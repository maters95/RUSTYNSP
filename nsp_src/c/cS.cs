using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using RestSharp;
using a;
using b;

namespace c
{
	internal class cS : aj
	{
		private new delegate void A(object P_0, EventArgs P_1);

		private new delegate void a(object P_0, EventArgs P_1);

		private Setting Bmd;

		private Setting BmE;

		private aI Bme = new aI();

		private Label BmF = new Label();

		internal cS(DataIdAndAttrId P_0, Framework P_1, Framework P_2)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			A(P_0, P_1, P_2);
		}

		private void A(DataIdAndAttrId P_0, Framework P_1, Framework P_2)
		{
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Expected O, but got Unknown
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Expected O, but got Unknown
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f4: Expected O, but got Unknown
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_0343: Expected O, but got Unknown
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_035b: Expected O, but got Unknown
			//IL_0369: Unknown result type (might be due to invalid IL or missing references)
			//IL_0373: Expected O, but got Unknown
			//IL_037c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Expected O, but got Unknown
			A(P_1, P_2);
			Bme.A(iB);
			A(P_0);
			Bmd = iB.A(ic.ax());
			if (ib != null && iD != null)
			{
				BmE = ib.A(iD.ax());
			}
			C();
			bool flag = c();
			List<Control> val = new List<Control>();
			BM.QQ.B(new EventHandler(b));
			((Control)this).SuspendLayout();
			bool flag2 = BM.QO == BM.b.BpF && (iF || @if);
			if (flag || flag2)
			{
				if (flag2)
				{
					((Control)BmF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bch() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
				}
				else
				{
					((Control)BmF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)ic).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO();
				}
				((Control)BmF).ForeColor = BM.te;
				((Control)BmF).Left = 0;
				((Control)BmF).Top = 2;
				((Control)BmF).AutoSize = true;
				val.Add((Control)(object)BmF);
				if (!((Control)this).Controls.Contains((Control)(object)BmF))
				{
					((Control)this).Controls.Add((Control)(object)BmF);
				}
				((Control)this).AutoSize = false;
				((Control)this).Height = 18;
				((Control)this).Width = ((Control)BmF).Width;
			}
			else
			{
				ic.A(new EventHandler(c));
				((SettingOrSpecialObject)ic).A(new EventHandler(D));
				Bme.A(new EventHandler(C));
				if (BM.QO == BM.b.BpG)
				{
					if (BmE == null)
					{
						Bme.A(0);
					}
					else
					{
						Bme.A(BmE.A());
					}
				}
				else if (Bmd == null)
				{
					Bme.A(0);
				}
				else
				{
					Bme.A(Bmd.A());
				}
				((Control)Bme).Left = 0;
				((Control)Bme).Top = 0;
				val.Add((Control)(object)Bme);
				if (!((Control)this).Controls.Contains((Control)(object)Bme))
				{
					((Control)this).Controls.Add((Control)(object)Bme);
				}
				((Control)iG).Tag = ic;
				((Control)iG).Width = 18;
				((Control)iG).Height = 18;
				((Control)iG).Left = ((Control)Bme).Right;
				((Control)iG).Top = 1;
				iG.SizeMode = (PictureBoxSizeMode)1;
				((Control)iG).Click += new EventHandler(B);
				val.Add((Control)(object)iG);
				if (!((Control)this).Controls.Contains((Control)(object)iG))
				{
					((Control)this).Controls.Add((Control)(object)iG);
				}
				((Control)iG).Visible = false;
				((Control)this).MouseEnter += new EventHandler(((aj)this).A);
				((Control)Bme).MouseEnter += new EventHandler(((aj)this).A);
				((Control)iG).MouseEnter += new EventHandler(((aj)this).A);
				((Control)this).MouseLeave += new EventHandler(((aj)this).a);
			}
			for (int num = ((ArrangedElementCollection)((Control)this).Controls).Count - 1; num >= 0; num--)
			{
				if (!val.Contains(((Control)this).Controls[num]))
				{
					((Control)this).Controls.RemoveAt(num);
				}
			}
			b();
			if (!flag && !flag2)
			{
				((Control)this).AutoSize = false;
				((Control)this).Height = ((Control)Bme).Height;
				((Control)this).Width = ((Control)iG).Right;
			}
			((Control)this).ResumeLayout(true);
		}

		private new void b()
		{
			if (BM.QO != BM.b.BpG && ((SettingOrSpecialObject)ic).l() && !ic.O())
			{
				switch (ic.P())
				{
				case IllegalitySeverityLevel.Error:
					iG.Image = (Image)(object)GeneralResources.RedError;
					break;
				case IllegalitySeverityLevel.Warning:
					iG.Image = (Image)(object)GeneralResources.YellowWarning;
					break;
				case IllegalitySeverityLevel.ErrorIfOnline:
					if (BM.A(iB.aXc, true))
					{
						iG.Image = (Image)(object)GeneralResources.RedError;
					}
					else
					{
						iG.Image = (Image)(object)GeneralResources.YellowWarning;
					}
					break;
				default:
					iG.Image = (Image)(object)GeneralResources.RedError;
					break;
				}
				((Control)iG).Visible = true;
			}
			else
			{
				((Control)iG).Visible = false;
				iG.Image = (Image)(object)GeneralResources.QuestionMark;
			}
		}

		private new void B(object P_0, EventArgs P_1)
		{
			BM.A(ic, (Control)(object)this);
		}

		private new void b(object P_0, EventArgs P_1)
		{
			if (iF || @if)
			{
				A();
				return;
			}
			if (BM.QO == BM.b.BpG)
			{
				if (BmE == null)
				{
					Bme.A(0);
				}
				else
				{
					Bme.A(BmE.A());
				}
			}
			else if (Bmd == null)
			{
				Bme.A(0);
			}
			else
			{
				Bme.A(Bmd.A());
			}
			b();
		}

		private new void C(object P_0, EventArgs P_1)
		{
			if (BM.QO != BM.b.BpG)
			{
				Ck ck2 = BM.aM();
				ck2?.A(ic.C());
				ic.a(Bme.a(), true);
				if (ic.W() != 0)
				{
					A(ic.W());
				}
				if (((SettingOrSpecialObject)ic).D() is Dk)
				{
					C();
				}
				ck2?.B();
				Bmd = iB.A(Bme.a());
				BM.A(ic.C());
			}
		}

		private void A(int P_0)
		{
			Setting setting = iB.A(Bme.a());
			if (setting == null)
			{
				return;
			}
			Setting setting2 = iB.A(P_0);
			if (setting2 == null || setting2.c() == 0)
			{
				return;
			}
			string text = ((SettingOrSpecialObject)setting).A(bz.aYt);
			if (!string.IsNullOrWhiteSpace(text))
			{
				if (Encoding.GetEncoding(setting2.c()).GetBytes(text).Length > setting2.av()[2])
				{
					text = ((SettingOrSpecialObject)setting).A(bz.aYT);
				}
			}
			else
			{
				text = ((SettingOrSpecialObject)setting).A(bz.aYT);
			}
			if (!string.IsNullOrWhiteSpace(text))
			{
				setting2.A(text, true);
				BM.A(setting2.C());
			}
		}

		private new void C()
		{
			Setting setting = iB.A(Bme.a());
			if (setting == null)
			{
				return;
			}
			Dk dk = ((SettingOrSpecialObject)ic).D() as Dk;
			if (dk.i() != null)
			{
				Setting setting2 = iB.A(new DataIdAndAttrId(setting.A(), 4));
				if (setting2 != null)
				{
					dk.i().a(setting2.ax(), true);
				}
				else
				{
					dk.i().a((setting.aS() << 8) | bS.a(setting.aS()), true);
				}
				BM.A(dk.i().C());
			}
			if (dk.I() != null)
			{
				Setting setting3 = iB.A(new DataIdAndAttrId(setting.A(), 5));
				if (setting3 != null)
				{
					dk.I().a(setting3.ax(), true);
				}
				else
				{
					dk.I().a(bS.D(setting.aS()), true);
				}
				BM.A(dk.I().C());
			}
			if (dk.G() != null)
			{
				Setting setting4 = iB.A(new DataIdAndAttrId(setting.A(), 8));
				if (setting4 != null)
				{
					dk.G().a(setting4.ax(), true);
				}
				else
				{
					dk.G().a(setting.aP(), true);
				}
				BM.A(dk.G().C());
			}
			if (dk.g() != null)
			{
				Setting setting5 = iB.A(new DataIdAndAttrId(setting.A(), 9));
				if (setting5 != null)
				{
					dk.g().a(setting5.ax(), true);
				}
				else
				{
					dk.g().a(setting.ap(), true);
				}
				BM.A(dk.g().C());
			}
			if (dk.H() != null)
			{
				Setting setting6 = iB.A(new DataIdAndAttrId(setting.A(), 6));
				if (setting6 != null)
				{
					dk.H().a(setting6.ax(), true);
				}
				else
				{
					dk.H().a(setting.aQ(), true);
				}
				BM.A(dk.H().C());
			}
			if (dk.h() != null)
			{
				Setting setting7 = iB.A(new DataIdAndAttrId(setting.A(), 7));
				if (setting7 != null)
				{
					dk.h().a(setting7.ax(), true);
				}
				else
				{
					dk.h().a(setting.aq(), true);
				}
				BM.A(dk.h().C());
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
			if (BM.QO != BM.b.BpG)
			{
				int num = ic.ax();
				if (Bme.a() != num)
				{
					Bme.A(num);
				}
				Bmd = iB.A(num);
				b();
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					a a = D;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			b();
		}

		protected override void A()
		{
			c();
			if (((Control)this).Parent != null)
			{
				((Control)this).Parent.SuspendLayout();
			}
			A(iC, iB, ib);
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
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected O, but got Unknown
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			try
			{
				ic.a(new EventHandler(c));
				((SettingOrSpecialObject)ic).a(new EventHandler(D));
				Bme.a(new EventHandler(C));
				((Control)this).MouseEnter -= new EventHandler(((aj)this).A);
				((Control)Bme).MouseEnter -= new EventHandler(((aj)this).A);
				((Control)iG).MouseEnter -= new EventHandler(((aj)this).A);
				((Control)this).MouseLeave -= new EventHandler(((aj)this).a);
				((Control)iG).Click -= new EventHandler(B);
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
			if (BM.SR == iG)
			{
				BM.SR = null;
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
	internal class cs : aj
	{
		private new delegate void A(object P_0, EventArgs P_1);

		private new delegate void a(object P_0, EventArgs P_1);

		private bool Bmf;

		private int BmG;

		private ThemedComboBox Bmg = new ThemedComboBox();

		private Label BmH = new Label();

		private Cn Bmh;

		private bool BmI;

		private int Bmi;

		private bool BmJ;

		internal cs(DataIdAndAttrId P_0, bool P_1, int P_2, Framework P_3, Framework P_4, Cn P_5, bool P_6)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			A(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
		}

		private void A(DataIdAndAttrId P_0, bool P_1, int P_2, Framework P_3, Framework P_4, Cn P_5, bool P_6)
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected O, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected O, but got Unknown
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0301: Unknown result type (might be due to invalid IL or missing references)
			//IL_0306: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Expected O, but got Unknown
			//IL_0372: Unknown result type (might be due to invalid IL or missing references)
			//IL_037c: Expected O, but got Unknown
			//IL_0389: Unknown result type (might be due to invalid IL or missing references)
			//IL_0393: Expected O, but got Unknown
			//IL_042b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0435: Expected O, but got Unknown
			//IL_047a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Expected O, but got Unknown
			//IL_0492: Unknown result type (might be due to invalid IL or missing references)
			//IL_049c: Expected O, but got Unknown
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b4: Expected O, but got Unknown
			//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cc: Expected O, but got Unknown
			//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04df: Expected O, but got Unknown
			Bmf = P_1;
			BmG = P_2;
			A(P_3, P_4);
			A(P_0);
			Bmh = P_5;
			if (Bmh != null)
			{
				BmI = P_6;
				int[] array = Bmh.a(ic);
				int num = (Bmf ? BmG : 0);
				if (array != null && array.Length > num)
				{
					Bmi = array[num];
				}
				else
				{
					Bmh = null;
				}
			}
			C();
			bool flag = c();
			List<Control> val = new List<Control>();
			BM.QQ.B(new EventHandler(C));
			ic.A(new EventHandler(D));
			((SettingOrSpecialObject)ic).A(new EventHandler(c));
			Enumerator<Setting> enumerator = ic.BC().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.A(new EventHandler(c));
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			((Control)this).SuspendLayout();
			bool flag2 = BM.QO == BM.b.BpF && (iF || @if) && ib != null;
			if (flag || flag2)
			{
				((Control)BmH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcI();
				((Control)BmH).ForeColor = BM.te;
				((Control)BmH).Left = 0;
				((Control)BmH).Top = 2;
				((Control)BmH).AutoSize = true;
				val.Add((Control)(object)BmH);
				if (!((Control)this).Controls.Contains((Control)(object)BmH))
				{
					((Control)this).Controls.Add((Control)(object)BmH);
				}
				((Control)this).AutoSize = false;
				((Control)this).Height = ((Control)Bmg).Height;
				((Control)this).Width = 170;
			}
			else
			{
				int selectedIndex = -1;
				int num2 = 0;
				Setting setting = ((BM.QO != BM.b.BpG || iD == null) ? ic : iD);
				int num3 = (Bmf ? BmG : 0);
				List<Setting.ListItems.A> val2 = setting.d(num3);
				((ComboBox)Bmg).Items.Clear();
				for (int i = 0; i < val2.Count; i++)
				{
					string text = setting.a(val2[i].bBv, num3);
					((ComboBox)Bmg).Items.Add((object)text);
					if (Bmf)
					{
						if (val2[i].bBv == setting.m(BmG))
						{
							selectedIndex = i;
						}
					}
					else if (val2[i].bBv == setting.ax())
					{
						selectedIndex = i;
					}
					if (text.Length > num2)
					{
						num2 = text.Length;
					}
				}
				((Control)Bmg).Font = new Font(((Control)Bmg).Font.FontFamily, 8.25f, ((Control)Bmg).Font.Style);
				((ListControl)Bmg).SelectedIndex = selectedIndex;
				((ComboBox)Bmg).DropDownStyle = (ComboBoxStyle)2;
				((Control)Bmg).Left = 0;
				((Control)Bmg).Top = 0;
				if (num2 >= 7)
				{
					((Control)Bmg).Width = 170;
				}
				else
				{
					((Control)Bmg).Width = 70;
				}
				((Control)Bmg).GotFocus += new EventHandler(b);
				((ComboBox)Bmg).SelectedIndexChanged += new EventHandler(d);
				val.Add((Control)(object)Bmg);
				if (!((Control)this).Controls.Contains((Control)(object)Bmg))
				{
					((Control)this).Controls.Add((Control)(object)Bmg);
				}
				((Control)iG).Tag = ic;
				((Control)iG).Width = 18;
				((Control)iG).Height = 18;
				((Control)iG).Left = ((Control)Bmg).Right + 5;
				((Control)iG).Top = 1;
				iG.SizeMode = (PictureBoxSizeMode)1;
				((Control)iG).Click += new EventHandler(B);
				val.Add((Control)(object)iG);
				if (!((Control)this).Controls.Contains((Control)(object)iG))
				{
					((Control)this).Controls.Add((Control)(object)iG);
				}
				((Control)iG).Visible = false;
				((Control)this).MouseEnter += new EventHandler(A);
				((Control)Bmg).MouseEnter += new EventHandler(A);
				((Control)iG).MouseEnter += new EventHandler(A);
				((Control)Bmg).MouseLeave += new EventHandler(a);
				((Control)this).MouseLeave += new EventHandler(a);
				((Control)this).AutoSize = false;
				((Control)this).Height = ((Control)Bmg).Height;
				((Control)this).Width = ((Control)iG).Right;
			}
			for (int num4 = ((ArrangedElementCollection)((Control)this).Controls).Count - 1; num4 >= 0; num4--)
			{
				if (!val.Contains(((Control)this).Controls[num4]))
				{
					((Control)this).Controls.RemoveAt(num4);
				}
			}
			C();
			D();
			((Control)this).ResumeLayout(true);
		}

		[SpecialName]
		internal new ThemedComboBox b()
		{
			return Bmg;
		}

		protected override void A(object P_0, EventArgs P_1)
		{
			if (BM.SR != iG)
			{
				if (!BM.Sr && BM.SR != null)
				{
					((Control)BM.SR).Visible = false;
				}
				bool flag = ((!Bmf) ? ((SettingOrSpecialObject)ic).l() : ic.q()[0, 0, BmG]);
				BM.Sr = flag && !ic.O();
				BM.SR = iG;
			}
			((Control)iG).Visible = true;
		}

		protected override void a(object P_0, EventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			Rectangle clientRectangle = ((Control)this).ClientRectangle;
			if (!((Rectangle)(ref clientRectangle)).Contains(((Control)this).PointToClient(Cursor.Position)))
			{
				bool flag = ((!Bmf) ? ((SettingOrSpecialObject)ic).l() : ic.q()[0, 0, BmG]);
				((Control)iG).Visible = iG.Image != null && flag && !ic.O();
			}
		}

		private new void C()
		{
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			bool enabled = iB.C() && (BM.QO != BM.b.BpG || iD == null) && ((!Bmf) ? ((SettingOrSpecialObject)ic).l() : ic.q()[0, 0, BmG]);
			((Control)Bmg).Enabled = enabled;
			if (((Control)Bmg).Enabled && !ic.O())
			{
				switch (ic.P())
				{
				case IllegalitySeverityLevel.Error:
					((Control)Bmg).BackColor = Color.Red;
					iG.Image = (Image)(object)GeneralResources.RedError;
					break;
				case IllegalitySeverityLevel.Warning:
					((Control)Bmg).BackColor = Color.Orange;
					iG.Image = (Image)(object)GeneralResources.YellowWarning;
					break;
				case IllegalitySeverityLevel.ErrorIfOnline:
					if (BM.A(iB.aXc, true))
					{
						((Control)Bmg).BackColor = Color.Red;
						iG.Image = (Image)(object)GeneralResources.RedError;
					}
					else
					{
						((Control)Bmg).BackColor = Color.Orange;
						iG.Image = (Image)(object)GeneralResources.YellowWarning;
					}
					break;
				default:
					((Control)Bmg).BackColor = Color.Red;
					iG.Image = (Image)(object)GeneralResources.RedError;
					break;
				}
				((Control)iG).Visible = true;
			}
			else
			{
				bool flag = iF || @if;
				if (iD != null && !flag && !ic.A(iD, BmG))
				{
					((Control)Bmg).BackColor = BM.tD;
				}
				else if (((Control)Bmg).Enabled)
				{
					((Control)Bmg).BackColor = BM.to;
				}
				else
				{
					((Control)Bmg).BackColor = BM.tQ;
				}
				((Control)iG).Visible = false;
				iG.Image = (Image)(object)GeneralResources.QuestionMark;
			}
			((Control)this).TabStop = ((Control)Bmg).Enabled;
			((Control)Bmg).TabStop = ((Control)this).TabStop;
			((Control)Bmg).Invalidate();
		}

		private new void B(object P_0, EventArgs P_1)
		{
			BM.A(ic, BmG, (Control)(object)this);
		}

		private new void b(object P_0, EventArgs P_1)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			BM.QQ.rL.A(ic);
			if (ib != null && ((Control)Bmg).BackColor == BM.tD)
			{
				BM.A(ic, BmG, (Control)(object)this);
			}
		}

		private new void C(object P_0, EventArgs P_1)
		{
			if (iF || @if)
			{
				A();
				return;
			}
			c();
			C();
		}

		private new void c()
		{
			Setting setting = ((BM.QO != BM.b.BpG || iD == null) ? ic : iD);
			List<Setting.ListItems.A> val = setting.d(Bmf ? BmG : 0);
			int num = -1;
			for (int i = 0; i < val.Count; i++)
			{
				if (Bmf)
				{
					if (val[i].bBv == setting.m(BmG))
					{
						num = i;
					}
				}
				else if (val[i].bBv == setting.ax())
				{
					num = i;
				}
			}
			if (((ListControl)Bmg).SelectedIndex != num)
			{
				((ListControl)Bmg).SelectedIndex = num;
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
			C();
		}

		private void D(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					a a = D;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			D();
			if (BM.QO != BM.b.BpG)
			{
				c();
				if (iD != null)
				{
					C();
				}
			}
		}

		private void D()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			FontStyle val = (FontStyle)0;
			if (Bmh != null && BmI)
			{
				Setting setting = ((BM.QO != BM.b.BpG || iD == null) ? ic : iD);
				if (Bmf)
				{
					if (setting.m(BmG) != Bmi)
					{
						val = (FontStyle)2;
					}
				}
				else if (setting.ax() != Bmi)
				{
					val = (FontStyle)2;
				}
			}
			if (((Control)Bmg).Font.Style != val)
			{
				Font font = ((Control)Bmg).Font;
				((Control)Bmg).Font = new Font(((Control)Bmg).Font.FontFamily, ((Control)Bmg).Font.Size, val);
				font.Dispose();
			}
		}

		private void d(object P_0, EventArgs P_1)
		{
			if (BM.QO == BM.b.BpG)
			{
				return;
			}
			if (BM.QP)
			{
				BM.A(ic.C());
				return;
			}
			if (BmJ)
			{
				BmJ = false;
				return;
			}
			List<Setting.ListItems.A> val = ic.d(Bmf ? BmG : 0);
			int selectedIndex = ((ListControl)Bmg).SelectedIndex;
			if (selectedIndex != -1 && ((SettingOrSpecialObject)ic).j())
			{
				if (Bmf)
				{
					if (ic.m(BmG) == val[selectedIndex].bBv)
					{
						return;
					}
				}
				else if (ic.ax() == val[selectedIndex].bBv)
				{
					return;
				}
				Ck ck2 = BM.aM();
				ck2?.A(ic.C());
				if (Bmf)
				{
					ic.a(BmG, val[selectedIndex].bBv, true);
				}
				else
				{
					ic.a(val[selectedIndex].bBv, true);
				}
				ck2?.B();
				BM.A(ic.C());
				return;
			}
			for (int i = 0; i < val.Count; i++)
			{
				if (Bmf)
				{
					if (val[i].bBv == ic.m(BmG))
					{
						BmJ = true;
						((ListControl)Bmg).SelectedIndex = i;
						break;
					}
				}
				else if (val[i].bBv == ic.ax())
				{
					BmJ = true;
					((ListControl)Bmg).SelectedIndex = i;
					break;
				}
			}
		}

		protected override void A()
		{
			d();
			if (((Control)this).Parent != null)
			{
				((Control)this).Parent.SuspendLayout();
			}
			A(iC, Bmf, BmG, iB, ib, Bmh, BmI);
			if (((Control)this).Parent != null)
			{
				((Control)this).Parent.ResumeLayout(true);
			}
		}

		protected override void B()
		{
			Ck ck2 = BM.aM();
			ck2?.A(ic.C());
			if (Bmf)
			{
				ic.A(BmG, true);
			}
			else
			{
				ic.I(true);
			}
			ck2?.B();
			BM.A(ic.C());
		}

		private void d()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected O, but got Unknown
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected O, but got Unknown
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected O, but got Unknown
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected O, but got Unknown
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Expected O, but got Unknown
			try
			{
				((ComboBox)Bmg).SelectedIndexChanged -= new EventHandler(d);
				((Control)Bmg).GotFocus -= new EventHandler(b);
				((Control)this).MouseEnter -= new EventHandler(A);
				((Control)Bmg).MouseEnter -= new EventHandler(A);
				((Control)iG).MouseEnter -= new EventHandler(A);
				((Control)Bmg).MouseLeave -= new EventHandler(a);
				((Control)this).MouseLeave -= new EventHandler(a);
				((Control)iG).Click -= new EventHandler(B);
				ic.a(new EventHandler(D));
				Enumerator<Setting> enumerator = ic.BC().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.a(new EventHandler(c));
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				((SettingOrSpecialObject)ic).a(new EventHandler(c));
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
			d();
			if (BM.SR == iG)
			{
				BM.SR = null;
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
	internal class CS
	{
		internal delegate void A(string P_0);

		private int Bcr;

		private List<FileInfo> BcS = new List<FileInfo>();

		private ToolStripMenuItem Bcs;

		private ToolStripMenuItem[] BcT;

		[CompilerGenerated]
		private A Bct;

		[SpecialName]
		[CompilerGenerated]
		internal void A(A P_0)
		{
			A a = Bct;
			A a2;
			do
			{
				a2 = a;
				A a3 = (A)System.Delegate.Combine((System.Delegate)a2, (System.Delegate)P_0);
				a = Interlocked.CompareExchange<A>(ref Bct, a3, a2);
			}
			while (a != a2);
		}

		[SpecialName]
		[CompilerGenerated]
		internal void a(A P_0)
		{
			A a = Bct;
			A a2;
			do
			{
				a2 = a;
				A a3 = (A)System.Delegate.Remove((System.Delegate)a2, (System.Delegate)P_0);
				a = Interlocked.CompareExchange<A>(ref Bct, a3, a2);
			}
			while (a != a2);
		}

		internal CS(ToolStripMenuItem P_0, int P_1)
		{
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			Bcs = P_0;
			Bcr = P_1;
			BcT = (ToolStripMenuItem[])(object)new ToolStripMenuItem[Bcr + 1];
			for (int i = 0; i < Bcr; i++)
			{
				BcT[i] = new ToolStripMenuItem();
				((ToolStripItem)BcT[i]).Visible = false;
				((ToolStripDropDownItem)Bcs).DropDownItems.Add((ToolStripItem)(object)BcT[i]);
			}
			a();
			A();
		}

		private void A()
		{
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			for (int i = 0; i < BcS.Count; i++)
			{
				((ToolStripItem)BcT[i]).Text = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXc(), (object)(i + 1), (object)((FileSystemInfo)BcS[i]).Name);
				((ToolStripItem)BcT[i]).Visible = true;
				((ToolStripItem)BcT[i]).Tag = BcS[i];
				((ToolStripItem)BcT[i]).Click -= new EventHandler(A);
				((ToolStripItem)BcT[i]).Click += new EventHandler(A);
			}
			for (int j = BcS.Count; j < Bcr; j++)
			{
				((ToolStripItem)BcT[j]).Visible = false;
				((ToolStripItem)BcT[j]).Click -= new EventHandler(A);
			}
		}

		internal void A(string P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			try
			{
				a(P_0);
				BcS.Insert(0, new FileInfo(P_0));
				if (BcS.Count > Bcr)
				{
					BcS.RemoveAt(Bcr);
				}
				A();
				B();
			}
			catch
			{
			}
		}

		private void a(string P_0)
		{
			for (int num = BcS.Count - 1; num >= 0; num--)
			{
				if (((FileSystemInfo)BcS[num]).FullName == P_0)
				{
					BcS.RemoveAt(num);
				}
			}
		}

		internal void B(string P_0)
		{
			a(P_0);
			A();
			B();
		}

		private void a()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			if (!File.Exists(BM.QT))
			{
				return;
			}
			StreamReader val = File.OpenText(BM.QT);
			try
			{
				string text;
				while ((text = ((TextReader)val).ReadLine()) != null)
				{
					FileInfo val2 = null;
					try
					{
						val2 = new FileInfo(text);
					}
					catch
					{
						val2 = null;
					}
					if (val2 != null)
					{
						BcS.Add(val2);
					}
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}

		internal void B()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			if (BcS.Count == 0)
			{
				return;
			}
			if (!Directory.Exists(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
			{
				Directory.CreateDirectory(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
			}
			((Stream)File.Create(BM.QT)).Close();
			List<string> val = new List<string>();
			Enumerator<FileInfo> enumerator = BcS.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					FileInfo current = enumerator.Current;
					val.Add(((FileSystemInfo)current).FullName);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			File.AppendAllLines(BM.QT, (System.Collections.Generic.IEnumerable<string>)val);
		}

		private void A(object P_0, EventArgs P_1)
		{
			if (Bct != null)
			{
				object tag = ((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
				FileInfo val = (FileInfo)((tag is FileInfo) ? tag : null);
				Bct(((FileSystemInfo)val).FullName);
			}
		}
	}
	internal class Cs
	{
		private readonly string BcU = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXT();

		private readonly string Bcu = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXt();

		private const string BcV = "rmmus-haltech.screenconnect.com";

		private const string Bcv = "https://rmmus-haltech.screenconnect.com";

		private const string BcW = "http://rmmus-haltech.screenconnect.com";

		private const string Bcw = "ScreenConnect.Client";

		internal string BcX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXU();

		internal string Bcx = string.Empty;

		internal bool BcY;

		private string Bcy = string.Empty;

		private Bu BcZ;

		private const int Bcz = 60;

		internal bool A(Bu P_0)
		{
			BcZ = P_0;
			BcZ.WG.Value = 0;
			string text = A();
			string text2 = A(text);
			bool result = false;
			if (!string.IsNullOrEmpty(text2))
			{
				result = A(text2, BcX, !string.IsNullOrEmpty(text));
			}
			return result;
		}

		private string A(string P_0)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			Random val = new Random();
			string result = string.Empty;
			string text = string.Empty;
			Bcx = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXD();
			BcZ.a();
			BcY = !string.IsNullOrEmpty(P_0);
			try
			{
				text = val.Next(1, 999).ToString().PadLeft(3, '0');
				RestClient val2 = ((!BcY) ? new RestClient(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXe() + BcU + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXE(), (ConfigureRestClient)null, (ConfigureHeaders)null, (ConfigureSerialization)null) : new RestClient(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXd() + BcU + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXE(), (ConfigureRestClient)null, (ConfigureHeaders)null, (ConfigureSerialization)null));
				RestRequest val3 = new RestRequest();
				val3.Method = (Method)1;
				if (BcY)
				{
					RestRequestExtensions.AddHeader(val3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXF(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXf());
					RestRequestExtensions.AddHeader(val3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXG(), P_0);
				}
				else
				{
					RestRequestExtensions.AddHeader(val3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXF(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXg());
				}
				RestRequestExtensions.AddParameter(val3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXg(), (object)(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXH() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXh()), (ParameterType)3, true);
				result = ((RestResponseBase)RestClientExtensions.Execute((IRestClient)(object)val2, val3)).Content.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
				Bcx = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXI();
				BcZ.WG.Value = 50;
				BcZ.a();
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXi() + ex.Message, true);
				((Form)BcZ).Close();
			}
			BcX = text;
			return result;
		}

		private string A()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Invalid comparison between Unknown and I4
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			HttpWebRequest val = (HttpWebRequest)WebRequest.Create(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXJ());
			try
			{
				HttpWebResponse val2 = (HttpWebResponse)((WebRequest)val).GetResponse();
				if ((int)val2.StatusCode == 200)
				{
					Stream responseStream = ((WebResponse)val2).GetResponseStream();
					StreamReader val3 = null;
					val3 = ((val2.CharacterSet != null) ? new StreamReader(responseStream, Encoding.GetEncoding(val2.CharacterSet)) : new StreamReader(responseStream));
					string text = string.Empty;
					string text2;
					while ((text2 = ((TextReader)val3).ReadLine()) != null)
					{
						if (text2.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXj()))
						{
							text = text2;
							break;
						}
					}
					((WebResponse)val2).Close();
					((TextReader)val3).Close();
					if (!string.IsNullOrEmpty(text))
					{
						string[] array = text.Split(',', (StringSplitOptions)0);
						string text3 = string.Empty;
						string[] array2 = array;
						foreach (string text4 in array2)
						{
							if (text4.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXj()))
							{
								text3 = text4;
								break;
							}
						}
						return text3.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXj().Length + 1, text3.Length - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXj().Length - 2);
					}
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXK() + ex.Message, true);
			}
			return string.Empty;
		}

		private bool A(string P_0, string P_1, bool P_2)
		{
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected O, but got Unknown
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			Bcx = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXk();
			BcZ.a();
			if (!C())
			{
				return false;
			}
			string text = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DV();
			string text2 = c();
			Bcy = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXL() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXl();
			Uri val = ((!P_2) ? new Uri(string.Concat(new string[6]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXn(),
				Bcu,
				P_0,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXm(),
				P_1,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXN()
			})) : new Uri(string.Concat(new string[6]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXM(),
				Bcu,
				P_0,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXm(),
				P_1,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXN()
			})));
			try
			{
				WebClient val2 = new WebClient();
				val2.DownloadFileCompleted += new AsyncCompletedEventHandler(A);
				val2.DownloadProgressChanged += new DownloadProgressChangedEventHandler(A);
				val2.DownloadFileAsync(val, Bcy);
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXO() + ex.Message, true);
				((Form)BcZ).Close();
			}
			return true;
		}

		private void A(object P_0, DownloadProgressChangedEventArgs P_1)
		{
			BcZ.WG.Value = 50 + (int)((float)((ProgressChangedEventArgs)P_1).ProgressPercentage / 100f * 50f);
		}

		private void A(object P_0, AsyncCompletedEventArgs P_1)
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			Bcx = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXo();
			BcZ.a();
			if (!File.Exists(Bcy))
			{
				((Form)BcZ).Close();
			}
			ProcessStartInfo val = new ProcessStartInfo();
			val.CreateNoWindow = false;
			val.UseShellExecute = false;
			val.FileName = Bcy;
			val.WindowStyle = (ProcessWindowStyle)0;
			try
			{
				Process obj = Process.Start(val);
				obj.EnableRaisingEvents = true;
				obj.Exited += new EventHandler(A);
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXP() + ex.Message, true);
				((Form)BcZ).Close();
			}
			int num = 60;
			while (num > 0)
			{
				if (b())
				{
					Bcx = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXp();
					BcZ.a();
					BcZ.A(false);
					return;
				}
				num--;
				Thread.Sleep(1000);
			}
			Bcx = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXQ();
			BcZ.a();
			BcZ.A(false);
			Thread.Sleep(1000);
			((Form)BcZ).Close();
		}

		private void A(object P_0, EventArgs P_1)
		{
			C();
		}

		internal static bool a()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			try
			{
				WebClient val = new WebClient();
				try
				{
					Stream val2 = val.OpenRead(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXq());
					try
					{
						return true;
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
			catch
			{
				return false;
			}
		}

		internal static bool B()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			try
			{
				WebClient val = new WebClient();
				try
				{
					Stream val2 = val.OpenRead(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXR());
					try
					{
						return true;
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
			catch
			{
				return false;
			}
		}

		internal static bool b()
		{
			return Process.GetProcessesByName(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXr()).Length != 0;
		}

		internal static bool C()
		{
			string text = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DV();
			try
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXS() + ex.Message, true);
				return false;
			}
			string[] files = Directory.GetFiles(text);
			foreach (string text2 in files)
			{
				if (text2.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXL()) && text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXl()))
				{
					try
					{
						File.Delete(text2);
					}
					catch (System.Exception ex2)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXS() + ex2.Message, true);
					}
				}
			}
			return true;
		}

		private string c()
		{
			string[] files = Directory.GetFiles(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DV());
			int num = 0;
			string[] array = files;
			foreach (string text in array)
			{
				if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXL()) && text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXl()))
				{
					num++;
				}
			}
			if (num == 0)
			{
				return string.Empty;
			}
			return (num + 1).ToString();
		}

		internal void D()
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXr());
				foreach (Process obj in processesByName)
				{
					obj.Kill();
					obj.WaitForExit();
					((Component)obj).Dispose();
				}
				processesByName = Process.GetProcessesByName(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXs());
				foreach (Process obj2 in processesByName)
				{
					obj2.Kill();
					obj2.WaitForExit();
					((Component)obj2).Dispose();
				}
			}
			catch
			{
			}
		}
	}
}
