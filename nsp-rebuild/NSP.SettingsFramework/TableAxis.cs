using System.Runtime.CompilerServices;
using ns5;
using ns7;

namespace NSP.SettingsFramework;

public class TableAxis : SpecialObject
{
	private AxisType bAr;

	private Setting bAS;

	private Setting bAs;

	private Setting bAT;

	private Setting bAt;

	private Setting bAU;

	private bool bAu;

	private bool bAV;

	private int bAv;

	private int bAW;

	private int bAw;

	private int bAX;

	internal TableAxis(Framework framework_0, AxisType axisType_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
		bAr = axisType_0;
	}

	[SpecialName]
	internal AxisType method_71()
	{
		return bAr;
	}

	[SpecialName]
	internal bool method_72()
	{
		if (m_parentSettingOrSpecialObject is Table && (m_parentSettingOrSpecialObject as Table).TableDataSetting != null)
		{
			int num = (m_parentSettingOrSpecialObject as Table).TableDataSetting.method_240();
			return bAr switch
			{
				AxisType.Slice => num > 2, 
				AxisType.Row => num > 1, 
				AxisType.Column => num > 0, 
				_ => true, 
			};
		}
		return false;
	}

	internal bool method_73()
	{
		bool result = false;
		if (method_87() != null && method_89() != null && method_72())
		{
			result = method_87().method_256() != 0;
		}
		return result;
	}

	internal int method_74()
	{
		int result = 1;
		if (method_73() && method_88() != null)
		{
			result = method_88().method_256();
		}
		return result;
	}

	[SpecialName]
	internal void method_75(bool bool_0)
	{
		bAu = bool_0;
	}

	[SpecialName]
	internal bool method_76()
	{
		return bAu;
	}

	[SpecialName]
	internal void method_77(bool bool_0)
	{
		bAV = bool_0;
	}

	[SpecialName]
	internal bool method_78()
	{
		return bAV;
	}

	[SpecialName]
	internal void method_79(int int_0)
	{
		bAv = int_0;
	}

	[SpecialName]
	internal int method_80()
	{
		return bAv;
	}

	[SpecialName]
	internal void method_81(int int_0)
	{
		bAW = int_0;
	}

	[SpecialName]
	internal int method_82()
	{
		return bAW;
	}

	[SpecialName]
	internal void method_83(int int_0)
	{
		bAw = int_0;
	}

	[SpecialName]
	internal int method_84()
	{
		return bAw;
	}

	[SpecialName]
	internal void method_85(int int_0)
	{
		bAX = int_0;
	}

	[SpecialName]
	internal int method_86()
	{
		return bAX;
	}

	[SpecialName]
	internal Setting method_87()
	{
		return bAS;
	}

	[SpecialName]
	internal Setting method_88()
	{
		return bAs;
	}

	[SpecialName]
	internal Setting method_89()
	{
		return bAT;
	}

	[SpecialName]
	internal Setting method_90()
	{
		return bAt;
	}

	[SpecialName]
	internal Setting method_91()
	{
		return bAU;
	}

	internal Setting method_92()
	{
		int int_ = bAt.method_256();
		return m_framework.method_31(int_);
	}

	internal AxisBehaviour method_93()
	{
		Setting setting = method_92();
		if (setting != null && setting.method_167() != -1)
		{
			return (AxisBehaviour)setting.method_167();
		}
		if (bAU != null)
		{
			return (AxisBehaviour)bAU.method_256();
		}
		return AxisBehaviour.Continuous;
	}

	internal void method_94()
	{
		for (int i = 0; i < method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = method_1()[i];
			if (!(settingOrSpecialObject is Setting))
			{
				continue;
			}
			if (settingOrSpecialObject.method_2() == Class333.smethod_420())
			{
				bAS = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == Class333.smethod_800())
			{
				bAs = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == Class333.smethod_796())
			{
				bAT = settingOrSpecialObject as Setting;
			}
			else if (!(settingOrSpecialObject.method_2() == Class333.smethod_814()) && !(settingOrSpecialObject.method_2() == Class333.ajW()))
			{
				if (settingOrSpecialObject.method_2() == Class333.aiv())
				{
					bAU = settingOrSpecialObject as Setting;
				}
			}
			else
			{
				bAt = settingOrSpecialObject as Setting;
			}
		}
		if (bAS == null && bAv != 0)
		{
			bAS = m_framework.method_31(bAv);
		}
		if (bAs == null && bAW != 0)
		{
			bAs = m_framework.method_31(bAW);
		}
		if (bAT == null && bAw != 0)
		{
			bAT = m_framework.method_31(bAw);
		}
		if (bAt == null && bAX != 0)
		{
			bAt = m_framework.method_31(bAX);
		}
	}

	internal int method_95(int int_0)
	{
		return method_96(int_0, null, 0);
	}

	internal int method_96(int int_0, string string_0, int int_1)
	{
		bool flag = false;
		if (method_87() != null && method_89() != null && method_88() != null && method_72())
		{
			flag = method_87().method_256() != 0;
		}
		if (flag)
		{
			int num = method_88().method_256();
			for (int i = 0; i < num; i++)
			{
				int num2 = method_89().method_258(i);
				if (num2 != int_0)
				{
					if (!string.IsNullOrEmpty(string_0) && Class233.smethod_29(num2, int_1) == string_0)
					{
						return i;
					}
					continue;
				}
				return i;
			}
		}
		return -1;
	}

	internal static bool smethod_4(int int_0, Setting setting_0)
	{
		if (setting_0 != null)
		{
			foreach (Setting.ListItems.Struct45 item in setting_0.method_102())
			{
				if (int_0 == item.bBv)
				{
					return false;
				}
			}
			int int_1 = 0;
			int int_2 = 0;
			int int_3 = 0;
			int int_4 = 0;
			setting_0.method_230(ref int_1, ref int_2, ref int_3, ref int_4);
			if (int_0 < int_3 || int_0 > int_4)
			{
				return true;
			}
		}
		return false;
	}
}
