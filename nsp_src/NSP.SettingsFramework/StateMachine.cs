using System.Collections.Generic;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using C;
using a;

namespace NSP.SettingsFramework;

public class StateMachine : SpecialObject, CG
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

	public StateMachine(Framework framework, string name, SettingOrSpecialObject parentSettingOrSpecialObject, string parentModuleName)
		: base(framework, name, parentSettingOrSpecialObject, parentModuleName)
	{
	}

	public void FindComponents()
	{
		for (int i = 0; i < ((SettingOrSpecialObject)this).a().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)this).a()[i];
			if (settingOrSpecialObject is StateMachineStage)
			{
				StateMachineStage stateMachineStage = settingOrSpecialObject as StateMachineStage;
				BzT.Add(stateMachineStage);
			}
			else if (settingOrSpecialObject is StateMachineError)
			{
				StateMachineError stateMachineError = settingOrSpecialObject as StateMachineError;
				Bzt.Add(stateMachineError);
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
		BM.QQ.rl.A(this, aE.Hy, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		if (!node.Text.ToLower().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiI()))
		{
			node.Text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bii();
		}
		if (Bzq != 0)
		{
			Setting setting = m_framework.A(Bzq);
			node.Checked = setting.J();
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
			m_framework.A(Bzq).c(node.Checked);
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
			Setting setting = m_framework.A(Bzq);
			Setting setting2 = importFramework.A(Bzq);
			if (!bothFrameworksUnlockedOrPasswordsMatch && ((destinationFrameworkLocked && setting.J()) || (importFrameworkLocked && (setting2 == null || setting2.J()))))
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
		if (!node.Text.ToLower().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiI()))
		{
			node.Text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bii();
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		if (Bzq != 0)
		{
			Setting setting = m_framework.A(Bzq);
			if (!bothFrameworksUnlockedOrPasswordsMatch && importFrameworkLocked && setting.J())
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
		if (!node.Text.ToLower().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiI()))
		{
			node.Text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bii();
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
