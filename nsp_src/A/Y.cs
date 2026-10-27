using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using NSP.SettingsFramework;
using a;
using c;

namespace A;

internal interface Y
{
	Control A(DataIdAndAttrId P_0);

	Control A();
}
internal class y : Panel
{
	private static readonly Color FU = Color.Red;

	private static readonly Color Fu = Color.Blue;

	private static readonly Color FV = Color.Purple;

	private static readonly Color Fv = Color.DimGray;

	private Framework FW;

	private KnockDetection Fw;

	private List<Setting> FX = new List<Setting>();

	private int Fx;

	private Setting FY;

	private Setting Fy;

	private Setting FZ;

	private Setting Fz;

	private Setting fA;

	private aP fa;

	private aP fB;

	private const long fb = 5000L;

	private List<List<int>> fC = new List<List<int>>();

	private List<long> fc = new List<long>();

	private Stopwatch fD = new Stopwatch();

	private bool fd;

	private bool fE;

	private bool fe;

	private int fF;

	private int ff;

	private int fG;

	internal y(KnockDetection P_0, Framework P_1)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected O, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		FW = P_1;
		Fw = P_0;
		if (Fw != null)
		{
			for (int num = 0; num < Fw.DataIdsOfAngleBucketChannels.Count; num++)
			{
				Setting setting = FW.A(Fw.DataIdsOfAngleBucketChannels[num]);
				if (setting != null)
				{
					FX.Add(setting);
					setting.A(new EventHandler(a));
					((SettingOrSpecialObject)setting).A(new EventHandler(a));
					fC.Add(new List<int>());
					Fx = FX[FX.Count - 1].av()[2];
					for (int num2 = 0; num2 < Fx; num2++)
					{
						fC[fC.Count - 1].Add(0);
						fc.Add(0L);
					}
				}
			}
			if (FX.Count == 2)
			{
				fa = new aP();
				((Control)fa).AutoSize = false;
				((Control)fa).Height = (int)((float)((Control)fa).Height * 0.75f);
				((Control)fa).Width = 170;
				((Control)fa).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ex();
				((Control)fa).Left = 10;
				((Control)fa).Top = 3;
				((Control)fa).Visible = false;
				((CheckBox)fa).Checked = true;
				((CheckBox)fa).CheckedChanged += new EventHandler(a);
				((Control)this).Controls.Add((Control)(object)fa);
				fB = new aP();
				((Control)fB).AutoSize = false;
				((Control)fB).Height = (int)((float)((Control)fB).Height * 0.75f);
				((Control)fB).Width = 170;
				((Control)fB).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EY();
				((Control)fB).Left = 10;
				((Control)fB).Top = 3 + ((Control)fa).Height;
				((Control)fB).Visible = false;
				((CheckBox)fB).Checked = true;
				((CheckBox)fB).CheckedChanged += new EventHandler(a);
				((Control)this).Controls.Add((Control)(object)fB);
			}
			FY = FW.A(Fw.DataIdOfWindowStartAngleSetting);
			Fy = FW.A(Fw.DataIdOfWindowDurationSetting);
			if (FY != null)
			{
				FY.A(new EventHandler(a));
			}
			if (Fy != null)
			{
				Fy.A(new EventHandler(a));
			}
			FZ = P_1.A(93);
			Fz = P_1.A(94);
			fA = P_1.A(95);
			if (FZ != null)
			{
				FZ.A(new EventHandler(a));
				((SettingOrSpecialObject)FZ).A(new EventHandler(a));
			}
			if (Fz != null)
			{
				Fz.A(new EventHandler(a));
				((SettingOrSpecialObject)Fz).A(new EventHandler(a));
			}
			if (fA != null)
			{
				fA.A(new EventHandler(a));
				((SettingOrSpecialObject)fA).A(new EventHandler(a));
			}
			Fw.OnDisplayedMagnitudeRangeChanged += new EventHandler(a);
		}
		global::A.A.A(new EventHandler(A));
		global::A.A.A((D)A);
		BM.D(new EventHandler(A));
		fD.Start();
		((Control)this).DoubleBuffered = true;
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)131072, true);
		((Control)this).SetStyle((ControlStyles)2, true);
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		try
		{
			Enumerator<Setting> enumerator = FX.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					current.a(new EventHandler(a));
					((SettingOrSpecialObject)current).a(new EventHandler(a));
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (FY != null)
			{
				FY.a(new EventHandler(a));
			}
			if (Fy != null)
			{
				Fy.a(new EventHandler(a));
			}
			if (FZ != null)
			{
				FZ.a(new EventHandler(a));
				((SettingOrSpecialObject)FZ).a(new EventHandler(a));
			}
			if (Fz != null)
			{
				Fz.a(new EventHandler(a));
				((SettingOrSpecialObject)Fz).a(new EventHandler(a));
			}
			if (fA != null)
			{
				fA.a(new EventHandler(a));
				((SettingOrSpecialObject)fA).a(new EventHandler(a));
			}
			if (fa != null)
			{
				((CheckBox)fa).CheckedChanged -= new EventHandler(a);
			}
			if (fB != null)
			{
				((CheckBox)fB).CheckedChanged -= new EventHandler(a);
			}
			if (Fw != null)
			{
				Fw.OnDisplayedMagnitudeRangeChanged -= new EventHandler(a);
			}
			global::A.A.a(new EventHandler(A));
			global::A.A.a((D)A);
			BM.d(new EventHandler(A));
			fD.Stop();
			((Control)this).Dispose(disposing);
		}
		catch
		{
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		((Control)this).Invalidate();
	}

	private void a(object P_0, EventArgs P_1)
	{
		((Control)this).Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).Parent != null && ((Control)this).BackColor != ((Control)this).Parent.BackColor)
		{
			((Control)this).BackColor = ((Control)this).Parent.BackColor;
		}
		Graphics graphics = e.Graphics;
		bool flag = FX.Count != 0 && ((SettingOrSpecialObject)FX[0]).l();
		bool flag2 = FX.Count == 2 && ((SettingOrSpecialObject)FX[1]).l();
		if (fa != null && fB != null)
		{
			if (flag && flag2)
			{
				if (((Control)fa).BackColor != ((Control)this).BackColor)
				{
					((Control)fa).BackColor = ((Control)this).BackColor;
				}
				if (((Control)fa).ForeColor != BM.te)
				{
					((Control)fa).ForeColor = BM.te;
				}
				if (!((Control)fa).Visible)
				{
					((Control)fa).Visible = true;
					if (!((CheckBox)fa).Checked)
					{
						((CheckBox)fa).Checked = true;
					}
				}
				if (((Control)fB).BackColor != ((Control)this).BackColor)
				{
					((Control)fB).BackColor = ((Control)this).BackColor;
				}
				if (((Control)fB).ForeColor != BM.te)
				{
					((Control)fB).ForeColor = BM.te;
				}
				if (!((Control)fB).Visible)
				{
					((Control)fB).Visible = true;
					if (!((CheckBox)fB).Checked)
					{
						((CheckBox)fB).Checked = true;
					}
				}
			}
			else
			{
				if (((CheckBox)fa).Checked)
				{
					((CheckBox)fa).Checked = false;
				}
				if (((Control)fa).Visible)
				{
					((Control)fa).Visible = false;
				}
				if (((CheckBox)fB).Checked)
				{
					((CheckBox)fB).Checked = false;
				}
				if (((Control)fB).Visible)
				{
					((Control)fB).Visible = false;
				}
			}
		}
		graphics.Clear(Color.Black);
		int num = A();
		if (num != 0)
		{
			Brush val = (Brush)new SolidBrush(((Control)this).BackColor);
			try
			{
				graphics.FillRectangle(val, 0, 0, ((Control)this).Width, num);
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		if (Fw != null && Fx != 0 && FY != null && Fy != null && FZ != null && Fz != null && fA != null)
		{
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ey();
			SizeF val2 = graphics.MeasureString(text, ((Control)this).Font);
			float height = ((SizeF)(ref val2)).Height;
			graphics.DrawString(text, ((Control)this).Font, Brushes.White, 3f, (float)(num + 3));
			int num2 = ((Control)this).Width - 10 - 47;
			float num3 = (float)((Control)this).Height - 20f;
			float num4 = (float)(num + 3) + height + 13f;
			float num5 = num3 - num4;
			graphics.DrawLine(Pens.Gray, 10f, num3, (float)(10 + num2), num3);
			graphics.DrawLine(Pens.Gray, (float)(10 + num2), num3, (float)(10 + num2), (float)num);
			try
			{
				A(out var num6, out var num7);
				graphics.FillRectangle(Brushes.White, ((Control)this).Width - 8, num6, 6, num7 - num6);
				graphics.DrawLine(Pens.Black, ((Control)this).Width - 10, num6 + 10, ((Control)this).Width, num6 + 10);
				graphics.DrawLine(Pens.Black, ((Control)this).Width - 10, num7 - 10, ((Control)this).Width, num7 - 10);
				graphics.DrawRectangle(Pens.Gray, ((Control)this).Width - 10, num, 9, ((Control)this).Height - 1 - num);
				graphics.DrawLine(Pens.Gray, ((Control)this).Width - 10, num + 10, ((Control)this).Width, num + 10);
				graphics.DrawLine(Pens.Gray, ((Control)this).Width - 10, ((Control)this).Height - 10, ((Control)this).Width, ((Control)this).Height - 10);
			}
			catch
			{
			}
			string text2 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EZ(), (object)(Fw.MinDisplayMagnitude / 100));
			val2 = graphics.MeasureString(text2, ((Control)this).Font);
			int num8 = (int)((SizeF)(ref val2)).Height;
			string text3 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EZ(), (object)(Fw.MaxDisplayMagnitude / 100));
			val2 = graphics.MeasureString(text3, ((Control)this).Font);
			int num9 = (int)((SizeF)(ref val2)).Height;
			graphics.DrawString(text2, ((Control)this).Font, Brushes.White, (float)(10 + num2 + 1), (float)((Control)this).Height - 20f - (float)num8 / 2f);
			graphics.DrawString(text3, ((Control)this).Font, Brushes.White, (float)(10 + num2 + 1), num4 - (float)num9 / 2f);
			if (FZ.O() && Fz.O() && fA.O())
			{
				A(graphics, ((Control)this).Font, 10, num2, 20f, 13f, num3, num4, num5, flag, flag2);
			}
		}
	}

	private void A(Graphics P_0, Font P_1, int P_2, int P_3, float P_4, float P_5, float P_6, float P_7, float P_8, bool P_9, bool P_10)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		int num = FZ.ax();
		int num2 = Fz.ax();
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		switch (num)
		{
		case 0:
			num3 = Fx;
			num4 = 720;
			num5 = 4;
			num6 = 8;
			break;
		case 1:
		case 2:
			num3 = Fx / 2;
			num4 = 360;
			num5 = 2;
			num6 = 4;
			break;
		default:
			return;
		}
		List<int> val = new List<int>();
		StringFormat val2 = new StringFormat();
		val2.Alignment = (StringAlignment)1;
		A(P_0, P_1, val2, P_2, P_3, P_5, P_6, P_7, num2, num4, val);
		int num7 = num4 / num3;
		A(P_0, P_2, P_3, P_8, P_4, num3, num4, num7, val, P_9, P_10);
		A(P_0, P_1, val2, P_2, P_3, P_6, P_7, num3, num4, num7, num5, num6);
		val2.Dispose();
	}

	private void A(Graphics P_0, Font P_1, StringFormat P_2, int P_3, int P_4, float P_5, float P_6, float P_7, int P_8, int P_9, List<int> P_10)
	{
		for (int num = 0; num < P_8; num++)
		{
			int num2 = fA.m(num);
			int num3 = P_3 + num * P_4 / P_8;
			P_0.DrawString(num2.ToString(), P_1, Brushes.White, (float)num3, P_7 - P_5, P_2);
			float num4 = num * P_9 / P_8;
			float num5 = (float)FY.ax() / 10f;
			float num6 = (float)Fy.ax() / 10f;
			int num7 = P_3 + (int)((num4 - num5) * (float)P_4 / (float)P_9);
			int num8 = (int)(num6 * (float)P_4 / (float)P_9);
			if (num7 < P_3 - 1)
			{
				int num9 = num8 - (P_3 - num7);
				P_0.FillRectangle(Brushes.White, (float)P_3, P_7, (float)num9, P_6 - P_7);
				P_10.Add(P_3);
				P_10.Add(P_3 + num9 - 1);
				int num10 = num7 + P_4;
				int num11 = num8 - num9;
				P_0.FillRectangle(Brushes.White, (float)(num10 - 1), P_7, (float)num11, P_6 - P_7);
				P_10.Add(num10);
				P_10.Add(num10 + num11 - 1);
			}
			else
			{
				P_0.FillRectangle(Brushes.White, (float)num7, P_7, (float)num8, P_6 - P_7);
				P_10.Add(num7);
				P_10.Add(num7 + num8 - 1);
			}
		}
	}

	private void A(Graphics P_0, int P_1, int P_2, float P_3, float P_4, int P_5, int P_6, int P_7, List<int> P_8, bool P_9, bool P_10)
	{
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<List<int>> enumerator;
		if (BM.A(FW.aXc, true) && !BM.aE())
		{
			int num = Math.Min((int)(P_3 / 30f), 10);
			for (int num2 = 0; num2 < P_5; num2++)
			{
				int num3 = num2 * P_7;
				int num4 = P_1 + num3 * P_2 / P_6;
				int num5 = P_7 * P_2 / P_6;
				bool flag = false;
				for (int num6 = 0; num6 < P_8.Count / 2; num6++)
				{
					int num7 = P_8[num6 * 2];
					int num8 = P_8[num6 * 2 + 1];
					if ((num4 > num7 && num4 < num8) || (num4 + num5 > num7 && num4 + num5 < num8))
					{
						flag = true;
						break;
					}
				}
				if (FX.Count == 1 || (FX.Count == 2 && ((P_9 && !P_10) || (!P_9 && P_10))))
				{
					if (P_9 || P_10)
					{
						A(P_0, P_3, P_4, num, num2, num4, num5, P_9, P_10, flag);
						continue;
					}
					enumerator = fC.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current[num2] = 0;
							fc[num2] = 0L;
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				else if (P_9 && P_10)
				{
					if (fa != null && fB != null && ((Control)fa).Visible && ((Control)fB).Visible && (!((CheckBox)fa).Checked || !((CheckBox)fB).Checked))
					{
						A(P_0, P_3, P_4, num, num2, num4, num5, flag);
					}
					else
					{
						a(P_0, P_3, P_4, num, num2, num4, num5, flag);
					}
				}
			}
			return;
		}
		enumerator = fC.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				List<int> current = enumerator.Current;
				for (int num9 = 0; num9 < current.Count; num9++)
				{
					current[num9] = 0;
					fc[num9] = 0L;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void A(Graphics P_0, float P_1, float P_2, int P_3, int P_4, int P_5, int P_6, bool P_7, bool P_8, bool P_9)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		if (P_8)
		{
			num = FX[1].m(P_4);
		}
		else if (P_7)
		{
			num = FX[0].m(P_4);
		}
		int num2 = Math.Max(Math.Min(num, Fw.MaxDisplayMagnitude), Fw.MinDisplayMagnitude);
		float num3 = P_1 * ((float)(num2 - Fw.MinDisplayMagnitude) / (float)(Fw.MaxDisplayMagnitude - Fw.MinDisplayMagnitude));
		float num4 = (float)((Control)this).Height - (P_2 + num3);
		Color val = ((!P_9) ? Fv : FU);
		Brush val2 = (Brush)new SolidBrush(val);
		try
		{
			P_0.FillRectangle(val2, (float)P_5, num4, (float)P_6, num3);
		}
		finally
		{
			((System.IDisposable)val2)?.Dispose();
		}
		if (P_8)
		{
			if (num2 > fC[1][P_4])
			{
				fC[1][P_4] = num2;
				fc[P_4] = fD.ElapsedMilliseconds;
			}
		}
		else if (P_7 && num2 > fC[0][P_4])
		{
			fC[0][P_4] = num2;
			fc[P_4] = fD.ElapsedMilliseconds;
		}
		if (fc[P_4] == 0L)
		{
			return;
		}
		long num5 = fD.ElapsedMilliseconds - fc[P_4];
		if (num5 < 10000)
		{
			int num6 = ((num5 >= 5000) ? (255 - (byte)((num5 - 5000) * 255 / 5000)) : 255);
			int num7 = 0;
			if (P_8)
			{
				num7 = ((Control)this).Height - (int)(P_2 + P_1 * ((float)(fC[1][P_4] - Fw.MinDisplayMagnitude) / (float)(Fw.MaxDisplayMagnitude - Fw.MinDisplayMagnitude)));
			}
			else if (P_7)
			{
				num7 = ((Control)this).Height - (int)(P_2 + P_1 * ((float)(fC[0][P_4] - Fw.MinDisplayMagnitude) / (float)(Fw.MaxDisplayMagnitude - Fw.MinDisplayMagnitude)));
			}
			int num8 = num7 + P_3 - (((Control)this).Height - (int)P_2);
			Rectangle val3 = default(Rectangle);
			if (num8 > 0)
			{
				((Rectangle)(ref val3))._002Ector(P_5, num7, P_6, P_3 - num8);
			}
			else
			{
				((Rectangle)(ref val3))._002Ector(P_5, num7, P_6, P_3);
			}
			if (((Rectangle)(ref val3)).Width != 0 && ((Rectangle)(ref val3)).Height != 0)
			{
				LinearGradientBrush val4 = new LinearGradientBrush(val3, Color.FromArgb(num6, val), Color.Transparent, (LinearGradientMode)1);
				try
				{
					P_0.FillRectangle((Brush)(object)val4, val3);
				}
				finally
				{
					((System.IDisposable)val4)?.Dispose();
				}
			}
		}
		else
		{
			fc[P_4] = 0L;
			if (P_7)
			{
				fC[0][P_4] = 0;
			}
			else if (P_8)
			{
				fC[1][P_4] = 0;
			}
		}
	}

	private void A(Graphics P_0, float P_1, float P_2, int P_3, int P_4, int P_5, int P_6, bool P_7)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		Color val;
		if (((CheckBox)fa).Checked)
		{
			num = FX[0].m(P_4);
			val = ((!P_7) ? Fv : FU);
		}
		else
		{
			if (!((CheckBox)fB).Checked)
			{
				fc[P_4] = 0L;
				fC[0][P_4] = 0;
				fC[1][P_4] = 0;
				return;
			}
			num = FX[1].m(P_4);
			val = ((!P_7) ? Fv : Fu);
		}
		int num2 = Math.Max(Math.Min(num, Fw.MaxDisplayMagnitude), Fw.MinDisplayMagnitude);
		float num3 = P_1 * ((float)(num2 - Fw.MinDisplayMagnitude) / (float)(Fw.MaxDisplayMagnitude - Fw.MinDisplayMagnitude));
		float num4 = (float)((Control)this).Height - (P_2 + num3);
		Brush val2 = (Brush)new SolidBrush(val);
		try
		{
			P_0.FillRectangle(val2, (float)P_5, num4, (float)P_6, num3);
		}
		finally
		{
			((System.IDisposable)val2)?.Dispose();
		}
		if (((CheckBox)fa).Checked)
		{
			if (num2 > fC[0][P_4])
			{
				fC[0][P_4] = num2;
				fc[P_4] = fD.ElapsedMilliseconds;
			}
		}
		else if (((CheckBox)fB).Checked && num2 > fC[1][P_4])
		{
			fC[1][P_4] = num2;
			fc[P_4] = fD.ElapsedMilliseconds;
		}
		if (fc[P_4] != 0L)
		{
			long num5 = fD.ElapsedMilliseconds - fc[P_4];
			if (num5 < 10000)
			{
				int num6 = ((num5 >= 5000) ? (255 - (byte)((num5 - 5000) * 255 / 5000)) : 255);
				int num7 = 0;
				if (((CheckBox)fa).Checked)
				{
					num7 = ((Control)this).Height - (int)(P_2 + P_1 * ((float)(fC[0][P_4] - Fw.MinDisplayMagnitude) / (float)(Fw.MaxDisplayMagnitude - Fw.MinDisplayMagnitude)));
				}
				else if (((CheckBox)fB).Checked)
				{
					num7 = ((Control)this).Height - (int)(P_2 + P_1 * ((float)(fC[1][P_4] - Fw.MinDisplayMagnitude) / (float)(Fw.MaxDisplayMagnitude - Fw.MinDisplayMagnitude)));
				}
				int num8 = num7 + P_3 - (((Control)this).Height - (int)P_2);
				Rectangle val3 = default(Rectangle);
				if (num8 > 0)
				{
					((Rectangle)(ref val3))._002Ector(P_5, num7, P_6, P_3 - num8);
				}
				else
				{
					((Rectangle)(ref val3))._002Ector(P_5, num7, P_6, P_3);
				}
				if (((Rectangle)(ref val3)).Width != 0 && ((Rectangle)(ref val3)).Height != 0)
				{
					LinearGradientBrush val4 = new LinearGradientBrush(val3, Color.FromArgb(num6, val), Color.Transparent, (LinearGradientMode)1);
					try
					{
						P_0.FillRectangle((Brush)(object)val4, val3);
					}
					finally
					{
						((System.IDisposable)val4)?.Dispose();
					}
				}
			}
			else
			{
				fc[P_4] = 0L;
				if (((CheckBox)fa).Checked)
				{
					fC[0][P_4] = 0;
				}
				else if (((CheckBox)fB).Checked)
				{
					fC[1][P_4] = 0;
				}
			}
		}
		if (!((CheckBox)fa).Checked)
		{
			fC[0][P_4] = 0;
		}
		if (!((CheckBox)fB).Checked)
		{
			fC[1][P_4] = 0;
		}
	}

	private void a(Graphics P_0, float P_1, float P_2, int P_3, int P_4, int P_5, int P_6, bool P_7)
	{
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		int num = Math.Max(Math.Min(FX[0].m(P_4), Fw.MaxDisplayMagnitude), Fw.MinDisplayMagnitude);
		int num2 = Math.Max(Math.Min(FX[1].m(P_4), Fw.MaxDisplayMagnitude), Fw.MinDisplayMagnitude);
		int num3 = Math.Max(num, num2);
		if (P_7)
		{
			int num4 = Math.Min(num, num2);
			float num5 = P_1 * ((float)(num4 - Fw.MinDisplayMagnitude) / (float)(Fw.MaxDisplayMagnitude - Fw.MinDisplayMagnitude));
			float num6 = (float)((Control)this).Height - (P_2 + num5);
			Brush val = (Brush)new SolidBrush(FV);
			try
			{
				P_0.FillRectangle(val, (float)P_5, num6, (float)P_6, num5);
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
			float num7 = (float)((Control)this).Height - (P_2 + P_1 * ((float)(num3 - Fw.MinDisplayMagnitude) / (float)(Fw.MaxDisplayMagnitude - Fw.MinDisplayMagnitude)));
			float num8 = num6 - num7 + 1f;
			Color val2 = ((num < num2) ? Fu : FU);
			Brush val3 = (Brush)new SolidBrush(val2);
			try
			{
				P_0.FillRectangle(val3, (float)P_5, num7, (float)P_6, num8);
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
		}
		else
		{
			float num9 = P_1 * ((float)(num3 - Fw.MinDisplayMagnitude) / (float)(Fw.MaxDisplayMagnitude - Fw.MinDisplayMagnitude));
			float num10 = (float)((Control)this).Height - (P_2 + num9);
			Brush val4 = (Brush)new SolidBrush(Fv);
			try
			{
				P_0.FillRectangle(val4, (float)P_5, num10, (float)P_6, num9);
			}
			finally
			{
				((System.IDisposable)val4)?.Dispose();
			}
		}
		if (num > fC[0][P_4])
		{
			fC[0][P_4] = num;
			if (num >= fC[1][P_4])
			{
				fc[P_4] = fD.ElapsedMilliseconds;
			}
		}
		if (num2 > fC[1][P_4])
		{
			fC[1][P_4] = num2;
			if (num2 > fC[0][P_4])
			{
				fc[P_4] = fD.ElapsedMilliseconds;
			}
		}
		if (fc[P_4] == 0L)
		{
			return;
		}
		long num11 = fD.ElapsedMilliseconds - fc[P_4];
		if (num11 < 10000)
		{
			int num12 = ((num11 >= 5000) ? (255 - (byte)((num11 - 5000) * 255 / 5000)) : 255);
			int num13;
			Color val5;
			if (fC[0][P_4] >= fC[1][P_4])
			{
				num13 = fC[0][P_4];
				val5 = (P_7 ? FU : Fv);
			}
			else
			{
				num13 = fC[1][P_4];
				val5 = (P_7 ? Fu : Fv);
			}
			int num14 = ((Control)this).Height - (int)(P_2 + P_1 * ((float)(num13 - Fw.MinDisplayMagnitude) / (float)(Fw.MaxDisplayMagnitude - Fw.MinDisplayMagnitude)));
			int num15 = num14 + P_3 - (((Control)this).Height - (int)P_2);
			Rectangle val6 = default(Rectangle);
			if (num15 > 0)
			{
				((Rectangle)(ref val6))._002Ector(P_5, num14, P_6, P_3 - num15);
			}
			else
			{
				((Rectangle)(ref val6))._002Ector(P_5, num14, P_6, P_3);
			}
			if (((Rectangle)(ref val6)).Width != 0 && ((Rectangle)(ref val6)).Height != 0)
			{
				LinearGradientBrush val7 = new LinearGradientBrush(val6, Color.FromArgb(num12, val5), Color.Transparent, (LinearGradientMode)1);
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
		else
		{
			fc[P_4] = 0L;
			fC[0][P_4] = 0;
			fC[1][P_4] = 0;
		}
	}

	private void A(Graphics P_0, Font P_1, StringFormat P_2, int P_3, int P_4, float P_5, float P_6, int P_7, int P_8, int P_9, int P_10, int P_11)
	{
		for (int num = 0; num <= P_7; num++)
		{
			int num2 = num * P_9;
			int num3 = P_3 + num2 * P_4 / P_8;
			if (num % P_10 == 0)
			{
				P_0.DrawLine(Pens.Gray, (float)num3, P_6, (float)num3, P_5 + 3f);
			}
			if (num % P_11 == 0)
			{
				P_0.DrawString(num2.ToString(), P_1, Brushes.White, (float)num3, (float)(((Control)this).Height - 15), P_2);
			}
		}
	}

	private int A()
	{
		int result = 0;
		if (FX.Count == 2 && ((SettingOrSpecialObject)FX[0]).l() && ((SettingOrSpecialObject)FX[1]).l())
		{
			result = ((Control)fB).Bottom + 3;
		}
		return result;
	}

	private void A(out int P_0, out int P_1)
	{
		int num = A();
		P_0 = ((Control)this).Height - 10 - Fw.MaxDisplayMagnitude * (((Control)this).Height - num - 20) / 7000;
		P_1 = ((Control)this).Height - 10 - Fw.MinDisplayMagnitude * (((Control)this).Height - num - 20) / 7000;
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Button != 1048576)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		if (Fw != null)
		{
			A(out num, out num2);
		}
		Point location = e.Location;
		if (((Point)(ref location)).X >= ((Control)this).Width - 10)
		{
			location = e.Location;
			if (((Point)(ref location)).X <= ((Control)this).Width && Fw != null)
			{
				fF = e.Y;
				ff = num;
				fG = num2;
				int num3 = A();
				if (fF < num3 + 10 || fF > ((Control)this).Height - 10)
				{
					Fw.MinDisplayMagnitude = 0;
					Fw.MaxDisplayMagnitude = 7000;
					Fw.SaveKnockDetectionPreferences();
					((Control)this).Invalidate();
				}
				else if (fF > num && fF < num + 10)
				{
					fE = true;
				}
				else if (fF > num + 10 && fF < num2 - 10)
				{
					fd = true;
				}
				else if (fF > num2 - 10 && fF < num2)
				{
					fe = true;
				}
				return;
			}
		}
		if (((Control)this).Parent != null && ((Control)this).Parent is ck)
		{
			(((Control)this).Parent as ck).A(e.Button, e.X, e.Y);
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (Fw != null && (fd || fe || fE))
		{
			int num = A();
			int num2 = ((Control)this).Height - num - 20;
			if (fd)
			{
				int num3 = e.Y - fF;
				int num4 = fG - ff;
				int num5 = ff + num3;
				int num6 = fG + num3;
				if (num5 < num + 10)
				{
					num5 = num + 10;
					num6 = num5 + num4;
				}
				else if (num6 > ((Control)this).Height - 10)
				{
					num6 = ((Control)this).Height - 10;
					num5 = num6 - num4;
				}
				Fw.MinDisplayMagnitude = Math.Max(0, (((Control)this).Height - 10 - num6) * 7000 / num2);
				Fw.MaxDisplayMagnitude = Math.Min(7000, (((Control)this).Height - 10 - num5) * 7000 / num2);
			}
			else
			{
				A(out var _, out var _);
				if (fE)
				{
					Fw.MaxDisplayMagnitude = Math.Min(7000, Math.Max(Fw.MinDisplayMagnitude + 1000, (num2 - (e.Y - (10 + num))) * 7000 / num2));
				}
				else if (fe)
				{
					Fw.MinDisplayMagnitude = Math.Max(0, Math.Min(Fw.MaxDisplayMagnitude - 1000, (num2 - (e.Y - (10 + num))) * 7000 / num2));
				}
			}
			((Control)this).Invalidate();
		}
		else if (((Control)this).Parent != null && ((Control)this).Parent is ck)
		{
			(((Control)this).Parent as ck).A(e.X, e.Y);
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (((Control)this).Parent != null && ((Control)this).Parent is ck)
		{
			(((Control)this).Parent as ck).a(e.X, e.Y);
		}
		if (Fw != null && (fd || fe || fE))
		{
			Fw.SaveKnockDetectionPreferences();
		}
		fd = false;
		fE = false;
		fe = false;
	}
}
