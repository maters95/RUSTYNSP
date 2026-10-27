using System;
using System.Collections.Generic;
using System.Windows.Forms;
using B;
using C;
using a;

namespace NSP.SettingsFramework;

public class ChannelsProperties : SpecialObject, CG
{
	public ChannelsProperties(Framework framework, string name, SettingOrSpecialObject parentSettingOrSpecialObject, string parentModuleName)
		: base(framework, name, parentSettingOrSpecialObject, parentModuleName)
	{
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		HashSet<DataIdAndAttrId> val = new HashSet<DataIdAndAttrId>();
		Enumerator<Setting> enumerator = m_framework.aWt.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Enumerator<SettingOrSpecialObject> enumerator2 = ((SettingOrSpecialObject)enumerator.Current).a().GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current is Setting setting && setting.b())
						{
							val.Add(setting.C());
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
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
		BM.QQ.rl.A(null, aE.Hv, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		skipThisTreeNode = true;
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		skipThisTreeNode = true;
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<DataIdAndAttrId> enumerator = GetIdsContained().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				Setting setting = m_framework.A(current);
				if (setting != null)
				{
					userAccessibleIdsInDestFramework.Add(current);
				}
				Setting setting2 = importFramework.A(current);
				if (setting2 != null && !setting.A(setting2))
				{
					treeNodesWithDifferences.Add(node);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<DataIdAndAttrId> enumerator = GetIdsContained().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				userAccessibleIdsInImportFramework.Add(current);
				if (equivalentNodeExistsInDestMap && !userAccessibleIdsInDestFramework.Contains(current))
				{
					equivalentNodeExistsInDestMap = false;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public bool NodeShouldBeOrange(TreeNode node, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework)
	{
		return false;
	}

	public void ImportFromAnotherFramework(Framework importFramework, bool markForWrite)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<DataIdAndAttrId> enumerator = GetIdsContained().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				Setting setting = m_framework.A(current);
				if (setting != null && !setting.D())
				{
					setting.A(importFramework, markForWrite);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}
}
