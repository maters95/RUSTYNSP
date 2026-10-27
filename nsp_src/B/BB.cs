using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;
using c;

namespace B
{
	internal abstract class BB : Form
	{
		protected enum A
		{
			BOQ,
			BOq
		}

		protected class a
		{
			internal SettingOrSpecialObject BOR;

			internal WiringPin BOr;
		}

		protected delegate void B(object P_0, EventArgs P_1);

		protected delegate void b(object P_0, EventArgs P_1);

		[Serializable]
		[CompilerGenerated]
		private sealed class C
		{
			public static readonly C BOS = new C();

			public static Func<Label, bool> BOs;

			internal bool A(Label P_0)
			{
				return ((Control)P_0).Text.Contains('\n');
			}
		}

		protected const int mI = 10;

		protected const int mi = 7;

		protected const int mJ = 7;

		protected const int mj = 35;

		protected const int mK = 40;

		protected const int mk = 38;

		protected const int mL = 12;

		protected const int ml = 85;

		protected const int mM = 400;

		protected const int mm = 610;

		protected const int mN = 1030;

		protected const int mn = 160;

		protected const int mO = 30;

		protected const int mo = 1;

		protected const int mP = 2;

		protected const int mp = 3;

		internal bool mQ;

		internal Dn mq;

		protected bool mR = true;

		protected Bb mr;

		protected aF mS = new aF();

		protected int ms;

		protected List<Label> mT = new List<Label>();

		protected List<Label> mt = new List<Label>();

		protected List<List<int>> mU = new List<List<int>>();

		protected List<List<float>> mu = new List<List<float>>();

		protected List<List<string>> mV = new List<List<string>>();

		protected List<List<int>> mv = new List<List<int>>();

		protected List<List<bool>> mW = new List<List<bool>>();

		internal bool mw = true;

		internal bool mX = true;

		protected Cg mx;

		protected bool mY = true;

		protected CH my;

		protected bool mZ = true;

		protected Cg mz;

		protected CH NA;

		protected byte Na;

		protected ushort NB;

		protected WiringPin Nb;

		protected HashSet<Setting> NC = new HashSet<Setting>();

		protected static A Nc;

		protected static A ND;

		internal Ck Nd;

		internal static BB NE;

		protected Stopwatch Ne = new Stopwatch();

		internal abstract string A();

		protected virtual void a()
		{
			((Control)mS).SuspendLayout();
			c();
			if (F() == BB.A.BOq)
			{
				B();
			}
			else if (F() == BB.A.BOQ)
			{
				if (mQ)
				{
					if (mX)
					{
						C();
						ms += 40;
					}
					if (mw)
					{
						b();
					}
				}
				else
				{
					if (mw)
					{
						b();
						ms += 40;
					}
					if (mX)
					{
						C();
					}
				}
			}
			((Control)mS).ResumeLayout(true);
			D();
			A(false);
			if (mr != null)
			{
				mr.A();
			}
		}

		protected void B()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected O, but got Unknown
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_037c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0383: Expected O, but got Unknown
			//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cb: Expected O, but got Unknown
			Label val = new Label();
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IU();
			((Control)val).ForeColor = BM.te;
			((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8f, (FontStyle)1);
			((Control)val).AutoSize = true;
			((Control)val).Left = 10;
			((Control)val).Top = ms + 6;
			((Control)mS).Controls.Add((Control)(object)val);
			Label val2 = new Label();
			((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iu();
			((Control)val2).ForeColor = BM.te;
			((Control)val2).Font = new Font(((Control)val2).Font.FontFamily, 8f, (FontStyle)1);
			((Control)val2).AutoSize = true;
			((Control)val2).Left = 610;
			((Control)val2).Top = ms + 6;
			((Control)mS).Controls.Add((Control)(object)val2);
			ms += 25;
			Label val3 = new Label();
			((Control)val3).AutoSize = false;
			((Control)val3).Height = 1;
			((Control)val3).Width = ((Control)mS).Width;
			((Control)val3).Left = 0;
			((Control)val3).Top = ms;
			val3.BorderStyle = (BorderStyle)1;
			((Control)mS).Controls.Add((Control)(object)val3);
			for (int i = 0; i < PortFunction.A().Length; i++)
			{
				Cg cg = PortFunction.A()[i];
				if (!BM.Qz.awb.ContainsKey(cg))
				{
					continue;
				}
				string text = PortFunction.a(cg, BM.Qz);
				string text2 = PortFunction.B(cg, BM.Qz);
				if (!string.IsNullOrEmpty(text))
				{
					text2 = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IV();
				}
				Enumerator<Connector> enumerator = BM.Qz.awb[cg].GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Connector current = enumerator.Current;
						int top = ms + 16;
						ms += 35;
						bool flag = false;
						for (int j = 0; j < current.ayS.Count; j++)
						{
							WiringPin wiringPin = current.ayS.Values[j];
							if (!wiringPin.Bbq.l())
							{
								continue;
							}
							List<WiringPin.A> val4 = wiringPin.b();
							if (val4.Count == 0)
							{
								continue;
							}
							Cg bsk = val4[val4.Count - 1].Bsk;
							CH bsL = val4[val4.Count - 1].BsL;
							byte bsl = val4[val4.Count - 1].Bsl;
							ushort bsM = val4[val4.Count - 1].BsM;
							SettingOrSpecialObject settingOrSpecialObject = PortFunction.A(BM.Qz, bsk, bsL, bsl, bsM);
							if (settingOrSpecialObject == null || !settingOrSpecialObject.l() || (bsL == CH.BaF && !mQ) || !A(bsk, bsL))
							{
								continue;
							}
							List<bool> val5 = new List<bool>();
							List<string> val6 = PortFunction.A(BM.Qz, bsk, bsL, bsl, bsM, true, val5);
							if (val6 == null)
							{
								string text3 = PortFunction.B(BM.Qz, bsk, bsL, bsl, bsM);
								if (text3 != null)
								{
									if (mQ)
									{
										continue;
									}
									List<string> obj = new List<string>();
									obj.Add(text3);
									val6 = obj;
								}
							}
							if (((mw && val6 != null) || (mX && val6 == null)) && (!mQ || PortFunction.A(settingOrSpecialObject, mq)))
							{
								A(true, settingOrSpecialObject, val6, wiringPin, bsk, bsL, bsl, bsM, ref flag);
							}
						}
						if (!flag)
						{
							ms -= 35;
							continue;
						}
						Label val7 = new Label();
						((Control)val7).Text = current.ayr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iv() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo();
						((Control)val7).ForeColor = BM.te;
						((Control)val7).Font = new Font(((Control)val7).Font.FontFamily, 10f);
						((Control)val7).AutoSize = true;
						((Control)val7).Left = 10;
						((Control)val7).Top = top;
						((Control)mS).Controls.Add((Control)(object)val7);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
		}

		protected void b()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Expected O, but got Unknown
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Expected O, but got Unknown
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0256: Expected O, but got Unknown
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02be: Expected O, but got Unknown
			Label val = new Label();
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IW();
			((Control)val).ForeColor = BM.te;
			((Control)val).Font = new Font(((Control)val).Font.FontFamily, 12f, (FontStyle)1);
			((Control)val).AutoSize = true;
			((Control)val).Left = 10;
			((Control)val).Top = ms;
			((Control)mS).Controls.Add((Control)(object)val);
			ms += 30;
			Label val2 = new Label();
			((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IU();
			((Control)val2).ForeColor = BM.te;
			((Control)val2).Font = new Font(((Control)val2).Font.FontFamily, 8f, (FontStyle)1);
			((Control)val2).AutoSize = true;
			((Control)val2).Left = 10;
			((Control)val2).Top = ms + 6;
			((Control)mS).Controls.Add((Control)(object)val2);
			Label val3 = new Label();
			((Control)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iu();
			((Control)val3).ForeColor = BM.te;
			((Control)val3).Font = new Font(((Control)val3).Font.FontFamily, 8f, (FontStyle)1);
			((Control)val3).AutoSize = true;
			((Control)val3).Left = 610;
			((Control)val3).Top = ms + 6;
			((Control)mS).Controls.Add((Control)(object)val3);
			ms += 25;
			Label val4 = new Label();
			((Control)val4).AutoSize = false;
			((Control)val4).Height = 1;
			((Control)val4).Width = ((Control)mS).Width;
			((Control)val4).Left = 0;
			((Control)val4).Top = ms;
			val4.BorderStyle = (BorderStyle)1;
			((Control)mS).Controls.Add((Control)(object)val4);
			for (int i = 0; i < PortFunction.A().Length; i++)
			{
				Cg cg = PortFunction.A()[i];
				string text = PortFunction.a(cg, BM.Qz);
				string text2 = PortFunction.B(cg, BM.Qz);
				if (!string.IsNullOrEmpty(text))
				{
					text2 = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IV();
				}
				for (int j = 0; j < PortFunction.a().Length; j++)
				{
					CH cH = PortFunction.a()[j];
					int top = ms + 16;
					ms += 35;
					if (!A(true, cg, cH))
					{
						ms -= 35;
					}
					else if (mZ || cH == my)
					{
						Label val5 = new Label();
						if (cg == Cg.BAM)
						{
							((Control)val5).Text = PortFunction.A(cH) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo();
						}
						else
						{
							((Control)val5).Text = PortFunction.A(cH) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iv() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo();
						}
						((Control)val5).ForeColor = BM.te;
						((Control)val5).Font = new Font(((Control)val5).Font.FontFamily, 10f);
						((Control)val5).AutoSize = true;
						((Control)val5).Left = 10;
						((Control)val5).Top = top;
						((Control)mS).Controls.Add((Control)(object)val5);
					}
				}
			}
		}

		protected void C()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected O, but got Unknown
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Expected O, but got Unknown
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Expected O, but got Unknown
			Label val = new Label();
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iw();
			((Control)val).ForeColor = BM.te;
			((Control)val).Font = new Font(((Control)val).Font.FontFamily, 12f, (FontStyle)1);
			((Control)val).AutoSize = true;
			((Control)val).Left = 10;
			((Control)val).Top = ms;
			((Control)mS).Controls.Add((Control)(object)val);
			ms += 30;
			Label val2 = new Label();
			((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IU();
			((Control)val2).ForeColor = BM.te;
			((Control)val2).Font = new Font(((Control)val2).Font.FontFamily, 8f, (FontStyle)1);
			((Control)val2).AutoSize = true;
			((Control)val2).Left = 10;
			((Control)val2).Top = ms + 6;
			((Control)mS).Controls.Add((Control)(object)val2);
			ms += 25;
			Label val3 = new Label();
			((Control)val3).AutoSize = false;
			((Control)val3).Height = 1;
			((Control)val3).Width = ((Control)mS).Width;
			((Control)val3).Left = 0;
			((Control)val3).Top = ms;
			val3.BorderStyle = (BorderStyle)1;
			((Control)mS).Controls.Add((Control)(object)val3);
			for (int i = 0; i < PortFunction.A().Length; i++)
			{
				Cg cg = PortFunction.A()[i];
				string text = PortFunction.a(cg, BM.Qz);
				string text2 = PortFunction.B(cg, BM.Qz);
				if (!string.IsNullOrEmpty(text))
				{
					text2 = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IV();
				}
				for (int j = 0; j < PortFunction.a().Length; j++)
				{
					CH cH = PortFunction.a()[j];
					int top = ms + 16;
					ms += 35;
					if (!A(false, cg, cH))
					{
						ms -= 35;
					}
					else if (mZ || cH == my)
					{
						Label val4 = new Label();
						if (cg == Cg.BAM)
						{
							((Control)val4).Text = PortFunction.A(cH) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo();
						}
						else
						{
							((Control)val4).Text = PortFunction.A(cH) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iv() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo();
						}
						((Control)val4).ForeColor = BM.te;
						((Control)val4).Font = new Font(((Control)val4).Font.FontFamily, 10f);
						((Control)val4).AutoSize = true;
						((Control)val4).Left = 10;
						((Control)val4).Top = top;
						((Control)mS).Controls.Add((Control)(object)val4);
					}
				}
			}
		}

		protected void c()
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			while (((ArrangedElementCollection)((Control)mS).Controls).Count != 0)
			{
				q.A(((Control)mS).Controls[0]);
			}
			mT.Clear();
			mt.Clear();
			mU.Clear();
			mu.Clear();
			mW.Clear();
			((ScrollableControl)mS).AutoScrollPosition = new Point(0, 0);
			ms = 10;
		}

		protected void D()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Expected O, but got Unknown
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected O, but got Unknown
			mV.Clear();
			mv.Clear();
			Enumerator<Label> enumerator = mT.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Label current = enumerator.Current;
					List<string> val = new List<string>();
					List<int> val2 = new List<int>();
					SettingOrSpecialObject bOR = ((a)((Control)current).Tag).BOR;
					Cg bSQ = bOR.F().E().BSQ;
					CH bSq = bOR.F().E().BSq;
					byte bSR = bOR.F().E().BSR;
					ushort bSr = bOR.F().E().BSr;
					List<Dn> val3 = PortFunction.A(BM.Qz, bSQ, bSq, bSR, bSr, false);
					List<int> val4 = null;
					if (val3 != null && val3.Count == 1)
					{
						val4 = ((SettingOrSpecialObject)val3[0]).F().C();
					}
					for (int i = 0; i < bOR.F().b().Count; i++)
					{
						Setting setting = bOR.F().b()[i];
						int bBZ = ((SettingOrSpecialObject)setting).F().BBZ;
						if (bBZ == -1 || val4 == null || val4.Contains(bBZ))
						{
							setting.a(new EventHandler(B));
							setting.A(new EventHandler(B));
							int num = setting.aS();
							val.Add(bS.A(setting.@as(), num, false, 0));
							val2.Add(i);
						}
					}
					mV.Add(val);
					mv.Add(val2);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		protected void a(object P_0, EventArgs P_1)
		{
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)this).InvokeRequired)
			{
				try
				{
					B b = a;
					((Control)this).BeginInvoke((System.Delegate)b, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			if (BM.A(BM.Qz.aXc, true) && !BM.aE())
			{
				return;
			}
			Enumerator<Label> enumerator = mT.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((Control)enumerator.Current).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ft();
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = mt.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((Control)enumerator.Current).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		protected void B(object P_0, EventArgs P_1)
		{
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Expected O, but got Unknown
			//IL_052d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0534: Expected O, but got Unknown
			//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ca: Invalid comparison between Unknown and I4
			//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0401: Unknown result type (might be due to invalid IL or missing references)
			//IL_055b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0562: Expected O, but got Unknown
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0655: Unknown result type (might be due to invalid IL or missing references)
			//IL_065c: Expected O, but got Unknown
			//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ea: Expected O, but got Unknown
			//IL_0576: Unknown result type (might be due to invalid IL or missing references)
			//IL_057b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0670: Unknown result type (might be due to invalid IL or missing references)
			//IL_0675: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0603: Unknown result type (might be due to invalid IL or missing references)
			//IL_0589: Unknown result type (might be due to invalid IL or missing references)
			//IL_0683: Unknown result type (might be due to invalid IL or missing references)
			//IL_0611: Unknown result type (might be due to invalid IL or missing references)
			if (!Ne.IsRunning)
			{
				Ne.Start();
			}
			else
			{
				if (Ne.ElapsedMilliseconds < 800)
				{
					return;
				}
				if (((Control)this).InvokeRequired)
				{
					try
					{
						b b = B;
						((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
						return;
					}
					catch
					{
						return;
					}
				}
				Setting setting = P_0 as Setting;
				SettingOrSpecialObject settingOrSpecialObject = ((((SettingOrSpecialObject)setting).F().E().BSQ != Cg.BAM) ? ((SettingOrSpecialObject)setting).D() : setting);
				int num = 0;
				Enumerator<Label> enumerator = mT.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Label current = enumerator.Current;
						while (mW.Count < mT.Count)
						{
							mW.Add((List<bool>)null);
						}
						if (((a)((Control)current).Tag).BOR == settingOrSpecialObject)
						{
							bool flag = mW[num] == null;
							if (flag)
							{
								mW[num] = new List<bool>();
							}
							bool flag2 = false;
							for (int i = 0; i < settingOrSpecialObject.F().b().Count; i++)
							{
								if (BM.C(settingOrSpecialObject.F().b()[i].A()))
								{
									flag2 = true;
									break;
								}
							}
							Label val = mt[mT.IndexOf(current)];
							if ((!BM.A(BM.Qz.aXc, true) || BM.aE()) && !flag2)
							{
								((Control)current).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ft();
								((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
								if (flag)
								{
									for (int j = 0; j < settingOrSpecialObject.F().b().Count; j++)
									{
										mW[num].Add(false);
									}
								}
								break;
							}
							StringBuilder val2 = new StringBuilder();
							bool flag3 = false;
							for (int k = 0; k < settingOrSpecialObject.F().b().Count; k++)
							{
								if (flag)
								{
									mW[num].Add(false);
								}
								if (!mv[num].Contains(k))
								{
									continue;
								}
								Setting setting2 = settingOrSpecialObject.F().b()[k];
								if (flag || ((Control)current).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ft())
								{
									mW[num][k] = ((SettingOrSpecialObject)setting2).l() && PortFunction.A(setting2);
								}
								if (!mW[num][k])
								{
									continue;
								}
								int num2 = setting2.ax();
								int num3 = setting2.ar() - setting2.aR();
								if (num3 != 0)
								{
									if (mU[num].Count <= k)
									{
										while (mU[num].Count <= k)
										{
											mU[num].Add(0);
										}
										mU[num][k] = num2;
										while (mu[num].Count <= k)
										{
											mu[num].Add(0f);
										}
									}
									else
									{
										int num4 = num2 - mU[num][k];
										mU[num][k] = num2;
										if (num4 == -2147483648)
										{
											num4 = 2147483647;
										}
										float num5 = (float)Math.Abs(num4) / (float)num3;
										num5 = Math.Min(num5, 0.3f);
										if (num5 > mu[num][k])
										{
											mu[num][k] = num5;
										}
										else
										{
											List<float> val3 = mu[num];
											int num6 = k;
											val3[num6] *= 0.95f;
										}
										if (mu[num][k] > 0.03f)
										{
											flag3 = true;
										}
									}
								}
								ValueTuple<string, string, bool> val4 = setting2.A(num2, -1);
								string text = ((SettingOrSpecialObject)setting2).A(bz.aYu);
								if (!string.IsNullOrEmpty(text))
								{
									val2.Append(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FZ());
								}
								val2.Append(val4.Item1);
								int num7 = mv[num].IndexOf(k);
								if (!string.IsNullOrEmpty(val4.Item2))
								{
									if (mV[num][num7] == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IX())
									{
										val2.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ix());
									}
									else
									{
										val2.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + mV[num][num7]);
									}
								}
								if (num7 != mv[num].Count - 1)
								{
									val2.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IY());
								}
							}
							string text2 = ((object)val2).ToString();
							if (text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IY()))
							{
								text2 = text2.Substring(0, text2.Length - 3);
							}
							if (((Control)current).Parent != null)
							{
								Panel val5 = (Panel)((Control)current).Parent;
								if (flag3)
								{
									((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iy();
									foreach (Control item in (ArrangedElementCollection)((Control)val5).Controls)
									{
										Control val6 = item;
										if (val6 is Label)
										{
											Label val7 = (Label)(object)((val6 is Label) ? val6 : null);
											if (((Control)val7).ForeColor != Color.Green)
											{
												((Control)val7).ForeColor = Color.Green;
											}
										}
									}
								}
								else
								{
									((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
									if ((int)val5.BorderStyle == 2)
									{
										foreach (Control item2 in (ArrangedElementCollection)((Control)val5).Controls)
										{
											Control val8 = item2;
											if (val8 is Label)
											{
												Label val9 = (Label)(object)((val8 is Label) ? val8 : null);
												if (((Control)val9).ForeColor != Color.DeepSkyBlue)
												{
													((Control)val9).ForeColor = Color.DeepSkyBlue;
												}
											}
										}
									}
									else
									{
										foreach (Control item3 in (ArrangedElementCollection)((Control)val5).Controls)
										{
											Control val10 = item3;
											if (val10 is Label)
											{
												Label val11 = (Label)(object)((val10 is Label) ? val10 : null);
												if (((Control)val11).ForeColor != BM.te)
												{
													((Control)val11).ForeColor = BM.te;
												}
											}
										}
									}
								}
							}
							((Control)current).Text = text2;
							break;
						}
						num++;
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
		}

		protected bool A(bool P_0, Cg P_1, CH P_2)
		{
			bool result = false;
			for (int i = 0; i < BM.Qz.awD.Count; i++)
			{
				SettingOrSpecialObject settingOrSpecialObject = BM.Qz.awD[i];
				if (!settingOrSpecialObject.l())
				{
					continue;
				}
				Cg bSQ = settingOrSpecialObject.F().E().BSQ;
				CH bSq = settingOrSpecialObject.F().E().BSq;
				byte bSR = settingOrSpecialObject.F().E().BSR;
				ushort bSr = settingOrSpecialObject.F().E().BSr;
				if ((bSq == CH.BaF && !mQ) || bSQ != P_1 || bSq != P_2 || !A(P_1, bSq))
				{
					continue;
				}
				List<bool> val = new List<bool>();
				List<string> val2 = PortFunction.A(BM.Qz, bSQ, bSq, bSR, bSr, mQ || !P_0, val);
				if (val2 == null)
				{
					string text = PortFunction.B(BM.Qz, bSQ, bSq, bSR, bSr);
					if (text != null)
					{
						if (mQ)
						{
							continue;
						}
						List<string> obj = new List<string>();
						obj.Add(text);
						val2 = obj;
					}
				}
				if (((P_0 && val2 != null) || (!P_0 && val2 == null)) && (!mQ || PortFunction.A(settingOrSpecialObject, mq)))
				{
					A(P_0, settingOrSpecialObject, val2, null, bSQ, bSq, bSR, bSr, ref result);
				}
			}
			return result;
		}

		protected void A(bool P_0, SettingOrSpecialObject P_1, List<string> P_2, WiringPin P_3, Cg P_4, CH P_5, byte P_6, ushort P_7, ref bool P_8)
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected O, but got Unknown
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected O, but got Unknown
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Expected O, but got Unknown
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_048f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0496: Expected O, but got Unknown
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Expected O, but got Unknown
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ac: Expected O, but got Unknown
			//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Expected O, but got Unknown
			//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d8: Expected O, but got Unknown
			//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ec: Expected O, but got Unknown
			//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0520: Unknown result type (might be due to invalid IL or missing references)
			//IL_0527: Expected O, but got Unknown
			//IL_0531: Unknown result type (might be due to invalid IL or missing references)
			//IL_0561: Unknown result type (might be due to invalid IL or missing references)
			//IL_0566: Unknown result type (might be due to invalid IL or missing references)
			//IL_038e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0395: Expected O, but got Unknown
			//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b1: Expected O, but got Unknown
			//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c5: Expected O, but got Unknown
			//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_037c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Expected O, but got Unknown
			//IL_0868: Unknown result type (might be due to invalid IL or missing references)
			//IL_086d: Unknown result type (might be due to invalid IL or missing references)
			//IL_064d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0654: Expected O, but got Unknown
			//IL_0678: Unknown result type (might be due to invalid IL or missing references)
			//IL_0682: Expected O, but got Unknown
			//IL_068c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0696: Expected O, but got Unknown
			//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0576: Unknown result type (might be due to invalid IL or missing references)
			//IL_057d: Expected O, but got Unknown
			//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ab: Expected O, but got Unknown
			//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bf: Expected O, but got Unknown
			//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_08af: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0797: Unknown result type (might be due to invalid IL or missing references)
			//IL_079e: Expected O, but got Unknown
			//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cc: Expected O, but got Unknown
			//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e0: Expected O, but got Unknown
			//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0955: Unknown result type (might be due to invalid IL or missing references)
			//IL_095c: Expected O, but got Unknown
			//IL_0973: Unknown result type (might be due to invalid IL or missing references)
			//IL_0986: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d9: Expected O, but got Unknown
			//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ed: Expected O, but got Unknown
			//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a74: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c3b: Unknown result type (might be due to invalid IL or missing references)
			List<PictureBox> val = new List<PictureBox>();
			List<Label> val2 = new List<Label>();
			List<ThemedButton> val3 = new List<ThemedButton>();
			string text = string.Empty;
			List<WiringPin> val4 = WiringPin.A(BM.Qz, P_4, P_5, P_6, P_7);
			List<ApplyAndExecuteProcess> val5 = A(P_0, P_1, P_4, P_5, P_6, P_7);
			if (P_5 == CH.Bal || val4.Count == 0)
			{
				PictureBox val6 = new PictureBox();
				((Control)val6).BackColor = Color.Transparent;
				((Control)val6).Tag = new a
				{
					BOR = P_1,
					BOr = P_3
				};
				((Control)val6).MouseClick += new MouseEventHandler(A);
				((Control)val6).DoubleClick += new EventHandler(A);
				if (P_5 == CH.Bal)
				{
					val6.Image = (Image)(object)WiringPin.A(Color.Transparent, Color.Transparent, false, true, false);
				}
				else
				{
					val6.Image = PortFunction.A(P_4, P_5);
				}
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
				((Control)val6).Left = 5;
				val.Add(val6);
				val3.Add((ThemedButton)null);
				Label val7 = new Label();
				((Control)val7).Tag = new a
				{
					BOR = P_1,
					BOr = P_3
				};
				((Control)val7).MouseClick += new MouseEventHandler(A);
				((Control)val7).DoubleClick += new EventHandler(A);
				if (P_5 == CH.Bal)
				{
					((Control)val7).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IZ();
				}
				((Control)val7).ForeColor = BM.te;
				((Control)val7).AutoSize = true;
				((Control)val7).Left = ((Control)val6).Right + 3 + 85 + 2;
				((Control)val7).Top = 0;
				val2.Add(val7);
				if (((Control)val6).Height > 35)
				{
					((Control)val6).Top = 2;
				}
				else
				{
					((Control)val6).Top = ((Control)val7).Top - 3;
				}
			}
			else
			{
				bool flag = val4.Count > 1;
				if (P_3 != null)
				{
					List<WiringPin> obj = new List<WiringPin>();
					obj.Add(P_3);
					val4 = obj;
				}
				Enumerator<WiringPin> enumerator = val4.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						WiringPin current = enumerator.Current;
						a tag = ((P_3 != null) ? new a
						{
							BOR = P_1,
							BOr = P_3
						} : ((!flag) ? new a
						{
							BOR = P_1,
							BOr = null
						} : new a
						{
							BOR = P_1,
							BOr = current
						}));
						PictureBox val8 = new PictureBox();
						((Control)val8).BackColor = Color.Transparent;
						((Control)val8).Tag = tag;
						((Control)val8).MouseClick += new MouseEventHandler(A);
						((Control)val8).DoubleClick += new EventHandler(A);
						val8.Image = current.d();
						if (val8.Image != null)
						{
							((Control)val8).Height = val8.Image.Height;
							((Control)val8).Width = val8.Image.Width;
						}
						else
						{
							((Control)val8).Height = 35;
							((Control)val8).Width = 100;
						}
						((Control)val8).Left = 5;
						val.Add(val8);
						ThemedButton themedButton = null;
						if (current.e())
						{
							themedButton = new ThemedButton();
							((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iz();
							((Control)themedButton).Tag = tag;
							((Control)themedButton).AutoSize = false;
							((Control)themedButton).Width = 85;
							((Control)themedButton).Height = 23;
							((Control)themedButton).Left = ((Control)val8).Right + 3;
							((Control)themedButton).MouseClick += new MouseEventHandler(a);
						}
						val3.Add(themedButton);
						Label val9 = new Label();
						((Control)val9).Tag = tag;
						((Control)val9).MouseClick += new MouseEventHandler(A);
						((Control)val9).DoubleClick += new EventHandler(A);
						((Control)val9).Text = current.A(flag);
						((Control)val9).ForeColor = BM.te;
						((Control)val9).AutoSize = true;
						((Control)val9).Left = ((Control)val8).Right + 3 + 85 + 2;
						((Control)val9).Top = val2.Count * ((Control)val9).Height;
						val2.Add(val9);
						if (((Control)val8).Height > 35)
						{
							((Control)val8).Top = 2;
						}
						else
						{
							((Control)val8).Top = ((Control)val9).Top - 3;
						}
						if (themedButton != null)
						{
							((Control)themedButton).Top = ((Control)val8).Top;
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
			Label val10 = new Label();
			((Control)val10).AutoSize = true;
			string text2 = PortFunction.B(P_1);
			if (text2 != null)
			{
				((Control)val10).Tag = new a
				{
					BOR = P_1,
					BOr = P_3
				};
				((Control)val10).MouseClick += new MouseEventHandler(A);
				((Control)val10).DoubleClick += new EventHandler(A);
				((Control)val10).Text = text2;
				((Control)val10).ForeColor = BM.te;
				((Control)val10).Top = 0;
				((Control)val10).Left = 400;
			}
			Label val11 = null;
			if (!string.IsNullOrEmpty(text))
			{
				val11 = new Label();
				((Control)val11).Text = text;
				((Control)val11).ForeColor = Color.DarkOrange;
				((Control)val11).Left = 5;
				((Control)val11).Top = 5;
				((Control)val11).AutoSize = true;
			}
			List<Label> val12 = new List<Label>();
			if (P_2 != null)
			{
				Enumerator<string> enumerator2 = P_2.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						string current2 = enumerator2.Current;
						Label val13 = new Label();
						((Control)val13).Tag = new a
						{
							BOR = P_1,
							BOr = P_3
						};
						((Control)val13).MouseClick += new MouseEventHandler(A);
						((Control)val13).DoubleClick += new EventHandler(A);
						((Control)val13).Text = current2;
						((Control)val13).ForeColor = BM.te;
						((Control)val13).AutoSize = true;
						if (P_1.F().b().Count != 0)
						{
							((Control)val13).Top = -10;
						}
						else
						{
							((Control)val13).Top = 0;
						}
						((Control)val13).Left = 610;
						val12.Add(val13);
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
			Label val14 = null;
			Label val15 = null;
			if (P_1.F().b().Count != 0)
			{
				val14 = new Label();
				((Control)val14).Tag = new a
				{
					BOR = P_1,
					BOr = P_3
				};
				((Control)val14).MouseClick += new MouseEventHandler(A);
				((Control)val14).DoubleClick += new EventHandler(A);
				((Control)val14).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ft();
				((Control)val14).ForeColor = BM.te;
				((Control)val14).AutoSize = false;
				if (P_0 && P_2 != null && P_2.Count != 0)
				{
					((Control)val14).Top = 9;
				}
				else
				{
					bool flag2 = false;
					Enumerator<SettingOrSpecialObject> enumerator3 = P_1.a().GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							if (enumerator3.Current.B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ia()))
							{
								flag2 = true;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator3).Dispose();
					}
					((Control)val14).Top = (flag2 ? 9 : 0);
				}
				((Control)val14).Left = 610;
				((Control)val14).Width = ((Control)mS).Width - 18 - 160 - 610;
				((Control)val14).Height = (int)((float)((Control)val14).Height * 0.7f);
				mT.Add(val14);
				mu.Add(new List<float>());
				mU.Add(new List<int>());
				val15 = new Label();
				((Control)val15).Tag = new a
				{
					BOR = P_1,
					BOr = P_3
				};
				((Control)val15).MouseClick += new MouseEventHandler(A);
				((Control)val15).DoubleClick += new EventHandler(A);
				((Control)val15).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
				((Control)val15).ForeColor = Color.Green;
				((Control)val15).AutoSize = false;
				((Control)val15).Top = ((Control)val14).Top;
				((Control)val15).Left = ((Control)mS).Width - 18 - 160;
				((Control)val15).Width = 160;
				((Control)val15).Height = (int)((float)((Control)val15).Height * 0.7f);
				mt.Add(val15);
			}
			List<string> val16 = new List<string>(val12.Count);
			Enumerator<Label> enumerator4 = val12.GetEnumerator();
			try
			{
				while (enumerator4.MoveNext())
				{
					Label current3 = enumerator4.Current;
					val16.Add(((Control)current3).Text);
				}
			}
			finally
			{
				((System.IDisposable)enumerator4).Dispose();
			}
			List<string> val17 = new List<string>(val2.Count);
			enumerator4 = val2.GetEnumerator();
			try
			{
				while (enumerator4.MoveNext())
				{
					Label current4 = enumerator4.Current;
					val17.Add(((Control)current4).Text);
				}
			}
			finally
			{
				((System.IDisposable)enumerator4).Dispose();
			}
			if (!A(A(), P_5, P_4, ((Control)val10).Text, val16, val17))
			{
				return;
			}
			P_8 = true;
			int num = Enumerable.Count<Label>(Enumerable.Where<Label>((System.Collections.Generic.IEnumerable<Label>)val12, (Func<Label, bool>)((Label P_0) => ((Control)P_0).Text.Contains('\n'))));
			int num2 = 38 + num * 12;
			int num3 = A(val, val2, val3, val12, val14, val11, num2, false);
			Panel val18 = new Panel();
			((Control)val18).SuspendLayout();
			val18.BorderStyle = (BorderStyle)1;
			((Control)val18).BackColor = ((Control)mS).BackColor;
			((Control)val18).Location = new Point(-1, ms);
			((Control)val18).Size = new Size(((Control)mS).Width, num3 + 1);
			((Control)val18).Tag = new a
			{
				BOR = P_1,
				BOr = P_3
			};
			((Control)val18).MouseClick += new MouseEventHandler(A);
			((Control)val18).DoubleClick += new EventHandler(A);
			ms += num3;
			A(val, val2, val3, val12, null, val14, val15, val10, val11, num3, 38, false);
			enumerator4 = val12.GetEnumerator();
			try
			{
				while (enumerator4.MoveNext())
				{
					Label current5 = enumerator4.Current;
					((Control)val18).Controls.Add((Control)(object)current5);
				}
			}
			finally
			{
				((System.IDisposable)enumerator4).Dispose();
			}
			if (val14 != null)
			{
				((Control)val18).Controls.Add((Control)(object)val14);
			}
			if (val15 != null)
			{
				((Control)val18).Controls.Add((Control)(object)val15);
			}
			Enumerator<PictureBox> enumerator5 = val.GetEnumerator();
			try
			{
				while (enumerator5.MoveNext())
				{
					PictureBox current6 = enumerator5.Current;
					((Control)val18).Controls.Add((Control)(object)current6);
				}
			}
			finally
			{
				((System.IDisposable)enumerator5).Dispose();
			}
			enumerator4 = val2.GetEnumerator();
			try
			{
				while (enumerator4.MoveNext())
				{
					Label current7 = enumerator4.Current;
					((Control)val18).Controls.Add((Control)(object)current7);
				}
			}
			finally
			{
				((System.IDisposable)enumerator4).Dispose();
			}
			for (int i = 0; i < val3.Count; i++)
			{
				if (val3[i] != null)
				{
					((Control)val18).Controls.Add((Control)(object)val3[i]);
				}
			}
			((Control)val18).Controls.Add((Control)(object)val10);
			if (val11 != null)
			{
				((Control)val18).Controls.Add((Control)(object)val11);
			}
			int num4 = 0;
			for (int j = 0; j < val5.Count; j++)
			{
				string text3 = null;
				string text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iB();
				string text5 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ib();
				int num5 = 0;
				int num6 = 0;
				bool holdToExecuteOutputTest = val5[j].HoldToExecuteOutputTest;
				bool flag3 = ((SettingOrSpecialObject)val5[j].OwnerObject).B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iC());
				bool flag4 = ((SettingOrSpecialObject)val5[j].OwnerObject).c().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ic());
				num6 = ((!(!P_0 && holdToExecuteOutputTest) || flag3 || flag4) ? 1 : 2);
				for (int k = 0; k < num6; k++)
				{
					if (!P_0)
					{
						if (flag3)
						{
							text3 = (holdToExecuteOutputTest ? text5 : null);
							num5 = (holdToExecuteOutputTest ? 2 : 3);
						}
						else if (flag4)
						{
							text3 = (holdToExecuteOutputTest ? text4 : null);
							num5 = (holdToExecuteOutputTest ? 1 : 3);
						}
						else if (holdToExecuteOutputTest)
						{
							text3 = ((k == 0) ? text4 : text5);
							num5 = ((k == 0) ? 1 : 2);
						}
						else
						{
							num5 = 3;
						}
					}
					cg cg = new cg(val5[j].OwnerObject, BM.Qz, BM.Qn, Rectangle.Empty, false);
					cg.A(true, P_0, text3, num5);
					((Control)cg).Top = 0;
					((Control)cg).Left = 1030 + num4 * ((Control)cg).Width;
					((Control)val18).Controls.Add((Control)(object)cg);
					num4++;
				}
			}
			((Control)val18).ResumeLayout(false);
			((Control)mS).Controls.Add((Control)(object)val18);
		}

		private List<ApplyAndExecuteProcess> A(bool P_0, SettingOrSpecialObject P_1, Cg P_2, CH P_3, byte P_4, ushort P_5)
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			List<Dn> val = PortFunction.A(BM.Qz, P_2, P_3, P_4, P_5, false);
			PortFunction.a a = PortFunction.a(BM.Qz, P_2, P_3, P_4, P_5);
			List<ApplyAndExecuteProcess> val2 = new List<ApplyAndExecuteProcess>();
			Enumerator<SettingOrSpecialObject> enumerator = P_1.a().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					SettingOrSpecialObject current = enumerator.Current;
					if (!current.B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ia()) || !(current is SpecialObject specialObject) || (specialObject.C().IdleText == null && specialObject.C().PreApplySettingDataIds.Count == 0))
					{
						continue;
					}
					if (!P_0)
					{
						val2.Add(specialObject.C());
						continue;
					}
					bool flag = false;
					if (val != null && val.Count != 0)
					{
						Enumerator<Dn> enumerator2 = val.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								Dn current2 = enumerator2.Current;
								if (PortFunction.A(current, current2, null))
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
					}
					if (!flag)
					{
						flag = PortFunction.A(current, null, a);
					}
					if (flag)
					{
						val2.Add(specialObject.C());
					}
				}
				return val2;
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		protected void d()
		{
			mw = true;
			mX = false;
			a();
		}

		protected void E()
		{
			mw = false;
			mX = true;
			a();
		}

		protected void e()
		{
			mw = true;
			mX = true;
			a();
		}

		protected void A(bool P_0, string P_1)
		{
			if (P_0)
			{
				mY = true;
				if (mr != null)
				{
					mr.a();
				}
			}
			else
			{
				mY = false;
				Cg[] array = PortFunction.A();
				foreach (Cg cg in array)
				{
					if (P_1 == PortFunction.B(cg, BM.Qz))
					{
						mx = cg;
						if (mr != null)
						{
							mr.A(cg);
						}
						break;
					}
				}
			}
			a();
		}

		protected void a(bool P_0, string P_1)
		{
			if (P_0)
			{
				mZ = true;
			}
			else
			{
				mZ = false;
				CH[] array = PortFunction.a();
				foreach (CH cH in array)
				{
					if (P_1 == PortFunction.A(cH))
					{
						my = cH;
						break;
					}
				}
			}
			a();
		}

		internal bool A(Cg P_0, CH P_1)
		{
			if (mY || P_0 == mx)
			{
				if (!mZ)
				{
					return P_1 == my;
				}
				return true;
			}
			return false;
		}

		protected void b(object P_0, EventArgs P_1)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			Point autoScrollPosition = ((ScrollableControl)mS).AutoScrollPosition;
			a();
			((ScrollableControl)mS).AutoScrollPosition = new Point(-((Point)(ref autoScrollPosition)).X, -((Point)(ref autoScrollPosition)).Y);
			mS.a();
		}

		protected void A(A P_0)
		{
			if (mQ)
			{
				Nc = P_0;
			}
			else
			{
				ND = P_0;
			}
			a();
		}

		protected A F()
		{
			if (mQ)
			{
				return Nc;
			}
			return ND;
		}

		private void A(bool P_0)
		{
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fe: Expected O, but got Unknown
			//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e4: Expected O, but got Unknown
			//IL_0312: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02af: Expected O, but got Unknown
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_035b: Expected O, but got Unknown
			//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cc: Expected O, but got Unknown
			//IL_039c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a6: Expected O, but got Unknown
			if (mr != null)
			{
				if (mz == Cg.BAB || mz == Cg.BAM || NA == CH.BAU)
				{
					mr.C();
				}
				else
				{
					SettingOrSpecialObject settingOrSpecialObject = PortFunction.A(BM.Qz, mz, NA, Na, NB);
					mr.A(settingOrSpecialObject, Nb);
				}
			}
			foreach (Control item in (ArrangedElementCollection)((Control)mS).Controls)
			{
				Control val = item;
				if (!(val is Panel))
				{
					continue;
				}
				if (val.Tag is a)
				{
					SettingOrSpecialObject bOR = ((a)val.Tag).BOR;
					Cg bSQ = bOR.F().E().BSQ;
					CH bSq = bOR.F().E().BSq;
					byte bSR = bOR.F().E().BSR;
					ushort bSr = bOR.F().E().BSr;
					if (bSQ == Cg.BAM)
					{
						if (bSQ == mz && bSq == NA && bSr == NB)
						{
							((Panel)((val is Panel) ? val : null)).BorderStyle = (BorderStyle)2;
							if (P_0)
							{
								((ScrollableControl)mS).ScrollControlIntoView(val);
							}
						}
						else
						{
							((Panel)((val is Panel) ? val : null)).BorderStyle = (BorderStyle)1;
						}
					}
					else if (bSQ == mz && bSq == NA && bSR == Na)
					{
						((Panel)((val is Panel) ? val : null)).BorderStyle = (BorderStyle)2;
						if (P_0 && (Nb == null || ((a)val.Tag).BOr == null || ((a)val.Tag).BOr == Nb))
						{
							((ScrollableControl)mS).ScrollControlIntoView(val);
						}
					}
					else
					{
						((Panel)((val is Panel) ? val : null)).BorderStyle = (BorderStyle)1;
					}
				}
				foreach (Control item2 in (ArrangedElementCollection)val.Controls)
				{
					Control val2 = item2;
					if (!(val2 is Label) || !(val2.Tag is a))
					{
						continue;
					}
					SettingOrSpecialObject bOR2 = ((a)val2.Tag).BOR;
					Cg bSQ2 = bOR2.F().E().BSQ;
					CH bSq2 = bOR2.F().E().BSq;
					byte bSR2 = bOR2.F().E().BSR;
					ushort bSr2 = bOR2.F().E().BSr;
					if (bSQ2 == Cg.BAM)
					{
						if (bSQ2 == mz && bSq2 == NA && bSr2 == NB)
						{
							val2.ForeColor = Color.DeepSkyBlue;
							val2.Font = new Font(val2.Font.FontFamily, val2.Font.Size, (FontStyle)1);
						}
						else
						{
							val2.ForeColor = BM.te;
							val2.Font = new Font(val2.Font.FontFamily, val2.Font.Size);
						}
					}
					else if (bSQ2 == mz && bSq2 == NA && bSR2 == Na)
					{
						val2.ForeColor = Color.DeepSkyBlue;
						if (WiringPin.A(BM.Qz, bSQ2, bSq2, bSR2, bSr2).Count == 1)
						{
							val2.Font = new Font(val2.Font.FontFamily, val2.Font.Size, (FontStyle)1);
						}
						else if (Nb != null && ((a)val2.Tag).BOr == Nb)
						{
							val2.Font = new Font(val2.Font.FontFamily, val2.Font.Size, (FontStyle)3);
						}
						else
						{
							val2.Font = new Font(val2.Font.FontFamily, val2.Font.Size);
						}
					}
					else
					{
						val2.ForeColor = BM.te;
						val2.Font = new Font(val2.Font.FontFamily, val2.Font.Size);
					}
				}
			}
		}

		internal void A(WiringPin P_0)
		{
			List<WiringPin.A> val = P_0.b();
			if (val.Count != 0)
			{
				Nb = P_0;
				mz = val[val.Count - 1].Bsk;
				NA = val[val.Count - 1].BsL;
				Na = val[val.Count - 1].Bsl;
				NB = val[val.Count - 1].BsM;
				A(true);
			}
		}

		protected void A(object P_0, MouseEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)P_1.Button == 1048576)
			{
				SettingOrSpecialObject bOR = ((a)((Control)((P_0 is Control) ? P_0 : null)).Tag).BOR;
				if (bOR != null)
				{
					Nb = ((a)((Control)((P_0 is Control) ? P_0 : null)).Tag).BOr;
					mz = bOR.F().E().BSQ;
					NA = bOR.F().E().BSq;
					Na = bOR.F().E().BSR;
					NB = bOR.F().E().BSr;
					A(true);
					((Control)mS).Focus();
				}
			}
		}

		protected void a(object P_0, MouseEventArgs P_1)
		{
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Invalid comparison between Unknown and I4
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			if (((a)((Control)((P_0 is Control) ? P_0 : null)).Tag).BOR == null)
			{
				return;
			}
			A(P_0, P_1);
			WiringPin wiringPin = null;
			if (Nb != null)
			{
				wiringPin = Nb;
			}
			else
			{
				List<WiringPin> val = WiringPin.A(BM.Qz, mz, NA, Na, NB);
				if (val.Count == 1)
				{
					wiringPin = val[0];
				}
			}
			if (wiringPin == null || !wiringPin.e())
			{
				return;
			}
			bJ bJ = new bJ(wiringPin);
			if ((int)((Form)bJ).ShowDialog((IWin32Window)(object)this) == 1)
			{
				byte abd = bJ.abd;
				byte abE = bJ.abE;
				if (wiringPin.F() != WiringPin.A(WiringPin.BCd[abd - 1]) || wiringPin.f() != WiringPin.A(WiringPin.BCd[abE - 1]))
				{
					wiringPin.A(abd, abE);
					Point autoScrollPosition = ((ScrollableControl)mS).AutoScrollPosition;
					a();
					((ScrollableControl)mS).AutoScrollPosition = new Point(-((Point)(ref autoScrollPosition)).X, -((Point)(ref autoScrollPosition)).Y);
					mS.a();
				}
			}
			((Component)bJ).Dispose();
		}

		protected virtual void A(object P_0, EventArgs P_1)
		{
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Invalid comparison between Unknown and I4
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Invalid comparison between Unknown and I4
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Invalid comparison between Unknown and I4
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Invalid comparison between Unknown and I4
			if (((Control)mS).Focused)
			{
				if ((int)keyData == 38 || (int)keyData == 37)
				{
					f();
					return true;
				}
				if ((int)keyData == 40 || (int)keyData == 39)
				{
					G();
					return true;
				}
			}
			return q.A((Form)(object)this, keyData);
		}

		private void f()
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			if (mz == Cg.BAB)
			{
				return;
			}
			for (int num = g() - 1; num >= 0; num--)
			{
				Control obj = ((Control)mS).Controls[num];
				Panel val = (Panel)(object)((obj is Panel) ? obj : null);
				if (val != null)
				{
					A((object)val, new MouseEventArgs((MouseButtons)1048576, 1, 0, 0, 0));
					break;
				}
			}
		}

		private void G()
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			if (mz == Cg.BAB)
			{
				return;
			}
			for (int i = g() + 1; i < ((ArrangedElementCollection)((Control)mS).Controls).Count; i++)
			{
				Control obj = ((Control)mS).Controls[i];
				Panel val = (Panel)(object)((obj is Panel) ? obj : null);
				if (val != null)
				{
					A((object)val, new MouseEventArgs((MouseButtons)1048576, 1, 0, 0, 0));
					break;
				}
			}
		}

		private int g()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			foreach (Control item in (ArrangedElementCollection)((Control)mS).Controls)
			{
				Control val = item;
				if (!(val is Panel) || !(val.Tag is a))
				{
					continue;
				}
				SettingOrSpecialObject bOR = ((a)val.Tag).BOR;
				Cg bSQ = bOR.F().E().BSQ;
				CH bSq = bOR.F().E().BSq;
				byte bSR = bOR.F().E().BSR;
				ushort bSr = bOR.F().E().BSr;
				if (bSQ == Cg.BAM)
				{
					if (bSQ == mz && bSq == NA && bSr == NB)
					{
						return ((Control)mS).Controls.IndexOf(val);
					}
				}
				else if (bSQ == mz && bSq == NA && bSR == Na)
				{
					WiringPin bOr = ((a)val.Tag).BOr;
					if (Nb == null || bOr == Nb)
					{
						return ((Control)mS).Controls.IndexOf(val);
					}
				}
			}
			return -1;
		}

		internal static bool A(string P_0, CH P_1, Cg P_2, string P_3, List<string> P_4, List<string> P_5)
		{
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			bool result = true;
			List<string> val = new List<string>();
			if (P_0 != string.Empty)
			{
				for (int i = 1; i < P_0.Length; i++)
				{
					if (P_0[i] >= '0' && P_0[i] <= '9' && P_0[i - 1] != ' ' && (P_0[i - 1] < '0' || P_0[i - 1] > '9'))
					{
						P_0 = P_0.Substring(0, i) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + P_0.Substring(i, P_0.Length - i);
						i++;
					}
				}
				string[] array = P_0.Split(RuntimeHelpers.CreateSpan<char>((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/));
				for (int j = 0; j < array.Length; j++)
				{
					val.Add(array[j].ToLower());
				}
			}
			if (val.Count != 0)
			{
				Enumerator<string> enumerator = val.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						bool flag = P_3.ToLower().Contains(current);
						if (!flag)
						{
							flag = PortFunction.A(P_1).ToLower().Contains(current);
						}
						if (!flag && P_4 != null)
						{
							Enumerator<string> enumerator2 = P_4.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									if (enumerator2.Current.ToLower().Contains(current))
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
						}
						if (!flag && P_5 != null)
						{
							Enumerator<string> enumerator2 = P_5.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									if (enumerator2.Current.ToLower().Contains(current))
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
						}
						if (!flag)
						{
							string text = PortFunction.a(P_2, BM.Qz);
							if (!string.IsNullOrEmpty(text) && text.ToLower().Contains(current))
							{
								flag = true;
							}
						}
						if (!flag)
						{
							result = false;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			return result;
		}

		internal static int A(List<PictureBox> P_0, List<Label> P_1, List<ThemedButton> P_2, List<Label> P_3, Label P_4, Label P_5, int P_6, bool P_7)
		{
			int num = 0;
			num = (P_7 ? ((P_0.Count == 1 && ((Control)P_0[0]).Height + 16 > P_6 - 3) ? (((Control)P_0[0]).Height + 20) : ((P_1.Count < 2) ? P_6 : (P_6 + 23 * (P_1.Count - 1)))) : ((P_0.Count == 1 && ((Control)P_0[0]).Height > P_6 - 3) ? (((Control)P_0[0]).Height + 4) : ((P_1.Count < 2) ? P_6 : (P_6 + 23 * (P_1.Count - 1)))));
			if (P_3 != null && P_3.Count > 1)
			{
				int num2 = ((P_4 == null) ? (((Control)P_3[0]).Height * P_3.Count) : (((Control)P_3[0]).Height * P_3.Count + ((Control)P_4).Height));
				if (num2 > num - 3)
				{
					num = num2 + 4;
				}
			}
			if (P_5 != null)
			{
				num += 30;
			}
			return num;
		}

		internal static void A(List<PictureBox> P_0, List<Label> P_1, List<ThemedButton> P_2, List<Label> P_3, List<PictureBox> P_4, Label P_5, Label P_6, Label P_7, Label P_8, int P_9, int P_10, bool P_11)
		{
			//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c51: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c56: Unknown result type (might be due to invalid IL or missing references)
			int num = ((P_8 != null) ? (P_9 - 30) : P_9) / 2;
			if (P_1.Count == 0)
			{
				if (P_3 != null)
				{
					if (P_3.Count == 1)
					{
						Label obj = P_3[0];
						((Control)obj).Top = ((Control)obj).Top + (num - 7);
						if (P_4 != null && P_4.Count == 1)
						{
							PictureBox obj2 = P_4[0];
							((Control)obj2).Top = ((Control)obj2).Top + (num - 7);
						}
						if (P_5 != null)
						{
							((Control)P_5).Top = ((Control)P_5).Top + (num - 7);
							if (P_6 != null)
							{
								((Control)P_6).Top = ((Control)P_5).Top;
							}
						}
					}
					else if (P_3.Count != 0)
					{
						for (int i = 0; i < P_3.Count; i++)
						{
							((Control)P_3[i]).Top = 2 + i * ((Control)P_3[0]).Height;
							if (P_4 != null && P_4.Count == P_3.Count)
							{
								((Control)P_4[i]).Top = 2 + i * ((Control)P_3[0]).Height;
							}
						}
						if (P_5 != null)
						{
							((Control)P_5).Top = 2 + ((Control)P_3[0]).Height * P_3.Count;
							if (P_6 != null)
							{
								((Control)P_6).Top = ((Control)P_5).Top;
							}
						}
					}
					else if (P_5 != null)
					{
						((Control)P_5).Top = ((Control)P_5).Top + (num - 7);
						if (P_6 != null)
						{
							((Control)P_6).Top = ((Control)P_5).Top;
						}
					}
				}
				if (P_11 && P_0.Count != 0)
				{
					((Control)P_7).Top = 3;
				}
				else
				{
					((Control)P_7).Top = ((Control)P_7).Top + (num - 7);
				}
			}
			else if (P_1.Count == 1)
			{
				if (P_0.Count == 1)
				{
					if (((Control)P_0[0]).Height > P_10 - 3)
					{
						int num2 = ((Control)P_0[0]).Height / 2 - 7;
						if (P_11)
						{
							Label obj3 = P_1[0];
							((Control)obj3).Top = ((Control)obj3).Top + (num2 + 16);
							PictureBox obj4 = P_0[0];
							((Control)obj4).Top = ((Control)obj4).Top + 16;
							if (P_2 != null && P_2.Count == 1 && P_2[0] != null)
							{
								ThemedButton themedButton = P_2[0];
								((Control)themedButton).Top = ((Control)themedButton).Top + 16;
							}
							if (P_3 != null)
							{
								if (P_3.Count == 1)
								{
									if (((Control)P_3[0]).Text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy()))
									{
										Label obj5 = P_3[0];
										((Control)obj5).Top = ((Control)obj5).Top + (num2 - 2);
									}
									else
									{
										Label obj6 = P_3[0];
										((Control)obj6).Top = ((Control)obj6).Top + (num2 + 8);
									}
									if (P_4 != null && P_4.Count == 1)
									{
										PictureBox obj7 = P_4[0];
										((Control)obj7).Top = ((Control)obj7).Top + (num2 + 8);
									}
									if (P_5 != null)
									{
										((Control)P_5).Top = ((Control)P_5).Top + (num2 + 8);
										if (P_6 != null)
										{
											((Control)P_6).Top = ((Control)P_5).Top;
										}
									}
								}
								else if (P_3.Count != 0)
								{
									for (int j = 0; j < P_3.Count; j++)
									{
										((Control)P_3[j]).Top = 2 + j * ((Control)P_3[0]).Height;
										if (P_4 != null && P_4.Count == P_3.Count)
										{
											((Control)P_4[j]).Top = 2 + j * ((Control)P_3[0]).Height;
										}
									}
									if (P_5 != null)
									{
										((Control)P_5).Top = 2 + ((Control)P_3[0]).Height * P_3.Count;
										if (P_6 != null)
										{
											((Control)P_6).Top = ((Control)P_5).Top;
										}
									}
								}
								else if (P_5 != null)
								{
									((Control)P_5).Top = ((Control)P_5).Top + (num2 + 8);
									if (P_6 != null)
									{
										((Control)P_6).Top = ((Control)P_5).Top;
									}
								}
							}
							((Control)P_7).Top = 3;
						}
						else
						{
							Label obj8 = P_1[0];
							((Control)obj8).Top = ((Control)obj8).Top + num2;
							if (P_3 != null)
							{
								if (P_3.Count == 1)
								{
									if (((Control)P_3[0]).Text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy()))
									{
										Label obj9 = P_3[0];
										((Control)obj9).Top = ((Control)obj9).Top + (num2 - 10);
									}
									else
									{
										Label obj10 = P_3[0];
										((Control)obj10).Top = ((Control)obj10).Top + num2;
									}
									if (P_4 != null && P_4.Count == 1)
									{
										PictureBox obj11 = P_4[0];
										((Control)obj11).Top = ((Control)obj11).Top + num2;
									}
									if (P_5 != null)
									{
										((Control)P_5).Top = ((Control)P_5).Top + num2;
										if (P_6 != null)
										{
											((Control)P_6).Top = ((Control)P_5).Top;
										}
									}
								}
								else if (P_3.Count != 0)
								{
									for (int k = 0; k < P_3.Count; k++)
									{
										((Control)P_3[k]).Top = 2 + k * ((Control)P_3[0]).Height;
										if (P_4 != null && P_4.Count == P_3.Count)
										{
											((Control)P_4[k]).Top = 2 + k * ((Control)P_3[0]).Height;
										}
									}
									if (P_5 != null)
									{
										((Control)P_5).Top = 2 + ((Control)P_3[0]).Height * P_3.Count;
										if (P_6 != null)
										{
											((Control)P_6).Top = ((Control)P_5).Top;
										}
									}
								}
								else if (P_5 != null)
								{
									((Control)P_5).Top = ((Control)P_5).Top + num2;
									if (P_6 != null)
									{
										((Control)P_6).Top = ((Control)P_5).Top;
									}
								}
							}
							((Control)P_7).Top = ((Control)P_7).Top + num2;
						}
					}
					else if (P_11)
					{
						Label obj12 = P_1[0];
						((Control)obj12).Top = ((Control)obj12).Top + (num - 7 + 8);
						((Control)P_0[0]).Top = num - ((Control)P_0[0]).Height / 2 + 8;
						if (P_2 != null && P_2.Count == 1 && P_2[0] != null)
						{
							((Control)P_2[0]).Top = ((Control)P_0[0]).Top;
						}
						if (P_3 != null)
						{
							if (P_3.Count == 1)
							{
								if (((Control)P_3[0]).Text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy()))
								{
									Label obj13 = P_3[0];
									((Control)obj13).Top = ((Control)obj13).Top + (num - 17);
								}
								else
								{
									Label obj14 = P_3[0];
									((Control)obj14).Top = ((Control)obj14).Top + (num - 7);
								}
								if (P_4 != null && P_4.Count == 1)
								{
									PictureBox obj15 = P_4[0];
									((Control)obj15).Top = ((Control)obj15).Top + (num - 7);
								}
								if (P_5 != null)
								{
									((Control)P_5).Top = ((Control)P_5).Top + (num - 7);
									if (P_6 != null)
									{
										((Control)P_6).Top = ((Control)P_5).Top;
									}
								}
							}
							else if (P_3.Count != 0)
							{
								for (int l = 0; l < P_3.Count; l++)
								{
									((Control)P_3[l]).Top = 2 + l * ((Control)P_3[0]).Height;
									if (P_4 != null && P_4.Count == P_3.Count)
									{
										((Control)P_4[l]).Top = 2 + l * ((Control)P_3[0]).Height;
									}
								}
								if (P_5 != null)
								{
									((Control)P_5).Top = 2 + ((Control)P_3[0]).Height * P_3.Count;
									if (P_6 != null)
									{
										((Control)P_6).Top = ((Control)P_5).Top;
									}
								}
							}
							else if (P_5 != null)
							{
								((Control)P_5).Top = ((Control)P_5).Top + (num - 7);
								if (P_6 != null)
								{
									((Control)P_6).Top = ((Control)P_5).Top;
								}
							}
						}
						((Control)P_7).Top = 3;
					}
					else
					{
						Label obj16 = P_1[0];
						((Control)obj16).Top = ((Control)obj16).Top + (num - 7);
						((Control)P_0[0]).Top = num - ((Control)P_0[0]).Height / 2;
						if (P_2 != null && P_2.Count == 1 && P_2[0] != null)
						{
							((Control)P_2[0]).Top = ((Control)P_0[0]).Top;
						}
						if (P_3 != null)
						{
							if (P_3.Count == 1)
							{
								int num3 = 0;
								if (((Control)P_3[0]).Text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy()))
								{
									Label obj17 = P_3[0];
									((Control)obj17).Top = ((Control)obj17).Top + (num - 13);
									num3 = 6;
								}
								else
								{
									Label obj18 = P_3[0];
									((Control)obj18).Top = ((Control)obj18).Top + (num - 7);
								}
								if (P_4 != null && P_4.Count == 1)
								{
									PictureBox obj19 = P_4[0];
									((Control)obj19).Top = ((Control)obj19).Top + (num - 7);
								}
								if (P_5 != null)
								{
									((Control)P_5).Top = ((Control)P_5).Top + (num - 7 + num3);
									if (P_6 != null)
									{
										((Control)P_6).Top = ((Control)P_5).Top;
									}
								}
							}
							else if (P_3.Count != 0)
							{
								for (int m = 0; m < P_3.Count; m++)
								{
									((Control)P_3[m]).Top = 2 + m * ((Control)P_3[0]).Height;
									if (P_4 != null && P_4.Count == P_3.Count)
									{
										((Control)P_4[m]).Top = 2 + m * ((Control)P_3[0]).Height;
									}
								}
								if (P_5 != null)
								{
									((Control)P_5).Top = 2 + ((Control)P_3[0]).Height * P_3.Count;
									if (P_6 != null)
									{
										((Control)P_6).Top = ((Control)P_5).Top;
									}
								}
							}
							else if (P_5 != null)
							{
								((Control)P_5).Top = ((Control)P_5).Top + (num - 7);
								if (P_6 != null)
								{
									((Control)P_6).Top = ((Control)P_5).Top;
								}
							}
						}
						((Control)P_7).Top = ((Control)P_7).Top + (num - 7);
					}
				}
			}
			else
			{
				int num4;
				if (P_11)
				{
					if (P_3 != null)
					{
						if (P_3.Count == 1)
						{
							Label obj20 = P_3[0];
							((Control)obj20).Top = ((Control)obj20).Top + (num - 7);
							if (P_4 != null && P_4.Count == 1)
							{
								PictureBox obj21 = P_4[0];
								((Control)obj21).Top = ((Control)obj21).Top + (num - 7);
							}
							if (P_5 != null)
							{
								((Control)P_5).Top = ((Control)P_5).Top + (num - 7);
								if (P_6 != null)
								{
									((Control)P_6).Top = ((Control)P_5).Top;
								}
							}
						}
						else if (P_3.Count != 0)
						{
							for (int n = 0; n < P_3.Count; n++)
							{
								((Control)P_3[n]).Top = 2 + n * ((Control)P_3[0]).Height;
								if (P_4 != null && P_4.Count == P_3.Count)
								{
									((Control)P_4[n]).Top = 2 + n * ((Control)P_3[0]).Height;
								}
							}
							if (P_5 != null)
							{
								((Control)P_5).Top = 2 + ((Control)P_3[0]).Height * P_3.Count;
								if (P_6 != null)
								{
									((Control)P_6).Top = ((Control)P_5).Top;
								}
							}
						}
						else if (P_5 != null)
						{
							((Control)P_5).Top = ((Control)P_5).Top + (num - 7);
							if (P_6 != null)
							{
								((Control)P_6).Top = ((Control)P_5).Top;
							}
						}
					}
					((Control)P_7).Top = 3;
					num4 = num - 7 - ((Control)P_1[0]).Height * (P_1.Count - 1) / 2 + 8;
				}
				else
				{
					if (P_3 != null)
					{
						if (P_3.Count == 1)
						{
							Label obj22 = P_3[0];
							((Control)obj22).Top = ((Control)obj22).Top + (num - 7);
							if (P_4 != null && P_4.Count == 1)
							{
								PictureBox obj23 = P_4[0];
								((Control)obj23).Top = ((Control)obj23).Top + (num - 7);
							}
							if (P_5 != null)
							{
								((Control)P_5).Top = ((Control)P_5).Top + (num - 7);
								if (P_6 != null)
								{
									((Control)P_6).Top = ((Control)P_5).Top;
								}
							}
						}
						else if (P_3.Count != 0)
						{
							for (int num5 = 0; num5 < P_3.Count; num5++)
							{
								((Control)P_3[num5]).Top = 2 + num5 * ((Control)P_3[0]).Height;
								if (P_4 != null && P_4.Count == P_3.Count)
								{
									((Control)P_4[num5]).Top = 2 + num5 * ((Control)P_3[0]).Height;
								}
							}
							if (P_5 != null)
							{
								((Control)P_5).Top = 2 + ((Control)P_3[0]).Height * P_3.Count;
								if (P_6 != null)
								{
									((Control)P_6).Top = ((Control)P_5).Top;
								}
							}
						}
						else if (P_5 != null)
						{
							((Control)P_5).Top = ((Control)P_5).Top + (num - 7);
							if (P_6 != null)
							{
								((Control)P_6).Top = ((Control)P_5).Top;
							}
						}
					}
					((Control)P_7).Top = ((Control)P_7).Top + (num - 7);
					num4 = num - 7 - ((Control)P_1[0]).Height * (P_1.Count - 1) / 2;
				}
				Enumerator<Label> enumerator = P_1.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Label current = enumerator.Current;
						((Control)current).Top = ((Control)current).Top + num4;
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				Enumerator<PictureBox> enumerator2 = P_0.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						PictureBox current2 = enumerator2.Current;
						((Control)current2).Top = ((Control)current2).Top + num4;
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				if (P_2 != null)
				{
					for (int num6 = 0; num6 < P_2.Count; num6++)
					{
						if (P_2[num6] != null)
						{
							ThemedButton themedButton2 = P_2[num6];
							((Control)themedButton2).Top = ((Control)themedButton2).Top + num4;
						}
					}
				}
			}
			if (P_8 == null)
			{
				return;
			}
			if (P_7 != null)
			{
				((Control)P_7).Top = ((Control)P_7).Top + 30;
			}
			if (P_5 != null)
			{
				((Control)P_5).Top = ((Control)P_5).Top + 30;
			}
			if (P_6 != null)
			{
				((Control)P_6).Top = ((Control)P_6).Top + 30;
			}
			if (P_3 != null && P_3.Count != 0)
			{
				for (int num7 = 0; num7 < P_3.Count; num7++)
				{
					Label obj24 = P_3[num7];
					((Control)obj24).Top = ((Control)obj24).Top + 30;
				}
				if (P_4 != null && P_4.Count == P_3.Count)
				{
					for (int num8 = 0; num8 < P_4.Count; num8++)
					{
						PictureBox obj25 = P_4[num8];
						((Control)obj25).Top = ((Control)obj25).Top + 30;
					}
				}
			}
			if (P_0 != null && P_0.Count != 0)
			{
				for (int num9 = 0; num9 < P_0.Count; num9++)
				{
					PictureBox obj26 = P_0[num9];
					((Control)obj26).Top = ((Control)obj26).Top + 30;
				}
			}
			if (P_1 != null && P_1.Count != 0)
			{
				for (int num10 = 0; num10 < P_1.Count; num10++)
				{
					Label obj27 = P_1[num10];
					((Control)obj27).Top = ((Control)obj27).Top + 30;
				}
			}
			if (P_2 == null || P_2.Count == 0)
			{
				return;
			}
			for (int num11 = 0; num11 < P_2.Count; num11++)
			{
				if (P_2[num11] != null)
				{
					ThemedButton themedButton3 = P_2[num11];
					((Control)themedButton3).Top = ((Control)themedButton3).Top + 30;
				}
			}
		}
	}
	internal class Bb : Panel
	{
		internal class A : PictureBox
		{
			internal Cg BOT;

			private Bb BOt;

			private List<WiringPin> BOU = new List<WiringPin>();

			private List<WiringPin> BOu = new List<WiringPin>();

			internal A(Bb P_0, Cg P_1)
			{
				BOt = P_0;
				BOT = P_1;
			}

			internal void A()
			{
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
				BOU.Clear();
				BOu.Clear();
				Enumerator<WiringPin> enumerator = BM.Qz.awc.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						WiringPin current = enumerator.Current;
						List<WiringPin.A> val = current.b();
						if (val.Count == 0)
						{
							continue;
						}
						Cg bsk = val[val.Count - 1].Bsk;
						CH bsL = val[val.Count - 1].BsL;
						byte bsl = val[val.Count - 1].Bsl;
						ushort bsM = val[val.Count - 1].BsM;
						if (bsk != BOT || (!current.A() && !current.a()))
						{
							continue;
						}
						_ = current.BbX;
						if (((Size)(ref current.BbX)).Width == 0 || ((Size)(ref current.BbX)).Height == 0)
						{
							continue;
						}
						bool flag = false;
						if (BOt.NH.A(bsk, bsL))
						{
							List<bool> val2 = new List<bool>();
							List<string> val3 = PortFunction.A(BM.Qz, bsk, bsL, bsl, bsM, true, val2);
							if (val3 == null)
							{
								string text = PortFunction.B(BM.Qz, bsk, bsL, bsl, bsM);
								if (text != null)
								{
									List<string> obj = new List<string>();
									obj.Add(text);
									val3 = obj;
								}
							}
							if ((BOt.NH.mw && val3 != null) || (BOt.NH.mX && val3 == null))
							{
								SettingOrSpecialObject settingOrSpecialObject = PortFunction.A(BM.Qz, bsk, bsL, bsl, bsM);
								if (!BOt.NH.mQ || PortFunction.A(settingOrSpecialObject, BOt.NH.mq))
								{
									string text2 = PortFunction.B(settingOrSpecialObject);
									if (text2 == null)
									{
										text2 = string.Empty;
									}
									bool flag2 = WiringPin.A(BM.Qz, bsk, bsL, bsl, bsM).Count > 1;
									List<string> obj2 = new List<string>();
									obj2.Add(current.A(flag2));
									List<string> val4 = obj2;
									if (BB.A(BOt.NH.A(), bsL, bsk, text2, val3, val4))
									{
										flag = true;
									}
								}
							}
						}
						if (flag || bsL == CH.BAU)
						{
							BOU.Add(current);
						}
						else
						{
							BOu.Add(current);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}

			protected override void OnPaint(PaintEventArgs e)
			{
				//IL_0195: Unknown result type (might be due to invalid IL or missing references)
				//IL_019a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_011f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0124: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d3: Expected O, but got Unknown
				//IL_0145: Unknown result type (might be due to invalid IL or missing references)
				//IL_0224: Unknown result type (might be due to invalid IL or missing references)
				//IL_022e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0235: Expected O, but got Unknown
				((PictureBox)this).OnPaint(e);
				WiringPin wiringPin = null;
				if (BOt.NK != null && (BOt.NK.A() || BOt.NK.a()))
				{
					_ = BOt.NK.BbX;
					if (((Size)(ref BOt.NK.BbX)).Width != 0 && ((Size)(ref BOt.NK.BbX)).Height != 0)
					{
						List<WiringPin.A> val = BOt.NK.b();
						if (val.Count != 0 && val[val.Count - 1].Bsk == BOT)
						{
							wiringPin = BOt.NK;
						}
					}
				}
				List<WiringPin> val2 = new List<WiringPin>();
				Enumerator<WiringPin> enumerator;
				if (BOt.Nk != null)
				{
					PortFunction.B b = BOt.Nk.F().E();
					Cg bSQ = b.BSQ;
					CH bSq = b.BSq;
					byte bSR = b.BSR;
					ushort bSr = b.BSr;
					if (bSQ == BOT)
					{
						enumerator = WiringPin.A(BM.Qz, bSQ, bSq, bSR, bSr).GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								WiringPin current = enumerator.Current;
								if (current.A() || current.a())
								{
									_ = current.BbX;
									if (((Size)(ref current.BbX)).Width != 0 && ((Size)(ref current.BbX)).Height != 0)
									{
										val2.Add(current);
									}
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
					}
				}
				A(e.Graphics);
				enumerator = val2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						WiringPin current2 = enumerator.Current;
						if (BOt.NI || (val2.Count > 1 && current2 != wiringPin))
						{
							Pen val3 = new Pen(Color.DodgerBlue, 3f);
							try
							{
								A(e.Graphics, current2, 0, val3);
							}
							finally
							{
								((System.IDisposable)val3)?.Dispose();
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				if (wiringPin != null && val2.Count > 1 && BOt.NI)
				{
					Pen val4 = new Pen(Color.DodgerBlue, 3f);
					try
					{
						A(e.Graphics, wiringPin, 0, val4);
					}
					finally
					{
						((System.IDisposable)val4)?.Dispose();
					}
				}
				if (BOt.Nj != null)
				{
					List<WiringPin.A> val5 = BOt.Nj.b();
					if (val5.Count != 0 && val5[val5.Count - 1].Bsk == BOT)
					{
						A(e.Graphics, BOt.Nj, -2, Pens.DodgerBlue);
					}
				}
			}

			private void A(Graphics P_0)
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0168: Unknown result type (might be due to invalid IL or missing references)
				//IL_016d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0179: Unknown result type (might be due to invalid IL or missing references)
				//IL_0183: Unknown result type (might be due to invalid IL or missing references)
				//IL_018a: Expected O, but got Unknown
				//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
				Enumerator<WiringPin> enumerator = BOU.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						WiringPin current = enumerator.Current;
						List<WiringPin.A> val = current.b();
						if (val.Count == 0)
						{
							continue;
						}
						Cg bsk = val[val.Count - 1].Bsk;
						CH bsL = val[val.Count - 1].BsL;
						bool flag = bsL == CH.BAU || !current.Bbq.l();
						bool flag2 = bsk == Cg.BAJ || bsL == CH.Bal || current.BbU == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IZ() || current.BbU == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTU();
						Bitmap val2 = WiringPin.A(((Size)(ref current.BbX)).Width, ((Size)(ref current.BbX)).Height, current.F(), current.f(), current.Bbt, flag2, flag);
						try
						{
							if (current.A())
							{
								P_0.DrawImage((Image)(object)val2, ((Point)(ref current.BbW)).X - ((Size)(ref current.BbX)).Width / 2, ((Point)(ref current.BbW)).Y - ((Size)(ref current.BbX)).Height / 2);
							}
							else if (current.a())
							{
								P_0.DrawImage((Image)(object)val2, ((Point)(ref current.Bbw)).X, ((Point)(ref current.Bbw)).Y);
							}
						}
						finally
						{
							((System.IDisposable)val2)?.Dispose();
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				enumerator = BOu.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						WiringPin current2 = enumerator.Current;
						Pen val3 = new Pen(Color.Gray, 1f);
						try
						{
							A(P_0, current2, 0, val3);
						}
						finally
						{
							((System.IDisposable)val3)?.Dispose();
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}

			private void A(Graphics P_0, WiringPin P_1, int P_2, Pen P_3)
			{
				int num = ((Size)(ref P_1.BbX)).Width - 2 * P_2;
				int num2 = ((Size)(ref P_1.BbX)).Height - 2 * P_2;
				int num3 = 0;
				int num4 = 0;
				if (P_1.A())
				{
					num3 = ((Point)(ref P_1.BbW)).X + P_2 - ((Size)(ref P_1.BbX)).Width / 2;
					num4 = ((Point)(ref P_1.BbW)).Y + P_2 - ((Size)(ref P_1.BbX)).Height / 2;
				}
				else if (P_1.a())
				{
					num3 = ((Point)(ref P_1.Bbw)).X + P_2;
					num4 = ((Point)(ref P_1.Bbw)).Y + P_2;
				}
				if (P_1.Bbv)
				{
					P_0.DrawRectangle(P_3, num3, num4, num, num2);
					return;
				}
				P_0.SmoothingMode = (SmoothingMode)2;
				P_0.DrawEllipse(P_3, num3, num4, num, num2);
			}

			private WiringPin A(int P_0, int P_1, out Rectangle P_2)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_0015: Unknown result type (might be due to invalid IL or missing references)
				//IL_001a: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Unknown result type (might be due to invalid IL or missing references)
				//IL_0107: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
				P_2 = Rectangle.Empty;
				Enumerator<WiringPin> enumerator = BM.Qz.awc.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						WiringPin current = enumerator.Current;
						List<WiringPin.A> val = current.b();
						if (val.Count == 0 || val[val.Count - 1].Bsk != BOT || (!current.A() && !current.a()))
						{
							continue;
						}
						_ = current.BbX;
						if (((Size)(ref current.BbX)).Width == 0 || ((Size)(ref current.BbX)).Height == 0)
						{
							continue;
						}
						if (current.A())
						{
							int num = ((Size)(ref current.BbX)).Width / 2;
							int num2 = ((Size)(ref current.BbX)).Height / 2;
							P_2 = new Rectangle(((Point)(ref current.BbW)).X - num, ((Point)(ref current.BbW)).Y - num2, ((Size)(ref current.BbX)).Width, ((Size)(ref current.BbX)).Height);
						}
						else
						{
							P_2 = new Rectangle(current.Bbw, current.BbX);
						}
						if (((Rectangle)(ref P_2)).Contains(P_0, P_1))
						{
							if (val[val.Count - 1].BsL != 0 && current.Bbq.l())
							{
								return current;
							}
							return null;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				return null;
			}

			protected override void OnMouseClick(MouseEventArgs e)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Invalid comparison between Unknown and I4
				if ((int)e.Button != 1048576)
				{
					return;
				}
				Rectangle val;
				WiringPin wiringPin = A(e.X, e.Y, out val);
				if (wiringPin == null)
				{
					return;
				}
				List<WiringPin.A> val2 = wiringPin.b();
				if (val2.Count != 0)
				{
					Cg bsk = val2[val2.Count - 1].Bsk;
					CH bsL = val2[val2.Count - 1].BsL;
					byte bsl = val2[val2.Count - 1].Bsl;
					ushort bsM = val2[val2.Count - 1].BsM;
					SettingOrSpecialObject settingOrSpecialObject = PortFunction.A(BM.Qz, bsk, bsL, bsl, bsM);
					if (!BOt.NH.mQ || PortFunction.A(settingOrSpecialObject, BOt.NH.mq))
					{
						BOt.NH.A(wiringPin);
					}
				}
			}

			protected override void OnMouseMove(MouseEventArgs e)
			{
				((Control)this).OnMouseMove(e);
				Rectangle val;
				WiringPin wiringPin = A(e.X, e.Y, out val);
				if (wiringPin != null)
				{
					if (BOt.Nj != wiringPin)
					{
						BOt.Nj = wiringPin;
						((Control)this).Refresh();
					}
					if (wiringPin != BOt.NJ)
					{
						BOt.NJ = wiringPin;
						BOt.Ni.ShowAlways = true;
						BOt.Ni.InitialDelay = 100;
						BOt.Ni.ReshowDelay = 100;
						BOt.Ni.Active = true;
						BOt.Ni.Show(A(wiringPin), (IWin32Window)(object)this, ((Rectangle)(ref val)).Right, ((Rectangle)(ref val)).Top);
					}
				}
				else
				{
					if (BOt.Nj != null)
					{
						BOt.Nj = null;
						((Control)this).Refresh();
					}
					BOt.NJ = null;
					BOt.Ni.Active = false;
					BOt.Ni.Hide((IWin32Window)(object)this);
				}
			}

			protected override void OnMouseLeave(EventArgs e)
			{
				((Control)this).OnMouseLeave(e);
				if (BOt.Nj != null)
				{
					BOt.Nj = null;
					((Control)this).Refresh();
				}
				BOt.Ni.Active = false;
				BOt.Ni.Hide((IWin32Window)(object)this);
			}

			private string A(WiringPin P_0)
			{
				//IL_0015: Unknown result type (might be due to invalid IL or missing references)
				//IL_001a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
				string text = string.Empty;
				Cg cg = Cg.BAB;
				CH cH = CH.BAU;
				byte b = 0;
				ushort num = 0;
				Enumerator<WiringPin.A> enumerator = P_0.b().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						WiringPin.A current = enumerator.Current;
						List<bool> val = new List<bool>();
						List<string> val2 = PortFunction.A(BM.Qz, current.Bsk, current.BsL, current.Bsl, current.BsM, true, val);
						if (val2 == null)
						{
							string text2 = PortFunction.B(BM.Qz, current.Bsk, current.BsL, current.Bsl, current.BsM);
							if (text2 != null)
							{
								List<string> obj = new List<string>();
								obj.Add(text2);
								val2 = obj;
							}
						}
						if (val2 != null)
						{
							Enumerator<string> enumerator2 = val2.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									string current2 = enumerator2.Current;
									if (val2.IndexOf(current2) != 0)
									{
										text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy();
									}
									text += current2;
								}
							}
							finally
							{
								((System.IDisposable)enumerator2).Dispose();
							}
						}
						cg = current.Bsk;
						cH = current.BsL;
						b = current.Bsl;
						num = current.BsM;
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				bool flag = WiringPin.A(BM.Qz, cg, cH, b, num).Count > 1;
				SettingOrSpecialObject settingOrSpecialObject = PortFunction.A(BM.Qz, cg, cH, b, num);
				string text3 = P_0.A(flag);
				string text4 = string.Empty;
				if (!string.IsNullOrEmpty(text3))
				{
					text4 += text3;
				}
				string text5 = ((settingOrSpecialObject != null) ? PortFunction.B(settingOrSpecialObject) : null);
				if (!string.IsNullOrEmpty(text5))
				{
					text4 = text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text5 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
				}
				if (!string.IsNullOrEmpty(text))
				{
					if (!string.IsNullOrEmpty(text4))
					{
						text4 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ru();
					}
					text4 += text;
				}
				return text4;
			}

			protected override void Dispose(bool disposing)
			{
				try
				{
					((PictureBox)this).Dispose(disposing);
					if (((PictureBox)this).Image != null)
					{
						((PictureBox)this).Image.Dispose();
					}
				}
				catch
				{
				}
			}
		}

		internal class a : UserControl
		{
			internal Cg BOV;

			internal Label BOv;

			internal A BOW;

			internal a(Bb P_0, Cg P_1, Image P_2)
			{
				//IL_000e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_0023: Expected O, but got Unknown
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Expected O, but got Unknown
				//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
				BOV = P_1;
				((Control)this).BackColor = BM.tG;
				BOv = new Label();
				((Control)this).Controls.Add((Control)(object)BOv);
				((Control)BOv).BackColor = BM.tG;
				((Control)BOv).ForeColor = BM.te;
				((Control)BOv).Font = new Font(((Control)BOv).Font.FontFamily, 10f);
				if (P_1 == Cg.BAb)
				{
					((Control)BOv).Text = bx.b(BM.Qz.awZ, BM.Qz.awz);
				}
				else
				{
					((Control)BOv).Text = PortFunction.b(P_1, BM.Qz);
				}
				((Control)BOv).AutoSize = true;
				BOW = new A(P_0, P_1);
				((Control)this).Controls.Add((Control)(object)BOW);
				((Control)BOW).BackColor = BM.tG;
				((PictureBox)BOW).BorderStyle = (BorderStyle)0;
				((PictureBox)BOW).Image = P_2;
				((PictureBox)BOW).SizeMode = (PictureBoxSizeMode)2;
				((Control)this).Width = Math.Max(((Control)BOv).Width, ((Control)BOW).Width);
				((Control)this).Height = ((Control)BOv).Height + ((Control)BOW).Height;
				((Control)BOv).Left = ((Control)this).Width / 2 - ((Control)BOv).Width / 2;
				((Control)BOv).Top = 0;
				((Control)BOW).Left = ((Control)this).Width / 2 - ((Control)BOW).Width / 2;
				((Control)BOW).Top = ((Control)BOv).Height;
			}
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class B
		{
			public static readonly B BOw = new B();

			public static Func<KeyValuePair<Cg, string>, Cg> BOX;

			public static Func<KeyValuePair<Cg, string>, Cg> BOx;

			public static Func<KeyValuePair<Cg, string>, string> BOY;

			internal Cg A(KeyValuePair<Cg, string> P_0)
			{
				return P_0.Key;
			}

			internal Cg a(KeyValuePair<Cg, string> P_0)
			{
				return P_0.Key;
			}

			internal string B(KeyValuePair<Cg, string> P_0)
			{
				return P_0.Value;
			}
		}

		private const int NF = 40;

		private const int Nf = 5;

		private const int NG = 25;

		private const int Ng = 250;

		private BB NH;

		private Timer Nh = new Timer();

		private bool NI;

		private ToolTip Ni = new ToolTip();

		private WiringPin NJ;

		private WiringPin Nj;

		private WiringPin NK;

		private SettingOrSpecialObject Nk;

		private int NL;

		internal Bb(BB P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Expected O, but got Unknown
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Expected O, but got Unknown
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a2: Expected O, but got Unknown
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			NH = P_0;
			Enumerator<Cg, string> enumerator = Enumerable.ToDictionary<KeyValuePair<Cg, string>, Cg, string>((System.Collections.Generic.IEnumerable<KeyValuePair<Cg, string>>)Enumerable.OrderBy<KeyValuePair<Cg, string>, Cg>((System.Collections.Generic.IEnumerable<KeyValuePair<Cg, string>>)BM.Qz.awC, (Func<KeyValuePair<Cg, string>, Cg>)((KeyValuePair<Cg, string> P_0) => P_0.Key)), (Func<KeyValuePair<Cg, string>, Cg>)((KeyValuePair<Cg, string> P_0) => P_0.Key), (Func<KeyValuePair<Cg, string>, string>)((KeyValuePair<Cg, string> P_0) => P_0.Value)).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<Cg, string> current = enumerator.Current;
					Cg key = current.Key;
					string value = current.Value;
					if ((key == Cg.BAb || BM.Qz.A(PortFunction.A(key, BM.Qz))) && PortFunction.A(BM.Qz, key))
					{
						MemoryStream val = new MemoryStream(n.A(value));
						try
						{
							Image val2 = Image.FromStream((Stream)(object)val);
							a a = new a(this, key, val2);
							((Control)a).Name = ((ArrangedElementCollection)((Control)this).Controls).Count.ToString();
							((Control)a).Top = 5;
							((Control)this).Controls.Add((Control)(object)a);
							((Control)this).Height = Math.Max(((Control)this).Height, 5 + ((Control)a).Height + 5);
						}
						finally
						{
							((System.IDisposable)val)?.Dispose();
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			B();
			ThemedButton themedButton = new ThemedButton();
			((Control)themedButton).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iD();
			((Control)themedButton).Anchor = (AnchorStyles)5;
			((ButtonBase)themedButton).Image = BM.tR;
			((Control)themedButton).Width = 40;
			((Control)themedButton).Height = ((Control)this).Height - 3;
			((Control)themedButton).Top = 0;
			((Control)themedButton).Left = 0;
			((Control)this).Controls.Add((Control)(object)themedButton);
			((Control)themedButton).BringToFront();
			((Control)themedButton).Click += new EventHandler(A);
			ThemedButton themedButton2 = new ThemedButton();
			((Control)themedButton2).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.id();
			((Control)themedButton2).Anchor = (AnchorStyles)9;
			((ButtonBase)themedButton2).Image = BM.tr;
			((Control)themedButton2).Width = 40;
			((Control)themedButton2).Height = ((Control)this).Height - 3;
			((Control)themedButton2).Top = 0;
			((Control)themedButton2).Left = ((Control)this).Width - 40;
			((Control)this).Controls.Add((Control)(object)themedButton2);
			((Control)themedButton2).BringToFront();
			((Control)themedButton2).Click += new EventHandler(this.a);
			b();
			Nh.Interval = 250.0;
			Nh.SynchronizingObject = (ISynchronizeInvoke)(object)this;
			Nh.Elapsed += new ElapsedEventHandler(A);
			Nh.AutoReset = true;
			Nh.Enabled = true;
			Nh.Start();
		}

		protected override void Dispose(bool disposing)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			try
			{
				foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
				{
					item.Click -= new EventHandler(A);
					item.Click -= new EventHandler(a);
				}
				Nh.Stop();
				((Component)Nh).Dispose();
				Nh = null;
				((Control)this).Dispose(disposing);
			}
			catch
			{
			}
		}

		internal void A()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is a)
				{
					(val as a).BOW.A();
				}
			}
			foreach (Control item2 in (ArrangedElementCollection)((Control)this).Controls)
			{
				item2.Refresh();
			}
		}

		private void A(object P_0, ElapsedEventArgs P_1)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			NI = !NI;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				item.Refresh();
			}
		}

		protected override void OnResize(EventArgs eventargs)
		{
			((Panel)this).OnResize(eventargs);
			if (((Control)this).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iD()) && ((Control)this).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.id()))
			{
				b();
			}
		}

		internal void A(Cg P_0)
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			int num = -1;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is a)
				{
					num++;
					a a = val as a;
					if (a.BOV == P_0)
					{
						NL = num;
						((Control)a).Visible = true;
					}
					else
					{
						((Control)a).Visible = false;
					}
				}
			}
			B();
			((Control)this).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iD()].Visible = false;
			((Control)this).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.id()].Visible = false;
		}

		internal void a()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is a)
				{
					val.Visible = true;
				}
			}
			NL = 0;
			B();
			b();
			A(Nk, NK);
		}

		private void B()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			int num = 0;
			int num2 = -1;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is a)
				{
					num2++;
					if (num2 < NL)
					{
						a a = val as a;
						num += ((Control)a).Width + 25;
					}
				}
			}
			int num3 = 45;
			for (int i = 0; i < ((ArrangedElementCollection)((Control)this).Controls).Count; i++)
			{
				Control val2 = ((Control)this).Controls[i];
				if (val2 is a)
				{
					a a2 = val2 as a;
					((Control)a2).Left = num3 - num;
					num3 += ((Control)a2).Width + 25;
				}
			}
		}

		private void b()
		{
			((Control)this).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iD()].Visible = ((ArrangedElementCollection)((Control)this).Controls).Count > 3 && NL > 0;
			((Control)this).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.id()].Visible = ((ArrangedElementCollection)((Control)this).Controls).Count > 3 && NL < ((ArrangedElementCollection)((Control)this).Controls).Count - 3 && ((Control)this).Controls[(((ArrangedElementCollection)((Control)this).Controls).Count - 3).ToString()].Right > ((Control)this).Width - 40;
		}

		private void A(object P_0, EventArgs P_1)
		{
			NL--;
			B();
			b();
		}

		private void a(object P_0, EventArgs P_1)
		{
			NL++;
			B();
			b();
		}

		internal void A(SettingOrSpecialObject P_0, WiringPin P_1)
		{
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected O, but got Unknown
			Nk = P_0;
			NK = P_1;
			if (Nk != null)
			{
				int num = -1;
				foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
				{
					Control val = item;
					if (!(val is a))
					{
						continue;
					}
					num++;
					a a = val as a;
					if (a.BOV == Nk.F().E().BSQ)
					{
						if (((Control)a).Visible && (((Control)a).Left < 40 || ((Control)a).Right > ((Control)this).Width - 40))
						{
							NL = num;
							B();
							b();
						}
						break;
					}
				}
			}
			foreach (Control item2 in (ArrangedElementCollection)((Control)this).Controls)
			{
				item2.Refresh();
			}
		}

		internal void C()
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			Nk = null;
			NK = null;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				item.Refresh();
			}
		}
	}
}
namespace b
{
	internal class bB : Form
	{
		private const int ZB = 48;

		private const int Zb = 300;

		private Table ZC;

		private Setting Zc;

		private Setting ZD;

		private Setting Zd;

		private DataGridViewWithThemedScrollBars[] ZE = new DataGridViewWithThemedScrollBars[3];

		private aP[] Ze = new aP[3];

		private aI[] ZF = new aI[3];

		private Label[] Zf = (Label[])(object)new Label[3];

		private Label[] ZG = (Label[])(object)new Label[3];

		private Label[] Zg = (Label[])(object)new Label[3];

		private ThemedComboBox[] ZH = new ThemedComboBox[3];

		private PictureBox[] Zh = (PictureBox[])(object)new PictureBox[3];

		private ThemedButton[] ZI = new ThemedButton[3];

		private ThemedButton[] Zi = new ThemedButton[3];

		private ThemedButton[] ZJ = new ThemedButton[3];

		private ThemedButton[] Zj = new ThemedButton[3];

		private Label[] ZK = (Label[])(object)new Label[3];

		private PictureBox[] Zk = (PictureBox[])(object)new PictureBox[3];

		private bool[] ZL = new bool[3];

		private bool[] Zl = new bool[3];

		private bool[] ZM = new bool[3];

		private List<int>[] Zm = new List<int>[3];

		private Label ZN;

		private IContainer Zn;

		private aI ZO;

		private aI Zo;

		private aI ZP;

		private aP Zp;

		private aP ZQ;

		private aP Zq;

		private ThemedButton ZR;

		private ThemedButton Zr;

		private DataGridViewWithThemedScrollBars ZS;

		private DataGridViewWithThemedScrollBars Zs;

		private DataGridViewWithThemedScrollBars ZT;

		private Label Zt;

		private Label ZU;

		private Label Zu;

		private Label ZV;

		private Label Zv;

		private Label ZW;

		private ThemedButton Zw;

		private ThemedButton ZX;

		private ThemedButton Zx;

		private ThemedButton ZY;

		private ThemedButton Zy;

		private ThemedButton ZZ;

		private ThemedButton Zz;

		private ThemedButton zA;

		private ThemedButton za;

		private PictureBox zB;

		private PictureBox zb;

		private PictureBox zC;

		private Label zc;

		private Label zD;

		private Label zd;

		private ThemedComboBox zE;

		private ThemedComboBox ze;

		private ThemedComboBox zF;

		private Label zf;

		private Label zG;

		private Label zg;

		private ThemedButton zH;

		private ThemedButton zh;

		private ThemedButton zI;

		private PictureBox zi;

		private PictureBox zJ;

		private PictureBox zj;

		internal bB(Table P_0)
		{
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_034f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0355: Expected O, but got Unknown
			//IL_0366: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e0: Expected O, but got Unknown
			//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0430: Unknown result type (might be due to invalid IL or missing references)
			//IL_0446: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0730: Unknown result type (might be due to invalid IL or missing references)
			//IL_073a: Expected O, but got Unknown
			//IL_0751: Unknown result type (might be due to invalid IL or missing references)
			//IL_075b: Expected O, but got Unknown
			//IL_0783: Unknown result type (might be due to invalid IL or missing references)
			//IL_078d: Expected O, but got Unknown
			//IL_0772: Unknown result type (might be due to invalid IL or missing references)
			//IL_077c: Expected O, but got Unknown
			d();
			ZE[2] = ZS;
			ZE[1] = Zs;
			ZE[0] = ZT;
			Ze[2] = Zp;
			Ze[1] = ZQ;
			Ze[0] = Zq;
			ZF[2] = ZO;
			ZF[1] = Zo;
			ZF[0] = ZP;
			Zf[2] = Zu;
			Zf[1] = Zt;
			Zf[0] = ZU;
			ZG[2] = ZV;
			ZG[1] = ZW;
			ZG[0] = Zv;
			Zg[2] = zg;
			Zg[1] = zf;
			Zg[0] = zG;
			ZH[2] = zE;
			ZH[1] = ze;
			ZH[0] = zF;
			Zh[2] = zi;
			Zh[1] = zJ;
			Zh[0] = zj;
			ZI[2] = Zw;
			ZI[1] = ZZ;
			ZI[0] = za;
			Zi[2] = ZX;
			Zi[1] = Zy;
			Zi[0] = zA;
			ZJ[2] = Zx;
			ZJ[1] = ZY;
			ZJ[0] = Zz;
			Zj[2] = zH;
			Zj[1] = zh;
			Zj[0] = zI;
			ZK[2] = zc;
			ZK[1] = zD;
			ZK[0] = zd;
			Zk[2] = zB;
			Zk[1] = zb;
			Zk[0] = zC;
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label || val is CheckBox)
				{
					val.ForeColor = BM.te;
				}
				else if (val is DataGridViewWithThemedScrollBars)
				{
					typeof(DataGridViewWithThemedScrollBars).InvokeMember(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HG(), (BindingFlags)8228, (Binder)null, (object)(val as DataGridViewWithThemedScrollBars), new object[1] { true });
					((DataGridView)(val as DataGridViewWithThemedScrollBars)).BackgroundColor = BM.ti;
				}
			}
			ZN = new Label();
			((Control)ZN).BackColor = BM.tG;
			((Control)ZN).ForeColor = BM.te;
			ZN.BorderStyle = (BorderStyle)1;
			((Control)ZN).Visible = false;
			((Control)ZN).AutoSize = true;
			((Control)ZN).MinimumSize = new Size(300, 0);
			((Control)ZN).MaximumSize = new Size(300, 0);
			((Control)this).Controls.Add((Control)(object)ZN);
			ZC = P_0;
			for (int i = 0; i < 3; i++)
			{
				ZF[i].A(BM.Qz);
			}
			if (ZC.HorizAxis != null && ZC.HorizAxis.g() != null)
			{
				Zc = ZC.HorizAxis.h();
			}
			if (ZC.VertAxis != null && ZC.VertAxis.g() != null)
			{
				ZD = ZC.VertAxis.h();
			}
			if (ZC.SliceAxis != null && ZC.SliceAxis.g() != null)
			{
				Zd = ZC.SliceAxis.h();
			}
			string text = ((SettingOrSpecialObject)ZC).A(true);
			((Control)this).Text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zq();
			ZL[2] = ZC.HorizAxis != null && ZC.HorizAxis.D() != 0;
			ZM[2] = ZC.HorizAxis != null && ZC.HorizAxis.e() != 0;
			Zl[2] = ZC.HorizAxis != null && ZC.HorizAxis.E() != 0;
			ZL[1] = ZC.VertAxis != null && ZC.VertAxis.D() != 0;
			ZM[1] = ZC.VertAxis != null && ZC.VertAxis.e() != 0;
			Zl[1] = ZC.VertAxis != null && ZC.VertAxis.E() != 0;
			ZL[0] = ZC.SliceAxis != null && ZC.SliceAxis.D() != 0;
			ZM[0] = ZC.SliceAxis != null && ZC.SliceAxis.e() != 0;
			Zl[0] = ZC.SliceAxis != null && ZC.SliceAxis.E() != 0;
			if (ZC.HorizAxis != null)
			{
				Zm[2] = new List<int>();
			}
			if (ZC.VertAxis != null)
			{
				Zm[1] = new List<int>();
			}
			if (ZC.SliceAxis != null)
			{
				Zm[0] = new List<int>();
			}
			if (!ZM[2])
			{
				ZO.A(new EventHandler(a));
			}
			if (!ZM[1])
			{
				Zo.A(new EventHandler(B));
			}
			if (!ZM[0])
			{
				ZP.A(new EventHandler(b));
			}
			BM.C(new EventHandler(l));
		}

		private void A(object P_0, EventArgs P_1)
		{
			a();
			B();
			b();
			C();
			c();
			A();
			D();
			((Control)ZE[2]).Focus();
		}

		private void A()
		{
			for (int i = 0; i < 3; i++)
			{
				if (((Control)ZE[i]).Visible)
				{
					((DataGridView)ZE[i]).Columns.Clear();
					((DataGridView)ZE[i]).Rows.Clear();
					switch (i)
					{
					case 2:
						((DataGridView)ZE[i]).ColumnCount = ZC.HorizAxis.G().Ba();
						break;
					case 1:
						((DataGridView)ZE[i]).ColumnCount = ZC.VertAxis.G().Ba();
						break;
					case 0:
						((DataGridView)ZE[i]).ColumnCount = ZC.SliceAxis.G().Ba();
						break;
					}
					((DataGridView)ZE[i]).RowCount = 0;
					string[] array = new string[((DataGridView)ZE[i]).ColumnCount];
					for (int j = 0; j < ((DataGridView)ZE[i]).ColumnCount; j++)
					{
						array[j] = string.Empty;
						((DataGridView)ZE[i]).Columns[j].Width = 48;
						((DataGridView)ZE[i]).Columns[j].SortMode = (DataGridViewColumnSortMode)0;
					}
					DataGridViewRowCollection rows = ((DataGridView)ZE[i]).Rows;
					object[] array2 = array;
					rows.Add(array2);
					A((AxisType)i, true);
					ZE[i].C();
					((Control)ZE[i]).Enabled = ((Control)ZE[i]).Enabled && !Zl[i];
				}
			}
		}

		private void A(AxisType P_0, bool P_1)
		{
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_038a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			if (!((Control)ZE[(int)P_0]).Visible || !((Control)ZE[(int)P_0]).Enabled)
			{
				return;
			}
			for (int i = 0; i < ((DataGridView)ZE[(int)P_0]).ColumnCount; i++)
			{
				TableAxis tableAxis = null;
				Setting setting = null;
				switch (P_0)
				{
				case AxisType.Column:
					tableAxis = ZC.HorizAxis;
					setting = Zc;
					break;
				case AxisType.Row:
					tableAxis = ZC.VertAxis;
					setting = ZD;
					break;
				case AxisType.Slice:
					tableAxis = ZC.SliceAxis;
					setting = Zd;
					break;
				}
				if (setting == null)
				{
					continue;
				}
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				setting.A(ref num, ref num2, ref num3, ref num4);
				if (P_1)
				{
					if (i < tableAxis.f().ax())
					{
						int num5 = tableAxis.G().m(i);
						if (i == Zm[(int)P_0].Count && !Zm[(int)P_0].Contains(num5))
						{
							Zm[(int)P_0].Add(num5);
						}
						ValueTuple<string, string, bool> val = setting.A(num5, -1);
						((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Value = val.Item1;
						if (val.Item1.Length > 5)
						{
							((DataGridView)ZE[(int)P_0]).Columns[i].Width = val.Item1.Length * 10;
						}
						else
						{
							((DataGridView)ZE[(int)P_0]).Columns[i].Width = 48;
						}
						if ((string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Value == string.Empty)
						{
							((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Style.BackColor = Color.White;
						}
						else
						{
							((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Style.BackColor = A(setting, num5, num3, num4);
						}
					}
				}
				else if ((string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Value != string.Empty && i < Zm[(int)P_0].Count)
				{
					int num6 = Zm[(int)P_0][i];
					ValueTuple<string, string, bool> val2 = setting.A(num6, -1);
					((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Value = val2.Item1;
					if (val2.Item1.Length > 5)
					{
						((DataGridView)ZE[(int)P_0]).Columns[i].Width = val2.Item1.Length * 10;
					}
					else
					{
						((DataGridView)ZE[(int)P_0]).Columns[i].Width = 48;
					}
					if ((string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Value == string.Empty)
					{
						((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Style.BackColor = Color.White;
					}
					else
					{
						((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Style.BackColor = A(setting, num6, num3, num4);
					}
				}
			}
			ZE[(int)P_0].C();
		}

		private Color A(Setting P_0, int P_1, int P_2, int P_3)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			Enumerator<Setting.ListItems.A> enumerator = P_0.d(0).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					if (P_1 == enumerator.Current.bBv)
					{
						return Color.White;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (P_1 < P_2 || P_1 > P_3)
			{
				return Color.Red;
			}
			return Color.White;
		}

		private void a()
		{
			for (int i = 0; i < 3; i++)
			{
				A((AxisType)i);
			}
		}

		private void A(AxisType P_0)
		{
			TableAxis tableAxis = null;
			switch (P_0)
			{
			case AxisType.Column:
				tableAxis = ZC.HorizAxis;
				break;
			case AxisType.Row:
				tableAxis = ZC.VertAxis;
				break;
			case AxisType.Slice:
				tableAxis = ZC.SliceAxis;
				break;
			}
			if (tableAxis != null && tableAxis.a() && tableAxis.g() != null && tableAxis.f() != null && tableAxis.F() != null && tableAxis.G() != null)
			{
				((Control)Ze[(int)P_0]).Visible = true;
				((Control)ZF[(int)P_0]).Visible = true;
				((Control)Zf[(int)P_0]).Visible = true;
				((Control)ZG[(int)P_0]).Visible = true;
				((Control)ZE[(int)P_0]).Visible = true;
				((Control)ZI[(int)P_0]).Visible = true;
				((Control)Zi[(int)P_0]).Visible = true;
				((Control)ZJ[(int)P_0]).Visible = true;
				((Control)Zj[(int)P_0]).Visible = true;
				((Control)Zg[(int)P_0]).Visible = tableAxis.H() != null;
				((Control)ZH[(int)P_0]).Visible = tableAxis.H() != null;
				((Control)Zh[(int)P_0]).Visible = tableAxis.H() != null;
			}
			else
			{
				((Control)Ze[(int)P_0]).Visible = false;
				((Control)ZF[(int)P_0]).Visible = false;
				((Control)Zf[(int)P_0]).Visible = false;
				((Control)ZG[(int)P_0]).Visible = false;
				((Control)ZE[(int)P_0]).Visible = false;
				((Control)ZI[(int)P_0]).Visible = false;
				((Control)Zi[(int)P_0]).Visible = false;
				((Control)ZJ[(int)P_0]).Visible = false;
				((Control)Zj[(int)P_0]).Visible = false;
				((Control)Zg[(int)P_0]).Visible = false;
				((Control)ZH[(int)P_0]).Visible = false;
				((Control)Zh[(int)P_0]).Visible = false;
			}
		}

		private void B()
		{
			for (int i = 0; i < 3; i++)
			{
				a((AxisType)i);
			}
		}

		private void a(AxisType P_0)
		{
			if (((Control)Ze[(int)P_0]).Visible)
			{
				TableAxis tableAxis = null;
				switch (P_0)
				{
				case AxisType.Column:
					tableAxis = ZC.HorizAxis;
					break;
				case AxisType.Row:
					tableAxis = ZC.VertAxis;
					break;
				case AxisType.Slice:
					tableAxis = ZC.SliceAxis;
					break;
				}
				bool flag = tableAxis.F().ax() == 1;
				((CheckBox)Ze[(int)P_0]).Checked = flag;
				((Control)Ze[(int)P_0]).Enabled = !ZL[(int)P_0];
				((Control)ZF[(int)P_0]).Enabled = flag && !tableAxis.g().am() && !ZM[(int)P_0];
				((Control)Zf[(int)P_0]).Enabled = flag;
				((Control)ZG[(int)P_0]).Enabled = flag;
				((Control)ZE[(int)P_0]).Enabled = flag;
				((Control)ZI[(int)P_0]).Enabled = flag && !Zl[(int)P_0];
				((Control)Zi[(int)P_0]).Enabled = flag && !Zl[(int)P_0];
				((Control)ZJ[(int)P_0]).Enabled = flag && !Zl[(int)P_0];
				((Control)Zj[(int)P_0]).Enabled = flag && !Zl[(int)P_0];
				((Control)Zg[(int)P_0]).Enabled = flag;
			}
		}

		private void b()
		{
			for (int i = 0; i < 3; i++)
			{
				B((AxisType)i);
			}
		}

		private void B(AxisType P_0)
		{
			if (((Control)ZF[(int)P_0]).Visible)
			{
				Setting setting = null;
				switch (P_0)
				{
				case AxisType.Column:
					setting = Zc;
					break;
				case AxisType.Row:
					setting = ZD;
					break;
				case AxisType.Slice:
					setting = Zd;
					break;
				}
				if (setting == null)
				{
					ZF[(int)P_0].A(0);
					Label obj = ZK[(int)P_0];
					bool visible = (((Control)Zk[(int)P_0]).Visible = ((CheckBox)Ze[(int)P_0]).Checked);
					((Control)obj).Visible = visible;
				}
				else
				{
					ZF[(int)P_0].A(setting.A());
					Label obj2 = ZK[(int)P_0];
					bool visible = (((Control)Zk[(int)P_0]).Visible = ((CheckBox)Ze[(int)P_0]).Checked && (!((SettingOrSpecialObject)setting).l() || !PortFunction.A(setting)));
					((Control)obj2).Visible = visible;
				}
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			int num = -1;
			if (Zc != null)
			{
				num = Zc.aS();
			}
			Zc = BM.Qz.A(ZO.a());
			C();
			A(AxisType.Column, num == -1);
			Label obj = zc;
			bool visible = (((Control)zB).Visible = !((SettingOrSpecialObject)Zc).l() || !PortFunction.A(Zc));
			((Control)obj).Visible = visible;
			((Control)ZE[2]).Focus();
			c(AxisType.Column);
		}

		private void B(object P_0, EventArgs P_1)
		{
			int num = -1;
			if (ZD != null)
			{
				num = ZD.aS();
			}
			ZD = BM.Qz.A(Zo.a());
			C();
			A(AxisType.Row, num == -1);
			Label obj = zD;
			bool visible = (((Control)zb).Visible = !((SettingOrSpecialObject)ZD).l() || !PortFunction.A(ZD));
			((Control)obj).Visible = visible;
			((Control)ZE[1]).Focus();
			c(AxisType.Row);
		}

		private void b(object P_0, EventArgs P_1)
		{
			int num = -1;
			if (Zd != null)
			{
				num = Zd.aS();
			}
			Zd = BM.Qz.A(ZP.a());
			C();
			A(AxisType.Slice, num == -1);
			Label obj = zd;
			bool visible = (((Control)zC).Visible = !((SettingOrSpecialObject)Zd).l() || !PortFunction.A(Zd));
			((Control)obj).Visible = visible;
			((Control)ZE[0]).Focus();
			c(AxisType.Slice);
		}

		private void C()
		{
			for (int i = 0; i < 3; i++)
			{
				b((AxisType)i);
			}
		}

		private void b(AxisType P_0)
		{
			if (((Control)Zf[(int)P_0]).Visible)
			{
				Setting setting = null;
				switch (P_0)
				{
				case AxisType.Column:
					setting = Zc;
					break;
				case AxisType.Row:
					setting = ZD;
					break;
				case AxisType.Slice:
					setting = Zd;
					break;
				}
				if (setting != null)
				{
					string text = bS.A(setting.@as(), setting.aS(), false, 0);
					((Control)Zf[(int)P_0]).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZR() + text;
				}
			}
		}

		private void c()
		{
			for (int i = 0; i < 3; i++)
			{
				C((AxisType)i);
			}
		}

		private void C(AxisType P_0)
		{
			if (((Control)ZG[(int)P_0]).Visible)
			{
				TableAxis tableAxis = null;
				switch (P_0)
				{
				case AxisType.Column:
					tableAxis = ZC.HorizAxis;
					break;
				case AxisType.Row:
					tableAxis = ZC.VertAxis;
					break;
				case AxisType.Slice:
					tableAxis = ZC.SliceAxis;
					break;
				}
				((Control)ZG[(int)P_0]).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zr() + tableAxis.G().Ba();
			}
		}

		private void D()
		{
			for (int i = 0; i < 3; i++)
			{
				c((AxisType)i);
			}
		}

		private void c(AxisType P_0)
		{
			if (((Control)ZH[(int)P_0]).Visible)
			{
				TableAxis tableAxis = null;
				Setting setting = null;
				switch (P_0)
				{
				case AxisType.Column:
					tableAxis = ZC.HorizAxis;
					setting = Zc;
					break;
				case AxisType.Row:
					tableAxis = ZC.VertAxis;
					setting = ZD;
					break;
				case AxisType.Slice:
					tableAxis = ZC.SliceAxis;
					setting = Zd;
					break;
				}
				bool flag = ((ComboBox)ZH[(int)P_0]).Items.Count == 0;
				List<Setting.ListItems.A> val = tableAxis.H().d(0);
				for (int i = 0; i < val.Count; i++)
				{
					if (flag)
					{
						((ComboBox)ZH[(int)P_0]).Items.Add((object)val[i].bBV);
					}
					if (setting != null && setting.x() != -1)
					{
						if (val[i].bBv == setting.x())
						{
							((ListControl)ZH[(int)P_0]).SelectedIndex = i;
						}
					}
					else if (val[i].bBv == tableAxis.H().ax() && flag)
					{
						((ListControl)ZH[(int)P_0]).SelectedIndex = i;
					}
				}
				if (setting != null && setting.x() != -1)
				{
					((Control)ZH[(int)P_0]).Enabled = false;
				}
				else
				{
					((Control)ZH[(int)P_0]).Enabled = ((CheckBox)Ze[(int)P_0]).Checked;
				}
				((Control)Zh[(int)P_0]).Visible = ((CheckBox)Ze[(int)P_0]).Checked;
			}
			else
			{
				((Control)Zh[(int)P_0]).Visible = false;
			}
		}

		private void D(AxisType P_0)
		{
			((Control)ZN).Visible = false;
			if (!ZL[(int)P_0])
			{
				TableAxis tableAxis = null;
				Setting setting = null;
				switch (P_0)
				{
				case AxisType.Column:
					tableAxis = ZC.HorizAxis;
					setting = Zc;
					break;
				case AxisType.Row:
					tableAxis = ZC.VertAxis;
					setting = ZD;
					break;
				case AxisType.Slice:
					tableAxis = ZC.SliceAxis;
					setting = Zd;
					break;
				}
				bool @checked = ((CheckBox)Ze[(int)P_0]).Checked;
				((Control)ZF[(int)P_0]).Enabled = @checked && !tableAxis.g().am() && !ZM[(int)P_0];
				((Control)Zf[(int)P_0]).Enabled = @checked;
				((Control)ZG[(int)P_0]).Enabled = @checked;
				((Control)ZE[(int)P_0]).Enabled = @checked && !Zl[(int)P_0];
				((Control)ZI[(int)P_0]).Enabled = @checked && !Zl[(int)P_0];
				((Control)Zi[(int)P_0]).Enabled = @checked && !Zl[(int)P_0];
				((Control)ZJ[(int)P_0]).Enabled = @checked && !Zl[(int)P_0];
				((Control)Zj[(int)P_0]).Enabled = @checked && !Zl[(int)P_0];
				((Control)Zg[(int)P_0]).Enabled = @checked;
				c(P_0);
				Label obj = ZK[(int)P_0];
				bool visible = (((Control)Zk[(int)P_0]).Visible = @checked && (setting == null || !((SettingOrSpecialObject)setting).l() || !PortFunction.A(setting)));
				((Control)obj).Visible = visible;
			}
		}

		private void C(object P_0, EventArgs P_1)
		{
			D(AxisType.Column);
		}

		private void c(object P_0, EventArgs P_1)
		{
			D(AxisType.Row);
		}

		private void D(object P_0, EventArgs P_1)
		{
			D(AxisType.Slice);
		}

		private void d(AxisType P_0)
		{
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Invalid comparison between Unknown and I4
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			((Control)ZN).Visible = false;
			if (!((Control)Ze[(int)P_0]).Visible || !((CheckBox)Ze[(int)P_0]).Checked)
			{
				return;
			}
			TableAxis tableAxis = null;
			Setting setting = null;
			switch (P_0)
			{
			case AxisType.Column:
				tableAxis = ZC.HorizAxis;
				setting = Zc;
				break;
			case AxisType.Row:
				tableAxis = ZC.VertAxis;
				setting = ZD;
				break;
			case AxisType.Slice:
				tableAxis = ZC.SliceAxis;
				setting = Zd;
				break;
			}
			if (setting == null)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZS(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			int num = Math.Min(tableAxis.f().ar(), tableAxis.G().av()[2]);
			int num2 = setting.@as();
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			setting.A(ref num3, ref num4, ref num5, ref num6);
			int num7 = setting.aS();
			bb bb2 = new bb(num, num7, num2, num3, num4, num5, num6);
			if ((int)((Form)bb2).ShowDialog((IWin32Window)(object)this) == 1)
			{
				List<int> val = bb2.A();
				if (val.Count != 0)
				{
					Zm[(int)P_0].Clear();
					for (int i = 0; i < ((DataGridView)ZE[(int)P_0]).ColumnCount; i++)
					{
						if (i < val.Count)
						{
							Zm[(int)P_0].Add(val[i]);
							((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Value = bS.a(val[i], num7, -1);
						}
						else
						{
							((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Value = string.Empty;
						}
						string text = (string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Value;
						if (text.Length > 5)
						{
							((DataGridView)ZE[(int)P_0]).Columns[i].Width = text.Length * 10;
						}
						else
						{
							((DataGridView)ZE[(int)P_0]).Columns[i].Width = 48;
						}
						if ((string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Value == string.Empty)
						{
							((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Style.BackColor = Color.White;
							continue;
						}
						int num8 = val[i];
						((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Style.BackColor = A(setting, num8, num5, num6);
					}
					ZE[(int)P_0].C();
				}
			}
			((Component)bb2).Dispose();
		}

		private void d(object P_0, EventArgs P_1)
		{
			d(AxisType.Column);
		}

		private void E(object P_0, EventArgs P_1)
		{
			d(AxisType.Row);
		}

		private void e(object P_0, EventArgs P_1)
		{
			d(AxisType.Slice);
		}

		private void A(AxisType P_0, object P_1)
		{
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Invalid comparison between Unknown and I4
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0668: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
			((Control)ZN).Visible = false;
			if (!((Control)Ze[(int)P_0]).Visible || !((CheckBox)Ze[(int)P_0]).Checked)
			{
				return;
			}
			int count = Zm[(int)P_0].Count;
			TableAxis tableAxis = null;
			Setting setting = null;
			switch (P_0)
			{
			case AxisType.Column:
				tableAxis = ZC.HorizAxis;
				setting = Zc;
				break;
			case AxisType.Row:
				tableAxis = ZC.VertAxis;
				setting = ZD;
				break;
			case AxisType.Slice:
				tableAxis = ZC.SliceAxis;
				setting = Zd;
				break;
			}
			if (setting == null)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZS(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if (count == tableAxis.f().ar())
			{
				bE.A((IWin32Window)(object)this, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zs(), (object)count), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			int num = setting.aS();
			int num2 = setting.@as();
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			setting.A(ref num3, ref num4, ref num5, ref num6);
			Keys val = (Keys)0;
			if (P_1 is Keys)
			{
				val = (Keys)P_1;
			}
			BG bG2 = new BG(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZT(), val, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay(), num, num2, num3, num4, num5, num6, setting.d(0));
			if ((int)((Form)bG2).ShowDialog((IWin32Window)(object)this) == 1)
			{
				int num7 = ((bG2.a() == null) ? bS.A(bG2.A(), num) : bG2.B());
				for (int i = 0; i < ((DataGridView)ZE[(int)P_0]).ColumnCount; i++)
				{
					if (!((string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Value != string.Empty))
					{
						continue;
					}
					bool flag = false;
					if (bG2.a() != null)
					{
						if ((string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Value == bG2.a())
						{
							flag = true;
						}
					}
					else if (i < count && Zm[(int)P_0][i] == num7)
					{
						flag = true;
					}
					if (flag)
					{
						bE.A((IWin32Window)(object)this, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zt(), (object)(string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Value), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						((Component)bG2).Dispose();
						return;
					}
				}
				int num8 = 0;
				if ((string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[0].Value != string.Empty && count != 0)
				{
					int num9 = Zm[(int)P_0][0];
					if (num7 > num9)
					{
						for (int j = 0; j < ((DataGridView)ZE[(int)P_0]).ColumnCount - 1; j++)
						{
							if ((string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[j + 1].Value == string.Empty)
							{
								num8 = j + 1;
								break;
							}
							if (j + 1 < count)
							{
								int num10 = Zm[(int)P_0][j + 1];
								if (num7 < num10)
								{
									num8 = j + 1;
									break;
								}
							}
						}
					}
				}
				for (int num11 = count - 1; num11 >= num8; num11--)
				{
					((DataGridView)ZE[(int)P_0]).Rows[0].Cells[num11 + 1].Value = ((DataGridView)ZE[(int)P_0]).Rows[0].Cells[num11].Value;
					if (num11 + 1 < Zm[(int)P_0].Count)
					{
						Zm[(int)P_0][num11 + 1] = Zm[(int)P_0][num11];
					}
					else
					{
						Zm[(int)P_0].Add(Zm[(int)P_0][num11]);
					}
					string text = (string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[num11 + 1].Value;
					if (text.Length > 5)
					{
						((DataGridView)ZE[(int)P_0]).Columns[num11 + 1].Width = text.Length * 10;
					}
					else
					{
						((DataGridView)ZE[(int)P_0]).Columns[num11 + 1].Width = 48;
					}
				}
				if (bG2.a() != null)
				{
					((DataGridView)ZE[(int)P_0]).Rows[0].Cells[num8].Value = bG2.a();
					if (num8 < Zm[(int)P_0].Count)
					{
						Zm[(int)P_0][num8] = bG2.B();
					}
					else
					{
						Zm[(int)P_0].Add(bG2.B());
					}
				}
				else
				{
					((DataGridView)ZE[(int)P_0]).Rows[0].Cells[num8].Value = bS.a(num7, num, -1);
					if (num8 < Zm[(int)P_0].Count)
					{
						Zm[(int)P_0][num8] = num7;
					}
					else
					{
						Zm[(int)P_0].Add(num7);
					}
				}
				string text2 = (string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[num8].Value;
				if (text2.Length > 5)
				{
					((DataGridView)ZE[(int)P_0]).Columns[num8].Width = text2.Length * 10;
				}
				else
				{
					((DataGridView)ZE[(int)P_0]).Columns[num8].Width = 48;
				}
				for (int k = 0; k < ((DataGridView)ZE[(int)P_0]).ColumnCount && !((string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[k].Value == string.Empty); k++)
				{
					if ((string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[k].Value == string.Empty)
					{
						((DataGridView)ZE[(int)P_0]).Rows[0].Cells[k].Style.BackColor = Color.White;
					}
					else if (k < Zm[(int)P_0].Count)
					{
						int num12 = Zm[(int)P_0][k];
						((DataGridView)ZE[(int)P_0]).Rows[0].Cells[k].Style.BackColor = A(setting, num12, num5, num6);
					}
				}
				((DataGridView)ZE[(int)P_0]).ClearSelection();
				if (num8 == ((DataGridView)ZE[(int)P_0]).ColumnCount - 1 || (string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[num8 + 1].Value != string.Empty)
				{
					((DataGridView)ZE[(int)P_0]).Rows[0].Cells[num8].Selected = true;
					((DataGridView)ZE[(int)P_0]).CurrentCell = ((DataGridView)ZE[(int)P_0]).Rows[0].Cells[num8];
				}
				else
				{
					((DataGridView)ZE[(int)P_0]).Rows[0].Cells[num8 + 1].Selected = true;
					((DataGridView)ZE[(int)P_0]).CurrentCell = ((DataGridView)ZE[(int)P_0]).Rows[0].Cells[num8 + 1];
				}
				ZE[(int)P_0].C();
			}
			((Component)bG2).Dispose();
		}

		private void F(object P_0, EventArgs P_1)
		{
			A(AxisType.Column, P_0);
		}

		private void f(object P_0, EventArgs P_1)
		{
			A(AxisType.Row, P_0);
		}

		private void G(object P_0, EventArgs P_1)
		{
			A(AxisType.Slice, P_0);
		}

		private void E(AxisType P_0)
		{
			//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0424: Unknown result type (might be due to invalid IL or missing references)
			((Control)ZN).Visible = false;
			if (((DataGridView)ZE[(int)P_0]).SelectedCells == null || ((BaseCollection)((DataGridView)ZE[(int)P_0]).SelectedCells).Count == 0)
			{
				return;
			}
			List<int> val = F(P_0);
			if (val.Count == 0)
			{
				return;
			}
			int num = val[0];
			int count = val.Count;
			if (count == 1 && num == ((DataGridView)ZE[(int)P_0]).ColumnCount - 1)
			{
				((DataGridView)ZE[(int)P_0]).Rows[0].Cells[num].Value = string.Empty;
				((DataGridView)ZE[(int)P_0]).Columns[num].Width = 48;
				if (num < Zm[(int)P_0].Count)
				{
					Zm[(int)P_0].RemoveAt(num);
				}
			}
			else
			{
				for (int i = 0; i < count; i++)
				{
					for (int j = num + 1; j < ((DataGridView)ZE[(int)P_0]).ColumnCount; j++)
					{
						((DataGridView)ZE[(int)P_0]).Rows[0].Cells[j - 1].Value = ((DataGridView)ZE[(int)P_0]).Rows[0].Cells[j].Value;
						if (j < Zm[(int)P_0].Count)
						{
							Zm[(int)P_0][j - 1] = Zm[(int)P_0][j];
						}
						else if (j - 1 < Zm[(int)P_0].Count)
						{
							Zm[(int)P_0].RemoveAt(j - 1);
						}
						if (j == ((DataGridView)ZE[(int)P_0]).ColumnCount - 1)
						{
							((DataGridView)ZE[(int)P_0]).Rows[0].Cells[j].Value = string.Empty;
							((DataGridView)ZE[(int)P_0]).Columns[j].Width = 48;
							if (j < Zm[(int)P_0].Count)
							{
								Zm[(int)P_0].RemoveAt(j);
							}
						}
						else
						{
							string text = (string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[j - 1].Value;
							if (text.Length > 5)
							{
								((DataGridView)ZE[(int)P_0]).Columns[j - 1].Width = text.Length * 10;
							}
							else
							{
								((DataGridView)ZE[(int)P_0]).Columns[j - 1].Width = 48;
							}
						}
					}
				}
				TableAxis tableAxis = null;
				Setting setting = null;
				switch (P_0)
				{
				case AxisType.Column:
					tableAxis = ZC.HorizAxis;
					setting = Zc;
					break;
				case AxisType.Row:
					tableAxis = ZC.VertAxis;
					setting = ZD;
					break;
				case AxisType.Slice:
					tableAxis = ZC.SliceAxis;
					setting = Zd;
					break;
				}
				if (tableAxis != null && setting != null)
				{
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
					int num5 = 0;
					setting.A(ref num2, ref num3, ref num4, ref num5);
					setting.aS();
					for (int k = 0; k < ((DataGridView)ZE[(int)P_0]).ColumnCount && !((string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[k].Value == string.Empty); k++)
					{
						if ((string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[k].Value == string.Empty)
						{
							((DataGridView)ZE[(int)P_0]).Rows[0].Cells[k].Style.BackColor = Color.White;
						}
						else if (k < Zm[(int)P_0].Count)
						{
							int num6 = Zm[(int)P_0][k];
							((DataGridView)ZE[(int)P_0]).Rows[0].Cells[k].Style.BackColor = A(setting, num6, num4, num5);
						}
					}
				}
			}
			ZE[(int)P_0].C();
		}

		private void g(object P_0, EventArgs P_1)
		{
			E(AxisType.Column);
		}

		private void H(object P_0, EventArgs P_1)
		{
			E(AxisType.Row);
		}

		private void h(object P_0, EventArgs P_1)
		{
			E(AxisType.Slice);
		}

		private void e(AxisType P_0)
		{
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			((Control)ZN).Visible = false;
			if (((DataGridView)ZE[(int)P_0]).SelectedCells == null || ((BaseCollection)((DataGridView)ZE[(int)P_0]).SelectedCells).Count < 3)
			{
				return;
			}
			List<int> val = F(P_0);
			if (val.Count == 0)
			{
				return;
			}
			int num = val[0];
			int num2 = val[val.Count - 1];
			try
			{
				for (int i = 0; i < val.Count; i++)
				{
					double.Parse((string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[num + i].Value, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture);
				}
			}
			catch
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZU(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			Setting setting = null;
			switch (P_0)
			{
			case AxisType.Column:
				setting = Zc;
				break;
			case AxisType.Row:
				setting = ZD;
				break;
			case AxisType.Slice:
				setting = Zd;
				break;
			}
			int num3 = setting.aS();
			int num4 = Zm[(int)P_0][num];
			int num5 = (Zm[(int)P_0][num2] - num4) / (val.Count - 1);
			for (int j = 1; j < val.Count - 1; j++)
			{
				int num6 = num4 + j * num5;
				((DataGridView)ZE[(int)P_0]).Rows[0].Cells[num + j].Value = bS.a(num6, num3, -1);
				Zm[(int)P_0][num + j] = num6;
			}
		}

		private void I(object P_0, EventArgs P_1)
		{
			e(AxisType.Column);
		}

		private void i(object P_0, EventArgs P_1)
		{
			e(AxisType.Row);
		}

		private void J(object P_0, EventArgs P_1)
		{
			e(AxisType.Slice);
		}

		private void A(AxisType P_0, Keys P_1, Keys P_2)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Invalid comparison between Unknown and I4
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Invalid comparison between Unknown and I4
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Invalid comparison between Unknown and I4
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Invalid comparison between Unknown and I4
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Invalid comparison between Unknown and I4
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Invalid comparison between Unknown and I4
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Invalid comparison between Unknown and I4
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Invalid comparison between Unknown and I4
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Invalid comparison between Unknown and I4
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Invalid comparison between Unknown and I4
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			if ((int)P_1 == 46)
			{
				E(P_0);
			}
			else if ((int)P_1 == 45)
			{
				A(P_0, (object)null);
			}
			else if ((int)P_1 == 76)
			{
				e(P_0);
			}
			else if ((int)P_2 >= 48 && (int)P_2 <= 57)
			{
				A(P_0, (object)P_2);
			}
			else if ((int)P_2 >= 96 && (int)P_2 <= 105)
			{
				A(P_0, (object)P_2);
			}
			else if ((int)P_2 == 189 || (int)P_2 == 109)
			{
				A(P_0, (object)P_2);
			}
			else
			{
				if ((int)P_1 != 131158)
				{
					return;
				}
				try
				{
					if (!Clipboard.ContainsText())
					{
						return;
					}
					string text = Clipboard.GetText();
					int num = text.Split('\n', (StringSplitOptions)0)[0].Split('\t', (StringSplitOptions)0).Length;
					if (num > ((DataGridView)ZE[(int)P_0]).ColumnCount)
					{
						return;
					}
					Setting setting = null;
					switch (P_0)
					{
					case AxisType.Column:
						setting = Zc;
						break;
					case AxisType.Row:
						setting = ZD;
						break;
					case AxisType.Slice:
						setting = Zd;
						break;
					}
					int num2 = setting.aS();
					int num3 = setting.aR();
					int num4 = setting.ar();
					List<int> val = new List<int>();
					int num5 = -2147483648;
					for (int i = 0; i < num; i++)
					{
						string text2 = text.Split('\n', (StringSplitOptions)0)[0].Split('\t', (StringSplitOptions)0)[i];
						if (text2 == string.Empty)
						{
							break;
						}
						if (text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VU()))
						{
							text2 = text2.Substring(0, text2.Length - 1);
						}
						int num6 = bS.A(text2, num2);
						if (num3 != 0 || num4 != 0)
						{
							num6 = Math.Min(Math.Max(num6, num3), num4);
						}
						if (i == 0 || (num6 > num5 && !val.Contains(num6)))
						{
							val.Add(num6);
							num5 = num6;
							continue;
						}
						throw new System.Exception();
					}
					Zm[(int)P_0].Clear();
					for (int j = 0; j < ((DataGridView)ZE[(int)P_0]).ColumnCount; j++)
					{
						if (j < val.Count)
						{
							Zm[(int)P_0].Add(val[j]);
							ValueTuple<string, string, bool> val2 = setting.A(val[j], -1);
							((DataGridView)ZE[(int)P_0]).Rows[0].Cells[j].Value = val2.Item1;
							if (val2.Item1.Length > 5)
							{
								((DataGridView)ZE[(int)P_0]).Columns[j].Width = val2.Item1.Length * 10;
							}
							else
							{
								((DataGridView)ZE[(int)P_0]).Columns[j].Width = 48;
							}
						}
						else
						{
							((DataGridView)ZE[(int)P_0]).Rows[0].Cells[j].Value = string.Empty;
						}
					}
					((DataGridView)ZE[(int)P_0]).ClearSelection();
					((DataGridView)ZE[(int)P_0]).CurrentCell = ((DataGridView)ZE[(int)P_0]).Rows[0].Cells[0];
					((DataGridView)ZE[(int)P_0]).Rows[0].Cells[0].Selected = true;
				}
				catch
				{
				}
			}
		}

		private void A(object P_0, KeyEventArgs P_1)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			A(AxisType.Column, P_1.KeyData, P_1.KeyCode);
		}

		private void a(object P_0, KeyEventArgs P_1)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			A(AxisType.Row, P_1.KeyData, P_1.KeyCode);
		}

		private void B(object P_0, KeyEventArgs P_1)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			A(AxisType.Slice, P_1.KeyData, P_1.KeyCode);
		}

		private List<int> F(AxisType P_0)
		{
			List<int> val = new List<int>();
			for (int i = 0; i < ((DataGridView)ZE[(int)P_0]).ColumnCount && !((string)((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Value == string.Empty); i++)
			{
				if (((DataGridView)ZE[(int)P_0]).Rows[0].Cells[i].Selected)
				{
					val.Add(i);
				}
			}
			return val;
		}

		private void A(int P_0, int P_1, string P_2, string P_3)
		{
			((Control)ZN).Text = P_2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zu() + P_3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZV();
			((Control)ZN).Left = P_0;
			((Control)ZN).Top = P_1;
			((Control)ZN).Visible = true;
			((Control)ZN).BringToFront();
		}

		private void j(object P_0, EventArgs P_1)
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)ZN).Visible && (int)((Control)ZN).Tag == 2)
			{
				((Control)ZN).Visible = false;
				return;
			}
			((Control)ZN).Tag = 2;
			Size clientSize = ((Form)this).ClientSize;
			A(((Size)(ref clientSize)).Width - 10 - 300, ((Control)zE).Bottom, ZC.HorizAxis.H().a(1, 0), ZC.HorizAxis.H().a(3, 0));
		}

		private void K(object P_0, EventArgs P_1)
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)ZN).Visible && (int)((Control)ZN).Tag == 1)
			{
				((Control)ZN).Visible = false;
				return;
			}
			((Control)ZN).Tag = 1;
			Size clientSize = ((Form)this).ClientSize;
			A(((Size)(ref clientSize)).Width - 10 - 300, ((Control)ze).Bottom, ZC.VertAxis.H().a(1, 0), ZC.VertAxis.H().a(3, 0));
		}

		private void k(object P_0, EventArgs P_1)
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)ZN).Visible && (int)((Control)ZN).Tag == 0)
			{
				((Control)ZN).Visible = false;
				return;
			}
			((Control)ZN).Tag = 0;
			Size clientSize = ((Form)this).ClientSize;
			A(((Size)(ref clientSize)).Width - 10 - 300, ((Control)zF).Bottom, ZC.SliceAxis.H().a(1, 0), ZC.SliceAxis.H().a(3, 0));
		}

		private void L(object P_0, EventArgs P_1)
		{
			((Control)ZN).Visible = false;
		}

		private void l(object P_0, EventArgs P_1)
		{
			((Form)this).DialogResult = (DialogResult)2;
			((Form)this).Close();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_07af: Expected O, but got Unknown
			//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d0: Expected O, but got Unknown
			//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0802: Expected O, but got Unknown
			//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f1: Expected O, but got Unknown
			if ((int)((Form)this).DialogResult != 1)
			{
				BM.c(new EventHandler(this.l));
				return;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			bool flag = false;
			Ck ck = BM.aM();
			try
			{
				ck?.A(((Setting)ZC).A());
				List<int> val = new List<int>();
				if (((Control)Zp).Visible)
				{
					if (((CheckBox)Zp).Checked)
					{
						if (((Control)zE).Visible)
						{
							if (((ListControl)zE).SelectedIndex == -1)
							{
								throw new System.Exception();
							}
							ZC.HorizAxis.H().a(ZC.HorizAxis.H().d(0)[((ListControl)zE).SelectedIndex].bBv, true);
						}
						for (int i = 0; i < ((DataGridView)ZS).ColumnCount; i++)
						{
							if ((string)((DataGridView)ZS).Rows[0].Cells[i].Value != string.Empty)
							{
								int num4 = Zm[2][i];
								if (val.Contains(num4))
								{
									flag = true;
									throw new System.Exception();
								}
								val.Add(num4);
								num++;
							}
						}
						if (num == 0)
						{
							throw new System.Exception();
						}
						ZC.HorizAxis.g().a(Zc.A(), true);
						ZC.HorizAxis.F().a(1, true);
					}
					else
					{
						ZC.HorizAxis.F().a(0, true);
						val.Add(0);
						num = 1;
					}
				}
				else
				{
					val.Add(0);
					num = 1;
				}
				List<int> val2 = new List<int>();
				if (((Control)ZQ).Visible)
				{
					if (((CheckBox)ZQ).Checked)
					{
						if (((Control)ze).Visible)
						{
							if (((ListControl)ze).SelectedIndex == -1)
							{
								throw new System.Exception();
							}
							ZC.VertAxis.H().a(ZC.VertAxis.H().d(0)[((ListControl)ze).SelectedIndex].bBv, true);
						}
						for (int j = 0; j < ((DataGridView)Zs).ColumnCount; j++)
						{
							if ((string)((DataGridView)Zs).Rows[0].Cells[j].Value != string.Empty)
							{
								int num5 = Zm[1][j];
								if (val2.Contains(num5))
								{
									flag = true;
									throw new System.Exception();
								}
								val2.Add(num5);
								num2++;
							}
						}
						if (num2 == 0)
						{
							throw new System.Exception();
						}
						ZC.VertAxis.g().a(ZD.A(), true);
						ZC.VertAxis.F().a(1, true);
					}
					else
					{
						ZC.VertAxis.F().a(0, true);
						val2.Add(0);
						num2 = 1;
					}
				}
				else
				{
					val2.Add(0);
					num2 = 1;
				}
				List<int> val3 = new List<int>();
				if (((Control)Zq).Visible)
				{
					if (((CheckBox)Zq).Checked)
					{
						if (((Control)zF).Visible)
						{
							if (((ListControl)zF).SelectedIndex == -1)
							{
								throw new System.Exception();
							}
							ZC.SliceAxis.H().a(ZC.SliceAxis.H().d(0)[((ListControl)zF).SelectedIndex].bBv, true);
						}
						for (int k = 0; k < ((DataGridView)ZT).ColumnCount; k++)
						{
							if ((string)((DataGridView)ZT).Rows[0].Cells[k].Value != string.Empty)
							{
								int num6 = Zm[0][k];
								if (val3.Contains(num6))
								{
									flag = true;
									throw new System.Exception();
								}
								val3.Add(num6);
								num3++;
							}
						}
						if (num3 == 0)
						{
							throw new System.Exception();
						}
						ZC.SliceAxis.g().a(Zd.A(), true);
						ZC.SliceAxis.F().a(1, true);
					}
					else
					{
						ZC.SliceAxis.F().a(0, true);
						val3.Add(0);
						num3 = 1;
					}
				}
				else
				{
					val3.Add(0);
					num3 = 1;
				}
				int[,,] array = new int[num3, num2, num];
				for (int l = 0; l < num3; l++)
				{
					for (int m = 0; m < num2; m++)
					{
						for (int n = 0; n < num; n++)
						{
							array[l, m, n] = ZC.GetInterpolatedTableDataRawValue(val[n], val2[m], val3[l]);
						}
					}
				}
				if (((Control)Zq).Visible)
				{
					ZC.SliceAxis.f().a(num3, true);
					ZC.SliceAxis.G().az();
					for (int num7 = 0; num7 < num3; num7++)
					{
						ZC.SliceAxis.G().a(num7, val3[num7], true);
					}
					ZC.SliceAxis.G().i(true);
				}
				if (((Control)ZQ).Visible)
				{
					ZC.VertAxis.f().a(num2, true);
					ZC.VertAxis.G().az();
					for (int num8 = 0; num8 < num2; num8++)
					{
						ZC.VertAxis.G().a(num8, val2[num8], true);
					}
					ZC.VertAxis.G().i(true);
				}
				if (((Control)Zp).Visible)
				{
					ZC.HorizAxis.f().a(num, true);
					ZC.HorizAxis.G().az();
					for (int num9 = 0; num9 < num; num9++)
					{
						ZC.HorizAxis.G().a(num9, val[num9], true);
					}
					ZC.HorizAxis.G().i(true);
				}
				ZC.TableDataSetting.az();
				for (int num10 = 0; num10 < num3; num10++)
				{
					for (int num11 = 0; num11 < num2; num11++)
					{
						for (int num12 = 0; num12 < num; num12++)
						{
							if (ZC.SwapColumnsAndRows)
							{
								ZC.TableDataSetting.A(num11, num12, num10, array[num10, num11, num12], true);
							}
							else
							{
								ZC.TableDataSetting.A(num12, num11, num10, array[num10, num11, num12], true);
							}
						}
					}
				}
				ZC.TableDataSetting.i(true);
				if (((SettingOrSpecialObject)ZC).A().awo != null)
				{
					((SettingOrSpecialObject)ZC).A().awo.A(((Setting)ZC).A());
				}
				ck?.B();
				if (!ZM[2])
				{
					ZO.a(new EventHandler(a));
				}
				if (!ZM[1])
				{
					Zo.a(new EventHandler(B));
				}
				if (!ZM[0])
				{
					ZP.a(new EventHandler(b));
				}
				BM.c(new EventHandler(this.l));
			}
			catch
			{
				ck?.B();
				string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zv();
				if ((((Control)zE).Visible && ((ListControl)zE).SelectedIndex == -1) || (((Control)ze).Visible && ((ListControl)ze).SelectedIndex == -1) || (((Control)zF).Visible && ((ListControl)zF).SelectedIndex == -1))
				{
					text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZW();
				}
				else if (flag)
				{
					text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zw();
				}
				else if ((((Control)Zp).Visible && ((CheckBox)Zp).Checked && num == 0) || (((Control)ZQ).Visible && ((CheckBox)ZQ).Checked && num2 == 0) || (((Control)Zq).Visible && ((CheckBox)Zq).Checked && num3 == 0))
				{
					text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZX();
				}
				bE.A((IWin32Window)(object)this, text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((CancelEventArgs)P_1).Cancel = true;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && Zn != null)
			{
				((System.IDisposable)Zn).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void d()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected O, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected O, but got Unknown
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected O, but got Unknown
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Expected O, but got Unknown
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Expected O, but got Unknown
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected O, but got Unknown
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected O, but got Unknown
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected O, but got Unknown
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Expected O, but got Unknown
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Expected O, but got Unknown
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Expected O, but got Unknown
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Expected O, but got Unknown
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Expected O, but got Unknown
			//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_031d: Unknown result type (might be due to invalid IL or missing references)
			//IL_035c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0366: Expected O, but got Unknown
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ed: Expected O, but got Unknown
			//IL_0409: Unknown result type (might be due to invalid IL or missing references)
			//IL_042d: Unknown result type (might be due to invalid IL or missing references)
			//IL_047c: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0509: Unknown result type (might be due to invalid IL or missing references)
			//IL_0535: Unknown result type (might be due to invalid IL or missing references)
			//IL_058c: Unknown result type (might be due to invalid IL or missing references)
			//IL_05af: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b9: Expected O, but got Unknown
			//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d0: Expected O, but got Unknown
			//IL_0606: Unknown result type (might be due to invalid IL or missing references)
			//IL_0635: Unknown result type (might be due to invalid IL or missing references)
			//IL_068c: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ba: Expected O, but got Unknown
			//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d1: Expected O, but got Unknown
			//IL_0707: Unknown result type (might be due to invalid IL or missing references)
			//IL_0736: Unknown result type (might be due to invalid IL or missing references)
			//IL_078d: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bb: Expected O, but got Unknown
			//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d2: Expected O, but got Unknown
			//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_080f: Unknown result type (might be due to invalid IL or missing references)
			//IL_084f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0873: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0914: Unknown result type (might be due to invalid IL or missing references)
			//IL_0938: Unknown result type (might be due to invalid IL or missing references)
			//IL_097b: Unknown result type (might be due to invalid IL or missing references)
			//IL_099f: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa7: Expected O, but got Unknown
			//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b21: Expected O, but got Unknown
			//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b9b: Expected O, but got Unknown
			//IL_0bab: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bcf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c19: Expected O, but got Unknown
			//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c97: Expected O, but got Unknown
			//IL_0ca7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ccb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d15: Expected O, but got Unknown
			//IL_0d25: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d49: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d89: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d93: Expected O, but got Unknown
			//IL_0da3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dc7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e11: Expected O, but got Unknown
			//IL_0e21: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e45: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e85: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e8f: Expected O, but got Unknown
			//IL_0ea0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eaa: Expected O, but got Unknown
			//IL_0eb7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ec8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f2c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f36: Expected O, but got Unknown
			//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f57: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fbb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fc5: Expected O, but got Unknown
			//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe6: Unknown result type (might be due to invalid IL or missing references)
			//IL_100a: Unknown result type (might be due to invalid IL or missing references)
			//IL_104b: Unknown result type (might be due to invalid IL or missing references)
			//IL_105f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1086: Unknown result type (might be due to invalid IL or missing references)
			//IL_10cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1109: Unknown result type (might be due to invalid IL or missing references)
			//IL_114e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1165: Unknown result type (might be due to invalid IL or missing references)
			//IL_118c: Unknown result type (might be due to invalid IL or missing references)
			//IL_11e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_11f1: Expected O, but got Unknown
			//IL_11fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_1225: Unknown result type (might be due to invalid IL or missing references)
			//IL_1264: Unknown result type (might be due to invalid IL or missing references)
			//IL_126e: Expected O, but got Unknown
			//IL_127b: Unknown result type (might be due to invalid IL or missing references)
			//IL_12a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_12eb: Expected O, but got Unknown
			//IL_12f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_131c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1363: Unknown result type (might be due to invalid IL or missing references)
			//IL_1387: Unknown result type (might be due to invalid IL or missing references)
			//IL_13aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_13b4: Expected O, but got Unknown
			//IL_13e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_140c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1430: Unknown result type (might be due to invalid IL or missing references)
			//IL_143a: Expected O, but got Unknown
			//IL_146e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1492: Unknown result type (might be due to invalid IL or missing references)
			//IL_14b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_14c0: Expected O, but got Unknown
			//IL_14dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1500: Unknown result type (might be due to invalid IL or missing references)
			//IL_1543: Unknown result type (might be due to invalid IL or missing references)
			//IL_1567: Unknown result type (might be due to invalid IL or missing references)
			//IL_15a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_15cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_15ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_1623: Unknown result type (might be due to invalid IL or missing references)
			//IL_1662: Unknown result type (might be due to invalid IL or missing references)
			//IL_166c: Expected O, but got Unknown
			//IL_167c: Unknown result type (might be due to invalid IL or missing references)
			//IL_16a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_16e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_16ea: Expected O, but got Unknown
			//IL_16fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_171e: Unknown result type (might be due to invalid IL or missing references)
			//IL_175e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1768: Expected O, but got Unknown
			//IL_176e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1789: Unknown result type (might be due to invalid IL or missing references)
			//IL_1793: Expected O, but got Unknown
			//IL_179f: Unknown result type (might be due to invalid IL or missing references)
			//IL_17b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_17d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1810: Unknown result type (might be due to invalid IL or missing references)
			//IL_181a: Expected O, but got Unknown
			//IL_1820: Unknown result type (might be due to invalid IL or missing references)
			//IL_183b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1845: Expected O, but got Unknown
			//IL_1855: Unknown result type (might be due to invalid IL or missing references)
			//IL_1866: Unknown result type (might be due to invalid IL or missing references)
			//IL_188a: Unknown result type (might be due to invalid IL or missing references)
			//IL_18c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_18d0: Expected O, but got Unknown
			//IL_18d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_18f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_18fb: Expected O, but got Unknown
			//IL_190b: Unknown result type (might be due to invalid IL or missing references)
			//IL_191c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1940: Unknown result type (might be due to invalid IL or missing references)
			//IL_197c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1986: Expected O, but got Unknown
			//IL_1991: Unknown result type (might be due to invalid IL or missing references)
			//IL_19b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cbd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cc7: Expected O, but got Unknown
			//IL_1d0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d19: Expected O, but got Unknown
			//IL_1d21: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d2b: Expected O, but got Unknown
			//IL_1d33: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d3d: Expected O, but got Unknown
			ComponentResourceManager val = new ComponentResourceManager(typeof(bB));
			Zp = new aP();
			ZQ = new aP();
			Zq = new aP();
			ZR = new ThemedButton();
			Zr = new ThemedButton();
			ZS = new DataGridViewWithThemedScrollBars();
			Zs = new DataGridViewWithThemedScrollBars();
			ZT = new DataGridViewWithThemedScrollBars();
			Zt = new Label();
			ZU = new Label();
			Zu = new Label();
			ZV = new Label();
			Zv = new Label();
			ZW = new Label();
			Zw = new ThemedButton();
			ZX = new ThemedButton();
			Zx = new ThemedButton();
			ZY = new ThemedButton();
			Zy = new ThemedButton();
			ZZ = new ThemedButton();
			Zz = new ThemedButton();
			zA = new ThemedButton();
			za = new ThemedButton();
			zB = new PictureBox();
			zb = new PictureBox();
			zC = new PictureBox();
			zc = new Label();
			zD = new Label();
			zd = new Label();
			ZP = new aI();
			Zo = new aI();
			ZO = new aI();
			zE = new ThemedComboBox();
			ze = new ThemedComboBox();
			zF = new ThemedComboBox();
			zf = new Label();
			zG = new Label();
			zg = new Label();
			zH = new ThemedButton();
			zh = new ThemedButton();
			zI = new ThemedButton();
			zi = new PictureBox();
			zJ = new PictureBox();
			zj = new PictureBox();
			((ISupportInitialize)ZS).BeginInit();
			((ISupportInitialize)Zs).BeginInit();
			((ISupportInitialize)ZT).BeginInit();
			((ISupportInitialize)zB).BeginInit();
			((ISupportInitialize)zb).BeginInit();
			((ISupportInitialize)zC).BeginInit();
			((ISupportInitialize)zi).BeginInit();
			((ISupportInitialize)zJ).BeginInit();
			((ISupportInitialize)zj).BeginInit();
			((Control)this).SuspendLayout();
			((Control)Zp).AutoSize = true;
			((Control)Zp).Location = new Point(11, 27);
			((Control)Zp).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zx();
			((Control)Zp).Size = new Size(84, 17);
			((Control)Zp).TabIndex = 0;
			((Control)Zp).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZY();
			((ButtonBase)Zp).UseVisualStyleBackColor = true;
			((CheckBox)Zp).CheckedChanged += new EventHandler(C);
			((Control)ZQ).AutoSize = true;
			((Control)ZQ).Location = new Point(11, 177);
			((Control)ZQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zy();
			((Control)ZQ).Size = new Size(84, 17);
			((Control)ZQ).TabIndex = 8;
			((Control)ZQ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZY();
			((ButtonBase)ZQ).UseVisualStyleBackColor = true;
			((CheckBox)ZQ).CheckedChanged += new EventHandler(c);
			((Control)Zq).AutoSize = true;
			((Control)Zq).Location = new Point(11, 327);
			((Control)Zq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZZ();
			((Control)Zq).Size = new Size(84, 17);
			((Control)Zq).TabIndex = 16;
			((Control)Zq).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZY();
			((ButtonBase)Zq).UseVisualStyleBackColor = true;
			((CheckBox)Zq).CheckedChanged += new EventHandler(D);
			((Button)ZR).DialogResult = (DialogResult)1;
			((Control)ZR).Location = new Point(581, 464);
			((Control)ZR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)ZR).Size = new Size(93, 30);
			((Control)ZR).TabIndex = 24;
			((Control)ZR).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)ZR).UseVisualStyleBackColor = true;
			((Button)Zr).DialogResult = (DialogResult)2;
			((Control)Zr).Location = new Point(680, 464);
			((Control)Zr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)Zr).Size = new Size(92, 30);
			((Control)Zr).TabIndex = 25;
			((Control)Zr).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)Zr).UseVisualStyleBackColor = true;
			((DataGridView)ZS).AllowUserToAddRows = false;
			((DataGridView)ZS).AllowUserToDeleteRows = false;
			((DataGridView)ZS).AllowUserToResizeColumns = false;
			((DataGridView)ZS).AllowUserToResizeRows = false;
			((DataGridView)ZS).BackgroundColor = Color.White;
			((DataGridView)ZS).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
			((DataGridView)ZS).ColumnHeadersVisible = false;
			((Control)ZS).Location = new Point(14, 68);
			((Control)ZS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Zz();
			((DataGridView)ZS).ReadOnly = true;
			((DataGridView)ZS).RowHeadersVisible = false;
			((DataGridView)ZS).ScrollBars = (ScrollBars)1;
			((DataGridView)ZS).ShowCellToolTips = false;
			((Control)ZS).Size = new Size(758, 65);
			((Control)ZS).TabIndex = 7;
			((Control)ZS).Click += new EventHandler(L);
			((Control)ZS).KeyDown += new KeyEventHandler(A);
			((DataGridView)Zs).AllowUserToAddRows = false;
			((DataGridView)Zs).AllowUserToDeleteRows = false;
			((DataGridView)Zs).AllowUserToResizeColumns = false;
			((DataGridView)Zs).AllowUserToResizeRows = false;
			((DataGridView)Zs).BackgroundColor = Color.White;
			((DataGridView)Zs).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
			((DataGridView)Zs).ColumnHeadersVisible = false;
			((Control)Zs).Location = new Point(14, 218);
			((Control)Zs).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zA();
			((DataGridView)Zs).ReadOnly = true;
			((DataGridView)Zs).RowHeadersVisible = false;
			((DataGridView)Zs).ScrollBars = (ScrollBars)1;
			((DataGridView)Zs).ShowCellToolTips = false;
			((Control)Zs).Size = new Size(758, 65);
			((Control)Zs).TabIndex = 15;
			((Control)Zs).Click += new EventHandler(L);
			((Control)Zs).KeyDown += new KeyEventHandler(a);
			((DataGridView)ZT).AllowUserToAddRows = false;
			((DataGridView)ZT).AllowUserToDeleteRows = false;
			((DataGridView)ZT).AllowUserToResizeColumns = false;
			((DataGridView)ZT).AllowUserToResizeRows = false;
			((DataGridView)ZT).BackgroundColor = Color.White;
			((DataGridView)ZT).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
			((DataGridView)ZT).ColumnHeadersVisible = false;
			((Control)ZT).Location = new Point(14, 368);
			((Control)ZT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.za();
			((DataGridView)ZT).ReadOnly = true;
			((DataGridView)ZT).RowHeadersVisible = false;
			((DataGridView)ZT).ScrollBars = (ScrollBars)1;
			((DataGridView)ZT).ShowCellToolTips = false;
			((Control)ZT).Size = new Size(758, 65);
			((Control)ZT).TabIndex = 23;
			((Control)ZT).Click += new EventHandler(L);
			((Control)ZT).KeyDown += new KeyEventHandler(B);
			((Control)Zt).AutoSize = true;
			((Control)Zt).Location = new Point(18, 202);
			((Control)Zt).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zB();
			((Control)Zt).Size = new Size(43, 13);
			((Control)Zt).TabIndex = 11;
			((Control)Zt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zb();
			((Control)ZU).AutoSize = true;
			((Control)ZU).Location = new Point(18, 352);
			((Control)ZU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zC();
			((Control)ZU).Size = new Size(43, 13);
			((Control)ZU).TabIndex = 12;
			((Control)ZU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zb();
			((Control)Zu).AutoSize = true;
			((Control)Zu).Location = new Point(18, 52);
			((Control)Zu).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zc();
			((Control)Zu).Size = new Size(43, 13);
			((Control)Zu).TabIndex = 13;
			((Control)Zu).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zb();
			((Control)ZV).AutoSize = true;
			((Control)ZV).Location = new Point(655, 52);
			((Control)ZV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zD();
			((Control)ZV).Size = new Size(98, 13);
			((Control)ZV).TabIndex = 14;
			((Control)ZV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zd();
			((Control)Zv).AutoSize = true;
			((Control)Zv).Location = new Point(655, 352);
			((Control)Zv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zE();
			((Control)Zv).Size = new Size(98, 13);
			((Control)Zv).TabIndex = 15;
			((Control)Zv).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zd();
			((Control)ZW).AutoSize = true;
			((Control)ZW).Location = new Point(655, 202);
			((Control)ZW).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ze();
			((Control)ZW).Size = new Size(98, 13);
			((Control)ZW).TabIndex = 16;
			((Control)ZW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zd();
			((Control)Zw).Location = new Point(425, 23);
			((Control)Zw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zF();
			((Control)Zw).Size = new Size(75, 23);
			((Control)Zw).TabIndex = 3;
			((Control)Zw).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZT();
			((ButtonBase)Zw).UseVisualStyleBackColor = true;
			((Control)Zw).Click += new EventHandler(F);
			((Control)ZX).Location = new Point(502, 23);
			((Control)ZX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zf();
			((Control)ZX).Size = new Size(85, 23);
			((Control)ZX).TabIndex = 4;
			((Control)ZX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zG();
			((ButtonBase)ZX).UseVisualStyleBackColor = true;
			((Control)ZX).Click += new EventHandler(g);
			((Control)Zx).Location = new Point(589, 23);
			((Control)Zx).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zg();
			((Control)Zx).Size = new Size(65, 23);
			((Control)Zx).TabIndex = 5;
			((Control)Zx).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zH();
			((ButtonBase)Zx).UseVisualStyleBackColor = true;
			((Control)Zx).Click += new EventHandler(I);
			((Control)ZY).Location = new Point(589, 173);
			((Control)ZY).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zh();
			((Control)ZY).Size = new Size(65, 23);
			((Control)ZY).TabIndex = 13;
			((Control)ZY).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zH();
			((ButtonBase)ZY).UseVisualStyleBackColor = true;
			((Control)ZY).Click += new EventHandler(i);
			((Control)Zy).Location = new Point(502, 173);
			((Control)Zy).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zI();
			((Control)Zy).Size = new Size(85, 23);
			((Control)Zy).TabIndex = 12;
			((Control)Zy).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zG();
			((ButtonBase)Zy).UseVisualStyleBackColor = true;
			((Control)Zy).Click += new EventHandler(H);
			((Control)ZZ).Location = new Point(425, 173);
			((Control)ZZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zi();
			((Control)ZZ).Size = new Size(75, 23);
			((Control)ZZ).TabIndex = 11;
			((Control)ZZ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZT();
			((ButtonBase)ZZ).UseVisualStyleBackColor = true;
			((Control)ZZ).Click += new EventHandler(f);
			((Control)Zz).Location = new Point(589, 323);
			((Control)Zz).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zJ();
			((Control)Zz).Size = new Size(65, 23);
			((Control)Zz).TabIndex = 21;
			((Control)Zz).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zH();
			((ButtonBase)Zz).UseVisualStyleBackColor = true;
			((Control)Zz).Click += new EventHandler(J);
			((Control)zA).Location = new Point(502, 323);
			((Control)zA).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zj();
			((Control)zA).Size = new Size(85, 23);
			((Control)zA).TabIndex = 20;
			((Control)zA).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zG();
			((ButtonBase)zA).UseVisualStyleBackColor = true;
			((Control)zA).Click += new EventHandler(h);
			((Control)za).Location = new Point(425, 323);
			((Control)za).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zK();
			((Control)za).Size = new Size(75, 23);
			((Control)za).TabIndex = 19;
			((Control)za).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZT();
			((ButtonBase)za).UseVisualStyleBackColor = true;
			((Control)za).Click += new EventHandler(G);
			zB.Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zk());
			((Control)zB).Location = new Point(337, 19);
			((Control)zB).Margin = new Padding(0);
			((Control)zB).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zL();
			((Control)zB).Size = new Size(32, 32);
			zB.TabIndex = 26;
			zB.TabStop = false;
			((Control)zB).Visible = false;
			zb.Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zl());
			((Control)zb).Location = new Point(337, 169);
			((Control)zb).Margin = new Padding(0);
			((Control)zb).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zM();
			((Control)zb).Size = new Size(32, 32);
			zb.TabIndex = 27;
			zb.TabStop = false;
			((Control)zb).Visible = false;
			zC.Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zm());
			((Control)zC).Location = new Point(337, 319);
			((Control)zC).Margin = new Padding(0);
			((Control)zC).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zN();
			((Control)zC).Size = new Size(32, 32);
			zC.TabIndex = 28;
			zC.TabStop = false;
			((Control)zC).Visible = false;
			((Control)zc).AutoSize = true;
			((Control)zc).ForeColor = Color.Black;
			((Control)zc).Location = new Point(103, 47);
			((Control)zc).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zn();
			((Control)zc).Size = new Size(224, 13);
			((Control)zc).TabIndex = 29;
			((Control)zc).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zO();
			((Control)zc).Visible = false;
			((Control)zD).AutoSize = true;
			((Control)zD).ForeColor = Color.Black;
			((Control)zD).Location = new Point(103, 197);
			((Control)zD).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zo();
			((Control)zD).Size = new Size(224, 13);
			((Control)zD).TabIndex = 30;
			((Control)zD).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zO();
			((Control)zD).Visible = false;
			((Control)zd).AutoSize = true;
			((Control)zd).ForeColor = Color.Black;
			((Control)zd).Location = new Point(103, 347);
			((Control)zd).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zP();
			((Control)zd).Size = new Size(224, 13);
			((Control)zd).TabIndex = 31;
			((Control)zd).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zO();
			((Control)zd).Visible = false;
			((Control)ZP).AutoSize = true;
			((UserControl)ZP).AutoSizeMode = (AutoSizeMode)0;
			((Control)ZP).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f);
			((Control)ZP).Location = new Point(98, 323);
			((Control)ZP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zp();
			((Control)ZP).Size = new Size(232, 23);
			((Control)ZP).TabIndex = 17;
			((Control)Zo).AutoSize = true;
			((UserControl)Zo).AutoSizeMode = (AutoSizeMode)0;
			((Control)Zo).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f);
			((Control)Zo).Location = new Point(98, 173);
			((Control)Zo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zQ();
			((Control)Zo).Size = new Size(232, 23);
			((Control)Zo).TabIndex = 9;
			((Control)ZO).AutoSize = true;
			((UserControl)ZO).AutoSizeMode = (AutoSizeMode)0;
			((Control)ZO).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f);
			((Control)ZO).Location = new Point(98, 23);
			((Control)ZO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zq();
			((Control)ZO).Size = new Size(232, 23);
			((Control)ZO).TabIndex = 1;
			((ComboBox)zE).DrawMode = (DrawMode)1;
			((ComboBox)zE).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)zE).FormattingEnabled = true;
			((Control)zE).Location = new Point(658, 24);
			((Control)zE).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zR();
			((Control)zE).Size = new Size(116, 23);
			((Control)zE).TabIndex = 6;
			((Control)zE).Click += new EventHandler(L);
			((ComboBox)ze).DrawMode = (DrawMode)1;
			((ComboBox)ze).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)ze).FormattingEnabled = true;
			((Control)ze).Location = new Point(658, 174);
			((Control)ze).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zr();
			((Control)ze).Size = new Size(116, 23);
			((Control)ze).TabIndex = 14;
			((Control)ze).Click += new EventHandler(L);
			((ComboBox)zF).DrawMode = (DrawMode)1;
			((ComboBox)zF).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)zF).FormattingEnabled = true;
			((Control)zF).Location = new Point(658, 324);
			((Control)zF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zS();
			((Control)zF).Size = new Size(116, 23);
			((Control)zF).TabIndex = 22;
			((Control)zF).Click += new EventHandler(L);
			((Control)zf).AutoSize = true;
			((Control)zf).Location = new Point(666, 159);
			((Control)zf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zs();
			((Control)zf).Size = new Size(84, 13);
			((Control)zf).TabIndex = 35;
			((Control)zf).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zT();
			((Control)zG).AutoSize = true;
			((Control)zG).Location = new Point(666, 309);
			((Control)zG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zt();
			((Control)zG).Size = new Size(84, 13);
			((Control)zG).TabIndex = 36;
			((Control)zG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zT();
			((Control)zg).AutoSize = true;
			((Control)zg).Location = new Point(666, 9);
			((Control)zg).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zU();
			((Control)zg).Size = new Size(84, 13);
			((Control)zg).TabIndex = 37;
			((Control)zg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zT();
			((Control)zH).Location = new Point(368, 23);
			((Control)zH).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zu();
			((Control)zH).Size = new Size(55, 23);
			((Control)zH).TabIndex = 2;
			((Control)zH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zV();
			((ButtonBase)zH).UseVisualStyleBackColor = true;
			((Control)zH).Click += new EventHandler(d);
			((Control)zh).Location = new Point(368, 173);
			((Control)zh).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zv();
			((Control)zh).Size = new Size(55, 23);
			((Control)zh).TabIndex = 10;
			((Control)zh).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zV();
			((ButtonBase)zh).UseVisualStyleBackColor = true;
			((Control)zh).Click += new EventHandler(E);
			((Control)zI).Location = new Point(368, 323);
			((Control)zI).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zW();
			((Control)zI).Size = new Size(55, 23);
			((Control)zI).TabIndex = 18;
			((Control)zI).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zV();
			((ButtonBase)zI).UseVisualStyleBackColor = true;
			((Control)zI).Click += new EventHandler(e);
			((Control)zi).BackColor = Color.Transparent;
			zi.Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zw());
			((Control)zi).Location = new Point(753, 4);
			((Control)zi).Margin = new Padding(0);
			((Control)zi).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zX();
			((Control)zi).Size = new Size(18, 18);
			zi.SizeMode = (PictureBoxSizeMode)4;
			zi.TabIndex = 41;
			zi.TabStop = false;
			((Control)zi).Click += new EventHandler(j);
			((Control)zJ).BackColor = Color.Transparent;
			zJ.Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zx());
			((Control)zJ).Location = new Point(753, 154);
			((Control)zJ).Margin = new Padding(0);
			((Control)zJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zY();
			((Control)zJ).Size = new Size(18, 18);
			zJ.SizeMode = (PictureBoxSizeMode)4;
			zJ.TabIndex = 42;
			zJ.TabStop = false;
			((Control)zJ).Click += new EventHandler(K);
			((Control)zj).BackColor = Color.Transparent;
			zj.Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zy());
			((Control)zj).Location = new Point(753, 304);
			((Control)zj).Margin = new Padding(0);
			((Control)zj).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zZ();
			((Control)zj).Size = new Size(18, 18);
			zj.SizeMode = (PictureBoxSizeMode)4;
			zj.TabIndex = 43;
			zj.TabStop = false;
			((Control)zj).Click += new EventHandler(k);
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)Zr;
			((Form)this).ClientSize = new Size(784, 502);
			((Control)this).Controls.Add((Control)(object)zj);
			((Control)this).Controls.Add((Control)(object)zJ);
			((Control)this).Controls.Add((Control)(object)zi);
			((Control)this).Controls.Add((Control)(object)zI);
			((Control)this).Controls.Add((Control)(object)zh);
			((Control)this).Controls.Add((Control)(object)zH);
			((Control)this).Controls.Add((Control)(object)zg);
			((Control)this).Controls.Add((Control)(object)zG);
			((Control)this).Controls.Add((Control)(object)zf);
			((Control)this).Controls.Add((Control)(object)zF);
			((Control)this).Controls.Add((Control)(object)ze);
			((Control)this).Controls.Add((Control)(object)zE);
			((Control)this).Controls.Add((Control)(object)zd);
			((Control)this).Controls.Add((Control)(object)zD);
			((Control)this).Controls.Add((Control)(object)zc);
			((Control)this).Controls.Add((Control)(object)zC);
			((Control)this).Controls.Add((Control)(object)zb);
			((Control)this).Controls.Add((Control)(object)zB);
			((Control)this).Controls.Add((Control)(object)Zz);
			((Control)this).Controls.Add((Control)(object)zA);
			((Control)this).Controls.Add((Control)(object)za);
			((Control)this).Controls.Add((Control)(object)ZY);
			((Control)this).Controls.Add((Control)(object)Zy);
			((Control)this).Controls.Add((Control)(object)ZZ);
			((Control)this).Controls.Add((Control)(object)Zx);
			((Control)this).Controls.Add((Control)(object)ZX);
			((Control)this).Controls.Add((Control)(object)Zw);
			((Control)this).Controls.Add((Control)(object)ZW);
			((Control)this).Controls.Add((Control)(object)Zv);
			((Control)this).Controls.Add((Control)(object)ZV);
			((Control)this).Controls.Add((Control)(object)Zu);
			((Control)this).Controls.Add((Control)(object)ZU);
			((Control)this).Controls.Add((Control)(object)Zt);
			((Control)this).Controls.Add((Control)(object)ZT);
			((Control)this).Controls.Add((Control)(object)Zs);
			((Control)this).Controls.Add((Control)(object)ZS);
			((Control)this).Controls.Add((Control)(object)Zr);
			((Control)this).Controls.Add((Control)(object)ZR);
			((Control)this).Controls.Add((Control)(object)Zq);
			((Control)this).Controls.Add((Control)(object)ZQ);
			((Control)this).Controls.Add((Control)(object)Zp);
			((Control)this).Controls.Add((Control)(object)ZP);
			((Control)this).Controls.Add((Control)(object)Zo);
			((Control)this).Controls.Add((Control)(object)ZO);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.zz();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pe();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).Click += new EventHandler(L);
			((ISupportInitialize)ZS).EndInit();
			((ISupportInitialize)Zs).EndInit();
			((ISupportInitialize)ZT).EndInit();
			((ISupportInitialize)zB).EndInit();
			((ISupportInitialize)zb).EndInit();
			((ISupportInitialize)zC).EndInit();
			((ISupportInitialize)zi).EndInit();
			((ISupportInitialize)zJ).EndInit();
			((ISupportInitialize)zj).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class bb : Form
	{
		private int zK;

		private int zk;

		private int zL;

		private int zl;

		private int zM;

		private int zm;

		private List<int> zN = new List<int>();

		private IContainer zn;

		private ThemedButton zO;

		private ThemedButton zo;

		private ThemedTextBox zP;

		private ThemedTextBox zp;

		private ThemedTextBox zQ;

		private Label zq;

		private Label zR;

		private Label zr;

		private Label zS;

		private Label zs;

		private Label zT;

		private Label zt;

		private Label zU;

		private Label zu;

		private Label zV;

		private Label zv;

		internal bb(int P_0, int P_1, int P_2, int P_3, int P_4, int P_5, int P_6)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			B();
			((Control)this).BackColor = BM.td;
			((Control)zq).ForeColor = BM.te;
			((Control)zR).ForeColor = BM.te;
			((Control)zr).ForeColor = BM.te;
			((Control)zU).ForeColor = BM.te;
			((Control)zt).ForeColor = BM.te;
			((Control)zT).ForeColor = BM.te;
			((Control)zP).BackColor = BM.to;
			((Control)zP).ForeColor = BM.te;
			((Control)zp).BackColor = BM.to;
			((Control)zp).ForeColor = BM.te;
			((Control)zQ).BackColor = BM.to;
			((Control)zQ).ForeColor = BM.te;
			zK = P_0;
			zk = P_3;
			zL = P_4;
			zl = P_5;
			zM = P_6;
			zm = P_1;
			Label obj = zU;
			Label obj2 = zt;
			string text2 = (((Control)zT).Text = bS.A(P_2, P_1, false, 0));
			string text4 = (((Control)obj2).Text = text2);
			((Control)obj).Text = text4;
		}

		[SpecialName]
		internal List<int> A()
		{
			return zN;
		}

		private void a()
		{
			((Control)zu).Visible = false;
			((Control)zs).Visible = false;
			((Control)zS).Visible = false;
			((Control)zV).Visible = false;
			((Control)zv).Visible = false;
			double num = default(double);
			double num2 = default(double);
			if (double.TryParse(((Control)zP).Text, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture, ref num) && double.TryParse(((Control)zp).Text, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture, ref num2))
			{
				int num3 = bS.A(num, zm);
				int num4 = bS.A(num2, zm);
				if (num3 > num4)
				{
					((Control)zu).Visible = true;
					return;
				}
			}
			double num5 = default(double);
			if (double.TryParse(((Control)zP).Text, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture, ref num) && double.TryParse(((Control)zp).Text, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture, ref num2) && double.TryParse(((Control)zQ).Text, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture, ref num5))
			{
				int num6 = bS.A(num, zm);
				int num7 = bS.A(num2, zm);
				int num8 = bS.A(num5, zm) - bS.A(0.0, zm);
				if (num8 != 0)
				{
					int num9 = num7 - num6;
					if (num9 / num8 + 1 > zK)
					{
						((Control)zs).Visible = true;
						return;
					}
					if (num8 > num9)
					{
						((Control)zV).Visible = true;
						return;
					}
					if (num9 % num8 != 0)
					{
						((Control)zS).Visible = true;
						return;
					}
				}
			}
			if (double.TryParse(((Control)zP).Text, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture, ref num))
			{
				int num10 = bS.A(num, zm);
				if (num10 < zk || num10 > zL)
				{
					((Control)zV).Visible = true;
					return;
				}
				if (num10 < zl || num10 > zM)
				{
					((Control)zv).Visible = true;
					return;
				}
			}
			if (double.TryParse(((Control)zp).Text, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture, ref num2))
			{
				int num11 = bS.A(num2, zm);
				if (num11 < zk || num11 > zL)
				{
					((Control)zV).Visible = true;
				}
				else if (num11 < zl || num11 > zM)
				{
					((Control)zv).Visible = true;
				}
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			a();
		}

		private void a(object P_0, EventArgs P_1)
		{
			a();
		}

		private void B(object P_0, EventArgs P_1)
		{
			a();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			if ((int)((Form)this).DialogResult != 1)
			{
				return;
			}
			zN.Clear();
			double num = default(double);
			if (!double.TryParse(((Control)zP).Text, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture, ref num))
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAA(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((CancelEventArgs)P_1).Cancel = true;
				return;
			}
			double num2 = default(double);
			if (!double.TryParse(((Control)zp).Text, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture, ref num2))
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAa(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((CancelEventArgs)P_1).Cancel = true;
				return;
			}
			double num3 = default(double);
			if (!double.TryParse(((Control)zQ).Text, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture, ref num3))
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAB(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((CancelEventArgs)P_1).Cancel = true;
				return;
			}
			int num4 = bS.A(num, zm);
			int num5 = bS.A(num2, zm);
			int num6 = bS.A(num3, zm) - bS.A(0.0, zm);
			if (num4 > num5)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAb(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((CancelEventArgs)P_1).Cancel = true;
				return;
			}
			int num7 = num5 - num4;
			if (num6 == 0)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fQ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((CancelEventArgs)P_1).Cancel = true;
				return;
			}
			if (num7 / num6 + 1 > zK)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((CancelEventArgs)P_1).Cancel = true;
				return;
			}
			if (num6 > num7 || num4 < zk || num4 > zL || num5 < zk || num5 > zL)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAc(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((CancelEventArgs)P_1).Cancel = true;
				return;
			}
			try
			{
				int num8 = num4;
				for (int i = 0; i <= num7 / num6; i++)
				{
					zN.Add(num8);
					if (i != num7 / num6)
					{
						num8 += num6;
					}
				}
				if (num8 != num5)
				{
					zN.Add(num5);
				}
			}
			catch
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fQ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((CancelEventArgs)P_1).Cancel = true;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && zn != null)
			{
				((System.IDisposable)zn).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void B()
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Expected O, but got Unknown
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Expected O, but got Unknown
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Expected O, but got Unknown
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0328: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0389: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0410: Unknown result type (might be due to invalid IL or missing references)
			//IL_0437: Unknown result type (might be due to invalid IL or missing references)
			//IL_047c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0490: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0503: Unknown result type (might be due to invalid IL or missing references)
			//IL_0527: Unknown result type (might be due to invalid IL or missing references)
			//IL_0567: Unknown result type (might be due to invalid IL or missing references)
			//IL_058b: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0628: Unknown result type (might be due to invalid IL or missing references)
			//IL_063c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0663: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0728: Unknown result type (might be due to invalid IL or missing references)
			//IL_073c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0763: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0904: Expected O, but got Unknown
			//IL_094c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0956: Expected O, but got Unknown
			zO = new ThemedButton();
			zo = new ThemedButton();
			zP = new ThemedTextBox();
			zp = new ThemedTextBox();
			zQ = new ThemedTextBox();
			zq = new Label();
			zR = new Label();
			zr = new Label();
			zS = new Label();
			zs = new Label();
			zT = new Label();
			zt = new Label();
			zU = new Label();
			zu = new Label();
			zV = new Label();
			zv = new Label();
			((Control)this).SuspendLayout();
			((Button)zO).DialogResult = (DialogResult)2;
			((Control)zO).Location = new Point(166, 136);
			((Control)zO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)zO).Size = new Size(92, 30);
			((Control)zO).TabIndex = 4;
			((Control)zO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)zO).UseVisualStyleBackColor = true;
			((Button)zo).DialogResult = (DialogResult)1;
			((Control)zo).Location = new Point(67, 136);
			((Control)zo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)zo).Size = new Size(93, 30);
			((Control)zo).TabIndex = 3;
			((Control)zo).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)zo).UseVisualStyleBackColor = true;
			((Control)zP).Location = new Point(130, 9);
			((Control)zP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAD();
			((Control)zP).Size = new Size(100, 22);
			((Control)zP).TabIndex = 0;
			((Control)zP).Leave += new EventHandler(A);
			((Control)zp).Location = new Point(130, 37);
			((Control)zp).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAd();
			((Control)zp).Size = new Size(100, 22);
			((Control)zp).TabIndex = 1;
			((Control)zp).Leave += new EventHandler(a);
			((Control)zQ).Location = new Point(130, 65);
			((Control)zQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAE();
			((Control)zQ).Size = new Size(100, 22);
			((Control)zQ).TabIndex = 2;
			((Control)zQ).Leave += new EventHandler(B);
			((Control)zq).AutoSize = true;
			((Control)zq).Location = new Point(11, 13);
			((Control)zq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)zq).Size = new Size(88, 13);
			((Control)zq).TabIndex = 31;
			((Control)zq).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAe();
			((Control)zR).AutoSize = true;
			((Control)zR).Location = new Point(11, 41);
			((Control)zR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)zR).Size = new Size(84, 13);
			((Control)zR).TabIndex = 32;
			((Control)zR).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAF();
			((Control)zr).AutoSize = true;
			((Control)zr).Location = new Point(11, 69);
			((Control)zr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
			((Control)zr).Size = new Size(115, 13);
			((Control)zr).TabIndex = 33;
			((Control)zr).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAf();
			((Control)zS).AutoSize = true;
			((Control)zS).ForeColor = Color.Orange;
			((Control)zS).Location = new Point(12, 99);
			((Control)zS).MaximumSize = new Size(300, 0);
			((Control)zS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAG();
			((Control)zS).Size = new Size(299, 26);
			((Control)zS).TabIndex = 34;
			((Control)zS).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAg();
			((Control)zS).Visible = false;
			((Control)zs).AutoSize = true;
			((Control)zs).ForeColor = Color.Red;
			((Control)zs).Location = new Point(12, 105);
			((Control)zs).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAH();
			((Control)zs).Size = new Size(207, 13);
			((Control)zs).TabIndex = 35;
			((Control)zs).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAC();
			((Control)zs).Visible = false;
			((Control)zT).AutoSize = true;
			((Control)zT).Location = new Point(236, 69);
			((Control)zT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAh();
			((Control)zT).Size = new Size(34, 13);
			((Control)zT).TabIndex = 38;
			((Control)zT).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ck();
			((Control)zt).AutoSize = true;
			((Control)zt).Location = new Point(236, 41);
			((Control)zt).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAI();
			((Control)zt).Size = new Size(34, 13);
			((Control)zt).TabIndex = 37;
			((Control)zt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ck();
			((Control)zU).AutoSize = true;
			((Control)zU).Location = new Point(236, 13);
			((Control)zU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAi();
			((Control)zU).Size = new Size(34, 13);
			((Control)zU).TabIndex = 36;
			((Control)zU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ck();
			((Control)zu).AutoSize = true;
			((Control)zu).ForeColor = Color.Red;
			((Control)zu).Location = new Point(12, 105);
			((Control)zu).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAJ();
			((Control)zu).Size = new Size(265, 13);
			((Control)zu).TabIndex = 39;
			((Control)zu).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAb();
			((Control)zu).Visible = false;
			((Control)zV).AutoSize = true;
			((Control)zV).ForeColor = Color.Red;
			((Control)zV).Location = new Point(12, 105);
			((Control)zV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAj();
			((Control)zV).Size = new Size(188, 13);
			((Control)zV).TabIndex = 40;
			((Control)zV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAc();
			((Control)zV).Visible = false;
			((Control)zv).AutoSize = true;
			((Control)zv).ForeColor = Color.Orange;
			((Control)zv).Location = new Point(12, 105);
			((Control)zv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAK();
			((Control)zv).Size = new Size(244, 13);
			((Control)zv).TabIndex = 41;
			((Control)zv).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAk();
			((Control)zv).Visible = false;
			((Form)this).AcceptButton = (IButtonControl)(object)zo;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)zO;
			((Form)this).ClientSize = new Size(324, 176);
			((Control)this).Controls.Add((Control)(object)zv);
			((Control)this).Controls.Add((Control)(object)zV);
			((Control)this).Controls.Add((Control)(object)zu);
			((Control)this).Controls.Add((Control)(object)zT);
			((Control)this).Controls.Add((Control)(object)zt);
			((Control)this).Controls.Add((Control)(object)zU);
			((Control)this).Controls.Add((Control)(object)zs);
			((Control)this).Controls.Add((Control)(object)zS);
			((Control)this).Controls.Add((Control)(object)zr);
			((Control)this).Controls.Add((Control)(object)zR);
			((Control)this).Controls.Add((Control)(object)zq);
			((Control)this).Controls.Add((Control)(object)zQ);
			((Control)this).Controls.Add((Control)(object)zp);
			((Control)this).Controls.Add((Control)(object)zP);
			((Control)this).Controls.Add((Control)(object)zO);
			((Control)this).Controls.Add((Control)(object)zo);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAL();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAl();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
