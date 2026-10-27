using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Resources;
using System.Runtime.CompilerServices;
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
using a;
using b;

namespace c
{
	internal class cX : BB
	{
		[CompilerGenerated]
		private static EventHandler BPJ;

		private IContainer BPj;

		private PictureBox BPK;

		private ThemedTextBox BPk;

		private ThemedButton BPL;

		private Label BPl;

		private ThemedComboBox BPM;

		private Label BPm;

		private ThemedComboBox BPN;

		private ThemedButton BPn;

		private ThemedButton BPO;

		private ThemedButton BPo;

		private Label BPP;

		private ThemedComboBox BPp;

		private ThemedButton BPQ;

		private ThemedButton BPq;

		private Timer BPR;

		internal cX(Dn P_0)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f3: Expected O, but got Unknown
			//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0404: Expected O, but got Unknown
			//IL_042a: Unknown result type (might be due to invalid IL or missing references)
			//IL_042f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0481: Unknown result type (might be due to invalid IL or missing references)
			//IL_0486: Unknown result type (might be due to invalid IL or missing references)
			//IL_0498: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a2: Expected O, but got Unknown
			mQ = true;
			a();
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			mq = P_0;
			uint num = (uint)P_0.ax();
			mz = PortFunction.A(num);
			NA = PortFunction.a(num);
			if (mz == Cg.BAM)
			{
				Na = 0;
				NB = PortFunction.b(num);
			}
			else
			{
				Na = PortFunction.B(num);
				NB = 0;
			}
			((Control)BPK).BackColor = ((Control)this).BackColor;
			if (BPK.Image != null)
			{
				BPK.Image.Dispose();
			}
			BPK.Image = (Image)(object)O.A((Image)(object)GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
			((Control)BPk).BackColor = BM.to;
			((Control)BPk).ForeColor = BM.te;
			BPk.A(A);
			Rectangle clientRectangle;
			if (BM.Qz.awC.Count != 0)
			{
				mr = new Bb(this);
				((Panel)mr).BorderStyle = (BorderStyle)1;
				((Control)mr).BackColor = BM.tG;
				((Control)mr).Left = 10;
				Bb bb = mr;
				clientRectangle = ((Control)this).ClientRectangle;
				((Control)bb).Width = ((Rectangle)(ref clientRectangle)).Width - 20;
				((Control)mr).Top = ((Control)BPo).Bottom + 7;
				((Control)this).Controls.Add((Control)(object)mr);
			}
			((Panel)mS).BorderStyle = (BorderStyle)1;
			((Control)mS).BackColor = BM.tG;
			((Control)mS).Left = 10;
			aF aF = mS;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)aF).Width = ((Rectangle)(ref clientRectangle)).Width - 20;
			if (BM.Qz.awC.Count != 0)
			{
				((Control)mS).Top = ((Control)mr).Top + ((Control)mr).Height + 7;
			}
			else
			{
				((Control)mS).Top = ((Control)BPo).Bottom + 7;
			}
			((Control)mS).Height = ((Control)BPq).Top - 10 - ((Control)mS).Top;
			((Control)this).Controls.Add((Control)(object)mS);
			((ComboBox)BPM).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDm());
			Cg[] array = PortFunction.A();
			foreach (Cg cg2 in array)
			{
				((ComboBox)BPM).Items.Add((object)PortFunction.B(cg2, BM.Qz));
			}
			((ListControl)BPM).SelectedIndex = 0;
			((ComboBox)BPN).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDN());
			CH[] array2 = PortFunction.a();
			foreach (CH cH2 in array2)
			{
				((ComboBox)BPN).Items.Add((object)PortFunction.A(cH2));
			}
			((ListControl)BPN).SelectedIndex = 0;
			ObjectCollection items = ((ComboBox)BPp).Items;
			object[] array3 = new string[2]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDn(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDO()
			};
			items.AddRange(array3);
			((ListControl)BPp).SelectedIndex = (int)BB.Nc;
			((Control)BPP).Visible = (((Control)BPp).Visible = BM.Qz.awe);
			global::A.A.A((global::A.D)base.a);
			BM.D(new EventHandler(base.a));
			BM.C(new EventHandler(F));
			a();
			BB.NE = this;
			Nd = new Ck(BM.Qz);
			Enumerator<WiringPin> enumerator2 = BM.Qz.awc.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					WiringPin current = enumerator2.Current;
					if (current.e())
					{
						NC.Add(BM.Qz.A(current.Bbx));
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			Enumerator<Setting> enumerator3 = NC.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					enumerator3.Current.A(new EventHandler(base.b));
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			mR = false;
		}

		private new void a(object P_0, EventArgs P_1)
		{
			d();
		}

		private new void B(object P_0, EventArgs P_1)
		{
			E();
		}

		private new void b(object P_0, EventArgs P_1)
		{
			e();
		}

		private void C(object P_0, EventArgs P_1)
		{
			if (!mR)
			{
				base.A(((ListControl)BPM).SelectedIndex == 0, ((Control)BPM).Text);
			}
		}

		private void c(object P_0, EventArgs P_1)
		{
			if (!mR)
			{
				base.a(((ListControl)BPN).SelectedIndex == 0, ((Control)BPN).Text);
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			if (!mR && ((ListControl)BPp).SelectedIndex != -1)
			{
				base.A((A)((ListControl)BPp).SelectedIndex);
			}
		}

		private void d(object P_0, EventArgs P_1)
		{
			BPR.Stop();
			BPR.Start();
		}

		private void A(object P_0, ThemedTextBox.B P_1)
		{
			BPR.Stop();
			BPR.Start();
		}

		private void E(object P_0, EventArgs P_1)
		{
			BPR.Stop();
			a();
		}

		private void e(object P_0, EventArgs P_1)
		{
			((Control)BPk).Text = string.Empty;
		}

		internal override string A()
		{
			return ((Control)BPk).Text;
		}

		protected override void A(object P_0, EventArgs P_1)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			A(P_0, (MouseEventArgs)P_1);
			((Button)BPq).PerformClick();
		}

		private void F(object P_0, EventArgs P_1)
		{
			((Form)this).DialogResult = (DialogResult)2;
			((Form)this).Close();
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void A(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = BPJ;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BPJ, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void a(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = BPJ;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BPJ, val3, val2);
			}
			while (val != val2);
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected O, but got Unknown
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected O, but got Unknown
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Expected O, but got Unknown
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected O, but got Unknown
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Invalid comparison between Unknown and I4
			BB.NE = null;
			foreach (Control item in (ArrangedElementCollection)((Control)mS).Controls)
			{
				item.MouseClick -= new MouseEventHandler(base.A);
				item.DoubleClick -= new EventHandler(((BB)this).A);
				foreach (Control item2 in (ArrangedElementCollection)item.Controls)
				{
					item2.MouseClick -= new MouseEventHandler(base.A);
					item2.DoubleClick -= new EventHandler(((BB)this).A);
					item2.MouseClick -= new MouseEventHandler(base.a);
				}
			}
			global::A.A.a((global::A.D)base.a);
			BM.d(new EventHandler(base.a));
			BM.c(new EventHandler(F));
			Enumerator<Label> enumerator3 = mT.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					SettingOrSpecialObject bOR = ((a)((Control)enumerator3.Current).Tag).BOR;
					for (int i = 0; i < bOR.F().b().Count; i++)
					{
						bOR.F().b()[i].a(new EventHandler(base.B));
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			Enumerator<Setting> enumerator4 = NC.GetEnumerator();
			try
			{
				while (enumerator4.MoveNext())
				{
					enumerator4.Current.a(new EventHandler(base.b));
				}
			}
			finally
			{
				((System.IDisposable)enumerator4).Dispose();
			}
			NC.Clear();
			if (Ne.IsRunning)
			{
				Ne.Stop();
			}
			if (BPJ != null)
			{
				BPJ.Invoke((object)this, (EventArgs)null);
			}
			if ((int)((Form)this).DialogResult != 1)
			{
				return;
			}
			Ck ck2 = BM.aM();
			ck2?.A(((Setting)mq).A());
			List<Setting> val3 = new List<Setting>();
			PortFunction.A(mq, val3, false);
			List<Table> val4 = new List<Table>();
			PortFunction.A(mq, val4, false);
			if (mz != Cg.BAM)
			{
				int num = mq.ax();
				int num2 = (int)PortFunction.A(mz, NA, Na);
				mq.a(num2, true);
				if (num == 0)
				{
					mq.A();
				}
			}
			else
			{
				mq.a((int)PortFunction.A(mz, NA, NB), true);
			}
			if (PortFunction.A(BM.Qz, true, mz, NA, Na, NB) == 1)
			{
				PortFunction.A(mq, val3, val4);
			}
			ck2?.B();
			BM.b(((Setting)mq).A());
		}

		private void f(object P_0, EventArgs P_1)
		{
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			((Control)BPq).Left = ((Control)this).Width - 235;
			((Control)BPQ).Left = ((Control)BPq).Right + 9;
			ThemedButton bPq = BPq;
			int top = (((Control)BPQ).Top = ((Control)this).Height - 79);
			((Control)bPq).Top = top;
			((Control)BPP).Top = ((Control)this).Height - 72;
			((Control)BPp).Top = ((Control)this).Height - 76;
			Rectangle clientRectangle;
			if (mr != null)
			{
				Bb bb = mr;
				clientRectangle = ((Control)this).ClientRectangle;
				((Control)bb).Width = ((Rectangle)(ref clientRectangle)).Width - 20;
			}
			aF aF = mS;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)aF).Width = ((Rectangle)(ref clientRectangle)).Width - 20;
			((Control)mS).Height = ((Control)BPq).Top - 10 - ((Control)mS).Top;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && BPj != null)
			{
				((System.IDisposable)BPj).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private new void a()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected O, but got Unknown
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected O, but got Unknown
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Expected O, but got Unknown
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Expected O, but got Unknown
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Expected O, but got Unknown
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_0376: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Expected O, but got Unknown
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Expected O, but got Unknown
			//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03da: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0436: Expected O, but got Unknown
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0482: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04af: Expected O, but got Unknown
			//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cc: Expected O, but got Unknown
			//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_053b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0545: Expected O, but got Unknown
			//IL_0558: Unknown result type (might be due to invalid IL or missing references)
			//IL_0562: Expected O, but got Unknown
			//IL_056e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0592: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05db: Expected O, but got Unknown
			//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f8: Expected O, but got Unknown
			//IL_0604: Unknown result type (might be due to invalid IL or missing references)
			//IL_0628: Unknown result type (might be due to invalid IL or missing references)
			//IL_0667: Unknown result type (might be due to invalid IL or missing references)
			//IL_0671: Expected O, but got Unknown
			//IL_0690: Unknown result type (might be due to invalid IL or missing references)
			//IL_069a: Expected O, but got Unknown
			//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_071c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0726: Expected O, but got Unknown
			//IL_073f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0772: Unknown result type (might be due to invalid IL or missing references)
			//IL_0795: Unknown result type (might be due to invalid IL or missing references)
			//IL_079f: Expected O, but got Unknown
			//IL_07be: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c8: Expected O, but got Unknown
			//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_084e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0858: Expected O, but got Unknown
			//IL_0868: Unknown result type (might be due to invalid IL or missing references)
			//IL_088c: Unknown result type (might be due to invalid IL or missing references)
			//IL_08db: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e5: Expected O, but got Unknown
			//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0924: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a34: Expected O, but got Unknown
			//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a7f: Expected O, but got Unknown
			//IL_0a87: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a91: Expected O, but got Unknown
			BPj = (IContainer)new Container();
			ComponentResourceManager val = new ComponentResourceManager(typeof(cX));
			BPK = new PictureBox();
			BPk = new ThemedTextBox();
			BPL = new ThemedButton();
			BPl = new Label();
			BPM = new ThemedComboBox();
			BPm = new Label();
			BPN = new ThemedComboBox();
			BPn = new ThemedButton();
			BPO = new ThemedButton();
			BPo = new ThemedButton();
			BPP = new Label();
			BPp = new ThemedComboBox();
			BPQ = new ThemedButton();
			BPq = new ThemedButton();
			BPR = new Timer(BPj);
			((ISupportInitialize)BPK).BeginInit();
			((Control)this).SuspendLayout();
			BPK.Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDo());
			((Control)BPK).Location = new Point(7, 7);
			((Control)BPK).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fJ();
			((Control)BPK).Size = new Size(24, 24);
			BPK.TabIndex = 28;
			BPK.TabStop = false;
			((Control)BPk).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPk).Location = new Point(36, 8);
			((Control)BPk).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fi();
			((Control)BPk).Size = new Size(137, 22);
			((Control)BPk).TabIndex = 0;
			((Control)BPk).TextChanged += new EventHandler(d);
			((Control)BPL).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)BPL).Location = new Point(175, 7);
			((Control)BPL).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fj();
			((Control)BPL).Size = new Size(22, 24);
			((Control)BPL).TabIndex = 1;
			((Control)BPL).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Di();
			((ButtonBase)BPL).UseVisualStyleBackColor = true;
			((Control)BPL).Click += new EventHandler(e);
			((Control)BPl).AutoSize = true;
			((Control)BPl).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPl).Location = new Point(211, 11);
			((Control)BPl).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDP();
			((Control)BPl).Size = new Size(48, 13);
			((Control)BPl).TabIndex = 27;
			((Control)BPl).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDp();
			((ComboBox)BPM).DrawMode = (DrawMode)1;
			((ComboBox)BPM).DropDownStyle = (ComboBoxStyle)2;
			((Control)BPM).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((ListControl)BPM).FormattingEnabled = true;
			((Control)BPM).Location = new Point(262, 7);
			((ComboBox)BPM).MaxDropDownItems = 50;
			((Control)BPM).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDQ();
			((Control)BPM).Size = new Size(206, 23);
			((Control)BPM).TabIndex = 2;
			((ComboBox)BPM).SelectedIndexChanged += new EventHandler(C);
			((Control)BPm).AutoSize = true;
			((Control)BPm).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPm).Location = new Point(482, 11);
			((Control)BPm).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDq();
			((Control)BPm).Size = new Size(101, 13);
			((Control)BPm).TabIndex = 26;
			((Control)BPm).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDR();
			((ComboBox)BPN).DrawMode = (DrawMode)1;
			((ComboBox)BPN).DropDownStyle = (ComboBoxStyle)2;
			((Control)BPN).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((ListControl)BPN).FormattingEnabled = true;
			((Control)BPN).Location = new Point(586, 7);
			((ComboBox)BPN).MaxDropDownItems = 50;
			((Control)BPN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDr();
			((Control)BPN).Size = new Size(194, 23);
			((Control)BPN).TabIndex = 3;
			((ComboBox)BPN).SelectedIndexChanged += new EventHandler(c);
			((Control)BPn).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPn).Location = new Point(836, 5);
			((Control)BPn).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDS();
			((Control)BPn).Size = new Size(120, 25);
			((Control)BPn).TabIndex = 4;
			((Control)BPn).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDs();
			((ButtonBase)BPn).UseVisualStyleBackColor = true;
			((Control)BPn).Click += new EventHandler(a);
			((Control)BPO).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPO).Location = new Point(958, 5);
			((Control)BPO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDT();
			((Control)BPO).Size = new Size(120, 25);
			((Control)BPO).TabIndex = 5;
			((Control)BPO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDt();
			((ButtonBase)BPO).UseVisualStyleBackColor = true;
			((Control)BPO).Click += new EventHandler(B);
			((Control)BPo).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPo).Location = new Point(1080, 5);
			((Control)BPo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDU();
			((Control)BPo).Size = new Size(120, 25);
			((Control)BPo).TabIndex = 6;
			((Control)BPo).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDu();
			((ButtonBase)BPo).UseVisualStyleBackColor = true;
			((Control)BPo).Click += new EventHandler(b);
			((Control)BPP).AutoSize = true;
			((Control)BPP).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPP).Location = new Point(7, 570);
			((Control)BPP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDV();
			((Control)BPP).Size = new Size(60, 13);
			((Control)BPP).TabIndex = 26;
			((Control)BPP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDv();
			((ComboBox)BPp).DrawMode = (DrawMode)1;
			((ComboBox)BPp).DropDownStyle = (ComboBoxStyle)2;
			((Control)BPp).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((ListControl)BPp).FormattingEnabled = true;
			((Control)BPp).Location = new Point(55, 566);
			((ComboBox)BPp).MaxDropDownItems = 2;
			((Control)BPp).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDW();
			((Control)BPp).Size = new Size(180, 23);
			((Control)BPp).TabIndex = 7;
			((ComboBox)BPp).SelectedIndexChanged += new EventHandler(D);
			((Button)BPQ).DialogResult = (DialogResult)2;
			((Control)BPQ).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPQ).Location = new Point(1135, 563);
			((Control)BPQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)BPQ).Size = new Size(100, 30);
			((Control)BPQ).TabIndex = 9;
			((Control)BPQ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)BPQ).UseVisualStyleBackColor = true;
			((Button)BPq).DialogResult = (DialogResult)1;
			((Control)BPq).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPq).Location = new Point(1026, 563);
			((Control)BPq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)BPq).Size = new Size(100, 30);
			((Control)BPq).TabIndex = 8;
			((Control)BPq).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)BPq).UseVisualStyleBackColor = true;
			BPR.Interval = 400;
			BPR.Tick += new EventHandler(E);
			((Form)this).AcceptButton = (IButtonControl)(object)BPq;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)BPQ;
			((Form)this).ClientSize = new Size(1245, 604);
			((Control)this).Controls.Add((Control)(object)BPK);
			((Control)this).Controls.Add((Control)(object)BPk);
			((Control)this).Controls.Add((Control)(object)BPL);
			((Control)this).Controls.Add((Control)(object)BPl);
			((Control)this).Controls.Add((Control)(object)BPM);
			((Control)this).Controls.Add((Control)(object)BPm);
			((Control)this).Controls.Add((Control)(object)BPN);
			((Control)this).Controls.Add((Control)(object)BPn);
			((Control)this).Controls.Add((Control)(object)BPO);
			((Control)this).Controls.Add((Control)(object)BPo);
			((Control)this).Controls.Add((Control)(object)BPP);
			((Control)this).Controls.Add((Control)(object)BPp);
			((Control)this).Controls.Add((Control)(object)BPQ);
			((Control)this).Controls.Add((Control)(object)BPq);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDw();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDX();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)this).Resize += new EventHandler(f);
			((ISupportInitialize)BPK).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class cx : BB
	{
		private new class A
		{
			private const int BxW = 295;

			private const int Bxw = 475;

			private cx BxX;

			private int Bxx;

			private int BxY;

			private int Bxy;

			private int BxZ;

			private int Bxz;

			private int BYA;

			private int BYa;

			private int BYB;

			private bool BYb;

			private bool BYC;

			private bool BYc;

			private bool BYD;

			private int BYd;

			private List<Connector> BYE = new List<Connector>();

			private int BYe;

			private bool BYF;

			private bool BYf;

			internal A(cx P_0)
			{
				BxX = P_0;
			}

			internal void A()
			{
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Expected O, but got Unknown
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Expected O, but got Unknown
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Expected O, but got Unknown
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Expected O, but got Unknown
				//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b2: Expected O, but got Unknown
				//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d2: Invalid comparison between Unknown and I4
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				try
				{
					BxY = 1;
					Bxy = 0;
					BxZ = 0;
					Bxz = 0;
					BYA = 0;
					BYa = 0;
					BYB = 0;
					BYb = false;
					BYC = false;
					BYc = false;
					BYD = false;
					BYd = 0;
					BYE.Clear();
					BYe = 0;
					BYF = false;
					BYf = false;
					PrintDialog val = new PrintDialog();
					PrintDocument val2 = new PrintDocument();
					val2.PrintPage += new PrintPageEventHandler(A);
					PageSettings val3 = new PageSettings();
					val3.Landscape = false;
					val3.Margins = new Margins(50, 50, 50, 50);
					val2.DefaultPageSettings = val3;
					val2.PrinterSettings = val.PrinterSettings;
					if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)BxX) == 1)
					{
						val2.Print();
					}
					((Component)val).Dispose();
				}
				catch (System.Exception)
				{
					bE.A((IWin32Window)(object)BxX, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhH(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}

			private void A(object P_0, PrintPageEventArgs P_1)
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Expected O, but got Unknown
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00dc: Expected O, but got Unknown
				//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Unknown result type (might be due to invalid IL or missing references)
				//IL_0205: Unknown result type (might be due to invalid IL or missing references)
				P_1.Graphics.Clear(Color.White);
				P_1.Graphics.InterpolationMode = (InterpolationMode)7;
				P_1.Graphics.CompositingQuality = (CompositingQuality)2;
				P_1.Graphics.SmoothingMode = (SmoothingMode)4;
				Rectangle marginBounds = P_1.MarginBounds;
				int num = ((Rectangle)(ref marginBounds)).Top;
				marginBounds = P_1.MarginBounds;
				int left = ((Rectangle)(ref marginBounds)).Left;
				Font val = new Font(((Control)BxX).Font.FontFamily, 12f, (FontStyle)1);
				try
				{
					string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhh() + BxY;
					SizeF val2 = P_1.Graphics.MeasureString(text, val);
					int num2 = (int)((SizeF)(ref val2)).Height;
					P_1.Graphics.DrawString(text, val, Brushes.Black, (float)(left + 3), (float)num);
					num += num2 + 5;
					Font val3 = new Font(((Control)BxX).Font.FontFamily, 12f, (FontStyle)0);
					try
					{
						string empty = string.Empty;
						if (BM.Qz.A(ref empty) && !string.IsNullOrEmpty(empty))
						{
							P_1.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhI(), val3, Brushes.Black, (float)(left + 3), (float)num);
							val2 = P_1.Graphics.MeasureString(empty, val);
							num2 = (int)((SizeF)(ref val2)).Height;
							P_1.Graphics.DrawString(empty, val, Brushes.Black, (float)(left + 140), (float)num);
							num += num2 + 2;
						}
						string text2 = BM.Qz.awy;
						if (text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq()))
						{
							text2 = text2.Substring(0, text2.Length - 1);
						}
						P_1.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agM(), val3, Brushes.Black, (float)(left + 3), (float)num);
						val2 = P_1.Graphics.MeasureString(text2, val);
						num2 = (int)((SizeF)(ref val2)).Height;
						P_1.Graphics.DrawString(text2, val, Brushes.Black, (float)(left + 140), (float)num);
						num += num2 + 15;
					}
					finally
					{
						((System.IDisposable)val3)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
				Bxx = num;
				if (!A(P_1.Graphics, P_1.MarginBounds))
				{
					BxY++;
					P_1.HasMorePages = true;
				}
			}

			private bool A(Graphics P_0, Rectangle P_1)
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0036: Unknown result type (might be due to invalid IL or missing references)
				//IL_0052: Unknown result type (might be due to invalid IL or missing references)
				if (BxX.F() == BB.A.BOq)
				{
					a(P_0, P_1);
				}
				else if (BxX.F() == BB.A.BOQ)
				{
					if (BxX.mw)
					{
						bool flag = false;
						A(P_0, P_1, ref flag);
						if (flag)
						{
							return false;
						}
					}
					if (BxX.mX)
					{
						B(P_0, P_1);
					}
				}
				if (BxX.F() != 0 || ((!BYb || !BYc) && BxX.mw) || ((!BYC || !BYD) && BxX.mX))
				{
					if (BxX.F() == BB.A.BOq)
					{
						return BYf;
					}
					return false;
				}
				return true;
			}

			private void a(Graphics P_0, Rectangle P_1)
			{
				//IL_0031: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Expected O, but got Unknown
				//IL_0139: Unknown result type (might be due to invalid IL or missing references)
				//IL_013e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0359: Unknown result type (might be due to invalid IL or missing references)
				//IL_0360: Expected O, but got Unknown
				//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
				int left = ((Rectangle)(ref P_1)).Left;
				int width = ((Rectangle)(ref P_1)).Width;
				if (!BYF)
				{
					Font val = new Font(((Control)BxX).Font.FontFamily, 8f, (FontStyle)1);
					try
					{
						P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IU(), val, Brushes.Black, (float)(left + 10), (float)(Bxx + 6));
						P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iu(), val, Brushes.Black, (float)(left + 475), (float)(Bxx + 6));
					}
					finally
					{
						((System.IDisposable)val)?.Dispose();
					}
					Bxx += 25;
					P_0.DrawLine(Pens.Black, left, Bxx, left + width, Bxx);
					BYF = true;
				}
				if (BYf)
				{
					return;
				}
				for (int i = BYd; i < PortFunction.A().Length; i++)
				{
					Cg cg2 = PortFunction.A()[i];
					if (BM.Qz.awb.ContainsKey(cg2))
					{
						string text = PortFunction.a(cg2, BM.Qz);
						string text2 = PortFunction.B(cg2, BM.Qz);
						if (!string.IsNullOrEmpty(text))
						{
							text2 = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IV();
						}
						bool flag = true;
						Enumerator<Connector> enumerator = BM.Qz.awb[cg2].GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Connector current = enumerator.Current;
								if (BYE.Contains(current))
								{
									continue;
								}
								int bxx = Bxx;
								Bxx += 35;
								bool flag2 = false;
								bool flag3 = false;
								for (int j = BYe; j < current.ayS.Count; j++)
								{
									WiringPin wiringPin = current.ayS.Values[j];
									if (!wiringPin.Bbq.l())
									{
										continue;
									}
									List<WiringPin.A> val2 = wiringPin.b();
									if (val2.Count == 0)
									{
										BYe++;
										continue;
									}
									Cg bsk = val2[val2.Count - 1].Bsk;
									CH bsL = val2[val2.Count - 1].BsL;
									byte bsl = val2[val2.Count - 1].Bsl;
									ushort bsM = val2[val2.Count - 1].BsM;
									SettingOrSpecialObject settingOrSpecialObject = PortFunction.A(BM.Qz, bsk, bsL, bsl, bsM);
									if (settingOrSpecialObject == null || !settingOrSpecialObject.l() || bsL == CH.BaF || !((BB)BxX).A(bsk, bsL))
									{
										BYe++;
										continue;
									}
									List<bool> val3 = new List<bool>();
									List<string> val4 = PortFunction.A(BM.Qz, bsk, bsL, bsl, bsM, true, val3);
									if (val4 == null)
									{
										string text3 = PortFunction.B(BM.Qz, bsk, bsL, bsl, bsM);
										if (text3 != null)
										{
											List<string> obj = new List<string>();
											obj.Add(text3);
											val4 = obj;
										}
									}
									if ((BxX.mw && val4 != null) || (BxX.mX && val4 == null))
									{
										A(P_0, P_1, true, settingOrSpecialObject, val4, wiringPin, bsk, bsL, bsl, bsM, ref flag2, ref flag3);
										if (flag3)
										{
											break;
										}
									}
									else
									{
										BYe++;
									}
								}
								if (!flag2)
								{
									Bxx -= 35;
								}
								else
								{
									Font val5 = new Font(((Control)BxX).Font.FontFamily, 8f);
									try
									{
										P_0.DrawString(current.ayr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iv() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo(), val5, Brushes.Black, (float)(left + 10), (float)(bxx + 20));
									}
									finally
									{
										((System.IDisposable)val5)?.Dispose();
									}
									P_0.DrawLine(Pens.Black, left, bxx + 35, left + width, bxx + 35);
								}
								if (!flag3)
								{
									BYe = 0;
									BYE.Add(current);
									continue;
								}
								flag = false;
								break;
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
						if (!flag)
						{
							break;
						}
						BYe = 0;
						BYd++;
						BYE.Clear();
						BYf = BYd == PortFunction.A().Length;
					}
					else
					{
						BYe = 0;
						BYd++;
						BYE.Clear();
						BYf = BYd == PortFunction.A().Length;
					}
				}
			}

			private void A(Graphics P_0, Rectangle P_1, ref bool P_2)
			{
				//IL_0031: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Expected O, but got Unknown
				//IL_0085: Unknown result type (might be due to invalid IL or missing references)
				//IL_008b: Expected O, but got Unknown
				//IL_019d: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f6: Expected O, but got Unknown
				int left = ((Rectangle)(ref P_1)).Left;
				int width = ((Rectangle)(ref P_1)).Width;
				if (!BYb)
				{
					Font val = new Font(((Control)BxX).Font.FontFamily, 12f, (FontStyle)1);
					try
					{
						P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IW(), val, Brushes.Black, (float)(left + 10), (float)Bxx);
					}
					finally
					{
						((System.IDisposable)val)?.Dispose();
					}
					Bxx += 30;
					Font val2 = new Font(((Control)BxX).Font.FontFamily, 8f, (FontStyle)1);
					try
					{
						P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IU(), val2, Brushes.Black, (float)(left + 10), (float)(Bxx + 6));
						P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iu(), val2, Brushes.Black, (float)(left + 475), (float)(Bxx + 6));
					}
					finally
					{
						((System.IDisposable)val2)?.Dispose();
					}
					Bxx += 25;
					P_0.DrawLine(Pens.Black, left, Bxx, left + width, Bxx);
					BYb = true;
				}
				if (BYc)
				{
					return;
				}
				for (int i = Bxy; i < PortFunction.A().Length; i++)
				{
					Cg cg2 = PortFunction.A()[i];
					string text = PortFunction.a(cg2, BM.Qz);
					string text2 = PortFunction.B(cg2, BM.Qz);
					if (!string.IsNullOrEmpty(text))
					{
						text2 = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IV();
					}
					bool flag = true;
					for (int j = Bxz; j < PortFunction.a().Length; j++)
					{
						CH cH2 = PortFunction.a()[j];
						int bxx = Bxx;
						Bxx += 35;
						if (!A(true, cg2, cH2, P_0, P_1, out var flag2))
						{
							Bxx -= 35;
						}
						else if (BxX.mZ || cH2 == BxX.my)
						{
							Font val3 = new Font(((Control)BxX).Font.FontFamily, 8f);
							try
							{
								if (cg2 == Cg.BAM)
								{
									P_0.DrawString(PortFunction.A(cH2) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo(), val3, Brushes.Black, (float)(left + 10), (float)(bxx + 20));
								}
								else
								{
									P_0.DrawString(PortFunction.A(cH2) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iv() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo(), val3, Brushes.Black, (float)(left + 10), (float)(bxx + 20));
								}
							}
							finally
							{
								((System.IDisposable)val3)?.Dispose();
							}
							P_0.DrawLine(Pens.Black, left, bxx + 35, left + width, bxx + 35);
						}
						if (!flag2)
						{
							BYa = 0;
							Bxz++;
							continue;
						}
						flag = false;
						break;
					}
					if (flag)
					{
						BYa = 0;
						Bxy++;
						Bxz = 0;
						bool flag3 = Bxy == PortFunction.A().Length;
						if (flag3 && !BYc)
						{
							P_2 = true;
						}
						BYc = flag3;
						continue;
					}
					break;
				}
			}

			private void B(Graphics P_0, Rectangle P_1)
			{
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected O, but got Unknown
				//IL_009d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a3: Expected O, but got Unknown
				//IL_019e: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f7: Expected O, but got Unknown
				int left = ((Rectangle)(ref P_1)).Left;
				int width = ((Rectangle)(ref P_1)).Width;
				if (!BYC && (BYc || !BxX.mw))
				{
					Font val = new Font(((Control)BxX).Font.FontFamily, 12f, (FontStyle)1);
					try
					{
						P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iw(), val, Brushes.Black, (float)(left + 10), (float)Bxx);
					}
					finally
					{
						((System.IDisposable)val)?.Dispose();
					}
					Bxx += 30;
					Font val2 = new Font(((Control)BxX).Font.FontFamily, 8f, (FontStyle)1);
					try
					{
						P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IU(), val2, Brushes.Black, (float)(left + 10), (float)(Bxx + 6));
					}
					finally
					{
						((System.IDisposable)val2)?.Dispose();
					}
					Bxx += 25;
					P_0.DrawLine(Pens.Black, left, Bxx, left + width, Bxx);
					BYC = true;
				}
				if (BYD || !BYC)
				{
					return;
				}
				for (int i = BxZ; i < PortFunction.A().Length; i++)
				{
					Cg cg2 = PortFunction.A()[i];
					string text = PortFunction.a(cg2, BM.Qz);
					string text2 = PortFunction.B(cg2, BM.Qz);
					if (!string.IsNullOrEmpty(text))
					{
						text2 = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IV();
					}
					bool flag = true;
					for (int j = BYA; j < PortFunction.a().Length; j++)
					{
						CH cH2 = PortFunction.a()[j];
						int bxx = Bxx;
						Bxx += 35;
						if (!A(false, cg2, cH2, P_0, P_1, out var flag2))
						{
							Bxx -= 35;
						}
						else if (BxX.mZ || cH2 == BxX.my)
						{
							Font val3 = new Font(((Control)BxX).Font.FontFamily, 8f);
							try
							{
								if (cg2 == Cg.BAM)
								{
									P_0.DrawString(PortFunction.A(cH2) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo(), val3, Brushes.Black, (float)(left + 10), (float)(bxx + 20));
								}
								else
								{
									P_0.DrawString(PortFunction.A(cH2) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iv() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo(), val3, Brushes.Black, (float)(left + 10), (float)(bxx + 20));
								}
							}
							finally
							{
								((System.IDisposable)val3)?.Dispose();
							}
							P_0.DrawLine(Pens.Black, left, bxx + 35, left + width, bxx + 35);
						}
						if (!flag2)
						{
							BYB = 0;
							BYA++;
							continue;
						}
						flag = false;
						break;
					}
					if (flag)
					{
						BYB = 0;
						BxZ++;
						BYA = 0;
						BYD = BxZ == PortFunction.A().Length;
						continue;
					}
					break;
				}
			}

			private bool A(bool P_0, Cg P_1, CH P_2, Graphics P_3, Rectangle P_4, out bool P_5)
			{
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				bool result = false;
				P_5 = false;
				int num = ((!P_0) ? BYB : BYa);
				for (int i = num; i < BM.Qz.awD.Count; i++)
				{
					SettingOrSpecialObject settingOrSpecialObject = BM.Qz.awD[i];
					if (!settingOrSpecialObject.l())
					{
						if (P_0)
						{
							BYa++;
						}
						else
						{
							BYB++;
						}
						continue;
					}
					Cg bSQ = settingOrSpecialObject.F().E().BSQ;
					CH bSq = settingOrSpecialObject.F().E().BSq;
					byte bSR = settingOrSpecialObject.F().E().BSR;
					ushort bSr = settingOrSpecialObject.F().E().BSr;
					if (bSQ != P_1 || bSq != P_2 || !((BB)BxX).A(bSQ, bSq))
					{
						if (P_0)
						{
							BYa++;
						}
						else
						{
							BYB++;
						}
						continue;
					}
					List<bool> val = new List<bool>();
					List<string> val2 = PortFunction.A(BM.Qz, bSQ, bSq, bSR, bSr, !P_0, val);
					if (val2 == null)
					{
						string text = PortFunction.B(BM.Qz, bSQ, bSq, bSR, bSr);
						if (text != null)
						{
							List<string> obj = new List<string>();
							obj.Add(text);
							val2 = obj;
						}
					}
					if ((P_0 && val2 != null) || (!P_0 && val2 == null))
					{
						A(P_3, P_4, P_0, settingOrSpecialObject, val2, null, bSQ, bSq, bSR, bSr, ref result, ref P_5);
						if (P_5)
						{
							break;
						}
					}
					else if (P_0)
					{
						BYa++;
					}
					else
					{
						BYB++;
					}
				}
				return result;
			}

			private void A(Graphics P_0, Rectangle P_1, bool P_2, SettingOrSpecialObject P_3, List<string> P_4, WiringPin P_5, Cg P_6, CH P_7, byte P_8, ushort P_9, ref bool P_10, ref bool P_11)
			{
				//IL_0039: Unknown result type (might be due to invalid IL or missing references)
				//IL_0040: Expected O, but got Unknown
				//IL_004b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_015d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d7: Expected O, but got Unknown
				//IL_016d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0174: Expected O, but got Unknown
				//IL_0285: Unknown result type (might be due to invalid IL or missing references)
				//IL_028c: Expected O, but got Unknown
				//IL_01de: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e5: Expected O, but got Unknown
				//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d0: Expected O, but got Unknown
				//IL_02da: Unknown result type (might be due to invalid IL or missing references)
				//IL_0379: Unknown result type (might be due to invalid IL or missing references)
				//IL_037e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0309: Unknown result type (might be due to invalid IL or missing references)
				//IL_030e: Unknown result type (might be due to invalid IL or missing references)
				//IL_031b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0322: Expected O, but got Unknown
				//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_042f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0436: Expected O, but got Unknown
				//IL_043f: Unknown result type (might be due to invalid IL or missing references)
				//IL_045f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0509: Unknown result type (might be due to invalid IL or missing references)
				//IL_0510: Expected O, but got Unknown
				//IL_0542: Unknown result type (might be due to invalid IL or missing references)
				//IL_0547: Unknown result type (might be due to invalid IL or missing references)
				//IL_059a: Unknown result type (might be due to invalid IL or missing references)
				//IL_059f: Unknown result type (might be due to invalid IL or missing references)
				//IL_061a: Unknown result type (might be due to invalid IL or missing references)
				//IL_061f: Unknown result type (might be due to invalid IL or missing references)
				List<PictureBox> val = new List<PictureBox>();
				List<Label> val2 = new List<Label>();
				string text = string.Empty;
				List<WiringPin> val3 = WiringPin.A(BM.Qz, P_6, P_7, P_8, P_9);
				if (P_7 == CH.Bal || val3.Count == 0)
				{
					PictureBox val4 = new PictureBox();
					if (P_7 == CH.Bal)
					{
						val4.Image = (Image)(object)WiringPin.A(Color.Transparent, Color.Transparent, false, true, false);
					}
					else
					{
						val4.Image = PortFunction.A(P_6, P_7);
					}
					if (val4.Image != null)
					{
						((Control)val4).Height = val4.Image.Height;
						((Control)val4).Width = val4.Image.Width;
					}
					else
					{
						((Control)val4).Height = 35;
						((Control)val4).Width = 100;
					}
					((Control)val4).Left = ((Rectangle)(ref P_1)).Left + 10;
					val.Add(val4);
					Label val5 = new Label();
					if (P_7 == CH.Bal)
					{
						((Control)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IZ();
					}
					((Control)val5).Left = ((Control)val4).Right + 20;
					((Control)val5).Top = 0;
					val2.Add(val5);
					if (((Control)val4).Height > 35)
					{
						((Control)val4).Top = 2;
					}
					else
					{
						((Control)val4).Top = ((Control)val5).Top - 3;
					}
				}
				else
				{
					bool flag = val3.Count > 1;
					if (P_5 != null)
					{
						List<WiringPin> obj = new List<WiringPin>();
						obj.Add(P_5);
						val3 = obj;
					}
					Enumerator<WiringPin> enumerator = val3.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							WiringPin current = enumerator.Current;
							PictureBox val6 = new PictureBox();
							val6.Image = current.d();
							if (val6.Image != null)
							{
								((Control)val6).Height = val6.Image.Height;
								((Control)val6).Width = val6.Image.Width;
							}
							else
							{
								((Control)val6).Height = 35;
								((Control)val6).Width = 100;
							}
							((Control)val6).Left = ((Rectangle)(ref P_1)).Left + 10;
							val.Add(val6);
							Label val7 = new Label();
							((Control)val7).Text = current.A(flag);
							((Control)val7).Left = ((Control)val6).Right + 20;
							((Control)val7).Top = val2.Count * ((Control)val7).Height;
							val2.Add(val7);
							if (((Control)val6).Height > 35)
							{
								((Control)val6).Top = 2;
							}
							else
							{
								((Control)val6).Top = ((Control)val7).Top - 3;
							}
							if (!string.IsNullOrEmpty(current.E()))
							{
								text = text + current.E() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iA();
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				Label val8 = new Label();
				string text2 = PortFunction.B(P_3);
				if (text2 != null)
				{
					((Control)val8).Text = text2;
					((Control)val8).Top = 0;
					((Control)val8).Left = ((Rectangle)(ref P_1)).Left + 295;
				}
				Label val9 = null;
				if (!string.IsNullOrEmpty(text))
				{
					val9 = new Label();
					((Control)val9).Text = text;
					((Control)val9).ForeColor = Color.DarkOrange;
					((Control)val9).Left = 5;
					((Control)val9).Top = 5;
					((Control)val9).AutoSize = true;
				}
				List<Label> val10 = new List<Label>();
				if (P_4 != null)
				{
					Enumerator<string> enumerator2 = P_4.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							string current2 = enumerator2.Current;
							Label val11 = new Label();
							((Control)val11).Text = current2;
							((Control)val11).Top = 0;
							((Control)val11).Left = ((Rectangle)(ref P_1)).Left + 475;
							val10.Add(val11);
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
				}
				List<string> val12 = new List<string>(val10.Count);
				Enumerator<Label> enumerator3 = val10.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						Label current3 = enumerator3.Current;
						val12.Add(((Control)current3).Text);
					}
				}
				finally
				{
					((System.IDisposable)enumerator3).Dispose();
				}
				List<string> val13 = new List<string>(val2.Count);
				enumerator3 = val2.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						Label current4 = enumerator3.Current;
						val13.Add(((Control)current4).Text);
					}
				}
				finally
				{
					((System.IDisposable)enumerator3).Dispose();
				}
				if (!BB.A(BxX.A(), P_7, P_6, ((Control)val8).Text, val12, val13))
				{
					return;
				}
				int num = BB.A(val, val2, null, val10, null, val9, 38, false);
				Panel val14 = new Panel();
				((Control)val14).Location = new Point(-1, Bxx);
				((Control)val14).Size = new Size(((Control)BxX.mS).Width, num + 1);
				Bxx += num;
				BB.A(val, val2, null, val10, null, null, null, val8, val9, num, 38, false);
				if (Bxx > ((Rectangle)(ref P_1)).Top + ((Rectangle)(ref P_1)).Height)
				{
					P_11 = true;
					return;
				}
				if (P_5 != null)
				{
					BYe++;
				}
				else if (P_2)
				{
					BYa++;
				}
				else
				{
					BYB++;
				}
				P_10 = true;
				Font val15 = new Font(((Control)BxX).Font.FontFamily, ((Control)BxX).Font.Size * 0.8f);
				try
				{
					if (val9 != null)
					{
						P_0.DrawString(((Control)val9).Text, val15, Brushes.DarkOrange, (float)((Control)val9).Left, (float)(((Control)val14).Top + ((Control)val9).Top));
					}
					enumerator3 = val10.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							Label current5 = enumerator3.Current;
							P_0.DrawString(((Control)current5).Text, val15, Brushes.Black, (float)((Control)current5).Left, (float)(((Control)val14).Top + ((Control)current5).Top));
						}
					}
					finally
					{
						((System.IDisposable)enumerator3).Dispose();
					}
					Enumerator<PictureBox> enumerator4 = val.GetEnumerator();
					try
					{
						while (enumerator4.MoveNext())
						{
							PictureBox current6 = enumerator4.Current;
							if (current6.Image != null)
							{
								P_0.DrawImage(current6.Image, ((Control)current6).Left, ((Control)val14).Top + ((Control)current6).Top, (int)((float)current6.Image.Width * 0.95f), (int)((float)current6.Image.Height * 0.95f));
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator4).Dispose();
					}
					enumerator3 = val2.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							Label current7 = enumerator3.Current;
							P_0.DrawString(((Control)current7).Text, val15, Brushes.Black, (float)((Control)current7).Left, (float)(((Control)val14).Top + ((Control)current7).Top));
						}
					}
					finally
					{
						((System.IDisposable)enumerator3).Dispose();
					}
					P_0.DrawString(((Control)val8).Text, val15, Brushes.Black, (float)((Control)val8).Left, (float)(((Control)val14).Top + ((Control)val8).Top));
					P_0.DrawLine(Pens.Black, ((Rectangle)(ref P_1)).Left, Bxx, ((Rectangle)(ref P_1)).Left + ((Rectangle)(ref P_1)).Width, Bxx);
				}
				finally
				{
					((System.IDisposable)val15)?.Dispose();
				}
			}
		}

		[CompilerGenerated]
		private static EventHandler BPt;

		private IContainer BPU;

		private PictureBox BPu;

		private ThemedTextBox BPV;

		private ThemedButton BPv;

		private Label BPW;

		private ThemedComboBox BPw;

		private Label BPX;

		private ThemedComboBox BPx;

		private ThemedButton BPY;

		private ThemedButton BPy;

		private ThemedButton BPZ;

		private Label BPz;

		private ThemedComboBox BpA;

		private ThemedButton Bpa;

		private ThemedButton BpB;

		private Timer Bpb;

		internal cx()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0399: Expected O, but got Unknown
			//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03aa: Expected O, but got Unknown
			//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0427: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_043e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0448: Expected O, but got Unknown
			mQ = false;
			a();
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			((Control)BPu).BackColor = ((Control)this).BackColor;
			if (BPu.Image != null)
			{
				BPu.Image.Dispose();
			}
			BPu.Image = (Image)(object)O.A((Image)(object)GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
			((Control)BPV).BackColor = BM.to;
			((Control)BPV).ForeColor = BM.te;
			BPV.A(A);
			Rectangle clientRectangle;
			if (BM.Qz.awC.Count != 0)
			{
				mr = new Bb(this);
				((Panel)mr).BorderStyle = (BorderStyle)1;
				((Control)mr).BackColor = BM.tG;
				((Control)mr).Left = 10;
				Bb bb = mr;
				clientRectangle = ((Control)this).ClientRectangle;
				((Control)bb).Width = ((Rectangle)(ref clientRectangle)).Width - 20;
				((Control)mr).Top = ((Control)BPZ).Bottom + 7;
				((Control)this).Controls.Add((Control)(object)mr);
			}
			((Panel)mS).BorderStyle = (BorderStyle)1;
			((Control)mS).BackColor = BM.tG;
			((Control)mS).Left = 10;
			aF aF = mS;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)aF).Width = ((Rectangle)(ref clientRectangle)).Width - 20;
			if (BM.Qz.awC.Count != 0)
			{
				((Control)mS).Top = ((Control)mr).Top + ((Control)mr).Height + 7;
			}
			else
			{
				((Control)mS).Top = ((Control)BPZ).Bottom + 7;
			}
			((Control)mS).Height = ((Control)BpB).Top - 10 - ((Control)mS).Top;
			((Control)this).Controls.Add((Control)(object)mS);
			((ComboBox)BPw).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDm());
			Cg[] array = PortFunction.A();
			foreach (Cg cg2 in array)
			{
				((ComboBox)BPw).Items.Add((object)PortFunction.B(cg2, BM.Qz));
			}
			((ListControl)BPw).SelectedIndex = 0;
			((ComboBox)BPx).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDN());
			CH[] array2 = PortFunction.a();
			foreach (CH cH2 in array2)
			{
				((ComboBox)BPx).Items.Add((object)PortFunction.A(cH2));
			}
			((ListControl)BPx).SelectedIndex = 0;
			ObjectCollection items = ((ComboBox)BpA).Items;
			object[] array3 = new string[2]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDn(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDO()
			};
			items.AddRange(array3);
			((ListControl)BpA).SelectedIndex = (int)BB.ND;
			((Control)BPz).Visible = (((Control)BpA).Visible = BM.Qz.awe);
			global::A.A.A((global::A.D)base.a);
			BM.D(new EventHandler(base.a));
			BM.C(new EventHandler(F));
			a();
			BB.NE = this;
			Nd = new Ck(BM.Qz);
			Enumerator<WiringPin> enumerator2 = BM.Qz.awc.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					WiringPin current = enumerator2.Current;
					if (current.e())
					{
						NC.Add(BM.Qz.A(current.Bbx));
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			Enumerator<Setting> enumerator3 = NC.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					enumerator3.Current.A(new EventHandler(base.b));
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			mR = false;
		}

		private new void a(object P_0, EventArgs P_1)
		{
			d();
		}

		private new void B(object P_0, EventArgs P_1)
		{
			E();
		}

		private new void b(object P_0, EventArgs P_1)
		{
			e();
		}

		private void C(object P_0, EventArgs P_1)
		{
			if (!mR)
			{
				base.A(((ListControl)BPw).SelectedIndex == 0, ((Control)BPw).Text);
			}
		}

		private void c(object P_0, EventArgs P_1)
		{
			if (!mR)
			{
				base.a(((ListControl)BPx).SelectedIndex == 0, ((Control)BPx).Text);
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			if (!mR && ((ListControl)BpA).SelectedIndex != -1)
			{
				base.A((BB.A)((ListControl)BpA).SelectedIndex);
			}
		}

		private void d(object P_0, EventArgs P_1)
		{
			Bpb.Stop();
			Bpb.Start();
		}

		private void A(object P_0, ThemedTextBox.B P_1)
		{
			Bpb.Stop();
			Bpb.Start();
		}

		private void E(object P_0, EventArgs P_1)
		{
			Bpb.Stop();
			a();
		}

		private void e(object P_0, EventArgs P_1)
		{
			((Control)BPV).Text = string.Empty;
		}

		internal override string A()
		{
			return ((Control)BPV).Text;
		}

		private void F(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void A(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = BPt;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BPt, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void a(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = BPt;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BPt, val3, val2);
			}
			while (val != val2);
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected O, but got Unknown
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected O, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected O, but got Unknown
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Expected O, but got Unknown
			BB.NE = null;
			foreach (Control item in (ArrangedElementCollection)((Control)mS).Controls)
			{
				item.MouseClick -= new MouseEventHandler(base.A);
				item.DoubleClick -= new EventHandler(((BB)this).A);
				foreach (Control item2 in (ArrangedElementCollection)item.Controls)
				{
					item2.MouseClick -= new MouseEventHandler(base.A);
					item2.DoubleClick -= new EventHandler(((BB)this).A);
					item2.MouseClick -= new MouseEventHandler(base.a);
				}
			}
			global::A.A.a((global::A.D)base.a);
			BM.d(new EventHandler(base.a));
			BM.c(new EventHandler(F));
			Enumerator<Label> enumerator3 = mT.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					SettingOrSpecialObject bOR = ((a)((Control)enumerator3.Current).Tag).BOR;
					for (int i = 0; i < bOR.F().b().Count; i++)
					{
						bOR.F().b()[i].a(new EventHandler(base.B));
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			Enumerator<Setting> enumerator4 = NC.GetEnumerator();
			try
			{
				while (enumerator4.MoveNext())
				{
					enumerator4.Current.a(new EventHandler(base.b));
				}
			}
			finally
			{
				((System.IDisposable)enumerator4).Dispose();
			}
			NC.Clear();
			if (Ne.IsRunning)
			{
				Ne.Stop();
			}
			if (BPt != null)
			{
				BPt.Invoke((object)this, (EventArgs)null);
			}
		}

		private void f(object P_0, EventArgs P_1)
		{
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			((Control)Bpa).Left = ((Control)this).Width - 251;
			((Control)BpB).Left = ((Control)Bpa).Right + 19;
			ThemedButton bpa = Bpa;
			int top = (((Control)BpB).Top = ((Control)this).Height - 79);
			((Control)bpa).Top = top;
			((Control)BPz).Top = ((Control)this).Height - 72;
			((Control)BpA).Top = ((Control)this).Height - 76;
			Rectangle clientRectangle;
			if (mr != null)
			{
				Bb bb = mr;
				clientRectangle = ((Control)this).ClientRectangle;
				((Control)bb).Width = ((Rectangle)(ref clientRectangle)).Width - 20;
			}
			aF aF = mS;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)aF).Width = ((Rectangle)(ref clientRectangle)).Width - 20;
			((Control)mS).Height = ((Control)BpB).Top - 10 - ((Control)mS).Top;
		}

		private void G(object P_0, EventArgs P_1)
		{
			new A(this).A();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && BPU != null)
			{
				((System.IDisposable)BPU).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private new void a()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected O, but got Unknown
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected O, but got Unknown
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Expected O, but got Unknown
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Expected O, but got Unknown
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Expected O, but got Unknown
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_0376: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Expected O, but got Unknown
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Expected O, but got Unknown
			//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03da: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0436: Expected O, but got Unknown
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0482: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04af: Expected O, but got Unknown
			//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cc: Expected O, but got Unknown
			//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_053b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0545: Expected O, but got Unknown
			//IL_0558: Unknown result type (might be due to invalid IL or missing references)
			//IL_0562: Expected O, but got Unknown
			//IL_056e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0592: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05db: Expected O, but got Unknown
			//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f8: Expected O, but got Unknown
			//IL_0604: Unknown result type (might be due to invalid IL or missing references)
			//IL_0628: Unknown result type (might be due to invalid IL or missing references)
			//IL_0667: Unknown result type (might be due to invalid IL or missing references)
			//IL_0671: Expected O, but got Unknown
			//IL_0690: Unknown result type (might be due to invalid IL or missing references)
			//IL_069a: Expected O, but got Unknown
			//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_071c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0726: Expected O, but got Unknown
			//IL_073f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0772: Unknown result type (might be due to invalid IL or missing references)
			//IL_0795: Unknown result type (might be due to invalid IL or missing references)
			//IL_079f: Expected O, but got Unknown
			//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bc: Expected O, but got Unknown
			//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_082f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0839: Expected O, but got Unknown
			//IL_0858: Unknown result type (might be due to invalid IL or missing references)
			//IL_0862: Expected O, but got Unknown
			//IL_0872: Unknown result type (might be due to invalid IL or missing references)
			//IL_0896: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f0: Expected O, but got Unknown
			//IL_0907: Unknown result type (might be due to invalid IL or missing references)
			//IL_092f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3f: Expected O, but got Unknown
			//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a8a: Expected O, but got Unknown
			//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a9c: Expected O, but got Unknown
			BPU = (IContainer)new Container();
			ComponentResourceManager val = new ComponentResourceManager(typeof(cx));
			BPu = new PictureBox();
			BPV = new ThemedTextBox();
			BPv = new ThemedButton();
			BPW = new Label();
			BPw = new ThemedComboBox();
			BPX = new Label();
			BPx = new ThemedComboBox();
			BPY = new ThemedButton();
			BPy = new ThemedButton();
			BPZ = new ThemedButton();
			BPz = new Label();
			BpA = new ThemedComboBox();
			Bpa = new ThemedButton();
			BpB = new ThemedButton();
			Bpb = new Timer(BPU);
			((ISupportInitialize)BPu).BeginInit();
			((Control)this).SuspendLayout();
			BPu.Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDo());
			((Control)BPu).Location = new Point(7, 7);
			((Control)BPu).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fJ();
			((Control)BPu).Size = new Size(24, 24);
			BPu.TabIndex = 21;
			BPu.TabStop = false;
			((Control)BPV).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPV).Location = new Point(36, 8);
			((Control)BPV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fi();
			((Control)BPV).Size = new Size(137, 22);
			((Control)BPV).TabIndex = 0;
			((Control)BPV).TextChanged += new EventHandler(d);
			((Control)BPv).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)BPv).Location = new Point(175, 7);
			((Control)BPv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fj();
			((Control)BPv).Size = new Size(22, 24);
			((Control)BPv).TabIndex = 1;
			((Control)BPv).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Di();
			((ButtonBase)BPv).UseVisualStyleBackColor = true;
			((Control)BPv).Click += new EventHandler(e);
			((Control)BPW).AutoSize = true;
			((Control)BPW).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPW).Location = new Point(211, 11);
			((Control)BPW).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDP();
			((Control)BPW).Size = new Size(48, 13);
			((Control)BPW).TabIndex = 18;
			((Control)BPW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDp();
			((ComboBox)BPw).DrawMode = (DrawMode)1;
			((ComboBox)BPw).DropDownStyle = (ComboBoxStyle)2;
			((Control)BPw).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((ListControl)BPw).FormattingEnabled = true;
			((Control)BPw).Location = new Point(262, 7);
			((ComboBox)BPw).MaxDropDownItems = 50;
			((Control)BPw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDQ();
			((Control)BPw).Size = new Size(206, 23);
			((Control)BPw).TabIndex = 2;
			((ComboBox)BPw).SelectedIndexChanged += new EventHandler(C);
			((Control)BPX).AutoSize = true;
			((Control)BPX).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPX).Location = new Point(482, 11);
			((Control)BPX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDq();
			((Control)BPX).Size = new Size(101, 13);
			((Control)BPX).TabIndex = 13;
			((Control)BPX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDR();
			((ComboBox)BPx).DrawMode = (DrawMode)1;
			((ComboBox)BPx).DropDownStyle = (ComboBoxStyle)2;
			((Control)BPx).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((ListControl)BPx).FormattingEnabled = true;
			((Control)BPx).Location = new Point(586, 7);
			((ComboBox)BPx).MaxDropDownItems = 50;
			((Control)BPx).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDr();
			((Control)BPx).Size = new Size(194, 23);
			((Control)BPx).TabIndex = 3;
			((ComboBox)BPx).SelectedIndexChanged += new EventHandler(c);
			((Control)BPY).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPY).Location = new Point(836, 5);
			((Control)BPY).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDS();
			((Control)BPY).Size = new Size(120, 25);
			((Control)BPY).TabIndex = 4;
			((Control)BPY).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDs();
			((ButtonBase)BPY).UseVisualStyleBackColor = true;
			((Control)BPY).Click += new EventHandler(a);
			((Control)BPy).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPy).Location = new Point(958, 5);
			((Control)BPy).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDT();
			((Control)BPy).Size = new Size(120, 25);
			((Control)BPy).TabIndex = 5;
			((Control)BPy).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDt();
			((ButtonBase)BPy).UseVisualStyleBackColor = true;
			((Control)BPy).Click += new EventHandler(B);
			((Control)BPZ).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPZ).Location = new Point(1080, 5);
			((Control)BPZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDU();
			((Control)BPZ).Size = new Size(120, 25);
			((Control)BPZ).TabIndex = 6;
			((Control)BPZ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDu();
			((ButtonBase)BPZ).UseVisualStyleBackColor = true;
			((Control)BPZ).Click += new EventHandler(b);
			((Control)BPz).AutoSize = true;
			((Control)BPz).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BPz).Location = new Point(7, 570);
			((Control)BPz).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDV();
			((Control)BPz).Size = new Size(60, 13);
			((Control)BPz).TabIndex = 26;
			((Control)BPz).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDv();
			((ComboBox)BpA).DrawMode = (DrawMode)1;
			((ComboBox)BpA).DropDownStyle = (ComboBoxStyle)2;
			((Control)BpA).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((ListControl)BpA).FormattingEnabled = true;
			((Control)BpA).Location = new Point(55, 566);
			((ComboBox)BpA).MaxDropDownItems = 2;
			((Control)BpA).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDW();
			((Control)BpA).Size = new Size(180, 23);
			((Control)BpA).TabIndex = 7;
			((ComboBox)BpA).SelectedIndexChanged += new EventHandler(D);
			((Control)Bpa).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)Bpa).Location = new Point(1010, 563);
			((Control)Bpa).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDx();
			((Control)Bpa).Size = new Size(106, 30);
			((Control)Bpa).TabIndex = 8;
			((Control)Bpa).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDY();
			((ButtonBase)Bpa).UseVisualStyleBackColor = true;
			((Control)Bpa).Click += new EventHandler(G);
			((Button)BpB).DialogResult = (DialogResult)1;
			((Control)BpB).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)BpB).Location = new Point(1135, 563);
			((Control)BpB).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)BpB).Size = new Size(100, 30);
			((Control)BpB).TabIndex = 9;
			((Control)BpB).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)BpB).UseVisualStyleBackColor = true;
			Bpb.Interval = 400;
			Bpb.Tick += new EventHandler(E);
			((Form)this).AcceptButton = (IButtonControl)(object)BpB;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)BpB;
			((Form)this).ClientSize = new Size(1245, 604);
			((Control)this).Controls.Add((Control)(object)BPu);
			((Control)this).Controls.Add((Control)(object)BPV);
			((Control)this).Controls.Add((Control)(object)BPv);
			((Control)this).Controls.Add((Control)(object)BPW);
			((Control)this).Controls.Add((Control)(object)BPw);
			((Control)this).Controls.Add((Control)(object)BPX);
			((Control)this).Controls.Add((Control)(object)BPx);
			((Control)this).Controls.Add((Control)(object)BPY);
			((Control)this).Controls.Add((Control)(object)BPy);
			((Control)this).Controls.Add((Control)(object)BPZ);
			((Control)this).Controls.Add((Control)(object)BPz);
			((Control)this).Controls.Add((Control)(object)BpA);
			((Control)this).Controls.Add((Control)(object)Bpa);
			((Control)this).Controls.Add((Control)(object)BpB);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDy();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDZ();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)this).Resize += new EventHandler(f);
			((ISupportInitialize)BPu).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
namespace C
{
	internal class CX
	{
		internal bW BdC;

		internal List<ushort> Bdc;

		public virtual string ToString()
		{
			return ((object)BdC).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY() + Bdc.Count + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYo();
		}
	}
	internal class Cx
	{
		internal bt BdD;

		internal k Bdd;

		public virtual string ToString()
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYO() + ((object)BdD).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aN() + ((object)Bdd).ToString();
		}
	}
}
