using System.Text;
using ns7;

namespace ns0;

internal class Class5
{
	internal byte byte_0;

	internal byte byte_1;

	internal byte byte_2;

	internal byte byte_3;

	internal int int_0;

	internal byte byte_4;

	internal byte byte_5;

	internal byte byte_6;

	internal bool bool_0;

	internal ushort ushort_0;

	internal byte byte_7;

	internal byte byte_8;

	internal byte byte_9;

	internal byte byte_10;

	internal byte byte_11;

	internal byte byte_12;

	internal byte byte_13;

	internal byte byte_14;

	internal byte byte_15;

	internal byte[] byte_16 = new byte[16];

	internal string string_0 = string.Empty;

	internal byte[] byte_17 = new byte[12];

	internal byte[] byte_18 = new byte[12];

	internal byte byte_19;

	internal byte byte_20;

	internal byte byte_21;

	internal uint[] uint_0 = new uint[4];

	internal bool bool_1;

	internal Struct1[] struct1_0 = new Struct1[47];

	internal Struct2[] struct2_0 = new Struct2[5];

	internal const uint uint_1 = 1024u;

	internal const ushort ushort_1 = ushort.MaxValue;

	public override string ToString()
	{
		return Class333.smethod_74() + string_0 + Class333.smethod_75() + byte_4 + Class333.smethod_76() + byte_5 + Class333.smethod_77() + byte_6 + Class333.smethod_78() + ushort_0 + Class333.smethod_79() + new Class14(byte_0, byte_1, byte_2, byte_3, int_0).ToString();
	}

	internal void method_0(byte[] byte_22)
	{
		int num;
		if (bool_1)
		{
			byte_0 = byte_22[3];
			byte_1 = byte_22[4];
			byte_2 = byte_22[5];
			byte_3 = byte_22[6];
			int_0 = 0;
			byte_4 = byte_22[0];
			byte_5 = byte_22[7];
			byte_6 = byte_22[28];
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < 6; i++)
			{
				byte_17[i] = byte_22[i + 8];
				stringBuilder.AppendFormat(Class333.smethod_80(), byte_22[i + 8]);
			}
			string_0 = stringBuilder.ToString();
			byte_7 = 0;
			byte_8 = 0;
			byte_9 = 0;
			byte_10 = 0;
			byte_11 = 0;
			byte_12 = 0;
			byte_13 = 0;
			byte_14 = 0;
			byte_15 = 0;
			bool_0 = byte_22[1] != 0;
			if (!bool_0)
			{
				if (byte_0 != byte.MaxValue || byte_1 != byte.MaxValue || byte_2 != byte.MaxValue)
				{
					goto IL_01a1;
				}
				num = ((byte_3 == byte.MaxValue) ? 1 : 0);
				if (num == 0)
				{
					goto IL_014b;
				}
			}
			else
			{
				num = 1;
			}
			byte_0 = byte_22[24];
			byte_1 = byte_22[25];
			byte_2 = byte_22[26];
			byte_3 = byte_22[27];
			goto IL_014b;
		}
		byte_0 = byte_22[0];
		byte_1 = byte_22[1];
		byte_2 = byte_22[2];
		byte_3 = byte_22[3];
		int_0 = (byte_22[4] << 24) | ((byte_22[5] << 16) & 0xFF0000) | ((byte_22[6] << 8) & 0xFF00) | (byte_22[7] & 0xFF);
		if (Class1.byte_0 == 0)
		{
			byte_4 = byte_22[8];
		}
		else
		{
			byte_4 = Class1.byte_0;
		}
		byte_6 = byte_22[9];
		byte_7 = byte_22[10];
		bool flag = method_1(byte_4, byte_6);
		if (Class1.byte_1 != 0)
		{
			byte_5 = Class1.byte_1;
		}
		else if (byte_4 == 22 && (byte_6 == 14 || byte_6 == 14))
		{
			byte_5 = byte_6;
		}
		else if (byte_22[11] == byte.MaxValue)
		{
			if (flag)
			{
				byte_5 = 3;
			}
			else
			{
				byte_5 = byte_6;
			}
		}
		else
		{
			byte_5 = byte_22[11];
		}
		byte_8 = byte_22[12];
		byte_9 = byte_22[13];
		byte_10 = byte_22[14];
		byte_11 = byte_22[15];
		if (flag)
		{
			byte_12 = byte_0;
			byte_13 = byte_1;
			byte_14 = byte_2;
			byte_15 = byte_3;
		}
		else
		{
			byte_12 = byte_22[16];
			byte_13 = byte_22[17];
			byte_14 = byte_22[18];
			byte_15 = byte_22[19];
		}
		if (byte_12 == byte.MaxValue && byte_13 == byte.MaxValue && byte_14 == byte.MaxValue && byte_15 == byte.MaxValue)
		{
			byte_12 = 0;
			byte_13 = 0;
			byte_14 = 0;
			byte_15 = 0;
		}
		for (int j = 0; j < byte_16.Length; j++)
		{
			byte_16[j] = byte_22[32 + j];
		}
		char[] array = new char[12];
		for (int k = 0; k < 6; k++)
		{
			byte_17[k] = byte_22[256 + k];
			int num2 = (byte_22[256 + k] >> 4) & 0xF;
			int num3 = byte_22[256 + k] & 0xF;
			if (num2 >= 10)
			{
				num2 += 7;
			}
			if (num3 >= 10)
			{
				num3 += 7;
			}
			array[k * 2] = (char)(num2 + 48);
			array[k * 2 + 1] = (char)(num3 + 48);
		}
		string text = new string(array);
		if (string.IsNullOrEmpty(string_0) || (!string.IsNullOrEmpty(text) && text != Class333.smethod_58() && text != Class333.smethod_59()))
		{
			string_0 = text;
		}
		for (int l = 0; l < byte_18.Length; l++)
		{
			byte_18[l] = byte_22[264 + l];
		}
		byte_19 = byte_22[276];
		Class14 @class = new Class14(byte_0, byte_1, byte_2, byte_3, int_0);
		Class14 class2;
		if (byte_4 == 8 || byte_4 == 10)
		{
			class2 = new Class14(3, 5, 0, 1, 0);
		}
		else if (byte_4 == 22)
		{
			class2 = ((!flag) ? new Class14(1, 8, 0, 1, 0) : new Class14(1, 1, 1, 0, 0));
		}
		else
		{
			class2 = ((!flag) ? new Class14(1, 18, 0, 1, 0) : new Class14(1, 3, 0, 1, 0));
		}
		if (@class >= class2)
		{
			ushort_0 = (ushort)((byte_22[277] << 8) | (byte_22[278] & 0xFF));
		}
		else
		{
			ushort_0 = ushort.MaxValue;
		}
		if (!flag)
		{
			Class14 class3 = ((byte_4 == 8 || byte_4 == 10) ? new Class14(3, 5, 0, 2, 0) : new Class14(1, 18, 0, 2, 0));
			if (@class >= class3)
			{
				byte_20 = byte_22[279];
			}
		}
		byte_21 = byte_22[280];
		for (int m = 0; m < 4; m++)
		{
			uint_0[m] = (uint)(byte_22[281 + 4 * m] | (byte_22[281 + 4 * m + 1] << 8) | (byte_22[281 + 4 * m + 2] << 16) | (byte_22[281 + 4 * m + 3] << 24));
		}
		bool_0 = false;
		goto IL_0627;
		IL_0627:
		if (byte_4 != 8 && byte_4 != 10)
		{
			struct2_0[0].uint_0 = 16400u;
			struct2_0[0].ushort_0 = 4112;
			struct2_0[3].uint_0 = 16400u;
			struct2_0[3].ushort_0 = 4112;
			struct2_0[1].uint_0 = 8208u;
			struct2_0[1].ushort_0 = 1040;
			struct2_0[2].uint_0 = 16400u;
			struct2_0[2].ushort_0 = 16400;
		}
		else
		{
			struct2_0[0].uint_0 = 16384u;
			struct2_0[0].ushort_0 = 256;
			struct2_0[3].uint_0 = 0u;
			struct2_0[3].ushort_0 = 0;
			struct2_0[1].uint_0 = 0u;
			struct2_0[1].ushort_0 = 0;
			struct2_0[2].uint_0 = 0u;
			struct2_0[2].ushort_0 = 0;
		}
		struct1_0[0].uint_0 = 0u;
		struct1_0[0].uint_1 = 0u;
		struct1_0[0].uint_2 = 2048u;
		struct1_0[0].ushort_0 = 4096;
		return;
		IL_01a1:
		ushort_0 = ushort.MaxValue;
		goto IL_0627;
		IL_014b:
		if (num == 0)
		{
			goto IL_01a1;
		}
		if (byte_4 == byte.MaxValue && byte_5 == byte.MaxValue && byte_22.Length >= 32)
		{
			ushort_0 = byte_22[29];
			byte_4 = byte_22[30];
			byte_5 = byte_22[31];
		}
		else
		{
			ushort_0 = ushort.MaxValue;
		}
		goto IL_0627;
	}

	protected bool method_1(byte byte_22, byte byte_23)
	{
		if (((byte_22 != 8 && byte_22 != 10 && byte_22 != 9) || byte_23 != 1) && (byte_22 != 22 || byte_23 != 14) && (byte_22 != 22 || byte_23 != 14) && ((byte_22 != 20 && byte_22 != 25 && byte_22 != 24 && byte_22 != 0 && byte_22 != byte.MaxValue) || byte_23 != 1) && (byte_22 != 21 || byte_23 != 1))
		{
			return false;
		}
		return true;
	}

	internal bool method_2()
	{
		if (byte_4 == 22)
		{
			return byte_5 == 2;
		}
		return false;
	}

	internal bool method_3()
	{
		if (!bool_0)
		{
			return method_1(byte_4, byte_6);
		}
		return true;
	}

	internal void method_4(byte[] byte_22)
	{
		Class14 @class = new Class14(byte_0, byte_1, byte_2, byte_3, int_0);
		if (byte_4 != 8 && byte_4 != 10)
		{
			if (byte_4 != 20 && byte_4 != 25 && byte_4 != 24)
			{
				if (byte_4 == 22)
				{
					struct1_0[0].uint_0 = 0u;
					struct1_0[0].uint_1 = 0u;
					struct1_0[0].uint_2 = 2048u;
					struct1_0[0].ushort_0 = 4096;
					struct1_0[0].ushort_1 = 0;
					struct1_0[0].ushort_2 = 0;
					struct1_0[33].uint_0 = 5120u;
					struct1_0[33].uint_1 = 16384u;
					struct1_0[33].uint_2 = 16384u;
					struct1_0[33].ushort_0 = 4096;
					struct1_0[33].ushort_1 = 4;
					struct1_0[33].ushort_2 = 4;
				}
				else if (byte_4 == 21)
				{
					ushort uint_ = 13312;
					struct1_0[0].uint_0 = 0u;
					struct1_0[0].uint_1 = 0u;
					struct1_0[0].uint_2 = 2048u;
					struct1_0[0].ushort_0 = 13312;
					struct1_0[0].ushort_1 = 0;
					struct1_0[0].ushort_2 = 0;
					struct1_0[3].uint_0 = 25165824u;
					struct1_0[3].uint_1 = 16777216u;
					struct1_0[3].uint_2 = 13312u;
					struct1_0[3].ushort_0 = 13312;
					struct1_0[3].ushort_1 = 0;
					struct1_0[3].ushort_2 = 0;
					struct1_0[33].uint_0 = 5120u;
					if (@class < new Class14(2, 33, 0, 102, 0))
					{
						struct1_0[33].uint_1 = 24576u;
					}
					else
					{
						struct1_0[33].uint_1 = 32768u;
					}
					struct1_0[33].uint_2 = uint_;
					struct1_0[33].ushort_0 = uint_;
					struct1_0[33].ushort_1 = 4;
					struct1_0[33].ushort_2 = 4;
					if (@class >= new Class14(2, 36, 0, 1, 0))
					{
						struct1_0[34].uint_0 = 65536u;
						struct1_0[34].uint_1 = 16384u;
						struct1_0[34].uint_2 = uint_;
						struct1_0[34].ushort_0 = 4096;
						struct1_0[34].ushort_1 = 0;
						struct1_0[34].ushort_2 = 0;
					}
					else
					{
						struct1_0[34].uint_0 = 0u;
						struct1_0[34].uint_1 = 0u;
						struct1_0[34].uint_2 = 0u;
						struct1_0[34].ushort_0 = 0;
						struct1_0[34].ushort_1 = 0;
						struct1_0[34].ushort_2 = 0;
					}
					struct1_0[35].uint_0 = 131072u;
					if (@class < new Class14(2, 30, 0, 1, 0))
					{
						struct1_0[35].uint_1 = 425984u;
					}
					else if (@class < new Class14(2, 33, 0, 4, 0))
					{
						struct1_0[35].uint_1 = 520192u;
					}
					else if (@class < new Class14(2, 35, 0, 5, 0))
					{
						struct1_0[35].uint_1 = 585728u;
					}
					else
					{
						struct1_0[35].uint_1 = 651264u;
					}
					struct1_0[35].uint_2 = uint_;
					struct1_0[35].ushort_0 = uint_;
					struct1_0[35].ushort_1 = 4;
					struct1_0[35].ushort_2 = 4;
					struct1_0[36].uint_0 = 0u;
					struct1_0[36].uint_1 = 0u;
					struct1_0[36].uint_2 = 0u;
					struct1_0[36].ushort_0 = 0;
					struct1_0[36].ushort_1 = 0;
					struct1_0[36].ushort_2 = 0;
					if (@class < new Class14(2, 33, 0, 4, 0))
					{
						struct1_0[37].uint_0 = 651520u;
					}
					else if (@class < new Class14(2, 35, 0, 5, 0))
					{
						struct1_0[37].uint_0 = 717056u;
					}
					else
					{
						struct1_0[37].uint_0 = 782848u;
					}
					struct1_0[37].uint_1 = 1024u;
					struct1_0[37].uint_2 = uint_;
					struct1_0[37].ushort_0 = uint_;
					struct1_0[37].ushort_1 = 0;
					struct1_0[37].ushort_2 = 0;
					if (@class < new Class14(2, 33, 0, 4, 0))
					{
						struct1_0[38].uint_0 = 652544u;
					}
					else if (@class < new Class14(2, 35, 0, 5, 0))
					{
						struct1_0[38].uint_0 = 718080u;
					}
					else
					{
						struct1_0[38].uint_0 = 784384u;
					}
					if (@class < new Class14(2, 33, 1, 0, 0))
					{
						struct1_0[38].uint_1 = 508u;
					}
					else
					{
						struct1_0[38].uint_1 = 1024u;
					}
					struct1_0[38].uint_2 = uint_;
					struct1_0[38].ushort_0 = 4096;
					struct1_0[38].ushort_1 = 0;
					struct1_0[38].ushort_2 = 0;
					struct1_0[40].uint_0 = 1073741824u;
					struct1_0[40].uint_1 = 536870912u;
					struct1_0[40].uint_2 = uint_;
					struct1_0[40].ushort_0 = 0;
					struct1_0[40].ushort_1 = 0;
					struct1_0[40].ushort_2 = 4;
					struct1_0[41].uint_0 = 1611137024u;
					struct1_0[41].uint_1 = 4194304u;
					struct1_0[41].uint_2 = uint_;
					struct1_0[41].ushort_0 = 0;
					struct1_0[41].ushort_1 = 0;
					struct1_0[41].ushort_2 = 2;
					struct1_0[42].uint_0 = 1879048192u;
					struct1_0[42].uint_1 = 4194304u;
					struct1_0[42].uint_2 = uint_;
					struct1_0[42].ushort_0 = uint_;
					struct1_0[42].ushort_1 = 0;
					struct1_0[42].ushort_2 = 0;
					struct1_0[43].uint_0 = 1883242496u;
					struct1_0[43].uint_1 = 4194304u;
					struct1_0[43].uint_2 = uint_;
					struct1_0[43].ushort_0 = uint_;
					struct1_0[43].ushort_1 = 0;
					struct1_0[43].ushort_2 = 0;
					if (@class < new Class14(2, 34, 0, 1, 0))
					{
						struct1_0[44].uint_0 = 0u;
						struct1_0[44].uint_1 = 0u;
						struct1_0[44].uint_2 = 0u;
						struct1_0[44].ushort_0 = 0;
						struct1_0[44].ushort_1 = 0;
						struct1_0[44].ushort_2 = 0;
						struct1_0[45].uint_0 = 0u;
						struct1_0[45].uint_1 = 0u;
						struct1_0[45].uint_2 = 0u;
						struct1_0[45].ushort_0 = 0;
						struct1_0[45].ushort_1 = 0;
						struct1_0[45].ushort_2 = 0;
					}
					else
					{
						struct1_0[44].uint_0 = 1887436800u;
						struct1_0[44].uint_1 = 4194304u;
						struct1_0[44].uint_2 = uint_;
						struct1_0[44].ushort_0 = uint_;
						struct1_0[44].ushort_1 = 0;
						struct1_0[44].ushort_2 = 0;
						struct1_0[45].uint_0 = 1891631104u;
						struct1_0[45].uint_1 = 4194304u;
						struct1_0[45].uint_2 = uint_;
						struct1_0[45].ushort_0 = uint_;
						struct1_0[45].ushort_1 = 0;
						struct1_0[45].ushort_2 = 0;
					}
				}
				else if (byte_4 == byte.MaxValue)
				{
					struct1_0[0].uint_0 = 0u;
					struct1_0[0].uint_1 = 0u;
					struct1_0[0].uint_2 = 2048u;
					struct1_0[0].ushort_0 = 4096;
					struct1_0[0].ushort_1 = 0;
					struct1_0[0].ushort_2 = 0;
					struct1_0[33].uint_0 = 5120u;
					struct1_0[33].uint_1 = 4096u;
					struct1_0[33].uint_2 = 16384u;
					struct1_0[33].ushort_0 = 4096;
					struct1_0[33].ushort_1 = 4;
					struct1_0[33].ushort_2 = 4;
				}
				return;
			}
			struct1_0[0].uint_0 = 0u;
			struct1_0[0].uint_1 = 0u;
			struct1_0[0].uint_2 = 2048u;
			struct1_0[0].ushort_0 = 4096;
			struct1_0[0].ushort_1 = 0;
			struct1_0[0].ushort_2 = 0;
			struct1_0[3].uint_0 = 25165824u;
			struct1_0[3].uint_1 = 4194304u;
			struct1_0[3].uint_2 = 16384u;
			struct1_0[3].ushort_0 = 4096;
			struct1_0[3].ushort_1 = 0;
			struct1_0[3].ushort_2 = 0;
			struct1_0[33].uint_0 = 5120u;
			if (@class < new Class14(1, 15, 0, 2, 0))
			{
				struct1_0[33].uint_1 = 16384u;
			}
			else
			{
				struct1_0[33].uint_1 = 32768u;
			}
			struct1_0[33].uint_2 = 16384u;
			struct1_0[33].ushort_0 = 4096;
			struct1_0[33].ushort_1 = 4;
			struct1_0[33].ushort_2 = 4;
			struct1_0[34].uint_0 = 65536u;
			struct1_0[34].uint_1 = 16384u;
			struct1_0[34].uint_2 = 16384u;
			struct1_0[34].ushort_0 = 4096;
			struct1_0[34].ushort_1 = 0;
			struct1_0[34].ushort_2 = 0;
			struct1_0[35].uint_0 = 131072u;
			if (@class < new Class14(1, 30, 0, 1, 0))
			{
				struct1_0[35].uint_1 = 425984u;
			}
			else
			{
				struct1_0[35].uint_1 = 520192u;
			}
			struct1_0[35].uint_2 = 16384u;
			struct1_0[35].ushort_0 = 4096;
			struct1_0[35].ushort_1 = 4;
			struct1_0[35].ushort_2 = 4;
			struct1_0[36].uint_0 = 651264u;
			struct1_0[36].uint_1 = 112u;
			struct1_0[36].uint_2 = 16384u;
			struct1_0[36].ushort_0 = 4096;
			struct1_0[36].ushort_1 = 0;
			struct1_0[36].ushort_2 = 0;
			struct1_0[37].uint_0 = 651520u;
			struct1_0[37].uint_1 = 1024u;
			struct1_0[37].uint_2 = 16384u;
			struct1_0[37].ushort_0 = 4096;
			struct1_0[37].ushort_1 = 0;
			struct1_0[37].ushort_2 = 0;
			struct1_0[38].uint_0 = 652544u;
			if (@class < new Class14(1, 33, 2, 0, 0))
			{
				struct1_0[38].uint_1 = 508u;
			}
			else
			{
				struct1_0[38].uint_1 = 1024u;
			}
			struct1_0[38].uint_2 = 16384u;
			struct1_0[38].ushort_0 = 4096;
			struct1_0[38].ushort_1 = 0;
			struct1_0[38].ushort_2 = 0;
			struct1_0[40].uint_0 = 1073741824u;
			struct1_0[40].uint_1 = 536870912u;
			if (byte_5 == 3)
			{
				struct1_0[40].uint_2 = 2097152u;
			}
			else
			{
				struct1_0[40].uint_2 = 1048576u;
			}
			struct1_0[40].ushort_0 = 16384;
			if (@class < new Class14(1, 21, 0, 104, 0))
			{
				struct1_0[40].ushort_1 = 2048;
			}
			else
			{
				struct1_0[40].ushort_1 = 0;
			}
			struct1_0[40].ushort_2 = 4;
			if (byte_5 == 3)
			{
				if (@class < new Class14(1, 21, 1, 102, 0))
				{
					struct1_0[32].uint_0 = 0u;
					struct1_0[32].uint_1 = 0u;
					struct1_0[32].uint_2 = 0u;
					struct1_0[32].ushort_0 = 0;
					struct1_0[32].ushort_1 = 0;
					struct1_0[32].ushort_2 = 0;
				}
				else
				{
					struct1_0[32].uint_0 = 1610612736u;
					struct1_0[32].uint_1 = 8194u;
					struct1_0[32].uint_2 = 8194u;
					struct1_0[32].ushort_0 = 0;
					struct1_0[32].ushort_1 = 0;
					struct1_0[32].ushort_2 = 0;
				}
			}
			else
			{
				struct1_0[32].uint_0 = 1610612736u;
				struct1_0[32].uint_1 = 8194u;
				struct1_0[32].uint_2 = 8194u;
				struct1_0[32].ushort_0 = 0;
				struct1_0[32].ushort_1 = 0;
				struct1_0[32].ushort_2 = 0;
			}
			struct1_0[46].uint_0 = 8388608u;
			struct1_0[46].uint_1 = 8388608u;
			struct1_0[46].uint_2 = 16384u;
			struct1_0[46].ushort_0 = 0;
			struct1_0[46].ushort_1 = 0;
			struct1_0[46].ushort_2 = 0;
		}
		else
		{
			uint uint_2 = 16384u;
			struct1_0[0].uint_0 = 0u;
			struct1_0[0].uint_1 = 0u;
			struct1_0[0].uint_2 = 2048u;
			struct1_0[0].ushort_0 = 256;
			struct1_0[0].ushort_1 = 0;
			struct1_0[0].ushort_2 = 0;
			struct1_0[3].uint_0 = 0u;
			struct1_0[3].uint_1 = 0u;
			struct1_0[3].uint_2 = 0u;
			struct1_0[3].ushort_0 = 0;
			struct1_0[3].ushort_1 = 0;
			struct1_0[3].ushort_2 = 0;
			struct1_0[33].uint_0 = 5120u;
			if (@class < new Class14(3, 3, 0, 2, 0))
			{
				struct1_0[33].uint_1 = 12288u;
			}
			else
			{
				struct1_0[33].uint_1 = 32768u;
			}
			struct1_0[33].uint_2 = uint_2;
			struct1_0[33].ushort_0 = 256;
			struct1_0[33].ushort_1 = 4;
			struct1_0[33].ushort_2 = 4;
			struct1_0[34].uint_0 = 65536u;
			struct1_0[34].uint_1 = 16384u;
			struct1_0[34].uint_2 = uint_2;
			struct1_0[34].ushort_0 = 256;
			struct1_0[34].ushort_1 = 0;
			struct1_0[34].ushort_2 = 0;
			struct1_0[35].uint_0 = 131072u;
			struct1_0[35].uint_1 = 375808u;
			struct1_0[35].uint_2 = uint_2;
			struct1_0[35].ushort_0 = 256;
			struct1_0[35].ushort_1 = 4;
			struct1_0[35].ushort_2 = 4;
			struct1_0[36].uint_0 = 651264u;
			struct1_0[36].uint_1 = 112u;
			struct1_0[36].uint_2 = uint_2;
			struct1_0[36].ushort_0 = 256;
			struct1_0[36].ushort_1 = 0;
			struct1_0[36].ushort_2 = 0;
			struct1_0[37].uint_0 = 651520u;
			struct1_0[37].uint_1 = 1024u;
			struct1_0[37].uint_2 = uint_2;
			struct1_0[37].ushort_0 = 256;
			struct1_0[37].ushort_1 = 0;
			struct1_0[37].ushort_2 = 0;
			struct1_0[38].uint_0 = 652544u;
			struct1_0[38].uint_1 = 335u;
			struct1_0[38].uint_2 = uint_2;
			struct1_0[38].ushort_0 = 256;
			struct1_0[38].ushort_1 = 0;
			struct1_0[38].ushort_2 = 0;
			struct1_0[40].uint_0 = 1073741824u;
			struct1_0[40].uint_1 = 8388608u;
			struct1_0[40].uint_2 = uint_2;
			struct1_0[40].ushort_0 = 0;
			struct1_0[40].ushort_1 = 2048;
			struct1_0[40].ushort_2 = 4;
			struct1_0[32].uint_0 = 0u;
			struct1_0[32].uint_1 = 0u;
			struct1_0[32].uint_2 = 0u;
			struct1_0[32].ushort_0 = 0;
			struct1_0[32].ushort_1 = 0;
			struct1_0[32].ushort_2 = 0;
		}
	}
}
