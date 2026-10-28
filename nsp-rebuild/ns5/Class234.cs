using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Xml;
using ns0;
using ns4;
using ns6;
using ns7;

namespace ns5;

internal static class Class234
{
	internal static readonly string avG = Form23.string_4 + Class333.ags();

	private static readonly string avg = Form23.string_2 + Class333.agT();

	private static readonly string avH = avG + Class333.agt();

	private static readonly string avh = avG + Class333.agU();

	private static Dictionary<string, (string HdefMD5, string LastModDate)> avI = new Dictionary<string, (string, string)>();

	private static readonly object avi = new object();

	internal static readonly object avJ = new object();

	internal static int avj = 100;

	internal static Class239 smethod_0(string string_0)
	{
		Class239 @class = Class242.smethod_3(string_0);
		if (@class != null)
		{
			return @class;
		}
		Class14 class2 = null;
		int axq = -1;
		int axR = -1;
		Stream stream = null;
		try
		{
			stream = Class35.smethod_7(string_0, Class19.smethod_2());
		}
		catch (FileNotFoundException)
		{
			return null;
		}
		bool flag;
		try
		{
			flag = Class31.smethod_7(stream);
		}
		catch
		{
			flag = false;
		}
		Stream stream_ = null;
		if (flag)
		{
			if (Class31.smethod_5(stream, Class333.aGW(), out stream_, null))
			{
				Stream stream_2 = null;
				if (!Class31.smethod_5(stream_, Class333.aGw(), out stream_2, Class19.smethod_1()))
				{
					stream_.Close();
					return null;
				}
				XmlReader xmlReader = XmlReader.Create(stream_2);
				xmlReader.Read();
				while (xmlReader.NodeType != XmlNodeType.Element)
				{
					xmlReader.Read();
				}
				bool flag2 = false;
				bool flag3 = false;
				if (!xmlReader.IsEmptyElement)
				{
					xmlReader.Read();
					while (xmlReader.IsStartElement())
					{
						bool flag4 = true;
						if (xmlReader.Name == Class333.aGX())
						{
							if (!xmlReader.IsEmptyElement)
							{
								for (; xmlReader.IsStartElement() && (class2 == null || !flag2 || !flag3); xmlReader.Read())
								{
									string name = xmlReader.Name;
									if (name == null)
									{
										continue;
									}
									switch (name.Length)
									{
									case 3:
									{
										char c = name[0];
										if (c != 'M')
										{
											if (c != 'T' || !(name == Class333.aGx()))
											{
												continue;
											}
										}
										else if (!(name == Class333.aGY()))
										{
											continue;
										}
										goto IL_0351;
									}
									case 7:
										switch (name[1])
										{
										case 'e':
											if (name == Class333.smethod_194())
											{
												xmlReader.Read();
												string text = string.Empty;
												byte[] array = Class24.smethod_1(xmlReader.Value);
												foreach (byte b in array)
												{
													text += (char)b;
												}
												class2 = new Class14(text, bool_0: false);
												xmlReader.Skip();
											}
											break;
										case 'a':
											if (name == Class333.agg())
											{
												xmlReader.Read();
												axR = int.Parse(xmlReader.Value, NumberStyles.AllowHexSpecifier);
												flag3 = true;
												xmlReader.Skip();
											}
											break;
										}
										continue;
									case 8:
									{
										char c = name[0];
										if (c != 'F')
										{
											if (c != 'H')
											{
												if (c != 'P' || !(name == Class333.aGz()))
												{
													continue;
												}
												break;
											}
											if (!(name == Class333.aGZ()))
											{
												continue;
											}
											goto IL_0351;
										}
										if (!(name == Class333.agA()))
										{
											continue;
										}
										break;
									}
									case 9:
										if (name == Class333.agG())
										{
											xmlReader.Read();
											axq = int.Parse(xmlReader.Value, NumberStyles.AllowHexSpecifier);
											flag2 = true;
											xmlReader.Skip();
										}
										continue;
									case 10:
										if (!(name == Class333.aGy()))
										{
											continue;
										}
										goto IL_0351;
									case 11:
									{
										char c = name[0];
										if (c != 'I')
										{
											if (c != 'P' || !(name == Class333.agB()))
											{
												continue;
											}
										}
										else if (!(name == Class333.aga()))
										{
											continue;
										}
										break;
									}
									case 14:
									{
										char c = name[7];
										if (c != 'E')
										{
											if (c != 'N' || !(name == Class333.agc()))
											{
												continue;
											}
										}
										else if (!(name == Class333.agC()))
										{
											continue;
										}
										break;
									}
									case 15:
										if (!(name == Class333.agb()))
										{
											continue;
										}
										break;
									case 17:
										if (!(name == Class333.agd()))
										{
											continue;
										}
										break;
									case 18:
										if (!(name == Class333.agD()))
										{
											continue;
										}
										break;
									case 20:
										if (!(name == Class333.agF()))
										{
											continue;
										}
										break;
									case 21:
									{
										char c = name[7];
										if (c != 'D')
										{
											if (c != 'S' || !(name == Class333.age()))
											{
												continue;
											}
										}
										else if (!(name == Class333.agE()))
										{
											continue;
										}
										break;
									}
									case 27:
										if (!(name == Class333.agf()))
										{
											continue;
										}
										break;
									default:
										continue;
										IL_0351:
										xmlReader.Skip();
										continue;
									}
									xmlReader.Read();
									xmlReader.Skip();
								}
							}
						}
						else
						{
							flag4 = false;
						}
						if (!flag4)
						{
							xmlReader.Skip();
						}
						else
						{
							xmlReader.Read();
						}
					}
				}
				xmlReader.Close();
				stream_2.Close();
			}
			else
			{
				stream_ = null;
			}
		}
		stream_?.Close();
		if (class2 != null)
		{
			@class = new Class239
			{
				axq = axq,
				axR = axR,
				axr = class2
			};
			stream.Close();
			return @class;
		}
		Stream stream_3 = null;
		if (flag)
		{
			if (!Class31.smethod_5(stream, Class333.agH(), out stream_3, null))
			{
				stream.Close();
				return null;
			}
		}
		else
		{
			stream_3 = stream;
		}
		XmlReader xmlReader2 = XmlReader.Create(stream_3);
		xmlReader2.Read();
		while (xmlReader2.NodeType != XmlNodeType.Element)
		{
			xmlReader2.Read();
		}
		if (!xmlReader2.IsEmptyElement)
		{
			axq = int.Parse(xmlReader2.GetAttribute(Class333.agh()));
			axR = int.Parse(xmlReader2.GetAttribute(Class333.agI()));
			class2 = new Class14(xmlReader2.GetAttribute(Class333.smethod_197()), bool_0: false);
		}
		xmlReader2.Close();
		stream_3?.Close();
		stream.Close();
		if (class2 != null)
		{
			@class = new Class239
			{
				axq = axq,
				axR = axR,
				axr = class2
			};
		}
		return @class;
	}

	internal static string smethod_1(string string_0)
	{
		Stream stream = Class35.smethod_7(string_0, Class19.smethod_2());
		bool flag;
		try
		{
			flag = Class31.smethod_7(stream);
		}
		catch (Exception)
		{
			flag = false;
		}
		Stream stream_ = null;
		if (flag)
		{
			if (!Class31.smethod_5(stream, Class333.agH(), out stream_, null))
			{
				stream.Close();
				return null;
			}
		}
		else
		{
			stream_ = stream;
		}
		XmlReader xmlReader = XmlReader.Create(stream_);
		xmlReader.Read();
		while (xmlReader.NodeType != XmlNodeType.Element)
		{
			xmlReader.Read();
		}
		string result = null;
		if (!xmlReader.IsEmptyElement)
		{
			result = xmlReader.GetAttribute(Class333.agi());
		}
		xmlReader.Close();
		stream_?.Close();
		stream.Close();
		return result;
	}

	internal static void smethod_2()
	{
		try
		{
			if (!Directory.Exists(avG))
			{
				Directory.CreateDirectory(avG);
			}
			List<string> list = new List<string>();
			foreach (string key in avI.Keys)
			{
				list.Add(key + Class333.agJ() + avI[key].HdefMD5 + Class333.agj() + avI[key].LastModDate);
			}
			if (File.Exists(avh))
			{
				File.Delete(avh);
			}
			File.WriteAllLines(avh, list);
			File.SetAttributes(avh, FileAttributes.Hidden);
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.agK() + ex.Message);
		}
	}

	internal static void smethod_3()
	{
		try
		{
			avI.Clear();
			if (!File.Exists(avh))
			{
				return;
			}
			using StreamReader streamReader = File.OpenText(avh);
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				int num = text.IndexOf(Class333.agJ());
				int num2 = text.IndexOf(Class333.agj());
				if (num != -1 && num2 != -1)
				{
					string key = text.Substring(0, num);
					string item = text.Substring(num + Class333.agJ().Length, 32);
					string item2 = text.Substring(num2 + Class333.agj().Length);
					avI.Add(key, (item, item2));
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.agk() + ex.Message);
		}
	}

	internal static string smethod_4(string string_0)
	{
		string text = null;
		string text2 = null;
		string text3 = null;
		try
		{
			text = Path.GetFullPath(string_0);
			if (avI.ContainsKey(text))
			{
				text3 = Class23.smethod_8(File.GetLastWriteTime(text), bool_1: true);
				if (avI[text].LastModDate == text3)
				{
					text2 = avI[text].HdefMD5;
				}
			}
		}
		catch
		{
			text2 = null;
		}
		if (text2 == null)
		{
			byte[] array = Class23.smethod_16(string_0);
			if (array != null)
			{
				text2 = Class24.smethod_0(array);
				if (text != null)
				{
					try
					{
						if (text3 == null)
						{
							text3 = Class23.smethod_8(File.GetLastWriteTime(text), bool_1: true);
						}
						avI[text] = (text2, text3);
					}
					catch
					{
						if (avI.ContainsKey(text))
						{
							avI.Remove(text);
						}
					}
				}
			}
		}
		return text2;
	}

	internal static bool smethod_5(string string_0, Class240 class240_0, out bool bool_0, out bool bool_1, out Class14 class14_0)
	{
		Class239 @class = smethod_0(string_0);
		bool flag = false;
		bool_0 = false;
		bool_1 = false;
		class14_0 = null;
		if (@class != null)
		{
			class14_0 = @class.axr;
			Class239 class2 = new Class239
			{
				axq = class240_0.axS,
				axR = class240_0.axs,
				axr = class240_0.axT
			};
			if (@class == class2)
			{
				flag = true;
				bool_0 = true;
				bool_1 = true;
			}
			else
			{
				bool_0 = @class.axq == class240_0.axS && @class.axR == class240_0.axs;
				bool_1 = class14_0 == class240_0.axT;
			}
		}
		if (flag)
		{
			if (class240_0.axt == null)
			{
				return true;
			}
			string text = smethod_4(string_0);
			if (text != null)
			{
				string text2 = Class24.smethod_0(class240_0.axt);
				if (text == text2)
				{
					return true;
				}
			}
		}
		return false;
	}

	internal static void smethod_6()
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		bool lockTaken = false;
		try
		{
			Monitor.TryEnter(avi, ref lockTaken);
			if (!lockTaken)
			{
				lock (avi)
				{
					stopwatch.Stop();
					return;
				}
			}
			if (!Directory.Exists(avG))
			{
				Directory.CreateDirectory(avG);
			}
			if (File.Exists(avH))
			{
				File.Delete(avH);
			}
			File.Create(avH).Close();
			File.SetAttributes(avH, FileAttributes.Normal);
			string[] files = Directory.GetFiles(avG, Class333.agL());
			string[] array;
			string[] array2;
			if (Directory.Exists(avg))
			{
				string[] files2 = Directory.GetFiles(avg, Class333.agL());
				array = new string[files.Length + files2.Length];
				int num = 0;
				array2 = files;
				foreach (string text in array2)
				{
					array[num] = text;
					num++;
				}
				array2 = files2;
				foreach (string text2 in array2)
				{
					array[num] = text2;
					num++;
				}
			}
			else
			{
				array = new string[files.Length];
				int num2 = 0;
				array2 = files;
				foreach (string text3 in array2)
				{
					array[num2] = text3;
					num2++;
				}
			}
			array2 = array;
			foreach (string text4 in array2)
			{
				Class239 @class = smethod_0(text4);
				if (@class != null)
				{
					List<string> list = new List<string>();
					list.Add(Class333.agl() + text4);
					list.Add(Class333.agM() + @class.axq);
					list.Add(Class333.agm() + @class.axR);
					list.Add(Class333.agN() + @class.axr.ToString());
					list.Add(Class333.smethod_102());
					File.AppendAllLines(avH, list);
				}
			}
			File.SetAttributes(avH, FileAttributes.Hidden);
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.agn() + ex.Message);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(avi);
			}
		}
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.agO(), stopwatch.ElapsedMilliseconds));
	}

	internal static void smethod_7(string string_0, int int_0, int int_1, Class14 class14_0)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		bool lockTaken = false;
		try
		{
			Monitor.TryEnter(avi, ref lockTaken);
			if (!lockTaken)
			{
				return;
			}
			if (!Directory.Exists(avG))
			{
				Directory.CreateDirectory(avG);
			}
			if (File.Exists(avH))
			{
				using StreamReader streamReader = File.OpenText(avH);
				string text;
				while ((text = streamReader.ReadLine()) != null)
				{
					if (text.StartsWith(Class333.agl()) && Path.GetFullPath(text.Substring(Class333.agl().Length)) == Path.GetFullPath(string_0))
					{
						return;
					}
				}
			}
			else
			{
				File.Create(avH).Close();
			}
			File.SetAttributes(avH, FileAttributes.Normal);
			List<string> list = new List<string>();
			list.Add(Class333.agl() + string_0);
			list.Add(Class333.agM() + int_0);
			list.Add(Class333.agm() + int_1);
			list.Add(Class333.agN() + class14_0.ToString());
			list.Add(Class333.smethod_102());
			File.AppendAllLines(avH, list);
			File.SetAttributes(avH, FileAttributes.Hidden);
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.ago() + ex.Message);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(avi);
			}
		}
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.agP(), stopwatch.ElapsedMilliseconds));
	}

	internal static string smethod_8(int int_0, int int_1, Class14 class14_0, byte[] byte_0, bool bool_0)
	{
		string text = null;
		lock (avi)
		{
			bool flag = false;
			do
			{
				if (!File.Exists(avH))
				{
					smethod_6();
					flag = true;
				}
				string text2 = string.Empty;
				int num = -1;
				int num2 = -1;
				Class14 @class = null;
				Class14 class2 = null;
				try
				{
					using StreamReader streamReader = File.OpenText(avH);
					string text3;
					while ((text3 = streamReader.ReadLine()) != null)
					{
						if (text3.StartsWith(Class333.agl()))
						{
							text2 = text3.Substring(Class333.agl().Length);
						}
						else if (text3.StartsWith(Class333.agM()))
						{
							num = int.Parse(text3.Substring(Class333.agM().Length));
						}
						else if (text3.StartsWith(Class333.agm()))
						{
							num2 = int.Parse(text3.Substring(Class333.agm().Length));
						}
						else if (text3.StartsWith(Class333.agN()))
						{
							@class = new Class14(text3.Substring(Class333.agN().Length), bool_0: false);
						}
						else if (class14_0 == null)
						{
							if (num == int_0 && num2 == int_1 && (class2 == null || @class > class2))
							{
								class2 = @class;
								text = text2;
							}
						}
						else
						{
							if (num != int_0 || num2 != int_1 || !(@class == class14_0))
							{
								continue;
							}
							if (byte_0 != null)
							{
								string text4 = smethod_4(text2);
								if (text4 != null)
								{
									string text5 = Class24.smethod_0(byte_0);
									if (text4 == text5)
									{
										text = text2;
										break;
									}
								}
							}
							else if (File.Exists(text2))
							{
								text = text2;
								break;
							}
						}
					}
				}
				catch
				{
				}
				if (bool_0 && string.IsNullOrEmpty(text) && !flag)
				{
					smethod_6();
					flag = true;
					continue;
				}
				break;
			}
			while (string.IsNullOrEmpty(text));
		}
		return text;
	}

	internal static string smethod_9(int int_0, int int_1, Class14 class14_0)
	{
		string result = null;
		lock (avi)
		{
			if (!File.Exists(avH))
			{
				smethod_6();
			}
			string text = string.Empty;
			int num = -1;
			int num2 = -1;
			Class14 @class = null;
			try
			{
				using StreamReader streamReader = File.OpenText(avH);
				string text2;
				while ((text2 = streamReader.ReadLine()) != null)
				{
					if (text2.StartsWith(Class333.agl()))
					{
						text = text2.Substring(Class333.agl().Length);
					}
					else if (text2.StartsWith(Class333.agM()))
					{
						num = int.Parse(text2.Substring(Class333.agM().Length));
					}
					else if (text2.StartsWith(Class333.agm()))
					{
						num2 = int.Parse(text2.Substring(Class333.agm().Length));
					}
					else if (text2.StartsWith(Class333.agN()))
					{
						@class = new Class14(text2.Substring(Class333.agN().Length), bool_0: false);
					}
					else if (num == int_0 && num2 == int_1 && @class != null && @class == class14_0)
					{
						result = text;
						break;
					}
				}
			}
			catch
			{
			}
		}
		return result;
	}

	internal static string smethod_10(int int_0, int int_1, out Class14 class14_0)
	{
		string result = null;
		class14_0 = null;
		lock (avi)
		{
			if (!File.Exists(avH))
			{
				smethod_6();
			}
			string text = string.Empty;
			int num = -1;
			int num2 = -1;
			Class14 @class = null;
			try
			{
				using StreamReader streamReader = File.OpenText(avH);
				string text2;
				while ((text2 = streamReader.ReadLine()) != null)
				{
					if (text2.StartsWith(Class333.agl()))
					{
						text = text2.Substring(Class333.agl().Length);
					}
					else if (text2.StartsWith(Class333.agM()))
					{
						num = int.Parse(text2.Substring(Class333.agM().Length));
					}
					else if (text2.StartsWith(Class333.agm()))
					{
						num2 = int.Parse(text2.Substring(Class333.agm().Length));
					}
					else if (text2.StartsWith(Class333.agN()))
					{
						@class = new Class14(text2.Substring(Class333.agN().Length), bool_0: false);
					}
					else if (num == int_0 && num2 == int_1 && (class14_0 == null || @class > class14_0))
					{
						class14_0 = @class;
						result = text;
					}
				}
			}
			catch
			{
			}
		}
		return result;
	}

	internal static List<string> smethod_11()
	{
		List<string> list = null;
		if (!File.Exists(avH))
		{
			smethod_6();
		}
		lock (avi)
		{
			bool flag = false;
			int num = 100;
			do
			{
				try
				{
					using StreamReader streamReader = File.OpenText(avH);
					flag = true;
					if (list == null)
					{
						list = new List<string>();
					}
					string text;
					while ((text = streamReader.ReadLine()) != null)
					{
						if (text.StartsWith(Class333.agl()))
						{
							list.Add(text.Substring(Class333.agl().Length));
						}
					}
				}
				catch (Exception ex)
				{
					Class23.smethod_3(Class333.agp() + ex.Message);
				}
				num--;
			}
			while (num != 0 && !flag);
		}
		return list;
	}

	internal static string smethod_12(byte[] byte_0, string string_0, out Class240 class240_0)
	{
		class240_0 = null;
		string text = null;
		lock (avJ)
		{
			if (!Directory.Exists(avG))
			{
				Directory.CreateDirectory(avG);
			}
			string text2 = avG + Class333.smethod_177() + string_0;
			File.WriteAllBytes(text2, byte_0);
			Class239 @class = smethod_0(text2);
			byte[] array = null;
			using (MD5 mD = MD5.Create())
			{
				array = mD.ComputeHash(byte_0);
			}
			string text3 = Class24.smethod_0(array);
			class240_0 = new Class240
			{
				axS = @class.axq,
				axs = @class.axR,
				axT = @class.axr,
				axt = array
			};
			string text4 = Class242.smethod_4(@class.axq, @class.axR, @class.axr);
			string text5 = avG + Class333.smethod_177() + text4;
			if (File.Exists(text5))
			{
				if (smethod_4(text5) == text3)
				{
					int num = 5;
					do
					{
						try
						{
							File.Delete(text2);
						}
						catch
						{
							num--;
							if (num != 0)
							{
								Thread.Sleep(200);
							}
							continue;
						}
						break;
					}
					while (num != 0);
				}
				else
				{
					text5 = avG + Class333.smethod_177() + text3 + Class333.smethod_100() + text4;
					int num2 = 5;
					do
					{
						try
						{
							if (File.Exists(text5))
							{
								File.Delete(text2);
							}
							else
							{
								File.Move(text2, text5);
							}
						}
						catch
						{
							num2--;
							if (num2 != 0)
							{
								Thread.Sleep(200);
							}
							continue;
						}
						break;
					}
					while (num2 != 0);
				}
			}
			else
			{
				string[] files = Directory.GetFiles(avG, Class333.agL());
				bool flag = false;
				string[] array2 = files;
				foreach (string text6 in array2)
				{
					if (Path.GetFullPath(text6) != Path.GetFullPath(text2) && smethod_4(text6) == text3)
					{
						flag = true;
						text5 = text6;
						break;
					}
				}
				int num3 = 5;
				do
				{
					try
					{
						if (flag)
						{
							File.Delete(text2);
						}
						else
						{
							File.Move(text2, text5);
						}
					}
					catch
					{
						num3--;
						if (num3 != 0)
						{
							Thread.Sleep(200);
						}
						continue;
					}
					break;
				}
				while (num3 != 0);
			}
			return text5;
		}
	}

	internal static List<string> smethod_13(string string_0)
	{
		List<string> list = new List<string>();
		if (Directory.Exists(Class320.Bdl))
		{
			try
			{
				using FileStream stream_ = File.OpenRead(string_0);
				List<string> list2 = Class31.smethod_8(stream_, null);
				for (int i = 0; i < list2.Count; i++)
				{
					string text = list2[i];
					if (!text.EndsWith(Class333.smethod_1402()) && !text.EndsWith(Class333.agQ()))
					{
						continue;
					}
					Stream stream_2 = null;
					if (Class31.smethod_5(stream_, text, out stream_2, null))
					{
						byte[] byte_;
						using (BinaryReader binaryReader = new BinaryReader(stream_2))
						{
							byte_ = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
						}
						string text2 = smethod_12(byte_, Class333.agq() + text, out var _);
						if (text2 != null)
						{
							list.Add(text2);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.agR() + ex.Message);
			}
		}
		return list;
	}

	internal static void smethod_14(string string_0)
	{
		bool lockTaken = false;
		try
		{
			Monitor.TryEnter(Class320.Bdn, ref lockTaken);
			if (!lockTaken)
			{
				smethod_13(string_0);
				return;
			}
			Class318 @class = Class307.smethod_0(string_0);
			if (@class != null)
			{
				foreach (Class316 item in @class.BdF)
				{
					if (string.IsNullOrEmpty(smethod_8(item.BdC.axS, item.BdC.axs, item.BdC.axT, item.BdC.axt, bool_0: false)))
					{
						smethod_13(string_0);
						break;
					}
				}
				return;
			}
			smethod_13(string_0);
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.agr() + ex.Message);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(Class320.Bdn);
			}
		}
	}

	internal static void smethod_15()
	{
		smethod_6();
		if (Directory.Exists(Class320.Bdl))
		{
			string[] files;
			try
			{
				files = Directory.GetFiles(Class320.Bdl, Class333.aCe());
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.agS() + ex.Message);
				return;
			}
			avj = 0;
			int num = 0;
			string[] array = files;
			for (int i = 0; i < array.Length; i++)
			{
				smethod_14(array[i]);
				num++;
				avj = num * 100 / files.Length;
				Thread.Sleep(0);
			}
			avj = 100;
		}
		smethod_6();
	}
}
