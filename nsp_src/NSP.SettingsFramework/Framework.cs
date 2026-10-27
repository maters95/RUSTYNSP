using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using NSP.UserInterface;
using b;
using c;

namespace NSP.SettingsFramework;

public class Framework
{
	internal enum A
	{
		BrB,
		Brb,
		BrC
	}

	private bV aWh;

	private string aWI;

	private byte[] aWi;

	private const uint aWJ = 1048576u;

	private const uint aWj = 32768u;

	private volatile byte[] aWK = new byte[1048576];

	private volatile by[] aWk = new by[1048576];

	private const int aWL = 1024;

	private volatile byte[] aWl = new byte[1024];

	private Stopwatch aWM = new Stopwatch();

	private volatile byte[] aWm = new byte[32768];

	private volatile by[] aWN = new by[32768];

	internal int aWn;

	private volatile List<Setting> aWO = new List<Setting>();

	private uint aWo;

	private volatile List<Setting> aWP = new List<Setting>();

	internal DataIdAndAttrId[] aWp = new DataIdAndAttrId[1048576];

	internal int[] aWQ = new int[32768];

	internal bool aWq;

	internal bool aWR = true;

	internal int aWr;

	internal List<SettingOrSpecialObject> aWS = new List<SettingOrSpecialObject>();

	internal Dictionary<DataIdAndAttrId, Setting> aWs = new Dictionary<DataIdAndAttrId, Setting>();

	internal Dictionary<int, SettingOrSpecialObject> aWT = new Dictionary<int, SettingOrSpecialObject>();

	internal List<Setting> aWt = new List<Setting>();

	internal List<Setting> aWU = new List<Setting>();

	internal List<Setting> aWu = new List<Setting>();

	internal List<Table> aWV = new List<Table>();

	internal Dictionary<string, Dm> aWv = new Dictionary<string, Dm>();

	internal DTCErrors aWW = new DTCErrors();

	internal List<Setting> aWw = new List<Setting>();

	internal bool aWX;

	internal List<SettingOrSpecialObject> aWx = new List<SettingOrSpecialObject>();

	internal List<SettingOrSpecialObject> aWY = new List<SettingOrSpecialObject>();

	internal Dictionary<int, int> aWy = new Dictionary<int, int>();

	internal List<int> aWZ = new List<int>();

	internal bool aWz;

	internal bool awA;

	internal int awa;

	internal Dictionary<int, MenuNode> awB = new Dictionary<int, MenuNode>();

	internal Dictionary<Cg, List<Connector>> awb = new Dictionary<Cg, List<Connector>>();

	internal Dictionary<Cg, string> awC = new Dictionary<Cg, string>();

	internal List<WiringPin> awc = new List<WiringPin>();

	internal List<SettingOrSpecialObject> awD = new List<SettingOrSpecialObject>();

	internal List<Dn> awd = new List<Dn>();

	internal List<SettingOrSpecialObject> awE = new List<SettingOrSpecialObject>();

	internal bool awe;

	internal Dictionary<int, DO> awF = new Dictionary<int, DO>();

	internal Dictionary<byte, Setting> awf = new Dictionary<byte, Setting>();

	internal Dictionary<byte, SettingOrSpecialObject> awG = new Dictionary<byte, SettingOrSpecialObject>();

	internal Dictionary<int, string> awg = new Dictionary<int, string>();

	internal Dictionary<int, List<Cd>> awH = new Dictionary<int, List<Cd>>();

	internal SettingOrSpecialObject awh;

	internal DI awI;

	internal List<int> awi = new List<int>();

	internal List<int> awJ = new List<int>();

	internal List<MenuNode> awj = new List<MenuNode>();

	internal int awK;

	internal int awk;

	internal List<MenuNode> awL = new List<MenuNode>();

	internal MenuNode awl;

	internal int awM;

	internal MenuNode awm;

	internal int awN;

	internal Dictionary<string, CB> awn = new Dictionary<string, CB>();

	internal KnockDetection awO;

	internal CJ awo;

	internal Di awP;

	internal Dj awp;

	internal DM awQ;

	internal List<DL> awq = new List<DL>();

	internal MenuNode awR;

	internal MenuNode awr;

	internal MenuNode awS;

	internal DN aws;

	internal DN awT;

	internal DN awt;

	internal MenuNode awU;

	internal MenuNode awu;

	internal MenuNode awV;

	internal List<Setting> awv = new List<Setting>();

	internal Setting awW;

	internal Dictionary<global::A.A.C, List<string>> aww = new Dictionary<global::A.A.C, List<string>>();

	internal Dictionary<int, MenuNode> awX = new Dictionary<int, MenuNode>();

	internal Dictionary<string, DataTableObject> awx = new Dictionary<string, DataTableObject>();

	internal string awY;

	internal string awy;

	internal int awZ;

	internal int awz;

	internal k aXA;

	internal string aXa;

	internal string aXB;

	internal string aXb;

	internal string aXC;

	internal string aXc = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHO();

	internal string aXD = string.Empty;

	internal bool aXd;

	internal bool aXE = true;

	private bool aXe;

	private bool aXF;

	private bool aXf;

	private bool aXG;

	private bool aXg;

	private bool aXH = true;

	private bool aXh;

	private bool aXI;

	private bool aXi;

	private Stopwatch aXJ = new Stopwatch();

	private const uint aXj = 50u;

	internal Units aXK;

	internal GlobalImageLibrary aXk;

	internal List<ValueTuple<byte, byte>> aXL = new List<ValueTuple<byte, byte>>();

	[CompilerGenerated]
	private EventHandler aXl;

	private bool aXM = true;

	internal ushort[] aXm;

	internal ushort[] aXN;

	internal ushort aXn = 1;

	internal Framework(string P_0, int P_1, int P_2, k P_3)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		aWI = P_0;
		awZ = P_1;
		awz = P_2;
		aXA = P_3;
		aXe = false;
		A();
		byte[] array = null;
		try
		{
			array = File.ReadAllBytes(aWI);
		}
		catch (System.Exception ex)
		{
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHo() + ex.Message;
			global::A.N.A(text, true);
			throw new System.Exception(text);
		}
		try
		{
			MD5 val = MD5.Create();
			try
			{
				aWi = ((HashAlgorithm)val).ComputeHash(array);
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		catch (System.Exception ex2)
		{
			string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHP() + ex2.Message;
			global::A.N.A(text2, true);
			throw new System.Exception(text2);
		}
		aWh = new bV(this, P_0);
	}

	internal void A()
	{
		aWi = null;
		for (int i = 0; i < aWK.Length; i++)
		{
			aWK[i] = 0;
		}
		for (int j = 0; j < aWk.Length; j++)
		{
			aWk[j] = by.aYJ;
		}
		for (int k = 0; k < aWm.Length; k++)
		{
			aWm[k] = 0;
		}
		for (int l = 0; l < aWN.Length; l++)
		{
			aWN[l] = by.aYJ;
		}
		for (int m = 0; m < aWp.Length; m++)
		{
			aWp[m] = new DataIdAndAttrId(0, 0);
		}
		for (int n = 0; n < aWQ.Length; n++)
		{
			aWQ[n] = 0;
		}
		aWn = 0;
		D();
		aWr = 0;
		aWS.Clear();
		aWs.Clear();
		aWT.Clear();
		aWt.Clear();
		aWU.Clear();
		aWu.Clear();
		aWV.Clear();
		aWx.Clear();
		aWY.Clear();
		aWy.Clear();
		aWZ.Clear();
		aWz = false;
		awA = false;
		awa = 0;
		awB.Clear();
		aWv.Clear();
		aWw.Clear();
		aWX = false;
		awb.Clear();
		awC.Clear();
		awc.Clear();
		awD.Clear();
		awd.Clear();
		awE.Clear();
		awe = false;
		awF.Clear();
		awf.Clear();
		awG.Clear();
		awg.Clear();
		awh = null;
		awI = null;
		awi.Clear();
		awJ.Clear();
		awK = 0;
		awk = 0;
		awj.Clear();
		awL.Clear();
		awM = 0;
		awl = null;
		awN = 0;
		awm = null;
		awn.Clear();
		awO = null;
		awo = null;
		awP = null;
		awp = null;
		awQ = null;
		awq.Clear();
		awR = null;
		awr = null;
		awS = null;
		aws = null;
		awT = null;
		awt = null;
		awU = null;
		awu = null;
		awV = null;
		awv.Clear();
		awW = null;
		aww.Clear();
		awX.Clear();
		awx.Clear();
		aWo = 0u;
		aWO.Clear();
		aWP.Clear();
		aXK = null;
		aXk = null;
	}

	internal bV.A a()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Stopwatch val = new Stopwatch();
		val.Start();
		bV.A a = aWh.A();
		aXe = a == bV.A.Brc;
		val.Stop();
		if (aXe)
		{
			global::A.N.A(string.Format(string.Concat(new string[7]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHp(),
				awZ.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHQ(),
				awz.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv(),
				((object)aXA)?.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHq()
			}), (object)val.ElapsedMilliseconds), true);
			if (!aWX)
			{
				val.Restart();
				g();
				aWX = true;
				val.Stop();
				global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHR(), (object)val.ElapsedMilliseconds), true);
			}
		}
		GC.Collect();
		return a;
	}

	[SpecialName]
	internal bool B()
	{
		return aXf;
	}

	[SpecialName]
	internal bool b()
	{
		return aXG;
	}

	[SpecialName]
	internal bool C()
	{
		return aXH;
	}

	[SpecialName]
	internal bool c()
	{
		return aXe;
	}

	internal void D()
	{
		for (int i = 0; i < aWl.Length; i++)
		{
			aWl[i] = 0;
		}
	}

	[SpecialName]
	internal byte[] d()
	{
		return aWl;
	}

	[SpecialName]
	internal void A(byte[] P_0)
	{
		aWl = P_0;
	}

	[SpecialName]
	internal bool E()
	{
		return aXF;
	}

	[SpecialName]
	internal string e()
	{
		return aWI;
	}

	[SpecialName]
	internal byte[] F()
	{
		return aWi;
	}

	internal bool f()
	{
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		Stream val = null;
		try
		{
			val = (Stream)(object)global::A.S.a(aWI, global::A.M.a());
		}
		catch
		{
			return false;
		}
		bool flag;
		try
		{
			flag = global::A.R.A(val);
		}
		catch (System.Exception)
		{
			flag = false;
		}
		G();
		if (!VirtualDashAppPanel.C())
		{
			val.Close();
			return false;
		}
		string text = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DV();
		Stream val2 = null;
		if (flag)
		{
			try
			{
				if (!global::A.R.A(val, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dv(), out val2, null))
				{
					val.Close();
					return false;
				}
				byte[] array = new byte[val2.Length];
				if (!global::A.N.A(val2, array, 0, array.Length))
				{
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHr());
				}
				File.WriteAllBytes(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dv(), array);
			}
			catch (System.Exception ex2)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHS() + ex2.Message, true);
				if (val2 != null)
				{
					val2.Close();
				}
				val.Close();
				return false;
			}
		}
		if (val2 != null)
		{
			val2.Close();
		}
		bool flag2 = false;
		if (flag)
		{
			List<string> val3 = null;
			try
			{
				val3 = global::A.R.A(val, null);
				if (Directory.Exists(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHs()))
				{
					Directory.Delete(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHs(), true);
				}
			}
			catch (System.Exception ex3)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHS() + ex3.Message, true);
				if (val != null)
				{
					val.Close();
				}
				return false;
			}
			Enumerator<string> enumerator = val3.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (!current.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHs()))
					{
						continue;
					}
					Stream val4 = null;
					try
					{
						if (!global::A.R.A(val, current, out val4, null))
						{
							val.Close();
							return false;
						}
						byte[] array2 = new byte[val4.Length];
						if (!global::A.N.A(val4, array2, 0, array2.Length))
						{
							throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHT());
						}
						Directory.CreateDirectory(Path.GetDirectoryName(text + current));
						File.WriteAllBytes(text + current, array2);
						flag2 = true;
					}
					catch (System.Exception ex4)
					{
						global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHS() + ex4.Message, true);
						if (val4 != null)
						{
							val4.Close();
						}
						val.Close();
						return false;
					}
					if (val4 != null)
					{
						val4.Close();
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		if (val != null)
		{
			val.Close();
		}
		if (flag2)
		{
			VirtualDashAppPanel.A();
			VirtualDashAppPanel.EG = this;
			VirtualDashAppPanel.a();
		}
		return flag2;
	}

	private void G()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Directory.CreateDirectory(BM.QW);
			FileInfo[] files = new DirectoryInfo(BM.QW).GetFiles(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHt());
			foreach (FileInfo val in files)
			{
				try
				{
					((FileSystemInfo)val).Delete();
				}
				catch (System.Exception ex)
				{
					global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHU() + ex.Message, true);
				}
			}
		}
		catch (System.Exception ex2)
		{
			global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHU() + ex2.Message, true);
		}
	}

	private void g()
	{
		Stream val = (Stream)(object)global::A.S.a(aWI, global::A.M.a());
		bool flag;
		try
		{
			flag = global::A.R.A(val);
		}
		catch (System.Exception)
		{
			flag = false;
		}
		Stream val2 = null;
		if (flag)
		{
			if (!global::A.R.A(val, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGW(), out val2, null))
			{
				val.Close();
				return;
			}
			Stream val3 = null;
			if (!global::A.R.A(val2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGw(), out val3, global::A.M.A()))
			{
				val2.Close();
				return;
			}
			new Cq(val3, this).A(out var _, true, false, false);
			val3.Close();
		}
		if (val2 != null)
		{
			val2.Close();
		}
		val.Close();
	}

	internal void A(List<SettingOrSpecialObject> P_0)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_0[i];
			A(settingOrSpecialObject.a());
			if (settingOrSpecialObject is Setting)
			{
				(settingOrSpecialObject as Setting).I(false);
			}
		}
	}

	internal void H()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		a(aWS);
		Enumerator<Table> enumerator = aWV.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.FindComponents();
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (awP != null)
		{
			awP.A();
		}
		if (awp != null)
		{
			awp.A();
		}
		Enumerator<DL> enumerator2 = awq.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				enumerator2.Current.A();
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
		if (awQ != null)
		{
			awQ.A();
		}
		Enumerator<SettingOrSpecialObject> enumerator3 = awD.GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				enumerator3.Current.F().B();
			}
		}
		finally
		{
			((System.IDisposable)enumerator3).Dispose();
		}
		awo = new CJ(this);
		awo.A();
	}

	private void a(List<SettingOrSpecialObject> P_0)
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < P_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_0[i];
			if (settingOrSpecialObject is Setting)
			{
				Setting setting = settingOrSpecialObject as Setting;
				if (setting is SensorCalibration)
				{
					(setting as SensorCalibration).FindComponents();
				}
				int num = awJ.IndexOf(setting.A());
				if (num != -1)
				{
					setting.D(awi[num]);
				}
			}
			else
			{
				if (settingOrSpecialObject is OnOffSwitchingPoint)
				{
					(settingOrSpecialObject as OnOffSwitchingPoint).FindComponents();
				}
				if (settingOrSpecialObject is StateMachine)
				{
					(settingOrSpecialObject as StateMachine).FindComponents();
				}
				if (settingOrSpecialObject is DN)
				{
					(settingOrSpecialObject as DN).b();
				}
			}
			a(settingOrSpecialObject.a());
		}
		if (P_0 != aWS)
		{
			return;
		}
		Enumerator<int> enumerator = awi.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current = enumerator.Current;
				A(current)?.F(true);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal byte[] h()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		MemoryStream val = new MemoryStream();
		A(val);
		A(val, aWS);
		((Stream)val).Flush();
		byte[] result = val.ToArray();
		((Stream)val).Close();
		return result;
	}

	private void A(MemoryStream P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<Setting> enumerator = aWu.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Setting current = enumerator.Current;
				byte[] array = new byte[current.BB()];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = current.l(i);
				}
				((Stream)P_0).Write(array, 0, array.Length);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void A(MemoryStream P_0, List<SettingOrSpecialObject> P_1)
	{
		for (int i = 0; i < P_1.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_1[i];
			A(P_0, settingOrSpecialObject.a());
			if (!(settingOrSpecialObject is Setting))
			{
				continue;
			}
			Setting setting = settingOrSpecialObject as Setting;
			if (setting.s().Length == 0 && setting.aI())
			{
				byte[] array = new byte[setting.BB()];
				for (int j = 0; j < array.Length; j++)
				{
					array[j] = setting.l(j);
				}
				((Stream)P_0).Write(array, 0, array.Length);
			}
		}
	}

	public virtual string ToString()
	{
		return awy + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHu(), (object)aXA);
	}

	[SpecialName]
	internal byte[] I()
	{
		return aWK;
	}

	[SpecialName]
	internal by[] i()
	{
		return aWk;
	}

	[SpecialName]
	internal byte[] J()
	{
		return aWm;
	}

	[SpecialName]
	internal by[] j()
	{
		return aWN;
	}

	[SpecialName]
	internal List<Setting> K()
	{
		return aWO;
	}

	[SpecialName]
	internal List<Setting> k()
	{
		return aWP;
	}

	internal bool A(bt P_0)
	{
		if (awG.ContainsKey((byte)P_0))
		{
			return awG[(byte)P_0].l();
		}
		if (awf.ContainsKey((byte)P_0))
		{
			return awf[(byte)P_0].ax() != 0;
		}
		return false;
	}

	internal static bool A(string P_0)
	{
		if (!string.IsNullOrWhiteSpace(P_0) && P_0.Length >= 2 && P_0[0] != ' ' && P_0[0] != 0 && !global::A.m.A(P_0))
		{
			return !P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax());
		}
		return false;
	}

	internal bool A(ref string P_0)
	{
		Setting setting = A(1501);
		if (setting != null)
		{
			P_0 = setting.ay();
			if (aXF)
			{
				return setting.O();
			}
			return A(P_0);
		}
		P_0 = string.Empty;
		return false;
	}

	internal int L()
	{
		return 1 + awk + awK;
	}

	internal Image a(string P_0)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		if (aXk != null && aXk.ImageItemList != null && aXk.ImageItemList.ContainsKey(P_0) && !string.IsNullOrEmpty(aXk.ImageItemList[P_0].ImageHexString))
		{
			byte[] array = global::A.n.A(aXk.ImageItemList[P_0].ImageHexString);
			if (array != null)
			{
				MemoryStream val = new MemoryStream(array);
				Image result = Image.FromStream((Stream)val);
				((Stream)val).Close();
				return result;
			}
		}
		return null;
	}

	internal Setting A(int P_0)
	{
		return A(new DataIdAndAttrId(P_0));
	}

	internal Setting A(DataIdAndAttrId P_0)
	{
		if (aWs.ContainsKey(P_0))
		{
			return aWs[P_0];
		}
		return null;
	}

	internal SettingOrSpecialObject a(int P_0)
	{
		if (aWT.ContainsKey(P_0))
		{
			return aWT[P_0];
		}
		return null;
	}

	internal Setting B(int P_0)
	{
		if (P_0 >= 0 && P_0 < aWp.Length)
		{
			DataIdAndAttrId dataIdAndAttrId = aWp[P_0];
			return A(dataIdAndAttrId);
		}
		return null;
	}

	internal Setting b(int P_0)
	{
		if (P_0 >= 0 && P_0 < aWQ.Length)
		{
			return A(aWQ[P_0]);
		}
		return null;
	}

	private void A(List<MenuNode> P_0)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			MenuNode menuNode = P_0[i];
			if (menuNode.H() != -1)
			{
				SettingOrSpecialObject settingOrSpecialObject = a(menuNode.H());
				if (settingOrSpecialObject != null)
				{
					PortFunction.A(menuNode, settingOrSpecialObject);
				}
			}
			A(menuNode.c());
			menuNode.ae();
		}
	}

	internal void a(List<MenuNode> P_0)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			MenuNode menuNode = P_0[i];
			a(menuNode.c());
			menuNode.y();
		}
	}

	internal bool A(HashSet<DataIdAndAttrId> P_0)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		if (P_0 == null || P_0.Count == 0)
		{
			B(awj);
			result = true;
		}
		else
		{
			HashSet<MenuNode> val = new HashSet<MenuNode>();
			Enumerator<DataIdAndAttrId> enumerator = P_0.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DataIdAndAttrId current = enumerator.Current;
					MenuNode menuNode = MenuNode.A(awj, current);
					Setting setting = A(current);
					if (setting == null || menuNode == null)
					{
						continue;
					}
					MenuNode menuNode2 = menuNode.A(setting);
					if (menuNode2 == null || val.Contains(menuNode2))
					{
						continue;
					}
					val.Add(menuNode2);
					bool flag = menuNode2.aC();
					if (menuNode2.Z())
					{
						menuNode2.G(false);
						if (!flag)
						{
							result = true;
						}
					}
					else if (flag)
					{
						result = true;
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

	private void B(List<MenuNode> P_0)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			MenuNode menuNode = P_0[i];
			if (menuNode.x())
			{
				if (menuNode.Z())
				{
					menuNode.G(false);
				}
			}
			else
			{
				B(menuNode.c());
			}
		}
	}

	internal void A(HashSet<DataIdAndAttrId> P_0, Framework P_1, HashSet<DataIdAndAttrId> P_2)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (P_1 == null)
		{
			return;
		}
		if (P_0 == null || P_0.Count == 0)
		{
			P_2.Clear();
			A(aWS, P_1, P_2);
			return;
		}
		Enumerator<DataIdAndAttrId> enumerator = P_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				Setting setting = A(current);
				Setting setting2 = P_1.A(current);
				if ((B() && b() && setting != null && setting.J()) || (P_1.B() && P_1.b() && setting2 != null && setting2.J()))
				{
					if (P_2.Contains(current))
					{
						P_2.Remove(current);
					}
				}
				else if (setting == null || setting2 == null || !setting.A(setting2))
				{
					P_2.Add(current);
				}
				else if (P_2.Contains(current))
				{
					P_2.Remove(current);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void A(List<SettingOrSpecialObject> P_0, Framework P_1, HashSet<DataIdAndAttrId> P_2)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_0[i];
			if (settingOrSpecialObject is Setting)
			{
				Setting setting = settingOrSpecialObject as Setting;
				if (!setting.aJ())
				{
					Setting setting2 = P_1.A(setting.C());
					if ((B() && b() && setting.J()) || (P_1.B() && P_1.b() && setting2 != null && setting2.J()))
					{
						if (P_2.Contains(setting.C()))
						{
							P_2.Remove(setting.C());
						}
					}
					else if (setting2 == null || !setting.A(setting2))
					{
						P_2.Add(setting.C());
					}
				}
			}
			A(settingOrSpecialObject.a(), P_1, P_2);
		}
	}

	internal bool a(HashSet<DataIdAndAttrId> P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Stopwatch val = new Stopwatch();
		val.Start();
		if (awT != null)
		{
			awT.A(P_0);
		}
		if (aws != null)
		{
			aws.A(P_0);
		}
		if (awt != null)
		{
			awt.A(P_0);
		}
		bool result = false;
		B(aWS);
		A(aWS, P_0, false, ref result);
		A(aWS, P_0, true, ref result);
		Setting setting = null;
		if (awh != null && awh.f() != null)
		{
			setting = A(awh.f().DataIdOfChannelListSetting);
			setting?.az();
		}
		b(aWS);
		setting?.i(true);
		aXF = true;
		B(P_0);
		if (!BM.qW)
		{
			BM.qA.ae();
		}
		A(awj);
		if (awl != null)
		{
			A(awl.c());
		}
		if (awm != null)
		{
			A(awm.c());
		}
		if (P_0 != null)
		{
			A(P_0, ref result);
		}
		val.Stop();
		global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHV(), (object)val.ElapsedMilliseconds), true);
		return result;
	}

	private void A(HashSet<DataIdAndAttrId> P_0, ref bool P_1)
	{
		HashSet<DataIdAndAttrId> val = null;
		DataIdAndAttrId[] array = new DataIdAndAttrId[P_0.Count];
		P_0.CopyTo(array);
		DataIdAndAttrId[] array2 = array;
		foreach (DataIdAndAttrId dataIdAndAttrId in array2)
		{
			Setting setting = A(dataIdAndAttrId);
			if (setting != null && setting.S().Count != 0)
			{
				PortFunction.A(setting, out val);
			}
		}
		if (val != null && val.Count != 0)
		{
			A(aWS, val, false, ref P_1);
			A(aWS, val, true, ref P_1);
		}
	}

	private void A(List<SettingOrSpecialObject> P_0, HashSet<DataIdAndAttrId> P_1, bool P_2, ref bool P_3)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_0[i];
			if (settingOrSpecialObject.A(P_1, P_2))
			{
				P_3 = true;
			}
			A(settingOrSpecialObject.a(), P_1, P_2, ref P_3);
		}
	}

	private void B(HashSet<DataIdAndAttrId> P_0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 == null || P_0.Count == 0)
		{
			return;
		}
		bool flag = false;
		Enumerator<byte, Setting> enumerator = awf.Values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Setting current = enumerator.Current;
				if (P_0.Contains(current.C()))
				{
					flag = true;
					break;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (!flag)
		{
			Enumerator<byte, SettingOrSpecialObject> enumerator2 = awG.Values.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					SettingOrSpecialObject current2 = enumerator2.Current;
					Enumerator<DataIdAndAttrId> enumerator3 = P_0.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							DataIdAndAttrId current3 = enumerator3.Current;
							if (current3.AttrId == 0)
							{
								int dataId = current3.DataId;
								if (current2.M().Contains(dataId))
								{
									flag = true;
									break;
								}
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator3).Dispose();
					}
					if (flag)
					{
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
		}
		if (flag)
		{
			BM.N();
		}
	}

	internal void B(List<SettingOrSpecialObject> P_0)
	{
		for (int num = P_0.Count - 1; num >= 0; num--)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_0[num];
			settingOrSpecialObject.O();
			B(settingOrSpecialObject.a());
		}
	}

	internal void b(List<SettingOrSpecialObject> P_0)
	{
		for (int num = P_0.Count - 1; num >= 0; num--)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_0[num];
			settingOrSpecialObject.n();
			b(settingOrSpecialObject.a());
		}
	}

	internal void C(List<SettingOrSpecialObject> P_0)
	{
		for (int num = P_0.Count - 1; num >= 0; num--)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_0[num];
			if (settingOrSpecialObject is Setting)
			{
				(settingOrSpecialObject as Setting).az();
			}
			C(settingOrSpecialObject.a());
		}
	}

	internal void c(List<SettingOrSpecialObject> P_0)
	{
		for (int num = P_0.Count - 1; num >= 0; num--)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_0[num];
			if (settingOrSpecialObject is Setting)
			{
				(settingOrSpecialObject as Setting).i(true);
			}
			c(settingOrSpecialObject.a());
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = aXl;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref aXl, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = aXl;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref aXl, val3, val2);
		}
		while (val != val2);
	}

	internal void A(Setting P_0)
	{
		if (aXl != null)
		{
			aXl.Invoke((object)P_0, (EventArgs)null);
		}
	}

	[SpecialName]
	internal bool l()
	{
		return aXM;
	}

	internal void A(bool P_0, Setting P_1 = null)
	{
		aXM = true;
		if (P_0)
		{
			A(P_1);
		}
	}

	internal void M()
	{
		aXM = false;
	}

	internal void m()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<MenuNode> enumerator = awj.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.aD();
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal bool A(out Setting P_0, out Setting P_1)
	{
		P_0 = A(8);
		P_1 = A(1503);
		if (P_0 != null)
		{
			return P_1 != null;
		}
		return false;
	}

	internal void N()
	{
		if (A(out var _, out var setting2))
		{
			bool flag = false;
			for (int i = 0; i < setting2.BB(); i++)
			{
				if (setting2.l(i) != 0)
				{
					flag = true;
					break;
				}
			}
			aXf = flag;
			aXG = aXf;
			Setting setting3 = A(9496);
			D(aWS);
			if (setting3 == null)
			{
				return;
			}
			int num = 0;
			for (int j = 0; j < setting3.BB(); j++)
			{
				byte b = setting3.l(j);
				for (int k = 0; k < 8; k++)
				{
					Setting setting4 = A(num);
					num++;
					if (setting4 != null)
					{
						byte b2 = (byte)(128 >> k);
						bool flag2 = (b & b2) != 0;
						setting4.c(flag2);
					}
				}
			}
		}
		else
		{
			aXf = false;
			aXG = false;
		}
	}

	internal void D(List<SettingOrSpecialObject> P_0)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_0[i];
			if (settingOrSpecialObject is Setting)
			{
				(settingOrSpecialObject as Setting).c(true);
			}
			D(settingOrSpecialObject.a());
		}
	}

	internal DialogResult A(bool P_0, bool P_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (aXg)
		{
			return (DialogResult)5;
		}
		BS bS = new BS(this, P_0, P_1);
		DialogResult val = ((Form)bS).ShowDialog((IWin32Window)(object)BM.QQ);
		aXg = (int)val == 5;
		if ((int)val == 1)
		{
			aXG = false;
		}
		((Component)bS).Dispose();
		return val;
	}

	internal static byte[] B(string P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		MemoryStream val = new MemoryStream();
		StreamWriter val2 = new StreamWriter((Stream)val);
		((TextWriter)val2).Write(P_0);
		((TextWriter)val2).Flush();
		byte[] array = val.ToArray();
		MD5 obj = MD5.Create();
		byte[] result = ((HashAlgorithm)obj).ComputeHash(array);
		((HashAlgorithm)obj).Dispose();
		((TextWriter)val2).Close();
		((Stream)val).Close();
		return result;
	}

	internal bool A(Framework P_0)
	{
		Setting setting = A(1503);
		Setting setting2 = P_0.A(1503);
		if (setting != null && setting2 != null && setting.BB() == setting2.BB())
		{
			for (int i = 0; i < setting.BB(); i++)
			{
				if (setting.l(i) != setting2.l(i))
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	internal bool b(string P_0)
	{
		Setting setting = A(1503);
		if (setting != null)
		{
			byte[] array = B(P_0);
			for (int i = 0; i < setting.BB(); i++)
			{
				if (setting.l(i) != array[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	internal void C(string P_0)
	{
		if (!A(out var setting, out var setting2))
		{
			return;
		}
		aXf = true;
		setting.a(1, true);
		byte[] array = B(P_0);
		for (int i = 0; i < setting2.BB(); i++)
		{
			setting2.A(i, array[i], true);
		}
		Setting setting3 = A(9496);
		if (setting3 == null)
		{
			return;
		}
		int num = 0;
		for (int j = 0; j < setting3.BB(); j++)
		{
			byte b = 0;
			for (int k = 0; k < 8; k++)
			{
				Setting setting4 = A(num);
				num++;
				if (setting4 != null)
				{
					byte b2 = (byte)(128 >> k);
					if (setting4.J())
					{
						b |= b2;
					}
				}
			}
			setting3.A(j, b, true);
		}
	}

	internal void n()
	{
		if (!A(out var setting, out var setting2))
		{
			return;
		}
		aXf = false;
		setting.a(0, true);
		for (int i = 0; i < setting2.BB(); i++)
		{
			setting2.A(i, (byte)0, true);
		}
		Setting setting3 = A(9496);
		if (setting3 == null)
		{
			return;
		}
		int num = 0;
		for (int j = 0; j < setting3.BB(); j++)
		{
			for (int k = 0; k < 8; k++)
			{
				Setting setting4 = A(num);
				num++;
				setting4?.c(false);
			}
			setting3.A(j, (byte)0, true);
		}
	}

	internal void A(IWin32Window P_0)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		aXH = false;
		Setting setting = A(14691);
		if (setting != null)
		{
			if (setting.ax() != 1 || !Bg.A(setting, null))
			{
				do
				{
					Bg bg = new Bg(((SettingOrSpecialObject)setting).P(), setting, null);
					if ((int)((Form)bg).ShowDialog(P_0) == 1)
					{
						setting.a(1, true);
						aXH = true;
					}
					else
					{
						aXH = false;
						if (a(P_0))
						{
							break;
						}
					}
					((Component)bg).Dispose();
				}
				while (!aXH);
			}
			else
			{
				aXH = true;
			}
		}
		else
		{
			aXH = true;
		}
		aXh = true;
	}

	private bool a(IWin32Window P_0)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		if (BM.qW)
		{
			return false;
		}
		Setting setting = A(14691);
		if (setting != null)
		{
			string text = ((setting.ax() == 1) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHW() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHv());
			if ((int)bE.A(P_0, text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHw(), (MessageBoxButtons)1, (MessageBoxIcon)48, (MessageBoxDefaultButton)0, new string[2]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHX()
			}) == 2)
			{
				return false;
			}
		}
		return true;
	}

	internal void O()
	{
		if (aXH || !aXh)
		{
			return;
		}
		Setting setting = A(14691);
		Setting setting2 = A(1320);
		if (setting == null || setting2 == null)
		{
			return;
		}
		if (setting2.ax() == 39)
		{
			bool flag = false;
			if (!aXI)
			{
				flag = true;
				aXI = true;
			}
			if (o())
			{
				if (!aXi)
				{
					flag = true;
					aXi = true;
				}
			}
			else
			{
				aXi = false;
			}
			if (flag && !a((IWin32Window)(object)BM.QQ))
			{
				A((IWin32Window)(object)BM.QQ);
				BM.E();
			}
		}
		else
		{
			aXI = false;
		}
	}

	internal bool o()
	{
		Setting setting = A(384);
		if (setting != null)
		{
			return setting.ax() != 0;
		}
		return false;
	}

	internal void A(Framework P_0, List<SettingOrSpecialObject> P_1, bool P_2, bool P_3, bool P_4 = false)
	{
		for (int i = 0; i < P_1.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_1[i];
			if (settingOrSpecialObject is Setting)
			{
				Setting setting = settingOrSpecialObject as Setting;
				if (!setting.aJ() && (P_2 || !setting.D()))
				{
					setting.A(P_0, P_3, P_4);
				}
			}
			A(P_0, settingOrSpecialObject.a(), P_2, P_3, P_4);
		}
	}

	internal void A(Framework P_0, bool P_1)
	{
		if (!BezierCurve.ETCBezierToTableRedundancyIsOK(P_0, this))
		{
			Setting setting = A(14206);
			if (setting != null && ((SettingOrSpecialObject)setting).D() != null && ((SettingOrSpecialObject)setting).D() is Table)
			{
				(((SettingOrSpecialObject)setting).D() as Table).I(P_1);
			}
		}
	}

	internal void A(long P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Stopwatch val = new Stopwatch();
		val.Start();
		lock (this)
		{
			if (!aWM.IsRunning)
			{
				aWM.Start();
			}
			if (aWM.ElapsedMilliseconds >= P_0)
			{
				F f = global::A.A.e(aXc);
				if (f != null)
				{
					uint bF = f.@as[38].BF;
					if (bF != 0 && global::A.A.A(aXc, global::A.f.az, 0u, bF, out var array, out var _))
					{
						for (int i = 0; i < bF; i++)
						{
							if (array[i] == aWl[i])
							{
								continue;
							}
							for (int j = 0; j < 1024; j++)
							{
								int num = 1024 * i + j;
								if (aWk[num] != by.aYK && aWk[num] != by.aYk)
								{
									aWk[num] = by.aYj;
								}
							}
							aWl[i] = array[i];
						}
					}
				}
				aWM.Restart();
			}
		}
		val.Stop();
		global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHx(), (object)val.ElapsedMilliseconds), false);
	}

	internal void P()
	{
		F f = global::A.A.e(aXc);
		if (f != null)
		{
			uint bF = f.@as[35].BF;
			for (uint num = 0u; num < bF; num++)
			{
				aWk[num] = by.aYj;
			}
		}
	}

	internal void p()
	{
		F f = global::A.A.e(aXc);
		if (f != null)
		{
			uint bF = f.@as[35].BF;
			for (uint num = 0u; num < bF; num++)
			{
				aWk[num] = by.aYK;
			}
		}
	}

	internal void Q()
	{
		for (int i = 0; i < aWk.Length; i++)
		{
			aWk[i] = by.aYJ;
		}
	}

	internal bool q()
	{
		F f = global::A.A.e(aXc);
		if (f != null)
		{
			uint bF = f.@as[35].BF;
			for (uint num = 0u; num < bF; num++)
			{
				if (aWk[num] == by.aYK || aWk[num] == by.aYk)
				{
					return true;
				}
			}
		}
		return false;
	}

	internal bool R()
	{
		F f = global::A.A.e(aXc);
		if (f != null)
		{
			uint bF = f.@as[33].BF;
			for (uint num = 0u; num < bF; num++)
			{
				aWN[num] = by.aYj;
			}
		}
		return true;
	}

	internal void r()
	{
		if (!aWq)
		{
			return;
		}
		F f = global::A.A.e(aXc);
		if (f == null)
		{
			return;
		}
		uint bF = f.@as[35].BF;
		uint num = global::A.A.A(aXc, global::A.f.aY);
		if (aWo + num > bF)
		{
			num = bF - aWo;
		}
		if (global::A.A.A(aXc, global::A.f.aY, aWo, num, out var array, out var _))
		{
			lock (K())
			{
				uint num2 = 0u;
				while (num2 < num)
				{
					uint num3 = aWo + num2;
					if (aWk[num3] == by.aYJ && aWK[num3] != array[num2])
					{
						Setting setting = B((int)num3);
						if (setting != null && setting.aI() && !setting.aJ() && !setting.am() && !setting.al() && !setting.aN())
						{
							if (!setting.g() && !K().Contains(setting))
							{
								K().Add(setting);
							}
							uint num4 = num3 - (uint)setting.a();
							num2 += (uint)(setting.BB() - (int)num4);
						}
						else
						{
							num2++;
						}
					}
					else
					{
						num2++;
					}
				}
			}
		}
		aWo += num;
		if (aWo >= bF)
		{
			aWo = 0u;
		}
	}

	internal bool A(ref int P_0)
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		P_0 = 0;
		F f = global::A.A.e(aXc);
		if (f == null)
		{
			return false;
		}
		aXJ.Restart();
		bool flag = false;
		while (aXJ.ElapsedMilliseconds <= 50)
		{
			for (int i = 0; i < aWt.Count; i++)
			{
				aWt[i].az();
			}
			int num = 0;
			int num2 = -1;
			int num3 = (int)global::A.A.A(aXc, global::A.f.aX);
			int bF = (int)f.@as[33].BF;
			for (int j = 0; j < bF; j++)
			{
				if (aWN[j] == by.aYj)
				{
					if (num2 == -1)
					{
						num2 = j;
					}
					num++;
					if (num >= num3)
					{
						num = num3;
						break;
					}
				}
				else if (num2 != -1)
				{
					if (num >= num3)
					{
						num = num3;
					}
					break;
				}
			}
			if (num2 != -1)
			{
				Stopwatch val = new Stopwatch();
				val.Start();
				flag = global::A.A.A(aXc, global::A.f.aX, (uint)num2, (uint)num, out var array, out var _);
				val.Stop();
				global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHY(), (object)val.ElapsedMilliseconds, (object)num), false);
				if (!flag)
				{
					continue;
				}
				P_0 += num;
				for (int k = 0; k < num; k++)
				{
					if (aWN[num2 + k] != by.aYK && aWN[num2 + k] != by.aYk)
					{
						aWm[num2 + k] = array[k];
						aWN[num2 + k] = by.aYJ;
					}
				}
				continue;
			}
			int num4 = bF;
			if (aWn > 0 && aWn < bF)
			{
				num4 = aWn;
			}
			for (int l = 0; l < num4; l++)
			{
				if (aWN[l] != by.aYK && aWN[l] != by.aYk)
				{
					aWN[l] = by.aYj;
				}
			}
			for (int m = 0; m < aWt.Count; m++)
			{
				aWt[m].i(false);
			}
			break;
		}
		if (flag && awZ == 21)
		{
			cb.A(false);
		}
		return true;
	}

	internal bool a(ref int P_0)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		P_0 = 0;
		F f = global::A.A.e(aXc);
		if (f == null)
		{
			return false;
		}
		bool result = false;
		aXJ.Restart();
		while (aXJ.ElapsedMilliseconds <= 50)
		{
			int num = 0;
			int num2 = -1;
			int num3 = (int)global::A.A.A(aXc, global::A.f.aY);
			int bF = (int)f.@as[35].BF;
			for (int i = 0; i < bF; i++)
			{
				if (aWk[i] == by.aYj)
				{
					if (num2 == -1)
					{
						num2 = i;
					}
					num++;
					if (num >= num3)
					{
						num = num3;
						break;
					}
				}
				else if (num2 != -1)
				{
					if (num >= num3)
					{
						num = num3;
					}
					break;
				}
			}
			if (num2 == -1)
			{
				break;
			}
			Stopwatch val = new Stopwatch();
			val.Start();
			result = true;
			byte[] array;
			bool flag;
			bool num4 = global::A.A.A(aXc, global::A.f.aY, (uint)num2, (uint)num, out array, out flag);
			val.Stop();
			global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHy(), (object)val.ElapsedMilliseconds, (object)num), false);
			if (!num4)
			{
				continue;
			}
			P_0 += num;
			Setting setting = null;
			bool flag2 = false;
			bool flag3 = false;
			for (int j = 0; j < num; j++)
			{
				Setting setting2 = B(num2 + j);
				if (setting2 != setting)
				{
					flag3 = flag2;
					flag2 = false;
				}
				if (aWk[num2 + j] != by.aYK && aWk[num2 + j] != by.aYk)
				{
					if (aWK[num2 + j] != array[j])
					{
						aWK[num2 + j] = array[j];
						flag2 = true;
					}
					aWk[num2 + j] = by.aYJ;
				}
				if (setting2 != setting)
				{
					setting?.i(flag3);
					setting2?.az();
					setting = setting2;
				}
				if (j == num - 1)
				{
					setting2?.i(flag2);
				}
			}
		}
		return result;
	}

	internal bool S()
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		F f = global::A.A.e(aXc);
		if (f == null)
		{
			return false;
		}
		bool result = false;
		int num = 0;
		int num2 = -1;
		int num3 = (int)global::A.A.a(aXc, global::A.f.aX);
		int bF = (int)f.@as[33].BF;
		byte[] array = new byte[num3];
		for (int i = 0; i < bF; i++)
		{
			if (aWN[i] == by.aYK)
			{
				if (num2 == -1)
				{
					num2 = i;
				}
				array[num] = aWm[i];
				num++;
				if (num >= num3)
				{
					num = num3;
					break;
				}
			}
			else if (num2 != -1)
			{
				if (num >= num3)
				{
					num = num3;
				}
				break;
			}
		}
		if (num2 != -1)
		{
			Stopwatch val = new Stopwatch();
			val.Start();
			byte[] array2 = new byte[num];
			System.Array.Copy((System.Array)array, (System.Array)array2, num);
			result = true;
			bool flag;
			bool num4 = global::A.A.A(aXc, global::A.f.aX, (uint)num2, array2, out flag);
			val.Stop();
			global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHZ(), (object)val.ElapsedMilliseconds, (object)num), false);
			if (num4)
			{
				for (int j = 0; j < num; j++)
				{
					aWN[num2 + j] = by.aYj;
				}
			}
		}
		return result;
	}

	internal bool B(ref int P_0)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		P_0 = 0;
		F f = global::A.A.e(aXc);
		if (f == null)
		{
			return false;
		}
		bool result = false;
		byte[] array = new byte[global::A.A.a(aXc, global::A.f.aY)];
		aXJ.Restart();
		while (aXJ.ElapsedMilliseconds <= 50)
		{
			int num = 0;
			int num2 = -1;
			int num3 = (int)global::A.A.a(aXc, global::A.f.aY);
			int bF = (int)f.@as[35].BF;
			for (int i = 0; i < bF; i++)
			{
				if (aWk[i] == by.aYK)
				{
					if (num2 == -1)
					{
						num2 = i;
					}
					aWk[i] = by.aYk;
					array[num] = aWK[i];
					num++;
					if (num >= num3)
					{
						num = num3;
						break;
					}
				}
				else if (num2 != -1)
				{
					if (num >= num3)
					{
						num = num3;
					}
					break;
				}
			}
			if (num2 == -1)
			{
				break;
			}
			Stopwatch val = new Stopwatch();
			val.Start();
			byte[] array2 = new byte[num];
			System.Array.Copy((System.Array)array, (System.Array)array2, num);
			result = true;
			bool flag;
			bool num4 = global::A.A.A(aXc, global::A.f.aY, (uint)num2, array2, out flag);
			val.Stop();
			global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aHz(), (object)val.ElapsedMilliseconds, (object)num), false);
			if (num4)
			{
				P_0 += num;
				List<int> val2 = new List<int>();
				for (int j = 0; j < num; j++)
				{
					if (aWk[num2 + j] != by.aYK)
					{
						aWk[num2 + j] = by.aYJ;
					}
					int num5 = (num2 + j) / 1024;
					if (!val2.Contains(num5))
					{
						val2.Add(num5);
					}
				}
				Enumerator<int> enumerator = val2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						int current = enumerator.Current;
						aWl[current]++;
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				continue;
			}
			for (int k = 0; k < num; k++)
			{
				if (aWk[num2 + k] == by.aYk)
				{
					aWk[num2 + k] = by.aYK;
				}
			}
		}
		return result;
	}

	internal void s()
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		if (awO == null)
		{
			return;
		}
		Setting knockSensorEnabler = awO.GetKnockSensorEnabler(0);
		if (knockSensorEnabler == null)
		{
			return;
		}
		Setting knockSensorEnabler2 = awO.GetKnockSensorEnabler(1);
		F f = global::A.A.e(aXc);
		if (f == null)
		{
			return;
		}
		uint num = global::A.A.A(aXc, global::A.f.aw);
		uint bF = f.@as[32].BF;
		uint num2 = bF - 2;
		if (num == 0 || bF == 0 || global::A.A.E(f.ao) == global::A.g.Bi)
		{
			return;
		}
		bool flag = knockSensorEnabler.ax() != 0;
		bool flag2 = knockSensorEnabler2 != null && knockSensorEnabler2.ax() != 0;
		if (flag || flag2)
		{
			uint num3 = ((flag && flag2) ? (2 + num2) : (2 + num2 / 2));
			Stopwatch val = new Stopwatch();
			val.Start();
			byte[] array;
			bool flag3;
			bool flag4 = global::A.A.A(aXc, global::A.f.aw, 0u, num3, out array, out flag3);
			val.Stop();
			if (flag3)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahA(), false);
			}
			else if (flag4)
			{
				aXn = (ushort)((uint)(array[0] << 8) | (array[1] & 0xFFu));
				string text = string.Empty;
				if (aXn != 1)
				{
					text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aha();
				}
				global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahB(), (object)val.ElapsedMilliseconds, (object)num3, (object)aXn) + text, false);
				uint num4 = num2 / 4;
				if (flag && flag2)
				{
					ushort[] array2 = new ushort[num4];
					for (int i = 0; i < num4; i++)
					{
						array2[i] = (ushort)((uint)(array[2 + i * 4] << 8) | (array[2 + i * 4 + 1] & 0xFFu));
					}
					aXm = array2;
					awO.CalculateFFT(0, aXm);
					ushort[] array3 = new ushort[num4];
					for (int j = 0; j < num4; j++)
					{
						array3[j] = (ushort)((uint)(array[2 + j * 4 + 2] << 8) | (array[2 + j * 4 + 3] & 0xFFu));
					}
					aXN = array3;
					awO.CalculateFFT(1, aXN);
				}
				else
				{
					ushort[] array4 = new ushort[num4];
					for (int k = 0; k < num4; k++)
					{
						array4[k] = (ushort)((uint)(array[2 + k * 2] << 8) | (array[2 + k * 2 + 1] & 0xFFu));
					}
					if (flag)
					{
						aXm = array4;
						awO.CalculateFFT(0, aXm);
					}
					else if (flag2)
					{
						aXN = array4;
						awO.CalculateFFT(1, aXN);
					}
				}
			}
			else
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahb(), false);
			}
		}
		if (!flag && aXm != null)
		{
			System.Array.Clear((System.Array)aXm, 0, aXm.Length);
		}
		if (!flag2 && aXN != null)
		{
			System.Array.Clear((System.Array)aXN, 0, aXN.Length);
		}
	}
}
