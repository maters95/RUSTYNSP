using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using B;

namespace NSP.UserInterface;

public class ThemedTextBox : TextBox
{
	private struct A
	{
		internal int BnH;

		internal int Bnh;

		internal int BnI;

		internal int Bni;
	}

	private struct a
	{
		internal A BnJ;

		internal A Bnj;

		internal A BnK;

		private nint Bnk;
	}

	internal class B : EventArgs
	{
		[CompilerGenerated]
		private string BnL;

		[SpecialName]
		[CompilerGenerated]
		private string A()
		{
			return BnL;
		}

		[SpecialName]
		[CompilerGenerated]
		private void A(string P_0)
		{
			BnL = P_0;
		}

		internal B(string P_0)
		{
			A(P_0);
		}
	}

	private bool KC;

	[CompilerGenerated]
	private EventHandler<B> Kc;

	protected override void OnEnter(EventArgs e)
	{
		((TextBoxBase)this).SelectAll();
		KC = true;
		((Control)this).OnEnter(e);
	}

	protected override void OnGotFocus(EventArgs e)
	{
		((TextBox)this).OnGotFocus(e);
		((TextBoxBase)this).SelectAll();
	}

	protected override void OnClick(EventArgs e)
	{
		((Control)this).OnClick(e);
		if (KC)
		{
			((TextBoxBase)this).SelectAll();
			KC = false;
		}
	}

	[DllImport("user32", EntryPoint = "GetWindowDC")]
	private static extern nint A(nint P_0);

	[SpecialName]
	[CompilerGenerated]
	internal void A(EventHandler<B> P_0)
	{
		EventHandler<B> val = Kc;
		EventHandler<B> val2;
		do
		{
			val2 = val;
			EventHandler<B> val3 = (EventHandler<B>)(object)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler<B>>(ref Kc, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(EventHandler<B> P_0)
	{
		EventHandler<B> val = Kc;
		EventHandler<B> val2;
		do
		{
			val2 = val;
			EventHandler<B> val3 = (EventHandler<B>)(object)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler<B>>(ref Kc, val3, val2);
		}
		while (val != val2);
	}

	protected override void WndProc(ref Message msg)
	{
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		if (((Message)(ref msg)).Msg == 131)
		{
			if (((Message)(ref msg)).WParam == System.IntPtr.Zero)
			{
				A a = (A)Marshal.PtrToStructure(((Message)(ref msg)).LParam, typeof(A));
				a.BnH++;
				a.BnI--;
				a.Bnh++;
				a.Bni--;
				Marshal.StructureToPtr<A>(a, ((Message)(ref msg)).LParam, false);
			}
			else
			{
				a a2 = (a)Marshal.PtrToStructure(((Message)(ref msg)).LParam, typeof(a));
				a2.BnJ.BnH++;
				a2.BnJ.BnI--;
				a2.BnJ.Bnh++;
				a2.BnJ.Bni--;
				Marshal.StructureToPtr<a>(a2, ((Message)(ref msg)).LParam, false);
			}
		}
		if (((Message)(ref msg)).Msg == 133)
		{
			nint num = A(((Control)this).Handle);
			if (num == (nint)System.IntPtr.Zero)
			{
				return;
			}
			Graphics val = Graphics.FromHdc((System.IntPtr)num);
			try
			{
				Size size = ((Control)this).Size;
				int width = ((Size)(ref size)).Width;
				size = ((Control)this).Size;
				ControlPaint.DrawBorder(val, new Rectangle(0, 0, width, ((Size)(ref size)).Height), BM.to, 4, (ButtonBorderStyle)3, BM.to, 4, (ButtonBorderStyle)3, BM.to, 4, (ButtonBorderStyle)3, BM.to, 4, (ButtonBorderStyle)3);
				size = ((Control)this).Size;
				int width2 = ((Size)(ref size)).Width;
				size = ((Control)this).Size;
				ControlPaint.DrawBorder(val, new Rectangle(0, 0, width2, ((Size)(ref size)).Height), Color.Gray, 1, (ButtonBorderStyle)3, Color.Gray, 1, (ButtonBorderStyle)3, Color.Gray, 1, (ButtonBorderStyle)3, Color.Gray, 1, (ButtonBorderStyle)3);
				if (((Control)this).BackColor == BM.tD)
				{
					size = ((Control)this).Size;
					int num2 = ((Size)(ref size)).Width - 4;
					size = ((Control)this).Size;
					ControlPaint.DrawBorder(val, new Rectangle(2, 2, num2, ((Size)(ref size)).Height - 4), BM.tD, 3, (ButtonBorderStyle)3, BM.tD, 3, (ButtonBorderStyle)3, BM.tD, 3, (ButtonBorderStyle)3, BM.tD, 3, (ButtonBorderStyle)3);
				}
				else if (!((Control)this).Enabled)
				{
					size = ((Control)this).Size;
					int num3 = ((Size)(ref size)).Width - 4;
					size = ((Control)this).Size;
					ControlPaint.DrawBorder(val, new Rectangle(2, 2, num3, ((Size)(ref size)).Height - 4), BM.tQ, 3, (ButtonBorderStyle)3, BM.tQ, 3, (ButtonBorderStyle)3, BM.tQ, 3, (ButtonBorderStyle)3, BM.tQ, 3, (ButtonBorderStyle)3);
				}
				return;
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		if (((Message)(ref msg)).Msg == 770)
		{
			string text = Clipboard.GetText();
			((TextBox)this).WndProc(ref msg);
			if (Kc != null)
			{
				Kc.Invoke((object)this, new B(text));
			}
		}
		else
		{
			((TextBox)this).WndProc(ref msg);
		}
	}
}
