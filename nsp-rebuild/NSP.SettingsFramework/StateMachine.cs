using System.Collections.Generic;
using System.Windows.Forms;
using ns2;
using ns4;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class StateMachine(Framework framework, string name, SettingOrSpecialObject parentSettingOrSpecialObject, string parentModuleName) : SpecialObject(framework, name, parentSettingOrSpecialObject, parentModuleName), Interface4
{
	private int Bzq;

	private int BzR;

	private int Bzr;

	private int BzS;

	private int Bzs;

	private List<StateMachineStage> BzT = new List<StateMachineStage>();

	private List<StateMachineError> Bzt = new List<StateMachineError>();

	public int StatusChannelDataId
	{
		get
		{
			return Bzq;
		}
		set
		{
			Bzq = value;
		}
	}

	public int ProcessId
	{
		get
		{
			return BzR;
		}
		set
		{
			BzR = value;
		}
	}

	public int OutcomeErrorChannelDataId
	{
		get
		{
			return Bzr;
		}
		set
		{
			Bzr = value;
		}
	}

	public int CurrentStageChannelDataId
	{
		get
		{
			return BzS;
		}
		set
		{
			BzS = value;
		}
	}

	public int RequestStageChannelDataId
	{
		get
		{
			return Bzs;
		}
		set
		{
			Bzs = value;
		}
	}

	public List<StateMachineStage> StagesList => BzT;

	public List<StateMachineError> ErrorsList => Bzt;

	public void FindComponents()
	{
		for (int i = 0; i < method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = method_1()[i];
			if (settingOrSpecialObject is StateMachineStage)
			{
				StateMachineStage item = settingOrSpecialObject as StateMachineStage;
				BzT.Add(item);
			}
			else if (settingOrSpecialObject is StateMachineError)
			{
				StateMachineError item2 = settingOrSpecialObject as StateMachineError;
				Bzt.Add(item2);
			}
		}
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		return new HashSet<DataIdAndAttrId>();
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		Form23.form23_0.control25_0.method_28(this, Enum38.const_10, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		if (!node.Text.ToLower().Contains(Class333.BiI()))
		{
			node.Text += Class333.Bii();
		}
		if (Bzq != 0)
		{
			Setting setting = m_framework.method_31(Bzq);
			node.Checked = setting.method_96();
		}
		else
		{
			node.Checked = false;
		}
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		if (Bzq != 0)
		{
			m_framework.method_31(Bzq).method_97(node.Checked);
		}
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		skipThisTreeNode = true;
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		if (Bzq != 0)
		{
			Setting setting = m_framework.method_31(Bzq);
			Setting setting2 = importFramework.method_31(Bzq);
			if (!bothFrameworksUnlockedOrPasswordsMatch && ((destinationFrameworkLocked && setting.method_96()) || (importFrameworkLocked && (setting2 == null || setting2.method_96()))))
			{
				skipThisTreeNode = true;
				return;
			}
		}
		else if (!bothFrameworksUnlockedOrPasswordsMatch)
		{
			skipThisTreeNode = true;
			return;
		}
		if (!node.Text.ToLower().Contains(Class333.BiI()))
		{
			node.Text += Class333.Bii();
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		if (Bzq != 0)
		{
			Setting setting = m_framework.method_31(Bzq);
			if ((!bothFrameworksUnlockedOrPasswordsMatch & importFrameworkLocked) && setting.method_96())
			{
				skipThisTreeNode = true;
				return;
			}
		}
		else if (!bothFrameworksUnlockedOrPasswordsMatch)
		{
			skipThisTreeNode = true;
			return;
		}
		if (!node.Text.ToLower().Contains(Class333.BiI()))
		{
			node.Text += Class333.Bii();
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
