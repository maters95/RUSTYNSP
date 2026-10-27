using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.Resources;

namespace a;

internal class aS : ToolStripDropDownButton
{
	private Image KU;

	private Image Ku;

	private static bool KV;

	internal void A()
	{
		bool flag = false;
		if (((ToolStripItem)this).Image == KU)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (KU != null)
		{
			KU.Dispose();
		}
		KU = (Image)(object)O.A((Image)(object)GeneralResources.IconCompareMaps, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		if (flag)
		{
			((ToolStripItem)this).Image = KU;
		}
		flag = false;
		if (((ToolStripItem)this).Image == Ku)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (Ku != null)
		{
			Ku.Dispose();
		}
		Ku = (Image)(object)O.A((Image)(object)GeneralResources.IconCompareMaps, 1f, 0f, 0f, 0f, 0f, (float)(int)((Color)(ref BM.tD)).R / 255f, (float)(int)((Color)(ref BM.tD)).G / 255f, (float)(int)((Color)(ref BM.tD)).B / 255f);
		if (flag)
		{
			((ToolStripItem)this).Image = Ku;
		}
	}

	internal void a()
	{
		if (((ToolStripItem)this).Image != KU)
		{
			((ToolStripItem)this).Image = KU;
		}
	}

	internal void B()
	{
		if (((ToolStripItem)this).Image != Ku)
		{
			((ToolStripItem)this).Image = Ku;
		}
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		((ToolStripItem)this).OnMouseEnter(e);
		KV = true;
		((ToolStripItem)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((ToolStripDropDownButton)this).OnMouseLeave(e);
		KV = false;
		((ToolStripItem)this).Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		((ToolStripDropDownButton)this).OnPaint(e);
		if (BM.Qn == null)
		{
			return;
		}
		if (KV)
		{
			Rectangle val = default(Rectangle);
			((Rectangle)(ref val))._002Ector(0, 0, ((ToolStripItem)this).Width, ((ToolStripItem)this).Height);
			SolidBrush val2 = new SolidBrush(Color.FromArgb(194, 224, 255));
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val2, val);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
			Pen val3 = new Pen(Color.FromArgb(51, 153, 255), 2f);
			try
			{
				e.Graphics.DrawRectangle(val3, val);
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
		}
		else
		{
			Rectangle val4 = default(Rectangle);
			((Rectangle)(ref val4))._002Ector(1, 1, ((ToolStripItem)this).Width - 2, ((ToolStripItem)this).Height - 3);
			SolidBrush val5 = new SolidBrush(((ToolStripItem)this).BackColor);
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val5, val4);
			}
			finally
			{
				((System.IDisposable)val5)?.Dispose();
			}
			Pen val6 = new Pen(BM.tD, 4f);
			try
			{
				e.Graphics.DrawRectangle(val6, val4);
			}
			finally
			{
				((System.IDisposable)val6)?.Dispose();
			}
		}
		Font val7 = new Font(((ToolStripItem)this).Font.FontFamily, 7f, (FontStyle)1);
		try
		{
			SolidBrush val8 = new SolidBrush(BM.te);
			try
			{
				StringFormat val9 = new StringFormat();
				val9.Alignment = (StringAlignment)1;
				val9.LineAlignment = (StringAlignment)1;
				int num = ((ToolStripItem)this).Width / 2;
				if (BM.QO == BM.b.BpF)
				{
					e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gc(), val7, (Brush)(object)val8, (float)num, 17f, val9);
					e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gD(), val7, (Brush)(object)val8, (float)num, 26f, val9);
					e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gd(), val7, (Brush)(object)val8, (float)num, 35f, val9);
				}
				else if (BM.QO == BM.b.Bpf)
				{
					e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gc(), val7, (Brush)(object)val8, (float)num, 17f, val9);
					e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gE(), val7, (Brush)(object)val8, (float)num, 26f, val9);
					e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gd(), val7, (Brush)(object)val8, (float)num, 35f, val9);
				}
				else if (BM.QO == BM.b.BpG)
				{
					e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gc(), val7, (Brush)(object)val8, (float)num, 17f, val9);
					e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ge(), val7, (Brush)(object)val8, (float)num, 26f, val9);
					e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gd(), val7, (Brush)(object)val8, (float)num, 35f, val9);
				}
				val9.Dispose();
			}
			finally
			{
				((System.IDisposable)val8)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val7)?.Dispose();
		}
	}
}
internal class @as : ToolStripButton
{
	private const int Kv = 2000;

	private Image KW;

	private Image Kw;

	private Stopwatch KX = new Stopwatch();

	internal void A()
	{
		bool flag = false;
		if (((ToolStripItem)this).Image == KW)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (KW != null)
		{
			KW.Dispose();
		}
		KW = (Image)(object)O.A((Image)(object)GeneralResources.IconDTCsCEL, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		if (flag)
		{
			((ToolStripItem)this).Image = KW;
		}
		flag = false;
		if (((ToolStripItem)this).Image == Kw)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (Kw != null)
		{
			Kw.Dispose();
		}
		Kw = (Image)(object)O.A((Image)(object)GeneralResources.IconDTCsCEL, 1f, 0f, 0f, 0f, 0f, 1f, 0.6f, 0f);
		if (flag)
		{
			((ToolStripItem)this).Image = Kw;
		}
	}

	internal void a()
	{
		((ToolStripItem)this).Image = KW;
	}

	internal void B()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (((ToolStripItem)this).Image != KW)
		{
			((ToolStripItem)this).Image = KW;
		}
		((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
		KX.Reset();
	}

	internal void b()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (((ToolStripItem)this).Image != Kw)
		{
			((ToolStripItem)this).Image = Kw;
		}
		KX.Restart();
		((ToolStripItem)this).BackColor = Color.FromArgb(200, 0, 0);
	}

	internal void C()
	{
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (((ToolStripItem)this).Image == Kw)
		{
			if (KX.IsRunning)
			{
				if (KX.ElapsedMilliseconds >= 2000)
				{
					((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
				}
				else
				{
					float num = 1f - (float)(int)KX.ElapsedMilliseconds / 2000f;
					Color backColor = BM.QQ.RG.BackColor;
					int r = ((Color)(ref backColor)).R;
					backColor = BM.QQ.RG.BackColor;
					int g = ((Color)(ref backColor)).G;
					backColor = BM.QQ.RG.BackColor;
					int num2 = ((Color)(ref backColor)).B;
					Color backColor2 = Color.FromArgb(r + (int)(num * (float)(200 - r)), g - (int)(num * (float)g), num2 - (int)(num * (float)num2));
					((ToolStripItem)this).BackColor = backColor2;
				}
			}
			else
			{
				KX.Restart();
				((ToolStripItem)this).BackColor = Color.FromArgb(200, 0, 0);
			}
		}
		else
		{
			((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
			KX.Reset();
		}
		((ToolStripItem)this).Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		((ToolStripButton)this).OnPaint(e);
		if (((ToolStripItem)this).Tag == null)
		{
			return;
		}
		int num = (int)((ToolStripItem)this).Tag;
		if (num == 0)
		{
			return;
		}
		e.Graphics.SmoothingMode = (SmoothingMode)2;
		Rectangle clipRectangle = e.ClipRectangle;
		Rectangle val = default(Rectangle);
		((Rectangle)(ref val))._002Ector(((Rectangle)(ref clipRectangle)).Width - 27, -2, 30, 30);
		clipRectangle = e.ClipRectangle;
		Rectangle val2 = default(Rectangle);
		((Rectangle)(ref val2))._002Ector(((Rectangle)(ref clipRectangle)).Width - 24, 1, 22, 22);
		e.Graphics.FillEllipse(Brushes.Red, val2);
		StringFormat val3 = new StringFormat();
		try
		{
			val3.Alignment = (StringAlignment)1;
			val3.LineAlignment = (StringAlignment)1;
			Font val4 = new Font(((ToolStripItem)this).Font.FontFamily, 9f, (FontStyle)1);
			try
			{
				e.Graphics.DrawString(num.ToString(), val4, Brushes.White, RectangleF.op_Implicit(val), val3);
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
	}
}
