using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using B;
using a;

namespace A;

internal class W : FlowLayoutPanel
{
	private delegate void A();

	[CompilerGenerated]
	private bool EY = true;

	private aQ Ey = new aQ();

	private aR EZ = new aR();

	private Panel Ez = new Panel();

	[SpecialName]
	[CompilerGenerated]
	internal bool A()
	{
		return EY;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(bool P_0)
	{
		EY = P_0;
	}

	internal W()
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
		_ = ((Control)Ey).Handle;
		_ = ((Control)EZ).Handle;
		_ = ((Control)Ez).Handle;
		_ = ((Control)this).Handle;
	}

	[DllImport("user32.dll", EntryPoint = "GetKeyState")]
	public static extern short A(Keys P_0);

	protected override Point ScrollToControl(Control activeControl)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (A() || ((uint)A((Keys)9) & 0x8000u) != 0)
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
				A a2 = a;
				((Control)this).Invoke((System.Delegate)a2);
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
					foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
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
					if (!((Control)Ey).IsDisposed && !((Control)Ey).Disposing)
					{
						((Control)Ey).Visible = ((Control)this).Visible;
						((Control)Ey).Left = num;
						((Control)Ey).Top = num2 + (((Control)this).Height - ((Control)Ey).Height) - 1;
						((Control)Ey).Width = (visible2 ? (((Control)this).Width - ((Control)EZ).Width) : ((Control)this).Width);
						Ey.a(new EventHandler(A));
						Ey.A(new EventHandler(A));
						Ey.B(0);
						Ey.a(((Control)this).Width / 40);
						Ey.A((int)((float)((Control)this).Width / 3f));
						Ey.b(num3 - ((Control)this).Width + Ey.A());
						if (visible2)
						{
							aQ ey = Ey;
							ey.b(ey.b() + ((Control)EZ).Width);
						}
						aQ ey2 = Ey;
						autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
						ey2.C(-((Point)(ref autoScrollPosition)).X);
						if (parent != null && !parent.Controls.Contains((Control)(object)Ey))
						{
							parent.Controls.Add((Control)(object)Ey);
						}
						((Control)Ey).BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!((Control)Ey).IsDisposed && !((Control)Ey).Disposing)
			{
				try
				{
					((Control)Ey).Visible = false;
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
					foreach (Control item2 in (ArrangedElementCollection)((Control)this).Controls)
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
					if (!((Control)EZ).IsDisposed && !((Control)EZ).Disposing)
					{
						((Control)EZ).Visible = ((Control)this).Visible;
						((Control)EZ).Left = num + (((Control)this).Width - ((Control)EZ).Width) - 1;
						((Control)EZ).Top = num2;
						((Control)EZ).Height = (visible ? (((Control)this).Height - ((Control)Ey).Height) : ((Control)this).Height);
						EZ.a(new EventHandler(a));
						EZ.A(new EventHandler(a));
						EZ.B(0);
						EZ.a(((Control)this).Height / 40);
						EZ.A((int)((float)((Control)this).Height / 3f));
						EZ.b(num5 - ((Control)this).Height + EZ.A());
						if (visible)
						{
							aR eZ = EZ;
							eZ.b(eZ.b() + ((Control)Ey).Height);
						}
						aR eZ2 = EZ;
						autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
						eZ2.C(-((Point)(ref autoScrollPosition)).Y);
						if (parent != null && !parent.Controls.Contains((Control)(object)EZ))
						{
							parent.Controls.Add((Control)(object)EZ);
						}
						((Control)EZ).BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!((Control)EZ).IsDisposed && !((Control)EZ).Disposing)
			{
				try
				{
					((Control)EZ).Visible = false;
				}
				catch
				{
				}
			}
			if (visible && visible2)
			{
				try
				{
					if (!((Control)Ez).IsDisposed && !((Control)Ez).Disposing)
					{
						((Control)Ez).Visible = ((Control)this).Visible;
						Ez.BorderStyle = (BorderStyle)0;
						((Control)Ez).BackColor = BM.tl;
						((Control)Ez).Size = new Size(((Control)EZ).Width - 1, ((Control)Ey).Height - 1);
						((Control)Ez).Left = ((Control)Ey).Right;
						((Control)Ez).Top = ((Control)EZ).Bottom;
						if (parent != null && !parent.Controls.Contains((Control)(object)Ez))
						{
							parent.Controls.Add((Control)(object)Ez);
						}
						((Control)Ez).BringToFront();
					}
					return;
				}
				catch
				{
					return;
				}
			}
			if (!((Control)Ez).IsDisposed && !((Control)Ez).Disposing)
			{
				try
				{
					((Control)Ez).Visible = false;
					return;
				}
				catch
				{
					return;
				}
			}
			return;
		}
		if (!((Control)Ey).IsDisposed && !((Control)Ey).Disposing)
		{
			try
			{
				((Control)Ey).Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains((Control)(object)Ey))
				{
					parent.Controls.Remove((Control)(object)Ey);
				}
			}
			catch
			{
			}
		}
		if (!((Control)EZ).IsDisposed && !((Control)EZ).Disposing)
		{
			try
			{
				((Control)EZ).Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains((Control)(object)EZ))
				{
					parent.Controls.Remove((Control)(object)EZ);
				}
			}
			catch
			{
			}
		}
		if (((Control)Ez).IsDisposed || ((Control)Ez).Disposing)
		{
			return;
		}
		try
		{
			((Control)Ez).Visible = false;
		}
		catch
		{
		}
		try
		{
			if (parent != null && parent.Controls.Contains((Control)(object)Ez))
			{
				parent.Controls.Remove((Control)(object)Ez);
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
				Ey.a(new EventHandler(A));
				EZ.a(new EventHandler(a));
			}
			catch
			{
			}
			try
			{
				((Component)EZ).Dispose();
			}
			catch
			{
			}
			try
			{
				((Component)Ey).Dispose();
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
		((ScrollableControl)this).AutoScrollPosition = new Point(Ey.C(), ((Control)EZ).Visible ? EZ.C() : 0);
		((Control)Ey).Invalidate();
	}

	private void a(object P_0, EventArgs P_1)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((ScrollableControl)this).AutoScrollPosition = new Point(((Control)Ey).Visible ? Ey.C() : 0, EZ.C());
		((Control)EZ).Invalidate();
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		a();
	}

	private void B(object P_0, EventArgs P_1)
	{
		if (!((Control)this).Visible)
		{
			((Control)Ey).Visible = false;
			((Control)EZ).Visible = false;
			((Control)Ez).Visible = false;
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
internal enum w
{
	eA,
	ea,
	eB
}
