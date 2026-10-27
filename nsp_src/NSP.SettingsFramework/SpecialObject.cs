using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;

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

	internal SpecialObject(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
	}

	public virtual string ToString()
	{
		string brM = m_stringProperties[1].BrM;
		if (brM != null)
		{
			return brM + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEh();
		}
		return m_internalName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEh();
	}

	[SpecialName]
	internal new Connector A()
	{
		if (m_connector == null)
		{
			m_connector = new Connector();
		}
		return m_connector;
	}

	[SpecialName]
	internal new WiringPin a()
	{
		if (m_wiringPin == null)
		{
			m_wiringPin = new WiringPin(m_framework, this);
		}
		return m_wiringPin;
	}

	[SpecialName]
	internal new UIListObject B()
	{
		if (m_uiListObject == null)
		{
			m_uiListObject = new UIListObject(m_framework, this);
		}
		return m_uiListObject;
	}

	[SpecialName]
	internal new IndexedList b()
	{
		if (m_indexedList == null)
		{
			m_indexedList = new IndexedList(m_framework, this);
		}
		return m_indexedList;
	}

	[SpecialName]
	internal new ApplyAndExecuteProcess C()
	{
		if (m_applyAndExecuteProcess == null)
		{
			m_applyAndExecuteProcess = new ApplyAndExecuteProcess(m_framework, this);
		}
		return m_applyAndExecuteProcess;
	}

	[SpecialName]
	internal new ConditionalActivator c()
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
		B().CurrentUIListSettingsIdsAndIndents.Clear();
		for (int i = 0; i < B().DefaultUIListSettingsIdsAndIndents.Count; i++)
		{
			B().CurrentUIListSettingsIdsAndIndents.Add(B().DefaultUIListSettingsIdsAndIndents[i]);
		}
		a().D();
	}

	protected override void UpdateConditionalPropertiesValues(int cellIndex, int condPropertiesBlockIndex)
	{
		base.UpdateConditionalPropertiesValues(cellIndex, condPropertiesBlockIndex);
		if (cellIndex != 0)
		{
			return;
		}
		if (B().ExtraUIListSettingsIdsAndIndentsPerCondProps.ContainsKey(condPropertiesBlockIndex))
		{
			List<UIListSettingDataIdAndIndent> val = B().ExtraUIListSettingsIdsAndIndentsPerCondProps[condPropertiesBlockIndex];
			for (int i = 0; i < val.Count; i++)
			{
				B().CurrentUIListSettingsIdsAndIndents.Add(val[i]);
			}
		}
		a().A(condPropertiesBlockIndex);
	}

	internal void A(int P_0, int P_1, bool P_2, bool P_3, int P_4, string P_5)
	{
		UIListSettingDataIdAndIndent uIListSettingDataIdAndIndent = default(UIListSettingDataIdAndIndent);
		uIListSettingDataIdAndIndent.DataId = P_0;
		uIListSettingDataIdAndIndent.Indent = P_1;
		uIListSettingDataIdAndIndent.PlacePartialMapSearchableListDirectlyOnPanel = P_2;
		uIListSettingDataIdAndIndent.PlacePartialMapImageGalleryDirectlyOnPanel = P_3;
		if (P_4 == -1)
		{
			B().DefaultUIListSettingsIdsAndIndents.Add(uIListSettingDataIdAndIndent);
			B().CurrentUIListSettingsIdsAndIndents.Add(uIListSettingDataIdAndIndent);
			BrP = string.Empty;
			return;
		}
		if (P_5 != BrP)
		{
			B().ExtraUIListSettingsIdsAndIndentsPerCondProps.Add(P_4, new List<UIListSettingDataIdAndIndent>());
			BrP = P_5;
		}
		B().ExtraUIListSettingsIdsAndIndentsPerCondProps[P_4].Add(uIListSettingDataIdAndIndent);
	}
}
