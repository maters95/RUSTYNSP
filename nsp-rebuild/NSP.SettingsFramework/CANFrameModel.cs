using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns3;
using ns7;

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

	internal static CANFrameModel smethod_0(Class255 class255_0, uint uint_0)
	{
		int num = class255_0.BZl.method_258((int)uint_0);
		if (!IsFrameVisible((byte)num))
		{
			return null;
		}
		CANFrameModel cANFrameModel = new CANFrameModel();
		cANFrameModel.Index = uint_0;
		string name = class255_0.BZk.method_261((int)uint_0);
		int canIdByte = class255_0.BZL.method_258((int)uint_0);
		int num2 = class255_0.BZM.method_258((int)uint_0);
		cANFrameModel.ParseName(name);
		cANFrameModel.ParseCanIdByte((uint)canIdByte);
		cANFrameModel.ParseTransmitRateByte((byte)num2);
		cANFrameModel.ParseEnabledLengthByte((byte)num);
		return cANFrameModel;
	}

	public override string ToString()
	{
		string[] array = new string[14]
		{
			Class333.art(),
			(Name != null) ? Name : string.Empty,
			Class333.arU(),
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null
		};
		object obj;
		if (Signals == null)
		{
			obj = Class333.aru();
			if (obj == null)
			{
				goto IL_0056;
			}
		}
		else
		{
			obj = Signals.Count;
			if (obj == null)
			{
				goto IL_0056;
			}
		}
		object obj2 = obj.ToString();
		goto IL_005f;
		IL_0056:
		obj2 = null;
		goto IL_005f;
		IL_005f:
		array[3] = (string)obj2;
		array[4] = Class333.arV();
		array[5] = Index.ToString();
		array[6] = Class333.arv();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
		defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_381());
		defaultInterpolatedStringHandler.AppendFormatted(CANId, Class333.smethod_330());
		array[7] = defaultInterpolatedStringHandler.ToStringAndClear();
		array[8] = Class333.arW();
		array[9] = FrameDirection.ToString();
		array[10] = Class333.arw();
		array[11] = Enabled.ToString();
		array[12] = Class333.arX();
		array[13] = Visible.ToString();
		return string.Concat(array);
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
			CANId = canIdByte & 0x7FF;
		}
		else
		{
			CANId = canIdByte & 0x1FFFFFFF;
		}
	}

	public void ParseEnabledLengthByte(byte enabledLengthByte)
	{
		Enabled = IsFrameEnabled(enabledLengthByte);
		Visible = IsFrameVisible(enabledLengthByte);
		Length = (uint)(enabledLengthByte & 0x3F);
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
		num = (uint)(0 | ((!StdFrame) ? int.MinValue : 0));
		if (StdFrame)
		{
			return num | (CANId & 0x7FF);
		}
		return num | (CANId & 0x1FFFFFFF);
	}

	public byte GetEnableLengthValue()
	{
		return (byte)((byte)((byte)(0 | (byte)(Enabled ? 128 : 0)) | (byte)(Visible ? 64 : 0)) | (byte)(Length & 0x3F));
	}

	public byte GetTransmitRateValue()
	{
		return (byte)((byte)((byte)(0 | (byte)((FrameDirection == Direction.Transmit) ? 128 : 0)) | (byte)(Oneshot ? 64 : 0)) | (byte)(Rate & 0x3F));
	}

	internal void method_0(uint uint_0)
	{
		if (uint_0 < 64)
		{
			DataBitsInUse |= (ulong)(1L << (int)uint_0);
		}
	}

	internal bool method_1(uint uint_0)
	{
		if (uint_0 < 64)
		{
			return ((DataBitsInUse >> (int)uint_0) & 1L) == 1L;
		}
		return false;
	}

	internal void method_2()
	{
		DataBitsInUse = 0uL;
	}
}
