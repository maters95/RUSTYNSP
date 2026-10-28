using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal class Class27
{
	private float[] float_0;

	private float[] float_1;

	private float[] float_2;

	private bool bool_0;

	private string string_0;

	private float float_3;

	private float float_4;

	private float float_5;

	private float float_6;

	private float float_7;

	private float float_8;

	private float float_9;

	private float float_10;

	[SpecialName]
	internal float[] method_0()
	{
		return float_0;
	}

	[SpecialName]
	internal float[] method_1()
	{
		return float_1;
	}

	[SpecialName]
	internal float[] method_2()
	{
		return float_2;
	}

	[SpecialName]
	internal string method_3()
	{
		return string_0;
	}

	[SpecialName]
	internal bool method_4()
	{
		return bool_0;
	}

	internal Class27(float float_11, float float_12, float float_13, float float_14, float float_15, float float_16, float float_17, float float_18, string string_1, int int_0)
	{
		string_0 = string_1;
		float_4 = float_11;
		float_3 = float_12;
		float_7 = float_13;
		float_6 = float_14;
		float_9 = float_15;
		float_10 = float_16;
		float_5 = method_5(float_17, int_0);
		float_8 = (float)Math.Round(float_5 / (float_3 - float_4) * (float_6 - float_7), int_0);
		float value = (float_10 - float_9) * (float_5 / (float_3 - float_4));
		if (float_18 >= Math.Abs(value))
		{
			bool_0 = true;
		}
		else
		{
			bool_0 = false;
		}
		method_6(int_0);
	}

	private float method_5(float float_11, int int_0)
	{
		float num = 1E+09f;
		float value = ((float_11 != 0f) ? ((float_10 - float_9) / float_11) : 0f);
		if (Math.Abs(value) < 1f)
		{
			value = 1f;
		}
		float num2 = Math.Abs(value);
		if (float_3 != float_4)
		{
			float num3 = float_3 - float_4;
			float num4 = num2;
			int num5 = 2;
			while (Math.Abs(num3 / num) < num4)
			{
				num /= 2f;
				num5 = 2;
				if (Math.Abs(num3 / num) >= num4)
				{
					break;
				}
				num /= 5f;
				num5 = 5;
			}
			num = (float)Math.Round(num * (float)num5, int_0);
			float num6 = (float)Math.Round(1f / (float)Math.Pow(10.0, int_0), int_0);
			if (num < num6)
			{
				num = num6;
			}
			if (num3 < 0f)
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

	private void method_6(int int_0)
	{
		float num = float_4 % float_5;
		if (float_5 == 0f)
		{
			num = 0f;
		}
		float num2 = float_4 - num;
		int num3 = 2;
		if (float_5 != 0f)
		{
			num3 = (int)((float_3 - (float_4 - num)) / float_5) + 1;
		}
		for (; (num2 < float_4 && float_5 > 0f) || (num2 > float_4 && !(float_5 >= 0f)); num2 += float_5)
		{
			num3--;
		}
		if (bool_0)
		{
			num3 -= num3 / 2;
		}
		float num4 = float_3 - float_4;
		float num5 = float_10 - float_9;
		float num6 = 0f;
		if (num4 != 0f)
		{
			num6 = num5 / num4;
		}
		bool flag = num2 % (float_5 * 2f) != 0f;
		float_1 = new float[num3];
		float_2 = new float[num3];
		for (int i = 0; i < num3; i++)
		{
			if (bool_0 & flag)
			{
				num2 += float_5;
			}
			flag = true;
			float_1[i] = (float)Math.Round(num2, int_0);
			float_2[i] = float_9 + num6 * (float_1[i] - float_4);
			num2 += float_5;
		}
		float_0 = new float[num3];
		float num7 = float_7;
		for (int j = 0; j < num3; j++)
		{
			if (bool_0 & flag)
			{
				num7 += float_8;
			}
			flag = true;
			float_0[j] = num7;
			num7 += float_8;
		}
	}
}
