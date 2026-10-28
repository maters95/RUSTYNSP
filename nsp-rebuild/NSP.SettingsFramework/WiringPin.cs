using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns0;
using ns4;
using ns6;
using ns7;

namespace NSP.SettingsFramework;

public class WiringPin
{
	internal class Class276
	{
		internal Enum104 Bsk;

		internal Enum105 BsL;

		internal byte Bsl;

		internal ushort BsM;

		internal int Bsm;

		internal Class276(uint uint_0, int int_0)
		{
			Bsk = PortFunction.smethod_12(uint_0);
			BsL = PortFunction.smethod_13(uint_0);
			Bsl = PortFunction.smethod_14(uint_0);
			BsM = PortFunction.smethod_15(uint_0);
			Bsm = int_0;
		}
	}

	internal class Class277
	{
		internal string BsN;

		internal int Bsn;

		internal Class277(string string_0, int int_0)
		{
			BsN = string_0;
			Bsn = int_0;
		}
	}

	internal const int BbP = 100;

	internal const int Bbp = 23;

	internal Framework BbQ;

	internal SpecialObject Bbq;

	internal string BbR = string.Empty;

	internal string Bbr = string.Empty;

	internal string BbS = string.Empty;

	internal string Bbs = string.Empty;

	internal int BbT = -1;

	internal bool Bbt;

	internal string BbU = string.Empty;

	internal string Bbu = string.Empty;

	internal int BbV;

	internal bool Bbv;

	internal Point BbW;

	internal Point Bbw;

	internal Size BbX;

	internal int Bbx = -1;

	internal int BbY = -1;

	private List<Class277> Bby = new List<Class277>();

	private Class277 BbZ;

	private List<Class276> Bbz = new List<Class276>();

	private List<Class276> BCA = new List<Class276>();

	internal static Image BCa;

	internal static Image BCB;

	internal static Image BCb;

	internal static Image BCC;

	internal static Image BCc;

	internal static Image BCD;

	internal static string[] BCd = new string[14]
	{
		Class333.smethod_2242(),
		Class333.aTY(),
		Class333.smethod_1329(),
		Class333.aGi(),
		Class333.smethod_1310(),
		Class333.ahq(),
		Class333.aTy(),
		Class333.smethod_1308(),
		Class333.smethod_1039(),
		Class333.aTv(),
		Class333.aTw(),
		Class333.aTX(),
		Class333.aTx(),
		Class333.aTW()
	};

	public WiringPin(Framework framework, SpecialObject ownerObject)
	{
		BbQ = framework;
		Bbq = ownerObject;
	}

	public override string ToString()
	{
		return BbR;
	}

	internal bool method_0()
	{
		if (BbW.X == 0)
		{
			return BbW.Y != 0;
		}
		return true;
	}

	internal bool method_1()
	{
		if (Bbw.X == 0)
		{
			return Bbw.Y != 0;
		}
		return true;
	}

	internal void method_2(uint uint_0, int int_0)
	{
		Class276 item = new Class276(uint_0, int_0);
		Bbz.Add(item);
	}

	internal List<Class276> method_3()
	{
		return Bbz;
	}

	internal List<Class276> method_4()
	{
		return BCA;
	}

	internal void method_5(string string_0, int int_0)
	{
		Class277 item = new Class277(string_0, int_0);
		Bby.Add(item);
	}

	internal List<Class277> method_6()
	{
		return Bby;
	}

	internal Class277 method_7()
	{
		return BbZ;
	}

	internal void method_8()
	{
		BCA.Clear();
		for (int i = 0; i < Bbz.Count; i++)
		{
			Class276 @class = Bbz[i];
			if (@class.Bsm == -1)
			{
				BCA.Add(@class);
			}
		}
		BbZ = null;
		for (int j = 0; j < Bby.Count; j++)
		{
			Class277 class2 = Bby[j];
			if (class2.Bsn == -1)
			{
				BbZ = class2;
			}
		}
	}

	internal void method_9(int int_0)
	{
		for (int i = 0; i < Bbz.Count; i++)
		{
			Class276 @class = Bbz[i];
			if (@class.Bsm == int_0)
			{
				BCA.Add(@class);
			}
		}
		for (int j = 0; j < Bby.Count; j++)
		{
			Class277 class2 = Bby[j];
			if (class2.Bsn == int_0)
			{
				BbZ = class2;
			}
		}
	}

	internal static List<WiringPin> smethod_0(Framework framework_0, Enum104 enum104_0, Enum105 enum105_0, byte byte_0, ushort ushort_0)
	{
		List<WiringPin> list = new List<WiringPin>();
		foreach (WiringPin item in framework_0.awc)
		{
			if (!item.Bbq.method_35())
			{
				continue;
			}
			foreach (Class276 item2 in item.method_4())
			{
				if (enum104_0 == Enum104.BAM)
				{
					if (item2.Bsk == enum104_0 && item2.BsL == enum105_0 && item2.BsM == ushort_0)
					{
						list.Add(item);
					}
				}
				else if (item2.Bsk == enum104_0 && item2.BsL == enum105_0 && item2.Bsl == byte_0)
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	internal static void smethod_1(float float_0, float float_1, float float_2)
	{
		if (BCa != null)
		{
			BCa.Dispose();
		}
		BCa = Class25.smethod_0(Class281.smethod_17(), 1f, 0f, 0f, 0f, 0f, float_0, float_1, float_2);
		if (BCB != null)
		{
			BCB.Dispose();
		}
		BCB = Class25.smethod_0(Class281.smethod_15(), 1f, 0f, 0f, 0f, 0f, float_0, float_1, float_2);
		if (BCb != null)
		{
			BCb.Dispose();
		}
		BCb = Class25.smethod_0(Class281.smethod_10(), 1f, 0f, 0f, 0f, 0f, float_0, float_1, float_2);
		if (BCC != null)
		{
			BCC.Dispose();
		}
		BCC = Class25.smethod_0(Class281.smethod_6(), 1f, 0f, 0f, 0f, 0f, float_0, float_1, float_2);
		if (BCc != null)
		{
			BCc.Dispose();
		}
		BCc = Class25.smethod_0(Class281.smethod_7(), 1f, 0f, 0f, 0f, 0f, float_0, float_1, float_2);
		if (BCD != null)
		{
			BCD.Dispose();
		}
		BCD = Class25.smethod_0(Class281.smethod_5(), 1f, 0f, 0f, 0f, 0f, float_0, float_1, float_2);
	}

	internal Image method_10()
	{
		using (List<Class276>.Enumerator enumerator = method_4().GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				Class276 current = enumerator.Current;
				if ((current.Bsk == Enum104.BAf || current.Bsk == Enum104.BAF || current.Bsk == Enum104.BAh || current.Bsk == Enum104.BAI || current.Bsk == Enum104.BAi) && current.BsL == Enum105.Baj)
				{
					return BCa;
				}
				if ((current.Bsk == Enum104.BAE || current.Bsk == Enum104.BAe || current.Bsk == Enum104.BAD || current.Bsk == Enum104.BAd || current.Bsk == Enum104.BAj) && current.BsL == Enum105.BaJ)
				{
					return BCB;
				}
				if (current.Bsk == Enum104.BAb && current.BsL == Enum105.Bai && current.Bsl == 0)
				{
					return BCb;
				}
				if (current.Bsk == Enum104.BAb && current.BsL == Enum105.Bak)
				{
					return BCD;
				}
				if ((current.Bsk == Enum104.BAb || current.Bsk == Enum104.BAr) && current.BsL == Enum105.BaE)
				{
					Bitmap bitmap = null;
					Image image = null;
					switch (current.Bsl)
					{
					case 0:
						image = Class281.smethod_16();
						break;
					case 1:
						image = Class281.smethod_4();
						break;
					case 2:
						image = Class281.smethod_2();
						break;
					case 3:
						image = Class281.smethod_12();
						break;
					case 4:
						image = Class281.smethod_11();
						break;
					case 5:
						image = Class281.smethod_1();
						break;
					}
					if (image != null)
					{
						bitmap = new Bitmap(Math.Max(image.Width, 100), image.Height);
						Graphics graphics = Graphics.FromImage(bitmap);
						graphics.DrawImage(image, (image.Width < 100) ? ((100 - image.Width) / 2) : 0, 0);
						graphics.Dispose();
					}
					if (bitmap != null)
					{
						return bitmap;
					}
					return null;
				}
				if (current.Bsk == Enum104.BAM)
				{
					Bitmap bitmap2 = new Bitmap(100, 25);
					Graphics graphics2 = Graphics.FromImage(bitmap2);
					using (SolidBrush brush = new SolidBrush(Color.FromArgb((int)(Form23.float_4 * 255f), (int)(Form23.float_5 * 255f), (int)(Form23.float_6 * 255f))))
					{
						using Font font = new Font(Control.DefaultFont.FontFamily, 13f, FontStyle.Bold);
						graphics2.DrawString(Class333.smethod_814(), font, brush, 17f, 0f);
					}
					graphics2.Dispose();
					return bitmap2;
				}
				if (current.Bsk == Enum104.BAb && current.BsL == Enum105.Bag)
				{
					Bitmap bitmap3 = new Bitmap(100, 60);
					Graphics graphics3 = Graphics.FromImage(bitmap3);
					using (SolidBrush brush2 = new SolidBrush(Color.FromArgb((int)(Form23.float_4 * 255f), (int)(Form23.float_5 * 255f), (int)(Form23.float_6 * 255f))))
					{
						using (Font font2 = new Font(Control.DefaultFont.FontFamily, 10f, FontStyle.Bold))
						{
							graphics3.DrawString(Class333.aTq(), font2, brush2, 1f, 3f);
						}
						using Font font3 = new Font(Control.DefaultFont.FontFamily, 8f);
						graphics3.DrawString(Class333.aTR(), font3, brush2, 17f, 23f);
						graphics3.DrawString(Class333.aTr(), font3, brush2, 17f, 40f);
					}
					graphics3.Dispose();
					return bitmap3;
				}
				if ((current.Bsk == Enum104.BAK || current.Bsk == Enum104.BAk || current.Bsk == Enum104.BAL || current.Bsk == Enum104.BAl) && current.BsL == Enum105.BaE)
				{
					Bitmap bitmap4 = null;
					if (current.Bsk != Enum104.BAK && current.Bsk != Enum104.BAk)
					{
						if (current.Bsk == Enum104.BAL || current.Bsk == Enum104.BAl)
						{
							bitmap4 = new Bitmap(Math.Max(BCc.Width, 100), BCc.Height);
							Graphics graphics4 = Graphics.FromImage(bitmap4);
							int num = ((BCc.Width < 100) ? ((100 - BCc.Width) / 2) : 0);
							graphics4.DrawImage(BCc, num, 0);
							if (current.Bsl < 5)
							{
								graphics4.FillRectangle(Brushes.DodgerBlue, num + 8 + current.Bsl * 13, 11, 12, 18);
							}
							else if (current.Bsl < 10)
							{
								graphics4.FillRectangle(Brushes.DodgerBlue, num + 8 + (current.Bsl - 5) * 13, 31, 12, 18);
							}
							else
							{
								graphics4.FillRectangle(Brushes.DodgerBlue, num + 8 + (current.Bsl - 10) * 13, 51, 12, 18);
							}
							graphics4.Dispose();
						}
					}
					else
					{
						bitmap4 = new Bitmap(Math.Max(BCC.Width, 100), BCC.Height);
						Graphics graphics5 = Graphics.FromImage(bitmap4);
						int num2 = ((BCC.Width < 100) ? ((100 - BCC.Width) / 2) : 0);
						graphics5.DrawImage(BCC, num2, 0);
						if (current.Bsl < 4)
						{
							graphics5.FillRectangle(Brushes.DodgerBlue, num2 + 11 + current.Bsl * 15, 16, 14, 23);
						}
						else
						{
							graphics5.FillRectangle(Brushes.DodgerBlue, num2 + 11 + (current.Bsl - 4) * 15, 41, 14, 23);
						}
						graphics5.Dispose();
					}
					if (bitmap4 != null)
					{
						return bitmap4;
					}
					return null;
				}
				if (current.BsL == Enum105.BaN && BbU == Class333.aTS())
				{
					return Class281.smethod_14();
				}
				if (current.BsL == Enum105.BaN && BbU == Class333.aTs())
				{
					return Class281.smethod_13();
				}
				if (current.BsL == Enum105.BaN && BbU == Class333.aTT())
				{
					return Class281.smethod_9();
				}
				if (current.BsL == Enum105.BaN && BbU == Class333.aTt())
				{
					return Class281.smethod_8();
				}
				return smethod_3(method_14(), method_15(), Bbt, BbU == Class333.smethod_883() || BbU == Class333.aTU() || current.Bsk == Enum104.BAJ, bool_2: false);
			}
		}
		return null;
	}

	internal string method_11(bool bool_0)
	{
		using (List<Class276>.Enumerator enumerator = method_4().GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				Class276 current = enumerator.Current;
				if ((current.Bsk == Enum104.BAf || current.Bsk == Enum104.BAF || current.Bsk == Enum104.BAh || current.Bsk == Enum104.BAI || current.Bsk == Enum104.BAi) && current.BsL == Enum105.Baj)
				{
					return string.Empty;
				}
				if ((current.Bsk == Enum104.BAE || current.Bsk == Enum104.BAe || current.Bsk == Enum104.BAD || current.Bsk == Enum104.BAd || current.Bsk == Enum104.BAj) && current.BsL == Enum105.BaJ)
				{
					return string.Empty;
				}
				if (current.Bsk == Enum104.BAb && current.BsL == Enum105.Bai && current.Bsl == 0)
				{
					return string.Empty;
				}
				if (current.Bsk == Enum104.BAb && current.BsL == Enum105.Bak)
				{
					return string.Empty;
				}
				if ((current.Bsk == Enum104.BAb || current.Bsk == Enum104.BAr) && current.BsL == Enum105.BaE)
				{
					return string.Empty;
				}
				if (current.Bsk == Enum104.BAM)
				{
					return string.Empty;
				}
				if (current.Bsk == Enum104.BAb && current.BsL == Enum105.Bag)
				{
					return string.Empty;
				}
				if ((current.Bsk == Enum104.BAK || current.Bsk == Enum104.BAk || current.Bsk == Enum104.BAL || current.Bsk == Enum104.BAl) && current.BsL == Enum105.BaE)
				{
					return string.Empty;
				}
				if (current.BsL == Enum105.BaN && BbU == Class333.aTS())
				{
					return string.Empty;
				}
				if (current.BsL == Enum105.BaN && BbU == Class333.aTs())
				{
					return string.Empty;
				}
				if (current.BsL == Enum105.BaN && BbU == Class333.aTT())
				{
					return string.Empty;
				}
				if (current.BsL == Enum105.BaN && BbU == Class333.aTt())
				{
					return string.Empty;
				}
				string text = string.Empty;
				string text2 = method_16();
				if (!string.IsNullOrEmpty(text2))
				{
					text = text + Class333.aTu() + text2;
					string text3 = method_17();
					if (!string.IsNullOrEmpty(text3) && text3 != text2)
					{
						text = text + Class333.smethod_177() + text3;
					}
					text += Class333.aTV();
				}
				if (!string.IsNullOrEmpty(Bbs))
				{
					if (text.Length != 0)
					{
						text += Class333.aMY();
					}
					text += Bbs;
				}
				if (bool_0 && !string.IsNullOrEmpty(BbR))
				{
					if (text.Length != 0)
					{
						text += Class333.aMY();
					}
					text += BbR;
				}
				return text;
			}
		}
		return string.Empty;
	}

	internal string method_12()
	{
		if (method_7() != null)
		{
			return method_7().BsN;
		}
		return null;
	}

	internal static Bitmap smethod_2(int int_0, int int_1, Color color_0, Color color_1, bool bool_0, bool bool_1, bool bool_2)
	{
		Bitmap bitmap = new Bitmap(int_0 + 1, int_1 + 1);
		Graphics graphics = Graphics.FromImage(bitmap);
		graphics.Clear(Color.Transparent);
		if (bool_2)
		{
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			using (Pen pen = new Pen(Color.Black, 2f))
			{
				graphics.DrawLine(pen, 2, 2, int_0 - 2, int_1 - 2);
				graphics.DrawLine(pen, 2, int_1 - 2, int_0 - 2, 2);
			}
			graphics.DrawEllipse(Pens.Black, 0, 0, int_0, int_1);
		}
		else if (bool_1)
		{
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.DrawEllipse(Pens.Black, 0, 0, int_0, int_1);
		}
		else if (color_0 != Color.Transparent)
		{
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			using (Brush brush = new SolidBrush(color_0))
			{
				graphics.FillEllipse(brush, 0, 0, int_0, int_1);
			}
			if (color_1 != Color.Transparent && color_1 != color_0)
			{
				using Pen pen2 = new Pen(color_1, 3f);
				graphics.SmoothingMode = SmoothingMode.None;
				graphics.DrawLine(pen2, int_0 / 2, 0, int_0 / 2, int_1);
			}
			if (bool_0)
			{
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.DrawEllipse(Pens.Silver, 1, 1, int_0 - 2, int_1 - 2);
			}
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.DrawEllipse(Pens.Black, 0, 0, int_0, int_1);
		}
		graphics.Dispose();
		return bitmap;
	}

	internal static Bitmap smethod_3(Color color_0, Color color_1, bool bool_0, bool bool_1, bool bool_2)
	{
		Bitmap bitmap = new Bitmap(100, 22);
		Graphics graphics = Graphics.FromImage(bitmap);
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		if (bool_1)
		{
			graphics.FillRectangle(Brushes.Black, 37, 1, 56, 19);
			graphics.FillEllipse(Brushes.Black, 31, 1, 14, 19);
			graphics.FillEllipse(Brushes.Black, 86, 1, 14, 19);
			using Font font = new Font(Control.DefaultFont.FontFamily, 12f, FontStyle.Bold);
			using StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			graphics.DrawString(Class333.smethod_883(), font, Brushes.White, 70f, 12f, stringFormat);
		}
		else if (bool_2)
		{
			graphics.FillRectangle(Brushes.White, 37, 1, 56, 19);
			graphics.FillEllipse(Brushes.White, 31, 1, 14, 19);
			graphics.FillEllipse(Brushes.White, 86, 1, 14, 19);
			using Font font2 = new Font(Control.DefaultFont.FontFamily, 16f, FontStyle.Bold);
			using StringFormat stringFormat2 = new StringFormat();
			stringFormat2.Alignment = StringAlignment.Center;
			stringFormat2.LineAlignment = StringAlignment.Center;
			graphics.DrawString(Class333.smethod_1798(), font2, Brushes.Red, 70f, 11f, stringFormat2);
		}
		else
		{
			using Brush brush = new SolidBrush(color_0);
			graphics.FillRectangle(brush, 37, 1, 56, 19);
			graphics.FillEllipse(brush, 31, 1, 14, 19);
			graphics.FillEllipse(brush, 86, 1, 14, 19);
		}
		graphics.DrawLine(Pens.DimGray, 37, 1, 93, 1);
		graphics.DrawLine(Pens.DimGray, 37, 20, 93, 20);
		graphics.DrawEllipse(Pens.DimGray, new Rectangle(31, 1, 14, 19));
		graphics.DrawArc(Pens.DimGray, new Rectangle(85, 1, 14, 19), 270f, 180f);
		if (color_0 != Color.Transparent && color_1 != Color.Transparent && color_1 != color_0 && !bool_1 && !bool_2)
		{
			Rectangle rect = new Rectangle(0, 2, 100, 18);
			graphics.SetClip(rect, CombineMode.Replace);
			using (Pen pen = new Pen(color_1, 12f))
			{
				graphics.DrawArc(pen, new Rectangle(-40, -62, 112, 112), 5f, 27f);
			}
			graphics.DrawArc(Pens.DimGray, new Rectangle(-46, -62, 112, 112), 5f, 27f);
			graphics.DrawArc(Pens.DimGray, new Rectangle(-34, -62, 112, 112), 5f, 27f);
			graphics.ResetClip();
		}
		if (bool_0)
		{
			graphics.FillRectangle(Brushes.Silver, 18, 3, 19, 15);
			graphics.FillEllipse(Brushes.Silver, 15, 3, 9, 15);
			graphics.FillEllipse(Brushes.Silver, 33, 3, 9, 15);
			graphics.DrawLine(Pens.Black, 20, 3, 37, 3);
			graphics.DrawLine(Pens.Black, 20, 18, 37, 18);
			graphics.DrawEllipse(Pens.Black, new Rectangle(15, 3, 9, 15));
			graphics.DrawArc(Pens.Black, new Rectangle(33, 3, 9, 15), 270f, 180f);
			graphics.FillRectangle(Brushes.SandyBrown, 4, 4, 14, 13);
			graphics.FillEllipse(Brushes.SandyBrown, 0, 4, 9, 13);
			graphics.FillEllipse(Brushes.SandyBrown, 15, 4, 9, 13);
			graphics.DrawLine(Pens.Black, 4, 4, 19, 4);
			graphics.DrawLine(Pens.Black, 4, 17, 19, 17);
			graphics.DrawEllipse(Pens.Black, new Rectangle(0, 4, 9, 13));
			graphics.DrawArc(Pens.Black, new Rectangle(15, 4, 9, 13), 270f, 180f);
		}
		else
		{
			if (bool_2)
			{
				graphics.FillRectangle(Brushes.White, 4, 4, 31, 13);
				graphics.FillEllipse(Brushes.White, 0, 4, 9, 13);
				graphics.FillEllipse(Brushes.White, 32, 4, 9, 13);
			}
			else
			{
				graphics.FillRectangle(Brushes.SandyBrown, 4, 4, 31, 13);
				graphics.FillEllipse(Brushes.SandyBrown, 0, 4, 9, 13);
				graphics.FillEllipse(Brushes.SandyBrown, 32, 4, 9, 13);
			}
			graphics.DrawLine(Pens.Black, 4, 4, 36, 4);
			graphics.DrawLine(Pens.Black, 4, 17, 36, 17);
			graphics.DrawEllipse(Pens.Black, new Rectangle(0, 4, 9, 13));
			graphics.DrawArc(Pens.Black, new Rectangle(32, 4, 9, 13), 270f, 180f);
		}
		graphics.Dispose();
		return bitmap;
	}

	internal static Color smethod_4(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0) && string_0 != null)
		{
			switch (string_0.Length)
			{
			case 2:
				switch (string_0[1])
				{
				case 'L':
					if (string_0 == Class333.aTX())
					{
						return Color.LightBlue;
					}
					break;
				case 'G':
					if (string_0 == Class333.aTx())
					{
						return Color.LightGreen;
					}
					break;
				case 'Y':
					if (!(string_0 == Class333.aTv()))
					{
						if (string_0 == Class333.aTW())
						{
							return Color.Khaki;
						}
						break;
					}
					return Color.Gray;
				case 'R':
					if (string_0 == Class333.aTw())
					{
						return Color.SaddleBrown;
					}
					break;
				}
				break;
			case 1:
				switch (string_0[0])
				{
				case 'G':
					return Color.Green;
				case 'B':
					return Color.Black;
				case 'V':
					return Color.Purple;
				case 'W':
					return Color.White;
				case 'Y':
					return Color.Yellow;
				case 'L':
					return Color.MediumBlue;
				case 'O':
					return Color.DarkOrange;
				case 'P':
					return Color.HotPink;
				case 'R':
					return Color.Red;
				}
				break;
			}
		}
		return Color.Transparent;
	}

	internal bool method_13()
	{
		if (Bbx != -1 && BbY != -1 && !string.IsNullOrEmpty(BbU))
		{
			Setting setting = BbQ.method_31(Bbx);
			if (setting != null && BbY < setting.method_277() && setting.method_199() == 2)
			{
				return true;
			}
		}
		return false;
	}

	internal Color method_14()
	{
		if (method_13())
		{
			byte b = (byte)((BbQ.method_31(Bbx).method_258(BbY) >> 8) & 0xFF);
			switch (b)
			{
			case 0:
				return smethod_4(BbU);
			default:
				if (b <= BCd.Length)
				{
					return smethod_4(BCd[b - 1]);
				}
				break;
			case byte.MaxValue:
				break;
			}
			return Color.Transparent;
		}
		return smethod_4(BbU);
	}

	internal Color method_15()
	{
		if (method_13())
		{
			byte b = (byte)(BbQ.method_31(Bbx).method_258(BbY) & 0xFF);
			switch (b)
			{
			case 0:
				return smethod_4(Bbu);
			default:
				if (b <= BCd.Length)
				{
					return smethod_4(BCd[b - 1]);
				}
				break;
			case byte.MaxValue:
				break;
			}
			return Color.Transparent;
		}
		return smethod_4(Bbu);
	}

	internal string method_16()
	{
		Color color = method_14();
		string[] bCd = BCd;
		int num = 0;
		string text;
		while (true)
		{
			if (num < bCd.Length)
			{
				text = bCd[num];
				if (smethod_4(text) == color)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return text;
	}

	internal string method_17()
	{
		Color color = method_15();
		string[] bCd = BCd;
		int num = 0;
		string text;
		while (true)
		{
			if (num < bCd.Length)
			{
				text = bCd[num];
				if (smethod_4(text) == color)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return text;
	}

	internal void method_18(byte byte_0, byte byte_1)
	{
		if (method_13())
		{
			Setting setting = BbQ.method_31(Bbx);
			Class280 @class = Form23.smethod_95();
			@class?.method_2(Bbx);
			int int_ = (byte_0 << 8) | byte_1;
			setting.method_274(BbY, int_, bool_0: true);
			@class?.method_4();
			Form23.smethod_74(Bbx);
		}
	}
}
