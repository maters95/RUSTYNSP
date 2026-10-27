using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using A;
using B;
using a;

namespace NSP.UserInterface;

public class TreeViewWithThemedScrollBars : UserControl
{
	private delegate void A();

	private const int kr = 3;

	private const int kS = 84;

	private const int ks = 16;

	private const int kT = 25;

	private const int kt = 16;

	private const int kU = 10;

	private const int ku = 13;

	private const int kV = 15;

	private const int kv = 18;

	private const int kW = 3;

	private const int kw = 3;

	private aW kX;

	private List<TreeNode> kx = new List<TreeNode>();

	private TreeNode kY;

	private bool ky;

	private bool kZ = true;

	private List<Image> kz;

	private TreeNode LA;

	private TreeNode La;

	private Label LB = new Label();

	private Label Lb = new Label();

	private ToolTip LC = new ToolTip();

	private bool Lc;

	private aQ LD = new aQ();

	private aR Ld = new aR();

	private Panel LE = new Panel();

	[CompilerGenerated]
	private TreeViewCancelEventHandler Le;

	[CompilerGenerated]
	private TreeViewEventHandler LF;

	[CompilerGenerated]
	private TreeViewEventHandler Lf;

	[CompilerGenerated]
	private TreeViewEventHandler LG;

	[CompilerGenerated]
	private TreeViewEventHandler Lg;

	[CompilerGenerated]
	private ItemDragEventHandler LH;

	protected int m_mouseDownX = -1;

	protected int m_mouseDownY = -1;

	protected TreeNode m_lastMouseOverTreeNode;

	[CompilerGenerated]
	private DrawTreeNodeEventHandler Lh;

	private const int LI = -16;

	private const int Li = 1048576;

	private const int LJ = 2097152;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((UserControl)this).CreateParams;
			createParams.ExStyle |= 0x2000000;
			return createParams;
		}
	}

	public TreeViewWithThemedScrollBars()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		((Control)this).DoubleBuffered = true;
		((ScrollableControl)this).AutoScroll = true;
		_ = ((Control)LD).Handle;
		_ = ((Control)Ld).Handle;
		_ = ((Control)LE).Handle;
		_ = ((Control)this).Handle;
		((Control)LB).BackColor = Color.Transparent;
		((Control)LB).ForeColor = Color.Transparent;
		((Control)LB).Height = 1;
		((Control)LB).Width = ((Control)this).Width;
		((Control)LB).Left = 0;
		((Control)LB).Top = 0;
		((Control)Lb).BackColor = Color.Transparent;
		((Control)Lb).ForeColor = Color.Transparent;
		((Control)Lb).Height = 1;
		((Control)Lb).Width = ((Control)this).Width;
		((Control)Lb).Left = 0;
		((Control)Lb).Top = ((Control)this).Height - 1;
		LC.InitialDelay = 500;
		LC.ReshowDelay = 500;
		((Control)this).Font = new Font(((Control)this).Font.FontFamily, 9f);
	}

	[SpecialName]
	internal aW A()
	{
		return kX;
	}

	[SpecialName]
	internal void A(aW P_0)
	{
		kX = P_0;
		H();
	}

	[SpecialName]
	internal List<TreeNode> a()
	{
		return kx;
	}

	[SpecialName]
	internal TreeNode B()
	{
		return kY;
	}

	[SpecialName]
	internal void A(TreeNode P_0)
	{
		if (b(P_0))
		{
			A(P_0, (TreeViewAction)0);
		}
	}

	internal void b()
	{
		Lc = true;
	}

	internal void C()
	{
		Lc = false;
		H();
	}

	[SpecialName]
	internal void a(TreeNode P_0)
	{
		LA = P_0;
		((Control)this).Invalidate();
	}

	[SpecialName]
	internal void B(TreeNode P_0)
	{
		La = P_0;
		((Control)this).Invalidate();
	}

	[SpecialName]
	internal bool c()
	{
		return ky;
	}

	[SpecialName]
	internal void A(bool P_0)
	{
		ky = P_0;
		H();
	}

	[SpecialName]
	internal bool D()
	{
		return kZ;
	}

	[SpecialName]
	internal void a(bool P_0)
	{
		kZ = P_0;
	}

	[SpecialName]
	internal List<Image> d()
	{
		return kz;
	}

	[SpecialName]
	internal void A(List<Image> P_0)
	{
		kz = P_0;
	}

	[SpecialName]
	private int E()
	{
		return (int)((Control)this).Font.Size;
	}

	[SpecialName]
	private int e()
	{
		return (int)((Control)this).Font.Size * 3;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 37 || (int)keyData == 39 || (int)keyData == 38 || (int)keyData == 40 || (int)keyData == 32)
		{
			A(keyData);
			return true;
		}
		return ((ContainerControl)this).ProcessCmdKey(ref msg, keyData);
	}

	internal void A(Keys P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		((Control)this).OnKeyDown(new KeyEventArgs(P_0));
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Invalid comparison between Unknown and I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between Unknown and I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Invalid comparison between Unknown and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Invalid comparison between Unknown and I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Invalid comparison between Unknown and I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Invalid comparison between Unknown and I4
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Invalid comparison between Unknown and I4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		((Control)this).OnKeyDown(e);
		if (kY == null)
		{
			return;
		}
		if (((kX == aW.kP || kX == aW.kQ) && (int)e.KeyData == 37) || (kX == aW.kp && (int)e.KeyData == 38))
		{
			if (kY.Nodes.Count != 0 && kY.IsExpanded)
			{
				OnAfterCollapse(new TreeViewEventArgs(kY, (TreeViewAction)1));
			}
			else if (kY.Parent != null && b(kY.Parent))
			{
				A(kY.Parent, (TreeViewAction)1);
			}
		}
		else if (((kX == aW.kP || kX == aW.kQ) && (int)e.KeyData == 39) || (kX == aW.kp && (int)e.KeyData == 40))
		{
			if (kY.Nodes.Count != 0 && !kY.IsExpanded)
			{
				OnAfterExpand(new TreeViewEventArgs(kY, (TreeViewAction)1));
			}
		}
		else if (((kX == aW.kP || kX == aW.kQ) && (int)e.KeyData == 38) || (kX == aW.kp && (int)e.KeyData == 37))
		{
			TreeNode val = F();
			if (val != null)
			{
				A(val, (TreeViewAction)1);
			}
		}
		else if (((kX == aW.kP || kX == aW.kQ) && (int)e.KeyData == 40) || (kX == aW.kp && (int)e.KeyData == 39))
		{
			TreeNode val2 = f();
			if (val2 != null)
			{
				A(val2, (TreeViewAction)1);
			}
		}
		else if ((int)e.KeyData == 32 && ky && kZ)
		{
			OnAfterCheck(new TreeViewEventArgs(kY, (TreeViewAction)1));
		}
	}

	private TreeNode F()
	{
		TreeNode val = null;
		TreeNode val2 = kY;
		while (true)
		{
			List<TreeNode> val3 = new List<TreeNode>();
			if (val2.Parent != null)
			{
				for (int i = 0; i < val2.Parent.Nodes.Count; i++)
				{
					val3.Add(val2.Parent.Nodes[i]);
				}
			}
			else
			{
				val3 = kx;
			}
			int num = val3.IndexOf(val2);
			if (num > 0)
			{
				TreeNode val4 = val3[num - 1];
				while (val4.Nodes.Count != 0 && val4.IsExpanded)
				{
					val = val4.Nodes[val4.Nodes.Count - 1];
					val4 = val;
				}
				val = val4;
			}
			else if (val2.Parent != null)
			{
				val = val2.Parent;
			}
			if (val == null || b(val))
			{
				break;
			}
			val2 = val;
		}
		return val;
	}

	private TreeNode f()
	{
		TreeNode val = null;
		TreeNode val2 = kY;
		while (true)
		{
			if (val2.Nodes.Count != 0 && val2.IsExpanded)
			{
				val = val2.Nodes[0];
			}
			else
			{
				do
				{
					TreeNode parent = val2.Parent;
					List<TreeNode> val3 = new List<TreeNode>();
					if (parent != null)
					{
						for (int i = 0; i < parent.Nodes.Count; i++)
						{
							val3.Add(parent.Nodes[i]);
						}
					}
					else
					{
						val3 = kx;
					}
					int num = val3.IndexOf(val2);
					if (num < val3.Count - 1)
					{
						val = val3[num + 1];
						continue;
					}
					if (parent == null)
					{
						break;
					}
					val2 = val2.Parent;
				}
				while (val == null);
			}
			if (val == null || b(val))
			{
				break;
			}
			val2 = val;
		}
		return val;
	}

	private bool b(TreeNode P_0)
	{
		if (P_0 is aw)
		{
			return (P_0 as aw).kR;
		}
		return true;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(TreeViewCancelEventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TreeViewCancelEventHandler val = Le;
		TreeViewCancelEventHandler val2;
		do
		{
			val2 = val;
			TreeViewCancelEventHandler val3 = (TreeViewCancelEventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<TreeViewCancelEventHandler>(ref Le, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(TreeViewCancelEventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TreeViewCancelEventHandler val = Le;
		TreeViewCancelEventHandler val2;
		do
		{
			val2 = val;
			TreeViewCancelEventHandler val3 = (TreeViewCancelEventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<TreeViewCancelEventHandler>(ref Le, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(TreeViewEventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TreeViewEventHandler val = LF;
		TreeViewEventHandler val2;
		do
		{
			val2 = val;
			TreeViewEventHandler val3 = (TreeViewEventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<TreeViewEventHandler>(ref LF, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(TreeViewEventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TreeViewEventHandler val = LF;
		TreeViewEventHandler val2;
		do
		{
			val2 = val;
			TreeViewEventHandler val3 = (TreeViewEventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<TreeViewEventHandler>(ref LF, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void B(TreeViewEventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TreeViewEventHandler val = Lf;
		TreeViewEventHandler val2;
		do
		{
			val2 = val;
			TreeViewEventHandler val3 = (TreeViewEventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<TreeViewEventHandler>(ref Lf, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void b(TreeViewEventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TreeViewEventHandler val = Lf;
		TreeViewEventHandler val2;
		do
		{
			val2 = val;
			TreeViewEventHandler val3 = (TreeViewEventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<TreeViewEventHandler>(ref Lf, val3, val2);
		}
		while (val != val2);
	}

	private void A(TreeNode P_0, TreeViewAction P_1)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		if (Le != null)
		{
			Le.Invoke((object)this, new TreeViewCancelEventArgs(P_0, false, P_1));
		}
		bool flag = kY != P_0;
		if (flag)
		{
			kY = P_0;
		}
		if (kY != null)
		{
			if (!flag)
			{
				if (Lf != null)
				{
					Lf.Invoke((object)this, new TreeViewEventArgs(P_0, P_1));
				}
			}
			else
			{
				if (LF != null)
				{
					LF.Invoke((object)this, new TreeViewEventArgs(P_0, P_1));
				}
				if (!(kY is aw) || (kY as aw).kq)
				{
					for (TreeNode parent = kY.Parent; parent != null; parent = parent.Parent)
					{
						if (!parent.IsExpanded)
						{
							OnAfterExpand(new TreeViewEventArgs(parent, (TreeViewAction)0));
						}
					}
				}
			}
			if (((Control)Ld).Visible)
			{
				G();
			}
		}
		((Control)this).Invalidate();
	}

	private void G()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = 2;
		for (int i = 0; i < kx.Count; i++)
		{
			TreeNode val = kx[i];
			int num3 = A(val, ref num, ref num2);
			if (num3 == -1)
			{
				continue;
			}
			int num4;
			if (kX == aW.kP || kX == aW.kQ)
			{
				num4 = (int)(((Control)this).Font.Size * 2f);
				if (kX == aW.kQ)
				{
					num4 += E();
				}
			}
			else
			{
				num4 = 84;
			}
			Point autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			if (num3 + ((Point)(ref autoScrollPosition)).Y < num4)
			{
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				int j;
				for (j = ((Point)(ref autoScrollPosition)).Y; num3 + j < num4; j += num4)
				{
				}
				j = Math.Min(0, j);
				((ScrollableControl)this).AutoScrollPosition = new Point(((Control)LD).Visible ? LD.C() : 0, -j);
			}
			else
			{
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				if (num3 + ((Point)(ref autoScrollPosition)).Y > ((Control)this).Height - (((Control)LD).Visible ? (num4 + 20) : num4))
				{
					autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
					int num5 = ((Point)(ref autoScrollPosition)).Y;
					while (num3 + num5 > ((Control)this).Height - (((Control)LD).Visible ? (num4 + 20) : num4))
					{
						num5 -= num4;
					}
					num5 = Math.Max(-(Ld.b() - Ld.A()), num5);
					((ScrollableControl)this).AutoScrollPosition = new Point(((Control)LD).Visible ? LD.C() : 0, -num5);
				}
			}
			I();
			((Control)Ld).Invalidate();
			break;
		}
	}

	private int A(TreeNode P_0, ref int P_1, ref int P_2)
	{
		if (kX == aW.kP || kX == aW.kQ)
		{
			if (P_0 == kY)
			{
				return P_2;
			}
			P_2 += (int)(((Control)this).Font.Size * 2f);
			if (kX == aW.kQ)
			{
				P_2 += E();
			}
			if (P_0.IsExpanded && P_0.Nodes.Count != 0)
			{
				P_1 += 10;
				for (int i = 0; i < P_0.Nodes.Count; i++)
				{
					TreeNode val = P_0.Nodes[i];
					int num = A(val, ref P_1, ref P_2);
					if (num != -1)
					{
						return num;
					}
				}
				P_1 -= 10;
			}
			return -1;
		}
		int num2 = 0;
		int num3;
		int num4;
		if (P_0.ImageIndex != -1)
		{
			num3 = h() + 84 - P_0.Level * 16;
			num4 = 84 - P_0.Level * 16;
		}
		else
		{
			num2 = P_0.Level * 16;
			num3 = ((Control)this).Width - 4 - num2;
			num4 = 25;
			if (P_1 != 2)
			{
				P_1 = 2;
				P_2 += 84 - P_0.Level * 16;
			}
		}
		if (P_0 == kY)
		{
			return P_2;
		}
		P_1 += num3;
		if (P_1 >= ((Control)this).Width - (2 + ((Control)Ld).Width) - num3)
		{
			P_1 = 2;
			P_2 += num4;
		}
		if (P_0.IsExpanded && P_0.Nodes.Count != 0)
		{
			if (P_1 != 2)
			{
				P_1 = 2;
				P_2 += num4;
			}
			for (int j = 0; j < P_0.Nodes.Count; j++)
			{
				TreeNode val2 = P_0.Nodes[j];
				int num5 = A(val2, ref P_1, ref P_2);
				if (num5 != -1)
				{
					return num5;
				}
				if (j == P_0.Nodes.Count - 1 && P_1 != 2)
				{
					int num6 = 84 - (P_0.Level + 1) * 16;
					P_1 = 2;
					P_2 += num6;
				}
			}
		}
		return -1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void C(TreeViewEventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TreeViewEventHandler val = LG;
		TreeViewEventHandler val2;
		do
		{
			val2 = val;
			TreeViewEventHandler val3 = (TreeViewEventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<TreeViewEventHandler>(ref LG, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void c(TreeViewEventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TreeViewEventHandler val = LG;
		TreeViewEventHandler val2;
		do
		{
			val2 = val;
			TreeViewEventHandler val3 = (TreeViewEventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<TreeViewEventHandler>(ref LG, val3, val2);
		}
		while (val != val2);
	}

	protected virtual void OnAfterExpand(TreeViewEventArgs e)
	{
		e.Node.Expand();
		if (LG != null)
		{
			LG.Invoke((object)this, e);
		}
		H();
	}

	[SpecialName]
	[CompilerGenerated]
	internal void D(TreeViewEventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TreeViewEventHandler val = Lg;
		TreeViewEventHandler val2;
		do
		{
			val2 = val;
			TreeViewEventHandler val3 = (TreeViewEventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<TreeViewEventHandler>(ref Lg, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void d(TreeViewEventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TreeViewEventHandler val = Lg;
		TreeViewEventHandler val2;
		do
		{
			val2 = val;
			TreeViewEventHandler val3 = (TreeViewEventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<TreeViewEventHandler>(ref Lg, val3, val2);
		}
		while (val != val2);
	}

	protected virtual void OnAfterCollapse(TreeViewEventArgs e)
	{
		e.Node.Collapse();
		if (Lg != null)
		{
			Lg.Invoke((object)this, e);
		}
		H();
	}

	protected virtual void OnAfterCheck(TreeViewEventArgs e)
	{
		bool flag = !e.Node.Checked;
		A(e.Node, flag);
		((Control)this).Invalidate();
	}

	internal void B(bool P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		Enumerator<TreeNode> enumerator = a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				TreeNode current = enumerator.Current;
				if (P_0)
				{
					foreach (TreeNode node in current.Nodes)
					{
						TreeNode val = node;
						OnAfterCollapse(new TreeViewEventArgs(val, (TreeViewAction)1));
					}
				}
				else
				{
					OnAfterCollapse(new TreeViewEventArgs(current, (TreeViewAction)1));
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal void g()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<TreeNode> enumerator = a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				TreeNode current = enumerator.Current;
				C(current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void C(TreeNode P_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		OnAfterExpand(new TreeViewEventArgs(P_0, (TreeViewAction)4));
		foreach (TreeNode node in P_0.Nodes)
		{
			TreeNode val = node;
			C(val);
		}
	}

	internal static void A(TreeNode P_0, bool P_1)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		P_0.Checked = P_1;
		foreach (TreeNode node in P_0.Nodes)
		{
			A(node, P_1);
		}
	}

	internal static bool c(TreeNode P_0)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		foreach (TreeNode node in P_0.Nodes)
		{
			TreeNode val = node;
			if (val.Checked)
			{
				return true;
			}
			if (c(val))
			{
				return true;
			}
		}
		return false;
	}

	internal static bool D(TreeNode P_0)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		foreach (TreeNode node in P_0.Nodes)
		{
			TreeNode val = node;
			if (!val.Checked)
			{
				return true;
			}
			if (D(val))
			{
				return true;
			}
		}
		return false;
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
		((ScrollableControl)this).OnMouseWheel(e);
		I();
		if (((Control)Ld).Visible)
		{
			((Control)Ld).Invalidate();
		}
		((Control)this).Invalidate();
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		((ScrollableControl)this).OnVisibleChanged(e);
		if (!((Control)this).Visible)
		{
			((Control)LD).Visible = false;
			((Control)Ld).Visible = false;
			((Control)LE).Visible = false;
		}
		else
		{
			H();
		}
	}

	protected override void OnResize(EventArgs e)
	{
		((UserControl)this).OnResize(e);
		H();
	}

	internal void H()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		bool autoScroll = ((ScrollableControl)this).AutoScroll;
		Point autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
		((ScrollableControl)this).AutoScroll = false;
		int num = 2;
		int num2 = 2;
		int num3 = 0;
		int num4 = 0;
		for (int i = 0; i < kx.Count; i++)
		{
			TreeNode val = kx[i];
			A(val, ref num, ref num2, ref num3, ref num4);
		}
		((Control)LB).Width = num3;
		((Control)Lb).Width = num3;
		if (num3 > ((Control)this).Width)
		{
			num4 += 20;
		}
		((Control)Lb).Top = Math.Max(num4 - 1, ((Control)this).Height - 1);
		if (!((Control)this).Controls.Contains((Control)(object)LB))
		{
			((Control)this).Controls.Add((Control)(object)LB);
		}
		if (!((Control)this).Controls.Contains((Control)(object)Lb))
		{
			((Control)this).Controls.Add((Control)(object)Lb);
		}
		if (autoScroll)
		{
			((ScrollableControl)this).AutoScroll = true;
			((ScrollableControl)this).AutoScrollPosition = new Point(-((Point)(ref autoScrollPosition)).X, -((Point)(ref autoScrollPosition)).Y);
		}
		I();
		((Control)LD).Invalidate();
		((Control)Ld).Invalidate();
		((Control)this).Invalidate();
	}

	private void A(TreeNode P_0, ref int P_1, ref int P_2, ref int P_3, ref int P_4)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		int num = h();
		if (kX == aW.kP || kX == aW.kQ)
		{
			int num2 = P_1 + num;
			if (ky)
			{
				num2 += 21;
			}
			else if (kX == aW.kQ)
			{
				num2 += 3 + e();
			}
			Font val = ((P_0.Parent == null || P_0.Parent.Parent != null) ? new Font(((Control)this).Font.FontFamily, ((Control)this).Font.Size, ((Control)this).Font.Style) : new Font(((Control)this).Font.FontFamily, ((Control)this).Font.Size, (FontStyle)1));
			Size val2 = TextRenderer.MeasureText(P_0.Text, val, new Size(2147483647, 2147483647), (TextFormatFlags)2048);
			int width = ((Size)(ref val2)).Width;
			val.Dispose();
			P_3 = Math.Max(num2 + width, P_3);
			int num3 = (int)(((Control)this).Font.Size * 2f);
			if (kX == aW.kQ)
			{
				num3 += E();
			}
			P_4 = Math.Max(P_2 + num3, P_4);
			P_2 += num3;
			if (P_0.IsExpanded && P_0.Nodes.Count != 0)
			{
				P_1 += 10;
				for (int i = 0; i < P_0.Nodes.Count; i++)
				{
					TreeNode val3 = P_0.Nodes[i];
					A(val3, ref P_1, ref P_2, ref P_3, ref P_4);
				}
				P_1 -= 10;
			}
			return;
		}
		int num4 = 0;
		int num5;
		int num6;
		if (P_0.ImageIndex != -1)
		{
			num5 = num + 84 - P_0.Level * 16;
			num6 = 84 - P_0.Level * 16;
		}
		else
		{
			num4 = P_0.Level * 16;
			num5 = ((Control)this).Width - 4 - num4;
			num6 = 25;
			if (P_1 != 2)
			{
				P_1 = 2;
				P_2 += 84 - P_0.Level * 16;
			}
		}
		P_3 = Math.Max(P_1 + num5, P_3);
		P_4 = Math.Max(P_2 + num6, P_4);
		P_1 += num5;
		if (P_1 >= ((Control)this).Width - (2 + ((Control)Ld).Width) - num5)
		{
			P_1 = 2;
			P_2 += num6;
		}
		if (!P_0.IsExpanded || P_0.Nodes.Count == 0)
		{
			return;
		}
		if (P_1 != 2)
		{
			P_1 = 2;
			P_2 += num6;
		}
		for (int j = 0; j < P_0.Nodes.Count; j++)
		{
			TreeNode val4 = P_0.Nodes[j];
			A(val4, ref P_1, ref P_2, ref P_3, ref P_4);
			if (j == P_0.Nodes.Count - 1 && P_1 != 2)
			{
				int num7 = 84 - (P_0.Level + 1) * 16;
				P_1 = 2;
				P_2 += num7;
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(ItemDragEventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		ItemDragEventHandler val = LH;
		ItemDragEventHandler val2;
		do
		{
			val2 = val;
			ItemDragEventHandler val3 = (ItemDragEventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<ItemDragEventHandler>(ref LH, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(ItemDragEventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		ItemDragEventHandler val = LH;
		ItemDragEventHandler val2;
		do
		{
			val2 = val;
			ItemDragEventHandler val3 = (ItemDragEventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<ItemDragEventHandler>(ref LH, val3, val2);
		}
		while (val != val2);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((UserControl)this).OnMouseDown(e);
		m_mouseDownX = e.X;
		m_mouseDownY = e.Y;
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Invalid comparison between Unknown and I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		((Control)this).OnMouseMove(e);
		if ((int)e.Button == 0)
		{
			Rectangle val;
			TreeNode val2 = A(e.X, e.Y, out val);
			if (m_lastMouseOverTreeNode == null || val2 != m_lastMouseOverTreeNode)
			{
				m_lastMouseOverTreeNode = val2;
				((Control)this).Invalidate();
			}
			if (val2 != null && !string.IsNullOrWhiteSpace(val2.ToolTipText))
			{
				if (!(LC.GetToolTip((Control)(object)this) != val2.ToolTipText))
				{
					return;
				}
				if (kX == aW.kp)
				{
					LC.Active = true;
					LC.Show(val2.ToolTipText, (IWin32Window)(object)this, e.X + 7, e.Y + 7);
					return;
				}
				if (val2.ToolTipText != val2.Text)
				{
					LC.Active = true;
					LC.Show(val2.ToolTipText, (IWin32Window)(object)this, e.X + 2, e.Y + 2);
					return;
				}
				Font val3 = ((val2.Parent == null || val2.Parent.Parent != null) ? new Font(((Control)this).Font.FontFamily, ((Control)this).Font.Size, ((Control)this).Font.Style) : new Font(((Control)this).Font.FontFamily, ((Control)this).Font.Size, (FontStyle)1));
				Size val4 = TextRenderer.MeasureText(val2.Text, val3, new Size(2147483647, 2147483647), (TextFormatFlags)2048);
				int width = ((Size)(ref val4)).Width;
				val3.Dispose();
				int num = h();
				if (ky)
				{
					num += 21;
				}
				if (kX == aW.kQ)
				{
					num += 3 + this.e();
				}
				for (TreeNode parent = val2.Parent; parent != null; parent = parent.Parent)
				{
					num += 10;
				}
				if ((((Control)Ld).Visible && num + width > ((Control)this).Width - 18) || (!((Control)Ld).Visible && num + width > ((Control)this).Width))
				{
					LC.Active = true;
					LC.Show(val2.ToolTipText, (IWin32Window)(object)this, e.X + 2, e.Y + 2);
				}
				else
				{
					LC.Active = false;
					LC.Hide((IWin32Window)(object)this);
				}
			}
			else
			{
				LC.Active = false;
				LC.Hide((IWin32Window)(object)this);
			}
			return;
		}
		if (m_lastMouseOverTreeNode != null)
		{
			m_lastMouseOverTreeNode = null;
			((Control)this).Invalidate();
		}
		if ((int)e.Button != 1048576 || m_mouseDownX == -1 || m_mouseDownY == -1 || (Math.Abs(e.X - m_mouseDownX) < 2 && Math.Abs(e.Y - m_mouseDownY) < 2))
		{
			return;
		}
		int num2 = 2;
		int num3 = 2;
		for (int i = 0; i < kx.Count; i++)
		{
			TreeNode val5 = kx[i];
			if (A(val5, m_mouseDownX, m_mouseDownY, false, true, false, ref num2, ref num3, out var _) != null)
			{
				break;
			}
		}
		m_mouseDownX = -1;
		m_mouseDownY = -1;
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		m_mouseDownX = -1;
		m_mouseDownY = -1;
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		LC.Active = false;
		LC.Hide((IWin32Window)(object)this);
		m_lastMouseOverTreeNode = null;
		((Control)this).Invalidate();
	}

	protected override void OnMouseClick(MouseEventArgs e)
	{
		((Control)this).OnMouseClick(e);
		int x = e.X;
		int y = e.Y;
		int num = 2;
		int num2 = 2;
		for (int i = 0; i < kx.Count; i++)
		{
			TreeNode val = kx[i];
			if (A(val, x, y, false, false, false, ref num, ref num2, out var _) != null)
			{
				((Control)this).Invalidate();
				break;
			}
		}
	}

	protected override void OnMouseDoubleClick(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDoubleClick(e);
		if ((int)e.Button != 1048576)
		{
			return;
		}
		int x = e.X;
		int y = e.Y;
		int num = 2;
		int num2 = 2;
		for (int i = 0; i < kx.Count; i++)
		{
			TreeNode val = kx[i];
			if (A(val, x, y, true, false, false, ref num, ref num2, out var _) != null)
			{
				((Control)this).Invalidate();
				break;
			}
		}
	}

	internal TreeNode A(int P_0, int P_1, out Rectangle P_2)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = 2;
		for (int i = 0; i < kx.Count; i++)
		{
			Rectangle val;
			TreeNode val2 = A(kx[i], P_0, P_1, false, false, true, ref num, ref num2, out val);
			if (val2 != null)
			{
				P_2 = val;
				return val2;
			}
		}
		P_2 = Rectangle.Empty;
		return null;
	}

	private TreeNode A(TreeNode P_0, int P_1, int P_2, bool P_3, bool P_4, bool P_5, ref int P_6, ref int P_7, out Rectangle P_8)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected O, but got Unknown
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		int num = h();
		Point autoScrollPosition;
		if (kX == aW.kP || kX == aW.kQ)
		{
			int num2 = ((Control)this).Width - 4;
			int num3 = P_6;
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			int num4 = num2 - (num3 + ((Point)(ref autoScrollPosition)).X);
			int num5 = P_7;
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			int num6 = num5 + ((Point)(ref autoScrollPosition)).Y;
			int num7 = (int)(((Control)this).Font.Size * 2f);
			if (kX == aW.kQ)
			{
				num4 += e();
				num7 += E();
			}
			int num8 = P_6;
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			Rectangle val = default(Rectangle);
			((Rectangle)(ref val))._002Ector(num8 + ((Point)(ref autoScrollPosition)).X, num6, num4, num7);
			P_8 = val;
			if (P_1 >= ((Rectangle)(ref val)).X && P_1 < ((Rectangle)(ref val)).X + ((Rectangle)(ref val)).Width && P_2 >= ((Rectangle)(ref val)).Y && P_2 < ((Rectangle)(ref val)).Y + ((Rectangle)(ref val)).Height)
			{
				if (P_5)
				{
					return P_0;
				}
				if (P_4)
				{
					if (LH != null)
					{
						LH.Invoke((object)this, new ItemDragEventArgs((MouseButtons)1048576, (object)P_0));
					}
					return P_0;
				}
				bool flag = P_0.Nodes.Count != 0;
				if (flag && P_1 <= ((Rectangle)(ref val)).X + num)
				{
					if (P_0.IsExpanded)
					{
						OnAfterCollapse(new TreeViewEventArgs(P_0, (TreeViewAction)2));
					}
					else
					{
						OnAfterExpand(new TreeViewEventArgs(P_0, (TreeViewAction)2));
					}
					return P_0;
				}
				if (ky && P_1 > ((Rectangle)(ref val)).X + num + 3 && P_1 < ((Rectangle)(ref val)).X + num + 3 + 18)
				{
					if (kZ)
					{
						OnAfterCheck(new TreeViewEventArgs(P_0, (TreeViewAction)2));
					}
					return P_0;
				}
				if (P_3)
				{
					if (flag)
					{
						if (P_0.IsExpanded)
						{
							OnAfterCollapse(new TreeViewEventArgs(P_0, (TreeViewAction)2));
						}
						else
						{
							OnAfterExpand(new TreeViewEventArgs(P_0, (TreeViewAction)2));
						}
					}
				}
				else if (b(P_0))
				{
					A(P_0, (TreeViewAction)2);
				}
				else if (flag)
				{
					if (P_0.IsExpanded)
					{
						OnAfterCollapse(new TreeViewEventArgs(P_0, (TreeViewAction)2));
					}
					else
					{
						OnAfterExpand(new TreeViewEventArgs(P_0, (TreeViewAction)2));
					}
				}
				return P_0;
			}
			P_7 += (int)(((Control)this).Font.Size * 2f);
			if (kX == aW.kQ)
			{
				P_7 += E();
			}
			if (P_0.IsExpanded && P_0.Nodes.Count != 0)
			{
				P_6 += 10;
				for (int i = 0; i < P_0.Nodes.Count; i++)
				{
					Rectangle val2;
					TreeNode val3 = A(P_0.Nodes[i], P_1, P_2, P_3, P_4, P_5, ref P_6, ref P_7, out val2);
					if (val3 != null)
					{
						P_8 = val2;
						return val3;
					}
				}
				P_6 -= 10;
			}
			P_8 = Rectangle.Empty;
			return null;
		}
		int num9 = 0;
		int num10;
		int num11;
		if (P_0.ImageIndex != -1)
		{
			num10 = num + 84 - P_0.Level * 16;
			num11 = 84 - P_0.Level * 16;
		}
		else
		{
			num9 = P_0.Level * 16;
			num10 = ((Control)this).Width - 4 - num9;
			num11 = 25;
			if (P_6 != 2)
			{
				P_6 = 2;
				P_7 += 84 - P_0.Level * 16;
			}
		}
		int num12 = P_6;
		autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
		int num13 = num12 + ((Point)(ref autoScrollPosition)).X + num9;
		int num14 = P_7;
		autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
		P_8 = new Rectangle(num13, num14 + ((Point)(ref autoScrollPosition)).Y, num10, num11);
		int num15 = P_6;
		autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
		if (P_1 >= num15 + ((Point)(ref autoScrollPosition)).X + num9)
		{
			int num16 = P_6;
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			if (P_1 < num16 + ((Point)(ref autoScrollPosition)).X + num9 + num10)
			{
				int num17 = P_7;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				if (P_2 >= num17 + ((Point)(ref autoScrollPosition)).Y)
				{
					int num18 = P_7;
					autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
					if (P_2 < num18 + ((Point)(ref autoScrollPosition)).Y + num11)
					{
						if (P_5)
						{
							return P_0;
						}
						if (P_4)
						{
							if (LH != null)
							{
								LH.Invoke((object)this, new ItemDragEventArgs((MouseButtons)1048576, (object)P_0));
							}
							return P_0;
						}
						bool flag2 = P_0.Nodes.Count != 0;
						if (flag2)
						{
							int num19 = P_6;
							autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
							if (P_1 < num19 + ((Point)(ref autoScrollPosition)).X + num9 + num)
							{
								if (P_0.IsExpanded)
								{
									OnAfterCollapse(new TreeViewEventArgs(P_0, (TreeViewAction)2));
								}
								else
								{
									OnAfterExpand(new TreeViewEventArgs(P_0, (TreeViewAction)2));
								}
								return P_0;
							}
						}
						if (P_3)
						{
							if (flag2)
							{
								if (P_0.IsExpanded)
								{
									OnAfterCollapse(new TreeViewEventArgs(P_0, (TreeViewAction)2));
								}
								else
								{
									OnAfterExpand(new TreeViewEventArgs(P_0, (TreeViewAction)2));
								}
							}
						}
						else if (b(P_0))
						{
							A(P_0, (TreeViewAction)2);
						}
						else if (flag2)
						{
							if (P_0.IsExpanded)
							{
								OnAfterCollapse(new TreeViewEventArgs(P_0, (TreeViewAction)2));
							}
							else
							{
								OnAfterExpand(new TreeViewEventArgs(P_0, (TreeViewAction)2));
							}
						}
						return P_0;
					}
				}
			}
		}
		P_6 += num10;
		if (P_6 >= ((Control)this).Width - (2 + ((Control)Ld).Width) - num10)
		{
			P_6 = 2;
			P_7 += num11;
		}
		if (P_0.IsExpanded && P_0.Nodes.Count != 0)
		{
			if (P_6 != 2)
			{
				P_6 = 2;
				P_7 += num11;
			}
			for (int j = 0; j < P_0.Nodes.Count; j++)
			{
				Rectangle val4;
				TreeNode val5 = A(P_0.Nodes[j], P_1, P_2, P_3, P_4, P_5, ref P_6, ref P_7, out val4);
				if (val5 != null)
				{
					P_8 = val4;
					return val5;
				}
				if (j == P_0.Nodes.Count - 1 && P_6 != 2)
				{
					int num20 = 84 - (P_0.Level + 1) * 16;
					P_6 = 2;
					P_7 += num20;
				}
			}
		}
		P_8 = Rectangle.Empty;
		return null;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		if (Lc)
		{
			return;
		}
		Graphics graphics = e.Graphics;
		if (BM.TO)
		{
			Pen val = new Pen(Color.Gray, 1f);
			try
			{
				graphics.DrawRectangle(val, 0, 0, ((Control)this).Width - 1, ((Control)this).Height - 1);
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		int num = 2;
		int num2 = 2;
		for (int i = 0; i < kx.Count; i++)
		{
			TreeNode val2 = kx[i];
			A(graphics, val2, ref num, ref num2);
		}
		((Control)this).OnPaint(e);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A(DrawTreeNodeEventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		DrawTreeNodeEventHandler val = Lh;
		DrawTreeNodeEventHandler val2;
		do
		{
			val2 = val;
			DrawTreeNodeEventHandler val3 = (DrawTreeNodeEventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<DrawTreeNodeEventHandler>(ref Lh, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(DrawTreeNodeEventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		DrawTreeNodeEventHandler val = Lh;
		DrawTreeNodeEventHandler val2;
		do
		{
			val2 = val;
			DrawTreeNodeEventHandler val3 = (DrawTreeNodeEventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<DrawTreeNodeEventHandler>(ref Lh, val3, val2);
		}
		while (val != val2);
	}

	private void A(Graphics P_0, TreeNode P_1, ref int P_2, ref int P_3)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected O, but got Unknown
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected O, but got Unknown
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected O, but got Unknown
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected O, but got Unknown
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected O, but got Unknown
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected O, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_097d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0984: Expected O, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_0a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a72: Expected O, but got Unknown
		//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Expected O, but got Unknown
		//IL_09f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Expected O, but got Unknown
		//IL_0b04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Expected O, but got Unknown
		//IL_0bb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
		bool flag = P_1 is aw && (P_1 as aw).kR && P_1 == m_lastMouseOverTreeNode;
		int num = h();
		Point autoScrollPosition;
		if (kX == aW.kP || kX == aW.kQ)
		{
			bool flag2 = P_1.Parent != null && P_1.Parent.Parent == null;
			Font val2;
			if (flag2 || flag)
			{
				FontStyle val = ((Control)this).Font.Style;
				if (flag2)
				{
					val = (FontStyle)(val | 1);
				}
				if (flag)
				{
					val = (FontStyle)(val | 4);
				}
				val2 = new Font(((Control)this).Font.FontFamily, ((Control)this).Font.Size, val);
			}
			else
			{
				val2 = ((Control)this).Font;
			}
			Size val3 = TextRenderer.MeasureText(P_1.Text, val2, new Size(2147483647, 2147483647), (TextFormatFlags)2048);
			int width = ((Size)(ref val3)).Width;
			int num2 = num;
			int num3;
			if (ky)
			{
				num3 = num + 3 + 18 + width;
				num2 += 21;
			}
			else if (kX == aW.kQ)
			{
				num3 = num + 3 + e() + width;
				num2 += 3 + e();
			}
			else
			{
				num3 = num + width;
			}
			if (P_1.Nodes.Count != 0)
			{
				if (kX == aW.kQ)
				{
					A(P_1, P_0, P_2, P_3 + e() / 2);
				}
				else
				{
					A(P_1, P_0, P_2, P_3 + (int)Math.Round((double)((Control)this).Font.Size));
				}
			}
			if (ky)
			{
				ao ao = ((P_1.Nodes.Count == 0) ? (P_1.Checked ? ao.jc : ao.jC) : (D(P_1) ? (c(P_1) ? ao.jD : ao.jC) : (P_1.Checked ? ao.jc : ao.jD)));
				Color backColor = ((Control)this).BackColor;
				int num4 = P_2;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				int num5 = num4 + ((Point)(ref autoScrollPosition)).X + num2 - 18;
				int num6 = P_3;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				aP.A(P_0, backColor, num5, num6 + ((Point)(ref autoScrollPosition)).Y, true, false, ao, false);
			}
			Rectangle val6 = default(Rectangle);
			if (kX == aW.kQ && !ky)
			{
				int num7 = P_3;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				int num8 = num7 + ((Point)(ref autoScrollPosition)).Y;
				if (P_1.ImageIndex != -1)
				{
					int num9 = P_2;
					autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
					int num10 = num9 + ((Point)(ref autoScrollPosition)).X + num2 - e();
					int num11 = P_3;
					autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
					Rectangle val4 = default(Rectangle);
					((Rectangle)(ref val4))._002Ector(num10, num11 + ((Point)(ref autoScrollPosition)).Y, e(), e());
					Color foreColor = P_1.ForeColor;
					Image val5 = d()[P_1.ImageIndex];
					val5 = (Image)(object)O.A(val5, 1f, 0f, 0f, 0f, 0f, (float)(int)((Color)(ref foreColor)).R / 255f, (float)(int)((Color)(ref foreColor)).G / 255f, (float)(int)((Color)(ref foreColor)).B / 255f);
					P_0.SmoothingMode = (SmoothingMode)2;
					P_0.DrawImage(val5, ((Rectangle)(ref val4)).X, ((Rectangle)(ref val4)).Y, ((Rectangle)(ref val4)).Width, ((Rectangle)(ref val4)).Height);
					P_0.SmoothingMode = (SmoothingMode)0;
					num8 = ((Rectangle)(ref val4)).Top + e() / 2 - (int)((Control)this).Font.Size;
				}
				int num12 = P_2;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				((Rectangle)(ref val6))._002Ector(num12 + ((Point)(ref autoScrollPosition)).X + num2, num8, width, (int)(((Control)this).Font.Size * 2f));
			}
			else
			{
				int num13 = P_2;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				int num14 = num13 + ((Point)(ref autoScrollPosition)).X + num2;
				int num15 = P_3;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				((Rectangle)(ref val6))._002Ector(num14, num15 + ((Point)(ref autoScrollPosition)).Y, width, (int)(((Control)this).Font.Size * 2f));
			}
			if (P_1 == kY)
			{
				SolidBrush val7 = new SolidBrush(Color.DodgerBlue);
				try
				{
					P_0.FillRectangle((Brush)(object)val7, val6);
				}
				finally
				{
					((System.IDisposable)val7)?.Dispose();
				}
				if (P_1.ForeColor == BM.tC)
				{
					TextRenderer.DrawText((IDeviceContext)(object)P_0, P_1.Text, val2, val6, BM.tc, (TextFormatFlags)2048);
				}
				else
				{
					TextRenderer.DrawText((IDeviceContext)(object)P_0, P_1.Text, val2, val6, P_1.ForeColor, (TextFormatFlags)2048);
				}
			}
			else
			{
				TextRenderer.DrawText((IDeviceContext)(object)P_0, P_1.Text, val2, val6, P_1.ForeColor, (TextFormatFlags)2048);
			}
			if (flag2 || flag)
			{
				val2.Dispose();
			}
			if (LA == P_1)
			{
				Pen val8 = new Pen(Color.DodgerBlue, 2f);
				try
				{
					int num16 = P_3;
					autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
					int num17 = num16 + ((Point)(ref autoScrollPosition)).Y;
					P_0.DrawLine(val8, ((Rectangle)(ref val6)).Left, num17, ((Rectangle)(ref val6)).Right, num17);
				}
				finally
				{
					((System.IDisposable)val8)?.Dispose();
				}
			}
			if (Lh != null)
			{
				TreeNodeStates val9 = (TreeNodeStates)0;
				if (P_1 == kY)
				{
					val9 = (TreeNodeStates)(val9 | 1);
				}
				if (P_1.Checked)
				{
					val9 = (TreeNodeStates)(val9 | 8);
				}
				int num18 = P_2;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				int num19 = num18 + ((Point)(ref autoScrollPosition)).X;
				int num20 = P_3;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				Rectangle val10 = default(Rectangle);
				((Rectangle)(ref val10))._002Ector(num19, num20 + ((Point)(ref autoScrollPosition)).Y, num3, (int)(((Control)this).Font.Size * 2f));
				Lh.Invoke((object)this, new DrawTreeNodeEventArgs(P_0, P_1, val10, val9));
			}
			P_3 += (int)(((Control)this).Font.Size * 2f);
			if (kX == aW.kQ)
			{
				P_3 += E();
			}
			if (P_1.IsExpanded && P_1.Nodes.Count != 0)
			{
				P_2 += 10;
				for (int i = 0; i < P_1.Nodes.Count; i++)
				{
					TreeNode val11 = P_1.Nodes[i];
					A(P_0, val11, ref P_2, ref P_3);
				}
				P_2 -= 10;
			}
			if (La == P_1)
			{
				Pen val12 = new Pen(Color.DodgerBlue, 2f);
				try
				{
					P_0.DrawLine(val12, ((Rectangle)(ref val6)).Left, P_3, ((Rectangle)(ref val6)).Right, P_3);
					return;
				}
				finally
				{
					((System.IDisposable)val12)?.Dispose();
				}
			}
			return;
		}
		int num21 = 0;
		int num22;
		int num23;
		if (BM.Tn == BM.r.BqG || BM.Tn == BM.r.Bqh)
		{
			num22 = Math.Max(255 - P_1.Level * 85, 0);
			num23 = Math.Max(255 - (P_1.Level + 1) * 85, 0);
		}
		else
		{
			num22 = Math.Min(P_1.Level * 85, 255);
			num23 = Math.Min((P_1.Level + 1) * 85, 255);
		}
		int num24;
		int num25;
		if (P_1.ImageIndex != -1)
		{
			num24 = num + 84 - P_1.Level * 16;
			num25 = 84 - P_1.Level * 16;
		}
		else
		{
			num21 = P_1.Level * 16;
			num24 = ((Control)this).Width - 4 - num21;
			num25 = 25;
			if (P_2 != 2)
			{
				int num26 = 84 - P_1.Level * 16;
				SolidBrush val13 = new SolidBrush(Color.FromArgb(num22, num22, num22));
				try
				{
					int num27 = P_2;
					autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
					int num28 = num27 + ((Point)(ref autoScrollPosition)).X;
					int num29 = P_3;
					autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
					P_0.FillRectangle((Brush)(object)val13, num28, num29 + ((Point)(ref autoScrollPosition)).Y, ((Control)this).Width - 2 - P_2, num26);
				}
				finally
				{
					((System.IDisposable)val13)?.Dispose();
				}
				P_2 = 2;
				P_3 += num26;
			}
		}
		if (P_1.IsExpanded && P_1.GetNodeCount(true) != 0)
		{
			SolidBrush val14 = new SolidBrush(Color.FromArgb(num23, num23, num23));
			try
			{
				int num30 = P_2;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				int num31 = num30 + ((Point)(ref autoScrollPosition)).X;
				int num32 = P_3;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				P_0.FillRectangle((Brush)(object)val14, num31, num32 + ((Point)(ref autoScrollPosition)).Y, ((Control)this).Width - 2 - P_2, num25);
			}
			finally
			{
				((System.IDisposable)val14)?.Dispose();
			}
		}
		else
		{
			SolidBrush val15 = new SolidBrush(Color.FromArgb(num22, num22, num22));
			try
			{
				int num33 = P_2;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				int num34 = num33 + ((Point)(ref autoScrollPosition)).X;
				int num35 = P_3;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				P_0.FillRectangle((Brush)(object)val15, num34, num35 + ((Point)(ref autoScrollPosition)).Y, ((Control)this).Width - 2 - P_2, num25);
			}
			finally
			{
				((System.IDisposable)val15)?.Dispose();
			}
		}
		int num36 = P_2;
		autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
		int num37 = num36 + ((Point)(ref autoScrollPosition)).X + num21 + num + 3;
		int num38 = P_3;
		autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
		Rectangle val16 = default(Rectangle);
		((Rectangle)(ref val16))._002Ector(num37, num38 + ((Point)(ref autoScrollPosition)).Y + 3, num24 - num - 6, num25 - 6);
		if (P_1.ForeColor != BM.te)
		{
			SolidBrush val17 = new SolidBrush(P_1.ForeColor);
			try
			{
				P_0.FillRectangle((Brush)(object)val17, val16);
			}
			finally
			{
				((System.IDisposable)val17)?.Dispose();
			}
		}
		else
		{
			SolidBrush val18 = new SolidBrush(Color.LightGray);
			try
			{
				P_0.FillRectangle((Brush)(object)val18, val16);
			}
			finally
			{
				((System.IDisposable)val18)?.Dispose();
			}
		}
		if (P_1 == kY)
		{
			Pen val19 = new Pen(Color.DodgerBlue, 3f);
			try
			{
				P_0.DrawRectangle(val19, val16);
			}
			finally
			{
				((System.IDisposable)val19)?.Dispose();
			}
		}
		if (flag)
		{
			Pen val20 = new Pen(Color.DodgerBlue, 2f);
			try
			{
				P_0.DrawRectangle(val20, new Rectangle(((Rectangle)(ref val16)).X - 1, ((Rectangle)(ref val16)).Y - 1, ((Rectangle)(ref val16)).Width + 3, ((Rectangle)(ref val16)).Height + 3));
			}
			finally
			{
				((System.IDisposable)val20)?.Dispose();
			}
		}
		if (P_1.ImageIndex != -1)
		{
			Image val21 = d()[P_1.ImageIndex];
			P_0.DrawImage(val21, ((Rectangle)(ref val16)).X - 1, ((Rectangle)(ref val16)).Y - 1, ((Rectangle)(ref val16)).Width + 2, ((Rectangle)(ref val16)).Height + 2);
		}
		if (P_1.Nodes.Count != 0)
		{
			A(P_1, P_0, P_2 + num21, P_3 + (num25 >> 1));
		}
		if (P_1.ImageIndex == -1)
		{
			Font val22 = new Font(((Control)this).Font.FontFamily, 8f);
			try
			{
				Rectangle val23 = default(Rectangle);
				((Rectangle)(ref val23))._002Ector(((Rectangle)(ref val16)).X + 1, ((Rectangle)(ref val16)).Y + 1, num24 - (num + 8), num25 - 8);
				TextRenderer.DrawText((IDeviceContext)(object)P_0, P_1.Text, val22, val23, Color.Black, (TextFormatFlags)2048);
			}
			finally
			{
				((System.IDisposable)val22)?.Dispose();
			}
		}
		if (Lh != null)
		{
			TreeNodeStates val24 = (TreeNodeStates)0;
			if (P_1 == kY)
			{
				val24 = (TreeNodeStates)(val24 | 1);
			}
			if (P_1.Checked)
			{
				val24 = (TreeNodeStates)(val24 | 8);
			}
			int num39 = P_2;
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			int num40 = num39 + ((Point)(ref autoScrollPosition)).X;
			int num41 = P_3;
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			Rectangle val25 = default(Rectangle);
			((Rectangle)(ref val25))._002Ector(num40, num41 + ((Point)(ref autoScrollPosition)).Y, num24, num25);
			Lh.Invoke((object)this, new DrawTreeNodeEventArgs(P_0, P_1, val25, val24));
		}
		P_2 += num24;
		if (P_2 >= ((Control)this).Width - (2 + ((Control)Ld).Width) - num24)
		{
			SolidBrush val26 = new SolidBrush(Color.FromArgb(num22, num22, num22));
			try
			{
				int num42 = P_2;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				int num43 = num42 + ((Point)(ref autoScrollPosition)).X + num21;
				int num44 = P_3;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				P_0.FillRectangle((Brush)(object)val26, num43, num44 + ((Point)(ref autoScrollPosition)).Y, ((Control)this).Width - 2 - (P_2 + num21), num25);
			}
			finally
			{
				((System.IDisposable)val26)?.Dispose();
			}
			P_2 = 2;
			P_3 += num25;
		}
		if (!P_1.IsExpanded || P_1.Nodes.Count == 0)
		{
			return;
		}
		if (P_2 != 2)
		{
			SolidBrush val27 = new SolidBrush(Color.FromArgb(num22, num22, num22));
			try
			{
				int num45 = P_2;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				int num46 = num45 + ((Point)(ref autoScrollPosition)).X;
				int num47 = P_3;
				autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
				P_0.FillRectangle((Brush)(object)val27, num46, num47 + ((Point)(ref autoScrollPosition)).Y, ((Control)this).Width - 2 - P_2, num25);
			}
			finally
			{
				((System.IDisposable)val27)?.Dispose();
			}
			P_2 = 2;
			P_3 += num25;
		}
		for (int j = 0; j < P_1.Nodes.Count; j++)
		{
			TreeNode val28 = P_1.Nodes[j];
			A(P_0, val28, ref P_2, ref P_3);
			if (j == P_1.Nodes.Count - 1 && P_2 != 2)
			{
				int num48 = 84 - (P_1.Level + 1) * 16;
				SolidBrush val29 = new SolidBrush(Color.FromArgb(num23, num23, num23));
				try
				{
					int num49 = P_2;
					autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
					int num50 = num49 + ((Point)(ref autoScrollPosition)).X;
					int num51 = P_3;
					autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
					P_0.FillRectangle((Brush)(object)val29, num50, num51 + ((Point)(ref autoScrollPosition)).Y, ((Control)this).Width - 2 - P_2, num48);
				}
				finally
				{
					((System.IDisposable)val29)?.Dispose();
				}
				P_2 = 2;
				P_3 += num48;
			}
		}
	}

	private void A(TreeNode P_0, Graphics P_1, int P_2, int P_3)
	{
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		P_1.SmoothingMode = (SmoothingMode)2;
		Point autoScrollPosition;
		if (P_0.IsExpanded)
		{
			Point[] array = (Point[])(object)new Point[3];
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			int num = P_2 + ((Point)(ref autoScrollPosition)).X + 8;
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			array[0] = new Point(num, P_3 + ((Point)(ref autoScrollPosition)).Y + 4);
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			int num2 = P_2 + ((Point)(ref autoScrollPosition)).X + 2;
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			array[1] = new Point(num2, P_3 + ((Point)(ref autoScrollPosition)).Y - 3);
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			int num3 = P_2 + ((Point)(ref autoScrollPosition)).X + 13;
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			array[2] = new Point(num3, P_3 + ((Point)(ref autoScrollPosition)).Y - 3);
			if (BM.Tn == BM.r.BqG || BM.Tn == BM.r.Bqh)
			{
				P_1.FillPolygon(Brushes.Gray, array);
			}
			else
			{
				SolidBrush val = new SolidBrush(BM.tM);
				try
				{
					P_1.FillPolygon((Brush)(object)val, array);
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
		}
		else
		{
			Point[] array2 = (Point[])(object)new Point[3];
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			int num4 = P_2 + ((Point)(ref autoScrollPosition)).X + 13;
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			array2[0] = new Point(num4, P_3 + ((Point)(ref autoScrollPosition)).Y - 1);
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			int num5 = P_2 + ((Point)(ref autoScrollPosition)).X + 6;
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			array2[1] = new Point(num5, P_3 + ((Point)(ref autoScrollPosition)).Y - 7);
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			int num6 = P_2 + ((Point)(ref autoScrollPosition)).X + 6;
			autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
			array2[2] = new Point(num6, P_3 + ((Point)(ref autoScrollPosition)).Y + 4);
			if (BM.Tn == BM.r.BqG || BM.Tn == BM.r.Bqh)
			{
				P_1.FillPolygon(Brushes.Gray, array2);
			}
			else
			{
				SolidBrush val2 = new SolidBrush(BM.tM);
				try
				{
					P_1.FillPolygon((Brush)(object)val2, array2);
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
		}
		P_1.SmoothingMode = (SmoothingMode)0;
	}

	private int h()
	{
		for (int i = 0; i < kx.Count; i++)
		{
			if (kx[i].Nodes.Count != 0)
			{
				if (kX != aW.kp)
				{
					return 13;
				}
				return 15;
			}
		}
		return 0;
	}

	[DllImport("user32.dll", CharSet = 4, EntryPoint = "GetWindowLong")]
	private static extern int A(nint P_0, int P_1);

	internal void I()
	{
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = I;
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
			Point autoScrollPosition;
			if (flag)
			{
				try
				{
					if (!((Control)LD).IsDisposed && !((Control)LD).Disposing)
					{
						int width = ((Control)Lb).Width;
						((Control)LD).Visible = ((Control)this).Visible;
						((Control)LD).Left = num;
						((Control)LD).Top = num2 + (((Control)this).Height - ((Control)LD).Height) - 1;
						((Control)LD).Width = (flag2 ? (((Control)this).Width - ((Control)Ld).Width) : ((Control)this).Width);
						LD.a(new EventHandler(A));
						LD.A(new EventHandler(A));
						LD.B(0);
						LD.a(((Control)this).Width / 40);
						LD.A((int)((float)((Control)this).Width / 3f));
						LD.b(width - ((Control)this).Width + LD.A());
						if (flag2)
						{
							aQ lD = LD;
							lD.b(lD.b() + ((Control)Ld).Width);
						}
						aQ lD2 = LD;
						autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
						lD2.C(-((Point)(ref autoScrollPosition)).X);
						if (parent != null && !parent.Controls.Contains((Control)(object)LD))
						{
							parent.Controls.Add((Control)(object)LD);
						}
						((Control)LD).BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!((Control)LD).IsDisposed && !((Control)LD).Disposing)
			{
				try
				{
					((Control)LD).Visible = false;
				}
				catch
				{
				}
			}
			if (flag2)
			{
				try
				{
					if (!((Control)Ld).IsDisposed && !((Control)Ld).Disposing)
					{
						int num4 = ((Control)Lb).Top + 1;
						autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
						int num5 = num4 - ((Point)(ref autoScrollPosition)).Y;
						((Control)Ld).Visible = ((Control)this).Visible;
						((Control)Ld).Left = num + (((Control)this).Width - ((Control)Ld).Width) - 1;
						((Control)Ld).Top = num2;
						((Control)Ld).Height = (flag ? (((Control)this).Height - ((Control)LD).Height) : ((Control)this).Height);
						Ld.a(new EventHandler(this.a));
						Ld.A(new EventHandler(this.a));
						Ld.B(0);
						Ld.a(20);
						Ld.A(200);
						Ld.b(num5 - ((Control)this).Height + Ld.A());
						if (flag)
						{
							aR ld = Ld;
							ld.b(ld.b() + ((Control)LD).Height);
						}
						aR ld2 = Ld;
						autoScrollPosition = ((ScrollableControl)this).AutoScrollPosition;
						ld2.C(-((Point)(ref autoScrollPosition)).Y);
						if (parent != null && !parent.Controls.Contains((Control)(object)Ld))
						{
							parent.Controls.Add((Control)(object)Ld);
						}
						((Control)Ld).BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!((Control)Ld).IsDisposed && !((Control)Ld).Disposing)
			{
				try
				{
					((Control)Ld).Visible = false;
				}
				catch
				{
				}
			}
			if (flag && flag2)
			{
				try
				{
					if (!((Control)LE).IsDisposed && !((Control)LE).Disposing)
					{
						((Control)LE).Visible = ((Control)this).Visible;
						LE.BorderStyle = (BorderStyle)0;
						((Control)LE).BackColor = BM.tl;
						((Control)LE).Size = new Size(((Control)Ld).Width - 1, ((Control)LD).Height - 1);
						((Control)LE).Left = ((Control)LD).Right;
						((Control)LE).Top = ((Control)Ld).Bottom;
						if (parent != null && !parent.Controls.Contains((Control)(object)LE))
						{
							parent.Controls.Add((Control)(object)LE);
						}
						((Control)LE).BringToFront();
					}
					return;
				}
				catch
				{
					return;
				}
			}
			if (!((Control)LE).IsDisposed && !((Control)LE).Disposing)
			{
				try
				{
					((Control)LE).Visible = false;
					return;
				}
				catch
				{
					return;
				}
			}
			return;
		}
		if (!((Control)LD).IsDisposed && !((Control)LD).Disposing)
		{
			try
			{
				((Control)LD).Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains((Control)(object)LD))
				{
					parent.Controls.Remove((Control)(object)LD);
				}
			}
			catch
			{
			}
		}
		if (!((Control)Ld).IsDisposed && !((Control)Ld).Disposing)
		{
			try
			{
				((Control)Ld).Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains((Control)(object)Ld))
				{
					parent.Controls.Remove((Control)(object)Ld);
				}
			}
			catch
			{
			}
		}
		if (((Control)LE).IsDisposed || ((Control)LE).Disposing)
		{
			return;
		}
		try
		{
			((Control)LE).Visible = false;
		}
		catch
		{
		}
		try
		{
			if (parent != null && parent.Controls.Contains((Control)(object)LE))
			{
				parent.Controls.Remove((Control)(object)LE);
			}
		}
		catch
		{
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (kx.Count != 0)
		{
			((ScrollableControl)this).AutoScrollPosition = new Point(LD.C(), ((Control)Ld).Visible ? Ld.C() : 0);
			((Control)LD).Invalidate();
			((Control)this).Invalidate();
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (kx.Count != 0)
		{
			((ScrollableControl)this).AutoScrollPosition = new Point(((Control)LD).Visible ? LD.C() : 0, Ld.C());
			((Control)Ld).Invalidate();
			((Control)this).Invalidate();
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		if (BM.Tn != 0 && BM.Tn != BM.r.Bqh)
		{
			try
			{
				LD.a(new EventHandler(A));
				Ld.a(new EventHandler(a));
			}
			catch
			{
			}
			try
			{
				((Component)Ld).Dispose();
			}
			catch
			{
			}
			try
			{
				((Component)LD).Dispose();
			}
			catch
			{
			}
		}
		try
		{
			((ContainerControl)this).Dispose(disposing);
		}
		catch
		{
		}
	}
}
