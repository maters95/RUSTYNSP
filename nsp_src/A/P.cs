using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace A;

internal class P
{
	private float[] cq;

	private float[] cR;

	private float[] cr;

	private bool cS;

	private string cs;

	private float cT;

	private float ct;

	private float cU;

	private float cu;

	private float cV;

	private float cv;

	private float cW;

	private float cw;

	[SpecialName]
	internal float[] A()
	{
		return cq;
	}

	[SpecialName]
	internal float[] a()
	{
		return cR;
	}

	[SpecialName]
	internal float[] B()
	{
		return cr;
	}

	[SpecialName]
	internal string b()
	{
		return cs;
	}

	[SpecialName]
	internal bool C()
	{
		return cS;
	}

	internal P(float P_0, float P_1, float P_2, float P_3, float P_4, float P_5, float P_6, float P_7, string P_8, int P_9)
	{
		cs = P_8;
		ct = P_0;
		cT = P_1;
		cV = P_2;
		cu = P_3;
		cW = P_4;
		cw = P_5;
		cU = A(P_6, P_9);
		cv = (float)Math.Round((double)(cU / (cT - ct) * (cu - cV)), P_9);
		float num = (cw - cW) * (cU / (cT - ct));
		if (P_7 >= Math.Abs(num))
		{
			cS = true;
		}
		else
		{
			cS = false;
		}
		A(P_9);
	}

	private float A(float P_0, int P_1)
	{
		float num = 1E+09f;
		float num2 = ((P_0 != 0f) ? ((cw - cW) / P_0) : 0f);
		if (Math.Abs(num2) < 1f)
		{
			num2 = 1f;
		}
		float num3 = Math.Abs(num2);
		if (cT != ct)
		{
			float num4 = cT - ct;
			float num5 = num3;
			int num6 = 2;
			while (!(Math.Abs(num4 / num) >= num5))
			{
				num /= 2f;
				num6 = 2;
				if (Math.Abs(num4 / num) >= num5)
				{
					break;
				}
				num /= 5f;
				num6 = 5;
			}
			num = (float)Math.Round((double)(num * (float)num6), P_1);
			float num7 = (float)Math.Round((double)(1f / (float)Math.Pow(10.0, (double)P_1)), P_1);
			if (num < num7)
			{
				num = num7;
			}
			if (num4 < 0f)
			{
				num = 0f - num;
			}
		}
		else
		{
			num = 0f;
		}
		return num;
	}

	private void A(int P_0)
	{
		float num = ct % cU;
		if (cU == 0f)
		{
			num = 0f;
		}
		float num2 = ct - num;
		int num3 = 2;
		if (cU != 0f)
		{
			num3 = (int)((cT - (ct - num)) / cU) + 1;
		}
		for (; (num2 < ct && cU > 0f) || (num2 > ct && cU < 0f); num2 += cU)
		{
			num3--;
		}
		if (cS)
		{
			num3 -= num3 / 2;
		}
		float num4 = cT - ct;
		float num5 = cw - cW;
		float num6 = 0f;
		if (num4 != 0f)
		{
			num6 = num5 / num4;
		}
		bool flag = num2 % (cU * 2f) != 0f;
		cR = new float[num3];
		cr = new float[num3];
		for (int num7 = 0; num7 < num3; num7++)
		{
			if (cS && flag)
			{
				num2 += cU;
			}
			flag = true;
			cR[num7] = (float)Math.Round((double)num2, P_0);
			cr[num7] = cW + num6 * (cR[num7] - ct);
			num2 += cU;
		}
		cq = new float[num3];
		float num8 = cV;
		for (int num9 = 0; num9 < num3; num9++)
		{
			if (cS && flag)
			{
				num8 += cv;
			}
			flag = true;
			cq[num9] = num8;
			num8 += cv;
		}
	}
}
internal class p
{
	private struct A
	{
		public int BgU;

		public int Bgu;

		public int BgV;

		public int Bgv;
	}

	private enum a
	{
		BgW = 10,
		Bgw = 117
	}

	public static void A(string P_0, ImageFormat P_1, nint P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		Rectangle val = A(P_2);
		Bitmap val2 = new Bitmap(((Rectangle)(ref val)).Width, ((Rectangle)(ref val)).Height);
		try
		{
			Graphics val3 = Graphics.FromImage((Image)(object)val2);
			try
			{
				val3.CopyFromScreen(((Rectangle)(ref val)).Location, Point.Empty, ((Rectangle)(ref val)).Size);
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
			((Image)val2).Save(P_0, P_1);
		}
		finally
		{
			((System.IDisposable)val2)?.Dispose();
		}
	}

	private static Rectangle A(nint P_0)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		A(P_0, out var a2);
		float num = A();
		return new Rectangle((int)Math.Round((double)((float)(a2.BgU + 8) * num)), (int)Math.Round((double)((float)a2.Bgu * num)), (int)Math.Round((double)((float)(a2.BgV - a2.BgU - 16) * num)), (int)Math.Round((double)((float)(a2.Bgv - a2.Bgu - 8) * num)));
	}

	[DllImport("user32.dll", EntryPoint = "GetWindowRect")]
	private static extern bool A(nint P_0, out A P_1);

	[DllImport("user32.dll", EntryPoint = "GetDpiForWindow")]
	private static extern int a(nint P_0);

	[DllImport("gdi32.dll", EntryPoint = "GetDeviceCaps")]
	private static extern int A(nint P_0, int P_1);

	private static float A()
	{
		Graphics val = Graphics.FromHwnd(System.IntPtr.Zero);
		try
		{
			nint hdc = val.GetHdc();
			int num = A(hdc, 10);
			int num2 = A(hdc, 117);
			val.ReleaseHdc((System.IntPtr)hdc);
			return (float)num2 / (float)num;
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}
}
