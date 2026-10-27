using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using NSP.SettingsFramework;
using c;
using crc;

namespace C
{
	internal class CC
	{
		private CB ayn;

		private Framework ayO;

		private string ayo;

		private string ayP;

		private string ayp;

		private string ayQ;

		private bool ayq;

		internal CC(CB P_0, Framework P_1, string P_2)
		{
			ayn = P_0;
			ayO = P_1;
			ayo = P_2;
		}

		public virtual string ToString()
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoJ() + ((!string.IsNullOrEmpty(ayo)) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoh() + ayo) : string.Empty) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + ((!string.IsNullOrEmpty(ayP)) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoi() + ayP) : string.Empty);
		}

		[SpecialName]
		internal CB A()
		{
			return ayn;
		}

		[SpecialName]
		internal string a()
		{
			return ayo;
		}

		[SpecialName]
		internal string B()
		{
			return ayp;
		}

		[SpecialName]
		internal void A(string P_0)
		{
			ayp = P_0;
		}

		[SpecialName]
		internal string b()
		{
			return ayQ;
		}

		[SpecialName]
		internal void a(string P_0)
		{
			ayQ = P_0;
		}

		[SpecialName]
		internal bool C()
		{
			return ayq;
		}

		[SpecialName]
		internal void A(bool P_0)
		{
			ayq = P_0;
		}

		[SpecialName]
		internal void B(string P_0)
		{
			ayP = P_0;
		}

		internal bool c()
		{
			if (string.IsNullOrEmpty(ayP))
			{
				return false;
			}
			string text = ayP;
			T.A(ref text, ayO);
			return T.A(ref text);
		}
	}
	internal class Cc
	{
		private Framework ays;

		private string ayT;

		private string ayt;

		private string ayU;

		private string ayu;

		private int ayV = -1;

		private bool ayv;

		private List<Cc> ayW = new List<Cc>();

		internal Cc(Framework P_0, string P_1, string P_2, string P_3, string P_4, int P_5, bool P_6)
		{
			ays = P_0;
			ayT = P_1;
			ayt = P_2;
			ayU = P_3;
			ayu = P_4;
			ayV = P_5;
			ayv = P_6;
		}

		internal void A(Cc P_0)
		{
			ayW.Add(P_0);
		}

		internal Setting A(Framework P_0)
		{
			if (ayV != -1)
			{
				return P_0.A(ayV);
			}
			return null;
		}

		public virtual void A(bool P_0)
		{
			A(null, ays, ays, null, null, P_0);
		}

		public virtual void A(Setting P_0, Framework P_1, Framework P_2, List<int[]> P_3, List<int[]> P_4, bool P_5)
		{
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			if (ayT == null)
			{
				return;
			}
			Setting setting = A(P_1);
			if (setting == null)
			{
				setting = P_0;
			}
			if (!A(setting, P_4, P_1, P_2))
			{
				return;
			}
			if (setting != null)
			{
				int num = a(AxisType.Column);
				int num2 = a(AxisType.Row);
				int num3 = a(AxisType.Slice);
				int num4 = b(AxisType.Column);
				int num5 = b(AxisType.Row);
				int num6 = b(AxisType.Slice);
				if (num4 == -1)
				{
					num4 = setting.av()[2] - num;
				}
				if (num5 == -1)
				{
					num5 = setting.av()[1] - num2;
				}
				if (num6 == -1)
				{
					num6 = setting.av()[0] - num3;
				}
				if (ayU != null)
				{
					A(setting, P_2, num3, num2, num, num6, num5, num4, P_3, P_4, P_5);
				}
				else
				{
					A(setting, P_1, P_2, num3, num2, num, num6, num5, num4, P_3, P_4, P_5);
				}
			}
			Enumerator<Cc> enumerator = ayW.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.A(P_0, P_1, P_2, P_3, P_4, P_5);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		protected bool A(Setting P_0, List<int[]> P_1, Framework P_2, Framework P_3)
		{
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			bool result = true;
			if (ayt != null)
			{
				string text = ayt;
				if (ayt.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl() + P_0.A() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl()) || ayt.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl() + P_0.A() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoj()))
				{
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					if (ayt.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl() + P_0.A() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoj()))
					{
						int num4 = ayt.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl() + P_0.A() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoj());
						int num5 = ayt.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl(), num4 + 1);
						int num6 = ayt.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoj(), num4 + 1);
						string[] array = ayt.Substring(num6 + 1, num5 - (num6 + 1)).Split('e', (StringSplitOptions)0);
						switch (array.Length)
						{
						case 1:
							num = 0;
							num2 = 0;
							num3 = int.Parse(array[0]);
							break;
						case 2:
							num = 0;
							num2 = int.Parse(array[0]);
							num3 = int.Parse(array[1]);
							break;
						case 3:
							num = int.Parse(array[0]);
							num2 = int.Parse(array[1]);
							num3 = int.Parse(array[2]);
							break;
						}
					}
					bool flag = false;
					if (P_1 != null)
					{
						Enumerator<int[]> enumerator = P_1.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								int[] current = enumerator.Current;
								if (current[0] == num && current[1] == num2 && current[2] == num3)
								{
									flag = true;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
					}
					if (flag)
					{
						T.A(ref text, P_2);
					}
					else
					{
						T.A(ref text, P_3);
					}
				}
				else
				{
					T.A(ref text, P_3);
				}
				result = T.A(ref text);
			}
			return result;
		}

		private void A(Setting P_0, Framework P_1, int P_2, int P_3, int P_4, int P_5, int P_6, int P_7, List<int[]> P_8, List<int[]> P_9, bool P_10)
		{
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			if (ayT[0] != 's' || ayT[ayT.Length - 1] != 's' || ayT.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG()) || ayT.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoj()))
			{
				return;
			}
			int num = int.Parse(ayT.Substring(1, ayT.Length - 2));
			Setting setting = P_1.A(num);
			int num2 = A(AxisType.Column);
			int num3 = A(AxisType.Row);
			int num4 = A(AxisType.Slice);
			int num5 = B(AxisType.Column);
			int num6 = B(AxisType.Row);
			int num7 = B(AxisType.Slice);
			if (num5 == -1)
			{
				num5 = setting.av()[2] - num2;
			}
			if (num6 == -1)
			{
				num6 = setting.av()[1] - num3;
			}
			if (num7 == -1)
			{
				num7 = setting.av()[0] - num4;
			}
			if (num5 != P_7 || num6 != P_6 || num7 != P_5)
			{
				return;
			}
			for (int i = 0; i < P_5; i++)
			{
				for (int j = 0; j < P_6; j++)
				{
					for (int k = 0; k < P_7; k++)
					{
						bool flag = false;
						if (P_8 != null)
						{
							Enumerator<int[]> enumerator = P_8.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									int[] current = enumerator.Current;
									if (current[0] == P_2 + i && current[1] == P_3 + j && current[2] == P_4 + k)
									{
										flag = true;
										break;
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator).Dispose();
							}
						}
						if (!flag)
						{
							int num8 = setting.B(num2 + k, num3 + j, num4 + i);
							P_0.A(P_4 + k, P_3 + j, P_2 + i, num8, P_10);
							int[] array = new int[3]
							{
								P_2 + i,
								P_3 + j,
								P_4 + k
							};
							P_8?.Add(array);
							P_9?.Add(array);
						}
					}
				}
			}
		}

		private void A(Setting P_0, Framework P_1, Framework P_2, int P_3, int P_4, int P_5, int P_6, int P_7, int P_8, List<int[]> P_9, List<int[]> P_10, bool P_11)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			for (int i = P_3; i < P_3 + P_6; i++)
			{
				for (int j = P_4; j < P_4 + P_7; j++)
				{
					for (int k = P_5; k < P_5 + P_8; k++)
					{
						bool flag = false;
						if (P_9 != null)
						{
							Enumerator<int[]> enumerator = P_9.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									int[] current = enumerator.Current;
									if (current[0] == i && current[1] == j && current[2] == k)
									{
										flag = true;
										break;
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator).Dispose();
							}
						}
						if (flag)
						{
							continue;
						}
						string text = ayT;
						string text2 = text;
						string text3 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoK(), (object)P_0.A());
						string text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aok();
						cd<object> buffer = default(cd<object>);
						cc.a<cd<object>, object>(ref buffer, 0) = P_0.A();
						cc.a<cd<object>, object>(ref buffer, 1) = i;
						cc.a<cd<object>, object>(ref buffer, 2) = j;
						cc.a<cd<object>, object>(ref buffer, 3) = k;
						text = text2.Replace(text3, string.Format(text4, cc.A<cd<object>, object>(in buffer, 4)));
						bool flag2 = false;
						if (P_10 != null)
						{
							Enumerator<int[]> enumerator = P_10.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									int[] current2 = enumerator.Current;
									if (current2[0] == i && current2[1] == j && current2[2] == k)
									{
										flag2 = true;
										break;
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator).Dispose();
							}
						}
						if (flag2)
						{
							T.A(ref text, P_1);
						}
						else
						{
							T.A(ref text, P_2);
						}
						int num = T.a(ref text);
						P_0.A(k, j, i, num, P_11);
						int[] array = new int[3] { i, j, k };
						P_9?.Add(array);
						P_10?.Add(array);
					}
				}
			}
		}

		private int A(AxisType P_0)
		{
			if (ayU == null)
			{
				return 0;
			}
			string[] array = ayU.Split(',', (StringSplitOptions)0);
			switch (P_0)
			{
			case AxisType.Slice:
			{
				if (array.Length < 3 || (array.Length == 3 && array[0].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoL())))
				{
					return 0;
				}
				string text3 = array[0].Trim();
				if (text3.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text3.Substring(0, text3.Length - 1));
				}
				if (text3.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text3.Split('+', (StringSplitOptions)0)[0]);
				}
				return int.Parse(text3);
			}
			case AxisType.Row:
			{
				if (array.Length < 2 || (array.Length >= 2 && array[array.Length - 2].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoL())))
				{
					return 0;
				}
				string text2 = array[array.Length - 2].Trim();
				if (text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text2.Substring(0, text2.Length - 1));
				}
				if (text2.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text2.Split('+', (StringSplitOptions)0)[0]);
				}
				return int.Parse(text2);
			}
			case AxisType.Column:
			{
				if (array[array.Length - 1].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoL()))
				{
					return 0;
				}
				string text = array[array.Length - 1].Trim();
				if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text.Substring(0, text.Length - 1));
				}
				if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text.Split('+', (StringSplitOptions)0)[0]);
				}
				return int.Parse(text);
			}
			default:
				return 0;
			}
		}

		private int a(AxisType P_0)
		{
			if (ayu == null)
			{
				return 0;
			}
			string[] array = ayu.Split(',', (StringSplitOptions)0);
			switch (P_0)
			{
			case AxisType.Slice:
			{
				if (array.Length < 3 || (array.Length == 3 && array[0].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoL())))
				{
					return 0;
				}
				string text3 = array[0].Trim();
				if (text3.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text3.Substring(0, text3.Length - 1));
				}
				if (text3.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text3.Split('+', (StringSplitOptions)0)[0]);
				}
				return int.Parse(text3);
			}
			case AxisType.Row:
			{
				if (array.Length < 2 || (array.Length >= 2 && array[array.Length - 2].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoL())))
				{
					return 0;
				}
				string text2 = array[array.Length - 2].Trim();
				if (text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text2.Substring(0, text2.Length - 1));
				}
				if (text2.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text2.Split('+', (StringSplitOptions)0)[0]);
				}
				return int.Parse(text2);
			}
			case AxisType.Column:
			{
				if (array[array.Length - 1].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoL()))
				{
					return 0;
				}
				string text = array[array.Length - 1].Trim();
				if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text.Substring(0, text.Length - 1));
				}
				if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text.Split('+', (StringSplitOptions)0)[0]);
				}
				return int.Parse(text);
			}
			default:
				return 0;
			}
		}

		private int B(AxisType P_0)
		{
			if (ayU == null)
			{
				return -1;
			}
			string[] array = ayU.Split(',', (StringSplitOptions)0);
			switch (P_0)
			{
			case AxisType.Slice:
			{
				if (array.Length < 3)
				{
					return 1;
				}
				if (array[0].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoL()))
				{
					return -1;
				}
				string text3 = array[0].Trim();
				if (text3.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return -1;
				}
				if (text3.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text3.Split('+', (StringSplitOptions)0)[1]);
				}
				return 1;
			}
			case AxisType.Row:
			{
				if (array.Length < 2)
				{
					return 1;
				}
				if (array[array.Length - 2].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoL()))
				{
					return -1;
				}
				string text2 = array[array.Length - 2].Trim();
				if (text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return -1;
				}
				if (text2.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text2.Split('+', (StringSplitOptions)0)[1]);
				}
				return 1;
			}
			case AxisType.Column:
			{
				if (array[array.Length - 1].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoL()))
				{
					return -1;
				}
				string text = array[array.Length - 1].Trim();
				if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return -1;
				}
				if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text.Split('+', (StringSplitOptions)0)[1]);
				}
				return 1;
			}
			default:
				return 0;
			}
		}

		private int b(AxisType P_0)
		{
			if (ayu == null)
			{
				return -1;
			}
			string[] array = ayu.Split(',', (StringSplitOptions)0);
			switch (P_0)
			{
			case AxisType.Slice:
			{
				if (array.Length < 3)
				{
					return 1;
				}
				if (array[0].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoL()))
				{
					return -1;
				}
				string text3 = array[0].Trim();
				if (text3.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return -1;
				}
				if (text3.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text3.Split('+', (StringSplitOptions)0)[1]);
				}
				return 1;
			}
			case AxisType.Row:
			{
				if (array.Length < 2)
				{
					return 1;
				}
				if (array[array.Length - 2].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoL()))
				{
					return -1;
				}
				string text2 = array[array.Length - 2].Trim();
				if (text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return -1;
				}
				if (text2.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text2.Split('+', (StringSplitOptions)0)[1]);
				}
				return 1;
			}
			case AxisType.Column:
			{
				if (array[array.Length - 1].Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoL()))
				{
					return -1;
				}
				string text = array[array.Length - 1].Trim();
				if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return -1;
				}
				if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aol()))
				{
					return int.Parse(text.Split('+', (StringSplitOptions)0)[1]);
				}
				return 1;
			}
			default:
				return 0;
			}
		}
	}
}
namespace c
{
	internal class cC
	{
		private const uint BEA = 4294967295u;

		private const int BEa = 1000;

		private const int BEB = 10;

		private const int BEb = 1000;

		private string BEC;

		private NamedPipeServerStream BEc;

		private Mutex BED = new Mutex();

		private bool BEd;

		internal bool A()
		{
			if (BEd && BEc != null)
			{
				return ((PipeStream)BEc).IsConnected;
			}
			return false;
		}

		internal cC(string P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			BEC = P_0;
		}

		virtual ~cC()
		{
			b();
		}

		internal void a()
		{
			B();
		}

		internal void B()
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			try
			{
				if (BEc != null)
				{
					((Stream)BEc).Close();
					BEc = null;
				}
				BEc = new NamedPipeServerStream(BEC, (PipeDirection)3, 1, (PipeTransmissionMode)0, (PipeOptions)1073741824);
				if (BEc != null && !((PipeStream)BEc).IsConnected)
				{
					BEc.WaitForConnectionAsync().Wait(1000);
					BEd = BEc != null && ((PipeStream)BEc).IsConnected;
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azH() + ex.Message, true);
			}
		}

		internal void b()
		{
			if (BEc != null)
			{
				try
				{
					if (((PipeStream)BEc).IsConnected)
					{
						((Stream)BEc).Flush();
					}
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azh() + ex.Message, true);
				}
				try
				{
					((Stream)BEc).Close();
				}
				catch (System.Exception ex2)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azh() + ex2.Message, true);
				}
			}
			BEc = null;
			BEd = false;
		}

		internal bool A(byte[] P_0, int P_1, int P_2, int P_3, bool P_4 = false)
		{
			int num = (P_4 ? 1000 : 10);
			bool result = false;
			try
			{
				if (((WaitHandle)BED).WaitOne(num))
				{
					if (BEc != null && ((PipeStream)BEc).IsConnected && P_0.Length != 0)
					{
						byte[] array = new byte[cb.BdW];
						array[0] = 1;
						array[1] = 0;
						array[2] = 0;
						array[3] = 0;
						byte[] bytes = BitConverter.GetBytes(P_3 + P_1);
						System.Array.Reverse<byte>(bytes);
						array[4] = (byte)(bytes[0] & 0xFFu);
						array[5] = (byte)(bytes[1] & 0xFFu);
						array[6] = (byte)(bytes[2] & 0xFFu);
						array[7] = (byte)(bytes[3] & 0xFFu);
						byte[] bytes2 = BitConverter.GetBytes(P_2);
						System.Array.Reverse<byte>(bytes2);
						array[8] = (byte)(bytes2[0] & 0xFFu);
						array[9] = (byte)(bytes2[1] & 0xFFu);
						array[10] = (byte)(bytes2[2] & 0xFFu);
						array[11] = (byte)(bytes2[3] & 0xFFu);
						System.Array.Copy((System.Array)P_0, P_1, (System.Array)array, 12, P_2);
						int num2 = 12 + P_2;
						byte[] bytes3 = BitConverter.GetBytes(new global::crc.crc().crc_process(array, 0u, (uint)num2, 4294967295u, partial: false));
						System.Array.Reverse<byte>(bytes3);
						array[num2++] = (byte)(bytes3[0] & 0xFFu);
						array[num2++] = (byte)(bytes3[1] & 0xFFu);
						array[num2++] = (byte)(bytes3[2] & 0xFFu);
						array[num2++] = (byte)(bytes3[3] & 0xFFu);
						((Stream)BEc).Write(array, 0, num2);
						((Stream)BEc).Flush();
						((PipeStream)BEc).WaitForPipeDrain();
						result = C();
					}
					BED.ReleaseMutex();
				}
			}
			catch (System.Exception ex)
			{
				BED.ReleaseMutex();
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azI() + ex.Message, true);
			}
			return result;
		}

		internal bool C()
		{
			bool flag = true;
			try
			{
				if (BEc != null && ((PipeStream)BEc).IsConnected)
				{
					byte[] array = new byte[16];
					System.Threading.Tasks.Task<int> task = ((Stream)BEc).ReadAsync(array, 0, 16);
					if (System.Threading.Tasks.Task.WhenAny((System.Threading.Tasks.Task)task, System.Threading.Tasks.Task.Delay(1000)).Result == task)
					{
						uint num = new global::crc.crc().crc_process(array, 0u, 12u, 4294967295u, partial: false);
						uint num2 = (uint)((array[12] << 24) | (array[13] << 16) | (array[14] << 8) | array[15]);
						flag = flag && num == num2;
						flag &= (array[0] & 0x80) == 0;
						if (num2 != num)
						{
							System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(34, 2);
							defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azi());
							defaultInterpolatedStringHandler.AppendFormatted<uint>(num2);
							defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azJ());
							defaultInterpolatedStringHandler.AppendFormatted<uint>(num);
							N.A(defaultInterpolatedStringHandler.ToStringAndClear(), true);
						}
					}
					else
					{
						int millisecond = System.DateTime.Now.Millisecond;
						((System.Threading.Tasks.Task)task).Wait();
						int num3 = System.DateTime.Now.Millisecond - millisecond;
						flag = false;
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azj() + num3, true);
					}
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azK() + ex.Message, true);
			}
			return flag;
		}

		internal bool c()
		{
			uint num = 3u;
			bool flag = false;
			while (num != 0)
			{
				byte[] array = new byte[2] { 0, 19 };
				flag = A(array, 0, array.Length, 0, true);
				if (flag)
				{
					break;
				}
				num--;
			}
			return flag;
		}

		internal bool D()
		{
			uint num = 3u;
			bool flag = false;
			byte b = 22;
			while (num != 0 && BEc != null && ((PipeStream)BEc).IsConnected)
			{
				byte[] array = new byte[2] { 0, b };
				flag = A(array, 0, array.Length, 0, true);
				if (flag)
				{
					break;
				}
				num--;
			}
			return flag;
		}

		internal bool d()
		{
			uint num = 3u;
			bool flag = false;
			byte b = 23;
			while (num != 0 && BEc != null && ((PipeStream)BEc).IsConnected)
			{
				byte[] array = new byte[2] { 0, b };
				flag = A(array, 0, array.Length, 0, true);
				if (flag)
				{
					break;
				}
				num--;
			}
			return flag;
		}
	}
	[CompilerGenerated]
	internal sealed class cc
	{
		[StructLayout(2, Pack = 2, Size = 4)]
		internal struct A
		{
		}

		[StructLayout(2, Pack = 1, Size = 5)]
		internal struct a
		{
		}

		[StructLayout(2, Pack = 1, Size = 7)]
		internal struct B
		{
		}

		[StructLayout(2, Pack = 1, Size = 10)]
		internal struct b
		{
		}

		[StructLayout(2, Pack = 1, Size = 12)]
		internal struct C
		{
		}

		[StructLayout(2, Pack = 1, Size = 16)]
		internal struct c
		{
		}

		[StructLayout(2, Pack = 1, Size = 18)]
		internal struct D
		{
		}

		[StructLayout(2, Pack = 1, Size = 20)]
		internal struct d
		{
		}

		[StructLayout(2, Pack = 2, Size = 28)]
		internal struct E
		{
		}

		[StructLayout(2, Pack = 1, Size = 40)]
		internal struct e
		{
		}

		[StructLayout(2, Pack = 1, Size = 48)]
		internal struct F
		{
		}

		[StructLayout(2, Pack = 1, Size = 68)]
		internal struct f
		{
		}

		[StructLayout(2, Pack = 1, Size = 200)]
		internal struct G
		{
		}

		[StructLayout(2, Pack = 1, Size = 4096)]
		internal struct g
		{
		}

		internal static readonly B BEE/* Not supported: data(48 41 4C 54 45 43 48) */;

		internal static readonly C BEe/* Not supported: data(01 00 00 00 01 00 00 00 01 00 00 00) */;

		internal static readonly b BEF/* Not supported: data(5C 00 3E 00 3C 00 7C 00 26 00) */;

		internal static readonly f BEf/* Not supported: data(00 00 C0 40 00 00 D0 40 00 00 E0 40 00 00 F0 40 00 00 00 41 00 00 08 41 00 00 10 41 00 00 18 41 00 00 20 41 00 00 30 41 00 00 40 41 00 00 50 41 00 00 60 41 00 00 70 41 00 00 80 41 00 00 88 41 00 00 90 41) */;

		internal static readonly g BEG/* Not supported: data(00 00 00 00 96 30 07 77 2C 61 0E EE BA 51 09 99 19 C4 6D 07 8F F4 6A 70 35 A5 63 E9 A3 95 64 9E 32 88 DB 0E A4 B8 DC 79 1E E9 D5 E0 88 D9 D2 97 2B 4C B6 09 BD 7C B1 7E 07 2D B8 E7 91 1D BF 90 64 10 B7 1D F2 20 B0 6A 48 71 B9 F3 DE 41 BE 84 7D D4 DA 1A EB E4 DD 6D 51 B5 D4 F4 C7 85 D3 83 56 98 6C 13 C0 A8 6B 64 7A F9 62 FD EC C9 65 8A 4F 5C 01 14 D9 6C 06 63 63 3D 0F FA F5 0D 08 8D C8 20 6E 3B 5E 10 69 4C E4 41 60 D5 72 71 67 A2 D1 E4 03 3C 47 D4 04 4B FD 85 0D D2 6B B5 0A A5 FA A8 B5 35 6C 98 B2 42 D6 C9 BB DB 40 F9 BC AC E3 6C D8 32 75 5C DF 45 CF 0D D6 DC 59 3D D1 AB AC 30 D9 26 3A 00 DE 51 80 51 D7 C8 16 61 D0 BF B5 F4 B4 21 23 C4 B3 56 99 95 BA CF 0F A5 BD B8 9E B8 02 28 08 88 05 5F B2 D9 0C C6 24 E9 0B B1 87 7C 6F 2F 11 4C 68 58 AB 1D 61 C1 3D 2D 66 B6 90 41 DC 76 06 71 DB 01 BC 20 D2 98 2A 10 D5 EF 89 85 B1 71 1F B5 B6 06 A5 E4 BF 9F 33 D4 B8 E8 A2 C9 07 78 34 F9 00 0F 8E A8 09 96 18 98 0E E1 BB 0D 6A 7F 2D 3D 6D 08 97 6C 64 91 01 5C 63 E6 F4 51 6B 6B 62 61 6C 1C D8 30 65 85 4E 00 62 F2 ED 95 06 6C 7B A5 01 1B C1 F4 08 82 57 C4 0F F5 C6 D9 B0 65 50 E9 B7 12 EA B8 BE 8B 7C 88 B9 FC DF 1D DD 62 49 2D DA 15 F3 7C D3 8C 65 4C D4 FB 58 61 B2 4D CE 51 B5 3A 74 00 BC A3 E2 30 BB D4 41 A5 DF 4A D7 95 D8 3D 6D C4 D1 A4 FB F4 D6 D3 6A E9 69 43 FC D9 6E 34 46 88 67 AD D0 B8 60 DA 73 2D 04 44 E5 1D 03 33 5F 4C 0A AA C9 7C 0D DD 3C 71 05 50 AA 41 02 27 10 10 0B BE 86 20 0C C9 25 B5 68 57 B3 85 6F 20 09 D4 66 B9 9F E4 61 CE 0E F9 DE 5E 98 C9 D9 29 22 98 D0 B0 B4 A8 D7 C7 17 3D B3 59 81 0D B4 2E 3B 5C BD B7 AD 6C BA C0 20 83 B8 ED B6 B3 BF 9A 0C E2 B6 03 9A D2 B1 74 39 47 D5 EA AF 77 D2 9D 15 26 DB 04 83 16 DC 73 12 0B 63 E3 84 3B 64 94 3E 6A 6D 0D A8 5A 6A 7A 0B CF 0E E4 9D FF 09 93 27 AE 00 0A B1 9E 07 7D 44 93 0F F0 D2 A3 08 87 68 F2 01 1E FE C2 06 69 5D 57 62 F7 CB 67 65 80 71 36 6C 19 E7 06 6B 6E 76 1B D4 FE E0 2B D3 89 5A 7A DA 10 CC 4A DD 67 6F DF B9 F9 F9 EF BE 8E 43 BE B7 17 D5 8E B0 60 E8 A3 D6 D6 7E 93 D1 A1 C4 C2 D8 38 52 F2 DF 4F F1 67 BB D1 67 57 BC A6 DD 06 B5 3F 4B 36 B2 48 DA 2B 0D D8 4C 1B 0A AF F6 4A 03 36 60 7A 04 41 C3 EF 60 DF 55 DF 67 A8 EF 8E 6E 31 79 BE 69 46 8C B3 61 CB 1A 83 66 BC A0 D2 6F 25 36 E2 68 52 95 77 0C CC 03 47 0B BB B9 16 02 22 2F 26 05 55 BE 3B BA C5 28 0B BD B2 92 5A B4 2B 04 6A B3 5C A7 FF D7 C2 31 CF D0 B5 8B 9E D9 2C 1D AE DE 5B B0 C2 64 9B 26 F2 63 EC 9C A3 6A 75 0A 93 6D 02 A9 06 09 9C 3F 36 0E EB 85 67 07 72 13 57 00 05 82 4A BF 95 14 7A B8 E2 AE 2B B1 7B 38 1B B6 0C 9B 8E D2 92 0D BE D5 E5 B7 EF DC 7C 21 DF DB 0B D4 D2 D3 86 42 E2 D4 F1 F8 B3 DD 68 6E 83 DA 1F CD 16 BE 81 5B 26 B9 F6 E1 77 B0 6F 77 47 B7 18 E6 5A 08 88 70 6A 0F FF CA 3B 06 66 5C 0B 01 11 FF 9E 65 8F 69 AE 62 F8 D3 FF 6B 61 45 CF 6C 16 78 E2 0A A0 EE D2 0D D7 54 83 04 4E C2 B3 03 39 61 26 67 A7 F7 16 60 D0 4D 47 69 49 DB 77 6E 3E 4A 6A D1 AE DC 5A D6 D9 66 0B DF 40 F0 3B D8 37 53 AE BC A9 C5 9E BB DE 7F CF B2 47 E9 FF B5 30 1C F2 BD BD 8A C2 BA CA 30 93 B3 53 A6 A3 B4 24 05 36 D0 BA 93 06 D7 CD 29 57 DE 54 BF 67 D9 23 2E 7A 66 B3 B8 4A 61 C4 02 1B 68 5D 94 2B 6F 2A 37 BE 0B B4 A1 8E 0C C3 1B DF 05 5A 8D EF 02 2D 00 00 00 00 41 31 1B 19 82 62 36 32 C3 53 2D 2B 04 C5 6C 64 45 F4 77 7D 86 A7 5A 56 C7 96 41 4F 08 8A D9 C8 49 BB C2 D1 8A E8 EF FA CB D9 F4 E3 0C 4F B5 AC 4D 7E AE B5 8E 2D 83 9E CF 1C 98 87 51 12 C2 4A 10 23 D9 53 D3 70 F4 78 92 41 EF 61 55 D7 AE 2E 14 E6 B5 37 D7 B5 98 1C 96 84 83 05 59 98 1B 82 18 A9 00 9B DB FA 2D B0 9A CB 36 A9 5D 5D 77 E6 1C 6C 6C FF DF 3F 41 D4 9E 0E 5A CD A2 24 84 95 E3 15 9F 8C 20 46 B2 A7 61 77 A9 BE A6 E1 E8 F1 E7 D0 F3 E8 24 83 DE C3 65 B2 C5 DA AA AE 5D 5D EB 9F 46 44 28 CC 6B 6F 69 FD 70 76 AE 6B 31 39 EF 5A 2A 20 2C 09 07 0B 6D 38 1C 12 F3 36 46 DF B2 07 5D C6 71 54 70 ED 30 65 6B F4 F7 F3 2A BB B6 C2 31 A2 75 91 1C 89 34 A0 07 90 FB BC 9F 17 BA 8D 84 0E 79 DE A9 25 38 EF B2 3C FF 79 F3 73 BE 48 E8 6A 7D 1B C5 41 3C 2A DE 58 05 4F 79 F0 44 7E 62 E9 87 2D 4F C2 C6 1C 54 DB 01 8A 15 94 40 BB 0E 8D 83 E8 23 A6 C2 D9 38 BF 0D C5 A0 38 4C F4 BB 21 8F A7 96 0A CE 96 8D 13 09 00 CC 5C 48 31 D7 45 8B 62 FA 6E CA 53 E1 77 54 5D BB BA 15 6C A0 A3 D6 3F 8D 88 97 0E 96 91 50 98 D7 DE 11 A9 CC C7 D2 FA E1 EC 93 CB FA F5 5C D7 62 72 1D E6 79 6B DE B5 54 40 9F 84 4F 59 58 12 0E 16 19 23 15 0F DA 70 38 24 9B 41 23 3D A7 6B FD 65 E6 5A E6 7C 25 09 CB 57 64 38 D0 4E A3 AE 91 01 E2 9F 8A 18 21 CC A7 33 60 FD BC 2A AF E1 24 AD EE D0 3F B4 2D 83 12 9F 6C B2 09 86 AB 24 48 C9 EA 15 53 D0 29 46 7E FB 68 77 65 E2 F6 79 3F 2F B7 48 24 36 74 1B 09 1D 35 2A 12 04 F2 BC 53 4B B3 8D 48 52 70 DE 65 79 31 EF 7E 60 FE F3 E6 E7 BF C2 FD FE 7C 91 D0 D5 3D A0 CB CC FA 36 8A 83 BB 07 91 9A 78 54 BC B1 39 65 A7 A8 4B 98 83 3B 0A A9 98 22 C9 FA B5 09 88 CB AE 10 4F 5D EF 5F 0E 6C F4 46 CD 3F D9 6D 8C 0E C2 74 43 12 5A F3 02 23 41 EA C1 70 6C C1 80 41 77 D8 47 D7 36 97 06 E6 2D 8E C5 B5 00 A5 84 84 1B BC 1A 8A 41 71 5B BB 5A 68 98 E8 77 43 D9 D9 6C 5A 1E 4F 2D 15 5F 7E 36 0C 9C 2D 1B 27 DD 1C 00 3E 12 00 98 B9 53 31 83 A0 90 62 AE 8B D1 53 B5 92 16 C5 F4 DD 57 F4 EF C4 94 A7 C2 EF D5 96 D9 F6 E9 BC 07 AE A8 8D 1C B7 6B DE 31 9C 2A EF 2A 85 ED 79 6B CA AC 48 70 D3 6F 1B 5D F8 2E 2A 46 E1 E1 36 DE 66 A0 07 C5 7F 63 54 E8 54 22 65 F3 4D E5 F3 B2 02 A4 C2 A9 1B 67 91 84 30 26 A0 9F 29 B8 AE C5 E4 F9 9F DE FD 3A CC F3 D6 7B FD E8 CF BC 6B A9 80 FD 5A B2 99 3E 09 9F B2 7F 38 84 AB B0 24 1C 2C F1 15 07 35 32 46 2A 1E 73 77 31 07 B4 E1 70 48 F5 D0 6B 51 36 83 46 7A 77 B2 5D 63 4E D7 FA CB 0F E6 E1 D2 CC B5 CC F9 8D 84 D7 E0 4A 12 96 AF 0B 23 8D B6 C8 70 A0 9D 89 41 BB 84 46 5D 23 03 07 6C 38 1A C4 3F 15 31 85 0E 0E 28 42 98 4F 67 03 A9 54 7E C0 FA 79 55 81 CB 62 4C 1F C5 38 81 5E F4 23 98 9D A7 0E B3 DC 96 15 AA 1B 00 54 E5 5A 31 4F FC 99 62 62 D7 D8 53 79 CE 17 4F E1 49 56 7E FA 50 95 2D D7 7B D4 1C CC 62 13 8A 8D 2D 52 BB 96 34 91 E8 BB 1F D0 D9 A0 06 EC F3 7E 5E AD C2 65 47 6E 91 48 6C 2F A0 53 75 E8 36 12 3A A9 07 09 23 6A 54 24 08 2B 65 3F 11 E4 79 A7 96 A5 48 BC 8F 66 1B 91 A4 27 2A 8A BD E0 BC CB F2 A1 8D D0 EB 62 DE FD C0 23 EF E6 D9 BD E1 BC 14 FC D0 A7 0D 3F 83 8A 26 7E B2 91 3F B9 24 D0 70 F8 15 CB 69 3B 46 E6 42 7A 77 FD 5B B5 6B 65 DC F4 5A 7E C5 37 09 53 EE 76 38 48 F7 B1 AE 09 B8 F0 9F 12 A1 33 CC 3F 8A 72 FD 24 93 00 00 00 00 37 6A C2 01 6E D4 84 03 59 BE 46 02 DC A8 09 07 EB C2 CB 06 B2 7C 8D 04 85 16 4F 05 B8 51 13 0E 8F 3B D1 0F D6 85 97 0D E1 EF 55 0C 64 F9 1A 09 53 93 D8 08 0A 2D 9E 0A 3D 47 5C 0B 70 A3 26 1C 47 C9 E4 1D 1E 77 A2 1F 29 1D 60 1E AC 0B 2F 1B 9B 61 ED 1A C2 DF AB 18 F5 B5 69 19 C8 F2 35 12 FF 98 F7 13 A6 26 B1 11 91 4C 73 10 14 5A 3C 15 23 30 FE 14 7A 8E B8 16 4D E4 7A 17 E0 46 4D 38 D7 2C 8F 39 8E 92 C9 3B B9 F8 0B 3A 3C EE 44 3F 0B 84 86 3E 52 3A C0 3C 65 50 02 3D 58 17 5E 36 6F 7D 9C 37 36 C3 DA 35 01 A9 18 34 84 BF 57 31 B3 D5 95 30 EA 6B D3 32 DD 01 11 33 90 E5 6B 24 A7 8F A9 25 FE 31 EF 27 C9 5B 2D 26 4C 4D 62 23 7B 27 A0 22 22 99 E6 20 15 F3 24 21 28 B4 78 2A 1F DE BA 2B 46 60 FC 29 71 0A 3E 28 F4 1C 71 2D C3 76 B3 2C 9A C8 F5 2E AD A2 37 2F C0 8D 9A 70 F7 E7 58 71 AE 59 1E 73 99 33 DC 72 1C 25 93 77 2B 4F 51 76 72 F1 17 74 45 9B D5 75 78 DC 89 7E 4F B6 4B 7F 16 08 0D 7D 21 62 CF 7C A4 74 80 79 93 1E 42 78 CA A0 04 7A FD CA C6 7B B0 2E BC 6C 87 44 7E 6D DE FA 38 6F E9 90 FA 6E 6C 86 B5 6B 5B EC 77 6A 02 52 31 68 35 38 F3 69 08 7F AF 62 3F 15 6D 63 66 AB 2B 61 51 C1 E9 60 D4 D7 A6 65 E3 BD 64 64 BA 03 22 66 8D 69 E0 67 20 CB D7 48 17 A1 15 49 4E 1F 53 4B 79 75 91 4A FC 63 DE 4F CB 09 1C 4E 92 B7 5A 4C A5 DD 98 4D 98 9A C4 46 AF F0 06 47 F6 4E 40 45 C1 24 82 44 44 32 CD 41 73 58 0F 40 2A E6 49 42 1D 8C 8B 43 50 68 F1 54 67 02 33 55 3E BC 75 57 09 D6 B7 56 8C C0 F8 53 BB AA 3A 52 E2 14 7C 50 D5 7E BE 51 E8 39 E2 5A DF 53 20 5B 86 ED 66 59 B1 87 A4 58 34 91 EB 5D 03 FB 29 5C 5A 45 6F 5E 6D 2F AD 5F 80 1B 35 E1 B7 71 F7 E0 EE CF B1 E2 D9 A5 73 E3 5C B3 3C E6 6B D9 FE E7 32 67 B8 E5 05 0D 7A E4 38 4A 26 EF 0F 20 E4 EE 56 9E A2 EC 61 F4 60 ED E4 E2 2F E8 D3 88 ED E9 8A 36 AB EB BD 5C 69 EA F0 B8 13 FD C7 D2 D1 FC 9E 6C 97 FE A9 06 55 FF 2C 10 1A FA 1B 7A D8 FB 42 C4 9E F9 75 AE 5C F8 48 E9 00 F3 7F 83 C2 F2 26 3D 84 F0 11 57 46 F1 94 41 09 F4 A3 2B CB F5 FA 95 8D F7 CD FF 4F F6 60 5D 78 D9 57 37 BA D8 0E 89 FC DA 39 E3 3E DB BC F5 71 DE 8B 9F B3 DF D2 21 F5 DD E5 4B 37 DC D8 0C 6B D7 EF 66 A9 D6 B6 D8 EF D4 81 B2 2D D5 04 A4 62 D0 33 CE A0 D1 6A 70 E6 D3 5D 1A 24 D2 10 FE 5E C5 27 94 9C C4 7E 2A DA C6 49 40 18 C7 CC 56 57 C2 FB 3C 95 C3 A2 82 D3 C1 95 E8 11 C0 A8 AF 4D CB 9F C5 8F CA C6 7B C9 C8 F1 11 0B C9 74 07 44 CC 43 6D 86 CD 1A D3 C0 CF 2D B9 02 CE 40 96 AF 91 77 FC 6D 90 2E 42 2B 92 19 28 E9 93 9C 3E A6 96 AB 54 64 97 F2 EA 22 95 C5 80 E0 94 F8 C7 BC 9F CF AD 7E 9E 96 13 38 9C A1 79 FA 9D 24 6F B5 98 13 05 77 99 4A BB 31 9B 7D D1 F3 9A 30 35 89 8D 07 5F 4B 8C 5E E1 0D 8E 69 8B CF 8F EC 9D 80 8A DB F7 42 8B 82 49 04 89 B5 23 C6 88 88 64 9A 83 BF 0E 58 82 E6 B0 1E 80 D1 DA DC 81 54 CC 93 84 63 A6 51 85 3A 18 17 87 0D 72 D5 86 A0 D0 E2 A9 97 BA 20 A8 CE 04 66 AA F9 6E A4 AB 7C 78 EB AE 4B 12 29 AF 12 AC 6F AD 25 C6 AD AC 18 81 F1 A7 2F EB 33 A6 76 55 75 A4 41 3F B7 A5 C4 29 F8 A0 F3 43 3A A1 AA FD 7C A3 9D 97 BE A2 D0 73 C4 B5 E7 19 06 B4 BE A7 40 B6 89 CD 82 B7 0C DB CD B2 3B B1 0F B3 62 0F 49 B1 55 65 8B B0 68 22 D7 BB 5F 48 15 BA 06 F6 53 B8 31 9C 91 B9 B4 8A DE BC 83 E0 1C BD DA 5E 5A BF ED 34 98 BE 00 00 00 00 65 67 BC B8 8B C8 09 AA EE AF B5 12 57 97 62 8F 32 F0 DE 37 DC 5F 6B 25 B9 38 D7 9D EF 28 B4 C5 8A 4F 08 7D 64 E0 BD 6F 01 87 01 D7 B8 BF D6 4A DD D8 6A F2 33 77 DF E0 56 10 63 58 9F 57 19 50 FA 30 A5 E8 14 9F 10 FA 71 F8 AC 42 C8 C0 7B DF AD A7 C7 67 43 08 72 75 26 6F CE CD 70 7F AD 95 15 18 11 2D FB B7 A4 3F 9E D0 18 87 27 E8 CF 1A 42 8F 73 A2 AC 20 C6 B0 C9 47 7A 08 3E AF 32 A0 5B C8 8E 18 B5 67 3B 0A D0 00 87 B2 69 38 50 2F 0C 5F EC 97 E2 F0 59 85 87 97 E5 3D D1 87 86 65 B4 E0 3A DD 5A 4F 8F CF 3F 28 33 77 86 10 E4 EA E3 77 58 52 0D D8 ED 40 68 BF 51 F8 A1 F8 2B F0 C4 9F 97 48 2A 30 22 5A 4F 57 9E E2 F6 6F 49 7F 93 08 F5 C7 7D A7 40 D5 18 C0 FC 6D 4E D0 9F 35 2B B7 23 8D C5 18 96 9F A0 7F 2A 27 19 47 FD BA 7C 20 41 02 92 8F F4 10 F7 E8 48 A8 3D 58 14 9B 58 3F A8 23 B6 90 1D 31 D3 F7 A1 89 6A CF 76 14 0F A8 CA AC E1 07 7F BE 84 60 C3 06 D2 70 A0 5E B7 17 1C E6 59 B8 A9 F4 3C DF 15 4C 85 E7 C2 D1 E0 80 7E 69 0E 2F CB 7B 6B 48 77 C3 A2 0F 0D CB C7 68 B1 73 29 C7 04 61 4C A0 B8 D9 F5 98 6F 44 90 FF D3 FC 7E 50 66 EE 1B 37 DA 56 4D 27 B9 0E 28 40 05 B6 C6 EF B0 A4 A3 88 0C 1C 1A B0 DB 81 7F D7 67 39 91 78 D2 2B F4 1F 6E 93 03 F7 26 3B 66 90 9A 83 88 3F 2F 91 ED 58 93 29 54 60 44 B4 31 07 F8 0C DF A8 4D 1E BA CF F1 A6 EC DF 92 FE 89 B8 2E 46 67 17 9B 54 02 70 27 EC BB 48 F0 71 DE 2F 4C C9 30 80 F9 DB 55 E7 45 63 9C A0 3F 6B F9 C7 83 D3 17 68 36 C1 72 0F 8A 79 CB 37 5D E4 AE 50 E1 5C 40 FF 54 4E 25 98 E8 F6 73 88 8B AE 16 EF 37 16 F8 40 82 04 9D 27 3E BC 24 1F E9 21 41 78 55 99 AF D7 E0 8B CA B0 5C 33 3B B6 59 ED 5E D1 E5 55 B0 7E 50 47 D5 19 EC FF 6C 21 3B 62 09 46 87 DA E7 E9 32 C8 82 8E 8E 70 D4 9E ED 28 B1 F9 51 90 5F 56 E4 82 3A 31 58 3A 83 09 8F A7 E6 6E 33 1F 08 C1 86 0D 6D A6 3A B5 A4 E1 40 BD C1 86 FC 05 2F 29 49 17 4A 4E F5 AF F3 76 22 32 96 11 9E 8A 78 BE 2B 98 1D D9 97 20 4B C9 F4 78 2E AE 48 C0 C0 01 FD D2 A5 66 41 6A 1C 5E 96 F7 79 39 2A 4F 97 96 9F 5D F2 F1 23 E5 05 19 6B 4D 60 7E D7 F5 8E D1 62 E7 EB B6 DE 5F 52 8E 09 C2 37 E9 B5 7A D9 46 00 68 BC 21 BC D0 EA 31 DF 88 8F 56 63 30 61 F9 D6 22 04 9E 6A 9A BD A6 BD 07 D8 C1 01 BF 36 6E B4 AD 53 09 08 15 9A 4E 72 1D FF 29 CE A5 11 86 7B B7 74 E1 C7 0F CD D9 10 92 A8 BE AC 2A 46 11 19 38 23 76 A5 80 75 66 C6 D8 10 01 7A 60 FE AE CF 72 9B C9 73 CA 22 F1 A4 57 47 96 18 EF A9 39 AD FD CC 5E 11 45 06 EE 4D 76 63 89 F1 CE 8D 26 44 DC E8 41 F8 64 51 79 2F F9 34 1E 93 41 DA B1 26 53 BF D6 9A EB E9 C6 F9 B3 8C A1 45 0B 62 0E F0 19 07 69 4C A1 BE 51 9B 3C DB 36 27 84 35 99 92 96 50 FE 2E 2E 99 B9 54 26 FC DE E8 9E 12 71 5D 8C 77 16 E1 34 CE 2E 36 A9 AB 49 8A 11 45 E6 3F 03 20 81 83 BB 76 91 E0 E3 13 F6 5C 5B FD 59 E9 49 98 3E 55 F1 21 06 82 6C 44 61 3E D4 AA CE 8B C6 CF A9 37 7E 38 41 7F D6 5D 26 C3 6E B3 89 76 7C D6 EE CA C4 6F D6 1D 59 0A B1 A1 E1 E4 1E 14 F3 81 79 A8 4B D7 69 CB 13 B2 0E 77 AB 5C A1 C2 B9 39 C6 7E 01 80 FE A9 9C E5 99 15 24 0B 36 A0 36 6E 51 1C 8E A7 16 66 86 C2 71 DA 3E 2C DE 6F 2C 49 B9 D3 94 F0 81 04 09 95 E6 B8 B1 7B 49 0D A3 1E 2E B1 1B 48 3E D2 43 2D 59 6E FB C3 F6 DB E9 A6 91 67 51 1F A9 B0 CC 7A CE 0C 74 94 61 B9 66 F1 06 05 DE) */;

		internal static readonly c BEg/* Not supported: data(5B 1E B8 01 DB 0C 37 46 53 B6 C7 F3 34 1E 07 07) */;

		internal static readonly d BEH/* Not supported: data(5B 00 5D 00 5E 00 24 00 2E 00 3F 00 2A 00 2B 00 28 00 29 00) */;

		internal static readonly c BEh/* Not supported: data(DD 05 00 00 DE 05 00 00 DF 05 00 00 D8 0E 00 00) */;

		internal static readonly c BEI/* Not supported: data(28 3E F8 4B D9 D9 8D 2C 96 89 4C 25 86 94 81 33) */;

		internal static readonly C BEi/* Not supported: data(96 00 00 00 FA 00 00 00 5E 01 00 00) */;

		internal static readonly c BEJ/* Not supported: data(47 96 64 35 6B 34 47 E5 4A 67 52 3C 56 52 47 41) */;

		internal static readonly e BEj/* Not supported: data(D0 00 00 00 F0 00 00 00 10 01 00 00 30 01 00 00 50 01 00 00 70 01 00 00 90 01 00 00 B0 01 00 00 D0 01 00 00 F0 01 00 00) */;

		internal static readonly c BEK/* Not supported: data(BF 3B A2 24 6C EC 12 AB C5 55 7E 9E A8 29 CE B3) */;

		internal static readonly F BEk/* Not supported: data(0D 03 00 00 0E 03 00 00 0F 03 00 00 10 03 00 00 F2 1D 00 00 02 1E 00 00 12 1E 00 00 22 1E 00 00 32 1E 00 00 42 1E 00 00 52 1E 00 00 62 1E 00 00) */;

		internal static readonly a BEL/* Not supported: data(48 45 50 53 00) */;

		internal static readonly D BEl/* Not supported: data(80 01 E0 00 52 1F E5 00 E4 00 E1 00 8D 01 19 19 75 09) */;

		internal static readonly c BEM/* Not supported: data(6B 00 00 00 6E 00 00 00 71 00 00 00 74 00 00 00) */;

		internal static readonly F BEm/* Not supported: data(24 08 00 00 28 08 00 00 47 08 00 00 4B 08 00 00 9A 1E 00 00 9B 1E 00 00 9C 1E 00 00 9D 1E 00 00 9E 1E 00 00 9F 1E 00 00 A0 1E 00 00 A1 1E 00 00) */;

		internal static readonly A BEN/* Not supported: data(20 00 2C 00) */;

		internal static readonly G BEn/* Not supported: data(FC A9 F1 D2 4D 62 50 3F FC A9 F1 D2 4D 62 60 3F 7B 14 AE 47 E1 7A 74 3F 7B 14 AE 47 E1 7A 84 3F 7B 14 AE 47 E1 7A 94 3F 9A 99 99 99 99 99 A9 3F 9A 99 99 99 99 99 B9 3F 9A 99 99 99 99 99 C9 3F 00 00 00 00 00 00 E0 3F 00 00 00 00 00 00 F0 3F 00 00 00 00 00 00 00 40 00 00 00 00 00 00 14 40 00 00 00 00 00 00 24 40 00 00 00 00 00 00 34 40 00 00 00 00 00 00 49 40 00 00 00 00 00 00 59 40 00 00 00 00 00 00 69 40 00 00 00 00 00 40 7F 40 00 00 00 00 00 40 8F 40 00 00 00 00 00 40 9F 40 00 00 00 00 00 88 B3 40 00 00 00 00 00 88 C3 40 00 00 00 00 00 88 D3 40 00 00 00 00 00 6A E8 40 00 00 00 00 00 6A F8 40) */;

		internal static readonly E BEO/* Not supported: data(20 00 2C 00 2D 00 2B 00 23 00 26 00 28 00 29 00 3C 00 3E 00 2F 00 3A 00 3B 00 7C 00) */;

		internal static readonly c BEo/* Not supported: data(6A 00 00 00 6D 00 00 00 70 00 00 00 73 00 00 00) */;

		internal static readonly d BEP/* Not supported: data(04 00 00 00 3E 10 00 00 3F 10 00 00 31 40 00 00 32 40 00 00) */;

		internal static readonly c BEp/* Not supported: data(8D D7 A0 0D D8 97 84 C3 16 D9 0F 0A 40 C1 89 E2) */;

		internal static readonly A BEQ/* Not supported: data(5C 00 2F 00) */;

		internal static readonly int BEq/* Not supported: data(FF AA CC DD) */;

		internal static readonly C BER/* Not supported: data(E8 03 00 00 DC 05 00 00 D0 07 00 00) */;

		internal static readonly c BEr/* Not supported: data(BC 00 00 00 BE 00 00 00 C0 00 00 00 C5 00 00 00) */;

		internal static readonly B BES/* Not supported: data(51 55 41 52 54 45 54) */;

		internal static readonly F BEs/* Not supported: data(E2 07 00 00 E3 07 00 00 EB 07 00 00 EC 07 00 00 F3 1D 00 00 03 1E 00 00 13 1E 00 00 23 1E 00 00 33 1E 00 00 43 1E 00 00 53 1E 00 00 63 1E 00 00) */;

		internal static System.ReadOnlySpan<a> A<A, a>(in A buffer, int P_1)
		{
			return MemoryMarshal.CreateReadOnlySpan<a>(ref System.Runtime.CompilerServices.Unsafe.As<A, a>(ref System.Runtime.CompilerServices.Unsafe.AsRef<A>(ref buffer)), P_1);
		}

		internal static ref a a<A, a>(ref A P_0, int P_1)
		{
			return ref System.Runtime.CompilerServices.Unsafe.Add<a>(ref System.Runtime.CompilerServices.Unsafe.As<A, a>(ref P_0), P_1);
		}
	}
}
