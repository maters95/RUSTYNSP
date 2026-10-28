using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ns2;
using ns4;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class UIListObject : Interface4
{
	private List<UIListSettingDataIdAndIndent> Bsd = new List<UIListSettingDataIdAndIndent>();

	private List<UIListSettingDataIdAndIndent> BsE = new List<UIListSettingDataIdAndIndent>();

	private Dictionary<int, List<UIListSettingDataIdAndIndent>> Bse = new Dictionary<int, List<UIListSettingDataIdAndIndent>>();

	private int BsF;

	private int Bsf;

	private bool BsG;

	private SpecialObject Bsg;

	private Framework BsH;

	public List<UIListSettingDataIdAndIndent> CurrentUIListSettingsIdsAndIndents
	{
		get
		{
			return Bsd;
		}
		set
		{
			Bsd = value;
		}
	}

	public List<UIListSettingDataIdAndIndent> DefaultUIListSettingsIdsAndIndents
	{
		get
		{
			return BsE;
		}
		set
		{
			BsE = value;
		}
	}

	public Dictionary<int, List<UIListSettingDataIdAndIndent>> ExtraUIListSettingsIdsAndIndentsPerCondProps
	{
		get
		{
			return Bse;
		}
		set
		{
			Bse = value;
		}
	}

	public int RowObjectId
	{
		get
		{
			return BsF;
		}
		set
		{
			BsF = value;
		}
	}

	public int RowIncludeSetting
	{
		get
		{
			return Bsf;
		}
		set
		{
			Bsf = value;
		}
	}

	public bool ShowCalibrateAllButton
	{
		get
		{
			return BsG;
		}
		set
		{
			BsG = value;
		}
	}

	public UIListObject(Framework framework, SpecialObject ownerObject)
	{
		BsH = framework;
		Bsg = ownerObject;
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		HashSet<DataIdAndAttrId> hashSet = new HashSet<DataIdAndAttrId>();
		for (int i = 0; i < Bsd.Count; i++)
		{
			int dataId = Bsd[i].DataId;
			Setting setting = BsH.method_31(dataId);
			if (setting == null || !setting.method_207() || setting.method_204())
			{
				hashSet.Add(new DataIdAndAttrId(dataId));
			}
		}
		return hashSet;
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		HashSet<DataIdAndAttrId> hashSet = new HashSet<DataIdAndAttrId>();
		for (int i = 0; i < Bsd.Count; i++)
		{
			int dataId = Bsd[i].DataId;
			if (!BsH.awX.ContainsKey(dataId))
			{
				Setting setting = BsH.method_31(dataId);
				if (setting == null || !setting.method_207() || setting.method_204())
				{
					hashSet.Add(new DataIdAndAttrId(dataId));
				}
			}
		}
		return hashSet;
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		Form23.form23_0.control25_0.method_28(Bsg, Enum38.const_7, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		bool flag = true;
		foreach (UIListSettingDataIdAndIndent item in Bsd)
		{
			Setting setting = BsH.method_31(item.DataId);
			if (setting != null && !setting.method_219() && !setting.method_212() && !setting.method_220() && (setting.method_204() || !setting.method_207()) && !BsH.awX.ContainsKey(item.DataId))
			{
				TreeNode treeNode = new TreeNode(setting.method_22(bool_0: true));
				treeNode.Checked = setting.method_96();
				treeNode.ForeColor = Form23.color_12;
				treeNode.Tag = setting;
				node.Nodes.Add(treeNode);
				flag = false;
			}
		}
		if (flag)
		{
			skipThisTreeNode = true;
		}
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		foreach (UIListSettingDataIdAndIndent item in Bsd)
		{
			Setting setting = BsH.method_31(item.DataId);
			if (setting == null || setting.method_219() || setting.method_212() || setting.method_220() || (!setting.method_204() && setting.method_207()) || BsH.awX.ContainsKey(setting.method_64()))
			{
				continue;
			}
			Setting setting2 = fromFramework.method_31(setting.method_64());
			if (setting2 == null)
			{
				TreeNode treeNode = new TreeNode(setting.method_22(bool_0: true));
				treeNode.ForeColor = node.ForeColor;
				treeNode.Tag = Class333.smethod_1138();
				node.Nodes.Add(treeNode);
			}
			else
			{
				if (setting.method_207() || setting.method_154())
				{
					continue;
				}
				List<Setting.ListItems.Struct45> list = setting.method_102();
				for (int i = 0; i < list.Count; i++)
				{
					bool flag = false;
					List<Setting.ListItems.Struct45> list2 = setting2.method_102();
					for (int j = 0; j < list2.Count; j++)
					{
						if (list2[j].bBv == list[i].bBv || list2[j].bBV.Equals(list[i].bBV))
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						TreeNode treeNode2 = new TreeNode(setting.method_22(bool_0: true));
						treeNode2.ForeColor = node.ForeColor;
						treeNode2.Tag = Class333.smethod_1135() + list[i].bBV + Class333.smethod_1136();
						node.Nodes.Add(treeNode2);
					}
				}
			}
		}
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		bool flag = true;
		foreach (UIListSettingDataIdAndIndent item in Bsd)
		{
			Setting setting = BsH.method_31(item.DataId);
			if (setting == null || setting.method_72() || setting.method_219() || setting.method_220() || (!setting.method_204() && setting.method_207()) || BsH.awX.ContainsKey(setting.method_64()))
			{
				continue;
			}
			Setting setting2 = importFramework.method_31(setting.method_64());
			if ((bothFrameworksUnlockedOrPasswordsMatch || ((!destinationFrameworkLocked || !setting.method_96()) && (!importFrameworkLocked || (setting2 != null && !setting2.method_96())))) && !idsAlreadyHandled.Contains(setting.method_69()))
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
				userAccessibleIdsInDestFramework.Add(setting.method_69());
				idsAlreadyHandled.Add(setting.method_69());
				if (setting2 != null && !setting2.method_72() && !setting2.method_219() && !setting2.method_220() && !setting.method_282(setting2))
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
		foreach (UIListSettingDataIdAndIndent item in Bsd)
		{
			Setting setting = BsH.method_31(item.DataId);
			if (setting != null && !setting.method_72() && !setting.method_219() && !setting.method_220() && (setting.method_204() || !setting.method_207()) && !BsH.awX.ContainsKey(setting.method_64()) && (bothFrameworksUnlockedOrPasswordsMatch || !importFrameworkLocked || !setting.method_96()) && !idsAlreadyHandled.Contains(setting.method_69()))
			{
				userAccessibleIdsInImportFramework.Add(setting.method_69());
				if (!userAccessibleIdsInDestFramework.Contains(setting.method_69()))
				{
					TreeNode treeNode = new TreeNode(setting.method_22(bool_0: true));
					treeNode.ForeColor = Form23.color_12;
					treeNode.Tag = setting;
					node.Nodes.Add(treeNode);
					flag = false;
					idsAlreadyHandled.Add(setting.method_69());
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
