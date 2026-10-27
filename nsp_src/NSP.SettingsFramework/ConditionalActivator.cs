using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using C;

namespace NSP.SettingsFramework;

public class ConditionalActivator : CG
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
		HashSet<DataIdAndAttrId> val = new HashSet<DataIdAndAttrId>();
		if (BrV != 0)
		{
			val.Add(new DataIdAndAttrId(BrV));
		}
		val.Add(new DataIdAndAttrId(Brv));
		val.Add(new DataIdAndAttrId(Brw));
		val.Add(new DataIdAndAttrId(BrX));
		return val;
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
		Setting setting = BrY.A(new DataIdAndAttrId(Brv));
		node.Checked = setting.J();
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
				BrY.A(current).c(node.Checked);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<DataIdAndAttrId> enumerator = GetIdsContained().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				if (fromFramework.A(current) == null)
				{
					TreeNode val = new TreeNode(((SettingOrSpecialObject)BrY.A(current)).A(true));
					val.ForeColor = node.ForeColor;
					val.Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kw();
					node.Nodes.Add(val);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private List<Setting> A(Framework P_0)
	{
		List<Setting> val = new List<Setting>();
		if (BrV != 0)
		{
			Setting setting = BrY.A(BrV);
			Setting setting2 = P_0.A(BrV);
			if (setting2 != null && !setting.A(setting2))
			{
				val.Add(setting);
			}
		}
		Setting setting3 = BrY.A(Brv);
		Setting setting4 = BrY.A(Brw);
		Setting setting5 = BrY.A(BrX);
		Setting setting6 = P_0.A(Brv);
		Setting setting7 = P_0.A(Brw);
		Setting setting8 = P_0.A(BrX);
		if (setting6 != null && setting7 != null && setting8 != null)
		{
			if (!setting3.A(setting6))
			{
				val.Add(setting3);
			}
			if (!setting4.A(setting7))
			{
				val.Add(setting4);
			}
			if (!setting5.A(setting8))
			{
				val.Add(setting5);
			}
		}
		return val;
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
				Setting setting = BrY.A(current);
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
				Setting setting = BrY.A(current);
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
