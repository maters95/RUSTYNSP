using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns0;
using ns2;
using ns4;
using ns6;
using ns7;

namespace ns3;

internal class Class255 : SpecialObject, Interface4
{
	internal enum Enum99
	{
		bbH = 0,
		bbh = 1,
		bbI = 4
	}

	[CompilerGenerated]
	private sealed class Class269
	{
		public string bbi;

		internal bool method_0(KeyValuePair<Enum99, (string displayName, string internalName, string parentBusName)> keyValuePair_0)
		{
			return keyValuePair_0.Value.parentBusName == bbi;
		}
	}

	internal static readonly Dictionary<Enum99, (string displayName, string internalName, string parentBusName)> BZH = new Dictionary<Enum99, (string, string, string)>
	{
		{
			Enum99.bbH,
			(Class333.BIS(), Class333.BIs(), Class333.aMf())
		},
		{
			Enum99.bbh,
			(Class333.BIT(), Class333.BIt(), Class333.aMG())
		},
		{
			Enum99.bbI,
			(Class333.BIU(), Class333.BIu(), Class333.aMg())
		}
	};

	internal HashSet<ushort> BZh = new HashSet<ushort>();

	internal HashSet<ushort> BZI = new HashSet<ushort>();

	internal HashSet<uint> BZi = new HashSet<uint>();

	internal HashSet<uint> BZJ = new HashSet<uint>();

	internal HashSet<int> BZj = new HashSet<int>();

	internal Setting BZK;

	internal Setting BZk;

	internal Setting BZL;

	internal Setting BZl;

	internal Setting BZM;

	internal Setting BZm;

	internal Setting BZN;

	internal Setting BZn;

	internal Setting BZO;

	internal Setting BZo;

	internal Setting BZP;

	internal Setting BZp;

	internal Setting BZQ;

	internal Setting BZq;

	internal Setting BZR;

	internal Setting BZr;

	internal Setting BZS;

	internal Setting BZs;

	[CompilerGenerated]
	private Dictionary<string, int> BZT = new Dictionary<string, int>();

	[CompilerGenerated]
	private DataIdAndAttrId BZt;

	[CompilerGenerated]
	private DataIdAndAttrId BZU;

	[SpecialName]
	[CompilerGenerated]
	public Dictionary<string, int> method_71()
	{
		return BZT;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_72(Dictionary<string, int> dictionary_0)
	{
		BZT = dictionary_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public DataIdAndAttrId method_73()
	{
		return BZt;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_74(DataIdAndAttrId dataIdAndAttrId_0)
	{
		BZt = dataIdAndAttrId_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public DataIdAndAttrId method_75()
	{
		return BZU;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_76(DataIdAndAttrId dataIdAndAttrId_0)
	{
		BZU = dataIdAndAttrId_0;
	}

	internal Class255(Framework framework_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_1)
		: base(framework_0, string_0, settingOrSpecialObject_0, string_1)
	{
	}

	internal static int smethod_4(string string_0)
	{
		KeyValuePair<Enum99, (string, string, string)> keyValuePair = BZH.FirstOrDefault((KeyValuePair<Enum99, (string displayName, string internalName, string parentBusName)> keyValuePair_0) => keyValuePair_0.Value.parentBusName == string_0);
		if (keyValuePair.Value.Item3 == null)
		{
			return -1;
		}
		return (int)keyValuePair.Key;
	}

	internal static string smethod_5(int int_0)
	{
		if (!BZH.ContainsKey((Enum99)int_0))
		{
			return string.Empty;
		}
		return BZH[(Enum99)int_0].displayName;
	}

	internal void method_77()
	{
		if (method_2() == Class333.BIg())
		{
			m_framework.awT = this;
		}
		else if (method_2() == Class333.BIH())
		{
			m_framework.aws = this;
		}
		else if (method_2() == Class333.BIh())
		{
			m_framework.awt = this;
		}
		for (int i = 0; i < method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = method_1()[i];
			if (settingOrSpecialObject is Setting)
			{
				if (settingOrSpecialObject.method_2().EndsWith(Class333.BII()))
				{
					BZK = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIi()))
				{
					BZk = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIJ()))
				{
					BZL = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIj()))
				{
					BZl = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIK()))
				{
					BZM = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIk()))
				{
					BZN = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIL()))
				{
					BZn = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIl()))
				{
					BZO = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIM()))
				{
					BZo = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIm()))
				{
					BZP = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIN()))
				{
					BZp = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIn()))
				{
					BZQ = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIO()))
				{
					BZq = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIo()))
				{
					BZR = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIP()))
				{
					BZr = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIp()))
				{
					BZS = settingOrSpecialObject as Setting;
				}
				else if (settingOrSpecialObject.method_2().EndsWith(Class333.BIQ()))
				{
					BZs = settingOrSpecialObject as Setting;
				}
			}
			else if (settingOrSpecialObject is SpecialObject && settingOrSpecialObject.method_2() == Class333.BIq() && settingOrSpecialObject.method_1().Count == 1 && settingOrSpecialObject.method_1()[0] is Setting && settingOrSpecialObject.method_1()[0].method_2().EndsWith(Class333.BIR()))
			{
				BZm = settingOrSpecialObject.method_1()[0] as Setting;
			}
		}
	}

	internal void method_78(HashSet<DataIdAndAttrId> hashSet_0)
	{
		bool flag = false;
		if (hashSet_0 != null && hashSet_0.Count != 0)
		{
			if (!hashSet_0.Contains(BZl.method_69()) && !hashSet_0.Contains(BZL.method_69()))
			{
				foreach (int item3 in BZj)
				{
					if (hashSet_0.Contains(new DataIdAndAttrId(item3)))
					{
						flag = true;
						break;
					}
				}
			}
			else
			{
				flag = true;
			}
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			return;
		}
		BZh.Clear();
		BZI.Clear();
		BZi.Clear();
		BZJ.Clear();
		int key;
		if (method_2() == Class333.BIg())
		{
			key = 1;
		}
		else if (method_2() == Class333.BIH())
		{
			key = 0;
		}
		else
		{
			if (!(method_2() == Class333.BIh()))
			{
				return;
			}
			key = 4;
		}
		bool flag2 = BZj.Count == 0 && (hashSet_0 == null || hashSet_0.Count == 0);
		if (m_framework.awH.ContainsKey(key))
		{
			foreach (Class270 item4 in m_framework.awH[key])
			{
				string string_ = item4.method_2();
				List<int> other = Class37.smethod_0(ref string_, m_framework);
				if (flag2)
				{
					BZj.UnionWith(other);
				}
				if (Class37.smethod_10(ref string_))
				{
					BZh.UnionWith(item4.method_6());
					BZi.UnionWith(item4.method_8());
				}
			}
		}
		if (BZl == null || BZL == null)
		{
			return;
		}
		int num = BZl.method_242()[2];
		for (int i = 0; i < num; i++)
		{
			int num2 = BZl.method_258(i);
			if (!CANFrameModel.IsFrameVisible((byte)num2) || !CANFrameModel.IsFrameEnabled((byte)num2))
			{
				continue;
			}
			int num3 = BZL.method_258(i);
			if ((num3 & 0x80000000L) == 0L)
			{
				ushort item = (ushort)(num3 & 0x7FF);
				if (BZh.Contains(item))
				{
					BZI.Add(item);
				}
				else
				{
					BZh.Add(item);
				}
			}
			else
			{
				uint item2 = (uint)(num3 & 0x7FFFFFFFL);
				if (BZi.Contains(item2))
				{
					BZJ.Add(item2);
				}
				else
				{
					BZi.Add(item2);
				}
			}
		}
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		HashSet<DataIdAndAttrId> hashSet = new HashSet<DataIdAndAttrId>();
		foreach (SettingOrSpecialObject childSettingsOrSpecialObject in m_childSettingsOrSpecialObjects)
		{
			if (childSettingsOrSpecialObject is Setting)
			{
				if (!(childSettingsOrSpecialObject as Setting).method_207())
				{
					hashSet.Add((childSettingsOrSpecialObject as Setting).method_69());
				}
				continue;
			}
			foreach (SettingOrSpecialObject item in childSettingsOrSpecialObject.method_1())
			{
				if (item is Setting && !(item as Setting).method_207())
				{
					hashSet.Add((item as Setting).method_69());
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
		Form23.form23_0.control25_0.method_28(this, Enum38.const_17, null, selectedMenuNode, fromScratch);
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
		if (BZK != null && fromFramework.method_31(BZK.method_64()) == null)
		{
			node.Tag = Class333.BIr();
		}
		else
		{
			skipThisTreeNode = true;
		}
	}

	private List<Setting> method_79(Framework framework_0)
	{
		List<Setting> list = new List<Setting>();
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			Setting setting = m_framework.method_32(item);
			Setting setting2 = framework_0.method_32(item);
			if (setting2 != null && !setting.method_282(setting2))
			{
				list.Add(setting);
			}
		}
		return list;
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		if (BZK != null)
		{
			Setting setting = importFramework.method_31(BZK.method_64());
			if (!bothFrameworksUnlockedOrPasswordsMatch && ((destinationFrameworkLocked && BZK.method_96()) || (importFrameworkLocked && (setting == null || setting.method_96()))))
			{
				skipThisTreeNode = true;
				return;
			}
			userAccessibleIdsInDestFramework.Add(BZK.method_69());
			if (setting != null && method_79(importFramework).Count != 0)
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
		if (BZK != null)
		{
			if ((!bothFrameworksUnlockedOrPasswordsMatch & importFrameworkLocked) && BZK.method_96())
			{
				skipThisTreeNode = true;
				return;
			}
			userAccessibleIdsInImportFramework.Add(BZK.method_69());
			if (!userAccessibleIdsInDestFramework.Contains(BZK.method_69()))
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
		return false;
	}

	public void ImportFromAnotherFramework(Framework importFramework, bool markForWrite)
	{
		foreach (DataIdAndAttrId item in GetIdsContained())
		{
			Setting setting = m_framework.method_32(item);
			if (setting != null && !setting.method_72())
			{
				setting.method_113(importFramework, markForWrite);
			}
		}
	}
}
