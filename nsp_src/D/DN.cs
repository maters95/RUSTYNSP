using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using NSP.SettingsFramework;
using a;
using b;

namespace D;

internal class DN : SpecialObject, CG
{
	internal new enum A
	{
		bbH = 0,
		bbh = 1,
		bbI = 4
	}

	[CompilerGenerated]
	private new sealed class a
	{
		public string bbi;

		internal bool A(KeyValuePair<A, ValueTuple<string, string, string>> x)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return x.Value.Item3 == bbi;
		}
	}

	internal static readonly Dictionary<A, ValueTuple<string, string, string>> BZH;

	internal HashSet<ushort> BZh = new HashSet<ushort>();

	internal HashSet<ushort> BZI = new HashSet<ushort>();

	internal HashSet<uint> BZi = new HashSet<uint>();

	internal HashSet<uint> BZJ = new HashSet<uint>();

	internal HashSet<int> BZj = new HashSet<int>();

	internal Setting BZK;

	internal Setting BZk;

	internal Setting BZL;

	internal Setting BZl;

	internal Setting BZM;

	internal Setting BZm;

	internal Setting BZN;

	internal Setting BZn;

	internal Setting BZO;

	internal Setting BZo;

	internal Setting BZP;

	internal Setting BZp;

	internal Setting BZQ;

	internal Setting BZq;

	internal Setting BZR;

	internal Setting BZr;

	internal Setting BZS;

	internal Setting BZs;

	[CompilerGenerated]
	private Dictionary<string, int> BZT = new Dictionary<string, int>();

	[CompilerGenerated]
	private DataIdAndAttrId BZt;

	[CompilerGenerated]
	private DataIdAndAttrId BZU;

	[SpecialName]
	[CompilerGenerated]
	public new Dictionary<string, int> A()
	{
		return BZT;
	}

	[SpecialName]
	[CompilerGenerated]
	public void A(Dictionary<string, int> P_0)
	{
		BZT = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public new DataIdAndAttrId a()
	{
		return BZt;
	}

	[SpecialName]
	[CompilerGenerated]
	public void A(DataIdAndAttrId P_0)
	{
		BZt = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public new DataIdAndAttrId B()
	{
		return BZU;
	}

	[SpecialName]
	[CompilerGenerated]
	public void a(DataIdAndAttrId P_0)
	{
		BZU = P_0;
	}

	internal DN(Framework P_0, string P_1, SettingOrSpecialObject P_2, string P_3)
		: base(P_0, P_1, P_2, P_3)
	{
	}

	internal new static int A(string P_0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		KeyValuePair<A, ValueTuple<string, string, string>> val = Enumerable.FirstOrDefault<KeyValuePair<A, ValueTuple<string, string, string>>>((System.Collections.Generic.IEnumerable<KeyValuePair<A, ValueTuple<string, string, string>>>)BZH, (Func<KeyValuePair<A, ValueTuple<string, string, string>>, bool>)((KeyValuePair<A, ValueTuple<string, string, string>> x) => x.Value.Item3 == P_0));
		if (val.Value.Item3 == null)
		{
			return -1;
		}
		return (int)val.Key;
	}

	internal new static string A(int P_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (!BZH.ContainsKey((A)P_0))
		{
			return string.Empty;
		}
		return BZH[(A)P_0].Item1;
	}

	internal new void b()
	{
		if (((SettingOrSpecialObject)this).B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIg())
		{
			m_framework.awT = this;
		}
		else if (((SettingOrSpecialObject)this).B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIH())
		{
			m_framework.aws = this;
		}
		else if (((SettingOrSpecialObject)this).B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIh())
		{
			m_framework.awt = this;
		}
		for (int i = 0; i < ((SettingOrSpecialObject)this).a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)this).a()[i];
			if (settingOrSpecialObject is Setting)
			{
				if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BII()))
				{
					BZK = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIi()))
				{
					BZk = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIJ()))
				{
					BZL = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIj()))
				{
					BZl = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIK()))
				{
					BZM = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIk()))
				{
					BZN = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIL()))
				{
					BZn = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIl()))
				{
					BZO = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIM()))
				{
					BZo = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIm()))
				{
					BZP = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIN()))
				{
					BZp = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIn()))
				{
					BZQ = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIO()))
				{
					BZq = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIo()))
				{
					BZR = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIP()))
				{
					BZr = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIp()))
				{
					BZS = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIQ()))
				{
					BZs = settingOrSpecialObject as Setting;
				}
			}
			else if (settingOrSpecialObject is SpecialObject && settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIq() && settingOrSpecialObject.a().Count == 1 && settingOrSpecialObject.a()[0] is Setting && settingOrSpecialObject.a()[0].B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIR()))
			{
				BZm = settingOrSpecialObject.a()[0] as Setting;
			}
		}
	}

	internal void A(HashSet<DataIdAndAttrId> P_0)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (P_0 == null || P_0.Count == 0)
		{
			flag = true;
		}
		else if (P_0.Contains(BZl.C()) || P_0.Contains(BZL.C()))
		{
			flag = true;
		}
		else
		{
			Enumerator<int> enumerator = BZj.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					if (P_0.Contains(new DataIdAndAttrId(current)))
					{
						flag = true;
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		if (!flag)
		{
			return;
		}
		BZh.Clear();
		BZI.Clear();
		BZi.Clear();
		BZJ.Clear();
		int num;
		if (((SettingOrSpecialObject)this).B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIg())
		{
			num = 1;
		}
		else if (((SettingOrSpecialObject)this).B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIH())
		{
			num = 0;
		}
		else
		{
			if (!(((SettingOrSpecialObject)this).B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIh()))
			{
				return;
			}
			num = 4;
		}
		bool flag2 = BZj.Count == 0 && (P_0 == null || P_0.Count == 0);
		if (m_framework.awH.ContainsKey(num))
		{
			Enumerator<Cd> enumerator2 = m_framework.awH[num].GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					Cd current2 = enumerator2.Current;
					string text = current2.a();
					List<int> val = T.A(ref text, m_framework);
					if (flag2)
					{
						BZj.UnionWith((System.Collections.Generic.IEnumerable<int>)val);
					}
					if (T.A(ref text))
					{
						BZh.UnionWith((System.Collections.Generic.IEnumerable<ushort>)current2.b());
						BZi.UnionWith((System.Collections.Generic.IEnumerable<uint>)current2.C());
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
		}
		if (BZl == null || BZL == null)
		{
			return;
		}
		int num2 = BZl.av()[2];
		for (int i = 0; i < num2; i++)
		{
			int num3 = BZl.m(i);
			if (!CANFrameModel.IsFrameVisible((byte)num3) || !CANFrameModel.IsFrameEnabled((byte)num3))
			{
				continue;
			}
			int num4 = BZL.m(i);
			if ((num4 & 0x80000000u) == 0L)
			{
				ushort num5 = (ushort)((uint)num4 & 0x7FFu);
				if (BZh.Contains(num5))
				{
					BZI.Add(num5);
				}
				else
				{
					BZh.Add(num5);
				}
			}
			else
			{
				uint num6 = (uint)((ulong)num4 & 0x7FFFFFFFuL);
				if (BZi.Contains(num6))
				{
					BZJ.Add(num6);
				}
				else
				{
					BZi.Add(num6);
				}
			}
		}
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		HashSet<DataIdAndAttrId> val = new HashSet<DataIdAndAttrId>();
		Enumerator<SettingOrSpecialObject> enumerator = m_childSettingsOrSpecialObjects.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SettingOrSpecialObject current = enumerator.Current;
				if (current is Setting)
				{
					if (!(current as Setting).aJ())
					{
						val.Add((current as Setting).C());
					}
					continue;
				}
				Enumerator<SettingOrSpecialObject> enumerator2 = current.a().GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						SettingOrSpecialObject current2 = enumerator2.Current;
						if (current2 is Setting && !(current2 as Setting).aJ())
						{
							val.Add((current2 as Setting).C());
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
			return val;
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		BM.QQ.rl.A(this, aE.hC, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		skipThisTreeNode = true;
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		if (BZK != null && fromFramework.A(BZK.A()) == null)
		{
			node.Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIr();
		}
		else
		{
			skipThisTreeNode = true;
		}
	}

	private List<Setting> A(Framework P_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Setting> val = new List<Setting>();
		Enumerator<DataIdAndAttrId> enumerator = GetIdsContained().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				Setting setting = m_framework.A(current);
				Setting setting2 = P_0.A(current);
				if (setting2 != null && !setting.A(setting2))
				{
					val.Add(setting);
				}
			}
			return val;
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		if (BZK != null)
		{
			Setting setting = importFramework.A(BZK.A());
			if (!bothFrameworksUnlockedOrPasswordsMatch && ((destinationFrameworkLocked && BZK.J()) || (importFrameworkLocked && (setting == null || setting.J()))))
			{
				skipThisTreeNode = true;
				return;
			}
			userAccessibleIdsInDestFramework.Add(BZK.C());
			if (setting != null && A(importFramework).Count != 0)
			{
				treeNodesWithDifferences.Add(node);
			}
		}
		else
		{
			skipThisTreeNode = true;
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		if (BZK != null)
		{
			if (!bothFrameworksUnlockedOrPasswordsMatch && importFrameworkLocked && BZK.J())
			{
				skipThisTreeNode = true;
				return;
			}
			userAccessibleIdsInImportFramework.Add(BZK.C());
			if (!userAccessibleIdsInDestFramework.Contains(BZK.C()))
			{
				equivalentNodeExistsInDestMap = false;
			}
		}
		else
		{
			skipThisTreeNode = true;
		}
	}

	public bool NodeShouldBeOrange(TreeNode node, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework)
	{
		return false;
	}

	public void ImportFromAnotherFramework(Framework importFramework, bool markForWrite)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<DataIdAndAttrId> enumerator = GetIdsContained().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				Setting setting = m_framework.A(current);
				if (setting != null && !setting.D())
				{
					setting.A(importFramework, markForWrite);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	static DN()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		Dictionary<A, ValueTuple<string, string, string>> obj = new Dictionary<A, ValueTuple<string, string, string>>();
		obj.Add(DN.A.bbH, new ValueTuple<string, string, string>(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIS(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIs(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMf()));
		obj.Add(DN.A.bbh, new ValueTuple<string, string, string>(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIT(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIt(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMG()));
		obj.Add(DN.A.bbI, new ValueTuple<string, string, string>(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIU(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIu(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMg()));
		BZH = obj;
	}
}
internal class Dn : Setting
{
	internal Dn(Framework P_0, string P_1, int P_2, int P_3, SettingOrSpecialObject P_4, string P_5)
		: base(P_0, false, P_1, P_2, P_3, P_4, P_5)
	{
	}

	internal new void A()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		MenuNode menuNode = MenuNode.A(m_framework.awj, m_dataIdAndAttrId);
		if (menuNode == null)
		{
			return;
		}
		MenuNode menuNode2 = menuNode.A(this);
		if (menuNode2 == null)
		{
			return;
		}
		Cn bcF = menuNode2.Y().BcF;
		List<Setting> val = new List<Setting>();
		PortFunction.A(this, val, true);
		Enumerator<Setting> enumerator = val.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Setting current = enumerator.Current;
				int[] array = bcF.a(current);
				if (array != null)
				{
					current.A(array, true);
					BM.b(current.A());
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		List<Table> val2 = new List<Table>();
		PortFunction.A(this, val2, true);
		Enumerator<Table> enumerator2 = val2.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				Enumerator<DataIdAndAttrId> enumerator3 = enumerator2.Current.GetIdsContained().GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						DataIdAndAttrId current2 = enumerator3.Current;
						Setting setting = m_framework.A(current2);
						if (setting != null)
						{
							int[] array2 = bcF.a(setting);
							if (array2 != null)
							{
								setting.A(array2, true);
								BM.b(setting.A());
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator3).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
	}

	internal new void A(ref bool P_0)
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = m_currentEnableOn;
		bool flag2 = m_currentEnableOn;
		int num = 0;
		int bbC = ((SettingOrSpecialObject)this).F().BbC;
		if (bbC != 0)
		{
			Setting setting = m_framework.A(bbC);
			if (setting != null)
			{
				flag = ((SettingOrSpecialObject)setting).l() && setting.ax() == 1;
				flag2 = flag;
				num = ((SettingOrSpecialObject)setting).C();
			}
		}
		else if (m_parentSettingOrSpecialObject != null && m_parentSettingOrSpecialObject is SpecialObject)
		{
			for (int i = 0; i < m_parentSettingOrSpecialObject.a().Count; i++)
			{
				if (m_parentSettingOrSpecialObject.a()[i] is Setting setting2 && setting2.T())
				{
					flag = setting2.ax() == 1;
					flag2 = flag;
					num = m_parentObjectId;
					break;
				}
			}
		}
		if (num != 0 && m_framework.aWy.ContainsKey(num))
		{
			SettingOrSpecialObject settingOrSpecialObject = m_framework.a(m_framework.aWy[num]);
			if (settingOrSpecialObject != null)
			{
				for (int j = 0; j < settingOrSpecialObject.a().Count; j++)
				{
					if (settingOrSpecialObject.a()[j] is Setting setting3 && setting3.T())
					{
						flag = setting3.ax() == 1;
						break;
					}
				}
			}
		}
		string text = ((SettingOrSpecialObject)this).A(bz.aYv);
		if (string.IsNullOrEmpty(text))
		{
			text = ((SettingOrSpecialObject)this).A(bz.aYu);
		}
		string text2 = (string.IsNullOrEmpty(text) ? ((SettingOrSpecialObject)this).A(bz.aYt) : text);
		uint num2 = (uint)ax();
		if (m_currentEnableOn && flag && flag2)
		{
			if (num2 == 0)
			{
				if (m_currentlyIsLegal)
				{
					P_0 = true;
					m_currentlyIsLegal = false;
				}
				m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIV() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIv());
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				m_currentIllegalityCanHighlightNode = true;
				return;
			}
			Cg cg = PortFunction.A(num2);
			CH cH = PortFunction.a(num2);
			byte b = PortFunction.B(num2);
			ushort num3 = PortFunction.b(num2);
			bool flag3 = false;
			if (A(cg, cH, b, num3, ref flag3))
			{
				if (m_currentlyIsLegal)
				{
					P_0 = true;
					m_currentlyIsLegal = false;
				}
				if (flag3)
				{
					m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIV() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIW());
				}
				else
				{
					m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIV() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIw());
				}
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				m_currentIllegalityCanHighlightNode = true;
				return;
			}
			bool flag4 = false;
			Enumerator<SettingOrSpecialObject> enumerator = ((SettingOrSpecialObject)this).a().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					SettingOrSpecialObject current = enumerator.Current;
					if (current is FilterOption)
					{
						FilterOption filterOption = current as FilterOption;
						if (filterOption.a() && filterOption.A())
						{
							flag4 = true;
							break;
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (!A(text2, flag4, cg, cH, b, num3, ref P_0))
			{
				SettingOrSpecialObject settingOrSpecialObject2 = PortFunction.A(m_framework, cg, cH, b, num3);
				if (settingOrSpecialObject2 != null)
				{
					A(settingOrSpecialObject2, ref P_0);
				}
			}
		}
		else if (flag)
		{
			if (num2 != 0)
			{
				if (m_currentlyIsLegal)
				{
					P_0 = true;
					m_currentlyIsLegal = false;
				}
				m_currentIllegalityTexts.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIV() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIX());
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				m_currentIllegalityCanHighlightNode = true;
			}
			else
			{
				if (!m_currentlyIsLegal)
				{
					P_0 = true;
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
				P_0 = true;
				m_currentlyIsLegal = true;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.None;
			m_currentIllegalityCanHighlightNode = false;
		}
	}

	private bool A(string P_0, bool P_1, Cg P_2, CH P_3, byte P_4, ushort P_5, ref bool P_6)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (!P_1)
		{
			List<WiringPin> val = WiringPin.A(m_framework, P_2, P_3, P_4, P_5);
			int num = 0;
			do
			{
				Dn dn = m_framework.awd[num];
				if (dn != this && ((SettingOrSpecialObject)dn).l())
				{
					bool flag2 = true;
					int bbC = ((SettingOrSpecialObject)dn).F().BbC;
					if (bbC != 0)
					{
						Setting setting = m_framework.A(bbC);
						if (setting != null)
						{
							flag2 = setting.ax() == 1;
						}
					}
					if (flag2)
					{
						uint num2 = (uint)dn.ax();
						if (num2 != 0)
						{
							Cg cg = PortFunction.A(num2);
							CH cH = PortFunction.a(num2);
							byte b = PortFunction.B(num2);
							ushort num3 = PortFunction.b(num2);
							Enumerator<WiringPin> enumerator = WiringPin.A(m_framework, cg, cH, b, num3).GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									WiringPin current = enumerator.Current;
									if (!val.Contains(current))
									{
										continue;
									}
									flag = true;
									string text = ((SettingOrSpecialObject)dn).A(bz.aYv);
									if (text == null || text.Length == 0)
									{
										text = ((SettingOrSpecialObject)dn).A(bz.aYu);
									}
									string text2 = ((text == null || text.Length == 0) ? ((SettingOrSpecialObject)dn).A(bz.aYt) : text);
									string text3 = string.Empty;
									if (((SettingOrSpecialObject)dn).C() != -1)
									{
										SettingOrSpecialObject settingOrSpecialObject = m_framework.a(((SettingOrSpecialObject)dn).C());
										if (settingOrSpecialObject != null)
										{
											string text4 = settingOrSpecialObject.A(bz.aYt);
											if (string.IsNullOrEmpty(text4))
											{
												text4 = settingOrSpecialObject.A(bz.aYu);
											}
											if (string.IsNullOrEmpty(text4))
											{
												text4 = settingOrSpecialObject.A(bz.aYT);
											}
											string text5 = settingOrSpecialObject.H();
											if (!string.IsNullOrWhiteSpace(text5))
											{
												text4 = text5 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
											}
											text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIx() + text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu();
										}
									}
									if (m_currentlyIsLegal)
									{
										P_6 = true;
										m_currentlyIsLegal = false;
									}
									m_currentIllegalityTexts.Add(string.Concat(new string[6]
									{
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIV(),
										P_0,
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIY(),
										text2,
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu(),
										text3
									}));
									m_currentSeverityLevel = IllegalitySeverityLevel.Error;
									m_currentIllegalityCanHighlightNode = true;
									break;
								}
							}
							finally
							{
								((System.IDisposable)enumerator).Dispose();
							}
						}
					}
				}
				num++;
			}
			while (!flag && num < m_framework.awd.Count);
			if (!flag)
			{
				string text6 = PortFunction.B(m_framework, P_2, P_3, P_4, P_5);
				if (text6 != null)
				{
					flag = true;
					if (m_currentlyIsLegal)
					{
						P_6 = true;
						m_currentlyIsLegal = false;
					}
					m_currentIllegalityTexts.Add(string.Concat(new string[5]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIV(),
						P_0,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIY(),
						text6,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()
					}));
					m_currentSeverityLevel = IllegalitySeverityLevel.Error;
					m_currentIllegalityCanHighlightNode = true;
				}
			}
		}
		if (!flag)
		{
			if (!m_currentlyIsLegal)
			{
				P_6 = true;
				m_currentlyIsLegal = true;
			}
			m_currentSeverityLevel = IllegalitySeverityLevel.None;
			m_currentIllegalityCanHighlightNode = false;
		}
		return flag;
	}

	private void A(SettingOrSpecialObject P_0, ref bool P_1)
	{
		List<int> val = new List<int>();
		for (int i = 0; i < P_0.F().b().Count; i++)
		{
			Setting setting = P_0.F().b()[i];
			if (!((SettingOrSpecialObject)setting).l() || !PortFunction.A(setting))
			{
				continue;
			}
			int num = setting.ax();
			if (m_framework.awg.ContainsKey(num) && !val.Contains(num))
			{
				val.Add(num);
				if (m_currentlyIsLegal)
				{
					P_1 = true;
					m_currentlyIsLegal = false;
				}
				m_currentIllegalityTexts.Add(m_framework.awg[num]);
				m_currentSeverityLevel = IllegalitySeverityLevel.Error;
				m_currentIllegalityCanHighlightNode = true;
			}
		}
	}

	private bool A(Cg P_0, CH P_1, byte P_2, ushort P_3, ref bool P_4)
	{
		P_4 = true;
		bool flag = false;
		for (int i = 0; i < m_framework.awD.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = m_framework.awD[i];
			Cg bSQ = settingOrSpecialObject.F().E().BSQ;
			CH bSq = settingOrSpecialObject.F().E().BSq;
			byte bSR = settingOrSpecialObject.F().E().BSR;
			ushort bSr = settingOrSpecialObject.F().E().BSr;
			if (bSQ == Cg.BAM)
			{
				if (bSQ == P_0 && bSq == P_1 && bSr == P_3)
				{
					P_4 = false;
					if (!settingOrSpecialObject.l())
					{
						flag = true;
					}
					break;
				}
			}
			else if (bSQ == P_0 && bSq == P_1 && bSR == P_2)
			{
				P_4 = false;
				if (!settingOrSpecialObject.l())
				{
					flag = true;
				}
				break;
			}
		}
		return flag | P_4;
	}
}
