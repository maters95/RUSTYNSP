using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using B;
using C;
using a;

namespace NSP.SettingsFramework;

public class UserLog : CG
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
		Setting setting = BsK.A(Bsh);
		if (setting != null)
		{
			return setting.av()[1] > 1;
		}
		return false;
	}

	private int A(int P_0, int P_1, Setting P_2, int P_3, List<List<int>> P_4, List<bool> P_5)
	{
		if (!BsK.C())
		{
			return -1;
		}
		if (P_5[P_1])
		{
			int num = -1;
			if (P_1 == 0)
			{
				for (int i = 1; i < P_3; i++)
				{
					if (!P_5[i])
					{
						num = i;
						break;
					}
				}
			}
			else if (P_1 == P_3 - 1)
			{
				for (int num2 = P_3 - 2; num2 >= 0; num2--)
				{
					if (!P_5[num2])
					{
						num = num2;
						break;
					}
				}
			}
			else
			{
				for (int j = 1; j <= P_3 - 2; j++)
				{
					if (P_1 - j >= 0 && !P_5[P_1 - j])
					{
						num = P_1 - j;
						break;
					}
					if (P_1 + j < P_3 && !P_5[P_1 + j])
					{
						num = P_1 + j;
						break;
					}
				}
			}
			if (num != -1)
			{
				P_2.A(P_4[num].Count, num, 0, P_0, true);
				P_4[num].Add(P_0);
				P_5[num] = P_4[num].Count >= P_2.av()[2];
			}
			return num;
		}
		P_2.A(P_4[P_1].Count, P_1, 0, P_0, true);
		P_4[P_1].Add(P_0);
		P_5[P_1] = P_4[P_1].Count >= P_2.av()[2];
		return P_1;
	}

	public void AddMissingRecommendedLogChannels()
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		if (BM.QO == BM.b.BpG)
		{
			return;
		}
		Setting setting = BsK.A(Bsh);
		Setting setting2 = BsK.A(BsI);
		int num = setting.av()[1];
		List<List<int>> val = new List<List<int>>();
		List<bool> val2 = new List<bool>();
		for (int i = 0; i < num; i++)
		{
			val.Add(new List<int>());
			for (int j = 0; j < setting.av()[2]; j++)
			{
				int num2 = setting.B(j, i, 0);
				if (num2 == 0 || num2 == setting.aU())
				{
					break;
				}
				val[i].Add(num2);
			}
			val2.Add(val[i].Count >= setting.av()[2]);
		}
		Ck ck = BM.aM();
		ck?.A(setting.A());
		setting.az();
		Dictionary<Table, int> val3 = new Dictionary<Table, int>();
		Enumerator<Setting> enumerator = BsK.aWt.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Setting current = enumerator.Current;
				if (current.i() == 0 || !((SettingOrSpecialObject)current).l() || !PortFunction.A(current))
				{
					continue;
				}
				bool flag = false;
				for (int k = 0; k < num; k++)
				{
					for (int l = 0; l < val[k].Count; l++)
					{
						if (val[k][l] == current.A())
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
					int num3 = current.i() - 1;
					int num4 = A(current.A(), num3, setting, num, val, val2);
					if (current is Table && num4 != -1)
					{
						val3.Add(current as Table, num4);
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		Enumerator<Table, int> enumerator2 = val3.Keys.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				Table current2 = enumerator2.Current;
				A(current2, val3[current2], num, setting, setting2, val, val2);
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
		setting.i(true);
		ck?.B();
		BM.b(setting.A());
	}

	private void A(Table P_0, int P_1, int P_2, Setting P_3, Setting P_4, List<List<int>> P_5, List<bool> P_6)
	{
		List<int> dataIdsOfChannelsPerEnabledAxis = P_0.GetDataIdsOfChannelsPerEnabledAxis();
		int num = P_4.m(P_1);
		for (int i = 0; i < dataIdsOfChannelsPerEnabledAxis.Count; i++)
		{
			int num2 = dataIdsOfChannelsPerEnabledAxis[i];
			int num3 = -1;
			int num4 = -1;
			for (int j = 0; j < P_2; j++)
			{
				for (int k = 0; k < P_5[j].Count; k++)
				{
					if (P_5[j][k] == num2)
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
				A(num2, P_1, P_3, P_2, P_5, P_6);
			}
			else if (P_4.m(num3) > num)
			{
				bool flag = P_3.aZ();
				P_3.az();
				bool flag2 = BsK.l();
				BsK.M();
				for (int l = num4 + 1; l < P_3.av()[2]; l++)
				{
					int num5 = P_3.B(l, num3, 0);
					P_3.A(l - 1, num3, 0, num5, true);
				}
				P_3.A(P_3.av()[2] - 1, num3, 0, P_3.aU(), true);
				if (flag2)
				{
					BsK.A(true, P_3);
				}
				if (flag)
				{
					P_3.i(true);
				}
				P_5[num3].Remove(num2);
				P_6[num3] = false;
				A(num2, P_1, P_3, P_2, P_5, P_6);
			}
		}
	}

	public void AddChannelToLoggingList(Setting channel, int targetGroupIndex)
	{
		Setting setting = BsK.A(Bsh);
		Setting setting2 = BsK.A(BsI);
		int num = setting.av()[1];
		List<List<int>> val = new List<List<int>>();
		List<bool> val2 = new List<bool>();
		for (int i = 0; i < num; i++)
		{
			val.Add(new List<int>());
			for (int j = 0; j < setting.av()[2]; j++)
			{
				int num2 = setting.B(j, i, 0);
				if (num2 == 0 || num2 == setting.aU())
				{
					break;
				}
				if (num2 == channel.A())
				{
					return;
				}
				val[i].Add(num2);
			}
			val2.Add(val[i].Count >= setting.av()[2]);
		}
		int num3 = A(channel.A(), targetGroupIndex, setting, num, val, val2);
		if (channel is Table && num3 != -1)
		{
			A(channel as Table, num3, num, setting, setting2, val, val2);
		}
		BM.b(setting.A());
	}

	public void RemoveChannelFromLoggingList(Setting channel)
	{
		if (!BsK.C())
		{
			return;
		}
		Setting setting = BsK.A(Bsh);
		int num = setting.av()[1];
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < setting.av()[2]; j++)
			{
				int num2 = setting.B(j, i, 0);
				if (num2 == 0 || num2 == setting.aU())
				{
					break;
				}
				if (num2 == channel.A())
				{
					bool flag = setting.aZ();
					setting.az();
					bool flag2 = BsK.l();
					BsK.M();
					for (int k = j + 1; k < setting.av()[2]; k++)
					{
						int num3 = setting.B(k, i, 0);
						setting.A(k - 1, i, 0, num3, true);
					}
					setting.A(setting.av()[2] - 1, i, 0, setting.aU(), true);
					if (flag2)
					{
						BsK.A(true, setting);
					}
					if (flag)
					{
						setting.i(true);
					}
					BM.b(setting.A());
					return;
				}
			}
		}
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		HashSet<DataIdAndAttrId> obj = new HashSet<DataIdAndAttrId>();
		obj.Add(new DataIdAndAttrId(Bsh));
		obj.Add(new DataIdAndAttrId(BsI));
		return obj;
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		BM.QQ.rl.A(Bsj, aE.ha, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		Setting setting = BsK.A(new DataIdAndAttrId(Bsh));
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
				BsK.A(current).c(node.Checked);
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
		List<Setting> val = new List<Setting>();
		Setting setting = BsK.A(Bsh);
		Setting setting2 = BsK.A(BsI);
		Setting setting3 = P_0.A(setting.A());
		Setting setting4 = P_0.A(setting2.A());
		if (setting3 != null && !setting.A(setting3))
		{
			val.Add(setting);
		}
		if (setting4 != null && !setting2.A(setting4))
		{
			val.Add(setting2);
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
				Setting setting = BsK.A(current);
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
				Setting setting = BsK.A(current);
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
