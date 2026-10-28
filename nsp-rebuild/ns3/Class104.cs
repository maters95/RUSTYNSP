using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns1;
using ns2;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns3;

internal class Class104 : Class101
{
	public struct Struct10
	{
		internal int bah;

		internal int baI;

		internal int bai;

		internal int baJ;
	}

	internal enum Enum32
	{
		baj,
		baK,
		bak,
		baL,
		bal
	}

	private class Class63
	{
		internal Enum32 baM;

		internal bool bam;
	}

	private class Class64
	{
		internal bool baN;

		internal bool ban;

		internal Class64(bool bool_0, bool bool_1)
		{
			baN = bool_0;
			ban = bool_1;
		}
	}

	private delegate void Delegate17(object sender, EventArgs e);

	private delegate void Delegate18(object sender, EventArgs e);

	private delegate void Delegate19(object sender, EventArgs e);

	internal class Class56 : DataGridViewWithThemedScrollBars
	{
		private Class104 baO;

		private string bao = string.Empty;

		internal Class56(Class104 class104_0)
		{
			baO = class104_0;
		}

		private void method_9(Graphics graphics_0, Rectangle rectangle_0)
		{
			Rectangle rectangle_1 = new Rectangle(0, 0, Width, Height);
			bool bool_ = false;
			if (HorizontalScrollingOffset != 0 || VerticalScrollingOffset != 0)
			{
				bool_ = true;
				if (RowHeadersVisible && ColumnHeadersVisible)
				{
					rectangle_1 = new Rectangle(RowHeadersWidth, ColumnHeadersHeight, Width - RowHeadersWidth, Height - ColumnHeadersHeight);
				}
				else if (RowHeadersVisible)
				{
					rectangle_1 = new Rectangle(RowHeadersWidth, 0, Width - RowHeadersWidth, Height);
				}
				else if (ColumnHeadersVisible)
				{
					rectangle_1 = new Rectangle(0, ColumnHeadersHeight, Width, Height - ColumnHeadersHeight);
				}
			}
			int num = (ColumnHeadersVisible ? (ColumnHeadersHeight - VerticalScrollingOffset) : (-VerticalScrollingOffset));
			for (int i = 0; i < RowCount; i++)
			{
				int height = Rows[i].Height;
				int num2;
				if (RowHeadersVisible)
				{
					method_10(graphics_0, rectangle_0, i, num, height);
					num2 = RowHeadersWidth - HorizontalScrollingOffset;
				}
				else
				{
					num2 = -HorizontalScrollingOffset;
				}
				for (int j = 0; j < ColumnCount; j++)
				{
					int width = Columns[j].Width;
					if (i == 0 && ColumnHeadersVisible)
					{
						method_11(graphics_0, rectangle_0, j, num2, width);
					}
					method_12(graphics_0, rectangle_0, bool_, rectangle_1, i, j, num2, num, width, height);
					num2 += width;
				}
				num += height;
				if (i != 0)
				{
					continue;
				}
				Rectangle rect = new Rectangle(num2 + 1, 0, Width - num2, Height);
				if (rectangle_0.IntersectsWith(rect))
				{
					using SolidBrush brush = new SolidBrush(BackgroundColor);
					graphics_0.FillRectangle(brush, rect);
				}
			}
			if (RowHeadersVisible && ColumnHeadersVisible)
			{
				Rectangle rect2 = new Rectangle(0, 0, RowHeadersWidth, ColumnHeadersHeight);
				if (rectangle_0.IntersectsWith(rect2))
				{
					using (SolidBrush brush2 = new SolidBrush(BackgroundColor))
					{
						graphics_0.FillRectangle(brush2, rect2);
					}
					graphics_0.DrawRectangle(Pens.DarkGray, rect2);
				}
			}
			Rectangle rect3 = new Rectangle(0, num + 1, Width, Height - num);
			if (rectangle_0.IntersectsWith(rect3))
			{
				using (SolidBrush brush3 = new SolidBrush(BackgroundColor))
				{
					graphics_0.FillRectangle(brush3, rect3);
				}
			}
		}

		private void method_10(Graphics graphics_0, Rectangle rectangle_0, int int_0, int int_1, int int_2)
		{
			Rectangle rect = new Rectangle(0, int_1, RowHeadersWidth, int_2);
			if (!rectangle_0.IntersectsWith(rect))
			{
				return;
			}
			using StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Far;
			stringFormat.LineAlignment = StringAlignment.Center;
			using (SolidBrush brush = new SolidBrush(Rows[int_0].HeaderCell.Style.BackColor))
			{
				graphics_0.FillRectangle(brush, rect);
			}
			using (SolidBrush brush2 = new SolidBrush(RowHeadersDefaultCellStyle.ForeColor))
			{
				int num;
				Font font;
				if (Rows[int_0].HeaderCell.Tag != null)
				{
					num = (((bool)Rows[int_0].HeaderCell.Tag) ? 1 : 0);
					if (num != 0)
					{
						font = new Font(RowHeadersDefaultCellStyle.Font, FontStyle.Bold | FontStyle.Italic);
						goto IL_00d2;
					}
				}
				else
				{
					num = 0;
				}
				font = RowHeadersDefaultCellStyle.Font;
				goto IL_00d2;
				IL_00d2:
				graphics_0.DrawString(Rows[int_0].HeaderCell.Value as string, font, brush2, RowHeadersWidth - 10, int_1 + int_2 / 2 + 1, stringFormat);
				if (num != 0)
				{
					font.Dispose();
				}
			}
			graphics_0.DrawRectangle(Pens.DarkGray, rect);
		}

		private void method_11(Graphics graphics_0, Rectangle rectangle_0, int int_0, int int_1, int int_2)
		{
			Rectangle rect = new Rectangle(int_1, 0, int_2, ColumnHeadersHeight);
			if (!rectangle_0.IntersectsWith(rect))
			{
				return;
			}
			using StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Far;
			stringFormat.LineAlignment = StringAlignment.Center;
			using (SolidBrush brush = new SolidBrush(Columns[int_0].HeaderCell.Style.BackColor))
			{
				graphics_0.FillRectangle(brush, rect);
			}
			using (SolidBrush brush2 = new SolidBrush(ColumnHeadersDefaultCellStyle.ForeColor))
			{
				int num;
				Font font;
				if (Columns[int_0].HeaderCell.Tag != null)
				{
					num = (((bool)Columns[int_0].HeaderCell.Tag) ? 1 : 0);
					if (num != 0)
					{
						font = new Font(ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold | FontStyle.Italic);
						goto IL_00d2;
					}
				}
				else
				{
					num = 0;
				}
				font = ColumnHeadersDefaultCellStyle.Font;
				goto IL_00d2;
				IL_00d2:
				graphics_0.DrawString(Columns[int_0].HeaderCell.Value as string, font, brush2, int_1 + int_2 - 3, ColumnHeadersHeight / 2 + 1, stringFormat);
				if (num != 0)
				{
					font.Dispose();
				}
			}
			graphics_0.DrawRectangle(Pens.DarkGray, rect);
		}

		private void method_12(Graphics graphics_0, Rectangle rectangle_0, bool bool_2, Rectangle rectangle_1, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			Rectangle rect = new Rectangle(int_2, int_3, int_4, int_5);
			if (!rectangle_0.IntersectsWith(rect))
			{
				return;
			}
			if (bool_2)
			{
				graphics_0.SetClip(rectangle_1, CombineMode.Replace);
			}
			using (StringFormat stringFormat = new StringFormat())
			{
				stringFormat.Alignment = StringAlignment.Far;
				stringFormat.LineAlignment = StringAlignment.Center;
				bool flag = false;
				bool flag2 = false;
				if (!baO.BKi && !baO.BKJ && Rows[int_0].Cells[int_1].Tag is Class64 @class)
				{
					flag = @class.baN;
					flag2 = @class.ban;
				}
				bool flag3 = false;
				if (baO.BKD.awo != null && !baO.BKE.SwapColumnsAndRows && (Form23.enum60_0 != Form23.Enum60.BpG || baO.BKd == null) && (baO.BKE.method_64() == 6447 || baO.BKE.method_64() == 8279 || baO.BKE.method_64() == 6437))
				{
					Setting setting = baO.BKD.awo.method_2(baO.BKE.method_64());
					Setting setting2 = baO.BKD.awo.method_3(baO.BKE.method_64());
					Setting setting3 = baO.BKD.awo.method_4(baO.BKE.method_64());
					if (setting != null && setting2 != null && setting3 != null)
					{
						int num = setting.method_256();
						int num2 = setting2.method_256();
						int num3 = setting3.method_256();
						if (num != 0 || num2 != 0 || num3 != 0)
						{
							flag3 = ((!baO.BKE.InvertRows) ? (int_0 == num && int_1 >= num2 && int_1 <= num3) : (int_0 == baO.BKE.VertAxisCount() - 1 - num && int_1 >= num2 && int_1 <= num3));
						}
					}
				}
				Font font;
				if (flag2)
				{
					font = new Font(Columns[int_1].DefaultCellStyle.Font, FontStyle.Italic);
				}
				else
				{
					font = ((!flag3) ? Columns[int_1].DefaultCellStyle.Font : new Font(Columns[int_1].DefaultCellStyle.Font, FontStyle.Bold));
				}
				if (Rows[int_0].Cells[int_1].Selected)
				{
					graphics_0.FillRectangle(Brushes.DodgerBlue, rect);
				}
				else
				{
					using SolidBrush brush = new SolidBrush(Rows[int_0].Cells[int_1].Style.BackColor);
					graphics_0.FillRectangle(brush, rect);
				}
				graphics_0.DrawString(brush: (!Rows[int_0].Cells[int_1].Selected) ? Brushes.Black : Brushes.White, s: Rows[int_0].Cells[int_1].Value as string, font: font, x: int_2 + int_4 - 2, y: int_3 + int_5 / 2 + 1, format: stringFormat);
				if (flag2)
				{
					font.Dispose();
				}
				if (flag)
				{
					using Pen pen = new Pen(Form23.color_9);
					Rectangle rect2 = new Rectangle(rect.Left + 1, rect.Top + 1, rect.Width - 2, rect.Height - 2);
					graphics_0.DrawRectangle(pen, rect2);
				}
				else
				{
					graphics_0.DrawRectangle(Pens.DarkGray, rect);
				}
			}
			if (bool_2)
			{
				graphics_0.ResetClip();
			}
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs_0)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			method_9(paintEventArgs_0.Graphics, paintEventArgs_0.ClipRectangle);
			if (Form23.enum60_0 == Form23.Enum60.BpG || !baO.BKE.method_35())
			{
				return;
			}
			int num = baO.method_38();
			int num2 = baO.method_39();
			bool flag = baO.BKE.HorizAxisEnabled();
			bool flag2 = baO.BKE.VertAxisEnabled();
			int num3 = 0;
			if (flag2)
			{
				num3 = RowHeadersWidth;
			}
			int num4 = 0;
			if (flag)
			{
				num4 = ColumnHeadersHeight;
			}
			bool flag3 = Form23.smethod_28(baO.BKE.method_0().aXc, bool_53: true) && !Form23.smethod_80();
			paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			if (baO.BvG && ((flag && baO.BKf != null) & flag2) && baO.BKG != null)
			{
				if (flag3 || (Form23.smethod_84(baO.BKf.method_64()) && Form23.smethod_84(baO.BKG.method_64())))
				{
					if (baO.Bvg.Count < 90000)
					{
						Point item = new Point(num, num2);
						bool flag4 = false;
						if (baO.Bvg.Count != 0)
						{
							Point point = baO.Bvg[baO.Bvg.Count - 1];
							int x = point.X;
							int y = point.Y;
							if (num >= x - 1 && num <= x + 1 && num2 >= y - 1 && num2 <= y + 1)
							{
								flag4 = true;
							}
						}
						if (!flag4)
						{
							baO.Bvg.Add(item);
						}
					}
					method_13();
				}
				if (baO.Bvg.Count >= 2)
				{
					using Pen pen = new Pen(Color.FromArgb(100, 0, 0, 0), 2f);
					for (int i = 1; i < baO.Bvg.Count; i++)
					{
						Point point2 = baO.Bvg[i - 1];
						Point point3 = baO.Bvg[i];
						int num5 = point2.X - HorizontalScrollingOffset;
						int num6 = point2.Y - VerticalScrollingOffset;
						int num7 = point3.X - HorizontalScrollingOffset;
						int num8 = point3.Y - VerticalScrollingOffset;
						if (num5 > num3 && num7 > num3 && num6 > num4 && num8 > num4)
						{
							paintEventArgs_0.Graphics.DrawLine(pen, num5, num6, num7, num8);
						}
					}
				}
			}
			if (Bve == Enum69.const_2 || Bve == Enum69.const_3 || Bve == Enum69.const_0)
			{
				int num9 = num - HorizontalScrollingOffset;
				int num10 = num2 - VerticalScrollingOffset;
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
						flag5 = !flag || (baO.BKf != null && Form23.smethod_84(baO.BKf.method_64()));
						flag6 = !flag2 || (baO.BKG != null && Form23.smethod_84(baO.BKG.method_64()));
					}
					if (flag5 & flag6)
					{
						using Pen pen2 = new Pen(Color.FromArgb(150, 0, 0, 0), 2f);
						if (Bve == Enum69.const_2)
						{
							paintEventArgs_0.Graphics.DrawEllipse(pen2, num9 - 5, num10 - 5, 10, 10);
						}
						else if (Bve == Enum69.const_3)
						{
							paintEventArgs_0.Graphics.DrawRectangle(pen2, num9 - 24, num10 - 8, 48, 17);
						}
					}
					if (flag && baO.BKf != null && (flag3 || Form23.smethod_84(baO.BKf.method_64())))
					{
						Point[] points = new Point[3]
						{
							new Point(num9, 9),
							new Point(num9 - 6, 1),
							new Point(num9 + 5, 1)
						};
						paintEventArgs_0.Graphics.FillPolygon(Brushes.DodgerBlue, points);
					}
					if (flag2 && baO.BKG != null && (flag3 || Form23.smethod_84(baO.BKG.method_64())))
					{
						Point[] points2 = new Point[3]
						{
							new Point(9, num10),
							new Point(1, num10 - 6),
							new Point(1, num10 + 5)
						};
						paintEventArgs_0.Graphics.FillPolygon(Brushes.DodgerBlue, points2);
					}
				}
			}
			stopwatch.Stop();
			Class23.smethod_3(string.Format(Class333.BJK(), stopwatch.ElapsedMilliseconds, Left, Top), bool_1: false);
		}

		private void method_13()
		{
			if (baO.BvI == null || baO.BKE.method_64() != 128)
			{
				return;
			}
			Setting setting = baO.BKD.method_31(8018);
			Setting setting2 = baO.BKD.method_31(6904);
			Setting setting3 = baO.BKD.method_31(6929);
			Setting setting4 = baO.BKD.method_31(132);
			Setting setting5 = baO.BKD.method_31(1400);
			Setting setting6 = baO.BKD.method_31(1401);
			Setting setting7 = baO.BKD.method_31(1321);
			Setting setting8 = baO.BKD.method_31(9281);
			Setting setting9 = baO.BKD.method_31(3970);
			Setting setting10 = baO.BKD.method_31(3971);
			Setting setting11 = baO.BKD.method_31(15986);
			if (setting == null || setting4 == null || !setting.method_35() || !setting4.method_35() || (!baO.method_79() && (!Form23.smethod_28(baO.BKE.method_0().aXc, bool_53: true) || Form23.smethod_80())))
			{
				return;
			}
			bool num = setting7 != null && setting7.method_35() && setting7.method_256() != 0;
			bool flag = setting8 != null && setting8.method_35() && setting8.method_256() != 0;
			bool flag2 = (setting9 != null && setting9.method_35() && setting9.method_256() != 0) || (setting10 != null && setting10.method_35() && setting10.method_256() != 0) || (setting11 != null && setting11.method_35() && setting11.method_256() != 0);
			if (num || flag || flag2)
			{
				return;
			}
			Struct10 item = default;
			bool flag3 = true;
			if (setting2 != null && setting2.method_35() && setting3 != null && setting3.method_35())
			{
				int num2 = setting2.method_256();
				int num3 = setting3.method_256();
				if (flag3 = num2 > 0 && num3 > 0 && setting2.method_287(num2) == null && setting3.method_287(num3) == null)
				{
					item.baI = (num2 + num3) / 2;
				}
			}
			else
			{
				int num4 = setting.method_256();
				if (flag3 = num4 > 0 && setting.method_287(num4) == null)
				{
					item.baI = num4;
				}
			}
			if (flag3)
			{
				item.bah = setting4.method_256();
				if (setting5 != null && setting5.method_35())
				{
					item.bai = setting5.method_256();
				}
				else
				{
					item.bai = 0;
				}
				if (setting6 != null && setting6.method_35())
				{
					item.baJ = setting6.method_256();
				}
				else
				{
					item.baJ = 0;
				}
				int currentHoriz = 0;
				int currentVert = 0;
				int currentSlice = 0;
				baO.BKE.GetOperatingPoint(ref currentHoriz, ref currentVert, ref currentSlice);
				if (baO.BvI[currentSlice, currentVert, currentHoriz].Count == 50)
				{
					baO.BvI[currentSlice, currentVert, currentHoriz].RemoveAt(0);
				}
				baO.BvI[currentSlice, currentVert, currentHoriz].Add(item);
				if (Bvf == Enum70.const_0)
				{
					baO.BVw.Rows[currentVert].Cells[currentHoriz].Style.BackColor = baO.method_84(currentVert, currentHoriz);
				}
				if (baO.BVw.CurrentCell.ColumnIndex == currentHoriz && baO.BVw.CurrentCell.RowIndex == currentVert)
				{
					baO.method_82();
				}
			}
		}

		[SpecialName]
		internal bool method_14()
		{
			return bao != string.Empty;
		}

		private void method_15()
		{
			if (Form23.enum60_0 == Form23.Enum60.BpG || !(bao != string.Empty))
			{
				return;
			}
			int num = baO.BKE.HorizAxisCount();
			int num2 = baO.BKE.VertAxisCount();
			for (int i = 0; i < num2; i++)
			{
				for (int j = 0; j < num; j++)
				{
					if (Rows[i].Cells[j].Selected)
					{
						DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
						dataGridViewCellStyle.SelectionBackColor = Color.White;
						dataGridViewCellStyle.SelectionForeColor = Color.Black;
						Rows[i].Cells[j].Style = dataGridViewCellStyle;
						Rows[i].Cells[j].Value = bao;
					}
				}
			}
		}

		protected override void OnKeyDown(KeyEventArgs keyEventArgs_0)
		{
			if ((baO.BKE != null && !baO.BKE.method_0().method_4()) || (baO.BKe != null && (baO.BKi || baO.BKJ) && Form23.enum60_0 == Form23.Enum60.BpF))
			{
				return;
			}
			if (bao == string.Empty)
			{
				if (keyEventArgs_0.KeyData == Keys.D)
				{
					baO.method_45(null, null);
					return;
				}
				if ((keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Prior) || (keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Next) || (keyEventArgs_0.Shift && keyEventArgs_0.KeyCode == Keys.Prior) || (keyEventArgs_0.Shift && keyEventArgs_0.KeyCode == Keys.Next) || keyEventArgs_0.KeyData == Keys.Prior || keyEventArgs_0.KeyData == Keys.Next || keyEventArgs_0.KeyData == Keys.OemOpenBrackets || keyEventArgs_0.KeyData == Keys.OemCloseBrackets || keyEventArgs_0.KeyData == Keys.OemSemicolon || keyEventArgs_0.KeyData == Keys.Oem7 || keyEventArgs_0.KeyData == Keys.Oemcomma || keyEventArgs_0.KeyData == Keys.OemPeriod)
				{
					return;
				}
			}
			if (baO.BKE != null && SelectedCells != null && SelectedCells.Count != 0)
			{
				if (bao == string.Empty)
				{
					if (keyEventArgs_0.KeyData == Keys.Left)
					{
						baO.BKE.MoveSelectionLeft(baO.BKe);
					}
					else if (keyEventArgs_0.KeyData == Keys.Up)
					{
						baO.BKE.MoveSelectionUp(baO.BKe);
					}
					else if (keyEventArgs_0.KeyData == Keys.Right)
					{
						baO.BKE.MoveSelectionRight(baO.BKe);
					}
					else if (keyEventArgs_0.KeyData == Keys.Down)
					{
						baO.BKE.MoveSelectionDown(baO.BKe);
					}
					else if (keyEventArgs_0.KeyData == (Keys.Left | Keys.Shift))
					{
						baO.BKE.IncreaseSelectionSizeOnLeft(baO.BKe);
					}
					else if (keyEventArgs_0.KeyData == (Keys.Up | Keys.Shift))
					{
						baO.BKE.IncreaseSelectionSizeOnTop(baO.BKe);
					}
					else if (keyEventArgs_0.KeyData == (Keys.Right | Keys.Shift))
					{
						baO.BKE.IncreaseSelectionSizeOnRight(baO.BKe);
					}
					else if (keyEventArgs_0.KeyData == (Keys.Down | Keys.Shift))
					{
						baO.BKE.IncreaseSelectionSizeOnBottom(baO.BKe);
					}
					else if (keyEventArgs_0.KeyData == (Keys.Left | Keys.Control))
					{
						baO.BKE.DecreaseSelectionSizeOnRight();
					}
					else if (keyEventArgs_0.KeyData == (Keys.Up | Keys.Control))
					{
						baO.BKE.DecreaseSelectionSizeOnBottom();
					}
					else if (keyEventArgs_0.KeyData == (Keys.Right | Keys.Control))
					{
						baO.BKE.DecreaseSelectionSizeOnLeft();
					}
					else if (keyEventArgs_0.KeyData == (Keys.Down | Keys.Control))
					{
						baO.BKE.DecreaseSelectionSizeOnTop();
					}
					else if ((keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Space) || keyEventArgs_0.KeyData == Keys.Escape)
					{
						baO.method_89();
					}
					else if (baO.BKE.method_35() && Form23.enum60_0 != Form23.Enum60.BpG)
					{
						if (keyEventArgs_0.KeyCode >= Keys.D0 && keyEventArgs_0.KeyCode <= Keys.D9)
						{
							bao = ((int)(keyEventArgs_0.KeyCode - 48)).ToString();
							baO.Bvj = true;
						}
						else if (keyEventArgs_0.KeyCode >= Keys.NumPad0 && keyEventArgs_0.KeyCode <= Keys.NumPad9)
						{
							bao = ((int)(keyEventArgs_0.KeyCode - 96)).ToString();
							baO.Bvj = true;
						}
						else if (keyEventArgs_0.KeyCode != Keys.OemMinus && keyEventArgs_0.KeyCode != Keys.Subtract)
						{
							if (keyEventArgs_0.KeyCode == Keys.Decimal)
							{
								bao = Class333.smethod_184() + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
								baO.Bvj = true;
							}
							else if (keyEventArgs_0.KeyData == Keys.Insert)
							{
								baO.method_69();
							}
							else if (keyEventArgs_0.KeyData == Keys.Delete)
							{
								baO.method_70();
							}
							else if (keyEventArgs_0.KeyData == Keys.F3)
							{
								baO.vmethod_3(null, null);
							}
							else if (keyEventArgs_0.KeyData == Keys.P)
							{
								baO.BvO_Click(null, null);
							}
							else if (keyEventArgs_0.KeyData == Keys.L)
							{
								baO.Bvo_Click(null, null);
							}
							else if (keyEventArgs_0.KeyData == Keys.H)
							{
								baO.BvP_Click(null, null);
							}
							else if (keyEventArgs_0.KeyData == Keys.V)
							{
								baO.Bvp_Click(null, null);
							}
							else if (keyEventArgs_0.KeyData == Keys.M)
							{
								if (baO.BKE.method_64() == 6447 || baO.BKE.method_64() == 8279 || baO.BKE.method_64() == 6437)
								{
									baO.BvQ_Click(null, null);
								}
							}
							else if (keyEventArgs_0.KeyData == Keys.Q)
							{
								if (baO.BKE.method_64() == 128)
								{
									baO.method_80(null, null);
								}
								else if (baO.BKE.method_64() == 15975)
								{
									baO.method_77(null, null);
								}
								else if (baO.BKE.method_64() == 6447 || baO.BKE.method_64() == 8279 || baO.BKE.method_64() == 6437)
								{
									baO.method_76(null, null);
								}
							}
							else if (keyEventArgs_0.KeyData == Keys.R)
							{
								baO.method_81(null, null);
							}
							else if (keyEventArgs_0.KeyData == Keys.T)
							{
								baO.method_85(null, null);
							}
							else if (keyEventArgs_0.KeyData == (Keys.T | Keys.Control))
							{
								baO.method_86(null, null);
							}
							else if (keyEventArgs_0.KeyData == Keys.X)
							{
								baO.method_88();
							}
							else if (keyEventArgs_0.KeyData == Keys.F)
							{
								baO.method_87(null, null);
							}
							else if (keyEventArgs_0.KeyData == Keys.Space)
							{
								baO.method_91(bool_0: false, bool_1: false);
							}
							else if (keyEventArgs_0.KeyData == (Keys.C | Keys.Control))
							{
								baO.BKE.CopyCellValuesToClipboard(baO.BKe);
							}
							else if (keyEventArgs_0.KeyData == (Keys.V | Keys.Control))
							{
								baO.BKE.method_298(baO.BKe, baO.BvI);
							}
							else if (baO.BKe != null && (baO.BKi || baO.BKJ) && Form23.enum60_0 == Form23.Enum60.BpF)
							{
								base.OnKeyDown(keyEventArgs_0);
							}
							else if (keyEventArgs_0.KeyData == (Keys.Left | Keys.Shift | Keys.Control))
							{
								baO.BKE.method_294(baO.BKe, baO.BvI);
							}
							else if (keyEventArgs_0.KeyData == (Keys.Up | Keys.Shift | Keys.Control))
							{
								baO.BKE.method_296(baO.BKe, baO.BvI);
							}
							else if (keyEventArgs_0.KeyData == (Keys.Right | Keys.Shift | Keys.Control))
							{
								baO.BKE.method_295(baO.BKe, baO.BvI);
							}
							else if (keyEventArgs_0.KeyData == (Keys.Down | Keys.Shift | Keys.Control))
							{
								baO.BKE.method_297(baO.BKe, baO.BvI);
							}
							else
							{
								base.OnKeyDown(keyEventArgs_0);
							}
						}
						else
						{
							bao = Class333.smethod_186();
							baO.Bvj = true;
						}
					}
					else
					{
						base.OnKeyDown(keyEventArgs_0);
					}
				}
				else if (baO.BKE.method_35() && Form23.enum60_0 != Form23.Enum60.BpG)
				{
					if (keyEventArgs_0.KeyCode == Keys.Back)
					{
						if (bao.Length == 1)
						{
							method_20();
						}
						else
						{
							bao = bao.Substring(0, bao.Length - 1);
						}
					}
					else if (keyEventArgs_0.KeyCode == Keys.Escape)
					{
						method_20();
					}
					else if (keyEventArgs_0.KeyCode >= Keys.D0 && keyEventArgs_0.KeyCode <= Keys.D9 && !keyEventArgs_0.Shift)
					{
						int int_ = (int)(keyEventArgs_0.KeyCode - 48);
						if (method_18(int_))
						{
							bao += int_;
						}
					}
					else if (keyEventArgs_0.KeyCode >= Keys.NumPad0 && keyEventArgs_0.KeyCode <= Keys.NumPad9)
					{
						int int_2 = (int)(keyEventArgs_0.KeyCode - 96);
						if (method_18(int_2))
						{
							bao += int_2;
						}
					}
					else if (keyEventArgs_0.KeyCode == Keys.Decimal)
					{
						bao += CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
					}
					else if (keyEventArgs_0.KeyCode == Keys.OemPeriod)
					{
						if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == Class333.smethod_190())
						{
							bao += Class333.smethod_190();
						}
					}
					else if (keyEventArgs_0.KeyCode == Keys.Oemcomma)
					{
						if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == Class333.smethod_189())
						{
							bao += Class333.smethod_189();
						}
					}
					else if (keyEventArgs_0.KeyCode == Keys.D5 && keyEventArgs_0.Shift)
					{
						if (!bao.Contains(Class333.smethod_681()))
						{
							bao += Class333.smethod_681();
						}
					}
					else if ((keyEventArgs_0.KeyCode == Keys.Oemplus && keyEventArgs_0.Shift) || keyEventArgs_0.KeyData == Keys.Add)
					{
						if (method_17(bao))
						{
							bao += Class333.aol();
						}
					}
					else if ((keyEventArgs_0.KeyCode == Keys.OemMinus && keyEventArgs_0.Shift) || keyEventArgs_0.KeyData == Keys.Subtract)
					{
						if (method_17(bao))
						{
							bao += Class333.smethod_186();
						}
					}
					else if ((keyEventArgs_0.KeyCode == Keys.D8 && keyEventArgs_0.Shift) || keyEventArgs_0.KeyData == Keys.Multiply)
					{
						if (method_17(bao))
						{
							bao += Class333.smethod_178();
						}
					}
					else if (keyEventArgs_0.KeyData != Keys.OemQuestion && keyEventArgs_0.KeyData != Keys.Divide)
					{
						if (keyEventArgs_0.KeyCode != Keys.Return && keyEventArgs_0.KeyCode != Keys.Tab && keyEventArgs_0.KeyCode != Keys.Left && keyEventArgs_0.KeyCode != Keys.Right && keyEventArgs_0.KeyCode != Keys.Up && keyEventArgs_0.KeyCode != Keys.Down)
						{
							base.OnKeyDown(keyEventArgs_0);
						}
						else
						{
							method_16(keyEventArgs_0);
						}
					}
					else if (method_17(bao))
					{
						bao += Class333.smethod_177();
					}
				}
				else
				{
					base.OnKeyDown(keyEventArgs_0);
				}
				method_15();
			}
			else
			{
				base.OnKeyDown(keyEventArgs_0);
			}
		}

		private void method_16(KeyEventArgs keyEventArgs_0)
		{
			baO.Bvj = false;
			Class280 @class = Form23.smethod_95();
			@class?.method_2(baO.BKE.TableDataSetting.method_64());
			baO.BKE.TableDataSetting.method_268();
			int num = baO.BKE.method_228();
			int num2 = baO.BKE.method_229();
			int num3 = baO.BKE.TableDataSetting.method_231();
			bao = method_19(bao, out var class63_);
			if (class63_.baM != Enum32.baj)
			{
				baO.method_55(bao, class63_);
				bao = string.Empty;
			}
			else
			{
				try
				{
					int int_ = 0;
					if (Form23.enum60_0 != Form23.Enum60.BpF || baO.BKe == null)
					{
						int_ = Class233.smethod_26(double.Parse(bao, NumberStyles.Any, CultureInfo.CurrentCulture), num3);
						if (num != 0 || num2 != 0)
						{
							int_ = Math.Min(Math.Max(int_, num), num2);
						}
					}
					int num4 = 0;
					if (baO.BKE.SlicesEnabled())
					{
						num4 = baO.BKE.UserSliceIndex;
					}
					int num5 = baO.BKE.HorizAxisCount();
					int num6 = baO.BKE.VertAxisCount();
					for (int i = 0; i < num6; i++)
					{
						for (int j = 0; j < num5; j++)
						{
							if (Rows[i].Cells[j].Selected)
							{
								if (Form23.enum60_0 == Form23.Enum60.BpF && baO.BKe != null)
								{
									int horizRawValue = ((baO.BKE.HorizAxis != null && baO.BKE.HorizAxis.method_89() != null) ? baO.BKE.HorizAxis.method_89().method_258(j) : 0);
									int vertRawValue = ((baO.BKE.VertAxis != null && baO.BKE.VertAxis.method_89() != null) ? ((!baO.BKE.InvertRows) ? baO.BKE.VertAxis.method_89().method_258(i) : baO.BKE.VertAxis.method_89().method_258(num6 - 1 - i)) : 0);
									int sliceRawValue = ((baO.BKE.SliceAxis != null && baO.BKE.SliceAxis.method_89() != null) ? baO.BKE.SliceAxis.method_89().method_258(num4) : 0);
									double num7 = Class233.smethod_28(baO.BKe.GetInterpolatedTableDataRawValue(horizRawValue, vertRawValue, sliceRawValue), num3);
									double num8 = double.Parse(bao, NumberStyles.Any, CultureInfo.CurrentCulture);
									int_ = Class233.smethod_26(num7 + num8, num3);
									if (num != 0 || num2 != 0)
									{
										int_ = Math.Min(Math.Max(int_, num), num2);
									}
								}
								baO.BKE.GetColumnIndexAndRowIndex(j, i, out var columnIndex, out var rowIndex);
								if (columnIndex == 0)
								{
									baO.method_53(ref int_);
								}
								if (rowIndex == 0)
								{
									baO.method_54(ref int_);
								}
								baO.BKE.TableDataSetting.method_273(columnIndex, rowIndex, num4, int_, bool_0: true);
								if (baO.BKE.method_0().awo != null)
								{
									Setting setting = baO.BKE.method_0().awo.method_2(baO.BKE.method_64());
									if (setting != null && setting.method_256() == rowIndex)
									{
										baO.BKE.method_0().awo.method_1(baO.BKE.method_64());
									}
								}
							}
							if (baO.BvI != null)
							{
								baO.BvI[num4, i, j].Clear();
							}
						}
					}
					bao = string.Empty;
				}
				catch (Exception)
				{
					if (Form23.enum60_0 == Form23.Enum60.BpF && baO.BKe != null)
					{
						Form54.smethod_6(Form23.form23_0, string.Format(Class333.Bcb(), bao), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						string arg = Class233.smethod_29(num, num3);
						string arg2 = Class233.smethod_29(num2, num3);
						Form54.smethod_6(Form23.form23_0, string.Format(Class333.smethod_1050(), bao, arg, arg2), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					bao = string.Empty;
					baO.method_31(null, null);
				}
			}
			baO.BKE.TableDataSetting.method_267(bool_0: true);
			@class?.method_4();
			if (keyEventArgs_0.KeyCode == Keys.Tab)
			{
				base.OnKeyDown(keyEventArgs_0);
			}
			Form23.smethod_74(baO.BKE.TableDataSetting.method_64());
		}

		private bool method_17(string string_0)
		{
			if (string_0.Length != 0 && string_0[0] == '-')
			{
				string_0 = string_0.TrimStart('-');
			}
			if (!string_0.Contains(Class333.aol()) && !string_0.Contains(Class333.smethod_186()) && !string_0.Contains(Class333.smethod_178()) && !string_0.Contains(Class333.smethod_177()))
			{
				return true;
			}
			return false;
		}

		private bool method_18(int int_0)
		{
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				return false;
			}
			if (baO.BKe != null && Form23.enum60_0 == Form23.Enum60.BpF && !baO.BKi && !baO.BKJ)
			{
				return true;
			}
			if (!double.TryParse(bao + int_0, NumberStyles.Any, CultureInfo.CurrentCulture, out var _))
			{
				return false;
			}
			return true;
		}

		private string method_19(string string_0, out Class63 class63_0)
		{
			Class63 @class = new Class63();
			if (string_0.Length < 2)
			{
				@class.baM = Enum32.baj;
				class63_0 = @class;
				return string_0;
			}
			string text = string_0.Substring(string_0.Length - 2, 2);
			if (!text.EndsWith(Class333.aol()) && !text.EndsWith(Class333.smethod_186()) && !text.EndsWith(Class333.smethod_178()) && !text.EndsWith(Class333.smethod_177()))
			{
				@class.baM = Enum32.baj;
				class63_0 = @class;
				return string_0;
			}
			if (text.Contains(Class333.aol()))
			{
				@class.baM = Enum32.baK;
			}
			if (text.Contains(Class333.smethod_186()))
			{
				@class.baM = Enum32.bak;
			}
			if (text.Contains(Class333.smethod_178()))
			{
				@class.baM = Enum32.baL;
			}
			if (text.Contains(Class333.smethod_177()))
			{
				@class.baM = Enum32.bal;
			}
			if (text.Contains(Class333.smethod_681()))
			{
				@class.bam = true;
				class63_0 = @class;
				return string_0.Substring(0, string_0.Length - 2);
			}
			@class.bam = false;
			class63_0 = @class;
			return string_0.Substring(0, string_0.Length - 1);
		}

		internal void method_20()
		{
			if (!(bao != string.Empty))
			{
				return;
			}
			baO.Bvj = false;
			bao = string.Empty;
			int firstDisplayedScrollingColumnIndex = baO.BVw.FirstDisplayedScrollingColumnIndex;
			int firstDisplayedScrollingRowIndex = baO.BVw.FirstDisplayedScrollingRowIndex;
			baO.method_26();
			try
			{
				if (firstDisplayedScrollingColumnIndex >= 0 && firstDisplayedScrollingColumnIndex < baO.BVw.ColumnCount)
				{
					baO.BVw.FirstDisplayedScrollingColumnIndex = firstDisplayedScrollingColumnIndex;
				}
			}
			catch
			{
			}
			try
			{
				if (firstDisplayedScrollingRowIndex >= 0 && firstDisplayedScrollingRowIndex < baO.BVw.RowCount)
				{
					baO.BVw.FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
				}
			}
			catch
			{
			}
			baO.BVw.method_4();
		}
	}

	[CompilerGenerated]
	private sealed class Class65
	{
		public bool baP;

		public int bap;

		public int baQ;

		public int baq;

		public int baR;

		public bool bar;

		public int baS;

		public int bas;

		public Class104 baT;

		internal void method_0()
		{
			if (baP && baT.BKf != null)
			{
				if (Bve == Enum69.const_1)
				{
					baT.Bvc.BringToFront();
					baT.Bvc.Left = baT.BVw.Left + bap;
					if (baT.Bvc.Left >= baT.BVw.Left + baQ && baT.Bvc.Left <= baT.BVw.Right)
					{
						baT.Bvc.Visible = true;
					}
					else
					{
						baT.Bvc.Visible = false;
					}
					baT.Bvc.Top = baT.BVw.Top;
					int num = baq;
					for (int i = 0; i < baR; i++)
					{
						num += baT.BVw.Rows[i].Height;
					}
					if (baT.BVw.method_7() && num > baT.BVw.Height - 18)
					{
						baT.Bvc.Height = Math.Min(baT.BVw.Height, num) - 18;
					}
					else
					{
						baT.Bvc.Height = Math.Min(baT.BVw.Height, num);
					}
				}
				else
				{
					baT.Bvc.Visible = false;
				}
			}
			else
			{
				baT.Bvc.Visible = false;
			}
		}

		internal void method_1()
		{
			if (bar && baT.BKG != null)
			{
				if (Bve == Enum69.const_1)
				{
					baT.BvD.BringToFront();
					baT.BvD.Top = baT.BVw.Top + baS;
					if (baT.BvD.Top >= baT.BVw.Top + baq && baT.BvD.Top <= baT.BVw.Bottom)
					{
						baT.BvD.Visible = true;
					}
					else
					{
						baT.BvD.Visible = false;
					}
					baT.BvD.Left = baT.BVw.Left;
					int num = baQ;
					for (int i = 0; i < bas; i++)
					{
						num += baT.BVw.Columns[i].Width;
					}
					if (baT.BVw.method_8() && num > baT.BVw.Width - 18)
					{
						baT.BvD.Width = Math.Min(baT.BVw.Width, num) - 18;
					}
					else
					{
						baT.BvD.Width = Math.Min(baT.BVw.Width, num);
					}
				}
				else
				{
					baT.BvD.Visible = false;
				}
			}
			else
			{
				baT.BvD.Visible = false;
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

	private Class56 BVw;

	private MenuNode BVX;

	private int BVx;

	private int BVY;

	private int BVy;

	private int BVZ;

	private int BVz;

	private PictureBox BvA = new PictureBox();

	private PictureBox Bva = new PictureBox();

	private Setting BvB;

	private Class148 Bvb = new Class148();

	private ThemedButton BvC = new ThemedButton();

	private Label Bvc = new Label();

	private Label BvD = new Label();

	internal static float Bvd = 9f;

	internal static Enum71 BvE = Enum71.const_0;

	internal static Enum69 Bve = Enum69.const_1;

	internal static Enum70 BvF = Enum70.const_0;

	internal static Enum70 Bvf = Enum70.const_0;

	private bool BvG;

	private List<Point> Bvg = new List<Point>();

	private int BvH;

	private int Bvh;

	private List<Struct10>[,,] BvI;

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

	internal Class104(Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0)
		: base(framework_0, framework_1, rectangle_0, bool_0)
	{
		_ = BvA.Handle;
		_ = Bva.Handle;
		_ = Bvc.Handle;
		_ = BvD.Handle;
		_ = Handle;
		Class233.smethod_2(method_52);
	}

	internal override void vmethod_2(int int_3)
	{
		Setting setting = BKD.method_31(int_3);
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
			BKF = BKE.method_64();
			if (BKd != null)
			{
				BKe = BKd.method_31(int_3) as Table;
			}
			else
			{
				BKe = null;
			}
			BVX = MenuNode.smethod_2(BKD.awj, BKE.method_69());
			if (BVX != null && BVX.method_22() != 0)
			{
				BvB = BKD.method_31(BVX.method_22());
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
		BKi = BKD.method_2() && BKD.method_3() && BKE.method_96();
		BKJ = BKd != null && BKd.method_2() && BKd.method_3() && BKe != null && BKe.method_96();
		if ((Form23.enum60_0 != Form23.Enum60.BpG || BKd == null) ? BKi : BKJ)
		{
			Label label = new Label();
			label.Text = Class333.smethod_180() + BKE.method_60(Enum96.aYt) + Class333.BAO();
			label.ForeColor = Form23.color_12;
			label.BackColor = Color.Transparent;
			label.AutoSize = true;
			label.Left = 10;
			label.Top = 10;
			Controls.Add(label);
			return;
		}
		if (BKE != null)
		{
			BKE.method_264(method_32);
			BKE.TableDataSetting.method_264(method_31);
			BKE.OnUserSliceIndexChanged += method_95;
			BKE.OnUserSelectionChanged += method_41;
			BKE.OnInvertRows += method_50;
			BKE.OnSwapColumnsAndRows += method_51;
			if (BKD.awo != null)
			{
				BKD.awo.method_2(BKE.method_64())?.method_264(method_33);
			}
			Paint += Class104_Paint;
			if (BvB != null && !BvB.method_219())
			{
				Bvb.Font = new Font(Bvb.Font.FontFamily, 10f, FontStyle.Bold);
				Bvb.ForeColor = Form23.color_14;
				string text = BKE.method_18();
				string text2 = (string.IsNullOrWhiteSpace(text) ? BKE.method_60(Enum96.aYt) : text);
				if (Form23.enum60_0 == Form23.Enum60.BpF && BKe != null && (BKi || BKJ))
				{
					text2 += Class333.BfI();
				}
				Bvb.Text = text2;
				Bvb.Enabled = BKD.method_4() && (Form23.enum60_0 != Form23.Enum60.BpG || BKd == null);
				Setting setting2 = ((Form23.enum60_0 != Form23.Enum60.BpG || BKd == null) ? BvB : BKd.method_31(BvB.method_64()));
				if (setting2 != null && !setting2.method_219())
				{
					Bvb.Checked = setting2.method_256() == 1;
				}
				else
				{
					Bvb.Checked = true;
				}
				Bvb.Left = 10;
				Bvb.Top = 6;
				Bvb.AutoSize = true;
				Bvb.CheckedChanged += Bvb_CheckedChanged;
				BvB.method_264(method_18);
				Controls.Add(Bvb);
			}
			method_14();
			method_15();
		}
		method_12();
		Bvc.Visible = false;
		Bvc.AutoSize = false;
		Bvc.Width = 2;
		Bvc.BackColor = Color.FromArgb(100, 100, 100);
		BvD.Visible = false;
		BvD.AutoSize = false;
		BvD.Height = 2;
		BvD.BackColor = Color.FromArgb(100, 100, 100);
		BvA.Size = new Size(32, 32);
		BvA.Image = GeneralResources.YellowWarning;
		Bva.Size = new Size(32, 32);
		Bva.Image = GeneralResources.YellowWarning;
		Class1.smethod_10(method_34);
		Class1.smethod_12(method_34);
		Form23.smethod_30(method_34);
		Form23.smethod_78(method_35);
		DoubleClick += vmethod_3;
		BvA.DoubleClick += vmethod_3;
		Bva.DoubleClick += vmethod_3;
		Controls.Add(BVw);
		Controls.Add(Bvc);
		Controls.Add(BvD);
		method_19();
		UpdateLayout(resizingOnly: false);
		ContextMenuStrip = method_57();
	}

	private void method_12()
	{
		BVw = new Class56(this);
		BVw.Visible = false;
		_ = BVw.Handle;
		BVw.SelectionMode = DataGridViewSelectionMode.CellSelect;
		BVw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
		BVw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
		BVw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		BVw.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		BVw.AllowUserToAddRows = false;
		BVw.AllowUserToDeleteRows = false;
		BVw.AllowUserToResizeRows = false;
		BVw.AllowUserToOrderColumns = false;
		BVw.AllowUserToResizeColumns = false;
		BVw.ReadOnly = true;
		BVw.EnableHeadersVisualStyles = false;
		BVw.BackgroundColor = Form23.color_20;
		BVw.ColumnHeadersDefaultCellStyle.BackColor = BVw.BackgroundColor;
		BVw.RowHeadersDefaultCellStyle.BackColor = BVw.BackgroundColor;
		BVw.ColumnHeadersDefaultCellStyle.ForeColor = Form23.color_12;
		BVw.RowHeadersDefaultCellStyle.ForeColor = Form23.color_12;
		BVw.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		BVw.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		BVw.GotFocus += BVw_GotFocus;
		BVw.LostFocus += BVw_LostFocus;
		BVw.MouseDown += BVw_MouseDown;
		BVw.MouseMove += BVw_MouseMove;
		BVw.MouseUp += BVw_MouseUp;
		BVw.SelectionChanged += BVw_SelectionChanged;
		BVw.CurrentCellChanged += BVw_CurrentCellChanged;
		typeof(Class56).InvokeMember(Class333.smethod_741(), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty, null, BVw, new object[1] { true });
		if (!BKD.method_4())
		{
			BVw.Enabled = false;
		}
	}

	internal void method_13()
	{
		BVw.Focus();
	}

	protected override void MouseDownHandler(object sender, MouseEventArgs e)
	{
		base.MouseDownHandler(sender, e);
		if (BVw != null && BVw.Visible)
		{
			method_13();
		}
		else
		{
			Focus();
		}
	}

	protected override void OnKeyDown(KeyEventArgs keyEventArgs_0)
	{
		if (keyEventArgs_0.KeyData == Keys.D)
		{
			method_45(null, null);
		}
		else
		{
			base.OnKeyDown(keyEventArgs_0);
		}
	}

	private void method_14()
	{
		if ((BKE.method_64() == 128 || BKE.method_64() == 15975 || BKE.method_64() == 6447 || BKE.method_64() == 8279 || BKE.method_64() == 6437) && BKD.method_4())
		{
			if (!Controls.Contains(BvC))
			{
				BvC.Top = 2;
				BvC.Width = 30;
				BvC.Height = 30;
				BvC.Text = Class333.smethod_1327();
				BvC.Font = new Font(BvC.Font.FontFamily, 11f, FontStyle.Bold);
				BvC.Click -= BvC_Click;
				BvC.Click += BvC_Click;
				Controls.Add(BvC);
			}
			BvC.Visible = true;
			BvC.Enabled = true;
		}
		else
		{
			BvC.Click -= BvC_Click;
			BvC.Visible = false;
			BvC.Enabled = false;
			if (Controls.Contains(BvC))
			{
				Controls.Remove(BvC);
			}
		}
	}

	private void method_15()
	{
		if (BVX == null)
		{
			return;
		}
		BKK = BVX.method_83(BKE.TableDataSetting);
		if (BKK != null)
		{
			BKk = BKK.method_80().BcF;
		}
		if (BKk == null)
		{
			return;
		}
		BKL = BKk.BcC[Class333.smethod_562()].BsP;
		int[] array = BKk.method_3(BKE.TableDataSetting);
		double[,,] array2 = null;
		if (array != null && array.Length == BKE.TableDataSetting.method_277())
		{
			int num = BKE.TableDataSetting.method_242()[0];
			int num2 = BKE.TableDataSetting.method_242()[1];
			int num3 = BKE.TableDataSetting.method_242()[2];
			array2 = new double[num, num2, num3];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num2; j++)
				{
					for (int k = 0; k < num3; k++)
					{
						array2[i, j, k] = array[BKE.TableDataSetting.method_250(k, j, i)];
					}
				}
			}
		}
		if (array2 != null)
		{
			BKl = array2;
			TableAxis[] array3 = new TableAxis[3] { BKE.SliceAxis, BKE.RowAxis, BKE.ColumnAxis };
			BKM = new Struct11[3];
			TableAxis[] array4 = array3;
			int num4 = 0;
			while (true)
			{
				if (num4 >= array4.Length)
				{
					return;
				}
				TableAxis tableAxis = array4[num4];
				if (tableAxis != null)
				{
					Struct11 @struct = default;
					int[] array5 = BKk.method_3(tableAxis.method_87());
					int[] array6 = BKk.method_3(tableAxis.method_90());
					int[] array7 = BKk.method_3(tableAxis.method_88());
					int[] array8 = BKk.method_3(tableAxis.method_89());
					if (array5 == null || array5.Length != 1 || array6 == null || array6.Length != 1 || array7 == null || array7.Length != 1 || array8 == null || array8.Length != tableAxis.method_89().method_277())
					{
						break;
					}
					@struct.Bvv = array5[0] != 0;
					@struct.BvW = array6[0];
					@struct.Bvw = array7[0];
					@struct.BvX = new int[@struct.Bvw];
					for (int l = 0; l < @struct.Bvw; l++)
					{
						@struct.BvX[l] = array8[l];
					}
					BKM[(int)tableAxis.method_71()] = @struct;
				}
				num4++;
			}
			BKk = null;
		}
		else
		{
			BKk = null;
		}
	}

	protected override void vmethod_1()
	{
		try
		{
			if (BvB != null && !BvB.method_219())
			{
				Bvb.CheckedChanged -= Bvb_CheckedChanged;
				BvB.method_265(method_18);
			}
			BvC.Click -= BvC_Click;
			if (BVw != null)
			{
				BVw.GotFocus -= BVw_GotFocus;
				BVw.LostFocus -= BVw_LostFocus;
				BVw.MouseDown -= BVw_MouseDown;
				BVw.MouseMove -= BVw_MouseMove;
				BVw.MouseUp -= BVw_MouseUp;
				BVw.SelectionChanged -= BVw_SelectionChanged;
				BVw.CurrentCellChanged -= BVw_CurrentCellChanged;
				for (int i = 0; i < BVw.Columns.Count; i++)
				{
					if (BVw.Columns[i].HeaderCell.ContextMenuStrip != null)
					{
						BVw.Columns[i].HeaderCell.ContextMenuStrip.Opening -= method_72;
					}
				}
				for (int j = 0; j < BVw.Rows.Count; j++)
				{
					if (BVw.Rows[j].HeaderCell.ContextMenuStrip != null)
					{
						BVw.Rows[j].HeaderCell.ContextMenuStrip.Opening -= method_74;
					}
				}
			}
			DoubleClick -= vmethod_3;
			BvA.DoubleClick -= vmethod_3;
			Bva.DoubleClick -= vmethod_3;
			if (BKE != null)
			{
				BKE.method_265(method_32);
				BKE.TableDataSetting.method_265(method_31);
				BKE.OnUserSliceIndexChanged -= method_95;
				BKE.OnUserSelectionChanged -= method_41;
				BKE.OnInvertRows -= method_50;
				BKE.OnSwapColumnsAndRows -= method_51;
				if (BKD.awo != null)
				{
					BKD.awo.method_2(BKE.method_64())?.method_265(method_33);
				}
				Paint -= Class104_Paint;
				if (BKE.SliceAxis != null && BKE.SliceAxis.method_87() != null)
				{
					BKE.SliceAxis.method_87().method_265(method_30);
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.method_88() != null)
				{
					BKE.SliceAxis.method_88().method_265(method_30);
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.method_89() != null)
				{
					BKE.SliceAxis.method_89().method_265(method_30);
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.method_91() != null)
				{
					BKE.SliceAxis.method_91().method_265(method_30);
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.method_90() != null)
				{
					BKE.HorizAxis.method_90().method_265(method_29);
				}
				if (BKE.VertAxis != null && BKE.VertAxis.method_90() != null)
				{
					BKE.VertAxis.method_90().method_265(method_29);
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.method_90() != null)
				{
					BKE.SliceAxis.method_90().method_265(method_29);
				}
			}
			Class1.smethod_11(method_34);
			Class1.smethod_13(method_34);
			Form23.smethod_31(method_34);
			Form23.smethod_79(method_35);
			foreach (ToolStripMenuItem item in BvR)
			{
				item.Click -= method_66;
			}
			foreach (ToolStripMenuItem item2 in Bvr)
			{
				item2.Click -= method_64;
			}
			foreach (ToolStripMenuItem bv in BvS)
			{
				bv.Click -= method_67;
			}
			foreach (ToolStripMenuItem bv2 in Bvs)
			{
				bv2.Click -= method_65;
			}
			foreach (ToolStripMenuItem item3 in BvT)
			{
				item3.Click -= method_75;
			}
			foreach (ToolStripMenuItem item4 in Bvt)
			{
				item4.Click -= Bvq_Click;
			}
			if (ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item5 in ContextMenuStrip.Items)
			{
				item5.Click -= vmethod_3;
				item5.Click -= method_47;
				item5.Click -= method_48;
				item5.Click -= method_49;
				item5.Click -= method_45;
				item5.Click -= Bvl_Click;
				item5.Click -= BvM_Click;
				item5.Click -= Bvm_Click;
				item5.Click -= BvN_Click;
				item5.Click -= Bvn_Click;
				item5.Click -= BvO_Click;
				item5.Click -= Bvo_Click;
				item5.Click -= BvP_Click;
				item5.Click -= Bvp_Click;
				item5.Click -= method_80;
				item5.Click -= method_77;
				item5.Click -= method_81;
				item5.Click -= method_76;
				item5.Click -= method_87;
				item5.Click -= method_85;
				item5.Click -= method_86;
				item5.Click -= BvQ_Click;
				item5.Click -= Bvq_Click;
			}
			ContextMenuStrip.Opening -= method_58;
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		vmethod_1();
		try
		{
			Form23.form23_0.method_10(vmethod_0);
			Class233.smethod_3(method_52);
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public override string ToString()
	{
		string text = base.ToString();
		if (BKE != null)
		{
			text = text + Class333.aMY() + BKE.ToString();
		}
		return text + Class333.BAZ() + Left + Class333.BAz() + Top;
	}

	protected override void vmethod_0(object sender, EventArgs e)
	{
		if (BvB != null)
		{
			Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || BKd == null) ? BvB : BKd.method_31(BvB.method_64()));
			if (setting != null && !setting.method_219())
			{
				Bvb.CheckedChanged -= Bvb_CheckedChanged;
				if (Bvb.Checked != (setting.method_256() == 1))
				{
					Bvb.Checked = setting.method_256() == 1;
				}
				Bvb.CheckedChanged += Bvb_CheckedChanged;
			}
		}
		base.vmethod_0(sender, e);
		if (BKE != null)
		{
			method_26();
		}
	}

	[SpecialName]
	internal Table method_16()
	{
		return BKE;
	}

	[SpecialName]
	internal Class56 method_17()
	{
		return BVw;
	}

	private void Bvb_CheckedChanged(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4())
		{
			return;
		}
		if (!Form23.bool_2)
		{
			SettingOrSpecialObject settingOrSpecialObject = null;
			if (BvB.method_6() != null && BKD.aWY.Contains(BvB.method_6()))
			{
				settingOrSpecialObject = BvB.method_6();
			}
			Class280 @class = Form23.smethod_95();
			@class?.method_2(BvB.method_64());
			if (Bvb.Checked)
			{
				BvB.method_272(1, bool_0: true);
				if (settingOrSpecialObject != null)
				{
					PortFunction.smethod_20(settingOrSpecialObject, bool_0: false);
				}
			}
			else
			{
				BvB.method_272(0, bool_0: true);
			}
			@class?.method_4();
		}
		Form23.smethod_74(BvB.method_64());
	}

	private void method_18(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate17 method = method_18;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (!BvB.method_219() && Bvb.Checked != (BvB.method_256() == 1))
		{
			Bvb.Checked = BvB.method_256() == 1;
		}
	}

	private void method_19()
	{
		bool flag = ((Form23.enum60_0 != Form23.Enum60.BpG || BKd == null) ? BKi : BKJ);
		if (flag || BKE == null)
		{
			return;
		}
		Table table = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.method_87() != null)
		{
			BKE.SliceAxis.method_87().method_265(method_30);
			BKE.SliceAxis.method_87().method_264(method_30);
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.method_88() != null)
		{
			BKE.SliceAxis.method_88().method_265(method_30);
			BKE.SliceAxis.method_88().method_264(method_30);
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.method_89() != null)
		{
			BKE.SliceAxis.method_89().method_265(method_30);
			BKE.SliceAxis.method_89().method_264(method_30);
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.method_91() != null)
		{
			BKE.SliceAxis.method_91().method_265(method_30);
			BKE.SliceAxis.method_91().method_264(method_30);
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.method_90() != null)
		{
			BKE.HorizAxis.method_90().method_265(method_29);
			BKE.HorizAxis.method_90().method_264(method_29);
			BKf = BKE.HorizAxis.method_92();
			if (BKf != null && BKE.HorizAxisEnabled() && !Controls.Contains(BvA))
			{
				Controls.Add(BvA);
			}
			if (BKe != null && BKe.HorizAxis != null && BKe.HorizAxis.method_90() != null)
			{
				BKH = BKe.HorizAxis.method_92();
			}
		}
		if (BKE.VertAxis != null && BKE.VertAxis.method_90() != null)
		{
			BKE.VertAxis.method_90().method_265(method_29);
			BKE.VertAxis.method_90().method_264(method_29);
			BKG = BKE.VertAxis.method_92();
			if (BKG != null && BKE.VertAxisEnabled() && !Controls.Contains(Bva))
			{
				Controls.Add(Bva);
			}
			if (BKe != null && BKe.VertAxis != null && BKe.VertAxis.method_90() != null)
			{
				BKh = BKe.VertAxis.method_92();
			}
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.method_90() != null)
		{
			BKE.SliceAxis.method_90().method_265(method_29);
			BKE.SliceAxis.method_90().method_264(method_29);
			BKg = BKE.SliceAxis.method_92();
			if (BKe != null && BKe.SliceAxis != null && BKe.SliceAxis.method_90() != null)
			{
				BKI = BKe.SliceAxis.method_92();
			}
		}
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		bool flag = ((Form23.enum60_0 != Form23.Enum60.BpG || BKd == null) ? BKi : BKJ);
		if (!flag && BKE != null)
		{
			Table table = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BKE : BKe);
			if (table != null)
			{
				BVw.Left = 8;
				BVw.Width = Width - 16;
				Graphics graphics = CreateGraphics();
				method_21(graphics);
				method_20();
				method_24(graphics);
				graphics.Dispose();
				BVw.Invalidate();
				BVw.method_4();
			}
		}
	}

	private void method_20()
	{
		int num;
		if (BVw.Rows.Count != 0)
		{
			num = 0;
			if (BVw.ColumnHeadersVisible)
			{
				num += BVw.ColumnHeadersHeight;
			}
			foreach (DataGridViewRow item in (IEnumerable)BVw.Rows)
			{
				num += item.Height;
			}
			num += 35;
		}
		else
		{
			num = int.MaxValue;
		}
		BVw.Top = 39 + Math.Max(BVy, BVx);
		if (BKE.SlicesEnabled() || (BKe != null && BKe.SlicesEnabled()))
		{
			BVw.Height = Math.Min(num, Height - 10 - BVw.Top - BKj.Height);
		}
		else
		{
			BVw.Height = Math.Min(num, Height - 10 - BVw.Top);
		}
	}

	private void method_21(Graphics graphics_0)
	{
		Table table;
		Setting setting;
		Setting setting2;
		if (Form23.enum60_0 == Form23.Enum60.BpG)
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
		using Font font = new Font(Font.FontFamily, 10f);
		if (table.VertAxisEnabled() && table.VertAxis.method_90() != null)
		{
			if (setting2 != null)
			{
				string text = string.Empty;
				int num = setting2.method_231();
				if (num != 0 && num != 82)
				{
					text = Class333.smethod_497() + Class233.smethod_35(setting2.method_232(), num, bool_0: false, 0) + Class333.smethod_9();
				}
				string text2 = setting2.method_18();
				string text3 = (string.IsNullOrWhiteSpace(text2) ? setting2.method_60(Enum96.aYt) : text2);
				text3 += text;
				SizeF sizeF = graphics_0.MeasureString(text3, font, 140);
				BVx = (int)sizeF.Height;
				BVY = (int)sizeF.Width;
				Bva.Visible = !setting2.method_35() || !PortFunction.smethod_52(setting2);
				if (Bva.Visible)
				{
					Bva.Top = 37 + BVx - Bva.Height;
					Bva.Left = 8 + BVY;
				}
			}
			else
			{
				Bva.Visible = false;
			}
		}
		else
		{
			Bva.Visible = false;
		}
		if (table.HorizAxisEnabled() && table.HorizAxis.method_90() != null)
		{
			if (setting != null)
			{
				string text4 = string.Empty;
				int num2 = setting.method_231();
				if (num2 != 0 && num2 != 82)
				{
					text4 = Class333.smethod_497() + Class233.smethod_35(setting.method_232(), num2, bool_0: false, 0) + Class333.smethod_9();
				}
				string text5 = setting.method_18();
				string text6 = (string.IsNullOrWhiteSpace(text5) ? setting.method_60(Enum96.aYt) : text5);
				text6 += text4;
				SizeF sizeF2;
				if (table.VertAxisEnabled())
				{
					int val = table.HorizAxisCount() * 48 + BVw.RowHeadersWidth - (BVY + 50);
					int width = Math.Min(500, Math.Max(200, val));
					sizeF2 = graphics_0.MeasureString(text6, font, width);
				}
				else
				{
					sizeF2 = graphics_0.MeasureString(text6, font);
				}
				BVy = (int)sizeF2.Height;
				BVZ = (int)sizeF2.Width + 5;
				if (table.VertAxisEnabled())
				{
					BVz = table.HorizAxisCount() * 48 / 2 + BVw.RowHeadersWidth - BVZ / 2;
				}
				else
				{
					BVz = table.HorizAxisCount() * 48 / 2 - BVZ / 2;
				}
				BVz = Math.Max(BVz, BVY + 50);
				if (BVz + BVZ >= Width - 50)
				{
					BVz = Width - 50 - BVZ;
				}
				if (BVz < 0)
				{
					BVz = 0;
				}
				BvA.Visible = !setting.method_35() || !PortFunction.smethod_52(setting);
				if (BvA.Visible)
				{
					BvA.Top = 37 + BVy - BvA.Height;
					BvA.Left = BVz + BVZ;
				}
			}
			else
			{
				BvA.Visible = false;
			}
		}
		else
		{
			BvA.Visible = false;
		}
	}

	private Color method_22(int int_3, Setting setting_0)
	{
		if (TableAxis.smethod_4(int_3, setting_0))
		{
			return Color.Red;
		}
		return BVw.BackgroundColor;
	}

	private Color method_23(int int_3, Setting setting_0)
	{
		if (TableAxis.smethod_4(int_3, setting_0))
		{
			return Color.Red;
		}
		return Form23.color_12;
	}

	private void method_24(Graphics graphics_0)
	{
		bool flag2;
		bool flag = (flag2 = BKE.SlicesEnabled());
		if (BKe != null)
		{
			flag = BKe.SlicesEnabled();
		}
		if (flag2 | flag)
		{
			Table table;
			Setting setting;
			if (Form23.enum60_0 == Form23.Enum60.BpG)
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
			if (!BKj.Visible)
			{
				BKj.Visible = true;
			}
			int num = table.SliceCount();
			int num2 = Height - (BKj.Height + 2);
			if (BKj.Top != num2)
			{
				BKj.Top = num2;
			}
			if (BKj.Left != BVw.Left)
			{
				BKj.Left = BVw.Left;
			}
			int num3 = Width - 10 - BKj.Left;
			if (BKj.Width != num3)
			{
				BKj.Width = num3;
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
			if (!Controls.Contains(BKj))
			{
				Controls.Add(BKj);
			}
			int num4 = 0;
			if (setting != null)
			{
				num4 = setting.method_231();
			}
			BKj.Bvx.Clear();
			for (int i = 0; i < num; i++)
			{
				BKj.Bvx.Add(new Control1.Class66());
				int int_ = table.SliceAxis.method_89().method_258(i);
				string text = ((setting == null) ? string.Empty : setting.method_253(int_).DisplayValueString);
				BKj.Bvx[i].bat = text;
				if (BKe == null)
				{
					BKj.Bvx[i].baU = method_23(int_, BKg);
				}
				else if (!BKi && !BKJ)
				{
					if (table == BKE && BKe.SliceAxis.method_96(int_, text, num4) == -1)
					{
						BKj.Bvx[i].baU = Form23.color_9;
					}
					else if (table == BKe && BKE.SliceAxis.method_96(int_, text, num4) == -1)
					{
						BKj.Bvx[i].baU = Form23.color_9;
					}
					else
					{
						BKj.Bvx[i].baU = method_23(int_, BKg);
					}
				}
				else
				{
					BKj.Bvx[i].baU = Form23.color_12;
				}
			}
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				BKj.BWC.Visible = false;
			}
			else if (flag2 && BKE.SliceAxis.method_90() != null)
			{
				if (BKg != null)
				{
					BKj.BWC.Visible = !BKg.method_35() || !PortFunction.smethod_52(BKg);
				}
				else
				{
					BKj.BWC.Visible = false;
				}
			}
			else
			{
				BKj.BWC.Visible = false;
			}
			BKj.Invalidate();
		}
		else
		{
			if (BKj.Visible)
			{
				BKj.Visible = false;
			}
			if (BKE.UserSliceIndex != 0)
			{
				BKE.UserSliceIndex = 0;
			}
		}
	}

	private Color method_25(int int_3, int int_4, int int_5, int int_6, int int_7, int int_8, int int_9)
	{
		if (int_4 == int_5)
		{
			return Class18.smethod_0(int_9, int_7, int_6);
		}
		int num;
		if (Form23.bool_50)
		{
			num = ((int_8 >= int_9) ? (int_8 + (255 - (int_8 - int_9)) * (int_3 - int_4) / (int_5 - int_4)) : (int_8 - (255 - (int_9 - int_8)) * (int_3 - int_4) / (int_5 - int_4)));
		}
		else
		{
			num = int_8 + (int_9 - int_8) * (int_3 - int_4) / (int_5 - int_4);
		}
		if (num < 0)
		{
			num += 255;
		}
		else if (num > 255)
		{
			num -= 255;
		}
		return Class18.smethod_0(num, int_7, int_6);
	}

	internal void method_26()
	{
		if (BKe != null && (BKi || BKJ) && Form23.enum60_0 == Form23.Enum60.BpF)
		{
			return;
		}
		bool flag = ((Form23.enum60_0 != Form23.Enum60.BpG || BKd == null) ? BKi : BKJ);
		if (flag || BKE == null)
		{
			return;
		}
		Table table;
		Setting setting;
		Setting setting2;
		if (Form23.enum60_0 == Form23.Enum60.BpG)
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
		ScrollBars scrollBars = BVw.ScrollBars;
		BVw.ScrollBars = ScrollBars.None;
		bool flag2 = table.HorizAxisEnabled();
		bool flag3 = table.VertAxisEnabled();
		bool flag4 = table.SlicesEnabled();
		int num = table.HorizAxisCount();
		int num2 = table.VertAxisCount();
		int num3 = table.SliceCount();
		List<Point> list = new List<Point>();
		for (int i = 0; i < table.HorizVertIndexPerUserSelectedCell.Count; i++)
		{
			list.Add(table.HorizVertIndexPerUserSelectedCell[i]);
		}
		Point userCurrentCellHorizVertIndex = table.UserCurrentCellHorizVertIndex;
		BVw.Columns.Clear();
		BVw.Rows.Clear();
		BVw.Visible = true;
		int num4 = 0;
		if (flag4)
		{
			num4 = table.UserSliceIndex;
		}
		BVw.ColumnCount = num;
		int int_ = table.TableDataSetting.method_231();
		int num5 = int.MaxValue;
		int num6 = int.MinValue;
		for (int j = 0; j < num3; j++)
		{
			for (int k = 0; k < num2; k++)
			{
				for (int l = 0; l < num; l++)
				{
					int num7;
					if (Form23.enum60_0 == Form23.Enum60.BpF && BKe != null)
					{
						num7 = Class233.smethod_26(BKE.GetCellDifferenceDisplayValue(BKe, l, k, num4, out var _, out var _), int_);
					}
					else
					{
						num7 = ((!table.SwapColumnsAndRows) ? table.TableDataSetting.method_257(l, k, j) : table.TableDataSetting.method_257(k, l, j));
					}
					if (num7 > num6)
					{
						num6 = num7;
					}
					if (num7 < num5)
					{
						num5 = num7;
					}
				}
			}
		}
		Graphics graphics = CreateGraphics();
		int num8 = 0;
		BVw.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Bvd, FontStyle.Bold);
		BVw.RowHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Bvd, FontStyle.Bold);
		int int_2 = Form23.int_45 * 255 / 100;
		int int_3 = Form23.int_44 * 255 / 100;
		int int_4 = Form23.int_46 * 255 / 100;
		int int_5 = Form23.int_47 * 255 / 100;
		for (int k = 0; k < num2; k++)
		{
			string[] array = new string[num];
			for (int l = 0; l < num; l++)
			{
				string text;
				if (Form23.enum60_0 == Form23.Enum60.BpF && BKe != null)
				{
					int num9 = ((!table.InvertRows) ? Class233.smethod_26(BKE.GetCellDifferenceDisplayValue(BKe, l, k, num4, out var _, out var _), int_) : Class233.smethod_26(BKE.GetCellDifferenceDisplayValue(BKe, l, num2 - 1 - k, num4, out var _, out var _), int_));
					text = Class233.smethod_29(num9, int_);
				}
				else
				{
					table.GetColumnIndexAndRowIndex(l, k, out var columnIndex, out var rowIndex);
					int num9 = table.TableDataSetting.method_257(columnIndex, rowIndex, num4);
					text = Class233.smethod_30(num9, int_, Class233.smethod_1(int_));
				}
				array[l] = text;
				if (k != 0)
				{
					continue;
				}
				if (flag2 && setting != null)
				{
					BVw.ColumnHeadersVisible = true;
					int height = TextRenderer.MeasureText(graphics, Class333.smethod_184(), BVw.ColumnHeadersDefaultCellStyle.Font).Height;
					BVw.ColumnHeadersHeight = Math.Max(20, height + 7);
					int num10 = table.HorizAxis.method_89().method_258(l);
					(string, string, bool) tuple = setting.method_253(num10);
					BVw.Columns[l].HeaderCell.Value = tuple.Item1;
					int num11 = setting.method_231();
					if (BKe != null && table == BKE && BKe.HorizAxis.method_96(num10, tuple.Item1, num11) == -1)
					{
						BVw.Columns[l].HeaderCell.Style.BackColor = Form23.color_9;
					}
					else if (BKe != null && table == BKe && BKE.HorizAxis.method_96(num10, tuple.Item1, num11) == -1)
					{
						BVw.Columns[l].HeaderCell.Style.BackColor = Form23.color_9;
					}
					else
					{
						bool flag5 = false;
						foreach (DataGridViewCell selectedCell in BVw.SelectedCells)
						{
							if (selectedCell.ColumnIndex == l)
							{
								flag5 = true;
								break;
							}
						}
						if (flag5)
						{
							BVw.Columns[l].HeaderCell.Style.BackColor = Color.DarkSeaGreen;
						}
						else
						{
							BVw.Columns[l].HeaderCell.Style.BackColor = method_22(num10, setting);
						}
					}
					bool flag6 = false;
					if (BKk != null && BKK.method_88() && (BKe == null || Form23.enum60_0 != Form23.Enum60.BpF))
					{
						int num12 = (int)table.HorizAxis.method_71();
						flag6 = true;
						for (int m = 0; m < BKM[num12].Bvw; m++)
						{
							if (BKM[num12].BvX[m] == num10)
							{
								flag6 = false;
								break;
							}
						}
					}
					BVw.Columns[l].HeaderCell.Tag = flag6;
				}
				else
				{
					BVw.ColumnHeadersVisible = false;
				}
			}
			if (num != 0)
			{
				DataGridViewRowCollection rows = BVw.Rows;
				object[] values = array;
				rows.Add(values);
			}
			if (BVw.Rows.Count != 0)
			{
				using Font font = new Font(Font.FontFamily, Bvd);
				int height2 = TextRenderer.MeasureText(graphics, Class333.smethod_184(), font).Height;
				BVw.Rows[k].Height = Math.Max(17, height2 + 2);
			}
			if (num > 1 || num2 > 1 || num3 > 1)
			{
				for (int l = 0; l < num; l++)
				{
					int num13 = 0;
					if (BKe != null)
					{
						num13 = ((!table.InvertRows) ? Class233.smethod_26(BKE.GetCellDifferenceDisplayValue(BKe, l, k, num4, out var _, out var _), int_) : Class233.smethod_26(BKE.GetCellDifferenceDisplayValue(BKe, l, num2 - 1 - k, num4, out var _, out var _), int_));
					}
					int int_6;
					if (Form23.enum60_0 == Form23.Enum60.BpF && BKe != null)
					{
						int_6 = num13;
					}
					else
					{
						table.GetColumnIndexAndRowIndex(l, k, out var columnIndex2, out var rowIndex2);
						int_6 = table.TableDataSetting.method_257(columnIndex2, rowIndex2, num4);
					}
					Color backColor = method_25(int_6, num5, num6, int_2, int_3, int_4, int_5);
					DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
					dataGridViewCellStyle.BackColor = backColor;
					BVw.Rows[k].Cells[l].Style = dataGridViewCellStyle;
					bool bool_ = false;
					if (BKe != null)
					{
						bool_ = Class233.smethod_28(num13, int_) != 0.0;
					}
					bool bool_2 = method_27(table, int_, num2, k, l, num4);
					Class64 tag = new Class64(bool_, bool_2);
					BVw.Rows[k].Cells[l].Tag = tag;
				}
			}
			if (flag3 && setting2 != null && BVw.Rows.Count != 0)
			{
				BVw.RowHeadersVisible = true;
				int num14 = ((!table.InvertRows) ? table.VertAxis.method_89().method_258(k) : table.VertAxis.method_89().method_258(num2 - 1 - k));
				(string, string, bool) tuple2 = setting2.method_253(num14);
				BVw.Rows[k].HeaderCell.Value = tuple2.Item1;
				int num15 = setting2.method_231();
				if (BKe != null && table == BKE && BKe.VertAxis.method_96(num14, tuple2.Item1, num15) == -1)
				{
					BVw.Rows[k].HeaderCell.Style.BackColor = Form23.color_9;
				}
				else if (BKe != null && table == BKe && BKE.VertAxis.method_96(num14, tuple2.Item1, num15) == -1)
				{
					BVw.Rows[k].HeaderCell.Style.BackColor = Form23.color_9;
				}
				else
				{
					bool flag7 = false;
					foreach (DataGridViewCell selectedCell2 in BVw.SelectedCells)
					{
						if (selectedCell2.RowIndex == k)
						{
							flag7 = true;
							break;
						}
					}
					if (flag7)
					{
						BVw.Rows[k].HeaderCell.Style.BackColor = Color.PaleVioletRed;
					}
					else
					{
						BVw.Rows[k].HeaderCell.Style.BackColor = method_22(num14, BKG);
					}
				}
				int val = TextRenderer.MeasureText(graphics, tuple2.Item1, BVw.RowHeadersDefaultCellStyle.Font).Width + 10;
				num8 = Math.Max(num8, val);
				bool flag8 = false;
				if (BKk != null && BKK.method_88() && (BKe == null || Form23.enum60_0 != Form23.Enum60.BpF))
				{
					int num16 = (int)table.VertAxis.method_71();
					flag8 = true;
					for (int n = 0; n < BKM[num16].Bvw; n++)
					{
						if (BKM[num16].BvX[n] == num14)
						{
							flag8 = false;
							break;
						}
					}
				}
				BVw.Rows[k].HeaderCell.Tag = flag8;
			}
			else
			{
				BVw.RowHeadersVisible = false;
			}
		}
		if (BVw.RowHeadersVisible)
		{
			BVw.RowHeadersWidth = Math.Max(60, num8);
		}
		Font font2 = new Font(Font.FontFamily, Bvd);
		string text2 = Class233.smethod_30(BKE.method_229(), int_, Class233.smethod_1(int_));
		int width = TextRenderer.MeasureText(graphics, text2, font2).Width;
		for (int l = 0; l < num; l++)
		{
			int width2 = TextRenderer.MeasureText(graphics, BVw.Columns[l].HeaderCell.Value as string, BVw.ColumnHeadersDefaultCellStyle.Font).Width;
			BVw.Columns[l].Width = Math.Max(Math.Max(48, width2 + 10), width + 5);
			BVw.Columns[l].SortMode = DataGridViewColumnSortMode.NotSortable;
			if (BKD.method_4())
			{
				BVw.Columns[l].HeaderCell.ContextMenuStrip = method_71(l);
			}
			BVw.Columns[l].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			BVw.Columns[l].DefaultCellStyle.Font = font2;
		}
		if (BVw.Rows.Count != 0 && BKD.method_4())
		{
			for (int k = 0; k < num2; k++)
			{
				BVw.Rows[k].HeaderCell.ContextMenuStrip = method_73(k);
			}
		}
		int num17 = int.MaxValue;
		int num18 = int.MaxValue;
		for (int num19 = 0; num19 < list.Count; num19++)
		{
			int num20 = Math.Min(list[num19].X, num - 1);
			int num21 = Math.Min(list[num19].Y, num2 - 1);
			if (BVw.Rows.Count != 0 && num21 < BVw.Rows.Count && BVw.Rows[num21].Cells.Count != 0 && num20 < BVw.Rows[num21].Cells.Count)
			{
				num17 = Math.Min(num17, num21);
				num18 = Math.Min(num18, num20);
			}
		}
		if (userCurrentCellHorizVertIndex.X != -1 && userCurrentCellHorizVertIndex.Y != -1)
		{
			int num22 = Math.Min(userCurrentCellHorizVertIndex.X, num - 1);
			int num23 = Math.Min(userCurrentCellHorizVertIndex.Y, num2 - 1);
			if (BVw.Rows.Count != 0 && num23 < BVw.Rows.Count && BVw.Rows[num23].Cells.Count != 0 && num22 < BVw.Rows[num23].Cells.Count)
			{
				BVw.CurrentCell = BVw.Rows[num23].Cells[num22];
			}
		}
		if (BVw.CurrentCell != null && BVw.CurrentCell.ColumnIndex == 0 && BVw.CurrentCell.RowIndex == 0 && list.Count > 0 && !list.Contains(new Point(0, 0)))
		{
			BVw.CurrentCell = BVw.Rows[num17].Cells[num18];
			BVw.Rows[0].Cells[0].Selected = false;
		}
		int num24 = int.MaxValue;
		int num25 = int.MinValue;
		int num26 = int.MaxValue;
		int num27 = int.MinValue;
		for (int num28 = 0; num28 < list.Count; num28++)
		{
			int num29 = Math.Min(list[num28].X, num - 1);
			int num30 = Math.Min(list[num28].Y, num2 - 1);
			if (BVw.Rows.Count != 0 && num30 < BVw.Rows.Count && BVw.Rows[num30].Cells.Count != 0 && num29 < BVw.Rows[num30].Cells.Count)
			{
				num24 = Math.Min(num24, num29);
				num25 = Math.Max(num25, num29);
				num26 = Math.Min(num26, num30);
				num27 = Math.Max(num27, num30);
			}
		}
		BvL = false;
		if (num24 != int.MaxValue && num25 != int.MinValue && num26 != int.MaxValue && num27 != int.MinValue)
		{
			if (!BVw.Rows[num27].Cells[num25].Displayed)
			{
				BVw.CurrentCell = BVw.Rows[num27].Cells[num25];
			}
			if (!BVw.Rows[num26].Cells[num24].Displayed)
			{
				BVw.CurrentCell = BVw.Rows[num26].Cells[num24];
			}
			for (int num31 = num26; num31 <= num27; num31++)
			{
				for (int num32 = num24; num32 <= num25; num32++)
				{
					BVw.Rows[num31].Cells[num32].Selected = true;
				}
			}
		}
		BvL = true;
		if (list.Count != 0)
		{
			BVw_SelectionChanged(null, null);
		}
		if (BvG)
		{
			method_83();
		}
		method_82();
		method_21(graphics);
		graphics.Dispose();
		method_20();
		BVw.ScrollBars = scrollBars;
		BVw.method_4();
	}

	private bool method_27(Table table_0, int int_3, int int_4, int int_5, int int_6, int int_7)
	{
		if (BKk != null && BKK.method_88() && (BKe == null || Form23.enum60_0 != Form23.Enum60.BpF))
		{
			int[] columnAxisValuesForCompare = null;
			Struct11 @struct = BKM[2];
			if (@struct.Bvv)
			{
				columnAxisValuesForCompare = @struct.BvX;
			}
			int[] rowAxisValuesForCompare = null;
			Struct11 struct2 = BKM[1];
			if (struct2.Bvv)
			{
				rowAxisValuesForCompare = struct2.BvX;
			}
			int[] sliceAxisValuesForCompare = null;
			Struct11 struct3 = BKM[0];
			if (struct3.Bvv)
			{
				sliceAxisValuesForCompare = struct3.BvX;
			}
			return table_0.GetCellDifferenceDisplayValue(BKl, columnAxisValuesForCompare, rowAxisValuesForCompare, sliceAxisValuesForCompare, int_6, int_5, int_7, int_4) != 0.0;
		}
		return false;
	}

	private void BVw_GotFocus(object sender, EventArgs e)
	{
		if ((BVw.SelectedCells == null || BVw.SelectedCells.Count == 0) && BVw.Rows.Count != 0 && BVw.Rows[0].Cells.Count != 0)
		{
			BVw.Rows[0].Cells[0].Selected = true;
		}
		Form23.smethod_12(this);
		Invalidate();
	}

	private void BVw_LostFocus(object sender, EventArgs e)
	{
		Form23.smethod_13();
		Invalidate();
	}

	private void BVw_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left || BKE == null || !BKE.method_35() || !BKD.method_4())
		{
			return;
		}
		if (BVw.method_14())
		{
			BVw.method_20();
		}
		Table table = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		Point pt = PointToClient(Control.MousePosition);
		int num = table.HorizAxisCount();
		int num2 = table.VertAxisCount();
		int num3 = 0;
		if (table.VertAxisEnabled())
		{
			num3 = BVw.RowHeadersWidth;
		}
		int num4 = 0;
		if (table.HorizAxisEnabled())
		{
			num4 = BVw.ColumnHeadersHeight;
		}
		int num5 = BVw.Left + num3;
		int num6 = 0;
		while (true)
		{
			if (num6 < num)
			{
				int width = BVw.Columns[num6].Width;
				if (new Rectangle(num5 - BVw.HorizontalScrollingOffset, BVw.Top, width, num4).Contains(pt))
				{
					break;
				}
				num5 += width;
				num6++;
				continue;
			}
			int num7 = BVw.Top + num4;
			int num8 = 0;
			while (true)
			{
				if (num8 < num2)
				{
					int height = BVw.Rows[num8].Height;
					if (new Rectangle(BVw.Left, num7 - BVw.VerticalScrollingOffset, num3, height).Contains(pt))
					{
						break;
					}
					num7 += height;
					num8++;
					continue;
				}
				return;
			}
			int num9 = (Bvk = num8);
			bool flag = false;
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num2; j++)
				{
					if (j == num9)
					{
						if (!flag)
						{
							BVw.CurrentCell = BVw.Rows[j].Cells[i];
							flag = true;
						}
						BVw.Rows[j].Cells[i].Selected = true;
					}
					else
					{
						BVw.Rows[j].Cells[i].Selected = false;
					}
				}
			}
			return;
		}
		int num10 = (BvK = num6);
		bool flag2 = false;
		for (int k = 0; k < num2; k++)
		{
			for (int l = 0; l < num; l++)
			{
				if (l == num10)
				{
					if (!flag2)
					{
						BVw.CurrentCell = BVw.Rows[k].Cells[l];
						flag2 = true;
					}
					BVw.Rows[k].Cells[l].Selected = true;
				}
				else
				{
					BVw.Rows[k].Cells[l].Selected = false;
				}
			}
		}
	}

	private void BVw_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left || BKE == null || !BKE.method_35() || (BvK == -1 && Bvk == -1) || !BKD.method_4())
		{
			return;
		}
		Table table = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		Point pt = PointToClient(Control.MousePosition);
		int num = table.HorizAxisCount();
		int num2 = table.VertAxisCount();
		int num3 = 0;
		if (table.VertAxisEnabled())
		{
			num3 = BVw.RowHeadersWidth;
		}
		int num4 = 0;
		if (table.HorizAxisEnabled())
		{
			num4 = BVw.ColumnHeadersHeight;
		}
		int num5 = BVw.Left + num3;
		int num6 = 0;
		while (true)
		{
			if (num6 < num)
			{
				int width = BVw.Columns[num6].Width;
				if (new Rectangle(num5 - BVw.HorizontalScrollingOffset, BVw.Top, width, BVw.Height).Contains(pt) && pt.X > BVw.Left + num3)
				{
					break;
				}
				num5 += width;
				num6++;
				continue;
			}
			int num7 = BVw.Top + num4;
			int num8 = 0;
			while (true)
			{
				if (num8 < num2)
				{
					int height = BVw.Rows[num8].Height;
					if (new Rectangle(BVw.Left, num7 - BVw.VerticalScrollingOffset, BVw.Width, height).Contains(pt))
					{
						break;
					}
					num7 += height;
					num8++;
					continue;
				}
				return;
			}
			int num9 = num8;
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num2; j++)
				{
					BVw.Rows[j].Cells[i].Selected = (num9 == Bvk && j == num9) || (num9 > Bvk && j >= Bvk && j <= num9) || (num9 < Bvk && j >= num9 && j <= Bvk);
				}
			}
			return;
		}
		int num10 = num6;
		for (int k = 0; k < num2; k++)
		{
			for (int l = 0; l < num; l++)
			{
				BVw.Rows[k].Cells[l].Selected = (num10 == BvK && l == num10) || (num10 > BvK && l >= BvK && l <= num10) || (num10 < BvK && l >= num10 && l <= BvK);
			}
		}
	}

	private void BVw_MouseUp(object sender, MouseEventArgs e)
	{
		BvK = -1;
		Bvk = -1;
	}

	internal void method_28()
	{
		if (BKE == null)
		{
			return;
		}
		Bvg.Clear();
		if (Form23.enum60_0 == Form23.Enum60.BpG && BKd != null)
		{
			BvI = null;
			return;
		}
		int num = BKE.HorizAxisCount();
		int num2 = BKE.VertAxisCount();
		int num3 = BKE.SliceCount();
		BvI = new List<Struct10>[num3, num2, num];
		for (int i = 0; i < num3; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				for (int k = 0; k < num; k++)
				{
					BvI[i, j, k] = new List<Struct10>();
				}
			}
		}
	}

	private void method_29(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate18 method = method_29;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_28();
		method_19();
		UpdateLayout(resizingOnly: false);
		method_26();
		Invalidate();
	}

	private void method_30(object sender, EventArgs e)
	{
		if (BKE == null || (BKe != null && (BKi || BKJ) && Form23.enum60_0 == Form23.Enum60.BpF))
		{
			return;
		}
		Table table = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		try
		{
			using (Graphics graphics_ = CreateGraphics())
			{
				method_24(graphics_);
			}
			method_31(null, null);
		}
		catch
		{
		}
	}

	private void method_31(object sender, EventArgs e)
	{
		if (BVw.Rows.Count == 0 || BKE == null || (BKe != null && (BKi || BKJ) && Form23.enum60_0 == Form23.Enum60.BpF))
		{
			return;
		}
		Table table = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		int num = table.HorizAxisCount();
		int num2 = table.VertAxisCount();
		int num3 = table.SliceCount();
		if (!Form23.bool_52 && num2 == BVw.Rows.Count && num == BVw.Rows[0].Cells.Count)
		{
			int int_ = table.TableDataSetting.method_231();
			int num4 = 0;
			if (table.SlicesEnabled())
			{
				num4 = table.UserSliceIndex;
			}
			int num5 = int.MaxValue;
			int num6 = int.MinValue;
			for (int i = 0; i < num3; i++)
			{
				for (int j = 0; j < num2; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num7;
						if (Form23.enum60_0 == Form23.Enum60.BpF && BKe != null)
						{
							num7 = Class233.smethod_26(BKE.GetCellDifferenceDisplayValue(BKe, k, j, num4, out var _, out var _), int_);
						}
						else
						{
							num7 = ((!table.SwapColumnsAndRows) ? table.TableDataSetting.method_257(k, j, i) : table.TableDataSetting.method_257(j, k, i));
						}
						if (num7 > num6)
						{
							num6 = num7;
						}
						if (num7 < num5)
						{
							num5 = num7;
						}
					}
				}
			}
			int int_2 = Form23.int_45 * 255 / 100;
			int int_3 = Form23.int_44 * 255 / 100;
			int int_4 = Form23.int_46 * 255 / 100;
			int int_5 = Form23.int_47 * 255 / 100;
			for (int j = 0; j < num2; j++)
			{
				for (int k = 0; k < num; k++)
				{
					if (!BVw.method_14())
					{
						int num8 = 0;
						if (BKe != null)
						{
							num8 = ((!table.InvertRows) ? Class233.smethod_26(BKE.GetCellDifferenceDisplayValue(BKe, k, j, num4, out var _, out var _), int_) : Class233.smethod_26(BKE.GetCellDifferenceDisplayValue(BKe, k, num2 - 1 - j, num4, out var _, out var _), int_));
						}
						int int_6;
						if (Form23.enum60_0 == Form23.Enum60.BpF && BKe != null)
						{
							int_6 = num8;
							BVw.Rows[j].Cells[k].Value = Class233.smethod_29(int_6, int_);
						}
						else
						{
							table.GetColumnIndexAndRowIndex(k, j, out var columnIndex, out var rowIndex);
							int_6 = table.TableDataSetting.method_257(columnIndex, rowIndex, num4);
							BVw.Rows[j].Cells[k].Value = Class233.smethod_30(int_6, int_, Class233.smethod_1(int_));
						}
						Color backColor = method_25(int_6, num5, num6, int_2, int_3, int_4, int_5);
						DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
						dataGridViewCellStyle.BackColor = backColor;
						BVw.Rows[j].Cells[k].Style = dataGridViewCellStyle;
						bool bool_ = false;
						if (BKe != null)
						{
							bool_ = Class233.smethod_28(num8, int_) != 0.0;
						}
						bool bool_2 = method_27(table, int_, num2, j, k, num4);
						Class64 tag = new Class64(bool_, bool_2);
						BVw.Rows[j].Cells[k].Tag = tag;
					}
				}
			}
			if (BvG)
			{
				method_83();
			}
			method_82();
		}
		else
		{
			method_26();
		}
	}

	private void method_32(object sender, EventArgs e)
	{
		if (BVw != null && method_0())
		{
			Invalidate(new Rectangle(0, 0, Width, BVw.Top));
		}
	}

	private void method_33(object sender, EventArgs e)
	{
		Invalidate();
		if (BVw != null)
		{
			BVw.Invalidate();
		}
	}

	private void method_34(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate19 method = method_34;
				BeginInvoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_40();
		Invalidate();
		if (BVw != null)
		{
			BVw.Invalidate();
		}
	}

	private void method_35(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void Class104_Paint(object sender, PaintEventArgs e)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		if (BKE == null)
		{
			return;
		}
		Graphics graphics = e.Graphics;
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		float num = 0f;
		using (SolidBrush brush = new SolidBrush(Form23.color_14))
		{
			using Font font = new Font(Font.FontFamily, 10f, FontStyle.Bold);
			string text = BKE.method_18();
			string text2 = (string.IsNullOrWhiteSpace(text) ? BKE.method_60(Enum96.aYt) : text);
			if (Form23.enum60_0 == Form23.Enum60.BpF && BKe != null && (BKi || BKJ))
			{
				text2 += Class333.BfI();
			}
			num = graphics.MeasureString(text2, font).Width;
			if (BvB == null || BvB.method_219())
			{
				graphics.DrawString(text2, font, brush, 8f, 8f);
			}
		}
		if (BvC.Visible && (float)BvC.Left != num + 10f)
		{
			BvC.Left = (int)num + 10;
		}
		Color color = ((!BVw.Focused || !BKE.method_35()) ? Color.Gray : Form23.color_12);
		if (BVX != null && !string.IsNullOrEmpty(BKL))
		{
			using SolidBrush brush2 = new SolidBrush(color);
			using Font font2 = new Font(Font.FontFamily, 10f);
			int num2 = (BvC.Visible ? 70 : 30);
			graphics.DrawString(BKL, font2, brush2, num + (float)num2, 8f);
			num += (float)num2 + graphics.MeasureString(BKL, font2).Width;
		}
		using (SolidBrush solidBrush = new SolidBrush(color))
		{
			using Font font3 = new Font(Font.FontFamily, 10f);
			if (Form23.enum60_0 != Form23.Enum60.BpG)
			{
				int num3 = BKE.method_231();
				string text3 = string.Empty;
				if (num3 != 0 && num3 != 82)
				{
					text3 = Class333.smethod_325() + Class233.smethod_35(BKE.method_232(), num3, bool_0: false, 0);
				}
				if ((!Form23.smethod_28(BKD.aXc, bool_53: true) || Form23.smethod_80()) && !Form23.smethod_84(BKE.method_64()))
				{
					graphics.DrawString(Class333.BFs() + text3, font3, solidBrush, num + 60f, 8f);
				}
				else
				{
					(string, string, bool) tuple = BKE.method_252();
					graphics.DrawString(Class333.BFT() + tuple.Item1 + (tuple.Item3 ? string.Empty : text3), font3, solidBrush, num + 60f, 8f);
				}
				if (Bvi != string.Empty)
				{
					graphics.DrawString(Bvi, font3, solidBrush, num + 200f, 8f);
				}
			}
			method_37(graphics);
			if (BVY == 0 && BVZ == 0)
			{
				method_21(graphics);
			}
			Table table;
			Setting setting_;
			Setting setting_2;
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				table = BKe;
				setting_ = BKH;
				setting_2 = BKh;
			}
			else
			{
				table = BKE;
				setting_ = BKf;
				setting_2 = BKG;
			}
			if (table == null)
			{
				return;
			}
			method_36(graphics, font3, solidBrush, table, setting_2, setting_);
		}
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.Bfi(), stopwatch.ElapsedMilliseconds, Left, Top), bool_1: false);
	}

	private void method_36(Graphics graphics_0, Font font_0, Brush brush_0, Table table_0, Setting setting_0, Setting setting_1)
	{
		bool flag2;
		bool flag = (flag2 = table_0.VertAxisEnabled());
		if (BKe != null)
		{
			if (table_0 == BKE)
			{
				flag2 = BKe.VertAxisEnabled();
			}
			else if (table_0 == BKe)
			{
				flag2 = BKE.VertAxisEnabled();
			}
		}
		string text = null;
		bool flag3 = true;
		bool flag4 = true;
		if (flag && table_0.VertAxis.method_90() != null && setting_0 != null)
		{
			string text2 = string.Empty;
			int num = setting_0.method_231();
			if (num != 0 && num != 82)
			{
				text2 = Class333.smethod_497() + Class233.smethod_35(setting_0.method_232(), num, bool_0: false, 0) + Class333.smethod_9();
			}
			string text3 = setting_0.method_18();
			text = (string.IsNullOrWhiteSpace(text3) ? setting_0.method_60(Enum96.aYt) : text3);
			text += text2;
			flag3 = flag2 && (BKe == null || (BKh != null && BKh.method_64() == BKG.method_64()));
			if (BKk != null && BKK.method_88())
			{
				int num2 = ((!BKE.SwapColumnsAndRows) ? 1 : 2);
				flag4 = BKM[num2].Bvv && BKM[num2].BvW == setting_0.method_64();
			}
		}
		bool flag6;
		bool flag5 = (flag6 = table_0.HorizAxisEnabled());
		if (BKe != null)
		{
			if (table_0 == BKE)
			{
				flag6 = BKe.HorizAxisEnabled();
			}
			else if (table_0 == BKe)
			{
				flag6 = BKE.HorizAxisEnabled();
			}
		}
		string text4 = null;
		bool flag7 = true;
		bool flag8 = true;
		if (flag5 && table_0.HorizAxis.method_90() != null && setting_1 != null)
		{
			string text5 = string.Empty;
			int num3 = setting_1.method_231();
			if (num3 != 0 && num3 != 82)
			{
				text5 = Class333.smethod_497() + Class233.smethod_35(setting_1.method_232(), num3, bool_0: false, 0) + Class333.smethod_9();
			}
			string text6 = setting_1.method_18();
			text4 = (string.IsNullOrWhiteSpace(text6) ? setting_1.method_60(Enum96.aYt) : text6);
			text4 += text5;
			flag7 = flag6 && (BKe == null || (BKH != null && BKH.method_64() == BKf.method_64()));
			if (BKk != null && BKK.method_88())
			{
				int num4 = (BKE.SwapColumnsAndRows ? 1 : 2);
				flag8 = BKM[num4].Bvv && BKM[num4].BvW == setting_1.method_64();
			}
		}
		if (text != null)
		{
			Rectangle rectangle = new Rectangle(8, BVw.Top - BVx - 2, 140, BVx);
			Font font = (flag4 ? font_0 : new Font(font_0, FontStyle.Italic));
			if (!flag3 && !BKi && !BKJ)
			{
				using SolidBrush brush = new SolidBrush(Form23.color_9);
				graphics_0.DrawString(text, font, brush, rectangle);
			}
			else
			{
				graphics_0.DrawString(text, font, brush_0, rectangle);
			}
			if (!flag4)
			{
				font.Dispose();
			}
		}
		if (text4 == null)
		{
			return;
		}
		Rectangle rectangle2 = new Rectangle(BVz, BVw.Top - BVy - 2, BVZ, BVy);
		Font font2 = (flag8 ? font_0 : new Font(font_0, FontStyle.Italic));
		if (!flag7 && !BKi && !BKJ)
		{
			using SolidBrush brush2 = new SolidBrush(Form23.color_9);
			graphics_0.DrawString(text4, font2, brush2, rectangle2);
		}
		else
		{
			graphics_0.DrawString(text4, font2, brush_0, rectangle2);
		}
		if (!flag8)
		{
			font2.Dispose();
		}
	}

	private void method_37(Graphics graphics_0)
	{
		if (!BKE.ColumnAxisMonotonicityIsValid())
		{
			using (SolidBrush brush = new SolidBrush(Form23.color_7))
			{
				using Font font = new Font(Font.FontFamily, 8f, FontStyle.Bold);
				if (BKE.ColumnAxis.method_76() && BKE.ColumnAxis.method_78())
				{
					graphics_0.DrawString(Class333.BfJ(), font, brush, 8f, 25f);
				}
				else if (BKE.ColumnAxis.method_76())
				{
					graphics_0.DrawString(Class333.Bfj(), font, brush, 8f, 25f);
				}
				else if (BKE.ColumnAxis.method_78())
				{
					graphics_0.DrawString(Class333.BfK(), font, brush, 8f, 25f);
				}
				return;
			}
		}
		if (BKE.RowAxisMonotonicityIsValid())
		{
			return;
		}
		using SolidBrush brush2 = new SolidBrush(Form23.color_7);
		using Font font2 = new Font(Font.FontFamily, 8f, FontStyle.Bold);
		if (BKE.RowAxis.method_76() && BKE.RowAxis.method_78())
		{
			graphics_0.DrawString(Class333.BfJ(), font2, brush2, 8f, 25f);
		}
		else if (BKE.RowAxis.method_76())
		{
			graphics_0.DrawString(Class333.Bfj(), font2, brush2, 8f, 25f);
		}
		else if (BKE.RowAxis.method_78())
		{
			graphics_0.DrawString(Class333.BfK(), font2, brush2, 8f, 25f);
		}
	}

	private int method_38()
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return 0;
		}
		bool flag = BKE.VertAxisEnabled();
		int num = BKE.HorizAxisCount();
		int num2 = 0;
		if (flag)
		{
			num2 = BVw.RowHeadersWidth;
		}
		if (BKf != null && BKE.HorizAxisEnabled() && BVw.Columns.Count != 0 && num <= BVw.Columns.Count)
		{
			AxisBehaviour axisBehaviour = BKE.HorizAxis.method_93();
			int result = 0;
			int num3 = BKf.method_256();
			int num4 = BKE.HorizAxis.method_89().method_258(0);
			int num5 = BKE.HorizAxis.method_89().method_258(num - 1);
			int num6 = num2;
			for (int i = 0; i < num - 1; i++)
			{
				num6 += BVw.Columns[i].Width;
			}
			if (num3 >= num5)
			{
				if (num <= BVw.Columns.Count)
				{
					result = num6 + BVw.Columns[num - 1].Width / 2;
				}
			}
			else if (num3 <= num4)
			{
				result = num2 + BVw.Columns[0].Width / 2;
			}
			else
			{
				switch (axisBehaviour)
				{
				case AxisBehaviour.DiscreteCentred:
				{
					for (int k = 1; k < num; k++)
					{
						int num16 = BKE.HorizAxis.method_89().method_258(k - 1);
						int num17 = BKE.HorizAxis.method_89().method_258(k);
						int num18 = num16 + num17 >> 1;
						if (num3 == num16 || num3 < num18 || k == num - 1)
						{
							int num19 = ((num3 == num16 || num3 < num18) ? (k - 1) : k);
							int num20 = num2;
							for (int l = 0; l < num19; l++)
							{
								num20 += BVw.Columns[l].Width;
							}
							result = num20 + BVw.Columns[num19].Width / 2;
							break;
						}
					}
					break;
				}
				case AxisBehaviour.Continuous:
				{
					int num7 = 0;
					int num8 = num - 1;
					while (num8 >= 0)
					{
						int num9 = BKE.HorizAxis.method_89().method_258(num8);
						if (num3 < num9)
						{
							num8--;
							continue;
						}
						num7 = num8;
						break;
					}
					if (num7 == num - 1)
					{
						num7--;
					}
					int num10 = BKE.HorizAxis.method_89().method_258(num7);
					int num11 = BKE.HorizAxis.method_89().method_258(num7 + 1);
					int num12 = num2;
					for (int j = 0; j < num7; j++)
					{
						num12 += BVw.Columns[j].Width;
					}
					float num13 = (float)(num10 + num11) / 2f;
					if ((float)num3 <= num13)
					{
						int num14 = BVw.Columns[num7].Width / 2;
						result = num12 + num14 + (int)((float)(num14 * (num3 - num10)) / (num13 - (float)num10));
					}
					else
					{
						int num15 = BVw.Columns[num7 + 1].Width / 2;
						result = num12 + BVw.Columns[num7].Width + (int)((float)num15 * ((float)num3 - num13) / ((float)num11 - num13));
					}
					break;
				}
				}
			}
			return result;
		}
		return num2 + 24;
	}

	private int method_39()
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return 0;
		}
		bool flag = BKE.HorizAxisEnabled();
		int num = BKE.VertAxisCount();
		int num2 = 0;
		if (flag)
		{
			num2 = BVw.ColumnHeadersHeight;
		}
		if (BKG != null && BKE.VertAxisEnabled() && BVw.Rows.Count != 0 && num <= BVw.Rows.Count)
		{
			AxisBehaviour axisBehaviour = BKE.VertAxis.method_93();
			int result = 0;
			int num3 = BKG.method_256();
			int num4 = BKE.VertAxis.method_89().method_258(0);
			int num5 = BKE.VertAxis.method_89().method_258(num - 1);
			int num6 = num2;
			for (int i = 0; i < num - 1; i++)
			{
				num6 += BVw.Rows[i].Height;
			}
			if (num3 >= num5)
			{
				if (BKE.InvertRows)
				{
					result = num2 + BVw.Rows[0].Height / 2;
				}
				else if (num <= BVw.Rows.Count)
				{
					result = num6 + BVw.Rows[num - 1].Height / 2;
				}
			}
			else if (num3 <= num4)
			{
				if (BKE.InvertRows && num <= BVw.Rows.Count)
				{
					result = num6 + BVw.Rows[num - 1].Height / 2;
				}
				else if (!BKE.InvertRows)
				{
					result = num2 + BVw.Rows[0].Height / 2;
				}
			}
			else
			{
				switch (axisBehaviour)
				{
				case AxisBehaviour.DiscreteCentred:
				{
					for (int l = 1; l < num; l++)
					{
						int num20 = BKE.VertAxis.method_89().method_258(l - 1);
						int num21 = BKE.VertAxis.method_89().method_258(l);
						int num22 = num20 + num21 >> 1;
						if (num3 != num20 && num3 >= num22 && l != num - 1)
						{
							continue;
						}
						int num23 = ((num3 == num20 || num3 < num22) ? (l - 1) : l);
						if (BKE.InvertRows)
						{
							int num24 = num2;
							int num25 = 0;
							for (int m = 0; m < num; m++)
							{
								num24 += BVw.Rows[m].Height;
								if (m < num23)
								{
									num25 += BVw.Rows[num - 1 - m].Height;
								}
							}
							result = num24 - (num25 + BVw.Rows[num23].Height / 2);
						}
						else
						{
							int num26 = num2;
							for (int n = 0; n < num23; n++)
							{
								num26 += BVw.Rows[n].Height;
							}
							result = num26 + BVw.Rows[num23].Height / 2;
						}
						break;
					}
					break;
				}
				case AxisBehaviour.Continuous:
				{
					int num7 = 0;
					int num8 = num - 1;
					while (num8 >= 0)
					{
						int num9 = BKE.VertAxis.method_89().method_258(num8);
						if (num3 < num9)
						{
							num8--;
							continue;
						}
						num7 = num8;
						break;
					}
					if (num7 == num - 1)
					{
						num7--;
					}
					int num10 = BKE.VertAxis.method_89().method_258(num7);
					int num11 = BKE.VertAxis.method_89().method_258(num7 + 1);
					float num12 = (float)(num10 + num11) / 2f;
					if (BKE.InvertRows)
					{
						int num13 = num2;
						int num14 = 0;
						for (int j = 0; j < num; j++)
						{
							num13 += BVw.Rows[j].Height;
							if (j < num7)
							{
								num14 += BVw.Rows[num - 1 - j].Height;
							}
						}
						if ((float)num3 <= num12)
						{
							int num15 = BVw.Rows[num7].Height / 2;
							result = num13 - (num14 + num15 + (int)((float)(num15 * (num3 - num10)) / (num12 - (float)num10)));
						}
						else
						{
							int num16 = BVw.Rows[num7 + 1].Height / 2;
							result = num13 - (num14 + BVw.Rows[num7].Height + (int)((float)num16 * ((float)num3 - num12) / ((float)num11 - num12)));
						}
					}
					else
					{
						int num17 = num2;
						for (int k = 0; k < num7; k++)
						{
							num17 += BVw.Rows[k].Height;
						}
						if ((float)num3 <= num12)
						{
							int num18 = BVw.Rows[num7].Height / 2;
							result = num17 + num18 + (int)((float)(num18 * (num3 - num10)) / (num12 - (float)num10));
						}
						else
						{
							int num19 = BVw.Rows[num7 + 1].Height / 2;
							result = num17 + BVw.Rows[num7].Height + (int)((float)num19 * ((float)num3 - num12) / ((float)num11 - num12));
						}
					}
					break;
				}
				}
			}
			return result;
		}
		return num2 + 8;
	}

	internal void method_40()
	{
		if (!method_0() || BVw == null || BVw.Rows.Count == 0 || BVw.Columns.Count == 0 || Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		try
		{
			if ((Form23.smethod_28(BKD.aXc, bool_53: true) && !Form23.smethod_80()) || (BKf != null && Form23.smethod_84(BKf.method_64()) && BKG != null && Form23.smethod_84(BKG.method_64())))
			{
				bool baP = BKE.HorizAxisEnabled();
				bool bar = BKE.VertAxisEnabled();
				int bas = BKE.HorizAxisCount();
				int baR = BKE.VertAxisCount();
				int baQ = 0;
				if (bar)
				{
					baQ = BVw.RowHeadersWidth;
				}
				int baq = 0;
				if (baP)
				{
					baq = BVw.ColumnHeadersHeight;
				}
				int bap = method_38() - BVw.HorizontalScrollingOffset;
				Bvc.Invoke(() =>
				{
					if (baP && BKf != null)
					{
						if (Bve == Enum69.const_1)
						{
							Bvc.BringToFront();
							Bvc.Left = BVw.Left + bap;
							if (Bvc.Left >= BVw.Left + baQ && Bvc.Left <= BVw.Right)
							{
								Bvc.Visible = true;
							}
							else
							{
								Bvc.Visible = false;
							}
							Bvc.Top = BVw.Top;
							int num9 = baq;
							for (int i = 0; i < baR; i++)
							{
								num9 += BVw.Rows[i].Height;
							}
							if (BVw.method_7() && num9 > BVw.Height - 18)
							{
								Bvc.Height = Math.Min(BVw.Height, num9) - 18;
							}
							else
							{
								Bvc.Height = Math.Min(BVw.Height, num9);
							}
						}
						else
						{
							Bvc.Visible = false;
						}
					}
					else
					{
						Bvc.Visible = false;
					}
				});
				int baS = method_39() - BVw.VerticalScrollingOffset;
				BvD.Invoke(() =>
				{
					if (bar && BKG != null)
					{
						if (Bve == Enum69.const_1)
						{
							BvD.BringToFront();
							BvD.Top = BVw.Top + baS;
							if (BvD.Top >= BVw.Top + baq && BvD.Top <= BVw.Bottom)
							{
								BvD.Visible = true;
							}
							else
							{
								BvD.Visible = false;
							}
							BvD.Left = BVw.Left;
							int num9 = baQ;
							for (int i = 0; i < bas; i++)
							{
								num9 += BVw.Columns[i].Width;
							}
							if (BVw.method_8() && num9 > BVw.Width - 18)
							{
								BvD.Width = Math.Min(BVw.Width, num9) - 18;
							}
							else
							{
								BvD.Width = Math.Min(BVw.Width, num9);
							}
						}
						else
						{
							BvD.Visible = false;
						}
					}
					else
					{
						BvD.Visible = false;
					}
				});
				if (Bve == Enum69.const_2 || Bve == Enum69.const_3 || Bve == Enum69.const_0)
				{
					if (baP && BKf != null)
					{
						int num = Math.Min(bap, BvH) - 20;
						int num2 = Math.Max(bap, BvH) + 20;
						Rectangle rc = new Rectangle(num, 0, num2 - num, 10);
						BVw.Invalidate(rc);
					}
					if (bar && BKG != null)
					{
						int num3 = Math.Min(baS, Bvh) - 20;
						int num4 = Math.Max(baS, Bvh) + 20;
						Rectangle rc2 = new Rectangle(0, num3, 10, num4 - num3);
						BVw.Invalidate(rc2);
					}
				}
				if (Bve == Enum69.const_2 || Bve == Enum69.const_3 || Bve == Enum69.const_0 || ((((BvG & baP) && BKf != null) & bar) && BKG != null))
				{
					if (BvH == 0 && Bvh == 0)
					{
						BVw.Invalidate();
					}
					else
					{
						int num5 = Math.Min(bap, BvH) - 28;
						int num6 = Math.Max(bap, BvH) + 28;
						int num7 = Math.Min(baS, Bvh) - 12;
						int num8 = Math.Max(baS, Bvh) + 12;
						Rectangle rc3 = new Rectangle(num5, num7, num6 - num5, num8 - num7);
						BVw.Invalidate(rc3);
					}
					BvH = bap;
					Bvh = baS;
				}
				if (BvJ && !BVw.method_14())
				{
					method_90();
				}
			}
			else
			{
				Bvc.Invoke(() =>
				{
					Bvc.Visible = false;
				});
				BvD.Invoke(() =>
				{
					BvD.Visible = false;
				});
				if (BvG)
				{
					BVw.Invalidate();
				}
			}
			BKj.Invalidate();
		}
		catch
		{
		}
	}

	private void BVw_CurrentCellChanged(object sender, EventArgs e)
	{
		if (BVw.CurrentCell != null)
		{
			BKE.UserCurrentCellHorizVertIndex = new Point(BVw.CurrentCell.ColumnIndex, BVw.CurrentCell.RowIndex);
		}
		else
		{
			BKE.UserCurrentCellHorizVertIndex = new Point(-1, -1);
		}
	}

	private void BVw_SelectionChanged(object sender, EventArgs e)
	{
		if (!BvL)
		{
			return;
		}
		List<Point> list = new List<Point>();
		if (BVw.SelectedCells != null && BVw.SelectedCells.Count != 0)
		{
			foreach (DataGridViewCell selectedCell in BVw.SelectedCells)
			{
				list.Add(new Point(selectedCell.ColumnIndex, selectedCell.RowIndex));
			}
		}
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			BKe.HorizVertIndexPerUserSelectedCell = list;
			BKE.HorizVertIndexPerUserSelectedCell = list;
			return;
		}
		BKE.HorizVertIndexPerUserSelectedCell = list;
		if (BKe != null)
		{
			BKe.HorizVertIndexPerUserSelectedCell = list;
		}
	}

	private void method_41(object sender, EventArgs e)
	{
		Table table = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		method_42(table);
		method_43(table);
		if (table.HorizVertIndexPerUserSelectedCell.Count != 0)
		{
			foreach (Point item2 in table.HorizVertIndexPerUserSelectedCell)
			{
				if (item2.X < BVw.Columns.Count)
				{
					BVw.Columns[item2.X].HeaderCell.Style.BackColor = Color.DarkSeaGreen;
				}
				if (item2.Y < BVw.Rows.Count)
				{
					BVw.Rows[item2.Y].HeaderCell.Style.BackColor = Color.PaleVioletRed;
				}
			}
		}
		List<DataGridViewCell> list = new List<DataGridViewCell>();
		foreach (Point item3 in BKE.HorizVertIndexPerUserSelectedCell)
		{
			list.Add(BVw.Rows[item3.Y].Cells[item3.X]);
		}
		bool flag = false;
		if (list.Count != BVw.SelectedCells.Count)
		{
			flag = true;
		}
		else
		{
			foreach (DataGridViewCell item4 in list)
			{
				if (!BVw.SelectedCells.Contains(item4))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				foreach (DataGridViewCell selectedCell in BVw.SelectedCells)
				{
					if (!list.Contains(selectedCell))
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
			if (BKE.UserCurrentCellHorizVertIndex.X != -1 && BKE.UserCurrentCellHorizVertIndex.Y != -1 && (BVw.CurrentCell == null || BKE.UserCurrentCellHorizVertIndex.X != BVw.CurrentCell.ColumnIndex || BKE.UserCurrentCellHorizVertIndex.Y != BVw.CurrentCell.RowIndex))
			{
				BVw.CurrentCell = BVw.Rows[BKE.UserCurrentCellHorizVertIndex.Y].Cells[BKE.UserCurrentCellHorizVertIndex.X];
			}
			foreach (DataGridViewCell item5 in list)
			{
				BVw.Rows[item5.RowIndex].Cells[item5.ColumnIndex].Selected = true;
			}
			foreach (DataGridViewCell selectedCell2 in BVw.SelectedCells)
			{
				if (!list.Contains(selectedCell2))
				{
					selectedCell2.Selected = false;
				}
			}
			BvL = true;
		}
		method_82();
	}

	private void method_42(Table table_0)
	{
		int num = 0;
		if (BKf != null && BKe != null)
		{
			num = BKf.method_231();
		}
		for (int i = 0; i < BVw.Columns.Count; i++)
		{
			if (table_0.HorizAxis != null && table_0.HorizAxis.method_89() != null)
			{
				if (!BKi && !BKJ)
				{
					int int_ = table_0.HorizAxis.method_89().method_258(i);
					if (BKe != null)
					{
						string string_ = Class233.smethod_29(int_, num);
						if (table_0 == BKE && BKe.HorizAxis.method_96(int_, string_, num) == -1)
						{
							BVw.Columns[i].HeaderCell.Style.BackColor = Form23.color_9;
						}
						else if (table_0 == BKe && BKE.HorizAxis.method_96(int_, string_, num) == -1)
						{
							BVw.Columns[i].HeaderCell.Style.BackColor = Form23.color_9;
						}
						else
						{
							BVw.Columns[i].HeaderCell.Style.BackColor = method_22(int_, BKf);
						}
					}
					else
					{
						BVw.Columns[i].HeaderCell.Style.BackColor = method_22(int_, BKf);
					}
				}
				else
				{
					BVw.Columns[i].HeaderCell.Style.BackColor = BVw.BackgroundColor;
				}
			}
			else
			{
				BVw.Columns[i].HeaderCell.Style.BackColor = BVw.BackgroundColor;
			}
		}
	}

	private void method_43(Table table_0)
	{
		int num = table_0.VertAxisCount();
		int num2 = 0;
		if (BKG != null && BKe != null)
		{
			num2 = BKG.method_231();
		}
		for (int i = 0; i < BVw.Rows.Count; i++)
		{
			if (table_0.VertAxis != null && table_0.VertAxis.method_89() != null)
			{
				if (!BKi && !BKJ)
				{
					int int_ = ((!table_0.InvertRows) ? table_0.VertAxis.method_89().method_258(i) : table_0.VertAxis.method_89().method_258(num - 1 - i));
					if (BKe != null)
					{
						string string_ = Class233.smethod_29(int_, num2);
						if (table_0 == BKE && BKe.VertAxis.method_96(int_, string_, num2) == -1)
						{
							BVw.Rows[i].HeaderCell.Style.BackColor = Form23.color_9;
						}
						else if (table_0 == BKe && BKE.VertAxis.method_96(int_, string_, num2) == -1)
						{
							BVw.Rows[i].HeaderCell.Style.BackColor = Form23.color_9;
						}
						else
						{
							BVw.Rows[i].HeaderCell.Style.BackColor = method_22(int_, BKG);
						}
					}
					else
					{
						BVw.Rows[i].HeaderCell.Style.BackColor = method_22(int_, BKG);
					}
				}
				else
				{
					BVw.Rows[i].HeaderCell.Style.BackColor = BVw.BackgroundColor;
				}
			}
			else
			{
				BVw.Rows[i].HeaderCell.Style.BackColor = BVw.BackgroundColor;
			}
		}
	}

	private void Bvl_Click(object sender, EventArgs e)
	{
		Enum65 @enum = (Form23.form23_0.control25_0.SelectedTab as Class130).method_0();
		int selectedIndex = Form23.form23_0.control25_0.SelectedIndex;
		if (@enum != Enum65.const_1 && Form23.form23_0.control25_0.method_5(selectedIndex) == this)
		{
			Form54.smethod_6(Form23.form23_0, Class333.Bfk(), Class333.BfL(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		Class30.smethod_0(this);
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_44(object sender, EventArgs e)
	{
		int num = Form46.smethod_0(Form23.form23_0, BKD);
		if (num != 0)
		{
			Setting setting = BKD.method_31(num);
			if (setting != null)
			{
				Form23.form23_0.control25_0.method_39(setting as Table, new Rectangle(Left, Top, Width, Height));
				Bvl_Click(null, null);
			}
		}
	}

	private void method_45(object sender, EventArgs e)
	{
		Form23.form23_0.control25_0.method_37(this);
	}

	internal override void vmethod_3(object sender, EventArgs e)
	{
		if (Form23.enum60_0 != Form23.Enum60.BpG && BKD.method_4() && BKE != null && BKE.method_35())
		{
			Form51 form = new Form51(BKE);
			if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
			{
				method_46();
			}
			form.Dispose();
		}
	}

	private void method_46()
	{
		HashSet<DataIdAndAttrId> idsContained = BKE.GetIdsContained();
		BKD.method_42(idsContained);
		BKD.method_40(idsContained, BKd, Form23.hashSet_0);
		BKD.method_38(idsContained);
		Form23.form23_0.control4_0.method_14(bool_7: false, bool_8: true, bool_9: false, bool_10: false);
		Form23.smethod_43();
		Form23.form23_0.control4_0.method_39(bool_7: false);
		if (Form23.framework_0 != null)
		{
			Form23.form23_0.control4_0.method_40(bool_7: false);
		}
		method_28();
		method_19();
		UpdateLayout(resizingOnly: false);
		method_26();
		method_13();
	}

	private void method_47(object sender, EventArgs e)
	{
		if (BKD.method_4() && Form23.framework_0 == null && BKE != null)
		{
			BKE.method_299();
		}
	}

	private void method_48(object sender, EventArgs e)
	{
		if (!BKD.method_4() || Form23.framework_0 != null || BKE == null)
		{
			return;
		}
		Table.Class274 @class = BKE.method_300();
		if (@class != null)
		{
			if (BKE.method_301(@class, out var string_))
			{
				Class280 class2 = Form23.smethod_95();
				class2?.method_2(BKE.method_64());
				BKE.method_302(@class);
				if (BKE.method_0().awo != null)
				{
					BKE.method_0().awo.method_1(BKE.method_64());
				}
				class2?.method_4();
				method_46();
				Invalidate();
			}
			else if (!string.IsNullOrWhiteSpace(string_))
			{
				Form54.smethod_6(Form23.form23_0, string_, Class333.Bfl(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		else
		{
			Form54.smethod_6(Form23.form23_0, Class333.BfM(), Class333.Bfl(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_49(object sender, EventArgs e)
	{
		if (BKD.method_4() && Form23.framework_0 == null && BKE != null)
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_2(BKE.method_64());
			BKE.method_306(bool_0: true);
			if (BKE.method_0().awo != null)
			{
				BKE.method_0().awo.method_1(BKE.method_64());
			}
			@class?.method_4();
			method_46();
			Invalidate();
		}
	}

	private void BvM_Click(object sender, EventArgs e)
	{
		if (BKE == null || !BKE.method_35())
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

	private void Bvm_Click(object sender, EventArgs e)
	{
		if (BKE == null || !BKE.method_35())
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

	private void method_50(object sender, EventArgs e)
	{
		method_28();
		method_19();
		UpdateLayout(resizingOnly: false);
		method_26();
		Invalidate();
		Form23.bool_3 = true;
	}

	private void method_51(object sender, EventArgs e)
	{
		method_28();
		method_19();
		UpdateLayout(resizingOnly: false);
		method_26();
		Invalidate();
		Form23.bool_3 = true;
	}

	private void BvN_Click(object sender, EventArgs e)
	{
		if (BKE != null)
		{
			int num = BKE.TableDataSetting.method_231();
			int num2 = Class233.smethod_1(num);
			if (num2 == -1)
			{
				num2 = Class233.smethod_39(num);
			}
			if (num2 > 0)
			{
				Class233.smethod_4(num, num2 - 1);
			}
		}
	}

	private void Bvn_Click(object sender, EventArgs e)
	{
		if (BKE != null)
		{
			int num = BKE.TableDataSetting.method_231();
			int num2 = Class233.smethod_1(num);
			if (num2 == -1)
			{
				num2 = Class233.smethod_39(num);
			}
			if (num2 < 4)
			{
				Class233.smethod_4(num, num2 + 1);
			}
		}
	}

	private void method_52(object sender, EventArgs e)
	{
		Font font = new Font(Font.FontFamily, Bvd);
		int num = BKE.method_229();
		int num2 = BKE.TableDataSetting.method_231();
		string text = Class233.smethod_30(num, num2, Class233.smethod_1(num2));
		int width;
		using (Graphics dc = CreateGraphics())
		{
			width = TextRenderer.MeasureText(dc, text, font).Width;
		}
		bool flag = false;
		for (int i = 0; i < BVw.Columns.Count; i++)
		{
			if (BVw.Columns[i].Width < width + 5)
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			method_26();
		}
		else
		{
			method_31(sender, e);
		}
	}

	private void method_53(ref int int_3)
	{
		if (BKE.AllCellsOnFirstColumnMustBeZero && int_3 != 0)
		{
			if (BKE.ColumnAxis != null && BKE.ColumnAxis.method_92() != null)
			{
				Form54.smethod_6(Form23.form23_0, Class333.Bfm() + BKE.ColumnAxis.method_92().method_60(Enum96.aYt) + Class333.BfN(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			int_3 = 0;
		}
	}

	private void method_54(ref int int_3)
	{
		if (BKE.AllCellsOnFirstRowMustBeZero && int_3 != 0)
		{
			if (BKE.RowAxis != null && BKE.RowAxis.method_92() != null)
			{
				Form54.smethod_6(Form23.form23_0, Class333.Bfm() + BKE.RowAxis.method_92().method_60(Enum96.aYt) + Class333.BfN(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			int_3 = 0;
		}
	}

	private void method_55(string string_0, Class63 class63_0)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4() || (BKe != null && (BKi || BKJ) && Form23.enum60_0 == Form23.Enum60.BpF))
		{
			return;
		}
		try
		{
			int int_ = BKE.TableDataSetting.method_231();
			double double_ = double.Parse(string_0, NumberStyles.Any, CultureInfo.CurrentCulture);
			int num = 0;
			if (BKE.SlicesEnabled())
			{
				num = BKE.UserSliceIndex;
			}
			int num2 = BKE.HorizAxisCount();
			int num3 = BKE.VertAxisCount();
			for (int i = 0; i < num3; i++)
			{
				for (int j = 0; j < num2; j++)
				{
					if (!BVw.Rows[i].Cells[j].Selected)
					{
						continue;
					}
					BKE.GetColumnIndexAndRowIndex(j, i, out var columnIndex, out var rowIndex);
					int num4 = 0;
					if (Form23.enum60_0 == Form23.Enum60.BpF && BKe != null)
					{
						double num5;
						double num6;
						if (BKE.InvertRows)
						{
							double cellDifferenceDisplayValue = BKE.GetCellDifferenceDisplayValue(BKe, j, num3 - 1 - i, num, out var _, out var compareTableRawCellValue);
							num5 = method_56(BKE, cellDifferenceDisplayValue, double_, class63_0, int_);
							num6 = Class233.smethod_28(compareTableRawCellValue, int_);
						}
						else
						{
							double cellDifferenceDisplayValue = BKE.GetCellDifferenceDisplayValue(BKe, j, i, num, out var _, out var compareTableRawCellValue2);
							num5 = method_56(BKE, cellDifferenceDisplayValue, double_, class63_0, int_);
							num6 = Class233.smethod_28(compareTableRawCellValue2, int_);
						}
						num4 = Class233.smethod_26(num6 + num5, int_);
					}
					else
					{
						double double_2 = Class233.smethod_28(BKE.TableDataSetting.method_257(columnIndex, rowIndex, num), int_);
						num4 = Class233.smethod_26(method_56(BKE, double_2, double_, class63_0, int_), int_);
					}
					if (columnIndex == 0)
					{
						method_53(ref num4);
					}
					if (rowIndex == 0)
					{
						method_54(ref num4);
					}
					BKE.TableDataSetting.method_273(columnIndex, rowIndex, num, num4, bool_0: true);
					if (BvI != null)
					{
						BvI[num, i, j].Clear();
					}
					if (BKD.awo != null)
					{
						Setting setting = BKD.awo.method_2(BKE.method_64());
						if (setting != null && setting.method_256() == rowIndex)
						{
							BKD.awo.method_1(BKE.method_64());
						}
					}
				}
			}
		}
		catch (Exception)
		{
			if (Form23.enum60_0 == Form23.Enum60.BpF && BKe != null)
			{
				Form54.smethod_6(Form23.form23_0, string.Format(Class333.Bcb(), string_0), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			method_31(null, null);
		}
	}

	private double method_56(Table table_0, double double_0, double double_1, Class63 class63_0, int int_3)
	{
		if (class63_0.baM != Enum32.baj && BKD.method_4())
		{
			int num = table_0.method_228();
			int num2 = table_0.method_229();
			double val = Class233.smethod_28(num, int_3);
			double val2 = Class233.smethod_28(num2, int_3);
			double val3 = 0.0;
			try
			{
				if (class63_0.bam)
				{
					double num3 = double_0 * (double_1 / 100.0);
					if (class63_0.baM == Enum32.baK)
					{
						val3 = double_0 + num3;
					}
					else if (class63_0.baM == Enum32.bak)
					{
						val3 = double_0 - num3;
					}
					else if (class63_0.baM == Enum32.baL)
					{
						val3 = double_0 * num3;
					}
					else if (class63_0.baM == Enum32.bal)
					{
						if (num3 == 0.0)
						{
							throw new Exception();
						}
						val3 = double_0 / num3;
					}
				}
				else if (class63_0.baM == Enum32.baK)
				{
					val3 = double_0 + double_1;
				}
				else if (class63_0.baM == Enum32.bak)
				{
					val3 = double_0 - double_1;
				}
				else if (class63_0.baM == Enum32.baL)
				{
					val3 = double_0 * double_1;
				}
				else if (class63_0.baM == Enum32.bal)
				{
					if (double_1 == 0.0)
					{
						throw new Exception();
					}
					val3 = double_0 / double_1;
				}
			}
			catch
			{
				return double_1;
			}
			return Math.Min(val2, Math.Max(val, val3));
		}
		return double_1;
	}

	private void BvO_Click(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4() || !BKE.method_35() || (BKe != null && (BKi || BKJ) && Form23.enum60_0 == Form23.Enum60.BpF))
		{
			return;
		}
		Form33 form = new Form33();
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			float num = form.method_0();
			float num2 = 1f + num / 100f;
			int num3 = BKE.method_228();
			int num4 = BKE.method_229();
			int num5 = BKE.TableDataSetting.method_231();
			int num6 = 0;
			if (BKE.SlicesEnabled())
			{
				num6 = BKE.UserSliceIndex;
			}
			int num7 = BKE.HorizAxisCount();
			int num8 = BKE.VertAxisCount();
			Class280 @class = Form23.smethod_95();
			@class?.method_2(BKE.TableDataSetting.method_64());
			BKE.TableDataSetting.method_268();
			for (int i = 0; i < num8; i++)
			{
				for (int j = 0; j < num7; j++)
				{
					if (!BVw.Rows[i].Cells[j].Selected)
					{
						continue;
					}
					BKE.GetColumnIndexAndRowIndex(j, i, out var columnIndex, out var rowIndex);
					int int_;
					if (Form23.enum60_0 == Form23.Enum60.BpF && BKe != null)
					{
						double num9;
						double num10;
						if (BKE.InvertRows)
						{
							num9 = (double)num2 * BKE.GetCellDifferenceDisplayValue(BKe, j, num8 - 1 - i, num6, out var _, out var compareTableRawCellValue);
							num10 = Class233.smethod_28(compareTableRawCellValue, num5);
						}
						else
						{
							num9 = (double)num2 * BKE.GetCellDifferenceDisplayValue(BKe, j, i, num6, out var _, out var compareTableRawCellValue2);
							num10 = Class233.smethod_28(compareTableRawCellValue2, num5);
						}
						int_ = Class233.smethod_26(num10 + num9, num5);
					}
					else
					{
						int_ = Class233.smethod_26(Class233.smethod_28(BKE.TableDataSetting.method_257(columnIndex, rowIndex, num6), num5) * (double)num2, num5);
					}
					if (num3 != 0 || num4 != 0)
					{
						int_ = Math.Min(Math.Max(int_, num3), num4);
					}
					if (columnIndex == 0)
					{
						method_53(ref int_);
					}
					if (rowIndex == 0)
					{
						method_54(ref int_);
					}
					BKE.TableDataSetting.method_273(columnIndex, rowIndex, num6, int_, bool_0: true);
					if (BvI != null)
					{
						BvI[num6, i, j].Clear();
					}
					if (BKD.awo != null)
					{
						Setting setting = BKD.awo.method_2(BKE.method_64());
						if (setting != null && setting.method_256() == rowIndex)
						{
							BKD.awo.method_1(BKE.method_64());
						}
					}
				}
			}
			BKE.TableDataSetting.method_267(bool_0: true);
			@class?.method_4();
			Form23.smethod_74(BKE.TableDataSetting.method_64());
		}
		form.Dispose();
	}

	private void Bvo_Click(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4() || !BKE.method_35())
		{
			return;
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_2(BKE.TableDataSetting.method_64());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == bottomSelectedVert)
		{
			if (rightSelectedHoriz - leftSelectedHoriz + 1 >= 3)
			{
				BKE.TableDataSetting.method_268();
				BKE.LineariseLeftToRight(topSelectedVert, leftSelectedHoriz, rightSelectedHoriz, BKe, forHorizAxisInsertion: false);
				BKE.TableDataSetting.method_267(bool_0: true);
			}
		}
		else if (leftSelectedHoriz == rightSelectedHoriz)
		{
			if (bottomSelectedVert - topSelectedVert + 1 >= 3)
			{
				BKE.TableDataSetting.method_268();
				BKE.LineariseTopToBottom(leftSelectedHoriz, topSelectedVert, bottomSelectedVert, BKe);
				BKE.TableDataSetting.method_267(bool_0: true);
			}
		}
		else
		{
			BKE.TableDataSetting.method_268();
			BKE.LineariseRange(leftSelectedHoriz, rightSelectedHoriz, topSelectedVert, bottomSelectedVert, BKe);
			BKE.TableDataSetting.method_267(bool_0: true);
		}
		@class?.method_4();
		Form23.smethod_74(BKE.TableDataSetting.method_64());
	}

	private void BvP_Click(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4() || !BKE.method_35())
		{
			return;
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_2(BKE.TableDataSetting.method_64());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (rightSelectedHoriz - leftSelectedHoriz + 1 >= 3)
		{
			BKE.TableDataSetting.method_268();
			for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
			{
				BKE.LineariseLeftToRight(i, leftSelectedHoriz, rightSelectedHoriz, BKe, forHorizAxisInsertion: false);
			}
			BKE.TableDataSetting.method_267(bool_0: true);
		}
		@class?.method_4();
		Form23.smethod_74(BKE.TableDataSetting.method_64());
	}

	private void Bvp_Click(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4() || !BKE.method_35())
		{
			return;
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_2(BKE.TableDataSetting.method_64());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (bottomSelectedVert - topSelectedVert + 1 >= 3)
		{
			BKE.TableDataSetting.method_268();
			for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
			{
				BKE.LineariseTopToBottom(i, topSelectedVert, bottomSelectedVert, BKe);
			}
			BKE.TableDataSetting.method_267(bool_0: true);
		}
		@class?.method_4();
		Form23.smethod_74(BKE.TableDataSetting.method_64());
	}

	private ContextMenuStrip method_57()
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		contextMenuStrip.BackColor = Form23.color_15;
		contextMenuStrip.ForeColor = Form23.color_12;
		if ((Form23.form23_0.control25_0.SelectedTab as Class130).method_0() == Enum65.const_1)
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem.Text = Class333.BFV();
			toolStripMenuItem.Click += method_44;
			contextMenuStrip.Items.Add(toolStripMenuItem);
		}
		ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripMenuItem2.Text = Class333.smethod_1286();
		toolStripMenuItem2.ShortcutKeyDisplayString = Class333.smethod_1285();
		toolStripMenuItem2.Click += method_45;
		contextMenuStrip.Items.Add(toolStripMenuItem2);
		Bvl.Text = Class333.Bfn();
		Bvl.Click += Bvl_Click;
		contextMenuStrip.Items.Add(Bvl);
		if (BKD.method_4())
		{
			ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
			toolStripMenuItem3.Text = Class333.smethod_1570();
			toolStripMenuItem3.ShortcutKeys = Keys.F3;
			toolStripMenuItem3.Click += vmethod_3;
			contextMenuStrip.Items.Add(toolStripMenuItem3);
			ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem();
			toolStripMenuItem4.Text = Class333.BfO();
			toolStripMenuItem4.Click += method_47;
			contextMenuStrip.Items.Add(toolStripMenuItem4);
			ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem();
			toolStripMenuItem5.Text = Class333.Bfo();
			toolStripMenuItem5.Click += method_48;
			contextMenuStrip.Items.Add(toolStripMenuItem5);
			ToolStripMenuItem toolStripMenuItem6 = new ToolStripMenuItem();
			toolStripMenuItem6.Text = Class333.BfP();
			toolStripMenuItem6.Click += method_49;
			contextMenuStrip.Items.Add(toolStripMenuItem6);
		}
		BvM.Text = Class333.Bfp();
		BvM.Click += BvM_Click;
		contextMenuStrip.Items.Add(BvM);
		Bvm.Text = Class333.BfQ();
		Bvm.Click += Bvm_Click;
		contextMenuStrip.Items.Add(Bvm);
		BvN.Text = Class333.Bfq();
		BvN.Click += BvN_Click;
		contextMenuStrip.Items.Add(BvN);
		Bvn.Text = Class333.BfR();
		Bvn.Click += Bvn_Click;
		contextMenuStrip.Items.Add(Bvn);
		if (BKD.method_4())
		{
			BvO.Text = Class333.Bfr();
			BvO.ShortcutKeyDisplayString = Class333.smethod_1308();
			BvO.Enabled = false;
			BvO.Click += BvO_Click;
			contextMenuStrip.Items.Add(BvO);
			Bvo.Text = Class333.BCy();
			Bvo.ShortcutKeyDisplayString = Class333.smethod_1310();
			Bvo.Enabled = false;
			Bvo.Click += Bvo_Click;
			contextMenuStrip.Items.Add(Bvo);
			BvP.Text = Class333.BfS();
			BvP.ShortcutKeyDisplayString = Class333.smethod_185();
			BvP.Enabled = false;
			BvP.Click += BvP_Click;
			contextMenuStrip.Items.Add(BvP);
			Bvp.Text = Class333.Bfs();
			Bvp.ShortcutKeyDisplayString = Class333.smethod_1039();
			Bvp.Enabled = false;
			Bvp.Click += Bvp_Click;
			contextMenuStrip.Items.Add(Bvp);
		}
		ToolStripMenuItem toolStripMenuItem7 = new ToolStripMenuItem();
		toolStripMenuItem7.Text = Class333.BfT();
		toolStripMenuItem7.ShortcutKeyDisplayString = Class333.smethod_1320();
		toolStripMenuItem7.Click += method_87;
		contextMenuStrip.Items.Add(toolStripMenuItem7);
		ToolStripMenuItem toolStripMenuItem8 = new ToolStripMenuItem();
		toolStripMenuItem8.Text = Class333.Bft();
		toolStripMenuItem8.ShortcutKeyDisplayString = Class333.smethod_1323();
		toolStripMenuItem8.Click += method_85;
		contextMenuStrip.Items.Add(toolStripMenuItem8);
		if (BKE != null && BKE.method_64() == 128)
		{
			ToolStripMenuItem toolStripMenuItem9 = new ToolStripMenuItem();
			toolStripMenuItem9.Text = Class333.BfU();
			toolStripMenuItem9.ShortcutKeyDisplayString = Class333.Bfu();
			toolStripMenuItem9.Click += method_86;
			contextMenuStrip.Items.Add(toolStripMenuItem9);
			if (BKD.method_4())
			{
				ToolStripMenuItem toolStripMenuItem10 = new ToolStripMenuItem();
				toolStripMenuItem10.Text = Class333.BfV();
				toolStripMenuItem10.ShortcutKeyDisplayString = Class333.smethod_1327();
				toolStripMenuItem10.Click += method_80;
				contextMenuStrip.Items.Add(toolStripMenuItem10);
				ToolStripMenuItem toolStripMenuItem11 = new ToolStripMenuItem();
				toolStripMenuItem11.Text = Class333.Bfv();
				toolStripMenuItem11.ShortcutKeyDisplayString = Class333.smethod_1329();
				toolStripMenuItem11.Click += method_81;
				contextMenuStrip.Items.Add(toolStripMenuItem11);
			}
		}
		if (BKE != null && BKD.method_4() && BKE.method_64() == 15975)
		{
			ToolStripMenuItem toolStripMenuItem12 = new ToolStripMenuItem();
			toolStripMenuItem12.Text = Class333.BfV();
			toolStripMenuItem12.ShortcutKeyDisplayString = Class333.smethod_1327();
			toolStripMenuItem12.Click += method_77;
			contextMenuStrip.Items.Add(toolStripMenuItem12);
		}
		if (BKE != null && BKD.method_4() && (BKE.method_64() == 6447 || BKE.method_64() == 8279 || BKE.method_64() == 6437))
		{
			ToolStripMenuItem toolStripMenuItem13 = new ToolStripMenuItem();
			toolStripMenuItem13.Text = Class333.BfW();
			toolStripMenuItem13.ShortcutKeyDisplayString = Class333.smethod_1327();
			toolStripMenuItem13.Click += method_76;
			contextMenuStrip.Items.Add(toolStripMenuItem13);
			if (BKD.awo != null && !BKE.SwapColumnsAndRows)
			{
				Setting setting = BKD.awo.method_2(BKE.method_64());
				Setting setting2 = BKD.awo.method_3(BKE.method_64());
				Setting setting3 = BKD.awo.method_4(BKE.method_64());
				if (setting != null && setting2 != null && setting3 != null)
				{
					BvQ.Text = Class333.Bfw();
					BvQ.ShortcutKeyDisplayString = Class333.smethod_218();
					BvQ.Click += BvQ_Click;
					contextMenuStrip.Items.Add(BvQ);
					Bvq.Text = Class333.BfX();
					Bvq.Click += Bvq_Click;
					contextMenuStrip.Items.Add(Bvq);
				}
			}
		}
		contextMenuStrip.Opening += method_58;
		return contextMenuStrip;
	}

	private void method_58(object sender, CancelEventArgs e)
	{
		Bvl.Enabled = !Form23.form23_0.control25_0.method_25(this);
		if (BKE == null)
		{
			return;
		}
		if (BKE.HorizVertIndexPerUserSelectedCell.Count != 0)
		{
			BKE.HorizAxisCount();
			int num = BKE.VertAxisCount();
			BvO.Enabled = BKD.method_4();
			Bvo.Enabled = BKD.method_4();
			BvP.Enabled = BKD.method_4();
			Bvp.Enabled = BKD.method_4();
			if (BKD.awo != null && BKD.method_4() && !BKE.SwapColumnsAndRows)
			{
				Setting setting = BKD.awo.method_2(BKE.method_64());
				Setting setting2 = BKD.awo.method_3(BKE.method_64());
				Setting setting3 = BKD.awo.method_4(BKE.method_64());
				if (setting != null && setting2 != null && setting3 != null)
				{
					BvQ.Enabled = num != 0;
					int num2 = setting.method_256();
					int num3 = setting2.method_256();
					int num4 = setting3.method_256();
					Bvq.Enabled = num2 != 0 || num3 != 0 || num4 != 0;
				}
				else
				{
					BvQ.Enabled = false;
					Bvq.Enabled = false;
				}
			}
			else
			{
				BvQ.Enabled = false;
				Bvq.Enabled = false;
			}
			List<int> list = new List<int>();
			foreach (Point item in BKE.HorizVertIndexPerUserSelectedCell)
			{
				if (!list.Contains(item.Y))
				{
					list.Add(item.Y);
				}
			}
			if (BvQ.Enabled)
			{
				BvQ.Enabled = list.Count == 1;
			}
		}
		else
		{
			BvO.Enabled = false;
			Bvo.Enabled = false;
			BvP.Enabled = false;
			Bvp.Enabled = false;
			BvQ.Enabled = false;
			Bvq.Enabled = false;
		}
		BvM.Enabled = BVw != null && BVw.RowHeadersVisible;
		Bvm.Enabled = BVw != null && (BVw.RowHeadersVisible || BVw.ColumnHeadersVisible);
		int num5 = BKE.TableDataSetting.method_231();
		int num6 = Class233.smethod_1(num5);
		if (num6 == -1)
		{
			num6 = Class233.smethod_39(num5);
		}
		BvN.Enabled = num6 > 0;
		Bvn.Enabled = num6 < 4;
	}

	private List<int> method_59()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < BVw.Rows[0].Cells.Count; i++)
		{
			bool flag = false;
			for (int j = 0; j < BVw.Rows.Count; j++)
			{
				if (BVw.Rows[j].Cells[i].Selected)
				{
					flag = true;
				}
			}
			if (flag)
			{
				list.Add(i);
			}
		}
		return list;
	}

	private List<int> method_60()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < BVw.Rows.Count; i++)
		{
			bool flag = false;
			for (int j = 0; j < BVw.Rows[i].Cells.Count; j++)
			{
				if (BVw.Rows[i].Cells[j].Selected)
				{
					flag = true;
				}
			}
			if (flag)
			{
				list.Add(i);
			}
		}
		return list;
	}

	private void method_61(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4() || !BKE.method_35() || !BKE.HorizAxisEnabled() || BKE.HorizAxis.method_88() == null || BVw.SelectedCells == null || BVw.SelectedCells.Count == 0)
		{
			return;
		}
		List<int> list = method_59();
		int count = list.Count;
		if (count >= BKE.HorizAxisCount())
		{
			return;
		}
		int num = list[0];
		int num2 = BKE.HorizAxis.method_89().method_258(num);
		string item = BKf.method_253(num2).DisplayValueString;
		if (count == 1)
		{
			if (Form54.smethod_6(Form23.form23_0, string.Format(Class333.BCz(), item), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				Class280 @class = Form23.smethod_95();
				@class?.method_2(BKE.method_64());
				for (int i = 0; i < count; i++)
				{
					BKE.DeleteFromHorizAxis(num);
				}
				@class?.method_4();
				Form23.smethod_74(BKE.TableDataSetting.method_64());
				Form23.smethod_74(BKE.HorizAxis.method_88().method_64());
				Form23.smethod_74(BKE.HorizAxis.method_89().method_64());
				method_28();
				method_26();
			}
			return;
		}
		int num3 = BKE.HorizAxis.method_89().method_258(num + count - 1);
		string item2 = BKf.method_253(num3).DisplayValueString;
		if (Form54.smethod_6(Form23.form23_0, string.Format(Class333.BcA(), item, item2), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			Class280 class2 = Form23.smethod_95();
			class2?.method_2(BKE.method_64());
			for (int j = 0; j < count; j++)
			{
				BKE.DeleteFromHorizAxis(num);
			}
			class2?.method_4();
			Form23.smethod_74(BKE.TableDataSetting.method_64());
			Form23.smethod_74(BKE.HorizAxis.method_88().method_64());
			Form23.smethod_74(BKE.HorizAxis.method_89().method_64());
			method_28();
			UpdateLayout(resizingOnly: false);
			method_26();
		}
	}

	private void method_62(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4() || !BKE.method_35() || !BKE.VertAxisEnabled() || BKE.VertAxis.method_88() == null || BVw.SelectedCells == null || BVw.SelectedCells.Count == 0)
		{
			return;
		}
		List<int> list = method_60();
		int count = list.Count;
		if (count >= BKE.VertAxisCount())
		{
			return;
		}
		int num = list[0];
		int num2 = ((!BKE.InvertRows) ? BKE.VertAxis.method_89().method_258(num) : BKE.VertAxis.method_89().method_258(BKE.VertAxisCount() - 1 - num));
		string item = BKG.method_253(num2).DisplayValueString;
		if (count == 1)
		{
			if (Form54.smethod_6(Form23.form23_0, string.Format(Class333.Bfx(), item), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
			{
				return;
			}
			Class280 @class = Form23.smethod_95();
			@class?.method_2(BKE.method_64());
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
			@class?.method_4();
			Form23.smethod_74(BKE.TableDataSetting.method_64());
			Form23.smethod_74(BKE.VertAxis.method_88().method_64());
			Form23.smethod_74(BKE.VertAxis.method_89().method_64());
			method_28();
			method_26();
			return;
		}
		int num3 = ((!BKE.InvertRows) ? BKE.VertAxis.method_89().method_258(num + count - 1) : BKE.VertAxis.method_89().method_258(BKE.VertAxisCount() - 1 - (num + count - 1)));
		string item2 = BKG.method_253(num3).DisplayValueString;
		if (Form54.smethod_6(Form23.form23_0, string.Format(Class333.BfY(), item, item2), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
		{
			return;
		}
		Class280 class2 = Form23.smethod_95();
		class2?.method_2(BKE.method_64());
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
		class2?.method_4();
		Form23.smethod_74(BKE.TableDataSetting.method_64());
		Form23.smethod_74(BKE.VertAxis.method_88().method_64());
		Form23.smethod_74(BKE.VertAxis.method_89().method_64());
		method_28();
		UpdateLayout(resizingOnly: false);
		method_26();
	}

	private void method_63(object sender, EventArgs e)
	{
		if (Form23.enum60_0 != Form23.Enum60.BpG && BKD.method_4() && BKE.method_35() && BKE.SlicesEnabled() && BKE.SliceAxis.method_88() != null && BKE.SliceCount() > 1)
		{
			int num = BKE.SliceAxis.method_89().method_258(BKE.UserSliceIndex);
			string item = BKg.method_253(num).DisplayValueString;
			if (Form54.smethod_6(Form23.form23_0, string.Format(Class333.Bfy(), item), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				Class280 @class = Form23.smethod_95();
				@class?.method_2(BKE.method_64());
				BKE.DeleteSlice(BKE.UserSliceIndex);
				@class?.method_4();
				Form23.smethod_74(BKE.TableDataSetting.method_64());
				Form23.smethod_74(BKE.SliceAxis.method_88().method_64());
				Form23.smethod_74(BKE.SliceAxis.method_89().method_64());
				method_28();
				UpdateLayout(resizingOnly: false);
				method_26();
			}
		}
	}

	private void method_64(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4() || !BKE.HorizAxisEnabled() || BKE.HorizAxis.method_88() == null || BKE.HorizAxisCount() <= 1)
		{
			return;
		}
		int num = (int)(sender as ToolStripMenuItem).Tag;
		if (num != -1)
		{
			int num2 = BKE.HorizAxis.method_89().method_258(num);
			string item = BKf.method_253(num2).DisplayValueString;
			if (Form54.smethod_6(Form23.form23_0, string.Format(Class333.BCz(), item), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				Class280 @class = Form23.smethod_95();
				@class?.method_2(BKE.method_64());
				BKE.DeleteFromHorizAxis(num);
				@class?.method_4();
				Form23.smethod_74(BKE.TableDataSetting.method_64());
				Form23.smethod_74(BKE.HorizAxis.method_88().method_64());
				Form23.smethod_74(BKE.HorizAxis.method_89().method_64());
				method_28();
				UpdateLayout(resizingOnly: false);
				method_26();
			}
		}
	}

	private void method_65(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4() || !BKE.VertAxisEnabled() || BKE.VertAxis.method_88() == null || BKE.VertAxisCount() <= 1)
		{
			return;
		}
		int num = (int)(sender as ToolStripMenuItem).Tag;
		if (num == -1)
		{
			return;
		}
		int num2 = ((!BKE.InvertRows) ? BKE.VertAxis.method_89().method_258(num) : BKE.VertAxis.method_89().method_258(BKE.VertAxisCount() - 1 - num));
		string item = BKG.method_253(num2).DisplayValueString;
		if (Form54.smethod_6(Form23.form23_0, string.Format(Class333.Bfx(), item), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_2(BKE.method_64());
			if (BKE.InvertRows)
			{
				BKE.DeleteFromVertAxis(BKE.VertAxisCount() - 1 - num);
			}
			else
			{
				BKE.DeleteFromVertAxis(num);
			}
			@class?.method_4();
			Form23.smethod_74(BKE.TableDataSetting.method_64());
			Form23.smethod_74(BKE.VertAxis.method_88().method_64());
			Form23.smethod_74(BKE.VertAxis.method_89().method_64());
			method_28();
			UpdateLayout(resizingOnly: false);
			method_26();
		}
	}

	private void method_66(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4() || !BKE.method_35() || !BKE.HorizAxisEnabled() || BKE.HorizAxis.method_88() == null)
		{
			return;
		}
		if (BKE.HorizAxisCount() == BKE.HorizAxis.method_88().method_229())
		{
			Form54.smethod_6(Form23.form23_0, string.Format(Class333.Bca(), BKE.HorizAxisCount()), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		int int_ = BKf.method_231();
		int int_2 = BKf.method_232();
		int num = -1;
		if (sender != null)
		{
			num = (int)(sender as ToolStripMenuItem).Tag;
		}
		string string_ = string.Empty;
		if (num != -1 && BKE.HorizAxisCount() > 1)
		{
			int num2;
			int num3;
			if (num < BKE.HorizAxisCount() - 1)
			{
				num2 = BKE.HorizAxis.method_89().method_258(num);
				num3 = BKE.HorizAxis.method_89().method_258(num + 1);
			}
			else
			{
				num2 = BKE.HorizAxis.method_89().method_258(num - 1);
				num3 = BKE.HorizAxis.method_89().method_258(num);
			}
			List<Setting.ListItems.Struct45> list = BKf.method_102();
			bool flag = false;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].bBv == num2 || list[i].bBv == num3)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				string_ = Class233.smethod_29((num2 + num3) / 2, int_);
			}
		}
		int int_3 = 0;
		int int_4 = 0;
		int int_5 = 0;
		int int_6 = 0;
		BKf.method_230(ref int_3, ref int_4, ref int_5, ref int_6);
		Form12 form = new Form12(Class333.BCx(), Keys.None, string_, int_, int_2, int_3, int_4, int_5, int_6, BKf.method_102());
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			int num4 = ((form.method_1() == null) ? Class233.smethod_26(form.method_0(), int_) : form.method_2());
			if (BKE.ValueExistsOnHorizAxis(num4))
			{
				Form54.smethod_6(Form23.form23_0, Class333.BfZ(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Class280 @class = Form23.smethod_95();
				@class?.method_2(BKE.method_64());
				BKE.InsertIntoHorizAxis(num4);
				@class?.method_4();
				Form23.smethod_74(BKE.TableDataSetting.method_64());
				Form23.smethod_74(BKE.HorizAxis.method_88().method_64());
				Form23.smethod_74(BKE.HorizAxis.method_89().method_64());
				method_28();
				UpdateLayout(resizingOnly: false);
				method_26();
			}
		}
		form.Dispose();
	}

	private void method_67(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4() || !BKE.method_35() || !BKE.VertAxisEnabled() || BKE.VertAxis.method_88() == null)
		{
			return;
		}
		if (BKE.VertAxisCount() == BKE.VertAxis.method_88().method_229())
		{
			Form54.smethod_6(Form23.form23_0, string.Format(Class333.Bfz(), BKE.VertAxisCount()), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		int int_ = BKG.method_231();
		int int_2 = BKG.method_232();
		int num = -1;
		if (sender != null)
		{
			num = (int)(sender as ToolStripMenuItem).Tag;
		}
		string string_ = string.Empty;
		if (num != -1 && BKE.VertAxisCount() > 1)
		{
			int num2;
			int num3;
			if (num < BKE.VertAxisCount() - 1)
			{
				if (BKE.InvertRows)
				{
					num2 = BKE.VertAxis.method_89().method_258(BKE.VertAxisCount() - 1 - num);
					num3 = BKE.VertAxis.method_89().method_258(BKE.VertAxisCount() - 1 - (num + 1));
				}
				else
				{
					num2 = BKE.VertAxis.method_89().method_258(num);
					num3 = BKE.VertAxis.method_89().method_258(num + 1);
				}
			}
			else if (BKE.InvertRows)
			{
				num2 = BKE.VertAxis.method_89().method_258(BKE.VertAxisCount() - 1 - (num - 1));
				num3 = BKE.VertAxis.method_89().method_258(BKE.VertAxisCount() - 1 - num);
			}
			else
			{
				num2 = BKE.VertAxis.method_89().method_258(num - 1);
				num3 = BKE.VertAxis.method_89().method_258(num);
			}
			List<Setting.ListItems.Struct45> list = BKG.method_102();
			bool flag = false;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].bBv == num2 || list[i].bBv == num3)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				string_ = Class233.smethod_29((num2 + num3) / 2, int_);
			}
		}
		int int_3 = 0;
		int int_4 = 0;
		int int_5 = 0;
		int int_6 = 0;
		BKG.method_230(ref int_3, ref int_4, ref int_5, ref int_6);
		Form12 form = new Form12(Class333.BGA(), Keys.None, string_, int_, int_2, int_3, int_4, int_5, int_6, BKG.method_102());
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			int num4 = ((form.method_1() == null) ? Class233.smethod_26(form.method_0(), int_) : form.method_2());
			if (BKE.ValueExistsOnVertAxis(num4))
			{
				Form54.smethod_6(Form23.form23_0, Class333.BfZ(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Class280 @class = Form23.smethod_95();
				@class?.method_2(BKE.method_64());
				BKE.InsertIntoVertAxis(num4);
				@class?.method_4();
				Form23.smethod_74(BKE.TableDataSetting.method_64());
				Form23.smethod_74(BKE.VertAxis.method_88().method_64());
				Form23.smethod_74(BKE.VertAxis.method_89().method_64());
				method_28();
				UpdateLayout(resizingOnly: false);
				method_26();
			}
		}
		form.Dispose();
	}

	private void method_68(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4() || !BKE.method_35() || !BKE.SlicesEnabled() || BKE.SliceAxis.method_88() == null)
		{
			return;
		}
		if (BKE.SliceCount() == BKE.SliceAxis.method_88().method_229())
		{
			Form54.smethod_6(Form23.form23_0, string.Format(Class333.BGa(), BKE.SliceCount()), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		int int_ = BKg.method_231();
		int int_2 = BKg.method_232();
		int int_3 = 0;
		int int_4 = 0;
		int int_5 = 0;
		int int_6 = 0;
		BKg.method_230(ref int_3, ref int_4, ref int_5, ref int_6);
		Form12 form = new Form12(Class333.BGB(), Keys.None, Class333.smethod_102(), int_, int_2, int_3, int_4, int_5, int_6, BKg.method_102());
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			int num = ((form.method_1() == null) ? Class233.smethod_26(form.method_0(), int_) : form.method_2());
			if (BKE.ValueExistsOnSliceAxis(num))
			{
				Form54.smethod_6(Form23.form23_0, Class333.BfZ(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Class280 @class = Form23.smethod_95();
				@class?.method_2(BKE.method_64());
				BKE.InsertSlice(num);
				@class?.method_4();
				Form23.smethod_74(BKE.TableDataSetting.method_64());
				Form23.smethod_74(BKE.SliceAxis.method_88().method_64());
				Form23.smethod_74(BKE.SliceAxis.method_89().method_64());
				method_28();
				UpdateLayout(resizingOnly: false);
				method_26();
			}
		}
		form.Dispose();
	}

	private void method_69()
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4())
		{
			return;
		}
		Form4 form = new Form4(BKE, bool_0: false);
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			if (form.method_0() == Enum50.const_0)
			{
				method_66(null, null);
			}
			else if (form.method_0() == Enum50.const_1)
			{
				method_67(null, null);
			}
			else if (form.method_0() == Enum50.const_2)
			{
				method_68(null, null);
			}
		}
		form.Dispose();
	}

	private void method_70()
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4())
		{
			return;
		}
		Form4 form = new Form4(BKE, bool_0: true);
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			if (form.method_0() == Enum50.const_0)
			{
				method_61(null, null);
			}
			else if (form.method_0() == Enum50.const_1)
			{
				method_62(null, null);
			}
			else if (form.method_0() == Enum50.const_2)
			{
				method_63(null, null);
			}
		}
		form.Dispose();
	}

	private ContextMenuStrip method_71(int int_3)
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip
		{
			Tag = int_3,
			BackColor = Form23.color_15,
			ForeColor = Form23.color_12
		};
		if (int_3 == 0)
		{
			BvR.Clear();
			Bvr.Clear();
		}
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem.Tag = int_3;
		toolStripMenuItem.Text = Class333.BCx();
		toolStripMenuItem.Click += method_66;
		contextMenuStrip.Items.Add(toolStripMenuItem);
		BvR.Add(toolStripMenuItem);
		ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripMenuItem2.Tag = int_3;
		toolStripMenuItem2.Text = Class333.BGb();
		toolStripMenuItem2.Click += method_64;
		contextMenuStrip.Items.Add(toolStripMenuItem2);
		Bvr.Add(toolStripMenuItem2);
		contextMenuStrip.Opening += method_72;
		return contextMenuStrip;
	}

	private void method_72(object sender, CancelEventArgs e)
	{
		foreach (ToolStripMenuItem item in Bvr)
		{
			item.Enabled = BKE != null && BKD.method_4() && BKE.HorizAxisCount() > 1;
		}
	}

	private ContextMenuStrip method_73(int int_3)
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		contextMenuStrip.Tag = int_3;
		contextMenuStrip.BackColor = Form23.color_15;
		contextMenuStrip.ForeColor = Form23.color_12;
		if (int_3 == 0)
		{
			BvS.Clear();
			Bvs.Clear();
			BvT.Clear();
			Bvt.Clear();
		}
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem.Tag = int_3;
		toolStripMenuItem.Text = Class333.BGA();
		toolStripMenuItem.Click += method_67;
		contextMenuStrip.Items.Add(toolStripMenuItem);
		BvS.Add(toolStripMenuItem);
		ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripMenuItem2.Tag = int_3;
		toolStripMenuItem2.Text = Class333.BGC();
		toolStripMenuItem2.Click += method_65;
		contextMenuStrip.Items.Add(toolStripMenuItem2);
		Bvs.Add(toolStripMenuItem2);
		if (BKE != null && BKD.awo != null && !BKE.SwapColumnsAndRows)
		{
			Setting setting = BKD.awo.method_2(BKE.method_64());
			Setting setting2 = BKD.awo.method_3(BKE.method_64());
			Setting setting3 = BKD.awo.method_4(BKE.method_64());
			if (setting != null && setting2 != null && setting3 != null)
			{
				ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
				toolStripMenuItem3.Tag = int_3;
				toolStripMenuItem3.Text = Class333.BGc();
				toolStripMenuItem3.Click += method_75;
				contextMenuStrip.Items.Add(toolStripMenuItem3);
				BvT.Add(toolStripMenuItem3);
				ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem();
				toolStripMenuItem4.Tag = int_3;
				toolStripMenuItem4.Text = Class333.BGD();
				toolStripMenuItem4.Click += Bvq_Click;
				contextMenuStrip.Items.Add(toolStripMenuItem4);
				Bvt.Add(toolStripMenuItem4);
			}
		}
		contextMenuStrip.Opening += method_74;
		return contextMenuStrip;
	}

	private void method_74(object sender, CancelEventArgs e)
	{
		foreach (ToolStripMenuItem bv in Bvs)
		{
			bv.Enabled = BKE != null && BKD.method_4() && BKE.VertAxisCount() > 1;
		}
		if (BKE == null || BKD.awo == null || BKE.SwapColumnsAndRows)
		{
			return;
		}
		Setting setting = BKD.awo.method_2(BKE.method_64());
		Setting setting2 = BKD.awo.method_3(BKE.method_64());
		Setting setting3 = BKD.awo.method_4(BKE.method_64());
		if (setting == null || setting2 == null || setting3 == null)
		{
			return;
		}
		int num = (int)(sender as ContextMenuStrip).Tag;
		if (num != -1)
		{
			int num2 = setting.method_256();
			int num3 = setting2.method_256();
			int num4 = setting3.method_256();
			if (num2 == 0 && num3 == 0 && num4 == 0)
			{
				Bvt[num].Enabled = false;
			}
			else if (BKE.InvertRows)
			{
				Bvt[num].Enabled = num == BKE.VertAxisCount() - 1 - num2;
			}
			else
			{
				Bvt[num].Enabled = num == num2;
			}
		}
	}

	private void method_75(object sender, EventArgs e)
	{
		if (BKE == null || BKD.awo == null || BKE.SwapColumnsAndRows)
		{
			return;
		}
		int num = (int)(sender as ToolStripMenuItem).Tag;
		if (num == -1)
		{
			return;
		}
		Setting setting = BKD.awo.method_2(BKE.method_64());
		Setting setting2 = BKD.awo.method_3(BKE.method_64());
		Setting setting3 = BKD.awo.method_4(BKE.method_64());
		if (setting != null && setting2 != null && setting3 != null)
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_2(BKE.TableDataSetting.method_64());
			setting2.method_272(0, bool_0: true);
			setting3.method_272(BKE.HorizAxisCount() - 1, bool_0: true);
			if (BKE.InvertRows)
			{
				setting.method_272(BKE.VertAxisCount() - 1 - num, bool_0: true);
			}
			else
			{
				setting.method_272(num, bool_0: true);
			}
			@class?.method_4();
		}
	}

	private void BvQ_Click(object sender, EventArgs e)
	{
		if (!BvQ.Enabled || BKD.awo == null || !BKD.method_4() || BKE == null || BKE.HorizVertIndexPerUserSelectedCell.Count == 0 || BKE.SwapColumnsAndRows)
		{
			return;
		}
		Setting setting = BKD.awo.method_2(BKE.method_64());
		Setting setting2 = BKD.awo.method_3(BKE.method_64());
		Setting setting3 = BKD.awo.method_4(BKE.method_64());
		if (setting == null || setting2 == null || setting3 == null)
		{
			return;
		}
		List<int> list = new List<int>();
		int val = int.MaxValue;
		int val2 = int.MinValue;
		foreach (Point item in BKE.HorizVertIndexPerUserSelectedCell)
		{
			if (!list.Contains(item.Y))
			{
				list.Add(item.Y);
			}
			val = Math.Min(val, item.X);
			val2 = Math.Max(val2, item.X);
		}
		if (list.Count == 1)
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_2(BKE.TableDataSetting.method_64());
			setting2.method_272(val, bool_0: true);
			setting3.method_272(val2, bool_0: true);
			if (BKE.InvertRows)
			{
				setting.method_272(BKE.VertAxisCount() - 1 - list[0], bool_0: true);
			}
			else
			{
				setting.method_272(list[0], bool_0: true);
			}
			@class?.method_4();
		}
	}

	private void Bvq_Click(object sender, EventArgs e)
	{
		if (BKD.awo != null && BKE != null)
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_2(BKE.TableDataSetting.method_64());
			BKD.awo.method_1(BKE.method_64());
			@class?.method_4();
		}
	}

	private void BvC_Click(object sender, EventArgs e)
	{
		if (BKD.method_4())
		{
			string text = null;
			if (BKE.method_64() == 128)
			{
				text = Class333.BGd();
			}
			else if (BKE.method_64() == 15975)
			{
				text = Class333.BGE();
			}
			else if (BKE.method_64() == 6447)
			{
				text = Class333.BGe();
			}
			else if (BKE.method_64() == 8279)
			{
				text = Class333.BGF();
			}
			else if (BKE.method_64() == 6437)
			{
				text = Class333.BGf();
			}
			if (text != null)
			{
				Form54.smethod_4(Form23.form23_0, Class333.smethod_1341() + BKE.method_60(Enum96.aYt) + Class333.BGG() + text, Class333.BGg(), MessageBoxButtons.OK);
			}
		}
	}

	private void method_76(object sender, EventArgs e)
	{
		if (BKE == null || !BKE.method_35() || !BKD.method_4() || ((Form23.enum60_0 == Form23.Enum60.BpG || Form23.enum60_0 == Form23.Enum60.BpF) && BKd != null))
		{
			return;
		}
		if ((Form23.int_0 & 0x1000) == 0)
		{
			Form54.smethod_6(Form23.form23_0, Class333.BGH(), Class333.BGh(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (!Form23.smethod_84(6425))
		{
			Form54.smethod_6(Form23.form23_0, Class333.BGI(), Class333.BGi(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		int num = 0;
		if (BKE.method_64() == 6447)
		{
			num = 6469;
		}
		else if (BKE.method_64() == 8279)
		{
			num = 384;
		}
		else
		{
			if (BKE.method_64() != 6437)
			{
				return;
			}
			num = 6970;
		}
		if (!Form23.smethod_84(num))
		{
			switch (num)
			{
			case 6469:
				Form54.smethod_6(Form23.form23_0, Class333.BGJ(), Class333.BGj(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				break;
			case 384:
				Form54.smethod_6(Form23.form23_0, Class333.BGK(), Class333.BGk(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				break;
			case 6970:
				Form54.smethod_6(Form23.form23_0, Class333.BGL(), Class333.BGl(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				break;
			}
			return;
		}
		TableAxis tableAxis = null;
		if (BKE.HorizAxis != null && BKE.HorizAxis.method_90() != null && BKE.HorizAxis.method_89() != null && BKE.HorizAxis.method_90().method_256() == 6425)
		{
			tableAxis = BKE.HorizAxis;
		}
		else
		{
			if (BKE.VertAxis == null || BKE.VertAxis.method_90() == null || BKE.VertAxis.method_89() == null || BKE.VertAxis.method_90().method_256() != 6425)
			{
				return;
			}
			tableAxis = BKE.VertAxis;
		}
		if (BVw.SelectedCells == null || BVw.SelectedCells.Count == 0)
		{
			return;
		}
		int num2 = -1;
		int num3 = -1;
		int num4 = -1;
		for (int i = 0; i < Control3.list_0.Count; i++)
		{
			num3 = -1;
			num4 = -1;
			for (int j = 0; j < Control3.list_0[i].Count; j++)
			{
				if (Control3.list_0[i][j] == 6425)
				{
					num3 = j;
				}
				else if (Control3.list_0[i][j] == num)
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
				Form54.smethod_6(Form23.form23_0, Class333.BGM(), Class333.BGm(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				break;
			case 384:
				Form54.smethod_6(Form23.form23_0, Class333.BGN(), Class333.BGn(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				break;
			case 6970:
				Form54.smethod_6(Form23.form23_0, Class333.BGO(), Class333.BGo(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				break;
			}
			return;
		}
		Control3.Struct13 @struct = Control3.list_5[num2];
		int count = @struct.BLP.Count;
		int num5 = -1;
		int num6 = -1;
		for (int k = 0; k < count; k++)
		{
			int bLo = (int)@struct.BLP[k].BLo;
			if ((bLo >= Control3.int_7 || Control3.int_7 == -1) && (bLo <= Control3.int_8 || Control3.int_8 == -1))
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
		int num7 = @struct.BLP[num5].BLO[num3];
		int val = BKE.method_228();
		int val2 = BKE.method_229();
		int num8 = 0;
		if (BKE.SlicesEnabled())
		{
			num8 = BKE.UserSliceIndex;
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_2(BKE.TableDataSetting.method_64());
		BKE.TableDataSetting.method_268();
		foreach (DataGridViewCell selectedCell in BVw.SelectedCells)
		{
			BKE.GetColumnIndexAndRowIndex(selectedCell.ColumnIndex, selectedCell.RowIndex, out var columnIndex, out var rowIndex);
			int num9 = ((tableAxis.method_71() == AxisType.Column) ? columnIndex : rowIndex);
			int num10 = tableAxis.method_89().method_258(num9);
			int num11 = -1;
			int num12 = -1;
			for (int l = num5; l <= num6; l++)
			{
				Control3.Struct12 struct2 = @struct.BLP[l];
				int num13 = struct2.BLO[num3];
				int num14 = struct2.BLO[num4];
				if (num13 != num10)
				{
					if (num13 <= num10 || (num11 == -1 && num12 == -1) || num10 < num7)
					{
						num11 = num13;
						num12 = num14;
						continue;
					}
					int int_ = Math.Max(Math.Min(num12 + (num10 - num11) * (num14 - num12) / (num13 - num11), val2), val);
					BKE.TableDataSetting.method_273(columnIndex, rowIndex, num8, int_, bool_0: true);
					break;
				}
				int int_2 = Math.Max(Math.Min(num14, val2), val);
				BKE.TableDataSetting.method_273(columnIndex, rowIndex, num8, int_2, bool_0: true);
				break;
			}
			if (BKD.awo != null)
			{
				Setting setting = BKD.awo.method_2(BKE.method_64());
				if (setting != null && setting.method_256() == rowIndex)
				{
					BKD.awo.method_1(BKE.method_64());
				}
			}
		}
		BKE.TableDataSetting.method_267(bool_0: true);
		@class?.method_4();
		Form23.smethod_74(BKE.TableDataSetting.method_64());
		method_26();
	}

	private void method_77(object sender, EventArgs e)
	{
		if (BKE != null && BKE.method_35() && BKD.method_4() && ((Form23.enum60_0 != Form23.Enum60.BpG && Form23.enum60_0 != Form23.Enum60.BpF) || BKd == null) && BKE.method_64() == 15975 && (Form23.smethod_84(15985) || (Form23.smethod_28(BKD.aXc, bool_53: true) && !Form23.smethod_80())))
		{
			method_91(bool_0: true, bool_1: false);
			Class280 @class = Form23.smethod_95();
			@class?.method_2(BKE.TableDataSetting.method_64());
			BKE.TableDataSetting.method_268();
			int num = 0;
			if (BKE.SlicesEnabled())
			{
				num = BKE.UserSliceIndex;
			}
			BKE.GetColumnIndexAndRowIndex(BVw.CurrentCell.ColumnIndex, BVw.CurrentCell.RowIndex, out var columnIndex, out var rowIndex);
			int val = BKD.method_31(15985).method_256();
			int val2 = BKE.method_228();
			int val3 = BKE.method_229();
			int int_ = Math.Max(Math.Min(val, val3), val2);
			BKE.TableDataSetting.method_273(columnIndex, rowIndex, num, int_, bool_0: true);
			BKE.TableDataSetting.method_267(bool_0: true);
			@class?.method_4();
			Form23.smethod_74(BKE.TableDataSetting.method_64());
			method_26();
		}
	}

	private bool method_78()
	{
		Setting setting = BKD.method_31(3822);
		if (setting != null && setting.method_35() && setting.method_256() != 0)
		{
			DialogResult dialogResult = DialogResult.OK;
			if (!Form34.smethod_0())
			{
				Form34 form = new Form34();
				dialogResult = form.ShowDialog(Form23.form23_0);
				form.Dispose();
			}
			if (dialogResult == DialogResult.OK)
			{
				List<Table> list = new List<Table>();
				if (BKD.method_31(3814) is Table table && table.method_35())
				{
					list.Add(table);
				}
				if (BKD.method_31(4039) is Table table2 && table2.method_35())
				{
					list.Add(table2);
				}
				InitialTaskObject.smethod_1(BKE, list, Enum102.azS);
				return true;
			}
			return false;
		}
		return true;
	}

	private bool method_79()
	{
		Setting setting = BKD.method_31(6904);
		Setting setting2 = BKD.method_31(6929);
		Setting setting3 = BKD.method_31(1400);
		Setting setting4 = BKD.method_31(1401);
		Setting setting5 = BKD.method_31(1321);
		Setting setting6 = BKD.method_31(9281);
		Setting setting7 = BKD.method_31(3970);
		Setting setting8 = BKD.method_31(3971);
		Setting setting9 = BKD.method_31(15986);
		if (Form23.smethod_84(8018) && Form23.smethod_84(132) && (setting == null || !setting.method_35() || setting2 == null || !setting2.method_35() || (Form23.smethod_84(6904) && Form23.smethod_84(6929))) && (setting3 == null || !setting3.method_35() || Form23.smethod_84(1400)) && (setting4 == null || !setting4.method_35() || Form23.smethod_84(1401)) && (setting5 == null || !setting5.method_35() || Form23.smethod_84(1321)) && (setting6 == null || !setting6.method_35() || Form23.smethod_84(9281)) && (setting7 == null || !setting7.method_35() || Form23.smethod_84(3970)) && (setting8 == null || !setting8.method_35() || Form23.smethod_84(3971)))
		{
			if (setting9 != null && setting9.method_35())
			{
				return Form23.smethod_84(15986);
			}
			return true;
		}
		return false;
	}

	private void method_80(object sender, EventArgs e)
	{
		if (BKE == null || !BKE.method_35() || !BKD.method_4() || ((Form23.enum60_0 == Form23.Enum60.BpG || Form23.enum60_0 == Form23.Enum60.BpF) && BKd != null) || BKE.method_64() != 128 || (!method_79() && (!Form23.smethod_28(BKD.aXc, bool_53: true) || Form23.smethod_80())))
		{
			return;
		}
		Setting setting = BKD.method_31(8018);
		if (setting != null && setting.method_35())
		{
			Setting setting2 = BKD.method_31(6904);
			Setting setting3 = BKD.method_31(6929);
			int num = 0;
			if (setting2 != null && setting2.method_35() && setting3 != null && setting3.method_35())
			{
				int num2 = setting2.method_256();
				string text = setting2.method_287(num2);
				int num3 = setting3.method_256();
				string text2 = setting3.method_287(num3);
				if ((text != null || num2 < 0) && (text2 != null || num3 < 0))
				{
					Form54.smethod_6(Form23.form23_0, Class333.BGQ(), Class333.BGq(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (text != null || num2 < 0)
				{
					Form54.smethod_6(Form23.form23_0, Class333.BGR(), Class333.BGq(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (text2 != null || num3 < 0)
				{
					Form54.smethod_6(Form23.form23_0, Class333.BGr(), Class333.BGq(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				num = (num2 + num3) / 2;
			}
			else
			{
				num = setting.method_256();
				if (setting.method_287(num) != null || num < 0)
				{
					Form54.smethod_6(Form23.form23_0, Class333.BGS(), Class333.BGq(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			Setting setting4 = BKD.method_31(132);
			if (setting4 != null && setting4.method_35())
			{
				int num4 = setting4.method_256();
				if (num4 == 0)
				{
					return;
				}
				int num5 = 0;
				Setting setting5 = BKD.method_31(1400);
				if (setting5 != null && setting5.method_35())
				{
					num5 = setting5.method_256();
				}
				int num6 = 0;
				Setting setting6 = BKD.method_31(1401);
				if (setting6 != null && setting6.method_35())
				{
					num6 = setting6.method_256();
				}
				if (method_78())
				{
					Setting setting7 = BKD.method_31(3768);
					if (setting7 != null && setting7.method_35())
					{
						_ = setting7.method_256() != 0;
					}
					else
						_ = 0;
					method_91(bool_0: true, bool_1: false);
					Class280 @class = Form23.smethod_95();
					@class?.method_2(BKE.TableDataSetting.method_64());
					BKE.TableDataSetting.method_268();
					int num7 = 0;
					if (BKE.SlicesEnabled())
					{
						num7 = BKE.UserSliceIndex;
					}
					BKE.GetColumnIndexAndRowIndex(BVw.CurrentCell.ColumnIndex, BVw.CurrentCell.RowIndex, out var columnIndex, out var rowIndex);
					int num8 = BKE.TableDataSetting.method_257(columnIndex, rowIndex, num7);
					int num9 = 0;
					int num10 = 0;
					if (setting5 != null && setting5.method_35())
					{
						num9 += num5;
						num10++;
					}
					if (setting6 != null && setting6.method_35())
					{
						num9 += num6;
						num10++;
					}
					if (num10 != 0)
					{
						num9 /= num10;
					}
					float num11 = (float)num / (float)num4 * (1f + (float)num9 / 1000f);
					int val = (int)((float)num8 * num11);
					int val2 = BKE.method_228();
					int val3 = BKE.method_229();
					val = Math.Max(Math.Min(val, val3), val2);
					BKE.TableDataSetting.method_273(columnIndex, rowIndex, num7, val, bool_0: true);
					if (BvI != null)
					{
						BvI[num7, BVw.CurrentCell.RowIndex, BVw.CurrentCell.ColumnIndex].Clear();
					}
					BKE.TableDataSetting.method_267(bool_0: true);
					@class?.method_4();
					Form23.smethod_74(BKE.TableDataSetting.method_64());
					method_26();
				}
			}
			else
			{
				Form54.smethod_6(Form23.form23_0, Class333.BGs(), Class333.BGT(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		else
		{
			Form54.smethod_6(Form23.form23_0, Class333.BGP(), Class333.BGp(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_81(object sender, EventArgs e)
	{
		if (BKE == null || !BKE.method_35() || !BKD.method_4() || ((Form23.enum60_0 == Form23.Enum60.BpG || Form23.enum60_0 == Form23.Enum60.BpF) && BKd != null) || BKE.method_64() != 128 || (!method_79() && (!Form23.smethod_28(BKD.aXc, bool_53: true) || Form23.smethod_80())) || BVw.SelectedCells == null || BVw.SelectedCells.Count == 0 || BvI == null)
		{
			return;
		}
		Setting setting = BKD.method_31(8018);
		if (setting != null && setting.method_35())
		{
			Setting setting2 = BKD.method_31(132);
			if (setting2 != null && setting2.method_35())
			{
				if (!method_78())
				{
					return;
				}
				int num = 0;
				if (BKE.SlicesEnabled())
				{
					num = BKE.UserSliceIndex;
				}
				Setting setting3 = BKD.method_31(3768);
				if (setting3 != null && setting3.method_35() && setting3.method_256() != 0)
				{
					int currentHoriz = 0;
					int currentVert = 0;
					int currentSlice = 0;
					BKE.GetOperatingPoint(ref currentHoriz, ref currentVert, ref currentSlice);
					if (BVw.SelectedCells.Contains(BVw.Rows[currentVert].Cells[currentHoriz]))
					{
					}
				}
				Class280 @class = Form23.smethod_95();
				@class?.method_2(BKE.TableDataSetting.method_64());
				BKE.TableDataSetting.method_268();
				foreach (DataGridViewCell selectedCell in BVw.SelectedCells)
				{
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
					int num5 = 0;
					int columnIndex = selectedCell.ColumnIndex;
					int rowIndex = selectedCell.RowIndex;
					if (num < BvI.GetLength(0) && rowIndex < BvI.GetLength(1) && columnIndex < BvI.GetLength(2) && BvI[num, rowIndex, columnIndex].Count != 0)
					{
						int num6 = 0;
						long num7 = 0L;
						long num8 = 0L;
						long num9 = 0L;
						long num10 = 0L;
						foreach (Struct10 item in BvI[num, rowIndex, columnIndex])
						{
							num7 += item.baI;
							num8 += item.bah;
							num9 += item.bai;
							num10 += item.baJ;
							num6++;
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
						BKE.GetColumnIndexAndRowIndex(selectedCell.ColumnIndex, selectedCell.RowIndex, out var columnIndex2, out var rowIndex2);
						int num11 = BKE.TableDataSetting.method_257(columnIndex2, rowIndex2, num);
						int num12 = 0;
						int num13 = 0;
						Setting setting4 = BKD.method_31(1400);
						if (setting4 != null && setting4.method_35())
						{
							num12 += num4;
							num13++;
						}
						Setting setting5 = BKD.method_31(1401);
						if (setting5 != null && setting5.method_35())
						{
							num12 += num5;
							num13++;
						}
						if (num13 != 0)
						{
							num12 /= num13;
						}
						float num14 = (float)num2 / (float)num3 * (1f + (float)num12 / 1000f);
						int val = (int)((float)num11 * num14);
						int val2 = BKE.method_228();
						int val3 = BKE.method_229();
						val = Math.Max(Math.Min(val, val3), val2);
						BKE.TableDataSetting.method_273(columnIndex2, rowIndex2, num, val, bool_0: true);
						BvI[num, rowIndex, columnIndex].Clear();
					}
				}
				BKE.TableDataSetting.method_267(bool_0: true);
				@class?.method_4();
				Form23.smethod_74(BKE.TableDataSetting.method_64());
				method_26();
			}
			else
			{
				Form54.smethod_6(Form23.form23_0, Class333.BGs(), Class333.BGT(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		else
		{
			Form54.smethod_6(Form23.form23_0, Class333.BGP(), Class333.BGp(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_82()
	{
		string bvi = string.Empty;
		if (BKE != null && BKE.method_64() == 128 && BVw.CurrentCell != null && BvI != null && BVw.SelectedCells != null && BVw.SelectedCells.Count == 1)
		{
			Setting setting = BKD.method_31(8018);
			Setting setting2 = BKD.method_31(132);
			if ((Form23.enum60_0 == Form23.Enum60.Bpf || BKd == null) && setting != null && setting.method_35() && setting2 != null && setting2.method_35())
			{
				bool flag = BKE.HorizAxisEnabled();
				bool flag2 = BKE.VertAxisEnabled();
				int num = 0;
				if (BKE.SlicesEnabled())
				{
					num = BKE.UserSliceIndex;
				}
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				if (((flag && BKf != null) & flag2) && BKG != null)
				{
					int columnIndex = BVw.CurrentCell.ColumnIndex;
					int rowIndex = BVw.CurrentCell.RowIndex;
					if (num < BvI.GetLength(0) && rowIndex < BvI.GetLength(1) && columnIndex < BvI.GetLength(2) && BvI[num, rowIndex, columnIndex].Count != 0)
					{
						int num6 = 0;
						long num7 = 0L;
						long num8 = 0L;
						long num9 = 0L;
						long num10 = 0L;
						foreach (Struct10 item in BvI[num, rowIndex, columnIndex])
						{
							num7 += item.baI;
							num8 += item.bah;
							num9 += item.bai;
							num10 += item.baJ;
							num6++;
						}
						if (num6 != 0)
						{
							num2 = (int)(num7 / num6);
							num3 = (int)(num8 / num6);
							num4 = (int)(num9 / num6);
							num5 = (int)(num10 / num6);
						}
					}
				}
				if (num2 != 0 && num3 != 0)
				{
					BKE.GetColumnIndexAndRowIndex(BVw.CurrentCell.ColumnIndex, BVw.CurrentCell.RowIndex, out var columnIndex2, out var rowIndex2);
					int num11 = BKE.TableDataSetting.method_257(columnIndex2, rowIndex2, num);
					int num12 = 0;
					int num13 = 0;
					Setting setting3 = BKD.method_31(1400);
					if (setting3 != null && setting3.method_35())
					{
						num12 += num4;
						num13++;
					}
					Setting setting4 = BKD.method_31(1401);
					if (setting4 != null && setting4.method_35())
					{
						num12 += num5;
						num13++;
					}
					if (num13 != 0)
					{
						num12 /= num13;
					}
					float num14 = (float)num2 / (float)num3 * (1f + (float)num12 / 1000f);
					int val = (int)((float)num11 * num14);
					int val2 = BKE.method_228();
					int val3 = BKE.method_229();
					string text = Class233.smethod_29(Math.Max(Math.Min(val, val3), val2), BKE.TableDataSetting.method_231());
					int num15 = setting.method_231();
					string text2 = Class233.smethod_35(0, num15, bool_0: false, 0);
					double num16 = Class233.smethod_28(num2, num15);
					double num17 = Class233.smethod_28(num3, num15);
					int abW = Class233.smethod_24(num15).abW;
					string format = Class333.BGt() + text2 + Class333.BGU() + abW + Class333.BGu() + abW + Class333.BGV() + abW + Class333.BGv();
					Struct65<object> gparam_ = default;
					Class332.smethod_1<Struct65<object>, object>(ref gparam_, 0) = num16;
					Class332.smethod_1<Struct65<object>, object>(ref gparam_, 1) = num17;
					Class332.smethod_1<Struct65<object>, object>(ref gparam_, 2) = num17 - num16;
					Class332.smethod_1<Struct65<object>, object>(ref gparam_, 3) = 100f * num14 - 100f;
					Class332.smethod_1<Struct65<object>, object>(ref gparam_, 4) = text;
					bvi = string.Format(format, Class332.smethod_0<Struct65<object>, object>(in gparam_, 5));
				}
			}
		}
		Bvi = bvi;
	}

	private void method_83()
	{
		if (BKE == null || BKE.method_64() != 128 || Bvf != Enum70.const_0)
		{
			return;
		}
		Setting setting = BKD.method_31(8018);
		Setting setting2 = BKD.method_31(132);
		if ((Form23.enum60_0 != Form23.Enum60.Bpf && BKd != null) || setting == null || !setting.method_35() || setting2 == null || !setting2.method_35())
		{
			return;
		}
		for (int i = 0; i < BVw.RowCount; i++)
		{
			for (int j = 0; j < BVw.ColumnCount; j++)
			{
				BVw.Rows[i].Cells[j].Style.BackColor = method_84(i, j);
			}
		}
	}

	private Color method_84(int int_3, int int_4)
	{
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
			if (i >= BvI.GetLength(0) || int_3 >= BvI.GetLength(1) || int_4 >= BvI.GetLength(2) || BvI[i, int_3, int_4].Count == 0)
			{
				continue;
			}
			int num7 = 0;
			long num8 = 0L;
			long num9 = 0L;
			long num10 = 0L;
			long num11 = 0L;
			foreach (Struct10 item in BvI[i, int_3, int_4])
			{
				num8 += item.baI;
				num9 += item.bah;
				num10 += item.bai;
				num11 += item.baJ;
				num7++;
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
			Setting setting = BKD.method_31(1400);
			if (setting != null && setting.method_35())
			{
				num12 += num3;
				num13++;
			}
			Setting setting2 = BKD.method_31(1401);
			if (setting2 != null && setting2.method_35())
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
			result = Class18.smethod_0(num16, num17, num15);
		}
		return result;
	}

	private void method_85(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG && BKd != null)
		{
			BvG = false;
		}
		else
		{
			BvG = !BvG;
		}
		method_28();
		if (BvG)
		{
			if (Bvf != BvF)
			{
				Bvf = BvF;
				method_26();
			}
			else
			{
				method_83();
				method_82();
			}
		}
		else
		{
			method_26();
		}
		BVw.Invalidate();
	}

	private void method_86(object sender, EventArgs e)
	{
		if (BKE != null && BvG)
		{
			if (Bvf == Enum70.const_0)
			{
				Bvf = Enum70.const_1;
			}
			else
			{
				Bvf = Enum70.const_0;
			}
			method_26();
			BVw.Invalidate();
		}
	}

	private void method_87(object sender, EventArgs e)
	{
		BvJ = !BvJ;
	}

	private void method_88()
	{
		switch (Bve)
		{
		case Enum69.const_0:
			Bve = Enum69.const_1;
			break;
		case Enum69.const_1:
			Bve = Enum69.const_2;
			break;
		case Enum69.const_2:
			Bve = Enum69.const_3;
			break;
		case Enum69.const_3:
			Bve = Enum69.const_0;
			break;
		}
		Form23.form23_0.control25_0.method_19();
	}

	private void method_89()
	{
		BvL = false;
		for (int i = 0; i < BVw.Rows.Count; i++)
		{
			for (int j = 0; j < BVw.Rows[i].Cells.Count; j++)
			{
				BVw.Rows[i].Cells[j].Selected = BVw.CurrentCell.ColumnIndex == j && BVw.CurrentCell.RowIndex == i;
			}
		}
		BvL = true;
		BVw_SelectionChanged(null, null);
	}

	private void method_90()
	{
		method_91(bool_0: false, bool_1: true);
	}

	private void method_91(bool bool_0, bool bool_1)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		int currentHoriz = 0;
		int currentVert = 0;
		int currentSlice = 0;
		BKE.GetOperatingPoint(ref currentHoriz, ref currentVert, ref currentSlice);
		if (!bool_1 || currentHoriz != BvU || currentVert != Bvu)
		{
			int leftSelectedHoriz = int.MaxValue;
			int rightSelectedHoriz = int.MinValue;
			int topSelectedVert = int.MaxValue;
			int bottomSelectedVert = int.MinValue;
			if (!bool_0)
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
					BVw.Rows[i].Cells[j].Selected = false;
				}
			}
			BVw.CurrentCell = BVw.Rows[currentVert].Cells[currentHoriz];
			BVw.Rows[currentVert].Cells[currentHoriz].Selected = true;
			if (!bool_0)
			{
				int num3 = rightSelectedHoriz - leftSelectedHoriz + 1;
				int num4 = bottomSelectedVert - topSelectedVert + 1;
				int val = currentHoriz - num3 / 2;
				int val2 = currentVert - num4 / 2;
				val = Math.Min(Math.Max(val, 0), BVw.ColumnCount - num3);
				val2 = Math.Min(Math.Max(val2, 0), BVw.RowCount - num4);
				for (int k = 0; k < num4; k++)
				{
					for (int l = 0; l < num3; l++)
					{
						int index = val + l;
						int index2 = val2 + k;
						BVw.Rows[index2].Cells[index].Selected = true;
					}
				}
			}
			BvL = true;
			BVw_SelectionChanged(null, null);
			if (bool_1)
			{
				BvU = currentHoriz;
				Bvu = currentVert;
			}
		}
		if (bool_1)
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

	internal bool method_92(KeyEventArgs keyEventArgs_0)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return false;
		}
		if (!BKD.method_4())
		{
			return false;
		}
		if (Bvj)
		{
			return false;
		}
		if ((!keyEventArgs_0.Control || keyEventArgs_0.KeyCode != Keys.Prior) && keyEventArgs_0.KeyData != Keys.Prior && (!keyEventArgs_0.Shift || keyEventArgs_0.KeyCode != Keys.Prior) && (!keyEventArgs_0.Control || keyEventArgs_0.KeyCode != Keys.Next) && keyEventArgs_0.KeyData != Keys.Next && (!keyEventArgs_0.Shift || keyEventArgs_0.KeyCode != Keys.Next) && keyEventArgs_0.KeyData != Keys.OemOpenBrackets && keyEventArgs_0.KeyData != Keys.OemCloseBrackets && keyEventArgs_0.KeyData != Keys.OemSemicolon && keyEventArgs_0.KeyData != Keys.Oem7 && keyEventArgs_0.KeyData != Keys.Oemcomma && keyEventArgs_0.KeyData != Keys.OemPeriod)
		{
			return false;
		}
		if (!BKE.method_35())
		{
			return true;
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_2(BKE.TableDataSetting.method_64());
		BKE.IncreaseOrDecreaseSelectedCellValues(keyEventArgs_0);
		@class?.method_4();
		Form23.smethod_74(BKE.TableDataSetting.method_64());
		if (BvI != null)
		{
			int num = 0;
			if (BKE.SlicesEnabled())
			{
				num = BKE.UserSliceIndex;
			}
			foreach (Point item in BKE.HorizVertIndexPerUserSelectedCell)
			{
				if (num < BvI.GetLength(0) && item.Y < BvI.GetLength(1) && item.X < BvI.GetLength(2))
				{
					BvI[num, item.Y, item.X].Clear();
				}
			}
		}
		return true;
	}

	internal void method_93(string string_0, int int_3, int int_4)
	{
		List<string> list = new List<string>();
		list.Add(Class333.BGW());
		int num = Left - int_3;
		int num2 = Top - int_4;
		list.Add(Class333.Bad() + num);
		list.Add(Class333.BaE() + num2);
		list.Add(Class333.Bae() + Width);
		list.Add(Class333.BaF() + Height);
		list.Add(Class333.BBi() + BKF);
		if (BKE != null)
		{
			list.Add(Class333.BBJ() + BKE.InvertRows);
			list.Add(Class333.BBj() + BKE.SwapColumnsAndRows);
		}
		list.Add(Class333.smethod_102());
		File.AppendAllLines(string_0, list);
	}

	internal void method_94(StreamReader streamReader_0)
	{
		string text;
		while ((text = streamReader_0.ReadLine()) != null)
		{
			if (text.StartsWith(Class333.BBi()))
			{
				BKF = int.Parse(text.Substring(Class333.BBi().Length));
				if (BKD.method_31(BKF) != null)
				{
					vmethod_2(BKF);
				}
			}
			else if (text.Contains(Class333.BBK()))
			{
				BKF = int.Parse(text.Substring(text.IndexOf(Class333.BBK()) + Class333.BBK().Length));
				if (BKD.method_31(BKF) != null)
				{
					vmethod_2(BKF);
				}
			}
			else if (text.StartsWith(Class333.BBJ()))
			{
				if (BKE != null)
				{
					BKE.InvertRows = bool.Parse(text.Substring(Class333.BBJ().Length));
				}
			}
			else if (text.StartsWith(Class333.BBj()))
			{
				if (BKE != null)
				{
					BKE.SwapColumnsAndRows = bool.Parse(text.Substring(Class333.BBj().Length));
				}
			}
			else if (!text.Contains(Class333.Bai()) && string.IsNullOrWhiteSpace(text))
			{
				break;
			}
		}
	}

	private void method_95(object sender, EventArgs e)
	{
		if (BKE != null && BKE.UserSliceIndex >= 0 && BKE.UserSliceIndex <= BKj.BWB)
		{
			BKj.BWb = BKE.UserSliceIndex;
			method_26();
		}
	}

	[CompilerGenerated]
	private void method_96()
	{
		Bvc.Visible = false;
	}

	[CompilerGenerated]
	private void method_97()
	{
		BvD.Visible = false;
	}
}
