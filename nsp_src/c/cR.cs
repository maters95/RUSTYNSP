using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
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
	internal class cR : aq
	{
		private delegate ci A();

		internal const int BlG = 800;

		internal const int Blg = 600;

		internal const int BlH = 500;

		internal const int Blh = 300;

		internal const int BlI = 300;

		internal const int Bli = 200;

		internal const int BlJ = 300;

		internal const int Blj = 200;

		internal const int BlK = 120;

		internal const int Blk = 150;

		internal const int BlL = 120;

		internal const int Bll = 200;

		internal const int BlM = 350;

		internal const int Blm = 250;

		internal const int BlN = 200;

		internal const int Bln = 200;

		internal const int BlO = 100;

		internal const int Blo = 100;

		internal const int BlP = 220;

		internal const int Blp = 250;

		internal const int BlQ = 200;

		internal const int Blq = 100;

		internal const int BlR = 350;

		internal const int Blr = 250;

		internal const int BlS = 600;

		internal const int Bls = 250;

		internal const int BlT = 600;

		internal const int Blt = 140;

		internal const int BlU = 600;

		internal const int Blu = 220;

		internal const int BlV = 1070;

		internal const int Blv = 570;

		[CompilerGenerated]
		private EventHandler BlW;

		private static readonly string Blw = BM.Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCu();

		internal static readonly string BlX = Blw + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCV();

		private bool Blx;

		private Bp BlY = new Bp();

		private Bv Bly = new Bv();

		private List<Panel> BlZ = new List<Panel>();

		private List<string> Blz = new List<string>();

		private List<int> BMA = new List<int>();

		private List<aF> BMa = new List<aF>();

		private List<Size> BMB = new List<Size>();

		private ContextMenuStrip BMb;

		private int BMC = -1;

		private int BMc = -1;

		private ToolStripMenuItem BMD = new ToolStripMenuItem();

		private ToolStripMenuItem BMd = new ToolStripMenuItem();

		private ToolStripMenuItem BME = new ToolStripMenuItem();

		private ToolStripMenuItem BMe = new ToolStripMenuItem();

		private ToolStripMenuItem BMF = new ToolStripMenuItem();

		private ToolStripMenuItem BMf = new ToolStripMenuItem();

		private ToolStripMenuItem BMG = new ToolStripMenuItem();

		private ToolStripMenuItem BMg = new ToolStripMenuItem();

		[SpecialName]
		[CompilerGenerated]
		internal void A(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BlW;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BlW, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		internal void a(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = BlW;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref BlW, val3, val2);
			}
			while (val != val2);
		}

		internal cR()
		{
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Expected O, but got Unknown
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			((Control)this).MouseDown += new MouseEventHandler(A);
			((Control)this).MouseMove += new MouseEventHandler(a);
			((Control)this).MouseUp += new MouseEventHandler(B);
		}

		internal void A()
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			D();
			C();
			if (BMb == null)
			{
				BMb = K();
				return;
			}
			((ToolStrip)BMb).BackColor = BM.tG;
			((ToolStrip)BMb).ForeColor = BM.te;
		}

		internal static bool a()
		{
			if (Directory.Exists(Blw))
			{
				try
				{
					return Directory.GetFiles(Blw, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SV()).Length == 0;
				}
				catch
				{
					return true;
				}
			}
			return true;
		}

		internal static void B()
		{
			if (File.Exists(BlX + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbb()))
			{
				try
				{
					string[] array = File.ReadAllLines(BlX + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbb());
					for (int i = 0; i < array.Length; i++)
					{
						string text = array[i];
						if (File.Exists(BlX + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + text))
						{
							string text2 = Blw + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj();
							text2 = ((i >= 10) ? (text2 + i + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + text) : string.Concat(new string[5]
							{
								text2,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn(),
								i.ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(),
								text
							}));
							File.Copy(BlX + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + text, text2);
						}
					}
					return;
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbC() + ex.Message, true);
					return;
				}
			}
			if (File.Exists(BlX + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbc()))
			{
				try
				{
					File.Copy(BlX + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbc(), Blw + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbD());
				}
				catch (System.Exception ex2)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbC() + ex2.Message, true);
				}
			}
		}

		internal int b()
		{
			for (int i = 0; i < ((TabControl)this).TabPages.Count - 1; i++)
			{
				if ((((TabControl)this).TabPages[i] as ae).a())
				{
					return i;
				}
			}
			return 0;
		}

		internal void C()
		{
			((TabControl)this).SelectedIndex = b();
		}

		internal Panel A(int P_0)
		{
			if (BlZ.Count > P_0)
			{
				return BlZ[P_0];
			}
			return null;
		}

		internal void c()
		{
			A(true);
		}

		internal void A(bool P_0)
		{
			if (P_0)
			{
				a(false);
			}
			BlZ.Clear();
			Blz.Clear();
			BMA.Clear();
			BMa.Clear();
			BMB.Clear();
			while (((TabControl)this).TabCount > 2)
			{
				q.A((Control)(object)((TabControl)this).TabPages[1]);
			}
			while (((ArrangedElementCollection)((Control)((TabControl)this).TabPages[0]).Controls).Count != 0)
			{
				q.A(((Control)((TabControl)this).TabPages[0]).Controls[0]);
			}
			(((TabControl)this).TabPages[0] as ae).A(true);
			((TabControl)this).SelectedIndex = 0;
		}

		private void D()
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d7: Invalid comparison between Unknown and I4
			//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bc: Invalid comparison between Unknown and I4
			Blx = true;
			A(true);
			bool flag = false;
			int num = 10;
			do
			{
				aF aF = new aF();
				((Control)aF).BackColor = BM.td;
				((Panel)aF).BorderStyle = (BorderStyle)0;
				((Control)aF).ContextMenuStrip = j();
				((Control)aF).Location = new Point(0, 0);
				((Control)aF).Width = ((Control)((TabControl)this).TabPages[0]).Width;
				((Control)aF).Height = ((Control)((TabControl)this).TabPages[0]).Height;
				aF.A(false);
				((Control)((TabControl)this).TabPages[0]).Controls.Add((Control)(object)aF);
				BMa.Add(aF);
				BMB.Add(new Size(0, 0));
				(((TabControl)this).TabPages[0] as ae).A(BP.uA);
				MovableResizablePanel movableResizablePanel = new MovableResizablePanel(new Rectangle(0, 0, 800, 600), true, false, false);
				BlZ.Add((Panel)(object)movableResizablePanel);
				Blz.Add(string.Empty);
				BMA.Add(-1);
				((Control)aF).Controls.Add((Control)(object)BlZ[0]);
				BMa.Add((aF)null);
				BMB.Add(new Size(0, 0));
				((Control)((TabControl)this).TabPages[0]).BackColor = BM.td;
				((Control)((TabControl)this).TabPages[1]).BackColor = BM.td;
				((Panel)((TabControl)this).TabPages[0]).BorderStyle = (BorderStyle)(BM.TO ? 1 : 0);
				((Panel)((TabControl)this).TabPages[1]).BorderStyle = (BorderStyle)(BM.TO ? 1 : 0);
				int num2 = 0;
				string[] array = null;
				try
				{
					if (Directory.Exists(Blw))
					{
						array = Directory.GetFiles(Blw, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SV());
						System.Array.Sort<string>(array);
						if (array.Length != 0 && array[0].EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbd()))
						{
							for (int i = 0; i < array.Length; i++)
							{
								string text = array[i];
								A(text, i, false, false);
								num2++;
							}
						}
					}
					Blx = false;
					if (BMA[0] != -1)
					{
						BM.QQ.rL.B(BMA[0]);
					}
					else if (!string.IsNullOrEmpty(Blz[0]))
					{
						BM.QQ.rL.A(Blz[0]);
					}
					flag = true;
				}
				catch
				{
					flag = false;
					if (num != 0)
					{
						num--;
					}
				}
				if (flag)
				{
					continue;
				}
				A(false);
				if (num != 0)
				{
					continue;
				}
				if (array != null && num2 < array.Length)
				{
					if ((int)bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbE() + array[num2] + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbe(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbF(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 7)
					{
						break;
					}
				}
				else if ((int)bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbf(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbF(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 7)
				{
					break;
				}
			}
			while (!flag);
		}

		private void A(string P_0, int P_1, bool P_2, bool P_3)
		{
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ec2: Unknown result type (might be due to invalid IL or missing references)
			//IL_109d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1064: Unknown result type (might be due to invalid IL or missing references)
			//IL_1028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_10d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0315: Unknown result type (might be due to invalid IL or missing references)
			//IL_031a: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a73: Unknown result type (might be due to invalid IL or missing references)
			//IL_098e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_09fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bcf: Unknown result type (might be due to invalid IL or missing references)
			//IL_061c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b97: Unknown result type (might be due to invalid IL or missing references)
			//IL_087a: Unknown result type (might be due to invalid IL or missing references)
			//IL_087c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0957: Unknown result type (might be due to invalid IL or missing references)
			//IL_0959: Unknown result type (might be due to invalid IL or missing references)
			//IL_0799: Unknown result type (might be due to invalid IL or missing references)
			//IL_079b: Unknown result type (might be due to invalid IL or missing references)
			if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbG()))
			{
				StreamReader val = File.OpenText(P_0);
				try
				{
					string text = string.Empty;
					string text2;
					Rectangle val4 = default(Rectangle);
					Rectangle val7 = default(Rectangle);
					Rectangle val5 = default(Rectangle);
					Rectangle val6 = default(Rectangle);
					while ((text2 = ((TextReader)val).ReadLine()) != null)
					{
						Size val2;
						if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbg()))
						{
							text = text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbg().Length);
						}
						else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbH()))
						{
							if (P_1 != 0)
							{
								BP bP = ((!bool.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbH().Length))) ? BP.ua : BP.uA);
								A(text, bP, false);
							}
						}
						else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbh()))
						{
							if (!P_2)
							{
								bool flag = bool.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbh().Length));
								(((TabControl)this).TabPages[((TabControl)this).TabCount - 2] as ae).A(flag);
							}
						}
						else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbI()))
						{
							bool flag2 = bool.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbI().Length));
							(((TabControl)this).TabPages[((TabControl)this).TabCount - 2] as ae).a(flag2);
						}
						else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbi()))
						{
							List<Size> bMB = BMB;
							int num = int.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbi().Length));
							val2 = BMB[P_1];
							bMB[P_1] = new Size(num, ((Size)(ref val2)).Height);
						}
						else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbJ()))
						{
							List<Size> bMB2 = BMB;
							val2 = BMB[P_1];
							bMB2[P_1] = new Size(((Size)(ref val2)).Width, int.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbJ().Length)));
						}
						else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbj()))
						{
							BMA[P_1] = int.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbj().Length));
						}
						else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbK()))
						{
							Blz[P_1] = text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbK().Length);
						}
						else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbk()))
						{
							int left = int.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbk().Length));
							((Control)BlZ[P_1]).Left = left;
						}
						else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbL()))
						{
							int top = int.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbL().Length));
							((Control)BlZ[P_1]).Top = top;
						}
						else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbl()))
						{
							int width = int.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbl().Length));
							((Control)BlZ[P_1]).Width = width;
						}
						else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbM()))
						{
							int height = int.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbM().Length));
							((Control)BlZ[P_1]).Height = height;
						}
						else
						{
							if (!text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbm()))
							{
								continue;
							}
							Rectangle val3 = A(val);
							string text3 = text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbm().Length);
							if (text3 == null)
							{
								continue;
							}
							switch (text3.Length)
							{
							case 21:
								switch (text3[0])
								{
								case 'G':
								{
									if (!(text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbn()))
									{
										break;
									}
									cP cP2 = new cP(null, BM.Qz, val3, true, false);
									cP2.A(val);
									((Control)BMa[P_1]).Controls.Add((Control)(object)cP2);
									if ((((TabControl)this).TabPages[P_1] as ae).A() == BP.uA && BlZ[P_1] != null)
									{
										((Rectangle)(ref val4))._002Ector(((Control)BlZ[P_1]).Left, ((Control)BlZ[P_1]).Top, ((Control)BlZ[P_1]).Width, ((Control)BlZ[P_1]).Height);
										if (val3 == val4)
										{
											Panel obj = BlZ[P_1];
											BlZ[P_1] = (Panel)(object)cP2;
											((Component)obj).Dispose();
										}
									}
									cP2.b();
									break;
								}
								case 'K':
									if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbO())
									{
										cl cl2 = new cl(BM.Qz, val3, true);
										cl2.A(val);
										((Control)BMa[P_1]).Controls.Add((Control)(object)cl2);
										((Control)cl2).Invalidate();
									}
									break;
								}
								break;
							case 13:
								switch (text3[0])
								{
								case 'T':
								{
									if (!(text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbo()))
									{
										break;
									}
									DC dC = new DC(BM.Qz, BM.Qn, val3, true);
									dC.A(val);
									((Control)BMa[P_1]).Controls.Add((Control)(object)dC);
									if ((((TabControl)this).TabPages[P_1] as ae).A() == BP.uA && BlZ[P_1] != null)
									{
										((Rectangle)(ref val7))._002Ector(((Control)BlZ[P_1]).Left, ((Control)BlZ[P_1]).Top, ((Control)BlZ[P_1]).Width, ((Control)BlZ[P_1]).Height);
										if (val3 == val7)
										{
											Panel obj4 = BlZ[P_1];
											BlZ[P_1] = (Panel)(object)dC;
											((Component)obj4).Dispose();
										}
									}
									dC.F();
									break;
								}
								case 'M':
									if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbP())
									{
										cm cm2 = new cm(BM.Qz, val3, true);
										cm2.A(val);
										((Control)BMa[P_1]).Controls.Add((Control)(object)cm2);
										((Control)cm2).Invalidate();
									}
									break;
								case 'N':
									if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbp())
									{
										cN cN2 = new cN(BM.Qz, val3, true);
										cN2.A(val);
										((Control)BMa[P_1]).Controls.Add((Control)(object)cN2);
										cN2.a();
									}
									break;
								}
								break;
							case 11:
								switch (text3[5])
								{
								case '2':
								{
									if (!(text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbQ()))
									{
										break;
									}
									DB dB = new DB(BM.Qz, BM.Qn, val3, true);
									dB.A(val);
									((Control)BMa[P_1]).Controls.Add((Control)(object)dB);
									if ((((TabControl)this).TabPages[P_1] as ae).A() == BP.uA && BlZ[P_1] != null)
									{
										((Rectangle)(ref val5))._002Ector(((Control)BlZ[P_1]).Left, ((Control)BlZ[P_1]).Top, ((Control)BlZ[P_1]).Width, ((Control)BlZ[P_1]).Height);
										if (val3 == val5)
										{
											Panel obj2 = BlZ[P_1];
											BlZ[P_1] = (Panel)(object)dB;
											((Component)obj2).Dispose();
										}
									}
									break;
								}
								case '3':
								{
									if (!(text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbq()))
									{
										break;
									}
									Db db = new Db(BM.Qz, BM.Qn, val3, true);
									db.A(val);
									((Control)BMa[P_1]).Controls.Add((Control)(object)db);
									if ((((TabControl)this).TabPages[P_1] as ae).A() == BP.uA && BlZ[P_1] != null)
									{
										((Rectangle)(ref val6))._002Ector(((Control)BlZ[P_1]).Left, ((Control)BlZ[P_1]).Top, ((Control)BlZ[P_1]).Width, ((Control)BlZ[P_1]).Height);
										if (val3 == val6)
										{
											Panel obj3 = BlZ[P_1];
											BlZ[P_1] = (Panel)(object)db;
											((Component)obj3).Dispose();
										}
									}
									break;
								}
								case 'i':
									if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbR())
									{
										cM cM2 = new cM(BM.Qz, val3, true);
										cM2.A(val);
										((Control)BMa[P_1]).Controls.Add((Control)(object)cM2);
										cM2.a();
									}
									break;
								}
								break;
							case 9:
								switch (text3[0])
								{
								case 'D':
									if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbs())
									{
										cj cj2 = new cj(BM.Qz, val3, true);
										cj2.A(val);
										((Control)BMa[P_1]).Controls.Add((Control)(object)cj2);
										cj2.B();
									}
									break;
								case 'T':
									if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbT())
									{
										co co2 = new co(BM.Qz, val3, true);
										co2.A(val);
										((Control)BMa[P_1]).Controls.Add((Control)(object)co2);
										((Control)co2).Invalidate();
									}
									break;
								}
								break;
							case 16:
								switch (text3[5])
								{
								case 'S':
									if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbU())
									{
										cL cL2 = new cL(BM.Qz, val3, true);
										cL2.A(val);
										((Control)BMa[P_1]).Controls.Add((Control)(object)cL2);
										((Control)cL2).Invalidate();
									}
									break;
								case 'E':
									if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbu())
									{
										ck ck2 = new ck(BM.Qz, val3, true);
										ck2.A(val);
										((Control)BMa[P_1]).Controls.Add((Control)(object)ck2);
										((Control)ck2).Invalidate();
									}
									break;
								}
								break;
							case 19:
								if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbN())
								{
									Df df = new Df(BM.Qz, BM.Qn, val3, true, false, false);
									int dataId = df.A(val);
									MenuNode menuNode = MenuNode.A(BM.Qz.awj, new DataIdAndAttrId(dataId));
									if (menuNode != null)
									{
										df.A(menuNode);
										((Control)BMa[P_1]).Controls.Add((Control)(object)df);
										df.A(true);
									}
									else
									{
										((Component)df).Dispose();
									}
								}
								break;
							case 18:
								if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbr())
								{
									cn cn2 = new cn(BM.Qz, val3, true);
									cn2.A(val);
									((Control)BMa[P_1]).Controls.Add((Control)(object)cn2);
								}
								break;
							case 8:
								if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbS())
								{
									cJ cJ2 = new cJ(BM.Qz, val3, true);
									cJ2.A(val);
									((Control)BMa[P_1]).Controls.Add((Control)(object)cJ2);
									cJ2.B();
								}
								break;
							case 14:
								if (text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbt())
								{
									cK cK2 = new cK(BM.Qz, val3, true);
									cK2.A(val);
									((Control)BMa[P_1]).Controls.Add((Control)(object)cK2);
									cK2.a();
								}
								break;
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			else if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbV()))
			{
				bool flag3 = File.ReadAllText(P_0).Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbv());
				StreamReader val8 = File.OpenText(P_0);
				try
				{
					string fileName = Path.GetFileName(P_0);
					string text4 = fileName.Substring(0, fileName.Length - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbV().Length);
					BP bP2 = ((!flag3) ? BP.ua : BP.uA);
					A(text4, bP2, false);
					string text5;
					while ((text5 = ((TextReader)val8).ReadLine()) != null)
					{
						if (text5.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbW()) || text5.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbw()) || !text5.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbX()))
						{
							continue;
						}
						string text6 = text5.Substring(text5.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbX()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbX().Length);
						Rectangle val9 = a(val8);
						if (text6 == null)
						{
							continue;
						}
						switch (text6.Length)
						{
						case 15:
							switch (text6[0])
							{
							case 'E':
								if (text6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbZ())
								{
									cn cn3 = new cn(BM.Qz, val9, true);
									cn3.A(val8);
									((Control)BMa[P_1]).Controls.Add((Control)(object)cn3);
								}
								break;
							case 'C':
								if (text6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbz())
								{
									cJ cJ3 = new cJ(BM.Qz, val9, true);
									cJ3.A(val8);
									((Control)BMa[P_1]).Controls.Add((Control)(object)cJ3);
									cJ3.B();
								}
								break;
							}
							break;
						case 12:
							switch (text6[7])
							{
							case 'G':
								if (text6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCA())
								{
									cj cj3 = new cj(BM.Qz, val9, true);
									cj3.A(val8);
									((Control)BMa[P_1]).Controls.Add((Control)(object)cj3);
									cj3.B();
								}
								break;
							case 'L':
								if (text6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCa())
								{
									cK cK3 = new cK(BM.Qz, val9, true);
									cK3.A(val8);
									((Control)BMa[P_1]).Controls.Add((Control)(object)cK3);
									cK3.a();
								}
								break;
							case 'T':
								if (text6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCB())
								{
									co co3 = new co(BM.Qz, val9, true);
									co3.A(val8);
									((Control)BMa[P_1]).Controls.Add((Control)(object)co3);
									((Control)co3).Invalidate();
								}
								break;
							}
							break;
						case 8:
							if (text6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbx())
							{
								((Control)BlZ[P_1]).Left = ((Rectangle)(ref val9)).Left;
								((Control)BlZ[P_1]).Top = ((Rectangle)(ref val9)).Top;
								((Control)BlZ[P_1]).Width = ((Rectangle)(ref val9)).Width;
								((Control)BlZ[P_1]).Height = ((Rectangle)(ref val9)).Height;
								DC dC2 = new DC(BM.Qz, BM.Qn, val9, true);
								dC2.A(val8);
								if (dC2.D() != null)
								{
									BMA[P_1] = ((Setting)dC2.D()).A();
								}
								((Component)dC2).Dispose();
							}
							break;
						case 6:
							if (text6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbY())
							{
								DB dB2 = new DB(BM.Qz, BM.Qn, val9, true);
								dB2.A(val8);
								((Control)BMa[P_1]).Controls.Add((Control)(object)dB2);
							}
							break;
						case 5:
							if (text6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bby())
							{
								Db db2 = new Db(BM.Qz, BM.Qn, val9, true);
								db2.A(val8);
								((Control)BMa[P_1]).Controls.Add((Control)(object)db2);
							}
							break;
						case 20:
							if (text6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCb())
							{
								cN cN3 = new cN(BM.Qz, val9, true);
								cN3.A(val8);
								((Control)BMa[P_1]).Controls.Add((Control)(object)cN3);
								cN3.a();
							}
							break;
						case 11:
							if (text6 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbR())
							{
								cM cM3 = new cM(BM.Qz, val9, true);
								cM3.A(val8);
								((Control)BMa[P_1]).Controls.Add((Control)(object)cM3);
								cM3.a();
							}
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)val8)?.Dispose();
				}
			}
			A(P_1, false);
			A(P_1, 0);
			if (P_3)
			{
				((TabControl)this).SelectedIndex = P_1;
			}
		}

		private Rectangle A(StreamReader P_0)
		{
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			string text;
			while ((text = ((TextReader)P_0).ReadLine()) != null)
			{
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad()))
				{
					num = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE()))
				{
					num2 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae()))
				{
					num3 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF()))
				{
					num4 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF().Length));
					break;
				}
			}
			return new Rectangle(num, num2, num3, num4);
		}

		private Rectangle a(StreamReader P_0)
		{
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			string text;
			while ((text = ((TextReader)P_0).ReadLine()) != null)
			{
				if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCC()))
				{
					num = int.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCC()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCC().Length));
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCc()))
				{
					num2 = int.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCc()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCc().Length));
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCD()))
				{
					num3 = int.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCD()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCD().Length));
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCd()))
				{
					num4 = int.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCd()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCd().Length));
					break;
				}
			}
			return new Rectangle(num, num2, num3, num4);
		}

		internal void a(bool P_0)
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			if (BlZ.Count == 0 || BMa.Count == 0)
			{
				return;
			}
			Stopwatch val = new Stopwatch();
			val.Start();
			string text = N.A(true);
			string text2 = Blw + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sS() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj();
			try
			{
				if (!Directory.Exists(Blw))
				{
					Directory.CreateDirectory(Blw);
				}
				else
				{
					if (!Directory.Exists(Blw + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ss()))
					{
						Directory.CreateDirectory(Blw + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ss());
					}
					string[] files = Directory.GetFiles(Blw, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SV());
					if (Directory.Exists(text2))
					{
						Directory.Delete(text2);
					}
					Directory.CreateDirectory(text2);
					string[] array = files;
					foreach (string obj in array)
					{
						string text3 = obj.Substring(Blw.Length + 1);
						File.Move(obj, text2 + text3);
					}
				}
				for (int j = 0; j < ((TabControl)this).TabPages.Count - 1; j++)
				{
					string text4 = ((Control)((TabControl)this).TabPages[j]).Text;
					string text5 = Blw + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj();
					text5 = ((j >= 10) ? string.Concat(new string[5]
					{
						text5,
						j.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(),
						text4,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbG()
					}) : string.Concat(new string[6]
					{
						text5,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn(),
						j.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(),
						text4,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbG()
					}));
					((Stream)File.Create(text5)).Close();
					File.SetAttributes(text5, (FileAttributes)128);
					A(text5, j);
				}
				if (!P_0)
				{
					Directory.Delete(text2, true);
				}
			}
			catch
			{
				if (Directory.Exists(text2))
				{
					string[] files2 = Directory.GetFiles(text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SV());
					if (files2.Length != 0)
					{
						string[] array = Directory.GetFiles(Blw, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SV());
						for (int i = 0; i < array.Length; i++)
						{
							File.Delete(array[i]);
						}
						array = files2;
						foreach (string obj2 in array)
						{
							string text6 = obj2.Substring(text2.Length);
							File.Move(obj2, Blw + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + text6);
						}
						Directory.Delete(text2, true);
					}
				}
			}
			val.Stop();
			N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCE(), (object)val.ElapsedMilliseconds), true);
		}

		private void A(string P_0, int P_1)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0293: Expected O, but got Unknown
			aF aF = BMa[P_1];
			Point autoScrollPosition = ((ScrollableControl)aF).AutoScrollPosition;
			int x = ((Point)(ref autoScrollPosition)).X;
			autoScrollPosition = ((ScrollableControl)aF).AutoScrollPosition;
			int y = ((Point)(ref autoScrollPosition)).Y;
			string text = ((Control)((TabControl)this).TabPages[P_1]).Text;
			bool flag = (((TabControl)this).TabPages[P_1] as ae).A() == BP.uA;
			bool flag2 = (((TabControl)this).TabPages[P_1] as ae).a();
			bool flag3 = (((TabControl)this).TabPages[P_1] as ae).B();
			List<string> val = new List<string>();
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbg() + text);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbH() + flag);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbh() + flag2);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbI() + flag3);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbi() + ((Control)aF).Width);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbJ() + ((Control)aF).Height);
			if (flag && BM.QQ.rL.A().a().Count != 0)
			{
				if (BMA[P_1] != -1)
				{
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbj() + BMA[P_1]);
				}
				else
				{
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbK() + Blz[P_1]);
				}
			}
			if (BlZ[P_1] != null)
			{
				int num = ((Control)BlZ[P_1]).Left - x;
				int num2 = ((Control)BlZ[P_1]).Top - y;
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbk() + num);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbL() + num2);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbl() + ((Control)BlZ[P_1]).Width);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbM() + ((Control)BlZ[P_1]).Height);
			}
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
			foreach (Control item in (ArrangedElementCollection)((Control)aF).Controls)
			{
				Control val2 = item;
				if (val2 is Df && !flag)
				{
					(val2 as Df).A(P_0, x, y);
				}
				else if (val2 is DC)
				{
					(val2 as DC).A(P_0, x, y);
				}
				else if (val2 is DB)
				{
					(val2 as DB).A(P_0, x, y);
				}
				else if (val2 is Db)
				{
					(val2 as Db).A(P_0, x, y);
				}
				else if (val2 is cn)
				{
					(val2 as cn).A(P_0, x, y);
				}
				else if (val2 is cJ)
				{
					(val2 as cJ).A(P_0, x, y);
				}
				else if (val2 is cm)
				{
					(val2 as cm).A(P_0, x, y);
				}
				else if (val2 is cj)
				{
					(val2 as cj).A(P_0, x, y);
				}
				else if (val2 is cK)
				{
					(val2 as cK).A(P_0, x, y);
				}
				else if (val2 is cN)
				{
					(val2 as cN).A(P_0, x, y);
				}
				else if (val2 is cM)
				{
					(val2 as cM).A(P_0, x, y);
				}
				else if (val2 is co)
				{
					(val2 as co).A(P_0, x, y);
				}
				else if (val2 is cL)
				{
					(val2 as cL).A(P_0, x, y);
				}
				else if (val2 is cl)
				{
					(val2 as cl).A(P_0, x, y);
				}
				else if (val2 is ck)
				{
					(val2 as ck).A(P_0, x, y);
				}
				else if (val2 is cP)
				{
					(val2 as cP).A(P_0, x, y);
				}
			}
		}

		[SpecialName]
		internal List<string> d()
		{
			return Blz;
		}

		[SpecialName]
		internal List<int> E()
		{
			return BMA;
		}

		protected override void OnSelectedIndexChanged(EventArgs e)
		{
			if (!Blx)
			{
				((TabControl)this).OnSelectedIndexChanged(e);
				BM.X(null, null);
				BM.Sl = true;
				if (((TabControl)this).SelectedIndex == ((TabControl)this).TabCount - 1)
				{
					H(null, null);
				}
				else
				{
					this.e();
				}
				if (BlW != null)
				{
					BlW.Invoke((object)this, (EventArgs)null);
				}
			}
		}

		private void e()
		{
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			if (BMa.Count == 0)
			{
				return;
			}
			if ((((TabControl)this).SelectedTab as ae).A() == BP.uA)
			{
				if (BMA[((TabControl)this).SelectedIndex] != -1)
				{
					BM.QQ.rL.B(BMA[((TabControl)this).SelectedIndex]);
				}
				else if (!string.IsNullOrEmpty(Blz[((TabControl)this).SelectedIndex]))
				{
					BM.QQ.rL.A(Blz[((TabControl)this).SelectedIndex]);
				}
			}
			foreach (Control item in (ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls)
			{
				Control val = item;
				if (val is DC)
				{
					((DC)(object)val).UpdateLayout(resizingOnly: false);
					((DC)(object)val).F();
				}
				else if (val is DB)
				{
					((DB)(object)val).UpdateLayout(resizingOnly: false);
				}
				else if (val is Db)
				{
					((Db)(object)val).UpdateLayout(resizingOnly: false);
				}
				else if (val is cn)
				{
					((cn)(object)val).UpdateLayout(resizingOnly: false);
				}
			}
			H();
		}

		internal void a(int P_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			Enumerator<aF> enumerator = BMa.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					aF current = enumerator.Current;
					if (current == null)
					{
						continue;
					}
					foreach (Control item in (ArrangedElementCollection)((Control)current).Controls)
					{
						Control val = item;
						if (val is cJ)
						{
							cJ cJ2 = val as cJ;
							if (cJ2.a() == P_0)
							{
								cJ2.A(true);
							}
						}
						if (val is cj)
						{
							cj cj2 = val as cj;
							if (cj2.a() == P_0)
							{
								cj2.A(true);
							}
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		internal void A(float P_0)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			DC.Bvd = P_0;
			Enumerator<aF> enumerator = BMa.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					aF current = enumerator.Current;
					if (current == null)
					{
						continue;
					}
					foreach (Control item in (ArrangedElementCollection)((Control)current).Controls)
					{
						Control val = item;
						if (val is DC)
						{
							((DC)(object)val).f();
							((DC)(object)val).UpdateLayout(resizingOnly: false);
							((DC)(object)val).F();
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		internal void F()
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			if (BMa.Count == 0)
			{
				return;
			}
			foreach (Control item in (ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls)
			{
				Control val = item;
				if (val is DC)
				{
					((Control)(DC)(object)val).Invalidate();
					((Control)((DC)(object)val).d()).Invalidate();
				}
			}
		}

		internal void f()
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			if (BMa.Count == 0)
			{
				return;
			}
			foreach (Control item in (ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls)
			{
				Control val = item;
				if (val is DC)
				{
					((DC)(object)val).F();
					((Control)(DC)(object)val).Invalidate();
					((Control)((DC)(object)val).d()).Invalidate();
				}
			}
		}

		internal void G()
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			if (BMa.Count == 0)
			{
				return;
			}
			foreach (Control item in (ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls)
			{
				Control val = item;
				if (val is Db)
				{
					((Db)(object)val).UpdateLayout(resizingOnly: false);
					((Control)(Db)(object)val).Invalidate();
				}
			}
		}

		internal void g()
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			if (BMa.Count == 0)
			{
				return;
			}
			foreach (Control item in (ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls)
			{
				Control val = item;
				if (val is DB)
				{
					((Control)(DB)(object)val).Invalidate();
				}
			}
		}

		private void A(int P_0, int P_1)
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			if (BMa.Count <= P_0 || BMa[P_0] == null)
			{
				return;
			}
			List<int> val = new List<int>();
			foreach (Control item in (ArrangedElementCollection)((Control)BMa[P_0]).Controls)
			{
				Control val2 = item;
				if (val2 is DC)
				{
					DC dC = val2 as DC;
					if (dC.D() != null)
					{
						val.Add(((Setting)dC.D()).A());
					}
				}
			}
			foreach (Control item2 in (ArrangedElementCollection)((Control)BMa[P_0]).Controls)
			{
				Control val3 = item2;
				if (val3 is DB)
				{
					DB dB = val3 as DB;
					if (dB.B() != null && (P_1 == 0 || P_1 == ((Setting)dB.B()).A()) && !val.Contains(((Setting)dB.B()).A()))
					{
						dB.A(true);
					}
				}
				else if (val3 is Db)
				{
					Db db = val3 as Db;
					if (db.B() != null && (P_1 == 0 || P_1 == ((Setting)db.B()).A()) && !val.Contains(((Setting)db.B()).A()))
					{
						db.A(true);
					}
				}
			}
		}

		internal bool A(Control P_0)
		{
			if (BMa.Count > ((TabControl)this).SelectedIndex && ((TabControl)this).SelectedIndex != -1 && ((TabControl)this).SelectedIndex != BMa.Count - 1)
			{
				Control val = P_0;
				do
				{
					if (((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Contains(val))
					{
						return true;
					}
					val = val.Parent;
				}
				while ((!(val is aF) || !BMa.Contains(val as aF)) && val != null);
			}
			return false;
		}

		internal bool a(Control P_0)
		{
			Control val = P_0;
			do
			{
				for (int i = 0; i < BMa.Count; i++)
				{
					aF aF = BMa[i];
					if (aF != null && ((Control)aF).Controls.Contains(val))
					{
						return (((TabControl)this).TabPages[i] as ae).B();
					}
				}
				val = val.Parent;
			}
			while ((!(val is aF) || !BMa.Contains(val as aF)) && val != null);
			return false;
		}

		private void A(string P_0, BP P_1, bool P_2)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			ae ae = new ae(P_0);
			((ScrollableControl)ae).AutoScroll = false;
			aF aF = new aF();
			((Control)aF).BackColor = BM.td;
			((Panel)aF).BorderStyle = (BorderStyle)0;
			((Control)aF).ContextMenuStrip = j();
			ae.A(P_1);
			((Panel)ae).BorderStyle = (BorderStyle)(BM.TO ? 1 : 0);
			((Control)ae).BackColor = BM.td;
			((Control)aF).Location = new Point(0, 0);
			((Control)ae).Width = ((Control)((TabControl)this).TabPages[0]).Width;
			((Control)ae).Height = ((Control)((TabControl)this).TabPages[0]).Height;
			((Control)aF).Width = ((Control)ae).Width;
			((Control)aF).Height = ((Control)ae).Height;
			aF.A(false);
			((Control)ae).Controls.Add((Control)(object)aF);
			int num = ((TabControl)this).TabCount - 1;
			((TabControl)this).TabPages.Insert(num, (TabPage)(object)ae);
			BMa.Insert(num, aF);
			BMB.Insert(num, new Size(0, 0));
			if (P_1 == BP.uA)
			{
				MovableResizablePanel movableResizablePanel = new MovableResizablePanel(new Rectangle(0, 0, 800, 600), true, false, false);
				BlZ.Add((Panel)(object)movableResizablePanel);
				((Control)aF).Controls.Add((Control)(object)movableResizablePanel);
			}
			else
			{
				BlZ.Add((Panel)null);
			}
			Blz.Add(string.Empty);
			BMA.Add(-1);
			if (P_2)
			{
				((TabControl)this).SelectedIndex = ((TabControl)this).TabCount - 2;
			}
		}

		internal void H()
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c3: Expected O, but got Unknown
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c4: Expected O, but got Unknown
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0331: Expected O, but got Unknown
			if (BMa.Count == 0)
			{
				return;
			}
			Control val = null;
			if (BM.qF.DataId != 0)
			{
				foreach (Control item in (ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls)
				{
					Control val2 = item;
					if (val2 is DC && (val2 as DC).D() != null && ((val2 as DC).D().C() == BM.qF || (val2 as DC).D().TableDataSetting.C() == BM.qF))
					{
						foreach (Control item2 in (ArrangedElementCollection)val2.Controls)
						{
							Control val3 = item2;
							if (val3 is DataGridViewWithThemedScrollBars)
							{
								val = val3;
								break;
							}
						}
						break;
					}
					if (val2 is Y)
					{
						val = (val2 as Y).A(BM.qF);
						if (val != null)
						{
							break;
						}
					}
				}
				if (val == null)
				{
					foreach (Control item3 in (ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls)
					{
						Control val4 = item3;
						if (val4 is DB && (val4 as DB).B() != null && ((val4 as DB).B().C() == BM.qF || (val4 as DB).B().TableDataSetting.C() == BM.qF))
						{
							val = (Control)(object)(val4 as DB);
							break;
						}
						if (val4 is Db && (val4 as Db).B() != null && ((val4 as Db).B().C() == BM.qF || (val4 as Db).B().TableDataSetting.C() == BM.qF))
						{
							val = (Control)(object)(val4 as Db);
							break;
						}
					}
				}
				if (!BM.qe)
				{
					BM.qF = new DataIdAndAttrId(0, 0);
				}
			}
			if (val == null && BMa.Count > ((TabControl)this).SelectedIndex && ((TabControl)this).SelectedIndex != -1 && ((TabControl)this).SelectedIndex != BMa.Count - 1)
			{
				foreach (Control item4 in (ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls)
				{
					Control val5 = item4;
					if (val5 is ci)
					{
						val = (Control)(object)(val5 as ci).B();
						break;
					}
					if (val5 is cz)
					{
						val = (Control)(object)(val5 as cz).C();
						continue;
					}
					if (val5 is cI)
					{
						val = (Control)(object)(val5 as cI);
						break;
					}
					if (val5 is DC)
					{
						foreach (Control item5 in (ArrangedElementCollection)val5.Controls)
						{
							Control val6 = item5;
							if (val6 is DataGridViewWithThemedScrollBars)
							{
								val = val6;
								break;
							}
						}
						break;
					}
					if (!(val5 is Y))
					{
						continue;
					}
					val = (val5 as Y).A();
					break;
				}
				if (val == null)
				{
					foreach (Control item6 in (ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls)
					{
						Control val7 = item6;
						if (val7 is DB)
						{
							val = (Control)(object)(val7 as DB);
							break;
						}
						if (val7 is Db)
						{
							val = (Control)(object)(val7 as Db);
							break;
						}
					}
				}
			}
			if (val != null)
			{
				val.Focus();
			}
		}

		internal void A(SettingOrSpecialObject P_0, aE P_1, object P_2, MenuNode P_3, bool P_4)
		{
			//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0733: Unknown result type (might be due to invalid IL or missing references)
			//IL_056b: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0625: Unknown result type (might be due to invalid IL or missing references)
			//IL_083f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0999: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0939: Unknown result type (might be due to invalid IL or missing references)
			//IL_08de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b77: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0379: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
			if (BMa.Count == 0)
			{
				return;
			}
			if (P_1 == aE.HW)
			{
				if ((((TabControl)this).SelectedTab as ae).A() == BP.uA)
				{
					Rectangle val2 = default(Rectangle);
					Rectangle val3 = default(Rectangle);
					Rectangle val4 = default(Rectangle);
					Rectangle val5 = default(Rectangle);
					Rectangle val6 = default(Rectangle);
					foreach (Control item in (ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls)
					{
						Control val = item;
						if (val is DC)
						{
							if (P_0 != null && (val as DC).D() != P_0 as Table)
							{
								((Rectangle)(ref val2))._002Ector(val.Left, val.Top, val.Width, val.Height);
								DC dC = new DC(BM.Qz, BM.Qn, val2, true);
								((cO)dC).A((P_0 as Setting).A());
								((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)dC);
								if (val == BlZ[((TabControl)this).SelectedIndex])
								{
									BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)dC;
								}
								((Component)val).Dispose();
								((Control)dC).BringToFront();
								dC.F();
							}
						}
						else if (val is DB)
						{
							if (P_0 != null && (val as DB).B() != P_0 as Table)
							{
								((Rectangle)(ref val3))._002Ector(val.Left, val.Top, val.Width, val.Height);
								DB dB = new DB(BM.Qz, BM.Qn, val3, true);
								((cO)dB).A((P_0 as Setting).A());
								((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)dB);
								if (val == BlZ[((TabControl)this).SelectedIndex])
								{
									BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)dB;
								}
								((Component)val).Dispose();
								((Control)dB).BringToFront();
							}
						}
						else if (val is Db)
						{
							if (P_0 != null && (val as Db).B() != P_0 as Table)
							{
								((Rectangle)(ref val4))._002Ector(val.Left, val.Top, val.Width, val.Height);
								Db db = new Db(BM.Qz, BM.Qn, val4, true);
								((cO)db).A((P_0 as Setting).A());
								((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)db);
								if (val == BlZ[((TabControl)this).SelectedIndex])
								{
									BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)db;
								}
								((Component)val).Dispose();
								((Control)db).BringToFront();
							}
						}
						else if (val is cn)
						{
							if (P_0 != null && (val as cn).a() != P_0 as Table)
							{
								((Rectangle)(ref val5))._002Ector(val.Left, val.Top, val.Width, val.Height);
								cn cn2 = new cn(BM.Qz, val5, true);
								cn2.A((P_0 as Setting).A());
								((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cn2);
								((Component)val).Dispose();
								((Control)cn2).BringToFront();
							}
						}
						else if (val == BlZ[((TabControl)this).SelectedIndex] && P_0 != null)
						{
							((Rectangle)(ref val6))._002Ector(val.Left, val.Top, val.Width, val.Height);
							DC dC2 = new DC(BM.Qz, BM.Qn, val6, true);
							((cO)dC2).A((P_0 as Setting).A());
							((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)dC2);
							BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)dC2;
							((Component)val).Dispose();
							((Control)dC2).BringToFront();
							dC2.F();
						}
					}
				}
				else
				{
					if (P_0 != null)
					{
						int num = b();
						BMA[num] = (P_0 as Setting).A();
						Blz[num] = string.Empty;
					}
					C();
					A(P_0, P_1, P_2, P_3, P_4);
				}
			}
			else
			{
				if ((((TabControl)this).SelectedTab as ae).A() == BP.ua)
				{
					if (P_3 != null)
					{
						TreeNode val7 = BM.QQ.rL.A(P_3.e());
						if (val7 != null)
						{
							int num2 = b();
							Blz[num2] = BM.QQ.rL.a(val7, true, true);
							BMA[num2] = -1;
						}
					}
					C();
				}
				Panel val8 = BlZ[((TabControl)this).SelectedIndex];
				Rectangle val9 = default(Rectangle);
				((Rectangle)(ref val9))._002Ector(((Control)val8).Left, ((Control)val8).Top, ((Control)val8).Width, ((Control)val8).Height);
				switch (P_1)
				{
				case aE.Hu:
				{
					if (!P_4)
					{
						(BlZ[((TabControl)this).SelectedIndex] as cZ).B();
						break;
					}
					cZ cZ2 = new cZ(BM.Qz, val9, true);
					((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cZ2);
					BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)cZ2;
					cZ2.B();
					break;
				}
				case aE.Ht:
				{
					if (!P_4)
					{
						(BlZ[((TabControl)this).SelectedIndex] as DH).A(false);
						break;
					}
					DH dH = new DH(val9, true, false);
					((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)dH);
					BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)dH;
					dH.A(true);
					break;
				}
				case aE.Hv:
					if (P_4)
					{
						cz cz2 = new cz(val9, BM.Qz, BM.Qn, true);
						((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cz2);
						BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)cz2;
						if (P_3 != null && P_3.p() != null)
						{
							cz2.A(P_3.p());
							P_3.B(null);
						}
					}
					break;
				case aE.hB:
				{
					if (!P_4)
					{
						(BlZ[((TabControl)this).SelectedIndex] as cI).A(false);
						break;
					}
					cI cI2 = new cI(BM.Qz, val9, true);
					((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cI2);
					BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)cI2;
					cI2.A(true);
					break;
				}
				case aE.HU:
				{
					if (!P_4)
					{
						(BlZ[((TabControl)this).SelectedIndex] as Da).A(false);
						break;
					}
					Da da = new Da(P_2 as bu, val9, true);
					((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)da);
					BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)da;
					da.A(true);
					break;
				}
				case aE.HV:
				{
					if (!P_4 && (BlZ[((TabControl)this).SelectedIndex] as ci).C())
					{
						(BlZ[((TabControl)this).SelectedIndex] as ci).A(false);
						break;
					}
					ci ci2 = new ci(BM.Qz, BM.Qn, val9, true);
					((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)ci2);
					BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)ci2;
					ci2.A(true);
					break;
				}
				case aE.Hw:
				{
					if (!P_4)
					{
						(BlZ[((TabControl)this).SelectedIndex] as DD).A(false);
						break;
					}
					DD dD = new DD(P_0, P_3, BM.Qz, BM.Qn, val9, true);
					((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)dD);
					BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)dD;
					dD.A(true);
					break;
				}
				case aE.HX:
				{
					if (!P_4)
					{
						(BlZ[((TabControl)this).SelectedIndex] as DF).A(false);
						break;
					}
					string text = string.Empty;
					if (P_3 != null && P_3.Q())
					{
						text = P_3.A(false, false);
					}
					DF dF = new DF(P_0 as SpecialObject, text, P_3, BM.Qz, BM.Qn, val9, true, false);
					((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)dF);
					BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)dF;
					dF.A(true);
					break;
				}
				case aE.hC:
					if (P_4)
					{
						cP cP2 = new cP(P_3, BM.Qz, val9, true, false);
						((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cP2);
						BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)cP2;
						cP2.b();
					}
					break;
				case aE.Hx:
					if (P_4)
					{
						cr cr2 = new cr(P_0 as SensorCalibration, P_3, BM.Qz, BM.Qn, val9, true);
						((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cr2);
						BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)cr2;
						cr2.b();
					}
					break;
				case aE.HY:
				{
					if (!P_4)
					{
						((Control)(BlZ[((TabControl)this).SelectedIndex] as cH)).Invalidate();
						break;
					}
					cH cH2 = new cH(P_0 as BezierCurve, BM.Qz, BM.Qn, val9, true);
					((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cH2);
					BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)cH2;
					((Control)cH2).Invalidate();
					break;
				}
				case aE.Hy:
				{
					if (!P_4)
					{
						(BlZ[((TabControl)this).SelectedIndex] as De).b();
						break;
					}
					De de = new De(P_0 as StateMachine, BM.Qz, BM.Qn, val9, true);
					((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)de);
					BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)de;
					de.b();
					break;
				}
				case aE.hb:
				{
					if (!P_4)
					{
						(BlZ[((TabControl)this).SelectedIndex] as Dh).b();
						break;
					}
					Dh dh = new Dh(BM.Qz, val9, true);
					((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)dh);
					BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)dh;
					dh.b();
					break;
				}
				case aE.HZ:
					if (!P_4)
					{
						((Control)(BlZ[((TabControl)this).SelectedIndex] as cp)).Invalidate();
					}
					else if (P_0 != null)
					{
						cp cp2 = new cp(P_0 as KnockDetection, BM.Qz, val9, true);
						((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cp2);
						BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)cp2;
						((Control)cp2).Invalidate();
					}
					break;
				case aE.Hz:
					if (P_4)
					{
						cg cg2 = new cg(P_0 as SpecialObject, BM.Qz, BM.Qn, val9, true);
						((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cg2);
						BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)cg2;
						cg2.A(false, true, null, 0);
					}
					break;
				case aE.hA:
					if (P_4 && P_0 != null)
					{
						Dc dc = new Dc(P_0 as OnOffSwitchingPoint, BM.Qz, BM.Qn, val9, true);
						((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)dc);
						BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)dc;
						dc.B();
					}
					break;
				case aE.ha:
					if (P_4)
					{
						if (P_0.f().HasGroups())
						{
							Dg dg = new Dg(P_0.f(), BM.Qz, BM.Qn, val9, true);
							((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)dg);
							BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)dg;
							dg.b();
						}
						else
						{
							DG dG = new DG(P_0.f(), BM.Qz, BM.Qn, val9, true);
							((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)dG);
							BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)dG;
							dG.b();
						}
					}
					break;
				}
				((Control)BMa[((TabControl)this).SelectedIndex]).Controls[((ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls).Count - 1].BringToFront();
				if (P_4 || (P_1 == aE.HV && !(val8 as ci).C()))
				{
					((Component)val8).Dispose();
				}
			}
			if (P_1 == aE.HW)
			{
				if (P_0 != null)
				{
					BMA[((TabControl)this).SelectedIndex] = (P_0 as Setting).A();
				}
				Blz[((TabControl)this).SelectedIndex] = string.Empty;
			}
			else
			{
				Blz[((TabControl)this).SelectedIndex] = BM.QQ.rL.a(BM.QQ.rL.A().B(), true, true);
				BMA[((TabControl)this).SelectedIndex] = -1;
			}
		}

		internal void A(MenuNode P_0, bool P_1)
		{
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			if (BMa.Count == 0 || ((TabControl)this).SelectedIndex >= BlZ.Count)
			{
				return;
			}
			if ((((TabControl)this).SelectedTab as ae).A() == BP.ua)
			{
				TreeNode val = BM.QQ.rL.A(P_0.e());
				if (val != null)
				{
					int num = b();
					Blz[num] = BM.QQ.rL.a(val, true, true);
					BMA[num] = -1;
				}
				C();
			}
			Panel val2 = BlZ[((TabControl)this).SelectedIndex];
			Rectangle val3 = default(Rectangle);
			((Rectangle)(ref val3))._002Ector(((Control)val2).Left, ((Control)val2).Top, ((Control)val2).Width, ((Control)val2).Height);
			if (P_0.j())
			{
				if (P_1)
				{
					cw cw2 = new cw(BM.Qz, BM.Qn, val3, true, false);
					cw2.A(P_0);
					((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cw2);
					BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)cw2;
					cw2.A(true);
					((Control)cw2).BringToFront();
				}
				else
				{
					(BlZ[((TabControl)this).SelectedIndex] as cw).A(false);
				}
			}
			else if (P_1)
			{
				Df df = new Df(BM.Qz, BM.Qn, val3, true, false, false);
				df.A(P_0);
				((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)df);
				BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)df;
				df.A(true);
				((Control)df).BringToFront();
			}
			else if (BlZ[((TabControl)this).SelectedIndex] is Df df2)
			{
				df2.A(false);
			}
			if (P_1)
			{
				((Component)val2).Dispose();
			}
			Blz[((TabControl)this).SelectedIndex] = BM.QQ.rL.a(BM.QQ.rL.A().B(), true, true);
			BMA[((TabControl)this).SelectedIndex] = -1;
		}

		internal void B(int P_0)
		{
			if (BlZ[((TabControl)this).SelectedIndex] is Df)
			{
				Df df = BlZ[((TabControl)this).SelectedIndex] as Df;
				if (df.F() != null)
				{
					df.F().a(P_0);
				}
			}
		}

		internal void h()
		{
			if (BlZ[((TabControl)this).SelectedIndex] is Df)
			{
				Df df = BlZ[((TabControl)this).SelectedIndex] as Df;
				if (df.F() != null)
				{
					df.F().d();
				}
			}
		}

		internal void I()
		{
			if (BlZ[((TabControl)this).SelectedIndex] is Df)
			{
				Df df = BlZ[((TabControl)this).SelectedIndex] as Df;
				if (df.F() != null)
				{
					df.F().C();
				}
			}
		}

		internal ci i()
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					A a = i;
					return ((Control)this).Invoke((System.Delegate)a) as ci;
				}
				catch
				{
					return null;
				}
			}
			if (((TabControl)this).SelectedIndex != -1 && BlZ.Count > ((TabControl)this).SelectedIndex)
			{
				return BlZ[((TabControl)this).SelectedIndex] as ci;
			}
			return null;
		}

		internal void J()
		{
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			if (BMa.Count <= ((TabControl)this).SelectedIndex || ((TabControl)this).SelectedIndex == -1 || ((TabControl)this).SelectedIndex == BMa.Count - 1)
			{
				return;
			}
			foreach (Control item in (ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls)
			{
				Control val = item;
				if (val is DC)
				{
					(val as DC).H();
				}
			}
		}

		internal void A(Point P_0, MenuNode P_1)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_043a: Unknown result type (might be due to invalid IL or missing references)
			//IL_043f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0371: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_047a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			if (((TabControl)this).TabPages[((TabControl)this).SelectedIndex] is ae && (((TabControl)this).TabPages[((TabControl)this).SelectedIndex] as ae).B())
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCe(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCF(), (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			SettingOrSpecialObject settingOrSpecialObject = BM.Qz.a(P_1.b());
			bool flag = false;
			if (settingOrSpecialObject is Table)
			{
				Table table = settingOrSpecialObject as Table;
				Rectangle val2 = default(Rectangle);
				foreach (Control item in (ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls)
				{
					Control val = item;
					((Rectangle)(ref val2))._002Ector(val.Left, val.Top, val.Width, val.Height);
					if (!((Rectangle)(ref val2)).Contains(P_0))
					{
						continue;
					}
					if (val is DC)
					{
						DC dC = new DC(BM.Qz, BM.Qn, val2, true);
						((cO)dC).A(((Setting)table).A());
						((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)dC);
						((Control)dC).BringToFront();
						dC.F();
						flag = true;
						if ((((TabControl)this).SelectedTab as ae).A() == BP.uA && BlZ[((TabControl)this).SelectedIndex] == val)
						{
							BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)dC;
						}
						q.A(val);
						((Control)dC).Focus();
						break;
					}
					if (val is DB)
					{
						DB dB = new DB(BM.Qz, BM.Qn, val2, true);
						((cO)dB).A(((Setting)table).A());
						((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)dB);
						((Control)dB).BringToFront();
						flag = true;
						if ((((TabControl)this).SelectedTab as ae).A() == BP.uA && BlZ[((TabControl)this).SelectedIndex] == val)
						{
							BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)dB;
						}
						q.A(val);
						((Control)dB).Focus();
						break;
					}
					if (val is Db)
					{
						Db db = new Db(BM.Qz, BM.Qn, val2, true);
						((cO)db).A(((Setting)table).A());
						((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)db);
						((Control)db).BringToFront();
						flag = true;
						if ((((TabControl)this).SelectedTab as ae).A() == BP.uA && BlZ[((TabControl)this).SelectedIndex] == val)
						{
							BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)db;
						}
						q.A(val);
						((Control)db).Focus();
						break;
					}
					if (val is cn)
					{
						cn cn2 = new cn(BM.Qz, val2, true);
						cn2.A(((Setting)table).A());
						((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cn2);
						((Control)cn2).BringToFront();
						flag = true;
						((Component)val).Dispose();
						break;
					}
				}
			}
			if (!flag)
			{
				if (settingOrSpecialObject != null)
				{
					if (settingOrSpecialObject is Table)
					{
						Table table2 = settingOrSpecialObject as Table;
						Rectangle val3 = default(Rectangle);
						((Rectangle)(ref val3))._002Ector(((Point)(ref P_0)).X, ((Point)(ref P_0)).Y, 500, 300);
						DC dC2 = new DC(BM.Qz, BM.Qn, val3, true);
						((cO)dC2).A(((Setting)table2).A());
						((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)dC2);
						((Control)dC2).BringToFront();
						dC2.F();
						((Control)dC2).Focus();
					}
					else if (settingOrSpecialObject is DN)
					{
						Rectangle val4 = default(Rectangle);
						((Rectangle)(ref val4))._002Ector(((Point)(ref P_0)).X, ((Point)(ref P_0)).Y, 1070, 570);
						cP cP2 = new cP(P_1, BM.Qz, val4, true, false);
						((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cP2);
						cP2.b();
						((Control)cP2).BringToFront();
						((Control)cP2).Focus();
					}
				}
				else
				{
					Enumerator<MenuNode> enumerator2 = P_1.c().GetEnumerator();
					try
					{
						Rectangle val5 = default(Rectangle);
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current.J())
							{
								((Rectangle)(ref val5))._002Ector(((Point)(ref P_0)).X, ((Point)(ref P_0)).Y, 800, 600);
								Df df = new Df(BM.Qz, BM.Qn, val5, true, false, false);
								df.A(P_1);
								((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)df);
								df.A(true);
								((Control)df).BringToFront();
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
			a(false);
		}

		internal void a(Point P_0, MenuNode P_1)
		{
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			if (!(BM.Qz.a(P_1.b()) is Table))
			{
				return;
			}
			Rectangle val2 = default(Rectangle);
			foreach (Control item in (ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls)
			{
				Control val = item;
				if (val is DC || val is DB || val is Db || val is cn)
				{
					((Rectangle)(ref val2))._002Ector(val.Left, val.Top, val.Width, val.Height);
					((MovableResizablePanel)(object)val).A(((Rectangle)(ref val2)).Contains(P_0));
				}
			}
		}

		internal void B(Control P_0)
		{
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			Rectangle val = default(Rectangle);
			((Rectangle)(ref val))._002Ector(P_0.Left, P_0.Top, P_0.Width, P_0.Height);
			if (P_0 is DC)
			{
				DC dC = P_0 as DC;
				Db db = B(dC.D(), val);
				if (db != null)
				{
					db.A(true);
					if ((((TabControl)this).SelectedTab as ae).A() == BP.uA && BlZ[((TabControl)this).SelectedIndex] == dC)
					{
						BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)db;
					}
					q.A((Control)(object)dC);
					((Control)db).Focus();
				}
			}
			else if (P_0 is Db)
			{
				Db db2 = P_0 as Db;
				DB dB = a(db2.B(), val);
				if (dB != null)
				{
					dB.A(true);
					if ((((TabControl)this).SelectedTab as ae).A() == BP.uA && BlZ[((TabControl)this).SelectedIndex] == db2)
					{
						BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)dB;
					}
					q.A((Control)(object)db2);
					((Control)dB).Focus();
				}
			}
			else if (P_0 is DB)
			{
				DB dB2 = P_0 as DB;
				DC dC2 = A(dB2.B(), val);
				if (dC2 != null)
				{
					if ((((TabControl)this).SelectedTab as ae).A() == BP.uA && BlZ[((TabControl)this).SelectedIndex] == dB2)
					{
						BlZ[((TabControl)this).SelectedIndex] = (Panel)(object)dC2;
					}
					q.A((Control)(object)dB2);
					if (dC2.d() != null)
					{
						((Control)dC2.d()).Focus();
					}
				}
			}
			a(false);
		}

		internal Point A(object P_0)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			Point result = default(Point);
			if (P_0 == null || ((TabControl)this).SelectedTab == null || ((Control)BMa[((TabControl)this).SelectedIndex]).ContextMenuStrip == null)
			{
				((Point)(ref result)).X = 0;
				((Point)(ref result)).Y = 0;
			}
			else
			{
				Rectangle bounds = ((Control)((Control)BMa[((TabControl)this).SelectedIndex]).ContextMenuStrip).Bounds;
				result = ((Control)this).PointToClient(((Rectangle)(ref bounds)).Location);
				((Point)(ref result)).X = ((Point)(ref result)).X - (((Control)BMa[((TabControl)this).SelectedIndex]).Left + ((Control)((TabControl)this).SelectedTab).Left);
				((Point)(ref result)).Y = ((Point)(ref result)).Y - (((Control)BMa[((TabControl)this).SelectedIndex]).Top + ((Control)((TabControl)this).SelectedTab).Top);
			}
			return result;
		}

		internal DC A(Table P_0, Rectangle P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			DC dC = new DC(BM.Qz, BM.Qn, P_1, true);
			int num = 0;
			if (P_0 != null)
			{
				num = ((Setting)P_0).A();
			}
			((cO)dC).A(num);
			((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)dC);
			((Control)dC).BringToFront();
			dC.F();
			return dC;
		}

		internal void A(object P_0, EventArgs P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz == null)
			{
				return;
			}
			Point val = A(P_0);
			Rectangle val2 = default(Rectangle);
			((Rectangle)(ref val2))._002Ector(((Point)(ref val)).X, ((Point)(ref val)).Y, 500, 300);
			if ((((TabControl)this).SelectedTab as ae).A() == BP.uA)
			{
				SettingOrSpecialObject settingOrSpecialObject = BM.QQ.rL.e();
				if (settingOrSpecialObject != null && !(settingOrSpecialObject is Table))
				{
					settingOrSpecialObject = null;
				}
				A(settingOrSpecialObject as Table, val2);
			}
			else
			{
				int num = By.A((IWin32Window)(object)BM.QQ, BM.Qz);
				if (num != 0)
				{
					Setting setting = BM.Qz.A(num);
					if (setting != null)
					{
						A(setting as Table, val2);
					}
				}
			}
			a(false);
		}

		internal DB a(Table P_0, Rectangle P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			DB dB = new DB(BM.Qz, BM.Qn, P_1, true);
			int num = 0;
			if (P_0 != null)
			{
				num = ((Setting)P_0).A();
			}
			((cO)dB).A(num);
			((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)dB);
			((Control)dB).BringToFront();
			if (P_0 != null)
			{
				A(((TabControl)this).SelectedIndex, ((Setting)P_0).A());
			}
			return dB;
		}

		internal void a(object P_0, EventArgs P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz == null)
			{
				return;
			}
			Point val = A(P_0);
			Rectangle val2 = default(Rectangle);
			((Rectangle)(ref val2))._002Ector(((Point)(ref val)).X, ((Point)(ref val)).Y, 300, 200);
			if ((((TabControl)this).SelectedTab as ae).A() == BP.uA)
			{
				SettingOrSpecialObject settingOrSpecialObject = BM.QQ.rL.e();
				if (settingOrSpecialObject != null && !(settingOrSpecialObject is Table))
				{
					settingOrSpecialObject = null;
				}
				a(settingOrSpecialObject as Table, val2);
			}
			else
			{
				int num = By.A((IWin32Window)(object)BM.QQ, BM.Qz);
				if (num != 0)
				{
					Setting setting = BM.Qz.A(num);
					if (setting != null)
					{
						a(setting as Table, val2);
					}
				}
			}
			a(false);
		}

		internal Db B(Table P_0, Rectangle P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			Db db = new Db(BM.Qz, BM.Qn, P_1, true);
			int num = 0;
			if (P_0 != null)
			{
				num = ((Setting)P_0).A();
			}
			((cO)db).A(num);
			((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)db);
			((Control)db).BringToFront();
			if (P_0 != null)
			{
				A(((TabControl)this).SelectedIndex, ((Setting)P_0).A());
			}
			return db;
		}

		internal void B(object P_0, EventArgs P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz == null)
			{
				return;
			}
			Point val = A(P_0);
			Rectangle val2 = default(Rectangle);
			((Rectangle)(ref val2))._002Ector(((Point)(ref val)).X, ((Point)(ref val)).Y, 300, 200);
			if ((((TabControl)this).SelectedTab as ae).A() == BP.uA)
			{
				SettingOrSpecialObject settingOrSpecialObject = BM.QQ.rL.e();
				if (settingOrSpecialObject != null && !(settingOrSpecialObject is Table))
				{
					settingOrSpecialObject = null;
				}
				B(settingOrSpecialObject as Table, val2);
			}
			else
			{
				int num = By.A((IWin32Window)(object)BM.QQ, BM.Qz);
				if (num != 0)
				{
					Setting setting = BM.Qz.A(num);
					if (setting != null)
					{
						B(setting as Table, val2);
					}
				}
			}
			a(false);
		}

		internal void b(object P_0, EventArgs P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz == null)
			{
				return;
			}
			Point val = A(P_0);
			Rectangle val2 = default(Rectangle);
			((Rectangle)(ref val2))._002Ector(((Point)(ref val)).X, ((Point)(ref val)).Y, 120, 150);
			if ((((TabControl)this).SelectedTab as ae).A() == BP.uA)
			{
				bool flag = false;
				foreach (Control item in (ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls)
				{
					if (item is cn)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCf(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCG(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else
				{
					SettingOrSpecialObject settingOrSpecialObject = BM.QQ.rL.e();
					if (settingOrSpecialObject != null && !(settingOrSpecialObject is Table))
					{
						settingOrSpecialObject = null;
					}
					cn cn2 = new cn(BM.Qz, val2, true);
					int num = 0;
					if (settingOrSpecialObject != null)
					{
						num = ((Setting)(settingOrSpecialObject as Table)).A();
					}
					cn2.A(num);
					((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cn2);
					((Control)cn2).BringToFront();
				}
			}
			else
			{
				int num2 = By.A((IWin32Window)(object)BM.QQ, BM.Qz);
				if (num2 != 0)
				{
					Setting setting = BM.Qz.A(num2);
					cn cn3 = new cn(BM.Qz, val2, true);
					cn3.A(setting.A());
					((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cn3);
					((Control)cn3).BringToFront();
				}
			}
			a(false);
		}

		internal void C(object P_0, EventArgs P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz != null)
			{
				Point val = A(P_0);
				Rectangle val2 = default(Rectangle);
				((Rectangle)(ref val2))._002Ector(((Point)(ref val)).X, ((Point)(ref val)).Y, 120, 200);
				cJ cJ2 = new cJ(BM.Qz, val2, true);
				((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cJ2);
				((Control)cJ2).BringToFront();
				cJ2.B();
				cJ2.d(null, null);
			}
		}

		internal void c(object P_0, EventArgs P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz != null)
			{
				Point val = A(P_0);
				Rectangle val2 = default(Rectangle);
				((Rectangle)(ref val2))._002Ector(((Point)(ref val)).X, ((Point)(ref val)).Y, 350, 250);
				cm cm2 = new cm(BM.Qz, val2, true);
				((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cm2);
				((Control)cm2).BringToFront();
				((Control)cm2).Invalidate();
				cm2.D(null, null);
			}
		}

		internal void D(object P_0, EventArgs P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz != null)
			{
				Point val = A(P_0);
				Rectangle val2 = default(Rectangle);
				((Rectangle)(ref val2))._002Ector(((Point)(ref val)).X, ((Point)(ref val)).Y, 200, 200);
				cj cj2 = new cj(BM.Qz, val2, true);
				((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cj2);
				((Control)cj2).BringToFront();
				cj2.B();
				cj2.d(null, null);
			}
		}

		internal void d(object P_0, EventArgs P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz != null)
			{
				Point val = A(P_0);
				Rectangle val2 = default(Rectangle);
				((Rectangle)(ref val2))._002Ector(((Point)(ref val)).X, ((Point)(ref val)).Y, 100, 100);
				cK cK2 = new cK(BM.Qz, val2, true);
				((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cK2);
				((Control)cK2).BringToFront();
				cK2.a();
				cK2.c(null, null);
			}
		}

		internal void E(object P_0, EventArgs P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz != null)
			{
				Point val = A(P_0);
				Rectangle val2 = default(Rectangle);
				((Rectangle)(ref val2))._002Ector(((Point)(ref val)).X, ((Point)(ref val)).Y, 200, 100);
				cN cN2 = new cN(BM.Qz, val2, true);
				((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cN2);
				((Control)cN2).BringToFront();
				cN2.a();
				cN2.D(null, null);
			}
		}

		internal void e(object P_0, EventArgs P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz != null)
			{
				Point val = A(P_0);
				Rectangle val2 = default(Rectangle);
				((Rectangle)(ref val2))._002Ector(((Point)(ref val)).X, ((Point)(ref val)).Y, 220, 250);
				cM cM2 = new cM(BM.Qz, val2, true);
				((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cM2);
				((Control)cM2).BringToFront();
				cM2.a();
				cM2.D(null, null);
			}
		}

		internal void F(object P_0, EventArgs P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz != null)
			{
				Point val = A(P_0);
				Rectangle val2 = default(Rectangle);
				((Rectangle)(ref val2))._002Ector(((Point)(ref val)).X, ((Point)(ref val)).Y, 350, 250);
				co co2 = new co(BM.Qz, val2, true);
				((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)co2);
				((Control)co2).BringToFront();
				((Control)co2).Invalidate();
				co2.d(null, null);
			}
		}

		internal void f(object P_0, EventArgs P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz != null)
			{
				Point val = A(P_0);
				Rectangle val2 = default(Rectangle);
				((Rectangle)(ref val2))._002Ector(((Point)(ref val)).X, ((Point)(ref val)).Y, 600, 250);
				cL cL2 = new cL(BM.Qz, val2, true);
				((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cL2);
				((Control)cL2).BringToFront();
				((Control)cL2).Invalidate();
			}
		}

		internal void G(object P_0, EventArgs P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz != null)
			{
				Point val = A(P_0);
				Rectangle val2 = default(Rectangle);
				((Rectangle)(ref val2))._002Ector(((Point)(ref val)).X, ((Point)(ref val)).Y, 600, 140);
				cl cl2 = new cl(BM.Qz, val2, true);
				((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)cl2);
				((Control)cl2).BringToFront();
				((Control)cl2).Invalidate();
			}
		}

		internal void g(object P_0, EventArgs P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			if (BM.Qz != null)
			{
				Point val = A(P_0);
				Rectangle val2 = default(Rectangle);
				((Rectangle)(ref val2))._002Ector(((Point)(ref val)).X, ((Point)(ref val)).Y, 600, 220);
				ck ck2 = new ck(BM.Qz, val2, true);
				((Control)BMa[((TabControl)this).SelectedIndex]).Controls.Add((Control)(object)ck2);
				((Control)ck2).BringToFront();
				((Control)ck2).Invalidate();
			}
		}

		private ContextMenuStrip j()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected O, but got Unknown
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected O, but got Unknown
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Expected O, but got Unknown
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Expected O, but got Unknown
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected O, but got Unknown
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Expected O, but got Unknown
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Expected O, but got Unknown
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Expected O, but got Unknown
			//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected O, but got Unknown
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Expected O, but got Unknown
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Expected O, but got Unknown
			//IL_023b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0242: Expected O, but got Unknown
			//IL_0257: Unknown result type (might be due to invalid IL or missing references)
			//IL_0261: Expected O, but got Unknown
			//IL_026f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0276: Expected O, but got Unknown
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Expected O, but got Unknown
			//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Expected O, but got Unknown
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c9: Expected O, but got Unknown
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f7: Expected O, but got Unknown
			//IL_030c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Expected O, but got Unknown
			//IL_0324: Unknown result type (might be due to invalid IL or missing references)
			//IL_032b: Expected O, but got Unknown
			//IL_0340: Unknown result type (might be due to invalid IL or missing references)
			//IL_034a: Expected O, but got Unknown
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Expected O, but got Unknown
			//IL_039b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a5: Expected O, but got Unknown
			ContextMenuStrip val = new ContextMenuStrip();
			((ToolStripDropDown)val).Opening += new CancelEventHandler(A);
			((ToolStrip)val).BackColor = BM.tG;
			((ToolStrip)val).ForeColor = BM.te;
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCg();
			((ToolStripItem)val2).Click += new EventHandler(K);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
			ToolStripMenuItem val3 = new ToolStripMenuItem();
			((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCH();
			((ToolStripItem)val3).Click += new EventHandler(J);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
			((ToolStrip)val).Items.Add((ToolStripItem)new ToolStripSeparator());
			ToolStripMenuItem val4 = new ToolStripMenuItem();
			((ToolStripItem)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCh();
			((ToolStripItem)val4).Click += new EventHandler(A);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val4);
			ToolStripMenuItem val5 = new ToolStripMenuItem();
			((ToolStripItem)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCI();
			((ToolStripItem)val5).Click += new EventHandler(a);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val5);
			ToolStripMenuItem val6 = new ToolStripMenuItem();
			((ToolStripItem)val6).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCi();
			((ToolStripItem)val6).Click += new EventHandler(B);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val6);
			ToolStripMenuItem val7 = new ToolStripMenuItem();
			((ToolStripItem)val7).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCJ();
			((ToolStripItem)val7).Click += new EventHandler(b);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val7);
			ToolStripMenuItem val8 = new ToolStripMenuItem();
			((ToolStripItem)val8).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCj();
			((ToolStripItem)val8).Click += new EventHandler(C);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val8);
			ToolStripMenuItem val9 = new ToolStripMenuItem();
			((ToolStripItem)val9).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCK();
			((ToolStripItem)val9).Click += new EventHandler(c);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val9);
			ToolStripMenuItem val10 = new ToolStripMenuItem();
			((ToolStripItem)val10).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCk();
			((ToolStripItem)val10).Click += new EventHandler(D);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val10);
			ToolStripMenuItem val11 = new ToolStripMenuItem();
			((ToolStripItem)val11).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAx();
			((ToolStripItem)val11).Click += new EventHandler(d);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val11);
			ToolStripMenuItem val12 = new ToolStripMenuItem();
			((ToolStripItem)val12).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCL();
			((ToolStripItem)val12).Click += new EventHandler(e);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val12);
			ToolStripMenuItem val13 = new ToolStripMenuItem();
			((ToolStripItem)val13).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCl();
			((ToolStripItem)val13).Click += new EventHandler(E);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val13);
			ToolStripMenuItem val14 = new ToolStripMenuItem();
			((ToolStripItem)val14).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAm();
			((ToolStripItem)val14).Click += new EventHandler(F);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val14);
			if (BM.Qz != null && BM.Qz.awO != null)
			{
				ToolStripMenuItem val15 = new ToolStripMenuItem();
				((ToolStripItem)val15).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCM();
				((ToolStripItem)val15).Click += new EventHandler(f);
				((ToolStrip)val).Items.Add((ToolStripItem)(object)val15);
				ToolStripMenuItem val16 = new ToolStripMenuItem();
				((ToolStripItem)val16).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCm();
				((ToolStripItem)val16).Click += new EventHandler(G);
				((ToolStrip)val).Items.Add((ToolStripItem)(object)val16);
				if (BM.Qz.awO.DataIdsOfAngleBucketChannels != null && BM.Qz.awO.DataIdsOfAngleBucketChannels.Count != 0)
				{
					ToolStripMenuItem val17 = new ToolStripMenuItem();
					((ToolStripItem)val17).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ey();
					((ToolStripItem)val17).Click += new EventHandler(g);
					((ToolStrip)val).Items.Add((ToolStripItem)(object)val17);
				}
			}
			return val;
		}

		private void A(object P_0, CancelEventArgs P_1)
		{
			ContextMenuStrip val = (ContextMenuStrip)((P_0 is ContextMenuStrip) ? P_0 : null);
			if (((TabControl)this).TabPages[((TabControl)this).SelectedIndex] is ae && (((TabControl)this).TabPages[((TabControl)this).SelectedIndex] as ae).B())
			{
				foreach (object item in (ArrangedElementCollection)((ToolStrip)val).Items)
				{
					ToolStripMenuItem val2 = (ToolStripMenuItem)((item is ToolStripMenuItem) ? item : null);
					if (val2 != null)
					{
						if (((ToolStripItem)val2).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCH() || ((ToolStripItem)val2).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCN())
						{
							((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCN();
						}
						else
						{
							((ToolStripItem)val2).Enabled = false;
						}
					}
				}
				return;
			}
			foreach (object item2 in (ArrangedElementCollection)((ToolStrip)val).Items)
			{
				ToolStripMenuItem val3 = (ToolStripMenuItem)((item2 is ToolStripMenuItem) ? item2 : null);
				if (val3 != null)
				{
					if (((ToolStripItem)val3).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCH() || ((ToolStripItem)val3).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCN())
					{
						((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCH();
					}
					else
					{
						((ToolStripItem)val3).Enabled = true;
					}
				}
			}
		}

		private void H(object P_0, EventArgs P_1)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Invalid comparison between Unknown and I4
			if ((int)((Form)BlY).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				if (BlY.b())
				{
					h(null, null);
					return;
				}
				if (!string.IsNullOrEmpty(BlY.B()))
				{
					A(BlY.B());
					return;
				}
				A(BlY.A(), BlY.a(), true);
				a(false);
			}
			else if (((TabControl)this).SelectedIndex == ((TabControl)this).TabCount - 1)
			{
				C();
			}
		}

		private void A(string P_0)
		{
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Invalid comparison between Unknown and I4
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			bool flag = false;
			try
			{
				StreamReader val = File.OpenText(P_0);
				try
				{
					string text;
					while ((text = ((TextReader)val).ReadLine()) != null)
					{
						if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbg()))
						{
							if (text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bbg().Length).Equals(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qa()))
							{
								flag = true;
							}
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			catch
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCn(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if (flag)
			{
				if ((int)bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCO(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48, (MessageBoxDefaultButton)256, new string[2]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCo(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCP()
				}) == 6)
				{
					MovableResizablePanel movableResizablePanel = new MovableResizablePanel(new Rectangle(0, 0, 800, 600), true, false, false);
					BlZ[0] = (Panel)(object)movableResizablePanel;
					while (((ArrangedElementCollection)((Control)BMa[0]).Controls).Count != 0)
					{
						q.A(((Control)BMa[0]).Controls[0]);
					}
					((Control)BMa[0]).Controls.Add((Control)(object)movableResizablePanel);
					int num = 0;
					A(P_0, num, true, true);
				}
				else
				{
					int num2 = ((TabControl)this).TabCount - 1;
					A(P_0, num2, true, true);
				}
			}
			else
			{
				int num3 = ((TabControl)this).TabCount - 1;
				A(P_0, num3, true, true);
			}
			a(false);
		}

		private void h(object P_0, EventArgs P_1)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Invalid comparison between Unknown and I4
			if (!Directory.Exists(BlX))
			{
				Directory.CreateDirectory(BlX);
			}
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCp();
			((FileDialog)val).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCQ();
			((FileDialog)val).InitialDirectory = BlX;
			DialogResult val2 = ((CommonDialog)val).ShowDialog((IWin32Window)(object)BM.QQ);
			((Component)val).Dispose();
			if ((int)val2 == 1)
			{
				A(((FileDialog)val).FileName);
			}
			else if (((TabControl)this).SelectedIndex == ((TabControl)this).TabCount - 1)
			{
				C();
			}
		}

		private void I(object P_0, EventArgs P_1)
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Invalid comparison between Unknown and I4
			if (!Directory.Exists(BlX))
			{
				Directory.CreateDirectory(BlX);
			}
			int num = (int)((Control)BMb).Tag;
			string text = ((Control)((TabControl)this).TabPages[num]).Text;
			SaveFileDialog val = new SaveFileDialog();
			((FileDialog)val).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCq();
			((FileDialog)val).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCR();
			((FileDialog)val).InitialDirectory = BlX;
			((FileDialog)val).FileName = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbG();
			if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				((Stream)File.Create(((FileDialog)val).FileName)).Close();
				File.SetAttributes(((FileDialog)val).FileName, (FileAttributes)128);
				A(((FileDialog)val).FileName, num);
			}
			((Component)val).Dispose();
		}

		private void i(object P_0, EventArgs P_1)
		{
			b((int)((Control)BMb).Tag);
		}

		private void J(object P_0, EventArgs P_1)
		{
			b(((TabControl)this).SelectedIndex);
		}

		private void b(int P_0)
		{
			if (P_0 != ((TabControl)this).TabPages.Count - 1 && ((TabControl)this).TabPages[P_0] is ae ae)
			{
				ae.a(!ae.B());
				((Control)this).Invalidate();
				a(false);
			}
		}

		private void j(object P_0, EventArgs P_1)
		{
			A((int)((Control)BMb).Tag, true);
		}

		private void K(object P_0, EventArgs P_1)
		{
			A(((TabControl)this).SelectedIndex, true);
		}

		private void k(object P_0, EventArgs P_1)
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Invalid comparison between Unknown and I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected O, but got Unknown
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected O, but got Unknown
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Expected O, but got Unknown
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected O, but got Unknown
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected O, but got Unknown
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Expected O, but got Unknown
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Expected O, but got Unknown
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Expected O, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected O, but got Unknown
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Expected O, but got Unknown
			int num = (int)((Control)BMb).Tag;
			TabPage val = ((TabControl)this).TabPages[num];
			if ((int)bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCr() + ((Control)val).Text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ws(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) != 6)
			{
				return;
			}
			foreach (ToolStripItem item in (ArrangedElementCollection)((ToolStrip)((Control)BMa[num]).ContextMenuStrip).Items)
			{
				item.Click -= new EventHandler(K);
				item.Click -= new EventHandler(J);
				item.Click -= new EventHandler(A);
				item.Click -= new EventHandler(a);
				item.Click -= new EventHandler(B);
				item.Click -= new EventHandler(b);
				item.Click -= new EventHandler(C);
				item.Click -= new EventHandler(c);
				item.Click -= new EventHandler(D);
				item.Click -= new EventHandler(d);
				item.Click -= new EventHandler(e);
				item.Click -= new EventHandler(E);
				item.Click -= new EventHandler(F);
				item.Click -= new EventHandler(f);
				item.Click -= new EventHandler(G);
				item.Click -= new EventHandler(g);
			}
			((ToolStripDropDown)((Control)BMa[num]).ContextMenuStrip).Opening -= new CancelEventHandler(A);
			q.A((Control)(object)val);
			BMa.RemoveAt(num);
			BlZ.RemoveAt(num);
			Blz.RemoveAt(num);
			BMA.RemoveAt(num);
			a(false);
		}

		private void L(object P_0, EventArgs P_1)
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Invalid comparison between Unknown and I4
			int num = (int)((Control)BMb).Tag;
			TabPage val = ((TabControl)this).TabPages[num];
			Bly.A(((Control)val).Text);
			if ((int)((Form)Bly).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				((Control)val).Text = Bly.A();
				a(false);
			}
		}

		private void l(object P_0, EventArgs P_1)
		{
			int num = (int)((Control)BMb).Tag;
			for (int i = 0; i < ((TabControl)this).TabPages.Count - 1; i++)
			{
				if (i == num)
				{
					(((TabControl)this).TabPages[i] as ae).A(true);
				}
				else
				{
					(((TabControl)this).TabPages[i] as ae).A(false);
				}
			}
			((Control)this).Invalidate();
			a(false);
		}

		private void a(int P_0, int P_1)
		{
			if (P_0 == 0 || P_0 == ((TabControl)this).TabPages.Count - 1 || P_1 == 0)
			{
				return;
			}
			TabPage val = ((TabControl)this).TabPages[P_0];
			Panel val2 = BlZ[P_0];
			string text = Blz[P_0];
			int num = BMA[P_0];
			aF aF = BMa[P_0];
			if (P_0 > P_1)
			{
				for (int num2 = P_0; num2 > P_1; num2--)
				{
					((TabControl)this).TabPages[num2] = ((TabControl)this).TabPages[num2 - 1];
					BlZ[num2] = BlZ[num2 - 1];
					Blz[num2] = Blz[num2 - 1];
					BMA[num2] = BMA[num2 - 1];
					BMa[num2] = BMa[num2 - 1];
				}
				((TabControl)this).TabPages[P_1] = val;
				BlZ[P_1] = val2;
				Blz[P_1] = text;
				BMA[P_1] = num;
				BMa[P_1] = aF;
				((TabControl)this).SelectedIndex = P_1;
				a(false);
			}
			else if (P_0 < P_1)
			{
				for (int i = P_0; i < P_1 - 1; i++)
				{
					((TabControl)this).TabPages[i] = ((TabControl)this).TabPages[i + 1];
					BlZ[i] = BlZ[i + 1];
					Blz[i] = Blz[i + 1];
					BMA[i] = BMA[i + 1];
					BMa[i] = BMa[i + 1];
				}
				((TabControl)this).TabPages[P_1 - 1] = val;
				BlZ[P_1 - 1] = val2;
				Blz[P_1 - 1] = text;
				BMA[P_1 - 1] = num;
				BMa[P_1 - 1] = aF;
				((TabControl)this).SelectedIndex = P_1 - 1;
				a(false);
			}
		}

		private ContextMenuStrip K()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected O, but got Unknown
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Expected O, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected O, but got Unknown
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected O, but got Unknown
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Expected O, but got Unknown
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected O, but got Unknown
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected O, but got Unknown
			ContextMenuStrip val = new ContextMenuStrip
			{
				BackColor = BM.tG,
				ForeColor = BM.te
			};
			((ToolStripItem)BMD).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCS();
			((ToolStripItem)BMD).Click += new EventHandler(H);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)BMD);
			((ToolStripItem)BMd).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCs();
			((ToolStripItem)BMd).Click += new EventHandler(k);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)BMd);
			((ToolStripItem)BME).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WP();
			((ToolStripItem)BME).Click += new EventHandler(L);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)BME);
			((ToolStripItem)BMe).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCT();
			((ToolStripItem)BMe).Click += new EventHandler(l);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)BMe);
			((ToolStripItem)BMF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCt();
			((ToolStripItem)BMF).Click += new EventHandler(h);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)BMF);
			((ToolStripItem)BMf).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCU();
			((ToolStripItem)BMf).Click += new EventHandler(I);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)BMf);
			((ToolStripItem)BMG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCg();
			((ToolStripItem)BMG).Click += new EventHandler(j);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)BMG);
			((ToolStripItem)BMg).Click += new EventHandler(i);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)BMg);
			return val;
		}

		private void A(object P_0, MouseEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Invalid comparison between Unknown and I4
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Invalid comparison between Unknown and I4
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Invalid comparison between Unknown and I4
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			if ((int)P_1.Button != 1048576 && (int)P_1.Button != 2097152)
			{
				return;
			}
			Point val = ((Control)this).PointToClient(Control.MousePosition);
			for (int i = 0; i < ((TabControl)this).TabPages.Count; i++)
			{
				Rectangle tabRect = ((TabControl)this).GetTabRect(i);
				if (!((Rectangle)(ref tabRect)).Contains(val))
				{
					continue;
				}
				if ((int)P_1.Button == 2097152)
				{
					ae ae = ((TabControl)this).TabPages[i] as ae;
					bool flag = ae.a();
					bool flag2 = ae.A() == BP.uA;
					((ToolStripItem)BMd).Enabled = i != 0 && i != ((TabControl)this).TabPages.Count - 1 && !flag;
					((ToolStripItem)BME).Enabled = i != 0 && i != ((TabControl)this).TabPages.Count - 1;
					((ToolStripItem)BMf).Enabled = i != ((TabControl)this).TabPages.Count - 1;
					((ToolStripItem)BMe).Enabled = flag2 && !flag && i != ((TabControl)this).TabPages.Count - 1;
					((ToolStripItem)BMG).Enabled = !ae.B() && i != ((TabControl)this).TabPages.Count - 1;
					if (i != ((TabControl)this).TabPages.Count - 1)
					{
						((ToolStripItem)BMg).Enabled = true;
						if (ae.B())
						{
							((ToolStripItem)BMg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCN();
						}
						else
						{
							((ToolStripItem)BMg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCH();
						}
					}
					else
					{
						((ToolStripItem)BMg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCH();
						((ToolStripItem)BMg).Enabled = false;
					}
					((Control)BMb).Tag = i;
					((ToolStripDropDown)BMb).Show((Control)(object)((TabControl)this).TabPages[i], val);
					break;
				}
				if ((int)P_1.Button == 1048576)
				{
					if (i != 0 && i != ((TabControl)this).TabPages.Count - 1)
					{
						BMC = i;
						Kb = i;
					}
					break;
				}
			}
		}

		private void a(object P_0, MouseEventArgs P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Invalid comparison between Unknown and I4
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			if (BMC == -1 || (int)P_1.Button != 1048576)
			{
				return;
			}
			Point val = ((Control)this).PointToClient(Control.MousePosition);
			for (int i = 1; i < ((TabControl)this).TabPages.Count; i++)
			{
				Rectangle tabRect = ((TabControl)this).GetTabRect(i);
				if (((Rectangle)(ref tabRect)).Contains(val))
				{
					Kb = i;
					break;
				}
			}
			if (Kb != BMc)
			{
				((Control)this).Invalidate();
				BMc = Kb;
			}
		}

		private void B(object P_0, MouseEventArgs P_1)
		{
			if (BMC != -1 && Kb != -1)
			{
				if (BMC != Kb)
				{
					a(BMC, Kb);
				}
				((Control)this).Invalidate();
			}
			BMC = -1;
			Kb = -1;
			BMc = -1;
		}

		protected override void OnResize(EventArgs e)
		{
			((TabControl)this).OnResize(e);
			k();
		}

		internal void k()
		{
			if (BMa.Count != 0 && ((TabControl)this).SelectedIndex != -1)
			{
				for (int i = 0; i < ((TabControl)this).TabPages.Count - 1; i++)
				{
					aF aF = BMa[i];
					((Control)aF).Width = ((Control)((TabControl)this).SelectedTab).Width;
					((Control)aF).Height = ((Control)((TabControl)this).SelectedTab).Height;
				}
			}
		}

		internal void A(int P_0, bool P_1)
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			if (P_0 < 0 || BMa.Count <= P_0)
			{
				return;
			}
			aF aF = BMa[P_0];
			if (aF == null)
			{
				return;
			}
			Point autoScrollPosition = ((ScrollableControl)aF).AutoScrollPosition;
			int x = ((Point)(ref autoScrollPosition)).X;
			autoScrollPosition = ((ScrollableControl)aF).AutoScrollPosition;
			int y = ((Point)(ref autoScrollPosition)).Y;
			int num = 0;
			int num2 = 0;
			foreach (Control item in (ArrangedElementCollection)((Control)aF).Controls)
			{
				Control val = item;
				num = Math.Max(num, val.Right - x);
				num2 = Math.Max(num2, val.Bottom - y);
			}
			int num3 = ((Control)aF).Width - 10;
			int num4 = ((Control)aF).Height - 10;
			int num5 = 0;
			int num6 = 0;
			Size val2 = BMB[P_0];
			bool flag;
			if (((Size)(ref val2)).Width != 0)
			{
				val2 = BMB[P_0];
				if (((Size)(ref val2)).Height != 0 && !P_1)
				{
					val2 = BMB[P_0];
					num5 = ((Size)(ref val2)).Width - 20;
					val2 = BMB[P_0];
					num6 = ((Size)(ref val2)).Height - 20;
					flag = true;
					goto IL_013f;
				}
			}
			num5 = num;
			num6 = num2;
			flag = false;
			goto IL_013f;
			IL_013f:
			int num7 = 0;
			int num8 = 0;
			if ((float)num5 / (float)num3 > (float)num6 / (float)num4)
			{
				if (num5 <= num3 && num5 >= num3 - 30)
				{
					return;
				}
				num7 = num3;
				num8 = num5 + 30;
			}
			else
			{
				if (num6 <= num4 && num6 >= num4 - 30)
				{
					return;
				}
				num7 = num4;
				num8 = num6 + 30;
			}
			if (flag && num8 > num7 && num < num3 - 10 && num2 < num4 - 10)
			{
				return;
			}
			((Control)aF).SuspendLayout();
			for (int i = 0; i < ((ArrangedElementCollection)((Control)aF).Controls).Count; i++)
			{
				Control val3 = ((Control)aF).Controls[i];
				val3.SuspendLayout();
				int left = val3.Left;
				int top = val3.Top;
				int right = val3.Right;
				int bottom = val3.Bottom;
				int num9 = (left - x) * num7 / num8;
				val3.Left = num9 + x;
				int num10 = (top - y) * num7 / num8;
				val3.Top = num10 + y;
				int num11 = (right - x) * num7 / num8;
				val3.Width = num11 + x - (num9 + x);
				int num12 = (bottom - y) * num7 / num8;
				val3.Height = num12 + y - (num10 + y);
				val3.ResumeLayout(true);
				if (val3 is MovableResizablePanel)
				{
					(val3 as MovableResizablePanel).UpdateLayout(resizingOnly: true);
				}
				val3.Invalidate();
			}
			((Control)aF).ResumeLayout(true);
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Invalid comparison between Unknown and I4
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Invalid comparison between Unknown and I4
			if (BMa.Count != 0 && ((TabControl)this).SelectedIndex >= 0)
			{
				foreach (Control item in (ArrangedElementCollection)((Control)BMa[((TabControl)this).SelectedIndex]).Controls)
				{
					Control val = item;
					if (val is DC)
					{
						if (val.ContainsFocus && (val as DC).A(e))
						{
							return;
						}
					}
					else if (val is Db)
					{
						if (val.ContainsFocus && (val as Db).A(e))
						{
							return;
						}
					}
					else if (val is DB)
					{
						if (val.ContainsFocus && (val as DB).A(e))
						{
							return;
						}
					}
					else if (val is cP && val.ContainsFocus && (val as cP).A(e))
					{
						return;
					}
				}
				if (((e.KeyData & 0x21) == 33 || (e.KeyData & 0x22) == 34) && q.A((Form)(object)BM.QQ, e.KeyData))
				{
					return;
				}
			}
			((TabControl)this).OnKeyDown(e);
		}
	}
	internal class cr : MovableResizablePanel, Y
	{
		private new delegate void A(object P_0, EventArgs P_1);

		private new delegate void a(object P_0, EventArgs P_1);

		private new delegate void B();

		private const int BML = 48;

		private const int BMl = 17;

		private const int BMM = 30;

		private const int BMm = 260;

		private Framework BMN;

		private Framework BMn;

		private MenuNode BMO;

		private SensorCalibration BMo;

		private Setting BMP;

		private Setting BMp;

		private Setting BMQ;

		private Setting BMq;

		private Setting BMR;

		private Setting BMr;

		private DataGridViewWithThemedScrollBars BMS = new DataGridViewWithThemedScrollBars();

		private X BMs;

		private ThemedButton BMT = new ThemedButton();

		private ThemedButton BMt = new ThemedButton();

		private ThemedButton BMU = new ThemedButton();

		private ThemedButton BMu = new ThemedButton();

		private ThemedButton BMV = new ThemedButton();

		private Label BMv = new Label();

		private Label BMW = new Label();

		private Label BMw;

		private List<string> BMX = new List<string>();

		private bool BMx;

		private bool BMY;

		private MenuNode BMy;

		private Cn BMZ;

		private bool BMz;

		private int[] BmA;

		private int[] Bma;

		private int BmB;

		private ToolStripMenuItem Bmb = new ToolStripMenuItem();

		private ToolStripMenuItem BmC = new ToolStripMenuItem();

		private ToolStripMenuItem Bmc = new ToolStripMenuItem();

		private string BmD = string.Empty;

		internal cr(SensorCalibration P_0, MenuNode P_1, Framework P_2, Framework P_3, Rectangle P_4, bool P_5)
			: base(P_4, P_5, false, false)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected O, but got Unknown
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Expected O, but got Unknown
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0379: Unknown result type (might be due to invalid IL or missing references)
			//IL_0383: Expected O, but got Unknown
			//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0400: Expected O, but got Unknown
			//IL_0494: Unknown result type (might be due to invalid IL or missing references)
			//IL_049e: Expected O, but got Unknown
			//IL_051c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0526: Expected O, but got Unknown
			//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ba: Expected O, but got Unknown
			//IL_062e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0630: Unknown result type (might be due to invalid IL or missing references)
			//IL_0724: Unknown result type (might be due to invalid IL or missing references)
			//IL_073f: Unknown result type (might be due to invalid IL or missing references)
			//IL_075a: Unknown result type (might be due to invalid IL or missing references)
			//IL_076f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0784: Unknown result type (might be due to invalid IL or missing references)
			//IL_079b: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a5: Expected O, but got Unknown
			//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bc: Expected O, but got Unknown
			//IL_0815: Unknown result type (might be due to invalid IL or missing references)
			//IL_081a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a25: Expected O, but got Unknown
			//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3b: Expected O, but got Unknown
			//IL_0a48: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a52: Expected O, but got Unknown
			//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a69: Expected O, but got Unknown
			//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a80: Expected O, but got Unknown
			//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a97: Expected O, but got Unknown
			//IL_0897: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a1: Expected O, but got Unknown
			//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b49: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c86: Unknown result type (might be due to invalid IL or missing references)
			//IL_0988: Unknown result type (might be due to invalid IL or missing references)
			//IL_0992: Expected O, but got Unknown
			//IL_099b: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a5: Expected O, but got Unknown
			BMN = P_2;
			BMn = P_3;
			BMO = P_1;
			BMo = P_0;
			BMP = P_0.CalibrationValuesSetting;
			BMp = P_0.CalibrationVoltagesSetting;
			BMQ = P_0.CalibrationValueCountSetting;
			if (BMn != null)
			{
				BMq = BMn.A(BMP.A());
				BMR = BMn.A(BMp.A());
				BMr = BMn.A(BMQ.A());
			}
			B();
			BMx = BMN.B() && BMN.b() && BMP.J();
			BMY = BMn != null && BMn.B() && BMn.b() && BMq != null && BMq.J();
			if ((BM.QO != BM.b.BpG || BMn == null) ? BMx : BMY)
			{
				Label val = new Label();
				((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCW();
				((Control)val).ForeColor = BM.te;
				((Control)val).BackColor = Color.Transparent;
				((Control)val).AutoSize = true;
				((Control)val).Left = 10;
				((Control)val).Top = 10;
				((Control)this).Controls.Add((Control)(object)val);
				((Control)this).Width = ((Control)val).Right + 10;
				return;
			}
			if (BMP == null || BMp == null || BMQ == null || ((BM.QO != BM.b.BpG || BMn == null) && (!((SettingOrSpecialObject)BMP).l() || !((SettingOrSpecialObject)BMp).l())) || (BM.QO == BM.b.BpG && BMn != null && BMq != null && BMR != null && (!((SettingOrSpecialObject)BMq).l() || !((SettingOrSpecialObject)BMR).l())))
			{
				Label val2 = new Label();
				((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCw();
				((Control)val2).ForeColor = BM.te;
				((Control)val2).BackColor = Color.Transparent;
				((Control)val2).AutoSize = true;
				((Control)val2).Left = 10;
				((Control)val2).Top = 10;
				((Control)this).Controls.Add((Control)(object)val2);
				((Control)this).Width = ((Control)val2).Right + 10;
				((Control)this).Height = ((Control)val2).Bottom + 10;
				return;
			}
			((Control)BMT).Visible = BMZ == null || !BMz;
			((Control)BMT).Enabled = BMN.C();
			((Control)BMT).AutoSize = true;
			((Control)BMT).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.UJ();
			((Control)BMT).Click += new EventHandler(g);
			((Control)BMT).Left = 10;
			((Control)BMT).Top = 10;
			((Control)this).Controls.Add((Control)(object)BMT);
			((Control)BMt).Visible = BMZ == null || !BMz;
			((Control)BMt).AutoSize = true;
			((Control)BMt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCX();
			((Control)BMt).Click += new EventHandler(H);
			((Control)BMt).Left = ((Control)BMT).Right + 5;
			((Control)BMt).Top = 10;
			((Control)this).Controls.Add((Control)(object)BMt);
			((Control)BMU).Visible = BMZ == null || !BMz;
			((Control)BMU).Enabled = BMN.C();
			((Control)BMU).AutoSize = true;
			((Control)BMU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCx();
			((Control)BMU).Click += new EventHandler(G);
			((Control)BMU).Left = ((Control)BMt).Right + 5;
			((Control)BMU).Top = 10;
			((Control)this).Controls.Add((Control)(object)BMU);
			((Control)BMu).Visible = BMZ == null || !BMz;
			((Control)BMu).AutoSize = true;
			((Control)BMu).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCY();
			((Control)BMu).Click += new EventHandler(f);
			((Control)BMu).Enabled = false;
			((Control)BMu).Left = ((Control)BMU).Right + 5;
			((Control)BMu).Top = 10;
			((Control)this).Controls.Add((Control)(object)BMu);
			((Control)BMV).Visible = BMZ == null || !BMz;
			((Control)BMV).AutoSize = true;
			((Control)BMV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCy();
			((Control)BMV).Click += new EventHandler(F);
			((Control)BMV).Enabled = false;
			((Control)BMV).Left = ((Control)BMu).Right + 5;
			((Control)BMV).Top = 10;
			((Control)this).Controls.Add((Control)(object)BMV);
			((Control)BMS).Left = 10;
			((Control)BMS).Top = ((Control)BMV).Bottom + 5;
			((Control)BMS).Height = 60;
			if (P_4 == Rectangle.Empty)
			{
				((Control)this).Width = Math.Max(600, ((Control)BMV).Right + 10);
			}
			((Control)BMS).Width = ((Control)this).Width - 20;
			((DataGridView)BMS).ColumnHeadersVisible = false;
			((DataGridView)BMS).RowHeadersVisible = true;
			((DataGridView)BMS).RowHeadersWidth = 72;
			((Control)BMS).Visible = BMZ == null || !BMz;
			((DataGridView)BMS).AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)1;
			((DataGridView)BMS).AutoSizeRowsMode = (DataGridViewAutoSizeRowsMode)0;
			((DataGridView)BMS).AllowUserToAddRows = false;
			((DataGridView)BMS).AllowUserToDeleteRows = false;
			((DataGridView)BMS).AllowUserToResizeRows = false;
			((DataGridView)BMS).AllowUserToOrderColumns = false;
			((DataGridView)BMS).AllowUserToResizeColumns = false;
			((DataGridView)BMS).ReadOnly = true;
			((DataGridView)BMS).EnableHeadersVisualStyles = false;
			((DataGridView)BMS).BackgroundColor = BM.ti;
			((DataGridView)BMS).ColumnHeadersDefaultCellStyle.BackColor = ((DataGridView)BMS).BackgroundColor;
			((DataGridView)BMS).RowHeadersDefaultCellStyle.BackColor = ((DataGridView)BMS).BackgroundColor;
			((DataGridView)BMS).ColumnHeadersDefaultCellStyle.ForeColor = BM.te;
			((DataGridView)BMS).RowHeadersDefaultCellStyle.ForeColor = BM.te;
			((Control)BMS).KeyDown += new KeyEventHandler(A);
			((DataGridView)BMS).SelectionChanged += new EventHandler(e);
			typeof(DataGridViewWithThemedScrollBars).InvokeMember(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HG(), (BindingFlags)8228, (Binder)null, (object)BMS, new object[1] { true });
			if (BMN.C())
			{
				((Control)BMS).ContextMenuStrip = C();
			}
			Enumerator<SettingOrSpecialObject> enumerator = ((SettingOrSpecialObject)P_0).D().a().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					SettingOrSpecialObject current = enumerator.Current;
					if (!(current is Dn))
					{
						continue;
					}
					Dn dn = current as Dn;
					int num = dn.ax();
					Cg cg2 = PortFunction.A((uint)num);
					CH cH2 = PortFunction.a((uint)num);
					byte b = PortFunction.B((uint)num);
					ushort num2 = PortFunction.b((uint)num);
					SettingOrSpecialObject settingOrSpecialObject = PortFunction.A(BMN, cg2, cH2, b, num2);
					if (settingOrSpecialObject != null && settingOrSpecialObject.F().b().Count != 0)
					{
						BMw = new Label();
						((Control)BMw).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ft();
						((Control)BMw).ForeColor = BM.te;
						((Control)BMw).Tag = new SettingOrSpecialObject[2] { settingOrSpecialObject, dn };
						((Control)BMw).AutoSize = false;
						((Control)BMw).Left = 10;
						((Control)BMw).Width = ((Control)this).Width - 20;
						((Control)BMw).Height = (int)((float)((Control)BMw).Height * 0.7f);
						if (((Control)BMS).Visible)
						{
							((Control)BMw).Top = ((Control)BMS).Bottom + 8;
						}
						else
						{
							((Control)BMw).Top = 8;
						}
						BMX.Clear();
						for (int i = 0; i < settingOrSpecialObject.F().b().Count; i++)
						{
							Setting setting = settingOrSpecialObject.F().b()[i];
							setting.a(new EventHandler(C));
							setting.A(new EventHandler(C));
							int num3 = setting.aS();
							BMX.Add(bS.A(setting.@as(), num3, false, 0));
						}
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			global::A.A.A((global::A.D)this.b);
			BM.D(new EventHandler(this.b));
			BM.QQ.B(new EventHandler(B));
			BMP.A(new EventHandler(c));
			BMp.A(new EventHandler(D));
			BMQ.A(new EventHandler(d));
			((SettingOrSpecialObject)BMQ).A(new EventHandler(E));
			if (BM.QO == BM.b.BpG && BMR != null && BMq != null && BMr != null)
			{
				BMs = new X(BMn, BMS, BMR, BMq, BMr);
			}
			else
			{
				BMs = new X(BMN, BMS, BMp, BMP, BMQ);
			}
			((Control)BMs).Left = 10;
			((Control)BMs).Top = ((Control)BMS).Bottom + 30;
			((Control)BMs).Width = ((Control)BMS).Width;
			if (P_4 == Rectangle.Empty)
			{
				if (((Control)BMS).Visible)
				{
					((Control)BMs).Height = 260;
					((Control)this).Height = ((Control)BMs).Bottom + 10;
				}
				else
				{
					((Control)this).Height = 30;
				}
			}
			else if (((Control)BMS).Visible)
			{
				((Control)BMs).Height = ((Control)this).Height - 10 - ((Control)BMs).Top;
			}
			((Control)this).Controls.Add((Control)(object)BMS);
			if (BMw != null)
			{
				((Control)this).Controls.Add((Control)(object)BMw);
			}
			((Control)this).Controls.Add((Control)(object)BMs);
			((Control)BMW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCZ();
			((Control)BMW).ForeColor = BM.tD;
			((Control)BMW).AutoSize = true;
			((Control)BMW).Left = ((Control)BMS).Left + 10;
			((Control)BMW).Top = ((Control)BMS).Top + 41;
			((Control)BMW).Visible = false;
			((Control)this).Controls.Add((Control)(object)BMW);
			((Control)BMW).BringToFront();
			((Control)BMv).ForeColor = BM.tC;
			((Control)BMv).AutoSize = true;
			((Control)BMv).Visible = false;
			((Control)this).Controls.Add((Control)(object)BMv);
			((Control)BMv).BringToFront();
			((Control)BMS).Enabled = BMN.C();
			((Control)BMs).Visible = ((Control)BMS).Visible;
		}

		protected override void Dispose(bool disposing)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected O, but got Unknown
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Expected O, but got Unknown
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected O, but got Unknown
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Expected O, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected O, but got Unknown
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected O, but got Unknown
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Expected O, but got Unknown
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Expected O, but got Unknown
			try
			{
				((Control)BMS).KeyDown -= new KeyEventHandler(A);
				((DataGridView)BMS).SelectionChanged -= new EventHandler(e);
				((ToolStripItem)Bmb).Click -= new EventHandler(F);
				((ToolStripItem)BmC).Click -= new EventHandler(f);
				((ToolStripItem)Bmc).Click -= new EventHandler(G);
				if (BMP != null)
				{
					BMP.a(new EventHandler(c));
				}
				if (BMp != null)
				{
					BMp.a(new EventHandler(D));
				}
				if (BMQ != null)
				{
					BMQ.a(new EventHandler(d));
					((SettingOrSpecialObject)BMQ).a(new EventHandler(E));
				}
				((Control)BMT).Click -= new EventHandler(g);
				((Control)BMt).Click -= new EventHandler(H);
				((Control)BMU).Click -= new EventHandler(G);
				((Control)BMu).Click -= new EventHandler(f);
				((Control)BMV).Click -= new EventHandler(F);
				if (BMw != null)
				{
					SettingOrSpecialObject settingOrSpecialObject = (((Control)BMw).Tag as SettingOrSpecialObject[])[0];
					for (int i = 0; i < settingOrSpecialObject.F().b().Count; i++)
					{
						settingOrSpecialObject.F().b()[i].a(new EventHandler(C));
					}
				}
				global::A.A.a((global::A.D)b);
				BM.d(new EventHandler(b));
				BM.QQ.b(new EventHandler(B));
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		public Control A(DataIdAndAttrId P_0)
		{
			if (((Control)BMS).Visible && ((Control)this).Controls.Contains((Control)(object)BMS) && ((BMP != null && P_0.DataId == BMP.A()) || (BMp != null && P_0.DataId == BMp.A())))
			{
				return (Control)(object)BMS;
			}
			return null;
		}

		public Control A()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (!(val is Label))
				{
					return val;
				}
			}
			return null;
		}

		private new void B()
		{
			BMy = BMO.A(BMP);
			if (BMy != null)
			{
				BMZ = BMy.Y().BcF;
				BMz = BMy.z();
			}
			if (BMZ == null)
			{
				return;
			}
			int[] array = BMZ.a(BMQ);
			if (array != null && array.Length == 1)
			{
				int[] array2 = BMZ.a(BMP);
				int[] array3 = BMZ.a(BMp);
				if (array2 != null && array2.Length == BMP.Ba() && array3 != null && array3.Length == BMp.Ba())
				{
					BmA = array2;
					Bma = array3;
					BmB = array[0];
				}
				else
				{
					BMZ = null;
				}
			}
			else
			{
				BMZ = null;
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			b();
		}

		private void b(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					A a = b;
					((Control)this).BeginInvoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			if ((!BM.A(BMN.aXc, true) || BM.aE()) && BMw != null)
			{
				((Control)BMw).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ft();
			}
		}

		private void C(object P_0, EventArgs P_1)
		{
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			if (!base.B() || BM.QO == BM.b.BpG)
			{
				return;
			}
			if (((Control)this).InvokeRequired)
			{
				try
				{
					a a = C;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			Setting setting = P_0 as Setting;
			SettingOrSpecialObject settingOrSpecialObject = ((((SettingOrSpecialObject)setting).F().E().BSQ != Cg.BAM) ? ((SettingOrSpecialObject)setting).D() : setting);
			if ((((Control)BMw).Tag as SettingOrSpecialObject[])[0] != settingOrSpecialObject)
			{
				return;
			}
			bool flag = false;
			for (int i = 0; i < settingOrSpecialObject.F().b().Count; i++)
			{
				if (BM.C(settingOrSpecialObject.F().b()[i].A()))
				{
					flag = true;
					break;
				}
			}
			if ((!BM.A(BMN.aXc, true) || BM.aE()) && !flag)
			{
				((Control)BMw).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ft();
				return;
			}
			StringBuilder val = new StringBuilder();
			for (int j = 0; j < settingOrSpecialObject.F().b().Count; j++)
			{
				Setting setting2 = settingOrSpecialObject.F().b()[j];
				if (!((SettingOrSpecialObject)setting2).l() || !PortFunction.A(setting2))
				{
					continue;
				}
				ValueTuple<string, string, bool> val2 = setting2.aX();
				string text = ((SettingOrSpecialObject)setting2).A(bz.aYu);
				if (!string.IsNullOrEmpty(text))
				{
					val.Append(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FZ());
				}
				val.Append(val2.Item1);
				if (!string.IsNullOrEmpty(val2.Item2))
				{
					if (BMX[j] == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IX())
					{
						val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ix());
					}
					else
					{
						val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + BMX[j]);
					}
				}
				val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IY());
			}
			string text2 = ((SettingOrSpecialObject)BMo).H();
			string text3 = (string.IsNullOrWhiteSpace(text2) ? ((SettingOrSpecialObject)BMo).A(bz.aYt) : text2);
			if (!string.IsNullOrEmpty(text3))
			{
				ValueTuple<string, string, bool> val3 = BMo.aX();
				val.Append(text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FZ() + val3.Item1);
				if (!string.IsNullOrEmpty(val3.Item2))
				{
					val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + val3.Item2);
				}
			}
			((Control)BMw).Text = ((object)val).ToString();
		}

		public override void UpdateLayout(bool resizingOnly)
		{
			if (!((BM.QO != BM.b.BpG || BMn == null) ? BMx : BMY))
			{
				((Control)BMS).Width = ((Control)this).Width - 20;
				((Control)BMs).Width = ((Control)BMS).Width;
				((Control)BMs).Height = ((Control)this).Height - 10 - ((Control)BMs).Top;
				b();
			}
		}

		internal new void b()
		{
			//IL_0571: Unknown result type (might be due to invalid IL or missing references)
			//IL_057b: Expected O, but got Unknown
			//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b8: Expected O, but got Unknown
			//IL_050b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0515: Expected O, but got Unknown
			//IL_053e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0548: Expected O, but got Unknown
			((Control)BMS).Enabled = BMN.C();
			if ((BM.QO != BM.b.BpG || BMn == null) ? BMx : BMY)
			{
				return;
			}
			Setting setting;
			Setting setting2;
			Setting setting3;
			if (BM.QO == BM.b.BpG)
			{
				setting = BMq;
				setting2 = BMR;
				setting3 = BMr;
			}
			else
			{
				setting = BMP;
				setting2 = BMp;
				setting3 = BMQ;
			}
			if (setting == null || setting2 == null || setting3 == null || !((SettingOrSpecialObject)setting).l() || !((SettingOrSpecialObject)setting2).l())
			{
				return;
			}
			if (((Control)this).InvokeRequired)
			{
				try
				{
					B b = this.b;
					((Control)this).Invoke((System.Delegate)b);
					return;
				}
				catch
				{
					return;
				}
			}
			int num = setting3.ax();
			if (num == 0)
			{
				((DataGridView)BMS).Columns.Clear();
				((DataGridView)BMS).Rows.Clear();
				((Control)BMS).Visible = BMZ == null || !BMz;
				((DataGridView)BMS).ColumnCount = 0;
				BMS.C();
				if (BMs != null)
				{
					((Control)BMs).Visible = ((Control)BMS).Visible;
					((Control)BMs).Invalidate();
				}
				if ((BMZ != null && BMz) || setting3.O() || setting3.o().Count == 0)
				{
					((Control)BMv).Visible = false;
					return;
				}
				((Control)BMv).Left = ((Control)BMS).Left + 10;
				((Control)BMv).Top = ((Control)BMS).Top + 10;
				((Control)BMv).Text = setting3.o()[0];
				((Control)BMv).Visible = true;
				return;
			}
			((Control)this).SuspendLayout();
			((Control)BMW).Visible = (BMZ == null || !BMz) && !BMx && !BMY && BMq != null && BMR != null && BMr != null && (!BMP.A(BMq) || !BMp.A(BMR) || !BMQ.A(BMr));
			bool[,] array = new bool[2, num];
			for (int i = 0; i < num; i++)
			{
				if (((DataGridView)BMS).Rows.Count == 0 || i >= ((BaseCollection)((DataGridView)BMS).Rows[0].Cells).Count)
				{
					array[0, i] = false;
					array[1, i] = false;
				}
				else
				{
					array[0, i] = ((DataGridView)BMS).Rows[0].Cells[i].Selected;
					array[1, i] = ((DataGridView)BMS).Rows[1].Cells[i].Selected;
				}
			}
			int num2 = 0;
			int num3 = 0;
			if (((DataGridView)BMS).CurrentCell != null)
			{
				num2 = ((DataGridView)BMS).CurrentCell.ColumnIndex;
				num3 = ((DataGridView)BMS).CurrentCell.RowIndex;
			}
			((DataGridView)BMS).Columns.Clear();
			((DataGridView)BMS).Rows.Clear();
			((Control)BMS).Visible = BMZ == null || !BMz;
			((DataGridView)BMS).ColumnCount = num;
			int num4 = setting2.aS();
			int num5 = setting.aS();
			string[] array2 = new string[num];
			string[] array3 = new string[num];
			for (int j = 0; j < num; j++)
			{
				string text = bS.a(setting2.m(j), num4, -1);
				array2[j] = text;
				string text2 = bS.a(setting.m(j), num5, -1);
				array3[j] = text2;
			}
			DataGridViewRowCollection rows = ((DataGridView)BMS).Rows;
			object[] array4 = array2;
			rows.Add(array4);
			DataGridViewRowCollection rows2 = ((DataGridView)BMS).Rows;
			array4 = array3;
			rows2.Add(array4);
			for (int k = 0; k < num; k++)
			{
				((DataGridView)BMS).Columns[k].Width = 48;
				if (BMZ != null && BMy.aa() && Bma != null && BmA != null)
				{
					if (k >= BmB)
					{
						((DataGridViewBand)((DataGridView)BMS).Columns[k]).DefaultCellStyle.Font = new Font(((Control)this).Font.FontFamily, 8f, (FontStyle)2);
					}
					else if (setting2.m(k) != Bma[k] || setting.m(k) != BmA[k])
					{
						((DataGridViewBand)((DataGridView)BMS).Columns[k]).DefaultCellStyle.Font = new Font(((Control)this).Font.FontFamily, 8f, (FontStyle)2);
					}
					else
					{
						((DataGridViewBand)((DataGridView)BMS).Columns[k]).DefaultCellStyle.Font = new Font(((Control)this).Font.FontFamily, 8f);
					}
				}
				else
				{
					((DataGridViewBand)((DataGridView)BMS).Columns[k]).DefaultCellStyle.Font = new Font(((Control)this).Font.FontFamily, 8f);
				}
			}
			((DataGridView)BMS).Rows[0].Height = 17;
			((DataGridView)BMS).Rows[1].Height = 17;
			((DataGridViewCell)((DataGridView)BMS).Rows[0].HeaderCell).Value = bS.A(setting2.@as(), num4, false, 0);
			((DataGridViewCell)((DataGridView)BMS).Rows[1].HeaderCell).Value = bS.A(setting.@as(), num5, false, 0);
			if (num2 < ((BaseCollection)((DataGridView)BMS).Rows[num3].Cells).Count)
			{
				((DataGridView)BMS).CurrentCell = ((DataGridView)BMS).Rows[num3].Cells[num2];
			}
			else
			{
				((DataGridView)BMS).CurrentCell = ((DataGridView)BMS).Rows[num3].Cells[((BaseCollection)((DataGridView)BMS).Rows[num3].Cells).Count - 1];
			}
			for (int l = 0; l < num; l++)
			{
				((DataGridView)BMS).Rows[0].Cells[l].Selected = array[0, l];
				((DataGridView)BMS).Rows[1].Cells[l].Selected = array[1, l];
			}
			if (((DataGridView)BMS).SelectedCells != null && ((BaseCollection)((DataGridView)BMS).SelectedCells).Count != 0)
			{
				((ToolStripItem)BmC).Enabled = BMN.C() && setting3.ax() != 0;
				((Control)BMu).Enabled = ((ToolStripItem)BmC).Enabled;
			}
			else
			{
				((ToolStripItem)BmC).Enabled = false;
				((Control)BMu).Enabled = false;
			}
			((Control)this).ResumeLayout(true);
			if (BMs != null)
			{
				((Control)BMs).Visible = ((Control)BMS).Visible;
				((Control)BMs).Invalidate();
			}
			BMS.C();
			if ((BMZ != null && BMz) || setting3.O() || setting3.o().Count == 0)
			{
				((Control)BMv).Visible = false;
				return;
			}
			if (((Control)BMS).Visible)
			{
				((Control)BMv).Left = ((Control)BMS).Left + ((DataGridView)BMS).RowHeadersWidth + ((DataGridView)BMS).ColumnCount * 48 + 10;
				((Control)BMv).Top = ((Control)BMS).Top + 10;
			}
			else
			{
				((Control)BMv).Left = ((Control)BMS).Left + 10;
				((Control)BMv).Top = ((Control)BMS).Top + 10;
			}
			((Control)BMv).Text = setting3.o()[0];
			((Control)BMv).Visible = true;
		}

		private void c(object P_0, EventArgs P_1)
		{
			b();
			BM.b(BMP.A());
			BM.b(BMp.A());
			BM.b(BMQ.A());
		}

		private void D(object P_0, EventArgs P_1)
		{
			b();
			BM.b(BMP.A());
			BM.b(BMp.A());
			BM.b(BMQ.A());
		}

		private void d(object P_0, EventArgs P_1)
		{
			b();
			BM.b(BMP.A());
			BM.b(BMp.A());
			BM.b(BMQ.A());
		}

		private void E(object P_0, EventArgs P_1)
		{
			b();
		}

		private void e(object P_0, EventArgs P_1)
		{
			((Control)BMs).Invalidate();
			if (BmD != string.Empty)
			{
				BmD = string.Empty;
				b();
			}
			if (((DataGridView)BMS).SelectedCells != null && ((BaseCollection)((DataGridView)BMS).SelectedCells).Count != 0)
			{
				((ToolStripItem)Bmb).Enabled = BMN.C();
				((Control)BMV).Enabled = ((ToolStripItem)Bmb).Enabled;
				((ToolStripItem)BmC).Enabled = BMN.C() && BMQ.ax() != 0;
				((Control)BMu).Enabled = ((ToolStripItem)BmC).Enabled;
			}
			else
			{
				((ToolStripItem)Bmb).Enabled = false;
				((Control)BMV).Enabled = false;
				((ToolStripItem)BmC).Enabled = false;
				((Control)BMu).Enabled = false;
			}
		}

		private ContextMenuStrip C()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			ContextMenuStrip val = new ContextMenuStrip
			{
				BackColor = BM.tG,
				ForeColor = BM.te
			};
			((ToolStripItem)Bmb).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCy();
			((ToolStripItem)Bmb).Enabled = false;
			((ToolStripItem)Bmb).Click += new EventHandler(F);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)Bmb);
			((ToolStripItem)BmC).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCY();
			((ToolStripItem)BmC).Enabled = false;
			((ToolStripItem)BmC).Click += new EventHandler(f);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)BmC);
			((ToolStripItem)Bmc).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCx();
			((ToolStripItem)Bmc).Click += new EventHandler(G);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)Bmc);
			return val;
		}

		private void F(object P_0, EventArgs P_1)
		{
			if (BM.QO == BM.b.BpG || !BMN.C())
			{
				return;
			}
			int num = BMQ.ax();
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < num; i++)
			{
				if (((DataGridView)BMS).Rows[0].Cells[i].Selected)
				{
					flag = true;
				}
				if (((DataGridView)BMS).Rows[1].Cells[i].Selected)
				{
					flag2 = true;
				}
			}
			Ck ck2 = BM.aM();
			ck2?.A(BMP.A());
			if (flag)
			{
				BMp.az();
				A(((DataGridView)BMS).SelectedCells[0].ColumnIndex, ((DataGridView)BMS).SelectedCells[((BaseCollection)((DataGridView)BMS).SelectedCells).Count - 1].ColumnIndex);
				BMp.i(true);
			}
			if (flag2)
			{
				BMP.az();
				a(((DataGridView)BMS).SelectedCells[0].ColumnIndex, ((DataGridView)BMS).SelectedCells[((BaseCollection)((DataGridView)BMS).SelectedCells).Count - 1].ColumnIndex);
				BMP.i(true);
			}
			ck2?.B();
		}

		private new void A(int P_0, int P_1)
		{
			if (BM.QO == BM.b.BpG || !BMN.C())
			{
				return;
			}
			int num = Math.Max(P_0, P_1);
			int num2 = Math.Min(P_0, P_1);
			int num3 = num - num2 + 1;
			if (num3 > 1)
			{
				int num4 = BMp.m(num2);
				int num5 = (BMp.m(num) - num4) / (num3 - 1);
				for (int i = 1; i < num3 - 1; i++)
				{
					BMp.a(num2 + i, num4 + i * num5, true);
				}
			}
		}

		private new void a(int P_0, int P_1)
		{
			if (BM.QO == BM.b.BpG || !BMN.C())
			{
				return;
			}
			int num = Math.Max(P_0, P_1);
			int num2 = Math.Min(P_0, P_1);
			int num3 = num - num2 + 1;
			int num4 = BMP.m(num) - BMP.m(num2);
			int num5 = BMp.m(num) - BMp.m(num2);
			if (num5 != 0)
			{
				float num6 = (float)num4 / (float)num5;
				int num7 = BMP.m(num2) - (int)Math.Round((double)(num6 * (float)BMp.m(num2)));
				for (int i = 1; i < num3 - 1; i++)
				{
					int num8 = BMp.m(num2 + i);
					int num9 = (int)Math.Round((double)(num6 * (float)num8 + (float)num7));
					BMP.a(num2 + i, num9, true);
				}
			}
		}

		private List<int> c()
		{
			List<int> val = new List<int>();
			for (int i = 0; i < ((BaseCollection)((DataGridView)BMS).Rows[0].Cells).Count; i++)
			{
				bool flag = false;
				for (int j = 0; j < 2; j++)
				{
					if (((DataGridView)BMS).Rows[j].Cells[i].Selected)
					{
						flag = true;
					}
				}
				if (flag)
				{
					val.Add(i);
				}
			}
			return val;
		}

		private void a(int P_0)
		{
			if (BM.QO != BM.b.BpG && BMN.C())
			{
				int num = BMQ.ax();
				for (int i = P_0 + 1; i < num; i++)
				{
					BMp.a(i - 1, BMp.m(i), true);
					BMP.a(i - 1, BMP.m(i), true);
				}
				BMQ.a(num - 1, true);
			}
		}

		private void f(object P_0, EventArgs P_1)
		{
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Invalid comparison between Unknown and I4
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Invalid comparison between Unknown and I4
			if (BM.QO == BM.b.BpG || !BMN.C() || BMQ.ax() == 0 || ((DataGridView)BMS).SelectedCells == null || ((BaseCollection)((DataGridView)BMS).SelectedCells).Count == 0)
			{
				return;
			}
			List<int> obj = c();
			int num = obj[0];
			int count = obj.Count;
			int num2 = BMp.aS();
			string text = bS.a(BMp.m(num), num2, -1);
			if (count == 1)
			{
				if ((int)bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCz(), (object)text), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
				{
					Ck ck2 = BM.aM();
					ck2?.A(BMP.A());
					BMp.az();
					BMP.az();
					BMQ.az();
					for (int i = 0; i < count; i++)
					{
						a(num);
					}
					BMp.i(true);
					BMP.i(true);
					BMQ.i(true);
					ck2?.B();
				}
				return;
			}
			string text2 = bS.a(BMp.m(num + count - 1), num2, -1);
			if ((int)bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcA(), (object)text, (object)text2), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				Ck ck3 = BM.aM();
				ck3?.A(BMP.A());
				BMp.az();
				BMP.az();
				BMQ.az();
				for (int j = 0; j < count; j++)
				{
					a(num);
				}
				BMp.i(true);
				BMP.i(true);
				BMQ.i(true);
				ck3?.B();
			}
		}

		private void G(object P_0, EventArgs P_1)
		{
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Invalid comparison between Unknown and I4
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			if (BM.QO == BM.b.BpG || !BMN.C())
			{
				return;
			}
			int num = BMQ.ax();
			if (num == BMP.av()[2])
			{
				bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bca(), (object)num), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			int num2 = BMp.aS();
			int num3 = BMp.@as();
			int num4 = BMp.aR();
			int num5 = BMp.ar();
			BG bG = new BG(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BCx(), (Keys)0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay(), num2, num3, num4, num5, num4, num5, null);
			if ((int)((Form)bG).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				int num6 = bS.A(bG.A(), num2);
				int num7 = 0;
				for (int num8 = num - 1; num8 >= 0; num8--)
				{
					int num9 = BMp.m(num8);
					if (num6 > num9)
					{
						num7 = num8 + 1;
						break;
					}
				}
				Ck ck2 = BM.aM();
				ck2?.A(BMP.A());
				BMp.az();
				BMP.az();
				BMQ.az();
				for (int num10 = BMQ.ax() - 1; num10 >= num7; num10--)
				{
					BMp.a(num10 + 1, BMp.m(num10), true);
					BMP.a(num10 + 1, BMP.m(num10), true);
				}
				BMp.a(num7, num6, true);
				if (num7 == 0)
				{
					BMP.a(0, BMP.m(1), true);
				}
				else if (num7 == num)
				{
					BMP.a(num7, BMP.m(num7 - 1), true);
				}
				else
				{
					a(num7 - 1, num7 + 1);
				}
				BMQ.a(BMQ.ax() + 1, true);
				BMp.i(true);
				BMP.i(true);
				BMQ.i(true);
				ck2?.B();
			}
			((Component)bG).Dispose();
		}

		private void D()
		{
			if (BM.QO == BM.b.BpG || !(BmD != string.Empty))
			{
				return;
			}
			for (int i = 0; i < BMQ.ax(); i++)
			{
				if (((DataGridView)BMS).Rows[0].Cells[i].Selected)
				{
					((DataGridView)BMS).Rows[0].Cells[i].Value = BmD;
				}
				else if (((DataGridView)BMS).Rows[1].Cells[i].Selected)
				{
					((DataGridView)BMS).Rows[1].Cells[i].Value = BmD;
				}
			}
		}

		private void A(object P_0, KeyEventArgs P_1)
		{
			//IL_077b: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Invalid comparison between Unknown and I4
			//IL_0815: Unknown result type (might be due to invalid IL or missing references)
			//IL_081c: Invalid comparison between Unknown and I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Invalid comparison between Unknown and I4
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Invalid comparison between Unknown and I4
			//IL_032c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0332: Invalid comparison between Unknown and I4
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Invalid comparison between Unknown and I4
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0384: Invalid comparison between Unknown and I4
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Invalid comparison between Unknown and I4
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Invalid comparison between Unknown and I4
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a4: Invalid comparison between Unknown and I4
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Invalid comparison between Unknown and I4
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Invalid comparison between Unknown and I4
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected I4, but got Unknown
			//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e0: Invalid comparison between Unknown and I4
			//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ae: Invalid comparison between Unknown and I4
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Invalid comparison between Unknown and I4
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected I4, but got Unknown
			//IL_0415: Unknown result type (might be due to invalid IL or missing references)
			//IL_041c: Invalid comparison between Unknown and I4
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ea: Invalid comparison between Unknown and I4
			//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c2: Expected I4, but got Unknown
			//IL_0444: Unknown result type (might be due to invalid IL or missing references)
			//IL_044e: Invalid comparison between Unknown and I4
			//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fe: Expected I4, but got Unknown
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Invalid comparison between Unknown and I4
			//IL_048a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0494: Invalid comparison between Unknown and I4
			//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d7: Invalid comparison between Unknown and I4
			//IL_04da: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e1: Invalid comparison between Unknown and I4
			//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04eb: Invalid comparison between Unknown and I4
			//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f5: Invalid comparison between Unknown and I4
			//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ff: Invalid comparison between Unknown and I4
			//IL_0502: Unknown result type (might be due to invalid IL or missing references)
			//IL_0509: Invalid comparison between Unknown and I4
			if (BM.QO == BM.b.BpG || !BMN.C() || ((DataGridView)BMS).SelectedCells == null || ((BaseCollection)((DataGridView)BMS).SelectedCells).Count == 0)
			{
				return;
			}
			if ((int)P_1.KeyData == 46)
			{
				f(null, null);
				return;
			}
			if ((int)P_1.KeyData == 45)
			{
				G(null, null);
				return;
			}
			if ((int)P_1.KeyData == 76)
			{
				F(null, null);
				return;
			}
			int num = BMQ.ax();
			int num2 = -1;
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < num; i++)
			{
				if (((DataGridView)BMS).Rows[0].Cells[i].Selected)
				{
					if (flag)
					{
						return;
					}
					num2 = i;
					flag = true;
				}
				if (((DataGridView)BMS).Rows[1].Cells[i].Selected)
				{
					flag2 = true;
				}
			}
			Setting setting;
			if (flag && !flag2)
			{
				setting = BMp;
			}
			else
			{
				if (!flag2 || flag)
				{
					return;
				}
				setting = BMP;
			}
			if (BmD == string.Empty)
			{
				if ((int)P_1.KeyCode >= 48 && (int)P_1.KeyCode <= 57)
				{
					BmD = (P_1.KeyCode - 48).ToString();
				}
				else if ((int)P_1.KeyCode >= 96 && (int)P_1.KeyCode <= 105)
				{
					BmD = (P_1.KeyCode - 96).ToString();
				}
				else if ((int)P_1.KeyCode == 189 || (int)P_1.KeyCode == 109)
				{
					BmD = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo();
				}
				else if (P_1.Control && (int)P_1.KeyCode == 86)
				{
					Ck ck2 = BM.aM();
					ck2?.A(BMP.A());
					try
					{
						if (Clipboard.ContainsText())
						{
							string text = Clipboard.GetText();
							int num3 = text.Split('\n', (StringSplitOptions)0)[0].Split('\t', (StringSplitOptions)0).Length;
							int num4 = setting.aR();
							int num5 = setting.ar();
							int num6 = 0;
							for (int j = 0; j < num; j++)
							{
								if (((DataGridView)BMS).Rows[0].Cells[j].Selected || ((DataGridView)BMS).Rows[1].Cells[j].Selected)
								{
									num6 = j;
									break;
								}
							}
							int num7 = Math.Min(num, num6 + num3) - 1;
							setting.az();
							for (int k = num6; k <= num7; k++)
							{
								string text2 = text.Split('\n', (StringSplitOptions)0)[0].Split('\t', (StringSplitOptions)0)[k - num6];
								if (text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VU()))
								{
									text2 = text2.Substring(0, text2.Length - 1);
								}
								int num8 = bS.A(text2, setting.aS());
								num8 = Math.Min(Math.Max(num8, num4), num5);
								setting.a(k, num8, true);
							}
							setting.i(true);
						}
					}
					catch
					{
					}
					ck2?.B();
				}
			}
			else if ((int)P_1.KeyCode == 8)
			{
				if (BmD.Length == 1)
				{
					BmD = string.Empty;
					b();
				}
				else
				{
					BmD = BmD.Substring(0, BmD.Length - 1);
				}
			}
			else if ((int)P_1.KeyCode == 27)
			{
				BmD = string.Empty;
				b();
			}
			else if ((int)P_1.KeyCode >= 48 && (int)P_1.KeyCode <= 57)
			{
				BmD += P_1.KeyCode - 48;
			}
			else if ((int)P_1.KeyCode >= 96 && (int)P_1.KeyCode <= 105)
			{
				BmD += P_1.KeyCode - 96;
			}
			else if ((int)P_1.KeyCode == 110)
			{
				BmD += CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			}
			else if ((int)P_1.KeyCode == 190)
			{
				if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq())
				{
					BmD += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq();
				}
			}
			else if ((int)P_1.KeyCode == 188)
			{
				if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ())
				{
					BmD += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ();
				}
			}
			else if ((int)P_1.KeyCode == 13 || (int)P_1.KeyCode == 9 || (int)P_1.KeyCode == 37 || (int)P_1.KeyCode == 39 || (int)P_1.KeyCode == 38 || (int)P_1.KeyCode == 40)
			{
				Ck ck3 = BM.aM();
				ck3?.A(BMP.A());
				int num9 = setting.aR();
				int num10 = setting.ar();
				int num11 = setting.aS();
				bool flag3 = false;
				try
				{
					int num12 = bS.A(BmD, num11);
					if ((num9 != 0 || num10 != 0) && (num12 < num9 || num12 > num10))
					{
						throw new System.Exception();
					}
					double num13 = double.Parse(BmD, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture);
					if (flag && num >= 2)
					{
						if (((DataGridView)BMS).Rows[0].Cells[0].Selected)
						{
							if (num13 > double.Parse((string)((DataGridView)BMS).Rows[0].Cells[1].Value, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture))
							{
								flag3 = true;
								throw new System.Exception();
							}
						}
						else if (((DataGridView)BMS).Rows[0].Cells[num - 1].Selected)
						{
							if (num13 < double.Parse((string)((DataGridView)BMS).Rows[0].Cells[num - 2].Value, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture))
							{
								flag3 = true;
								throw new System.Exception();
							}
						}
						else if (num >= 3 && (num13 > double.Parse((string)((DataGridView)BMS).Rows[0].Cells[num2 + 1].Value, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture) || num13 < double.Parse((string)((DataGridView)BMS).Rows[0].Cells[num2 - 1].Value, (NumberStyles)511, (IFormatProvider)(object)CultureInfo.CurrentCulture)))
						{
							flag3 = true;
							throw new System.Exception();
						}
					}
					int num14 = bS.A(num13, num11);
					for (int l = 0; l < num; l++)
					{
						if (((DataGridView)BMS).Rows[0].Cells[l].Selected || ((DataGridView)BMS).Rows[1].Cells[l].Selected)
						{
							setting.a(l, num14, true);
						}
					}
				}
				catch (System.Exception)
				{
					if (flag3)
					{
						bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcB(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else if (num9 != 0 || num10 != 0)
					{
						string text3 = bS.a(num9, num11, -1);
						string text4 = bS.a(num10, num11, -1);
						bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ke(), (object)BmD, (object)text3, (object)text4), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else
					{
						bE.A((IWin32Window)(object)BM.QQ, string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcb(), (object)BmD), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
				ck3?.B();
				P_1.Handled = true;
				BmD = string.Empty;
				b();
				if ((int)P_1.KeyCode == 9)
				{
					P_1.Handled = false;
				}
			}
			D();
		}

		private void g(object P_0, EventArgs P_1)
		{
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Invalid comparison between Unknown and I4
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0421: Unknown result type (might be due to invalid IL or missing references)
			if (BM.QO == BM.b.BpG || !BMN.C())
			{
				return;
			}
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcC();
			((FileDialog)val).InitialDirectory = BM.QX;
			if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				StreamReader val2 = new StreamReader((Stream)new FileStream(((FileDialog)val).FileName, (FileMode)3, (FileAccess)1));
				string[] array = null;
				try
				{
					if (((TextReader)val2).ReadLine() != D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcc())
					{
						bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcD(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						((TextReader)val2).Close();
						((Component)val).Dispose();
						return;
					}
				}
				catch
				{
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcD(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					((TextReader)val2).Close();
					((Component)val).Dispose();
					return;
				}
				int[] array2 = new int[BMp.av()[2]];
				int[] array3 = new int[BMP.av()[2]];
				int num = 0;
				int num2 = 3;
				int num3 = 7;
				bool flag = true;
				while (!val2.EndOfStream)
				{
					string[] array4 = null;
					int num4 = 0;
					string[] array5 = ((TextReader)val2).ReadLine().Trim().Split(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo().ToCharArray());
					if (array5.Length == 2)
					{
						array5[0] = array5[0].Trim();
						array5[1] = array5[1].Trim();
						array = array5;
					}
					else
					{
						array = new string[0];
					}
					if (array.Length == 0)
					{
						continue;
					}
					string text = array[0];
					if (!(text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcd()))
					{
						if (!(text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gd()))
						{
							if (!(text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcE()))
							{
								if (text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bce() && !int.TryParse(array[1], ref num2))
								{
									flag = false;
								}
							}
							else if (!int.TryParse(array[1], ref num3))
							{
								flag = false;
							}
							continue;
						}
						num4 = 0;
						array4 = array[1].Split(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ().ToCharArray());
						for (int i = 0; i < array4.Length && i < BMP.av()[2]; i++)
						{
							int num5 = 0;
							if (int.TryParse(array4[i], ref num5))
							{
								array3[i] = num5;
							}
							num4++;
						}
						if (num4 != num)
						{
							flag = false;
						}
						continue;
					}
					num4 = 0;
					array4 = array[1].Split(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ().ToCharArray());
					for (int j = 0; j < array4.Length && j < BMp.av()[2]; j++)
					{
						int num6 = 0;
						if (int.TryParse(array4[j], ref num6))
						{
							array2[j] = num6;
						}
						num4++;
					}
					num = num4;
				}
				if (flag && num != 0)
				{
					if (BMP.aS() != num2)
					{
						for (int k = 0; k < array3.Length; k++)
						{
							double num7 = bS.A(array3[k], num2, -1);
							array3[k] = bS.A(num7, BMP.aS());
						}
					}
					if (BMp.aS() != num3)
					{
						for (int l = 0; l < array2.Length; l++)
						{
							double num8 = bS.A(array2[l], num3, -1);
							array2[l] = bS.A(num8, BMp.aS());
						}
					}
					Ck ck2 = BM.aM();
					ck2?.A(BMP.A());
					BMp.az();
					BMP.az();
					BMQ.az();
					for (int m = 0; m < BMp.av()[2]; m++)
					{
						if (m < num)
						{
							BMp.a(m, array2[m], true);
							BMP.a(m, array3[m], true);
						}
						else
						{
							BMp.a(m, 0, true);
							BMP.a(m, 0, true);
						}
					}
					BMQ.a(num, true);
					BMp.i(true);
					BMP.i(true);
					BMQ.i(true);
					ck2?.B();
				}
				else
				{
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcD(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				((TextReader)val2).Close();
			}
			((Component)val).Dispose();
		}

		private void H(object P_0, EventArgs P_1)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Invalid comparison between Unknown and I4
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			if (BM.QO == BM.b.BpG)
			{
				return;
			}
			SaveFileDialog val = new SaveFileDialog();
			((FileDialog)val).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcC();
			((FileDialog)val).InitialDirectory = BM.QX;
			if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				StreamWriter val2 = new StreamWriter((Stream)new FileStream(((FileDialog)val).FileName, (FileMode)2, (FileAccess)2));
				((TextWriter)val2).WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcc());
				((TextWriter)val2).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jz(), (object)0));
				((TextWriter)val2).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcF(), (object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DP()));
				((TextWriter)val2).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcf(), (object)BMp.aS()));
				((TextWriter)val2).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcG(), (object)BMP.aS()));
				int num = BMQ.ax();
				string text = string.Empty;
				if (num > 0)
				{
					text = BMp.m(0).ToString();
				}
				for (int i = 1; i < num; i++)
				{
					text = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bR(), (object)text, (object)BMp.m(i));
				}
				((TextWriter)val2).WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcg() + text);
				string text2 = string.Empty;
				if (num > 0)
				{
					text2 = BMP.m(0).ToString();
				}
				for (int j = 1; j < num; j++)
				{
					text2 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bR(), (object)text2, (object)BMP.m(j));
				}
				((TextWriter)val2).WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcH() + text2);
				((TextWriter)val2).Close();
			}
			((Component)val).Dispose();
		}
	}
}
namespace C
{
	internal class CR
	{
		private string Bcn;

		private Framework BcO;

		private bool Bco;

		internal CR(string P_0, Framework P_1, bool P_2)
		{
			Bcn = P_0;
			BcO = P_1;
			Bco = P_2;
		}

		internal void A()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0320: Unknown result type (might be due to invalid IL or missing references)
			//IL_0327: Expected O, but got Unknown
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0330: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_02af: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
			MemoryStream val = new MemoryStream();
			XmlWriterSettings val2 = new XmlWriterSettings();
			val2.ConformanceLevel = (ConformanceLevel)2;
			val2.CloseOutput = false;
			val2.Indent = true;
			val2.NewLineChars = Environment.NewLine;
			XmlWriter val3 = XmlWriter.Create((Stream)(object)val, val2);
			byte[] array = null;
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awc());
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGX());
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGx());
			array = Encoding.ASCII.GetBytes(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awU());
			val3.WriteBinHex(array, 0, array.Length);
			val3.WriteEndElement();
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGY());
			byte[] array2 = BcO.h();
			MD5 val4 = MD5.Create();
			try
			{
				string text = n.A(((HashAlgorithm)val4).ComputeHash(array2));
				array = Encoding.ASCII.GetBytes(text);
				val3.WriteBinHex(array, 0, array.Length);
			}
			finally
			{
				((System.IDisposable)val4)?.Dispose();
			}
			val3.WriteEndElement();
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZH());
			val3.WriteString(BcO.aXc);
			val3.WriteEndElement();
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGy());
			byte[] array3 = new byte[4] { 0, 0, 0, 4 };
			val3.WriteBinHex(array3, 0, array3.Length);
			val3.WriteEndElement();
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGZ());
			val3.WriteBinHex(BcO.F(), 0, BcO.F().Length);
			val3.WriteEndElement();
			Enumerator<Setting> enumerator = BcO.aWu.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					val3.WriteStartElement(current.s());
					val3.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP(), current.A().ToString());
					val3.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWx(), current.B().ToString());
					byte[] array4 = current.aY();
					byte[] array5 = (BcO.aWR ? array4 : N.A(array4, current.aG()));
					val3.WriteBinHex(array5, 0, array5.Length);
					val3.WriteEndElement();
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			val3.WriteEndElement();
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hh());
			A(val3, BcO.aWS);
			val3.WriteEndElement();
			val3.WriteEndElement();
			val3.Close();
			((Stream)val).Flush();
			if (Bco)
			{
				List<KeyValuePair<string, byte[]>> val5 = a();
				List<KeyValuePair<string, byte[]>> val6 = B();
				KeyValuePair<string, byte[]>[] array6 = new KeyValuePair<string, byte[]>[1 + val5.Count + val6.Count];
				array6[0] = new KeyValuePair<string, byte[]>(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGw(), val.ToArray());
				for (int i = 0; i < val5.Count; i++)
				{
					KeyValuePair<string, byte[]> val7 = val5[i];
					array6[1 + i] = val7;
				}
				for (int j = 0; j < val6.Count; j++)
				{
					KeyValuePair<string, byte[]> val8 = val6[j];
					array6[1 + val5.Count + j] = val8;
				}
				R.A(Bcn, M.A(), true, array6);
			}
			else
			{
				StreamWriter val9 = new StreamWriter(Bcn);
				try
				{
					((Stream)val).Position = 0L;
					string text2 = ((TextReader)new StreamReader((Stream)(object)val)).ReadToEnd();
					((TextWriter)val9).Write(text2);
				}
				finally
				{
					((System.IDisposable)val9)?.Dispose();
				}
			}
			((Stream)val).Close();
		}

		private void A(XmlWriter P_0, List<SettingOrSpecialObject> P_1)
		{
			for (int i = 0; i < P_1.Count; i++)
			{
				SettingOrSpecialObject settingOrSpecialObject = P_1[i];
				A(P_0, settingOrSpecialObject.a());
				if (settingOrSpecialObject is Setting)
				{
					Setting setting = settingOrSpecialObject as Setting;
					if (setting.s().Length == 0 && setting.aI())
					{
						P_0.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGi());
						P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP(), setting.A().ToString());
						P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWx(), setting.B().ToString());
						byte[] array = setting.aY();
						byte[] array2 = (BcO.aWR ? array : N.A(array, setting.aG()));
						P_0.WriteBinHex(array2, 0, array2.Length);
						P_0.WriteEndElement();
					}
				}
			}
		}

		private List<KeyValuePair<string, byte[]>> a()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			List<KeyValuePair<string, byte[]>> val = new List<KeyValuePair<string, byte[]>>();
			List<string> val2 = new List<string>();
			Enumerator<int, MenuNode> enumerator = BcO.awX.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					MenuNode current = enumerator.Current;
					if (current.Y() != null && current.Y().BcF != null && !string.IsNullOrEmpty(current.Y().Bcf) && current.Y().Bcf.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sU()))
					{
						val2.Add(current.Y().Bcf);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<string> enumerator2 = val2.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					string current2 = enumerator2.Current;
					try
					{
						string fileName = Path.GetFileName(current2);
						bool flag = false;
						Enumerator<KeyValuePair<string, byte[]>> enumerator3 = val.GetEnumerator();
						try
						{
							while (enumerator3.MoveNext())
							{
								if (enumerator3.Current.Key == fileName)
								{
									flag = true;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator3).Dispose();
						}
						if (!flag)
						{
							byte[] array = File.ReadAllBytes(current2);
							val.Add(new KeyValuePair<string, byte[]>(fileName, array));
						}
					}
					catch
					{
					}
				}
				return val;
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
		}

		private List<KeyValuePair<string, byte[]>> B()
		{
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			List<KeyValuePair<string, byte[]>> val = new List<KeyValuePair<string, byte[]>>();
			if (BcO.awv.Count != 0 && Directory.Exists(BM.Qu))
			{
				string[] array = null;
				try
				{
					array = Directory.GetDirectories(BM.Qu);
				}
				catch (System.Exception ex)
				{
					array = null;
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awu() + BM.Qu + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TT() + ex.Message, true);
				}
				if (array != null)
				{
					string[] array2 = array;
					foreach (string text in array2)
					{
						string[] array3 = null;
						try
						{
							array3 = Directory.GetFiles(text);
						}
						catch (System.Exception ex2)
						{
							array3 = null;
							N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awV() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TT() + ex2.Message, true);
						}
						if (array3 == null)
						{
							continue;
						}
						string[] array4 = array3;
						foreach (string text2 in array4)
						{
							try
							{
								byte[] array5 = File.ReadAllBytes(text2);
								string name = ((FileSystemInfo)new DirectoryInfo(text)).Name;
								string fileName = Path.GetFileName(text2);
								string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWz() + name + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK() + fileName;
								val.Add(new KeyValuePair<string, byte[]>(text3, array5));
							}
							catch (System.Exception ex3)
							{
								N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awv() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TT() + ex3.Message, true);
							}
						}
					}
				}
			}
			return val;
		}
	}
	internal class Cr
	{
		[CompilerGenerated]
		private static class A
		{
			public static ProgressChangedEventHandler Bss;
		}

		[CompilerGenerated]
		private sealed class a
		{
			public FileInfo BsT;

			internal void A()
			{
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEQ() + ((FileSystemInfo)BsT).Name + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FC());
			}
		}

		internal string BcP;

		internal bool Bcp;

		internal k BcQ;

		private Dictionary<int, int> Bcq;

		private Dictionary<int, List<int>> BcR;

		internal Cr(string P_0, bool P_1, k P_2, Dictionary<int, int> P_3, Dictionary<int, List<int>> P_4)
		{
			BcP = P_0;
			Bcp = P_1;
			BcQ = P_2;
			Bcq = P_3;
			BcR = P_4;
		}

		internal void A()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected O, but got Unknown
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Expected O, but got Unknown
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected O, but got Unknown
			DirectoryInfo val = new DirectoryInfo(BcP);
			if (((FileSystemInfo)val).Exists)
			{
				string text = ((FileSystemInfo)val.Parent).FullName + ((((FileSystemInfo)val.Parent).FullName.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()) || ((FileSystemInfo)val.Parent).FullName.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj())) ? string.Empty : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()) + ((FileSystemInfo)val).Name + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awW();
				if (!Directory.Exists(text))
				{
					try
					{
						Directory.CreateDirectory(text);
					}
					catch
					{
						bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aww(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					BackgroundWorker val2 = new BackgroundWorker
					{
						WorkerReportsProgress = true
					};
					val2.DoWork += new DoWorkEventHandler(A);
					object obj2 = Cr.A.Bss;
					if (obj2 == null)
					{
						ProgressChangedEventHandler val3 = BM.a;
						Cr.A.Bss = val3;
						obj2 = (object)val3;
					}
					val2.ProgressChanged += (ProgressChangedEventHandler)obj2;
					val2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(A);
					val2.RunWorkerAsync((object)text);
				}
				else
				{
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awX(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			else
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awx(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private void A(string P_0, string P_1, List<string> P_2, BackgroundWorker P_3)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			DirectoryInfo val = new DirectoryInfo(P_0);
			if (!Directory.Exists(P_1))
			{
				Directory.CreateDirectory(P_1);
			}
			FileInfo[] files = val.GetFiles();
			foreach (FileInfo BsT in files)
			{
				string text = string.Empty;
				try
				{
					P_3.ReportProgress(0);
					bW bW = Cq.a(((FileSystemInfo)BsT).FullName);
					if (bW != null && bW.axS != 1 && bW.axS != 2 && bW.axS != 3 && bW.axS != 4 && bW.axS != 5 && bW.axS != 6)
					{
						((Control)BM.QQ).Invoke((Action)delegate
						{
							BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEQ() + ((FileSystemInfo)BsT).Name + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FC());
						});
						P_3.ReportProgress(10);
						string text2 = bT.A(bW.axS, bW.axs, bW.axT, bW.axt, true);
						string text3 = bT.A(bW.axS, bW.axs, BcQ, null, true);
						P_3.ReportProgress(20);
						if (!string.IsNullOrEmpty(text2))
						{
							if (!string.IsNullOrEmpty(text3))
							{
								Framework framework = new Framework(text2, bW.axS, bW.axs, bW.axT);
								if (framework.a() == bV.A.Brc)
								{
									P_3.ReportProgress(50);
									Thread.Sleep(0);
									Framework framework2 = new Framework(text3, bW.axS, bW.axs, BcQ);
									if (framework2.a() == bV.A.Brc)
									{
										P_3.ReportProgress(80);
										Thread.Sleep(0);
										new Cq(((FileSystemInfo)BsT).FullName, framework).A(out var _);
										framework2.C(framework2.aWS);
										framework2.A(framework, framework2.aWS, true, false);
										framework2.A(framework, false);
										framework2.c(framework2.aWS);
										P_3.ReportProgress(90);
										Thread.Sleep(0);
										if (Bcq != null)
										{
											Enumerator<int, int> enumerator = Bcq.GetEnumerator();
											try
											{
												while (enumerator.MoveNext())
												{
													KeyValuePair<int, int> current = enumerator.Current;
													int key = current.Key;
													int value = current.Value;
													framework2.A(key)?.a(value, false);
												}
											}
											finally
											{
												((System.IDisposable)enumerator).Dispose();
											}
										}
										if (BcR != null)
										{
											Enumerator<int, List<int>> enumerator2 = BcR.GetEnumerator();
											try
											{
												while (enumerator2.MoveNext())
												{
													KeyValuePair<int, List<int>> current2 = enumerator2.Current;
													int key2 = current2.Key;
													List<int> value2 = current2.Value;
													Setting setting = framework2.A(key2);
													if (setting != null)
													{
														int num = setting.Ba();
														int num2 = Math.Min(value2.Count, num);
														for (int j = 0; j < num2; j++)
														{
															setting.a(j, value2[j], false);
														}
													}
												}
											}
											finally
											{
												((System.IDisposable)enumerator2).Dispose();
											}
										}
										new CR(Path.Combine(P_1, Path.GetFileNameWithoutExtension(((FileSystemInfo)BsT).FullName) + bx.a(framework2.awZ, framework2.awz, framework2.aXA)) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu(), framework2, true).A();
										P_3.ReportProgress(100);
										Thread.Sleep(50);
										text = ((FileSystemInfo)BsT).FullName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awI();
									}
									else
									{
										text = ((FileSystemInfo)BsT).FullName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awY();
									}
								}
								else
								{
									text = ((FileSystemInfo)BsT).FullName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awy();
								}
							}
							else
							{
								text = ((FileSystemInfo)BsT).FullName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awZ() + ((object)BcQ)?.ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awz();
							}
						}
						else
						{
							text = ((FileSystemInfo)BsT).FullName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awZ() + ((object)bW.axT)?.ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXA();
						}
					}
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXa() + ex.Message, true);
				}
				if (!string.IsNullOrEmpty(text))
				{
					P_2.Add(text);
				}
			}
			if (Bcp)
			{
				DirectoryInfo[] directories = val.GetDirectories();
				foreach (DirectoryInfo val2 in directories)
				{
					string text5 = P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK() + ((FileSystemInfo)val2).Name;
					A(((FileSystemInfo)val2).FullName, text5, P_2, P_3);
				}
			}
		}

		private void A(object P_0, DoWorkEventArgs P_1)
		{
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			string text = P_1.Argument as string;
			List<string> val2 = new List<string>();
			A(BcP, text, val2, val);
			P_1.Result = val2;
		}

		private void A(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			BM.P();
			List<string> val = P_1.Result as List<string>;
			int num = 0;
			Enumerator<string> enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awJ()))
					{
						num++;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXB() + num + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXb();
			enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (!current.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awJ()))
					{
						text = text + current + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy();
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			bE.A((IWin32Window)(object)BM.QQ, text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aXC(), (MessageBoxButtons)0);
		}
	}
}
