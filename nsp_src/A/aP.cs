using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using B;

namespace a;

internal class aP : CheckBox
{
	internal bool jd;

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		((ButtonBase)this).OnPaint(e);
		if (((Control)this).Parent != null)
		{
			SolidBrush val = new SolidBrush(((Control)this).Parent.BackColor);
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val, 0, 0, ((Control)this).Width, ((Control)this).Height);
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		e.Graphics.SmoothingMode = (SmoothingMode)2;
		int num = ((Control)this).Height / 2 - 7;
		int num2 = ((Control)this).Height / 2;
		Graphics graphics = e.Graphics;
		Color backColor = ((Control)this).BackColor;
		bool enabled = ((Control)this).Enabled;
		bool focused = ((Control)this).Focused;
		int num3 = (((CheckBox)this).Checked ? 1 : 0);
		Rectangle clientRectangle = ((Control)this).ClientRectangle;
		A(graphics, backColor, 0, num, enabled, focused, (ao)num3, ((Rectangle)(ref clientRectangle)).Contains(((Control)this).PointToClient(Control.MousePosition)), jd);
		if (((Control)this).Enabled || ((Control)this).ForeColor == BM.tD)
		{
			Point val2 = default(Point);
			((Point)(ref val2))._002Ector(17, num2);
			TextRenderer.DrawText((IDeviceContext)(object)e.Graphics, ((Control)this).Text, ((Control)this).Font, val2, ((Control)this).ForeColor, (TextFormatFlags)2052);
		}
		else
		{
			Point val3 = default(Point);
			((Point)(ref val3))._002Ector(17, num2);
			TextRenderer.DrawText((IDeviceContext)(object)e.Graphics, ((Control)this).Text, ((Control)this).Font, val3, BM.tq, (TextFormatFlags)2052);
		}
	}

	internal static void A(Graphics P_0, Color P_1, int P_2, int P_3, bool P_4, bool P_5, ao P_6, bool P_7)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		A(P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7, false);
	}

	internal static void A(Graphics P_0, Color P_1, int P_2, int P_3, bool P_4, bool P_5, ao P_6, bool P_7, bool P_8)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		SmoothingMode smoothingMode = P_0.SmoothingMode;
		P_0.SmoothingMode = (SmoothingMode)2;
		Pen val = ((!P_4) ? new Pen(BM.tq, 1f) : (P_7 ? new Pen(Color.DodgerBlue, 1f) : ((!P_5) ? new Pen(BM.te, 1f) : new Pen(BM.te, 2f))));
		P_0.DrawArc(val, P_2, P_3, 12, 12, 90, 180);
		P_0.DrawArc(val, P_2 + 4, P_3, 12, 12, 270, 180);
		P_0.DrawLine(val, P_2 + 6, P_3, P_2 + 10, P_3);
		P_0.DrawLine(val, P_2 + 6, P_3 + 12, P_2 + 10, P_3 + 12);
		val.Dispose();
		if (P_4 || P_8)
		{
			switch (P_6)
			{
			case ao.jc:
			{
				SolidBrush val9 = new SolidBrush(P_1);
				try
				{
					P_0.FillEllipse((Brush)(object)val9, P_2 + 1, P_3 + 1, 10, 10);
				}
				finally
				{
					((System.IDisposable)val9)?.Dispose();
				}
				SolidBrush val10 = new SolidBrush(BM.tO);
				try
				{
					P_0.FillEllipse((Brush)(object)val10, P_2 + 5, P_3 + 1, 10, 10);
				}
				finally
				{
					((System.IDisposable)val10)?.Dispose();
				}
				break;
			}
			case ao.jC:
			{
				SolidBrush val7 = new SolidBrush(P_1);
				try
				{
					P_0.FillEllipse((Brush)(object)val7, P_2 + 5, P_3 + 1, 10, 10);
				}
				finally
				{
					((System.IDisposable)val7)?.Dispose();
				}
				SolidBrush val8 = new SolidBrush(BM.tn);
				try
				{
					P_0.FillEllipse((Brush)(object)val8, P_2 + 1, P_3 + 1, 10, 10);
				}
				finally
				{
					((System.IDisposable)val8)?.Dispose();
				}
				break;
			}
			case ao.jD:
			{
				SolidBrush val2 = new SolidBrush(P_1);
				try
				{
					P_0.FillEllipse((Brush)(object)val2, P_2 + 1, P_3 + 1, 10, 10);
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
				SolidBrush val3 = new SolidBrush(BM.tn);
				try
				{
					GraphicsPath val4 = new GraphicsPath();
					try
					{
						val4.AddArc(P_2 + 5, P_3 + 1, 10, 10, 270f, 180f);
						val4.CloseAllFigures();
						P_0.FillPath((Brush)(object)val3, val4);
					}
					finally
					{
						((System.IDisposable)val4)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val3)?.Dispose();
				}
				SolidBrush val5 = new SolidBrush(BM.tO);
				try
				{
					GraphicsPath val6 = new GraphicsPath();
					try
					{
						val6.AddArc(P_2 + 5, P_3 + 1, 10, 10, 90f, 180f);
						val6.CloseAllFigures();
						P_0.FillPath((Brush)(object)val5, val6);
					}
					finally
					{
						((System.IDisposable)val6)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val5)?.Dispose();
				}
				break;
			}
			}
		}
		P_0.SmoothingMode = smoothingMode;
	}
}
internal class ap : CheckedListBox
{
	[CompilerGenerated]
	private bool jE;

	private bool je;

	private const int jF = 17;

	[SpecialName]
	[CompilerGenerated]
	public bool A()
	{
		return jE;
	}

	[SpecialName]
	[CompilerGenerated]
	public void A(bool P_0)
	{
		jE = P_0;
	}

	public ap()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		((Control)this).BackColor = BM.tg;
		((ListBox)this).SelectionMode = (SelectionMode)1;
		((ListBox)this).BorderStyle = (BorderStyle)1;
		((ListBox)this).DrawMode = (DrawMode)1;
		((CheckedListBox)this).ItemCheck += new ItemCheckEventHandler(A);
	}

	public void a()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		foreach (object item in (ObjectCollection)((CheckedListBox)this).Items)
		{
			Size val = TextRenderer.MeasureText(item.ToString(), ((Control)this).Font);
			if (((Size)(ref val)).Width > num)
			{
				num = ((Size)(ref val)).Width;
			}
		}
		if (num > ((Control)this).Width)
		{
			((Control)this).Width = num + 17 + 10;
		}
	}

	private void A(object P_0, ItemCheckEventArgs P_1)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		((ListBox)this).ClearSelected();
		if (!A() || je)
		{
			return;
		}
		je = true;
		CheckState val = (CheckState)2;
		for (int i = 1; i < ((ObjectCollection)((CheckedListBox)this).Items).Count; i++)
		{
			if (i == 1)
			{
				val = ((i != P_1.Index) ? ((CheckedListBox)this).GetItemCheckState(i) : P_1.NewValue);
			}
			else if (i == P_1.Index)
			{
				if (P_1.NewValue != val)
				{
					((CheckedListBox)this).SetItemCheckState(0, (CheckState)2);
					return;
				}
			}
			else if (((CheckedListBox)this).GetItemCheckState(i) != val)
			{
				((CheckedListBox)this).SetItemCheckState(0, (CheckState)2);
				return;
			}
		}
		((CheckedListBox)this).SetItemCheckState(0, val);
		je = false;
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		int num = ((ListBox)this).IndexFromPoint(P_1.Location);
		if (num != -1)
		{
			Rectangle itemRectangle = ((ListBox)this).GetItemRectangle(num);
			Rectangle val = default(Rectangle);
			((Rectangle)(ref val))._002Ector(((Rectangle)(ref itemRectangle)).X + 2, ((Rectangle)(ref itemRectangle)).Y + 2, 16, 16);
			if (((Rectangle)(ref val)).Contains(P_1.Location))
			{
				bool flag = !((CheckedListBox)this).GetItemChecked(num);
				((CheckedListBox)this).SetItemChecked(num, flag);
			}
		}
	}

	protected override void OnDrawItem(DrawItemEventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected I4, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		_ = e.Graphics;
		e.Graphics.SmoothingMode = (SmoothingMode)2;
		e.DrawBackground();
		CheckState itemCheckState = ((CheckedListBox)this).GetItemCheckState(e.Index);
		ao ao2 = ao.jC;
		switch ((int)itemCheckState)
		{
		case 1:
			ao2 = ao.jc;
			break;
		case 0:
			ao2 = ao.jC;
			break;
		case 2:
			ao2 = ao.jD;
			break;
		}
		Rectangle bounds = e.Bounds;
		int x = ((Rectangle)(ref bounds)).X;
		int y = ((Rectangle)(ref bounds)).Y;
		Graphics graphics = e.Graphics;
		Color backColor = ((Control)this).BackColor;
		bool enabled = ((Control)this).Enabled;
		bool focused = ((Control)this).Focused;
		ao num = ao2;
		Rectangle clientRectangle = ((Control)this).ClientRectangle;
		aP.A(graphics, backColor, x, y, enabled, focused, num, ((Rectangle)(ref clientRectangle)).Contains(((Control)this).PointToClient(Control.MousePosition)), false);
		Point val = default(Point);
		((Point)(ref val))._002Ector(17, y + ((Rectangle)(ref bounds)).Height / 2);
		if (((Control)this).Enabled || ((Control)this).ForeColor == BM.tD)
		{
			TextRenderer.DrawText((IDeviceContext)(object)e.Graphics, ((ObjectCollection)((CheckedListBox)this).Items)[e.Index].ToString(), ((Control)this).Font, val, ((Control)this).ForeColor, (TextFormatFlags)2052);
		}
		else
		{
			TextRenderer.DrawText((IDeviceContext)(object)e.Graphics, ((ObjectCollection)((CheckedListBox)this).Items)[e.Index].ToString(), ((Control)this).Font, val, BM.tq, (TextFormatFlags)2052);
		}
		e.DrawFocusRectangle();
	}
}
