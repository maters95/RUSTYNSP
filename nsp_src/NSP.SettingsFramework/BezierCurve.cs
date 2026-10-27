using System;
using System.Collections.Generic;
using System.Windows.Forms;
using B;
using C;
using a;

namespace NSP.SettingsFramework;

public class BezierCurve : SpecialObject, CG
{
	private new class A
	{
		private short bbb;

		private short bbC;

		private short bbc;

		private short bbD;

		private bool bbd;

		public A(short P_0, short P_1)
		{
			bbb = P_0;
			bbD = P_1;
			A(P_0, P_1);
		}

		public void A(short P_0, short P_1)
		{
			bbC = P_0;
			bbc = P_1;
			bbd = BezierCurve.A(bbb, bbD, bbC) && BezierCurve.A(bbb, bbD, bbc);
		}

		public bool A(ushort P_0, out short P_1)
		{
			if (bbd && BezierCurve.A((short)0, (short)1000, (short)P_0))
			{
				ushort num = (ushort)(1000 - P_0);
				P_1 = (short)((long)bbb * (long)num * num * num / 1000000000 + (long)bbC * (long)num * num * P_0 * 3 / 1000000000 + (long)bbc * (long)num * P_0 * P_0 * 3 / 1000000000 + (long)bbD * (long)P_0 * P_0 * P_0 / 1000000000);
				return true;
			}
			P_1 = 0;
			return false;
		}

		public bool A(short P_0, out ushort P_1)
		{
			if (bbd)
			{
				short num = bbb;
				short num2 = bbD;
				if (BezierCurve.A(num, num2, P_0))
				{
					ushort num3 = 0;
					ushort num4 = 1000;
					ushort num5;
					while (true)
					{
						num5 = (ushort)((num3 + num4) / 2);
						if (num3 >= num5 || num5 >= num4)
						{
							break;
						}
						if (!A(num5, out var num6))
						{
							P_1 = 0;
							return false;
						}
						if (num6 == P_0)
						{
							break;
						}
						if (num < num2)
						{
							if (P_0 > num6)
							{
								num3 = num5;
							}
							else
							{
								num4 = num5;
							}
						}
						else if (P_0 < num6)
						{
							num3 = num5;
						}
						else
						{
							num4 = num5;
						}
					}
					P_1 = num5;
					return true;
				}
			}
			P_1 = 0;
			return false;
		}
	}

	public BezierCurve(Framework framework, string name, SettingOrSpecialObject parentSettingOrSpecialObject, string parentModuleName)
		: base(framework, name, parentSettingOrSpecialObject, parentModuleName)
	{
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		HashSet<DataIdAndAttrId> obj = new HashSet<DataIdAndAttrId>();
		Setting setting = (Setting)((SettingOrSpecialObject)this).a()[0];
		Setting setting2 = (Setting)((SettingOrSpecialObject)this).a()[1];
		obj.Add(setting.C());
		obj.Add(setting2.C());
		return obj;
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		BM.QQ.rl.A(this, aE.HY, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		node.Checked = ((Setting)((SettingOrSpecialObject)this).a()[0]).J();
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		Setting setting = (Setting)((SettingOrSpecialObject)this).a()[0];
		Setting obj = (Setting)((SettingOrSpecialObject)this).a()[1];
		setting.c(node.Checked);
		obj.c(node.Checked);
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		skipThisTreeNode = true;
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		Setting setting = (Setting)((SettingOrSpecialObject)this).a()[0];
		Setting setting2 = (Setting)((SettingOrSpecialObject)this).a()[1];
		Setting setting3 = importFramework.A(setting.A());
		Setting setting4 = importFramework.A(setting2.A());
		if (bothFrameworksUnlockedOrPasswordsMatch || ((!destinationFrameworkLocked || !setting.J()) && (!importFrameworkLocked || (setting3 != null && !setting3.J()))))
		{
			userAccessibleIdsInDestFramework.Add(setting.C());
			userAccessibleIdsInDestFramework.Add(setting2.C());
			if (setting3 != null && setting4 != null && (!setting.A(setting3) || !setting2.A(setting4)))
			{
				treeNodesWithDifferences.Add(node);
			}
		}
		else
		{
			skipThisTreeNode = true;
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		Setting setting = (Setting)((SettingOrSpecialObject)this).a()[0];
		Setting setting2 = (Setting)((SettingOrSpecialObject)this).a()[1];
		if (bothFrameworksUnlockedOrPasswordsMatch || !importFrameworkLocked || !setting.J())
		{
			userAccessibleIdsInImportFramework.Add(setting.C());
			userAccessibleIdsInImportFramework.Add(setting2.C());
			if (!userAccessibleIdsInDestFramework.Contains(setting.C()) || !userAccessibleIdsInDestFramework.Contains(setting2.C()))
			{
				equivalentNodeExistsInDestMap = false;
			}
		}
		else
		{
			skipThisTreeNode = true;
		}
	}

	public bool NodeShouldBeOrange(TreeNode node, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework)
	{
		Setting setting = (Setting)((SettingOrSpecialObject)this).a()[0];
		Setting setting2 = (Setting)((SettingOrSpecialObject)this).a()[1];
		if (!userAccessibleIdsInImportFramework.Contains(setting.C()) || !userAccessibleIdsInImportFramework.Contains(setting2.C()))
		{
			return true;
		}
		return false;
	}

	public void ImportFromAnotherFramework(Framework importFramework, bool markForWrite)
	{
		Setting setting = (Setting)((SettingOrSpecialObject)this).a()[0];
		Setting obj = (Setting)((SettingOrSpecialObject)this).a()[1];
		setting.A(importFramework, markForWrite);
		obj.A(importFramework, markForWrite);
	}

	public static bool ETCBezierToTableRedundancyIsOK(Framework importFramework, Framework destFramework)
	{
		Setting setting = importFramework.A(2821);
		Setting setting2 = importFramework.A(2830);
		if (setting != null && setting2 != null)
		{
			Setting setting3 = destFramework.A(14206);
			Setting setting4 = destFramework.A(13876);
			Setting setting5 = destFramework.A(13899);
			Setting setting6 = destFramework.A(14203);
			Setting setting7 = destFramework.A(13945);
			Setting setting8 = destFramework.A(14201);
			if (setting3 != null && setting7 != null && setting4 != null && setting5 != null && setting6 != null)
			{
				bool flag = setting8 != null && setting8.ax() != 0;
				bool flag2 = setting7.ax() != 0;
				if (setting4.ax() == 0 || flag2 || flag)
				{
					return false;
				}
				int num = setting5.ax();
				if (num > setting6.av()[2])
				{
					return false;
				}
				int num2 = setting.m(0);
				int num3 = setting2.m(0);
				int num4 = setting.m(1);
				int num5 = setting2.m(1);
				A a = new A(0, 1000);
				A a2 = new A(0, 1000);
				a.A((short)num2, (short)num4);
				a2.A((short)num3, (short)num5);
				for (int i = 0; i < num; i++)
				{
					int num6 = setting6.m(i);
					int num7 = setting3.B(i, 0, 0);
					if (!a.A((short)num6, out var num8))
					{
						return false;
					}
					if (!a2.A(num8, out var num9))
					{
						return false;
					}
					if (!a2.A((short)num7, out var num10))
					{
						return false;
					}
					if (!a.A(num10, out var num11))
					{
						return false;
					}
					if (Math.Abs(num7 - num9) > 8 && Math.Abs(num6 - num11) > 8)
					{
						return false;
					}
				}
			}
		}
		return true;
	}

	private static bool A(short P_0, short P_1, short P_2)
	{
		if (P_0 <= P_1)
		{
			if (P_0 <= P_2 && P_2 <= P_1)
			{
				return true;
			}
		}
		else if (P_0 >= P_2 && P_2 >= P_1)
		{
			return true;
		}
		return false;
	}
}
