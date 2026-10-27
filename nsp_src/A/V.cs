using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using D;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;
using c;

namespace A;

internal class V : Panel
{
	private class A
	{
		internal DJ BIT;

		internal int BIt;

		internal ch.a BIU;

		internal System.DateTime BIu;

		internal bool BIV;
	}

	internal enum a
	{
		BIv,
		BIW,
		BIw
	}

	internal enum B
	{
		BIX,
		BIx
	}

	internal enum b
	{
		BIY,
		BIy,
		BIZ
	}

	internal enum C
	{
		BIz,
		BiA
	}

	internal class c
	{
		[CompilerGenerated]
		private sealed class A
		{
			public V BuC;

			public int Buc;

			public int BuD;

			public MethodInvoker Bud;

			internal void A()
			{
				BuC.En.Minimum = Buc;
				BuC.En.Maximum = BuD;
			}

			internal void a()
			{
				BuC.En.Minimum = Buc;
				BuC.En.Maximum = BuD;
			}
		}

		private Framework Bia;

		public B BiB;

		public int Bib;

		public int BiC;

		public Dk Bic;

		public Thread BiD;

		internal V Bid;

		internal c(Framework P_0, Dk P_1, V P_2)
		{
			Bia = P_0;
			Bic = P_1;
			Bid = P_2;
			Bib = P_1.F().ax();
			BiB = V.B.BIX;
			BiC = 0;
		}

		internal c(Framework P_0, int P_1)
		{
			Bia = P_0;
			Bic = null;
			Bib = P_1;
			BiB = V.B.BIX;
			BiC = 0;
		}

		internal void A(object P_0)
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Expected O, but got Unknown
			//IL_01ba: Expected O, but got Unknown
			if (Bib <= 0 || Bic == null)
			{
				return;
			}
			V.A(Bia, Bic, out Setting setting, out Setting setting2, out Setting setting3);
			int Buc = setting.ax();
			int BuD = setting2.ax();
			int num = setting3.ax();
			V BuC = P_0 as V;
			if (((Control)BuC).InvokeRequired)
			{
				((Control)BuC).Invoke((System.Delegate)(MethodInvoker)delegate
				{
					BuC.En.Minimum = Buc;
					BuC.En.Maximum = BuD;
				});
			}
			else
			{
				BuC.En.Minimum = Buc;
				BuC.En.Maximum = BuD;
			}
			int num2 = BuD - Buc;
			int num3 = ((num2 < 40 && num == 0) ? 1 : (num2 / 40));
			int num4 = Buc;
			int num5 = BuD;
			MethodInvoker Bud = default(MethodInvoker);
			while (BiB != 0)
			{
				for (int num6 = num4; (num3 > 0) ? (num6 <= num5) : (num6 >= num5); num6 += num3)
				{
					if (BiB == V.B.BIX)
					{
						break;
					}
					BiC = num6;
					cb.A(true);
					Thread.Sleep(200);
					V.A(Bia, Bic, out Setting setting4, out Setting setting5, out Setting setting6);
					if (setting4.ax() == Buc && setting5.ax() == BuD)
					{
						continue;
					}
					Buc = setting4.ax();
					BuD = setting5.ax();
					num4 = Buc;
					num5 = BuD;
					num = setting6.ax();
					if (((Control)BuC).InvokeRequired)
					{
						V obj = BuC;
						MethodInvoker obj2 = Bud;
						if (obj2 == null)
						{
							MethodInvoker val = delegate
							{
								BuC.En.Minimum = Buc;
								BuC.En.Maximum = BuD;
							};
							MethodInvoker val2 = val;
							Bud = val;
							obj2 = val2;
						}
						((Control)obj).Invoke((System.Delegate)(object)obj2);
					}
					else
					{
						BuC.En.Minimum = Buc;
						BuC.En.Maximum = BuD;
					}
					num2 = BuD - Buc;
					num3 = ((num3 <= 0) ? ((num2 < 40 && num == 0) ? (-1) : (-num2 / 40)) : ((num2 < 40 && num == 0) ? 1 : (num2 / 40)));
					break;
				}
				if (num3 > 0)
				{
					num3 = -num3;
					int num7 = num4;
					num4 = num5;
					num5 = num7;
				}
				else
				{
					num3 = -num3;
				}
			}
		}

		internal void A()
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			if (BiD == null)
			{
				BiD = new Thread(new ParameterizedThreadStart(A));
				BiB = V.B.BIx;
				BiD.Start((object)Bid);
			}
		}

		internal void a()
		{
			try
			{
				if (BiD != null)
				{
					BiB = V.B.BIX;
				}
			}
			catch
			{
			}
			BiD = null;
		}
	}

	internal class D
	{
		public bool BiE;

		public b Bie = V.b.BIZ;

		public List<c> BiF = new List<c>();
	}

	private delegate bool d(ref byte[] P_0);

	internal const int EL = 26;

	internal const int El = 470;

	private aP EM;

	private Label Em;

	private Label EN;

	private TrackBar En;

	private aP EO;

	private ThemedButton Eo;

	private RadioButton EP;

	private RadioButton Ep;

	private cQ EQ;

	private Rectangle Eq = Rectangle.Empty;

	private Framework ER;

	private Setting Er;

	internal D ES = new D();

	private int Es = 100;

	private List<A> ET = new List<A>();

	private int Et;

	private Dk EU;

	private const int Eu = 30;

	private a EV;

	internal void A(int P_0)
	{
		Es = P_0;
	}

	private void A()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		EP = new RadioButton();
		Ep = new RadioButton();
		Em = new Label();
		EN = new Label();
		En = new TrackBar();
		EO = new aP();
		Eo = new ThemedButton();
		EM = new aP();
		((ISupportInitialize)En).BeginInit();
		((Control)this).SuspendLayout();
		((Control)EM).AutoSize = true;
		((Control)EM).Font = new Font(((Control)EM).Font.FontFamily, 9f);
		((Control)EM).Location = new Point(1, 4);
		((Control)EM).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dz();
		((Control)EM).TabIndex = 0;
		((Control)EM).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dA();
		((ButtonBase)EM).UseVisualStyleBackColor = true;
		((Control)Em).AutoSize = true;
		((Control)Em).Font = new Font(((Control)Em).Font.FontFamily, 9f);
		((Control)Em).Location = new Point(90, 5);
		((Control)Em).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.da();
		((Control)Em).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dB();
		((Control)EN).AutoSize = true;
		((Control)EN).Font = new Font(((Control)EN).Font.FontFamily, 9f);
		((Control)EN).Location = new Point(130, 5);
		((Control)EN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.db();
		((Control)EN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
		((Control)En).AutoSize = false;
		En.TickStyle = (TickStyle)0;
		En.SmallChange = 1;
		En.LargeChange = 10;
		((Control)En).Location = new Point(170, 2);
		((Control)En).Margin = new Padding(0);
		En.Maximum = 100;
		((Control)En).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dC();
		((Control)En).Size = new Size(440, 30);
		((Control)En).TabIndex = 1;
		((Control)EO).AutoSize = true;
		((Control)EO).Font = new Font(((Control)EO).Font.FontFamily, 9f);
		((Control)EO).Location = new Point(580, 4);
		((Control)EO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dc();
		((Control)EO).TabIndex = 2;
		((Control)EO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dD();
		((ButtonBase)EO).UseVisualStyleBackColor = true;
		((Control)EP).AutoSize = true;
		((Control)EP).Font = new Font(((Control)EP).Font.FontFamily, 9f);
		((Control)EP).Location = new Point(640, 3);
		((Control)EP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dd();
		((Control)EP).TabIndex = 3;
		EP.TabStop = true;
		((Control)EP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dE();
		((ButtonBase)EP).UseVisualStyleBackColor = true;
		((Control)Ep).AutoSize = true;
		((Control)Ep).Font = new Font(((Control)Ep).Font.FontFamily, 9f);
		((Control)Ep).Location = new Point(680, 3);
		((Control)Ep).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.de();
		((Control)Ep).TabIndex = 4;
		Ep.TabStop = true;
		((Control)Ep).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dF();
		((ButtonBase)Ep).UseVisualStyleBackColor = true;
		((Control)Eo).AutoSize = false;
		((Control)Eo).Width = 40;
		((Control)Eo).Font = new Font(((Control)EO).Font.FontFamily, 9f);
		((Control)Eo).Location = new Point(720, 2);
		((Control)Eo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.df();
		((Control)Eo).TabIndex = 2;
		((Control)Eo).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dG();
		((ButtonBase)Eo).UseVisualStyleBackColor = true;
		((Control)this).Controls.Add((Control)(object)EM);
		((Control)this).Controls.Add((Control)(object)Em);
		((Control)this).Controls.Add((Control)(object)EN);
		((Control)this).Controls.Add((Control)(object)En);
		((Control)this).Controls.Add((Control)(object)EO);
		((Control)this).Controls.Add((Control)(object)EP);
		((Control)this).Controls.Add((Control)(object)Ep);
		((Control)this).Controls.Add((Control)(object)Eo);
		((ISupportInitialize)En).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void a()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		((Control)EM).ForeColor = BM.te;
		((Control)Em).ForeColor = BM.te;
		((Control)EN).ForeColor = BM.te;
		((Control)EO).ForeColor = BM.te;
		((Control)EP).ForeColor = BM.te;
		((Control)Ep).ForeColor = BM.te;
		((Control)Eo).ForeColor = BM.te;
	}

	private void B()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		((Control)this).Resize += new EventHandler(A);
		((Control)EP).Click += new EventHandler(a);
		((Control)Ep).Click += new EventHandler(a);
		En.ValueChanged += new EventHandler(a);
		((Control)EO).Click += new EventHandler(a);
		((Control)EM).Click += new EventHandler(a);
		((Control)Eo).Click += new EventHandler(a);
	}

	private void b()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		((Control)this).Resize -= new EventHandler(A);
		((Control)EP).Click -= new EventHandler(a);
		((Control)Ep).Click -= new EventHandler(a);
		En.ValueChanged -= new EventHandler(a);
		((Control)EO).Click -= new EventHandler(a);
		((Control)EM).Click -= new EventHandler(a);
		((Control)Eo).Click -= new EventHandler(a);
	}

	private void A(object P_0, EventArgs P_1)
	{
		((Control)En).Width = ((Control)this).Width - 400;
		((Control)EO).Left = ((Control)this).Width - 230;
		((Control)EP).Left = ((Control)this).Width - 170;
		((Control)Ep).Left = ((Control)this).Width - 120;
		((Control)Eo).Left = ((Control)this).Width - 50;
	}

	private void a(object P_0, EventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Invalid comparison between Unknown and I4
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Invalid comparison between Unknown and I4
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		Control val = (Control)P_0;
		EV = V.a.BIv;
		string name = val.Name;
		if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dz()))
		{
			if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dd()))
			{
				if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.de()))
				{
					if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dC()))
					{
						if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dc()))
						{
							if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.df())
							{
								if ((Control.ModifierKeys & 0x20000) == 131072)
								{
									EV = V.a.BIw;
								}
								else
								{
									EV = V.a.BIW;
								}
								cb.A(true);
								Thread.Sleep(30);
							}
						}
						else if (Et > 0)
						{
							Enumerator<c> enumerator = ES.BiF.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									c current = enumerator.Current;
									if (current.Bib == Et)
									{
										if ((int)((CheckBox)(aP)(object)val).CheckState == 1)
										{
											current.BiB = V.B.BIx;
											current.A();
										}
										else
										{
											current.BiB = V.B.BIX;
											current.a();
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
					else if (Et > 0 && EU != null)
					{
						Enumerator<c> enumerator = ES.BiF.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								c current2 = enumerator.Current;
								if (current2.Bib == Et)
								{
									current2.BiC = ((TrackBar)val).Value;
									Setting setting = ER.A(Et);
									A(ER, EU, out var setting2, out var setting3, out var _);
									int num = setting2.ax();
									int num2 = setting3.ax();
									if (En.Minimum != num || En.Maximum != num2)
									{
										En.Minimum = num;
										En.Maximum = num2;
									}
									int num3 = setting3.K();
									if (setting != null)
									{
										((Control)EN).Text = bS.a(((TrackBar)val).Value, setting.aS(), num3);
									}
									else
									{
										((Control)EN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
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
				else
				{
					ES.Bie = V.b.BIy;
					EP.Checked = false;
				}
			}
			else
			{
				ES.Bie = V.b.BIY;
				Ep.Checked = false;
			}
		}
		else if ((int)((CheckBox)(aP)(object)val).CheckState == 1)
		{
			ES.BiE = true;
			if (ER.awP != null && ER.awP.D() != null)
			{
				ER.awP.D().a(1, true);
			}
			if (ER.awp != null)
			{
				ER.awp.B(1);
			}
			if (Et > 0)
			{
				Enumerator<c> enumerator = ES.BiF.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						c current3 = enumerator.Current;
						if (current3.Bib == Et && current3.Bic != null)
						{
							A(current3.Bic, current3);
							A(current3.Bic);
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			else
			{
				ER.awP.C().a(0, true);
			}
			((Control)Em).Enabled = Et > 0 && EU != null;
			((Control)EN).Enabled = Et > 0 && EU != null;
			((Control)EO).Enabled = Et > 0 && EU != null;
			((Control)En).Enabled = Et > 0 && EU != null;
			((Control)EP).Enabled = true;
			((Control)Ep).Enabled = true;
			((Control)Eo).Enabled = Er != null;
		}
		else
		{
			ES.BiE = false;
			if (ER.awP != null && ER.awP.D() != null)
			{
				ER.awP.D().a(0, true);
			}
			if (ER.awp != null)
			{
				ER.awp.B(0);
			}
			if (EQ != null)
			{
				EQ.c();
			}
			Enumerator<c> enumerator = ES.BiF.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					c current4 = enumerator.Current;
					if (current4.Bic != null)
					{
						((Control)En).Enabled = false;
						A(ER, current4.Bic, out var setting5, out var setting6, out var _);
						En.Minimum = setting5.ax();
						En.Maximum = setting6.ax();
						int biC = (En.Value = En.Minimum);
						current4.BiC = biC;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			((Control)Em).Enabled = false;
			((Control)EN).Enabled = false;
			((Control)EO).Enabled = false;
			((Control)EP).Enabled = false;
			((Control)Ep).Enabled = false;
			((Control)Eo).Enabled = false;
		}
		cb.A(true);
	}

	internal void A(Dk P_0)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 != null)
		{
			EU = P_0;
			Et = P_0.F().ax();
			bool flag = Et > 0 && EU != null && ((CheckBox)EM).Checked;
			((Control)EO).Enabled = flag;
			((Control)En).Enabled = flag;
			((Control)Em).Enabled = flag;
			((Control)EN).Enabled = flag;
			((Control)Eo).Enabled = flag && Er != null;
			bool flag2 = false;
			c c2 = null;
			Enumerator<c> enumerator = ES.BiF.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					c current = enumerator.Current;
					if (current.Bib == Et)
					{
						flag2 = true;
						c2 = current;
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (!flag2)
			{
				c c3 = new c(ER, P_0, this);
				ES.BiF.Add(c3);
				c2 = c3;
			}
			if (P_0 != null && ((CheckBox)EM).Checked)
			{
				A(P_0, c2);
			}
		}
		else
		{
			ER.awP.C().a(0, true);
		}
	}

	internal void A(Dk P_0, c P_1)
	{
		Setting setting = ER.A(Et);
		if (setting != null && EU != null)
		{
			((Control)En).Enabled = true;
			A(ER, P_0, out var setting2, out var setting3, out var _);
			En.Minimum = setting2.ax();
			En.Maximum = setting3.ax();
			if (P_1 != null)
			{
				if (P_1 != null && P_1.BiC >= En.Minimum && P_1.BiC <= En.Maximum)
				{
					En.Value = P_1.BiC;
				}
				else
				{
					En.Value = (P_1.BiC = En.Minimum);
				}
				if (P_1.BiB == V.B.BIx)
				{
					((CheckBox)EO).Checked = true;
				}
				else
				{
					((CheckBox)EO).Checked = false;
				}
			}
			else
			{
				En.Value = En.Minimum;
			}
			int num = setting3.K();
			((Control)EN).Text = bS.a(En.Value, setting.aS(), num);
		}
		else
		{
			((Control)EN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
		}
	}

	internal V(Framework P_0, cQ P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		A();
		ER = P_0;
		EQ = P_1;
		a();
		((CheckBox)EM).Checked = false;
		ES.BiE = false;
		if (ER.awp != null)
		{
			ER.awp.B(0);
		}
		((Control)Em).Enabled = false;
		((Control)EN).Enabled = false;
		((Control)En).Enabled = false;
		((Control)EO).Enabled = false;
		((Control)EP).Enabled = false;
		((Control)Ep).Enabled = false;
		((Control)Eo).Enabled = false;
		B();
		ET.Clear();
		Er = ER.A(60045);
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		b();
		Enumerator<c> enumerator = ES.BiF.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				c current = enumerator.Current;
				if (current.BiD != null)
				{
					current.BiB = V.B.BIX;
					current.BiD = null;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	internal bool A(ref byte[] P_0)
	{
		if (((Control)this).InvokeRequired)
		{
			d d2 = a;
			return (bool)((Control)this).Invoke((System.Delegate)d2, new object[1] { P_0 });
		}
		return a(ref P_0);
	}

	private bool a(ref byte[] P_0)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		bool result = false;
		if (ES.BiE)
		{
			if (EU != null)
			{
				A(ER, EU, out var setting, out var setting2, out var _);
				if (En.Minimum != setting.ax())
				{
					En.Minimum = setting.ax();
				}
				if (En.Maximum != setting2.ax())
				{
					En.Maximum = setting2.ax();
				}
			}
			Mutex val = new Mutex(false, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dg());
			try
			{
				if (((WaitHandle)val).WaitOne(100))
				{
					if (ER.awp != null && ER.awp.a() != null)
					{
						Setting setting4 = ER.awp.a();
						setting4.a(1, true);
						N.A(setting4.ax(), P_0, setting4.a(), setting4.aG(), ER.aWR);
						Setting setting5 = ER.awP.D();
						if (setting5 != null)
						{
							N.A(1, P_0, setting5.a(), 4, ER.aWR);
						}
					}
					N.A(Es, P_0, ER.awP.d().a(), ER.awP.d().aG(), ER.aWR);
					if (ES.Bie != V.b.BIZ)
					{
						Setting setting6 = ER.A(60002);
						int num = setting6.ax();
						int bie = (int)ES.Bie;
						if (num != bie)
						{
							N.A(bie, P_0, setting6.a(), 4, ER.aWR);
							result = true;
						}
					}
					Enumerator<c> enumerator = ES.BiF.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							c current = enumerator.Current;
							Setting setting7 = ER.A(current.Bib);
							int biC = current.BiC;
							N.A(biC, P_0, setting7.a(), 4, ER.aWR);
							result = true;
							if (EU != null && current.Bib == Et)
							{
								A(ER, EU, out var _, out var setting9, out var _);
								int num2 = setting9.K();
								string text = bS.a(biC, setting7.aS(), num2);
								if (text != ((Control)EN).Text)
								{
									((Control)EN).Text = text;
								}
								En.ValueChanged -= new EventHandler(a);
								En.Value = biC;
								En.ValueChanged += new EventHandler(a);
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					if (Er != null)
					{
						N.A((int)EV, P_0, Er.a(), 4, ER.aWR);
						EV = V.a.BIv;
					}
					Setting setting11 = ER.awP.C();
					N.A(setting11.ax(), P_0, setting11.a(), 4, ER.aWR);
					Setting setting12 = ER.awP.c();
					if (setting12 != null)
					{
						N.A(setting12.ax(), P_0, setting12.a(), 4, ER.aWR);
					}
					setting11 = ER.awP.b();
					N.A(setting11.ax(), P_0, setting11.a(), 4, ER.aWR);
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		return result;
	}

	private static void A(Framework P_0, Dk P_1, out Setting P_2, out Setting P_3, out Setting P_4)
	{
		P_2 = P_1.H();
		P_3 = P_1.h();
		P_4 = P_1.I();
		if (P_2.aD() == 0 || P_2.ad() == 0)
		{
			return;
		}
		Setting setting = P_0.A(P_2.ad());
		if (setting == null)
		{
			return;
		}
		Setting setting2 = null;
		if (setting.aE() != 0)
		{
			Setting setting3 = P_0.A(setting.aE());
			if (setting3 != null)
			{
				setting2 = P_0.A(setting3.ax());
			}
		}
		else if (setting.ae() != 0)
		{
			setting2 = P_0.A(setting.ae());
		}
		if (setting2 == null)
		{
			return;
		}
		Setting setting4 = P_0.A(new DataIdAndAttrId(setting2.A(), P_2.aD()));
		Setting setting5 = P_0.A(new DataIdAndAttrId(setting2.A(), P_3.aD()));
		Setting setting6 = P_0.A(new DataIdAndAttrId(setting2.A(), P_4.aD()));
		if (setting.ax() == 0)
		{
			if (setting4 != null)
			{
				P_2 = setting4;
			}
			if (setting5 != null)
			{
				P_3 = setting5;
			}
			if (setting6 != null)
			{
				P_4 = setting6;
			}
		}
	}
}
internal class v : Panel
{
	internal v()
	{
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)131072, true);
		((Control)this).SetStyle((ControlStyles)2, true);
	}
}
