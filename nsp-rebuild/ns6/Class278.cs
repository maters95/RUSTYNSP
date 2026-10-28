using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using NSP.SettingsFramework;
using ns7;

namespace ns6;

internal class Class278
{
	private List<Class279> BCE = new List<Class279>();

	private DataIdAndAttrId BCe;

	internal Class278(DataIdAndAttrId dataIdAndAttrId_0)
	{
		BCe = dataIdAndAttrId_0;
	}

	internal Class278()
	{
	}

	internal string method_0(Framework framework_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (BCE.Count != 0)
		{
			HashSet<DataIdAndAttrId> hashSet = new HashSet<DataIdAndAttrId>();
			foreach (Class279 item in BCE)
			{
				hashSet.Add(item.BCF);
			}
			stringBuilder.Append(Class333.aTZ() + ((hashSet.Count > 1) ? Class333.smethod_960() : Class333.smethod_102()) + Class333.aTz());
			foreach (DataIdAndAttrId item2 in hashSet)
			{
				Setting setting = framework_0.method_32(item2);
				stringBuilder.Append(Class333.atA() + setting.method_22(bool_0: true));
			}
		}
		return stringBuilder.ToString();
	}

	internal void method_1(Setting setting_0)
	{
		Class279 @class = new Class279();
		@class.BCF = setting_0.method_69();
		BCE.Add(@class);
	}

	internal void method_2(Setting setting_0, int int_0, int int_1)
	{
		Class279 @class = BCE[BCE.Count - 1];
		for (int i = 0; i < int_1; i++)
		{
			byte item = setting_0.method_254(int_0 + i);
			@class.BCG.Add(item);
		}
		@class.BCf = int_0;
	}

	internal void method_3(Setting setting_0, int int_0, int int_1)
	{
		Class279 @class = BCE[BCE.Count - 1];
		for (int i = 0; i < int_1; i++)
		{
			byte item = setting_0.method_254(int_0 + i);
			@class.BCg.Add(item);
		}
		@class.BCf = int_0;
	}

	[SpecialName]
	internal List<Class279> method_4()
	{
		return BCE;
	}

	[SpecialName]
	internal DataIdAndAttrId method_5()
	{
		return BCe;
	}

	public override string ToString()
	{
		return Class333.ata() + BCE.Count + Class333.atB();
	}
}
