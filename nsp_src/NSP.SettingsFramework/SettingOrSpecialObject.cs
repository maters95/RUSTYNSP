using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using b;

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

		internal EnableOn(string P_0, int P_1)
		{
			BrL = P_0;
			Brl = P_1;
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

		internal void A(string P_0, int P_1)
		{
			if (P_1 == -1)
			{
				Brm = P_0;
				BrM = P_0;
			}
			else
			{
				BrN.Add(P_1, P_0);
			}
		}

		public virtual string ToString()
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

	internal SettingOrSpecialObject(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
	{
		m_framework = P_0;
		m_parentSettingOrSpecialObject = P_2;
		m_parentModuleName = P_3;
		m_internalName = P_1;
		int parentDataId = 0;
		if (P_2 is Setting)
		{
			parentDataId = (P_2 as Setting).A();
		}
		m_parentDataId = parentDataId;
		int parentObjectId = -1;
		if (P_2 != null)
		{
			parentObjectId = P_2.r();
		}
		m_parentObjectId = parentObjectId;
		for (int i = 0; i < 7; i++)
		{
			m_stringProperties[i] = new StringProperty();
		}
	}

	[SpecialName]
	internal Framework A()
	{
		return m_framework;
	}

	[SpecialName]
	internal List<SettingOrSpecialObject> a()
	{
		return m_childSettingsOrSpecialObjects;
	}

	[SpecialName]
	internal string B()
	{
		return m_internalName;
	}

	[SpecialName]
	internal int b()
	{
		return m_parentDataId;
	}

	[SpecialName]
	internal int C()
	{
		return m_parentObjectId;
	}

	[SpecialName]
	internal string c()
	{
		return m_parentModuleName;
	}

	[SpecialName]
	internal SettingOrSpecialObject D()
	{
		return m_parentSettingOrSpecialObject;
	}

	internal bool A(SettingOrSpecialObject P_0, bool P_1)
	{
		if (P_1)
		{
			if (m_parentSettingOrSpecialObject != null && m_parentSettingOrSpecialObject == P_0)
			{
				return true;
			}
			return false;
		}
		SettingOrSpecialObject settingOrSpecialObject = this;
		bool flag = false;
		do
		{
			if (settingOrSpecialObject.D() != null)
			{
				if (settingOrSpecialObject.D() == P_0)
				{
					return true;
				}
				settingOrSpecialObject = settingOrSpecialObject.D();
			}
			else
			{
				flag = true;
			}
		}
		while (!flag);
		return false;
	}

	[SpecialName]
	internal int d()
	{
		return m_partialMapTypeId;
	}

	[SpecialName]
	internal void A(int P_0)
	{
		m_partialMapTypeId = P_0;
	}

	[SpecialName]
	internal Dictionary<string, string> E()
	{
		return m_partialMapTagFilters.Brn;
	}

	internal CG e()
	{
		if (this is CG)
		{
			return this as CG;
		}
		if (f().DataIdOfChannelListSetting != 0)
		{
			return f();
		}
		if (this is SpecialObject)
		{
			SpecialObject specialObject = this as SpecialObject;
			if (specialObject.C().IdleText != null || specialObject.C().PreApplySettingDataIds.Count != 0)
			{
				return specialObject.C();
			}
			if (specialObject.B().CurrentUIListSettingsIdsAndIndents.Count != 0)
			{
				return specialObject.B();
			}
			if (specialObject.b().DataIdsOfListSettings.Count != 0 || specialObject.b().EachListRowIsAnObject())
			{
				return specialObject.b();
			}
			if (specialObject.c().EnablerSettingId != 0 || specialObject.c().ChannelSettingId != 0 || specialObject.c().OperatorSettingId != 0 || specialObject.c().ThresholdSettingId != 0 || !string.IsNullOrEmpty(specialObject.c().JoinText))
			{
				return specialObject.c();
			}
			return null;
		}
		return null;
	}

	[SpecialName]
	internal PortFunction F()
	{
		if (m_portFunction == null)
		{
			m_portFunction = new PortFunction(m_framework, this);
		}
		return m_portFunction;
	}

	[SpecialName]
	internal UserLog f()
	{
		if (m_userLog == null)
		{
			m_userLog = new UserLog(m_framework, this);
		}
		return m_userLog;
	}

	[SpecialName]
	internal byte G()
	{
		return m_externalDeviceType;
	}

	[SpecialName]
	internal void A(byte P_0)
	{
		m_externalDeviceType = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal int g()
	{
		return aYX;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(int P_0)
	{
		aYX = P_0;
	}

	internal string H()
	{
		Setting setting = h();
		string result = string.Empty;
		if (setting != null && setting.c() != 0)
		{
			result = ((g() == -1) ? setting.ay() : setting.N(g()));
		}
		return result;
	}

	internal Setting h()
	{
		Setting result = null;
		if (m_dataIdOfCustomNameSetting != 0)
		{
			result = m_framework.A(m_dataIdOfCustomNameSetting);
		}
		return result;
	}

	[SpecialName]
	internal int I()
	{
		return m_dataIdOfCustomNameSetting;
	}

	[SpecialName]
	internal void B(int P_0)
	{
		m_dataIdOfCustomNameSetting = P_0;
	}

	internal string A(bool P_0)
	{
		string text = string.Empty;
		if (this is Setting setting && setting.aJ())
		{
			string text2 = A(bz.aYt);
			string text3 = ((SettingOrSpecialObject)setting).H();
			text = ((!string.IsNullOrWhiteSpace(text3)) ? (text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()) : text2);
		}
		else if (P_0)
		{
			if (Bz.A() && A(bz.aYW) != null)
			{
				text = A(bz.aYW);
			}
			else if (A(bz.aYv) != null)
			{
				text = A(bz.aYv);
			}
			else if (A(bz.aYV) != null)
			{
				text = A(bz.aYV);
			}
			else if (A(bz.aYu) != null)
			{
				text = A(bz.aYu);
			}
			if (string.IsNullOrWhiteSpace(text))
			{
				text = A(bz.aYt);
			}
			if (string.IsNullOrEmpty(text))
			{
				text = m_internalName;
			}
		}
		else if (Bz.A() && A(bz.aYW) != null)
		{
			text = A(bz.aYW);
		}
		else if (A(bz.aYv) != null)
		{
			text = A(bz.aYv);
		}
		else if (A(bz.aYV) != null)
		{
			text = A(bz.aYV);
		}
		else if (A(bz.aYu) != null)
		{
			text = A(bz.aYu);
		}
		else if (A(bz.aYt) != null)
		{
			text = A(bz.aYt);
		}
		return text;
	}

	[SpecialName]
	internal List<string> i()
	{
		return m_searchMetaTags;
	}

	[SpecialName]
	internal List<InitialTaskObject> J()
	{
		return m_initialTaskObjects;
	}

	internal bool j()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		Enumerator<InitialTaskObject> enumerator = m_initialTaskObjects.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				InitialTaskObject current = enumerator.Current;
				switch (current.c())
				{
				case Cf.azu:
					return false;
				case Cf.azt:
					if (current.B())
					{
						return false;
					}
					result = false;
					break;
				case Cf.azU:
					if (current.b())
					{
						return false;
					}
					result = false;
					break;
				}
			}
			return result;
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	[SpecialName]
	internal SettingWriteTaskObject K()
	{
		if (m_settingWriteTaskObject == null)
		{
			m_settingWriteTaskObject = new SettingWriteTaskObject(m_framework);
		}
		return m_settingWriteTaskObject;
	}

	[SpecialName]
	internal List<int> k()
	{
		return m_embeddedFunctionsObjectIds;
	}

	internal void b(int P_0)
	{
		m_embeddedFunctionsObjectIds.Add(P_0);
	}

	internal void a(SettingOrSpecialObject P_0, bool P_1)
	{
		Setting setting = this as Setting;
		Setting setting2 = P_0 as Setting;
		if (setting != null && setting2 != null)
		{
			setting.A(setting2, P_1);
		}
		for (int i = 0; i < P_0.a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = m_childSettingsOrSpecialObjects[i];
			SettingOrSpecialObject settingOrSpecialObject2 = P_0.a()[i];
			settingOrSpecialObject.a(settingOrSpecialObject2, P_1);
		}
	}

	internal void A(string P_0, int P_1)
	{
		m_allEnableOns.Add(new EnableOn(P_0, P_1));
	}

	internal bool A(string P_0)
	{
		for (int i = 0; i < m_allEnableOns.Count; i++)
		{
			if (m_allEnableOns[i].BrL.Contains(P_0))
			{
				return true;
			}
		}
		return false;
	}

	internal void A(string P_0, string P_1, int P_2, string P_3)
	{
		if (P_2 == -1)
		{
			m_partialMapTagFilters.BrO.Add(P_0, P_1);
			m_partialMapTagFilters.Brn.Add(P_0, P_1);
			aYx = string.Empty;
			return;
		}
		if (P_3 != aYx)
		{
			m_partialMapTagFilters.Bro.Add(P_2, new Dictionary<string, string>());
			aYx = P_3;
		}
		m_partialMapTagFilters.Bro[P_2].Add(P_0, P_1);
	}

	internal virtual void A(string P_0, bool P_1)
	{
		CondPropertiesBlock condPropertiesBlock = default(CondPropertiesBlock);
		condPropertiesBlock.Brj = m_condPropertiesBlocks.Count;
		condPropertiesBlock.BrK = P_0;
		condPropertiesBlock.Brk = P_1;
		CondPropertiesBlock condPropertiesBlock2 = condPropertiesBlock;
		m_condPropertiesBlocks.Add(condPropertiesBlock2);
		if (P_1)
		{
			m_hasMultiCellCondProperties = true;
		}
	}

	internal bool a(string P_0)
	{
		for (int i = 0; i < m_condPropertiesBlocks.Count; i++)
		{
			if (m_condPropertiesBlocks[i].BrK.Contains(P_0))
			{
				return true;
			}
		}
		return false;
	}

	internal int L()
	{
		return m_condPropertiesBlocks.Count;
	}

	protected virtual void RevertAllConditionalPropertiesToDefaults()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < 7; i++)
		{
			m_stringProperties[i].BrM = m_stringProperties[i].Brm;
		}
		m_partialMapTagFilters.Brn.Clear();
		Enumerator<string, string> enumerator = m_partialMapTagFilters.BrO.Keys.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				m_partialMapTagFilters.Brn.Add(current, m_partialMapTagFilters.BrO[current]);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
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
		F().e();
	}

	protected virtual void UpdateConditionalPropertiesValues(int cellIndex, int condPropertiesBlockIndex)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
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
			Enumerator<string, string> enumerator = m_partialMapTagFilters.Bro[condPropertiesBlockIndex].Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					m_partialMapTagFilters.Brn.Add(current, m_partialMapTagFilters.Bro[condPropertiesBlockIndex][current]);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
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
		F().a(condPropertiesBlockIndex);
	}

	[SpecialName]
	internal bool l()
	{
		return m_currentEnableOn;
	}

	[SpecialName]
	internal HashSet<int> M()
	{
		return m_dataIdsInEnableOnEquations;
	}

	[SpecialName]
	internal HashSet<int> m()
	{
		return m_dataIdsInCondPropsEquations;
	}

	private bool A(HashSet<DataIdAndAttrId> P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<int> enumerator = m_dataIdsInEnableOnEquations.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current = enumerator.Current;
				if (P_0.Contains(new DataIdAndAttrId(current)))
				{
					return true;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		enumerator = m_dataIdsInCondPropsEquations.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current2 = enumerator.Current;
				if (P_0.Contains(new DataIdAndAttrId(current2)))
				{
					return true;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (this is FilterOption)
		{
			enumerator = (this as FilterOption).B().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current3 = enumerator.Current;
					if (P_0.Contains(new DataIdAndAttrId(current3)))
					{
						return true;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		if (this is Setting setting)
		{
			for (int i = 0; i < setting.Q().Count; i++)
			{
				if (setting.Q()[i] == null)
				{
					continue;
				}
				enumerator = setting.Q()[i].GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						int current4 = enumerator.Current;
						if (P_0.Contains(new DataIdAndAttrId(current4)))
						{
							return true;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			if (setting.b() && ((SettingOrSpecialObject)setting).D() != null)
			{
				enumerator = ((SettingOrSpecialObject)setting).D().M().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						int current5 = enumerator.Current;
						if (P_0.Contains(new DataIdAndAttrId(current5)))
						{
							return true;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			if (((SettingOrSpecialObject)setting).D() != null && (((SettingOrSpecialObject)setting).D() is DN || ((SettingOrSpecialObject)setting).D().D() is DN))
			{
				DN dN = ((((SettingOrSpecialObject)setting).D() is DN) ? (((SettingOrSpecialObject)setting).D() as DN) : (((SettingOrSpecialObject)setting).D().D() as DN));
				if (P_0.Contains(dN.BZK.C()))
				{
					return true;
				}
				if ((dN.BZK.A() == 19293 && P_0.Contains(new DataIdAndAttrId(10363))) || (dN.BZK.A() == 19323 && P_0.Contains(new DataIdAndAttrId(10362))) || (dN.BZK.A() == 19351 && P_0.Contains(new DataIdAndAttrId(16033))))
				{
					return true;
				}
				if (setting == dN.BZK)
				{
					if (P_0.Contains(dN.BZl.C()) || P_0.Contains(dN.BZk.C()) || P_0.Contains(dN.BZL.C()) || P_0.Contains(dN.BZN.C()) || P_0.Contains(dN.BZm.C()) || P_0.Contains(dN.BZp.C()) || P_0.Contains(dN.BZo.C()) || P_0.Contains(dN.BZP.C()) || P_0.Contains(dN.BZn.C()) || P_0.Contains(dN.BZr.C()) || P_0.Contains(dN.BZq.C()))
					{
						return true;
					}
				}
				else if (setting == dN.BZk)
				{
					if (P_0.Contains(dN.BZl.C()))
					{
						return true;
					}
				}
				else if (setting == dN.BZL)
				{
					if (P_0.Contains(dN.BZl.C()))
					{
						return true;
					}
					enumerator = dN.BZj.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current6 = enumerator.Current;
							if (P_0.Contains(new DataIdAndAttrId(current6)))
							{
								return true;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				else if (setting == dN.BZm)
				{
					if (P_0.Contains(dN.BZl.C()) || P_0.Contains(dN.BZN.C()))
					{
						return true;
					}
				}
				else if (setting == dN.BZq)
				{
					if (P_0.Contains(dN.BZl.C()) || P_0.Contains(dN.BZN.C()))
					{
						return true;
					}
				}
				else if (setting == dN.BZo)
				{
					if (P_0.Contains(dN.BZl.C()) || P_0.Contains(dN.BZN.C()) || P_0.Contains(dN.BZp.C()) || P_0.Contains(dN.BZP.C()))
					{
						return true;
					}
				}
				else if (setting == dN.BZP)
				{
					if (P_0.Contains(dN.BZl.C()) || P_0.Contains(dN.BZN.C()) || P_0.Contains(dN.BZp.C()) || P_0.Contains(dN.BZo.C()))
					{
						return true;
					}
				}
				else if (setting == dN.BZn)
				{
					if (P_0.Contains(dN.BZl.C()) || P_0.Contains(dN.BZN.C()) || P_0.Contains(dN.BZM.C()))
					{
						return true;
					}
				}
				else if (setting == dN.BZr && (P_0.Contains(dN.BZl.C()) || P_0.Contains(dN.BZN.C()) || P_0.Contains(dN.BZn.C()) || P_0.Contains(dN.BZO.C())))
				{
					return true;
				}
			}
		}
		return false;
	}

	internal bool A(HashSet<DataIdAndAttrId> P_0, bool P_1)
	{
		Setting setting = this as Setting;
		bool flag = false;
		flag = P_0 == null || P_0.Count == 0 || ((setting == null || !setting.Y() || !P_1) && setting != null && P_0.Contains(setting.C())) || A(P_0);
		if (setting != null)
		{
			if (!flag && this is Dn)
			{
				flag = true;
			}
			if (!flag && PortFunction.a(m_parentSettingOrSpecialObject))
			{
				if (P_1)
				{
					if (setting.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoe()))
					{
						flag = true;
					}
				}
				else if (A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoe()))
				{
					flag = true;
				}
				else if (a(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoe()))
				{
					flag = true;
				}
			}
			if (!flag && m_parentSettingOrSpecialObject != null && !setting.aJ() && (setting.d(0).Count != 0 || setting.e(0).Count != 0) && setting is Do)
			{
				for (int i = 0; i < m_parentSettingOrSpecialObject.a().Count; i++)
				{
					if (m_parentSettingOrSpecialObject.a()[i] is Setting setting2 && setting2.T())
					{
						if (P_0.Contains(setting2.C()))
						{
							flag = true;
						}
						break;
					}
				}
				if (!flag)
				{
					if (P_1)
					{
						if (setting.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ald()))
						{
							flag = true;
						}
					}
					else if (A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ald()))
					{
						flag = true;
					}
					else if (a(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ald()))
					{
						flag = true;
					}
				}
			}
			if (!flag && setting.T())
			{
				flag = true;
			}
			if (!flag && setting.j() != 0)
			{
				flag = true;
			}
			if (!flag && (setting.v() || setting.X()))
			{
				flag = true;
			}
			if (!flag && setting.w().DataId != 0)
			{
				flag = true;
			}
			if (!flag && setting.b() && setting.B() != 4)
			{
				Setting setting3 = m_framework.A(new DataIdAndAttrId(setting.A(), 4));
				if (setting3 != null && P_0.Contains(setting3.C()))
				{
					flag = true;
				}
			}
			if (!flag && setting.b() && (setting.B() == 8 || setting.B() == 9 || setting.B() == 6 || setting.B() == 7))
			{
				Setting setting4 = m_framework.A(new DataIdAndAttrId(setting.A(), 8));
				Setting setting5 = m_framework.A(new DataIdAndAttrId(setting.A(), 9));
				Setting setting6 = m_framework.A(new DataIdAndAttrId(setting.A(), 6));
				Setting setting7 = m_framework.A(new DataIdAndAttrId(setting.A(), 7));
				if ((setting4 != null && P_0.Contains(setting4.C())) || (setting5 != null && P_0.Contains(setting5.C())) || (setting6 != null && P_0.Contains(setting6.C())) || (setting7 != null && P_0.Contains(setting7.C())))
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
			if (!P_1)
			{
				bool flag2 = m_dataIdsInEnableOnEquations.Count == 0 && (P_0 == null || P_0.Count == 0);
				m_conditionsChangedOnLastEvaluation = false;
				m_conditionsChangedOnLastEvaluation |= EvaluateCondPropertiesConditions(flag2);
				m_conditionsChangedOnLastEvaluation |= EvaluateEnableOnConditions(flag2);
				if (this is FilterOption)
				{
					m_conditionsChangedOnLastEvaluation |= (this as FilterOption).a(flag2);
				}
			}
			else
			{
				if (setting != null)
				{
					bool flag2 = setting.Q().Count == 0 && (P_0 == null || P_0.Count == 0);
					if (flag2 || !setting.Y())
					{
						m_conditionsChangedOnLastEvaluation |= setting.D(flag2);
					}
					DataIdAndAttrId dataIdAndAttrId = setting.C();
					if (!m_conditionsChangedOnLastEvaluation && setting.c() != 0 && P_0 != null && P_0.Contains(dataIdAndAttrId))
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
					if (!m_conditionsChangedOnLastEvaluation && setting is Dn && P_0 != null && P_0.Contains(dataIdAndAttrId))
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
					if (!m_conditionsChangedOnLastEvaluation && setting is Dk && dataIdAndAttrId == (setting as Dk).B().C() && P_0 != null && P_0.Contains(dataIdAndAttrId))
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
					if (!m_conditionsChangedOnLastEvaluation && setting.w().DataId != 0)
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
					if (!m_conditionsChangedOnLastEvaluation && setting.b() && setting.B() != 4 && m_framework.A(new DataIdAndAttrId(setting.A(), 4)) != null)
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
					if (!m_conditionsChangedOnLastEvaluation && (setting.aE() != 0 || setting.ae() != 0))
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
					if (!m_conditionsChangedOnLastEvaluation && dataIdAndAttrId.DataId == 10195 && P_0 != null && P_0.Contains(dataIdAndAttrId))
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
					if (!m_conditionsChangedOnLastEvaluation && (dataIdAndAttrId.DataId == 19293 || dataIdAndAttrId.DataId == 19323 || dataIdAndAttrId.DataId == 19351) && P_0 != null && P_0.Contains(dataIdAndAttrId))
					{
						m_conditionsChangedOnLastEvaluation = true;
					}
				}
				if (m_conditionsChangedOnLastEvaluation)
				{
					N();
				}
			}
			return m_conditionsChangedOnLastEvaluation;
		}
		return false;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = aYY;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref aYY, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = aYY;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref aYY, val3, val2);
		}
		while (val != val2);
	}

	private void N()
	{
		if (!aYy)
		{
			return;
		}
		if (aYY != null)
		{
			aYY.Invoke((object)this, (EventArgs)null);
		}
		if (!(this is Setting setting) || !m_framework.E() || m_framework.awh == null || m_framework.awh.f() == null || setting.i() == 0 || !setting.aJ())
		{
			return;
		}
		Setting setting2 = m_framework.A(12201);
		if (setting2 != null && setting2.ax() != 0)
		{
			if (l() && PortFunction.A(setting))
			{
				m_framework.awh.f().AddChannelToLoggingList(setting, setting.i() - 1);
			}
			else
			{
				m_framework.awh.f().RemoveChannelFromLoggingList(setting);
			}
		}
	}

	internal void n()
	{
		aYy = true;
		if (m_conditionsChangedOnLastEvaluation)
		{
			N();
			m_conditionsChangedOnLastEvaluation = false;
		}
	}

	internal void O()
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
				string brL = m_currentEnableOns[i].BrL;
				List<int> val = T.A(ref brL, m_framework);
				if (initInfluencingSettingIdsList)
				{
					for (int j = 0; j < val.Count; j++)
					{
						m_dataIdsInEnableOnEquations.Add(val[j]);
						Setting setting = m_framework.A(val[j]);
						if (this is SpecialObject)
						{
							setting.r().Add(m_objectId);
						}
					}
				}
				bool flag2 = T.A(ref brL);
				flag = flag || flag2;
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
			string brK = m_condPropertiesBlocks[i].BrK;
			List<int> val = T.A(ref brK, m_framework);
			if (initInfluencingSettingIdsList)
			{
				for (int j = 0; j < val.Count; j++)
				{
					m_dataIdsInCondPropsEquations.Add(val[j]);
					Setting setting = m_framework.A(val[j]);
					if (this is SpecialObject)
					{
						setting.r().Add(m_objectId);
					}
					else if (this is Setting)
					{
						setting.R().Add((this as Setting).C());
					}
				}
			}
			bool flag2 = T.A(ref brK);
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
	internal MenuNode o()
	{
		return m_isTargetObjectForMenuNode;
	}

	[SpecialName]
	internal void A(MenuNode P_0)
	{
		m_isTargetObjectForMenuNode = P_0;
	}

	[SpecialName]
	internal string P()
	{
		return m_disclaimer;
	}

	[SpecialName]
	internal void B(string P_0)
	{
		m_disclaimer = P_0;
	}

	[SpecialName]
	internal bool p()
	{
		return m_disclaimerShowEveryTime;
	}

	[SpecialName]
	internal void a(bool P_0)
	{
		m_disclaimerShowEveryTime = P_0;
	}

	internal void b(string P_0)
	{
		m_associatedDTCs.Add(P_0);
	}

	internal List<string> Q()
	{
		return m_associatedDTCs;
	}

	[SpecialName]
	internal string q()
	{
		return m_dtc;
	}

	[SpecialName]
	internal void C(string P_0)
	{
		m_dtc = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal string R()
	{
		return aYZ;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void c(string P_0)
	{
		aYZ = P_0;
	}

	[SpecialName]
	internal int r()
	{
		return m_objectId;
	}

	[SpecialName]
	internal void C(int P_0)
	{
		m_objectId = P_0;
	}

	internal void A(bz P_0, string P_1, int P_2)
	{
		m_stringProperties[(int)P_0].A(P_1, P_2);
	}

	internal string A(bz P_0)
	{
		return m_stringProperties[(int)P_0].BrM;
	}

	internal string S()
	{
		if (m_parentSettingOrSpecialObject is Dk)
		{
			Dk dk = m_parentSettingOrSpecialObject as Dk;
			DK dK = ((SettingOrSpecialObject)dk).D() as DK;
			string text = dK.H();
			string text2 = ((SettingOrSpecialObject)dk).H();
			string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoF();
			text3 = (string.IsNullOrWhiteSpace(text) ? (text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aof() + (m_framework.awP.E().IndexOf(dK) + 1) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh()) : (text3 + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh()));
			text3 = (string.IsNullOrWhiteSpace(text2) ? (text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoG() + (dK.a().IndexOf(dk) + 1) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh()) : (text3 + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh()));
			return text3 + A(false);
		}
		return A(bz.aYt);
	}

	[SpecialName]
	internal string s()
	{
		return m_inputType;
	}

	[SpecialName]
	internal void D(string P_0)
	{
		m_inputType = P_0;
	}

	internal static bool A(Framework P_0, List<SettingOrSpecialObject> P_1, int P_2, int P_3, bool P_4 = true)
	{
		if (P_2 == P_3)
		{
			return true;
		}
		if (P_2 < 0 || P_2 >= P_1.Count)
		{
			return false;
		}
		if (P_3 < 0 || P_3 >= P_1.Count)
		{
			return false;
		}
		Ck ck = BM.aM();
		if (P_4)
		{
			ck?.a();
			P_0.M();
		}
		SettingOrSpecialObject settingOrSpecialObject = P_1[P_2];
		List<List<int>> val = new List<List<int>>();
		A(settingOrSpecialObject, val);
		if (P_2 > P_3)
		{
			for (int num = P_2; num > P_3; num--)
			{
				P_1[num].a(P_1[num - 1], true);
			}
			int num2 = 0;
			A(P_1[P_3], val, ref num2, true);
		}
		else if (P_2 < P_3)
		{
			for (int i = P_2; i < Math.Min(P_3, P_1.Count - 2); i++)
			{
				P_1[i].a(P_1[i + 1], true);
			}
			int num3 = 0;
			A(P_1[P_3], val, ref num3, true);
		}
		if (P_4)
		{
			P_0.A(true);
			ck?.B();
		}
		for (int j = Math.Min(P_2, P_3); j <= Math.Max(P_3, P_2); j++)
		{
			A(P_1[j]);
		}
		return true;
	}

	internal static void A(SettingOrSpecialObject P_0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 is Setting)
		{
			BM.b((P_0 as Setting).A());
		}
		Enumerator<SettingOrSpecialObject> enumerator = P_0.a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				A(enumerator.Current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal static void A(SettingOrSpecialObject P_0, List<List<int>> P_1)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 is Setting)
		{
			Setting setting = P_0 as Setting;
			int num = setting.Ba();
			List<int> val = new List<int>(num);
			for (int i = 0; i < num; i++)
			{
				val.Add(setting.m(i));
			}
			P_1.Add(val);
		}
		Enumerator<SettingOrSpecialObject> enumerator = P_0.a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				A(enumerator.Current, P_1);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal static void A(SettingOrSpecialObject P_0, List<List<int>> P_1, ref int P_2, bool P_3)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 is Setting)
		{
			Setting setting = P_0 as Setting;
			List<int> val = P_1[P_2];
			for (int i = 0; i < val.Count; i++)
			{
				setting.a(i, val[i], P_3);
			}
			P_2++;
		}
		Enumerator<SettingOrSpecialObject> enumerator = P_0.a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				A(enumerator.Current, P_1, ref P_2, P_3);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}
}
