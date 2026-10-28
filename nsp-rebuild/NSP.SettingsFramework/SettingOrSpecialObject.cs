using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using ns0;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class SettingOrSpecialObject
{
	public struct CondPropertiesBlock
	{
		internal int Brj;

		internal string BrK;

		internal bool Brk;
	}

	protected class EnableOn
	{
		internal string BrL;

		internal int Brl;

		internal EnableOn(string string_0, int int_0)
		{
			BrL = string_0;
			Brl = int_0;
		}
	}

	protected class StringProperty
	{
		internal string BrM;

		internal string Brm;

		internal Dictionary<int, string> BrN;

		internal StringProperty()
		{
			BrN = new Dictionary<int, string>();
		}

		internal void method_0(string string_0, int int_0)
		{
			if (int_0 == -1)
			{
				Brm = string_0;
				BrM = string_0;
			}
			else
			{
				BrN.Add(int_0, string_0);
			}
		}

		public override string ToString()
		{
			return BrM;
		}
	}

	public class PartialMapTagFilters
	{
		internal Dictionary<string, string> Brn = new Dictionary<string, string>();

		internal Dictionary<string, string> BrO = new Dictionary<string, string>();

		internal Dictionary<int, Dictionary<string, string>> Bro = new Dictionary<int, Dictionary<string, string>>();
	}

	protected string m_internalName;

	protected string m_parentModuleName;

	protected MenuNode m_isTargetObjectForMenuNode;

	protected int m_objectId = -1;

	protected int m_parentDataId;

	protected int m_parentObjectId;

	protected int m_partialMapTypeId;

	protected PartialMapTagFilters m_partialMapTagFilters = new PartialMapTagFilters();

	protected List<EnableOn> m_allEnableOns = new List<EnableOn>();

	protected List<EnableOn> m_currentEnableOns = new List<EnableOn>();

	protected List<CondPropertiesBlock> m_condPropertiesBlocks = new List<CondPropertiesBlock>();

	protected bool m_hasMultiCellCondProperties;

	protected List<bool> m_conditionsPreviouslyMetPerCondPropertiesBlock = new List<bool>();

	protected bool m_conditionsChangedOnLastEvaluation = true;

	protected bool m_currentEnableOn = true;

	protected HashSet<int> m_dataIdsInEnableOnEquations = new HashSet<int>();

	protected HashSet<int> m_dataIdsInCondPropsEquations = new HashSet<int>();

	protected List<string> m_searchMetaTags = new List<string>();

	protected int m_dataIdOfCustomNameSetting;

	protected StringProperty[] m_stringProperties = new StringProperty[7];

	protected string m_inputType;

	protected string m_disclaimer;

	protected bool m_disclaimerShowEveryTime;

	protected List<string> m_associatedDTCs = new List<string>();

	protected string m_dtc;

	protected PortFunction m_portFunction;

	protected UserLog m_userLog;

	protected byte m_externalDeviceType;

	protected List<InitialTaskObject> m_initialTaskObjects = new List<InitialTaskObject>();

	protected SettingWriteTaskObject m_settingWriteTaskObject;

	protected List<int> m_embeddedFunctionsObjectIds = new List<int>();

	protected List<SettingOrSpecialObject> m_childSettingsOrSpecialObjects = new List<SettingOrSpecialObject>();

	protected Framework m_framework;

	protected SettingOrSpecialObject m_parentSettingOrSpecialObject;

	[CompilerGenerated]
	private int aYX = -1;

	private string aYx = string.Empty;

	[CompilerGenerated]
	private EventHandler aYY;

	private bool aYy = true;

	[CompilerGenerated]
	private string aYZ;

	internal SettingOrSpecialObject(Framework framework_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
	{
		m_framework = framework_0;
		m_parentSettingOrSpecialObject = settingOrSpecialObject_0;
		m_parentModuleName = string_1;
		m_internalName = string_0;
		int parentDataId = 0;
		if (settingOrSpecialObject_0 is Setting)
		{
			parentDataId = (settingOrSpecialObject_0 as Setting).method_64();
		}
		m_parentDataId = parentDataId;
		int parentObjectId = -1;
		if (settingOrSpecialObject_0 != null)
		{
			parentObjectId = settingOrSpecialObject_0.method_57();
		}
		m_parentObjectId = parentObjectId;
		for (int i = 0; i < 7; i++)
		{
			m_stringProperties[i] = new StringProperty();
		}
	}

	[SpecialName]
	internal Framework method_0()
	{
		return m_framework;
	}

	[SpecialName]
	internal List<SettingOrSpecialObject> method_1()
	{
		return m_childSettingsOrSpecialObjects;
	}

	[SpecialName]
	internal string method_2()
	{
		return m_internalName;
	}

	[SpecialName]
	internal int method_3()
	{
		return m_parentDataId;
	}

	[SpecialName]
	internal int method_4()
	{
		return m_parentObjectId;
	}

	[SpecialName]
	internal string method_5()
	{
		return m_parentModuleName;
	}

	[SpecialName]
	internal SettingOrSpecialObject method_6()
	{
		return m_parentSettingOrSpecialObject;
	}

	internal bool method_7(SettingOrSpecialObject settingOrSpecialObject_0, bool bool_0)
	{
		if (bool_0)
		{
			if (m_parentSettingOrSpecialObject != null && m_parentSettingOrSpecialObject == settingOrSpecialObject_0)
			{
				return true;
			}
			return false;
		}
		SettingOrSpecialObject settingOrSpecialObject = this;
		bool flag = false;
		do
		{
			if (settingOrSpecialObject.method_6() == null)
			{
				flag = true;
				continue;
			}
			if (settingOrSpecialObject.method_6() != settingOrSpecialObject_0)
			{
				settingOrSpecialObject = settingOrSpecialObject.method_6();
				continue;
			}
			return true;
		}
		while (!flag);
		return false;
	}

	[SpecialName]
	internal int method_8()
	{
		return m_partialMapTypeId;
	}

	[SpecialName]
	internal void method_9(int int_0)
	{
		m_partialMapTypeId = int_0;
	}

	[SpecialName]
	internal Dictionary<string, string> method_10()
	{
		return m_partialMapTagFilters.Brn;
	}

	internal Interface4 method_11()
	{
		if (this is Interface4)
		{
			return this as Interface4;
		}
		if (method_13().DataIdOfChannelListSetting != 0)
		{
			return method_13();
		}
		if (this is SpecialObject)
		{
			SpecialObject specialObject = this as SpecialObject;
			if (specialObject.method_68().IdleText == null && specialObject.method_68().PreApplySettingDataIds.Count == 0)
			{
				if (specialObject.method_66().CurrentUIListSettingsIdsAndIndents.Count != 0)
				{
					return specialObject.method_66();
				}
				if (specialObject.method_67().DataIdsOfListSettings.Count == 0 && !specialObject.method_67().EachListRowIsAnObject())
				{
					if (specialObject.method_69().EnablerSettingId == 0 && specialObject.method_69().ChannelSettingId == 0 && specialObject.method_69().OperatorSettingId == 0 && specialObject.method_69().ThresholdSettingId == 0 && string.IsNullOrEmpty(specialObject.method_69().JoinText))
					{
						return null;
					}
					return specialObject.method_69();
				}
				return specialObject.method_67();
			}
			return specialObject.method_68();
		}
		return null;
	}

	[SpecialName]
	internal PortFunction method_12()
	{
		if (m_portFunction == null)
		{
			m_portFunction = new PortFunction(m_framework, this);
		}
		return m_portFunction;
	}

	[SpecialName]
	internal UserLog method_13()
	{
		if (m_userLog == null)
		{
			m_userLog = new UserLog(m_framework, this);
		}
		return m_userLog;
	}

	[SpecialName]
	internal byte method_14()
	{
		return m_externalDeviceType;
	}

	[SpecialName]
	internal void method_15(byte byte_0)
	{
		m_externalDeviceType = byte_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal int method_16()
	{
		return aYX;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_17(int int_0)
	{
		aYX = int_0;
	}

	internal string method_18()
	{
		Setting setting = method_19();
		string result = string.Empty;
		if (setting != null && setting.method_70() != 0)
		{
			result = ((method_16() == -1) ? setting.method_260() : setting.method_261(method_16()));
		}
		return result;
	}

	internal Setting method_19()
	{
		Setting result = null;
		if (m_dataIdOfCustomNameSetting != 0)
		{
			result = m_framework.method_31(m_dataIdOfCustomNameSetting);
		}
		return result;
	}

	[SpecialName]
	internal int method_20()
	{
		return m_dataIdOfCustomNameSetting;
	}

	[SpecialName]
	internal void method_21(int int_0)
	{
		m_dataIdOfCustomNameSetting = int_0;
	}

	internal string method_22(bool bool_0)
	{
		string text = string.Empty;
		if (this is Setting setting && setting.method_207())
		{
			string text2 = method_60(Enum96.aYt);
			string text3 = setting.method_18();
			text = ((!string.IsNullOrWhiteSpace(text3)) ? (text3 + Class333.smethod_497() + text2 + Class333.smethod_9()) : text2);
		}
		else if (bool_0)
		{
			if (Form48.smethod_2() && method_60(Enum96.aYW) != null)
			{
				text = method_60(Enum96.aYW);
			}
			else if (method_60(Enum96.aYv) != null)
			{
				text = method_60(Enum96.aYv);
			}
			else if (method_60(Enum96.aYV) != null)
			{
				text = method_60(Enum96.aYV);
			}
			else if (method_60(Enum96.aYu) != null)
			{
				text = method_60(Enum96.aYu);
			}
			if (string.IsNullOrWhiteSpace(text))
			{
				text = method_60(Enum96.aYt);
			}
			if (string.IsNullOrEmpty(text))
			{
				text = m_internalName;
			}
		}
		else if (Form48.smethod_2() && method_60(Enum96.aYW) != null)
		{
			text = method_60(Enum96.aYW);
		}
		else if (method_60(Enum96.aYv) != null)
		{
			text = method_60(Enum96.aYv);
		}
		else if (method_60(Enum96.aYV) != null)
		{
			text = method_60(Enum96.aYV);
		}
		else if (method_60(Enum96.aYu) != null)
		{
			text = method_60(Enum96.aYu);
		}
		else if (method_60(Enum96.aYt) != null)
		{
			text = method_60(Enum96.aYt);
		}
		return text;
	}

	[SpecialName]
	internal List<string> method_23()
	{
		return m_searchMetaTags;
	}

	[SpecialName]
	internal List<InitialTaskObject> method_24()
	{
		return m_initialTaskObjects;
	}

	internal bool method_25()
	{
		bool result = true;
		foreach (InitialTaskObject initialTaskObject in m_initialTaskObjects)
		{
			switch (initialTaskObject.method_15())
			{
			case Enum103.azt:
				if (!initialTaskObject.method_10())
				{
					result = false;
					break;
				}
				return false;
			case Enum103.azU:
				if (!initialTaskObject.method_12())
				{
					result = false;
					break;
				}
				return false;
			case Enum103.azu:
				return false;
			}
		}
		return result;
	}

	[SpecialName]
	internal SettingWriteTaskObject method_26()
	{
		if (m_settingWriteTaskObject == null)
		{
			m_settingWriteTaskObject = new SettingWriteTaskObject(m_framework);
		}
		return m_settingWriteTaskObject;
	}

	[SpecialName]
	internal List<int> method_27()
	{
		return m_embeddedFunctionsObjectIds;
	}

	internal void method_28(int int_0)
	{
		m_embeddedFunctionsObjectIds.Add(int_0);
	}

	internal void method_29(SettingOrSpecialObject settingOrSpecialObject_0, bool bool_0)
	{
		Setting setting = this as Setting;
		Setting setting2 = settingOrSpecialObject_0 as Setting;
		if (setting != null && setting2 != null)
		{
			setting.method_116(setting2, bool_0);
		}
		for (int i = 0; i < settingOrSpecialObject_0.method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = m_childSettingsOrSpecialObjects[i];
			SettingOrSpecialObject settingOrSpecialObject_1 = settingOrSpecialObject_0.method_1()[i];
			settingOrSpecialObject.method_29(settingOrSpecialObject_1, bool_0);
		}
	}

	internal void method_30(string string_0, int int_0)
	{
		m_allEnableOns.Add(new EnableOn(string_0, int_0));
	}

	internal bool method_31(string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < m_allEnableOns.Count)
			{
				if (m_allEnableOns[num].BrL.Contains(string_0))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	internal void method_32(string string_0, string string_1, int int_0, string string_2)
	{
		if (int_0 == -1)
		{
			m_partialMapTagFilters.BrO.Add(string_0, string_1);
			m_partialMapTagFilters.Brn.Add(string_0, string_1);
			aYx = string.Empty;
			return;
		}
		if (string_2 != aYx)
		{
			m_partialMapTagFilters.Bro.Add(int_0, new Dictionary<string, string>());
			aYx = string_2;
		}
		m_partialMapTagFilters.Bro[int_0].Add(string_0, string_1);
	}

	internal virtual void vmethod_0(string string_0, bool bool_0)
	{
		CondPropertiesBlock item = new CondPropertiesBlock
		{
			Brj = m_condPropertiesBlocks.Count,
			BrK = string_0,
			Brk = bool_0
		};
		m_condPropertiesBlocks.Add(item);
		if (bool_0)
		{
			m_hasMultiCellCondProperties = true;
		}
	}

	internal bool method_33(string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < m_condPropertiesBlocks.Count)
			{
				if (m_condPropertiesBlocks[num].BrK.Contains(string_0))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	internal int method_34()
	{
		return m_condPropertiesBlocks.Count;
	}

	protected virtual void RevertAllConditionalPropertiesToDefaults()
	{
		for (int i = 0; i < 7; i++)
		{
			m_stringProperties[i].BrM = m_stringProperties[i].Brm;
		}
		m_partialMapTagFilters.Brn.Clear();
		foreach (string key in m_partialMapTagFilters.BrO.Keys)
		{
			m_partialMapTagFilters.Brn.Add(key, m_partialMapTagFilters.BrO[key]);
		}
		m_currentEnableOns.Clear();
		for (int j = 0; j < m_allEnableOns.Count; j++)
		{
			EnableOn enableOn = m_allEnableOns[j];
			if (enableOn.Brl == -1)
			{
				m_currentEnableOns.Add(enableOn);
			}
		}
		method_12().method_13();
	}

	protected virtual void UpdateConditionalPropertiesValues(int cellIndex, int condPropertiesBlockIndex)
	{
		if (cellIndex != 0)
		{
			return;
		}
		for (int i = 0; i < 7; i++)
		{
			if (m_stringProperties[i].BrN.ContainsKey(condPropertiesBlockIndex))
			{
				m_stringProperties[i].BrM = m_stringProperties[i].BrN[condPropertiesBlockIndex];
			}
		}
		if (m_partialMapTagFilters.Bro.ContainsKey(condPropertiesBlockIndex))
		{
			foreach (string key in m_partialMapTagFilters.Bro[condPropertiesBlockIndex].Keys)
			{
				m_partialMapTagFilters.Brn.Add(key, m_partialMapTagFilters.Bro[condPropertiesBlockIndex][key]);
			}
		}
		for (int j = 0; j < m_allEnableOns.Count; j++)
		{
			EnableOn enableOn = m_allEnableOns[j];
			if (enableOn.Brl == condPropertiesBlockIndex)
			{
				m_currentEnableOns.Add(enableOn);
			}
		}
		method_12().method_14(condPropertiesBlockIndex);
	}

	[SpecialName]
	internal bool method_35()
	{
		return m_currentEnableOn;
	}

	[SpecialName]
	internal HashSet<int> method_36()
	{
		return m_dataIdsInEnableOnEquations;
	}

	[SpecialName]
	internal HashSet<int> method_37()
	{
		return m_dataIdsInCondPropsEquations;
	}

	private bool method_38(HashSet<DataIdAndAttrId> hashSet_0)
	{
		foreach (int dataIdsInEnableOnEquation in m_dataIdsInEnableOnEquations)
		{
			if (hashSet_0.Contains(new DataIdAndAttrId(dataIdsInEnableOnEquation)))
			{
				return true;
			}
		}
		foreach (int dataIdsInCondPropsEquation in m_dataIdsInCondPropsEquations)
		{
			if (hashSet_0.Contains(new DataIdAndAttrId(dataIdsInCondPropsEquation)))
			{
				return true;
			}
		}
		if (this is FilterOption)
		{
			foreach (int item in (this as FilterOption).method_76())
			{
				if (hashSet_0.Contains(new DataIdAndAttrId(item)))
				{
					return true;
				}
			}
		}
		if (this is Setting setting)
		{
			for (int i = 0; i < setting.method_126().Count; i++)
			{
				if (setting.method_126()[i] == null)
				{
					continue;
				}
				foreach (int item2 in setting.method_126()[i])
				{
					if (hashSet_0.Contains(new DataIdAndAttrId(item2)))
					{
						return true;
					}
				}
			}
			if (setting.method_68() && setting.method_6() != null)
			{
				foreach (int item3 in setting.method_6().method_36())
				{
					if (hashSet_0.Contains(new DataIdAndAttrId(item3)))
					{
						return true;
					}
				}
			}
			if (setting.method_6() != null && (setting.method_6() is Class255 || setting.method_6().method_6() is Class255))
			{
				Class255 @class = ((setting.method_6() is Class255) ? (setting.method_6() as Class255) : (setting.method_6().method_6() as Class255));
				if (hashSet_0.Contains(@class.BZK.method_69()))
				{
					return true;
				}
				if ((@class.BZK.method_64() == 19293 && hashSet_0.Contains(new DataIdAndAttrId(10363))) || (@class.BZK.method_64() == 19323 && hashSet_0.Contains(new DataIdAndAttrId(10362))) || (@class.BZK.method_64() == 19351 && hashSet_0.Contains(new DataIdAndAttrId(16033))))
				{
					return true;
				}
				if (setting == @class.BZK)
				{
					if (hashSet_0.Contains(@class.BZl.method_69()) || hashSet_0.Contains(@class.BZk.method_69()) || hashSet_0.Contains(@class.BZL.method_69()) || hashSet_0.Contains(@class.BZN.method_69()) || hashSet_0.Contains(@class.BZm.method_69()) || hashSet_0.Contains(@class.BZp.method_69()) || hashSet_0.Contains(@class.BZo.method_69()) || hashSet_0.Contains(@class.BZP.method_69()) || hashSet_0.Contains(@class.BZn.method_69()) || hashSet_0.Contains(@class.BZr.method_69()) || hashSet_0.Contains(@class.BZq.method_69()))
					{
						return true;
					}
				}
				else if (setting == @class.BZk)
				{
					if (hashSet_0.Contains(@class.BZl.method_69()))
					{
						return true;
					}
				}
				else if (setting == @class.BZL)
				{
					if (hashSet_0.Contains(@class.BZl.method_69()))
					{
						return true;
					}
					foreach (int item4 in @class.BZj)
					{
						if (hashSet_0.Contains(new DataIdAndAttrId(item4)))
						{
							return true;
						}
					}
				}
				else if (setting == @class.BZm)
				{
					if (hashSet_0.Contains(@class.BZl.method_69()) || hashSet_0.Contains(@class.BZN.method_69()))
					{
						return true;
					}
				}
				else if (setting == @class.BZq)
				{
					if (hashSet_0.Contains(@class.BZl.method_69()) || hashSet_0.Contains(@class.BZN.method_69()))
					{
						return true;
					}
				}
				else if (setting == @class.BZo)
				{
					if (hashSet_0.Contains(@class.BZl.method_69()) || hashSet_0.Contains(@class.BZN.method_69()) || hashSet_0.Contains(@class.BZp.method_69()) || hashSet_0.Contains(@class.BZP.method_69()))
					{
						return true;
					}
				}
				else if (setting == @class.BZP)
				{
					if (hashSet_0.Contains(@class.BZl.method_69()) || hashSet_0.Contains(@class.BZN.method_69()) || hashSet_0.Contains(@class.BZp.method_69()) || hashSet_0.Contains(@class.BZo.method_69()))
					{
						return true;
					}
				}
				else if (setting == @class.BZn)
				{
					if (hashSet_0.Contains(@class.BZl.method_69()) || hashSet_0.Contains(@class.BZN.method_69()) || hashSet_0.Contains(@class.BZM.method_69()))
					{
						return true;
					}
				}
				else if (setting == @class.BZr && (hashSet_0.Contains(@class.BZl.method_69()) || hashSet_0.Contains(@class.BZN.method_69()) || hashSet_0.Contains(@class.BZn.method_69()) || hashSet_0.Contains(@class.BZO.method_69())))
				{
					return true;
				}
			}
		}
		return false;
	}

	internal bool method_39(HashSet<DataIdAndAttrId> hashSet_0, bool bool_0)
	{
		Setting setting = this as Setting;
		bool flag = false;
		flag = hashSet_0 == null || hashSet_0.Count == 0 || ((setting == null || !setting.method_169() || !bool_0) && setting != null && hashSet_0.Contains(setting.method_69())) || method_38(hashSet_0);
		if (setting != null)
		{
			if (!flag && this is Class244)
			{
				flag = true;
			}
			if (!flag && PortFunction.smethod_27(m_parentSettingOrSpecialObject))
			{
				if (bool_0)
				{
					if (setting.method_121(Class333.aoe()))
					{
						flag = true;
					}
				}
				else if (method_31(Class333.aoe()))
				{
					flag = true;
				}
				else if (method_33(Class333.aoe()))
				{
					flag = true;
				}
			}
			if (!flag && m_parentSettingOrSpecialObject != null && !setting.method_207() && (setting.method_102().Count != 0 || setting.method_106().Count != 0) && setting is Class245)
			{
				for (int i = 0; i < m_parentSettingOrSpecialObject.method_1().Count; i++)
				{
					if (m_parentSettingOrSpecialObject.method_1()[i] is Setting setting2 && setting2.method_150())
					{
						if (hashSet_0.Contains(setting2.method_69()))
						{
							flag = true;
						}
						break;
					}
				}
				if (!flag)
				{
					if (bool_0)
					{
						if (setting.method_121(Class333.ald()))
						{
							flag = true;
						}
					}
					else if (method_31(Class333.ald()))
					{
						flag = true;
					}
					else if (method_33(Class333.ald()))
					{
						flag = true;
					}
				}
			}
			if (!flag && setting.method_150())
			{
				flag = true;
			}
			if (!flag && setting.method_98() != 0)
			{
				flag = true;
			}
			if (!flag && (setting.method_159() || setting.method_165()))
			{
				flag = true;
			}
			if (!flag && setting.method_163().DataId != 0)
			{
				flag = true;
			}
			if (!flag && setting.method_68() && setting.method_67() != 4)
			{
				Setting setting3 = m_framework.method_32(new DataIdAndAttrId(setting.method_64(), 4));
				if (setting3 != null && hashSet_0.Contains(setting3.method_69()))
				{
					flag = true;
				}
			}
			if (!flag && setting.method_68() && (setting.method_67() == 8 || setting.method_67() == 9 || setting.method_67() == 6 || setting.method_67() == 7))
			{
				Setting setting4 = m_framework.method_32(new DataIdAndAttrId(setting.method_64(), 8));
				Setting setting5 = m_framework.method_32(new DataIdAndAttrId(setting.method_64(), 9));
				Setting setting6 = m_framework.method_32(new DataIdAndAttrId(setting.method_64(), 6));
				Setting setting7 = m_framework.method_32(new DataIdAndAttrId(setting.method_64(), 7));
				if ((setting4 != null && hashSet_0.Contains(setting4.method_69())) || (setting5 != null && hashSet_0.Contains(setting5.method_69())) || (setting6 != null && hashSet_0.Contains(setting6.method_69())) || (setting7 != null && hashSet_0.Contains(setting7.method_69())))
				{
					flag = true;
				}
			}
			if (!flag && this is Table)
			{
				flag = true;
			}
		}
		if (flag)
		{
			if (!bool_0)
			{
				bool flag2 = m_dataIdsInEnableOnEquations.Count == 0 && (hashSet_0 == null || hashSet_0.Count == 0);
				m_conditionsChangedOnLastEvaluation = false;
				m_conditionsChangedOnLastEvaluation |= EvaluateCondPropertiesConditions(flag2);
				m_conditionsChangedOnLastEvaluation |= EvaluateEnableOnConditions(flag2);
				if (this is FilterOption)
				{
					m_conditionsChangedOnLastEvaluation |= (this as FilterOption).method_75(flag2);
				}
			}
			else
			{
				if (setting != null)
				{
					bool flag2 = setting.method_126().Count == 0 && (hashSet_0 == null || hashSet_0.Count == 0);
					if (flag2 || !setting.method_169())
					{
						m_conditionsChangedOnLastEvaluation |= setting.method_136(flag2);
					}
					DataIdAndAttrId dataIdAndAttrId = setting.method_69();
					if (!m_conditionsChangedOnLastEvaluation && setting.method_70() != 0 && hashSet_0 != null && hashSet_0.Contains(dataIdAndAttrId))
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
					if (!m_conditionsChangedOnLastEvaluation && setting is Class244 && hashSet_0 != null && hashSet_0.Contains(dataIdAndAttrId))
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
					if (!m_conditionsChangedOnLastEvaluation && setting is Class243 && dataIdAndAttrId == (setting as Class243).method_297().method_69() && hashSet_0 != null && hashSet_0.Contains(dataIdAndAttrId))
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
					if (!m_conditionsChangedOnLastEvaluation && setting.method_163().DataId != 0)
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
					if (!m_conditionsChangedOnLastEvaluation && setting.method_68() && setting.method_67() != 4 && m_framework.method_32(new DataIdAndAttrId(setting.method_64(), 4)) != null)
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
					if (!m_conditionsChangedOnLastEvaluation && (setting.method_191() != 0 || setting.method_193() != 0))
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
					if (!m_conditionsChangedOnLastEvaluation && dataIdAndAttrId.DataId == 10195 && hashSet_0 != null && hashSet_0.Contains(dataIdAndAttrId))
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
					if (!m_conditionsChangedOnLastEvaluation && (dataIdAndAttrId.DataId == 19293 || dataIdAndAttrId.DataId == 19323 || dataIdAndAttrId.DataId == 19351) && hashSet_0 != null && hashSet_0.Contains(dataIdAndAttrId))
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
				}
				if (m_conditionsChangedOnLastEvaluation)
				{
					method_42();
				}
			}
			return m_conditionsChangedOnLastEvaluation;
		}
		return false;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_40(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = aYY;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref aYY, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_41(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = aYY;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref aYY, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private void method_42()
	{
		if (!aYy)
		{
			return;
		}
		if (aYY != null)
		{
			aYY(this, null);
		}
		if (!(this is Setting setting) || !m_framework.method_9() || m_framework.awh == null || m_framework.awh.method_13() == null || setting.method_94() == 0 || !setting.method_207())
		{
			return;
		}
		Setting setting2 = m_framework.method_31(12201);
		if (setting2 != null && setting2.method_256() != 0)
		{
			if (method_35() && PortFunction.smethod_52(setting))
			{
				m_framework.awh.method_13().AddChannelToLoggingList(setting, setting.method_94() - 1);
			}
			else
			{
				m_framework.awh.method_13().RemoveChannelFromLoggingList(setting);
			}
		}
	}

	internal void method_43()
	{
		aYy = true;
		if (m_conditionsChangedOnLastEvaluation)
		{
			method_42();
			m_conditionsChangedOnLastEvaluation = false;
		}
	}

	internal void method_44()
	{
		aYy = false;
	}

	protected virtual bool EvaluateEnableOnConditions(bool initInfluencingSettingIdsList)
	{
		bool result = false;
		bool flag = false;
		if (m_currentEnableOns.Count == 0)
		{
			m_currentEnableOn = true;
		}
		else
		{
			for (int i = 0; i < m_currentEnableOns.Count; i++)
			{
				string string_ = m_currentEnableOns[i].BrL;
				List<int> list = Class37.smethod_0(ref string_, m_framework);
				if (initInfluencingSettingIdsList)
				{
					for (int j = 0; j < list.Count; j++)
					{
						m_dataIdsInEnableOnEquations.Add(list[j]);
						Setting setting = m_framework.method_31(list[j]);
						if (this is SpecialObject)
						{
							setting.method_133().Add(m_objectId);
						}
					}
				}
				bool flag2 = Class37.smethod_10(ref string_);
				flag |= flag2;
			}
			result = m_currentEnableOn != flag;
			m_currentEnableOn = flag;
		}
		return result;
	}

	protected virtual bool EvaluateCondPropertiesConditions(bool initInfluencingSettingIdsList)
	{
		bool flag = m_conditionsPreviouslyMetPerCondPropertiesBlock.Count == 0 && m_condPropertiesBlocks.Count != 0;
		RevertAllConditionalPropertiesToDefaults();
		for (int i = 0; i < m_condPropertiesBlocks.Count; i++)
		{
			string string_ = m_condPropertiesBlocks[i].BrK;
			List<int> list = Class37.smethod_0(ref string_, m_framework);
			if (initInfluencingSettingIdsList)
			{
				for (int j = 0; j < list.Count; j++)
				{
					m_dataIdsInCondPropsEquations.Add(list[j]);
					Setting setting = m_framework.method_31(list[j]);
					if (this is SpecialObject)
					{
						setting.method_133().Add(m_objectId);
					}
					else if (this is Setting)
					{
						setting.method_132().Add((this as Setting).method_69());
					}
				}
			}
			bool flag2 = Class37.smethod_10(ref string_);
			if (!flag && flag2 != m_conditionsPreviouslyMetPerCondPropertiesBlock[i])
			{
				flag = true;
			}
			if (m_conditionsPreviouslyMetPerCondPropertiesBlock.Count <= i)
			{
				m_conditionsPreviouslyMetPerCondPropertiesBlock.Add(flag2);
			}
			else
			{
				m_conditionsPreviouslyMetPerCondPropertiesBlock[i] = flag2;
			}
			if (flag2)
			{
				UpdateConditionalPropertiesValues(0, i);
			}
		}
		return flag;
	}

	[SpecialName]
	internal MenuNode method_45()
	{
		return m_isTargetObjectForMenuNode;
	}

	[SpecialName]
	internal void method_46(MenuNode menuNode_0)
	{
		m_isTargetObjectForMenuNode = menuNode_0;
	}

	[SpecialName]
	internal string method_47()
	{
		return m_disclaimer;
	}

	[SpecialName]
	internal void method_48(string string_0)
	{
		m_disclaimer = string_0;
	}

	[SpecialName]
	internal bool method_49()
	{
		return m_disclaimerShowEveryTime;
	}

	[SpecialName]
	internal void method_50(bool bool_0)
	{
		m_disclaimerShowEveryTime = bool_0;
	}

	internal void method_51(string string_0)
	{
		m_associatedDTCs.Add(string_0);
	}

	internal List<string> method_52()
	{
		return m_associatedDTCs;
	}

	[SpecialName]
	internal string method_53()
	{
		return m_dtc;
	}

	[SpecialName]
	internal void method_54(string string_0)
	{
		m_dtc = string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal string method_55()
	{
		return aYZ;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_56(string string_0)
	{
		aYZ = string_0;
	}

	[SpecialName]
	internal int method_57()
	{
		return m_objectId;
	}

	[SpecialName]
	internal void method_58(int int_0)
	{
		m_objectId = int_0;
	}

	internal void method_59(Enum96 enum96_0, string string_0, int int_0)
	{
		m_stringProperties[(int)enum96_0].method_0(string_0, int_0);
	}

	internal string method_60(Enum96 enum96_0)
	{
		return m_stringProperties[(int)enum96_0].BrM;
	}

	internal string method_61()
	{
		if (m_parentSettingOrSpecialObject is Class243)
		{
			Class243 @class = m_parentSettingOrSpecialObject as Class243;
			Class250 class2 = @class.method_6() as Class250;
			string text = class2.method_18();
			string text2 = @class.method_18();
			string text3 = Class333.aoF();
			text3 = (string.IsNullOrWhiteSpace(text) ? (text3 + Class333.aof() + (m_framework.awP.method_79().IndexOf(class2) + 1) + Class333.smethod_536()) : (text3 + text + Class333.smethod_536()));
			text3 = (string.IsNullOrWhiteSpace(text2) ? (text3 + Class333.aoG() + (class2.method_72().IndexOf(@class) + 1) + Class333.smethod_536()) : (text3 + text2 + Class333.smethod_536()));
			return text3 + method_22(bool_0: false);
		}
		return method_60(Enum96.aYt);
	}

	[SpecialName]
	internal string method_62()
	{
		return m_inputType;
	}

	[SpecialName]
	internal void method_63(string string_0)
	{
		m_inputType = string_0;
	}

	internal static bool smethod_0(Framework framework_0, List<SettingOrSpecialObject> list_0, int int_0, int int_1, bool bool_0 = true)
	{
		if (int_0 == int_1)
		{
			return true;
		}
		if (int_0 >= 0 && int_0 < list_0.Count)
		{
			if (int_1 >= 0 && int_1 < list_0.Count)
			{
				Class280 @class = Form23.smethod_95();
				if (bool_0)
				{
					@class?.method_1();
					framework_0.method_55();
				}
				SettingOrSpecialObject settingOrSpecialObject_ = list_0[int_0];
				List<List<int>> list_1 = new List<List<int>>();
				smethod_2(settingOrSpecialObject_, list_1);
				if (int_0 > int_1)
				{
					for (int num = int_0; num > int_1; num--)
					{
						list_0[num].method_29(list_0[num - 1], bool_0: true);
					}
					int int_2 = 0;
					smethod_3(list_0[int_1], list_1, ref int_2, bool_0: true);
				}
				else if (int_0 < int_1)
				{
					for (int i = int_0; i < Math.Min(int_1, list_0.Count - 2); i++)
					{
						list_0[i].method_29(list_0[i + 1], bool_0: true);
					}
					int int_3 = 0;
					smethod_3(list_0[int_1], list_1, ref int_3, bool_0: true);
				}
				if (bool_0)
				{
					framework_0.method_54(bool_0: true);
					@class?.method_4();
				}
				for (int j = Math.Min(int_0, int_1); j <= Math.Max(int_1, int_0); j++)
				{
					smethod_1(list_0[j]);
				}
				return true;
			}
			return false;
		}
		return false;
	}

	internal static void smethod_1(SettingOrSpecialObject settingOrSpecialObject_0)
	{
		if (settingOrSpecialObject_0 is Setting)
		{
			Form23.smethod_74((settingOrSpecialObject_0 as Setting).method_64());
		}
		foreach (SettingOrSpecialObject item in settingOrSpecialObject_0.method_1())
		{
			smethod_1(item);
		}
	}

	internal static void smethod_2(SettingOrSpecialObject settingOrSpecialObject_0, List<List<int>> list_0)
	{
		if (settingOrSpecialObject_0 is Setting)
		{
			Setting setting = settingOrSpecialObject_0 as Setting;
			int num = setting.method_277();
			List<int> list = new List<int>(num);
			for (int i = 0; i < num; i++)
			{
				list.Add(setting.method_258(i));
			}
			list_0.Add(list);
		}
		foreach (SettingOrSpecialObject item in settingOrSpecialObject_0.method_1())
		{
			smethod_2(item, list_0);
		}
	}

	internal static void smethod_3(SettingOrSpecialObject settingOrSpecialObject_0, List<List<int>> list_0, ref int int_0, bool bool_0)
	{
		if (settingOrSpecialObject_0 is Setting)
		{
			Setting setting = settingOrSpecialObject_0 as Setting;
			List<int> list = list_0[int_0];
			for (int i = 0; i < list.Count; i++)
			{
				setting.method_274(i, list[i], bool_0);
			}
			int_0++;
		}
		foreach (SettingOrSpecialObject item in settingOrSpecialObject_0.method_1())
		{
			smethod_3(item, list_0, ref int_0, bool_0);
		}
	}
}
