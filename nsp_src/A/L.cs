using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using C;
using NSP.Properties;
using b;
using c;

namespace A;

[SupportedOSPlatform("windows")]
internal static class L
{
	[CompilerGenerated]
	private static class A
	{
		public static UnhandledExceptionEventHandler BgL;

		public static ThreadExceptionEventHandler Bgl;
	}

	[STAThread]
	private static void A(string[] P_0)
	{
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		bx.A();
		bool flag = false;
		foreach (string text in P_0)
		{
			if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bt()))
			{
				flag = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bt().Length));
			}
		}
		if (!flag)
		{
			((ApplicationSettingsBase)Settings.Default).Upgrade();
			((SettingsBase)Settings.Default).Save();
			N.A();
			Application.SetDefaultFont(new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f));
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
		}
		bool flag2 = false;
		bool flag3 = false;
		string text2 = null;
		bool flag4 = false;
		string text3 = null;
		bool flag5 = false;
		if (!flag2)
		{
			flag2 = A(P_0, ref flag3, ref text2, ref flag4);
		}
		if (!flag2)
		{
			flag2 = a(P_0, ref flag3, ref text3, ref flag5);
		}
		if (!flag2)
		{
			B(P_0);
		}
		BM bM = new BM(flag, !flag3);
		if (!flag2)
		{
			flag2 = B(P_0, bM);
		}
		if (!flag2)
		{
			a(P_0);
		}
		if (!flag2)
		{
			flag2 = a(P_0, bM);
		}
		if (!flag2)
		{
			flag2 = b(P_0, bM);
		}
		if (!flag2)
		{
			flag2 = C(P_0, bM);
		}
		if (!flag2)
		{
			flag2 = c(P_0, bM);
		}
		if (!flag2)
		{
			flag2 = D(P_0, bM);
		}
		if (!flag2)
		{
			flag2 = e(P_0, bM);
		}
		if (!flag2)
		{
			flag2 = d(P_0, bM);
		}
		if (!flag2)
		{
			flag2 = E(P_0, bM);
		}
		if (!flag2)
		{
			A(P_0, bM);
		}
		bM.qN = text2;
		bM.qn = flag4;
		bM.qO = text3;
		bM.qo = flag5;
		if (BM.qW)
		{
			if (!string.IsNullOrEmpty(text2))
			{
				new Cp(text2, flag4).A();
			}
			if (!string.IsNullOrEmpty(text3))
			{
				new CQ(text3, flag5).A();
			}
		}
		try
		{
			if (BM.qW)
			{
				Application.Run();
			}
			else
			{
				Application.Run((Form)(object)bM);
			}
		}
		finally
		{
			if (!flag)
			{
				N.a();
			}
			AppDomain currentDomain = AppDomain.CurrentDomain;
			object obj = L.A.BgL;
			if (obj == null)
			{
				UnhandledExceptionEventHandler val = A;
				L.A.BgL = val;
				obj = (object)val;
			}
			currentDomain.UnhandledException -= (UnhandledExceptionEventHandler)obj;
			object obj2 = L.A.Bgl;
			if (obj2 == null)
			{
				ThreadExceptionEventHandler val2 = A;
				L.A.Bgl = val2;
				obj2 = (object)val2;
			}
			Application.ThreadException -= (ThreadExceptionEventHandler)obj2;
		}
	}

	private static void A(string[] P_0, BM P_1)
	{
		foreach (string text in P_0)
		{
			if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu()))
			{
				P_1.qv = text;
				break;
			}
		}
	}

	private static bool a(string[] P_0, BM P_1)
	{
		foreach (string text in P_0)
		{
			if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BV()))
			{
				P_1.qP = text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BV().Length);
				break;
			}
		}
		if (P_1.qP != null)
		{
			foreach (string text2 in P_0)
			{
				if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bv()))
				{
					P_1.qp = bool.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bv().Length));
				}
				else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BW()))
				{
					P_1.qQ = bool.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BW().Length));
				}
				else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bw()))
				{
					P_1.qq = bool.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bw().Length));
				}
				else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BX()))
				{
					string[] array = text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BX().Length).Split(',', (StringSplitOptions)0);
					foreach (string text3 in array)
					{
						P_1.qR.Add(text3);
					}
				}
			}
			return true;
		}
		return false;
	}

	private static bool B(string[] P_0, BM P_1)
	{
		bool flag = false;
		for (int num = 0; num < P_0.Length; num++)
		{
			if (P_0[num] == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bx())
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			try
			{
				foreach (string text in P_0)
				{
					if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BY()))
					{
						P_1.qJ = text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BY().Length);
						if (!string.IsNullOrEmpty(P_1.qJ))
						{
							flag2 = true;
						}
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.By()))
					{
						P_1.qj = text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.By().Length);
						if (!string.IsNullOrEmpty(P_1.qj))
						{
							flag3 = true;
						}
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BZ()))
					{
						P_1.qK = text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BZ().Length);
						if (!string.IsNullOrEmpty(P_1.qK))
						{
							flag4 = true;
						}
					}
				}
				if (flag2 && flag3 && flag4)
				{
					P_1.qi = true;
				}
			}
			catch
			{
			}
			return true;
		}
		return false;
	}

	private static void a(string[] P_0)
	{
		foreach (string text in P_0)
		{
			if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bz()))
			{
				global::A.A.A(byte.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bz().Length)));
			}
			else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bA()))
			{
				global::A.A.a(byte.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bA().Length)));
			}
		}
	}

	private static bool A(string[] P_0, ref bool P_1, ref string P_2, ref bool P_3)
	{
		return false;
	}

	private static bool a(string[] P_0, ref bool P_1, ref string P_2, ref bool P_3)
	{
		return false;
	}

	private static bool b(string[] P_0, BM P_1)
	{
		string text = null;
		foreach (string text2 in P_0)
		{
			if (text2.ToLower().StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ba()))
			{
				if (text2.Length > D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ba().Length)
				{
					text = text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ba().Length);
				}
				break;
			}
		}
		if (text != null)
		{
			foreach (string text3 in P_0)
			{
				if (text3.ToLower().StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bB()))
				{
					string[] array = text3.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bB().Length).Split('.', (StringSplitOptions)0);
					P_1.ql = new k(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]), int.Parse(array[3]), 0);
					P_1.qk = text;
				}
				else if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bb())
				{
					P_1.qL = true;
				}
				else if (text3.ToLower().StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bC()))
				{
					string[] array2 = text3.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bC().Length).Split(',', (StringSplitOptions)0);
					int num3 = int.Parse(array2[0].Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bc().Length));
					int num4 = int.Parse(array2[1].Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bD().Length));
					if (P_1.qM == null)
					{
						P_1.qM = new Dictionary<int, int>();
					}
					P_1.qM.Add(num3, num4);
				}
				else
				{
					if (!text3.ToLower().StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bd()))
					{
						continue;
					}
					string[] array3 = text3.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bd().Length).Split(',', (StringSplitOptions)0);
					int num5 = int.Parse(array3[0].Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bc().Length));
					List<int> val = new List<int>();
					for (int num6 = 1; num6 < array3.Length; num6++)
					{
						if (num6 == 1)
						{
							val.Add(int.Parse(array3[num6].Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bE().Length)));
						}
						else
						{
							val.Add(int.Parse(array3[num6]));
						}
					}
					if (P_1.qm == null)
					{
						P_1.qm = new Dictionary<int, List<int>>();
					}
					P_1.qm.Add(num5, val);
				}
			}
			return true;
		}
		return false;
	}

	private static bool C(string[] P_0, BM P_1)
	{
		foreach (string text in P_0)
		{
			if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.be()))
			{
				P_1.qS = text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.be().Length);
				return true;
			}
		}
		return false;
	}

	private static bool c(string[] P_0, BM P_1)
	{
		for (int num = 0; num < P_0.Length; num++)
		{
			if (P_0[num] == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bF())
			{
				P_1.qr = true;
				return true;
			}
		}
		return false;
	}

	private static bool D(string[] P_0, BM P_1)
	{
		foreach (string text in P_0)
		{
			if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bf()))
			{
				P_1.qt = text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bf().Length);
				return true;
			}
		}
		return false;
	}

	private static bool d(string[] P_0, BM P_1)
	{
		foreach (string text in P_0)
		{
			if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bG()))
			{
				P_1.qU = text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bG().Length);
				return true;
			}
		}
		return false;
	}

	private static bool E(string[] P_0, BM P_1)
	{
		for (int num = 0; num < P_0.Length; num++)
		{
			if (P_0[num] == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bg())
			{
				P_1.qu = true;
				return true;
			}
		}
		return false;
	}

	private static bool e(string[] P_0, BM P_1)
	{
		foreach (string text in P_0)
		{
			if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bH()))
			{
				P_1.qV = text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bH().Length);
				return true;
			}
		}
		return false;
	}

	private static void B(string[] P_0)
	{
		for (int num = 0; num < P_0.Length; num++)
		{
			if (P_0[num].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bh()))
			{
				ch.BIg = true;
				break;
			}
		}
	}

	private static void A(System.Exception P_0)
	{
		N.A(P_0.Message, true);
		if (P_0.StackTrace != null)
		{
			N.A(P_0.StackTrace, true);
		}
		if (P_0.InnerException != null)
		{
			N.A(P_0.InnerException.Message, true);
			if (P_0.InnerException.StackTrace != null)
			{
				N.A(P_0.InnerException.StackTrace, true);
			}
		}
	}

	private static void A(object P_0, UnhandledExceptionEventArgs P_1)
	{
		if (P_1.ExceptionObject is System.Exception)
		{
			A(P_1.ExceptionObject as System.Exception);
		}
		Application.Exit();
	}

	private static void A(object P_0, ThreadExceptionEventArgs P_1)
	{
		if (P_1.Exception != null)
		{
			A(P_1.Exception);
		}
		Application.Exit();
	}
}
internal static class l
{
	internal static Color A(int P_0, int P_1, int P_2)
	{
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = (double)P_0 / 255.0 * 360.0 % 360.0;
		double num5 = (double)P_1 / 255.0;
		double num6 = (double)P_2 / 255.0;
		if (num5 == 0.0)
		{
			num = num6;
			num2 = num6;
			num3 = num6;
		}
		else
		{
			double num7 = num4 / 60.0;
			int num8 = (int)Math.Floor(num7);
			double num9 = num7 - (double)num8;
			double num10 = num6 * (1.0 - num5);
			double num11 = num6 * (1.0 - num5 * num9);
			double num12 = num6 * (1.0 - num5 * (1.0 - num9));
			switch (num8)
			{
			case 0:
				num = num6;
				num2 = num12;
				num3 = num10;
				break;
			case 1:
				num = num11;
				num2 = num6;
				num3 = num10;
				break;
			case 2:
				num = num10;
				num2 = num6;
				num3 = num12;
				break;
			case 3:
				num = num10;
				num2 = num11;
				num3 = num6;
				break;
			case 4:
				num = num12;
				num2 = num10;
				num3 = num6;
				break;
			case 5:
				num = num6;
				num2 = num10;
				num3 = num11;
				break;
			}
		}
		return Color.FromArgb((int)(num * 255.0), (int)(num2 * 255.0), (int)(num3 * 255.0));
	}
}
