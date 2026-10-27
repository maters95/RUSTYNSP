using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using b;
using c;

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

	internal new enum a
	{
		BYi = -1,
		BYJ,
		BYj,
		BYK
	}

	internal new struct B
	{
		internal int BYk;

		internal a BYL;
	}

	public struct ValueSupplier
	{
		internal int BYl;

		internal string BYM;
	}

	public class ListItems
	{
		internal struct A
		{
			internal string bBu;

			internal string bBV;

			internal int bBv;

			internal int bBW;

			internal string bBw;

			internal string bBX;

			internal string bBx;
		}

		internal List<List<A>> BYm = new List<List<A>>();

		internal List<A> BYN = new List<A>();

		internal Dictionary<int, List<A>> BYn = new Dictionary<int, List<A>>();
	}

	public class ValDescs
	{
		internal struct A
		{
			internal string bBY;

			internal string bBy;

			internal int bBZ;
		}

		internal List<List<A>> BYO = new List<List<A>>();

		internal List<A> BYo = new List<A>();

		internal Dictionary<int, List<A>> BYP = new Dictionary<int, List<A>>();
	}

	public class MaskItems
	{
		internal struct A
		{
			internal string bBz;

			internal string bbA;

			internal int bba;

			internal int bbB;
		}

		internal List<List<A>> BYp = new List<List<A>>();

		internal List<A> BYQ = new List<A>();

		internal Dictionary<int, List<A>> BYq = new Dictionary<int, List<A>>();
	}

	protected class LegalOn
	{
		internal string BYR;

		internal string BYr;

		internal IllegalitySeverityLevel BYS;

		internal bool BYs;

		internal int BYT;

		internal LegalOn(string P_0, string P_1, IllegalitySeverityLevel P_2, bool P_3, int P_4)
		{
			BYR = P_0;
			BYr = P_1;
			BYS = P_2;
			BYs = P_3;
			BYT = P_4;
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

		internal void A(int P_0, bool P_1, string P_2, int P_3)
		{
			if (P_3 == -1)
			{
				BYu = P_0;
				BYU = P_0;
				BYW = P_1;
				BYv = P_1;
				BYx = P_2;
				BYX = P_2;
			}
			else
			{
				if (!BYy.Contains(P_3))
				{
					BYV.Add(P_3, P_0);
					BYw.Add(P_3, P_1);
					BYY.Add(P_3, P_2);
				}
				BYy.Add(P_3);
			}
			BYt = true;
		}

		internal int A(Framework P_0)
		{
			if (BYv)
			{
				Setting setting = P_0.A(BYU);
				if (setting == null)
				{
					return 0;
				}
				if (BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJn())
				{
					return setting.a(bZ.aYl);
				}
				if (BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJO())
				{
					return setting.a(bZ.aYM);
				}
				if (BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ais())
				{
					return setting.a(bZ.aYm);
				}
				if (BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiT())
				{
					return setting.a(bZ.aYN);
				}
				if (BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJo())
				{
					return setting.a(bZ.aYn);
				}
				if (BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ain())
				{
					return setting.a(bZ.aYO);
				}
				if (BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aio())
				{
					return setting.a(bZ.aYP);
				}
				if (BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJh())
				{
					return setting.a(bZ.aYp);
				}
				if (BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJC())
				{
					return setting.a(bZ.aYR);
				}
				if (BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJc())
				{
					return setting.a(bZ.aYr);
				}
				return setting.ax();
			}
			return BYU;
		}

		public virtual string ToString()
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

	private List<B> BrH = new List<B>();

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

	private global::A.A.C Brh;

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

	internal Setting(Framework P_0, bool P_1, string P_2, int P_3, int P_4, SettingOrSpecialObject P_5, string P_6)
		: base(P_0, P_2, P_5, P_6)
	{
		m_isAttribute = P_1;
		if (P_1)
		{
			m_attributeId = P_3;
			m_dataId = m_parentDataId;
		}
		else
		{
			m_dataId = P_3;
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
		if (P_5 != null && P_5 is Table && m_internalName == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hh())
		{
			m_intProperties[8].A((P_5 as Table).aS(), false, null, -1);
		}
		A(bZ.aYL, 199, false, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay(), -1);
		m_byteAddress = P_4;
	}

	public virtual string ToString()
	{
		string brM = m_stringProperties[1].BrM;
		string text = ((brM == null) ? m_internalName : brM);
		if (aJ())
		{
			text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdH();
		}
		text = string.Concat(new string[7]
		{
			text,
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdh(),
			m_dataId.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.atC(),
			m_attributeId.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdI(),
			m_byteAddress.ToString()
		});
		if (m_encoding != 0)
		{
			string text2 = ay();
			return text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdi() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
		}
		int num = ax();
		return text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdJ() + num;
	}

	[SpecialName]
	internal new int A()
	{
		return m_dataId;
	}

	[SpecialName]
	internal new int a()
	{
		return m_byteAddress;
	}

	[SpecialName]
	internal new void A(int P_0)
	{
		m_byteAddress = P_0;
	}

	[SpecialName]
	internal new int B()
	{
		return m_attributeId;
	}

	[SpecialName]
	internal new bool b()
	{
		return m_isAttribute;
	}

	[SpecialName]
	internal new DataIdAndAttrId C()
	{
		return m_dataIdAndAttrId;
	}

	[SpecialName]
	internal new int c()
	{
		return m_encoding;
	}

	[SpecialName]
	internal new void a(int P_0)
	{
		m_encoding = P_0;
	}

	[SpecialName]
	internal new bool D()
	{
		return m_noImport;
	}

	[SpecialName]
	internal new void A(bool P_0)
	{
		m_noImport = P_0;
	}

	[SpecialName]
	internal new int d()
	{
		return m_templatedSettingType;
	}

	[SpecialName]
	internal new void B(int P_0)
	{
		m_templatedSettingType = P_0;
	}

	[SpecialName]
	internal new bool E()
	{
		return m_partialMapSettingAlwaysShow;
	}

	[SpecialName]
	internal new void a(bool P_0)
	{
		m_partialMapSettingAlwaysShow = P_0;
	}

	[SpecialName]
	internal new bool e()
	{
		return m_partialMapSettingShowOffset;
	}

	[SpecialName]
	internal void B(bool P_0)
	{
		m_partialMapSettingShowOffset = P_0;
	}

	[SpecialName]
	internal new string F()
	{
		return m_partialMapSettingNameWhenShowingOffset;
	}

	[SpecialName]
	internal new void A(string P_0)
	{
		m_partialMapSettingNameWhenShowingOffset = P_0;
	}

	[SpecialName]
	internal new string f()
	{
		return m_partialMapSettingHelpDescWhenShowingOffset;
	}

	[SpecialName]
	internal new void a(string P_0)
	{
		m_partialMapSettingHelpDescWhenShowingOffset = P_0;
	}

	[SpecialName]
	internal new bool G()
	{
		return m_partialMapSettingOffsetAllowWrap;
	}

	[SpecialName]
	internal void b(bool P_0)
	{
		m_partialMapSettingOffsetAllowWrap = P_0;
	}

	[SpecialName]
	internal new bool g()
	{
		return m_firmwareCanModify;
	}

	[SpecialName]
	internal void C(bool P_0)
	{
		m_firmwareCanModify = P_0;
	}

	[SpecialName]
	internal new int H()
	{
		return m_scopeFixedScaleValue;
	}

	[SpecialName]
	internal new void b(int P_0)
	{
		m_scopeFixedScaleValue = P_0;
	}

	[SpecialName]
	internal new int h()
	{
		return m_scopeFixedScaleOrder;
	}

	[SpecialName]
	internal new void C(int P_0)
	{
		m_scopeFixedScaleOrder = P_0;
	}

	[SpecialName]
	internal new string I()
	{
		return m_scopeChannelSelectionWarning;
	}

	[SpecialName]
	internal new void B(string P_0)
	{
		m_scopeChannelSelectionWarning = P_0;
	}

	[SpecialName]
	internal new int i()
	{
		return m_recommendedLoggingGroupNumber;
	}

	[SpecialName]
	internal void c(int P_0)
	{
		m_recommendedLoggingGroupNumber = P_0;
	}

	[SpecialName]
	internal new bool J()
	{
		return m_includedInPasswordProtection;
	}

	[SpecialName]
	internal void c(bool P_0)
	{
		m_includedInPasswordProtection = P_0;
	}

	[SpecialName]
	internal new int j()
	{
		return m_dataIdOfSettingContainingChannelIdForMinMaxAndUnits;
	}

	[SpecialName]
	internal void D(int P_0)
	{
		m_dataIdOfSettingContainingChannelIdForMinMaxAndUnits = P_0;
	}

	internal new int K()
	{
		Setting setting = null;
		if (m_idOfSettingContainingDisplayUnits.DataId != 0)
		{
			setting = m_framework.A(m_idOfSettingContainingDisplayUnits);
		}
		if (setting == null && m_isAttribute && m_parentSettingOrSpecialObject is Setting)
		{
			setting = m_framework.A(new DataIdAndAttrId(m_dataId, 4));
		}
		if (setting != null)
		{
			int num = setting.ax();
			if (((num >> 8) & 0xFF) == aS())
			{
				return num & 0xFF;
			}
		}
		return -1;
	}

	private new List<ListItems.A> k()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		List<ListItems.A> val = new List<ListItems.A>();
		if (m_framework.aXK != null && m_framework.aXK.QuantityTypesPerUnitType.ContainsKey(aS()))
		{
			Enumerator<Unit> enumerator = m_framework.aXK.QuantityTypesPerUnitType[aS()].UnitsList.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Unit current = enumerator.Current;
					ListItems.A a = default(ListItems.A);
					a.bBv = current.ListItemVal;
					a.bBV = current.ListItemText;
					val.Add(a);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		return val;
	}

	internal List<ListItems.A> d(int P_0 = 0)
	{
		if (m_isAttribute && m_attributeId == 4)
		{
			return k();
		}
		if (m_hasMultiCellCondProperties && P_0 >= 0 && P_0 < m_listItems.BYm.Count)
		{
			return m_listItems.BYm[P_0];
		}
		if (!m_hasMultiCellCondProperties && m_listItems.BYm.Count != 0)
		{
			return m_listItems.BYm[0];
		}
		return new List<ListItems.A>();
	}

	[SpecialName]
	internal new List<ListItems.A> L()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		if (m_isAttribute && m_attributeId == 4)
		{
			return k();
		}
		List<ListItems.A> val = new List<ListItems.A>();
		if (m_listItems.BYN != null)
		{
			val.AddRange((System.Collections.Generic.IEnumerable<ListItems.A>)m_listItems.BYN);
		}
		Enumerator<int, List<ListItems.A>> enumerator = m_listItems.BYn.Values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				List<ListItems.A> current = enumerator.Current;
				if (current != null)
				{
					val.AddRange((System.Collections.Generic.IEnumerable<ListItems.A>)current);
				}
			}
			return val;
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal List<ValDescs.A> E(int P_0 = 0)
	{
		if (m_hasMultiCellCondProperties && P_0 >= 0 && P_0 < m_valDescs.BYO.Count)
		{
			return m_valDescs.BYO[P_0];
		}
		if (!m_hasMultiCellCondProperties && m_valDescs.BYO.Count != 0)
		{
			return m_valDescs.BYO[0];
		}
		return new List<ValDescs.A>();
	}

	[SpecialName]
	internal new List<ValDescs.A> l()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		List<ValDescs.A> val = new List<ValDescs.A>();
		if (m_valDescs.BYo != null)
		{
			val.AddRange((System.Collections.Generic.IEnumerable<ValDescs.A>)m_valDescs.BYo);
		}
		Enumerator<int, List<ValDescs.A>> enumerator = m_valDescs.BYP.Values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				List<ValDescs.A> current = enumerator.Current;
				if (current != null)
				{
					val.AddRange((System.Collections.Generic.IEnumerable<ValDescs.A>)current);
				}
			}
			return val;
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal List<MaskItems.A> e(int P_0 = 0)
	{
		if (m_hasMultiCellCondProperties && P_0 >= 0 && P_0 < m_maskItems.BYp.Count)
		{
			return m_maskItems.BYp[P_0];
		}
		if (!m_hasMultiCellCondProperties && m_maskItems.BYp.Count != 0)
		{
			return m_maskItems.BYp[0];
		}
		return new List<MaskItems.A>();
	}

	[SpecialName]
	internal new string M()
	{
		return m_maskJoinText;
	}

	[SpecialName]
	internal new void b(string P_0)
	{
		m_maskJoinText = P_0;
	}

	internal void A(ConvertFrom P_0)
	{
		m_convertFromsList.Add(P_0);
	}

	internal void A(ConvertTo P_0)
	{
		m_convertTosList.Add(P_0);
	}

	[SpecialName]
	internal new List<ConvertFrom> m()
	{
		return m_convertFromsList;
	}

	[SpecialName]
	internal List<ConvertTo> N()
	{
		return m_convertTosList;
	}

	internal void A(Framework P_0, bool P_1, bool P_2 = false)
	{
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (m_framework.awZ == 20 || m_framework.awZ == 25 || m_framework.awZ == 24 || m_framework.awZ == 21) && bx.A(P_0.awZ);
		bool flag2 = bx.A(m_framework.awZ) && (P_0.awZ == 20 || P_0.awZ == 25 || P_0.awZ == 24 || P_0.awZ == 21);
		bool flag3 = flag || (!flag2 && P_0.aXA <= m_framework.aXA);
		bool flag4 = flag2 || (!flag && P_0.aXA > m_framework.aXA);
		Setting setting = P_0.A(m_dataIdAndAttrId);
		if (setting == null)
		{
			if (m_dataId == 9496)
			{
				int num = BB();
				for (int i = 0; i < num; i++)
				{
					A(i, (byte)255, P_1);
				}
			}
			else
			{
				I(P_1);
			}
		}
		if (flag3)
		{
			A(P_0, setting, P_1);
		}
		else if (flag4)
		{
			a(P_0, setting, P_1);
		}
		else if (setting != null)
		{
			A(setting, P_1);
		}
		if (this is Dn)
		{
			List<Setting> val = new List<Setting>();
			PortFunction.A(this as Dn, val, false);
			Enumerator<Setting> enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.A(P_0, P_1);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			List<Table> val2 = new List<Table>();
			PortFunction.A(this as Dn, val2, false);
			Enumerator<Table> enumerator2 = val2.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					enumerator2.Current.ImportFromAnotherFramework(P_0, P_1);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
		}
		if (P_2 && y())
		{
			Di.A(this, P_1);
		}
	}

	private void A(Framework P_0, Setting P_1, bool P_2)
	{
		List<int[]> val = new List<int[]>();
		for (int i = 0; i < m_convertFromsList.Count; i++)
		{
			ConvertFrom convertFrom = m_convertFromsList[i];
			if (convertFrom.A() == P_0.awZ && (convertFrom.a() == -1 || convertFrom.a() == P_0.awz))
			{
				k k = null;
				k k2 = null;
				if (convertFrom.B() != null)
				{
					k = new k(convertFrom.B(), false);
				}
				if (convertFrom.b() != null)
				{
					k2 = new k(convertFrom.b(), false);
				}
				if ((k == null || P_0.aXA >= k) && (k2 == null || P_0.aXA <= k2))
				{
					convertFrom.A(this, m_framework, P_0, val, P_2);
				}
			}
		}
		if (val.Count == 0)
		{
			if (m_dataId == 1501 && bx.A(P_0.awZ) && P_0.aXA.A() < 3)
			{
				int num = BB();
				for (int j = 0; j < num; j++)
				{
					A(j, (byte)0, P_2);
				}
			}
			else if (P_1 != null)
			{
				int num2 = Math.Min(m_dimensionsSliceRowCol[0], P_1.av()[0]);
				int num3 = Math.Min(m_dimensionsSliceRowCol[1], P_1.av()[1]);
				int num4 = Math.Min(m_dimensionsSliceRowCol[2], P_1.av()[2]);
				bool flag = base.D() is Table && this == (base.D() as Table).TableDataSetting && P_1.Ba() == 1;
				for (int l = 0; l < m_dimensionsSliceRowCol[0]; l++)
				{
					for (int m = 0; m < m_dimensionsSliceRowCol[1]; m++)
					{
						for (int n = 0; n < m_dimensionsSliceRowCol[2]; n++)
						{
							if (l < num2 && m < num3 && n < num4)
							{
								A(n, m, l, P_1.B(n, m, l), P_2);
							}
							else if (flag)
							{
								A(n, m, l, P_1.ax(), P_2);
							}
							else
							{
								A(n, m, l, m_terminatingValue, P_2);
							}
						}
					}
				}
			}
		}
		if (!(base.D() is TableAxis))
		{
			return;
		}
		TableAxis tableAxis = base.D() as TableAxis;
		if (this == tableAxis.f())
		{
			int num5 = ar();
			if (ax() > num5)
			{
				a(num5, P_2);
			}
		}
	}

	private void a(Framework P_0, Setting P_1, bool P_2)
	{
		if (P_1 != null)
		{
			List<int[]> val = new List<int[]>();
			for (int i = 0; i < P_1.N().Count; i++)
			{
				ConvertTo convertTo = P_1.N()[i];
				if (convertTo.A() == P_0.awZ && (convertTo.a() == -1 || convertTo.a() == P_0.awz))
				{
					k k = null;
					k k2 = null;
					if (convertTo.B() != null)
					{
						k = new k(convertTo.B(), false);
					}
					if (convertTo.b() != null)
					{
						k2 = new k(convertTo.b(), false);
					}
					if ((k == null || m_framework.aXA >= k) && (k2 == null || m_framework.aXA <= k2))
					{
						convertTo.A(this, m_framework, P_0, val, P_2);
					}
				}
			}
			if (val.Count == 0)
			{
				int num = Math.Min(m_dimensionsSliceRowCol[0], P_1.av()[0]);
				int num2 = Math.Min(m_dimensionsSliceRowCol[1], P_1.av()[1]);
				int num3 = Math.Min(m_dimensionsSliceRowCol[2], P_1.av()[2]);
				bool flag = base.D() is Table && this == (base.D() as Table).TableDataSetting && P_1.Ba() == 1;
				for (int j = 0; j < m_dimensionsSliceRowCol[0]; j++)
				{
					for (int l = 0; l < m_dimensionsSliceRowCol[1]; l++)
					{
						for (int m = 0; m < m_dimensionsSliceRowCol[2]; m++)
						{
							if (j < num && l < num2 && m < num3)
							{
								A(m, l, j, P_1.B(m, l, j), P_2);
							}
							else if (flag)
							{
								A(m, l, j, P_1.ax(), P_2);
							}
							else
							{
								A(m, l, j, m_terminatingValue, P_2);
							}
						}
					}
				}
			}
		}
		if (!(base.D() is TableAxis))
		{
			return;
		}
		TableAxis tableAxis = base.D() as TableAxis;
		if (this == tableAxis.f())
		{
			int num4 = ar();
			if (ax() > num4)
			{
				a(num4, P_2);
			}
		}
	}

	internal void A(Setting P_0, bool P_1)
	{
		int num = m_dimensionsSliceRowCol[0];
		if (P_0.av()[0] != num)
		{
			return;
		}
		int num2 = m_dimensionsSliceRowCol[1];
		if (P_0.av()[1] != num2)
		{
			return;
		}
		int num3 = m_dimensionsSliceRowCol[2];
		if (P_0.av()[2] != num3)
		{
			return;
		}
		bool flag = aZ();
		az();
		bool flag2 = m_framework.l();
		m_framework.M();
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				for (int k = 0; k < num3; k++)
				{
					A(k, j, i, P_0.B(k, j, i), P_1);
				}
			}
		}
		if (flag2)
		{
			m_framework.A(true, this);
		}
		if (flag)
		{
			this.i(true);
		}
	}

	internal void A(Setting P_0, StringBuilder P_1)
	{
		if (P_1 == null || aJ() || al() || m_useFixedValue || aN() || !aI() || P_0.aJ() || P_0.al() || P_0.am() || P_0.aN() || !P_0.aI())
		{
			return;
		}
		int num = Ba();
		int num2 = P_0.Ba();
		int num3 = aG();
		int num4 = P_0.aG();
		if (num != num2 || num3 != num4)
		{
			P_1.Append(string.Concat(new string[9]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdj(),
				base.A(bz.aYt),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
				m_dataId.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdk(),
				(num * num3).ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdL(),
				(num2 * num4).ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdl()
			}));
			return;
		}
		if (m_encoding != 0)
		{
			string text = ay();
			string text2 = P_0.ay();
			if (text != text2)
			{
				P_1.Append(string.Concat(new string[9]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdj(),
					base.A(bz.aYt),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
					m_dataId.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdM(),
					text,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdm(),
					text2,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdN()
				}));
			}
			return;
		}
		for (int i = 0; i < num; i++)
		{
			int num5 = m(i);
			int num6 = P_0.m(i);
			if (num5 != num6)
			{
				int num7 = P_0.aS();
				string text3 = a(num5, i);
				string text4 = P_0.a(num6, i);
				string text5 = ((num > 1) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdn() + i) : string.Empty);
				if (text3 != null && text4 != null)
				{
					P_1.Append(string.Concat(new string[11]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdj(),
						base.A(bz.aYt),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
						m_dataId.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(),
						text5,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdO(),
						text3,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdm(),
						text4,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdN()
					}));
				}
				else if (aS() != num7 || @as() != P_0.@as() || aS() == 0 || aS() == 82 || (text3 == null && text4 != null) || (text3 != null && text4 == null))
				{
					P_1.Append(string.Concat(new string[11]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdj(),
						base.A(bz.aYt),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
						m_dataId.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(),
						text5,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdo(),
						num5.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdP(),
						num6.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdp()
					}));
				}
				else
				{
					string text6 = bS.a(num5, aS(), -1) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + bS.A(@as(), aS(), true, num5);
					string text7 = bS.a(num6, aS(), -1) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + bS.A(@as(), aS(), true, num6);
					P_1.Append(string.Concat(new string[15]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdj(),
						base.A(bz.aYt),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdK(),
						m_dataId.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(),
						text5,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdo(),
						text6,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdQ(),
						num5.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdq(),
						text7,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdQ(),
						num6.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdR()
					}));
				}
			}
		}
	}

	internal void A(string P_0, int P_1, int P_2, int P_3)
	{
		MultiCellCondition multiCellCondition = default(MultiCellCondition);
		multiCellCondition.BYg = P_0;
		multiCellCondition.BYH = P_1;
		multiCellCondition.BYh = P_2;
		multiCellCondition.BYI = P_3;
		m_multiCellEnableOnConditions.Add(multiCellCondition);
	}

	[SpecialName]
	internal new List<MultiCellCondition> n()
	{
		return m_multiCellEnableOnConditions;
	}

	internal void A(string P_0, IllegalitySeverityLevel P_1, bool P_2, string P_3, int P_4)
	{
		m_allLegalOns.Add(new LegalOn(P_0, P_3, P_1, P_2, P_4));
	}

	internal new bool C(string P_0)
	{
		for (int i = 0; i < m_allLegalOns.Count; i++)
		{
			if (m_allLegalOns[i].BYR.Contains(P_0))
			{
				return true;
			}
		}
		return false;
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
		int num = ((!m_hasMultiCellCondProperties) ? 1 : Ba());
		for (int j = 0; j < num; j++)
		{
			m_listItems.BYm.Add(new List<ListItems.A>());
			m_listItems.BYm[j].AddRange((System.Collections.Generic.IEnumerable<ListItems.A>)m_listItems.BYN);
			m_valDescs.BYO.Add(new List<ValDescs.A>());
			m_valDescs.BYO[j].AddRange((System.Collections.Generic.IEnumerable<ValDescs.A>)m_valDescs.BYo);
			m_maskItems.BYp.Add(new List<MaskItems.A>());
			m_maskItems.BYp[j].AddRange((System.Collections.Generic.IEnumerable<MaskItems.A>)m_maskItems.BYQ);
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
			List<ListItems.A> val = m_listItems.BYn[condPropertiesBlockIndex];
			m_listItems.BYm[cellIndex].AddRange((System.Collections.Generic.IEnumerable<ListItems.A>)val);
		}
		if (m_valDescs.BYP.ContainsKey(condPropertiesBlockIndex))
		{
			List<ValDescs.A> val2 = m_valDescs.BYP[condPropertiesBlockIndex];
			m_valDescs.BYO[cellIndex].AddRange((System.Collections.Generic.IEnumerable<ValDescs.A>)val2);
		}
		if (m_maskItems.BYq.ContainsKey(condPropertiesBlockIndex))
		{
			List<MaskItems.A> val3 = m_maskItems.BYq[condPropertiesBlockIndex];
			m_maskItems.BYp[cellIndex].AddRange((System.Collections.Generic.IEnumerable<MaskItems.A>)val3);
		}
	}

	[SpecialName]
	internal new bool O()
	{
		return m_currentlyIsLegal;
	}

	[SpecialName]
	internal new List<string> o()
	{
		return m_currentIllegalityTexts;
	}

	[SpecialName]
	internal new IllegalitySeverityLevel P()
	{
		return m_currentSeverityLevel;
	}

	[SpecialName]
	internal new bool p()
	{
		return m_currentIllegalityCanHighlightNode;
	}

	[SpecialName]
	internal new List<HashSet<int>> Q()
	{
		return m_dataIdsInIllegalityEquations;
	}

	internal void A(int P_0, string P_1)
	{
		a bYL = ((P_1 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm()) ? Setting.a.BYi : ((!(P_1 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ib())) ? ((P_1 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks()) ? Setting.a.BYj : ((P_1 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.g()) ? Setting.a.BYK : Setting.a.BYJ)) : Setting.a.BYJ));
		BrH.Add(new B
		{
			BYk = P_0,
			BYL = bYL
		});
	}

	internal void A(string P_0, string P_1, int P_2, int P_3, string P_4, string P_5, string P_6, int P_7)
	{
		ListItems.A a = default(ListItems.A);
		a.bBu = P_0;
		a.bBV = P_1;
		a.bBv = P_2;
		a.bBW = P_3;
		a.bBw = P_4;
		a.bBX = P_5;
		a.bBx = P_6;
		if (P_7 == -1)
		{
			m_listItems.BYN.Add(a);
			if (m_listItems.BYm.Count == 0)
			{
				m_listItems.BYm.Add(new List<ListItems.A>());
			}
			m_listItems.BYm[0].Add(a);
		}
		else
		{
			if (!m_listItems.BYn.ContainsKey(P_7))
			{
				m_listItems.BYn.Add(P_7, new List<ListItems.A>());
			}
			m_listItems.BYn[P_7].Add(a);
		}
	}

	internal void A(string P_0, string P_1, int P_2, int P_3)
	{
		ValDescs.A a = default(ValDescs.A);
		a.bBY = P_0;
		a.bBy = P_1;
		a.bBZ = P_2;
		if (P_3 == -1)
		{
			m_valDescs.BYo.Add(a);
			if (m_valDescs.BYO.Count == 0)
			{
				m_valDescs.BYO.Add(new List<ValDescs.A>());
			}
			m_valDescs.BYO[0].Add(a);
		}
		else
		{
			if (!m_valDescs.BYP.ContainsKey(P_3))
			{
				m_valDescs.BYP.Add(P_3, new List<ValDescs.A>());
			}
			m_valDescs.BYP[P_3].Add(a);
		}
	}

	internal void A(string P_0, string P_1, int P_2, int P_3, int P_4)
	{
		MaskItems.A a = default(MaskItems.A);
		a.bBz = P_0;
		a.bbA = P_1;
		a.bba = P_2;
		a.bbB = P_3;
		if (P_4 == -1)
		{
			m_maskItems.BYQ.Add(a);
			if (m_maskItems.BYp.Count == 0)
			{
				m_maskItems.BYp.Add(new List<MaskItems.A>());
			}
			m_maskItems.BYp[0].Add(a);
		}
		else
		{
			if (!m_maskItems.BYq.ContainsKey(P_4))
			{
				m_maskItems.BYq.Add(P_4, new List<MaskItems.A>());
			}
			m_maskItems.BYq[P_4].Add(a);
		}
	}

	[SpecialName]
	internal new bool[,,] q()
	{
		return m_currentMultiCellEnableOnSliceRowCol;
	}

	[SpecialName]
	internal new HashSet<DataIdAndAttrId> R()
	{
		return m_idsWithEquationsAffectedByThisSetting;
	}

	[SpecialName]
	internal new HashSet<int> r()
	{
		return m_objectIdsWithEquationsAffectedByThisSetting;
	}

	[SpecialName]
	internal new HashSet<FilterOption> S()
	{
		return m_filterOptionsWithEquationsAffectedByThisSetting;
	}

	protected override bool EvaluateCondPropertiesConditions(bool initInfluencingSettingIdsList)
	{
		bool result = m_conditionsPreviouslyMetPerCellPerCondPropertiesBlock.Count == 0 && m_condPropertiesBlocks.Count != 0;
		RevertAllConditionalPropertiesToDefaults();
		int num = Ba();
		for (int i = 0; i < m_condPropertiesBlocks.Count; i++)
		{
			string brK = m_condPropertiesBlocks[i].BrK;
			bool brk = m_condPropertiesBlocks[i].Brk;
			int num2 = ((!brk) ? 1 : m_dimensionsSliceRowCol[2]);
			int num3 = ((!brk) ? 1 : m_dimensionsSliceRowCol[1]);
			int num4 = ((!brk) ? 1 : m_dimensionsSliceRowCol[0]);
			for (int j = 0; j < num4; j++)
			{
				for (int k = 0; k < num3; k++)
				{
					for (int l = 0; l < num2; l++)
					{
						string text = brK.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdr(), l.ToString()).Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdS(), k.ToString()).Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bds(), j.ToString());
						int num5 = A(l, k, j);
						List<int> val = global::A.T.A(ref text, m_framework);
						if (initInfluencingSettingIdsList && num5 == 0)
						{
							for (int m = 0; m < val.Count; m++)
							{
								m_dataIdsInCondPropsEquations.Add(val[m]);
								m_framework.A(val[m]).R().Add(m_dataIdAndAttrId);
							}
						}
						bool flag = global::A.T.A(ref text);
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
				if (m_currentEnableOn != m_parentSettingOrSpecialObject.l())
				{
					flag = true;
					m_currentEnableOn = m_parentSettingOrSpecialObject.l();
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
				string brL = m_currentEnableOns[i].BrL;
				List<int> val = global::A.T.A(ref brL, m_framework);
				if (initInfluencingSettingIdsList)
				{
					for (int j = 0; j < val.Count; j++)
					{
						m_dataIdsInEnableOnEquations.Add(val[j]);
						m_framework.A(val[j]).R().Add(m_dataIdAndAttrId);
					}
				}
				bool flag3 = global::A.T.A(ref brL);
				flag2 = flag2 || flag3;
			}
			if (m_isAttribute && m_parentSettingOrSpecialObject != null)
			{
				bool flag4 = flag2 && m_parentSettingOrSpecialObject.l();
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
			string brL = m_multiCellEnableOnConditions[i].BYg;
			List<int> val2 = global::A.T.A(ref brL, m_framework);
			if (initInfluencingSettingIdsList)
			{
				for (int k = 0; k < val2.Count; k++)
				{
					m_dataIdsInEnableOnEquations.Add(val2[k]);
					m_framework.A(val2[k]).R().Add(m_dataIdAndAttrId);
				}
			}
			bool flag3 = global::A.T.A(ref brL);
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

	private void A(bool P_0, bool P_1, ref bool P_2)
	{
		if (m_currentLegalOns.Count != 0)
		{
			int num = 3;
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < m_currentLegalOns.Count; i++)
			{
				string bYR = m_currentLegalOns[i].BYR;
				List<int> val = global::A.T.A(ref bYR, m_framework);
				if (P_0)
				{
					HashSet<int> val2 = new HashSet<int>();
					for (int j = 0; j < val.Count; j++)
					{
						val2.Add(val[j]);
						m_framework.A(val[j]).R().Add(m_dataIdAndAttrId);
					}
					m_dataIdsInIllegalityEquations.Add(val2);
				}
				if (!P_1)
				{
					continue;
				}
				bool flag3 = global::A.T.A(ref bYR);
				flag2 = flag2 || flag3;
				string text;
				if (flag3)
				{
					num = Math.Min(num, (int)m_currentLegalOns[i].BYS);
					text = m_currentLegalOns[i].BYr;
					if (!flag)
					{
						flag = m_currentLegalOns[i].BYs;
					}
				}
				else
				{
					text = string.Empty;
				}
				if (m_currentIllegalityTexts.Count == i)
				{
					m_currentIllegalityTexts.Add(text);
				}
				else if (i < m_currentIllegalityTexts.Count)
				{
					m_currentIllegalityTexts.Insert(i, text);
				}
				else
				{
					m_currentIllegalityTexts.Add(text);
				}
			}
			if (P_1)
			{
				bool flag4 = !flag2;
				if (m_currentlyIsLegal != flag4)
				{
					P_2 = true;
					m_currentlyIsLegal = flag4;
				}
				if (m_currentSeverityLevel != (IllegalitySeverityLevel)num)
				{
					P_2 = true;
					m_currentSeverityLevel = (IllegalitySeverityLevel)num;
				}
				m_currentIllegalityCanHighlightNode = flag;
			}
		}
		else
		{
			if (!m_currentlyIsLegal)
			{
				P_2 = true;
				m_currentlyIsLegal = true;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.None;
			m_currentIllegalityCanHighlightNode = false;
		}
	}

	internal bool D(bool P_0)
	{
		m_previousIllegalityTexts = Enumerable.ToList<string>((System.Collections.Generic.IEnumerable<string>)m_currentIllegalityTexts);
		m_currentIllegalityTexts.Clear();
		m_currentIllegalityCanHighlightNode = false;
		bool result = false;
		bool flag = true;
		if (m_useFixedValue || al())
		{
			m_currentlyIsLegal = true;
			m_currentSeverityLevel = IllegalitySeverityLevel.None;
			m_currentIllegalityCanHighlightNode = false;
			flag = false;
		}
		if (flag && m_multiCellEnableOnConditions.Count == 0 && !m_currentEnableOn && (!(this is Dn) || (this as Dn).ax() == 0))
		{
			if (!m_currentlyIsLegal)
			{
				result = true;
				m_currentlyIsLegal = true;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.None;
			m_currentIllegalityCanHighlightNode = false;
			flag = false;
		}
		bool flag2 = false;
		if (m_isPortFunctionEnabler)
		{
			flag2 = !(this is Do);
			if (ax() != 1)
			{
				if (!m_currentlyIsLegal)
				{
					result = true;
					m_currentlyIsLegal = true;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.None;
				m_currentIllegalityCanHighlightNode = false;
				flag = false;
			}
		}
		if (!flag2 && this is Do && m_parentSettingOrSpecialObject != null && m_listItems.BYm.Count != 0 && m_listItems.BYm[0].Count != 0)
		{
			for (int i = 0; i < m_parentSettingOrSpecialObject.a().Count; i++)
			{
				if (m_parentSettingOrSpecialObject.a()[i] is Setting setting && setting.T() && !(setting is Do) && setting.ax() != 1)
				{
					if (!m_currentlyIsLegal)
					{
						result = true;
						m_currentlyIsLegal = true;
					}
					m_currentSeverityLevel = IllegalitySeverityLevel.None;
					m_currentIllegalityCanHighlightNode = false;
					flag = false;
					break;
				}
			}
		}
		if (flag && m_dimensionsSliceRowCol[0] == 1 && m_dimensionsSliceRowCol[1] == 1 && m_dimensionsSliceRowCol[2] == 1 && !aJ() && PortFunction.a(m_parentSettingOrSpecialObject))
		{
			PortFunction.B b = m_parentSettingOrSpecialObject.F().E();
			int num = PortFunction.A(m_framework, false, b.BSQ, b.BSq, b.BSR, b.BSr);
			if (num == 0 && PortFunction.a(m_framework, b.BSQ, b.BSq, b.BSR, b.BSr) != null)
			{
				num = 1;
			}
			if (num == 0)
			{
				if (!m_currentlyIsLegal)
				{
					result = true;
					m_currentlyIsLegal = true;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.None;
				m_currentIllegalityCanHighlightNode = false;
				flag = false;
			}
		}
		if (m_numBytesPerCell == 1 && m_parentSettingOrSpecialObject is TableAxis && m_parentSettingOrSpecialObject.D() is Table && (!m_parentSettingOrSpecialObject.l() || !m_parentSettingOrSpecialObject.D().l() || ((m_parentSettingOrSpecialObject as TableAxis).F() != null && (m_parentSettingOrSpecialObject as TableAxis).F().ax() == 0) || !(m_parentSettingOrSpecialObject as TableAxis).a()) && (m_internalName == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hj() || m_internalName == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiv()))
		{
			if (!m_currentlyIsLegal)
			{
				result = true;
				m_currentlyIsLegal = true;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.None;
			m_currentIllegalityCanHighlightNode = false;
			flag = false;
		}
		if (m_parentSettingOrSpecialObject is SensorCalibration && !m_parentSettingOrSpecialObject.l())
		{
			if (!m_currentlyIsLegal)
			{
				result = true;
				m_currentlyIsLegal = true;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.None;
			m_currentIllegalityCanHighlightNode = false;
			flag = false;
		}
		if (m_parentSettingOrSpecialObject != null && (m_parentSettingOrSpecialObject is DN || m_parentSettingOrSpecialObject.D() is DN))
		{
			DN dN = ((m_parentSettingOrSpecialObject is DN) ? (m_parentSettingOrSpecialObject as DN) : (m_parentSettingOrSpecialObject.D() as DN));
			bool flag3 = dN.BZK.ax() == 0 || (dN.BZK.A() == 19293 && m_framework.A(10363).ax() == 0) || (dN.BZK.A() == 19323 && m_framework.A(10362).ax() == 0) || (dN.BZK.A() == 19351 && m_framework.A(16033).ax() == 0);
			if (flag3 || m_internalName.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdT()))
			{
				if (!m_currentlyIsLegal)
				{
					result = true;
					m_currentlyIsLegal = true;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.None;
				m_currentIllegalityCanHighlightNode = false;
				flag = false;
			}
		}
		bool flag4 = false;
		if (flag)
		{
			flag4 = this.b(ref flag, ref result);
		}
		bool flag5 = false;
		if (flag)
		{
			flag5 = A(ref flag, ref result);
		}
		bool flag6 = false;
		if (flag)
		{
			flag6 = a(ref flag, ref result);
		}
		bool flag7 = false;
		if (flag)
		{
			flag7 = B(ref flag, ref result);
		}
		bool flag8 = false;
		if (flag)
		{
			flag8 = C(ref flag, ref result);
		}
		bool flag9 = false;
		if (flag)
		{
			flag9 = c(ref flag, ref result);
		}
		bool flag10 = false;
		if (flag && this is Table)
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
					result = true;
					m_currentlyIsLegal = false;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.Warning;
				m_currentIllegalityCanHighlightNode = false;
				flag10 = true;
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
					result = true;
					m_currentlyIsLegal = false;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				flag10 = true;
			}
		}
		bool flag11 = false;
		if (flag)
		{
			flag11 = D(ref flag, ref result);
		}
		bool flag12 = false;
		if (flag)
		{
			flag12 = A(ref result);
		}
		bool flag13 = false;
		if (!flag5 && !flag6 && !flag7 && !flag10 && !flag8 && !flag11 && !flag4 && !flag12 && !flag9)
		{
			if (flag && this is Dn)
			{
				(this as Dn).A(ref result);
				if (!m_currentlyIsLegal && m_parentSettingOrSpecialObject != null)
				{
					for (int l = 0; l < m_parentSettingOrSpecialObject.a().Count; l++)
					{
						if (m_parentSettingOrSpecialObject.a()[l] is Setting setting2 && setting2.T())
						{
							Setting setting3 = setting2;
							if (setting3.m_currentlyIsLegal)
							{
								result = true;
								setting3.m_conditionsChangedOnLastEvaluation = true;
								setting3.m_currentlyIsLegal = false;
							}
							if (!setting3.m_currentIllegalityTexts.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdt()))
							{
								setting3.m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdt());
							}
							setting3.m_currentSeverityLevel = IllegalitySeverityLevel.Error;
							setting3.m_currentIllegalityCanHighlightNode = true;
							break;
						}
					}
				}
				flag13 = true;
			}
			if (!flag13)
			{
				A(P_0, flag, ref result);
			}
		}
		if (!m_currentlyIsLegal && !flag13 && m_currentSeverityLevel == IllegalitySeverityLevel.Error)
		{
			SpecialObject specialObject = null;
			SettingOrSpecialObject settingOrSpecialObject = this;
			bool flag14 = false;
			do
			{
				if (settingOrSpecialObject.D() != null)
				{
					settingOrSpecialObject = settingOrSpecialObject.D();
					if (settingOrSpecialObject is SpecialObject && settingOrSpecialObject.F().Bbb != -1)
					{
						specialObject = settingOrSpecialObject as SpecialObject;
						break;
					}
				}
				else
				{
					flag14 = true;
				}
			}
			while (!flag14);
			if (specialObject != null)
			{
				for (int m = 0; m < ((SettingOrSpecialObject)specialObject).a().Count; m++)
				{
					if (((SettingOrSpecialObject)specialObject).a()[m] is Setting setting4 && setting4.T())
					{
						Setting setting5 = setting4;
						if (setting5.m_currentlyIsLegal)
						{
							result = true;
							setting5.m_conditionsChangedOnLastEvaluation = true;
							setting5.m_currentlyIsLegal = false;
						}
						if (!setting5.m_currentIllegalityTexts.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdU()))
						{
							setting5.m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdU());
						}
						setting5.m_currentSeverityLevel = IllegalitySeverityLevel.Error;
						setting5.m_currentIllegalityCanHighlightNode = true;
						break;
					}
				}
			}
		}
		return result;
	}

	internal bool A(ref bool P_0, ref bool P_1)
	{
		if (aJ() || m_isEnabler)
		{
			return false;
		}
		bool num = m_multiCellEnableOnConditions.Count != 0;
		int num2 = aR();
		int num3 = ar();
		int num4 = aS();
		if (num)
		{
			bool flag = true;
			for (int i = 0; i < m_dimensionsSliceRowCol[2]; i++)
			{
				if (q()[0, 0, i])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				if (!m_currentlyIsLegal)
				{
					P_1 = true;
					m_currentlyIsLegal = true;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.None;
				m_currentIllegalityCanHighlightNode = false;
				P_0 = false;
				return false;
			}
			if (num2 != 0 || num3 != 0)
			{
				for (int j = 0; j < m_dimensionsSliceRowCol[2]; j++)
				{
					if (!q()[0, 0, j])
					{
						continue;
					}
					int num5 = B(j, 0, 0);
					if ((num5 < num2 || num5 > num3) && a(num5, j) == null)
					{
						string text = bS.a(num2, num4, -1);
						string text2 = bS.a(num3, num4, -1);
						if (m_currentlyIsLegal)
						{
							P_1 = true;
							m_currentlyIsLegal = false;
						}
						m_currentSeverityLevel = IllegalitySeverityLevel.Error;
						m_currentIllegalityCanHighlightNode = true;
						m_currentIllegalityTexts.Add(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdu(), (object)text, (object)text2));
						P_0 = false;
						return true;
					}
				}
			}
			else
			{
				for (int k = 0; k < m_dimensionsSliceRowCol[2]; k++)
				{
					if (!q()[0, 0, k] || d(k).Count == 0)
					{
						continue;
					}
					int num6 = B(k, 0, 0);
					if (a(num6, k) == null)
					{
						if (m_currentlyIsLegal)
						{
							P_1 = true;
							m_currentlyIsLegal = false;
						}
						m_currentSeverityLevel = IllegalitySeverityLevel.Error;
						m_currentIllegalityCanHighlightNode = true;
						m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdV());
						P_0 = false;
						return true;
					}
				}
			}
			return false;
		}
		Setting setting = this;
		int num7 = num2;
		int num8 = num3;
		if (m_dataIdOfSettingContainingChannelIdForMinMaxAndUnits != 0)
		{
			setting = null;
			Setting setting2 = m_framework.A(m_dataIdOfSettingContainingChannelIdForMinMaxAndUnits);
			if (setting2 != null)
			{
				setting = m_framework.A(setting2.ax());
				if (setting != null)
				{
					setting.A(ref num2, ref num3, ref num7, ref num8);
					num4 = setting.aS();
				}
			}
		}
		if (setting == null)
		{
			return false;
		}
		bool result = false;
		int num9 = ax();
		if (m_dimensionsSliceRowCol[0] == 1 && m_dimensionsSliceRowCol[1] == 1 && m_dimensionsSliceRowCol[2] == 1)
		{
			if ((num7 != 0 || num8 != 0) && (num9 < num7 || num9 > num8))
			{
				if (setting.a(num9, 0) == null)
				{
					if (m_currentlyIsLegal)
					{
						P_1 = true;
						m_currentlyIsLegal = false;
					}
					m_currentSeverityLevel = IllegalitySeverityLevel.Error;
					m_currentIllegalityCanHighlightNode = true;
					int num10 = K();
					string text3 = bS.a(num9, num4, num10);
					string text4 = bS.a(num7, num4, num10);
					string text5 = bS.a(num8, num4, num10);
					if (setting is SensorCalibration && num7 > num2 && num8 < num3)
					{
						List<string> currentIllegalityTexts = m_currentIllegalityTexts;
						string text6 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdv();
						cd<object> buffer = default(cd<object>);
						cc.a<cd<object>, object>(ref buffer, 0) = text3;
						cc.a<cd<object>, object>(ref buffer, 1) = ((SettingOrSpecialObject)setting).A(true);
						cc.a<cd<object>, object>(ref buffer, 2) = text4;
						cc.a<cd<object>, object>(ref buffer, 3) = text5;
						currentIllegalityTexts.Add(string.Format(text6, cc.A<cd<object>, object>(in buffer, 4)));
					}
					else
					{
						m_currentIllegalityTexts.Add(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ke(), (object)text3, (object)text4, (object)text5));
					}
					P_0 = false;
					result = true;
				}
			}
			else if (m_dataIdOfSettingContainingChannelIdForMinMaxAndUnits == 0 && d(0).Count != 0 && a(num9, 0) == null)
			{
				if (m_currentlyIsLegal)
				{
					P_1 = true;
					m_currentlyIsLegal = false;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				m_currentIllegalityCanHighlightNode = true;
				m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdV());
				P_0 = false;
				result = true;
			}
		}
		return result;
	}

	internal bool a(ref bool P_0, ref bool P_1)
	{
		if (!m_isAttribute || !(m_parentSettingOrSpecialObject is Setting))
		{
			return false;
		}
		bool flag = false;
		if (m_attributeId == 8)
		{
			Setting setting = m_framework.A(new DataIdAndAttrId(m_dataId, 6));
			if (setting != null)
			{
				int num = ax();
				int num2 = setting.ax();
				if (num < num2)
				{
					m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdW());
					P_0 = false;
					flag = true;
				}
			}
		}
		else if (m_attributeId == 9)
		{
			Setting setting2 = m_framework.A(new DataIdAndAttrId(m_dataId, 7));
			if (setting2 != null)
			{
				int num3 = ax();
				int num4 = setting2.ax();
				if (num3 > num4)
				{
					m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdw());
					P_0 = false;
					flag = true;
				}
			}
		}
		if (flag)
		{
			if (m_currentlyIsLegal)
			{
				P_1 = true;
				m_currentlyIsLegal = false;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.Warning;
			m_currentIllegalityCanHighlightNode = true;
		}
		return flag;
	}

	internal bool B(ref bool P_0, ref bool P_1)
	{
		if (!m_isAttribute || !(m_parentSettingOrSpecialObject is Setting))
		{
			return false;
		}
		bool flag = false;
		if (m_attributeId == 7)
		{
			Setting setting = m_framework.A(new DataIdAndAttrId(m_dataId, 6));
			if (setting != null)
			{
				int num = ax();
				int num2 = setting.ax();
				if (num < num2)
				{
					m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdX());
					P_0 = false;
					flag = true;
				}
			}
		}
		else if (m_attributeId == 6)
		{
			Setting setting2 = m_framework.A(new DataIdAndAttrId(m_dataId, 7));
			if (setting2 != null)
			{
				int num3 = ax();
				int num4 = setting2.ax();
				if (num3 > num4)
				{
					m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdx());
					P_0 = false;
					flag = true;
				}
			}
		}
		if (flag)
		{
			if (m_currentlyIsLegal)
			{
				P_1 = true;
				m_currentlyIsLegal = false;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.Error;
			m_currentIllegalityCanHighlightNode = true;
		}
		return flag;
	}

	private bool b(ref bool P_0, ref bool P_1)
	{
		bool result = false;
		if (m_isChannelSelector || m_isConditionalActivatorChannelSelector)
		{
			Setting setting = m_framework.A(ax());
			if (setting == null || !((SettingOrSpecialObject)setting).l() || !PortFunction.A(setting))
			{
				result = true;
				if (m_currentlyIsLegal)
				{
					P_1 = true;
					m_currentlyIsLegal = false;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				m_currentIllegalityCanHighlightNode = true;
				if (setting == null)
				{
					m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdY());
				}
				else
				{
					m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdy());
				}
				P_0 = false;
			}
			else
			{
				if (!m_currentlyIsLegal)
				{
					P_1 = true;
					m_currentlyIsLegal = true;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.None;
				m_currentIllegalityCanHighlightNode = false;
			}
		}
		return result;
	}

	private bool C(ref bool P_0, ref bool P_1)
	{
		bool result = false;
		if (m_parentSettingOrSpecialObject is SensorCalibration && this == (m_parentSettingOrSpecialObject as SensorCalibration).CalibrationValueCountSetting && ax() < 2)
		{
			result = true;
			if (m_currentlyIsLegal)
			{
				P_1 = true;
				m_currentlyIsLegal = false;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.Error;
			m_currentIllegalityCanHighlightNode = true;
			m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdZ());
			P_0 = false;
		}
		return result;
	}

	private bool c(ref bool P_0, ref bool P_1)
	{
		bool result = false;
		if (aJ() && PortFunction.a(m_parentSettingOrSpecialObject))
		{
			int num = ax();
			if (m_framework.awg.ContainsKey(num))
			{
				result = true;
				if (m_currentlyIsLegal)
				{
					P_1 = true;
					m_currentlyIsLegal = false;
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				m_currentIllegalityCanHighlightNode = true;
				m_currentIllegalityTexts.Add(m_framework.awg[num]);
				P_0 = false;
			}
		}
		return result;
	}

	private void A(DN P_0, ref bool P_1, ref bool P_2)
	{
		if (this != P_0.BZk && this != P_0.BZL)
		{
			return;
		}
		HashSet<string> val = new HashSet<string>();
		int num = P_0.BZl.av()[2];
		for (int i = 0; i < num; i++)
		{
			int num2 = P_0.BZl.m(i);
			if (!CANFrameModel.IsFrameVisible((byte)num2) || !CANFrameModel.IsFrameEnabled((byte)num2))
			{
				continue;
			}
			if (this == P_0.BZk)
			{
				string text = N(i);
				if (string.IsNullOrWhiteSpace(text))
				{
					P_1 = true;
					string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdz();
					if (!m_currentIllegalityTexts.Contains(text2))
					{
						m_currentIllegalityTexts.Add(text2);
					}
				}
				else if (val.Contains(text))
				{
					P_1 = true;
					string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEA();
					if (!m_currentIllegalityTexts.Contains(text3))
					{
						m_currentIllegalityTexts.Add(text3);
					}
				}
				else
				{
					val.Add(text);
				}
			}
			else
			{
				if (this != P_0.BZL)
				{
					continue;
				}
				int num3 = m(i);
				bool flag = CANFrameModel.IsFrameStdId((uint)num3);
				uint num4 = (uint)num3 & 0x7FFFFFFFu;
				if (flag ? (num4 > 2047) : (num4 > 536870911))
				{
					P_1 = true;
					string text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEa();
					if (!m_currentIllegalityTexts.Contains(text4))
					{
						m_currentIllegalityTexts.Add(text4);
					}
				}
				else if (flag && P_0.BZI.Contains((ushort)num4))
				{
					P_1 = true;
					string text5 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEB() + num4.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dh()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEb();
					if (!m_currentIllegalityTexts.Contains(text5))
					{
						m_currentIllegalityTexts.Add(text5);
					}
				}
				else if (!flag && P_0.BZJ.Contains(num4))
				{
					P_1 = true;
					string text6 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEB() + num4.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dH()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEb();
					if (!m_currentIllegalityTexts.Contains(text6))
					{
						m_currentIllegalityTexts.Add(text6);
					}
				}
			}
		}
	}

	private void a(DN P_0, ref bool P_1, ref bool P_2)
	{
		if (this != P_0.BZm && this != P_0.BZq && this != P_0.BZo && this != P_0.BZP && this != P_0.BZn && this != P_0.BZr)
		{
			return;
		}
		HashSet<string> val = new HashSet<string>();
		Dictionary<int, CANFrameModel> val2 = new Dictionary<int, CANFrameModel>();
		int num = P_0.BZN.av()[2];
		for (int i = 0; i < num; i++)
		{
			int num2 = P_0.BZN.m(i);
			if (num2 == -1)
			{
				continue;
			}
			int num3 = num2;
			int num4 = P_0.BZl.m(num3);
			if (!CANFrameModel.IsFrameVisible((byte)num4) || !CANFrameModel.IsFrameEnabled((byte)num4))
			{
				continue;
			}
			if (this == P_0.BZm)
			{
				string text = N(i);
				if (string.IsNullOrWhiteSpace(text))
				{
					P_1 = true;
					string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEC();
					if (!m_currentIllegalityTexts.Contains(text2))
					{
						m_currentIllegalityTexts.Add(text2);
					}
				}
				else if (val.Contains(text))
				{
					P_1 = true;
					string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEc();
					if (!m_currentIllegalityTexts.Contains(text3))
					{
						m_currentIllegalityTexts.Add(text3);
					}
				}
				else
				{
					val.Add(text);
				}
			}
			else if (this == P_0.BZn)
			{
				if (m(i) == 1)
				{
					P_1 = true;
					string text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BED();
					if (!m_currentIllegalityTexts.Contains(text4))
					{
						m_currentIllegalityTexts.Add(text4);
					}
				}
			}
			else if (this == P_0.BZr)
			{
				int num5 = m(i);
				if (num5 == -1 || num5 == 65535)
				{
					P_1 = true;
					string text5 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEd();
					if (!m_currentIllegalityTexts.Contains(text5))
					{
						m_currentIllegalityTexts.Add(text5);
					}
				}
			}
			else if (this == P_0.BZq)
			{
				if (m(i) == 0)
				{
					P_2 = true;
					string text6 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEE();
					if (!m_currentIllegalityTexts.Contains(text6))
					{
						m_currentIllegalityTexts.Add(text6);
					}
				}
			}
			else if (this == P_0.BZo || this == P_0.BZP)
			{
				if (!val2.ContainsKey(num3))
				{
					CANFrameModel cANFrameModel = CANFrameModel.A(P_0, (uint)num3);
					cANFrameModel.Signals = new List<CANSignalModel>();
					val2.Add(num3, cANFrameModel);
				}
				CANSignalModel cANSignalModel = CANSignalModel.A(P_0, m_framework, null, num3, i);
				val2[num3].Signals.Add(cANSignalModel);
			}
		}
		if (this == P_0.BZo || this == P_0.BZP)
		{
			A(P_0, val2, ref P_1);
		}
	}

	private void A(DN P_0, Dictionary<int, CANFrameModel> P_1, ref bool P_2)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		bool flag2 = false;
		Enumerator<int, CANFrameModel> enumerator = P_1.Values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CANFrameModel current = enumerator.Current;
				Enumerator<CANSignalModel> enumerator2 = current.Signals.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						CANSignalModel current2 = enumerator2.Current;
						int num = -1;
						uint num2 = 0u;
						uint num3 = 8 * current.Length;
						if (current2.Format == 1)
						{
							num2 = current2.StartBit + current2.BitLength - 1;
							for (uint num4 = current2.StartBit; num4 < current2.StartBit + current2.BitLength; num4++)
							{
								if (current.a(num4))
								{
									num = (int)num4;
									break;
								}
								if (num4 < num3)
								{
									current.A(num4);
								}
							}
						}
						else if (current2.Format == 0)
						{
							num2 = current2.StartBit;
							for (int i = 0; i < current2.BitLength; i++)
							{
								if (current.a(num2) && num == -1)
								{
									num = (int)num2;
								}
								else
								{
									current.A(num2);
								}
								if (i != current2.BitLength - 1)
								{
									num2 = ((num2 % 8 != 0) ? (num2 - 1) : (num2 + 15));
								}
							}
						}
						if (num2 >= num3)
						{
							flag2 = true;
							P_2 = true;
							string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEe();
							if (!m_currentIllegalityTexts.Contains(text))
							{
								m_currentIllegalityTexts.Add(text);
							}
						}
						if (num != -1)
						{
							flag = true;
							P_2 = true;
							string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEF();
							if (!m_currentIllegalityTexts.Contains(text2))
							{
								m_currentIllegalityTexts.Add(text2);
							}
						}
						if (flag && flag2)
						{
							return;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private bool D(ref bool P_0, ref bool P_1)
	{
		bool result = false;
		if (m_parentSettingOrSpecialObject != null && (m_parentSettingOrSpecialObject is DN || m_parentSettingOrSpecialObject.D() is DN))
		{
			DN dN = ((m_parentSettingOrSpecialObject is DN) ? (m_parentSettingOrSpecialObject as DN) : (m_parentSettingOrSpecialObject.D() as DN));
			bool flag = false;
			bool flag2 = false;
			A(dN, ref flag, ref flag2);
			a(dN, ref flag, ref flag2);
			if (flag || flag2)
			{
				result = true;
				if (m_currentlyIsLegal)
				{
					P_1 = true;
					m_currentlyIsLegal = false;
				}
				else if (!P_1)
				{
					if (m_currentIllegalityTexts.Count != m_previousIllegalityTexts.Count)
					{
						P_1 = true;
					}
					else
					{
						for (int i = 0; i < m_currentIllegalityTexts.Count; i++)
						{
							if (m_currentIllegalityTexts[i] != m_previousIllegalityTexts[i])
							{
								P_1 = true;
								break;
							}
						}
					}
				}
				m_currentSeverityLevel = ((!flag) ? IllegalitySeverityLevel.Warning : IllegalitySeverityLevel.Error);
				m_currentIllegalityCanHighlightNode = flag;
				P_0 = false;
			}
		}
		return result;
	}

	internal bool A(ref bool P_0)
	{
		if (m_dataId != 1501)
		{
			return false;
		}
		bool flag = false;
		string text = ay();
		if (text.Length < 2 || text[0] == ' ' || text[0] == '\0')
		{
			flag = true;
			m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEf());
		}
		else if (global::A.m.A(text) || text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax()))
		{
			flag = true;
			m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBV());
		}
		if (flag)
		{
			if (m_currentlyIsLegal)
			{
				P_0 = true;
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
	internal new string s()
	{
		return m_metaDataString;
	}

	[SpecialName]
	internal new void c(string P_0)
	{
		m_metaDataString = P_0;
	}

	[SpecialName]
	internal bool T()
	{
		return m_isPortFunctionEnabler;
	}

	[SpecialName]
	internal void d(bool P_0)
	{
		m_isPortFunctionEnabler = P_0;
	}

	[SpecialName]
	internal MenuNode t()
	{
		return m_isFunctionEnablerForMenuNode;
	}

	[SpecialName]
	internal new void A(MenuNode P_0)
	{
		m_isFunctionEnablerForMenuNode = P_0;
	}

	[SpecialName]
	internal bool U()
	{
		return m_isEnabler;
	}

	[SpecialName]
	internal void E(bool P_0)
	{
		m_isEnabler = P_0;
	}

	[SpecialName]
	internal byte u()
	{
		return m_enablesExternalDevice;
	}

	[SpecialName]
	internal new void A(byte P_0)
	{
		m_enablesExternalDevice = P_0;
	}

	[SpecialName]
	internal List<byte> V()
	{
		if (m_deviceIdCanBeChangedTo == null)
		{
			m_deviceIdCanBeChangedTo = new List<byte>();
		}
		return m_deviceIdCanBeChangedTo;
	}

	[SpecialName]
	internal bool v()
	{
		return m_isChannelSelector;
	}

	[SpecialName]
	internal void e(bool P_0)
	{
		m_isChannelSelector = P_0;
	}

	[SpecialName]
	internal int W()
	{
		return m_channelSelectorApplyChannelNameToSettingId;
	}

	[SpecialName]
	internal void F(int P_0)
	{
		m_channelSelectorApplyChannelNameToSettingId = P_0;
	}

	[SpecialName]
	internal DataIdAndAttrId w()
	{
		return m_idOfSettingContainingDisplayUnits;
	}

	[SpecialName]
	internal void A(DataIdAndAttrId P_0)
	{
		m_idOfSettingContainingDisplayUnits = P_0;
	}

	[SpecialName]
	internal bool X()
	{
		return m_isConditionalActivatorChannelSelector;
	}

	[SpecialName]
	internal void F(bool P_0)
	{
		m_isConditionalActivatorChannelSelector = P_0;
	}

	[SpecialName]
	internal int x()
	{
		return m_fixedAxisType;
	}

	[SpecialName]
	internal void f(int P_0)
	{
		m_fixedAxisType = P_0;
	}

	[SpecialName]
	internal bool Y()
	{
		return m_isColourPicker;
	}

	[SpecialName]
	internal void f(bool P_0)
	{
		m_isColourPicker = P_0;
	}

	internal bool y()
	{
		if (m_isResourcePickerForTheseFileExtensions != null && m_isResourcePickerForTheseFileExtensions.Count != 0)
		{
			return Di.B(Brh) != null;
		}
		return false;
	}

	[SpecialName]
	internal List<string> Z()
	{
		return m_isResourcePickerForTheseFileExtensions;
	}

	[SpecialName]
	internal void A(List<string> P_0)
	{
		m_isResourcePickerForTheseFileExtensions = P_0;
	}

	[SpecialName]
	internal global::A.A.C z()
	{
		return Brh;
	}

	[SpecialName]
	internal void A(global::A.A.C P_0)
	{
		Brh = P_0;
	}

	[SpecialName]
	internal bool aA()
	{
		return m_isResourcePickerForSplashScreen;
	}

	[SpecialName]
	internal void G(bool P_0)
	{
		m_isResourcePickerForSplashScreen = P_0;
	}

	[SpecialName]
	internal Size aa()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return m_isResourcePickerForFixedResolution;
	}

	[SpecialName]
	internal void A(Size P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		m_isResourcePickerForFixedResolution = P_0;
	}

	[SpecialName]
	internal int aB()
	{
		return m_isResourcePickerForFixedBitDepth;
	}

	[SpecialName]
	internal void G(int P_0)
	{
		m_isResourcePickerForFixedBitDepth = P_0;
	}

	[SpecialName]
	internal int ab()
	{
		return m_dataIdOfResourceCRCSetting;
	}

	[SpecialName]
	internal void g(int P_0)
	{
		m_dataIdOfResourceCRCSetting = P_0;
	}

	[SpecialName]
	internal bool aC()
	{
		return m_userSearchable;
	}

	[SpecialName]
	internal void g(bool P_0)
	{
		m_userSearchable = P_0;
	}

	[SpecialName]
	internal List<B> ac()
	{
		return BrH;
	}

	[SpecialName]
	internal int aD()
	{
		return m_attrIdToOverride;
	}

	[SpecialName]
	internal void H(int P_0)
	{
		m_attrIdToOverride = P_0;
	}

	[SpecialName]
	internal int ad()
	{
		return m_dataIdOfAttrOverrideEnabler;
	}

	[SpecialName]
	internal void h(int P_0)
	{
		m_dataIdOfAttrOverrideEnabler = P_0;
	}

	[SpecialName]
	internal int aE()
	{
		return m_attrOverrideChanSelectorSettingId;
	}

	[SpecialName]
	internal void I(int P_0)
	{
		m_attrOverrideChanSelectorSettingId = P_0;
	}

	[SpecialName]
	internal int ae()
	{
		return m_attrOverrideChanId;
	}

	[SpecialName]
	internal void i(int P_0)
	{
		m_attrOverrideChanId = P_0;
	}

	[SpecialName]
	internal string aF()
	{
		return m_helpPath;
	}

	[SpecialName]
	internal new void D(string P_0)
	{
		m_helpPath = P_0;
	}

	internal void a(int P_0, string P_1)
	{
		m_valueSupplier.BYl = P_0;
		m_valueSupplier.BYM = P_1;
	}

	internal ValueSupplier af()
	{
		return m_valueSupplier;
	}

	[SpecialName]
	internal int aG()
	{
		return m_numBytesPerCell;
	}

	[SpecialName]
	internal void J(int P_0)
	{
		m_numBytesPerCell = P_0;
	}

	[SpecialName]
	internal bool ag()
	{
		return m_valuesAreSigned;
	}

	[SpecialName]
	internal void H(bool P_0)
	{
		m_valuesAreSigned = P_0;
	}

	internal bool aH()
	{
		return (a(bZ.aYL) & 1) != 0;
	}

	internal bool ah()
	{
		return (a(bZ.aYL) & 2) != 0;
	}

	internal bool aI()
	{
		return (a(bZ.aYL) & 4) != 0;
	}

	internal bool ai()
	{
		return (a(bZ.aYL) & 8) != 0;
	}

	internal bool aJ()
	{
		return (a(bZ.aYL) & 0x10) != 0;
	}

	internal bool aj()
	{
		return (a(bZ.aYL) & 0x20) != 0;
	}

	internal bool aK()
	{
		return (a(bZ.aYL) & 0x40) != 0;
	}

	internal bool ak()
	{
		return (a(bZ.aYL) & 0x80) != 0;
	}

	internal bool aL()
	{
		return a(bZ.aYL) == 27;
	}

	[SpecialName]
	internal bool al()
	{
		return a(bZ.aYQ) != 0;
	}

	internal void A(bZ P_0, int P_1, bool P_2, string P_3, int P_4)
	{
		m_intProperties[(int)P_0].A(P_1, P_2, P_3, P_4);
	}

	internal bool A(bZ P_0)
	{
		return m_intProperties[(int)P_0].BYt;
	}

	internal int a(bZ P_0)
	{
		return m_intProperties[(int)P_0].A(m_framework);
	}

	internal int B(bZ P_0)
	{
		if (m_intProperties[(int)P_0].BYv)
		{
			int bYU = m_intProperties[(int)P_0].BYU;
			if (m_intProperties[(int)P_0].BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJn())
			{
				return m_framework.A(bYU).B(bZ.aYl);
			}
			if (m_intProperties[(int)P_0].BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJO())
			{
				return m_framework.A(bYU).B(bZ.aYM);
			}
			if (m_intProperties[(int)P_0].BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ais())
			{
				return m_framework.A(bYU).B(bZ.aYm);
			}
			if (m_intProperties[(int)P_0].BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aiT())
			{
				return m_framework.A(bYU).B(bZ.aYN);
			}
			if (m_intProperties[(int)P_0].BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJo())
			{
				return m_framework.A(bYU).B(bZ.aYn);
			}
			if (m_intProperties[(int)P_0].BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ain())
			{
				return m_framework.A(bYU).B(bZ.aYO);
			}
			if (m_intProperties[(int)P_0].BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aio())
			{
				return m_framework.A(bYU).B(bZ.aYP);
			}
			if (m_intProperties[(int)P_0].BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJh())
			{
				return m_framework.A(bYU).B(bZ.aYp);
			}
			if (m_intProperties[(int)P_0].BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJC())
			{
				return m_framework.A(bYU).B(bZ.aYR);
			}
			if (m_intProperties[(int)P_0].BYX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJc())
			{
				return m_framework.A(bYU).B(bZ.aYr);
			}
			return bYU;
		}
		return -1;
	}

	[SpecialName]
	internal List<int> aM()
	{
		return m_fixedValue;
	}

	[SpecialName]
	internal void A(List<int> P_0)
	{
		m_fixedValue = P_0;
		m_useFixedValue = true;
	}

	[SpecialName]
	internal bool am()
	{
		return m_useFixedValue;
	}

	[SpecialName]
	internal bool aN()
	{
		return a(bZ.aYq) != 0;
	}

	[SpecialName]
	internal int an()
	{
		return a(bZ.aYp);
	}

	[SpecialName]
	internal int aO()
	{
		return a(bZ.aYR);
	}

	[SpecialName]
	internal int ao()
	{
		return a(bZ.aYr);
	}

	internal int aP()
	{
		if (A(bZ.aYn))
		{
			return a(bZ.aYn);
		}
		if (m_isAttribute && m_parentSettingOrSpecialObject is Setting)
		{
			return (m_parentSettingOrSpecialObject as Setting).aP();
		}
		return aR();
	}

	internal int ap()
	{
		if (A(bZ.aYO))
		{
			return a(bZ.aYO);
		}
		if (m_isAttribute && m_parentSettingOrSpecialObject is Setting)
		{
			return (m_parentSettingOrSpecialObject as Setting).ap();
		}
		return ar();
	}

	internal int aQ()
	{
		if (aJ())
		{
			int num = a(bZ.aYm);
			int num2 = a(bZ.aYN);
			if (num == 0 && num2 == 0)
			{
				num = a(bZ.aYl);
			}
			return num;
		}
		throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEG());
	}

	internal int aq()
	{
		if (aJ())
		{
			int num = a(bZ.aYm);
			int num2 = a(bZ.aYN);
			if (num == 0 && num2 == 0)
			{
				num2 = a(bZ.aYM);
			}
			return num2;
		}
		throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEg());
	}

	internal int aR()
	{
		int num = a(bZ.aYl);
		int num2 = a(bZ.aYM);
		if (num == 0 && num2 == 0)
		{
			if (m_isAttribute && m_parentSettingOrSpecialObject is Setting)
			{
				return (m_parentSettingOrSpecialObject as Setting).aR();
			}
			if (m_intProperties[3].BYv)
			{
				int bYU = m_intProperties[3].BYU;
				num = m_framework.A(bYU)?.aR() ?? a(bZ.aYm);
			}
			else
			{
				num = a(bZ.aYm);
			}
		}
		return num;
	}

	internal int ar()
	{
		int num = a(bZ.aYl);
		int num2 = a(bZ.aYM);
		if (num == 0 && num2 == 0)
		{
			if (m_isAttribute && m_parentSettingOrSpecialObject is Setting)
			{
				return (m_parentSettingOrSpecialObject as Setting).ar();
			}
			if (m_intProperties[4].BYv)
			{
				int bYU = m_intProperties[4].BYU;
				num2 = m_framework.A(bYU)?.ar() ?? a(bZ.aYN);
			}
			else
			{
				num2 = a(bZ.aYN);
			}
		}
		return num2;
	}

	internal void A(ref int P_0, ref int P_1, ref int P_2, ref int P_3)
	{
		P_0 = aR();
		P_1 = ar();
		if (this is SensorCalibration)
		{
			SensorCalibration sensorCalibration = this as SensorCalibration;
			if (sensorCalibration.CalibrationValuesSetting != null && sensorCalibration.CalibrationVoltagesSetting != null && ((SettingOrSpecialObject)sensorCalibration.CalibrationValuesSetting).l() && ((SettingOrSpecialObject)sensorCalibration.CalibrationVoltagesSetting).l())
			{
				P_2 = sensorCalibration.GetMinCalibrationValue();
				P_3 = sensorCalibration.GetMaxCalibrationValue();
				if (P_2 < P_0)
				{
					P_2 = P_0;
				}
				if (P_3 > P_1)
				{
					P_3 = P_1;
				}
			}
			else
			{
				P_2 = P_0;
				P_3 = P_1;
			}
		}
		else
		{
			P_2 = P_0;
			P_3 = P_1;
		}
	}

	[SpecialName]
	internal int aS()
	{
		if (m_isAttribute && m_parentSettingOrSpecialObject is Setting && !A(bZ.aYP))
		{
			return (m_parentSettingOrSpecialObject as Setting).aS();
		}
		return a(bZ.aYP);
	}

	[SpecialName]
	internal int @as()
	{
		if (m_isAttribute && m_parentSettingOrSpecialObject is Setting && !A(bZ.aYP))
		{
			return (m_parentSettingOrSpecialObject as Setting).@as();
		}
		return m_unitsOrder;
	}

	[SpecialName]
	internal void j(int P_0)
	{
		m_unitsOrder = P_0;
	}

	internal void aT()
	{
		if (A(bZ.aYS))
		{
			a(a(bZ.aYS), true);
			BM.b(m_dataId);
		}
	}

	internal int at()
	{
		return a(bZ.aYS);
	}

	[SpecialName]
	internal int aU()
	{
		return m_terminatingValue;
	}

	[SpecialName]
	internal void K(int P_0)
	{
		m_terminatingValue = P_0;
	}

	[SpecialName]
	internal bool au()
	{
		return m_listOrder;
	}

	[SpecialName]
	internal void h(bool P_0)
	{
		m_listOrder = P_0;
	}

	[SpecialName]
	internal int aV()
	{
		return m_visibleDimensions;
	}

	[SpecialName]
	internal void k(int P_0)
	{
		m_visibleDimensions = P_0;
	}

	[SpecialName]
	internal int[] av()
	{
		return m_dimensionsSliceRowCol;
	}

	[SpecialName]
	internal void A(int[] P_0)
	{
		m_dimensionsSliceRowCol = P_0;
	}

	[SpecialName]
	internal byte[] aW()
	{
		return m_defaultDataBytes;
	}

	[SpecialName]
	internal void A(byte[] P_0)
	{
		m_defaultDataBytes = P_0;
	}

	internal bool I(bool P_0)
	{
		bool result = false;
		if (m_defaultDataBytes != null)
		{
			result = A(m_defaultDataBytes, P_0);
		}
		else if (aI())
		{
			result = J(P_0);
		}
		return result;
	}

	internal bool A(int P_0, bool P_1)
	{
		bool flag = false;
		if (m_defaultDataBytes != null && m_defaultDataBytes.Length >= BB())
		{
			for (int i = 0; i < m_numBytesPerCell; i++)
			{
				int num = m_numBytesPerCell * P_0 + i;
				flag = A(num, m_defaultDataBytes[num], P_1) || flag;
			}
		}
		else if (aI())
		{
			flag = a(P_0, 0, P_1);
		}
		return flag;
	}

	internal int L(int P_0)
	{
		if (m_defaultDataBytes != null && m_defaultDataBytes.Length >= BB())
		{
			return global::A.N.A(m_defaultDataBytes, m_numBytesPerCell * P_0, m_numBytesPerCell, m_valuesAreSigned, m_framework.aWR);
		}
		return 0;
	}

	internal string aw()
	{
		if (m_encoding != 0 && m_defaultDataBytes != null && m_defaultDataBytes.Length >= BB())
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

	internal int A(int P_0, int P_1, int P_2)
	{
		return m_dimensionsSliceRowCol[2] * m_dimensionsSliceRowCol[1] * P_2 + m_dimensionsSliceRowCol[2] * P_1 + P_0;
	}

	internal int a(int P_0, int P_1, int P_2)
	{
		return m_numBytesPerCell * A(P_0, P_1, P_2);
	}

	internal ValueTuple<string, string, bool> aX()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return A(ax(), -1);
	}

	internal ValueTuple<string, string, bool> A(int P_0, int P_1 = -1)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (m_encoding != 0)
		{
			return new ValueTuple<string, string, bool>(ay(), string.Empty, false);
		}
		string text = string.Empty;
		string text2 = a(P_0, 0);
		if (text2 == null)
		{
			text2 = B(P_0, 0);
		}
		bool flag;
		if (text2 != null)
		{
			flag = true;
		}
		else
		{
			flag = false;
			text2 = bS.a(P_0, aS(), P_1);
			text = bS.A(@as(), aS(), true, P_0, P_1);
		}
		return new ValueTuple<string, string, bool>(text2, text, flag);
	}

	internal byte l(int P_0)
	{
		byte result = 0;
		if (!m_useFixedValue)
		{
			if (m_byteAddress == -1)
			{
				return 0;
			}
			result = ((!aJ()) ? m_framework.I()[m_byteAddress + P_0] : m_framework.J()[m_byteAddress + P_0]);
		}
		else if (m_numBytesPerCell == 1)
		{
			result = ((P_0 >= m_fixedValue.Count) ? ((byte)m_fixedValue[0]) : ((byte)m_fixedValue[P_0]));
		}
		else if (m_numBytesPerCell == 2)
		{
			uint num = (uint)((P_0 / 2 >= m_fixedValue.Count) ? m_fixedValue[0] : m_fixedValue[P_0 / 2]);
			int num2 = P_0 % 2;
			if (m_framework.aWR)
			{
				switch (num2)
				{
				case 0:
					result = (byte)((num >> 8) & 0xFFu);
					break;
				case 1:
					result = (byte)(num & 0xFFu);
					break;
				}
			}
			else
			{
				switch (num2)
				{
				case 1:
					result = (byte)((num >> 8) & 0xFFu);
					break;
				case 0:
					result = (byte)(num & 0xFFu);
					break;
				}
			}
		}
		else if (m_numBytesPerCell == 4)
		{
			uint num3 = (uint)((P_0 / 4 >= m_fixedValue.Count) ? m_fixedValue[0] : m_fixedValue[P_0 / 4]);
			int num4 = P_0 % 4;
			if (m_framework.aWR)
			{
				switch (num4)
				{
				case 0:
					result = (byte)((num3 >> 24) & 0xFFu);
					break;
				case 1:
					result = (byte)((num3 >> 16) & 0xFFu);
					break;
				case 2:
					result = (byte)((num3 >> 8) & 0xFFu);
					break;
				case 3:
					result = (byte)(num3 & 0xFFu);
					break;
				}
			}
			else
			{
				switch (num4)
				{
				case 3:
					result = (byte)((num3 >> 24) & 0xFFu);
					break;
				case 2:
					result = (byte)((num3 >> 16) & 0xFFu);
					break;
				case 1:
					result = (byte)((num3 >> 8) & 0xFFu);
					break;
				case 0:
					result = (byte)(num3 & 0xFFu);
					break;
				}
			}
		}
		return result;
	}

	internal int M(int P_0)
	{
		int result = 0;
		if (m_useFixedValue)
		{
			if (m_numBytesPerCell == 1)
			{
				result = (m_valuesAreSigned ? ((P_0 >= m_fixedValue.Count) ? m_fixedValue[0] : m_fixedValue[P_0]) : ((P_0 >= m_fixedValue.Count) ? (m_fixedValue[0] & 0xFF) : (m_fixedValue[P_0] & 0xFF)));
			}
			else if (m_numBytesPerCell == 2)
			{
				result = (m_valuesAreSigned ? ((P_0 / 2 >= m_fixedValue.Count) ? m_fixedValue[0] : m_fixedValue[P_0 / 2]) : ((P_0 / 2 >= m_fixedValue.Count) ? (m_fixedValue[0] & 0xFFFF) : (m_fixedValue[P_0 / 2] & 0xFFFF)));
			}
			else if (m_numBytesPerCell == 4)
			{
				result = ((P_0 / 4 >= m_fixedValue.Count) ? m_fixedValue[0] : m_fixedValue[P_0 / 4]);
			}
		}
		else if (m_byteAddress != -1)
		{
			result = ((!aJ()) ? global::A.N.A(m_framework.I(), m_byteAddress + P_0, m_numBytesPerCell, m_valuesAreSigned, m_framework.aWR) : global::A.N.A(m_framework.J(), m_byteAddress + P_0, m_numBytesPerCell, m_valuesAreSigned, m_framework.aWR));
		}
		return result;
	}

	internal int ax()
	{
		return M(0);
	}

	internal int B(int P_0, int P_1, int P_2)
	{
		return M(a(P_0, P_1, P_2));
	}

	internal int m(int P_0)
	{
		return M(a(P_0, 0, 0));
	}

	internal byte[] aY()
	{
		int num = BB();
		byte[] array = new byte[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = l(i);
		}
		return array;
	}

	internal string ay()
	{
		return N(-1);
	}

	internal string N(int P_0)
	{
		if (m_encoding != 0)
		{
			Encoding encoding = Encoding.GetEncoding(m_encoding);
			byte[] array;
			if (P_0 == -1)
			{
				array = new byte[m_dimensionsSliceRowCol[2] * m_numBytesPerCell];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = l(i);
				}
			}
			else
			{
				array = new byte[m_dimensionsSliceRowCol[1] * m_numBytesPerCell];
				int num = P_0 * m_dimensionsSliceRowCol[1];
				for (int j = 0; j < array.Length; j++)
				{
					array[j] = l(num + j);
				}
			}
			return encoding.GetString(array).TrimEnd('\0');
		}
		return string.Empty;
	}

	internal new void A(string P_0, bool P_1)
	{
		A(P_0, -1, P_1);
	}

	internal void A(string P_0, int P_1, bool P_2)
	{
		if (m_encoding == 0)
		{
			return;
		}
		bool flag = aZ();
		az();
		bool flag2 = m_framework.l();
		m_framework.M();
		byte[] bytes = Encoding.GetEncoding(m_encoding).GetBytes(P_0);
		if (P_1 == -1)
		{
			for (int i = 0; i < m_dimensionsSliceRowCol[2]; i++)
			{
				if (i < bytes.Length)
				{
					A(i, bytes[i], P_2);
				}
				else
				{
					A(i, (byte)0, P_2);
				}
			}
		}
		else
		{
			int num = P_1 * m_dimensionsSliceRowCol[1];
			for (int j = 0; j < m_dimensionsSliceRowCol[1]; j++)
			{
				if (j < bytes.Length)
				{
					A(num + j, bytes[j], P_2);
				}
				else
				{
					A(num + j, (byte)0, P_2);
				}
			}
		}
		if (flag2)
		{
			m_framework.A(true, this);
		}
		if (flag)
		{
			this.i(true);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal new void A(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = BrI;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref BrI, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal new void a(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = BrI;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref BrI, val3, val2);
		}
		while (val != val2);
	}

	protected virtual void OnDataChangedHandler()
	{
		if (!m_useFixedValue && aN() && m_framework.aWX && m_defaultDataBytes != null)
		{
			for (int i = 0; i < m_dimensionsSliceRowCol[0]; i++)
			{
				for (int j = 0; j < m_dimensionsSliceRowCol[1]; j++)
				{
					for (int k = 0; k < m_dimensionsSliceRowCol[2]; k++)
					{
						int num = global::A.N.A(m_defaultDataBytes, a(k, j, i), m_numBytesPerCell, m_valuesAreSigned, m_framework.aWR);
						if (B(k, j, i) == num)
						{
							continue;
						}
						lock (m_framework.k())
						{
							if (!m_framework.k().Contains(this))
							{
								m_framework.k().Add(this);
							}
						}
					}
				}
			}
		}
		if (BrI != null)
		{
			BrI.Invoke((object)this, (EventArgs)null);
		}
	}

	[SpecialName]
	internal bool aZ()
	{
		return Bri;
	}

	internal void i(bool P_0)
	{
		Bri = true;
		if (P_0)
		{
			OnDataChangedHandler();
		}
	}

	internal void az()
	{
		Bri = false;
	}

	internal void BA()
	{
		if (!aJ())
		{
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEH());
		}
		if (m_framework.E())
		{
			bool flag = m_idsWithEquationsAffectedByThisSetting.Count != 0 || m_objectIdsWithEquationsAffectedByThisSetting.Count != 0;
			bool flag2 = PortFunction.a(m_parentSettingOrSpecialObject);
			if (flag || flag2)
			{
				int num = Ba();
				int[] array = new int[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = m(i);
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
						BM.b(m_dataId);
					}
					else if (flag2)
					{
						int num2 = array[0];
						int num3 = BrJ[0];
						if (m_framework.awg.ContainsKey(num2) || m_framework.awg.ContainsKey(num3))
						{
							BM.b(m_dataId);
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

	internal bool A(int P_0, byte P_1, bool P_2)
	{
		if (m_useFixedValue || m_byteAddress == -1)
		{
			return false;
		}
		if (aN() && m_framework.aWX && m_defaultDataBytes != null && P_1 != m_defaultDataBytes[P_0])
		{
			P_1 = m_defaultDataBytes[P_0];
		}
		Ck ck = null;
		Cj cj = null;
		if (P_2 && !aJ() && !BM.qW)
		{
			ck = BM.aM();
			if (ck != null && ck.A())
			{
				cj = ck.b();
				cj.A(this);
				cj.A(this, P_0, 1);
			}
		}
		bool result = false;
		if (aJ())
		{
			if (m_framework.J()[m_byteAddress + P_0] != P_1)
			{
				m_framework.J()[m_byteAddress + P_0] = P_1;
				result = true;
			}
		}
		else if (m_framework.I()[m_byteAddress + P_0] != P_1)
		{
			m_framework.I()[m_byteAddress + P_0] = P_1;
			result = true;
		}
		if (P_2)
		{
			if (aJ())
			{
				m_framework.j()[m_byteAddress + P_0] = by.aYK;
			}
			else
			{
				m_framework.i()[m_byteAddress + P_0] = by.aYK;
			}
			if (aI() || m_metaDataString.Length != 0)
			{
				m_framework.aXd = true;
				m_framework.aXE = true;
			}
		}
		if (aZ())
		{
			OnDataChangedHandler();
		}
		if (m_framework.l() && !aJ())
		{
			m_framework.A(this);
		}
		if (ck != null && ck.A())
		{
			cj.a(this, P_0, 1);
		}
		return result;
	}

	internal bool A(int P_0, int P_1, bool P_2)
	{
		if (m_useFixedValue || m_byteAddress == -1)
		{
			return false;
		}
		if (aN() && m_framework.aWX && m_defaultDataBytes != null)
		{
			int num = global::A.N.A(m_defaultDataBytes, P_0, m_numBytesPerCell, m_valuesAreSigned, m_framework.aWR);
			if (P_1 != num)
			{
				P_1 = num;
			}
		}
		Ck ck = null;
		Cj cj = null;
		if (P_2 && !aJ() && !BM.qW)
		{
			ck = BM.aM();
			if (ck != null && ck.A())
			{
				cj = ck.b();
				cj.A(this);
				cj.A(this, P_0, m_numBytesPerCell);
			}
		}
		bool result = ((!aJ()) ? global::A.N.A(P_1, m_framework.I(), m_byteAddress + P_0, m_numBytesPerCell, m_framework.aWR) : global::A.N.A(P_1, m_framework.J(), m_byteAddress + P_0, m_numBytesPerCell, m_framework.aWR));
		if (P_2)
		{
			for (int i = 0; i < m_numBytesPerCell; i++)
			{
				if (aJ())
				{
					m_framework.j()[m_byteAddress + P_0 + i] = by.aYK;
				}
				else
				{
					m_framework.i()[m_byteAddress + P_0 + i] = by.aYK;
				}
			}
			if (aI() || m_metaDataString.Length != 0)
			{
				m_framework.aXd = true;
				m_framework.aXE = true;
			}
		}
		if (aZ())
		{
			OnDataChangedHandler();
		}
		if (m_framework.l() && !aJ())
		{
			m_framework.A(this);
		}
		if (ck != null && ck.A())
		{
			cj.a(this, P_0, m_numBytesPerCell);
		}
		return result;
	}

	internal bool a(int P_0, bool P_1)
	{
		return A(0, P_0, P_1);
	}

	internal bool A(int P_0, int P_1, int P_2, int P_3, bool P_4)
	{
		return A(a(P_0, P_1, P_2), P_3, P_4);
	}

	internal bool a(int P_0, int P_1, bool P_2)
	{
		return A(a(P_0, 0, 0), P_1, P_2);
	}

	internal bool A(byte[] P_0, bool P_1)
	{
		bool flag = false;
		bool flag2 = aZ();
		az();
		bool flag3 = m_framework.l();
		m_framework.M();
		int num = Math.Min(BB(), P_0.Length);
		for (int i = 0; i < num; i++)
		{
			flag = A(i, P_0[i], P_1) || flag;
		}
		if (flag3)
		{
			m_framework.A(true, this);
		}
		if (flag2)
		{
			this.i(true);
		}
		return flag;
	}

	internal bool A(int[] P_0, bool P_1)
	{
		bool flag = false;
		bool flag2 = aZ();
		az();
		bool flag3 = m_framework.l();
		m_framework.M();
		int num = Math.Min(Ba(), P_0.Length);
		for (int i = 0; i < num; i++)
		{
			flag = a(i, P_0[i], P_1) || flag;
		}
		if (flag3)
		{
			m_framework.A(true, this);
		}
		if (flag2)
		{
			this.i(true);
		}
		return flag;
	}

	internal int Ba()
	{
		return m_dimensionsSliceRowCol[0] * m_dimensionsSliceRowCol[1] * m_dimensionsSliceRowCol[2];
	}

	internal int BB()
	{
		return m_numBytesPerCell * Ba();
	}

	internal bool J(bool P_0)
	{
		bool flag = false;
		bool flag2 = aZ();
		az();
		bool flag3 = m_framework.l();
		m_framework.M();
		int num = BB();
		for (int i = 0; i < num; i++)
		{
			flag = A(i, (byte)0, P_0) || flag;
		}
		if (flag3)
		{
			m_framework.A(true, this);
		}
		if (flag2)
		{
			this.i(true);
		}
		return flag;
	}

	internal bool Bb()
	{
		int num = BB();
		for (int i = 0; i < num; i++)
		{
			if (l(i) != 0)
			{
				return false;
			}
		}
		return true;
	}

	internal bool A(Setting P_0, int P_1)
	{
		if (m_numBytesPerCell != P_0.aG())
		{
			return false;
		}
		if (P_1 >= Ba())
		{
			return false;
		}
		if (P_1 >= P_0.Ba())
		{
			return false;
		}
		return m(P_1) == P_0.m(P_1);
	}

	internal bool A(Setting P_0)
	{
		int num = Ba();
		if (num != P_0.Ba())
		{
			return false;
		}
		for (int i = 0; i < num; i++)
		{
			if (m(i) != P_0.m(i))
			{
				return false;
			}
		}
		return true;
	}

	internal bool a(int[] P_0)
	{
		if (P_0 == null || P_0.Length > Ba())
		{
			return false;
		}
		int num = Math.Min(P_0.Length, Ba());
		for (int i = 0; i < num; i++)
		{
			if (m(i) != P_0[i])
			{
				return false;
			}
		}
		return true;
	}

	internal bool a(byte[] P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		int num = BB();
		if (num != P_0.Length)
		{
			return false;
		}
		for (int i = 0; i < num; i++)
		{
			if (l(i) != P_0[i])
			{
				return false;
			}
		}
		return true;
	}

	internal List<Setting> BC()
	{
		List<Setting> val = new List<Setting>();
		List<ListItems.A> val2 = L();
		for (int i = 0; i < val2.Count; i++)
		{
			if (val2[i].bBW != 0)
			{
				Setting setting = m_framework.A(val2[i].bBW);
				if (setting != null)
				{
					val.Add(setting);
				}
			}
		}
		return val;
	}

	internal string Bc()
	{
		return a(ax(), 0);
	}

	internal string a(int P_0, int P_1 = 0)
	{
		List<ListItems.A> val = d(P_1);
		for (int i = 0; i < val.Count; i++)
		{
			if (val[i].bBv != P_0)
			{
				continue;
			}
			if (val[i].bBW != 0)
			{
				Setting setting = m_framework.A(val[i].bBW);
				if (setting != null)
				{
					string text = setting.ay();
					if (string.IsNullOrWhiteSpace(text))
					{
						return val[i].bBV;
					}
					return text;
				}
				return val[i].bBV;
			}
			return val[i].bBV;
		}
		return null;
	}

	internal string BD()
	{
		return B(ax(), 0);
	}

	internal string B(int P_0, int P_1 = 0)
	{
		string text = null;
		List<MaskItems.A> val = e(P_1);
		for (int i = 0; i < val.Count; i++)
		{
			if ((P_0 & val[i].bbB) == val[i].bba)
			{
				if (text == null)
				{
					text = val[i].bbA;
					continue;
				}
				string text2 = ((m_maskJoinText != null) ? m_maskJoinText : string.Empty);
				text = text + text2 + val[i].bbA;
			}
		}
		return text;
	}

	internal bool b(int P_0, int P_1 = 0)
	{
		List<ListItems.A> val = d(P_1);
		bool flag = false;
		for (int i = 0; i < val.Count; i++)
		{
			if (val[i].bBv == P_0)
			{
				flag = true;
				break;
			}
		}
		List<MaskItems.A> val2 = e(P_1);
		bool flag2 = false;
		for (int j = 0; j < val2.Count; j++)
		{
			if ((P_0 & val2[j].bbB) == val2[j].bba)
			{
				flag2 = true;
				break;
			}
		}
		return flag || flag2;
	}

	internal Image Bd()
	{
		return n(ax());
	}

	internal Image n(int P_0)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		List<ListItems.A> val = d(0);
		for (int i = 0; i < val.Count; i++)
		{
			if (val[i].bBv != P_0)
			{
				continue;
			}
			if (!string.IsNullOrEmpty(val[i].bBw))
			{
				byte[] array = global::A.n.A(val[i].bBw);
				if (array != null)
				{
					MemoryStream val2 = new MemoryStream(array);
					Image result = Image.FromStream((Stream)val2);
					((Stream)val2).Close();
					return result;
				}
			}
			return null;
		}
		return null;
	}

	internal bool BE()
	{
		List<ListItems.A> val = L();
		for (int i = 0; i < val.Count; i++)
		{
			if (!string.IsNullOrEmpty(val[i].bBw))
			{
				return true;
			}
		}
		return false;
	}
}
