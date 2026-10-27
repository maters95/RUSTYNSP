using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using C;
using a;

namespace NSP.SettingsFramework;

public class UIListObject : CG
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
		HashSet<DataIdAndAttrId> val = new HashSet<DataIdAndAttrId>();
		for (int i = 0; i < Bsd.Count; i++)
		{
			int dataId = Bsd[i].DataId;
			Setting setting = BsH.A(dataId);
			if (setting == null || !setting.aJ() || setting.ah())
			{
				val.Add(new DataIdAndAttrId(dataId));
			}
		}
		return val;
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		HashSet<DataIdAndAttrId> val = new HashSet<DataIdAndAttrId>();
		for (int i = 0; i < Bsd.Count; i++)
		{
			int dataId = Bsd[i].DataId;
			if (!BsH.awX.ContainsKey(dataId))
			{
				Setting setting = BsH.A(dataId);
				if (setting == null || !setting.aJ() || setting.ah())
				{
					val.Add(new DataIdAndAttrId(dataId));
				}
			}
		}
		return val;
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		BM.QQ.rl.A(Bsg, aE.HX, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		Enumerator<UIListSettingDataIdAndIndent> enumerator = Bsd.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				UIListSettingDataIdAndIndent current = enumerator.Current;
				Setting setting = BsH.A(current.DataId);
				if (setting != null && !setting.am() && !setting.al() && !setting.aN() && (setting.ah() || !setting.aJ()) && !BsH.awX.ContainsKey(current.DataId))
				{
					TreeNode val = new TreeNode(((SettingOrSpecialObject)setting).A(true));
					val.Checked = setting.J();
					val.ForeColor = BM.te;
					val.Tag = setting;
					node.Nodes.Add(val);
					flag = false;
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

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<UIListSettingDataIdAndIndent> enumerator = Bsd.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				UIListSettingDataIdAndIndent current = enumerator.Current;
				Setting setting = BsH.A(current.DataId);
				if (setting == null || setting.am() || setting.al() || setting.aN() || (!setting.ah() && setting.aJ()) || BsH.awX.ContainsKey(setting.A()))
				{
					continue;
				}
				Setting setting2 = fromFramework.A(setting.A());
				if (setting2 == null)
				{
					TreeNode val = new TreeNode(((SettingOrSpecialObject)setting).A(true));
					val.ForeColor = node.ForeColor;
					val.Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kw();
					node.Nodes.Add(val);
				}
				else
				{
					if (setting.aJ() || setting.U())
					{
						continue;
					}
					List<Setting.ListItems.A> val2 = setting.d(0);
					for (int i = 0; i < val2.Count; i++)
					{
						bool flag = false;
						List<Setting.ListItems.A> val3 = setting2.d(0);
						for (int j = 0; j < val3.Count; j++)
						{
							if (val3[j].bBv == val2[i].bBv || val3[j].bBV.Equals(val2[i].bBV))
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							TreeNode val4 = new TreeNode(((SettingOrSpecialObject)setting).A(true));
							val4.ForeColor = node.ForeColor;
							val4.Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kV() + val2[i].bBV + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kv();
							node.Nodes.Add(val4);
						}
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		Enumerator<UIListSettingDataIdAndIndent> enumerator = Bsd.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				UIListSettingDataIdAndIndent current = enumerator.Current;
				Setting setting = BsH.A(current.DataId);
				if (setting == null || setting.D() || setting.am() || setting.aN() || (!setting.ah() && setting.aJ()) || BsH.awX.ContainsKey(setting.A()))
				{
					continue;
				}
				Setting setting2 = importFramework.A(setting.A());
				if ((bothFrameworksUnlockedOrPasswordsMatch || ((!destinationFrameworkLocked || !setting.J()) && (!importFrameworkLocked || (setting2 != null && !setting2.J())))) && !idsAlreadyHandled.Contains(setting.C()))
				{
					TreeNode val = new TreeNode(((SettingOrSpecialObject)setting).A(true));
					if (forceTickAll)
					{
						val.Checked = true;
					}
					val.ForeColor = Color.Gray;
					val.Tag = setting;
					node.Nodes.Add(val);
					flag = false;
					userAccessibleIdsInDestFramework.Add(setting.C());
					idsAlreadyHandled.Add(setting.C());
					if (setting2 != null && !setting2.D() && !setting2.am() && !setting2.aN() && !setting.A(setting2))
					{
						treeNodesWithDifferences.Add(val);
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
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		Enumerator<UIListSettingDataIdAndIndent> enumerator = Bsd.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				UIListSettingDataIdAndIndent current = enumerator.Current;
				Setting setting = BsH.A(current.DataId);
				if (setting != null && !setting.D() && !setting.am() && !setting.aN() && (setting.ah() || !setting.aJ()) && !BsH.awX.ContainsKey(setting.A()) && (bothFrameworksUnlockedOrPasswordsMatch || !importFrameworkLocked || !setting.J()) && !idsAlreadyHandled.Contains(setting.C()))
				{
					userAccessibleIdsInImportFramework.Add(setting.C());
					if (!userAccessibleIdsInDestFramework.Contains(setting.C()))
					{
						TreeNode val = new TreeNode(((SettingOrSpecialObject)setting).A(true));
						val.ForeColor = BM.te;
						val.Tag = setting;
						node.Nodes.Add(val);
						flag = false;
						idsAlreadyHandled.Add(setting.C());
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
