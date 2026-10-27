using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using B;
using a;

namespace NSP.UserInterface;

public class DataGridViewWithThemedScrollBars : DataGridView
{
	private delegate void A();

	private aQ Ev = new aQ();

	private aR EW = new aR();

	private Panel Ew = new Panel();

	private bool EX;

	private bool Ex;

	public DataGridViewWithThemedScrollBars()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		((DataGridView)this).ShowCellToolTips = false;
		((Control)this).DoubleBuffered = true;
		_ = ((Control)Ev).Handle;
		_ = ((Control)EW).Handle;
		_ = ((Control)Ew).Handle;
		_ = ((Control)this).Handle;
	}

	private int A()
	{
		int num = 0;
		for (int i = 0; i < ((DataGridView)this).ColumnCount; i++)
		{
			if (((DataGridViewBand)((DataGridView)this).Columns[i]).Visible)
			{
				num += ((DataGridView)this).Columns[i].Width;
			}
		}
		return (((DataGridView)this).RowHeadersVisible ? ((DataGridView)this).RowHeadersWidth : 0) + num;
	}

	private int a()
	{
		int num = 0;
		for (int i = 0; i < ((DataGridView)this).RowCount; i++)
		{
			if (((DataGridViewBand)((DataGridView)this).Rows[i]).Visible)
			{
				num += ((DataGridView)this).Rows[i].Height;
			}
		}
		return (((DataGridView)this).ColumnHeadersVisible ? ((DataGridView)this).ColumnHeadersHeight : 0) + num;
	}

	private HScrollBar B()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
		{
			Control val = item;
			if (val is HScrollBar)
			{
				return (HScrollBar)(object)((val is HScrollBar) ? val : null);
			}
		}
		return null;
	}

	private VScrollBar b()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
		{
			Control val = item;
			if (val is VScrollBar)
			{
				return (VScrollBar)(object)((val is VScrollBar) ? val : null);
			}
		}
		return null;
	}

	internal void C()
	{
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected O, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected O, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected O, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected O, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected O, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected O, but got Unknown
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Invalid comparison between Unknown and I4
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = C;
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
		int num3 = 0;
		int num4 = 0;
		try
		{
			num3 = A();
			num4 = this.a();
		}
		catch
		{
		}
		HScrollBar val = B();
		VScrollBar val2 = b();
		bool flag = ((val != null && ((Control)val).Visible) || num3 > ((Control)this).Width) && ((int)((DataGridView)this).ScrollBars == 3 || (int)((DataGridView)this).ScrollBars == 1);
		bool flag2 = ((val2 != null && ((Control)val2).Visible) || num4 > ((Control)this).Height) && ((int)((DataGridView)this).ScrollBars == 3 || (int)((DataGridView)this).ScrollBars == 2);
		if (BM.Tn != 0 && BM.Tn != BM.r.Bqh)
		{
			if (flag)
			{
				try
				{
					if (!((Control)Ev).IsDisposed && !((Control)Ev).Disposing)
					{
						((Control)Ev).Visible = ((Control)this).Visible;
						((Control)Ev).Left = num;
						((Control)Ev).Top = num2 + (((Control)this).Height - ((Control)Ev).Height);
						((Control)Ev).Width = (flag2 ? (((Control)this).Width - ((Control)EW).Width) : ((Control)this).Width);
						Ev.a(new EventHandler(A));
						Ev.A(new EventHandler(A));
						Ev.B(0);
						Ev.a(((Control)this).Width / 40);
						Ev.A((int)((float)((Control)this).Width / 3f));
						Ev.b(num3 - ((Control)this).Width + Ev.A());
						if (flag2)
						{
							aQ ev = Ev;
							ev.b(ev.b() + ((Control)EW).Width);
						}
						Ev.C(((ScrollBar)val).Value);
						if (parent != null && !parent.Controls.Contains((Control)(object)Ev))
						{
							parent.Controls.Add((Control)(object)Ev);
						}
						((Control)Ev).BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!((Control)Ev).IsDisposed && !((Control)Ev).Disposing)
			{
				try
				{
					((Control)Ev).Visible = false;
				}
				catch
				{
				}
			}
			if (flag2)
			{
				try
				{
					if (!((Control)EW).IsDisposed && !((Control)EW).Disposing)
					{
						((Control)EW).Visible = ((Control)this).Visible;
						((Control)EW).Left = num + (((Control)this).Width - ((Control)EW).Width);
						((Control)EW).Top = num2;
						((Control)EW).Height = (flag ? (((Control)this).Height - ((Control)Ev).Height) : ((Control)this).Height);
						EW.a(new EventHandler(this.a));
						EW.A(new EventHandler(this.a));
						EW.B(0);
						EW.a(((Control)this).Height / 40);
						EW.A((int)((float)((Control)this).Height / 3f));
						EW.b(num4 - ((Control)this).Height + EW.A());
						if (flag)
						{
							aR eW = EW;
							eW.b(eW.b() + ((Control)Ev).Height);
						}
						EW.C(((ScrollBar)val2).Value);
						if (parent != null && !parent.Controls.Contains((Control)(object)EW))
						{
							parent.Controls.Add((Control)(object)EW);
						}
						((Control)EW).BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!((Control)EW).IsDisposed && !((Control)EW).Disposing)
			{
				try
				{
					((Control)EW).Visible = false;
				}
				catch
				{
				}
			}
			if (flag && flag2)
			{
				try
				{
					if (!((Control)Ew).IsDisposed && !((Control)Ew).Disposing)
					{
						((Control)Ew).Visible = ((Control)this).Visible;
						Ew.BorderStyle = (BorderStyle)0;
						((Control)Ew).BackColor = BM.tl;
						((Control)Ew).Size = new Size(((Control)EW).Width, ((Control)Ev).Height);
						((Control)Ew).Left = ((Control)Ev).Right;
						((Control)Ew).Top = ((Control)EW).Bottom;
						if (parent != null && !parent.Controls.Contains((Control)(object)Ew))
						{
							parent.Controls.Add((Control)(object)Ew);
						}
						((Control)Ew).BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!((Control)Ew).IsDisposed && !((Control)Ew).Disposing)
			{
				try
				{
					((Control)Ew).Visible = false;
				}
				catch
				{
				}
			}
			((DataGridView)this).SelectionChanged -= new EventHandler(B);
			((DataGridView)this).SelectionChanged += new EventHandler(B);
			((Control)this).MouseWheel -= new MouseEventHandler(A);
			((Control)this).MouseWheel += new MouseEventHandler(A);
			((Control)this).VisibleChanged -= new EventHandler(b);
			((Control)this).VisibleChanged += new EventHandler(b);
			((Control)this).Layout -= new LayoutEventHandler(C);
			((Control)this).Layout += new LayoutEventHandler(C);
			((Control)this).Resize -= new EventHandler(C);
			((Control)this).Resize += new EventHandler(C);
		}
		else
		{
			if (!((Control)Ev).IsDisposed && !((Control)Ev).Disposing)
			{
				try
				{
					((Control)Ev).Visible = false;
				}
				catch
				{
				}
				try
				{
					if (parent != null && parent.Controls.Contains((Control)(object)Ev))
					{
						parent.Controls.Remove((Control)(object)Ev);
					}
				}
				catch
				{
				}
			}
			if (!((Control)EW).IsDisposed && !((Control)EW).Disposing)
			{
				try
				{
					((Control)EW).Visible = false;
				}
				catch
				{
				}
				try
				{
					if (parent != null && parent.Controls.Contains((Control)(object)EW))
					{
						parent.Controls.Remove((Control)(object)EW);
					}
				}
				catch
				{
				}
			}
			if (!((Control)Ew).IsDisposed && !((Control)Ew).Disposing)
			{
				try
				{
					((Control)Ew).Visible = false;
				}
				catch
				{
				}
				try
				{
					if (parent != null && parent.Controls.Contains((Control)(object)Ew))
					{
						parent.Controls.Remove((Control)(object)Ew);
					}
				}
				catch
				{
				}
			}
		}
		EX = flag;
		Ex = flag2;
	}

	protected override void Dispose(bool disposing)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		try
		{
			Ev.a(new EventHandler(A));
			EW.a(new EventHandler(a));
			((DataGridView)this).SelectionChanged -= new EventHandler(B);
			((Control)this).MouseWheel -= new MouseEventHandler(A);
			((Control)this).VisibleChanged -= new EventHandler(b);
			((Control)this).Layout -= new LayoutEventHandler(C);
			((Control)this).Resize -= new EventHandler(C);
		}
		catch
		{
		}
		if (BM.Tn != 0 && BM.Tn != BM.r.Bqh)
		{
			try
			{
				((Component)EW).Dispose();
			}
			catch
			{
			}
			try
			{
				((Component)Ev).Dispose();
			}
			catch
			{
			}
		}
		try
		{
			((DataGridView)this).Dispose(disposing);
		}
		catch
		{
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		HScrollBar val = B();
		if (val != null)
		{
			((ScrollBar)val).Value = Math.Max(Math.Min(Ev.C(), ((ScrollBar)val).Maximum), ((ScrollBar)val).Minimum);
			int num = 0;
			for (int i = 0; i < ((DataGridView)this).ColumnCount; i++)
			{
				if (((ScrollBar)val).Value <= num)
				{
					if (((DataGridViewBand)((DataGridView)this).Columns[i]).Visible)
					{
						((DataGridView)this).FirstDisplayedScrollingColumnIndex = i;
					}
					if (i == 0)
					{
						((DataGridView)this).HorizontalScrollingOffset = 0;
					}
					break;
				}
				if (((DataGridViewBand)((DataGridView)this).Columns[i]).Visible)
				{
					num += ((DataGridView)this).Columns[i].Width;
				}
			}
			((Control)Ev).Invalidate();
		}
		((Control)this).Invalidate();
	}

	private void a(object P_0, EventArgs P_1)
	{
		VScrollBar val = b();
		if (val != null)
		{
			((ScrollBar)val).Value = Math.Max(Math.Min(EW.C(), ((ScrollBar)val).Maximum), ((ScrollBar)val).Minimum);
			int num = 0;
			for (int i = 0; i < ((DataGridView)this).RowCount; i++)
			{
				if (((ScrollBar)val).Value <= num)
				{
					if (((DataGridViewBand)((DataGridView)this).Rows[i]).Visible)
					{
						((DataGridView)this).FirstDisplayedScrollingRowIndex = i;
					}
					break;
				}
				if (((DataGridViewBand)((DataGridView)this).Rows[i]).Visible)
				{
					num += ((DataGridView)this).Rows[i].Height;
				}
			}
			((Control)EW).Invalidate();
		}
		((Control)this).Invalidate();
	}

	private void B(object P_0, EventArgs P_1)
	{
		HScrollBar val = B();
		VScrollBar val2 = b();
		if (val != null)
		{
			Ev.C(((ScrollBar)val).Value);
		}
		if (val2 != null)
		{
			EW.C(((ScrollBar)val2).Value);
		}
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		C();
		((Control)this).Invalidate();
	}

	private void b(object P_0, EventArgs P_1)
	{
		if (!((Control)this).Visible)
		{
			((Control)Ev).Visible = false;
			((Control)EW).Visible = false;
			((Control)Ew).Visible = false;
		}
		else
		{
			C();
		}
	}

	private void C(object P_0, EventArgs P_1)
	{
		C();
	}

	[SpecialName]
	internal bool c()
	{
		return EX;
	}

	[SpecialName]
	internal bool D()
	{
		return Ex;
	}
}
