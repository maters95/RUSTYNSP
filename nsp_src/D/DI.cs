using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using NSP.SettingsFramework;
using c;

namespace D;

internal class DI : SpecialObject
{
	private List<int> BYG = new List<int>();

	internal DI(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
	}

	[SpecialName]
	internal new List<int> A()
	{
		return BYG;
	}

	[SpecialName]
	internal void A(List<int> P_0)
	{
		BYG = P_0;
	}
}
internal class Di : SpecialObject
{
	internal const string BYZ = "user_resources";

	internal const string BYz = "images";

	internal const string ByA = "fonts";

	internal const string Bya = "u/";

	internal const string ByB = "h/";

	private Setting Byb;

	private Setting ByC;

	private Setting Byc;

	private Setting ByD;

	private Setting Byd;

	private Setting ByE;

	private Setting Bye;

	private List<DK> ByF = new List<DK>();

	private const uint Byf = 1u;

	[CompilerGenerated]
	private EventHandler ByG;

	private List<List<int>> Byg = new List<List<int>>();

	private List<List<int>> ByH = new List<List<int>>();

	internal Di(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
	}

	internal new void A()
	{
		for (int i = 0; i < ((SettingOrSpecialObject)this).a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)this).a()[i];
			if (settingOrSpecialObject is DK)
			{
				DK dK = settingOrSpecialObject as DK;
				ByF.Add(dK);
				dK.A();
			}
			else if (settingOrSpecialObject is Setting)
			{
				if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhi())
				{
					Byb = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhJ())
				{
					ByC = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhj())
				{
					Byc = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhK())
				{
					ByD = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhk())
				{
					ByE = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhL())
				{
					Byd = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhl())
				{
					Bye = settingOrSpecialObject as Setting;
				}
			}
		}
	}

	[SpecialName]
	internal new Setting a()
	{
		return Byb;
	}

	[SpecialName]
	internal new Setting B()
	{
		return ByC;
	}

	[SpecialName]
	internal new Setting b()
	{
		return Byc;
	}

	[SpecialName]
	internal new Setting C()
	{
		return ByD;
	}

	[SpecialName]
	internal new Setting c()
	{
		return Byd;
	}

	[SpecialName]
	internal new Setting D()
	{
		return Bye;
	}

	[SpecialName]
	internal new Setting d()
	{
		return ByE;
	}

	[SpecialName]
	internal new List<DK> E()
	{
		return ByF;
	}

	[SpecialName]
	[CompilerGenerated]
	internal new void A(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = ByG;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref ByG, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal new void a(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = ByG;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref ByG, val3, val2);
		}
		while (val != val2);
	}

	internal new bool A(int P_0)
	{
		return A(P_0, false);
	}

	private bool A(int P_0, bool P_1)
	{
		int num = Byb.ax();
		if (num == ByF.Count)
		{
			return false;
		}
		Ck ck = BM.aM();
		if (!P_1)
		{
			ck?.a();
			m_framework.M();
		}
		if (P_0 >= num)
		{
			ByF[P_0].A(true);
			ByF[P_0].b();
			ByF[P_0].h()?.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aof() + (P_0 + 1), true);
		}
		else
		{
			for (int num2 = num - 1; num2 >= P_0; num2--)
			{
				ByF[num2 + 1].a(ByF[num2], true);
			}
			ByF[P_0].A(true);
			ByF[P_0].b();
			ByF[P_0].h()?.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aof() + (P_0 + 1), true);
			if (ByC != null)
			{
				int num3 = ByC.ax();
				if (num3 >= P_0)
				{
					ByC.a(num3 + 1, true);
				}
			}
		}
		Byb.a(num + 1, true);
		if (!P_1)
		{
			m_framework.A(true);
			ck?.B();
			G();
			if (ByG != null)
			{
				ByG.Invoke((object)null, (EventArgs)null);
			}
			BM.Z();
		}
		return true;
	}

	internal new void e()
	{
		BM.QQ.rl.h();
	}

	internal new void F()
	{
		BM.QQ.rl.I();
	}

	internal new bool a(int P_0)
	{
		string[] files = Directory.GetFiles(BM.QW);
		int num = Byb.ax();
		if ((long)num <= 1L)
		{
			return true;
		}
		Ck ck = BM.aM();
		ck?.a();
		cb.b();
		if (BM.A(m_framework.aXc, true))
		{
			global::A.A.d(m_framework.aXc, out var _);
		}
		m_framework.M();
		for (int i = P_0 + 1; i < num; i++)
		{
			ByF[i - 1].a(ByF[i], true);
			if (h())
			{
				File.Copy(files[i], files[i - 1], true);
			}
		}
		if (ByC != null)
		{
			int num2 = ByC.ax();
			if (num2 > P_0)
			{
				ByC.a(num2 - 1, true);
			}
			else if (num2 == P_0)
			{
				ByC.a(-1, true);
			}
		}
		if (Byc.ax() >= num - 1)
		{
			Byc.a(num - 2, true);
		}
		Byb.a(num - 1, true);
		m_framework.A(true);
		ck?.B();
		G();
		if (ByG != null)
		{
			ByG.Invoke((object)null, (EventArgs)null);
		}
		BM.Z();
		return true;
	}

	internal bool A(int P_0, int P_1)
	{
		if (Byb.ax() < 2)
		{
			return false;
		}
		if (P_0 == P_1)
		{
			return true;
		}
		Ck ck = BM.aM();
		ck?.a();
		cb.b();
		if (BM.A(m_framework.aXc, true))
		{
			global::A.A.d(m_framework.aXc, out var _);
		}
		m_framework.M();
		List<List<int>> val = new List<List<int>>();
		SettingOrSpecialObject.A(ByF[P_0], val);
		string text = BM.QW + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhM();
		if (File.Exists(text))
		{
			File.Delete(text);
		}
		string[] files = Directory.GetFiles(BM.QW);
		if (h() && files.Length > P_0)
		{
			File.Copy(files[P_0], text, true);
		}
		if (P_0 > P_1)
		{
			for (int num = P_0; num > P_1; num--)
			{
				ByF[num].a(ByF[num - 1], true);
				if (h() && files.Length > P_0)
				{
					File.Copy(files[num - 1], files[num], true);
				}
			}
			if (h() && files.Length > P_1 && File.Exists(text))
			{
				File.Copy(text, files[P_1], true);
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			int num2 = 0;
			SettingOrSpecialObject.A(ByF[P_1], val, ref num2, true);
			if (ByC != null)
			{
				int num3 = ByC.ax();
				if (num3 == P_0)
				{
					ByC.a(P_1, true);
				}
				else if (num3 >= P_1 && num3 < P_0)
				{
					ByC.a(num3 + 1, true);
				}
			}
		}
		else if (P_0 < P_1)
		{
			for (int i = P_0; i < P_1; i++)
			{
				ByF[i].a(ByF[i + 1], true);
				if (h() && files.Length > P_1)
				{
					File.Copy(files[i + 1], files[i], true);
				}
			}
			if (h() && files.Length > P_1 && File.Exists(text))
			{
				File.Copy(text, files[P_1], true);
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			int num4 = 0;
			SettingOrSpecialObject.A(ByF[P_1], val, ref num4, true);
			if (ByC != null)
			{
				int num5 = ByC.ax();
				if (num5 == P_0)
				{
					ByC.a(P_1, true);
				}
				else if (num5 > P_0 && num5 <= P_1)
				{
					ByC.a(num5 - 1, true);
				}
			}
		}
		m_framework.A(true);
		ck?.B();
		G();
		if (ByG != null)
		{
			ByG.Invoke((object)null, (EventArgs)null);
		}
		BM.Z();
		return true;
	}

	internal new bool B(int P_0)
	{
		int num = Byb.ax();
		if (num == 0 || P_0 >= num || num == ByF.Count)
		{
			return false;
		}
		Ck ck = BM.aM();
		ck?.a();
		cb.b();
		if (BM.A(m_framework.aXc, true))
		{
			global::A.A.d(m_framework.aXc, out var _);
		}
		m_framework.M();
		A(P_0 + 1, true);
		ByF[P_0 + 1].a(ByF[P_0], true);
		if (h())
		{
			string[] files = Directory.GetFiles(BM.QW);
			for (int num2 = files.Length - 1; num2 > P_0; num2--)
			{
				File.Copy(files[num2 - 1], files[num2], true);
			}
		}
		m_framework.A(true);
		ck?.B();
		G();
		if (ByG != null)
		{
			ByG.Invoke((object)null, (EventArgs)null);
		}
		BM.Z();
		return true;
	}

	internal new bool b(int P_0)
	{
		int num = Byb.ax();
		if (num == 0 || P_0 < 0 || P_0 >= num)
		{
			return false;
		}
		Byg.Clear();
		SettingOrSpecialObject.A(ByF[P_0], Byg);
		return true;
	}

	internal new bool C(int P_0)
	{
		int num = Byb.ax();
		if (P_0 >= num || num == ByF.Count)
		{
			return false;
		}
		if (Byg.Count == 0)
		{
			return false;
		}
		Ck ck = BM.aM();
		ck?.a();
		cb.b();
		if (BM.A(m_framework.aXc, true))
		{
			global::A.A.d(m_framework.aXc, out var _);
		}
		m_framework.M();
		if (P_0 != -1)
		{
			A(P_0 + 1, true);
			int num2 = 0;
			SettingOrSpecialObject.A(ByF[P_0 + 1], Byg, ref num2, true);
		}
		else
		{
			P_0 = num;
			A(num, true);
			int num3 = 0;
			SettingOrSpecialObject.A(ByF[P_0], Byg, ref num3, true);
		}
		m_framework.A(true);
		ck?.B();
		G();
		if (ByG != null)
		{
			ByG.Invoke((object)null, (EventArgs)null);
		}
		BM.Z();
		return true;
	}

	internal bool a(int P_0, int P_1)
	{
		int num = Byb.ax();
		if (num == 0 || P_0 < 0 || P_0 >= num || ByF[P_0] == null)
		{
			return false;
		}
		if (ByF[P_0].a().Count == 0 || P_1 < 0 || P_1 >= ByF[P_0].a().Count)
		{
			return false;
		}
		ByH.Clear();
		SettingOrSpecialObject.A(ByF[P_0].a()[P_1], ByH);
		return true;
	}

	internal new bool f()
	{
		return ByH.Count > 0;
	}

	internal Dk B(int P_0, int P_1)
	{
		int num = Byb.ax();
		if (num == 0 || P_0 < 0 || P_0 >= num || ByF[P_0] == null)
		{
			return null;
		}
		if (ByF[P_0].a().Count == 0 || P_1 < 0 || P_1 >= ByF[P_0].a().Count)
		{
			return null;
		}
		if (ByH.Count == 0)
		{
			return null;
		}
		Ck ck = BM.aM();
		ck?.a();
		cb.b();
		if (BM.A(m_framework.aXc, true))
		{
			global::A.A.d(m_framework.aXc, out var _);
		}
		m_framework.M();
		Dk dk = ByF[P_0].a()[P_1];
		int num2 = 0;
		SettingOrSpecialObject.A(dk, ByH, ref num2, true);
		m_framework.A(true);
		ck?.B();
		return dk;
	}

	private new void G()
	{
		for (int i = 0; i < m_framework.awR.c().Count; i++)
		{
			MenuNode menuNode = m_framework.awR.c()[i];
			if (menuNode.l())
			{
				menuNode.y();
			}
		}
	}

	internal List<Setting> A(string P_0, global::A.A.C P_1, bool P_2)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		List<Setting> val = new List<Setting>();
		Enumerator<Setting> enumerator = m_framework.awv.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Setting current = enumerator.Current;
				if (!((SettingOrSpecialObject)current).l() || current.z() != P_1)
				{
					continue;
				}
				string text = current.ay();
				if (string.IsNullOrEmpty(text))
				{
					continue;
				}
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG()))
				{
					if (P_2 && text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG().Length) == P_0)
					{
						val.Add(current);
					}
				}
				else if (!P_2)
				{
					string text2 = ((!text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oh())) ? text : text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oh().Length));
					if (text2 == P_0)
					{
						val.Add(current);
					}
				}
			}
			return val;
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal static void A(Setting P_0, bool P_1)
	{
		string text = P_0.ay();
		if (!text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG()))
		{
			return;
		}
		string text2 = B(P_0.z());
		if (string.IsNullOrWhiteSpace(text2))
		{
			return;
		}
		string text3 = BM.QV + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj();
		string text4 = BM.Qu + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj();
		string text5 = text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG().Length);
		if (string.IsNullOrWhiteSpace(text5))
		{
			return;
		}
		string text6 = text5.Substring(text5.LastIndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq()));
		string text7 = text5.Substring(0, text5.LastIndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq()));
		string text8 = text5;
		int num = 0;
		while (true)
		{
			if (num != 0)
			{
				text8 = text7 + num + text6;
			}
			if (!File.Exists(text4 + text8))
			{
				break;
			}
			bool flag = false;
			try
			{
				byte[] array = File.ReadAllBytes(text3 + text5);
				byte[] array2 = File.ReadAllBytes(text4 + text8);
				if (array.Length == array2.Length && Enumerable.SequenceEqual<byte>((System.Collections.Generic.IEnumerable<byte>)array2, (System.Collections.Generic.IEnumerable<byte>)array))
				{
					flag = true;
				}
			}
			catch
			{
				flag = false;
			}
			if (flag)
			{
				break;
			}
			num++;
		}
		if (BM.A(text5, text8, text2, out var text9))
		{
			string text10 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG() + text8;
			if (text10 != text)
			{
				P_0.A(text10, P_1);
			}
		}
		else
		{
			N.A(text9, true);
		}
	}

	internal new List<Setting.ListItems.A> g()
	{
		List<Setting.ListItems.A> result = new List<Setting.ListItems.A>();
		if (E().Count > 0 && E()[0].a().Count > 0)
		{
			result = E()[0].a()[0].B().d(0);
		}
		return result;
	}

	internal new bool H()
	{
		if (m_framework != null)
		{
			return m_framework.aXA >= new k(2, 30, 0, 1, 0);
		}
		return false;
	}

	internal new bool h()
	{
		if (m_framework != null)
		{
			return m_framework.aXA >= new k(2, 31, 0, 1, 0);
		}
		return false;
	}

	internal static string A(global::A.A.C P_0)
	{
		return P_0 switch
		{
			global::A.A.C.BFH => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahJ(), 
			global::A.A.C.BFh => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhm(), 
			_ => null, 
		};
	}

	internal static string a(global::A.A.C P_0)
	{
		return P_0 switch
		{
			global::A.A.C.BFH => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhN(), 
			global::A.A.C.BFh => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bhn(), 
			_ => null, 
		};
	}

	internal static string B(global::A.A.C P_0)
	{
		return P_0 switch
		{
			global::A.A.C.BFH => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhO(), 
			global::A.A.C.BFh => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bho(), 
			_ => null, 
		};
	}

	internal new static global::A.A.C A(string P_0)
	{
		if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BhO())
		{
			return global::A.A.C.BFH;
		}
		if (P_0 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bho())
		{
			return global::A.A.C.BFh;
		}
		return global::A.A.C.BFI;
	}
}
