using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using NSP.UserInterface;
using ns0;
using ns1;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class Framework
{
	internal enum Enum90
	{
		BrB,
		Brb,
		BrC
	}

	private Class237 aWh;

	private string aWI;

	private byte[] aWi;

	private const uint aWJ = 1048576u;

	private const uint aWj = 32768u;

	private volatile byte[] aWK = new byte[1048576];

	private volatile Enum93[] aWk = new Enum93[1048576];

	private const int aWL = 1024;

	private volatile byte[] aWl = new byte[1024];

	private Stopwatch aWM = new Stopwatch();

	private volatile byte[] aWm = new byte[32768];

	private volatile Enum93[] aWN = new Enum93[32768];

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

	internal Dictionary<string, Class254> aWv = new Dictionary<string, Class254>();

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

	internal Dictionary<Enum104, List<Connector>> awb = new Dictionary<Enum104, List<Connector>>();

	internal Dictionary<Enum104, string> awC = new Dictionary<Enum104, string>();

	internal List<WiringPin> awc = new List<WiringPin>();

	internal List<SettingOrSpecialObject> awD = new List<SettingOrSpecialObject>();

	internal List<Class244> awd = new List<Class244>();

	internal List<SettingOrSpecialObject> awE = new List<SettingOrSpecialObject>();

	internal bool awe;

	internal Dictionary<int, Class256> awF = new Dictionary<int, Class256>();

	internal Dictionary<byte, Setting> awf = new Dictionary<byte, Setting>();

	internal Dictionary<byte, SettingOrSpecialObject> awG = new Dictionary<byte, SettingOrSpecialObject>();

	internal Dictionary<int, string> awg = new Dictionary<int, string>();

	internal Dictionary<int, List<Class270>> awH = new Dictionary<int, List<Class270>>();

	internal SettingOrSpecialObject awh;

	internal Class246 awI;

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

	internal Dictionary<string, Class258> awn = new Dictionary<string, Class258>();

	internal KnockDetection awO;

	internal Class275 awo;

	internal Class247 awP;

	internal Class249 awp;

	internal Class253 awQ;

	internal List<Class251> awq = new List<Class251>();

	internal MenuNode awR;

	internal MenuNode awr;

	internal MenuNode awS;

	internal Class255 aws;

	internal Class255 awT;

	internal Class255 awt;

	internal MenuNode awU;

	internal MenuNode awu;

	internal MenuNode awV;

	internal List<Setting> awv = new List<Setting>();

	internal Setting awW;

	internal Dictionary<Class1.Enum5, List<string>> aww = new Dictionary<Class1.Enum5, List<string>>();

	internal Dictionary<int, MenuNode> awX = new Dictionary<int, MenuNode>();

	internal Dictionary<string, DataTableObject> awx = new Dictionary<string, DataTableObject>();

	internal string awY;

	internal string awy;

	internal int awZ;

	internal int awz;

	internal Class14 aXA;

	internal string aXa;

	internal string aXB;

	internal string aXb;

	internal string aXC;

	internal string aXc = Class333.aHO();

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

	internal List<(byte pid, byte vid)> aXL = new List<(byte, byte)>();

	[CompilerGenerated]
	private EventHandler aXl;

	private bool aXM = true;

	internal ushort[] aXm;

	internal ushort[] aXN;

	internal ushort aXn = 1;

	internal Framework(string string_0, int int_0, int int_1, Class14 class14_0)
	{
		aWI = string_0;
		awZ = int_0;
		awz = int_1;
		aXA = class14_0;
		aXe = false;
		method_0();
		byte[] array = null;
		try
		{
			array = File.ReadAllBytes(aWI);
		}
		catch (Exception ex)
		{
			string text = Class333.aHo() + ex.Message;
			Class23.smethod_3(text);
			throw new Exception(text);
		}
		try
		{
			using MD5 mD = MD5.Create();
			aWi = mD.ComputeHash(array);
		}
		catch (Exception ex2)
		{
			string text2 = Class333.aHP() + ex2.Message;
			Class23.smethod_3(text2);
			throw new Exception(text2);
		}
		aWh = new Class237(this, string_0);
	}

	internal void method_0()
	{
		aWi = null;
		for (int i = 0; i < aWK.Length; i++)
		{
			aWK[i] = 0;
		}
		for (int j = 0; j < aWk.Length; j++)
		{
			aWk[j] = Enum93.aYJ;
		}
		for (int k = 0; k < aWm.Length; k++)
		{
			aWm[k] = 0;
		}
		for (int l = 0; l < aWN.Length; l++)
		{
			aWN[l] = Enum93.aYJ;
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
		method_6();
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

	internal Class237.Enum91 method_1()
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		Class237.Enum91 @enum = aWh.method_0();
		aXe = @enum == Class237.Enum91.Brc;
		stopwatch.Stop();
		if (aXe)
		{
			Class23.smethod_3(string.Format(Class333.aHp() + awZ + Class333.aHQ() + awz + Class333.smethod_1396() + aXA?.ToString() + Class333.aHq(), stopwatch.ElapsedMilliseconds));
			if (!aWX)
			{
				stopwatch.Restart();
				method_14();
				aWX = true;
				stopwatch.Stop();
				Class23.smethod_3(string.Format(Class333.aHR(), stopwatch.ElapsedMilliseconds));
			}
		}
		GC.Collect();
		return @enum;
	}

	[SpecialName]
	internal bool method_2()
	{
		return aXf;
	}

	[SpecialName]
	internal bool method_3()
	{
		return aXG;
	}

	[SpecialName]
	internal bool method_4()
	{
		return aXH;
	}

	[SpecialName]
	internal bool method_5()
	{
		return aXe;
	}

	internal void method_6()
	{
		for (int i = 0; i < aWl.Length; i++)
		{
			aWl[i] = 0;
		}
	}

	[SpecialName]
	internal byte[] method_7()
	{
		return aWl;
	}

	[SpecialName]
	internal void method_8(byte[] byte_0)
	{
		aWl = byte_0;
	}

	[SpecialName]
	internal bool method_9()
	{
		return aXF;
	}

	[SpecialName]
	internal string method_10()
	{
		return aWI;
	}

	[SpecialName]
	internal byte[] method_11()
	{
		return aWi;
	}

	internal bool method_12()
	{
		Stream stream = null;
		try
		{
			stream = Class35.smethod_7(aWI, Class19.smethod_2());
		}
		catch
		{
			return false;
		}
		bool flag;
		try
		{
			flag = Class31.smethod_7(stream);
		}
		catch (Exception)
		{
			flag = false;
		}
		method_13();
		if (!VirtualDashAppPanel.smethod_5())
		{
			stream.Close();
			return false;
		}
		string text = Form23.string_3 + Class333.smethod_355();
		Stream stream_ = null;
		if (flag)
		{
			try
			{
				if (!Class31.smethod_5(stream, Class333.smethod_356(), out stream_, null))
				{
					stream.Close();
					return false;
				}
				byte[] array = new byte[stream_.Length];
				if (!Class23.smethod_14(stream_, array, 0, array.Length))
				{
					throw new Exception(Class333.aHr());
				}
				File.WriteAllBytes(text + Class333.smethod_356(), array);
			}
			catch (Exception ex2)
			{
				Class23.smethod_3(Class333.aHS() + ex2.Message);
				stream_?.Close();
				stream.Close();
				return false;
			}
		}
		stream_?.Close();
		bool flag2 = false;
		if (flag)
		{
			List<string> list = null;
			try
			{
				list = Class31.smethod_8(stream, null);
				if (Directory.Exists(text + Class333.aHs()))
				{
					Directory.Delete(text + Class333.aHs(), recursive: true);
				}
			}
			catch (Exception ex3)
			{
				Class23.smethod_3(Class333.aHS() + ex3.Message);
				stream?.Close();
				return false;
			}
			foreach (string item in list)
			{
				if (!item.StartsWith(Class333.aHs()))
				{
					continue;
				}
				Stream stream_2 = null;
				try
				{
					if (!Class31.smethod_5(stream, item, out stream_2, null))
					{
						stream.Close();
						return false;
					}
					byte[] array2 = new byte[stream_2.Length];
					if (!Class23.smethod_14(stream_2, array2, 0, array2.Length))
					{
						throw new Exception(Class333.aHT());
					}
					Directory.CreateDirectory(Path.GetDirectoryName(text + item));
					File.WriteAllBytes(text + item, array2);
					flag2 = true;
				}
				catch (Exception ex4)
				{
					Class23.smethod_3(Class333.aHS() + ex4.Message);
					stream_2?.Close();
					stream.Close();
					return false;
				}
				stream_2?.Close();
			}
		}
		stream?.Close();
		if (flag2)
		{
			VirtualDashAppPanel.smethod_0();
			VirtualDashAppPanel.framework_0 = this;
			VirtualDashAppPanel.smethod_1();
		}
		return flag2;
	}

	private void method_13()
	{
		try
		{
			Directory.CreateDirectory(Form23.string_13);
			FileInfo[] files = new DirectoryInfo(Form23.string_13).GetFiles(Class333.aHt());
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					fileInfo.Delete();
				}
				catch (Exception ex)
				{
					Class23.smethod_3(Class333.aHU() + ex.Message);
				}
			}
		}
		catch (Exception ex2)
		{
			Class23.smethod_3(Class333.aHU() + ex2.Message);
		}
	}

	private void method_14()
	{
		Stream stream = Class35.smethod_7(aWI, Class19.smethod_2());
		bool flag;
		try
		{
			flag = Class31.smethod_7(stream);
		}
		catch (Exception)
		{
			flag = false;
		}
		Stream stream_ = null;
		if (flag)
		{
			if (!Class31.smethod_5(stream, Class333.aGW(), out stream_, null))
			{
				stream.Close();
				return;
			}
			Stream stream_2 = null;
			if (!Class31.smethod_5(stream_, Class333.aGw(), out stream_2, Class19.smethod_1()))
			{
				stream_.Close();
				return;
			}
			new Class296(stream_2, this).method_1(out var _, bool_0: true, bool_1: false, bool_2: false);
			stream_2.Close();
		}
		stream_?.Close();
		stream.Close();
	}

	internal void method_15(List<SettingOrSpecialObject> list_0)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = list_0[i];
			method_15(settingOrSpecialObject.method_1());
			if (settingOrSpecialObject is Setting)
			{
				(settingOrSpecialObject as Setting).method_246(bool_0: false);
			}
		}
	}

	internal void method_16()
	{
		method_17(aWS);
		foreach (Table item in aWV)
		{
			item.FindComponents();
		}
		if (awP != null)
		{
			awP.method_71();
		}
		if (awp != null)
		{
			awp.method_71();
		}
		foreach (Class251 item2 in awq)
		{
			item2.method_71();
		}
		if (awQ != null)
		{
			awQ.method_71();
		}
		foreach (SettingOrSpecialObject item3 in awD)
		{
			item3.method_12().method_0();
		}
		awo = new Class275(this);
		awo.method_0();
	}

	private void method_17(List<SettingOrSpecialObject> list_0)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = list_0[i];
			if (settingOrSpecialObject is Setting)
			{
				Setting setting = settingOrSpecialObject as Setting;
				if (setting is SensorCalibration)
				{
					(setting as SensorCalibration).FindComponents();
				}
				int num = awJ.IndexOf(setting.method_64());
				if (num != -1)
				{
					setting.method_99(awi[num]);
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
				if (settingOrSpecialObject is Class255)
				{
					(settingOrSpecialObject as Class255).method_77();
				}
			}
			method_17(settingOrSpecialObject.method_1());
		}
		if (list_0 != aWS)
		{
			return;
		}
		foreach (int item in awi)
		{
			method_31(item)?.method_166(bool_0: true);
		}
	}

	internal byte[] method_18()
	{
		MemoryStream memoryStream = new MemoryStream();
		method_19(memoryStream);
		method_20(memoryStream, aWS);
		memoryStream.Flush();
		byte[] result = memoryStream.ToArray();
		memoryStream.Close();
		return result;
	}

	private void method_19(MemoryStream memoryStream_0)
	{
		foreach (Setting item in aWu)
		{
			byte[] array = new byte[item.method_278()];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = item.method_254(i);
			}
			memoryStream_0.Write(array, 0, array.Length);
		}
	}

	private void method_20(MemoryStream memoryStream_0, List<SettingOrSpecialObject> list_0)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = list_0[i];
			method_20(memoryStream_0, settingOrSpecialObject.method_1());
			if (!(settingOrSpecialObject is Setting))
			{
				continue;
			}
			Setting setting = settingOrSpecialObject as Setting;
			if (setting.method_148().Length == 0 && setting.method_205())
			{
				byte[] array = new byte[setting.method_278()];
				for (int j = 0; j < array.Length; j++)
				{
					array[j] = setting.method_254(j);
				}
				memoryStream_0.Write(array, 0, array.Length);
			}
		}
	}

	public override string ToString()
	{
		return awy + string.Format(Class333.aHu(), aXA);
	}

	[SpecialName]
	internal byte[] method_21()
	{
		return aWK;
	}

	[SpecialName]
	internal Enum93[] method_22()
	{
		return aWk;
	}

	[SpecialName]
	internal byte[] method_23()
	{
		return aWm;
	}

	[SpecialName]
	internal Enum93[] method_24()
	{
		return aWN;
	}

	[SpecialName]
	internal List<Setting> method_25()
	{
		return aWO;
	}

	[SpecialName]
	internal List<Setting> method_26()
	{
		return aWP;
	}

	internal bool method_27(Enum88 enum88_0)
	{
		if (awG.ContainsKey((byte)enum88_0))
		{
			return awG[(byte)enum88_0].method_35();
		}
		if (awf.ContainsKey((byte)enum88_0))
		{
			return awf[(byte)enum88_0].method_256() != 0;
		}
		return false;
	}

	internal static bool smethod_0(string string_0)
	{
		if (!string.IsNullOrWhiteSpace(string_0) && string_0.Length >= 2 && string_0[0] != ' ' && string_0[0] != '\0' && !Class22.smethod_2(string_0))
		{
			return !string_0.Contains(Class333.smethod_100());
		}
		return false;
	}

	internal bool method_28(ref string string_0)
	{
		Setting setting = method_31(1501);
		if (setting != null)
		{
			string_0 = setting.method_260();
			if (aXF)
			{
				return setting.method_122();
			}
			return smethod_0(string_0);
		}
		string_0 = string.Empty;
		return false;
	}

	internal int method_29()
	{
		return 1 + awk + awK;
	}

	internal Image method_30(string string_0)
	{
		if (aXk != null && aXk.ImageItemList != null && aXk.ImageItemList.ContainsKey(string_0) && !string.IsNullOrEmpty(aXk.ImageItemList[string_0].ImageHexString))
		{
			byte[] array = Class24.smethod_1(aXk.ImageItemList[string_0].ImageHexString);
			if (array != null)
			{
				MemoryStream memoryStream = new MemoryStream(array);
				Image result = Image.FromStream(memoryStream);
				memoryStream.Close();
				return result;
			}
		}
		return null;
	}

	internal Setting method_31(int int_0)
	{
		return method_32(new DataIdAndAttrId(int_0));
	}

	internal Setting method_32(DataIdAndAttrId dataIdAndAttrId_0)
	{
		if (aWs.ContainsKey(dataIdAndAttrId_0))
		{
			return aWs[dataIdAndAttrId_0];
		}
		return null;
	}

	internal SettingOrSpecialObject method_33(int int_0)
	{
		if (aWT.ContainsKey(int_0))
		{
			return aWT[int_0];
		}
		return null;
	}

	internal Setting method_34(int int_0)
	{
		if (int_0 >= 0 && int_0 < aWp.Length)
		{
			DataIdAndAttrId dataIdAndAttrId_ = aWp[int_0];
			return method_32(dataIdAndAttrId_);
		}
		return null;
	}

	internal Setting method_35(int int_0)
	{
		if (int_0 >= 0 && int_0 < aWQ.Length)
		{
			return method_31(aWQ[int_0]);
		}
		return null;
	}

	private void method_36(List<MenuNode> list_0)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			MenuNode menuNode = list_0[i];
			if (menuNode.method_20() != -1)
			{
				SettingOrSpecialObject settingOrSpecialObject = method_33(menuNode.method_20());
				if (settingOrSpecialObject != null)
				{
					PortFunction.smethod_35(menuNode, settingOrSpecialObject);
				}
			}
			method_36(menuNode.method_6());
			menuNode.method_105();
		}
	}

	internal void method_37(List<MenuNode> list_0)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			MenuNode menuNode = list_0[i];
			method_37(menuNode.method_6());
			menuNode.method_81();
		}
	}

	internal bool method_38(HashSet<DataIdAndAttrId> hashSet_0)
	{
		bool result = false;
		if (hashSet_0 != null && hashSet_0.Count != 0)
		{
			HashSet<MenuNode> hashSet = new HashSet<MenuNode>();
			foreach (DataIdAndAttrId item in hashSet_0)
			{
				MenuNode menuNode = MenuNode.smethod_2(awj, item);
				Setting setting = method_32(item);
				if (setting == null || menuNode == null)
				{
					continue;
				}
				MenuNode menuNode2 = menuNode.method_83(setting);
				if (menuNode2 == null || hashSet.Contains(menuNode2))
				{
					continue;
				}
				hashSet.Add(menuNode2);
				bool flag = menuNode2.method_94();
				if (menuNode2.method_82())
				{
					menuNode2.method_85(bool_0: false);
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
		else
		{
			method_39(awj);
			result = true;
		}
		return result;
	}

	private void method_39(List<MenuNode> list_0)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			MenuNode menuNode = list_0[i];
			if (menuNode.method_79())
			{
				if (menuNode.method_82())
				{
					menuNode.method_85(bool_0: false);
				}
			}
			else
			{
				method_39(menuNode.method_6());
			}
		}
	}

	internal void method_40(HashSet<DataIdAndAttrId> hashSet_0, Framework framework_0, HashSet<DataIdAndAttrId> hashSet_1)
	{
		if (framework_0 == null)
		{
			return;
		}
		if (hashSet_0 != null && hashSet_0.Count != 0)
		{
			foreach (DataIdAndAttrId item in hashSet_0)
			{
				Setting setting = method_32(item);
				Setting setting2 = framework_0.method_32(item);
				if ((method_2() && method_3() && setting != null && setting.method_96()) || (framework_0.method_2() && framework_0.method_3() && setting2 != null && setting2.method_96()))
				{
					if (hashSet_1.Contains(item))
					{
						hashSet_1.Remove(item);
					}
				}
				else if (setting != null && setting2 != null && setting.method_282(setting2))
				{
					if (hashSet_1.Contains(item))
					{
						hashSet_1.Remove(item);
					}
				}
				else
				{
					hashSet_1.Add(item);
				}
			}
			return;
		}
		hashSet_1.Clear();
		method_41(aWS, framework_0, hashSet_1);
	}

	private void method_41(List<SettingOrSpecialObject> list_0, Framework framework_0, HashSet<DataIdAndAttrId> hashSet_0)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = list_0[i];
			if (settingOrSpecialObject is Setting)
			{
				Setting setting = settingOrSpecialObject as Setting;
				if (!setting.method_207())
				{
					Setting setting2 = framework_0.method_32(setting.method_69());
					if ((method_2() && method_3() && setting.method_96()) || (framework_0.method_2() && framework_0.method_3() && setting2 != null && setting2.method_96()))
					{
						if (hashSet_0.Contains(setting.method_69()))
						{
							hashSet_0.Remove(setting.method_69());
						}
					}
					else if (setting2 == null || !setting.method_282(setting2))
					{
						hashSet_0.Add(setting.method_69());
					}
				}
			}
			method_41(settingOrSpecialObject.method_1(), framework_0, hashSet_0);
		}
	}

	internal bool method_42(HashSet<DataIdAndAttrId> hashSet_0)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		if (awT != null)
		{
			awT.method_78(hashSet_0);
		}
		if (aws != null)
		{
			aws.method_78(hashSet_0);
		}
		if (awt != null)
		{
			awt.method_78(hashSet_0);
		}
		bool bool_ = false;
		method_46(aWS);
		method_44(aWS, hashSet_0, bool_0: false, ref bool_);
		method_44(aWS, hashSet_0, bool_0: true, ref bool_);
		Setting setting = null;
		if (awh != null && awh.method_13() != null)
		{
			setting = method_31(awh.method_13().DataIdOfChannelListSetting);
			setting?.method_268();
		}
		method_47(aWS);
		setting?.method_267(bool_0: true);
		aXF = true;
		method_45(hashSet_0);
		if (!Form23.bool_14)
		{
			Form23.menuNode_0.method_105();
		}
		method_36(awj);
		if (awl != null)
		{
			method_36(awl.method_6());
		}
		if (awm != null)
		{
			method_36(awm.method_6());
		}
		if (hashSet_0 != null)
		{
			method_43(hashSet_0, ref bool_);
		}
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.aHV(), stopwatch.ElapsedMilliseconds));
		return bool_;
	}

	private void method_43(HashSet<DataIdAndAttrId> hashSet_0, ref bool bool_0)
	{
		HashSet<DataIdAndAttrId> hashSet_1 = null;
		DataIdAndAttrId[] array = new DataIdAndAttrId[hashSet_0.Count];
		hashSet_0.CopyTo(array);
		DataIdAndAttrId[] array2 = array;
		foreach (DataIdAndAttrId dataIdAndAttrId_ in array2)
		{
			Setting setting = method_32(dataIdAndAttrId_);
			if (setting != null && setting.method_134().Count != 0)
			{
				PortFunction.smethod_21(setting, out hashSet_1);
			}
		}
		if (hashSet_1 != null && hashSet_1.Count != 0)
		{
			method_44(aWS, hashSet_1, bool_0: false, ref bool_0);
			method_44(aWS, hashSet_1, bool_0: true, ref bool_0);
		}
	}

	private void method_44(List<SettingOrSpecialObject> list_0, HashSet<DataIdAndAttrId> hashSet_0, bool bool_0, ref bool bool_1)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = list_0[i];
			if (settingOrSpecialObject.method_39(hashSet_0, bool_0))
			{
				bool_1 = true;
			}
			method_44(settingOrSpecialObject.method_1(), hashSet_0, bool_0, ref bool_1);
		}
	}

	private void method_45(HashSet<DataIdAndAttrId> hashSet_0)
	{
		if (hashSet_0 == null || hashSet_0.Count == 0)
		{
			return;
		}
		bool flag = false;
		foreach (Setting value in awf.Values)
		{
			if (hashSet_0.Contains(value.method_69()))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			foreach (SettingOrSpecialObject value2 in awG.Values)
			{
				foreach (DataIdAndAttrId item in hashSet_0)
				{
					if (item.AttrId == 0)
					{
						int dataId = item.DataId;
						if (value2.method_36().Contains(dataId))
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					break;
				}
			}
		}
		if (flag)
		{
			Form23.smethod_61();
		}
	}

	internal void method_46(List<SettingOrSpecialObject> list_0)
	{
		for (int num = list_0.Count - 1; num >= 0; num--)
		{
			SettingOrSpecialObject settingOrSpecialObject = list_0[num];
			settingOrSpecialObject.method_44();
			method_46(settingOrSpecialObject.method_1());
		}
	}

	internal void method_47(List<SettingOrSpecialObject> list_0)
	{
		for (int num = list_0.Count - 1; num >= 0; num--)
		{
			SettingOrSpecialObject settingOrSpecialObject = list_0[num];
			settingOrSpecialObject.method_43();
			method_47(settingOrSpecialObject.method_1());
		}
	}

	internal void method_48(List<SettingOrSpecialObject> list_0)
	{
		for (int num = list_0.Count - 1; num >= 0; num--)
		{
			SettingOrSpecialObject settingOrSpecialObject = list_0[num];
			if (settingOrSpecialObject is Setting)
			{
				(settingOrSpecialObject as Setting).method_268();
			}
			method_48(settingOrSpecialObject.method_1());
		}
	}

	internal void method_49(List<SettingOrSpecialObject> list_0)
	{
		for (int num = list_0.Count - 1; num >= 0; num--)
		{
			SettingOrSpecialObject settingOrSpecialObject = list_0[num];
			if (settingOrSpecialObject is Setting)
			{
				(settingOrSpecialObject as Setting).method_267(bool_0: true);
			}
			method_49(settingOrSpecialObject.method_1());
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_50(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = aXl;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref aXl, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_51(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = aXl;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref aXl, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal void method_52(Setting setting_0)
	{
		if (aXl != null)
		{
			aXl(setting_0, null);
		}
	}

	[SpecialName]
	internal bool method_53()
	{
		return aXM;
	}

	internal void method_54(bool bool_0, Setting setting_0 = null)
	{
		aXM = true;
		if (bool_0)
		{
			method_52(setting_0);
		}
	}

	internal void method_55()
	{
		aXM = false;
	}

	internal void method_56()
	{
		foreach (MenuNode item in awj)
		{
			item.method_99();
		}
	}

	internal bool method_57(out Setting setting_0, out Setting setting_1)
	{
		setting_0 = method_31(8);
		setting_1 = method_31(1503);
		if (setting_0 != null)
		{
			return setting_1 != null;
		}
		return false;
	}

	internal void method_58()
	{
		if (method_57(out var _, out var setting_2))
		{
			bool flag = false;
			for (int i = 0; i < setting_2.method_278(); i++)
			{
				if (setting_2.method_254(i) != 0)
				{
					flag = true;
					break;
				}
			}
			aXf = flag;
			aXG = aXf;
			Setting setting = method_31(9496);
			method_59(aWS);
			if (setting == null)
			{
				return;
			}
			int num = 0;
			for (int j = 0; j < setting.method_278(); j++)
			{
				byte b = setting.method_254(j);
				for (int k = 0; k < 8; k++)
				{
					Setting setting2 = method_31(num);
					num++;
					if (setting2 != null)
					{
						byte b2 = (byte)(128 >> k);
						bool bool_ = (b & b2) != 0;
						setting2.method_97(bool_);
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

	internal void method_59(List<SettingOrSpecialObject> list_0)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = list_0[i];
			if (settingOrSpecialObject is Setting)
			{
				(settingOrSpecialObject as Setting).method_97(bool_0: true);
			}
			method_59(settingOrSpecialObject.method_1());
		}
	}

	internal DialogResult method_60(bool bool_0, bool bool_1)
	{
		if (aXg)
		{
			return DialogResult.Ignore;
		}
		Form32 form = new Form32(this, bool_0, bool_1);
		DialogResult dialogResult = form.ShowDialog(Form23.form23_0);
		aXg = dialogResult == DialogResult.Ignore;
		if (dialogResult == DialogResult.OK)
		{
			aXG = false;
		}
		form.Dispose();
		return dialogResult;
	}

	internal static byte[] smethod_1(string string_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		StreamWriter streamWriter = new StreamWriter(memoryStream);
		streamWriter.Write(string_0);
		streamWriter.Flush();
		byte[] buffer = memoryStream.ToArray();
		MD5 mD = MD5.Create();
		byte[] result = mD.ComputeHash(buffer);
		mD.Dispose();
		streamWriter.Close();
		memoryStream.Close();
		return result;
	}

	internal bool method_61(Framework framework_0)
	{
		Setting setting = method_31(1503);
		Setting setting2 = framework_0.method_31(1503);
		if (setting != null && setting2 != null && setting.method_278() == setting2.method_278())
		{
			int num = 0;
			while (true)
			{
				if (num < setting.method_278())
				{
					if (setting.method_254(num) != setting2.method_254(num))
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	internal bool method_62(string string_0)
	{
		Setting setting = method_31(1503);
		if (setting != null)
		{
			byte[] array = smethod_1(string_0);
			for (int i = 0; i < setting.method_278(); i++)
			{
				if (setting.method_254(i) != array[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	internal void method_63(string string_0)
	{
		if (!method_57(out var setting_, out var setting_2))
		{
			return;
		}
		aXf = true;
		setting_.method_272(1, bool_0: true);
		byte[] array = smethod_1(string_0);
		for (int i = 0; i < setting_2.method_278(); i++)
		{
			setting_2.method_270(i, array[i], bool_0: true);
		}
		Setting setting = method_31(9496);
		if (setting == null)
		{
			return;
		}
		int num = 0;
		for (int j = 0; j < setting.method_278(); j++)
		{
			byte b = 0;
			for (int k = 0; k < 8; k++)
			{
				Setting setting2 = method_31(num);
				num++;
				if (setting2 != null)
				{
					byte b2 = (byte)(128 >> k);
					if (setting2.method_96())
					{
						b |= b2;
					}
				}
			}
			setting.method_270(j, b, bool_0: true);
		}
	}

	internal void method_64()
	{
		if (!method_57(out var setting_, out var setting_2))
		{
			return;
		}
		aXf = false;
		setting_.method_272(0, bool_0: true);
		for (int i = 0; i < setting_2.method_278(); i++)
		{
			setting_2.method_270(i, 0, bool_0: true);
		}
		Setting setting = method_31(9496);
		if (setting == null)
		{
			return;
		}
		int num = 0;
		for (int j = 0; j < setting.method_278(); j++)
		{
			for (int k = 0; k < 8; k++)
			{
				Setting setting2 = method_31(num);
				num++;
				setting2?.method_97(bool_0: false);
			}
			setting.method_270(j, 0, bool_0: true);
		}
	}

	internal void method_65(IWin32Window iwin32Window_0)
	{
		aXH = false;
		Setting setting = method_31(14691);
		if (setting != null)
		{
			if (setting.method_256() == 1 && Form13.smethod_0(setting, null))
			{
				aXH = true;
			}
			else
			{
				do
				{
					Form13 form = new Form13(setting.method_47(), setting, null);
					if (form.ShowDialog(iwin32Window_0) != DialogResult.OK)
					{
						aXH = false;
						if (method_66(iwin32Window_0))
						{
							break;
						}
					}
					else
					{
						setting.method_272(1, bool_0: true);
						aXH = true;
					}
					form.Dispose();
				}
				while (!aXH);
			}
		}
		else
		{
			aXH = true;
		}
		aXh = true;
	}

	private bool method_66(IWin32Window iwin32Window_0)
	{
		if (Form23.bool_14)
		{
			return false;
		}
		Setting setting = method_31(14691);
		if (setting != null)
		{
			string string_ = ((setting.method_256() == 1) ? Class333.aHW() : Class333.aHv());
			if (Form54.smethod_9(iwin32Window_0, string_, Class333.aHw(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, new string[2]
			{
				Class333.smethod_821(),
				Class333.aHX()
			}) == DialogResult.Cancel)
			{
				return false;
			}
		}
		return true;
	}

	internal void method_67()
	{
		if (aXH || !aXh)
		{
			return;
		}
		Setting setting = method_31(14691);
		Setting setting2 = method_31(1320);
		if (setting == null || setting2 == null)
		{
			return;
		}
		if (setting2.method_256() == 39)
		{
			bool flag = false;
			if (!aXI)
			{
				flag = true;
				aXI = true;
			}
			if (method_68())
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
			if (flag && !method_66(Form23.form23_0))
			{
				method_65(Form23.form23_0);
				Form23.smethod_11();
			}
		}
		else
		{
			aXI = false;
		}
	}

	internal bool method_68()
	{
		Setting setting = method_31(384);
		if (setting != null)
		{
			return setting.method_256() != 0;
		}
		return false;
	}

	internal void method_69(Framework framework_0, List<SettingOrSpecialObject> list_0, bool bool_0, bool bool_1, bool bool_2 = false)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = list_0[i];
			if (settingOrSpecialObject is Setting)
			{
				Setting setting = settingOrSpecialObject as Setting;
				if (!setting.method_207() && (bool_0 || !setting.method_72()))
				{
					setting.method_113(framework_0, bool_1, bool_2);
				}
			}
			method_69(framework_0, settingOrSpecialObject.method_1(), bool_0, bool_1, bool_2);
		}
	}

	internal void method_70(Framework framework_0, bool bool_0)
	{
		if (!BezierCurve.ETCBezierToTableRedundancyIsOK(framework_0, this))
		{
			Setting setting = method_31(14206);
			if (setting != null && setting.method_6() != null && setting.method_6() is Table)
			{
				(setting.method_6() as Table).method_246(bool_0);
			}
		}
	}

	internal void method_71(long long_0)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		lock (this)
		{
			if (!aWM.IsRunning)
			{
				aWM.Start();
			}
			if (aWM.ElapsedMilliseconds >= long_0)
			{
				Class5 @class = Class1.smethod_26(aXc);
				if (@class != null)
				{
					uint uint_ = @class.struct1_0[38].uint_1;
					if (uint_ != 0 && Class1.smethod_37(aXc, Enum10.const_10, 0u, uint_, out var byte_, out var _))
					{
						for (int i = 0; i < uint_; i++)
						{
							if (byte_[i] == aWl[i])
							{
								continue;
							}
							for (int j = 0; j < 1024; j++)
							{
								int num = 1024 * i + j;
								if (aWk[num] != Enum93.aYK && aWk[num] != Enum93.aYk)
								{
									aWk[num] = Enum93.aYj;
								}
							}
							aWl[i] = byte_[i];
						}
					}
				}
				aWM.Restart();
			}
		}
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.aHx(), stopwatch.ElapsedMilliseconds), bool_1: false);
	}

	internal void method_72()
	{
		Class5 @class = Class1.smethod_26(aXc);
		if (@class != null)
		{
			uint uint_ = @class.struct1_0[35].uint_1;
			for (uint num = 0u; num < uint_; num++)
			{
				aWk[num] = Enum93.aYj;
			}
		}
	}

	internal void method_73()
	{
		Class5 @class = Class1.smethod_26(aXc);
		if (@class != null)
		{
			uint uint_ = @class.struct1_0[35].uint_1;
			for (uint num = 0u; num < uint_; num++)
			{
				aWk[num] = Enum93.aYK;
			}
		}
	}

	internal void method_74()
	{
		for (int i = 0; i < aWk.Length; i++)
		{
			aWk[i] = Enum93.aYJ;
		}
	}

	internal bool method_75()
	{
		Class5 @class = Class1.smethod_26(aXc);
		if (@class != null)
		{
			uint uint_ = @class.struct1_0[35].uint_1;
			for (uint num = 0u; num < uint_; num++)
			{
				if (aWk[num] == Enum93.aYK || aWk[num] == Enum93.aYk)
				{
					return true;
				}
			}
		}
		return false;
	}

	internal bool method_76()
	{
		Class5 @class = Class1.smethod_26(aXc);
		if (@class != null)
		{
			uint uint_ = @class.struct1_0[33].uint_1;
			for (uint num = 0u; num < uint_; num++)
			{
				aWN[num] = Enum93.aYj;
			}
		}
		return true;
	}

	internal void method_77()
	{
		if (!aWq)
		{
			return;
		}
		Class5 @class = Class1.smethod_26(aXc);
		if (@class == null)
		{
			return;
		}
		uint uint_ = @class.struct1_0[35].uint_1;
		uint num = Class1.smethod_73(aXc, Enum10.const_7);
		if (aWo + num > uint_)
		{
			num = uint_ - aWo;
		}
		if (Class1.smethod_37(aXc, Enum10.const_7, aWo, num, out var byte_, out var _))
		{
			lock (method_25())
			{
				uint num2 = 0u;
				while (num2 < num)
				{
					uint num3 = aWo + num2;
					if (aWk[num3] == Enum93.aYJ && aWK[num3] != byte_[num2])
					{
						Setting setting = method_34((int)num3);
						if (setting != null && setting.method_205() && !setting.method_207() && !setting.method_219() && !setting.method_212() && !setting.method_220())
						{
							if (!setting.method_86() && !method_25().Contains(setting))
							{
								method_25().Add(setting);
							}
							uint num4 = num3 - (uint)setting.method_65();
							num2 += (uint)(setting.method_278() - (int)num4);
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
		if (aWo >= uint_)
		{
			aWo = 0u;
		}
	}

	internal bool method_78(ref int int_0)
	{
		int_0 = 0;
		Class5 @class = Class1.smethod_26(aXc);
		if (@class == null)
		{
			return false;
		}
		aXJ.Restart();
		bool flag = false;
		while (aXJ.ElapsedMilliseconds <= 50L)
		{
			for (int i = 0; i < aWt.Count; i++)
			{
				aWt[i].method_268();
			}
			int num = 0;
			int num2 = -1;
			int num3 = (int)Class1.smethod_73(aXc, Enum10.const_5);
			int uint_ = (int)@class.struct1_0[33].uint_1;
			for (int j = 0; j < uint_; j++)
			{
				if (aWN[j] == Enum93.aYj)
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
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				flag = Class1.smethod_37(aXc, Enum10.const_5, (uint)num2, (uint)num, out var byte_, out var _);
				stopwatch.Stop();
				Class23.smethod_3(string.Format(Class333.aHY(), stopwatch.ElapsedMilliseconds, num), bool_1: false);
				if (!flag)
				{
					continue;
				}
				int_0 += num;
				for (int k = 0; k < num; k++)
				{
					if (aWN[num2 + k] != Enum93.aYK && aWN[num2 + k] != Enum93.aYk)
					{
						aWm[num2 + k] = byte_[k];
						aWN[num2 + k] = Enum93.aYJ;
					}
				}
				continue;
			}
			int num4 = uint_;
			if (aWn > 0 && aWn < uint_)
			{
				num4 = aWn;
			}
			for (int l = 0; l < num4; l++)
			{
				if (aWN[l] != Enum93.aYK && aWN[l] != Enum93.aYk)
				{
					aWN[l] = Enum93.aYj;
				}
			}
			for (int m = 0; m < aWt.Count; m++)
			{
				aWt[m].method_267(bool_0: false);
			}
			break;
		}
		if (flag && awZ == 21)
		{
			Class329.smethod_6();
		}
		return true;
	}

	internal bool method_79(ref int int_0)
	{
		int_0 = 0;
		Class5 @class = Class1.smethod_26(aXc);
		if (@class == null)
		{
			return false;
		}
		bool result = false;
		aXJ.Restart();
		while (aXJ.ElapsedMilliseconds <= 50L)
		{
			int num = 0;
			int num2 = -1;
			int num3 = (int)Class1.smethod_73(aXc, Enum10.const_7);
			int uint_ = (int)@class.struct1_0[35].uint_1;
			for (int i = 0; i < uint_; i++)
			{
				if (aWk[i] == Enum93.aYj)
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
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			result = true;
			bool flag = Class1.smethod_37(aXc, Enum10.const_7, (uint)num2, (uint)num, out var byte_, out var _);
			stopwatch.Stop();
			Class23.smethod_3(string.Format(Class333.aHy(), stopwatch.ElapsedMilliseconds, num), bool_1: false);
			if (!flag)
			{
				continue;
			}
			int_0 += num;
			Setting setting = null;
			bool flag2 = false;
			bool bool_2 = false;
			for (int j = 0; j < num; j++)
			{
				Setting setting2 = method_34(num2 + j);
				if (setting2 != setting)
				{
					bool_2 = flag2;
					flag2 = false;
				}
				if (aWk[num2 + j] != Enum93.aYK && aWk[num2 + j] != Enum93.aYk)
				{
					if (aWK[num2 + j] != byte_[j])
					{
						aWK[num2 + j] = byte_[j];
						flag2 = true;
					}
					aWk[num2 + j] = Enum93.aYJ;
				}
				if (setting2 != setting)
				{
					setting?.method_267(bool_2);
					setting2?.method_268();
					setting = setting2;
				}
				if (j == num - 1)
				{
					setting2?.method_267(flag2);
				}
			}
		}
		return result;
	}

	internal bool method_80()
	{
		Class5 @class = Class1.smethod_26(aXc);
		if (@class == null)
		{
			return false;
		}
		bool result = false;
		int num = 0;
		int num2 = -1;
		int num3 = (int)Class1.smethod_74(aXc, Enum10.const_5);
		int uint_ = (int)@class.struct1_0[33].uint_1;
		byte[] array = new byte[num3];
		for (int i = 0; i < uint_; i++)
		{
			if (aWN[i] == Enum93.aYK)
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
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			byte[] array2 = new byte[num];
			Array.Copy(array, array2, num);
			result = true;
			bool flag = Class1.smethod_39(aXc, Enum10.const_5, (uint)num2, array2, out var _);
			stopwatch.Stop();
			Class23.smethod_3(string.Format(Class333.aHZ(), stopwatch.ElapsedMilliseconds, num), bool_1: false);
			if (flag)
			{
				for (int j = 0; j < num; j++)
				{
					aWN[num2 + j] = Enum93.aYj;
				}
			}
		}
		return result;
	}

	internal bool method_81(ref int int_0)
	{
		int_0 = 0;
		Class5 @class = Class1.smethod_26(aXc);
		if (@class == null)
		{
			return false;
		}
		bool result = false;
		byte[] array = new byte[Class1.smethod_74(aXc, Enum10.const_7)];
		aXJ.Restart();
		while (aXJ.ElapsedMilliseconds <= 50L)
		{
			int num = 0;
			int num2 = -1;
			int num3 = (int)Class1.smethod_74(aXc, Enum10.const_7);
			int uint_ = (int)@class.struct1_0[35].uint_1;
			for (int i = 0; i < uint_; i++)
			{
				if (aWk[i] == Enum93.aYK)
				{
					if (num2 == -1)
					{
						num2 = i;
					}
					aWk[i] = Enum93.aYk;
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
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			byte[] array2 = new byte[num];
			Array.Copy(array, array2, num);
			result = true;
			bool flag = Class1.smethod_39(aXc, Enum10.const_7, (uint)num2, array2, out var _);
			stopwatch.Stop();
			Class23.smethod_3(string.Format(Class333.aHz(), stopwatch.ElapsedMilliseconds, num), bool_1: false);
			if (flag)
			{
				int_0 += num;
				List<int> list = new List<int>();
				for (int j = 0; j < num; j++)
				{
					if (aWk[num2 + j] != Enum93.aYK)
					{
						aWk[num2 + j] = Enum93.aYJ;
					}
					int item = (num2 + j) / 1024;
					if (!list.Contains(item))
					{
						list.Add(item);
					}
				}
				foreach (int item2 in list)
				{
					aWl[item2]++;
				}
				continue;
			}
			for (int k = 0; k < num; k++)
			{
				if (aWk[num2 + k] == Enum93.aYk)
				{
					aWk[num2 + k] = Enum93.aYK;
				}
			}
		}
		return result;
	}

	internal void method_82()
	{
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
		Class5 @class = Class1.smethod_26(aXc);
		if (@class == null)
		{
			return;
		}
		uint num = Class1.smethod_73(aXc, Enum10.const_4);
		uint uint_ = @class.struct1_0[32].uint_1;
		uint num2 = uint_ - 2;
		if (num == 0 || uint_ == 0 || Class1.smethod_25(@class.string_0) == Enum11.const_1)
		{
			return;
		}
		bool flag = knockSensorEnabler.method_256() != 0;
		bool flag2 = knockSensorEnabler2 != null && knockSensorEnabler2.method_256() != 0;
		if (flag | flag2)
		{
			uint num3 = ((flag & flag2) ? (2 + num2) : (2 + num2 / 2));
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			bool flag3 = Class1.smethod_37(aXc, Enum10.const_4, 0u, num3, out var byte_, out var bool_);
			stopwatch.Stop();
			if (bool_)
			{
				Class23.smethod_3(Class333.ahA(), bool_1: false);
			}
			else if (flag3)
			{
				aXn = (ushort)((byte_[0] << 8) | (byte_[1] & 0xFF));
				string text = string.Empty;
				if (aXn != 1)
				{
					text = Class333.aha();
				}
				Class23.smethod_3(string.Format(Class333.ahB(), stopwatch.ElapsedMilliseconds, num3, aXn) + text, bool_1: false);
				uint num4 = num2 / 4;
				if (flag & flag2)
				{
					ushort[] array = new ushort[num4];
					for (int i = 0; i < num4; i++)
					{
						array[i] = (ushort)((byte_[2 + i * 4] << 8) | (byte_[2 + i * 4 + 1] & 0xFF));
					}
					aXm = array;
					awO.CalculateFFT(0, aXm);
					ushort[] array2 = new ushort[num4];
					for (int j = 0; j < num4; j++)
					{
						array2[j] = (ushort)((byte_[2 + j * 4 + 2] << 8) | (byte_[2 + j * 4 + 3] & 0xFF));
					}
					aXN = array2;
					awO.CalculateFFT(1, aXN);
				}
				else
				{
					ushort[] array3 = new ushort[num4];
					for (int k = 0; k < num4; k++)
					{
						array3[k] = (ushort)((byte_[2 + k * 2] << 8) | (byte_[2 + k * 2 + 1] & 0xFF));
					}
					if (flag)
					{
						aXm = array3;
						awO.CalculateFFT(0, aXm);
					}
					else if (flag2)
					{
						aXN = array3;
						awO.CalculateFFT(1, aXN);
					}
				}
			}
			else
			{
				Class23.smethod_3(Class333.ahb(), bool_1: false);
			}
		}
		if (!flag && aXm != null)
		{
			Array.Clear(aXm, 0, aXm.Length);
		}
		if (!flag2 && aXN != null)
		{
			Array.Clear(aXN, 0, aXN.Length);
		}
	}
}
