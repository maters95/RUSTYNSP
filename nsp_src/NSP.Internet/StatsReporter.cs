using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Timers;
using System.Xml;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using Microsoft.Win32;
using NSP.SettingsFramework;

namespace NSP.Internet;

public class StatsReporter
{
	private enum A
	{
		Bst,
		BsU,
		Bsu,
		BsV
	}

	private enum a
	{
		Bsv,
		BsW,
		Bsw
	}

	private class B
	{
		public string BsX;

		public object Bsx;
	}

	private int[] BDA;

	private int[] BDa;

	private Timer BDB;

	private List<KeyValuePair<string, object>> BDb;

	private List<KeyValuePair<string, object>> BDC;

	private List<KeyValuePair<string, object>> BDc;

	private static readonly object BDD = new object();

	private static bool BDd = false;

	public bool UserOptInPrivacy
	{
		get
		{
			return A();
		}
		set
		{
			A(value);
		}
	}

	public Version LastAgreedPrivacyDocumentVer
	{
		get
		{
			return a();
		}
		set
		{
			A(value);
		}
	}

	public static bool StatsStorageInProgress => BDd;

	private bool A()
	{
		try
		{
			int num = 0;
			RegistryKey val = RegistryKey.OpenBaseKey((RegistryHive)(-2147483647), (RegistryView)0);
			try
			{
				RegistryKey val2 = val.OpenSubKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cb());
				try
				{
					if (val2 != null)
					{
						object value = val2.GetValue(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXu());
						if (value != null)
						{
							num = (int)value;
						}
					}
					else
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXV(), true);
					}
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
			return num == 1;
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXv() + ex.Message, true);
			return false;
		}
	}

	private void A(bool P_0)
	{
		int num = (P_0 ? 1 : 0);
		try
		{
			RegistryKey val = RegistryKey.OpenBaseKey((RegistryHive)(-2147483647), (RegistryView)0);
			try
			{
				RegistryKey val2 = val.CreateSubKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cb(), true);
				try
				{
					if (val2 != null)
					{
						val2.SetValue(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXu(), (object)num);
					}
					else
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXW(), true);
					}
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXw() + ex.Message, true);
		}
	}

	public bool UserPrivacyOptionRegistryExists()
	{
		try
		{
			RegistryKey val = RegistryKey.OpenBaseKey((RegistryHive)(-2147483647), (RegistryView)0);
			try
			{
				RegistryKey val2 = val.OpenSubKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cb());
				try
				{
					if (val2 != null)
					{
						return val2.GetValue(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXu()) != null;
					}
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXX(), true);
					return false;
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXx() + ex.Message, true);
			return false;
		}
	}

	private Version a()
	{
		try
		{
			Version result = null;
			RegistryKey val = RegistryKey.OpenBaseKey((RegistryHive)(-2147483647), (RegistryView)0);
			try
			{
				RegistryKey val2 = val.OpenSubKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cb());
				try
				{
					if (val2 != null)
					{
						object value = val2.GetValue(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXY());
						if (value != null && !Version.TryParse((string)value, ref result))
						{
							result = null;
						}
					}
					else
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXy(), true);
					}
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
			return result;
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXZ() + ex.Message, true);
			return null;
		}
	}

	private void A(Version P_0)
	{
		try
		{
			RegistryKey val = RegistryKey.OpenBaseKey((RegistryHive)(-2147483647), (RegistryView)0);
			try
			{
				RegistryKey val2 = val.CreateSubKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cb(), true);
				try
				{
					if (val2 != null)
					{
						val2.SetValue(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXY(), (object)P_0);
					}
					else
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXz(), true);
					}
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axA() + ex.Message, true);
		}
	}

	public bool LastAgreedPrivacyDocVerRegistryEntryExists()
	{
		try
		{
			Version val = null;
			RegistryKey val2 = RegistryKey.OpenBaseKey((RegistryHive)(-2147483647), (RegistryView)0);
			try
			{
				RegistryKey val3 = val2.OpenSubKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cb());
				try
				{
					if (val3 != null)
					{
						object value = val3.GetValue(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXY());
						if (value != null && !Version.TryParse((string)value, ref val))
						{
							val = null;
						}
					}
					else
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axa(), true);
					}
				}
				finally
				{
					((System.IDisposable)val3)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
			return val != (Version)null;
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axB() + ex.Message, true);
			return false;
		}
	}

	public void DeleteLastAgreedPrivacyDocVerRegistryEntry()
	{
		try
		{
			RegistryKey val = RegistryKey.OpenBaseKey((RegistryHive)(-2147483647), (RegistryView)0);
			try
			{
				RegistryKey val2 = val.OpenSubKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cb(), true);
				try
				{
					if (val2 != null)
					{
						val2.DeleteValue(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXY());
					}
					else
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axb(), true);
					}
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axC() + ex.Message, true);
		}
	}

	public StatsReporter()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		int[] array = new int[4];
		RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		BDA = array;
		int[] array2 = new int[5];
		RuntimeHelpers.InitializeArray((System.Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		BDa = array2;
		base._002Ector();
		BDB = new Timer();
		BDB.Interval = 10000.0;
		BDB.Elapsed += new ElapsedEventHandler(A);
		BDB.Start();
	}

	private static B A(string P_0, object P_1)
	{
		return new B
		{
			BsX = P_0,
			Bsx = P_1
		};
	}

	private void B()
	{
		string aXc = BM.Qz.aXc;
		int awZ = BM.Qz.awZ;
		int awz = BM.Qz.awz;
		string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axc();
		if (UserOptInPrivacy)
		{
			text = aXc;
		}
		List<B> val = new List<B>();
		val.Add(A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avt(), (object)text));
		val.Add(A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axD(), (object)awZ));
		val.Add(A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agI(), (object)awz));
		val.Add(A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axd(), (object)(-1)));
		val.Add(A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axE(), (object)0));
		BDb = new List<KeyValuePair<string, object>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, object>>)A(val));
	}

	private void b()
	{
		List<B> val = new List<B>();
		val.Add(A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axe(), (object)BM.Qz.aXA.A()));
		val.Add(A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axF(), (object)BM.Qz.aXA.a()));
		val.Add(A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axf(), (object)BM.Qz.aXA.B()));
		val.Add(A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axG(), (object)BM.Qz.aXA.b()));
		val.Add(A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axg(), (object)BM.Qz.aXA.C()));
		val.Add(A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axH(), (object)(-1)));
		BDC = new List<KeyValuePair<string, object>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, object>>)A(val));
	}

	private void A(List<SettingOrSpecialObject> P_0, List<B> P_1)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_0[i];
			if (settingOrSpecialObject is Setting)
			{
				Setting setting = settingOrSpecialObject as Setting;
				int num = setting.Ba();
				bool flag = ((SettingOrSpecialObject)setting).D() is Table || ((SettingOrSpecialObject)setting).D() is TableAxis;
				bool num2 = Enumerable.Contains<int>((System.Collections.Generic.IEnumerable<int>)BDA, setting.A());
				bool flag2 = Enumerable.Contains<int>((System.Collections.Generic.IEnumerable<int>)BDa, setting.A());
				if (!num2 && !flag && !setting.Y() && (flag2 || !setting.aJ()))
				{
					if (setting.c() == 0)
					{
						if (num == 1)
						{
							P_1.Add(A(setting.A().ToString(), (object)setting.ax()));
						}
						else
						{
							int[] array = new int[num];
							for (int j = 0; j < num; j++)
							{
								array[j] = setting.m(j);
							}
							P_1.Add(A(setting.A().ToString(), (object)array));
						}
					}
					else
					{
						string text = setting.ay();
						if (string.IsNullOrEmpty(text))
						{
							text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
						}
						P_1.Add(A(setting.A().ToString(), (object)text));
					}
				}
			}
			A(settingOrSpecialObject.a(), P_1);
		}
	}

	private void C()
	{
		List<B> val = new List<B>();
		A(BM.Qz.aWS, val);
		BDc = new List<KeyValuePair<string, object>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, object>>)A(val));
	}

	private List<KeyValuePair<string, object>> A(List<B> P_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		List<KeyValuePair<string, object>> val = new List<KeyValuePair<string, object>>();
		Enumerator<B> enumerator = P_0.GetEnumerator();
		try
		{
			KeyValuePair<string, object> val2 = default(KeyValuePair<string, object>);
			while (enumerator.MoveNext())
			{
				B current = enumerator.Current;
				if (current.BsX == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZH())
				{
					current.BsX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.avt();
				}
				val2._002Ector(current.BsX, current.Bsx);
				val.Add(val2);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		string text = System.DateTime.UtcNow.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahR());
		KeyValuePair<string, object> val3 = default(KeyValuePair<string, object>);
		val3._002Ector(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axh(), (object)text);
		val.Add(val3);
		return val;
	}

	private void A(object P_0, ElapsedEventArgs P_1)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		if (BM.Qz == null || !BM.Qz.c() || !BM.A(BM.Qz.aXc, true) || ((uint)BM.qI & 0x20u) != 0)
		{
			return;
		}
		bool flag = false;
		for (int i = 1; i < BM.Qz.aXc.Length; i++)
		{
			if (BM.Qz.aXc[i] != BM.Qz.aXc[i - 1])
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			BackgroundWorker val = new BackgroundWorker();
			val.DoWork += new DoWorkEventHandler(A);
			val.RunWorkerAsync();
		}
	}

	private void A(object P_0, DoWorkEventArgs P_1)
	{
		bool flag = false;
		try
		{
			Monitor.TryEnter(BDD, ref flag);
			if (flag)
			{
				B();
				b();
				C();
			}
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axI() + ex.Message, true);
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(BDD);
			}
		}
	}

	public void StorePendingStats()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		if (BDb != null && BDC != null && BDc != null && !BDd)
		{
			BDd = true;
			BackgroundWorker val = new BackgroundWorker();
			val.DoWork += new DoWorkEventHandler(a);
			val.RunWorkerAsync();
		}
	}

	private void a(object P_0, DoWorkEventArgs P_1)
	{
		lock (BDD)
		{
			c();
			BDd = false;
		}
	}

	private void c()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		try
		{
			string text = BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBL();
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string text2 = text + N.A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axi();
			MemoryStream val = new MemoryStream();
			XmlWriterSettings val2 = new XmlWriterSettings();
			val2.ConformanceLevel = (ConformanceLevel)2;
			val2.CloseOutput = false;
			val2.Indent = true;
			val2.NewLineChars = Environment.NewLine;
			XmlWriter obj = XmlWriter.Create((Stream)(object)val, val2);
			obj.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axJ());
			obj.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axj());
			A(obj, BDb);
			obj.WriteEndElement();
			obj.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axK());
			A(obj, BDC);
			obj.WriteEndElement();
			obj.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axk());
			A(obj, BDc);
			obj.WriteEndElement();
			obj.WriteEndElement();
			obj.Close();
			((Stream)val).Flush();
			((Stream)val).Position = 0L;
			StreamReader val3 = new StreamReader((Stream)(object)val);
			try
			{
				string text3 = ((TextReader)val3).ReadToEnd();
				Aes val4 = Aes.Create();
				try
				{
					((SymmetricAlgorithm)val4).Key = Encoding.UTF8.GetBytes(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axL());
					((SymmetricAlgorithm)val4).IV = new byte[16];
					((SymmetricAlgorithm)val4).Padding = (PaddingMode)3;
					ICryptoTransform val5 = ((SymmetricAlgorithm)val4).CreateEncryptor(((SymmetricAlgorithm)val4).Key, ((SymmetricAlgorithm)val4).IV);
					try
					{
						MemoryStream val6 = new MemoryStream();
						try
						{
							CryptoStream val7 = new CryptoStream((Stream)(object)val6, val5, (CryptoStreamMode)1);
							try
							{
								StreamWriter val8 = new StreamWriter((Stream)(object)val7);
								try
								{
									((TextWriter)val8).Write(text3);
								}
								finally
								{
									((System.IDisposable)val8)?.Dispose();
								}
								byte[] array = val6.ToArray();
								File.WriteAllBytes(text2, array);
							}
							finally
							{
								((System.IDisposable)val7)?.Dispose();
							}
						}
						finally
						{
							((System.IDisposable)val6)?.Dispose();
						}
					}
					finally
					{
						((System.IDisposable)val5)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val4)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
			File.SetAttributes(text2, (FileAttributes)2);
			((Stream)val).Close();
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axl() + ex.Message + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl(), true);
		}
	}

	private static void A(XmlWriter P_0, List<KeyValuePair<string, object>> P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<KeyValuePair<string, object>> enumerator = P_1.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, object> current = enumerator.Current;
				P_0.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axM());
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bt(), current.Key);
				if (current.Value is string)
				{
					string text = current.Value as string;
					text = text.Replace('\\', ' ').Replace('/', ' ').Replace('<', ' ')
						.Replace('>', ' ')
						.Replace('\0', ' ');
					P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axm(), text);
				}
				else if (current.Value is int)
				{
					P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axN(), ((int)current.Value).ToString());
				}
				else if (current.Value is int[])
				{
					int[] array = current.Value as int[];
					string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJz();
					for (int i = 0; i < array.Length; i++)
					{
						text2 += array[i];
						if (i != array.Length - 1)
						{
							text2 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ();
						}
					}
					text2 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGk();
					P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axn(), text2);
				}
				else
				{
					P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.axO(), current.Value.ToString());
				}
				P_0.WriteEndElement();
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}
}
