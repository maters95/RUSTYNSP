using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns1;
using ns4;
using ns7;

namespace NSP.UserInterface;

public class ThemedBitfieldViewer : UserControl
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class145
	{
		public static readonly Class145 BNV = new Class145();

		public static Func<int, int> BNv;

		public static Func<int, int> BNW;

		public static Func<int, int> BNw;

		internal int method_0(int int_0)
		{
			return int_0 / 8;
		}

		internal int method_1(int int_0)
		{
			return int_0 / 8;
		}

		internal int method_2(int int_0)
		{
			return int_0 / 8;
		}
	}

	internal const int int_0 = 225;

	internal const int int_1 = 150;

	private const int int_2 = 8;

	private const int int_3 = 50;

	private const int int_4 = 20;

	private const int int_5 = 5;

	private const int int_6 = 27;

	private List<CANSignalModel> list_0 = new List<CANSignalModel>();

	private CANSignalModel cansignalModel_0;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	[CompilerGenerated]
	private EventHandler eventHandler_1;

	private uint uint_0;

	private ToolTip toolTip_0 = new ToolTip();

	private CANSignalModel cansignalModel_1;

	private Color[] color_0 = new Color[64]
	{
		Color.Red,
		Color.Green,
		Color.Blue,
		Color.Yellow,
		Color.Magenta,
		Color.Cyan,
		Color.Orange,
		Color.Purple,
		Color.Teal,
		Color.Lime,
		Color.Indigo,
		Color.Violet,
		Color.Brown,
		Color.Olive,
		Color.Maroon,
		Color.Navy,
		Color.Turquoise,
		Color.Gold,
		Color.Pink,
		Color.DarkRed,
		Color.DarkGreen,
		Color.DarkBlue,
		Color.DarkCyan,
		Color.DarkMagenta,
		Color.DarkOrange,
		Color.DarkViolet,
		Color.DarkTurquoise,
		Color.MediumVioletRed,
		Color.MediumOrchid,
		Color.MediumBlue,
		Color.MediumSeaGreen,
		Color.MediumTurquoise,
		Color.MediumSlateBlue,
		Color.MediumSpringGreen,
		Color.DeepPink,
		Color.DeepSkyBlue,
		Color.LightSeaGreen,
		Color.LightCoral,
		Color.LightSalmon,
		Color.LightGreen,
		Color.LightSkyBlue,
		Color.Sienna,
		Color.SteelBlue,
		Color.Tomato,
		Color.SlateBlue,
		Color.SlateGray,
		Color.SeaGreen,
		Color.RoyalBlue,
		Color.Peru,
		Color.Plum,
		Color.PaleVioletRed,
		Color.Moccasin,
		Color.Khaki,
		Color.HotPink,
		Color.IndianRed,
		Color.Firebrick,
		Color.Crimson,
		Color.CadetBlue,
		Color.Chartreuse,
		Color.Chocolate,
		Color.Coral,
		Color.CornflowerBlue,
		Color.DarkSlateBlue,
		Color.DarkSlateGray
	};

	private int int_7 = -1;

	private IContainer icontainer_0;

	public event EventHandler SignalSelectionChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler SelectedSignalBitsChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ThemedBitfieldViewer()
	{
		method_8();
		DoubleBuffered = true;
		ResizeRedraw = true;
		MouseDown += ThemedBitfieldViewer_MouseDown;
		MouseMove += ThemedBitfieldViewer_MouseMove;
		MouseUp += ThemedBitfieldViewer_MouseUp;
		MouseLeave += ThemedBitfieldViewer_MouseLeave;
		Disposed += (object? sender, EventArgs e) =>
		{
			Form23.form23_0.control25_0.SelectedIndexChanged -= method_0;
			toolTip_0.Dispose();
		};
		Form23.form23_0.control25_0.SelectedIndexChanged += method_0;
	}

	private void method_0(object sender, EventArgs e)
	{
		method_7();
	}

	public void UpdateSignals(CANFrameModel frame)
	{
		if (frame != null && frame.Signals != null)
		{
			list_0 = frame.Signals.ToList();
			uint_0 = frame.Length;
			Invalidate();
			if (cansignalModel_0 != null && !list_0.Contains(cansignalModel_0))
			{
				ClearSignalSelection();
			}
		}
		else
		{
			list_0.Clear();
			uint_0 = 0u;
			Invalidate();
			ClearSignalSelection();
		}
		method_7();
	}

	public void SelectSignal(CANSignalModel signal)
	{
		if (cansignalModel_0 != signal)
		{
			cansignalModel_0 = signal;
			Invalidate();
			if (eventHandler_0 != null)
			{
				Invoke(eventHandler_0, this, null);
			}
		}
	}

	public void ClearSignalSelection()
	{
		if (cansignalModel_0 != null)
		{
			cansignalModel_0 = null;
			Invalidate();
			if (eventHandler_0 != null)
			{
				Invoke(eventHandler_0, this, null);
			}
		}
	}

	public CANSignalModel GetSelectedSignal()
	{
		return cansignalModel_0;
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		base.OnPaint(paintEventArgs_0);
		method_1(paintEventArgs_0.Graphics);
		if (list_0 != null && list_0.Count > 0)
		{
			method_3(paintEventArgs_0.Graphics, list_0);
		}
		method_2(paintEventArgs_0.Graphics);
	}

	private void method_1(Graphics graphics_0)
	{
		using Brush brush = new SolidBrush(Form23.color_12);
		using Brush brush2 = new SolidBrush(Form23.color_36);
		using Pen pen = new Pen(Form23.color_10);
		int num = (ClientSize.Width - 50) / 8;
		int num2 = (ClientSize.Height - 20) / 8;
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				int num3 = 50 + j * num;
				int num4 = 20 + i * num2;
				graphics_0.DrawRectangle(pen, num3, num4, num, num2);
				int num5 = i * 8 + (7 - j);
				Brush brush3 = ((uint_0 >= i + 1) ? brush : brush2);
				graphics_0.DrawString(num5.ToString(), Font, brush3, num3 + 6, num4 + 2);
			}
		}
	}

	private void method_2(Graphics graphics_0)
	{
		using Brush brush = new SolidBrush(Form23.color_12);
		using Brush brush2 = new SolidBrush(Form23.color_36);
		int num = (ClientSize.Width - 50) / 8;
		int num2 = (ClientSize.Height - 20) / 8;
		for (int i = 0; i < 8; i++)
		{
			int num3 = 50 + i * num;
			string text = Class333.smethod_666() + (7 - i);
			SizeF sizeF = graphics_0.MeasureString(text, Font);
			Brush brush3 = ((uint_0 != 0) ? brush : brush2);
			graphics_0.DrawString(text, Font, brush3, (float)num3 + ((float)num - sizeF.Width) / 2f, (20f - sizeF.Height) / 2f);
		}
		for (int j = 0; j < 8; j++)
		{
			int num4 = 20 + j * num2;
			string s = Class333.smethod_667() + j;
			Brush brush4 = ((uint_0 >= j + 1) ? brush : brush2);
			graphics_0.DrawString(s, Font, brush4, 4f, num4 + (num2 - Font.Height) / 2);
		}
	}

	private void method_3(Graphics graphics_0, List<CANSignalModel> list_1)
	{
		int int_ = (ClientSize.Width - 50) / 8;
		int int_2 = (ClientSize.Height - 20) / 8;
		int num = 0;
		foreach (CANSignalModel item in list_1)
		{
			if (item.BitLength != 0)
			{
				method_5(item, graphics_0, Color.FromArgb(80, color_0[num++]), int_, int_2);
			}
			num %= color_0.Length;
		}
	}

	private List<int> method_4(CANSignalModel cansignalModel_2)
	{
		List<int> list = new List<int>();
		switch ((CANSignalModel.SignalFormat)cansignalModel_2.Format)
		{
		case CANSignalModel.SignalFormat.LittleEndian:
		{
			int num2 = (int)(cansignalModel_2.StartBit + cansignalModel_2.BitLength - 1);
			for (int j = (int)cansignalModel_2.StartBit; j <= num2; j++)
			{
				list.Add(j);
			}
			break;
		}
		case CANSignalModel.SignalFormat.BigEndian:
		{
			int num = (int)cansignalModel_2.StartBit;
			for (int i = 0; i < cansignalModel_2.BitLength; i++)
			{
				list.Add(num);
				num = ((num % 8 != 0) ? (num - 1) : (num + 15));
			}
			break;
		}
		}
		return list;
	}

	private void method_5(CANSignalModel cansignalModel_2, Graphics graphics_0, Color color_1, int int_8, int int_9)
	{
		CANSignalModel.SignalFormat format = (CANSignalModel.SignalFormat)cansignalModel_2.Format;
		IEnumerable<IGrouping<int, int>> enumerable = from num9 in method_4(cansignalModel_2)
			group num9 by num9 / 8;
		int num = 1;
		bool flag = false;
		foreach (IGrouping<int, int> item in enumerable)
		{
			int key = item.Key;
			if (key >= 8)
			{
				continue;
			}
			List<int> source = item.ToList();
			int num2 = 7 - source.Min() % 8;
			int num3 = 7 - source.Max() % 8;
			int num4 = 50 + num3 * int_8;
			int num5 = 20 + key * int_9;
			int num6 = (num2 - num3 + 1) * int_8;
			using (Brush brush = new SolidBrush(color_1))
			{
				graphics_0.FillRectangle(brush, num4, num5, num6, int_9);
			}
			using (new Pen(Form23.color_12, 1f))
			{
				using Brush brush2 = new SolidBrush(Form23.color_12);
				using Brush brush3 = new SolidBrush(Color.Red);
				using Pen pen = new Pen(Form23.color_10);
				using Pen pen2 = new Pen(Color.White, 2f);
				int num7 = num5 + (int)((double)int_9 * 0.7);
				int num8 = (int)((double)int_9 * 0.2);
				if (num == 1)
				{
					switch (format)
					{
					case CANSignalModel.SignalFormat.LittleEndian:
					{
						Point point = new Point(num4 + num6 - 5 - 2, num7 - num8);
						Point point2 = new Point(num4 + num6 - 2, num7);
						Point point3 = new Point(num4 + num6 - 5 - 2, num7 + num8);
						Struct63<Point> gparam_2 = default;
						Class332.smethod_1<Struct63<Point>, Point>(ref gparam_2, 0) = point2;
						Class332.smethod_1<Struct63<Point>, Point>(ref gparam_2, 1) = point;
						Class332.smethod_1<Struct63<Point>, Point>(ref gparam_2, 2) = point3;
						graphics_0.FillPolygon(brush3, Class332.smethod_0<Struct63<Point>, Point>(in gparam_2, 3));
						break;
					}
					case CANSignalModel.SignalFormat.BigEndian:
					{
						Point point = new Point(num4 + 2, num7 - num8);
						Point point2 = new Point(num4 + 2 + 5, num7);
						Point point3 = new Point(num4 + 2, num7 + num8);
						Struct63<Point> gparam_ = default;
						Class332.smethod_1<Struct63<Point>, Point>(ref gparam_, 0) = point2;
						Class332.smethod_1<Struct63<Point>, Point>(ref gparam_, 1) = point;
						Class332.smethod_1<Struct63<Point>, Point>(ref gparam_, 2) = point3;
						graphics_0.FillPolygon(brush3, Class332.smethod_0<Struct63<Point>, Point>(in gparam_, 3));
						break;
					}
					}
				}
				if (num == enumerable.Count())
				{
					switch (format)
					{
					case CANSignalModel.SignalFormat.LittleEndian:
					{
						Point point = new Point(num4 + 2, num7 - num8);
						Point point2 = new Point(num4 + 2 + 5, num7);
						Point point3 = new Point(num4 + 2, num7 + num8);
						Struct63<Point> gparam_4 = default;
						Class332.smethod_1<Struct63<Point>, Point>(ref gparam_4, 0) = point2;
						Class332.smethod_1<Struct63<Point>, Point>(ref gparam_4, 1) = point;
						Class332.smethod_1<Struct63<Point>, Point>(ref gparam_4, 2) = point3;
						graphics_0.FillPolygon(brush3, Class332.smethod_0<Struct63<Point>, Point>(in gparam_4, 3));
						break;
					}
					case CANSignalModel.SignalFormat.BigEndian:
					{
						Point point = new Point(num4 + num6 - 5 - 2, num7 - num8);
						Point point2 = new Point(num4 + num6 - 2, num7);
						Point point3 = new Point(num4 + num6 - 5 - 2, num7 + num8);
						Struct63<Point> gparam_3 = default;
						Class332.smethod_1<Struct63<Point>, Point>(ref gparam_3, 0) = point2;
						Class332.smethod_1<Struct63<Point>, Point>(ref gparam_3, 1) = point;
						Class332.smethod_1<Struct63<Point>, Point>(ref gparam_3, 2) = point3;
						graphics_0.FillPolygon(brush3, Class332.smethod_0<Struct63<Point>, Point>(in gparam_3, 3));
						break;
					}
					}
				}
				num++;
				if (cansignalModel_2 == cansignalModel_0)
				{
					graphics_0.DrawRectangle(pen2, num4, num5, num6 - 1, int_9 - 1);
				}
				else
				{
					graphics_0.DrawRectangle(pen, num4, num5, num6, int_9);
				}
				if (flag)
				{
					continue;
				}
				string text = cansignalModel_2.Name;
				bool flag2 = false;
				SizeF sizeF;
				while (true)
				{
					sizeF = graphics_0.MeasureString((!flag2) ? text : (text + Class333.smethod_525()), Font);
					if (!(27f + sizeF.Width >= (float)int_8) || text.Length <= 1)
					{
						break;
					}
					text = text.Substring(0, text.Length - 1);
					flag2 = true;
				}
				if (flag2)
				{
					text += Class333.smethod_525();
				}
				graphics_0.DrawString(text, Font, brush2, num4 + 27, (float)num5 + ((float)int_9 - sizeF.Height) / 2f);
				flag = true;
			}
		}
	}

	private void ThemedBitfieldViewer_MouseDown(object sender, MouseEventArgs e)
	{
		CANSignalModel cANSignalModel = null;
		if (e.Button == MouseButtons.Left && list_0 != null && list_0.Count > 0)
		{
			int num = (ClientSize.Width - 50) / 8;
			int num2 = (ClientSize.Height - 20) / 8;
			List<CANSignalModel> list = new List<CANSignalModel>(list_0.Count);
			if (cansignalModel_0 != null)
			{
				list.Add(cansignalModel_0);
			}
			foreach (CANSignalModel item in list_0)
			{
				if (item != cansignalModel_0)
				{
					list.Add(item);
				}
			}
			foreach (CANSignalModel item2 in list)
			{
				if (item2.BitLength == 0)
				{
					continue;
				}
				CANSignalModel.SignalFormat format = (CANSignalModel.SignalFormat)item2.Format;
				IEnumerable<IGrouping<int, int>> enumerable = from int_0 in method_4(item2)
					group int_0 by int_0 / 8;
				int num3 = 1;
				foreach (IGrouping<int, int> item3 in enumerable)
				{
					int key = item3.Key;
					if (key >= 8)
					{
						continue;
					}
					List<int> source = item3.ToList();
					int num4 = 7 - source.Min() % 8;
					int num5 = 7 - source.Max() % 8;
					int x = 50 + num5 * num;
					int y = 20 + key * num2;
					int width = (num4 - num5 + 1) * num;
					if (new Rectangle(x, y, width, num2).Contains(e.X, e.Y))
					{
						int num6 = 7 - (e.X - 50) / num;
						int num7 = 7 - num5;
						int num8 = 7 - num4;
						if (enumerable.Count() == 1)
						{
							if (num6 == num8)
							{
								int_7 = key * 8 + num7;
							}
							else if (num6 == num7)
							{
								int_7 = key * 8 + num8;
							}
						}
						else if (num3 == 1)
						{
							switch (format)
							{
							case CANSignalModel.SignalFormat.LittleEndian:
								if (num6 == num8)
								{
									int num11 = (int)(item2.StartBit + item2.BitLength - 1);
									int_7 = num11;
								}
								break;
							case CANSignalModel.SignalFormat.BigEndian:
								if (num6 == num7)
								{
									int num9 = (int)item2.StartBit;
									for (int num10 = 1; num10 < item2.BitLength; num10++)
									{
										num9 = ((num9 % 8 != 0) ? (num9 - 1) : (num9 + 15));
									}
									int_7 = num9;
								}
								break;
							}
						}
						else if (num3 == enumerable.Count())
						{
							switch (format)
							{
							case CANSignalModel.SignalFormat.LittleEndian:
								if (num6 == num7)
								{
									int_7 = (int)item2.StartBit;
								}
								break;
							case CANSignalModel.SignalFormat.BigEndian:
								if (num6 == num8)
								{
									int_7 = (int)item2.StartBit;
								}
								break;
							}
						}
						if (int_7 != -1)
						{
							SelectSignal(item2);
							Form23.smethod_95()?.method_1();
							return;
						}
						if (cANSignalModel == null)
						{
							cANSignalModel = item2;
						}
					}
					num3++;
				}
			}
			if (cANSignalModel != null && int_7 == -1)
			{
				SelectSignal(cANSignalModel);
				return;
			}
		}
		if (cANSignalModel == null)
		{
			ClearSignalSelection();
		}
	}

	private void ThemedBitfieldViewer_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left && cansignalModel_0 != null && int_7 != -1)
		{
			method_7();
			int num = (ClientSize.Width - 50) / 8;
			int num2 = (ClientSize.Height - 20) / 8;
			uint num3 = 0u;
			while (true)
			{
				if (num3 < 64)
				{
					int x = 50 + (7 - (int)num3 % 8) * num;
					int y = 20 + (int)num3 / 8 * num2;
					if (new Rectangle(x, y, num, num2).Contains(e.X, e.Y))
					{
						break;
					}
					num3++;
					continue;
				}
				return;
			}
			uint num4 = num3;
			uint num5;
			uint num6;
			if (cansignalModel_0.Format == 1L)
			{
				if (num4 < int_7)
				{
					num5 = num4;
					num6 = (uint)(int_7 - (int)num5 + 1);
				}
				else
				{
					num5 = (uint)int_7;
					num6 = num4 - num5 + 1;
				}
			}
			else
			{
				if (cansignalModel_0.Format != 0L)
				{
					return;
				}
				int num7 = (int)num4 / 8;
				int num8 = int_7 / 8;
				if (num7 == num8)
				{
					if (num4 < int_7)
					{
						num5 = (uint)int_7;
						num6 = num5 - num4 + 1;
					}
					else
					{
						num5 = num4;
						num6 = (uint)((int)num5 - int_7 + 1);
					}
				}
				else if (num7 < num8)
				{
					num5 = num4;
					num6 = 1u;
					for (uint num9 = num5; num9 != int_7; num9 = ((num9 % 8 != 0) ? (num9 - 1) : (num9 + 15)))
					{
						num6++;
					}
				}
				else
				{
					num5 = (uint)int_7;
					num6 = 1u;
					for (uint num10 = num5; num10 != num4; num10 = ((num10 % 8 != 0) ? (num10 - 1) : (num10 + 15)))
					{
						num6++;
					}
				}
			}
			if (cansignalModel_0.StartBit != num5 || cansignalModel_0.BitLength != num6)
			{
				cansignalModel_0.StartBit = num5;
				cansignalModel_0.BitLength = num6;
				Invalidate();
			}
		}
		else
		{
			method_6(e);
		}
	}

	private void ThemedBitfieldViewer_MouseUp(object sender, MouseEventArgs e)
	{
		if (int_7 != -1)
		{
			if (eventHandler_1 != null)
			{
				Invoke(eventHandler_1, this, null);
			}
			Form23.smethod_95()?.method_4();
			int_7 = -1;
		}
	}

	private void ThemedBitfieldViewer_MouseLeave(object sender, EventArgs e)
	{
		Point pt = PointToClient(Control.MousePosition);
		if (!ClientRectangle.Contains(pt))
		{
			method_7();
		}
	}

	private void method_6(MouseEventArgs mouseEventArgs_0)
	{
		int num = (ClientSize.Width - 50) / 8;
		int num2 = (ClientSize.Height - 20) / 8;
		List<CANSignalModel> list = new List<CANSignalModel>(list_0.Count);
		if (cansignalModel_0 != null)
		{
			list.Add(cansignalModel_0);
		}
		foreach (CANSignalModel item in list_0)
		{
			if (item != cansignalModel_0)
			{
				list.Add(item);
			}
		}
		foreach (CANSignalModel item2 in list)
		{
			if (item2.BitLength == 0)
			{
				continue;
			}
			_ = item2.Format;
			foreach (IGrouping<int, int> item3 in from int_0 in method_4(item2)
				group int_0 by int_0 / 8)
			{
				int key = item3.Key;
				if (key >= 8)
				{
					continue;
				}
				List<int> source = item3.ToList();
				int num3 = 7 - source.Min() % 8;
				int num4 = 7 - source.Max() % 8;
				int x = 50 + num4 * num;
				int y = 20 + key * num2;
				int width = (num3 - num4 + 1) * num;
				Rectangle rectangle = new Rectangle(x, y, width, num2);
				if (rectangle.Contains(mouseEventArgs_0.X, mouseEventArgs_0.Y))
				{
					if (item2 != cansignalModel_1)
					{
						cansignalModel_1 = item2;
						toolTip_0.ShowAlways = true;
						toolTip_0.InitialDelay = 100;
						toolTip_0.ReshowDelay = 100;
						toolTip_0.Active = true;
						toolTip_0.Show(item2.Name, this, mouseEventArgs_0.X, rectangle.Y + 3);
					}
					return;
				}
			}
		}
		method_7();
	}

	internal void method_7()
	{
		cansignalModel_1 = null;
		toolTip_0.Active = false;
		toolTip_0.Hide(this);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_8()
	{
		icontainer_0 = new Container();
		AutoScaleMode = AutoScaleMode.Font;
	}

	[CompilerGenerated]
	private void ThemedBitfieldViewer_Disposed(object? sender, EventArgs e)
	{
		Form23.form23_0.control25_0.SelectedIndexChanged -= method_0;
		toolTip_0.Dispose();
	}
}
