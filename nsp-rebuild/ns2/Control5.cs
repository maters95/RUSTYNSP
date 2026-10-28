using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns0;
using ns3;
using ns4;
using ns6;
using ns7;

namespace ns2;

internal class Control5 : UserControl
{
	private delegate void Delegate29(object sender, EventArgs e);

	private delegate void Delegate30(object sender, EventArgs e);

	private delegate void Delegate31(object sender, EventArgs e);

	private MenuNode menuNode_0;

	private Setting setting_0;

	private string string_0;

	private List<(Class287, string)> list_0;

	private Class136 class136_0 = new Class136();

	private bool bool_0;

	private bool bool_1;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	private IContainer icontainer_0;

	public Control5()
	{
		method_13();
		class136_0.Left = 0;
		class136_0.Top = 0;
		Controls.Add(class136_0);
		class136_0.method_0(method_10);
	}

	[SpecialName]
	internal MenuNode method_0()
	{
		return menuNode_0;
	}

	internal void method_1(MenuNode menuNode_1)
	{
		class136_0.BackColor = Form23.color_32;
		menuNode_0 = menuNode_1;
		setting_0 = menuNode_0.method_1().method_31(menuNode_0.method_73());
		method_2();
		class136_0.method_2();
		Width = class136_0.Width;
		Height = class136_0.Height;
		Visible = setting_0.method_35();
		setting_0.method_265(method_4);
		setting_0.method_264(method_4);
		setting_0.method_41(method_5);
		setting_0.method_40(method_5);
		Form23.smethod_90(method_3);
		Form23.smethod_89(method_3);
	}

	private void method_2()
	{
		list_0 = Class286.smethod_9(menuNode_0, setting_0, bool_0: false);
		class136_0.method_8();
		Bitmap bitmap = new Bitmap(140, 140);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			using Font font = new Font(Font.FontFamily, 20f);
			using SolidBrush brush = new SolidBrush(Form23.color_12);
			using StringFormat stringFormat = new StringFormat();
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			graphics.Clear(Form23.color_32);
			graphics.DrawString(Class333.smethod_561(), font, brush, 70f, 70f, stringFormat);
		}
		class136_0.method_7(bitmap, Class333.smethod_561(), null);
		foreach (var item2 in list_0)
		{
			Class287 item = item2.Item1;
			if (item.BcF.method_20())
			{
				class136_0.method_7(Class288.smethod_1(item), item.BcF.BcC[Class333.smethod_562()].Bsp, item);
			}
		}
		if (!bool_1)
		{
			method_6();
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			Delegate29 method = method_3;
			BeginInvoke(method, sender, e);
		}
		else
		{
			string string_ = string_0;
			bool_1 = true;
			method_2();
			method_7(string_);
			bool_1 = false;
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate30 method = method_4;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_6();
	}

	private void method_5(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate31 method = method_5;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		Visible = setting_0.method_35();
	}

	private void method_6()
	{
		if (setting_0 != null)
		{
			string text = Class24.smethod_0(setting_0.method_259());
			if (text != Class333.smethod_563())
			{
				bool_0 = true;
				method_7(text);
				bool_0 = false;
			}
		}
	}

	private void method_7(string string_1)
	{
		bool flag = string_1 == null || string_1 == Class333.smethod_563();
		int num = 0;
		while (true)
		{
			if (num < class136_0.method_14())
			{
				Class287 @class = class136_0.method_13(num) as Class287;
				if ((!flag && @class != null && string_1 == @class.BcF.BCw) || (flag && @class == null))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		if (class136_0.method_5() != num)
		{
			class136_0.method_6(num);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_8(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_9(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private void method_10(object sender, EventArgs e)
	{
		if (class136_0.method_5() != -1 && !bool_0 && !bool_1)
		{
			object obj = class136_0.method_13(class136_0.method_5());
			if (obj == null)
			{
				string_0 = Class333.smethod_563();
				method_12();
			}
			else if (obj is Class287)
			{
				Class287 @class = obj as Class287;
				string_0 = @class.BcF.BCw;
				method_12();
			}
		}
		if (eventHandler_0 != null)
		{
			eventHandler_0(null, null);
		}
	}

	[SpecialName]
	internal string method_11()
	{
		return string_0;
	}

	private void method_12()
	{
		bool flag = string_0 == Class333.smethod_563();
		menuNode_0.method_1().method_48(menuNode_0.method_1().aWS);
		menuNode_0.method_1().method_55();
		menuNode_0.method_0().method_1();
		if (flag)
		{
			if (setting_0 != null)
			{
				if (Form48.smethod_2() && menuNode_0.method_1().awF.ContainsKey(setting_0.method_8()))
				{
					Class256 @class = menuNode_0.method_1().awF[setting_0.method_8()];
					System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
					foreach (Setting item in @class.method_88(menuNode_0, bool_0: true))
					{
						if (!item.method_219() && (item.method_246(bool_0: true) || item.method_134().Count != 0))
						{
							Form23.smethod_75(item.method_69());
						}
					}
				}
				setting_0.method_279(bool_0: true);
				menuNode_0.method_81();
				menuNode_0.method_95(bool_0: false);
				menuNode_0.method_85(bool_0: false);
				Form23.smethod_74(setting_0.method_64());
			}
		}
		else
		{
			Class286 class2 = null;
			lock (Form23.object_0)
			{
				if (Form23.dictionary_1.ContainsKey(string_0))
				{
					class2 = Form23.dictionary_1[string_0].BcF;
				}
			}
			if (class2 != null && setting_0 != null)
			{
				System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
				if (menuNode_0.method_1().awv.Count != 0)
				{
					Class288.smethod_0(new Class287
					{
						BcF = class2,
						Bcf = Form23.dictionary_1[string_0].Bcf
					}, menuNode_0.method_1());
				}
				byte[] byte_ = Class24.smethod_1(string_0);
				setting_0.method_275(byte_, bool_0: true);
				class2.method_5(menuNode_0);
				Form23.smethod_74(setting_0.method_64());
				System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
			}
		}
		menuNode_0.method_1().method_54(bool_0: true);
		menuNode_0.method_1().method_49(menuNode_0.method_1().aWS);
		menuNode_0.method_0().method_4();
	}

	protected override void Dispose(bool disposing)
	{
		if (setting_0 != null)
		{
			setting_0.method_265(method_4);
			setting_0.method_41(method_5);
		}
		Form23.smethod_90(method_3);
		class136_0.method_1(method_10);
		class136_0.method_8();
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_13()
	{
		icontainer_0 = new Container();
		AutoScaleMode = AutoScaleMode.Font;
	}
}
