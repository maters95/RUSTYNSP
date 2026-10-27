using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
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

internal class DE : cv
{
	private new delegate void A(object P_0, EventArgs P_1);

	private new delegate void a(object P_0, EventArgs P_1);

	private new delegate void B(object P_0, EventArgs P_1);

	internal const int BWy = 100;

	internal const int BWZ = 160;

	internal const int BWz = 220;

	internal const int BwA = 320;

	internal const int Bwa = 60;

	internal const int BwB = 100;

	internal const int Bwb = 180;

	internal const int BwC = 300;

	internal const int Bwc = 200;

	internal const int BwD = 120;

	internal const int Bwd = 120;

	private Setting BwE;

	private Setting Bwe;

	private Setting BwF;

	private Setting Bwf;

	private bool BwG;

	private Label Bwg = new Label();

	private Label BwH = new Label();

	private ThemedButton Bwh;

	private bool BwI;

	private bool Bwi;

	private Timer BwJ = new Timer();

	private bool Bwj;

	private bool BwK;

	private bool Bwk;

	private bool BwL;

	private bool Bwl;

	private bool BwM;

	[SpecialName]
	internal new int b()
	{
		return ((Control)Bwg).Width;
	}

	internal DE(DataIdAndAttrId P_0, Framework P_1, Framework P_2, Cn P_3, bool P_4, bool P_5, bool P_6)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		A(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
		BwJ.Interval = 400;
		BwJ.Tick += new EventHandler(D);
	}

	private void A(DataIdAndAttrId P_0, Framework P_1, Framework P_2, Cn P_3, bool P_4, bool P_5, bool P_6)
	{
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected O, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected O, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected O, but got Unknown
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected O, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected O, but got Unknown
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected O, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected O, but got Unknown
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_096a: Expected O, but got Unknown
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected O, but got Unknown
		A(P_1, P_2);
		A(P_0);
		if (ic.j() != 0)
		{
			BwE = iB.A(ic.j());
			BwF = iB.A(BwE.ax());
		}
		if (ib != null && iD != null && iD.j() != 0)
		{
			Bwe = ib.A(iD.j());
			Bwf = ib.A(Bwe.ax());
		}
		BNQ = P_3;
		if (BNQ != null)
		{
			BNq = P_4;
			Bwi = P_5;
			int[] array = BNQ.a(ic);
			if (array != null && array.Length == 1)
			{
				BNR = array[0];
			}
			else
			{
				BNQ = null;
			}
		}
		C();
		bool flag = c();
		if (((Control)BNP).ContextMenuStrip == null)
		{
			((Control)BNP).ContextMenuStrip = a();
		}
		List<Control> val = new List<Control>();
		BM.QQ.B(new EventHandler(C));
		BwG = ic.c() != 0;
		BNp = false;
		((Control)Bwg).Font = new Font(((Control)Bwg).Font.FontFamily, 8.25f, ((Control)Bwg).Font.Style);
		((Control)BwH).Font = new Font(((Control)BwH).Font.FontFamily, 8.25f, ((Control)BwH).Font.Style);
		((Control)BNP).Font = new Font(((Control)BNP).Font.FontFamily, 8.25f, ((Control)BNP).Font.Style);
		((Control)this).SuspendLayout();
		bool flag2 = BM.QO == BM.b.BpF && (iF || @if) && ib != null;
		if (flag2)
		{
			((Control)Bwg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bci() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
		}
		else if (flag)
		{
			((Control)Bwg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO();
		}
		else if (BNQ != null && ic.e() && Bwi && !string.IsNullOrEmpty(ic.F()))
		{
			((Control)Bwg).Text = ic.F();
		}
		else
		{
			((Control)Bwg).Text = ((SettingOrSpecialObject)ic).A(false);
		}
		BwI = P_6;
		((Control)BNP).Width = c();
		((Control)Bwg).Left = 0;
		((Control)Bwg).Top = 3;
		if (BwI)
		{
			((Control)Bwg).AutoSize = true;
			((Control)Bwg).MinimumSize = new Size(60, 0);
			((Control)Bwg).MaximumSize = new Size(0, 0);
			((Control)BNP).Left = 0;
			((Control)BNP).Top = ((Control)Bwg).Top + 14;
		}
		else
		{
			((Control)Bwg).Height = 16;
			((Control)Bwg).Width = C();
			((Control)BNP).Left = ((Control)Bwg).Right + 10;
			((Control)BNP).Top = 0;
		}
		val.Add((Control)(object)Bwg);
		if (!((Control)this).Controls.Contains((Control)(object)Bwg))
		{
			((Control)this).Controls.Add((Control)(object)Bwg);
		}
		if (BwG && ic.av()[2] > 32)
		{
			((Control)BNP).MinimumSize = new Size(300, 200);
			((Control)BNP).MaximumSize = ((Control)BNP).MinimumSize;
			((TextBoxBase)BNP).Multiline = true;
		}
		if (!flag && !flag2)
		{
			((Control)BNP).Tag = ic.af().BYl;
			((Control)BNP).GotFocus += new EventHandler(b);
			((Control)BNP).KeyDown += new KeyEventHandler(A);
			((Control)BNP).KeyPress += new KeyPressEventHandler(A);
			((Control)BNP).Leave += new EventHandler(d);
			ic.A(new EventHandler(E));
			((SettingOrSpecialObject)ic).A(new EventHandler(c));
			val.Add((Control)(object)BNP);
			if (!((Control)this).Controls.Contains((Control)(object)BNP))
			{
				((Control)this).Controls.Add((Control)(object)BNP);
			}
			if (BwE != null)
			{
				BwE.A(new EventHandler(e));
				((SettingOrSpecialObject)BwE).A(new EventHandler(c));
			}
			((Control)this).MouseEnter += new EventHandler(((aj)this).A);
			((Control)Bwg).MouseEnter += new EventHandler(((aj)this).A);
			((Control)BNP).MouseEnter += new EventHandler(((aj)this).A);
			((Control)BwH).MouseEnter += new EventHandler(((aj)this).A);
			((Control)iG).MouseEnter += new EventHandler(((aj)this).A);
			((Control)BNP).MouseLeave += new EventHandler(((aj)this).a);
			((Control)this).MouseLeave += new EventHandler(((aj)this).a);
		}
		((Control)this).AutoSize = false;
		bool flag3 = ib != null && (iF || @if);
		if (flag3)
		{
			if (BwI)
			{
				Size val2 = TextRenderer.MeasureText(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO(), ((Control)Bwg).Font);
				((Control)this).Width = ((Size)(ref val2)).Width;
			}
			else
			{
				((Control)this).Width = C() + 10 + c() + 10 + 120;
			}
		}
		if (BwI)
		{
			if (flag3)
			{
				((Control)this).Height = 17 + ((Control)BNP).Height;
			}
			else
			{
				((Control)this).Width = ((Control)Bwg).Width;
				((Control)this).Height = ((Control)BNP).Bottom;
			}
		}
		else if (flag3)
		{
			((Control)this).Height = ((Control)BNP).Height;
		}
		else
		{
			((Control)this).Width = ((Control)BNP).Right;
			((Control)this).Height = ((Control)BNP).Height;
		}
		if (!flag && !flag2)
		{
			if (!BwG)
			{
				if (BwI)
				{
					((Control)BwH).Left = ((Control)BNP).Right + 5;
					((Control)BwH).Top = ((Control)BNP).Top + 3;
					((Control)BwH).Height = 16;
					((Control)BwH).Width = 55;
					val.Add((Control)(object)BwH);
					if (!((Control)this).Controls.Contains((Control)(object)BwH))
					{
						((Control)this).Controls.Add((Control)(object)BwH);
					}
				}
				else
				{
					((Control)BwH).Left = ((Control)BNP).Right + 10;
					((Control)BwH).Top = 3;
					((Control)BwH).Height = 16;
					((Control)BwH).Width = 120;
					val.Add((Control)(object)BwH);
					if (!((Control)this).Controls.Contains((Control)(object)BwH))
					{
						((Control)this).Controls.Add((Control)(object)BwH);
					}
					if (!flag3)
					{
						((Control)this).Width = ((Control)BwH).Right;
					}
				}
				if (ic.af().BYl != 0)
				{
					if (Bwh == null)
					{
						Bwh = new ThemedButton();
						((Control)Bwh).Click += new EventHandler(F);
					}
					((Control)Bwh).Text = ic.af().BYM;
					((Control)Bwh).Left = ((Control)BwH).Right + 5;
					((Control)Bwh).Top = 0;
					((Control)Bwh).Height = ((Control)BNP).Height;
					((Control)Bwh).Width = 120;
					val.Add((Control)(object)Bwh);
					if (!((Control)this).Controls.Contains((Control)(object)Bwh))
					{
						((Control)this).Controls.Add((Control)(object)Bwh);
					}
					if (!flag3)
					{
						((Control)this).Width = ((Control)Bwh).Right;
					}
				}
			}
			((Control)iG).Tag = ic;
			((Control)iG).Width = 18;
			((Control)iG).Height = 18;
			((Control)iG).Left = ((Control)this).Width;
			((Control)iG).Top = 1;
			iG.SizeMode = (PictureBoxSizeMode)1;
			((Control)iG).Click += new EventHandler(B);
			val.Add((Control)(object)iG);
			if (!((Control)this).Controls.Contains((Control)(object)iG))
			{
				((Control)this).Controls.Add((Control)(object)iG);
			}
			if (!flag3)
			{
				((Control)this).Width = Math.Max(((Control)iG).Right, ((Control)BwH).Right);
			}
			((Control)iG).Visible = false;
		}
		for (int num = ((ArrangedElementCollection)((Control)this).Controls).Count - 1; num >= 0; num--)
		{
			if (!val.Contains(((Control)this).Controls[num]))
			{
				((Control)this).Controls.RemoveAt(num);
			}
		}
		D();
		E();
		((Control)this).ResumeLayout(true);
	}

	private new int C()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(((Control)Bwg).Text))
		{
			return 2;
		}
		Size val = TextRenderer.MeasureText(((Control)Bwg).Text, ((Control)Bwg).Font);
		int width = ((Size)(ref val)).Width;
		if (width < 100)
		{
			return 100;
		}
		if (width < 160)
		{
			return 160;
		}
		if (width < 220)
		{
			return 220;
		}
		if (width < 320)
		{
			return 320;
		}
		return width;
	}

	private new int c()
	{
		if (BwG)
		{
			if (ic.av()[2] <= 32)
			{
				return 180;
			}
			return 300;
		}
		if (BwI)
		{
			return 60;
		}
		bool flag = false;
		int num = 0;
		int num2 = 0;
		if (BwF != null)
		{
			num = BwF.aR();
			num2 = BwF.ar();
			if (num != 0 || num2 != 0)
			{
				int num3 = BwF.aS();
				string text = bS.a(num, num3, -1);
				string text2 = bS.a(num2, num3, -1);
				flag = text.Length * 6 <= 53 && text2.Length * 6 <= 53;
			}
		}
		else
		{
			if (BNQ != null && ic.e() && Bwi)
			{
				num = ic.aO();
				num2 = ic.ao();
			}
			if (num == 0 && num2 == 0)
			{
				num = ic.aR();
				num2 = ic.ar();
			}
			if (num != 0 || num2 != 0)
			{
				int num4 = ic.aS();
				int num5 = ic.K();
				string text3 = bS.a(num, num4, num5);
				string text4 = bS.a(num2, num4, num5);
				flag = text3.Length * 6 <= 53 && text4.Length * 6 <= 53;
			}
			if (flag && id != null)
			{
				num = id.aR();
				num2 = id.ar();
				if (num != 0 || num2 != 0)
				{
					int num6 = id.aS();
					int num7 = id.K();
					string text5 = bS.a(num, num6, num7);
					string text6 = bS.a(num2, num6, num7);
					flag = text5.Length * 6 <= 53 && text6.Length * 6 <= 53;
				}
			}
		}
		if (flag)
		{
			return 60;
		}
		return 100;
	}

	internal void A(int P_0)
	{
		if (BwI)
		{
			return;
		}
		int num = P_0 - ((Control)Bwg).Width;
		if (num > 0)
		{
			Label bwg = Bwg;
			((Control)bwg).Width = ((Control)bwg).Width + num;
			ThemedTextBox bNP = BNP;
			((Control)bNP).Left = ((Control)bNP).Left + num;
			Label bwH = BwH;
			((Control)bwH).Left = ((Control)bwH).Left + num;
			if (Bwh != null)
			{
				ThemedButton bwh = Bwh;
				((Control)bwh).Left = ((Control)bwh).Left + num;
			}
			PictureBox obj = iG;
			((Control)obj).Left = ((Control)obj).Left + num;
			((Control)this).Width = ((Control)this).Width + num;
		}
	}

	private void D()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		if (((SettingOrSpecialObject)ic).l() && iB.C())
		{
			((Control)Bwg).ForeColor = BM.te;
			((Control)BwH).ForeColor = BM.te;
		}
		else
		{
			((Control)Bwg).ForeColor = BM.tq;
			((Control)BwH).ForeColor = BM.tq;
		}
		bool flag;
		if (BM.QO == BM.b.BpG && iD != null)
		{
			flag = false;
			((Control)BNP).Text = A(iD);
		}
		else
		{
			flag = ((SettingOrSpecialObject)ic).l() && iB.C();
			((Control)BNP).Text = A(ic);
		}
		if (Bwh != null)
		{
			((Control)Bwh).Enabled = flag;
		}
		if (flag && !ic.O())
		{
			((Control)BNP).Enabled = true;
			if (Bz.A() && ic.A() == 1501 && string.IsNullOrEmpty(ic.ay()))
			{
				((Control)BNP).BackColor = BM.to;
				((Control)iG).Visible = false;
				iG.Image = (Image)(object)GeneralResources.QuestionMark;
			}
			else
			{
				switch (ic.P())
				{
				case IllegalitySeverityLevel.Error:
					((Control)BNP).BackColor = Color.Red;
					iG.Image = (Image)(object)GeneralResources.RedError;
					break;
				case IllegalitySeverityLevel.Warning:
					((Control)BNP).BackColor = Color.Orange;
					iG.Image = (Image)(object)GeneralResources.YellowWarning;
					break;
				case IllegalitySeverityLevel.ErrorIfOnline:
					if (BM.A(iB.aXc, true))
					{
						((Control)BNP).BackColor = Color.Red;
						iG.Image = (Image)(object)GeneralResources.RedError;
					}
					else
					{
						((Control)BNP).BackColor = Color.Orange;
						iG.Image = (Image)(object)GeneralResources.YellowWarning;
					}
					break;
				default:
					((Control)BNP).BackColor = Color.Red;
					iG.Image = (Image)(object)GeneralResources.RedError;
					break;
				}
				((Control)iG).Visible = true;
			}
		}
		else
		{
			((Control)BNP).Enabled = flag;
			bool flag2 = iF || @if;
			if (iD != null && !flag2 && !ic.A(iD))
			{
				((Control)BNP).BackColor = BM.tD;
			}
			else if (flag)
			{
				((Control)BNP).BackColor = BM.to;
			}
			else
			{
				((Control)BNP).BackColor = BM.tQ;
			}
			((Control)iG).Visible = false;
			iG.Image = (Image)(object)GeneralResources.QuestionMark;
		}
		if (((Control)BNP).Enabled || ((Control)BNP).BackColor == BM.tD)
		{
			((Control)BNP).ForeColor = BM.te;
		}
		else
		{
			((Control)BNP).ForeColor = BM.tq;
		}
		((Control)this).TabStop = ((Control)BNP).Enabled;
		((Control)BNP).TabStop = ((Control)this).TabStop;
		if (Bwh != null)
		{
			((Control)Bwh).TabStop = ((Control)this).TabStop;
		}
		((Control)BNP).Invalidate();
		d();
	}

	private void d()
	{
		if (BM.QO == BM.b.BpG)
		{
			if (Bwf != null)
			{
				int num = Bwf.aS();
				((Control)BwH).Text = bS.A(Bwf.@as(), num, false, 0);
			}
			else if (iD != null)
			{
				int num2 = iD.aS();
				int num3 = iD.K();
				((Control)BwH).Text = bS.A(iD.@as(), num2, false, iD.ax(), num3);
			}
			else
			{
				int num4 = ic.aS();
				int num5 = ic.K();
				((Control)BwH).Text = bS.A(ic.@as(), num4, false, ic.ax(), num5);
			}
		}
		else if (BwF != null)
		{
			int num6 = BwF.aS();
			((Control)BwH).Text = bS.A(BwF.@as(), num6, false, 0);
		}
		else
		{
			int num7 = ic.aS();
			int num8 = ic.K();
			((Control)BwH).Text = bS.A(ic.@as(), num7, false, ic.ax(), num8);
		}
	}

	private new void B(object P_0, EventArgs P_1)
	{
		BM.A(ic, (Control)(object)this);
	}

	private new void b(object P_0, EventArgs P_1)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Invalid comparison between Unknown and I4
		BM.QQ.rL.A(ic);
		if (ib != null)
		{
			if (((Control)BNP).BackColor == BM.tD)
			{
				BM.A(ic, (Control)(object)this);
			}
		}
		else
		{
			if (!BwG || !((Control)BNP).Enabled || ic.A() != 1501 || !string.IsNullOrEmpty(((Control)BNP).Text) || Bwj || !BM.A(iB.aXc, true))
			{
				return;
			}
			string text = BM.h(iB.aXc);
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			string text2 = ((FileSystemInfo)new DirectoryInfo(text)).Name;
			int num = text2.IndexOf('_');
			if (num != -1)
			{
				text2 = text2.Substring(0, num);
			}
			if (!string.IsNullOrEmpty(text2))
			{
				((Control)BNP).GotFocus -= new EventHandler(b);
				Bwj = true;
				if ((int)bE.A((IWin32Window)(object)BM.QQ, string.Concat(new string[5]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBt(),
					text2,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBU(),
					text2,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ws()
				}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBu(), (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
				{
					((Control)BNP).Text = text2;
					A(false);
					iB.aXD = text;
				}
				Bwj = false;
			}
		}
	}

	private new void C(object P_0, EventArgs P_1)
	{
		if (iF || @if)
		{
			A();
		}
		else
		{
			D();
		}
	}

	private void c(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = c;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		D();
	}

	private string A(Setting P_0)
	{
		if (P_0.c() != 0)
		{
			return P_0.ay();
		}
		int num = P_0.ax();
		if (BM.QO == BM.b.BpG)
		{
			if (iD != null && Bwf != null)
			{
				return bS.a(num, Bwf.aS(), -1);
			}
		}
		else if (BwF != null)
		{
			return bS.a(num, BwF.aS(), -1);
		}
		int num2 = P_0.an();
		if (num2 > 1)
		{
			num = N.A(num, num2);
		}
		if (BNQ != null && P_0.e() && Bwi)
		{
			num -= BNR;
			if (P_0.G())
			{
				int num3 = P_0.aR();
				int num4 = P_0.ar();
				int num5 = P_0.aO();
				int num6 = P_0.ao();
				if (num > num6)
				{
					num -= num4 + 1 - num3;
				}
				else if (num < num5)
				{
					num += num4 + 1 - num3;
				}
			}
		}
		int num7 = P_0.K();
		return bS.a(num, P_0.aS(), num7);
	}

	internal void A(bool P_0)
	{
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)BNP).Disposing || BM.QP || BM.QO == BM.b.BpG || BM.sX)
		{
			return;
		}
		string text = ((Control)BNP).Text;
		BNp = false;
		string text2 = A(ic);
		if (text2 == text && (!Bwk || P_0))
		{
			return;
		}
		Bwk = P_0;
		if (BwG && ic.A() == 1501 && !Bwj && !P_0)
		{
			Bwj = true;
			BM.A(text2, text, iB);
			Bwj = false;
		}
		if (string.IsNullOrWhiteSpace(text) && !BwG)
		{
			((Control)BNP).Text = text2;
		}
		else if (((SettingOrSpecialObject)ic).j())
		{
			if (!BwG)
			{
				try
				{
					int num;
					int num2;
					if (BwF != null)
					{
						num = BwF.aR();
						num2 = BwF.ar();
					}
					else
					{
						num = ic.aR();
						num2 = ic.ar();
					}
					int num3 = ic.K();
					int num7;
					if (BNQ != null && ic.e() && Bwi)
					{
						int num4 = bS.A(text, ic.aS(), num3);
						int num5 = ic.aO();
						int num6 = ic.ao();
						if (num5 != 0 || num6 != 0)
						{
							num4 = Math.Min(num6, Math.Max(num5, num4));
						}
						num7 = num4 + BNR;
						if (ic.G() && (num != 0 || num2 != 0))
						{
							num7 = (num7 - (num2 + 1)) % (num2 + 1 - num) + num;
							if (num7 < num)
							{
								num7 += num2 + 1 - num;
							}
							else if (num7 > num2)
							{
								num7 -= num2 + 1 - num;
							}
						}
					}
					else
					{
						num7 = ((BwF == null) ? bS.A(text, ic.aS(), num3) : bS.A(text, BwF.aS()));
						if (ic.aG() == 2)
						{
							if (ic.ag())
							{
								if (num7 < -32768)
								{
									num7 = -32768;
								}
								else if (num7 > 32767)
								{
									num7 = 32767;
								}
							}
							else if (num7 < 0)
							{
								num7 = 0;
							}
							else if (num7 > 65535)
							{
								num7 = 65535;
							}
						}
						else if (ic.aG() == 1)
						{
							if (ic.ag())
							{
								if (num7 < -128)
								{
									num7 = -128;
								}
								else if (num7 > 127)
								{
									num7 = 127;
								}
							}
							else if (num7 < 0)
							{
								num7 = 0;
							}
							else if (num7 > 255)
							{
								num7 = 255;
							}
						}
					}
					if (BwF == null)
					{
						int num8 = ic.an();
						if (num8 > 1)
						{
							num7 = N.A(num7, num8);
						}
					}
					if (num != 0 || num2 != 0)
					{
						num7 = Math.Min(Math.Max(num7, num), num2);
					}
					Ck ck = BM.aM();
					ck?.A(ic.C());
					ic.a(num7, true);
					ck?.B();
					BM.A(ic.C());
					return;
				}
				catch
				{
					BwK = true;
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fQ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					BwK = false;
					((Control)BNP).Text = text2;
					return;
				}
			}
			Ck ck2 = BM.aM();
			if (!P_0)
			{
				ck2?.A(ic.C());
			}
			ic.A(text, true);
			if (!P_0)
			{
				ck2?.B();
			}
			BM.A(ic.C());
		}
		else
		{
			((Control)BNP).Text = text2;
		}
	}

	private void A(object P_0, KeyEventArgs P_1)
	{
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Invalid comparison between Unknown and I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Invalid comparison between Unknown and I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Invalid comparison between Unknown and I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Invalid comparison between Unknown and I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Invalid comparison between Unknown and I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Invalid comparison between Unknown and I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Invalid comparison between Unknown and I4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Invalid comparison between Unknown and I4
		if (BwG)
		{
			bool flag = Encoding.GetEncoding(ic.c()).GetBytes(((Control)BNP).Text).Length >= ic.av()[2];
			if (((TextBoxBase)BNP).Multiline)
			{
				if ((int)P_1.KeyData == 65549)
				{
					if (flag)
					{
						BwM = true;
					}
				}
				else if ((int)P_1.KeyCode == 13 || (int)P_1.KeyCode == 13)
				{
					Bwl = true;
					P_1.Handled = true;
					A(false);
				}
				else if (flag && (int)P_1.KeyCode != 8)
				{
					BwM = true;
				}
			}
			else if ((int)P_1.KeyCode == 13 || (int)P_1.KeyCode == 13)
			{
				A(false);
			}
			else if (flag && (int)P_1.KeyCode != 8)
			{
				BwM = true;
			}
		}
		else if ((P_1.Control && (int)P_1.KeyCode == 33) || (int)P_1.KeyData == 33 || (P_1.Shift && (int)P_1.KeyCode == 33) || (P_1.Control && (int)P_1.KeyCode == 34) || (int)P_1.KeyData == 34 || (P_1.Shift && (int)P_1.KeyCode == 34))
		{
			BwL = true;
			P_1.Handled = true;
		}
		else if ((int)P_1.KeyCode == 13 || (int)P_1.KeyCode == 13)
		{
			A(false);
		}
		else if (!P_1.Control)
		{
			BNp = true;
		}
		BwJ.Stop();
		BwJ.Start();
	}

	private void A(object P_0, KeyPressEventArgs P_1)
	{
		if (BwL)
		{
			P_1.Handled = true;
			BwL = false;
			BNp = false;
		}
		else if (BwG)
		{
			if (((TextBoxBase)BNP).Multiline && Bwl)
			{
				P_1.Handled = true;
				Bwl = false;
			}
			else if (BwM)
			{
				P_1.Handled = true;
				BwM = false;
			}
		}
		else if (P_1.KeyChar == '.')
		{
			if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq())
			{
				P_1.Handled = true;
			}
		}
		else if (P_1.KeyChar == ',' && CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ())
		{
			P_1.Handled = true;
		}
	}

	private void D(object P_0, EventArgs P_1)
	{
		BwJ.Stop();
		if (BwG && ic != null && Bz.A() && ic.A() == 1501)
		{
			A(true);
		}
	}

	private void d(object P_0, EventArgs P_1)
	{
		if (!BwK && !Bwj)
		{
			A(false);
		}
	}

	private void E(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				a a = E;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		E();
		if (BM.QO != BM.b.BpG && !BNp)
		{
			int selectionStart = ((TextBoxBase)BNP).SelectionStart;
			int selectionLength = ((TextBoxBase)BNP).SelectionLength;
			string text = A(ic);
			if (((Control)BNP).Text != text)
			{
				((Control)BNP).Text = text;
			}
			((TextBoxBase)BNP).SelectionStart = selectionStart;
			((TextBoxBase)BNP).SelectionLength = selectionLength;
			if (iD != null)
			{
				D();
			}
		}
	}

	private void e(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				B b = e;
				((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BM.QO != BM.b.BpG)
		{
			int num = BwE.ax();
			if (BwF == null || num != BwF.A())
			{
				BwF = iB.A(num);
				BM.A(BwE.C());
				D();
			}
		}
	}

	private void E()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		FontStyle val = (FontStyle)0;
		if (BNQ != null && !BwG && BNq)
		{
			Setting setting = ((BM.QO != BM.b.BpG || iD == null) ? ic : iD);
			if (setting.ax() != BNR)
			{
				val = (FontStyle)2;
			}
		}
		if (((Control)BNP).Font.Style != val)
		{
			Font font = ((Control)BNP).Font;
			((Control)BNP).Font = new Font(((Control)BNP).Font.FontFamily, ((Control)BNP).Font.Size, val);
			font.Dispose();
		}
		if (((Control)Bwg).Font.Style != val)
		{
			Font font2 = ((Control)Bwg).Font;
			((Control)Bwg).Font = new Font(((Control)Bwg).Font.FontFamily, ((Control)Bwg).Font.Size, val);
			font2.Dispose();
		}
	}

	private void F(object P_0, EventArgs P_1)
	{
		if (BM.QO != BM.b.BpG)
		{
			int num = (int)((Control)BNP).Tag;
			Setting setting = iB.A(num);
			((Control)BNP).Text = bS.a(setting.ax(), ic.aS(), -1);
			A(false);
		}
	}

	[SpecialName]
	internal ThemedButton e()
	{
		return Bwh;
	}

	public override string ToString()
	{
		return ((SettingOrSpecialObject)ic).A(true);
	}

	internal bool A(KeyEventArgs P_0)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Invalid comparison between Unknown and I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Invalid comparison between Unknown and I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Invalid comparison between Unknown and I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG)
		{
			return false;
		}
		if (BwG || ((!P_0.Control || (int)P_0.KeyCode != 33) && (int)P_0.KeyData != 33 && (!P_0.Shift || (int)P_0.KeyCode != 33) && (!P_0.Control || (int)P_0.KeyCode != 34) && (int)P_0.KeyData != 34 && (!P_0.Shift || (int)P_0.KeyCode != 34)))
		{
			return false;
		}
		BNp = false;
		int num;
		int num2;
		int num3;
		if (BwF != null)
		{
			num = BwF.aS();
			num2 = BwF.aR();
			num3 = BwF.ar();
		}
		else
		{
			num = ic.aS();
			num2 = ic.aR();
			num3 = ic.ar();
		}
		int num4 = ic.ax();
		int num5 = num4;
		if (P_0.Control && (int)P_0.KeyCode == 33)
		{
			num5 += bS.b(num);
		}
		else if ((int)P_0.KeyData == 33)
		{
			num5 += bS.C(num);
		}
		else if (P_0.Shift && (int)P_0.KeyCode == 33)
		{
			num5 += bS.c(num);
		}
		else if (P_0.Control && (int)P_0.KeyCode == 34)
		{
			num5 -= bS.b(num);
		}
		else if ((int)P_0.KeyData == 34)
		{
			num5 -= bS.C(num);
		}
		else if (P_0.Shift && (int)P_0.KeyCode == 34)
		{
			num5 -= bS.c(num);
		}
		if (num5 != num4)
		{
			int num6 = ic.K();
			if (BNQ != null && ic.e() && Bwi)
			{
				int num7 = num5 - BNR;
				int num8 = ic.aO();
				int num9 = ic.ao();
				if (num8 != 0 || num9 != 0)
				{
					num7 = Math.Min(num9, Math.Max(num8, num7));
				}
				((Control)BNP).Text = bS.a(num7, num, num6);
				A(false);
			}
			else
			{
				if (num2 != 0 || num3 != 0)
				{
					num5 = Math.Min(num3, Math.Max(num2, num5));
				}
				if (num5 != num4)
				{
					((Control)BNP).Text = bS.a(num5, num, num6);
					A(false);
				}
			}
		}
		return true;
	}

	protected override void A()
	{
		F();
		int width = ((Control)Bwg).Width;
		if (((Control)this).Parent != null)
		{
			((Control)this).Parent.SuspendLayout();
		}
		A(iC, iB, ib, BNQ, BNq, Bwi, BwI);
		A(Math.Max(width, ((Control)Bwg).Width));
		if (((Control)this).Parent != null)
		{
			((Control)this).Parent.ResumeLayout(true);
		}
	}

	private void F()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		try
		{
			if (Bwh != null)
			{
				((Control)Bwh).Click -= new EventHandler(F);
			}
			((Control)BNP).GotFocus -= new EventHandler(b);
			((Control)BNP).KeyDown -= new KeyEventHandler(A);
			((Control)BNP).KeyPress -= new KeyPressEventHandler(A);
			((Control)BNP).Leave -= new EventHandler(d);
			((Control)this).MouseEnter -= new EventHandler(((aj)this).A);
			((Control)Bwg).MouseEnter -= new EventHandler(((aj)this).A);
			((Control)BNP).MouseEnter -= new EventHandler(((aj)this).A);
			((Control)BwH).MouseEnter -= new EventHandler(((aj)this).A);
			((Control)iG).MouseEnter -= new EventHandler(((aj)this).A);
			((Control)BNP).MouseLeave -= new EventHandler(((aj)this).a);
			((Control)this).MouseLeave -= new EventHandler(((aj)this).a);
			((Control)iG).Click -= new EventHandler(B);
			ic.a(new EventHandler(E));
			((SettingOrSpecialObject)ic).a(new EventHandler(c));
			if (BwE != null)
			{
				BwE.a(new EventHandler(e));
				((SettingOrSpecialObject)BwE).a(new EventHandler(c));
			}
			if (iE != null)
			{
				((SettingOrSpecialObject)iE).a(new EventHandler(((aj)this).B));
			}
			if (ie != null)
			{
				ie.a(new EventHandler(((aj)this).b));
			}
			BM.QQ.b(new EventHandler(C));
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		F();
		if (BM.SR == iG)
		{
			BM.SR = null;
		}
		BwJ.Tick -= new EventHandler(D);
		((Component)BwJ).Dispose();
		try
		{
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
internal class De : cq
{
	private new delegate void A();

	private new delegate void a(object P_0, EventArgs P_1);

	private new delegate void B(object P_0, EventArgs P_1);

	private new delegate void b(object P_0, EventArgs P_1);

	internal new enum C
	{
		bBF = 255,
		bBf = 0,
		bBG = 1,
		bBg = 2,
		bBH = 3,
		bBh = 4,
		bBI = 5,
		bBi = 6,
		bBJ = 7,
		bBj = 8,
		bBK = 9,
		bBk = 10,
		bBL = 11
	}

	internal enum c
	{
		bBl,
		bBM,
		bBm
	}

	private Framework Bwm;

	private Framework BwN;

	private StateMachine Bwn;

	private Setting BwO;

	private Setting Bwo;

	private Setting BwP;

	private Setting Bwp;

	private List<Setting> BwQ = new List<Setting>();

	private int Bwq;

	private List<Label> BwR = new List<Label>();

	private List<Label> Bwr = new List<Label>();

	private List<ProgressBar> BwS = new List<ProgressBar>();

	private Image Bws;

	private PictureBox BwT = new PictureBox();

	private Size Bwt;

	private Label BwU = new Label();

	private Label Bwu = new Label();

	private Label BwV = new Label();

	private ThemedButton Bwv = new ThemedButton();

	private ThemedButton BwW = new ThemedButton();

	private Rectangle Bww;

	private bool BwX;

	private bool Bwx;

	private Stopwatch BwY = new Stopwatch();

	internal De(StateMachine P_0, Framework P_1, Framework P_2, Rectangle P_3, bool P_4)
		: base(P_3, P_4, false)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		Bwm = P_1;
		BwN = P_2;
		Bwn = P_0;
		Bww = P_3;
		BwX = Bwm.B() && Bwm.b() && Bwn.StatusChannelDataId != 0 && Bwm.A(Bwn.StatusChannelDataId).J();
		Bwx = BwN != null && BwN.B() && BwN.b() && Bwn.StatusChannelDataId != 0 && BwN.A(Bwn.StatusChannelDataId).J();
		bool flag = ((BM.QO != BM.b.BpG || BwN == null) ? BwX : Bwx);
		if (Bwn.StatusChannelDataId != 0)
		{
			BwO = Bwm.A(Bwn.StatusChannelDataId);
			if (!flag)
			{
				BwO.A(new EventHandler(b));
			}
		}
		if (Bwn.OutcomeErrorChannelDataId != 0)
		{
			Bwo = Bwm.A(Bwn.OutcomeErrorChannelDataId);
			if (!flag)
			{
				Bwo.A(new EventHandler(C));
			}
		}
		if (Bwn.CurrentStageChannelDataId != 0)
		{
			BwP = Bwm.A(Bwn.CurrentStageChannelDataId);
		}
		if (Bwn.RequestStageChannelDataId != 0)
		{
			Bwp = Bwm.A(Bwn.RequestStageChannelDataId);
		}
		for (int i = 0; i < Bwn.StagesList.Count; i++)
		{
			StateMachineStage stateMachineStage = Bwn.StagesList[i];
			if (stateMachineStage.C() != 0)
			{
				Setting setting = Bwm.A(stateMachineStage.C());
				setting.A(new EventHandler(c));
				BwQ.Add(setting);
			}
		}
		BM.QQ.B(new EventHandler(B));
		global::A.A.A((global::A.D)D);
		BM.D(new EventHandler(D));
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		try
		{
			if (BwO != null)
			{
				BwO.a(new EventHandler(b));
			}
			if (Bwo != null)
			{
				Bwo.a(new EventHandler(C));
			}
			for (int i = 0; i < Bwn.StagesList.Count; i++)
			{
				StateMachineStage stateMachineStage = Bwn.StagesList[i];
				if (stateMachineStage.C() != 0)
				{
					Bwm.A(stateMachineStage.C())?.a(new EventHandler(c));
				}
			}
			BM.QQ.b(new EventHandler(B));
			global::A.A.a((global::A.D)D);
			BM.d(new EventHandler(D));
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val = item;
				if (val is Button)
				{
					((val is Button) ? val : null).Click -= new EventHandler(d);
					((val is Button) ? val : null).Click -= new EventHandler(E);
				}
			}
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private void B(object P_0, EventArgs P_1)
	{
		((Control)base.B()).Controls.Clear();
		b();
	}

	private new Size B()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		Size result = default(Size);
		((Size)(ref result))._002Ector(0, 0);
		for (int i = 0; i < Bwn.StagesList.Count; i++)
		{
			byte[] array = n.A(Bwn.StagesList[i].A());
			if (array != null)
			{
				Image val = Image.FromStream((Stream)new MemoryStream(array));
				if (val != null)
				{
					((Size)(ref result)).Width = Math.Max(((Size)(ref result)).Width, val.Width);
					((Size)(ref result)).Height = Math.Max(((Size)(ref result)).Height, val.Height);
					val.Dispose();
				}
			}
		}
		return result;
	}

	internal new void b()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).FindForm() is BZ && !Bwn.l())
		{
			((Control)this).Width = 0;
			((Control)this).Height = 0;
			((Control)this).Visible = false;
			return;
		}
		((Control)this).SuspendLayout();
		((Control)base.B()).SuspendLayout();
		int left = 5;
		int top = 5;
		if ((BM.QO != BM.b.BpG || BwN == null) ? BwX : Bwx)
		{
			Label val = new Label();
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + Bwn.A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO();
			((Control)val).ForeColor = BM.te;
			((Control)val).BackColor = Color.Transparent;
			((Control)val).AutoSize = true;
			((Control)val).Left = left;
			((Control)val).Top = top;
			((Control)base.B()).Controls.Add((Control)(object)val);
		}
		else
		{
			Bwq = 0;
			if (BwO != null)
			{
				for (int i = 0; i < Bwn.StagesList.Count; i++)
				{
					Enumerator<int> enumerator = Bwn.StagesList[i].B().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current = enumerator.Current;
							if (BwO.ax() == current)
							{
								Bwq = i;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
			}
			else if (BwP != null)
			{
				if (Bwm.aWR)
				{
					Bwq = BwP.l(3);
				}
				else
				{
					Bwq = BwP.l(0);
				}
			}
			Bwt = B();
			A(ref left, ref top);
			a(ref left, ref top);
			b(ref left, ref top);
			B(ref left, ref top);
			C(ref left, ref top);
			c(ref left, ref top);
			D(ref left, ref top);
		}
		if (Bww != Rectangle.Empty)
		{
			((Control)this).Width = ((Rectangle)(ref Bww)).Width;
			((Control)this).Height = ((Rectangle)(ref Bww)).Height;
			((Control)this).Left = ((Rectangle)(ref Bww)).Left;
			((Control)this).Top = ((Rectangle)(ref Bww)).Top;
		}
		else
		{
			int num = 0;
			int num2 = 0;
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val2 = item;
				num = Math.Max(num, val2.Right + 20);
				num2 = Math.Max(num2, val2.Bottom + 50);
			}
			((Control)this).Width = num;
			((Control)this).Height = num2;
		}
		foreach (Control item2 in (ArrangedElementCollection)((Control)this).Controls)
		{
			item2.Enabled = Bwn.l() && Bwm.C();
		}
		((Control)base.B()).ResumeLayout(true);
		((Control)this).ResumeLayout(true);
	}

	private void A(ref int P_0, ref int P_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (Bwo != null)
		{
			Label val = new Label();
			((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8.25f, (FontStyle)1);
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jd();
			((Control)val).ForeColor = BM.te;
			((Control)val).Left = P_0;
			((Control)val).Top = P_1;
			((Control)val).Width = 160;
			((Control)val).Height = 16;
			((Control)base.B()).Controls.Add((Control)(object)val);
			P_0 = ((Control)val).Right + 10;
		}
	}

	private void a(ref int P_0, ref int P_1)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		for (int i = 0; i < Bwn.StagesList.Count; i++)
		{
			StateMachineStage stateMachineStage = Bwn.StagesList[i];
			Label val = new Label();
			((Control)val).ForeColor = BM.te;
			BwR.Add(val);
			if (i == Bwq)
			{
				((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8.25f, (FontStyle)1);
				((Control)val).Enabled = true;
			}
			else
			{
				((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8.25f);
				if (BM.Tn == BM.r.BqG || BM.Tn == BM.r.Bqh)
				{
					((Control)val).Enabled = false;
				}
			}
			((Control)val).Text = string.Empty;
			if (stateMachineStage.a() != -1)
			{
				((Control)val).Text = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgJ(), (object)(stateMachineStage.a() + 1));
			}
			((Control)val).Left = P_0;
			((Control)val).Top = P_1;
			((Control)val).Width = 80;
			((Control)val).Height = 16;
			((Control)base.B()).Controls.Add((Control)(object)val);
			P_0 = ((Control)val).Right + 10;
		}
		P_0 = 5;
		P_1 += 18;
	}

	private void B(ref int P_0, ref int P_1)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		int num = 0;
		for (int i = 0; i < Bwn.StagesList.Count; i++)
		{
			StateMachineStage stateMachineStage = Bwn.StagesList[i];
			Label val = new Label();
			((Control)val).ForeColor = BM.te;
			Bwr.Add(val);
			if (i == Bwq)
			{
				((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8.25f, (FontStyle)1);
				((Control)val).Enabled = true;
			}
			else
			{
				((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8.25f);
				if (BM.Tn == BM.r.BqG || BM.Tn == BM.r.Bqh)
				{
					((Control)val).Enabled = false;
				}
			}
			((Control)val).Text = stateMachineStage.e();
			((Control)val).Left = P_0;
			((Control)val).Top = P_1;
			((Control)val).Width = 80;
			((Control)val).Height = 16;
			((Control)base.B()).Controls.Add((Control)(object)val);
			if (stateMachineStage.C() != 0)
			{
				ProgressBar val2 = new ProgressBar();
				BwS.Add(val2);
				Setting setting = BwQ[num];
				val2.Minimum = setting.aQ();
				val2.Maximum = setting.aq();
				int num2 = setting.ax();
				num2 = Math.Min(val2.Maximum, num2);
				num2 = Math.Max(val2.Minimum, num2);
				val2.Value = num2;
				((Control)val2).Left = P_0;
				((Control)val2).Top = ((Control)val).Bottom;
				((Control)val2).Width = 70;
				((Control)val2).Height = 10;
				((Control)base.B()).Controls.Add((Control)(object)val2);
				num++;
			}
			P_0 = ((Control)val).Right + 10;
		}
		P_0 = 5;
		P_1 += 18;
	}

	private void b(ref int P_0, ref int P_1)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (Bwo == null)
		{
			return;
		}
		((Control)BwU).Left = P_0;
		((Control)BwU).Top = P_1;
		((Control)BwU).Width = 160;
		((Control)BwU).Height = 16;
		((Control)BwU).ForeColor = BM.te;
		Enumerator<StateMachineError> enumerator = Bwn.ErrorsList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				StateMachineError current = enumerator.Current;
				if (Bwo.ax() == current.A())
				{
					A(current);
					((Control)base.B()).Controls.Add((Control)(object)BwU);
					break;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		P_0 = ((Control)BwU).Right + 10;
	}

	private void C(ref int P_0, ref int P_1)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		byte[] array = n.A(Bwn.StagesList[Bwq].A());
		if (array != null)
		{
			Bws = Image.FromStream((Stream)new MemoryStream(array));
		}
		else
		{
			Bws = null;
		}
		((Control)BwT).Left = P_0;
		((Control)BwT).Top = P_1;
		if (BM.Tn != 0 && BM.Tn != BM.r.Bqh)
		{
			((Control)BwT).BackColor = SystemColors.Control;
		}
		if (Bws != null)
		{
			((Control)BwT).Width = Bws.Width;
			((Control)BwT).Height = Bws.Height;
			BwT.Image = Bws;
			((Control)BwT).Visible = true;
		}
		else
		{
			BwT.Image = null;
			((Control)BwT).Visible = false;
		}
		((Control)base.B()).Controls.Add((Control)(object)BwT);
		P_1 += ((Size)(ref Bwt)).Height + 10;
	}

	private void c(ref int P_0, ref int P_1)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		((Control)BwW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgj();
		((Control)BwW).Width = 100;
		((Control)BwW).Height = 25;
		((Control)BwW).Left = P_0 + ((((Size)(ref Bwt)).Width != 0) ? (((Size)(ref Bwt)).Width + 40) : 0);
		if (Bws != null)
		{
			P_1 = ((Control)BwT).Top + Math.Max(((Size)(ref Bwt)).Height, ((Control)BwT).Height) / 2 - 15;
		}
		((Control)BwW).Top = P_1;
		((Control)BwW).Enabled = Bwm.C() && (BM.QO != BM.b.BpG || BwN == null);
		((Control)BwW).Click -= new EventHandler(E);
		((Control)BwW).Click += new EventHandler(E);
		((Control)base.B()).Controls.Add((Control)(object)BwW);
		P_0 = ((Control)BwW).Right + 10;
		((Control)Bwv).Text = Bwn.StagesList[Bwq].f();
		((Control)Bwv).Width = 100;
		((Control)Bwv).Height = 25;
		((Control)Bwv).Left = P_0;
		((Control)Bwv).Top = P_1;
		((Control)Bwv).Enabled = Bwm.C() && (BM.QO != BM.b.BpG || BwN == null);
		((Control)Bwv).Click -= new EventHandler(d);
		((Control)Bwv).Click += new EventHandler(d);
		((Control)base.B()).Controls.Add((Control)(object)Bwv);
		P_0 = 5;
		P_1 = ((Control)BwT).Top + Math.Max(((Size)(ref Bwt)).Height, ((Control)BwT).Height) + 5;
	}

	private void D(ref int P_0, ref int P_1)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		((Control)Bwu).Font = new Font(((Control)Bwu).Font.FontFamily, 8.25f, (FontStyle)1);
		((Control)Bwu).Text = string.Empty;
		((Control)Bwu).ForeColor = BM.te;
		if (Bwn.StagesList[Bwq].a() != -1)
		{
			((Control)Bwu).Text = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgK(), (object)(Bwn.StagesList[Bwq].a() + 1));
		}
		Label bwu = Bwu;
		((Control)bwu).Text = ((Control)bwu).Text + Bwn.StagesList[Bwq].e();
		((Control)Bwu).Left = P_0;
		((Control)Bwu).Top = P_1;
		((Control)Bwu).Width = ((Control)this).Width - ((Control)Bwu).Left - 20;
		((Control)base.B()).Controls.Add((Control)(object)Bwu);
		P_1 = ((Control)Bwu).Bottom;
		int num = ((Control)Bwv).Right;
		if (BwS.Count != 0)
		{
			num = Math.Max(num, ((Control)BwS[BwS.Count - 1]).Right);
		}
		((Control)BwV).Text = Bwn.StagesList[Bwq].F();
		((Control)BwV).ForeColor = BM.te;
		((Control)BwV).AutoSize = true;
		((Control)BwV).MinimumSize = new Size(0, 20);
		((Control)BwV).MaximumSize = new Size(num - 10, 100);
		((Control)BwV).Left = P_0;
		((Control)BwV).Top = P_1;
		((Control)BwV).Width = num - 10;
		((Control)base.B()).Controls.Add((Control)(object)BwV);
	}

	private void b(object P_0, EventArgs P_1)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < Bwn.StagesList.Count; i++)
		{
			Enumerator<int> enumerator = Bwn.StagesList[i].B().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					if (BwO.ax() == current)
					{
						if (Bwq != i)
						{
							Bwq = i;
							C();
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
	}

	private new void C()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = C;
				((Control)this).Invoke((System.Delegate)a);
				return;
			}
			catch
			{
				return;
			}
		}
		for (int i = 0; i < BwR.Count; i++)
		{
			Label val = BwR[i];
			if (i == Bwq)
			{
				((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8.25f, (FontStyle)1);
				((Control)val).Enabled = true;
			}
			else
			{
				((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8.25f);
				((Control)val).Enabled = false;
			}
		}
		for (int j = 0; j < Bwr.Count; j++)
		{
			Label val2 = Bwr[j];
			if (j == Bwq)
			{
				((Control)val2).Font = new Font(((Control)val2).Font.FontFamily, 8.25f, (FontStyle)1);
				((Control)val2).Enabled = true;
			}
			else
			{
				((Control)val2).Font = new Font(((Control)val2).Font.FontFamily, 8.25f);
				((Control)val2).Enabled = false;
			}
		}
		byte[] array = n.A(Bwn.StagesList[Bwq].A());
		if (array != null)
		{
			Bws = Image.FromStream((Stream)new MemoryStream(array));
			((Control)BwT).Width = Bws.Width;
			((Control)BwT).Height = Bws.Height;
			BwT.Image = Bws;
			((Control)BwT).Visible = true;
		}
		else
		{
			Bws = null;
			BwT.Image = null;
			((Control)BwT).Visible = false;
		}
		((Control)Bwu).Text = string.Empty;
		if (Bwn.StagesList[Bwq].a() != -1)
		{
			((Control)Bwu).Text = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgK(), (object)(Bwn.StagesList[Bwq].a() + 1));
		}
		Label bwu = Bwu;
		((Control)bwu).Text = ((Control)bwu).Text + Bwn.StagesList[Bwq].e();
		((Control)Bwu).Width = ((Control)this).Width - ((Control)Bwu).Left - 20;
		((Control)BwV).Text = Bwn.StagesList[Bwq].F();
		((Control)Bwv).Text = Bwn.StagesList[Bwq].f();
	}

	private void A(StateMachineError P_0)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		((Control)BwU).Font = new Font(((Control)BwU).Font.FontFamily, 8.25f, (FontStyle)1);
		string text;
		if (BwN == null)
		{
			((Control)BwU).Text = P_0.a();
			text = P_0.B();
			if (!(text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgk()))
			{
				if (!(text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgL()))
				{
					if (text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgl())
					{
						((Control)BwU).ForeColor = BM.tC;
					}
				}
				else
				{
					((Control)BwU).ForeColor = Color.DarkOrange;
				}
			}
			else if (BM.Tn == BM.r.BqG || BM.Tn == BM.r.Bqh)
			{
				((Control)BwU).ForeColor = Color.DarkGreen;
			}
			else
			{
				((Control)BwU).ForeColor = Color.Green;
			}
			return;
		}
		if (P_0.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgk())
		{
			bool flag = true;
			if (Bwn.o() != null)
			{
				Enumerator<int> enumerator = Bwn.o().aE().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						int current = enumerator.Current;
						Setting setting = Bwm.A(current);
						Setting setting2 = BwN.A(current);
						if (setting != null && setting2 != null && !setting.A(setting2))
						{
							flag = false;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			if (flag)
			{
				((Control)BwU).Text = P_0.a();
				if (BM.Tn == BM.r.BqG || BM.Tn == BM.r.Bqh)
				{
					((Control)BwU).ForeColor = Color.DarkGreen;
				}
				else
				{
					((Control)BwU).ForeColor = Color.Green;
				}
			}
			else
			{
				((Control)BwU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgM();
				((Control)BwU).ForeColor = BM.tD;
			}
			return;
		}
		((Control)BwU).Text = P_0.a();
		text = P_0.B();
		if (!(text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgL()))
		{
			if (text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgl())
			{
				((Control)BwU).ForeColor = BM.tC;
			}
		}
		else
		{
			((Control)BwU).ForeColor = Color.DarkOrange;
		}
	}

	private void C(object P_0, EventArgs P_1)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).InvokeRequired)
		{
			try
			{
				a a = C;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		bool flag = false;
		Enumerator<StateMachineError> enumerator = Bwn.ErrorsList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				StateMachineError current = enumerator.Current;
				if (Bwo.ax() == current.A())
				{
					A(current);
					flag = true;
					break;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (!flag)
		{
			((Control)base.B()).Controls.Remove((Control)(object)BwU);
		}
		else if (!((Control)base.B()).Controls.Contains((Control)(object)BwU))
		{
			((Control)base.B()).Controls.Add((Control)(object)BwU);
		}
	}

	private void c(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				B b = c;
				((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		for (int i = 0; i < BwQ.Count; i++)
		{
			Setting setting = BwQ[i];
			if (P_0 as Setting == setting && i < BwS.Count)
			{
				int num = setting.ax();
				num = Math.Min(BwS[i].Maximum, num);
				num = Math.Max(BwS[i].Minimum, num);
				BwS[i].Value = num;
				break;
			}
		}
	}

	private void D(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				b b = D;
				((Control)this).BeginInvoke((System.Delegate)b, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (!BM.A(Bwm.aXc, true) || BM.aE())
		{
			for (int i = 0; i < BwS.Count; i++)
			{
				BwS[i].Value = 0;
			}
		}
	}

	private void d(object P_0, EventArgs P_1)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		if (!BM.A(Bwm.aXc, true) || BwP == null || Bwp == null || !Bwm.C() || Bwq < 0 || Bwq >= Bwn.StagesList.Count)
		{
			return;
		}
		string text = Bwn.StagesList[Bwq].G();
		if (!string.IsNullOrEmpty(text) && (int)bE.A((IWin32Window)(object)BM.QQ, text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) != 6)
		{
			return;
		}
		((Control)Bwv).Enabled = false;
		BackgroundWorker val = new BackgroundWorker();
		val.DoWork += new DoWorkEventHandler(A);
		val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(A);
		bool flag = false;
		for (int i = 0; i < Bwn.StagesList.Count; i++)
		{
			if (Bwn.StagesList[i].D() != 0)
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			val.RunWorkerAsync((object)Bwn.StagesList[Bwq].D());
		}
		else if (Bwm.aWR)
		{
			val.RunWorkerAsync((object)(int)BwP.l(3));
		}
		else
		{
			val.RunWorkerAsync((object)(int)BwP.l(0));
		}
	}

	private void A(object P_0, DoWorkEventArgs P_1)
	{
		byte b = (byte)(int)P_1.Argument;
		if (Bwm.aWR)
		{
			Bwp.A(0, (byte)0, true);
			Bwp.A(1, (byte)0, true);
			Bwp.A(2, (byte)2, true);
			Bwp.A(3, b, true);
		}
		else
		{
			Bwp.A(3, (byte)0, true);
			Bwp.A(2, (byte)0, true);
			Bwp.A(1, (byte)2, true);
			Bwp.A(0, b, true);
		}
		Thread.Sleep(100);
		BwY.Restart();
		while (BwP.l((!Bwm.aWR) ? 1 : 2) == 255)
		{
			if (BwY.ElapsedMilliseconds > Bwn.StagesList[Bwq].c())
			{
				if (BwO == null)
				{
					Bwq = 0;
					C();
				}
				return;
			}
		}
		Thread.Sleep(100);
		if (Bwm.aWR)
		{
			Bwp.A(0, (byte)0, true);
			Bwp.A(1, (byte)0, true);
			Bwp.A(2, (byte)1, true);
			Bwp.A(3, b, true);
		}
		else
		{
			Bwp.A(3, (byte)0, true);
			Bwp.A(2, (byte)0, true);
			Bwp.A(1, (byte)1, true);
			Bwp.A(0, b, true);
		}
		Thread.Sleep(100);
		BwY.Restart();
		while (BwP.l((!Bwm.aWR) ? 1 : 2) == 255)
		{
			if (BwY.ElapsedMilliseconds > Bwn.StagesList[Bwq].c())
			{
				if (BwO == null)
				{
					Bwq = 0;
					C();
				}
				return;
			}
		}
		if (BwO == null)
		{
			Thread.Sleep(200);
			if (Bwm.aWR)
			{
				Bwq = BwP.l(3);
			}
			else
			{
				Bwq = BwP.l(0);
			}
			C();
		}
	}

	private void A(object P_0, RunWorkerCompletedEventArgs P_1)
	{
		((Control)Bwv).Enabled = Bwm.C();
		Bwm.A(0L);
	}

	private void E(object P_0, EventArgs P_1)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		if (BM.A(Bwm.aXc, true) && BwP != null && Bwp != null && Bwm.C())
		{
			((Control)BwW).Enabled = false;
			BackgroundWorker val = new BackgroundWorker();
			val.DoWork += new DoWorkEventHandler(a);
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(a);
			val.RunWorkerAsync();
		}
	}

	private void a(object P_0, DoWorkEventArgs P_1)
	{
		if (Bwm.aWR)
		{
			Bwp.A(0, (byte)0, true);
			Bwp.A(1, (byte)0, true);
			Bwp.A(2, (byte)2, true);
			Bwp.A(3, (byte)0, true);
		}
		else
		{
			Bwp.A(3, (byte)0, true);
			Bwp.A(2, (byte)0, true);
			Bwp.A(1, (byte)2, true);
			Bwp.A(0, (byte)0, true);
		}
		Thread.Sleep(100);
		BwY.Restart();
		while (BwP.l((!Bwm.aWR) ? 1 : 2) == 255)
		{
			if (BwY.ElapsedMilliseconds > Bwn.StagesList[Bwq].c())
			{
				if (BwO == null)
				{
					Bwq = 0;
					C();
				}
				return;
			}
		}
		Thread.Sleep(100);
		if (Bwm.aWR)
		{
			Bwp.A(0, (byte)0, true);
			Bwp.A(1, (byte)0, true);
			Bwp.A(2, (byte)1, true);
			Bwp.A(3, (byte)0, true);
		}
		else
		{
			Bwp.A(3, (byte)0, true);
			Bwp.A(2, (byte)0, true);
			Bwp.A(1, (byte)1, true);
			Bwp.A(0, (byte)0, true);
		}
		Thread.Sleep(100);
		BwY.Restart();
		while (BwP.l((!Bwm.aWR) ? 1 : 2) == 255)
		{
			if (BwY.ElapsedMilliseconds > Bwn.StagesList[Bwq].c())
			{
				if (BwO == null)
				{
					Bwq = 0;
					C();
				}
				return;
			}
		}
		if (BwO == null)
		{
			Thread.Sleep(200);
			if (Bwm.aWR)
			{
				Bwq = BwP.l(3);
			}
			else
			{
				Bwq = BwP.l(0);
			}
			C();
		}
	}

	private void a(object P_0, RunWorkerCompletedEventArgs P_1)
	{
		((Control)BwW).Enabled = Bwm.C();
		Bwm.A(0L);
	}
}
