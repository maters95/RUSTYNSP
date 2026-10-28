using System.Collections.Generic;
using NSP.UnitConversion;
using ns7;

namespace ns5;

internal class Class231
{
	internal class Class232
	{
		internal int BRX;

		internal double BRx;

		internal string BRY;

		internal string BRy;

		internal string BRZ;

		internal string BRz;

		internal Class232(int int_0, double double_0, string string_0)
		{
			BRX = int_0;
			BRx = double_0;
			BRY = string_0;
			BRy = string_0 + Class333.acw();
			BRZ = string_0 + Class333.acX();
			BRz = string_0 + Class333.acx();
		}

		internal Class232(int int_0, double double_0, string string_0, string string_1, string string_2, string string_3)
		{
			BRX = int_0;
			BRx = double_0;
			BRY = string_0;
			BRy = string_1;
			BRZ = string_2;
			BRz = string_3;
		}
	}

	internal UnitType abq;

	internal UnitsGroup abR;

	internal int abr;

	internal string abS;

	internal string abs;

	internal string abT;

	internal string abt;

	internal string abU;

	internal int abu = 100;

	internal int abV = 10;

	internal int abv = 1;

	internal int abW;

	internal List<Class232> abw = new List<Class232>(2);

	internal Class231(UnitType unitType_0, UnitsGroup unitsGroup_0, int int_0, string string_0, string string_1)
	{
		abq = unitType_0;
		abR = unitsGroup_0;
		abr = int_0;
		abS = string_0;
		abs = string_1;
		abT = string_1 + Class333.acw();
		abt = string_1 + Class333.acX();
		abU = string_1 + Class333.acx();
	}

	internal Class231(UnitType unitType_0, UnitsGroup unitsGroup_0, int int_0, string string_0, string string_1, string string_2, string string_3, string string_4)
	{
		abq = unitType_0;
		abR = unitsGroup_0;
		abr = int_0;
		abS = string_0;
		abs = string_1;
		abT = string_2;
		abt = string_3;
		abU = string_4;
	}
}
