using ns0;
using ns7;

namespace ns5;

internal class Class239
{
	internal int axq;

	internal int axR;

	internal Class14 axr;

	public override bool Equals(object obj)
	{
		if (this == obj)
		{
			return true;
		}
		if (obj == null)
		{
			return false;
		}
		if (obj is Class239)
		{
			return this == obj as Class239;
		}
		return false;
	}

	public static bool operator ==(Class239 class239_0, Class239 class239_1)
	{
		if ((object)class239_0 != null && (object)class239_1 != null)
		{
			if (class239_0.axq == class239_1.axq && class239_0.axR == class239_1.axR)
			{
				return class239_0.axr == class239_1.axr;
			}
			return false;
		}
		return (object)class239_0 == class239_1;
	}

	public static bool operator !=(Class239 class239_0, Class239 class239_1)
	{
		return !(class239_0 == class239_1);
	}

	public override string ToString()
	{
		return Class333.amA() + axq + Class333.ama() + axR + Class333.smethod_79() + axr.ToString();
	}
}
