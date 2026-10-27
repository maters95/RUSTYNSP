using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using FTD2XX_NET;
using HaltechComms;

namespace c
{
	internal class cF : i, System.IDisposable
	{
		private enum A
		{
			Btn,
			BtO,
			Bto,
			BtP
		}

		private const int BfC = 50;

		private const uint Bfc = 65536u;

		private const byte BfD = 2;

		private FTDI Bfd = new FTDI();

		private FT_STATUS BfE = (FT_STATUS)2;

		private byte Bfe;

		private string BfF = string.Empty;

		private A Bff;

		private uint BfG = 4294967295u;

		private const uint Bfg = 10u;

		private uint BfH = 10u;

		private const uint Bfh = 5u;

		private uint[,] BfI = new uint[5, 2];

		private uint Bfi;

		private uint BfJ = 1000u;

		private uint Bfj = 50u;

		private bool BfK = true;

		private string Bfk;

		[CompilerGenerated]
		private EventHandler BfL;

		[CompilerGenerated]
		private EventHandler Bfl;

		[CompilerGenerated]
		private EventHandler BfM;

		[CompilerGenerated]
		private bool Bfm;

		public virtual string ToString()
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azl() + Bfk;
		}

		public bool A(List<string> P_0)
		{
			return A(P_0, null);
		}

		private bool A(List<string> P_0, string P_1)
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Invalid comparison between Unknown and I4
			//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_0517: Unknown result type (might be due to invalid IL or missing references)
			//IL_051c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0529: Unknown result type (might be due to invalid IL or missing references)
			//IL_052e: Unknown result type (might be due to invalid IL or missing references)
			//IL_053f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0544: Unknown result type (might be due to invalid IL or missing references)
			//IL_0557: Unknown result type (might be due to invalid IL or missing references)
			//IL_055c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_0306: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0321: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0363: Unknown result type (might be due to invalid IL or missing references)
			//IL_0374: Unknown result type (might be due to invalid IL or missing references)
			//IL_0379: Unknown result type (might be due to invalid IL or missing references)
			//IL_038c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0391: Unknown result type (might be due to invalid IL or missing references)
			if (P_0 == null)
			{
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azM());
			}
			else
			{
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azm());
			}
			uint num = 0u;
			int num2 = 5;
			do
			{
				BfE = Bfd.GetNumberOfDevices(ref num);
				if ((int)BfE == 0)
				{
					break;
				}
				num2--;
				Thread.Sleep(100);
			}
			while (num2 > 0);
			FT_DEVICE_INFO_NODE[] array = null;
			if (num != 0)
			{
				num2 = 5;
				bool flag;
				do
				{
					try
					{
						array = (FT_DEVICE_INFO_NODE[])(object)new FT_DEVICE_INFO_NODE[num];
						BfE = Bfd.GetDeviceList(array);
						flag = (int)BfE == 0;
					}
					catch
					{
						BfE = Bfd.GetNumberOfDevices(ref num);
						flag = false;
					}
					if (!flag)
					{
						num2--;
						Thread.Sleep(100);
					}
				}
				while (num2 > 0 && !flag);
				for (uint num3 = 0u; num3 < array.Length; num3++)
				{
					if (array[num3] == null)
					{
						continue;
					}
					if (array[num3].ID == 382734023 && array[num3].SerialNumber.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mP()))
					{
						Bff = cF.A.BtO;
						string text = array[num3].SerialNumber.Remove(array[num3].SerialNumber.Length - 1);
						if (!string.IsNullOrEmpty(P_1) && P_1.Remove(P_1.Length - 1) != text)
						{
							continue;
						}
						uint num4 = 0u;
						uint num5;
						for (num5 = 0u; num5 < array.Length; num5++)
						{
							if (array[num5].ID == 382734023 && text.Equals(array[num5].SerialNumber.Remove(array[num5].SerialNumber.Length - 1)))
							{
								num4++;
								if ((array[num5].Flags & 1) == 1)
								{
									break;
								}
							}
						}
						if (num5 < array.Length)
						{
							continue;
						}
						switch (num4)
						{
						case 0u:
						case 1u:
							global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azN());
							break;
						default:
							global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azn());
							break;
						case 2u:
						{
							Bfk = string.Concat(new string[5]
							{
								text,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax(),
								array[num3].ID.ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax(),
								array[num3].LocId.ToString()
							});
							if (P_0 != null && P_0.Contains(Bfk))
							{
								continue;
							}
							if (Bfd.IsOpen)
							{
								BfE = j();
							}
							if ((int)BfE != 0 && Bfd.IsOpen)
							{
								global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azO());
								break;
							}
							string text2 = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mP();
							string text3 = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vc();
							BfE = Bfd.OpenBySerialNumber(text2);
							if (!Bfd.IsOpen || (int)BfE != 0)
							{
								continue;
							}
							BfF = text2;
							Bfe = 0;
							BfE = Bfd.SetBitMode((byte)255, Bfe);
							BfE = j();
							if ((int)BfE != 0 && Bfd.IsOpen)
							{
								global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azO());
								break;
							}
							BfE = Bfd.OpenBySerialNumber(text3);
							if (!Bfd.IsOpen || (int)BfE != 0)
							{
								continue;
							}
							BfF = text3;
							Bfe = 0;
							BfE = Bfd.SetBitMode((byte)255, Bfe);
							BfE = Bfd.SetLatency((byte)2);
							BfE = Bfd.InTransferSize(65536u);
							BfE = Bfd.SetFlowControl((ushort)256, (byte)0, (byte)0);
							C();
							A(0);
							global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azo());
							return true;
						}
						}
						break;
					}
					bool flag2 = array[num3].ID == 382734086;
					bool flag3 = array[num3].ID == 67330068 && array[num3].Description.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azP());
					if (!(flag2 || flag3))
					{
						continue;
					}
					if (flag2)
					{
						Bff = cF.A.Bto;
					}
					else if (flag3)
					{
						Bff = cF.A.BtP;
					}
					if (!string.IsNullOrEmpty(P_1) && P_1 != array[num3].SerialNumber)
					{
						continue;
					}
					BfF = array[num3].SerialNumber;
					Bfk = string.Concat(new string[5]
					{
						BfF,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax(),
						array[num3].ID.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax(),
						array[num3].LocId.ToString()
					});
					if (P_0 == null || !P_0.Contains(Bfk))
					{
						if (Bfd.IsOpen)
						{
							BfE = j();
						}
						if ((int)BfE != 0 && Bfd.IsOpen)
						{
							global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azO());
							break;
						}
						BfE = Bfd.OpenByIndex(num3);
						if (Bfd.IsOpen && (int)BfE == 0)
						{
							Bfe = 0;
							BfE = Bfd.SetBitMode((byte)255, Bfe);
							BfE = Bfd.SetLatency((byte)2);
							BfE = Bfd.InTransferSize(65536u);
							BfE = Bfd.SetFlowControl((ushort)256, (byte)0, (byte)0);
							C();
							A(0);
							global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azo());
							return true;
						}
					}
				}
			}
			else if (P_0 == null && P_1 != null)
			{
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azp());
			}
			if (P_0 == null && P_1 != null)
			{
				string text4 = string.Empty;
				try
				{
					if (array != null && array.Length != 0)
					{
						for (uint num6 = 0u; num6 < array.Length; num6++)
						{
							text4 = ((array[num6] == null) ? (text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azQ() + num6 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azS()) : string.Concat(new string[9]
							{
								text4,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azQ(),
								num6.ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azq(),
								array[num6].Description,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azR(),
								array[num6].Flags.ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azr(),
								array[num6].SerialNumber
							}));
						}
					}
				}
				catch
				{
				}
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azs() + Bfd.IsOpen + text4);
			}
			return false;
		}

		public void A()
		{
		}

		public bool A(F P_0)
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			if (Bff == cF.A.BtO)
			{
				if (P_0.aj == 0)
				{
					int num = 5;
					do
					{
						if (Bfd.IsOpen)
						{
							BfE = j();
						}
						if ((int)BfE != 0 && Bfd.IsOpen)
						{
							global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azT());
							return false;
						}
						string text = BfF.Remove(BfF.Length - 1) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mP();
						BfE = Bfd.OpenBySerialNumber(text);
						if (Bfd.IsOpen && (int)BfE == 0)
						{
							BfF = text;
							Bfe = 64;
							BfE = Bfd.SetBitMode((byte)255, Bfe);
							BfE = Bfd.SetLatency((byte)2);
							BfE = Bfd.InTransferSize(65536u);
							BfE = Bfd.SetFlowControl((ushort)256, (byte)0, (byte)0);
							C();
							A(0);
							break;
						}
						num--;
					}
					while (num > 0);
					if (num == 0)
					{
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azt() + ((object)(FT_STATUS)(ref BfE)).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azU());
						return false;
					}
				}
			}
			else if (Bff != cF.A.Bto)
			{
				_ = Bff;
				_ = 3;
			}
			global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azu());
			return true;
		}

		public bool a()
		{
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			if (Bfd.IsOpen && !B())
			{
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azV());
				return false;
			}
			int num = 5;
			do
			{
				if (A(null, BfF))
				{
					return true;
				}
				num--;
				if (Bfd.IsOpen)
				{
					BfE = j();
				}
				if ((int)BfE != 0 && Bfd.IsOpen)
				{
					global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azV());
					break;
				}
			}
			while (num > 0);
			global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azv());
			return false;
		}

		private void A(int P_0 = 0)
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			if (P_0 > 0)
			{
				Thread.Sleep(P_0);
			}
			if (Bfd.IsOpen)
			{
				BfE = Bfd.Purge(3u);
			}
		}

		public void e()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			Thread.Sleep(5);
			while (J())
			{
				uint num = 0u;
				BfE = Bfd.Read(new byte[65536], 65536u, ref num);
				if (num == 0)
				{
					break;
				}
				Thread.Sleep(5);
			}
			A(0);
		}

		public bool F()
		{
			return BfK;
		}

		public bool f()
		{
			return false;
		}

		public void G()
		{
			BfG = 4294967295u;
			BfH = 10u;
			for (int i = 0; (long)i < 5L; i++)
			{
				BfI[i, 0] = 10u;
				BfI[i, 1] = 0u;
			}
			BfJ = 1000u;
			if (!BfK)
			{
				BfK = true;
				if (BfM != null)
				{
					BfM.Invoke((object)this, EventArgs.Empty);
				}
			}
		}

		public void g()
		{
			BfG = 512u;
			BfH = 0u;
			for (int i = 0; (long)i < 5L; i++)
			{
				BfI[i, 0] = 0u;
				BfI[i, 1] = 0u;
			}
			BfJ = 0u;
			if (BfK)
			{
				BfK = false;
				if (Bfl != null)
				{
					Bfl.Invoke((object)this, EventArgs.Empty);
				}
			}
		}

		public void A(int P_0, int P_1)
		{
			BfI[Bfi, 0] = (uint)P_0;
			BfI[Bfi, 1] = (uint)P_1;
			Bfi = (Bfi + 1) % 5;
			uint num = 0u;
			uint num2 = 0u;
			for (int i = 0; (long)i < 5L; i++)
			{
				num += BfI[i, 0];
				num2 += BfI[i, 1];
			}
			if (num != 0)
			{
				uint num3 = 0u;
				if (num2 <= num)
				{
					num3 = num - num2;
				}
				BfJ = num3 * 1000 / num;
			}
			else
			{
				BfJ = 1000u;
			}
			if (BfJ == 1000)
			{
				BfH++;
				if (BfH >= 10 && BfG != 4294967295u)
				{
					if (BfG >= 8192)
					{
						BfG = 4294967295u;
					}
					else if (BfG == 1008)
					{
						BfG = 2048u;
					}
					else
					{
						BfG *= 2u;
					}
				}
			}
			else
			{
				BfH = 0u;
			}
		}

		public void a(bool P_0)
		{
			if (!P_0 && BfG != 512)
			{
				if (BfG == 4294967295u)
				{
					BfG = 8192u;
				}
				else if (BfG > 2048)
				{
					BfG /= 2u;
				}
				else
				{
					BfG = 1008u;
				}
			}
		}

		public void A(ref uint P_0)
		{
		}

		public uint E()
		{
			return BfG;
		}

		public uint H()
		{
			return BfJ;
		}

		public uint[,] h()
		{
			return BfI;
		}

		public uint I()
		{
			return Bfi;
		}

		public uint i()
		{
			return BfH;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BfL;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BfL, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void a(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BfL;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BfL, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void B(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = Bfl;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref Bfl, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void b(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = Bfl;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref Bfl, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void C(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BfM;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BfM, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void c(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BfM;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BfM, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		public string b()
		{
			return Bfk;
		}

		public void A(uint P_0)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			Bfj = P_0;
			BfE = Bfd.SetTimeouts(Bfj, Bfj);
		}

		public void C()
		{
			A(50u);
		}

		[SpecialName]
		[CompilerGenerated]
		public bool c()
		{
			return Bfm;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(bool P_0)
		{
			Bfm = P_0;
		}

		private bool J()
		{
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			bool flag = false;
			if (Bfd.IsOpen)
			{
				flag = true;
			}
			else if (!string.IsNullOrEmpty(BfF))
			{
				int num = 5;
				do
				{
					try
					{
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azW() + BfF);
						BfE = Bfd.OpenBySerialNumber(BfF);
						if (Bfd.IsOpen && (int)BfE == 0)
						{
							flag = true;
							BfE = Bfd.SetBitMode((byte)255, Bfe);
							BfE = Bfd.SetLatency((byte)2);
							BfE = Bfd.InTransferSize(65536u);
							BfE = Bfd.SetFlowControl((ushort)256, (byte)0, (byte)0);
							A(Bfj);
						}
					}
					catch
					{
						flag = false;
					}
					if (!flag)
					{
						Thread.Sleep(100);
						num--;
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azw() + num + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aa());
					}
				}
				while (num != 0 && !flag);
				if (flag)
				{
					global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azX() + num + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aa());
				}
			}
			else
			{
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azx());
			}
			if (!flag)
			{
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azY());
			}
			return flag;
		}

		public bool A(byte[] P_0, uint P_1, out uint P_2)
		{
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			if (!J())
			{
				if (BfL != null)
				{
					BfL.Invoke((object)this, EventArgs.Empty);
				}
				P_2 = 0u;
				return false;
			}
			uint num = (P_1 - 1) / 65536 + 1;
			uint num2 = 0u;
			uint num3 = P_1;
			P_2 = 0u;
			for (uint num4 = 0u; num4 < num; num4++)
			{
				uint num5 = ((num3 <= 65536) ? num3 : 65536u);
				byte[] array;
				if (P_1 <= 65536)
				{
					array = P_0;
				}
				else
				{
					array = new byte[num5];
					System.Array.Copy((System.Array)P_0, (long)num2, (System.Array)array, 0L, (long)num5);
				}
				uint num6 = 0u;
				int num7 = 5;
				FT_STATUS bfE;
				do
				{
					BfE = Bfd.Write(array, num5, ref num6);
					bfE = BfE;
					if ((int)bfE != 0 && num6 == 0)
					{
						num7--;
						if (num7 != 0)
						{
							A(80);
						}
					}
				}
				while ((int)bfE != 0 && num6 == 0 && num7 != 0);
				if (num6 == 0)
				{
					A(0);
					if ((int)bfE != 0)
					{
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azy() + ((object)(FT_STATUS)(ref bfE)).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azZ());
						if (BfL != null)
						{
							BfL.Invoke((object)this, EventArgs.Empty);
						}
					}
					else if (!c() && BfK)
					{
						BfK = false;
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azz());
						if (Bfl != null)
						{
							Bfl.Invoke((object)this, EventArgs.Empty);
						}
					}
					return false;
				}
				num2 += num6;
				num3 -= num6;
			}
			P_2 = num2;
			return true;
		}

		public bool A(ref byte[] P_0, out uint P_1)
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			if (!J())
			{
				if (BfL != null)
				{
					BfL.Invoke((object)this, EventArgs.Empty);
				}
				P_1 = 0u;
				return false;
			}
			uint num = 0u;
			uint num2 = 0u;
			bool flag = false;
			Stopwatch val = new Stopwatch();
			val.Start();
			do
			{
				BfE = Bfd.GetRxBytesAvailable(ref num);
				flag = num != 0 && num == num2;
				num2 = num;
				if (num == 0)
				{
					Thread.Sleep(0);
				}
				else if (!flag)
				{
					Thread.Sleep(20);
				}
			}
			while (val.ElapsedMilliseconds < Bfj && !flag);
			val.Stop();
			P_1 = 0u;
			if (num != 0 && num <= P_0.Length)
			{
				return A(ref P_0, num, out P_1, 0);
			}
			return false;
		}

		public bool A(ref byte[] P_0, uint P_1, out uint P_2, byte P_3)
		{
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			if (!J())
			{
				if (BfL != null)
				{
					BfL.Invoke((object)this, EventArgs.Empty);
				}
				P_2 = 0u;
				return false;
			}
			uint num = (P_1 - 1) / 65536 + 1;
			uint num2 = 0u;
			uint num3 = P_1;
			P_2 = 0u;
			for (uint num4 = 0u; num4 < num; num4++)
			{
				uint num5 = ((num3 <= 65536) ? num3 : 65536u);
				byte[] array = ((P_1 > 65536) ? new byte[num5] : P_0);
				uint num6 = 0u;
				int num7 = 5;
				FT_STATUS bfE;
				do
				{
					BfE = Bfd.Read(array, num5, ref num6);
					bfE = BfE;
					if ((int)bfE != 0 && num6 == 0)
					{
						num7--;
						if (num7 != 0)
						{
							A(80);
						}
					}
				}
				while ((int)bfE != 0 && num6 == 0 && num7 != 0);
				if (num6 == 0)
				{
					A(0);
					if ((int)bfE != 0)
					{
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAA() + ((object)(FT_STATUS)(ref bfE)).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.azZ());
						if (BfL != null)
						{
							BfL.Invoke((object)this, EventArgs.Empty);
						}
					}
					else if (!c() && BfK)
					{
						BfK = false;
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAa());
						if (Bfl != null)
						{
							Bfl.Invoke((object)this, EventArgs.Empty);
						}
					}
					return false;
				}
				if (!BfK)
				{
					BfK = true;
					global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAB());
					if (BfM != null)
					{
						BfM.Invoke((object)this, EventArgs.Empty);
					}
				}
				if ((long)P_0.Length > 65536L)
				{
					System.Array.Copy((System.Array)array, 0L, (System.Array)P_0, (long)num2, (long)num6);
				}
				num2 += num6;
				num3 -= num6;
			}
			P_2 = num2;
			return true;
		}

		public uint D()
		{
			return 65536u;
		}

		public bool d()
		{
			return true;
		}

		private FT_STATUS j()
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			int num = 2;
			do
			{
				try
				{
					if (Bfd.IsOpen)
					{
						return Bfd.Close();
					}
					return (FT_STATUS)0;
				}
				catch
				{
					Thread.Sleep(20);
					num--;
				}
			}
			while (num != 0);
			return (FT_STATUS)17;
		}

		public bool B()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			return (int)j() == 0;
		}

		public void Dispose()
		{
			B();
		}
	}
	internal class cf : i, System.IDisposable
	{
		private SerialPort BGm;

		private const int BGN = 200;

		private uint BGn = 200u;

		private const int BGO = 30;

		private int BGo;

		private bool BGP = true;

		private string BGp;

		[CompilerGenerated]
		private EventHandler BGQ;

		[CompilerGenerated]
		private EventHandler BGq;

		[CompilerGenerated]
		private EventHandler BGR;

		[CompilerGenerated]
		private bool BGr;

		public virtual string ToString()
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAb() + BGp;
		}

		private bool A(string P_0)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			try
			{
				BGm = new SerialPort(P_0);
				if (BGm != null)
				{
					A(BGn);
					BGm.ReadBufferSize = 32768;
					BGm.WriteBufferSize = 32768;
					BGm.Open();
					return true;
				}
				return false;
			}
			catch
			{
				BGm = null;
				return false;
			}
		}

		public bool A(List<string> P_0)
		{
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			string[] array = J();
			try
			{
				List<string> val = new List<string>((System.Collections.Generic.IEnumerable<string>)SerialPort.GetPortNames());
				List<string> val2;
				Enumerator<string> enumerator;
				if (array != null && array.Length != 0)
				{
					val2 = new List<string>();
					string[] array2 = array;
					foreach (string text in array2)
					{
						if (val.Contains(text))
						{
							val2.Add(text);
						}
					}
					enumerator = val.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							if (!val2.Contains(current))
							{
								val2.Add(current);
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				else
				{
					val2 = val;
				}
				List<Win32DeviceMgmt.DeviceInfo> deviceInfoPerCOMPort = Win32DeviceMgmt.GetDeviceInfoPerCOMPort();
				enumerator = val2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string current2 = enumerator.Current;
						Enumerator<Win32DeviceMgmt.DeviceInfo> enumerator2 = deviceInfoPerCOMPort.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								Win32DeviceMgmt.DeviceInfo current3 = enumerator2.Current;
								if (current3.Name == current2)
								{
									if ((current3.BusDescription.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HC()) || current3.Description.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HC())) && current3.BusDescription.ToUpper() != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAC())
									{
										BGp = current2;
										if ((P_0 == null || !P_0.Contains(BGp)) && A(BGp))
										{
											return true;
										}
										break;
									}
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator2).Dispose();
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				return false;
			}
			catch
			{
				return false;
			}
		}

		public void A()
		{
			K();
		}

		public bool A(F P_0)
		{
			j();
			return true;
		}

		private string[] J()
		{
			string[] result = null;
			try
			{
				string folderPath = Environment.GetFolderPath((SpecialFolder)26);
				if (!Directory.Exists(folderPath + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
				{
					Directory.CreateDirectory(folderPath + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
				}
				else
				{
					string text = folderPath + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAc();
					if (File.Exists(text))
					{
						result = File.ReadAllLines(text);
					}
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		private void j()
		{
			try
			{
				string folderPath = Environment.GetFolderPath((SpecialFolder)26);
				if (!Directory.Exists(folderPath + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
				{
					Directory.CreateDirectory(folderPath + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
				}
				string text = folderPath + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAc();
				if (File.Exists(text))
				{
					if (!new List<string>((System.Collections.Generic.IEnumerable<string>)File.ReadAllLines(text)).Contains(BGp))
					{
						string[] array = new string[1] { BGp };
						File.AppendAllLines(text, (System.Collections.Generic.IEnumerable<string>)array);
					}
				}
				else
				{
					string[] array2 = new string[1] { BGp };
					File.WriteAllLines(text, array2);
				}
			}
			catch
			{
			}
		}

		private void K()
		{
			try
			{
				string text = Environment.GetFolderPath((SpecialFolder)26) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAc();
				if (File.Exists(text))
				{
					List<string> val = new List<string>((System.Collections.Generic.IEnumerable<string>)File.ReadAllLines(text));
					if (val.Contains(BGp))
					{
						val.Remove(BGp);
						File.WriteAllLines(text, (System.Collections.Generic.IEnumerable<string>)val);
					}
				}
			}
			catch
			{
			}
		}

		public bool a()
		{
			if (BGm != null)
			{
				if (B())
				{
					((Component)BGm).Dispose();
					return A(BGp);
				}
				return false;
			}
			return A(BGp);
		}

		private void A(int P_0 = 0)
		{
			if (P_0 > 0)
			{
				Thread.Sleep(P_0);
			}
			if (BGm != null && BGm.IsOpen)
			{
				try
				{
					BGm.DiscardInBuffer();
					BGm.DiscardOutBuffer();
				}
				catch
				{
				}
			}
		}

		public void e()
		{
			if (BGm == null)
			{
				return;
			}
			Thread.Sleep(5);
			try
			{
				while (k())
				{
					int num;
					try
					{
						num = BGm.Read(new byte[1024], 0, 1024);
					}
					catch
					{
						num = 0;
					}
					if (num != 0)
					{
						Thread.Sleep(5);
						continue;
					}
					break;
				}
			}
			catch
			{
			}
			A(0);
		}

		public bool F()
		{
			return BGP;
		}

		public bool f()
		{
			return false;
		}

		public void G()
		{
			if (!BGP)
			{
				BGP = true;
				if (BGR != null)
				{
					BGR.Invoke((object)this, EventArgs.Empty);
				}
			}
		}

		public void g()
		{
			if (BGP)
			{
				BGP = false;
				if (BGq != null)
				{
					BGq.Invoke((object)this, EventArgs.Empty);
				}
			}
		}

		public void A(int P_0, int P_1)
		{
		}

		public uint H()
		{
			return 1000u;
		}

		public uint[,] h()
		{
			return null;
		}

		public uint I()
		{
			return 0u;
		}

		public uint i()
		{
			return 0u;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BGQ;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BGQ, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void a(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BGQ;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BGQ, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void B(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BGq;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BGq, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void b(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BGq;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BGq, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void C(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BGR;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BGR, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		public void c(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BGR;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BGR, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		public string b()
		{
			return BGp;
		}

		public void A(uint P_0)
		{
			BGn = P_0;
			if (BGm != null)
			{
				try
				{
					BGm.ReadTimeout = (int)BGn;
					BGm.WriteTimeout = (int)BGn;
				}
				catch
				{
				}
			}
		}

		public void C()
		{
			A(200u);
		}

		[SpecialName]
		[CompilerGenerated]
		public bool c()
		{
			return BGr;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(bool P_0)
		{
			BGr = P_0;
		}

		private bool k()
		{
			bool flag = false;
			if (BGm != null)
			{
				if (BGm.IsOpen)
				{
					flag = true;
				}
				else
				{
					try
					{
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAD());
						BGm.Open();
						flag = BGm.IsOpen;
					}
					catch
					{
						flag = false;
					}
				}
			}
			if (!flag)
			{
				global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAd());
			}
			return flag;
		}

		public bool A(byte[] P_0, uint P_1, out uint P_2)
		{
			if (!k())
			{
				if (!c() && BGQ != null)
				{
					BGQ.Invoke((object)this, EventArgs.Empty);
				}
				P_2 = 0u;
				return false;
			}
			try
			{
				BGm.Write(P_0, 0, (int)P_1);
				P_2 = P_1;
				return true;
			}
			catch (System.Exception ex)
			{
				if (ex is TimeoutException)
				{
					BGo++;
				}
				A(0);
				if (!c())
				{
					if (BGm == null || !BGm.IsOpen || !Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)SerialPort.GetPortNames(), BGm.PortName))
					{
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAE());
						if (BGQ != null)
						{
							BGQ.Invoke((object)this, EventArgs.Empty);
						}
					}
					else if (BGo > 30 && BGP)
					{
						BGP = false;
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAe());
						if (BGq != null)
						{
							BGq.Invoke((object)this, EventArgs.Empty);
						}
					}
				}
				P_2 = 0u;
				return false;
			}
		}

		public bool A(ref byte[] P_0, uint P_1, out uint P_2, byte P_3)
		{
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			if (!k())
			{
				if (!c() && BGQ != null)
				{
					BGQ.Invoke((object)this, EventArgs.Empty);
				}
				P_2 = 0u;
				return false;
			}
			try
			{
				int num = 0;
				int num2 = 0;
				bool flag = false;
				Stopwatch val = new Stopwatch();
				val.Start();
				do
				{
					if (BGm != null)
					{
						num = BGm.BytesToRead;
					}
					flag = num != 0 && (num == num2 || num >= P_1);
					num2 = num;
					if (num == 0)
					{
						Thread.Sleep(0);
					}
					else if (!flag)
					{
						Thread.Sleep(20);
					}
				}
				while (val.ElapsedMilliseconds < BGn && !flag);
				val.Stop();
				if (num < P_1)
				{
					throw new TimeoutException(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAF());
				}
				P_2 = (uint)BGm.Read(P_0, 0, (int)P_1);
				BGo = 0;
				if (!BGP)
				{
					BGP = true;
					global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAf());
					if (BGR != null)
					{
						BGR.Invoke((object)this, EventArgs.Empty);
					}
				}
				return true;
			}
			catch (System.Exception ex)
			{
				if (ex is TimeoutException)
				{
					BGo++;
				}
				A(0);
				if (!c())
				{
					if (BGm == null || !BGm.IsOpen || !Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)SerialPort.GetPortNames(), BGm.PortName))
					{
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAG());
						if (BGQ != null)
						{
							BGQ.Invoke((object)this, EventArgs.Empty);
						}
					}
					else if (BGo > 30 && BGP)
					{
						BGP = false;
						global::A.A.k(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAg());
						if (BGq != null)
						{
							BGq.Invoke((object)this, EventArgs.Empty);
						}
					}
				}
				P_2 = 0u;
				return false;
			}
		}

		public uint D()
		{
			return 4294967295u;
		}

		public bool d()
		{
			return true;
		}

		public void a(bool P_0)
		{
		}

		public void A(ref uint P_0)
		{
		}

		public uint E()
		{
			return 4294967295u;
		}

		public bool B()
		{
			try
			{
				if (BGm.IsOpen)
				{
					BGm.Close();
					while (BGm.IsOpen)
					{
						Thread.Sleep(50);
					}
				}
				return !BGm.IsOpen;
			}
			catch
			{
				return false;
			}
		}

		public void Dispose()
		{
			if (BGm != null)
			{
				try
				{
					B();
					((Component)BGm).Dispose();
				}
				catch
				{
				}
				BGm = null;
			}
		}
	}
}
namespace C
{
	internal enum CF
	{
		azS,
		azs
	}
	internal enum Cf
	{
		azT,
		azt,
		azU,
		azu
	}
}
