using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;

namespace NSP.SettingsFramework;

public class WiringPin
{
	internal class A
	{
		internal Cg Bsk;

		internal CH BsL;

		internal byte Bsl;

		internal ushort BsM;

		internal int Bsm;

		internal A(uint P_0, int P_1)
		{
			Bsk = PortFunction.A(P_0);
			BsL = PortFunction.a(P_0);
			Bsl = PortFunction.B(P_0);
			BsM = PortFunction.b(P_0);
			Bsm = P_1;
		}
	}

	internal class a
	{
		internal string BsN;

		internal int Bsn;

		internal a(string P_0, int P_1)
		{
			BsN = P_0;
			Bsn = P_1;
		}
	}

	internal const int BbP = 100;

	internal const int Bbp = 23;

	internal Framework BbQ;

	internal SpecialObject Bbq;

	internal string BbR = string.Empty;

	internal string Bbr = string.Empty;

	internal string BbS = string.Empty;

	internal string Bbs = string.Empty;

	internal int BbT = -1;

	internal bool Bbt;

	internal string BbU = string.Empty;

	internal string Bbu = string.Empty;

	internal int BbV;

	internal bool Bbv;

	internal Point BbW;

	internal Point Bbw;

	internal Size BbX;

	internal int Bbx = -1;

	internal int BbY = -1;

	private List<a> Bby = new List<a>();

	private a BbZ;

	private List<A> Bbz = new List<A>();

	private List<A> BCA = new List<A>();

	internal static Image BCa;

	internal static Image BCB;

	internal static Image BCb;

	internal static Image BCC;

	internal static Image BCc;

	internal static Image BCD;

	internal static string[] BCd = new string[14]
	{
		D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vc(),
		D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTY(),
		D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mO(),
		D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGi(),
		D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.me(),
		D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahq(),
		D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTy(),
		D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md(),
		D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jZ(),
		D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTv(),
		D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTw(),
		D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTX(),
		D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTx(),
		D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTW()
	};

	public WiringPin(Framework framework, SpecialObject ownerObject)
	{
		BbQ = framework;
		Bbq = ownerObject;
	}

	public virtual string ToString()
	{
		return BbR;
	}

	internal bool A()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = BbW;
		if (((Point)(ref BbW)).X == 0)
		{
			return ((Point)(ref BbW)).Y != 0;
		}
		return true;
	}

	internal bool a()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = Bbw;
		if (((Point)(ref Bbw)).X == 0)
		{
			return ((Point)(ref Bbw)).Y != 0;
		}
		return true;
	}

	internal void A(uint P_0, int P_1)
	{
		A a = new A(P_0, P_1);
		Bbz.Add(a);
	}

	internal List<A> B()
	{
		return Bbz;
	}

	internal List<A> b()
	{
		return BCA;
	}

	internal void A(string P_0, int P_1)
	{
		a a = new a(P_0, P_1);
		Bby.Add(a);
	}

	internal List<a> C()
	{
		return Bby;
	}

	internal a c()
	{
		return BbZ;
	}

	internal void D()
	{
		BCA.Clear();
		for (int i = 0; i < Bbz.Count; i++)
		{
			A a = Bbz[i];
			if (a.Bsm == -1)
			{
				BCA.Add(a);
			}
		}
		BbZ = null;
		for (int j = 0; j < Bby.Count; j++)
		{
			a a2 = Bby[j];
			if (a2.Bsn == -1)
			{
				BbZ = a2;
			}
		}
	}

	internal void A(int P_0)
	{
		for (int i = 0; i < Bbz.Count; i++)
		{
			A a = Bbz[i];
			if (a.Bsm == P_0)
			{
				BCA.Add(a);
			}
		}
		for (int j = 0; j < Bby.Count; j++)
		{
			a a2 = Bby[j];
			if (a2.Bsn == P_0)
			{
				BbZ = a2;
			}
		}
	}

	internal static List<WiringPin> A(Framework P_0, Cg P_1, CH P_2, byte P_3, ushort P_4)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		List<WiringPin> val = new List<WiringPin>();
		Enumerator<WiringPin> enumerator = P_0.awc.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				WiringPin current = enumerator.Current;
				if (!current.Bbq.l())
				{
					continue;
				}
				Enumerator<A> enumerator2 = current.b().GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						A current2 = enumerator2.Current;
						if (P_1 == Cg.BAM)
						{
							if (current2.Bsk == P_1 && current2.BsL == P_2 && current2.BsM == P_4)
							{
								val.Add(current);
							}
						}
						else if (current2.Bsk == P_1 && current2.BsL == P_2 && current2.Bsl == P_3)
						{
							val.Add(current);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
			return val;
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal static void A(float P_0, float P_1, float P_2)
	{
		if (BCa != null)
		{
			BCa.Dispose();
		}
		BCa = (Image)(object)O.A((Image)(object)CL.j(), 1f, 0f, 0f, 0f, 0f, P_0, P_1, P_2);
		if (BCB != null)
		{
			BCB.Dispose();
		}
		BCB = (Image)(object)O.A((Image)(object)CL.i(), 1f, 0f, 0f, 0f, 0f, P_0, P_1, P_2);
		if (BCb != null)
		{
			BCb.Dispose();
		}
		BCb = (Image)(object)O.A((Image)(object)CL.G(), 1f, 0f, 0f, 0f, 0f, P_0, P_1, P_2);
		if (BCC != null)
		{
			BCC.Dispose();
		}
		BCC = (Image)(object)O.A((Image)(object)CL.E(), 1f, 0f, 0f, 0f, 0f, P_0, P_1, P_2);
		if (BCc != null)
		{
			BCc.Dispose();
		}
		BCc = (Image)(object)O.A((Image)(object)CL.e(), 1f, 0f, 0f, 0f, 0f, P_0, P_1, P_2);
		if (BCD != null)
		{
			BCD.Dispose();
		}
		BCD = (Image)(object)O.A((Image)(object)CL.d(), 1f, 0f, 0f, 0f, 0f, P_0, P_1, P_2);
	}

	internal Image d()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<A> enumerator = b().GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				A current = enumerator.Current;
				if ((current.Bsk == Cg.BAf || current.Bsk == Cg.BAF || current.Bsk == Cg.BAh || current.Bsk == Cg.BAI || current.Bsk == Cg.BAi) && current.BsL == CH.Baj)
				{
					return BCa;
				}
				if ((current.Bsk == Cg.BAE || current.Bsk == Cg.BAe || current.Bsk == Cg.BAD || current.Bsk == Cg.BAd || current.Bsk == Cg.BAj) && current.BsL == CH.BaJ)
				{
					return BCB;
				}
				if (current.Bsk == Cg.BAb && current.BsL == CH.Bai && current.Bsl == 0)
				{
					return BCb;
				}
				if (current.Bsk == Cg.BAb && current.BsL == CH.Bak)
				{
					return BCD;
				}
				if ((current.Bsk == Cg.BAb || current.Bsk == Cg.BAr) && current.BsL == CH.BaE)
				{
					Bitmap val = null;
					Image val2 = null;
					switch (current.Bsl)
					{
					case 0:
						val2 = (Image)(object)CL.J();
						break;
					case 1:
						val2 = (Image)(object)CL.D();
						break;
					case 2:
						val2 = (Image)(object)CL.C();
						break;
					case 3:
						val2 = (Image)(object)CL.H();
						break;
					case 4:
						val2 = (Image)(object)CL.g();
						break;
					case 5:
						val2 = (Image)(object)CL.b();
						break;
					}
					if (val2 != null)
					{
						val = new Bitmap(Math.Max(val2.Width, 100), val2.Height);
						Graphics obj = Graphics.FromImage((Image)(object)val);
						obj.DrawImage(val2, (val2.Width < 100) ? ((100 - val2.Width) / 2) : 0, 0);
						obj.Dispose();
					}
					if (val != null)
					{
						return (Image)(object)val;
					}
					return null;
				}
				if (current.Bsk == Cg.BAM)
				{
					Bitmap val3 = new Bitmap(100, 25);
					Graphics val4 = Graphics.FromImage((Image)(object)val3);
					SolidBrush val5 = new SolidBrush(Color.FromArgb((int)(BM.TX * 255f), (int)(BM.Tx * 255f), (int)(BM.TY * 255f)));
					try
					{
						Font val6 = new Font(Control.DefaultFont.FontFamily, 13f, (FontStyle)1);
						try
						{
							val4.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hq(), val6, (Brush)(object)val5, 17f, 0f);
						}
						finally
						{
							((System.IDisposable)val6)?.Dispose();
						}
					}
					finally
					{
						((System.IDisposable)val5)?.Dispose();
					}
					val4.Dispose();
					return (Image)(object)val3;
				}
				if (current.Bsk == Cg.BAb && current.BsL == CH.Bag)
				{
					Bitmap val7 = new Bitmap(100, 60);
					Graphics val8 = Graphics.FromImage((Image)(object)val7);
					SolidBrush val9 = new SolidBrush(Color.FromArgb((int)(BM.TX * 255f), (int)(BM.Tx * 255f), (int)(BM.TY * 255f)));
					try
					{
						Font val10 = new Font(Control.DefaultFont.FontFamily, 10f, (FontStyle)1);
						try
						{
							val8.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTq(), val10, (Brush)(object)val9, 1f, 3f);
						}
						finally
						{
							((System.IDisposable)val10)?.Dispose();
						}
						Font val11 = new Font(Control.DefaultFont.FontFamily, 8f);
						try
						{
							val8.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTR(), val11, (Brush)(object)val9, 17f, 23f);
							val8.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTr(), val11, (Brush)(object)val9, 17f, 40f);
						}
						finally
						{
							((System.IDisposable)val11)?.Dispose();
						}
					}
					finally
					{
						((System.IDisposable)val9)?.Dispose();
					}
					val8.Dispose();
					return (Image)(object)val7;
				}
				if ((current.Bsk == Cg.BAK || current.Bsk == Cg.BAk || current.Bsk == Cg.BAL || current.Bsk == Cg.BAl) && current.BsL == CH.BaE)
				{
					Bitmap val12 = null;
					if (current.Bsk == Cg.BAK || current.Bsk == Cg.BAk)
					{
						val12 = new Bitmap(Math.Max(BCC.Width, 100), BCC.Height);
						Graphics val13 = Graphics.FromImage((Image)(object)val12);
						int num = ((BCC.Width < 100) ? ((100 - BCC.Width) / 2) : 0);
						val13.DrawImage(BCC, num, 0);
						if (current.Bsl < 4)
						{
							val13.FillRectangle(Brushes.DodgerBlue, num + 11 + current.Bsl * 15, 16, 14, 23);
						}
						else
						{
							val13.FillRectangle(Brushes.DodgerBlue, num + 11 + (current.Bsl - 4) * 15, 41, 14, 23);
						}
						val13.Dispose();
					}
					else if (current.Bsk == Cg.BAL || current.Bsk == Cg.BAl)
					{
						val12 = new Bitmap(Math.Max(BCc.Width, 100), BCc.Height);
						Graphics val14 = Graphics.FromImage((Image)(object)val12);
						int num2 = ((BCc.Width < 100) ? ((100 - BCc.Width) / 2) : 0);
						val14.DrawImage(BCc, num2, 0);
						if (current.Bsl < 5)
						{
							val14.FillRectangle(Brushes.DodgerBlue, num2 + 8 + current.Bsl * 13, 11, 12, 18);
						}
						else if (current.Bsl < 10)
						{
							val14.FillRectangle(Brushes.DodgerBlue, num2 + 8 + (current.Bsl - 5) * 13, 31, 12, 18);
						}
						else
						{
							val14.FillRectangle(Brushes.DodgerBlue, num2 + 8 + (current.Bsl - 10) * 13, 51, 12, 18);
						}
						val14.Dispose();
					}
					if (val12 != null)
					{
						return (Image)(object)val12;
					}
					return null;
				}
				if (current.BsL == CH.BaN && BbU == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTS())
				{
					return (Image)(object)CL.I();
				}
				if (current.BsL == CH.BaN && BbU == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTs())
				{
					return (Image)(object)CL.h();
				}
				if (current.BsL == CH.BaN && BbU == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTT())
				{
					return (Image)(object)CL.f();
				}
				if (current.BsL == CH.BaN && BbU == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTt())
				{
					return (Image)(object)CL.F();
				}
				return (Image)(object)A(F(), f(), Bbt, BbU == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IZ() || BbU == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTU() || current.Bsk == Cg.BAJ, false);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return null;
	}

	internal string A(bool P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<A> enumerator = b().GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				A current = enumerator.Current;
				if ((current.Bsk == Cg.BAf || current.Bsk == Cg.BAF || current.Bsk == Cg.BAh || current.Bsk == Cg.BAI || current.Bsk == Cg.BAi) && current.BsL == CH.Baj)
				{
					return string.Empty;
				}
				if ((current.Bsk == Cg.BAE || current.Bsk == Cg.BAe || current.Bsk == Cg.BAD || current.Bsk == Cg.BAd || current.Bsk == Cg.BAj) && current.BsL == CH.BaJ)
				{
					return string.Empty;
				}
				if (current.Bsk == Cg.BAb && current.BsL == CH.Bai && current.Bsl == 0)
				{
					return string.Empty;
				}
				if (current.Bsk == Cg.BAb && current.BsL == CH.Bak)
				{
					return string.Empty;
				}
				if ((current.Bsk == Cg.BAb || current.Bsk == Cg.BAr) && current.BsL == CH.BaE)
				{
					return string.Empty;
				}
				if (current.Bsk == Cg.BAM)
				{
					return string.Empty;
				}
				if (current.Bsk == Cg.BAb && current.BsL == CH.Bag)
				{
					return string.Empty;
				}
				if ((current.Bsk == Cg.BAK || current.Bsk == Cg.BAk || current.Bsk == Cg.BAL || current.Bsk == Cg.BAl) && current.BsL == CH.BaE)
				{
					return string.Empty;
				}
				if (current.BsL == CH.BaN && BbU == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTS())
				{
					return string.Empty;
				}
				if (current.BsL == CH.BaN && BbU == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTs())
				{
					return string.Empty;
				}
				if (current.BsL == CH.BaN && BbU == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTT())
				{
					return string.Empty;
				}
				if (current.BsL == CH.BaN && BbU == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTt())
				{
					return string.Empty;
				}
				string text = string.Empty;
				string text2 = G();
				if (!string.IsNullOrEmpty(text2))
				{
					text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTu() + text2;
					string text3 = g();
					if (!string.IsNullOrEmpty(text3) && text3 != text2)
					{
						text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK() + text3;
					}
					text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTV();
				}
				if (!string.IsNullOrEmpty(Bbs))
				{
					if (text.Length != 0)
					{
						text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY();
					}
					text += Bbs;
				}
				if (P_0 && !string.IsNullOrEmpty(BbR))
				{
					if (text.Length != 0)
					{
						text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY();
					}
					text += BbR;
				}
				return text;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return string.Empty;
	}

	internal string E()
	{
		if (c() != null)
		{
			return c().BsN;
		}
		return null;
	}

	internal static Bitmap A(int P_0, int P_1, Color P_2, Color P_3, bool P_4, bool P_5, bool P_6)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		Bitmap val = new Bitmap(P_0 + 1, P_1 + 1);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.Clear(Color.Transparent);
		if (P_6)
		{
			val2.SmoothingMode = (SmoothingMode)2;
			Pen val3 = new Pen(Color.Black, 2f);
			try
			{
				val2.DrawLine(val3, 2, 2, P_0 - 2, P_1 - 2);
				val2.DrawLine(val3, 2, P_1 - 2, P_0 - 2, 2);
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
			val2.DrawEllipse(Pens.Black, 0, 0, P_0, P_1);
		}
		else if (P_5)
		{
			val2.SmoothingMode = (SmoothingMode)2;
			val2.DrawEllipse(Pens.Black, 0, 0, P_0, P_1);
		}
		else if (P_2 != Color.Transparent)
		{
			val2.SmoothingMode = (SmoothingMode)2;
			Brush val4 = (Brush)new SolidBrush(P_2);
			try
			{
				val2.FillEllipse(val4, 0, 0, P_0, P_1);
			}
			finally
			{
				((System.IDisposable)val4)?.Dispose();
			}
			if (P_3 != Color.Transparent && P_3 != P_2)
			{
				Pen val5 = new Pen(P_3, 3f);
				try
				{
					val2.SmoothingMode = (SmoothingMode)3;
					val2.DrawLine(val5, P_0 / 2, 0, P_0 / 2, P_1);
				}
				finally
				{
					((System.IDisposable)val5)?.Dispose();
				}
			}
			if (P_4)
			{
				val2.SmoothingMode = (SmoothingMode)2;
				val2.DrawEllipse(Pens.Silver, 1, 1, P_0 - 2, P_1 - 2);
			}
			val2.SmoothingMode = (SmoothingMode)2;
			val2.DrawEllipse(Pens.Black, 0, 0, P_0, P_1);
		}
		val2.Dispose();
		return val;
	}

	internal static Bitmap A(Color P_0, Color P_1, bool P_2, bool P_3, bool P_4)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		Bitmap val = new Bitmap(100, 22);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.SmoothingMode = (SmoothingMode)2;
		if (P_3)
		{
			val2.FillRectangle(Brushes.Black, 37, 1, 56, 19);
			val2.FillEllipse(Brushes.Black, 31, 1, 14, 19);
			val2.FillEllipse(Brushes.Black, 86, 1, 14, 19);
			Font val3 = new Font(Control.DefaultFont.FontFamily, 12f, (FontStyle)1);
			try
			{
				StringFormat val4 = new StringFormat();
				try
				{
					val4.Alignment = (StringAlignment)1;
					val4.LineAlignment = (StringAlignment)1;
					val2.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IZ(), val3, Brushes.White, 70f, 12f, val4);
				}
				finally
				{
					((System.IDisposable)val4)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
		}
		else if (P_4)
		{
			val2.FillRectangle(Brushes.White, 37, 1, 56, 19);
			val2.FillEllipse(Brushes.White, 31, 1, 14, 19);
			val2.FillEllipse(Brushes.White, 86, 1, 14, 19);
			Font val5 = new Font(Control.DefaultFont.FontFamily, 16f, (FontStyle)1);
			try
			{
				StringFormat val6 = new StringFormat();
				try
				{
					val6.Alignment = (StringAlignment)1;
					val6.LineAlignment = (StringAlignment)1;
					val2.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ro(), val5, Brushes.Red, 70f, 11f, val6);
				}
				finally
				{
					((System.IDisposable)val6)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val5)?.Dispose();
			}
		}
		else
		{
			Brush val7 = (Brush)new SolidBrush(P_0);
			try
			{
				val2.FillRectangle(val7, 37, 1, 56, 19);
				val2.FillEllipse(val7, 31, 1, 14, 19);
				val2.FillEllipse(val7, 86, 1, 14, 19);
			}
			finally
			{
				((System.IDisposable)val7)?.Dispose();
			}
		}
		val2.DrawLine(Pens.DimGray, 37, 1, 93, 1);
		val2.DrawLine(Pens.DimGray, 37, 20, 93, 20);
		val2.DrawEllipse(Pens.DimGray, new Rectangle(31, 1, 14, 19));
		val2.DrawArc(Pens.DimGray, new Rectangle(85, 1, 14, 19), 270f, 180f);
		if (P_0 != Color.Transparent && P_1 != Color.Transparent && P_1 != P_0 && !P_3 && !P_4)
		{
			Rectangle val8 = default(Rectangle);
			((Rectangle)(ref val8))._002Ector(0, 2, 100, 18);
			val2.SetClip(val8, (CombineMode)0);
			Pen val9 = new Pen(P_1, 12f);
			try
			{
				val2.DrawArc(val9, new Rectangle(-40, -62, 112, 112), 5f, 27f);
			}
			finally
			{
				((System.IDisposable)val9)?.Dispose();
			}
			val2.DrawArc(Pens.DimGray, new Rectangle(-46, -62, 112, 112), 5f, 27f);
			val2.DrawArc(Pens.DimGray, new Rectangle(-34, -62, 112, 112), 5f, 27f);
			val2.ResetClip();
		}
		if (P_2)
		{
			val2.FillRectangle(Brushes.Silver, 18, 3, 19, 15);
			val2.FillEllipse(Brushes.Silver, 15, 3, 9, 15);
			val2.FillEllipse(Brushes.Silver, 33, 3, 9, 15);
			val2.DrawLine(Pens.Black, 20, 3, 37, 3);
			val2.DrawLine(Pens.Black, 20, 18, 37, 18);
			val2.DrawEllipse(Pens.Black, new Rectangle(15, 3, 9, 15));
			val2.DrawArc(Pens.Black, new Rectangle(33, 3, 9, 15), 270f, 180f);
			val2.FillRectangle(Brushes.SandyBrown, 4, 4, 14, 13);
			val2.FillEllipse(Brushes.SandyBrown, 0, 4, 9, 13);
			val2.FillEllipse(Brushes.SandyBrown, 15, 4, 9, 13);
			val2.DrawLine(Pens.Black, 4, 4, 19, 4);
			val2.DrawLine(Pens.Black, 4, 17, 19, 17);
			val2.DrawEllipse(Pens.Black, new Rectangle(0, 4, 9, 13));
			val2.DrawArc(Pens.Black, new Rectangle(15, 4, 9, 13), 270f, 180f);
		}
		else
		{
			if (P_4)
			{
				val2.FillRectangle(Brushes.White, 4, 4, 31, 13);
				val2.FillEllipse(Brushes.White, 0, 4, 9, 13);
				val2.FillEllipse(Brushes.White, 32, 4, 9, 13);
			}
			else
			{
				val2.FillRectangle(Brushes.SandyBrown, 4, 4, 31, 13);
				val2.FillEllipse(Brushes.SandyBrown, 0, 4, 9, 13);
				val2.FillEllipse(Brushes.SandyBrown, 32, 4, 9, 13);
			}
			val2.DrawLine(Pens.Black, 4, 4, 36, 4);
			val2.DrawLine(Pens.Black, 4, 17, 36, 17);
			val2.DrawEllipse(Pens.Black, new Rectangle(0, 4, 9, 13));
			val2.DrawArc(Pens.Black, new Rectangle(32, 4, 9, 13), 270f, 180f);
		}
		val2.Dispose();
		return val;
	}

	internal static Color A(string P_0)
	{
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(P_0) && P_0 != null)
		{
			switch (P_0.Length)
			{
			case 1:
				switch (P_0[0])
				{
				case 'B':
					return Color.Black;
				case 'W':
					return Color.White;
				case 'R':
					return Color.Red;
				case 'G':
					return Color.Green;
				case 'L':
					return Color.MediumBlue;
				case 'O':
					return Color.DarkOrange;
				case 'Y':
					return Color.Yellow;
				case 'P':
					return Color.HotPink;
				case 'V':
					return Color.Purple;
				}
				break;
			case 2:
				switch (P_0[1])
				{
				case 'Y':
					if (!(P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTv()))
					{
						if (!(P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTW()))
						{
							break;
						}
						return Color.Khaki;
					}
					return Color.Gray;
				case 'R':
					if (!(P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTw()))
					{
						break;
					}
					return Color.SaddleBrown;
				case 'L':
					if (!(P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTX()))
					{
						break;
					}
					return Color.LightBlue;
				case 'G':
					if (!(P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTx()))
					{
						break;
					}
					return Color.LightGreen;
				}
				break;
			}
		}
		return Color.Transparent;
	}

	internal bool e()
	{
		if (Bbx != -1 && BbY != -1 && !string.IsNullOrEmpty(BbU))
		{
			Setting setting = BbQ.A(Bbx);
			if (setting != null && BbY < setting.Ba() && setting.aG() == 2)
			{
				return true;
			}
		}
		return false;
	}

	internal Color F()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (e())
		{
			byte b = (byte)((uint)(BbQ.A(Bbx).m(BbY) >> 8) & 0xFFu);
			switch (b)
			{
			case 0:
				return A(BbU);
			default:
				if (b <= BCd.Length)
				{
					return A(BCd[b - 1]);
				}
				break;
			case 255:
				break;
			}
			return Color.Transparent;
		}
		return A(BbU);
	}

	internal Color f()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (e())
		{
			byte b = (byte)((uint)BbQ.A(Bbx).m(BbY) & 0xFFu);
			switch (b)
			{
			case 0:
				return A(Bbu);
			default:
				if (b <= BCd.Length)
				{
					return A(BCd[b - 1]);
				}
				break;
			case 255:
				break;
			}
			return Color.Transparent;
		}
		return A(Bbu);
	}

	internal string G()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		Color val = F();
		string[] bCd = BCd;
		foreach (string text in bCd)
		{
			if (A(text) == val)
			{
				return text;
			}
		}
		return null;
	}

	internal string g()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		Color val = f();
		string[] bCd = BCd;
		foreach (string text in bCd)
		{
			if (A(text) == val)
			{
				return text;
			}
		}
		return null;
	}

	internal void A(byte P_0, byte P_1)
	{
		if (e())
		{
			Setting setting = BbQ.A(Bbx);
			Ck ck = BM.aM();
			ck?.A(Bbx);
			int num = (P_0 << 8) | P_1;
			setting.a(BbY, num, true);
			ck?.B();
			BM.b(Bbx);
		}
	}
}
