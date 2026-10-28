using NSP.SettingsFramework;

namespace ns6;

internal class Class275
{
	private Framework BbK;

	private Setting Bbk;

	private Setting BbL;

	private Setting Bbl;

	private Setting BbM;

	private Setting Bbm;

	private Setting BbN;

	private Setting Bbn;

	private Setting BbO;

	private Setting Bbo;

	internal Class275(Framework framework_0)
	{
		BbK = framework_0;
	}

	internal void method_0()
	{
		Bbk = BbK.method_31(15171);
		BbL = BbK.method_31(15172);
		Bbl = BbK.method_31(15181);
		BbM = BbK.method_31(15182);
		Bbm = BbK.method_31(15254);
		BbN = BbK.method_31(15255);
		Bbn = BbK.method_31(15256);
		BbO = BbK.method_31(15257);
		Bbo = BbK.method_31(15258);
	}

	internal void method_1(int int_0)
	{
		method_2(int_0)?.method_272(0, bool_0: true);
		method_3(int_0)?.method_272(0, bool_0: true);
		method_4(int_0)?.method_272(0, bool_0: true);
	}

	internal Setting method_2(int int_0)
	{
		Setting result = null;
		switch (int_0)
		{
		case 6447:
			result = Bbk;
			break;
		case 8279:
			result = BbM;
			break;
		case 6437:
			result = Bbn;
			break;
		}
		return result;
	}

	internal Setting method_3(int int_0)
	{
		Setting result = null;
		switch (int_0)
		{
		case 6447:
			result = BbL;
			break;
		case 8279:
			result = Bbm;
			break;
		case 6437:
			result = BbO;
			break;
		}
		return result;
	}

	internal Setting method_4(int int_0)
	{
		Setting result = null;
		switch (int_0)
		{
		case 6447:
			result = Bbl;
			break;
		case 8279:
			result = BbN;
			break;
		case 6437:
			result = Bbo;
			break;
		}
		return result;
	}
}
