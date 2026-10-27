using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using a;

namespace NSP.SettingsFramework;

public class KnockDetection : SpecialObject, CG
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

	private static readonly string BzC = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiB();

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
				Bzc.Invoke((object)null, (EventArgs)null);
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
				Bzc.Invoke((object)null, (EventArgs)null);
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
				BzD.Invoke((object)null, (EventArgs)null);
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
				BzD.Invoke((object)null, (EventArgs)null);
			}
		}
	}

	public int[,] FFTMagnitudesForSensorsXFrequencies => BZx;

	public event EventHandler OnDisplayedFrequencyRangeChanged
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = Bzc;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref Bzc, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = Bzc;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref Bzc, val3, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler OnDisplayedMagnitudeRangeChanged
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BzD;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref BzD, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BzD;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref BzD, val3, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler OnNewFFTResult
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = Bzd;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref Bzd, val3, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = Bzd;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)value);
				val = Interlocked.CompareExchange<EventHandler>(ref Bzd, val3, val2);
			}
			while (val != val2);
		}
	}

	public KnockDetection(Framework framework, string name, SettingOrSpecialObject parentSettingOrSpecialObject, string parentModuleName)
		: base(framework, name, parentSettingOrSpecialObject, parentModuleName)
	{
		A();
	}

	private new void A()
	{
		if (File.Exists(BzC))
		{
			StreamReader val = File.OpenText(BzC);
			try
			{
				string text;
				while ((text = ((TextReader)val).ReadLine()) != null)
				{
					if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIy()))
					{
						BzB = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIy().Length));
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIZ()))
					{
						Bzb = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIZ().Length));
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIz()))
					{
						BZZ = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIz().Length));
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiA()))
					{
						BZz = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiA().Length));
					}
				}
				return;
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		BzB = 0;
		Bzb = 6000;
		BZZ = 4000;
		BZz = 12000;
	}

	public void SaveKnockDetectionPreferences()
	{
		if (!Directory.Exists(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
		{
			Directory.CreateDirectory(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
		}
		((Stream)File.Create(BzC)).Close();
		List<string> val = new List<string>();
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIy() + BzB);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIZ() + Bzb);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BIz() + BZZ);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BiA() + BZz);
		File.AppendAllLines(BzC, (System.Collections.Generic.IEnumerable<string>)val);
	}

	public void CalculateFFT(int sensorIndex, ushort[] samplesBuffer)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		if (BZv.Count == 0 && samplesBuffer != null)
		{
			Stopwatch val = new Stopwatch();
			val.Start();
			double[] array = new double[samplesBuffer.Length];
			double[] array2 = new double[samplesBuffer.Length];
			A(samplesBuffer, 0, samplesBuffer.Length, 1, array, array2);
			if (BZx == null || ((System.Array)BZx).GetLength(1) != samplesBuffer.Length / 2)
			{
				BZx = new int[2, samplesBuffer.Length / 2];
			}
			for (int i = 0; i < samplesBuffer.Length / 2; i++)
			{
				double num = array[i];
				double num2 = array2[i];
				BZx[sensorIndex, i] = (int)Math.Round(Math.Sqrt(num * num + num2 * num2) / ((double)samplesBuffer.Length / 2.0));
			}
			val.Stop();
			N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bia(), (object)val.ElapsedMilliseconds, (object)sensorIndex), false);
			if (Bzd != null)
			{
				Bzd.Invoke((object)null, (EventArgs)null);
			}
		}
	}

	private void A(ushort[] P_0, int P_1, int P_2, int P_3, double[] P_4, double[] P_5)
	{
		int num = P_2 >> 1;
		double[] array = new double[num];
		double[] array2 = new double[num];
		double[] array3 = new double[num];
		double[] array4 = new double[num];
		if (P_2 == 1)
		{
			P_4[0] = (int)P_0[P_1];
			P_5[0] = 0.0;
			return;
		}
		A(P_0, P_1, num, P_3 << 1, array, array2);
		A(P_0, P_1 + P_3, num, P_3 << 1, array3, array4);
		for (int i = 0; i < num; i++)
		{
			double num2 = array[i];
			double num3 = array2[i];
			double num4 = Math.PI * -2.0 * (double)i / (double)P_2;
			double num5 = Math.Cos(num4);
			double num6 = Math.Sin(num4);
			double num7 = array3[i];
			double num8 = array4[i];
			P_4[i] = num2 + num5 * num7 - num6 * num8;
			P_5[i] = num3 + num6 * num7 + num5 * num8;
			P_4[i + num] = num2 - num5 * num7 + num6 * num8;
			P_5[i + num] = num3 - num6 * num7 - num5 * num8;
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
			0 => m_framework.A(1927), 
			1 => m_framework.A(1310), 
			_ => null, 
		};
	}

	public Color GetColourForMagnitude(int magnitude)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2 = 4000;
		if (magnitude < num)
		{
			return Color.Black;
		}
		int num3 = Math.Min(magnitude, num2);
		int num4 = num2 - num;
		float num5 = (float)(num3 - num) / (float)num4;
		return global::A.l.A((int)((1f - num5) * 90f / 360f * 255f), 255, (int)(255f * num5));
	}

	public HashSet<DataIdAndAttrId> GetIdsContained()
	{
		HashSet<DataIdAndAttrId> obj = new HashSet<DataIdAndAttrId>();
		obj.Add(new DataIdAndAttrId(BZu));
		return obj;
	}

	public HashSet<DataIdAndAttrId> GetIdsContainedForShowingDiffs()
	{
		return GetIdsContained();
	}

	public void ShowUIControlForSelectedNode(MenuNode selectedMenuNode, bool fromScratch)
	{
		BM.QQ.rl.A(this, aE.HZ, null, selectedMenuNode, fromScratch);
	}

	public void InitPasswordProtectionNode(TreeNode node, ref bool skipThisTreeNode)
	{
		Setting setting = m_framework.A(BZu);
		node.Checked = setting.J();
	}

	public void UpdateSettingsIncludedInPasswordProtection(TreeNode node)
	{
		m_framework.A(BZu).c(node.Checked);
	}

	public void InitReleaseNotesNode(TreeNode node, Framework fromFramework, ref bool skipThisTreeNode)
	{
		skipThisTreeNode = true;
	}

	public void InitImportMapDestinationNode(TreeNode node, ref bool skipThisTreeNode, Framework importFramework, bool bothFrameworksUnlockedOrPasswordsMatch, bool destinationFrameworkLocked, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, List<TreeNode> treeNodesWithDifferences, HashSet<DataIdAndAttrId> idsAlreadyHandled, bool forceTickAll)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		Setting setting = m_framework.A(BZu);
		Setting setting2 = importFramework.A(BZu);
		if (bothFrameworksUnlockedOrPasswordsMatch || ((!destinationFrameworkLocked || !setting.J()) && (!importFrameworkLocked || (setting2 != null && !setting2.J()))))
		{
			TreeNode val = new TreeNode(((SettingOrSpecialObject)setting).A(true));
			if (forceTickAll)
			{
				val.Checked = true;
			}
			val.ForeColor = Color.Gray;
			val.Tag = setting;
			node.Nodes.Add(val);
			userAccessibleIdsInDestFramework.Add(new DataIdAndAttrId(BZu));
			if (setting2 != null && !setting.A(setting2))
			{
				treeNodesWithDifferences.Add(val);
			}
		}
		else
		{
			skipThisTreeNode = true;
		}
	}

	public void InitImportMapSourceNode(TreeNode node, ref bool skipThisTreeNode, bool bothFrameworksUnlockedOrPasswordsMatch, bool importFrameworkLocked, HashSet<DataIdAndAttrId> userAccessibleIdsInImportFramework, HashSet<DataIdAndAttrId> userAccessibleIdsInDestFramework, HashSet<DataIdAndAttrId> idsAlreadyHandled, ref bool equivalentNodeExistsInDestMap)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		Setting setting = m_framework.A(BZu);
		if (bothFrameworksUnlockedOrPasswordsMatch || !importFrameworkLocked || !setting.J())
		{
			userAccessibleIdsInImportFramework.Add(new DataIdAndAttrId(BZu));
			if (!userAccessibleIdsInDestFramework.Contains(new DataIdAndAttrId(BZu)))
			{
				TreeNode val = new TreeNode(((SettingOrSpecialObject)setting).A(true));
				val.ForeColor = BM.te;
				val.Tag = setting;
				node.Nodes.Add(val);
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
	}
}
