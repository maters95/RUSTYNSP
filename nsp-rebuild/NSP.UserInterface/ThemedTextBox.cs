using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ns4;

namespace NSP.UserInterface;

public class ThemedTextBox : TextBox
{
	private struct Struct17
	{
		internal int BnH;

		internal int Bnh;

		internal int BnI;

		internal int Bni;
	}

	private struct Struct18
	{
		internal Struct17 BnJ;

		internal Struct17 Bnj;

		internal Struct17 BnK;

		private nint Bnk;
	}

	internal class EventArgs4 : EventArgs
	{
		[CompilerGenerated]
		private string BnL;

		[SpecialName]
		[CompilerGenerated]
		private string method_0()
		{
			return BnL;
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_1(string string_0)
		{
			BnL = string_0;
		}

		internal EventArgs4(string string_0)
		{
			method_1(string_0);
		}
	}

	private bool bool_0;

	[CompilerGenerated]
	private EventHandler<EventArgs4> eventHandler_0;

	protected override void OnEnter(EventArgs eventArgs_0)
	{
		SelectAll();
		bool_0 = true;
		base.OnEnter(eventArgs_0);
	}

	protected override void OnGotFocus(EventArgs eventArgs_0)
	{
		base.OnGotFocus(eventArgs_0);
		SelectAll();
	}

	protected override void OnClick(EventArgs eventArgs_0)
	{
		base.OnClick(eventArgs_0);
		if (bool_0)
		{
			SelectAll();
			bool_0 = false;
		}
	}

	[DllImport("user32")]
	private static extern nint GetWindowDC(nint intptr_0);

	[SpecialName]
	[CompilerGenerated]
	internal void method_0(EventHandler<EventArgs4> eventHandler_1)
	{
		EventHandler<EventArgs4> eventHandler = eventHandler_0;
		EventHandler<EventArgs4> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs4> value = (EventHandler<EventArgs4>)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(EventHandler<EventArgs4> eventHandler_1)
	{
		EventHandler<EventArgs4> eventHandler = eventHandler_0;
		EventHandler<EventArgs4> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs4> value = (EventHandler<EventArgs4>)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	protected override void WndProc(ref Message msg)
	{
		if (msg.Msg == 131)
		{
			if (msg.WParam == IntPtr.Zero)
			{
				Struct17 structure = (Struct17)Marshal.PtrToStructure(msg.LParam, typeof(Struct17));
				structure.BnH++;
				structure.BnI--;
				structure.Bnh++;
				structure.Bni--;
				Marshal.StructureToPtr(structure, msg.LParam, fDeleteOld: false);
			}
			else
			{
				Struct18 structure2 = (Struct18)Marshal.PtrToStructure(msg.LParam, typeof(Struct18));
				structure2.BnJ.BnH++;
				structure2.BnJ.BnI--;
				structure2.BnJ.Bnh++;
				structure2.BnJ.Bni--;
				Marshal.StructureToPtr(structure2, msg.LParam, fDeleteOld: false);
			}
		}
		if (msg.Msg == 133)
		{
			nint windowDC = GetWindowDC(Handle);
			if (windowDC == IntPtr.Zero)
			{
				return;
			}
			using Graphics graphics = Graphics.FromHdc(windowDC);
			ControlPaint.DrawBorder(graphics, new Rectangle(0, 0, Size.Width, Size.Height), Form23.color_32, 4, ButtonBorderStyle.Solid, Form23.color_32, 4, ButtonBorderStyle.Solid, Form23.color_32, 4, ButtonBorderStyle.Solid, Form23.color_32, 4, ButtonBorderStyle.Solid);
			ControlPaint.DrawBorder(graphics, new Rectangle(0, 0, Size.Width, Size.Height), Color.Gray, 1, ButtonBorderStyle.Solid, Color.Gray, 1, ButtonBorderStyle.Solid, Color.Gray, 1, ButtonBorderStyle.Solid, Color.Gray, 1, ButtonBorderStyle.Solid);
			if (BackColor == Form23.color_9)
			{
				ControlPaint.DrawBorder(graphics, new Rectangle(2, 2, Size.Width - 4, Size.Height - 4), Form23.color_9, 3, ButtonBorderStyle.Solid, Form23.color_9, 3, ButtonBorderStyle.Solid, Form23.color_9, 3, ButtonBorderStyle.Solid, Form23.color_9, 3, ButtonBorderStyle.Solid);
			}
			else if (!Enabled)
			{
				ControlPaint.DrawBorder(graphics, new Rectangle(2, 2, Size.Width - 4, Size.Height - 4), Form23.color_35, 3, ButtonBorderStyle.Solid, Form23.color_35, 3, ButtonBorderStyle.Solid, Form23.color_35, 3, ButtonBorderStyle.Solid, Form23.color_35, 3, ButtonBorderStyle.Solid);
			}
			return;
		}
		if (msg.Msg == 770)
		{
			string text = Clipboard.GetText();
			base.WndProc(ref msg);
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, new EventArgs4(text));
			}
		}
		else
		{
			base.WndProc(ref msg);
		}
	}
}
