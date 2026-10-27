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

internal class aV : ToolStripButton
{
	private const int kk = 2000;

	private Image kL;

	private Image kl;

	private Stopwatch kM = new Stopwatch();

	internal void A()
	{
		bool flag = false;
		if (((ToolStripItem)this).Image == kL)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (kL != null)
		{
			kL.Dispose();
		}
		kL = (Image)(object)O.A((Image)(object)GeneralResources.IconFWUpdate, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		if (flag)
		{
			((ToolStripItem)this).Image = kL;
		}
		flag = false;
		if (((ToolStripItem)this).Image == kl)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (kl != null)
		{
			kl.Dispose();
		}
		kl = (Image)(object)O.A((Image)(object)GeneralResources.IconFWUpdate, 1f, 0f, 0f, 0f, 0f, 0f, 0.5f, 0f);
		if (flag)
		{
			((ToolStripItem)this).Image = kl;
		}
	}

	internal void a()
	{
		((ToolStripItem)this).Image = kL;
	}

	internal void B()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (((ToolStripItem)this).Image != kL)
		{
			((ToolStripItem)this).Image = kL;
			((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gn();
			((ToolStripItem)this).ToolTipText = ((ToolStripItem)this).Text;
		}
		kM.Reset();
		((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
	}

	internal void b()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (((ToolStripItem)this).Image != kl)
		{
			((ToolStripItem)this).Image = kl;
			((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gO();
			((ToolStripItem)this).ToolTipText = ((ToolStripItem)this).Text;
		}
		kM.Restart();
		((ToolStripItem)this).BackColor = Color.FromArgb(0, 200, 0);
	}

	internal void C()
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (((ToolStripItem)this).Image == kl)
		{
			if (kM.IsRunning)
			{
				if (kM.ElapsedMilliseconds >= 2000)
				{
					((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
					return;
				}
				float num = 1f - (float)(int)kM.ElapsedMilliseconds / 2000f;
				Color backColor = BM.QQ.RG.BackColor;
				int r = ((Color)(ref backColor)).R;
				backColor = BM.QQ.RG.BackColor;
				int g = ((Color)(ref backColor)).G;
				backColor = BM.QQ.RG.BackColor;
				int num2 = ((Color)(ref backColor)).B;
				Color backColor2 = Color.FromArgb(r - (int)(num * (float)r), g + (int)(num * (float)(200 - g)), num2 - (int)(num * (float)num2));
				((ToolStripItem)this).BackColor = backColor2;
			}
			else
			{
				kM.Restart();
				((ToolStripItem)this).BackColor = Color.FromArgb(0, 200, 0);
			}
		}
		else
		{
			((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
			kM.Reset();
		}
	}
}
internal class av : ToolStripButton
{
	private const int km = 2000;

	private Image kN;

	private Image kn;

	private Stopwatch kO = new Stopwatch();

	internal void A()
	{
		bool flag = false;
		if (((ToolStripItem)this).Image == kN)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (kN != null)
		{
			kN.Dispose();
		}
		kN = (Image)(object)O.A((Image)(object)GeneralResources.IconWarning, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		if (flag)
		{
			((ToolStripItem)this).Image = kN;
		}
		flag = false;
		if (((ToolStripItem)this).Image == kn)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (kn != null)
		{
			kn.Dispose();
		}
		kn = (Image)(object)O.A((Image)(object)GeneralResources.IconWarning, 1f, 0f, 0f, 0f, 0f, 1f, 0.8f, 0f);
		if (flag)
		{
			((ToolStripItem)this).Image = kn;
		}
	}

	internal void a()
	{
		((ToolStripItem)this).Image = kN;
	}

	internal void B()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (((ToolStripItem)this).Image != kN)
		{
			((ToolStripItem)this).Image = kN;
		}
		((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
		kO.Reset();
	}

	internal void A(bool P_0)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (((ToolStripItem)this).Image != kn)
		{
			((ToolStripItem)this).Image = kn;
		}
		if (P_0)
		{
			kO.Restart();
			((ToolStripItem)this).BackColor = Color.FromArgb(200, 0, 0);
		}
	}

	internal void b()
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (((ToolStripItem)this).Image == kn)
		{
			if (kO.IsRunning)
			{
				if (kO.ElapsedMilliseconds >= 2000)
				{
					((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
					return;
				}
				float num = 1f - (float)(int)kO.ElapsedMilliseconds / 2000f;
				Color backColor = BM.QQ.RG.BackColor;
				int r = ((Color)(ref backColor)).R;
				backColor = BM.QQ.RG.BackColor;
				int g = ((Color)(ref backColor)).G;
				backColor = BM.QQ.RG.BackColor;
				int num2 = ((Color)(ref backColor)).B;
				Color backColor2 = Color.FromArgb(r + (int)(num * (float)(200 - r)), g - (int)(num * (float)g), num2 - (int)(num * (float)num2));
				((ToolStripItem)this).BackColor = backColor2;
			}
			else
			{
				kO.Restart();
				((ToolStripItem)this).BackColor = Color.FromArgb(200, 0, 0);
			}
		}
		else
		{
			((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
			kO.Reset();
		}
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
