using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using b;

namespace A;

internal static class O
{
	internal static Bitmap A(Image P_0, float P_1, float P_2, float P_3, float P_4, float P_5, float P_6, float P_7, float P_8)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		Bitmap val = new Bitmap(P_0.Width, P_0.Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		ColorMatrix val3 = new ColorMatrix(new float[5][]
		{
			new float[5] { P_2, 0f, 0f, 0f, 0f },
			new float[5] { 0f, P_3, 0f, 0f, 0f },
			new float[5] { 0f, 0f, P_4, 0f, 0f },
			new float[5] { 0f, 0f, 0f, P_1, 0f },
			new float[5] { P_6, P_7, P_8, P_5, 1f }
		});
		ImageAttributes val4 = new ImageAttributes();
		val4.SetColorMatrix(val3, (ColorMatrixFlag)0, (ColorAdjustType)1);
		val2.DrawImage(P_0, new Rectangle(0, 0, ((Image)val).Width, ((Image)val).Height), 0, 0, P_0.Width, P_0.Height, (GraphicsUnit)2, val4);
		val2.Dispose();
		val4.Dispose();
		return val;
	}

	internal static Size A(Size P_0, Size P_1)
	{
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		int num;
		int num2;
		if (((Size)(ref P_0)).Width > ((Size)(ref P_1)).Width && ((Size)(ref P_0)).Height > ((Size)(ref P_1)).Height)
		{
			if ((float)((Size)(ref P_0)).Width / (float)((Size)(ref P_1)).Width > (float)((Size)(ref P_0)).Height / (float)((Size)(ref P_1)).Height)
			{
				num = ((Size)(ref P_1)).Width;
				num2 = ((Size)(ref P_1)).Width * ((Size)(ref P_0)).Height / ((Size)(ref P_0)).Width;
			}
			else
			{
				num2 = ((Size)(ref P_1)).Height;
				num = ((Size)(ref P_1)).Height * ((Size)(ref P_0)).Width / ((Size)(ref P_0)).Height;
			}
		}
		else if (((Size)(ref P_0)).Width > ((Size)(ref P_1)).Width)
		{
			num = ((Size)(ref P_1)).Width;
			num2 = ((Size)(ref P_1)).Width * ((Size)(ref P_0)).Height / ((Size)(ref P_0)).Width;
		}
		else if (((Size)(ref P_0)).Height > ((Size)(ref P_1)).Height)
		{
			num2 = ((Size)(ref P_1)).Height;
			num = ((Size)(ref P_1)).Height * ((Size)(ref P_0)).Width / ((Size)(ref P_0)).Height;
		}
		else
		{
			num = ((Size)(ref P_0)).Width;
			num2 = ((Size)(ref P_0)).Height;
		}
		return new Size(num, num2);
	}
}
[DefaultMember("Item")]
internal class o : System.Collections.IEnumerable
{
	[CompilerGenerated]
	private EventHandler cG;

	[CompilerGenerated]
	private EventHandler cg;

	private ArrayList cH = new ArrayList();

	private int ch;

	private float cI;

	private float ci;

	private float cJ;

	private float cj;

	private float cK;

	private float ck;

	private float cL = 15f;

	private float cl;

	private bool cM;

	private float[] cm;

	private float[] cN;

	private float[] cn;

	private bool cO;

	private PointF[] co;

	private string[] cP;

	private int cp;

	private object cQ = new object();

	[SpecialName]
	[CompilerGenerated]
	internal void A(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = cG;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref cG, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = cG;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref cG, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void B(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = cg;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref cg, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void b(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = cg;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref cg, val3, val2);
		}
		while (val != val2);
	}

	internal o()
	{
	}//IL_0001: Unknown result type (might be due to invalid IL or missing references)
	//IL_000b: Expected O, but got Unknown


	[SpecialName]
	internal int A()
	{
		return ch;
	}

	[SpecialName]
	internal void A(int P_0)
	{
		ch = P_0;
		cM = false;
	}

	[SpecialName]
	internal float a()
	{
		return cI;
	}

	[SpecialName]
	internal void A(float P_0)
	{
		cI = P_0;
		cJ = E(cI);
		cO = true;
		cM = false;
	}

	[SpecialName]
	internal float B()
	{
		return ci;
	}

	[SpecialName]
	internal void a(float P_0)
	{
		ci = P_0;
		cj = E(ci);
		cO = true;
		cM = false;
	}

	[SpecialName]
	internal float b()
	{
		return cK;
	}

	[SpecialName]
	internal void B(float P_0)
	{
		cK = P_0;
		cM = false;
	}

	[SpecialName]
	internal float C()
	{
		return ck;
	}

	[SpecialName]
	internal void b(float P_0)
	{
		ck = P_0;
		cM = false;
	}

	[SpecialName]
	internal float c()
	{
		return cL;
	}

	[SpecialName]
	internal void C(float P_0)
	{
		cL = P_0;
		cM = false;
	}

	[SpecialName]
	internal float D()
	{
		return cl;
	}

	[SpecialName]
	internal void c(float P_0)
	{
		cl = P_0;
		cM = false;
	}

	[SpecialName]
	internal bool d()
	{
		return cM;
	}

	[SpecialName]
	internal P a(int P_0)
	{
		if (cM)
		{
			return (P)cH[P_0];
		}
		return null;
	}

	[SpecialName]
	internal int E()
	{
		return cH.Count;
	}

	[SpecialName]
	internal float[] e()
	{
		return cN;
	}

	[SpecialName]
	internal float[] F()
	{
		return cn;
	}

	[SpecialName]
	internal float[] f()
	{
		return cm;
	}

	[SpecialName]
	internal bool G()
	{
		return cO;
	}

	internal void A(int P_0, PointF[] P_1, string[] P_2)
	{
		cp = P_0;
		co = P_1;
		cP = P_2;
		cJ = E(cI);
		cj = E(ci);
		cM = false;
	}

	internal string g()
	{
		string text = cP[0];
		for (int num = 2; num < cP.Length; num += 2)
		{
			text = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bR(), (object)text, (object)cP[num]);
		}
		return text;
	}

	internal void H()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		bK bK = bS.a(ch, -1);
		if (bK == null)
		{
			bK = bS.a(0, -1);
		}
		string[] array = new string[bK.abw.Count];
		PointF[] array2 = (PointF[])(object)new PointF[bK.abw.Count];
		int num = 0;
		Enumerator<bK.A> enumerator = bK.abw.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				bK.A current = enumerator.Current;
				array2[num] = new PointF((float)current.BRX, (float)current.BRx);
				array[num] = current.BRY;
				num++;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		A(bK.abW, array2, array);
		if (cg != null)
		{
			cg.Invoke((object)this, new EventArgs());
		}
		h();
		I();
		cM = true;
		if (cG != null)
		{
			cG.Invoke((object)this, new EventArgs());
		}
		cO = false;
	}

	internal float D(float P_0)
	{
		if (ci == cI)
		{
			return cK;
		}
		return cK + (P_0 - cI) / (ci - cI) * (ck - cK);
	}

	internal float d(float P_0)
	{
		_ = cI;
		_ = (P_0 - cK) / (ck - cK);
		_ = ci;
		_ = cI;
		return cI + (P_0 - cK) / (ck - cK) * (ci - cI);
	}

	public System.Collections.IEnumerator GetEnumerator()
	{
		return cH.GetEnumerator();
	}

	private void h()
	{
		lock (cQ)
		{
			float num = cI;
			float num2 = ci;
			float num3 = cJ;
			float num4 = cj;
			float num5 = cK;
			float num6 = ck;
			bool flag = false;
			if (num2 - num < 0f)
			{
				float num7 = num;
				num = num2;
				num2 = num7;
				float num8 = num5;
				num5 = num6;
				num6 = num8;
				float num9 = num3;
				num3 = num4;
				num4 = num9;
				flag = true;
			}
			cH.Clear();
			if (co != null && co.Length > 1)
			{
				float num10 = num5;
				float num11 = num;
				float num12 = num3;
				string text = string.Empty;
				int num13 = 0;
				if (num <= ((PointF)(ref co[0])).X)
				{
					text = cP[0];
					num13 = 1;
				}
				else
				{
					while (num > ((PointF)(ref co[num13])).X)
					{
						num13++;
						if (num13 == co.Length)
						{
							break;
						}
					}
					if (num13 == co.Length)
					{
						if (flag)
						{
							cH.Add((object)new P(cj, cJ, num2, num, num6, num5, cL, cl, cP[cP.Length - 1], cp));
						}
						else
						{
							cH.Add((object)new P(cJ, cj, num, num2, num5, num6, cL, cl, cP[cP.Length - 1], cp));
						}
					}
					else
					{
						text = cP[num13];
					}
				}
				for (int num14 = num13; num14 < co.Length; num14++)
				{
					if (((PointF)(ref co[num14])).X <= num2 && cP[num14] == text && num14 != co.Length - 1)
					{
						float num15 = num5 + (num5 - num6) * ((((PointF)(ref co[num14])).X - num) / (num - num2));
						if (num15 != num10)
						{
							float num16 = ((PointF)(ref co[num14])).X;
							float num17 = ((PointF)(ref co[num14])).Y;
							if (flag)
							{
								cH.Add((object)new P(num17, num12, num16, num11, num15, num10, cL, cl, cP[num14], cp));
							}
							else
							{
								cH.Add((object)new P(num12, num17, num11, num16, num10, num15, cL, cl, cP[num14], cp));
							}
							num10 = num15;
							num11 = num16;
							num12 = num17;
						}
					}
					else if (cP[num14] == text)
					{
						float num18 = num6;
						float num19 = num2;
						float num20 = num4;
						if (flag)
						{
							cH.Add((object)new P(num20, num12, num19, num11, num18, num10, cL, cl, text, cp));
						}
						else
						{
							cH.Add((object)new P(num12, num20, num11, num19, num10, num18, cL, cl, text, cp));
						}
						num10 = num18;
						num11 = num19;
						num12 = num20;
						break;
					}
					text = cP[num14];
				}
			}
			else if (flag)
			{
				cH.Add((object)new P(num2, num, num2, num, num6, num5, cL, cl, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay(), 0));
			}
			else
			{
				cH.Add((object)new P(num, num2, num, num2, num5, num6, cL, cl, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay(), 0));
			}
		}
	}

	private void I()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		ArrayList val = new ArrayList();
		ArrayList val2 = new ArrayList();
		ArrayList val3 = new ArrayList();
		lock (cQ)
		{
			foreach (P item in cH)
			{
				float[] array = item.B();
				float[] array2 = item.a();
				float[] array3 = item.A();
				val.AddRange((System.Collections.ICollection)(object)array);
				val2.AddRange((System.Collections.ICollection)(object)array2);
				val3.AddRange((System.Collections.ICollection)(object)array3);
			}
		}
		for (int num = 0; num < val.Count - 1; num++)
		{
			if ((float)val[num] > (float)val[num + 1])
			{
				float num2 = (float)val[num];
				val[num] = (float)val[num + 1];
				val[num + 1] = num2;
				num2 = (float)val2[num];
				val2[num] = (float)val2[num + 1];
				val2[num + 1] = num2;
				num2 = (float)val3[num];
				val3[num] = (float)val3[num + 1];
				val3[num + 1] = num2;
				num = -1;
			}
			else if ((float)val[num] == (float)val[num + 1])
			{
				val.RemoveAt(num);
				val2.RemoveAt(num);
				val3.RemoveAt(num);
				num = -1;
			}
		}
		cN = (float[])val2.ToArray(typeof(float));
		cn = (float[])val.ToArray(typeof(float));
		cm = (float[])val3.ToArray(typeof(float));
	}

	internal float E(float P_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (co == null || co.Length < 2)
		{
			return P_0;
		}
		PointF val = PointF.Empty;
		for (int num = 1; num < co.Length; num++)
		{
			val = co[num];
			if (((PointF)(ref val)).X > P_0)
			{
				return A(P_0, val, co[num - 1]);
			}
		}
		val = co[co.Length - 2];
		return A(P_0, val, co[co.Length - 1]);
	}

	internal float e(float P_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (co == null || co.Length < 2)
		{
			return P_0;
		}
		PointF val = PointF.Empty;
		for (int num = 1; num < co.Length; num++)
		{
			val = co[num];
			if (((PointF)(ref val)).Y > P_0)
			{
				return a(P_0, val, co[num - 1]);
			}
		}
		val = co[co.Length - 2];
		return a(P_0, val, co[co.Length - 1]);
	}

	private float A(float P_0, PointF P_1, PointF P_2)
	{
		float num = (((PointF)(ref P_2)).Y - ((PointF)(ref P_1)).Y) / (((PointF)(ref P_2)).X - ((PointF)(ref P_1)).X);
		float num2 = ((PointF)(ref P_1)).Y - num * ((PointF)(ref P_1)).X;
		return num * P_0 + num2;
	}

	private float a(float P_0, PointF P_1, PointF P_2)
	{
		float num = (((PointF)(ref P_2)).Y - ((PointF)(ref P_1)).Y) / (((PointF)(ref P_2)).X - ((PointF)(ref P_1)).X);
		float num2 = ((PointF)(ref P_1)).Y - num * ((PointF)(ref P_1)).X;
		return (P_0 - num2) / num;
	}
}
