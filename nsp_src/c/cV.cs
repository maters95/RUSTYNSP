using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;

namespace c
{
	internal class cV : aj
	{
		private new delegate void A(object P_0, EventArgs P_1);

		private new delegate void a(object P_0, EventArgs P_1);

		private Label BNm = new Label();

		private aH BNN = new aH();

		private Cn BNn;

		private int BNO;

		private bool BNo;

		internal cV(DataIdAndAttrId P_0, Framework P_1, Framework P_2, Cn P_3)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			((Control)this).SetStyle((ControlStyles)512, true);
			((Control)this).SetStyle((ControlStyles)131072, true);
			((Control)this).DoubleBuffered = true;
			A(P_0, P_1, P_2, P_3);
		}

		private void A(DataIdAndAttrId P_0, Framework P_1, Framework P_2, Cn P_3)
		{
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected O, but got Unknown
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_0290: Expected O, but got Unknown
			//IL_029d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a7: Expected O, but got Unknown
			//IL_0371: Unknown result type (might be due to invalid IL or missing references)
			//IL_0376: Unknown result type (might be due to invalid IL or missing references)
			A(P_1, P_2);
			A(P_0);
			BNn = P_3;
			if (BNn != null)
			{
				int[] array = BNn.a(ic);
				if (array != null && array.Length == 1)
				{
					BNO = array[0];
				}
				else
				{
					BNn = null;
				}
			}
			C();
			bool flag = c();
			List<Control> val = new List<Control>();
			BM.QQ.B(new EventHandler(b));
			ic.A(new EventHandler(c));
			((SettingOrSpecialObject)ic).A(new EventHandler(C));
			bool flag2 = BM.QO == BM.b.BpF && (iF || @if) && ib != null;
			((Control)this).SuspendLayout();
			if (flag2)
			{
				((Control)BNm).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bci() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
			}
			else if (flag)
			{
				((Control)BNm).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO();
			}
			else
			{
				((Control)BNm).Text = ((SettingOrSpecialObject)ic).A(false);
			}
			Setting setting = ((BM.QO != BM.b.BpG || iD == null) ? ic : iD);
			int num = setting.ax();
			BNN.B();
			int num2 = -1;
			List<Setting.ListItems.A> val2 = setting.d(0);
			for (int i = 0; i < val2.Count; i++)
			{
				if (val2[i].bBv == num)
				{
					num2 = i;
				}
				Image val3 = setting.n(val2[i].bBv);
				BNN.A(val3, val2[i].bBV, null);
			}
			BNN.a((num2 < BNN.b()) ? num2 : (-1));
			((Control)BNm).Left = 0;
			((Control)BNm).Top = 3;
			((Control)BNm).AutoSize = true;
			((Control)BNN).Left = 0;
			((Control)BNN).Top = ((Control)BNm).Top + 17;
			val.Add((Control)(object)BNm);
			if (!((Control)this).Controls.Contains((Control)(object)BNm))
			{
				((Control)this).Controls.Add((Control)(object)BNm);
			}
			if (!flag && !flag2)
			{
				BNN.A(new EventHandler(D));
				((Control)BNN).GotFocus += new EventHandler(B);
			}
			b();
			if (!flag && !flag2)
			{
				val.Add((Control)(object)BNN);
				if (!((Control)this).Controls.Contains((Control)(object)BNN))
				{
					((Control)this).Controls.Add((Control)(object)BNN);
				}
			}
			for (int num3 = ((ArrangedElementCollection)((Control)this).Controls).Count - 1; num3 >= 0; num3--)
			{
				if (!val.Contains(((Control)this).Controls[num3]))
				{
					((Control)this).Controls.RemoveAt(num3);
				}
			}
			((Control)this).AutoSize = false;
			bool flag3 = ib != null && (iF || @if);
			if (flag3)
			{
				Size val4 = TextRenderer.MeasureText(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO(), ((Control)BNm).Font);
				((Control)this).Width = ((Size)(ref val4)).Width;
			}
			if (flag || flag2)
			{
				if (flag3)
				{
					((Control)this).Height = 20 + ((Control)BNN).Height;
				}
				else
				{
					((Control)this).Width = ((Control)BNm).Width;
					((Control)this).Height = ((Control)BNm).Height * 2;
				}
			}
			else if (flag3)
			{
				((Control)this).Height = 20 + ((Control)BNN).Height;
			}
			else
			{
				((Control)this).Width = Math.Max(((Control)BNm).Width, ((Control)BNN).Width);
				((Control)this).Height = ((Control)BNN).Bottom;
			}
			((Control)this).ResumeLayout(true);
		}

		private new void b()
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			if (((SettingOrSpecialObject)ic).l() && iB.C())
			{
				((Control)BNm).ForeColor = BM.te;
			}
			else
			{
				((Control)BNm).ForeColor = BM.tq;
			}
			bool flag = (BM.QO != BM.b.BpG || iD == null) && ((SettingOrSpecialObject)ic).l() && iB.C();
			if (flag && !ic.O())
			{
				((Control)BNN).Enabled = true;
				switch (ic.P())
				{
				case IllegalitySeverityLevel.Error:
					((Control)BNN).BackColor = Color.Red;
					break;
				case IllegalitySeverityLevel.Warning:
					((Control)BNN).BackColor = Color.Orange;
					break;
				case IllegalitySeverityLevel.ErrorIfOnline:
					if (BM.A(iB.aXc, true))
					{
						((Control)BNN).BackColor = Color.Red;
					}
					else
					{
						((Control)BNN).BackColor = Color.Orange;
					}
					break;
				default:
					((Control)BNN).BackColor = Color.Red;
					break;
				}
			}
			else
			{
				((Control)BNN).Enabled = flag;
				bool flag2 = iF || @if;
				if (iD != null && !flag2 && !ic.A(iD))
				{
					((Control)BNN).BackColor = BM.tD;
				}
				else if (((Control)BNN).Enabled)
				{
					((Control)BNN).BackColor = BM.to;
				}
				else
				{
					((Control)BNN).BackColor = BM.tQ;
				}
			}
			((Control)this).TabStop = ((Control)BNN).Enabled;
			((Panel)BNN).TabStop = ((Control)this).TabStop;
			BNN.A();
			((Control)BNN).Invalidate();
		}

		protected override void OnGotFocus(EventArgs e)
		{
			((Control)this).OnGotFocus(e);
			((Control)BNN).Focus();
		}

		private new void B(object P_0, EventArgs P_1)
		{
			BM.QQ.rL.A(ic);
		}

		private new void b(object P_0, EventArgs P_1)
		{
			if (iF || @if)
			{
				A();
				return;
			}
			C();
			b();
		}

		private new void C()
		{
			Setting setting = ((BM.QO != BM.b.BpG || iD == null) ? ic : iD);
			int num = -1;
			int num2 = setting.ax();
			List<Setting.ListItems.A> val = setting.d(0);
			for (int i = 0; i < val.Count; i++)
			{
				if (val[i].bBv == num2)
				{
					num = i;
					break;
				}
			}
			if (BNN.a() != num && num != -1 && num < BNN.b())
			{
				BNN.a(num);
			}
		}

		private new void C(object P_0, EventArgs P_1)
		{
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			if (((Control)this).InvokeRequired)
			{
				try
				{
					A a = C;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			List<Setting.ListItems.A> val = ic.d(0);
			bool flag = false;
			if (val.Count != BNN.b())
			{
				flag = true;
			}
			else
			{
				for (int i = 0; i < BNN.b(); i++)
				{
					if (val[i].bBV != BNN.b(i))
					{
						flag = true;
						break;
					}
					Image val2 = ic.n(val[i].bBv);
					Image val3 = BNN.B(i);
					byte[] array = null;
					byte[] array2 = null;
					if (val2 != null && val3 != null)
					{
						MemoryStream val4 = new MemoryStream();
						try
						{
							val2.Save((Stream)(object)val4, val2.RawFormat);
							array = val4.ToArray();
						}
						finally
						{
							((System.IDisposable)val4)?.Dispose();
						}
						MemoryStream val5 = new MemoryStream();
						try
						{
							val3.Save((Stream)(object)val5, val3.RawFormat);
							array2 = val5.ToArray();
						}
						finally
						{
							((System.IDisposable)val5)?.Dispose();
						}
					}
					if (val2 != null)
					{
						val2.Dispose();
					}
					if (array == null || array2 == null || array.Length != array2.Length)
					{
						flag = true;
						break;
					}
					for (int j = 0; j < array.Length; j++)
					{
						if (array[j] != array2[j])
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						break;
					}
				}
			}
			if (flag)
			{
				A();
			}
			else
			{
				b();
			}
		}

		private void c(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					a a = c;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			if (BM.QO != BM.b.BpG)
			{
				C();
				if (iD != null)
				{
					b();
				}
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Invalid comparison between Unknown and I4
			if (BM.QO == BM.b.BpG)
			{
				return;
			}
			if (BM.QP)
			{
				BM.A(ic.C());
			}
			else if (BNo)
			{
				BNo = false;
			}
			else
			{
				if (BNN.a() == -1)
				{
					return;
				}
				List<Setting.ListItems.A> val = ic.d(0);
				if (ic.ax() == val[BNN.a()].bBv)
				{
					return;
				}
				bool flag = false;
				string text = ((SettingOrSpecialObject)ic).P();
				if (text != null && val[BNN.a()].bBv != 0 && !Bg.A(ic, null))
				{
					Bg bg = new Bg(text, ic, null);
					if ((int)((Form)bg).ShowDialog((IWin32Window)(object)BM.QQ) != 1)
					{
						flag = true;
					}
					((Component)bg).Dispose();
				}
				if (flag)
				{
					for (int i = 0; i < val.Count; i++)
					{
						if (val[i].bBv == ic.ax())
						{
							BNo = true;
							BNN.a((i < BNN.b()) ? i : (-1));
							break;
						}
					}
				}
				else
				{
					Ck ck2 = BM.aM();
					ck2?.A(ic.C());
					ic.a(val[BNN.a()].bBv, true);
					ck2?.B();
					BM.A(ic.C());
				}
			}
		}

		public override string ToString()
		{
			return ((SettingOrSpecialObject)ic).A(true);
		}

		protected override void A()
		{
			c();
			if (((Control)this).Parent != null)
			{
				((Control)this).Parent.SuspendLayout();
			}
			BNN.B();
			A(iC, iB, ib, BNn);
			if (((Control)this).Parent != null)
			{
				((Control)this).Parent.ResumeLayout(true);
			}
		}

		private new void c()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Expected O, but got Unknown
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			try
			{
				BNN.a(new EventHandler(D));
				((Control)BNN).GotFocus -= new EventHandler(B);
				ic.a(new EventHandler(c));
				((SettingOrSpecialObject)ic).a(new EventHandler(C));
				if (iE != null)
				{
					((SettingOrSpecialObject)iE).a(new EventHandler(((aj)this).B));
				}
				if (ie != null)
				{
					ie.a(new EventHandler(((aj)this).b));
				}
				BM.QQ.b(new EventHandler(b));
			}
			catch
			{
			}
		}

		protected override void Dispose(bool disposing)
		{
			c();
			BNN.B();
			try
			{
				base.Dispose(disposing);
			}
			catch
			{
			}
		}
	}
	internal abstract class cv : aj
	{
		protected ThemedTextBox BNP = new ThemedTextBox();

		protected bool BNp;

		protected Cn BNQ;

		protected bool BNq;

		protected int BNR;

		[SpecialName]
		internal new ThemedTextBox b()
		{
			return BNP;
		}

		protected override ContextMenuStrip a()
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected O, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected O, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Expected O, but got Unknown
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected O, but got Unknown
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Expected O, but got Unknown
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected O, but got Unknown
			ContextMenuStrip val = null;
			if (iB.C() && !c())
			{
				val = new ContextMenuStrip();
				((ToolStripDropDown)val).Opening += new CancelEventHandler(A);
				((ToolStrip)val).BackColor = BM.tG;
				((ToolStrip)val).ForeColor = BM.te;
				ToolStripMenuItem val2 = new ToolStripMenuItem();
				((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fU();
				((ToolStripItem)val2).Click += new EventHandler(base.C);
				((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
				ToolStripMenuItem val3 = new ToolStripMenuItem();
				((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcT();
				((ToolStripItem)val3).Click += new EventHandler(B);
				((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
				ToolStripMenuItem val4 = new ToolStripMenuItem();
				((ToolStripItem)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mk();
				((ToolStripItem)val4).Click += new EventHandler(b);
				((ToolStrip)val).Items.Add((ToolStripItem)(object)val4);
				ToolStripMenuItem val5 = new ToolStripMenuItem();
				((ToolStripItem)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ml();
				((ToolStripItem)val5).Click += new EventHandler(C);
				((ToolStrip)val).Items.Add((ToolStripItem)(object)val5);
				ToolStripMenuItem val6 = new ToolStripMenuItem();
				((ToolStripItem)val6).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bct();
				((ToolStripItem)val6).Click += new EventHandler(c);
				((ToolStrip)val).Items.Add((ToolStripItem)(object)val6);
			}
			return val;
		}

		private void A(object P_0, CancelEventArgs P_1)
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((P_0 is ContextMenuStrip) ? P_0 : null)).Items)
			{
				ToolStripMenuItem val = item;
				string text = ((ToolStripItem)val).Text;
				if (!(text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcT()))
				{
					if (!(text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mk()))
					{
						if (!(text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ml()))
						{
							if (text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bct())
							{
								((ToolStripItem)val).Enabled = ((Control)BNP).Text.Length > 0;
							}
						}
						else
						{
							((ToolStripItem)val).Enabled = Clipboard.ContainsText();
						}
					}
					else
					{
						((ToolStripItem)val).Enabled = ((TextBoxBase)BNP).SelectionLength > 0;
					}
				}
				else
				{
					((ToolStripItem)val).Enabled = ((TextBoxBase)BNP).SelectionLength > 0;
				}
			}
		}

		private new void B(object P_0, EventArgs P_1)
		{
			((TextBoxBase)BNP).Cut();
		}

		private new void b(object P_0, EventArgs P_1)
		{
			((TextBoxBase)BNP).Copy();
		}

		private new void C(object P_0, EventArgs P_1)
		{
			if (Clipboard.ContainsText())
			{
				((TextBoxBase)BNP).Paste();
			}
		}

		private void c(object P_0, EventArgs P_1)
		{
			((TextBoxBase)BNP).SelectAll();
		}

		protected override void Dispose(bool disposing)
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected O, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Expected O, but got Unknown
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected O, but got Unknown
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Expected O, but got Unknown
			if (((Control)BNP).ContextMenuStrip != null)
			{
				foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)BNP).ContextMenuStrip).Items)
				{
					((ToolStripItem)item).Click -= new EventHandler(base.C);
					((ToolStripItem)item).Click -= new EventHandler(B);
					((ToolStripItem)item).Click -= new EventHandler(b);
					((ToolStripItem)item).Click -= new EventHandler(C);
					((ToolStripItem)item).Click -= new EventHandler(c);
				}
				((Component)((Control)BNP).ContextMenuStrip).Dispose();
			}
			if (((Control)this).ContextMenuStrip != null)
			{
				foreach (ToolStripMenuItem item2 in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
				{
					((ToolStripItem)item2).Click -= new EventHandler(base.C);
					((ToolStripItem)item2).Click -= new EventHandler(B);
					((ToolStripItem)item2).Click -= new EventHandler(b);
					((ToolStripItem)item2).Click -= new EventHandler(C);
					((ToolStripItem)item2).Click -= new EventHandler(c);
				}
				((Component)((Control)this).ContextMenuStrip).Dispose();
				((Control)this).ContextMenuStrip = null;
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
}
namespace C
{
	internal enum CV : uint
	{
		BDk = 0u,
		BDL = 1u,
		BDl = 2u,
		BDM = 3u,
		BDm = 4u,
		BDN = 5u,
		BDn = 6u,
		BDO = 7u,
		BDo = 8u,
		BDP = 9u,
		BDp = 10u,
		BDQ = 11u,
		BDq = 12u,
		BDR = 13u,
		BDr = 14u,
		BDS = 15u,
		BDs = 16u,
		BDT = 17u,
		BDt = 25u
	}
	internal class Cv
	{
		internal uint BDU;

		internal CV BDu;

		internal byte BDV;

		internal k BDv;

		internal uint BDW;

		internal uint BDw;

		internal uint BDX;

		internal uint BDx;

		internal byte[] BDY;
	}
}
