using System.Collections.Generic;
using System.Windows.Forms;
using ns2;
using ns4;
using ns6;

namespace NSP.SettingsFramework;

public class ChannelsProperties : SpecialObject, Interface4
{
	public ChannelsProperties(Framework framework, string name, SettingOrSpecialObject parentSettingOrSpecialObject, string parentModuleName)
		: base(framework, name, parentSettingOrSpecialObject, parentModuleName)
	{
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		HashSet<DataIdAndAttrId> hashSet = new HashSet<DataIdAndAttrId>();
		foreach (Setting item in m_framework.aWt)
		{
			foreach (SettingOrSpecialObject item2 in item.method_1())
			{
				if (item2 is Setting setting && setting.method_68())
				{
					hashSet.Add(setting.method_69());
				}
			}
		}
		return hashSet;
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		Form23.form23_0.control25_0.method_28(null, Enum38.const_4, null, selectedMenuNode, fromScratch);
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
		skipThisTreeNode = true;
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			Setting setting = m_framework.method_32(item);
			if (setting != null)
			{
				userAccessibleIdsInDestFramework.Add(item);
			}
			Setting setting2 = importFramework.method_32(item);
			if (setting2 != null && !setting.method_282(setting2))
			{
				treeNodesWithDifferences.Add(node);
			}
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			userAccessibleIdsInImportFramework.Add(item);
			if (equivalentNodeExistsInDestMap && !userAccessibleIdsInDestFramework.Contains(item))
			{
				equivalentNodeExistsInDestMap = false;
			}
		}
	}

	public bool NodeShouldBeOrange(TreeNode node, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework)
	{
		return false;
	}

	public void ImportFromAnotherFramework(Framework importFramework, bool markForWrite)
	{
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			Setting setting = m_framework.method_32(item);
			if (setting != null && !setting.method_72())
			{
				setting.method_113(importFramework, markForWrite);
			}
		}
	}
}
