using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;
using c;

namespace D;

internal class DC : cO
{
	public new struct A
	{
		internal int bah;

		internal int baI;

		internal int bai;

		internal int baJ;
	}

	internal new enum a
	{
		baj,
		baK,
		bak,
		baL,
		bal
	}

	private new class B
	{
		internal a baM;

		internal bool bam;
	}

	private new class b
	{
		internal bool baN;

		internal bool ban;

		internal b(bool P_0, bool P_1)
		{
			baN = P_0;
			ban = P_1;
		}
	}

	private delegate void C(object P_0, EventArgs P_1);

	private delegate void c(object P_0, EventArgs P_1);

	private delegate void D(object P_0, EventArgs P_1);

	internal class d : DataGridViewWithThemedScrollBars
	{
		private DC baO;

		private string bao = string.Empty;

		internal d(DC P_0)
		{
			baO = P_0;
		}

		private void A(Graphics P_0, Rectangle P_1)
		{
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0281: Expected O, but got Unknown
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Expected O, but got Unknown
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Expected O, but got Unknown
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			Rectangle val = default(Rectangle);
			((Rectangle)(ref val))._002Ector(0, 0, ((Control)this).Width, ((Control)this).Height);
			bool flag = false;
			if (((DataGridView)this).HorizontalScrollingOffset != 0 || ((DataGridView)this).VerticalScrollingOffset != 0)
			{
				flag = true;
				if (((DataGridView)this).RowHeadersVisible && ((DataGridView)this).ColumnHeadersVisible)
				{
					((Rectangle)(ref val))._002Ector(((DataGridView)this).RowHeadersWidth, ((DataGridView)this).ColumnHeadersHeight, ((Control)this).Width - ((DataGridView)this).RowHeadersWidth, ((Control)this).Height - ((DataGridView)this).ColumnHeadersHeight);
				}
				else if (((DataGridView)this).RowHeadersVisible)
				{
					((Rectangle)(ref val))._002Ector(((DataGridView)this).RowHeadersWidth, 0, ((Control)this).Width - ((DataGridView)this).RowHeadersWidth, ((Control)this).Height);
				}
				else if (((DataGridView)this).ColumnHeadersVisible)
				{
					((Rectangle)(ref val))._002Ector(0, ((DataGridView)this).ColumnHeadersHeight, ((Control)this).Width, ((Control)this).Height - ((DataGridView)this).ColumnHeadersHeight);
				}
			}
			int num = (((DataGridView)this).ColumnHeadersVisible ? (((DataGridView)this).ColumnHeadersHeight - ((DataGridView)this).VerticalScrollingOffset) : (-((DataGridView)this).VerticalScrollingOffset));
			Rectangle val2 = default(Rectangle);
			for (int i = 0; i < ((DataGridView)this).RowCount; i++)
			{
				int height = ((DataGridView)this).Rows[i].Height;
				int num2;
				if (((DataGridView)this).RowHeadersVisible)
				{
					A(P_0, P_1, i, num, height);
					num2 = ((DataGridView)this).RowHeadersWidth - ((DataGridView)this).HorizontalScrollingOffset;
				}
				else
				{
					num2 = -((DataGridView)this).HorizontalScrollingOffset;
				}
				for (int j = 0; j < ((DataGridView)this).ColumnCount; j++)
				{
					int width = ((DataGridView)this).Columns[j].Width;
					if (i == 0 && ((DataGridView)this).ColumnHeadersVisible)
					{
						a(P_0, P_1, j, num2, width);
					}
					A(P_0, P_1, flag, val, i, j, num2, num, width, height);
					num2 += width;
				}
				num += height;
				if (i != 0)
				{
					continue;
				}
				((Rectangle)(ref val2))._002Ector(num2 + 1, 0, ((Control)this).Width - num2, ((Control)this).Height);
				if (((Rectangle)(ref P_1)).IntersectsWith(val2))
				{
					SolidBrush val3 = new SolidBrush(((DataGridView)this).BackgroundColor);
					try
					{
						P_0.FillRectangle((Brush)(object)val3, val2);
					}
					finally
					{
						((System.IDisposable)val3)?.Dispose();
					}
				}
			}
			if (((DataGridView)this).RowHeadersVisible && ((DataGridView)this).ColumnHeadersVisible)
			{
				Rectangle val4 = default(Rectangle);
				((Rectangle)(ref val4))._002Ector(0, 0, ((DataGridView)this).RowHeadersWidth, ((DataGridView)this).ColumnHeadersHeight);
				if (((Rectangle)(ref P_1)).IntersectsWith(val4))
				{
					SolidBrush val5 = new SolidBrush(((DataGridView)this).BackgroundColor);
					try
					{
						P_0.FillRectangle((Brush)(object)val5, val4);
					}
					finally
					{
						((System.IDisposable)val5)?.Dispose();
					}
					P_0.DrawRectangle(Pens.DarkGray, val4);
				}
			}
			Rectangle val6 = default(Rectangle);
			((Rectangle)(ref val6))._002Ector(0, num + 1, ((Control)this).Width, ((Control)this).Height - num);
			if (((Rectangle)(ref P_1)).IntersectsWith(val6))
			{
				SolidBrush val7 = new SolidBrush(((DataGridView)this).BackgroundColor);
				try
				{
					P_0.FillRectangle((Brush)(object)val7, val6);
				}
				finally
				{
					((System.IDisposable)val7)?.Dispose();
				}
			}
		}

		private void A(Graphics P_0, Rectangle P_1, int P_2, int P_3, int P_4)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			Rectangle val = default(Rectangle);
			((Rectangle)(ref val))._002Ector(0, P_3, ((DataGridView)this).RowHeadersWidth, P_4);
			if (!((Rectangle)(ref P_1)).IntersectsWith(val))
			{
				return;
			}
			StringFormat val2 = new StringFormat();
			try
			{
				val2.Alignment = (StringAlignment)2;
				val2.LineAlignment = (StringAlignment)1;
				SolidBrush val3 = new SolidBrush(((DataGridViewCell)((DataGridView)this).Rows[P_2].HeaderCell).Style.BackColor);
				try
				{
					P_0.FillRectangle((Brush)(object)val3, val);
				}
				finally
				{
					((System.IDisposable)val3)?.Dispose();
				}
				SolidBrush val4 = new SolidBrush(((DataGridView)this).RowHeadersDefaultCellStyle.ForeColor);
				try
				{
					int num;
					Font val5;
					if (((DataGridViewCell)((DataGridView)this).Rows[P_2].HeaderCell).Tag != null)
					{
						num = (((bool)((DataGridViewCell)((DataGridView)this).Rows[P_2].HeaderCell).Tag) ? 1 : 0);
						if (num != 0)
						{
							val5 = new Font(((DataGridView)this).RowHeadersDefaultCellStyle.Font, (FontStyle)3);
							goto IL_00d4;
						}
					}
					else
					{
						num = 0;
					}
					val5 = ((DataGridView)this).RowHeadersDefaultCellStyle.Font;
					goto IL_00d4;
					IL_00d4:
					P_0.DrawString(((DataGridViewCell)((DataGridView)this).Rows[P_2].HeaderCell).Value as string, val5, (Brush)(object)val4, (float)(((DataGridView)this).RowHeadersWidth - 10), (float)(P_3 + P_4 / 2 + 1), val2);
					if (num != 0)
					{
						val5.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val4)?.Dispose();
				}
				P_0.DrawRectangle(Pens.DarkGray, val);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}

		private void a(Graphics P_0, Rectangle P_1, int P_2, int P_3, int P_4)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			Rectangle val = default(Rectangle);
			((Rectangle)(ref val))._002Ector(P_3, 0, P_4, ((DataGridView)this).ColumnHeadersHeight);
			if (!((Rectangle)(ref P_1)).IntersectsWith(val))
			{
				return;
			}
			StringFormat val2 = new StringFormat();
			try
			{
				val2.Alignment = (StringAlignment)2;
				val2.LineAlignment = (StringAlignment)1;
				SolidBrush val3 = new SolidBrush(((DataGridViewCell)((DataGridView)this).Columns[P_2].HeaderCell).Style.BackColor);
				try
				{
					P_0.FillRectangle((Brush)(object)val3, val);
				}
				finally
				{
					((System.IDisposable)val3)?.Dispose();
				}
				SolidBrush val4 = new SolidBrush(((DataGridView)this).ColumnHeadersDefaultCellStyle.ForeColor);
				try
				{
					int num;
					Font val5;
					if (((DataGridViewCell)((DataGridView)this).Columns[P_2].HeaderCell).Tag != null)
					{
						num = (((bool)((DataGridViewCell)((DataGridView)this).Columns[P_2].HeaderCell).Tag) ? 1 : 0);
						if (num != 0)
						{
							val5 = new Font(((DataGridView)this).ColumnHeadersDefaultCellStyle.Font, (FontStyle)3);
							goto IL_00d4;
						}
					}
					else
					{
						num = 0;
					}
					val5 = ((DataGridView)this).ColumnHeadersDefaultCellStyle.Font;
					goto IL_00d4;
					IL_00d4:
					P_0.DrawString(((DataGridViewCell)((DataGridView)this).Columns[P_2].HeaderCell).Value as string, val5, (Brush)(object)val4, (float)(P_3 + P_4 - 3), (float)(((DataGridView)this).ColumnHeadersHeight / 2 + 1), val2);
					if (num != 0)
					{
						val5.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val4)?.Dispose();
				}
				P_0.DrawRectangle(Pens.DarkGray, val);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}

		private void A(Graphics P_0, Rectangle P_1, bool P_2, Rectangle P_3, int P_4, int P_5, int P_6, int P_7, int P_8, int P_9)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Expected O, but got Unknown
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_02df: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Expected O, but got Unknown
			//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Unknown result type (might be due to invalid IL or missing references)
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Expected O, but got Unknown
			//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
			Rectangle val = default(Rectangle);
			((Rectangle)(ref val))._002Ector(P_6, P_7, P_8, P_9);
			if (!((Rectangle)(ref P_1)).IntersectsWith(val))
			{
				return;
			}
			if (P_2)
			{
				P_0.SetClip(P_3, (CombineMode)0);
			}
			StringFormat val2 = new StringFormat();
			try
			{
				val2.Alignment = (StringAlignment)2;
				val2.LineAlignment = (StringAlignment)1;
				bool flag = false;
				bool flag2 = false;
				if (!baO.BKi && !baO.BKJ && ((DataGridView)this).Rows[P_4].Cells[P_5].Tag is b b)
				{
					flag = b.baN;
					flag2 = b.ban;
				}
				bool flag3 = false;
				if (baO.BKD.awo != null && !baO.BKE.SwapColumnsAndRows && (BM.QO != BM.b.BpG || baO.BKd == null) && (((Setting)baO.BKE).A() == 6447 || ((Setting)baO.BKE).A() == 8279 || ((Setting)baO.BKE).A() == 6437))
				{
					Setting setting = baO.BKD.awo.a(((Setting)baO.BKE).A());
					Setting setting2 = baO.BKD.awo.B(((Setting)baO.BKE).A());
					Setting setting3 = baO.BKD.awo.b(((Setting)baO.BKE).A());
					if (setting != null && setting2 != null && setting3 != null)
					{
						int num = setting.ax();
						int num2 = setting2.ax();
						int num3 = setting3.ax();
						if (num != 0 || num2 != 0 || num3 != 0)
						{
							flag3 = ((!baO.BKE.InvertRows) ? (P_4 == num && P_5 >= num2 && P_5 <= num3) : (P_4 == baO.BKE.VertAxisCount() - 1 - num && P_5 >= num2 && P_5 <= num3));
						}
					}
				}
				Font val3 = (Font)(flag2 ? ((object)new Font(((DataGridViewBand)((DataGridView)this).Columns[P_5]).DefaultCellStyle.Font, (FontStyle)2)) : ((!flag3) ? ((object)((DataGridViewBand)((DataGridView)this).Columns[P_5]).DefaultCellStyle.Font) : ((object)new Font(((DataGridViewBand)((DataGridView)this).Columns[P_5]).DefaultCellStyle.Font, (FontStyle)1))));
				if (((DataGridView)this).Rows[P_4].Cells[P_5].Selected)
				{
					P_0.FillRectangle(Brushes.DodgerBlue, val);
				}
				else
				{
					SolidBrush val4 = new SolidBrush(((DataGridView)this).Rows[P_4].Cells[P_5].Style.BackColor);
					try
					{
						P_0.FillRectangle((Brush)(object)val4, val);
					}
					finally
					{
						((System.IDisposable)val4)?.Dispose();
					}
				}
				Brush val5 = ((!((DataGridView)this).Rows[P_4].Cells[P_5].Selected) ? Brushes.Black : Brushes.White);
				P_0.DrawString(((DataGridView)this).Rows[P_4].Cells[P_5].Value as string, val3, val5, (float)(P_6 + P_8 - 2), (float)(P_7 + P_9 / 2 + 1), val2);
				if (flag2)
				{
					val3.Dispose();
				}
				if (flag)
				{
					Pen val6 = new Pen(BM.tD);
					try
					{
						Rectangle val7 = default(Rectangle);
						((Rectangle)(ref val7))._002Ector(((Rectangle)(ref val)).Left + 1, ((Rectangle)(ref val)).Top + 1, ((Rectangle)(ref val)).Width - 2, ((Rectangle)(ref val)).Height - 2);
						P_0.DrawRectangle(val6, val7);
					}
					finally
					{
						((System.IDisposable)val6)?.Dispose();
					}
				}
				else
				{
					P_0.DrawRectangle(Pens.DarkGray, val);
				}
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
			if (P_2)
			{
				P_0.ResetClip();
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0391: Unknown result type (might be due to invalid IL or missing references)
			//IL_039b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a2: Expected O, but got Unknown
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Expected O, but got Unknown
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_042f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0434: Unknown result type (might be due to invalid IL or missing references)
			//IL_0441: Unknown result type (might be due to invalid IL or missing references)
			//IL_0446: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_04af: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			Stopwatch val = new Stopwatch();
			val.Start();
			A(e.Graphics, e.ClipRectangle);
			if (BM.QO == BM.b.BpG || !((SettingOrSpecialObject)baO.BKE).l())
			{
				return;
			}
			int num = baO.G();
			int num2 = baO.g();
			bool flag = baO.BKE.HorizAxisEnabled();
			bool flag2 = baO.BKE.VertAxisEnabled();
			int num3 = 0;
			if (flag2)
			{
				num3 = ((DataGridView)this).RowHeadersWidth;
			}
			int num4 = 0;
			if (flag)
			{
				num4 = ((DataGridView)this).ColumnHeadersHeight;
			}
			bool flag3 = BM.A(((SettingOrSpecialObject)baO.BKE).A().aXc, true) && !BM.aE();
			e.Graphics.SmoothingMode = (SmoothingMode)2;
			if (baO.BvG && flag && baO.BKf != null && flag2 && baO.BKG != null)
			{
				if (flag3 || (BM.C(baO.BKf.A()) && BM.C(baO.BKG.A())))
				{
					if (baO.Bvg.Count < 90000)
					{
						Point val2 = default(Point);
						((Point)(ref val2))._002Ector(num, num2);
						bool flag4 = false;
						if (baO.Bvg.Count != 0)
						{
							Point val3 = baO.Bvg[baO.Bvg.Count - 1];
							int x = ((Point)(ref val3)).X;
							int y = ((Point)(ref val3)).Y;
							if (num >= x - 1 && num <= x + 1 && num2 >= y - 1 && num2 <= y + 1)
							{
								flag4 = true;
							}
						}
						if (!flag4)
						{
							baO.Bvg.Add(val2);
						}
					}
					A();
				}
				if (baO.Bvg.Count >= 2)
				{
					Pen val4 = new Pen(Color.FromArgb(100, 0, 0, 0), 2f);
					try
					{
						for (int i = 1; i < baO.Bvg.Count; i++)
						{
							Point val5 = baO.Bvg[i - 1];
							Point val6 = baO.Bvg[i];
							int num5 = ((Point)(ref val5)).X - ((DataGridView)this).HorizontalScrollingOffset;
							int num6 = ((Point)(ref val5)).Y - ((DataGridView)this).VerticalScrollingOffset;
							int num7 = ((Point)(ref val6)).X - ((DataGridView)this).HorizontalScrollingOffset;
							int num8 = ((Point)(ref val6)).Y - ((DataGridView)this).VerticalScrollingOffset;
							if (num5 > num3 && num7 > num3 && num6 > num4 && num8 > num4)
							{
								e.Graphics.DrawLine(val4, num5, num6, num7, num8);
							}
						}
					}
					finally
					{
						((System.IDisposable)val4)?.Dispose();
					}
				}
			}
			if (Bve == bC.zX || Bve == bC.zx || Bve == bC.zW)
			{
				int num9 = num - ((DataGridView)this).HorizontalScrollingOffset;
				int num10 = num2 - ((DataGridView)this).VerticalScrollingOffset;
				if (num9 > num3 && num10 > num4)
				{
					bool flag5;
					bool flag6;
					if (flag3)
					{
						flag5 = true;
						flag6 = true;
					}
					else
					{
						flag5 = !flag || (baO.BKf != null && BM.C(baO.BKf.A()));
						flag6 = !flag2 || (baO.BKG != null && BM.C(baO.BKG.A()));
					}
					if (flag5 && flag6)
					{
						Pen val7 = new Pen(Color.FromArgb(150, 0, 0, 0), 2f);
						try
						{
							if (Bve == bC.zX)
							{
								e.Graphics.DrawEllipse(val7, num9 - 5, num10 - 5, 10, 10);
							}
							else if (Bve == bC.zx)
							{
								e.Graphics.DrawRectangle(val7, num9 - 24, num10 - 8, 48, 17);
							}
						}
						finally
						{
							((System.IDisposable)val7)?.Dispose();
						}
					}
					if (flag && baO.BKf != null && (flag3 || BM.C(baO.BKf.A())))
					{
						Point[] array = (Point[])(object)new Point[3]
						{
							new Point(num9, 9),
							new Point(num9 - 6, 1),
							new Point(num9 + 5, 1)
						};
						e.Graphics.FillPolygon(Brushes.DodgerBlue, array);
					}
					if (flag2 && baO.BKG != null && (flag3 || BM.C(baO.BKG.A())))
					{
						Point[] array2 = (Point[])(object)new Point[3]
						{
							new Point(9, num10),
							new Point(1, num10 - 6),
							new Point(1, num10 + 5)
						};
						e.Graphics.FillPolygon(Brushes.DodgerBlue, array2);
					}
				}
			}
			val.Stop();
			global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJK(), (object)val.ElapsedMilliseconds, (object)((Control)this).Left, (object)((Control)this).Top), false);
		}

		private void A()
		{
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			if (baO.BvI == null || ((Setting)baO.BKE).A() != 128)
			{
				return;
			}
			Setting setting = baO.BKD.A(8018);
			Setting setting2 = baO.BKD.A(6904);
			Setting setting3 = baO.BKD.A(6929);
			Setting setting4 = baO.BKD.A(132);
			Setting setting5 = baO.BKD.A(1400);
			Setting setting6 = baO.BKD.A(1401);
			Setting setting7 = baO.BKD.A(1321);
			Setting setting8 = baO.BKD.A(9281);
			Setting setting9 = baO.BKD.A(3970);
			Setting setting10 = baO.BKD.A(3971);
			Setting setting11 = baO.BKD.A(15986);
			if (setting == null || setting4 == null || !((SettingOrSpecialObject)setting).l() || !((SettingOrSpecialObject)setting4).l() || (!baO.L() && (!BM.A(((SettingOrSpecialObject)baO.BKE).A().aXc, true) || BM.aE())))
			{
				return;
			}
			bool num = setting7 != null && ((SettingOrSpecialObject)setting7).l() && setting7.ax() != 0;
			bool flag = setting8 != null && ((SettingOrSpecialObject)setting8).l() && setting8.ax() != 0;
			bool flag2 = (setting9 != null && ((SettingOrSpecialObject)setting9).l() && setting9.ax() != 0) || (setting10 != null && ((SettingOrSpecialObject)setting10).l() && setting10.ax() != 0) || (setting11 != null && ((SettingOrSpecialObject)setting11).l() && setting11.ax() != 0);
			if (num || flag || flag2)
			{
				return;
			}
			A a = default(A);
			bool flag3 = true;
			if (setting2 != null && ((SettingOrSpecialObject)setting2).l() && setting3 != null && ((SettingOrSpecialObject)setting3).l())
			{
				int num2 = setting2.ax();
				int num3 = setting3.ax();
				flag3 = num2 > 0 && num3 > 0 && setting2.a(num2, 0) == null && setting3.a(num3, 0) == null;
				if (flag3)
				{
					a.baI = (num2 + num3) / 2;
				}
			}
			else
			{
				int num4 = setting.ax();
				flag3 = num4 > 0 && setting.a(num4, 0) == null;
				if (flag3)
				{
					a.baI = num4;
				}
			}
			if (flag3)
			{
				a.bah = setting4.ax();
				if (setting5 != null && ((SettingOrSpecialObject)setting5).l())
				{
					a.bai = setting5.ax();
				}
				else
				{
					a.bai = 0;
				}
				if (setting6 != null && ((SettingOrSpecialObject)setting6).l())
				{
					a.baJ = setting6.ax();
				}
				else
				{
					a.baJ = 0;
				}
				int currentHoriz = 0;
				int currentVert = 0;
				int currentSlice = 0;
				baO.BKE.GetOperatingPoint(ref currentHoriz, ref currentVert, ref currentSlice);
				if (baO.BvI[currentSlice, currentVert, currentHoriz].Count == 50)
				{
					baO.BvI[currentSlice, currentVert, currentHoriz].RemoveAt(0);
				}
				baO.BvI[currentSlice, currentVert, currentHoriz].Add(a);
				if (Bvf == bc.zY)
				{
					((DataGridView)baO.BVw).Rows[currentVert].Cells[currentHoriz].Style.BackColor = baO.A(currentVert, currentHoriz);
				}
				if (((DataGridView)baO.BVw).CurrentCell.ColumnIndex == currentHoriz && ((DataGridView)baO.BVw).CurrentCell.RowIndex == currentVert)
				{
					baO.l();
				}
			}
		}

		[SpecialName]
		internal bool a()
		{
			return bao != string.Empty;
		}

		private void B()
		{
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			if (BM.QO == BM.b.BpG || !(bao != string.Empty))
			{
				return;
			}
			int num = baO.BKE.HorizAxisCount();
			int num2 = baO.BKE.VertAxisCount();
			for (int i = 0; i < num2; i++)
			{
				for (int j = 0; j < num; j++)
				{
					if (((DataGridView)this).Rows[i].Cells[j].Selected)
					{
						DataGridViewCellStyle val = new DataGridViewCellStyle();
						val.SelectionBackColor = Color.White;
						val.SelectionForeColor = Color.Black;
						((DataGridView)this).Rows[i].Cells[j].Style = val;
						((DataGridView)this).Rows[i].Cells[j].Value = bao;
					}
				}
			}
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Invalid comparison between Unknown and I4
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Invalid comparison between Unknown and I4
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Invalid comparison between Unknown and I4
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Invalid comparison between Unknown and I4
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Invalid comparison between Unknown and I4
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Invalid comparison between Unknown and I4
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Invalid comparison between Unknown and I4
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Invalid comparison between Unknown and I4
			//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d2: Invalid comparison between Unknown and I4
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Invalid comparison between Unknown and I4
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Invalid comparison between Unknown and I4
			//IL_0912: Unknown result type (might be due to invalid IL or missing references)
			//IL_0919: Invalid comparison between Unknown and I4
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Invalid comparison between Unknown and I4
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Invalid comparison between Unknown and I4
			//IL_0927: Unknown result type (might be due to invalid IL or missing references)
			//IL_092e: Invalid comparison between Unknown and I4
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Invalid comparison between Unknown and I4
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Invalid comparison between Unknown and I4
			//IL_0976: Unknown result type (might be due to invalid IL or missing references)
			//IL_097d: Invalid comparison between Unknown and I4
			//IL_0931: Unknown result type (might be due to invalid IL or missing references)
			//IL_0938: Invalid comparison between Unknown and I4
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0256: Invalid comparison between Unknown and I4
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Invalid comparison between Unknown and I4
			//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c4: Invalid comparison between Unknown and I4
			//IL_0980: Unknown result type (might be due to invalid IL or missing references)
			//IL_0987: Invalid comparison between Unknown and I4
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Invalid comparison between Unknown and I4
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Invalid comparison between Unknown and I4
			//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f6: Invalid comparison between Unknown and I4
			//IL_098a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0991: Unknown result type (might be due to invalid IL or missing references)
			//IL_0993: Expected I4, but got Unknown
			//IL_0943: Unknown result type (might be due to invalid IL or missing references)
			//IL_094a: Unknown result type (might be due to invalid IL or missing references)
			//IL_094c: Expected I4, but got Unknown
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Invalid comparison between Unknown and I4
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Invalid comparison between Unknown and I4
			//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3c: Invalid comparison between Unknown and I4
			//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dd: Invalid comparison between Unknown and I4
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Invalid comparison between Unknown and I4
			//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a7f: Invalid comparison between Unknown and I4
			//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ff: Invalid comparison between Unknown and I4
			//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac4: Invalid comparison between Unknown and I4
			//IL_0317: Unknown result type (might be due to invalid IL or missing references)
			//IL_0321: Invalid comparison between Unknown and I4
			//IL_0acf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad6: Invalid comparison between Unknown and I4
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_0343: Invalid comparison between Unknown and I4
			//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b0f: Invalid comparison between Unknown and I4
			//IL_0b1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b21: Invalid comparison between Unknown and I4
			//IL_036d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0374: Invalid comparison between Unknown and I4
			//IL_0363: Unknown result type (might be due to invalid IL or missing references)
			//IL_036a: Invalid comparison between Unknown and I4
			//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b57: Invalid comparison between Unknown and I4
			//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b69: Invalid comparison between Unknown and I4
			//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba2: Invalid comparison between Unknown and I4
			//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ae: Invalid comparison between Unknown and I4
			//IL_0ba5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bac: Invalid comparison between Unknown and I4
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ea: Invalid comparison between Unknown and I4
			//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b8: Invalid comparison between Unknown and I4
			//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bdc: Invalid comparison between Unknown and I4
			//IL_041f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0429: Invalid comparison between Unknown and I4
			//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f4: Invalid comparison between Unknown and I4
			//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c5: Expected I4, but got Unknown
			//IL_0bdf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be6: Invalid comparison between Unknown and I4
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0433: Invalid comparison between Unknown and I4
			//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0401: Expected I4, but got Unknown
			//IL_0be9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf0: Invalid comparison between Unknown and I4
			//IL_0452: Unknown result type (might be due to invalid IL or missing references)
			//IL_0459: Invalid comparison between Unknown and I4
			//IL_0bf3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bfa: Invalid comparison between Unknown and I4
			//IL_048c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0493: Invalid comparison between Unknown and I4
			//IL_0bfd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c04: Invalid comparison between Unknown and I4
			//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ad: Invalid comparison between Unknown and I4
			//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c0e: Invalid comparison between Unknown and I4
			//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c7: Invalid comparison between Unknown and I4
			//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e3: Invalid comparison between Unknown and I4
			//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ff: Invalid comparison between Unknown and I4
			//IL_0514: Unknown result type (might be due to invalid IL or missing references)
			//IL_051b: Invalid comparison between Unknown and I4
			//IL_0530: Unknown result type (might be due to invalid IL or missing references)
			//IL_0537: Invalid comparison between Unknown and I4
			//IL_054c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0553: Invalid comparison between Unknown and I4
			//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b7: Invalid comparison between Unknown and I4
			//IL_0669: Unknown result type (might be due to invalid IL or missing references)
			//IL_0670: Invalid comparison between Unknown and I4
			//IL_0685: Unknown result type (might be due to invalid IL or missing references)
			//IL_068c: Invalid comparison between Unknown and I4
			//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ab: Invalid comparison between Unknown and I4
			//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c7: Invalid comparison between Unknown and I4
			//IL_06da: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e1: Invalid comparison between Unknown and I4
			//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06fd: Invalid comparison between Unknown and I4
			//IL_0712: Unknown result type (might be due to invalid IL or missing references)
			//IL_071c: Invalid comparison between Unknown and I4
			//IL_073f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0749: Invalid comparison between Unknown and I4
			//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b2: Invalid comparison between Unknown and I4
			//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ea: Invalid comparison between Unknown and I4
			//IL_0818: Unknown result type (might be due to invalid IL or missing references)
			//IL_0822: Invalid comparison between Unknown and I4
			//IL_0850: Unknown result type (might be due to invalid IL or missing references)
			//IL_085a: Invalid comparison between Unknown and I4
			if ((baO.BKE != null && !((SettingOrSpecialObject)baO.BKE).A().C()) || (baO.BKe != null && (baO.BKi || baO.BKJ) && BM.QO == BM.b.BpF))
			{
				return;
			}
			if (bao == string.Empty)
			{
				if ((int)e.KeyData == 68)
				{
					baO.J(null, null);
					return;
				}
				if ((e.Control && (int)e.KeyCode == 33) || (e.Control && (int)e.KeyCode == 34) || (e.Shift && (int)e.KeyCode == 33) || (e.Shift && (int)e.KeyCode == 34) || (int)e.KeyData == 33 || (int)e.KeyData == 34 || (int)e.KeyData == 219 || (int)e.KeyData == 221 || (int)e.KeyData == 186 || (int)e.KeyData == 222 || (int)e.KeyData == 188 || (int)e.KeyData == 190)
				{
					return;
				}
			}
			if (baO.BKE == null || ((DataGridView)this).SelectedCells == null || ((BaseCollection)((DataGridView)this).SelectedCells).Count == 0)
			{
				((DataGridView)this).OnKeyDown(e);
				return;
			}
			if (bao == string.Empty)
			{
				if ((int)e.KeyData == 37)
				{
					baO.BKE.MoveSelectionLeft(baO.BKe);
				}
				else if ((int)e.KeyData == 38)
				{
					baO.BKE.MoveSelectionUp(baO.BKe);
				}
				else if ((int)e.KeyData == 39)
				{
					baO.BKE.MoveSelectionRight(baO.BKe);
				}
				else if ((int)e.KeyData == 40)
				{
					baO.BKE.MoveSelectionDown(baO.BKe);
				}
				else if ((int)e.KeyData == 65573)
				{
					baO.BKE.IncreaseSelectionSizeOnLeft(baO.BKe);
				}
				else if ((int)e.KeyData == 65574)
				{
					baO.BKE.IncreaseSelectionSizeOnTop(baO.BKe);
				}
				else if ((int)e.KeyData == 65575)
				{
					baO.BKE.IncreaseSelectionSizeOnRight(baO.BKe);
				}
				else if ((int)e.KeyData == 65576)
				{
					baO.BKE.IncreaseSelectionSizeOnBottom(baO.BKe);
				}
				else if ((int)e.KeyData == 131109)
				{
					baO.BKE.DecreaseSelectionSizeOnRight();
				}
				else if ((int)e.KeyData == 131110)
				{
					baO.BKE.DecreaseSelectionSizeOnBottom();
				}
				else if ((int)e.KeyData == 131111)
				{
					baO.BKE.DecreaseSelectionSizeOnLeft();
				}
				else if ((int)e.KeyData == 131112)
				{
					baO.BKE.DecreaseSelectionSizeOnTop();
				}
				else if ((e.Control && (int)e.KeyCode == 32) || (int)e.KeyData == 27)
				{
					baO.N();
				}
				else if (((SettingOrSpecialObject)baO.BKE).l() && BM.QO != BM.b.BpG)
				{
					if ((int)e.KeyCode >= 48 && (int)e.KeyCode <= 57)
					{
						bao = (e.KeyCode - 48).ToString();
						baO.Bvj = true;
					}
					else if ((int)e.KeyCode >= 96 && (int)e.KeyCode <= 105)
					{
						bao = (e.KeyCode - 96).ToString();
						baO.Bvj = true;
					}
					else if ((int)e.KeyCode == 189 || (int)e.KeyCode == 109)
					{
						bao = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
						baO.Bvj = true;
					}
					else if ((int)e.KeyCode == 110)
					{
						bao = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn() + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
						baO.Bvj = true;
					}
					else if ((int)e.KeyData == 45)
					{
						baO.j();
					}
					else if ((int)e.KeyData == 46)
					{
						baO.K();
					}
					else if ((int)e.KeyData == 114)
					{
						((cO)baO).a((object)null, (EventArgs)null);
					}
					else if ((int)e.KeyData == 80)
					{
						baO.o(null, null);
					}
					else if ((int)e.KeyData == 76)
					{
						baO.P(null, null);
					}
					else if ((int)e.KeyData == 72)
					{
						baO.p(null, null);
					}
					else if ((int)e.KeyData == 86)
					{
						baO.Q(null, null);
					}
					else if ((int)e.KeyData == 77)
					{
						if (((Setting)baO.BKE).A() == 6447 || ((Setting)baO.BKE).A() == 8279 || ((Setting)baO.BKE).A() == 6437)
						{
							baO.V(null, null);
						}
					}
					else if ((int)e.KeyData == 81)
					{
						if (((Setting)baO.BKE).A() == 128)
						{
							baO.x(null, null);
						}
						else if (((Setting)baO.BKE).A() == 15975)
						{
							baO.X(null, null);
						}
						else if (((Setting)baO.BKE).A() == 6447 || ((Setting)baO.BKE).A() == 8279 || ((Setting)baO.BKE).A() == 6437)
						{
							baO.w(null, null);
						}
					}
					else if ((int)e.KeyData == 82)
					{
						baO.Y(null, null);
					}
					else if ((int)e.KeyData == 84)
					{
						baO.y(null, null);
					}
					else if ((int)e.KeyData == 131156)
					{
						baO.Z(null, null);
					}
					else if ((int)e.KeyData == 88)
					{
						baO.m();
					}
					else if ((int)e.KeyData == 70)
					{
						baO.z(null, null);
					}
					else if ((int)e.KeyData == 32)
					{
						baO.A(false, false);
					}
					else if ((int)e.KeyData == 131139)
					{
						baO.BKE.CopyCellValuesToClipboard(baO.BKe);
					}
					else if ((int)e.KeyData == 131158)
					{
						baO.BKE.C(baO.BKe, baO.BvI);
					}
					else if (baO.BKe == null || (!baO.BKi && !baO.BKJ) || BM.QO != 0)
					{
						if ((int)e.KeyData == 196645)
						{
							baO.BKE.A(baO.BKe, baO.BvI);
						}
						else if ((int)e.KeyData == 196646)
						{
							baO.BKE.B(baO.BKe, baO.BvI);
						}
						else if ((int)e.KeyData == 196647)
						{
							baO.BKE.a(baO.BKe, baO.BvI);
						}
						else if ((int)e.KeyData == 196648)
						{
							baO.BKE.b(baO.BKe, baO.BvI);
						}
						else
						{
							((DataGridView)this).OnKeyDown(e);
						}
					}
					else
					{
						((DataGridView)this).OnKeyDown(e);
					}
				}
				else
				{
					((DataGridView)this).OnKeyDown(e);
				}
			}
			else if (((SettingOrSpecialObject)baO.BKE).l() && BM.QO != BM.b.BpG)
			{
				if ((int)e.KeyCode == 8)
				{
					if (bao.Length == 1)
					{
						b();
					}
					else
					{
						bao = bao.Substring(0, bao.Length - 1);
					}
				}
				else if ((int)e.KeyCode == 27)
				{
					b();
				}
				else if ((int)e.KeyCode >= 48 && (int)e.KeyCode <= 57 && !e.Shift)
				{
					int num = e.KeyCode - 48;
					if (A(num))
					{
						bao += num;
					}
				}
				else if ((int)e.KeyCode >= 96 && (int)e.KeyCode <= 105)
				{
					int num2 = e.KeyCode - 96;
					if (A(num2))
					{
						bao += num2;
					}
				}
				else if ((int)e.KeyCode == 110)
				{
					bao += CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
				}
				else if ((int)e.KeyCode == 190)
				{
					if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq())
					{
						bao += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq();
					}
				}
				else if ((int)e.KeyCode == 188)
				{
					if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ())
					{
						bao += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ();
					}
				}
				else if ((int)e.KeyCode == 53 && e.Shift)
				{
					if (!bao.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gC()))
					{
						bao += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gC();
					}
				}
				else if (((int)e.KeyCode == 187 && e.Shift) || (int)e.KeyData == 107)
				{
					if (A(bao))
					{
						bao += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol();
					}
				}
				else if (((int)e.KeyCode == 189 && e.Shift) || (int)e.KeyData == 109)
				{
					if (A(bao))
					{
						bao += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
					}
				}
				else if (((int)e.KeyCode == 56 && e.Shift) || (int)e.KeyData == 106)
				{
					if (A(bao))
					{
						bao += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bk();
					}
				}
				else if ((int)e.KeyData == 191 || (int)e.KeyData == 111)
				{
					if (A(bao))
					{
						bao += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK();
					}
				}
				else if ((int)e.KeyCode == 13 || (int)e.KeyCode == 9 || (int)e.KeyCode == 37 || (int)e.KeyCode == 39 || (int)e.KeyCode == 38 || (int)e.KeyCode == 40)
				{
					A(e);
				}
				else
				{
					((DataGridView)this).OnKeyDown(e);
				}
			}
			else
			{
				((DataGridView)this).OnKeyDown(e);
			}
			B();
		}

		private void A(KeyEventArgs P_0)
		{
			//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_046f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f3: Invalid comparison between Unknown and I4
			baO.Bvj = false;
			Ck ck = BM.aM();
			ck?.A(baO.BKE.TableDataSetting.A());
			baO.BKE.TableDataSetting.az();
			int num = baO.BKE.aR();
			int num2 = baO.BKE.ar();
			int num3 = baO.BKE.TableDataSetting.aS();
			bao = A(bao, out var b);
			if (b.baM != 0)
			{
				baO.A(bao, b);
				bao = string.Empty;
			}
			else
			{
				try
				{
					int num4 = 0;
					if (BM.QO != 0 || baO.BKe == null)
					{
						num4 = bS.A(double.Parse(bao, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture), num3);
						if (num != 0 || num2 != 0)
						{
							num4 = Math.Min(Math.Max(num4, num), num2);
						}
					}
					int num5 = 0;
					if (baO.BKE.SlicesEnabled())
					{
						num5 = baO.BKE.UserSliceIndex;
					}
					int num6 = baO.BKE.HorizAxisCount();
					int num7 = baO.BKE.VertAxisCount();
					for (int i = 0; i < num7; i++)
					{
						for (int j = 0; j < num6; j++)
						{
							if (((DataGridView)this).Rows[i].Cells[j].Selected)
							{
								if (BM.QO == BM.b.BpF && baO.BKe != null)
								{
									int horizRawValue = ((baO.BKE.HorizAxis != null && baO.BKE.HorizAxis.G() != null) ? baO.BKE.HorizAxis.G().m(j) : 0);
									int vertRawValue = ((baO.BKE.VertAxis != null && baO.BKE.VertAxis.G() != null) ? ((!baO.BKE.InvertRows) ? baO.BKE.VertAxis.G().m(i) : baO.BKE.VertAxis.G().m(num7 - 1 - i)) : 0);
									int sliceRawValue = ((baO.BKE.SliceAxis != null && baO.BKE.SliceAxis.G() != null) ? baO.BKE.SliceAxis.G().m(num5) : 0);
									double num8 = bS.A(baO.BKe.GetInterpolatedTableDataRawValue(horizRawValue, vertRawValue, sliceRawValue), num3, -1);
									double num9 = double.Parse(bao, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture);
									num4 = bS.A(num8 + num9, num3);
									if (num != 0 || num2 != 0)
									{
										num4 = Math.Min(Math.Max(num4, num), num2);
									}
								}
								baO.BKE.GetColumnIndexAndRowIndex(j, i, out var columnIndex, out var rowIndex);
								if (columnIndex == 0)
								{
									baO.A(ref num4);
								}
								if (rowIndex == 0)
								{
									baO.a(ref num4);
								}
								baO.BKE.TableDataSetting.A(columnIndex, rowIndex, num5, num4, true);
								if (((SettingOrSpecialObject)baO.BKE).A().awo != null)
								{
									Setting setting = ((SettingOrSpecialObject)baO.BKE).A().awo.a(((Setting)baO.BKE).A());
									if (setting != null && setting.ax() == rowIndex)
									{
										((SettingOrSpecialObject)baO.BKE).A().awo.A(((Setting)baO.BKE).A());
									}
								}
							}
							if (baO.BvI != null)
							{
								baO.BvI[num5, i, j].Clear();
							}
						}
					}
					bao = string.Empty;
				}
				catch (System.Exception)
				{
					if (BM.QO == BM.b.BpF && baO.BKe != null)
					{
						bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcb(), (object)bao), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else
					{
						string text = bS.a(num, num3, -1);
						string text2 = bS.a(num2, num3, -1);
						bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ke(), (object)bao, (object)text, (object)text2), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					bao = string.Empty;
					baO.E(null, null);
				}
			}
			baO.BKE.TableDataSetting.i(true);
			ck?.B();
			if ((int)P_0.KeyCode == 9)
			{
				((DataGridView)this).OnKeyDown(P_0);
			}
			BM.b(baO.BKE.TableDataSetting.A());
		}

		private bool A(string P_0)
		{
			if (P_0.Length != 0 && P_0[0] == '-')
			{
				P_0 = P_0.TrimStart('-');
			}
			if (!P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()) && !P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo()) && !P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bk()) && !P_0.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()))
			{
				return true;
			}
			return false;
		}

		private bool A(int P_0)
		{
			if (BM.QO == BM.b.BpG)
			{
				return false;
			}
			if (baO.BKe != null && BM.QO == BM.b.BpF && !baO.BKi && !baO.BKJ)
			{
				return true;
			}
			double num = default(double);
			if (!double.TryParse(bao + P_0, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture, ref num))
			{
				return false;
			}
			return true;
		}

		private string A(string P_0, out B P_1)
		{
			B b = new B();
			if (P_0.Length < 2)
			{
				b.baM = DC.a.baj;
				P_1 = b;
				return P_0;
			}
			string text = P_0.Substring(P_0.Length - 2, 2);
			if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()) || text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo()) || text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bk()) || text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()))
			{
				if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					b.baM = DC.a.baK;
				}
				if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo()))
				{
					b.baM = DC.a.bak;
				}
				if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bk()))
				{
					b.baM = DC.a.baL;
				}
				if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()))
				{
					b.baM = DC.a.bal;
				}
				if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gC()))
				{
					b.bam = true;
					P_1 = b;
					return P_0.Substring(0, P_0.Length - 2);
				}
				b.bam = false;
				P_1 = b;
				return P_0.Substring(0, P_0.Length - 1);
			}
			b.baM = DC.a.baj;
			P_1 = b;
			return P_0;
		}

		internal void b()
		{
			if (!(bao != string.Empty))
			{
				return;
			}
			baO.Bvj = false;
			bao = string.Empty;
			int firstDisplayedScrollingColumnIndex = ((DataGridView)baO.BVw).FirstDisplayedScrollingColumnIndex;
			int firstDisplayedScrollingRowIndex = ((DataGridView)baO.BVw).FirstDisplayedScrollingRowIndex;
			baO.F();
			try
			{
				if (firstDisplayedScrollingColumnIndex >= 0 && firstDisplayedScrollingColumnIndex < ((DataGridView)baO.BVw).ColumnCount)
				{
					((DataGridView)baO.BVw).FirstDisplayedScrollingColumnIndex = firstDisplayedScrollingColumnIndex;
				}
			}
			catch
			{
			}
			try
			{
				if (firstDisplayedScrollingRowIndex >= 0 && firstDisplayedScrollingRowIndex < ((DataGridView)baO.BVw).RowCount)
				{
					((DataGridView)baO.BVw).FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
				}
			}
			catch
			{
			}
			baO.BVw.C();
		}
	}

	[CompilerGenerated]
	private sealed class E
	{
		public bool baP;

		public int bap;

		public int baQ;

		public int baq;

		public int baR;

		public bool bar;

		public int baS;

		public int bas;

		public DC baT;

		internal void A()
		{
			if (baP && baT.BKf != null)
			{
				if (Bve == bC.zw)
				{
					((Control)baT.Bvc).BringToFront();
					((Control)baT.Bvc).Left = ((Control)baT.BVw).Left + bap;
					if (((Control)baT.Bvc).Left < ((Control)baT.BVw).Left + baQ || ((Control)baT.Bvc).Left > ((Control)baT.BVw).Right)
					{
						((Control)baT.Bvc).Visible = false;
					}
					else
					{
						((Control)baT.Bvc).Visible = true;
					}
					((Control)baT.Bvc).Top = ((Control)baT.BVw).Top;
					int num = baq;
					for (int i = 0; i < baR; i++)
					{
						num += ((DataGridView)baT.BVw).Rows[i].Height;
					}
					if (baT.BVw.c() && num > ((Control)baT.BVw).Height - 18)
					{
						((Control)baT.Bvc).Height = Math.Min(((Control)baT.BVw).Height, num) - 18;
					}
					else
					{
						((Control)baT.Bvc).Height = Math.Min(((Control)baT.BVw).Height, num);
					}
				}
				else
				{
					((Control)baT.Bvc).Visible = false;
				}
			}
			else
			{
				((Control)baT.Bvc).Visible = false;
			}
		}

		internal void a()
		{
			if (bar && baT.BKG != null)
			{
				if (Bve == bC.zw)
				{
					((Control)baT.BvD).BringToFront();
					((Control)baT.BvD).Top = ((Control)baT.BVw).Top + baS;
					if (((Control)baT.BvD).Top < ((Control)baT.BVw).Top + baq || ((Control)baT.BvD).Top > ((Control)baT.BVw).Bottom)
					{
						((Control)baT.BvD).Visible = false;
					}
					else
					{
						((Control)baT.BvD).Visible = true;
					}
					((Control)baT.BvD).Left = ((Control)baT.BVw).Left;
					int num = baQ;
					for (int i = 0; i < bas; i++)
					{
						num += ((DataGridView)baT.BVw).Columns[i].Width;
					}
					if (baT.BVw.D() && num > ((Control)baT.BVw).Width - 18)
					{
						((Control)baT.BvD).Width = Math.Min(((Control)baT.BVw).Width, num) - 18;
					}
					else
					{
						((Control)baT.BvD).Width = Math.Min(((Control)baT.BVw).Width, num);
					}
				}
				else
				{
					((Control)baT.BvD).Visible = false;
				}
			}
			else
			{
				((Control)baT.BvD).Visible = false;
			}
		}
	}

	private const int BVS = 48;

	private const int BVs = 60;

	private const int BVT = 17;

	private const int BVt = 10;

	private const int BVU = 200;

	private const int BVu = 500;

	private const int BVV = 140;

	private const int BVv = 50;

	private const int BVW = 50;

	private d BVw;

	private MenuNode BVX;

	private int BVx;

	private int BVY;

	private int BVy;

	private int BVZ;

	private int BVz;

	private PictureBox BvA = new PictureBox();

	private PictureBox Bva = new PictureBox();

	private Setting BvB;

	private aP Bvb = new aP();

	private ThemedButton BvC = new ThemedButton();

	private Label Bvc = new Label();

	private Label BvD = new Label();

	internal static float Bvd = 9f;

	internal static bD BvE = bD.zZ;

	internal static bC Bve = bC.zw;

	internal static bc BvF = bc.zY;

	internal static bc Bvf = bc.zY;

	private bool BvG;

	private List<Point> Bvg = new List<Point>();

	private int BvH;

	private int Bvh;

	private List<A>[,,] BvI;

	private string Bvi = string.Empty;

	private bool BvJ;

	private bool Bvj;

	private int BvK = -1;

	private int Bvk = -1;

	private bool BvL = true;

	private ToolStripMenuItem Bvl = new ToolStripMenuItem();

	private ToolStripMenuItem BvM = new ToolStripMenuItem();

	private ToolStripMenuItem Bvm = new ToolStripMenuItem();

	private ToolStripMenuItem BvN = new ToolStripMenuItem();

	private ToolStripMenuItem Bvn = new ToolStripMenuItem();

	private ToolStripMenuItem BvO = new ToolStripMenuItem();

	private ToolStripMenuItem Bvo = new ToolStripMenuItem();

	private ToolStripMenuItem BvP = new ToolStripMenuItem();

	private ToolStripMenuItem Bvp = new ToolStripMenuItem();

	private ToolStripMenuItem BvQ = new ToolStripMenuItem();

	private ToolStripMenuItem Bvq = new ToolStripMenuItem();

	private List<ToolStripMenuItem> BvR = new List<ToolStripMenuItem>();

	private List<ToolStripMenuItem> Bvr = new List<ToolStripMenuItem>();

	private List<ToolStripMenuItem> BvS = new List<ToolStripMenuItem>();

	private List<ToolStripMenuItem> Bvs = new List<ToolStripMenuItem>();

	private List<ToolStripMenuItem> BvT = new List<ToolStripMenuItem>();

	private List<ToolStripMenuItem> Bvt = new List<ToolStripMenuItem>();

	private int BvU = -1;

	private int Bvu = -1;

	private int BvV = -1;

	internal DC(Framework P_0, Framework P_1, Rectangle P_2, bool P_3)
		: base(P_0, P_1, P_2, P_3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		_ = ((Control)BvA).Handle;
		_ = ((Control)Bva).Handle;
		_ = ((Control)Bvc).Handle;
		_ = ((Control)BvD).Handle;
		_ = ((Control)this).Handle;
		bS.A(new EventHandler(O));
	}

	internal override void A(int P_0)
	{
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected O, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected O, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected O, but got Unknown
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected O, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		Setting setting = BKD.A(P_0);
		if (setting != null)
		{
			BKE = setting as Table;
		}
		else
		{
			BKE = null;
		}
		if (BKE != null)
		{
			BKF = ((Setting)BKE).A();
			if (BKd != null)
			{
				BKe = BKd.A(P_0) as Table;
			}
			else
			{
				BKe = null;
			}
			BVX = MenuNode.A(BKD.awj, BKE.C());
			if (BVX != null && BVX.h() != 0)
			{
				BvB = BKD.A(BVX.h());
			}
		}
		else
		{
			BKe = null;
		}
		if (BKE != null && BKe != null)
		{
			BKe.InvertRows = BKE.InvertRows;
			BKe.SwapColumnsAndRows = BKE.SwapColumnsAndRows;
		}
		BKi = BKD.B() && BKD.b() && BKE.J();
		BKJ = BKd != null && BKd.B() && BKd.b() && BKe != null && BKe.J();
		if ((BM.QO != BM.b.BpG || BKd == null) ? BKi : BKJ)
		{
			Label val = new Label();
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)BKE).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO();
			((Control)val).ForeColor = BM.te;
			((Control)val).BackColor = Color.Transparent;
			((Control)val).AutoSize = true;
			((Control)val).Left = 10;
			((Control)val).Top = 10;
			((Control)this).Controls.Add((Control)(object)val);
			return;
		}
		if (BKE != null)
		{
			((Setting)BKE).A(new EventHandler(e));
			BKE.TableDataSetting.A(new EventHandler(E));
			BKE.OnUserSliceIndexChanged += new EventHandler(aA);
			BKE.OnUserSelectionChanged += new EventHandler(h);
			BKE.OnInvertRows += new EventHandler(M);
			BKE.OnSwapColumnsAndRows += new EventHandler(m);
			if (BKD.awo != null)
			{
				BKD.awo.a(((Setting)BKE).A())?.A(new EventHandler(F));
			}
			((Control)this).Paint += new PaintEventHandler(A);
			if (BvB != null && !BvB.am())
			{
				((Control)Bvb).Font = new Font(((Control)Bvb).Font.FontFamily, 10f, (FontStyle)1);
				((Control)Bvb).ForeColor = BM.tf;
				string text = ((SettingOrSpecialObject)BKE).H();
				string text2 = (string.IsNullOrWhiteSpace(text) ? ((SettingOrSpecialObject)BKE).A(bz.aYt) : text);
				if (BM.QO == BM.b.BpF && BKe != null && (BKi || BKJ))
				{
					text2 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfI();
				}
				((Control)Bvb).Text = text2;
				((Control)Bvb).Enabled = BKD.C() && (BM.QO != BM.b.BpG || BKd == null);
				Setting setting2 = ((BM.QO != BM.b.BpG || BKd == null) ? BvB : BKd.A(BvB.A()));
				if (setting2 != null && !setting2.am())
				{
					((CheckBox)Bvb).Checked = setting2.ax() == 1;
				}
				else
				{
					((CheckBox)Bvb).Checked = true;
				}
				((Control)Bvb).Left = 10;
				((Control)Bvb).Top = 6;
				((Control)Bvb).AutoSize = true;
				((CheckBox)Bvb).CheckedChanged += new EventHandler(B);
				BvB.A(new EventHandler(b));
				((Control)this).Controls.Add((Control)(object)Bvb);
			}
			C();
			c();
		}
		B();
		((Control)Bvc).Visible = false;
		((Control)Bvc).AutoSize = false;
		((Control)Bvc).Width = 2;
		((Control)Bvc).BackColor = Color.FromArgb(100, 100, 100);
		((Control)BvD).Visible = false;
		((Control)BvD).AutoSize = false;
		((Control)BvD).Height = 2;
		((Control)BvD).BackColor = Color.FromArgb(100, 100, 100);
		((Control)BvA).Size = new Size(32, 32);
		BvA.Image = (Image)(object)GeneralResources.YellowWarning;
		((Control)Bva).Size = new Size(32, 32);
		Bva.Image = (Image)(object)GeneralResources.YellowWarning;
		global::A.A.A(new EventHandler(f));
		global::A.A.A((global::A.D)f);
		BM.D(new EventHandler(f));
		BM.E(new EventHandler(G));
		((Control)this).DoubleClick += new EventHandler(a);
		((Control)BvA).DoubleClick += new EventHandler(a);
		((Control)Bva).DoubleClick += new EventHandler(a);
		((Control)this).Controls.Add((Control)(object)BVw);
		((Control)this).Controls.Add((Control)(object)Bvc);
		((Control)this).Controls.Add((Control)(object)BvD);
		E();
		UpdateLayout(resizingOnly: false);
		((Control)this).ContextMenuStrip = I();
	}

	private new void B()
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		BVw = new d(this);
		((Control)BVw).Visible = false;
		_ = ((Control)BVw).Handle;
		((DataGridView)BVw).SelectionMode = (DataGridViewSelectionMode)0;
		((DataGridView)BVw).AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)1;
		((DataGridView)BVw).AutoSizeRowsMode = (DataGridViewAutoSizeRowsMode)0;
		((DataGridView)BVw).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)1;
		((DataGridView)BVw).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)BVw).AllowUserToAddRows = false;
		((DataGridView)BVw).AllowUserToDeleteRows = false;
		((DataGridView)BVw).AllowUserToResizeRows = false;
		((DataGridView)BVw).AllowUserToOrderColumns = false;
		((DataGridView)BVw).AllowUserToResizeColumns = false;
		((DataGridView)BVw).ReadOnly = true;
		((DataGridView)BVw).EnableHeadersVisualStyles = false;
		((DataGridView)BVw).BackgroundColor = BM.ti;
		((DataGridView)BVw).ColumnHeadersDefaultCellStyle.BackColor = ((DataGridView)BVw).BackgroundColor;
		((DataGridView)BVw).RowHeadersDefaultCellStyle.BackColor = ((DataGridView)BVw).BackgroundColor;
		((DataGridView)BVw).ColumnHeadersDefaultCellStyle.ForeColor = BM.te;
		((DataGridView)BVw).RowHeadersDefaultCellStyle.ForeColor = BM.te;
		((DataGridView)BVw).ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)64;
		((DataGridView)BVw).RowHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)64;
		((Control)BVw).GotFocus += new EventHandler(C);
		((Control)BVw).LostFocus += new EventHandler(c);
		((Control)BVw).MouseDown += new MouseEventHandler(A);
		((Control)BVw).MouseMove += new MouseEventHandler(a);
		((Control)BVw).MouseUp += new MouseEventHandler(B);
		((DataGridView)BVw).SelectionChanged += new EventHandler(H);
		((DataGridView)BVw).CurrentCellChanged += new EventHandler(g);
		typeof(d).InvokeMember(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HG(), (BindingFlags)8228, (Binder)null, (object)BVw, new object[1] { true });
		if (!BKD.C())
		{
			((Control)BVw).Enabled = false;
		}
	}

	internal new void b()
	{
		((Control)BVw).Focus();
	}

	protected override void MouseDownHandler(object sender, MouseEventArgs e)
	{
		base.MouseDownHandler(sender, e);
		if (BVw != null && ((Control)BVw).Visible)
		{
			b();
		}
		else
		{
			((Control)this).Focus();
		}
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.KeyData == 68)
		{
			J(null, null);
		}
		else
		{
			((Control)this).OnKeyDown(e);
		}
	}

	private void C()
	{
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		if ((((Setting)BKE).A() == 128 || ((Setting)BKE).A() == 15975 || ((Setting)BKE).A() == 6447 || ((Setting)BKE).A() == 8279 || ((Setting)BKE).A() == 6437) && BKD.C())
		{
			if (!((Control)this).Controls.Contains((Control)(object)BvC))
			{
				((Control)BvC).Top = 2;
				((Control)BvC).Width = 30;
				((Control)BvC).Height = 30;
				((Control)BvC).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mN();
				((Control)BvC).Font = new Font(((Control)BvC).Font.FontFamily, 11f, (FontStyle)1);
				((Control)BvC).Click -= new EventHandler(W);
				((Control)BvC).Click += new EventHandler(W);
				((Control)this).Controls.Add((Control)(object)BvC);
			}
			((Control)BvC).Visible = true;
			((Control)BvC).Enabled = true;
		}
		else
		{
			((Control)BvC).Click -= new EventHandler(W);
			((Control)BvC).Visible = false;
			((Control)BvC).Enabled = false;
			if (((Control)this).Controls.Contains((Control)(object)BvC))
			{
				((Control)this).Controls.Remove((Control)(object)BvC);
			}
		}
	}

	private void c()
	{
		if (BVX == null)
		{
			return;
		}
		BKK = BVX.A(BKE.TableDataSetting);
		if (BKK != null)
		{
			BKk = BKK.Y().BcF;
		}
		if (BKk == null)
		{
			return;
		}
		BKL = BKk.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].BsP;
		int[] array = BKk.a(BKE.TableDataSetting);
		double[,,] array2 = null;
		if (array != null && array.Length == BKE.TableDataSetting.Ba())
		{
			int num = BKE.TableDataSetting.av()[0];
			int num2 = BKE.TableDataSetting.av()[1];
			int num3 = BKE.TableDataSetting.av()[2];
			array2 = new double[num, num2, num3];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num2; j++)
				{
					for (int k = 0; k < num3; k++)
					{
						array2[i, j, k] = array[BKE.TableDataSetting.A(k, j, i)];
					}
				}
			}
		}
		if (array2 != null)
		{
			BKl = array2;
			TableAxis[] obj = new TableAxis[3] { BKE.SliceAxis, BKE.RowAxis, BKE.ColumnAxis };
			BKM = new cO.A[3];
			TableAxis[] array3 = obj;
			foreach (TableAxis tableAxis in array3)
			{
				if (tableAxis != null)
				{
					cO.A a = default(cO.A);
					int[] array4 = BKk.a(tableAxis.F());
					int[] array5 = BKk.a(tableAxis.g());
					int[] array6 = BKk.a(tableAxis.f());
					int[] array7 = BKk.a(tableAxis.G());
					if (array4 == null || array4.Length != 1 || array5 == null || array5.Length != 1 || array6 == null || array6.Length != 1 || array7 == null || array7.Length != tableAxis.G().Ba())
					{
						BKk = null;
						break;
					}
					a.Bvv = array4[0] != 0;
					a.BvW = array5[0];
					a.Bvw = array6[0];
					a.BvX = new int[a.Bvw];
					for (int m = 0; m < a.Bvw; m++)
					{
						a.BvX[m] = array7[m];
					}
					BKM[(int)tableAxis.A()] = a;
				}
			}
		}
		else
		{
			BKk = null;
		}
	}

	protected override void a()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected O, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected O, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected O, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected O, but got Unknown
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected O, but got Unknown
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected O, but got Unknown
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected O, but got Unknown
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected O, but got Unknown
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected O, but got Unknown
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected O, but got Unknown
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected O, but got Unknown
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected O, but got Unknown
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected O, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected O, but got Unknown
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected O, but got Unknown
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected O, but got Unknown
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected O, but got Unknown
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Expected O, but got Unknown
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Expected O, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Expected O, but got Unknown
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Expected O, but got Unknown
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected O, but got Unknown
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Expected O, but got Unknown
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected O, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected O, but got Unknown
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected O, but got Unknown
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected O, but got Unknown
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Expected O, but got Unknown
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected O, but got Unknown
		try
		{
			if (BvB != null && !BvB.am())
			{
				((CheckBox)Bvb).CheckedChanged -= new EventHandler(B);
				BvB.a(new EventHandler(b));
			}
			((Control)BvC).Click -= new EventHandler(W);
			if (BVw != null)
			{
				((Control)BVw).GotFocus -= new EventHandler(C);
				((Control)BVw).LostFocus -= new EventHandler(c);
				((Control)BVw).MouseDown -= new MouseEventHandler(A);
				((Control)BVw).MouseMove -= new MouseEventHandler(a);
				((Control)BVw).MouseUp -= new MouseEventHandler(B);
				((DataGridView)BVw).SelectionChanged -= new EventHandler(H);
				((DataGridView)BVw).CurrentCellChanged -= new EventHandler(g);
				for (int i = 0; i < ((BaseCollection)((DataGridView)BVw).Columns).Count; i++)
				{
					if (((DataGridViewCell)((DataGridView)BVw).Columns[i].HeaderCell).ContextMenuStrip != null)
					{
						((ToolStripDropDown)((DataGridViewCell)((DataGridView)BVw).Columns[i].HeaderCell).ContextMenuStrip).Opening -= new CancelEventHandler(a);
					}
				}
				for (int j = 0; j < ((DataGridView)BVw).Rows.Count; j++)
				{
					if (((DataGridViewCell)((DataGridView)BVw).Rows[j].HeaderCell).ContextMenuStrip != null)
					{
						((ToolStripDropDown)((DataGridViewCell)((DataGridView)BVw).Rows[j].HeaderCell).ContextMenuStrip).Opening -= new CancelEventHandler(B);
					}
				}
			}
			((Control)this).DoubleClick -= new EventHandler(a);
			((Control)BvA).DoubleClick -= new EventHandler(a);
			((Control)Bva).DoubleClick -= new EventHandler(a);
			if (BKE != null)
			{
				BKE.a(new EventHandler(e));
				BKE.TableDataSetting.a(new EventHandler(E));
				BKE.OnUserSliceIndexChanged -= new EventHandler(aA);
				BKE.OnUserSelectionChanged -= new EventHandler(h);
				BKE.OnInvertRows -= new EventHandler(M);
				BKE.OnSwapColumnsAndRows -= new EventHandler(m);
				if (BKD.awo != null)
				{
					BKD.awo.a(((Setting)BKE).A())?.a(new EventHandler(F));
				}
				((Control)this).Paint -= new PaintEventHandler(A);
				if (BKE.SliceAxis != null && BKE.SliceAxis.F() != null)
				{
					BKE.SliceAxis.F().a(new EventHandler(d));
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.f() != null)
				{
					BKE.SliceAxis.f().a(new EventHandler(d));
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.G() != null)
				{
					BKE.SliceAxis.G().a(new EventHandler(d));
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.H() != null)
				{
					BKE.SliceAxis.H().a(new EventHandler(d));
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.g() != null)
				{
					BKE.HorizAxis.g().a(new EventHandler(D));
				}
				if (BKE.VertAxis != null && BKE.VertAxis.g() != null)
				{
					BKE.VertAxis.g().a(new EventHandler(D));
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.g() != null)
				{
					BKE.SliceAxis.g().a(new EventHandler(D));
				}
			}
			global::A.A.a(new EventHandler(f));
			global::A.A.a((global::A.D)f);
			BM.d(new EventHandler(f));
			BM.e(new EventHandler(G));
			Enumerator<ToolStripMenuItem> enumerator = BvR.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((ToolStripItem)enumerator.Current).Click -= new EventHandler(T);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = Bvr.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((ToolStripItem)enumerator.Current).Click -= new EventHandler(S);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = BvS.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((ToolStripItem)enumerator.Current).Click -= new EventHandler(t);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = Bvs.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((ToolStripItem)enumerator.Current).Click -= new EventHandler(s);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = BvT.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((ToolStripItem)enumerator.Current).Click -= new EventHandler(u);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = Bvt.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((ToolStripItem)enumerator.Current).Click -= new EventHandler(v);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (((Control)this).ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
			{
				((ToolStripItem)item).Click -= new EventHandler(a);
				((ToolStripItem)item).Click -= new EventHandler(this.j);
				((ToolStripItem)item).Click -= new EventHandler(K);
				((ToolStripItem)item).Click -= new EventHandler(k);
				((ToolStripItem)item).Click -= new EventHandler(J);
				((ToolStripItem)item).Click -= new EventHandler(I);
				((ToolStripItem)item).Click -= new EventHandler(L);
				((ToolStripItem)item).Click -= new EventHandler(l);
				((ToolStripItem)item).Click -= new EventHandler(N);
				((ToolStripItem)item).Click -= new EventHandler(n);
				((ToolStripItem)item).Click -= new EventHandler(o);
				((ToolStripItem)item).Click -= new EventHandler(P);
				((ToolStripItem)item).Click -= new EventHandler(p);
				((ToolStripItem)item).Click -= new EventHandler(Q);
				((ToolStripItem)item).Click -= new EventHandler(x);
				((ToolStripItem)item).Click -= new EventHandler(X);
				((ToolStripItem)item).Click -= new EventHandler(Y);
				((ToolStripItem)item).Click -= new EventHandler(w);
				((ToolStripItem)item).Click -= new EventHandler(z);
				((ToolStripItem)item).Click -= new EventHandler(y);
				((ToolStripItem)item).Click -= new EventHandler(Z);
				((ToolStripItem)item).Click -= new EventHandler(V);
				((ToolStripItem)item).Click -= new EventHandler(v);
			}
			((ToolStripDropDown)((Control)this).ContextMenuStrip).Opening -= new CancelEventHandler(A);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		a();
		try
		{
			BM.QQ.b(new EventHandler(A));
			bS.a(new EventHandler(O));
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public override string ToString()
	{
		string text = ((Panel)this).ToString();
		if (BKE != null)
		{
			text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY() + ((object)BKE).ToString();
		}
		return string.Concat(new string[5]
		{
			text,
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAZ(),
			((Control)this).Left.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAz(),
			((Control)this).Top.ToString()
		});
	}

	protected override void A(object P_0, EventArgs P_1)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		if (BvB != null)
		{
			Setting setting = ((BM.QO != BM.b.BpG || BKd == null) ? BvB : BKd.A(BvB.A()));
			if (setting != null && !setting.am())
			{
				((CheckBox)Bvb).CheckedChanged -= new EventHandler(B);
				if (((CheckBox)Bvb).Checked != (setting.ax() == 1))
				{
					((CheckBox)Bvb).Checked = setting.ax() == 1;
				}
				((CheckBox)Bvb).CheckedChanged += new EventHandler(B);
			}
		}
		base.A(P_0, P_1);
		if (BKE != null)
		{
			F();
		}
	}

	[SpecialName]
	internal Table D()
	{
		return BKE;
	}

	[SpecialName]
	internal d d()
	{
		return BVw;
	}

	private void B(object P_0, EventArgs P_1)
	{
		if (BM.QO == BM.b.BpG || !BKD.C())
		{
			return;
		}
		if (!BM.QP)
		{
			SettingOrSpecialObject settingOrSpecialObject = null;
			if (((SettingOrSpecialObject)BvB).D() != null && BKD.aWY.Contains(((SettingOrSpecialObject)BvB).D()))
			{
				settingOrSpecialObject = ((SettingOrSpecialObject)BvB).D();
			}
			Ck ck = BM.aM();
			ck?.A(BvB.A());
			if (((CheckBox)Bvb).Checked)
			{
				BvB.a(1, true);
				if (settingOrSpecialObject != null)
				{
					PortFunction.A(settingOrSpecialObject, false);
				}
			}
			else
			{
				BvB.a(0, true);
			}
			ck?.B();
		}
		BM.b(BvB.A());
	}

	private void b(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				C c = b;
				((Control)this).Invoke((System.Delegate)c, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (!BvB.am() && ((CheckBox)Bvb).Checked != (BvB.ax() == 1))
		{
			((CheckBox)Bvb).Checked = BvB.ax() == 1;
		}
	}

	private void E()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		bool flag = ((BM.QO != BM.b.BpG || BKd == null) ? BKi : BKJ);
		if (flag || BKE == null)
		{
			return;
		}
		Table table = ((BM.QO != BM.b.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.F() != null)
		{
			BKE.SliceAxis.F().a(new EventHandler(d));
			BKE.SliceAxis.F().A(new EventHandler(d));
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.f() != null)
		{
			BKE.SliceAxis.f().a(new EventHandler(d));
			BKE.SliceAxis.f().A(new EventHandler(d));
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.G() != null)
		{
			BKE.SliceAxis.G().a(new EventHandler(d));
			BKE.SliceAxis.G().A(new EventHandler(d));
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.H() != null)
		{
			BKE.SliceAxis.H().a(new EventHandler(d));
			BKE.SliceAxis.H().A(new EventHandler(d));
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.g() != null)
		{
			BKE.HorizAxis.g().a(new EventHandler(D));
			BKE.HorizAxis.g().A(new EventHandler(D));
			BKf = BKE.HorizAxis.h();
			if (BKf != null && BKE.HorizAxisEnabled() && !((Control)this).Controls.Contains((Control)(object)BvA))
			{
				((Control)this).Controls.Add((Control)(object)BvA);
			}
			if (BKe != null && BKe.HorizAxis != null && BKe.HorizAxis.g() != null)
			{
				BKH = BKe.HorizAxis.h();
			}
		}
		if (BKE.VertAxis != null && BKE.VertAxis.g() != null)
		{
			BKE.VertAxis.g().a(new EventHandler(D));
			BKE.VertAxis.g().A(new EventHandler(D));
			BKG = BKE.VertAxis.h();
			if (BKG != null && BKE.VertAxisEnabled() && !((Control)this).Controls.Contains((Control)(object)Bva))
			{
				((Control)this).Controls.Add((Control)(object)Bva);
			}
			if (BKe != null && BKe.VertAxis != null && BKe.VertAxis.g() != null)
			{
				BKh = BKe.VertAxis.h();
			}
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.g() != null)
		{
			BKE.SliceAxis.g().a(new EventHandler(D));
			BKE.SliceAxis.g().A(new EventHandler(D));
			BKg = BKE.SliceAxis.h();
			if (BKe != null && BKe.SliceAxis != null && BKe.SliceAxis.g() != null)
			{
				BKI = BKe.SliceAxis.h();
			}
		}
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		bool flag = ((BM.QO != BM.b.BpG || BKd == null) ? BKi : BKJ);
		if (!flag && BKE != null)
		{
			Table table = ((BM.QO != BM.b.BpG) ? BKE : BKe);
			if (table != null)
			{
				((Control)BVw).Left = 8;
				((Control)BVw).Width = ((Control)this).Width - 16;
				Graphics val = ((Control)this).CreateGraphics();
				A(val);
				e();
				a(val);
				val.Dispose();
				((Control)BVw).Invalidate();
				BVw.C();
			}
		}
	}

	private void e()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		int num;
		if (((DataGridView)BVw).Rows.Count != 0)
		{
			num = 0;
			if (((DataGridView)BVw).ColumnHeadersVisible)
			{
				num += ((DataGridView)BVw).ColumnHeadersHeight;
			}
			foreach (DataGridViewRow item in (System.Collections.IEnumerable)((DataGridView)BVw).Rows)
			{
				DataGridViewRow val = item;
				num += val.Height;
			}
			num += 35;
		}
		else
		{
			num = 2147483647;
		}
		((Control)BVw).Top = 39 + Math.Max(BVy, BVx);
		if (BKE.SlicesEnabled() || (BKe != null && BKe.SlicesEnabled()))
		{
			((Control)BVw).Height = Math.Min(num, ((Control)this).Height - 10 - ((Control)BVw).Top - ((Control)BKj).Height);
		}
		else
		{
			((Control)BVw).Height = Math.Min(num, ((Control)this).Height - 10 - ((Control)BVw).Top);
		}
	}

	private void A(Graphics P_0)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		Table table;
		Setting setting;
		Setting setting2;
		if (BM.QO == BM.b.BpG)
		{
			table = BKe;
			setting = BKH;
			setting2 = BKh;
			_ = BKI;
		}
		else
		{
			table = BKE;
			setting = BKf;
			setting2 = BKG;
			_ = BKg;
		}
		if (table == null)
		{
			return;
		}
		Font val = new Font(((Control)this).Font.FontFamily, 10f);
		try
		{
			if (table.VertAxisEnabled() && table.VertAxis.g() != null)
			{
				if (setting2 != null)
				{
					string text = string.Empty;
					int num = setting2.aS();
					if (num != 0 && num != 82)
					{
						text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(setting2.@as(), num, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
					}
					string text2 = ((SettingOrSpecialObject)setting2).H();
					string text3 = (string.IsNullOrWhiteSpace(text2) ? ((SettingOrSpecialObject)setting2).A(bz.aYt) : text2);
					text3 += text;
					SizeF val2 = P_0.MeasureString(text3, val, 140);
					BVx = (int)((SizeF)(ref val2)).Height;
					BVY = (int)((SizeF)(ref val2)).Width;
					((Control)Bva).Visible = !((SettingOrSpecialObject)setting2).l() || !PortFunction.A(setting2);
					if (((Control)Bva).Visible)
					{
						((Control)Bva).Top = 37 + BVx - ((Control)Bva).Height;
						((Control)Bva).Left = 8 + BVY;
					}
				}
				else
				{
					((Control)Bva).Visible = false;
				}
			}
			else
			{
				((Control)Bva).Visible = false;
			}
			if (table.HorizAxisEnabled() && table.HorizAxis.g() != null)
			{
				if (setting != null)
				{
					string text4 = string.Empty;
					int num2 = setting.aS();
					if (num2 != 0 && num2 != 82)
					{
						text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(setting.@as(), num2, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
					}
					string text5 = ((SettingOrSpecialObject)setting).H();
					string text6 = (string.IsNullOrWhiteSpace(text5) ? ((SettingOrSpecialObject)setting).A(bz.aYt) : text5);
					text6 += text4;
					SizeF val3;
					if (table.VertAxisEnabled())
					{
						int num3 = table.HorizAxisCount() * 48 + ((DataGridView)BVw).RowHeadersWidth - (BVY + 50);
						int num4 = Math.Min(500, Math.Max(200, num3));
						val3 = P_0.MeasureString(text6, val, num4);
					}
					else
					{
						val3 = P_0.MeasureString(text6, val);
					}
					BVy = (int)((SizeF)(ref val3)).Height;
					BVZ = (int)((SizeF)(ref val3)).Width + 5;
					if (table.VertAxisEnabled())
					{
						BVz = table.HorizAxisCount() * 48 / 2 + ((DataGridView)BVw).RowHeadersWidth - BVZ / 2;
					}
					else
					{
						BVz = table.HorizAxisCount() * 48 / 2 - BVZ / 2;
					}
					BVz = Math.Max(BVz, BVY + 50);
					if (BVz + BVZ >= ((Control)this).Width - 50)
					{
						BVz = ((Control)this).Width - 50 - BVZ;
					}
					if (BVz < 0)
					{
						BVz = 0;
					}
					((Control)BvA).Visible = !((SettingOrSpecialObject)setting).l() || !PortFunction.A(setting);
					if (((Control)BvA).Visible)
					{
						((Control)BvA).Top = 37 + BVy - ((Control)BvA).Height;
						((Control)BvA).Left = BVz + BVZ;
					}
				}
				else
				{
					((Control)BvA).Visible = false;
				}
			}
			else
			{
				((Control)BvA).Visible = false;
			}
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	private Color A(int P_0, Setting P_1)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (TableAxis.A(P_0, P_1))
		{
			return Color.Red;
		}
		return ((DataGridView)BVw).BackgroundColor;
	}

	private Color a(int P_0, Setting P_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (TableAxis.A(P_0, P_1))
		{
			return Color.Red;
		}
		return BM.te;
	}

	private void a(Graphics P_0)
	{
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		bool flag = BKE.SlicesEnabled();
		bool flag2 = flag;
		if (BKe != null)
		{
			flag2 = BKe.SlicesEnabled();
		}
		if (flag || flag2)
		{
			Table table;
			Setting setting;
			if (BM.QO == BM.b.BpG)
			{
				table = BKe;
				setting = BKI;
			}
			else
			{
				table = BKE;
				setting = BKg;
			}
			if (table == null)
			{
				return;
			}
			if (!((Control)BKj).Visible)
			{
				((Control)BKj).Visible = true;
			}
			int num = table.SliceCount();
			int num2 = ((Control)this).Height - (((Control)BKj).Height + 2);
			if (((Control)BKj).Top != num2)
			{
				((Control)BKj).Top = num2;
			}
			if (((Control)BKj).Left != ((Control)BVw).Left)
			{
				((Control)BKj).Left = ((Control)BVw).Left;
			}
			int num3 = ((Control)this).Width - 10 - ((Control)BKj).Left;
			if (((Control)BKj).Width != num3)
			{
				((Control)BKj).Width = num3;
			}
			if (BKj.BWB != num - 1)
			{
				BKj.BWB = num - 1;
			}
			if (table.UserSliceIndex > BKj.BWB)
			{
				table.UserSliceIndex = BKj.BWB;
			}
			if (BKj.BWb != table.UserSliceIndex)
			{
				BKj.BWb = table.UserSliceIndex;
			}
			if (!((Control)this).Controls.Contains((Control)(object)BKj))
			{
				((Control)this).Controls.Add((Control)(object)BKj);
			}
			int num4 = 0;
			if (setting != null)
			{
				num4 = setting.aS();
			}
			BKj.Bvx.Clear();
			for (int i = 0; i < num; i++)
			{
				BKj.Bvx.Add(new cO.a.A());
				int num5 = table.SliceAxis.G().m(i);
				string text = ((setting == null) ? string.Empty : setting.A(num5, -1).Item1);
				BKj.Bvx[i].bat = text;
				if (BKe == null)
				{
					BKj.Bvx[i].baU = a(num5, BKg);
				}
				else if (BKi || BKJ)
				{
					BKj.Bvx[i].baU = BM.te;
				}
				else if (table == BKE && BKe.SliceAxis.A(num5, text, num4) == -1)
				{
					BKj.Bvx[i].baU = BM.tD;
				}
				else if (table == BKe && BKE.SliceAxis.A(num5, text, num4) == -1)
				{
					BKj.Bvx[i].baU = BM.tD;
				}
				else
				{
					BKj.Bvx[i].baU = a(num5, BKg);
				}
			}
			if (BM.QO == BM.b.BpG)
			{
				((Control)BKj.BWC).Visible = false;
			}
			else if (flag && BKE.SliceAxis.g() != null)
			{
				if (BKg != null)
				{
					((Control)BKj.BWC).Visible = !((SettingOrSpecialObject)BKg).l() || !PortFunction.A(BKg);
				}
				else
				{
					((Control)BKj.BWC).Visible = false;
				}
			}
			else
			{
				((Control)BKj.BWC).Visible = false;
			}
			((Control)BKj).Invalidate();
		}
		else
		{
			if (((Control)BKj).Visible)
			{
				((Control)BKj).Visible = false;
			}
			if (BKE.UserSliceIndex != 0)
			{
				BKE.UserSliceIndex = 0;
			}
		}
	}

	private Color A(int P_0, int P_1, int P_2, int P_3, int P_4, int P_5, int P_6)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (P_1 == P_2)
		{
			return global::A.l.A(P_6, P_4, P_3);
		}
		int num = ((!BM.Tw) ? (P_5 + (P_6 - P_5) * (P_0 - P_1) / (P_2 - P_1)) : ((P_5 >= P_6) ? (P_5 + (255 - (P_5 - P_6)) * (P_0 - P_1) / (P_2 - P_1)) : (P_5 - (255 - (P_6 - P_5)) * (P_0 - P_1) / (P_2 - P_1))));
		if (num < 0)
		{
			num += 255;
		}
		else if (num > 255)
		{
			num -= 255;
		}
		return global::A.l.A(num, P_4, P_3);
	}

	internal void F()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b69: Expected O, but got Unknown
		//IL_0b8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected O, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Expected O, but got Unknown
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f86: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
		if (BKe != null && (BKi || BKJ) && BM.QO == BM.b.BpF)
		{
			return;
		}
		bool flag = ((BM.QO != BM.b.BpG || BKd == null) ? BKi : BKJ);
		if (flag || BKE == null)
		{
			return;
		}
		Table table;
		Setting setting;
		Setting setting2;
		if (BM.QO == BM.b.BpG)
		{
			table = BKe;
			setting = BKH;
			setting2 = BKh;
		}
		else
		{
			table = BKE;
			setting = BKf;
			setting2 = BKG;
		}
		if (table == null)
		{
			return;
		}
		ScrollBars scrollBars = ((DataGridView)BVw).ScrollBars;
		((DataGridView)BVw).ScrollBars = (ScrollBars)0;
		bool flag2 = table.HorizAxisEnabled();
		bool flag3 = table.VertAxisEnabled();
		bool flag4 = table.SlicesEnabled();
		int num = table.HorizAxisCount();
		int num2 = table.VertAxisCount();
		int num3 = table.SliceCount();
		List<Point> val = new List<Point>();
		for (int i = 0; i < table.HorizVertIndexPerUserSelectedCell.Count; i++)
		{
			val.Add(table.HorizVertIndexPerUserSelectedCell[i]);
		}
		Point userCurrentCellHorizVertIndex = table.UserCurrentCellHorizVertIndex;
		((DataGridView)BVw).Columns.Clear();
		((DataGridView)BVw).Rows.Clear();
		((Control)BVw).Visible = true;
		int num4 = 0;
		if (flag4)
		{
			num4 = table.UserSliceIndex;
		}
		((DataGridView)BVw).ColumnCount = num;
		int num5 = table.TableDataSetting.aS();
		int num6 = 2147483647;
		int num7 = -2147483648;
		for (int j = 0; j < num3; j++)
		{
			for (int k = 0; k < num2; k++)
			{
				for (int l = 0; l < num; l++)
				{
					int currentTableRawCellValue;
					int compareTableRawCellValue;
					int num8 = ((BM.QO == BM.b.BpF && BKe != null) ? bS.A(BKE.GetCellDifferenceDisplayValue(BKe, l, k, num4, out currentTableRawCellValue, out compareTableRawCellValue), num5) : ((!table.SwapColumnsAndRows) ? table.TableDataSetting.B(l, k, j) : table.TableDataSetting.B(k, l, j)));
					if (num8 > num7)
					{
						num7 = num8;
					}
					if (num8 < num6)
					{
						num6 = num8;
					}
				}
			}
		}
		Graphics val2 = ((Control)this).CreateGraphics();
		int num9 = 0;
		((DataGridView)BVw).ColumnHeadersDefaultCellStyle.Font = new Font(((Control)this).Font.FontFamily, Bvd, (FontStyle)1);
		((DataGridView)BVw).RowHeadersDefaultCellStyle.Font = new Font(((Control)this).Font.FontFamily, Bvd, (FontStyle)1);
		int num10 = BM.TV * 255 / 100;
		int num11 = BM.Tu * 255 / 100;
		int num12 = BM.Tv * 255 / 100;
		int num13 = BM.TW * 255 / 100;
		Size val3;
		for (int k = 0; k < num2; k++)
		{
			string[] array = new string[num];
			for (int l = 0; l < num; l++)
			{
				string text;
				if (BM.QO == BM.b.BpF && BKe != null)
				{
					int currentTableRawCellValue2;
					int compareTableRawCellValue2;
					int currentTableRawCellValue3;
					int compareTableRawCellValue3;
					int num14 = ((!table.InvertRows) ? bS.A(BKE.GetCellDifferenceDisplayValue(BKe, l, k, num4, out currentTableRawCellValue2, out compareTableRawCellValue2), num5) : bS.A(BKE.GetCellDifferenceDisplayValue(BKe, l, num2 - 1 - k, num4, out currentTableRawCellValue3, out compareTableRawCellValue3), num5));
					text = bS.a(num14, num5, -1);
				}
				else
				{
					table.GetColumnIndexAndRowIndex(l, k, out var columnIndex, out var rowIndex);
					int num14 = table.TableDataSetting.B(columnIndex, rowIndex, num4);
					text = bS.A(num14, num5, bS.A(num5), -1);
				}
				array[l] = text;
				if (k != 0)
				{
					continue;
				}
				if (flag2 && setting != null)
				{
					((DataGridView)BVw).ColumnHeadersVisible = true;
					val3 = TextRenderer.MeasureText((IDeviceContext)(object)val2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn(), ((DataGridView)BVw).ColumnHeadersDefaultCellStyle.Font);
					int height = ((Size)(ref val3)).Height;
					((DataGridView)BVw).ColumnHeadersHeight = Math.Max(20, height + 7);
					int num15 = table.HorizAxis.G().m(l);
					ValueTuple<string, string, bool> val4 = setting.A(num15, -1);
					((DataGridViewCell)((DataGridView)BVw).Columns[l].HeaderCell).Value = val4.Item1;
					int num16 = setting.aS();
					if (BKe != null && table == BKE && BKe.HorizAxis.A(num15, val4.Item1, num16) == -1)
					{
						((DataGridViewCell)((DataGridView)BVw).Columns[l].HeaderCell).Style.BackColor = BM.tD;
					}
					else if (BKe != null && table == BKe && BKE.HorizAxis.A(num15, val4.Item1, num16) == -1)
					{
						((DataGridViewCell)((DataGridView)BVw).Columns[l].HeaderCell).Style.BackColor = BM.tD;
					}
					else
					{
						bool flag5 = false;
						foreach (DataGridViewCell item in (BaseCollection)((DataGridView)BVw).SelectedCells)
						{
							if (item.ColumnIndex == l)
							{
								flag5 = true;
								break;
							}
						}
						if (flag5)
						{
							((DataGridViewCell)((DataGridView)BVw).Columns[l].HeaderCell).Style.BackColor = Color.DarkSeaGreen;
						}
						else
						{
							((DataGridViewCell)((DataGridView)BVw).Columns[l].HeaderCell).Style.BackColor = A(num15, setting);
						}
					}
					bool flag6 = false;
					if (BKk != null && BKK.aa() && (BKe == null || BM.QO != 0))
					{
						int num17 = (int)table.HorizAxis.A();
						flag6 = true;
						for (int m = 0; m < BKM[num17].Bvw; m++)
						{
							if (BKM[num17].BvX[m] == num15)
							{
								flag6 = false;
								break;
							}
						}
					}
					((DataGridViewCell)((DataGridView)BVw).Columns[l].HeaderCell).Tag = flag6;
				}
				else
				{
					((DataGridView)BVw).ColumnHeadersVisible = false;
				}
			}
			if (num != 0)
			{
				DataGridViewRowCollection rows = ((DataGridView)BVw).Rows;
				object[] array2 = array;
				rows.Add(array2);
			}
			if (((DataGridView)BVw).Rows.Count != 0)
			{
				Font val5 = new Font(((Control)this).Font.FontFamily, Bvd);
				try
				{
					val3 = TextRenderer.MeasureText((IDeviceContext)(object)val2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn(), val5);
					int height2 = ((Size)(ref val3)).Height;
					((DataGridView)BVw).Rows[k].Height = Math.Max(17, height2 + 2);
				}
				finally
				{
					((System.IDisposable)val5)?.Dispose();
				}
			}
			if (num > 1 || num2 > 1 || num3 > 1)
			{
				for (int l = 0; l < num; l++)
				{
					int num18 = 0;
					if (BKe != null)
					{
						num18 = ((!table.InvertRows) ? bS.A(BKE.GetCellDifferenceDisplayValue(BKe, l, k, num4, out var _, out var _), num5) : bS.A(BKE.GetCellDifferenceDisplayValue(BKe, l, num2 - 1 - k, num4, out var _, out var _), num5));
					}
					int num19;
					if (BM.QO == BM.b.BpF && BKe != null)
					{
						num19 = num18;
					}
					else
					{
						table.GetColumnIndexAndRowIndex(l, k, out var columnIndex2, out var rowIndex2);
						num19 = table.TableDataSetting.B(columnIndex2, rowIndex2, num4);
					}
					Color backColor = A(num19, num6, num7, num10, num11, num12, num13);
					DataGridViewCellStyle val6 = new DataGridViewCellStyle();
					val6.BackColor = backColor;
					((DataGridView)BVw).Rows[k].Cells[l].Style = val6;
					bool flag7 = false;
					if (BKe != null)
					{
						flag7 = bS.A(num18, num5, -1) != 0.0;
					}
					bool flag8 = A(table, num5, num2, k, l, num4);
					b tag = new b(flag7, flag8);
					((DataGridView)BVw).Rows[k].Cells[l].Tag = tag;
				}
			}
			if (flag3 && setting2 != null && ((DataGridView)BVw).Rows.Count != 0)
			{
				((DataGridView)BVw).RowHeadersVisible = true;
				int num20 = ((!table.InvertRows) ? table.VertAxis.G().m(k) : table.VertAxis.G().m(num2 - 1 - k));
				ValueTuple<string, string, bool> val7 = setting2.A(num20, -1);
				((DataGridViewCell)((DataGridView)BVw).Rows[k].HeaderCell).Value = val7.Item1;
				int num21 = setting2.aS();
				if (BKe != null && table == BKE && BKe.VertAxis.A(num20, val7.Item1, num21) == -1)
				{
					((DataGridViewCell)((DataGridView)BVw).Rows[k].HeaderCell).Style.BackColor = BM.tD;
				}
				else if (BKe != null && table == BKe && BKE.VertAxis.A(num20, val7.Item1, num21) == -1)
				{
					((DataGridViewCell)((DataGridView)BVw).Rows[k].HeaderCell).Style.BackColor = BM.tD;
				}
				else
				{
					bool flag9 = false;
					foreach (DataGridViewCell item2 in (BaseCollection)((DataGridView)BVw).SelectedCells)
					{
						if (item2.RowIndex == k)
						{
							flag9 = true;
							break;
						}
					}
					if (flag9)
					{
						((DataGridViewCell)((DataGridView)BVw).Rows[k].HeaderCell).Style.BackColor = Color.PaleVioletRed;
					}
					else
					{
						((DataGridViewCell)((DataGridView)BVw).Rows[k].HeaderCell).Style.BackColor = A(num20, BKG);
					}
				}
				val3 = TextRenderer.MeasureText((IDeviceContext)(object)val2, val7.Item1, ((DataGridView)BVw).RowHeadersDefaultCellStyle.Font);
				int num22 = ((Size)(ref val3)).Width + 10;
				num9 = Math.Max(num9, num22);
				bool flag10 = false;
				if (BKk != null && BKK.aa() && (BKe == null || BM.QO != 0))
				{
					int num23 = (int)table.VertAxis.A();
					flag10 = true;
					for (int n = 0; n < BKM[num23].Bvw; n++)
					{
						if (BKM[num23].BvX[n] == num20)
						{
							flag10 = false;
							break;
						}
					}
				}
				((DataGridViewCell)((DataGridView)BVw).Rows[k].HeaderCell).Tag = flag10;
			}
			else
			{
				((DataGridView)BVw).RowHeadersVisible = false;
			}
		}
		if (((DataGridView)BVw).RowHeadersVisible)
		{
			((DataGridView)BVw).RowHeadersWidth = Math.Max(60, num9);
		}
		Font val8 = new Font(((Control)this).Font.FontFamily, Bvd);
		string text2 = bS.A(BKE.ar(), num5, bS.A(num5), -1);
		val3 = TextRenderer.MeasureText((IDeviceContext)(object)val2, text2, val8);
		int width = ((Size)(ref val3)).Width;
		for (int l = 0; l < num; l++)
		{
			val3 = TextRenderer.MeasureText((IDeviceContext)(object)val2, ((DataGridViewCell)((DataGridView)BVw).Columns[l].HeaderCell).Value as string, ((DataGridView)BVw).ColumnHeadersDefaultCellStyle.Font);
			int width2 = ((Size)(ref val3)).Width;
			((DataGridView)BVw).Columns[l].Width = Math.Max(Math.Max(48, width2 + 10), width + 5);
			((DataGridView)BVw).Columns[l].SortMode = (DataGridViewColumnSortMode)0;
			if (BKD.C())
			{
				((DataGridViewCell)((DataGridView)BVw).Columns[l].HeaderCell).ContextMenuStrip = a(l);
			}
			((DataGridViewBand)((DataGridView)BVw).Columns[l]).DefaultCellStyle.Alignment = (DataGridViewContentAlignment)64;
			((DataGridViewBand)((DataGridView)BVw).Columns[l]).DefaultCellStyle.Font = val8;
		}
		if (((DataGridView)BVw).Rows.Count != 0 && BKD.C())
		{
			for (int k = 0; k < num2; k++)
			{
				((DataGridViewCell)((DataGridView)BVw).Rows[k].HeaderCell).ContextMenuStrip = B(k);
			}
		}
		int num24 = 2147483647;
		int num25 = 2147483647;
		Point val9;
		for (int num26 = 0; num26 < val.Count; num26++)
		{
			val9 = val[num26];
			int num27 = Math.Min(((Point)(ref val9)).X, num - 1);
			val9 = val[num26];
			int num28 = Math.Min(((Point)(ref val9)).Y, num2 - 1);
			if (((DataGridView)BVw).Rows.Count != 0 && num28 < ((DataGridView)BVw).Rows.Count && ((BaseCollection)((DataGridView)BVw).Rows[num28].Cells).Count != 0 && num27 < ((BaseCollection)((DataGridView)BVw).Rows[num28].Cells).Count)
			{
				num24 = Math.Min(num24, num28);
				num25 = Math.Min(num25, num27);
			}
		}
		if (((Point)(ref userCurrentCellHorizVertIndex)).X != -1 && ((Point)(ref userCurrentCellHorizVertIndex)).Y != -1)
		{
			int num29 = Math.Min(((Point)(ref userCurrentCellHorizVertIndex)).X, num - 1);
			int num30 = Math.Min(((Point)(ref userCurrentCellHorizVertIndex)).Y, num2 - 1);
			if (((DataGridView)BVw).Rows.Count != 0 && num30 < ((DataGridView)BVw).Rows.Count && ((BaseCollection)((DataGridView)BVw).Rows[num30].Cells).Count != 0 && num29 < ((BaseCollection)((DataGridView)BVw).Rows[num30].Cells).Count)
			{
				((DataGridView)BVw).CurrentCell = ((DataGridView)BVw).Rows[num30].Cells[num29];
			}
		}
		if (((DataGridView)BVw).CurrentCell != null && ((DataGridView)BVw).CurrentCell.ColumnIndex == 0 && ((DataGridView)BVw).CurrentCell.RowIndex == 0 && val.Count > 0 && !val.Contains(new Point(0, 0)))
		{
			((DataGridView)BVw).CurrentCell = ((DataGridView)BVw).Rows[num24].Cells[num25];
			((DataGridView)BVw).Rows[0].Cells[0].Selected = false;
		}
		int num31 = 2147483647;
		int num32 = -2147483648;
		int num33 = 2147483647;
		int num34 = -2147483648;
		for (int num35 = 0; num35 < val.Count; num35++)
		{
			val9 = val[num35];
			int num36 = Math.Min(((Point)(ref val9)).X, num - 1);
			val9 = val[num35];
			int num37 = Math.Min(((Point)(ref val9)).Y, num2 - 1);
			if (((DataGridView)BVw).Rows.Count != 0 && num37 < ((DataGridView)BVw).Rows.Count && ((BaseCollection)((DataGridView)BVw).Rows[num37].Cells).Count != 0 && num36 < ((BaseCollection)((DataGridView)BVw).Rows[num37].Cells).Count)
			{
				num31 = Math.Min(num31, num36);
				num32 = Math.Max(num32, num36);
				num33 = Math.Min(num33, num37);
				num34 = Math.Max(num34, num37);
			}
		}
		BvL = false;
		if (num31 != 2147483647 && num32 != -2147483648 && num33 != 2147483647 && num34 != -2147483648)
		{
			if (!((DataGridView)BVw).Rows[num34].Cells[num32].Displayed)
			{
				((DataGridView)BVw).CurrentCell = ((DataGridView)BVw).Rows[num34].Cells[num32];
			}
			if (!((DataGridView)BVw).Rows[num33].Cells[num31].Displayed)
			{
				((DataGridView)BVw).CurrentCell = ((DataGridView)BVw).Rows[num33].Cells[num31];
			}
			for (int num38 = num33; num38 <= num34; num38++)
			{
				for (int num39 = num31; num39 <= num32; num39++)
				{
					((DataGridView)BVw).Rows[num38].Cells[num39].Selected = true;
				}
			}
		}
		BvL = true;
		if (val.Count != 0)
		{
			H(null, null);
		}
		if (BvG)
		{
			M();
		}
		this.l();
		A(val2);
		val2.Dispose();
		e();
		((DataGridView)BVw).ScrollBars = scrollBars;
		BVw.C();
	}

	private bool A(Table P_0, int P_1, int P_2, int P_3, int P_4, int P_5)
	{
		if (BKk != null && BKK.aa() && (BKe == null || BM.QO != 0))
		{
			int[] columnAxisValuesForCompare = null;
			cO.A a = BKM[2];
			if (a.Bvv)
			{
				columnAxisValuesForCompare = a.BvX;
			}
			int[] rowAxisValuesForCompare = null;
			cO.A a2 = BKM[1];
			if (a2.Bvv)
			{
				rowAxisValuesForCompare = a2.BvX;
			}
			int[] sliceAxisValuesForCompare = null;
			cO.A a3 = BKM[0];
			if (a3.Bvv)
			{
				sliceAxisValuesForCompare = a3.BvX;
			}
			return P_0.GetCellDifferenceDisplayValue(BKl, columnAxisValuesForCompare, rowAxisValuesForCompare, sliceAxisValuesForCompare, P_4, P_3, P_5, P_2) != 0.0;
		}
		return false;
	}

	private void C(object P_0, EventArgs P_1)
	{
		if ((((DataGridView)BVw).SelectedCells == null || ((BaseCollection)((DataGridView)BVw).SelectedCells).Count == 0) && ((DataGridView)BVw).Rows.Count != 0 && ((BaseCollection)((DataGridView)BVw).Rows[0].Cells).Count != 0)
		{
			((DataGridView)BVw).Rows[0].Cells[0].Selected = true;
		}
		BM.A((Control)(object)this);
		((Control)this).Invalidate();
	}

	private void c(object P_0, EventArgs P_1)
	{
		BM.e();
		((Control)this).Invalidate();
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		if ((int)P_1.Button != 1048576 || BKE == null || !((SettingOrSpecialObject)BKE).l() || !BKD.C())
		{
			return;
		}
		if (BVw.a())
		{
			BVw.b();
		}
		Table table = ((BM.QO != BM.b.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		Point val = ((Control)this).PointToClient(Control.MousePosition);
		int num = table.HorizAxisCount();
		int num2 = table.VertAxisCount();
		int num3 = 0;
		if (table.VertAxisEnabled())
		{
			num3 = ((DataGridView)BVw).RowHeadersWidth;
		}
		int num4 = 0;
		if (table.HorizAxisEnabled())
		{
			num4 = ((DataGridView)BVw).ColumnHeadersHeight;
		}
		int num5 = ((Control)BVw).Left + num3;
		Rectangle val2 = default(Rectangle);
		for (int i = 0; i < num; i++)
		{
			int width = ((DataGridView)BVw).Columns[i].Width;
			((Rectangle)(ref val2))._002Ector(num5 - ((DataGridView)BVw).HorizontalScrollingOffset, ((Control)BVw).Top, width, num4);
			if (((Rectangle)(ref val2)).Contains(val))
			{
				int num6 = (BvK = i);
				bool flag = false;
				for (int j = 0; j < num2; j++)
				{
					for (int k = 0; k < num; k++)
					{
						if (k == num6)
						{
							if (!flag)
							{
								((DataGridView)BVw).CurrentCell = ((DataGridView)BVw).Rows[j].Cells[k];
								flag = true;
							}
							((DataGridView)BVw).Rows[j].Cells[k].Selected = true;
						}
						else
						{
							((DataGridView)BVw).Rows[j].Cells[k].Selected = false;
						}
					}
				}
				return;
			}
			num5 += width;
		}
		int num7 = ((Control)BVw).Top + num4;
		Rectangle val3 = default(Rectangle);
		for (int l = 0; l < num2; l++)
		{
			int height = ((DataGridView)BVw).Rows[l].Height;
			((Rectangle)(ref val3))._002Ector(((Control)BVw).Left, num7 - ((DataGridView)BVw).VerticalScrollingOffset, num3, height);
			if (((Rectangle)(ref val3)).Contains(val))
			{
				int num8 = (Bvk = l);
				bool flag2 = false;
				for (int m = 0; m < num; m++)
				{
					for (int n = 0; n < num2; n++)
					{
						if (n == num8)
						{
							if (!flag2)
							{
								((DataGridView)BVw).CurrentCell = ((DataGridView)BVw).Rows[n].Cells[m];
								flag2 = true;
							}
							((DataGridView)BVw).Rows[n].Cells[m].Selected = true;
						}
						else
						{
							((DataGridView)BVw).Rows[n].Cells[m].Selected = false;
						}
					}
				}
				break;
			}
			num7 += height;
		}
	}

	private void a(object P_0, MouseEventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		if ((int)P_1.Button != 1048576 || BKE == null || !((SettingOrSpecialObject)BKE).l() || (BvK == -1 && Bvk == -1) || !BKD.C())
		{
			return;
		}
		Table table = ((BM.QO != BM.b.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		Point val = ((Control)this).PointToClient(Control.MousePosition);
		int num = table.HorizAxisCount();
		int num2 = table.VertAxisCount();
		int num3 = 0;
		if (table.VertAxisEnabled())
		{
			num3 = ((DataGridView)BVw).RowHeadersWidth;
		}
		int num4 = 0;
		if (table.HorizAxisEnabled())
		{
			num4 = ((DataGridView)BVw).ColumnHeadersHeight;
		}
		int num5 = ((Control)BVw).Left + num3;
		Rectangle val2 = default(Rectangle);
		for (int i = 0; i < num; i++)
		{
			int width = ((DataGridView)BVw).Columns[i].Width;
			((Rectangle)(ref val2))._002Ector(num5 - ((DataGridView)BVw).HorizontalScrollingOffset, ((Control)BVw).Top, width, ((Control)BVw).Height);
			if (((Rectangle)(ref val2)).Contains(val) && ((Point)(ref val)).X > ((Control)BVw).Left + num3)
			{
				int num6 = i;
				for (int j = 0; j < num2; j++)
				{
					for (int k = 0; k < num; k++)
					{
						((DataGridView)BVw).Rows[j].Cells[k].Selected = (num6 == BvK && k == num6) || (num6 > BvK && k >= BvK && k <= num6) || (num6 < BvK && k >= num6 && k <= BvK);
					}
				}
				return;
			}
			num5 += width;
		}
		int num7 = ((Control)BVw).Top + num4;
		Rectangle val3 = default(Rectangle);
		for (int l = 0; l < num2; l++)
		{
			int height = ((DataGridView)BVw).Rows[l].Height;
			((Rectangle)(ref val3))._002Ector(((Control)BVw).Left, num7 - ((DataGridView)BVw).VerticalScrollingOffset, ((Control)BVw).Width, height);
			if (((Rectangle)(ref val3)).Contains(val))
			{
				int num8 = l;
				for (int m = 0; m < num; m++)
				{
					for (int n = 0; n < num2; n++)
					{
						((DataGridView)BVw).Rows[n].Cells[m].Selected = (num8 == Bvk && n == num8) || (num8 > Bvk && n >= Bvk && n <= num8) || (num8 < Bvk && n >= num8 && n <= Bvk);
					}
				}
				break;
			}
			num7 += height;
		}
	}

	private void B(object P_0, MouseEventArgs P_1)
	{
		BvK = -1;
		Bvk = -1;
	}

	internal void f()
	{
		if (BKE == null)
		{
			return;
		}
		Bvg.Clear();
		if (BM.QO != BM.b.BpG || BKd == null)
		{
			int num = BKE.HorizAxisCount();
			int num2 = BKE.VertAxisCount();
			int num3 = BKE.SliceCount();
			BvI = new List<A>[num3, num2, num];
			for (int i = 0; i < num3; i++)
			{
				for (int j = 0; j < num2; j++)
				{
					for (int k = 0; k < num; k++)
					{
						BvI[i, j, k] = new List<A>();
					}
				}
			}
		}
		else
		{
			BvI = null;
		}
	}

	private void D(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				c c = D;
				((Control)this).Invoke((System.Delegate)c, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		f();
		E();
		UpdateLayout(resizingOnly: false);
		F();
		((Control)this).Invalidate();
	}

	private void d(object P_0, EventArgs P_1)
	{
		if (BKE == null || (BKe != null && (BKi || BKJ) && BM.QO == BM.b.BpF))
		{
			return;
		}
		Table table = ((BM.QO != BM.b.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		try
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				a(val);
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
			E(null, null);
		}
		catch
		{
		}
	}

	private void E(object P_0, EventArgs P_1)
	{
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		if (((DataGridView)BVw).Rows.Count == 0 || BKE == null || (BKe != null && (BKi || BKJ) && BM.QO == BM.b.BpF))
		{
			return;
		}
		Table table = ((BM.QO != BM.b.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		int num = table.HorizAxisCount();
		int num2 = table.VertAxisCount();
		int num3 = table.SliceCount();
		if (BM.tV || num2 != ((DataGridView)BVw).Rows.Count || num != ((BaseCollection)((DataGridView)BVw).Rows[0].Cells).Count)
		{
			F();
			return;
		}
		int num4 = table.TableDataSetting.aS();
		int num5 = 0;
		if (table.SlicesEnabled())
		{
			num5 = table.UserSliceIndex;
		}
		int num6 = 2147483647;
		int num7 = -2147483648;
		for (int i = 0; i < num3; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				for (int k = 0; k < num; k++)
				{
					int currentTableRawCellValue;
					int compareTableRawCellValue;
					int num8 = ((BM.QO == BM.b.BpF && BKe != null) ? bS.A(BKE.GetCellDifferenceDisplayValue(BKe, k, j, num5, out currentTableRawCellValue, out compareTableRawCellValue), num4) : ((!table.SwapColumnsAndRows) ? table.TableDataSetting.B(k, j, i) : table.TableDataSetting.B(j, k, i)));
					if (num8 > num7)
					{
						num7 = num8;
					}
					if (num8 < num6)
					{
						num6 = num8;
					}
				}
			}
		}
		int num9 = BM.TV * 255 / 100;
		int num10 = BM.Tu * 255 / 100;
		int num11 = BM.Tv * 255 / 100;
		int num12 = BM.TW * 255 / 100;
		for (int j = 0; j < num2; j++)
		{
			for (int k = 0; k < num; k++)
			{
				if (!BVw.a())
				{
					int num13 = 0;
					if (BKe != null)
					{
						num13 = ((!table.InvertRows) ? bS.A(BKE.GetCellDifferenceDisplayValue(BKe, k, j, num5, out var _, out var _), num4) : bS.A(BKE.GetCellDifferenceDisplayValue(BKe, k, num2 - 1 - j, num5, out var _, out var _), num4));
					}
					int num14;
					if (BM.QO == BM.b.BpF && BKe != null)
					{
						num14 = num13;
						((DataGridView)BVw).Rows[j].Cells[k].Value = bS.a(num14, num4, -1);
					}
					else
					{
						table.GetColumnIndexAndRowIndex(k, j, out var columnIndex, out var rowIndex);
						num14 = table.TableDataSetting.B(columnIndex, rowIndex, num5);
						((DataGridView)BVw).Rows[j].Cells[k].Value = bS.A(num14, num4, bS.A(num4), -1);
					}
					Color backColor = A(num14, num6, num7, num9, num10, num11, num12);
					DataGridViewCellStyle val = new DataGridViewCellStyle();
					val.BackColor = backColor;
					((DataGridView)BVw).Rows[j].Cells[k].Style = val;
					bool flag = false;
					if (BKe != null)
					{
						flag = bS.A(num13, num4, -1) != 0.0;
					}
					bool flag2 = A(table, num4, num2, j, k, num5);
					b tag = new b(flag, flag2);
					((DataGridView)BVw).Rows[j].Cells[k].Tag = tag;
				}
			}
		}
		if (BvG)
		{
			M();
		}
		l();
	}

	private void e(object P_0, EventArgs P_1)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (BVw != null && base.B())
		{
			((Control)this).Invalidate(new Rectangle(0, 0, ((Control)this).Width, ((Control)BVw).Top));
		}
	}

	private void F(object P_0, EventArgs P_1)
	{
		((Control)this).Invalidate();
		if (BVw != null)
		{
			((Control)BVw).Invalidate();
		}
	}

	private void f(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				D d = f;
				((Control)this).BeginInvoke((System.Delegate)d, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		H();
		((Control)this).Invalidate();
		if (BVw != null)
		{
			((Control)BVw).Invalidate();
		}
	}

	private void G(object P_0, EventArgs P_1)
	{
		((Control)this).Invalidate();
	}

	private void A(object P_0, PaintEventArgs P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		Stopwatch val = new Stopwatch();
		val.Start();
		if (BKE == null)
		{
			return;
		}
		Graphics graphics = P_1.Graphics;
		graphics.SmoothingMode = (SmoothingMode)2;
		float num = 0f;
		SolidBrush val2 = new SolidBrush(BM.tf);
		SizeF val4;
		try
		{
			Font val3 = new Font(((Control)this).Font.FontFamily, 10f, (FontStyle)1);
			try
			{
				string text = ((SettingOrSpecialObject)BKE).H();
				string text2 = (string.IsNullOrWhiteSpace(text) ? ((SettingOrSpecialObject)BKE).A(bz.aYt) : text);
				if (BM.QO == BM.b.BpF && BKe != null && (BKi || BKJ))
				{
					text2 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfI();
				}
				val4 = graphics.MeasureString(text2, val3);
				num = ((SizeF)(ref val4)).Width;
				if (BvB == null || BvB.am())
				{
					graphics.DrawString(text2, val3, (Brush)(object)val2, 8f, 8f);
				}
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val2)?.Dispose();
		}
		if (((Control)BvC).Visible && (float)((Control)BvC).Left != num + 10f)
		{
			((Control)BvC).Left = (int)num + 10;
		}
		Color val5 = ((!((Control)BVw).Focused || !((SettingOrSpecialObject)BKE).l()) ? Color.Gray : BM.te);
		if (BVX != null && !string.IsNullOrEmpty(BKL))
		{
			SolidBrush val6 = new SolidBrush(val5);
			try
			{
				Font val7 = new Font(((Control)this).Font.FontFamily, 10f);
				try
				{
					int num2 = (((Control)BvC).Visible ? 70 : 30);
					graphics.DrawString(BKL, val7, (Brush)(object)val6, num + (float)num2, 8f);
					float num3 = num;
					float num4 = num2;
					val4 = graphics.MeasureString(BKL, val7);
					num = num3 + (num4 + ((SizeF)(ref val4)).Width);
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
		SolidBrush val8 = new SolidBrush(val5);
		try
		{
			Font val9 = new Font(((Control)this).Font.FontFamily, 10f);
			try
			{
				if (BM.QO != BM.b.BpG)
				{
					int num5 = BKE.aS();
					string text3 = string.Empty;
					if (num5 != 0 && num5 != 82)
					{
						text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + bS.A(BKE.@as(), num5, false, 0);
					}
					if ((!BM.A(BKD.aXc, true) || BM.aE()) && !BM.C(((Setting)BKE).A()))
					{
						graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFs() + text3, val9, (Brush)(object)val8, num + 60f, 8f);
					}
					else
					{
						ValueTuple<string, string, bool> val10 = BKE.aX();
						graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFT() + val10.Item1 + (val10.Item3 ? string.Empty : text3), val9, (Brush)(object)val8, num + 60f, 8f);
					}
					if (Bvi != string.Empty)
					{
						graphics.DrawString(Bvi, val9, (Brush)(object)val8, num + 200f, 8f);
					}
				}
				B(graphics);
				if (BVY == 0 && BVZ == 0)
				{
					A(graphics);
				}
				Table table;
				Setting setting;
				Setting setting2;
				if (BM.QO == BM.b.BpG)
				{
					table = BKe;
					setting = BKH;
					setting2 = BKh;
					_ = BKI;
				}
				else
				{
					table = BKE;
					setting = BKf;
					setting2 = BKG;
					_ = BKg;
				}
				if (table == null)
				{
					return;
				}
				A(graphics, val9, (Brush)(object)val8, table, setting2, setting);
			}
			finally
			{
				((System.IDisposable)val9)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val8)?.Dispose();
		}
		val.Stop();
		global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfi(), (object)val.ElapsedMilliseconds, (object)((Control)this).Left, (object)((Control)this).Top), false);
	}

	private void A(Graphics P_0, Font P_1, Brush P_2, Table P_3, Setting P_4, Setting P_5)
	{
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		bool flag;
		bool num = (flag = P_3.VertAxisEnabled());
		if (BKe != null)
		{
			if (P_3 == BKE)
			{
				flag = BKe.VertAxisEnabled();
			}
			else if (P_3 == BKe)
			{
				flag = BKE.VertAxisEnabled();
			}
		}
		string text = null;
		bool flag2 = true;
		bool flag3 = true;
		if (num && P_3.VertAxis.g() != null && P_4 != null)
		{
			string text2 = string.Empty;
			int num2 = P_4.aS();
			if (num2 != 0 && num2 != 82)
			{
				text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(P_4.@as(), num2, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
			}
			string text3 = ((SettingOrSpecialObject)P_4).H();
			text = (string.IsNullOrWhiteSpace(text3) ? ((SettingOrSpecialObject)P_4).A(bz.aYt) : text3);
			text += text2;
			flag2 = flag && (BKe == null || (BKh != null && BKh.A() == BKG.A()));
			if (BKk != null && BKK.aa())
			{
				int num3 = ((!BKE.SwapColumnsAndRows) ? 1 : 2);
				flag3 = BKM[num3].Bvv && BKM[num3].BvW == P_4.A();
			}
		}
		bool flag4;
		bool num4 = (flag4 = P_3.HorizAxisEnabled());
		if (BKe != null)
		{
			if (P_3 == BKE)
			{
				flag4 = BKe.HorizAxisEnabled();
			}
			else if (P_3 == BKe)
			{
				flag4 = BKE.HorizAxisEnabled();
			}
		}
		string text4 = null;
		bool flag5 = true;
		bool flag6 = true;
		if (num4 && P_3.HorizAxis.g() != null && P_5 != null)
		{
			string text5 = string.Empty;
			int num5 = P_5.aS();
			if (num5 != 0 && num5 != 82)
			{
				text5 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(P_5.@as(), num5, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
			}
			string text6 = ((SettingOrSpecialObject)P_5).H();
			text4 = (string.IsNullOrWhiteSpace(text6) ? ((SettingOrSpecialObject)P_5).A(bz.aYt) : text6);
			text4 += text5;
			flag5 = flag4 && (BKe == null || (BKH != null && BKH.A() == BKf.A()));
			if (BKk != null && BKK.aa())
			{
				int num6 = (BKE.SwapColumnsAndRows ? 1 : 2);
				flag6 = BKM[num6].Bvv && BKM[num6].BvW == P_5.A();
			}
		}
		if (text != null)
		{
			Rectangle val = default(Rectangle);
			((Rectangle)(ref val))._002Ector(8, ((Control)BVw).Top - BVx - 2, 140, BVx);
			Font val2 = (Font)(flag3 ? ((object)P_1) : ((object)new Font(P_1, (FontStyle)2)));
			if (flag2 || BKi || BKJ)
			{
				P_0.DrawString(text, val2, P_2, RectangleF.op_Implicit(val));
			}
			else
			{
				SolidBrush val3 = new SolidBrush(BM.tD);
				try
				{
					P_0.DrawString(text, val2, (Brush)(object)val3, RectangleF.op_Implicit(val));
				}
				finally
				{
					((System.IDisposable)val3)?.Dispose();
				}
			}
			if (!flag3)
			{
				val2.Dispose();
			}
		}
		if (text4 == null)
		{
			return;
		}
		Rectangle val4 = default(Rectangle);
		((Rectangle)(ref val4))._002Ector(BVz, ((Control)BVw).Top - BVy - 2, BVZ, BVy);
		Font val5 = (Font)(flag6 ? ((object)P_1) : ((object)new Font(P_1, (FontStyle)2)));
		if (flag5 || BKi || BKJ)
		{
			P_0.DrawString(text4, val5, P_2, RectangleF.op_Implicit(val4));
		}
		else
		{
			SolidBrush val6 = new SolidBrush(BM.tD);
			try
			{
				P_0.DrawString(text4, val5, (Brush)(object)val6, RectangleF.op_Implicit(val4));
			}
			finally
			{
				((System.IDisposable)val6)?.Dispose();
			}
		}
		if (!flag6)
		{
			val5.Dispose();
		}
	}

	private void B(Graphics P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		if (!BKE.ColumnAxisMonotonicityIsValid())
		{
			SolidBrush val = new SolidBrush(BM.tC);
			try
			{
				Font val2 = new Font(((Control)this).Font.FontFamily, 8f, (FontStyle)1);
				try
				{
					if (BKE.ColumnAxis.C() && BKE.ColumnAxis.c())
					{
						P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfJ(), val2, (Brush)(object)val, 8f, 25f);
					}
					else if (BKE.ColumnAxis.C())
					{
						P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfj(), val2, (Brush)(object)val, 8f, 25f);
					}
					else if (BKE.ColumnAxis.c())
					{
						P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfK(), val2, (Brush)(object)val, 8f, 25f);
					}
					return;
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		if (BKE.RowAxisMonotonicityIsValid())
		{
			return;
		}
		SolidBrush val3 = new SolidBrush(BM.tC);
		try
		{
			Font val4 = new Font(((Control)this).Font.FontFamily, 8f, (FontStyle)1);
			try
			{
				if (BKE.RowAxis.C() && BKE.RowAxis.c())
				{
					P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfJ(), val4, (Brush)(object)val3, 8f, 25f);
				}
				else if (BKE.RowAxis.C())
				{
					P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfj(), val4, (Brush)(object)val3, 8f, 25f);
				}
				else if (BKE.RowAxis.c())
				{
					P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfK(), val4, (Brush)(object)val3, 8f, 25f);
				}
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

	private int G()
	{
		if (BM.QO == BM.b.BpG)
		{
			return 0;
		}
		bool num = BKE.VertAxisEnabled();
		int num2 = BKE.HorizAxisCount();
		int num3 = 0;
		if (num)
		{
			num3 = ((DataGridView)BVw).RowHeadersWidth;
		}
		if (BKf == null || !BKE.HorizAxisEnabled() || ((BaseCollection)((DataGridView)BVw).Columns).Count == 0 || num2 > ((BaseCollection)((DataGridView)BVw).Columns).Count)
		{
			return num3 + 24;
		}
		AxisBehaviour axisBehaviour = BKE.HorizAxis.I();
		int result = 0;
		int num4 = BKf.ax();
		int num5 = BKE.HorizAxis.G().m(0);
		int num6 = BKE.HorizAxis.G().m(num2 - 1);
		int num7 = num3;
		for (int i = 0; i < num2 - 1; i++)
		{
			num7 += ((DataGridView)BVw).Columns[i].Width;
		}
		if (num4 >= num6)
		{
			if (num2 <= ((BaseCollection)((DataGridView)BVw).Columns).Count)
			{
				result = num7 + ((DataGridView)BVw).Columns[num2 - 1].Width / 2;
			}
		}
		else if (num4 <= num5)
		{
			result = num3 + ((DataGridView)BVw).Columns[0].Width / 2;
		}
		else
		{
			switch (axisBehaviour)
			{
			case AxisBehaviour.DiscreteCentred:
			{
				for (int k = 1; k < num2; k++)
				{
					int num17 = BKE.HorizAxis.G().m(k - 1);
					int num18 = BKE.HorizAxis.G().m(k);
					int num19 = num17 + num18 >> 1;
					if (num4 == num17 || num4 < num19 || k == num2 - 1)
					{
						int num20 = ((num4 != num17 && num4 >= num19) ? k : (k - 1));
						int num21 = num3;
						for (int l = 0; l < num20; l++)
						{
							num21 += ((DataGridView)BVw).Columns[l].Width;
						}
						result = num21 + ((DataGridView)BVw).Columns[num20].Width / 2;
						break;
					}
				}
				break;
			}
			case AxisBehaviour.Continuous:
			{
				int num8 = 0;
				for (int num9 = num2 - 1; num9 >= 0; num9--)
				{
					int num10 = BKE.HorizAxis.G().m(num9);
					if (num4 >= num10)
					{
						num8 = num9;
						break;
					}
				}
				if (num8 == num2 - 1)
				{
					num8--;
				}
				int num11 = BKE.HorizAxis.G().m(num8);
				int num12 = BKE.HorizAxis.G().m(num8 + 1);
				int num13 = num3;
				for (int j = 0; j < num8; j++)
				{
					num13 += ((DataGridView)BVw).Columns[j].Width;
				}
				float num14 = (float)(num11 + num12) / 2f;
				if ((float)num4 <= num14)
				{
					int num15 = ((DataGridView)BVw).Columns[num8].Width / 2;
					result = num13 + num15 + (int)((float)(num15 * (num4 - num11)) / (num14 - (float)num11));
				}
				else
				{
					int num16 = ((DataGridView)BVw).Columns[num8 + 1].Width / 2;
					result = num13 + ((DataGridView)BVw).Columns[num8].Width + (int)((float)num16 * ((float)num4 - num14) / ((float)num12 - num14));
				}
				break;
			}
			}
		}
		return result;
	}

	private int g()
	{
		if (BM.QO == BM.b.BpG)
		{
			return 0;
		}
		bool num = BKE.HorizAxisEnabled();
		int num2 = BKE.VertAxisCount();
		int num3 = 0;
		if (num)
		{
			num3 = ((DataGridView)BVw).ColumnHeadersHeight;
		}
		if (BKG == null || !BKE.VertAxisEnabled() || ((DataGridView)BVw).Rows.Count == 0 || num2 > ((DataGridView)BVw).Rows.Count)
		{
			return num3 + 8;
		}
		AxisBehaviour axisBehaviour = BKE.VertAxis.I();
		int result = 0;
		int num4 = BKG.ax();
		int num5 = BKE.VertAxis.G().m(0);
		int num6 = BKE.VertAxis.G().m(num2 - 1);
		int num7 = num3;
		for (int i = 0; i < num2 - 1; i++)
		{
			num7 += ((DataGridView)BVw).Rows[i].Height;
		}
		if (num4 >= num6)
		{
			if (BKE.InvertRows)
			{
				result = num3 + ((DataGridView)BVw).Rows[0].Height / 2;
			}
			else if (num2 <= ((DataGridView)BVw).Rows.Count)
			{
				result = num7 + ((DataGridView)BVw).Rows[num2 - 1].Height / 2;
			}
		}
		else if (num4 <= num5)
		{
			if (BKE.InvertRows && num2 <= ((DataGridView)BVw).Rows.Count)
			{
				result = num7 + ((DataGridView)BVw).Rows[num2 - 1].Height / 2;
			}
			else if (!BKE.InvertRows)
			{
				result = num3 + ((DataGridView)BVw).Rows[0].Height / 2;
			}
		}
		else
		{
			switch (axisBehaviour)
			{
			case AxisBehaviour.DiscreteCentred:
			{
				for (int l = 1; l < num2; l++)
				{
					int num21 = BKE.VertAxis.G().m(l - 1);
					int num22 = BKE.VertAxis.G().m(l);
					int num23 = num21 + num22 >> 1;
					if (num4 != num21 && num4 >= num23 && l != num2 - 1)
					{
						continue;
					}
					int num24 = ((num4 != num21 && num4 >= num23) ? l : (l - 1));
					if (BKE.InvertRows)
					{
						int num25 = num3;
						int num26 = 0;
						for (int m = 0; m < num2; m++)
						{
							num25 += ((DataGridView)BVw).Rows[m].Height;
							if (m < num24)
							{
								num26 += ((DataGridView)BVw).Rows[num2 - 1 - m].Height;
							}
						}
						result = num25 - (num26 + ((DataGridView)BVw).Rows[num24].Height / 2);
					}
					else
					{
						int num27 = num3;
						for (int n = 0; n < num24; n++)
						{
							num27 += ((DataGridView)BVw).Rows[n].Height;
						}
						result = num27 + ((DataGridView)BVw).Rows[num24].Height / 2;
					}
					break;
				}
				break;
			}
			case AxisBehaviour.Continuous:
			{
				int num8 = 0;
				for (int num9 = num2 - 1; num9 >= 0; num9--)
				{
					int num10 = BKE.VertAxis.G().m(num9);
					if (num4 >= num10)
					{
						num8 = num9;
						break;
					}
				}
				if (num8 == num2 - 1)
				{
					num8--;
				}
				int num11 = BKE.VertAxis.G().m(num8);
				int num12 = BKE.VertAxis.G().m(num8 + 1);
				float num13 = (float)(num11 + num12) / 2f;
				if (BKE.InvertRows)
				{
					int num14 = num3;
					int num15 = 0;
					for (int j = 0; j < num2; j++)
					{
						num14 += ((DataGridView)BVw).Rows[j].Height;
						if (j < num8)
						{
							num15 += ((DataGridView)BVw).Rows[num2 - 1 - j].Height;
						}
					}
					if ((float)num4 <= num13)
					{
						int num16 = ((DataGridView)BVw).Rows[num8].Height / 2;
						result = num14 - (num15 + num16 + (int)((float)(num16 * (num4 - num11)) / (num13 - (float)num11)));
					}
					else
					{
						int num17 = ((DataGridView)BVw).Rows[num8 + 1].Height / 2;
						result = num14 - (num15 + ((DataGridView)BVw).Rows[num8].Height + (int)((float)num17 * ((float)num4 - num13) / ((float)num12 - num13)));
					}
				}
				else
				{
					int num18 = num3;
					for (int k = 0; k < num8; k++)
					{
						num18 += ((DataGridView)BVw).Rows[k].Height;
					}
					if ((float)num4 <= num13)
					{
						int num19 = ((DataGridView)BVw).Rows[num8].Height / 2;
						result = num18 + num19 + (int)((float)(num19 * (num4 - num11)) / (num13 - (float)num11));
					}
					else
					{
						int num20 = ((DataGridView)BVw).Rows[num8 + 1].Height / 2;
						result = num18 + ((DataGridView)BVw).Rows[num8].Height + (int)((float)num20 * ((float)num4 - num13) / ((float)num12 - num13));
					}
				}
				break;
			}
			}
		}
		return result;
	}

	internal void H()
	{
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		if (!base.B() || BVw == null || ((DataGridView)BVw).Rows.Count == 0 || ((BaseCollection)((DataGridView)BVw).Columns).Count == 0 || BM.QO == BM.b.BpG)
		{
			return;
		}
		try
		{
			if ((BM.A(BKD.aXc, true) && !BM.aE()) || (BKf != null && BM.C(BKf.A()) && BKG != null && BM.C(BKG.A())))
			{
				bool baP = BKE.HorizAxisEnabled();
				bool bar = BKE.VertAxisEnabled();
				int bas = BKE.HorizAxisCount();
				int baR = BKE.VertAxisCount();
				int baQ = 0;
				if (bar)
				{
					baQ = ((DataGridView)BVw).RowHeadersWidth;
				}
				int baq = 0;
				if (baP)
				{
					baq = ((DataGridView)BVw).ColumnHeadersHeight;
				}
				int bap = G() - ((DataGridView)BVw).HorizontalScrollingOffset;
				((Control)Bvc).Invoke((Action)delegate
				{
					if (baP && BKf != null)
					{
						if (Bve == bC.zw)
						{
							((Control)Bvc).BringToFront();
							((Control)Bvc).Left = ((Control)BVw).Left + bap;
							if (((Control)Bvc).Left < ((Control)BVw).Left + baQ || ((Control)Bvc).Left > ((Control)BVw).Right)
							{
								((Control)Bvc).Visible = false;
							}
							else
							{
								((Control)Bvc).Visible = true;
							}
							((Control)Bvc).Top = ((Control)BVw).Top;
							int num12 = baq;
							for (int j = 0; j < baR; j++)
							{
								num12 += ((DataGridView)BVw).Rows[j].Height;
							}
							if (BVw.c() && num12 > ((Control)BVw).Height - 18)
							{
								((Control)Bvc).Height = Math.Min(((Control)BVw).Height, num12) - 18;
							}
							else
							{
								((Control)Bvc).Height = Math.Min(((Control)BVw).Height, num12);
							}
						}
						else
						{
							((Control)Bvc).Visible = false;
						}
					}
					else
					{
						((Control)Bvc).Visible = false;
					}
				});
				int baS = g() - ((DataGridView)BVw).VerticalScrollingOffset;
				((Control)BvD).Invoke((Action)delegate
				{
					if (bar && BKG != null)
					{
						if (Bve == bC.zw)
						{
							((Control)BvD).BringToFront();
							((Control)BvD).Top = ((Control)BVw).Top + baS;
							if (((Control)BvD).Top < ((Control)BVw).Top + baq || ((Control)BvD).Top > ((Control)BVw).Bottom)
							{
								((Control)BvD).Visible = false;
							}
							else
							{
								((Control)BvD).Visible = true;
							}
							((Control)BvD).Left = ((Control)BVw).Left;
							int num11 = baQ;
							for (int i = 0; i < bas; i++)
							{
								num11 += ((DataGridView)BVw).Columns[i].Width;
							}
							if (BVw.D() && num11 > ((Control)BVw).Width - 18)
							{
								((Control)BvD).Width = Math.Min(((Control)BVw).Width, num11) - 18;
							}
							else
							{
								((Control)BvD).Width = Math.Min(((Control)BVw).Width, num11);
							}
						}
						else
						{
							((Control)BvD).Visible = false;
						}
					}
					else
					{
						((Control)BvD).Visible = false;
					}
				});
				if (Bve == bC.zX || Bve == bC.zx || Bve == bC.zW)
				{
					if (baP && BKf != null)
					{
						int num = Math.Min(bap, BvH) - 20;
						int num2 = Math.Max(bap, BvH) + 20;
						Rectangle val = default(Rectangle);
						((Rectangle)(ref val))._002Ector(num, 0, num2 - num, 10);
						((Control)BVw).Invalidate(val);
					}
					if (bar && BKG != null)
					{
						int num3 = Math.Min(baS, Bvh) - 20;
						int num4 = Math.Max(baS, Bvh) + 20;
						Rectangle val2 = default(Rectangle);
						((Rectangle)(ref val2))._002Ector(0, num3, 10, num4 - num3);
						((Control)BVw).Invalidate(val2);
					}
				}
				if (Bve == bC.zX || Bve == bC.zx || Bve == bC.zW || (BvG && baP && BKf != null && bar && BKG != null))
				{
					if (BvH == 0 && Bvh == 0)
					{
						((Control)BVw).Invalidate();
					}
					else
					{
						int num5 = 28;
						int num6 = 12;
						int num7 = Math.Min(bap, BvH) - num5;
						int num8 = Math.Max(bap, BvH) + num5;
						int num9 = Math.Min(baS, Bvh) - num6;
						int num10 = Math.Max(baS, Bvh) + num6;
						Rectangle val3 = default(Rectangle);
						((Rectangle)(ref val3))._002Ector(num7, num9, num8 - num7, num10 - num9);
						((Control)BVw).Invalidate(val3);
					}
					BvH = bap;
					Bvh = baS;
				}
				if (BvJ && !BVw.a())
				{
					n();
				}
			}
			else
			{
				((Control)Bvc).Invoke((Action)([CompilerGenerated] () =>
				{
					((Control)Bvc).Visible = false;
				}));
				((Control)BvD).Invoke((Action)([CompilerGenerated] () =>
				{
					((Control)BvD).Visible = false;
				}));
				if (BvG)
				{
					((Control)BVw).Invalidate();
				}
			}
			((Control)BKj).Invalidate();
		}
		catch
		{
		}
	}

	private void g(object P_0, EventArgs P_1)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (((DataGridView)BVw).CurrentCell != null)
		{
			BKE.UserCurrentCellHorizVertIndex = new Point(((DataGridView)BVw).CurrentCell.ColumnIndex, ((DataGridView)BVw).CurrentCell.RowIndex);
		}
		else
		{
			BKE.UserCurrentCellHorizVertIndex = new Point(-1, -1);
		}
	}

	private void H(object P_0, EventArgs P_1)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		if (!BvL)
		{
			return;
		}
		List<Point> val = new List<Point>();
		if (((DataGridView)BVw).SelectedCells != null && ((BaseCollection)((DataGridView)BVw).SelectedCells).Count != 0)
		{
			foreach (DataGridViewCell item in (BaseCollection)((DataGridView)BVw).SelectedCells)
			{
				DataGridViewCell val2 = item;
				val.Add(new Point(val2.ColumnIndex, val2.RowIndex));
			}
		}
		if (BM.QO == BM.b.BpG)
		{
			BKe.HorizVertIndexPerUserSelectedCell = val;
			BKE.HorizVertIndexPerUserSelectedCell = val;
			return;
		}
		BKE.HorizVertIndexPerUserSelectedCell = val;
		if (BKe != null)
		{
			BKe.HorizVertIndexPerUserSelectedCell = val;
		}
	}

	private void h(object P_0, EventArgs P_1)
	{
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		Table table = ((BM.QO != BM.b.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		A(table);
		a(table);
		Enumerator<Point> enumerator;
		if (table.HorizVertIndexPerUserSelectedCell.Count != 0)
		{
			enumerator = table.HorizVertIndexPerUserSelectedCell.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Point current = enumerator.Current;
					if (((Point)(ref current)).X < ((BaseCollection)((DataGridView)BVw).Columns).Count)
					{
						((DataGridViewCell)((DataGridView)BVw).Columns[((Point)(ref current)).X].HeaderCell).Style.BackColor = Color.DarkSeaGreen;
					}
					if (((Point)(ref current)).Y < ((DataGridView)BVw).Rows.Count)
					{
						((DataGridViewCell)((DataGridView)BVw).Rows[((Point)(ref current)).Y].HeaderCell).Style.BackColor = Color.PaleVioletRed;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		List<DataGridViewCell> val = new List<DataGridViewCell>();
		enumerator = BKE.HorizVertIndexPerUserSelectedCell.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Point current2 = enumerator.Current;
				val.Add(((DataGridView)BVw).Rows[((Point)(ref current2)).Y].Cells[((Point)(ref current2)).X]);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		bool flag = false;
		Enumerator<DataGridViewCell> enumerator2;
		if (val.Count != ((BaseCollection)((DataGridView)BVw).SelectedCells).Count)
		{
			flag = true;
		}
		else
		{
			enumerator2 = val.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					DataGridViewCell current3 = enumerator2.Current;
					if (!((DataGridView)BVw).SelectedCells.Contains(current3))
					{
						flag = true;
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			if (!flag)
			{
				foreach (DataGridViewCell item in (BaseCollection)((DataGridView)BVw).SelectedCells)
				{
					DataGridViewCell val2 = item;
					if (!val.Contains(val2))
					{
						flag = true;
						break;
					}
				}
			}
		}
		if (flag)
		{
			BvL = false;
			Point userCurrentCellHorizVertIndex = BKE.UserCurrentCellHorizVertIndex;
			if (((Point)(ref userCurrentCellHorizVertIndex)).X != -1)
			{
				userCurrentCellHorizVertIndex = BKE.UserCurrentCellHorizVertIndex;
				if (((Point)(ref userCurrentCellHorizVertIndex)).Y != -1)
				{
					if (((DataGridView)BVw).CurrentCell != null)
					{
						userCurrentCellHorizVertIndex = BKE.UserCurrentCellHorizVertIndex;
						if (((Point)(ref userCurrentCellHorizVertIndex)).X == ((DataGridView)BVw).CurrentCell.ColumnIndex)
						{
							userCurrentCellHorizVertIndex = BKE.UserCurrentCellHorizVertIndex;
							if (((Point)(ref userCurrentCellHorizVertIndex)).Y == ((DataGridView)BVw).CurrentCell.RowIndex)
							{
								goto IL_0300;
							}
						}
					}
					d bVw = BVw;
					DataGridViewRowCollection rows = ((DataGridView)BVw).Rows;
					userCurrentCellHorizVertIndex = BKE.UserCurrentCellHorizVertIndex;
					DataGridViewCellCollection cells = rows[((Point)(ref userCurrentCellHorizVertIndex)).Y].Cells;
					userCurrentCellHorizVertIndex = BKE.UserCurrentCellHorizVertIndex;
					((DataGridView)bVw).CurrentCell = cells[((Point)(ref userCurrentCellHorizVertIndex)).X];
				}
			}
			goto IL_0300;
		}
		goto IL_03b5;
		IL_0300:
		enumerator2 = val.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				DataGridViewCell current4 = enumerator2.Current;
				((DataGridView)BVw).Rows[current4.RowIndex].Cells[current4.ColumnIndex].Selected = true;
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
		foreach (DataGridViewCell item2 in (BaseCollection)((DataGridView)BVw).SelectedCells)
		{
			DataGridViewCell val3 = item2;
			if (!val.Contains(val3))
			{
				val3.Selected = false;
			}
		}
		BvL = true;
		goto IL_03b5;
		IL_03b5:
		l();
	}

	private void A(Table P_0)
	{
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		if (BKf != null && BKe != null)
		{
			num = BKf.aS();
		}
		for (int i = 0; i < ((BaseCollection)((DataGridView)BVw).Columns).Count; i++)
		{
			if (P_0.HorizAxis != null && P_0.HorizAxis.G() != null)
			{
				if (BKi || BKJ)
				{
					((DataGridViewCell)((DataGridView)BVw).Columns[i].HeaderCell).Style.BackColor = ((DataGridView)BVw).BackgroundColor;
					continue;
				}
				int num2 = P_0.HorizAxis.G().m(i);
				if (BKe != null)
				{
					string text = bS.a(num2, num, -1);
					if (P_0 == BKE && BKe.HorizAxis.A(num2, text, num) == -1)
					{
						((DataGridViewCell)((DataGridView)BVw).Columns[i].HeaderCell).Style.BackColor = BM.tD;
					}
					else if (P_0 == BKe && BKE.HorizAxis.A(num2, text, num) == -1)
					{
						((DataGridViewCell)((DataGridView)BVw).Columns[i].HeaderCell).Style.BackColor = BM.tD;
					}
					else
					{
						((DataGridViewCell)((DataGridView)BVw).Columns[i].HeaderCell).Style.BackColor = A(num2, BKf);
					}
				}
				else
				{
					((DataGridViewCell)((DataGridView)BVw).Columns[i].HeaderCell).Style.BackColor = A(num2, BKf);
				}
			}
			else
			{
				((DataGridViewCell)((DataGridView)BVw).Columns[i].HeaderCell).Style.BackColor = ((DataGridView)BVw).BackgroundColor;
			}
		}
	}

	private void a(Table P_0)
	{
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		int num = P_0.VertAxisCount();
		int num2 = 0;
		if (BKG != null && BKe != null)
		{
			num2 = BKG.aS();
		}
		for (int i = 0; i < ((DataGridView)BVw).Rows.Count; i++)
		{
			if (P_0.VertAxis != null && P_0.VertAxis.G() != null)
			{
				if (BKi || BKJ)
				{
					((DataGridViewCell)((DataGridView)BVw).Rows[i].HeaderCell).Style.BackColor = ((DataGridView)BVw).BackgroundColor;
					continue;
				}
				int num3 = ((!P_0.InvertRows) ? P_0.VertAxis.G().m(i) : P_0.VertAxis.G().m(num - 1 - i));
				if (BKe != null)
				{
					string text = bS.a(num3, num2, -1);
					if (P_0 == BKE && BKe.VertAxis.A(num3, text, num2) == -1)
					{
						((DataGridViewCell)((DataGridView)BVw).Rows[i].HeaderCell).Style.BackColor = BM.tD;
					}
					else if (P_0 == BKe && BKE.VertAxis.A(num3, text, num2) == -1)
					{
						((DataGridViewCell)((DataGridView)BVw).Rows[i].HeaderCell).Style.BackColor = BM.tD;
					}
					else
					{
						((DataGridViewCell)((DataGridView)BVw).Rows[i].HeaderCell).Style.BackColor = A(num3, BKG);
					}
				}
				else
				{
					((DataGridViewCell)((DataGridView)BVw).Rows[i].HeaderCell).Style.BackColor = A(num3, BKG);
				}
			}
			else
			{
				((DataGridViewCell)((DataGridView)BVw).Rows[i].HeaderCell).Style.BackColor = ((DataGridView)BVw).BackgroundColor;
			}
		}
	}

	private void I(object P_0, EventArgs P_1)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		BP num = (((TabControl)BM.QQ.rl).SelectedTab as ae).A();
		int selectedIndex = ((TabControl)BM.QQ.rl).SelectedIndex;
		if (num == BP.ua || BM.QQ.rl.A(selectedIndex) != this)
		{
			global::A.q.A((Control)(object)this);
			BM.QQ.rl.a(false);
		}
		else
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfk(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfL(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void i(object P_0, EventArgs P_1)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		int num = By.A((IWin32Window)(object)BM.QQ, BKD);
		if (num != 0)
		{
			Setting setting = BKD.A(num);
			if (setting != null)
			{
				BM.QQ.rl.A(setting as Table, new Rectangle(((Control)this).Left, ((Control)this).Top, ((Control)this).Width, ((Control)this).Height));
				I(null, null);
			}
		}
	}

	private void J(object P_0, EventArgs P_1)
	{
		BM.QQ.rl.B((Control)(object)this);
	}

	internal override void a(object P_0, EventArgs P_1)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		if (BM.QO != BM.b.BpG && BKD.C() && BKE != null && ((SettingOrSpecialObject)BKE).l())
		{
			bB bB = new bB(BKE);
			if ((int)((Form)bB).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				h();
			}
			((Component)bB).Dispose();
		}
	}

	private void h()
	{
		HashSet<DataIdAndAttrId> idsContained = BKE.GetIdsContained();
		BKD.a(idsContained);
		BKD.A(idsContained, BKd, BM.qf);
		BKD.A(idsContained);
		BM.QQ.rL.A(false, true, false, false);
		BM.M();
		BM.QQ.rL.B(false);
		if (BM.Qn != null)
		{
			BM.QQ.rL.b(false);
		}
		f();
		E();
		UpdateLayout(resizingOnly: false);
		F();
		b();
	}

	private void j(object P_0, EventArgs P_1)
	{
		if (BKD.C() && BM.Qn == null && BKE != null)
		{
			BKE.A();
		}
	}

	private void K(object P_0, EventArgs P_1)
	{
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (!BKD.C() || BM.Qn != null || BKE == null)
		{
			return;
		}
		Table.A a = BKE.a();
		if (a != null)
		{
			if (BKE.A(a, out var text))
			{
				Ck ck = BM.aM();
				ck?.A(((Setting)BKE).A());
				BKE.A(a);
				if (((SettingOrSpecialObject)BKE).A().awo != null)
				{
					((SettingOrSpecialObject)BKE).A().awo.A(((Setting)BKE).A());
				}
				ck?.B();
				h();
				((Control)this).Invalidate();
			}
			else if (!string.IsNullOrWhiteSpace(text))
			{
				bE.A((IWin32Window)(object)BM.QQ, text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfl(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}
		else
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfM(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfl(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void k(object P_0, EventArgs P_1)
	{
		if (BKD.C() && BM.Qn == null && BKE != null)
		{
			Ck ck = BM.aM();
			ck?.A(((Setting)BKE).A());
			BKE.A(true);
			if (((SettingOrSpecialObject)BKE).A().awo != null)
			{
				((SettingOrSpecialObject)BKE).A().awo.A(((Setting)BKE).A());
			}
			ck?.B();
			h();
			((Control)this).Invalidate();
		}
	}

	private void L(object P_0, EventArgs P_1)
	{
		if (BKE == null || !((SettingOrSpecialObject)BKE).l())
		{
			return;
		}
		if (BKE.InvertRows)
		{
			if (BKe != null)
			{
				BKe.InvertRows = false;
			}
			BKE.InvertRows = false;
		}
		else
		{
			if (BKe != null)
			{
				BKe.InvertRows = true;
			}
			BKE.InvertRows = true;
		}
	}

	private void l(object P_0, EventArgs P_1)
	{
		if (BKE == null || !((SettingOrSpecialObject)BKE).l())
		{
			return;
		}
		if (BKE.SwapColumnsAndRows)
		{
			if (BKe != null)
			{
				BKe.SwapColumnsAndRows = false;
			}
			BKE.SwapColumnsAndRows = false;
		}
		else
		{
			if (BKe != null)
			{
				BKe.SwapColumnsAndRows = true;
			}
			BKE.SwapColumnsAndRows = true;
		}
	}

	private void M(object P_0, EventArgs P_1)
	{
		f();
		E();
		UpdateLayout(resizingOnly: false);
		F();
		((Control)this).Invalidate();
		BM.qe = true;
	}

	private void m(object P_0, EventArgs P_1)
	{
		f();
		E();
		UpdateLayout(resizingOnly: false);
		F();
		((Control)this).Invalidate();
		BM.qe = true;
	}

	private void N(object P_0, EventArgs P_1)
	{
		if (BKE != null)
		{
			int num = BKE.TableDataSetting.aS();
			int num2 = bS.A(num);
			if (num2 == -1)
			{
				num2 = bS.D(num);
			}
			if (num2 > 0)
			{
				bS.A(num, num2 - 1);
			}
		}
	}

	private void n(object P_0, EventArgs P_1)
	{
		if (BKE != null)
		{
			int num = BKE.TableDataSetting.aS();
			int num2 = bS.A(num);
			if (num2 == -1)
			{
				num2 = bS.D(num);
			}
			if (num2 < 4)
			{
				bS.A(num, num2 + 1);
			}
		}
	}

	private void O(object P_0, EventArgs P_1)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		Font val = new Font(((Control)this).Font.FontFamily, Bvd);
		int num = BKE.ar();
		int num2 = BKE.TableDataSetting.aS();
		string text = bS.A(num, num2, bS.A(num2), -1);
		Graphics val2 = ((Control)this).CreateGraphics();
		int width;
		try
		{
			Size val3 = TextRenderer.MeasureText((IDeviceContext)(object)val2, text, val);
			width = ((Size)(ref val3)).Width;
		}
		finally
		{
			((System.IDisposable)val2)?.Dispose();
		}
		bool flag = false;
		for (int i = 0; i < ((BaseCollection)((DataGridView)BVw).Columns).Count; i++)
		{
			if (((DataGridView)BVw).Columns[i].Width < width + 5)
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			F();
		}
		else
		{
			E(P_0, P_1);
		}
	}

	private void A(ref int P_0)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (BKE.AllCellsOnFirstColumnMustBeZero && P_0 != 0)
		{
			if (BKE.ColumnAxis != null && BKE.ColumnAxis.h() != null)
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfm() + ((SettingOrSpecialObject)BKE.ColumnAxis.h()).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfN(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			P_0 = 0;
		}
	}

	private void a(ref int P_0)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (BKE.AllCellsOnFirstRowMustBeZero && P_0 != 0)
		{
			if (BKE.RowAxis != null && BKE.RowAxis.h() != null)
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfm() + ((SettingOrSpecialObject)BKE.RowAxis.h()).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfN(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			P_0 = 0;
		}
	}

	private void A(string P_0, B P_1)
	{
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		if (BM.QO == BM.b.BpG || !BKD.C() || (BKe != null && (BKi || BKJ) && BM.QO == BM.b.BpF))
		{
			return;
		}
		try
		{
			int num = BKE.TableDataSetting.aS();
			double num2 = double.Parse(P_0, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture);
			int num3 = 0;
			if (BKE.SlicesEnabled())
			{
				num3 = BKE.UserSliceIndex;
			}
			int num4 = BKE.HorizAxisCount();
			int num5 = BKE.VertAxisCount();
			for (int i = 0; i < num5; i++)
			{
				for (int j = 0; j < num4; j++)
				{
					if (!((DataGridView)BVw).Rows[i].Cells[j].Selected)
					{
						continue;
					}
					BKE.GetColumnIndexAndRowIndex(j, i, out var columnIndex, out var rowIndex);
					int num6 = 0;
					if (BM.QO == BM.b.BpF && BKe != null)
					{
						double num7;
						double num8;
						if (BKE.InvertRows)
						{
							int currentTableRawCellValue;
							int compareTableRawCellValue;
							double cellDifferenceDisplayValue = BKE.GetCellDifferenceDisplayValue(BKe, j, num5 - 1 - i, num3, out currentTableRawCellValue, out compareTableRawCellValue);
							num7 = A(BKE, cellDifferenceDisplayValue, num2, P_1, num);
							num8 = bS.A(compareTableRawCellValue, num, -1);
						}
						else
						{
							int currentTableRawCellValue2;
							int compareTableRawCellValue2;
							double cellDifferenceDisplayValue = BKE.GetCellDifferenceDisplayValue(BKe, j, i, num3, out currentTableRawCellValue2, out compareTableRawCellValue2);
							num7 = A(BKE, cellDifferenceDisplayValue, num2, P_1, num);
							num8 = bS.A(compareTableRawCellValue2, num, -1);
						}
						num6 = bS.A(num8 + num7, num);
					}
					else
					{
						double num9 = bS.A(BKE.TableDataSetting.B(columnIndex, rowIndex, num3), num, -1);
						num6 = bS.A(A(BKE, num9, num2, P_1, num), num);
					}
					if (columnIndex == 0)
					{
						A(ref num6);
					}
					if (rowIndex == 0)
					{
						a(ref num6);
					}
					BKE.TableDataSetting.A(columnIndex, rowIndex, num3, num6, true);
					if (BvI != null)
					{
						BvI[num3, i, j].Clear();
					}
					if (BKD.awo != null)
					{
						Setting setting = BKD.awo.a(((Setting)BKE).A());
						if (setting != null && setting.ax() == rowIndex)
						{
							BKD.awo.A(((Setting)BKE).A());
						}
					}
				}
			}
		}
		catch (System.Exception)
		{
			if (BM.QO == BM.b.BpF && BKe != null)
			{
				bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcb(), (object)P_0), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			E(null, null);
		}
	}

	private double A(Table P_0, double P_1, double P_2, B P_3, int P_4)
	{
		if (P_3.baM == DC.a.baj || !BKD.C())
		{
			return P_2;
		}
		int num = P_0.aR();
		int num2 = P_0.ar();
		double num3 = bS.A(num, P_4, -1);
		double num4 = bS.A(num2, P_4, -1);
		double num5 = 0.0;
		try
		{
			if (P_3.bam)
			{
				double num6 = P_1 * (P_2 / 100.0);
				if (P_3.baM == DC.a.baK)
				{
					num5 = P_1 + num6;
				}
				else if (P_3.baM == DC.a.bak)
				{
					num5 = P_1 - num6;
				}
				else if (P_3.baM == DC.a.baL)
				{
					num5 = P_1 * num6;
				}
				else if (P_3.baM == DC.a.bal)
				{
					if (num6 == 0.0)
					{
						throw new System.Exception();
					}
					num5 = P_1 / num6;
				}
			}
			else if (P_3.baM == DC.a.baK)
			{
				num5 = P_1 + P_2;
			}
			else if (P_3.baM == DC.a.bak)
			{
				num5 = P_1 - P_2;
			}
			else if (P_3.baM == DC.a.baL)
			{
				num5 = P_1 * P_2;
			}
			else if (P_3.baM == DC.a.bal)
			{
				if (P_2 == 0.0)
				{
					throw new System.Exception();
				}
				num5 = P_1 / P_2;
			}
		}
		catch
		{
			return P_2;
		}
		return Math.Min(num4, Math.Max(num3, num5));
	}

	private void o(object P_0, EventArgs P_1)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG || !BKD.C() || !((SettingOrSpecialObject)BKE).l() || (BKe != null && (BKi || BKJ) && BM.QO == BM.b.BpF))
		{
			return;
		}
		Bs bs = new Bs();
		if ((int)((Form)bs).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
		{
			float num = bs.A();
			float num2 = 1f + num / 100f;
			int num3 = BKE.aR();
			int num4 = BKE.ar();
			int num5 = BKE.TableDataSetting.aS();
			int num6 = 0;
			if (BKE.SlicesEnabled())
			{
				num6 = BKE.UserSliceIndex;
			}
			int num7 = BKE.HorizAxisCount();
			int num8 = BKE.VertAxisCount();
			Ck ck = BM.aM();
			ck?.A(BKE.TableDataSetting.A());
			BKE.TableDataSetting.az();
			for (int i = 0; i < num8; i++)
			{
				for (int j = 0; j < num7; j++)
				{
					if (!((DataGridView)BVw).Rows[i].Cells[j].Selected)
					{
						continue;
					}
					BKE.GetColumnIndexAndRowIndex(j, i, out var columnIndex, out var rowIndex);
					int num11;
					if (BM.QO == BM.b.BpF && BKe != null)
					{
						double num9;
						double num10;
						if (BKE.InvertRows)
						{
							num9 = (double)num2 * BKE.GetCellDifferenceDisplayValue(BKe, j, num8 - 1 - i, num6, out var _, out var compareTableRawCellValue);
							num10 = bS.A(compareTableRawCellValue, num5, -1);
						}
						else
						{
							num9 = (double)num2 * BKE.GetCellDifferenceDisplayValue(BKe, j, i, num6, out var _, out var compareTableRawCellValue2);
							num10 = bS.A(compareTableRawCellValue2, num5, -1);
						}
						num11 = bS.A(num10 + num9, num5);
					}
					else
					{
						num11 = bS.A(bS.A(BKE.TableDataSetting.B(columnIndex, rowIndex, num6), num5, -1) * (double)num2, num5);
					}
					if (num3 != 0 || num4 != 0)
					{
						num11 = Math.Min(Math.Max(num11, num3), num4);
					}
					if (columnIndex == 0)
					{
						A(ref num11);
					}
					if (rowIndex == 0)
					{
						a(ref num11);
					}
					BKE.TableDataSetting.A(columnIndex, rowIndex, num6, num11, true);
					if (BvI != null)
					{
						BvI[num6, i, j].Clear();
					}
					if (BKD.awo != null)
					{
						Setting setting = BKD.awo.a(((Setting)BKE).A());
						if (setting != null && setting.ax() == rowIndex)
						{
							BKD.awo.A(((Setting)BKE).A());
						}
					}
				}
			}
			BKE.TableDataSetting.i(true);
			ck?.B();
			BM.b(BKE.TableDataSetting.A());
		}
		((Component)bs).Dispose();
	}

	private void P(object P_0, EventArgs P_1)
	{
		if (BM.QO == BM.b.BpG || !BKD.C() || !((SettingOrSpecialObject)BKE).l())
		{
			return;
		}
		Ck ck = BM.aM();
		ck?.A(BKE.TableDataSetting.A());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == bottomSelectedVert)
		{
			if (rightSelectedHoriz - leftSelectedHoriz + 1 >= 3)
			{
				BKE.TableDataSetting.az();
				BKE.LineariseLeftToRight(topSelectedVert, leftSelectedHoriz, rightSelectedHoriz, BKe, forHorizAxisInsertion: false);
				BKE.TableDataSetting.i(true);
			}
		}
		else if (leftSelectedHoriz == rightSelectedHoriz)
		{
			if (bottomSelectedVert - topSelectedVert + 1 >= 3)
			{
				BKE.TableDataSetting.az();
				BKE.LineariseTopToBottom(leftSelectedHoriz, topSelectedVert, bottomSelectedVert, BKe);
				BKE.TableDataSetting.i(true);
			}
		}
		else
		{
			BKE.TableDataSetting.az();
			BKE.LineariseRange(leftSelectedHoriz, rightSelectedHoriz, topSelectedVert, bottomSelectedVert, BKe);
			BKE.TableDataSetting.i(true);
		}
		ck?.B();
		BM.b(BKE.TableDataSetting.A());
	}

	private void p(object P_0, EventArgs P_1)
	{
		if (BM.QO == BM.b.BpG || !BKD.C() || !((SettingOrSpecialObject)BKE).l())
		{
			return;
		}
		Ck ck = BM.aM();
		ck?.A(BKE.TableDataSetting.A());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (rightSelectedHoriz - leftSelectedHoriz + 1 >= 3)
		{
			BKE.TableDataSetting.az();
			for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
			{
				BKE.LineariseLeftToRight(i, leftSelectedHoriz, rightSelectedHoriz, BKe, forHorizAxisInsertion: false);
			}
			BKE.TableDataSetting.i(true);
		}
		ck?.B();
		BM.b(BKE.TableDataSetting.A());
	}

	private void Q(object P_0, EventArgs P_1)
	{
		if (BM.QO == BM.b.BpG || !BKD.C() || !((SettingOrSpecialObject)BKE).l())
		{
			return;
		}
		Ck ck = BM.aM();
		ck?.A(BKE.TableDataSetting.A());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (bottomSelectedVert - topSelectedVert + 1 >= 3)
		{
			BKE.TableDataSetting.az();
			for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
			{
				BKE.LineariseTopToBottom(i, topSelectedVert, bottomSelectedVert, BKe);
			}
			BKE.TableDataSetting.i(true);
		}
		ck?.B();
		BM.b(BKE.TableDataSetting.A());
	}

	private ContextMenuStrip I()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Expected O, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected O, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected O, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected O, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected O, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected O, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected O, but got Unknown
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected O, but got Unknown
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		ContextMenuStrip val = new ContextMenuStrip();
		((ToolStrip)val).BackColor = BM.tG;
		((ToolStrip)val).ForeColor = BM.te;
		if ((((TabControl)BM.QQ.rl).SelectedTab as ae).A() == BP.ua)
		{
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFV();
			((ToolStripItem)val2).Click += new EventHandler(i);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
		}
		ToolStripMenuItem val3 = new ToolStripMenuItem();
		((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ms();
		val3.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MS();
		((ToolStripItem)val3).Click += new EventHandler(J);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
		((ToolStripItem)Bvl).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfn();
		((ToolStripItem)Bvl).Click += new EventHandler(I);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)Bvl);
		if (BKD.C())
		{
			ToolStripMenuItem val4 = new ToolStripMenuItem();
			((ToolStripItem)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pe();
			val4.ShortcutKeys = (Keys)114;
			((ToolStripItem)val4).Click += new EventHandler(a);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val4);
			ToolStripMenuItem val5 = new ToolStripMenuItem();
			((ToolStripItem)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfO();
			((ToolStripItem)val5).Click += new EventHandler(j);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val5);
			ToolStripMenuItem val6 = new ToolStripMenuItem();
			((ToolStripItem)val6).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfo();
			((ToolStripItem)val6).Click += new EventHandler(K);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val6);
			ToolStripMenuItem val7 = new ToolStripMenuItem();
			((ToolStripItem)val7).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfP();
			((ToolStripItem)val7).Click += new EventHandler(k);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val7);
		}
		((ToolStripItem)BvM).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfp();
		((ToolStripItem)BvM).Click += new EventHandler(L);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)BvM);
		((ToolStripItem)Bvm).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfQ();
		((ToolStripItem)Bvm).Click += new EventHandler(l);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)Bvm);
		((ToolStripItem)BvN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfq();
		((ToolStripItem)BvN).Click += new EventHandler(N);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)BvN);
		((ToolStripItem)Bvn).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfR();
		((ToolStripItem)Bvn).Click += new EventHandler(n);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)Bvn);
		if (BKD.C())
		{
			((ToolStripItem)BvO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfr();
			BvO.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.md();
			((ToolStripItem)BvO).Enabled = false;
			((ToolStripItem)BvO).Click += new EventHandler(o);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)BvO);
			((ToolStripItem)Bvo).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCy();
			Bvo.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.me();
			((ToolStripItem)Bvo).Enabled = false;
			((ToolStripItem)Bvo).Click += new EventHandler(P);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)Bvo);
			((ToolStripItem)BvP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfS();
			BvP.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bO();
			((ToolStripItem)BvP).Enabled = false;
			((ToolStripItem)BvP).Click += new EventHandler(p);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)BvP);
			((ToolStripItem)Bvp).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfs();
			Bvp.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jZ();
			((ToolStripItem)Bvp).Enabled = false;
			((ToolStripItem)Bvp).Click += new EventHandler(Q);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)Bvp);
		}
		ToolStripMenuItem val8 = new ToolStripMenuItem();
		((ToolStripItem)val8).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfT();
		val8.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mj();
		((ToolStripItem)val8).Click += new EventHandler(z);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val8);
		ToolStripMenuItem val9 = new ToolStripMenuItem();
		((ToolStripItem)val9).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bft();
		val9.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mL();
		((ToolStripItem)val9).Click += new EventHandler(y);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val9);
		if (BKE != null && ((Setting)BKE).A() == 128)
		{
			ToolStripMenuItem val10 = new ToolStripMenuItem();
			((ToolStripItem)val10).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfU();
			val10.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfu();
			((ToolStripItem)val10).Click += new EventHandler(Z);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val10);
			if (BKD.C())
			{
				ToolStripMenuItem val11 = new ToolStripMenuItem();
				((ToolStripItem)val11).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfV();
				val11.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mN();
				((ToolStripItem)val11).Click += new EventHandler(x);
				((ToolStrip)val).Items.Add((ToolStripItem)(object)val11);
				ToolStripMenuItem val12 = new ToolStripMenuItem();
				((ToolStripItem)val12).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfv();
				val12.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mO();
				((ToolStripItem)val12).Click += new EventHandler(Y);
				((ToolStrip)val).Items.Add((ToolStripItem)(object)val12);
			}
		}
		if (BKE != null && BKD.C() && ((Setting)BKE).A() == 15975)
		{
			ToolStripMenuItem val13 = new ToolStripMenuItem();
			((ToolStripItem)val13).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfV();
			val13.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mN();
			((ToolStripItem)val13).Click += new EventHandler(X);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val13);
		}
		if (BKE != null && BKD.C() && (((Setting)BKE).A() == 6447 || ((Setting)BKE).A() == 8279 || ((Setting)BKE).A() == 6437))
		{
			ToolStripMenuItem val14 = new ToolStripMenuItem();
			((ToolStripItem)val14).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfW();
			val14.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mN();
			((ToolStripItem)val14).Click += new EventHandler(w);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val14);
			if (BKD.awo != null && !BKE.SwapColumnsAndRows)
			{
				Setting setting = BKD.awo.a(((Setting)BKE).A());
				Setting setting2 = BKD.awo.B(((Setting)BKE).A());
				Setting setting3 = BKD.awo.b(((Setting)BKE).A());
				if (setting != null && setting2 != null && setting3 != null)
				{
					((ToolStripItem)BvQ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfw();
					BvQ.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ce();
					((ToolStripItem)BvQ).Click += new EventHandler(V);
					((ToolStrip)val).Items.Add((ToolStripItem)(object)BvQ);
					((ToolStripItem)Bvq).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfX();
					((ToolStripItem)Bvq).Click += new EventHandler(v);
					((ToolStrip)val).Items.Add((ToolStripItem)(object)Bvq);
				}
			}
		}
		((ToolStripDropDown)val).Opening += new CancelEventHandler(A);
		return val;
	}

	private void A(object P_0, CancelEventArgs P_1)
	{
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		((ToolStripItem)Bvl).Enabled = !BM.QQ.rl.a((Control)(object)this);
		if (BKE == null)
		{
			return;
		}
		if (BKE.HorizVertIndexPerUserSelectedCell.Count != 0)
		{
			BKE.HorizAxisCount();
			int num = BKE.VertAxisCount();
			((ToolStripItem)BvO).Enabled = BKD.C();
			((ToolStripItem)Bvo).Enabled = BKD.C();
			((ToolStripItem)BvP).Enabled = BKD.C();
			((ToolStripItem)Bvp).Enabled = BKD.C();
			if (BKD.awo != null && BKD.C() && !BKE.SwapColumnsAndRows)
			{
				Setting setting = BKD.awo.a(((Setting)BKE).A());
				Setting setting2 = BKD.awo.B(((Setting)BKE).A());
				Setting setting3 = BKD.awo.b(((Setting)BKE).A());
				if (setting != null && setting2 != null && setting3 != null)
				{
					((ToolStripItem)BvQ).Enabled = num != 0;
					int num2 = setting.ax();
					int num3 = setting2.ax();
					int num4 = setting3.ax();
					((ToolStripItem)Bvq).Enabled = num2 != 0 || num3 != 0 || num4 != 0;
				}
				else
				{
					((ToolStripItem)BvQ).Enabled = false;
					((ToolStripItem)Bvq).Enabled = false;
				}
			}
			else
			{
				((ToolStripItem)BvQ).Enabled = false;
				((ToolStripItem)Bvq).Enabled = false;
			}
			List<int> val = new List<int>();
			Enumerator<Point> enumerator = BKE.HorizVertIndexPerUserSelectedCell.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Point current = enumerator.Current;
					if (!val.Contains(((Point)(ref current)).Y))
					{
						val.Add(((Point)(ref current)).Y);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (((ToolStripItem)BvQ).Enabled)
			{
				((ToolStripItem)BvQ).Enabled = val.Count == 1;
			}
		}
		else
		{
			((ToolStripItem)BvO).Enabled = false;
			((ToolStripItem)Bvo).Enabled = false;
			((ToolStripItem)BvP).Enabled = false;
			((ToolStripItem)Bvp).Enabled = false;
			((ToolStripItem)BvQ).Enabled = false;
			((ToolStripItem)Bvq).Enabled = false;
		}
		((ToolStripItem)BvM).Enabled = BVw != null && ((DataGridView)BVw).RowHeadersVisible;
		((ToolStripItem)Bvm).Enabled = BVw != null && (((DataGridView)BVw).RowHeadersVisible || ((DataGridView)BVw).ColumnHeadersVisible);
		int num5 = BKE.TableDataSetting.aS();
		int num6 = bS.A(num5);
		if (num6 == -1)
		{
			num6 = bS.D(num5);
		}
		((ToolStripItem)BvN).Enabled = num6 > 0;
		((ToolStripItem)Bvn).Enabled = num6 < 4;
	}

	private List<int> i()
	{
		List<int> val = new List<int>();
		for (int i = 0; i < ((BaseCollection)((DataGridView)BVw).Rows[0].Cells).Count; i++)
		{
			bool flag = false;
			for (int j = 0; j < ((DataGridView)BVw).Rows.Count; j++)
			{
				if (((DataGridView)BVw).Rows[j].Cells[i].Selected)
				{
					flag = true;
				}
			}
			if (flag)
			{
				val.Add(i);
			}
		}
		return val;
	}

	private List<int> J()
	{
		List<int> val = new List<int>();
		for (int i = 0; i < ((DataGridView)BVw).Rows.Count; i++)
		{
			bool flag = false;
			for (int j = 0; j < ((BaseCollection)((DataGridView)BVw).Rows[i].Cells).Count; j++)
			{
				if (((DataGridView)BVw).Rows[i].Cells[j].Selected)
				{
					flag = true;
				}
			}
			if (flag)
			{
				val.Add(i);
			}
		}
		return val;
	}

	private void q(object P_0, EventArgs P_1)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Invalid comparison between Unknown and I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG || !BKD.C() || !((SettingOrSpecialObject)BKE).l() || !BKE.HorizAxisEnabled() || BKE.HorizAxis.f() == null || ((DataGridView)BVw).SelectedCells == null || ((BaseCollection)((DataGridView)BVw).SelectedCells).Count == 0)
		{
			return;
		}
		List<int> val = this.i();
		int count = val.Count;
		if (count >= BKE.HorizAxisCount())
		{
			return;
		}
		int num = val[0];
		int num2 = BKE.HorizAxis.G().m(num);
		string item = BKf.A(num2, -1).Item1;
		if (count == 1)
		{
			if ((int)bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCz(), (object)item), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				Ck ck = BM.aM();
				ck?.A(((Setting)BKE).A());
				for (int i = 0; i < count; i++)
				{
					BKE.DeleteFromHorizAxis(num);
				}
				ck?.B();
				BM.b(BKE.TableDataSetting.A());
				BM.b(BKE.HorizAxis.f().A());
				BM.b(BKE.HorizAxis.G().A());
				f();
				F();
			}
			return;
		}
		int num3 = BKE.HorizAxis.G().m(num + count - 1);
		string item2 = BKf.A(num3, -1).Item1;
		if ((int)bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcA(), (object)item, (object)item2), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
		{
			Ck ck2 = BM.aM();
			ck2?.A(((Setting)BKE).A());
			for (int j = 0; j < count; j++)
			{
				BKE.DeleteFromHorizAxis(num);
			}
			ck2?.B();
			BM.b(BKE.TableDataSetting.A());
			BM.b(BKE.HorizAxis.f().A());
			BM.b(BKE.HorizAxis.G().A());
			f();
			UpdateLayout(resizingOnly: false);
			F();
		}
	}

	private void R(object P_0, EventArgs P_1)
	{
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Invalid comparison between Unknown and I4
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG || !BKD.C() || !((SettingOrSpecialObject)BKE).l() || !BKE.VertAxisEnabled() || BKE.VertAxis.f() == null || ((DataGridView)BVw).SelectedCells == null || ((BaseCollection)((DataGridView)BVw).SelectedCells).Count == 0)
		{
			return;
		}
		List<int> val = J();
		int count = val.Count;
		if (count >= BKE.VertAxisCount())
		{
			return;
		}
		int num = val[0];
		int num2 = ((!BKE.InvertRows) ? BKE.VertAxis.G().m(num) : BKE.VertAxis.G().m(BKE.VertAxisCount() - 1 - num));
		string item = BKG.A(num2, -1).Item1;
		if (count == 1)
		{
			if ((int)bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfx(), (object)item), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) != 6)
			{
				return;
			}
			Ck ck = BM.aM();
			ck?.A(((Setting)BKE).A());
			for (int i = 0; i < count; i++)
			{
				if (BKE.InvertRows)
				{
					BKE.DeleteFromVertAxis(BKE.VertAxisCount() - 1 - num);
				}
				else
				{
					BKE.DeleteFromVertAxis(num);
				}
			}
			ck?.B();
			BM.b(BKE.TableDataSetting.A());
			BM.b(BKE.VertAxis.f().A());
			BM.b(BKE.VertAxis.G().A());
			f();
			F();
			return;
		}
		int num3 = ((!BKE.InvertRows) ? BKE.VertAxis.G().m(num + count - 1) : BKE.VertAxis.G().m(BKE.VertAxisCount() - 1 - (num + count - 1)));
		string item2 = BKG.A(num3, -1).Item1;
		if ((int)bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfY(), (object)item, (object)item2), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) != 6)
		{
			return;
		}
		Ck ck2 = BM.aM();
		ck2?.A(((Setting)BKE).A());
		for (int j = 0; j < count; j++)
		{
			if (BKE.InvertRows)
			{
				BKE.DeleteFromVertAxis(BKE.VertAxisCount() - 1 - num);
			}
			else
			{
				BKE.DeleteFromVertAxis(num);
			}
		}
		ck2?.B();
		BM.b(BKE.TableDataSetting.A());
		BM.b(BKE.VertAxis.f().A());
		BM.b(BKE.VertAxis.G().A());
		f();
		UpdateLayout(resizingOnly: false);
		F();
	}

	private void r(object P_0, EventArgs P_1)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Invalid comparison between Unknown and I4
		if (BM.QO != BM.b.BpG && BKD.C() && ((SettingOrSpecialObject)BKE).l() && BKE.SlicesEnabled() && BKE.SliceAxis.f() != null && BKE.SliceCount() > 1)
		{
			int num = BKE.SliceAxis.G().m(BKE.UserSliceIndex);
			string item = BKg.A(num, -1).Item1;
			if ((int)bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfy(), (object)item), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				Ck ck = BM.aM();
				ck?.A(((Setting)BKE).A());
				BKE.DeleteSlice(BKE.UserSliceIndex);
				ck?.B();
				BM.b(BKE.TableDataSetting.A());
				BM.b(BKE.SliceAxis.f().A());
				BM.b(BKE.SliceAxis.G().A());
				f();
				UpdateLayout(resizingOnly: false);
				F();
			}
		}
	}

	private void S(object P_0, EventArgs P_1)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG || !BKD.C() || !BKE.HorizAxisEnabled() || BKE.HorizAxis.f() == null || BKE.HorizAxisCount() <= 1)
		{
			return;
		}
		int num = (int)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		if (num != -1)
		{
			int num2 = BKE.HorizAxis.G().m(num);
			string item = BKf.A(num2, -1).Item1;
			if ((int)bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCz(), (object)item), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				Ck ck = BM.aM();
				ck?.A(((Setting)BKE).A());
				BKE.DeleteFromHorizAxis(num);
				ck?.B();
				BM.b(BKE.TableDataSetting.A());
				BM.b(BKE.HorizAxis.f().A());
				BM.b(BKE.HorizAxis.G().A());
				f();
				UpdateLayout(resizingOnly: false);
				F();
			}
		}
	}

	private void s(object P_0, EventArgs P_1)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG || !BKD.C() || !BKE.VertAxisEnabled() || BKE.VertAxis.f() == null || BKE.VertAxisCount() <= 1)
		{
			return;
		}
		int num = (int)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		if (num == -1)
		{
			return;
		}
		int num2 = ((!BKE.InvertRows) ? BKE.VertAxis.G().m(num) : BKE.VertAxis.G().m(BKE.VertAxisCount() - 1 - num));
		string item = BKG.A(num2, -1).Item1;
		if ((int)bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfx(), (object)item), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
		{
			Ck ck = BM.aM();
			ck?.A(((Setting)BKE).A());
			if (BKE.InvertRows)
			{
				BKE.DeleteFromVertAxis(BKE.VertAxisCount() - 1 - num);
			}
			else
			{
				BKE.DeleteFromVertAxis(num);
			}
			ck?.B();
			BM.b(BKE.TableDataSetting.A());
			BM.b(BKE.VertAxis.f().A());
			BM.b(BKE.VertAxis.G().A());
			f();
			UpdateLayout(resizingOnly: false);
			F();
		}
	}

	private void T(object P_0, EventArgs P_1)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Invalid comparison between Unknown and I4
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		if (BM.QO == BM.b.BpG || !BKD.C() || !((SettingOrSpecialObject)BKE).l() || !BKE.HorizAxisEnabled() || BKE.HorizAxis.f() == null)
		{
			return;
		}
		if (BKE.HorizAxisCount() == BKE.HorizAxis.f().ar())
		{
			bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bca(), (object)BKE.HorizAxisCount()), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		int num = BKf.aS();
		int num2 = BKf.@as();
		int num3 = -1;
		if (P_0 != null)
		{
			num3 = (int)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		}
		string text = string.Empty;
		if (num3 != -1 && BKE.HorizAxisCount() > 1)
		{
			int num4;
			int num5;
			if (num3 < BKE.HorizAxisCount() - 1)
			{
				num4 = BKE.HorizAxis.G().m(num3);
				num5 = BKE.HorizAxis.G().m(num3 + 1);
			}
			else
			{
				num4 = BKE.HorizAxis.G().m(num3 - 1);
				num5 = BKE.HorizAxis.G().m(num3);
			}
			List<Setting.ListItems.A> val = BKf.d(0);
			bool flag = false;
			for (int i = 0; i < val.Count; i++)
			{
				if (val[i].bBv == num4 || val[i].bBv == num5)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				text = bS.a((num4 + num5) / 2, num, -1);
			}
		}
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		BKf.A(ref num6, ref num7, ref num8, ref num9);
		BG bG = new BG(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCx(), (Keys)0, text, num, num2, num6, num7, num8, num9, BKf.d(0));
		if ((int)((Form)bG).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
		{
			int num10 = ((bG.a() == null) ? bS.A(bG.A(), num) : bG.B());
			if (BKE.ValueExistsOnHorizAxis(num10))
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfZ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else
			{
				Ck ck = BM.aM();
				ck?.A(((Setting)BKE).A());
				BKE.InsertIntoHorizAxis(num10);
				ck?.B();
				BM.b(BKE.TableDataSetting.A());
				BM.b(BKE.HorizAxis.f().A());
				BM.b(BKE.HorizAxis.G().A());
				f();
				UpdateLayout(resizingOnly: false);
				F();
			}
		}
		((Component)bG).Dispose();
	}

	private void t(object P_0, EventArgs P_1)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Invalid comparison between Unknown and I4
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		if (BM.QO == BM.b.BpG || !BKD.C() || !((SettingOrSpecialObject)BKE).l() || !BKE.VertAxisEnabled() || BKE.VertAxis.f() == null)
		{
			return;
		}
		if (BKE.VertAxisCount() == BKE.VertAxis.f().ar())
		{
			bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfz(), (object)BKE.VertAxisCount()), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		int num = BKG.aS();
		int num2 = BKG.@as();
		int num3 = -1;
		if (P_0 != null)
		{
			num3 = (int)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		}
		string text = string.Empty;
		if (num3 != -1 && BKE.VertAxisCount() > 1)
		{
			int num4;
			int num5;
			if (num3 < BKE.VertAxisCount() - 1)
			{
				if (BKE.InvertRows)
				{
					num4 = BKE.VertAxis.G().m(BKE.VertAxisCount() - 1 - num3);
					num5 = BKE.VertAxis.G().m(BKE.VertAxisCount() - 1 - (num3 + 1));
				}
				else
				{
					num4 = BKE.VertAxis.G().m(num3);
					num5 = BKE.VertAxis.G().m(num3 + 1);
				}
			}
			else if (BKE.InvertRows)
			{
				num4 = BKE.VertAxis.G().m(BKE.VertAxisCount() - 1 - (num3 - 1));
				num5 = BKE.VertAxis.G().m(BKE.VertAxisCount() - 1 - num3);
			}
			else
			{
				num4 = BKE.VertAxis.G().m(num3 - 1);
				num5 = BKE.VertAxis.G().m(num3);
			}
			List<Setting.ListItems.A> val = BKG.d(0);
			bool flag = false;
			for (int i = 0; i < val.Count; i++)
			{
				if (val[i].bBv == num4 || val[i].bBv == num5)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				text = bS.a((num4 + num5) / 2, num, -1);
			}
		}
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		BKG.A(ref num6, ref num7, ref num8, ref num9);
		BG bG = new BG(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGA(), (Keys)0, text, num, num2, num6, num7, num8, num9, BKG.d(0));
		if ((int)((Form)bG).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
		{
			int num10 = ((bG.a() == null) ? bS.A(bG.A(), num) : bG.B());
			if (BKE.ValueExistsOnVertAxis(num10))
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfZ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else
			{
				Ck ck = BM.aM();
				ck?.A(((Setting)BKE).A());
				BKE.InsertIntoVertAxis(num10);
				ck?.B();
				BM.b(BKE.TableDataSetting.A());
				BM.b(BKE.VertAxis.f().A());
				BM.b(BKE.VertAxis.G().A());
				f();
				UpdateLayout(resizingOnly: false);
				F();
			}
		}
		((Component)bG).Dispose();
	}

	private void U(object P_0, EventArgs P_1)
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Invalid comparison between Unknown and I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		if (BM.QO == BM.b.BpG || !BKD.C() || !((SettingOrSpecialObject)BKE).l() || !BKE.SlicesEnabled() || BKE.SliceAxis.f() == null)
		{
			return;
		}
		if (BKE.SliceCount() == BKE.SliceAxis.f().ar())
		{
			bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGa(), (object)BKE.SliceCount()), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		int num = BKg.aS();
		int num2 = BKg.@as();
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		BKg.A(ref num3, ref num4, ref num5, ref num6);
		BG bG = new BG(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGB(), (Keys)0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay(), num, num2, num3, num4, num5, num6, BKg.d(0));
		if ((int)((Form)bG).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
		{
			int num7 = ((bG.a() == null) ? bS.A(bG.A(), num) : bG.B());
			if (BKE.ValueExistsOnSliceAxis(num7))
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfZ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else
			{
				Ck ck = BM.aM();
				ck?.A(((Setting)BKE).A());
				BKE.InsertSlice(num7);
				ck?.B();
				BM.b(BKE.TableDataSetting.A());
				BM.b(BKE.SliceAxis.f().A());
				BM.b(BKE.SliceAxis.G().A());
				f();
				UpdateLayout(resizingOnly: false);
				F();
			}
		}
		((Component)bG).Dispose();
	}

	private void j()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG || !BKD.C())
		{
			return;
		}
		BA bA = new BA(BKE, false);
		if ((int)((Form)bA).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
		{
			if (bA.A() == az.Mj)
			{
				T(null, null);
			}
			else if (bA.A() == az.MK)
			{
				t(null, null);
			}
			else if (bA.A() == az.Mk)
			{
				U(null, null);
			}
		}
		((Component)bA).Dispose();
	}

	private void K()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG || !BKD.C())
		{
			return;
		}
		BA bA = new BA(BKE, true);
		if ((int)((Form)bA).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
		{
			if (bA.A() == az.Mj)
			{
				q(null, null);
			}
			else if (bA.A() == az.MK)
			{
				R(null, null);
			}
			else if (bA.A() == az.Mk)
			{
				r(null, null);
			}
		}
		((Component)bA).Dispose();
	}

	private ContextMenuStrip a(int P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Expected O, but got Unknown
		ContextMenuStrip val = new ContextMenuStrip
		{
			Tag = P_0,
			BackColor = BM.tG,
			ForeColor = BM.te
		};
		if (P_0 == 0)
		{
			BvR.Clear();
			Bvr.Clear();
		}
		ToolStripMenuItem val2 = new ToolStripMenuItem();
		((ToolStripItem)val2).Tag = P_0;
		((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCx();
		((ToolStripItem)val2).Click += new EventHandler(T);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
		BvR.Add(val2);
		ToolStripMenuItem val3 = new ToolStripMenuItem();
		((ToolStripItem)val3).Tag = P_0;
		((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGb();
		((ToolStripItem)val3).Click += new EventHandler(S);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
		Bvr.Add(val3);
		((ToolStripDropDown)val).Opening += new CancelEventHandler(a);
		return val;
	}

	private void a(object P_0, CancelEventArgs P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<ToolStripMenuItem> enumerator = Bvr.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				((ToolStripItem)enumerator.Current).Enabled = BKE != null && BKD.C() && BKE.HorizAxisCount() > 1;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private ContextMenuStrip B(int P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		ContextMenuStrip val = new ContextMenuStrip();
		((Control)val).Tag = P_0;
		((ToolStrip)val).BackColor = BM.tG;
		((ToolStrip)val).ForeColor = BM.te;
		if (P_0 == 0)
		{
			BvS.Clear();
			Bvs.Clear();
			BvT.Clear();
			Bvt.Clear();
		}
		ToolStripMenuItem val2 = new ToolStripMenuItem();
		((ToolStripItem)val2).Tag = P_0;
		((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGA();
		((ToolStripItem)val2).Click += new EventHandler(t);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
		BvS.Add(val2);
		ToolStripMenuItem val3 = new ToolStripMenuItem();
		((ToolStripItem)val3).Tag = P_0;
		((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGC();
		((ToolStripItem)val3).Click += new EventHandler(s);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
		Bvs.Add(val3);
		if (BKE != null && BKD.awo != null && !BKE.SwapColumnsAndRows)
		{
			Setting setting = BKD.awo.a(((Setting)BKE).A());
			Setting setting2 = BKD.awo.B(((Setting)BKE).A());
			Setting setting3 = BKD.awo.b(((Setting)BKE).A());
			if (setting != null && setting2 != null && setting3 != null)
			{
				ToolStripMenuItem val4 = new ToolStripMenuItem();
				((ToolStripItem)val4).Tag = P_0;
				((ToolStripItem)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGc();
				((ToolStripItem)val4).Click += new EventHandler(u);
				((ToolStrip)val).Items.Add((ToolStripItem)(object)val4);
				BvT.Add(val4);
				ToolStripMenuItem val5 = new ToolStripMenuItem();
				((ToolStripItem)val5).Tag = P_0;
				((ToolStripItem)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGD();
				((ToolStripItem)val5).Click += new EventHandler(v);
				((ToolStrip)val).Items.Add((ToolStripItem)(object)val5);
				Bvt.Add(val5);
			}
		}
		((ToolStripDropDown)val).Opening += new CancelEventHandler(B);
		return val;
	}

	private void B(object P_0, CancelEventArgs P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<ToolStripMenuItem> enumerator = Bvs.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				((ToolStripItem)enumerator.Current).Enabled = BKE != null && BKD.C() && BKE.VertAxisCount() > 1;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (BKE == null || BKD.awo == null || BKE.SwapColumnsAndRows)
		{
			return;
		}
		Setting setting = BKD.awo.a(((Setting)BKE).A());
		Setting setting2 = BKD.awo.B(((Setting)BKE).A());
		Setting setting3 = BKD.awo.b(((Setting)BKE).A());
		if (setting == null || setting2 == null || setting3 == null)
		{
			return;
		}
		int num = (int)((Control)((P_0 is ContextMenuStrip) ? P_0 : null)).Tag;
		if (num == -1)
		{
			return;
		}
		int num2 = setting.ax();
		int num3 = setting2.ax();
		int num4 = setting3.ax();
		if (num2 != 0 || num3 != 0 || num4 != 0)
		{
			if (BKE.InvertRows)
			{
				((ToolStripItem)Bvt[num]).Enabled = num == BKE.VertAxisCount() - 1 - num2;
			}
			else
			{
				((ToolStripItem)Bvt[num]).Enabled = num == num2;
			}
		}
		else
		{
			((ToolStripItem)Bvt[num]).Enabled = false;
		}
	}

	private void u(object P_0, EventArgs P_1)
	{
		if (BKE == null || BKD.awo == null || BKE.SwapColumnsAndRows)
		{
			return;
		}
		int num = (int)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		if (num == -1)
		{
			return;
		}
		Setting setting = BKD.awo.a(((Setting)BKE).A());
		Setting setting2 = BKD.awo.B(((Setting)BKE).A());
		Setting setting3 = BKD.awo.b(((Setting)BKE).A());
		if (setting != null && setting2 != null && setting3 != null)
		{
			Ck ck = BM.aM();
			ck?.A(BKE.TableDataSetting.A());
			setting2.a(0, true);
			setting3.a(BKE.HorizAxisCount() - 1, true);
			if (BKE.InvertRows)
			{
				setting.a(BKE.VertAxisCount() - 1 - num, true);
			}
			else
			{
				setting.a(num, true);
			}
			ck?.B();
		}
	}

	private void V(object P_0, EventArgs P_1)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		if (!((ToolStripItem)BvQ).Enabled || BKD.awo == null || !BKD.C() || BKE == null || BKE.HorizVertIndexPerUserSelectedCell.Count == 0 || BKE.SwapColumnsAndRows)
		{
			return;
		}
		Setting setting = BKD.awo.a(((Setting)BKE).A());
		Setting setting2 = BKD.awo.B(((Setting)BKE).A());
		Setting setting3 = BKD.awo.b(((Setting)BKE).A());
		if (setting == null || setting2 == null || setting3 == null)
		{
			return;
		}
		List<int> val = new List<int>();
		int num = 2147483647;
		int num2 = -2147483648;
		Enumerator<Point> enumerator = BKE.HorizVertIndexPerUserSelectedCell.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Point current = enumerator.Current;
				if (!val.Contains(((Point)(ref current)).Y))
				{
					val.Add(((Point)(ref current)).Y);
				}
				num = Math.Min(num, ((Point)(ref current)).X);
				num2 = Math.Max(num2, ((Point)(ref current)).X);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (val.Count == 1)
		{
			Ck ck = BM.aM();
			ck?.A(BKE.TableDataSetting.A());
			setting2.a(num, true);
			setting3.a(num2, true);
			if (BKE.InvertRows)
			{
				setting.a(BKE.VertAxisCount() - 1 - val[0], true);
			}
			else
			{
				setting.a(val[0], true);
			}
			ck?.B();
		}
	}

	private void v(object P_0, EventArgs P_1)
	{
		if (BKD.awo != null && BKE != null)
		{
			Ck ck = BM.aM();
			ck?.A(BKE.TableDataSetting.A());
			BKD.awo.A(((Setting)BKE).A());
			ck?.B();
		}
	}

	private void W(object P_0, EventArgs P_1)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		if (BKD.C())
		{
			string text = null;
			if (((Setting)BKE).A() == 128)
			{
				text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGd();
			}
			else if (((Setting)BKE).A() == 15975)
			{
				text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGE();
			}
			else if (((Setting)BKE).A() == 6447)
			{
				text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGe();
			}
			else if (((Setting)BKE).A() == 8279)
			{
				text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGF();
			}
			else if (((Setting)BKE).A() == 6437)
			{
				text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGf();
			}
			if (text != null)
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mU() + ((SettingOrSpecialObject)BKE).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGG() + text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGg(), (MessageBoxButtons)0);
			}
		}
	}

	private void w(object P_0, EventArgs P_1)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		if (BKE == null || !((SettingOrSpecialObject)BKE).l() || !BKD.C() || ((BM.QO == BM.b.BpG || BM.QO == BM.b.BpF) && BKd != null))
		{
			return;
		}
		if ((BM.qI & 0x1000) == 0)
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGH(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGh(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		if (!BM.C(6425))
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGI(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGi(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		int num = 0;
		if (((Setting)BKE).A() == 6447)
		{
			num = 6469;
		}
		else if (((Setting)BKE).A() == 8279)
		{
			num = 384;
		}
		else
		{
			if (((Setting)BKE).A() != 6437)
			{
				return;
			}
			num = 6970;
		}
		if (!BM.C(num))
		{
			switch (num)
			{
			case 6469:
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGJ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGj(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				break;
			case 384:
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGK(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGk(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				break;
			case 6970:
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGL(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGl(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				break;
			}
			return;
		}
		TableAxis tableAxis = null;
		if (BKE.HorizAxis != null && BKE.HorizAxis.g() != null && BKE.HorizAxis.G() != null && BKE.HorizAxis.g().ax() == 6425)
		{
			tableAxis = BKE.HorizAxis;
		}
		else
		{
			if (BKE.VertAxis == null || BKE.VertAxis.g() == null || BKE.VertAxis.G() == null || BKE.VertAxis.g().ax() != 6425)
			{
				return;
			}
			tableAxis = BKE.VertAxis;
		}
		if (((DataGridView)BVw).SelectedCells == null || ((BaseCollection)((DataGridView)BVw).SelectedCells).Count == 0)
		{
			return;
		}
		int num2 = -1;
		int num3 = -1;
		int num4 = -1;
		for (int i = 0; i < aC.GN.Count; i++)
		{
			num3 = -1;
			num4 = -1;
			for (int j = 0; j < aC.GN[i].Count; j++)
			{
				if (aC.GN[i][j] == 6425)
				{
					num3 = j;
				}
				else if (aC.GN[i][j] == num)
				{
					num4 = j;
				}
				if (num3 != -1 && num4 != -1)
				{
					num2 = i;
					break;
				}
			}
			if (num2 != -1)
			{
				break;
			}
		}
		if (num2 == -1)
		{
			switch (num)
			{
			case 6469:
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGM(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				break;
			case 384:
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGN(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGn(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				break;
			case 6970:
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGO(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGo(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				break;
			}
			return;
		}
		aC.a a = aC.gD[num2];
		int count = a.BLP.Count;
		int num5 = -1;
		int num6 = -1;
		for (int k = 0; k < count; k++)
		{
			int bLo = (int)a.BLP[k].BLo;
			if ((bLo >= aC.GT || aC.GT == -1) && (bLo <= aC.Gt || aC.Gt == -1))
			{
				if (num5 == -1)
				{
					num5 = k;
				}
				num6 = k;
			}
		}
		if (num5 == -1 || num6 == -1)
		{
			return;
		}
		int num7 = a.BLP[num5].BLO[num3];
		int num8 = BKE.aR();
		int num9 = BKE.ar();
		int num10 = 0;
		if (BKE.SlicesEnabled())
		{
			num10 = BKE.UserSliceIndex;
		}
		Ck ck = BM.aM();
		ck?.A(BKE.TableDataSetting.A());
		BKE.TableDataSetting.az();
		foreach (DataGridViewCell item in (BaseCollection)((DataGridView)BVw).SelectedCells)
		{
			DataGridViewCell val = item;
			BKE.GetColumnIndexAndRowIndex(val.ColumnIndex, val.RowIndex, out var columnIndex, out var rowIndex);
			int num11 = ((tableAxis.A() == AxisType.Column) ? columnIndex : rowIndex);
			int num12 = tableAxis.G().m(num11);
			int num13 = -1;
			int num14 = -1;
			for (int l = num5; l <= num6; l++)
			{
				aC.A obj = a.BLP[l];
				int num15 = obj.BLO[num3];
				int num16 = obj.BLO[num4];
				if (num15 == num12)
				{
					int num17 = Math.Max(Math.Min(num16, num9), num8);
					BKE.TableDataSetting.A(columnIndex, rowIndex, num10, num17, true);
					break;
				}
				if (num15 > num12 && (num13 != -1 || num14 != -1) && num12 >= num7)
				{
					int num18 = Math.Max(Math.Min(num14 + (num12 - num13) * (num16 - num14) / (num15 - num13), num9), num8);
					BKE.TableDataSetting.A(columnIndex, rowIndex, num10, num18, true);
					break;
				}
				num13 = num15;
				num14 = num16;
			}
			if (BKD.awo != null)
			{
				Setting setting = BKD.awo.a(((Setting)BKE).A());
				if (setting != null && setting.ax() == rowIndex)
				{
					BKD.awo.A(((Setting)BKE).A());
				}
			}
		}
		BKE.TableDataSetting.i(true);
		ck?.B();
		BM.b(BKE.TableDataSetting.A());
		F();
	}

	private void X(object P_0, EventArgs P_1)
	{
		if (BKE != null && ((SettingOrSpecialObject)BKE).l() && BKD.C() && ((BM.QO != BM.b.BpG && BM.QO != 0) || BKd == null) && ((Setting)BKE).A() == 15975 && (BM.C(15985) || (BM.A(BKD.aXc, true) && !BM.aE())))
		{
			A(true, false);
			Ck ck = BM.aM();
			ck?.A(BKE.TableDataSetting.A());
			BKE.TableDataSetting.az();
			int num = 0;
			if (BKE.SlicesEnabled())
			{
				num = BKE.UserSliceIndex;
			}
			BKE.GetColumnIndexAndRowIndex(((DataGridView)BVw).CurrentCell.ColumnIndex, ((DataGridView)BVw).CurrentCell.RowIndex, out var columnIndex, out var rowIndex);
			int num2 = BKD.A(15985).ax();
			int num3 = BKE.aR();
			int num4 = BKE.ar();
			int num5 = Math.Max(Math.Min(num2, num4), num3);
			BKE.TableDataSetting.A(columnIndex, rowIndex, num, num5, true);
			BKE.TableDataSetting.i(true);
			ck?.B();
			BM.b(BKE.TableDataSetting.A());
			F();
		}
	}

	private bool k()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		Setting setting = BKD.A(3822);
		if (setting != null && ((SettingOrSpecialObject)setting).l() && setting.ax() != 0)
		{
			DialogResult val = (DialogResult)1;
			if (!BT.A())
			{
				BT bT = new BT();
				val = ((Form)bT).ShowDialog((IWin32Window)(object)BM.QQ);
				((Component)bT).Dispose();
			}
			if ((int)val == 1)
			{
				List<Table> val2 = new List<Table>();
				if (BKD.A(3814) is Table table && ((SettingOrSpecialObject)table).l())
				{
					val2.Add(table);
				}
				if (BKD.A(4039) is Table table2 && ((SettingOrSpecialObject)table2).l())
				{
					val2.Add(table2);
				}
				InitialTaskObject.A(BKE, val2, CF.azS);
				return true;
			}
			return false;
		}
		return true;
	}

	private bool L()
	{
		Setting setting = BKD.A(6904);
		Setting setting2 = BKD.A(6929);
		Setting setting3 = BKD.A(1400);
		Setting setting4 = BKD.A(1401);
		Setting setting5 = BKD.A(1321);
		Setting setting6 = BKD.A(9281);
		Setting setting7 = BKD.A(3970);
		Setting setting8 = BKD.A(3971);
		Setting setting9 = BKD.A(15986);
		if (BM.C(8018) && BM.C(132) && (setting == null || !((SettingOrSpecialObject)setting).l() || setting2 == null || !((SettingOrSpecialObject)setting2).l() || (BM.C(6904) && BM.C(6929))) && (setting3 == null || !((SettingOrSpecialObject)setting3).l() || BM.C(1400)) && (setting4 == null || !((SettingOrSpecialObject)setting4).l() || BM.C(1401)) && (setting5 == null || !((SettingOrSpecialObject)setting5).l() || BM.C(1321)) && (setting6 == null || !((SettingOrSpecialObject)setting6).l() || BM.C(9281)) && (setting7 == null || !((SettingOrSpecialObject)setting7).l() || BM.C(3970)) && (setting8 == null || !((SettingOrSpecialObject)setting8).l() || BM.C(3971)))
		{
			if (setting9 != null && ((SettingOrSpecialObject)setting9).l())
			{
				return BM.C(15986);
			}
			return true;
		}
		return false;
	}

	private void x(object P_0, EventArgs P_1)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		if (BKE == null || !((SettingOrSpecialObject)BKE).l() || !BKD.C() || ((BM.QO == BM.b.BpG || BM.QO == BM.b.BpF) && BKd != null) || ((Setting)BKE).A() != 128 || (!L() && (!BM.A(BKD.aXc, true) || BM.aE())))
		{
			return;
		}
		Setting setting = BKD.A(8018);
		if (setting == null || !((SettingOrSpecialObject)setting).l())
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGP(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGp(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		Setting setting2 = BKD.A(6904);
		Setting setting3 = BKD.A(6929);
		int num = 0;
		if (setting2 != null && ((SettingOrSpecialObject)setting2).l() && setting3 != null && ((SettingOrSpecialObject)setting3).l())
		{
			int num2 = setting2.ax();
			string text = setting2.a(num2, 0);
			int num3 = setting3.ax();
			string text2 = setting3.a(num3, 0);
			if ((text != null || num2 < 0) && (text2 != null || num3 < 0))
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGQ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGq(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if (text != null || num2 < 0)
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGR(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGq(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if (text2 != null || num3 < 0)
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGr(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGq(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			num = (num2 + num3) / 2;
		}
		else
		{
			num = setting.ax();
			if (setting.a(num, 0) != null || num < 0)
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGS(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGq(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
		}
		Setting setting4 = BKD.A(132);
		if (setting4 == null || !((SettingOrSpecialObject)setting4).l())
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGs(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGT(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		int num4 = setting4.ax();
		if (num4 == 0)
		{
			return;
		}
		int num5 = 0;
		Setting setting5 = BKD.A(1400);
		if (setting5 != null && ((SettingOrSpecialObject)setting5).l())
		{
			num5 = setting5.ax();
		}
		int num6 = 0;
		Setting setting6 = BKD.A(1401);
		if (setting6 != null && ((SettingOrSpecialObject)setting6).l())
		{
			num6 = setting6.ax();
		}
		if (k())
		{
			Setting setting7 = BKD.A(3768);
			if (setting7 != null && ((SettingOrSpecialObject)setting7).l())
			{
				_ = setting7.ax() != 0;
			}
			else
				_ = 0;
			A(true, false);
			Ck ck = BM.aM();
			ck?.A(BKE.TableDataSetting.A());
			BKE.TableDataSetting.az();
			int num7 = 0;
			if (BKE.SlicesEnabled())
			{
				num7 = BKE.UserSliceIndex;
			}
			BKE.GetColumnIndexAndRowIndex(((DataGridView)BVw).CurrentCell.ColumnIndex, ((DataGridView)BVw).CurrentCell.RowIndex, out var columnIndex, out var rowIndex);
			int num8 = BKE.TableDataSetting.B(columnIndex, rowIndex, num7);
			int num9 = 0;
			int num10 = 0;
			if (setting5 != null && ((SettingOrSpecialObject)setting5).l())
			{
				num9 += num5;
				num10++;
			}
			if (setting6 != null && ((SettingOrSpecialObject)setting6).l())
			{
				num9 += num6;
				num10++;
			}
			if (num10 != 0)
			{
				num9 /= num10;
			}
			float num11 = (float)num / (float)num4 * (1f + (float)num9 / 1000f);
			int num12 = (int)((float)num8 * num11);
			int num13 = BKE.aR();
			int num14 = BKE.ar();
			num12 = Math.Max(Math.Min(num12, num14), num13);
			BKE.TableDataSetting.A(columnIndex, rowIndex, num7, num12, true);
			if (BvI != null)
			{
				BvI[num7, ((DataGridView)BVw).CurrentCell.RowIndex, ((DataGridView)BVw).CurrentCell.ColumnIndex].Clear();
			}
			BKE.TableDataSetting.i(true);
			ck?.B();
			BM.b(BKE.TableDataSetting.A());
			F();
		}
	}

	private void Y(object P_0, EventArgs P_1)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		if (BKE == null || !((SettingOrSpecialObject)BKE).l() || !BKD.C() || ((BM.QO == BM.b.BpG || BM.QO == BM.b.BpF) && BKd != null) || ((Setting)BKE).A() != 128 || (!L() && (!BM.A(BKD.aXc, true) || BM.aE())) || ((DataGridView)BVw).SelectedCells == null || ((BaseCollection)((DataGridView)BVw).SelectedCells).Count == 0 || BvI == null)
		{
			return;
		}
		Setting setting = BKD.A(8018);
		if (setting == null || !((SettingOrSpecialObject)setting).l())
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGP(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGp(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		Setting setting2 = BKD.A(132);
		if (setting2 == null || !((SettingOrSpecialObject)setting2).l())
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGs(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGT(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		else
		{
			if (!k())
			{
				return;
			}
			int num = 0;
			if (BKE.SlicesEnabled())
			{
				num = BKE.UserSliceIndex;
			}
			Setting setting3 = BKD.A(3768);
			if (setting3 != null && ((SettingOrSpecialObject)setting3).l() && setting3.ax() != 0)
			{
				int currentHoriz = 0;
				int currentVert = 0;
				int currentSlice = 0;
				BKE.GetOperatingPoint(ref currentHoriz, ref currentVert, ref currentSlice);
				if (!((DataGridView)BVw).SelectedCells.Contains(((DataGridView)BVw).Rows[currentVert].Cells[currentHoriz]))
				{
				}
			}
			Ck ck = BM.aM();
			ck?.A(BKE.TableDataSetting.A());
			BKE.TableDataSetting.az();
			foreach (DataGridViewCell item in (BaseCollection)((DataGridView)BVw).SelectedCells)
			{
				DataGridViewCell val = item;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int columnIndex = val.ColumnIndex;
				int rowIndex = val.RowIndex;
				if (num < ((System.Array)BvI).GetLength(0) && rowIndex < ((System.Array)BvI).GetLength(1) && columnIndex < ((System.Array)BvI).GetLength(2) && BvI[num, rowIndex, columnIndex].Count != 0)
				{
					int num6 = 0;
					long num7 = 0L;
					long num8 = 0L;
					long num9 = 0L;
					long num10 = 0L;
					Enumerator<A> enumerator2 = BvI[num, rowIndex, columnIndex].GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							A current = enumerator2.Current;
							num7 += current.baI;
							num8 += current.bah;
							num9 += current.bai;
							num10 += current.baJ;
							num6++;
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
					if (num6 != 0)
					{
						num2 = (int)(num7 / num6);
						num3 = (int)(num8 / num6);
						num4 = (int)(num9 / num6);
						num5 = (int)(num10 / num6);
					}
				}
				if (num2 != 0 && num3 != 0)
				{
					BKE.GetColumnIndexAndRowIndex(val.ColumnIndex, val.RowIndex, out var columnIndex2, out var rowIndex2);
					int num11 = BKE.TableDataSetting.B(columnIndex2, rowIndex2, num);
					int num12 = 0;
					int num13 = 0;
					Setting setting4 = BKD.A(1400);
					if (setting4 != null && ((SettingOrSpecialObject)setting4).l())
					{
						num12 += num4;
						num13++;
					}
					Setting setting5 = BKD.A(1401);
					if (setting5 != null && ((SettingOrSpecialObject)setting5).l())
					{
						num12 += num5;
						num13++;
					}
					if (num13 != 0)
					{
						num12 /= num13;
					}
					float num14 = (float)num2 / (float)num3 * (1f + (float)num12 / 1000f);
					int num15 = (int)((float)num11 * num14);
					int num16 = BKE.aR();
					int num17 = BKE.ar();
					num15 = Math.Max(Math.Min(num15, num17), num16);
					BKE.TableDataSetting.A(columnIndex2, rowIndex2, num, num15, true);
					BvI[num, rowIndex, columnIndex].Clear();
				}
			}
			BKE.TableDataSetting.i(true);
			ck?.B();
			BM.b(BKE.TableDataSetting.A());
			F();
		}
	}

	private void l()
	{
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		string bvi = string.Empty;
		if (BKE != null && ((Setting)BKE).A() == 128 && ((DataGridView)BVw).CurrentCell != null && BvI != null && ((DataGridView)BVw).SelectedCells != null && ((BaseCollection)((DataGridView)BVw).SelectedCells).Count == 1)
		{
			Setting setting = BKD.A(8018);
			Setting setting2 = BKD.A(132);
			if ((BM.QO == BM.b.Bpf || BKd == null) && setting != null && ((SettingOrSpecialObject)setting).l() && setting2 != null && ((SettingOrSpecialObject)setting2).l())
			{
				bool num = BKE.HorizAxisEnabled();
				bool flag = BKE.VertAxisEnabled();
				int num2 = 0;
				if (BKE.SlicesEnabled())
				{
					num2 = BKE.UserSliceIndex;
				}
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				if (num && BKf != null && flag && BKG != null)
				{
					int columnIndex = ((DataGridView)BVw).CurrentCell.ColumnIndex;
					int rowIndex = ((DataGridView)BVw).CurrentCell.RowIndex;
					if (num2 < ((System.Array)BvI).GetLength(0) && rowIndex < ((System.Array)BvI).GetLength(1) && columnIndex < ((System.Array)BvI).GetLength(2) && BvI[num2, rowIndex, columnIndex].Count != 0)
					{
						int num7 = 0;
						long num8 = 0L;
						long num9 = 0L;
						long num10 = 0L;
						long num11 = 0L;
						Enumerator<A> enumerator = BvI[num2, rowIndex, columnIndex].GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								A current = enumerator.Current;
								num8 += current.baI;
								num9 += current.bah;
								num10 += current.bai;
								num11 += current.baJ;
								num7++;
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
						if (num7 != 0)
						{
							num3 = (int)(num8 / num7);
							num4 = (int)(num9 / num7);
							num5 = (int)(num10 / num7);
							num6 = (int)(num11 / num7);
						}
					}
				}
				if (num3 != 0 && num4 != 0)
				{
					BKE.GetColumnIndexAndRowIndex(((DataGridView)BVw).CurrentCell.ColumnIndex, ((DataGridView)BVw).CurrentCell.RowIndex, out var columnIndex2, out var rowIndex2);
					int num12 = BKE.TableDataSetting.B(columnIndex2, rowIndex2, num2);
					int num13 = 0;
					int num14 = 0;
					Setting setting3 = BKD.A(1400);
					if (setting3 != null && ((SettingOrSpecialObject)setting3).l())
					{
						num13 += num5;
						num14++;
					}
					Setting setting4 = BKD.A(1401);
					if (setting4 != null && ((SettingOrSpecialObject)setting4).l())
					{
						num13 += num6;
						num14++;
					}
					if (num14 != 0)
					{
						num13 /= num14;
					}
					float num15 = (float)num3 / (float)num4 * (1f + (float)num13 / 1000f);
					int num16 = (int)((float)num12 * num15);
					int num17 = BKE.aR();
					int num18 = BKE.ar();
					string text = bS.a(Math.Max(Math.Min(num16, num18), num17), BKE.TableDataSetting.aS(), -1);
					int num19 = setting.aS();
					string text2 = bS.A(0, num19, false, 0);
					double num20 = bS.A(num3, num19, -1);
					double num21 = bS.A(num4, num19, -1);
					int abW = bS.a(num19, -1).abW;
					string text3 = string.Concat(new string[9]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGt(),
						text2,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGU(),
						abW.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGu(),
						abW.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGV(),
						abW.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGv()
					});
					cE<object> buffer = default(cE<object>);
					cc.a<cE<object>, object>(ref buffer, 0) = num20;
					cc.a<cE<object>, object>(ref buffer, 1) = num21;
					cc.a<cE<object>, object>(ref buffer, 2) = num21 - num20;
					cc.a<cE<object>, object>(ref buffer, 3) = 100f * num15 - 100f;
					cc.a<cE<object>, object>(ref buffer, 4) = text;
					bvi = string.Format(text3, cc.A<cE<object>, object>(in buffer, 5));
				}
			}
		}
		Bvi = bvi;
	}

	private void M()
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		if (BKE == null || ((Setting)BKE).A() != 128 || Bvf != 0)
		{
			return;
		}
		Setting setting = BKD.A(8018);
		Setting setting2 = BKD.A(132);
		if ((BM.QO != BM.b.Bpf && BKd != null) || setting == null || !((SettingOrSpecialObject)setting).l() || setting2 == null || !((SettingOrSpecialObject)setting2).l())
		{
			return;
		}
		for (int i = 0; i < ((DataGridView)BVw).RowCount; i++)
		{
			for (int j = 0; j < ((DataGridView)BVw).ColumnCount; j++)
			{
				((DataGridView)BVw).Rows[i].Cells[j].Style.BackColor = A(i, j);
			}
		}
	}

	private new Color A(int P_0, int P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		Color result = Color.DarkGray;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		bool flag = true;
		int num5 = BKE.SliceCount();
		int num6 = 0;
		if (BKE.SlicesEnabled())
		{
			num6 = BKE.UserSliceIndex;
		}
		for (int i = 0; i < num5; i++)
		{
			if (i >= ((System.Array)BvI).GetLength(0) || P_0 >= ((System.Array)BvI).GetLength(1) || P_1 >= ((System.Array)BvI).GetLength(2) || BvI[i, P_0, P_1].Count == 0)
			{
				continue;
			}
			int num7 = 0;
			long num8 = 0L;
			long num9 = 0L;
			long num10 = 0L;
			long num11 = 0L;
			Enumerator<A> enumerator = BvI[i, P_0, P_1].GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					A current = enumerator.Current;
					num8 += current.baI;
					num9 += current.bah;
					num10 += current.bai;
					num11 += current.baJ;
					num7++;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (num7 != 0)
			{
				num = (int)(num8 / num7);
				num2 = (int)(num9 / num7);
				num3 = (int)(num10 / num7);
				num4 = (int)(num11 / num7);
			}
			if (i == num6)
			{
				flag = false;
				break;
			}
		}
		if (num != 0 && num2 != 0)
		{
			int num12 = 0;
			int num13 = 0;
			Setting setting = BKD.A(1400);
			if (setting != null && ((SettingOrSpecialObject)setting).l())
			{
				num12 += num3;
				num13++;
			}
			Setting setting2 = BKD.A(1401);
			if (setting2 != null && ((SettingOrSpecialObject)setting2).l())
			{
				num12 += num4;
				num13++;
			}
			if (num13 != 0)
			{
				num12 /= num13;
			}
			float num14 = (float)num / (float)num2 * (1f + (float)num12 / 1000f);
			int num15 = (flag ? 120 : 255);
			int num16 = 0;
			int num17 = 0;
			if (num14 < 1f)
			{
				num16 = 170;
				num17 = (int)((1f - Math.Max(num14, 0.88f)) * 230f / 0.120000005f);
			}
			else if (num14 > 1f)
			{
				num16 = 0;
				num17 = (int)((Math.Min(num14, 1.12f) - 1f) * 250f / 0.120000005f);
			}
			result = global::A.l.A(num16, num17, num15);
		}
		return result;
	}

	private void y(object P_0, EventArgs P_1)
	{
		if (BM.QO == BM.b.BpG && BKd != null)
		{
			BvG = false;
		}
		else
		{
			BvG = !BvG;
		}
		f();
		if (BvG)
		{
			if (Bvf != BvF)
			{
				Bvf = BvF;
				F();
			}
			else
			{
				M();
				l();
			}
		}
		else
		{
			F();
		}
		((Control)BVw).Invalidate();
	}

	private void Z(object P_0, EventArgs P_1)
	{
		if (BKE != null && BvG)
		{
			if (Bvf == bc.zY)
			{
				Bvf = bc.zy;
			}
			else
			{
				Bvf = bc.zY;
			}
			F();
			((Control)BVw).Invalidate();
		}
	}

	private void z(object P_0, EventArgs P_1)
	{
		BvJ = !BvJ;
	}

	private void m()
	{
		switch (Bve)
		{
		case bC.zW:
			Bve = bC.zw;
			break;
		case bC.zw:
			Bve = bC.zX;
			break;
		case bC.zX:
			Bve = bC.zx;
			break;
		case bC.zx:
			Bve = bC.zW;
			break;
		}
		BM.QQ.rl.F();
	}

	private void N()
	{
		BvL = false;
		for (int i = 0; i < ((DataGridView)BVw).Rows.Count; i++)
		{
			for (int j = 0; j < ((BaseCollection)((DataGridView)BVw).Rows[i].Cells).Count; j++)
			{
				((DataGridView)BVw).Rows[i].Cells[j].Selected = ((DataGridView)BVw).CurrentCell.ColumnIndex == j && ((DataGridView)BVw).CurrentCell.RowIndex == i;
			}
		}
		BvL = true;
		H(null, null);
	}

	private void n()
	{
		A(false, true);
	}

	private void A(bool P_0, bool P_1)
	{
		if (BM.QO == BM.b.BpG)
		{
			return;
		}
		int currentHoriz = 0;
		int currentVert = 0;
		int currentSlice = 0;
		BKE.GetOperatingPoint(ref currentHoriz, ref currentVert, ref currentSlice);
		if (!P_1 || currentHoriz != BvU || currentVert != Bvu)
		{
			int leftSelectedHoriz = 2147483647;
			int rightSelectedHoriz = -2147483648;
			int topSelectedVert = 2147483647;
			int bottomSelectedVert = -2147483648;
			if (!P_0)
			{
				BKE.GetSelectedLeftRightTopBottomIndices(out leftSelectedHoriz, out rightSelectedHoriz, out topSelectedVert, out bottomSelectedVert);
			}
			int num = BKE.HorizAxisCount();
			int num2 = BKE.VertAxisCount();
			BvL = false;
			for (int i = 0; i < num2; i++)
			{
				for (int j = 0; j < num; j++)
				{
					((DataGridView)BVw).Rows[i].Cells[j].Selected = false;
				}
			}
			((DataGridView)BVw).CurrentCell = ((DataGridView)BVw).Rows[currentVert].Cells[currentHoriz];
			((DataGridView)BVw).Rows[currentVert].Cells[currentHoriz].Selected = true;
			if (!P_0)
			{
				int num3 = rightSelectedHoriz - leftSelectedHoriz + 1;
				int num4 = bottomSelectedVert - topSelectedVert + 1;
				int num5 = currentHoriz - num3 / 2;
				int num6 = currentVert - num4 / 2;
				num5 = Math.Min(Math.Max(num5, 0), ((DataGridView)BVw).ColumnCount - num3);
				num6 = Math.Min(Math.Max(num6, 0), ((DataGridView)BVw).RowCount - num4);
				for (int k = 0; k < num4; k++)
				{
					for (int l = 0; l < num3; l++)
					{
						int num7 = num5 + l;
						int num8 = num6 + k;
						((DataGridView)BVw).Rows[num8].Cells[num7].Selected = true;
					}
				}
			}
			BvL = true;
			H(null, null);
			if (P_1)
			{
				BvU = currentHoriz;
				Bvu = currentVert;
			}
		}
		if (P_1)
		{
			if (currentSlice != BvV)
			{
				BKj.BWb = currentSlice;
				BvV = currentSlice;
			}
		}
		else
		{
			BKj.BWb = currentSlice;
		}
	}

	internal bool A(KeyEventArgs P_0)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Invalid comparison between Unknown and I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Invalid comparison between Unknown and I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG)
		{
			return false;
		}
		if (!BKD.C())
		{
			return false;
		}
		if (Bvj)
		{
			return false;
		}
		if ((!P_0.Control || (int)P_0.KeyCode != 33) && (int)P_0.KeyData != 33 && (!P_0.Shift || (int)P_0.KeyCode != 33) && (!P_0.Control || (int)P_0.KeyCode != 34) && (int)P_0.KeyData != 34 && (!P_0.Shift || (int)P_0.KeyCode != 34) && (int)P_0.KeyData != 219 && (int)P_0.KeyData != 221 && (int)P_0.KeyData != 186 && (int)P_0.KeyData != 222 && (int)P_0.KeyData != 188 && (int)P_0.KeyData != 190)
		{
			return false;
		}
		if (!((SettingOrSpecialObject)BKE).l())
		{
			return true;
		}
		Ck ck = BM.aM();
		ck?.A(BKE.TableDataSetting.A());
		BKE.IncreaseOrDecreaseSelectedCellValues(P_0);
		ck?.B();
		BM.b(BKE.TableDataSetting.A());
		if (BvI != null)
		{
			int num = 0;
			if (BKE.SlicesEnabled())
			{
				num = BKE.UserSliceIndex;
			}
			Enumerator<Point> enumerator = BKE.HorizVertIndexPerUserSelectedCell.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Point current = enumerator.Current;
					if (num < ((System.Array)BvI).GetLength(0) && ((Point)(ref current)).Y < ((System.Array)BvI).GetLength(1) && ((Point)(ref current)).X < ((System.Array)BvI).GetLength(2))
					{
						BvI[num, ((Point)(ref current)).Y, ((Point)(ref current)).X].Clear();
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		return true;
	}

	internal void A(string P_0, int P_1, int P_2)
	{
		List<string> val = new List<string>();
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGW());
		int num = ((Control)this).Left - P_1;
		int num2 = ((Control)this).Top - P_2;
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBi() + BKF);
		if (BKE != null)
		{
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBJ() + BKE.InvertRows);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBj() + BKE.SwapColumnsAndRows);
		}
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
		File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
	}

	internal void A(StreamReader P_0)
	{
		string text;
		while ((text = ((TextReader)P_0).ReadLine()) != null)
		{
			if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBi()))
			{
				BKF = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBi().Length));
				if (BKD.A(BKF) != null)
				{
					((cO)this).A(BKF);
				}
			}
			else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBK()))
			{
				BKF = int.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBK()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBK().Length));
				if (BKD.A(BKF) != null)
				{
					((cO)this).A(BKF);
				}
			}
			else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBJ()))
			{
				if (BKE != null)
				{
					BKE.InvertRows = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBJ().Length));
				}
			}
			else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBj()))
			{
				if (BKE != null)
				{
					BKE.SwapColumnsAndRows = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBj().Length));
				}
			}
			else if (!text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bai()) && string.IsNullOrWhiteSpace(text))
			{
				break;
			}
		}
	}

	private void aA(object P_0, EventArgs P_1)
	{
		if (BKE != null && BKE.UserSliceIndex >= 0 && BKE.UserSliceIndex <= BKj.BWB)
		{
			BKj.BWb = BKE.UserSliceIndex;
			F();
		}
	}

	[CompilerGenerated]
	private void O()
	{
		((Control)Bvc).Visible = false;
	}

	[CompilerGenerated]
	private void o()
	{
		((Control)BvD).Visible = false;
	}
}
internal class Dc : cq, Y
{
	internal new class A : Panel
	{
		private const int bau = 55;

		private const int baV = 30;

		private const int bav = 10;

		private const int baW = 40;

		private OnOffSwitchingPoint baw;

		private int baX;

		private int bax;

		private string baY = string.Empty;

		private string bay = string.Empty;

		private o baZ = new o();

		private o baz = new o();

		private bool bBA;

		private int bBa;

		private int bBB;

		private int bBb;

		private int bBC;

		private int bBc;

		private int bBD;

		private SolidBrush bBd = new SolidBrush(BM.te);

		private Font bBE;

		private Font bBe;

		public A(OnOffSwitchingPoint P_0)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			bBE = new Font(((Control)this).Font.FontFamily, 8f);
			bBe = new Font(((Control)this).Font.FontFamily, 8f, (FontStyle)1);
			baw = P_0;
			((Control)this).AutoSize = false;
			((Control)this).Width = 450;
			((Control)this).Height = 200;
			A();
		}

		protected override void Dispose(bool disposing)
		{
			((Brush)bBd).Dispose();
			bBE.Dispose();
			bBe.Dispose();
		}

		internal void A()
		{
			Setting setting = ((SettingOrSpecialObject)baw).A().A(baw.ColumnChannelDataId);
			if (setting != null)
			{
				baX = setting.aS();
				baY = ((SettingOrSpecialObject)setting).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(setting.@as(), baX, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
			}
			Setting setting2 = ((SettingOrSpecialObject)baw).A().A(baw.RowChannelDataId);
			if (setting2 != null)
			{
				bax = setting2.aS();
				bay = ((SettingOrSpecialObject)setting2).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(setting2.@as(), bax, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
			}
			bBA = baw.UpperBoundsEnablerSetting.ax() == 0;
			bBb = baw.Point1RowUpperBoundSetting.ax();
			bBC = baw.Point2RowUpperBoundSetting.ax();
			bBc = baw.Point1RowLowerBoundSetting.ax();
			bBD = baw.Point2RowLowerBoundSetting.ax();
			int num = Math.Max(bBC, bBb);
			if (bBA)
			{
				num = Math.Max(bBD, bBc);
			}
			int num2 = Math.Min(bBc, bBD);
			if (num2 == num)
			{
				num2 -= 1000;
				num += 1000;
			}
			int num3 = (num - num2) / 5;
			baz.A((float)(num2 - num3));
			baz.a((float)(num + num3));
			baz.B((float)(((Control)this).Height - 40));
			baz.b(30f);
			baz.A(bax);
			baz.H();
			bBa = baw.Point1ColumnValueSetting.ax();
			bBB = baw.Point2ColumnValueSetting.ax();
			baZ.A(baX);
			baZ.C(25f);
			int num4 = (bBB - bBa) / 5;
			baZ.A((float)(bBa - num4));
			baZ.a((float)(bBB + num4));
			baZ.B(55f);
			baZ.b((float)(((Control)this).Width - 10));
			baZ.H();
			((Control)this).Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Expected O, but got Unknown
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ce: Expected O, but got Unknown
			//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e8: Expected O, but got Unknown
			//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0409: Expected O, but got Unknown
			//IL_041b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0422: Expected O, but got Unknown
			//IL_0535: Unknown result type (might be due to invalid IL or missing references)
			//IL_053f: Expected O, but got Unknown
			//IL_0554: Unknown result type (might be due to invalid IL or missing references)
			//IL_0559: Unknown result type (might be due to invalid IL or missing references)
			//IL_0560: Expected O, but got Unknown
			//IL_064a: Unknown result type (might be due to invalid IL or missing references)
			//IL_064f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0690: Unknown result type (might be due to invalid IL or missing references)
			//IL_0778: Unknown result type (might be due to invalid IL or missing references)
			//IL_077d: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0802: Unknown result type (might be due to invalid IL or missing references)
			//IL_0809: Expected O, but got Unknown
			//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a29: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a30: Expected O, but got Unknown
			//IL_083e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0843: Unknown result type (might be due to invalid IL or missing references)
			//IL_0925: Unknown result type (might be due to invalid IL or missing references)
			//IL_092a: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).OnPaint(e);
			Graphics graphics = e.Graphics;
			graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJk(), bBe, Brushes.Green, 220f, 10f);
			graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK(), bBe, (Brush)(object)bBd, 246f, 10f);
			graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJL(), bBe, Brushes.DarkRed, 260f, 10f);
			float num = 55f;
			float num2 = ((Control)this).Width - 10;
			float num3 = 30f;
			float num4 = ((Control)this).Height - 40;
			graphics.SmoothingMode = (SmoothingMode)2;
			SolidBrush val = new SolidBrush(Color.Green);
			try
			{
				GraphicsPath val2 = new GraphicsPath();
				val2.AddLine(num, baz.D(bBc), baZ.D(bBa), baz.D(bBc));
				val2.AddLine(baZ.D(bBa), baz.D(bBc), baZ.D(bBB), baz.D(bBD));
				val2.AddLine(baZ.D(bBB), baz.D(bBD), num2, baz.D(bBD));
				if (bBA)
				{
					val2.AddLine(num2, baz.D(bBD), num2, num3);
					val2.AddLine(num2, num3, num, num3);
					val2.AddLine(num, num3, num, baz.D(bBc));
				}
				else
				{
					val2.AddLine(num2, baz.D(bBD), num2, baz.D(bBC));
					val2.AddLine(num2, baz.D(bBC), baZ.D(bBB), baz.D(bBC));
					val2.AddLine(baZ.D(bBB), baz.D(bBC), baZ.D(bBa), baz.D(bBb));
					val2.AddLine(baZ.D(bBa), baz.D(bBb), num, baz.D(bBb));
				}
				graphics.FillRegion((Brush)(object)val, new Region(val2));
				val2.Dispose();
				val.Color = Color.DarkRed;
				val2 = new GraphicsPath();
				val2.AddLine(num, baz.D(bBc), baZ.D(bBa), baz.D(bBc));
				val2.AddLine(baZ.D(bBa), baz.D(bBc), baZ.D(bBB), baz.D(bBD));
				val2.AddLine(baZ.D(bBB), baz.D(bBD), num2, baz.D(bBD));
				val2.AddLine(num2, baz.D(bBD), num2, num4);
				val2.AddLine(num2, num4, num, num4);
				val2.AddLine(num, num4, num, baz.D(bBc));
				graphics.FillRegion((Brush)(object)val, new Region(val2));
				val2.Dispose();
				if (!bBA)
				{
					val2 = new GraphicsPath();
					val2.AddLine(num, baz.D(bBb), baZ.D(bBa), baz.D(bBb));
					val2.AddLine(baZ.D(bBa), baz.D(bBb), baZ.D(bBB), baz.D(bBC));
					val2.AddLine(baZ.D(bBB), baz.D(bBC), num2, baz.D(bBC));
					val2.AddLine(num2, baz.D(bBC), num2, num3);
					val2.AddLine(num2, num3, num, num3);
					val2.AddLine(num, num3, num, baz.D(bBb));
					graphics.FillRegion((Brush)(object)val, new Region(val2));
					val2.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
			Pen val3 = new Pen(Color.DarkGreen);
			try
			{
				val3.Width = 2f;
				graphics.DrawLine(val3, num, baz.D(bBc), baZ.D(bBa), baz.D(bBc));
				graphics.DrawLine(val3, baZ.D(bBa), baz.D(bBc), baZ.D(bBB), baz.D(bBD));
				graphics.DrawLine(val3, baZ.D(bBB), baz.D(bBD), num2, baz.D(bBD));
				val3.Width = 1f;
				val3.Color = Color.FromArgb(120, Color.Black);
				graphics.DrawLine(val3, num2, baz.D(bBD), num2, num4);
				if (!bBA)
				{
					val3.Width = 2f;
					val3.Color = Color.DarkGreen;
					graphics.DrawLine(val3, num, baz.D(bBb), baZ.D(bBa), baz.D(bBb));
					graphics.DrawLine(val3, baZ.D(bBa), baz.D(bBb), baZ.D(bBB), baz.D(bBC));
					graphics.DrawLine(val3, baZ.D(bBB), baz.D(bBC), num2, baz.D(bBC));
					val3.Width = 1f;
					val3.Color = Color.FromArgb(120, Color.Black);
					graphics.DrawLine(val3, num2, baz.D(bBC), num2, num3);
				}
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
			graphics.SmoothingMode = (SmoothingMode)3;
			if (baz.d())
			{
				float[] array = baz.F();
				float[] array2 = baz.e();
				graphics.DrawLine(Pens.Black, num, num3, num, num4);
				Pen val4 = new Pen(Color.FromArgb(150, Color.Black));
				try
				{
					val4.DashStyle = (DashStyle)1;
					graphics.TextRenderingHint = (TextRenderingHint)5;
					for (int i = 0; i < array2.Length; i++)
					{
						float num5 = array2[i];
						float num6 = array[i];
						SizeF val5 = graphics.MeasureString(num5.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAp()), bBE);
						graphics.DrawString(num5.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAQ()), bBE, (Brush)(object)bBd, num - ((SizeF)(ref val5)).Width - 2f, num6 - ((SizeF)(ref val5)).Height / 2f);
						graphics.DrawLine(val4, num, num6, num2, num6);
					}
				}
				finally
				{
					((System.IDisposable)val4)?.Dispose();
				}
			}
			if (baZ.d())
			{
				float[] array3 = baZ.e();
				float[] array4 = baZ.F();
				if (array4 != null && array4.Length != 0)
				{
					graphics.DrawLine(Pens.Black, baZ.b(), num4, baZ.C(), num4);
				}
				for (int j = 0; j < array3.Length; j++)
				{
					string text = array3[j].ToString();
					SizeF val6 = graphics.MeasureString(text, bBE);
					graphics.DrawString(text, bBE, (Brush)(object)bBd, array4[j] - ((SizeF)(ref val6)).Width / 2f, num4 + 3f);
					graphics.DrawLine(Pens.Black, array4[j], num4, array4[j], num4 - 2f);
				}
			}
			string text2 = baY;
			Font obj = bBe;
			SolidBrush obj2 = bBd;
			float num7 = num + (num2 - num) / 2f;
			SizeF val7 = graphics.MeasureString(baY, bBe);
			float num8 = num7 - ((SizeF)(ref val7)).Width / 2f;
			Rectangle clientRectangle = ((Control)this).ClientRectangle;
			graphics.DrawString(text2, obj, (Brush)(object)obj2, num8, (float)(((Rectangle)(ref clientRectangle)).Bottom - bBe.Height));
			A(graphics, bay, bBe, new PointF(0f, num3 + (num4 - num3) / 2f), (Brush)(object)bBd, -90f, (ContentAlignment)2);
			graphics.SmoothingMode = (SmoothingMode)2;
			Pen val8 = new Pen(Color.White);
			try
			{
				val8.Width = 2f;
				graphics.DrawEllipse(val8, baZ.D(bBa) - 3f, baz.D(bBc) - 3f, 6f, 6f);
				if (!bBA)
				{
					graphics.DrawEllipse(val8, baZ.D(bBa) - 3f, baz.D(bBb) - 3f, 6f, 6f);
				}
				graphics.DrawEllipse(val8, baZ.D(bBB) - 3f, baz.D(bBD) - 3f, 6f, 6f);
				if (!bBA)
				{
					graphics.DrawEllipse(val8, baZ.D(bBB) - 3f, baz.D(bBC) - 3f, 6f, 6f);
				}
			}
			finally
			{
				((System.IDisposable)val8)?.Dispose();
			}
		}

		private static void A(Graphics P_0, string P_1, Font P_2, PointF P_3, Brush P_4, float P_5, ContentAlignment P_6)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Invalid comparison between Unknown and I4
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Invalid comparison between Unknown and I4
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Invalid comparison between Unknown and I4
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Invalid comparison between Unknown and I4
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Invalid comparison between Unknown and I4
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Invalid comparison between Unknown and I4
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Invalid comparison between Unknown and I4
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Invalid comparison between Unknown and I4
			Matrix transform = P_0.Transform;
			SizeF val = P_0.MeasureString(P_1, P_2);
			PointF val2 = default(PointF);
			P_0.TranslateTransform(((PointF)(ref P_3)).X, ((PointF)(ref P_3)).Y);
			P_0.RotateTransform(P_5, (MatrixOrder)0);
			if ((int)P_6 == 2)
			{
				((PointF)(ref val2))._002Ector((0f - ((SizeF)(ref val)).Width) / 2f, 0f);
			}
			else if ((int)P_6 == 4)
			{
				((PointF)(ref val2))._002Ector(0f - ((SizeF)(ref val)).Width, 0f);
			}
			else if ((int)P_6 == 16)
			{
				((PointF)(ref val2))._002Ector(0f, (0f - ((SizeF)(ref val)).Height) / 2f);
			}
			else if ((int)P_6 == 32)
			{
				((PointF)(ref val2))._002Ector((0f - ((SizeF)(ref val)).Width) / 2f, (0f - ((SizeF)(ref val)).Height) / 2f);
			}
			else if ((int)P_6 == 64)
			{
				((PointF)(ref val2))._002Ector(0f - ((SizeF)(ref val)).Width, (0f - ((SizeF)(ref val)).Height) / 2f);
			}
			else if ((int)P_6 == 256)
			{
				((PointF)(ref val2))._002Ector(0f, 0f - ((SizeF)(ref val)).Height);
			}
			else if ((int)P_6 == 512)
			{
				((PointF)(ref val2))._002Ector((0f - ((SizeF)(ref val)).Width) / 2f, 0f - ((SizeF)(ref val)).Height);
			}
			else if ((int)P_6 == 1024)
			{
				((PointF)(ref val2))._002Ector(0f - ((SizeF)(ref val)).Width, 0f - ((SizeF)(ref val)).Height);
			}
			P_0.DrawString(P_1, P_2, P_4, val2);
			P_0.Transform = transform;
			transform.Dispose();
		}
	}

	private Framework BWE;

	private Framework BWe;

	private OnOffSwitchingPoint BWF;

	private Rectangle BWf;

	private bool BWG;

	private bool BWg;

	private A BWH;

	internal Dc(OnOffSwitchingPoint P_0, Framework P_1, Framework P_2, Rectangle P_3, bool P_4)
		: base(P_3, P_4, false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		BWE = P_1;
		BWe = P_2;
		BWF = P_0;
		BWH = new A(P_0);
		BWf = P_3;
		BM.QQ.B(new EventHandler(B));
		BWF.UpperBoundsEnablerSetting.A(new EventHandler(b));
		BWF.Point1ColumnValueSetting.A(new EventHandler(b));
		BWF.Point2ColumnValueSetting.A(new EventHandler(b));
		BWF.Point1RowUpperBoundSetting.A(new EventHandler(b));
		BWF.Point2RowUpperBoundSetting.A(new EventHandler(b));
		BWF.Point1RowLowerBoundSetting.A(new EventHandler(b));
		BWF.Point2RowLowerBoundSetting.A(new EventHandler(b));
	}

	protected override void Dispose(bool disposing)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		try
		{
			BM.QQ.b(new EventHandler(B));
			BWF.UpperBoundsEnablerSetting.a(new EventHandler(b));
			BWF.Point1ColumnValueSetting.a(new EventHandler(b));
			BWF.Point2ColumnValueSetting.a(new EventHandler(b));
			BWF.Point1RowUpperBoundSetting.a(new EventHandler(b));
			BWF.Point2RowUpperBoundSetting.a(new EventHandler(b));
			BWF.Point1RowLowerBoundSetting.a(new EventHandler(b));
			BWF.Point2RowLowerBoundSetting.a(new EventHandler(b));
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private void B(object P_0, EventArgs P_1)
	{
		bool flag = false;
		switch (BM.QO)
		{
		case BM.b.BpF:
			flag = BWG != BWg;
			break;
		case BM.b.Bpf:
			flag = false;
			break;
		case BM.b.BpG:
			flag = BWG != BWg;
			break;
		}
		if (flag)
		{
			while (((ArrangedElementCollection)((Control)base.B()).Controls).Count != 0)
			{
				q.A(((Control)base.B()).Controls[0]);
			}
			B();
		}
	}

	private void b(object P_0, EventArgs P_1)
	{
		BWH.A();
	}

	internal new void B()
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((Control)base.B()).SuspendLayout();
		int left = 5;
		int top = 5;
		BWG = BWE.B() && BWE.b() && BWE.A(BWF.UpperBoundsEnablerSetting.A()).J();
		BWg = BWe != null && BWe.B() && BWe.b() && BWe.A(BWF.UpperBoundsEnablerSetting.A()).J();
		if ((BM.QO != BM.b.BpG || BWe == null) ? BWG : BWg)
		{
			Label val = new Label();
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + BWF.A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO();
			((Control)val).ForeColor = BM.te;
			((Control)val).BackColor = Color.Transparent;
			((Control)val).AutoSize = true;
			((Control)val).Left = 5;
			((Control)val).Top = 5;
			((Control)base.B()).Controls.Add((Control)(object)val);
		}
		else
		{
			cu cu = new cu(BWF.UpperBoundsEnablerSetting.C(), BWE, BWe, null, false, true, false);
			((Control)cu).Left = left;
			((Control)cu).Top = top;
			((Control)base.B()).Controls.Add((Control)(object)cu);
			top = ((Control)cu).Bottom + 8;
			DE dE = new DE(BWF.Point1ColumnValueSetting.C(), BWE, BWe, null, false, false, false);
			((Control)dE).Left = left;
			((Control)dE).Top = top;
			((Control)base.B()).Controls.Add((Control)(object)dE);
			left = ((Control)dE).Right + 10;
			DE dE2 = new DE(BWF.Point2ColumnValueSetting.C(), BWE, BWe, null, false, false, false);
			((Control)dE2).Left = left;
			((Control)dE2).Top = top;
			((Control)base.B()).Controls.Add((Control)(object)dE2);
			top = ((Control)dE2).Bottom + 8;
			left = 5;
			DE dE3 = new DE(BWF.Point1RowUpperBoundSetting.C(), BWE, BWe, null, false, false, false);
			((Control)dE3).Left = left;
			((Control)dE3).Top = top;
			((Control)base.B()).Controls.Add((Control)(object)dE3);
			left = ((Control)dE3).Right + 10;
			DE dE4 = new DE(BWF.Point2RowUpperBoundSetting.C(), BWE, BWe, null, false, false, false);
			((Control)dE4).Left = left;
			((Control)dE4).Top = top;
			((Control)base.B()).Controls.Add((Control)(object)dE4);
			top = ((Control)dE4).Bottom + 8;
			left = 5;
			DE dE5 = new DE(BWF.Point1RowLowerBoundSetting.C(), BWE, BWe, null, false, false, false);
			((Control)dE5).Left = left;
			((Control)dE5).Top = top;
			((Control)base.B()).Controls.Add((Control)(object)dE5);
			left = ((Control)dE5).Right + 10;
			DE dE6 = new DE(BWF.Point2RowLowerBoundSetting.C(), BWE, BWe, null, false, false, false);
			((Control)dE6).Left = left;
			((Control)dE6).Top = top;
			((Control)base.B()).Controls.Add((Control)(object)dE6);
			top = ((Control)dE6).Bottom + 8;
			left = 5;
			((Control)BWH).Left = left;
			((Control)BWH).Top = top;
			((Control)base.B()).Controls.Add((Control)(object)BWH);
			BWH.A();
		}
		if (BWf != Rectangle.Empty)
		{
			((Control)this).Width = ((Rectangle)(ref BWf)).Width;
			((Control)this).Height = ((Rectangle)(ref BWf)).Height;
			((Control)this).Left = ((Rectangle)(ref BWf)).Left;
			((Control)this).Top = ((Rectangle)(ref BWf)).Top;
		}
		else
		{
			int num = 0;
			int num2 = 0;
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val2 = item;
				num = Math.Max(num, val2.Right + 10);
				num2 = Math.Max(num2, val2.Bottom + 10);
			}
			((Control)this).Width = num;
			((Control)this).Height = num2;
		}
		((Control)base.B()).ResumeLayout(true);
		((Control)this).ResumeLayout(true);
	}

	public Control A(DataIdAndAttrId P_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val = item;
			if ((val is DE && ((aj)(val as DE)).b().C() == P_0) || (val is cu && ((aj)(val as cu)).b().C() == P_0))
			{
				return val;
			}
		}
		return null;
	}

	public Control A()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val = item;
			if (val is DE || val is cu)
			{
				return val;
			}
		}
		return null;
	}
}
