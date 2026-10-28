using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ns2;
using ns4;
using ns6;

namespace NSP.SettingsFramework;

public class UserLog : Interface4
{
	private int Bsh;

	private int BsI;

	private int Bsi;

	private string BsJ;

	private SettingOrSpecialObject Bsj;

	private Framework BsK;

	public int DataIdOfChannelListSetting
	{
		get
		{
			return Bsh;
		}
		set
		{
			Bsh = value;
		}
	}

	public int DataIdOfChannelRateSetting
	{
		get
		{
			return BsI;
		}
		set
		{
			BsI = value;
		}
	}

	public int RateLimit
	{
		get
		{
			return Bsi;
		}
		set
		{
			Bsi = value;
		}
	}

	public string LimitedSpaceEquation
	{
		get
		{
			return BsJ;
		}
		set
		{
			BsJ = value;
		}
	}

	public UserLog(Framework framework, SettingOrSpecialObject ownerSettingOrObject)
	{
		BsK = framework;
		Bsj = ownerSettingOrObject;
	}

	public bool HasGroups()
	{
		Setting setting = BsK.method_31(Bsh);
		if (setting != null)
		{
			return setting.method_242()[1] > 1;
		}
		return false;
	}

	private int method_0(int int_0, int int_1, Setting setting_0, int int_2, List<List<int>> list_0, List<bool> list_1)
	{
		if (!BsK.method_4())
		{
			return -1;
		}
		if (list_1[int_1])
		{
			int num = -1;
			if (int_1 == 0)
			{
				for (int i = 1; i < int_2; i++)
				{
					if (!list_1[i])
					{
						num = i;
						break;
					}
				}
			}
			else if (int_1 == int_2 - 1)
			{
				int num2 = int_2 - 2;
				while (num2 >= 0)
				{
					if (list_1[num2])
					{
						num2--;
						continue;
					}
					num = num2;
					break;
				}
			}
			else
			{
				for (int j = 1; j <= int_2 - 2; j++)
				{
					if (int_1 - j < 0 || list_1[int_1 - j])
					{
						if (int_1 + j < int_2 && !list_1[int_1 + j])
						{
							num = int_1 + j;
							break;
						}
						continue;
					}
					num = int_1 - j;
					break;
				}
			}
			if (num != -1)
			{
				setting_0.method_273(list_0[num].Count, num, 0, int_0, bool_0: true);
				list_0[num].Add(int_0);
				list_1[num] = list_0[num].Count >= setting_0.method_242()[2];
			}
			return num;
		}
		setting_0.method_273(list_0[int_1].Count, int_1, 0, int_0, bool_0: true);
		list_0[int_1].Add(int_0);
		list_1[int_1] = list_0[int_1].Count >= setting_0.method_242()[2];
		return int_1;
	}

	public void AddMissingRecommendedLogChannels()
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		Setting setting = BsK.method_31(Bsh);
		Setting setting_ = BsK.method_31(BsI);
		int num = setting.method_242()[1];
		List<List<int>> list = new List<List<int>>();
		List<bool> list2 = new List<bool>();
		for (int i = 0; i < num; i++)
		{
			list.Add(new List<int>());
			for (int j = 0; j < setting.method_242()[2]; j++)
			{
				int num2 = setting.method_257(j, i, 0);
				if (num2 == 0 || num2 == setting.method_236())
				{
					break;
				}
				list[i].Add(num2);
			}
			list2.Add(list[i].Count >= setting.method_242()[2]);
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_2(setting.method_64());
		setting.method_268();
		Dictionary<Table, int> dictionary = new Dictionary<Table, int>();
		foreach (Setting item in BsK.aWt)
		{
			if (item.method_94() == 0 || !item.method_35() || !PortFunction.smethod_52(item))
			{
				continue;
			}
			bool flag = false;
			for (int k = 0; k < num; k++)
			{
				for (int l = 0; l < list[k].Count; l++)
				{
					if (list[k][l] == item.method_64())
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					break;
				}
			}
			if (!flag)
			{
				int int_ = item.method_94() - 1;
				int num3 = method_0(item.method_64(), int_, setting, num, list, list2);
				if (item is Table && num3 != -1)
				{
					dictionary.Add(item as Table, num3);
				}
			}
		}
		foreach (Table key in dictionary.Keys)
		{
			method_1(key, dictionary[key], num, setting, setting_, list, list2);
		}
		setting.method_267(bool_0: true);
		@class?.method_4();
		Form23.smethod_74(setting.method_64());
	}

	private void method_1(Table table_0, int int_0, int int_1, Setting setting_0, Setting setting_1, List<List<int>> list_0, List<bool> list_1)
	{
		List<int> dataIdsOfChannelsPerEnabledAxis = table_0.GetDataIdsOfChannelsPerEnabledAxis();
		int num = setting_1.method_258(int_0);
		for (int i = 0; i < dataIdsOfChannelsPerEnabledAxis.Count; i++)
		{
			int num2 = dataIdsOfChannelsPerEnabledAxis[i];
			int num3 = -1;
			int num4 = -1;
			for (int j = 0; j < int_1; j++)
			{
				for (int k = 0; k < list_0[j].Count; k++)
				{
					if (list_0[j][k] == num2)
					{
						num3 = j;
						num4 = k;
						break;
					}
				}
				if (num3 != -1)
				{
					break;
				}
			}
			if (num3 == -1)
			{
				method_0(num2, int_0, setting_0, int_1, list_0, list_1);
			}
			else if (setting_1.method_258(num3) > num)
			{
				bool flag = setting_0.method_266();
				setting_0.method_268();
				bool flag2 = BsK.method_53();
				BsK.method_55();
				for (int l = num4 + 1; l < setting_0.method_242()[2]; l++)
				{
					int int_2 = setting_0.method_257(l, num3, 0);
					setting_0.method_273(l - 1, num3, 0, int_2, bool_0: true);
				}
				setting_0.method_273(setting_0.method_242()[2] - 1, num3, 0, setting_0.method_236(), bool_0: true);
				if (flag2)
				{
					BsK.method_54(bool_0: true, setting_0);
				}
				if (flag)
				{
					setting_0.method_267(bool_0: true);
				}
				list_0[num3].Remove(num2);
				list_1[num3] = false;
				method_0(num2, int_0, setting_0, int_1, list_0, list_1);
			}
		}
	}

	public void AddChannelToLoggingList(Setting channel, int targetGroupIndex)
	{
		Setting setting = BsK.method_31(Bsh);
		Setting setting_ = BsK.method_31(BsI);
		int num = setting.method_242()[1];
		List<List<int>> list = new List<List<int>>();
		List<bool> list2 = new List<bool>();
		for (int i = 0; i < num; i++)
		{
			list.Add(new List<int>());
			for (int j = 0; j < setting.method_242()[2]; j++)
			{
				int num2 = setting.method_257(j, i, 0);
				if (num2 == 0 || num2 == setting.method_236())
				{
					break;
				}
				if (num2 == channel.method_64())
				{
					return;
				}
				list[i].Add(num2);
			}
			list2.Add(list[i].Count >= setting.method_242()[2]);
		}
		int num3 = method_0(channel.method_64(), targetGroupIndex, setting, num, list, list2);
		if (channel is Table && num3 != -1)
		{
			method_1(channel as Table, num3, num, setting, setting_, list, list2);
		}
		Form23.smethod_74(setting.method_64());
	}

	public void RemoveChannelFromLoggingList(Setting channel)
	{
		if (!BsK.method_4())
		{
			return;
		}
		Setting setting = BsK.method_31(Bsh);
		int num = setting.method_242()[1];
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < setting.method_242()[2]; j++)
			{
				int num2 = setting.method_257(j, i, 0);
				if (num2 == 0 || num2 == setting.method_236())
				{
					break;
				}
				if (num2 == channel.method_64())
				{
					bool flag = setting.method_266();
					setting.method_268();
					bool flag2 = BsK.method_53();
					BsK.method_55();
					for (int k = j + 1; k < setting.method_242()[2]; k++)
					{
						int int_ = setting.method_257(k, i, 0);
						setting.method_273(k - 1, i, 0, int_, bool_0: true);
					}
					setting.method_273(setting.method_242()[2] - 1, i, 0, setting.method_236(), bool_0: true);
					if (flag2)
					{
						BsK.method_54(bool_0: true, setting);
					}
					if (flag)
					{
						setting.method_267(bool_0: true);
					}
					Form23.smethod_74(setting.method_64());
					return;
				}
			}
		}
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		return new HashSet<DataIdAndAttrId>
		{
			new DataIdAndAttrId(Bsh),
			new DataIdAndAttrId(BsI)
		};
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		Form23.form23_0.control25_0.method_28(Bsj, Enum38.const_14, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		Setting setting = BsK.method_32(new DataIdAndAttrId(Bsh));
		node.Checked = setting.method_96();
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			BsK.method_32(item).method_97(node.Checked);
		}
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		skipThisTreeNode = true;
	}

	private List<Setting> method_2(Framework framework_0)
	{
		List<Setting> list = new List<Setting>();
		Setting setting = BsK.method_31(Bsh);
		Setting setting2 = BsK.method_31(BsI);
		Setting setting3 = framework_0.method_31(setting.method_64());
		Setting setting4 = framework_0.method_31(setting2.method_64());
		if (setting3 != null && !setting.method_282(setting3))
		{
			list.Add(setting);
		}
		if (setting4 != null && !setting2.method_282(setting4))
		{
			list.Add(setting2);
		}
		return list;
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		List<Setting> list = method_2(importFramework);
		bool flag = true;
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			Setting setting = BsK.method_32(item);
			Setting setting2 = importFramework.method_31(setting.method_64());
			if (bothFrameworksUnlockedOrPasswordsMatch || ((!destinationFrameworkLocked || !setting.method_96()) && (!importFrameworkLocked || (setting2 != null && !setting2.method_96()))))
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
				userAccessibleIdsInDestFramework.Add(item);
				if (list.Contains(setting))
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

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		bool flag = true;
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			Setting setting = BsK.method_32(item);
			if (bothFrameworksUnlockedOrPasswordsMatch || !importFrameworkLocked || !setting.method_96())
			{
				userAccessibleIdsInImportFramework.Add(item);
				if (!userAccessibleIdsInDestFramework.Contains(item))
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

	public bool NodeShouldBeOrange(TreeNode node, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework)
	{
		return false;
	}

	public void ImportFromAnotherFramework(Framework importFramework, bool markForWrite)
	{
	}
}
