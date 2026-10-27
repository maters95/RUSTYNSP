using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using Microsoft.Win32;
using NSP.SettingsFramework;
using NSP.UnitConversion;
using NSP.UserInterface;
using a;
using b;

namespace B
{
	internal enum BE
	{
		nd,
		nE,
		ne
	}
	internal class Be : Form
	{
		internal class A
		{
			internal BE BOy;

			internal int BOZ;
		}

		internal class a
		{
			internal List<int> BOz;

			internal byte BoA;

			internal bool Boa;

			internal int BoB;

			internal List<System.DateTime> Bob;

			internal int BoC;

			internal int Boc;

			internal int BoD;

			internal int Bod;

			internal string BoE;

			public virtual string ToString()
			{
				if (BOz.Count > 1)
				{
					return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDA() + BOz[0] + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rb() + BOz[BOz.Count - 1];
				}
				if (BOz.Count == 1)
				{
					return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDa() + BOz[0];
				}
				return base.ToString();
			}
		}

		private struct B
		{
			internal int Boe;

			internal Bc BoF;
		}

		private enum b
		{
			Bof,
			BoG,
			Bog,
			BoH,
			Boh,
			BoI
		}

		private delegate void C(object P_0, EventArgs P_1);

		private delegate void c(a P_0, bool P_1, ListViewItem P_2);

		internal struct D
		{
			internal string Boi;

			internal string BoJ;

			internal string Boj;

			internal A BoK;

			internal int Bok;
		}

		internal struct d
		{
			internal string BoL;

			internal A Bol;

			internal int BoM;
		}

		internal static class E
		{
			internal static void A()
			{
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Expected O, but got Unknown
				//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ad: Invalid comparison between Unknown and I4
				ny.Clear();
				nZ.Clear();
				nz.Clear();
				OA.Clear();
				Oa.Clear();
				OB.Clear();
				Ob.Clear();
				OC.Clear();
				if (BM.Qz == null)
				{
					return;
				}
				string aXD = BM.Qz.aXD;
				if (aXD == string.Empty)
				{
					return;
				}
				string text = aXD + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDB();
				if (!File.Exists(text))
				{
					return;
				}
				try
				{
					FileStream val = new FileStream(text, (FileMode)3);
					XmlReader val2 = XmlReader.Create((Stream)(object)val);
					val2.Read();
					while ((int)val2.NodeType != 1)
					{
						val2.Read();
					}
					if (!val2.IsEmptyElement)
					{
						val2.Read();
						while (val2.IsStartElement())
						{
							bool flag = true;
							string name = val2.Name;
							if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDb()))
							{
								if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDC())
								{
									A(val2);
								}
								else
								{
									flag = false;
								}
							}
							else
							{
								A(val2, aXD);
							}
							if (!flag)
							{
								val2.Skip();
							}
							else
							{
								val2.Read();
							}
						}
					}
					val2.Close();
					((Stream)val).Close();
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDc() + ex.Message, true);
				}
			}

			private static void A(XmlReader P_0, string P_1)
			{
				string[] array = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDD()).Split(',', (StringSplitOptions)0);
				List<int> val = new List<int>();
				string[] array2 = array;
				foreach (string text in array2)
				{
					val.Add(int.Parse(text));
				}
				string[] array3 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDd()).Split(',', (StringSplitOptions)0);
				List<System.DateTime> val2 = new List<System.DateTime>();
				array2 = array3;
				foreach (string text2 in array2)
				{
					val2.Add(System.DateTime.Parse(text2));
				}
				a a = new a
				{
					BOz = val,
					BoA = byte.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDE())),
					Boa = bool.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JP())),
					BoB = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDe())),
					Bob = val2,
					BoC = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDF())),
					Boc = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDf())),
					BoE = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDG())
				};
				string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDg());
				if (attribute != null)
				{
					a.BoD = int.Parse(attribute);
				}
				string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDH());
				if (attribute2 != null)
				{
					a.Bod = int.Parse(attribute2);
				}
				if (a.Boa && !string.IsNullOrEmpty(a.BoE) && File.Exists(P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JT() + a.BoE + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
				{
					if (a.BOz.Count == 1)
					{
						ny[a.BOz[0]] = a;
						Oa[a.BOz[0]] = a.Bob[0];
						OB[a.BOz[0]] = a.BoC;
						Ob[a.BOz[0]] = a.BoD;
						OC[a.BOz[0]] = a.Bod;
					}
					nZ[a.BoE] = a;
					nz[a.BoE] = a.BOz;
					OA[a.BoE] = a.BoA;
				}
			}

			private static void A(XmlReader P_0)
			{
				int num = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDh()));
				Oa[num] = System.DateTime.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDI()));
				OB[num] = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDF()));
				string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDg());
				if (attribute != null)
				{
					Ob[num] = int.Parse(attribute);
				}
				else
				{
					Ob[num] = 0;
				}
				string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDH());
				if (attribute2 != null)
				{
					OC[num] = int.Parse(attribute2);
				}
				else
				{
					OC[num] = 0;
				}
			}

			internal static void a()
			{
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0066: Expected O, but got Unknown
				//IL_0066: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Expected O, but got Unknown
				//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_011c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0121: Unknown result type (might be due to invalid IL or missing references)
				//IL_01be: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c5: Expected O, but got Unknown
				//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
				try
				{
					if (BM.Qz == null)
					{
						return;
					}
					string aXD = BM.Qz.aXD;
					if (aXD == string.Empty)
					{
						return;
					}
					string text = aXD + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDB();
					if (File.Exists(text))
					{
						File.Delete(text);
					}
					if (nZ.Count == 0 && OB.Count == 0)
					{
						return;
					}
					MemoryStream val = new MemoryStream();
					XmlWriterSettings val2 = new XmlWriterSettings();
					val2.ConformanceLevel = (ConformanceLevel)2;
					val2.CloseOutput = false;
					val2.Indent = true;
					val2.NewLineChars = Environment.NewLine;
					XmlWriter val3 = XmlWriter.Create((Stream)(object)val, val2);
					val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDi());
					List<int> val4 = new List<int>();
					Enumerator<string, a> enumerator = nZ.Values.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							a current = enumerator.Current;
							if (current.Boa)
							{
								A(val3, current);
								if (current.BOz.Count == 1)
								{
									val4.Add(current.BOz[0]);
								}
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					Enumerator<int, int> enumerator2 = OB.Keys.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							int current2 = enumerator2.Current;
							if (!val4.Contains(current2) && Oa.ContainsKey(current2))
							{
								System.DateTime dateTime = Oa[current2];
								int num = OB[current2];
								int num2 = Ob[current2];
								int num3 = OC[current2];
								A(val3, current2, dateTime, num, num2, num3);
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
					val3.WriteEndElement();
					val3.Close();
					((Stream)val).Flush();
					StreamWriter val5 = new StreamWriter(text);
					try
					{
						((Stream)val).Position = 0L;
						string text2 = ((TextReader)new StreamReader((Stream)(object)val)).ReadToEnd();
						((TextWriter)val5).Write(text2);
					}
					finally
					{
						((System.IDisposable)val5)?.Dispose();
					}
					File.SetAttributes(text, (FileAttributes)2);
					((Stream)val).Close();
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDJ() + ex.Message, true);
				}
			}

			private static void A(XmlWriter P_0, a P_1)
			{
				//IL_0017: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
				P_0.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDb());
				string text = string.Empty;
				Enumerator<int> enumerator = P_1.BOz.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						int current = enumerator.Current;
						text = ((!string.IsNullOrEmpty(text)) ? (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ() + current) : (text + current));
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDD(), text);
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDE(), P_1.BoA.ToString());
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JP(), P_1.Boa.ToString());
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDe(), P_1.BoB.ToString());
				string text2 = string.Empty;
				Enumerator<System.DateTime> enumerator2 = P_1.Bob.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						System.DateTime current2 = enumerator2.Current;
						text2 = ((!string.IsNullOrEmpty(text2)) ? (text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ() + current2.ToString()) : (text2 + current2.ToString()));
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDd(), text2);
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDF(), P_1.BoC.ToString());
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDf(), P_1.Boc.ToString());
				if (string.IsNullOrEmpty(P_1.BoE))
				{
					P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDG(), string.Empty);
				}
				else
				{
					P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDG(), P_1.BoE);
				}
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDg(), P_1.BoD.ToString());
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDH(), P_1.Bod.ToString());
				P_0.WriteEndElement();
			}

			private static void A(XmlWriter P_0, int P_1, System.DateTime P_2, int P_3, int P_4, int P_5)
			{
				P_0.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDC());
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDh(), P_1.ToString());
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDI(), P_2.ToString());
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDF(), P_3.ToString());
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDg(), P_4.ToString());
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDH(), P_5.ToString());
				P_0.WriteEndElement();
			}
		}

		[CompilerGenerated]
		private static class e
		{
			public static DoWorkEventHandler Bom;

			public static RunWorkerCompletedEventHandler BoN;
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class F
		{
			public static readonly F Bon = new F();

			public static Func<FileInfo, System.DateTime> BoO;

			public static Func<FileInfo, string> Boo;

			public static Action BoP;

			public static Action Bop;

			internal System.DateTime A(FileInfo P_0)
			{
				return ((FileSystemInfo)P_0).LastWriteTime;
			}

			internal string a(FileInfo P_0)
			{
				return ((FileSystemInfo)P_0).FullName;
			}

			internal void A()
			{
				//IL_0018: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Expected O, but got Unknown
				foreach (ListViewItem item in ((ListView)Od).Items)
				{
					ListViewItem val = item;
					if (val.SubItems.Count > OJ)
					{
						a a = (a)val.Tag;
						if (a.BoA != 0 && !a.Boa)
						{
							val.SubItems[OJ].Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
						}
					}
				}
			}

			internal void a()
			{
				//IL_0018: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Expected O, but got Unknown
				foreach (ListViewItem item in ((ListView)Od).Items)
				{
					ListViewItem val = item;
					a a = (a)val.Tag;
					if (a.BOz.Count == 1 && a.BOz[0] == nK)
					{
						if (val.SubItems.Count > OJ)
						{
							val.SubItems[OJ].Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDj();
							a.Boa = false;
							val.Tag = a;
						}
						break;
					}
				}
				if (Od != null)
				{
					((Control)Od).Invalidate();
				}
			}
		}

		[CompilerGenerated]
		private sealed class f
		{
			public Be BoQ;

			public B Boq;
		}

		[CompilerGenerated]
		private sealed class G
		{
			public a BoR;

			public int Bor;

			public int BoS;

			public int Bos;

			public int BoT;

			public int Bot;

			public int BoU;

			public int Bou;

			public int BoV;

			public f Bov;

			internal void A()
			{
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004b: Expected O, but got Unknown
				//IL_0142: Unknown result type (might be due to invalid IL or missing references)
				//IL_014c: Expected O, but got Unknown
				//IL_016d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0177: Expected O, but got Unknown
				if (((ListView)Bov.BoQ.Oo).Items.Count == 0)
				{
					return;
				}
				foreach (ListViewItem item in ((ListView)Bov.BoQ.Oo).Items)
				{
					ListViewItem val = item;
					BoR = (a)val.Tag;
					if (BoR.BOz.Count == 1 && BoR.BOz[0] == Bov.Boq.Boe)
					{
						BoR.BoB = ns;
						BoR.Bob = new List<System.DateTime>();
						BoR.Bob.Add(new System.DateTime(Bor, BoS, Bos, BoT, Bot, BoU));
						BoR.BoC = Bou;
						BoR.Boc = Bou - BoV;
						BoR.BoE = string.Empty;
						Bov.BoQ.A(BoR, false, val);
						nY = new BackgroundWorker();
						nY.WorkerSupportsCancellation = true;
						nY.DoWork += new DoWorkEventHandler(Bov.BoQ.a);
						nY.RunWorkerAsync();
						break;
					}
				}
			}
		}

		[CompilerGenerated]
		private sealed class g
		{
			public Be BoW;

			public string Bow;

			internal void A()
			{
				((Control)BoW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDK() + Bow + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu();
			}
		}

		[CompilerGenerated]
		private sealed class H
		{
			public Be BoX;

			public string Box;

			internal void A()
			{
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				bE.A((IWin32Window)(object)BoX, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDk() + Box, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDL(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		[CompilerGenerated]
		private sealed class h
		{
			public Be BoY;

			public int Boy;

			internal void A()
			{
				for (int num = ((ListView)BoY.Oo).Items.Count - 1; num >= 0; num--)
				{
					a a = (a)((ListView)BoY.Oo).Items[num].Tag;
					if (a.BoA != 0 && a.BOz.Count == 1)
					{
						Boy = Math.Min(Boy, a.BOz[0]);
					}
				}
			}
		}

		[CompilerGenerated]
		private sealed class I
		{
			public Be BoZ;

			public a Boz;

			internal void A()
			{
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003b: Expected O, but got Unknown
				if (((ListView)BoZ.Oo).Items.Count == 0)
				{
					return;
				}
				foreach (ListViewItem item in ((ListView)BoZ.Oo).Items)
				{
					ListViewItem val = item;
					if ((a)val.Tag == Boz)
					{
						BoZ.A(Boz, false, val);
						break;
					}
				}
			}
		}

		[CompilerGenerated]
		private sealed class i
		{
			public Be BPA;

			public int BPa;

			public Action BPB;

			internal void A()
			{
				for (int num = ((ListView)BPA.Oo).Items.Count - 1; num >= 0; num--)
				{
					a a = (a)((ListView)BPA.Oo).Items[num].Tag;
					bool flag = a.BoA != 0;
					if (a.BOz.Count == 1 && a.BOz[0] < BPa && flag && !a.Boa)
					{
						Be.a(a.BOz[0]);
						((ListView)BPA.Oo).Items[num].Tag = null;
						((ListView)BPA.Oo).Items.RemoveAt(num);
						if (ny.ContainsKey(a.BOz[0]))
						{
							ny.Remove(a.BOz[0]);
						}
						if (Oa.ContainsKey(a.BOz[0]))
						{
							Oa.Remove(a.BOz[0]);
						}
						if (OB.ContainsKey(a.BOz[0]))
						{
							OB.Remove(a.BOz[0]);
						}
						if (Ob.ContainsKey(a.BOz[0]))
						{
							Ob.Remove(a.BOz[0]);
						}
						if (OC.ContainsKey(a.BOz[0]))
						{
							OC.Remove(a.BOz[0]);
						}
					}
				}
				BPA.Oo.a();
				((Control)BPA.Oo).Invalidate();
			}
		}

		[CompilerGenerated]
		private sealed class J
		{
			public int BPb;

			internal void A()
			{
				//IL_0018: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Expected O, but got Unknown
				foreach (ListViewItem item in ((ListView)Od).Items)
				{
					ListViewItem val = item;
					a a = (a)val.Tag;
					if (a.BOz.Count == 1 && a.BOz[0] == nK)
					{
						if (val.SubItems.Count > OJ)
						{
							val.SubItems[OJ].Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDl() + BPb + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gC();
						}
						break;
					}
				}
				if (Od != null)
				{
					((Control)Od).Invalidate();
				}
			}
		}

		[CompilerGenerated]
		private sealed class j
		{
			public int BPC;

			public string BPc;

			internal void A()
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0021: Expected O, but got Unknown
				foreach (ListViewItem item in ((ListView)Od).Items)
				{
					ListViewItem val = item;
					a a = (a)val.Tag;
					if (a.BOz.Count == 1 && a.BOz[0] == BPC)
					{
						if (val.SubItems.Count > OJ && val.SubItems.Count > OL)
						{
							val.SubItems[OJ].Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDM();
							val.SubItems[OL].Text = BPc;
							a.Boa = true;
							a.BoE = BPc;
							val.Tag = a;
						}
						nZ[BPc] = a;
						nz[BPc] = a.BOz;
						OA[BPc] = a.BoA;
						break;
					}
				}
				if (Od != null)
				{
					((Control)Od).Invalidate();
				}
			}
		}

		[CompilerGenerated]
		private sealed class K
		{
			public int BPD;

			public string BPd;

			public A BPE;

			internal void A()
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0021: Expected O, but got Unknown
				foreach (ListViewItem item in ((ListView)Od).Items)
				{
					ListViewItem val = item;
					a a = (a)val.Tag;
					if (a.BOz.Count != 1 || a.BOz[0] != BPD)
					{
						continue;
					}
					if (val.SubItems.Count <= OJ || val.SubItems.Count <= OL)
					{
						break;
					}
					val.SubItems[OJ].Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JP();
					val.SubItems[OL].Text = BPd;
					a.Boa = true;
					a.BoE = BPd;
					val.Tag = a;
					if (BPE != null && BPE.BOZ == BPD)
					{
						if (BPE.BOy == BE.nE)
						{
							Oe.A(a);
						}
						else if (BPE.BOy == BE.ne)
						{
							Oe.A(a.BoE);
						}
					}
					break;
				}
				if (Od != null)
				{
					((Control)Od).Invalidate();
				}
			}
		}

		internal static readonly string nF = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jX();

		private static string nf = null;

		private static string nG = null;

		internal const int ng = 3;

		private static int nH = 0;

		private static int nh;

		private static MemoryStream nI = null;

		private static ZipArchive ni = null;

		private static ZipArchiveEntry nJ = null;

		private static Stream nj = null;

		private static int nK = -1;

		private static int nk = -1;

		private static int nL = -1;

		private static int nl = -1;

		private static int nM = -1;

		private static int nm = -1;

		private static int nN = -1;

		private static int nn = 0;

		private static System.DateTime nO;

		private static bool no = false;

		private static int nP = -1;

		private static int np = -1;

		private static int nQ = -1;

		private static int nq = -1;

		private static int nR = -1;

		private static int nr = -1;

		private static int nS = -1;

		private static int ns = 0;

		private static bool nT = false;

		private static List<A> nt = new List<A>();

		private static global::A.b nU;

		private static Bc nu = Bc.NO;

		internal static int nV = 30;

		internal static bool nv = true;

		private static List<string> nW = new List<string>();

		private static ListViewItem nw = null;

		private static object nX = new object();

		private static BackgroundWorker nx;

		private static BackgroundWorker nY;

		private static Dictionary<int, a> ny = new Dictionary<int, a>();

		private static Dictionary<string, a> nZ = new Dictionary<string, a>();

		private static Dictionary<string, List<int>> nz = new Dictionary<string, List<int>>();

		private static Dictionary<string, byte> OA = new Dictionary<string, byte>();

		private static Dictionary<int, System.DateTime> Oa = new Dictionary<int, System.DateTime>();

		private static Dictionary<int, int> OB = new Dictionary<int, int>();

		private static Dictionary<int, int> Ob = new Dictionary<int, int>();

		private static Dictionary<int, int> OC = new Dictionary<int, int>();

		private static System.DateTime Oc = new System.DateTime(1980, 1, 1, 1, 1, 1);

		private static bool OD = false;

		private static ab Od;

		internal static bool OE = false;

		internal static Be Oe;

		private ToolStripMenuItem OF = new ToolStripMenuItem();

		private ToolStripMenuItem Of = new ToolStripMenuItem();

		private ToolStripMenuItem OG = new ToolStripMenuItem();

		private ToolStripMenuItem Og = new ToolStripMenuItem();

		private ToolStripMenuItem OH = new ToolStripMenuItem();

		private static Point Oh = new Point(0, 0);

		private static int OI = -1;

		private static int Oi = -1;

		private static int OJ = -1;

		private static int Oj = -1;

		private static int OK = -1;

		private static int Ok = -1;

		private static int OL = -1;

		private static int Ol = 0;

		private static int OM = -1;

		private IContainer Om;

		private aP ON;

		private ThemedComboBox On;

		private Label OO;

		private ab Oo;

		private Label OP;

		private ThemedComboBox Op;

		private ThemedTextBox OQ;

		private ThemedButton Oq;

		private ThemedButton OR;

		private ThemedButton Or;

		private ThemedButton OS;

		private Label Os;

		[DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
		private static extern bool A(nint P_0);

		internal Be(string P_0, bool P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected O, but got Unknown
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected O, but got Unknown
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected O, but got Unknown
			J();
			_ = ((Control)Oo).Handle;
			Od = Oo;
			Oe = this;
			nG = P_0;
			OD = P_1;
			((ListView)Oo).UseCompatibleStateImageBehavior = false;
			((ListView)Oo).OwnerDraw = true;
			((ListView)Oo).DrawItem += new DrawListViewItemEventHandler(A);
			((ListView)Oo).DrawSubItem += new DrawListViewSubItemEventHandler(A);
			((ListView)Oo).DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(A);
			BM.C(new EventHandler(a));
			((Control)Oo).ContextMenuStrip = A();
			((ToolStripDropDown)((Control)Oo).ContextMenuStrip).Opening += new CancelEventHandler(A);
			Be.E.A();
		}

		private ContextMenuStrip A()
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
			//IL_0139: Expected O, but got Unknown
			ContextMenuStrip val = new ContextMenuStrip
			{
				BackColor = BM.tG,
				ForeColor = BM.te
			};
			((ToolStripItem)OF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iI();
			((ToolStripItem)OF).Click += new EventHandler(c);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)OF);
			((ToolStripItem)Of).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ii();
			((ToolStripItem)Of).Click += new EventHandler(D);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)Of);
			((ToolStripItem)OG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iJ();
			((ToolStripItem)OG).Click += new EventHandler(d);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)OG);
			((ToolStripItem)Og).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ij();
			((ToolStripItem)Og).Click += new EventHandler(E);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)Og);
			((ToolStripItem)OH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iK();
			((ToolStripItem)OH).Click += new EventHandler(e);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)OH);
			return val;
		}

		internal static void a()
		{
			if (File.Exists(nF))
			{
				StreamReader val = File.OpenText(nF);
				try
				{
					string text;
					while ((text = ((TextReader)val).ReadLine()) != null)
					{
						if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ik()))
						{
							nT = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ik().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iL()))
						{
							global::A.A.n = (global::A.b)int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iL().Length));
							nU = global::A.A.n;
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.il()))
						{
							nv = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.il().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iM()))
						{
							nV = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iM().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.im()))
						{
							nu = (Bc)int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.im().Length));
						}
					}
					return;
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			nT = false;
			nv = true;
			nV = 30;
			nu = Bc.NO;
		}

		internal static void B()
		{
			try
			{
				if (!Directory.Exists(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
				{
					Directory.CreateDirectory(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
				}
				((Stream)File.Create(nF)).Close();
				List<string> val = new List<string>();
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ik() + nT);
				string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iL();
				int num = (int)nU;
				val.Add(text + num);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.il() + nv);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iM() + nV);
				string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.im();
				num = (int)nu;
				val.Add(text2 + num);
				File.AppendAllLines(nF, (System.Collections.Generic.IEnumerable<string>)val);
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iN() + ex.Message, true);
			}
		}

		[SpecialName]
		internal static string b()
		{
			string result = null;
			RegistryKey val = Registry.CurrentUser.OpenSubKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.@in(), true);
			if (val != null)
			{
				RegistryKey val2 = val.OpenSubKey(Application.CompanyName, true);
				if (val2 != null)
				{
					RegistryKey val3 = val2.OpenSubKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iO(), true);
					if (val3 != null)
					{
						result = val3.GetValue(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.io()) as string;
					}
				}
			}
			return result;
		}

		[SpecialName]
		internal static string C()
		{
			string result = null;
			RegistryKey val = Registry.LocalMachine.OpenSubKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.@in(), false);
			if (val != null)
			{
				RegistryKey val2 = val.OpenSubKey(Application.CompanyName, false);
				if (val2 != null)
				{
					RegistryKey val3 = val2.OpenSubKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iP(), false);
					if (val3 != null)
					{
						result = val3.GetValue(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.io()) as string;
					}
				}
			}
			return result;
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ip();
			((Control)this).BackColor = BM.td;
			((Control)ON).ForeColor = BM.te;
			((Control)Oo).BackColor = BM.tH;
			((Control)Oo).ForeColor = BM.te;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					val.ForeColor = BM.te;
				}
			}
			a();
			((CheckBox)ON).Checked = nT;
			((ListControl)On).SelectedIndex = (int)nU;
			((ListControl)Op).SelectedIndex = (int)nu;
			c();
			OE = true;
		}

		private void a(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			((ListView)Oo).DrawItem -= new DrawListViewItemEventHandler(A);
			((ListView)Oo).DrawSubItem -= new DrawListViewSubItemEventHandler(A);
			((ListView)Oo).DrawColumnHeader -= new DrawListViewColumnHeaderEventHandler(A);
			BM.c(new EventHandler(a));
			B();
			Setting setting = null;
			if (BM.Qz != null)
			{
				setting = BM.Qz.A(9500);
			}
			setting?.a(new EventHandler(f));
			Be.E.a();
			((ListView)Oo).Items.Clear();
			Od = null;
			if (nx != null)
			{
				nx.CancelAsync();
			}
			if (nY != null)
			{
				nY.CancelAsync();
			}
			OE = false;
		}

		private void c()
		{
			((Control)ON).Enabled = !OD;
			((Control)On).Enabled = !OD && ((CheckBox)ON).Checked;
			((Control)On).Invalidate();
			((Control)On).Visible = ((Control)On).Enabled;
			((Control)OO).Visible = ((Control)On).Visible;
			((Control)Os).Visible = ((Control)On).Visible;
			bool flag = D();
			((Control)Oq).Enabled = !OD && flag;
			((Control)OR).Enabled = !OD && flag;
			((Control)Or).Enabled = !OD && flag;
			((Control)OS).Enabled = !OD && flag;
			((Control)OQ).Enabled = !OD;
		}

		private bool D()
		{
			for (int num = ((ListView)Oo).Items.Count - 1; num >= 0; num--)
			{
				a a = (a)((ListView)Oo).Items[num].Tag;
				bool flag = a.BoA != 0;
				if (a.BOz.Count == 1 && flag && !a.Boa)
				{
					return true;
				}
			}
			return false;
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			((Control)On).Enabled = !OD && ((CheckBox)ON).Checked;
			((Control)On).Visible = ((Control)On).Enabled;
			((Control)OO).Visible = ((Control)On).Visible;
			((Control)Os).Visible = ((Control)On).Visible;
			nt.Clear();
			nT = ((CheckBox)ON).Checked;
			B();
			if (nT)
			{
				foreach (ListViewItem item in ((ListView)Oo).Items)
				{
					ListViewItem val = item;
					if (val.SubItems.Count > OJ && ((a)val.Tag).BoA != 0 && val.SubItems[OJ].Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG())
					{
						val.SubItems[OJ].Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iQ();
					}
				}
			}
			((Control)Oo).Invalidate();
		}

		private void b(object P_0, EventArgs P_1)
		{
			if (((ListControl)On).SelectedIndex != -1)
			{
				nU = (global::A.b)((ListControl)On).SelectedIndex;
				B();
			}
		}

		private void C(object P_0, EventArgs P_1)
		{
			if (((ListControl)Op).SelectedIndex != -1)
			{
				nu = (Bc)((ListControl)Op).SelectedIndex;
				B b = default(B);
				b.Boe = -1;
				b.BoF = nu;
				B b2 = b;
				A(b2);
			}
		}

		private static bool A(int P_0)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			Enumerator<A> enumerator = nt.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.BOZ == P_0)
					{
						return true;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			return false;
		}

		private static void A(int P_0, BE P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			Enumerator<A> enumerator = nt.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.BOZ == P_0)
					{
						return;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			A a = new A();
			a.BOZ = P_0;
			a.BOy = P_1;
			nt.Add(a);
		}

		private static A a(int P_0)
		{
			A result = null;
			for (int num = nt.Count - 1; num >= 0; num--)
			{
				if (nt[num].BOZ == P_0)
				{
					result = nt[num];
					nt.RemoveAt(num);
					break;
				}
			}
			if (nt.Count == 0)
			{
				global::A.A.n = nU;
			}
			return result;
		}

		private void A(object P_0, MouseEventArgs P_1)
		{
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			if (((ListView)Oo).Items.Count != 0)
			{
				ListViewItem val = ((ListView)Oo).Items[((ListView)Oo).Items.Count - 1];
				if (val.SubItems.Count > OK)
				{
					if (P_1.Y >= 20)
					{
						int y = P_1.Y;
						Rectangle bounds = val.SubItems[0].Bounds;
						if (y <= ((Rectangle)(ref bounds)).Bottom)
						{
							int x = P_1.X;
							bounds = val.SubItems[OJ].Bounds;
							if (x >= ((Rectangle)(ref bounds)).Right)
							{
								((Control)Oo).Cursor = Cursors.Hand;
								goto IL_00e0;
							}
						}
					}
					((Control)Oo).Cursor = Cursors.Default;
				}
				else
				{
					((Control)Oo).Cursor = Cursors.Default;
				}
			}
			else
			{
				((Control)Oo).Cursor = Cursors.Default;
			}
			goto IL_00e0;
			IL_00e0:
			((Point)(ref Oh)).X = P_1.X;
			((Point)(ref Oh)).Y = P_1.Y;
			((Control)Oo).Invalidate();
		}

		private void d()
		{
			//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			if (nf != null && Directory.Exists(nf))
			{
				if (((Control)OQ).Text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
				{
					((Control)OQ).Text = ((Control)OQ).Text.Substring(0, ((Control)OQ).Text.Length - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej().Length);
				}
				else if (((Control)OQ).Text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()))
				{
					((Control)OQ).Text = ((Control)OQ).Text.Substring(0, ((Control)OQ).Text.Length - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK().Length);
				}
				bool flag = false;
				string[] files = Directory.GetFiles(nf);
				foreach (string text in files)
				{
					if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK() + ((Control)OQ).Text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()) || text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + ((Control)OQ).Text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()) || text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK() + ((Control)OQ).Text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()) || text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + ((Control)OQ).Text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iq(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else
				{
					try
					{
						Enumerator<string> enumerator = nW.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								string current = enumerator.Current;
								int num = 0;
								for (int num2 = current.Length - 2; num2 >= 0; num2--)
								{
									if (current[num2] == '/' || current[num2] == '\\')
									{
										num = num2 + 1;
										break;
									}
								}
								string text2 = string.Empty;
								if (current.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
								{
									text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej();
								}
								else if (current.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()))
								{
									text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK();
								}
								else if (current.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iR()))
								{
									text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iR();
								}
								string text3 = current.Substring(0, num) + ((Control)OQ).Text + text2;
								File.Move(current, text3);
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
						if (Oo != null && ((Control)Oo).IsHandleCreated && nw != null && nw.SubItems.Count > OL)
						{
							nw.SubItems[OL].Text = ((Control)OQ).Text;
							a a = (a)nw.Tag;
							if (nZ.ContainsKey(a.BoE))
							{
								nZ.Remove(a.BoE);
							}
							if (nz.ContainsKey(a.BoE))
							{
								nz.Remove(a.BoE);
							}
							if (OA.ContainsKey(a.BoE))
							{
								OA.Remove(a.BoE);
							}
							a.BoE = ((Control)OQ).Text;
							nZ[((Control)OQ).Text] = a;
							nz[((Control)OQ).Text] = a.BOz;
							OA[((Control)OQ).Text] = a.BoA;
							Be.E.a();
						}
					}
					catch
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ir(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
			}
			((Control)OQ).Visible = false;
			((Control)OQ).Text = string.Empty;
			nw = null;
			nW.Clear();
			((Control)Oo).Invalidate();
		}

		private void a(object P_0, MouseEventArgs P_1)
		{
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Invalid comparison between Unknown and I4
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)OQ).Visible && nw != null)
			{
				if (((Control)OQ).Text != string.Empty)
				{
					d();
					return;
				}
				((Control)OQ).Visible = false;
				nw = null;
				nW.Clear();
				((Control)Oo).Invalidate();
			}
			else
			{
				if ((int)P_1.Button != 1048576 || ((Point)(ref Oh)).X == 0 || ((Point)(ref Oh)).Y == 0)
				{
					return;
				}
				foreach (ListViewItem item in ((ListView)Oo).Items)
				{
					ListViewItem val = item;
					int y = ((Point)(ref Oh)).Y;
					Rectangle bounds = val.Bounds;
					if (y <= ((Rectangle)(ref bounds)).Top)
					{
						continue;
					}
					int y2 = ((Point)(ref Oh)).Y;
					bounds = val.Bounds;
					if (y2 >= ((Rectangle)(ref bounds)).Bottom)
					{
						continue;
					}
					if (val.SubItems.Count > Oj)
					{
						int x = ((Point)(ref Oh)).X;
						bounds = val.SubItems[Oj].Bounds;
						if (x > ((Rectangle)(ref bounds)).Left)
						{
							int x2 = ((Point)(ref Oh)).X;
							bounds = val.SubItems[Oj].Bounds;
							if (x2 < ((Rectangle)(ref bounds)).Right)
							{
								c(val, null);
								break;
							}
						}
					}
					if (val.SubItems.Count > OK)
					{
						int x3 = ((Point)(ref Oh)).X;
						bounds = val.SubItems[OK].Bounds;
						if (x3 > ((Rectangle)(ref bounds)).Left)
						{
							int x4 = ((Point)(ref Oh)).X;
							bounds = val.SubItems[OK].Bounds;
							if (x4 < ((Rectangle)(ref bounds)).Right)
							{
								d(val, null);
								break;
							}
						}
					}
					if (val.SubItems.Count <= Ok)
					{
						break;
					}
					int x5 = ((Point)(ref Oh)).X;
					bounds = val.SubItems[Ok].Bounds;
					if (x5 > ((Rectangle)(ref bounds)).Left)
					{
						int x6 = ((Point)(ref Oh)).X;
						bounds = val.SubItems[Ok].Bounds;
						if (x6 < ((Rectangle)(ref bounds)).Right)
						{
							E(val, null);
						}
					}
					break;
				}
			}
		}

		private void c(object P_0, EventArgs P_1)
		{
			ListViewItem val = (ListViewItem)((!(P_0 is ListViewItem)) ? ((object)/*isinst with value type is only supported in some contexts*/) : ((P_0 is ListViewItem) ? P_0 : null));
			a a = (a)val.Tag;
			bool flag = a.BoA == 0;
			bool flag2 = a.Boa || flag;
			if (!nT && !flag2 && a.BOz.Count == 1)
			{
				A(a.BOz[0], BE.nd);
				val.SubItems[OJ].Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iQ();
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			ListViewItem val = (ListViewItem)((!(P_0 is ListViewItem)) ? ((object)/*isinst with value type is only supported in some contexts*/) : ((P_0 is ListViewItem) ? P_0 : null));
			a a = (a)val.Tag;
			bool flag = a.BoA == 0;
			if (a.Boa || flag)
			{
				string text;
				string text2;
				string text3;
				if (flag)
				{
					string boE = a.BoE;
					text = B(boE);
					text2 = Be.a(boE);
					text3 = b(boE);
				}
				else
				{
					text = Be.a(a.BOz);
					text2 = A(a.BOz);
					text3 = B(a.BOz);
				}
				nw = val;
				nW.Clear();
				if (text != null)
				{
					nW.Add(text);
				}
				if (text2 != null)
				{
					nW.Add(text2);
				}
				if (text3 != null)
				{
					nW.Add(text3);
				}
				if (text2 != null || text != null)
				{
					string text4 = ((text2 == null) ? text : text2);
					((Control)OQ).Text = Path.GetFileNameWithoutExtension(text4);
					ThemedTextBox oQ = OQ;
					int left = ((Control)Oo).Left;
					Rectangle bounds = val.SubItems[OL].Bounds;
					((Control)oQ).Left = left + ((Rectangle)(ref bounds)).Left;
					ThemedTextBox oQ2 = OQ;
					int top = ((Control)Oo).Top;
					bounds = val.SubItems[OL].Bounds;
					((Control)oQ2).Top = top + ((Rectangle)(ref bounds)).Top;
					((Control)OQ).Visible = true;
					((Control)OQ).BringToFront();
					((Control)OQ).Focus();
					((TextBoxBase)OQ).SelectAll();
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iS(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
		}

		private void d(object P_0, EventArgs P_1)
		{
			ListViewItem val = (ListViewItem)((!(P_0 is ListViewItem)) ? ((object)/*isinst with value type is only supported in some contexts*/) : ((P_0 is ListViewItem) ? P_0 : null));
			a a = (a)val.Tag;
			bool flag = a.BoA == 0;
			if (a.Boa || flag)
			{
				A(a);
				return;
			}
			if (!flag && a.BOz.Count == 1)
			{
				if (val.SubItems[OJ].Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG())
				{
					val.SubItems[OJ].Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iQ();
				}
				A(a.BOz[0], BE.nE);
				((Control)Oo).Invalidate();
			}
			((Control)this).UseWaitCursor = true;
		}

		private void E(object P_0, EventArgs P_1)
		{
			ListViewItem val = (ListViewItem)((!(P_0 is ListViewItem)) ? ((object)/*isinst with value type is only supported in some contexts*/) : ((P_0 is ListViewItem) ? P_0 : null));
			a a = (a)val.Tag;
			bool flag = a.BoA == 0;
			if (a.Boa || flag)
			{
				A(a.BoE);
				return;
			}
			if (!flag && a.BOz.Count == 1)
			{
				if (val.SubItems[OJ].Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG())
				{
					val.SubItems[OJ].Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iQ();
				}
				A(a.BOz[0], BE.ne);
				((Control)Oo).Invalidate();
			}
			((Control)this).UseWaitCursor = true;
		}

		private void e(object P_0, EventArgs P_1)
		{
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			ListViewItem val = (ListViewItem)((!(P_0 is ListViewItem)) ? ((object)/*isinst with value type is only supported in some contexts*/) : ((P_0 is ListViewItem) ? P_0 : null));
			a a = (a)val.Tag;
			bool flag = a.BoA == 0;
			if (!(a.Boa || flag))
			{
				return;
			}
			string text = null;
			if (flag)
			{
				string boE = a.BoE;
				text = B(boE);
				if (string.IsNullOrEmpty(text))
				{
					text = Be.a(boE);
				}
				if (string.IsNullOrEmpty(text))
				{
					text = b(boE);
				}
			}
			else
			{
				text = Be.a(a.BOz);
				if (string.IsNullOrEmpty(text))
				{
					text = A(a.BOz);
				}
				if (string.IsNullOrEmpty(text))
				{
					text = B(a.BOz);
				}
			}
			if (nf != null && Directory.Exists(nf))
			{
				if (!string.IsNullOrEmpty(text) && File.Exists(text))
				{
					try
					{
						Process.Start(new ProcessStartInfo(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.@is(), nf));
						return;
					}
					catch (System.Exception ex)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iT() + ex.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
				}
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iS(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.it(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private void A(object P_0, CancelEventArgs P_1)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			Point val = ((Control)Oo).PointToClient(Control.MousePosition);
			foreach (ListViewItem item in ((ListView)Oo).Items)
			{
				ListViewItem val2 = item;
				int y = ((Point)(ref val)).Y;
				Rectangle bounds = val2.Bounds;
				if (y >= ((Rectangle)(ref bounds)).Top)
				{
					int y2 = ((Point)(ref val)).Y;
					bounds = val2.Bounds;
					if (y2 < ((Rectangle)(ref bounds)).Bottom)
					{
						((ToolStripItem)OF).Tag = val2;
						((ToolStripItem)Of).Tag = val2;
						((ToolStripItem)OG).Tag = val2;
						((ToolStripItem)Og).Tag = val2;
						((ToolStripItem)OH).Tag = val2;
						a a = (a)val2.Tag;
						bool flag = a.BoA == 0;
						bool flag2 = a.Boa || flag;
						((ToolStripItem)OF).Enabled = !nT && !flag2 && a.BOz.Count == 1;
						((ToolStripItem)Of).Enabled = flag2;
						((ToolStripItem)OG).Enabled = flag2 || (!flag && a.BOz.Count == 1);
						((ToolStripItem)Og).Enabled = flag2 || (!flag && a.BOz.Count == 1);
						((ToolStripItem)OH).Enabled = flag2;
						return;
					}
				}
			}
			P_1.Cancel = true;
		}

		private void A(a P_0)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			string text = a(P_0);
			if (text != null)
			{
				((Form)this).Close();
				BM.QQ.a(text, false);
			}
			else
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iS(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			((Control)this).UseWaitCursor = false;
		}

		private void A(string P_0)
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			bool flag = false;
			bool flag2 = false;
			if (File.Exists(C()))
			{
				flag = true;
				flag2 = true;
			}
			else if (File.Exists(b()))
			{
				flag = false;
				flag2 = true;
			}
			if (!flag2)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iU(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((Control)this).UseWaitCursor = false;
				return;
			}
			if (flag)
			{
				string text = a(P_0);
				if (File.Exists(text))
				{
					if (!S.A(text))
					{
						S.A(text, M.B());
					}
					A(C(), text);
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iu(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			else
			{
				string text2 = b(P_0);
				if (text2 != null && File.Exists(text2))
				{
					A(b(), text2);
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iV(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			((Control)this).UseWaitCursor = false;
		}

		internal static void A(string P_0, string P_1)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			Process val = new Process();
			val.StartInfo.FileName = P_0;
			val.StartInfo.Arguments = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iv() + P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
			val.Start();
			nint num = System.IntPtr.Zero;
			System.DateTime dateTime = System.DateTime.Now.AddSeconds(30.0);
			while (!val.HasExited && num == (nint)System.IntPtr.Zero && System.DateTime.Now < dateTime)
			{
				num = val.MainWindowHandle;
				if (num == (nint)System.IntPtr.Zero)
				{
					Thread.Sleep(1000);
				}
			}
			if (num != (nint)System.IntPtr.Zero)
			{
				A(num);
			}
		}

		private string a(a P_0)
		{
			string text;
			if (P_0.BoA == 0)
			{
				text = B(P_0.BoE);
				if (text == null)
				{
					text = a(P_0.BoE);
				}
			}
			else
			{
				text = a(P_0.BOz);
				if (text == null)
				{
					text = A(P_0.BOz);
				}
			}
			return text;
		}

		private void F(object P_0, EventArgs P_1)
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			if (((Point)(ref Oh)).X == 0 || ((Point)(ref Oh)).Y == 0)
			{
				return;
			}
			foreach (ListViewItem item in ((ListView)Oo).Items)
			{
				ListViewItem val = item;
				int y = ((Point)(ref Oh)).Y;
				Rectangle bounds = val.Bounds;
				if (y <= ((Rectangle)(ref bounds)).Top)
				{
					continue;
				}
				int y2 = ((Point)(ref Oh)).Y;
				bounds = val.Bounds;
				if (y2 >= ((Rectangle)(ref bounds)).Bottom)
				{
					continue;
				}
				if (val.SubItems.Count <= OL)
				{
					break;
				}
				int x = ((Point)(ref Oh)).X;
				bounds = val.SubItems[OL].Bounds;
				if (x > ((Rectangle)(ref bounds)).Left)
				{
					int x2 = ((Point)(ref Oh)).X;
					bounds = val.SubItems[OL].Bounds;
					if (x2 < ((Rectangle)(ref bounds)).Right)
					{
						D(val, null);
					}
				}
				break;
			}
		}

		private void A(object P_0, KeyEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Invalid comparison between Unknown and I4
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Invalid comparison between Unknown and I4
			if ((int)P_1.KeyCode == 27)
			{
				((Control)OQ).Visible = false;
				((Control)OQ).Text = string.Empty;
				nw = null;
				nW.Clear();
				((Control)Oo).Invalidate();
			}
			else if (((int)P_1.KeyCode == 13 || (int)P_1.KeyCode == 13) && ((Control)OQ).Visible && ((Control)OQ).Text != string.Empty && nw != null)
			{
				d();
				((Control)Oo).Invalidate();
			}
		}

		private static string a(string P_0)
		{
			string text = nf + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej();
			if (File.Exists(text))
			{
				return text;
			}
			return null;
		}

		private static string A(List<int> P_0)
		{
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			if (nf != null && Directory.Exists(nf))
			{
				if (P_0.Count == 1 && ny.ContainsKey(P_0[0]))
				{
					a a = ny[P_0[0]];
					if (!string.IsNullOrEmpty(a.BoE))
					{
						string text = nf + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + a.BoE + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej();
						if (File.Exists(text))
						{
							return text;
						}
					}
				}
				string[] files = Directory.GetFiles(nf, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iW());
				string[] array;
				if (P_0.Count == 1)
				{
					array = files;
					foreach (string text2 in array)
					{
						if (text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iw() + P_0[0] + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()) || text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iX() + P_0[0] + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
						{
							return text2;
						}
					}
				}
				array = files;
				foreach (string text3 in array)
				{
					if (!text3.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
					{
						continue;
					}
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text3);
					List<int> val;
					byte b;
					if (nZ.ContainsKey(fileNameWithoutExtension))
					{
						a obj = nZ[fileNameWithoutExtension];
						val = obj.BOz;
						b = obj.BoA;
					}
					else if (nz.ContainsKey(fileNameWithoutExtension) && OA.ContainsKey(fileNameWithoutExtension))
					{
						val = nz[fileNameWithoutExtension];
						b = OA[fileNameWithoutExtension];
					}
					else
					{
						val = A(text3, out var _, out b);
						nz[fileNameWithoutExtension] = val;
						OA[fileNameWithoutExtension] = b;
					}
					bool flag = true;
					Enumerator<int> enumerator = P_0.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current = enumerator.Current;
							if (!val.Contains(current))
							{
								flag = false;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					if (flag && P_0.Count == val.Count && b != 0)
					{
						return text3;
					}
				}
			}
			return null;
		}

		private static string B(string P_0)
		{
			string text = nf + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK();
			if (File.Exists(text))
			{
				return text;
			}
			return null;
		}

		private static string a(List<int> P_0)
		{
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			if (nf != null && Directory.Exists(nf))
			{
				if (P_0.Count == 1 && ny.ContainsKey(P_0[0]))
				{
					a a = ny[P_0[0]];
					if (!string.IsNullOrEmpty(a.BoE))
					{
						string text = nf + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + a.BoE + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK();
						if (File.Exists(text))
						{
							return text;
						}
					}
				}
				string[] files = Directory.GetFiles(nf, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ix());
				string[] array;
				if (P_0.Count == 1)
				{
					array = files;
					foreach (string text2 in array)
					{
						if (text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iw() + P_0[0] + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()) || text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iX() + P_0[0] + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()))
						{
							return text2;
						}
					}
				}
				array = files;
				foreach (string text3 in array)
				{
					if (!text3.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()))
					{
						continue;
					}
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text3);
					List<int> val;
					byte b;
					if (nZ.ContainsKey(fileNameWithoutExtension))
					{
						a obj = nZ[fileNameWithoutExtension];
						val = obj.BOz;
						b = obj.BoA;
					}
					else if (nz.ContainsKey(fileNameWithoutExtension) && OA.ContainsKey(fileNameWithoutExtension))
					{
						val = nz[fileNameWithoutExtension];
						b = OA[fileNameWithoutExtension];
					}
					else
					{
						val = A(text3, out var _, out b);
						nz[fileNameWithoutExtension] = val;
						OA[fileNameWithoutExtension] = b;
					}
					bool flag = true;
					Enumerator<int> enumerator = P_0.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current = enumerator.Current;
							if (!val.Contains(current))
							{
								flag = false;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					if (flag && P_0.Count == val.Count && b != 0)
					{
						return text3;
					}
				}
			}
			return null;
		}

		private static string b(string P_0)
		{
			string text = nf + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iR();
			if (File.Exists(text))
			{
				return text;
			}
			return null;
		}

		private static string B(List<int> P_0)
		{
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			if (nf != null && Directory.Exists(nf))
			{
				string[] files = Directory.GetFiles(nf, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iY());
				string[] array;
				if (P_0.Count == 1)
				{
					array = files;
					foreach (string text in array)
					{
						if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iw() + P_0[0] + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iR()) || text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iX() + P_0[0] + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iR()))
						{
							return text;
						}
					}
				}
				array = files;
				foreach (string text2 in array)
				{
					if (!text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iR()))
					{
						continue;
					}
					System.DateTime dateTime;
					byte b;
					List<int> val = A(text2, out dateTime, out b);
					bool flag = true;
					Enumerator<int> enumerator = P_0.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current = enumerator.Current;
							if (!val.Contains(current))
							{
								flag = false;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					if (flag && P_0.Count == val.Count && b != 0)
					{
						return text2;
					}
				}
			}
			return null;
		}

		internal static List<int> A(string P_0, out System.DateTime P_1, out byte P_2)
		{
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Expected O, but got Unknown
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			List<int> val = new List<int>();
			P_1 = Oc;
			P_2 = 0;
			MemoryStream val2 = null;
			ZipArchive val3 = null;
			ZipArchiveEntry val4 = null;
			Stream val5 = null;
			try
			{
				if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iR()))
				{
					StreamReader val6 = File.OpenText(P_0);
					try
					{
						bool flag = false;
						bool flag2 = false;
						string text;
						while ((text = ((TextReader)val6).ReadLine()) != null)
						{
							if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iy()))
							{
								flag2 = true;
								val.Add(int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iy().Length)));
							}
							else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iZ()))
							{
								flag = true;
								P_2 = byte.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iZ().Length));
								if (flag2)
								{
									break;
								}
							}
							else if (flag && flag2)
							{
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)val6)?.Dispose();
					}
					return val;
				}
				val2 = S.a(P_0, M.B());
				if (((Stream)val2).CanRead)
				{
					if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
					{
						val3 = new ZipArchive((Stream)(object)val2, (ZipArchiveMode)0);
						System.Collections.Generic.IEnumerator<ZipArchiveEntry> enumerator = val3.Entries.GetEnumerator();
						try
						{
							while (((System.Collections.IEnumerator)enumerator).MoveNext())
							{
								ZipArchiveEntry current = enumerator.Current;
								if (current.Name.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()))
								{
									val4 = current;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator)?.Dispose();
						}
						if (val4 != null)
						{
							val5 = val4.Open();
						}
					}
					else
					{
						val5 = (Stream)new FileStream(P_0, (FileMode)3);
					}
					while (true)
					{
						int num = val5.ReadByte();
						switch (num)
						{
						case 255:
							continue;
						case -1:
							goto end_IL_014d;
						}
						byte[] array = new byte[4];
						if (!N.A(val5, array, 0, 4))
						{
							break;
						}
						uint num2 = (uint)(array[0] << 24) | ((uint)(array[1] << 16) & 0xFF0000u) | ((uint)(array[2] << 8) & 0xFF00u) | (array[3] & 0xFFu);
						if (num2 == 4294967295u || num2 == 0 || (num2 > 131072 && num != 2 && (num & 0xF) != 9 && num != 13))
						{
							break;
						}
						uint num3 = 0u;
						uint num4 = 0u;
						int num5 = 0;
						int num6 = 1;
						int num7 = 1;
						int num8 = 1;
						int num9 = 1;
						int num10 = 1;
						byte[] array2 = new byte[num2 - 5];
						if (!N.A(val5, array2, 0, (int)(num2 - 5)))
						{
							return val;
						}
						for (int i = 5; i < num2; i++)
						{
							byte b = array2[i - 5];
							switch (num)
							{
							case 14:
								switch ((i - 5) % 4)
								{
								case 0:
									num3 = (uint)(b << 24) & 0xFF000000u;
									break;
								case 1:
									num3 |= (uint)(b << 16) & 0xFF0000u;
									break;
								case 2:
									num3 |= (uint)(b << 8) & 0xFF00u;
									break;
								case 3:
									num3 |= b & 0xFFu;
									val.Add((int)num3);
									break;
								}
								break;
							case 1:
								if ((i == 5 && b != 72) || (i == 6 && b != 65) || (i == 7 && b != 76) || (i == 8 && b != 84) || (i == 9 && b != 69) || (i == 10 && b != 67) || (i == 11 && b != 72) || (i == 12 && b != 48 && b != 49))
								{
									return val;
								}
								switch (i)
								{
								case 53:
									num5 = (b << 8) & 0xFF00;
									break;
								case 54:
									num5 |= b & 0xFF;
									break;
								case 55:
									num6 = b;
									break;
								case 56:
									num7 = b;
									break;
								case 49:
									num8 = b;
									break;
								case 50:
									num9 = b;
									break;
								case 51:
									num10 = b;
									break;
								}
								if (i == 56)
								{
									if (num5 < 1 || num5 > 9999 || num6 < 1 || num6 > 12 || num7 < 1 || num7 > 31 || num8 < 0 || num8 > 23 || num9 < 0 || num9 > 59 || num10 < 0 || num10 > 59)
									{
										P_1 = Oc;
									}
									else
									{
										P_1 = new System.DateTime(num5, num6, num7, num8, num9, num10);
									}
								}
								if (val.Count == 0)
								{
									switch (i)
									{
									case 57:
										num4 |= (uint)(b << 24);
										break;
									case 58:
										num4 |= (uint)(b << 16) & 0xFF0000u;
										break;
									case 59:
										num4 |= (uint)(b << 8) & 0xFF00u;
										break;
									case 60:
										num4 |= b & 0xFFu;
										val.Add((int)num4);
										break;
									}
								}
								if (i == 65)
								{
									P_2 = b;
									return val;
								}
								break;
							}
						}
						continue;
						end_IL_014d:
						break;
					}
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iz() + ex.Message, true);
			}
			finally
			{
				if (val5 != null)
				{
					val5.Close();
				}
				if (val3 != null)
				{
					val3.Dispose();
				}
				if (val2 != null)
				{
					((Stream)val2).Close();
				}
			}
			return val;
		}

		private bool B(int P_0)
		{
			bool flag = false;
			try
			{
				Monitor.TryEnter(nX, P_0, ref flag);
				return flag;
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(nX);
				}
			}
		}

		private static bool E()
		{
			if (BM.Qz != null)
			{
				if (!bx.A(BM.Qz.awZ))
				{
					return BM.Qz.awZ == 21;
				}
				return true;
			}
			return false;
		}

		private void A(B P_0)
		{
			//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f2: Expected O, but got Unknown
			//IL_0409: Unknown result type (might be due to invalid IL or missing references)
			//IL_0413: Expected O, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_0428: Unknown result type (might be due to invalid IL or missing references)
			//IL_0432: Expected O, but got Unknown
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected O, but got Unknown
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected O, but got Unknown
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected O, but got Unknown
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			//IL_021e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Expected O, but got Unknown
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_0277: Expected O, but got Unknown
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Expected O, but got Unknown
			//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0305: Expected O, but got Unknown
			//IL_0341: Unknown result type (might be due to invalid IL or missing references)
			//IL_0348: Expected O, but got Unknown
			//IL_0384: Unknown result type (might be due to invalid IL or missing references)
			//IL_038b: Expected O, but got Unknown
			if (nx != null)
			{
				nx.CancelAsync();
			}
			if (nY != null)
			{
				nY.CancelAsync();
			}
			bool num = B(500);
			if (P_0.Boe == -1)
			{
				((ListView)Oo).Items.Clear();
				Oo.a();
				if (((ListView)Oo).Columns.Count == 0)
				{
					bool flag = E();
					int num2 = 0;
					int num3 = 0;
					ColumnHeader val = new ColumnHeader();
					val.TextAlign = (HorizontalAlignment)1;
					val.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JA();
					val.Width = 50;
					((ListView)Oo).Columns.Add(val);
					num2++;
					num3 += val.Width;
					if (!flag)
					{
						ColumnHeader val2 = new ColumnHeader();
						val2.TextAlign = (HorizontalAlignment)1;
						val2.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ja();
						val2.Width = 80;
						((ListView)Oo).Columns.Add(val2);
						num2++;
						num3 += val2.Width;
						ColumnHeader val3 = new ColumnHeader();
						val3.TextAlign = (HorizontalAlignment)1;
						val3.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JB();
						val3.Width = 70;
						((ListView)Oo).Columns.Add(val3);
						num2++;
						num3 += val3.Width;
					}
					ColumnHeader val4 = new ColumnHeader();
					val4.TextAlign = (HorizontalAlignment)1;
					val4.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jb();
					val4.Width = 70;
					((ListView)Oo).Columns.Add(val4);
					num2++;
					num3 += val4.Width;
					ColumnHeader val5 = new ColumnHeader();
					val5.TextAlign = (HorizontalAlignment)1;
					val5.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JC();
					val5.Width = 118;
					((ListView)Oo).Columns.Add(val5);
					num2++;
					num3 += val5.Width;
					ColumnHeader val6 = new ColumnHeader();
					val6.TextAlign = (HorizontalAlignment)1;
					val6.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jc();
					val6.Width = (flag ? 93 : 59);
					((ListView)Oo).Columns.Add(val6);
					OI = num2;
					num2++;
					num3 += val6.Width;
					ColumnHeader val7 = new ColumnHeader();
					val7.TextAlign = (HorizontalAlignment)1;
					val7.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JD();
					val7.Width = (flag ? 93 : 59);
					((ListView)Oo).Columns.Add(val7);
					Oi = num2;
					num2++;
					num3 += val7.Width;
					ColumnHeader val8 = new ColumnHeader();
					val8.TextAlign = (HorizontalAlignment)1;
					val8.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jd();
					val8.Width = 100;
					((ListView)Oo).Columns.Add(val8);
					OJ = num2;
					num2++;
					num3 += val8.Width;
					ColumnHeader val9 = new ColumnHeader();
					val9.Text = string.Empty;
					val9.Width = 24;
					((ListView)Oo).Columns.Add(val9);
					Oj = num2;
					num2++;
					num3 += val9.Width;
					ColumnHeader val10 = new ColumnHeader();
					val10.Text = string.Empty;
					val10.Width = 24;
					((ListView)Oo).Columns.Add(val10);
					OK = num2;
					num2++;
					num3 += val10.Width;
					ColumnHeader val11 = new ColumnHeader();
					val11.Text = string.Empty;
					val11.Width = 24;
					((ListView)Oo).Columns.Add(val11);
					Ok = num2;
					num2++;
					num3 += val11.Width;
					ColumnHeader val12 = new ColumnHeader();
					val12.Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JE();
					val12.Width = (flag ? 260 : 190);
					((Control)OQ).Width = val12.Width;
					((ListView)Oo).Columns.Add(val12);
					OL = num2;
					num2++;
					num3 += val12.Width;
				}
			}
			if (num)
			{
				nx = new BackgroundWorker();
				nx.WorkerSupportsCancellation = true;
				nx.DoWork += new DoWorkEventHandler(A);
				if (P_0.Boe == -1)
				{
					nx.RunWorkerCompleted += new RunWorkerCompletedEventHandler(A);
				}
				nx.RunWorkerAsync((object)P_0);
			}
		}

		private void A(object P_0, DoWorkEventArgs P_1)
		{
			//IL_0581: Unknown result type (might be due to invalid IL or missing references)
			//IL_058b: Expected O, but got Unknown
			lock (nX)
			{
				nP = -1;
				np = -1;
				nQ = -1;
				nq = -1;
				ns = 0;
				if (nx.CancellationPending)
				{
					P_1.Result = b.BoG;
					return;
				}
				B Boq = (B)P_1.Argument;
				if (OD)
				{
					this.a(Boq);
					e();
					P_1.Result = b.Bof;
					return;
				}
				if (!A(out var text))
				{
					P_1.Result = b.Bog;
					return;
				}
				if (nx.CancellationPending)
				{
					P_1.Result = b.BoG;
					return;
				}
				if (Boq.Boe == -1)
				{
					if (Boq.BoF == Bc.NO)
					{
						A(true);
					}
					else if (Boq.BoF == Bc.No)
					{
						A(false);
						e();
						Be.E.a();
						P_1.Result = b.Bof;
						return;
					}
				}
				while (!nx.CancellationPending)
				{
					try
					{
						if (BM.Qz.A(9500).ax() != 0)
						{
							P_1.Result = b.BoH;
							return;
						}
						nH = BM.Qz.A(9497).ax();
						nh = BM.Qz.A(9510).ax();
						int num = BM.Qz.A(9501).ax();
						int num2 = BM.Qz.A(9508).ax();
						int num3 = BM.Qz.A(9509).ax();
						A(num, text);
						if (num == -1)
						{
							A(Boq.BoF);
							e();
							Be.E.a();
							P_1.Result = b.Bof;
							return;
						}
						if (num < 0 || nH == 0)
						{
							P_1.Result = b.BoI;
							return;
						}
						if (nx.CancellationPending)
						{
							P_1.Result = b.BoG;
							return;
						}
						if (np == -1 || nP == -1 || nQ == -1 || nq == -1)
						{
							if (!A(ref num3, num2))
							{
								P_1.Result = b.Boh;
								return;
							}
							if (!A(num, num3, num2))
							{
								P_1.Result = b.Boh;
								return;
							}
							if (np == 0 && nQ == 0 && nq == 0 && nr == -1 && nR == -1)
							{
								A(Boq.BoF);
								e();
								Be.E.a();
								P_1.Result = b.Bof;
								return;
							}
						}
						if (nx.CancellationPending)
						{
							P_1.Result = b.BoG;
							return;
						}
						int num4 = ((nq <= nQ) ? (nH - np) : (nq - nQ));
						if (np + num4 > nH)
						{
							num4 = nH - np;
						}
						if ((nq > nQ || np < nq) && np + num4 > nq)
						{
							num4 = nq - np;
						}
						ns += num4;
						np += num4;
						if (np == nH)
						{
							np = 0;
						}
						bool flag = nP != num;
						if (np != num2 && (!flag || np != nS))
						{
							continue;
						}
						if (nx.CancellationPending)
						{
							P_1.Result = b.BoG;
							return;
						}
						a BoR = null;
						if (Boq.Boe == -1 && ny.ContainsKey(nP))
						{
							a a = ny[nP];
							if (a.BOz.Count == 1 && a.Bob.Count == 1 && !string.IsNullOrEmpty(a.BoE) && nZ.ContainsKey(a.BoE))
							{
								BoR = a;
							}
						}
						if (nx.CancellationPending)
						{
							P_1.Result = b.BoG;
							return;
						}
						int BoV = 0;
						int Bou = 0;
						int Bor = 0;
						int BoS = 0;
						int Bos = 0;
						int BoT = 0;
						int Bot = 0;
						int BoU = 0;
						if (BoR == null)
						{
							b b = A(ref BoV, ref Bou, ref Bor, ref BoS, ref Bos, ref BoT, ref Bot, ref BoU);
							if (b == b.BoG || b == b.Boh)
							{
								P_1.Result = b;
								return;
							}
						}
						if (Boq.Boe != -1)
						{
							((Control)Oo).Invoke((Action)delegate
							{
								//IL_0045: Unknown result type (might be due to invalid IL or missing references)
								//IL_004b: Expected O, but got Unknown
								//IL_0142: Unknown result type (might be due to invalid IL or missing references)
								//IL_014c: Expected O, but got Unknown
								//IL_016d: Unknown result type (might be due to invalid IL or missing references)
								//IL_0177: Expected O, but got Unknown
								if (((ListView)Oo).Items.Count != 0)
								{
									foreach (ListViewItem item in ((ListView)Oo).Items)
									{
										ListViewItem val2 = item;
										BoR = (a)val2.Tag;
										if (BoR.BOz.Count == 1 && BoR.BOz[0] == Boq.Boe)
										{
											BoR.BoB = ns;
											BoR.Bob = new List<System.DateTime>();
											BoR.Bob.Add(new System.DateTime(Bor, BoS, Bos, BoT, Bot, BoU));
											BoR.BoC = Bou;
											BoR.Boc = Bou - BoV;
											BoR.BoE = string.Empty;
											A(BoR, false, val2);
											nY = new BackgroundWorker();
											nY.WorkerSupportsCancellation = true;
											nY.DoWork += new DoWorkEventHandler(this.a);
											nY.RunWorkerAsync();
											break;
										}
									}
								}
							});
							P_1.Result = b.Bof;
							return;
						}
						bool flag2 = false;
						if (text != string.Empty)
						{
							string text2 = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Je();
							if (File.Exists(text2))
							{
								try
								{
									StreamReader val = File.OpenText(text2);
									try
									{
										string text3;
										while ((text3 = ((TextReader)val).ReadLine()) != null)
										{
											if (int.Parse(text3) == nP)
											{
												flag2 = true;
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
								}
							}
						}
						if (nx.CancellationPending)
						{
							P_1.Result = b.BoG;
							return;
						}
						if (BoR == null)
						{
							BoR = A(flag2, BoV, Bou, Bor, BoS, Bos, BoT, Bot, BoU);
						}
						else
						{
							nz[BoR.BoE] = BoR.BOz;
							OA[BoR.BoE] = BoR.BoA;
						}
						A(BoR, false, null);
						if (nx.CancellationPending)
						{
							P_1.Result = b.BoG;
							return;
						}
						nP--;
						if (nP < 0 || ns >= nH || nR == -1 || nr == -1 || nr >= nP + 1)
						{
							P_1.Result = b.Bof;
							A(Boq.BoF);
							e();
							Be.E.a();
							return;
						}
						if (!Be.b(num2))
						{
							P_1.Result = b.Boh;
							return;
						}
					}
					catch (System.Exception ex)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JF() + ex.Message, true);
						P_1.Result = b.BoI;
						return;
					}
				}
				P_1.Result = b.BoG;
			}
		}

		private void A(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Invalid comparison between Unknown and I4
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Invalid comparison between Unknown and I4
			try
			{
				if ((b)P_1.Result == Be.b.Bof)
				{
					Setting setting = BM.Qz.A(9500);
					if (setting != null)
					{
						setting.a(new EventHandler(f));
						setting.A(new EventHandler(f));
					}
				}
				else
				{
					if ((b)P_1.Result == Be.b.BoG)
					{
						return;
					}
					if ((b)P_1.Result == Be.b.Bog)
					{
						if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jf(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
						{
							bh bh = new bh(BM.Qz);
							DialogResult val = ((Form)bh).ShowDialog((IWin32Window)(object)this);
							((Component)bh).Dispose();
							if ((int)val == 1)
							{
								((Form)this).Close();
								BM.QQ.l(null, null);
							}
							else
							{
								((Form)this).Close();
							}
						}
						else
						{
							((Form)this).Close();
						}
					}
					else if ((b)P_1.Result == Be.b.BoH)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JG(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						((Form)this).Close();
					}
					else
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jg(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						((Form)this).Close();
					}
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JH() + ex.Message, true);
			}
		}

		private bool A(out string P_0)
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			nf = null;
			P_0 = string.Empty;
			string Bow = string.Empty;
			if (BM.Qz.A(ref Bow))
			{
				try
				{
					((Control)this).Invoke((Action)delegate
					{
						((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDK() + Bow + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu();
					});
				}
				catch
				{
				}
				P_0 = BM.Qz.aXD;
				if (string.IsNullOrEmpty(P_0))
				{
					P_0 = BM.A(Bow, BM.Qz.aXc);
					try
					{
						if (string.IsNullOrEmpty(P_0))
						{
							string text = Bow;
							List<string> obj2 = new List<string>();
							obj2.Add(BM.Qz.aXc);
							P_0 = BM.a(text, obj2);
						}
						BM.Qz.aXD = P_0;
					}
					catch
					{
						return false;
					}
				}
				nf = P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jh();
				Directory.CreateDirectory(nf);
				return true;
			}
			return false;
		}

		private void A(int P_0, string P_1)
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected O, but got Unknown
			if (!(P_1 != string.Empty))
			{
				return;
			}
			string text = P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Je();
			if (!File.Exists(text))
			{
				return;
			}
			int num = -1;
			try
			{
				StreamReader val = File.OpenText(text);
				try
				{
					string text2;
					while ((text2 = ((TextReader)val).ReadLine()) != null)
					{
						num = Math.Max(num, int.Parse(text2));
					}
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			catch
			{
			}
			if (num != -1 && P_0 < num)
			{
				string Box = P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JI() + N.A(false);
				((Control)this).Invoke((Action)delegate
				{
					//IL_001e: Unknown result type (might be due to invalid IL or missing references)
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDk() + Box, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDL(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				});
				ny.Clear();
				nZ.Clear();
				nz.Clear();
				OA.Clear();
				Oa.Clear();
				OB.Clear();
				Ob.Clear();
				OC.Clear();
				try
				{
					Directory.Move(nf, Box);
					Directory.CreateDirectory(nf);
				}
				catch
				{
				}
			}
		}

		private b A(ref int P_0, ref int P_1, ref int P_2, ref int P_3, ref int P_4, ref int P_5, ref int P_6, ref int P_7)
		{
			byte[] array = null;
			byte[] array2 = null;
			bool flag2;
			do
			{
				global::A.b n = global::A.A.n;
				global::A.A.n = global::A.b.q;
				flag2 = global::A.A.A(BM.Qz.aXc, global::A.f.Ba, (uint)nQ, Math.Min(16384u, (uint)nh), out array, out var flag);
				global::A.A.n = n;
				if (nx.CancellationPending)
				{
					return Be.b.BoG;
				}
				if (!flag2)
				{
					continue;
				}
				if (Oa.ContainsKey(nP) && OB.ContainsKey(nP))
				{
					flag2 = true;
				}
				else
				{
					int num;
					for (num = nQ + ns - nh; num >= nH; num -= nH)
					{
					}
					global::A.b n2 = global::A.A.n;
					global::A.A.n = global::A.b.q;
					flag2 = global::A.A.A(BM.Qz.aXc, global::A.f.Ba, (uint)num, (uint)nh, out array2, out flag);
					global::A.A.n = n2;
				}
				if (nx.CancellationPending)
				{
					return Be.b.BoG;
				}
			}
			while (!flag2 && OE);
			if (!flag2)
			{
				return Be.b.Boh;
			}
			P_0 = A(array);
			if (array2 != null)
			{
				P_1 = a(array2);
			}
			else if (OB.ContainsKey(nP))
			{
				P_1 = OB[nP];
			}
			if (array2 != null)
			{
				if (array2[3] == 1 && array2[8] == 72 && array2[9] == 65 && array2[10] == 76 && array2[11] == 84 && array2[12] == 69 && array2[13] == 67 && array2[14] == 72 && (array2[15] == 48 || array2[15] == 49))
				{
					P_2 = ((array2[56] << 8) & 0xFF00) | (array2[57] & 0xFF);
					P_3 = array2[58];
					P_4 = array2[59];
					P_5 = array2[52];
					P_6 = array2[53];
					P_7 = array2[54];
				}
			}
			else if (Oa.ContainsKey(nP))
			{
				System.DateTime dateTime = Oa[nP];
				P_2 = dateTime.Year;
				P_3 = dateTime.Month;
				P_4 = dateTime.Day;
				P_5 = dateTime.Hour;
				P_6 = dateTime.Minute;
				P_7 = dateTime.Second;
			}
			if (P_2 < 1 || P_2 > 9999 || P_3 < 1 || P_3 > 12 || P_4 < 1 || P_4 > 31 || P_5 < 0 || P_5 > 23 || P_6 < 0 || P_6 > 59 || P_7 < 0 || P_7 > 59)
			{
				P_2 = Oc.Year;
				P_3 = Oc.Month;
				P_4 = Oc.Day;
				P_5 = Oc.Hour;
				P_6 = Oc.Minute;
				P_7 = Oc.Second;
			}
			if (nx.CancellationPending)
			{
				return Be.b.BoG;
			}
			return Be.b.Bof;
		}

		private a A(bool P_0, int P_1, int P_2, int P_3, int P_4, int P_5, int P_6, int P_7, int P_8)
		{
			List<int> val = new List<int>();
			val.Add(nP);
			string text = A(val);
			if (text == null)
			{
				text = Be.a(val);
			}
			if (text == null)
			{
				text = string.Empty;
			}
			a a = new a
			{
				BOz = new List<int>(),
				BoA = (byte)BM.Qz.awZ,
				Boa = P_0,
				BoB = ns,
				Bob = new List<System.DateTime>(),
				BoC = P_2,
				Boc = P_2 - P_1,
				BoD = 0,
				Bod = 0,
				BoE = Path.GetFileNameWithoutExtension(text)
			};
			a.BOz.Add(nP);
			a.Bob.Add(new System.DateTime(P_3, P_4, P_5, P_6, P_7, P_8));
			ny[nP] = a;
			Oa[nP] = a.Bob[0];
			OB[nP] = a.BoC;
			Ob[nP] = a.BoD;
			OC[nP] = a.Bod;
			if (!string.IsNullOrEmpty(text))
			{
				nZ[a.BoE] = a;
				nz[a.BoE] = a.BOz;
				OA[a.BoE] = a.BoA;
			}
			return a;
		}

		private void a(B P_0)
		{
			nf = nG;
			if (P_0.BoF == Bc.NO)
			{
				A(true);
				A(Bc.NO);
			}
			else if (P_0.BoF == Bc.No)
			{
				A(false);
			}
			else if (P_0.BoF == Bc.NP)
			{
				A(P_0.BoF);
			}
			Be.E.a();
		}

		private void A(bool P_0)
		{
			if (nf == null || !Directory.Exists(nf))
			{
				return;
			}
			string[] files = Directory.GetFiles(nf);
			foreach (string text in files)
			{
				if (!nx.CancellationPending)
				{
					if ((text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()) || text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej())) && (BM.Tf.BCt.Contains(text) || !P_0))
					{
						A(text, true, true, -1);
					}
					continue;
				}
				break;
			}
		}

		private void A(Bc P_0)
		{
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			if (nf == null || !Directory.Exists(nf) || nx.CancellationPending)
			{
				return;
			}
			int Boy = 2147483647;
			((Control)Oo).Invoke((Action)delegate
			{
				for (int num = ((ListView)Oo).Items.Count - 1; num >= 0; num--)
				{
					a a = (a)((ListView)Oo).Items[num].Tag;
					if (a.BoA != 0 && a.BOz.Count == 1)
					{
						Boy = Math.Min(Boy, a.BOz[0]);
					}
				}
			});
			bool flag = P_0 == Bc.NO;
			string[] files = Directory.GetFiles(nf);
			foreach (string text in files)
			{
				if (!nx.CancellationPending)
				{
					if ((text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()) || text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej())) && !BM.Tf.BCt.Contains(text))
					{
						A(text, false, flag, Boy);
					}
					continue;
				}
				break;
			}
		}

		private void A(string P_0, bool P_1, bool P_2, int P_3)
		{
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			byte b = 255;
			List<int> val = new List<int>();
			List<System.DateTime> val2 = new List<System.DateTime>();
			MemoryStream val3 = null;
			ZipArchive val4 = null;
			ZipArchiveEntry val5 = null;
			Stream val6 = null;
			try
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(P_0);
				if (nZ.ContainsKey(fileNameWithoutExtension))
				{
					a a = nZ[fileNameWithoutExtension];
					bool flag = a.BoA == 0;
					if ((!P_1 || flag) && (!flag || P_2) && (a.BOz.Count != 1 || flag || P_3 == -1 || a.BOz[0] < P_3))
					{
						A(a, false, null);
					}
					return;
				}
				val3 = S.a(P_0, M.B());
				if (nx.CancellationPending)
				{
					return;
				}
				if (((Stream)val3).CanRead)
				{
					int boB = 0;
					if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
					{
						val4 = new ZipArchive((Stream)(object)val3, (ZipArchiveMode)0);
						if (nx.CancellationPending)
						{
							return;
						}
						System.Collections.Generic.IEnumerator<ZipArchiveEntry> enumerator = val4.Entries.GetEnumerator();
						try
						{
							while (((System.Collections.IEnumerator)enumerator).MoveNext())
							{
								ZipArchiveEntry current = enumerator.Current;
								if (current.Name.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()))
								{
									val5 = current;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator)?.Dispose();
						}
						if (nx.CancellationPending)
						{
							return;
						}
						if (val5 != null)
						{
							val6 = val5.Open();
							boB = (int)val5.Length;
						}
						if (nx.CancellationPending)
						{
							return;
						}
					}
					else
					{
						val6 = (Stream)new FileStream(P_0, (FileMode)3);
						boB = (int)((Stream)val3).Length;
					}
					int num = -1;
					int num2 = 0;
					bool flag2 = false;
					int num3;
					do
					{
						if (nx.CancellationPending)
						{
							return;
						}
						num3 = val6.ReadByte();
						if (num3 == -1)
						{
							break;
						}
						if (num3 != 255)
						{
							byte[] array = new byte[4];
							if (!N.A(val6, array, 0, 4))
							{
								break;
							}
							uint num4 = (uint)(array[0] << 24) | ((uint)(array[1] << 16) & 0xFF0000u) | ((uint)(array[2] << 8) & 0xFF00u) | (array[3] & 0xFFu);
							if (num4 == 4294967295u || num4 == 0 || (num4 > 131072 && num3 != 2 && (num3 & 0xF) != 9 && num3 != 13))
							{
								break;
							}
							if (num3 == 14)
							{
								uint num5 = 0u;
								byte[] array2 = new byte[num4 - 5];
								if (!N.A(val6, array2, 0, (int)(num4 - 5)))
								{
									flag2 = true;
								}
								else
								{
									for (int i = 5; i < num4; i++)
									{
										if (nx.CancellationPending)
										{
											return;
										}
										byte b2 = array2[i - 5];
										switch ((i - 5) % 4)
										{
										case 0:
											num5 = (uint)(b2 << 24) & 0xFF000000u;
											break;
										case 1:
											num5 |= (uint)(b2 << 16) & 0xFF0000u;
											break;
										case 2:
											num5 |= (uint)(b2 << 8) & 0xFF00u;
											break;
										case 3:
											num5 |= b2 & 0xFFu;
											val.Add((int)num5);
											break;
										}
									}
								}
							}
							else if (num3 == 1)
							{
								uint num6 = 0u;
								int num7 = 0;
								int num8 = 1;
								int num9 = 1;
								int num10 = 1;
								int num11 = 1;
								int num12 = 1;
								byte[] array3 = new byte[num4 - 5];
								if (!N.A(val6, array3, 0, (int)(num4 - 5)))
								{
									flag2 = true;
								}
								else
								{
									for (int j = 5; j < num4; j++)
									{
										if (nx.CancellationPending)
										{
											return;
										}
										byte b3 = array3[j - 5];
										if ((j == 5 && b3 != 72) || (j == 6 && b3 != 65) || (j == 7 && b3 != 76) || (j == 8 && b3 != 84) || (j == 9 && b3 != 69) || (j == 10 && b3 != 67) || (j == 11 && b3 != 72) || (j == 12 && b3 != 48 && b3 != 49))
										{
											flag2 = true;
											continue;
										}
										switch (j)
										{
										case 53:
											num7 = (b3 << 8) & 0xFF00;
											break;
										case 54:
											num7 |= b3 & 0xFF;
											break;
										case 55:
											num8 = b3;
											break;
										case 56:
											num9 = b3;
											break;
										case 49:
											num10 = b3;
											break;
										case 50:
											num11 = b3;
											break;
										case 51:
											num12 = b3;
											break;
										}
										if (j == 56)
										{
											System.DateTime dateTime = ((num7 >= 1 && num7 <= 9999 && num8 >= 1 && num8 <= 12 && num9 >= 1 && num9 <= 31 && num10 >= 0 && num10 <= 23 && num11 >= 0 && num11 <= 59 && num12 >= 0 && num12 <= 59) ? new System.DateTime(num7, num8, num9, num10, num11, num12) : Oc);
											if (!val2.Contains(dateTime))
											{
												val2.Add(dateTime);
											}
										}
										switch (j)
										{
										case 57:
											num6 |= (uint)(b3 << 24);
											break;
										case 58:
											num6 |= (uint)(b3 << 16) & 0xFF0000u;
											break;
										case 59:
											num6 |= (uint)(b3 << 8) & 0xFF00u;
											break;
										case 60:
											num6 |= b3 & 0xFFu;
											if (!val.Contains((int)num6))
											{
												val.Add((int)num6);
											}
											break;
										}
										if (j == 65 && b == 255)
										{
											b = b3;
											bool flag3 = b == 0;
											if ((P_1 && !flag3) || (flag3 && !P_2) || (val.Count == 1 && !flag3 && P_3 != -1 && val[0] >= P_3))
											{
												return;
											}
										}
									}
								}
							}
							else if ((num3 & 0xF) == 7 || num3 == 12)
							{
								if (num3 == 12)
								{
									byte[] array4 = new byte[2];
									if (!N.A(val6, array4, 0, 2))
									{
										break;
									}
								}
								byte[] array5 = new byte[4];
								if (!N.A(val6, array5, 0, 4))
								{
									break;
								}
								num2 = (array5[0] << 24) | ((array5[1] << 16) & 0xFF0000) | ((array5[2] << 8) & 0xFF00) | (array5[3] & 0xFF);
								if (num == -1)
								{
									num = num2;
								}
								uint num13 = ((num3 != 12) ? (num4 - 9) : (num4 - 11));
								byte[] array6 = new byte[num13];
								if (!N.A(val6, array6, 0, (int)num13))
								{
									flag2 = true;
									break;
								}
							}
							else
							{
								byte[] array7 = new byte[num4 - 5];
								if (!N.A(val6, array7, 0, (int)(num4 - 5)))
								{
									flag2 = true;
									break;
								}
							}
						}
						if (nx.CancellationPending)
						{
							return;
						}
					}
					while (num3 != -1 && !flag2);
					if (val.Count != 0 && b != 255 && num != -1 && num2 != 0)
					{
						a a2 = new a
						{
							BOz = new List<int>(),
							BoA = b,
							Boa = true,
							BoB = boB,
							Bob = new List<System.DateTime>(),
							BoC = num2,
							Boc = num2 - num,
							BoD = 0,
							Bod = 0,
							BoE = fileNameWithoutExtension
						};
						a2.BOz.AddRange((System.Collections.Generic.IEnumerable<int>)val);
						a2.Bob.AddRange((System.Collections.Generic.IEnumerable<System.DateTime>)val2);
						if (val.Count == 1)
						{
							ny[val[0]] = a2;
							Oa[val[0]] = a2.Bob[0];
							OB[val[0]] = a2.BoC;
						}
						nZ[a2.BoE] = a2;
						nz[a2.BoE] = a2.BOz;
						OA[a2.BoE] = a2.BoA;
						if (nx.CancellationPending)
						{
							return;
						}
						A(a2, false, null);
					}
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ji() + ex.Message, true);
			}
			finally
			{
				if (val6 != null)
				{
					val6.Close();
				}
				if (val4 != null)
				{
					val4.Dispose();
				}
				if (val3 != null)
				{
					((Stream)val3).Close();
				}
			}
			Thread.Sleep(0);
		}

		private void e()
		{
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			if (nf == null || !Directory.Exists(nf))
			{
				return;
			}
			List<string> val = null;
			try
			{
				val = Enumerable.ToList<string>(Enumerable.Select<FileInfo, string>((System.Collections.Generic.IEnumerable<FileInfo>)Enumerable.OrderBy<FileInfo, System.DateTime>((System.Collections.Generic.IEnumerable<FileInfo>)new DirectoryInfo(nf).GetFiles(), (Func<FileInfo, System.DateTime>)((FileInfo P_0) => ((FileSystemInfo)P_0).LastWriteTime)), (Func<FileInfo, string>)((FileInfo P_0) => ((FileSystemInfo)P_0).FullName)));
			}
			catch
			{
				val = null;
			}
			if (val == null)
			{
				return;
			}
			Enumerator<string> enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (nx.CancellationPending)
					{
						break;
					}
					if (current.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()) || current.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
					{
						C(current);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private void C(string P_0)
		{
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Expected O, but got Unknown
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06eb: Expected O, but got Unknown
			List<int> val = new List<int>();
			MemoryStream val2 = null;
			ZipArchive val3 = null;
			ZipArchiveEntry val4 = null;
			Stream val5 = null;
			int num = 0;
			int num2 = 0;
			int num3 = -1;
			int num4 = -1;
			int num5 = -1;
			int num6 = -1;
			try
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(P_0);
				if (nZ.ContainsKey(fileNameWithoutExtension))
				{
					a a = nZ[fileNameWithoutExtension];
					if (a.BoD != 0 || a.Bod != 0)
					{
						return;
					}
				}
				val2 = S.a(P_0, M.B());
				if (nx.CancellationPending)
				{
					return;
				}
				if (((Stream)val2).CanRead)
				{
					if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
					{
						val3 = new ZipArchive((Stream)(object)val2, (ZipArchiveMode)0);
						if (nx.CancellationPending)
						{
							return;
						}
						System.Collections.Generic.IEnumerator<ZipArchiveEntry> enumerator = val3.Entries.GetEnumerator();
						try
						{
							while (((System.Collections.IEnumerator)enumerator).MoveNext())
							{
								ZipArchiveEntry current = enumerator.Current;
								if (current.Name.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()))
								{
									val4 = current;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator)?.Dispose();
						}
						if (nx.CancellationPending)
						{
							return;
						}
						if (val4 != null)
						{
							val5 = val4.Open();
							_ = val4.Length;
						}
						if (nx.CancellationPending)
						{
							return;
						}
					}
					else
					{
						val5 = (Stream)new FileStream(P_0, (FileMode)3);
						_ = ((Stream)val2).Length;
					}
					bool flag = false;
					int num7;
					do
					{
						if (nx.CancellationPending)
						{
							return;
						}
						num7 = val5.ReadByte();
						if (num7 == -1)
						{
							break;
						}
						if (num7 != 255)
						{
							byte[] array = new byte[4];
							if (!N.A(val5, array, 0, 4))
							{
								break;
							}
							uint num8 = (uint)(array[0] << 24) | ((uint)(array[1] << 16) & 0xFF0000u) | ((uint)(array[2] << 8) & 0xFF00u) | (array[3] & 0xFFu);
							if (num8 == 4294967295u || num8 == 0 || (num8 > 131072 && num7 != 2 && (num7 & 0xF) != 9 && num7 != 13))
							{
								break;
							}
							if (num7 == 14)
							{
								uint num9 = 0u;
								byte[] array2 = new byte[num8 - 5];
								if (!N.A(val5, array2, 0, (int)(num8 - 5)))
								{
									flag = true;
								}
								else
								{
									for (int i = 5; i < num8; i++)
									{
										if (nx.CancellationPending)
										{
											return;
										}
										byte b = array2[i - 5];
										switch ((i - 5) % 4)
										{
										case 0:
											num9 = (uint)(b << 24) & 0xFF000000u;
											break;
										case 1:
											num9 |= (uint)(b << 16) & 0xFF0000u;
											break;
										case 2:
											num9 |= (uint)(b << 8) & 0xFF00u;
											break;
										case 3:
											num9 |= b & 0xFFu;
											val.Add((int)num9);
											break;
										}
									}
								}
							}
							else if (num7 == 1)
							{
								uint num10 = 0u;
								byte[] array3 = new byte[num8 - 5];
								if (!N.A(val5, array3, 0, (int)(num8 - 5)))
								{
									flag = true;
								}
								else
								{
									for (int j = 5; j < num8; j++)
									{
										if (nx.CancellationPending)
										{
											return;
										}
										byte b2 = array3[j - 5];
										if ((j == 5 && b2 != 72) || (j == 6 && b2 != 65) || (j == 7 && b2 != 76) || (j == 8 && b2 != 84) || (j == 9 && b2 != 69) || (j == 10 && b2 != 67) || (j == 11 && b2 != 72) || (j == 12 && b2 != 48 && b2 != 49))
										{
											flag = true;
											continue;
										}
										switch (j)
										{
										case 57:
											num10 |= (uint)(b2 << 24);
											break;
										case 58:
											num10 |= (uint)(b2 << 16) & 0xFF0000u;
											break;
										case 59:
											num10 |= (uint)(b2 << 8) & 0xFF00u;
											break;
										case 60:
											num10 |= b2 & 0xFFu;
											if (!val.Contains((int)num10))
											{
												val.Add((int)num10);
											}
											break;
										}
									}
								}
							}
							else if ((num7 & 0xF) == 6 || num7 == 11)
							{
								int num11;
								if (num7 == 11)
								{
									byte[] array4 = new byte[2];
									if (!N.A(val5, array4, 0, 2))
									{
										break;
									}
									num11 = ((array4[0] << 8) & 0xFF00) | (array4[1] & 0xFF);
								}
								else
								{
									num11 = (num7 >> 4) & 0xF;
								}
								uint num12 = ((num7 != 11) ? (num8 - 5) : (num8 - 7));
								byte[] array5 = new byte[num12];
								if (!N.A(val5, array5, 0, (int)num12))
								{
									flag = true;
									break;
								}
								uint num13 = num12 / 2;
								for (int k = 0; k < num13; k++)
								{
									switch ((ushort)(((array5[2 * k] << 8) & 0xFF00) | (array5[2 * k + 1] & 0xFF)))
									{
									case 384:
										num3 = num11;
										num5 = k;
										break;
									case 224:
										num4 = num11;
										num6 = k;
										break;
									}
								}
							}
							else if ((num7 & 0xF) == 7 || num7 == 12)
							{
								int num14;
								if (num7 == 12)
								{
									byte[] array6 = new byte[2];
									if (!N.A(val5, array6, 0, 2))
									{
										break;
									}
									num14 = ((array6[0] << 8) & 0xFF00) | (array6[1] & 0xFF);
								}
								else
								{
									num14 = (num7 >> 4) & 0xF;
								}
								byte[] array7 = new byte[4];
								if (!N.A(val5, array7, 0, 4))
								{
									break;
								}
								uint num15 = ((num7 != 12) ? (num8 - 9) : (num8 - 11));
								byte[] array8 = new byte[num15];
								if (!N.A(val5, array8, 0, (int)num15))
								{
									flag = true;
									break;
								}
								if (num3 != -1 && num5 != -1 && num14 == num3)
								{
									int num16 = (array8[4 * num5] << 24) | ((array8[4 * num5 + 1] << 16) & 0xFF0000) | ((array8[4 * num5 + 2] << 8) & 0xFF00) | (array8[4 * num5 + 3] & 0xFF);
									num = Math.Max(num, num16);
								}
								if (num4 != -1 && num6 != -1 && num14 == num4)
								{
									int num17 = (array8[4 * num6] << 24) | ((array8[4 * num6 + 1] << 16) & 0xFF0000) | ((array8[4 * num6 + 2] << 8) & 0xFF00) | (array8[4 * num6 + 3] & 0xFF);
									num2 = Math.Max(num2, num17);
								}
							}
							else
							{
								byte[] array9 = new byte[num8 - 5];
								if (!N.A(val5, array9, 0, (int)(num8 - 5)))
								{
									flag = true;
									break;
								}
							}
						}
						if (nx.CancellationPending)
						{
							return;
						}
					}
					while (num7 != -1 && !flag);
					if (val.Count != 0 && num3 != -1 && num4 != -1 && (num != 0 || num2 != 0))
					{
						if (nZ.ContainsKey(fileNameWithoutExtension))
						{
							a Boz = nZ[fileNameWithoutExtension];
							Boz.BoD = num;
							Boz.Bod = num2;
							((Control)Oo).Invoke((Action)delegate
							{
								//IL_0035: Unknown result type (might be due to invalid IL or missing references)
								//IL_003b: Expected O, but got Unknown
								if (((ListView)Oo).Items.Count != 0)
								{
									foreach (ListViewItem item in ((ListView)Oo).Items)
									{
										ListViewItem val6 = item;
										if ((a)val6.Tag == Boz)
										{
											A(Boz, false, val6);
											break;
										}
									}
								}
							});
						}
						if (val.Count == 1)
						{
							Ob[val[0]] = num;
							OC[val[0]] = num2;
						}
					}
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JJ() + ex.Message, true);
			}
			finally
			{
				if (val5 != null)
				{
					val5.Close();
				}
				if (val3 != null)
				{
					val3.Dispose();
				}
				if (val2 != null)
				{
					((Stream)val2).Close();
				}
			}
			Thread.Sleep(0);
		}

		private void a(object P_0, DoWorkEventArgs P_1)
		{
			//IL_0296: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Expected O, but got Unknown
			//IL_02a3: Expected O, but got Unknown
			if (!Monitor.TryEnter(nX, 1000))
			{
				return;
			}
			try
			{
				nP = -1;
				np = -1;
				nQ = -1;
				nq = -1;
				ns = 0;
				int BPa = 2147483647;
				Action BPB = default(Action);
				while (!nY.CancellationPending)
				{
					try
					{
						if (BM.Qz.A(9500).ax() != 0)
						{
							break;
						}
						nH = BM.Qz.A(9497).ax();
						nh = BM.Qz.A(9510).ax();
						int num = BM.Qz.A(9501).ax();
						int num2 = BM.Qz.A(9508).ax();
						int num3 = BM.Qz.A(9509).ax();
						if (num < 0 || nH == 0 || nY.CancellationPending || ((np == -1 || nP == -1 || nQ == -1 || nq == -1) && (!A(ref num3, num2) || !A(num, num3, num2))) || nY.CancellationPending)
						{
							break;
						}
						int num4 = ((nq <= nQ) ? (nH - np) : (nq - nQ));
						if (np + num4 > nH)
						{
							num4 = nH - np;
						}
						if ((nq > nQ || np < nq) && np + num4 > nq)
						{
							num4 = nq - np;
						}
						ns += num4;
						np += num4;
						if (np == nH)
						{
							np = 0;
						}
						bool flag = nP != num;
						if (np != num2 && (!flag || np != nS))
						{
							continue;
						}
						BPa = nP;
						nP--;
						if (nP < 0 || ns >= nH || nR == -1 || nr == -1 || nr >= nP + 1)
						{
							if (nY.CancellationPending)
							{
								break;
							}
							ab oo = Oo;
							Action obj = BPB;
							if (obj == null)
							{
								Action val = delegate
								{
									for (int num5 = ((ListView)Oo).Items.Count - 1; num5 >= 0; num5--)
									{
										a a = (a)((ListView)Oo).Items[num5].Tag;
										bool flag2 = a.BoA != 0;
										if (a.BOz.Count == 1 && a.BOz[0] < BPa && flag2 && !a.Boa)
										{
											Be.a(a.BOz[0]);
											((ListView)Oo).Items[num5].Tag = null;
											((ListView)Oo).Items.RemoveAt(num5);
											if (ny.ContainsKey(a.BOz[0]))
											{
												ny.Remove(a.BOz[0]);
											}
											if (Oa.ContainsKey(a.BOz[0]))
											{
												Oa.Remove(a.BOz[0]);
											}
											if (OB.ContainsKey(a.BOz[0]))
											{
												OB.Remove(a.BOz[0]);
											}
											if (Ob.ContainsKey(a.BOz[0]))
											{
												Ob.Remove(a.BOz[0]);
											}
											if (OC.ContainsKey(a.BOz[0]))
											{
												OC.Remove(a.BOz[0]);
											}
										}
									}
									Oo.a();
									((Control)Oo).Invalidate();
								};
								Action val2 = val;
								BPB = val;
								obj = val2;
							}
							((Control)oo).Invoke(obj);
							break;
						}
						if (nY.CancellationPending || !b(num2))
						{
							break;
						}
					}
					catch
					{
						break;
					}
				}
			}
			finally
			{
				Monitor.Exit(nX);
			}
		}

		private void f(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					C c = f;
					((Control)this).Invoke((System.Delegate)c, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			if (((ListControl)Op).SelectedIndex == 1 || !(P_0 is Setting))
			{
				return;
			}
			int num = (P_0 as Setting).ax();
			Setting setting = BM.Qz.A(9501);
			if (setting != null)
			{
				int num2 = setting.ax();
				if (num2 != -1)
				{
					if (num != 0 && num != 12 && Ol == 0)
					{
						a a = new a
						{
							BOz = new List<int>(),
							BoA = (byte)BM.Qz.awZ,
							Boa = false,
							BoB = -1,
							Bob = new List<System.DateTime>(),
							BoC = -1,
							Boc = -1,
							BoD = 0,
							Bod = 0,
							BoE = string.Empty
						};
						a.BOz.Add(num2);
						a.Bob.Add(System.DateTime.Now);
						ny[num2] = a;
						A(a, true, null);
					}
					else if (num == 0 && Ol != 0 && Ol != 12)
					{
						B b = default(B);
						b.Boe = num2;
						b.BoF = (Bc)((ListControl)Op).SelectedIndex;
						B b2 = b;
						A(b2);
					}
				}
			}
			Ol = num;
		}

		private void A(a P_0, bool P_1, ListViewItem P_2)
		{
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			if (((Control)this).InvokeRequired)
			{
				try
				{
					c c = A;
					((Control)this).BeginInvoke((System.Delegate)c, new object[3] { P_0, P_1, P_2 });
					return;
				}
				catch
				{
					return;
				}
			}
			bool flag = E();
			bool flag2 = P_0.BoA == 0;
			string[] array = A(P_0, flag, P_1, flag2);
			bool flag3 = false;
			if (flag2)
			{
				string text = string.Empty;
				if (!string.IsNullOrEmpty(nf) && !string.IsNullOrEmpty(P_0.BoE))
				{
					text = nf + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + P_0.BoE + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej();
				}
				flag3 = BM.Tf.BCt.Contains(text);
			}
			if (P_2 == null)
			{
				ListViewItem val = new ListViewItem(array)
				{
					Tag = P_0
				};
				if (P_1)
				{
					((ListView)Oo).Items.Insert(0, val);
				}
				else if (((ListView)Oo).Items.Count == 0)
				{
					((ListView)Oo).Items.Add(val);
				}
				else
				{
					for (int i = 0; i < ((ListView)Oo).Items.Count; i++)
					{
						a a = (a)((ListView)Oo).Items[i].Tag;
						bool flag4 = a.BoA == 0;
						bool flag5 = false;
						if (flag4)
						{
							string text2 = string.Empty;
							if (!string.IsNullOrEmpty(nf) && !string.IsNullOrEmpty(a.BoE))
							{
								text2 = nf + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + a.BoE + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej();
							}
							flag5 = BM.Tf.BCt.Contains(text2);
						}
						bool flag6 = P_0.Bob[P_0.Bob.Count - 1] >= a.Bob[a.Bob.Count - 1];
						bool flag7 = P_0.BOz[P_0.BOz.Count - 1] >= a.BOz[a.BOz.Count - 1];
						bool flag8;
						if (flag)
						{
							flag8 = (flag3 ? (!flag4 || flag6) : ((!(flag2 && flag4)) ? (flag7 && !flag5) : (flag6 && !flag5)));
						}
						else
						{
							bool num = P_0.Bob[P_0.Bob.Count - 1] != Oc;
							bool flag9 = a.Bob[a.Bob.Count - 1] != Oc;
							flag8 = ((num && flag9) ? flag6 : ((!flag2 && !flag4) ? flag7 : ((!flag2) ? (!flag5) : flag3)));
						}
						if (flag8)
						{
							((ListView)Oo).Items.Insert(i, val);
							break;
						}
						if (i == ((ListView)Oo).Items.Count - 1)
						{
							((ListView)Oo).Items.Add(val);
							break;
						}
					}
				}
				Oo.a();
				((Control)Oo).Invalidate();
				this.c();
				return;
			}
			P_2.Tag = P_0;
			if (P_2.SubItems.Count == array.Length)
			{
				for (int j = 0; j < P_2.SubItems.Count; j++)
				{
					P_2.SubItems[j].Text = array[j];
				}
			}
		}

		private string[] A(a P_0, bool P_1, bool P_2, bool P_3)
		{
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0368: Unknown result type (might be due to invalid IL or missing references)
			//IL_036d: Unknown result type (might be due to invalid IL or missing references)
			string text = null;
			string text2 = null;
			if (!P_1)
			{
				System.DateTime now = System.DateTime.Now;
				if (P_0.Bob.Count <= 1)
				{
					text = ((P_0.Bob[0].Year == now.Year && P_0.Bob[0].Month == now.Month && P_0.Bob[0].Day == now.Day) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JK() : ((!(P_0.Bob[0] == Oc)) ? string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jk(), (object)P_0.Bob[0]) : string.Empty));
					text2 = ((!(P_0.Bob[0] == Oc)) ? P_0.Bob[0].ToString(DateTimeFormatInfo.CurrentInfo.ShortTimePattern) : string.Empty);
				}
				else
				{
					text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jj();
					text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jj();
				}
			}
			string text3 = ((!P_2) ? string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JL(), (object)((float)P_0.BoB / 1048576f)) : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG());
			string text4;
			if (P_2)
			{
				text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
			}
			else
			{
				TimeSpan val = TimeSpan.FromMilliseconds((long)P_0.Boc, 0L);
				text4 = ((P_0.Boc < 60000) ? (((TimeSpan)(ref val)).Seconds + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl()) : ((P_0.Boc >= 3600000) ? string.Concat(new string[8]
				{
					((TimeSpan)(ref val)).Hours.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jm(),
					(((TimeSpan)(ref val)).Minutes < 10) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn() : string.Empty,
					((TimeSpan)(ref val)).Minutes.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JM(),
					(((TimeSpan)(ref val)).Seconds < 10) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn() : string.Empty,
					((TimeSpan)(ref val)).Seconds.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl()
				}) : string.Concat(new string[5]
				{
					((TimeSpan)(ref val)).Minutes.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JM(),
					(((TimeSpan)(ref val)).Seconds < 10) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn() : string.Empty,
					((TimeSpan)(ref val)).Seconds.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jl()
				})));
				if (P_0.Boc < P_0.BoC - 1000)
				{
					text4 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JN();
				}
			}
			string text5 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
			if (P_0.BoD != 0)
			{
				text5 = bS.a(P_0.BoD, 1, -1);
			}
			string text6 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
			if (P_0.Bod != 0)
			{
				text6 = bS.a(P_0.Bod, 3, -1);
			}
			bool flag = P_0.BOz.Count > 1;
			string text7 = (flag ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jn() : (P_3 ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JO() : (P_2 ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jo() : (P_0.Boa ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JP() : ((!nT) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iQ())))));
			string boE = P_0.BoE;
			string text8 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
			if (!P_3)
			{
				if (flag)
				{
					int num = 2147483647;
					int num2 = -2147483648;
					Enumerator<int> enumerator = P_0.BOz.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current = enumerator.Current;
							num = Math.Min(num, current);
							num2 = Math.Max(num2, current);
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					text8 = num + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo() + num2;
				}
				else if (P_0.BOz.Count == 1)
				{
					text8 = P_0.BOz[0].ToString();
				}
			}
			string text9 = (File.Exists(C()) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JQ() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jp());
			if (P_1)
			{
				return new string[10]
				{
					text8,
					text3,
					text4,
					text5,
					text6,
					text7,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jq(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JR(),
					text9,
					boE
				};
			}
			return new string[12]
			{
				text8,
				text,
				text2,
				text3,
				text4,
				text5,
				text6,
				text7,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jq(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JR(),
				text9,
				boE
			};
		}

		private void A(object P_0, DrawListViewItemEventArgs P_1)
		{
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			if (((ListView)Oo).SelectedItems.Contains(P_1.Item))
			{
				P_1.Graphics.FillRectangle(Brushes.DodgerBlue, P_1.Bounds);
				P_1.DrawFocusRectangle();
				return;
			}
			SolidBrush val = new SolidBrush(((Control)Oo).BackColor);
			try
			{
				P_1.Graphics.FillRectangle((Brush)(object)val, P_1.Bounds);
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}

		private void A(object P_0, DrawListViewSubItemEventArgs P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected I4, but got Unknown
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0476: Unknown result type (might be due to invalid IL or missing references)
			//IL_0481: Unknown result type (might be due to invalid IL or missing references)
			//IL_0486: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected O, but got Unknown
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_0227: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03da: Unknown result type (might be due to invalid IL or missing references)
			//IL_03df: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0404: Unknown result type (might be due to invalid IL or missing references)
			//IL_0409: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0423: Unknown result type (might be due to invalid IL or missing references)
			//IL_0428: Unknown result type (might be due to invalid IL or missing references)
			//IL_0435: Unknown result type (might be due to invalid IL or missing references)
			//IL_043a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Unknown result type (might be due to invalid IL or missing references)
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0375: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0384: Unknown result type (might be due to invalid IL or missing references)
			//IL_0389: Unknown result type (might be due to invalid IL or missing references)
			//IL_0393: Unknown result type (might be due to invalid IL or missing references)
			//IL_0398: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
			TextFormatFlags val = (TextFormatFlags)2052;
			HorizontalAlignment textAlign = P_1.Header.TextAlign;
			switch ((int)textAlign)
			{
			case 0:
				val = (TextFormatFlags)(val | 0);
				break;
			case 2:
				val = (TextFormatFlags)(val | 1);
				break;
			case 1:
				val = (TextFormatFlags)(val | 2);
				break;
			}
			if (P_1.ColumnIndex >= Oj)
			{
				a a = (a)P_1.Item.Tag;
				bool flag = a.BoA == 0;
				if ((a.BOz.Count != 1 && P_1.ColumnIndex == Oj) || (flag && P_1.ColumnIndex == Oj))
				{
					return;
				}
				bool flag2 = a.Boa || flag;
				bool flag3 = false;
				if (P_1.ColumnIndex == Oj)
				{
					flag3 = nT || a.Boa;
				}
				else if (P_1.ColumnIndex == OL)
				{
					flag3 = !flag2;
				}
				Rectangle bounds;
				if (P_1.ColumnIndex == OL)
				{
					Font val2 = new Font(((Control)Oo).Font.FontFamily, ((Control)Oo).Font.Size, (FontStyle)4);
					try
					{
						if (flag3)
						{
							TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, P_1.SubItem.Text, val2, P_1.Bounds, Color.Gray, val);
							return;
						}
						if (((Point)(ref Oh)).X != 0 && ((Point)(ref Oh)).Y != 0)
						{
							int x = ((Point)(ref Oh)).X;
							bounds = P_1.SubItem.Bounds;
							if (x > ((Rectangle)(ref bounds)).Left)
							{
								int x2 = ((Point)(ref Oh)).X;
								bounds = P_1.SubItem.Bounds;
								if (x2 < ((Rectangle)(ref bounds)).Right)
								{
									int y = ((Point)(ref Oh)).Y;
									bounds = P_1.SubItem.Bounds;
									if (y > ((Rectangle)(ref bounds)).Top)
									{
										int y2 = ((Point)(ref Oh)).Y;
										bounds = P_1.SubItem.Bounds;
										if (y2 < ((Rectangle)(ref bounds)).Bottom)
										{
											TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, P_1.SubItem.Text, val2, P_1.Bounds, Color.LightBlue, val);
											return;
										}
									}
								}
							}
						}
						TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, P_1.SubItem.Text, val2, P_1.Bounds, ((Control)Oo).ForeColor, val);
						return;
					}
					finally
					{
						((System.IDisposable)val2)?.Dispose();
					}
				}
				Image val3 = null;
				if (P_1.ColumnIndex == Oj)
				{
					val3 = (Image)(object)CM.B();
				}
				else if (P_1.ColumnIndex == OK)
				{
					val3 = (Image)(object)CM.C();
				}
				else if (P_1.ColumnIndex == Ok)
				{
					val3 = (Image)(object)CM.b();
				}
				if (val3 == null)
				{
					return;
				}
				bounds = P_1.Bounds;
				int num = (((Rectangle)(ref bounds)).Width - val3.Width) / 2;
				bounds = P_1.Bounds;
				int num2 = (((Rectangle)(ref bounds)).Height - val3.Height) / 2;
				if (flag3)
				{
					return;
				}
				if (((Point)(ref Oh)).X != 0 && ((Point)(ref Oh)).Y != 0)
				{
					int x3 = ((Point)(ref Oh)).X;
					bounds = P_1.SubItem.Bounds;
					if (x3 > ((Rectangle)(ref bounds)).Left)
					{
						int x4 = ((Point)(ref Oh)).X;
						bounds = P_1.SubItem.Bounds;
						if (x4 < ((Rectangle)(ref bounds)).Right)
						{
							int y3 = ((Point)(ref Oh)).Y;
							bounds = P_1.SubItem.Bounds;
							if (y3 > ((Rectangle)(ref bounds)).Top)
							{
								int y4 = ((Point)(ref Oh)).Y;
								bounds = P_1.SubItem.Bounds;
								if (y4 < ((Rectangle)(ref bounds)).Bottom)
								{
									Graphics graphics = P_1.Graphics;
									Pen lightBlue = Pens.LightBlue;
									bounds = P_1.Bounds;
									int x5 = ((Rectangle)(ref bounds)).X;
									bounds = P_1.Bounds;
									int y5 = ((Rectangle)(ref bounds)).Y;
									bounds = P_1.Bounds;
									int num3 = ((Rectangle)(ref bounds)).Width - 1;
									bounds = P_1.Bounds;
									graphics.DrawRectangle(lightBlue, x5, y5, num3, ((Rectangle)(ref bounds)).Height - 1);
								}
							}
						}
					}
				}
				Image obj = val3;
				Color foreColor = ((Control)Oo).ForeColor;
				float num4 = (int)((Color)(ref foreColor)).R;
				foreColor = ((Control)Oo).ForeColor;
				float num5 = (int)((Color)(ref foreColor)).G;
				foreColor = ((Control)Oo).ForeColor;
				Image val4 = (Image)(object)O.A(obj, 1f, 0f, 0f, 0f, 0f, num4, num5, (int)((Color)(ref foreColor)).B);
				try
				{
					Graphics graphics2 = P_1.Graphics;
					bounds = P_1.Bounds;
					int num6 = ((Rectangle)(ref bounds)).X + num;
					bounds = P_1.Bounds;
					graphics2.DrawImageUnscaled(val4, num6, ((Rectangle)(ref bounds)).Y + num2);
					return;
				}
				finally
				{
					((System.IDisposable)val4)?.Dispose();
				}
			}
			TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, P_1.SubItem.Text, ((Control)Oo).Font, P_1.Bounds, ((Control)Oo).ForeColor, val);
		}

		private void A(object P_0, DrawListViewColumnHeaderEventArgs P_1)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected I4, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			P_1.DrawBackground();
			TextFormatFlags val = (TextFormatFlags)2052;
			HorizontalAlignment textAlign = P_1.Header.TextAlign;
			switch ((int)textAlign)
			{
			case 0:
				val = (TextFormatFlags)(val | 0);
				break;
			case 2:
				val = (TextFormatFlags)(val | 1);
				break;
			case 1:
				val = (TextFormatFlags)(val | 2);
				break;
			}
			TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, P_1.Header.Text, ((Control)Oo).Font, P_1.Bounds, Color.Black, val);
		}

		private static int A(byte[] P_0)
		{
			int num = 0;
			int result = 0;
			bool flag = false;
			do
			{
				byte b = P_0[num];
				num++;
				if (b != 255)
				{
					byte num2 = P_0[num];
					byte b2 = P_0[num + 1];
					byte b3 = P_0[num + 2];
					byte b4 = P_0[num + 3];
					num += 4;
					uint num3 = (uint)(num2 << 24) | ((uint)(b2 << 16) & 0xFF0000u) | ((uint)(b3 << 8) & 0xFF00u) | (b4 & 0xFFu);
					if (num3 != 4294967295u && num3 != 0 && (num3 <= 131072 || b == 2 || (b & 0xF) == 9 || b == 13))
					{
						if ((b & 0xF) == 7 || b == 12)
						{
							if (b == 12)
							{
								num += 2;
							}
							byte num4 = P_0[num];
							byte b5 = P_0[num + 1];
							byte b6 = P_0[num + 2];
							byte b7 = P_0[num + 3];
							result = (num4 << 24) | ((b5 << 16) & 0xFF0000) | ((b6 << 8) & 0xFF00) | (b7 & 0xFF);
							flag = true;
						}
						else
						{
							num += (int)(num3 - 5);
						}
					}
					else
					{
						flag = true;
					}
				}
				if (num >= P_0.Length)
				{
					flag = true;
				}
			}
			while (!flag);
			return result;
		}

		private static int a(byte[] P_0)
		{
			int num = 0;
			int result = 0;
			bool flag = false;
			do
			{
				byte b = P_0[num];
				num++;
				if (b != 255)
				{
					byte num2 = P_0[num];
					byte b2 = P_0[num + 1];
					byte b3 = P_0[num + 2];
					byte b4 = P_0[num + 3];
					num += 4;
					uint num3 = (uint)(num2 << 24) | ((uint)(b2 << 16) & 0xFF0000u) | ((uint)(b3 << 8) & 0xFF00u) | (b4 & 0xFFu);
					if (num3 != 4294967295u && num3 != 0 && (num3 <= 131072 || b == 2 || (b & 0xF) == 9 || b == 13))
					{
						if ((b & 0xF) == 7 || b == 12)
						{
							if (b == 12)
							{
								num += 2;
							}
							byte num4 = P_0[num];
							byte b5 = P_0[num + 1];
							byte b6 = P_0[num + 2];
							byte b7 = P_0[num + 3];
							num += 4;
							result = (num4 << 24) | ((b5 << 16) & 0xFF0000) | ((b6 << 8) & 0xFF00) | (b7 & 0xFF);
							num = ((b != 12) ? (num + (int)(num3 - 9)) : (num + (int)(num3 - 11)));
						}
						else
						{
							num += (int)(num3 - 5);
						}
					}
					else
					{
						flag = true;
					}
				}
				if (num >= P_0.Length)
				{
					flag = true;
				}
			}
			while (!flag);
			return result;
		}

		private static bool A(ref int P_0, int P_1)
		{
			byte[] array = null;
			int num = P_1 - nh;
			if (num < 0)
			{
				num += nH;
			}
			bool flag2;
			do
			{
				flag2 = global::A.A.A(BM.Qz.aXc, global::A.f.Ba, (uint)num, 80u, out var array2, out var _);
				if (flag2)
				{
					array = array2;
				}
				else if (!BM.A(BM.Qz.aXc, true))
				{
					break;
				}
			}
			while (!flag2 && OE);
			if (flag2)
			{
				int num2 = (array[64] << 24) | ((array[65] << 16) & 0xFF0000) | ((array[66] << 8) & 0xFF00) | (array[67] & 0xFF);
				P_0 = P_1;
				for (int i = 0; i < num2 + 1; i++)
				{
					P_0 -= nh;
					if (P_0 < 0)
					{
						P_0 += nH;
					}
					if (P_0 == P_1)
					{
						break;
					}
				}
				return true;
			}
			return false;
		}

		private static bool A(int P_0, int P_1, int P_2)
		{
			byte[] array = null;
			int num = P_1 - nh;
			if (num < 0)
			{
				num += nH;
			}
			bool flag2;
			do
			{
				flag2 = global::A.A.A(BM.Qz.aXc, global::A.f.Ba, (uint)num, 80u, out var array2, out var _);
				if (flag2)
				{
					array = array2;
				}
				else if (!BM.A(BM.Qz.aXc, true))
				{
					break;
				}
			}
			while (!flag2 && OE);
			if (flag2)
			{
				nP = P_0;
				ns = 0;
				np = P_1;
				nQ = P_1;
				nq = P_2;
				nr = (array[60] << 24) | ((array[61] << 16) & 0xFF0000) | ((array[62] << 8) & 0xFF00) | (array[63] & 0xFF);
				nR = (array[64] << 24) | ((array[65] << 16) & 0xFF0000) | ((array[66] << 8) & 0xFF00) | (array[67] & 0xFF);
				return true;
			}
			return false;
		}

		private static bool b(int P_0)
		{
			nq = nQ;
			np = nq;
			for (int i = 0; i < nR + 1; i++)
			{
				np -= nh;
				if (np < 0)
				{
					np += nH;
				}
				if (np == P_0)
				{
					break;
				}
			}
			nS = nQ;
			nQ = np;
			ns = 0;
			byte[] array = null;
			int num = nQ - nh;
			if (num < 0)
			{
				num += nH;
			}
			bool flag2;
			do
			{
				flag2 = global::A.A.A(BM.Qz.aXc, global::A.f.Ba, (uint)num, 80u, out var array2, out var _);
				if (flag2)
				{
					array = array2;
				}
				else if (!BM.A(BM.Qz.aXc, true))
				{
					break;
				}
			}
			while (!flag2 && OE);
			if (flag2)
			{
				nr = (array[60] << 24) | ((array[61] << 16) & 0xFF0000) | ((array[62] << 8) & 0xFF00) | (array[63] & 0xFF);
				nR = (array[64] << 24) | ((array[65] << 16) & 0xFF0000) | ((array[66] << 8) & 0xFF00) | (array[67] & 0xFF);
				return true;
			}
			return false;
		}

		internal static void F()
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			if (nK != -1)
			{
				if (Od != null && ((Control)Od).IsHandleCreated)
				{
					ab od = Od;
					object obj = Be.F.BoP;
					if (obj == null)
					{
						Action val = delegate
						{
							//IL_0018: Unknown result type (might be due to invalid IL or missing references)
							//IL_001e: Expected O, but got Unknown
							foreach (ListViewItem item in ((ListView)Od).Items)
							{
								ListViewItem val2 = item;
								if (val2.SubItems.Count > OJ)
								{
									a a = (a)val2.Tag;
									if (a.BoA != 0 && !a.Boa)
									{
										val2.SubItems[OJ].Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
									}
								}
							}
						};
						Be.F.BoP = val;
						obj = (object)val;
					}
					((Control)od).Invoke((Action)obj);
				}
				nK = -1;
			}
			nk = -1;
			nL = -1;
			nl = -1;
			nn = 0;
			no = false;
		}

		private static bool a(int P_0, int P_1, int P_2)
		{
			byte[] array = null;
			int num = P_1 - nh;
			if (num < 0)
			{
				num += nH;
			}
			bool flag2;
			do
			{
				flag2 = global::A.A.A(BM.Qz.aXc, global::A.f.Ba, (uint)num, 80u, out var array2, out var _);
				if (flag2)
				{
					array = array2;
				}
				else if (!BM.A(BM.Qz.aXc, true))
				{
					break;
				}
			}
			while (!flag2 && OE);
			if (flag2)
			{
				nK = P_0;
				nn = 0;
				no = false;
				nk = P_1;
				nL = P_1;
				nl = P_2;
				nm = (array[60] << 24) | ((array[61] << 16) & 0xFF0000) | ((array[62] << 8) & 0xFF00) | (array[63] & 0xFF);
				nM = (array[64] << 24) | ((array[65] << 16) & 0xFF0000) | ((array[66] << 8) & 0xFF00) | (array[67] & 0xFF);
				return true;
			}
			return false;
		}

		private static bool c(string P_0)
		{
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected O, but got Unknown
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Expected O, but got Unknown
			string aXD = BM.Qz.aXD;
			if (aXD == string.Empty)
			{
				F();
				return false;
			}
			if (!nT && !A(nK))
			{
				return true;
			}
			string text = aXD + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Je();
			if (File.Exists(text))
			{
				try
				{
					StreamReader val = File.OpenText(text);
					try
					{
						string text2;
						while ((text2 = ((TextReader)val).ReadLine()) != null)
						{
							if (int.Parse(text2) == nK)
							{
								return true;
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
				}
			}
			if (nn != 0)
			{
				F();
				return false;
			}
			try
			{
				string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gf() + nK;
				nI = new MemoryStream();
				ni = new ZipArchive((Stream)(object)nI, (ZipArchiveMode)1);
				Stream val2 = ni.CreateEntry(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jr() + nK + bx.a(BM.Qz.awZ, BM.Qz.awz, BM.Qz.aXA) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu()).Open();
				string text4 = BM.Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + BM.Qy + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JS();
				bool flag = File.Exists(text4);
				if (BM.Qz.aXE || !flag)
				{
					if (flag)
					{
						File.Delete(text4);
					}
					new CR(text4, BM.Qz, true).A();
					BM.Qz.aXE = false;
				}
				byte[] array = File.ReadAllBytes(text4);
				foreach (byte b in array)
				{
					val2.WriteByte(b);
				}
				val2.Close();
				nJ = ni.CreateEntry(text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK());
				nj = nJ.Open();
				if (Od != null && ((Control)Od).IsHandleCreated)
				{
					ab od = Od;
					object obj2 = Be.F.Bop;
					if (obj2 == null)
					{
						Action val3 = delegate
						{
							//IL_0018: Unknown result type (might be due to invalid IL or missing references)
							//IL_001e: Expected O, but got Unknown
							foreach (ListViewItem item in ((ListView)Od).Items)
							{
								ListViewItem val4 = item;
								a a = (a)val4.Tag;
								if (a.BOz.Count == 1 && a.BOz[0] == nK)
								{
									if (val4.SubItems.Count > OJ)
									{
										val4.SubItems[OJ].Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDj();
										a.Boa = false;
										val4.Tag = a;
									}
									break;
								}
							}
							if (Od != null)
							{
								((Control)Od).Invalidate();
							}
						};
						Be.F.Bop = val3;
						obj2 = (object)val3;
					}
					((Control)od).Invoke((Action)obj2);
				}
				return true;
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Js() + ex.Message, true);
				if (!BM.Rb)
				{
					f();
				}
				F();
				return false;
			}
		}

		private static void D(string P_0)
		{
			if (!BM.Rb)
			{
				f();
			}
			A a = Be.a(nK);
			string aXD = BM.Qz.aXD;
			if (aXD == string.Empty)
			{
				return;
			}
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gf() + nK;
			string text2 = aXD + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JT() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jt();
			if (!File.Exists(text2))
			{
				return;
			}
			try
			{
				string text3 = ((!E() && !(nO == Oc)) ? N.A(nO, false) : N.A(false));
				text = text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax() + text;
				if (no)
				{
					text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JU();
					string text4 = aXD + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JT() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej();
					if (File.Exists(text4))
					{
						File.Delete(text4);
					}
					File.Move(text2, text4);
					no = false;
				}
				else
				{
					string text5 = aXD + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JT() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej();
					if (File.Exists(text5))
					{
						File.Delete(text5);
					}
					File.Move(text2, text5);
				}
				string text6 = aXD + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Je();
				List<string> val = new List<string>();
				val.Add(nK.ToString());
				File.AppendAllLines(text6, (System.Collections.Generic.IEnumerable<string>)val);
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ju() + ex.Message, true);
			}
			A(aXD + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JT(), text, a, nK);
		}

		internal static void f()
		{
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected O, but got Unknown
			if (nj != null)
			{
				nj.Close();
				nj = null;
			}
			if (ni != null)
			{
				ni.Dispose();
				ni = null;
			}
			if (nI != null)
			{
				string aXD = BM.Qz.aXD;
				string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gf() + nK;
				FileStream val = new FileStream(aXD + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JT() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jt(), (FileMode)2);
				try
				{
					S.A(nI.ToArray(), M.B(), (Stream)(object)val, S.Dj);
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
				((Stream)nI).Close();
				nI = null;
			}
		}

		internal static bool G()
		{
			return nI == null;
		}

		[SpecialName]
		internal static int g()
		{
			return nK;
		}

		[SpecialName]
		internal static int H()
		{
			return nL;
		}

		[SpecialName]
		internal static int h()
		{
			return nl;
		}

		[SpecialName]
		internal static int I()
		{
			return nn;
		}

		private static bool C(int P_0)
		{
			nl = nL;
			nk = nl;
			for (int i = 0; i < nM + 1; i++)
			{
				nk -= nh;
				if (nk < 0)
				{
					nk += nH;
				}
				if (nk == P_0)
				{
					break;
				}
			}
			nN = nL;
			nL = nk;
			nn = 0;
			no = false;
			byte[] array = null;
			int num = nL - nh;
			if (num < 0)
			{
				num += nH;
			}
			bool flag2;
			do
			{
				flag2 = global::A.A.A(BM.Qz.aXc, global::A.f.Ba, (uint)num, 80u, out var array2, out var _);
				if (flag2)
				{
					array = array2;
				}
				else if (!BM.A(BM.Qz.aXc, true))
				{
					break;
				}
			}
			while (!flag2 && OE);
			if (flag2)
			{
				nm = (array[60] << 24) | ((array[61] << 16) & 0xFF0000) | ((array[62] << 8) & 0xFF00) | (array[63] & 0xFF);
				nM = (array[64] << 24) | ((array[65] << 16) & 0xFF0000) | ((array[66] << 8) & 0xFF00) | (array[67] & 0xFF);
			}
			return flag2;
		}

		private static void i()
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected O, but got Unknown
			if (Od == null || !((Control)Od).IsHandleCreated)
			{
				return;
			}
			int num = nl - nL;
			if (num <= 0)
			{
				num += nH;
			}
			int BPb = (int)((long)nn * 100L / num);
			if (BPb == OM)
			{
				return;
			}
			((Control)Od).Invoke((Action)delegate
			{
				//IL_0018: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Expected O, but got Unknown
				foreach (ListViewItem item in ((ListView)Od).Items)
				{
					ListViewItem val = item;
					a a = (a)val.Tag;
					if (a.BOz.Count == 1 && a.BOz[0] == nK)
					{
						if (val.SubItems.Count > OJ)
						{
							val.SubItems[OJ].Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDl() + BPb + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gC();
						}
						break;
					}
				}
				if (Od != null)
				{
					((Control)Od).Invalidate();
				}
			});
			OM = BPb;
		}

		internal static void d(string P_0)
		{
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			if (((uint)BM.qI & 0x100u) != 0 || ((uint)BM.qI & 0x200u) != 0 || BM.Rb || BM.Sj || (nt.Count == 0 && !nT))
			{
				if (!BM.Rb)
				{
					f();
				}
				F();
				return;
			}
			Stopwatch val = new Stopwatch();
			val.Start();
			if (nt.Count > 0)
			{
				global::A.A.n = global::A.b.q;
			}
			else
			{
				global::A.A.n = nU;
			}
			uint num = ((nt.Count > 0) ? 80u : (global::A.A.n switch
			{
				global::A.b.P => 2u, 
				global::A.b.p => 5u, 
				global::A.b.Q => 10u, 
				global::A.b.q => 13u, 
				_ => 10u, 
			}));
			do
			{
				try
				{
					if (BM.Qz.A(9500).ax() != 0)
					{
						if (!BM.Rb)
						{
							f();
						}
						F();
						return;
					}
					string text = BM.Qz.aXD;
					if (string.IsNullOrEmpty(text))
					{
						text = BM.A(P_0, BM.Qz.aXc);
						try
						{
							if (string.IsNullOrEmpty(text))
							{
								List<string> obj = new List<string>();
								obj.Add(BM.Qz.aXc);
								text = BM.a(P_0, obj);
							}
							BM.Qz.aXD = text;
						}
						catch
						{
							F();
							return;
						}
					}
					Directory.CreateDirectory(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jh());
					nH = BM.Qz.A(9497).ax();
					nh = BM.Qz.A(9510).ax();
					int num2 = BM.Qz.A(9501).ax();
					int num3 = BM.Qz.A(9508).ax();
					int num4 = BM.Qz.A(9509).ax();
					if (num2 < 0 || nH == 0 || ((nk == -1 || nK == -1 || nL == -1 || nl == -1) && (!A(ref num4, num3) || !a(num2, num4, num3))) || (nI == null && !c(P_0)))
					{
						return;
					}
					int num5 = ((nk == nL) ? Math.Min(nh, (int)global::A.A.A(BM.Qz.aXc, global::A.f.Ba)) : ((nI != null) ? ((int)global::A.A.A(BM.Qz.aXc, global::A.f.Ba)) : ((nl <= nL) ? (nH - nk) : (nl - nL))));
					if (nk + num5 > nH)
					{
						num5 = nH - nk;
					}
					if ((nl > nL || nk < nl) && nk + num5 > nl)
					{
						num5 = nl - nk;
					}
					byte[] array = null;
					bool flag = false;
					if (nI != null)
					{
						array = null;
						do
						{
							flag = global::A.A.A(BM.Qz.aXc, global::A.f.Ba, (uint)nk, (uint)num5, out var array2, out var _);
							if (flag)
							{
								array = array2;
							}
							else if (!BM.A(BM.Qz.aXc, true))
							{
								break;
							}
						}
						while (!flag && OE);
					}
					if (!flag && nI != null)
					{
						return;
					}
					if (nI == null)
					{
						nn += num5;
					}
					else
					{
						if (nk == nL)
						{
							if (array[3] != 1)
							{
								no = true;
								nj.Write(array, 0, num5);
								nn += num5;
							}
							else
							{
								int num6 = 3 + ((array[4] << 24) | ((array[5] << 16) & 0xFF0000) | ((array[6] << 8) & 0xFF00) | (array[7] & 0xFF));
								int num7 = ((array[56] << 8) & 0xFF00) | (array[57] & 0xFF);
								int num8 = array[58];
								int num9 = array[59];
								int num10 = array[52];
								int num11 = array[53];
								int num12 = array[54];
								if (num7 < 1 || num7 > 9999 || num8 < 1 || num8 > 12 || num9 < 1 || num9 > 31 || num10 < 0 || num10 > 23 || num11 < 0 || num11 > 59 || num12 < 0 || num12 > 59)
								{
									nO = Oc;
								}
								else
								{
									nO = new System.DateTime(num7, num8, num9, num10, num11, num12);
								}
								int num13;
								bool flag3;
								List<List<ushort>> val2 = A(array, num6, out num13, out flag3);
								if (flag3)
								{
									no = true;
								}
								int num14 = num13 - num6;
								if (!no)
								{
									array[68] = (byte)BM.Qz.awZ;
									nj.Write(array, 0, num6);
									nn += num6;
									nj.Write(array, num6, num14);
									nn += num14;
									Cm.A(nj, val2);
									nj.Write(array, num6 + num14, num5 - (num6 + num14));
									nn += num5 - (num6 + num14);
								}
								else
								{
									nj.Write(array, 0, num5);
									nn += num5;
								}
							}
						}
						else
						{
							nj.Write(array, 0, num5);
							nn += num5;
						}
						i();
					}
					nk += num5;
					if (nk == nH)
					{
						nk = 0;
					}
					bool flag4 = nK != num2;
					if (nk == num3 || (flag4 && nk == nN))
					{
						if (nI != null)
						{
							D(P_0);
						}
						nK--;
						if (nK < 0 || nn >= nH || nM == -1 || nm == -1 || nm >= nK + 1)
						{
							nK = -1;
							return;
						}
						if (!C(num3))
						{
							return;
						}
					}
					continue;
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JV() + ex.Message, true);
					F();
				}
			}
			while (val.ElapsedMilliseconds < num);
			val.Stop();
		}

		internal static List<List<ushort>> A(byte[] P_0, int P_1, out int P_2, out bool P_3)
		{
			List<List<ushort>> val = new List<List<ushort>>();
			P_3 = false;
			int num = P_1;
			do
			{
				byte b = P_0[num];
				if (b != 255)
				{
					if ((b & 0xF) != 6 && b != 11)
					{
						if (val.Count == 0)
						{
							P_3 = true;
						}
						break;
					}
					int num2 = 0;
					int num3 = 0;
					if ((b & 0xF) == 6)
					{
						num2 = 5;
						num3 = (b >> 4) & 0xF;
					}
					int num4 = (P_0[num + 1] << 24) | ((P_0[num + 2] << 16) & 0xFF0000) | ((P_0[num + 3] << 8) & 0xFF00) | (P_0[num + 4] & 0xFF);
					if (b == 11)
					{
						num2 = 7;
						num3 = ((P_0[num + 5] << 8) & 0xFF00) | (P_0[num + 6] & 0xFF);
					}
					List<ushort> val2 = new List<ushort>();
					for (int i = num2; i < num4; i++)
					{
						if ((i & 1) == 1)
						{
							val2.Add((ushort)((uint)(P_0[num + i] << 8) & 0xFF00u));
							continue;
						}
						List<ushort> val3 = val2;
						int num5 = val2.Count - 1;
						val3[num5] |= (ushort)(P_0[num + i] & 0xFFu);
					}
					while (val.Count < num3)
					{
						val.Add(new List<ushort>());
					}
					val.Add(val2);
					num += num4;
				}
				else
				{
					num++;
				}
			}
			while (num < P_0.Length);
			P_2 = num;
			return val;
		}

		private void G(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
			BM.QQ.A(BE.nE, false, false, false);
		}

		private void g(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
			BM.QQ.A(BE.ne, false, false, false);
		}

		private void H(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
			BM.QQ.A(BE.nd, false, false, false);
		}

		private void h(object P_0, EventArgs P_1)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			if (!BM.QQ.A((Form)(object)this, BE.nd, null, null))
			{
				return;
			}
			try
			{
				((Control)Oo).Invoke((Action)([CompilerGenerated] () =>
				{
					for (int num = ((ListView)Oo).Items.Count - 1; num >= 0; num--)
					{
						a a = (a)((ListView)Oo).Items[num].Tag;
						bool flag = a.BoA != 0;
						if (a.BOz.Count == 1 && flag && !a.Boa)
						{
							Be.a(a.BOz[0]);
							((ListView)Oo).Items[num].Tag = null;
							((ListView)Oo).Items.RemoveAt(num);
							if (ny.ContainsKey(a.BOz[0]))
							{
								ny.Remove(a.BOz[0]);
							}
							if (Oa.ContainsKey(a.BOz[0]))
							{
								Oa.Remove(a.BOz[0]);
							}
							if (OB.ContainsKey(a.BOz[0]))
							{
								OB.Remove(a.BOz[0]);
							}
							if (Ob.ContainsKey(a.BOz[0]))
							{
								Ob.Remove(a.BOz[0]);
							}
							if (OC.ContainsKey(a.BOz[0]))
							{
								OC.Remove(a.BOz[0]);
							}
						}
					}
					Oo.a();
					((Control)Oo).Invalidate();
				}));
				c();
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jv() + ex.Message, true);
				((Form)this).Close();
			}
		}

		internal static void A(string P_0, string P_1, A P_2, int P_3)
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			string text = P_0 + P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej();
			if (!File.Exists(text))
			{
				return;
			}
			if (Od != null && ((Control)Od).IsHandleCreated)
			{
				((Control)Od).Invoke((Action)delegate
				{
					//IL_001b: Unknown result type (might be due to invalid IL or missing references)
					//IL_0021: Expected O, but got Unknown
					foreach (ListViewItem item in ((ListView)Od).Items)
					{
						ListViewItem val = item;
						a a = (a)val.Tag;
						if (a.BOz.Count == 1 && a.BOz[0] == P_3)
						{
							if (val.SubItems.Count > OJ && val.SubItems.Count > OL)
							{
								val.SubItems[OJ].Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDM();
								val.SubItems[OL].Text = P_1;
								a.Boa = true;
								a.BoE = P_1;
								val.Tag = a;
							}
							nZ[P_1] = a;
							nz[P_1] = a.BOz;
							OA[P_1] = a.BoA;
							break;
						}
					}
					if (Od != null)
					{
						((Control)Od).Invalidate();
					}
				});
			}
			a(P_0, P_1, P_2, P_3);
			if (Oe != null)
			{
				Oe.C(text);
			}
		}

		internal static void a(string P_0, string P_1, A P_2, int P_3)
		{
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			string boj = P_0 + P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej();
			D d = default(D);
			d.Boi = P_0;
			d.BoJ = P_1;
			d.Boj = boj;
			d.BoK = P_2;
			d.Bok = P_3;
			BackgroundWorker val = new BackgroundWorker();
			object obj = Be.e.Bom;
			if (obj == null)
			{
				DoWorkEventHandler val2 = B;
				Be.e.Bom = val2;
				obj = (object)val2;
			}
			val.DoWork += (DoWorkEventHandler)obj;
			object obj2 = Be.e.BoN;
			if (obj2 == null)
			{
				RunWorkerCompletedEventHandler val3 = a;
				Be.e.BoN = val3;
				obj2 = (object)val3;
			}
			val.RunWorkerCompleted += (RunWorkerCompletedEventHandler)obj2;
			val.RunWorkerAsync((object)d);
		}

		internal static void B(object P_0, DoWorkEventArgs P_1)
		{
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0df9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e00: Expected O, but got Unknown
			//IL_0e29: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0529: Unknown result type (might be due to invalid IL or missing references)
			//IL_052e: Unknown result type (might be due to invalid IL or missing references)
			//IL_094e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0955: Expected O, but got Unknown
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			if (val.WorkerReportsProgress)
			{
				val.ReportProgress(0);
			}
			D d = (D)P_1.Argument;
			string boi = d.Boi;
			string boJ = d.BoJ;
			string boj = d.Boj;
			string text = boi + boJ + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iR();
			ZipArchive val2 = null;
			ZipArchiveEntry val3 = null;
			Stream val4 = null;
			MemoryStream val5 = null;
			StreamWriter val6 = null;
			List<uint> obj = new List<uint>();
			obj.Add(0u);
			List<uint> val7 = obj;
			try
			{
				val6 = new StreamWriter((Stream)(object)File.Open(text, (FileMode)2, (FileAccess)2));
				((TextWriter)val6).WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JW());
				((TextWriter)val6).WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jw());
				((TextWriter)val6).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JX(), (object)BM.Qp));
				((TextWriter)val6).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jx(), default(System.ReadOnlySpan<object>)));
				((TextWriter)val6).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JY(), (object)System.DateTime.Now));
				if (val.WorkerReportsProgress)
				{
					val.ReportProgress(5);
				}
				byte b = 0;
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				val5 = S.a(boj, M.B());
				if (((Stream)val5).CanRead)
				{
					val2 = new ZipArchive((Stream)(object)val5, (ZipArchiveMode)0);
					System.Collections.Generic.IEnumerator<ZipArchiveEntry> enumerator = val2.Entries.GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							ZipArchiveEntry current = enumerator.Current;
							if (current.Name.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()))
							{
								val3 = current;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
					if (val3 != null)
					{
						val4 = val3.Open();
					}
					if (val.WorkerReportsProgress)
					{
						val.ReportProgress(10);
					}
					List<List<ushort>> val8 = new List<List<ushort>>();
					byte b2 = 0;
					bool flag = false;
					int num8;
					do
					{
						num8 = val4.ReadByte();
						switch (num8)
						{
						default:
						{
							if ((num8 & 0xF) == 7 || num8 == 12 || (num8 & 0xF) == 9 || num8 == 13 || num8 == 10)
							{
								b2 = (byte)num8;
								break;
							}
							byte[] array = new byte[4];
							if (!N.A(val4, array, 0, 4))
							{
								break;
							}
							uint num9 = (uint)(array[0] << 24) | ((uint)(array[1] << 16) & 0xFF0000u) | ((uint)(array[2] << 8) & 0xFF00u) | (array[3] & 0xFFu);
							if (num9 == 4294967295u || num9 == 0 || (num9 > 131072 && num8 != 2 && (num8 & 0xF) != 9 && num8 != 13))
							{
								break;
							}
							int num10 = 0;
							if ((num8 & 0xF) == 6)
							{
								num10 = (num8 >> 4) & 0xF;
							}
							List<ushort> val9 = null;
							if ((num8 & 0xF) == 6 || num8 == 11)
							{
								val9 = new List<ushort>();
							}
							byte[] array2 = new byte[num9 - 5];
							if (!N.A(val4, array2, 0, (int)(num9 - 5)))
							{
								flag = true;
							}
							else
							{
								for (int i = 5; i < num9; i++)
								{
									byte b3 = array2[i - 5];
									if ((num8 & 0xF) == 1)
									{
										if ((i == 5 && b3 != 72) || (i == 6 && b3 != 65) || (i == 7 && b3 != 76) || (i == 8 && b3 != 84) || (i == 9 && b3 != 69) || (i == 10 && b3 != 67) || (i == 11 && b3 != 72) || (i == 12 && b3 != 48 && b3 != 49))
										{
											throw new System.Exception();
										}
										if (i == 53)
										{
											num = (b3 << 8) & 0xFF00;
										}
										if (i == 54)
										{
											num |= b3 & 0xFF;
										}
										if (i == 55)
										{
											num2 = b3;
										}
										if (i == 56)
										{
											num3 = b3;
										}
										if (i == 49)
										{
											num4 = b3;
										}
										if (i == 50)
										{
											num5 = b3;
										}
										if (i == 51)
										{
											num6 = b3;
										}
										switch (i)
										{
										case 57:
											val7[0] = (uint)(b3 << 24);
											break;
										case 58:
										{
											List<uint> val10 = val7;
											val10[0] = val10[0] | ((uint)(b3 << 16) & 0xFF0000u);
											break;
										}
										case 59:
										{
											List<uint> val10 = val7;
											val10[0] = val10[0] | ((uint)(b3 << 8) & 0xFF00u);
											break;
										}
										case 60:
										{
											List<uint> val10 = val7;
											val10[0] = val10[0] | (b3 & 0xFFu);
											break;
										}
										}
										if (i == 65)
										{
											b = b3;
										}
									}
									else
									{
										if ((num8 & 0xF) != 6 && num8 != 11)
										{
											continue;
										}
										if (num8 == 11)
										{
											switch (i)
											{
											case 5:
												num10 |= (b3 << 8) & 0xFF00;
												break;
											case 6:
												num10 |= b3 & 0xFF;
												break;
											}
										}
										if ((num8 & 0xF) == 6 || (num8 == 11 && i >= 7))
										{
											if ((i & 1) == 1)
											{
												val9.Add((ushort)((uint)(b3 << 8) & 0xFF00u));
												continue;
											}
											List<ushort> val11 = val9;
											int num11 = val9.Count - 1;
											val11[num11] |= (ushort)(b3 & 0xFFu);
										}
									}
								}
							}
							if ((num8 & 0xF) == 6 || num8 == 11)
							{
								while (val8.Count < num10)
								{
									val8.Add(new List<ushort>());
								}
								val8.Add(val9);
							}
							continue;
						}
						case 255:
							continue;
						case -1:
							break;
						}
						break;
					}
					while (!flag);
					if (val.WorkerReportsProgress)
					{
						val.ReportProgress(15);
					}
					if (val8.Count == 0)
					{
						throw new System.Exception();
					}
					for (int j = 0; j < val8.Count; j++)
					{
						Enumerator<ushort> enumerator2 = val8[j].GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								int current2 = enumerator2.Current;
								Setting setting = BM.Qz.A(current2);
								if (setting != null)
								{
									((TextWriter)val6).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jy(), (object)((SettingOrSpecialObject)setting).A(true)));
									((TextWriter)val6).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JZ(), (object)setting.A()));
									((TextWriter)val6).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jz(), (object)((object)(UnitType)setting.aS()).ToString()));
									if (setting.aJ())
									{
										int num12 = setting.aQ();
										int num13 = setting.aq();
										if (num12 != 0 || num13 != 0)
										{
											((TextWriter)val6).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jA(), (object)num13, (object)num12));
										}
									}
								}
								else
								{
									((TextWriter)val6).WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ja());
									((TextWriter)val6).WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jB());
									((TextWriter)val6).WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jb());
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator2).Dispose();
						}
					}
					if (val.WorkerReportsProgress)
					{
						val.ReportProgress(20);
					}
					if (num < 1 || num > 9999 || num2 < 1 || num2 > 12 || num3 < 1 || num3 > 31 || num4 < 0 || num4 > 23 || num5 < 0 || num5 > 59 || num6 < 0 || num6 > 59)
					{
						num = Oc.Year;
						num2 = Oc.Month;
						num3 = Oc.Day;
						num4 = Oc.Hour;
						num5 = Oc.Minute;
						num6 = Oc.Second;
					}
					((TextWriter)val6).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jC(), (object)b));
					((TextWriter)val6).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jc(), (object)val7[0]));
					System.DateTime dateTime = new System.DateTime(num, num2, num3, num4, num5, num6);
					((TextWriter)val6).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jD(), (object)dateTime));
					bool flag2 = true;
					uint num14 = 0u;
					if (val7.Count != 0)
					{
						num14 = val7[0];
					}
					uint num15 = 4294967295u;
					List<List<string>> val12 = new List<List<string>>();
					for (int k = 0; k < val8.Count; k++)
					{
						List<string> val13 = new List<string>();
						for (int l = 0; l < val8[k].Count; l++)
						{
							val13.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ());
						}
						val12.Add(val13);
					}
					if (val.WorkerReportsProgress)
					{
						val.ReportProgress(25);
					}
					int num16 = 25;
					uint num17 = 0u;
					flag = false;
					do
					{
						if (b2 != 0)
						{
							num8 = b2;
							b2 = 0;
						}
						else
						{
							num8 = val4.ReadByte();
						}
						switch (num8)
						{
						case 255:
							continue;
						case -1:
							goto end_IL_07d2;
						}
						byte[] array3 = new byte[4];
						if (!N.A(val4, array3, 0, 4))
						{
							break;
						}
						uint num18 = (uint)(array3[0] << 24) | ((uint)(array3[1] << 16) & 0xFF0000u) | ((uint)(array3[2] << 8) & 0xFF00u) | (array3[3] & 0xFFu);
						if (num18 == 4294967295u || num18 == 0 || (num18 > 131072 && num8 != 2 && (num8 & 0xF) != 9 && num8 != 13))
						{
							break;
						}
						if ((num8 & 0xF) == 7 || num8 == 12)
						{
							num17 += num18;
							int num19;
							if (num8 == 12)
							{
								byte[] array4 = new byte[2];
								if (!N.A(val4, array4, 0, 2))
								{
									break;
								}
								num19 = ((array4[0] << 8) & 0xFF00) | (array4[1] & 0xFF);
							}
							else
							{
								num19 = (num8 >> 4) & 0xF;
							}
							byte[] array5 = new byte[4];
							if (!N.A(val4, array5, 0, 4))
							{
								break;
							}
							uint num20 = (uint)(array5[0] << 24) | ((uint)(array5[1] << 16) & 0xFF0000u) | ((uint)(array5[2] << 8) & 0xFF00u) | (array5[3] & 0xFFu);
							if (num15 != 4294967295u && num20 != num15)
							{
								if (num20 < num15)
								{
									throw new System.Exception();
								}
								StringBuilder val14 = new StringBuilder(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jd(), (object)dateTime.AddMilliseconds((double)(num15 - num7))));
								for (int m = 0; m < val8.Count; m++)
								{
									for (int n = 0; n < val8[m].Count; n++)
									{
										val14.Append(val12[m][n]);
										val12[m][n] = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ();
									}
								}
								string text2 = ((object)val14).ToString();
								if (flag2)
								{
									while (text2.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jE()))
									{
										text2 = text2.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jE(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.je());
									}
									if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ()))
									{
										text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn() + text2;
									}
									if (text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ()))
									{
										text2 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn();
									}
									flag2 = false;
								}
								((TextWriter)val6).WriteLine(text2);
							}
							num15 = num20;
							if (num19 < val8.Count && (((num8 & 0xF) == 7 && num18 == 9 + 4 * val8[num19].Count) || (num8 == 12 && num18 == 11 + 4 * val8[num19].Count)))
							{
								int num21 = 0;
								uint num22 = ((num8 != 12) ? (num18 - 9) : (num18 - 11));
								byte[] array6 = new byte[num22];
								if (!N.A(val4, array6, 0, (int)num22))
								{
									flag = true;
								}
								else
								{
									for (int num23 = 0; num23 < num22; num23++)
									{
										int num24 = num23 % 4;
										byte b4 = array6[num23];
										switch (num24)
										{
										case 0:
											num21 = b4 << 24;
											break;
										case 1:
											num21 |= (b4 << 16) & 0xFF0000;
											break;
										case 2:
											num21 |= (b4 << 8) & 0xFF00;
											break;
										case 3:
											num21 |= b4 & 0xFF;
											val12[num19][num23 / 4] = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ() + num21;
											break;
										}
									}
								}
								if (val.WorkerReportsProgress)
								{
									uint num25 = (uint)Math.Min(90L, 25 + (long)num17 * 65L / val3.Length);
									if (num25 != num16)
									{
										num16 = (int)num25;
										val.ReportProgress((int)num25);
									}
								}
								continue;
							}
							flag = true;
							break;
						}
						uint num26 = 0u;
						int num27 = 0;
						int num28 = 0;
						int num29 = 0;
						int num30 = 0;
						int num31 = 0;
						int num32 = 0;
						byte[] array7 = new byte[num18 - 5];
						if (!N.A(val4, array7, 0, (int)(num18 - 5)))
						{
							flag = true;
							continue;
						}
						for (int num33 = 5; num33 < num18; num33++)
						{
							if (num8 == 1)
							{
								byte b5 = array7[num33 - 5];
								if (num33 == 53)
								{
									num27 = (b5 << 8) & 0xFF00;
								}
								if (num33 == 54)
								{
									num27 |= b5 & 0xFF;
								}
								if (num33 == 55)
								{
									num28 = b5;
								}
								if (num33 == 56)
								{
									num29 = b5;
								}
								if (num33 == 49)
								{
									num30 = b5;
								}
								if (num33 == 50)
								{
									num31 = b5;
								}
								if (num33 == 51)
								{
									num32 = b5;
								}
								switch (num33)
								{
								case 57:
									num26 = (uint)(b5 << 24);
									break;
								case 58:
									num26 |= (uint)(b5 << 16) & 0xFF0000u;
									break;
								case 59:
									num26 |= (uint)(b5 << 8) & 0xFF00u;
									break;
								case 60:
									num26 |= b5 & 0xFFu;
									break;
								}
								if (num33 == 60 && num26 != num14)
								{
									num14 = num26;
									val7.Add(num14);
									System.DateTime dateTime2 = ((num27 >= 1 && num27 <= 9999 && num28 >= 1 && num28 <= 12 && num29 >= 1 && num29 <= 31 && num30 >= 0 && num30 <= 23 && num31 >= 0 && num31 <= 59 && num32 >= 0 && num32 <= 59) ? new System.DateTime(num27, num28, num29, num30, num31, num32) : Oc);
									((TextWriter)val6).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jD(), (object)dateTime2));
									flag2 = true;
								}
							}
						}
						continue;
						end_IL_07d2:
						break;
					}
					while (num8 != -1 && !flag);
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jF() + ex.Message, true);
			}
			finally
			{
				if (val4 != null)
				{
					val4.Close();
				}
				if (val2 != null)
				{
					val2.Dispose();
				}
				if (val5 != null)
				{
					((Stream)val5).Close();
				}
				d d2 = default(d);
				d2.BoL = boJ;
				d2.Bol = d.BoK;
				d2.BoM = d.Bok;
				P_1.Result = d2;
			}
			if (val6 != null)
			{
				((TextWriter)val6).Close();
			}
			if (val7.Count > 1)
			{
				StreamReader val15 = null;
				val6 = null;
				string text3 = boi + boJ + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jf();
				try
				{
					val6 = new StreamWriter((Stream)(object)File.Open(text3, (FileMode)2, (FileAccess)2));
					val15 = File.OpenText(text);
					string text4 = null;
					do
					{
						text4 = ((TextReader)val15).ReadLine();
						if (text4 == null)
						{
							continue;
						}
						if (text4.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iy()))
						{
							Enumerator<uint> enumerator3 = val7.GetEnumerator();
							try
							{
								while (enumerator3.MoveNext())
								{
									int current3 = (int)enumerator3.Current;
									((TextWriter)val6).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jc(), (object)current3));
								}
							}
							finally
							{
								((System.IDisposable)enumerator3).Dispose();
							}
						}
						else
						{
							((TextWriter)val6).WriteLine(text4);
						}
					}
					while (text4 != null);
				}
				catch (System.Exception ex2)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jF() + ex2.Message, true);
				}
				finally
				{
					if (val15 != null)
					{
						((TextReader)val15).Close();
					}
					if (val6 != null)
					{
						((TextWriter)val6).Close();
					}
				}
				try
				{
					File.Delete(text);
					File.Move(text3, text);
				}
				catch (System.Exception ex3)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jF() + ex3.Message, true);
				}
			}
			if (val.WorkerReportsProgress)
			{
				val.ReportProgress(100);
				Thread.Sleep(100);
			}
		}

		private static void a(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			d d = (d)P_1.Result;
			string BPd = d.BoL;
			A BPE = d.Bol;
			int BPD = d.BoM;
			if (BPD == -1 || Od == null || !((Control)Od).IsHandleCreated)
			{
				return;
			}
			try
			{
				((Control)Od).Invoke((Action)delegate
				{
					//IL_001b: Unknown result type (might be due to invalid IL or missing references)
					//IL_0021: Expected O, but got Unknown
					foreach (ListViewItem item in ((ListView)Od).Items)
					{
						ListViewItem val = item;
						a a = (a)val.Tag;
						if (a.BOz.Count == 1 && a.BOz[0] == BPD)
						{
							if (val.SubItems.Count > OJ && val.SubItems.Count > OL)
							{
								val.SubItems[OJ].Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JP();
								val.SubItems[OL].Text = BPd;
								a.Boa = true;
								a.BoE = BPd;
								val.Tag = a;
								if (BPE != null && BPE.BOZ == BPD)
								{
									if (BPE.BOy == BE.nE)
									{
										Oe.A(a);
									}
									else if (BPE.BOy == BE.ne)
									{
										Oe.A(a.BoE);
									}
								}
							}
							break;
						}
					}
					if (Od != null)
					{
						((Control)Od).Invalidate();
					}
				});
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jG() + ex.Message, true);
			}
		}

		internal static void b(object P_0, DoWorkEventArgs P_1)
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_0315: Unknown result type (might be due to invalid IL or missing references)
			//IL_031a: Unknown result type (might be due to invalid IL or missing references)
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			if (val.WorkerReportsProgress)
			{
				val.ReportProgress(0);
			}
			string text = (string)P_1.Argument;
			StreamReader val2 = null;
			string text2 = text.Substring(0, text.Length - 4) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jg();
			StreamWriter val3 = null;
			bool flag = false;
			try
			{
				val3 = new StreamWriter((Stream)(object)File.Open(text2, (FileMode)2, (FileAccess)2));
				val2 = File.OpenText(text);
				List<string> val4 = new List<string>();
				List<int> val5 = new List<int>();
				List<int> val6 = new List<int>();
				string text3 = ((TextReader)val2).ReadLine();
				if (text3 != null && text3 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JW())
				{
					flag = true;
					long length = val2.BaseStream.Length;
					long num = 0L;
					int num2 = 0;
					int num3 = -1;
					bool flag2 = false;
					int[] array = null;
					long num4 = -1L;
					do
					{
						text3 = ((TextReader)val2).ReadLine();
						if (text3 == null)
						{
							continue;
						}
						if (flag2)
						{
							if (text3.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jH()))
							{
								continue;
							}
							string[] array2 = text3.Split(',', (StringSplitOptions)0);
							int num5 = int.Parse(array2[0].Substring(0, 2));
							int num6 = int.Parse(array2[0].Substring(3, 2));
							int num7 = int.Parse(array2[0].Substring(6, 2));
							int num8 = int.Parse(array2[0].Substring(9, 3));
							long num9 = num5 * 3600000 + num6 * 60000 + num7 * 1000 + num8;
							if (num4 == -1)
							{
								num4 = num9;
							}
							num9 -= num4;
							string text4 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jh(), (object)((float)num9 / 1000f));
							for (int i = 1; i < array2.Length; i++)
							{
								int num10 = val6[i - 1];
								if (!string.IsNullOrEmpty(array2[i]))
								{
									string text5 = array2[i];
									int num11;
									try
									{
										num11 = int.Parse(text5);
									}
									catch
									{
										num11 = (int)float.Parse(text5);
									}
									string text6 = bS.a(num11, num10, -1);
									text4 = text4 + text6 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ();
									array[i - 1] = num11;
								}
								else
								{
									string text7 = bS.a(array[i - 1], num10, -1);
									text4 = text4 + text7 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ();
								}
							}
							((TextWriter)val3).WriteLine(text4);
							if (val.WorkerReportsProgress)
							{
								num++;
								if (num2 == 0)
								{
									num2 = val4.Count * 3;
								}
								int num12 = Math.Min(100, (int)(100 * num * num2 / length));
								if (num12 != num3)
								{
									val.ReportProgress(num12);
								}
								num3 = num12;
							}
						}
						else if (text3.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jI()))
						{
							val4.Add(text3.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jI().Length));
						}
						else if (text3.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ji()))
						{
							val5.Add(int.Parse(text3.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ji().Length)));
						}
						else if (text3.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jJ()))
						{
							val6.Add((int)System.Enum.Parse(typeof(UnitType), text3.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jJ().Length)));
						}
						else
						{
							if (!text3.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jH()))
							{
								continue;
							}
							string text8 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jj();
							Enumerator<string> enumerator = val4.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									string current = enumerator.Current;
									text8 = text8 + current + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bQ();
								}
							}
							finally
							{
								((System.IDisposable)enumerator).Dispose();
							}
							((TextWriter)val3).WriteLine(text8);
							array = new int[val4.Count];
							flag2 = true;
						}
					}
					while (text3 != null);
				}
				if (val.WorkerReportsProgress)
				{
					val.ReportProgress(100);
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jK() + ex.Message, true);
			}
			finally
			{
				if (val2 != null)
				{
					((TextReader)val2).Close();
				}
				if (val3 != null)
				{
					((TextWriter)val3).Close();
				}
				try
				{
					if (!flag)
					{
						File.Delete(text2);
					}
				}
				catch
				{
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected O, but got Unknown
			((ListView)Oo).DrawItem -= new DrawListViewItemEventHandler(A);
			((ListView)Oo).DrawSubItem -= new DrawListViewSubItemEventHandler(A);
			((ListView)Oo).DrawColumnHeader -= new DrawListViewColumnHeaderEventHandler(A);
			((ToolStripDropDown)((Control)Oo).ContextMenuStrip).Opening -= new CancelEventHandler(A);
			((ToolStripItem)OF).Click -= new EventHandler(c);
			((ToolStripItem)Of).Click -= new EventHandler(D);
			((ToolStripItem)OG).Click -= new EventHandler(d);
			((ToolStripItem)Og).Click -= new EventHandler(E);
			((ToolStripItem)OH).Click -= new EventHandler(e);
			if (disposing && Om != null)
			{
				((System.IDisposable)Om).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void J()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Expected O, but got Unknown
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Expected O, but got Unknown
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c7: Expected O, but got Unknown
			//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02de: Expected O, but got Unknown
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Expected O, but got Unknown
			//IL_035c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b0: Expected O, but got Unknown
			//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0404: Unknown result type (might be due to invalid IL or missing references)
			//IL_0443: Unknown result type (might be due to invalid IL or missing references)
			//IL_044d: Expected O, but got Unknown
			//IL_045d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bd: Expected O, but got Unknown
			//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0530: Unknown result type (might be due to invalid IL or missing references)
			//IL_053a: Expected O, but got Unknown
			//IL_0547: Unknown result type (might be due to invalid IL or missing references)
			//IL_056e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b8: Expected O, but got Unknown
			//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_062c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0636: Expected O, but got Unknown
			//IL_0643: Unknown result type (might be due to invalid IL or missing references)
			//IL_066a: Unknown result type (might be due to invalid IL or missing references)
			//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b4: Expected O, but got Unknown
			//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0723: Unknown result type (might be due to invalid IL or missing references)
			//IL_073f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0823: Unknown result type (might be due to invalid IL or missing references)
			//IL_082d: Expected O, but got Unknown
			//IL_0875: Unknown result type (might be due to invalid IL or missing references)
			//IL_087f: Expected O, but got Unknown
			//IL_0887: Unknown result type (might be due to invalid IL or missing references)
			//IL_0891: Expected O, but got Unknown
			OO = new Label();
			OP = new Label();
			Op = new ThemedComboBox();
			Oo = new ab();
			On = new ThemedComboBox();
			ON = new aP();
			OQ = new ThemedTextBox();
			Oq = new ThemedButton();
			OR = new ThemedButton();
			Or = new ThemedButton();
			OS = new ThemedButton();
			Os = new Label();
			((Control)this).SuspendLayout();
			((Control)OO).AutoSize = true;
			((Control)OO).Location = new Point(12, 24);
			((Control)OO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)OO).Size = new Size(212, 13);
			((Control)OO).TabIndex = 3;
			((Control)OO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jk();
			((Control)OP).AutoSize = true;
			((Control)OP).Location = new Point(12, 67);
			((Control)OP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
			((Control)OP).Size = new Size(113, 13);
			((Control)OP).TabIndex = 11;
			((Control)OP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jL();
			((ComboBox)Op).DrawMode = (DrawMode)1;
			((ComboBox)Op).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)Op).FormattingEnabled = true;
			((ComboBox)Op).Items.AddRange(new object[3]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jl(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jM(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jm()
			});
			((Control)Op).Location = new Point(158, 64);
			((Control)Op).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jN();
			((Control)Op).Size = new Size(230, 23);
			((Control)Op).TabIndex = 2;
			((ComboBox)Op).SelectedIndexChanged += new EventHandler(C);
			((ListView)Oo).BorderStyle = (BorderStyle)1;
			((Control)Oo).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((ListView)Oo).FullRowSelect = true;
			((ListView)Oo).HeaderStyle = (ColumnHeaderStyle)1;
			((Control)Oo).Location = new Point(12, 92);
			((Control)Oo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jn();
			((ListView)Oo).ShowItemToolTips = true;
			((Control)Oo).Size = new Size(890, 500);
			((Control)Oo).TabIndex = 5;
			((ListView)Oo).UseCompatibleStateImageBehavior = false;
			((ListView)Oo).View = (View)1;
			((Control)Oo).DoubleClick += new EventHandler(F);
			((Control)Oo).MouseClick += new MouseEventHandler(a);
			((Control)Oo).MouseMove += new MouseEventHandler(A);
			((ComboBox)On).DrawMode = (DrawMode)1;
			((ComboBox)On).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)On).FormattingEnabled = true;
			((ComboBox)On).Items.AddRange(new object[4]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jO(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jo(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jP(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jp()
			});
			((Control)On).Location = new Point(228, 21);
			((Control)On).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jQ();
			((Control)On).Size = new Size(230, 23);
			((Control)On).TabIndex = 1;
			((ComboBox)On).SelectedIndexChanged += new EventHandler(b);
			((Control)ON).AutoSize = true;
			((CheckBox)ON).Checked = true;
			((CheckBox)ON).CheckState = (CheckState)1;
			((Control)ON).Location = new Point(12, 3);
			((Control)ON).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jq();
			((Control)ON).Size = new Size(456, 17);
			((Control)ON).TabIndex = 0;
			((Control)ON).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jR();
			((ButtonBase)ON).UseVisualStyleBackColor = true;
			((CheckBox)ON).CheckedChanged += new EventHandler(B);
			((Control)OQ).Location = new Point(542, 250);
			((Control)OQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jr();
			((Control)OQ).Size = new Size(190, 22);
			((Control)OQ).TabIndex = 6;
			((Control)OQ).Visible = false;
			((Control)OQ).KeyDown += new KeyEventHandler(A);
			((Control)Oq).Location = new Point(500, 0);
			((Control)Oq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jS();
			((Control)Oq).Size = new Size(400, 23);
			((Control)Oq).TabIndex = 14;
			((Control)Oq).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.js();
			((ButtonBase)Oq).UseVisualStyleBackColor = true;
			((Control)Oq).Click += new EventHandler(G);
			((Control)OR).Location = new Point(500, 23);
			((Control)OR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jT();
			((Control)OR).Size = new Size(400, 23);
			((Control)OR).TabIndex = 15;
			((Control)OR).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jt();
			((ButtonBase)OR).UseVisualStyleBackColor = true;
			((Control)OR).Click += new EventHandler(g);
			((Control)Or).Location = new Point(500, 46);
			((Control)Or).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jU();
			((Control)Or).Size = new Size(400, 23);
			((Control)Or).TabIndex = 16;
			((Control)Or).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ju();
			((ButtonBase)Or).UseVisualStyleBackColor = true;
			((Control)Or).Click += new EventHandler(H);
			((Control)OS).Location = new Point(500, 69);
			((Control)OS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jV();
			((Control)OS).Size = new Size(400, 23);
			((Control)OS).TabIndex = 17;
			((Control)OS).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jv();
			((ButtonBase)OS).UseVisualStyleBackColor = true;
			((Control)OS).Click += new EventHandler(h);
			((Control)Os).AutoSize = true;
			((Control)Os).Location = new Point(12, 45);
			((Control)Os).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)Os).Size = new Size(316, 13);
			((Control)Os).TabIndex = 20;
			((Control)Os).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jW();
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(914, 601);
			((Control)this).Controls.Add((Control)(object)Os);
			((Control)this).Controls.Add((Control)(object)OS);
			((Control)this).Controls.Add((Control)(object)Or);
			((Control)this).Controls.Add((Control)(object)OR);
			((Control)this).Controls.Add((Control)(object)Oq);
			((Control)this).Controls.Add((Control)(object)Op);
			((Control)this).Controls.Add((Control)(object)OP);
			((Control)this).Controls.Add((Control)(object)OQ);
			((Control)this).Controls.Add((Control)(object)Oo);
			((Control)this).Controls.Add((Control)(object)OO);
			((Control)this).Controls.Add((Control)(object)On);
			((Control)this).Controls.Add((Control)(object)ON);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jw();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ip();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}

		[CompilerGenerated]
		private void j()
		{
			for (int num = ((ListView)Oo).Items.Count - 1; num >= 0; num--)
			{
				a a = (a)((ListView)Oo).Items[num].Tag;
				bool flag = a.BoA != 0;
				if (a.BOz.Count == 1 && flag && !a.Boa)
				{
					Be.a(a.BOz[0]);
					((ListView)Oo).Items[num].Tag = null;
					((ListView)Oo).Items.RemoveAt(num);
					if (ny.ContainsKey(a.BOz[0]))
					{
						ny.Remove(a.BOz[0]);
					}
					if (Oa.ContainsKey(a.BOz[0]))
					{
						Oa.Remove(a.BOz[0]);
					}
					if (OB.ContainsKey(a.BOz[0]))
					{
						OB.Remove(a.BOz[0]);
					}
					if (Ob.ContainsKey(a.BOz[0]))
					{
						Ob.Remove(a.BOz[0]);
					}
					if (OC.ContainsKey(a.BOz[0]))
					{
						OC.Remove(a.BOz[0]);
					}
				}
			}
			Oo.a();
			((Control)Oo).Invalidate();
		}
	}
}
namespace b
{
	internal class bE : Form
	{
		private const int aAG = 28;

		private const int aAg = 70;

		private const int aAH = 10;

		private const int aAh = 34;

		private const int aAI = 50;

		private const int aAi = 40;

		private const int aAJ = 600;

		private ThemedButton aAj = new ThemedButton();

		private ThemedButton aAK = new ThemedButton();

		private ThemedButton aAk = new ThemedButton();

		private MessageBoxDefaultButton aAL;

		private IContainer aAl;

		internal bE(string P_0, string P_1, MessageBoxButtons P_2, MessageBoxIcon P_3, MessageBoxDefaultButton P_4, string[] P_5)
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0272: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0460: Unknown result type (might be due to invalid IL or missing references)
			//IL_047e: Expected I4, but got Unknown
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Expected O, but got Unknown
			//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fbb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fbd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0345: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Invalid comparison between Unknown and I4
			//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_062c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0631: Unknown result type (might be due to invalid IL or missing references)
			//IL_0648: Unknown result type (might be due to invalid IL or missing references)
			//IL_064d: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_080c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0811: Unknown result type (might be due to invalid IL or missing references)
			//IL_0845: Unknown result type (might be due to invalid IL or missing references)
			//IL_084a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0861: Unknown result type (might be due to invalid IL or missing references)
			//IL_0866: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dce: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e40: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e45: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e61: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c2c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c43: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c48: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a66: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a87: Unknown result type (might be due to invalid IL or missing references)
			//IL_034b: Unknown result type (might be due to invalid IL or missing references)
			//IL_034f: Invalid comparison between Unknown and I4
			//IL_053a: Unknown result type (might be due to invalid IL or missing references)
			//IL_053f: Unknown result type (might be due to invalid IL or missing references)
			//IL_051b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0520: Unknown result type (might be due to invalid IL or missing references)
			//IL_0529: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06be: Unknown result type (might be due to invalid IL or missing references)
			//IL_069a: Unknown result type (might be due to invalid IL or missing references)
			//IL_069f: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08df: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eeb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ecc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eda: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_0355: Invalid comparison between Unknown and I4
			//IL_036a: Unknown result type (might be due to invalid IL or missing references)
			//IL_036e: Invalid comparison between Unknown and I4
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0387: Invalid comparison between Unknown and I4
			//IL_0389: Unknown result type (might be due to invalid IL or missing references)
			//IL_038d: Invalid comparison between Unknown and I4
			//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a6: Invalid comparison between Unknown and I4
			//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ac: Invalid comparison between Unknown and I4
			A();
			((Control)this).BackColor = BM.td;
			((Control)this).ForeColor = BM.te;
			if (P_0.Length > 60000)
			{
				P_0 = P_0.Substring(0, 60000) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAU();
			}
			Label val = new Label();
			((Control)val).Text = P_0;
			Size val2 = TextRenderer.MeasureText(P_0, ((Control)val).Font);
			int width = ((Size)(ref val2)).Width;
			if ((int)P_3 != 0)
			{
				float num = (float)width * 1.5f;
				val2 = ((Form)this).ClientSize;
				if (num < (float)(((Size)(ref val2)).Width - 50 - 10))
				{
					int num2 = (int)((float)width * 1.5f) + 50 + 10;
					val2 = ((Form)this).ClientSize;
					((Form)this).ClientSize = new Size(num2, ((Size)(ref val2)).Height);
				}
			}
			else
			{
				float num3 = (float)width * 1.5f;
				val2 = ((Form)this).ClientSize;
				if (num3 < (float)(((Size)(ref val2)).Width - 20))
				{
					int num4 = (int)((float)width * 1.5f) + 20;
					val2 = ((Form)this).ClientSize;
					((Form)this).ClientSize = new Size(num4, ((Size)(ref val2)).Height);
				}
			}
			val.TextAlign = (ContentAlignment)16;
			((Control)val).BackColor = ((Control)this).BackColor;
			((Control)val).ForeColor = BM.te;
			((Control)val).Left = (((int)P_3 != 0) ? 50 : 10);
			((Control)val).Top = 10;
			int num5;
			if ((int)P_3 == 0)
			{
				val2 = ((Form)this).ClientSize;
				num5 = ((Size)(ref val2)).Width - 20;
			}
			else
			{
				val2 = ((Form)this).ClientSize;
				num5 = ((Size)(ref val2)).Width - 50 - 10;
			}
			int num6 = num5;
			((Control)val).MinimumSize = new Size(num6, 40);
			((Control)val).MaximumSize = new Size(num6, 2147483647);
			((Control)val).AutoSize = true;
			val2 = TextRenderer.MeasureText(P_0, ((Control)val).Font, new Size(((Control)val).Width, -1));
			int height = ((Size)(ref val2)).Height;
			if (height > 600)
			{
				aF aF = new aF();
				((Control)aF).BackColor = ((Control)this).BackColor;
				((Control)aF).Width = ((Control)val).Width;
				((Control)aF).Height = 600;
				((Control)aF).Left = ((Control)val).Left;
				((Control)aF).Top = ((Control)val).Top;
				((Control)val).Left = 0;
				((Control)val).Top = 0;
				((Control)val).MinimumSize = new Size(num6 - 20, 40);
				((Control)val).MaximumSize = new Size(num6 - 20, 2147483647);
				((Control)aF).Controls.Add((Control)(object)val);
				((Control)this).Controls.Add((Control)(object)aF);
				val2 = ((Form)this).ClientSize;
				((Form)this).ClientSize = new Size(((Size)(ref val2)).Width, 658);
			}
			else
			{
				((Control)this).Controls.Add((Control)(object)val);
				val2 = ((Form)this).ClientSize;
				((Form)this).ClientSize = new Size(((Size)(ref val2)).Width, 10 + ((Control)val).Height + 10 + 28 + 10);
			}
			((Control)this).Text = P_1;
			if ((int)P_3 != 0)
			{
				PictureBox val3 = new PictureBox();
				((Control)val3).BackColor = ((Control)this).BackColor;
				((Control)val3).Width = 34;
				((Control)val3).Height = 34;
				((Control)val3).Left = 10;
				if (height > 600)
				{
					((Control)val3).Top = 310 - ((Control)val3).Height / 2;
				}
				else
				{
					((Control)val3).Top = 10 + ((Control)val).Height / 2 - ((Control)val3).Height / 2;
				}
				val3.SizeMode = (PictureBoxSizeMode)3;
				if ((int)P_3 == 16 || (int)P_3 == 16 || (int)P_3 == 16)
				{
					val3.Image = (Image)(object)SystemIcons.Error.ToBitmap();
				}
				else if ((int)P_3 == 32)
				{
					val3.Image = (Image)(object)SystemIcons.Question.ToBitmap();
				}
				else if ((int)P_3 == 48 || (int)P_3 == 48)
				{
					val3.Image = (Image)(object)SystemIcons.Warning.ToBitmap();
				}
				else if ((int)P_3 == 64 || (int)P_3 == 64)
				{
					val3.Image = (Image)(object)SystemIcons.Information.ToBitmap();
				}
				((Control)this).Controls.Add((Control)(object)val3);
			}
			((Control)aAj).AutoSize = false;
			((Control)aAj).Height = 28;
			ThemedButton themedButton = aAj;
			val2 = ((Form)this).ClientSize;
			((Control)themedButton).Top = ((Size)(ref val2)).Height - 38;
			((Control)aAK).AutoSize = false;
			((Control)aAK).Height = 28;
			((Control)aAK).Top = ((Control)aAj).Top;
			((Control)aAk).AutoSize = false;
			((Control)aAk).Height = 28;
			((Control)aAk).Top = ((Control)aAj).Top;
			switch ((int)P_2)
			{
			case 0:
			{
				if (P_5 == null || P_5.Length == 0)
				{
					((Control)aAj).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
				}
				else
				{
					((Control)aAj).Text = P_5[0];
				}
				ThemedButton themedButton9 = aAj;
				val2 = TextRenderer.MeasureText(((Control)aAj).Text, ((Control)aAj).Font);
				((Control)themedButton9).Width = Math.Max(70, ((Size)(ref val2)).Width + 20);
				val2 = ((Form)this).ClientSize;
				if (((Size)(ref val2)).Width < 10 + ((Control)aAj).Width + 10)
				{
					int num9 = 10 + ((Control)aAj).Width + 10;
					val2 = ((Form)this).ClientSize;
					((Form)this).ClientSize = new Size(num9, ((Size)(ref val2)).Height);
				}
				ThemedButton themedButton10 = aAj;
				val2 = ((Form)this).ClientSize;
				((Control)themedButton10).Left = ((Size)(ref val2)).Width - (((Control)aAj).Width + 10);
				((Button)aAj).DialogResult = (DialogResult)1;
				((Control)this).Controls.Add((Control)(object)aAj);
				((Form)this).CancelButton = (IButtonControl)(object)aAj;
				break;
			}
			case 1:
			{
				if (P_5 == null || P_5.Length < 2)
				{
					((Control)aAj).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
					((Control)aAK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
				}
				else
				{
					((Control)aAj).Text = P_5[0];
					((Control)aAK).Text = P_5[1];
				}
				ThemedButton themedButton18 = aAj;
				val2 = TextRenderer.MeasureText(((Control)aAj).Text, ((Control)aAj).Font);
				((Control)themedButton18).Width = Math.Max(70, ((Size)(ref val2)).Width + 20);
				ThemedButton themedButton19 = aAK;
				val2 = TextRenderer.MeasureText(((Control)aAK).Text, ((Control)aAK).Font);
				((Control)themedButton19).Width = Math.Max(70, ((Size)(ref val2)).Width + 20);
				val2 = ((Form)this).ClientSize;
				if (((Size)(ref val2)).Width < 10 + ((Control)aAj).Width + 10 + ((Control)aAK).Width + 10)
				{
					int num12 = 10 + ((Control)aAj).Width + 10 + ((Control)aAK).Width + 10;
					val2 = ((Form)this).ClientSize;
					((Form)this).ClientSize = new Size(num12, ((Size)(ref val2)).Height);
				}
				ThemedButton themedButton20 = aAK;
				val2 = ((Form)this).ClientSize;
				((Control)themedButton20).Left = ((Size)(ref val2)).Width - (((Control)aAK).Width + 10);
				((Control)aAj).Left = ((Control)aAK).Left - (((Control)aAj).Width + 10);
				((Button)aAj).DialogResult = (DialogResult)1;
				((Button)aAK).DialogResult = (DialogResult)2;
				((Control)this).Controls.Add((Control)(object)aAj);
				((Control)this).Controls.Add((Control)(object)aAK);
				((Form)this).CancelButton = (IButtonControl)(object)aAK;
				break;
			}
			case 2:
			{
				if (P_5 == null || P_5.Length < 3)
				{
					((Control)aAj).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAu();
					((Control)aAK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAV();
					((Control)aAk).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NY();
				}
				else
				{
					((Control)aAj).Text = P_5[0];
					((Control)aAK).Text = P_5[1];
					((Control)aAk).Text = P_5[2];
				}
				ThemedButton themedButton14 = aAj;
				val2 = TextRenderer.MeasureText(((Control)aAj).Text, ((Control)aAj).Font);
				((Control)themedButton14).Width = Math.Max(70, ((Size)(ref val2)).Width + 20);
				ThemedButton themedButton15 = aAK;
				val2 = TextRenderer.MeasureText(((Control)aAK).Text, ((Control)aAK).Font);
				((Control)themedButton15).Width = Math.Max(70, ((Size)(ref val2)).Width + 20);
				ThemedButton themedButton16 = aAk;
				val2 = TextRenderer.MeasureText(((Control)aAk).Text, ((Control)aAk).Font);
				((Control)themedButton16).Width = Math.Max(70, ((Size)(ref val2)).Width + 20);
				val2 = ((Form)this).ClientSize;
				if (((Size)(ref val2)).Width < 10 + ((Control)aAj).Width + 10 + ((Control)aAK).Width + 10 + ((Control)aAk).Width + 10)
				{
					int num11 = 10 + ((Control)aAj).Width + 10 + ((Control)aAK).Width + 10 + ((Control)aAk).Width + 10;
					val2 = ((Form)this).ClientSize;
					((Form)this).ClientSize = new Size(num11, ((Size)(ref val2)).Height);
				}
				ThemedButton themedButton17 = aAk;
				val2 = ((Form)this).ClientSize;
				((Control)themedButton17).Left = ((Size)(ref val2)).Width - (((Control)aAk).Width + 10);
				((Control)aAK).Left = ((Control)aAk).Left - (((Control)aAK).Width + 10);
				((Control)aAj).Left = ((Control)aAK).Left - (((Control)aAj).Width + 10);
				((Button)aAj).DialogResult = (DialogResult)3;
				((Button)aAK).DialogResult = (DialogResult)4;
				((Button)aAk).DialogResult = (DialogResult)5;
				((Control)this).Controls.Add((Control)(object)aAj);
				((Control)this).Controls.Add((Control)(object)aAK);
				((Control)this).Controls.Add((Control)(object)aAk);
				((Form)this).CancelButton = (IButtonControl)(object)aAj;
				break;
			}
			case 5:
			{
				if (P_5 == null || P_5.Length < 2)
				{
					((Control)aAj).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAV();
					((Control)aAK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
				}
				else
				{
					((Control)aAj).Text = P_5[0];
					((Control)aAK).Text = P_5[1];
				}
				ThemedButton themedButton6 = aAj;
				val2 = TextRenderer.MeasureText(((Control)aAj).Text, ((Control)aAj).Font);
				((Control)themedButton6).Width = Math.Max(70, ((Size)(ref val2)).Width + 20);
				ThemedButton themedButton7 = aAK;
				val2 = TextRenderer.MeasureText(((Control)aAK).Text, ((Control)aAK).Font);
				((Control)themedButton7).Width = Math.Max(70, ((Size)(ref val2)).Width + 20);
				val2 = ((Form)this).ClientSize;
				if (((Size)(ref val2)).Width < 10 + ((Control)aAj).Width + 10 + ((Control)aAK).Width + 10)
				{
					int num8 = 10 + ((Control)aAj).Width + 10 + ((Control)aAK).Width + 10;
					val2 = ((Form)this).ClientSize;
					((Form)this).ClientSize = new Size(num8, ((Size)(ref val2)).Height);
				}
				ThemedButton themedButton8 = aAK;
				val2 = ((Form)this).ClientSize;
				((Control)themedButton8).Left = ((Size)(ref val2)).Width - (((Control)aAK).Width + 10);
				((Control)aAj).Left = ((Control)aAK).Left - (((Control)aAj).Width + 10);
				((Button)aAj).DialogResult = (DialogResult)4;
				((Button)aAK).DialogResult = (DialogResult)2;
				((Control)this).Controls.Add((Control)(object)aAj);
				((Control)this).Controls.Add((Control)(object)aAK);
				((Form)this).CancelButton = (IButtonControl)(object)aAK;
				break;
			}
			case 4:
			{
				if (P_5 == null || P_5.Length < 2)
				{
					((Control)aAj).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wz();
					((Control)aAK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WZ();
				}
				else
				{
					((Control)aAj).Text = P_5[0];
					((Control)aAK).Text = P_5[1];
				}
				ThemedButton themedButton11 = aAj;
				val2 = TextRenderer.MeasureText(((Control)aAj).Text, ((Control)aAj).Font);
				((Control)themedButton11).Width = Math.Max(70, ((Size)(ref val2)).Width + 20);
				ThemedButton themedButton12 = aAK;
				val2 = TextRenderer.MeasureText(((Control)aAK).Text, ((Control)aAK).Font);
				((Control)themedButton12).Width = Math.Max(70, ((Size)(ref val2)).Width + 20);
				val2 = ((Form)this).ClientSize;
				if (((Size)(ref val2)).Width < 10 + ((Control)aAj).Width + 10 + ((Control)aAK).Width + 10)
				{
					int num10 = 10 + ((Control)aAj).Width + 10 + ((Control)aAK).Width + 10;
					val2 = ((Form)this).ClientSize;
					((Form)this).ClientSize = new Size(num10, ((Size)(ref val2)).Height);
				}
				ThemedButton themedButton13 = aAK;
				val2 = ((Form)this).ClientSize;
				((Control)themedButton13).Left = ((Size)(ref val2)).Width - (((Control)aAK).Width + 10);
				((Control)aAj).Left = ((Control)aAK).Left - (((Control)aAj).Width + 10);
				((Button)aAj).DialogResult = (DialogResult)6;
				((Button)aAK).DialogResult = (DialogResult)7;
				((Control)this).Controls.Add((Control)(object)aAj);
				((Control)this).Controls.Add((Control)(object)aAK);
				((Form)this).CancelButton = (IButtonControl)(object)aAK;
				break;
			}
			case 3:
			{
				if (P_5 == null || P_5.Length < 3)
				{
					((Control)aAj).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wz();
					((Control)aAK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WZ();
					((Control)aAk).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
				}
				else
				{
					((Control)aAj).Text = P_5[0];
					((Control)aAK).Text = P_5[1];
					((Control)aAk).Text = P_5[2];
				}
				ThemedButton themedButton2 = aAj;
				val2 = TextRenderer.MeasureText(((Control)aAj).Text, ((Control)aAj).Font);
				((Control)themedButton2).Width = Math.Max(70, ((Size)(ref val2)).Width + 20);
				ThemedButton themedButton3 = aAK;
				val2 = TextRenderer.MeasureText(((Control)aAK).Text, ((Control)aAK).Font);
				((Control)themedButton3).Width = Math.Max(70, ((Size)(ref val2)).Width + 20);
				ThemedButton themedButton4 = aAk;
				val2 = TextRenderer.MeasureText(((Control)aAk).Text, ((Control)aAk).Font);
				((Control)themedButton4).Width = Math.Max(70, ((Size)(ref val2)).Width + 20);
				val2 = ((Form)this).ClientSize;
				if (((Size)(ref val2)).Width < 10 + ((Control)aAj).Width + 10 + ((Control)aAK).Width + 10 + ((Control)aAk).Width + 10)
				{
					int num7 = 10 + ((Control)aAj).Width + 10 + ((Control)aAK).Width + 10 + ((Control)aAk).Width + 10;
					val2 = ((Form)this).ClientSize;
					((Form)this).ClientSize = new Size(num7, ((Size)(ref val2)).Height);
				}
				ThemedButton themedButton5 = aAk;
				val2 = ((Form)this).ClientSize;
				((Control)themedButton5).Left = ((Size)(ref val2)).Width - (((Control)aAk).Width + 10);
				((Control)aAK).Left = ((Control)aAk).Left - (((Control)aAK).Width + 10);
				((Control)aAj).Left = ((Control)aAK).Left - (((Control)aAj).Width + 10);
				((Button)aAj).DialogResult = (DialogResult)6;
				((Button)aAK).DialogResult = (DialogResult)7;
				((Button)aAk).DialogResult = (DialogResult)2;
				((Control)this).Controls.Add((Control)(object)aAj);
				((Control)this).Controls.Add((Control)(object)aAK);
				((Control)this).Controls.Add((Control)(object)aAk);
				((Form)this).CancelButton = (IButtonControl)(object)aAk;
				break;
			}
			}
			aAL = P_4;
		}

		protected override void OnShown(EventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Invalid comparison between Unknown and I4
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Invalid comparison between Unknown and I4
			MessageBoxDefaultButton val = aAL;
			if ((int)val != 0)
			{
				if ((int)val != 256)
				{
					if ((int)val == 512)
					{
						((Control)aAk).Focus();
					}
					else
					{
						((Control)aAj).Focus();
					}
				}
				else
				{
					((Control)aAK).Focus();
				}
			}
			else
			{
				((Control)aAj).Focus();
			}
		}

		internal static DialogResult A(IWin32Window P_0, string P_1)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			bE obj = new bE(P_1, string.Empty, (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0, null);
			DialogResult result = ((Form)obj).ShowDialog(P_0);
			((Component)obj).Dispose();
			return result;
		}

		internal static DialogResult A(IWin32Window P_0, string P_1, string[] P_2)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			bE obj = new bE(P_1, string.Empty, (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0, P_2);
			DialogResult result = ((Form)obj).ShowDialog(P_0);
			((Component)obj).Dispose();
			return result;
		}

		internal static DialogResult A(IWin32Window P_0, string P_1, string P_2)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			bE obj = new bE(P_1, P_2, (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0, null);
			DialogResult result = ((Form)obj).ShowDialog(P_0);
			((Component)obj).Dispose();
			return result;
		}

		internal static DialogResult A(IWin32Window P_0, string P_1, string P_2, string[] P_3)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			bE obj = new bE(P_1, P_2, (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0, P_3);
			DialogResult result = ((Form)obj).ShowDialog(P_0);
			((Component)obj).Dispose();
			return result;
		}

		internal static DialogResult A(IWin32Window P_0, string P_1, string P_2, MessageBoxButtons P_3)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			bE obj = new bE(P_1, P_2, P_3, (MessageBoxIcon)0, (MessageBoxDefaultButton)0, null);
			DialogResult result = ((Form)obj).ShowDialog(P_0);
			((Component)obj).Dispose();
			return result;
		}

		internal static DialogResult A(IWin32Window P_0, string P_1, string P_2, MessageBoxButtons P_3, string[] P_4)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			bE obj = new bE(P_1, P_2, P_3, (MessageBoxIcon)0, (MessageBoxDefaultButton)0, P_4);
			DialogResult result = ((Form)obj).ShowDialog(P_0);
			((Component)obj).Dispose();
			return result;
		}

		internal static DialogResult A(IWin32Window P_0, string P_1, string P_2, MessageBoxButtons P_3, MessageBoxIcon P_4)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			bE obj = new bE(P_1, P_2, P_3, P_4, (MessageBoxDefaultButton)0, null);
			DialogResult result = ((Form)obj).ShowDialog(P_0);
			((Component)obj).Dispose();
			return result;
		}

		internal static DialogResult A(IWin32Window P_0, string P_1, string P_2, MessageBoxButtons P_3, MessageBoxIcon P_4, string[] P_5)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			bE obj = new bE(P_1, P_2, P_3, P_4, (MessageBoxDefaultButton)0, P_5);
			DialogResult result = ((Form)obj).ShowDialog(P_0);
			((Component)obj).Dispose();
			return result;
		}

		internal static DialogResult A(IWin32Window P_0, string P_1, string P_2, MessageBoxButtons P_3, MessageBoxIcon P_4, MessageBoxDefaultButton P_5)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			bE obj = new bE(P_1, P_2, P_3, P_4, P_5, null);
			DialogResult result = ((Form)obj).ShowDialog(P_0);
			((Component)obj).Dispose();
			return result;
		}

		internal static DialogResult A(IWin32Window P_0, string P_1, string P_2, MessageBoxButtons P_3, MessageBoxIcon P_4, MessageBoxDefaultButton P_5, string[] P_6)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			bE obj = new bE(P_1, P_2, P_3, P_4, P_5, P_6);
			DialogResult result = ((Form)obj).ShowDialog(P_0);
			((Component)obj).Dispose();
			return result;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && aAl != null)
			{
				((System.IDisposable)aAl).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void A()
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			((Control)this).SuspendLayout();
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(424, 131);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).ControlBox = false;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAv();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).ResumeLayout(false);
		}
	}
	internal class be : Form
	{
		private bool aAM;

		private Timer aAm = new Timer();

		private IContainer aAN;

		private ThemedComboBox aAn;

		private Label aAO;

		private ThemedButton aAo;

		private aP aAP;

		private NumericUpDown aAp;

		private NumericUpDown aAQ;

		private Label aAq;

		private Label aAR;

		private aP aAr;

		private Label aAS;

		private ThemedComboBox aAs;

		private Label aAT;

		private ThemedButton aAt;

		private NumericUpDown aAU;

		private NumericUpDown aAu;

		private Label aAV;

		private Label aAv;

		private aP aAW;

		private Label aAw;

		private aP aAX;

		internal be()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Expected O, but got Unknown
			aAM = true;
			a();
			((Control)this).BackColor = BM.tE;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label || val is aP)
				{
					val.ForeColor = BM.te;
				}
			}
			if ((int)BM.Tn < ((ComboBox)aAn).Items.Count)
			{
				((ListControl)aAn).SelectedIndex = (int)BM.Tn;
			}
			((CheckBox)aAP).Checked = BM.TO;
			((ListControl)aAs).SelectedIndex = (int)BM.Tp;
			((CheckBox)aAr).Checked = BM.Tt;
			((CheckBox)aAX).Checked = BM.TU;
			aAQ.Value = decimal.op_Implicit(BM.Tu);
			aAp.Value = decimal.op_Implicit(BM.TV);
			aAu.Value = decimal.op_Implicit(BM.Tv);
			aAU.Value = decimal.op_Implicit(BM.TW);
			((CheckBox)aAW).Checked = BM.Tw;
			aAm.Interval = 100;
			aAm.Tick += new EventHandler(B);
			aAM = false;
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			BM.QQ.ak();
		}

		private void A(object P_0, EventArgs P_1)
		{
			if (!aAM)
			{
				BM.Tn = (BM.r)((ListControl)aAn).SelectedIndex;
				BM.To = true;
				aAm.Stop();
				aAm.Start();
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			if (!aAM)
			{
				BM.TO = ((CheckBox)aAP).Checked;
				BM.To = true;
				aAm.Stop();
				aAm.Start();
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			switch (BM.Tn)
			{
			case BM.r.BqG:
			case BM.r.Bqh:
				((Control)this).BackColor = SystemColors.Control;
				foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
				{
					Control val3 = item;
					if (val3 is Label || val3 is aP)
					{
						val3.ForeColor = Color.Black;
					}
					else if (val3 is ThemedComboBox)
					{
						val3.BackColor = Color.White;
						val3.ForeColor = Color.Black;
					}
					val3.Invalidate();
				}
				break;
			case BM.r.Bqg:
				((Control)this).BackColor = Color.Black;
				foreach (Control item2 in (ArrangedElementCollection)((Control)this).Controls)
				{
					Control val2 = item2;
					if (val2 is Label || val2 is aP)
					{
						val2.ForeColor = Color.White;
					}
					else if (val2 is ThemedComboBox)
					{
						val2.BackColor = Color.Black;
						val2.ForeColor = Color.White;
					}
					val2.Invalidate();
				}
				break;
			case BM.r.BqH:
				((Control)this).BackColor = BM.TZ;
				foreach (Control item3 in (ArrangedElementCollection)((Control)this).Controls)
				{
					Control val = item3;
					if (val is Label || val is aP)
					{
						val.ForeColor = Color.White;
					}
					else if (val is ThemedComboBox)
					{
						val.BackColor = BM.ta;
						val.ForeColor = Color.White;
					}
					val.Invalidate();
				}
				break;
			}
			aAm.Stop();
		}

		private void b(object P_0, EventArgs P_1)
		{
			if (!aAM && ((ListControl)aAs).SelectedIndex != -1)
			{
				BM.Tp = (BM.S)((ListControl)aAs).SelectedIndex;
				A();
			}
		}

		private void C(object P_0, EventArgs P_1)
		{
			if (!aAM)
			{
				BM.Tt = ((CheckBox)aAr).Checked;
				A();
			}
		}

		private void c(object P_0, EventArgs P_1)
		{
			if (!aAM)
			{
				BM.TU = ((CheckBox)aAX).Checked;
				A();
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			if (!aAM)
			{
				BM.Tu = (int)aAQ.Value;
				A();
			}
		}

		private void d(object P_0, EventArgs P_1)
		{
			if (!aAM)
			{
				BM.TV = (int)aAp.Value;
				A();
			}
		}

		private void E(object P_0, EventArgs P_1)
		{
			if (!aAM)
			{
				BM.Tv = (int)aAu.Value;
				A();
			}
		}

		private void e(object P_0, EventArgs P_1)
		{
			if (!aAM)
			{
				BM.TW = (int)aAU.Value;
				A();
			}
		}

		private void F(object P_0, EventArgs P_1)
		{
			if (!aAM)
			{
				BM.Tw = ((CheckBox)aAW).Checked;
				A();
			}
		}

		private void A()
		{
			BM.QQ.rl.f();
			BM.QQ.rl.g();
			BM.QQ.rl.G();
		}

		private void f(object P_0, EventArgs P_1)
		{
			if (!aAM)
			{
				((ListControl)aAs).SelectedIndex = 0;
				((CheckBox)aAr).Checked = true;
				((CheckBox)aAX).Checked = true;
				aAQ.Value = 90m;
				aAp.Value = 90m;
				aAu.Value = 0m;
				aAU.Value = 39m;
				((CheckBox)aAW).Checked = false;
			}
		}

		private void G(object P_0, EventArgs P_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			aAm.Tick -= new EventHandler(B);
			((Component)aAm).Dispose();
			((Form)this).Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && aAN != null)
			{
				((System.IDisposable)aAN).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected O, but got Unknown
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected O, but got Unknown
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Unknown result type (might be due to invalid IL or missing references)
			//IL_0264: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ae: Expected O, but got Unknown
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0334: Expected O, but got Unknown
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_035d: Expected O, but got Unknown
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f4: Expected O, but got Unknown
			//IL_0413: Unknown result type (might be due to invalid IL or missing references)
			//IL_041d: Expected O, but got Unknown
			//IL_0448: Unknown result type (might be due to invalid IL or missing references)
			//IL_046c: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b4: Expected O, but got Unknown
			//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0534: Unknown result type (might be due to invalid IL or missing references)
			//IL_055b: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05da: Unknown result type (might be due to invalid IL or missing references)
			//IL_0619: Unknown result type (might be due to invalid IL or missing references)
			//IL_0623: Expected O, but got Unknown
			//IL_063c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0663: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0710: Unknown result type (might be due to invalid IL or missing references)
			//IL_0733: Unknown result type (might be due to invalid IL or missing references)
			//IL_073d: Expected O, but got Unknown
			//IL_075c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0766: Expected O, but got Unknown
			//IL_0770: Unknown result type (might be due to invalid IL or missing references)
			//IL_0797: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_082e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0838: Expected O, but got Unknown
			//IL_0857: Unknown result type (might be due to invalid IL or missing references)
			//IL_0861: Expected O, but got Unknown
			//IL_088c: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f9: Expected O, but got Unknown
			//IL_0918: Unknown result type (might be due to invalid IL or missing references)
			//IL_0922: Expected O, but got Unknown
			//IL_094d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0971: Unknown result type (might be due to invalid IL or missing references)
			//IL_0994: Unknown result type (might be due to invalid IL or missing references)
			//IL_099e: Expected O, but got Unknown
			//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_09de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a45: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af6: Expected O, but got Unknown
			//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b1f: Expected O, but got Unknown
			//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bcf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c18: Expected O, but got Unknown
			//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0db7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dc1: Expected O, but got Unknown
			//IL_0e09: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e13: Expected O, but got Unknown
			aAn = new ThemedComboBox();
			aAO = new Label();
			aAo = new ThemedButton();
			aAP = new aP();
			aAp = new NumericUpDown();
			aAQ = new NumericUpDown();
			aAq = new Label();
			aAR = new Label();
			aAr = new aP();
			aAS = new Label();
			aAs = new ThemedComboBox();
			aAT = new Label();
			aAt = new ThemedButton();
			aAU = new NumericUpDown();
			aAu = new NumericUpDown();
			aAV = new Label();
			aAv = new Label();
			aAW = new aP();
			aAw = new Label();
			aAX = new aP();
			((ISupportInitialize)aAp).BeginInit();
			((ISupportInitialize)aAQ).BeginInit();
			((ISupportInitialize)aAU).BeginInit();
			((ISupportInitialize)aAu).BeginInit();
			((Control)this).SuspendLayout();
			((ComboBox)aAn).DrawMode = (DrawMode)1;
			((ComboBox)aAn).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aAn).FormattingEnabled = true;
			((ComboBox)aAn).Items.AddRange(new object[4]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAW(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAw(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAX(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAx()
			});
			((Control)aAn).Location = new Point(106, 34);
			((Control)aAn).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAY();
			((Control)aAn).Size = new Size(176, 23);
			((Control)aAn).TabIndex = 0;
			((ComboBox)aAn).SelectedIndexChanged += new EventHandler(A);
			((Control)aAO).AutoSize = true;
			((Control)aAO).Location = new Point(12, 38);
			((Control)aAO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)aAO).Size = new Size(78, 13);
			((Control)aAO).TabIndex = 9;
			((Control)aAO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAy();
			((Button)aAo).DialogResult = (DialogResult)2;
			((Control)aAo).Location = new Point(101, 406);
			((Control)aAo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gu();
			((Control)aAo).Size = new Size(105, 34);
			((Control)aAo).TabIndex = 11;
			((Control)aAo).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gV();
			((ButtonBase)aAo).UseVisualStyleBackColor = true;
			((Control)aAo).Click += new EventHandler(G);
			((Control)aAP).AutoSize = true;
			((Control)aAP).Location = new Point(14, 65);
			((Control)aAP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAZ();
			((Control)aAP).Size = new Size(147, 17);
			((Control)aAP).TabIndex = 1;
			((Control)aAP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAz();
			((ButtonBase)aAP).UseVisualStyleBackColor = true;
			((CheckBox)aAP).CheckedChanged += new EventHandler(a);
			((UpDownBase)aAp).BorderStyle = (BorderStyle)1;
			((Control)aAp).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			aAp.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
			((Control)aAp).Location = new Point(192, 284);
			((Control)aAp).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaA();
			((Control)aAp).Size = new Size(90, 23);
			((Control)aAp).TabIndex = 7;
			aAp.Value = new decimal(new int[4] { 90, 0, 0, 0 });
			aAp.ValueChanged += new EventHandler(d);
			((UpDownBase)aAQ).BorderStyle = (BorderStyle)1;
			((Control)aAQ).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			aAQ.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
			((Control)aAQ).Location = new Point(192, 254);
			((Control)aAQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaa();
			((Control)aAQ).Size = new Size(90, 23);
			((Control)aAQ).TabIndex = 6;
			aAQ.Value = new decimal(new int[4] { 90, 0, 0, 0 });
			aAQ.ValueChanged += new EventHandler(D);
			((Control)aAq).AutoSize = true;
			((Control)aAq).Location = new Point(11, 287);
			((Control)aAq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
			((Control)aAq).Size = new Size(147, 13);
			((Control)aAq).TabIndex = 26;
			((Control)aAq).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaB();
			((Control)aAR).AutoSize = true;
			((Control)aAR).Location = new Point(11, 257);
			((Control)aAR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)aAR).Size = new Size(147, 13);
			((Control)aAR).TabIndex = 25;
			((Control)aAR).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aab();
			((Control)aAr).AutoSize = true;
			((CheckBox)aAr).Checked = true;
			((CheckBox)aAr).CheckState = (CheckState)1;
			((Control)aAr).Location = new Point(15, 194);
			((Control)aAr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaC();
			((Control)aAr).Size = new Size(262, 17);
			((Control)aAr).TabIndex = 4;
			((Control)aAr).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aac();
			((ButtonBase)aAr).UseVisualStyleBackColor = true;
			((CheckBox)aAr).CheckedChanged += new EventHandler(C);
			((Control)aAS).AutoSize = true;
			((Control)aAS).Location = new Point(11, 165);
			((Control)aAS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fZ();
			((Control)aAS).Size = new Size(143, 13);
			((Control)aAS).TabIndex = 24;
			((Control)aAS).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaD();
			((ComboBox)aAs).DrawMode = (DrawMode)1;
			((ComboBox)aAs).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)aAs).FormattingEnabled = true;
			((ComboBox)aAs).Items.AddRange(new object[3]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aAx(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jo(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aad()
			});
			((Control)aAs).Location = new Point(172, 161);
			((Control)aAs).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaE();
			((Control)aAs).Size = new Size(110, 23);
			((Control)aAs).TabIndex = 3;
			((ComboBox)aAs).SelectedIndexChanged += new EventHandler(b);
			((Control)aAT).AutoSize = true;
			((Control)aAT).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)aAT).Location = new Point(11, 103);
			((Control)aAT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Io();
			((Control)aAT).Size = new Size(165, 17);
			((Control)aAT).TabIndex = 28;
			((Control)aAT).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aae();
			((Control)aAt).Location = new Point(13, 126);
			((Control)aAt).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaF();
			((Control)aAt).Size = new Size(282, 27);
			((Control)aAt).TabIndex = 2;
			((Control)aAt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaf();
			((ButtonBase)aAt).UseVisualStyleBackColor = true;
			((Control)aAt).Click += new EventHandler(f);
			((UpDownBase)aAU).BorderStyle = (BorderStyle)1;
			((Control)aAU).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			aAU.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
			((Control)aAU).Location = new Point(192, 344);
			((Control)aAU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaG();
			((Control)aAU).Size = new Size(90, 23);
			((Control)aAU).TabIndex = 9;
			aAU.Value = new decimal(new int[4] { 39, 0, 0, 0 });
			aAU.ValueChanged += new EventHandler(e);
			((UpDownBase)aAu).BorderStyle = (BorderStyle)1;
			((Control)aAu).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			aAu.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
			((Control)aAu).Location = new Point(192, 314);
			((Control)aAu).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aag();
			((Control)aAu).Size = new Size(90, 23);
			((Control)aAu).TabIndex = 8;
			aAu.ValueChanged += new EventHandler(E);
			((Control)aAV).AutoSize = true;
			((Control)aAV).Location = new Point(11, 347);
			((Control)aAV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ip();
			((Control)aAV).Size = new Size(158, 13);
			((Control)aAV).TabIndex = 34;
			((Control)aAV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaH();
			((Control)aAv).AutoSize = true;
			((Control)aAv).Location = new Point(11, 317);
			((Control)aAv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iq();
			((Control)aAv).Size = new Size(154, 13);
			((Control)aAv).TabIndex = 33;
			((Control)aAv).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aah();
			((Control)aAW).AutoSize = true;
			((Control)aAW).Location = new Point(15, 376);
			((Control)aAW).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaI();
			((Control)aAW).Size = new Size(139, 17);
			((Control)aAW).TabIndex = 10;
			((Control)aAW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aai();
			((ButtonBase)aAW).UseVisualStyleBackColor = true;
			((CheckBox)aAW).CheckedChanged += new EventHandler(F);
			((Control)aAw).AutoSize = true;
			((Control)aAw).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)aAw).Location = new Point(11, 9);
			((Control)aAw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GB();
			((Control)aAw).Size = new Size(158, 17);
			((Control)aAw).TabIndex = 37;
			((Control)aAw).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaJ();
			((Control)aAX).AutoSize = true;
			((CheckBox)aAX).Checked = true;
			((CheckBox)aAX).CheckState = (CheckState)1;
			((Control)aAX).Location = new Point(15, 224);
			((Control)aAX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaj();
			((Control)aAX).Size = new Size(283, 17);
			((Control)aAX).TabIndex = 5;
			((Control)aAX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaK();
			((ButtonBase)aAX).UseVisualStyleBackColor = true;
			((CheckBox)aAX).CheckedChanged += new EventHandler(c);
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)aAo;
			((Form)this).ClientSize = new Size(308, 449);
			((Control)this).Controls.Add((Control)(object)aAX);
			((Control)this).Controls.Add((Control)(object)aAw);
			((Control)this).Controls.Add((Control)(object)aAW);
			((Control)this).Controls.Add((Control)(object)aAU);
			((Control)this).Controls.Add((Control)(object)aAu);
			((Control)this).Controls.Add((Control)(object)aAV);
			((Control)this).Controls.Add((Control)(object)aAv);
			((Control)this).Controls.Add((Control)(object)aAt);
			((Control)this).Controls.Add((Control)(object)aAT);
			((Control)this).Controls.Add((Control)(object)aAp);
			((Control)this).Controls.Add((Control)(object)aAQ);
			((Control)this).Controls.Add((Control)(object)aAq);
			((Control)this).Controls.Add((Control)(object)aAR);
			((Control)this).Controls.Add((Control)(object)aAr);
			((Control)this).Controls.Add((Control)(object)aAS);
			((Control)this).Controls.Add((Control)(object)aAs);
			((Control)this).Controls.Add((Control)(object)aAP);
			((Control)this).Controls.Add((Control)(object)aAo);
			((Control)this).Controls.Add((Control)(object)aAO);
			((Control)this).Controls.Add((Control)(object)aAn);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aak();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aaL();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((ISupportInitialize)aAp).EndInit();
			((ISupportInitialize)aAQ).EndInit();
			((ISupportInitialize)aAU).EndInit();
			((ISupportInitialize)aAu).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
