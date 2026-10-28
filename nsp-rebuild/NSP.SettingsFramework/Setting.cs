using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns0;
using ns1;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class Setting : SettingOrSpecialObject
{
	public struct MultiCellCondition
	{
		internal string BYg;

		internal int BYH;

		internal int BYh;

		internal int BYI;
	}

	internal enum Enum95
	{
		BYi = -1,
		BYJ,
		BYj,
		BYK
	}

	internal struct Struct44
	{
		internal int BYk;

		internal Enum95 BYL;
	}

	public struct ValueSupplier
	{
		internal int BYl;

		internal string BYM;
	}

	public class ListItems
	{
		internal struct Struct45
		{
			internal string bBu;

			internal string bBV;

			internal int bBv;

			internal int bBW;

			internal string bBw;

			internal string bBX;

			internal string bBx;
		}

		internal List<List<Struct45>> BYm = new List<List<Struct45>>();

		internal List<Struct45> BYN = new List<Struct45>();

		internal Dictionary<int, List<Struct45>> BYn = new Dictionary<int, List<Struct45>>();
	}

	public class ValDescs
	{
		internal struct Struct46
		{
			internal string bBY;

			internal string bBy;

			internal int bBZ;
		}

		internal List<List<Struct46>> BYO = new List<List<Struct46>>();

		internal List<Struct46> BYo = new List<Struct46>();

		internal Dictionary<int, List<Struct46>> BYP = new Dictionary<int, List<Struct46>>();
	}

	public class MaskItems
	{
		internal struct Struct47
		{
			internal string bBz;

			internal string bbA;

			internal int bba;

			internal int bbB;
		}

		internal List<List<Struct47>> BYp = new List<List<Struct47>>();

		internal List<Struct47> BYQ = new List<Struct47>();

		internal Dictionary<int, List<Struct47>> BYq = new Dictionary<int, List<Struct47>>();
	}

	protected class LegalOn
	{
		internal string BYR;

		internal string BYr;

		internal IllegalitySeverityLevel BYS;

		internal bool BYs;

		internal int BYT;

		internal LegalOn(string string_0, string string_1, IllegalitySeverityLevel illegalitySeverityLevel_0, bool bool_0, int int_0)
		{
			BYR = string_0;
			BYr = string_1;
			BYS = illegalitySeverityLevel_0;
			BYs = bool_0;
			BYT = int_0;
		}
	}

	protected class IntProperty
	{
		internal bool BYt;

		internal int BYU;

		internal int BYu;

		internal Dictionary<int, int> BYV;

		internal bool BYv;

		internal bool BYW;

		internal Dictionary<int, bool> BYw;

		internal string BYX;

		internal string BYx;

		internal Dictionary<int, string> BYY;

		private List<int> BYy = new List<int>();

		internal IntProperty()
		{
			BYV = new Dictionary<int, int>();
			BYw = new Dictionary<int, bool>();
			BYY = new Dictionary<int, string>();
		}

		internal void method_0(int int_0, bool bool_0, string string_0, int int_1)
		{
			if (int_1 == -1)
			{
				BYu = int_0;
				BYU = int_0;
				BYW = bool_0;
				BYv = bool_0;
				BYx = string_0;
				BYX = string_0;
			}
			else
			{
				if (!BYy.Contains(int_1))
				{
					BYV.Add(int_1, int_0);
					BYw.Add(int_1, bool_0);
					BYY.Add(int_1, string_0);
				}
				BYy.Add(int_1);
			}
			BYt = true;
		}

		internal int method_1(Framework framework_0)
		{
			if (BYv)
			{
				Setting setting = framework_0.method_31(BYU);
				if (setting == null)
				{
					return 0;
				}
				if (BYX == Class333.aJn())
				{
					return setting.method_215(Enum94.aYl);
				}
				if (BYX == Class333.aJO())
				{
					return setting.method_215(Enum94.aYM);
				}
				if (BYX == Class333.ais())
				{
					return setting.method_215(Enum94.aYm);
				}
				if (BYX == Class333.aiT())
				{
					return setting.method_215(Enum94.aYN);
				}
				if (BYX == Class333.aJo())
				{
					return setting.method_215(Enum94.aYn);
				}
				if (BYX == Class333.ain())
				{
					return setting.method_215(Enum94.aYO);
				}
				if (BYX == Class333.aio())
				{
					return setting.method_215(Enum94.aYP);
				}
				if (BYX == Class333.aJh())
				{
					return setting.method_215(Enum94.aYp);
				}
				if (BYX == Class333.aJC())
				{
					return setting.method_215(Enum94.aYR);
				}
				if (BYX == Class333.aJc())
				{
					return setting.method_215(Enum94.aYr);
				}
				return setting.method_256();
			}
			return BYU;
		}

		public override string ToString()
		{
			return BYU.ToString();
		}
	}

	protected int m_dataId;

	protected int m_byteAddress;

	protected bool m_isAttribute;

	protected int m_attributeId;

	protected DataIdAndAttrId m_dataIdAndAttrId;

	protected string m_metaDataString = string.Empty;

	protected int m_numBytesPerCell;

	protected bool m_valuesAreSigned;

	protected int[] m_dimensionsSliceRowCol = new int[3];

	protected int m_visibleDimensions;

	protected byte[] m_defaultDataBytes;

	protected int m_encoding;

	protected bool m_noImport;

	protected int m_templatedSettingType;

	protected bool m_partialMapSettingAlwaysShow;

	protected bool m_partialMapSettingShowOffset;

	protected string m_partialMapSettingNameWhenShowingOffset;

	protected string m_partialMapSettingHelpDescWhenShowingOffset;

	protected bool m_partialMapSettingOffsetAllowWrap;

	protected bool m_isPortFunctionEnabler;

	protected MenuNode m_isFunctionEnablerForMenuNode;

	protected bool m_firmwareCanModify;

	protected int m_scopeFixedScaleValue;

	protected int m_scopeFixedScaleOrder;

	protected string m_scopeChannelSelectionWarning;

	protected int m_recommendedLoggingGroupNumber;

	protected bool m_includedInPasswordProtection = true;

	protected List<ConvertFrom> m_convertFromsList = new List<ConvertFrom>();

	protected List<ConvertTo> m_convertTosList = new List<ConvertTo>();

	protected List<bool[]> m_conditionsPreviouslyMetPerCellPerCondPropertiesBlock = new List<bool[]>();

	protected List<MultiCellCondition> m_multiCellEnableOnConditions = new List<MultiCellCondition>();

	protected bool[,,] m_currentMultiCellEnableOnSliceRowCol;

	protected List<LegalOn> m_allLegalOns = new List<LegalOn>();

	protected List<LegalOn> m_currentLegalOns = new List<LegalOn>();

	protected bool m_currentlyIsLegal = true;

	protected List<string> m_currentIllegalityTexts = new List<string>();

	protected List<string> m_previousIllegalityTexts = new List<string>();

	protected IllegalitySeverityLevel m_currentSeverityLevel;

	protected bool m_currentIllegalityCanHighlightNode;

	protected List<HashSet<int>> m_dataIdsInIllegalityEquations = new List<HashSet<int>>();

	protected HashSet<DataIdAndAttrId> m_idsWithEquationsAffectedByThisSetting = new HashSet<DataIdAndAttrId>();

	protected HashSet<int> m_objectIdsWithEquationsAffectedByThisSetting = new HashSet<int>();

	protected HashSet<FilterOption> m_filterOptionsWithEquationsAffectedByThisSetting = new HashSet<FilterOption>();

	protected int m_fixedAxisType = -1;

	protected IntProperty[] m_intProperties = new IntProperty[15];

	protected ListItems m_listItems = new ListItems();

	protected MaskItems m_maskItems = new MaskItems();

	protected string m_maskJoinText;

	protected bool m_listOrder;

	protected ValDescs m_valDescs = new ValDescs();

	private List<Struct44> BrH = new List<Struct44>();

	protected int m_unitsOrder;

	protected bool m_useFixedValue;

	protected List<int> m_fixedValue = new List<int>();

	protected int m_terminatingValue;

	protected bool m_isEnabler;

	protected byte m_enablesExternalDevice;

	protected List<byte> m_deviceIdCanBeChangedTo;

	protected string m_helpPath;

	protected ValueSupplier m_valueSupplier;

	protected int m_dataIdOfSettingContainingChannelIdForMinMaxAndUnits;

	protected bool m_isConditionalActivatorChannelSelector;

	protected bool m_isChannelSelector;

	protected int m_channelSelectorApplyChannelNameToSettingId;

	protected DataIdAndAttrId m_idOfSettingContainingDisplayUnits = new DataIdAndAttrId(0, 0);

	protected bool m_isColourPicker;

	protected List<string> m_isResourcePickerForTheseFileExtensions;

	private Class1.Enum5 Brh;

	protected bool m_isResourcePickerForSplashScreen;

	protected Size m_isResourcePickerForFixedResolution;

	protected int m_isResourcePickerForFixedBitDepth;

	protected int m_dataIdOfResourceCRCSetting;

	protected bool m_userSearchable = true;

	protected int m_attrIdToOverride;

	protected int m_dataIdOfAttrOverrideEnabler;

	protected int m_attrOverrideChanSelectorSettingId;

	protected int m_attrOverrideChanId;

	[CompilerGenerated]
	private EventHandler BrI;

	private bool Bri = true;

	private int[] BrJ;

	internal Setting(Framework framework_0, bool bool_0, string string_0, int int_0, int int_1, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
		m_isAttribute = bool_0;
		if (bool_0)
		{
			m_attributeId = int_0;
			m_dataId = m_parentDataId;
		}
		else
		{
			m_dataId = int_0;
			m_attributeId = 0;
		}
		m_dataIdAndAttrId = new DataIdAndAttrId(m_dataId, m_attributeId);
		m_dimensionsSliceRowCol[0] = 1;
		m_dimensionsSliceRowCol[1] = 1;
		m_dimensionsSliceRowCol[2] = 1;
		m_numBytesPerCell = 2;
		m_valuesAreSigned = true;
		for (int i = 0; i < 15; i++)
		{
			m_intProperties[i] = new IntProperty();
		}
		if (settingOrSpecialObject_0 != null && settingOrSpecialObject_0 is Table && m_internalName == Class333.smethod_796())
		{
			m_intProperties[8].method_0((settingOrSpecialObject_0 as Table).method_231(), bool_0: false, null, -1);
		}
		method_213(Enum94.aYL, 199, bool_0: false, Class333.smethod_102(), -1);
		m_byteAddress = int_1;
	}

	public override string ToString()
	{
		string brM = m_stringProperties[1].BrM;
		string text = ((brM == null) ? m_internalName : brM);
		if (method_207())
		{
			text += Class333.BdH();
		}
		text = text + Class333.Bdh() + m_dataId + Class333.atC() + m_attributeId + Class333.BdI() + m_byteAddress;
		if (m_encoding != 0)
		{
			string text2 = method_260();
			return text + Class333.Bdi() + text2 + Class333.smethod_180();
		}
		int num = method_256();
		return text + Class333.BdJ() + num;
	}

	[SpecialName]
	internal int method_64()
	{
		return m_dataId;
	}

	[SpecialName]
	internal int method_65()
	{
		return m_byteAddress;
	}

	[SpecialName]
	internal void method_66(int int_0)
	{
		m_byteAddress = int_0;
	}

	[SpecialName]
	internal int method_67()
	{
		return m_attributeId;
	}

	[SpecialName]
	internal bool method_68()
	{
		return m_isAttribute;
	}

	[SpecialName]
	internal DataIdAndAttrId method_69()
	{
		return m_dataIdAndAttrId;
	}

	[SpecialName]
	internal int method_70()
	{
		return m_encoding;
	}

	[SpecialName]
	internal void method_71(int int_0)
	{
		m_encoding = int_0;
	}

	[SpecialName]
	internal bool method_72()
	{
		return m_noImport;
	}

	[SpecialName]
	internal void method_73(bool bool_0)
	{
		m_noImport = bool_0;
	}

	[SpecialName]
	internal int method_74()
	{
		return m_templatedSettingType;
	}

	[SpecialName]
	internal void method_75(int int_0)
	{
		m_templatedSettingType = int_0;
	}

	[SpecialName]
	internal bool method_76()
	{
		return m_partialMapSettingAlwaysShow;
	}

	[SpecialName]
	internal void method_77(bool bool_0)
	{
		m_partialMapSettingAlwaysShow = bool_0;
	}

	[SpecialName]
	internal bool method_78()
	{
		return m_partialMapSettingShowOffset;
	}

	[SpecialName]
	internal void method_79(bool bool_0)
	{
		m_partialMapSettingShowOffset = bool_0;
	}

	[SpecialName]
	internal string method_80()
	{
		return m_partialMapSettingNameWhenShowingOffset;
	}

	[SpecialName]
	internal void method_81(string string_0)
	{
		m_partialMapSettingNameWhenShowingOffset = string_0;
	}

	[SpecialName]
	internal string method_82()
	{
		return m_partialMapSettingHelpDescWhenShowingOffset;
	}

	[SpecialName]
	internal void method_83(string string_0)
	{
		m_partialMapSettingHelpDescWhenShowingOffset = string_0;
	}

	[SpecialName]
	internal bool method_84()
	{
		return m_partialMapSettingOffsetAllowWrap;
	}

	[SpecialName]
	internal void method_85(bool bool_0)
	{
		m_partialMapSettingOffsetAllowWrap = bool_0;
	}

	[SpecialName]
	internal bool method_86()
	{
		return m_firmwareCanModify;
	}

	[SpecialName]
	internal void method_87(bool bool_0)
	{
		m_firmwareCanModify = bool_0;
	}

	[SpecialName]
	internal int method_88()
	{
		return m_scopeFixedScaleValue;
	}

	[SpecialName]
	internal void method_89(int int_0)
	{
		m_scopeFixedScaleValue = int_0;
	}

	[SpecialName]
	internal int method_90()
	{
		return m_scopeFixedScaleOrder;
	}

	[SpecialName]
	internal void method_91(int int_0)
	{
		m_scopeFixedScaleOrder = int_0;
	}

	[SpecialName]
	internal string method_92()
	{
		return m_scopeChannelSelectionWarning;
	}

	[SpecialName]
	internal void method_93(string string_0)
	{
		m_scopeChannelSelectionWarning = string_0;
	}

	[SpecialName]
	internal int method_94()
	{
		return m_recommendedLoggingGroupNumber;
	}

	[SpecialName]
	internal void method_95(int int_0)
	{
		m_recommendedLoggingGroupNumber = int_0;
	}

	[SpecialName]
	internal bool method_96()
	{
		return m_includedInPasswordProtection;
	}

	[SpecialName]
	internal void method_97(bool bool_0)
	{
		m_includedInPasswordProtection = bool_0;
	}

	[SpecialName]
	internal int method_98()
	{
		return m_dataIdOfSettingContainingChannelIdForMinMaxAndUnits;
	}

	[SpecialName]
	internal void method_99(int int_0)
	{
		m_dataIdOfSettingContainingChannelIdForMinMaxAndUnits = int_0;
	}

	internal int method_100()
	{
		Setting setting = null;
		if (m_idOfSettingContainingDisplayUnits.DataId != 0)
		{
			setting = m_framework.method_32(m_idOfSettingContainingDisplayUnits);
		}
		if (setting == null && m_isAttribute && m_parentSettingOrSpecialObject is Setting)
		{
			setting = m_framework.method_32(new DataIdAndAttrId(m_dataId, 4));
		}
		if (setting != null)
		{
			int num = setting.method_256();
			if (((num >> 8) & 0xFF) == method_231())
			{
				return num & 0xFF;
			}
		}
		return -1;
	}

	private List<ListItems.Struct45> method_101()
	{
		List<ListItems.Struct45> list = new List<ListItems.Struct45>();
		if (m_framework.aXK != null && m_framework.aXK.QuantityTypesPerUnitType.ContainsKey(method_231()))
		{
			foreach (Unit units in m_framework.aXK.QuantityTypesPerUnitType[method_231()].UnitsList)
			{
				list.Add(new ListItems.Struct45
				{
					bBv = units.ListItemVal,
					bBV = units.ListItemText
				});
			}
		}
		return list;
	}

	internal List<ListItems.Struct45> method_102(int int_0 = 0)
	{
		if (m_isAttribute && m_attributeId == 4)
		{
			return method_101();
		}
		if (m_hasMultiCellCondProperties && int_0 >= 0 && int_0 < m_listItems.BYm.Count)
		{
			return m_listItems.BYm[int_0];
		}
		if (!m_hasMultiCellCondProperties && m_listItems.BYm.Count != 0)
		{
			return m_listItems.BYm[0];
		}
		return new List<ListItems.Struct45>();
	}

	[SpecialName]
	internal List<ListItems.Struct45> method_103()
	{
		if (m_isAttribute && m_attributeId == 4)
		{
			return method_101();
		}
		List<ListItems.Struct45> list = new List<ListItems.Struct45>();
		if (m_listItems.BYN != null)
		{
			list.AddRange(m_listItems.BYN);
		}
		foreach (List<ListItems.Struct45> value in m_listItems.BYn.Values)
		{
			if (value != null)
			{
				list.AddRange(value);
			}
		}
		return list;
	}

	internal List<ValDescs.Struct46> method_104(int int_0 = 0)
	{
		if (m_hasMultiCellCondProperties && int_0 >= 0 && int_0 < m_valDescs.BYO.Count)
		{
			return m_valDescs.BYO[int_0];
		}
		if (!m_hasMultiCellCondProperties && m_valDescs.BYO.Count != 0)
		{
			return m_valDescs.BYO[0];
		}
		return new List<ValDescs.Struct46>();
	}

	[SpecialName]
	internal List<ValDescs.Struct46> method_105()
	{
		List<ValDescs.Struct46> list = new List<ValDescs.Struct46>();
		if (m_valDescs.BYo != null)
		{
			list.AddRange(m_valDescs.BYo);
		}
		foreach (List<ValDescs.Struct46> value in m_valDescs.BYP.Values)
		{
			if (value != null)
			{
				list.AddRange(value);
			}
		}
		return list;
	}

	internal List<MaskItems.Struct47> method_106(int int_0 = 0)
	{
		if (m_hasMultiCellCondProperties && int_0 >= 0 && int_0 < m_maskItems.BYp.Count)
		{
			return m_maskItems.BYp[int_0];
		}
		if (!m_hasMultiCellCondProperties && m_maskItems.BYp.Count != 0)
		{
			return m_maskItems.BYp[0];
		}
		return new List<MaskItems.Struct47>();
	}

	[SpecialName]
	internal string method_107()
	{
		return m_maskJoinText;
	}

	[SpecialName]
	internal void method_108(string string_0)
	{
		m_maskJoinText = string_0;
	}

	internal void method_109(ConvertFrom convertFrom_0)
	{
		m_convertFromsList.Add(convertFrom_0);
	}

	internal void method_110(ConvertTo convertTo_0)
	{
		m_convertTosList.Add(convertTo_0);
	}

	[SpecialName]
	internal List<ConvertFrom> method_111()
	{
		return m_convertFromsList;
	}

	[SpecialName]
	internal List<ConvertTo> method_112()
	{
		return m_convertTosList;
	}

	internal void method_113(Framework framework_0, bool bool_0, bool bool_1 = false)
	{
		bool flag = (m_framework.awZ == 20 || m_framework.awZ == 25 || m_framework.awZ == 24 || m_framework.awZ == 21) && Class242.smethod_12(framework_0.awZ);
		bool flag2 = Class242.smethod_12(m_framework.awZ) && (framework_0.awZ == 20 || framework_0.awZ == 25 || framework_0.awZ == 24 || framework_0.awZ == 21);
		bool flag3 = flag || (!flag2 && framework_0.aXA <= m_framework.aXA);
		bool flag4 = flag2 || (!flag && framework_0.aXA > m_framework.aXA);
		Setting setting = framework_0.method_32(m_dataIdAndAttrId);
		if (setting == null)
		{
			if (m_dataId == 9496)
			{
				int num = method_278();
				for (int i = 0; i < num; i++)
				{
					method_270(i, byte.MaxValue, bool_0);
				}
			}
			else
			{
				method_246(bool_0);
			}
		}
		if (flag3)
		{
			method_114(framework_0, setting, bool_0);
		}
		else if (flag4)
		{
			method_115(framework_0, setting, bool_0);
		}
		else if (setting != null)
		{
			method_116(setting, bool_0);
		}
		if (this is Class244)
		{
			List<Setting> list = new List<Setting>();
			PortFunction.smethod_31(this as Class244, list, bool_0: false);
			foreach (Setting item in list)
			{
				item.method_113(framework_0, bool_0);
			}
			List<Table> list2 = new List<Table>();
			PortFunction.smethod_34(this as Class244, list2, bool_0: false);
			foreach (Table item2 in list2)
			{
				item2.ImportFromAnotherFramework(framework_0, bool_0);
			}
		}
		if (bool_1 && method_171())
		{
			Class247.smethod_4(this, bool_0);
		}
	}

	private void method_114(Framework framework_0, Setting setting_0, bool bool_0)
	{
		List<int[]> list = new List<int[]>();
		for (int i = 0; i < m_convertFromsList.Count; i++)
		{
			ConvertFrom convertFrom = m_convertFromsList[i];
			if (convertFrom.method_0() == framework_0.awZ && (convertFrom.method_1() == -1 || convertFrom.method_1() == framework_0.awz))
			{
				Class14 @class = null;
				Class14 class2 = null;
				if (convertFrom.method_2() != null)
				{
					@class = new Class14(convertFrom.method_2(), bool_0: false);
				}
				if (convertFrom.method_3() != null)
				{
					class2 = new Class14(convertFrom.method_3(), bool_0: false);
				}
				if ((@class == null || framework_0.aXA >= @class) && (class2 == null || framework_0.aXA <= class2))
				{
					convertFrom.method_5(this, m_framework, framework_0, list, bool_0);
				}
			}
		}
		if (list.Count == 0)
		{
			if (m_dataId == 1501 && Class242.smethod_12(framework_0.awZ) && framework_0.aXA.method_0() < 3)
			{
				int num = method_278();
				for (int j = 0; j < num; j++)
				{
					method_270(j, 0, bool_0);
				}
			}
			else if (setting_0 != null)
			{
				int num2 = Math.Min(m_dimensionsSliceRowCol[0], setting_0.method_242()[0]);
				int num3 = Math.Min(m_dimensionsSliceRowCol[1], setting_0.method_242()[1]);
				int num4 = Math.Min(m_dimensionsSliceRowCol[2], setting_0.method_242()[2]);
				bool flag = method_6() is Table && this == (method_6() as Table).TableDataSetting && setting_0.method_277() == 1;
				for (int k = 0; k < m_dimensionsSliceRowCol[0]; k++)
				{
					for (int l = 0; l < m_dimensionsSliceRowCol[1]; l++)
					{
						for (int m = 0; m < m_dimensionsSliceRowCol[2]; m++)
						{
							if (k < num2 && l < num3 && m < num4)
							{
								method_273(m, l, k, setting_0.method_257(m, l, k), bool_0);
							}
							else if (flag)
							{
								method_273(m, l, k, setting_0.method_256(), bool_0);
							}
							else
							{
								method_273(m, l, k, m_terminatingValue, bool_0);
							}
						}
					}
				}
			}
		}
		if (!(method_6() is TableAxis))
		{
			return;
		}
		TableAxis tableAxis = method_6() as TableAxis;
		if (this == tableAxis.method_88())
		{
			int num5 = method_229();
			if (method_256() > num5)
			{
				method_272(num5, bool_0);
			}
		}
	}

	private void method_115(Framework framework_0, Setting setting_0, bool bool_0)
	{
		if (setting_0 != null)
		{
			List<int[]> list = new List<int[]>();
			for (int i = 0; i < setting_0.method_112().Count; i++)
			{
				ConvertTo convertTo = setting_0.method_112()[i];
				if (convertTo.method_0() == framework_0.awZ && (convertTo.method_1() == -1 || convertTo.method_1() == framework_0.awz))
				{
					Class14 @class = null;
					Class14 class2 = null;
					if (convertTo.method_2() != null)
					{
						@class = new Class14(convertTo.method_2(), bool_0: false);
					}
					if (convertTo.method_3() != null)
					{
						class2 = new Class14(convertTo.method_3(), bool_0: false);
					}
					if ((@class == null || m_framework.aXA >= @class) && (class2 == null || m_framework.aXA <= class2))
					{
						convertTo.method_5(this, m_framework, framework_0, list, bool_0);
					}
				}
			}
			if (list.Count == 0)
			{
				int num = Math.Min(m_dimensionsSliceRowCol[0], setting_0.method_242()[0]);
				int num2 = Math.Min(m_dimensionsSliceRowCol[1], setting_0.method_242()[1]);
				int num3 = Math.Min(m_dimensionsSliceRowCol[2], setting_0.method_242()[2]);
				bool flag = method_6() is Table && this == (method_6() as Table).TableDataSetting && setting_0.method_277() == 1;
				for (int j = 0; j < m_dimensionsSliceRowCol[0]; j++)
				{
					for (int k = 0; k < m_dimensionsSliceRowCol[1]; k++)
					{
						for (int l = 0; l < m_dimensionsSliceRowCol[2]; l++)
						{
							if (j < num && k < num2 && l < num3)
							{
								method_273(l, k, j, setting_0.method_257(l, k, j), bool_0);
							}
							else if (flag)
							{
								method_273(l, k, j, setting_0.method_256(), bool_0);
							}
							else
							{
								method_273(l, k, j, m_terminatingValue, bool_0);
							}
						}
					}
				}
			}
		}
		if (!(method_6() is TableAxis))
		{
			return;
		}
		TableAxis tableAxis = method_6() as TableAxis;
		if (this == tableAxis.method_88())
		{
			int num4 = method_229();
			if (method_256() > num4)
			{
				method_272(num4, bool_0);
			}
		}
	}

	internal void method_116(Setting setting_0, bool bool_0)
	{
		int num = m_dimensionsSliceRowCol[0];
		if (setting_0.method_242()[0] != num)
		{
			return;
		}
		int num2 = m_dimensionsSliceRowCol[1];
		if (setting_0.method_242()[1] != num2)
		{
			return;
		}
		int num3 = m_dimensionsSliceRowCol[2];
		if (setting_0.method_242()[2] != num3)
		{
			return;
		}
		bool flag = method_266();
		method_268();
		bool flag2 = m_framework.method_53();
		m_framework.method_55();
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				for (int k = 0; k < num3; k++)
				{
					method_273(k, j, i, setting_0.method_257(k, j, i), bool_0);
				}
			}
		}
		if (flag2)
		{
			m_framework.method_54(bool_0: true, this);
		}
		if (flag)
		{
			method_267(bool_0: true);
		}
	}

	internal void method_117(Setting setting_0, StringBuilder stringBuilder_0)
	{
		if (stringBuilder_0 == null || method_207() || method_212() || m_useFixedValue || method_220() || !method_205() || setting_0.method_207() || setting_0.method_212() || setting_0.method_219() || setting_0.method_220() || !setting_0.method_205())
		{
			return;
		}
		int num = method_277();
		int num2 = setting_0.method_277();
		int num3 = method_199();
		int num4 = setting_0.method_199();
		if (num == num2 && num3 == num4)
		{
			if (m_encoding != 0)
			{
				string text = method_260();
				string text2 = setting_0.method_260();
				if (text != text2)
				{
					stringBuilder_0.Append(Class333.Bdj() + method_60(Enum96.aYt) + Class333.BdK() + m_dataId + Class333.BdM() + text + Class333.Bdm() + text2 + Class333.BdN());
				}
				return;
			}
			for (int i = 0; i < num; i++)
			{
				int num5 = method_258(i);
				int num6 = setting_0.method_258(i);
				if (num5 != num6)
				{
					int num7 = setting_0.method_231();
					string text3 = method_287(num5, i);
					string text4 = setting_0.method_287(num6, i);
					string text5 = ((num > 1) ? (Class333.Bdn() + i) : string.Empty);
					if (text3 != null && text4 != null)
					{
						stringBuilder_0.Append(Class333.Bdj() + method_60(Enum96.aYt) + Class333.BdK() + m_dataId + Class333.smethod_9() + text5 + Class333.BdO() + text3 + Class333.Bdm() + text4 + Class333.BdN());
					}
					else if (method_231() == num7 && method_232() == setting_0.method_232() && method_231() != 0 && method_231() != 82 && (text3 != null || text4 == null) && (text3 == null || text4 != null))
					{
						string text6 = Class233.smethod_29(num5, method_231()) + Class333.smethod_325() + Class233.smethod_35(method_232(), method_231(), bool_0: true, num5);
						string text7 = Class233.smethod_29(num6, method_231()) + Class333.smethod_325() + Class233.smethod_35(method_232(), method_231(), bool_0: true, num6);
						stringBuilder_0.Append(Class333.Bdj() + method_60(Enum96.aYt) + Class333.BdK() + m_dataId + Class333.smethod_9() + text5 + Class333.Bdo() + text6 + Class333.BdQ() + num5 + Class333.Bdq() + text7 + Class333.BdQ() + num6 + Class333.BdR());
					}
					else
					{
						stringBuilder_0.Append(Class333.Bdj() + method_60(Enum96.aYt) + Class333.BdK() + m_dataId + Class333.smethod_9() + text5 + Class333.Bdo() + num5 + Class333.BdP() + num6 + Class333.Bdp());
					}
				}
			}
		}
		else
		{
			stringBuilder_0.Append(Class333.Bdj() + method_60(Enum96.aYt) + Class333.BdK() + m_dataId + Class333.Bdk() + num * num3 + Class333.BdL() + num2 * num4 + Class333.Bdl());
		}
	}

	internal void method_118(string string_0, int int_0, int int_1, int int_2)
	{
		MultiCellCondition item = new MultiCellCondition
		{
			BYg = string_0,
			BYH = int_0,
			BYh = int_1,
			BYI = int_2
		};
		m_multiCellEnableOnConditions.Add(item);
	}

	[SpecialName]
	internal List<MultiCellCondition> method_119()
	{
		return m_multiCellEnableOnConditions;
	}

	internal void method_120(string string_0, IllegalitySeverityLevel illegalitySeverityLevel_0, bool bool_0, string string_1, int int_0)
	{
		m_allLegalOns.Add(new LegalOn(string_0, string_1, illegalitySeverityLevel_0, bool_0, int_0));
	}

	internal bool method_121(string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < m_allLegalOns.Count)
			{
				if (m_allLegalOns[num].BYR.Contains(string_0))
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

	protected override void RevertAllConditionalPropertiesToDefaults()
	{
		base.RevertAllConditionalPropertiesToDefaults();
		for (int i = 0; i < 15; i++)
		{
			m_intProperties[i].BYU = m_intProperties[i].BYu;
		}
		m_listItems.BYm.Clear();
		m_valDescs.BYO.Clear();
		m_maskItems.BYp.Clear();
		int num = ((!m_hasMultiCellCondProperties) ? 1 : method_277());
		for (int j = 0; j < num; j++)
		{
			m_listItems.BYm.Add(new List<ListItems.Struct45>());
			m_listItems.BYm[j].AddRange(m_listItems.BYN);
			m_valDescs.BYO.Add(new List<ValDescs.Struct46>());
			m_valDescs.BYO[j].AddRange(m_valDescs.BYo);
			m_maskItems.BYp.Add(new List<MaskItems.Struct47>());
			m_maskItems.BYp[j].AddRange(m_maskItems.BYQ);
		}
		m_currentLegalOns.Clear();
		for (int k = 0; k < m_allLegalOns.Count; k++)
		{
			LegalOn legalOn = m_allLegalOns[k];
			if (legalOn.BYT == -1)
			{
				m_currentLegalOns.Add(legalOn);
			}
		}
	}

	protected override void UpdateConditionalPropertiesValues(int cellIndex, int condPropertiesBlockIndex)
	{
		base.UpdateConditionalPropertiesValues(cellIndex, condPropertiesBlockIndex);
		if (cellIndex == 0)
		{
			for (int i = 0; i < 15; i++)
			{
				if (m_intProperties[i].BYV.ContainsKey(condPropertiesBlockIndex))
				{
					m_intProperties[i].BYU = m_intProperties[i].BYV[condPropertiesBlockIndex];
				}
				if (m_intProperties[i].BYw.ContainsKey(condPropertiesBlockIndex))
				{
					m_intProperties[i].BYv = m_intProperties[i].BYw[condPropertiesBlockIndex];
				}
				if (m_intProperties[i].BYY.ContainsKey(condPropertiesBlockIndex))
				{
					m_intProperties[i].BYX = m_intProperties[i].BYY[condPropertiesBlockIndex];
				}
			}
			for (int j = 0; j < m_allLegalOns.Count; j++)
			{
				LegalOn legalOn = m_allLegalOns[j];
				if (legalOn.BYT == condPropertiesBlockIndex)
				{
					m_currentLegalOns.Add(legalOn);
				}
			}
		}
		if (m_listItems.BYn.ContainsKey(condPropertiesBlockIndex))
		{
			List<ListItems.Struct45> collection = m_listItems.BYn[condPropertiesBlockIndex];
			m_listItems.BYm[cellIndex].AddRange(collection);
		}
		if (m_valDescs.BYP.ContainsKey(condPropertiesBlockIndex))
		{
			List<ValDescs.Struct46> collection2 = m_valDescs.BYP[condPropertiesBlockIndex];
			m_valDescs.BYO[cellIndex].AddRange(collection2);
		}
		if (m_maskItems.BYq.ContainsKey(condPropertiesBlockIndex))
		{
			List<MaskItems.Struct47> collection3 = m_maskItems.BYq[condPropertiesBlockIndex];
			m_maskItems.BYp[cellIndex].AddRange(collection3);
		}
	}

	[SpecialName]
	internal bool method_122()
	{
		return m_currentlyIsLegal;
	}

	[SpecialName]
	internal List<string> method_123()
	{
		return m_currentIllegalityTexts;
	}

	[SpecialName]
	internal IllegalitySeverityLevel method_124()
	{
		return m_currentSeverityLevel;
	}

	[SpecialName]
	internal bool method_125()
	{
		return m_currentIllegalityCanHighlightNode;
	}

	[SpecialName]
	internal List<HashSet<int>> method_126()
	{
		return m_dataIdsInIllegalityEquations;
	}

	internal void method_127(int int_0, string string_0)
	{
		Enum95 bYL = ((string_0 == Class333.smethod_390()) ? Enum95.BYi : ((!(string_0 == Class333.smethod_836())) ? ((string_0 == Class333.smethod_1130()) ? Enum95.BYj : ((string_0 == Class333.smethod_14()) ? Enum95.BYK : Enum95.BYJ)) : Enum95.BYJ));
		BrH.Add(new Struct44
		{
			BYk = int_0,
			BYL = bYL
		});
	}

	internal void method_128(string string_0, string string_1, int int_0, int int_1, string string_2, string string_3, string string_4, int int_2)
	{
		ListItems.Struct45 item = new ListItems.Struct45
		{
			bBu = string_0,
			bBV = string_1,
			bBv = int_0,
			bBW = int_1,
			bBw = string_2,
			bBX = string_3,
			bBx = string_4
		};
		if (int_2 == -1)
		{
			m_listItems.BYN.Add(item);
			if (m_listItems.BYm.Count == 0)
			{
				m_listItems.BYm.Add(new List<ListItems.Struct45>());
			}
			m_listItems.BYm[0].Add(item);
		}
		else
		{
			if (!m_listItems.BYn.ContainsKey(int_2))
			{
				m_listItems.BYn.Add(int_2, new List<ListItems.Struct45>());
			}
			m_listItems.BYn[int_2].Add(item);
		}
	}

	internal void method_129(string string_0, string string_1, int int_0, int int_1)
	{
		ValDescs.Struct46 item = new ValDescs.Struct46
		{
			bBY = string_0,
			bBy = string_1,
			bBZ = int_0
		};
		if (int_1 == -1)
		{
			m_valDescs.BYo.Add(item);
			if (m_valDescs.BYO.Count == 0)
			{
				m_valDescs.BYO.Add(new List<ValDescs.Struct46>());
			}
			m_valDescs.BYO[0].Add(item);
		}
		else
		{
			if (!m_valDescs.BYP.ContainsKey(int_1))
			{
				m_valDescs.BYP.Add(int_1, new List<ValDescs.Struct46>());
			}
			m_valDescs.BYP[int_1].Add(item);
		}
	}

	internal void method_130(string string_0, string string_1, int int_0, int int_1, int int_2)
	{
		MaskItems.Struct47 item = new MaskItems.Struct47
		{
			bBz = string_0,
			bbA = string_1,
			bba = int_0,
			bbB = int_1
		};
		if (int_2 == -1)
		{
			m_maskItems.BYQ.Add(item);
			if (m_maskItems.BYp.Count == 0)
			{
				m_maskItems.BYp.Add(new List<MaskItems.Struct47>());
			}
			m_maskItems.BYp[0].Add(item);
		}
		else
		{
			if (!m_maskItems.BYq.ContainsKey(int_2))
			{
				m_maskItems.BYq.Add(int_2, new List<MaskItems.Struct47>());
			}
			m_maskItems.BYq[int_2].Add(item);
		}
	}

	[SpecialName]
	internal bool[,,] method_131()
	{
		return m_currentMultiCellEnableOnSliceRowCol;
	}

	[SpecialName]
	internal HashSet<DataIdAndAttrId> method_132()
	{
		return m_idsWithEquationsAffectedByThisSetting;
	}

	[SpecialName]
	internal HashSet<int> method_133()
	{
		return m_objectIdsWithEquationsAffectedByThisSetting;
	}

	[SpecialName]
	internal HashSet<FilterOption> method_134()
	{
		return m_filterOptionsWithEquationsAffectedByThisSetting;
	}

	protected override bool EvaluateCondPropertiesConditions(bool initInfluencingSettingIdsList)
	{
		bool result = m_conditionsPreviouslyMetPerCellPerCondPropertiesBlock.Count == 0 && m_condPropertiesBlocks.Count != 0;
		RevertAllConditionalPropertiesToDefaults();
		int num = method_277();
		for (int i = 0; i < m_condPropertiesBlocks.Count; i++)
		{
			string brK = m_condPropertiesBlocks[i].BrK;
			bool brk;
			int num2 = ((!(brk = m_condPropertiesBlocks[i].Brk)) ? 1 : m_dimensionsSliceRowCol[2]);
			int num3 = ((!brk) ? 1 : m_dimensionsSliceRowCol[1]);
			int num4 = ((!brk) ? 1 : m_dimensionsSliceRowCol[0]);
			for (int j = 0; j < num4; j++)
			{
				for (int k = 0; k < num3; k++)
				{
					for (int l = 0; l < num2; l++)
					{
						string string_ = brK.Replace(Class333.Bdr(), l.ToString()).Replace(Class333.BdS(), k.ToString()).Replace(Class333.Bds(), j.ToString());
						int num5 = method_250(l, k, j);
						List<int> list = Class37.smethod_0(ref string_, m_framework);
						if (initInfluencingSettingIdsList && num5 == 0)
						{
							for (int m = 0; m < list.Count; m++)
							{
								m_dataIdsInCondPropsEquations.Add(list[m]);
								m_framework.method_31(list[m]).method_132().Add(m_dataIdAndAttrId);
							}
						}
						bool flag = Class37.smethod_10(ref string_);
						if (m_condPropertiesBlocks.Count != m_conditionsPreviouslyMetPerCellPerCondPropertiesBlock.Count || m_conditionsPreviouslyMetPerCellPerCondPropertiesBlock[i] == null || num5 >= m_conditionsPreviouslyMetPerCellPerCondPropertiesBlock[i].Length || flag != m_conditionsPreviouslyMetPerCellPerCondPropertiesBlock[i][num5])
						{
							result = true;
						}
						if (m_conditionsPreviouslyMetPerCellPerCondPropertiesBlock.Count <= i)
						{
							m_conditionsPreviouslyMetPerCellPerCondPropertiesBlock.Add(new bool[(!brk) ? 1 : num]);
						}
						m_conditionsPreviouslyMetPerCellPerCondPropertiesBlock[i][num5] = flag;
						if (flag)
						{
							UpdateConditionalPropertiesValues(num5, i);
						}
					}
				}
			}
		}
		return result;
	}

	protected override bool EvaluateEnableOnConditions(bool initInfluencingSettingIdsList)
	{
		bool flag = false;
		int num = m_dimensionsSliceRowCol[2];
		int num2 = m_dimensionsSliceRowCol[1];
		int num3 = m_dimensionsSliceRowCol[0];
		bool[,,] array = new bool[num3, num2, num];
		if (m_currentEnableOns.Count == 0)
		{
			if (m_isAttribute && m_parentSettingOrSpecialObject != null)
			{
				if (m_currentEnableOn != m_parentSettingOrSpecialObject.method_35())
				{
					flag = true;
					m_currentEnableOn = m_parentSettingOrSpecialObject.method_35();
				}
			}
			else
			{
				m_currentEnableOn = true;
			}
		}
		else
		{
			bool flag2 = false;
			for (int i = 0; i < m_currentEnableOns.Count; i++)
			{
				string string_ = m_currentEnableOns[i].BrL;
				List<int> list = Class37.smethod_0(ref string_, m_framework);
				if (initInfluencingSettingIdsList)
				{
					for (int j = 0; j < list.Count; j++)
					{
						m_dataIdsInEnableOnEquations.Add(list[j]);
						m_framework.method_31(list[j]).method_132().Add(m_dataIdAndAttrId);
					}
				}
				bool flag3 = Class37.smethod_10(ref string_);
				flag2 |= flag3;
			}
			if (m_isAttribute && m_parentSettingOrSpecialObject != null)
			{
				bool flag4 = flag2 && m_parentSettingOrSpecialObject.method_35();
				flag = m_currentEnableOn != flag4;
				m_currentEnableOn = flag4;
			}
			else
			{
				flag = m_currentEnableOn != flag2;
				m_currentEnableOn = flag2;
			}
		}
		for (int i = 0; i < m_multiCellEnableOnConditions.Count; i++)
		{
			string string_ = m_multiCellEnableOnConditions[i].BYg;
			List<int> list2 = Class37.smethod_0(ref string_, m_framework);
			if (initInfluencingSettingIdsList)
			{
				for (int k = 0; k < list2.Count; k++)
				{
					m_dataIdsInEnableOnEquations.Add(list2[k]);
					m_framework.method_31(list2[k]).method_132().Add(m_dataIdAndAttrId);
				}
			}
			bool flag3 = Class37.smethod_10(ref string_);
			array[m_multiCellEnableOnConditions[i].BYI, m_multiCellEnableOnConditions[i].BYh, m_multiCellEnableOnConditions[i].BYH] = flag3;
		}
		if (!flag)
		{
			if (m_currentMultiCellEnableOnSliceRowCol == null)
			{
				flag = true;
			}
			else
			{
				for (int l = 0; l < num3; l++)
				{
					for (int m = 0; m < num2; m++)
					{
						for (int n = 0; n < num; n++)
						{
							if (m_currentMultiCellEnableOnSliceRowCol[l, m, n] != array[l, m, n])
							{
								flag = true;
								break;
							}
						}
						if (flag)
						{
							break;
						}
					}
					if (flag)
					{
						break;
					}
				}
			}
		}
		m_currentMultiCellEnableOnSliceRowCol = array;
		return flag;
	}

	private void method_135(bool bool_0, bool bool_1, ref bool bool_2)
	{
		if (m_currentLegalOns.Count != 0)
		{
			int num = 3;
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < m_currentLegalOns.Count; i++)
			{
				string string_ = m_currentLegalOns[i].BYR;
				List<int> list = Class37.smethod_0(ref string_, m_framework);
				if (bool_0)
				{
					HashSet<int> hashSet = new HashSet<int>();
					for (int j = 0; j < list.Count; j++)
					{
						hashSet.Add(list[j]);
						m_framework.method_31(list[j]).method_132().Add(m_dataIdAndAttrId);
					}
					m_dataIdsInIllegalityEquations.Add(hashSet);
				}
				if (!bool_1)
				{
					continue;
				}
				bool flag3 = Class37.smethod_10(ref string_);
				flag2 |= flag3;
				string item;
				if (flag3)
				{
					num = Math.Min(num, (int)m_currentLegalOns[i].BYS);
					item = m_currentLegalOns[i].BYr;
					if (!flag)
					{
						flag = m_currentLegalOns[i].BYs;
					}
				}
				else
				{
					item = string.Empty;
				}
				if (m_currentIllegalityTexts.Count == i)
				{
					m_currentIllegalityTexts.Add(item);
				}
				else if (i < m_currentIllegalityTexts.Count)
				{
					m_currentIllegalityTexts.Insert(i, item);
				}
				else
				{
					m_currentIllegalityTexts.Add(item);
				}
			}
			if (bool_1)
			{
				bool flag4 = !flag2;
				if (m_currentlyIsLegal != flag4)
				{
					bool_2 = true;
					m_currentlyIsLegal = flag4;
				}
				if (m_currentSeverityLevel != (IllegalitySeverityLevel)num)
				{
					bool_2 = true;
					m_currentSeverityLevel = (IllegalitySeverityLevel)num;
				}
				m_currentIllegalityCanHighlightNode = flag;
			}
		}
		else
		{
			if (!m_currentlyIsLegal)
			{
				bool_2 = true;
				m_currentlyIsLegal = true;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.None;
			m_currentIllegalityCanHighlightNode = false;
		}
	}

	internal bool method_136(bool bool_0)
	{
		m_previousIllegalityTexts = m_currentIllegalityTexts.ToList();
		m_currentIllegalityTexts.Clear();
		m_currentIllegalityCanHighlightNode = false;
		bool bool_1 = false;
		bool bool_2 = true;
		if (m_useFixedValue || method_212())
		{
			m_currentlyIsLegal = true;
			m_currentSeverityLevel = IllegalitySeverityLevel.None;
			m_currentIllegalityCanHighlightNode = false;
			bool_2 = false;
		}
		if (bool_2 && m_multiCellEnableOnConditions.Count == 0 && !m_currentEnableOn && (!(this is Class244) || (this as Class244).method_256() == 0))
		{
			if (!m_currentlyIsLegal)
			{
				bool_1 = true;
				m_currentlyIsLegal = true;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.None;
			m_currentIllegalityCanHighlightNode = false;
			bool_2 = false;
		}
		bool flag = false;
		if (m_isPortFunctionEnabler)
		{
			flag = !(this is Class245);
			if (method_256() != 1)
			{
				if (!m_currentlyIsLegal)
				{
					bool_1 = true;
					m_currentlyIsLegal = true;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.None;
				m_currentIllegalityCanHighlightNode = false;
				bool_2 = false;
			}
		}
		if (!flag && this is Class245 && m_parentSettingOrSpecialObject != null && m_listItems.BYm.Count != 0 && m_listItems.BYm[0].Count != 0)
		{
			for (int i = 0; i < m_parentSettingOrSpecialObject.method_1().Count; i++)
			{
				if (m_parentSettingOrSpecialObject.method_1()[i] is Setting setting && setting.method_150() && !(setting is Class245) && setting.method_256() != 1)
				{
					if (!m_currentlyIsLegal)
					{
						bool_1 = true;
						m_currentlyIsLegal = true;
					}
					m_currentSeverityLevel = IllegalitySeverityLevel.None;
					m_currentIllegalityCanHighlightNode = false;
					bool_2 = false;
					break;
				}
			}
		}
		if (bool_2 && m_dimensionsSliceRowCol[0] == 1 && m_dimensionsSliceRowCol[1] == 1 && m_dimensionsSliceRowCol[2] == 1 && !method_207() && PortFunction.smethod_27(m_parentSettingOrSpecialObject))
		{
			PortFunction.Class273 @class = m_parentSettingOrSpecialObject.method_12().method_12();
			int num = PortFunction.smethod_38(m_framework, bool_0: false, @class.BSQ, @class.BSq, @class.BSR, @class.BSr);
			if (num == 0 && PortFunction.smethod_46(m_framework, @class.BSQ, @class.BSq, @class.BSR, @class.BSr) != null)
			{
				num = 1;
			}
			if (num == 0)
			{
				if (!m_currentlyIsLegal)
				{
					bool_1 = true;
					m_currentlyIsLegal = true;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.None;
				m_currentIllegalityCanHighlightNode = false;
				bool_2 = false;
			}
		}
		if (m_numBytesPerCell == 1 && m_parentSettingOrSpecialObject is TableAxis && m_parentSettingOrSpecialObject.method_6() is Table && (!m_parentSettingOrSpecialObject.method_35() || !m_parentSettingOrSpecialObject.method_6().method_35() || ((m_parentSettingOrSpecialObject as TableAxis).method_87() != null && (m_parentSettingOrSpecialObject as TableAxis).method_87().method_256() == 0) || !(m_parentSettingOrSpecialObject as TableAxis).method_72()) && (m_internalName == Class333.smethod_800() || m_internalName == Class333.aiv()))
		{
			if (!m_currentlyIsLegal)
			{
				bool_1 = true;
				m_currentlyIsLegal = true;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.None;
			m_currentIllegalityCanHighlightNode = false;
			bool_2 = false;
		}
		if (m_parentSettingOrSpecialObject is SensorCalibration && !m_parentSettingOrSpecialObject.method_35())
		{
			if (!m_currentlyIsLegal)
			{
				bool_1 = true;
				m_currentlyIsLegal = true;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.None;
			m_currentIllegalityCanHighlightNode = false;
			bool_2 = false;
		}
		if (m_parentSettingOrSpecialObject != null && (m_parentSettingOrSpecialObject is Class255 || m_parentSettingOrSpecialObject.method_6() is Class255))
		{
			Class255 class2 = ((m_parentSettingOrSpecialObject is Class255) ? (m_parentSettingOrSpecialObject as Class255) : (m_parentSettingOrSpecialObject.method_6() as Class255));
			bool flag2 = class2.BZK.method_256() == 0 || (class2.BZK.method_64() == 19293 && m_framework.method_31(10363).method_256() == 0) || (class2.BZK.method_64() == 19323 && m_framework.method_31(10362).method_256() == 0) || (class2.BZK.method_64() == 19351 && m_framework.method_31(16033).method_256() == 0);
			if (flag2 || m_internalName.EndsWith(Class333.BdT()))
			{
				if (!m_currentlyIsLegal)
				{
					bool_1 = true;
					m_currentlyIsLegal = true;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.None;
				m_currentIllegalityCanHighlightNode = false;
				bool_2 = false;
			}
		}
		bool flag3 = false;
		if (bool_2)
		{
			flag3 = method_140(ref bool_2, ref bool_1);
		}
		bool flag4 = false;
		if (bool_2)
		{
			flag4 = method_137(ref bool_2, ref bool_1);
		}
		bool flag5 = false;
		if (bool_2)
		{
			flag5 = method_138(ref bool_2, ref bool_1);
		}
		bool flag6 = false;
		if (bool_2)
		{
			flag6 = method_139(ref bool_2, ref bool_1);
		}
		bool flag7 = false;
		if (bool_2)
		{
			flag7 = method_141(ref bool_2, ref bool_1);
		}
		bool flag8 = false;
		if (bool_2)
		{
			flag8 = method_142(ref bool_2, ref bool_1);
		}
		bool flag9 = false;
		if (bool_2 && this is Table)
		{
			List<string> axesWarningStrings = (this as Table).GetAxesWarningStrings();
			if (axesWarningStrings.Count != 0)
			{
				for (int j = 0; j < axesWarningStrings.Count; j++)
				{
					m_currentIllegalityTexts.Add(axesWarningStrings[j]);
				}
				if (m_currentlyIsLegal)
				{
					bool_1 = true;
					m_currentlyIsLegal = false;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.Warning;
				m_currentIllegalityCanHighlightNode = false;
				flag9 = true;
			}
			List<string> axesErrorStrings = (this as Table).GetAxesErrorStrings();
			if (axesErrorStrings.Count != 0)
			{
				for (int k = 0; k < axesErrorStrings.Count; k++)
				{
					m_currentIllegalityTexts.Add(axesErrorStrings[k]);
				}
				if (m_currentlyIsLegal)
				{
					bool_1 = true;
					m_currentlyIsLegal = false;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				flag9 = true;
			}
		}
		bool flag10 = false;
		if (bool_2)
		{
			flag10 = method_146(ref bool_2, ref bool_1);
		}
		bool flag11 = false;
		if (bool_2)
		{
			flag11 = method_147(ref bool_1);
		}
		bool flag12 = false;
		if (!flag4 && !flag5 && !flag6 && !flag9 && !flag7 && !flag10 && !flag3 && !flag11 && !flag8)
		{
			if (bool_2 && this is Class244)
			{
				(this as Class244).method_295(ref bool_1);
				if (!m_currentlyIsLegal && m_parentSettingOrSpecialObject != null)
				{
					for (int l = 0; l < m_parentSettingOrSpecialObject.method_1().Count; l++)
					{
						if (m_parentSettingOrSpecialObject.method_1()[l] is Setting setting2 && setting2.method_150())
						{
							Setting setting3 = setting2;
							if (setting3.m_currentlyIsLegal)
							{
								bool_1 = true;
								setting3.m_conditionsChangedOnLastEvaluation = true;
								setting3.m_currentlyIsLegal = false;
							}
							if (!setting3.m_currentIllegalityTexts.Contains(Class333.Bdt()))
							{
								setting3.m_currentIllegalityTexts.Add(Class333.Bdt());
							}
							setting3.m_currentSeverityLevel = IllegalitySeverityLevel.Error;
							setting3.m_currentIllegalityCanHighlightNode = true;
							break;
						}
					}
				}
				flag12 = true;
			}
			if (!flag12)
			{
				method_135(bool_0, bool_2, ref bool_1);
			}
		}
		if (!m_currentlyIsLegal && !flag12 && m_currentSeverityLevel == IllegalitySeverityLevel.Error)
		{
			SpecialObject specialObject = null;
			SettingOrSpecialObject settingOrSpecialObject = this;
			bool flag13 = false;
			do
			{
				if (settingOrSpecialObject.method_6() == null)
				{
					flag13 = true;
					continue;
				}
				settingOrSpecialObject = settingOrSpecialObject.method_6();
				if (settingOrSpecialObject is SpecialObject && settingOrSpecialObject.method_12().Bbb != -1)
				{
					specialObject = settingOrSpecialObject as SpecialObject;
					break;
				}
			}
			while (!flag13);
			if (specialObject != null)
			{
				for (int m = 0; m < specialObject.method_1().Count; m++)
				{
					if (specialObject.method_1()[m] is Setting setting4 && setting4.method_150())
					{
						Setting setting5 = setting4;
						if (setting5.m_currentlyIsLegal)
						{
							bool_1 = true;
							setting5.m_conditionsChangedOnLastEvaluation = true;
							setting5.m_currentlyIsLegal = false;
						}
						if (!setting5.m_currentIllegalityTexts.Contains(Class333.BdU()))
						{
							setting5.m_currentIllegalityTexts.Add(Class333.BdU());
						}
						setting5.m_currentSeverityLevel = IllegalitySeverityLevel.Error;
						setting5.m_currentIllegalityCanHighlightNode = true;
						break;
					}
				}
			}
		}
		return bool_1;
	}

	internal bool method_137(ref bool bool_0, ref bool bool_1)
	{
		if (!method_207() && !m_isEnabler)
		{
			bool flag = m_multiCellEnableOnConditions.Count != 0;
			int int_ = method_228();
			int int_2 = method_229();
			int int_3 = method_231();
			if (flag)
			{
				bool flag2 = true;
				for (int i = 0; i < m_dimensionsSliceRowCol[2]; i++)
				{
					if (method_131()[0, 0, i])
					{
						flag2 = false;
						break;
					}
				}
				if (flag2)
				{
					if (!m_currentlyIsLegal)
					{
						bool_1 = true;
						m_currentlyIsLegal = true;
					}
					m_currentSeverityLevel = IllegalitySeverityLevel.None;
					m_currentIllegalityCanHighlightNode = false;
					bool_0 = false;
					return false;
				}
				if (int_ == 0 && int_2 == 0)
				{
					for (int j = 0; j < m_dimensionsSliceRowCol[2]; j++)
					{
						if (!method_131()[0, 0, j] || method_102(j).Count == 0)
						{
							continue;
						}
						int int_4 = method_257(j, 0, 0);
						if (method_287(int_4, j) == null)
						{
							if (m_currentlyIsLegal)
							{
								bool_1 = true;
								m_currentlyIsLegal = false;
							}
							m_currentSeverityLevel = IllegalitySeverityLevel.Error;
							m_currentIllegalityCanHighlightNode = true;
							m_currentIllegalityTexts.Add(Class333.BdV());
							bool_0 = false;
							return true;
						}
					}
				}
				else
				{
					for (int k = 0; k < m_dimensionsSliceRowCol[2]; k++)
					{
						if (!method_131()[0, 0, k])
						{
							continue;
						}
						int num = method_257(k, 0, 0);
						if ((num < int_ || num > int_2) && method_287(num, k) == null)
						{
							string arg = Class233.smethod_29(int_, int_3);
							string arg2 = Class233.smethod_29(int_2, int_3);
							if (m_currentlyIsLegal)
							{
								bool_1 = true;
								m_currentlyIsLegal = false;
							}
							m_currentSeverityLevel = IllegalitySeverityLevel.Error;
							m_currentIllegalityCanHighlightNode = true;
							m_currentIllegalityTexts.Add(string.Format(Class333.Bdu(), arg, arg2));
							bool_0 = false;
							return true;
						}
					}
				}
				return false;
			}
			Setting setting = this;
			int int_5 = int_;
			int int_6 = int_2;
			if (m_dataIdOfSettingContainingChannelIdForMinMaxAndUnits != 0)
			{
				setting = null;
				Setting setting2 = m_framework.method_31(m_dataIdOfSettingContainingChannelIdForMinMaxAndUnits);
				if (setting2 != null)
				{
					setting = m_framework.method_31(setting2.method_256());
					if (setting != null)
					{
						setting.method_230(ref int_, ref int_2, ref int_5, ref int_6);
						int_3 = setting.method_231();
					}
				}
			}
			if (setting == null)
			{
				return false;
			}
			bool result = false;
			int num2 = method_256();
			if (m_dimensionsSliceRowCol[0] == 1 && m_dimensionsSliceRowCol[1] == 1 && m_dimensionsSliceRowCol[2] == 1)
			{
				if ((int_5 == 0 && int_6 == 0) || (num2 >= int_5 && num2 <= int_6))
				{
					if (m_dataIdOfSettingContainingChannelIdForMinMaxAndUnits == 0 && method_102().Count != 0 && method_287(num2) == null)
					{
						if (m_currentlyIsLegal)
						{
							bool_1 = true;
							m_currentlyIsLegal = false;
						}
						m_currentSeverityLevel = IllegalitySeverityLevel.Error;
						m_currentIllegalityCanHighlightNode = true;
						m_currentIllegalityTexts.Add(Class333.BdV());
						bool_0 = false;
						result = true;
					}
				}
				else if (setting.method_287(num2) == null)
				{
					if (m_currentlyIsLegal)
					{
						bool_1 = true;
						m_currentlyIsLegal = false;
					}
					m_currentSeverityLevel = IllegalitySeverityLevel.Error;
					m_currentIllegalityCanHighlightNode = true;
					int int_7 = method_100();
					string text = Class233.smethod_29(num2, int_3, int_7);
					string text2 = Class233.smethod_29(int_5, int_3, int_7);
					string text3 = Class233.smethod_29(int_6, int_3, int_7);
					if (setting is SensorCalibration && int_5 > int_ && int_6 < int_2)
					{
						List<string> currentIllegalityTexts = m_currentIllegalityTexts;
						string format = Class333.Bdv();
						Struct64<object> gparam_ = default;
						Class332.smethod_1<Struct64<object>, object>(ref gparam_, 0) = text;
						Class332.smethod_1<Struct64<object>, object>(ref gparam_, 1) = setting.method_22(bool_0: true);
						Class332.smethod_1<Struct64<object>, object>(ref gparam_, 2) = text2;
						Class332.smethod_1<Struct64<object>, object>(ref gparam_, 3) = text3;
						currentIllegalityTexts.Add(string.Format(format, Class332.smethod_0<Struct64<object>, object>(in gparam_, 4)));
					}
					else
					{
						m_currentIllegalityTexts.Add(string.Format(Class333.smethod_1050(), text, text2, text3));
					}
					bool_0 = false;
					result = true;
				}
			}
			return result;
		}
		return false;
	}

	internal bool method_138(ref bool bool_0, ref bool bool_1)
	{
		if (m_isAttribute && m_parentSettingOrSpecialObject is Setting)
		{
			bool flag = false;
			if (m_attributeId == 8)
			{
				Setting setting = m_framework.method_32(new DataIdAndAttrId(m_dataId, 6));
				if (setting != null)
				{
					int num = method_256();
					int num2 = setting.method_256();
					if (num < num2)
					{
						m_currentIllegalityTexts.Add(Class333.BdW());
						bool_0 = false;
						flag = true;
					}
				}
			}
			else if (m_attributeId == 9)
			{
				Setting setting2 = m_framework.method_32(new DataIdAndAttrId(m_dataId, 7));
				if (setting2 != null)
				{
					int num3 = method_256();
					int num4 = setting2.method_256();
					if (num3 > num4)
					{
						m_currentIllegalityTexts.Add(Class333.Bdw());
						bool_0 = false;
						flag = true;
					}
				}
			}
			if (flag)
			{
				if (m_currentlyIsLegal)
				{
					bool_1 = true;
					m_currentlyIsLegal = false;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.Warning;
				m_currentIllegalityCanHighlightNode = true;
			}
			return flag;
		}
		return false;
	}

	internal bool method_139(ref bool bool_0, ref bool bool_1)
	{
		if (m_isAttribute && m_parentSettingOrSpecialObject is Setting)
		{
			bool flag = false;
			if (m_attributeId == 7)
			{
				Setting setting = m_framework.method_32(new DataIdAndAttrId(m_dataId, 6));
				if (setting != null)
				{
					int num = method_256();
					int num2 = setting.method_256();
					if (num < num2)
					{
						m_currentIllegalityTexts.Add(Class333.BdX());
						bool_0 = false;
						flag = true;
					}
				}
			}
			else if (m_attributeId == 6)
			{
				Setting setting2 = m_framework.method_32(new DataIdAndAttrId(m_dataId, 7));
				if (setting2 != null)
				{
					int num3 = method_256();
					int num4 = setting2.method_256();
					if (num3 > num4)
					{
						m_currentIllegalityTexts.Add(Class333.Bdx());
						bool_0 = false;
						flag = true;
					}
				}
			}
			if (flag)
			{
				if (m_currentlyIsLegal)
				{
					bool_1 = true;
					m_currentlyIsLegal = false;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				m_currentIllegalityCanHighlightNode = true;
			}
			return flag;
		}
		return false;
	}

	private bool method_140(ref bool bool_0, ref bool bool_1)
	{
		bool result = false;
		if (m_isChannelSelector || m_isConditionalActivatorChannelSelector)
		{
			Setting setting = m_framework.method_31(method_256());
			if (setting != null && setting.method_35() && PortFunction.smethod_52(setting))
			{
				if (!m_currentlyIsLegal)
				{
					bool_1 = true;
					m_currentlyIsLegal = true;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.None;
				m_currentIllegalityCanHighlightNode = false;
			}
			else
			{
				result = true;
				if (m_currentlyIsLegal)
				{
					bool_1 = true;
					m_currentlyIsLegal = false;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				m_currentIllegalityCanHighlightNode = true;
				if (setting == null)
				{
					m_currentIllegalityTexts.Add(Class333.BdY());
				}
				else
				{
					m_currentIllegalityTexts.Add(Class333.Bdy());
				}
				bool_0 = false;
			}
		}
		return result;
	}

	private bool method_141(ref bool bool_0, ref bool bool_1)
	{
		bool result = false;
		if (m_parentSettingOrSpecialObject is SensorCalibration && this == (m_parentSettingOrSpecialObject as SensorCalibration).CalibrationValueCountSetting && method_256() < 2)
		{
			result = true;
			if (m_currentlyIsLegal)
			{
				bool_1 = true;
				m_currentlyIsLegal = false;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.Error;
			m_currentIllegalityCanHighlightNode = true;
			m_currentIllegalityTexts.Add(Class333.BdZ());
			bool_0 = false;
		}
		return result;
	}

	private bool method_142(ref bool bool_0, ref bool bool_1)
	{
		bool result = false;
		if (method_207() && PortFunction.smethod_27(m_parentSettingOrSpecialObject))
		{
			int key = method_256();
			if (m_framework.awg.ContainsKey(key))
			{
				result = true;
				if (m_currentlyIsLegal)
				{
					bool_1 = true;
					m_currentlyIsLegal = false;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				m_currentIllegalityCanHighlightNode = true;
				m_currentIllegalityTexts.Add(m_framework.awg[key]);
				bool_0 = false;
			}
		}
		return result;
	}

	private void method_143(Class255 class255_0, ref bool bool_0, ref bool bool_1)
	{
		if (this != class255_0.BZk && this != class255_0.BZL)
		{
			return;
		}
		HashSet<string> hashSet = new HashSet<string>();
		int num = class255_0.BZl.method_242()[2];
		for (int i = 0; i < num; i++)
		{
			int num2 = class255_0.BZl.method_258(i);
			if (!CANFrameModel.IsFrameVisible((byte)num2) || !CANFrameModel.IsFrameEnabled((byte)num2))
			{
				continue;
			}
			if (this == class255_0.BZk)
			{
				string text = method_261(i);
				if (string.IsNullOrWhiteSpace(text))
				{
					bool_0 = true;
					string item = Class333.Bdz();
					if (!m_currentIllegalityTexts.Contains(item))
					{
						m_currentIllegalityTexts.Add(item);
					}
				}
				else if (hashSet.Contains(text))
				{
					bool_0 = true;
					string item2 = Class333.BEA();
					if (!m_currentIllegalityTexts.Contains(item2))
					{
						m_currentIllegalityTexts.Add(item2);
					}
				}
				else
				{
					hashSet.Add(text);
				}
			}
			else
			{
				if (this != class255_0.BZL)
				{
					continue;
				}
				int num3 = method_258(i);
				bool flag = CANFrameModel.IsFrameStdId((uint)num3);
				uint num4 = (uint)(num3 & 0x7FFFFFFF);
				if (flag ? (num4 > 2047) : (num4 > 536870911))
				{
					bool_0 = true;
					string item3 = Class333.BEa();
					if (!m_currentIllegalityTexts.Contains(item3))
					{
						m_currentIllegalityTexts.Add(item3);
					}
				}
				else if (flag && class255_0.BZI.Contains((ushort)num4))
				{
					bool_0 = true;
					string item4 = Class333.BEB() + num4.ToString(Class333.smethod_380()) + Class333.BEb();
					if (!m_currentIllegalityTexts.Contains(item4))
					{
						m_currentIllegalityTexts.Add(item4);
					}
				}
				else if (!flag && class255_0.BZJ.Contains(num4))
				{
					bool_0 = true;
					string item5 = Class333.BEB() + num4.ToString(Class333.smethod_379()) + Class333.BEb();
					if (!m_currentIllegalityTexts.Contains(item5))
					{
						m_currentIllegalityTexts.Add(item5);
					}
				}
			}
		}
	}

	private void method_144(Class255 class255_0, ref bool bool_0, ref bool bool_1)
	{
		if (this != class255_0.BZm && this != class255_0.BZq && this != class255_0.BZo && this != class255_0.BZP && this != class255_0.BZn && this != class255_0.BZr)
		{
			return;
		}
		HashSet<string> hashSet = new HashSet<string>();
		Dictionary<int, CANFrameModel> dictionary = new Dictionary<int, CANFrameModel>();
		int num = class255_0.BZN.method_242()[2];
		for (int i = 0; i < num; i++)
		{
			int num2 = class255_0.BZN.method_258(i);
			if (num2 == -1)
			{
				continue;
			}
			int num3 = num2;
			int num4 = class255_0.BZl.method_258(num3);
			if (!CANFrameModel.IsFrameVisible((byte)num4) || !CANFrameModel.IsFrameEnabled((byte)num4))
			{
				continue;
			}
			if (this == class255_0.BZm)
			{
				string text = method_261(i);
				if (string.IsNullOrWhiteSpace(text))
				{
					bool_0 = true;
					string item = Class333.BEC();
					if (!m_currentIllegalityTexts.Contains(item))
					{
						m_currentIllegalityTexts.Add(item);
					}
				}
				else if (hashSet.Contains(text))
				{
					bool_0 = true;
					string item2 = Class333.BEc();
					if (!m_currentIllegalityTexts.Contains(item2))
					{
						m_currentIllegalityTexts.Add(item2);
					}
				}
				else
				{
					hashSet.Add(text);
				}
			}
			else if (this == class255_0.BZn)
			{
				if (method_258(i) == 1)
				{
					bool_0 = true;
					string item3 = Class333.BED();
					if (!m_currentIllegalityTexts.Contains(item3))
					{
						m_currentIllegalityTexts.Add(item3);
					}
				}
			}
			else if (this == class255_0.BZr)
			{
				int num5 = method_258(i);
				if (num5 == -1 || num5 == 65535)
				{
					bool_0 = true;
					string item4 = Class333.BEd();
					if (!m_currentIllegalityTexts.Contains(item4))
					{
						m_currentIllegalityTexts.Add(item4);
					}
				}
			}
			else if (this == class255_0.BZq)
			{
				if (method_258(i) == 0)
				{
					bool_1 = true;
					string item5 = Class333.BEE();
					if (!m_currentIllegalityTexts.Contains(item5))
					{
						m_currentIllegalityTexts.Add(item5);
					}
				}
			}
			else if (this == class255_0.BZo || this == class255_0.BZP)
			{
				if (!dictionary.ContainsKey(num3))
				{
					CANFrameModel cANFrameModel = CANFrameModel.smethod_0(class255_0, (uint)num3);
					cANFrameModel.Signals = new List<CANSignalModel>();
					dictionary.Add(num3, cANFrameModel);
				}
				CANSignalModel item6 = CANSignalModel.smethod_0(class255_0, m_framework, null, num3, i);
				dictionary[num3].Signals.Add(item6);
			}
		}
		if (this == class255_0.BZo || this == class255_0.BZP)
		{
			method_145(class255_0, dictionary, ref bool_0);
		}
	}

	private void method_145(Class255 class255_0, Dictionary<int, CANFrameModel> dictionary_0, ref bool bool_0)
	{
		bool flag = false;
		bool flag2 = false;
		foreach (CANFrameModel value in dictionary_0.Values)
		{
			foreach (CANSignalModel signal in value.Signals)
			{
				int num = -1;
				uint num2 = 0u;
				uint num3 = 8 * value.Length;
				if (signal.Format == 1)
				{
					num2 = signal.StartBit + signal.BitLength - 1;
					for (uint num4 = signal.StartBit; num4 < signal.StartBit + signal.BitLength; num4++)
					{
						if (!value.method_1(num4))
						{
							if (num4 < num3)
							{
								value.method_0(num4);
							}
							continue;
						}
						num = (int)num4;
						break;
					}
				}
				else if (signal.Format == 0)
				{
					num2 = signal.StartBit;
					for (int i = 0; i < signal.BitLength; i++)
					{
						if (value.method_1(num2) && num == -1)
						{
							num = (int)num2;
						}
						else
						{
							value.method_0(num2);
						}
						if (i != signal.BitLength - 1)
						{
							num2 = ((num2 % 8 != 0) ? (num2 - 1) : (num2 + 15));
						}
					}
				}
				if (num2 >= num3)
				{
					flag2 = true;
					bool_0 = true;
					string item = Class333.BEe();
					if (!m_currentIllegalityTexts.Contains(item))
					{
						m_currentIllegalityTexts.Add(item);
					}
				}
				if (num != -1)
				{
					flag = true;
					bool_0 = true;
					string item2 = Class333.BEF();
					if (!m_currentIllegalityTexts.Contains(item2))
					{
						m_currentIllegalityTexts.Add(item2);
					}
				}
				if (flag & flag2)
				{
					return;
				}
			}
		}
	}

	private bool method_146(ref bool bool_0, ref bool bool_1)
	{
		bool result = false;
		if (m_parentSettingOrSpecialObject != null && (m_parentSettingOrSpecialObject is Class255 || m_parentSettingOrSpecialObject.method_6() is Class255))
		{
			Class255 class255_ = ((m_parentSettingOrSpecialObject is Class255) ? (m_parentSettingOrSpecialObject as Class255) : (m_parentSettingOrSpecialObject.method_6() as Class255));
			bool bool_2 = false;
			bool bool_3 = false;
			method_143(class255_, ref bool_2, ref bool_3);
			method_144(class255_, ref bool_2, ref bool_3);
			if (bool_2 | bool_3)
			{
				result = true;
				if (m_currentlyIsLegal)
				{
					bool_1 = true;
					m_currentlyIsLegal = false;
				}
				else if (!bool_1)
				{
					if (m_currentIllegalityTexts.Count != m_previousIllegalityTexts.Count)
					{
						bool_1 = true;
					}
					else
					{
						for (int i = 0; i < m_currentIllegalityTexts.Count; i++)
						{
							if (m_currentIllegalityTexts[i] != m_previousIllegalityTexts[i])
							{
								bool_1 = true;
								break;
							}
						}
					}
				}
				m_currentSeverityLevel = ((!bool_2) ? IllegalitySeverityLevel.Warning : IllegalitySeverityLevel.Error);
				m_currentIllegalityCanHighlightNode = bool_2;
				bool_0 = false;
			}
		}
		return result;
	}

	internal bool method_147(ref bool bool_0)
	{
		if (m_dataId != 1501)
		{
			return false;
		}
		bool flag = false;
		string text = method_260();
		if (text.Length >= 2 && text[0] != ' ' && text[0] != '\0')
		{
			if (Class22.smethod_2(text) || text.Contains(Class333.smethod_100()))
			{
				flag = true;
				m_currentIllegalityTexts.Add(Class333.aBV());
			}
		}
		else
		{
			flag = true;
			m_currentIllegalityTexts.Add(Class333.BEf());
		}
		if (flag)
		{
			if (m_currentlyIsLegal)
			{
				bool_0 = true;
				m_currentlyIsLegal = false;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.Error;
			m_currentIllegalityCanHighlightNode = true;
		}
		else
		{
			m_framework.aXD = string.Empty;
		}
		return flag;
	}

	[SpecialName]
	internal string method_148()
	{
		return m_metaDataString;
	}

	[SpecialName]
	internal void method_149(string string_0)
	{
		m_metaDataString = string_0;
	}

	[SpecialName]
	internal bool method_150()
	{
		return m_isPortFunctionEnabler;
	}

	[SpecialName]
	internal void method_151(bool bool_0)
	{
		m_isPortFunctionEnabler = bool_0;
	}

	[SpecialName]
	internal MenuNode method_152()
	{
		return m_isFunctionEnablerForMenuNode;
	}

	[SpecialName]
	internal void method_153(MenuNode menuNode_0)
	{
		m_isFunctionEnablerForMenuNode = menuNode_0;
	}

	[SpecialName]
	internal bool method_154()
	{
		return m_isEnabler;
	}

	[SpecialName]
	internal void method_155(bool bool_0)
	{
		m_isEnabler = bool_0;
	}

	[SpecialName]
	internal byte method_156()
	{
		return m_enablesExternalDevice;
	}

	[SpecialName]
	internal void method_157(byte byte_0)
	{
		m_enablesExternalDevice = byte_0;
	}

	[SpecialName]
	internal List<byte> method_158()
	{
		if (m_deviceIdCanBeChangedTo == null)
		{
			m_deviceIdCanBeChangedTo = new List<byte>();
		}
		return m_deviceIdCanBeChangedTo;
	}

	[SpecialName]
	internal bool method_159()
	{
		return m_isChannelSelector;
	}

	[SpecialName]
	internal void method_160(bool bool_0)
	{
		m_isChannelSelector = bool_0;
	}

	[SpecialName]
	internal int method_161()
	{
		return m_channelSelectorApplyChannelNameToSettingId;
	}

	[SpecialName]
	internal void method_162(int int_0)
	{
		m_channelSelectorApplyChannelNameToSettingId = int_0;
	}

	[SpecialName]
	internal DataIdAndAttrId method_163()
	{
		return m_idOfSettingContainingDisplayUnits;
	}

	[SpecialName]
	internal void method_164(DataIdAndAttrId dataIdAndAttrId_0)
	{
		m_idOfSettingContainingDisplayUnits = dataIdAndAttrId_0;
	}

	[SpecialName]
	internal bool method_165()
	{
		return m_isConditionalActivatorChannelSelector;
	}

	[SpecialName]
	internal void method_166(bool bool_0)
	{
		m_isConditionalActivatorChannelSelector = bool_0;
	}

	[SpecialName]
	internal int method_167()
	{
		return m_fixedAxisType;
	}

	[SpecialName]
	internal void method_168(int int_0)
	{
		m_fixedAxisType = int_0;
	}

	[SpecialName]
	internal bool method_169()
	{
		return m_isColourPicker;
	}

	[SpecialName]
	internal void method_170(bool bool_0)
	{
		m_isColourPicker = bool_0;
	}

	internal bool method_171()
	{
		if (m_isResourcePickerForTheseFileExtensions != null && m_isResourcePickerForTheseFileExtensions.Count != 0)
		{
			return Class247.smethod_7(Brh) != null;
		}
		return false;
	}

	[SpecialName]
	internal List<string> method_172()
	{
		return m_isResourcePickerForTheseFileExtensions;
	}

	[SpecialName]
	internal void method_173(List<string> list_0)
	{
		m_isResourcePickerForTheseFileExtensions = list_0;
	}

	[SpecialName]
	internal Class1.Enum5 method_174()
	{
		return Brh;
	}

	[SpecialName]
	internal void method_175(Class1.Enum5 enum5_0)
	{
		Brh = enum5_0;
	}

	[SpecialName]
	internal bool method_176()
	{
		return m_isResourcePickerForSplashScreen;
	}

	[SpecialName]
	internal void method_177(bool bool_0)
	{
		m_isResourcePickerForSplashScreen = bool_0;
	}

	[SpecialName]
	internal Size method_178()
	{
		return m_isResourcePickerForFixedResolution;
	}

	[SpecialName]
	internal void method_179(Size size_0)
	{
		m_isResourcePickerForFixedResolution = size_0;
	}

	[SpecialName]
	internal int method_180()
	{
		return m_isResourcePickerForFixedBitDepth;
	}

	[SpecialName]
	internal void method_181(int int_0)
	{
		m_isResourcePickerForFixedBitDepth = int_0;
	}

	[SpecialName]
	internal int method_182()
	{
		return m_dataIdOfResourceCRCSetting;
	}

	[SpecialName]
	internal void method_183(int int_0)
	{
		m_dataIdOfResourceCRCSetting = int_0;
	}

	[SpecialName]
	internal bool method_184()
	{
		return m_userSearchable;
	}

	[SpecialName]
	internal void method_185(bool bool_0)
	{
		m_userSearchable = bool_0;
	}

	[SpecialName]
	internal List<Struct44> method_186()
	{
		return BrH;
	}

	[SpecialName]
	internal int method_187()
	{
		return m_attrIdToOverride;
	}

	[SpecialName]
	internal void method_188(int int_0)
	{
		m_attrIdToOverride = int_0;
	}

	[SpecialName]
	internal int method_189()
	{
		return m_dataIdOfAttrOverrideEnabler;
	}

	[SpecialName]
	internal void method_190(int int_0)
	{
		m_dataIdOfAttrOverrideEnabler = int_0;
	}

	[SpecialName]
	internal int method_191()
	{
		return m_attrOverrideChanSelectorSettingId;
	}

	[SpecialName]
	internal void method_192(int int_0)
	{
		m_attrOverrideChanSelectorSettingId = int_0;
	}

	[SpecialName]
	internal int method_193()
	{
		return m_attrOverrideChanId;
	}

	[SpecialName]
	internal void method_194(int int_0)
	{
		m_attrOverrideChanId = int_0;
	}

	[SpecialName]
	internal string method_195()
	{
		return m_helpPath;
	}

	[SpecialName]
	internal void method_196(string string_0)
	{
		m_helpPath = string_0;
	}

	internal void method_197(int int_0, string string_0)
	{
		m_valueSupplier.BYl = int_0;
		m_valueSupplier.BYM = string_0;
	}

	internal ValueSupplier method_198()
	{
		return m_valueSupplier;
	}

	[SpecialName]
	internal int method_199()
	{
		return m_numBytesPerCell;
	}

	[SpecialName]
	internal void method_200(int int_0)
	{
		m_numBytesPerCell = int_0;
	}

	[SpecialName]
	internal bool method_201()
	{
		return m_valuesAreSigned;
	}

	[SpecialName]
	internal void method_202(bool bool_0)
	{
		m_valuesAreSigned = bool_0;
	}

	internal bool method_203()
	{
		return (method_215(Enum94.aYL) & 1) != 0;
	}

	internal bool method_204()
	{
		return (method_215(Enum94.aYL) & 2) != 0;
	}

	internal bool method_205()
	{
		return (method_215(Enum94.aYL) & 4) != 0;
	}

	internal bool method_206()
	{
		return (method_215(Enum94.aYL) & 8) != 0;
	}

	internal bool method_207()
	{
		return (method_215(Enum94.aYL) & 0x10) != 0;
	}

	internal bool method_208()
	{
		return (method_215(Enum94.aYL) & 0x20) != 0;
	}

	internal bool method_209()
	{
		return (method_215(Enum94.aYL) & 0x40) != 0;
	}

	internal bool method_210()
	{
		return (method_215(Enum94.aYL) & 0x80) != 0;
	}

	internal bool method_211()
	{
		return method_215(Enum94.aYL) == 27;
	}

	[SpecialName]
	internal bool method_212()
	{
		return method_215(Enum94.aYQ) != 0;
	}

	internal void method_213(Enum94 enum94_0, int int_0, bool bool_0, string string_0, int int_1)
	{
		m_intProperties[(int)enum94_0].method_0(int_0, bool_0, string_0, int_1);
	}

	internal bool method_214(Enum94 enum94_0)
	{
		return m_intProperties[(int)enum94_0].BYt;
	}

	internal int method_215(Enum94 enum94_0)
	{
		return m_intProperties[(int)enum94_0].method_1(m_framework);
	}

	internal int method_216(Enum94 enum94_0)
	{
		if (m_intProperties[(int)enum94_0].BYv)
		{
			int bYU = m_intProperties[(int)enum94_0].BYU;
			if (m_intProperties[(int)enum94_0].BYX == Class333.aJn())
			{
				return m_framework.method_31(bYU).method_216(Enum94.aYl);
			}
			if (m_intProperties[(int)enum94_0].BYX == Class333.aJO())
			{
				return m_framework.method_31(bYU).method_216(Enum94.aYM);
			}
			if (m_intProperties[(int)enum94_0].BYX == Class333.ais())
			{
				return m_framework.method_31(bYU).method_216(Enum94.aYm);
			}
			if (m_intProperties[(int)enum94_0].BYX == Class333.aiT())
			{
				return m_framework.method_31(bYU).method_216(Enum94.aYN);
			}
			if (m_intProperties[(int)enum94_0].BYX == Class333.aJo())
			{
				return m_framework.method_31(bYU).method_216(Enum94.aYn);
			}
			if (m_intProperties[(int)enum94_0].BYX == Class333.ain())
			{
				return m_framework.method_31(bYU).method_216(Enum94.aYO);
			}
			if (m_intProperties[(int)enum94_0].BYX == Class333.aio())
			{
				return m_framework.method_31(bYU).method_216(Enum94.aYP);
			}
			if (m_intProperties[(int)enum94_0].BYX == Class333.aJh())
			{
				return m_framework.method_31(bYU).method_216(Enum94.aYp);
			}
			if (m_intProperties[(int)enum94_0].BYX == Class333.aJC())
			{
				return m_framework.method_31(bYU).method_216(Enum94.aYR);
			}
			if (m_intProperties[(int)enum94_0].BYX == Class333.aJc())
			{
				return m_framework.method_31(bYU).method_216(Enum94.aYr);
			}
			return bYU;
		}
		return -1;
	}

	[SpecialName]
	internal List<int> method_217()
	{
		return m_fixedValue;
	}

	[SpecialName]
	internal void method_218(List<int> list_0)
	{
		m_fixedValue = list_0;
		m_useFixedValue = true;
	}

	[SpecialName]
	internal bool method_219()
	{
		return m_useFixedValue;
	}

	[SpecialName]
	internal bool method_220()
	{
		return method_215(Enum94.aYq) != 0;
	}

	[SpecialName]
	internal int method_221()
	{
		return method_215(Enum94.aYp);
	}

	[SpecialName]
	internal int method_222()
	{
		return method_215(Enum94.aYR);
	}

	[SpecialName]
	internal int method_223()
	{
		return method_215(Enum94.aYr);
	}

	internal int method_224()
	{
		if (method_214(Enum94.aYn))
		{
			return method_215(Enum94.aYn);
		}
		if (m_isAttribute && m_parentSettingOrSpecialObject is Setting)
		{
			return (m_parentSettingOrSpecialObject as Setting).method_224();
		}
		return method_228();
	}

	internal int method_225()
	{
		if (method_214(Enum94.aYO))
		{
			return method_215(Enum94.aYO);
		}
		if (m_isAttribute && m_parentSettingOrSpecialObject is Setting)
		{
			return (m_parentSettingOrSpecialObject as Setting).method_225();
		}
		return method_229();
	}

	internal int method_226()
	{
		if (method_207())
		{
			int num = method_215(Enum94.aYm);
			int num2 = method_215(Enum94.aYN);
			if (num == 0 && num2 == 0)
			{
				num = method_215(Enum94.aYl);
			}
			return num;
		}
		throw new Exception(Class333.BEG());
	}

	internal int method_227()
	{
		if (method_207())
		{
			int num = method_215(Enum94.aYm);
			int num2 = method_215(Enum94.aYN);
			if (num == 0 && num2 == 0)
			{
				num2 = method_215(Enum94.aYM);
			}
			return num2;
		}
		throw new Exception(Class333.BEg());
	}

	internal int method_228()
	{
		int num = method_215(Enum94.aYl);
		int num2 = method_215(Enum94.aYM);
		if (num == 0 && num2 == 0)
		{
			if (m_isAttribute && m_parentSettingOrSpecialObject is Setting)
			{
				return (m_parentSettingOrSpecialObject as Setting).method_228();
			}
			if (m_intProperties[3].BYv)
			{
				int bYU = m_intProperties[3].BYU;
				num = m_framework.method_31(bYU)?.method_228() ?? method_215(Enum94.aYm);
			}
			else
			{
				num = method_215(Enum94.aYm);
			}
		}
		return num;
	}

	internal int method_229()
	{
		int num = method_215(Enum94.aYl);
		int num2 = method_215(Enum94.aYM);
		if (num == 0 && num2 == 0)
		{
			if (m_isAttribute && m_parentSettingOrSpecialObject is Setting)
			{
				return (m_parentSettingOrSpecialObject as Setting).method_229();
			}
			if (m_intProperties[4].BYv)
			{
				int bYU = m_intProperties[4].BYU;
				num2 = m_framework.method_31(bYU)?.method_229() ?? method_215(Enum94.aYN);
			}
			else
			{
				num2 = method_215(Enum94.aYN);
			}
		}
		return num2;
	}

	internal void method_230(ref int int_0, ref int int_1, ref int int_2, ref int int_3)
	{
		int_0 = method_228();
		int_1 = method_229();
		if (this is SensorCalibration)
		{
			SensorCalibration sensorCalibration = this as SensorCalibration;
			if (sensorCalibration.CalibrationValuesSetting != null && sensorCalibration.CalibrationVoltagesSetting != null && sensorCalibration.CalibrationValuesSetting.method_35() && sensorCalibration.CalibrationVoltagesSetting.method_35())
			{
				int_2 = sensorCalibration.GetMinCalibrationValue();
				int_3 = sensorCalibration.GetMaxCalibrationValue();
				if (int_2 < int_0)
				{
					int_2 = int_0;
				}
				if (int_3 > int_1)
				{
					int_3 = int_1;
				}
			}
			else
			{
				int_2 = int_0;
				int_3 = int_1;
			}
		}
		else
		{
			int_2 = int_0;
			int_3 = int_1;
		}
	}

	[SpecialName]
	internal int method_231()
	{
		if (m_isAttribute && m_parentSettingOrSpecialObject is Setting && !method_214(Enum94.aYP))
		{
			return (m_parentSettingOrSpecialObject as Setting).method_231();
		}
		return method_215(Enum94.aYP);
	}

	[SpecialName]
	internal int method_232()
	{
		if (m_isAttribute && m_parentSettingOrSpecialObject is Setting && !method_214(Enum94.aYP))
		{
			return (m_parentSettingOrSpecialObject as Setting).method_232();
		}
		return m_unitsOrder;
	}

	[SpecialName]
	internal void method_233(int int_0)
	{
		m_unitsOrder = int_0;
	}

	internal void method_234()
	{
		if (method_214(Enum94.aYS))
		{
			method_272(method_215(Enum94.aYS), bool_0: true);
			Form23.smethod_74(m_dataId);
		}
	}

	internal int method_235()
	{
		return method_215(Enum94.aYS);
	}

	[SpecialName]
	internal int method_236()
	{
		return m_terminatingValue;
	}

	[SpecialName]
	internal void method_237(int int_0)
	{
		m_terminatingValue = int_0;
	}

	[SpecialName]
	internal bool method_238()
	{
		return m_listOrder;
	}

	[SpecialName]
	internal void method_239(bool bool_0)
	{
		m_listOrder = bool_0;
	}

	[SpecialName]
	internal int method_240()
	{
		return m_visibleDimensions;
	}

	[SpecialName]
	internal void method_241(int int_0)
	{
		m_visibleDimensions = int_0;
	}

	[SpecialName]
	internal int[] method_242()
	{
		return m_dimensionsSliceRowCol;
	}

	[SpecialName]
	internal void method_243(int[] int_0)
	{
		m_dimensionsSliceRowCol = int_0;
	}

	[SpecialName]
	internal byte[] method_244()
	{
		return m_defaultDataBytes;
	}

	[SpecialName]
	internal void method_245(byte[] byte_0)
	{
		m_defaultDataBytes = byte_0;
	}

	internal bool method_246(bool bool_0)
	{
		bool result = false;
		if (m_defaultDataBytes != null)
		{
			result = method_275(m_defaultDataBytes, bool_0);
		}
		else if (method_205())
		{
			result = method_279(bool_0);
		}
		return result;
	}

	internal bool method_247(int int_0, bool bool_0)
	{
		bool flag = false;
		if (m_defaultDataBytes != null && m_defaultDataBytes.Length >= method_278())
		{
			for (int i = 0; i < m_numBytesPerCell; i++)
			{
				int num = m_numBytesPerCell * int_0 + i;
				flag = method_270(num, m_defaultDataBytes[num], bool_0) | flag;
			}
		}
		else if (method_205())
		{
			flag = method_274(int_0, 0, bool_0);
		}
		return flag;
	}

	internal int method_248(int int_0)
	{
		if (m_defaultDataBytes != null && m_defaultDataBytes.Length >= method_278())
		{
			return Class23.smethod_5(m_defaultDataBytes, m_numBytesPerCell * int_0, m_numBytesPerCell, m_valuesAreSigned, m_framework.aWR);
		}
		return 0;
	}

	internal string method_249()
	{
		if (m_encoding != 0 && m_defaultDataBytes != null && m_defaultDataBytes.Length >= method_278())
		{
			Encoding encoding = Encoding.GetEncoding(m_encoding);
			byte[] array = new byte[m_dimensionsSliceRowCol[2] * m_numBytesPerCell];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = m_defaultDataBytes[i];
			}
			return encoding.GetString(array).TrimEnd('\0');
		}
		return string.Empty;
	}

	internal int method_250(int int_0, int int_1, int int_2)
	{
		return m_dimensionsSliceRowCol[2] * m_dimensionsSliceRowCol[1] * int_2 + m_dimensionsSliceRowCol[2] * int_1 + int_0;
	}

	internal int method_251(int int_0, int int_1, int int_2)
	{
		return m_numBytesPerCell * method_250(int_0, int_1, int_2);
	}

	internal (string DisplayValueString, string UnitsString, bool IsListItem) method_252()
	{
		return method_253(method_256());
	}

	internal (string DisplayValueString, string UnitsString, bool IsListItem) method_253(int int_0, int int_1 = -1)
	{
		if (m_encoding != 0)
		{
			return (DisplayValueString: method_260(), UnitsString: string.Empty, IsListItem: false);
		}
		string item = string.Empty;
		string text = method_287(int_0);
		if (text == null)
		{
			text = method_289(int_0);
		}
		bool item2;
		if (text != null)
		{
			item2 = true;
		}
		else
		{
			item2 = false;
			text = Class233.smethod_29(int_0, method_231(), int_1);
			item = Class233.smethod_35(method_232(), method_231(), bool_0: true, int_0, int_1);
		}
		return (DisplayValueString: text, UnitsString: item, IsListItem: item2);
	}

	internal byte method_254(int int_0)
	{
		byte result = 0;
		if (!m_useFixedValue)
		{
			if (m_byteAddress == -1)
			{
				return 0;
			}
			result = ((!method_207()) ? m_framework.method_21()[m_byteAddress + int_0] : m_framework.method_23()[m_byteAddress + int_0]);
		}
		else if (m_numBytesPerCell == 1)
		{
			result = ((int_0 >= m_fixedValue.Count) ? ((byte)m_fixedValue[0]) : ((byte)m_fixedValue[int_0]));
		}
		else if (m_numBytesPerCell == 2)
		{
			uint num = (uint)((int_0 / 2 >= m_fixedValue.Count) ? m_fixedValue[0] : m_fixedValue[int_0 / 2]);
			int num2 = int_0 % 2;
			if (m_framework.aWR)
			{
				switch (num2)
				{
				case 0:
					result = (byte)((num >> 8) & 0xFF);
					break;
				case 1:
					result = (byte)(num & 0xFF);
					break;
				}
			}
			else
			{
				switch (num2)
				{
				case 1:
					result = (byte)((num >> 8) & 0xFF);
					break;
				case 0:
					result = (byte)(num & 0xFF);
					break;
				}
			}
		}
		else if (m_numBytesPerCell == 4)
		{
			uint num3 = (uint)((int_0 / 4 >= m_fixedValue.Count) ? m_fixedValue[0] : m_fixedValue[int_0 / 4]);
			int num4 = int_0 % 4;
			if (m_framework.aWR)
			{
				switch (num4)
				{
				case 0:
					result = (byte)((num3 >> 24) & 0xFF);
					break;
				case 1:
					result = (byte)((num3 >> 16) & 0xFF);
					break;
				case 2:
					result = (byte)((num3 >> 8) & 0xFF);
					break;
				case 3:
					result = (byte)(num3 & 0xFF);
					break;
				}
			}
			else
			{
				switch (num4)
				{
				case 3:
					result = (byte)((num3 >> 24) & 0xFF);
					break;
				case 2:
					result = (byte)((num3 >> 16) & 0xFF);
					break;
				case 1:
					result = (byte)((num3 >> 8) & 0xFF);
					break;
				case 0:
					result = (byte)(num3 & 0xFF);
					break;
				}
			}
		}
		return result;
	}

	internal int method_255(int int_0)
	{
		int result = 0;
		if (m_useFixedValue)
		{
			if (m_numBytesPerCell == 1)
			{
				if (m_valuesAreSigned)
				{
					result = ((int_0 >= m_fixedValue.Count) ? m_fixedValue[0] : m_fixedValue[int_0]);
				}
				else
				{
					result = ((int_0 >= m_fixedValue.Count) ? (m_fixedValue[0] & 0xFF) : (m_fixedValue[int_0] & 0xFF));
				}
			}
			else if (m_numBytesPerCell == 2)
			{
				if (m_valuesAreSigned)
				{
					result = ((int_0 / 2 >= m_fixedValue.Count) ? m_fixedValue[0] : m_fixedValue[int_0 / 2]);
				}
				else
				{
					result = ((int_0 / 2 >= m_fixedValue.Count) ? (m_fixedValue[0] & 0xFFFF) : (m_fixedValue[int_0 / 2] & 0xFFFF));
				}
			}
			else if (m_numBytesPerCell == 4)
			{
				result = ((int_0 / 4 >= m_fixedValue.Count) ? m_fixedValue[0] : m_fixedValue[int_0 / 4]);
			}
		}
		else if (m_byteAddress != -1)
		{
			result = ((!method_207()) ? Class23.smethod_5(m_framework.method_21(), m_byteAddress + int_0, m_numBytesPerCell, m_valuesAreSigned, m_framework.aWR) : Class23.smethod_5(m_framework.method_23(), m_byteAddress + int_0, m_numBytesPerCell, m_valuesAreSigned, m_framework.aWR));
		}
		return result;
	}

	internal int method_256()
	{
		return method_255(0);
	}

	internal int method_257(int int_0, int int_1, int int_2)
	{
		return method_255(method_251(int_0, int_1, int_2));
	}

	internal int method_258(int int_0)
	{
		return method_255(method_251(int_0, 0, 0));
	}

	internal byte[] method_259()
	{
		int num = method_278();
		byte[] array = new byte[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = method_254(i);
		}
		return array;
	}

	internal string method_260()
	{
		return method_261(-1);
	}

	internal string method_261(int int_0)
	{
		if (m_encoding != 0)
		{
			Encoding encoding = Encoding.GetEncoding(m_encoding);
			byte[] array;
			if (int_0 == -1)
			{
				array = new byte[m_dimensionsSliceRowCol[2] * m_numBytesPerCell];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = method_254(i);
				}
			}
			else
			{
				array = new byte[m_dimensionsSliceRowCol[1] * m_numBytesPerCell];
				int num = int_0 * m_dimensionsSliceRowCol[1];
				for (int j = 0; j < array.Length; j++)
				{
					array[j] = method_254(num + j);
				}
			}
			return encoding.GetString(array).TrimEnd('\0');
		}
		return string.Empty;
	}

	internal void method_262(string string_0, bool bool_0)
	{
		method_263(string_0, -1, bool_0);
	}

	internal void method_263(string string_0, int int_0, bool bool_0)
	{
		if (m_encoding == 0)
		{
			return;
		}
		bool flag = method_266();
		method_268();
		bool flag2 = m_framework.method_53();
		m_framework.method_55();
		byte[] bytes = Encoding.GetEncoding(m_encoding).GetBytes(string_0);
		if (int_0 == -1)
		{
			for (int i = 0; i < m_dimensionsSliceRowCol[2]; i++)
			{
				if (i < bytes.Length)
				{
					method_270(i, bytes[i], bool_0);
				}
				else
				{
					method_270(i, 0, bool_0);
				}
			}
		}
		else
		{
			int num = int_0 * m_dimensionsSliceRowCol[1];
			for (int j = 0; j < m_dimensionsSliceRowCol[1]; j++)
			{
				if (j < bytes.Length)
				{
					method_270(num + j, bytes[j], bool_0);
				}
				else
				{
					method_270(num + j, 0, bool_0);
				}
			}
		}
		if (flag2)
		{
			m_framework.method_54(bool_0: true, this);
		}
		if (flag)
		{
			method_267(bool_0: true);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_264(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BrI;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BrI, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_265(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BrI;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BrI, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	protected virtual void OnDataChangedHandler()
	{
		if (!m_useFixedValue && method_220() && m_framework.aWX && m_defaultDataBytes != null)
		{
			for (int i = 0; i < m_dimensionsSliceRowCol[0]; i++)
			{
				for (int j = 0; j < m_dimensionsSliceRowCol[1]; j++)
				{
					for (int k = 0; k < m_dimensionsSliceRowCol[2]; k++)
					{
						int num = Class23.smethod_5(m_defaultDataBytes, method_251(k, j, i), m_numBytesPerCell, m_valuesAreSigned, m_framework.aWR);
						if (method_257(k, j, i) == num)
						{
							continue;
						}
						lock (m_framework.method_26())
						{
							if (!m_framework.method_26().Contains(this))
							{
								m_framework.method_26().Add(this);
							}
						}
					}
				}
			}
		}
		if (BrI != null)
		{
			BrI(this, null);
		}
	}

	[SpecialName]
	internal bool method_266()
	{
		return Bri;
	}

	internal void method_267(bool bool_0)
	{
		Bri = true;
		if (bool_0)
		{
			OnDataChangedHandler();
		}
	}

	internal void method_268()
	{
		Bri = false;
	}

	internal void method_269()
	{
		if (!method_207())
		{
			throw new Exception(Class333.BEH());
		}
		if (m_framework.method_9())
		{
			bool flag = m_idsWithEquationsAffectedByThisSetting.Count != 0 || m_objectIdsWithEquationsAffectedByThisSetting.Count != 0;
			bool flag2 = PortFunction.smethod_27(m_parentSettingOrSpecialObject);
			if (flag | flag2)
			{
				int num = method_277();
				int[] array = new int[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = method_258(i);
				}
				bool flag3 = false;
				if (BrJ == null)
				{
					BrJ = new int[num];
					flag3 = true;
				}
				else
				{
					for (int j = 0; j < num; j++)
					{
						if (array[j] != BrJ[j])
						{
							flag3 = true;
							break;
						}
					}
				}
				if (flag3)
				{
					if (flag)
					{
						Form23.smethod_74(m_dataId);
					}
					else if (flag2)
					{
						int key = array[0];
						int key2 = BrJ[0];
						if (m_framework.awg.ContainsKey(key) || m_framework.awg.ContainsKey(key2))
						{
							Form23.smethod_74(m_dataId);
						}
					}
					for (int k = 0; k < num; k++)
					{
						BrJ[k] = array[k];
					}
				}
			}
		}
		OnDataChangedHandler();
	}

	internal bool method_270(int int_0, byte byte_0, bool bool_0)
	{
		if (!m_useFixedValue && m_byteAddress != -1)
		{
			if (method_220() && m_framework.aWX && m_defaultDataBytes != null && byte_0 != m_defaultDataBytes[int_0])
			{
				byte_0 = m_defaultDataBytes[int_0];
			}
			Class280 @class = null;
			Class278 class2 = null;
			if (bool_0 && !method_207() && !Form23.bool_14)
			{
				@class = Form23.smethod_95();
				if (@class != null && @class.method_0())
				{
					class2 = @class.method_5();
					class2.method_1(this);
					class2.method_2(this, int_0, 1);
				}
			}
			bool result = false;
			if (method_207())
			{
				if (m_framework.method_23()[m_byteAddress + int_0] != byte_0)
				{
					m_framework.method_23()[m_byteAddress + int_0] = byte_0;
					result = true;
				}
			}
			else if (m_framework.method_21()[m_byteAddress + int_0] != byte_0)
			{
				m_framework.method_21()[m_byteAddress + int_0] = byte_0;
				result = true;
			}
			if (bool_0)
			{
				if (method_207())
				{
					m_framework.method_24()[m_byteAddress + int_0] = Enum93.aYK;
				}
				else
				{
					m_framework.method_22()[m_byteAddress + int_0] = Enum93.aYK;
				}
				if (method_205() || m_metaDataString.Length != 0)
				{
					m_framework.aXd = true;
					m_framework.aXE = true;
				}
			}
			if (method_266())
			{
				OnDataChangedHandler();
			}
			if (m_framework.method_53() && !method_207())
			{
				m_framework.method_52(this);
			}
			if (@class != null && @class.method_0())
			{
				class2.method_3(this, int_0, 1);
			}
			return result;
		}
		return false;
	}

	internal bool method_271(int int_0, int int_1, bool bool_0)
	{
		if (!m_useFixedValue && m_byteAddress != -1)
		{
			if (method_220() && m_framework.aWX && m_defaultDataBytes != null)
			{
				int num = Class23.smethod_5(m_defaultDataBytes, int_0, m_numBytesPerCell, m_valuesAreSigned, m_framework.aWR);
				if (int_1 != num)
				{
					int_1 = num;
				}
			}
			Class280 @class = null;
			Class278 class2 = null;
			if (bool_0 && !method_207() && !Form23.bool_14)
			{
				@class = Form23.smethod_95();
				if (@class != null && @class.method_0())
				{
					class2 = @class.method_5();
					class2.method_1(this);
					class2.method_2(this, int_0, m_numBytesPerCell);
				}
			}
			bool result = ((!method_207()) ? Class23.smethod_6(int_1, m_framework.method_21(), m_byteAddress + int_0, m_numBytesPerCell, m_framework.aWR) : Class23.smethod_6(int_1, m_framework.method_23(), m_byteAddress + int_0, m_numBytesPerCell, m_framework.aWR));
			if (bool_0)
			{
				for (int i = 0; i < m_numBytesPerCell; i++)
				{
					if (method_207())
					{
						m_framework.method_24()[m_byteAddress + int_0 + i] = Enum93.aYK;
					}
					else
					{
						m_framework.method_22()[m_byteAddress + int_0 + i] = Enum93.aYK;
					}
				}
				if (method_205() || m_metaDataString.Length != 0)
				{
					m_framework.aXd = true;
					m_framework.aXE = true;
				}
			}
			if (method_266())
			{
				OnDataChangedHandler();
			}
			if (m_framework.method_53() && !method_207())
			{
				m_framework.method_52(this);
			}
			if (@class != null && @class.method_0())
			{
				class2.method_3(this, int_0, m_numBytesPerCell);
			}
			return result;
		}
		return false;
	}

	internal bool method_272(int int_0, bool bool_0)
	{
		return method_271(0, int_0, bool_0);
	}

	internal bool method_273(int int_0, int int_1, int int_2, int int_3, bool bool_0)
	{
		return method_271(method_251(int_0, int_1, int_2), int_3, bool_0);
	}

	internal bool method_274(int int_0, int int_1, bool bool_0)
	{
		return method_271(method_251(int_0, 0, 0), int_1, bool_0);
	}

	internal bool method_275(byte[] byte_0, bool bool_0)
	{
		bool flag = false;
		bool flag2 = method_266();
		method_268();
		bool flag3 = m_framework.method_53();
		m_framework.method_55();
		int num = Math.Min(method_278(), byte_0.Length);
		for (int i = 0; i < num; i++)
		{
			flag = method_270(i, byte_0[i], bool_0) | flag;
		}
		if (flag3)
		{
			m_framework.method_54(bool_0: true, this);
		}
		if (flag2)
		{
			method_267(bool_0: true);
		}
		return flag;
	}

	internal bool method_276(int[] int_0, bool bool_0)
	{
		bool flag = false;
		bool flag2 = method_266();
		method_268();
		bool flag3 = m_framework.method_53();
		m_framework.method_55();
		int num = Math.Min(method_277(), int_0.Length);
		for (int i = 0; i < num; i++)
		{
			flag = method_274(i, int_0[i], bool_0) | flag;
		}
		if (flag3)
		{
			m_framework.method_54(bool_0: true, this);
		}
		if (flag2)
		{
			method_267(bool_0: true);
		}
		return flag;
	}

	internal int method_277()
	{
		return m_dimensionsSliceRowCol[0] * m_dimensionsSliceRowCol[1] * m_dimensionsSliceRowCol[2];
	}

	internal int method_278()
	{
		return m_numBytesPerCell * method_277();
	}

	internal bool method_279(bool bool_0)
	{
		bool flag = false;
		bool flag2 = method_266();
		method_268();
		bool flag3 = m_framework.method_53();
		m_framework.method_55();
		int num = method_278();
		for (int i = 0; i < num; i++)
		{
			flag = method_270(i, 0, bool_0) | flag;
		}
		if (flag3)
		{
			m_framework.method_54(bool_0: true, this);
		}
		if (flag2)
		{
			method_267(bool_0: true);
		}
		return flag;
	}

	internal bool method_280()
	{
		int num = method_278();
		int num2 = 0;
		while (true)
		{
			if (num2 < num)
			{
				if (method_254(num2) != 0)
				{
					break;
				}
				num2++;
				continue;
			}
			return true;
		}
		return false;
	}

	internal bool method_281(Setting setting_0, int int_0)
	{
		if (m_numBytesPerCell != setting_0.method_199())
		{
			return false;
		}
		if (int_0 >= method_277())
		{
			return false;
		}
		if (int_0 >= setting_0.method_277())
		{
			return false;
		}
		return method_258(int_0) == setting_0.method_258(int_0);
	}

	internal bool method_282(Setting setting_0)
	{
		int num = method_277();
		if (num != setting_0.method_277())
		{
			return false;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < num)
			{
				if (method_258(num2) != setting_0.method_258(num2))
				{
					break;
				}
				num2++;
				continue;
			}
			return true;
		}
		return false;
	}

	internal bool method_283(int[] int_0)
	{
		if (int_0 != null && int_0.Length <= method_277())
		{
			int num = Math.Min(int_0.Length, method_277());
			int num2 = 0;
			while (true)
			{
				if (num2 < num)
				{
					if (method_258(num2) != int_0[num2])
					{
						break;
					}
					num2++;
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	internal bool method_284(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			return false;
		}
		int num = method_278();
		if (num != byte_0.Length)
		{
			return false;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < num)
			{
				if (method_254(num2) != byte_0[num2])
				{
					break;
				}
				num2++;
				continue;
			}
			return true;
		}
		return false;
	}

	internal List<Setting> method_285()
	{
		List<Setting> list = new List<Setting>();
		List<ListItems.Struct45> list2 = method_103();
		for (int i = 0; i < list2.Count; i++)
		{
			if (list2[i].bBW != 0)
			{
				Setting setting = m_framework.method_31(list2[i].bBW);
				if (setting != null)
				{
					list.Add(setting);
				}
			}
		}
		return list;
	}

	internal string method_286()
	{
		return method_287(method_256());
	}

	internal string method_287(int int_0, int int_1 = 0)
	{
		List<ListItems.Struct45> list = method_102(int_1);
		int num = 0;
		while (true)
		{
			if (num < list.Count)
			{
				if (list[num].bBv == int_0)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		if (list[num].bBW != 0)
		{
			Setting setting = m_framework.method_31(list[num].bBW);
			if (setting != null)
			{
				string text = setting.method_260();
				if (string.IsNullOrWhiteSpace(text))
				{
					return list[num].bBV;
				}
				return text;
			}
			return list[num].bBV;
		}
		return list[num].bBV;
	}

	internal string method_288()
	{
		return method_289(method_256());
	}

	internal string method_289(int int_0, int int_1 = 0)
	{
		string text = null;
		List<MaskItems.Struct47> list = method_106(int_1);
		for (int i = 0; i < list.Count; i++)
		{
			if ((int_0 & list[i].bbB) == list[i].bba)
			{
				if (text == null)
				{
					text = list[i].bbA;
					continue;
				}
				string text2 = ((m_maskJoinText != null) ? m_maskJoinText : string.Empty);
				text = text + text2 + list[i].bbA;
			}
		}
		return text;
	}

	internal bool method_290(int int_0, int int_1 = 0)
	{
		List<ListItems.Struct45> list = method_102(int_1);
		bool flag = false;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].bBv == int_0)
			{
				flag = true;
				break;
			}
		}
		List<MaskItems.Struct47> list2 = method_106(int_1);
		bool flag2 = false;
		for (int j = 0; j < list2.Count; j++)
		{
			if ((int_0 & list2[j].bbB) == list2[j].bba)
			{
				flag2 = true;
				break;
			}
		}
		return flag | flag2;
	}

	internal Image method_291()
	{
		return method_292(method_256());
	}

	internal Image method_292(int int_0)
	{
		List<ListItems.Struct45> list = method_102();
		int num = 0;
		while (true)
		{
			if (num < list.Count)
			{
				if (list[num].bBv == int_0)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		if (!string.IsNullOrEmpty(list[num].bBw))
		{
			byte[] array = Class24.smethod_1(list[num].bBw);
			if (array != null)
			{
				MemoryStream memoryStream = new MemoryStream(array);
				Image result = Image.FromStream(memoryStream);
				memoryStream.Close();
				return result;
			}
		}
		return null;
	}

	internal bool method_293()
	{
		List<ListItems.Struct45> list = method_103();
		int num = 0;
		while (true)
		{
			if (num < list.Count)
			{
				if (!string.IsNullOrEmpty(list[num].bBw))
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
}
