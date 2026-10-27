using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;
using c;

namespace D;

internal class DA : cq
{
	private new delegate void A(object P_0, EventArgs P_1);

	private new delegate void a(object P_0, EventArgs P_1);

	private Framework BUj;

	private CB BUK;

	private Setting BUk;

	private Rectangle BUL;

	private float BUl = 1f;

	private ThemedButton BUM;

	internal DA(CB P_0, Framework P_1, Rectangle P_2, bool P_3, bool P_4, float P_5 = 1f)
		: base(P_2, P_3, P_4)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		BUj = P_1;
		BUK = P_0;
		BUK.A(new EventHandler(B));
		BUL = P_2;
		BUl = P_5;
		if (BUK.d() > 0)
		{
			BUk = BUj.A(BUK.d());
			if (BUk != null)
			{
				BUk.A(new EventHandler(b));
			}
		}
	}

	public override string ToString()
	{
		string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bef();
		if (BUK != null && !string.IsNullOrEmpty(BUK.c()))
		{
			text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FZ() + BUK.c();
		}
		return text;
	}

	private void B(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = B;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (((ArrangedElementCollection)((Control)base.B()).Controls).Count != 0)
		{
			A(false);
		}
	}

	internal new void A(bool P_0)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((Control)base.B()).SuspendLayout();
		int num = 5;
		int num2 = 10;
		A(ref num, ref num2);
		a(ref num, ref num2);
		B(ref num, ref num2);
		b(ref num, ref num2);
		if (BUK.D() == CA.ayA && BUk != null)
		{
			A(P_0, ref num, ref num2);
		}
		B();
		if (BUL != Rectangle.Empty)
		{
			if (P_0)
			{
				((Control)this).Width = ((Rectangle)(ref BUL)).Width;
				((Control)this).Height = ((Rectangle)(ref BUL)).Height;
				((Control)this).Left = ((Rectangle)(ref BUL)).Left;
				((Control)this).Top = ((Rectangle)(ref BUL)).Top;
			}
		}
		else
		{
			int num3 = 0;
			int num4 = 0;
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val = item;
				num3 = Math.Max(num3, val.Right + 10);
				num4 = Math.Max(num4, val.Bottom + 10);
			}
			if (((Control)this).Width != num3)
			{
				((Control)this).Width = num3;
			}
			if (((Control)this).Height != num4)
			{
				((Control)this).Height = num4;
			}
		}
		((Control)base.B()).ResumeLayout(true);
		((Control)this).ResumeLayout(true);
		if (BUK.a() == Ca.ayb)
		{
			((Control)this).Width = 0;
			((Control)this).Height = 0;
			((Control)this).Visible = false;
		}
		else if (!string.IsNullOrEmpty(BUK.c()))
		{
			if (((ArrangedElementCollection)((Control)base.B()).Controls).Count > 1)
			{
				((Control)this).Visible = true;
				C();
			}
			else
			{
				((Control)this).Width = 0;
				((Control)this).Height = 0;
				((Control)this).Visible = false;
			}
		}
		else if (((ArrangedElementCollection)((Control)base.B()).Controls).Count > 0)
		{
			((Control)this).Visible = true;
			C();
		}
		else
		{
			((Control)this).Width = 0;
			((Control)this).Height = 0;
			((Control)this).Visible = false;
		}
	}

	private void A(ref int P_0, ref int P_1)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(BUK.c()))
		{
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeG();
			Label val = null;
			if (((Control)base.B()).Controls.ContainsKey(text))
			{
				Control obj = ((Control)base.B()).Controls[text];
				val = (Label)(object)((obj is Label) ? obj : null);
			}
			else
			{
				val = new Label();
				((Control)val).Name = text;
				((Control)val).Text = BUK.c();
				((Control)val).ForeColor = BM.tf;
				((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8f * BUl, (FontStyle)1);
				((Control)val).BackColor = Color.Transparent;
				((Control)val).AutoSize = true;
				((Control)base.B()).Controls.Add((Control)(object)val);
			}
			((Control)val).Left = P_0;
			((Control)val).Top = P_1;
			P_1 = ((Control)val).Bottom + 2;
		}
	}

	private void a(ref int P_0, ref int P_1)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Beg();
		if (BUK.E().Count == 1)
		{
			Setting setting = BUj.A(BUK.E()[0]);
			if (setting != null)
			{
				string text2 = text + setting.A();
				aJ aJ = null;
				if (((Control)base.B()).Controls.ContainsKey(text2))
				{
					aJ = ((Control)base.B()).Controls[text2] as aJ;
				}
				else
				{
					aJ = new aJ(setting.A(), false, BUj, BUl);
					((Control)aJ).Name = text2;
					((Control)base.B()).Controls.Add((Control)(object)aJ);
				}
				((Control)aJ).Left = 330;
				((Control)aJ).Top = 10;
			}
			return;
		}
		Enumerator<int> enumerator = BUK.E().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current = enumerator.Current;
				Setting setting2 = BUj.A(current);
				if (setting2 != null)
				{
					string text3 = text + setting2.A();
					aJ aJ2 = null;
					if (((Control)base.B()).Controls.ContainsKey(text3))
					{
						aJ2 = ((Control)base.B()).Controls[text3] as aJ;
					}
					else
					{
						aJ2 = new aJ(setting2.A(), true, BUj, BUl);
						((Control)aJ2).Name = text3;
						((Control)base.B()).Controls.Add((Control)(object)aJ2);
					}
					((Control)aJ2).Left = P_0;
					((Control)aJ2).Top = P_1;
					P_1 = ((Control)aJ2).Bottom;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void B(ref int P_0, ref int P_1)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (BUK.e().Count == 0)
		{
			return;
		}
		P_1 += 3;
		Enumerator<int> enumerator = BUK.e().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current = enumerator.Current;
				Setting setting = BUj.A(current);
				if (setting == null || setting.am())
				{
					continue;
				}
				Cn cn = null;
				MenuNode menuNode = MenuNode.A(BUj.awj, setting.C());
				if (menuNode != null)
				{
					MenuNode menuNode2 = menuNode.A(setting);
					if (menuNode2 != null)
					{
						cn = menuNode2.Y().BcF;
					}
				}
				string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeH() + setting.A();
				Control val = null;
				if (((Control)base.B()).Controls.ContainsKey(text))
				{
					val = ((Control)base.B()).Controls[text];
				}
				if (setting.al() || setting.aN())
				{
					if (val != null)
					{
						((Component)val).Dispose();
					}
				}
				else if (setting.U())
				{
					if (val == null)
					{
						ct ct = new ct(setting.C(), BUj, null, cn, false);
						((Control)ct).Name = text;
						((Control)ct).Left = P_0;
						((Control)ct).Top = P_1;
						P_1 = ((Control)ct).Bottom;
						((Control)base.B()).Controls.Add((Control)(object)ct);
					}
					else
					{
						val.Top = P_1;
						P_1 += val.Height;
					}
				}
				else if (setting.L().Count != 0)
				{
					if (val == null)
					{
						cu cu = new cu(setting.C(), BUj, null, cn, false, true, false);
						((Control)cu).Name = text;
						((Control)cu).Left = P_0;
						((Control)cu).Top = P_1 + 2;
						P_1 = ((Control)cu).Bottom + 3;
						((Control)base.B()).Controls.Add((Control)(object)cu);
					}
					else
					{
						val.Top = P_1 + 2;
						P_1 += val.Height + 3;
					}
				}
				else if (val == null)
				{
					DE dE = new DE(setting.C(), BUj, null, cn, false, true, false);
					((Control)dE).Name = text;
					((Control)dE).Left = P_0;
					((Control)dE).Top = P_1 + 2;
					P_1 = ((Control)dE).Bottom + 3;
					((Control)base.B()).Controls.Add((Control)(object)dE);
				}
				else
				{
					val.Top = P_1 + 2;
					P_1 += val.Height + 3;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void b(ref int P_0, ref int P_1)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Beh();
		for (int i = 0; i < BUK.B().Count; i++)
		{
			string text2 = text + i;
			Label val = null;
			if (((Control)base.B()).Controls.ContainsKey(text2))
			{
				Control obj = ((Control)base.B()).Controls[text2];
				val = (Label)(object)((obj is Label) ? obj : null);
			}
			else
			{
				val = new Label();
				((Control)val).Name = text2;
				((Control)val).Font = new Font(((Control)val).Font.FontFamily, 5f * BUl, (FontStyle)1);
				((Control)val).BackColor = Color.Transparent;
				((Control)val).ForeColor = BM.tC;
				((Control)val).AutoSize = true;
				((Control)base.B()).Controls.Add((Control)(object)val);
			}
			((Control)val).Text = BUK.B()[i];
			((Control)val).Left = P_0;
			((Control)val).Top = P_1;
			P_1 = ((Control)val).Bottom + 4;
			((Control)val).BringToFront();
		}
		for (int num = ((ArrangedElementCollection)((Control)base.B()).Controls).Count - 1; num >= 0; num--)
		{
			Control val2 = ((Control)base.B()).Controls[num];
			if (val2.Name.StartsWith(text) && int.Parse(val2.Name.Substring(text.Length)) >= BUK.B().Count)
			{
				((Component)val2).Dispose();
			}
		}
	}

	private void A(bool P_0, ref int P_1, ref int P_2)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		if (P_0)
		{
			BUM = new ThemedButton();
			((Control)BUM).Font = new Font(((Control)BUM).Font.FontFamily, 6f * BUl);
			((Control)BUM).AutoSize = false;
			((Control)BUM).Width = 80;
			((Control)BUM).Height = 33;
			((Control)BUM).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeI();
			((Control)BUM).Click += new EventHandler(C);
			((Control)base.B()).Controls.Add((Control)(object)BUM);
		}
		if (BUM != null)
		{
			((Control)BUM).Left = P_1;
			((Control)BUM).Top = P_2;
			P_2 = ((Control)BUM).Bottom + 10;
		}
	}

	private new void B()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bei();
		PictureBox val = null;
		if (((Control)base.B()).Controls.ContainsKey(text))
		{
			Control obj = ((Control)base.B()).Controls[text];
			val = (PictureBox)(object)((obj is PictureBox) ? obj : null);
		}
		else
		{
			val = new PictureBox();
			((Control)val).Name = text;
			((Control)val).BackColor = Color.Transparent;
			val.SizeMode = (PictureBoxSizeMode)4;
			((Control)val).Width = 32;
			((Control)val).Height = 32;
			((Control)val).Left = 510;
			((Control)val).Top = 10;
			((Control)base.B()).Controls.Add((Control)(object)val);
		}
		switch (BUK.a())
		{
		case Ca.ayc:
			val.Image = (Image)(object)GeneralResources.ChecklistTick;
			break;
		case Ca.ayD:
			val.Image = (Image)(object)GeneralResources.ChecklistCross;
			break;
		case Ca.ayC:
			val.Image = (Image)(object)GeneralResources.ChecklistWaiting;
			break;
		default:
			val.Image = null;
			break;
		}
	}

	private void b(object P_0, EventArgs P_1)
	{
		if (BUk == null || BUM == null)
		{
			return;
		}
		if (((Control)this).InvokeRequired)
		{
			try
			{
				a a = b;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BUk.ax() == 0)
		{
			((Control)BUM).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeI();
		}
		else
		{
			((Control)BUM).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeJ();
		}
	}

	private void C(object P_0, EventArgs P_1)
	{
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Invalid comparison between Unknown and I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Invalid comparison between Unknown and I4
		if (BUk == null)
		{
			return;
		}
		Enumerator<Cb> enumerator;
		if (BUk.ax() == 0)
		{
			if (BUK.F() != null)
			{
				BUK.F().A(false);
			}
			enumerator = BUK.f().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.A(false);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			BUK.A();
			BUk.a(1, true);
			BM.b(BUk.A());
			return;
		}
		BUk.a(0, true);
		BM.b(BUk.A());
		if (BUK.F() != null && !string.IsNullOrEmpty(BUK.F().B()))
		{
			if ((int)bE.A((IWin32Window)(object)BM.QQ, BUK.F().B(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uK(), (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
			{
				BUK.F().a(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bej());
			}
			else
			{
				BUK.F().a(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeK());
			}
			BUK.F().A(true);
			return;
		}
		enumerator = BUK.f().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Cb current = enumerator.Current;
				if (!string.IsNullOrEmpty(current.B()))
				{
					if ((int)bE.A((IWin32Window)(object)BM.QQ, current.B(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uK(), (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
					{
						current.a(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bej());
					}
					else
					{
						current.a(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeK());
					}
					current.A(true);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		try
		{
			BUK.a(new EventHandler(B));
			if (BUk != null)
			{
				BUk.a(new EventHandler(b));
			}
			if (BUM != null)
			{
				((Control)BUM).Click -= new EventHandler(C);
				if (BUk != null && BUk.ax() != 0)
				{
					BUk.a(0, true);
					BM.b(BUk.A());
				}
			}
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
internal class Da : cq
{
	private new class A
	{
		internal byte bAz;

		internal byte baA;
	}

	private new class a
	{
		internal byte[] baa;

		internal byte baB;

		internal byte bab;

		internal bool baC;
	}

	[CompilerGenerated]
	private new static class B
	{
		public static ProgressChangedEventHandler bac;
	}

	private const int BuE = 200;

	private const int Bue = 25;

	private bu BuF;

	private Rectangle Buf;

	private Setting BuG;

	private List<byte> Bug;

	private ContextMenuStrip BuH = new ContextMenuStrip();

	internal Da(bu P_0, Rectangle P_1, bool P_2)
		: base(P_1, P_2, false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		BuF = P_0;
		Buf = P_1;
		if (BM.Qz.awf.ContainsKey((byte)BuF.A()))
		{
			BuG = BM.Qz.awf[(byte)BuF.A()];
			Bug = BuG.V();
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		try
		{
			foreach (Control item in (ArrangedElementCollection)((Control)B()).Controls)
			{
				Control val = item;
				if (val is ThemedButton)
				{
					((Control)(val as ThemedButton)).Click -= new EventHandler(B);
					((Control)(val as ThemedButton)).Click -= new EventHandler(b);
					((Control)(val as ThemedButton)).Click -= new EventHandler(c);
					((Control)(val as ThemedButton)).Click -= new EventHandler(D);
					((Control)(val as ThemedButton)).Click -= new EventHandler(d);
					((Control)(val as ThemedButton)).Click -= new EventHandler(E);
				}
			}
			foreach (ToolStripMenuItem item2 in (ArrangedElementCollection)((ToolStrip)BuH).Items)
			{
				((ToolStripItem)item2).Click -= new EventHandler(C);
			}
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private void B(object P_0, EventArgs P_1)
	{
		if (BuG != null && BM.Qz.C())
		{
			Ck ck = BM.aM();
			ck?.A(BuG.A());
			if (BuG.ax() == 0)
			{
				BuG.a(1, true);
			}
			else
			{
				BuG.a(0, true);
			}
			ck?.B();
			BM.b(BuG.A());
		}
	}

	private void b(object P_0, EventArgs P_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if (!BM.Qz.C())
		{
			return;
		}
		((ToolStrip)BuH).BackColor = BM.tG;
		((ToolStrip)BuH).ForeColor = BM.te;
		((ToolStrip)BuH).Items.Clear();
		Enumerator<byte> enumerator = Bug.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				byte current = enumerator.Current;
				ToolStripMenuItem val = new ToolStripMenuItem();
				((ToolStripItem)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bel() + bu.a((bt)current);
				((ToolStripItem)val).Tag = current;
				((ToolStripItem)val).Click += new EventHandler(C);
				((ToolStrip)BuH).Items.Add((ToolStripItem)(object)val);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		Point val2 = default(Point);
		((Point)(ref val2))._002Ector(0, 0);
		((ToolStripDropDown)BuH).Show((Control)(object)(P_0 as ThemedButton), val2, (ToolStripDropDownDirection)3);
	}

	private void C(object P_0, EventArgs P_1)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		if (BM.Qz.C())
		{
			ToolStripMenuItem val = (ToolStripMenuItem)((P_0 is ToolStripMenuItem) ? P_0 : null);
			A a = new A
			{
				bAz = (byte)BuF.A(),
				baA = (byte)((ToolStripItem)val).Tag
			};
			BackgroundWorker val2 = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			object obj = Da.B.bac;
			if (obj == null)
			{
				ProgressChangedEventHandler val3 = BM.a;
				Da.B.bac = val3;
				obj = (object)val3;
			}
			val2.ProgressChanged += (ProgressChangedEventHandler)obj;
			val2.DoWork += new DoWorkEventHandler(A);
			val2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(A);
			BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeM());
			val2.RunWorkerAsync((object)a);
		}
	}

	private void A(object P_0, DoWorkEventArgs P_1)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
		val.ReportProgress(0);
		A a = P_1.Argument as A;
		byte bAz = a.bAz;
		byte baA = a.baA;
		bool flag = false;
		byte[] array = null;
		bool baC = false;
		if (global::A.A.A(BM.Qz.aXc, bAz, baA, out flag))
		{
			Stopwatch val2 = new Stopwatch();
			val2.Restart();
			BM.QQ.rL.HK = (bt)baA;
			while (true)
			{
				if (val2.ElapsedMilliseconds >= 3000)
				{
					array = null;
					break;
				}
				if (!global::A.A.A(BM.Qz.aXc, bAz, out array, out flag) || array.Length == 0)
				{
					break;
				}
				if (array[0] != 2)
				{
					if (array[0] != 0)
					{
						break;
					}
					if (BM.Qz.awf.ContainsKey(baA))
					{
						Setting setting = BM.Qz.awf[baA];
						if (setting.ax() == 0)
						{
							setting.a(1, true);
							baC = true;
						}
					}
					val.ReportProgress(90);
					Thread.Sleep(500);
					val.ReportProgress(100);
					Thread.Sleep(500);
					break;
				}
				val.ReportProgress(Math.Min(100, (int)(val2.ElapsedMilliseconds * 80 / 1000)));
				Thread.Sleep(10);
			}
		}
		a result = new a
		{
			baa = array,
			baB = a.bAz,
			bab = a.baA,
			baC = baC
		};
		P_1.Result = result;
	}

	private void A(object P_0, RunWorkerCompletedEventArgs P_1)
	{
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		BM.P();
		a a = P_1.Result as a;
		byte[] baa = a.baa;
		byte baB = a.baB;
		byte bab = a.bab;
		string text = bu.a((bt)baB);
		string text2 = bu.a((bt)bab);
		F f = global::A.A.e(BM.Qz.aXc);
		string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSF();
		if (f != null && f.aH == 21)
		{
			text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHl();
		}
		if (baa != null && baa.Length != 0)
		{
			string empty = string.Empty;
			byte b = baa[0];
			switch (b)
			{
			case 1:
				if (b != 1)
				{
					goto default;
				}
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ben() + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeO();
				break;
			case 0:
				empty = string.Concat(new string[5]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bem(),
					text,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeN(),
					text2,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq()
				});
				break;
			case 129:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Beo();
				break;
			case 130:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeP() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bep();
				break;
			case 131:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeQ();
				break;
			case 132:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ben() + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeO();
				break;
			case 144:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Beq();
				break;
			case 145:
				empty = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeR();
				break;
			case 146:
				empty = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ber();
				break;
			default:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeS();
				break;
			}
			if (baa[0] == 0)
			{
				A(empty, baB, bab, a.baC);
				return;
			}
			BM.QQ.rL.HK = bt.avK;
			bE.A((IWin32Window)(object)BM.QQ, empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		else
		{
			BM.QQ.rL.HK = bt.avK;
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bes(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void A(string P_0, byte P_1, byte P_2, bool P_3)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Invalid comparison between Unknown and I4
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		bool flag = false;
		if (P_3 && BM.Qz.awf.ContainsKey(P_2))
		{
			BM.b(BM.Qz.awf[P_2].A());
			flag = true;
		}
		bool flag2 = false;
		Enumerator<SettingOrSpecialObject> enumerator = BM.Qz.awD.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				PortFunction.B b = enumerator.Current.F().E();
				if (b.BSQ == bu.A((bt)P_1))
				{
					List<Dn> val = PortFunction.A(BM.Qz, b.BSQ, b.BSq, b.BSR, b.BSr, false);
					if (val != null && val.Count != 0)
					{
						flag2 = true;
						break;
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (flag2)
		{
			string text = bu.a((bt)P_1);
			string text2 = bu.a((bt)P_2);
			DialogResult val2 = ((!flag) ? bE.A((IWin32Window)(object)BM.QQ, string.Concat(new string[6]
			{
				P_0,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeU(),
				text,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bet(),
				text2,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Beu()
			}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.g(), (MessageBoxButtons)4, (MessageBoxIcon)64, (MessageBoxDefaultButton)256) : bE.A((IWin32Window)(object)BM.QQ, string.Concat(new string[6]
			{
				P_0,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeT(),
				text,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bet(),
				text2,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bL()
			}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.g(), (MessageBoxButtons)4, (MessageBoxIcon)64, (MessageBoxDefaultButton)256));
			if ((int)val2 == 6)
			{
				Cg cg = bu.A((bt)P_1);
				Cg cg2 = bu.A((bt)P_2);
				PortFunction.A(BM.Qz, cg, cg2);
				BackgroundWorker val3 = new BackgroundWorker();
				val3.DoWork += new DoWorkEventHandler(a);
				val3.RunWorkerCompleted += new RunWorkerCompletedEventHandler(a);
				val3.RunWorkerAsync();
			}
			else
			{
				BM.QQ.t(null, null);
			}
		}
		else if (flag)
		{
			bE.A((IWin32Window)(object)BM.QQ, P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeV(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.g(), (MessageBoxButtons)0, (MessageBoxIcon)64);
			BM.QQ.t(null, null);
		}
		else
		{
			bE.A((IWin32Window)(object)BM.QQ, P_0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.g(), (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		BM.QQ.rL.HK = (bt)P_2;
		BM.QQ.rL.A(false, true, false, false);
	}

	private void a(object P_0, DoWorkEventArgs P_1)
	{
		while (BM.Qz.q())
		{
			Thread.Sleep(100);
		}
	}

	private void a(object P_0, RunWorkerCompletedEventArgs P_1)
	{
		BM.QQ.t(null, null);
	}

	private void c(object P_0, EventArgs P_1)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		if (BM.SI.Count != 1)
		{
			return;
		}
		F bpS = BM.SI[0].BpS;
		if ((BuF.A() == bt.avU || BuF.A() == bt.avu || BuF.A() == bt.avV || BuF.A() == bt.avv) && BuF.a() < CZ.A(BuF.E()))
		{
			string text = ((bpS.aH == 21) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHl() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSF());
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bev() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeW(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bew(), (MessageBoxButtons)0);
			return;
		}
		if (CZ.A(bpS, true))
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeX(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bex(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		if (BM.Qz.o())
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kp(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kQ(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		BackgroundWorker val = new BackgroundWorker
		{
			WorkerReportsProgress = true
		};
		val.DoWork += new DoWorkEventHandler(B);
		object obj = Da.B.bac;
		if (obj == null)
		{
			ProgressChangedEventHandler val2 = BM.a;
			Da.B.bac = val2;
			obj = (object)val2;
		}
		val.ProgressChanged += (ProgressChangedEventHandler)obj;
		val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(B);
		BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.re());
		val.RunWorkerAsync();
	}

	private void B(object P_0, DoWorkEventArgs P_1)
	{
		if (BM.SI.Count == 1)
		{
			F bpS = BM.SI[0].BpS;
			k k = null;
			if (bpS.aK != 255 || bpS.ak != 255 || bpS.aL != 255 || bpS.al != 255)
			{
				k = new k(bpS.aK, bpS.ak, bpS.aL, bpS.al, 0);
			}
			k k2 = new k(bpS.ae, bpS.aF, bpS.af, bpS.aG, 0);
			bool flag = !bg.a();
			List<CY> result = CZ.A((BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null), bpS.aH, bpS.ah, k2, bpS.aJ, bpS.ao, k, flag, BuF.A(), BuF.a(), BuF.E());
			P_1.Result = result;
		}
		else
		{
			P_1.Result = null;
		}
	}

	private void B(object P_0, RunWorkerCompletedEventArgs P_1)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		BM.P();
		if (P_1.Result != null && BM.SI.Count == 1)
		{
			List<CY> obj = (List<CY>)P_1.Result;
			F bpS = BM.SI[0].BpS;
			BI bI = new BI(obj, bpS, BuF.A(), BuF.a(), BuF.E());
			((Form)bI).ShowDialog((IWin32Window)(object)this);
			((Component)bI).Dispose();
		}
	}

	private void D(object P_0, EventArgs P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		BackgroundWorker val = new BackgroundWorker
		{
			WorkerReportsProgress = true
		};
		object obj = Da.B.bac;
		if (obj == null)
		{
			ProgressChangedEventHandler val2 = BM.a;
			Da.B.bac = val2;
			obj = (object)val2;
		}
		val.ProgressChanged += (ProgressChangedEventHandler)obj;
		val.DoWork += new DoWorkEventHandler(b);
		val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(b);
		BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeY());
		val.RunWorkerAsync();
	}

	private void b(object P_0, DoWorkEventArgs P_1)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
		val.ReportProgress(0);
		MemoryStream val2 = new MemoryStream();
		byte[] array = new byte[2] { 0, 26 };
		uint num = 256u;
		global::A.A.a(BM.Qz.aXc, 30000u);
		if (global::A.A.A(BM.Qz.aXc, (byte)BuF.A(), f.au, 0u, array, num, out var array2, out var flag))
		{
			try
			{
				val.ReportProgress(5);
				string text = string.Empty;
				MemoryStream val3 = new MemoryStream();
				try
				{
					uint num2 = global::A.A.A(BM.Qz.aXc, f.Bd);
					uint num3 = 0u;
					while (true)
					{
						if (global::A.A.A(BM.Qz.aXc, (byte)BuF.A(), f.Bd, num3, num2, out var array3, out flag))
						{
							if (array3.Length != 0)
							{
								((Stream)val3).Write(array3, 0, array3.Length);
							}
							if (array3.Length < num2)
							{
								break;
							}
							num3 += num2;
							val.ReportProgress(Math.Min(100, 5 + (int)(num3 * 95) / 1000000));
							continue;
						}
						text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bey();
						break;
					}
					if (text == string.Empty)
					{
						Version version = Assembly.GetEntryAssembly().GetName().Version;
						array2[104] = (byte)version.Major;
						array2[105] = (byte)version.Minor;
						array2[106] = (byte)version.Build;
						array2[107] = (byte)version.Revision;
						array2[108] = 0;
						array2[109] = 0;
						array2[110] = 0;
						array2[111] = 0;
						System.DateTime now = System.DateTime.Now;
						array2[112] = A((byte)(now.Year / 100));
						array2[113] = A((byte)(now.Year % 100));
						array2[114] = A((byte)now.Month);
						array2[115] = A((byte)now.Day);
						array2[116] = A((byte)now.Hour);
						array2[117] = A((byte)now.Minute);
						array2[118] = A((byte)now.Second);
						array2[119] = 0;
						byte[] array4 = val3.ToArray();
						MD5 val4 = MD5.Create();
						try
						{
							byte[] array5 = ((HashAlgorithm)val4).ComputeHash(array4);
							for (int i = 0; i < 16; i++)
							{
								array2[120 + i] = array5[i];
							}
						}
						finally
						{
							((System.IDisposable)val4)?.Dispose();
						}
						((Stream)val2).Write(array2, 0, array2.Length);
						((Stream)val2).Write(array4, 0, array4.Length);
					}
				}
				finally
				{
					((System.IDisposable)val3)?.Dispose();
				}
				val.ReportProgress(100);
				Thread.Sleep(500);
				P_1.Result = new ValueTuple<string, MemoryStream>(text, val2);
			}
			catch (System.Exception ex)
			{
				string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeZ() + ex.Message;
				P_1.Result = new ValueTuple<string, MemoryStream>(text2, val2);
			}
		}
		else
		{
			string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bez();
			P_1.Result = new ValueTuple<string, MemoryStream>(text3, val2);
		}
		global::A.A.I(BM.Qz.aXc);
	}

	private void b(object P_0, RunWorkerCompletedEventArgs P_1)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		BM.P();
		ValueTuple<string, MemoryStream> val = (ValueTuple<string, MemoryStream>)P_1.Result;
		if (string.IsNullOrEmpty(val.Item1))
		{
			SaveFileDialog val2 = new SaveFileDialog();
			((FileDialog)val2).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wp();
			((FileDialog)val2).FileName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFA() + N.A(false);
			if ((int)((CommonDialog)val2).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				try
				{
					File.WriteAllBytes(((FileDialog)val2).FileName, val.Item2.ToArray());
				}
				catch (System.Exception ex)
				{
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFa() + ex.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			((Component)val2).Dispose();
		}
		else
		{
			bE.A((IWin32Window)(object)BM.QQ, val.Item1, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		((Stream)val.Item2).Dispose();
	}

	private void d(object P_0, EventArgs P_1)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		if (BM.SI.Count != 1 || (int)bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFB(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFb(), (MessageBoxButtons)4, (MessageBoxIcon)48) != 6)
		{
			return;
		}
		F bpS = BM.SI[0].BpS;
		if (CZ.A(bpS, true))
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bex(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		if (BM.Qz.o())
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFc(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kQ(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		BackgroundWorker val = new BackgroundWorker
		{
			WorkerReportsProgress = true
		};
		val.DoWork += new DoWorkEventHandler(C);
		object obj = Da.B.bac;
		if (obj == null)
		{
			ProgressChangedEventHandler val2 = BM.a;
			Da.B.bac = val2;
			obj = (object)val2;
		}
		val.ProgressChanged += (ProgressChangedEventHandler)obj;
		val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(C);
		BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFD());
		val.RunWorkerAsync((object)bpS);
	}

	private void C(object P_0, DoWorkEventArgs P_1)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		int num = BM.Qz.A(19236).ax();
		ValueTuple<string, string> val = CZ.A((BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null), BuF.A(), num);
		string item = val.Item1;
		string item2 = val.Item2;
		F f = P_1.Argument as F;
		P_1.Result = new ValueTuple<string, string, F>(item2, item, f);
	}

	private void C(object P_0, RunWorkerCompletedEventArgs P_1)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		BM.P();
		ValueTuple<string, string, F> val = (ValueTuple<string, string, F>)P_1.Result;
		if (val.Item2 == null)
		{
			bE.A((IWin32Window)(object)BM.QQ, string.IsNullOrEmpty(val.Item1) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFd() : val.Item1, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		else
		{
			CZ.A(val.Item3, val.Item2, BuF.A());
		}
	}

	private void E(object P_0, EventArgs P_1)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		if ((int)bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFE(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
		{
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			object obj = Da.B.bac;
			if (obj == null)
			{
				ProgressChangedEventHandler val2 = BM.a;
				Da.B.bac = val2;
				obj = (object)val2;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj;
			val.DoWork += new DoWorkEventHandler(c);
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(c);
			BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFe());
			val.RunWorkerAsync();
		}
	}

	private void c(object P_0, DoWorkEventArgs P_1)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
		val.ReportProgress(0);
		bool flag = false;
		byte[] array = null;
		byte[] array2 = new byte[2] { 0, 25 };
		if (global::A.A.A(BM.Qz.aXc, (byte)BuF.A(), f.au, 0u, array2, out flag))
		{
			Stopwatch val2 = new Stopwatch();
			val2.Restart();
			while (true)
			{
				if (val2.ElapsedMilliseconds >= 2000)
				{
					array = null;
					break;
				}
				if (!global::A.A.A(BM.Qz.aXc, (byte)BuF.A(), out array, out flag) || array.Length == 0)
				{
					break;
				}
				if (array[0] != 2)
				{
					val.ReportProgress(100);
					Thread.Sleep(600);
					break;
				}
				val.ReportProgress(Math.Min(100, (int)val2.ElapsedMilliseconds));
				Thread.Sleep(10);
			}
		}
		P_1.Result = array;
	}

	private void c(object P_0, RunWorkerCompletedEventArgs P_1)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		BM.P();
		if (P_1.Result is byte[] array && array.Length != 0)
		{
			if (array[0] == 0)
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFF(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.g(), (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			else
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFf(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}
		else
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bes(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	internal new void A(bool P_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected O, but got Unknown
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected O, but got Unknown
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected O, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b54: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((Control)B()).SuspendLayout();
		int left = 5;
		int top = 5;
		Label val = new Label();
		((Control)val).ForeColor = BM.tf;
		((Control)val).Font = new Font(((Control)val).Font.FontFamily, 10f, (FontStyle)1);
		((Control)val).AutoSize = true;
		((Control)val).Text = BuF.G();
		((Control)val).Left = left;
		((Control)val).Top = top;
		top = ((Control)val).Bottom + 10;
		if (P_0)
		{
			((Control)B()).Controls.Add((Control)(object)val);
		}
		else
		{
			((Component)val).Dispose();
		}
		ThemedButton themedButton = null;
		if (BuG != null && !BuG.am() && (!BM.Qz.B() || !BM.Qz.b() || !BuG.J()))
		{
			if (!P_0)
			{
				if (((Control)B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFG()))
				{
					themedButton = ((Control)B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFG()] as ThemedButton;
				}
			}
			else
			{
				themedButton = new ThemedButton();
				((Control)themedButton).Enabled = BM.Qz.C();
				((Control)themedButton).Click += new EventHandler(B);
				((Control)themedButton).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFG();
				((Control)themedButton).Width = 200;
				((Control)themedButton).Height = 25;
				((Control)themedButton).Left = left;
				((Control)themedButton).Top = top;
				top = ((Control)themedButton).Bottom + 10;
				((Control)B()).Controls.Add((Control)(object)themedButton);
			}
		}
		Label val2 = null;
		if (!P_0)
		{
			if (((Control)B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFg()))
			{
				Control obj = ((Control)B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFg()];
				val2 = (Label)(object)((obj is Label) ? obj : null);
			}
		}
		else
		{
			val2 = new Label();
			((Control)val2).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFg();
			((Control)val2).ForeColor = BM.te;
			((Control)val2).Font = new Font(((Control)val2).Font.FontFamily, 8f, (FontStyle)1);
			((Control)val2).AutoSize = true;
			((Control)val2).Left = left;
			((Control)val2).Top = top;
			top = ((Control)val2).Bottom + 10;
			((Control)B()).Controls.Add((Control)(object)val2);
		}
		Label val3 = null;
		if (!P_0)
		{
			if (((Control)B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFH()))
			{
				Control obj2 = ((Control)B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFH()];
				val3 = (Label)(object)((obj2 is Label) ? obj2 : null);
			}
		}
		else
		{
			val3 = new Label();
			((Control)val3).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFH();
			((Control)val3).ForeColor = BM.te;
			((Control)val3).Font = new Font(((Control)val3).Font.FontFamily, 8f, (FontStyle)1);
			((Control)val3).AutoSize = true;
			((Control)val3).Left = left;
			((Control)val3).Top = top;
			top = ((Control)val3).Bottom + 10;
			((Control)B()).Controls.Add((Control)(object)val3);
		}
		Label val4 = null;
		if (!P_0)
		{
			if (((Control)B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFh()))
			{
				Control obj3 = ((Control)B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFh()];
				val4 = (Label)(object)((obj3 is Label) ? obj3 : null);
			}
		}
		else
		{
			val4 = new Label();
			((Control)val4).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFh();
			((Control)val4).ForeColor = BM.te;
			((Control)val4).Font = new Font(((Control)val4).Font.FontFamily, 8f, (FontStyle)1);
			((Control)val4).AutoSize = true;
			((Control)val4).Left = left;
			((Control)val4).Top = top;
			top = ((Control)val4).Bottom + 10;
			((Control)B()).Controls.Add((Control)(object)val4);
		}
		ThemedButton themedButton2 = null;
		if (BM.SI.Count == 1)
		{
			F bpS = BM.SI[0].BpS;
			if ((CZ.A(bpS.aH, bpS.ah, new k(bpS.ae, bpS.aF, bpS.af, bpS.aG, bpS.ag)) && CZ.A(BuF.A())) || BuF.A() == bt.avU || BuF.A() == bt.avu || BuF.A() == bt.avV || BuF.A() == bt.avv)
			{
				if (!P_0)
				{
					foreach (Control item in (ArrangedElementCollection)((Control)B()).Controls)
					{
						Control val5 = item;
						if ((string)val5.Tag == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFI())
						{
							themedButton2 = val5 as ThemedButton;
							break;
						}
					}
				}
				else
				{
					themedButton2 = new ThemedButton();
					((Control)themedButton2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFi();
					((Control)themedButton2).Click += new EventHandler(c);
					((Control)themedButton2).Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFI();
					((Control)themedButton2).Width = 200;
					((Control)themedButton2).Height = 25;
					((Control)themedButton2).Left = left;
					((Control)themedButton2).Top = top;
					top = ((Control)themedButton2).Bottom + 10;
					((Control)B()).Controls.Add((Control)(object)themedButton2);
				}
			}
		}
		ThemedButton themedButton3 = null;
		if (BuG != null && Bug != null && Bug.Count != 0)
		{
			if (!P_0)
			{
				if (((Control)B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFJ()))
				{
					themedButton3 = ((Control)B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFJ()] as ThemedButton;
				}
			}
			else
			{
				themedButton3 = new ThemedButton();
				((Control)themedButton3).Enabled = BM.Qz.C();
				((Control)themedButton3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFj();
				((Control)themedButton3).Click += new EventHandler(b);
				((Control)themedButton3).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFJ();
				((Control)themedButton3).Width = 200;
				((Control)themedButton3).Height = 25;
				((Control)themedButton3).Left = left;
				((Control)themedButton3).Top = top;
				top = ((Control)themedButton3).Bottom + 10;
				((Control)B()).Controls.Add((Control)(object)themedButton3);
			}
		}
		ThemedButton themedButton4 = null;
		ThemedButton themedButton5 = null;
		ThemedButton themedButton6 = null;
		if (BuF.A() == bt.avx && BM.Qz.A(19236) != null && !BuF.e())
		{
			if (!P_0)
			{
				if (((Control)B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFK()))
				{
					themedButton4 = ((Control)B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFK()] as ThemedButton;
				}
				if (((Control)B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFk()))
				{
					themedButton5 = ((Control)B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFk()] as ThemedButton;
				}
				if (((Control)B()).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFL()))
				{
					themedButton6 = ((Control)B()).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFL()] as ThemedButton;
				}
			}
			else
			{
				themedButton4 = new ThemedButton();
				((Control)themedButton4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFl();
				((Control)themedButton4).Click += new EventHandler(D);
				((Control)themedButton4).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFK();
				((Control)themedButton4).Width = 200;
				((Control)themedButton4).Height = 25;
				((Control)themedButton4).Left = left;
				((Control)themedButton4).Top = top;
				top = ((Control)themedButton4).Bottom + 10;
				((Control)B()).Controls.Add((Control)(object)themedButton4);
				themedButton5 = new ThemedButton();
				((Control)themedButton5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFM();
				((Control)themedButton5).Click += new EventHandler(d);
				((Control)themedButton5).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFk();
				((Control)themedButton5).Width = 200;
				((Control)themedButton5).Height = 25;
				((Control)themedButton5).Left = left;
				((Control)themedButton5).Top = top;
				top = ((Control)themedButton5).Bottom + 10;
				((Control)B()).Controls.Add((Control)(object)themedButton5);
				themedButton6 = new ThemedButton();
				((Control)themedButton6).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFm();
				((Control)themedButton6).Click += new EventHandler(E);
				((Control)themedButton6).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFL();
				((Control)themedButton6).Width = 200;
				((Control)themedButton6).Height = 25;
				((Control)themedButton6).Left = left;
				((Control)themedButton6).Top = top;
				top = ((Control)themedButton6).Bottom + 10;
				((Control)B()).Controls.Add((Control)(object)themedButton6);
			}
		}
		bool flag = false;
		bool flag2 = false;
		if (BM.A(BM.Qz.aXc, true))
		{
			((Control)val2).Visible = true;
			if (BuF.C() || !BuF.c())
			{
				((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFN();
				if (themedButton != null)
				{
					((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFn();
				}
			}
			else
			{
				if (BuF.D())
				{
					if (BuF.F())
					{
						((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFO();
					}
					else if (BuF.e())
					{
						((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFo();
					}
					else if (BuF.d())
					{
						((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFP();
					}
					else if (BuF.E())
					{
						((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFp();
					}
					else
					{
						flag2 = true;
						((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFQ();
					}
					flag = true;
					((Control)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFq() + ((object)BuF.a()).ToString();
					((Control)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEX() + BuF.B();
				}
				else
				{
					((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFR();
				}
				if (themedButton != null)
				{
					if (BuG.ax() == 0)
					{
						((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFn();
					}
					else
					{
						((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFr();
					}
				}
			}
		}
		else
		{
			((Control)val2).Visible = false;
			if (themedButton != null)
			{
				if (BuG.ax() == 0)
				{
					((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFn();
				}
				else
				{
					((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFr();
				}
			}
		}
		if (val3 != null)
		{
			((Control)val3).Visible = flag && BuF.a() != new k(0, 0, 0, 0, 0);
		}
		if (val4 != null)
		{
			((Control)val4).Visible = flag && BuF.B() != string.Empty && BuF.B() != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aD();
		}
		if (themedButton2 != null)
		{
			((Control)themedButton2).Visible = flag || BuF.A() == bt.avU || BuF.A() == bt.avu || BuF.A() == bt.avV || BuF.A() == bt.avv;
		}
		bool visible = flag && flag2;
		if (themedButton3 != null)
		{
			((Control)themedButton3).Visible = visible;
		}
		if (themedButton4 != null)
		{
			((Control)themedButton4).Visible = visible;
		}
		if (themedButton5 != null)
		{
			((Control)themedButton5).Visible = visible;
		}
		if (themedButton6 != null)
		{
			((Control)themedButton6).Visible = visible;
		}
		if (Buf != Rectangle.Empty)
		{
			((Control)this).Width = ((Rectangle)(ref Buf)).Width;
			((Control)this).Height = ((Rectangle)(ref Buf)).Height;
			((Control)this).Left = ((Rectangle)(ref Buf)).Left;
			((Control)this).Top = ((Rectangle)(ref Buf)).Top;
		}
		else
		{
			int num = 0;
			int num2 = 0;
			foreach (Control item2 in (ArrangedElementCollection)((Control)B()).Controls)
			{
				Control val6 = item2;
				num = Math.Max(num, val6.Right + 10);
				num2 = Math.Max(num2, val6.Bottom + 10);
			}
			((Control)this).Width = num;
			((Control)this).Height = num2;
		}
		((Control)B()).ResumeLayout(true);
		((Control)this).ResumeLayout(true);
	}

	[CompilerGenerated]
	internal static byte A(byte P_0)
	{
		return (byte)((P_0 / 10 << 4) | (P_0 % 10));
	}
}
