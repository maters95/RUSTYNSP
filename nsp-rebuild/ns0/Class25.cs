using System.Drawing;
using System.Drawing.Imaging;

namespace ns0;

internal static class Class25
{
	internal static Bitmap smethod_0(Image image_0, float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, float float_6, float float_7)
	{
		Bitmap bitmap = new Bitmap(image_0.Width, image_0.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		ColorMatrix newColorMatrix = new ColorMatrix(new float[5][]
		{
			new float[5] { float_1, 0f, 0f, 0f, 0f },
			new float[5] { 0f, float_2, 0f, 0f, 0f },
			new float[5] { 0f, 0f, float_3, 0f, 0f },
			new float[5] { 0f, 0f, 0f, float_0, 0f },
			new float[5] { float_5, float_6, float_7, float_4, 1f }
		});
		ImageAttributes imageAttributes = new ImageAttributes();
		imageAttributes.SetColorMatrix(newColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
		graphics.DrawImage(image_0, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, image_0.Width, image_0.Height, GraphicsUnit.Pixel, imageAttributes);
		graphics.Dispose();
		imageAttributes.Dispose();
		return bitmap;
	}

	internal static Size smethod_1(Size size_0, Size size_1)
	{
		int width;
		int height;
		if (size_0.Width > size_1.Width && size_0.Height > size_1.Height)
		{
			if ((float)size_0.Width / (float)size_1.Width > (float)size_0.Height / (float)size_1.Height)
			{
				width = size_1.Width;
				height = size_1.Width * size_0.Height / size_0.Width;
			}
			else
			{
				height = size_1.Height;
				width = size_1.Height * size_0.Width / size_0.Height;
			}
		}
		else if (size_0.Width > size_1.Width)
		{
			width = size_1.Width;
			height = size_1.Width * size_0.Height / size_0.Width;
		}
		else if (size_0.Height > size_1.Height)
		{
			height = size_1.Height;
			width = size_1.Height * size_0.Width / size_0.Height;
		}
		else
		{
			width = size_0.Width;
			height = size_0.Height;
		}
		return new Size(width, height);
	}
}
