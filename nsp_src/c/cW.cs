using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
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
	internal class cW : aM
	{
		private int BNr;

		private aM BNS;

		private int BNs;

		private aB BNT;

		internal static int BNt = 420;

		private const int BNU = 2;

		private const int BNu = 3;

		internal cW(int P_0, int P_1, int P_2, int P_3, int P_4, int P_5)
			: base(P_4, P_5)
		{
			BNr = P_0;
			int num = P_4 / BNr;
			int num2 = (int)((double)num * 0.7);
			BNs = num - num2;
			BNS = new aM(num2, P_5 - 4 + 1);
			BNT = new aB(P_0, P_2, P_3, P_1);
		}

		internal cW(int P_0, int[] P_1, int P_2, int P_3, int P_4)
			: base(P_3, P_4)
		{
			BNr = P_0;
			int num = P_3 / BNr;
			int num2 = (int)((double)num * 0.7);
			BNs = num - num2;
			BNS = new aM(num2, P_4 - 4 + 1);
			BNT = new aB(P_0, P_1, P_2);
		}

		internal Bitmap A(al P_0)
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			Bitmap val = new Bitmap(BNr * (BNS.a() + BNs) + BNs, BNS.A(), (PixelFormat)137224);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				SolidBrush val3 = new SolidBrush(BM.td);
				try
				{
					val2.FillRectangle((Brush)(object)val3, new Rectangle(0, 0, BNr * (BNS.a() + BNs) + BNs, BNS.A()));
				}
				finally
				{
					((System.IDisposable)val3)?.Dispose();
				}
				int num = BNS.A() - 6;
				for (int i = 0; i < BNr; i++)
				{
					int num2 = BNs + i * (BNS.a() + BNs);
					Color val4 = ((P_0 != 0 || !BNT.B()) ? BNT.B(i) : aa.A(0));
					SolidBrush val5 = new SolidBrush(val4);
					try
					{
						val2.FillRectangle((Brush)(object)val5, new Rectangle(num2, 3, BNS.a(), num));
					}
					finally
					{
						((System.IDisposable)val5)?.Dispose();
					}
				}
				return val;
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}

		[SpecialName]
		internal new bool A()
		{
			return BNT.B();
		}
	}
	internal class cw : MovableResizablePanel, Y
	{
		private new delegate void A(object P_0, EventArgs P_1);

		private const int Bnn = 5;

		private aq BnO = new aq();

		private Dictionary<MenuNode, aX> Bno = new Dictionary<MenuNode, aX>();

		private Framework BnP;

		private Framework Bnp;

		private MenuNode BnQ;

		private Rectangle Bnq;

		private int BnR = -1;

		internal cw(Framework P_0, Framework P_1, Rectangle P_2, bool P_3, bool P_4)
			: base(P_2, P_3, P_4, false)
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Expected O, but got Unknown
			BnP = P_0;
			Bnp = P_1;
			Bnq = P_2;
			_ = ((Control)BnO).Handle;
			((TabControl)BnO).SelectedIndex = -1;
			((Control)BnO).Left = 5;
			((Control)BnO).Top = 5;
			((TabControl)BnO).SelectedIndexChanged += new EventHandler(B);
			((Control)this).Controls.Add((Control)(object)BnO);
		}

		protected override void Dispose(bool disposing)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected O, but got Unknown
			try
			{
				((TabControl)BnO).SelectedIndexChanged -= new EventHandler(B);
				Enumerator<MenuNode, aX> enumerator = Bno.Values.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						q.A((Control)(object)enumerator.Current);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				Bno.Clear();
				if (BnP.awZ == 21)
				{
					for (int i = 0; i < BnP.awP.E().Count; i++)
					{
						DK dK = BnP.awP.E()[i];
						for (int j = 0; j < dK.a().Count; j++)
						{
							((SettingOrSpecialObject)dK.a()[j]).h()?.a(new EventHandler(b));
						}
					}
				}
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		[SpecialName]
		internal void A(MenuNode P_0)
		{
			BnQ = P_0;
		}

		public override string ToString()
		{
			string text = ((Panel)this).ToString();
			if (BnQ != null)
			{
				text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + BnQ.E();
			}
			return text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcU() + ((TabControl)BnO).TabPages.Count + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcu();
		}

		private void A(List<MenuNode> P_0, List<bool> P_1, List<bool> P_2, MenuNode P_3)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			Enumerator<MenuNode> enumerator = P_3.c().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					MenuNode current = enumerator.Current;
					if (!current.J())
					{
						if (num == 0 && P_1.Count != 0)
						{
							P_1[P_1.Count - 1] = true;
						}
						if (P_3 == BnQ && num != 0)
						{
							P_2[P_2.Count - 1] = true;
						}
						P_0.Add(current);
						P_1.Add(false);
						P_2.Add(false);
						num++;
						A(P_0, P_1, P_2, current);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		internal new int B()
		{
			int result = 1;
			A(ref result, BnQ.c()[0]);
			return result;
		}

		private void A(ref int P_0, MenuNode P_1)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			Enumerator<MenuNode> enumerator = P_1.c().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					MenuNode current = enumerator.Current;
					if (!current.J())
					{
						P_0++;
						A(ref P_0, current);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		internal void a(int P_0)
		{
			if (BnQ.K())
			{
				A(true, P_0);
				if (((TabControl)BnO).TabPages.Count != 0)
				{
					int num = B();
					if (BnQ.k())
					{
						if (P_0 == 0)
						{
							if (((TabControl)BnO).SelectedIndex != 0)
							{
								((TabControl)BnO).SelectedIndex = 0;
							}
						}
						else if (((TabControl)BnO).TabPages.Count > 1 && ((TabControl)BnO).SelectedIndex != 1 + (P_0 - 1) % num)
						{
							((TabControl)BnO).SelectedIndex = 1 + (P_0 - 1) % num;
						}
					}
					else if (((TabControl)BnO).SelectedIndex != P_0 % num)
					{
						((TabControl)BnO).SelectedIndex = P_0 % num;
					}
				}
			}
			else if (((TabControl)BnO).TabPages.Count > P_0 && ((TabControl)BnO).SelectedIndex != P_0)
			{
				((TabControl)BnO).SelectedIndex = P_0;
			}
			((Control)BnO).Visible = true;
		}

		internal void B(int P_0)
		{
			if (BnQ.K())
			{
				string text = null;
				if (((TabControl)BnO).SelectedIndex != -1)
				{
					text = ((Control)((TabControl)BnO).TabPages[((TabControl)BnO).SelectedIndex]).Text;
				}
				int num = B();
				bool flag = BnQ.k();
				if (BnR == P_0 && (!flag || ((TabControl)BnO).SelectedIndex != 0))
				{
					return;
				}
				BnR = P_0;
				if (flag)
				{
					A(true, 1 + P_0 * num);
				}
				else
				{
					A(true, P_0 * num);
				}
				if (((TabControl)BnO).TabPages.Count != 0)
				{
					int num2 = -1;
					if (!string.IsNullOrEmpty(text))
					{
						for (int i = (flag ? 1 : 0); i < ((TabControl)BnO).TabPages.Count; i++)
						{
							if (((Control)((TabControl)BnO).TabPages[i]).Text == text)
							{
								num2 = i;
								break;
							}
						}
					}
					if (num2 != -1)
					{
						if (((TabControl)BnO).SelectedIndex != num2)
						{
							((TabControl)BnO).SelectedIndex = num2;
						}
					}
					else if (flag && ((TabControl)BnO).TabPages.Count > 1)
					{
						if (((TabControl)BnO).SelectedIndex != 1)
						{
							((TabControl)BnO).SelectedIndex = 1;
						}
					}
					else if (((TabControl)BnO).SelectedIndex != 0)
					{
						((TabControl)BnO).SelectedIndex = 0;
					}
				}
			}
			((Control)BnO).Visible = true;
		}

		internal void A(bool P_0, int P_1 = 0)
		{
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_040c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0411: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03aa: Expected O, but got Unknown
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected O, but got Unknown
			//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ef: Expected O, but got Unknown
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Expected O, but got Unknown
			if (P_0)
			{
				((Control)BnO).Visible = false;
			}
			((Control)this).SuspendLayout();
			((Control)BnO).SuspendLayout();
			bool flag = BnQ.K();
			if (!P_0)
			{
				b();
			}
			else
			{
				((TabControl)BnO).SelectedIndex = -1;
				List<MenuNode> val = new List<MenuNode>();
				List<bool> val2 = new List<bool>();
				List<bool> val3 = new List<bool>();
				Enumerator<MenuNode> enumerator;
				if (flag)
				{
					if (BnQ.k())
					{
						val.Add(BnQ.C());
						val2.Add(true);
						val3.Add(false);
					}
					A(val, val2, val3, BnQ);
					val2[val2.Count - 1] = false;
					val3[val3.Count - 1] = false;
				}
				else
				{
					enumerator = BnQ.c().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							MenuNode current = enumerator.Current;
							val.Add(current);
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				bool flag2 = false;
				int num = 0;
				if (flag)
				{
					flag2 = BnQ.k();
					int i = P_1;
					if (i != 0 || !flag2)
					{
						for (; i != val3.Count && !val3[i]; i++)
						{
							num++;
						}
					}
				}
				enumerator = val.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						MenuNode current2 = enumerator.Current;
						bool flag3 = false;
						if (flag)
						{
							int num2 = val.IndexOf(current2);
							if (flag2)
							{
								if (P_1 == 0)
								{
									if (num2 != 0)
									{
										flag3 = true;
									}
								}
								else if (num2 != 0 && (num2 < P_1 || num2 > P_1 + num))
								{
									flag3 = true;
								}
							}
							else if (num2 < P_1 || num2 > P_1 + num)
							{
								flag3 = true;
							}
						}
						if (!flag3)
						{
							flag3 = current2.J(false);
						}
						if (flag3)
						{
							for (int j = 0; j < ((TabControl)BnO).TabPages.Count; j++)
							{
								aX aX = (aX)(object)((TabControl)BnO).TabPages[j];
								if (((ax)((Control)aX).Tag).Lk == current2)
								{
									((TabControl)BnO).SelectedIndexChanged -= new EventHandler(B);
									if (((TabControl)BnO).SelectedIndex == j)
									{
										((TabControl)BnO).SelectedIndex = -1;
									}
									bool num3 = ((TabControl)BnO).SelectedIndex == -1;
									((TabControl)BnO).TabPages.Remove((TabPage)(object)aX);
									if (num3 && ((TabControl)BnO).SelectedIndex != -1)
									{
										((TabControl)BnO).SelectedIndex = -1;
									}
									((TabControl)BnO).SelectedIndexChanged += new EventHandler(B);
									break;
								}
							}
							continue;
						}
						aX aX2;
						if (!Bno.ContainsKey(current2))
						{
							aX2 = new aX(A(current2, out var setting));
							((Control)aX2).Tag = new ax(current2, setting);
							((Control)aX2).SuspendLayout();
							aX2.A(val2.Count == val.Count && val2[val.IndexOf(current2)]);
							aX2.a(val3.Count == val.Count && val3[val.IndexOf(current2)]);
							((ScrollableControl)aX2).AutoScroll = false;
							((Panel)aX2).BorderStyle = (BorderStyle)0;
							((Control)aX2).BackColor = BM.tE;
							aF aF = new aF();
							((Control)aX2).Controls.Add((Control)(object)aF);
							((Control)aX2).ResumeLayout(true);
							Bno.Add(current2, aX2);
						}
						else
						{
							aX2 = Bno[current2];
						}
						if (!((TabControl)BnO).TabPages.Contains((TabPage)(object)aX2))
						{
							bool num4 = ((TabControl)BnO).SelectedIndex == -1;
							((TabControl)BnO).SelectedIndexChanged -= new EventHandler(B);
							((TabControl)BnO).TabPages.Add((TabPage)(object)aX2);
							if (num4 && ((TabControl)BnO).SelectedIndex != -1)
							{
								((TabControl)BnO).SelectedIndex = -1;
							}
							((TabControl)BnO).SelectedIndexChanged += new EventHandler(B);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				if (Bnq != Rectangle.Empty)
				{
					((Control)this).Width = ((Rectangle)(ref Bnq)).Width;
					((Control)this).Height = ((Rectangle)(ref Bnq)).Height;
					((Control)this).Left = ((Rectangle)(ref Bnq)).Left;
					((Control)this).Top = ((Rectangle)(ref Bnq)).Top;
				}
			}
			((Control)BnO).ResumeLayout(true);
			((Control)this).ResumeLayout(true);
			if (P_0)
			{
				if (!flag)
				{
					((Control)BnO).Visible = true;
				}
				if (((TabControl)BnO).SelectedIndex == -1 && ((TabControl)BnO).TabPages.Count != 0 && P_1 == 0)
				{
					((TabControl)BnO).SelectedIndex = 0;
				}
				((TabControl)BnO).SizeMode = (TabSizeMode)2;
				((TabControl)BnO).SizeMode = (TabSizeMode)0;
			}
		}

		private void A(bool P_0, MenuNode P_1, aF P_2, SettingOrSpecialObject P_3, SettingOrSpecialObject P_4)
		{
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_030c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Expected O, but got Unknown
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Expected O, but got Unknown
			if (P_3 is Table)
			{
				return;
			}
			if (P_3 is SpecialObject && (P_3 as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.Count != 0)
			{
				if (!P_0)
				{
					foreach (Control item in (ArrangedElementCollection)((Control)P_2).Controls)
					{
						Control val = item;
						if (val is DF && val.Tag == P_1)
						{
							(val as DF).A(false);
							break;
						}
					}
					return;
				}
				string text = string.Empty;
				if (P_1.Q())
				{
					text = P_1.E();
				}
				DF dF = new DF(P_3 as SpecialObject, text, P_1, BnP, Bnp, Rectangle.Empty, false, true);
				((Control)dF).Tag = P_1;
				((Control)dF).Left = 5;
				((Control)dF).Top = 5;
				((Control)P_2).Controls.Add((Control)(object)dF);
				dF.A(true);
			}
			else
			{
				if (P_4 != null)
				{
					return;
				}
				if (P_3 == null)
				{
					Enumerator<MenuNode> enumerator2 = P_1.c().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							if (!enumerator2.Current.J())
							{
								continue;
							}
							if (!P_0)
							{
								foreach (Control item2 in (ArrangedElementCollection)((Control)P_2).Controls)
								{
									Control val2 = item2;
									if (val2 is Df && val2.Tag == P_1)
									{
										(val2 as Df).A(false);
										break;
									}
								}
								break;
							}
							Df df = new Df(BnP, Bnp, Rectangle.Empty, false, true, true);
							df.A(P_1);
							((Control)df).Tag = P_1;
							((Control)df).Left = 5;
							((Control)df).Top = 0;
							((Control)P_2).Controls.Add((Control)(object)df);
							df.A(true);
							break;
						}
						return;
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
				}
				if (P_3 is SpecialObject)
				{
					if (P_3 is OnOffSwitchingPoint || P_3 is StateMachine || P_3 is WiFiSetup || P_3 is BezierCurve || (P_3 as SpecialObject).C().IdleText != null || (P_3 as SpecialObject).C().PreApplySettingDataIds.Count != 0 || P_3 is KnockDetection || P_3.f().DataIdOfChannelListSetting != 0)
					{
						return;
					}
					if (!P_0)
					{
						foreach (Control item3 in (ArrangedElementCollection)((Control)P_2).Controls)
						{
							Control val3 = item3;
							if (val3 is DF && val3.Tag == P_1)
							{
								(val3 as DF).A(false);
								break;
							}
						}
						return;
					}
					string text2 = string.Empty;
					if (P_1.Q())
					{
						text2 = P_1.E();
					}
					DF dF2 = new DF(P_3 as SpecialObject, text2, P_1, BnP, Bnp, Rectangle.Empty, false, true);
					((Control)dF2).Tag = P_1;
					((Control)dF2).Left = 5;
					((Control)dF2).Top = 5;
					((Control)P_2).Controls.Add((Control)(object)dF2);
					dF2.A(true);
				}
				else if (P_3 is SensorCalibration)
				{
					_ = (P_3 as SensorCalibration).CalibrationValuesSetting;
				}
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			b();
		}

		private new void b()
		{
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_035d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0364: Expected O, but got Unknown
			//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Expected O, but got Unknown
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Expected O, but got Unknown
			if (((TabControl)BnO).SelectedIndex == -1 || BM.qY)
			{
				return;
			}
			if (((TabControl)BnO).SelectedIndex == 0 && BnQ.K() && BnQ.k())
			{
				((TabControl)BnO).SelectedIndexChanged -= new EventHandler(B);
				while (((TabControl)BnO).TabPages.Count > 1)
				{
					((TabControl)BnO).TabPages.RemoveAt(1);
				}
				((TabControl)BnO).SelectedIndex = 0;
				((TabControl)BnO).SelectedIndexChanged += new EventHandler(B);
			}
			aX aX = ((TabControl)BnO).TabPages[((TabControl)BnO).SelectedIndex] as aX;
			MenuNode lk = ((ax)((Control)aX).Tag).Lk;
			int num = lk.b();
			int num2 = lk.H();
			SettingOrSpecialObject settingOrSpecialObject = BnP.a(num);
			SettingOrSpecialObject settingOrSpecialObject2 = BnP.a(num2);
			aF aF = null;
			foreach (Control item in (ArrangedElementCollection)((Control)aX).Controls)
			{
				Control val = item;
				if (val is aF)
				{
					aF = val as aF;
					break;
				}
			}
			if (aF == null)
			{
				return;
			}
			bool flag = ((ArrangedElementCollection)((Control)aF).Controls).Count == 0;
			if (flag)
			{
				((Control)BnO).Visible = false;
			}
			((Control)this).SuspendLayout();
			((Control)BnO).SuspendLayout();
			((Control)aX).SuspendLayout();
			A(flag, lk, aF, settingOrSpecialObject, settingOrSpecialObject2);
			if (flag)
			{
				if (Bnq == Rectangle.Empty)
				{
					int num3 = 0;
					int num4 = 0;
					foreach (aX tabPage in ((TabControl)BnO).TabPages)
					{
						foreach (Control item2 in (ArrangedElementCollection)((Control)tabPage).Controls)
						{
							Control val2 = item2;
							if (!(val2 is aF))
							{
								continue;
							}
							foreach (Control item3 in (ArrangedElementCollection)((Control)(val2 as aF)).Controls)
							{
								Control val3 = item3;
								num3 = Math.Max(num3, val3.Right + 10);
								num4 = Math.Max(num4, val3.Bottom + 10);
							}
							break;
						}
					}
					((Control)this).Width = 5 + num3 + 5;
					((Control)this).Height = 35 + num4 + 5;
				}
				((Control)BnO).Width = ((Control)this).Width - 10;
				((Control)BnO).Height = ((Control)this).Height - 10;
				foreach (aX tabPage2 in ((TabControl)BnO).TabPages)
				{
					((Control)tabPage2).SuspendLayout();
					((Control)tabPage2).Width = ((Control)BnO).Width;
					((Control)tabPage2).Height = ((Control)BnO).Height;
					foreach (Control item4 in (ArrangedElementCollection)((Control)tabPage2).Controls)
					{
						Control val4 = item4;
						if (val4 is aF)
						{
							aF obj = val4 as aF;
							((Control)obj).SuspendLayout();
							((Control)obj).Width = ((Control)tabPage2).Width;
							((Control)obj).Height = ((Control)tabPage2).Height;
							((Control)obj).ResumeLayout(true);
							break;
						}
					}
					((Control)tabPage2).ResumeLayout(true);
				}
			}
			((Control)aX).ResumeLayout(true);
			((Control)BnO).ResumeLayout(true);
			((Control)this).ResumeLayout(true);
			if (flag)
			{
				((Control)BnO).Visible = true;
			}
		}

		private string A(MenuNode P_0, out Setting P_1)
		{
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			string result = P_0.E();
			P_1 = null;
			if (P_0.M())
			{
				int num = P_0.C().C().m();
				int num2 = P_0.N();
				Dk dk = BnP.awP.E()[num].a()[num2];
				string text = ((SettingOrSpecialObject)dk).H();
				if (!string.IsNullOrWhiteSpace(text))
				{
					string text2 = dk.Bc();
					result = (string.IsNullOrEmpty(text2) ? text : (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()));
				}
				P_1 = ((SettingOrSpecialObject)dk).h();
				if (P_1 != null)
				{
					P_1.a(new EventHandler(b));
					P_1.A(new EventHandler(b));
				}
			}
			return result;
		}

		private void b(object P_0, EventArgs P_1)
		{
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)this).InvokeRequired)
			{
				try
				{
					A a = b;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			if (!(P_0 is Setting setting))
			{
				return;
			}
			Enumerator<MenuNode, aX> enumerator = Bno.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					aX current = enumerator.Current;
					ax ax = (ax)((Control)current).Tag;
					Setting lL = ax.LL;
					if (lL == setting)
					{
						MenuNode lk = ax.Lk;
						Setting setting2;
						string text = A(lk, out setting2);
						if (setting2 == lL)
						{
							((Control)current).Text = text;
							break;
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		public override void UpdateLayout(bool resizingOnly)
		{
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			((Control)this).SuspendLayout();
			((Control)BnO).SuspendLayout();
			((Control)BnO).Width = ((Control)this).Width - 10;
			((Control)BnO).Height = ((Control)this).Height - 10;
			foreach (aX tabPage in ((TabControl)BnO).TabPages)
			{
				((Control)tabPage).SuspendLayout();
				((Control)tabPage).Width = ((Control)BnO).Width;
				((Control)tabPage).Height = ((Control)BnO).Height;
				foreach (Control item in (ArrangedElementCollection)((Control)tabPage).Controls)
				{
					Control val = item;
					if (val is aF)
					{
						aF obj = val as aF;
						((Control)obj).SuspendLayout();
						((Control)obj).Width = ((Control)tabPage).Width;
						((Control)obj).Height = ((Control)tabPage).Height;
						((Control)obj).ResumeLayout(true);
						break;
					}
				}
				((Control)tabPage).ResumeLayout(true);
			}
			((Control)BnO).ResumeLayout(true);
			((Control)this).ResumeLayout(true);
		}

		public Control A(DataIdAndAttrId P_0)
		{
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected O, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			if (((TabControl)BnO).SelectedIndex != -1 && ((TabControl)BnO).SelectedIndex < ((TabControl)BnO).TabPages.Count && ((TabControl)BnO).TabPages[((TabControl)BnO).SelectedIndex] is aX aX)
			{
				foreach (Control item in (ArrangedElementCollection)((Control)aX).Controls)
				{
					Control val = item;
					if (!(val is aF))
					{
						continue;
					}
					foreach (Control item2 in (ArrangedElementCollection)((Control)(val as aF)).Controls)
					{
						Control val2 = item2;
						if (val2 is Y)
						{
							Control val3 = (val2 as Y).A(P_0);
							if (val3 != null)
							{
								return val3;
							}
						}
					}
					break;
				}
			}
			return null;
		}

		public Control A()
		{
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected O, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			if (((TabControl)BnO).SelectedIndex != -1 && ((TabControl)BnO).SelectedIndex < ((TabControl)BnO).TabPages.Count && ((TabControl)BnO).TabPages[((TabControl)BnO).SelectedIndex] is aX aX)
			{
				foreach (Control item in (ArrangedElementCollection)((Control)aX).Controls)
				{
					Control val = item;
					if (!(val is aF))
					{
						continue;
					}
					foreach (Control item2 in (ArrangedElementCollection)((Control)(val as aF)).Controls)
					{
						Control val2 = item2;
						if (val2 is Y)
						{
							Control val3 = (val2 as Y).A();
							if (val3 != null)
							{
								return val3;
							}
						}
					}
					break;
				}
			}
			return null;
		}
	}
}
namespace C
{
	internal class CW
	{
		internal bW BDy;

		internal List<ushort> BDZ;

		internal string BDz;

		internal string BdA;

		public virtual string ToString()
		{
			return ((object)BDy).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYn() + BDz;
		}
	}
	internal class Cw
	{
		internal bt Bda;

		internal k BdB;

		internal string Bdb;

		public virtual string ToString()
		{
			return string.Concat(new string[6]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYO(),
				((object)Bda).ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aN(),
				((object)BdB).ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aYn(),
				Bdb
			});
		}
	}
}
