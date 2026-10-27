using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using b;

namespace NSP.SettingsFramework;

public class InitialTaskObject
{
	private string azV;

	private string azv;

	private string azW;

	private string azw;

	private List<int> azX = new List<int>();

	private List<string> azx = new List<string>();

	private CE azY = CE.azP;

	private int azy = -1;

	private Ce azZ = Ce.azR;

	private bool azz = true;

	private bool BAA;

	private Framework BAa;

	internal InitialTaskObject(Framework P_0)
	{
		BAa = P_0;
	}

	[SpecialName]
	internal string A()
	{
		return azV;
	}

	[SpecialName]
	internal void A(string P_0)
	{
		azV = P_0;
	}

	[SpecialName]
	internal void a(string P_0)
	{
		azv = P_0;
	}

	[SpecialName]
	internal void B(string P_0)
	{
		azW = P_0;
	}

	[SpecialName]
	internal void b(string P_0)
	{
		azw = P_0;
	}

	internal void A(int P_0, string P_1)
	{
		azX.Add(P_0);
		azx.Add(P_1);
	}

	[SpecialName]
	internal CE a()
	{
		return azY;
	}

	[SpecialName]
	internal void A(CE P_0)
	{
		azY = P_0;
	}

	[SpecialName]
	internal void A(int P_0)
	{
		azy = P_0;
	}

	[SpecialName]
	internal void A(Ce P_0)
	{
		azZ = P_0;
	}

	[SpecialName]
	internal bool B()
	{
		return azz;
	}

	[SpecialName]
	internal void A(bool P_0)
	{
		azz = P_0;
	}

	[SpecialName]
	internal bool b()
	{
		return BAA;
	}

	[SpecialName]
	internal void a(bool P_0)
	{
		BAA = P_0;
	}

	internal bool C()
	{
		if (azy != -1)
		{
			SettingOrSpecialObject settingOrSpecialObject = BAa.a(azy);
			if (settingOrSpecialObject != null && settingOrSpecialObject.K().a())
			{
				return true;
			}
		}
		if (azY == CE.azQ)
		{
			for (int i = 0; i < azx.Count; i++)
			{
				if (!(azx[i] != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSb()))
				{
					continue;
				}
				if (azx[i] == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSC())
				{
					Setting setting = BAa.A(azX[i]);
					if (setting != null && BAa.B() && BAa.b() && setting.J())
					{
						return true;
					}
				}
				else if (azx[i].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSc()))
				{
					Setting setting2 = BAa.A(azX[i]);
					if (setting2 != null && BAa.B() && BAa.b() && setting2.J())
					{
						return true;
					}
				}
				else if (azx[i] == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSD())
				{
					SettingOrSpecialObject settingOrSpecialObject2 = BAa.a(azX[i]);
					if (settingOrSpecialObject2 is Table && BAa.B() && BAa.b() && (settingOrSpecialObject2 as Table).J())
					{
						return true;
					}
				}
				else if (azx[i].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSd()))
				{
					SettingOrSpecialObject settingOrSpecialObject3 = BAa.a(azX[i]);
					if (settingOrSpecialObject3 is Table && BAa.B() && BAa.b() && (settingOrSpecialObject3 as Table).J())
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	internal Cf c()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		string text = azw;
		if (text != null)
		{
			T.A(ref text, BAa);
		}
		if (text != null && !T.A(ref text))
		{
			if (!string.IsNullOrEmpty(azW))
			{
				bE.A((IWin32Window)(object)BM.QQ, azW, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			return Cf.azU;
		}
		if (azv != null && (int)bE.A((IWin32Window)(object)BM.QQ, azv, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) != 6)
		{
			return Cf.azt;
		}
		if (azZ == Ce.azq && BM.A(BAa.aXc, true))
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSE(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return Cf.azu;
		}
		if (azZ == Ce.azr && !BM.A(BAa.aXc, true))
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSe(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return Cf.azu;
		}
		switch (azY)
		{
		case CE.azQ:
		{
			Table table = null;
			List<Table> val = new List<Table>();
			Setting setting = null;
			List<Setting> val2 = new List<Setting>();
			CF cF = CF.azS;
			for (int i = 0; i < azx.Count; i++)
			{
				if (azx[i] == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSb())
				{
					cF = (CF)azX[i];
				}
				else if (azx[i] == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSC())
				{
					setting = BAa.A(azX[i]);
				}
				else if (azx[i].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSc()))
				{
					Setting setting2 = BAa.A(azX[i]);
					if (setting2 != null && ((SettingOrSpecialObject)setting2).l())
					{
						val2.Add(setting2);
					}
				}
				else if (azx[i] == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSD())
				{
					SettingOrSpecialObject settingOrSpecialObject = BAa.a(azX[i]);
					if (settingOrSpecialObject != null && settingOrSpecialObject is Table)
					{
						table = settingOrSpecialObject as Table;
					}
				}
				else if (azx[i].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSd()))
				{
					SettingOrSpecialObject settingOrSpecialObject2 = BAa.a(azX[i]);
					if (settingOrSpecialObject2 != null && settingOrSpecialObject2.l() && settingOrSpecialObject2 is Table)
					{
						val.Add(settingOrSpecialObject2 as Table);
					}
				}
			}
			if (setting != null && val2.Count != 0)
			{
				if (!A(setting, val2, cF))
				{
					return Cf.azt;
				}
				break;
			}
			if (table != null && val.Count != 0)
			{
				if (!A(table, val, cF))
				{
					return Cf.azt;
				}
				break;
			}
			return Cf.azt;
		}
		}
		if (azy != -1)
		{
			SettingOrSpecialObject settingOrSpecialObject3 = BAa.a(azy);
			if (settingOrSpecialObject3 != null && settingOrSpecialObject3.K().A().Count != 0)
			{
				settingOrSpecialObject3.K().B();
			}
		}
		return Cf.azT;
	}

	internal static bool A(Setting P_0, List<Setting> P_1, CF P_2)
	{
		if (P_0 == null || P_1.Count == 0)
		{
			return false;
		}
		Ck ck = BM.aM();
		ck?.a();
		double num = 0.0;
		for (int i = 0; i < P_1.Count; i++)
		{
			double num2 = P_1[i].ax();
			switch (P_2)
			{
			case CF.azS:
				num += num2 / (double)P_1.Count;
				break;
			case CF.azs:
				num = ((i != 0) ? Math.Max(num2, num) : num2);
				break;
			}
		}
		double num3 = P_0.ax();
		int num4 = 0;
		switch (P_2)
		{
		case CF.azS:
			num4 = (int)Math.Round(num3 + num3 * (num / 1000.0), 0);
			break;
		case CF.azs:
			num4 = (int)Math.Round(num3 + num, 0);
			break;
		}
		int num5 = P_0.aR();
		int num6 = P_0.ar();
		if (num5 != 0 || num6 != 0)
		{
			num4 = Math.Min(Math.Max(num4, num5), num6);
		}
		P_0.a(num4, true);
		BM.b(P_0.A());
		for (int j = 0; j < P_1.Count; j++)
		{
			Setting setting = P_1[j];
			double num7 = setting.ax();
			setting.a((int)(num7 - num), true);
			BM.b(P_1[j].A());
		}
		ck?.B();
		return true;
	}

	internal static bool A(Table P_0, List<Table> P_1, CF P_2)
	{
		if (P_0 == null || P_1.Count == 0)
		{
			return false;
		}
		Ck ck = BM.aM();
		ck?.a();
		double[,,] array = new double[P_1[0].SliceCount(), P_1[0].RowCount(), P_1[0].ColumnCount()];
		int[] array2 = null;
		if (P_0.ColumnsEnabled())
		{
			array2 = new int[P_1[0].ColumnCount()];
		}
		int[] array3 = null;
		if (P_0.RowsEnabled())
		{
			array3 = new int[P_1[0].RowCount()];
		}
		int[] array4 = null;
		if (P_0.SlicesEnabled())
		{
			array4 = new int[P_1[0].SliceCount()];
		}
		for (int i = 0; i < P_1.Count; i++)
		{
			Setting tableDataSetting = P_1[i].TableDataSetting;
			for (int j = 0; j < P_1[0].ColumnCount(); j++)
			{
				if (i == 0 && array2 != null)
				{
					array2[j] = P_1[0].ColumnAxis.G().m(j);
				}
				for (int k = 0; k < P_1[0].RowCount(); k++)
				{
					if (i == 0 && array3 != null)
					{
						array3[k] = P_1[0].RowAxis.G().m(k);
					}
					for (int l = 0; l < P_1[0].SliceCount(); l++)
					{
						if (i == 0 && array4 != null)
						{
							array4[l] = P_1[0].SliceAxis.G().m(l);
						}
						double num = tableDataSetting.B(j, k, l);
						switch (P_2)
						{
						case CF.azS:
							array[l, k, j] += num / (double)P_1.Count;
							break;
						case CF.azs:
							if (i == 0)
							{
								array[l, k, j] = num;
							}
							else
							{
								array[l, k, j] = Math.Max(num, array[l, k, j]);
							}
							break;
						}
					}
				}
			}
		}
		P_0.TableDataSetting.az();
		bool flag = (P_0.ColumnsEnabled() && P_0.ColumnAxis.I() != AxisBehaviour.Continuous) || (P_1[0].ColumnsEnabled() && P_1[0].ColumnAxis.I() != AxisBehaviour.Continuous);
		bool flag2 = (P_0.RowsEnabled() && P_0.RowAxis.I() != AxisBehaviour.Continuous) || (P_1[0].RowsEnabled() && P_1[0].RowAxis.I() != AxisBehaviour.Continuous);
		bool flag3 = (P_0.SlicesEnabled() && P_0.SliceAxis.I() != AxisBehaviour.Continuous) || (P_1[0].SlicesEnabled() && P_1[0].SliceAxis.I() != AxisBehaviour.Continuous);
		for (int m = 0; m < P_0.ColumnCount(); m++)
		{
			int num2 = 0;
			if (P_0.ColumnsEnabled())
			{
				num2 = P_0.ColumnAxis.G().m(m);
				if (flag && P_1[0].ColumnAxis.C(num2) == -1)
				{
					continue;
				}
			}
			for (int n = 0; n < P_0.RowCount(); n++)
			{
				int num3 = 0;
				if (P_0.RowsEnabled())
				{
					num3 = P_0.RowAxis.G().m(n);
					if (flag2 && P_1[0].RowAxis.C(num3) == -1)
					{
						continue;
					}
				}
				for (int num4 = 0; num4 < P_0.SliceCount(); num4++)
				{
					int num5 = 0;
					if (P_0.SlicesEnabled())
					{
						num5 = P_0.SliceAxis.G().m(num4);
						if (flag3 && P_1[0].SliceAxis.C(num5) == -1)
						{
							continue;
						}
					}
					double interpolatedValue = Table.GetInterpolatedValue(array, array2, array3, array4, num2, num3, num5);
					double num6 = P_0.TableDataSetting.B(m, n, num4);
					int num7 = 0;
					switch (P_2)
					{
					case CF.azS:
						num7 = (int)Math.Round(num6 + num6 * (interpolatedValue / 1000.0), 0);
						break;
					case CF.azs:
						num7 = (int)Math.Round(num6 + interpolatedValue, 0);
						break;
					}
					int num8 = P_0.aR();
					int num9 = P_0.ar();
					if (num8 != 0 || num9 != 0)
					{
						num7 = Math.Min(Math.Max(num7, num8), num9);
					}
					P_0.TableDataSetting.A(m, n, num4, num7, true);
				}
			}
		}
		P_0.TableDataSetting.i(true);
		BM.b(P_0.TableDataSetting.A());
		for (int num10 = 0; num10 < P_1.Count; num10++)
		{
			P_1[num10].TableDataSetting.az();
		}
		for (int num11 = 0; num11 < P_1[0].TableDataSetting.av()[2]; num11++)
		{
			for (int num12 = 0; num12 < P_1[0].TableDataSetting.av()[1]; num12++)
			{
				for (int num13 = 0; num13 < P_1[0].TableDataSetting.av()[0]; num13++)
				{
					for (int num14 = 0; num14 < P_1.Count; num14++)
					{
						Setting tableDataSetting2 = P_1[num14].TableDataSetting;
						double num15 = tableDataSetting2.B(num11, num12, num13);
						double num16 = ((num11 >= P_1[0].ColumnCount() || num12 >= P_1[0].RowCount() || num13 >= P_1[0].SliceCount()) ? num15 : array[num13, num12, num11]);
						tableDataSetting2.A(num11, num12, num13, (int)(num15 - num16), true);
					}
				}
			}
		}
		for (int num17 = 0; num17 < P_1.Count; num17++)
		{
			P_1[num17].TableDataSetting.i(true);
			BM.b(P_1[num17].TableDataSetting.A());
		}
		ck?.B();
		return true;
	}
}
