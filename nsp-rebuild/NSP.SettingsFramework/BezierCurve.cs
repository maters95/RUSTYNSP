using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ns2;
using ns4;
using ns6;

namespace NSP.SettingsFramework;

public class BezierCurve : SpecialObject, Interface4
{
	private class Class257
	{
		private short bbb;

		private short bbC;

		private short bbc;

		private short bbD;

		private bool bbd;

		public Class257(short short_0, short short_1)
		{
			bbb = short_0;
			bbD = short_1;
			method_0(short_0, short_1);
		}

		public void method_0(short short_0, short short_1)
		{
			bbC = short_0;
			bbc = short_1;
			bbd = smethod_4(bbb, bbD, bbC) && smethod_4(bbb, bbD, bbc);
		}

		public bool method_1(ushort ushort_0, out short short_0)
		{
			if (bbd && smethod_4(0, 1000, (short)ushort_0))
			{
				ushort num = (ushort)(1000 - ushort_0);
				short_0 = (short)((long)bbb * (long)num * num * num / 1000000000L + (long)bbC * (long)num * num * ushort_0 * 3L / 1000000000L + (long)bbc * (long)num * ushort_0 * ushort_0 * 3L / 1000000000L + (long)bbD * (long)ushort_0 * ushort_0 * ushort_0 / 1000000000L);
				return true;
			}
			short_0 = 0;
			return false;
		}

		public bool method_2(short short_0, out ushort ushort_0)
		{
			if (bbd)
			{
				short num = bbb;
				short num2 = bbD;
				if (smethod_4(num, num2, short_0))
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
						if (method_1(num5, out var short_1))
						{
							if (short_1 == short_0)
							{
								break;
							}
							if (num < num2)
							{
								if (short_0 > short_1)
								{
									num3 = num5;
								}
								else
								{
									num4 = num5;
								}
							}
							else if (short_0 < short_1)
							{
								num3 = num5;
							}
							else
							{
								num4 = num5;
							}
							continue;
						}
						ushort_0 = 0;
						return false;
					}
					ushort_0 = num5;
					return true;
				}
			}
			ushort_0 = 0;
			return false;
		}
	}

	public BezierCurve(Framework framework, string name, SettingOrSpecialObject parentSettingOrSpecialObject, string parentModuleName)
		: base(framework, name, parentSettingOrSpecialObject, parentModuleName)
	{
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		HashSet<DataIdAndAttrId> hashSet = new HashSet<DataIdAndAttrId>();
		Setting setting = (Setting)method_1()[0];
		Setting setting2 = (Setting)method_1()[1];
		hashSet.Add(setting.method_69());
		hashSet.Add(setting2.method_69());
		return hashSet;
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		Form23.form23_0.control25_0.method_28(this, Enum38.const_9, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		node.Checked = ((Setting)method_1()[0]).method_96();
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		Setting setting = (Setting)method_1()[0];
		Setting setting2 = (Setting)method_1()[1];
		setting.method_97(node.Checked);
		setting2.method_97(node.Checked);
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		skipThisTreeNode = true;
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		Setting setting = (Setting)method_1()[0];
		Setting setting2 = (Setting)method_1()[1];
		Setting setting3 = importFramework.method_31(setting.method_64());
		Setting setting4 = importFramework.method_31(setting2.method_64());
		if (!bothFrameworksUnlockedOrPasswordsMatch && ((destinationFrameworkLocked && setting.method_96()) || (importFrameworkLocked && (setting3 == null || setting3.method_96()))))
		{
			skipThisTreeNode = true;
			return;
		}
		userAccessibleIdsInDestFramework.Add(setting.method_69());
		userAccessibleIdsInDestFramework.Add(setting2.method_69());
		if (setting3 != null && setting4 != null && (!setting.method_282(setting3) || !setting2.method_282(setting4)))
		{
			treeNodesWithDifferences.Add(node);
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		Setting setting = (Setting)method_1()[0];
		Setting setting2 = (Setting)method_1()[1];
		if (!bothFrameworksUnlockedOrPasswordsMatch && importFrameworkLocked && setting.method_96())
		{
			skipThisTreeNode = true;
			return;
		}
		userAccessibleIdsInImportFramework.Add(setting.method_69());
		userAccessibleIdsInImportFramework.Add(setting2.method_69());
		if (!userAccessibleIdsInDestFramework.Contains(setting.method_69()) || !userAccessibleIdsInDestFramework.Contains(setting2.method_69()))
		{
			equivalentNodeExistsInDestMap = false;
		}
	}

	public bool NodeShouldBeOrange(TreeNode node, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework)
	{
		Setting setting = (Setting)method_1()[0];
		Setting setting2 = (Setting)method_1()[1];
		if (userAccessibleIdsInImportFramework.Contains(setting.method_69()) && userAccessibleIdsInImportFramework.Contains(setting2.method_69()))
		{
			return false;
		}
		return true;
	}

	public void ImportFromAnotherFramework(Framework importFramework, bool markForWrite)
	{
		Setting setting = (Setting)method_1()[0];
		Setting setting2 = (Setting)method_1()[1];
		setting.method_113(importFramework, markForWrite);
		setting2.method_113(importFramework, markForWrite);
	}

	public static bool ETCBezierToTableRedundancyIsOK(Framework importFramework, Framework destFramework)
	{
		Setting setting = importFramework.method_31(2821);
		Setting setting2 = importFramework.method_31(2830);
		if (setting != null && setting2 != null)
		{
			Setting setting3 = destFramework.method_31(14206);
			Setting setting4 = destFramework.method_31(13876);
			Setting setting5 = destFramework.method_31(13899);
			Setting setting6 = destFramework.method_31(14203);
			Setting setting7 = destFramework.method_31(13945);
			Setting setting8 = destFramework.method_31(14201);
			if (setting3 != null && setting7 != null && setting4 != null && setting5 != null && setting6 != null)
			{
				bool flag = setting8 != null && setting8.method_256() != 0;
				bool flag2 = setting7.method_256() != 0;
				if (setting4.method_256() == 0 || flag2 || flag)
				{
					return false;
				}
				int num = setting5.method_256();
				if (num > setting6.method_242()[2])
				{
					return false;
				}
				int num2 = setting.method_258(0);
				int num3 = setting2.method_258(0);
				int num4 = setting.method_258(1);
				int num5 = setting2.method_258(1);
				Class257 @class = new Class257(0, 1000);
				Class257 class2 = new Class257(0, 1000);
				@class.method_0((short)num2, (short)num4);
				class2.method_0((short)num3, (short)num5);
				for (int i = 0; i < num; i++)
				{
					int num6 = setting6.method_258(i);
					int num7 = setting3.method_257(i, 0, 0);
					if (@class.method_2((short)num6, out var ushort_))
					{
						if (class2.method_1(ushort_, out var short_))
						{
							if (class2.method_2((short)num7, out var ushort_2))
							{
								if (@class.method_1(ushort_2, out var short_2))
								{
									if (Math.Abs(num7 - short_) > 8 && Math.Abs(num6 - short_2) > 8)
									{
										return false;
									}
									continue;
								}
								return false;
							}
							return false;
						}
						return false;
					}
					return false;
				}
			}
		}
		return true;
	}

	private static bool smethod_4(short short_0, short short_1, short short_2)
	{
		if (short_0 <= short_1)
		{
			if (short_0 <= short_2 && short_2 <= short_1)
			{
				return true;
			}
		}
		else if (short_0 >= short_2 && short_2 >= short_1)
		{
			return true;
		}
		return false;
	}
}
