using System.Collections.Generic;
using System.Windows.Forms;
using ns2;
using ns4;
using ns6;

namespace NSP.SettingsFramework;

public class WiFiSetup : SpecialObject, Interface4
{
	internal const int bAx = 2;

	public WiFiSetup(Framework framework, string name, SettingOrSpecialObject parentSettingOrSpecialObject, string parentModuleName)
		: base(framework, name, parentSettingOrSpecialObject, parentModuleName)
	{
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		return new HashSet<DataIdAndAttrId>
		{
			new DataIdAndAttrId(10195)
		};
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		Form23.form23_0.control25_0.method_28(this, Enum38.const_16, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		Setting setting = m_framework.method_31(10195);
		node.Checked = setting.method_96();
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		m_framework.method_31(10195).method_97(node.Checked);
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		skipThisTreeNode = true;
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		Setting setting = m_framework.method_31(10195);
		Setting setting2 = importFramework.method_31(setting.method_64());
		if (!bothFrameworksUnlockedOrPasswordsMatch && ((destinationFrameworkLocked && setting.method_96()) || (importFrameworkLocked && (setting2 == null || setting2.method_96()))))
		{
			skipThisTreeNode = true;
			return;
		}
		userAccessibleIdsInDestFramework.Add(setting.method_69());
		if (setting2 != null && !setting.method_282(setting2))
		{
			treeNodesWithDifferences.Add(node);
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		Setting setting = m_framework.method_31(10195);
		if (!bothFrameworksUnlockedOrPasswordsMatch && importFrameworkLocked && setting.method_96())
		{
			skipThisTreeNode = true;
			return;
		}
		userAccessibleIdsInImportFramework.Add(setting.method_69());
		if (!userAccessibleIdsInDestFramework.Contains(setting.method_69()))
		{
			equivalentNodeExistsInDestMap = false;
		}
	}

	public bool NodeShouldBeOrange(TreeNode node, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework)
	{
		return !userAccessibleIdsInImportFramework.Contains(new DataIdAndAttrId(10195));
	}

	public void ImportFromAnotherFramework(Framework importFramework, bool markForWrite)
	{
		m_framework.method_31(10195).method_113(importFramework, markForWrite);
	}
}
