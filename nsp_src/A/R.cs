using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using Ionic.Zip;

namespace A;

internal class R
{
	[CompilerGenerated]
	private sealed class A : System.Collections.Generic.IEnumerable<KeyValuePair<string, int>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<KeyValuePair<string, int>>, System.Collections.IEnumerator, System.IDisposable
	{
		private int BgX;

		private KeyValuePair<string, int> Bgx;

		private int BgY;

		public R Bgy;

		private int BgZ;

		private System.Collections.Generic.IEnumerator<ZipEntry> Bgz;

		[DebuggerHidden]
		public A(int P_0)
		{
			BgX = P_0;
			BgY = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void A()
		{
			int bgX = BgX;
			if (bgX == -3 || bgX == 1)
			{
				try
				{
				}
				finally
				{
					a();
				}
			}
			Bgz = null;
			BgX = -2;
		}

		void System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				int bgX = BgX;
				R bgy = Bgy;
				switch (bgX)
				{
				default:
					return false;
				case 0:
					BgX = -1;
					BgZ = 0;
					Bgz = ((System.Collections.Generic.IEnumerable<ZipEntry>)bgy.DE.Entries).GetEnumerator();
					BgX = -3;
					break;
				case 1:
					BgX = -3;
					break;
				}
				if (((System.Collections.IEnumerator)Bgz).MoveNext())
				{
					ZipEntry current = Bgz.Current;
					Bgx = new KeyValuePair<string, int>(current.FileName, BgZ++);
					BgX = 1;
					return true;
				}
				a();
				Bgz = null;
				return false;
			}
			catch
			{
				//try-fault
				A();
				throw;
			}
		}

		bool System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void a()
		{
			BgX = -1;
			if (Bgz != null)
			{
				((System.IDisposable)Bgz).Dispose();
			}
		}

		[SpecialName]
		[DebuggerHidden]
		private KeyValuePair<string, int> B()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return Bgx;
		}

		KeyValuePair<string, int> System.Collections.Generic.IEnumerator<KeyValuePair<string, int>>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			return this.B();
		}

		[DebuggerHidden]
		private void b()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b
			this.b();
		}

		[SpecialName]
		[DebuggerHidden]
		private object C()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return Bgx;
		}

		object System.Collections.IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in C
			return this.C();
		}

		[DebuggerHidden]
		private System.Collections.Generic.IEnumerator<KeyValuePair<string, int>> c()
		{
			A result;
			if (BgX == -2 && BgY == Environment.CurrentManagedThreadId)
			{
				BgX = 0;
				result = this;
			}
			else
			{
				result = new A(0)
				{
					Bgy = Bgy
				};
			}
			return result;
		}

		System.Collections.Generic.IEnumerator<KeyValuePair<string, int>> System.Collections.Generic.IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in c
			return this.c();
		}

		[DebuggerHidden]
		private System.Collections.IEnumerator D()
		{
			return (System.Collections.IEnumerator)c();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in D
			return this.D();
		}
	}

	[CompilerGenerated]
	private sealed class a : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
	{
		private int BHA;

		private string BHa;

		private int BHB;

		public R BHb;

		private string[] BHC;

		public string[] BHc;

		private System.Collections.Generic.IEnumerator<ZipEntry> BHD;

		[DebuggerHidden]
		public a(int P_0)
		{
			BHA = P_0;
			BHB = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void A()
		{
			int bHA = BHA;
			if (bHA == -3 || bHA == 1)
			{
				try
				{
				}
				finally
				{
					a();
				}
			}
			BHD = null;
			BHA = -2;
		}

		void System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			try
			{
				int bHA = BHA;
				R bHb = BHb;
				switch (bHA)
				{
				default:
					return false;
				case 0:
					BHA = -1;
					BHD = ((System.Collections.Generic.IEnumerable<ZipEntry>)bHb.DE.Entries).GetEnumerator();
					BHA = -3;
					break;
				case 1:
					BHA = -3;
					break;
				}
				while (((System.Collections.IEnumerator)BHD).MoveNext())
				{
					string fileName = BHD.Current.FileName;
					if (fileName.EndsWith(bHb.C()))
					{
						continue;
					}
					bool flag = false;
					string[] bHC = BHC;
					foreach (string text in bHC)
					{
						if (fileName.EndsWith(text))
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						BHa = fileName;
						BHA = 1;
						return true;
					}
				}
				a();
				BHD = null;
				return false;
			}
			catch
			{
				//try-fault
				A();
				throw;
			}
		}

		bool System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void a()
		{
			BHA = -1;
			if (BHD != null)
			{
				((System.IDisposable)BHD).Dispose();
			}
		}

		[SpecialName]
		[DebuggerHidden]
		private string B()
		{
			return BHa;
		}

		string System.Collections.Generic.IEnumerator<string>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			return this.B();
		}

		[DebuggerHidden]
		private void b()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b
			this.b();
		}

		[SpecialName]
		[DebuggerHidden]
		private object C()
		{
			return BHa;
		}

		object System.Collections.IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in C
			return this.C();
		}

		[DebuggerHidden]
		private System.Collections.Generic.IEnumerator<string> c()
		{
			a a2;
			if (BHA == -2 && BHB == Environment.CurrentManagedThreadId)
			{
				BHA = 0;
				a2 = this;
			}
			else
			{
				a2 = new a(0)
				{
					BHb = BHb
				};
			}
			a2.BHC = BHc;
			return a2;
		}

		System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<string>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in c
			return this.c();
		}

		[DebuggerHidden]
		private System.Collections.IEnumerator D()
		{
			return (System.Collections.IEnumerator)c();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in D
			return this.D();
		}
	}

	private ZipFile DE;

	private string De = string.Empty;

	private string DF = string.Empty;

	private string Df = string.Empty;

	private string DG = string.Empty;

	private string Dg = string.Empty;

	internal static System.DateTime DH = new System.DateTime(1982, 1, 23, 23, 23, 23, 23, (DateTimeKind)1);

	private bool Dh = true;

	internal static R A(string P_0, string P_1, System.Collections.Generic.IEnumerable<string> P_2, string P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ZipFile val = new ZipFile();
		if (P_1 != null)
		{
			val.Password = P_1;
			val.Encryption = (EncryptionAlgorithm)3;
		}
		System.Collections.Generic.IEnumerator<string> enumerator = P_2.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				string directoryName = Path.GetDirectoryName(current.Substring(P_3.Length));
				val.AddFile(current, directoryName);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return new R(val, P_0, P_1);
	}

	internal static void A(string P_0, string P_1, string P_2, FileInfo[] P_3)
	{
		A(P_0, P_1, P_2, P_3, true);
	}

	internal static void A(string P_0, string P_1, string P_2, FileInfo[] P_3, bool P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ZipFile val = new ZipFile();
		try
		{
			val.EmitTimesInWindowsFormatWhenSaving = true;
			if (P_2 != null)
			{
				val.Password = P_2;
				val.Encryption = (EncryptionAlgorithm)3;
			}
			foreach (FileInfo val2 in P_3)
			{
				val.AddFile(((FileSystemInfo)val2).FullName, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			}
			if (P_4)
			{
				System.Collections.Generic.IEnumerator<ZipEntry> enumerator = ((System.Collections.Generic.IEnumerable<ZipEntry>)val.Entries).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						enumerator.Current.SetEntryTimes(DH, DH, DH);
					}
				}
				finally
				{
					((System.IDisposable)enumerator)?.Dispose();
				}
			}
			val.Save(P_0);
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	internal static void A(string P_0, string P_1, bool P_2, params KeyValuePair<string, byte[]>[] dataList)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		ZipFile val = new ZipFile();
		try
		{
			val.EmitTimesInWindowsFormatWhenSaving = true;
			if (P_1 != null)
			{
				val.Password = P_1;
				val.Encryption = (EncryptionAlgorithm)3;
			}
			for (int num = 0; num < dataList.Length; num++)
			{
				KeyValuePair<string, byte[]> val2 = dataList[num];
				val.AddEntry(val2.Key, val2.Value);
			}
			if (P_2)
			{
				System.Collections.Generic.IEnumerator<ZipEntry> enumerator = ((System.Collections.Generic.IEnumerable<ZipEntry>)val.Entries).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						enumerator.Current.SetEntryTimes(DH, DH, DH);
					}
				}
				finally
				{
					((System.IDisposable)enumerator)?.Dispose();
				}
			}
			val.Save(P_0);
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	internal static bool A(string P_0, string P_1, out Stream P_2, string P_3)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		P_2 = null;
		bool result = false;
		ZipFile val = new ZipFile(P_0);
		try
		{
			val.EmitTimesInWindowsFormatWhenSaving = true;
			if (P_3 != null)
			{
				val.Password = P_3;
			}
			if (val.ContainsEntry(P_1))
			{
				result = true;
				P_2 = (Stream)(object)val[P_1].OpenReader();
			}
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
		return result;
	}

	internal static bool A(Stream P_0, string P_1, out Stream P_2, string P_3)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		P_2 = null;
		bool result = false;
		P_0.Seek(0L, (SeekOrigin)0);
		ZipFile val = ZipFile.Read(P_0);
		try
		{
			val.EmitTimesInWindowsFormatWhenSaving = true;
			if (P_3 != null)
			{
				val.Password = P_3;
			}
			if (val.ContainsEntry(P_1))
			{
				result = true;
				P_2 = (Stream)new MemoryStream();
				val[P_1].Extract(P_2);
				P_2.Flush();
				P_2.Seek(0L, (SeekOrigin)0);
			}
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
		return result;
	}

	internal static bool A(string P_0)
	{
		return ZipFile.IsZipFile(P_0);
	}

	internal static bool A(Stream P_0)
	{
		long position = P_0.Position;
		P_0.Seek(0L, (SeekOrigin)0);
		bool result = ZipFile.IsZipFile(P_0, false);
		P_0.Seek(position, (SeekOrigin)0);
		return result;
	}

	internal R(Stream P_0, string P_1, string P_2)
		: this(P_0, P_1, null, P_2)
	{
	}

	internal R(Stream P_0, string P_1, string P_2, string P_3)
	{
		De = P_1;
		DE = ZipFile.Read(P_0);
		if (P_2 != null)
		{
			DE.Password = P_2;
		}
		DE.EmitTimesInWindowsFormatWhenSaving = true;
		bool flag = true;
		string text = string.Empty;
		ZipEntry val = DE[D(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.br())];
		if (val != null)
		{
			XmlReader val2 = XmlReader.Create((Stream)(object)val.OpenReader());
			while (val2.Read())
			{
				if (!val2.IsStartElement())
				{
					continue;
				}
				string name = val2.Name;
				if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bS()))
				{
					if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bs()))
					{
						if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aT()))
						{
							if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bT())
							{
								Dg = val2.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bU());
								val2.Read();
								DG = val2.Value;
							}
						}
						else
						{
							val2.Read();
							Df = val2.Value;
						}
					}
					else
					{
						val2.Read();
						DF = val2.Value;
					}
				}
				else
				{
					text = val2.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bt());
					flag = text == De;
				}
			}
			val2.Close();
		}
		if (DG != string.Empty || P_3 != null)
		{
			string[] array = A(DG, P_3);
			if (array.Length < 1)
			{
				throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bu(), (object)P_1, (object)text));
			}
			if (array.Length != DE.Count * 2)
			{
				throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bu(), (object)P_1, (object)text));
			}
			for (int num = 2; num < array.Length - 1; num++)
			{
				ZipEntry val3 = DE[array[num++]];
				if (val3 == null || val3.Crc.ToString() != array[num])
				{
					throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bu(), (object)P_1, (object)text));
				}
			}
		}
		if (!flag)
		{
			throw new System.Exception(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bu(), (object)P_1, (object)text));
		}
	}

	private R(ZipFile P_0, string P_1, string P_2)
	{
		De = P_1;
		DE = P_0;
		if (P_2 != null)
		{
			DE.Password = P_2;
		}
		DE.EmitTimesInWindowsFormatWhenSaving = true;
	}

	private string A(ZipEntry P_0, string P_1, byte[] P_2)
	{
		string text = string.Empty;
		System.Collections.Generic.IEnumerator<ZipEntry> enumerator = ((System.Collections.Generic.IEnumerable<ZipEntry>)DE.Entries).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ZipEntry current = enumerator.Current;
				if (current != P_0)
				{
					text = string.Concat(new string[5]
					{
						text,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bV(),
						current.FileName,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bV(),
						current.Crc.ToString()
					});
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return r.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bv() + text, P_1, P_2);
	}

	private string[] A(string P_0, string P_1)
	{
		if (P_1 == null || P_0.Length < 30)
		{
			return new string[0];
		}
		return r.A(P_0, P_1).Split(';', (StringSplitOptions)0);
	}

	[IteratorStateMachine(typeof(a))]
	internal System.Collections.Generic.IEnumerable<string> A(params string[] excludingExtensions)
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new a(-2)
		{
			BHb = this,
			BHc = excludingExtensions
		};
	}

	internal static List<string> A(Stream P_0, string P_1)
	{
		List<string> val = new List<string>();
		P_0.Seek(0L, (SeekOrigin)0);
		ZipFile val2 = ZipFile.Read(P_0);
		try
		{
			if (P_1 != null)
			{
				val2.Password = P_1;
			}
			System.Collections.Generic.IEnumerator<ZipEntry> enumerator = ((System.Collections.Generic.IEnumerable<ZipEntry>)val2.Entries).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					ZipEntry current = enumerator.Current;
					val.Add(current.FileName);
				}
				return val;
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val2)?.Dispose();
		}
	}

	internal bool a(string P_0)
	{
		return DE.ContainsEntry(P_0);
	}

	internal bool B(string P_0)
	{
		return DE.ContainsEntry(D(P_0));
	}

	internal MemoryStream b(string P_0)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		string text = D(P_0);
		MemoryStream val = null;
		lock (DE)
		{
			ZipEntry val2 = DE[text];
			if (val2 != null)
			{
				val = new MemoryStream();
				val2.Extract((Stream)(object)val);
				((Stream)val).Seek(0L, (SeekOrigin)0);
			}
		}
		return val;
	}

	internal MemoryStream C(string P_0)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		MemoryStream val = null;
		lock (DE)
		{
			ZipEntry val2 = DE[P_0];
			if (val2 != null)
			{
				val = new MemoryStream();
				val2.Extract((Stream)(object)val);
				((Stream)val).Seek(0L, (SeekOrigin)0);
			}
		}
		return val;
	}

	internal MemoryStream A(int P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		MemoryStream val = new MemoryStream();
		lock (DE)
		{
			DE[P_0].Extract((Stream)(object)val);
			((Stream)val).Seek(0L, (SeekOrigin)0);
			return val;
		}
	}

	[IteratorStateMachine(typeof(A))]
	internal System.Collections.Generic.IEnumerable<KeyValuePair<string, int>> A()
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new A(-2)
		{
			Bgy = this
		};
	}

	internal void A(System.DateTime P_0, System.DateTime P_1, System.DateTime P_2)
	{
		System.Collections.Generic.IEnumerator<ZipEntry> enumerator = ((System.Collections.Generic.IEnumerable<ZipEntry>)DE.Entries).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				enumerator.Current.SetEntryTimes(P_0, P_1, P_2);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	internal void A(string P_0, Stream P_1)
	{
		DE.UpdateEntry(P_0, P_1);
	}

	internal int c(string P_0)
	{
		return DE[P_0].Crc;
	}

	internal void a(Stream P_0)
	{
		if (Dh)
		{
			A(DH, DH, DH);
		}
		DE.Save(P_0);
	}

	internal void a()
	{
		if (Dh)
		{
			A(DH, DH, DH);
		}
		DE.Save();
	}

	[SpecialName]
	internal string B()
	{
		return DF;
	}

	[SpecialName]
	internal string b()
	{
		return Df;
	}

	internal string D(string P_0)
	{
		return string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bW(), (object)Path.GetFileNameWithoutExtension(P_0), (object)C());
	}

	internal virtual string C()
	{
		return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bw();
	}

	internal void c()
	{
		DE.Dispose();
	}
}
internal class r
{
	private static byte[] DI = Encoding.ASCII.GetBytes(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bz());

	private const int Di = 1000;

	internal static string A(string P_0, string P_1, byte[] P_2)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		if (string.IsNullOrEmpty(P_0))
		{
			throw new ArgumentNullException(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bX());
		}
		if (string.IsNullOrEmpty(P_1))
		{
			throw new ArgumentNullException(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bx());
		}
		string text = null;
		Aes val = null;
		try
		{
			Rfc2898DeriveBytes val2 = new Rfc2898DeriveBytes(P_1, DI, 1000, HashAlgorithmName.SHA1);
			val = Aes.Create();
			((SymmetricAlgorithm)val).Key = ((DeriveBytes)val2).GetBytes(((SymmetricAlgorithm)val).KeySize / 8);
			if (P_2 != null)
			{
				((SymmetricAlgorithm)val).IV = P_2;
			}
			ICryptoTransform val3 = ((SymmetricAlgorithm)val).CreateEncryptor(((SymmetricAlgorithm)val).Key, ((SymmetricAlgorithm)val).IV);
			MemoryStream val4 = new MemoryStream();
			try
			{
				((Stream)val4).Write(BitConverter.GetBytes(((SymmetricAlgorithm)val).IV.Length), 0, 4);
				((Stream)val4).Write(((SymmetricAlgorithm)val).IV, 0, ((SymmetricAlgorithm)val).IV.Length);
				CryptoStream val5 = new CryptoStream((Stream)(object)val4, val3, (CryptoStreamMode)1);
				try
				{
					StreamWriter val6 = new StreamWriter((Stream)(object)val5);
					try
					{
						((TextWriter)val6).Write(P_0);
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
				return Convert.ToBase64String(val4.ToArray());
			}
			finally
			{
				((System.IDisposable)val4)?.Dispose();
			}
		}
		finally
		{
			if (val != null)
			{
				((SymmetricAlgorithm)val).Clear();
			}
		}
	}

	internal static string A(string P_0, string P_1)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		if (string.IsNullOrEmpty(P_0))
		{
			throw new ArgumentNullException(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bY());
		}
		if (string.IsNullOrEmpty(P_1))
		{
			throw new ArgumentNullException(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bx());
		}
		Aes val = null;
		string text = null;
		try
		{
			Rfc2898DeriveBytes val2 = new Rfc2898DeriveBytes(P_1, DI, 1000, HashAlgorithmName.SHA1);
			MemoryStream val3 = new MemoryStream(Convert.FromBase64String(P_0));
			try
			{
				val = Aes.Create();
				((SymmetricAlgorithm)val).Key = ((DeriveBytes)val2).GetBytes(((SymmetricAlgorithm)val).KeySize / 8);
				((SymmetricAlgorithm)val).IV = A((Stream)(object)val3);
				ICryptoTransform val4 = ((SymmetricAlgorithm)val).CreateDecryptor(((SymmetricAlgorithm)val).Key, ((SymmetricAlgorithm)val).IV);
				CryptoStream val5 = new CryptoStream((Stream)(object)val3, val4, (CryptoStreamMode)0);
				try
				{
					StreamReader val6 = new StreamReader((Stream)(object)val5);
					try
					{
						return ((TextReader)val6).ReadToEnd();
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
				((System.IDisposable)val3)?.Dispose();
			}
		}
		finally
		{
			if (val != null)
			{
				((SymmetricAlgorithm)val).Clear();
			}
		}
	}

	internal static void A(byte[] P_0, string P_1, Stream P_2, byte[] P_3)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		if (P_0 == null)
		{
			throw new ArgumentNullException(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bX());
		}
		if (string.IsNullOrEmpty(P_1))
		{
			throw new ArgumentNullException(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bx());
		}
		Aes val = null;
		try
		{
			Rfc2898DeriveBytes val2 = new Rfc2898DeriveBytes(P_1, DI, 1000, HashAlgorithmName.SHA1);
			val = Aes.Create();
			((SymmetricAlgorithm)val).Key = ((DeriveBytes)val2).GetBytes(((SymmetricAlgorithm)val).KeySize / 8);
			if (P_3 != null)
			{
				((SymmetricAlgorithm)val).IV = P_3;
			}
			ICryptoTransform val3 = ((SymmetricAlgorithm)val).CreateEncryptor(((SymmetricAlgorithm)val).Key, ((SymmetricAlgorithm)val).IV);
			P_2.Write(BitConverter.GetBytes(((SymmetricAlgorithm)val).IV.Length), 0, 4);
			P_2.Write(((SymmetricAlgorithm)val).IV, 0, ((SymmetricAlgorithm)val).IV.Length);
			CryptoStream val4 = new CryptoStream(P_2, val3, (CryptoStreamMode)1);
			try
			{
				MemoryStream val5 = new MemoryStream(P_0);
				try
				{
					val5.WriteTo((Stream)(object)val4);
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
			if (val != null)
			{
				((SymmetricAlgorithm)val).Clear();
			}
		}
	}

	internal static void A(Stream P_0, string P_1, Stream P_2)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		if (P_0 == null)
		{
			throw new ArgumentNullException(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bY());
		}
		if (string.IsNullOrEmpty(P_1))
		{
			throw new ArgumentNullException(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bx());
		}
		Aes val = null;
		try
		{
			Rfc2898DeriveBytes val2 = new Rfc2898DeriveBytes(P_1, DI, 1000, HashAlgorithmName.SHA1);
			val = Aes.Create();
			((SymmetricAlgorithm)val).Key = ((DeriveBytes)val2).GetBytes(((SymmetricAlgorithm)val).KeySize / 8);
			((SymmetricAlgorithm)val).IV = A(P_0);
			ICryptoTransform val3 = ((SymmetricAlgorithm)val).CreateDecryptor(((SymmetricAlgorithm)val).Key, ((SymmetricAlgorithm)val).IV);
			CryptoStream val4 = new CryptoStream(P_0, val3, (CryptoStreamMode)0);
			try
			{
				A((Stream)(object)val4, P_2);
			}
			finally
			{
				((System.IDisposable)val4)?.Dispose();
			}
		}
		finally
		{
			if (val != null)
			{
				((SymmetricAlgorithm)val).Clear();
			}
		}
	}

	internal static void A(Stream P_0, Stream P_1)
	{
		byte[] array = new byte[32768];
		int num;
		while ((num = P_0.Read(array, 0, array.Length)) > 0)
		{
			P_1.Write(array, 0, num);
		}
	}

	private static byte[] A(Stream P_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		byte[] array = new byte[4];
		if (!N.A(P_0, array, 0, array.Length))
		{
			throw new SystemException(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.by());
		}
		byte[] array2 = new byte[BitConverter.ToInt32(array, 0)];
		if (!N.A(P_0, array2, 0, array2.Length))
		{
			throw new SystemException(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bZ());
		}
		return array2;
	}
}
