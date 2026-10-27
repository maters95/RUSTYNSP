using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.Resources;
using NSP.SettingsFramework;

namespace a;

internal class aT : ToolStripButton
{
	private const int Kx = 2000;

	private Image KY;

	private Image Ky;

	private Stopwatch KZ = new Stopwatch();

	internal void A()
	{
		bool flag = false;
		if (((ToolStripItem)this).Image == KY)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (KY != null)
		{
			KY.Dispose();
		}
		KY = (Image)(object)O.A((Image)(object)GeneralResources.IconError, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		if (flag)
		{
			((ToolStripItem)this).Image = KY;
		}
		flag = false;
		if (((ToolStripItem)this).Image == Ky)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (Ky != null)
		{
			Ky.Dispose();
		}
		Ky = (Image)(object)O.A((Image)(object)GeneralResources.IconError, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f);
		if (flag)
		{
			((ToolStripItem)this).Image = Ky;
		}
	}

	internal void a()
	{
		((ToolStripItem)this).Image = KY;
	}

	internal void B()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (((ToolStripItem)this).Image != KY)
		{
			((ToolStripItem)this).Image = KY;
		}
		((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
		KZ.Reset();
	}

	internal void A(bool P_0)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (((ToolStripItem)this).Image != Ky)
		{
			((ToolStripItem)this).Image = Ky;
		}
		if (P_0)
		{
			KZ.Restart();
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
		if (((ToolStripItem)this).Image == Ky)
		{
			if (KZ.IsRunning)
			{
				if (KZ.ElapsedMilliseconds >= 2000)
				{
					((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
					return;
				}
				float num = 1f - (float)(int)KZ.ElapsedMilliseconds / 2000f;
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
				KZ.Restart();
				((ToolStripItem)this).BackColor = Color.FromArgb(200, 0, 0);
			}
		}
		else
		{
			((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
			KZ.Reset();
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
internal class at : ToolStripDropDownButton
{
	private bool Kz;

	private float kA;

	protected override void OnMouseEnter(EventArgs e)
	{
		((ToolStripItem)this).OnMouseEnter(e);
		Kz = true;
		((ToolStripItem)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((ToolStripDropDownButton)this).OnMouseLeave(e);
		Kz = false;
		((ToolStripItem)this).Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected O, but got Unknown
		((ToolStripDropDownButton)this).OnPaint(e);
		Rectangle val = default(Rectangle);
		((Rectangle)(ref val))._002Ector(0, 0, ((ToolStripItem)this).Width, ((ToolStripItem)this).Height);
		if (Kz)
		{
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
			SolidBrush val4 = new SolidBrush(((ToolStripItem)this).BackColor);
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val4, val);
			}
			finally
			{
				((System.IDisposable)val4)?.Dispose();
			}
		}
		bool flag;
		bool flag2;
		string text;
		string text2;
		Color val5;
		if (((uint)BM.qI & 0x400u) != 0)
		{
			flag = false;
			flag2 = true;
			text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gF();
			text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gf();
			val5 = Color.FromArgb(96, 96, 255);
		}
		else if (((ToolStripItem)this).Enabled)
		{
			int num = 0;
			if (BM.Qz != null)
			{
				Setting setting = BM.Qz.A(9497);
				if (setting != null)
				{
					num = setting.ax();
				}
			}
			if (num == 0 || Be.G() || Be.g() == -1 || ((uint)BM.qI & 0x100u) != 0 || ((uint)BM.qI & 0x200u) != 0)
			{
				flag = false;
				if (BM.Qz != null && BM.A(BM.Qz.aXc, true) && !BM.aE() && (BM.qI & 0x100) == 0)
				{
					Setting setting2 = BM.Qz.A(9501);
					Setting setting3 = BM.Qz.A(9500);
					if (setting2 != null && setting3 != null)
					{
						int num2 = setting2.ax();
						int num3 = setting3.ax();
						if (num3 == 12)
						{
							flag2 = false;
							text = null;
							text2 = null;
							val5 = Color.Orange;
						}
						else if (num2 != -1 && num3 != 0)
						{
							flag2 = true;
							text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gf();
							text2 = num2.ToString();
							val5 = Color.FromArgb(96, 96, 255);
						}
						else
						{
							flag2 = false;
							text = null;
							text2 = null;
							val5 = Color.FromArgb((int)(BM.TX * 255f), (int)(BM.Tx * 255f), (int)(BM.TY * 255f));
						}
					}
					else
					{
						flag2 = false;
						text = null;
						text2 = null;
						val5 = Color.Gray;
					}
				}
				else
				{
					flag2 = false;
					text = null;
					text2 = null;
					val5 = Color.FromArgb((int)(BM.TX * 255f), (int)(BM.Tx * 255f), (int)(BM.TY * 255f));
				}
			}
			else
			{
				flag = true;
				flag2 = false;
				int num4 = Be.h() - Be.H();
				if (num4 <= 0)
				{
					num4 += num;
				}
				int num5 = (int)((long)Be.I() * 100L / num4);
				text = Be.g().ToString();
				text2 = num5 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gC();
				val5 = Color.FromArgb((int)(BM.TX * 255f), (int)(BM.Tx * 255f), (int)(BM.TY * 255f));
			}
		}
		else
		{
			flag = false;
			flag2 = false;
			text = null;
			text2 = null;
			val5 = Color.Gray;
		}
		SolidBrush val6 = new SolidBrush(val5);
		try
		{
			Pen val7 = new Pen(val5, 2f);
			try
			{
				e.Graphics.SmoothingMode = (SmoothingMode)2;
				int num6 = 18;
				int num7 = 2;
				int num8 = 9;
				e.Graphics.FillEllipse((Brush)(object)val6, num7, num7, num6, num6);
				e.Graphics.FillEllipse((Brush)(object)val6, ((ToolStripItem)this).Width - num7 - num6, num7, num6, num6);
				e.Graphics.DrawLine(val7, num7 + 2, num7 + num6 / 2, num7 + 2, 1 + (((ToolStripItem)this).Height - num8) - num6 / 2);
				e.Graphics.DrawLine(val7, ((ToolStripItem)this).Width - num7 - 2, num7 + num6 / 2, ((ToolStripItem)this).Width - num7 - 2, 1 + (((ToolStripItem)this).Height - num8) - num6 / 2);
				e.Graphics.DrawArc(val7, num7 + 2, ((ToolStripItem)this).Height - num8 - num6, num6, num6, 90, 90);
				e.Graphics.DrawArc(val7, ((ToolStripItem)this).Width - num7 - num6 - 2, ((ToolStripItem)this).Height - num8 - num6, num6, num6, 0, 90);
				e.Graphics.DrawLine(val7, num7 + 1 + num6 / 2, ((ToolStripItem)this).Height - num8, ((ToolStripItem)this).Width - num7 - num6 / 2 - 1, ((ToolStripItem)this).Height - num8);
				if (flag2)
				{
					if (kA >= 360f)
					{
						kA = 0f;
					}
					else
					{
						kA += 15f;
					}
				}
				else
				{
					kA = 0f;
				}
				Pen val8 = ((!Kz) ? new Pen(((ToolStripItem)this).BackColor, 4f) : new Pen(Color.FromArgb(194, 224, 255), 4f));
				e.Graphics.DrawArc(val8, (float)(num7 + 4), (float)(num7 + 4), (float)(num6 - 8), (float)(num6 - 8), 0f + kA, 80f);
				e.Graphics.DrawArc(val8, (float)(num7 + 4), (float)(num7 + 4), (float)(num6 - 8), (float)(num6 - 8), 120f + kA, 80f);
				e.Graphics.DrawArc(val8, (float)(num7 + 4), (float)(num7 + 4), (float)(num6 - 8), (float)(num6 - 8), 240f + kA, 80f);
				e.Graphics.DrawArc(val8, (float)(((ToolStripItem)this).Width - (num7 + 4) - (num6 - 8)), (float)(num7 + 4), (float)(num6 - 8), (float)(num6 - 8), 0f + kA, 80f);
				e.Graphics.DrawArc(val8, (float)(((ToolStripItem)this).Width - (num7 + 4) - (num6 - 8)), (float)(num7 + 4), (float)(num6 - 8), (float)(num6 - 8), 120f + kA, 80f);
				e.Graphics.DrawArc(val8, (float)(((ToolStripItem)this).Width - (num7 + 4) - (num6 - 8)), (float)(num7 + 4), (float)(num6 - 8), (float)(num6 - 8), 240f + kA, 80f);
				val8.Dispose();
				if (!((ToolStripItem)this).Enabled && (BM.qI & 0x400) == 0)
				{
					return;
				}
				int num9 = ((ToolStripItem)this).Width / 2;
				if (flag)
				{
					int num10 = 17;
					int num11 = 10;
					e.Graphics.FillRectangle((Brush)(object)val6, num9 - 3, num10 - 1, 6, 4);
					Point[] array = (Point[])(object)new Point[3]
					{
						new Point(num9 - 6, num10),
						new Point(num9 + 6, num10),
						new Point(num9, num11)
					};
					e.Graphics.FillPolygon((Brush)(object)val6, array);
				}
				if (text == null || text2 == null)
				{
					return;
				}
				Font val9 = new Font(((ToolStripItem)this).Font.FontFamily, 8f, (FontStyle)1);
				try
				{
					StringFormat val10 = new StringFormat();
					try
					{
						val10.Alignment = (StringAlignment)1;
						val10.LineAlignment = (StringAlignment)1;
						e.Graphics.DrawString(text, val9, (Brush)(object)val6, (float)num9, 27f, val10);
						e.Graphics.DrawString(text2, val9, (Brush)(object)val6, (float)num9, 38f, val10);
					}
					finally
					{
						((System.IDisposable)val10)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val9)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val7)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val6)?.Dispose();
		}
	}
}
