using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using NSP.SettingsFramework;
using c;

namespace A;

internal class Z : Panel
{
	private const int fg = 500;

	private const int fH = 2048;

	private const int fh = 2;

	private const int fI = 10000;

	private Framework fi;

	private KnockDetection fJ;

	private Setting fj;

	private List<Setting> fK = new List<Setting>();

	private Stopwatch fk = new Stopwatch();

	private int[,,] fL = new int[2, 2048, 500];

	private int[] fl = new int[500];

	private bool fM;

	private bool fm;

	private bool fN;

	private int fn;

	private int fO;

	private int fo;

	internal Z(KnockDetection P_0, Framework P_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		fi = P_1;
		fJ = P_0;
		if (fJ != null)
		{
			fj = fi.A(fJ.DataIdOfCentreFrequencySetting);
			fj.A(new EventHandler(a));
			for (int num = 0; num < fJ.DataIdsOfFFTChannels.Count; num++)
			{
				Setting setting = fi.A(fJ.DataIdsOfFFTChannels[num]);
				fK.Add(setting);
				setting.A(new EventHandler(a));
			}
			fJ.OnNewFFTResult += new EventHandler(a);
			fJ.OnDisplayedFrequencyRangeChanged += new EventHandler(a);
			fJ.OnDisplayedMagnitudeRangeChanged += new EventHandler(a);
		}
		global::A.A.A(new EventHandler(A));
		global::A.A.A((D)A);
		BM.D(new EventHandler(A));
		((Control)this).DoubleBuffered = true;
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)131072, true);
		((Control)this).SetStyle((ControlStyles)2, true);
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		try
		{
			if (fj != null)
			{
				fj.a(new EventHandler(a));
			}
			Enumerator<Setting> enumerator = fK.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.a(new EventHandler(a));
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (fJ != null)
			{
				fJ.OnNewFFTResult -= new EventHandler(a);
				fJ.OnDisplayedFrequencyRangeChanged -= new EventHandler(a);
				fJ.OnDisplayedMagnitudeRangeChanged -= new EventHandler(a);
			}
			global::A.A.a(new EventHandler(A));
			global::A.A.a((D)A);
			BM.d(new EventHandler(A));
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

	private void A()
	{
		if (fJ == null)
		{
			return;
		}
		int num = 0;
		if (fk.IsRunning)
		{
			fk.Stop();
			num = (int)fk.ElapsedMilliseconds;
			int num2 = 10;
			num = Math.Max(num, num2);
			fk.Reset();
		}
		fk.Start();
		System.Array.Copy((System.Array)fl, 1, (System.Array)fl, 0, 499);
		fl[499] = num;
		int num3 = 0;
		if (fK.Count != 0)
		{
			num3 = fK.Count;
		}
		else if (fJ.FFTMagnitudesForSensorsXFrequencies != null)
		{
			num3 = ((System.Array)fJ.FFTMagnitudesForSensorsXFrequencies).GetLength(0);
		}
		for (int num4 = 0; num4 < num3; num4++)
		{
			int num5 = 0;
			if (fK.Count != 0)
			{
				num5 = fK[num4].av()[2];
			}
			else if (fJ.FFTMagnitudesForSensorsXFrequencies != null)
			{
				num5 = ((System.Array)fJ.FFTMagnitudesForSensorsXFrequencies).GetLength(1);
			}
			if (num5 > 2048)
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ez() + num5 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eA());
			}
			Setting knockSensorEnabler = fJ.GetKnockSensorEnabler(num4);
			bool flag = knockSensorEnabler != null && knockSensorEnabler.ax() != 0;
			for (int num6 = 0; num6 < num5; num6++)
			{
				int num7 = 0;
				if (fK.Count != 0)
				{
					if (flag)
					{
						num7 = fK[num4].m(num6);
					}
				}
				else if (fJ.FFTMagnitudesForSensorsXFrequencies != null && flag)
				{
					num7 = fJ.FFTMagnitudesForSensorsXFrequencies[num4, num6];
					num7 = KnockDetection.ConvertAudioSampleValueToDecibels(num7);
				}
				int num8 = num4 * 2048 * 500 + num6 * 500;
				int num9 = num8 + 1;
				System.Array.Copy((System.Array)fL, num9, (System.Array)fL, num8, 499);
				fL[num4, num6, 499] = num7;
			}
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected O, but got Unknown
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		Stopwatch val = new Stopwatch();
		val.Start();
		A();
		Graphics graphics = e.Graphics;
		graphics.Clear(Color.Black);
		if (fJ == null)
		{
			return;
		}
		int num = 0;
		if (fK.Count != 0)
		{
			num = fK[0].av()[2];
		}
		else if (fJ.FFTMagnitudesForSensorsXFrequencies != null)
		{
			num = ((System.Array)fJ.FFTMagnitudesForSensorsXFrequencies).GetLength(1);
		}
		int num2 = fj.ax();
		int num3 = ((fK.Count == 0) ? 20000 : (num2 * 2));
		if (num == 0 || num3 == 0)
		{
			val.Stop();
			return;
		}
		int num4 = Math.Min(fJ.MinDisplayFrequencyHz * num / num3, num - 2);
		int num5 = Math.Max(fJ.MaxDisplayFrequencyHz * num / num3 - num4, 2);
		string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ea();
		SizeF val2 = graphics.MeasureString(text, ((Control)this).Font);
		int num6 = (int)((SizeF)(ref val2)).Height;
		graphics.DrawString(text, ((Control)this).Font, Brushes.White, 3f, 3f);
		int num7 = ((Control)this).Width - 73;
		int num8 = ((Control)this).Height - 30;
		int num9 = 3 + num6;
		int num10 = num8 - num9;
		float num11 = (float)num10 / (float)num5;
		if (BM.A(fi.aXc, true) && !BM.aE())
		{
			int num12 = 0;
			int num13 = 0;
			Setting knockSensorEnabler = fJ.GetKnockSensorEnabler(1);
			bool flag = knockSensorEnabler != null && knockSensorEnabler.ax() != 0;
			int num14 = 499;
			SizeF val3 = default(SizeF);
			PointF val4 = default(PointF);
			while (num14 >= 0 && fl[num14] != 0 && num12 >= 0)
			{
				int num15 = num7 - num13 * num7 / 10000;
				((SizeF)(ref val3))._002Ector((float)Math.Max(num12 - num15, 1), Math.Max(num11, 1f));
				int num16 = 0;
				int num17 = -2147483648;
				float num18 = 0f;
				if (num14 != 499)
				{
					for (int num19 = num4; num19 <= num4 + num5; num19++)
					{
						int num20 = num10 * (num19 - num4) / num5;
						if (num20 != num16)
						{
							if (num4 != 0 || num19 - 1 != num4)
							{
								Color colourForMagnitude = fJ.GetColourForMagnitude(num17);
								((PointF)(ref val4))._002Ector((float)num15, (float)num8 - (float)num16 - num11);
								SolidBrush val5 = new SolidBrush(colourForMagnitude);
								try
								{
									graphics.FillRectangle((Brush)(object)val5, new RectangleF(val4, val3));
								}
								finally
								{
									((System.IDisposable)val5)?.Dispose();
								}
							}
							if (num14 == 498 && num10 > num5 * 2)
							{
								float num21 = num8 - num20;
								if (num21 + 7f < num18)
								{
									graphics.DrawLine(Pens.Gray, (float)num7, num21, (float)(num7 + 3), num21);
									float num22 = (float)(num19 * num3) / (1000f * (float)num);
									string text2 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eB(), (object)num22);
									SizeF val6 = graphics.MeasureString(text2, ((Control)this).Font);
									graphics.DrawString(text2, ((Control)this).Font, Brushes.White, (float)(num7 + 5), num21 - ((SizeF)(ref val6)).Height / 2f);
									num18 = num21 - ((SizeF)(ref val6)).Height / 2f;
								}
							}
							num16 = num20;
							num17 = -2147483648;
							if (num19 == num4 + num5)
							{
								break;
							}
						}
						else if (num19 == num4 && num14 == 498 && num10 > num5 * 2)
						{
							float num23 = num8;
							graphics.DrawLine(Pens.Gray, (float)num7, num23, (float)(num7 + 3), num23);
							float num24 = (float)(num19 * num3) / (1000f * (float)num);
							string text3 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eB(), (object)num24);
							SizeF val7 = graphics.MeasureString(text3, ((Control)this).Font);
							graphics.DrawString(text3, ((Control)this).Font, Brushes.White, (float)(num7 + 5), num23 - ((SizeF)(ref val7)).Height / 2f);
							num18 = num23 - ((SizeF)(ref val7)).Height / 2f;
						}
						int num25 = fL[0, num19, num14];
						if (flag)
						{
							num25 = Math.Max(num25, fL[1, num19, num14]);
						}
						num17 = Math.Max(num25, num17);
					}
					num13 += fl[num14];
				}
				num12 = num15;
				num14--;
			}
		}
		graphics.DrawLine(Pens.Gray, num7, num8, num7, 0);
		graphics.DrawLine(Pens.Gray, 0, num8, num7, num8);
		string text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eb();
		SizeF val8 = graphics.MeasureString(text4, ((Control)this).Font);
		int num26 = (int)((SizeF)(ref val8)).Width;
		graphics.DrawString(text4, ((Control)this).Font, Brushes.White, (float)(num7 / 2 - num26 / 2), (float)(num8 + 15));
		int num27 = 10;
		for (int num28 = 0; num28 < num27; num28++)
		{
			int num29 = num7 - num28 * num7 / num27;
			graphics.DrawLine(Pens.Gray, num29, num8 + 1, num29, num8 + 4);
			string text5 = num28.ToString();
			val8 = graphics.MeasureString(text5, ((Control)this).Font);
			int num30 = (int)((SizeF)(ref val8)).Width;
			graphics.DrawString(text5, ((Control)this).Font, Brushes.White, (float)(num29 - num30 / 2), (float)(num8 + 4));
		}
		if (num10 <= num5 * 2)
		{
			int num31 = fJ.MinDisplayFrequencyHz % 1000;
			int num32 = 0;
			if (num31 != 0)
			{
				num32 = 1000 - num31;
			}
			float num33 = 0f;
			for (int num34 = fJ.MinDisplayFrequencyHz + num32; num34 <= fJ.MaxDisplayFrequencyHz; num34 += 1000)
			{
				float num35 = num8 - (num34 - fJ.MinDisplayFrequencyHz) * num10 / (fJ.MaxDisplayFrequencyHz - fJ.MinDisplayFrequencyHz);
				if (num35 + 7f < num33 || num34 == fJ.MinDisplayFrequencyHz + num32)
				{
					graphics.DrawLine(Pens.Gray, (float)num7, num35, (float)(num7 + 3), num35);
					string text6 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eC(), (object)((float)num34 / 1000f));
					val8 = graphics.MeasureString(text6, ((Control)this).Font);
					int num36 = (int)((SizeF)(ref val8)).Height;
					graphics.DrawString(text6, ((Control)this).Font, Brushes.White, (float)(num7 + 5), num35 - (float)(num36 / 2));
					num33 = num35 - 5f;
				}
			}
		}
		int num37 = num4 * num3 / num;
		int num38 = (num4 + num5) * num3 / num;
		float num39 = num8 - num10 * (num2 - num37) / (num38 - num37);
		Pen val9 = new Pen(Color.Gray, 1f);
		try
		{
			val9.DashStyle = (DashStyle)2;
			graphics.DrawLine(val9, 0f, num39, (float)num7, num39);
		}
		finally
		{
			((System.IDisposable)val9)?.Dispose();
		}
		try
		{
			A(out var num40, out var num41);
			graphics.FillRectangle(Brushes.White, ((Control)this).Width - 8, num40, 6, num41 - num40);
			graphics.DrawLine(Pens.Black, ((Control)this).Width - 10, num40 + 10, ((Control)this).Width, num40 + 10);
			graphics.DrawLine(Pens.Black, ((Control)this).Width - 10, num41 - 10, ((Control)this).Width, num41 - 10);
			graphics.DrawRectangle(Pens.Gray, ((Control)this).Width - 10, 0, 9, ((Control)this).Height - 1);
			graphics.DrawLine(Pens.Gray, ((Control)this).Width - 10, 10, ((Control)this).Width, 10);
			graphics.DrawLine(Pens.Gray, ((Control)this).Width - 10, ((Control)this).Height - 10, ((Control)this).Width, ((Control)this).Height - 10);
		}
		catch
		{
		}
		val.Stop();
		N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ec(), (object)val.ElapsedMilliseconds), false);
	}

	private void A(out int P_0, out int P_1)
	{
		int num = ((fK.Count == 0) ? 20000 : (fj.ax() * 2));
		P_0 = ((Control)this).Height - 10 - fJ.MaxDisplayFrequencyHz * (((Control)this).Height - 20) / num;
		P_1 = ((Control)this).Height - 10 - fJ.MinDisplayFrequencyHz * (((Control)this).Height - 20) / num;
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Button != 1048576)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		if (fJ != null)
		{
			A(out num, out num2);
		}
		Point location = e.Location;
		if (((Point)(ref location)).X >= ((Control)this).Width - 10)
		{
			location = e.Location;
			if (((Point)(ref location)).X <= ((Control)this).Width && fJ != null)
			{
				fn = e.Y;
				fO = num;
				fo = num2;
				if (fn < 10 || fn > ((Control)this).Height - 10)
				{
					fJ.MinDisplayFrequencyHz = 0;
					if (fK.Count != 0)
					{
						int num3 = fj.ax();
						fJ.MaxDisplayFrequencyHz = num3 * 2;
					}
					else
					{
						fJ.MaxDisplayFrequencyHz = 20000;
					}
					fJ.SaveKnockDetectionPreferences();
					((Control)this).Invalidate();
				}
				else if (fn > num && fn < num + 10)
				{
					fm = true;
				}
				else if (fn > num + 10 && fn < num2 - 10)
				{
					fM = true;
				}
				else if (fn > num2 - 10 && fn < num2)
				{
					fN = true;
				}
				return;
			}
		}
		if (((Control)this).Parent != null && ((Control)this).Parent is cL)
		{
			(((Control)this).Parent as cL).A(e.Button, e.X, e.Y);
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (fJ != null && (fM || fN || fm))
		{
			int num = ((fK.Count == 0) ? 20000 : (fj.ax() * 2));
			int num2 = ((Control)this).Height - 20;
			if (fM)
			{
				int num3 = e.Y - fn;
				int num4 = fo - fO;
				int num5 = fO + num3;
				int num6 = fo + num3;
				if (num5 < 10)
				{
					num5 = 10;
					num6 = num5 + num4;
				}
				else if (num6 > ((Control)this).Height - 10)
				{
					num6 = ((Control)this).Height - 10;
					num5 = num6 - num4;
				}
				fJ.MaxDisplayFrequencyHz = Math.Min(num, (((Control)this).Height - 10 - num5) * num / num2);
				fJ.MinDisplayFrequencyHz = Math.Max(0, (((Control)this).Height - 10 - num6) * num / num2);
			}
			else
			{
				A(out var _, out var _);
				if (fm)
				{
					fJ.MaxDisplayFrequencyHz = Math.Min(num, Math.Max(fJ.MinDisplayFrequencyHz + 1000, (num2 - (e.Y - 10)) * num / num2));
				}
				else if (fN)
				{
					fJ.MinDisplayFrequencyHz = Math.Max(0, Math.Min(fJ.MaxDisplayFrequencyHz - 1000, (num2 - (e.Y - 10)) * num / num2));
				}
			}
			((Control)this).Invalidate();
		}
		else if (((Control)this).Parent != null && ((Control)this).Parent is cL)
		{
			(((Control)this).Parent as cL).A(e.X, e.Y);
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (((Control)this).Parent != null && ((Control)this).Parent is cL)
		{
			(((Control)this).Parent as cL).a(e.X, e.Y);
		}
		if (fJ != null && (fM || fN || fm))
		{
			fJ.SaveKnockDetectionPreferences();
		}
		fM = false;
		fm = false;
		fN = false;
	}
}
internal class z : Panel
{
	private Framework fP;

	private KnockDetection fp;

	private Setting fQ;

	private List<Setting> fq = new List<Setting>();

	private bool fR;

	private bool fr;

	private bool fS;

	private bool fs;

	private bool fT;

	private bool ft;

	private int fU;

	private int fu;

	private int fV;

	private int fv;

	private int fW;

	private int fw;

	internal z(KnockDetection P_0, Framework P_1)
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		fP = P_1;
		fp = P_0;
		if (fp != null)
		{
			fQ = fP.A(fp.DataIdOfCentreFrequencySetting);
			fQ.A(new EventHandler(a));
			for (int num = 0; num < fp.DataIdsOfFFTChannels.Count; num++)
			{
				Setting setting = fP.A(fp.DataIdsOfFFTChannels[num]);
				fq.Add(setting);
				setting.A(new EventHandler(a));
			}
			fp.OnNewFFTResult += new EventHandler(a);
			fp.OnDisplayedFrequencyRangeChanged += new EventHandler(a);
			fp.OnDisplayedMagnitudeRangeChanged += new EventHandler(a);
		}
		global::A.A.A(new EventHandler(A));
		global::A.A.A((D)A);
		BM.D(new EventHandler(A));
		((Control)this).DoubleBuffered = true;
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)131072, true);
		((Control)this).SetStyle((ControlStyles)2, true);
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		try
		{
			if (fQ != null)
			{
				fQ.a(new EventHandler(a));
			}
			Enumerator<Setting> enumerator = fq.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.a(new EventHandler(a));
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (fp != null)
			{
				fp.OnNewFFTResult -= new EventHandler(a);
				fp.OnDisplayedFrequencyRangeChanged -= new EventHandler(a);
				fp.OnDisplayedMagnitudeRangeChanged -= new EventHandler(a);
			}
			global::A.A.a(new EventHandler(A));
			global::A.A.a((D)A);
			BM.d(new EventHandler(A));
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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		Stopwatch val = new Stopwatch();
		val.Start();
		Graphics graphics = e.Graphics;
		graphics.Clear(Color.Black);
		if (fp == null)
		{
			return;
		}
		int num = 0;
		if (fq.Count != 0)
		{
			num = fq[0].av()[2];
		}
		else if (fp.FFTMagnitudesForSensorsXFrequencies != null)
		{
			num = ((System.Array)fp.FFTMagnitudesForSensorsXFrequencies).GetLength(1);
		}
		int num2 = fQ.ax();
		int num3 = ((fq.Count == 0) ? 20000 : (num2 * 2));
		if (num == 0 || num3 == 0)
		{
			val.Stop();
			return;
		}
		int num4 = Math.Min(fp.MinDisplayFrequencyHz * num / num3, num - 2);
		int num5 = Math.Max(fp.MaxDisplayFrequencyHz * num / num3 - num4, 2);
		string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eD();
		SizeF val2 = graphics.MeasureString(text, ((Control)this).Font);
		float height = ((SizeF)(ref val2)).Height;
		graphics.DrawString(text, ((Control)this).Font, Brushes.White, 3f, 3f);
		int num6 = ((Control)this).Width - 47;
		float num7 = (float)((Control)this).Height - 30f;
		float num8 = 3f + height;
		float num9 = num7 - num8;
		graphics.DrawLine(Pens.Gray, 0f, num7, (float)num6, num7);
		graphics.DrawLine(Pens.Gray, (float)num6, num7, (float)num6, 0f);
		float num10 = (float)num6 / (float)num5;
		if (BM.A(fP.aXc, true) && !BM.aE())
		{
			Setting knockSensorEnabler = fp.GetKnockSensorEnabler(0);
			bool flag = knockSensorEnabler != null && knockSensorEnabler.ax() != 0;
			Setting knockSensorEnabler2 = fp.GetKnockSensorEnabler(1);
			bool flag2 = knockSensorEnabler2 != null && knockSensorEnabler2.ax() != 0;
			int num11 = 0;
			int num12 = -2147483648;
			float num13 = 0f;
			PointF val3 = default(PointF);
			SizeF val4 = default(SizeF);
			for (int num14 = num4; num14 <= num4 + num5; num14++)
			{
				int num15 = num6 * (num14 - num4) / num5;
				if (num15 != num11)
				{
					if ((num4 != 0 || num14 - 1 != num4) && num12 >= fp.MinDisplayMagnitude)
					{
						Color colourForMagnitude = fp.GetColourForMagnitude(num12);
						int num16 = Math.Max(Math.Min(num12, fp.MaxDisplayMagnitude), fp.MinDisplayMagnitude);
						float num17 = num9 * ((float)(num16 - fp.MinDisplayMagnitude) / (float)(fp.MaxDisplayMagnitude - fp.MinDisplayMagnitude));
						float num18 = (float)((Control)this).Height - (30f + num17);
						if (num6 <= num5 * 4)
						{
							((PointF)(ref val3))._002Ector((float)num11, num18);
							((SizeF)(ref val4))._002Ector(Math.Max(num10, 1f), num17);
						}
						else
						{
							((PointF)(ref val3))._002Ector((float)num11 + num10 / 16f, num18);
							((SizeF)(ref val4))._002Ector(Math.Max(num10 * 7f / 8f, 1f), num17);
						}
						SolidBrush val5 = new SolidBrush(colourForMagnitude);
						try
						{
							graphics.FillRectangle((Brush)(object)val5, new RectangleF(val3, val4));
						}
						finally
						{
							((System.IDisposable)val5)?.Dispose();
						}
					}
					if (num6 > num5 * 4)
					{
						float num19 = num15;
						if (num19 - 25f > num13)
						{
							graphics.DrawLine(Pens.Gray, num19, num7, num19, num7 + 3f);
							float num20 = (float)(num14 * num3) / (1000f * (float)num);
							string text2 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eB(), (object)num20);
							SizeF val6 = graphics.MeasureString(text2, ((Control)this).Font);
							graphics.DrawString(text2, ((Control)this).Font, Brushes.White, num19 - ((SizeF)(ref val6)).Width / 2f, num7 + 4f);
							num13 = num19 + ((SizeF)(ref val6)).Width / 2f;
						}
					}
					num11 = num15;
					num12 = -2147483648;
					if (num14 == num4 + num5)
					{
						break;
					}
				}
				else if (num14 == num4 && num6 > num5 * 4)
				{
					float num21 = 0f;
					graphics.DrawLine(Pens.Gray, num21, num7, num21, num7 + 3f);
					float num22 = (float)(num14 * num3) / (1000f * (float)num);
					string text3 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eB(), (object)num22);
					SizeF val7 = graphics.MeasureString(text3, ((Control)this).Font);
					graphics.DrawString(text3, ((Control)this).Font, Brushes.White, num21 - ((SizeF)(ref val7)).Width / 2f, num7 + 4f);
					num13 = num21 + ((SizeF)(ref val7)).Width / 2f;
				}
				int num23 = 0;
				if (fq.Count != 0)
				{
					if (flag)
					{
						num23 = fq[0].m(num14);
					}
					if (flag2)
					{
						num23 = Math.Max(num23, fq[1].m(num14));
					}
				}
				else
				{
					if (flag)
					{
						num23 = fp.FFTMagnitudesForSensorsXFrequencies[0, num14];
					}
					if (flag2)
					{
						num23 = Math.Max(num23, fp.FFTMagnitudesForSensorsXFrequencies[1, num14]);
					}
					num23 = KnockDetection.ConvertAudioSampleValueToDecibels(num23);
				}
				num12 = Math.Max(num23, num12);
			}
		}
		if (num6 <= num5 * 4)
		{
			int num24 = fp.MinDisplayFrequencyHz % 1000;
			int num25 = 0;
			if (num24 != 0)
			{
				num25 = 1000 - num24;
			}
			float num26 = 0f;
			for (int num27 = fp.MinDisplayFrequencyHz + num25; num27 <= fp.MaxDisplayFrequencyHz; num27 += 1000)
			{
				float num28 = (num27 - fp.MinDisplayFrequencyHz) * num6 / (fp.MaxDisplayFrequencyHz - fp.MinDisplayFrequencyHz);
				if (num28 - 25f > num26 || num27 == fp.MinDisplayFrequencyHz + num25)
				{
					graphics.DrawLine(Pens.Gray, num28, num7, num28, num7 + 3f);
					string text4 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eC(), (object)((float)num27 / 1000f));
					val2 = graphics.MeasureString(text4, ((Control)this).Font);
					int num29 = (int)((SizeF)(ref val2)).Width;
					graphics.DrawString(text4, ((Control)this).Font, Brushes.White, num28 - (float)(num29 / 2), num7 + 4f);
					num26 = num28 + 22f;
				}
			}
		}
		int num30 = num4 * num3 / num;
		int num31 = (num4 + num5) * num3 / num;
		float num32 = num6 * (num2 - num30) / (num31 - num30);
		Pen val8 = new Pen(Color.Gray, 1f);
		try
		{
			val8.DashStyle = (DashStyle)2;
			graphics.DrawLine(val8, num32, num7, num32, num8);
		}
		finally
		{
			((System.IDisposable)val8)?.Dispose();
		}
		try
		{
			A(out var num33, out var num34);
			graphics.FillRectangle(Brushes.White, num33, ((Control)this).Height - 8, num34 - num33, 6);
			graphics.DrawLine(Pens.Black, num33 + 10, ((Control)this).Height - 10, num33 + 10, ((Control)this).Height);
			graphics.DrawLine(Pens.Black, num34 - 10, ((Control)this).Height - 10, num34 - 10, ((Control)this).Height);
			graphics.DrawRectangle(Pens.Gray, 0, ((Control)this).Height - 10, ((Control)this).Width - 11, 9);
			graphics.DrawLine(Pens.Gray, 10, ((Control)this).Height - 10, 10, ((Control)this).Height);
			graphics.DrawLine(Pens.Gray, ((Control)this).Width - 20, ((Control)this).Height - 10, ((Control)this).Width - 20, ((Control)this).Height);
		}
		catch
		{
		}
		try
		{
			a(out var num35, out var num36);
			graphics.FillRectangle(Brushes.White, ((Control)this).Width - 8, num35, 6, num36 - num35);
			graphics.DrawLine(Pens.Black, ((Control)this).Width - 10, num35 + 10, ((Control)this).Width, num35 + 10);
			graphics.DrawLine(Pens.Black, ((Control)this).Width - 10, num36 - 10, ((Control)this).Width, num36 - 10);
			graphics.DrawRectangle(Pens.Gray, ((Control)this).Width - 10, 0, 9, ((Control)this).Height - 11);
			graphics.DrawLine(Pens.Gray, ((Control)this).Width - 10, 10, ((Control)this).Width, 10);
			graphics.DrawLine(Pens.Gray, ((Control)this).Width - 10, ((Control)this).Height - 20, ((Control)this).Width, ((Control)this).Height - 20);
		}
		catch
		{
		}
		string text5 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EZ(), (object)(fp.MinDisplayMagnitude / 100));
		val2 = graphics.MeasureString(text5, ((Control)this).Font);
		int num37 = (int)((SizeF)(ref val2)).Height;
		string text6 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EZ(), (object)(fp.MaxDisplayMagnitude / 100));
		val2 = graphics.MeasureString(text6, ((Control)this).Font);
		int num38 = (int)((SizeF)(ref val2)).Height;
		graphics.DrawString(text5, ((Control)this).Font, Brushes.White, (float)(num6 + 1), (float)((Control)this).Height - 30f - (float)num37 / 2f);
		graphics.DrawString(text6, ((Control)this).Font, Brushes.White, (float)(num6 + 1), num8 - (float)num38 / 2f);
		val.Stop();
		N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ed(), (object)val.ElapsedMilliseconds), false);
	}

	private void A(out int P_0, out int P_1)
	{
		int num = ((fq.Count == 0) ? 20000 : (fQ.ax() * 2));
		P_0 = 10 + fp.MinDisplayFrequencyHz * (((Control)this).Width - 30) / num;
		P_1 = 10 + fp.MaxDisplayFrequencyHz * (((Control)this).Width - 30) / num;
	}

	private void a(out int P_0, out int P_1)
	{
		P_0 = ((Control)this).Height - 20 - fp.MaxDisplayMagnitude * (((Control)this).Height - 30) / 7000;
		P_1 = ((Control)this).Height - 20 - fp.MinDisplayMagnitude * (((Control)this).Height - 30) / 7000;
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Button != 1048576)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		if (fp != null)
		{
			A(out num, out num2);
			a(out num3, out num4);
		}
		Point location = e.Location;
		if (((Point)(ref location)).Y >= ((Control)this).Height - 10)
		{
			location = e.Location;
			if (((Point)(ref location)).Y <= ((Control)this).Height && fp != null)
			{
				fU = e.X;
				fV = num;
				fv = num2;
				if (fU < 10 || (fU > ((Control)this).Width - 20 && fU < ((Control)this).Width - 10))
				{
					fp.MinDisplayFrequencyHz = 0;
					if (fq.Count != 0)
					{
						int num5 = fQ.ax();
						fp.MaxDisplayFrequencyHz = num5 * 2;
					}
					else
					{
						fp.MaxDisplayFrequencyHz = 20000;
					}
					fp.SaveKnockDetectionPreferences();
					((Control)this).Invalidate();
				}
				else if (fU > num && fU < num + 10)
				{
					fS = true;
				}
				else if (fU > num + 10 && fU < num2 - 10)
				{
					fR = true;
				}
				else if (fU > num2 - 10 && fU < num2)
				{
					fr = true;
				}
				return;
			}
		}
		location = e.Location;
		if (((Point)(ref location)).X >= ((Control)this).Width - 10)
		{
			location = e.Location;
			if (((Point)(ref location)).X <= ((Control)this).Width && fp != null)
			{
				fu = e.Y;
				fW = num3;
				fw = num4;
				if (fu < 10 || (fu > ((Control)this).Height - 20 && fu < ((Control)this).Height - 10))
				{
					fp.MinDisplayMagnitude = 0;
					fp.MaxDisplayMagnitude = 7000;
					fp.SaveKnockDetectionPreferences();
					((Control)this).Invalidate();
				}
				else if (fu > num3 && fu < num3 + 10)
				{
					fT = true;
				}
				else if (fu > num3 + 10 && fu < num4 - 10)
				{
					fs = true;
				}
				else if (fu > num4 - 10 && fu < num4)
				{
					ft = true;
				}
				return;
			}
		}
		if (((Control)this).Parent != null && ((Control)this).Parent is cl)
		{
			(((Control)this).Parent as cl).A(e.Button, e.X, e.Y);
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (fp != null && (fR || fS || fr))
		{
			int num = ((fq.Count == 0) ? 20000 : (fQ.ax() * 2));
			int num2 = ((Control)this).Width - 30;
			if (fR)
			{
				int num3 = e.X - fU;
				int num4 = fv - fV;
				int num5 = fV + num3;
				int num6 = fv + num3;
				if (num5 < 10)
				{
					num5 = 10;
					num6 = num5 + num4;
				}
				else if (num6 > ((Control)this).Width - 20)
				{
					num6 = ((Control)this).Width - 20;
					num5 = num6 - num4;
				}
				fp.MaxDisplayFrequencyHz = Math.Min(num, (num6 - 10) * num / num2);
				fp.MinDisplayFrequencyHz = Math.Max(0, (num5 - 10) * num / num2);
			}
			else
			{
				A(out var _, out var _);
				if (fr)
				{
					fp.MaxDisplayFrequencyHz = Math.Min(num, Math.Max(fp.MinDisplayFrequencyHz + 1000, (e.X - 10) * num / num2));
				}
				else if (fS)
				{
					fp.MinDisplayFrequencyHz = Math.Max(0, Math.Min(fp.MaxDisplayFrequencyHz - 1000, (e.X - 10) * num / num2));
				}
			}
			((Control)this).Invalidate();
		}
		else if (fp != null && (fs || ft || fT))
		{
			int num9 = ((Control)this).Height - 30;
			if (fs)
			{
				int num10 = e.Y - fu;
				int num11 = fw - fW;
				int num12 = fW + num10;
				int num13 = fw + num10;
				if (num12 < 10)
				{
					num12 = 10;
					num13 = num12 + num11;
				}
				else if (num13 > ((Control)this).Height - 20)
				{
					num13 = ((Control)this).Height - 20;
					num12 = num13 - num11;
				}
				fp.MinDisplayMagnitude = Math.Max(0, (((Control)this).Height - 20 - num13) * 7000 / num9);
				fp.MaxDisplayMagnitude = Math.Min(7000, (((Control)this).Height - 20 - num12) * 7000 / num9);
			}
			else
			{
				a(out var _, out var _);
				if (fT)
				{
					fp.MaxDisplayMagnitude = Math.Min(7000, Math.Max(fp.MinDisplayMagnitude + 1000, (num9 - (e.Y - 10)) * 7000 / num9));
				}
				else if (ft)
				{
					fp.MinDisplayMagnitude = Math.Max(0, Math.Min(fp.MaxDisplayMagnitude - 1000, (num9 - (e.Y - 10)) * 7000 / num9));
				}
			}
			((Control)this).Invalidate();
		}
		else if (((Control)this).Parent != null && ((Control)this).Parent is cl)
		{
			(((Control)this).Parent as cl).A(e.X, e.Y);
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (((Control)this).Parent != null && ((Control)this).Parent is cl)
		{
			(((Control)this).Parent as cl).a(e.X, e.Y);
		}
		if (fp != null && (fR || fS || fr || fs || ft || fT))
		{
			fp.SaveKnockDetectionPreferences();
		}
		fR = false;
		fr = false;
		fS = false;
		fs = false;
		fT = false;
		ft = false;
	}
}
