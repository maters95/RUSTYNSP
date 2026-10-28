using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ns0;

internal class Class28
{
	private struct Struct7
	{
		public int BgU;

		public int Bgu;

		public int BgV;

		public int Bgv;
	}

	private enum Enum19
	{
		BgW = 10,
		Bgw = 117
	}

	public static void smethod_0(string string_0, ImageFormat imageFormat_0, nint intptr_0)
	{
		Rectangle rectangle = smethod_1(intptr_0);
		using Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
		}
		bitmap.Save(string_0, imageFormat_0);
	}

	private static Rectangle smethod_1(nint intptr_0)
	{
		GetWindowRect(intptr_0, out var struct7_);
		float num = smethod_2();
		return new Rectangle((int)Math.Round((float)(struct7_.BgU + 8) * num), (int)Math.Round((float)struct7_.Bgu * num), (int)Math.Round((float)(struct7_.BgV - struct7_.BgU - 16) * num), (int)Math.Round((float)(struct7_.Bgv - struct7_.Bgu - 8) * num));
	}

	[DllImport("user32.dll")]
	private static extern bool GetWindowRect(nint intptr_0, out Struct7 struct7_0);

	[DllImport("user32.dll")]
	private static extern int GetDpiForWindow(nint intptr_0);

	[DllImport("gdi32.dll")]
	private static extern int GetDeviceCaps(nint intptr_0, int int_0);

	private static float smethod_2()
	{
		using Graphics graphics = Graphics.FromHwnd(IntPtr.Zero);
		nint hdc = graphics.GetHdc();
		int deviceCaps = GetDeviceCaps(hdc, 10);
		int deviceCaps2 = GetDeviceCaps(hdc, 117);
		graphics.ReleaseHdc(hdc);
		return (float)deviceCaps2 / (float)deviceCaps;
	}
}
