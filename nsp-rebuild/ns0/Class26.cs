using System;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using ns5;
using ns7;

namespace ns0;

[DefaultMember("Item")]
internal class Class26 : IEnumerable
{
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	[CompilerGenerated]
	private EventHandler eventHandler_1;

	private ArrayList arrayList_0 = new ArrayList();

	private int int_0;

	private float float_0;

	private float float_1;

	private float float_2;

	private float float_3;

	private float float_4;

	private float float_5;

	private float float_6 = 15f;

	private float float_7;

	private bool bool_0;

	private float[] float_8;

	private float[] float_9;

	private float[] float_10;

	private bool bool_1;

	private PointF[] pointF_0;

	private string[] string_0;

	private int int_1;

	private object object_0 = new object();

	[SpecialName]
	[CompilerGenerated]
	internal void method_0(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_2(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = eventHandler_1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = eventHandler_1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal Class26()
	{
	}

	[SpecialName]
	internal int method_4()
	{
		return int_0;
	}

	[SpecialName]
	internal void method_5(int int_2)
	{
		int_0 = int_2;
		bool_0 = false;
	}

	[SpecialName]
	internal float method_6()
	{
		return float_0;
	}

	[SpecialName]
	internal void method_7(float float_11)
	{
		float_0 = float_11;
		float_2 = method_32(float_0);
		bool_1 = true;
		bool_0 = false;
	}

	[SpecialName]
	internal float method_8()
	{
		return float_1;
	}

	[SpecialName]
	internal void method_9(float float_11)
	{
		float_1 = float_11;
		float_3 = method_32(float_1);
		bool_1 = true;
		bool_0 = false;
	}

	[SpecialName]
	internal float method_10()
	{
		return float_4;
	}

	[SpecialName]
	internal void method_11(float float_11)
	{
		float_4 = float_11;
		bool_0 = false;
	}

	[SpecialName]
	internal float method_12()
	{
		return float_5;
	}

	[SpecialName]
	internal void method_13(float float_11)
	{
		float_5 = float_11;
		bool_0 = false;
	}

	[SpecialName]
	internal float method_14()
	{
		return float_6;
	}

	[SpecialName]
	internal void method_15(float float_11)
	{
		float_6 = float_11;
		bool_0 = false;
	}

	[SpecialName]
	internal float method_16()
	{
		return float_7;
	}

	[SpecialName]
	internal void method_17(float float_11)
	{
		float_7 = float_11;
		bool_0 = false;
	}

	[SpecialName]
	internal bool method_18()
	{
		return bool_0;
	}

	[SpecialName]
	internal Class27 method_19(int int_2)
	{
		if (bool_0)
		{
			return (Class27)arrayList_0[int_2];
		}
		return null;
	}

	[SpecialName]
	internal int method_20()
	{
		return arrayList_0.Count;
	}

	[SpecialName]
	internal float[] method_21()
	{
		return float_9;
	}

	[SpecialName]
	internal float[] method_22()
	{
		return float_10;
	}

	[SpecialName]
	internal float[] method_23()
	{
		return float_8;
	}

	[SpecialName]
	internal bool method_24()
	{
		return bool_1;
	}

	internal void method_25(int int_2, PointF[] pointF_1, string[] string_1)
	{
		int_1 = int_2;
		pointF_0 = pointF_1;
		string_0 = string_1;
		float_2 = method_32(float_0);
		float_3 = method_32(float_1);
		bool_0 = false;
	}

	internal string method_26()
	{
		string text = string_0[0];
		for (int i = 2; i < string_0.Length; i += 2)
		{
			text = string.Format(Class333.smethod_191(), text, string_0[i]);
		}
		return text;
	}

	internal void method_27()
	{
		Class231 @class = Class233.smethod_24(int_0);
		if (@class == null)
		{
			@class = Class233.smethod_24(0);
		}
		string[] array = new string[@class.abw.Count];
		PointF[] array2 = new PointF[@class.abw.Count];
		int num = 0;
		foreach (Class231.Class232 item in @class.abw)
		{
			array2[num] = new PointF(item.BRX, (float)item.BRx);
			array[num] = item.BRY;
			num++;
		}
		method_25(@class.abW, array2, array);
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, new EventArgs());
		}
		method_30();
		method_31();
		bool_0 = true;
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
		}
		bool_1 = false;
	}

	internal float method_28(float float_11)
	{
		if (float_1 == float_0)
		{
			return float_4;
		}
		return float_4 + (float_11 - float_0) / (float_1 - float_0) * (float_5 - float_4);
	}

	internal float method_29(float float_11)
	{
		return float_0 + (float_11 - float_4) / (float_5 - float_4) * (float_1 - float_0);
	}

	public IEnumerator GetEnumerator()
	{
		return arrayList_0.GetEnumerator();
	}

	private void method_30()
	{
		lock (object_0)
		{
			float num = float_0;
			float num2 = float_1;
			float num3 = float_2;
			float num4 = float_3;
			float num5 = float_4;
			float num6 = float_5;
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
			arrayList_0.Clear();
			if (pointF_0 != null && pointF_0.Length > 1)
			{
				float num10 = num5;
				float num11 = num;
				float num12 = num3;
				string text = string.Empty;
				int num13 = 0;
				if (num <= pointF_0[0].X)
				{
					text = string_0[0];
					num13 = 1;
				}
				else
				{
					while (num > pointF_0[num13].X)
					{
						num13++;
						if (num13 == pointF_0.Length)
						{
							break;
						}
					}
					if (num13 == pointF_0.Length)
					{
						if (flag)
						{
							arrayList_0.Add(new Class27(float_3, float_2, num2, num, num6, num5, float_6, float_7, string_0[string_0.Length - 1], int_1));
						}
						else
						{
							arrayList_0.Add(new Class27(float_2, float_3, num, num2, num5, num6, float_6, float_7, string_0[string_0.Length - 1], int_1));
						}
					}
					else
					{
						text = string_0[num13];
					}
				}
				int num14 = num13;
				while (true)
				{
					if (num14 >= pointF_0.Length)
					{
						return;
					}
					if (pointF_0[num14].X <= num2 && string_0[num14] == text && num14 != pointF_0.Length - 1)
					{
						float num15 = num5 + (num5 - num6) * ((pointF_0[num14].X - num) / (num - num2));
						if (num15 != num10)
						{
							float x = pointF_0[num14].X;
							float y = pointF_0[num14].Y;
							if (flag)
							{
								arrayList_0.Add(new Class27(y, num12, x, num11, num15, num10, float_6, float_7, string_0[num14], int_1));
							}
							else
							{
								arrayList_0.Add(new Class27(num12, y, num11, x, num10, num15, float_6, float_7, string_0[num14], int_1));
							}
							num10 = num15;
							num11 = x;
							num12 = y;
						}
					}
					else if (string_0[num14] == text)
					{
						break;
					}
					text = string_0[num14];
					num14++;
				}
				float num16 = num6;
				float num17 = num2;
				float num18 = num4;
				if (flag)
				{
					arrayList_0.Add(new Class27(num18, num12, num17, num11, num16, num10, float_6, float_7, text, int_1));
				}
				else
				{
					arrayList_0.Add(new Class27(num12, num18, num11, num17, num10, num16, float_6, float_7, text, int_1));
				}
				num10 = num16;
				num11 = num17;
				num12 = num18;
			}
			else if (flag)
			{
				arrayList_0.Add(new Class27(num2, num, num2, num, num6, num5, float_6, float_7, Class333.smethod_102(), 0));
			}
			else
			{
				arrayList_0.Add(new Class27(num, num2, num, num2, num5, num6, float_6, float_7, Class333.smethod_102(), 0));
			}
		}
	}

	private void method_31()
	{
		ArrayList arrayList = new ArrayList();
		ArrayList arrayList2 = new ArrayList();
		ArrayList arrayList3 = new ArrayList();
		lock (object_0)
		{
			foreach (Class27 item in arrayList_0)
			{
				float[] c = item.method_2();
				float[] c2 = item.method_1();
				float[] c3 = item.method_0();
				arrayList.AddRange(c);
				arrayList2.AddRange(c2);
				arrayList3.AddRange(c3);
			}
		}
		for (int i = 0; i < arrayList.Count - 1; i++)
		{
			if ((float)arrayList[i] > (float)arrayList[i + 1])
			{
				float num = (float)arrayList[i];
				arrayList[i] = (float)arrayList[i + 1];
				arrayList[i + 1] = num;
				num = (float)arrayList2[i];
				arrayList2[i] = (float)arrayList2[i + 1];
				arrayList2[i + 1] = num;
				num = (float)arrayList3[i];
				arrayList3[i] = (float)arrayList3[i + 1];
				arrayList3[i + 1] = num;
				i = -1;
			}
			else if ((float)arrayList[i] == (float)arrayList[i + 1])
			{
				arrayList.RemoveAt(i);
				arrayList2.RemoveAt(i);
				arrayList3.RemoveAt(i);
				i = -1;
			}
		}
		float_9 = (float[])arrayList2.ToArray(typeof(float));
		float_10 = (float[])arrayList.ToArray(typeof(float));
		float_8 = (float[])arrayList3.ToArray(typeof(float));
	}

	internal float method_32(float float_11)
	{
		if (pointF_0 != null && pointF_0.Length >= 2)
		{
			PointF empty = PointF.Empty;
			int num = 1;
			while (true)
			{
				if (num < pointF_0.Length)
				{
					empty = pointF_0[num];
					if (!(empty.X <= float_11))
					{
						break;
					}
					num++;
					continue;
				}
				empty = pointF_0[pointF_0.Length - 2];
				return method_34(float_11, empty, pointF_0[pointF_0.Length - 1]);
			}
			return method_34(float_11, empty, pointF_0[num - 1]);
		}
		return float_11;
	}

	internal float method_33(float float_11)
	{
		if (pointF_0 != null && pointF_0.Length >= 2)
		{
			PointF empty = PointF.Empty;
			int num = 1;
			while (true)
			{
				if (num < pointF_0.Length)
				{
					empty = pointF_0[num];
					if (!(empty.Y <= float_11))
					{
						break;
					}
					num++;
					continue;
				}
				empty = pointF_0[pointF_0.Length - 2];
				return method_35(float_11, empty, pointF_0[pointF_0.Length - 1]);
			}
			return method_35(float_11, empty, pointF_0[num - 1]);
		}
		return float_11;
	}

	private float method_34(float float_11, PointF pointF_1, PointF pointF_2)
	{
		float num = (pointF_2.Y - pointF_1.Y) / (pointF_2.X - pointF_1.X);
		float num2 = pointF_1.Y - num * pointF_1.X;
		return num * float_11 + num2;
	}

	private float method_35(float float_11, PointF pointF_1, PointF pointF_2)
	{
		float num = (pointF_2.Y - pointF_1.Y) / (pointF_2.X - pointF_1.X);
		float num2 = pointF_1.Y - num * pointF_1.X;
		return (float_11 - num2) / num;
	}
}
