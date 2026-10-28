using System;
using System.Collections.Generic;
using NexusUpdaterAWS.Reporter;

namespace NexusReporter.Runtime;

public static class ReporterV2Data
{
	public static Dictionary<string, List<KeyValuePair<string, object>>> DeviceReg_PerFile = new Dictionary<string, List<KeyValuePair<string, object>>>();

	public static Dictionary<string, List<KeyValuePair<string, object>>> FWStats_PerFile = new Dictionary<string, List<KeyValuePair<string, object>>>();

	public static Dictionary<string, List<KeyValuePair<string, object>>> Settings_PerFile = new Dictionary<string, List<KeyValuePair<string, object>>>();

	public static Dictionary<string, List<KeyValuePair<string, object>>> Misc_PerFile = new Dictionary<string, List<KeyValuePair<string, object>>>();

	public static void PopulateAdditionalMiscData()
	{
		lock (UsageStatsReporting.StatsLockingObject)
		{
			Misc_PerFile.Clear();
			string timeStamp = DateTime.UtcNow.ToString("o");
			foreach (string filePath in DeviceReg_PerFile.Keys)
			{
				KeyValuePair<string, object> kvp = new KeyValuePair<string, object>("date_uploaded", timeStamp);
				Misc_PerFile[filePath] = new List<KeyValuePair<string, object>> { kvp };
			}
		}
	}

	public static void RemoveFromQueue(string filePath)
	{
		lock (UsageStatsReporting.StatsLockingObject)
		{
			if (DeviceReg_PerFile.ContainsKey(filePath))
			{
				DeviceReg_PerFile.Remove(filePath);
			}
			if (FWStats_PerFile.ContainsKey(filePath))
			{
				FWStats_PerFile.Remove(filePath);
			}
			if (Settings_PerFile.ContainsKey(filePath))
			{
				Settings_PerFile.Remove(filePath);
			}
			if (Misc_PerFile.ContainsKey(filePath))
			{
				Misc_PerFile.Remove(filePath);
			}
		}
	}

	public static void ClearAll()
	{
		lock (UsageStatsReporting.StatsLockingObject)
		{
			DeviceReg_PerFile.Clear();
			FWStats_PerFile.Clear();
			Settings_PerFile.Clear();
			Misc_PerFile.Clear();
		}
	}

	public static string GetJSONPayloadString(string filePath)
	{
		lock (UsageStatsReporting.StatsLockingObject)
		{
			string PayloadStr = string.Empty;
			string ObjName = GetStringJSON("ReporterData");
			List<List<KeyValuePair<string, object>>> listsPerStatType = new List<List<KeyValuePair<string, object>>>
			{
				DeviceReg_PerFile[filePath],
				FWStats_PerFile[filePath],
				Settings_PerFile[filePath],
				Misc_PerFile[filePath]
			};
			List<string> namesPerStatType = new List<string> { "DeviceReg", "FWStats", "Settings", "Misc" };
			for (int statTypeIndex = 0; statTypeIndex < listsPerStatType.Count; statTypeIndex++)
			{
				if (listsPerStatType[statTypeIndex] == null)
				{
					continue;
				}
				string listvalstr = string.Empty;
				for (int i = 0; i < listsPerStatType[statTypeIndex].Count; i++)
				{
					string kvstr = string.Empty;
					string namestr = GetStringJSON(listsPerStatType[statTypeIndex][i].Key);
					string valstr = string.Empty;
					if (listsPerStatType[statTypeIndex][i].Value is string[])
					{
						valstr = GetStringArrayJSONString((string[])listsPerStatType[statTypeIndex][i].Value);
					}
					else if (listsPerStatType[statTypeIndex][i].Value is int[])
					{
						valstr = GetIntArrayJSONString((int[])listsPerStatType[statTypeIndex][i].Value);
					}
					else
					{
						valstr = ((!(listsPerStatType[statTypeIndex][i].Value is string)) ? listsPerStatType[statTypeIndex][i].Value.ToString() : GetStringJSON(listsPerStatType[statTypeIndex][i].Value.ToString()));
					}
					if (!string.IsNullOrEmpty(namestr) && !string.IsNullOrEmpty(valstr))
					{
						if (i != 0)
						{
							kvstr += ", ";
						}
						kvstr = kvstr + namestr + ":" + valstr;
						listvalstr += kvstr;
					}
				}
				string PJSON = string.Empty;
				if (!string.IsNullOrEmpty(listvalstr))
				{
					if (statTypeIndex != 0)
					{
						PJSON += ", ";
					}
					PJSON = PJSON + GetStringJSON(namesPerStatType[statTypeIndex]) + ":" + EncloseinCarets(listvalstr);
				}
				if (!string.IsNullOrEmpty(PJSON))
				{
					PayloadStr += PJSON;
				}
			}
			if (!string.IsNullOrEmpty(ObjName) && !string.IsNullOrEmpty(PayloadStr))
			{
				return EncloseinCarets(ObjName + ":" + EncloseinCarets(PayloadStr));
			}
			return string.Empty;
		}
	}

	public static string GetJSONPayloadString_Flat(string filePath)
	{
		lock (UsageStatsReporting.StatsLockingObject)
		{
			List<string> kvstringlist = new List<string>();
			List<List<KeyValuePair<string, object>>> listsPerStatType = new List<List<KeyValuePair<string, object>>>
			{
				DeviceReg_PerFile[filePath],
				FWStats_PerFile[filePath],
				Settings_PerFile[filePath],
				Misc_PerFile[filePath]
			};
			for (int statTypeIndex = 0; statTypeIndex < listsPerStatType.Count; statTypeIndex++)
			{
				if (listsPerStatType[statTypeIndex] == null)
				{
					continue;
				}
				for (int i = 0; i < listsPerStatType[statTypeIndex].Count; i++)
				{
					string namestr = GetStringJSON(listsPerStatType[statTypeIndex][i].Key);
					string valstr = string.Empty;
					if (listsPerStatType[statTypeIndex][i].Value is string[])
					{
						valstr = GetStringArrayJSONString((string[])listsPerStatType[statTypeIndex][i].Value);
					}
					else if (listsPerStatType[statTypeIndex][i].Value is int[])
					{
						valstr = GetIntArrayJSONString((int[])listsPerStatType[statTypeIndex][i].Value);
					}
					else
					{
						valstr = ((!(listsPerStatType[statTypeIndex][i].Value is string)) ? listsPerStatType[statTypeIndex][i].Value.ToString() : GetStringJSON(listsPerStatType[statTypeIndex][i].Value.ToString()));
					}
					if (!string.IsNullOrEmpty(namestr) && !string.IsNullOrEmpty(valstr))
					{
						kvstringlist.Add(namestr + ":" + valstr);
					}
				}
			}
			if (kvstringlist.Count > 1)
			{
				string valstr2 = string.Empty;
				for (int j = 0; j < kvstringlist.Count; j++)
				{
					string currstr = kvstringlist[j];
					if (j != 0)
					{
						currstr = ", " + currstr;
					}
					valstr2 += currstr;
				}
				return EncloseinCarets(valstr2);
			}
			return string.Empty;
		}
	}

	private static string EncloseinCarets(string s)
	{
		return "{" + s + "}";
	}

	private static string EncloseinBrackets(string s)
	{
		return "[" + s + "]";
	}

	private static string GetStringArrayJSONString(string[] stringarray)
	{
		string arraystr = string.Empty;
		for (int i = 0; i < stringarray.Length; i++)
		{
			if (i != 0)
			{
				arraystr += ", ";
			}
			string valstr = GetStringJSON(stringarray[i]);
			arraystr += valstr;
		}
		return EncloseinBrackets(arraystr);
	}

	private static string GetIntArrayJSONString(int[] intarray)
	{
		string arraystr = string.Empty;
		for (int i = 0; i < intarray.Length; i++)
		{
			if (i != 0)
			{
				arraystr += ", ";
			}
			string valstr = intarray[i].ToString();
			arraystr += valstr;
		}
		return EncloseinBrackets(arraystr);
	}

	private static string GetStringJSON(string Text)
	{
		return "\"" + Text + "\"";
	}
}
