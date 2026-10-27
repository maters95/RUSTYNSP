using System.Text;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;

namespace A;

internal class F
{
	internal byte ae;

	internal byte aF;

	internal byte af;

	internal byte aG;

	internal int ag;

	internal byte aH;

	internal byte ah;

	internal byte aI;

	internal bool ai;

	internal ushort aJ;

	internal byte aj;

	internal byte aK;

	internal byte ak;

	internal byte aL;

	internal byte al;

	internal byte aM;

	internal byte am;

	internal byte aN;

	internal byte an;

	internal byte[] aO = new byte[16];

	internal string ao = string.Empty;

	internal byte[] aP = new byte[12];

	internal byte[] ap = new byte[12];

	internal byte aQ;

	internal byte aq;

	internal byte aR;

	internal uint[] ar = new uint[4];

	internal bool aS;

	internal G[] @as = new G[47];

	internal H[] aT = new H[5];

	internal const uint at = 1024u;

	internal const ushort aU = 65535;

	public virtual string ToString()
	{
		return string.Concat(new string[12]
		{
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ak(),
			ao,
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aL(),
			aH.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.al(),
			ah.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aM(),
			aI.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.am(),
			aJ.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aN(),
			((object)new k(ae, aF, af, aG, ag)).ToString()
		});
	}

	internal void A(byte[] P_0)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		int num2;
		if (aS)
		{
			ae = P_0[3];
			aF = P_0[4];
			af = P_0[5];
			aG = P_0[6];
			ag = 0;
			aH = P_0[0];
			ah = P_0[7];
			aI = P_0[28];
			StringBuilder val = new StringBuilder();
			for (int num = 0; num < 6; num++)
			{
				aP[num] = P_0[num + 8];
				val.AppendFormat(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.an(), (object)P_0[num + 8]);
			}
			ao = ((object)val).ToString();
			aj = 0;
			aK = 0;
			ak = 0;
			aL = 0;
			al = 0;
			aM = 0;
			am = 0;
			aN = 0;
			an = 0;
			ai = P_0[1] != 0;
			if (!ai)
			{
				if (ae == 255 && aF == 255 && af == 255)
				{
					num2 = ((aG == 255) ? 1 : 0);
					if (num2 != 0)
					{
						goto IL_0123;
					}
				}
				else
				{
					num2 = 0;
				}
				goto IL_014b;
			}
			num2 = 1;
			goto IL_0123;
		}
		ae = P_0[0];
		aF = P_0[1];
		af = P_0[2];
		aG = P_0[3];
		ag = (P_0[4] << 24) | ((P_0[5] << 16) & 0xFF0000) | ((P_0[6] << 8) & 0xFF00) | (P_0[7] & 0xFF);
		if (global::A.A.L == 0)
		{
			aH = P_0[8];
		}
		else
		{
			aH = global::A.A.L;
		}
		aI = P_0[9];
		aj = P_0[10];
		bool flag = A(aH, aI);
		if (global::A.A.l != 0)
		{
			ah = global::A.A.l;
		}
		else if (aH == 22 && (aI == 14 || aI == 14))
		{
			ah = aI;
		}
		else if (P_0[11] == 255)
		{
			if (flag)
			{
				ah = 3;
			}
			else
			{
				ah = aI;
			}
		}
		else
		{
			ah = P_0[11];
		}
		aK = P_0[12];
		ak = P_0[13];
		aL = P_0[14];
		al = P_0[15];
		if (flag)
		{
			aM = ae;
			am = aF;
			aN = af;
			an = aG;
		}
		else
		{
			aM = P_0[16];
			am = P_0[17];
			aN = P_0[18];
			an = P_0[19];
		}
		if (aM == 255 && am == 255 && aN == 255 && an == 255)
		{
			aM = 0;
			am = 0;
			aN = 0;
			an = 0;
		}
		for (int num3 = 0; num3 < aO.Length; num3++)
		{
			aO[num3] = P_0[32 + num3];
		}
		char[] array = new char[12];
		for (int num4 = 0; num4 < 6; num4++)
		{
			aP[num4] = P_0[256 + num4];
			int num5 = (P_0[256 + num4] >> 4) & 0xF;
			int num6 = P_0[256 + num4] & 0xF;
			if (num5 >= 10)
			{
				num5 += 7;
			}
			if (num6 >= 10)
			{
				num6 += 7;
			}
			array[num4 * 2] = (char)(num5 + 48);
			array[num4 * 2 + 1] = (char)(num6 + 48);
		}
		string text = new string(array);
		if (string.IsNullOrEmpty(ao) || (!string.IsNullOrEmpty(text) && text != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ac() && text != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aD()))
		{
			ao = text;
		}
		for (int num7 = 0; num7 < ap.Length; num7++)
		{
			ap[num7] = P_0[264 + num7];
		}
		aQ = P_0[276];
		k k2 = new k(ae, aF, af, aG, ag);
		k k3 = ((aH == 8 || aH == 10) ? new k(3, 5, 0, 1, 0) : ((aH == 22) ? ((!flag) ? new k(1, 8, 0, 1, 0) : new k(1, 1, 1, 0, 0)) : ((!flag) ? new k(1, 18, 0, 1, 0) : new k(1, 3, 0, 1, 0))));
		if (k2 >= k3)
		{
			aJ = (ushort)((uint)(P_0[277] << 8) | (P_0[278] & 0xFFu));
		}
		else
		{
			aJ = 65535;
		}
		if (!flag)
		{
			k k4 = ((aH != 8 && aH != 10) ? new k(1, 18, 0, 2, 0) : new k(3, 5, 0, 2, 0));
			if (k2 >= k4)
			{
				aq = P_0[279];
			}
		}
		aR = P_0[280];
		for (int num8 = 0; num8 < 4; num8++)
		{
			ar[num8] = (uint)(P_0[281 + 4 * num8] | (P_0[281 + 4 * num8 + 1] << 8) | (P_0[281 + 4 * num8 + 2] << 16) | (P_0[281 + 4 * num8 + 3] << 24));
		}
		ai = false;
		goto IL_0623;
		IL_0123:
		ae = P_0[24];
		aF = P_0[25];
		af = P_0[26];
		aG = P_0[27];
		goto IL_014b;
		IL_0623:
		if (aH == 8 || aH == 10)
		{
			uint bL = 16384u;
			aT[0].BL = bL;
			aT[0].Bl = 256;
			aT[3].BL = 0u;
			aT[3].Bl = 0;
			aT[1].BL = 0u;
			aT[1].Bl = 0;
			aT[2].BL = 0u;
			aT[2].Bl = 0;
		}
		else
		{
			aT[0].BL = 16400u;
			aT[0].Bl = 4112;
			aT[3].BL = 16400u;
			aT[3].Bl = 4112;
			aT[1].BL = 8208u;
			aT[1].Bl = 1040;
			aT[2].BL = 16400u;
			aT[2].Bl = 16400;
		}
		@as[0].Be = 0u;
		@as[0].BF = 0u;
		@as[0].Bf = 2048u;
		@as[0].BG = 4096;
		return;
		IL_014b:
		if (num2 != 0)
		{
			if (aH == 255 && ah == 255 && P_0.Length >= 32)
			{
				aJ = P_0[29];
				aH = P_0[30];
				ah = P_0[31];
			}
			else
			{
				aJ = 65535;
			}
		}
		else
		{
			aJ = 65535;
		}
		goto IL_0623;
	}

	protected bool A(byte P_0, byte P_1)
	{
		if (((P_0 == 8 || P_0 == 10 || P_0 == 9) && P_1 == 1) || (P_0 == 22 && P_1 == 14) || (P_0 == 22 && P_1 == 14) || ((P_0 == 20 || P_0 == 25 || P_0 == 24 || P_0 == 0 || P_0 == 255) && P_1 == 1) || (P_0 == 21 && P_1 == 1))
		{
			return true;
		}
		return false;
	}

	internal bool A()
	{
		if (aH == 22)
		{
			return ah == 2;
		}
		return false;
	}

	internal bool a()
	{
		if (!ai)
		{
			return A(aH, aI);
		}
		return true;
	}

	internal void a(byte[] P_0)
	{
		k k2 = new k(ae, aF, af, aG, ag);
		if (aH == 8 || aH == 10)
		{
			uint bf = 16384u;
			@as[0].Be = 0u;
			@as[0].BF = 0u;
			@as[0].Bf = 2048u;
			@as[0].BG = 256;
			@as[0].Bg = 0;
			@as[0].BH = 0;
			@as[3].Be = 0u;
			@as[3].BF = 0u;
			@as[3].Bf = 0u;
			@as[3].BG = 0;
			@as[3].Bg = 0;
			@as[3].BH = 0;
			@as[33].Be = 5120u;
			if (k2 < new k(3, 3, 0, 2, 0))
			{
				@as[33].BF = 12288u;
			}
			else
			{
				@as[33].BF = 32768u;
			}
			@as[33].Bf = bf;
			@as[33].BG = 256;
			@as[33].Bg = 4;
			@as[33].BH = 4;
			@as[34].Be = 65536u;
			@as[34].BF = 16384u;
			@as[34].Bf = bf;
			@as[34].BG = 256;
			@as[34].Bg = 0;
			@as[34].BH = 0;
			@as[35].Be = 131072u;
			@as[35].BF = 375808u;
			@as[35].Bf = bf;
			@as[35].BG = 256;
			@as[35].Bg = 4;
			@as[35].BH = 4;
			@as[36].Be = 651264u;
			@as[36].BF = 112u;
			@as[36].Bf = bf;
			@as[36].BG = 256;
			@as[36].Bg = 0;
			@as[36].BH = 0;
			@as[37].Be = 651520u;
			@as[37].BF = 1024u;
			@as[37].Bf = bf;
			@as[37].BG = 256;
			@as[37].Bg = 0;
			@as[37].BH = 0;
			@as[38].Be = 652544u;
			@as[38].BF = 335u;
			@as[38].Bf = bf;
			@as[38].BG = 256;
			@as[38].Bg = 0;
			@as[38].BH = 0;
			@as[40].Be = 1073741824u;
			@as[40].BF = 8388608u;
			@as[40].Bf = bf;
			@as[40].BG = 0;
			@as[40].Bg = 2048;
			@as[40].BH = 4;
			@as[32].Be = 0u;
			@as[32].BF = 0u;
			@as[32].Bf = 0u;
			@as[32].BG = 0;
			@as[32].Bg = 0;
			@as[32].BH = 0;
		}
		else if (aH == 20 || aH == 25 || aH == 24)
		{
			@as[0].Be = 0u;
			@as[0].BF = 0u;
			@as[0].Bf = 2048u;
			@as[0].BG = 4096;
			@as[0].Bg = 0;
			@as[0].BH = 0;
			@as[3].Be = 25165824u;
			@as[3].BF = 4194304u;
			@as[3].Bf = 16384u;
			@as[3].BG = 4096;
			@as[3].Bg = 0;
			@as[3].BH = 0;
			@as[33].Be = 5120u;
			if (k2 < new k(1, 15, 0, 2, 0))
			{
				@as[33].BF = 16384u;
			}
			else
			{
				@as[33].BF = 32768u;
			}
			@as[33].Bf = 16384u;
			@as[33].BG = 4096;
			@as[33].Bg = 4;
			@as[33].BH = 4;
			@as[34].Be = 65536u;
			@as[34].BF = 16384u;
			@as[34].Bf = 16384u;
			@as[34].BG = 4096;
			@as[34].Bg = 0;
			@as[34].BH = 0;
			@as[35].Be = 131072u;
			if (k2 < new k(1, 30, 0, 1, 0))
			{
				@as[35].BF = 425984u;
			}
			else
			{
				@as[35].BF = 520192u;
			}
			@as[35].Bf = 16384u;
			@as[35].BG = 4096;
			@as[35].Bg = 4;
			@as[35].BH = 4;
			@as[36].Be = 651264u;
			@as[36].BF = 112u;
			@as[36].Bf = 16384u;
			@as[36].BG = 4096;
			@as[36].Bg = 0;
			@as[36].BH = 0;
			@as[37].Be = 651520u;
			@as[37].BF = 1024u;
			@as[37].Bf = 16384u;
			@as[37].BG = 4096;
			@as[37].Bg = 0;
			@as[37].BH = 0;
			@as[38].Be = 652544u;
			if (k2 < new k(1, 33, 2, 0, 0))
			{
				@as[38].BF = 508u;
			}
			else
			{
				@as[38].BF = 1024u;
			}
			@as[38].Bf = 16384u;
			@as[38].BG = 4096;
			@as[38].Bg = 0;
			@as[38].BH = 0;
			@as[40].Be = 1073741824u;
			@as[40].BF = 536870912u;
			if (ah == 3)
			{
				@as[40].Bf = 2097152u;
			}
			else
			{
				@as[40].Bf = 1048576u;
			}
			@as[40].BG = 16384;
			if (k2 < new k(1, 21, 0, 104, 0))
			{
				@as[40].Bg = 2048;
			}
			else
			{
				@as[40].Bg = 0;
			}
			@as[40].BH = 4;
			if (ah == 3)
			{
				if (k2 < new k(1, 21, 1, 102, 0))
				{
					@as[32].Be = 0u;
					@as[32].BF = 0u;
					@as[32].Bf = 0u;
					@as[32].BG = 0;
					@as[32].Bg = 0;
					@as[32].BH = 0;
				}
				else
				{
					@as[32].Be = 1610612736u;
					@as[32].BF = 8194u;
					@as[32].Bf = 8194u;
					@as[32].BG = 0;
					@as[32].Bg = 0;
					@as[32].BH = 0;
				}
			}
			else
			{
				@as[32].Be = 1610612736u;
				@as[32].BF = 8194u;
				@as[32].Bf = 8194u;
				@as[32].BG = 0;
				@as[32].Bg = 0;
				@as[32].BH = 0;
			}
			@as[46].Be = 8388608u;
			@as[46].BF = 8388608u;
			@as[46].Bf = 16384u;
			@as[46].BG = 0;
			@as[46].Bg = 0;
			@as[46].BH = 0;
		}
		else if (aH == 22)
		{
			@as[0].Be = 0u;
			@as[0].BF = 0u;
			@as[0].Bf = 2048u;
			@as[0].BG = 4096;
			@as[0].Bg = 0;
			@as[0].BH = 0;
			@as[33].Be = 5120u;
			@as[33].BF = 16384u;
			@as[33].Bf = 16384u;
			@as[33].BG = 4096;
			@as[33].Bg = 4;
			@as[33].BH = 4;
		}
		else if (aH == 21)
		{
			ushort num = 13312;
			@as[0].Be = 0u;
			@as[0].BF = 0u;
			@as[0].Bf = 2048u;
			@as[0].BG = num;
			@as[0].Bg = 0;
			@as[0].BH = 0;
			@as[3].Be = 25165824u;
			@as[3].BF = 16777216u;
			@as[3].Bf = num;
			@as[3].BG = num;
			@as[3].Bg = 0;
			@as[3].BH = 0;
			@as[33].Be = 5120u;
			if (k2 < new k(2, 33, 0, 102, 0))
			{
				@as[33].BF = 24576u;
			}
			else
			{
				@as[33].BF = 32768u;
			}
			@as[33].Bf = num;
			@as[33].BG = num;
			@as[33].Bg = 4;
			@as[33].BH = 4;
			if (k2 >= new k(2, 36, 0, 1, 0))
			{
				@as[34].Be = 65536u;
				@as[34].BF = 16384u;
				@as[34].Bf = num;
				@as[34].BG = 4096;
				@as[34].Bg = 0;
				@as[34].BH = 0;
			}
			else
			{
				@as[34].Be = 0u;
				@as[34].BF = 0u;
				@as[34].Bf = 0u;
				@as[34].BG = 0;
				@as[34].Bg = 0;
				@as[34].BH = 0;
			}
			@as[35].Be = 131072u;
			if (k2 < new k(2, 30, 0, 1, 0))
			{
				@as[35].BF = 425984u;
			}
			else if (k2 < new k(2, 33, 0, 4, 0))
			{
				@as[35].BF = 520192u;
			}
			else if (k2 < new k(2, 35, 0, 5, 0))
			{
				@as[35].BF = 585728u;
			}
			else
			{
				@as[35].BF = 651264u;
			}
			@as[35].Bf = num;
			@as[35].BG = num;
			@as[35].Bg = 4;
			@as[35].BH = 4;
			@as[36].Be = 0u;
			@as[36].BF = 0u;
			@as[36].Bf = 0u;
			@as[36].BG = 0;
			@as[36].Bg = 0;
			@as[36].BH = 0;
			if (k2 < new k(2, 33, 0, 4, 0))
			{
				@as[37].Be = 651520u;
			}
			else if (k2 < new k(2, 35, 0, 5, 0))
			{
				@as[37].Be = 717056u;
			}
			else
			{
				@as[37].Be = 782848u;
			}
			@as[37].BF = 1024u;
			@as[37].Bf = num;
			@as[37].BG = num;
			@as[37].Bg = 0;
			@as[37].BH = 0;
			if (k2 < new k(2, 33, 0, 4, 0))
			{
				@as[38].Be = 652544u;
			}
			else if (k2 < new k(2, 35, 0, 5, 0))
			{
				@as[38].Be = 718080u;
			}
			else
			{
				@as[38].Be = 784384u;
			}
			if (k2 < new k(2, 33, 1, 0, 0))
			{
				@as[38].BF = 508u;
			}
			else
			{
				@as[38].BF = 1024u;
			}
			@as[38].Bf = num;
			@as[38].BG = 4096;
			@as[38].Bg = 0;
			@as[38].BH = 0;
			@as[40].Be = 1073741824u;
			@as[40].BF = 536870912u;
			@as[40].Bf = num;
			@as[40].BG = 0;
			@as[40].Bg = 0;
			@as[40].BH = 4;
			@as[41].Be = 1611137024u;
			@as[41].BF = 4194304u;
			@as[41].Bf = num;
			@as[41].BG = 0;
			@as[41].Bg = 0;
			@as[41].BH = 2;
			@as[42].Be = 1879048192u;
			@as[42].BF = 4194304u;
			@as[42].Bf = num;
			@as[42].BG = num;
			@as[42].Bg = 0;
			@as[42].BH = 0;
			@as[43].Be = 1883242496u;
			@as[43].BF = 4194304u;
			@as[43].Bf = num;
			@as[43].BG = num;
			@as[43].Bg = 0;
			@as[43].BH = 0;
			if (k2 < new k(2, 34, 0, 1, 0))
			{
				@as[44].Be = 0u;
				@as[44].BF = 0u;
				@as[44].Bf = 0u;
				@as[44].BG = 0;
				@as[44].Bg = 0;
				@as[44].BH = 0;
				@as[45].Be = 0u;
				@as[45].BF = 0u;
				@as[45].Bf = 0u;
				@as[45].BG = 0;
				@as[45].Bg = 0;
				@as[45].BH = 0;
			}
			else
			{
				@as[44].Be = 1887436800u;
				@as[44].BF = 4194304u;
				@as[44].Bf = num;
				@as[44].BG = num;
				@as[44].Bg = 0;
				@as[44].BH = 0;
				@as[45].Be = 1891631104u;
				@as[45].BF = 4194304u;
				@as[45].Bf = num;
				@as[45].BG = num;
				@as[45].Bg = 0;
				@as[45].BH = 0;
			}
		}
		else if (aH == 255)
		{
			@as[0].Be = 0u;
			@as[0].BF = 0u;
			@as[0].Bf = 2048u;
			@as[0].BG = 4096;
			@as[0].Bg = 0;
			@as[0].BH = 0;
			@as[33].Be = 5120u;
			@as[33].BF = 4096u;
			@as[33].Bf = 16384u;
			@as[33].BG = 4096;
			@as[33].Bg = 4;
			@as[33].BH = 4;
		}
	}
}
internal enum f : byte
{
	au = 0,
	aV = 1,
	av = 2,
	aW = 3,
	aw = 32,
	aX = 33,
	ax = 34,
	aY = 35,
	ay = 36,
	aZ = 37,
	az = 38,
	BA = 39,
	Ba = 40,
	BB = 41,
	Bb = 42,
	BC = 43,
	Bc = 44,
	BD = 45,
	Bd = 46,
	BE = 47
}
