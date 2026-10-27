using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using C;
using a;

namespace NSP.SettingsFramework;

public class SensorCalibration : Setting, CG
{
	private Setting BzP;

	private Setting Bzp;

	private Setting BzQ;

	public Setting CalibrationValuesSetting => BzP;

	public Setting CalibrationVoltagesSetting => Bzp;

	public Setting CalibrationValueCountSetting => BzQ;

	public SensorCalibration(Framework framework, string name, int id, int byteAddress, SettingOrSpecialObject parentSettingOrSpecialObject, string parentModuleName)
		: base(framework, false, name, id, byteAddress, parentSettingOrSpecialObject, parentModuleName)
	{
	}

	public int GetMinCalibrationValue()
	{
		int num = 0;
		if (BzP != null && BzQ != null)
		{
			int num2 = Math.Min(BzQ.ax(), BzP.av()[2]);
			num = 2147483647;
			for (int i = 0; i < num2; i++)
			{
				num = Math.Min(num, BzP.m(i));
			}
		}
		return num;
	}

	public int GetMaxCalibrationValue()
	{
		int num = 0;
		if (BzP != null && BzQ != null)
		{
			int num2 = Math.Min(BzQ.ax(), BzP.av()[2]);
			num = -2147483648;
			for (int i = 0; i < num2; i++)
			{
				num = Math.Max(num, BzP.m(i));
			}
		}
		return num;
	}

	public void FindComponents()
	{
		BzP = null;
		Bzp = null;
		BzQ = null;
		for (int i = 0; i < ((SettingOrSpecialObject)this).a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)this).a()[i];
			if (settingOrSpecialObject is Setting)
			{
				Setting setting = settingOrSpecialObject as Setting;
				if (((SettingOrSpecialObject)setting).B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bie())
				{
					BzP = setting;
				}
				else if (((SettingOrSpecialObject)setting).B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiF())
				{
					Bzp = setting;
				}
				else if (((SettingOrSpecialObject)setting).B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bif())
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
		HashSet<DataIdAndAttrId> val = new HashSet<DataIdAndAttrId>();
		if (BzP != null)
		{
			val.Add(new DataIdAndAttrId(BzP.A()));
		}
		if (Bzp != null)
		{
			val.Add(new DataIdAndAttrId(Bzp.A()));
		}
		if (BzQ != null)
		{
			val.Add(new DataIdAndAttrId(BzQ.A()));
		}
		return val;
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		BM.QQ.rl.A(this, global::a.aE.Hx, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		node.Text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiG();
		node.Checked = BzP.J();
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		BzP.c(node.Checked);
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		node.Text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiG();
		Setting setting = fromFramework.A(BzP.A());
		if (setting == null)
		{
			node.Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Big();
			return;
		}
		int num = setting.Ba();
		int num2 = BzP.Ba();
		if (num2 > num)
		{
			node.Tag = string.Concat(new string[5]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiH(),
				num.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rb(),
				num2.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bih()
			});
		}
		else
		{
			skipThisTreeNode = true;
		}
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		Setting setting = importFramework.A(BzP.A());
		if (!bothFrameworksUnlockedOrPasswordsMatch && ((destinationFrameworkLocked && BzP.J()) || (importFrameworkLocked && (setting == null || setting.J()))))
		{
			skipThisTreeNode = true;
			return;
		}
		node.Text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiG();
		userAccessibleIdsInDestFramework.Add(BzP.C());
		if (setting != null && !BzP.A(setting))
		{
			treeNodesWithDifferences.Add(node);
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		if (!bothFrameworksUnlockedOrPasswordsMatch && importFrameworkLocked && BzP.J())
		{
			skipThisTreeNode = true;
			return;
		}
		node.Text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiG();
		userAccessibleIdsInImportFramework.Add(BzP.C());
		if (!userAccessibleIdsInDestFramework.Contains(BzP.C()))
		{
			equivalentNodeExistsInDestMap = false;
		}
	}

	public bool NodeShouldBeOrange(TreeNode node, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework)
	{
		return !userAccessibleIdsInImportFramework.Contains(BzP.C());
	}

	public void ImportFromAnotherFramework(Framework importFramework, bool markForWrite)
	{
		if (BzP != null && Bzp != null && BzQ != null)
		{
			BzQ.A(importFramework, markForWrite);
			BzP.A(importFramework, markForWrite);
			Bzp.A(importFramework, markForWrite);
		}
	}
}
