using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using NexusUpdaterAWS.Classes;
using NexusUpdaterAWS.Components;
using NexusUpdaterAWS.Runtime;

namespace NexusUpdaterAWS.Web;

public static class AWSOps
{
	private struct PidVid
	{
		internal int ProductId;

		internal int VariantId;

		internal PidVid(int productId, int variantId)
		{
			ProductId = productId;
			VariantId = variantId;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is PidVid otherPidVid))
			{
				return false;
			}
			if (otherPidVid.ProductId == ProductId)
			{
				return otherPidVid.VariantId == VariantId;
			}
			return false;
		}

		public static bool operator ==(PidVid a, PidVid b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(PidVid a, PidVid b)
		{
			return !a.Equals(b);
		}

		public override int GetHashCode()
		{
			return (ProductId << 8) | VariantId;
		}
	}

	private static readonly RegionEndpoint bucketRegion = RegionEndpoint.APSoutheast2;

	private static IAmazonS3 client;

	private static string bucketName
	{
		get
		{
			if (SvcRuntime.DebugMode)
			{
				return "haltechtest2";
			}
			return "haltech";
		}
	}

	public static void InitializeAWS()
	{
		if (client == null)
		{
			client = new AmazonS3Client(null, null, bucketRegion);
		}
	}

	public static async Task<(S3Object, string Error)> GetNewestNSPInstallerKey()
	{
		List<S3Object> objlist = new List<S3Object>();
		try
		{
			using CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(10.0));
			ListObjectsV2Request request = new ListObjectsV2Request
			{
				Prefix = "h-nexus-release/h-installers/NSP/NSPSetup",
				BucketName = bucketName,
				MaxKeys = 10
			};
			ListObjectsV2Response response;
			do
			{
				response = await client.ListObjectsV2Async(request, cts.Token);
				objlist.AddRange(response.S3Objects);
				request.ContinuationToken = response.NextContinuationToken;
			}
			while (response.IsTruncated);
		}
		catch (TaskCanceledException ex)
		{
			SvcRuntime.EventLog.WriteEntry("GetNewestNSPInstallerKey: " + ex.Message, (EventLogEntryType)1);
			return (null, Error: "Timed-out.\n" + ex.Message);
		}
		catch (AmazonS3Exception ex2)
		{
			SvcRuntime.EventLog.WriteEntry("GetNewestNSPInstallerKey: " + ex2.Message, (EventLogEntryType)1);
			return (null, Error: ex2.Message);
		}
		catch (Exception ex3)
		{
			SvcRuntime.EventLog.WriteEntry("GetNewestNSPInstallerKey: " + ex3.Message, (EventLogEntryType)1);
			return (null, Error: ex3.Message);
		}
		if (objlist.Count == 0)
		{
			return (null, Error: string.Empty);
		}
		Version latestversion = null;
		S3Object latestkey = null;
		foreach (S3Object s in objlist)
		{
			string[] ver = Path.GetFileNameWithoutExtension(s.Key).Split(new char[1] { '_' });
			if (ver.Length >= 2)
			{
				Version.TryParse(ver[1].Remove(0, 1), out Version currentversion);
				if (latestversion == null)
				{
					latestversion = currentversion;
					latestkey = s;
				}
				if (currentversion > latestversion)
				{
					latestversion = currentversion;
					latestkey = s;
				}
			}
		}
		return (latestkey, Error: string.Empty);
	}

	public static async Task<(S3Object, string Error)> GetNewestUpdaterInstallerKey()
	{
		List<S3Object> objlist = new List<S3Object>();
		try
		{
			using CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(10.0));
			ListObjectsV2Request request = new ListObjectsV2Request
			{
				Prefix = "h-nexus-release/h-installers/NxUpdater/NexusUpdaterSetup",
				BucketName = bucketName,
				MaxKeys = 10
			};
			ListObjectsV2Response response;
			do
			{
				response = await client.ListObjectsV2Async(request, cts.Token);
				objlist.AddRange(response.S3Objects);
				request.ContinuationToken = response.NextContinuationToken;
			}
			while (response.IsTruncated);
		}
		catch (TaskCanceledException ex)
		{
			SvcRuntime.EventLog.WriteEntry("GetNewestUpdaterInstallerKey: " + ex.Message, (EventLogEntryType)1);
			return (null, Error: "Timed-out.\n" + ex.Message);
		}
		catch (AmazonS3Exception ex2)
		{
			SvcRuntime.EventLog.WriteEntry("GetNewestUpdaterInstallerKey: " + ex2.Message, (EventLogEntryType)1);
			return (null, Error: ex2.Message);
		}
		catch (Exception ex3)
		{
			SvcRuntime.EventLog.WriteEntry("GetNewestUpdaterInstallerKey: " + ex3.Message, (EventLogEntryType)1);
			return (null, Error: ex3.Message);
		}
		if (objlist.Count == 0)
		{
			return (null, Error: string.Empty);
		}
		Version latestversion = null;
		S3Object latestkey = null;
		foreach (S3Object s in objlist)
		{
			string[] ver = Path.GetFileNameWithoutExtension(s.Key).Split(new char[1] { '_' });
			if (ver.Length >= 2)
			{
				Version.TryParse(ver[1].Remove(0, 1), out Version currentversion);
				if (latestversion == null)
				{
					latestversion = currentversion;
					latestkey = s;
				}
				if (currentversion > latestversion)
				{
					latestversion = currentversion;
					latestkey = s;
				}
			}
		}
		return (latestkey, Error: string.Empty);
	}

	public static async Task<(S3Object, string Error)> GetNewestDLVInstallerKey()
	{
		List<S3Object> objlist = new List<S3Object>();
		try
		{
			using CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(10.0));
			ListObjectsV2Request request = new ListObjectsV2Request
			{
				Prefix = "h-nexus-release/h-installers/DLV/DLVSetup",
				BucketName = bucketName,
				MaxKeys = 10
			};
			ListObjectsV2Response response;
			do
			{
				response = await client.ListObjectsV2Async(request, cts.Token);
				objlist.AddRange(response.S3Objects);
				request.ContinuationToken = response.NextContinuationToken;
			}
			while (response.IsTruncated);
		}
		catch (TaskCanceledException ex)
		{
			SvcRuntime.EventLog.WriteEntry("GetNewestDLVInstallerKey: " + ex.Message, (EventLogEntryType)1);
			return (null, Error: "Timed-out.\n" + ex.Message);
		}
		catch (AmazonS3Exception ex2)
		{
			SvcRuntime.EventLog.WriteEntry("GetNewestDLVInstallerKey: " + ex2.Message, (EventLogEntryType)1);
			return (null, Error: ex2.Message);
		}
		catch (Exception ex3)
		{
			SvcRuntime.EventLog.WriteEntry("GetNewestDLVInstallerKey: " + ex3.Message, (EventLogEntryType)1);
			return (null, Error: ex3.Message);
		}
		if (objlist.Count == 0)
		{
			return (null, Error: string.Empty);
		}
		Version latestversion = null;
		S3Object latestkey = null;
		foreach (S3Object s in objlist)
		{
			string[] ver = Path.GetFileNameWithoutExtension(s.Key).Split(new char[1] { '_' });
			if (ver.Length >= 2)
			{
				Version.TryParse(ver[1].Remove(0, 1), out Version currentversion);
				if (latestversion == null)
				{
					latestversion = currentversion;
					latestkey = s;
				}
				if (currentversion > latestversion)
				{
					latestversion = currentversion;
					latestkey = s;
				}
			}
		}
		return (latestkey, Error: string.Empty);
	}

	public static async Task<(List<LocalS3Object> Objects, string Error)> ListSupportObjectsAsync()
	{
		List<LocalS3Object> objlist = new List<LocalS3Object>();
		bool betaOptIn = GetBetaOptIn();
		try
		{
			ListObjectsV2Request request = new ListObjectsV2Request
			{
				Prefix = "h-nexus-release/h-programdata/",
				BucketName = bucketName,
				MaxKeys = 1000
			};
			ListObjectsV2Response response;
			do
			{
				using (CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(20.0)))
				{
					response = await client.ListObjectsV2Async(request, cts.Token);
				}
				foreach (S3Object entry in response.S3Objects)
				{
					if (!(Path.GetFileName(entry.Key) != string.Empty))
					{
						continue;
					}
					ComponentTypeEnum cat = ComponentTypeEnum.SupportFile;
					if (entry.Key.Contains("h-nexus-release/h-programdata/Help"))
					{
						cat = ComponentTypeEnum.Help;
					}
					if (entry.Key.Contains("h-nexus-release/h-programdata/ReleaseNotes"))
					{
						cat = ComponentTypeEnum.ReleaseNotes;
					}
					if (entry.Key.Contains("h-nexus-release/h-programdata/EULA"))
					{
						cat = ComponentTypeEnum.EULA;
					}
					if (entry.Key.Contains("h-nexus-release/h-programdata/Firmware"))
					{
						cat = ComponentTypeEnum.Firmware;
					}
					if (entry.Key.Contains("h-nexus-release/h-programdata/Definitions"))
					{
						cat = ComponentTypeEnum.Definition;
					}
					LocalS3Object localS3Obj = new LocalS3Object(entry.Key, cat, entry.LastModified, entry.Size, string.Empty);
					switch (cat)
					{
					case ComponentTypeEnum.Firmware:
					{
						string releaseStr = GetS3ObjectReleaseString(entry);
						int releaseVal;
						if (string.IsNullOrEmpty(releaseStr))
						{
							objlist.Add(localS3Obj);
						}
						else if (int.TryParse(releaseStr, out releaseVal))
						{
							bool flag = releaseVal == 0;
							bool isBetaFwVersion = releaseVal > 100 && releaseVal <= 200;
							if (flag || (isBetaFwVersion & betaOptIn))
							{
								objlist.Add(localS3Obj);
							}
						}
						break;
					}
					default:
						objlist.Add(localS3Obj);
						break;
					case ComponentTypeEnum.Definition:
						break;
					}
				}
				request.ContinuationToken = response.NextContinuationToken;
			}
			while (response.IsTruncated);
		}
		catch (TaskCanceledException ex)
		{
			SvcRuntime.EventLog.WriteEntry("ListSupportObjectsAsync: " + ex.Message, (EventLogEntryType)1);
			return (Objects: null, Error: "Timed-out.\n" + ex.Message);
		}
		catch (AmazonS3Exception ex2)
		{
			SvcRuntime.EventLog.WriteEntry("ListSupportObjectsAsync: " + ex2.Message, (EventLogEntryType)1);
			return (Objects: null, Error: "Failed to get list of remote files." + Environment.NewLine + ex2.Message);
		}
		catch (Exception ex3)
		{
			SvcRuntime.EventLog.WriteEntry("ListSupportObjectsAsync: " + ex3.Message, (EventLogEntryType)1);
			return (Objects: null, Error: "Failed to get list of remote files." + Environment.NewLine + ex3.Message);
		}
		return (Objects: objlist, Error: string.Empty);
	}

	private static bool GetBetaOptIn()
	{
		try
		{
			string filePath = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "/Haltech/", "BetaOptIn.txt");
			if (File.Exists(filePath))
			{
				return File.ReadAllText(filePath).Trim() == "BetaOptIn: True";
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	private static void GetProductVariantsFromMetaData(List<KeyValuePair<string, string>> s3ObjectUserMetadata, out PidVid singlePidVid, out List<PidVid> multiplePidsVids)
	{
		singlePidVid = new PidVid(-1, -1);
		multiplePidsVids = new List<PidVid>();
		if (s3ObjectUserMetadata == null)
		{
			return;
		}
		foreach (KeyValuePair<string, string> kv in s3ObjectUserMetadata)
		{
			int vid2;
			if (kv.Key == "productsvariants")
			{
				string[] array = kv.Value.Split(new char[1] { '-' });
				foreach (string pidvid in array)
				{
					if (!string.IsNullOrEmpty(pidvid))
					{
						try
						{
							int startOfPidVal = "pid".Length;
							int startOfVidVal = pidvid.IndexOf("vid") + "vid".Length;
							int pid = int.Parse(pidvid.Substring(startOfPidVal, pidvid.IndexOf("vid") - startOfPidVal));
							int vid = int.Parse(pidvid.Substring(startOfVidVal));
							multiplePidsVids.Add(new PidVid(pid, vid));
						}
						catch
						{
							multiplePidsVids.Clear();
							break;
						}
					}
				}
			}
			else if (kv.Key == "productid")
			{
				if (int.TryParse(kv.Value, out var pid2))
				{
					singlePidVid.ProductId = pid2;
				}
			}
			else if (kv.Key == "variantid" && int.TryParse(kv.Value, out vid2))
			{
				singlePidVid.VariantId = vid2;
			}
		}
	}

	private static VersionInfo GetVersionFromMetaData(List<KeyValuePair<string, string>> s3ObjectUserMetadata)
	{
		int major = -1;
		int minor = -1;
		int bugfix = -1;
		int release = -1;
		if (s3ObjectUserMetadata != null)
		{
			foreach (KeyValuePair<string, string> kv in s3ObjectUserMetadata)
			{
				if (kv.Key == "major")
				{
					if (!int.TryParse(kv.Value, out major))
					{
						major = -1;
					}
				}
				else if (kv.Key == "minor")
				{
					if (!int.TryParse(kv.Value, out minor))
					{
						minor = -1;
					}
				}
				else if (kv.Key == "bugfix")
				{
					if (!int.TryParse(kv.Value, out bugfix))
					{
						bugfix = -1;
					}
				}
				else if (kv.Key == "release" && !int.TryParse(kv.Value, out release))
				{
					release = -1;
				}
			}
		}
		if (major != -1 && minor != -1 && bugfix != -1 && release != -1)
		{
			return new VersionInfo(major, minor, bugfix, release);
		}
		return null;
	}

	private static async Task<List<S3Object>> ListTaggedSupportObjectsAsync(string repoFolderName)
	{
		List<S3Object> objlist = new List<S3Object>();
		List<S3Object> objlistFinal = null;
		string keyEnd = string.Empty;
		if (!string.IsNullOrEmpty(repoFolderName))
		{
			keyEnd = repoFolderName + "/";
		}
		try
		{
			ListObjectsV2Request request = new ListObjectsV2Request
			{
				Prefix = "h-nexus-release/h-programdata/" + keyEnd,
				BucketName = bucketName,
				MaxKeys = 1000
			};
			ListObjectsV2Response response;
			do
			{
				using (CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(20.0)))
				{
					response = await client.ListObjectsV2Async(request, cts.Token);
				}
				objlist.AddRange(response.S3Objects);
				request.ContinuationToken = response.NextContinuationToken;
			}
			while (response.IsTruncated);
		}
		catch (TaskCanceledException ex)
		{
			SvcRuntime.EventLog.WriteEntry("ListTaggedSupportObjectsAsync: " + ex.Message, (EventLogEntryType)1);
			return null;
		}
		catch (AmazonS3Exception ex2)
		{
			SvcRuntime.EventLog.WriteEntry("ListTaggedSupportObjectsAsync: " + ex2.Message, (EventLogEntryType)1);
			return null;
		}
		catch (Exception ex3)
		{
			SvcRuntime.EventLog.WriteEntry("ListTaggedSupportObjectsAsync: " + ex3.Message, (EventLogEntryType)1);
			return null;
		}
		if (objlist.Count > 0)
		{
			objlistFinal = new List<S3Object>();
			foreach (S3Object obj in objlist)
			{
				if (obj.Size > 0)
				{
					objlistFinal.Add(obj);
				}
			}
		}
		return objlistFinal;
	}

	private static async Task<List<S3Object>> ListDefinitionsAsync()
	{
		List<S3Object> objlist = new List<S3Object>();
		List<S3Object> objlistFinal = null;
		try
		{
			ListObjectsV2Request request = new ListObjectsV2Request
			{
				Prefix = "h-nexus-release/h-olddefinitions/",
				BucketName = bucketName,
				MaxKeys = 1000
			};
			ListObjectsV2Response response;
			do
			{
				using (CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(20.0)))
				{
					response = await client.ListObjectsV2Async(request, cts.Token);
				}
				objlist.AddRange(response.S3Objects);
				request.ContinuationToken = response.NextContinuationToken;
			}
			while (response.IsTruncated);
		}
		catch (TaskCanceledException ex)
		{
			SvcRuntime.EventLog.WriteEntry("ListDefinitionsAsync: " + ex.Message, (EventLogEntryType)1);
			return null;
		}
		catch (AmazonS3Exception ex2)
		{
			SvcRuntime.EventLog.WriteEntry("ListDefinitionsAsync: " + ex2.Message, (EventLogEntryType)1);
			return null;
		}
		catch (Exception ex3)
		{
			SvcRuntime.EventLog.WriteEntry("ListDefinitionsAsync: " + ex3.Message, (EventLogEntryType)1);
			return null;
		}
		if (objlist.Count > 0)
		{
			objlistFinal = new List<S3Object>();
			foreach (S3Object obj in objlist)
			{
				if (obj.Size > 0)
				{
					objlistFinal.Add(obj);
				}
			}
		}
		return objlistFinal;
	}

	public static async Task<List<LocalS3Object>> ListDefinitionsAsyncByMetadataAND(List<S3MetaDataKeyValuePair> requestList)
	{
		new List<S3Object>();
		List<LocalS3Object> localObjList = new List<LocalS3Object>();
		foreach (S3Object entry in await ListDefinitionsAsync())
		{
			if (Path.GetFileName(entry.Key) != string.Empty)
			{
				ComponentTypeEnum cat = ComponentTypeEnum.SupportFile;
				if (entry.Key.Contains("h-nexus-release/h-olddefinitions"))
				{
					cat = ComponentTypeEnum.OldDefinition;
				}
				string releaseString = string.Empty;
				if (S3ObjectMatchesAllRequestedMetaDataKVPs(entry, requestList, out releaseString))
				{
					LocalS3Object localS3Obj = new LocalS3Object(entry.Key, cat, entry.LastModified, entry.Size, releaseString);
					localObjList.Add(localS3Obj);
				}
			}
		}
		return localObjList;
	}

	public static async Task<List<LocalS3Object>> ListSupportObjectsAsyncByMetadataAND(string repoFolderName, List<S3MetaDataKeyValuePair> requestList, bool latestVersionOnly)
	{
		new List<S3Object>();
		List<LocalS3Object> localObjList = new List<LocalS3Object>();
		List<S3Object> list = await ListTaggedSupportObjectsAsync(repoFolderName);
		LocalS3Object latestVersionObj = null;
		VersionInfo latestVersion = null;
		foreach (S3Object entry in list)
		{
			if (!(Path.GetFileName(entry.Key) != string.Empty))
			{
				continue;
			}
			ComponentTypeEnum cat = ComponentTypeEnum.SupportFile;
			if (entry.Key.Contains("h-nexus-release/h-programdata/Help"))
			{
				cat = ComponentTypeEnum.Help;
			}
			if (entry.Key.Contains("h-nexus-release/h-programdata/ReleaseNotes"))
			{
				cat = ComponentTypeEnum.ReleaseNotes;
			}
			if (entry.Key.Contains("h-nexus-release/h-programdata/EULA"))
			{
				cat = ComponentTypeEnum.EULA;
			}
			if (entry.Key.Contains("h-nexus-release/h-programdata/Firmware"))
			{
				cat = ComponentTypeEnum.Firmware;
			}
			if (entry.Key.Contains("h-nexus-release/h-programdata/Definitions"))
			{
				cat = ComponentTypeEnum.Definition;
			}
			string releaseString = string.Empty;
			if (!S3ObjectMatchesAllRequestedMetaDataKVPs(entry, requestList, out releaseString))
			{
				continue;
			}
			LocalS3Object localS3Obj = new LocalS3Object(entry.Key, cat, entry.LastModified, entry.Size, releaseString);
			if (latestVersionOnly)
			{
				VersionInfo version = GetVersionFromMetaData(GetS3ObjectUserMetadata(entry));
				if (version != null && (latestVersion == null || version > latestVersion))
				{
					latestVersionObj = localS3Obj;
					latestVersion = version;
				}
			}
			else
			{
				localObjList.Add(localS3Obj);
			}
		}
		if (latestVersionOnly && latestVersionObj != null)
		{
			localObjList.Add(latestVersionObj);
		}
		return localObjList;
	}

	private static bool S3ObjectMatchesAllRequestedMetaDataKVPs(S3Object s3Obj, List<S3MetaDataKeyValuePair> requestList, out string releaseString)
	{
		List<KeyValuePair<string, string>> s3ObjectUserMetadata = GetS3ObjectUserMetadata(s3Obj);
		string remoteObjectReleaseString = string.Empty;
		if (s3ObjectUserMetadata == null || s3ObjectUserMetadata.Count == 0)
		{
			releaseString = string.Empty;
			return false;
		}
		foreach (KeyValuePair<string, string> kv in s3ObjectUserMetadata)
		{
			if (kv.Key == "release")
			{
				remoteObjectReleaseString = kv.Value;
			}
		}
		try
		{
			bool s3ObjectHasMultipleProductVariants = false;
			foreach (KeyValuePair<string, string> item in s3ObjectUserMetadata)
			{
				if (item.Key == "productsvariants")
				{
					s3ObjectHasMultipleProductVariants = true;
					break;
				}
			}
			bool allMatched = true;
			if (s3ObjectHasMultipleProductVariants)
			{
				foreach (S3MetaDataKeyValuePair request in requestList)
				{
					KeyValuePair<string, string> requestKVP = new KeyValuePair<string, string>(request.Key, request.Value);
					if (s3ObjectUserMetadata.Contains(requestKVP) || request.Key == "productid" || request.Key == "variantid")
					{
						continue;
					}
					if (request.Key == "productsvariants")
					{
						bool foundCorrectPidVid = false;
						foreach (KeyValuePair<string, string> s3ObjKVP in s3ObjectUserMetadata)
						{
							if (!(s3ObjKVP.Key == "productsvariants"))
							{
								continue;
							}
							string[] array = s3ObjKVP.Value.Split(new char[1] { '-' });
							foreach (string pidvid in array)
							{
								if (!string.IsNullOrEmpty(pidvid) && request.Value == pidvid.Trim())
								{
									foundCorrectPidVid = true;
									break;
								}
							}
							break;
						}
						if (!foundCorrectPidVid)
						{
							allMatched = false;
							break;
						}
						continue;
					}
					allMatched = false;
					break;
				}
			}
			else
			{
				foreach (S3MetaDataKeyValuePair request2 in requestList)
				{
					KeyValuePair<string, string> requestKVP2 = new KeyValuePair<string, string>(request2.Key, request2.Value);
					if (!s3ObjectUserMetadata.Contains(requestKVP2) && !(request2.Key == "productsvariants"))
					{
						allMatched = false;
						break;
					}
				}
			}
			if (allMatched)
			{
				releaseString = remoteObjectReleaseString;
				return true;
			}
		}
		catch (Exception)
		{
			releaseString = string.Empty;
			return false;
		}
		releaseString = string.Empty;
		return false;
	}

	private static List<KeyValuePair<string, string>> GetS3ObjectUserMetadata(S3Object s3Obj)
	{
		GetObjectMetadataRequest req = new GetObjectMetadataRequest();
		req.BucketName = bucketName;
		req.Key = s3Obj.Key;
		GetObjectMetadataResponse res = new GetObjectMetadataResponse();
		try
		{
			res = client.GetObjectMetadata(req);
			int startidx = "x-amz-meta-".Length;
			List<KeyValuePair<string, string>> s3ObjectUserMetadata = new List<KeyValuePair<string, string>>();
			foreach (string k in res.Metadata.Keys)
			{
				if (k.StartsWith("x-amz-meta-"))
				{
					string val = res.Metadata[k];
					if (!string.IsNullOrEmpty(val))
					{
						KeyValuePair<string, string> keyVal = new KeyValuePair<string, string>(k.Substring(startidx), val);
						s3ObjectUserMetadata.Add(keyVal);
					}
				}
			}
			return s3ObjectUserMetadata;
		}
		catch
		{
			return null;
		}
	}

	private static string GetS3ObjectReleaseString(S3Object s3Obj)
	{
		string releaseString = "0";
		string valString = string.Empty;
		GetObjectMetadataRequest req = new GetObjectMetadataRequest();
		GetObjectMetadataResponse res = new GetObjectMetadataResponse();
		req.BucketName = bucketName;
		req.Key = s3Obj.Key;
		new List<KeyValuePair<string, string>>();
		try
		{
			res = client.GetObjectMetadata(req);
		}
		catch
		{
			return releaseString;
		}
		int startidx = "x-amz-meta-".Length;
		foreach (string k in res.Metadata.Keys)
		{
			if (k.StartsWith("x-amz-meta-") && k.Substring(startidx).StartsWith("release"))
			{
				valString = res.Metadata[k];
				break;
			}
		}
		if (!string.IsNullOrEmpty(valString))
		{
			releaseString = valString;
		}
		return releaseString;
	}

	public static async Task<LocalS3Object> GetCurrentHelpObject()
	{
		try
		{
			ListObjectsV2Request request = new ListObjectsV2Request
			{
				Prefix = "h-nexus-release/help/Offline",
				BucketName = bucketName,
				MaxKeys = 1
			};
			ListObjectsV2Response response;
			do
			{
				response = await client.ListObjectsV2Async(request);
				foreach (S3Object s3Object in response.S3Objects)
				{
					_ = s3Object;
				}
				request.ContinuationToken = response.NextContinuationToken;
			}
			while (response.IsTruncated);
		}
		catch (AmazonS3Exception ex)
		{
			SvcRuntime.EventLog.WriteEntry("GetCurrentHelpObject: " + ex.Message, (EventLogEntryType)1);
			return null;
		}
		catch (Exception ex2)
		{
			SvcRuntime.EventLog.WriteEntry("GetCurrentHelpObject: " + ex2.Message, (EventLogEntryType)1);
			return null;
		}
		return null;
	}
}
