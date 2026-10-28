using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ns4;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class IndexedList : Interface4
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

	public void SetListLabelsFormatString(string string_0)
	{
		BSz = string_0;
	}

	public void SetObjectsListLabelsFormatString(string string_0)
	{
		BsC = string_0;
	}

	public void SetObjectsOrderColumnTextWithDefault(string string_0, string default_str)
	{
		if (string_0 != Class333.smethod_102())
		{
			BsB = string_0;
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
			return number + Class333.BEm();
		}
		return (number % 10) switch
		{
			1 => number + Class333.BEN(), 
			2 => number + Class333.BEn(), 
			3 => number + Class333.BEO(), 
			_ => number + Class333.BEm(), 
		};
	}

	public string GetListLabelString(int number)
	{
		string arg = number.ToString();
		if (BSZ)
		{
			arg = IntToOrdinal(number);
		}
		if (BSz != null)
		{
			return string.Format(BSz, arg);
		}
		if (BsC != null)
		{
			return string.Format(BsC, arg);
		}
		return string.Empty;
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		HashSet<DataIdAndAttrId> hashSet = new HashSet<DataIdAndAttrId>();
		if (!BsA)
		{
			if (BSx.Count != 0)
			{
				foreach (int item in BSx)
				{
					hashSet.Add(new DataIdAndAttrId(item));
				}
			}
			else if (EachListRowIsAnObject())
			{
				for (int i = 0; i < Bsc.method_1().Count; i++)
				{
					SettingOrSpecialObject settingOrSpecialObject = Bsc.method_1()[i];
					if (!(settingOrSpecialObject is SpecialObject))
					{
						continue;
					}
					for (int j = 0; j < (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents.Count; j++)
					{
						if (!BsD.awX.ContainsKey((settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents[j].DataId))
						{
							hashSet.Add(new DataIdAndAttrId((settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents[j].DataId));
						}
					}
				}
			}
		}
		return hashSet;
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
		if (BSx.Count != 0)
		{
			bool flag = true;
			for (int i = 0; i < BSx.Count; i++)
			{
				int int_ = BSx[i];
				Setting setting = BsD.method_31(int_);
				if (!setting.method_219() && !setting.method_212() && !setting.method_220())
				{
					TreeNode treeNode = new TreeNode(setting.method_22(bool_0: true));
					treeNode.Checked = setting.method_96();
					treeNode.ForeColor = Form23.color_12;
					treeNode.Tag = setting;
					node.Nodes.Add(treeNode);
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
			for (int j = 0; j <= Bsc.method_1().Count; j++)
			{
				if (j == 0)
				{
					continue;
				}
				SettingOrSpecialObject settingOrSpecialObject = Bsc.method_1()[j - 1];
				if (!(settingOrSpecialObject is SpecialObject))
				{
					continue;
				}
				for (int k = 0; k <= (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents.Count; k++)
				{
					if (k != 0)
					{
						Setting setting2 = BsD.method_31((settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents[k - 1].DataId);
						if (setting2 != null && !setting2.method_219() && !setting2.method_212() && !setting2.method_220() && !BsD.awX.ContainsKey(setting2.method_64()))
						{
							TreeNode treeNode2 = new TreeNode(setting2.method_22(bool_0: true) + Class333.BEo() + j + Class333.smethod_9());
							treeNode2.Checked = setting2.method_96();
							treeNode2.ForeColor = Form23.color_12;
							treeNode2.Tag = setting2;
							node.Nodes.Add(treeNode2);
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
		if (BSx.Count != 0)
		{
			bool flag = true;
			for (int i = 0; i < BSx.Count; i++)
			{
				int int_ = BSx[i];
				Setting setting = BsD.method_31(int_);
				if (!setting.method_219() && !setting.method_212() && !setting.method_220() && fromFramework.method_31(int_) == null)
				{
					TreeNode treeNode = new TreeNode(setting.method_22(bool_0: true));
					treeNode.ForeColor = node.ForeColor;
					treeNode.Tag = Class333.smethod_1138();
					node.Nodes.Add(treeNode);
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
			for (int j = 0; j <= Bsc.method_1().Count; j++)
			{
				if (j == 0)
				{
					continue;
				}
				SettingOrSpecialObject settingOrSpecialObject = Bsc.method_1()[j - 1];
				if (!(settingOrSpecialObject is SpecialObject))
				{
					continue;
				}
				for (int k = 0; k <= (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents.Count; k++)
				{
					if (k != 0)
					{
						Setting setting2 = BsD.method_31((settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents[k - 1].DataId);
						if (setting2 != null && !setting2.method_219() && !setting2.method_212() && !setting2.method_220() && !BsD.awX.ContainsKey(setting2.method_64()) && fromFramework.method_31(setting2.method_64()) == null)
						{
							TreeNode treeNode2 = new TreeNode(setting2.method_22(bool_0: true) + Class333.BEo() + j + Class333.smethod_9());
							treeNode2.ForeColor = node.ForeColor;
							treeNode2.Tag = Class333.smethod_1138();
							node.Nodes.Add(treeNode2);
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
		if (BSx.Count != 0)
		{
			bool flag = true;
			for (int i = 0; i < DataIdsOfListSettings.Count; i++)
			{
				int num = DataIdsOfListSettings[i];
				Setting setting = BsD.method_31(num);
				Setting setting2 = importFramework.method_31(num);
				if (setting2 != null && !setting.method_72() && !setting.method_219() && !setting.method_220() && (bothFrameworksUnlockedOrPasswordsMatch || ((!destinationFrameworkLocked || !setting.method_96()) && (!importFrameworkLocked || (setting2 != null && !setting2.method_96())))))
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
					userAccessibleIdsInDestFramework.Add(new DataIdAndAttrId(num));
					if (!setting.method_282(setting2))
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
		else
		{
			if (!EachListRowIsAnObject())
			{
				return;
			}
			bool flag2 = true;
			for (int j = 0; j <= Bsc.method_1().Count; j++)
			{
				if (j == 0)
				{
					continue;
				}
				SettingOrSpecialObject settingOrSpecialObject = Bsc.method_1()[j - 1];
				if (!(settingOrSpecialObject is SpecialObject))
				{
					continue;
				}
				for (int k = 0; k <= (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents.Count; k++)
				{
					if (k == 0)
					{
						continue;
					}
					Setting setting3 = BsD.method_31((settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents[k - 1].DataId);
					Setting setting4 = importFramework.method_31((settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents[k - 1].DataId);
					if (setting4 != null && setting3 != null && !setting3.method_72() && !setting3.method_219() && !setting3.method_220() && !BsD.awX.ContainsKey(setting3.method_64()) && (bothFrameworksUnlockedOrPasswordsMatch || ((!destinationFrameworkLocked || !setting3.method_96()) && (!importFrameworkLocked || (setting4 != null && !setting4.method_96())))))
					{
						TreeNode treeNode2 = new TreeNode(setting3.method_22(bool_0: true) + Class333.BEo() + j + Class333.smethod_9());
						if (forceTickAll)
						{
							treeNode2.Checked = true;
						}
						treeNode2.ForeColor = Color.Gray;
						treeNode2.Tag = setting3;
						node.Nodes.Add(treeNode2);
						flag2 = false;
						userAccessibleIdsInDestFramework.Add(setting3.method_69());
						if (!setting3.method_282(setting4))
						{
							treeNodesWithDifferences.Add(treeNode2);
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
		if (BSx.Count != 0)
		{
			bool flag = true;
			for (int i = 0; i < DataIdsOfListSettings.Count; i++)
			{
				int int_ = DataIdsOfListSettings[i];
				Setting setting = BsD.method_31(int_);
				if (!setting.method_72() && !setting.method_219() && !setting.method_220() && (bothFrameworksUnlockedOrPasswordsMatch || !importFrameworkLocked || !setting.method_96()))
				{
					userAccessibleIdsInImportFramework.Add(setting.method_69());
					if (!userAccessibleIdsInDestFramework.Contains(setting.method_69()))
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
		else
		{
			if (!EachListRowIsAnObject())
			{
				return;
			}
			bool flag2 = true;
			for (int j = 0; j <= Bsc.method_1().Count; j++)
			{
				if (j == 0)
				{
					continue;
				}
				SettingOrSpecialObject settingOrSpecialObject = Bsc.method_1()[j - 1];
				if (!(settingOrSpecialObject is SpecialObject))
				{
					continue;
				}
				for (int k = 0; k <= (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents.Count; k++)
				{
					if (k == 0)
					{
						continue;
					}
					Setting setting2 = BsD.method_31((settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents[k - 1].DataId);
					if (setting2 != null && !setting2.method_72() && !setting2.method_219() && !setting2.method_220() && !BsD.awX.ContainsKey(setting2.method_64()) && (bothFrameworksUnlockedOrPasswordsMatch || !importFrameworkLocked || !setting2.method_96()))
					{
						userAccessibleIdsInImportFramework.Add(setting2.method_69());
						if (!userAccessibleIdsInDestFramework.Contains(setting2.method_69()))
						{
							TreeNode treeNode2 = new TreeNode(setting2.method_22(bool_0: true) + Class333.BEo() + j + Class333.smethod_9());
							treeNode2.ForeColor = Form23.color_12;
							treeNode2.Tag = setting2;
							node.Nodes.Add(treeNode2);
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
