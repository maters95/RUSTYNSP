using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using C;

namespace NSP.SettingsFramework;

public class IndexedList : CG
{
	private List<int> BSx = new List<int>();

	private int BSY;

	private int BSy;

	private bool BSZ;

	private string BSz;

	private bool BsA;

	private bool Bsa;

	private string BsB;

	private int Bsb;

	private string BsC;

	private SpecialObject Bsc;

	private Framework BsD;

	public bool ShowOrdinalValues
	{
		get
		{
			return BSZ;
		}
		set
		{
			BSZ = value;
		}
	}

	public bool ShowSummary
	{
		get
		{
			return BsA;
		}
		set
		{
			BsA = value;
		}
	}

	public bool Reorderable
	{
		get
		{
			return Bsa;
		}
		set
		{
			Bsa = value;
		}
	}

	public string ReorderableText
	{
		get
		{
			return BsB;
		}
		set
		{
			BsB = value;
		}
	}

	public int ExtraSummaryObjectId
	{
		get
		{
			return Bsb;
		}
		set
		{
			Bsb = value;
		}
	}

	public int DataIdOfListCountSetting
	{
		get
		{
			return BSY;
		}
		set
		{
			BSY = value;
		}
	}

	public int FixedCountValue
	{
		get
		{
			return BSy;
		}
		set
		{
			BSy = value;
		}
	}

	public List<int> DataIdsOfListSettings => BSx;

	public IndexedList(Framework framework, SpecialObject ownerObject)
	{
		BsD = framework;
		Bsc = ownerObject;
	}

	public void SetListLabelsFormatString(string s)
	{
		BSz = s;
	}

	public void SetObjectsListLabelsFormatString(string s)
	{
		BsC = s;
	}

	public void SetObjectsOrderColumnTextWithDefault(string s, string default_str)
	{
		if (s != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay())
		{
			BsB = s;
		}
		else
		{
			BsB = default_str;
		}
	}

	public bool EachListRowIsAnObject()
	{
		return BsC != null;
	}

	public static string IntToOrdinal(int number)
	{
		if (number < 0)
		{
			return number.ToString();
		}
		int num = number % 100;
		if (num >= 11 && num <= 13)
		{
			return number + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEm();
		}
		return (number % 10) switch
		{
			1 => number + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEN(), 
			2 => number + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEn(), 
			3 => number + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEO(), 
			_ => number + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEm(), 
		};
	}

	public string GetListLabelString(int number)
	{
		string text = number.ToString();
		if (BSZ)
		{
			text = IntToOrdinal(number);
		}
		if (BSz != null)
		{
			return string.Format(BSz, (object)text);
		}
		if (BsC != null)
		{
			return string.Format(BsC, (object)text);
		}
		return string.Empty;
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		HashSet<DataIdAndAttrId> val = new HashSet<DataIdAndAttrId>();
		if (!BsA)
		{
			if (BSx.Count != 0)
			{
				Enumerator<int> enumerator = BSx.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						int current = enumerator.Current;
						val.Add(new DataIdAndAttrId(current));
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			else if (EachListRowIsAnObject())
			{
				for (int i = 0; i < ((SettingOrSpecialObject)Bsc).a().Count; i++)
				{
					SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)Bsc).a()[i];
					if (!(settingOrSpecialObject is SpecialObject))
					{
						continue;
					}
					for (int j = 0; j < (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.Count; j++)
					{
						if (!BsD.awX.ContainsKey((settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents[j].DataId))
						{
							val.Add(new DataIdAndAttrId((settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents[j].DataId));
						}
					}
				}
			}
		}
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
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		if (BSx.Count != 0)
		{
			bool flag = true;
			for (int i = 0; i < BSx.Count; i++)
			{
				int num = BSx[i];
				Setting setting = BsD.A(num);
				if (!setting.am() && !setting.al() && !setting.aN())
				{
					TreeNode val = new TreeNode(((SettingOrSpecialObject)setting).A(true));
					val.Checked = setting.J();
					val.ForeColor = BM.te;
					val.Tag = setting;
					node.Nodes.Add(val);
					flag = false;
				}
			}
			if (flag)
			{
				skipThisTreeNode = true;
			}
		}
		else
		{
			if (!EachListRowIsAnObject())
			{
				return;
			}
			bool flag2 = true;
			for (int j = 0; j <= ((SettingOrSpecialObject)Bsc).a().Count; j++)
			{
				if (j == 0)
				{
					continue;
				}
				SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)Bsc).a()[j - 1];
				if (!(settingOrSpecialObject is SpecialObject))
				{
					continue;
				}
				for (int k = 0; k <= (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.Count; k++)
				{
					if (k != 0)
					{
						Setting setting2 = BsD.A((settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents[k - 1].DataId);
						if (setting2 != null && !setting2.am() && !setting2.al() && !setting2.aN() && !BsD.awX.ContainsKey(setting2.A()))
						{
							TreeNode val2 = new TreeNode(((SettingOrSpecialObject)setting2).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEo() + j + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E());
							val2.Checked = setting2.J();
							val2.ForeColor = BM.te;
							val2.Tag = setting2;
							node.Nodes.Add(val2);
							flag2 = false;
						}
					}
				}
			}
			if (flag2)
			{
				skipThisTreeNode = true;
			}
		}
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		if (BSx.Count != 0)
		{
			bool flag = true;
			for (int i = 0; i < BSx.Count; i++)
			{
				int num = BSx[i];
				Setting setting = BsD.A(num);
				if (!setting.am() && !setting.al() && !setting.aN() && fromFramework.A(num) == null)
				{
					TreeNode val = new TreeNode(((SettingOrSpecialObject)setting).A(true));
					val.ForeColor = node.ForeColor;
					val.Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kw();
					node.Nodes.Add(val);
					flag = false;
				}
			}
			if (flag)
			{
				skipThisTreeNode = true;
			}
		}
		else
		{
			if (!EachListRowIsAnObject())
			{
				return;
			}
			bool flag2 = true;
			for (int j = 0; j <= ((SettingOrSpecialObject)Bsc).a().Count; j++)
			{
				if (j == 0)
				{
					continue;
				}
				SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)Bsc).a()[j - 1];
				if (!(settingOrSpecialObject is SpecialObject))
				{
					continue;
				}
				for (int k = 0; k <= (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.Count; k++)
				{
					if (k != 0)
					{
						Setting setting2 = BsD.A((settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents[k - 1].DataId);
						if (setting2 != null && !setting2.am() && !setting2.al() && !setting2.aN() && !BsD.awX.ContainsKey(setting2.A()) && fromFramework.A(setting2.A()) == null)
						{
							TreeNode val2 = new TreeNode(((SettingOrSpecialObject)setting2).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEo() + j + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E());
							val2.ForeColor = node.ForeColor;
							val2.Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kw();
							node.Nodes.Add(val2);
							flag2 = false;
						}
					}
				}
			}
			if (flag2)
			{
				skipThisTreeNode = true;
			}
		}
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		if (BSx.Count != 0)
		{
			bool flag = true;
			for (int i = 0; i < DataIdsOfListSettings.Count; i++)
			{
				int num = DataIdsOfListSettings[i];
				Setting setting = BsD.A(num);
				Setting setting2 = importFramework.A(num);
				if (setting2 != null && !setting.D() && !setting.am() && !setting.aN() && (bothFrameworksUnlockedOrPasswordsMatch || ((!destinationFrameworkLocked || !setting.J()) && (!importFrameworkLocked || (setting2 != null && !setting2.J())))))
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
					userAccessibleIdsInDestFramework.Add(new DataIdAndAttrId(num));
					if (!setting.A(setting2))
					{
						treeNodesWithDifferences.Add(val);
					}
				}
			}
			if (flag)
			{
				skipThisTreeNode = true;
			}
		}
		else
		{
			if (!EachListRowIsAnObject())
			{
				return;
			}
			bool flag2 = true;
			for (int j = 0; j <= ((SettingOrSpecialObject)Bsc).a().Count; j++)
			{
				if (j == 0)
				{
					continue;
				}
				SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)Bsc).a()[j - 1];
				if (!(settingOrSpecialObject is SpecialObject))
				{
					continue;
				}
				for (int k = 0; k <= (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.Count; k++)
				{
					if (k == 0)
					{
						continue;
					}
					Setting setting3 = BsD.A((settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents[k - 1].DataId);
					Setting setting4 = importFramework.A((settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents[k - 1].DataId);
					if (setting4 != null && setting3 != null && !setting3.D() && !setting3.am() && !setting3.aN() && !BsD.awX.ContainsKey(setting3.A()) && (bothFrameworksUnlockedOrPasswordsMatch || ((!destinationFrameworkLocked || !setting3.J()) && (!importFrameworkLocked || (setting4 != null && !setting4.J())))))
					{
						TreeNode val2 = new TreeNode(((SettingOrSpecialObject)setting3).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEo() + j + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E());
						if (forceTickAll)
						{
							val2.Checked = true;
						}
						val2.ForeColor = Color.Gray;
						val2.Tag = setting3;
						node.Nodes.Add(val2);
						flag2 = false;
						userAccessibleIdsInDestFramework.Add(setting3.C());
						if (!setting3.A(setting4))
						{
							treeNodesWithDifferences.Add(val2);
						}
					}
				}
			}
			if (flag2)
			{
				skipThisTreeNode = true;
			}
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		if (BSx.Count != 0)
		{
			bool flag = true;
			for (int i = 0; i < DataIdsOfListSettings.Count; i++)
			{
				int num = DataIdsOfListSettings[i];
				Setting setting = BsD.A(num);
				if (!setting.D() && !setting.am() && !setting.aN() && (bothFrameworksUnlockedOrPasswordsMatch || !importFrameworkLocked || !setting.J()))
				{
					userAccessibleIdsInImportFramework.Add(setting.C());
					if (!userAccessibleIdsInDestFramework.Contains(setting.C()))
					{
						TreeNode val = new TreeNode(((SettingOrSpecialObject)setting).A(true));
						val.ForeColor = BM.te;
						val.Tag = setting;
						node.Nodes.Add(val);
						flag = false;
					}
				}
			}
			if (flag)
			{
				skipThisTreeNode = true;
			}
		}
		else
		{
			if (!EachListRowIsAnObject())
			{
				return;
			}
			bool flag2 = true;
			for (int j = 0; j <= ((SettingOrSpecialObject)Bsc).a().Count; j++)
			{
				if (j == 0)
				{
					continue;
				}
				SettingOrSpecialObject settingOrSpecialObject = ((SettingOrSpecialObject)Bsc).a()[j - 1];
				if (!(settingOrSpecialObject is SpecialObject))
				{
					continue;
				}
				for (int k = 0; k <= (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.Count; k++)
				{
					if (k == 0)
					{
						continue;
					}
					Setting setting2 = BsD.A((settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents[k - 1].DataId);
					if (setting2 != null && !setting2.D() && !setting2.am() && !setting2.aN() && !BsD.awX.ContainsKey(setting2.A()) && (bothFrameworksUnlockedOrPasswordsMatch || !importFrameworkLocked || !setting2.J()))
					{
						userAccessibleIdsInImportFramework.Add(setting2.C());
						if (!userAccessibleIdsInDestFramework.Contains(setting2.C()))
						{
							TreeNode val2 = new TreeNode(((SettingOrSpecialObject)setting2).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEo() + j + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E());
							val2.ForeColor = BM.te;
							val2.Tag = setting2;
							node.Nodes.Add(val2);
							flag2 = false;
						}
					}
				}
			}
			if (flag2)
			{
				skipThisTreeNode = true;
			}
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
