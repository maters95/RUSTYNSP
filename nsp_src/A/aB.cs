using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;

namespace a;

internal class aB
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A BLd = new A();

		public static Func<aa, Color> BLE;

		public static Func<aa, bool> BLe;

		public static Action<aa> BLF;

		internal Color A(aa P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return P_0.A();
		}

		internal bool a(aa P_0)
		{
			return P_0.B();
		}

		internal void B(aa P_0)
		{
			P_0.A(false);
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public bool BLf;

		internal void A(aa P_0)
		{
			P_0.A(BLf);
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public Color BLG;

		internal void A(aa P_0)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			P_0.A(BLG);
		}
	}

	private List<aa> Gc;

	[CompilerGenerated]
	private bool GD;

	[SpecialName]
	internal int A()
	{
		return Gc.Count;
	}

	[SpecialName]
	internal List<Color> a()
	{
		return Enumerable.ToList<Color>(Enumerable.Select<aa, Color>((System.Collections.Generic.IEnumerable<aa>)Gc, (Func<aa, Color>)((aa P_0) => P_0.A())));
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool B()
	{
		return GD;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(bool P_0)
	{
		GD = P_0;
	}

	[SpecialName]
	internal List<bool> b()
	{
		return Enumerable.ToList<bool>(Enumerable.Select<aa, bool>((System.Collections.Generic.IEnumerable<aa>)Gc, (Func<aa, bool>)((aa P_0) => P_0.B())));
	}

	internal aB(int P_0, Color[] P_1, bool P_2, int P_3)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (P_1.Length != P_0)
		{
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eE());
		}
		A(P_0);
		Gc.ForEach((Action<aa>)delegate(aa P_0)
		{
			P_0.A(P_2);
		});
		A(P_2);
		for (int i = 0; i < P_0; i++)
		{
			Gc[i].a((P_3 & (1 << i)) > 0);
			Gc[i].A(P_1[i]);
		}
	}

	internal aB(int P_0, int[] P_1, int P_2)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (P_1.Length != P_0)
		{
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eE());
		}
		A(P_0);
		Gc.ForEach((Action<aa>)delegate(aa P_0)
		{
			P_0.A(false);
		});
		for (int i = 0; i < P_0; i++)
		{
			Gc[i].a((P_2 & (1 << i)) > 0);
			Gc[i].A(aa.A(P_1[i]));
		}
	}

	internal aB(int P_0, Color P_1, bool P_2, int P_3)
		: this(P_0, Enumerable.ToArray<Color>(Enumerable.Repeat<Color>(P_1, P_0)), P_2, P_3)
	{
	}//IL_0002: Unknown result type (might be due to invalid IL or missing references)


	internal aB(int P_0, int P_1, int P_2, int P_3)
		: this(P_0, aa.A(P_1), P_2 == 1, P_3)
	{
	}//IL_0003: Unknown result type (might be due to invalid IL or missing references)


	private void A(int P_0)
	{
		Gc = new List<aa>(P_0);
		for (int i = 0; i < P_0; i++)
		{
			Gc.Add(new aa());
		}
	}

	internal void A(int P_0, bool P_1)
	{
		Gc[P_0].a(P_1);
	}

	internal int C()
	{
		int num = 0;
		for (int i = 0; i < Gc.Count; i++)
		{
			num |= (int)((Gc[i].B() ? 1u : 0u) << i);
		}
		return num;
	}

	internal void a(int P_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		Color BLG = aa.A(P_0);
		Gc.ForEach((Action<aa>)delegate(aa P_0)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			P_0.A(BLG);
		});
	}

	internal void A(int P_0, int P_1)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		Gc[P_0].A(aa.A(P_1));
	}

	internal Color B(int P_0)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!Gc[P_0].B())
		{
			return aa.A(0);
		}
		return Gc[P_0].A();
	}
}
internal class ab : ListView
{
	private delegate void A();

	private aR Gd = new aR();

	private aQ GE = new aQ();

	private Panel Ge = new Panel();

	private const int GF = -16;

	private const int Gf = 1048576;

	private const int GG = 2097152;

	private const int Gg = 0;

	private const int GH = 1;

	private const int Gh = 4096;

	private const int GI = 4116;

	private int Gi;

	internal ab()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		((Control)this).DoubleBuffered = true;
		((ListView)this).Scrollable = true;
		((ListView)this).SelectedIndexChanged += new EventHandler(B);
		((Control)this).MouseWheel += new MouseEventHandler(A);
		((Control)this).VisibleChanged += new EventHandler(b);
		((Control)this).KeyDown += new KeyEventHandler(A);
		_ = ((Control)GE).Handle;
		_ = ((Control)Gd).Handle;
		_ = ((Control)Ge).Handle;
		_ = ((Control)this).Handle;
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
			((ListView)this).SelectedIndexChanged -= new EventHandler(B);
			((Control)this).MouseWheel -= new MouseEventHandler(A);
			((Control)this).VisibleChanged -= new EventHandler(b);
			((Control)this).KeyDown -= new KeyEventHandler(A);
		}
		catch
		{
		}
		if (BM.Tn != 0 && BM.Tn != BM.r.Bqh)
		{
			try
			{
				GE.a(new EventHandler(A));
				Gd.a(new EventHandler(a));
			}
			catch
			{
			}
			try
			{
				((Component)Gd).Dispose();
			}
			catch
			{
			}
			try
			{
				((Component)GE).Dispose();
			}
			catch
			{
			}
		}
		try
		{
			((ListView)this).Dispose(disposing);
		}
		catch
		{
		}
	}

	[DllImport("user32.dll", CharSet = 4, EntryPoint = "GetWindowLong")]
	private static extern int A(nint P_0, int P_1);

	[DllImport("user32.dll", CharSet = 3, EntryPoint = "GetScrollPos")]
	private static extern int a(nint P_0, int P_1);

	[DllImport("user32.dll", CharSet = 3, EntryPoint = "SendMessage")]
	private static extern nint A(nint P_0, int P_1, nint P_2, nint P_3);

	private int A()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		int num = 0;
		foreach (ColumnHeader column in ((ListView)this).Columns)
		{
			ColumnHeader val = column;
			num += val.Width;
		}
		return num;
	}

	internal void a()
	{
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
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
			bool flag;
			bool flag2;
			try
			{
				int num3 = A(((Control)this).Handle, -16);
				flag = (num3 & 0x100000) != 0;
				flag2 = (num3 & 0x200000) != 0;
			}
			catch
			{
				return;
			}
			if (flag)
			{
				try
				{
					if (!((Control)GE).IsDisposed && !((Control)GE).Disposing)
					{
						int num4 = A();
						((Control)GE).Visible = ((Control)this).Visible;
						((Control)GE).Left = num;
						((Control)GE).Top = num2 + (((Control)this).Height - ((Control)GE).Height) - 1;
						((Control)GE).Width = (flag2 ? (((Control)this).Width - ((Control)Gd).Width) : ((Control)this).Width);
						GE.a(new EventHandler(A));
						GE.A(new EventHandler(A));
						GE.B(0);
						GE.a(10);
						GE.A(50);
						GE.b(num4 - ((Control)this).Width + GE.A());
						if (flag2)
						{
							aQ gE = GE;
							gE.b(gE.b() + ((Control)Gd).Width);
						}
						GE.C(ab.a(((Control)this).Handle, 0));
						Gi = GE.C();
						if (parent != null && !parent.Controls.Contains((Control)(object)GE))
						{
							parent.Controls.Add((Control)(object)GE);
						}
						((Control)GE).BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!((Control)GE).IsDisposed && !((Control)GE).Disposing)
			{
				try
				{
					((Control)GE).Visible = false;
				}
				catch
				{
				}
			}
			if (flag2)
			{
				try
				{
					if (!((Control)Gd).IsDisposed && !((Control)Gd).Disposing)
					{
						((Control)Gd).Visible = ((Control)this).Visible;
						((Control)Gd).Left = num + (((Control)this).Width - ((Control)Gd).Width) - 1;
						((Control)Gd).Top = num2;
						((Control)Gd).Height = (flag ? (((Control)this).Height - ((Control)GE).Height) : ((Control)this).Height);
						Gd.a(new EventHandler(this.a));
						Gd.A(new EventHandler(this.a));
						Gd.B(0);
						Gd.a(1);
						Gd.A(10);
						if (((ListView)this).Items.Count >= 2)
						{
							Rectangle bounds = ((ListView)this).Items[1].Bounds;
							int top = ((Rectangle)(ref bounds)).Top;
							bounds = ((ListView)this).Items[0].Bounds;
							int num5 = top - ((Rectangle)(ref bounds)).Top;
							if (num5 != 0)
							{
								int num6 = (((Control)this).Height - 20) / num5;
								Gd.b(((ListView)this).Items.Count - num6 + Gd.A());
								if (flag)
								{
									aR gd = Gd;
									gd.b(gd.b() + ((Control)GE).Height);
								}
								Gd.C(ab.a(((Control)this).Handle, 1));
							}
						}
						if (parent != null && !parent.Controls.Contains((Control)(object)Gd))
						{
							parent.Controls.Add((Control)(object)Gd);
						}
						((Control)Gd).BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!((Control)Gd).IsDisposed && !((Control)Gd).Disposing)
			{
				try
				{
					((Control)Gd).Visible = false;
				}
				catch
				{
				}
			}
			if (flag && flag2)
			{
				try
				{
					if (!((Control)Ge).IsDisposed && !((Control)Ge).Disposing)
					{
						((Control)Ge).Visible = ((Control)this).Visible;
						Ge.BorderStyle = (BorderStyle)0;
						((Control)Ge).BackColor = BM.tl;
						((Control)Ge).Size = new Size(((Control)Gd).Width - 1, ((Control)GE).Height - 1);
						((Control)Ge).Left = ((Control)GE).Right;
						((Control)Ge).Top = ((Control)Gd).Bottom;
						if (parent != null && !parent.Controls.Contains((Control)(object)Ge))
						{
							parent.Controls.Add((Control)(object)Ge);
						}
						((Control)Ge).BringToFront();
					}
					return;
				}
				catch
				{
					return;
				}
			}
			if (!((Control)Ge).IsDisposed && !((Control)Ge).Disposing)
			{
				try
				{
					((Control)Ge).Visible = false;
					return;
				}
				catch
				{
					return;
				}
			}
			return;
		}
		if (!((Control)GE).IsDisposed && !((Control)GE).Disposing)
		{
			try
			{
				((Control)GE).Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains((Control)(object)GE))
				{
					parent.Controls.Remove((Control)(object)GE);
				}
			}
			catch
			{
			}
		}
		if (!((Control)Gd).IsDisposed && !((Control)Gd).Disposing)
		{
			try
			{
				((Control)Gd).Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains((Control)(object)Gd))
				{
					parent.Controls.Remove((Control)(object)Gd);
				}
			}
			catch
			{
			}
		}
		if (((Control)Ge).IsDisposed || ((Control)Ge).Disposing)
		{
			return;
		}
		try
		{
			((Control)Ge).Visible = false;
		}
		catch
		{
		}
		try
		{
			if (parent != null && parent.Controls.Contains((Control)(object)Ge))
			{
				parent.Controls.Remove((Control)(object)Ge);
			}
		}
		catch
		{
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		int num = GE.C() - Gi;
		A(((Control)this).Handle, 4116, num, System.IntPtr.Zero);
		Gi = GE.C();
		((Control)GE).Invalidate();
	}

	private void a(object P_0, EventArgs P_1)
	{
		((ListView)this).TopItem = ((ListView)this).Items[Math.Min(Math.Max(Gd.C(), 0), ((ListView)this).Items.Count - 1)];
		((Control)Gd).Invalidate();
	}

	private void B(object P_0, EventArgs P_1)
	{
		a();
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		a();
	}

	private void b(object P_0, EventArgs P_1)
	{
		if (!((Control)this).Visible)
		{
			((Control)GE).Visible = false;
			((Control)Gd).Visible = false;
			((Control)Ge).Visible = false;
		}
		else
		{
			a();
		}
	}

	private void A(object P_0, KeyEventArgs P_1)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (!P_1.Control || (int)P_1.KeyCode != 65)
		{
			return;
		}
		foreach (ListViewItem item in ((ListView)this).Items)
		{
			item.Selected = true;
		}
	}

	protected override void OnItemDrag(ItemDragEventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		((ListView)this).OnItemDrag(e);
		((Control)this).DoDragDrop((object)((ListView)this).SelectedItems, (DragDropEffects)2);
	}

	protected override void OnDragEnter(DragEventArgs dragEvent)
	{
		((Control)this).OnDragEnter(dragEvent);
		int num = dragEvent.Data.GetFormats().Length - 1;
		for (int i = 0; i <= num; i++)
		{
			if (dragEvent.Data.GetFormats()[i].Equals(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ee()))
			{
				dragEvent.Effect = (DragDropEffects)2;
			}
		}
	}

	protected override void OnDragDrop(DragEventArgs dragEvent)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		if (((ListView)this).SelectedItems.Count == 0)
		{
			return;
		}
		Point val = ((Control)this).PointToClient(new Point(dragEvent.X, dragEvent.Y));
		ListViewItem itemAt = ((ListView)this).GetItemAt(((Point)(ref val)).X, ((Point)(ref val)).Y);
		if (itemAt == null)
		{
			return;
		}
		int index = itemAt.Index;
		ListViewItem[] array = (ListViewItem[])(object)new ListViewItem[((ListView)this).SelectedItems.Count];
		for (int i = 0; i < ((ListView)this).SelectedItems.Count; i++)
		{
			array[i] = ((ListView)this).SelectedItems[i];
		}
		for (int j = 0; j < ((System.Array)array).GetLength(0); j++)
		{
			ListViewItem val2 = array[j];
			int num = index;
			if (num == val2.Index)
			{
				return;
			}
			num = ((val2.Index >= num) ? (index + j) : (num + 1));
			ListViewItem val3 = (ListViewItem)val2.Clone();
			((ListView)this).Items.Insert(num, val3);
			((ListView)this).Items.Remove(val2);
		}
		((Control)this).OnDragDrop(dragEvent);
	}
}
