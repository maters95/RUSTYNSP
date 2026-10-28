using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ns4;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class ConditionalActivator : Interface4
{
	private int BrV;

	private int Brv;

	private string BrW;

	private int Brw;

	private int BrX;

	private SpecialObject Brx;

	private Framework BrY;

	public int EnablerSettingId
	{
		get
		{
			return BrV;
		}
		set
		{
			BrV = value;
		}
	}

	public int ChannelSettingId
	{
		get
		{
			return Brv;
		}
		set
		{
			Brv = value;
		}
	}

	public string JoinText
	{
		get
		{
			return BrW;
		}
		set
		{
			BrW = value;
		}
	}

	public int OperatorSettingId
	{
		get
		{
			return Brw;
		}
		set
		{
			Brw = value;
		}
	}

	public int ThresholdSettingId
	{
		get
		{
			return BrX;
		}
		set
		{
			BrX = value;
		}
	}

	public ConditionalActivator(Framework framework, SpecialObject ownerObject)
	{
		BrY = framework;
		Brx = ownerObject;
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		HashSet<DataIdAndAttrId> hashSet = new HashSet<DataIdAndAttrId>();
		if (BrV != 0)
		{
			hashSet.Add(new DataIdAndAttrId(BrV));
		}
		hashSet.Add(new DataIdAndAttrId(Brv));
		hashSet.Add(new DataIdAndAttrId(Brw));
		hashSet.Add(new DataIdAndAttrId(BrX));
		return hashSet;
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		Setting setting = BrY.method_32(new DataIdAndAttrId(Brv));
		node.Checked = setting.method_96();
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			BrY.method_32(item).method_97(node.Checked);
		}
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			if (fromFramework.method_32(item) == null)
			{
				TreeNode treeNode = new TreeNode(BrY.method_32(item).method_22(bool_0: true));
				treeNode.ForeColor = node.ForeColor;
				treeNode.Tag = Class333.smethod_1138();
				node.Nodes.Add(treeNode);
			}
		}
	}

	private List<Setting> method_0(Framework framework_0)
	{
		List<Setting> list = new List<Setting>();
		if (BrV != 0)
		{
			Setting setting = BrY.method_31(BrV);
			Setting setting2 = framework_0.method_31(BrV);
			if (setting2 != null && !setting.method_282(setting2))
			{
				list.Add(setting);
			}
		}
		Setting setting3 = BrY.method_31(Brv);
		Setting setting4 = BrY.method_31(Brw);
		Setting setting5 = BrY.method_31(BrX);
		Setting setting6 = framework_0.method_31(Brv);
		Setting setting7 = framework_0.method_31(Brw);
		Setting setting8 = framework_0.method_31(BrX);
		if (setting6 != null && setting7 != null && setting8 != null)
		{
			if (!setting3.method_282(setting6))
			{
				list.Add(setting3);
			}
			if (!setting4.method_282(setting7))
			{
				list.Add(setting4);
			}
			if (!setting5.method_282(setting8))
			{
				list.Add(setting5);
			}
		}
		return list;
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		List<Setting> list = method_0(importFramework);
		bool flag = true;
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			Setting setting = BrY.method_32(item);
			Setting setting2 = importFramework.method_31(setting.method_64());
			if (bothFrameworksUnlockedOrPasswordsMatch || ((!destinationFrameworkLocked || !setting.method_96()) && (!importFrameworkLocked || (setting2 != null && !setting2.method_96()))))
			{
				TreeNode treeNode = new TreeNode(setting.method_22(bool_0: true));
				if (forceTickAll)
				{
					treeNode.Checked = true;
				}
				treeNode.ForeColor = Color.Gray;
				treeNode.Tag = setting;
				node.Nodes.Add(treeNode);
				flag = false;
				userAccessibleIdsInDestFramework.Add(item);
				if (list.Contains(setting))
				{
					treeNodesWithDifferences.Add(treeNode);
				}
			}
		}
		if (flag)
		{
			skipThisTreeNode = true;
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		bool flag = true;
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			Setting setting = BrY.method_32(item);
			if (bothFrameworksUnlockedOrPasswordsMatch || !importFrameworkLocked || !setting.method_96())
			{
				userAccessibleIdsInImportFramework.Add(item);
				if (!userAccessibleIdsInDestFramework.Contains(item))
				{
					TreeNode treeNode = new TreeNode(setting.method_22(bool_0: true));
					treeNode.ForeColor = Form23.color_12;
					treeNode.Tag = setting;
					node.Nodes.Add(treeNode);
					flag = false;
				}
			}
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
