using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;

namespace c
{
	internal class cH : MovableResizablePanel
	{
		private const int BHp = 45;

		private const int BHQ = 357;

		private const int BHq = 20;

		private const int BHR = 266;

		private const int BHr = 312;

		private const int BHS = 246;

		private int BHs = 10;

		private int BHT = 2;

		private string BHt = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAo();

		private string BHU = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gC();

		private string BHu = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAP();

		private string BHV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gC();

		private Framework BHv;

		private Framework BHW;

		private Setting BHw;

		private Setting BHX;

		private Setting BHx;

		private Setting BHY;

		private PointF BHy = new PointF(0f, 0f);

		private PointF BHZ = new PointF(100f, 100f);

		private PointF BHz = new PointF(0f, 0f);

		private PointF BhA = new PointF(100f, 100f);

		private PointF Bha = new PointF(0f, 0f);

		private PointF BhB = new PointF(100f, 100f);

		private Matrix Bhb = new Matrix();

		private Matrix BhC = new Matrix();

		private Matrix Bhc = new Matrix();

		private Matrix BhD = new Matrix();

		private int Bhd = -1;

		private bool BhE;

		private bool Bhe;

		internal cH(BezierCurve P_0, Framework P_1, Framework P_2, Rectangle P_3, bool P_4)
			: base(P_3, P_4, false, true)
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected O, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Expected O, but got Unknown
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Expected O, but got Unknown
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_0281: Expected O, but got Unknown
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Unknown result type (might be due to invalid IL or missing references)
			BHv = P_1;
			BHW = P_2;
			((Control)this).DoubleBuffered = true;
			BHw = ((SettingOrSpecialObject)P_0).a()[0] as Setting;
			BHX = ((SettingOrSpecialObject)P_0).a()[1] as Setting;
			BHw.A(new EventHandler(a));
			BHX.A(new EventHandler(B));
			if (BHW != null)
			{
				BHx = BHW.A(BHw.A());
				BHY = BHW.A(BHX.A());
			}
			B(new PointF((float)(BHw.m(0) / 10), (float)(BHX.m(0) / 10)));
			b(new PointF((float)(BHw.m(1) / 10), (float)(BHX.m(1) / 10)));
			if (BHx != null && BHY != null)
			{
				C(new PointF((float)(BHx.m(0) / 10), (float)(BHY.m(0) / 10)));
				c(new PointF((float)(BHx.m(1) / 10), (float)(BHY.m(1) / 10)));
			}
			a();
			BM.QQ.B(new EventHandler(A));
			BhE = BHv.B() && BHv.b() && (BHw.J() || BHX.J());
			Bhe = BHW != null && BHW.B() && BHW.b() && (BHx.J() || BHY.J());
			if (P_3 != Rectangle.Empty)
			{
				((Control)this).Width = ((Rectangle)(ref P_3)).Width;
				((Control)this).Height = ((Rectangle)(ref P_3)).Height;
				((Control)this).Left = ((Rectangle)(ref P_3)).Left;
				((Control)this).Top = ((Rectangle)(ref P_3)).Top;
			}
			else
			{
				((Control)this).Width = 377;
				((Control)this).Height = 306;
			}
		}

		private void a()
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected O, but got Unknown
			SizeF val = default(SizeF);
			((SizeF)(ref val))._002Ector(312f / (((PointF)(ref BHZ)).X - ((PointF)(ref BHy)).X), -246f / (((PointF)(ref BHZ)).Y - ((PointF)(ref BHy)).Y));
			SizeF val2 = default(SizeF);
			((SizeF)(ref val2))._002Ector(45f, 266f);
			Bhb = new Matrix();
			Bhb.Translate(((SizeF)(ref val2)).Width, ((SizeF)(ref val2)).Height);
			Bhb.Scale(((SizeF)(ref val)).Width, ((SizeF)(ref val)).Height);
			BhC = Bhb.Clone();
			BhC.Invert();
			Bhc = new Matrix();
			Bhc.Translate(((SizeF)(ref val2)).Width, ((SizeF)(ref val2)).Height);
			Bhc.Scale(((SizeF)(ref val)).Width, ((SizeF)(ref val)).Height);
			BhD = Bhc.Clone();
			BhD.Invert();
		}

		[SpecialName]
		internal new PointF B()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return BHy;
		}

		[SpecialName]
		internal void A(PointF P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			if (BHy != P_0)
			{
				BHy = P_0;
				a();
				((Control)this).Invalidate();
			}
		}

		[SpecialName]
		internal new PointF b()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return BHZ;
		}

		[SpecialName]
		internal void a(PointF P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			if (BHZ != P_0)
			{
				BHZ = P_0;
				a();
				((Control)this).Invalidate();
			}
		}

		[SpecialName]
		internal PointF C()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return BHz;
		}

		[SpecialName]
		internal void B(PointF P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			if (BHz != P_0)
			{
				BHz = P_0;
				if (((PointF)(ref BHz)).X < ((PointF)(ref BHy)).X)
				{
					((PointF)(ref BHz)).X = ((PointF)(ref BHy)).X;
				}
				if (((PointF)(ref BHz)).Y < ((PointF)(ref BHy)).Y)
				{
					((PointF)(ref BHz)).Y = ((PointF)(ref BHy)).Y;
				}
				if (((PointF)(ref BHz)).X > ((PointF)(ref BHZ)).X)
				{
					((PointF)(ref BHz)).X = ((PointF)(ref BHZ)).X;
				}
				if (((PointF)(ref BHz)).Y > ((PointF)(ref BHZ)).Y)
				{
					((PointF)(ref BHz)).Y = ((PointF)(ref BHZ)).Y;
				}
				((Control)this).Invalidate();
			}
		}

		[SpecialName]
		internal PointF c()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return BhA;
		}

		[SpecialName]
		internal void b(PointF P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			if (BhA != P_0)
			{
				BhA = P_0;
				if (((PointF)(ref BhA)).X < ((PointF)(ref BHy)).X)
				{
					((PointF)(ref BhA)).X = ((PointF)(ref BHy)).X;
				}
				if (((PointF)(ref BhA)).Y < ((PointF)(ref BHy)).Y)
				{
					((PointF)(ref BhA)).Y = ((PointF)(ref BHy)).Y;
				}
				if (((PointF)(ref BhA)).X > ((PointF)(ref BHZ)).X)
				{
					((PointF)(ref BhA)).X = ((PointF)(ref BHZ)).X;
				}
				if (((PointF)(ref BhA)).Y > ((PointF)(ref BHZ)).Y)
				{
					((PointF)(ref BhA)).Y = ((PointF)(ref BHZ)).Y;
				}
				((Control)this).Invalidate();
			}
		}

		[SpecialName]
		private PointF D()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return Bha;
		}

		[SpecialName]
		private void C(PointF P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			if (Bha != P_0)
			{
				Bha = P_0;
				if (((PointF)(ref Bha)).X < ((PointF)(ref BHy)).X)
				{
					((PointF)(ref Bha)).X = ((PointF)(ref BHy)).X;
				}
				if (((PointF)(ref Bha)).Y < ((PointF)(ref BHy)).Y)
				{
					((PointF)(ref Bha)).Y = ((PointF)(ref BHy)).Y;
				}
				if (((PointF)(ref Bha)).X > ((PointF)(ref BHZ)).X)
				{
					((PointF)(ref Bha)).X = ((PointF)(ref BHZ)).X;
				}
				if (((PointF)(ref Bha)).Y > ((PointF)(ref BHZ)).Y)
				{
					((PointF)(ref Bha)).Y = ((PointF)(ref BHZ)).Y;
				}
				((Control)this).Invalidate();
			}
		}

		[SpecialName]
		private PointF d()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return BhB;
		}

		[SpecialName]
		private void c(PointF P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			if (BhB != P_0)
			{
				BhB = P_0;
				if (((PointF)(ref BhB)).X < ((PointF)(ref BHy)).X)
				{
					((PointF)(ref BhB)).X = ((PointF)(ref BHy)).X;
				}
				if (((PointF)(ref BhB)).Y < ((PointF)(ref BHy)).Y)
				{
					((PointF)(ref BhB)).Y = ((PointF)(ref BHy)).Y;
				}
				if (((PointF)(ref BhB)).X > ((PointF)(ref BHZ)).X)
				{
					((PointF)(ref BhB)).X = ((PointF)(ref BHZ)).X;
				}
				if (((PointF)(ref BhB)).Y > ((PointF)(ref BHZ)).Y)
				{
					((PointF)(ref BhB)).Y = ((PointF)(ref BHZ)).Y;
				}
				((Control)this).Invalidate();
			}
		}

		protected override void MouseDownHandler(object sender, MouseEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)e.Button == 1048576 && (e.X < 35 || e.X > 367 || e.Y < 10 || e.Y > 276))
			{
				base.MouseDownHandler(sender, e);
			}
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).OnMouseDown(e);
			if (BM.QO == BM.b.BpG || !BHv.C())
			{
				return;
			}
			if (!BhE)
			{
				PointF[] array = (PointF[])(object)new PointF[2] { BHz, BhA };
				Bhb.TransformPoints(array);
				float num = (float)BHs / 2f;
				for (int i = 0; i < array.Length; i++)
				{
					if ((float)e.X >= ((PointF)(ref array[i])).X - num && (float)e.X <= ((PointF)(ref array[i])).X + num && (float)e.Y >= ((PointF)(ref array[i])).Y - num && (float)e.Y <= ((PointF)(ref array[i])).Y + num)
					{
						Bhd = i;
						return;
					}
				}
			}
			Bhd = -1;
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).OnMouseMove(e);
			if (BM.QO != BM.b.BpG && BHv.C() && !BhE && Bhd != -1)
			{
				Point[] array = (Point[])(object)new Point[1] { e.Location };
				BhC.TransformPoints(array);
				switch (Bhd)
				{
				case 0:
					B(Point.op_Implicit(array[0]));
					break;
				case 1:
					b(Point.op_Implicit(array[0]));
					break;
				}
				((Control)this).Invalidate();
			}
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).OnMouseUp(e);
			if (BM.QO == BM.b.BpG || !BHv.C())
			{
				return;
			}
			if (!BhE)
			{
				Ck ck2 = BM.aM();
				ck2?.A(BHw.A());
				PointF val;
				if (Bhd == 0)
				{
					Setting bHw = BHw;
					val = C();
					bHw.a(0, (int)(((PointF)(ref val)).X * 10f), true);
					Setting bHX = BHX;
					val = C();
					bHX.a(0, (int)(((PointF)(ref val)).Y * 10f), true);
				}
				else if (Bhd == 1)
				{
					Setting bHw2 = BHw;
					val = c();
					bHw2.a(1, (int)(((PointF)(ref val)).X * 10f), true);
					Setting bHX2 = BHX;
					val = c();
					bHX2.a(1, (int)(((PointF)(ref val)).Y * 10f), true);
				}
				ck2?.B();
			}
			Bhd = -1;
		}

		protected override void OnResize(EventArgs e)
		{
			a();
			((Panel)this).OnResize(e);
		}

		protected override void OnPaddingChanged(EventArgs e)
		{
			a();
			((Control)this).Invalidate();
			((ScrollableControl)this).OnPaddingChanged(e);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Expected O, but got Unknown
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected O, but got Unknown
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Expected O, but got Unknown
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected O, but got Unknown
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Expected O, but got Unknown
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Expected O, but got Unknown
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Expected O, but got Unknown
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected O, but got Unknown
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0313: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0499: Unknown result type (might be due to invalid IL or missing references)
			//IL_049e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0533: Unknown result type (might be due to invalid IL or missing references)
			//IL_053a: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05af: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0554: Unknown result type (might be due to invalid IL or missing references)
			//IL_0560: Unknown result type (might be due to invalid IL or missing references)
			//IL_0567: Expected O, but got Unknown
			//IL_0571: Unknown result type (might be due to invalid IL or missing references)
			//IL_0578: Unknown result type (might be due to invalid IL or missing references)
			//IL_057f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0586: Unknown result type (might be due to invalid IL or missing references)
			//IL_067c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0683: Unknown result type (might be due to invalid IL or missing references)
			//IL_0697: Unknown result type (might be due to invalid IL or missing references)
			//IL_069e: Unknown result type (might be due to invalid IL or missing references)
			//IL_078a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0799: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0604: Unknown result type (might be due to invalid IL or missing references)
			//IL_074a: Unknown result type (might be due to invalid IL or missing references)
			//IL_074f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0756: Expected O, but got Unknown
			//IL_0618: Unknown result type (might be due to invalid IL or missing references)
			//IL_0624: Unknown result type (might be due to invalid IL or missing references)
			//IL_062b: Expected O, but got Unknown
			//IL_075e: Unknown result type (might be due to invalid IL or missing references)
			//IL_076d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0635: Unknown result type (might be due to invalid IL or missing references)
			//IL_063c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0643: Unknown result type (might be due to invalid IL or missing references)
			//IL_064a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0858: Unknown result type (might be due to invalid IL or missing references)
			//IL_0867: Unknown result type (might be due to invalid IL or missing references)
			//IL_087b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0880: Unknown result type (might be due to invalid IL or missing references)
			//IL_0887: Expected O, but got Unknown
			//IL_088f: Unknown result type (might be due to invalid IL or missing references)
			//IL_089e: Unknown result type (might be due to invalid IL or missing references)
			base.OnPaint(e);
			if ((BM.QO != BM.b.BpG || BHW == null) ? BhE : Bhe)
			{
				SolidBrush val = new SolidBrush(BM.te);
				try
				{
					Font val2 = new Font(((Control)this).Font.FontFamily, ((Control)this).Font.Size, (FontStyle)1);
					try
					{
						e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)BHw).D().A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO(), val2, (Brush)(object)val, 10f, 10f);
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
			PointF[] array = (PointF[])(object)new PointF[4] { BHy, BHz, BhA, BHZ };
			Bhb.TransformPoints(array);
			PointF[] array2 = (PointF[])(object)new PointF[4] { BHy, Bha, BhB, BHZ };
			Bhc.TransformPoints(array2);
			SolidBrush val3 = new SolidBrush(BM.te);
			try
			{
				Pen val4 = new Pen(Color.Gray, 1f);
				try
				{
					Pen val5 = new Pen(BM.te);
					try
					{
						Pen val6 = new Pen(BM.te, (float)BHT);
						try
						{
							Brush val7 = (Brush)new SolidBrush(BM.te);
							try
							{
								Pen val8 = new Pen(BM.te);
								try
								{
									Pen val9 = new Pen(Color.FromArgb(100, Color.Gray), (float)BHT);
									try
									{
										Font val10 = new Font(((Control)this).Font.FontFamily, ((Control)this).Font.Size, (FontStyle)1);
										try
										{
											e.Graphics.SmoothingMode = (SmoothingMode)3;
											val4.DashStyle = (DashStyle)1;
											e.Graphics.DrawLine(val5, 45, 266, 357, 266);
											PointF val11 = default(PointF);
											((PointF)(ref val11))._002Ector(0f, 266f);
											e.Graphics.TextRenderingHint = (TextRenderingHint)5;
											SizeF val12;
											for (int i = 0; i < 11; i++)
											{
												float num = i * 10;
												((PointF)(ref val11)).X = 45f + 31.2f * (float)i;
												val12 = e.Graphics.MeasureString(num.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAp()), ((Control)this).Font);
												e.Graphics.DrawString(num.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAQ()), ((Control)this).Font, (Brush)(object)val3, ((PointF)(ref val11)).X - ((SizeF)(ref val12)).Width / 2f, 268f);
												e.Graphics.DrawLine(val5, ((PointF)(ref val11)).X, ((PointF)(ref val11)).Y, ((PointF)(ref val11)).X, ((PointF)(ref val11)).Y - 4f);
												e.Graphics.DrawLine(val4, ((PointF)(ref val11)).X, ((PointF)(ref val11)).Y, ((PointF)(ref val11)).X, 20f);
											}
											val12 = e.Graphics.MeasureString(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAq(), (object)BHt, (object)BHU), val10);
											e.Graphics.DrawString(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAq(), (object)BHt, (object)BHU), val10, (Brush)(object)val3, 201f - ((SizeF)(ref val12)).Width / 2f, 286f);
											e.Graphics.DrawLine(val5, 45, 266, 45, 20);
											((PointF)(ref val11))._002Ector(45f, 0f);
											e.Graphics.TextRenderingHint = (TextRenderingHint)5;
											for (int j = 0; j < 11; j++)
											{
												float num2 = 100 - j * 10;
												((PointF)(ref val11)).Y = 20f + 24.6f * (float)j;
												val12 = e.Graphics.MeasureString(num2.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAp()), ((Control)this).Font);
												e.Graphics.DrawString(num2.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAQ()), ((Control)this).Font, (Brush)(object)val3, 45f - ((SizeF)(ref val12)).Width - 2f, ((PointF)(ref val11)).Y - ((SizeF)(ref val12)).Height / 2f);
												e.Graphics.DrawLine(val5, ((PointF)(ref val11)).X, ((PointF)(ref val11)).Y, ((PointF)(ref val11)).X + 4f, ((PointF)(ref val11)).Y);
												e.Graphics.DrawLine(val4, ((PointF)(ref val11)).X, ((PointF)(ref val11)).Y, 357f, ((PointF)(ref val11)).Y);
											}
											val12 = e.Graphics.MeasureString(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAq(), (object)BHu, (object)BHV), val10);
											e.Graphics.TranslateTransform(25f - ((SizeF)(ref val12)).Height, 143f + ((SizeF)(ref val12)).Width / 2f);
											e.Graphics.RotateTransform(-90f);
											e.Graphics.DrawString(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAq(), (object)BHu, (object)BHV), val10, (Brush)(object)val3, 0f, 0f);
											e.Graphics.ResetTransform();
											e.Graphics.SmoothingMode = (SmoothingMode)2;
											val9.DashStyle = (DashStyle)1;
											e.Graphics.DrawLine(val9, array[0], array[3]);
											if (BM.QO == BM.b.BpG)
											{
												if (!BhE)
												{
													Pen val13 = new Pen(BM.tD, (float)BHT);
													try
													{
														e.Graphics.DrawBezier(val13, array[0], array[1], array[2], array[3]);
													}
													finally
													{
														((System.IDisposable)val13)?.Dispose();
													}
												}
											}
											else
											{
												e.Graphics.DrawBezier(val6, array[0], array[1], array[2], array[3]);
											}
											if (BHx != null && BHY != null)
											{
												if (BM.QO == BM.b.BpG)
												{
													e.Graphics.DrawBezier(val6, array2[0], array2[1], array2[2], array2[3]);
												}
												else if (!Bhe)
												{
													Pen val14 = new Pen(BM.tD, (float)BHT);
													try
													{
														e.Graphics.DrawBezier(val14, array2[0], array2[1], array2[2], array2[3]);
													}
													finally
													{
														((System.IDisposable)val14)?.Dispose();
													}
												}
											}
											val8.DashStyle = (DashStyle)1;
											if (BM.QO != BM.b.BpG)
											{
												e.Graphics.DrawLine(val8, array[1], array[0]);
												e.Graphics.DrawLine(val8, array[2], array[3]);
											}
											RectangleF val15 = default(RectangleF);
											((RectangleF)(ref val15))._002Ector(((PointF)(ref array[1])).X - (float)BHs / 2f, ((PointF)(ref array[1])).Y - (float)BHs / 2f, (float)BHs, (float)BHs);
											RectangleF val16 = default(RectangleF);
											((RectangleF)(ref val16))._002Ector(((PointF)(ref array[2])).X - (float)BHs / 2f, ((PointF)(ref array[2])).Y - (float)BHs / 2f, (float)BHs, (float)BHs);
											if (BM.QO == BM.b.BpG)
											{
												if (!BhE)
												{
													Brush val17 = (Brush)new SolidBrush(BM.tD);
													try
													{
														e.Graphics.FillEllipse(val17, val15);
														e.Graphics.FillEllipse(val17, val16);
													}
													finally
													{
														((System.IDisposable)val17)?.Dispose();
													}
												}
											}
											else
											{
												e.Graphics.FillEllipse(val7, val15);
												e.Graphics.FillEllipse(val7, val16);
											}
											if (BHx == null || BHY == null)
											{
												return;
											}
											RectangleF val18 = default(RectangleF);
											((RectangleF)(ref val18))._002Ector(((PointF)(ref array2[1])).X - (float)BHs / 2f, ((PointF)(ref array2[1])).Y - (float)BHs / 2f, (float)BHs, (float)BHs);
											RectangleF val19 = default(RectangleF);
											((RectangleF)(ref val19))._002Ector(((PointF)(ref array2[2])).X - (float)BHs / 2f, ((PointF)(ref array2[2])).Y - (float)BHs / 2f, (float)BHs, (float)BHs);
											if (BM.QO == BM.b.BpG)
											{
												e.Graphics.FillEllipse(val7, val18);
												e.Graphics.FillEllipse(val7, val19);
											}
											else if (!Bhe)
											{
												Brush val20 = (Brush)new SolidBrush(BM.tD);
												try
												{
													e.Graphics.FillEllipse(val20, val18);
													e.Graphics.FillEllipse(val20, val19);
													return;
												}
												finally
												{
													((System.IDisposable)val20)?.Dispose();
												}
											}
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
									((System.IDisposable)val8)?.Dispose();
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
					finally
					{
						((System.IDisposable)val5)?.Dispose();
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

		private void A(object P_0, EventArgs P_1)
		{
			((Control)this).Invalidate();
		}

		protected override void Dispose(bool disposing)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			try
			{
				BHw.a(new EventHandler(a));
				BHX.a(new EventHandler(B));
				BM.QQ.b(new EventHandler(A));
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			if (BM.QO != BM.b.BpG)
			{
				((Control)this).Invalidate();
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			if (BM.QO != BM.b.BpG)
			{
				a();
				B(new PointF((float)(BHw.m(0) / 10), (float)(BHX.m(0) / 10)));
				b(new PointF((float)(BHw.m(1) / 10), (float)(BHX.m(1) / 10)));
				((Control)this).Invalidate();
			}
		}
	}
	internal class ch : MovableResizablePanel
	{
		internal new enum A
		{
			BUm,
			BUN,
			BUn,
			BUO,
			BUo,
			BUP,
			BUp,
			BUQ,
			BUq
		}

		internal new enum a
		{
			BUR,
			BUr,
			BUS
		}

		[Serializable]
		[CompilerGenerated]
		private new sealed class B
		{
			public static readonly B BUs = new B();

			public static Action BUT;

			internal void A()
			{
				Bhk.c();
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private new struct b
		{
			public ch BUt;

			public Dk BUU;

			public int BUu;

			public int BUV;

			public int BUv;

			public int BUW;

			public int BUw;

			public int BUX;
		}

		[CompilerGenerated]
		private sealed class C
		{
			public ch BUx;

			public int BUY;

			public int BUy;

			public Size BUZ;

			internal void A()
			{
				//IL_0028: Unknown result type (might be due to invalid IL or missing references)
				((Control)BUx).Width = BUY;
				((Control)BUx).Height = BUy;
				((Control)Bhk).Size = BUZ;
			}

			internal void a()
			{
				((Control)BUx).Refresh();
			}

			internal void B()
			{
				((Control)Bhl).Top = ((Control)BUx).Top + ((Control)BUx).Height + 10;
			}
		}

		[CompilerGenerated]
		private sealed class c
		{
			public bool BUz;

			public ch BuA;

			internal void A()
			{
				BUz = BM.QQ.rl.A((Control)(object)BuA);
			}
		}

		internal Framework Bhi;

		private Rectangle BhJ;

		private int Bhj = -1;

		internal const string BhK = "dash_virtual";

		internal static VirtualDashAppPanel Bhk = null;

		internal TransparentPanel BhL = new TransparentPanel();

		internal static cw Bhl = null;

		private V BhM;

		internal List<Setting.ListItems.A> Bhm;

		private Dictionary<int, string> BhN = new Dictionary<int, string>();

		private List<int> Bhn = new List<int>();

		private const string BhO = "Dial Gauges";

		private bool Bho;

		private bool BhP;

		private bool Bhp;

		private bool BhQ;

		private float Bhq;

		private int BhR;

		private int Bhr;

		private int BhS;

		private int Bhs = -1;

		private float BhT = 1f;

		private const int Bht = 200;

		private int BhU = Environment.TickCount;

		private Cursor Bhu = Cursor.Current;

		private Cursor BhV;

		private const int Bhv = 500;

		private int BhW = 1280;

		private int Bhw = 480;

		private const int BhX = -1;

		private cQ Bhx;

		private Point BhY = new Point(0, 0);

		private int Bhy;

		private int BhZ;

		private int Bhz;

		private int BIA;

		private int BIa;

		private int BIB;

		private bool BIb;

		private int BIC = -1;

		private Ck BIc;

		private int BID = -1;

		private int BId = -1;

		private Timer BIE;

		private static bool BIe = true;

		private double BIF = 1.0;

		private bool BIf;

		private u BIG;

		internal static bool BIg = false;

		private const int BIH = 10;

		private static int BIh = -1;

		private A BII;

		internal static int A(Framework P_0)
		{
			if (P_0.awZ == 21 && P_0.awz == 11)
			{
				return 860;
			}
			if (P_0.awZ == 21 && P_0.awz == 12)
			{
				return 1280;
			}
			if (P_0.awZ == 21 && P_0.awz == 41)
			{
				return 2560;
			}
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAR());
		}

		internal static int a(Framework P_0)
		{
			if (P_0.awZ == 21 && P_0.awz == 11)
			{
				return 480;
			}
			if (P_0.awZ == 21 && P_0.awz == 12)
			{
				return 480;
			}
			if (P_0.awZ == 21 && P_0.awz == 41)
			{
				return 720;
			}
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAr());
		}

		internal DK a()
		{
			return Bhi.awP.E()[Bhj];
		}

		private void A(int P_0 = -1)
		{
			((Control)this).Focus();
			DK dK = a();
			int num = -32767;
			BID = -1;
			int num2 = 0;
			int count = dK.a().Count;
			int num3 = -BhW;
			int num4 = -Bhw;
			int num5 = BhW * 2;
			int num6 = Bhw * 2;
			for (int i = num2; i < count; i++)
			{
				Dk dk = dK.a()[i];
				if (dK.a()[i].B().ax() <= 0)
				{
					continue;
				}
				int num7 = dk.d().ax();
				int num8 = dk.E().ax();
				int num9 = dk.C().ax();
				int num10 = dk.c().ax();
				if (Bhy > num9 - 10 && Bhy < num9 + num7 + 10 && BhZ > num10 - 10 && BhZ < num10 + num8 + 10)
				{
					int num11 = dk.D().ax();
					int num12 = dk.f().ax();
					if ((num11 > num || (a(num9, num3, num5) && a(num9 + num7, num3, num5) && a(num10, num4, num6) && a(num10 + num8, num4, num6))) && num12 != BID)
					{
						BIa = num7;
						BIB = num8;
						num = num11;
						BID = i + 1;
						Bhz = Bhy;
						BIA = BhZ;
						num3 = num9;
						num4 = num10;
						num5 = num9 + num7;
						num6 = num10 + num8;
					}
				}
			}
			if (BID == -1)
			{
				D(0);
				BId = -1;
				BhM.A(null);
				return;
			}
			D(BID);
			A(BID - 1, true);
			BM.QQ.rL.A(Bhj, BID - 1);
			BIb = false;
			Dk dk2 = dK.a()[BID - 1];
			if (dk2.F().ax() > 0)
			{
				dk2.F().ax();
				BhM.A(dk2);
			}
		}

		private bool A(Point P_0, int P_1, int P_2)
		{
			bool result = false;
			Dk dk = a().a()[P_1 - 1];
			if (dk.B().ax() > 0)
			{
				int num = dk.d().ax();
				int num2 = dk.E().ax();
				int num3 = dk.C().ax();
				int num4 = dk.c().ax();
				int num5 = P_2;
				int num6 = P_2;
				switch (BII)
				{
				case ch.A.BUN:
				case ch.A.BUn:
					num6 = 0;
					break;
				case ch.A.BUO:
				case ch.A.BUo:
					num5 = 0;
					break;
				}
				if (((Point)(ref P_0)).X > num3 - num5 && ((Point)(ref P_0)).X < num3 + num + num5 && ((Point)(ref P_0)).Y > num4 - num6 && ((Point)(ref P_0)).Y < num4 + num2 + num6)
				{
					result = true;
				}
			}
			return result;
		}

		internal void a(int P_0)
		{
			try
			{
				DK dK = a();
				if (P_0 > -1 && P_0 < dK.a().Count)
				{
					D(0);
					bool flag = BID != P_0 + 1;
					BID = P_0 + 1;
					D(BID);
					A(P_0, flag);
					Dk dk = dK.a()[BID - 1];
					if (dk.F().ax() > 0)
					{
						BhM.A(dk);
					}
					BM.QQ.rL.A(Bhj, BID - 1);
				}
			}
			catch
			{
			}
		}

		private void A(int P_0, bool P_1 = true)
		{
			if (Bhl != null && P_0 >= 0)
			{
				Bhl.B(P_0);
			}
			BId = P_0;
			if (P_1)
			{
				((Control)this).Focus();
			}
		}

		internal List<int> A(Point P_0)
		{
			List<int> val = new List<int>();
			((Control)this).Focus();
			DK dK = a();
			for (int i = 0; i < dK.a().Count; i++)
			{
				Dk dk = dK.a()[i];
				if (dK.a()[i].B().ax() > 0)
				{
					int num = dk.d().ax();
					int num2 = dk.E().ax();
					int num3 = dk.C().ax();
					int num4 = dk.c().ax();
					if (((Point)(ref P_0)).X > num3 && ((Point)(ref P_0)).X < num3 + num && ((Point)(ref P_0)).Y > num4 && ((Point)(ref P_0)).Y < num4 + num2)
					{
						val.Add(i);
					}
				}
			}
			return val;
		}

		internal List<string> A(List<int> P_0)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
			List<string> val = new List<string>();
			DK dK = a();
			Enumerator<int> enumerator = P_0.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					Dk dk = dK.a()[current];
					int num = dk.B().ax();
					text = dk.Bc();
					if (num > 0)
					{
						string text2 = dk.e().ay();
						if (text2.Length <= 0)
						{
							text2 = string.Concat(new string[9]
							{
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aJz(),
								dk.C().ax().ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ(),
								dk.c().ax().ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ(),
								dk.d().ax().ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ(),
								dk.E().ax().ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGk()
							});
						}
						if (string.IsNullOrEmpty(text))
						{
							text = (BhN.ContainsKey(num) ? BhN[num] : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAS());
						}
						text2 = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
						val.Add(text2);
					}
				}
				return val;
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private new void A(int P_0, int P_1)
		{
			if (!BIf && (!Bho || ((Control)Bhl).ContainsFocus))
			{
				return;
			}
			if (BID == -1)
			{
				A();
				return;
			}
			D(BID);
			DK dK = a();
			for (int i = 0; i < dK.a().Count; i++)
			{
				Dk dk = dK.a()[i];
				int num = dK.a()[i].B().ax();
				int num2 = dK.a()[i].f().ax();
				if (num > 0 && (i == BID - 1 || num2 == BID))
				{
					int num3 = P_0 - Bhz;
					int num4 = P_1 - BIA;
					if ((num3 != 0 || num4 != 0) && Math.Abs(num3) < BhW / 2 && Math.Abs(num4) < Bhw / 2)
					{
						int num5 = dk.C().ax();
						int num6 = dk.c().ax();
						int num7 = num5 + num3;
						int num8 = num6 + num4;
						dk.C().a(num7, true);
						dk.c().a(num8, true);
					}
				}
			}
			Bhz = P_0;
			BIA = P_1;
		}

		private new void B()
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			DK dK = a();
			BID = -1;
			Enumerator<Dk> enumerator = dK.a().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Dk current = enumerator.Current;
					current.B().a(0, true);
					BM.b(current.B().A());
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		internal new bool b()
		{
			DK dK = a();
			if (dK != null)
			{
				return dK.B() >= dK.a().Count;
			}
			return true;
		}

		internal void C()
		{
			if (b() || BID == -1)
			{
				return;
			}
			DK dK = a();
			int num = -1;
			for (int i = 0; i < dK.a().Count; i++)
			{
				if (dK.a()[i].B().ax() == 0)
				{
					num = i;
					break;
				}
			}
			if (num >= 0)
			{
				Dk dk = dK.a()[num];
				Ck ck2 = BM.aM();
				ck2?.a();
				Dk dk2 = dK.a()[BID - 1];
				dk.a(dk2, true);
				dk.e().A(dk.e().ay() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax() + num, true);
				int num2 = A(dk);
				dk.D().a(num2, true);
				ck2?.B();
				BM.Z();
				while (BM.z())
				{
					Application.DoEvents();
				}
				a(num);
			}
		}

		internal void c()
		{
			if (Bhi != null && Bhi.awP != null && BID > 0)
			{
				Bhi.awP.a(Bhj, BID - 1);
			}
		}

		internal void D()
		{
			if (b())
			{
				return;
			}
			DK dK = a();
			int num = -1;
			for (int i = 0; i < dK.a().Count; i++)
			{
				if (dK.a()[i].B().ax() == 0)
				{
					num = i;
					break;
				}
			}
			if (num < 0 || Bhi == null || Bhi.awP == null)
			{
				return;
			}
			Dk dk = Bhi.awP.B(Bhj, num);
			if (dk != null)
			{
				dk.C().a(Bhy, true);
				dk.c().a(BhZ, true);
				int num2 = A(dk);
				dk.D().a(num2, true);
				dk.e().A(dk.e().ay() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax() + num, true);
				BM.Z();
				while (BM.z())
				{
					Application.DoEvents();
				}
				a(num);
			}
		}

		internal void A(int P_0, int P_1, int P_2)
		{
			if (b())
			{
				return;
			}
			DK dK = a();
			int num = -1;
			for (int i = 0; i < dK.a().Count; i++)
			{
				Dk dk = dK.a()[i];
				if (dk.B().ax() == 0)
				{
					Ck ck2 = BM.aM();
					ck2?.a();
					dk.B().a(P_0, true);
					BM.b(dk.B().A());
					while (BM.z())
					{
						Application.DoEvents();
					}
					dk.a();
					dk.C().a(P_1, true);
					BM.b(dk.C().A());
					dk.c().a(P_2, true);
					BM.b(dk.c().A());
					dk.b().a(0, true);
					BM.b(dk.b().A());
					int num2 = A(dk);
					dk.D().a(num2, true);
					BM.b(dk.D().A());
					string text = (BhN.ContainsKey(P_0) ? BhN[P_0] : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAS());
					dk.e().A(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax() + i, true);
					ck2?.B();
					num = i;
					break;
				}
			}
			a(num);
		}

		private int A(Dk P_0)
		{
			int num = 0;
			int num2 = 1;
			if (P_0 != null && P_0 != null)
			{
				int num3 = P_0.d().ax();
				int num4 = P_0.E().ax();
				int num5 = P_0.C().ax();
				int num6 = P_0.c().ax();
				num2 = P_0.D().ar();
				for (int i = 0; i < a().a().Count; i++)
				{
					Dk dk = a().a()[i];
					if (dk != P_0 && a().a()[i].B().ax() > 0)
					{
						int num7 = dk.d().ax();
						int num8 = dk.E().ax();
						int num9 = dk.C().ax();
						int num10 = dk.c().ax();
						int num11 = dk.D().ax();
						if ((B(num5, num9, num9 + num7) && B(num6, num10, num10 + num8)) || (B(num5 + num3, num9, num9 + num7) && B(num6, num10, num10 + num8)) || (B(num5, num9, num9 + num7) && B(num6 + num4, num10, num10 + num8)) || (B(num5 + num3, num9, num9 + num7) && B(num6 + num4, num10, num10 + num8)) || (B(num9, num5, num5 + num3) && B(num10, num6, num6 + num4)) || (B(num9 + num7, num5, num5 + num3) && B(num10, num6, num6 + num4)) || (B(num9, num5, num5 + num3) && B(num10 + num8, num6, num6 + num4)) || (B(num9 + num7, num5, num5 + num3) && B(num10 + num8, num6, num6 + num4)))
						{
							num = Math.Max(num, num11);
						}
					}
				}
			}
			return Math.Min(num2, num + 1);
		}

		internal void d()
		{
			if (BID == -1)
			{
				A();
			}
			if (!H())
			{
				return;
			}
			int num = BID - 1;
			DK dK = a();
			if (num < dK.a().Count && dK.B() > 0)
			{
				Dk dk = dK.a()[num];
				Ck ck2 = BM.aM();
				ck2?.a();
				dk.B().a(0, true);
				BM.b(dk.B().A());
				ck2?.B();
				BID = -1;
				if (Bhl != null)
				{
					Bhl.a(0);
				}
				D(0);
				Thread.Sleep(10);
			}
		}

		private void B(int P_0)
		{
			if (BID == -1)
			{
				A();
			}
			if (BID != -1)
			{
				Dk dk = a().a()[BID - 1];
				dk.B().ax();
				int num = dk.d().ax();
				int num2 = dk.E().ax();
				Ck ck2 = BM.aM();
				ck2?.a();
				double num3 = (double)P_0 / 100.0;
				dk.d().a((int)((double)num * num3), true);
				BM.b(dk.d().A());
				dk.E().a((int)((double)num2 * num3), true);
				BM.b(dk.E().A());
				ck2?.B();
			}
		}

		private void A(int P_0, int P_1, A P_2)
		{
			b b = default(b);
			b.BUt = this;
			b.BUu = P_0;
			b.BUW = P_1;
			if (BID == -1)
			{
				A();
			}
			if (BID == -1)
			{
				return;
			}
			BhQ = false;
			DK dK = a();
			b.BUU = dK.a()[BID - 1];
			int num = b.BUU.B().ax();
			if (Bhn.Contains(num) || P_2 == ch.A.BUp || P_2 == ch.A.BUP || P_2 == ch.A.BUq || P_2 == ch.A.BUQ)
			{
				BhQ = true;
			}
			int num2 = b.BUU.d().ax();
			int num3 = b.BUU.E().ax();
			b.BUV = b.BUU.C().ax();
			b.BUX = b.BUU.c().ax();
			b.BUv = b.BUV + num2;
			b.BUw = b.BUX + num3;
			switch (P_2)
			{
			case ch.A.BUn:
				A(ref b);
				break;
			case ch.A.BUN:
				a(ref b);
				break;
			case ch.A.BUo:
				this.b(ref b);
				break;
			case ch.A.BUO:
				B(ref b);
				break;
			case ch.A.BUP:
				if (BhP || BhQ)
				{
					int num4 = Math.Abs(b.BUu - b.BUv);
					int num5 = A(num4, ref b);
					b.BUU.C().a(Math.Min(b.BUu, b.BUv), true);
					b.BUU.c().a(b.BUw - num5, true);
					b.BUU.E().a(num5, true);
					b.BUU.d().a(num4, true);
					B(num4, ref b);
				}
				else
				{
					B(ref b);
					a(ref b);
				}
				break;
			case ch.A.BUp:
				a(ref b);
				if (!BhP && !BhQ)
				{
					this.b(ref b);
				}
				break;
			case ch.A.BUQ:
				B(ref b);
				if (!BhP && !BhQ)
				{
					A(ref b);
				}
				break;
			case ch.A.BUq:
				A(ref b);
				if (!BhP && !BhQ)
				{
					this.b(ref b);
				}
				break;
			}
		}

		private void b(int P_0)
		{
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected O, but got Unknown
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected O, but got Unknown
			BID = -1;
			D(0);
			Bho = false;
			BIF = (double)P_0 / 100.0;
			if (BhM != null)
			{
				BhM.A(P_0);
			}
			a();
			Bhi.awP.d().a(P_0, true);
			BM.b(Bhi.awP.d().A());
			int BUY = Math.Max((int)((double)BhW * BIF), 470);
			int BUy = (int)((double)Bhw * BIF) + 26;
			Size BUZ = new Size((int)((double)BhW * BIF), BUy - 26);
			if (((Control)Bhk).InvokeRequired)
			{
				((Control)Bhk).Invoke((Action)delegate
				{
					//IL_0028: Unknown result type (might be due to invalid IL or missing references)
					((Control)this).Width = BUY;
					((Control)this).Height = BUy;
					((Control)Bhk).Size = BUZ;
				});
			}
			else
			{
				((Control)this).Width = BUY;
				((Control)this).Height = BUy;
				((Control)Bhk).Size = BUZ;
			}
			G();
			g();
			if (Bhx != null)
			{
				Bhx.A(BIF);
			}
			if (((Control)Bhk).InvokeRequired)
			{
				((Control)Bhk).Invoke((Action)delegate
				{
					((Control)this).Refresh();
				});
			}
			else
			{
				((Control)this).Refresh();
			}
			if (Bhl != null && ((Control)this).Parent != null)
			{
				if (((Control)Bhl).InvokeRequired)
				{
					((Control)Bhl).Invoke((Action)delegate
					{
						((Control)Bhl).Top = ((Control)this).Top + ((Control)this).Height + 10;
					});
				}
				else
				{
					((Control)Bhl).Top = ((Control)this).Top + ((Control)this).Height + 10;
				}
			}
			Thread.Sleep(100);
		}

		internal void C(int P_0)
		{
			B(P_0);
		}

		internal void c(int P_0)
		{
			b(P_0);
			cb.A(false);
		}

		internal new void A(bool P_0)
		{
			BIe = P_0;
			if (!BIe)
			{
				c(100);
			}
		}

		private void E()
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			if (BIE != null)
			{
				BIE.Close();
				BIE = null;
			}
			BIE = new Timer();
			BIE.Interval = 500.0;
			BIE.SynchronizingObject = (ISynchronizeInvoke)(object)this;
			BIE.Elapsed += new ElapsedEventHandler(A);
			BIE.AutoReset = true;
			BIE.Enabled = true;
			BIE.Start();
		}

		private void e()
		{
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)this).Parent == null || !(((Control)this).Parent is aF))
			{
				return;
			}
			int num = Math.Min((int)(BIF * 100.0), 100);
			int num2 = 100;
			if (((Control)this).Width > ((Control)this).Parent.Width - 20 || ((Control)this).Width < BhW)
			{
				num2 = (((Control)this).Parent.Width - 40) * 100 / BhW;
				num2 = Math.Min(num2, 100);
				num2 = Math.Max(num2, 60);
			}
			int num3 = 100;
			if (Bhl != null)
			{
				int height = ((Control)this).Parent.Height;
				int top = ((Control)Bhl).Top;
				Point autoScrollPosition = ((ScrollableControl)(((Control)this).Parent as aF)).AutoScrollPosition;
				int num4 = height - (top - ((Point)(ref autoScrollPosition)).Y);
				if (num4 < 200 || num4 > 220)
				{
					int num5 = ((Control)this).Height - 26;
					num3 = (num5 - (220 - num4)) * 100 / num5;
					num3 = num3 * num5 / Bhw;
				}
				else
				{
					num3 = num;
				}
				num3 = Math.Min(num3, 100);
				num3 = Math.Max(num3, 60);
			}
			int num6 = Math.Min(num3, num2);
			if (num6 < num - 5 || num6 > num + 5)
			{
				c(num6);
			}
			else if (Bhi.awP.d().ax() != num)
			{
				Bhi.awP.d().a(num, true);
			}
		}

		private void F()
		{
			if (!H())
			{
				return;
			}
			DK dK = a();
			if (dK != null)
			{
				Dk dk = dK.a()[BID - 1];
				if (dk != null && dk.B().ax() <= 0)
				{
					D(0);
				}
			}
		}

		private bool f()
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			bool BUz = false;
			if (((Control)BM.QQ.rl).InvokeRequired)
			{
				((Control)BM.QQ.rl).Invoke((Action)delegate
				{
					BUz = BM.QQ.rl.A((Control)(object)this);
				});
			}
			else
			{
				BUz = BM.QQ.rl.A((Control)(object)this);
			}
			return BUz;
		}

		private void A(object P_0, ElapsedEventArgs P_1)
		{
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected O, but got Unknown
			if (f() && (!cb.A() || cb.Bdy != BhM))
			{
				if (Process.GetProcessesByName(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dx()).Length == 0)
				{
					return;
				}
				cb.A(Bhi, BhM);
				cb.A(false);
				cb.a();
			}
			if (BIe && ((Control)this).Visible && f())
			{
				e();
			}
			if (Bhi != null && Bhi.awP.H())
			{
				F();
			}
			if (Bhk == null)
			{
				return;
			}
			if (((Control)Bhk).InvokeRequired)
			{
				VirtualDashAppPanel bhk = Bhk;
				object obj = ch.B.BUT;
				if (obj == null)
				{
					Action val = delegate
					{
						Bhk.c();
					};
					ch.B.BUT = val;
					obj = (object)val;
				}
				((Control)bhk).Invoke((Action)obj);
			}
			else
			{
				Bhk.c();
			}
			if (((Control)BhL).InvokeRequired)
			{
				((Control)BhL).Invoke((Action)([CompilerGenerated] () =>
				{
					((Control)BhL).BringToFront();
				}));
			}
			else
			{
				((Control)BhL).BringToFront();
			}
			if (((Control)BhM).InvokeRequired)
			{
				((Control)BhM).Invoke((Action)([CompilerGenerated] () =>
				{
					((Control)BhM).BringToFront();
				}));
			}
			else
			{
				((Control)BhM).BringToFront();
			}
		}

		private void G()
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			if (((Control)BhL).InvokeRequired)
			{
				((Control)BhL).Invoke((Action)([CompilerGenerated] () =>
				{
					((Control)BhL).Left = 0;
					((Control)BhL).Top = 0;
					((Control)BhL).Width = (int)((double)BhW * BIF);
					((Control)BhL).Height = ((Control)this).Height - 26;
				}));
			}
			else
			{
				((Control)BhL).Left = 0;
				((Control)BhL).Top = 0;
				((Control)BhL).Width = (int)((double)BhW * BIF);
				((Control)BhL).Height = ((Control)this).Height - 26;
			}
		}

		private void g()
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			if (((Control)BhM).InvokeRequired)
			{
				((Control)BhM).Invoke((Action)([CompilerGenerated] () =>
				{
					((Control)BhM).Left = 0;
					((Control)BhM).Top = ((Control)BhL).Height;
					((Control)BhM).Width = ((Control)this).Width;
					((Control)BhM).Height = 26;
				}));
			}
			else
			{
				((Control)BhM).Left = 0;
				((Control)BhM).Top = ((Control)BhL).Height;
				((Control)BhM).Width = ((Control)this).Width;
				((Control)BhM).Height = 26;
			}
		}

		private void A(object P_0, PreviewKeyDownEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Invalid comparison between Unknown and I4
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Invalid comparison between Unknown and I4
			Keys keyCode = P_1.KeyCode;
			if (keyCode - 37 <= 3 || (int)keyCode == 46)
			{
				P_1.IsInputKey = true;
			}
		}

		private void A(object P_0, KeyEventArgs P_1)
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_045e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0326: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)this).Focused && H())
			{
				BIf = true;
				int num = 5;
				if (((System.Enum)Control.ModifierKeys).HasFlag((System.Enum)(object)(Keys)131072))
				{
					num = 1;
				}
				else if (((System.Enum)Control.ModifierKeys).HasFlag((System.Enum)(object)(Keys)65536))
				{
					num = 10;
				}
				Dk dk = a().a()[BID - 1];
				switch (P_1.KeyValue)
				{
				case 37:
				{
					Ck ck5 = BM.aM();
					ck5?.a();
					A(Bhz - num, BIA);
					ck5?.B();
					BM.b(dk.C().A());
					BM.b(dk.c().A());
					P_1.Handled = true;
					break;
				}
				case 39:
				{
					Ck ck2 = BM.aM();
					ck2?.a();
					A(Bhz + num, BIA);
					ck2?.B();
					BM.b(dk.C().A());
					BM.b(dk.c().A());
					P_1.Handled = true;
					break;
				}
				case 38:
				{
					Ck ck4 = BM.aM();
					ck4?.a();
					A(Bhz, BIA - num);
					ck4?.B();
					BM.b(dk.C().A());
					BM.b(dk.c().A());
					P_1.Handled = true;
					break;
				}
				case 40:
				{
					Ck ck3 = BM.aM();
					ck3?.a();
					A(Bhz, BIA + num);
					ck3?.B();
					BM.b(dk.C().A());
					BM.b(dk.c().A());
					P_1.Handled = true;
					break;
				}
				case 46:
					if (BM.QQ.rL.A().B() != null && BM.QQ.rL.A().B().Tag is MenuNode && (BM.QQ.rL.A().B().Tag as MenuNode).M() && BM.QQ.rL.A().B().Parent != null && BM.QQ.rL.A().B().Parent.Tag is MenuNode && (BM.QQ.rL.A().B().Parent.Tag as MenuNode).l())
					{
						BM.QQ.rL.A().A(BM.QQ.rL.A().B().Parent);
					}
					d();
					P_1.Handled = true;
					break;
				case 67:
					if (((System.Enum)Control.ModifierKeys).HasFlag((System.Enum)(object)(Keys)131072) && Bhi != null && Bhi.awP.H() && BM.QQ.rL.A().B() != null && BM.QQ.rL.A().B().Tag is MenuNode && (BM.QQ.rL.A().B().Tag as MenuNode).M() && BM.QQ.rL.A().B().Parent != null && BM.QQ.rL.A().B().Parent.Tag is MenuNode && (BM.QQ.rL.A().B().Parent.Tag as MenuNode).l())
					{
						c();
					}
					P_1.Handled = true;
					break;
				}
			}
			if (((Control)this).Focused && Bhi != null && Bhi.awP.H() && ((System.Enum)Control.ModifierKeys).HasFlag((System.Enum)(object)(Keys)131072) && P_1.KeyValue == 86)
			{
				D();
				P_1.Handled = true;
			}
			BIf = false;
		}

		private void A(object P_0, MouseEventArgs P_1)
		{
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Invalid comparison between Unknown and I4
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Invalid comparison between Unknown and I4
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Invalid comparison between Unknown and I4
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
			if (!f())
			{
				return;
			}
			int left = ((Control)BhL).Left;
			int top = ((Control)BhL).Top;
			int width = ((Control)BhL).Width;
			int height = ((Control)BhL).Height;
			Bhy = (int)((double)(P_1.X + left) / BIF);
			BhZ = (int)((double)(P_1.Y + top) / BIF);
			BII = ch.A.BUm;
			if ((int)P_1.Button == 1048576)
			{
				Bho = true;
				BhP = (Control.ModifierKeys & 0x10000) == 65536;
				Bhp = (Control.ModifierKeys & 0x20000) == 131072;
				BhY = ((Control)this).PointToScreen(new Point(((Control)BhL).Left, ((Control)BhL).Top));
				int num = ((Bhi.awP.c() == null) ? (-1) : Bhi.awP.c().ax());
				if (num != -1)
				{
					BID = num;
					A(BID);
				}
				if (BID == -1 || num == -1)
				{
					A();
				}
				if (H())
				{
					Bhu = Cursor.Current;
					Cursor.Current = Cursors.Cross;
					BhV = Cursor.Current;
					Dk dk = a().a()[BID - 1];
					Bhz = Bhy;
					BIA = BhZ;
					width = dk.d().ax();
					height = dk.E().ax();
					int num2 = dk.C().ax();
					int num3 = dk.c().ax();
					int num4 = num2 + width;
					int num5 = num3 + height;
					BhT = (float)height / (float)width;
					int num6 = dk.B().ax();
					if (Bhn.Contains(num6))
					{
						BhQ = true;
					}
					else
					{
						BhQ = false;
					}
					Bhq = width;
					BhR = dk.K().ax();
					Bhr = dk.k().ax();
					BhS = dk.L().ax();
					if (Math.Abs(Bhy - num4) <= 10)
					{
						if (Math.Abs(BhZ - num3) <= 10)
						{
							BII = ch.A.BUQ;
							Cursor.Current = Cursors.SizeNESW;
							BhV = Cursor.Current;
						}
						else if (Math.Abs(BhZ - num5) <= 10)
						{
							BII = ch.A.BUq;
							Cursor.Current = Cursors.SizeNWSE;
							BhV = Cursor.Current;
						}
						else
						{
							BII = ch.A.BUn;
							Cursor.Current = Cursors.SizeWE;
							BhV = Cursor.Current;
						}
					}
					else if (Math.Abs(Bhy - num2) <= 10)
					{
						if (Math.Abs(BhZ - num3) <= 10)
						{
							BII = ch.A.BUP;
							Cursor.Current = Cursors.SizeNWSE;
							BhV = Cursor.Current;
						}
						else if (Math.Abs(BhZ - num5) <= 10)
						{
							BII = ch.A.BUp;
							Cursor.Current = Cursors.SizeNESW;
							BhV = Cursor.Current;
						}
						else
						{
							BII = ch.A.BUN;
							Cursor.Current = Cursors.SizeWE;
							BhV = Cursor.Current;
						}
					}
					else if (Math.Abs(BhZ - num3) <= 10)
					{
						BII = ch.A.BUO;
						Cursor.Current = Cursors.SizeNS;
						BhV = Cursor.Current;
					}
					else if (Math.Abs(BhZ - num5) <= 10)
					{
						BII = ch.A.BUo;
						Cursor.Current = Cursors.SizeNS;
						BhV = Cursor.Current;
					}
					((SettingOrSpecialObject)dk.C()).O();
					((SettingOrSpecialObject)dk.c()).O();
					((SettingOrSpecialObject)dk.d()).O();
					((SettingOrSpecialObject)dk.E()).O();
				}
				else
				{
					Bho = false;
					D(0);
					Cursor.Current = Bhu;
					BhV = Cursor.Current;
				}
				return;
			}
			try
			{
				if (Bho && BID == -1)
				{
					Bho = false;
					D(0);
					return;
				}
				DK dK = a();
				if (BID <= -1 || BID >= dK.a().Count || (dK != null && dK.a()[BID - 1] != null && dK.a()[BID - 1].B().ax() == 0))
				{
					BID = -1;
				}
				BIG.A(new Point(Bhy, BhZ), BID);
				((ToolStripDropDown)BIG).Show((Control)(object)this, P_1.Location);
			}
			catch
			{
			}
		}

		internal new void a(int P_0, int P_1)
		{
			if (!f())
			{
				return;
			}
			DK dK = a();
			int num = -32767;
			int num2 = Bhs;
			int num3 = 0;
			int count = dK.a().Count;
			int num4 = -BhW;
			int num5 = -Bhw;
			int num6 = BhW * 2;
			int num7 = Bhw * 2;
			int num8 = BhW * 2;
			int num9 = Bhw * 2;
			for (int i = num3; i < count; i++)
			{
				Dk dk = dK.a()[i];
				if (dK.a()[i].B().ax() <= 0)
				{
					continue;
				}
				int num10 = dk.d().ax();
				int num11 = dk.E().ax();
				int num12 = dk.C().ax();
				int num13 = dk.c().ax();
				if (b(P_0, num12, num12 + num10) && b(P_1, num13, num13 + num11))
				{
					int num14 = dk.D().ax();
					int num15 = dk.f().ax();
					if (num14 > num || (b(num12, num4, num6) && b(num12 + num10, num4, num6) && b(num13, num5, num7) && b(num13 + num11, num5, num7) && num15 != num2 && num10 < num8 && num11 < num9))
					{
						num8 = (BIa = num10);
						num9 = (BIB = num11);
						num = num14;
						num2 = i + 1;
						num4 = num12;
						num5 = num13;
						num6 = num12 + num10;
						num7 = num13 + num11;
					}
				}
			}
			if (num2 != Bhs || num2 == -1)
			{
				d(num2);
			}
			BhU = Environment.TickCount;
		}

		private bool H()
		{
			return BID != -1;
		}

		private void a(object P_0, MouseEventArgs P_1)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_0468: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			if (!f())
			{
				return;
			}
			Rectangle displayRectangle = ((Control)this).DisplayRectangle;
			if (!((Rectangle)(ref displayRectangle)).Contains(new Point(P_1.X, P_1.Y)))
			{
				return;
			}
			int left = ((Control)BhL).Left;
			int top = ((Control)BhL).Top;
			int num = (int)((double)(P_1.X + left) / BIF);
			int num2 = (int)((double)(P_1.Y + top) / BIF);
			if (Environment.TickCount - BhU > 200 && !Bho)
			{
				a(num, num2);
			}
			if (Bhi.awP.c() != null)
			{
				Bhi.awP.c().ax();
			}
			if (BIb || !H())
			{
				return;
			}
			BIb = true;
			int num3 = (int)((double)P_1.X / BIF);
			int num4 = (int)((double)P_1.Y / BIF);
			if (Bho && A(new Point(num3, num4), BID, 100))
			{
				if ((Math.Abs(num - Bhy) != 0 || Math.Abs(num2 - BhZ) != 0) && BIc == null && BIC != -1)
				{
					BIc = BM.aM();
					if (BIc != null)
					{
						BIc.a();
					}
				}
				if (BII != 0)
				{
					if (BIC == BID || Math.Abs(num3 - Bhz) > 5 || Math.Abs(num4 - BIA) > 5)
					{
						A(num3, num4, BII);
					}
					else
					{
						BIC = BID;
					}
				}
				else if (Cursor.Current == Cursors.Cross && A(new Point(num3, num4), BID, 10) && (BIC == BID || Math.Abs(num3 - Bhz) > 5 || Math.Abs(num4 - BIA) > 5))
				{
					A(num3, num4);
				}
				else
				{
					BIC = BID;
					BIb = false;
				}
			}
			else if (BID != -1 && A(new Point(num3, num4), BID, 10))
			{
				Dk dk = a().a()[BID - 1];
				int num5 = dk.d().ax();
				int num6 = dk.E().ax();
				int num7 = dk.C().ax();
				int num8 = dk.c().ax();
				int num9 = num7 + num5;
				int num10 = num8 + num6;
				if (Math.Abs(num3 - num9) <= 10)
				{
					if (Math.Abs(num4 - num8) <= 10)
					{
						BII = ch.A.BUQ;
						Cursor.Current = Cursors.SizeNESW;
						BhV = Cursor.Current;
					}
					else if (Math.Abs(num4 - num10) <= 10)
					{
						BII = ch.A.BUq;
						Cursor.Current = Cursors.SizeNWSE;
						BhV = Cursor.Current;
					}
					else
					{
						BII = ch.A.BUn;
						Cursor.Current = Cursors.SizeWE;
						BhV = Cursor.Current;
					}
				}
				else if (Math.Abs(num3 - num7) <= 10)
				{
					if (Math.Abs(num4 - num8) <= 10)
					{
						BII = ch.A.BUP;
						Cursor.Current = Cursors.SizeNWSE;
						BhV = Cursor.Current;
					}
					else if (Math.Abs(num4 - num10) <= 10)
					{
						BII = ch.A.BUp;
						Cursor.Current = Cursors.SizeNESW;
						BhV = Cursor.Current;
					}
					else
					{
						BII = ch.A.BUN;
						Cursor.Current = Cursors.SizeWE;
						BhV = Cursor.Current;
					}
				}
				else if (Math.Abs(num4 - num8) <= 10)
				{
					BII = ch.A.BUO;
					Cursor.Current = Cursors.SizeNS;
					BhV = Cursor.Current;
				}
				else if (Math.Abs(num4 - num10) <= 10)
				{
					BII = ch.A.BUo;
					Cursor.Current = Cursors.SizeNS;
					BhV = Cursor.Current;
				}
				else
				{
					Cursor.Current = Bhu;
					BhV = Cursor.Current;
				}
			}
			else if (BID != -1 && BII != 0 && !A(new Point(num3, num4), BID, 10))
			{
				BII = ch.A.BUm;
				Cursor.Current = Bhu;
				BIC = -1;
			}
			BIb = false;
		}

		private void B(object P_0, MouseEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)P_1.Button != 1048576)
			{
				return;
			}
			if (H() && Bho)
			{
				Dk dk = a().a()[BID - 1];
				((SettingOrSpecialObject)dk.C()).n();
				((SettingOrSpecialObject)dk.c()).n();
				((SettingOrSpecialObject)dk.d()).n();
				((SettingOrSpecialObject)dk.E()).n();
				if (BIc != null)
				{
					BIc.B();
					BM.b(dk.C().A());
					BM.b(dk.c().A());
					BM.b(dk.d().A());
					BM.b(dk.E().A());
				}
			}
			Bho = false;
			BIc = null;
			BIC = -1;
			BIb = false;
			Cursor.Current = Bhu;
			BhV = Cursor.Current;
		}

		private void A(object P_0, EventArgs P_1)
		{
			Bho = false;
		}

		private void D(int P_0)
		{
			if (P_0 >= 0 && f())
			{
				Bhi.awP.C().a(P_0, true);
				cb.A(BhM != null && BhM.ES != null && BhM.ES.BiE);
			}
		}

		private void d(int P_0)
		{
			if (P_0 >= -1 && f())
			{
				if (Bhi.awP.c() != null)
				{
					Bhi.awP.c().a(P_0, true);
				}
				cb.A(BhM != null && BhM.ES != null && BhM.ES.BiE);
				Bhs = P_0;
			}
		}

		private void E(int P_0)
		{
			if (H())
			{
				Dk dk = a().a()[BID - 1];
				int num = dk.D().ax();
				dk.D().a(num + P_0, true);
				BM.b(dk.D().A());
				Bhi.i()[dk.D().a()] = by.aYK;
			}
		}

		private void e(int P_0)
		{
			if (P_0 >= 0)
			{
				Bho = false;
				BID = -1;
				Bhj = P_0;
				Bhi.awP.b().a(P_0, true);
				D(0);
				d(0);
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			int num = Bhi.awP.b().ax();
			if (BIh != ((TabControl)BM.QQ.rl).SelectedIndex)
			{
				BIh = ((TabControl)BM.QQ.rl).SelectedIndex;
				BM.QQ.rL.C(num);
				if (f())
				{
					cb.a();
				}
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			int num = Bhi.awP.b().ax();
			if (BIh != ((TabControl)BM.QQ.rl).SelectedIndex || num != Bhj)
			{
				BIh = ((TabControl)BM.QQ.rl).SelectedIndex;
				BM.QQ.rL.b(num);
				if (f())
				{
					cb.a();
				}
			}
		}

		private void b(object P_0, EventArgs P_1)
		{
			if (Bhk != null)
			{
				((Control)this).Controls.Remove((Control)(object)Bhk);
			}
			((Control)this).Controls.Remove((Control)(object)BhL);
			((Control)this).Controls.Remove((Control)(object)BhM);
			I();
		}

		private void h()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected O, but got Unknown
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected O, but got Unknown
			((Control)BhL).MouseDown += new MouseEventHandler(A);
			((Control)BhL).MouseUp += new MouseEventHandler(B);
			((Control)BhL).LostFocus += new EventHandler(C);
			((Control)this).HandleDestroyed += new EventHandler(b);
			if (Bhi.awP.H())
			{
				((Control)BhL).MouseMove += new MouseEventHandler(a);
				((Control)BM.QQ).KeyDown += new KeyEventHandler(A);
			}
			((Control)this).PreviewKeyDown += new PreviewKeyDownEventHandler(A);
		}

		private void C(object P_0, EventArgs P_1)
		{
			BIb = false;
		}

		private void I()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected O, but got Unknown
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected O, but got Unknown
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected O, but got Unknown
			((Control)BhL).MouseDown -= new MouseEventHandler(A);
			((Control)BhL).MouseUp -= new MouseEventHandler(B);
			((Control)BhL).LostFocus -= new EventHandler(C);
			((Control)this).HandleDestroyed -= new EventHandler(b);
			if (Bhi.awP.H())
			{
				((Control)BhL).MouseMove -= new MouseEventHandler(a);
				((Control)BM.QQ).KeyDown -= new KeyEventHandler(A);
			}
			((Control)this).PreviewKeyDown -= new PreviewKeyDownEventHandler(A);
			if (BIE != null)
			{
				BIE.Stop();
				BIE.Elapsed -= new ElapsedEventHandler(A);
				((Component)BIE).Dispose();
				BIE = null;
			}
		}

		protected override void Dispose(bool disposing)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			Bhi.awP.b().a(new EventHandler(B));
			BM.QQ.rl.a(new EventHandler(a));
			try
			{
				Bhi.awP.C().a(0, true);
				cb.A(false);
				if (BhM != null)
				{
					((Component)BhM).Dispose();
				}
				if (BIG != null)
				{
					((Component)BIG).Dispose();
				}
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		internal ch(DK P_0, Framework P_1, Rectangle P_2, bool P_3, cQ P_4)
			: base(P_2, P_3, true, false)
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03db: Expected O, but got Unknown
			//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Expected O, but got Unknown
			Bhi = P_1;
			BhJ = P_2;
			Bhx = P_4;
			BhW = A(Bhi);
			Bhw = a(Bhi);
			Bhj = Bhi.awP.E().IndexOf(P_0);
			BhM = new V(Bhi, Bhx);
			Bhm = Bhi.awP.g();
			Enumerator<Setting.ListItems.A> enumerator = Bhm.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting.ListItems.A current = enumerator.Current;
					BhN.Add(current.bBv, current.bBV);
					if (Bhi.awP.H() && current.bBx.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAs()))
					{
						Bhn.Add(current.bBv);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			GC.Collect();
			int num = Bhi.awP.d().ax();
			if (num == 0)
			{
				num = 100;
			}
			BIF = (double)num / 100.0;
			BhM.A(num);
			((Control)this).Width = Math.Max((int)((double)BhW * BIF), 470);
			((Control)this).Height = (int)((double)Bhw * BIF) + 26;
			if (Bhx != null)
			{
				Bhx.A(BIF);
			}
			if (Bhk == null || ((Control)Bhk).Disposing || ((Control)Bhk).IsDisposed)
			{
				Bhk = new VirtualDashAppPanel();
			}
			if (!BIg)
			{
				((Control)Bhk).Location = new Point(0, 0);
				((Control)Bhk).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAT();
				((Control)Bhk).Size = new Size((int)((double)BhW * BIF), ((Control)this).Height - 26);
				((Control)Bhk).TabIndex = 0;
				if (!((Control)this).Controls.Contains((Control)(object)Bhk))
				{
					((Control)this).Controls.Add((Control)(object)Bhk);
				}
				Bhk.A((Control)(object)Bhk);
			}
			((Control)this).SetStyle((ControlStyles)65536, true);
			((Control)this).SetStyle((ControlStyles)2, true);
			((Control)this).SetStyle((ControlStyles)8192, true);
			if (!((Control)this).Controls.Contains((Control)(object)BhM))
			{
				((Control)this).Controls.Add((Control)(object)BhM);
			}
			if (!((Control)this).Controls.Contains((Control)(object)BhL))
			{
				((Control)this).Controls.Add((Control)(object)BhL);
			}
			G();
			g();
			if (Bhl != null && ((Control)this).Parent != null)
			{
				((Control)Bhl).Top = ((Control)this).Top + ((Control)this).Height + 10;
			}
			((Control)BhL).BringToFront();
			((Control)BhM).BringToFront();
			h();
			E();
			e(Bhj);
			BIG = new u(this);
			Bhi.awP.b().A(new EventHandler(B));
			BM.QQ.rl.A(new EventHandler(a));
		}

		[CompilerGenerated]
		internal static bool a(int P_0, int P_1, int P_2)
		{
			if (P_0 <= P_2)
			{
				return P_0 >= P_1;
			}
			return false;
		}

		[CompilerGenerated]
		internal static bool B(int P_0, int P_1, int P_2)
		{
			if (P_0 <= P_2)
			{
				return P_0 >= P_1;
			}
			return false;
		}

		[CompilerGenerated]
		private int A(int P_0, ref b P_1)
		{
			return (int)((float)P_0 * BhT);
		}

		[CompilerGenerated]
		private int a(int P_0, ref b P_1)
		{
			return (int)((float)P_0 / BhT);
		}

		[CompilerGenerated]
		private void B(int P_0, ref b P_1)
		{
			float num = (float)P_0 / Bhq;
			P_1.BUU.K().a(Math.Max(1, (int)((float)BhR * num)), true);
			P_1.BUU.k().a(Math.Max(1, (int)((float)Bhr * num)), true);
			P_1.BUU.L().a(Math.Max(1, (int)((float)BhS * num)), true);
		}

		[CompilerGenerated]
		private void A(ref b P_0)
		{
			int num = Math.Abs(P_0.BUu - P_0.BUV);
			P_0.BUU.C().a(Math.Min(P_0.BUu, P_0.BUV), true);
			P_0.BUU.d().a(num, true);
			if (BhP || BhQ)
			{
				int num2 = A(num, ref P_0);
				P_0.BUU.E().a(num2, true);
				B(num, ref P_0);
			}
		}

		[CompilerGenerated]
		private void a(ref b P_0)
		{
			int num = Math.Abs(P_0.BUu - P_0.BUv);
			P_0.BUU.C().a(Math.Min(P_0.BUu, P_0.BUv), true);
			P_0.BUU.d().a(num, true);
			if (BhP || BhQ)
			{
				int num2 = A(num, ref P_0);
				P_0.BUU.E().a(num2, true);
				B(num, ref P_0);
			}
		}

		[CompilerGenerated]
		private void B(ref b P_0)
		{
			P_0.BUU.c().a(Math.Min(P_0.BUW, P_0.BUw), true);
			P_0.BUU.E().a(Math.Abs(P_0.BUW - P_0.BUw), true);
			if (BhP || BhQ)
			{
				int num = a(Math.Abs(P_0.BUW - P_0.BUw), ref P_0);
				P_0.BUU.d().a(num, true);
				B(num, ref P_0);
			}
		}

		[CompilerGenerated]
		private void b(ref b P_0)
		{
			P_0.BUU.c().a(Math.Min(P_0.BUW, P_0.BUX), true);
			P_0.BUU.E().a(Math.Abs(P_0.BUW - P_0.BUX), true);
			if (BhP || BhQ)
			{
				int num = a(Math.Abs(P_0.BUW - P_0.BUX), ref P_0);
				P_0.BUU.d().a(num, true);
				B(num, ref P_0);
			}
		}

		[CompilerGenerated]
		private void i()
		{
			((Control)BhL).BringToFront();
		}

		[CompilerGenerated]
		private void J()
		{
			((Control)BhM).BringToFront();
		}

		[CompilerGenerated]
		private void j()
		{
			((Control)BhL).Left = 0;
			((Control)BhL).Top = 0;
			((Control)BhL).Width = (int)((double)BhW * BIF);
			((Control)BhL).Height = ((Control)this).Height - 26;
		}

		[CompilerGenerated]
		private void K()
		{
			((Control)BhM).Left = 0;
			((Control)BhM).Top = ((Control)BhL).Height;
			((Control)BhM).Width = ((Control)this).Width;
			((Control)BhM).Height = 26;
		}

		[CompilerGenerated]
		internal static bool b(int P_0, int P_1, int P_2)
		{
			if (P_0 <= P_2)
			{
				return P_0 >= P_1;
			}
			return false;
		}
	}
}
namespace C
{
	internal enum CH : byte
	{
		BAU = 0,
		BAu = 1,
		BAV = 2,
		BAv = 3,
		BAW = 4,
		BAw = 5,
		BAX = 6,
		BAx = 7,
		BAY = 8,
		BAy = 9,
		BAZ = 10,
		BAz = 11,
		BaA = 12,
		Baa = 13,
		BaB = 14,
		Bab = 15,
		BaC = 16,
		Bac = 17,
		BaD = 18,
		Bad = 19,
		BaE = 20,
		Bae = 21,
		BaF = 22,
		Baf = 23,
		BaG = 24,
		Bag = 25,
		BaH = 26,
		Bah = 27,
		BaI = 128,
		Bai = 129,
		BaJ = 130,
		Baj = 131,
		BaK = 132,
		Bak = 133,
		BaL = 200,
		Bal = 201,
		BaM = 202,
		Bam = 203,
		BaN = 255
	}
	internal enum Ch : byte
	{
		Ban = 0,
		BaO = 1,
		Bao = 2,
		BaP = 3,
		Bap = 4,
		BaQ = 5,
		Baq = 6,
		BaR = 7,
		Bar = 8,
		BaS = 9,
		Bas = 10,
		BaT = 11,
		Bat = 12,
		BaU = 13,
		Bau = 14,
		BaV = 15,
		Bav = 16,
		BaW = 17,
		Baw = 18,
		BaX = 21,
		Bax = 24
	}
}
