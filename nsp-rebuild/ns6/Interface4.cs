using System.Collections.Generic;
using System.Windows.Forms;
using NSP.SettingsFramework;

namespace ns6;

internal interface Interface4
{
	HashSet<DataIdAndAttrId> GetIdsContained();

	HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs();

	void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch);

	void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode);

	void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode);

	void UpdateSettingsIncludedInPasswordProtection(TreeNode node);

	void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll);

	void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap);

	bool NodeShouldBeOrange(TreeNode node, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework);

	void ImportFromAnotherFramework(Framework importFramework, bool markForWrite);
}
