using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ns3;
using ns4;
using ns7;

namespace NSP.SettingsFramework;

public class CANSignalModel
{
	public enum SignalFormat
	{
		BigEndian,
		LittleEndian
	}

	public enum SignalSign
	{
		Unsigned,
		Signed
	}

	public enum ChannelTypes
	{
		const_0,
		TX_None,
		TX_FixedValue,
		TX_Channel,
		TX_Counter
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class267
	{
		public static readonly Class267 BSf = new Class267();

		public static Func<ValueAndDisplay, string> BSG;

		internal string method_0(ValueAndDisplay valueAndDisplay_0)
		{
			return valueAndDisplay_0.Display;
		}
	}

	[CompilerGenerated]
	private sealed class Class268
	{
		public string BSg;

		internal bool method_0(SettingOrSpecialObject settingOrSpecialObject_0)
		{
			return settingOrSpecialObject_0.method_2() == BSg;
		}
	}

	private ulong azC;

	private long azc;

	public const int SIGNAL_REMOVED = -1;

	public const int UNSPECIFIED_UNITS = 65535;

	public const int RAW_UNITS = 0;

	private int azD = 65535;

	private ISignalSource azd;

	[CompilerGenerated]
	private int azE = -1;

	[CompilerGenerated]
	private int aze = -1;

	[CompilerGenerated]
	private int azF;

	[CompilerGenerated]
	private string azf;

	[CompilerGenerated]
	private int azG;

	[CompilerGenerated]
	private uint azg;

	[CompilerGenerated]
	private uint azH;

	[CompilerGenerated]
	private int azh;

	[CompilerGenerated]
	private float azI;

	[CompilerGenerated]
	private float azi;

	[CompilerGenerated]
	private bool azJ;

	[CompilerGenerated]
	private bool azj;

	[CompilerGenerated]
	private bool azK;

	[CompilerGenerated]
	private bool azk;

	[CompilerGenerated]
	private CANFrameModel.Direction azL;

	public int Bus
	{
		[CompilerGenerated]
		get
		{
			return azE;
		}
		[CompilerGenerated]
		set
		{
			azE = value;
		}
	}

	public int Index
	{
		[CompilerGenerated]
		get
		{
			return aze;
		}
		[CompilerGenerated]
		set
		{
			aze = value;
		}
	}

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return azF;
		}
		[CompilerGenerated]
		set
		{
			azF = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return azf;
		}
		[CompilerGenerated]
		set
		{
			azf = value;
		}
	}

	public int Format
	{
		[CompilerGenerated]
		get
		{
			return azG;
		}
		[CompilerGenerated]
		set
		{
			azG = value;
		}
	}

	public uint StartBit
	{
		[CompilerGenerated]
		get
		{
			return azg;
		}
		[CompilerGenerated]
		set
		{
			azg = value;
		}
	}

	public uint BitLength
	{
		[CompilerGenerated]
		get
		{
			return azH;
		}
		[CompilerGenerated]
		set
		{
			azH = value;
		}
	}

	public int Sign
	{
		[CompilerGenerated]
		get
		{
			return azh;
		}
		[CompilerGenerated]
		set
		{
			azh = value;
		}
	}

	public int Units
	{
		get
		{
			if (!(azd is CounterSource))
			{
				return azD;
			}
			return 0;
		}
		set
		{
			azD = ((!(azd is CounterSource)) ? value : 0);
		}
	}

	public float Multiplier
	{
		[CompilerGenerated]
		get
		{
			return azI;
		}
		[CompilerGenerated]
		set
		{
			azI = value;
		}
	}

	public float Offset
	{
		[CompilerGenerated]
		get
		{
			return azi;
		}
		[CompilerGenerated]
		set
		{
			azi = value;
		}
	}

	public bool InvalidUnits => Units == 65535;

	public string Value
	{
		get
		{
			Class255 @class = method_0();
			if (@class != null && Index != -1 && Form23.smethod_28(Form23.framework_1.aXc, bool_53: true) && !Form23.smethod_80())
			{
				string text = Class333.arz();
				string item = Class255.BZH[(Class255.Enum99)Bus].internalName;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
				defaultInterpolatedStringHandler.AppendLiteral(Class333.aSA());
				defaultInterpolatedStringHandler.AppendFormatted(Index);
				defaultInterpolatedStringHandler.AppendLiteral(Class333.aSa());
				string BSg = text + item + defaultInterpolatedStringHandler.ToStringAndClear();
				if (@class.method_1().FirstOrDefault((SettingOrSpecialObject settingOrSpecialObject_0) => settingOrSpecialObject_0.method_2() == BSg) is Setting setting && !InvalidUnits)
				{
					int int_ = setting.method_256();
					if (FrameDirection == CANFrameModel.Direction.Receive)
					{
						(string, string, bool) tuple = setting.method_253(int_, (byte)Units);
						return tuple.Item1 + Class333.smethod_325() + tuple.Item2;
					}
					if (Multiplier == 0f)
					{
						return Class333.smethod_186();
					}
					return int_.ToString();
				}
				return Class333.smethod_186();
			}
			return Class333.smethod_186();
		}
	}

	public string SourceString
	{
		get
		{
			if (Source != null)
			{
				return Source.Name;
			}
			return Class333.smethod_836();
		}
	}

	public ISignalSource Source
	{
		get
		{
			return azd;
		}
		set
		{
			azd = value;
			if (azd is CounterSource)
			{
				azD = 0;
			}
		}
	}

	public string RawValue
	{
		get
		{
			if (Source == null && FrameDirection == CANFrameModel.Direction.Receive)
			{
				if (Form23.smethod_28(Form23.framework_1.aXc, bool_53: true) && !Form23.smethod_80())
				{
					long num = 0L;
					if (Format == 1)
					{
						num = (azc >> (int)StartBit) & ((BitLength >= 64) ? (-1L) : ((1L << (int)BitLength) - 1L));
					}
					else if (Format == 0)
					{
						num = 0L;
						uint num2 = StartBit;
						for (int i = 0; i < BitLength; i++)
						{
							byte b = (byte)(num2 / 8);
							byte b2 = (byte)(num2 % 8);
							byte b3 = (byte)((azc >> b * 8 + b2) & 1L);
							num = (num << 1) | b3;
							num2 = ((b2 != 0) ? (num2 - 1) : (num2 + 15));
						}
					}
					if (Sign == 1)
					{
						long num3 = 1L << (int)(BitLength - 1);
						if ((num & num3) != 0L)
						{
							num |= ~((1L << (int)BitLength) - 1L);
						}
					}
					return $"{num}";
				}
				return Class333.smethod_186();
			}
			if (Source is FixedSource)
			{
				return Source.Value.ToString();
			}
			if (Source is ChannelSource)
			{
				Setting channel = (Source as ChannelSource).Channel;
				if (channel != null && !InvalidUnits)
				{
					int int_ = (byte)Units;
					int int_2 = channel.method_256();
					(string, string, bool) tuple = channel.method_253(int_2, int_);
					return tuple.Item1 + Class333.smethod_325() + tuple.Item2;
				}
				return Class333.smethod_186();
			}
			return Class333.smethod_186();
		}
		set
		{
			if (long.TryParse(value, out var result))
			{
				azc = result;
			}
			else
			{
				azc = 0L;
			}
		}
	}

	public bool HasBitOverlapError
	{
		[CompilerGenerated]
		get
		{
			return azJ;
		}
		[CompilerGenerated]
		set
		{
			azJ = value;
		}
	}

	public bool HasBeyondEndOfFrameError
	{
		[CompilerGenerated]
		get
		{
			return azj;
		}
		[CompilerGenerated]
		set
		{
			azj = value;
		}
	}

	public bool HasSignalNameError
	{
		[CompilerGenerated]
		get
		{
			return azK;
		}
		[CompilerGenerated]
		set
		{
			azK = value;
		}
	}

	public bool HasZeroMultiplierWarning
	{
		[CompilerGenerated]
		get
		{
			return azk;
		}
		[CompilerGenerated]
		set
		{
			azk = value;
		}
	}

	public CANFrameModel.Direction FrameDirection
	{
		[CompilerGenerated]
		get
		{
			return azL;
		}
		[CompilerGenerated]
		set
		{
			azL = value;
		}
	}

	internal static CANSignalModel smethod_0(Class255 class255_0, Framework framework_0, CANSignalModel cansignalModel_0, int int_0 = -1, int int_1 = -1, int int_2 = -1)
	{
		CANSignalModel cANSignalModel = ((cansignalModel_0 != null) ? cansignalModel_0 : new CANSignalModel
		{
			Int32_0 = int_0,
			Index = int_1,
			Bus = int_2
		});
		cANSignalModel.Name = class255_0.BZm.method_261(cANSignalModel.Index);
		cANSignalModel.StartBit = (uint)class255_0.BZo.method_258(cANSignalModel.Index);
		cANSignalModel.BitLength = (uint)class255_0.BZP.method_258(cANSignalModel.Index);
		cANSignalModel.Format = class255_0.BZp.method_258(cANSignalModel.Index);
		cANSignalModel.Sign = class255_0.BZQ.method_258(cANSignalModel.Index);
		cANSignalModel.Units = class255_0.BZr.method_258(cANSignalModel.Index);
		byte[] bytes = BitConverter.GetBytes(class255_0.BZq.method_258(cANSignalModel.Index));
		if (!framework_0.aWR)
		{
			Array.Reverse(bytes);
		}
		cANSignalModel.Multiplier = BitConverter.ToSingle(bytes, 0);
		byte[] bytes2 = BitConverter.GetBytes(class255_0.BZR.method_258(cANSignalModel.Index));
		if (!framework_0.aWR)
		{
			Array.Reverse(bytes2);
		}
		cANSignalModel.Offset = BitConverter.ToSingle(bytes2, 0);
		int num = class255_0.BZn.method_258(cANSignalModel.Index);
		switch (num)
		{
		default:
			cANSignalModel.Source = null;
			break;
		case 2:
		{
			int val = class255_0.BZO.method_258(cANSignalModel.Index);
			cANSignalModel.Source = new FixedSource(val);
			break;
		}
		case 3:
		{
			int int_3 = class255_0.BZO.method_258(cANSignalModel.Index);
			Setting setting = framework_0.method_31(int_3);
			cANSignalModel.Source = ((setting != null) ? new ChannelSource(setting) : null);
			break;
		}
		case 4:
			cANSignalModel.Source = new CounterSource();
			break;
		}
		cANSignalModel.FrameDirection = ((num != 0) ? CANFrameModel.Direction.Transmit : CANFrameModel.Direction.Receive);
		return cANSignalModel;
	}

	public override string ToString()
	{
		return Class333.arx() + ((Name != null) ? Name : string.Empty) + Class333.arV() + Index + Class333.arY() + Int32_0 + Class333.ary() + StartBit + Class333.arZ() + BitLength;
	}

	public void UpdateStartBitAfterFormatChange()
	{
		if (Format == 1)
		{
			if (BitLength % 8 == 0 && StartBit % 8 == 7)
			{
				StartBit -= 7u;
			}
			else
			{
				if (BitLength >= 8)
				{
					return;
				}
				uint num = StartBit;
				for (int i = 0; i < BitLength; i++)
				{
					if (i != BitLength - 1)
					{
						num = ((num % 8 != 0) ? (num - 1) : (num + 15));
					}
				}
				if (StartBit / 8 == num / 8)
				{
					StartBit -= BitLength - 1;
				}
			}
		}
		else
		{
			if (Format != 0)
			{
				return;
			}
			if (BitLength % 8 == 0 && StartBit % 8 == 0)
			{
				StartBit += 7u;
			}
			else if (BitLength < 8)
			{
				uint num2 = StartBit + BitLength - 1;
				if (StartBit / 8 == num2 / 8)
				{
					StartBit += BitLength - 1;
				}
			}
		}
	}

	public bool ValueOverflowedBitLength()
	{
		if (FrameDirection == CANFrameModel.Direction.Transmit)
		{
			if (BitLength == 0)
			{
				return true;
			}
			string value = Value;
			if (Sign == 1)
			{
				if (long.TryParse(value, out var result))
				{
					if (result >= -(1L << (int)(BitLength - 1)))
					{
						return result >= 1L << (int)(BitLength - 1);
					}
					return true;
				}
				return false;
			}
			if (ulong.TryParse(value, out var result2))
			{
				return result2 >= (ulong)(1L << (int)BitLength);
			}
			return false;
		}
		return false;
	}

	public byte GetSignalTypeFromSource()
	{
		if (Source == null && FrameDirection == CANFrameModel.Direction.Transmit)
		{
			return 1;
		}
		if (Source is FixedSource)
		{
			return 2;
		}
		if (Source is ChannelSource)
		{
			return 3;
		}
		if (Source is CounterSource)
		{
			return 4;
		}
		return 0;
	}

	private Class255 method_0()
	{
		if (Bus == 1)
		{
			return Form23.framework_1.awT;
		}
		if (Bus == 0)
		{
			return Form23.framework_1.aws;
		}
		if (Bus == 4)
		{
			return Form23.framework_1.awt;
		}
		return null;
	}

	public List<ValueAndDisplay> GetUnitsListDataSource()
	{
		List<ValueAndDisplay> list = new List<ValueAndDisplay>();
		Class255 @class = method_0();
		if (@class != null)
		{
			foreach (Setting.ListItems.Struct45 item in @class.BZr.method_102(Index))
			{
				if (FrameDirection != CANFrameModel.Direction.Receive && !(Source is FixedSource))
				{
					if (Source is ChannelSource)
					{
						Setting channel = (Source as ChannelSource).Channel;
						byte b = (byte)((item.bBv >> 8) & 0xFF);
						if (channel != null && channel.method_231() == b)
						{
							list.Add(new ValueAndDisplay
							{
								Value = item.bBv,
								Display = item.bBV
							});
						}
					}
					else if (Source is CounterSource && item.bBv == 0)
					{
						list.Add(new ValueAndDisplay
						{
							Value = item.bBv,
							Display = item.bBV
						});
					}
				}
				else
				{
					list.Add(new ValueAndDisplay
					{
						Value = item.bBv,
						Display = item.bBV
					});
				}
			}
		}
		return list.OrderBy((ValueAndDisplay valueAndDisplay_0) => valueAndDisplay_0.Display).ToList();
	}

	internal ulong method_1()
	{
		return azC;
	}

	internal void method_2(uint uint_0)
	{
		if (uint_0 < 64)
		{
			azC |= (ulong)(1L << (int)uint_0);
		}
	}

	internal bool method_3(uint uint_0)
	{
		if (uint_0 < 64)
		{
			return ((azC >> (int)uint_0) & 1L) == 1L;
		}
		return false;
	}

	internal void method_4()
	{
		azC = 0uL;
	}
}
