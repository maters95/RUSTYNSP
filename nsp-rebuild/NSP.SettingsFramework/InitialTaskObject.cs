using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns0;
using ns4;
using ns5;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class InitialTaskObject
{
	private string azV;

	private string azv;

	private string azW;

	private string azw;

	private List<int> azX = new List<int>();

	private List<string> azx = new List<string>();

	private Enum100 azY = Enum100.azP;

	private int azy = -1;

	private Enum101 azZ = Enum101.azR;

	private bool azz = true;

	private bool BAA;

	private Framework BAa;

	internal InitialTaskObject(Framework framework_0)
	{
		BAa = framework_0;
	}

	[SpecialName]
	internal string method_0()
	{
		return azV;
	}

	[SpecialName]
	internal void method_1(string string_0)
	{
		azV = string_0;
	}

	[SpecialName]
	internal void method_2(string string_0)
	{
		azv = string_0;
	}

	[SpecialName]
	internal void method_3(string string_0)
	{
		azW = string_0;
	}

	[SpecialName]
	internal void method_4(string string_0)
	{
		azw = string_0;
	}

	internal void method_5(int int_0, string string_0)
	{
		azX.Add(int_0);
		azx.Add(string_0);
	}

	[SpecialName]
	internal Enum100 method_6()
	{
		return azY;
	}

	[SpecialName]
	internal void method_7(Enum100 enum100_0)
	{
		azY = enum100_0;
	}

	[SpecialName]
	internal void method_8(int int_0)
	{
		azy = int_0;
	}

	[SpecialName]
	internal void method_9(Enum101 enum101_0)
	{
		azZ = enum101_0;
	}

	[SpecialName]
	internal bool method_10()
	{
		return azz;
	}

	[SpecialName]
	internal void method_11(bool bool_0)
	{
		azz = bool_0;
	}

	[SpecialName]
	internal bool method_12()
	{
		return BAA;
	}

	[SpecialName]
	internal void method_13(bool bool_0)
	{
		BAA = bool_0;
	}

	internal bool method_14()
	{
		if (azy != -1)
		{
			SettingOrSpecialObject settingOrSpecialObject = BAa.method_33(azy);
			if (settingOrSpecialObject != null && settingOrSpecialObject.method_26().method_5())
			{
				return true;
			}
		}
		if (azY == Enum100.azQ)
		{
			for (int i = 0; i < azx.Count; i++)
			{
				if (!(azx[i] != Class333.aSb()))
				{
					continue;
				}
				if (azx[i] == Class333.aSC())
				{
					Setting setting = BAa.method_31(azX[i]);
					if (setting != null && BAa.method_2() && BAa.method_3() && setting.method_96())
					{
						return true;
					}
				}
				else if (azx[i].Contains(Class333.aSc()))
				{
					Setting setting2 = BAa.method_31(azX[i]);
					if (setting2 != null && BAa.method_2() && BAa.method_3() && setting2.method_96())
					{
						return true;
					}
				}
				else if (azx[i] == Class333.aSD())
				{
					SettingOrSpecialObject settingOrSpecialObject2 = BAa.method_33(azX[i]);
					if (settingOrSpecialObject2 is Table && BAa.method_2() && BAa.method_3() && (settingOrSpecialObject2 as Table).method_96())
					{
						return true;
					}
				}
				else if (azx[i].Contains(Class333.aSd()))
				{
					SettingOrSpecialObject settingOrSpecialObject3 = BAa.method_33(azX[i]);
					if (settingOrSpecialObject3 is Table && BAa.method_2() && BAa.method_3() && (settingOrSpecialObject3 as Table).method_96())
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	internal Enum103 method_15()
	{
		string string_ = azw;
		if (string_ != null)
		{
			Class37.smethod_0(ref string_, BAa);
		}
		if (string_ != null && !Class37.smethod_10(ref string_))
		{
			if (!string.IsNullOrEmpty(azW))
			{
				Form54.smethod_6(Form23.form23_0, azW, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			return Enum103.azU;
		}
		if (azv != null && Form54.smethod_6(Form23.form23_0, azv, Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
		{
			return Enum103.azt;
		}
		if (azZ == Enum101.azq && Form23.smethod_28(BAa.aXc, bool_53: true))
		{
			Form54.smethod_6(Form23.form23_0, Class333.aSE(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return Enum103.azu;
		}
		if (azZ == Enum101.azr && !Form23.smethod_28(BAa.aXc, bool_53: true))
		{
			Form54.smethod_6(Form23.form23_0, Class333.aSe(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return Enum103.azu;
		}
		switch (azY)
		{
		case Enum100.azQ:
		{
			Table table = null;
			List<Table> list = new List<Table>();
			Setting setting = null;
			List<Setting> list2 = new List<Setting>();
			Enum102 enum102_ = Enum102.azS;
			for (int i = 0; i < azx.Count; i++)
			{
				if (azx[i] == Class333.aSb())
				{
					enum102_ = (Enum102)azX[i];
				}
				else if (azx[i] == Class333.aSC())
				{
					setting = BAa.method_31(azX[i]);
				}
				else if (azx[i].Contains(Class333.aSc()))
				{
					Setting setting2 = BAa.method_31(azX[i]);
					if (setting2 != null && setting2.method_35())
					{
						list2.Add(setting2);
					}
				}
				else if (azx[i] == Class333.aSD())
				{
					SettingOrSpecialObject settingOrSpecialObject = BAa.method_33(azX[i]);
					if (settingOrSpecialObject != null && settingOrSpecialObject is Table)
					{
						table = settingOrSpecialObject as Table;
					}
				}
				else if (azx[i].Contains(Class333.aSd()))
				{
					SettingOrSpecialObject settingOrSpecialObject2 = BAa.method_33(azX[i]);
					if (settingOrSpecialObject2 != null && settingOrSpecialObject2.method_35() && settingOrSpecialObject2 is Table)
					{
						list.Add(settingOrSpecialObject2 as Table);
					}
				}
			}
			if (setting != null && list2.Count != 0)
			{
				if (!smethod_0(setting, list2, enum102_))
				{
					return Enum103.azt;
				}
			}
			else
			{
				if (table == null || list.Count == 0)
				{
					break;
				}
				if (!smethod_1(table, list, enum102_))
				{
					return Enum103.azt;
				}
			}
			goto default;
		}
		default:
			if (azy != -1)
			{
				SettingOrSpecialObject settingOrSpecialObject3 = BAa.method_33(azy);
				if (settingOrSpecialObject3 != null && settingOrSpecialObject3.method_26().method_4().Count != 0)
				{
					settingOrSpecialObject3.method_26().method_6();
				}
			}
			return Enum103.azT;
		}
		return Enum103.azt;
	}

	internal static bool smethod_0(Setting setting_0, List<Setting> list_0, Enum102 enum102_0)
	{
		if (setting_0 != null && list_0.Count != 0)
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_1();
			double num = 0.0;
			for (int i = 0; i < list_0.Count; i++)
			{
				double num2 = list_0[i].method_256();
				switch (enum102_0)
				{
				case Enum102.azS:
					num += num2 / (double)list_0.Count;
					break;
				case Enum102.azs:
					num = ((i != 0) ? Math.Max(num2, num) : num2);
					break;
				}
			}
			double num3 = setting_0.method_256();
			int num4 = 0;
			switch (enum102_0)
			{
			case Enum102.azS:
				num4 = (int)Math.Round(num3 + num3 * (num / 1000.0), 0);
				break;
			case Enum102.azs:
				num4 = (int)Math.Round(num3 + num, 0);
				break;
			}
			int num5 = setting_0.method_228();
			int num6 = setting_0.method_229();
			if (num5 != 0 || num6 != 0)
			{
				num4 = Math.Min(Math.Max(num4, num5), num6);
			}
			setting_0.method_272(num4, bool_0: true);
			Form23.smethod_74(setting_0.method_64());
			for (int j = 0; j < list_0.Count; j++)
			{
				Setting setting = list_0[j];
				double num7 = setting.method_256();
				setting.method_272((int)(num7 - num), bool_0: true);
				Form23.smethod_74(list_0[j].method_64());
			}
			@class?.method_4();
			return true;
		}
		return false;
	}

	internal static bool smethod_1(Table table_0, List<Table> list_0, Enum102 enum102_0)
	{
		if (table_0 != null && list_0.Count != 0)
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_1();
			double[,,] array = new double[list_0[0].SliceCount(), list_0[0].RowCount(), list_0[0].ColumnCount()];
			int[] array2 = null;
			if (table_0.ColumnsEnabled())
			{
				array2 = new int[list_0[0].ColumnCount()];
			}
			int[] array3 = null;
			if (table_0.RowsEnabled())
			{
				array3 = new int[list_0[0].RowCount()];
			}
			int[] array4 = null;
			if (table_0.SlicesEnabled())
			{
				array4 = new int[list_0[0].SliceCount()];
			}
			for (int i = 0; i < list_0.Count; i++)
			{
				Setting tableDataSetting = list_0[i].TableDataSetting;
				for (int j = 0; j < list_0[0].ColumnCount(); j++)
				{
					if (i == 0 && array2 != null)
					{
						array2[j] = list_0[0].ColumnAxis.method_89().method_258(j);
					}
					for (int k = 0; k < list_0[0].RowCount(); k++)
					{
						if (i == 0 && array3 != null)
						{
							array3[k] = list_0[0].RowAxis.method_89().method_258(k);
						}
						for (int l = 0; l < list_0[0].SliceCount(); l++)
						{
							if (i == 0 && array4 != null)
							{
								array4[l] = list_0[0].SliceAxis.method_89().method_258(l);
							}
							double num = tableDataSetting.method_257(j, k, l);
							switch (enum102_0)
							{
							case Enum102.azS:
								array[l, k, j] += num / (double)list_0.Count;
								break;
							case Enum102.azs:
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
			table_0.TableDataSetting.method_268();
			bool flag = (table_0.ColumnsEnabled() && table_0.ColumnAxis.method_93() != AxisBehaviour.Continuous) || (list_0[0].ColumnsEnabled() && list_0[0].ColumnAxis.method_93() != AxisBehaviour.Continuous);
			bool flag2 = (table_0.RowsEnabled() && table_0.RowAxis.method_93() != AxisBehaviour.Continuous) || (list_0[0].RowsEnabled() && list_0[0].RowAxis.method_93() != AxisBehaviour.Continuous);
			bool flag3 = (table_0.SlicesEnabled() && table_0.SliceAxis.method_93() != AxisBehaviour.Continuous) || (list_0[0].SlicesEnabled() && list_0[0].SliceAxis.method_93() != AxisBehaviour.Continuous);
			for (int m = 0; m < table_0.ColumnCount(); m++)
			{
				int num2 = 0;
				if (table_0.ColumnsEnabled())
				{
					num2 = table_0.ColumnAxis.method_89().method_258(m);
					if (flag && list_0[0].ColumnAxis.method_95(num2) == -1)
					{
						continue;
					}
				}
				for (int n = 0; n < table_0.RowCount(); n++)
				{
					int num3 = 0;
					if (table_0.RowsEnabled())
					{
						num3 = table_0.RowAxis.method_89().method_258(n);
						if (flag2 && list_0[0].RowAxis.method_95(num3) == -1)
						{
							continue;
						}
					}
					for (int num4 = 0; num4 < table_0.SliceCount(); num4++)
					{
						int num5 = 0;
						if (table_0.SlicesEnabled())
						{
							num5 = table_0.SliceAxis.method_89().method_258(num4);
							if (flag3 && list_0[0].SliceAxis.method_95(num5) == -1)
							{
								continue;
							}
						}
						double interpolatedValue = Table.GetInterpolatedValue(array, array2, array3, array4, num2, num3, num5);
						double num6 = table_0.TableDataSetting.method_257(m, n, num4);
						int num7 = 0;
						switch (enum102_0)
						{
						case Enum102.azS:
							num7 = (int)Math.Round(num6 + num6 * (interpolatedValue / 1000.0), 0);
							break;
						case Enum102.azs:
							num7 = (int)Math.Round(num6 + interpolatedValue, 0);
							break;
						}
						int num8 = table_0.method_228();
						int num9 = table_0.method_229();
						if (num8 != 0 || num9 != 0)
						{
							num7 = Math.Min(Math.Max(num7, num8), num9);
						}
						table_0.TableDataSetting.method_273(m, n, num4, num7, bool_0: true);
					}
				}
			}
			table_0.TableDataSetting.method_267(bool_0: true);
			Form23.smethod_74(table_0.TableDataSetting.method_64());
			for (int num10 = 0; num10 < list_0.Count; num10++)
			{
				list_0[num10].TableDataSetting.method_268();
			}
			for (int num11 = 0; num11 < list_0[0].TableDataSetting.method_242()[2]; num11++)
			{
				for (int num12 = 0; num12 < list_0[0].TableDataSetting.method_242()[1]; num12++)
				{
					for (int num13 = 0; num13 < list_0[0].TableDataSetting.method_242()[0]; num13++)
					{
						for (int num14 = 0; num14 < list_0.Count; num14++)
						{
							Setting tableDataSetting2 = list_0[num14].TableDataSetting;
							double num15 = tableDataSetting2.method_257(num11, num12, num13);
							double num16 = ((num11 >= list_0[0].ColumnCount() || num12 >= list_0[0].RowCount() || num13 >= list_0[0].SliceCount()) ? num15 : array[num13, num12, num11]);
							tableDataSetting2.method_273(num11, num12, num13, (int)(num15 - num16), bool_0: true);
						}
					}
				}
			}
			for (int num17 = 0; num17 < list_0.Count; num17++)
			{
				list_0[num17].TableDataSetting.method_267(bool_0: true);
				Form23.smethod_74(list_0[num17].TableDataSetting.method_64());
			}
			@class?.method_4();
			return true;
		}
		return false;
	}
}
