using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using B;
using a;

namespace NSP.UserInterface;

public class TableLayoutPanelWithThemedScrollBars : TableLayoutPanel
{
	private delegate void A();

	[CompilerGenerated]
	private bool JR = true;

	private aQ Jr = new aQ();

	private aR JS = new aR();

	private Panel Js = new Panel();

	[SpecialName]
	[CompilerGenerated]
	internal bool A()
	{
		return JR;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(bool P_0)
	{
		JR = P_0;
	}

	public TableLayoutPanelWithThemedScrollBars()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		((ScrollableControl)this).AutoScroll = true;
		((Control)this).MouseWheel += new MouseEventHandler(A);
		((Control)this).VisibleChanged += new EventHandler(B);
		((Control)this).Layout += new LayoutEventHandler(b);
		((Control)this).Resize += new EventHandler(b);
		_ = ((Control)Jr).Handle;
		_ = ((Control)JS).Handle;
		_ = ((Control)Js).Handle;
		_ = ((Control)this).Handle;
	}

	[DllImport("user32.dll")]
	public static extern short GetKeyState(Keys key);

	protected override Point ScrollToControl(Control activeControl)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (A() || ((uint)GetKeyState((Keys)9) & 0x8000u) != 0)
		{
			return ((ScrollableControl)this).ScrollToControl(activeControl);
		}
		return ((ScrollableControl)this).AutoScrollPosition;
	}

	internal void a()
	{
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = this.a;
				((Control)this).Invoke((System.Delegate)a);
				return;
			}
			catch
			{
				return;
			}
		}
		Control parent = ((Control)this).Parent;
		int num = ((Control)this).Left;
		int num2 = ((Control)this).Top;
		while (parent != null && (parent is FlowLayoutPanel || parent is TableLayoutPanel))
		{
			num += parent.Left;
			num2 += parent.Top;
			parent = parent.Parent;
		}
		if (BM.Tn != 0 && BM.Tn != BM.r.Bqh)
		{
			bool visible = ((ScrollProperties)((ScrollableControl)this).HorizontalScroll).Visible;
			bool visible2 = ((ScrollProperties)((ScrollableControl)this).VerticalScroll).Visible;
			Point autoScrollPosition;
			if (visible)
			{
				int num3 = 0;
				try
				{
					foreach (Control item in (ArrangedElementCollection)((TableLayoutPanel)this).Controls)
					{
						Control val = item;
						int num4 = num3;
						int right = val.Right;
						autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
						num3 = Math.Max(num4, right - ((Point)(ref autoScrollPosition)).X);
					}
				}
				catch
				{
				}
				try
				{
					if (!((Control)Jr).IsDisposed && !((Control)Jr).Disposing)
					{
						((Control)Jr).Visible = ((Control)this).Visible;
						((Control)Jr).Left = num;
						((Control)Jr).Top = num2 + (((Control)this).Height - ((Control)Jr).Height) - 1;
						((Control)Jr).Width = (visible2 ? (((Control)this).Width - ((Control)JS).Width) : ((Control)this).Width);
						Jr.a(new EventHandler(A));
						Jr.A(new EventHandler(A));
						Jr.B(0);
						Jr.a(((Control)this).Width / 40);
						Jr.A((int)((float)((Control)this).Width / 3f));
						Jr.b(num3 - ((Control)this).Width + Jr.A());
						if (visible2)
						{
							aQ jr = Jr;
							jr.b(jr.b() + ((Control)JS).Width);
						}
						aQ jr2 = Jr;
						autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
						jr2.C(-((Point)(ref autoScrollPosition)).X);
						if (parent != null && !parent.Controls.Contains((Control)(object)Jr))
						{
							parent.Controls.Add((Control)(object)Jr);
						}
						((Control)Jr).BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!((Control)Jr).IsDisposed && !((Control)Jr).Disposing)
			{
				try
				{
					((Control)Jr).Visible = false;
				}
				catch
				{
				}
			}
			if (visible2)
			{
				int num5 = 0;
				try
				{
					foreach (Control item2 in (ArrangedElementCollection)((TableLayoutPanel)this).Controls)
					{
						Control val2 = item2;
						int num6 = num5;
						int bottom = val2.Bottom;
						autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
						num5 = Math.Max(num6, bottom - ((Point)(ref autoScrollPosition)).Y);
					}
				}
				catch
				{
				}
				try
				{
					if (!((Control)JS).IsDisposed && !((Control)JS).Disposing)
					{
						((Control)JS).Visible = ((Control)this).Visible;
						((Control)JS).Left = num + (((Control)this).Width - ((Control)JS).Width) - 1;
						((Control)JS).Top = num2;
						((Control)JS).Height = (visible ? (((Control)this).Height - ((Control)Jr).Height) : ((Control)this).Height);
						JS.a(new EventHandler(this.a));
						JS.A(new EventHandler(this.a));
						JS.B(0);
						JS.a(((Control)this).Height / 40);
						JS.A((int)((float)((Control)this).Height / 3f));
						JS.b(num5 - ((Control)this).Height + JS.A());
						if (visible)
						{
							aR jS = JS;
							jS.b(jS.b() + ((Control)Jr).Height);
						}
						aR jS2 = JS;
						autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
						jS2.C(-((Point)(ref autoScrollPosition)).Y);
						if (parent != null && !parent.Controls.Contains((Control)(object)JS))
						{
							parent.Controls.Add((Control)(object)JS);
						}
						((Control)JS).BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!((Control)JS).IsDisposed && !((Control)JS).Disposing)
			{
				try
				{
					((Control)JS).Visible = false;
				}
				catch
				{
				}
			}
			if (visible && visible2)
			{
				try
				{
					if (!((Control)Js).IsDisposed && !((Control)Js).Disposing)
					{
						((Control)Js).Visible = ((Control)this).Visible;
						Js.BorderStyle = (BorderStyle)0;
						((Control)Js).BackColor = BM.tl;
						((Control)Js).Size = new Size(((Control)JS).Width - 1, ((Control)Jr).Height - 1);
						((Control)Js).Left = ((Control)Jr).Right;
						((Control)Js).Top = ((Control)JS).Bottom;
						if (parent != null && !parent.Controls.Contains((Control)(object)Js))
						{
							parent.Controls.Add((Control)(object)Js);
						}
						((Control)Js).BringToFront();
					}
					return;
				}
				catch
				{
					return;
				}
			}
			if (!((Control)Js).IsDisposed && !((Control)Js).Disposing)
			{
				try
				{
					((Control)Js).Visible = false;
					return;
				}
				catch
				{
					return;
				}
			}
			return;
		}
		if (!((Control)Jr).IsDisposed && !((Control)Jr).Disposing)
		{
			try
			{
				((Control)Jr).Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains((Control)(object)Jr))
				{
					parent.Controls.Remove((Control)(object)Jr);
				}
			}
			catch
			{
			}
		}
		if (!((Control)JS).IsDisposed && !((Control)JS).Disposing)
		{
			try
			{
				((Control)JS).Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains((Control)(object)JS))
				{
					parent.Controls.Remove((Control)(object)JS);
				}
			}
			catch
			{
			}
		}
		if (((Control)Js).IsDisposed || ((Control)Js).Disposing)
		{
			return;
		}
		try
		{
			((Control)Js).Visible = false;
		}
		catch
		{
		}
		try
		{
			if (parent != null && parent.Controls.Contains((Control)(object)Js))
			{
				parent.Controls.Remove((Control)(object)Js);
			}
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		try
		{
			((Control)this).MouseWheel -= new MouseEventHandler(A);
			((Control)this).VisibleChanged -= new EventHandler(B);
			((Control)this).Layout -= new LayoutEventHandler(b);
			((Control)this).Resize -= new EventHandler(b);
		}
		catch
		{
		}
		if (BM.Tn != 0 && BM.Tn != BM.r.Bqh)
		{
			try
			{
				Jr.a(new EventHandler(A));
				JS.a(new EventHandler(a));
			}
			catch
			{
			}
			try
			{
				((Component)JS).Dispose();
			}
			catch
			{
			}
			try
			{
				((Component)Jr).Dispose();
			}
			catch
			{
			}
		}
		try
		{
			((Control)this).Dispose(disposing);
		}
		catch
		{
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((ScrollableControl)this).AutoScrollPosition = new Point(Jr.C(), ((Control)JS).Visible ? JS.C() : 0);
		((Control)Jr).Invalidate();
	}

	private void a(object P_0, EventArgs P_1)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((ScrollableControl)this).AutoScrollPosition = new Point(((Control)Jr).Visible ? Jr.C() : 0, JS.C());
		((Control)JS).Invalidate();
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		a();
	}

	private void B(object P_0, EventArgs P_1)
	{
		if (!((Control)this).Visible)
		{
			((Control)Jr).Visible = false;
			((Control)JS).Visible = false;
			((Control)Js).Visible = false;
		}
		else
		{
			a();
		}
	}

	private void b(object P_0, EventArgs P_1)
	{
		a();
	}
}
