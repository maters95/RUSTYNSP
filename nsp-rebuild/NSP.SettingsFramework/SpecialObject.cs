using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns7;

namespace NSP.SettingsFramework;

public class SpecialObject : SettingOrSpecialObject
{
	protected Connector m_connector;

	protected WiringPin m_wiringPin;

	protected UIListObject m_uiListObject;

	protected IndexedList m_indexedList;

	protected ApplyAndExecuteProcess m_applyAndExecuteProcess;

	protected ConditionalActivator m_conditionalActivator;

	private string BrP = string.Empty;

	internal SpecialObject(Framework framework_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
	}

	public override string ToString()
	{
		string brM = m_stringProperties[1].BrM;
		if (brM != null)
		{
			return brM + Class333.BEh();
		}
		return m_internalName + Class333.BEh();
	}

	[SpecialName]
	internal Connector method_64()
	{
		if (m_connector == null)
		{
			m_connector = new Connector();
		}
		return m_connector;
	}

	[SpecialName]
	internal WiringPin method_65()
	{
		if (m_wiringPin == null)
		{
			m_wiringPin = new WiringPin(m_framework, this);
		}
		return m_wiringPin;
	}

	[SpecialName]
	internal UIListObject method_66()
	{
		if (m_uiListObject == null)
		{
			m_uiListObject = new UIListObject(m_framework, this);
		}
		return m_uiListObject;
	}

	[SpecialName]
	internal IndexedList method_67()
	{
		if (m_indexedList == null)
		{
			m_indexedList = new IndexedList(m_framework, this);
		}
		return m_indexedList;
	}

	[SpecialName]
	internal ApplyAndExecuteProcess method_68()
	{
		if (m_applyAndExecuteProcess == null)
		{
			m_applyAndExecuteProcess = new ApplyAndExecuteProcess(m_framework, this);
		}
		return m_applyAndExecuteProcess;
	}

	[SpecialName]
	internal ConditionalActivator method_69()
	{
		if (m_conditionalActivator == null)
		{
			m_conditionalActivator = new ConditionalActivator(m_framework, this);
		}
		return m_conditionalActivator;
	}

	protected override void RevertAllConditionalPropertiesToDefaults()
	{
		base.RevertAllConditionalPropertiesToDefaults();
		method_66().CurrentUIListSettingsIdsAndIndents.Clear();
		for (int i = 0; i < method_66().DefaultUIListSettingsIdsAndIndents.Count; i++)
		{
			method_66().CurrentUIListSettingsIdsAndIndents.Add(method_66().DefaultUIListSettingsIdsAndIndents[i]);
		}
		method_65().method_8();
	}

	protected override void UpdateConditionalPropertiesValues(int cellIndex, int condPropertiesBlockIndex)
	{
		base.UpdateConditionalPropertiesValues(cellIndex, condPropertiesBlockIndex);
		if (cellIndex != 0)
		{
			return;
		}
		if (method_66().ExtraUIListSettingsIdsAndIndentsPerCondProps.ContainsKey(condPropertiesBlockIndex))
		{
			List<UIListSettingDataIdAndIndent> list = method_66().ExtraUIListSettingsIdsAndIndentsPerCondProps[condPropertiesBlockIndex];
			for (int i = 0; i < list.Count; i++)
			{
				method_66().CurrentUIListSettingsIdsAndIndents.Add(list[i]);
			}
		}
		method_65().method_9(condPropertiesBlockIndex);
	}

	internal void method_70(int int_0, int int_1, bool bool_0, bool bool_1, int int_2, string string_0)
	{
		UIListSettingDataIdAndIndent item = new UIListSettingDataIdAndIndent
		{
			DataId = int_0,
			Indent = int_1,
			PlacePartialMapSearchableListDirectlyOnPanel = bool_0,
			PlacePartialMapImageGalleryDirectlyOnPanel = bool_1
		};
		if (int_2 == -1)
		{
			method_66().DefaultUIListSettingsIdsAndIndents.Add(item);
			method_66().CurrentUIListSettingsIdsAndIndents.Add(item);
			BrP = string.Empty;
			return;
		}
		if (string_0 != BrP)
		{
			method_66().ExtraUIListSettingsIdsAndIndentsPerCondProps.Add(int_2, new List<UIListSettingDataIdAndIndent>());
			BrP = string_0;
		}
		method_66().ExtraUIListSettingsIdsAndIndentsPerCondProps[int_2].Add(item);
	}
}
