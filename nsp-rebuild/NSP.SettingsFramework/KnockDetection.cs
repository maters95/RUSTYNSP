using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns0;
using ns2;
using ns4;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class KnockDetection : SpecialObject, Interface4
{
	private int BZu;

	private int BZV;

	private List<int> BZv = new List<int>();

	private List<int> BZW = new List<int>();

	private int BZw = -1;

	private int BZX = -1;

	private int[,] BZx;

	public const ushort KNOCK_AUDIO_SAMPLING_FREQUENCY_HZ = 40000;

	private const int BZY = 4000;

	private const int BZy = 12000;

	private int BZZ = 4000;

	private int BZz = 12000;

	public const int MAGNITUDE_RANGE_MAX = 7000;

	private const int BzA = 4000;

	private const int Bza = 6000;

	private int BzB;

	private int Bzb = 6000;

	private static readonly string BzC = Form23.string_3 + Class333.BiB();

	[CompilerGenerated]
	private EventHandler Bzc;

	[CompilerGenerated]
	private EventHandler BzD;

	[CompilerGenerated]
	private EventHandler Bzd;

	public int DataIdOfCentreFrequencySetting
	{
		get
		{
			return BZu;
		}
		set
		{
			BZu = value;
		}
	}

	public int DataIdOfBandwidthSetting
	{
		get
		{
			return BZV;
		}
		set
		{
			BZV = value;
		}
	}

	public List<int> DataIdsOfFFTChannels => BZv;

	public List<int> DataIdsOfAngleBucketChannels => BZW;

	public int DataIdOfWindowStartAngleSetting
	{
		get
		{
			return BZw;
		}
		set
		{
			BZw = value;
		}
	}

	public int DataIdOfWindowDurationSetting
	{
		get
		{
			return BZX;
		}
		set
		{
			BZX = value;
		}
	}

	public int MinDisplayFrequencyHz
	{
		get
		{
			return BZZ;
		}
		set
		{
			BZZ = value;
			if (Bzc != null)
			{
				Bzc(null, null);
			}
		}
	}

	public int MaxDisplayFrequencyHz
	{
		get
		{
			return BZz;
		}
		set
		{
			BZz = value;
			if (Bzc != null)
			{
				Bzc(null, null);
			}
		}
	}

	public int MinDisplayMagnitude
	{
		get
		{
			return BzB;
		}
		set
		{
			BzB = value;
			if (BzD != null)
			{
				BzD(null, null);
			}
		}
	}

	public int MaxDisplayMagnitude
	{
		get
		{
			return Bzb;
		}
		set
		{
			Bzb = value;
			if (BzD != null)
			{
				BzD(null, null);
			}
		}
	}

	public int[,] FFTMagnitudesForSensorsXFrequencies => BZx;

	public event EventHandler OnDisplayedFrequencyRangeChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = Bzc;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Bzc, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = Bzc;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Bzc, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler OnDisplayedMagnitudeRangeChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = BzD;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref BzD, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = BzD;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref BzD, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler OnNewFFTResult
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = Bzd;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Bzd, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = Bzd;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Bzd, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public KnockDetection(Framework framework, string name, SettingOrSpecialObject parentSettingOrSpecialObject, string parentModuleName)
		: base(framework, name, parentSettingOrSpecialObject, parentModuleName)
	{
		method_71();
	}

	private void method_71()
	{
		if (File.Exists(BzC))
		{
			using (StreamReader streamReader = File.OpenText(BzC))
			{
				string text;
				while ((text = streamReader.ReadLine()) != null)
				{
					if (text.StartsWith(Class333.BIy()))
					{
						BzB = int.Parse(text.Substring(Class333.BIy().Length));
					}
					else if (text.StartsWith(Class333.BIZ()))
					{
						Bzb = int.Parse(text.Substring(Class333.BIZ().Length));
					}
					else if (text.StartsWith(Class333.BIz()))
					{
						BZZ = int.Parse(text.Substring(Class333.BIz().Length));
					}
					else if (text.StartsWith(Class333.BiA()))
					{
						BZz = int.Parse(text.Substring(Class333.BiA().Length));
					}
				}
				return;
			}
		}
		BzB = 0;
		Bzb = 6000;
		BZZ = 4000;
		BZz = 12000;
	}

	public void SaveKnockDetectionPreferences()
	{
		if (!Directory.Exists(Form23.string_3 + Class333.smethod_557()))
		{
			Directory.CreateDirectory(Form23.string_3 + Class333.smethod_557());
		}
		File.Create(BzC).Close();
		List<string> list = new List<string>();
		list.Add(Class333.BIy() + BzB);
		list.Add(Class333.BIZ() + Bzb);
		list.Add(Class333.BIz() + BZZ);
		list.Add(Class333.BiA() + BZz);
		File.AppendAllLines(BzC, list);
	}

	public void CalculateFFT(int sensorIndex, ushort[] samplesBuffer)
	{
		if (BZv.Count == 0 && samplesBuffer != null)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			double[] array = new double[samplesBuffer.Length];
			double[] array2 = new double[samplesBuffer.Length];
			method_72(samplesBuffer, 0, samplesBuffer.Length, 1, array, array2);
			if (BZx == null || BZx.GetLength(1) != samplesBuffer.Length / 2)
			{
				BZx = new int[2, samplesBuffer.Length / 2];
			}
			for (int i = 0; i < samplesBuffer.Length / 2; i++)
			{
				double num = array[i];
				double num2 = array2[i];
				BZx[sensorIndex, i] = (int)Math.Round(Math.Sqrt(num * num + num2 * num2) / ((double)samplesBuffer.Length / 2.0));
			}
			stopwatch.Stop();
			Class23.smethod_3(string.Format(Class333.Bia(), stopwatch.ElapsedMilliseconds, sensorIndex), bool_1: false);
			if (Bzd != null)
			{
				Bzd(null, null);
			}
		}
	}

	private void method_72(ushort[] ushort_0, int int_0, int int_1, int int_2, double[] double_0, double[] double_1)
	{
		int num = int_1 >> 1;
		double[] array = new double[num];
		double[] array2 = new double[num];
		double[] array3 = new double[num];
		double[] array4 = new double[num];
		if (int_1 == 1)
		{
			double_0[0] = (int)ushort_0[int_0];
			double_1[0] = 0.0;
			return;
		}
		method_72(ushort_0, int_0, num, int_2 << 1, array, array2);
		method_72(ushort_0, int_0 + int_2, num, int_2 << 1, array3, array4);
		for (int i = 0; i < num; i++)
		{
			double num2 = array[i];
			double num3 = array2[i];
			double num4 = Math.PI * -2.0 * (double)i / (double)int_1;
			double num5 = Math.Cos(num4);
			double num6 = Math.Sin(num4);
			double num7 = array3[i];
			double num8 = array4[i];
			double_0[i] = num2 + num5 * num7 - num6 * num8;
			double_1[i] = num3 + num6 * num7 + num5 * num8;
			double_0[i + num] = num2 - num5 * num7 + num6 * num8;
			double_1[i + num] = num3 - num6 * num7 - num5 * num8;
		}
	}

	public static int ConvertAudioSampleValueToDecibels(int sample)
	{
		int num = sample * 5000 >> 14;
		return (int)(2000.0 * Math.Log10((double)num * Math.PI / (2.0 * Math.Sqrt(2.0))));
	}

	public Setting GetKnockSensorEnabler(int sensorIndex)
	{
		return sensorIndex switch
		{
			0 => m_framework.method_31(1927), 
			1 => m_framework.method_31(1310), 
			_ => null, 
		};
	}

	public Color GetColourForMagnitude(int magnitude)
	{
		int num = 0;
		int num2 = 4000;
		if (magnitude < 0)
		{
			return Color.Black;
		}
		int num3 = Math.Min(magnitude, num2);
		int num4 = num2 - num;
		float num5 = (float)(num3 - num) / (float)num4;
		return Class18.smethod_0((int)((1f - num5) * 90f / 360f * 255f), 255, (int)(255f * num5));
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		return new HashSet<DataIdAndAttrId>
		{
			new DataIdAndAttrId(BZu)
		};
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		Form23.form23_0.control25_0.method_28(this, Enum38.const_11, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		Setting setting = m_framework.method_31(BZu);
		node.Checked = setting.method_96();
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		m_framework.method_31(BZu).method_97(node.Checked);
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		skipThisTreeNode = true;
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		Setting setting = m_framework.method_31(BZu);
		Setting setting2 = importFramework.method_31(BZu);
		if (!bothFrameworksUnlockedOrPasswordsMatch && ((destinationFrameworkLocked && setting.method_96()) || (importFrameworkLocked && (setting2 == null || setting2.method_96()))))
		{
			skipThisTreeNode = true;
			return;
		}
		TreeNode treeNode = new TreeNode(setting.method_22(bool_0: true));
		if (forceTickAll)
		{
			treeNode.Checked = true;
		}
		treeNode.ForeColor = Color.Gray;
		treeNode.Tag = setting;
		node.Nodes.Add(treeNode);
		userAccessibleIdsInDestFramework.Add(new DataIdAndAttrId(BZu));
		if (setting2 != null && !setting.method_282(setting2))
		{
			treeNodesWithDifferences.Add(treeNode);
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		Setting setting = m_framework.method_31(BZu);
		if (!bothFrameworksUnlockedOrPasswordsMatch && importFrameworkLocked && setting.method_96())
		{
			skipThisTreeNode = true;
			return;
		}
		userAccessibleIdsInImportFramework.Add(new DataIdAndAttrId(BZu));
		if (!userAccessibleIdsInDestFramework.Contains(new DataIdAndAttrId(BZu)))
		{
			TreeNode treeNode = new TreeNode(setting.method_22(bool_0: true));
			treeNode.ForeColor = Form23.color_12;
			treeNode.Tag = setting;
			node.Nodes.Add(treeNode);
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
