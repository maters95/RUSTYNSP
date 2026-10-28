using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using NSP.SettingsFramework;
using ns0;
using ns1;
using ns3;
using ns4;
using ns6;
using ns7;

namespace ns5;

internal class Class237
{
	internal enum Enum91 : byte
	{
		Brc,
		BrD,
		Brd,
		BrE,
		Bre,
		BrF
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class238
	{
		public static readonly Class238 Brf = new Class238();

		public static Action BrG;

		public static Converter<string, int> Brg;

		internal void method_0()
		{
			Form54.smethod_6(Form23.form23_0, Class333.BdG(), Class333.Bdg(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		internal int method_1(string string_0)
		{
			return int.Parse(string_0);
		}
	}

	private Framework aXO;

	private string aXo;

	private int aXP;

	private List<string> aXp = new List<string>();

	internal const int aXQ = 20;

	internal Class237(Framework framework_0, string string_0)
	{
		aXO = framework_0;
		aXo = string_0;
		aXP = 0;
	}

	internal Enum91 method_0()
	{
		Stream stream = null;
		try
		{
			stream = Class35.smethod_7(aXo, Class19.smethod_2());
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.ahC() + ex.Message);
			return Enum91.BrD;
		}
		bool flag;
		try
		{
			flag = Class31.smethod_7(stream);
		}
		catch (Exception)
		{
			flag = false;
		}
		XmlReader xmlReader = null;
		Stream stream_ = null;
		try
		{
			if (flag)
			{
				if (!Class31.smethod_5(stream, Class333.agH(), out stream_, null))
				{
					stream.Close();
					Class23.smethod_3(Class333.ahc());
					return Enum91.BrD;
				}
			}
			else
			{
				stream_ = stream;
			}
			xmlReader = XmlReader.Create(stream_);
		}
		catch (Exception ex3)
		{
			Class23.smethod_3(Class333.ahD() + ex3.Message);
			return Enum91.BrD;
		}
		Enum91 result = Enum91.Bre;
		bool flag2 = false;
		try
		{
			xmlReader.Read();
			while (xmlReader.NodeType != XmlNodeType.Element)
			{
				xmlReader.Read();
			}
			if (!xmlReader.IsEmptyElement)
			{
				if (aXO.awZ != int.Parse(xmlReader.GetAttribute(Class333.agh())) || aXO.awz != int.Parse(xmlReader.GetAttribute(Class333.agI())) || aXO.aXA != new Class14(xmlReader.GetAttribute(Class333.smethod_197()), bool_0: false))
				{
					result = Enum91.Brd;
					throw new Exception(Class333.ahd());
				}
				aXO.aXa = xmlReader.GetAttribute(Class333.agi());
				bool flag3;
				Version version = (((!(flag3 = Class242.smethod_12(aXO.awZ)) || !(aXO.aXA >= new Class14(3, 0, 0, 0, 0))) && flag3) ? new Version(0, 0, 0) : new Version(aXO.aXa));
				if (Assembly.GetEntryAssembly().GetName().Version < version)
				{
					result = Enum91.BrE;
					throw new Exception(Class333.ahE());
				}
				flag2 = true;
				xmlReader.Read();
				while (xmlReader.IsStartElement())
				{
					bool flag4 = true;
					string name = xmlReader.Name;
					if (name == null)
					{
						goto IL_03cf;
					}
					switch (name.Length)
					{
					case 5:
						break;
					case 6:
						goto IL_029b;
					case 8:
						goto IL_02c3;
					case 9:
						goto IL_032e;
					case 10:
						goto IL_0353;
					case 13:
						goto IL_0372;
					case 17:
						goto IL_0391;
					case 18:
						goto IL_03b0;
					default:
						goto IL_03cf;
					}
					char c = name[0];
					if (c != 'T')
					{
						if (c != 'U' || !(name == Class333.smethod_282()))
						{
							goto IL_03cf;
						}
						if (!xmlReader.IsEmptyElement)
						{
							method_3(xmlReader);
						}
					}
					else
					{
						if (!(name == Class333.ahf()))
						{
							goto IL_03cf;
						}
						if (!xmlReader.IsEmptyElement)
						{
							method_48(xmlReader);
						}
					}
					goto IL_03d2;
					IL_02c3:
					c = name[0];
					if (c != 'M')
					{
						if (c != 'S' || !(name == Class333.ahG()))
						{
							goto IL_03cf;
						}
						if (!xmlReader.IsEmptyElement)
						{
							method_8(xmlReader);
						}
					}
					else
					{
						if (!(name == Class333.ahg()))
						{
							goto IL_03cf;
						}
						if (!xmlReader.IsEmptyElement)
						{
							method_54(xmlReader);
						}
					}
					goto IL_03d2;
					IL_029b:
					if (!(name == Class333.ahH()))
					{
						goto IL_03cf;
					}
					if (!xmlReader.IsEmptyElement)
					{
						method_55(xmlReader);
					}
					goto IL_03d2;
					IL_03b0:
					if (!(name == Class333.ahi()))
					{
						goto IL_03cf;
					}
					if (!xmlReader.IsEmptyElement)
					{
						method_6(xmlReader);
					}
					goto IL_03d2;
					IL_03d2:
					if (!flag4)
					{
						xmlReader.Skip();
					}
					else
					{
						xmlReader.Read();
					}
					continue;
					IL_0353:
					if (!(name == Class333.ahh()))
					{
						goto IL_03cf;
					}
					if (!xmlReader.IsEmptyElement)
					{
						method_56(xmlReader);
					}
					goto IL_03d2;
					IL_0391:
					if (!(name == Class333.ahe()))
					{
						goto IL_03cf;
					}
					if (!xmlReader.IsEmptyElement)
					{
						method_1(xmlReader);
					}
					goto IL_03d2;
					IL_03cf:
					flag4 = false;
					goto IL_03d2;
					IL_032e:
					if (!(name == Class333.ahF()))
					{
						goto IL_03cf;
					}
					if (!xmlReader.IsEmptyElement)
					{
						method_2(xmlReader);
					}
					goto IL_03d2;
					IL_0372:
					if (!(name == Class333.ahI()))
					{
						goto IL_03cf;
					}
					if (!xmlReader.IsEmptyElement)
					{
						method_57(xmlReader);
					}
					goto IL_03d2;
				}
			}
			result = Enum91.Brc;
		}
		catch (Exception)
		{
			if (flag2 && !Form23.bool_14)
			{
				Form23.form23_0.Invoke(() =>
				{
					Form54.smethod_6(Form23.form23_0, Class333.BdG(), Class333.Bdg(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				});
			}
		}
		finally
		{
			try
			{
				xmlReader?.Close();
			}
			catch
			{
			}
			try
			{
				stream_?.Close();
			}
			catch
			{
			}
			try
			{
				stream?.Close();
			}
			catch
			{
			}
		}
		return result;
	}

	private void method_1(XmlReader xmlReader_0)
	{
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.ahe()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.smethod_304() && xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				xmlReader_0.Read();
				aXO.awY = xmlReader_0.Value;
				xmlReader_0.Skip();
			}
			else if (xmlReader_0.Name == Class333.smethod_91() && xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				xmlReader_0.Read();
				aXO.awy = xmlReader_0.Value;
				xmlReader_0.Skip();
			}
			else if (xmlReader_0.Name == Class333.ahJ() && xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				xmlReader_0.Read();
				aXO.aXB = xmlReader_0.Value;
				xmlReader_0.Skip();
			}
			else if (xmlReader_0.Name == Class333.ahj() && xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				xmlReader_0.Read();
				aXO.aXb = xmlReader_0.Value;
				xmlReader_0.Skip();
			}
			else if (xmlReader_0.Name == Class333.ahK() && xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				xmlReader_0.Read();
				aXO.aXC = xmlReader_0.Value;
				xmlReader_0.Skip();
			}
			else if (xmlReader_0.Name == Class333.ahk() && xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				aXO.aWR = bool.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
			}
			xmlReader_0.Read();
		}
	}

	private void method_2(XmlReader xmlReader_0)
	{
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.ahF()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.ahl() && xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				aXO.aXL.Add((byte.Parse(xmlReader_0.GetAttribute(Class333.acm())), byte.Parse(xmlReader_0.GetAttribute(Class333.acN()))));
			}
			xmlReader_0.Read();
		}
	}

	private void method_3(XmlReader xmlReader_0)
	{
		Units units = new Units();
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.smethod_282()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.ahM())
			{
				method_4(xmlReader_0, units);
			}
			else if (xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				throw new Exception(string.Format(Class333.ahm(), xmlReader_0.Name));
			}
			xmlReader_0.Read();
		}
		aXO.aXK = units;
	}

	private void method_4(XmlReader xmlReader_0, Units units_0)
	{
		QuantityType quantityType = new QuantityType();
		int key = (quantityType.UnitType = int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.ahM()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.ahN())
			{
				method_5(xmlReader_0, quantityType);
			}
			else if (xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				throw new Exception(string.Format(Class333.ahn(), xmlReader_0.Name));
			}
			xmlReader_0.Read();
		}
		units_0.QuantityTypesPerUnitType.Add(key, quantityType);
	}

	private void method_5(XmlReader xmlReader_0, QuantityType quantityType_0)
	{
		Unit unit = new Unit();
		unit.ListItemVal = int.Parse(xmlReader_0.GetAttribute(Class333.ahO()));
		unit.ListItemText = xmlReader_0.GetAttribute(Class333.aho());
		quantityType_0.UnitsList.Add(unit);
	}

	private void method_6(XmlReader xmlReader_0)
	{
		GlobalImageLibrary globalImageLibrary = new GlobalImageLibrary();
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.ahi()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.ahP())
			{
				method_7(xmlReader_0, globalImageLibrary);
			}
			else if (xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				throw new Exception(string.Format(Class333.ahp(), xmlReader_0.Name));
			}
			xmlReader_0.Read();
		}
		aXO.aXk = globalImageLibrary;
	}

	private void method_7(XmlReader xmlReader_0, GlobalImageLibrary globalImageLibrary_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.smethod_196());
		xmlReader_0.Read();
		string value = xmlReader_0.Value;
		globalImageLibrary_0.ImageItemList.Add(attribute, new ImageItem(value));
		xmlReader_0.Skip();
	}

	private void method_8(XmlReader xmlReader_0)
	{
		string string_ = string.Empty;
		xmlReader_0.Read();
		while (true)
		{
			if (!xmlReader_0.IsStartElement() && xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				return;
			}
			if (xmlReader_0.Name == Class333.ahG() && xmlReader_0.NodeType == XmlNodeType.EndElement)
			{
				break;
			}
			if (xmlReader_0.Name == Class333.smethod_218() || xmlReader_0.Name == Class333.aFU())
			{
				string_ = ((xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) ? string.Empty : xmlReader_0.GetAttribute(Class333.ahQ()));
			}
			else if (!(xmlReader_0.Name == Class333.ahq()) && !(xmlReader_0.Name == Class333.ahR()))
			{
				if ((xmlReader_0.Name == Class333.smethod_1799() || xmlReader_0.Name == Class333.smethod_960()) && xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
				{
					method_11(xmlReader_0, string_, null);
				}
				else if (xmlReader_0.Name == Class333.ahr() && xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
				{
					method_10(xmlReader_0);
				}
				else if (xmlReader_0.Name == Class333.ahS() && xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
				{
					method_9(xmlReader_0);
				}
				else
				{
					if (!(xmlReader_0.Name == Class333.smethod_1308()) && !(xmlReader_0.Name == Class333.ahs()))
					{
						throw new Exception(string.Format(Class333.ahT(), xmlReader_0.Name));
					}
					xmlReader_0.Read();
					while (xmlReader_0.NodeType != XmlNodeType.EndElement || (xmlReader_0.Name != Class333.smethod_1308() && xmlReader_0.Name != Class333.ahs()))
					{
						xmlReader_0.Read();
					}
				}
			}
			else
			{
				method_12(xmlReader_0, string_, null);
			}
			xmlReader_0.Read();
		}
		aXO.method_16();
	}

	private void method_9(XmlReader xmlReader_0)
	{
		string text = Class333.smethod_102();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		bool result = false;
		bool.TryParse(xmlReader_0.GetAttribute(Class333.aht()), out result);
		aXO.aWW.Visible = result;
		xmlReader_0.Read();
		while (true)
		{
			if (!(xmlReader_0.Name != Class333.ahS()))
			{
				return;
			}
			if (xmlReader_0.Name == Class333.smethod_390() && xmlReader_0.IsStartElement())
			{
				dictionary = new Dictionary<string, string>();
			}
			else if (xmlReader_0.Name == Class333.smethod_390() && xmlReader_0.NodeType == XmlNodeType.EndElement)
			{
				if (!string.IsNullOrEmpty(text) && !aXO.aWW.ErrorDefs.ContainsKey(text))
				{
					if (dictionary.ContainsKey(Class333.smethod_1087()) && int.TryParse(dictionary[Class333.smethod_1087()], out var result2) && dictionary.ContainsKey(Class333.smethod_1088()))
					{
						aXO.aWW.ErrorIndexToCodeMap.Add(result2, dictionary[Class333.smethod_1088()]);
					}
					aXO.aWW.ErrorDefs.Add(text, dictionary);
				}
			}
			else if ((xmlReader_0.Name == Class333.smethod_1308() || xmlReader_0.Name == Class333.ahs()) && xmlReader_0.IsStartElement())
			{
				string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
				if (attribute != null)
				{
					if (attribute == Class333.smethod_1086())
					{
						string attribute2 = xmlReader_0.GetAttribute(Class333.ahU());
						dictionary.Add(attribute, attribute2);
					}
					else
					{
						xmlReader_0.Read();
						string value = xmlReader_0.Value;
						if (attribute == Class333.ahu())
						{
							if (!int.TryParse(value, out var result3))
							{
								throw new ArgumentException(Class333.ahV());
							}
							aXO.aWW.SeverityArrayDataId = result3;
						}
						else if (attribute == Class333.ahv())
						{
							if (!int.TryParse(value, out var result4))
							{
								throw new ArgumentException(Class333.ahW());
							}
							aXO.aWW.ModeArrayDataId = result4;
						}
						else if (attribute == Class333.ahw())
						{
							if (!int.TryParse(value, out var result5))
							{
								throw new ArgumentException(Class333.ahX());
							}
							aXO.aWW.StatusArrayDataId = result5;
						}
						else
						{
							if (attribute == Class333.smethod_1088())
							{
								text = value;
							}
							dictionary.Add(attribute, value);
						}
					}
				}
			}
			else if (xmlReader_0.Name == Class333.ahx() && xmlReader_0.IsStartElement())
			{
				xmlReader_0.Read();
				string value2 = xmlReader_0.Value;
				if (!(value2 != string.Empty))
				{
					break;
				}
				string[] array = value2.Split('|');
				if (array.Length != 0)
				{
					aXO.aWW.ErrorToSettingMap = Array.ConvertAll(array, (string string_0) => int.Parse(string_0));
				}
			}
			xmlReader_0.Read();
		}
		throw new Exception(Class333.ahY());
	}

	private void method_10(XmlReader xmlReader_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
		string attribute2 = xmlReader_0.GetAttribute(Class333.ahy());
		if (attribute == null)
		{
			throw new Exception(Class333.ahZ());
		}
		DataTableObject dataTableObject;
		if (aXO.awx.ContainsKey(attribute))
		{
			dataTableObject = aXO.awx[attribute];
		}
		else
		{
			dataTableObject = new DataTableObject();
			dataTableObject.Name = attribute;
			aXO.awx.Add(attribute, dataTableObject);
		}
		if (attribute2 != null && bool.TryParse(attribute2, out var _))
		{
			dataTableObject.IsErrorTable = true;
			while (xmlReader_0.IsStartElement() && xmlReader_0.NodeType != XmlNodeType.EndElement)
			{
				if (xmlReader_0.Name == Class333.aIA())
				{
					DataTableColumn dataTableColumn = new DataTableColumn();
					string attribute3 = xmlReader_0.GetAttribute(Class333.aIa());
					string attribute4 = xmlReader_0.GetAttribute(Class333.aIB());
					string attribute5 = xmlReader_0.GetAttribute(Class333.aIb());
					string attribute6 = xmlReader_0.GetAttribute(Class333.aIC());
					string attribute7 = xmlReader_0.GetAttribute(Class333.aIc());
					string attribute8 = xmlReader_0.GetAttribute(Class333.aID());
					string attribute9 = xmlReader_0.GetAttribute(Class333.aht());
					string attribute10 = xmlReader_0.GetAttribute(Class333.aId());
					string attribute11 = xmlReader_0.GetAttribute(Class333.aIE());
					string attribute12 = xmlReader_0.GetAttribute(Class333.aIe());
					string attribute13 = xmlReader_0.GetAttribute(Class333.aIF());
					string attribute14 = xmlReader_0.GetAttribute(Class333.aIf());
					string attribute15 = xmlReader_0.GetAttribute(Class333.aIG());
					if (attribute9 != null && bool.TryParse(attribute9, out var result2))
					{
						dataTableColumn.Visible = result2;
					}
					else
					{
						dataTableColumn.Visible = true;
					}
					dataTableColumn.MenuLink = attribute10;
					dataTableColumn.Tooltip = attribute13;
					DataTableColumnType dataTableColumnType = DataTableColumnType.Text;
					if (attribute4 == null)
					{
						throw new Exception(Class333.aIh() + attribute + Class333.aII());
					}
					if (!(attribute4 == Class333.aIg()))
					{
						if (attribute4 == Class333.aIH())
						{
							dataTableColumnType = DataTableColumnType.Enum;
						}
					}
					else
					{
						dataTableColumnType = DataTableColumnType.Text;
					}
					if (bool.TryParse(attribute14, out var result3) && result3)
					{
						ErrorPanelItem item = new ErrorPanelItem
						{
							Type = dataTableColumnType,
							Text = attribute15,
							ErrorDefKey = attribute3,
							DataId = (int.TryParse(attribute6, out var result4) ? result4 : (-1))
						};
						aXO.aWW.ErrorPanel.Add(item);
					}
					DataGridViewAutoSizeColumnMode autoSize = DataGridViewAutoSizeColumnMode.None;
					if (attribute12 != null)
					{
						if (!(attribute12 == Class333.aIa()))
						{
							if (attribute12 == Class333.aIi())
							{
								autoSize = DataGridViewAutoSizeColumnMode.Fill;
							}
						}
						else
						{
							autoSize = DataGridViewAutoSizeColumnMode.ColumnHeader;
						}
					}
					dataTableColumn.AutoSize = autoSize;
					switch (dataTableColumnType)
					{
					case DataTableColumnType.Enum:
					{
						dataTableColumn.Type = DataTableColumnType.Enum;
						if (attribute3 != null && attribute6 != null && attribute7 != null && attribute11 != null && bool.TryParse(attribute11, out var result6))
						{
							if (attribute8 != null)
							{
								dataTableColumn.EnumValueStr = attribute8;
							}
							dataTableColumn.HeaderText = attribute3;
							dataTableColumn.BindingData = new BindingData
							{
								BindingDataId = attribute6,
								BindingType = ((!(attribute7 == Class333.aIj())) ? DataTableBindType.TwoWay : DataTableBindType.OneWay),
								IsMapped = result6
							};
							dataTableObject.Columns.Add(dataTableColumn);
							break;
						}
						throw new Exception(Class333.aIK() + attribute + Class333.aII());
					}
					case DataTableColumnType.Text:
						dataTableColumn.Type = DataTableColumnType.Text;
						if (attribute3 != null)
						{
							dataTableColumn.HeaderText = attribute3;
							if (attribute5 != null)
							{
								dataTableColumn.PFieldId = attribute5;
							}
							if (attribute6 != null && attribute7 != null && attribute11 != null && bool.TryParse(attribute11, out var result5))
							{
								dataTableColumn.BindingData = new BindingData
								{
									BindingDataId = attribute6,
									BindingType = ((!(attribute7 == Class333.aIj())) ? DataTableBindType.TwoWay : DataTableBindType.OneWay),
									IsMapped = result5
								};
								if (attribute8 != null)
								{
									dataTableColumn.EnumValueStr = attribute8;
								}
							}
							dataTableObject.Columns.Add(dataTableColumn);
							break;
						}
						throw new Exception(Class333.aIJ() + attribute + Class333.aII());
					}
				}
				else if (xmlReader_0.Name == Class333.aIk())
				{
					SearchFilter searchFilter = new SearchFilter();
					string attribute16 = xmlReader_0.GetAttribute(Class333.aIL());
					string attribute17 = xmlReader_0.GetAttribute(Class333.aIl());
					string attribute18 = xmlReader_0.GetAttribute(Class333.aIM());
					if (attribute16 != null && attribute17 != null && attribute18 != null && int.TryParse(attribute18, out var result7))
					{
						searchFilter.Text = attribute16;
						searchFilter.HeaderStr = attribute17;
						searchFilter.MaxChars = result7;
						dataTableObject.Filters.Add(searchFilter);
					}
				}
				else if (xmlReader_0.Name == Class333.aIm())
				{
					CheckboxFilter checkboxFilter = new CheckboxFilter();
					string attribute19 = xmlReader_0.GetAttribute(Class333.aIL());
					string attribute20 = xmlReader_0.GetAttribute(Class333.aIa());
					string attribute21 = xmlReader_0.GetAttribute(Class333.aIN());
					string attribute22 = xmlReader_0.GetAttribute(Class333.aIn());
					if (bool.TryParse(xmlReader_0.GetAttribute(Class333.aIO()), out var result8))
					{
						checkboxFilter.BulkEdit = result8;
					}
					else
					{
						checkboxFilter.BulkEdit = false;
					}
					if (attribute19 != null && attribute20 != null)
					{
						checkboxFilter.Text = attribute19;
						checkboxFilter.Header = attribute20;
						if (attribute21 != null)
						{
							checkboxFilter.OptionsStr = attribute21;
						}
						else
						{
							if (attribute22 == null)
							{
								throw new ArgumentException(Class333.aIo());
							}
							checkboxFilter.EnumSrcDataId = attribute22;
						}
						dataTableObject.Filters.Add(checkboxFilter);
					}
				}
				xmlReader_0.Read();
			}
			return;
		}
		throw new Exception(Class333.ahz());
	}

	private void method_11(XmlReader xmlReader_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
		int num = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
		string attribute2 = xmlReader_0.GetAttribute(Class333.aIp());
		int num2 = -1;
		num2 = ((attribute2 == null) ? aXP : int.Parse(attribute2));
		Setting setting;
		if (attribute.EndsWith(Class333.aIQ()))
		{
			setting = new Table(aXO, attribute, num, num2, settingOrSpecialObject_0, string_0);
		}
		else if (attribute == Class333.aIq())
		{
			setting = new SensorCalibration(aXO, attribute, num, num2, settingOrSpecialObject_0, string_0);
		}
		else if (attribute.EndsWith(Class333.aIR()) || attribute.EndsWith(Class333.aIr()) || attribute.EndsWith(Class333.aIS()))
		{
			setting = new Class244(aXO, attribute, num, num2, settingOrSpecialObject_0, string_0);
		}
		else if (attribute.StartsWith(Class333.aIs()))
		{
			setting = new Class245(aXO, attribute, num, num2, settingOrSpecialObject_0, string_0);
		}
		else
		{
			setting = ((!attribute.StartsWith(Class333.aIT()) || !attribute.EndsWith(Class333.aIt())) ? new Setting(aXO, bool_0: false, attribute, num, num2, settingOrSpecialObject_0, string_0) : new Class243(aXO, attribute, num, num2, settingOrSpecialObject_0, string_0));
		}
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && ((!(xmlReader_0.Name == Class333.smethod_1799()) && !(xmlReader_0.Name == Class333.smethod_960())) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (!(xmlReader_0.Name == Class333.smethod_1308()) && !(xmlReader_0.Name == Class333.ahs()))
			{
				if (!(xmlReader_0.Name == Class333.smethod_1331()) && !(xmlReader_0.Name == Class333.aIU()))
				{
					if (!(xmlReader_0.Name == Class333.smethod_2244()) && !(xmlReader_0.Name == Class333.aIu()))
					{
						if (xmlReader_0.Name == Class333.aIV())
						{
							method_36(xmlReader_0, setting);
						}
						else if (xmlReader_0.Name == Class333.aIv())
						{
							method_41(xmlReader_0, setting);
						}
						else if (xmlReader_0.Name == Class333.aIW())
						{
							method_42(xmlReader_0, setting);
						}
						else if (!(xmlReader_0.Name == Class333.ahq()) && !(xmlReader_0.Name == Class333.ahR()))
						{
							if (!(xmlReader_0.Name == Class333.smethod_1799()) && !(xmlReader_0.Name == Class333.smethod_960()))
							{
								if (xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
								{
									throw new Exception(string.Format(Class333.aIw(), xmlReader_0.Name));
								}
							}
							else
							{
								method_11(xmlReader_0, string_0, setting);
							}
						}
						else
						{
							method_12(xmlReader_0, string_0, setting);
						}
					}
					else if (!xmlReader_0.IsEmptyElement)
					{
						xmlReader_0.Skip();
					}
				}
				else
				{
					method_13(xmlReader_0, string_0, setting);
				}
			}
			else
			{
				method_14(xmlReader_0, setting, -1, Class333.smethod_102());
			}
			xmlReader_0.Read();
		}
		if (settingOrSpecialObject_0 == null)
		{
			aXO.aWS.Add(setting);
		}
		else
		{
			settingOrSpecialObject_0.method_1().Add(setting);
		}
		aXO.aWs.Add(setting.method_69(), setting);
		if (setting.method_57() != -1)
		{
			aXO.aWT.Add(setting.method_57(), setting);
		}
		if (PortFunction.smethod_27(setting))
		{
			aXO.awD.Add(setting);
		}
		if (setting is Class244)
		{
			aXO.awd.Add(setting as Class244);
		}
		if (setting.method_148().Length != 0)
		{
			aXO.aWu.Add(setting);
		}
		if (setting.method_207())
		{
			aXO.aWt.Add(setting);
			if (attribute2 == null)
			{
				setting.method_66(-1);
			}
		}
		else
		{
			if (attribute2 == null)
			{
				aXP += setting.method_278();
			}
			if (num > aXO.aWr)
			{
				aXO.aWr = num;
			}
		}
		if (attribute2 != null && setting.method_65() != -1)
		{
			if (setting.method_207())
			{
				for (int i = 0; i < setting.method_278(); i++)
				{
					aXO.aWQ[setting.method_65() + i] = setting.method_64();
				}
				int num3 = setting.method_65() + setting.method_278();
				if (num3 > aXO.aWn)
				{
					aXO.aWn = num3;
				}
			}
			else
			{
				for (int j = 0; j < setting.method_278(); j++)
				{
					aXO.aWp[setting.method_65() + j] = setting.method_69();
				}
			}
		}
		if (num == 10195)
		{
			setting.method_151(bool_0: true);
		}
		if (setting is Table)
		{
			aXO.aWV.Add(setting as Table);
		}
		if (setting.method_156() != 0)
		{
			aXO.awf.Add(setting.method_156(), setting);
		}
		if (setting.method_14() != 0)
		{
			aXO.awG.Add(setting.method_14(), setting);
		}
	}

	private void method_12(XmlReader xmlReader_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
		SpecialObject specialObject;
		if (attribute == Class333.aIX())
		{
			specialObject = new Class246(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute.EndsWith(Class333.aIx()))
		{
			specialObject = new Class256(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute.EndsWith(Class333.aIY()))
		{
			specialObject = new Class254(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute == Class333.aIy())
		{
			specialObject = new WiFiSetup(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute == Class333.aIZ())
		{
			specialObject = new TableAxis(aXO, AxisType.Column, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute == Class333.aIz())
		{
			specialObject = new TableAxis(aXO, AxisType.Row, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute == Class333.aiA())
		{
			specialObject = new TableAxis(aXO, AxisType.Slice, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute == Class333.aia())
		{
			specialObject = new ChannelsProperties(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute == Class333.aiB())
		{
			specialObject = new KnockDetection(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute.EndsWith(Class333.aib()))
		{
			specialObject = new BezierCurve(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute.EndsWith(Class333.aiC()))
		{
			specialObject = new StateMachine(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute.StartsWith(Class333.aic()))
		{
			specialObject = new StateMachineStage(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute.StartsWith(Class333.aiD()))
		{
			specialObject = new StateMachineError(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute.StartsWith(Class333.aid()))
		{
			specialObject = new FilterOption(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute.StartsWith(Class333.aiE()))
		{
			specialObject = new OnOffSwitchingPoint(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute == Class333.aie())
		{
			specialObject = new Class247(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute.Contains(Class333.aiF()))
		{
			specialObject = new Class251(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute.StartsWith(Class333.aIT()))
		{
			specialObject = new Class250(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute == Class333.aif())
		{
			specialObject = new Class249(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute.StartsWith(Class333.aiG()))
		{
			specialObject = new Class248(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute == Class333.aig())
		{
			specialObject = new Class253(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else if (attribute.StartsWith(Class333.aiH()))
		{
			specialObject = new Class252(aXO, attribute, settingOrSpecialObject_0, string_0);
		}
		else
		{
			specialObject = ((!attribute.StartsWith(Class333.aih())) ? new SpecialObject(aXO, attribute, settingOrSpecialObject_0, string_0) : new Class255(aXO, attribute, settingOrSpecialObject_0, string_0));
		}
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && ((!(xmlReader_0.Name == Class333.ahq()) && !(xmlReader_0.Name == Class333.ahR())) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (!(xmlReader_0.Name == Class333.smethod_1308()) && !(xmlReader_0.Name == Class333.ahs()))
			{
				if (!(xmlReader_0.Name == Class333.smethod_2244()) && !(xmlReader_0.Name == Class333.aIu()))
				{
					if (xmlReader_0.Name == Class333.aIV())
					{
						method_36(xmlReader_0, specialObject);
					}
					else if (!(xmlReader_0.Name == Class333.smethod_1799()) && !(xmlReader_0.Name == Class333.smethod_960()))
					{
						if (!(xmlReader_0.Name == Class333.ahq()) && !(xmlReader_0.Name == Class333.ahR()))
						{
							if (xmlReader_0.Name == Class333.aiI() && specialObject is Class256)
							{
								method_45(xmlReader_0, specialObject as Class256);
							}
							else if (xmlReader_0.Name == Class333.aii() && specialObject is Class256)
							{
								method_46(xmlReader_0, specialObject as Class256);
							}
							else if (xmlReader_0.Name == Class333.aiJ())
							{
								method_47(xmlReader_0);
							}
							else if (xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
							{
								throw new Exception(string.Format(Class333.aij(), xmlReader_0.Name));
							}
						}
						else
						{
							method_12(xmlReader_0, string_0, specialObject);
						}
					}
					else
					{
						method_11(xmlReader_0, string_0, specialObject);
					}
				}
				else if (!xmlReader_0.IsEmptyElement)
				{
					xmlReader_0.Skip();
				}
			}
			else
			{
				method_14(xmlReader_0, specialObject, -1, Class333.smethod_102());
			}
			xmlReader_0.Read();
		}
		if (settingOrSpecialObject_0 == null)
		{
			aXO.aWS.Add(specialObject);
		}
		else
		{
			settingOrSpecialObject_0.method_1().Add(specialObject);
		}
		if (specialObject.method_57() != -1)
		{
			aXO.aWT.Add(specialObject.method_57(), specialObject);
		}
		if (specialObject is Class246)
		{
			aXO.awI = specialObject as Class246;
		}
		if (specialObject.method_64().ayR != Enum104.BAB)
		{
			if (!aXO.awb.ContainsKey(specialObject.method_64().ayR))
			{
				aXO.awb.Add(specialObject.method_64().ayR, new List<Connector>());
			}
			aXO.awb[specialObject.method_64().ayR].Add(specialObject.method_64());
		}
		if (!string.IsNullOrEmpty(specialObject.method_65().BbR))
		{
			aXO.awc.Add(specialObject.method_65());
			if (settingOrSpecialObject_0 is SpecialObject specialObject2 && !string.IsNullOrEmpty(specialObject2.method_64().ayr))
			{
				if (specialObject2.method_64().ayS == null)
				{
					specialObject2.method_64().ayS = new SortedList<int, WiringPin>();
				}
				if (specialObject.method_65().BbT != -1)
				{
					specialObject2.method_64().ayS.Add(specialObject.method_65().BbT, specialObject.method_65());
				}
				else
				{
					string text = string.Empty;
					string bbs = specialObject.method_65().Bbs;
					foreach (char c in bbs)
					{
						if (char.IsDigit(c))
						{
							text += c;
						}
					}
					int key = ((text.Length != 0) ? int.Parse(text) : specialObject2.method_64().ayS.Count);
					specialObject2.method_64().ayS.Add(key, specialObject.method_65());
				}
			}
		}
		if (PortFunction.smethod_27(specialObject))
		{
			aXO.awD.Add(specialObject);
		}
		if (specialObject.method_12().Bbb != -1)
		{
			aXO.aWY.Add(specialObject);
			foreach (SettingOrSpecialObject item in specialObject.method_1())
			{
				if (!(item is Setting setting) || setting.method_199() != 1 || !setting.method_154())
				{
					continue;
				}
				List<Setting.ListItems.Struct45> list = setting.method_102();
				if ((list.Count != 2 && list.Count != 3) || (!setting.method_2().EndsWith(Class333.smethod_532()) && !setting.method_2().EndsWith(Class333.smethod_533()) && !setting.method_2().EndsWith(Class333.smethod_534())) || setting.method_2().EndsWith(Class333.aiK()) || !list[0].bBV.StartsWith(Class333.aik()) || !list[1].bBV.StartsWith(Class333.smethod_533()))
				{
					continue;
				}
				Setting setting2 = setting;
				setting2.method_151(bool_0: true);
				if (!(setting2 is Class245))
				{
					aXO.aWZ.Add(setting2.method_64());
					if (specialObject.method_1().IndexOf(setting2) != 0)
					{
						specialObject.method_1().Remove(setting2);
						specialObject.method_1().Insert(0, setting2);
					}
					break;
				}
			}
		}
		if (specialObject is WiFiSetup)
		{
			aXO.aWZ.Add(10195);
		}
		if (specialObject is Class256)
		{
			int key2 = (specialObject as Class256).method_8();
			aXO.awF.Add(key2, specialObject as Class256);
		}
		if (specialObject is Class254)
		{
			Class254 @class = specialObject as Class254;
			if (!string.IsNullOrEmpty(@class.method_71()))
			{
				aXO.aWv.Add(@class.method_71(), @class);
			}
		}
		if (aXO.awh == null && specialObject.method_13().DataIdOfChannelListSetting != 0)
		{
			aXO.awh = specialObject;
		}
		if (specialObject is KnockDetection)
		{
			aXO.awO = specialObject as KnockDetection;
		}
		if (specialObject is Class247)
		{
			aXO.awP = specialObject as Class247;
		}
		if (specialObject is Class249)
		{
			aXO.awp = specialObject as Class249;
		}
		if (specialObject is Class253)
		{
			aXO.awQ = specialObject as Class253;
		}
		if (specialObject is Class251)
		{
			aXO.awq.Add(specialObject as Class251);
		}
		if (specialObject.method_14() != 0)
		{
			aXO.awG.Add(specialObject.method_14(), specialObject);
		}
		if (aXp.Contains(attribute))
		{
			if (aXO.aWY.Contains(specialObject))
			{
				aXO.aWx.Add(specialObject);
			}
		}
		else
		{
			aXp.Add(attribute);
		}
	}

	private void method_13(XmlReader xmlReader_0, string string_0, SettingOrSpecialObject settingOrSpecialObject_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
		int int_ = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
		string attribute2 = xmlReader_0.GetAttribute(Class333.aIp());
		int num = -1;
		Setting setting = new Setting(int_1: (attribute2 == null) ? aXP : int.Parse(attribute2), framework_0: aXO, bool_0: true, string_0: attribute, int_0: int_, settingOrSpecialObject_0: settingOrSpecialObject_0, string_1: string_0);
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && ((!(xmlReader_0.Name == Class333.smethod_1331()) && !(xmlReader_0.Name == Class333.aIU())) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (!(xmlReader_0.Name == Class333.smethod_1308()) && !(xmlReader_0.Name == Class333.ahs()))
			{
				if (xmlReader_0.Name == Class333.aIv())
				{
					method_41(xmlReader_0, setting);
				}
				else if (xmlReader_0.Name == Class333.aIW())
				{
					method_42(xmlReader_0, setting);
				}
				else if (xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
				{
					throw new Exception(string.Format(Class333.aiL(), xmlReader_0.Name));
				}
			}
			else
			{
				method_14(xmlReader_0, setting, -1, Class333.smethod_102());
			}
			xmlReader_0.Read();
		}
		if (settingOrSpecialObject_0 == null)
		{
			aXO.aWS.Add(setting);
		}
		else
		{
			settingOrSpecialObject_0.method_1().Add(setting);
		}
		aXO.aWs.Add(setting.method_69(), setting);
		if (setting.method_148().Length != 0)
		{
			aXO.aWu.Add(setting);
		}
		if (attribute2 == null)
		{
			aXP += setting.method_278();
		}
		if (attribute2 != null && setting.method_65() != -1)
		{
			for (int i = 0; i < setting.method_278(); i++)
			{
				aXO.aWp[setting.method_65() + i] = setting.method_69();
			}
		}
	}

	private void method_14(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, int int_0, string string_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
		if (string.IsNullOrEmpty(attribute))
		{
			throw new Exception(string.Format(Class333.ail() + settingOrSpecialObject_0.method_2() + Class333.aiM(), default(ReadOnlySpan<object>)));
		}
		string string_1 = string.Empty;
		string string_2 = string.Empty;
		bool bool_ = false;
		int int_1 = 0;
		Setting setting = settingOrSpecialObject_0 as Setting;
		if (attribute != null)
		{
			switch (attribute.Length)
			{
			case 3:
				switch (attribute[1])
				{
				case 'i':
					if (attribute == Class333.aJn())
					{
						if (method_30(xmlReader_0, ref int_1, ref bool_, ref string_2))
						{
							setting?.method_213(Enum94.aYl, int_1, bool_, string_2, int_0);
						}
						return;
					}
					break;
				case 'a':
					if (attribute == Class333.aJO())
					{
						if (method_30(xmlReader_0, ref int_1, ref bool_, ref string_2))
						{
							setting?.method_213(Enum94.aYM, int_1, bool_, string_2, int_0);
						}
						return;
					}
					break;
				}
				break;
			case 4:
				if (!(attribute == Class333.aiv()))
				{
					break;
				}
				if (int_0 == -1 && setting != null)
				{
					string attribute14 = xmlReader_0.GetAttribute(Class333.ahL());
					if (attribute14 == Class333.aJx())
					{
						setting.method_200(2);
						setting.method_202(bool_0: false);
					}
					else if (attribute14 == Class333.smethod_2237())
					{
						setting.method_200(1);
						setting.method_202(bool_0: false);
					}
					else if (attribute14 == Class333.aJY())
					{
						setting.method_200(4);
						setting.method_202(bool_0: true);
					}
					else if (attribute14 == Class333.aJy())
					{
						setting.method_200(2);
						setting.method_202(bool_0: true);
					}
					else if (attribute14 == Class333.aJZ())
					{
						setting.method_200(1);
						setting.method_202(bool_0: true);
					}
				}
				return;
			case 5:
				if (!(attribute == Class333.aJw()))
				{
					break;
				}
				return;
			case 6:
				if (!(attribute == Class333.aJW()))
				{
					break;
				}
				return;
			case 7:
				switch (attribute[0])
				{
				case 'W':
					if (attribute == Class333.aJo())
					{
						if (method_30(xmlReader_0, ref int_1, ref bool_, ref string_2))
						{
							setting?.method_213(Enum94.aYn, int_1, bool_, string_2, int_0);
						}
						return;
					}
					break;
				case 'B':
					if (attribute == Class333.aJP())
					{
						if (settingOrSpecialObject_0 is Class255 && int.TryParse(xmlReader_0.GetAttribute(Class333.aIP()), out var result3))
						{
							method_31(xmlReader_0, ref string_1);
							(settingOrSpecialObject_0 as Class255).method_71().Add(string_1, result3);
						}
						return;
					}
					break;
				}
				break;
			case 8:
				switch (attribute[3])
				{
				case 'e':
					if (attribute == Class333.aiQ())
					{
						if (int_0 == -1)
						{
							settingOrSpecialObject_0.method_58(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return;
					}
					break;
				case 'g':
					if (attribute == Class333.smethod_574())
					{
						method_31(xmlReader_0, ref string_1);
						settingOrSpecialObject_0.method_59(Enum96.aYt, string_1, int_0);
						return;
					}
					break;
				case 'i':
					if (!(attribute == Class333.aiO()))
					{
						break;
					}
					if (setting != null)
					{
						if (xmlReader_0.GetAttribute(Class333.ahL()) == Class333.ajD())
						{
							setting.method_213(Enum94.aYQ, 1, bool_0: false, Class333.smethod_102(), int_0);
						}
						else
						{
							setting.method_213(Enum94.aYQ, 0, bool_0: false, Class333.smethod_102(), int_0);
						}
					}
					return;
				case 'm':
					if (!(attribute == Class333.aiN()))
					{
						break;
					}
					if (int_0 == -1 && setting != null)
					{
						setting.method_73(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						if (setting.method_72())
						{
							aXO.aWw.Add(setting);
						}
					}
					return;
				case 'n':
					if (attribute == Class333.ain())
					{
						if (method_30(xmlReader_0, ref int_1, ref bool_, ref string_2))
						{
							setting?.method_213(Enum94.aYO, int_1, bool_, string_2, int_0);
						}
						return;
					}
					break;
				case 'o':
					if (attribute == Class333.aim())
					{
						if (int_0 == -1)
						{
							setting?.method_71(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return;
					}
					break;
				case 'p':
					if (attribute == Class333.aip())
					{
						method_31(xmlReader_0, ref string_1);
						setting?.method_196(string_1);
						return;
					}
					break;
				case 't':
					if (!(attribute == Class333.aio()))
					{
						break;
					}
					if (method_30(xmlReader_0, ref int_1, ref bool_, ref string_2))
					{
						setting?.method_213(Enum94.aYP, int_1, bool_, string_2, int_0);
					}
					if (int_0 == -1 && setting != null)
					{
						string attribute13 = xmlReader_0.GetAttribute(Class333.ajb());
						if (attribute13 != null)
						{
							setting.method_233(int.Parse(attribute13));
						}
						else
						{
							setting.method_233(0);
						}
					}
					return;
				case 'u':
					if (attribute == Class333.aiP())
					{
						method_31(xmlReader_0, ref string_1);
						settingOrSpecialObject_0.method_59(Enum96.aYu, string_1, int_0);
						return;
					}
					break;
				case 'w':
					if (!(attribute == Class333.aiR()))
					{
						break;
					}
					return;
				case 'a':
					if (attribute == Class333.aGX())
					{
						if (int_0 == -1)
						{
							setting?.method_149(xmlReader_0.GetAttribute(Class333.ahL()));
						}
						return;
					}
					break;
				case 'L':
					if (!(attribute == Class333.aiq()))
					{
						break;
					}
					return;
				}
				break;
			case 9:
				switch (attribute[5])
				{
				case 'T':
					if (attribute == Class333.aJK())
					{
						if (int_0 == -1)
						{
							settingOrSpecialObject_0.method_63(xmlReader_0.GetAttribute(Class333.ahL()));
						}
						return;
					}
					break;
				case 'N':
					if (attribute == Class333.smethod_575())
					{
						method_31(xmlReader_0, ref string_1);
						settingOrSpecialObject_0.method_59(Enum96.aYT, string_1, int_0);
						return;
					}
					break;
				case 'C':
					if (attribute == Class333.aJl())
					{
						method_31(xmlReader_0, ref string_1);
						settingOrSpecialObject_0.method_56(string_1);
						return;
					}
					break;
				case 't':
					if (!(attribute == Class333.aJM()) && !(attribute == Class333.aJm()))
					{
						break;
					}
					return;
				case 'r':
					if (attribute == Class333.aJL())
					{
						if (int_0 == -1)
						{
							setting?.method_239(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return;
					}
					break;
				case 'a':
					if (attribute == Class333.aJj())
					{
						if (method_30(xmlReader_0, ref int_1, ref bool_, ref string_2))
						{
							setting?.method_213(Enum94.aYS, int_1, bool_, string_2, int_0);
						}
						return;
					}
					break;
				case 'b':
					if (attribute == Class333.aJk())
					{
						if (int_0 == -1)
						{
							setting?.method_155(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return;
					}
					break;
				case 'c':
					if (!(attribute == Class333.aJN()))
					{
						break;
					}
					return;
				}
				break;
			case 10:
				switch (attribute[8])
				{
				case 'a':
					if (attribute == Class333.aiT())
					{
						if (method_30(xmlReader_0, ref int_1, ref bool_, ref string_2))
						{
							setting?.method_213(Enum94.aYN, int_1, bool_, string_2, int_0);
						}
						return;
					}
					break;
				case 'I':
					if (attribute == Class333.aiV())
					{
						if (settingOrSpecialObject_0 is Class255 && int.TryParse(xmlReader_0.GetAttribute(Class333.ahL()), out var result2))
						{
							(settingOrSpecialObject_0 as Class255).method_74(new DataIdAndAttrId(result2));
						}
						return;
					}
					break;
				case 'F':
					if (attribute == Class333.aiU())
					{
						method_31(xmlReader_0, ref string_1);
						settingOrSpecialObject_0.method_59(Enum96.aYv, string_1, int_0);
						return;
					}
					break;
				case 'm':
					if (!(attribute == Class333.aiu()))
					{
						break;
					}
					if (int_0 == -1)
					{
						settingOrSpecialObject_0.method_21(int.Parse(xmlReader_0.GetAttribute(Class333.aIP())));
						string attribute11 = xmlReader_0.GetAttribute(Class333.aje());
						if (!string.IsNullOrEmpty(attribute11))
						{
							settingOrSpecialObject_0.method_17(int.Parse(attribute11));
						}
					}
					return;
				case 'e':
					if (attribute == Class333.smethod_1076())
					{
						string attribute10 = xmlReader_0.GetAttribute(Class333.ajF());
						if (attribute10 != null)
						{
							settingOrSpecialObject_0.method_50(bool.Parse(attribute10));
						}
						method_31(xmlReader_0, ref string_1);
						if (int_0 == -1)
						{
							settingOrSpecialObject_0.method_48(string_1);
						}
						return;
					}
					break;
				case 'g':
					if (attribute == Class333.ait())
					{
						if (method_30(xmlReader_0, ref int_1, ref bool_, ref string_2))
						{
							setting?.method_213(Enum94.aYo, int_1, bool_, string_2, int_0);
						}
						return;
					}
					break;
				case 'i':
					if (attribute == Class333.ais())
					{
						if (method_30(xmlReader_0, ref int_1, ref bool_, ref string_2))
						{
							setting?.method_213(Enum94.aYm, int_1, bool_, string_2, int_0);
						}
						return;
					}
					break;
				case 'u':
				{
					if (!(attribute == Class333.aiS()))
					{
						break;
					}
					if (int_0 != -1 || setting == null)
					{
						return;
					}
					List<int> list = new List<int>();
					string attribute12 = xmlReader_0.GetAttribute(Class333.ahL());
					if (attribute12.StartsWith(Class333.aJz()))
					{
						attribute12 = attribute12.Substring(1, attribute12.Length - 2);
						StringBuilder stringBuilder = new StringBuilder();
						for (int j = 0; j < attribute12.Length; j++)
						{
							if (attribute12[j] != ',')
							{
								stringBuilder.Append(attribute12[j]);
								if (j == attribute12.Length - 1)
								{
									list.Add(int.Parse(stringBuilder.ToString()));
								}
							}
							else
							{
								list.Add(int.Parse(stringBuilder.ToString()));
								stringBuilder.Clear();
							}
						}
					}
					else
					{
						list.Add(int.Parse(attribute12));
					}
					setting.method_218(list);
					return;
				}
				case 'n':
					if (!(attribute == Class333.air()))
					{
						break;
					}
					if (int_0 == -1 && setting != null)
					{
						int[] array3 = new int[3] { 1, 1, 1 };
						string attribute9 = xmlReader_0.GetAttribute(Class333.ahL());
						if (attribute9 != Class333.aJX())
						{
							attribute9 = attribute9.Substring(1, attribute9.Length - 2);
							int num2 = attribute9.IndexOf(',');
							int num3 = attribute9.IndexOf(',', num2 + 1);
							array3[0] = int.Parse(attribute9.Substring(0, num2));
							array3[1] = int.Parse(attribute9.Substring(num2 + 1, num3 - (num2 + 1)));
							array3[2] = int.Parse(attribute9.Substring(num3 + 1));
						}
						setting.method_243(array3);
					}
					return;
				}
				break;
			case 11:
				switch (attribute[2])
				{
				case 'P':
					if (!(attribute == Class333.aga()))
					{
						break;
					}
					return;
				case 'L':
					if (!(attribute == Class333.aJr()))
					{
						break;
					}
					if (setting != null)
					{
						if (xmlReader_0.GetAttribute(Class333.ahL()) == Class333.ajD())
						{
							setting.method_213(Enum94.aYq, 1, bool_0: false, Class333.smethod_102(), int_0);
						}
						else
						{
							setting.method_213(Enum94.aYq, 0, bool_0: false, Class333.smethod_102(), int_0);
						}
					}
					return;
				case 'y':
					if (!(attribute == Class333.aJS()))
					{
						break;
					}
					return;
				case 's':
					if (attribute == Class333.smethod_91())
					{
						method_31(xmlReader_0, ref string_1);
						settingOrSpecialObject_0.method_59(Enum96.aYU, string_1, int_0);
						return;
					}
					break;
				}
				break;
			case 12:
				switch (attribute[0])
				{
				case 'M':
					if (attribute == Class333.aiw())
					{
						method_31(xmlReader_0, ref string_1);
						settingOrSpecialObject_0.method_59(Enum96.aYV, string_1, int_0);
						return;
					}
					break;
				case 'D':
					if (!(attribute == Class333.aiW()))
					{
						break;
					}
					if (int_0 == -1)
					{
						if (setting != null)
						{
							if (setting.method_199() == 0)
							{
								throw new Exception(Class333.aja());
							}
							string text = xmlReader_0.GetAttribute(Class333.ahL());
							if (text.StartsWith(Class333.aJz()) && text.EndsWith(Class333.aGk()))
							{
								text = text.Substring(1, text.Length - 2);
							}
							string[] array2 = text.Split(',');
							int num = setting.method_277();
							if (array2.Length != num)
							{
								throw new Exception(Class333.ajA());
							}
							setting.method_245(new byte[setting.method_278()]);
							for (int i = 0; i < array2.Length; i++)
							{
								Class23.smethod_6(int.Parse(array2[i]), setting.method_244(), i * setting.method_199(), setting.method_199(), aXO.aWR);
							}
							if (num > 1)
							{
								aXO.aWX = true;
							}
						}
						return;
					}
					throw new Exception(Class333.ajB());
				case 'S':
					if (!(attribute == Class333.aix()))
					{
						break;
					}
					return;
				case 'R':
					if (attribute == Class333.aiX())
					{
						if (settingOrSpecialObject_0 is Class255 && int.TryParse(xmlReader_0.GetAttribute(Class333.ahL()), out var result))
						{
							(settingOrSpecialObject_0 as Class255).method_76(new DataIdAndAttrId(result));
						}
						return;
					}
					break;
				}
				break;
			case 13:
				switch (attribute[0])
				{
				case 'R':
					if (attribute == Class333.aJh())
					{
						if (method_30(xmlReader_0, ref int_1, ref bool_, ref string_2))
						{
							setting?.method_213(Enum94.aYp, int_1, bool_, string_2, int_0);
						}
						return;
					}
					break;
				case 'S':
					if (!(attribute == Class333.aJJ()))
					{
						break;
					}
					return;
				case 'V':
					if (attribute == Class333.aJI())
					{
						if (int_0 == -1)
						{
							setting?.method_197(int.Parse(xmlReader_0.GetAttribute(Class333.aIP())), xmlReader_0.GetAttribute(Class333.ajC()));
						}
						return;
					}
					break;
				case 'H':
					if (!(attribute == Class333.aJi()))
					{
						break;
					}
					return;
				case 'F':
					if (attribute == Class333.aJH())
					{
						if (int_0 == -1)
						{
							setting?.method_168(int.Parse(xmlReader_0.GetAttribute(Class333.ajc())));
						}
						return;
					}
					break;
				}
				break;
			case 14:
				switch (attribute[0])
				{
				case 'I':
					if (attribute == Class333.aJT())
					{
						if (int_0 == -1)
						{
							setting?.method_170(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return;
					}
					break;
				case 'A':
				{
					if (!(attribute == Class333.aJu()))
					{
						break;
					}
					if (int_0 != -1 || setting == null)
					{
						return;
					}
					string attribute7 = xmlReader_0.GetAttribute(Class333.ajJ());
					string attribute8 = xmlReader_0.GetAttribute(Class333.ajj());
					if (attribute7 != null && attribute8 != null)
					{
						throw new Exception(Class333.ajK());
					}
					if (attribute7 != null)
					{
						setting.method_192(int.Parse(attribute7));
						return;
					}
					if (attribute8 != null)
					{
						setting.method_194(int.Parse(attribute8));
						return;
					}
					throw new Exception(Class333.ajk());
				}
				case 'U':
					if (attribute == Class333.aJU())
					{
						if (int_0 == -1)
						{
							setting?.method_185(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return;
					}
					break;
				case 'R':
				{
					if (!(attribute == Class333.aJt()))
					{
						break;
					}
					if (int_0 != -1 || setting == null)
					{
						return;
					}
					string[] collection = xmlReader_0.GetAttribute(Class333.ajf()).Split(',');
					List<string> fileExtensions = new List<string>(collection);
					string attribute2 = xmlReader_0.GetAttribute(Class333.ajG());
					setting.method_175((Class1.Enum5)int.Parse(attribute2));
					if (setting.method_174() == Class1.Enum5.BFH)
					{
						if (!fileExtensions.Exists(extension => string.Equals(extension, "gif", StringComparison.OrdinalIgnoreCase)))
						{
							fileExtensions.Add("gif");
						}
						if (!fileExtensions.Exists(extension => string.Equals(extension, "mp4", StringComparison.OrdinalIgnoreCase)))
						{
							fileExtensions.Add("mp4");
						}
					}
					setting.method_173(fileExtensions);
					aXO.awv.Add(setting);
					if (!aXO.aww.ContainsKey(setting.method_174()))
					{
						aXO.aww.Add(setting.method_174(), setting.method_172());
					}
					string attribute3 = xmlReader_0.GetAttribute(Class333.ajg());
					if (attribute3 != null)
					{
						setting.method_177(bool.Parse(attribute3));
						if (setting.method_176())
						{
							aXO.awW = setting;
						}
					}
					string attribute4 = xmlReader_0.GetAttribute(Class333.ajH());
					if (attribute4 != null)
					{
						string[] array = attribute4.Split('x');
						if (array.Length != 2)
						{
							throw new Exception(Class333.ajh());
						}
						setting.method_179(new Size(int.Parse(array[0]), int.Parse(array[1])));
					}
					string attribute5 = xmlReader_0.GetAttribute(Class333.ajI());
					if (attribute5 != null)
					{
						setting.method_181(int.Parse(attribute5));
					}
					string attribute6 = xmlReader_0.GetAttribute(Class333.aji());
					if (attribute6 != null)
					{
						setting.method_183(int.Parse(attribute6));
					}
					return;
				}
				case 'M':
					if (attribute == Class333.aJs())
					{
						method_31(xmlReader_0, ref string_1);
						settingOrSpecialObject_0.method_59(Enum96.aYW, string_1, int_0);
						return;
					}
					break;
				}
				break;
			case 15:
				switch (attribute[1])
				{
				case 't':
					if (!(attribute == Class333.aJG()))
					{
						break;
					}
					if (int_0 == -1 && settingOrSpecialObject_0 is SpecialObject)
					{
						if ((settingOrSpecialObject_0 as SpecialObject).method_68().IdleText != null)
						{
							(settingOrSpecialObject_0 as SpecialObject).method_68().StatusChannelDataId = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
						}
						else if (settingOrSpecialObject_0 is StateMachine)
						{
							(settingOrSpecialObject_0 as StateMachine).StatusChannelDataId = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
						}
					}
					return;
				case 'c':
					if (attribute == Class333.aJf())
					{
						if (int_0 == -1 && setting != null)
						{
							setting.method_89(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
							setting.method_91(int.Parse(xmlReader_0.GetAttribute(Class333.ajb())));
						}
						return;
					}
					break;
				}
				break;
			case 16:
				switch (attribute[1])
				{
				case 'e':
					if (attribute == Class333.aJQ())
					{
						if (int_0 == -1)
						{
							setting?.method_237(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return;
					}
					break;
				case 'c':
					if (attribute == Class333.aJp())
					{
						if (method_30(xmlReader_0, ref int_1, ref bool_, ref string_2))
						{
							setting?.method_213(Enum94.aYL, int_1, bool_, string_2, int_0);
						}
						return;
					}
					break;
				case 't':
					if (attribute == Class333.aJq())
					{
						if (int_0 == -1)
						{
							setting?.method_188(int.Parse(xmlReader_0.GetAttribute(Class333.ajE())));
						}
						return;
					}
					break;
				case 'l':
					if (attribute == Class333.aJR())
					{
						return;
					}
					break;
				}
				break;
			case 17:
				if (attribute == Class333.aJV())
				{
					if (int_0 == -1)
					{
						setting?.method_160(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					}
					return;
				}
				break;
			case 18:
				switch (attribute[0])
				{
				case 'S':
					if (attribute == Class333.aJE())
					{
						if (int_0 == -1)
						{
							setting?.method_87(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						aXO.aWq = true;
						return;
					}
					break;
				case 'I':
					if (!(attribute == Class333.aJe()))
					{
						break;
					}
					if (int_0 == -1)
					{
						int key = int.Parse(xmlReader_0.GetAttribute(Class333.ajc()));
						method_31(xmlReader_0, ref string_1);
						string value = string_1;
						if (!aXO.awg.ContainsKey(key))
						{
							aXO.awg.Add(key, value);
						}
					}
					return;
				case 'E':
					if (attribute == Class333.aJF())
					{
						if (int_0 == -1)
						{
							settingOrSpecialObject_0.method_15(byte.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return;
					}
					break;
				}
				break;
			case 19:
				switch (attribute[17])
				{
				case 'i':
					if (attribute == Class333.aJC())
					{
						if (method_30(xmlReader_0, ref int_1, ref bool_, ref string_2))
						{
							setting?.method_213(Enum94.aYR, int_1, bool_, string_2, int_0);
						}
						return;
					}
					break;
				case 'a':
					if (attribute == Class333.aJc())
					{
						if (method_30(xmlReader_0, ref int_1, ref bool_, ref string_2))
						{
							setting?.method_213(Enum94.aYr, int_1, bool_, string_2, int_0);
						}
						return;
					}
					break;
				}
				break;
			case 20:
				switch (attribute[10])
				{
				case 'S':
					if (attribute == Class333.aiz())
					{
						if (int_0 == -1)
						{
							setting?.method_79(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return;
					}
					break;
				case 'D':
					if (attribute == Class333.aJA())
					{
						if (int_0 == -1)
						{
							setting?.method_157(byte.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return;
					}
					break;
				case 'A':
					if (attribute == Class333.aiZ())
					{
						if (int_0 == -1)
						{
							setting?.method_77(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return;
					}
					break;
				}
				break;
			case 22:
				if (attribute == Class333.aJv())
				{
					if (int_0 == -1 && settingOrSpecialObject_0 is SpecialObject)
					{
						(settingOrSpecialObject_0 as SpecialObject).method_66().ShowCalibrateAllButton = bool.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
					}
					return;
				}
				break;
			case 25:
				switch (attribute[0])
				{
				case 'D':
					if (attribute == Class333.aJd())
					{
						if (int_0 == -1)
						{
							setting?.method_164(new DataIdAndAttrId(int.Parse(xmlReader_0.GetAttribute(Class333.ajd())), int.Parse(xmlReader_0.GetAttribute(Class333.ajE()))));
						}
						return;
					}
					break;
				case 'C':
					if (attribute == Class333.aJD())
					{
						if (int_0 == -1)
						{
							setting?.method_85(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return;
					}
					break;
				}
				break;
			case 27:
				switch (attribute[0])
				{
				case 'S':
					if (attribute == Class333.aiY())
					{
						if (int_0 == -1)
						{
							setting?.method_75(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return;
					}
					break;
				case 'D':
					if (attribute == Class333.aiy())
					{
						if (int_0 == -1)
						{
							setting?.method_190(int.Parse(xmlReader_0.GetAttribute(Class333.ajd())));
						}
						return;
					}
					break;
				}
				break;
			case 28:
				if (attribute == Class333.aJg())
				{
					if (int_0 == -1)
					{
						setting?.method_93(xmlReader_0.GetAttribute(Class333.ajC()));
					}
					return;
				}
				break;
			case 31:
				switch (attribute[0])
				{
				case 'C':
					if (attribute == Class333.aJa())
					{
						if (int_0 == -1)
						{
							setting?.method_81(xmlReader_0.GetAttribute(Class333.aIL()));
						}
						return;
					}
					break;
				case 'A':
					if (attribute == Class333.aJB())
					{
						if (int_0 == -1)
						{
							setting?.method_162(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return;
					}
					break;
				}
				break;
			case 35:
				if (attribute == Class333.aJb())
				{
					method_31(xmlReader_0, ref string_1);
					if (int_0 == -1)
					{
						setting?.method_83(string_1);
					}
					return;
				}
				break;
			}
		}
		if (attribute.StartsWith(Class333.ajL()))
		{
			if (setting != null)
			{
				string attribute15 = xmlReader_0.GetAttribute(Class333.ajC());
				int int_2 = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
				string attribute16 = xmlReader_0.GetAttribute(Class333.ajl());
				string attribute17 = xmlReader_0.GetAttribute(Class333.ajM());
				string attribute18 = xmlReader_0.GetAttribute(Class333.ajm());
				string attribute19 = xmlReader_0.GetAttribute(Class333.ajN());
				int int_3 = 0;
				if (attribute17 != null)
				{
					int_3 = int.Parse(attribute17);
				}
				setting.method_128(attribute, attribute15, int_2, int_3, attribute16, attribute18, attribute19, int_0);
			}
		}
		else if (attribute.StartsWith(Class333.ajn()))
		{
			if (setting != null)
			{
				string attribute20 = xmlReader_0.GetAttribute(Class333.ahL());
				string attribute21 = xmlReader_0.GetAttribute(Class333.ajO());
				if (attribute20 != null && attribute21 != null)
				{
					setting.method_127(int.Parse(attribute20), attribute21);
				}
			}
		}
		else if (attribute.StartsWith(Class333.ajo()))
		{
			string_1 = xmlReader_0.GetAttribute(Class333.ajc());
			int int_4 = int.Parse(string_1);
			method_31(xmlReader_0, ref string_1);
			setting?.method_129(attribute, string_1, int_4, int_0);
		}
		else if (attribute.StartsWith(Class333.ajP()))
		{
			if (setting != null)
			{
				string attribute22 = xmlReader_0.GetAttribute(Class333.ajC());
				int num4 = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
				int int_5 = num4;
				string attribute23 = xmlReader_0.GetAttribute(Class333.ajp());
				if (attribute23 != null)
				{
					int_5 = int.Parse(attribute23);
				}
				setting.method_130(attribute, attribute22, num4, int_5, int_0);
			}
		}
		else if (attribute == Class333.ajQ())
		{
			setting?.method_108(xmlReader_0.GetAttribute(Class333.ajC()));
		}
		else if (attribute.StartsWith(Class333.ajq()))
		{
			if (int_0 == -1)
			{
				setting?.method_158().Add(byte.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
			}
		}
		else if (attribute.StartsWith(Class333.smethod_1086()))
		{
			string attribute24 = xmlReader_0.GetAttribute(Class333.ajR());
			if (attribute24 != null)
			{
				method_33(xmlReader_0, settingOrSpecialObject_0, attribute24);
			}
			else
			{
				method_32(xmlReader_0, settingOrSpecialObject_0, attribute, int_0);
			}
		}
		else if (attribute.StartsWith(Class333.ajr()))
		{
			method_35(xmlReader_0, settingOrSpecialObject_0, attribute, int_0);
		}
		else if (attribute.StartsWith(Class333.ajS()))
		{
			method_31(xmlReader_0, ref string_1);
			if (int_0 == -1)
			{
				settingOrSpecialObject_0.method_23().Add(string_1);
			}
		}
		else if (attribute.StartsWith(Class333.ajs()))
		{
			if (int_0 == -1)
			{
				int num5 = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
				settingOrSpecialObject_0.method_28(num5);
				aXO.aWy.Add(num5, settingOrSpecialObject_0.method_57());
			}
		}
		else if (attribute[0] == 'S' && attribute[1] >= '0' && attribute[1] <= '9')
		{
			string attribute25 = xmlReader_0.GetAttribute(Class333.aIP());
			string attribute26 = xmlReader_0.GetAttribute(Class333.ajT());
			string attribute27 = xmlReader_0.GetAttribute(Class333.ajt());
			string attribute28 = xmlReader_0.GetAttribute(Class333.ajU());
			if (attribute25 == null || !(settingOrSpecialObject_0 is SpecialObject))
			{
				return;
			}
			int num6 = int.Parse(attribute25);
			if (settingOrSpecialObject_0 is Class246)
			{
				(settingOrSpecialObject_0 as Class246).method_71().Add(num6);
				return;
			}
			int int_6 = 0;
			if (attribute26 != null)
			{
				int_6 = int.Parse(attribute26);
			}
			bool bool_2 = false;
			bool bool_3 = false;
			if (attribute27 != null)
			{
				bool_2 = bool.Parse(attribute27);
			}
			if (attribute28 != null)
			{
				bool_3 = bool.Parse(attribute28);
			}
			(settingOrSpecialObject_0 as SpecialObject).method_70(num6, int_6, bool_2, bool_3, int_0, string_0);
		}
		else if (attribute.StartsWith(Class333.aju()))
		{
			string attribute29 = xmlReader_0.GetAttribute(Class333.ajV());
			if (attribute29 != null && settingOrSpecialObject_0 is SpecialObject)
			{
				(settingOrSpecialObject_0 as SpecialObject).method_66().RowObjectId = int.Parse(attribute29);
			}
		}
		else if (attribute.StartsWith(Class333.ajv()))
		{
			string attribute30 = xmlReader_0.GetAttribute(Class333.aIP());
			if (attribute30 != null && settingOrSpecialObject_0 is SpecialObject)
			{
				(settingOrSpecialObject_0 as SpecialObject).method_66().RowIncludeSetting = int.Parse(attribute30);
			}
		}
		else if (!method_17(xmlReader_0, settingOrSpecialObject_0, attribute, int_0, string_0) && !method_18(xmlReader_0, settingOrSpecialObject_0, attribute, int_0, string_0) && !method_19(xmlReader_0, settingOrSpecialObject_0, attribute, int_0, string_0) && !method_20(xmlReader_0, settingOrSpecialObject_0, attribute, int_0, string_0) && !method_21(xmlReader_0, settingOrSpecialObject_0, attribute, int_0, string_0) && !method_29(xmlReader_0, settingOrSpecialObject_0, attribute, int_0, string_0) && !method_28(xmlReader_0, settingOrSpecialObject_0, attribute, int_0, string_0) && !method_15(xmlReader_0, settingOrSpecialObject_0, attribute, int_0, string_0) && !method_16(xmlReader_0, settingOrSpecialObject_0, attribute, int_0, string_0) && !method_27(xmlReader_0, settingOrSpecialObject_0, attribute, int_0, string_0) && !method_22(xmlReader_0, settingOrSpecialObject_0, attribute, int_0, string_0) && !method_23(xmlReader_0, settingOrSpecialObject_0, attribute, int_0, string_0) && !method_24(xmlReader_0, settingOrSpecialObject_0, attribute, int_0, string_0) && !method_25(xmlReader_0, settingOrSpecialObject_0, attribute, int_0, string_0) && !method_26(xmlReader_0, settingOrSpecialObject_0, attribute, int_0, string_0))
		{
			string attribute31 = xmlReader_0.GetAttribute(Class333.aIB());
			if (attribute31 != null && attribute31 == Class333.aIg())
			{
				method_31(xmlReader_0, ref string_1);
			}
			else if (!xmlReader_0.IsEmptyElement)
			{
				xmlReader_0.Skip();
			}
		}
	}

	private bool method_15(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0, string string_1)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.aIP());
		if (string_0 != null)
		{
			switch (string_0.Length)
			{
			case 15:
				if (string_0 == Class333.ajw())
				{
					if (settingOrSpecialObject_0 is TableAxis)
					{
						(settingOrSpecialObject_0 as TableAxis).method_75(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					}
					return true;
				}
				break;
			case 16:
				if (string_0 == Class333.ajX())
				{
					if (settingOrSpecialObject_0 is TableAxis)
					{
						(settingOrSpecialObject_0 as TableAxis).method_77(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					}
					return true;
				}
				break;
			case 17:
				if (string_0 == Class333.ajy())
				{
					if (settingOrSpecialObject_0 is Setting setting)
					{
						setting.method_241(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					}
					return true;
				}
				break;
			case 4:
				if (string_0 == Class333.smethod_796())
				{
					if (attribute != null && settingOrSpecialObject_0 is TableAxis)
					{
						(settingOrSpecialObject_0 as TableAxis).method_83(int.Parse(attribute));
					}
					return true;
				}
				break;
			case 5:
				if (string_0 == Class333.smethod_800())
				{
					if (attribute != null && settingOrSpecialObject_0 is TableAxis)
					{
						(settingOrSpecialObject_0 as TableAxis).method_81(int.Parse(attribute));
					}
					return true;
				}
				break;
			case 6:
				if (!(string_0 == Class333.ajW()))
				{
					break;
				}
				goto IL_01b0;
			case 7:
			{
				char c = string_0[0];
				if (c != 'C')
				{
					if (c == 'E' && string_0 == Class333.smethod_420())
					{
						if (attribute != null && settingOrSpecialObject_0 is TableAxis)
						{
							(settingOrSpecialObject_0 as TableAxis).method_79(int.Parse(attribute));
						}
						return true;
					}
					break;
				}
				if (!(string_0 == Class333.smethod_814()))
				{
					break;
				}
				goto IL_01b0;
			}
			case 31:
				if (string_0 == Class333.ajx())
				{
					if (settingOrSpecialObject_0 is Table)
					{
						(settingOrSpecialObject_0 as Table).AllCellsOnFirstColumnMustBeZero = bool.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
					}
					return true;
				}
				break;
			case 28:
				{
					if (string_0 == Class333.ajY())
					{
						if (settingOrSpecialObject_0 is Table)
						{
							(settingOrSpecialObject_0 as Table).AllCellsOnFirstRowMustBeZero = bool.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
						}
						return true;
					}
					break;
				}
				IL_01b0:
				if (attribute != null && settingOrSpecialObject_0 is TableAxis)
				{
					(settingOrSpecialObject_0 as TableAxis).method_85(int.Parse(attribute));
				}
				return true;
			}
		}
		return false;
	}

	private bool method_16(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0, string string_1)
	{
		if (!(string_0 == Class333.ajZ()))
		{
			if (!(string_0 == Class333.ajz()))
			{
				return false;
			}
			if (settingOrSpecialObject_0 is OnOffSwitchingPoint)
			{
				(settingOrSpecialObject_0 as OnOffSwitchingPoint).ColumnChannelDataId = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
			}
			return true;
		}
		if (settingOrSpecialObject_0 is OnOffSwitchingPoint)
		{
			(settingOrSpecialObject_0 as OnOffSwitchingPoint).RowChannelDataId = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
		}
		return true;
	}

	private bool method_17(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0, string string_1)
	{
		string string_2 = string.Empty;
		if (string_0 != null)
		{
			switch (string_0.Length)
			{
			case 14:
				if (string_0 == Class333.aKa())
				{
					if (int_0 == -1)
					{
						settingOrSpecialObject_0.method_12().Bbb = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
					}
					return true;
				}
				break;
			case 10:
				if (string_0 == Class333.aKd())
				{
					settingOrSpecialObject_0.method_12().method_9(uint.Parse(xmlReader_0.GetAttribute(Class333.ahL())), Class333.smethod_102(), int_0);
					return true;
				}
				break;
			case 6:
				if (string_0 == Class333.aKA())
				{
					settingOrSpecialObject_0.method_12().method_11(uint.Parse(xmlReader_0.GetAttribute(Class333.ahL())), xmlReader_0.GetAttribute(Class333.aKe()), int_0);
					return true;
				}
				break;
			case 20:
				if (string_0 == Class333.aKD())
				{
					if (int_0 == -1)
					{
						settingOrSpecialObject_0.method_12().BbC = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
					}
					return true;
				}
				break;
			case 16:
				switch (string_0[12])
				{
				case 'T':
					if (string_0 == Class333.aKb())
					{
						return true;
					}
					break;
				case 'P':
					if (string_0 == Class333.aKC())
					{
						method_31(xmlReader_0, ref string_2);
						return true;
					}
					break;
				case 'N':
				{
					if (!(string_0 == Class333.aKc()))
					{
						break;
					}
					string attribute = xmlReader_0.GetAttribute(Class333.aIB());
					bool flag = false;
					if (attribute != null)
					{
						flag = attribute == Class333.aIg();
					}
					if (flag)
					{
						method_31(xmlReader_0, ref string_2);
						if (int_0 == -1)
						{
							settingOrSpecialObject_0.method_12().method_4(string_2);
						}
					}
					else if (int_0 == -1)
					{
						settingOrSpecialObject_0.method_12().method_3(int.Parse(xmlReader_0.GetAttribute(Class333.aIP())));
					}
					return true;
				}
				}
				break;
			case 25:
				if (string_0 == Class333.aKE())
				{
					settingOrSpecialObject_0.method_12().Bbd = bool.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
					return true;
				}
				break;
			case 24:
				if (string_0 == Class333.aKB())
				{
					if (int_0 == -1)
					{
						settingOrSpecialObject_0.method_12().BBZ = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
					}
					return true;
				}
				break;
			}
		}
		if (string_0.StartsWith(Class333.aKF()))
		{
			ushort ushort_ = ushort.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
			settingOrSpecialObject_0.method_12().method_15(ushort_, int_0);
			return true;
		}
		if (string_0.StartsWith(Class333.aKf()))
		{
			uint uint_ = uint.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
			string attribute2 = xmlReader_0.GetAttribute(Class333.aKe());
			string attribute3 = xmlReader_0.GetAttribute(Class333.aKG());
			bool bool_;
			ushort ushort_2 = (ushort)((bool_ = attribute3 != null) ? ushort.Parse(attribute3) : 0);
			settingOrSpecialObject_0.method_12().method_6(uint_, attribute2, bool_, ushort_2, int_0);
			if (!aXO.awE.Contains(settingOrSpecialObject_0))
			{
				aXO.awE.Add(settingOrSpecialObject_0);
			}
			return true;
		}
		if (string_0.StartsWith(Class333.aKB()))
		{
			if (int_0 == -1)
			{
				int item = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
				settingOrSpecialObject_0.method_12().method_2().Add(item);
			}
			return true;
		}
		return false;
	}

	private bool method_18(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0, string string_1)
	{
		if (string_0 == Class333.aKg())
		{
			if (settingOrSpecialObject_0 is FilterOption)
			{
				(settingOrSpecialObject_0 as FilterOption).method_72(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
			}
			return true;
		}
		if (string_0.StartsWith(Class333.aKH()))
		{
			uint num = 0u;
			Enum104 @enum = Enum104.BAB;
			Enum105 enum105_ = Enum105.BAU;
			byte byte_ = byte.MaxValue;
			ushort ushort_ = 0;
			string attribute = xmlReader_0.GetAttribute(Class333.aKh());
			if (attribute != null)
			{
				@enum = (Enum104)byte.Parse(attribute);
			}
			string attribute2 = xmlReader_0.GetAttribute(Class333.aKI());
			if (attribute2 != null)
			{
				enum105_ = (Enum105)byte.Parse(attribute2);
			}
			if (@enum == Enum104.BAM)
			{
				string attribute3 = xmlReader_0.GetAttribute(Class333.aKi());
				if (attribute3 != null)
				{
					ushort_ = ushort.Parse(attribute3);
				}
				num = PortFunction.smethod_17(@enum, enum105_, ushort_);
			}
			else
			{
				string attribute4 = xmlReader_0.GetAttribute(Class333.aKJ());
				if (attribute4 != null)
				{
					byte_ = byte.Parse(attribute4);
				}
				num = PortFunction.smethod_16(@enum, enum105_, byte_);
			}
			bool bool_ = true;
			string attribute5 = xmlReader_0.GetAttribute(Class333.ahL());
			if (attribute5 != null)
			{
				bool_ = bool.Parse(attribute5);
			}
			if (settingOrSpecialObject_0 is FilterOption)
			{
				(settingOrSpecialObject_0 as FilterOption).method_77(num, bool_, int_0);
			}
			return true;
		}
		if (string_0.StartsWith(Class333.aKj()))
		{
			if (int_0 == -1)
			{
				method_34(xmlReader_0, settingOrSpecialObject_0 as FilterOption, string_0);
			}
			else if (!xmlReader_0.IsEmptyElement)
			{
				xmlReader_0.Read();
				while (xmlReader_0.NodeType != XmlNodeType.EndElement || (xmlReader_0.Name != Class333.smethod_1308() && xmlReader_0.Name != Class333.ahs()))
				{
					xmlReader_0.Read();
				}
			}
			return true;
		}
		return false;
	}

	private bool method_19(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0, string string_1)
	{
		string string_2 = string.Empty;
		if (string_0 != null)
		{
			switch (string_0.Length)
			{
			case 7:
				if (string_0 == Class333.aKo() && settingOrSpecialObject_0 is Class256)
				{
					method_31(xmlReader_0, ref string_2);
					string[] array = string_2.Split(',');
					foreach (string item in array)
					{
						(settingOrSpecialObject_0 as Class256).method_77().Add(item);
					}
					return true;
				}
				break;
			case 9:
				switch (string_0[0])
				{
				case 'D':
					if (string_0 == Class333.aKk())
					{
						if (settingOrSpecialObject_0 is Class256)
						{
							(settingOrSpecialObject_0 as Class256).method_74().Add(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return true;
					}
					break;
				case 'C':
					if (string_0 == Class333.aKK())
					{
						settingOrSpecialObject_0.method_9(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						return true;
					}
					break;
				}
				break;
			case 10:
				if (string_0 == Class333.aKN())
				{
					if (settingOrSpecialObject_0 is Class256)
					{
						method_31(xmlReader_0, ref string_2);
						(settingOrSpecialObject_0 as Class256).method_82(string_2);
					}
					return true;
				}
				break;
			case 13:
				switch (string_0[0])
				{
				case 'H':
					if (string_0 == Class333.aKl() && settingOrSpecialObject_0 is Class256)
					{
						method_31(xmlReader_0, ref string_2);
						string[] array = string_2.Split(',');
						foreach (string item3 in array)
						{
							(settingOrSpecialObject_0 as Class256).method_79().Add(item3);
						}
						return true;
					}
					break;
				case 'C':
					if (string_0 == Class333.aKL())
					{
						if (settingOrSpecialObject_0 is Class256)
						{
							(settingOrSpecialObject_0 as Class256).method_72(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return true;
					}
					break;
				}
				break;
			case 15:
				if (string_0 == Class333.aKP() && settingOrSpecialObject_0 is Class256)
				{
					method_31(xmlReader_0, ref string_2);
					string[] array = string_2.Split(',');
					foreach (string item2 in array)
					{
						(settingOrSpecialObject_0 as Class256).method_78().Add(item2);
					}
					return true;
				}
				break;
			case 16:
				if (string_0 == Class333.aKp() && settingOrSpecialObject_0 is Class256)
				{
					string attribute = xmlReader_0.GetAttribute(Class333.aKQ());
					method_31(xmlReader_0, ref string_2);
					string[] value = string_2.Split(',');
					(settingOrSpecialObject_0 as Class256).method_80().Add(attribute, value);
					return true;
				}
				break;
			case 17:
				switch (string_0[0])
				{
				case 'P':
					if (string_0 == Class333.aKO() && settingOrSpecialObject_0 is Class256)
					{
						int key = int.Parse(xmlReader_0.GetAttribute(Class333.aKq()));
						method_31(xmlReader_0, ref string_2);
						string[] value2 = string_2.Split(',');
						(settingOrSpecialObject_0 as Class256).method_87().Add(key, value2);
						return true;
					}
					break;
				case 'D':
					if (string_0 == Class333.aKn())
					{
						if (settingOrSpecialObject_0 is Class256)
						{
							method_31(xmlReader_0, ref string_2);
							(settingOrSpecialObject_0 as Class256).method_86(string_2);
						}
						return true;
					}
					break;
				}
				break;
			case 19:
				if (string_0 == Class333.aKM())
				{
					if (settingOrSpecialObject_0 is Class256)
					{
						(settingOrSpecialObject_0 as Class256).method_84(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					}
					return true;
				}
				break;
			case 20:
				if (string_0 == Class333.aKm())
				{
					if (settingOrSpecialObject_0 is Class256)
					{
						(settingOrSpecialObject_0 as Class256).method_73().Add(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					}
					return true;
				}
				break;
			}
		}
		if (string_0.StartsWith(Class333.aKR()))
		{
			settingOrSpecialObject_0.method_32(xmlReader_0.GetAttribute(Class333.aKQ()), xmlReader_0.GetAttribute(Class333.ahL()), int_0, string_1);
			return true;
		}
		return false;
	}

	private bool method_20(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0, string string_1)
	{
		string string_2 = string.Empty;
		if (string_0 != null)
		{
			switch (string_0.Length)
			{
			case 8:
				switch (string_0[4])
				{
				case 'E':
					if (string_0 == Class333.aKS())
					{
						method_31(xmlReader_0, ref string_2);
						if (settingOrSpecialObject_0 is Class254)
						{
							(settingOrSpecialObject_0 as Class254).method_74(string_2);
						}
						return true;
					}
					break;
				case 'C':
					if (string_0 == Class333.aKr())
					{
						method_31(xmlReader_0, ref string_2);
						if (settingOrSpecialObject_0 is Class254)
						{
							(settingOrSpecialObject_0 as Class254).method_72(string_2);
						}
						return true;
					}
					break;
				}
				break;
			case 11:
				if (string_0 == Class333.aKs())
				{
					if (settingOrSpecialObject_0 is Class254)
					{
						(settingOrSpecialObject_0 as Class254).method_78(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					}
					return true;
				}
				break;
			case 12:
				if (string_0 == Class333.aKU())
				{
					if (settingOrSpecialObject_0 is Class254)
					{
						(settingOrSpecialObject_0 as Class254).method_84(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					}
					return true;
				}
				break;
			case 14:
				if (string_0 == Class333.aKu())
				{
					if (settingOrSpecialObject_0 is Class254)
					{
						(settingOrSpecialObject_0 as Class254).method_86(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					}
					return true;
				}
				break;
			case 15:
				if (string_0 == Class333.aKT())
				{
					if (settingOrSpecialObject_0 is Class254)
					{
						(settingOrSpecialObject_0 as Class254).method_80(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					}
					return true;
				}
				break;
			case 16:
				if (string_0 == Class333.aKV())
				{
					method_31(xmlReader_0, ref string_2);
					if (settingOrSpecialObject_0 is Class254)
					{
						(settingOrSpecialObject_0 as Class254).method_76(string_2);
					}
					return true;
				}
				break;
			case 19:
				if (string_0 == Class333.aKt())
				{
					if (settingOrSpecialObject_0 is Class254)
					{
						(settingOrSpecialObject_0 as Class254).method_82(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					}
					return true;
				}
				break;
			case 3:
				if (string_0 == Class333.aKv())
				{
					settingOrSpecialObject_0.method_54(xmlReader_0.GetAttribute(Class333.ahL()));
					return true;
				}
				break;
			}
		}
		if (string_0.StartsWith(Class333.aKW()))
		{
			method_31(xmlReader_0, ref string_2);
			settingOrSpecialObject_0.method_51(string_2);
			return true;
		}
		return false;
	}

	private bool method_21(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0, string string_1)
	{
		string string_2 = string.Empty;
		if (settingOrSpecialObject_0 is SpecialObject specialObject)
		{
			if (string_0 != null)
			{
				switch (string_0.Length)
				{
				case 5:
					switch (string_0[0])
					{
					case 'P':
						if (string_0 == Class333.akb())
						{
							method_31(xmlReader_0, ref string_2);
							if (int_0 == -1)
							{
								specialObject.method_65().Bbs = string_2;
							}
							return true;
						}
						break;
					case 'G':
						if (string_0 == Class333.akC())
						{
							if (int_0 == -1)
							{
								specialObject.method_65().BbV = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
							}
							return true;
						}
						break;
					}
					break;
				case 7:
					if (string_0 == Class333.aKZ())
					{
						method_31(xmlReader_0, ref string_2);
						if (int_0 == -1)
						{
							specialObject.method_65().BbR = string_2;
						}
						return true;
					}
					break;
				case 8:
					switch (string_0[0])
					{
					case 'S':
						if (string_0 == Class333.akD())
						{
							if (int_0 == -1)
							{
								specialObject.method_65().Bbt = bool.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
							}
							return true;
						}
						break;
					case 'P':
						if (string_0 == Class333.akc())
						{
							if (int_0 == -1)
							{
								specialObject.method_65().BbT = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
							}
							return true;
						}
						break;
					}
					break;
				case 9:
					switch (string_0[0])
					{
					case 'C':
						if (string_0 == Class333.aka())
						{
							method_31(xmlReader_0, ref string_2);
							if (int_0 == -1)
							{
								specialObject.method_65().BbS = string_2;
							}
							return true;
						}
						break;
					case 'B':
						if (string_0 == Class333.akB())
						{
							if (int_0 == -1)
							{
								specialObject.method_65().BbU = xmlReader_0.GetAttribute(Class333.ahL());
							}
							return true;
						}
						break;
					}
					break;
				case 10:
					if (string_0 == Class333.akd())
					{
						if (int_0 == -1)
						{
							specialObject.method_65().Bbu = xmlReader_0.GetAttribute(Class333.ahL());
						}
						return true;
					}
					break;
				case 12:
					switch (string_0[0])
					{
					case 'P':
						if (string_0 == Class333.aKz())
						{
							method_31(xmlReader_0, ref string_2);
							if (int_0 == -1)
							{
								specialObject.method_65().Bbr = string_2;
							}
							return true;
						}
						break;
					case 'F':
						if (string_0 == Class333.akA())
						{
							return true;
						}
						break;
					}
					break;
				case 13:
					switch (string_0[0])
					{
					case 'P':
						if (string_0 == Class333.aKy())
						{
							if (int_0 == -1)
							{
								string[] array3 = xmlReader_0.GetAttribute(Class333.akh()).Split(',');
								specialObject.method_65().BbX = new Size(int.Parse(array3[0]), int.Parse(array3[1]));
							}
							return true;
						}
						break;
					case 'C':
						if (string_0 == Class333.aKY())
						{
							method_31(xmlReader_0, ref string_2);
							if (int_0 == -1)
							{
								specialObject.method_64().ayr = string_2;
								aXO.awe = true;
							}
							return true;
						}
						break;
					}
					break;
				case 15:
					switch (string_0[1])
					{
					case 'u':
						if (string_0 == Class333.aKx())
						{
							specialObject.method_65().Bbx = int.Parse(xmlReader_0.GetAttribute(Class333.akf()));
							specialObject.method_65().BbY = int.Parse(xmlReader_0.GetAttribute(Class333.akG()));
							return true;
						}
						break;
					case 'o':
						if (string_0 == Class333.aKX())
						{
							if (int_0 == -1)
							{
								specialObject.method_64().ayR = (Enum104)byte.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
								aXO.awe = true;
							}
							return true;
						}
						break;
					}
					break;
				case 17:
					switch (string_0[0])
					{
					case 'P':
						if (!(string_0 == Class333.ake()))
						{
							break;
						}
						if (int_0 == -1)
						{
							string attribute = xmlReader_0.GetAttribute(Class333.akg());
							if (attribute != null)
							{
								string[] array = attribute.Split(',');
								specialObject.method_65().BbW = new Point(int.Parse(array[0]), int.Parse(array[1]));
							}
							else
							{
								string attribute2 = xmlReader_0.GetAttribute(Class333.akH());
								if (attribute2 != null)
								{
									string[] array2 = attribute2.Split(',');
									specialObject.method_65().Bbw = new Point(int.Parse(array2[0]), int.Parse(array2[1]));
								}
							}
						}
						return true;
					case 'D':
						if (string_0 == Class333.akE())
						{
							if (int_0 == -1)
							{
								specialObject.method_65().Bbv = bool.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
							}
							return true;
						}
						break;
					}
					break;
				case 21:
					if (string_0 == Class333.aKw())
					{
						Enum104 key = (Enum104)byte.Parse(xmlReader_0.GetAttribute(Class333.akF()));
						xmlReader_0.Read();
						if (int_0 == -1)
						{
							aXO.awC.Add(key, xmlReader_0.Value);
						}
						xmlReader_0.Skip();
						return true;
					}
					break;
				}
			}
			if (string_0.StartsWith(Class333.akI()))
			{
				specialObject.method_65().method_2(uint.Parse(xmlReader_0.GetAttribute(Class333.ahL())), int_0);
				return true;
			}
			if (string_0.StartsWith(Class333.aki()))
			{
				method_31(xmlReader_0, ref string_2);
				specialObject.method_65().method_5(string_2, int_0);
				return true;
			}
		}
		return false;
	}

	private bool method_22(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0, string string_1)
	{
		if (!(string_0 == Class333.akJ()))
		{
			if (!(string_0 == Class333.akj()))
			{
				if (!(string_0 == Class333.akK()))
				{
					if (!(string_0 == Class333.akk()))
					{
						if (!(string_0 == Class333.akL()))
						{
							return false;
						}
						if (settingOrSpecialObject_0 is Setting setting)
						{
							setting.method_95(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
							if (setting.method_94() != 0)
							{
								aXO.aWU.Add(setting);
							}
						}
						return true;
					}
					settingOrSpecialObject_0.method_13().DataIdOfChannelRateSetting = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
					return true;
				}
				settingOrSpecialObject_0.method_13().DataIdOfChannelListSetting = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
				return true;
			}
			settingOrSpecialObject_0.method_13().RateLimit = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
			return true;
		}
		settingOrSpecialObject_0.method_13().LimitedSpaceEquation = xmlReader_0.GetAttribute(Class333.ahU());
		return true;
	}

	private bool method_23(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0, string string_1)
	{
		string string_2 = string.Empty;
		InitialTaskObject initialTaskObject = null;
		if (string_0.EndsWith(Class333.akl()))
		{
			string text = string_0.Substring(0, string_0.Length - 12);
			for (int i = 0; i < settingOrSpecialObject_0.method_24().Count; i++)
			{
				if (settingOrSpecialObject_0.method_24()[i].method_0() == text)
				{
					initialTaskObject = settingOrSpecialObject_0.method_24()[i];
					break;
				}
			}
			if (initialTaskObject == null)
			{
				initialTaskObject = new InitialTaskObject(aXO);
				initialTaskObject.method_1(text);
				settingOrSpecialObject_0.method_24().Add(initialTaskObject);
			}
			initialTaskObject.method_7((Enum100)int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
			string attribute = xmlReader_0.GetAttribute(Class333.akM());
			if (attribute != null)
			{
				initialTaskObject.method_8(int.Parse(attribute));
			}
			initialTaskObject.method_9((Enum101)int.Parse(xmlReader_0.GetAttribute(Class333.akm())));
			string attribute2 = xmlReader_0.GetAttribute(Class333.akN());
			if (attribute2 != null)
			{
				initialTaskObject.method_11(bool.Parse(attribute2));
			}
			string attribute3 = xmlReader_0.GetAttribute(Class333.akn());
			if (attribute3 != null)
			{
				initialTaskObject.method_13(bool.Parse(attribute3));
			}
			return true;
		}
		if (string_0.EndsWith(Class333.akO()))
		{
			string text2 = string_0.Substring(0, string_0.Length - 15);
			for (int j = 0; j < settingOrSpecialObject_0.method_24().Count; j++)
			{
				if (settingOrSpecialObject_0.method_24()[j].method_0() == text2)
				{
					initialTaskObject = settingOrSpecialObject_0.method_24()[j];
					break;
				}
			}
			if (initialTaskObject == null)
			{
				initialTaskObject = new InitialTaskObject(aXO);
				initialTaskObject.method_1(text2);
				settingOrSpecialObject_0.method_24().Add(initialTaskObject);
			}
			method_31(xmlReader_0, ref string_2);
			initialTaskObject.method_2(string_2);
			return true;
		}
		if (string_0.EndsWith(Class333.ako()))
		{
			string text3 = string_0.Substring(0, string_0.Length - 16);
			for (int k = 0; k < settingOrSpecialObject_0.method_24().Count; k++)
			{
				if (settingOrSpecialObject_0.method_24()[k].method_0() == text3)
				{
					initialTaskObject = settingOrSpecialObject_0.method_24()[k];
					break;
				}
			}
			if (initialTaskObject == null)
			{
				initialTaskObject = new InitialTaskObject(aXO);
				initialTaskObject.method_1(text3);
				settingOrSpecialObject_0.method_24().Add(initialTaskObject);
			}
			initialTaskObject.method_4(xmlReader_0.GetAttribute(Class333.ahU()));
			return true;
		}
		if (string_0.EndsWith(Class333.akP()))
		{
			string text4 = string_0.Substring(0, string_0.Length - 19);
			for (int l = 0; l < settingOrSpecialObject_0.method_24().Count; l++)
			{
				if (settingOrSpecialObject_0.method_24()[l].method_0() == text4)
				{
					initialTaskObject = settingOrSpecialObject_0.method_24()[l];
					break;
				}
			}
			if (initialTaskObject == null)
			{
				initialTaskObject = new InitialTaskObject(aXO);
				initialTaskObject.method_1(text4);
				settingOrSpecialObject_0.method_24().Add(initialTaskObject);
			}
			method_31(xmlReader_0, ref string_2);
			initialTaskObject.method_3(string_2);
			return true;
		}
		if (string_0.Contains(Class333.akp()))
		{
			string text5 = string_0.Substring(0, string_0.IndexOf(Class333.akp()));
			for (int m = 0; m < settingOrSpecialObject_0.method_24().Count; m++)
			{
				if (settingOrSpecialObject_0.method_24()[m].method_0() == text5)
				{
					initialTaskObject = settingOrSpecialObject_0.method_24()[m];
					break;
				}
			}
			if (initialTaskObject == null)
			{
				initialTaskObject = new InitialTaskObject(aXO);
				initialTaskObject.method_1(text5);
				settingOrSpecialObject_0.method_24().Add(initialTaskObject);
			}
			int num = string_0.IndexOf(Class333.akp()) + 17;
			string string_3 = string_0.Substring(num, string_0.Length - num);
			initialTaskObject.method_5(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())), string_3);
			return true;
		}
		return false;
	}

	private bool method_24(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0, string string_1)
	{
		string string_2 = string.Empty;
		if (!(string_0 == Class333.akQ()))
		{
			if (!(string_0 == Class333.akq()))
			{
				if (!(string_0 == Class333.akR()))
				{
					if (string_0.StartsWith(Class333.akr()))
					{
						settingOrSpecialObject_0.method_26().method_3(int.Parse(xmlReader_0.GetAttribute(Class333.akS())), xmlReader_0.GetAttribute(Class333.ahU()));
						return true;
					}
					return false;
				}
				settingOrSpecialObject_0.method_26().method_2(xmlReader_0.GetAttribute(Class333.ahU()));
				return true;
			}
			method_31(xmlReader_0, ref string_2);
			settingOrSpecialObject_0.method_26().method_1(string_2);
			return true;
		}
		method_31(xmlReader_0, ref string_2);
		settingOrSpecialObject_0.method_26().method_0(string_2);
		return true;
	}

	private bool method_25(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0, string string_1)
	{
		if (string_0 == Class333.aks())
		{
			if (settingOrSpecialObject_0 is KnockDetection)
			{
				(settingOrSpecialObject_0 as KnockDetection).DataIdOfCentreFrequencySetting = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
			}
			return true;
		}
		if (string_0 == Class333.akT())
		{
			if (settingOrSpecialObject_0 is KnockDetection)
			{
				(settingOrSpecialObject_0 as KnockDetection).DataIdOfBandwidthSetting = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
			}
			return true;
		}
		if (string_0.StartsWith(Class333.akt()))
		{
			if (settingOrSpecialObject_0 is KnockDetection)
			{
				(settingOrSpecialObject_0 as KnockDetection).DataIdsOfFFTChannels.Add(int.Parse(xmlReader_0.GetAttribute(Class333.aIP())));
			}
			return true;
		}
		if (string_0.StartsWith(Class333.akU()))
		{
			if (settingOrSpecialObject_0 is KnockDetection)
			{
				(settingOrSpecialObject_0 as KnockDetection).DataIdsOfAngleBucketChannels.Add(int.Parse(xmlReader_0.GetAttribute(Class333.aIP())));
			}
			return true;
		}
		if (string_0 == Class333.aku())
		{
			if (settingOrSpecialObject_0 is KnockDetection)
			{
				(settingOrSpecialObject_0 as KnockDetection).DataIdOfWindowStartAngleSetting = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
			}
			return true;
		}
		if (string_0 == Class333.akV())
		{
			if (settingOrSpecialObject_0 is KnockDetection)
			{
				(settingOrSpecialObject_0 as KnockDetection).DataIdOfWindowDurationSetting = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
			}
			return true;
		}
		return false;
	}

	private bool method_26(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0, string string_1)
	{
		string string_2 = string.Empty;
		if (settingOrSpecialObject_0 is SpecialObject specialObject)
		{
			if (string_0 != null)
			{
				switch (string_0.Length)
				{
				case 16:
					if (string_0 == Class333.akv())
					{
						method_31(xmlReader_0, ref string_2);
						specialObject.method_68().ConfirmationText = string_2;
						return true;
					}
					break;
				case 18:
					if (string_0 == Class333.aky())
					{
						specialObject.method_68().InjectorStageIndex = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
						return true;
					}
					break;
				case 19:
					if (string_0 == Class333.akx())
					{
						method_31(xmlReader_0, ref string_2);
						specialObject.method_68().ActiveText = string_2;
						return true;
					}
					break;
				case 23:
					if (string_0 == Class333.akX())
					{
						specialObject.method_68().HoldToExecuteOutputTest = bool.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
						return true;
					}
					break;
				case 24:
					if (string_0 == Class333.akY())
					{
						specialObject.method_68().ProcessId = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
						return true;
					}
					break;
				case 25:
					switch (string_0[0])
					{
					case 'I':
						if (string_0 == Class333.akw())
						{
							specialObject.method_68().InjectorOutputWithinStage = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
							return true;
						}
						break;
					case 'A':
						if (string_0 == Class333.akW())
						{
							method_31(xmlReader_0, ref string_2);
							specialObject.method_68().IdleText = string_2;
							return true;
						}
						break;
					}
					break;
				}
			}
			if (string_0.StartsWith(Class333.akZ()))
			{
				specialObject.method_68().AddPreApplySettingDataId(int.Parse(xmlReader_0.GetAttribute(Class333.aIP())));
				return true;
			}
		}
		return false;
	}

	private bool method_27(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0, string string_1)
	{
		string string_2 = string.Empty;
		SpecialObject specialObject = settingOrSpecialObject_0 as SpecialObject;
		if (!(string_0 == Class333.akz()))
		{
			if (!(string_0 == Class333.aLA()))
			{
				if (!(string_0 == Class333.aLa()))
				{
					if (!(string_0 == Class333.aLB()))
					{
						if (!(string_0 == Class333.aLb()))
						{
							return false;
						}
						if (specialObject != null)
						{
							int num = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
							specialObject.method_69().ThresholdSettingId = num;
							aXO.awJ.Add(num);
						}
						return true;
					}
					if (specialObject != null)
					{
						int operatorSettingId = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
						specialObject.method_69().OperatorSettingId = operatorSettingId;
					}
					return true;
				}
				method_31(xmlReader_0, ref string_2);
				if (specialObject != null)
				{
					specialObject.method_69().JoinText = string_2;
				}
				return true;
			}
			int num2 = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
			if (specialObject != null)
			{
				specialObject.method_69().ChannelSettingId = num2;
				aXO.awi.Add(num2);
			}
			else if (settingOrSpecialObject_0 is Setting setting)
			{
				setting.method_99(num2);
			}
			return true;
		}
		if (specialObject != null)
		{
			int enablerSettingId = int.Parse(xmlReader_0.GetAttribute(Class333.aIP()));
			specialObject.method_69().EnablerSettingId = enablerSettingId;
		}
		return true;
	}

	private bool method_28(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0, string string_1)
	{
		if (settingOrSpecialObject_0 is SpecialObject)
		{
			SpecialObject specialObject = settingOrSpecialObject_0 as SpecialObject;
			if (string_0 != null)
			{
				switch (string_0.Length)
				{
				case 7:
					if (string_0 == Class333.smethod_2562())
					{
						specialObject.method_67().ShowSummary = bool.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
						return true;
					}
					break;
				case 10:
					if (string_0 == Class333.aLd())
					{
						string attribute = xmlReader_0.GetAttribute(Class333.aIP());
						if (attribute != null)
						{
							specialObject.method_67().DataIdOfListCountSetting = int.Parse(attribute);
						}
						string attribute2 = xmlReader_0.GetAttribute(Class333.ahL());
						if (attribute2 != null)
						{
							specialObject.method_67().FixedCountValue = int.Parse(attribute2);
						}
						return true;
					}
					break;
				case 11:
					switch (string_0[0])
					{
					case 'R':
						if (string_0 == Class333.aLc())
						{
							specialObject.method_67().Reorderable = bool.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
							specialObject.method_67().SetObjectsOrderColumnTextWithDefault(xmlReader_0.GetAttribute(Class333.aIL()), Class333.aLG());
							return true;
						}
						break;
					case 'I':
						if (string_0 == Class333.aLC())
						{
							specialObject.method_67().SetListLabelsFormatString(xmlReader_0.GetAttribute(Class333.ahL()));
							return true;
						}
						break;
					}
					break;
				case 12:
					if (string_0 == Class333.aLD())
					{
						specialObject.method_67().ShowOrdinalValues = bool.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
						return true;
					}
					break;
				case 16:
					if (string_0 == Class333.aLF())
					{
						return true;
					}
					break;
				case 17:
					if (string_0 == Class333.aLE())
					{
						specialObject.method_67().SetObjectsListLabelsFormatString(xmlReader_0.GetAttribute(Class333.ahL()));
						return true;
					}
					break;
				case 18:
					if (string_0 == Class333.aLe())
					{
						specialObject.method_67().ShowOrdinalValues = bool.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
						return true;
					}
					break;
				case 20:
					if (string_0 == Class333.aLf())
					{
						specialObject.method_67().ExtraSummaryObjectId = int.Parse(xmlReader_0.GetAttribute(Class333.ajV()));
						return true;
					}
					break;
				}
			}
			if (string_0.StartsWith(Class333.aLg()))
			{
				specialObject.method_67().DataIdsOfListSettings.Add(int.Parse(xmlReader_0.GetAttribute(Class333.aIP())));
				return true;
			}
		}
		return false;
	}

	private bool method_29(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0, string string_1)
	{
		string string_2 = string.Empty;
		if (string_0 != null)
		{
			switch (string_0.Length)
			{
			case 4:
				if (string_0 == Class333.aLj())
				{
					if (settingOrSpecialObject_0 is StateMachineStage)
					{
						(settingOrSpecialObject_0 as StateMachineStage).method_74(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					}
					return true;
				}
				break;
			case 5:
				switch (string_0[0])
				{
				case 'V':
					if (string_0 == Class333.smethod_280())
					{
						if (settingOrSpecialObject_0 is StateMachineError)
						{
							(settingOrSpecialObject_0 as StateMachineError).method_72(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return true;
					}
					break;
				case 'S':
					if (string_0 == Class333.aLL())
					{
						if (settingOrSpecialObject_0 is StateMachineStage)
						{
							(settingOrSpecialObject_0 as StateMachineStage).method_84(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return true;
					}
					break;
				case 'I':
					if (string_0 == Class333.ahJ())
					{
						xmlReader_0.Read();
						if (settingOrSpecialObject_0 is StateMachineStage)
						{
							(settingOrSpecialObject_0 as StateMachineStage).method_72(xmlReader_0.Value);
						}
						xmlReader_0.Skip();
						return true;
					}
					break;
				}
				break;
			case 6:
				switch (string_0[0])
				{
				case 'S':
				{
					if (!(string_0 == Class333.smethod_944()))
					{
						break;
					}
					string attribute = xmlReader_0.GetAttribute(Class333.ahL());
					if (!attribute.Contains(Class333.aJz()))
					{
						if (settingOrSpecialObject_0 is StateMachineStage)
						{
							(settingOrSpecialObject_0 as StateMachineStage).method_75(int.Parse(attribute));
						}
					}
					else
					{
						attribute = attribute.Substring(1, attribute.Length - 2);
						string text = string.Empty;
						for (int i = 0; i < attribute.Length; i++)
						{
							if (attribute[i] != ',')
							{
								text += attribute[i];
								continue;
							}
							if (settingOrSpecialObject_0 is StateMachineStage)
							{
								(settingOrSpecialObject_0 as StateMachineStage).method_75(int.Parse(text));
							}
							text = string.Empty;
						}
						if (settingOrSpecialObject_0 is StateMachineStage)
						{
							(settingOrSpecialObject_0 as StateMachineStage).method_75(int.Parse(text));
						}
					}
					return true;
				}
				case 'C':
					if (string_0 == Class333.smethod_2063())
					{
						method_31(xmlReader_0, ref string_2);
						if (settingOrSpecialObject_0 is StateMachineError)
						{
							(settingOrSpecialObject_0 as StateMachineError).method_76(string_2);
						}
						return true;
					}
					break;
				}
				break;
			case 7:
				switch (string_0[0])
				{
				case 'T':
					if (string_0 == Class333.aLK())
					{
						if (settingOrSpecialObject_0 is StateMachineStage)
						{
							(settingOrSpecialObject_0 as StateMachineStage).method_82(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return true;
					}
					break;
				case 'M':
					if (string_0 == Class333.aLk())
					{
						method_31(xmlReader_0, ref string_2);
						if (settingOrSpecialObject_0 is StateMachineError)
						{
							(settingOrSpecialObject_0 as StateMachineError).method_74(string_2);
						}
						return true;
					}
					break;
				}
				break;
			case 8:
				switch (string_0[0])
				{
				case 'N':
					if (string_0 == Class333.aLo())
					{
						method_31(xmlReader_0, ref string_2);
						if (settingOrSpecialObject_0 is StateMachineStage)
						{
							(settingOrSpecialObject_0 as StateMachineStage).method_94(string_2);
						}
						return true;
					}
					break;
				case 'H':
					if (string_0 == Class333.aLO())
					{
						method_31(xmlReader_0, ref string_2);
						if (settingOrSpecialObject_0 is StateMachineStage)
						{
							(settingOrSpecialObject_0 as StateMachineStage).method_92(string_2);
						}
						return true;
					}
					break;
				}
				break;
			case 11:
				switch (string_0[0])
				{
				case 'H':
					if (string_0 == Class333.aLN())
					{
						if (settingOrSpecialObject_0 is StateMachineStage)
						{
							(settingOrSpecialObject_0 as StateMachineStage).method_88(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return true;
					}
					break;
				case 'C':
					if (string_0 == Class333.aLn())
					{
						method_31(xmlReader_0, ref string_2);
						if (settingOrSpecialObject_0 is StateMachineStage)
						{
							(settingOrSpecialObject_0 as StateMachineStage).method_90(string_2);
						}
						return true;
					}
					break;
				}
				break;
			case 14:
				switch (string_0[0])
				{
				case 'H':
					if (string_0 == Class333.aLJ())
					{
						if (settingOrSpecialObject_0 is StateMachineStage)
						{
							(settingOrSpecialObject_0 as StateMachineStage).method_86(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return true;
					}
					break;
				case 'E':
					if (string_0 == Class333.aLi())
					{
						if (settingOrSpecialObject_0 is StateMachine)
						{
							(settingOrSpecialObject_0 as StateMachine).OutcomeErrorChannelDataId = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
						}
						return true;
					}
					break;
				}
				break;
			case 15:
				if (string_0 == Class333.aLP())
				{
					method_31(xmlReader_0, ref string_2);
					if (settingOrSpecialObject_0 is StateMachineStage)
					{
						(settingOrSpecialObject_0 as StateMachineStage).method_96(string_2);
					}
					return true;
				}
				break;
			case 16:
				switch (string_0[1])
				{
				case 'u':
					if (string_0 == Class333.aLM())
					{
						if (settingOrSpecialObject_0 is StateMachineStage)
						{
							(settingOrSpecialObject_0 as StateMachineStage).method_78(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						}
						return true;
					}
					break;
				case 's':
					if (string_0 == Class333.aLm())
					{
						return true;
					}
					break;
				}
				break;
			case 17:
				if (string_0 == Class333.aLl())
				{
					if (settingOrSpecialObject_0 is StateMachineStage)
					{
						(settingOrSpecialObject_0 as StateMachineStage).method_80(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					}
					return true;
				}
				break;
			case 21:
				switch (string_0[0])
				{
				case 'S':
					if (string_0 == Class333.aLH())
					{
						if (settingOrSpecialObject_0 is StateMachine)
						{
							(settingOrSpecialObject_0 as StateMachine).ProcessId = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
						}
						return true;
					}
					break;
				case 'R':
					if (string_0 == Class333.aLI())
					{
						if (settingOrSpecialObject_0 is StateMachine)
						{
							(settingOrSpecialObject_0 as StateMachine).RequestStageChannelDataId = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
						}
						return true;
					}
					break;
				case 'C':
					if (string_0 == Class333.aLh())
					{
						if (settingOrSpecialObject_0 is StateMachine)
						{
							(settingOrSpecialObject_0 as StateMachine).CurrentStageChannelDataId = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
						}
						return true;
					}
					break;
				}
				break;
			}
		}
		return false;
	}

	private bool method_30(XmlReader xmlReader_0, ref int int_0, ref bool bool_0, ref string string_0)
	{
		bool result = false;
		string_0 = string.Empty;
		string attribute = xmlReader_0.GetAttribute(Class333.ahL());
		if (attribute != null)
		{
			int_0 = int.Parse(attribute);
			bool_0 = false;
			result = true;
		}
		else
		{
			string text = xmlReader_0.GetAttribute(Class333.aIP());
			if (text != null)
			{
				int num = text.IndexOf(':');
				if (num != -1)
				{
					string_0 = text.Substring(num + 1, text.Length - (num + 1));
					text = text.Remove(num);
				}
				int_0 = int.Parse(text);
				bool_0 = true;
				result = true;
			}
		}
		return result;
	}

	private void method_31(XmlReader xmlReader_0, ref string string_0)
	{
		xmlReader_0.Read();
		if ((xmlReader_0.Name == Class333.smethod_1308() || xmlReader_0.Name == Class333.ahs()) && xmlReader_0.NodeType == XmlNodeType.EndElement)
		{
			string_0 = string.Empty;
			return;
		}
		string_0 = xmlReader_0.Value;
		xmlReader_0.Skip();
	}

	private void method_32(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0)
	{
		bool flag = true;
		string attribute = xmlReader_0.GetAttribute(Class333.aLp());
		if (attribute == null)
		{
			attribute = xmlReader_0.GetAttribute(Class333.aLQ());
		}
		if (attribute != null)
		{
			flag = bool.Parse(attribute);
		}
		StringBuilder stringBuilder_ = new StringBuilder(100);
		method_37(xmlReader_0, ref stringBuilder_);
		if (!flag)
		{
			stringBuilder_.Insert(0, Class333.aLq());
			stringBuilder_.Append(Class333.aLR());
		}
		settingOrSpecialObject_0.method_30(stringBuilder_.ToString(), int_0);
	}

	private void method_33(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0)
	{
		if (!(settingOrSpecialObject_0 is Setting setting))
		{
			return;
		}
		string attribute = xmlReader_0.GetAttribute(Class333.ahU());
		if (attribute == null)
		{
			return;
		}
		bool flag = true;
		string attribute2 = xmlReader_0.GetAttribute(Class333.aLp());
		if (attribute2 == null)
		{
			attribute2 = xmlReader_0.GetAttribute(Class333.aLQ());
		}
		if (attribute2 != null)
		{
			flag = bool.Parse(attribute2);
		}
		StringBuilder stringBuilder = new StringBuilder(50);
		int[] array = new int[3] { 1, 1, 1 };
		if (string_0 != Class333.aJX())
		{
			string_0 = string_0.Substring(1, string_0.Length - 2);
			int num = string_0.IndexOf(',');
			int num2 = string_0.IndexOf(',', num + 1);
			array[0] = int.Parse(string_0.Substring(0, num));
			array[1] = int.Parse(string_0.Substring(num + 1, num2 - (num + 1)));
			array[2] = int.Parse(string_0.Substring(num2 + 1));
		}
		for (int i = 0; i < array[2]; i++)
		{
			for (int j = 0; j < array[1]; j++)
			{
				for (int k = 0; k < array[0]; k++)
				{
					stringBuilder.Clear();
					for (int l = 0; l < attribute.Length; l++)
					{
						if (attribute[l] == 'd')
						{
							continue;
						}
						if (l > 0 && attribute[l - 1] == 'd')
						{
							if (attribute[l] == '0')
							{
								stringBuilder.Append(i);
							}
							else if (attribute[l] == '1')
							{
								stringBuilder.Append(j);
							}
							else if (attribute[l] == '2')
							{
								stringBuilder.Append(k);
							}
						}
						else
						{
							stringBuilder.Append(attribute[l]);
						}
					}
					if (!flag)
					{
						stringBuilder.Insert(0, Class333.aLq());
						stringBuilder.Append(Class333.aLR());
					}
					setting.method_118(stringBuilder.ToString(), i, j, k);
				}
			}
		}
	}

	private void method_34(XmlReader xmlReader_0, FilterOption filterOption_0, string string_0)
	{
		bool flag = true;
		string attribute = xmlReader_0.GetAttribute(Class333.aLp());
		if (attribute == null)
		{
			attribute = xmlReader_0.GetAttribute(Class333.aLQ());
		}
		if (attribute != null)
		{
			flag = bool.Parse(attribute);
		}
		StringBuilder stringBuilder_ = new StringBuilder(100);
		method_37(xmlReader_0, ref stringBuilder_);
		if (!flag)
		{
			stringBuilder_.Insert(0, Class333.aLq());
			stringBuilder_.Append(Class333.aLR());
		}
		filterOption_0.method_73(stringBuilder_.ToString());
	}

	private void method_35(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, int int_0)
	{
		bool flag = true;
		string attribute = xmlReader_0.GetAttribute(Class333.aLp());
		if (attribute == null)
		{
			attribute = xmlReader_0.GetAttribute(Class333.aLQ());
		}
		if (attribute != null)
		{
			flag = bool.Parse(attribute);
		}
		string attribute2 = xmlReader_0.GetAttribute(Class333.aIL());
		if (attribute2 == null)
		{
			attribute2 = xmlReader_0.GetAttribute(Class333.ajC());
		}
		int num = 0;
		string attribute3 = xmlReader_0.GetAttribute(Class333.aLr());
		if (attribute3 == null)
		{
			attribute3 = xmlReader_0.GetAttribute(Class333.aLS());
		}
		if (attribute3 != null)
		{
			num = int.Parse(attribute3);
		}
		bool bool_ = num != 1;
		string attribute4 = xmlReader_0.GetAttribute(Class333.aLs());
		if (attribute4 == null)
		{
			attribute4 = xmlReader_0.GetAttribute(Class333.aLT());
		}
		if (attribute4 != null)
		{
			bool_ = bool.Parse(attribute4);
		}
		StringBuilder stringBuilder_ = new StringBuilder(100);
		method_37(xmlReader_0, ref stringBuilder_);
		if (!flag)
		{
			stringBuilder_.Insert(0, Class333.aLq());
			stringBuilder_.Append(Class333.aLR());
		}
		if (settingOrSpecialObject_0 is Setting setting)
		{
			setting.method_120(stringBuilder_.ToString(), (IllegalitySeverityLevel)num, bool_, attribute2, int_0);
		}
	}

	private void method_36(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
		StringBuilder stringBuilder_ = new StringBuilder(100);
		stringBuilder_.Append(Class333.smethod_765());
		bool flag = false;
		string attribute2 = xmlReader_0.GetAttribute(Class333.aLt());
		if (attribute2 != null)
		{
			flag = bool.Parse(attribute2);
		}
		bool flag2 = false;
		bool flag3 = false;
		string attribute3 = xmlReader_0.GetAttribute(Class333.aLU());
		if (attribute3 != null)
		{
			flag2 = attribute3 == Class333.aLu();
			flag3 = attribute3 == Class333.aLV();
		}
		if (flag)
		{
			stringBuilder_.Append(Class333.aLq());
		}
		bool bool_ = false;
		bool flag4 = false;
		xmlReader_0.Read();
		while (true)
		{
			if ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.aIV()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
			{
				if (!(xmlReader_0.Name == Class333.smethod_1308()) && !(xmlReader_0.Name == Class333.ahs()))
				{
					flag4 = false;
					if (!(xmlReader_0.Name == Class333.smethod_2244()) && !(xmlReader_0.Name == Class333.aIu()))
					{
						if (xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
						{
							break;
						}
					}
					else
					{
						if (xmlReader_0.GetAttribute(Class333.ajR()) != null)
						{
							bool_ = true;
						}
						method_37(xmlReader_0, ref stringBuilder_);
						if (flag2)
						{
							stringBuilder_.Append(Class333.aLv());
							flag4 = true;
						}
						else if (flag3)
						{
							stringBuilder_.Append(Class333.aLW());
							flag4 = true;
						}
					}
				}
				else
				{
					method_14(xmlReader_0, settingOrSpecialObject_0, settingOrSpecialObject_0.method_34(), attribute);
				}
				xmlReader_0.Read();
				continue;
			}
			if (flag4)
			{
				stringBuilder_.Remove(stringBuilder_.Length - 4, 4);
			}
			if (flag)
			{
				stringBuilder_.Append(Class333.aLR());
			}
			stringBuilder_.Append(Class333.smethod_9());
			settingOrSpecialObject_0.vmethod_0(stringBuilder_.ToString(), bool_);
			return;
		}
		throw new Exception(string.Format(Class333.aLw(), xmlReader_0.Name));
	}

	private void method_37(XmlReader xmlReader_0, ref StringBuilder stringBuilder_0)
	{
		method_40(xmlReader_0, ref stringBuilder_0, null, null);
	}

	private void method_38(XmlReader xmlReader_0, ref StringBuilder stringBuilder_0, Class260 class260_0)
	{
		method_40(xmlReader_0, ref stringBuilder_0, class260_0, null);
	}

	private void method_39(XmlReader xmlReader_0, ref StringBuilder stringBuilder_0, Class259 class259_0)
	{
		method_40(xmlReader_0, ref stringBuilder_0, null, class259_0);
	}

	private void method_40(XmlReader xmlReader_0, ref StringBuilder stringBuilder_0, Class260 class260_0, Class259 class259_0)
	{
		stringBuilder_0.Append(Class333.smethod_765());
		string attribute = xmlReader_0.GetAttribute(Class333.ahU());
		if (attribute != null)
		{
			stringBuilder_0.Append(Class333.smethod_765());
			stringBuilder_0.Append(attribute);
			stringBuilder_0.Append(Class333.smethod_9());
		}
		else
		{
			string attribute2 = xmlReader_0.GetAttribute(Class333.aLX());
			if (attribute2 != null)
			{
				stringBuilder_0.Append(Class333.smethod_219() + attribute2 + Class333.smethod_9());
			}
			else
			{
				string attribute3 = xmlReader_0.GetAttribute(Class333.aLx());
				if (attribute3 != null)
				{
					stringBuilder_0.Append(Class333.smethod_228() + attribute3 + Class333.smethod_9());
				}
				else
				{
					string attribute4 = xmlReader_0.GetAttribute(Class333.aLY());
					string attribute5 = xmlReader_0.GetAttribute(Class333.aLy());
					if (attribute4 != null && attribute5 != null)
					{
						if (class260_0 != null)
						{
							class260_0.method_3(attribute4);
							string text = class260_0.method_0().method_7();
							stringBuilder_0.Append(Class333.smethod_233() + text + Class333.aLZ() + attribute5 + Class333.smethod_9());
						}
						else if (class259_0 != null)
						{
							class259_0.method_3(attribute4);
							string text2 = class259_0.method_0().method_7();
							int count = class259_0.method_0().method_16().Count;
							stringBuilder_0.Append(Class333.smethod_233() + text2 + Class333.aLz() + count + Class333.alA() + attribute5 + Class333.smethod_9());
						}
					}
				}
			}
		}
		string attribute6 = xmlReader_0.GetAttribute(Class333.ala());
		string attribute7 = xmlReader_0.GetAttribute(Class333.alB());
		string attribute8 = xmlReader_0.GetAttribute(Class333.alb());
		string attribute9 = xmlReader_0.GetAttribute(Class333.alC());
		string attribute10 = xmlReader_0.GetAttribute(Class333.alc());
		if (attribute6 != null && attribute7 != null && (attribute8 != null || attribute9 != null))
		{
			stringBuilder_0.Append(Class333.alD());
			stringBuilder_0.Append(attribute7);
			if (attribute10 != null)
			{
				stringBuilder_0.Append(Class333.ald() + attribute10);
			}
			stringBuilder_0.Append(Class333.smethod_960());
			if (attribute6 == Class333.smethod_220())
			{
				stringBuilder_0.Append(Class333.alE());
			}
			else if (attribute6 == Class333.smethod_221())
			{
				stringBuilder_0.Append(Class333.ale());
			}
			else if (attribute6 == Class333.aGi())
			{
				stringBuilder_0.Append(Class333.alF());
			}
			else if (attribute6 == Class333.alf())
			{
				stringBuilder_0.Append(Class333.alG());
			}
			else if (attribute6 == Class333.smethod_1310())
			{
				stringBuilder_0.Append(Class333.alg());
			}
			else if (attribute6 == Class333.alH())
			{
				stringBuilder_0.Append(Class333.alh());
			}
			else
			{
				stringBuilder_0.Append(Class333.alI());
			}
			if (attribute9 != null)
			{
				stringBuilder_0.Append(Class333.smethod_960());
				stringBuilder_0.Append(attribute9);
				stringBuilder_0.Append(Class333.smethod_960());
			}
			else
			{
				stringBuilder_0.Append(attribute8);
			}
			stringBuilder_0.Append(Class333.smethod_9());
		}
		bool flag = false;
		string attribute11 = xmlReader_0.GetAttribute(Class333.aLt());
		if (attribute11 != null)
		{
			flag = bool.Parse(attribute11);
		}
		bool flag2 = false;
		bool flag3 = false;
		string attribute12 = xmlReader_0.GetAttribute(Class333.aLU());
		if (attribute12 != null)
		{
			flag2 = attribute12 == Class333.aLu();
			flag3 = attribute12 == Class333.aLV();
		}
		if (flag)
		{
			stringBuilder_0.Append(Class333.aLq());
		}
		bool flag4 = false;
		if (!xmlReader_0.IsEmptyElement)
		{
			xmlReader_0.Read();
			while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && ((!(xmlReader_0.Name == Class333.smethod_2244()) && !(xmlReader_0.Name == Class333.aIu())) || xmlReader_0.NodeType != XmlNodeType.EndElement) && ((!(xmlReader_0.Name == Class333.smethod_1308()) && !(xmlReader_0.Name == Class333.ahs())) || xmlReader_0.NodeType != XmlNodeType.EndElement) && ((!(xmlReader_0.Name == Class333.ali()) && !(xmlReader_0.Name == Class333.alJ())) || xmlReader_0.NodeType != XmlNodeType.EndElement) && ((!(xmlReader_0.Name == Class333.alj()) && !(xmlReader_0.Name == Class333.alK())) || xmlReader_0.NodeType != XmlNodeType.EndElement))
			{
				flag4 = false;
				if (!(xmlReader_0.Name == Class333.smethod_2244()) && !(xmlReader_0.Name == Class333.aIu()))
				{
					if (xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
					{
						if (!(xmlReader_0.Name == Class333.smethod_1308()) && !(xmlReader_0.Name == Class333.ahs()))
						{
							throw new Exception(string.Format(Class333.alk(), xmlReader_0.Name));
						}
						xmlReader_0.Read();
						while (xmlReader_0.NodeType != XmlNodeType.EndElement || (xmlReader_0.Name != Class333.smethod_1308() && xmlReader_0.Name != Class333.ahs()))
						{
							xmlReader_0.Read();
						}
					}
				}
				else
				{
					method_40(xmlReader_0, ref stringBuilder_0, class260_0, class259_0);
					if (flag2)
					{
						stringBuilder_0.Append(Class333.aLv());
						flag4 = true;
					}
					else if (flag3)
					{
						stringBuilder_0.Append(Class333.aLW());
						flag4 = true;
					}
				}
				xmlReader_0.Read();
			}
			if (flag4)
			{
				stringBuilder_0.Remove(stringBuilder_0.Length - 4, 4);
			}
		}
		if (flag)
		{
			stringBuilder_0.Append(Class333.aLR());
		}
		stringBuilder_0.Append(Class333.smethod_9());
	}

	private void method_41(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.agh());
		string attribute2 = xmlReader_0.GetAttribute(Class333.agI());
		string attribute3 = xmlReader_0.GetAttribute(Class333.alL());
		string attribute4 = xmlReader_0.GetAttribute(Class333.all());
		int int_ = 0;
		if (attribute != null)
		{
			int_ = int.Parse(attribute);
		}
		int int_2 = -1;
		if (attribute2 != null)
		{
			int_2 = int.Parse(attribute2);
		}
		ConvertFrom convertFrom_ = new ConvertFrom(int_, int_2, attribute3, attribute4);
		if (settingOrSpecialObject_0 is Setting setting)
		{
			setting.method_109(convertFrom_);
		}
		if (xmlReader_0.IsEmptyElement)
		{
			return;
		}
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.aIv()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.alM())
			{
				method_43(xmlReader_0, null, convertFrom_, null, null);
			}
			else if (xmlReader_0.Name == Class333.alm())
			{
				method_44(xmlReader_0, null, convertFrom_, null);
			}
			else if (xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				throw new Exception(string.Format(Class333.alN(), xmlReader_0.Name));
			}
			xmlReader_0.Read();
		}
	}

	private void method_42(XmlReader xmlReader_0, SettingOrSpecialObject settingOrSpecialObject_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.agh());
		string attribute2 = xmlReader_0.GetAttribute(Class333.agI());
		string attribute3 = xmlReader_0.GetAttribute(Class333.alL());
		string attribute4 = xmlReader_0.GetAttribute(Class333.all());
		int int_ = 0;
		if (attribute != null)
		{
			int_ = int.Parse(attribute);
		}
		int int_2 = -1;
		if (attribute2 != null)
		{
			int_2 = int.Parse(attribute2);
		}
		ConvertTo convertTo_ = new ConvertTo(int_, int_2, attribute3, attribute4);
		if (settingOrSpecialObject_0 is Setting setting)
		{
			setting.method_110(convertTo_);
		}
		if (xmlReader_0.IsEmptyElement)
		{
			return;
		}
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.aIW()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.alM())
			{
				method_43(xmlReader_0, null, null, convertTo_, null);
			}
			else if (xmlReader_0.Name == Class333.alm())
			{
				method_44(xmlReader_0, null, null, convertTo_);
			}
			else if (xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				throw new Exception(string.Format(Class333.aln(), xmlReader_0.Name));
			}
			xmlReader_0.Read();
		}
	}

	private void method_43(XmlReader xmlReader_0, Class261 class261_0, ConvertFrom convertFrom_0, ConvertTo convertTo_0, ModifyOnChange modifyOnChange_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.ahU());
		string attribute2 = xmlReader_0.GetAttribute(Class333.aLp());
		string attribute3 = xmlReader_0.GetAttribute(Class333.alO());
		string attribute4 = xmlReader_0.GetAttribute(Class333.alo());
		bool bool_ = false;
		string attribute5 = xmlReader_0.GetAttribute(Class333.alP());
		if (attribute5 != null)
		{
			bool_ = bool.Parse(attribute5);
		}
		string attribute6 = xmlReader_0.GetAttribute(Class333.alp());
		int int_ = -1;
		if (attribute6 != null)
		{
			int_ = int.Parse(attribute6);
		}
		Class261 class261_1 = new Class261(aXO, attribute, attribute2, attribute3, attribute4, int_, bool_);
		if (class261_0 != null)
		{
			class261_0.method_0(class261_1);
		}
		else if (convertFrom_0 != null)
		{
			convertFrom_0.method_4(class261_1);
		}
		else if (convertTo_0 != null)
		{
			convertTo_0.method_4(class261_1);
		}
		else
		{
			modifyOnChange_0?.method_0(class261_1);
		}
		if (xmlReader_0.IsEmptyElement)
		{
			return;
		}
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.alM()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.alM())
			{
				method_43(xmlReader_0, class261_1, convertFrom_0, convertTo_0, modifyOnChange_0);
			}
			else if (xmlReader_0.Name == Class333.alm())
			{
				method_44(xmlReader_0, class261_1, convertFrom_0, convertTo_0);
			}
			else if (xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				throw new Exception(string.Format(Class333.alQ(), xmlReader_0.Name));
			}
			xmlReader_0.Read();
		}
	}

	private void method_44(XmlReader xmlReader_0, Class261 class261_0, ConvertFrom convertFrom_0, ConvertTo convertTo_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.aLp());
		Class262 class261_1 = new Class262(aXO, attribute);
		if (class261_0 != null)
		{
			class261_0.method_0(class261_1);
		}
		else if (convertFrom_0 != null)
		{
			convertFrom_0.method_4(class261_1);
		}
		else
		{
			convertTo_0?.method_4(class261_1);
		}
		if (xmlReader_0.IsEmptyElement)
		{
			return;
		}
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.alm()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace)
			{
				xmlReader_0.Read();
				continue;
			}
			throw new Exception(string.Format(Class333.alq(), xmlReader_0.Name));
		}
	}

	private void method_45(XmlReader xmlReader_0, Class256 class256_0)
	{
		int key = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.aiI()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if ((xmlReader_0.Name == Class333.smethod_1308() || xmlReader_0.Name == Class333.ahs()) && xmlReader_0.GetAttribute(Class333.ahQ()) == Class333.alR())
			{
				if (class256_0.method_76().ContainsKey(key))
				{
					if (class256_0.method_76()[key] == null)
					{
						class256_0.method_76()[key] = new List<int>();
					}
				}
				else
				{
					class256_0.method_76().Add(key, new List<int>());
				}
				int item = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
				class256_0.method_76()[key].Add(item);
			}
			else if (xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				throw new Exception(string.Format(Class333.alr(), xmlReader_0.Name));
			}
			xmlReader_0.Read();
		}
	}

	private void method_46(XmlReader xmlReader_0, Class256 class256_0)
	{
		int key = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.aii()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if ((xmlReader_0.Name == Class333.smethod_1308() || xmlReader_0.Name == Class333.ahs()) && xmlReader_0.GetAttribute(Class333.ahQ()) == Class333.alR())
			{
				if (class256_0.method_75().ContainsKey(key))
				{
					if (class256_0.method_75()[key] == null)
					{
						class256_0.method_75()[key] = new List<int>();
					}
				}
				else
				{
					class256_0.method_75().Add(key, new List<int>());
				}
				int item = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
				class256_0.method_75()[key].Add(item);
			}
			else if (xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				throw new Exception(string.Format(Class333.alS(), xmlReader_0.Name));
			}
			xmlReader_0.Read();
		}
	}

	private void method_47(XmlReader xmlReader_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
		string attribute2 = xmlReader_0.GetAttribute(Class333.ahU());
		string attribute3 = xmlReader_0.GetAttribute(Class333.als());
		xmlReader_0.Read();
		string value = xmlReader_0.Value;
		if (!string.IsNullOrEmpty(attribute) && !string.IsNullOrEmpty(attribute2) && !string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(attribute3))
		{
			int result = -1;
			if (!int.TryParse(attribute3, out result))
			{
				throw new Exception(Class333.alt() + attribute + Class333.aII());
			}
			value = value.Replace(Class333.smethod_570(), Class333.smethod_102()).Replace(Class333.smethod_2225(), Class333.smethod_102()).Replace(Class333.alU(), Class333.smethod_102())
				.Trim();
			string[] array = value.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			List<ushort> list = new List<ushort>();
			List<uint> list2 = new List<uint>();
			string[] array2 = array;
			int num = 0;
			while (true)
			{
				if (num < array2.Length)
				{
					string text = array2[num];
					string text2 = text;
					if (text.StartsWith(Class333.smethod_381()))
					{
						text2 = text.Substring(2);
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (int.TryParse(text2, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var result2))
					{
						if (text2.Length == 3)
						{
							list.Add((ushort)result2);
						}
						else
						{
							if (text2.Length != 8)
							{
								defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(102, 2);
								defaultInterpolatedStringHandler.AppendLiteral(Class333.alu());
								defaultInterpolatedStringHandler.AppendFormatted(attribute);
								defaultInterpolatedStringHandler.AppendLiteral(Class333.alV());
								defaultInterpolatedStringHandler.AppendFormatted(text);
								defaultInterpolatedStringHandler.AppendLiteral(Class333.alv());
								throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							list2.Add((uint)result2);
						}
						num++;
						continue;
					}
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(55, 2);
					defaultInterpolatedStringHandler.AppendLiteral(Class333.alu());
					defaultInterpolatedStringHandler.AppendFormatted(attribute);
					defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_536());
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral(Class333.alW());
					throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				if (!aXO.awH.ContainsKey(result))
				{
					aXO.awH[result] = new List<Class270>();
				}
				break;
			}
			List<Class270> list3 = aXO.awH[result];
			Class270 @class = new Class270();
			@class.method_1(attribute);
			@class.method_3(attribute2);
			@class.method_5(result);
			@class.method_7(list);
			@class.method_9(list2);
			list3.Add(@class);
			xmlReader_0.Read();
			return;
		}
		throw new Exception(Class333.alT());
	}

	private void method_48(XmlReader xmlReader_0)
	{
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.ahf()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.alw() || xmlReader_0.Name == Class333.alX())
			{
				method_49(xmlReader_0);
				xmlReader_0.Read();
				continue;
			}
			throw new Exception(string.Format(Class333.alx(), xmlReader_0.Name));
		}
	}

	private void method_49(XmlReader xmlReader_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
		string attribute2 = xmlReader_0.GetAttribute(Class333.aIL());
		string attribute3 = xmlReader_0.GetAttribute(Class333.aIB());
		Enum97 enum97_;
		if (attribute3 == Class333.alY())
		{
			enum97_ = Enum97.aYz;
		}
		else if (attribute3 == Class333.aly())
		{
			enum97_ = Enum97.ayA;
		}
		else
		{
			if (!(attribute3 == Class333.alZ()))
			{
				throw new Exception(string.Format(Class333.alz(), attribute3));
			}
			enum97_ = Enum97.aya;
		}
		Class258 @class = new Class258(aXO, attribute, attribute2, enum97_);
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && ((!(xmlReader_0.Name == Class333.alw()) && !(xmlReader_0.Name == Class333.alX())) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (!(xmlReader_0.Name == Class333.smethod_1308()) && !(xmlReader_0.Name == Class333.ahs()))
			{
				if (!(xmlReader_0.Name == Class333.ali()) && !(xmlReader_0.Name == Class333.alJ()))
				{
					if (!(xmlReader_0.Name == Class333.alj()) && !(xmlReader_0.Name == Class333.alK()))
					{
						if (xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
						{
							throw new Exception(string.Format(Class333.aMA(), xmlReader_0.Name));
						}
					}
					else
					{
						method_53(xmlReader_0, @class);
					}
				}
				else
				{
					method_52(xmlReader_0, @class);
				}
			}
			else
			{
				method_50(xmlReader_0, @class);
			}
			xmlReader_0.Read();
		}
		aXO.awn.Add(attribute, @class);
	}

	private void method_50(XmlReader xmlReader_0, Class258 class258_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
		if (attribute == Class333.aMa())
		{
			class258_0.method_11(int.Parse(xmlReader_0.GetAttribute(Class333.aIP())));
		}
		else if (attribute.StartsWith(Class333.aMB()))
		{
			class258_0.method_12().Add(int.Parse(xmlReader_0.GetAttribute(Class333.aIP())));
		}
		else if (attribute.StartsWith(Class333.aMb()))
		{
			class258_0.method_13().Add(int.Parse(xmlReader_0.GetAttribute(Class333.aIP())));
		}
		else if (attribute.StartsWith(Class333.smethod_1086()))
		{
			method_51(xmlReader_0, class258_0);
		}
		else if (!xmlReader_0.IsEmptyElement)
		{
			xmlReader_0.Skip();
		}
	}

	private void method_51(XmlReader xmlReader_0, Class258 class258_0)
	{
		bool flag = true;
		string attribute = xmlReader_0.GetAttribute(Class333.aLp());
		if (attribute == null)
		{
			attribute = xmlReader_0.GetAttribute(Class333.aLQ());
		}
		if (attribute != null)
		{
			flag = bool.Parse(attribute);
		}
		StringBuilder stringBuilder_ = new StringBuilder(100);
		method_37(xmlReader_0, ref stringBuilder_);
		if (!flag)
		{
			stringBuilder_.Insert(0, Class333.aLq());
			stringBuilder_.Append(Class333.aLR());
		}
		class258_0.method_17(stringBuilder_.ToString());
	}

	private void method_52(XmlReader xmlReader_0, Class258 class258_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.aIL());
		Class260 @class = new Class260(class258_0, aXO, attribute);
		bool flag = true;
		string attribute2 = xmlReader_0.GetAttribute(Class333.aLp());
		if (attribute2 == null)
		{
			attribute2 = xmlReader_0.GetAttribute(Class333.aLQ());
		}
		if (attribute2 != null)
		{
			flag = bool.Parse(attribute2);
		}
		StringBuilder stringBuilder_ = new StringBuilder(100);
		method_38(xmlReader_0, ref stringBuilder_, @class);
		if (!flag)
		{
			stringBuilder_.Insert(0, Class333.aLq());
			stringBuilder_.Append(Class333.aLR());
		}
		@class.method_8(stringBuilder_.ToString());
		class258_0.method_15(@class);
	}

	private void method_53(XmlReader xmlReader_0, Class258 class258_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.aIL());
		Class259 @class = new Class259(class258_0, aXO, attribute);
		bool flag = true;
		string attribute2 = xmlReader_0.GetAttribute(Class333.aLp());
		if (attribute2 == null)
		{
			attribute2 = xmlReader_0.GetAttribute(Class333.aLQ());
		}
		if (attribute2 != null)
		{
			flag = bool.Parse(attribute2);
		}
		StringBuilder stringBuilder_ = new StringBuilder(100);
		method_39(xmlReader_0, ref stringBuilder_, @class);
		if (!flag)
		{
			stringBuilder_.Insert(0, Class333.aLq());
			stringBuilder_.Append(Class333.aLR());
		}
		@class.method_8(stringBuilder_.ToString());
		class258_0.method_16().Add(@class);
	}

	private void method_54(XmlReader xmlReader_0)
	{
		method_59();
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.ahg()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.aMC() && xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				method_60(xmlReader_0, aXO.awj[0]);
			}
			else if ((xmlReader_0.Name == Class333.smethod_1308() || xmlReader_0.Name == Class333.ahs()) && xmlReader_0.GetAttribute(Class333.ahQ()) == Class333.aMc())
			{
				MenuNode menuNode = aXO.awj[0];
				menuNode.method_74(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
				aXO.awX.Add(menuNode.method_73(), menuNode);
			}
			xmlReader_0.Read();
		}
	}

	private void method_55(XmlReader xmlReader_0)
	{
		xmlReader_0.Read();
		while (true)
		{
			if (xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace)
			{
				if (xmlReader_0.Name == Class333.ahH() && xmlReader_0.NodeType == XmlNodeType.EndElement)
				{
					break;
				}
				if (xmlReader_0.Name == Class333.aMC() && xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
				{
					method_61(xmlReader_0, aXO.awj[0]);
				}
				xmlReader_0.Read();
				continue;
			}
			return;
		}
		method_58(aXO.awj[0].method_6());
	}

	private void method_56(XmlReader xmlReader_0)
	{
		if (aXO.awl == null)
		{
			MenuNode menuNode = new MenuNode(aXO, null, null, bool_0: false, bool_1: true, string.Empty);
			menuNode.method_4(-1);
			menuNode.method_11(Class333.smethod_2571());
			menuNode.method_13(0);
			aXO.awl = menuNode;
		}
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.ahh()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.aMC() && xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				method_62(xmlReader_0, aXO.awl);
			}
			xmlReader_0.Read();
		}
	}

	private void method_57(XmlReader xmlReader_0)
	{
		if (aXO.awm == null)
		{
			MenuNode menuNode = new MenuNode(aXO, null, null, bool_0: false, bool_1: true, string.Empty);
			menuNode.method_4(-1);
			menuNode.method_11(Class333.smethod_1567());
			menuNode.method_13(0);
			aXO.awm = menuNode;
		}
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.ahI()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.aMC() && xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				method_63(xmlReader_0, aXO.awm);
			}
			xmlReader_0.Read();
		}
	}

	private void method_58(List<MenuNode> list_0)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			if (!list_0[i].method_7())
			{
				MenuNode menuNode = list_0[i];
				menuNode.method_13(menuNode.method_12() + aXO.awk);
				method_58(list_0[i].method_6());
			}
		}
	}

	private void method_59()
	{
		if (aXO.awj.Count == 0)
		{
			string string_ = aXO.awY + Class333.smethod_880() + aXO.aXA;
			MenuNode menuNode = new MenuNode(aXO, null, null, bool_0: false, bool_1: true, string.Empty);
			menuNode.method_4(-1);
			menuNode.method_11(string_);
			menuNode.method_69(aXO.aXC);
			menuNode.method_13(0);
			aXO.awj.Add(menuNode);
		}
	}

	private void method_60(XmlReader xmlReader_0, MenuNode menuNode_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
		int num = -1;
		string attribute2 = xmlReader_0.GetAttribute(Class333.alB());
		if (attribute2 != null)
		{
			num = int.Parse(attribute2);
		}
		string attribute3 = xmlReader_0.GetAttribute(Class333.aMD());
		bool bool_ = false;
		string attribute4 = xmlReader_0.GetAttribute(Class333.aMd());
		if (attribute4 != null)
		{
			bool_ = bool.Parse(attribute4);
		}
		MenuNode menuNode = new MenuNode(aXO, null, menuNode_0, bool_0: false, bool_, attribute3);
		menuNode.method_4(num);
		menuNode.method_11(attribute);
		aXO.awK++;
		menuNode.method_13(aXO.awK);
		if (num != -1)
		{
			aXO.method_33(num).method_46(menuNode);
		}
		if (attribute == Class333.aME())
		{
			aXO.awR = menuNode;
			aXO.awr = menuNode;
		}
		else if (attribute == Class333.aMe())
		{
			aXO.awr = menuNode;
		}
		else if (attribute == Class333.aMF())
		{
			if (menuNode.method_5().method_10() == Class333.aMf())
			{
				aXO.awU = menuNode;
			}
			else if (menuNode.method_5().method_10() == Class333.aMG())
			{
				aXO.awu = menuNode;
			}
			else if (menuNode.method_5().method_10() == Class333.aMg())
			{
				aXO.awV = menuNode;
			}
		}
		if (attribute.EndsWith(Class333.aMH()))
		{
			aXO.awS = menuNode;
		}
		if (!xmlReader_0.IsEmptyElement)
		{
			xmlReader_0.Read();
			while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.aMC()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
			{
				if (!(xmlReader_0.Name == Class333.smethod_1308()) && !(xmlReader_0.Name == Class333.ahs()))
				{
					if (xmlReader_0.Name == Class333.aMC())
					{
						method_60(xmlReader_0, menuNode);
					}
				}
				else
				{
					method_65(xmlReader_0, menuNode);
				}
				xmlReader_0.Read();
			}
		}
		menuNode_0?.method_6().Add(menuNode);
	}

	private void method_61(XmlReader xmlReader_0, MenuNode menuNode_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
		int num = -1;
		string attribute2 = xmlReader_0.GetAttribute(Class333.alB());
		if (attribute2 != null)
		{
			num = int.Parse(attribute2);
		}
		string attribute3 = xmlReader_0.GetAttribute(Class333.aMD());
		aXO.awk++;
		MenuNode menuNode = new MenuNode(aXO, null, menuNode_0, bool_0: true, bool_1: false, attribute3);
		menuNode.method_4(num);
		menuNode.method_11(attribute);
		aXO.awk++;
		menuNode.method_13(aXO.awk);
		if (num != -1)
		{
			aXO.method_33(num).method_46(menuNode);
		}
		if (!xmlReader_0.IsEmptyElement)
		{
			xmlReader_0.Read();
			while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.aMC()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
			{
				if (!(xmlReader_0.Name == Class333.smethod_1308()) && !(xmlReader_0.Name == Class333.ahs()))
				{
					if (xmlReader_0.Name == Class333.aMC())
					{
						method_61(xmlReader_0, menuNode);
					}
				}
				else
				{
					method_65(xmlReader_0, menuNode);
				}
				xmlReader_0.Read();
			}
		}
		if (menuNode_0 == null)
		{
			return;
		}
		if (menuNode_0.method_5() == null)
		{
			int num2 = 0;
			for (int i = 0; i < menuNode_0.method_6().Count && menuNode_0.method_6()[i].method_7(); i++)
			{
				num2++;
			}
			menuNode_0.method_6().Insert(num2, menuNode);
		}
		else
		{
			menuNode_0.method_6().Add(menuNode);
		}
	}

	private void method_62(XmlReader xmlReader_0, MenuNode menuNode_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
		int int_ = -1;
		string attribute2 = xmlReader_0.GetAttribute(Class333.alB());
		if (attribute2 != null)
		{
			int_ = int.Parse(attribute2);
		}
		string attribute3 = xmlReader_0.GetAttribute(Class333.aMD());
		bool bool_ = false;
		string attribute4 = xmlReader_0.GetAttribute(Class333.aMd());
		if (attribute4 != null)
		{
			bool_ = bool.Parse(attribute4);
		}
		MenuNode menuNode = new MenuNode(aXO, null, menuNode_0, bool_0: false, bool_, attribute3);
		menuNode.method_4(int_);
		menuNode.method_11(attribute);
		aXO.awM++;
		menuNode.method_13(aXO.awM);
		if (!xmlReader_0.IsEmptyElement)
		{
			xmlReader_0.Read();
			while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.aMC()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
			{
				if (!(xmlReader_0.Name == Class333.smethod_1308()) && !(xmlReader_0.Name == Class333.ahs()))
				{
					if (xmlReader_0.Name == Class333.aMh())
					{
						method_64(xmlReader_0, menuNode);
					}
					else if (xmlReader_0.Name == Class333.aMC())
					{
						method_62(xmlReader_0, menuNode);
					}
				}
				else
				{
					method_65(xmlReader_0, menuNode);
				}
				xmlReader_0.Read();
			}
		}
		menuNode_0?.method_6().Add(menuNode);
	}

	private void method_63(XmlReader xmlReader_0, MenuNode menuNode_0)
	{
		string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
		int int_ = -1;
		string attribute2 = xmlReader_0.GetAttribute(Class333.alB());
		if (attribute2 != null)
		{
			int_ = int.Parse(attribute2);
		}
		string attribute3 = xmlReader_0.GetAttribute(Class333.aMD());
		bool bool_ = false;
		string attribute4 = xmlReader_0.GetAttribute(Class333.aMd());
		if (attribute4 != null)
		{
			bool_ = bool.Parse(attribute4);
		}
		MenuNode menuNode = new MenuNode(aXO, null, menuNode_0, bool_0: false, bool_, attribute3);
		menuNode.method_4(int_);
		menuNode.method_11(attribute);
		aXO.awN++;
		menuNode.method_13(aXO.awN);
		if (!xmlReader_0.IsEmptyElement)
		{
			xmlReader_0.Read();
			while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.aMC()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
			{
				if (!(xmlReader_0.Name == Class333.smethod_1308()) && !(xmlReader_0.Name == Class333.ahs()))
				{
					if (xmlReader_0.Name == Class333.aMC())
					{
						method_63(xmlReader_0, menuNode);
					}
				}
				else
				{
					method_65(xmlReader_0, menuNode);
				}
				xmlReader_0.Read();
			}
		}
		menuNode_0?.method_6().Add(menuNode);
	}

	private void method_64(XmlReader xmlReader_0, MenuNode menuNode_0)
	{
		int int_ = int.Parse(xmlReader_0.GetAttribute(Class333.aMI()));
		ModifyOnChange modifyOnChange_ = new ModifyOnChange(aXO, int_);
		menuNode_0.method_96(modifyOnChange_);
		if (xmlReader_0.IsEmptyElement)
		{
			return;
		}
		xmlReader_0.Read();
		while ((xmlReader_0.IsStartElement() || xmlReader_0.NodeType == XmlNodeType.EndElement || xmlReader_0.NodeType == XmlNodeType.Whitespace) && (!(xmlReader_0.Name == Class333.aMh()) || xmlReader_0.NodeType != XmlNodeType.EndElement))
		{
			if (xmlReader_0.Name == Class333.alM())
			{
				method_43(xmlReader_0, null, null, null, modifyOnChange_);
			}
			else if (xmlReader_0.NodeType != XmlNodeType.EndElement && xmlReader_0.NodeType != XmlNodeType.Whitespace)
			{
				throw new Exception(string.Format(Class333.aMi(), xmlReader_0.Name));
			}
			xmlReader_0.Read();
		}
	}

	private void method_65(XmlReader xmlReader_0, MenuNode menuNode_0)
	{
		string string_ = string.Empty;
		string attribute = xmlReader_0.GetAttribute(Class333.ahQ());
		if (attribute != null)
		{
			switch (attribute.Length)
			{
			case 4:
				switch (attribute[0])
				{
				case 'T':
					if (attribute == Class333.alX())
					{
						menuNode_0.method_9(xmlReader_0.GetAttribute(Class333.aLX()));
						return;
					}
					break;
				case 'S':
					if (!(attribute == Class333.smethod_940()))
					{
						break;
					}
					return;
				}
				break;
			case 5:
				if (attribute == Class333.ahJ())
				{
					xmlReader_0.Read();
					xmlReader_0.Skip();
					return;
				}
				break;
			case 6:
				if (attribute == Class333.smethod_1091())
				{
					menuNode_0.method_61(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					aXO.awA = true;
					aXO.awB.Add(menuNode_0.method_60(), menuNode_0);
					if (menuNode_0.method_60() > aXO.awa)
					{
						aXO.awa = menuNode_0.method_60();
					}
					return;
				}
				break;
			case 7:
				switch (attribute[0])
				{
				case 'S':
					if (attribute == Class333.aML())
					{
						menuNode_0.method_53(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						return;
					}
					break;
				case 'F':
					if (attribute == Class333.aMl())
					{
						menuNode_0.method_55(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						return;
					}
					break;
				case 'C':
					if (attribute == Class333.aMc())
					{
						menuNode_0.method_74(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						string attribute3 = xmlReader_0.GetAttribute(Class333.ajt());
						if (attribute3 != null)
						{
							menuNode_0.method_76(bool.Parse(attribute3));
						}
						string attribute4 = xmlReader_0.GetAttribute(Class333.ajU());
						if (attribute4 != null)
						{
							menuNode_0.method_78(bool.Parse(attribute4));
						}
						aXO.awX.Add(menuNode_0.method_73(), menuNode_0);
						return;
					}
					break;
				}
				break;
			case 8:
				switch (attribute[0])
				{
				case 'H':
					if (attribute == Class333.aip())
					{
						method_31(xmlReader_0, ref string_);
						menuNode_0.method_67(string_);
						return;
					}
					break;
				case 'C':
					if (!(attribute == Class333.aMo()))
					{
						break;
					}
					return;
				case 'P':
					if (attribute == Class333.aDa())
					{
						string attribute2 = xmlReader_0.GetAttribute(Class333.ahL());
						attribute2 = attribute2.Substring(1, attribute2.Length - 2);
						menuNode_0.method_25(int.Parse(attribute2.Substring(0, 1)));
						menuNode_0.method_27(int.Parse(attribute2.Substring(attribute2.Length - 1, 1)));
						return;
					}
					break;
				case 'M':
					if (!(attribute == Class333.aMO()))
					{
						break;
					}
					return;
				}
				break;
			case 10:
				if (attribute == Class333.smethod_1076())
				{
					method_31(xmlReader_0, ref string_);
					menuNode_0.method_65(string_);
					return;
				}
				break;
			case 11:
				switch (attribute[0])
				{
				case 'R':
					if (attribute == Class333.aLc())
					{
						menuNode_0.method_18(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						return;
					}
					break;
				case 'D':
					if (attribute == Class333.smethod_91())
					{
						method_31(xmlReader_0, ref string_);
						menuNode_0.method_63(string_);
						return;
					}
					break;
				}
				break;
			case 12:
				switch (attribute[0])
				{
				case 'F':
					if (!(attribute == Class333.aMU()))
					{
						break;
					}
					return;
				case 'D':
					if (attribute == Class333.aMt())
					{
						menuNode_0.method_51(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						return;
					}
					break;
				}
				break;
			case 13:
				switch (attribute[0])
				{
				case 'S':
					if (!(attribute == Class333.aMP()))
					{
						break;
					}
					return;
				case 'I':
					if (attribute == Class333.ahj())
					{
						xmlReader_0.Read();
						menuNode_0.method_69(xmlReader_0.Value);
						xmlReader_0.Skip();
						return;
					}
					break;
				}
				break;
			case 14:
				switch (attribute[0])
				{
				case 'P':
					if (!(attribute == Class333.aKa()))
					{
						break;
					}
					menuNode_0.method_21(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					aXO.method_33(menuNode_0.method_20()).method_46(menuNode_0);
					if (!menuNode_0.method_7())
					{
						for (int i = 0; i < 20; i++)
						{
							MenuNode menuNode = new MenuNode(aXO, null, menuNode_0, bool_0: false, bool_1: false, string.Empty);
							menuNode.method_15(bool_0: true);
							menuNode.method_4(-1);
							menuNode.method_11(null);
							aXO.awK++;
							menuNode.method_13(aXO.awK);
							menuNode_0.method_6().Add(menuNode);
						}
					}
					return;
				case 'I':
					if (attribute == Class333.aMJ())
					{
						return;
					}
					break;
				}
				break;
			case 15:
				if (attribute == Class333.aMS())
				{
					menuNode_0.method_40(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					return;
				}
				break;
			case 17:
				if (attribute == Class333.aMp())
				{
					menuNode_0.method_30(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					return;
				}
				break;
			case 18:
				if (attribute == Class333.aMk())
				{
					if (bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())))
					{
						aXO.awL.Add(menuNode_0);
					}
					return;
				}
				break;
			case 21:
				switch (attribute[0])
				{
				case 'F':
					if (attribute == Class333.aMj())
					{
						menuNode_0.method_23(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						aXO.aWz = true;
						aXO.method_31(menuNode_0.method_22()).method_153(menuNode_0);
						return;
					}
					break;
				case 'A':
					if (attribute == Class333.aMK())
					{
						menuNode_0.method_91(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						return;
					}
					break;
				}
				break;
			case 22:
				switch (attribute[0])
				{
				case 'H':
					if (attribute == Class333.aMM())
					{
						menuNode_0.method_87(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						return;
					}
					break;
				case 'C':
					if (attribute == Class333.aMm())
					{
						method_31(xmlReader_0, ref string_);
						menuNode_0.method_72(string_);
						return;
					}
					break;
				}
				break;
			case 23:
				switch (attribute[0])
				{
				case 'D':
					if (attribute == Class333.aMs())
					{
						menuNode_0.method_47(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						return;
					}
					break;
				case 'C':
					if (attribute == Class333.aMT())
					{
						menuNode_0.method_57(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						return;
					}
					break;
				}
				break;
			case 24:
				switch (attribute[0])
				{
				case 'I':
					if (attribute == Class333.aMR())
					{
						menuNode_0.method_36(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						return;
					}
					break;
				case 'D':
					if (attribute == Class333.aMr())
					{
						menuNode_0.method_42(int.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
						return;
					}
					break;
				}
				break;
			case 27:
				if (attribute == Class333.aMN())
				{
					menuNode_0.method_89(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					return;
				}
				break;
			case 28:
				if (attribute == Class333.aMu())
				{
					menuNode_0.method_59(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					return;
				}
				break;
			case 32:
				if (attribute == Class333.aMq())
				{
					menuNode_0.method_34(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					return;
				}
				break;
			case 33:
				if (attribute == Class333.aMn())
				{
					menuNode_0.method_93(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					return;
				}
				break;
			case 34:
				if (attribute == Class333.aMQ())
				{
					menuNode_0.method_32(bool.Parse(xmlReader_0.GetAttribute(Class333.ahL())));
					return;
				}
				break;
			}
		}
		if (attribute.StartsWith(Class333.ajS()))
		{
			method_31(xmlReader_0, ref string_);
			menuNode_0.method_70().Add(string_);
		}
		else if (attribute.StartsWith(Class333.aMV()))
		{
			int item = int.Parse(xmlReader_0.GetAttribute(Class333.ahL()));
			menuNode_0.method_103().Add(item);
		}
		else if (!xmlReader_0.IsEmptyElement)
		{
			xmlReader_0.Skip();
		}
	}
}
