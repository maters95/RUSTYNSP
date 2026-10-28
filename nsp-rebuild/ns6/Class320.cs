using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns0;
using ns1;
using ns4;
using ns5;
using ns7;

namespace ns6;

internal static class Class320
{
	internal class Class321
	{
		internal string BTM;

		internal Class5 BTm;

		internal Class240 BTN;

		internal bool BTn;

		internal bool BTO;

		internal bool BTo;

		internal string BTP;

		internal bool BTp;

		internal bool BTQ;

		internal Enum88 BTq;

		internal Class14 BTR;

		internal Class14 BTr;

		internal bool BTS;

		internal Dictionary<Enum88, Class14> BTs;

		internal Dictionary<Enum88, Class14> BTT;

		internal Dictionary<Enum88, bool> BTt;

		internal bool BTU;

		internal List<string> BTu;

		internal List<Class319> BTV;

		internal int BTv;

		internal List<string> BTW = new List<string>();

		internal bool BTw;

		internal bool BTX;

		internal bool BTx;

		internal bool BTY;

		internal bool BTy;
	}

	private enum Enum113
	{
		BTZ,
		BTz,
		BtA,
		Bta,
		BtB,
		Btb
	}

	internal class Class322
	{
		internal bool BtC;

		internal bool Btc;

		internal bool BtD;

		internal string Btd;

		internal string BtE;

		internal bool Bte;

		internal Enum88 BtF;

		internal Class14 Btf;

		internal Class14 BtG;

		internal Dictionary<Enum88, Class14> Btg;

		internal Dictionary<Enum88, Class14> BtH;

		internal string Bth;

		internal bool BtI;

		internal int Bti;

		internal Class5 BtJ;
	}

	[CompilerGenerated]
	private static class Class323
	{
		public static DoWorkEventHandler Btj;

		public static ProgressChangedEventHandler BtK;

		public static RunWorkerCompletedEventHandler Btk;

		public static DoWorkEventHandler BtL;

		public static ProgressChangedEventHandler Btl;

		public static RunWorkerCompletedEventHandler BtM;
	}

	internal static readonly string Bdl = Form23.string_4 + Class333.aZe();

	private static bool BdM = false;

	private static Point Bdm;

	internal const uint BdN = 2u;

	internal static readonly object Bdn = new object();

	internal static bool BdO = false;

	[CompilerGenerated]
	private static EventHandler Bdo;

	private static Class319 smethod_0(Stream stream_0, Class5 class5_0, string string_0, string string_1, bool bool_0, byte byte_0, Enum88 enum88_0, string string_2, bool bool_1, string string_3)
	{
		Class319 result = null;
		try
		{
			if (string_2 == Class333.aYQ())
			{
				stream_0 = Class304.smethod_0(stream_0);
				if (stream_0 == null)
				{
					return null;
				}
			}
			Class313 @class = new Class313();
			byte[] array = null;
			using (BinaryReader binaryReader = new BinaryReader(stream_0))
			{
				@class.BDU = binaryReader.ReadUInt32();
				uint num = binaryReader.ReadUInt32();
				if (@class.BDU < 2)
				{
					@class.BDu = (Enum112)num;
					@class.BDV = 0;
				}
				else
				{
					@class.BDu = Enum112.BDk;
					@class.BDV = (byte)num;
				}
				byte int_ = binaryReader.ReadByte();
				byte int_2 = binaryReader.ReadByte();
				byte int_3 = binaryReader.ReadByte();
				byte int_4 = binaryReader.ReadByte();
				@class.BDv = new Class14(int_, int_2, int_3, int_4, 0);
				@class.BDW = binaryReader.ReadUInt32();
				@class.BDw = binaryReader.ReadUInt32();
				@class.BDX = binaryReader.ReadUInt32();
				@class.BDx = binaryReader.ReadUInt32();
				@class.BDY = binaryReader.ReadBytes(16);
				array = new byte[binaryReader.BaseStream.Length - binaryReader.BaseStream.Position];
				uint num2 = 0u;
				while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
				{
					array[num2] = binaryReader.ReadByte();
					num2++;
				}
			}
			if (array != null)
			{
				if (class5_0 != null)
				{
					if (Class242.smethod_12(class5_0.byte_4))
					{
						uint uint_ = ((@class.BDU < 2) ? uint.MaxValue : @class.BDX);
						result = new Class319(@class, array, string_2, uint_, byte.MaxValue, string_0, string_1, bool_0, enum88_0, bool_1, string_3);
					}
					else
					{
						uint num3 = @class.BDX;
						uint bDw = @class.BDw;
						while (num3 > bDw)
						{
							if (num3 > Class1.smethod_74(class5_0.string_0, Enum10.const_0))
							{
								num3 >>= 1;
								continue;
							}
							result = new Class319(@class, array, string_2, num3, byte_0, string_0, string_1, bool_0, enum88_0, bool_1, string_3);
							break;
						}
					}
				}
				else
				{
					result = new Class319(@class, array, string_2, 0u, byte.MaxValue, string_0, string_1, bool_0, enum88_0, bool_1, string_3);
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.aYq() + ex.Message);
			result = null;
		}
		return result;
	}

	private static Class319 smethod_1(string string_0, Class5 class5_0, string string_1, string string_2, bool bool_0, byte byte_0, Enum88 enum88_0, string string_3, bool bool_1, string string_4)
	{
		return smethod_0(File.Open(string_0, FileMode.Open), class5_0, string_1, string_2, bool_0, byte_0, enum88_0, string_3, bool_1, string_4);
	}

	private static Class319 smethod_2(Stream stream_0, Class5 class5_0, string string_0, ref Class240 class240_0, string string_1, ref string string_2)
	{
		Class319 result = null;
		try
		{
			byte[] array;
			using (BinaryReader binaryReader = new BinaryReader(stream_0))
			{
				array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			}
			string_2 = Class234.smethod_12(array, Class333.aYR() + string_1, out var class240_1);
			if (string_2 != null)
			{
				class240_0 = class240_1;
			}
			if (class5_0 != null)
			{
				byte[] array2 = new byte[array.Length + 4];
				array2[0] = (byte)((array.Length >>> 24) & 0xFF);
				array2[1] = (byte)((array.Length >>> 16) & 0xFF);
				array2[2] = (byte)((array.Length >>> 8) & 0xFF);
				array2[3] = (byte)(array.Length & 0xFF);
				Array.Copy(array, 0, array2, 4, array.Length);
				Class313 @class = new Class313
				{
					BDU = ((string_0 != null) ? 2u : 0u),
					BDu = Enum112.BDp,
					BDV = 0,
					BDv = new Class14(0, 0, 0, 0, 0),
					BDW = class5_0.struct1_0[3].uint_0,
					BDw = 256u,
					BDX = 8192u,
					BDx = 1000u,
					BDY = new byte[16]
				};
				uint num = @class.BDX;
				uint bDw = @class.BDw;
				while (num > bDw)
				{
					if (Class1.smethod_74(class5_0.string_0, Enum10.const_3) < num)
					{
						num >>= 1;
						continue;
					}
					result = new Class319(@class, array2, Class333.aYr(), num, byte.MaxValue, string_0, null, bool_0: true, Enum88.avK, bool_1: true, null);
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.aYS() + ex.Message);
		}
		return result;
	}

	internal static bool smethod_3(byte byte_0, byte byte_1, Class14 class14_0)
	{
		if (class14_0 == null)
		{
			return false;
		}
		if (Class242.smethod_12(byte_0))
		{
			return class14_0 >= new Class14(3, 5, 0, 2, 0);
		}
		switch (byte_0)
		{
		case 20:
			return class14_0 >= new Class14(1, 18, 0, 2, 0);
		default:
			return false;
		case 21:
		case 24:
		case 25:
			return true;
		}
	}

	internal static bool smethod_4(Enum88 enum88_0)
	{
		switch (enum88_0)
		{
		case Enum88.aWA:
			return false;
		case Enum88.avk:
		case Enum88.avL:
			return true;
		case Enum88.avl:
		case Enum88.avM:
		case Enum88.avm:
		case Enum88.avN:
			return true;
		default:
			return false;
		case Enum88.avn:
		case Enum88.avO:
		case Enum88.avp:
		case Enum88.avQ:
		case Enum88.avq:
			return true;
		case Enum88.avR:
			return false;
		case Enum88.avr:
		case Enum88.avS:
		case Enum88.avs:
		case Enum88.avT:
			return false;
		case Enum88.avt:
			return false;
		case Enum88.avU:
		case Enum88.avu:
		case Enum88.avV:
		case Enum88.avv:
			return true;
		case Enum88.avW:
		case Enum88.avw:
		case Enum88.avX:
		case Enum88.avx:
		case Enum88.avY:
		case Enum88.avy:
			return true;
		}
	}

	internal static bool smethod_5(Enum88 enum88_0, Class14 class14_0, Class14 class14_1, bool bool_0)
	{
		switch (enum88_0)
		{
		case Enum88.avn:
		case Enum88.avO:
		case Enum88.avp:
		case Enum88.avQ:
		case Enum88.avq:
			if (!(class14_0 == null) && !(class14_1 == null))
			{
				if (class14_0.method_0() != 1)
				{
					return class14_0.method_0() == class14_1.method_0();
				}
				return false;
			}
			return false;
		default:
			return true;
		case Enum88.avU:
		case Enum88.avu:
		case Enum88.avV:
		case Enum88.avv:
			if (!(class14_0 == null) && !(class14_1 == null))
			{
				if (class14_0 >= smethod_6(bool_0))
				{
					return class14_1 >= smethod_6(bool_0: false);
				}
				return false;
			}
			return false;
		}
	}

	internal static Class14 smethod_6(bool bool_0)
	{
		if (bool_0)
		{
			return new Class14(1, 1, 7, 0, 0);
		}
		return new Class14(1, 12, 0, 1, 0);
	}

	internal static List<Class315> smethod_7(string string_0)
	{
		List<Class315> list = new List<Class315>();
		try
		{
			using FileStream stream_ = File.OpenRead(string_0);
			List<string> list2 = Class31.smethod_8(stream_, null);
			if (list2.Contains(Class333.aYs()))
			{
				Class308 @class = null;
				try
				{
					if (Class31.smethod_5(stream_, Class333.aYs(), out var stream_2, null))
					{
						@class = new Class308(stream_2);
					}
				}
				catch
				{
					@class = null;
				}
				if (@class != null)
				{
					foreach (Class308.Class311 item in @class.BDj)
					{
						string text = null;
						text = ((item.BTJ == null) ? Class333.aYT() : item.BTJ);
						string bdb = null;
						if (list2.Contains(text))
						{
							Stream stream_3 = null;
							if (Class31.smethod_5(stream_, text, out stream_3, null))
							{
								byte[] bytes;
								using (BinaryReader binaryReader = new BinaryReader(stream_3))
								{
									bytes = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
								}
								bdb = Encoding.GetEncoding(65001).GetString(bytes).TrimEnd('\0');
								bdb = bdb.Replace('\r', ' ');
							}
						}
						Class14 class2 = null;
						foreach (Class308.Class309 item2 in item.BTj)
						{
							if (string.IsNullOrEmpty(item2.BTB) || !list2.Contains(item2.BTB))
							{
								continue;
							}
							Stream stream_4 = null;
							if (Class31.smethod_5(stream_, item2.BTB, out stream_4, null))
							{
								Class319 class3 = smethod_0(stream_4, null, null, null, bool_0: false, byte.MaxValue, Enum88.avK, null, bool_1: false, null);
								if (class3 != null)
								{
									class2 = class3.BdG.BDv;
									break;
								}
							}
						}
						if (!(class2 != null))
						{
							continue;
						}
						foreach (Enum88 item3 in item.BTi)
						{
							Class315 class4 = new Class315();
							class4.Bda = item3;
							class4.BdB = class2;
							class4.Bdb = bdb;
							list.Add(class4);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.aYt() + ex.Message);
		}
		return list;
	}

	internal static List<Class314> smethod_8(string string_0)
	{
		List<Class314> list = new List<Class314>();
		using (FileStream fileStream = File.OpenRead(string_0))
		{
			List<string> list2 = Class31.smethod_8(fileStream, null);
			if (list2.Contains(Class333.aYs()))
			{
				smethod_9(fileStream, list2, list);
			}
			else
			{
				smethod_10(fileStream, list2, list);
			}
		}
		return list;
	}

	private static void smethod_9(FileStream fileStream_0, List<string> list_0, List<Class314> list_1)
	{
		Class308 @class = null;
		try
		{
			if (Class31.smethod_5(fileStream_0, Class333.aYs(), out var stream_, null))
			{
				@class = new Class308(stream_);
			}
		}
		catch
		{
			@class = null;
		}
		if (@class == null)
		{
			return;
		}
		bool flag = false;
		foreach (Class308.Class310 item2 in @class.BDJ)
		{
			if (item2.BTH != null)
			{
				flag = true;
				break;
			}
		}
		foreach (Class308.Class310 item3 in @class.BDJ)
		{
			string string_ = null;
			Class240 class240_ = null;
			if (item3.BTg != null)
			{
				if (!list_0.Contains(item3.BTg))
				{
					throw new Exception(Class333.aYv());
				}
				Stream stream_2 = null;
				if (Class31.smethod_5(fileStream_0, item3.BTg, out stream_2, null))
				{
					smethod_2(stream_2, null, null, ref class240_, item3.BTg, ref string_);
					if (class240_ == null)
					{
						string_ = null;
						throw new Exception(Class333.aYU());
					}
					if (class240_.axS != item3.BTF || class240_.axs != item3.BTf)
					{
						string_ = null;
						throw new Exception(Class333.aYu());
					}
					if (class240_.axT != @class.BDi)
					{
						string_ = null;
						throw new Exception(Class333.aYV());
					}
				}
			}
			string text = null;
			if (item3.BTH != null)
			{
				text = item3.BTH;
			}
			else if (!flag)
			{
				text = Class333.aYT();
			}
			string bDz = null;
			if (text != null && list_0.Contains(text))
			{
				Stream stream_3 = null;
				if (Class31.smethod_5(fileStream_0, text, out stream_3, null))
				{
					byte[] bytes;
					using (BinaryReader binaryReader = new BinaryReader(stream_3))
					{
						bytes = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					}
					bDz = Encoding.GetEncoding(65001).GetString(bytes).TrimEnd('\0');
					bDz = bDz.Replace('\r', ' ');
				}
			}
			Class240 class2 = new Class240
			{
				axS = item3.BTF,
				axs = item3.BTf
			};
			if (item3.BTg != null)
			{
				class2.axT = @class.BDi;
			}
			else if (@class.BDJ.Count == 1)
			{
				class2.axT = @class.BDi;
			}
			else
			{
				int num = item3.BTh.Count - 1;
				while (num >= 0)
				{
					Class308.Class309 class3 = item3.BTh[num];
					if (!string.IsNullOrEmpty(class3.BTc) || string.IsNullOrEmpty(class3.BTB) || !list_0.Contains(class3.BTB) || !(class3.BTb != Class333.aYW()) || !(class3.BTb != Class333.aYw()))
					{
						num--;
						continue;
					}
					if (Class31.smethod_5(fileStream_0, class3.BTB, out var stream_4, null))
					{
						Class319 class4 = smethod_0(stream_4, null, class3.BTa, class3.BTc, class3.BTD, class3.BTC, Enum88.avK, class3.BTb, class3.BTd, class3.BTE);
						if (class4 != null)
						{
							class2.axT = class4.BdG.BDv;
						}
					}
					break;
				}
			}
			if (!(class240_ == null) && class240_.axt != null)
			{
				class2.axt = class240_.axt;
			}
			else if (string_ != null)
			{
				class2.axt = Class23.smethod_16(string_);
			}
			Class314 item = new Class314
			{
				BDy = class2,
				BDZ = item3.BTG,
				BDz = bDz,
				BdA = string_
			};
			list_1.Add(item);
		}
	}

	private static void smethod_10(FileStream fileStream_0, List<string> list_0, List<Class314> list_1)
	{
		Class14 @class = null;
		int num = -1;
		int num2 = -1;
		string text = null;
		string string_ = null;
		Class240 class240_ = null;
		for (int i = 0; i < list_0.Count; i++)
		{
			string text2 = list_0[i];
			Stream stream_ = null;
			if (!Class31.smethod_5(fileStream_0, text2, out stream_, null))
			{
				continue;
			}
			if (text2.EndsWith(Class333.smethod_1402()))
			{
				smethod_2(stream_, null, null, ref class240_, text2, ref string_);
				if (class240_ == null)
				{
					throw new Exception();
				}
				num = class240_.axS;
				num2 = class240_.axs;
				@class = class240_.axT;
				if (text != null)
				{
					break;
				}
			}
			else if (text2 == Class333.aYT())
			{
				byte[] bytes;
				using (BinaryReader binaryReader = new BinaryReader(stream_))
				{
					bytes = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
				}
				text = Encoding.GetEncoding(65001).GetString(bytes).TrimEnd('\0');
				text = text.Replace('\r', ' ');
				if (@class != null)
				{
					break;
				}
			}
		}
		if (@class == null)
		{
			string_ = null;
			for (int j = 0; j < list_0.Count; j++)
			{
				string string_2 = list_0[j];
				Stream stream_2 = null;
				if (Class31.smethod_5(fileStream_0, string_2, out stream_2, null))
				{
					Class319 class2 = smethod_0(stream_2, null, null, null, bool_0: false, byte.MaxValue, Enum88.avK, null, bool_1: false, null);
					if (class2 != null && class2.BdG.BDu == Enum112.BDs)
					{
						num = 22;
						num2 = 13;
						@class = class2.BdG.BDv;
						break;
					}
					if (class2 != null && class2.BdG.BDu == Enum112.BDt)
					{
						num = 22;
						num2 = 2;
						@class = class2.BdG.BDv;
						break;
					}
				}
			}
		}
		if (@class != null)
		{
			Class240 class3 = new Class240
			{
				axS = num,
				axs = num2,
				axT = @class
			};
			if (!(class240_ == null) && class240_.axt != null)
			{
				class3.axt = class240_.axt;
			}
			else if (string_ != null)
			{
				class3.axt = Class23.smethod_16(string_);
			}
			List<ushort> bDZ = smethod_11((byte)num, (byte)num2);
			Class314 item = new Class314
			{
				BDy = class3,
				BDZ = bDZ,
				BDz = text,
				BdA = string_
			};
			list_1.Add(item);
		}
	}

	private static List<ushort> smethod_11(byte byte_0, byte byte_1)
	{
		List<ushort> list = new List<ushort>();
		switch (byte_0)
		{
		case 8:
			switch (byte_1)
			{
			case 20:
				list.Add(17);
				break;
			case 19:
				list.Add(17);
				break;
			case 2:
				list.AddRange(new List<ushort> { 2, 6, 18 });
				break;
			case 3:
				list.AddRange(new List<ushort> { 3, 7, 19 });
				break;
			case 5:
				list.AddRange(new List<ushort> { 3, 7, 19 });
				break;
			case 6:
				list.Add(8);
				break;
			case 7:
				list.Add(8);
				break;
			case 11:
				list.AddRange(new List<ushort> { 2, 6, 18 });
				break;
			case 14:
				list.Add(9);
				break;
			}
			break;
		case 10:
			switch (byte_1)
			{
			case 15:
				list.Add(32);
				break;
			case 12:
				list.AddRange(new List<ushort> { 16, 48 });
				break;
			}
			break;
		case 20:
			if (byte_1 == 3)
			{
				list.Add(33280);
			}
			break;
		case 22:
			list.Add(37888);
			break;
		}
		list.Add(ushort.MaxValue);
		return list;
	}

	internal static bool smethod_12(string string_0, Class240 class240_0, out bool bool_0, out bool bool_1, out Class14 class14_0, out string string_1)
	{
		List<Class314> list = smethod_8(string_0);
		bool result = false;
		bool_0 = false;
		bool_1 = false;
		class14_0 = null;
		string_1 = null;
		foreach (Class314 item in list)
		{
			if (item.BDy != null)
			{
				Class240 bDy = item.BDy;
				class14_0 = bDy.axT;
				if (bDy == class240_0)
				{
					result = true;
					bool_0 = true;
					bool_1 = true;
					string_1 = item.BdA;
					break;
				}
				if (bDy.axS == class240_0.axS && bDy.axs == class240_0.axs)
				{
					bool_0 = true;
				}
				if (bDy.axT == class240_0.axT)
				{
					bool_1 = true;
				}
			}
		}
		return result;
	}

	internal static string smethod_13(Class240 class240_0, ushort ushort_0)
	{
		if (!Directory.Exists(Bdl))
		{
			return null;
		}
		string[] files = Directory.GetFiles(Bdl, Class333.aCe());
		foreach (string text in files)
		{
			Class318 @class = Class307.smethod_0(text);
			if (@class == null)
			{
				foreach (Class314 item in smethod_8(text))
				{
					if (item.BDy == class240_0 && item.BDZ.Contains(ushort_0))
					{
						return text;
					}
				}
				continue;
			}
			foreach (Class316 item2 in @class.BdF)
			{
				if (!(item2.BdC == class240_0) || !item2.Bdc.Contains(ushort_0))
				{
					continue;
				}
				foreach (Class314 item3 in smethod_8(text))
				{
					if (item3.BDy == class240_0 && item3.BDZ.Contains(ushort_0))
					{
						return text;
					}
				}
				break;
			}
		}
		return null;
	}

	internal static string smethod_14(Class240 class240_0)
	{
		if (!Directory.Exists(Bdl))
		{
			return null;
		}
		string[] files = Directory.GetFiles(Bdl, Class333.aCe());
		foreach (string string_ in files)
		{
			Class318 @class = Class307.smethod_0(string_);
			if (@class == null)
			{
				foreach (Class314 item in smethod_8(string_))
				{
					if (item.BDy == class240_0)
					{
						return item.BDz;
					}
				}
				continue;
			}
			foreach (Class316 item2 in @class.BdF)
			{
				if (!(item2.BdC == class240_0))
				{
					continue;
				}
				foreach (Class314 item3 in smethod_8(string_))
				{
					if (item3.BDy == class240_0)
					{
						return item3.BDz;
					}
				}
				break;
			}
		}
		return null;
	}

	internal static void smethod_15(string string_0)
	{
		try
		{
			if (!Directory.Exists(Bdl))
			{
				Directory.CreateDirectory(Bdl);
			}
			if (Directory.Exists(Bdl))
			{
				string text = Bdl + Class333.smethod_176() + Path.GetFileName(string_0);
				if (Path.GetFullPath(text) != Path.GetFullPath(string_0))
				{
					File.Copy(string_0, text, overwrite: true);
				}
			}
		}
		catch
		{
		}
	}

	internal static void smethod_16(Class5 class5_0, int int_0, int int_1, Class14 class14_0, byte[] byte_0, ushort ushort_0, bool bool_0, bool bool_1, bool bool_2, string string_0, bool bool_3, Enum88 enum88_0, Class14 class14_1, Class14 class14_2, bool bool_4, Dictionary<Enum88, Class14> dictionary_0, Dictionary<Enum88, Class14> dictionary_1, Dictionary<Enum88, bool> dictionary_2)
	{
		string text = null;
		if (class14_0 != null)
		{
			text = smethod_13(new Class240
			{
				axS = int_0,
				axs = int_1,
				axT = class14_0,
				axt = byte_0
			}, ushort_0);
		}
		if (text == null)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Bdl;
			openFileDialog.Title = Class333.smethod_1110();
			openFileDialog.Filter = Class333.smethod_1111();
			if (openFileDialog.ShowDialog(Form23.form23_0) == DialogResult.OK)
			{
				text = openFileDialog.FileName;
			}
			openFileDialog.Dispose();
		}
		if (text != null)
		{
			smethod_17(class5_0, text, bool_0, bool_1, bool_2, string_0, bool_3, bool_4: false, enum88_0, class14_1, class14_2, bool_4, dictionary_0, dictionary_1, dictionary_2, bool_6: true, null);
		}
	}

	internal static void smethod_17(Class5 class5_0, string string_0, bool bool_0, bool bool_1, bool bool_2, string string_1, bool bool_3, bool bool_4, Enum88 enum88_0, Class14 class14_0, Class14 class14_1, bool bool_5, Dictionary<Enum88, Class14> dictionary_0, Dictionary<Enum88, Class14> dictionary_1, Dictionary<Enum88, bool> dictionary_2, bool bool_6, List<string> list_0)
	{
		Form23.form23_0.statsReporter_0.StorePendingStats();
		if (enum88_0 == Enum88.avK)
		{
			Form23.smethod_87(Form23.form23_0, bool_53: false);
		}
		smethod_15(string_0);
		Class321 argument = new Class321
		{
			BTm = class5_0,
			BTM = string_0,
			BTn = bool_0,
			BTO = bool_1,
			BTo = bool_2,
			BTP = string_1,
			BTp = bool_3,
			BTQ = bool_4,
			BTq = enum88_0,
			BTR = class14_0,
			BTr = class14_1,
			BTS = bool_5,
			BTs = dictionary_0,
			BTT = dictionary_1,
			BTt = dictionary_2,
			BTU = bool_6,
			BTu = list_0
		};
		GC.Collect();
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.WorkerSupportsCancellation = false;
		backgroundWorker.DoWork += smethod_19;
		backgroundWorker.ProgressChanged += Form23.smethod_69;
		backgroundWorker.RunWorkerCompleted += smethod_29;
		Form23.smethod_66(Class333.aYX());
		backgroundWorker.RunWorkerAsync(argument);
	}

	internal static void smethod_18(Class5 class5_0, string string_0, Enum88 enum88_0)
	{
		smethod_17(class5_0, string_0, bool_0: false, bool_1: true, bool_2: false, null, bool_3: false, bool_4: true, enum88_0, null, null, bool_5: false, null, null, null, bool_6: false, null);
	}

	private static void smethod_19(object sender, DoWorkEventArgs e)
	{
		if (e.Argument is Class321)
		{
			Class321 class321_ = (Class321)e.Argument;
			Enum113 @enum = smethod_20(sender as BackgroundWorker, ref class321_);
			if (@enum == Enum113.BTZ)
			{
				e.Result = class321_;
			}
			else
			{
				e.Result = @enum;
			}
		}
		else
		{
			e.Result = null;
		}
	}

	private static Enum113 smethod_20(BackgroundWorker backgroundWorker_0, ref Class321 class321_0)
	{
		if (string.IsNullOrEmpty(class321_0.BTM))
		{
			return Enum113.BtA;
		}
		class321_0.BTV = new List<Class319>();
		backgroundWorker_0.ReportProgress(0, Class333.aYX());
		class321_0.BTw = false;
		class321_0.BTX = false;
		class321_0.BTx = false;
		class321_0.BTY = false;
		class321_0.BTy = false;
		Class240 class240_ = null;
		class321_0.BTv = 0;
		using (FileStream fileStream = File.OpenRead(class321_0.BTM))
		{
			List<string> list;
			try
			{
				list = Class31.smethod_8(fileStream, null);
			}
			catch
			{
				return Enum113.BtA;
			}
			backgroundWorker_0.ReportProgress(30);
			if (list.Contains(Class333.aYs()))
			{
				Enum113 @enum = smethod_21(backgroundWorker_0, ref class321_0, fileStream, ref class240_);
				if (@enum != Enum113.BTZ)
				{
					return @enum;
				}
			}
			else if (class321_0.BTq == Enum88.avK)
			{
				Enum113 enum2 = smethod_27(backgroundWorker_0, ref class321_0, fileStream, ref class240_, list);
				if (enum2 != Enum113.BTZ)
				{
					return enum2;
				}
			}
		}
		class321_0.BTN = class240_;
		Thread.Sleep(400);
		return Enum113.BTZ;
	}

	private static Enum113 smethod_21(BackgroundWorker backgroundWorker_0, ref Class321 class321_0, FileStream fileStream_0, ref Class240 class240_0)
	{
		Class308 @class = null;
		try
		{
			if (Class31.smethod_5(fileStream_0, Class333.aYs(), out var stream_, null))
			{
				@class = new Class308(stream_);
			}
		}
		catch
		{
			@class = null;
		}
		if (@class != null)
		{
			if (class321_0.BTq != Enum88.avK)
			{
				return smethod_24(backgroundWorker_0, ref class321_0, fileStream_0, @class);
			}
			Enum113 @enum = smethod_22(backgroundWorker_0, ref class321_0, fileStream_0, ref class240_0, @class);
			if (@enum != Enum113.BTZ)
			{
				return @enum;
			}
			return Enum113.BTZ;
		}
		return Enum113.Bta;
	}

	private static Enum113 smethod_22(BackgroundWorker backgroundWorker_0, ref Class321 class321_0, FileStream fileStream_0, ref Class240 class240_0, Class308 class308_0)
	{
		List<Class308.Class309> list = null;
		string text = null;
		foreach (Class308.Class310 item2 in class308_0.BDJ)
		{
			bool flag = item2.BTf == class321_0.BTm.byte_5 || (Form23.form23_0.string_27 != null && (class321_0.BTm.byte_5 == 0 || class321_0.BTm.byte_5 == byte.MaxValue)) || item2.BTF == 22;
			if (((item2.BTF == class321_0.BTm.byte_4 || (Form23.form23_0.string_27 != null && (class321_0.BTm.byte_4 == 0 || class321_0.BTm.byte_4 == byte.MaxValue))) & flag) && (smethod_43(class321_0.BTm.string_0) || item2.BTG.Contains(class321_0.BTm.ushort_0)))
			{
				list = item2.BTh;
				text = item2.BTg;
				break;
			}
		}
		if (list != null)
		{
			bool flag2 = false;
			List<string> list2 = new List<string>();
			for (int i = 0; i < list.Count; i++)
			{
				Class308.Class309 @class = list[i];
				if (@class.BTb != null && !list2.Contains(@class.BTb))
				{
					list2.Add(@class.BTb);
				}
			}
			List<string> list3 = new List<string>();
			int num = 0;
			while (true)
			{
				if (num < list.Count)
				{
					Class308.Class309 class2 = list[num];
					Stream stream_;
					if (string.IsNullOrEmpty(class2.BTB))
					{
						if (!string.IsNullOrEmpty(class2.BTc) && (class321_0.BTu == null || class321_0.BTu.Count == 0 || class2.BTb == null || class321_0.BTu.Contains(class2.BTb)))
						{
							Class319 item = new Class319(null, null, class2.BTb, 0u, class2.BTC, class2.BTa, class2.BTc, class2.BTD, Enum88.avK, class2.BTd, class2.BTE);
							class321_0.BTV.Add(item);
						}
					}
					else if (Class31.smethod_5(fileStream_0, class2.BTB, out stream_, null))
					{
						Class319 class3 = null;
						if (class321_0.BTu == null || class321_0.BTu.Count == 0 || class2.BTb == null || class321_0.BTu.Contains(class2.BTb))
						{
							if (!string.IsNullOrEmpty(class2.BTB) && (class2.BTB.EndsWith(Class333.smethod_1402()) || class2.BTB.EndsWith(Class333.agQ())))
							{
								flag2 = true;
								string string_ = null;
								class3 = smethod_2(stream_, class321_0.BTm, class2.BTa, ref class240_0, class2.BTB, ref string_);
								if (smethod_28(class240_0, string_))
								{
									return Enum113.BTz;
								}
							}
							else
							{
								class3 = smethod_0(stream_, class321_0.BTm, class2.BTa, class2.BTc, class2.BTD, class2.BTC, Enum88.avK, class2.BTb, class2.BTd, class2.BTE);
								if (class321_0.BTU)
								{
									Class14 class4 = null;
									if (class2.BTb != null && !smethod_48(class321_0.BTm))
									{
										if (!Class1.smethod_79(class321_0.BTm.string_0, class2.BTb, out var byte_, out var bool_) || bool_ || byte_ == null || byte_.Length < 4)
										{
											class4 = null;
										}
										else
										{
											class4 = ((class321_0.BTm.byte_4 != 21) ? new Class14(byte_[0], byte_[1], byte_[2], byte_[3], 0) : new Class14(byte_[3], byte_[2], byte_[1], byte_[0], 0));
										}
									}
									if (class4 != null && class3.BdG.BDv == class4 && class2.BTb != Class333.smethod_68() && class2.BTb != Class333.smethod_73() && class2.BTb != Class333.smethod_72() && list2.Count > 1)
									{
										class3 = null;
										list3.Add(class2.BTb);
									}
								}
								if (class2.BTb == Class333.aYW())
								{
									Class14 class5 = new Class14(class321_0.BTm.byte_12, class321_0.BTm.byte_13, class321_0.BTm.byte_14, class321_0.BTm.byte_15, 0);
									if (class3.BdG.BDv <= class5)
									{
										class3 = null;
										list3.Add(Class333.aYW());
										list3.Add(Class333.aYw());
									}
								}
							}
						}
						if (class3 != null)
						{
							if (class3.BdG.BDU < 2)
							{
								break;
							}
							class321_0.BTV.Add(class3);
						}
					}
					backgroundWorker_0.ReportProgress(30 + (num + 1) * 70 / list.Count);
					num++;
					continue;
				}
				foreach (string item3 in list3)
				{
					for (int num2 = class321_0.BTV.Count - 1; num2 >= 0; num2--)
					{
						if (class321_0.BTV[num2].BdH != null && class321_0.BTV[num2].BdH == item3)
						{
							class321_0.BTV.RemoveAt(num2);
						}
					}
				}
				if (class321_0.BTs != null && class321_0.BTs.Count != 0)
				{
					smethod_23(backgroundWorker_0, ref class321_0, fileStream_0, class308_0);
				}
				if (text != null && (class240_0 == null || !flag2))
				{
					Stream stream_2 = null;
					if (Class31.smethod_5(fileStream_0, text, out stream_2, null))
					{
						string string_2 = null;
						smethod_2(stream_2, null, null, ref class240_0, text, ref string_2);
						if (smethod_28(class240_0, string_2))
						{
							return Enum113.BTz;
						}
					}
				}
				return Enum113.BTZ;
			}
			return Enum113.Btb;
		}
		return Enum113.BtB;
	}

	private static void smethod_23(BackgroundWorker backgroundWorker_0, ref Class321 class321_0, FileStream fileStream_0, Class308 class308_0)
	{
		foreach (Class308.Class311 item in class308_0.BDj)
		{
			foreach (Enum88 item2 in item.BTi)
			{
				if (class321_0.BTs.ContainsKey(item2) && class321_0.BTt.ContainsKey(item2))
				{
					for (int i = 0; i < item.BTj.Count; i++)
					{
						smethod_26(item.BTj[i], item2, class321_0.BTs[item2], class321_0.BTt[item2], ref class321_0, fileStream_0);
						backgroundWorker_0.ReportProgress((i + 1) * 100 / item.BTj.Count);
					}
				}
			}
		}
	}

	private static Enum113 smethod_24(BackgroundWorker backgroundWorker_0, ref Class321 class321_0, FileStream fileStream_0, Class308 class308_0)
	{
		if (class321_0.BTQ)
		{
			foreach (Class308.Class312 item2 in class308_0.BDK)
			{
				if (item2.BTk.Contains(class321_0.BTq))
				{
					int item = Form23.framework_1.method_31(19236).method_256();
					if (item2.BTL.Contains(item) && smethod_25(backgroundWorker_0, ref class321_0, fileStream_0, item2.BTl))
					{
						return Enum113.BTZ;
					}
				}
			}
		}
		else
		{
			foreach (Class308.Class311 item3 in class308_0.BDj)
			{
				if (item3.BTi.Contains(class321_0.BTq) && smethod_25(backgroundWorker_0, ref class321_0, fileStream_0, item3.BTj))
				{
					return Enum113.BTZ;
				}
			}
		}
		return Enum113.BtB;
	}

	private static bool smethod_25(BackgroundWorker backgroundWorker_0, ref Class321 class321_0, FileStream fileStream_0, List<Class308.Class309> list_0)
	{
		bool result = false;
		for (int i = 0; i < list_0.Count; i++)
		{
			if (smethod_26(list_0[i], class321_0.BTq, class321_0.BTR, class321_0.BTS, ref class321_0, fileStream_0))
			{
				result = true;
			}
			backgroundWorker_0.ReportProgress(30 + (i + 1) * 70 / list_0.Count);
		}
		return result;
	}

	private static bool smethod_26(Class308.Class309 class309_0, Enum88 enum88_0, Class14 class14_0, bool bool_0, ref Class321 class321_0, FileStream fileStream_0)
	{
		bool result = false;
		if (!string.IsNullOrEmpty(class309_0.BTB) && Class31.smethod_5(fileStream_0, class309_0.BTB, out var stream_, null))
		{
			Class319 @class = smethod_0(stream_, class321_0.BTm, class309_0.BTa, class309_0.BTc, class309_0.BTD, class309_0.BTC, enum88_0, null, bool_1: false, null);
			if (@class != null && (class321_0.BTQ || smethod_5(enum88_0, class14_0, @class.BdG.BDv, bool_0)))
			{
				result = true;
				class321_0.BTV.Add(@class);
				class321_0.BTv++;
			}
		}
		return result;
	}

	private static Enum113 smethod_27(BackgroundWorker backgroundWorker_0, ref Class321 class321_0, FileStream fileStream_0, ref Class240 class240_0, List<string> list_0)
	{
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				string text = list_0[num];
				Stream stream_ = null;
				if (Class31.smethod_5(fileStream_0, text, out stream_, null))
				{
					Class319 @class = null;
					if (text.EndsWith(Class333.smethod_1402()))
					{
						string string_ = null;
						@class = smethod_2(stream_, class321_0.BTm, null, ref class240_0, text, ref string_);
						if (smethod_28(class240_0, string_))
						{
							break;
						}
					}
					else if (!text.Contains(Class333.aYT()))
					{
						@class = smethod_0(stream_, class321_0.BTm, null, null, bool_0: true, byte.MaxValue, Enum88.avK, null, bool_1: true, null);
					}
					backgroundWorker_0.ReportProgress(30 + (num + 1) * 70 / list_0.Count);
					if (@class != null)
					{
						if (@class.BdG.BDu == Enum112.BDL)
						{
							if (!class321_0.BTw)
							{
								if (class321_0.BTX)
								{
									class321_0.BTV.Insert(class321_0.BTV.Count - 1, @class);
								}
								else
								{
									class321_0.BTV.Add(@class);
								}
								class321_0.BTw = true;
							}
						}
						else if (@class.BdG.BDu == Enum112.BDl)
						{
							if (!class321_0.BTX)
							{
								class321_0.BTV.Add(@class);
								class321_0.BTX = true;
							}
						}
						else if (@class.BdG.BDu == Enum112.BDo)
						{
							if (!class321_0.BTx)
							{
								class321_0.BTV.Add(@class);
								class321_0.BTx = true;
							}
						}
						else if (@class.BdG.BDu == Enum112.BDQ)
						{
							if (!class321_0.BTY)
							{
								class321_0.BTV.Add(@class);
								class321_0.BTY = true;
							}
						}
						else if (@class.BdG.BDu == Enum112.BDs)
						{
							if (!class321_0.BTy)
							{
								class321_0.BTV.Add(@class);
								class321_0.BTy = true;
							}
						}
						else if (class321_0.BTV.Count != 0)
						{
							class321_0.BTV.Insert(0, @class);
						}
						else
						{
							class321_0.BTV.Add(@class);
						}
					}
				}
				num++;
				continue;
			}
			return Enum113.BTZ;
		}
		return Enum113.BTz;
	}

	private static bool smethod_28(Class240 class240_0, string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			string text;
			try
			{
				text = Class234.smethod_1(string_0);
			}
			catch
			{
				text = null;
			}
			if (!string.IsNullOrEmpty(text))
			{
				Version? version = Assembly.GetEntryAssembly().GetName().Version;
				Version version2 = new Version(text);
				if (version < version2)
				{
					return true;
				}
			}
		}
		return false;
	}

	private static void smethod_29(object sender, RunWorkerCompletedEventArgs e)
	{
		Form23.smethod_68();
		GC.Collect();
		if (e.Result is Enum113)
		{
			Enum113 @enum = (Enum113)e.Result;
			string text = string.Empty;
			string string_ = Class333.smethod_390();
			switch (@enum)
			{
			case Enum113.BtA:
				text = Class333.aYx();
				break;
			case Enum113.Bta:
				text = Class333.aYY();
				break;
			case Enum113.BtB:
				text = Class333.aYy();
				break;
			case Enum113.Btb:
				text = Class333.aYZ();
				break;
			case Enum113.BTz:
				text = Class333.aYz();
				string_ = Class333.ayA();
				break;
			}
			if (Form23.bool_14)
			{
				Console.WriteLine();
				Console.WriteLine(text);
				Environment.Exit(1);
			}
			else
			{
				Form54.smethod_6(Form23.form23_0, text, string_, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			Form23.form23_0.string_27 = null;
			Form23.form23_0.bool_8 = false;
			Form23.form23_0.bool_9 = false;
			Form23.form23_0.bool_10 = true;
			Form23.form23_0.list_1.Clear();
			Class1.smethod_30();
			Class1.smethod_32();
			return;
		}
		Class321 @class = null;
		bool flag = false;
		if (e.Result is Class321)
		{
			@class = (Class321)e.Result;
			if (!smethod_30(@class))
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
			if (!Form23.bool_14)
			{
				Form23.form23_0.method_117();
				Form23.smethod_9();
				Form23.form23_0.Refresh();
			}
			bool flag2;
			if ((flag2 = @class.BTq != Enum88.avK || @class.BTV.Count - @class.BTv == 0) && smethod_48(@class.BTm))
			{
				if (!Form23.bool_14)
				{
					Form54.smethod_6(Form23.form23_0, Class333.aya(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				return;
			}
			if (!flag2 && !smethod_48(@class.BTm, bool_0: false) && !smethod_46(@class.BTm))
			{
				if (Form23.bool_14)
				{
					Console.WriteLine();
					Console.WriteLine(Class333.ayC());
					Environment.Exit(1);
				}
				else
				{
					Form54.smethod_6(Form23.form23_0, Class333.ayC(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				Form23.form23_0.string_27 = null;
				Form23.form23_0.bool_8 = false;
				Form23.form23_0.bool_9 = false;
				Form23.form23_0.bool_10 = true;
				Form23.form23_0.list_1.Clear();
				Class1.smethod_30();
				Class1.smethod_32();
				return;
			}
			if (Form23.framework_1 != null)
			{
				Form23.framework_1.method_6();
			}
			if (!Form23.bool_14)
			{
				if (Form23.form3_0 != null && Form23.form3_0.Visible)
				{
					Form23.form3_0.Close();
				}
				if (Form23.form43_0 != null && Form23.form43_0.Visible)
				{
					Bdm = Form23.form43_0.Location;
					Form23.form43_0.Close();
					BdM = true;
				}
				else
				{
					BdM = false;
				}
			}
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.WorkerSupportsCancellation = false;
			backgroundWorker.DoWork += smethod_34;
			backgroundWorker.ProgressChanged += Form23.smethod_72;
			backgroundWorker.RunWorkerCompleted += smethod_35;
			if (@class.BTn)
			{
				Form23.smethod_70(Class333.ayB(), @class.BTW);
			}
			else
			{
				Form23.smethod_70(Class333.ayb(), @class.BTW);
			}
			backgroundWorker.RunWorkerAsync(@class);
		}
		else
		{
			if (Form23.bool_14)
			{
				Console.WriteLine();
				Console.WriteLine(Class333.ayc());
				Environment.Exit(1);
			}
			else
			{
				Form54.smethod_6(Form23.form23_0, Class333.ayc(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			Form23.form23_0.string_27 = null;
			Form23.form23_0.bool_8 = false;
			Form23.form23_0.bool_9 = false;
			Form23.form23_0.bool_10 = true;
			Form23.form23_0.list_1.Clear();
			Class1.smethod_30();
			Class1.smethod_32();
		}
	}

	private static bool smethod_30(Class321 class321_0)
	{
		bool flag = false;
		bool flag2 = false;
		foreach (Class319 item in class321_0.BTV)
		{
			bool flag3 = item.BdK != Enum88.avK;
			if (!string.IsNullOrEmpty(item.BdJ))
			{
				if (item.Bdj && !flag3)
				{
					class321_0.BTW.Add(item.Bdi + Class333.smethod_134());
				}
				continue;
			}
			if (item.Bdg != null)
			{
				if (flag3)
				{
					if (!flag2 && !flag && !class321_0.BTO && class321_0.BTW.Count != 0 && class321_0.BTq == Enum88.avK && class321_0.BTm.byte_4 != 22)
					{
						smethod_31(class321_0);
						smethod_32(class321_0);
						smethod_33(class321_0);
						flag2 = true;
					}
					class321_0.BTW.Add(item.Bdi + Class333.smethod_134());
					continue;
				}
				if (item.BdG.BDU >= 2)
				{
					class321_0.BTW.Add(item.Bdi + Class333.smethod_134());
					continue;
				}
				switch (item.BdG.BDu)
				{
				case Enum112.BDl:
					class321_0.BTW.Add(Class333.ayI());
					break;
				case Enum112.BDM:
					class321_0.BTW.Add(Class333.ayD());
					break;
				case Enum112.BDm:
					class321_0.BTW.Add(Class333.aye());
					break;
				case Enum112.BDN:
					class321_0.BTW.Add(Class333.ayG());
					break;
				case Enum112.BDn:
					class321_0.BTW.Add(Class333.ayF());
					break;
				case Enum112.BDp:
					class321_0.BTW.Add(Class333.ayf());
					break;
				case Enum112.BDL:
				case Enum112.BDo:
				case Enum112.BDQ:
					class321_0.BTW.Add(Class333.ayg());
					if (class321_0.BTw && class321_0.BTX)
					{
						class321_0.BTW.Add(Class333.ayH());
					}
					else
					{
						class321_0.BTW.Add(Class333.ayh());
					}
					break;
				case Enum112.BDP:
				case Enum112.BDq:
					class321_0.BTW.Add(Class333.ayd());
					class321_0.BTW.Add(Class333.ayE());
					break;
				case Enum112.BDs:
					class321_0.BTW.Add(Class333.ayi());
					break;
				}
				continue;
			}
			flag = true;
			break;
		}
		if (!flag2 && !flag && !class321_0.BTO && class321_0.BTW.Count != 0 && class321_0.BTq == Enum88.avK && (class321_0.BTu == null || class321_0.BTu.Count == 0 || class321_0.BTu.Contains(Class333.smethod_68()) || class321_0.BTu.Contains(Class333.aYr())) && class321_0.BTm.byte_4 != 22)
		{
			smethod_31(class321_0);
			smethod_32(class321_0);
			smethod_33(class321_0);
		}
		return !flag;
	}

	private static void smethod_31(Class321 class321_0)
	{
		if (class321_0.BTn)
		{
			class321_0.BTW.Add(Class333.ayJ());
		}
		else
		{
			class321_0.BTW.Add(Class333.ayj());
		}
	}

	private static void smethod_32(Class321 class321_0)
	{
		class321_0.BTW.Add(Class333.ayK());
	}

	private static void smethod_33(Class321 class321_0)
	{
		if (class321_0.BTm.byte_4 == 21)
		{
			class321_0.BTW.Add(Class333.ayk());
		}
		else
		{
			class321_0.BTW.Add(Class333.ayL());
		}
	}

	private static void smethod_34(object sender, DoWorkEventArgs e)
	{
		lock (Form23.object_1)
		{
			Form23.int_0 |= 512;
		}
		Class322 @class = new Class322();
		@class.BtC = false;
		@class.Btc = false;
		@class.BtD = false;
		if (e.Argument is Class321)
		{
			Class321 class2 = (Class321)e.Argument;
			Class5 class3 = (@class.BtJ = class2.BTm);
			@class.Bti = 0;
			if (class2.BTs != null)
			{
				foreach (Enum88 key in class2.BTs.Keys)
				{
					if (key == Enum88.avU || key == Enum88.avu || key == Enum88.avV || key == Enum88.avv)
					{
						Class14 class4 = class2.BTs[key];
						bool bool_ = false;
						if (class2.BTt.ContainsKey(key))
						{
							bool_ = class2.BTt[key];
						}
						if (class4 < smethod_6(bool_))
						{
							@class.Bti++;
						}
					}
				}
			}
			@class.BtI = class2.BTp;
			@class.Bte = class2.BTQ;
			@class.BtF = class2.BTq;
			@class.Btf = class2.BTR;
			@class.BtG = class2.BTr;
			@class.Btg = class2.BTs;
			@class.BtH = class2.BTT;
			BackgroundWorker backgroundWorker_ = sender as BackgroundWorker;
			if (class2.BTV.Count - class2.BTv != 0)
			{
				if (Class242.smethod_12(class3.byte_4))
				{
					@class.Btc = Class325.smethod_0(class2, class3, backgroundWorker_, e, @class, out @class.BtC);
					if (!@class.Btc)
					{
						return;
					}
				}
				else
				{
					@class.Btc = Class324.smethod_0(class2, class3, backgroundWorker_, e, @class, out @class.BtC);
					if (!@class.Btc)
					{
						return;
					}
				}
				Thread.Sleep(200);
				Class1.smethod_77(class3.string_0);
				if ((class2.BTu == null || class2.BTu.Count == 0 || class2.BTu.Contains(Class333.smethod_68()) || class2.BTu.Contains(Class333.aYr())) && class3.byte_4 != 22)
				{
					if (!smethod_37(class2, class2.BTN, backgroundWorker_, out var bool_2))
					{
						if (class2.BTO)
						{
							@class.BtC = false;
							@class.Btc = false;
							@class.Btd = Class333.ayN();
							e.Result = @class;
							Class1.smethod_77(class3.string_0);
						}
						else
						{
							@class.BtC = false;
							@class.Btc = false;
							@class.Btd = Class333.ayn();
							e.Result = @class;
							Class1.smethod_77(class3.string_0);
						}
						return;
					}
					if (bool_2)
					{
						string text;
						if (class2.BTP != null)
						{
							@class.Bth = class2.BTP;
							text = Class333.ayl() + class2.BTP + Class333.ayM();
						}
						else
						{
							text = Class333.aym();
						}
						if (string.IsNullOrEmpty(@class.Btd))
						{
							@class.Btd = text;
						}
						else
						{
							@class.Btd = @class.Btd + Class333.smethod_1812() + text;
						}
					}
				}
			}
			else
			{
				@class.BtC = true;
				@class.Btc = true;
			}
			if (class2.BTv != 0)
			{
				if (class2.BTq == Enum88.avK && !smethod_47(class3))
				{
					@class.BtE = Class333.smethod_2047();
					e.Result = @class;
					Class1.smethod_77(class3.string_0);
					return;
				}
				if (Class324.smethod_1(class2, class3, backgroundWorker_, e, @class))
				{
					@class.BtD = true;
				}
				else
				{
					@class.BtD = false;
				}
			}
			else
			{
				@class.BtD = true;
			}
			e.Result = @class;
			Thread.Sleep(100);
			Class1.smethod_77(class3.string_0);
		}
		else
		{
			@class.Btd = Class333.ayO();
			e.Result = @class;
		}
	}

	private static void smethod_35(object sender, RunWorkerCompletedEventArgs e)
	{
		Form23.smethod_68();
		Form23.smethod_71();
		GC.Collect();
		Form23.form23_0.string_27 = null;
		Form23.form23_0.bool_8 = false;
		Form23.form23_0.bool_9 = false;
		Form23.form23_0.bool_10 = true;
		Form23.form23_0.list_1.Clear();
		Class1.smethod_30();
		Class1.smethod_32();
		Class322 @class = (Class322)e.Result;
		string text = string.Empty;
		if (!string.IsNullOrEmpty(@class.BtE))
		{
			text += @class.BtE;
		}
		if (!string.IsNullOrEmpty(@class.Btd))
		{
			if (!string.IsNullOrEmpty(text))
			{
				text += Class333.smethod_1812();
			}
			if (@class.BtI && Form23.framework_1 != null && Form23.smethod_35(Form23.framework_1))
			{
				text += Class333.ayo();
			}
			text += @class.Btd;
		}
		bool flag = false;
		if (Form23.bool_14)
		{
			if (!string.IsNullOrEmpty(text))
			{
				Console.WriteLine();
				Console.WriteLine(text);
			}
		}
		else if (@class.BtC && !string.IsNullOrEmpty(@class.Btd) && @class.Bth != null)
		{
			if (Form54.smethod_6(string_1: (!@class.BtD) ? Class333.smethod_390() : Class333.ayP(), iwin32Window_0: Form23.form23_0, string_0: text, messageBoxButtons_0: MessageBoxButtons.YesNo, messageBoxIcon_0: MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				flag = true;
			}
		}
		else if (!string.IsNullOrEmpty(text))
		{
			string string_;
			if (@class.BtC && @class.BtD)
			{
				string_ = Class333.ayP();
				text = Class333.ayp() + text;
			}
			else
			{
				string_ = Class333.smethod_390();
			}
			Form54.smethod_6(Form23.form23_0, text, string_, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		if (@class.Btc)
		{
			if (!@class.Bte && !smethod_47(@class.BtJ))
			{
				lock (Form23.object_1)
				{
					Form23.int_0 &= -513;
				}
				if (Form23.bool_14)
				{
					Console.WriteLine();
					Console.WriteLine(Class333.smethod_2047());
					Environment.Exit(1);
				}
				else
				{
					Form54.smethod_6(Form23.form23_0, Class333.smethod_2047(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				if (@class.BtI)
				{
					smethod_36(@class.BtJ);
				}
				lock (Form23.object_1)
				{
					Form23.int_0 &= -513;
				}
				if (flag)
				{
					Class240 class2 = Class296.smethod_0(@class.Bth);
					if (class2 != null)
					{
						Form23.form23_0.method_152(null, @class.Bth, class2);
					}
					else
					{
						Form54.smethod_6(Form23.form23_0, Class333.smethod_1369(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				else if (@class.BtJ.byte_4 == 22)
				{
					if (!Form23.bool_14)
					{
						Form54.smethod_4(Form23.form23_0, Class333.ayQ(), Class333.ayP(), MessageBoxButtons.OK);
					}
				}
				else
				{
					if (Form23.framework_1 != null)
					{
						Form23.framework_1.method_6();
					}
					if (Form23.form23_0.bool_4)
					{
						Form54.smethod_4(Form23.form23_0, Class333.ayq(), Class333.ayP(), MessageBoxButtons.OK);
						Form23.form23_0.bool_4 = false;
						Class1.smethod_6();
					}
					if (!Form23.bool_14)
					{
						if (Form23.framework_1 != null)
						{
							Form23.framework_1.method_65(Form23.form23_0);
						}
						bool bool_ = false;
						bool bool_2 = false;
						bool bool_3 = false;
						bool flag2 = false;
						if (Form23.framework_1.method_4())
						{
							flag2 = Form48.smethod_1(Form23.framework_1, out bool_, out bool_2, out bool_3);
						}
						if (bool_)
						{
							Form23.smethod_32(bool_53: true);
						}
						else if (!bool_3)
						{
							Form23.smethod_10(bool_53: true);
							Form23.form23_0.toolStripMenuItem_39.Enabled = true;
							Form23.form23_0.toolStripButton_11.Enabled = true;
							Form23.form23_0.toolStripMenuItem_38.Enabled = true;
							Form23.form23_0.toolStripMenuItem_42.Enabled = true;
							Form23.form23_0.class163_0.Enabled = true;
							Form23.form23_0.toolStripMenuItem_6.Enabled = true;
							Form23.form23_0.toolStripButton_4.Enabled = true;
							Form23.form23_0.toolStripMenuItem_58.Enabled = true;
							Form23.form23_0.toolStripMenuItem_59.Enabled = true;
							Form23.form23_0.toolStripDropDownButton_0.Enabled = true;
							Form23.smethod_11();
							Form23.string_19 = string.Empty;
							Form23.smethod_6();
							if (Form10.bool_2 && (Form23.int_0 & 0x800) == 0)
							{
								Form23.class284_1.method_0();
							}
							if (flag2 && Form23.form23_0.toolStripMenuItem_31.Enabled && !bool_2)
							{
								Form23.form23_0.toolStripMenuItem_31.PerformClick();
							}
						}
						if (@class.Bti > 1)
						{
							Form54.smethod_4(Form23.form23_0, Class333.ayR() + ((@class.BtJ.byte_4 == 21) ? Class333.aHl() : Class333.aSF()) + Class333.ayr(), Class333.ayS(), MessageBoxButtons.OK);
						}
						else if (@class.Bti == 1)
						{
							Form54.smethod_4(Form23.form23_0, Class333.ays() + ((@class.BtJ.byte_4 == 21) ? Class333.aHl() : Class333.aSF()) + Class333.ayT(), Class333.ayS(), MessageBoxButtons.OK);
						}
						else if (Class326.smethod_3(@class.BtF, @class.Btf, @class.BtG, @class.Btg, @class.BtH))
						{
							Form54.smethod_6(Form23.form23_0, Class326.smethod_2(bool_0: false, bool_1: false, bool_2: true), Class333.ayt(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
					}
				}
			}
		}
		else
		{
			lock (Form23.object_1)
			{
				Form23.int_0 &= -513;
			}
			if (@class.BtJ.byte_4 != 21 && !smethod_48(@class.BtJ) && !smethod_46(@class.BtJ) && !Form23.bool_14)
			{
				Form54.smethod_6(Form23.form23_0, Class333.ayC(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			if (Form23.bool_14)
			{
				Environment.Exit(1);
			}
		}
		if (BdM && !Form23.bool_14)
		{
			if (Form23.form43_0 != null)
			{
				Form23.form43_0.Dispose();
			}
			Form23.form43_0 = new Form43();
			Form23.form43_0.Show(Form23.form23_0);
			Form23.form43_0.Location = Bdm;
			BdM = false;
		}
		if (Form23.bool_14)
		{
			if (@class.BtC && @class.Btc && @class.BtD)
			{
				Environment.Exit(0);
			}
			else
			{
				Environment.Exit(1);
			}
		}
	}

	private static void smethod_36(Class5 class5_0)
	{
		if (Form23.framework_1 == null || !Form23.smethod_35(Form23.framework_1))
		{
			return;
		}
		if (Form23.framework_1.method_31(9500).method_256() == 0)
		{
			if (!Class1.smethod_59(class5_0.string_0, out var _))
			{
				Form54.smethod_6(Form23.form23_0, Class333.ayU(), Class333.ayu(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		else
		{
			Form54.smethod_6(Form23.form23_0, Class333.ayV(), Class333.ayu(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private static bool smethod_37(Class321 class321_0, Class240 class240_0, BackgroundWorker backgroundWorker_0, out bool bool_0)
	{
		Class5 bTm = class321_0.BTm;
		if (class321_0.BTO)
		{
			bool_0 = false;
			if (smethod_47(bTm))
			{
				if (Form23.framework_1 != null)
				{
					Form23.framework_1.method_6();
				}
				return true;
			}
			return false;
		}
		bool flag = false;
		bool_0 = false;
		if (class240_0 != null)
		{
			int num = class321_0.BTW.Count - class321_0.BTv - 3;
			int int_ = num + 1;
			int int_2 = num + 2;
			backgroundWorker_0.ReportProgress(0, num);
			string text = Class234.smethod_8(class240_0.axS, class240_0.axs, class240_0.axT, class240_0.axt, bool_0: true);
			backgroundWorker_0.ReportProgress(10, num);
			if (!string.IsNullOrEmpty(text))
			{
				bool flag2;
				if (flag2 = Form23.form23_0.bool_4 && !string.IsNullOrEmpty(Form23.form23_0.string_22))
				{
					Class240 @class = Class296.smethod_0(Form23.form23_0.string_22);
					if (@class != null)
					{
						string text2 = Class234.smethod_8(@class.axS, @class.axs, @class.axT, @class.axt, bool_0: true);
						if (!string.IsNullOrEmpty(text2))
						{
							Framework framework = new Framework(text, class240_0.axS, class240_0.axs, class240_0.axT);
							framework.aXc = bTm.string_0;
							Framework framework2 = new Framework(text2, @class.axS, @class.axs, @class.axT);
							framework2.aXc = bTm.string_0;
							backgroundWorker_0.ReportProgress(20, num);
							if (framework2.method_1() == Class237.Enum91.Brc)
							{
								backgroundWorker_0.ReportProgress(40, num);
								if (framework.method_1() == Class237.Enum91.Brc)
								{
									backgroundWorker_0.ReportProgress(60, num);
									new Class296(Form23.form23_0.string_22, framework2).method_0(out var _);
									framework.method_48(framework.aWS);
									framework.method_69(framework2, framework.aWS, bool_0: true, bool_1: false);
									framework.method_70(framework2, bool_0: false);
									backgroundWorker_0.ReportProgress(80, num);
									framework.method_49(framework.aWS);
									framework.method_58();
									framework.method_37(framework.awj);
									framework.method_42(null);
									backgroundWorker_0.ReportProgress(100, num);
									Form23.framework_1 = framework;
									if (smethod_47(bTm, backgroundWorker_0, int_))
									{
										try
										{
											if (Form23.framework_1 != null)
											{
												Form23.framework_1.method_6();
											}
											Form23.form23_0.method_223(backgroundWorker_0, int_2);
											flag = true;
										}
										catch
										{
										}
									}
								}
							}
						}
					}
				}
				else if (Form23.framework_1 != null && !class321_0.BTo)
				{
					Framework framework3 = new Framework(text, class240_0.axS, class240_0.axs, class240_0.axT);
					framework3.aXc = bTm.string_0;
					if (framework3.method_1() == Class237.Enum91.Brc)
					{
						backgroundWorker_0.ReportProgress(50, num);
						framework3.method_48(framework3.aWS);
						framework3.method_69(Form23.framework_1, framework3.aWS, bool_0: true, bool_1: false);
						framework3.method_70(Form23.framework_1, bool_0: false);
						backgroundWorker_0.ReportProgress(70, num);
						framework3.method_49(framework3.aWS);
						framework3.method_58();
						framework3.method_37(framework3.awj);
						framework3.method_42(null);
						if (framework3.awZ == 21)
						{
							backgroundWorker_0.ReportProgress(90, num);
							if (framework3.method_12())
							{
								Class329.smethod_0(framework3, null);
								Class329.smethod_5();
								if (framework3.awP.method_98())
								{
									Class329.smethod_10();
								}
							}
						}
						backgroundWorker_0.ReportProgress(100, num);
						Form23.framework_1 = framework3;
						if (smethod_47(bTm, backgroundWorker_0, int_))
						{
							try
							{
								if (Form23.framework_1 != null)
								{
									Form23.framework_1.method_6();
								}
								Form23.form23_0.method_223(backgroundWorker_0, int_2);
								flag = true;
							}
							catch
							{
							}
						}
					}
				}
				if (!flag || (!flag2 && Form23.framework_1 == null))
				{
					Framework framework4 = new Framework(text, class240_0.axS, class240_0.axs, class240_0.axT);
					if (framework4.method_1() == Class237.Enum91.Brc)
					{
						backgroundWorker_0.ReportProgress(60, num);
						framework4.method_15(framework4.aWS);
						backgroundWorker_0.ReportProgress(70, num);
						framework4.method_37(framework4.awj);
						framework4.method_42(null);
						if (framework4.awZ == 21)
						{
							backgroundWorker_0.ReportProgress(90, num);
							if (framework4.method_12())
							{
								Class329.smethod_0(framework4, null);
								Class329.smethod_5();
								if (framework4.awP.method_98())
								{
									Class329.smethod_10();
								}
							}
						}
						backgroundWorker_0.ReportProgress(100, num);
						framework4.aXc = bTm.string_0;
						Form23.framework_1 = framework4;
						if (smethod_47(bTm, backgroundWorker_0, int_))
						{
							try
							{
								if (Form23.framework_1 != null)
								{
									Form23.framework_1.method_6();
								}
								Form23.form23_0.method_223(backgroundWorker_0, int_2);
								flag = true;
								bool_0 = true;
							}
							catch
							{
							}
						}
					}
				}
			}
		}
		return flag;
	}

	internal static List<Class318> smethod_38(BackgroundWorker backgroundWorker_0, int int_0, int int_1, Class14 class14_0, ushort ushort_0, string string_0, Class14 class14_1, bool bool_0, Enum88 enum88_0, Class14 class14_2, bool bool_1)
	{
		lock (Bdn)
		{
			if (backgroundWorker_0 != null && backgroundWorker_0.WorkerReportsProgress)
			{
				backgroundWorker_0.ReportProgress(0);
			}
			List<Class318> list = new List<Class318>();
			if (!Directory.Exists(Bdl))
			{
				return list;
			}
			string[] files = Directory.GetFiles(Bdl, Class333.aCe());
			for (int i = 0; i < files.Length; i++)
			{
				string string_1 = files[i];
				if (backgroundWorker_0 != null && backgroundWorker_0.CancellationPending)
				{
					break;
				}
				Class318 @class = smethod_39(string_1, int_0, int_1, ushort_0, string_0, class14_1, enum88_0, class14_2, bool_1);
				if (@class != null)
				{
					if (list.Count == 0)
					{
						if (enum88_0 == Enum88.avK)
						{
							if (!bool_0 || @class.BdF[0].BdC.axT.method_7())
							{
								list.Add(@class);
							}
						}
						else
						{
							Class317 class2 = smethod_41(@class.Bdf, enum88_0, class14_2, bool_1);
							if (class2 != null && (!bool_0 || class2.Bdd.method_7()))
							{
								list.Add(@class);
							}
						}
					}
					else
					{
						for (int j = 0; j < list.Count; j++)
						{
							if (enum88_0 == Enum88.avK)
							{
								if (!bool_0 || @class.BdF[0].BdC.axT.method_7())
								{
									if (@class.BdF[0].BdC.axT > list[j].BdF[0].BdC.axT)
									{
										list.Insert(j, @class);
										break;
									}
									if (j == list.Count - 1)
									{
										list.Add(@class);
										break;
									}
								}
								continue;
							}
							Class317 class3 = smethod_41(@class.Bdf, enum88_0, class14_2, bool_1);
							Class317 class4 = smethod_41(list[j].Bdf, enum88_0, class14_2, bool_1);
							if (class3 == null || class4 == null || (bool_0 && !class3.Bdd.method_7()))
							{
								continue;
							}
							if (!(class3.Bdd > class4.Bdd))
							{
								if (j == list.Count - 1)
								{
									if (class3.Bdd != class4.Bdd)
									{
										list.Add(@class);
									}
									break;
								}
								continue;
							}
							if (j == 0)
							{
								list.Insert(j, @class);
							}
							else if (smethod_41(list[j - 1].Bdf, enum88_0, class14_2, bool_1).Bdd != class3.Bdd)
							{
								list.Insert(j, @class);
							}
							break;
						}
					}
				}
				if (backgroundWorker_0 != null && backgroundWorker_0.WorkerReportsProgress)
				{
					backgroundWorker_0.ReportProgress((i + 1) * 90 / files.Length);
				}
			}
			if (backgroundWorker_0 != null && backgroundWorker_0.CancellationPending)
			{
				list.Clear();
			}
			else
			{
				Class307.smethod_7();
				if (backgroundWorker_0 != null && backgroundWorker_0.WorkerReportsProgress)
				{
					backgroundWorker_0.ReportProgress(100);
				}
			}
			return list;
		}
	}

	internal static Class318 smethod_39(string string_0, int int_0, int int_1, ushort ushort_0, string string_1, Class14 class14_0, Enum88 enum88_0, Class14 class14_1, bool bool_0)
	{
		Class318 @class = Class307.smethod_0(string_0);
		if (@class == null)
		{
			List<Class314> list = smethod_8(string_0);
			List<Class315> list2 = smethod_7(string_0);
			if (list.Count == 0 && list2.Count == 0)
			{
				return null;
			}
			@class = smethod_40(string_0, list, list2);
			Class307.smethod_1(@class, bool_0: false);
		}
		if (@class.BdF.Count == 0 && enum88_0 != Enum88.avK && @class.Bdf.Count != 0)
		{
			if (smethod_41(@class.Bdf, enum88_0, class14_1, bool_0) == null)
			{
				return null;
			}
		}
		else
		{
			bool flag = false;
			foreach (Class316 item in @class.BdF)
			{
				if (!Class305.smethod_4(item, out var _, out var _))
				{
					bool flag2 = false;
					if (item.BdC != null)
					{
						flag2 = item.BdC.axs == int_1 || item.BdC.axS == 22;
					}
					if (((item.BdC != null && item.BdC.axS == int_0) & flag2) && (class14_0 == null || item.BdC.axT >= class14_0) && (smethod_43(string_1) || item.Bdc.Contains(ushort_0)))
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				return null;
			}
			if (enum88_0 != Enum88.avK && smethod_41(@class.Bdf, enum88_0, class14_1, bool_0) == null)
			{
				return null;
			}
		}
		return @class;
	}

	internal static Class318 smethod_40(string string_0, List<Class314> list_0, List<Class315> list_1)
	{
		Class318 @class = new Class318();
		@class.BdE = string_0;
		try
		{
			DateTime creationTime = File.GetCreationTime(string_0);
			DateTime lastWriteTime = File.GetLastWriteTime(string_0);
			DateTime dateTime_ = ((lastWriteTime > creationTime) ? lastWriteTime : creationTime);
			@class.Bde = Class23.smethod_9(dateTime_, bool_1: true, bool_2: false);
		}
		catch
		{
		}
		foreach (Class314 item in list_0)
		{
			Class316 class2 = new Class316
			{
				BdC = item.BDy,
				Bdc = new List<ushort>()
			};
			if (item.BDZ != null)
			{
				class2.Bdc.AddRange(item.BDZ);
			}
			@class.BdF.Add(class2);
		}
		foreach (Class315 item2 in list_1)
		{
			Class317 class3 = new Class317();
			class3.BdD = item2.Bda;
			class3.Bdd = item2.BdB;
			@class.Bdf.Add(class3);
		}
		return @class;
	}

	internal static Class317 smethod_41(List<Class317> list_0, Enum88 enum88_0, Class14 class14_0, bool bool_0)
	{
		foreach (Class317 item in list_0)
		{
			if (item.BdD == enum88_0 && smethod_5(enum88_0, class14_0, item.Bdd, bool_0))
			{
				return item;
			}
		}
		return null;
	}

	internal static (string Path, string Error) smethod_42(BackgroundWorker backgroundWorker_0, Enum88 enum88_0, int int_0)
	{
		backgroundWorker_0.ReportProgress(0);
		try
		{
			if (!Directory.Exists(Bdl))
			{
				return (Path: null, Error: Class333.ayv());
			}
			Class14 @class = null;
			string text = null;
			bool flag = false;
			string[] files = Directory.GetFiles(Bdl, Class333.aCe());
			for (int i = 0; i < files.Length; i++)
			{
				string text2 = files[i];
				Class318 class2 = Class307.smethod_0(text2);
				if (class2 == null || (class2.BdF.Count == 0 && class2.Bdf.Count == 0))
				{
					using FileStream stream_ = File.OpenRead(text2);
					if (Class31.smethod_8(stream_, null).Contains(Class333.aYs()))
					{
						Class308 class3 = null;
						try
						{
							if (Class31.smethod_5(stream_, Class333.aYs(), out var stream_2, null))
							{
								class3 = new Class308(stream_2);
							}
						}
						catch
						{
							class3 = null;
						}
						if (class3 != null && class3.BDK.Count != 0)
						{
							foreach (Class308.Class312 item2 in class3.BDK)
							{
								if (!item2.BTk.Contains(enum88_0))
								{
									continue;
								}
								flag = true;
								if (item2.BTL.Contains(int_0))
								{
									if (@class == null || class3.BDi > @class)
									{
										@class = class3.BDi;
										text = text2;
									}
									break;
								}
							}
						}
					}
				}
				backgroundWorker_0.ReportProgress((i + 1) * 100 / files.Length);
			}
			if (text == null)
			{
				if (flag)
				{
					return (Path: null, Error: Class333.ayW());
				}
				return (Path: null, Error: Class333.ayw());
			}
			return (Path: text, Error: null);
		}
		catch (Exception ex)
		{
			string item = Class333.ayX() + ex.Message;
			return (Path: null, Error: item);
		}
	}

	internal static bool smethod_43(string string_0)
	{
		if (string_0 != null && string_0.Length == 12)
		{
			return string_0.Substring(4, 2) == Class333.ayx();
		}
		return false;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_44(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = Bdo;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref Bdo, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_45(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = Bdo;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref Bdo, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal static bool smethod_46(Class5 class5_0)
	{
		Class23.smethod_3(Class333.ayY() + class5_0.string_0 + Class333.smethod_9());
		Bdo?.Invoke(null, EventArgs.Empty);
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		do
		{
			if (Form23.smethod_34(bool_53: false))
			{
				Thread.Sleep(100);
				continue;
			}
			stopwatch.Stop();
			BdO = true;
			lock (Form23.object_1)
			{
				Form23.int_0 |= 256;
			}
			Thread.Sleep(300);
			Class1.smethod_45(class5_0.string_0);
			bool flag;
			if (flag = Class242.smethod_12(class5_0.byte_4))
			{
				class5_0.bool_1 = true;
			}
			bool flag2 = false;
			int num = 3;
			do
			{
				num--;
				Class1.smethod_19(class5_0.string_0);
				if (!flag)
				{
					if (class5_0.byte_4 != 22 && class5_0.byte_4 != 21)
					{
						Thread.Sleep(200);
					}
					else
					{
						Thread.Sleep(1500);
						Class1.smethod_19(class5_0.string_0);
						Thread.Sleep(1500);
					}
				}
				else
				{
					Thread.Sleep(1000);
				}
				Class5 @class = Class1.smethod_28(class5_0.string_0);
				if (@class != null)
				{
					if (smethod_48(@class, bool_0: false))
					{
						Class23.smethod_3(Class333.ayz() + class5_0.string_0 + Class333.smethod_9());
						flag2 = true;
						continue;
					}
					Class23.smethod_3(Class333.aZA() + class5_0.string_0 + Class333.aZa() + num + Class333.aZB());
				}
				else
				{
					Class23.smethod_3(Class333.aZA() + class5_0.string_0 + Class333.aZb() + num + Class333.aZB());
				}
			}
			while (num != 0 && !flag2);
			if (!flag2)
			{
				Form23.smethod_32(bool_53: false);
			}
			BdO = false;
			return flag2;
		}
		while (stopwatch.ElapsedMilliseconds <= 2000L);
		stopwatch.Stop();
		Class23.smethod_3(Class333.ayy() + class5_0.string_0 + Class333.ayZ());
		return false;
	}

	internal static bool smethod_47(Class5 class5_0, BackgroundWorker backgroundWorker_0 = null, int int_0 = -1)
	{
		Class23.smethod_3(Class333.aZC() + class5_0.string_0 + Class333.smethod_9());
		Bdo?.Invoke(null, EventArgs.Empty);
		if (backgroundWorker_0 != null)
		{
			if (int_0 == -1)
			{
				backgroundWorker_0.ReportProgress(0);
			}
			else
			{
				backgroundWorker_0.ReportProgress(0, int_0);
			}
		}
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		do
		{
			if (Form23.smethod_34(bool_53: false))
			{
				Thread.Sleep(100);
				continue;
			}
			stopwatch.Stop();
			bool num = Class1.smethod_25(class5_0.string_0) == Enum11.const_0 || Class1.smethod_25(class5_0.string_0) == Enum11.const_3;
			Class1.smethod_78(class5_0.string_0, bool_1: true);
			Class1.smethod_44(class5_0.string_0);
			if (Class1.smethod_25(class5_0.string_0) == Enum11.const_3)
			{
				Thread.Sleep(2000);
			}
			bool flag = false;
			if (num)
			{
				int num2 = ((class5_0.byte_4 != 21) ? 3 : 50);
				int num3 = num2;
				do
				{
					num3--;
					Class1.smethod_19(class5_0.string_0);
					Thread.Sleep(700);
					Class5 @class = Class1.smethod_28(class5_0.string_0);
					if (@class == null)
					{
						Class23.smethod_3(Class333.aZd() + class5_0.string_0 + Class333.aZb() + num3 + Class333.aZB());
					}
					else if (!smethod_48(@class))
					{
						Class23.smethod_3(Class333.aZD() + class5_0.string_0 + Class333.smethod_9());
						flag = true;
					}
					else
					{
						Class23.smethod_3(Class333.aZd() + class5_0.string_0 + Class333.aZE() + num3 + Class333.aZB());
					}
					if (backgroundWorker_0 != null)
					{
						int percentProgress = Math.Min(100, (num2 - num3) * 100 / (num2 / 2));
						if (int_0 == -1)
						{
							backgroundWorker_0.ReportProgress(percentProgress);
						}
						else
						{
							backgroundWorker_0.ReportProgress(percentProgress, int_0);
						}
					}
				}
				while (num3 != 0 && !flag);
				if (flag && backgroundWorker_0 != null)
				{
					if (int_0 == -1)
					{
						backgroundWorker_0.ReportProgress(100);
					}
					else
					{
						backgroundWorker_0.ReportProgress(100, int_0);
					}
				}
			}
			Class1.smethod_78(class5_0.string_0, bool_1: false);
			return flag;
		}
		while (stopwatch.ElapsedMilliseconds <= 2000L);
		stopwatch.Stop();
		Class23.smethod_3(Class333.aZc() + class5_0.string_0 + Class333.ayZ());
		return false;
	}

	internal static bool smethod_48(Class5 class5_0, bool bool_0 = true)
	{
		bool result;
		if (result = class5_0.method_3() || (bool_0 && class5_0.method_2()))
		{
			lock (Form23.object_1)
			{
				Form23.int_0 |= 256;
				Form23.int_0 &= -5;
				Form23.int_0 &= -33;
				Form23.int_0 &= -9;
				Form23.int_0 &= -65;
				Form23.int_0 &= -17;
				Form23.int_0 &= -129;
			}
			if ((Form23.int_0 & 0x400) != 0)
			{
				Form23.form23_0.toolStripMenuItem_14_Click(null, null);
			}
		}
		else
		{
			lock (Form23.object_1)
			{
				Form23.int_0 &= -257;
			}
		}
		return result;
	}
}
