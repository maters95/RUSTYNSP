using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using C;
using a;

namespace NSP.SettingsFramework;

public class OnOffSwitchingPoint : SpecialObject, CG
{
	private int BzE;

	private int Bze;

	private Setting BzF;

	private Setting Bzf;

	private Setting BzG;

	private Setting Bzg;

	private Setting BzH;

	private Setting Bzh;

	private Setting BzI;

	public int RowChannelDataId
	{
		get
		{
			return BzE;
		}
		set
		{
			BzE = value;
		}
	}

	public int ColumnChannelDataId
	{
		get
		{
			return Bze;
		}
		set
		{
			Bze = value;
		}
	}

	public Setting UpperBoundsEnablerSetting => BzF;

	public Setting Point1ColumnValueSetting => Bzf;

	public Setting Point1RowLowerBoundSetting => BzG;

	public Setting Point1RowUpperBoundSetting => Bzg;

	public Setting Point2ColumnValueSetting => BzH;

	public Setting Point2RowLowerBoundSetting => Bzh;

	public Setting Point2RowUpperBoundSetting => BzI;

	public OnOffSwitchingPoint(Framework framework, string name, SettingOrSpecialObject parentSettingOrSpecialObject, string parentModuleName)
		: base(framework, name, parentSettingOrSpecialObject, parentModuleName)
	{
	}

	public void FindComponents()
	{
		BzF = null;
		Bzf = null;
		BzG = null;
		Bzg = null;
		BzH = null;
		Bzh = null;
		BzI = null;
		for (int i = 0; i < ((SettingOrSpecialObject)this).a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)this).a()[i];
			if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bib())
			{
				BzF = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiC())
			{
				for (int j = 0; j < settingOrSpecialObject.a().Count; j++)
				{
					SettingOrSpecialObject settingOrSpecialObject2 = settingOrSpecialObject.a()[j];
					if (settingOrSpecialObject2.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bic())
					{
						Bzf = settingOrSpecialObject2 as Setting;
					}
					else if (settingOrSpecialObject2.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiD())
					{
						BzG = settingOrSpecialObject2 as Setting;
					}
					else if (settingOrSpecialObject2.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bid())
					{
						Bzg = settingOrSpecialObject2 as Setting;
					}
				}
			}
			else if (settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiE())
			{
				for (int k = 0; k < settingOrSpecialObject.a().Count; k++)
				{
					SettingOrSpecialObject settingOrSpecialObject3 = settingOrSpecialObject.a()[k];
					if (settingOrSpecialObject3.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bic())
					{
						BzH = settingOrSpecialObject3 as Setting;
					}
					else if (settingOrSpecialObject3.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiD())
					{
						Bzh = settingOrSpecialObject3 as Setting;
					}
					else if (settingOrSpecialObject3.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bid())
					{
						BzI = settingOrSpecialObject3 as Setting;
					}
				}
			}
			if (BzF != null && Bzf != null && BzG != null && Bzg != null && BzH != null && Bzh != null && BzI != null)
			{
				break;
			}
		}
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		HashSet<DataIdAndAttrId> obj = new HashSet<DataIdAndAttrId>();
		obj.Add(new DataIdAndAttrId(BzF.A()));
		obj.Add(new DataIdAndAttrId(Bzf.A()));
		obj.Add(new DataIdAndAttrId(BzH.A()));
		obj.Add(new DataIdAndAttrId(Bzg.A()));
		obj.Add(new DataIdAndAttrId(BzI.A()));
		obj.Add(new DataIdAndAttrId(BzG.A()));
		obj.Add(new DataIdAndAttrId(Bzh.A()));
		return obj;
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		BM.QQ.rl.A(this, aE.hA, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		Setting setting = m_framework.A(new DataIdAndAttrId(BzF.A()));
		node.Checked = setting.J();
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<DataIdAndAttrId> enumerator = GetIdsContained().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				m_framework.A(current).c(node.Checked);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<DataIdAndAttrId> enumerator = GetIdsContained().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				if (fromFramework.A(current) == null)
				{
					TreeNode val = new TreeNode(((SettingOrSpecialObject)m_framework.A(current)).A(true));
					val.ForeColor = node.ForeColor;
					val.Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kw();
					node.Nodes.Add(val);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private List<Setting> A(Framework P_0)
	{
		List<Setting> val = new List<Setting>();
		Setting setting = P_0.A(BzF.A());
		if (setting != null && !BzF.A(setting))
		{
			val.Add(BzF);
		}
		Setting setting2 = P_0.A(Bzf.A());
		if (setting2 != null && !Bzf.A(setting2))
		{
			val.Add(Bzf);
		}
		Setting setting3 = P_0.A(BzH.A());
		if (setting3 != null && !BzH.A(setting3))
		{
			val.Add(BzH);
		}
		Setting setting4 = P_0.A(Bzg.A());
		if (setting4 != null && !Bzg.A(setting4))
		{
			val.Add(Bzg);
		}
		Setting setting5 = P_0.A(BzI.A());
		if (setting5 != null && !BzI.A(setting5))
		{
			val.Add(BzI);
		}
		Setting setting6 = P_0.A(BzG.A());
		if (setting6 != null && !BzG.A(setting6))
		{
			val.Add(BzG);
		}
		Setting setting7 = P_0.A(Bzh.A());
		if (setting7 != null && !Bzh.A(setting7))
		{
			val.Add(Bzh);
		}
		return val;
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		List<Setting> val = A(importFramework);
		bool flag = true;
		Enumerator<DataIdAndAttrId> enumerator = GetIdsContained().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				Setting setting = m_framework.A(current);
				Setting setting2 = importFramework.A(setting.A());
				if (bothFrameworksUnlockedOrPasswordsMatch || ((!destinationFrameworkLocked || !setting.J()) && (!importFrameworkLocked || (setting2 != null && !setting2.J()))))
				{
					TreeNode val2 = new TreeNode(((SettingOrSpecialObject)setting).A(true));
					if (forceTickAll)
					{
						val2.Checked = true;
					}
					val2.ForeColor = Color.Gray;
					val2.Tag = setting;
					node.Nodes.Add(val2);
					flag = false;
					userAccessibleIdsInDestFramework.Add(current);
					if (val.Contains(setting))
					{
						treeNodesWithDifferences.Add(val2);
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (flag)
		{
			skipThisTreeNode = true;
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		Enumerator<DataIdAndAttrId> enumerator = GetIdsContained().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				Setting setting = m_framework.A(current);
				if (bothFrameworksUnlockedOrPasswordsMatch || !importFrameworkLocked || !setting.J())
				{
					userAccessibleIdsInImportFramework.Add(current);
					if (!userAccessibleIdsInDestFramework.Contains(current))
					{
						TreeNode val = new TreeNode(((SettingOrSpecialObject)setting).A(true));
						val.ForeColor = BM.te;
						val.Tag = setting;
						node.Nodes.Add(val);
						flag = false;
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (flag)
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
	}
}
