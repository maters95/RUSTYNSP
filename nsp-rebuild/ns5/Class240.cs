using ns0;
using ns7;

namespace ns5;

internal class Class240
{
	internal int axS;

	internal int axs;

	internal Class14 axT;

	internal byte[] axt;

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
		if (obj is Class240)
		{
			return this == obj as Class240;
		}
		return false;
	}

	public static bool operator ==(Class240 class240_0, Class240 class240_1)
	{
		if ((object)class240_0 != null && (object)class240_1 != null)
		{
			if (class240_0.axS == class240_1.axS && class240_0.axs == class240_1.axs && class240_0.axT == class240_1.axT)
			{
				if (class240_0.axt != null && class240_1.axt != null)
				{
					return Class24.smethod_0(class240_0.axt) == Class24.smethod_0(class240_1.axt);
				}
				return class240_0.axt == null == (class240_1.axt == null);
			}
			return false;
		}
		return (object)class240_0 == class240_1;
	}

	public static bool operator !=(Class240 class240_0, Class240 class240_1)
	{
		return !(class240_0 == class240_1);
	}

	public override string ToString()
	{
		return Class333.amA() + axS + Class333.ama() + axs + Class333.smethod_79() + axT.ToString() + ((axt != null) ? (Class333.amB() + Class24.smethod_0(axt)) : string.Empty);
	}
}
