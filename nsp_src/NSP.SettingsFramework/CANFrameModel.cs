using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using D;

namespace NSP.SettingsFramework;

public class CANFrameModel
{
	public enum Direction
	{
		None = -1,
		Receive,
		Transmit
	}

	public enum EnabledFlags : byte
	{
		Enabled = 128,
		Visible = 64,
		LengthMask = 63
	}

	public enum TransmitFlags : byte
	{
		Transmit = 128,
		Oneshot = 64,
		RateMask = 63
	}

	[CompilerGenerated]
	private Direction aZW;

	[CompilerGenerated]
	private uint aZw;

	[CompilerGenerated]
	private string aZX;

	[CompilerGenerated]
	private bool aZx;

	[CompilerGenerated]
	private bool aZY;

	[CompilerGenerated]
	private bool aZy = true;

	[CompilerGenerated]
	private bool aZZ;

	[CompilerGenerated]
	private uint aZz;

	[CompilerGenerated]
	private uint azA;

	[CompilerGenerated]
	private int aza;

	[CompilerGenerated]
	private bool azB;

	public ulong DataBitsInUse;

	[CompilerGenerated]
	private List<CANSignalModel> azb;

	public const uint EXTENDED_CAN_ID_BIT = 2147483648u;

	public Direction FrameDirection
	{
		[CompilerGenerated]
		get
		{
			return aZW;
		}
		[CompilerGenerated]
		set
		{
			aZW = value;
		}
	}

	public uint Index
	{
		[CompilerGenerated]
		get
		{
			return aZw;
		}
		[CompilerGenerated]
		set
		{
			aZw = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return aZX;
		}
		[CompilerGenerated]
		set
		{
			aZX = value;
		}
	}

	public bool Enabled
	{
		[CompilerGenerated]
		get
		{
			return aZx;
		}
		[CompilerGenerated]
		set
		{
			aZx = value;
		}
	}

	public bool Oneshot
	{
		[CompilerGenerated]
		get
		{
			return aZY;
		}
		[CompilerGenerated]
		set
		{
			aZY = value;
		}
	}

	public bool Visible
	{
		[CompilerGenerated]
		get
		{
			return aZy;
		}
		[CompilerGenerated]
		set
		{
			aZy = value;
		}
	}

	public bool StdFrame
	{
		[CompilerGenerated]
		get
		{
			return aZZ;
		}
		[CompilerGenerated]
		set
		{
			aZZ = value;
		}
	}

	public uint CANId
	{
		[CompilerGenerated]
		get
		{
			return aZz;
		}
		[CompilerGenerated]
		set
		{
			aZz = value;
		}
	}

	public uint Length
	{
		[CompilerGenerated]
		get
		{
			return azA;
		}
		[CompilerGenerated]
		set
		{
			azA = value;
		}
	}

	public int Rate
	{
		[CompilerGenerated]
		get
		{
			return aza;
		}
		[CompilerGenerated]
		set
		{
			aza = value;
		}
	}

	public bool InError
	{
		[CompilerGenerated]
		get
		{
			return azB;
		}
		[CompilerGenerated]
		set
		{
			azB = value;
		}
	}

	public List<CANSignalModel> Signals
	{
		[CompilerGenerated]
		get
		{
			return azb;
		}
		[CompilerGenerated]
		set
		{
			azb = value;
		}
	}

	internal static CANFrameModel A(DN P_0, uint P_1)
	{
		int num = P_0.BZl.m((int)P_1);
		if (!IsFrameVisible((byte)num))
		{
			return null;
		}
		CANFrameModel cANFrameModel = new CANFrameModel();
		cANFrameModel.Index = P_1;
		string name = P_0.BZk.N((int)P_1);
		int canIdByte = P_0.BZL.m((int)P_1);
		int num2 = P_0.BZM.m((int)P_1);
		cANFrameModel.ParseName(name);
		cANFrameModel.ParseCanIdByte((uint)canIdByte);
		cANFrameModel.ParseTransmitRateByte((byte)num2);
		cANFrameModel.ParseEnabledLengthByte((byte)num);
		return cANFrameModel;
	}

	public virtual string ToString()
	{
		string[] obj = new string[14]
		{
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.art(),
			(Name != null) ? Name : string.Empty,
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.arU(),
			((Signals != null) ? ((object)Signals.Count) : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aru())?.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.arV(),
			Index.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.arv(),
			null,
			null,
			null,
			null,
			null,
			null,
			null
		};
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 1);
		defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dI());
		defaultInterpolatedStringHandler.AppendFormatted<uint>(CANId, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Di());
		obj[7] = defaultInterpolatedStringHandler.ToStringAndClear();
		obj[8] = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.arW();
		obj[9] = ((object)FrameDirection).ToString();
		obj[10] = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.arw();
		obj[11] = Enabled.ToString();
		obj[12] = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.arX();
		obj[13] = Visible.ToString();
		return string.Concat(obj);
	}

	public static bool IsFrameVisible(byte enabledLengthByte)
	{
		return (enabledLengthByte & 0x40) == 64;
	}

	public static bool IsFrameEnabled(byte enabledLengthByte)
	{
		return (enabledLengthByte & 0x80) == 128;
	}

	public static bool IsFrameTransmit(byte transmitRateByte)
	{
		return (transmitRateByte & 0x80) == 128;
	}

	public static bool IsFrameOneshotFlag(byte transmitRateByte)
	{
		return (transmitRateByte & 0x40) == 64;
	}

	public static bool IsFrameStdId(uint canIdByte)
	{
		return (canIdByte & 0x80000000u) != 2147483648u;
	}

	public bool IsFrameOneshotRate()
	{
		return false;
	}

	public void ParseCanIdByte(uint canIdByte)
	{
		StdFrame = IsFrameStdId(canIdByte);
		if (StdFrame)
		{
			CANId = canIdByte & 0x7FFu;
		}
		else
		{
			CANId = canIdByte & 0x1FFFFFFFu;
		}
	}

	public void ParseEnabledLengthByte(byte enabledLengthByte)
	{
		Enabled = IsFrameEnabled(enabledLengthByte);
		Visible = IsFrameVisible(enabledLengthByte);
		Length = enabledLengthByte & 0x3Fu;
	}

	public void ParseTransmitRateByte(byte transmitRateByte)
	{
		FrameDirection = (IsFrameTransmit(transmitRateByte) ? Direction.Transmit : Direction.Receive);
		Oneshot = IsFrameOneshotFlag(transmitRateByte);
		Rate = transmitRateByte & 0x3F;
	}

	public void ParseName(string name)
	{
		Name = name;
	}

	public uint GetCanIdSettingValue()
	{
		uint num = 0u;
		num |= ((!StdFrame) ? 2147483648u : 0u);
		if (StdFrame)
		{
			return num | (CANId & 0x7FFu);
		}
		return num | (CANId & 0x1FFFFFFFu);
	}

	public byte GetEnableLengthValue()
	{
		return (byte)((byte)((byte)(0u | (byte)(Enabled ? 128u : 0u)) | (byte)(Visible ? 64u : 0u)) | (byte)(Length & 0x3Fu));
	}

	public byte GetTransmitRateValue()
	{
		return (byte)((byte)((byte)(0u | (byte)((FrameDirection == Direction.Transmit) ? 128u : 0u)) | (byte)(Oneshot ? 64u : 0u)) | (byte)((uint)Rate & 0x3Fu));
	}

	internal void A(uint P_0)
	{
		if (P_0 < 64)
		{
			DataBitsInUse |= (ulong)(1L << (int)P_0);
		}
	}

	internal bool a(uint P_0)
	{
		if (P_0 < 64)
		{
			return ((DataBitsInUse >> (int)P_0) & 1) == 1;
		}
		return false;
	}

	internal void A()
	{
		DataBitsInUse = 0uL;
	}
}
