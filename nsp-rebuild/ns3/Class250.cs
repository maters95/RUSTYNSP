using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using NSP.SettingsFramework;
using ns7;

namespace ns3;

internal class Class250 : SpecialObject
{
	private Class247 ByL;

	private List<Class243> Byl = new List<Class243>();

	internal Class250(Framework framework_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
		ByL = settingOrSpecialObject_0 as Class247;
	}

	public override string ToString()
	{
		return Class333.BhS() + method_73();
	}

	internal void method_71()
	{
		ByL.method_79().IndexOf(this);
		for (int i = 0; i < method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = method_1()[i];
			if (settingOrSpecialObject is Class243)
			{
				Class243 @class = settingOrSpecialObject as Class243;
				Byl.Add(@class);
				@class.method_294();
			}
		}
	}

	[SpecialName]
	internal List<Class243> method_72()
	{
		return Byl;
	}

	internal int method_73()
	{
		int num = 0;
		foreach (Class243 item in Byl)
		{
			if (item.method_297().method_256() != 0)
			{
				num++;
			}
		}
		return num;
	}

	internal void method_74(bool bool_0)
	{
		foreach (Class243 item in Byl)
		{
			item.method_297().method_272(0, bool_0);
		}
		int num = ByL.method_79().IndexOf(this);
		int num2 = 0;
		MenuNode menuNode;
		while (true)
		{
			if (num2 < m_framework.awR.method_6().Count)
			{
				menuNode = m_framework.awR.method_6()[num2];
				if (menuNode.method_37() && menuNode.method_39() == num)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		m_framework.method_31(menuNode.method_73())?.method_279(bool_0);
	}

	private void method_75(List<SettingOrSpecialObject> list_0)
	{
		foreach (SettingOrSpecialObject item in list_0)
		{
			if (item is Setting)
			{
				(item as Setting).method_234();
			}
			if (item.method_1().Count != 0)
			{
				method_75(item.method_1());
			}
		}
	}

	internal void method_76()
	{
		if (method_1().Count != 0)
		{
			method_75(method_1());
		}
	}

	internal bool method_77(int int_0, int int_1)
	{
		List<SettingOrSpecialObject> list_ = Byl.Cast<SettingOrSpecialObject>().ToList();
		return SettingOrSpecialObject.smethod_0(m_framework, list_, int_0, int_1);
	}
}
