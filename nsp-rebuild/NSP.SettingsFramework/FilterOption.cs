using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;
using ns6;

namespace NSP.SettingsFramework;

public class FilterOption : SpecialObject
{
	internal class Class266
	{
		internal Enum104 bbE;

		internal Enum105 bbe;

		internal byte bbF;

		internal ushort bbf;

		internal bool bbG;

		internal int bbg;

		internal Class266(uint uint_0, bool bool_0, int int_0)
		{
			bbE = PortFunction.smethod_12(uint_0);
			bbe = PortFunction.smethod_13(uint_0);
			bbF = PortFunction.smethod_14(uint_0);
			bbf = PortFunction.smethod_15(uint_0);
			bbG = bool_0;
			bbg = int_0;
		}
	}

	private List<Class266> BZE = new List<Class266>();

	private List<Class266> BZe = new List<Class266>();

	private List<string> BZF = new List<string>();

	private HashSet<int> BZf = new HashSet<int>();

	private bool BZG;

	private bool BZg;

	internal FilterOption(Framework framework_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
	}

	[SpecialName]
	internal bool method_71()
	{
		return BZg;
	}

	[SpecialName]
	internal void method_72(bool bool_0)
	{
		BZg = bool_0;
	}

	protected override void RevertAllConditionalPropertiesToDefaults()
	{
		base.RevertAllConditionalPropertiesToDefaults();
		BZe.Clear();
		for (int i = 0; i < BZE.Count; i++)
		{
			Class266 @class = BZE[i];
			if (@class.bbg == -1)
			{
				BZe.Add(@class);
			}
		}
	}

	protected override void UpdateConditionalPropertiesValues(int cellIndex, int condPropertiesBlockIndex)
	{
		base.UpdateConditionalPropertiesValues(cellIndex, condPropertiesBlockIndex);
		if (cellIndex != 0)
		{
			return;
		}
		for (int i = 0; i < BZE.Count; i++)
		{
			Class266 @class = BZE[i];
			if (@class.bbg == condPropertiesBlockIndex)
			{
				BZe.Add(@class);
			}
		}
	}

	internal void method_73(string string_0)
	{
		BZF.Add(string_0);
	}

	[SpecialName]
	internal bool method_74()
	{
		return BZG;
	}

	internal bool method_75(bool bool_0)
	{
		bool flag = false;
		if (BZF.Count == 0)
		{
			flag = true;
		}
		else
		{
			for (int i = 0; i < BZF.Count; i++)
			{
				string string_ = BZF[i];
				List<int> list = Class37.smethod_0(ref string_, m_framework);
				if (bool_0)
				{
					for (int j = 0; j < list.Count; j++)
					{
						BZf.Add(list[j]);
						Setting setting = m_framework.method_31(list[j]);
						setting.method_133().Add(method_57());
						setting.method_134().Add(this);
					}
				}
				bool flag2 = Class37.smethod_10(ref string_);
				flag |= flag2;
			}
		}
		bool result = BZG != flag;
		BZG = flag;
		return result;
	}

	[SpecialName]
	internal HashSet<int> method_76()
	{
		return BZf;
	}

	internal void method_77(uint uint_0, bool bool_0, int int_0)
	{
		Class266 item = new Class266(uint_0, bool_0, int_0);
		BZE.Add(item);
	}

	internal List<Class266> method_78()
	{
		return BZe;
	}
}
