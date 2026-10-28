using System;
using System.Drawing;

namespace ns0;

internal static class Class18
{
	internal static Color smethod_0(int int_0, int int_1, int int_2)
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = (double)int_0 / 255.0 * 360.0 % 360.0;
		double num5 = (double)int_1 / 255.0;
		double num6 = (double)int_2 / 255.0;
		if (num5 == 0.0)
		{
			num = num6;
			num2 = num6;
			num3 = num6;
		}
		else
		{
			double num7 = num4 / 60.0;
			int num8 = (int)Math.Floor(num7);
			double num9 = num7 - (double)num8;
			double num10 = num6 * (1.0 - num5);
			double num11 = num6 * (1.0 - num5 * num9);
			double num12 = num6 * (1.0 - num5 * (1.0 - num9));
			switch (num8)
			{
			case 0:
				num = num6;
				num2 = num12;
				num3 = num10;
				break;
			case 1:
				num = num11;
				num2 = num6;
				num3 = num10;
				break;
			case 2:
				num = num10;
				num2 = num6;
				num3 = num12;
				break;
			case 3:
				num = num10;
				num2 = num11;
				num3 = num6;
				break;
			case 4:
				num = num12;
				num2 = num10;
				num3 = num6;
				break;
			case 5:
				num = num6;
				num2 = num10;
				num3 = num11;
				break;
			}
		}
		return Color.FromArgb((int)(num * 255.0), (int)(num2 * 255.0), (int)(num3 * 255.0));
	}
}
