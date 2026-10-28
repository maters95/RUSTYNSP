using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ns2;
using ns4;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class OnOffSwitchingPoint : SpecialObject, Interface4
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
		for (int i = 0; i < method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = method_1()[i];
			if (settingOrSpecialObject.method_2() == Class333.Bib())
			{
				BzF = settingOrSpecialObject as Setting;
			}
			else if (settingOrSpecialObject.method_2() == Class333.BiC())
			{
				for (int j = 0; j < settingOrSpecialObject.method_1().Count; j++)
				{
					SettingOrSpecialObject settingOrSpecialObject2 = settingOrSpecialObject.method_1()[j];
					if (settingOrSpecialObject2.method_2() == Class333.Bic())
					{
						Bzf = settingOrSpecialObject2 as Setting;
					}
					else if (settingOrSpecialObject2.method_2() == Class333.BiD())
					{
						BzG = settingOrSpecialObject2 as Setting;
					}
					else if (settingOrSpecialObject2.method_2() == Class333.Bid())
					{
						Bzg = settingOrSpecialObject2 as Setting;
					}
				}
			}
			else if (settingOrSpecialObject.method_2() == Class333.BiE())
			{
				for (int k = 0; k < settingOrSpecialObject.method_1().Count; k++)
				{
					SettingOrSpecialObject settingOrSpecialObject3 = settingOrSpecialObject.method_1()[k];
					if (settingOrSpecialObject3.method_2() == Class333.Bic())
					{
						BzH = settingOrSpecialObject3 as Setting;
					}
					else if (settingOrSpecialObject3.method_2() == Class333.BiD())
					{
						Bzh = settingOrSpecialObject3 as Setting;
					}
					else if (settingOrSpecialObject3.method_2() == Class333.Bid())
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
		return new HashSet<DataIdAndAttrId>
		{
			new DataIdAndAttrId(BzF.method_64()),
			new DataIdAndAttrId(Bzf.method_64()),
			new DataIdAndAttrId(BzH.method_64()),
			new DataIdAndAttrId(Bzg.method_64()),
			new DataIdAndAttrId(BzI.method_64()),
			new DataIdAndAttrId(BzG.method_64()),
			new DataIdAndAttrId(Bzh.method_64())
		};
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		Form23.form23_0.control25_0.method_28(this, Enum38.const_13, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		Setting setting = m_framework.method_32(new DataIdAndAttrId(BzF.method_64()));
		node.Checked = setting.method_96();
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			m_framework.method_32(item).method_97(node.Checked);
		}
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			if (fromFramework.method_32(item) == null)
			{
				TreeNode treeNode = new TreeNode(m_framework.method_32(item).method_22(bool_0: true));
				treeNode.ForeColor = node.ForeColor;
				treeNode.Tag = Class333.smethod_1138();
				node.Nodes.Add(treeNode);
			}
		}
	}

	private List<Setting> method_71(Framework framework_0)
	{
		List<Setting> list = new List<Setting>();
		Setting setting = framework_0.method_31(BzF.method_64());
		if (setting != null && !BzF.method_282(setting))
		{
			list.Add(BzF);
		}
		Setting setting2 = framework_0.method_31(Bzf.method_64());
		if (setting2 != null && !Bzf.method_282(setting2))
		{
			list.Add(Bzf);
		}
		Setting setting3 = framework_0.method_31(BzH.method_64());
		if (setting3 != null && !BzH.method_282(setting3))
		{
			list.Add(BzH);
		}
		Setting setting4 = framework_0.method_31(Bzg.method_64());
		if (setting4 != null && !Bzg.method_282(setting4))
		{
			list.Add(Bzg);
		}
		Setting setting5 = framework_0.method_31(BzI.method_64());
		if (setting5 != null && !BzI.method_282(setting5))
		{
			list.Add(BzI);
		}
		Setting setting6 = framework_0.method_31(BzG.method_64());
		if (setting6 != null && !BzG.method_282(setting6))
		{
			list.Add(BzG);
		}
		Setting setting7 = framework_0.method_31(Bzh.method_64());
		if (setting7 != null && !Bzh.method_282(setting7))
		{
			list.Add(Bzh);
		}
		return list;
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		List<Setting> list = method_71(importFramework);
		bool flag = true;
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			Setting setting = m_framework.method_32(item);
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
			Setting setting = m_framework.method_32(item);
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
