using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.SettingsFramework;

namespace C
{
	internal class CB
	{
		private Ca ayd;

		private List<string> ayE = new List<string>();

		private Framework aye;

		private string ayF;

		private string ayf;

		private CA ayG;

		private int ayg;

		private List<int> ayH = new List<int>();

		private List<int> ayh = new List<int>();

		private List<string> ayI = new List<string>();

		private CC ayi;

		private List<Cb> ayJ = new List<Cb>();

		[CompilerGenerated]
		private EventHandler ayj;

		internal CB(Framework P_0, string P_1, string P_2, CA P_3)
		{
			aye = P_0;
			ayF = P_1;
			ayf = P_2;
			ayG = P_3;
		}

		public virtual string ToString()
		{
			return string.Concat(new string[6]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aog(),
				((object)ayG).ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(),
				(!string.IsNullOrEmpty(ayF)) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoH() + ayF) : string.Empty,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(),
				(!string.IsNullOrEmpty(ayf)) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoh() + ayf) : string.Empty
			});
		}

		internal void A()
		{
			if (ayd != 0 || ayE.Count != 0)
			{
				ayd = Ca.ayB;
				ayE.Clear();
				if (ayj != null)
				{
					ayj.Invoke((object)this, (EventArgs)null);
				}
			}
		}

		[SpecialName]
		internal Ca a()
		{
			return ayd;
		}

		[SpecialName]
		internal List<string> B()
		{
			return ayE;
		}

		[SpecialName]
		[CompilerGenerated]
		internal void A(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = ayj;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref ayj, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		internal void a(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = ayj;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref ayj, val3, val2);
			}
			while (val != val2);
		}

		internal void b()
		{
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			bool flag = false;
			List<string> val = new List<string>();
			bool num = G();
			bool flag2 = false;
			if (num && !BM.aE())
			{
				if (ayd == Ca.ayb)
				{
					flag = true;
					ayd = Ca.ayB;
					flag2 = true;
				}
			}
			else if (ayd != Ca.ayb || ayE.Count != 0)
			{
				flag = true;
				ayd = Ca.ayb;
			}
			bool flag3 = false;
			if (num)
			{
				if (ayG == CA.aYz)
				{
					flag3 = true;
				}
				else if (ayG == CA.ayA)
				{
					if (ayi != null && ayi.C())
					{
						flag3 = true;
					}
					else
					{
						Enumerator<Cb> enumerator = ayJ.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								if (enumerator.Current.C())
								{
									flag3 = true;
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
				else if (ayG == CA.aya && flag2)
				{
					flag3 = true;
				}
			}
			if (flag3)
			{
				Enumerator<Cb> enumerator = ayJ.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Cb current = enumerator.Current;
						if (current.c())
						{
							val.Add(current.a());
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				if (ayi != null)
				{
					if (val.Count != 0)
					{
						if (ayd != Ca.ayD || A(val))
						{
							flag = true;
							ayd = Ca.ayD;
						}
					}
					else if (ayi.c())
					{
						if (ayd != Ca.ayc || A(val))
						{
							flag = true;
							ayd = Ca.ayc;
						}
					}
					else if (ayJ.Count == 0)
					{
						if (ayd != Ca.ayD || A(val))
						{
							flag = true;
							ayd = Ca.ayD;
						}
					}
					else if (ayd != Ca.ayC || A(val))
					{
						flag = true;
						ayd = Ca.ayC;
					}
				}
				else if (val.Count != 0)
				{
					if (ayd != Ca.ayD || A(val))
					{
						flag = true;
						ayd = Ca.ayD;
					}
				}
				else if (ayd != Ca.ayc || A(val))
				{
					flag = true;
					ayd = Ca.ayc;
				}
			}
			if (flag)
			{
				ayE = val;
				if (ayj != null)
				{
					ayj.Invoke((object)this, (EventArgs)null);
				}
			}
		}

		private bool A(List<string> P_0)
		{
			if (P_0.Count != ayE.Count)
			{
				return true;
			}
			for (int i = 0; i < P_0.Count; i++)
			{
				if (P_0[i] != ayE[i])
				{
					return true;
				}
			}
			return false;
		}

		[SpecialName]
		internal string C()
		{
			return ayF;
		}

		[SpecialName]
		internal string c()
		{
			return ayf;
		}

		[SpecialName]
		internal CA D()
		{
			return ayG;
		}

		[SpecialName]
		internal int d()
		{
			return ayg;
		}

		[SpecialName]
		internal void A(int P_0)
		{
			ayg = P_0;
		}

		[SpecialName]
		internal List<int> E()
		{
			return ayH;
		}

		[SpecialName]
		internal List<int> e()
		{
			return ayh;
		}

		[SpecialName]
		internal CC F()
		{
			return ayi;
		}

		[SpecialName]
		internal void A(CC P_0)
		{
			ayi = P_0;
		}

		[SpecialName]
		internal List<Cb> f()
		{
			return ayJ;
		}

		internal void A(string P_0)
		{
			ayI.Add(P_0);
		}

		internal bool G()
		{
			if (ayI.Count != 0)
			{
				for (int i = 0; i < ayI.Count; i++)
				{
					string text = ayI[i];
					T.A(ref text, aye);
					if (T.A(ref text))
					{
						return true;
					}
				}
				return false;
			}
			return true;
		}
	}
	internal class Cb
	{
		private CB ayK;

		private Framework ayk;

		private string ayL;

		private string ayl;

		private string ayM;

		private string aym;

		private bool ayN;

		internal Cb(CB P_0, Framework P_1, string P_2)
		{
			ayK = P_0;
			ayk = P_1;
			ayL = P_2;
		}

		public virtual string ToString()
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoI() + ((!string.IsNullOrEmpty(ayL)) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoh() + ayL) : string.Empty) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + ((!string.IsNullOrEmpty(ayl)) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoi() + ayl) : string.Empty);
		}

		[SpecialName]
		internal CB A()
		{
			return ayK;
		}

		[SpecialName]
		internal string a()
		{
			return ayL;
		}

		[SpecialName]
		internal string B()
		{
			return ayM;
		}

		[SpecialName]
		internal void A(string P_0)
		{
			ayM = P_0;
		}

		[SpecialName]
		internal string b()
		{
			return aym;
		}

		[SpecialName]
		internal void a(string P_0)
		{
			aym = P_0;
		}

		[SpecialName]
		internal bool C()
		{
			return ayN;
		}

		[SpecialName]
		internal void A(bool P_0)
		{
			ayN = P_0;
		}

		[SpecialName]
		internal void B(string P_0)
		{
			ayl = P_0;
		}

		internal bool c()
		{
			if (string.IsNullOrEmpty(ayl))
			{
				return false;
			}
			string text = ayl;
			T.A(ref text, ayk);
			return T.A(ref text);
		}
	}
}
namespace c
{
	internal class cB
	{
		[CompilerGenerated]
		private sealed class A
		{
			public string Btm;

			internal void A(object P_0, DataReceivedEventArgs P_1)
			{
				Btm += P_1.Data;
			}
		}

		private static string Bdq = BM.Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + BM.Qy;

		private static string BdR = Bdq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azF();

		private static string Bdr = Bdq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azf();

		private static char[] BdS;

		internal static char[] Bds;

		private static Encoding BdT;

		private static ProcessStartInfo A(string P_0, string P_1)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			ProcessStartInfo val = new ProcessStartInfo();
			if (P_0 != null)
			{
				val.FileName = P_0;
			}
			if (P_1 != null)
			{
				val.Arguments = P_1;
			}
			val.UseShellExecute = false;
			val.WindowStyle = (ProcessWindowStyle)1;
			val.CreateNoWindow = true;
			val.RedirectStandardOutput = true;
			val.RedirectStandardError = true;
			return val;
		}

		internal static bool A(string P_0)
		{
			bool flag = false;
			for (int i = 0; i < Bds.Length; i++)
			{
				if (P_0.Contains(Bds[i]))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				return true;
			}
			return false;
		}

		internal static bool a(string P_0, string P_1)
		{
			if (P_0.Length < 1 || P_1.Length < 8 || A(P_0))
			{
				return false;
			}
			string text = BitConverter.ToString(BdT.GetBytes(P_0));
			text = text.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			string text2 = string.Concat(new string[9]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZZ(),
				P_0,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZz(),
				text,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azA(),
				P_0,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aza(),
				P_1,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azB()
			});
			try
			{
				File.WriteAllText(BdR, text2, BdT);
				bool result = B(BdR, P_0);
				File.Delete(BdR);
				return result;
			}
			catch (System.Exception ex)
			{
				N.A(((object)ex).ToString(), true);
				return false;
			}
		}

		private static bool B(string P_0, string P_1)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			bool result = false;
			if (P_0 == null || P_1 == null || P_0.Length < 1 || P_1.Length < 1)
			{
				return false;
			}
			Process val = new Process();
			val.StartInfo = A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.az(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azb() + P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl());
			string Btm = null;
			string text = null;
			val.ErrorDataReceived += (DataReceivedEventHandler)delegate(object P_0, DataReceivedEventArgs P_1)
			{
				Btm += P_1.Data;
			};
			try
			{
				val.Start();
				val.BeginErrorReadLine();
				text = ((TextReader)val.StandardOutput).ReadToEnd();
				val.WaitForExit();
				_ = val.ExitCode;
				string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azC();
				for (int i = 0; i < BdS.Length; i++)
				{
					System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(text2);
					System.ReadOnlySpan<char> readOnlySpan2 = string.op_Implicit(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj());
					char c = BdS[i];
					text2 = string.Concat(readOnlySpan, readOnlySpan2, new System.ReadOnlySpan<char>(ref c));
				}
				text2 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azc();
				string[] array = Regex.Split(P_1, text2);
				string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j].Length <= 0)
					{
						continue;
					}
					bool flag = false;
					int num = 0;
					for (num = 0; num < BdS.Length; num++)
					{
						if (array[j][0] == BdS[num])
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						array[j] = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + array[j];
					}
					text3 += array[j];
				}
				text3 = text3.Trim(' ');
				if (new Regex(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azD() + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azd(), (RegexOptions)11).Matches(text).Count > 0)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azE(), true);
					result = true;
				}
				else
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aze(), true);
				}
				return result;
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Be() + ex.Message, true);
				return false;
			}
		}

		static cB()
		{
			char[] array = new char[10];
			RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			BdS = array;
			char[] array2 = new char[5];
			RuntimeHelpers.InitializeArray((System.Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			Bds = array2;
			BdT = Encoding.GetEncoding(20127);
		}
	}
	internal class cb
	{
		[CompilerGenerated]
		private static class A
		{
			public static EventHandler BtN;
		}

		internal const int Bdt = 3;

		internal const int BdU = 12;

		internal const int Bdu = 4;

		private static cC BdV;

		private static string Bdv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azg();

		internal static int BdW = 32768;

		internal static int Bdw = 0;

		internal static int BdX = 0;

		internal static int Bdx = 0;

		internal static int BdY = 0;

		internal static V Bdy = null;

		private static Framework BdZ = null;

		internal static byte[] Bdz;

		internal static void A(Framework P_0, V P_1)
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Expected O, but got Unknown
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected O, but got Unknown
			if (BdZ != null)
			{
				Framework bdZ = BdZ;
				object obj = cb.A.BtN;
				if (obj == null)
				{
					EventHandler val = A;
					cb.A.BtN = val;
					obj = (object)val;
				}
				bdZ.a((EventHandler)obj);
			}
			BdZ = P_0;
			F f = global::A.A.e(BdZ.aXc);
			if (f == null)
			{
				f = A(BdZ);
			}
			Bdw = (int)f.@as[35].Be;
			BdX = (int)f.@as[35].BF;
			Bdx = (int)f.@as[33].Be;
			BdY = (int)f.@as[33].BF;
			BdW = BdY + 12 + 4;
			Bdz = new byte[BdW];
			Bdy = P_1;
			if (BdV == null)
			{
				BdV = new cC(Bdv);
			}
			if (BdZ != null)
			{
				Framework bdZ2 = BdZ;
				object obj2 = cb.A.BtN;
				if (obj2 == null)
				{
					EventHandler val2 = A;
					cb.A.BtN = val2;
					obj2 = (object)val2;
				}
				bdZ2.a((EventHandler)obj2);
				Framework bdZ3 = BdZ;
				object obj3 = cb.A.BtN;
				if (obj3 == null)
				{
					EventHandler val3 = A;
					cb.A.BtN = val3;
					obj3 = (object)val3;
				}
				bdZ3.A((EventHandler)obj3);
			}
		}

		private static F A(Framework P_0)
		{
			byte[] array = new byte[1024];
			array[0] = (byte)P_0.aXA.A();
			array[1] = (byte)P_0.aXA.a();
			array[2] = (byte)P_0.aXA.B();
			array[3] = (byte)P_0.aXA.b();
			array[4] = (byte)((uint)(P_0.aXA.C() >> 24) & 0xFFu);
			array[5] = (byte)((uint)(P_0.aXA.C() >> 16) & 0xFFu);
			array[6] = (byte)((uint)(P_0.aXA.C() >> 8) & 0xFFu);
			array[7] = (byte)((uint)P_0.aXA.C() & 0xFFu);
			array[8] = 21;
			for (int i = 9; i < 1024; i++)
			{
				array[i] = 255;
			}
			F f = new F();
			f.A(array);
			f.a(null);
			return f;
		}

		private static void A(object P_0, EventArgs P_1)
		{
			if (BdZ != null && A())
			{
				if (P_0 is Setting)
				{
					A(P_0 as Setting);
				}
				else
				{
					a();
				}
			}
		}

		internal static bool A()
		{
			if (BdV != null)
			{
				return BdV.A();
			}
			return false;
		}

		internal static void A(Setting P_0)
		{
			if (BdZ == null || BdX == 0)
			{
				return;
			}
			if (BdV != null && !BdV.A())
			{
				BdV.a();
			}
			if (!A())
			{
				return;
			}
			byte[] array = P_0.aY();
			int num = 0;
			bool flag;
			do
			{
				flag = A(array, P_0.a());
				if (!flag)
				{
					num++;
					Thread.Sleep(20);
				}
			}
			while (!flag && num < 3);
		}

		internal static void a()
		{
			if (BdZ == null || BdX == 0)
			{
				return;
			}
			if (BdV != null && !BdV.A())
			{
				BdV.a();
			}
			if (!A() || BdZ == null)
			{
				return;
			}
			int num = 0;
			bool flag;
			do
			{
				flag = A(BdZ.I());
				if (!flag)
				{
					num++;
					Thread.Sleep(20);
				}
			}
			while (!flag && num < 3 && BdZ != null);
		}

		internal static void A(bool P_0 = false)
		{
			if (BdZ == null || BdX == 0 || (Bdy != null && Bdy.ES != null && Bdy.ES.BiE && !P_0))
			{
				return;
			}
			if (BdV != null && !BdV.A())
			{
				BdV.a();
			}
			if (!A() || BdZ == null)
			{
				return;
			}
			int num = 0;
			bool flag;
			do
			{
				flag = a(BdZ.J());
				if (!flag)
				{
					num++;
					Thread.Sleep(20);
				}
			}
			while (!flag && num < 3 && BdZ != null);
		}

		internal static bool A(byte[] P_0, int P_1)
		{
			if (BdX == 0)
			{
				return false;
			}
			if (BdV != null && !BdV.A())
			{
				BdV.a();
			}
			if (BdV != null && BdV.A())
			{
				return BdV.A(P_0, 0, P_0.Length, Bdw + P_1, true);
			}
			return false;
		}

		internal static bool A(byte[] P_0)
		{
			if (BdX == 0)
			{
				return false;
			}
			if (BdV != null && !BdV.A())
			{
				BdV.a();
			}
			if (BdV != null && BdV.A())
			{
				bool flag = true;
				int num = 0;
				do
				{
					int num2 = Math.Min(BdW - 16, BdX - num);
					flag &= BdV.A(P_0, num, num2, Bdw, true);
					num += num2;
				}
				while (num < BdX);
				return flag;
			}
			return false;
		}

		internal static bool a(byte[] P_0)
		{
			if (BdZ == null || BdY == 0)
			{
				return false;
			}
			if (BdV != null && !BdV.A())
			{
				BdV.a();
			}
			try
			{
				if (Bdy != null && Bdy.ES != null && Bdy.ES.BiE)
				{
					System.Array.Clear((System.Array)Bdz, 0, Bdz.Length);
					Bdy.A(ref Bdz);
				}
				if (BdV != null && BdV.A())
				{
					bool flag = false;
					return (Bdy == null || Bdy.ES == null || !Bdy.ES.BiE) ? BdV.A(P_0, 0, BdY, Bdx) : BdV.A(Bdz, 0, BdY, Bdx);
				}
				return false;
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azG() + ex.Message, true);
				return false;
			}
		}

		internal static void B()
		{
			if (BdV != null)
			{
				BdV.d();
			}
		}

		internal static void a(bool P_0 = true)
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			if (BdZ != null)
			{
				Framework bdZ = BdZ;
				object obj = cb.A.BtN;
				if (obj == null)
				{
					EventHandler val = A;
					cb.A.BtN = val;
					obj = (object)val;
				}
				bdZ.a((EventHandler)obj);
				BdZ = null;
			}
			Bdy = null;
			if (BdV != null)
			{
				if (BdV.A() && P_0)
				{
					BdV.D();
				}
				BdV.b();
			}
		}

		internal static bool b()
		{
			if (BdV != null)
			{
				return BdV.c();
			}
			return false;
		}
	}
}
