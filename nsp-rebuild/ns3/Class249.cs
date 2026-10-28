using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using NSP.SettingsFramework;
using ns4;
using ns6;
using ns7;

namespace ns3;

internal class Class249 : SpecialObject
{
	private List<Class248> ByK = new List<Class248>();

	private Setting Byk;

	internal Class249(Framework framework_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
	}

	internal void method_71()
	{
		for (int i = 0; i < method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = method_1()[i];
			if (settingOrSpecialObject.method_2() == Class333.Bhr())
			{
				Byk = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject is Class248)
			{
				Class248 @class = settingOrSpecialObject as Class248;
				ByK.Add(@class);
				@class.method_71();
			}
		}
	}

	[SpecialName]
	internal Setting method_72()
	{
		return Byk;
	}

	[SpecialName]
	internal List<Class248> method_73()
	{
		return ByK;
	}

	internal void method_74()
	{
		foreach (Class248 item in ByK)
		{
			if (item.method_72().method_256() == 0)
			{
				Class280 @class = Form23.smethod_95();
				@class?.method_1();
				item.method_19().method_262(Class333.smethod_664(), bool_0: true);
				item.method_72().method_272(1, bool_0: true);
				@class?.method_4();
				Form23.smethod_74(item.method_72().method_64());
				break;
			}
		}
	}

	internal void method_75(int int_0)
	{
		Class248 @class = ByK[int_0];
		if (@class.method_72().method_256() != 0)
		{
			Class280 class2 = Form23.smethod_95();
			class2?.method_1();
			@class.method_72().method_272(0, bool_0: true);
			class2?.method_4();
			Form23.smethod_74(@class.method_72().method_64());
		}
	}

	internal void method_76(int int_0)
	{
		Class248 @class = null;
		foreach (Class248 item in ByK)
		{
			if (item.method_72().method_256() == 0)
			{
				@class = item;
				break;
			}
		}
		if (@class != null)
		{
			Class280 class2 = Form23.smethod_95();
			class2?.method_1();
			Class248 settingOrSpecialObject_ = ByK[int_0];
			@class.method_29(settingOrSpecialObject_, bool_0: true);
			@class.method_72().method_272(1, bool_0: true);
			class2?.method_4();
			Form23.smethod_74(@class.method_72().method_64());
		}
	}

	internal void method_77(int int_0)
	{
		if (Byk != null)
		{
			Byk.method_272(int_0, bool_0: false);
		}
	}

	internal bool method_78(int int_0, int int_1)
	{
		List<SettingOrSpecialObject> list_ = ByK.Cast<SettingOrSpecialObject>().ToList();
		return SettingOrSpecialObject.smethod_0(m_framework, list_, int_0, int_1);
	}
}
