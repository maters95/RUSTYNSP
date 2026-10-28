using System.Collections.Generic;
using NSP.SettingsFramework;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns3;

internal class Class244 : Setting
{
	internal Class244(Framework framework_0, string string_0, int int_0, int int_1, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, bool_0: false, string_0, int_0, int_1, settingOrSpecialObject_0, string_1)
	{
	}

	internal void method_294()
	{
		MenuNode menuNode = MenuNode.smethod_2(m_framework.awj, m_dataIdAndAttrId);
		if (menuNode == null)
		{
			return;
		}
		MenuNode menuNode2 = menuNode.method_83(this);
		if (menuNode2 == null)
		{
			return;
		}
		Class286 bcF = menuNode2.method_80().BcF;
		List<Setting> list = new List<Setting>();
		PortFunction.smethod_31(this, list, bool_0: true);
		foreach (Setting item in list)
		{
			int[] array = bcF.method_3(item);
			if (array != null)
			{
				item.method_276(array, bool_0: true);
				Form23.smethod_74(item.method_64());
			}
		}
		List<Table> list2 = new List<Table>();
		PortFunction.smethod_34(this, list2, bool_0: true);
		foreach (Table item2 in list2)
		{
			foreach (DataIdAndAttrId item3 in item2.GetIdsContained())
			{
				Setting setting = m_framework.method_32(item3);
				if (setting != null)
				{
					int[] array2 = bcF.method_3(setting);
					if (array2 != null)
					{
						setting.method_276(array2, bool_0: true);
						Form23.smethod_74(setting.method_64());
					}
				}
			}
		}
	}

	internal void method_295(ref bool bool_0)
	{
		bool flag = m_currentEnableOn;
		bool flag2 = m_currentEnableOn;
		int num = 0;
		int bbC = method_12().BbC;
		if (bbC != 0)
		{
			Setting setting = m_framework.method_31(bbC);
			if (setting != null)
			{
				flag2 = (flag = setting.method_35() && setting.method_256() == 1);
				num = setting.method_4();
			}
		}
		else if (m_parentSettingOrSpecialObject != null && m_parentSettingOrSpecialObject is SpecialObject)
		{
			for (int i = 0; i < m_parentSettingOrSpecialObject.method_1().Count; i++)
			{
				if (m_parentSettingOrSpecialObject.method_1()[i] is Setting setting2 && setting2.method_150())
				{
					flag2 = (flag = setting2.method_256() == 1);
					num = m_parentObjectId;
					break;
				}
			}
		}
		if (num != 0 && m_framework.aWy.ContainsKey(num))
		{
			SettingOrSpecialObject settingOrSpecialObject = m_framework.method_33(m_framework.aWy[num]);
			if (settingOrSpecialObject != null)
			{
				for (int j = 0; j < settingOrSpecialObject.method_1().Count; j++)
				{
					if (settingOrSpecialObject.method_1()[j] is Setting setting3 && setting3.method_150())
					{
						flag = setting3.method_256() == 1;
						break;
					}
				}
			}
		}
		string text = method_60(Enum96.aYv);
		if (string.IsNullOrEmpty(text))
		{
			text = method_60(Enum96.aYu);
		}
		string text2 = (string.IsNullOrEmpty(text) ? method_60(Enum96.aYt) : text);
		uint num2 = (uint)method_256();
		if (m_currentEnableOn & flag & flag2)
		{
			if (num2 == 0)
			{
				if (m_currentlyIsLegal)
				{
					bool_0 = true;
					m_currentlyIsLegal = false;
				}
				m_currentIllegalityTexts.Add(Class333.BIV() + text2 + Class333.BIv());
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				m_currentIllegalityCanHighlightNode = true;
				return;
			}
			Enum104 enum104_ = PortFunction.smethod_12(num2);
			Enum105 enum105_ = PortFunction.smethod_13(num2);
			byte byte_ = PortFunction.smethod_14(num2);
			ushort ushort_ = PortFunction.smethod_15(num2);
			bool bool_1 = false;
			if (method_298(enum104_, enum105_, byte_, ushort_, ref bool_1))
			{
				if (m_currentlyIsLegal)
				{
					bool_0 = true;
					m_currentlyIsLegal = false;
				}
				if (bool_1)
				{
					m_currentIllegalityTexts.Add(Class333.BIV() + text2 + Class333.BIW());
				}
				else
				{
					m_currentIllegalityTexts.Add(Class333.BIV() + text2 + Class333.BIw());
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				m_currentIllegalityCanHighlightNode = true;
				return;
			}
			bool bool_2 = false;
			foreach (SettingOrSpecialObject item in method_1())
			{
				if (item is FilterOption)
				{
					FilterOption filterOption = item as FilterOption;
					if (filterOption.method_74() && filterOption.method_71())
					{
						bool_2 = true;
						break;
					}
				}
			}
			if (!method_296(text2, bool_2, enum104_, enum105_, byte_, ushort_, ref bool_0))
			{
				SettingOrSpecialObject settingOrSpecialObject2 = PortFunction.smethod_36(m_framework, enum104_, enum105_, byte_, ushort_);
				if (settingOrSpecialObject2 != null)
				{
					method_297(settingOrSpecialObject2, ref bool_0);
				}
			}
		}
		else if (flag)
		{
			if (num2 != 0)
			{
				if (m_currentlyIsLegal)
				{
					bool_0 = true;
					m_currentlyIsLegal = false;
				}
				m_currentIllegalityTexts.Add(Class333.BIV() + text2 + Class333.BIX());
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				m_currentIllegalityCanHighlightNode = true;
			}
			else
			{
				if (!m_currentlyIsLegal)
				{
					bool_0 = true;
					m_currentlyIsLegal = true;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.None;
				m_currentIllegalityCanHighlightNode = false;
			}
		}
		else
		{
			if (!m_currentlyIsLegal)
			{
				bool_0 = true;
				m_currentlyIsLegal = true;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.None;
			m_currentIllegalityCanHighlightNode = false;
		}
	}

	private bool method_296(string string_0, bool bool_0, Enum104 enum104_0, Enum105 enum105_0, byte byte_0, ushort ushort_0, ref bool bool_1)
	{
		bool flag = false;
		if (!bool_0)
		{
			List<WiringPin> list = WiringPin.smethod_0(m_framework, enum104_0, enum105_0, byte_0, ushort_0);
			int num = 0;
			do
			{
				Class244 @class = m_framework.awd[num];
				if (@class != this && @class.method_35())
				{
					bool flag2 = true;
					int bbC = @class.method_12().BbC;
					if (bbC != 0)
					{
						Setting setting = m_framework.method_31(bbC);
						if (setting != null)
						{
							flag2 = setting.method_256() == 1;
						}
					}
					if (flag2)
					{
						uint num2 = (uint)@class.method_256();
						if (num2 != 0)
						{
							Enum104 enum104_1 = PortFunction.smethod_12(num2);
							Enum105 enum105_1 = PortFunction.smethod_13(num2);
							byte byte_1 = PortFunction.smethod_14(num2);
							ushort ushort_1 = PortFunction.smethod_15(num2);
							foreach (WiringPin item in WiringPin.smethod_0(m_framework, enum104_1, enum105_1, byte_1, ushort_1))
							{
								if (!list.Contains(item))
								{
									continue;
								}
								flag = true;
								string text = @class.method_60(Enum96.aYv);
								if (text == null || text.Length == 0)
								{
									text = @class.method_60(Enum96.aYu);
								}
								string text2 = ((text == null || text.Length == 0) ? @class.method_60(Enum96.aYt) : text);
								string text3 = string.Empty;
								if (@class.method_4() != -1)
								{
									SettingOrSpecialObject settingOrSpecialObject = m_framework.method_33(@class.method_4());
									if (settingOrSpecialObject != null)
									{
										string text4 = settingOrSpecialObject.method_60(Enum96.aYt);
										if (string.IsNullOrEmpty(text4))
										{
											text4 = settingOrSpecialObject.method_60(Enum96.aYu);
										}
										if (string.IsNullOrEmpty(text4))
										{
											text4 = settingOrSpecialObject.method_60(Enum96.aYT);
										}
										string text5 = settingOrSpecialObject.method_18();
										if (!string.IsNullOrWhiteSpace(text5))
										{
											text4 = text5 + Class333.smethod_497() + text4 + Class333.smethod_9();
										}
										text3 = Class333.BIx() + text4 + Class333.smethod_1394();
									}
								}
								if (m_currentlyIsLegal)
								{
									bool_1 = true;
									m_currentlyIsLegal = false;
								}
								m_currentIllegalityTexts.Add(Class333.BIV() + string_0 + Class333.BIY() + text2 + Class333.smethod_1394() + text3);
								m_currentSeverityLevel = IllegalitySeverityLevel.Error;
								m_currentIllegalityCanHighlightNode = true;
								break;
							}
						}
					}
				}
				num++;
			}
			while (!flag && num < m_framework.awd.Count);
			if (!flag)
			{
				string text6 = PortFunction.smethod_47(m_framework, enum104_0, enum105_0, byte_0, ushort_0);
				if (text6 != null)
				{
					flag = true;
					if (m_currentlyIsLegal)
					{
						bool_1 = true;
						m_currentlyIsLegal = false;
					}
					m_currentIllegalityTexts.Add(Class333.BIV() + string_0 + Class333.BIY() + text6 + Class333.smethod_1394());
					m_currentSeverityLevel = IllegalitySeverityLevel.Error;
					m_currentIllegalityCanHighlightNode = true;
				}
			}
		}
		if (!flag)
		{
			if (!m_currentlyIsLegal)
			{
				bool_1 = true;
				m_currentlyIsLegal = true;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.None;
			m_currentIllegalityCanHighlightNode = false;
		}
		return flag;
	}

	private void method_297(SettingOrSpecialObject settingOrSpecialObject_0, ref bool bool_0)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < settingOrSpecialObject_0.method_12().method_1().Count; i++)
		{
			Setting setting = settingOrSpecialObject_0.method_12().method_1()[i];
			if (!setting.method_35() || !PortFunction.smethod_52(setting))
			{
				continue;
			}
			int num = setting.method_256();
			if (m_framework.awg.ContainsKey(num) && !list.Contains(num))
			{
				list.Add(num);
				if (m_currentlyIsLegal)
				{
					bool_0 = true;
					m_currentlyIsLegal = false;
				}
				m_currentIllegalityTexts.Add(m_framework.awg[num]);
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				m_currentIllegalityCanHighlightNode = true;
			}
		}
	}

	private bool method_298(Enum104 enum104_0, Enum105 enum105_0, byte byte_0, ushort ushort_0, ref bool bool_0)
	{
		bool_0 = true;
		bool flag = false;
		for (int i = 0; i < m_framework.awD.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = m_framework.awD[i];
			Enum104 bSQ = settingOrSpecialObject.method_12().method_12().BSQ;
			Enum105 bSq = settingOrSpecialObject.method_12().method_12().BSq;
			byte bSR = settingOrSpecialObject.method_12().method_12().BSR;
			ushort bSr = settingOrSpecialObject.method_12().method_12().BSr;
			if (bSQ == Enum104.BAM)
			{
				if (bSQ == enum104_0 && bSq == enum105_0 && bSr == ushort_0)
				{
					bool_0 = false;
					if (!settingOrSpecialObject.method_35())
					{
						flag = true;
					}
					break;
				}
			}
			else if (bSQ == enum104_0 && bSq == enum105_0 && bSR == byte_0)
			{
				bool_0 = false;
				if (!settingOrSpecialObject.method_35())
				{
					flag = true;
				}
				break;
			}
		}
		return flag | bool_0;
	}
}
