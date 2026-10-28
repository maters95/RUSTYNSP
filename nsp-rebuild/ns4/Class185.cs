using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns5;
using ns6;
using ns7;

namespace ns4;

internal class Class185 : Panel
{
	internal class Class186 : PictureBox
	{
		internal Enum104 BOT;

		private Class185 BOt;

		private List<WiringPin> BOU = new List<WiringPin>();

		private List<WiringPin> BOu = new List<WiringPin>();

		internal Class186(Class185 class185_0, Enum104 enum104_0)
		{
			BOt = class185_0;
			BOT = enum104_0;
		}

		internal void method_0()
		{
			BOU.Clear();
			BOu.Clear();
			foreach (WiringPin item in Form23.framework_1.awc)
			{
				List<WiringPin.Class276> list = item.method_4();
				if (list.Count == 0)
				{
					continue;
				}
				Enum104 bsk = list[list.Count - 1].Bsk;
				Enum105 bsL = list[list.Count - 1].BsL;
				byte bsl = list[list.Count - 1].Bsl;
				ushort bsM = list[list.Count - 1].BsM;
				if (bsk != BOT || (!item.method_0() && !item.method_1()) || item.BbX.Width == 0 || item.BbX.Height == 0)
				{
					continue;
				}
				bool flag = false;
				if (BOt.form6_0.method_15(bsk, bsL))
				{
					List<bool> list_ = new List<bool>();
					List<string> list2 = PortFunction.smethod_45(Form23.framework_1, bsk, bsL, bsl, bsM, bool_0: true, list_);
					if (list2 == null)
					{
						string text = PortFunction.smethod_47(Form23.framework_1, bsk, bsL, bsl, bsM);
						if (text != null)
						{
							list2 = new List<string> { text };
						}
					}
					if ((BOt.form6_0.bool_2 && list2 != null) || (BOt.form6_0.bool_3 && list2 == null))
					{
						SettingOrSpecialObject settingOrSpecialObject_ = PortFunction.smethod_36(Form23.framework_1, bsk, bsL, bsl, bsM);
						if (!BOt.form6_0.bool_0 || PortFunction.smethod_40(settingOrSpecialObject_, BOt.form6_0.class244_0))
						{
							string text2 = PortFunction.smethod_37(settingOrSpecialObject_);
							if (text2 == null)
							{
								text2 = string.Empty;
							}
							bool bool_ = WiringPin.smethod_0(Form23.framework_1, bsk, bsL, bsl, bsM).Count > 1;
							List<string> list_2 = new List<string> { item.method_11(bool_) };
							if (Form6.smethod_0(BOt.form6_0.vmethod_0(), bsL, bsk, text2, list2, list_2))
							{
								flag = true;
							}
						}
					}
				}
				if (!flag && bsL != Enum105.BAU)
				{
					BOu.Add(item);
				}
				else
				{
					BOU.Add(item);
				}
			}
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs_0)
		{
			base.OnPaint(paintEventArgs_0);
			WiringPin wiringPin = null;
			if (BOt.wiringPin_2 != null && (BOt.wiringPin_2.method_0() || BOt.wiringPin_2.method_1()) && BOt.wiringPin_2.BbX.Width != 0 && BOt.wiringPin_2.BbX.Height != 0)
			{
				List<WiringPin.Class276> list = BOt.wiringPin_2.method_4();
				if (list.Count != 0 && list[list.Count - 1].Bsk == BOT)
				{
					wiringPin = BOt.wiringPin_2;
				}
			}
			List<WiringPin> list2 = new List<WiringPin>();
			if (BOt.settingOrSpecialObject_0 != null)
			{
				PortFunction.Class273 @class = BOt.settingOrSpecialObject_0.method_12().method_12();
				Enum104 bSQ = @class.BSQ;
				Enum105 bSq = @class.BSq;
				byte bSR = @class.BSR;
				ushort bSr = @class.BSr;
				if (bSQ == BOT)
				{
					foreach (WiringPin item in WiringPin.smethod_0(Form23.framework_1, bSQ, bSq, bSR, bSr))
					{
						if ((item.method_0() || item.method_1()) && item.BbX.Width != 0 && item.BbX.Height != 0)
						{
							list2.Add(item);
						}
					}
				}
			}
			method_1(paintEventArgs_0.Graphics);
			foreach (WiringPin item2 in list2)
			{
				if (BOt.bool_0 || (list2.Count > 1 && item2 != wiringPin))
				{
					using Pen pen_ = new Pen(Color.DodgerBlue, 3f);
					method_2(paintEventArgs_0.Graphics, item2, 0, pen_);
				}
			}
			if (wiringPin != null && list2.Count > 1 && BOt.bool_0)
			{
				using Pen pen_2 = new Pen(Color.DodgerBlue, 3f);
				method_2(paintEventArgs_0.Graphics, wiringPin, 0, pen_2);
			}
			if (BOt.wiringPin_1 != null)
			{
				List<WiringPin.Class276> list3 = BOt.wiringPin_1.method_4();
				if (list3.Count != 0 && list3[list3.Count - 1].Bsk == BOT)
				{
					method_2(paintEventArgs_0.Graphics, BOt.wiringPin_1, -2, Pens.DodgerBlue);
				}
			}
		}

		private void method_1(Graphics graphics_0)
		{
			foreach (WiringPin item in BOU)
			{
				List<WiringPin.Class276> list = item.method_4();
				if (list.Count == 0)
				{
					continue;
				}
				Enum104 bsk = list[list.Count - 1].Bsk;
				Enum105 bsL = list[list.Count - 1].BsL;
				bool bool_ = bsL == Enum105.BAU || !item.Bbq.method_35();
				bool bool_2 = bsk == Enum104.BAJ || bsL == Enum105.Bal || item.BbU == Class333.smethod_883() || item.BbU == Class333.aTU();
				using Bitmap image = WiringPin.smethod_2(item.BbX.Width, item.BbX.Height, item.method_14(), item.method_15(), item.Bbt, bool_2, bool_);
				if (item.method_0())
				{
					graphics_0.DrawImage(image, item.BbW.X - item.BbX.Width / 2, item.BbW.Y - item.BbX.Height / 2);
				}
				else if (item.method_1())
				{
					graphics_0.DrawImage(image, item.Bbw.X, item.Bbw.Y);
				}
			}
			foreach (WiringPin item2 in BOu)
			{
				using Pen pen_ = new Pen(Color.Gray, 1f);
				method_2(graphics_0, item2, 0, pen_);
			}
		}

		private void method_2(Graphics graphics_0, WiringPin wiringPin_0, int int_0, Pen pen_0)
		{
			int width = wiringPin_0.BbX.Width - 2 * int_0;
			int height = wiringPin_0.BbX.Height - 2 * int_0;
			int x = 0;
			int y = 0;
			if (wiringPin_0.method_0())
			{
				x = wiringPin_0.BbW.X + int_0 - wiringPin_0.BbX.Width / 2;
				y = wiringPin_0.BbW.Y + int_0 - wiringPin_0.BbX.Height / 2;
			}
			else if (wiringPin_0.method_1())
			{
				x = wiringPin_0.Bbw.X + int_0;
				y = wiringPin_0.Bbw.Y + int_0;
			}
			if (wiringPin_0.Bbv)
			{
				graphics_0.DrawRectangle(pen_0, x, y, width, height);
				return;
			}
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.DrawEllipse(pen_0, x, y, width, height);
		}

		private WiringPin method_3(int int_0, int int_1, out Rectangle rectangle_0)
		{
			rectangle_0 = Rectangle.Empty;
			foreach (WiringPin item in Form23.framework_1.awc)
			{
				List<WiringPin.Class276> list = item.method_4();
				if (list.Count == 0 || list[list.Count - 1].Bsk != BOT || (!item.method_0() && !item.method_1()) || item.BbX.Width == 0 || item.BbX.Height == 0)
				{
					continue;
				}
				if (item.method_0())
				{
					int num = item.BbX.Width / 2;
					int num2 = item.BbX.Height / 2;
					rectangle_0 = new Rectangle(item.BbW.X - num, item.BbW.Y - num2, item.BbX.Width, item.BbX.Height);
				}
				else
				{
					rectangle_0 = new Rectangle(item.Bbw, item.BbX);
				}
				if (rectangle_0.Contains(int_0, int_1))
				{
					if (list[list.Count - 1].BsL != Enum105.BAU && item.Bbq.method_35())
					{
						return item;
					}
					return null;
				}
			}
			return null;
		}

		protected override void OnMouseClick(MouseEventArgs mouseEventArgs_0)
		{
			if (mouseEventArgs_0.Button != MouseButtons.Left)
			{
				return;
			}
			WiringPin wiringPin = method_3(mouseEventArgs_0.X, mouseEventArgs_0.Y, out var _);
			if (wiringPin == null)
			{
				return;
			}
			List<WiringPin.Class276> list = wiringPin.method_4();
			if (list.Count != 0)
			{
				Enum104 bsk = list[list.Count - 1].Bsk;
				Enum105 bsL = list[list.Count - 1].BsL;
				byte bsl = list[list.Count - 1].Bsl;
				ushort bsM = list[list.Count - 1].BsM;
				SettingOrSpecialObject settingOrSpecialObject_ = PortFunction.smethod_36(Form23.framework_1, bsk, bsL, bsl, bsM);
				if (!BOt.form6_0.bool_0 || PortFunction.smethod_40(settingOrSpecialObject_, BOt.form6_0.class244_0))
				{
					BOt.form6_0.method_20(wiringPin);
				}
			}
		}

		protected override void OnMouseMove(MouseEventArgs mevent)
		{
			base.OnMouseMove(mevent);
			WiringPin wiringPin = method_3(mevent.X, mevent.Y, out var rectangle_);
			if (wiringPin != null)
			{
				if (BOt.wiringPin_1 != wiringPin)
				{
					BOt.wiringPin_1 = wiringPin;
					Refresh();
				}
				if (wiringPin != BOt.wiringPin_0)
				{
					BOt.wiringPin_0 = wiringPin;
					BOt.toolTip_0.ShowAlways = true;
					BOt.toolTip_0.InitialDelay = 100;
					BOt.toolTip_0.ReshowDelay = 100;
					BOt.toolTip_0.Active = true;
					BOt.toolTip_0.Show(method_4(wiringPin), this, rectangle_.Right, rectangle_.Top);
				}
			}
			else
			{
				if (BOt.wiringPin_1 != null)
				{
					BOt.wiringPin_1 = null;
					Refresh();
				}
				BOt.wiringPin_0 = null;
				BOt.toolTip_0.Active = false;
				BOt.toolTip_0.Hide(this);
			}
		}

		protected override void OnMouseLeave(EventArgs eventArgs_0)
		{
			base.OnMouseLeave(eventArgs_0);
			if (BOt.wiringPin_1 != null)
			{
				BOt.wiringPin_1 = null;
				Refresh();
			}
			BOt.toolTip_0.Active = false;
			BOt.toolTip_0.Hide(this);
		}

		private string method_4(WiringPin wiringPin_0)
		{
			string text = string.Empty;
			Enum104 enum104_ = Enum104.BAB;
			Enum105 enum105_ = Enum105.BAU;
			byte byte_ = 0;
			ushort ushort_ = 0;
			foreach (WiringPin.Class276 item in wiringPin_0.method_4())
			{
				List<bool> list_ = new List<bool>();
				List<string> list = PortFunction.smethod_45(Form23.framework_1, item.Bsk, item.BsL, item.Bsl, item.BsM, bool_0: true, list_);
				if (list == null)
				{
					string text2 = PortFunction.smethod_47(Form23.framework_1, item.Bsk, item.BsL, item.Bsl, item.BsM);
					if (text2 != null)
					{
						list = new List<string> { text2 };
					}
				}
				if (list != null)
				{
					foreach (string item2 in list)
					{
						if (list.IndexOf(item2) != 0)
						{
							text += Class333.smethod_570();
						}
						text += item2;
					}
				}
				enum104_ = item.Bsk;
				enum105_ = item.BsL;
				byte_ = item.Bsl;
				ushort_ = item.BsM;
			}
			bool bool_ = WiringPin.smethod_0(Form23.framework_1, enum104_, enum105_, byte_, ushort_).Count > 1;
			SettingOrSpecialObject settingOrSpecialObject = PortFunction.smethod_36(Form23.framework_1, enum104_, enum105_, byte_, ushort_);
			string text3 = wiringPin_0.method_11(bool_);
			string text4 = string.Empty;
			if (!string.IsNullOrEmpty(text3))
			{
				text4 += text3;
			}
			string text5 = ((settingOrSpecialObject != null) ? PortFunction.smethod_37(settingOrSpecialObject) : null);
			if (!string.IsNullOrEmpty(text5))
			{
				text4 = text4 + Class333.smethod_497() + text5 + Class333.smethod_9();
			}
			if (!string.IsNullOrEmpty(text))
			{
				if (!string.IsNullOrEmpty(text4))
				{
					text4 += Class333.smethod_1810();
				}
				text4 += text;
			}
			return text4;
		}

		protected override void Dispose(bool disposing)
		{
			try
			{
				base.Dispose(disposing);
				if (Image != null)
				{
					Image.Dispose();
				}
			}
			catch
			{
			}
		}
	}

	internal class Control27 : UserControl
	{
		internal Enum104 BOV;

		internal Label BOv;

		internal Class186 BOW;

		internal Control27(Class185 class185_0, Enum104 enum104_0, Image image_0)
		{
			BOV = enum104_0;
			BackColor = Form23.color_15;
			BOv = new Label();
			Controls.Add(BOv);
			BOv.BackColor = Form23.color_15;
			BOv.ForeColor = Form23.color_12;
			BOv.Font = new Font(BOv.Font.FontFamily, 10f);
			if (enum104_0 == Enum104.BAb)
			{
				BOv.Text = Class242.smethod_9(Form23.framework_1.awZ, Form23.framework_1.awz);
			}
			else
			{
				BOv.Text = PortFunction.smethod_3(enum104_0, Form23.framework_1);
			}
			BOv.AutoSize = true;
			BOW = new Class186(class185_0, enum104_0);
			Controls.Add(BOW);
			BOW.BackColor = Form23.color_15;
			BOW.BorderStyle = BorderStyle.None;
			BOW.Image = image_0;
			BOW.SizeMode = PictureBoxSizeMode.AutoSize;
			Width = Math.Max(BOv.Width, BOW.Width);
			Height = BOv.Height + BOW.Height;
			BOv.Left = Width / 2 - BOv.Width / 2;
			BOv.Top = 0;
			BOW.Left = Width / 2 - BOW.Width / 2;
			BOW.Top = BOv.Height;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class187
	{
		public static readonly Class187 BOw = new Class187();

		public static Func<KeyValuePair<Enum104, string>, Enum104> BOX;

		public static Func<KeyValuePair<Enum104, string>, Enum104> BOx;

		public static Func<KeyValuePair<Enum104, string>, string> BOY;

		internal Enum104 method_0(KeyValuePair<Enum104, string> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		internal Enum104 method_1(KeyValuePair<Enum104, string> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		internal string method_2(KeyValuePair<Enum104, string> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}
	}

	private const int int_0 = 40;

	private const int int_1 = 5;

	private const int int_2 = 25;

	private const int int_3 = 250;

	private Form6 form6_0;

	private System.Timers.Timer timer_0 = new System.Timers.Timer();

	private bool bool_0;

	private ToolTip toolTip_0 = new ToolTip();

	private WiringPin wiringPin_0;

	private WiringPin wiringPin_1;

	private WiringPin wiringPin_2;

	private SettingOrSpecialObject settingOrSpecialObject_0;

	private int int_4;

	internal Class185(Form6 form6_1)
	{
		form6_0 = form6_1;
		foreach (KeyValuePair<Enum104, string> item in Form23.framework_1.awC.OrderBy((KeyValuePair<Enum104, string> keyValuePair_0) => keyValuePair_0.Key).ToDictionary((KeyValuePair<Enum104, string> keyValuePair_0) => keyValuePair_0.Key, (KeyValuePair<Enum104, string> keyValuePair_0) => keyValuePair_0.Value))
		{
			Enum104 key = item.Key;
			string value = item.Value;
			if ((key == Enum104.BAb || Form23.framework_1.method_27(PortFunction.smethod_0(key, Form23.framework_1))) && PortFunction.smethod_43(Form23.framework_1, key))
			{
				using MemoryStream stream = new MemoryStream(Class24.smethod_1(value));
				Image image_ = Image.FromStream(stream);
				Control27 control = new Control27(this, key, image_)
				{
					Name = Controls.Count.ToString(),
					Top = 5
				};
				Controls.Add(control);
				Height = Math.Max(Height, 5 + control.Height + 5);
			}
		}
		method_3();
		ThemedButton themedButton = new ThemedButton
		{
			Name = Class333.smethod_891(),
			Anchor = (AnchorStyles.Top | AnchorStyles.Left),
			Image = Form23.image_2,
			Width = 40,
			Height = Height - 3,
			Top = 0,
			Left = 0
		};
		Controls.Add(themedButton);
		themedButton.BringToFront();
		themedButton.Click += method_5;
		ThemedButton themedButton2 = new ThemedButton
		{
			Name = Class333.smethod_892(),
			Anchor = (AnchorStyles.Top | AnchorStyles.Right),
			Image = Form23.image_3,
			Width = 40,
			Height = Height - 3,
			Top = 0,
			Left = Width - 40
		};
		Controls.Add(themedButton2);
		themedButton2.BringToFront();
		themedButton2.Click += method_6;
		method_4();
		timer_0.Interval = 250.0;
		timer_0.SynchronizingObject = this;
		timer_0.Elapsed += timer_0_Elapsed;
		timer_0.AutoReset = true;
		timer_0.Enabled = true;
		timer_0.Start();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			foreach (Control control in Controls)
			{
				control.Click -= method_5;
				control.Click -= method_6;
			}
			timer_0.Stop();
			timer_0.Dispose();
			timer_0 = null;
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	internal void method_0()
	{
		foreach (Control control in Controls)
		{
			if (control is Control27)
			{
				(control as Control27).BOW.method_0();
			}
		}
		foreach (Control control2 in Controls)
		{
			control2.Refresh();
		}
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		bool_0 = !bool_0;
		foreach (Control control in Controls)
		{
			control.Refresh();
		}
	}

	protected override void OnResize(EventArgs eventargs)
	{
		base.OnResize(eventargs);
		if (Controls.ContainsKey(Class333.smethod_891()) && Controls.ContainsKey(Class333.smethod_892()))
		{
			method_4();
		}
	}

	internal void method_1(Enum104 enum104_0)
	{
		int num = -1;
		foreach (Control control3 in Controls)
		{
			if (control3 is Control27)
			{
				num++;
				Control27 control2 = control3 as Control27;
				if (control2.BOV == enum104_0)
				{
					int_4 = num;
					control2.Visible = true;
				}
				else
				{
					control2.Visible = false;
				}
			}
		}
		method_3();
		Controls[Class333.smethod_891()].Visible = false;
		Controls[Class333.smethod_892()].Visible = false;
	}

	internal void method_2()
	{
		foreach (Control control in Controls)
		{
			if (control is Control27)
			{
				control.Visible = true;
			}
		}
		int_4 = 0;
		method_3();
		method_4();
		method_7(settingOrSpecialObject_0, wiringPin_2);
	}

	private void method_3()
	{
		int num = 0;
		int num2 = -1;
		foreach (Control control5 in Controls)
		{
			if (control5 is Control27)
			{
				num2++;
				if (num2 < int_4)
				{
					Control27 control2 = control5 as Control27;
					num += control2.Width + 25;
				}
			}
		}
		int num3 = 45;
		for (int i = 0; i < Controls.Count; i++)
		{
			Control control3 = Controls[i];
			if (control3 is Control27)
			{
				Control27 control4 = control3 as Control27;
				control4.Left = num3 - num;
				num3 += control4.Width + 25;
			}
		}
	}

	private void method_4()
	{
		Controls[Class333.smethod_891()].Visible = Controls.Count > 3 && int_4 > 0;
		Controls[Class333.smethod_892()].Visible = Controls.Count > 3 && int_4 < Controls.Count - 3 && Controls[(Controls.Count - 3).ToString()].Right > Width - 40;
	}

	private void method_5(object sender, EventArgs e)
	{
		int_4--;
		method_3();
		method_4();
	}

	private void method_6(object sender, EventArgs e)
	{
		int_4++;
		method_3();
		method_4();
	}

	internal void method_7(SettingOrSpecialObject settingOrSpecialObject_1, WiringPin wiringPin_3)
	{
		settingOrSpecialObject_0 = settingOrSpecialObject_1;
		wiringPin_2 = wiringPin_3;
		if (settingOrSpecialObject_0 != null)
		{
			int num = -1;
			foreach (Control control3 in Controls)
			{
				if (!(control3 is Control27))
				{
					continue;
				}
				num++;
				Control27 control2 = control3 as Control27;
				if (control2.BOV == settingOrSpecialObject_0.method_12().method_12().BSQ)
				{
					if (control2.Visible && (control2.Left < 40 || control2.Right > Width - 40))
					{
						int_4 = num;
						method_3();
						method_4();
					}
					break;
				}
			}
		}
		foreach (Control control4 in Controls)
		{
			control4.Refresh();
		}
	}

	internal void method_8()
	{
		settingOrSpecialObject_0 = null;
		wiringPin_2 = null;
		foreach (Control control in Controls)
		{
			control.Refresh();
		}
	}
}
