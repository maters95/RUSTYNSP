using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using ns2;
using ns4;

namespace ns1;

internal class Class140 : Class139
{
	private int BNr;

	private Class139 BNS;

	private int BNs;

	private Class81 BNT;

	internal static int BNt = 420;

	private const int BNU = 2;

	private const int BNu = 3;

	internal Class140(int int_2, int int_3, int int_4, int int_5, int int_6, int int_7)
		: base(int_6, int_7)
	{
		BNr = int_2;
		int num = int_6 / BNr;
		int num2 = (int)((double)num * 0.7);
		BNs = num - num2;
		BNS = new Class139(num2, int_7 - 4 + 1);
		BNT = new Class81(int_2, int_4, int_5, int_3);
	}

	internal Class140(int int_2, int[] int_3, int int_4, int int_5, int int_6)
		: base(int_5, int_6)
	{
		BNr = int_2;
		int num = int_5 / BNr;
		int num2 = (int)((double)num * 0.7);
		BNs = num - num2;
		BNS = new Class139(num2, int_6 - 4 + 1);
		BNT = new Class81(int_2, int_3, int_4);
	}

	internal Bitmap method_4(Enum42 enum42_0)
	{
		Bitmap bitmap = new Bitmap(BNr * (BNS.method_2() + BNs) + BNs, BNS.method_0(), PixelFormat.Format24bppRgb);
		using Graphics graphics = Graphics.FromImage(bitmap);
		using (SolidBrush brush = new SolidBrush(Form23.color_10))
		{
			graphics.FillRectangle(brush, new Rectangle(0, 0, BNr * (BNS.method_2() + BNs) + BNs, BNS.method_0()));
		}
		int height = BNS.method_0() - 6;
		for (int i = 0; i < BNr; i++)
		{
			int x = BNs + i * (BNS.method_2() + BNs);
			Color color = ((enum42_0 != Enum42.const_0 || !BNT.method_2()) ? BNT.method_10(i) : Class80.smethod_0(0));
			using SolidBrush brush2 = new SolidBrush(color);
			graphics.FillRectangle(brush2, new Rectangle(x, 3, BNS.method_2(), height));
		}
		return bitmap;
	}

	[SpecialName]
	internal bool method_5()
	{
		return BNT.method_2();
	}
}
