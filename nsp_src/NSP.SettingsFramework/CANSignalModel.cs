using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using D;

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
		RX,
		TX_None,
		TX_FixedValue,
		TX_Channel,
		TX_Counter
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class b
	{
		public static readonly b BSf = new b();

		public static Func<ValueAndDisplay, string> BSG;

		internal string A(ValueAndDisplay P_0)
		{
			return P_0.Display;
		}
	}

	[CompilerGenerated]
	private sealed class C
	{
		public string BSg;

		internal bool A(SettingOrSpecialObject P_0)
		{
			return P_0.B() == BSg;
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

	public int Id
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
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			DN dN = A();
			if (dN == null || Index == -1 || !BM.A(BM.Qz.aXc, true) || BM.aE())
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
			}
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.arz();
			string item = DN.BZH[(DN.A)Bus].Item2;
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(15, 1);
			defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSA());
			defaultInterpolatedStringHandler.AppendFormatted<int>(Index);
			defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aSa());
			string BSg = text + item + defaultInterpolatedStringHandler.ToStringAndClear();
			if (!(Enumerable.FirstOrDefault<SettingOrSpecialObject>((System.Collections.Generic.IEnumerable<SettingOrSpecialObject>)((SettingOrSpecialObject)dN).a(), (Func<SettingOrSpecialObject, bool>)((SettingOrSpecialObject P_0) => P_0.B() == BSg)) is Setting setting) || InvalidUnits)
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
			}
			int num = setting.ax();
			if (FrameDirection == CANFrameModel.Direction.Receive)
			{
				ValueTuple<string, string, bool> val = setting.A(num, (byte)Units);
				return val.Item1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + val.Item2;
			}
			if (Multiplier == 0f)
			{
				return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
			}
			return num.ToString();
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
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ib();
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
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			if (Source == null && FrameDirection == CANFrameModel.Direction.Receive)
			{
				if (!BM.A(BM.Qz.aXc, true) || BM.aE())
				{
					return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
				}
				long num = 0L;
				if (Format == 1)
				{
					num = (azc >> (int)StartBit) & ((BitLength >= 64) ? (-1) : ((1L << (int)BitLength) - 1));
				}
				else if (Format == 0)
				{
					num = 0L;
					uint num2 = StartBit;
					for (int i = 0; i < BitLength; i++)
					{
						byte b = (byte)(num2 / 8);
						byte b2 = (byte)(num2 % 8);
						byte b3 = (byte)((azc >> b * 8 + b2) & 1);
						num = (num << 1) | b3;
						num2 = ((b2 != 0) ? (num2 - 1) : (num2 + 15));
					}
				}
				if (Sign == 1)
				{
					long num3 = 1L << (int)(BitLength - 1);
					if ((num & num3) != 0L)
					{
						num |= ~((1L << (int)BitLength) - 1);
					}
				}
				return $"{num}";
			}
			if (Source is FixedSource)
			{
				return Source.Value.ToString();
			}
			if (Source is ChannelSource)
			{
				Setting channel = (Source as ChannelSource).Channel;
				if (channel == null || InvalidUnits)
				{
					return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
				}
				int num4 = (byte)Units;
				int num5 = channel.ax();
				ValueTuple<string, string, bool> val = channel.A(num5, num4);
				return val.Item1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + val.Item2;
			}
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
		}
		set
		{
			long num = default(long);
			if (long.TryParse(value, ref num))
			{
				azc = num;
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

	internal static CANSignalModel A(DN P_0, Framework P_1, CANSignalModel P_2, int P_3 = -1, int P_4 = -1, int P_5 = -1)
	{
		CANSignalModel cANSignalModel = ((P_2 != null) ? P_2 : new CANSignalModel
		{
			Id = P_3,
			Index = P_4,
			Bus = P_5
		});
		cANSignalModel.Name = P_0.BZm.N(cANSignalModel.Index);
		cANSignalModel.StartBit = (uint)P_0.BZo.m(cANSignalModel.Index);
		cANSignalModel.BitLength = (uint)P_0.BZP.m(cANSignalModel.Index);
		cANSignalModel.Format = P_0.BZp.m(cANSignalModel.Index);
		cANSignalModel.Sign = P_0.BZQ.m(cANSignalModel.Index);
		cANSignalModel.Units = P_0.BZr.m(cANSignalModel.Index);
		byte[] bytes = BitConverter.GetBytes(P_0.BZq.m(cANSignalModel.Index));
		if (!P_1.aWR)
		{
			System.Array.Reverse<byte>(bytes);
		}
		cANSignalModel.Multiplier = BitConverter.ToSingle(bytes, 0);
		byte[] bytes2 = BitConverter.GetBytes(P_0.BZR.m(cANSignalModel.Index));
		if (!P_1.aWR)
		{
			System.Array.Reverse<byte>(bytes2);
		}
		cANSignalModel.Offset = BitConverter.ToSingle(bytes2, 0);
		int num = P_0.BZn.m(cANSignalModel.Index);
		switch (num)
		{
		case 3:
		{
			int num2 = P_0.BZO.m(cANSignalModel.Index);
			Setting setting = P_1.A(num2);
			cANSignalModel.Source = ((setting != null) ? new ChannelSource(setting) : null);
			break;
		}
		case 2:
		{
			int val = P_0.BZO.m(cANSignalModel.Index);
			cANSignalModel.Source = new FixedSource(val);
			break;
		}
		case 4:
			cANSignalModel.Source = new CounterSource();
			break;
		default:
			cANSignalModel.Source = null;
			break;
		}
		cANSignalModel.FrameDirection = ((num != 0) ? CANFrameModel.Direction.Transmit : CANFrameModel.Direction.Receive);
		return cANSignalModel;
	}

	public virtual string ToString()
	{
		return string.Concat(new string[10]
		{
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.arx(),
			(Name != null) ? Name : string.Empty,
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.arV(),
			Index.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.arY(),
			Id.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ary(),
			StartBit.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.arZ(),
			BitLength.ToString()
		});
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
				long num = default(long);
				if (long.TryParse(value, ref num))
				{
					if (num >= -(1L << (int)(BitLength - 1)))
					{
						return num >= 1L << (int)(BitLength - 1);
					}
					return true;
				}
				return false;
			}
			ulong num2 = default(ulong);
			if (ulong.TryParse(value, ref num2))
			{
				return num2 >= (ulong)(1L << (int)BitLength);
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

	private DN A()
	{
		if (Bus == 1)
		{
			return BM.Qz.awT;
		}
		if (Bus == 0)
		{
			return BM.Qz.aws;
		}
		if (Bus == 4)
		{
			return BM.Qz.awt;
		}
		return null;
	}

	public List<ValueAndDisplay> GetUnitsListDataSource()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		List<ValueAndDisplay> val = new List<ValueAndDisplay>();
		DN dN = A();
		if (dN != null)
		{
			Enumerator<Setting.ListItems.A> enumerator = dN.BZr.d(Index).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting.ListItems.A current = enumerator.Current;
					if (FrameDirection == CANFrameModel.Direction.Receive || Source is FixedSource)
					{
						val.Add(new ValueAndDisplay
						{
							Value = current.bBv,
							Display = current.bBV
						});
					}
					else if (Source is ChannelSource)
					{
						Setting channel = (Source as ChannelSource).Channel;
						byte b = (byte)((uint)(current.bBv >> 8) & 0xFFu);
						if (channel != null && channel.aS() == b)
						{
							val.Add(new ValueAndDisplay
							{
								Value = current.bBv,
								Display = current.bBV
							});
						}
					}
					else if (Source is CounterSource && current.bBv == 0)
					{
						val.Add(new ValueAndDisplay
						{
							Value = current.bBv,
							Display = current.bBV
						});
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		return Enumerable.ToList<ValueAndDisplay>((System.Collections.Generic.IEnumerable<ValueAndDisplay>)Enumerable.OrderBy<ValueAndDisplay, string>((System.Collections.Generic.IEnumerable<ValueAndDisplay>)val, (Func<ValueAndDisplay, string>)((ValueAndDisplay P_0) => P_0.Display)));
	}

	internal ulong a()
	{
		return azC;
	}

	internal void A(uint P_0)
	{
		if (P_0 < 64)
		{
			azC |= (ulong)(1L << (int)P_0);
		}
	}

	internal bool a(uint P_0)
	{
		if (P_0 < 64)
		{
			return ((azC >> (int)P_0) & 1) == 1;
		}
		return false;
	}

	internal void B()
	{
		azC = 0uL;
	}
}
