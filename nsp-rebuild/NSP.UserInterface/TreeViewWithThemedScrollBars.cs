using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ns0;
using ns2;
using ns4;

namespace NSP.UserInterface;

public class TreeViewWithThemedScrollBars : UserControl
{
	private delegate void Delegate79();

	private const int int_0 = 3;

	private const int int_1 = 84;

	private const int int_2 = 16;

	private const int int_3 = 25;

	private const int int_4 = 16;

	private const int int_5 = 10;

	private const int int_6 = 13;

	private const int int_7 = 15;

	private const int int_8 = 18;

	private const int int_9 = 3;

	private const int int_10 = 3;

	private Enum45 enum45_0;

	private List<TreeNode> list_0 = new List<TreeNode>();

	private TreeNode treeNode_0;

	private bool bool_0;

	private bool bool_1 = true;

	private List<Image> list_1;

	private TreeNode treeNode_1;

	private TreeNode treeNode_2;

	private Label label_0 = new Label();

	private Label label_1 = new Label();

	private ToolTip toolTip_0 = new ToolTip();

	private bool bool_2;

	private Control23 control23_0 = new Control23();

	private Control26 control26_0 = new Control26();

	private Panel panel_0 = new Panel();

	[CompilerGenerated]
	private TreeViewCancelEventHandler treeViewCancelEventHandler_0;

	[CompilerGenerated]
	private TreeViewEventHandler treeViewEventHandler_0;

	[CompilerGenerated]
	private TreeViewEventHandler treeViewEventHandler_1;

	[CompilerGenerated]
	private TreeViewEventHandler treeViewEventHandler_2;

	[CompilerGenerated]
	private TreeViewEventHandler treeViewEventHandler_3;

	[CompilerGenerated]
	private ItemDragEventHandler itemDragEventHandler_0;

	protected int m_mouseDownX = -1;

	protected int m_mouseDownY = -1;

	protected TreeNode m_lastMouseOverTreeNode;

	[CompilerGenerated]
	private DrawTreeNodeEventHandler drawTreeNodeEventHandler_0;

	private const int int_11 = -16;

	private const int int_12 = 1048576;

	private const int int_13 = 2097152;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			createParams.ExStyle |= 33554432;
			return createParams;
		}
	}

	public TreeViewWithThemedScrollBars()
	{
		DoubleBuffered = true;
		AutoScroll = true;
		_ = control23_0.Handle;
		_ = control26_0.Handle;
		_ = panel_0.Handle;
		_ = Handle;
		label_0.BackColor = Color.Transparent;
		label_0.ForeColor = Color.Transparent;
		label_0.Height = 1;
		label_0.Width = Width;
		label_0.Left = 0;
		label_0.Top = 0;
		label_1.BackColor = Color.Transparent;
		label_1.ForeColor = Color.Transparent;
		label_1.Height = 1;
		label_1.Width = Width;
		label_1.Left = 0;
		label_1.Top = Height - 1;
		toolTip_0.InitialDelay = 500;
		toolTip_0.ReshowDelay = 500;
		Font = new Font(Font.FontFamily, 9f);
	}

	[SpecialName]
	internal Enum45 method_0()
	{
		return enum45_0;
	}

	[SpecialName]
	internal void method_1(Enum45 enum45_1)
	{
		enum45_0 = enum45_1;
		method_37();
	}

	[SpecialName]
	internal List<TreeNode> method_2()
	{
		return list_0;
	}

	[SpecialName]
	internal TreeNode method_3()
	{
		return treeNode_0;
	}

	[SpecialName]
	internal void method_4(TreeNode treeNode_3)
	{
		if (method_20(treeNode_3))
		{
			method_27(treeNode_3, TreeViewAction.Unknown);
		}
	}

	internal void method_5()
	{
		bool_2 = true;
	}

	internal void method_6()
	{
		bool_2 = false;
		method_37();
	}

	[SpecialName]
	internal void method_7(TreeNode treeNode_3)
	{
		treeNode_1 = treeNode_3;
		Invalidate();
	}

	[SpecialName]
	internal void method_8(TreeNode treeNode_3)
	{
		treeNode_2 = treeNode_3;
		Invalidate();
	}

	[SpecialName]
	internal bool method_9()
	{
		return bool_0;
	}

	[SpecialName]
	internal void method_10(bool bool_3)
	{
		bool_0 = bool_3;
		method_37();
	}

	[SpecialName]
	internal bool method_11()
	{
		return bool_1;
	}

	[SpecialName]
	internal void method_12(bool bool_3)
	{
		bool_1 = bool_3;
	}

	[SpecialName]
	internal List<Image> method_13()
	{
		return list_1;
	}

	[SpecialName]
	internal void method_14(List<Image> list_2)
	{
		list_1 = list_2;
	}

	[SpecialName]
	private int method_15()
	{
		return (int)Font.Size;
	}

	[SpecialName]
	private int method_16()
	{
		return (int)Font.Size * 3;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		if (keyData != Keys.Left && keyData != Keys.Right && keyData != Keys.Up && keyData != Keys.Down && keyData != Keys.Space)
		{
			return base.ProcessCmdKey(ref msg, keyData);
		}
		method_17(keyData);
		return true;
	}

	internal void method_17(Keys keys_0)
	{
		OnKeyDown(new KeyEventArgs(keys_0));
	}

	protected override void OnKeyDown(KeyEventArgs keyEventArgs_0)
	{
		base.OnKeyDown(keyEventArgs_0);
		if (treeNode_0 == null)
		{
			return;
		}
		if (((enum45_0 != Enum45.const_0 && enum45_0 != Enum45.const_2) || keyEventArgs_0.KeyData != Keys.Left) && (enum45_0 != Enum45.const_1 || keyEventArgs_0.KeyData != Keys.Up))
		{
			if (((enum45_0 != Enum45.const_0 && enum45_0 != Enum45.const_2) || keyEventArgs_0.KeyData != Keys.Right) && (enum45_0 != Enum45.const_1 || keyEventArgs_0.KeyData != Keys.Down))
			{
				if (((enum45_0 != Enum45.const_0 && enum45_0 != Enum45.const_2) || keyEventArgs_0.KeyData != Keys.Up) && (enum45_0 != Enum45.const_1 || keyEventArgs_0.KeyData != Keys.Left))
				{
					if (((enum45_0 != Enum45.const_0 && enum45_0 != Enum45.const_2) || keyEventArgs_0.KeyData != Keys.Down) && (enum45_0 != Enum45.const_1 || keyEventArgs_0.KeyData != Keys.Right))
					{
						if (keyEventArgs_0.KeyData == Keys.Space && bool_0 && bool_1)
						{
							OnAfterCheck(new TreeViewEventArgs(treeNode_0, TreeViewAction.ByKeyboard));
						}
						return;
					}
					TreeNode treeNode = method_19();
					if (treeNode != null)
					{
						method_27(treeNode, TreeViewAction.ByKeyboard);
					}
				}
				else
				{
					TreeNode treeNode2 = method_18();
					if (treeNode2 != null)
					{
						method_27(treeNode2, TreeViewAction.ByKeyboard);
					}
				}
			}
			else if (treeNode_0.Nodes.Count != 0 && !treeNode_0.IsExpanded)
			{
				OnAfterExpand(new TreeViewEventArgs(treeNode_0, TreeViewAction.ByKeyboard));
			}
		}
		else if (treeNode_0.Nodes.Count != 0 && treeNode_0.IsExpanded)
		{
			OnAfterCollapse(new TreeViewEventArgs(treeNode_0, TreeViewAction.ByKeyboard));
		}
		else if (treeNode_0.Parent != null && method_20(treeNode_0.Parent))
		{
			method_27(treeNode_0.Parent, TreeViewAction.ByKeyboard);
		}
	}

	private TreeNode method_18()
	{
		TreeNode treeNode = null;
		TreeNode treeNode2 = treeNode_0;
		while (true)
		{
			List<TreeNode> list = new List<TreeNode>();
			if (treeNode2.Parent == null)
			{
				list = list_0;
			}
			else
			{
				for (int i = 0; i < treeNode2.Parent.Nodes.Count; i++)
				{
					list.Add(treeNode2.Parent.Nodes[i]);
				}
			}
			int num = list.IndexOf(treeNode2);
			if (num > 0)
			{
				TreeNode treeNode3 = list[num - 1];
				while (treeNode3.Nodes.Count != 0 && treeNode3.IsExpanded)
				{
					treeNode = treeNode3.Nodes[treeNode3.Nodes.Count - 1];
					treeNode3 = treeNode;
				}
				treeNode = treeNode3;
			}
			else if (treeNode2.Parent != null)
			{
				treeNode = treeNode2.Parent;
			}
			if (treeNode == null || method_20(treeNode))
			{
				break;
			}
			treeNode2 = treeNode;
		}
		return treeNode;
	}

	private TreeNode method_19()
	{
		TreeNode treeNode = null;
		TreeNode treeNode2 = treeNode_0;
		while (true)
		{
			if (treeNode2.Nodes.Count == 0 || !treeNode2.IsExpanded)
			{
				do
				{
					TreeNode parent = treeNode2.Parent;
					List<TreeNode> list = new List<TreeNode>();
					if (parent == null)
					{
						list = list_0;
					}
					else
					{
						for (int i = 0; i < parent.Nodes.Count; i++)
						{
							list.Add(parent.Nodes[i]);
						}
					}
					int num = list.IndexOf(treeNode2);
					if (num < list.Count - 1)
					{
						treeNode = list[num + 1];
						continue;
					}
					if (parent == null)
					{
						break;
					}
					treeNode2 = treeNode2.Parent;
				}
				while (treeNode == null);
			}
			else
			{
				treeNode = treeNode2.Nodes[0];
			}
			if (treeNode == null || method_20(treeNode))
			{
				break;
			}
			treeNode2 = treeNode;
		}
		return treeNode;
	}

	private bool method_20(TreeNode treeNode_3)
	{
		if (treeNode_3 is Class171)
		{
			return (treeNode_3 as Class171).bool_1;
		}
		return true;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_21(TreeViewCancelEventHandler treeViewCancelEventHandler_1)
	{
		TreeViewCancelEventHandler treeViewCancelEventHandler = treeViewCancelEventHandler_0;
		TreeViewCancelEventHandler treeViewCancelEventHandler2;
		do
		{
			treeViewCancelEventHandler2 = treeViewCancelEventHandler;
			TreeViewCancelEventHandler value = (TreeViewCancelEventHandler)Delegate.Combine(treeViewCancelEventHandler2, treeViewCancelEventHandler_1);
			treeViewCancelEventHandler = Interlocked.CompareExchange(ref treeViewCancelEventHandler_0, value, treeViewCancelEventHandler2);
		}
		while ((object)treeViewCancelEventHandler != treeViewCancelEventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_22(TreeViewCancelEventHandler treeViewCancelEventHandler_1)
	{
		TreeViewCancelEventHandler treeViewCancelEventHandler = treeViewCancelEventHandler_0;
		TreeViewCancelEventHandler treeViewCancelEventHandler2;
		do
		{
			treeViewCancelEventHandler2 = treeViewCancelEventHandler;
			TreeViewCancelEventHandler value = (TreeViewCancelEventHandler)Delegate.Remove(treeViewCancelEventHandler2, treeViewCancelEventHandler_1);
			treeViewCancelEventHandler = Interlocked.CompareExchange(ref treeViewCancelEventHandler_0, value, treeViewCancelEventHandler2);
		}
		while ((object)treeViewCancelEventHandler != treeViewCancelEventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_23(TreeViewEventHandler treeViewEventHandler_4)
	{
		TreeViewEventHandler treeViewEventHandler = treeViewEventHandler_0;
		TreeViewEventHandler treeViewEventHandler2;
		do
		{
			treeViewEventHandler2 = treeViewEventHandler;
			TreeViewEventHandler value = (TreeViewEventHandler)Delegate.Combine(treeViewEventHandler2, treeViewEventHandler_4);
			treeViewEventHandler = Interlocked.CompareExchange(ref treeViewEventHandler_0, value, treeViewEventHandler2);
		}
		while ((object)treeViewEventHandler != treeViewEventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_24(TreeViewEventHandler treeViewEventHandler_4)
	{
		TreeViewEventHandler treeViewEventHandler = treeViewEventHandler_0;
		TreeViewEventHandler treeViewEventHandler2;
		do
		{
			treeViewEventHandler2 = treeViewEventHandler;
			TreeViewEventHandler value = (TreeViewEventHandler)Delegate.Remove(treeViewEventHandler2, treeViewEventHandler_4);
			treeViewEventHandler = Interlocked.CompareExchange(ref treeViewEventHandler_0, value, treeViewEventHandler2);
		}
		while ((object)treeViewEventHandler != treeViewEventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_25(TreeViewEventHandler treeViewEventHandler_4)
	{
		TreeViewEventHandler treeViewEventHandler = treeViewEventHandler_1;
		TreeViewEventHandler treeViewEventHandler2;
		do
		{
			treeViewEventHandler2 = treeViewEventHandler;
			TreeViewEventHandler value = (TreeViewEventHandler)Delegate.Combine(treeViewEventHandler2, treeViewEventHandler_4);
			treeViewEventHandler = Interlocked.CompareExchange(ref treeViewEventHandler_1, value, treeViewEventHandler2);
		}
		while ((object)treeViewEventHandler != treeViewEventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_26(TreeViewEventHandler treeViewEventHandler_4)
	{
		TreeViewEventHandler treeViewEventHandler = treeViewEventHandler_1;
		TreeViewEventHandler treeViewEventHandler2;
		do
		{
			treeViewEventHandler2 = treeViewEventHandler;
			TreeViewEventHandler value = (TreeViewEventHandler)Delegate.Remove(treeViewEventHandler2, treeViewEventHandler_4);
			treeViewEventHandler = Interlocked.CompareExchange(ref treeViewEventHandler_1, value, treeViewEventHandler2);
		}
		while ((object)treeViewEventHandler != treeViewEventHandler2);
	}

	private void method_27(TreeNode treeNode_3, TreeViewAction treeViewAction_0)
	{
		if (treeViewCancelEventHandler_0 != null)
		{
			treeViewCancelEventHandler_0(this, new TreeViewCancelEventArgs(treeNode_3, cancel: false, treeViewAction_0));
		}
		bool flag;
		if (flag = treeNode_0 != treeNode_3)
		{
			treeNode_0 = treeNode_3;
		}
		if (treeNode_0 != null)
		{
			if (!flag)
			{
				if (treeViewEventHandler_1 != null)
				{
					treeViewEventHandler_1(this, new TreeViewEventArgs(treeNode_3, treeViewAction_0));
				}
			}
			else
			{
				if (treeViewEventHandler_0 != null)
				{
					treeViewEventHandler_0(this, new TreeViewEventArgs(treeNode_3, treeViewAction_0));
				}
				if (!(treeNode_0 is Class171) || (treeNode_0 as Class171).bool_0)
				{
					for (TreeNode parent = treeNode_0.Parent; parent != null; parent = parent.Parent)
					{
						if (!parent.IsExpanded)
						{
							OnAfterExpand(new TreeViewEventArgs(parent, TreeViewAction.Unknown));
						}
					}
				}
			}
			if (control26_0.Visible)
			{
				method_28();
			}
		}
		Invalidate();
	}

	private void method_28()
	{
		int int_ = 2;
		int int_2 = 2;
		int num = 0;
		int num2;
		while (true)
		{
			if (num < list_0.Count)
			{
				TreeNode treeNode_ = list_0[num];
				num2 = method_29(treeNode_, ref int_, ref int_2);
				if (num2 != -1)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		int num3;
		if (enum45_0 != Enum45.const_0 && enum45_0 != Enum45.const_2)
		{
			num3 = 84;
		}
		else
		{
			num3 = (int)(Font.Size * 2f);
			if (enum45_0 == Enum45.const_2)
			{
				num3 += method_15();
			}
		}
		if (num2 + AutoScrollPosition.Y < num3)
		{
			int i;
			for (i = AutoScrollPosition.Y; num2 + i < num3; i += num3)
			{
			}
			i = Math.Min(0, i);
			AutoScrollPosition = new Point(control23_0.Visible ? control23_0.method_10() : 0, -i);
		}
		else if (num2 + AutoScrollPosition.Y > Height - (control23_0.Visible ? (num3 + 20) : num3))
		{
			int num4 = AutoScrollPosition.Y;
			while (num2 + num4 > Height - ((!control23_0.Visible) ? num3 : (num3 + 20)))
			{
				num4 -= num3;
			}
			num4 = Math.Max(-(control26_0.method_8() - control26_0.method_2()), num4);
			AutoScrollPosition = new Point(control23_0.Visible ? control23_0.method_10() : 0, -num4);
		}
		method_48();
		control26_0.Invalidate();
	}

	private int method_29(TreeNode treeNode_3, ref int int_14, ref int int_15)
	{
		if (enum45_0 != Enum45.const_0 && enum45_0 != Enum45.const_2)
		{
			int num = 0;
			int num2;
			int num3;
			if (treeNode_3.ImageIndex != -1)
			{
				num2 = method_47() + 84 - treeNode_3.Level * 16;
				num3 = 84 - treeNode_3.Level * 16;
			}
			else
			{
				num = treeNode_3.Level * 16;
				num2 = Width - 4 - num;
				num3 = 25;
				if (int_14 != 2)
				{
					int_14 = 2;
					int_15 += 84 - treeNode_3.Level * 16;
				}
			}
			if (treeNode_3 == treeNode_0)
			{
				return int_15;
			}
			int_14 += num2;
			if (int_14 >= Width - (2 + control26_0.Width) - num2)
			{
				int_14 = 2;
				int_15 += num3;
			}
			if (treeNode_3.IsExpanded && treeNode_3.Nodes.Count != 0)
			{
				if (int_14 != 2)
				{
					int_14 = 2;
					int_15 += num3;
				}
				for (int i = 0; i < treeNode_3.Nodes.Count; i++)
				{
					TreeNode treeNode_4 = treeNode_3.Nodes[i];
					int num4 = method_29(treeNode_4, ref int_14, ref int_15);
					if (num4 == -1)
					{
						if (i == treeNode_3.Nodes.Count - 1 && int_14 != 2)
						{
							int num5 = 84 - (treeNode_3.Level + 1) * 16;
							int_14 = 2;
							int_15 += num5;
						}
						continue;
					}
					return num4;
				}
			}
			return -1;
		}
		if (treeNode_3 == treeNode_0)
		{
			return int_15;
		}
		int_15 += (int)(Font.Size * 2f);
		if (enum45_0 == Enum45.const_2)
		{
			int_15 += method_15();
		}
		if (treeNode_3.IsExpanded && treeNode_3.Nodes.Count != 0)
		{
			int_14 += 10;
			for (int j = 0; j < treeNode_3.Nodes.Count; j++)
			{
				TreeNode treeNode_5 = treeNode_3.Nodes[j];
				int num6 = method_29(treeNode_5, ref int_14, ref int_15);
				if (num6 != -1)
				{
					return num6;
				}
			}
			int_14 -= 10;
		}
		return -1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_30(TreeViewEventHandler treeViewEventHandler_4)
	{
		TreeViewEventHandler treeViewEventHandler = treeViewEventHandler_2;
		TreeViewEventHandler treeViewEventHandler2;
		do
		{
			treeViewEventHandler2 = treeViewEventHandler;
			TreeViewEventHandler value = (TreeViewEventHandler)Delegate.Combine(treeViewEventHandler2, treeViewEventHandler_4);
			treeViewEventHandler = Interlocked.CompareExchange(ref treeViewEventHandler_2, value, treeViewEventHandler2);
		}
		while ((object)treeViewEventHandler != treeViewEventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_31(TreeViewEventHandler treeViewEventHandler_4)
	{
		TreeViewEventHandler treeViewEventHandler = treeViewEventHandler_2;
		TreeViewEventHandler treeViewEventHandler2;
		do
		{
			treeViewEventHandler2 = treeViewEventHandler;
			TreeViewEventHandler value = (TreeViewEventHandler)Delegate.Remove(treeViewEventHandler2, treeViewEventHandler_4);
			treeViewEventHandler = Interlocked.CompareExchange(ref treeViewEventHandler_2, value, treeViewEventHandler2);
		}
		while ((object)treeViewEventHandler != treeViewEventHandler2);
	}

	protected virtual void OnAfterExpand(TreeViewEventArgs treeViewEventArgs_0)
	{
		treeViewEventArgs_0.Node.Expand();
		if (treeViewEventHandler_2 != null)
		{
			treeViewEventHandler_2(this, treeViewEventArgs_0);
		}
		method_37();
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_32(TreeViewEventHandler treeViewEventHandler_4)
	{
		TreeViewEventHandler treeViewEventHandler = treeViewEventHandler_3;
		TreeViewEventHandler treeViewEventHandler2;
		do
		{
			treeViewEventHandler2 = treeViewEventHandler;
			TreeViewEventHandler value = (TreeViewEventHandler)Delegate.Combine(treeViewEventHandler2, treeViewEventHandler_4);
			treeViewEventHandler = Interlocked.CompareExchange(ref treeViewEventHandler_3, value, treeViewEventHandler2);
		}
		while ((object)treeViewEventHandler != treeViewEventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_33(TreeViewEventHandler treeViewEventHandler_4)
	{
		TreeViewEventHandler treeViewEventHandler = treeViewEventHandler_3;
		TreeViewEventHandler treeViewEventHandler2;
		do
		{
			treeViewEventHandler2 = treeViewEventHandler;
			TreeViewEventHandler value = (TreeViewEventHandler)Delegate.Remove(treeViewEventHandler2, treeViewEventHandler_4);
			treeViewEventHandler = Interlocked.CompareExchange(ref treeViewEventHandler_3, value, treeViewEventHandler2);
		}
		while ((object)treeViewEventHandler != treeViewEventHandler2);
	}

	protected virtual void OnAfterCollapse(TreeViewEventArgs treeViewEventArgs_0)
	{
		treeViewEventArgs_0.Node.Collapse();
		if (treeViewEventHandler_3 != null)
		{
			treeViewEventHandler_3(this, treeViewEventArgs_0);
		}
		method_37();
	}

	protected virtual void OnAfterCheck(TreeViewEventArgs treeViewEventArgs_0)
	{
		bool bool_ = !treeViewEventArgs_0.Node.Checked;
		smethod_0(treeViewEventArgs_0.Node, bool_);
		Invalidate();
	}

	internal void method_34(bool bool_3)
	{
		foreach (TreeNode item in method_2())
		{
			if (bool_3)
			{
				foreach (TreeNode node in item.Nodes)
				{
					OnAfterCollapse(new TreeViewEventArgs(node, TreeViewAction.ByKeyboard));
				}
			}
			else
			{
				OnAfterCollapse(new TreeViewEventArgs(item, TreeViewAction.ByKeyboard));
			}
		}
	}

	internal void method_35()
	{
		foreach (TreeNode item in method_2())
		{
			method_36(item);
		}
	}

	private void method_36(TreeNode treeNode_3)
	{
		OnAfterExpand(new TreeViewEventArgs(treeNode_3, TreeViewAction.Expand));
		foreach (TreeNode node in treeNode_3.Nodes)
		{
			method_36(node);
		}
	}

	internal static void smethod_0(TreeNode treeNode_3, bool bool_3)
	{
		treeNode_3.Checked = bool_3;
		foreach (TreeNode node in treeNode_3.Nodes)
		{
			smethod_0(node, bool_3);
		}
	}

	internal static bool smethod_1(TreeNode treeNode_3)
	{
		foreach (TreeNode node in treeNode_3.Nodes)
		{
			if (!node.Checked)
			{
				if (smethod_1(node))
				{
					return true;
				}
				continue;
			}
			return true;
		}
		return false;
	}

	internal static bool smethod_2(TreeNode treeNode_3)
	{
		foreach (TreeNode node in treeNode_3.Nodes)
		{
			if (node.Checked)
			{
				if (smethod_2(node))
				{
					return true;
				}
				continue;
			}
			return true;
		}
		return false;
	}

	protected override void OnMouseWheel(MouseEventArgs mouseEventArgs_0)
	{
		base.OnMouseWheel(mouseEventArgs_0);
		method_48();
		if (control26_0.Visible)
		{
			control26_0.Invalidate();
		}
		Invalidate();
	}

	protected override void OnVisibleChanged(EventArgs eventArgs_0)
	{
		base.OnVisibleChanged(eventArgs_0);
		if (!Visible)
		{
			control23_0.Visible = false;
			control26_0.Visible = false;
			panel_0.Visible = false;
		}
		else
		{
			method_37();
		}
	}

	protected override void OnResize(EventArgs eventargs)
	{
		base.OnResize(eventargs);
		method_37();
	}

	internal void method_37()
	{
		bool autoScroll = AutoScroll;
		Point autoScrollPosition = AutoScrollPosition;
		AutoScroll = false;
		int int_ = 2;
		int int_2 = 2;
		int int_3 = 0;
		int int_4 = 0;
		for (int i = 0; i < list_0.Count; i++)
		{
			TreeNode treeNode_ = list_0[i];
			method_38(treeNode_, ref int_, ref int_2, ref int_3, ref int_4);
		}
		label_0.Width = int_3;
		label_1.Width = int_3;
		if (int_3 > Width)
		{
			int_4 += 20;
		}
		label_1.Top = Math.Max(int_4 - 1, Height - 1);
		if (!Controls.Contains(label_0))
		{
			Controls.Add(label_0);
		}
		if (!Controls.Contains(label_1))
		{
			Controls.Add(label_1);
		}
		if (autoScroll)
		{
			AutoScroll = true;
			AutoScrollPosition = new Point(-autoScrollPosition.X, -autoScrollPosition.Y);
		}
		method_48();
		control23_0.Invalidate();
		control26_0.Invalidate();
		Invalidate();
	}

	private void method_38(TreeNode treeNode_3, ref int int_14, ref int int_15, ref int int_16, ref int int_17)
	{
		int num = method_47();
		if (enum45_0 != Enum45.const_0 && enum45_0 != Enum45.const_2)
		{
			int num2 = 0;
			int num3;
			int num4;
			if (treeNode_3.ImageIndex != -1)
			{
				num3 = num + 84 - treeNode_3.Level * 16;
				num4 = 84 - treeNode_3.Level * 16;
			}
			else
			{
				num2 = treeNode_3.Level * 16;
				num3 = Width - 4 - num2;
				num4 = 25;
				if (int_14 != 2)
				{
					int_14 = 2;
					int_15 += 84 - treeNode_3.Level * 16;
				}
			}
			int_16 = Math.Max(int_14 + num3, int_16);
			int_17 = Math.Max(int_15 + num4, int_17);
			int_14 += num3;
			if (int_14 >= Width - (2 + control26_0.Width) - num3)
			{
				int_14 = 2;
				int_15 += num4;
			}
			if (!treeNode_3.IsExpanded || treeNode_3.Nodes.Count == 0)
			{
				return;
			}
			if (int_14 != 2)
			{
				int_14 = 2;
				int_15 += num4;
			}
			for (int i = 0; i < treeNode_3.Nodes.Count; i++)
			{
				TreeNode treeNode_4 = treeNode_3.Nodes[i];
				method_38(treeNode_4, ref int_14, ref int_15, ref int_16, ref int_17);
				if (i == treeNode_3.Nodes.Count - 1 && int_14 != 2)
				{
					int num5 = 84 - (treeNode_3.Level + 1) * 16;
					int_14 = 2;
					int_15 += num5;
				}
			}
			return;
		}
		int num6 = int_14 + num;
		if (bool_0)
		{
			num6 += 21;
		}
		else if (enum45_0 == Enum45.const_2)
		{
			num6 += 3 + method_16();
		}
		Font font = ((treeNode_3.Parent == null || treeNode_3.Parent.Parent != null) ? new Font(Font.FontFamily, Font.Size, Font.Style) : new Font(Font.FontFamily, Font.Size, FontStyle.Bold));
		int width = TextRenderer.MeasureText(treeNode_3.Text, font, new Size(int.MaxValue, int.MaxValue), TextFormatFlags.NoPrefix).Width;
		font.Dispose();
		int_16 = Math.Max(num6 + width, int_16);
		int num7 = (int)(Font.Size * 2f);
		if (enum45_0 == Enum45.const_2)
		{
			num7 += method_15();
		}
		int_17 = Math.Max(int_15 + num7, int_17);
		int_15 += num7;
		if (treeNode_3.IsExpanded && treeNode_3.Nodes.Count != 0)
		{
			int_14 += 10;
			for (int j = 0; j < treeNode_3.Nodes.Count; j++)
			{
				TreeNode treeNode_5 = treeNode_3.Nodes[j];
				method_38(treeNode_5, ref int_14, ref int_15, ref int_16, ref int_17);
			}
			int_14 -= 10;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_39(ItemDragEventHandler itemDragEventHandler_1)
	{
		ItemDragEventHandler itemDragEventHandler = itemDragEventHandler_0;
		ItemDragEventHandler itemDragEventHandler2;
		do
		{
			itemDragEventHandler2 = itemDragEventHandler;
			ItemDragEventHandler value = (ItemDragEventHandler)Delegate.Combine(itemDragEventHandler2, itemDragEventHandler_1);
			itemDragEventHandler = Interlocked.CompareExchange(ref itemDragEventHandler_0, value, itemDragEventHandler2);
		}
		while ((object)itemDragEventHandler != itemDragEventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_40(ItemDragEventHandler itemDragEventHandler_1)
	{
		ItemDragEventHandler itemDragEventHandler = itemDragEventHandler_0;
		ItemDragEventHandler itemDragEventHandler2;
		do
		{
			itemDragEventHandler2 = itemDragEventHandler;
			ItemDragEventHandler value = (ItemDragEventHandler)Delegate.Remove(itemDragEventHandler2, itemDragEventHandler_1);
			itemDragEventHandler = Interlocked.CompareExchange(ref itemDragEventHandler_0, value, itemDragEventHandler2);
		}
		while ((object)itemDragEventHandler != itemDragEventHandler2);
	}

	protected override void OnMouseDown(MouseEventArgs mouseEventArgs_0)
	{
		base.OnMouseDown(mouseEventArgs_0);
		m_mouseDownX = mouseEventArgs_0.X;
		m_mouseDownY = mouseEventArgs_0.Y;
	}

	protected override void OnMouseMove(MouseEventArgs mevent)
	{
		base.OnMouseMove(mevent);
		if (mevent.Button == MouseButtons.None)
		{
			TreeNode treeNode = method_41(mevent.X, mevent.Y, out var _);
			if (m_lastMouseOverTreeNode == null || treeNode != m_lastMouseOverTreeNode)
			{
				m_lastMouseOverTreeNode = treeNode;
				Invalidate();
			}
			if (treeNode != null && !string.IsNullOrWhiteSpace(treeNode.ToolTipText))
			{
				if (!(toolTip_0.GetToolTip(this) != treeNode.ToolTipText))
				{
					return;
				}
				if (enum45_0 == Enum45.const_1)
				{
					toolTip_0.Active = true;
					toolTip_0.Show(treeNode.ToolTipText, this, mevent.X + 7, mevent.Y + 7);
					return;
				}
				if (treeNode.ToolTipText != treeNode.Text)
				{
					toolTip_0.Active = true;
					toolTip_0.Show(treeNode.ToolTipText, this, mevent.X + 2, mevent.Y + 2);
					return;
				}
				Font font = ((treeNode.Parent == null || treeNode.Parent.Parent != null) ? new Font(Font.FontFamily, Font.Size, Font.Style) : new Font(Font.FontFamily, Font.Size, FontStyle.Bold));
				int width = TextRenderer.MeasureText(treeNode.Text, font, new Size(int.MaxValue, int.MaxValue), TextFormatFlags.NoPrefix).Width;
				font.Dispose();
				int num = method_47();
				if (bool_0)
				{
					num += 21;
				}
				if (enum45_0 == Enum45.const_2)
				{
					num += 3 + method_16();
				}
				for (TreeNode parent = treeNode.Parent; parent != null; parent = parent.Parent)
				{
					num += 10;
				}
				if ((control26_0.Visible && num + width > Width - 18) || (!control26_0.Visible && num + width > Width))
				{
					toolTip_0.Active = true;
					toolTip_0.Show(treeNode.ToolTipText, this, mevent.X + 2, mevent.Y + 2);
				}
				else
				{
					toolTip_0.Active = false;
					toolTip_0.Hide(this);
				}
			}
			else
			{
				toolTip_0.Active = false;
				toolTip_0.Hide(this);
			}
			return;
		}
		if (m_lastMouseOverTreeNode != null)
		{
			m_lastMouseOverTreeNode = null;
			Invalidate();
		}
		if (mevent.Button != MouseButtons.Left || m_mouseDownX == -1 || m_mouseDownY == -1 || (Math.Abs(mevent.X - m_mouseDownX) < 2 && Math.Abs(mevent.Y - m_mouseDownY) < 2))
		{
			return;
		}
		int int_ = 2;
		int int_2 = 2;
		for (int i = 0; i < list_0.Count; i++)
		{
			TreeNode treeNode_ = list_0[i];
			if (method_42(treeNode_, m_mouseDownX, m_mouseDownY, bool_3: false, bool_4: true, bool_5: false, ref int_, ref int_2, out var _) != null)
			{
				break;
			}
		}
		m_mouseDownX = -1;
		m_mouseDownY = -1;
	}

	protected override void OnMouseUp(MouseEventArgs mevent)
	{
		base.OnMouseUp(mevent);
		m_mouseDownX = -1;
		m_mouseDownY = -1;
	}

	protected override void OnMouseLeave(EventArgs eventArgs_0)
	{
		base.OnMouseLeave(eventArgs_0);
		toolTip_0.Active = false;
		toolTip_0.Hide(this);
		m_lastMouseOverTreeNode = null;
		Invalidate();
	}

	protected override void OnMouseClick(MouseEventArgs mouseEventArgs_0)
	{
		base.OnMouseClick(mouseEventArgs_0);
		int x = mouseEventArgs_0.X;
		int y = mouseEventArgs_0.Y;
		int int_ = 2;
		int int_2 = 2;
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				TreeNode treeNode_ = list_0[num];
				if (method_42(treeNode_, x, y, bool_3: false, bool_4: false, bool_5: false, ref int_, ref int_2, out var _) != null)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		Invalidate();
	}

	protected override void OnMouseDoubleClick(MouseEventArgs mouseEventArgs_0)
	{
		base.OnMouseDoubleClick(mouseEventArgs_0);
		if (mouseEventArgs_0.Button != MouseButtons.Left)
		{
			return;
		}
		int x = mouseEventArgs_0.X;
		int y = mouseEventArgs_0.Y;
		int int_ = 2;
		int int_2 = 2;
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				TreeNode treeNode_ = list_0[num];
				if (method_42(treeNode_, x, y, bool_3: true, bool_4: false, bool_5: false, ref int_, ref int_2, out var _) != null)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		Invalidate();
	}

	internal TreeNode method_41(int int_14, int int_15, out Rectangle rectangle_0)
	{
		int int_16 = 2;
		int int_17 = 2;
		int num = 0;
		TreeNode treeNode;
		Rectangle rectangle_1;
		while (true)
		{
			if (num < list_0.Count)
			{
				treeNode = method_42(list_0[num], int_14, int_15, bool_3: false, bool_4: false, bool_5: true, ref int_16, ref int_17, out rectangle_1);
				if (treeNode != null)
				{
					break;
				}
				num++;
				continue;
			}
			rectangle_0 = Rectangle.Empty;
			return null;
		}
		rectangle_0 = rectangle_1;
		return treeNode;
	}

	private TreeNode method_42(TreeNode treeNode_3, int int_14, int int_15, bool bool_3, bool bool_4, bool bool_5, ref int int_16, ref int int_17, out Rectangle rectangle_0)
	{
		int num = method_47();
		if (enum45_0 != Enum45.const_0 && enum45_0 != Enum45.const_2)
		{
			int num2 = 0;
			int num3;
			int num4;
			if (treeNode_3.ImageIndex != -1)
			{
				num3 = num + 84 - treeNode_3.Level * 16;
				num4 = 84 - treeNode_3.Level * 16;
			}
			else
			{
				num2 = treeNode_3.Level * 16;
				num3 = Width - 4 - num2;
				num4 = 25;
				if (int_16 != 2)
				{
					int_16 = 2;
					int_17 += 84 - treeNode_3.Level * 16;
				}
			}
			rectangle_0 = new Rectangle(int_16 + AutoScrollPosition.X + num2, int_17 + AutoScrollPosition.Y, num3, num4);
			if (int_14 >= int_16 + AutoScrollPosition.X + num2 && int_14 < int_16 + AutoScrollPosition.X + num2 + num3 && int_15 >= int_17 + AutoScrollPosition.Y && int_15 < int_17 + AutoScrollPosition.Y + num4)
			{
				if (bool_5)
				{
					return treeNode_3;
				}
				if (bool_4)
				{
					if (itemDragEventHandler_0 != null)
					{
						itemDragEventHandler_0(this, new ItemDragEventArgs(MouseButtons.Left, treeNode_3));
					}
					return treeNode_3;
				}
				bool flag;
				if ((flag = treeNode_3.Nodes.Count != 0) && int_14 < int_16 + AutoScrollPosition.X + num2 + num)
				{
					if (treeNode_3.IsExpanded)
					{
						OnAfterCollapse(new TreeViewEventArgs(treeNode_3, TreeViewAction.ByMouse));
					}
					else
					{
						OnAfterExpand(new TreeViewEventArgs(treeNode_3, TreeViewAction.ByMouse));
					}
					return treeNode_3;
				}
				if (bool_3)
				{
					if (flag)
					{
						if (treeNode_3.IsExpanded)
						{
							OnAfterCollapse(new TreeViewEventArgs(treeNode_3, TreeViewAction.ByMouse));
						}
						else
						{
							OnAfterExpand(new TreeViewEventArgs(treeNode_3, TreeViewAction.ByMouse));
						}
					}
				}
				else if (method_20(treeNode_3))
				{
					method_27(treeNode_3, TreeViewAction.ByMouse);
				}
				else if (flag)
				{
					if (treeNode_3.IsExpanded)
					{
						OnAfterCollapse(new TreeViewEventArgs(treeNode_3, TreeViewAction.ByMouse));
					}
					else
					{
						OnAfterExpand(new TreeViewEventArgs(treeNode_3, TreeViewAction.ByMouse));
					}
				}
				return treeNode_3;
			}
			int_16 += num3;
			if (int_16 >= Width - (2 + control26_0.Width) - num3)
			{
				int_16 = 2;
				int_17 += num4;
			}
			if (treeNode_3.IsExpanded && treeNode_3.Nodes.Count != 0)
			{
				if (int_16 != 2)
				{
					int_16 = 2;
					int_17 += num4;
				}
				for (int i = 0; i < treeNode_3.Nodes.Count; i++)
				{
					TreeNode treeNode = method_42(treeNode_3.Nodes[i], int_14, int_15, bool_3, bool_4, bool_5, ref int_16, ref int_17, out var rectangle_1);
					if (treeNode == null)
					{
						if (i == treeNode_3.Nodes.Count - 1 && int_16 != 2)
						{
							int num5 = 84 - (treeNode_3.Level + 1) * 16;
							int_16 = 2;
							int_17 += num5;
						}
						continue;
					}
					rectangle_0 = rectangle_1;
					return treeNode;
				}
			}
			rectangle_0 = Rectangle.Empty;
			return null;
		}
		int num6 = Width - 4 - (int_16 + AutoScrollPosition.X);
		int y = int_17 + AutoScrollPosition.Y;
		int num7 = (int)(Font.Size * 2f);
		if (enum45_0 == Enum45.const_2)
		{
			num6 += method_16();
			num7 += method_15();
		}
		Rectangle rectangle = (rectangle_0 = new Rectangle(int_16 + AutoScrollPosition.X, y, num6, num7));
		if (int_14 >= rectangle.X && int_14 < rectangle.X + rectangle.Width && int_15 >= rectangle.Y && int_15 < rectangle.Y + rectangle.Height)
		{
			if (bool_5)
			{
				return treeNode_3;
			}
			if (bool_4)
			{
				if (itemDragEventHandler_0 != null)
				{
					itemDragEventHandler_0(this, new ItemDragEventArgs(MouseButtons.Left, treeNode_3));
				}
				return treeNode_3;
			}
			bool flag2;
			if ((flag2 = treeNode_3.Nodes.Count != 0) && int_14 <= rectangle.X + num)
			{
				if (treeNode_3.IsExpanded)
				{
					OnAfterCollapse(new TreeViewEventArgs(treeNode_3, TreeViewAction.ByMouse));
				}
				else
				{
					OnAfterExpand(new TreeViewEventArgs(treeNode_3, TreeViewAction.ByMouse));
				}
				return treeNode_3;
			}
			if (bool_0 && int_14 > rectangle.X + num + 3 && int_14 < rectangle.X + num + 3 + 18)
			{
				if (bool_1)
				{
					OnAfterCheck(new TreeViewEventArgs(treeNode_3, TreeViewAction.ByMouse));
				}
				return treeNode_3;
			}
			if (bool_3)
			{
				if (flag2)
				{
					if (treeNode_3.IsExpanded)
					{
						OnAfterCollapse(new TreeViewEventArgs(treeNode_3, TreeViewAction.ByMouse));
					}
					else
					{
						OnAfterExpand(new TreeViewEventArgs(treeNode_3, TreeViewAction.ByMouse));
					}
				}
			}
			else if (method_20(treeNode_3))
			{
				method_27(treeNode_3, TreeViewAction.ByMouse);
			}
			else if (flag2)
			{
				if (treeNode_3.IsExpanded)
				{
					OnAfterCollapse(new TreeViewEventArgs(treeNode_3, TreeViewAction.ByMouse));
				}
				else
				{
					OnAfterExpand(new TreeViewEventArgs(treeNode_3, TreeViewAction.ByMouse));
				}
			}
			return treeNode_3;
		}
		int_17 += (int)(Font.Size * 2f);
		if (enum45_0 == Enum45.const_2)
		{
			int_17 += method_15();
		}
		if (treeNode_3.IsExpanded && treeNode_3.Nodes.Count != 0)
		{
			int_16 += 10;
			for (int j = 0; j < treeNode_3.Nodes.Count; j++)
			{
				TreeNode treeNode2 = method_42(treeNode_3.Nodes[j], int_14, int_15, bool_3, bool_4, bool_5, ref int_16, ref int_17, out var rectangle_2);
				if (treeNode2 != null)
				{
					rectangle_0 = rectangle_2;
					return treeNode2;
				}
			}
			int_16 -= 10;
		}
		rectangle_0 = Rectangle.Empty;
		return null;
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		if (bool_2)
		{
			return;
		}
		Graphics graphics = paintEventArgs_0.Graphics;
		if (Form23.bool_43)
		{
			using Pen pen = new Pen(Color.Gray, 1f);
			graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
		}
		int int_ = 2;
		int int_2 = 2;
		for (int i = 0; i < list_0.Count; i++)
		{
			TreeNode treeNode_ = list_0[i];
			method_45(graphics, treeNode_, ref int_, ref int_2);
		}
		base.OnPaint(paintEventArgs_0);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_43(DrawTreeNodeEventHandler drawTreeNodeEventHandler_1)
	{
		DrawTreeNodeEventHandler drawTreeNodeEventHandler = drawTreeNodeEventHandler_0;
		DrawTreeNodeEventHandler drawTreeNodeEventHandler2;
		do
		{
			drawTreeNodeEventHandler2 = drawTreeNodeEventHandler;
			DrawTreeNodeEventHandler value = (DrawTreeNodeEventHandler)Delegate.Combine(drawTreeNodeEventHandler2, drawTreeNodeEventHandler_1);
			drawTreeNodeEventHandler = Interlocked.CompareExchange(ref drawTreeNodeEventHandler_0, value, drawTreeNodeEventHandler2);
		}
		while ((object)drawTreeNodeEventHandler != drawTreeNodeEventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_44(DrawTreeNodeEventHandler drawTreeNodeEventHandler_1)
	{
		DrawTreeNodeEventHandler drawTreeNodeEventHandler = drawTreeNodeEventHandler_0;
		DrawTreeNodeEventHandler drawTreeNodeEventHandler2;
		do
		{
			drawTreeNodeEventHandler2 = drawTreeNodeEventHandler;
			DrawTreeNodeEventHandler value = (DrawTreeNodeEventHandler)Delegate.Remove(drawTreeNodeEventHandler2, drawTreeNodeEventHandler_1);
			drawTreeNodeEventHandler = Interlocked.CompareExchange(ref drawTreeNodeEventHandler_0, value, drawTreeNodeEventHandler2);
		}
		while ((object)drawTreeNodeEventHandler != drawTreeNodeEventHandler2);
	}

	private void method_45(Graphics graphics_0, TreeNode treeNode_3, ref int int_14, ref int int_15)
	{
		bool flag = treeNode_3 is Class171 && (treeNode_3 as Class171).bool_1 && treeNode_3 == m_lastMouseOverTreeNode;
		int num = method_47();
		if (enum45_0 != Enum45.const_0 && enum45_0 != Enum45.const_2)
		{
			int num2 = 0;
			int num3;
			int num4;
			if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
			{
				num3 = Math.Min(treeNode_3.Level * 85, 255);
				num4 = Math.Min((treeNode_3.Level + 1) * 85, 255);
			}
			else
			{
				num3 = Math.Max(255 - treeNode_3.Level * 85, 0);
				num4 = Math.Max(255 - (treeNode_3.Level + 1) * 85, 0);
			}
			int num5;
			int num6;
			if (treeNode_3.ImageIndex != -1)
			{
				num5 = num + 84 - treeNode_3.Level * 16;
				num6 = 84 - treeNode_3.Level * 16;
			}
			else
			{
				num2 = treeNode_3.Level * 16;
				num5 = Width - 4 - num2;
				num6 = 25;
				if (int_14 != 2)
				{
					int num7 = 84 - treeNode_3.Level * 16;
					using (SolidBrush brush = new SolidBrush(Color.FromArgb(num3, num3, num3)))
					{
						graphics_0.FillRectangle(brush, int_14 + AutoScrollPosition.X, int_15 + AutoScrollPosition.Y, Width - 2 - int_14, num7);
					}
					int_14 = 2;
					int_15 += num7;
				}
			}
			if (treeNode_3.IsExpanded && treeNode_3.GetNodeCount(includeSubTrees: true) != 0)
			{
				using SolidBrush brush2 = new SolidBrush(Color.FromArgb(num4, num4, num4));
				graphics_0.FillRectangle(brush2, int_14 + AutoScrollPosition.X, int_15 + AutoScrollPosition.Y, Width - 2 - int_14, num6);
			}
			else
			{
				using SolidBrush brush3 = new SolidBrush(Color.FromArgb(num3, num3, num3));
				graphics_0.FillRectangle(brush3, int_14 + AutoScrollPosition.X, int_15 + AutoScrollPosition.Y, Width - 2 - int_14, num6);
			}
			Rectangle rect = new Rectangle(int_14 + AutoScrollPosition.X + num2 + num + 3, int_15 + AutoScrollPosition.Y + 3, num5 - num - 6, num6 - 6);
			if (treeNode_3.ForeColor != Form23.color_12)
			{
				using SolidBrush brush4 = new SolidBrush(treeNode_3.ForeColor);
				graphics_0.FillRectangle(brush4, rect);
			}
			else
			{
				using SolidBrush brush5 = new SolidBrush(Color.LightGray);
				graphics_0.FillRectangle(brush5, rect);
			}
			if (treeNode_3 == treeNode_0)
			{
				using Pen pen = new Pen(Color.DodgerBlue, 3f);
				graphics_0.DrawRectangle(pen, rect);
			}
			if (flag)
			{
				using Pen pen2 = new Pen(Color.DodgerBlue, 2f);
				graphics_0.DrawRectangle(pen2, new Rectangle(rect.X - 1, rect.Y - 1, rect.Width + 3, rect.Height + 3));
			}
			if (treeNode_3.ImageIndex != -1)
			{
				Image image = method_13()[treeNode_3.ImageIndex];
				graphics_0.DrawImage(image, rect.X - 1, rect.Y - 1, rect.Width + 2, rect.Height + 2);
			}
			if (treeNode_3.Nodes.Count != 0)
			{
				method_46(treeNode_3, graphics_0, int_14 + num2, int_15 + (num6 >> 1));
			}
			if (treeNode_3.ImageIndex == -1)
			{
				using Font font = new Font(Font.FontFamily, 8f);
				TextRenderer.DrawText(bounds: new Rectangle(rect.X + 1, rect.Y + 1, num5 - (num + 8), num6 - 8), dc: graphics_0, text: treeNode_3.Text, font: font, foreColor: Color.Black, flags: TextFormatFlags.NoPrefix);
			}
			if (drawTreeNodeEventHandler_0 != null)
			{
				TreeNodeStates treeNodeStates = (TreeNodeStates)0;
				if (treeNode_3 == treeNode_0)
				{
					treeNodeStates |= TreeNodeStates.Selected;
				}
				if (treeNode_3.Checked)
				{
					treeNodeStates |= TreeNodeStates.Checked;
				}
				Rectangle bounds = new Rectangle(int_14 + AutoScrollPosition.X, int_15 + AutoScrollPosition.Y, num5, num6);
				drawTreeNodeEventHandler_0(this, new DrawTreeNodeEventArgs(graphics_0, treeNode_3, bounds, treeNodeStates));
			}
			int_14 += num5;
			if (int_14 >= Width - (2 + control26_0.Width) - num5)
			{
				using (SolidBrush brush6 = new SolidBrush(Color.FromArgb(num3, num3, num3)))
				{
					graphics_0.FillRectangle(brush6, int_14 + AutoScrollPosition.X + num2, int_15 + AutoScrollPosition.Y, Width - 2 - (int_14 + num2), num6);
				}
				int_14 = 2;
				int_15 += num6;
			}
			if (!treeNode_3.IsExpanded || treeNode_3.Nodes.Count == 0)
			{
				return;
			}
			if (int_14 != 2)
			{
				using (SolidBrush brush7 = new SolidBrush(Color.FromArgb(num3, num3, num3)))
				{
					graphics_0.FillRectangle(brush7, int_14 + AutoScrollPosition.X, int_15 + AutoScrollPosition.Y, Width - 2 - int_14, num6);
				}
				int_14 = 2;
				int_15 += num6;
			}
			for (int i = 0; i < treeNode_3.Nodes.Count; i++)
			{
				TreeNode treeNode_4 = treeNode_3.Nodes[i];
				method_45(graphics_0, treeNode_4, ref int_14, ref int_15);
				if (i == treeNode_3.Nodes.Count - 1 && int_14 != 2)
				{
					int num8 = 84 - (treeNode_3.Level + 1) * 16;
					using (SolidBrush brush8 = new SolidBrush(Color.FromArgb(num4, num4, num4)))
					{
						graphics_0.FillRectangle(brush8, int_14 + AutoScrollPosition.X, int_15 + AutoScrollPosition.Y, Width - 2 - int_14, num8);
					}
					int_14 = 2;
					int_15 += num8;
				}
			}
			return;
		}
		bool flag2;
		Font font2;
		if ((flag2 = treeNode_3.Parent != null && treeNode_3.Parent.Parent == null) | flag)
		{
			FontStyle fontStyle = Font.Style;
			if (flag2)
			{
				fontStyle |= FontStyle.Bold;
			}
			if (flag)
			{
				fontStyle |= FontStyle.Underline;
			}
			font2 = new Font(Font.FontFamily, Font.Size, fontStyle);
		}
		else
		{
			font2 = Font;
		}
		int width = TextRenderer.MeasureText(treeNode_3.Text, font2, new Size(int.MaxValue, int.MaxValue), TextFormatFlags.NoPrefix).Width;
		int num9 = num;
		int width2;
		if (bool_0)
		{
			width2 = num + 3 + 18 + width;
			num9 += 21;
		}
		else if (enum45_0 == Enum45.const_2)
		{
			width2 = num + 3 + method_16() + width;
			num9 += 3 + method_16();
		}
		else
		{
			width2 = num + width;
		}
		if (treeNode_3.Nodes.Count != 0)
		{
			if (enum45_0 == Enum45.const_2)
			{
				method_46(treeNode_3, graphics_0, int_14, int_15 + method_16() / 2);
			}
			else
			{
				method_46(treeNode_3, graphics_0, int_14, int_15 + (int)Math.Round(Font.Size));
			}
		}
		if (bool_0)
		{
			Class148.smethod_0(enum43_0: (treeNode_3.Nodes.Count == 0) ? (treeNode_3.Checked ? Enum43.const_1 : Enum43.const_0) : (smethod_2(treeNode_3) ? (smethod_1(treeNode_3) ? Enum43.const_2 : Enum43.const_0) : (treeNode_3.Checked ? Enum43.const_1 : Enum43.const_2)), graphics_0: graphics_0, color_0: BackColor, int_0: int_14 + AutoScrollPosition.X + num9 - 18, int_1: int_15 + AutoScrollPosition.Y, bool_1: true, bool_2: false, bool_3: false);
		}
		Rectangle rectangle2;
		if (enum45_0 == Enum45.const_2 && !bool_0)
		{
			int y = int_15 + AutoScrollPosition.Y;
			if (treeNode_3.ImageIndex != -1)
			{
				Rectangle rectangle = new Rectangle(int_14 + AutoScrollPosition.X + num9 - method_16(), int_15 + AutoScrollPosition.Y, method_16(), method_16());
				Color foreColor = treeNode_3.ForeColor;
				Image image_ = method_13()[treeNode_3.ImageIndex];
				image_ = Class25.smethod_0(image_, 1f, 0f, 0f, 0f, 0f, (float)(int)foreColor.R / 255f, (float)(int)foreColor.G / 255f, (float)(int)foreColor.B / 255f);
				graphics_0.SmoothingMode = SmoothingMode.HighQuality;
				graphics_0.DrawImage(image_, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
				graphics_0.SmoothingMode = SmoothingMode.Default;
				y = rectangle.Top + method_16() / 2 - (int)Font.Size;
			}
			rectangle2 = new Rectangle(int_14 + AutoScrollPosition.X + num9, y, width, (int)(Font.Size * 2f));
		}
		else
		{
			rectangle2 = new Rectangle(int_14 + AutoScrollPosition.X + num9, int_15 + AutoScrollPosition.Y, width, (int)(Font.Size * 2f));
		}
		if (treeNode_3 == treeNode_0)
		{
			using (SolidBrush brush9 = new SolidBrush(Color.DodgerBlue))
			{
				graphics_0.FillRectangle(brush9, rectangle2);
			}
			if (treeNode_3.ForeColor == Form23.color_7)
			{
				TextRenderer.DrawText(graphics_0, treeNode_3.Text, font2, rectangle2, Form23.color_8, TextFormatFlags.NoPrefix);
			}
			else
			{
				TextRenderer.DrawText(graphics_0, treeNode_3.Text, font2, rectangle2, treeNode_3.ForeColor, TextFormatFlags.NoPrefix);
			}
		}
		else
		{
			TextRenderer.DrawText(graphics_0, treeNode_3.Text, font2, rectangle2, treeNode_3.ForeColor, TextFormatFlags.NoPrefix);
		}
		if (flag2 | flag)
		{
			font2.Dispose();
		}
		if (treeNode_1 == treeNode_3)
		{
			using Pen pen3 = new Pen(Color.DodgerBlue, 2f);
			int num10 = int_15 + AutoScrollPosition.Y;
			graphics_0.DrawLine(pen3, rectangle2.Left, num10, rectangle2.Right, num10);
		}
		if (drawTreeNodeEventHandler_0 != null)
		{
			TreeNodeStates treeNodeStates2 = (TreeNodeStates)0;
			if (treeNode_3 == treeNode_0)
			{
				treeNodeStates2 |= TreeNodeStates.Selected;
			}
			if (treeNode_3.Checked)
			{
				treeNodeStates2 |= TreeNodeStates.Checked;
			}
			Rectangle bounds2 = new Rectangle(int_14 + AutoScrollPosition.X, int_15 + AutoScrollPosition.Y, width2, (int)(Font.Size * 2f));
			drawTreeNodeEventHandler_0(this, new DrawTreeNodeEventArgs(graphics_0, treeNode_3, bounds2, treeNodeStates2));
		}
		int_15 += (int)(Font.Size * 2f);
		if (enum45_0 == Enum45.const_2)
		{
			int_15 += method_15();
		}
		if (treeNode_3.IsExpanded && treeNode_3.Nodes.Count != 0)
		{
			int_14 += 10;
			for (int j = 0; j < treeNode_3.Nodes.Count; j++)
			{
				TreeNode treeNode_5 = treeNode_3.Nodes[j];
				method_45(graphics_0, treeNode_5, ref int_14, ref int_15);
			}
			int_14 -= 10;
		}
		if (treeNode_2 == treeNode_3)
		{
			using (Pen pen4 = new Pen(Color.DodgerBlue, 2f))
			{
				graphics_0.DrawLine(pen4, rectangle2.Left, int_15, rectangle2.Right, int_15);
			}
		}
	}

	private void method_46(TreeNode treeNode_3, Graphics graphics_0, int int_14, int int_15)
	{
		graphics_0.SmoothingMode = SmoothingMode.HighQuality;
		if (treeNode_3.IsExpanded)
		{
			Point[] points = new Point[3]
			{
				new Point(int_14 + AutoScrollPosition.X + 8, int_15 + AutoScrollPosition.Y + 4),
				new Point(int_14 + AutoScrollPosition.X + 2, int_15 + AutoScrollPosition.Y - 3),
				new Point(int_14 + AutoScrollPosition.X + 13, int_15 + AutoScrollPosition.Y - 3)
			};
			if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
			{
				using SolidBrush brush = new SolidBrush(Form23.color_27);
				graphics_0.FillPolygon(brush, points);
			}
			else
			{
				graphics_0.FillPolygon(Brushes.Gray, points);
			}
		}
		else
		{
			Point[] points2 = new Point[3]
			{
				new Point(int_14 + AutoScrollPosition.X + 13, int_15 + AutoScrollPosition.Y - 1),
				new Point(int_14 + AutoScrollPosition.X + 6, int_15 + AutoScrollPosition.Y - 7),
				new Point(int_14 + AutoScrollPosition.X + 6, int_15 + AutoScrollPosition.Y + 4)
			};
			if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
			{
				using SolidBrush brush2 = new SolidBrush(Form23.color_27);
				graphics_0.FillPolygon(brush2, points2);
			}
			else
			{
				graphics_0.FillPolygon(Brushes.Gray, points2);
			}
		}
		graphics_0.SmoothingMode = SmoothingMode.Default;
	}

	private int method_47()
	{
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				if (list_0[num].Nodes.Count != 0)
				{
					break;
				}
				num++;
				continue;
			}
			return 0;
		}
		if (enum45_0 != Enum45.const_1)
		{
			return 13;
		}
		return 15;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int GetWindowLong(nint intptr_0, int int_14);

	internal void method_48()
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate79 method = method_48;
				Invoke(method);
				return;
			}
			catch
			{
				return;
			}
		}
		Control parent = Parent;
		int num = Left;
		int num2 = Top;
		while (parent != null && (parent is FlowLayoutPanel || parent is TableLayoutPanel))
		{
			num += parent.Left;
			num2 += parent.Top;
			parent = parent.Parent;
		}
		if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
		{
			bool flag;
			bool flag2;
			try
			{
				int windowLong = GetWindowLong(Handle, -16);
				flag = (windowLong & 0x100000) != 0;
				flag2 = (windowLong & 0x200000) != 0;
			}
			catch
			{
				return;
			}
			if (flag)
			{
				try
				{
					if (!control23_0.IsDisposed && !control23_0.Disposing)
					{
						int width = label_1.Width;
						control23_0.Visible = Visible;
						control23_0.Left = num;
						control23_0.Top = num2 + (Height - control23_0.Height) - 1;
						control23_0.Width = (flag2 ? (Width - control26_0.Width) : Width);
						control23_0.method_1(method_49);
						control23_0.method_0(method_49);
						control23_0.method_7(0);
						control23_0.method_5(Width / 40);
						control23_0.method_3((int)((float)Width / 3f));
						control23_0.method_9(width - Width + control23_0.method_2());
						if (flag2)
						{
							Control23 control = control23_0;
							control.method_9(control.method_8() + control26_0.Width);
						}
						control23_0.method_11(-AutoScrollPosition.X);
						if (parent != null && !parent.Controls.Contains(control23_0))
						{
							parent.Controls.Add(control23_0);
						}
						control23_0.BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!control23_0.IsDisposed && !control23_0.Disposing)
			{
				try
				{
					control23_0.Visible = false;
				}
				catch
				{
				}
			}
			if (flag2)
			{
				try
				{
					if (!control26_0.IsDisposed && !control26_0.Disposing)
					{
						int num3 = label_1.Top + 1 - AutoScrollPosition.Y;
						control26_0.Visible = Visible;
						control26_0.Left = num + (Width - control26_0.Width) - 1;
						control26_0.Top = num2;
						control26_0.Height = (flag ? (Height - control23_0.Height) : Height);
						control26_0.method_1(method_50);
						control26_0.method_0(method_50);
						control26_0.method_7(0);
						control26_0.method_5(20);
						control26_0.method_3(200);
						control26_0.method_9(num3 - Height + control26_0.method_2());
						if (flag)
						{
							Control26 control2 = control26_0;
							control2.method_9(control2.method_8() + control23_0.Height);
						}
						control26_0.method_11(-AutoScrollPosition.Y);
						if (parent != null && !parent.Controls.Contains(control26_0))
						{
							parent.Controls.Add(control26_0);
						}
						control26_0.BringToFront();
					}
				}
				catch
				{
				}
			}
			else if (!control26_0.IsDisposed && !control26_0.Disposing)
			{
				try
				{
					control26_0.Visible = false;
				}
				catch
				{
				}
			}
			if (flag & flag2)
			{
				try
				{
					if (!panel_0.IsDisposed && !panel_0.Disposing)
					{
						panel_0.Visible = Visible;
						panel_0.BorderStyle = BorderStyle.None;
						panel_0.BackColor = Form23.color_26;
						panel_0.Size = new Size(control26_0.Width - 1, control23_0.Height - 1);
						panel_0.Left = control23_0.Right;
						panel_0.Top = control26_0.Bottom;
						if (parent != null && !parent.Controls.Contains(panel_0))
						{
							parent.Controls.Add(panel_0);
						}
						panel_0.BringToFront();
					}
					return;
				}
				catch
				{
					return;
				}
			}
			if (!panel_0.IsDisposed && !panel_0.Disposing)
			{
				try
				{
					panel_0.Visible = false;
					return;
				}
				catch
				{
					return;
				}
			}
			return;
		}
		if (!control23_0.IsDisposed && !control23_0.Disposing)
		{
			try
			{
				control23_0.Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains(control23_0))
				{
					parent.Controls.Remove(control23_0);
				}
			}
			catch
			{
			}
		}
		if (!control26_0.IsDisposed && !control26_0.Disposing)
		{
			try
			{
				control26_0.Visible = false;
			}
			catch
			{
			}
			try
			{
				if (parent != null && parent.Controls.Contains(control26_0))
				{
					parent.Controls.Remove(control26_0);
				}
			}
			catch
			{
			}
		}
		if (panel_0.IsDisposed || panel_0.Disposing)
		{
			return;
		}
		try
		{
			panel_0.Visible = false;
		}
		catch
		{
		}
		try
		{
			if (parent != null && parent.Controls.Contains(panel_0))
			{
				parent.Controls.Remove(panel_0);
			}
		}
		catch
		{
		}
	}

	private void method_49(object sender, EventArgs e)
	{
		if (list_0.Count != 0)
		{
			AutoScrollPosition = new Point(control23_0.method_10(), control26_0.Visible ? control26_0.method_10() : 0);
			control23_0.Invalidate();
			Invalidate();
		}
	}

	private void method_50(object sender, EventArgs e)
	{
		if (list_0.Count != 0)
		{
			AutoScrollPosition = new Point(control23_0.Visible ? control23_0.method_10() : 0, control26_0.method_10());
			control26_0.Invalidate();
			Invalidate();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
		{
			try
			{
				control23_0.method_1(method_49);
				control26_0.method_1(method_50);
			}
			catch
			{
			}
			try
			{
				control26_0.Dispose();
			}
			catch
			{
			}
			try
			{
				control23_0.Dispose();
			}
			catch
			{
			}
		}
		try
		{
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
