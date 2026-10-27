using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using NSP.SettingsFramework;
using b;

namespace C
{
	internal enum CA
	{
		aYz,
		ayA,
		aya
	}
	internal enum Ca
	{
		ayB,
		ayb,
		ayC,
		ayc,
		ayD
	}
}
namespace c
{
	internal static class cA
	{
		internal static bool A(CZ.A P_0, F P_1, BackgroundWorker P_2, DoWorkEventArgs P_3, CZ.B P_4, out bool P_5)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			P_5 = false;
			bool flag = false;
			int num = 65535;
			Enumerator<Cy> enumerator = P_0.BTV.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Cy current = enumerator.Current;
					if (!string.IsNullOrEmpty(current.BdJ))
					{
						int num2 = P_0.BTV.IndexOf(current);
						int num3 = 0;
						for (int i = 0; i < num2; i++)
						{
							if (!P_0.BTV[i].Bdj)
							{
								num3++;
							}
						}
						int num4 = num2 - num3;
						if (current.BdJ == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZF())
						{
							if (current.Bdj)
							{
								P_2.ReportProgress(0, (object)num4);
							}
							flag = false;
							num = 65535;
							if (num2 + 1 >= P_0.BTV.Count)
							{
								P_4.Btd = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayc();
								P_3.Result = P_4;
								global::A.A.I(P_1.ao);
								return false;
							}
							if (!A(P_0.BTV[num2 + 1], P_0, P_2, num4, ref flag, ref num))
							{
								P_4.Btd = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayc();
								P_3.Result = P_4;
								global::A.A.I(P_1.ao);
								return false;
							}
							if (current.Bdj)
							{
								P_2.ReportProgress(100, (object)num4);
							}
						}
						else if (current.BdJ == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZG())
						{
							if (current.Bdj)
							{
								P_2.ReportProgress(0, (object)num4);
							}
							if (!CZ.A(P_1, true))
							{
								CZ.a(P_1);
							}
							if (current.Bdj)
							{
								P_2.ReportProgress(100, (object)num4);
							}
						}
						else if (current.BdJ == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZg())
						{
							if (current.Bdj)
							{
								P_2.ReportProgress(0, (object)num4);
							}
							if (CZ.A(P_1, true))
							{
								CZ.A(P_1);
							}
							if (current.Bdj)
							{
								P_2.ReportProgress(100, (object)num4);
							}
						}
						continue;
					}
					if (current.Bdg != null)
					{
						bool flag2 = current.BdK != bt.avK;
						if (flag2)
						{
							continue;
						}
						int num7;
						if (current.BdG.BDU >= 2)
						{
							int num5 = P_0.BTV.IndexOf(current);
							int num6 = 0;
							for (int j = 0; j < num5; j++)
							{
								if (!P_0.BTV[j].Bdj)
								{
									num6++;
								}
							}
							num7 = num5 - num6;
							if (A(current, P_0, P_2, num7, flag, num))
							{
								continue;
							}
							P_4.Btd = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayc();
							P_3.Result = P_4;
							global::A.A.I(P_1.ao);
							return false;
						}
						if (flag2)
						{
							P_4.Btd = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZk();
							P_3.Result = P_4;
							global::A.A.I(P_1.ao);
							return false;
						}
						num7 = P_0.BTV.IndexOf(current) * 2;
						flag = false;
						num = 65535;
						if (!A(current, P_0, P_2, num7, ref flag, ref num))
						{
							P_4.Btd = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayc();
							P_3.Result = P_4;
							global::A.A.I(P_1.ao);
							return false;
						}
						num7++;
						if (A(current, P_0, P_2, num7, flag, num))
						{
							continue;
						}
						P_4.Btd = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ayc();
						P_3.Result = P_4;
						global::A.A.I(P_1.ao);
						return false;
					}
					P_4.Btd = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZN();
					P_3.Result = P_4;
					global::A.A.I(P_1.ao);
					return false;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			P_5 = true;
			return true;
		}

		private static bool A(Cy P_0, CZ.A P_1, BackgroundWorker P_2, int P_3, ref bool P_4, ref int P_5)
		{
			P_2.ReportProgress(0, (object)P_3);
			F bTm = P_1.BTm;
			if (!CZ.A(bTm, true) && !CZ.a(bTm))
			{
				return false;
			}
			uint bDx = P_0.BdG.BDx;
			global::A.A.a(bTm.ao, bDx);
			if (A(P_0, bTm, out var num))
			{
				P_5 = num;
				P_4 = P_5 != 65535;
				if (!A(P_0, bTm, 0))
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZO(), true);
					return false;
				}
				if (!A(bTm, P_2, P_3))
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZo(), true);
					return false;
				}
				return true;
			}
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZn(), true);
			return false;
		}

		private static bool A(Cy P_0, CZ.A P_1, BackgroundWorker P_2, int P_3, bool P_4, int P_5)
		{
			P_2.ReportProgress(0, (object)P_3);
			F bTm = P_1.BTm;
			if (!A(P_0, bTm, P_2, P_3, P_4, P_5))
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZP(), true);
				return false;
			}
			if (!A(P_0, bTm, 1))
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZp(), true);
				return false;
			}
			bool flag;
			if (P_0.BdG.BDU >= 2)
			{
				int num = P_1.BTV.IndexOf(P_0);
				int count = P_1.BTV.Count;
				flag = num == count - P_1.BTv - 1;
			}
			else
			{
				flag = P_0.BdG.BDu == CV.BDo || P_0.BdG.BDu == CV.BDQ;
			}
			if (!flag && P_0.BdK == bt.avK && !A(bTm))
			{
				return false;
			}
			P_2.ReportProgress(100, (object)P_3);
			return true;
		}

		private static bool A(Cy P_0, F P_1, out int P_2)
		{
			P_2 = 65535;
			byte b;
			if (P_0.BdG.BDU >= 2)
			{
				b = P_0.BdG.BDV;
			}
			else if (P_0.BdG.BDu == CV.BDP || P_0.BdG.BDu == CV.BDq)
			{
				b = 130;
			}
			else
			{
				if (P_0.BdG.BDu != CV.BDo && P_0.BdG.BDu != CV.BDQ)
				{
					return false;
				}
				b = 255;
			}
			uint bDW = P_0.BdG.BDW;
			uint num = (uint)P_0.Bdg.Length;
			if (!global::A.A.A(P_1.ao, b, bDW, num, bDW, (byte)P_0.BdG.BDv.A(), (byte)P_0.BdG.BDv.a(), (byte)P_0.BdG.BDv.B(), (byte)P_0.BdG.BDv.b(), out P_2))
			{
				return false;
			}
			return true;
		}

		private static bool A(Cy P_0, F P_1, byte P_2)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			byte b = 0;
			bool flag = false;
			Stopwatch val = new Stopwatch();
			val.Start();
			do
			{
				flag = global::A.A.A(P_1.ao, P_2, b, (byte)P_0.BdG.BDv.A(), (byte)P_0.BdG.BDv.a(), (byte)P_0.BdG.BDv.B(), (byte)P_0.BdG.BDv.b());
				if (!flag)
				{
					Thread.Sleep(0);
				}
			}
			while (!flag && val.ElapsedMilliseconds < 6000);
			val.Stop();
			if (!flag)
			{
				return false;
			}
			return true;
		}

		private static bool A(F P_0, BackgroundWorker P_1, int P_2)
		{
			int num = 10;
			bool flag = false;
			do
			{
				global::A.A.H(P_0.ao);
				P_1.ReportProgress(50, (object)P_2);
				Thread.Sleep(200);
				if (global::A.A.h(P_0.ao))
				{
					flag = true;
				}
				num--;
			}
			while (num > 0 && !flag);
			if (!flag)
			{
				return false;
			}
			P_1.ReportProgress(100, (object)P_2);
			return true;
		}

		private static bool A(Cy P_0, F P_1, BackgroundWorker P_2, int P_3, bool P_4, int P_5)
		{
			uint num = (uint)P_0.Bdg.Length;
			uint num2 = 0u;
			int num3 = 0;
			uint num4;
			if (P_0.BdG.BDU >= 2)
			{
				num4 = P_0.Bdh;
			}
			else if (P_0.BdG.BDu == CV.BDP || P_0.BdG.BDu == CV.BDq)
			{
				num4 = 94u;
			}
			else
			{
				if (P_0.BdG.BDu != CV.BDo && P_0.BdG.BDu != CV.BDQ)
				{
					return false;
				}
				num4 = 80u;
			}
			do
			{
				List<uint> val = new List<uint>();
				List<byte[]> val2 = new List<byte[]>();
				List<uint> val3 = new List<uint>();
				int num5 = 28;
				for (int i = 0; i < num5; i++)
				{
					if (num2 >= num)
					{
						break;
					}
					uint num7;
					if (P_4)
					{
						uint num6 = (num2 / (uint)P_5 + 1) * (uint)P_5;
						num7 = ((num2 + num4 <= num6) ? Math.Min(num - num2, num4) : Math.Min(num - num2, num6 - num2));
					}
					else
					{
						num7 = Math.Min(num - num2, num4);
					}
					byte[] array = new byte[num7];
					System.Array.Copy((System.Array)P_0.Bdg, (long)num2, (System.Array)array, 0L, (long)num7);
					val.Add(num2);
					val2.Add(array);
					val3.Add(num7);
					num2 += num7;
				}
				if (global::A.A.A(P_1.ao, val, val2, val3))
				{
					int num8 = (int)(100 * num2 / num);
					if (num8 != num3)
					{
						P_2.ReportProgress(num8, (object)P_3);
						num3 = num8;
					}
					continue;
				}
				return false;
			}
			while (num2 < num);
			return true;
		}

		private static bool A(F P_0)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZQ() + P_0.ao + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(), true);
			global::A.A.f(P_0.ao);
			Thread.Sleep(700);
			F f = global::A.A.F(P_0.ao);
			if (f != null)
			{
				if (CZ.A(f, true))
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZq() + P_0.ao + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(), true);
					return true;
				}
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZR() + P_0.ao + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZr(), true);
				BM.b(false);
				return false;
			}
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZR() + P_0.ao + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZS(), true);
			BM.b(false);
			return false;
		}
	}
	internal static class ca
	{
		private static readonly k BdP = new k(1, 22, 0, 103, 0);

		private static readonly k Bdp = new k(3, 9, 0, 0, 0);

		private static readonly k BdQ = new k(3, 10, 0, 0, 0);

		internal static bool A(IWin32Window P_0, F P_1, k P_2, k P_3, out bool P_4)
		{
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Invalid comparison between Unknown and I4
			P_4 = false;
			bool flag = false;
			if (BM.Qz != null && BM.Qz.c() && BM.Qz.E())
			{
				if (!CZ.A(P_1, true) && P_1.aH == 20 && P_1.ah == 3 && P_2 != null && P_3 != null && P_2 < BdP && P_3 >= BdP && A(BM.Qz, true, null))
				{
					flag = true;
				}
				if (flag && (int)bE.A(P_0, A(true, false, false), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZs(), (MessageBoxButtons)1, (MessageBoxIcon)48) == 2)
				{
					P_4 = true;
				}
			}
			return flag;
		}

		internal static bool A(IWin32Window P_0, bool P_1, bool P_2, Framework P_3, Framework P_4, out bool P_5)
		{
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Invalid comparison between Unknown and I4
			P_5 = false;
			bool flag = false;
			if (P_3.awZ == 20 && P_3.awz == 3 && P_4.awZ == 20)
			{
				k aXA = P_3.aXA;
				k aXA2 = P_4.aXA;
				if (aXA < BdP && aXA2 >= BdP && A(BM.Qz, true, null))
				{
					flag = true;
				}
			}
			if (flag && (int)bE.A(P_0, ((P_1 || P_2) ? string.Empty : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZT()) + A(false, true, false), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZt(), (MessageBoxButtons)1, (MessageBoxIcon)48) == 2)
			{
				P_5 = true;
			}
			return flag;
		}

		internal static string A(bool P_0, bool P_1, bool P_2)
		{
			string text = string.Empty;
			if (P_0)
			{
				text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZU();
			}
			else if (P_1)
			{
				text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZu();
			}
			else if (P_2)
			{
				text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZV();
			}
			text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZv();
			if (P_0)
			{
				text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZW();
			}
			else if (P_1)
			{
				text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZw();
			}
			else if (P_2)
			{
				text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZX();
			}
			text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZx();
			if (!P_2)
			{
				text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZY();
			}
			return text;
		}

		internal static bool A(bt P_0, k P_1, k P_2, Dictionary<bt, k> P_3, Dictionary<bt, k> P_4)
		{
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			bool result = false;
			if (P_0 == bt.avn || P_0 == bt.avp || P_0 == bt.avQ || P_0 == bt.avq || P_0 == bt.avO)
			{
				if (P_1 != null && P_2 != null && P_1 < Bdp && P_2 >= BdQ)
				{
					List<bt> val = new List<bt>();
					val.Add(P_0);
					if (A(BM.Qz, false, val))
					{
						result = true;
					}
				}
			}
			else if (P_3 != null && P_4 != null)
			{
				List<bt> val2 = new List<bt>();
				Enumerator<bt, k> enumerator = P_3.Keys.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						bt current = enumerator.Current;
						if ((current == bt.avn || current == bt.avp || current == bt.avQ || current == bt.avq || current == bt.avO) && P_4.ContainsKey(current))
						{
							k k = P_3[current];
							k k2 = P_4[current];
							if (k != null && k2 != null && k < Bdp && k2 >= BdQ)
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
				if (val2.Count != 0 && A(BM.Qz, false, val2))
				{
					result = true;
				}
			}
			return result;
		}

		private static bool A(Framework P_0, bool P_1, List<bt> P_2)
		{
			if (P_0 == null)
			{
				return false;
			}
			Setting setting = P_0.A(14163);
			if (setting == null || setting.ax() != 0)
			{
				int[] array = new int[12];
				RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				int[] array2 = array;
				int[] array3 = new int[12];
				RuntimeHelpers.InitializeArray((System.Array)array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				int[] array4 = array3;
				int[] array5 = new int[12];
				RuntimeHelpers.InitializeArray((System.Array)array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				int[] array6 = array5;
				for (int i = 0; i < 12; i++)
				{
					Setting setting2 = P_0.A(array2[i]);
					Setting setting3 = P_0.A(array4[i]);
					Setting setting4 = P_0.A(array6[i]);
					if (setting2 == null || setting3 == null || setting4 == null || setting2.ax() == 0 || setting3.ax() != 1292)
					{
						continue;
					}
					int num = setting4.ax();
					Cg cg2 = PortFunction.A((uint)num);
					CH cH2 = PortFunction.a((uint)num);
					byte b = PortFunction.B((uint)num);
					if (P_1 && cg2 == Cg.BAb && cH2 == CH.Baj)
					{
						Setting setting5 = null;
						switch (b)
						{
						case 0:
							setting5 = P_0.A(9877);
							break;
						case 1:
							setting5 = P_0.A(9893);
							break;
						}
						if (setting5 != null)
						{
							string text = setting5.Bc();
							if (!string.IsNullOrEmpty(text) && text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZy()))
							{
								return true;
							}
						}
					}
					if (P_2 == null)
					{
						continue;
					}
					Setting setting6 = null;
					Setting setting7 = null;
					if (cg2 == Cg.BAf && P_2.Contains(bt.avO))
					{
						setting6 = P_0.A(12129);
					}
					else if (cg2 == Cg.BAF && P_2.Contains(bt.avn))
					{
						setting6 = P_0.A(12121);
						setting7 = P_0.A(12122);
					}
					else if (cg2 == Cg.BAh && P_2.Contains(bt.avp))
					{
						setting6 = P_0.A(12123);
						setting7 = P_0.A(12124);
					}
					else if (cg2 == Cg.BAI && P_2.Contains(bt.avQ))
					{
						setting6 = P_0.A(12125);
						setting7 = P_0.A(12126);
					}
					else if (cg2 == Cg.BAi && P_2.Contains(bt.avq))
					{
						setting6 = P_0.A(12127);
						setting7 = P_0.A(12128);
					}
					if (setting6 != null)
					{
						string text2 = setting6.Bc();
						if (!string.IsNullOrEmpty(text2) && text2.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZy()))
						{
							return true;
						}
					}
					if (setting7 != null)
					{
						string text3 = setting7.Bc();
						if (!string.IsNullOrEmpty(text3) && text3.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZy()))
						{
							return true;
						}
					}
				}
			}
			return false;
		}
	}
}
