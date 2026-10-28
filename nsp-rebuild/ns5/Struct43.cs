namespace ns5;

internal struct Struct43
{
	internal int axU;

	internal int axu;

	internal Struct43(int int_0, int int_1)
	{
		axU = int_0;
		axu = int_1;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		Struct43 @struct = (Struct43)obj;
		if (@struct.axU == axU)
		{
			return @struct.axu == axu;
		}
		return false;
	}

	public static bool operator ==(Struct43 struct43_0, Struct43 struct43_1)
	{
		return struct43_0.Equals(struct43_1);
	}

	public static bool operator !=(Struct43 struct43_0, Struct43 struct43_1)
	{
		return !struct43_0.Equals(struct43_1);
	}

	public override int GetHashCode()
	{
		return (axU << 8) | axu;
	}
}
