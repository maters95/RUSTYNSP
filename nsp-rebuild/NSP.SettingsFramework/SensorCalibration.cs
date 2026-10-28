using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ns2;
using ns4;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class SensorCalibration : Setting, Interface4
{
	private Setting BzP;

	private Setting Bzp;

	private Setting BzQ;

	public Setting CalibrationValuesSetting => BzP;

	public Setting CalibrationVoltagesSetting => Bzp;

	public Setting CalibrationValueCountSetting => BzQ;

	public SensorCalibration(Framework framework, string name, int int_0, int byteAddress, SettingOrSpecialObject parentSettingOrSpecialObject, string parentModuleName)
		: base(framework, bool_0: false, name, int_0, byteAddress, parentSettingOrSpecialObject, parentModuleName)
	{
	}

	public int GetMinCalibrationValue()
	{
		int num = 0;
		if (BzP != null && BzQ != null)
		{
			int num2 = Math.Min(BzQ.method_256(), BzP.method_242()[2]);
			num = int.MaxValue;
			for (int i = 0; i < num2; i++)
			{
				num = Math.Min(num, BzP.method_258(i));
			}
		}
		return num;
	}

	public int GetMaxCalibrationValue()
	{
		int num = 0;
		if (BzP != null && BzQ != null)
		{
			int num2 = Math.Min(BzQ.method_256(), BzP.method_242()[2]);
			num = int.MinValue;
			for (int i = 0; i < num2; i++)
			{
				num = Math.Max(num, BzP.method_258(i));
			}
		}
		return num;
	}

	public void FindComponents()
	{
		BzP = null;
		Bzp = null;
		BzQ = null;
		for (int i = 0; i < method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = method_1()[i];
			if (settingOrSpecialObject is Setting)
			{
				Setting setting = settingOrSpecialObject as Setting;
				if (setting.method_2() == Class333.Bie())
				{
					BzP = setting;
				}
				else if (setting.method_2() == Class333.BiF())
				{
					Bzp = setting;
				}
				else if (setting.method_2() == Class333.Bif())
				{
					BzQ = setting;
				}
			}
			if (BzP != null && Bzp != null && BzQ != null)
			{
				break;
			}
		}
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		HashSet<DataIdAndAttrId> hashSet = new HashSet<DataIdAndAttrId>();
		if (BzP != null)
		{
			hashSet.Add(new DataIdAndAttrId(BzP.method_64()));
		}
		if (Bzp != null)
		{
			hashSet.Add(new DataIdAndAttrId(Bzp.method_64()));
		}
		if (BzQ != null)
		{
			hashSet.Add(new DataIdAndAttrId(BzQ.method_64()));
		}
		return hashSet;
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		Form23.form23_0.control25_0.method_28(this, Enum38.const_8, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		node.Text += Class333.BiG();
		node.Checked = BzP.method_96();
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		BzP.method_97(node.Checked);
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		node.Text += Class333.BiG();
		Setting setting = fromFramework.method_31(BzP.method_64());
		if (setting == null)
		{
			node.Tag = Class333.Big();
			return;
		}
		int num = setting.method_277();
		int num2 = BzP.method_277();
		if (num2 > num)
		{
			node.Tag = Class333.BiH() + num + Class333.smethod_1824() + num2 + Class333.Bih();
		}
		else
		{
			skipThisTreeNode = true;
		}
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		Setting setting = importFramework.method_31(BzP.method_64());
		if (!bothFrameworksUnlockedOrPasswordsMatch && ((destinationFrameworkLocked && BzP.method_96()) || (importFrameworkLocked && (setting == null || setting.method_96()))))
		{
			skipThisTreeNode = true;
			return;
		}
		node.Text += Class333.BiG();
		userAccessibleIdsInDestFramework.Add(BzP.method_69());
		if (setting != null && !BzP.method_282(setting))
		{
			treeNodesWithDifferences.Add(node);
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		if ((!bothFrameworksUnlockedOrPasswordsMatch & importFrameworkLocked) && BzP.method_96())
		{
			skipThisTreeNode = true;
			return;
		}
		node.Text += Class333.BiG();
		userAccessibleIdsInImportFramework.Add(BzP.method_69());
		if (!userAccessibleIdsInDestFramework.Contains(BzP.method_69()))
		{
			equivalentNodeExistsInDestMap = false;
		}
	}

	public bool NodeShouldBeOrange(TreeNode node, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework)
	{
		return !userAccessibleIdsInImportFramework.Contains(BzP.method_69());
	}

	public void ImportFromAnotherFramework(Framework importFramework, bool markForWrite)
	{
		if (BzP != null && Bzp != null && BzQ != null)
		{
			BzQ.method_113(importFramework, markForWrite);
			BzP.method_113(importFramework, markForWrite);
			Bzp.method_113(importFramework, markForWrite);
		}
	}
}
