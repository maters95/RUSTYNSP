using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ns2;
using ns4;
using ns6;

namespace NSP.SettingsFramework;

public class ApplyAndExecuteProcess : Interface4
{
	private int Brp;

	private string BrQ;

	private string Brq;

	private string BrR;

	private int Brr;

	private bool BrS;

	private List<int> Brs = new List<int>();

	private int BrT = -1;

	private int Brt = -1;

	private SpecialObject BrU;

	private Framework Bru;

	public SpecialObject OwnerObject => BrU;

	public int StatusChannelDataId
	{
		get
		{
			return Brp;
		}
		set
		{
			Brp = value;
		}
	}

	public string ConfirmationText
	{
		get
		{
			return BrQ;
		}
		set
		{
			BrQ = value;
		}
	}

	public string IdleText
	{
		get
		{
			return Brq;
		}
		set
		{
			Brq = value;
		}
	}

	public string ActiveText
	{
		get
		{
			return BrR;
		}
		set
		{
			BrR = value;
		}
	}

	public int ProcessId
	{
		get
		{
			return Brr;
		}
		set
		{
			Brr = value;
		}
	}

	public List<int> PreApplySettingDataIds => Brs;

	public int InjectorStageIndex
	{
		get
		{
			return BrT;
		}
		set
		{
			BrT = value;
		}
	}

	public int InjectorOutputWithinStage
	{
		get
		{
			return Brt;
		}
		set
		{
			Brt = value;
		}
	}

	public bool HoldToExecuteOutputTest
	{
		get
		{
			return BrS;
		}
		set
		{
			BrS = value;
		}
	}

	public ApplyAndExecuteProcess(Framework framework, SpecialObject ownerObject)
	{
		Bru = framework;
		BrU = ownerObject;
	}

	public void AddPreApplySettingDataId(int dataId)
	{
		Brs.Add(dataId);
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		HashSet<DataIdAndAttrId> hashSet = new HashSet<DataIdAndAttrId>();
		foreach (int br in Brs)
		{
			hashSet.Add(new DataIdAndAttrId(br));
		}
		return hashSet;
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		Form23.form23_0.control25_0.method_28(BrU, Enum38.const_12, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		if (Brs.Count != 0)
		{
			Setting setting = Bru.method_32(new DataIdAndAttrId(Brs[0]));
			node.Checked = setting.method_96();
		}
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			Bru.method_32(item).method_97(node.Checked);
		}
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		skipThisTreeNode = true;
	}

	private List<Setting> method_0(Framework framework_0)
	{
		List<Setting> list = new List<Setting>();
		foreach (int br in Brs)
		{
			Setting setting = Bru.method_31(br);
			Setting setting2 = framework_0.method_31(br);
			if (setting2 != null && !setting.method_282(setting2))
			{
				list.Add(setting);
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
			Setting setting = Bru.method_32(item);
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
			Setting setting = Bru.method_32(item);
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
