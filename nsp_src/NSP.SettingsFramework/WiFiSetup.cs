using System.Collections.Generic;
using System.Windows.Forms;
using B;
using C;
using a;

namespace NSP.SettingsFramework;

public class WiFiSetup : SpecialObject, CG
{
	internal const int bAx = 2;

	public WiFiSetup(Framework framework, string name, SettingOrSpecialObject parentSettingOrSpecialObject, string parentModuleName)
		: base(framework, name, parentSettingOrSpecialObject, parentModuleName)
	{
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		HashSet<DataIdAndAttrId> obj = new HashSet<DataIdAndAttrId>();
		obj.Add(new DataIdAndAttrId(10195));
		return obj;
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		BM.QQ.rl.A(this, aE.hb, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		Setting setting = m_framework.A(10195);
		node.Checked = setting.J();
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		m_framework.A(10195).c(node.Checked);
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		skipThisTreeNode = true;
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		Setting setting = m_framework.A(10195);
		Setting setting2 = importFramework.A(setting.A());
		if (bothFrameworksUnlockedOrPasswordsMatch || ((!destinationFrameworkLocked || !setting.J()) && (!importFrameworkLocked || (setting2 != null && !setting2.J()))))
		{
			userAccessibleIdsInDestFramework.Add(setting.C());
			if (setting2 != null && !setting.A(setting2))
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
		Setting setting = m_framework.A(10195);
		if (bothFrameworksUnlockedOrPasswordsMatch || !importFrameworkLocked || !setting.J())
		{
			userAccessibleIdsInImportFramework.Add(setting.C());
			if (!userAccessibleIdsInDestFramework.Contains(setting.C()))
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
		return !userAccessibleIdsInImportFramework.Contains(new DataIdAndAttrId(10195));
	}

	public void ImportFromAnotherFramework(Framework importFramework, bool markForWrite)
	{
		m_framework.A(10195).A(importFramework, markForWrite);
	}
}
