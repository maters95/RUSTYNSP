using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using NSP.SettingsFramework;
using NSP.UserInterface;
using b;
using c;

namespace B
{
	internal class BV : Form
	{
		private string Wg = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wk();

		private IContainer WH;

		private Label Wh;

		private ThemedTextBox WI;

		private ThemedButton Wi;

		private ThemedButton WJ;

		internal BV()
		{
			a();
		}

		[SpecialName]
		internal string A()
		{
			return Wg;
		}

		[SpecialName]
		internal void A(string P_0)
		{
			Wg = P_0;
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			if ((int)((Form)this).DialogResult == 1)
			{
				if (((Control)WI).Text.Length == 0)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WL(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					((CancelEventArgs)P_1).Cancel = true;
				}
				else
				{
					Wg = ((Control)WI).Text;
				}
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			((Control)WI).BackColor = BM.to;
			((Control)WI).ForeColor = BM.te;
			((Control)WI).Text = Wg;
			((Control)WI).Focus();
			((TextBoxBase)WI).SelectAll();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && WH != null)
			{
				((System.IDisposable)WH).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Expected O, but got Unknown
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected O, but got Unknown
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Expected O, but got Unknown
			Wh = new Label();
			WI = new ThemedTextBox();
			Wi = new ThemedButton();
			WJ = new ThemedButton();
			((Control)this).SuspendLayout();
			((Control)Wh).AutoSize = true;
			((Control)Wh).Location = new Point(10, 9);
			((Control)Wh).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)Wh).Size = new Size(150, 13);
			((Control)Wh).TabIndex = 0;
			((Control)Wh).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wl();
			((Control)WI).Location = new Point(13, 25);
			((Control)WI).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WM();
			((Control)WI).Size = new Size(228, 22);
			((Control)WI).TabIndex = 1;
			((Button)Wi).DialogResult = (DialogResult)1;
			((Control)Wi).Location = new Point(20, 57);
			((Control)Wi).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)Wi).Size = new Size(100, 30);
			((Control)Wi).TabIndex = 2;
			((Control)Wi).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)Wi).UseVisualStyleBackColor = true;
			((Button)WJ).DialogResult = (DialogResult)2;
			((Control)WJ).Location = new Point(134, 57);
			((Control)WJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)WJ).Size = new Size(100, 30);
			((Control)WJ).TabIndex = 3;
			((Control)WJ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)WJ).UseVisualStyleBackColor = true;
			((Form)this).AcceptButton = (IButtonControl)(object)Wi;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)WJ;
			((Form)this).ClientSize = new Size(255, 100);
			((Control)this).Controls.Add((Control)(object)WJ);
			((Control)this).Controls.Add((Control)(object)Wi);
			((Control)this).Controls.Add((Control)(object)WI);
			((Control)this).Controls.Add((Control)(object)Wh);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wm();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WN();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class Bv : Form
	{
		private string Wj = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wn();

		private IContainer WK;

		private Label Wk;

		private ThemedTextBox WL;

		private ThemedButton Wl;

		private ThemedButton WM;

		internal Bv()
		{
			a();
		}

		[SpecialName]
		internal string A()
		{
			return Wj;
		}

		[SpecialName]
		internal void A(string P_0)
		{
			Wj = P_0;
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			if ((int)((Form)this).DialogResult == 1)
			{
				if (((Control)WL).Text.Length == 0)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UD(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					((CancelEventArgs)P_1).Cancel = true;
				}
				else
				{
					Wj = ((Control)WL).Text;
				}
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			((Control)WL).BackColor = BM.to;
			((Control)WL).ForeColor = BM.te;
			((Control)WL).Text = Wj;
			((Control)WL).Focus();
			((TextBoxBase)WL).SelectAll();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && WK != null)
			{
				((System.IDisposable)WK).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0256: Expected O, but got Unknown
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Expected O, but got Unknown
			//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ba: Expected O, but got Unknown
			Wk = new Label();
			WL = new ThemedTextBox();
			Wl = new ThemedButton();
			WM = new ThemedButton();
			((Control)this).SuspendLayout();
			((Control)Wk).AutoSize = true;
			((Control)Wk).Location = new Point(10, 9);
			((Control)Wk).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)Wk).Size = new Size(117, 13);
			((Control)Wk).TabIndex = 0;
			((Control)Wk).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WO();
			((Control)WL).Location = new Point(13, 25);
			((Control)WL).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ue();
			((Control)WL).Size = new Size(228, 22);
			((Control)WL).TabIndex = 1;
			((Button)Wl).DialogResult = (DialogResult)1;
			((Control)Wl).Location = new Point(20, 57);
			((Control)Wl).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)Wl).Size = new Size(100, 30);
			((Control)Wl).TabIndex = 2;
			((Control)Wl).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)Wl).UseVisualStyleBackColor = true;
			((Button)WM).DialogResult = (DialogResult)2;
			((Control)WM).Location = new Point(134, 57);
			((Control)WM).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)WM).Size = new Size(100, 30);
			((Control)WM).TabIndex = 3;
			((Control)WM).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)WM).UseVisualStyleBackColor = true;
			((Form)this).AcceptButton = (IButtonControl)(object)Wl;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)WM;
			((Form)this).ClientSize = new Size(255, 100);
			((Control)this).Controls.Add((Control)(object)WM);
			((Control)this).Controls.Add((Control)(object)Wl);
			((Control)this).Controls.Add((Control)(object)WL);
			((Control)this).Controls.Add((Control)(object)Wk);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wo();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WP();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
namespace b
{
	internal class bV
	{
		internal enum A : byte
		{
			Brc,
			BrD,
			Brd,
			BrE,
			Bre,
			BrF
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class a
		{
			public static readonly a Brf = new a();

			public static Action BrG;

			public static Converter<string, int> Brg;

			internal void A()
			{
				//IL_0012: Unknown result type (might be due to invalid IL or missing references)
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdG(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdg(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}

			internal int A(string P_0)
			{
				return int.Parse(P_0);
			}
		}

		private Framework aXO;

		private string aXo;

		private int aXP;

		private List<string> aXp = new List<string>();

		internal const int aXQ = 20;

		internal bV(Framework P_0, string P_1)
		{
			aXO = P_0;
			aXo = P_1;
			aXP = 0;
		}

		internal A A()
		{
			//IL_0451: Unknown result type (might be due to invalid IL or missing references)
			//IL_0456: Unknown result type (might be due to invalid IL or missing references)
			//IL_045c: Expected O, but got Unknown
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Invalid comparison between Unknown and I4
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Expected O, but got Unknown
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected O, but got Unknown
			Stream val = null;
			try
			{
				val = (Stream)(object)S.a(aXo, M.a());
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahC() + ex.Message, true);
				return bV.A.BrD;
			}
			bool flag;
			try
			{
				flag = R.A(val);
			}
			catch (System.Exception)
			{
				flag = false;
			}
			XmlReader val2 = null;
			Stream val3 = null;
			try
			{
				if (flag)
				{
					if (!R.A(val, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agH(), out val3, null))
					{
						val.Close();
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahc(), true);
						return bV.A.BrD;
					}
				}
				else
				{
					val3 = val;
				}
				val2 = XmlReader.Create(val3);
			}
			catch (System.Exception ex3)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahD() + ex3.Message, true);
				return bV.A.BrD;
			}
			A result = bV.A.Bre;
			bool flag2 = false;
			try
			{
				val2.Read();
				while ((int)val2.NodeType != 1)
				{
					val2.Read();
				}
				if (!val2.IsEmptyElement)
				{
					if (aXO.awZ != int.Parse(val2.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agh())) || aXO.awz != int.Parse(val2.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agI())) || aXO.aXA != new k(val2.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bU()), false))
					{
						result = bV.A.Brd;
						throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahd());
					}
					aXO.aXa = val2.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agi());
					bool flag3 = bx.A(aXO.awZ);
					Version val4 = (((!flag3 || !(aXO.aXA >= new k(3, 0, 0, 0, 0))) && flag3) ? new Version(0, 0, 0) : new Version(aXO.aXa));
					if (Assembly.GetEntryAssembly().GetName().Version < val4)
					{
						result = bV.A.BrE;
						throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahE());
					}
					flag2 = true;
					val2.Read();
					while (val2.IsStartElement())
					{
						bool flag4 = true;
						string name = val2.Name;
						if (name == null)
						{
							goto IL_0404;
						}
						switch (name.Length)
						{
						case 5:
							break;
						case 8:
							goto IL_0251;
						case 17:
							goto IL_026c;
						case 9:
							goto IL_0282;
						case 6:
							goto IL_02f0;
						case 10:
							goto IL_0306;
						case 13:
							goto IL_031c;
						case 18:
							goto IL_0332;
						default:
							goto IL_0404;
						}
						char c = name[0];
						if (c != 'T')
						{
							if (c != 'U' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ck()))
							{
								goto IL_0404;
							}
							if (!val2.IsEmptyElement)
							{
								B(val2);
							}
						}
						else
						{
							if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahf()))
							{
								goto IL_0404;
							}
							if (!val2.IsEmptyElement)
							{
								E(val2);
							}
						}
						goto IL_0407;
						IL_026c:
						if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahe()))
						{
							goto IL_0404;
						}
						if (!val2.IsEmptyElement)
						{
							A(val2);
						}
						goto IL_0407;
						IL_02f0:
						if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahH()))
						{
							goto IL_0404;
						}
						if (!val2.IsEmptyElement)
						{
							f(val2);
						}
						goto IL_0407;
						IL_0332:
						if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahi()))
						{
							goto IL_0404;
						}
						if (!val2.IsEmptyElement)
						{
							b(val2);
						}
						goto IL_0407;
						IL_0282:
						if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahF()))
						{
							goto IL_0404;
						}
						if (!val2.IsEmptyElement)
						{
							a(val2);
						}
						goto IL_0407;
						IL_0251:
						c = name[0];
						if (c != 'M')
						{
							if (c != 'S' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahG()))
							{
								goto IL_0404;
							}
							if (!val2.IsEmptyElement)
							{
								C(val2);
							}
						}
						else
						{
							if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahg()))
							{
								goto IL_0404;
							}
							if (!val2.IsEmptyElement)
							{
								F(val2);
							}
						}
						goto IL_0407;
						IL_031c:
						if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahI()))
						{
							goto IL_0404;
						}
						if (!val2.IsEmptyElement)
						{
							g(val2);
						}
						goto IL_0407;
						IL_0407:
						if (!flag4)
						{
							val2.Skip();
						}
						else
						{
							val2.Read();
						}
						continue;
						IL_0404:
						flag4 = false;
						goto IL_0407;
						IL_0306:
						if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahh()))
						{
							goto IL_0404;
						}
						if (!val2.IsEmptyElement)
						{
							G(val2);
						}
						goto IL_0407;
					}
				}
				result = bV.A.Brc;
			}
			catch (System.Exception)
			{
				if (flag2 && !BM.qW)
				{
					BM qQ = BM.QQ;
					object obj = bV.a.BrG;
					if (obj == null)
					{
						Action val5 = delegate
						{
							//IL_0012: Unknown result type (might be due to invalid IL or missing references)
							bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdG(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdg(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						};
						bV.a.BrG = val5;
						obj = (object)val5;
					}
					((Control)qQ).Invoke((Action)obj);
				}
			}
			finally
			{
				try
				{
					if (val2 != null)
					{
						val2.Close();
					}
				}
				catch
				{
				}
				try
				{
					if (val3 != null)
					{
						val3.Close();
					}
				}
				catch
				{
				}
				try
				{
					if (val != null)
					{
						val.Close();
					}
				}
				catch
				{
				}
			}
			return result;
		}

		private void A(XmlReader P_0)
		{
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Invalid comparison between Unknown and I4
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Invalid comparison between Unknown and I4
			//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Invalid comparison between Unknown and I4
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Invalid comparison between Unknown and I4
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Invalid comparison between Unknown and I4
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Invalid comparison between Unknown and I4
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Invalid comparison between Unknown and I4
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Invalid comparison between Unknown and I4
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Invalid comparison between Unknown and I4
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Invalid comparison between Unknown and I4
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Invalid comparison between Unknown and I4
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Invalid comparison between Unknown and I4
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Invalid comparison between Unknown and I4
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Invalid comparison between Unknown and I4
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Invalid comparison between Unknown and I4
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahe()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cv() && (int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					P_0.Read();
					aXO.awY = P_0.Value;
					P_0.Skip();
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aT() && (int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					P_0.Read();
					aXO.awy = P_0.Value;
					P_0.Skip();
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahJ() && (int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					P_0.Read();
					aXO.aXB = P_0.Value;
					P_0.Skip();
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahj() && (int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					P_0.Read();
					aXO.aXb = P_0.Value;
					P_0.Skip();
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahK() && (int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					P_0.Read();
					aXO.aXC = P_0.Value;
					P_0.Skip();
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahk() && (int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					aXO.aWR = bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
				}
				P_0.Read();
			}
		}

		private void a(XmlReader P_0)
		{
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Invalid comparison between Unknown and I4
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Invalid comparison between Unknown and I4
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Invalid comparison between Unknown and I4
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Invalid comparison between Unknown and I4
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Invalid comparison between Unknown and I4
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahF()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahl() && (int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					aXO.aXL.Add(new ValueTuple<byte, byte>(byte.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acm())), byte.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acN()))));
				}
				P_0.Read();
			}
		}

		private void B(XmlReader P_0)
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Invalid comparison between Unknown and I4
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Invalid comparison between Unknown and I4
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Invalid comparison between Unknown and I4
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Invalid comparison between Unknown and I4
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Invalid comparison between Unknown and I4
			Units units = new Units();
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ck()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahM())
				{
					A(P_0, units);
				}
				else if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahm(), (object)P_0.Name));
				}
				P_0.Read();
			}
			aXO.aXK = units;
		}

		private void A(XmlReader P_0, Units P_1)
		{
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Invalid comparison between Unknown and I4
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Invalid comparison between Unknown and I4
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Invalid comparison between Unknown and I4
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Invalid comparison between Unknown and I4
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Invalid comparison between Unknown and I4
			QuantityType quantityType = new QuantityType();
			int num = (quantityType.UnitType = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahM()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahN())
				{
					A(P_0, quantityType);
				}
				else if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahn(), (object)P_0.Name));
				}
				P_0.Read();
			}
			P_1.QuantityTypesPerUnitType.Add(num, quantityType);
		}

		private void A(XmlReader P_0, QuantityType P_1)
		{
			Unit unit = new Unit();
			unit.ListItemVal = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahO()));
			unit.ListItemText = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aho());
			P_1.UnitsList.Add(unit);
		}

		private void b(XmlReader P_0)
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Invalid comparison between Unknown and I4
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Invalid comparison between Unknown and I4
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Invalid comparison between Unknown and I4
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Invalid comparison between Unknown and I4
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Invalid comparison between Unknown and I4
			GlobalImageLibrary globalImageLibrary = new GlobalImageLibrary();
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahi()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahP())
				{
					A(P_0, globalImageLibrary);
				}
				else if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahp(), (object)P_0.Name));
				}
				P_0.Read();
			}
			aXO.aXk = globalImageLibrary;
		}

		private void A(XmlReader P_0, GlobalImageLibrary P_1)
		{
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bt());
			P_0.Read();
			string value = P_0.Value;
			P_1.ImageItemList.Add(attribute, new ImageItem(value));
			P_0.Skip();
		}

		private void C(XmlReader P_0)
		{
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Invalid comparison between Unknown and I4
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Invalid comparison between Unknown and I4
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Invalid comparison between Unknown and I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Invalid comparison between Unknown and I4
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Invalid comparison between Unknown and I4
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Invalid comparison between Unknown and I4
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Invalid comparison between Unknown and I4
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Invalid comparison between Unknown and I4
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Invalid comparison between Unknown and I4
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Invalid comparison between Unknown and I4
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Invalid comparison between Unknown and I4
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Invalid comparison between Unknown and I4
			string text = string.Empty;
			P_0.Read();
			while (P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13)
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahG() && (int)P_0.NodeType == 15)
				{
					aXO.H();
					break;
				}
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ce() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aFU())
				{
					text = (((int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) ? string.Empty : P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ()));
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahq() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahR())
				{
					a(P_0, text, null);
				}
				else if ((P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RP() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl()) && (int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					A(P_0, text, null);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahr() && (int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					D(P_0);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahS() && (int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					c(P_0);
				}
				else
				{
					if (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md()) && !(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs()))
					{
						throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahT(), (object)P_0.Name));
					}
					P_0.Read();
					while ((int)P_0.NodeType != 15 || (P_0.Name != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() && P_0.Name != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs()))
					{
						P_0.Read();
					}
				}
				P_0.Read();
			}
		}

		private void c(XmlReader P_0)
		{
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Invalid comparison between Unknown and I4
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Unknown result type (might be due to invalid IL or missing references)
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
			Dictionary<string, string> val = new Dictionary<string, string>();
			bool visible = false;
			bool.TryParse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aht()), ref visible);
			aXO.aWW.Visible = visible;
			P_0.Read();
			int num = default(int);
			int severityArrayDataId = default(int);
			int modeArrayDataId = default(int);
			int statusArrayDataId = default(int);
			while (P_0.Name != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahS())
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm() && P_0.IsStartElement())
				{
					val = new Dictionary<string, string>();
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm() && (int)P_0.NodeType == 15)
				{
					if (!string.IsNullOrEmpty(text) && !aXO.aWW.ErrorDefs.ContainsKey(text))
					{
						if (val.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KX()) && int.TryParse(val[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KX()], ref num) && val.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kx()))
						{
							aXO.aWW.ErrorIndexToCodeMap.Add(num, val[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kx()]);
						}
						aXO.aWW.ErrorDefs.Add(text, val);
					}
				}
				else if ((P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs()) && P_0.IsStartElement())
				{
					string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
					if (attribute != null)
					{
						if (attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kw())
						{
							string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahU());
							val.Add(attribute, attribute2);
						}
						else
						{
							P_0.Read();
							string value = P_0.Value;
							if (attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahu())
							{
								if (!int.TryParse(value, ref severityArrayDataId))
								{
									throw new ArgumentException(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahV());
								}
								aXO.aWW.SeverityArrayDataId = severityArrayDataId;
							}
							else if (attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahv())
							{
								if (!int.TryParse(value, ref modeArrayDataId))
								{
									throw new ArgumentException(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahW());
								}
								aXO.aWW.ModeArrayDataId = modeArrayDataId;
							}
							else if (attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahw())
							{
								if (!int.TryParse(value, ref statusArrayDataId))
								{
									throw new ArgumentException(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahX());
								}
								aXO.aWW.StatusArrayDataId = statusArrayDataId;
							}
							else
							{
								if (attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kx())
								{
									text = value;
								}
								val.Add(attribute, value);
							}
						}
					}
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahx() && P_0.IsStartElement())
				{
					P_0.Read();
					string value2 = P_0.Value;
					if (!(value2 != string.Empty))
					{
						throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahY());
					}
					string[] array = value2.Split('|', (StringSplitOptions)0);
					if (array.Length != 0)
					{
						aXO.aWW.ErrorToSettingMap = System.Array.ConvertAll<string, int>(array, (Converter<string, int>)((string P_0) => int.Parse(P_0)));
					}
				}
				P_0.Read();
			}
		}

		private void D(XmlReader P_0)
		{
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Invalid comparison between Unknown and I4
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahy());
			if (attribute == null)
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahZ());
			}
			DataTableObject dataTableObject;
			if (aXO.awx.ContainsKey(attribute))
			{
				dataTableObject = aXO.awx[attribute];
			}
			else
			{
				dataTableObject = new DataTableObject();
				dataTableObject.Name = attribute;
				aXO.awx.Add(attribute, dataTableObject);
			}
			bool flag = default(bool);
			if (attribute2 != null && bool.TryParse(attribute2, ref flag))
			{
				dataTableObject.IsErrorTable = true;
				bool visible = default(bool);
				bool flag2 = default(bool);
				int num = default(int);
				bool isMapped2 = default(bool);
				bool isMapped = default(bool);
				int maxChars = default(int);
				bool bulkEdit = default(bool);
				while (P_0.IsStartElement() && (int)P_0.NodeType != 15)
				{
					if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIA())
					{
						DataTableColumn dataTableColumn = new DataTableColumn();
						string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIa());
						string attribute4 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIB());
						string attribute5 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIb());
						string attribute6 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIC());
						string attribute7 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIc());
						string attribute8 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aID());
						string attribute9 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aht());
						string attribute10 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aId());
						string attribute11 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIE());
						string attribute12 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIe());
						string attribute13 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIF());
						string attribute14 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIf());
						string attribute15 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIG());
						if (attribute9 != null && bool.TryParse(attribute9, ref visible))
						{
							dataTableColumn.Visible = visible;
						}
						else
						{
							dataTableColumn.Visible = true;
						}
						dataTableColumn.MenuLink = attribute10;
						dataTableColumn.Tooltip = attribute13;
						DataTableColumnType dataTableColumnType = DataTableColumnType.Text;
						if (attribute4 == null)
						{
							throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIh() + attribute + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aII());
						}
						if (!(attribute4 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIg()))
						{
							if (attribute4 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIH())
							{
								dataTableColumnType = DataTableColumnType.Enum;
							}
						}
						else
						{
							dataTableColumnType = DataTableColumnType.Text;
						}
						if (bool.TryParse(attribute14, ref flag2) && flag2)
						{
							ErrorPanelItem errorPanelItem = new ErrorPanelItem
							{
								Type = dataTableColumnType,
								Text = attribute15,
								ErrorDefKey = attribute3,
								DataId = (int.TryParse(attribute6, ref num) ? num : (-1))
							};
							aXO.aWW.ErrorPanel.Add(errorPanelItem);
						}
						DataGridViewAutoSizeColumnMode autoSize = (DataGridViewAutoSizeColumnMode)1;
						if (attribute12 != null)
						{
							if (!(attribute12 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIa()))
							{
								if (attribute12 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIi())
								{
									autoSize = (DataGridViewAutoSizeColumnMode)16;
								}
							}
							else
							{
								autoSize = (DataGridViewAutoSizeColumnMode)2;
							}
						}
						dataTableColumn.AutoSize = autoSize;
						switch (dataTableColumnType)
						{
						case DataTableColumnType.Text:
							dataTableColumn.Type = DataTableColumnType.Text;
							if (attribute3 != null)
							{
								dataTableColumn.HeaderText = attribute3;
								if (attribute5 != null)
								{
									dataTableColumn.PFieldId = attribute5;
								}
								if (attribute6 != null && attribute7 != null && attribute11 != null && bool.TryParse(attribute11, ref isMapped2))
								{
									dataTableColumn.BindingData = new BindingData
									{
										BindingDataId = attribute6,
										BindingType = ((!(attribute7 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIj())) ? DataTableBindType.TwoWay : DataTableBindType.OneWay),
										IsMapped = isMapped2
									};
									if (attribute8 != null)
									{
										dataTableColumn.EnumValueStr = attribute8;
									}
								}
								dataTableObject.Columns.Add(dataTableColumn);
								break;
							}
							throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIJ() + attribute + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aII());
						case DataTableColumnType.Enum:
							dataTableColumn.Type = DataTableColumnType.Enum;
							if (attribute3 != null && attribute6 != null && attribute7 != null && attribute11 != null && bool.TryParse(attribute11, ref isMapped))
							{
								if (attribute8 != null)
								{
									dataTableColumn.EnumValueStr = attribute8;
								}
								dataTableColumn.HeaderText = attribute3;
								dataTableColumn.BindingData = new BindingData
								{
									BindingDataId = attribute6,
									BindingType = ((!(attribute7 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIj())) ? DataTableBindType.TwoWay : DataTableBindType.OneWay),
									IsMapped = isMapped
								};
								dataTableObject.Columns.Add(dataTableColumn);
								break;
							}
							throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIK() + attribute + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aII());
						}
					}
					else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIk())
					{
						SearchFilter searchFilter = new SearchFilter();
						string attribute16 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIL());
						string attribute17 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIl());
						string attribute18 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIM());
						if (attribute16 != null && attribute17 != null && attribute18 != null && int.TryParse(attribute18, ref maxChars))
						{
							searchFilter.Text = attribute16;
							searchFilter.HeaderStr = attribute17;
							searchFilter.MaxChars = maxChars;
							dataTableObject.Filters.Add((IFilter)searchFilter);
						}
					}
					else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIm())
					{
						CheckboxFilter checkboxFilter = new CheckboxFilter();
						string attribute19 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIL());
						string attribute20 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIa());
						string attribute21 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIN());
						string attribute22 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIn());
						if (bool.TryParse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIO()), ref bulkEdit))
						{
							checkboxFilter.BulkEdit = bulkEdit;
						}
						else
						{
							checkboxFilter.BulkEdit = false;
						}
						if (attribute19 != null && attribute20 != null)
						{
							checkboxFilter.Text = attribute19;
							checkboxFilter.Header = attribute20;
							if (attribute21 != null)
							{
								checkboxFilter.OptionsStr = attribute21;
							}
							else
							{
								if (attribute22 == null)
								{
									throw new ArgumentException(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIo());
								}
								checkboxFilter.EnumSrcDataId = attribute22;
							}
							dataTableObject.Filters.Add((IFilter)checkboxFilter);
						}
					}
					P_0.Read();
				}
				return;
			}
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahz());
		}

		private void A(XmlReader P_0, string P_1, SettingOrSpecialObject P_2)
		{
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_0309: Invalid comparison between Unknown and I4
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Invalid comparison between Unknown and I4
			//IL_030f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Invalid comparison between Unknown and I4
			//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cd: Invalid comparison between Unknown and I4
			//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d7: Invalid comparison between Unknown and I4
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			int num = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIp());
			int num2 = -1;
			num2 = ((attribute2 == null) ? aXP : int.Parse(attribute2));
			Setting setting = (attribute.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIQ()) ? new Table(aXO, attribute, num, num2, P_2, P_1) : ((attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIq()) ? new SensorCalibration(aXO, attribute, num, num2, P_2, P_1) : ((attribute.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIR()) || attribute.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIr()) || attribute.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIS())) ? new Dn(aXO, attribute, num, num2, P_2, P_1) : (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIs()) ? new Do(aXO, attribute, num, num2, P_2, P_1) : ((!attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIT()) || !attribute.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIt())) ? new Setting(aXO, false, attribute, num, num2, P_2, P_1) : new Dk(aXO, attribute, num, num2, P_2, P_1))))));
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && ((!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RP()) && !(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl())) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs())
				{
					A(P_0, setting, -1, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mP() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIU())
				{
					B(P_0, P_1, setting);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vd() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIu())
				{
					if (!P_0.IsEmptyElement)
					{
						P_0.Skip();
					}
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIV())
				{
					A(P_0, setting);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIv())
				{
					a(P_0, setting);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIW())
				{
					B(P_0, setting);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahq() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahR())
				{
					a(P_0, P_1, setting);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RP() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl())
				{
					A(P_0, P_1, setting);
				}
				else if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIw(), (object)P_0.Name));
				}
				P_0.Read();
			}
			if (P_2 == null)
			{
				aXO.aWS.Add((SettingOrSpecialObject)setting);
			}
			else
			{
				P_2.a().Add((SettingOrSpecialObject)setting);
			}
			aXO.aWs.Add(setting.C(), setting);
			if (((SettingOrSpecialObject)setting).r() != -1)
			{
				aXO.aWT.Add(((SettingOrSpecialObject)setting).r(), (SettingOrSpecialObject)setting);
			}
			if (PortFunction.a(setting))
			{
				aXO.awD.Add((SettingOrSpecialObject)setting);
			}
			if (setting is Dn)
			{
				aXO.awd.Add(setting as Dn);
			}
			if (setting.s().Length != 0)
			{
				aXO.aWu.Add(setting);
			}
			if (setting.aJ())
			{
				aXO.aWt.Add(setting);
				if (attribute2 == null)
				{
					setting.A(-1);
				}
			}
			else
			{
				if (attribute2 == null)
				{
					aXP += setting.BB();
				}
				if (num > aXO.aWr)
				{
					aXO.aWr = num;
				}
			}
			if (attribute2 != null && setting.a() != -1)
			{
				if (setting.aJ())
				{
					for (int i = 0; i < setting.BB(); i++)
					{
						aXO.aWQ[setting.a() + i] = setting.A();
					}
					int num3 = setting.a() + setting.BB();
					if (num3 > aXO.aWn)
					{
						aXO.aWn = num3;
					}
				}
				else
				{
					for (int j = 0; j < setting.BB(); j++)
					{
						aXO.aWp[setting.a() + j] = setting.C();
					}
				}
			}
			if (num == 10195)
			{
				setting.d(true);
			}
			if (setting is Table)
			{
				aXO.aWV.Add(setting as Table);
			}
			if (setting.u() != 0)
			{
				aXO.awf.Add(setting.u(), setting);
			}
			if (((SettingOrSpecialObject)setting).G() != 0)
			{
				aXO.awG.Add(((SettingOrSpecialObject)setting).G(), (SettingOrSpecialObject)setting);
			}
		}

		private void a(XmlReader P_0, string P_1, SettingOrSpecialObject P_2)
		{
			//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04eb: Invalid comparison between Unknown and I4
			//IL_033a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Invalid comparison between Unknown and I4
			//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f8: Invalid comparison between Unknown and I4
			//IL_0735: Unknown result type (might be due to invalid IL or missing references)
			//IL_073a: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04af: Invalid comparison between Unknown and I4
			//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b9: Invalid comparison between Unknown and I4
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			SpecialObject specialObject = ((attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIX()) ? new DI(aXO, attribute, P_2, P_1) : (attribute.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIx()) ? new DO(aXO, attribute, P_2, P_1) : (attribute.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIY()) ? new Dm(aXO, attribute, P_2, P_1) : ((attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIy()) ? new WiFiSetup(aXO, attribute, P_2, P_1) : ((attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIZ()) ? new TableAxis(aXO, AxisType.Column, attribute, P_2, P_1) : ((attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIz()) ? new TableAxis(aXO, AxisType.Row, attribute, P_2, P_1) : ((attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiA()) ? new TableAxis(aXO, AxisType.Slice, attribute, P_2, P_1) : ((attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aia()) ? new ChannelsProperties(aXO, attribute, P_2, P_1) : ((attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiB()) ? new KnockDetection(aXO, attribute, P_2, P_1) : (attribute.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aib()) ? new BezierCurve(aXO, attribute, P_2, P_1) : (attribute.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiC()) ? new StateMachine(aXO, attribute, P_2, P_1) : (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aic()) ? new StateMachineStage(aXO, attribute, P_2, P_1) : (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiD()) ? new StateMachineError(aXO, attribute, P_2, P_1) : (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aid()) ? new FilterOption(aXO, attribute, P_2, P_1) : (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiE()) ? new OnOffSwitchingPoint(aXO, attribute, P_2, P_1) : ((attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aie()) ? new Di(aXO, attribute, P_2, P_1) : (attribute.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiF()) ? new DL(aXO, attribute, P_2, P_1) : (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIT()) ? new DK(aXO, attribute, P_2, P_1) : ((attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aif()) ? new Dj(aXO, attribute, P_2, P_1) : (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiG()) ? new DJ(aXO, attribute, P_2, P_1) : ((attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aig()) ? new DM(aXO, attribute, P_2, P_1) : (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiH()) ? new Dl(aXO, attribute, P_2, P_1) : ((!attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aih())) ? new SpecialObject(aXO, attribute, P_2, P_1) : new DN(aXO, attribute, P_2, P_1))))))))))))))))))))))));
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && ((!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahq()) && !(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahR())) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs())
				{
					A(P_0, specialObject, -1, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vd() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIu())
				{
					if (!P_0.IsEmptyElement)
					{
						P_0.Skip();
					}
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIV())
				{
					A(P_0, specialObject);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RP() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl())
				{
					A(P_0, P_1, specialObject);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahq() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahR())
				{
					a(P_0, P_1, specialObject);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiI() && specialObject is DO)
				{
					A(P_0, specialObject as DO);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aii() && specialObject is DO)
				{
					a(P_0, specialObject as DO);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiJ())
				{
					d(P_0);
				}
				else if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aij(), (object)P_0.Name));
				}
				P_0.Read();
			}
			if (P_2 == null)
			{
				aXO.aWS.Add((SettingOrSpecialObject)specialObject);
			}
			else
			{
				P_2.a().Add((SettingOrSpecialObject)specialObject);
			}
			if (specialObject.r() != -1)
			{
				aXO.aWT.Add(specialObject.r(), (SettingOrSpecialObject)specialObject);
			}
			if (specialObject is DI)
			{
				aXO.awI = specialObject as DI;
			}
			if (specialObject.A().ayR != 0)
			{
				if (!aXO.awb.ContainsKey(specialObject.A().ayR))
				{
					aXO.awb.Add(specialObject.A().ayR, new List<Connector>());
				}
				aXO.awb[specialObject.A().ayR].Add(specialObject.A());
			}
			if (!string.IsNullOrEmpty(specialObject.a().BbR))
			{
				aXO.awc.Add(specialObject.a());
				if (P_2 is SpecialObject specialObject2 && !string.IsNullOrEmpty(specialObject2.A().ayr))
				{
					if (specialObject2.A().ayS == null)
					{
						specialObject2.A().ayS = new SortedList<int, WiringPin>();
					}
					if (specialObject.a().BbT != -1)
					{
						specialObject2.A().ayS.Add(specialObject.a().BbT, specialObject.a());
					}
					else
					{
						string text = string.Empty;
						string bbs = specialObject.a().Bbs;
						foreach (char c in bbs)
						{
							if (char.IsDigit(c))
							{
								System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(text);
								char c2 = c;
								text = string.Concat(readOnlySpan, new System.ReadOnlySpan<char>(ref c2));
							}
						}
						int num = ((text.Length != 0) ? int.Parse(text) : specialObject2.A().ayS.Count);
						specialObject2.A().ayS.Add(num, specialObject.a());
					}
				}
			}
			if (PortFunction.a(specialObject))
			{
				aXO.awD.Add((SettingOrSpecialObject)specialObject);
			}
			if (specialObject.F().Bbb != -1)
			{
				aXO.aWY.Add((SettingOrSpecialObject)specialObject);
				Enumerator<SettingOrSpecialObject> enumerator = ((SettingOrSpecialObject)specialObject).a().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						if (!(enumerator.Current is Setting setting) || setting.aG() != 1 || !setting.U())
						{
							continue;
						}
						List<Setting.ListItems.A> val = setting.d(0);
						if ((val.Count != 2 && val.Count != 3) || (!((SettingOrSpecialObject)setting).B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ff()) && !((SettingOrSpecialObject)setting).B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FG()) && !((SettingOrSpecialObject)setting).B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fg())) || ((SettingOrSpecialObject)setting).B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiK()) || !val[0].bBV.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aik()) || !val[1].bBV.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FG()))
						{
							continue;
						}
						Setting setting2 = setting;
						setting2.d(true);
						if (!(setting2 is Do))
						{
							aXO.aWZ.Add(setting2.A());
							if (((SettingOrSpecialObject)specialObject).a().IndexOf((SettingOrSpecialObject)setting2) != 0)
							{
								((SettingOrSpecialObject)specialObject).a().Remove((SettingOrSpecialObject)setting2);
								((SettingOrSpecialObject)specialObject).a().Insert(0, (SettingOrSpecialObject)setting2);
							}
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			if (specialObject is WiFiSetup)
			{
				aXO.aWZ.Add(10195);
			}
			if (specialObject is DO)
			{
				int num2 = ((SettingOrSpecialObject)(specialObject as DO)).d();
				aXO.awF.Add(num2, specialObject as DO);
			}
			if (specialObject is Dm)
			{
				Dm dm = specialObject as Dm;
				if (!string.IsNullOrEmpty(dm.A()))
				{
					aXO.aWv.Add(dm.A(), dm);
				}
			}
			if (aXO.awh == null && specialObject.f().DataIdOfChannelListSetting != 0)
			{
				aXO.awh = specialObject;
			}
			if (specialObject is KnockDetection)
			{
				aXO.awO = specialObject as KnockDetection;
			}
			if (specialObject is Di)
			{
				aXO.awP = specialObject as Di;
			}
			if (specialObject is Dj)
			{
				aXO.awp = specialObject as Dj;
			}
			if (specialObject is DM)
			{
				aXO.awQ = specialObject as DM;
			}
			if (specialObject is DL)
			{
				aXO.awq.Add(specialObject as DL);
			}
			if (specialObject.G() != 0)
			{
				aXO.awG.Add(specialObject.G(), (SettingOrSpecialObject)specialObject);
			}
			if (aXp.Contains(attribute))
			{
				if (aXO.aWY.Contains((SettingOrSpecialObject)specialObject))
				{
					aXO.aWx.Add((SettingOrSpecialObject)specialObject);
				}
			}
			else
			{
				aXp.Add(attribute);
			}
		}

		private void B(XmlReader P_0, string P_1, SettingOrSpecialObject P_2)
		{
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Invalid comparison between Unknown and I4
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Invalid comparison between Unknown and I4
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Invalid comparison between Unknown and I4
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Invalid comparison between Unknown and I4
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Invalid comparison between Unknown and I4
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			int num = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIp());
			int num2 = -1;
			num2 = ((attribute2 == null) ? aXP : int.Parse(attribute2));
			Setting setting = new Setting(aXO, true, attribute, num, num2, P_2, P_1);
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && ((!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mP()) && !(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIU())) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs())
				{
					A(P_0, setting, -1, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIv())
				{
					a(P_0, setting);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIW())
				{
					B(P_0, setting);
				}
				else if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiL(), (object)P_0.Name));
				}
				P_0.Read();
			}
			if (P_2 == null)
			{
				aXO.aWS.Add((SettingOrSpecialObject)setting);
			}
			else
			{
				P_2.a().Add((SettingOrSpecialObject)setting);
			}
			aXO.aWs.Add(setting.C(), setting);
			if (setting.s().Length != 0)
			{
				aXO.aWu.Add(setting);
			}
			if (attribute2 == null)
			{
				aXP += setting.BB();
			}
			if (attribute2 != null && setting.a() != -1)
			{
				for (int i = 0; i < setting.BB(); i++)
				{
					aXO.aWp[setting.a() + i] = setting.C();
				}
			}
		}

		private void A(XmlReader P_0, SettingOrSpecialObject P_1, int P_2, string P_3)
		{
			//IL_102f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1036: Expected O, but got Unknown
			//IL_15dc: Unknown result type (might be due to invalid IL or missing references)
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			if (string.IsNullOrEmpty(attribute))
			{
				throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ail() + P_1.B() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiM(), default(System.ReadOnlySpan<object>)));
			}
			string empty = string.Empty;
			string empty2 = string.Empty;
			bool flag = false;
			int num = 0;
			Setting setting = P_1 as Setting;
			if (attribute != null)
			{
				switch (attribute.Length)
				{
				case 8:
					switch (attribute[3])
					{
					case 'a':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGX()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.c(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
						}
						return;
					case 'o':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aim()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.a(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return;
					case 'm':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiN()))
						{
							break;
						}
						if (P_2 == -1 && setting != null)
						{
							setting.A(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
							if (setting.D())
							{
								aXO.aWw.Add(setting);
							}
						}
						return;
					case 'n':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ain()))
						{
							break;
						}
						if (A(P_0, ref num, ref flag, ref empty2))
						{
							setting?.A(bZ.aYO, num, flag, empty2, P_2);
						}
						return;
					case 'i':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiO()))
						{
							break;
						}
						if (setting != null)
						{
							if (P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()) == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajD())
							{
								setting.A(bZ.aYQ, 1, false, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay(), P_2);
							}
							else
							{
								setting.A(bZ.aYQ, 0, false, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay(), P_2);
							}
						}
						return;
					case 't':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aio()))
						{
							break;
						}
						if (A(P_0, ref num, ref flag, ref empty2))
						{
							setting?.A(bZ.aYP, num, flag, empty2, P_2);
						}
						if (P_2 == -1 && setting != null)
						{
							string attribute6 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajb());
							if (attribute6 != null)
							{
								setting.j(int.Parse(attribute6));
							}
							else
							{
								setting.j(0);
							}
						}
						return;
					case 'g':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fa()))
						{
							break;
						}
						A(P_0, ref empty);
						P_1.A(bz.aYt, empty, P_2);
						return;
					case 'u':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiP()))
						{
							break;
						}
						A(P_0, ref empty);
						P_1.A(bz.aYu, empty, P_2);
						return;
					case 'p':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aip()))
						{
							break;
						}
						A(P_0, ref empty);
						setting?.D(empty);
						return;
					case 'e':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiQ()))
						{
							break;
						}
						if (P_2 == -1)
						{
							P_1.C(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return;
					case 'L':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiq()))
						{
							break;
						}
						return;
					case 'w':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiR()))
						{
							break;
						}
						return;
					}
					break;
				case 10:
					switch (attribute[8])
					{
					case 'n':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.air()))
						{
							break;
						}
						if (P_2 == -1 && setting != null)
						{
							int[] array2 = new int[3];
							RuntimeHelpers.InitializeArray((System.Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
							int[] array3 = array2;
							string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL());
							if (attribute3 != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJX())
							{
								attribute3 = attribute3.Substring(1, attribute3.Length - 2);
								int num3 = attribute3.IndexOf(',');
								int num4 = attribute3.IndexOf(',', num3 + 1);
								array3[0] = int.Parse(attribute3.Substring(0, num3));
								array3[1] = int.Parse(attribute3.Substring(num3 + 1, num4 - (num3 + 1)));
								array3[2] = int.Parse(attribute3.Substring(num4 + 1));
							}
							setting.A(array3);
						}
						return;
					case 'u':
					{
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiS()))
						{
							break;
						}
						if (P_2 != -1 || setting == null)
						{
							return;
						}
						List<int> val = new List<int>();
						string attribute5 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL());
						if (attribute5.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJz()))
						{
							attribute5 = attribute5.Substring(1, attribute5.Length - 2);
							StringBuilder val2 = new StringBuilder();
							for (int j = 0; j < attribute5.Length; j++)
							{
								if (attribute5[j] != ',')
								{
									val2.Append(attribute5[j]);
									if (j == attribute5.Length - 1)
									{
										val.Add(int.Parse(((object)val2).ToString()));
									}
								}
								else
								{
									val.Add(int.Parse(((object)val2).ToString()));
									val2.Clear();
								}
							}
						}
						else
						{
							val.Add(int.Parse(attribute5));
						}
						setting.A(val);
						return;
					}
					case 'i':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ais()))
						{
							break;
						}
						if (A(P_0, ref num, ref flag, ref empty2))
						{
							setting?.A(bZ.aYm, num, flag, empty2, P_2);
						}
						return;
					case 'a':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiT()))
						{
							break;
						}
						if (A(P_0, ref num, ref flag, ref empty2))
						{
							setting?.A(bZ.aYN, num, flag, empty2, P_2);
						}
						return;
					case 'g':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ait()))
						{
							break;
						}
						if (A(P_0, ref num, ref flag, ref empty2))
						{
							setting?.A(bZ.aYo, num, flag, empty2, P_2);
						}
						return;
					case 'F':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiU()))
						{
							break;
						}
						A(P_0, ref empty);
						P_1.A(bz.aYv, empty, P_2);
						return;
					case 'm':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiu()))
						{
							break;
						}
						if (P_2 == -1)
						{
							P_1.B(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP())));
							string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aje());
							if (!string.IsNullOrEmpty(attribute2))
							{
								P_1.a(int.Parse(attribute2));
							}
						}
						return;
					case 'e':
					{
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kr()))
						{
							break;
						}
						string attribute4 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajF());
						if (attribute4 != null)
						{
							P_1.a(bool.Parse(attribute4));
						}
						A(P_0, ref empty);
						if (P_2 == -1)
						{
							P_1.B(empty);
						}
						return;
					}
					case 'I':
					{
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiV()))
						{
							break;
						}
						int dataId2 = default(int);
						if (P_1 is DN && int.TryParse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()), ref dataId2))
						{
							(P_1 as DN).A(new DataIdAndAttrId(dataId2));
						}
						return;
					}
					}
					break;
				case 12:
					switch (attribute[0])
					{
					case 'D':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiW()))
						{
							break;
						}
						if (P_2 == -1)
						{
							if (setting != null)
							{
								if (setting.aG() == 0)
								{
									throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aja());
								}
								string text = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL());
								if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJz()) && text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGk()))
								{
									text = text.Substring(1, text.Length - 2);
								}
								string[] array = text.Split(',', (StringSplitOptions)0);
								int num2 = setting.Ba();
								if (array.Length != num2)
								{
									throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajA());
								}
								setting.A(new byte[setting.BB()]);
								for (int i = 0; i < array.Length; i++)
								{
									N.A(int.Parse(array[i]), setting.aW(), i * setting.aG(), setting.aG(), aXO.aWR);
								}
								if (num2 > 1)
								{
									aXO.aWX = true;
								}
							}
							return;
						}
						throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajB());
					case 'M':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiw()))
						{
							break;
						}
						A(P_0, ref empty);
						P_1.A(bz.aYV, empty, P_2);
						return;
					case 'R':
					{
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiX()))
						{
							break;
						}
						int dataId = default(int);
						if (P_1 is DN && int.TryParse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()), ref dataId))
						{
							(P_1 as DN).a(new DataIdAndAttrId(dataId));
						}
						return;
					}
					case 'S':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aix()))
						{
							break;
						}
						return;
					}
					break;
				case 27:
					switch (attribute[0])
					{
					case 'S':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiY()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.B(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return;
					case 'D':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiy()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.h(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajd())));
						}
						return;
					}
					break;
				case 20:
					switch (attribute[10])
					{
					case 'A':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiZ()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.a(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return;
					case 'S':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiz()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.B(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return;
					case 'D':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJA()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.A(byte.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return;
					}
					break;
				case 31:
					switch (attribute[0])
					{
					case 'C':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJa()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.A(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIL()));
						}
						return;
					case 'A':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJB()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.F(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return;
					}
					break;
				case 19:
					switch (attribute[17])
					{
					case 'i':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJC()))
						{
							break;
						}
						if (A(P_0, ref num, ref flag, ref empty2))
						{
							setting?.A(bZ.aYR, num, flag, empty2, P_2);
						}
						return;
					case 'a':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJc()))
						{
							break;
						}
						if (A(P_0, ref num, ref flag, ref empty2))
						{
							setting?.A(bZ.aYr, num, flag, empty2, P_2);
						}
						return;
					}
					break;
				case 25:
					switch (attribute[0])
					{
					case 'C':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJD()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.b(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return;
					case 'D':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJd()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.A(new DataIdAndAttrId(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajd())), int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajE()))));
						}
						return;
					}
					break;
				case 18:
					switch (attribute[0])
					{
					case 'S':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJE()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.C(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						aXO.aWq = true;
						return;
					case 'I':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJe()))
						{
							break;
						}
						if (P_2 == -1)
						{
							int num6 = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajc()));
							A(P_0, ref empty);
							string text2 = empty;
							if (!aXO.awg.ContainsKey(num6))
							{
								aXO.awg.Add(num6, text2);
							}
						}
						return;
					case 'E':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJF()))
						{
							break;
						}
						if (P_2 == -1)
						{
							P_1.A(byte.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return;
					}
					break;
				case 15:
					switch (attribute[1])
					{
					case 'c':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJf()))
						{
							break;
						}
						if (P_2 == -1 && setting != null)
						{
							setting.b(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
							setting.C(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajb())));
						}
						return;
					case 't':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJG()))
						{
							break;
						}
						if (P_2 == -1 && P_1 is SpecialObject)
						{
							if ((P_1 as SpecialObject).C().IdleText != null)
							{
								(P_1 as SpecialObject).C().StatusChannelDataId = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
							}
							else if (P_1 is StateMachine)
							{
								(P_1 as StateMachine).StatusChannelDataId = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
							}
						}
						return;
					}
					break;
				case 13:
					switch (attribute[0])
					{
					case 'F':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJH()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.f(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajc())));
						}
						return;
					case 'R':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJh()))
						{
							break;
						}
						if (A(P_0, ref num, ref flag, ref empty2))
						{
							setting?.A(bZ.aYp, num, flag, empty2, P_2);
						}
						return;
					case 'V':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJI()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.a(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP())), P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajC()));
						}
						return;
					case 'H':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJi()))
						{
							break;
						}
						return;
					case 'S':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJJ()))
						{
							break;
						}
						return;
					}
					break;
				case 9:
					switch (attribute[5])
					{
					case 'a':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJj()))
						{
							break;
						}
						if (A(P_0, ref num, ref flag, ref empty2))
						{
							setting?.A(bZ.aYS, num, flag, empty2, P_2);
						}
						return;
					case 'N':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fB()))
						{
							break;
						}
						A(P_0, ref empty);
						P_1.A(bz.aYT, empty, P_2);
						return;
					case 'T':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJK()))
						{
							break;
						}
						if (P_2 == -1)
						{
							P_1.D(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
						}
						return;
					case 'b':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJk()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.E(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return;
					case 'r':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJL()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.h(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return;
					case 'C':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJl()))
						{
							break;
						}
						A(P_0, ref empty);
						P_1.c(empty);
						return;
					case 't':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJM()) && !(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJm()))
						{
							break;
						}
						return;
					case 'c':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJN()))
						{
							break;
						}
						return;
					}
					break;
				case 3:
					switch (attribute[1])
					{
					case 'i':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJn()))
						{
							break;
						}
						if (A(P_0, ref num, ref flag, ref empty2))
						{
							setting?.A(bZ.aYl, num, flag, empty2, P_2);
						}
						return;
					case 'a':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJO()))
						{
							break;
						}
						if (A(P_0, ref num, ref flag, ref empty2))
						{
							setting?.A(bZ.aYM, num, flag, empty2, P_2);
						}
						return;
					}
					break;
				case 7:
					switch (attribute[0])
					{
					case 'W':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJo()))
						{
							break;
						}
						if (A(P_0, ref num, ref flag, ref empty2))
						{
							setting?.A(bZ.aYn, num, flag, empty2, P_2);
						}
						return;
					case 'B':
					{
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJP()))
						{
							break;
						}
						int num5 = default(int);
						if (P_1 is DN && int.TryParse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()), ref num5))
						{
							A(P_0, ref empty);
							(P_1 as DN).A().Add(empty, num5);
						}
						return;
					}
					}
					break;
				case 16:
					switch (attribute[1])
					{
					case 'c':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJp()))
						{
							break;
						}
						if (A(P_0, ref num, ref flag, ref empty2))
						{
							setting?.A(bZ.aYL, num, flag, empty2, P_2);
						}
						return;
					case 'e':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJQ()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.K(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return;
					case 't':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJq()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.H(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajE())));
						}
						return;
					case 'l':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJR()))
						{
							break;
						}
						return;
					}
					break;
				case 11:
					switch (attribute[2])
					{
					case 'L':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJr()))
						{
							break;
						}
						if (setting != null)
						{
							if (P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()) == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajD())
							{
								setting.A(bZ.aYq, 1, false, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay(), P_2);
							}
							else
							{
								setting.A(bZ.aYq, 0, false, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay(), P_2);
							}
						}
						return;
					case 's':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aT()))
						{
							break;
						}
						A(P_0, ref empty);
						P_1.A(bz.aYU, empty, P_2);
						return;
					case 'y':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJS()))
						{
							break;
						}
						return;
					case 'P':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aga()))
						{
							break;
						}
						return;
					}
					break;
				case 14:
					switch (attribute[0])
					{
					case 'M':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJs()))
						{
							break;
						}
						A(P_0, ref empty);
						P_1.A(bz.aYW, empty, P_2);
						return;
					case 'I':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJT()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.f(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return;
					case 'R':
					{
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJt()))
						{
							break;
						}
						if (P_2 != -1 || setting == null)
						{
							return;
						}
						string[] array4 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajf()).Split(',', (StringSplitOptions)0);
						setting.A(new List<string>((System.Collections.Generic.IEnumerable<string>)array4));
						string attribute9 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajG());
						setting.A((global::A.A.C)int.Parse(attribute9));
						aXO.awv.Add(setting);
						if (!aXO.aww.ContainsKey(setting.z()))
						{
							aXO.aww.Add(setting.z(), setting.Z());
						}
						string attribute10 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajg());
						if (attribute10 != null)
						{
							setting.G(bool.Parse(attribute10));
							if (setting.aA())
							{
								aXO.awW = setting;
							}
						}
						string attribute11 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajH());
						if (attribute11 != null)
						{
							string[] array5 = attribute11.Split('x', (StringSplitOptions)0);
							if (array5.Length != 2)
							{
								throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajh());
							}
							setting.A(new Size(int.Parse(array5[0]), int.Parse(array5[1])));
						}
						string attribute12 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajI());
						if (attribute12 != null)
						{
							setting.G(int.Parse(attribute12));
						}
						string attribute13 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aji());
						if (attribute13 != null)
						{
							setting.g(int.Parse(attribute13));
						}
						return;
					}
					case 'U':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJU()))
						{
							break;
						}
						if (P_2 == -1)
						{
							setting?.g(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return;
					case 'A':
					{
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJu()))
						{
							break;
						}
						if (P_2 != -1 || setting == null)
						{
							return;
						}
						string attribute7 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajJ());
						string attribute8 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajj());
						if (attribute7 != null && attribute8 != null)
						{
							throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajK());
						}
						if (attribute7 != null)
						{
							setting.I(int.Parse(attribute7));
							return;
						}
						if (attribute8 != null)
						{
							setting.i(int.Parse(attribute8));
							return;
						}
						throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajk());
					}
					}
					break;
				case 4:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiv()))
					{
						break;
					}
					if (P_2 == -1 && setting != null)
					{
						string attribute14 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL());
						if (attribute14 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJx())
						{
							setting.J(2);
							setting.H(false);
						}
						else if (attribute14 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vA())
						{
							setting.J(1);
							setting.H(false);
						}
						else if (attribute14 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJY())
						{
							setting.J(4);
							setting.H(true);
						}
						else if (attribute14 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJy())
						{
							setting.J(2);
							setting.H(true);
						}
						else if (attribute14 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJZ())
						{
							setting.J(1);
							setting.H(true);
						}
					}
					return;
				case 35:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJb()))
					{
						break;
					}
					A(P_0, ref empty);
					if (P_2 == -1)
					{
						setting?.a(empty);
					}
					return;
				case 28:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJg()))
					{
						break;
					}
					if (P_2 == -1)
					{
						setting?.B(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajC()));
					}
					return;
				case 17:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJV()))
					{
						break;
					}
					if (P_2 == -1)
					{
						setting?.e(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					}
					return;
				case 22:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJv()))
					{
						break;
					}
					if (P_2 == -1 && P_1 is SpecialObject)
					{
						(P_1 as SpecialObject).B().ShowCalibrateAllButton = bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
					}
					return;
				case 6:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJW()))
					{
						break;
					}
					return;
				case 5:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJw()))
					{
						break;
					}
					return;
				}
			}
			if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajL()))
			{
				if (setting != null)
				{
					string attribute15 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajC());
					int num7 = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
					string attribute16 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajl());
					string attribute17 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajM());
					string attribute18 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajm());
					string attribute19 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajN());
					int num8 = 0;
					if (attribute17 != null)
					{
						num8 = int.Parse(attribute17);
					}
					setting.A(attribute, attribute15, num7, num8, attribute16, attribute18, attribute19, P_2);
				}
			}
			else if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajn()))
			{
				if (setting != null)
				{
					string attribute20 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL());
					string attribute21 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajO());
					if (attribute20 != null && attribute21 != null)
					{
						setting.A(int.Parse(attribute20), attribute21);
					}
				}
			}
			else if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajo()))
			{
				empty = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajc());
				int num9 = int.Parse(empty);
				A(P_0, ref empty);
				setting?.A(attribute, empty, num9, P_2);
			}
			else if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajP()))
			{
				if (setting != null)
				{
					string attribute22 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajC());
					int num10 = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
					int num11 = num10;
					string attribute23 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajp());
					if (attribute23 != null)
					{
						num11 = int.Parse(attribute23);
					}
					setting.A(attribute, attribute22, num10, num11, P_2);
				}
			}
			else if (attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajQ())
			{
				setting?.b(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajC()));
			}
			else if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajq()))
			{
				if (P_2 == -1)
				{
					setting?.V().Add(byte.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
				}
			}
			else if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kw()))
			{
				string attribute24 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajR());
				if (attribute24 != null)
				{
					A(P_0, P_1, attribute24);
				}
				else
				{
					A(P_0, P_1, attribute, P_2);
				}
			}
			else if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajr()))
			{
				a(P_0, P_1, attribute, P_2);
			}
			else if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajS()))
			{
				A(P_0, ref empty);
				if (P_2 == -1)
				{
					P_1.i().Add(empty);
				}
			}
			else if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajs()))
			{
				if (P_2 == -1)
				{
					int num12 = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
					P_1.b(num12);
					aXO.aWy.Add(num12, P_1.r());
				}
			}
			else if (attribute[0] == 'S' && attribute[1] >= '0' && attribute[1] <= '9')
			{
				string attribute25 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP());
				string attribute26 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajT());
				string attribute27 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajt());
				string attribute28 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajU());
				if (attribute25 == null || !(P_1 is SpecialObject))
				{
					return;
				}
				int num13 = int.Parse(attribute25);
				if (P_1 is DI)
				{
					(P_1 as DI).A().Add(num13);
					return;
				}
				int num14 = 0;
				if (attribute26 != null)
				{
					num14 = int.Parse(attribute26);
				}
				bool flag2 = false;
				bool flag3 = false;
				if (attribute27 != null)
				{
					flag2 = bool.Parse(attribute27);
				}
				if (attribute28 != null)
				{
					flag3 = bool.Parse(attribute28);
				}
				(P_1 as SpecialObject).A(num13, num14, flag2, flag3, P_2, P_3);
			}
			else if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aju()))
			{
				string attribute29 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajV());
				if (attribute29 != null && P_1 is SpecialObject)
				{
					(P_1 as SpecialObject).B().RowObjectId = int.Parse(attribute29);
				}
			}
			else if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajv()))
			{
				string attribute30 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP());
				if (attribute30 != null && P_1 is SpecialObject)
				{
					(P_1 as SpecialObject).B().RowIncludeSetting = int.Parse(attribute30);
				}
			}
			else if (!B(P_0, P_1, attribute, P_2, P_3) && !b(P_0, P_1, attribute, P_2, P_3) && !C(P_0, P_1, attribute, P_2, P_3) && !c(P_0, P_1, attribute, P_2, P_3) && !D(P_0, P_1, attribute, P_2, P_3) && !H(P_0, P_1, attribute, P_2, P_3) && !g(P_0, P_1, attribute, P_2, P_3) && !A(P_0, P_1, attribute, P_2, P_3) && !a(P_0, P_1, attribute, P_2, P_3) && !G(P_0, P_1, attribute, P_2, P_3) && !d(P_0, P_1, attribute, P_2, P_3) && !E(P_0, P_1, attribute, P_2, P_3) && !e(P_0, P_1, attribute, P_2, P_3) && !F(P_0, P_1, attribute, P_2, P_3) && !f(P_0, P_1, attribute, P_2, P_3))
			{
				string attribute31 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIB());
				if (attribute31 != null && attribute31 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIg())
				{
					A(P_0, ref empty);
				}
				else if (!P_0.IsEmptyElement)
				{
					P_0.Skip();
				}
			}
		}

		private bool A(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3, string P_4)
		{
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP());
			if (P_2 != null)
			{
				switch (P_2.Length)
				{
				case 7:
				{
					char c = P_2[0];
					if (c != 'C')
					{
						if (c != 'E' || !(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Eb()))
						{
							break;
						}
						if (attribute != null && P_1 is TableAxis)
						{
							(P_1 as TableAxis).A(int.Parse(attribute));
						}
						return true;
					}
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hq()))
					{
						break;
					}
					goto IL_01a6;
				}
				case 4:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hh()))
					{
						break;
					}
					if (attribute != null && P_1 is TableAxis)
					{
						(P_1 as TableAxis).B(int.Parse(attribute));
					}
					return true;
				case 5:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hj()))
					{
						break;
					}
					if (attribute != null && P_1 is TableAxis)
					{
						(P_1 as TableAxis).a(int.Parse(attribute));
					}
					return true;
				case 6:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajW()))
					{
						break;
					}
					goto IL_01a6;
				case 15:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajw()))
					{
						break;
					}
					if (P_1 is TableAxis)
					{
						(P_1 as TableAxis).A(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					}
					return true;
				case 16:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajX()))
					{
						break;
					}
					if (P_1 is TableAxis)
					{
						(P_1 as TableAxis).a(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					}
					return true;
				case 31:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajx()))
					{
						break;
					}
					if (P_1 is Table)
					{
						(P_1 as Table).AllCellsOnFirstColumnMustBeZero = bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
					}
					return true;
				case 28:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajY()))
					{
						break;
					}
					if (P_1 is Table)
					{
						(P_1 as Table).AllCellsOnFirstRowMustBeZero = bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
					}
					return true;
				case 17:
					{
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajy()))
						{
							break;
						}
						if (P_1 is Setting setting)
						{
							setting.k(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return true;
					}
					IL_01a6:
					if (attribute != null && P_1 is TableAxis)
					{
						(P_1 as TableAxis).b(int.Parse(attribute));
					}
					return true;
				}
			}
			return false;
		}

		private bool a(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3, string P_4)
		{
			if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajZ()))
			{
				if (P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajz())
				{
					if (P_1 is OnOffSwitchingPoint)
					{
						(P_1 as OnOffSwitchingPoint).ColumnChannelDataId = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
					}
					return true;
				}
				return false;
			}
			if (P_1 is OnOffSwitchingPoint)
			{
				(P_1 as OnOffSwitchingPoint).RowChannelDataId = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
			}
			return true;
		}

		private bool B(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3, string P_4)
		{
			string empty = string.Empty;
			if (P_2 != null)
			{
				switch (P_2.Length)
				{
				case 16:
					switch (P_2[12])
					{
					case 'T':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKb()))
						{
							break;
						}
						return true;
					case 'P':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKC()))
						{
							break;
						}
						A(P_0, ref empty);
						return true;
					case 'N':
					{
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKc()))
						{
							break;
						}
						string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIB());
						bool flag = false;
						if (attribute != null)
						{
							flag = attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIg();
						}
						if (flag)
						{
							A(P_0, ref empty);
							if (P_3 == -1)
							{
								P_1.F().A(empty);
							}
						}
						else if (P_3 == -1)
						{
							P_1.F().A(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP())));
						}
						return true;
					}
					}
					break;
				case 6:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKA()))
					{
						break;
					}
					P_1.F().a(uint.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())), P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKe()), P_3);
					return true;
				case 14:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKa()))
					{
						break;
					}
					if (P_3 == -1)
					{
						P_1.F().Bbb = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
					}
					return true;
				case 24:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKB()))
					{
						break;
					}
					if (P_3 == -1)
					{
						P_1.F().BBZ = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
					}
					return true;
				case 20:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKD()))
					{
						break;
					}
					if (P_3 == -1)
					{
						P_1.F().BbC = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
					}
					return true;
				case 10:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKd()))
					{
						break;
					}
					P_1.F().A(uint.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay(), P_3);
					return true;
				case 25:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKE()))
					{
						break;
					}
					P_1.F().Bbd = bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
					return true;
				}
			}
			if (P_2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKF()))
			{
				ushort num = ushort.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
				P_1.F().A(num, P_3);
				return true;
			}
			if (P_2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKf()))
			{
				uint num2 = uint.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
				string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKe());
				string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKG());
				bool flag2 = attribute3 != null;
				ushort num3 = (ushort)(flag2 ? ushort.Parse(attribute3) : 0);
				P_1.F().A(num2, attribute2, flag2, num3, P_3);
				if (!aXO.awE.Contains(P_1))
				{
					aXO.awE.Add(P_1);
				}
				return true;
			}
			if (P_2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKB()))
			{
				if (P_3 == -1)
				{
					int num4 = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
					P_1.F().C().Add(num4);
				}
				return true;
			}
			return false;
		}

		private bool b(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3, string P_4)
		{
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Invalid comparison between Unknown and I4
			if (P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKg())
			{
				if (P_1 is FilterOption)
				{
					(P_1 as FilterOption).A(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
				}
				return true;
			}
			if (P_2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKH()))
			{
				uint num = 0u;
				Cg cg = Cg.BAB;
				CH cH = CH.BAU;
				byte b = 255;
				ushort num2 = 0;
				string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKh());
				if (attribute != null)
				{
					cg = (Cg)byte.Parse(attribute);
				}
				string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKI());
				if (attribute2 != null)
				{
					cH = (CH)byte.Parse(attribute2);
				}
				if (cg == Cg.BAM)
				{
					string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKi());
					if (attribute3 != null)
					{
						num2 = ushort.Parse(attribute3);
					}
					num = PortFunction.A(cg, cH, num2);
				}
				else
				{
					string attribute4 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKJ());
					if (attribute4 != null)
					{
						b = byte.Parse(attribute4);
					}
					num = PortFunction.A(cg, cH, b);
				}
				bool flag = true;
				string attribute5 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL());
				if (attribute5 != null)
				{
					flag = bool.Parse(attribute5);
				}
				if (P_1 is FilterOption)
				{
					(P_1 as FilterOption).A(num, flag, P_3);
				}
				return true;
			}
			if (P_2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKj()))
			{
				if (P_3 == -1)
				{
					A(P_0, P_1 as FilterOption, P_2);
				}
				else if (!P_0.IsEmptyElement)
				{
					P_0.Read();
					while ((int)P_0.NodeType != 15 || (P_0.Name != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() && P_0.Name != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs()))
					{
						P_0.Read();
					}
				}
				return true;
			}
			return false;
		}

		private bool C(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3, string P_4)
		{
			string empty = string.Empty;
			if (P_2 != null)
			{
				switch (P_2.Length)
				{
				case 9:
					switch (P_2[0])
					{
					case 'C':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKK()))
						{
							break;
						}
						P_1.A(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						return true;
					case 'D':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKk()))
						{
							break;
						}
						if (P_1 is DO)
						{
							(P_1 as DO).B().Add(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return true;
					}
					break;
				case 13:
					switch (P_2[0])
					{
					case 'C':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKL()))
						{
							break;
						}
						if (P_1 is DO)
						{
							(P_1 as DO).A(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return true;
					case 'H':
					{
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKl()) || !(P_1 is DO))
						{
							break;
						}
						A(P_0, ref empty);
						string[] array2 = empty.Split(',', (StringSplitOptions)0);
						foreach (string text2 in array2)
						{
							(P_1 as DO).d().Add(text2);
						}
						return true;
					}
					}
					break;
				case 17:
					switch (P_2[0])
					{
					case 'D':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKn()))
						{
							break;
						}
						if (P_1 is DO)
						{
							A(P_0, ref empty);
							(P_1 as DO).a(empty);
						}
						return true;
					case 'P':
					{
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKO()) || !(P_1 is DO))
						{
							break;
						}
						int num = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKq()));
						A(P_0, ref empty);
						string[] array3 = empty.Split(',', (StringSplitOptions)0);
						(P_1 as DO).G().Add(num, array3);
						return true;
					}
					}
					break;
				case 19:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKM()))
					{
						break;
					}
					if (P_1 is DO)
					{
						(P_1 as DO).A(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					}
					return true;
				case 20:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKm()))
					{
						break;
					}
					if (P_1 is DO)
					{
						(P_1 as DO).a().Add(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					}
					return true;
				case 10:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKN()))
					{
						break;
					}
					if (P_1 is DO)
					{
						A(P_0, ref empty);
						(P_1 as DO).A(empty);
					}
					return true;
				case 7:
				{
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKo()) || !(P_1 is DO))
					{
						break;
					}
					A(P_0, ref empty);
					string[] array2 = empty.Split(',', (StringSplitOptions)0);
					foreach (string text3 in array2)
					{
						(P_1 as DO).c().Add(text3);
					}
					return true;
				}
				case 15:
				{
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKP()) || !(P_1 is DO))
					{
						break;
					}
					A(P_0, ref empty);
					string[] array2 = empty.Split(',', (StringSplitOptions)0);
					foreach (string text in array2)
					{
						(P_1 as DO).D().Add(text);
					}
					return true;
				}
				case 16:
				{
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKp()) || !(P_1 is DO))
					{
						break;
					}
					string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKQ());
					A(P_0, ref empty);
					string[] array = empty.Split(',', (StringSplitOptions)0);
					(P_1 as DO).E().Add(attribute, array);
					return true;
				}
				}
			}
			if (P_2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKR()))
			{
				P_1.A(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKQ()), P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()), P_3, P_4);
				return true;
			}
			return false;
		}

		private bool c(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3, string P_4)
		{
			string empty = string.Empty;
			if (P_2 != null)
			{
				switch (P_2.Length)
				{
				case 8:
					switch (P_2[4])
					{
					case 'C':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKr()))
						{
							break;
						}
						A(P_0, ref empty);
						if (P_1 is Dm)
						{
							(P_1 as Dm).A(empty);
						}
						return true;
					case 'E':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKS()))
						{
							break;
						}
						A(P_0, ref empty);
						if (P_1 is Dm)
						{
							(P_1 as Dm).a(empty);
						}
						return true;
					}
					break;
				case 11:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKs()))
					{
						break;
					}
					if (P_1 is Dm)
					{
						(P_1 as Dm).A(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					}
					return true;
				case 15:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKT()))
					{
						break;
					}
					if (P_1 is Dm)
					{
						(P_1 as Dm).A(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					}
					return true;
				case 19:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKt()))
					{
						break;
					}
					if (P_1 is Dm)
					{
						(P_1 as Dm).a(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					}
					return true;
				case 12:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKU()))
					{
						break;
					}
					if (P_1 is Dm)
					{
						(P_1 as Dm).B(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					}
					return true;
				case 14:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKu()))
					{
						break;
					}
					if (P_1 is Dm)
					{
						(P_1 as Dm).b(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					}
					return true;
				case 16:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKV()))
					{
						break;
					}
					A(P_0, ref empty);
					if (P_1 is Dm)
					{
						(P_1 as Dm).B(empty);
					}
					return true;
				case 3:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKv()))
					{
						break;
					}
					P_1.C(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
					return true;
				}
			}
			if (P_2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKW()))
			{
				A(P_0, ref empty);
				P_1.b(empty);
				return true;
			}
			return false;
		}

		private bool D(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3, string P_4)
		{
			//IL_056e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0573: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0530: Unknown result type (might be due to invalid IL or missing references)
			//IL_0535: Unknown result type (might be due to invalid IL or missing references)
			string empty = string.Empty;
			if (P_1 is SpecialObject specialObject)
			{
				if (P_2 != null)
				{
					switch (P_2.Length)
					{
					case 15:
						switch (P_2[1])
						{
						case 'o':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKX()))
							{
								break;
							}
							if (P_3 == -1)
							{
								specialObject.A().ayR = (Cg)byte.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
								aXO.awe = true;
							}
							return true;
						case 'u':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKx()))
							{
								break;
							}
							specialObject.a().Bbx = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akf()));
							specialObject.a().BbY = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akG()));
							return true;
						}
						break;
					case 13:
						switch (P_2[0])
						{
						case 'C':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKY()))
							{
								break;
							}
							A(P_0, ref empty);
							if (P_3 == -1)
							{
								specialObject.A().ayr = empty;
								aXO.awe = true;
							}
							return true;
						case 'P':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKy()))
							{
								break;
							}
							if (P_3 == -1)
							{
								string[] array3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akh()).Split(',', (StringSplitOptions)0);
								specialObject.a().BbX = new Size(int.Parse(array3[0]), int.Parse(array3[1]));
							}
							return true;
						}
						break;
					case 12:
						switch (P_2[0])
						{
						case 'P':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKz()))
							{
								break;
							}
							A(P_0, ref empty);
							if (P_3 == -1)
							{
								specialObject.a().Bbr = empty;
							}
							return true;
						case 'F':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akA()))
							{
								break;
							}
							return true;
						}
						break;
					case 9:
						switch (P_2[0])
						{
						case 'C':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aka()))
							{
								break;
							}
							A(P_0, ref empty);
							if (P_3 == -1)
							{
								specialObject.a().BbS = empty;
							}
							return true;
						case 'B':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akB()))
							{
								break;
							}
							if (P_3 == -1)
							{
								specialObject.a().BbU = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL());
							}
							return true;
						}
						break;
					case 5:
						switch (P_2[0])
						{
						case 'P':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akb()))
							{
								break;
							}
							A(P_0, ref empty);
							if (P_3 == -1)
							{
								specialObject.a().Bbs = empty;
							}
							return true;
						case 'G':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akC()))
							{
								break;
							}
							if (P_3 == -1)
							{
								specialObject.a().BbV = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
							}
							return true;
						}
						break;
					case 8:
						switch (P_2[0])
						{
						case 'P':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akc()))
							{
								break;
							}
							if (P_3 == -1)
							{
								specialObject.a().BbT = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
							}
							return true;
						case 'S':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akD()))
							{
								break;
							}
							if (P_3 == -1)
							{
								specialObject.a().Bbt = bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
							}
							return true;
						}
						break;
					case 17:
						switch (P_2[0])
						{
						case 'D':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akE()))
							{
								break;
							}
							if (P_3 == -1)
							{
								specialObject.a().Bbv = bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
							}
							return true;
						case 'P':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ake()))
							{
								break;
							}
							if (P_3 == -1)
							{
								string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akg());
								if (attribute != null)
								{
									string[] array = attribute.Split(',', (StringSplitOptions)0);
									specialObject.a().BbW = new Point(int.Parse(array[0]), int.Parse(array[1]));
								}
								else
								{
									string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akH());
									if (attribute2 != null)
									{
										string[] array2 = attribute2.Split(',', (StringSplitOptions)0);
										specialObject.a().Bbw = new Point(int.Parse(array2[0]), int.Parse(array2[1]));
									}
								}
							}
							return true;
						}
						break;
					case 21:
					{
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKw()))
						{
							break;
						}
						Cg cg = (Cg)byte.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akF()));
						P_0.Read();
						if (P_3 == -1)
						{
							aXO.awC.Add(cg, P_0.Value);
						}
						P_0.Skip();
						return true;
					}
					case 7:
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKZ()))
						{
							break;
						}
						A(P_0, ref empty);
						if (P_3 == -1)
						{
							specialObject.a().BbR = empty;
						}
						return true;
					case 10:
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akd()))
						{
							break;
						}
						if (P_3 == -1)
						{
							specialObject.a().Bbu = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL());
						}
						return true;
					}
				}
				if (P_2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akI()))
				{
					specialObject.a().A(uint.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())), P_3);
					return true;
				}
				if (P_2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aki()))
				{
					A(P_0, ref empty);
					specialObject.a().A(empty, P_3);
					return true;
				}
			}
			return false;
		}

		private bool d(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3, string P_4)
		{
			if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akJ()))
			{
				if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akj()))
				{
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akK()))
					{
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akk()))
						{
							if (P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akL())
							{
								if (P_1 is Setting setting)
								{
									setting.c(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
									if (setting.i() != 0)
									{
										aXO.aWU.Add(setting);
									}
								}
								return true;
							}
							return false;
						}
						P_1.f().DataIdOfChannelRateSetting = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
						return true;
					}
					P_1.f().DataIdOfChannelListSetting = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
					return true;
				}
				P_1.f().RateLimit = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
				return true;
			}
			P_1.f().LimitedSpaceEquation = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahU());
			return true;
		}

		private bool E(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3, string P_4)
		{
			string empty = string.Empty;
			InitialTaskObject initialTaskObject = null;
			if (P_2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akl()))
			{
				string text = P_2.Substring(0, P_2.Length - 12);
				for (int i = 0; i < P_1.J().Count; i++)
				{
					if (P_1.J()[i].A() == text)
					{
						initialTaskObject = P_1.J()[i];
						break;
					}
				}
				if (initialTaskObject == null)
				{
					initialTaskObject = new InitialTaskObject(aXO);
					initialTaskObject.A(text);
					P_1.J().Add(initialTaskObject);
				}
				initialTaskObject.A((CE)int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
				string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akM());
				if (attribute != null)
				{
					initialTaskObject.A(int.Parse(attribute));
				}
				initialTaskObject.A((Ce)int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akm())));
				string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akN());
				if (attribute2 != null)
				{
					initialTaskObject.A(bool.Parse(attribute2));
				}
				string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akn());
				if (attribute3 != null)
				{
					initialTaskObject.a(bool.Parse(attribute3));
				}
				return true;
			}
			if (P_2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akO()))
			{
				string text2 = P_2.Substring(0, P_2.Length - 15);
				for (int j = 0; j < P_1.J().Count; j++)
				{
					if (P_1.J()[j].A() == text2)
					{
						initialTaskObject = P_1.J()[j];
						break;
					}
				}
				if (initialTaskObject == null)
				{
					initialTaskObject = new InitialTaskObject(aXO);
					initialTaskObject.A(text2);
					P_1.J().Add(initialTaskObject);
				}
				A(P_0, ref empty);
				initialTaskObject.a(empty);
				return true;
			}
			if (P_2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ako()))
			{
				string text3 = P_2.Substring(0, P_2.Length - 16);
				for (int k = 0; k < P_1.J().Count; k++)
				{
					if (P_1.J()[k].A() == text3)
					{
						initialTaskObject = P_1.J()[k];
						break;
					}
				}
				if (initialTaskObject == null)
				{
					initialTaskObject = new InitialTaskObject(aXO);
					initialTaskObject.A(text3);
					P_1.J().Add(initialTaskObject);
				}
				initialTaskObject.b(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahU()));
				return true;
			}
			if (P_2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akP()))
			{
				string text4 = P_2.Substring(0, P_2.Length - 19);
				for (int l = 0; l < P_1.J().Count; l++)
				{
					if (P_1.J()[l].A() == text4)
					{
						initialTaskObject = P_1.J()[l];
						break;
					}
				}
				if (initialTaskObject == null)
				{
					initialTaskObject = new InitialTaskObject(aXO);
					initialTaskObject.A(text4);
					P_1.J().Add(initialTaskObject);
				}
				A(P_0, ref empty);
				initialTaskObject.B(empty);
				return true;
			}
			if (P_2.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akp()))
			{
				string text5 = P_2.Substring(0, P_2.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akp()));
				for (int m = 0; m < P_1.J().Count; m++)
				{
					if (P_1.J()[m].A() == text5)
					{
						initialTaskObject = P_1.J()[m];
						break;
					}
				}
				if (initialTaskObject == null)
				{
					initialTaskObject = new InitialTaskObject(aXO);
					initialTaskObject.A(text5);
					P_1.J().Add(initialTaskObject);
				}
				int num = P_2.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akp()) + 17;
				string text6 = P_2.Substring(num, P_2.Length - num);
				initialTaskObject.A(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())), text6);
				return true;
			}
			return false;
		}

		private bool e(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3, string P_4)
		{
			string empty = string.Empty;
			if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akQ()))
			{
				if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akq()))
				{
					if (P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akR())
					{
						P_1.K().B(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahU()));
						return true;
					}
					if (P_2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akr()))
					{
						P_1.K().A(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akS())), P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahU()));
						return true;
					}
					return false;
				}
				A(P_0, ref empty);
				P_1.K().a(empty);
				return true;
			}
			A(P_0, ref empty);
			P_1.K().A(empty);
			return true;
		}

		private bool F(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3, string P_4)
		{
			if (P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aks())
			{
				if (P_1 is KnockDetection)
				{
					(P_1 as KnockDetection).DataIdOfCentreFrequencySetting = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
				}
				return true;
			}
			if (P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akT())
			{
				if (P_1 is KnockDetection)
				{
					(P_1 as KnockDetection).DataIdOfBandwidthSetting = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
				}
				return true;
			}
			if (P_2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akt()))
			{
				if (P_1 is KnockDetection)
				{
					(P_1 as KnockDetection).DataIdsOfFFTChannels.Add(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP())));
				}
				return true;
			}
			if (P_2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akU()))
			{
				if (P_1 is KnockDetection)
				{
					(P_1 as KnockDetection).DataIdsOfAngleBucketChannels.Add(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP())));
				}
				return true;
			}
			if (P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aku())
			{
				if (P_1 is KnockDetection)
				{
					(P_1 as KnockDetection).DataIdOfWindowStartAngleSetting = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
				}
				return true;
			}
			if (P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akV())
			{
				if (P_1 is KnockDetection)
				{
					(P_1 as KnockDetection).DataIdOfWindowDurationSetting = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
				}
				return true;
			}
			return false;
		}

		private bool f(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3, string P_4)
		{
			string empty = string.Empty;
			if (P_1 is SpecialObject specialObject)
			{
				if (P_2 != null)
				{
					switch (P_2.Length)
					{
					case 25:
						switch (P_2[0])
						{
						case 'A':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akW()))
							{
								break;
							}
							A(P_0, ref empty);
							specialObject.C().IdleText = empty;
							return true;
						case 'I':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akw()))
							{
								break;
							}
							specialObject.C().InjectorOutputWithinStage = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
							return true;
						}
						break;
					case 16:
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akv()))
						{
							break;
						}
						A(P_0, ref empty);
						specialObject.C().ConfirmationText = empty;
						return true;
					case 23:
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akX()))
						{
							break;
						}
						specialObject.C().HoldToExecuteOutputTest = bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
						return true;
					case 19:
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akx()))
						{
							break;
						}
						A(P_0, ref empty);
						specialObject.C().ActiveText = empty;
						return true;
					case 24:
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akY()))
						{
							break;
						}
						specialObject.C().ProcessId = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
						return true;
					case 18:
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aky()))
						{
							break;
						}
						specialObject.C().InjectorStageIndex = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
						return true;
					}
				}
				if (P_2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akZ()))
				{
					specialObject.C().AddPreApplySettingDataId(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP())));
					return true;
				}
			}
			return false;
		}

		private bool G(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3, string P_4)
		{
			string empty = string.Empty;
			SpecialObject specialObject = P_1 as SpecialObject;
			if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.akz()))
			{
				if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLA()))
				{
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLa()))
					{
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLB()))
						{
							if (P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLb())
							{
								if (specialObject != null)
								{
									int num = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
									specialObject.c().ThresholdSettingId = num;
									aXO.awJ.Add(num);
								}
								return true;
							}
							return false;
						}
						if (specialObject != null)
						{
							int operatorSettingId = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
							specialObject.c().OperatorSettingId = operatorSettingId;
						}
						return true;
					}
					A(P_0, ref empty);
					if (specialObject != null)
					{
						specialObject.c().JoinText = empty;
					}
					return true;
				}
				int num2 = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
				if (specialObject != null)
				{
					specialObject.c().ChannelSettingId = num2;
					aXO.awi.Add(num2);
				}
				else if (P_1 is Setting setting)
				{
					setting.D(num2);
				}
				return true;
			}
			if (specialObject != null)
			{
				int enablerSettingId = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
				specialObject.c().EnablerSettingId = enablerSettingId;
			}
			return true;
		}

		private bool g(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3, string P_4)
		{
			if (P_1 is SpecialObject)
			{
				SpecialObject specialObject = P_1 as SpecialObject;
				if (P_2 != null)
				{
					switch (P_2.Length)
					{
					case 11:
						switch (P_2[0])
						{
						case 'I':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLC()))
							{
								break;
							}
							specialObject.b().SetListLabelsFormatString(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
							return true;
						case 'R':
							if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLc()))
							{
								break;
							}
							specialObject.b().Reorderable = bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
							specialObject.b().SetObjectsOrderColumnTextWithDefault(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIL()), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLG());
							return true;
						}
						break;
					case 12:
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLD()))
						{
							break;
						}
						specialObject.b().ShowOrdinalValues = bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
						return true;
					case 10:
					{
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLd()))
						{
							break;
						}
						string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP());
						if (attribute != null)
						{
							specialObject.b().DataIdOfListCountSetting = int.Parse(attribute);
						}
						string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL());
						if (attribute2 != null)
						{
							specialObject.b().FixedCountValue = int.Parse(attribute2);
						}
						return true;
					}
					case 17:
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLE()))
						{
							break;
						}
						specialObject.b().SetObjectsListLabelsFormatString(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
						return true;
					case 18:
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLe()))
						{
							break;
						}
						specialObject.b().ShowOrdinalValues = bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
						return true;
					case 16:
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLF()))
						{
							break;
						}
						return true;
					case 7:
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yg()))
						{
							break;
						}
						specialObject.b().ShowSummary = bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
						return true;
					case 20:
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLf()))
						{
							break;
						}
						specialObject.b().ExtraSummaryObjectId = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajV()));
						return true;
					}
				}
				if (P_2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLg()))
				{
					specialObject.b().DataIdsOfListSettings.Add(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP())));
					return true;
				}
			}
			return false;
		}

		private bool H(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3, string P_4)
		{
			string empty = string.Empty;
			if (P_2 != null)
			{
				switch (P_2.Length)
				{
				case 21:
					switch (P_2[0])
					{
					case 'S':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLH()))
						{
							break;
						}
						if (P_1 is StateMachine)
						{
							(P_1 as StateMachine).ProcessId = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
						}
						return true;
					case 'C':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLh()))
						{
							break;
						}
						if (P_1 is StateMachine)
						{
							(P_1 as StateMachine).CurrentStageChannelDataId = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
						}
						return true;
					case 'R':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLI()))
						{
							break;
						}
						if (P_1 is StateMachine)
						{
							(P_1 as StateMachine).RequestStageChannelDataId = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
						}
						return true;
					}
					break;
				case 14:
					switch (P_2[0])
					{
					case 'E':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLi()))
						{
							break;
						}
						if (P_1 is StateMachine)
						{
							(P_1 as StateMachine).OutcomeErrorChannelDataId = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
						}
						return true;
					case 'H':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLJ()))
						{
							break;
						}
						if (P_1 is StateMachineStage)
						{
							(P_1 as StateMachineStage).a(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return true;
					}
					break;
				case 6:
					switch (P_2[0])
					{
					case 'S':
					{
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jd()))
						{
							break;
						}
						string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL());
						if (!attribute.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJz()))
						{
							if (P_1 is StateMachineStage)
							{
								(P_1 as StateMachineStage).a(int.Parse(attribute));
							}
						}
						else
						{
							attribute = attribute.Substring(1, attribute.Length - 2);
							string text = string.Empty;
							for (int i = 0; i < attribute.Length; i++)
							{
								if (attribute[i] != ',')
								{
									System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(text);
									char c = attribute[i];
									text = string.Concat(readOnlySpan, new System.ReadOnlySpan<char>(ref c));
									continue;
								}
								if (P_1 is StateMachineStage)
								{
									(P_1 as StateMachineStage).a(int.Parse(text));
								}
								text = string.Empty;
							}
							if (P_1 is StateMachineStage)
							{
								(P_1 as StateMachineStage).a(int.Parse(text));
							}
						}
						return true;
					}
					case 'C':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tR()))
						{
							break;
						}
						A(P_0, ref empty);
						if (P_1 is StateMachineError)
						{
							(P_1 as StateMachineError).a(empty);
						}
						return true;
					}
					break;
				case 7:
					switch (P_2[0])
					{
					case 'T':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLK()))
						{
							break;
						}
						if (P_1 is StateMachineStage)
						{
							(P_1 as StateMachineStage).b(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return true;
					case 'M':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLk()))
						{
							break;
						}
						A(P_0, ref empty);
						if (P_1 is StateMachineError)
						{
							(P_1 as StateMachineError).A(empty);
						}
						return true;
					}
					break;
				case 5:
					switch (P_2[0])
					{
					case 'S':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLL()))
						{
							break;
						}
						if (P_1 is StateMachineStage)
						{
							(P_1 as StateMachineStage).C(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return true;
					case 'I':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahJ()))
						{
							break;
						}
						P_0.Read();
						if (P_1 is StateMachineStage)
						{
							(P_1 as StateMachineStage).A(P_0.Value);
						}
						P_0.Skip();
						return true;
					case 'V':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cj()))
						{
							break;
						}
						if (P_1 is StateMachineError)
						{
							(P_1 as StateMachineError).A(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return true;
					}
					break;
				case 16:
					switch (P_2[1])
					{
					case 'u':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLM()))
						{
							break;
						}
						if (P_1 is StateMachineStage)
						{
							(P_1 as StateMachineStage).A(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return true;
					case 's':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLm()))
						{
							break;
						}
						return true;
					}
					break;
				case 11:
					switch (P_2[0])
					{
					case 'H':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLN()))
						{
							break;
						}
						if (P_1 is StateMachineStage)
						{
							(P_1 as StateMachineStage).B(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						}
						return true;
					case 'C':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLn()))
						{
							break;
						}
						A(P_0, ref empty);
						if (P_1 is StateMachineStage)
						{
							(P_1 as StateMachineStage).a(empty);
						}
						return true;
					}
					break;
				case 8:
					switch (P_2[0])
					{
					case 'H':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLO()))
						{
							break;
						}
						A(P_0, ref empty);
						if (P_1 is StateMachineStage)
						{
							(P_1 as StateMachineStage).B(empty);
						}
						return true;
					case 'N':
						if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLo()))
						{
							break;
						}
						A(P_0, ref empty);
						if (P_1 is StateMachineStage)
						{
							(P_1 as StateMachineStage).b(empty);
						}
						return true;
					}
					break;
				case 4:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLj()))
					{
						break;
					}
					if (P_1 is StateMachineStage)
					{
						(P_1 as StateMachineStage).A(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					}
					return true;
				case 17:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLl()))
					{
						break;
					}
					if (P_1 is StateMachineStage)
					{
						(P_1 as StateMachineStage).B(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					}
					return true;
				case 15:
					if (!(P_2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLP()))
					{
						break;
					}
					A(P_0, ref empty);
					if (P_1 is StateMachineStage)
					{
						(P_1 as StateMachineStage).C(empty);
					}
					return true;
				}
			}
			return false;
		}

		private bool A(XmlReader P_0, ref int P_1, ref bool P_2, ref string P_3)
		{
			bool result = false;
			P_3 = string.Empty;
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL());
			if (attribute != null)
			{
				P_1 = int.Parse(attribute);
				P_2 = false;
				result = true;
			}
			else
			{
				string text = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP());
				if (text != null)
				{
					int num = text.IndexOf(':');
					if (num != -1)
					{
						P_3 = text.Substring(num + 1, text.Length - (num + 1));
						text = text.Remove(num);
					}
					P_1 = int.Parse(text);
					P_2 = true;
					result = true;
				}
			}
			return result;
		}

		private void A(XmlReader P_0, ref string P_1)
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Invalid comparison between Unknown and I4
			P_0.Read();
			if ((P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs()) && (int)P_0.NodeType == 15)
			{
				P_1 = string.Empty;
				return;
			}
			P_1 = P_0.Value;
			P_0.Skip();
		}

		private void A(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3)
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			bool flag = true;
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLp());
			if (attribute == null)
			{
				attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLQ());
			}
			if (attribute != null)
			{
				flag = bool.Parse(attribute);
			}
			StringBuilder val = new StringBuilder(100);
			A(P_0, ref val);
			if (!flag)
			{
				val.Insert(0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLq());
				val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLR());
			}
			P_1.A(((object)val).ToString(), P_3);
		}

		private void A(XmlReader P_0, SettingOrSpecialObject P_1, string P_2)
		{
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			if (!(P_1 is Setting setting))
			{
				return;
			}
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahU());
			if (attribute == null)
			{
				return;
			}
			bool flag = true;
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLp());
			if (attribute2 == null)
			{
				attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLQ());
			}
			if (attribute2 != null)
			{
				flag = bool.Parse(attribute2);
			}
			StringBuilder val = new StringBuilder(50);
			int[] array = new int[3];
			RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int[] array2 = array;
			if (P_2 != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJX())
			{
				P_2 = P_2.Substring(1, P_2.Length - 2);
				int num = P_2.IndexOf(',');
				int num2 = P_2.IndexOf(',', num + 1);
				array2[0] = int.Parse(P_2.Substring(0, num));
				array2[1] = int.Parse(P_2.Substring(num + 1, num2 - (num + 1)));
				array2[2] = int.Parse(P_2.Substring(num2 + 1));
			}
			for (int i = 0; i < array2[2]; i++)
			{
				for (int j = 0; j < array2[1]; j++)
				{
					for (int k = 0; k < array2[0]; k++)
					{
						val.Clear();
						for (int l = 0; l < attribute.Length; l++)
						{
							if (attribute[l] == 'd')
							{
								continue;
							}
							if (l > 0 && attribute[l - 1] == 'd')
							{
								if (attribute[l] == '0')
								{
									val.Append(i);
								}
								else if (attribute[l] == '1')
								{
									val.Append(j);
								}
								else if (attribute[l] == '2')
								{
									val.Append(k);
								}
							}
							else
							{
								val.Append(attribute[l]);
							}
						}
						if (!flag)
						{
							val.Insert(0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLq());
							val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLR());
						}
						setting.A(((object)val).ToString(), i, j, k);
					}
				}
			}
		}

		private void A(XmlReader P_0, FilterOption P_1, string P_2)
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			bool flag = true;
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLp());
			if (attribute == null)
			{
				attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLQ());
			}
			if (attribute != null)
			{
				flag = bool.Parse(attribute);
			}
			StringBuilder val = new StringBuilder(100);
			A(P_0, ref val);
			if (!flag)
			{
				val.Insert(0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLq());
				val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLR());
			}
			P_1.A(((object)val).ToString());
		}

		private void a(XmlReader P_0, SettingOrSpecialObject P_1, string P_2, int P_3)
		{
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			bool flag = true;
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLp());
			if (attribute == null)
			{
				attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLQ());
			}
			if (attribute != null)
			{
				flag = bool.Parse(attribute);
			}
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIL());
			if (attribute2 == null)
			{
				attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajC());
			}
			int num = 0;
			string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLr());
			if (attribute3 == null)
			{
				attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLS());
			}
			if (attribute3 != null)
			{
				num = int.Parse(attribute3);
			}
			bool flag2 = num != 1;
			string attribute4 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLs());
			if (attribute4 == null)
			{
				attribute4 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLT());
			}
			if (attribute4 != null)
			{
				flag2 = bool.Parse(attribute4);
			}
			StringBuilder val = new StringBuilder(100);
			A(P_0, ref val);
			if (!flag)
			{
				val.Insert(0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLq());
				val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLR());
			}
			if (P_1 is Setting setting)
			{
				setting.A(((object)val).ToString(), (IllegalitySeverityLevel)num, flag2, attribute2, P_3);
			}
		}

		private void A(XmlReader P_0, SettingOrSpecialObject P_1)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Invalid comparison between Unknown and I4
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Invalid comparison between Unknown and I4
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Invalid comparison between Unknown and I4
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Invalid comparison between Unknown and I4
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Invalid comparison between Unknown and I4
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			StringBuilder val = new StringBuilder(100);
			val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HS());
			bool flag = false;
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLt());
			if (attribute2 != null)
			{
				flag = bool.Parse(attribute2);
			}
			bool flag2 = false;
			bool flag3 = false;
			string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLU());
			if (attribute3 != null)
			{
				flag2 = attribute3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLu();
				flag3 = attribute3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLV();
			}
			if (flag)
			{
				val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLq());
			}
			bool flag4 = false;
			bool flag5 = false;
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIV()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs())
				{
					A(P_0, P_1, P_1.L(), attribute);
				}
				else
				{
					flag5 = false;
					if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vd() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIu())
					{
						if (P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajR()) != null)
						{
							flag4 = true;
						}
						A(P_0, ref val);
						if (flag2)
						{
							val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLv());
							flag5 = true;
						}
						else if (flag3)
						{
							val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLW());
							flag5 = true;
						}
					}
					else if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
					{
						throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLw(), (object)P_0.Name));
					}
				}
				P_0.Read();
			}
			if (flag5)
			{
				val.Remove(val.Length - 4, 4);
			}
			if (flag)
			{
				val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLR());
			}
			val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E());
			P_1.A(((object)val).ToString(), flag4);
		}

		private void A(XmlReader P_0, ref StringBuilder P_1)
		{
			A(P_0, ref P_1, null, null);
		}

		private void A(XmlReader P_0, ref StringBuilder P_1, CC P_2)
		{
			A(P_0, ref P_1, P_2, null);
		}

		private void A(XmlReader P_0, ref StringBuilder P_1, Cb P_2)
		{
			A(P_0, ref P_1, null, P_2);
		}

		private void A(XmlReader P_0, ref StringBuilder P_1, CC P_2, Cb P_3)
		{
			//IL_055f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0566: Invalid comparison between Unknown and I4
			//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bc: Invalid comparison between Unknown and I4
			//IL_056c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0573: Invalid comparison between Unknown and I4
			//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ed: Invalid comparison between Unknown and I4
			//IL_0417: Unknown result type (might be due to invalid IL or missing references)
			//IL_041e: Invalid comparison between Unknown and I4
			//IL_0448: Unknown result type (might be due to invalid IL or missing references)
			//IL_044f: Invalid comparison between Unknown and I4
			//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c3: Invalid comparison between Unknown and I4
			//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d0: Invalid comparison between Unknown and I4
			//IL_0507: Unknown result type (might be due to invalid IL or missing references)
			//IL_050e: Invalid comparison between Unknown and I4
			P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HS());
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahU());
			if (attribute != null)
			{
				P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HS());
				P_1.Append(attribute);
				P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E());
			}
			else
			{
				string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLX());
				if (attribute2 != null)
				{
					P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CF() + attribute2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E());
				}
				else
				{
					string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLx());
					if (attribute3 != null)
					{
						P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cj() + attribute3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E());
					}
					else
					{
						string attribute4 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLY());
						string attribute5 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLy());
						if (attribute4 != null && attribute5 != null)
						{
							if (P_2 != null)
							{
								P_2.A(attribute4);
								string text = P_2.A().C();
								P_1.Append(string.Concat(new string[5]
								{
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CM(),
									text,
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLZ(),
									attribute5,
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
								}));
							}
							else if (P_3 != null)
							{
								P_3.A(attribute4);
								string text2 = P_3.A().C();
								int count = P_3.A().f().Count;
								P_1.Append(string.Concat(new string[7]
								{
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CM(),
									text2,
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLz(),
									count.ToString(),
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alA(),
									attribute5,
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
								}));
							}
						}
					}
				}
			}
			string attribute6 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ala());
			string attribute7 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alB());
			string attribute8 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alb());
			string attribute9 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alC());
			string attribute10 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alc());
			if (attribute6 != null && attribute7 != null && (attribute8 != null || attribute9 != null))
			{
				P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alD());
				P_1.Append(attribute7);
				if (attribute10 != null)
				{
					P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ald() + attribute10);
				}
				P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl());
				if (attribute6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cf())
				{
					P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alE());
				}
				else if (attribute6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CG())
				{
					P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ale());
				}
				else if (attribute6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGi())
				{
					P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alF());
				}
				else if (attribute6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alf())
				{
					P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alG());
				}
				else if (attribute6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.me())
				{
					P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alg());
				}
				else if (attribute6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alH())
				{
					P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alh());
				}
				else
				{
					P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alI());
				}
				if (attribute9 != null)
				{
					P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl());
					P_1.Append(attribute9);
					P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl());
				}
				else
				{
					P_1.Append(attribute8);
				}
				P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E());
			}
			bool flag = false;
			string attribute11 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLt());
			if (attribute11 != null)
			{
				flag = bool.Parse(attribute11);
			}
			bool flag2 = false;
			bool flag3 = false;
			string attribute12 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLU());
			if (attribute12 != null)
			{
				flag2 = attribute12 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLu();
				flag3 = attribute12 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLV();
			}
			if (flag)
			{
				P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLq());
			}
			bool flag4 = false;
			if (!P_0.IsEmptyElement)
			{
				P_0.Read();
				while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && ((!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vd()) && !(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIu())) || (int)P_0.NodeType != 15) && ((!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md()) && !(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs())) || (int)P_0.NodeType != 15) && ((!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ali()) && !(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alJ())) || (int)P_0.NodeType != 15) && ((!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alj()) && !(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alK())) || (int)P_0.NodeType != 15))
				{
					flag4 = false;
					if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vd() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIu())
					{
						A(P_0, ref P_1, P_2, P_3);
						if (flag2)
						{
							P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLv());
							flag4 = true;
						}
						else if (flag3)
						{
							P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLW());
							flag4 = true;
						}
					}
					else if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
					{
						if (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md()) && !(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs()))
						{
							throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alk(), (object)P_0.Name));
						}
						P_0.Read();
						while ((int)P_0.NodeType != 15 || (P_0.Name != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() && P_0.Name != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs()))
						{
							P_0.Read();
						}
					}
					P_0.Read();
				}
				if (flag4)
				{
					P_1.Remove(P_1.Length - 4, 4);
				}
			}
			if (flag)
			{
				P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLR());
			}
			P_1.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E());
		}

		private void a(XmlReader P_0, SettingOrSpecialObject P_1)
		{
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Invalid comparison between Unknown and I4
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Invalid comparison between Unknown and I4
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Invalid comparison between Unknown and I4
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Invalid comparison between Unknown and I4
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Invalid comparison between Unknown and I4
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agh());
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agI());
			string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alL());
			string attribute4 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.all());
			int num = 0;
			if (attribute != null)
			{
				num = int.Parse(attribute);
			}
			int num2 = -1;
			if (attribute2 != null)
			{
				num2 = int.Parse(attribute2);
			}
			ConvertFrom convertFrom = new ConvertFrom(num, num2, attribute3, attribute4);
			if (P_1 is Setting setting)
			{
				setting.A(convertFrom);
			}
			if (P_0.IsEmptyElement)
			{
				return;
			}
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIv()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alM())
				{
					A(P_0, null, convertFrom, null, null);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alm())
				{
					A(P_0, null, convertFrom, null);
				}
				else if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alN(), (object)P_0.Name));
				}
				P_0.Read();
			}
		}

		private void B(XmlReader P_0, SettingOrSpecialObject P_1)
		{
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Invalid comparison between Unknown and I4
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Invalid comparison between Unknown and I4
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Invalid comparison between Unknown and I4
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Invalid comparison between Unknown and I4
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Invalid comparison between Unknown and I4
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agh());
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agI());
			string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alL());
			string attribute4 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.all());
			int num = 0;
			if (attribute != null)
			{
				num = int.Parse(attribute);
			}
			int num2 = -1;
			if (attribute2 != null)
			{
				num2 = int.Parse(attribute2);
			}
			ConvertTo convertTo = new ConvertTo(num, num2, attribute3, attribute4);
			if (P_1 is Setting setting)
			{
				setting.A(convertTo);
			}
			if (P_0.IsEmptyElement)
			{
				return;
			}
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIW()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alM())
				{
					A(P_0, null, null, convertTo, null);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alm())
				{
					A(P_0, null, null, convertTo);
				}
				else if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aln(), (object)P_0.Name));
				}
				P_0.Read();
			}
		}

		private void A(XmlReader P_0, Cc P_1, ConvertFrom P_2, ConvertTo P_3, ModifyOnChange P_4)
		{
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Invalid comparison between Unknown and I4
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Invalid comparison between Unknown and I4
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Invalid comparison between Unknown and I4
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Invalid comparison between Unknown and I4
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Invalid comparison between Unknown and I4
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahU());
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLp());
			string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alO());
			string attribute4 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alo());
			bool flag = false;
			string attribute5 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alP());
			if (attribute5 != null)
			{
				flag = bool.Parse(attribute5);
			}
			string attribute6 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alp());
			int num = -1;
			if (attribute6 != null)
			{
				num = int.Parse(attribute6);
			}
			Cc cc = new Cc(aXO, attribute, attribute2, attribute3, attribute4, num, flag);
			if (P_1 != null)
			{
				P_1.A(cc);
			}
			else if (P_2 != null)
			{
				P_2.A(cc);
			}
			else if (P_3 != null)
			{
				P_3.A(cc);
			}
			else
			{
				P_4?.A(cc);
			}
			if (P_0.IsEmptyElement)
			{
				return;
			}
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alM()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alM())
				{
					A(P_0, cc, P_2, P_3, P_4);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alm())
				{
					A(P_0, cc, P_2, P_3);
				}
				else if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alQ(), (object)P_0.Name));
				}
				P_0.Read();
			}
		}

		private void A(XmlReader P_0, Cc P_1, ConvertFrom P_2, ConvertTo P_3)
		{
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Invalid comparison between Unknown and I4
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Invalid comparison between Unknown and I4
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Invalid comparison between Unknown and I4
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Invalid comparison between Unknown and I4
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Invalid comparison between Unknown and I4
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLp());
			cy cy = new cy(aXO, attribute);
			if (P_1 != null)
			{
				P_1.A(cy);
			}
			else if (P_2 != null)
			{
				P_2.A(cy);
			}
			else
			{
				P_3?.A(cy);
			}
			if (P_0.IsEmptyElement)
			{
				return;
			}
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alm()) || (int)P_0.NodeType != 15))
			{
				if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alq(), (object)P_0.Name));
				}
				P_0.Read();
			}
		}

		private void A(XmlReader P_0, DO P_1)
		{
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Invalid comparison between Unknown and I4
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Invalid comparison between Unknown and I4
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Invalid comparison between Unknown and I4
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Invalid comparison between Unknown and I4
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Invalid comparison between Unknown and I4
			int num = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiI()) || (int)P_0.NodeType != 15))
			{
				if ((P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs()) && P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ()) == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alR())
				{
					if (P_1.C().ContainsKey(num))
					{
						if (P_1.C()[num] == null)
						{
							P_1.C()[num] = new List<int>();
						}
					}
					else
					{
						P_1.C().Add(num, new List<int>());
					}
					int num2 = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
					P_1.C()[num].Add(num2);
				}
				else if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alr(), (object)P_0.Name));
				}
				P_0.Read();
			}
		}

		private void a(XmlReader P_0, DO P_1)
		{
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Invalid comparison between Unknown and I4
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Invalid comparison between Unknown and I4
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Invalid comparison between Unknown and I4
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Invalid comparison between Unknown and I4
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Invalid comparison between Unknown and I4
			int num = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aii()) || (int)P_0.NodeType != 15))
			{
				if ((P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs()) && P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ()) == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alR())
				{
					if (P_1.b().ContainsKey(num))
					{
						if (P_1.b()[num] == null)
						{
							P_1.b()[num] = new List<int>();
						}
					}
					else
					{
						P_1.b().Add(num, new List<int>());
					}
					int num2 = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
					P_1.b()[num].Add(num2);
				}
				else if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alS(), (object)P_0.Name));
				}
				P_0.Read();
			}
		}

		private void d(XmlReader P_0)
		{
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahU());
			string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.als());
			P_0.Read();
			string value = P_0.Value;
			if (string.IsNullOrEmpty(attribute) || string.IsNullOrEmpty(attribute2) || string.IsNullOrEmpty(value) || string.IsNullOrEmpty(attribute3))
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alT());
			}
			int num = -1;
			if (!int.TryParse(attribute3, ref num))
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alt() + attribute + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aII());
			}
			value = value.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay()).Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VU(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay()).Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alU(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
				.Trim();
			string[] array = value.Split(new char[1] { ',' }, (StringSplitOptions)1);
			List<ushort> val = new List<ushort>();
			List<uint> val2 = new List<uint>();
			string[] array2 = array;
			int num2 = default(int);
			foreach (string text in array2)
			{
				string text2 = text;
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dI()))
				{
					text2 = text.Substring(2);
				}
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (int.TryParse(text2, (NumberStyles)515, (IFormatProvider)(object)CultureInfo.InvariantCulture, ref num2))
				{
					if (text2.Length == 3)
					{
						val.Add((ushort)num2);
						continue;
					}
					if (text2.Length == 8)
					{
						val2.Add((uint)num2);
						continue;
					}
					defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(102, 2);
					defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alu());
					defaultInterpolatedStringHandler.AppendFormatted(attribute);
					defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alV());
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alv());
					throw new System.Exception(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(55, 2);
				defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alu());
				defaultInterpolatedStringHandler.AppendFormatted(attribute);
				defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh());
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alW());
				throw new System.Exception(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			if (!aXO.awH.ContainsKey(num))
			{
				aXO.awH[num] = new List<Cd>();
			}
			List<Cd> obj = aXO.awH[num];
			Cd cd = new Cd();
			cd.A(attribute);
			cd.a(attribute2);
			cd.A(num);
			cd.A(val);
			cd.A(val2);
			obj.Add(cd);
			P_0.Read();
		}

		private void E(XmlReader P_0)
		{
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Invalid comparison between Unknown and I4
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Invalid comparison between Unknown and I4
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Invalid comparison between Unknown and I4
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahf()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alw() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alX())
				{
					e(P_0);
					P_0.Read();
					continue;
				}
				throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alx(), (object)P_0.Name));
			}
		}

		private void e(XmlReader P_0)
		{
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Invalid comparison between Unknown and I4
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Invalid comparison between Unknown and I4
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Invalid comparison between Unknown and I4
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Invalid comparison between Unknown and I4
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Invalid comparison between Unknown and I4
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIL());
			string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIB());
			CA cA;
			if (attribute3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alY())
			{
				cA = CA.aYz;
			}
			else if (attribute3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aly())
			{
				cA = CA.ayA;
			}
			else
			{
				if (!(attribute3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alZ()))
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alz(), (object)attribute3));
				}
				cA = CA.aya;
			}
			CB cB = new CB(aXO, attribute, attribute2, cA);
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && ((!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alw()) && !(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alX())) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs())
				{
					A(P_0, cB);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ali() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alJ())
				{
					B(P_0, cB);
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alj() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alK())
				{
					b(P_0, cB);
				}
				else if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMA(), (object)P_0.Name));
				}
				P_0.Read();
			}
			aXO.awn.Add(attribute, cB);
		}

		private void A(XmlReader P_0, CB P_1)
		{
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			if (attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMa())
			{
				P_1.A(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP())));
			}
			else if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMB()))
			{
				P_1.E().Add(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP())));
			}
			else if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMb()))
			{
				P_1.e().Add(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP())));
			}
			else if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kw()))
			{
				a(P_0, P_1);
			}
			else if (!P_0.IsEmptyElement)
			{
				P_0.Skip();
			}
		}

		private void a(XmlReader P_0, CB P_1)
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			bool flag = true;
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLp());
			if (attribute == null)
			{
				attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLQ());
			}
			if (attribute != null)
			{
				flag = bool.Parse(attribute);
			}
			StringBuilder val = new StringBuilder(100);
			A(P_0, ref val);
			if (!flag)
			{
				val.Insert(0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLq());
				val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLR());
			}
			P_1.A(((object)val).ToString());
		}

		private void B(XmlReader P_0, CB P_1)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIL());
			CC cC = new CC(P_1, aXO, attribute);
			bool flag = true;
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLp());
			if (attribute2 == null)
			{
				attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLQ());
			}
			if (attribute2 != null)
			{
				flag = bool.Parse(attribute2);
			}
			StringBuilder val = new StringBuilder(100);
			A(P_0, ref val, cC);
			if (!flag)
			{
				val.Insert(0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLq());
				val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLR());
			}
			cC.B(((object)val).ToString());
			P_1.A(cC);
		}

		private void b(XmlReader P_0, CB P_1)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIL());
			Cb cb = new Cb(P_1, aXO, attribute);
			bool flag = true;
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLp());
			if (attribute2 == null)
			{
				attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLQ());
			}
			if (attribute2 != null)
			{
				flag = bool.Parse(attribute2);
			}
			StringBuilder val = new StringBuilder(100);
			A(P_0, ref val, cb);
			if (!flag)
			{
				val.Insert(0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLq());
				val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLR());
			}
			cb.B(((object)val).ToString());
			P_1.f().Add(cb);
		}

		private void F(XmlReader P_0)
		{
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Invalid comparison between Unknown and I4
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Invalid comparison between Unknown and I4
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Invalid comparison between Unknown and I4
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Invalid comparison between Unknown and I4
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Invalid comparison between Unknown and I4
			a();
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahg()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMC() && (int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					A(P_0, aXO.awj[0]);
				}
				else if ((P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs()) && P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ()) == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMc())
				{
					MenuNode menuNode = aXO.awj[0];
					menuNode.f(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					aXO.awX.Add(menuNode.W(), menuNode);
				}
				P_0.Read();
			}
		}

		private void f(XmlReader P_0)
		{
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Invalid comparison between Unknown and I4
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Invalid comparison between Unknown and I4
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Invalid comparison between Unknown and I4
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Invalid comparison between Unknown and I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Invalid comparison between Unknown and I4
			P_0.Read();
			while (P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13)
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahH() && (int)P_0.NodeType == 15)
				{
					A(aXO.awj[0].c());
					break;
				}
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMC() && (int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					a(P_0, aXO.awj[0]);
				}
				P_0.Read();
			}
		}

		private void G(XmlReader P_0)
		{
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Invalid comparison between Unknown and I4
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Invalid comparison between Unknown and I4
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Invalid comparison between Unknown and I4
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Invalid comparison between Unknown and I4
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Invalid comparison between Unknown and I4
			if (aXO.awl == null)
			{
				MenuNode menuNode = new MenuNode(aXO, null, null, false, true, string.Empty);
				menuNode.A(-1);
				menuNode.a(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yL());
				menuNode.a(0);
				aXO.awl = menuNode;
			}
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahh()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMC() && (int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					B(P_0, aXO.awl);
				}
				P_0.Read();
			}
		}

		private void g(XmlReader P_0)
		{
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Invalid comparison between Unknown and I4
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Invalid comparison between Unknown and I4
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Invalid comparison between Unknown and I4
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Invalid comparison between Unknown and I4
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Invalid comparison between Unknown and I4
			if (aXO.awm == null)
			{
				MenuNode menuNode = new MenuNode(aXO, null, null, false, true, string.Empty);
				menuNode.A(-1);
				menuNode.a(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PD());
				menuNode.a(0);
				aXO.awm = menuNode;
			}
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahI()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMC() && (int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					b(P_0, aXO.awm);
				}
				P_0.Read();
			}
		}

		private void A(List<MenuNode> P_0)
		{
			for (int i = 0; i < P_0.Count; i++)
			{
				if (!P_0[i].D())
				{
					MenuNode menuNode = P_0[i];
					menuNode.a(menuNode.e() + aXO.awk);
					A(P_0[i].c());
				}
			}
		}

		private void a()
		{
			if (aXO.awj.Count == 0)
			{
				string text = aXO.awY + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ix() + (object)aXO.aXA;
				MenuNode menuNode = new MenuNode(aXO, null, null, false, true, string.Empty);
				menuNode.A(-1);
				menuNode.a(text);
				menuNode.D(aXO.aXC);
				menuNode.a(0);
				aXO.awj.Add(menuNode);
			}
		}

		private void A(XmlReader P_0, MenuNode P_1)
		{
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Invalid comparison between Unknown and I4
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Invalid comparison between Unknown and I4
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Invalid comparison between Unknown and I4
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			int num = -1;
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alB());
			if (attribute2 != null)
			{
				num = int.Parse(attribute2);
			}
			string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMD());
			bool flag = false;
			string attribute4 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMd());
			if (attribute4 != null)
			{
				flag = bool.Parse(attribute4);
			}
			MenuNode menuNode = new MenuNode(aXO, null, P_1, false, flag, attribute3);
			menuNode.A(num);
			menuNode.a(attribute);
			aXO.awK++;
			menuNode.a(aXO.awK);
			if (num != -1)
			{
				aXO.a(num).A(menuNode);
			}
			if (attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aME())
			{
				aXO.awR = menuNode;
				aXO.awr = menuNode;
			}
			else if (attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMe())
			{
				aXO.awr = menuNode;
			}
			else if (attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMF())
			{
				if (menuNode.C().E() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMf())
				{
					aXO.awU = menuNode;
				}
				else if (menuNode.C().E() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMG())
				{
					aXO.awu = menuNode;
				}
				else if (menuNode.C().E() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMg())
				{
					aXO.awV = menuNode;
				}
			}
			if (attribute.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMH()))
			{
				aXO.awS = menuNode;
			}
			if (!P_0.IsEmptyElement)
			{
				P_0.Read();
				while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMC()) || (int)P_0.NodeType != 15))
				{
					if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs())
					{
						c(P_0, menuNode);
					}
					else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMC())
					{
						A(P_0, menuNode);
					}
					P_0.Read();
				}
			}
			P_1?.c().Add(menuNode);
		}

		private void a(XmlReader P_0, MenuNode P_1)
		{
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Invalid comparison between Unknown and I4
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Invalid comparison between Unknown and I4
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Invalid comparison between Unknown and I4
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			int num = -1;
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alB());
			if (attribute2 != null)
			{
				num = int.Parse(attribute2);
			}
			string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMD());
			aXO.awk++;
			MenuNode menuNode = new MenuNode(aXO, null, P_1, true, false, attribute3);
			menuNode.A(num);
			menuNode.a(attribute);
			aXO.awk++;
			menuNode.a(aXO.awk);
			if (num != -1)
			{
				aXO.a(num).A(menuNode);
			}
			if (!P_0.IsEmptyElement)
			{
				P_0.Read();
				while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMC()) || (int)P_0.NodeType != 15))
				{
					if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs())
					{
						c(P_0, menuNode);
					}
					else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMC())
					{
						a(P_0, menuNode);
					}
					P_0.Read();
				}
			}
			if (P_1 == null)
			{
				return;
			}
			if (P_1.C() == null)
			{
				int num2 = 0;
				for (int i = 0; i < P_1.c().Count && P_1.c()[i].D(); i++)
				{
					num2++;
				}
				P_1.c().Insert(num2, menuNode);
			}
			else
			{
				P_1.c().Add(menuNode);
			}
		}

		private void B(XmlReader P_0, MenuNode P_1)
		{
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Invalid comparison between Unknown and I4
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Invalid comparison between Unknown and I4
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Invalid comparison between Unknown and I4
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			int num = -1;
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alB());
			if (attribute2 != null)
			{
				num = int.Parse(attribute2);
			}
			string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMD());
			bool flag = false;
			string attribute4 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMd());
			if (attribute4 != null)
			{
				flag = bool.Parse(attribute4);
			}
			MenuNode menuNode = new MenuNode(aXO, null, P_1, false, flag, attribute3);
			menuNode.A(num);
			menuNode.a(attribute);
			aXO.awM++;
			menuNode.a(aXO.awM);
			if (!P_0.IsEmptyElement)
			{
				P_0.Read();
				while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMC()) || (int)P_0.NodeType != 15))
				{
					if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs())
					{
						c(P_0, menuNode);
					}
					else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMh())
					{
						C(P_0, menuNode);
					}
					else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMC())
					{
						B(P_0, menuNode);
					}
					P_0.Read();
				}
			}
			P_1?.c().Add(menuNode);
		}

		private void b(XmlReader P_0, MenuNode P_1)
		{
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Invalid comparison between Unknown and I4
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Invalid comparison between Unknown and I4
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Invalid comparison between Unknown and I4
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			int num = -1;
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alB());
			if (attribute2 != null)
			{
				num = int.Parse(attribute2);
			}
			string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMD());
			bool flag = false;
			string attribute4 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMd());
			if (attribute4 != null)
			{
				flag = bool.Parse(attribute4);
			}
			MenuNode menuNode = new MenuNode(aXO, null, P_1, false, flag, attribute3);
			menuNode.A(num);
			menuNode.a(attribute);
			aXO.awN++;
			menuNode.a(aXO.awN);
			if (!P_0.IsEmptyElement)
			{
				P_0.Read();
				while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMC()) || (int)P_0.NodeType != 15))
				{
					if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md() || P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahs())
					{
						c(P_0, menuNode);
					}
					else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMC())
					{
						b(P_0, menuNode);
					}
					P_0.Read();
				}
			}
			P_1?.c().Add(menuNode);
		}

		private void C(XmlReader P_0, MenuNode P_1)
		{
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Invalid comparison between Unknown and I4
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Invalid comparison between Unknown and I4
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Invalid comparison between Unknown and I4
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Invalid comparison between Unknown and I4
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Invalid comparison between Unknown and I4
			int num = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMI()));
			ModifyOnChange modifyOnChange = new ModifyOnChange(aXO, num);
			P_1.A(modifyOnChange);
			if (P_0.IsEmptyElement)
			{
				return;
			}
			P_0.Read();
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMh()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alM())
				{
					A(P_0, null, null, null, modifyOnChange);
				}
				else if ((int)P_0.NodeType != 15 && (int)P_0.NodeType != 13)
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMi(), (object)P_0.Name));
				}
				P_0.Read();
			}
		}

		private void c(XmlReader P_0, MenuNode P_1)
		{
			string empty = string.Empty;
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
			if (attribute != null)
			{
				switch (attribute.Length)
				{
				case 14:
					switch (attribute[0])
					{
					case 'P':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aKa()))
						{
							break;
						}
						P_1.B(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						aXO.a(P_1.H()).A(P_1);
						if (!P_1.D())
						{
							for (int i = 0; i < 20; i++)
							{
								MenuNode menuNode = new MenuNode(aXO, null, P_1, false, false, string.Empty);
								menuNode.A(true);
								menuNode.A(-1);
								menuNode.a(null);
								aXO.awK++;
								menuNode.a(aXO.awK);
								P_1.c().Add(menuNode);
							}
						}
						return;
					case 'I':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMJ()))
						{
							break;
						}
						return;
					}
					break;
				case 21:
					switch (attribute[0])
					{
					case 'F':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMj()))
						{
							break;
						}
						P_1.b(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						aXO.aWz = true;
						aXO.A(P_1.h()).A(P_1);
						return;
					case 'A':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMK()))
						{
							break;
						}
						P_1.h(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						return;
					}
					break;
				case 4:
					switch (attribute[0])
					{
					case 'T':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.alX()))
						{
							break;
						}
						P_1.A(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLX()));
						return;
					case 'S':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jb()))
						{
							break;
						}
						return;
					}
					break;
				case 7:
					switch (attribute[0])
					{
					case 'C':
					{
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMc()))
						{
							break;
						}
						P_1.f(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						string attribute3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajt());
						if (attribute3 != null)
						{
							P_1.F(bool.Parse(attribute3));
						}
						string attribute4 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajU());
						if (attribute4 != null)
						{
							P_1.f(bool.Parse(attribute4));
						}
						aXO.awX.Add(P_1.W(), P_1);
						return;
					}
					case 'S':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aML()))
						{
							break;
						}
						P_1.d(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						return;
					case 'F':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMl()))
						{
							break;
						}
						P_1.E(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						return;
					}
					break;
				case 22:
					switch (attribute[0])
					{
					case 'H':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMM()))
						{
							break;
						}
						P_1.g(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						return;
					case 'C':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMm()))
						{
							break;
						}
						A(P_0, ref empty);
						P_1.d(empty);
						return;
					}
					break;
				case 11:
					switch (attribute[0])
					{
					case 'D':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aT()))
						{
							break;
						}
						A(P_0, ref empty);
						P_1.b(empty);
						return;
					case 'R':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aLc()))
						{
							break;
						}
						P_1.a(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						return;
					}
					break;
				case 8:
					switch (attribute[0])
					{
					case 'H':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aip()))
						{
							break;
						}
						A(P_0, ref empty);
						P_1.c(empty);
						return;
					case 'P':
					{
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aDa()))
						{
							break;
						}
						string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL());
						attribute2 = attribute2.Substring(1, attribute2.Length - 2);
						P_1.C(int.Parse(attribute2.Substring(0, 1)));
						P_1.c(int.Parse(attribute2.Substring(attribute2.Length - 1, 1)));
						return;
					}
					case 'M':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMO()))
						{
							break;
						}
						return;
					case 'C':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMo()))
						{
							break;
						}
						return;
					}
					break;
				case 13:
					switch (attribute[0])
					{
					case 'I':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahj()))
						{
							break;
						}
						P_0.Read();
						P_1.D(P_0.Value);
						P_0.Skip();
						return;
					case 'S':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMP()))
						{
							break;
						}
						return;
					}
					break;
				case 24:
					switch (attribute[0])
					{
					case 'I':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMR()))
						{
							break;
						}
						P_1.c(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						return;
					case 'D':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMr()))
						{
							break;
						}
						P_1.d(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						return;
					}
					break;
				case 23:
					switch (attribute[0])
					{
					case 'D':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMs()))
						{
							break;
						}
						P_1.E(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						return;
					case 'C':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMT()))
						{
							break;
						}
						P_1.e(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						return;
					}
					break;
				case 12:
					switch (attribute[0])
					{
					case 'D':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMt()))
						{
							break;
						}
						P_1.D(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
						return;
					case 'F':
						if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMU()))
						{
							break;
						}
						return;
					}
					break;
				case 6:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KZ()))
					{
						break;
					}
					P_1.F(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					aXO.awA = true;
					aXO.awB.Add(P_1.s(), P_1);
					if (P_1.s() > aXO.awa)
					{
						aXO.awa = P_1.s();
					}
					return;
				case 18:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMk()))
					{
						break;
					}
					if (bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())))
					{
						aXO.awL.Add(P_1);
					}
					return;
				case 27:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMN()))
					{
						break;
					}
					P_1.H(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					return;
				case 33:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMn()))
					{
						break;
					}
					P_1.I(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					return;
				case 10:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kr()))
					{
						break;
					}
					A(P_0, ref empty);
					P_1.C(empty);
					return;
				case 5:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahJ()))
					{
						break;
					}
					P_0.Read();
					P_0.Skip();
					return;
				case 17:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMp()))
					{
						break;
					}
					P_1.B(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					return;
				case 34:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMQ()))
					{
						break;
					}
					P_1.b(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					return;
				case 32:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMq()))
					{
						break;
					}
					P_1.C(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					return;
				case 15:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMS()))
					{
						break;
					}
					P_1.D(int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					return;
				case 28:
					if (!(attribute == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMu()))
					{
						break;
					}
					P_1.e(bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL())));
					return;
				}
			}
			if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ajS()))
			{
				A(P_0, ref empty);
				P_1.V().Add(empty);
			}
			else if (attribute.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMV()))
			{
				int num = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahL()));
				P_1.aE().Add(num);
			}
			else if (!P_0.IsEmptyElement)
			{
				P_0.Skip();
			}
		}
	}
	internal class bv
	{
		internal int axq;

		internal int axR;

		internal k axr;

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
			if (obj is bv)
			{
				return this == obj as bv;
			}
			return false;
		}

		public static bool operator ==(bv P_0, bv P_1)
		{
			if ((object)P_0 == null || (object)P_1 == null)
			{
				return (object)P_0 == P_1;
			}
			if (P_0.axq == P_1.axq && P_0.axR == P_1.axR)
			{
				return P_0.axr == P_1.axr;
			}
			return false;
		}

		public static bool operator !=(bv P_0, bv P_1)
		{
			return !(P_0 == P_1);
		}

		public virtual string ToString()
		{
			return string.Concat(new string[6]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amA(),
				axq.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ama(),
				axR.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aN(),
				((object)axr).ToString()
			});
		}
	}
}
