using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using B;
using C;
using a;

namespace NSP.SettingsFramework;

public class ApplyAndExecuteProcess : CG
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		HashSet<DataIdAndAttrId> val = new HashSet<DataIdAndAttrId>();
		Enumerator<int> enumerator = Brs.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current = enumerator.Current;
				val.Add(new DataIdAndAttrId(current));
			}
			return val;
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		BM.QQ.rl.A(BrU, aE.Hz, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		if (Brs.Count != 0)
		{
			Setting setting = Bru.A(new DataIdAndAttrId(Brs[0]));
			node.Checked = setting.J();
		}
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<DataIdAndAttrId> enumerator = GetIdsContained().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				Bru.A(current).c(node.Checked);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		skipThisTreeNode = true;
	}

	private List<Setting> A(Framework P_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Setting> val = new List<Setting>();
		Enumerator<int> enumerator = Brs.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current = enumerator.Current;
				Setting setting = Bru.A(current);
				Setting setting2 = P_0.A(current);
				if (setting2 != null && !setting.A(setting2))
				{
					val.Add(setting);
				}
			}
			return val;
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		List<Setting> val = A(importFramework);
		bool flag = true;
		Enumerator<DataIdAndAttrId> enumerator = GetIdsContained().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				Setting setting = Bru.A(current);
				Setting setting2 = importFramework.A(setting.A());
				if (bothFrameworksUnlockedOrPasswordsMatch || ((!destinationFrameworkLocked || !setting.J()) && (!importFrameworkLocked || (setting2 != null && !setting2.J()))))
				{
					TreeNode val2 = new TreeNode(((SettingOrSpecialObject)setting).A(true));
					if (forceTickAll)
					{
						val2.Checked = true;
					}
					val2.ForeColor = Color.Gray;
					val2.Tag = setting;
					node.Nodes.Add(val2);
					flag = false;
					userAccessibleIdsInDestFramework.Add(current);
					if (val.Contains(setting))
					{
						treeNodesWithDifferences.Add(val2);
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (flag)
		{
			skipThisTreeNode = true;
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		Enumerator<DataIdAndAttrId> enumerator = GetIdsContained().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				Setting setting = Bru.A(current);
				if (bothFrameworksUnlockedOrPasswordsMatch || !importFrameworkLocked || !setting.J())
				{
					userAccessibleIdsInImportFramework.Add(current);
					if (!userAccessibleIdsInDestFramework.Contains(current))
					{
						TreeNode val = new TreeNode(((SettingOrSpecialObject)setting).A(true));
						val.ForeColor = BM.te;
						val.Tag = setting;
						node.Nodes.Add(val);
						flag = false;
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
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
