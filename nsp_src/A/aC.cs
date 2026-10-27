using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using NSP.Resources;
using NSP.Resources.TreeIcons;
using NSP.SettingsFramework;
using NSP.UserInterface;
using b;
using c;

namespace a;

internal class aC : UserControl
{
	internal struct A
	{
		internal int[] BLO;

		internal uint BLo;
	}

	internal struct a
	{
		internal List<A> BLP;

		internal List<int> BLp;

		internal List<int> BLQ;
	}

	private struct B
	{
		internal uint[,] BLq;

		internal ushort BLR;

		internal uint BLr;
	}

	internal struct b
	{
		internal Point BLS;

		internal Point BLs;

		internal byte BLT;

		internal int BLt;

		internal short BLU;

		internal Color BLu;

		public string ToString()
		{
			return string.Concat(new string[8]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bba(),
				((Point)(ref BLS)).X.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY(),
				((Point)(ref BLS)).Y.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbB(),
				((Point)(ref BLs)).X.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY(),
				((Point)(ref BLs)).Y.ToString()
			});
		}
	}

	internal enum C
	{
		BLV,
		BLv,
		BLW
	}

	internal enum c
	{
		BLw,
		BLX,
		BLx
	}

	internal class D : EventArgs
	{
		[CompilerGenerated]
		private c BLY;

		internal D(c P_0)
		{
			A(P_0);
		}

		[SpecialName]
		[CompilerGenerated]
		internal c A()
		{
			return BLY;
		}

		[SpecialName]
		[CompilerGenerated]
		private void A(c P_0)
		{
			BLY = P_0;
		}
	}

	private delegate void d();

	private delegate void E(object P_0, EventArgs P_1);

	internal enum e
	{
		BLy,
		BLZ,
		BLz
	}

	internal const int GJ = 10;

	private const int Gj = 5;

	private const int GK = 3;

	private const int Gk = 50;

	internal static double GL = 1.0;

	internal static bool Gl = true;

	internal static bool GM = false;

	internal static string Gm = BM.Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + BM.Qy + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FB();

	internal static List<List<ushort>> GN = new List<List<ushort>>();

	internal static List<bool> Gn = new List<bool>();

	internal static bool GO = false;

	private static MemoryStream Go = null;

	private static ZipArchive GP = null;

	private static ZipArchiveEntry Gp = null;

	private static Stream GQ = null;

	private static string Gq = string.Empty;

	internal static Stopwatch GR = new Stopwatch();

	internal static int Gr = 0;

	internal static int GS = -1;

	internal static int Gs = -1;

	internal static int GT = -1;

	internal static int Gt = -1;

	internal static int GU = 0;

	private static int Gu = 0;

	private static int GV = 0;

	internal static bool Gv = false;

	internal static bool GW = false;

	private static bool Gw = false;

	private static bool GX = false;

	private static bool Gx = false;

	private static bool GY = false;

	private static int Gy = 0;

	private static int GZ = 0;

	private static int Gz = 0;

	internal static List<int> gA = new List<int>();

	internal static int ga = -1;

	private static List<List<int>> gB = new List<List<int>>();

	private static List<List<Color>> gb = new List<List<Color>>();

	private static Color[] gC = (Color[])(object)new Color[10];

	private static ushort[] gc;

	internal static List<a> gD;

	private static List<B> gd;

	private static List<List<b>> gE;

	private static BackgroundWorker ge;

	internal static C gF;

	[CompilerGenerated]
	private static EventHandler gf;

	[CompilerGenerated]
	private static EventHandler<D> gG;

	private static object gg;

	private static int gH;

	private static int gh;

	private static int gI;

	private static bool gi;

	private static bool gJ;

	private static int gj;

	private static int gK;

	private const int gk = 1;

	private const int gL = 10;

	private const int gl = 50;

	private IContainer gM;

	private ThemedButton gm;

	private ThemedButton gN;

	private ThemedButton gn;

	private ThemedButton gO;

	private ThemedButton go;

	private Label gP;

	private Label gp;

	private v gQ;

	private ImageList gq;

	private ContextMenuStrip gR;

	private ToolStripMenuItem gr;

	internal Panel gS;

	internal ThemedButton gs;

	internal aC()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		e();
		if (gc.Length > 10)
		{
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eF());
		}
		gC[0] = Color.Red;
		gC[1] = Color.SkyBlue;
		gC[2] = Color.LightGreen;
		gC[3] = Color.Yellow;
		gC[4] = Color.PeachPuff;
		gC[5] = Color.LightCoral;
		gC[6] = Color.PaleTurquoise;
		gC[7] = Color.White;
		gC[8] = Color.Orange;
		gC[9] = Color.Pink;
		ge.DoWork += new DoWorkEventHandler(A);
		ge.RunWorkerAsync();
		((Control)gS).MouseDown += new MouseEventHandler(C);
		((Control)gS).MouseMove += new MouseEventHandler(c);
		((Control)gS).MouseUp += new MouseEventHandler(D);
	}

	internal void A()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		((Control)gS).BackColor = BM.td;
		((Control)gp).ForeColor = BM.te;
		((Control)gP).ForeColor = BM.te;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void A(EventHandler P_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		EventHandler val = gf;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref gf, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void a(EventHandler P_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		EventHandler val = gf;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref gf, val3, val2);
		}
		while (val != val2);
	}

	protected virtual void a()
	{
		if (gf != null)
		{
			gf.Invoke((object)this, (EventArgs)null);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void A(EventHandler<D> P_0)
	{
		EventHandler<D> val = gG;
		EventHandler<D> val2;
		do
		{
			val2 = val;
			EventHandler<D> val3 = (EventHandler<D>)(object)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler<D>>(ref gG, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void a(EventHandler<D> P_0)
	{
		EventHandler<D> val = gG;
		EventHandler<D> val2;
		do
		{
			val2 = val;
			EventHandler<D> val3 = (EventHandler<D>)(object)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler<D>>(ref gG, val3, val2);
		}
		while (val != val2);
	}

	protected virtual void A(c P_0)
	{
		D d = new D(P_0);
		if (gG != null)
		{
			gG.Invoke((object)this, d);
		}
	}

	private bool A(List<string> P_0)
	{
		if (gD.Count != GN.Count)
		{
			P_0.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ef());
			return false;
		}
		for (int i = 0; i < gD.Count; i++)
		{
			a a = gD[i];
			int count = GN[i].Count;
			for (int j = 0; j < a.BLP.Count; j++)
			{
				if (a.BLP[j].BLO.Length != count)
				{
					P_0.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eG());
					return false;
				}
			}
		}
		return true;
	}

	private void A(object P_0, EventArgs P_1)
	{
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		GW = false;
		GU = 0;
		GL = 1.0;
		Gl = true;
		GM = false;
		if (((Control)this).Visible)
		{
			gB.Clear();
			gb.Clear();
			int num = 0;
			for (int i = 0; i < GN.Count; i++)
			{
				num += GN[i].Count;
			}
			if (num <= 10)
			{
				int num2 = 0;
				for (int j = 0; j < GN.Count; j++)
				{
					gB.Add(new List<int>());
					gb.Add(new List<Color>());
					for (int k = 0; k < GN[j].Count; k++)
					{
						ushort num3 = GN[j][k];
						Setting setting = BM.Qz.A((int)num3);
						if (setting != null && ((SettingOrSpecialObject)setting).l() && PortFunction.A(setting))
						{
							gB[j].Add((int)num3);
							gb[j].Add(gC[num2]);
							num2++;
						}
					}
				}
			}
			else
			{
				HashSet<ushort> val = new HashSet<ushort>();
				int num4 = 0;
				for (int l = 0; l < GN.Count; l++)
				{
					gB.Add(new List<int>());
					gb.Add(new List<Color>());
					for (int m = 0; m < GN[l].Count; m++)
					{
						ushort num5 = GN[l][m];
						if (val.Contains(num5))
						{
							continue;
						}
						val.Add(num5);
						ushort[] array = gc;
						foreach (int num6 in array)
						{
							if (num5 == num6)
							{
								Setting setting2 = BM.Qz.A((int)num5);
								if (setting2 != null && ((SettingOrSpecialObject)setting2).l() && PortFunction.A(setting2))
								{
									gB[l].Add((int)num5);
									gb[l].Add(gC[num4]);
									num4++;
								}
								break;
							}
						}
						if (num4 >= 10)
						{
							break;
						}
					}
				}
			}
			double num7 = (double)(Gs - GS) / 1000.0;
			((Control)gp).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eg() + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eH(), (object)num7) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eh();
			((Control)gP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eI() + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eH(), (object)GL) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ei();
			((Control)go).Enabled = true;
			((Control)gn).Enabled = false;
			((Control)gs).Enabled = false;
			((Control)gN).Enabled = true;
			((Control)gm).Enabled = true;
			((ToolStripItem)gr).Enabled = true;
			gA.Clear();
			ga = -1;
			if (GR.IsRunning)
			{
				GR.Reset();
			}
			Rectangle val2 = default(Rectangle);
			((Rectangle)(ref val2))._002Ector(0, 4, ((Control)gQ).Width, ((Control)gQ).Height - 10);
			A(val2, 0, 0, gB, null, null, gb, gE, GS, Gs);
			((Control)this).Invalidate(val2);
		}
		else
		{
			B();
		}
	}

	internal void B()
	{
		try
		{
			if (GQ != null)
			{
				GQ.Close();
				GQ = null;
			}
			if (GP != null)
			{
				GP.Dispose();
				GP = null;
			}
			if (Go != null)
			{
				((Stream)Go).Close();
				Go = null;
			}
		}
		catch
		{
		}
	}

	private void b()
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				d d = b;
				((Control)this).BeginInvoke((System.Delegate)d);
			}
			catch
			{
			}
		}
		else
		{
			int num = Gs - GS;
			double num2 = (double)(Gr - GS) / 1000.0;
			double num3 = (double)num / 1000.0;
			((Control)gp).Text = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eH(), (object)num2) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eJ() + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eH(), (object)num3) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eh();
			((Control)gQ).Invalidate();
		}
		if (gF == aC.C.BLW)
		{
			if (Gr >= Gt)
			{
				A(aC.c.BLX);
			}
			else
			{
				A(aC.c.BLw);
			}
		}
		else
		{
			A(aC.c.BLw);
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		List<int> val = new List<int>();
		for (int i = 0; i < gB.Count; i++)
		{
			Enumerator<int> enumerator = gB[i].GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					val.Add(current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		List<int> val2 = BY.A((IWin32Window)(object)BM.QQ, BM.Qz, val, 10);
		if (val2 == null)
		{
			return;
		}
		gB.Clear();
		gb.Clear();
		HashSet<ushort> val3 = new HashSet<ushort>();
		int num = 0;
		for (int j = 0; j < GN.Count; j++)
		{
			gB.Add(new List<int>());
			gb.Add(new List<Color>());
			for (int k = 0; k < GN[j].Count; k++)
			{
				ushort num2 = GN[j][k];
				if (!val3.Contains(num2))
				{
					val3.Add(num2);
					if (val2.Contains((int)num2))
					{
						gB[j].Add((int)num2);
						gb[j].Add(gC[num]);
						num++;
					}
					if (num >= 10)
					{
						break;
					}
				}
			}
		}
		Rectangle val4 = default(Rectangle);
		((Rectangle)(ref val4))._002Ector(0, 4, ((Control)gQ).Width, ((Control)gQ).Height - 10);
		A(val4, 0, 0, gB, null, null, gb, gE, GS, Gs);
		((Control)this).Invalidate(val4);
		D();
	}

	private void C()
	{
		bool flag = Gr >= Gt;
		bool flag2 = Gr >= Gs;
		if (flag && flag2)
		{
			if (gF == aC.C.BLv)
			{
				GU = GT;
			}
			else if (gF == aC.C.BLW)
			{
				GU = GS;
				int gV = Gz - GZ;
				Gu = GS;
				GV = gV;
			}
		}
		else if (flag)
		{
			if (gF == aC.C.BLv)
			{
				GU = GT;
			}
		}
		else if (GU == 0)
		{
			if (gF == aC.C.BLv)
			{
				GU = GT;
			}
			else if (gF == aC.C.BLW)
			{
				GU = GS;
			}
		}
		Gy = GU;
		GZ = Gu;
		Gz = GV;
		if (!GR.IsRunning)
		{
			GR.Start();
		}
		else if (Gl)
		{
			GR.Restart();
		}
		else if (GM)
		{
			GR.Start();
		}
		Gl = false;
		GM = false;
		((Control)go).Enabled = false;
		((Control)gn).Enabled = true;
		((Control)gs).Enabled = true;
		((Control)gN).Enabled = false;
		((Control)gm).Enabled = false;
		((ToolStripItem)gr).Enabled = false;
	}

	private void B(object P_0, EventArgs P_1)
	{
		gF = aC.C.BLv;
		C();
	}

	private void b(object P_0, EventArgs P_1)
	{
		gF = aC.C.BLW;
		C();
	}

	private void C(object P_0, EventArgs P_1)
	{
		if (GR.IsRunning && !GM)
		{
			GR.Stop();
			GM = true;
		}
		((Control)go).Enabled = true;
		((Control)gn).Enabled = false;
		((Control)gs).Enabled = true;
		((Control)gN).Enabled = false;
		((Control)gm).Enabled = false;
		((ToolStripItem)gr).Enabled = false;
	}

	internal void c(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				E e = c;
				((Control)this).Invoke((System.Delegate)e, new object[2] { P_0, P_1 });
			}
			catch
			{
			}
		}
		else
		{
			if (!Gl)
			{
				gA.Clear();
				ga = -1;
				if (P_0 != null)
				{
					if (gF == aC.C.BLv)
					{
						GU = GT;
						Gr = GT;
					}
					else if (gF == aC.C.BLW)
					{
						GU = GS;
						Gr = GS;
						int num = Gz - GZ;
						Gu = GS;
						GV = num;
						GT = GS;
						Gt = num;
					}
				}
				else if (gF == aC.C.BLv)
				{
					GU = Gy;
				}
				else if (gF == aC.C.BLW)
				{
					GU = 0;
					int gV = Gz - GZ;
					Gu = 0;
					GV = gV;
				}
				GR.Reset();
				Gl = true;
				GM = false;
				c();
			}
			((Control)go).Enabled = true;
			((Control)gn).Enabled = false;
			((Control)gs).Enabled = false;
			((Control)gN).Enabled = true;
			((Control)gm).Enabled = true;
			((ToolStripItem)gr).Enabled = true;
			((Control)BM.QQ).Refresh();
		}
		gF = aC.C.BLV;
	}

	private void c()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (Go == null || GQ == null)
		{
			return;
		}
		if (GQ is FileStream)
		{
			GQ.Position = 0L;
			return;
		}
		B();
		if (string.IsNullOrEmpty(Gq))
		{
			return;
		}
		try
		{
			Go = S.a(Gq, M.B());
			if (((Stream)Go).CanRead && Gq.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
			{
				GP = new ZipArchive((Stream)(object)Go, (ZipArchiveMode)0);
				System.Collections.Generic.IEnumerator<ZipArchiveEntry> enumerator = GP.Entries.GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						ZipArchiveEntry current = enumerator.Current;
						if (current.Name.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()))
						{
							Gp = current;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator)?.Dispose();
				}
				if (Gp != null)
				{
					GQ = Gp.Open();
				}
			}
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ek() + ex.Message, true);
		}
		gA.Clear();
		ga = -1;
	}

	private void D(object P_0, EventArgs P_1)
	{
		if (GL > 0.125)
		{
			GL /= 2.0;
			((Control)gP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eI() + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eH(), (object)GL) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ei();
		}
	}

	private void d(object P_0, EventArgs P_1)
	{
		if (GL < 8.0)
		{
			GL *= 2.0;
			((Control)gP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eI() + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eH(), (object)GL) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ei();
		}
	}

	private int A(ref uint P_0, bool P_1)
	{
		int num = GQ.ReadByte();
		int num2 = 1;
		if (num != -1)
		{
			if (num != 255)
			{
				byte[] array = null;
				byte[] array2 = new byte[4];
				if (!N.A(GQ, array2, 0, 4))
				{
					return 0;
				}
				uint num3 = (uint)(array2[0] << 24) | ((uint)(array2[1] << 16) & 0xFF0000u) | ((uint)(array2[2] << 8) & 0xFF00u) | (array2[3] & 0xFFu);
				num2 += 4;
				if (num3 == 4294967295u || num3 == 0 || (num3 > 131072 && num != 2 && (num & 0xF) != 9 && num != 13))
				{
					return 0;
				}
				int num4 = 0;
				if ((num & 0xF) == 6)
				{
					num4 = (num >> 4) & 0xF;
				}
				List<ushort> val = null;
				if ((num & 0xF) == 6 || num == 11)
				{
					val = new List<ushort>();
				}
				if ((num & 0xF) == 7 || num == 12)
				{
					int num5;
					if (num == 12)
					{
						byte[] array3 = new byte[2];
						if (!N.A(GQ, array3, 0, 2))
						{
							return 0;
						}
						num5 = ((array3[0] << 8) & 0xFF00) | (array3[1] & 0xFF);
						num2 += 2;
					}
					else
					{
						num5 = (num >> 4) & 0xF;
					}
					byte[] array4 = new byte[4];
					if (!N.A(GQ, array4, 0, 4))
					{
						return 0;
					}
					uint num6 = (uint)(array4[0] << 24) | ((uint)(array4[1] << 16) & 0xFF0000u) | ((uint)(array4[2] << 8) & 0xFF00u) | (array4[3] & 0xFFu);
					num2 += 4;
					Gs = (int)num6;
					if (GS == -1)
					{
						GS = (int)num6;
					}
					int num7 = 0;
					while (gD.Count <= num5)
					{
						a a = default(a);
						a.BLP = new List<A>();
						a.BLp = new List<int>();
						a.BLQ = new List<int>();
						gD.Add(a);
					}
					A a2 = default(A);
					a2.BLo = num6;
					a2.BLO = new int[GN[num5].Count];
					uint num8 = ((num != 12) ? (num3 - 9) : (num3 - 11));
					byte[] array5 = new byte[num8];
					if (!N.A(GQ, array5, 0, (int)num8))
					{
						return 0;
					}
					num2 += (int)num8;
					for (int i = 0; i < num8; i++)
					{
						uint num9 = array5[i] & 0xFFu;
						switch (i % 4)
						{
						case 0:
							num7 = (int)(num9 << 24);
							break;
						case 1:
							num7 |= (int)(num9 << 16);
							break;
						case 2:
							num7 |= (int)(num9 << 8);
							break;
						case 3:
						{
							num7 |= (int)num9;
							int num10 = i >> 2;
							a2.BLO[num10] = num7;
							while (gD[num5].BLp.Count <= num10)
							{
								gD[num5].BLp.Add(2147483647);
							}
							gD[num5].BLp[num10] = Math.Min(gD[num5].BLp[num10], num7);
							while (gD[num5].BLQ.Count <= num10)
							{
								gD[num5].BLQ.Add(-2147483648);
							}
							gD[num5].BLQ[num10] = Math.Max(gD[num5].BLQ[num10], num7);
							break;
						}
						}
					}
					if (P_0 != 4294967295u && num6 < P_0)
					{
						throw new System.Exception();
					}
					P_0 = num6;
					gD[num5].BLP.Add(a2);
				}
				else if (num == 10)
				{
					GO = true;
					byte[] array6 = new byte[4];
					if (!N.A(GQ, array6, 0, 4))
					{
						return 0;
					}
					uint bLr = (uint)(array6[0] << 24) | ((uint)(array6[1] << 16) & 0xFF0000u) | ((uint)(array6[2] << 8) & 0xFF00u) | (array6[3] & 0xFFu);
					num2 += 4;
					byte[] array7 = new byte[2];
					if (!N.A(GQ, array7, 0, 2))
					{
						return 0;
					}
					ushort bLR = (ushort)(((uint)(array7[0] << 8) & 0xFF00u) | (array7[1] & 0xFFu));
					num2 += 2;
					B b = default(B);
					b.BLr = bLr;
					b.BLR = bLR;
					b.BLq = new uint[4, 1000];
					int num11 = 16000;
					byte[] array8 = new byte[num11];
					if (!N.A(GQ, array8, 0, num11))
					{
						return 0;
					}
					num2 += num11;
					uint num12 = 0u;
					for (int j = 0; j < num11; j++)
					{
						uint num13 = array8[j] & 0xFFu;
						switch (j % 4)
						{
						case 0:
							num12 = num13 << 24;
							break;
						case 1:
							num12 |= num13 << 16;
							break;
						case 2:
							num12 |= num13 << 8;
							break;
						case 3:
						{
							num12 |= num13;
							int num14 = j / 4000;
							int num15 = j % 4000 / 4;
							b.BLq[num14, num15] = num12;
							break;
						}
						}
					}
					gd.Add(b);
				}
				else
				{
					byte[] array9 = new byte[num3 - 5];
					if (!N.A(GQ, array9, 0, (int)(num3 - 5)))
					{
						return 0;
					}
					num2 += (int)(num3 - 5);
					for (int k = 5; k < num3; k++)
					{
						byte b2 = array9[k - 5];
						if ((num & 0xF) == 1)
						{
							if ((k == 5 && b2 != 72) || (k == 6 && b2 != 65) || (k == 7 && b2 != 76) || (k == 8 && b2 != 84) || (k == 9 && b2 != 69) || (k == 10 && b2 != 67) || (k == 11 && b2 != 72) || (k == 12 && b2 != 48 && b2 != 49))
							{
								throw new System.Exception();
							}
						}
						else if ((num & 0xF) == 2)
						{
							if (!P_1)
							{
								if (k == 5)
								{
									array = new byte[num3 - 5];
								}
								array[k - 5] = b2;
								if (k == num3 - 1)
								{
									File.WriteAllBytes(Gm, array);
								}
							}
						}
						else
						{
							if ((num & 0xF) != 6 && num != 11)
							{
								continue;
							}
							if (num == 11)
							{
								switch (k)
								{
								case 5:
									num4 |= (b2 << 8) & 0xFF00;
									break;
								case 6:
									num4 |= b2 & 0xFF;
									break;
								}
							}
							if ((num & 0xF) == 6 || (num == 11 && k >= 7))
							{
								if ((k & 1) == 1)
								{
									val.Add((ushort)((uint)(b2 << 8) & 0xFF00u));
									continue;
								}
								List<ushort> val2 = val;
								int num16 = val.Count - 1;
								val2[num16] |= (ushort)(b2 & 0xFFu);
							}
						}
					}
				}
				if ((num & 0xF) == 6 || num == 11)
				{
					while (GN.Count < num4)
					{
						GN.Add(new List<ushort>());
					}
					if (GN.Count <= num4)
					{
						GN.Add(val);
					}
				}
			}
			return num2;
		}
		return 0;
	}

	internal bool A(string P_0, BackgroundWorker P_1, out string P_2)
	{
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		P_1.ReportProgress(5);
		if (File.Exists(Gm))
		{
			File.Delete(Gm);
		}
		GN.Clear();
		if (gD != null)
		{
			gD.Clear();
		}
		gD = new List<a>();
		GO = false;
		if (gd != null)
		{
			gd.Clear();
		}
		gd = new List<B>();
		GS = -1;
		Gs = -1;
		bool flag = true;
		List<string> val = new List<string>();
		B();
		for (int i = 0; i < 10; i++)
		{
			try
			{
				if (File.Exists(P_0))
				{
					Gq = P_0;
					Go = S.a(P_0, M.B());
				}
				if (Go != null)
				{
					break;
				}
			}
			catch
			{
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eL());
				Thread.Sleep(1000);
			}
		}
		try
		{
			if (Go != null && ((Stream)Go).CanRead)
			{
				bool flag2 = false;
				long num = 0L;
				if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
				{
					GP = new ZipArchive((Stream)(object)Go, (ZipArchiveMode)0);
					System.Collections.Generic.IEnumerator<ZipArchiveEntry> enumerator = GP.Entries.GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							ZipArchiveEntry current = enumerator.Current;
							if (current.Name.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()))
							{
								Gp = current;
								if (flag2)
								{
									break;
								}
							}
							else
							{
								if (!current.Name.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu()))
								{
									continue;
								}
								Stream val2 = current.Open();
								try
								{
									long length = current.Length;
									byte[] array = new byte[length];
									for (int j = 0; j < length; j++)
									{
										array[j] = (byte)val2.ReadByte();
									}
									File.WriteAllBytes(Gm, array);
									flag2 = true;
								}
								finally
								{
									((System.IDisposable)val2)?.Dispose();
								}
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
					if (Gp != null)
					{
						GQ = Gp.Open();
						num = Gp.Length;
					}
				}
				else
				{
					GQ = (Stream)(object)Go;
					num = ((Stream)Go).Length;
				}
				int num2 = 0;
				long num3 = 0L;
				int num4 = 5;
				uint num5 = 4294967295u;
				do
				{
					num2 = A(ref num5, flag2);
					num3 += num2;
					int num6 = (int)(5 + num3 * 90 / num);
					if (num6 % 2 == 0 && num6 != num4)
					{
						P_1.ReportProgress(num6);
						Thread.Sleep(0);
					}
					num4 = num6;
				}
				while (num2 != 0);
				c();
			}
			else
			{
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.el());
				flag = false;
			}
		}
		catch
		{
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eM());
			flag = false;
		}
		if (flag)
		{
			flag = A(val);
			Gn.Clear();
			if (flag)
			{
				int num7 = -1;
				for (int k = 0; k < GN.Count; k++)
				{
					Enumerator<ushort> enumerator2 = GN[k].GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							num7 = Math.Max((int)enumerator2.Current, num7);
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
				}
				if (num7 != -1)
				{
					for (int l = 0; l <= num7; l++)
					{
						Gn.Add(false);
					}
					for (int m = 0; m < GN.Count; m++)
					{
						Enumerator<ushort> enumerator2 = GN[m].GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								int current2 = enumerator2.Current;
								Gn[current2] = true;
							}
						}
						finally
						{
							((System.IDisposable)enumerator2).Dispose();
						}
					}
				}
				else
				{
					flag = false;
				}
				GT = GS;
				Gt = Gs;
				a();
			}
		}
		P_1.ReportProgress(100);
		P_2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
		if (val.Count > 0)
		{
			P_2 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bN();
		}
		Enumerator<string> enumerator3 = val.GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				string current3 = enumerator3.Current;
				P_2 = P_2 + current3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bN();
			}
			return flag;
		}
		finally
		{
			((System.IDisposable)enumerator3).Dispose();
		}
	}

	private void A(object P_0, DoWorkEventArgs P_1)
	{
		Thread.CurrentThread.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.em();
		while (true)
		{
			if (Go != null && GQ != null && !GM && !Gl && ((uint)BM.qI & 0x1000u) != 0)
			{
				D();
				Thread.Sleep(20);
			}
			else
			{
				Thread.Sleep(500);
			}
		}
	}

	internal void D()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		bool flag = false;
		try
		{
			Monitor.TryEnter(gg, ref flag);
			if (!flag)
			{
				return;
			}
			Stopwatch val = new Stopwatch();
			val.Start();
			int num = Gs - GS;
			int num2 = Gr - GT;
			int num3 = (int)((double)GU + (double)(int)GR.ElapsedMilliseconds * GL);
			int gT = Gu;
			int num4 = GV;
			if (gF == aC.C.BLW && num3 >= Gt && !d())
			{
				num4 = num3;
				gT = num3 - num2;
			}
			for (int i = 0; i < BM.Qz.aWt.Count; i++)
			{
				BM.Qz.aWt[i].az();
			}
			for (int j = 0; j < gD.Count; j++)
			{
				while (gA.Count <= j)
				{
					gA.Add(-1);
				}
				if (gA[j] > num3)
				{
					continue;
				}
				a a = gD[j];
				int count = a.BLP.Count;
				int num5 = 0;
				if (count > 1000 && !GW && !Gv)
				{
					num5 = Math.Max(0, (int)((double)(num3 - GS) / (double)num * (double)count) - count / 100);
				}
				for (int k = num5; k < count; k++)
				{
					if (a.BLP[k].BLo <= num3)
					{
						continue;
					}
					A a2 = a.BLP[k - 1];
					int bLo = (int)a2.BLo;
					for (int l = 0; l < a2.BLO.Length; l++)
					{
						Setting setting = BM.Qz.A((int)GN[j][l]);
						if (setting != null)
						{
							int num6 = a2.BLO[l];
							setting.a(num6, false);
						}
					}
					while (gA.Count <= j)
					{
						gA.Add(-1);
					}
					gA[j] = bLo;
					break;
				}
			}
			for (int m = 0; m < BM.Qz.aWt.Count; m++)
			{
				BM.Qz.aWt[m].i(false);
			}
			if (GO && BM.qz != null && ((Control)BM.qz).Visible && ga <= num3)
			{
				int count2 = gd.Count;
				for (int n = 0; n < count2; n++)
				{
					if (gd[n].BLr > num3 && n >= 1)
					{
						BM.qz.A(gd[n - 1].BLq, gd[n - 1].BLR);
						ga = (int)gd[n - 1].BLr;
						break;
					}
				}
			}
			if (!GW && !Gv)
			{
				if (gF == aC.C.BLv || d())
				{
					if (num3 < Gt)
					{
						Gr = num3;
					}
					else
					{
						Gr = Gt;
						c((object)null, (EventArgs)null);
					}
				}
				else if (gF == aC.C.BLW)
				{
					GT = gT;
					Gt = num4;
					if (num4 < Gs)
					{
						Gr = num3;
					}
					else
					{
						Gr = Gs;
						c((object)null, (EventArgs)null);
					}
				}
			}
			b();
			val.Stop();
			N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eN(), (object)val.ElapsedMilliseconds), false);
		}
		catch
		{
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(gg);
			}
		}
	}

	internal static void A(Rectangle P_0, int P_1, int P_2, List<List<int>> P_3, List<List<int>> P_4, List<List<int>> P_5, List<List<Color>> P_6, List<List<b>> P_7, int P_8, int P_9)
	{
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		P_7.Clear();
		bool flag = P_4 != null && P_5 != null;
		int num = P_9 - P_8;
		if (num == 0)
		{
			num = 1;
		}
		if (P_3.Count == 0 || num == 0)
		{
			return;
		}
		for (int i = 0; i < gD.Count; i++)
		{
			a a = gD[i];
			if (a.BLP.Count == 0)
			{
				continue;
			}
			List<int> bLp = a.BLp;
			List<int> bLQ = a.BLQ;
			int num2 = 0;
			int num3 = a.BLP[0].BLO.Length;
			int[] array = new int[num3];
			int[] array2 = new int[num3];
			for (int j = 0; j < num3; j++)
			{
				array[j] = 2147483647;
			}
			for (int k = 0; k < num3; k++)
			{
				array2[k] = -2147483648;
			}
			int[] array3 = new int[num3];
			int[] array4 = new int[num3];
			int[] array5 = new int[P_3[i].Count];
			for (int l = 0; l < P_3[i].Count; l++)
			{
				int num4 = GN[i].IndexOf((ushort)P_3[i][l]);
				array5[l] = num4;
			}
			for (int m = 0; m < a.BLP.Count; m++)
			{
				A a2 = a.BLP[m];
				int num5 = (int)((a2.BLo - P_8) * ((Rectangle)(ref P_0)).Width / num);
				if (num5 < 0)
				{
					for (int n = 0; n < P_3[i].Count; n++)
					{
						int num6 = a2.BLO[array5[n]];
						array[array5[n]] = num6;
						array2[array5[n]] = num6;
					}
				}
				else
				{
					if (num5 > ((Rectangle)(ref P_0)).Width)
					{
						continue;
					}
					if (num5 != num2)
					{
						HashSet<int> val = new HashSet<int>();
						for (int num7 = 0; num7 < a2.BLO.Length; num7++)
						{
							for (int num8 = 0; num8 < P_3[i].Count; num8++)
							{
								int num9 = P_3[i][num8];
								if (GN[i][num7] != num9 || val.Contains(num9))
								{
									continue;
								}
								val.Add(num9);
								int num10 = bLp[num7];
								int num11 = bLQ[num7];
								if (flag)
								{
									num10 = P_4[i][num8];
									num11 = P_5[i][num8];
									_ = P_6[i][num8];
								}
								if (num5 == num2 + 1)
								{
									int num14;
									int num15;
									if (num11 - num10 != 0)
									{
										int num12 = ((Rectangle)(ref P_0)).Bottom - ((Rectangle)(ref P_0)).Height * (array[num7] - num10) / (num11 - num10);
										int num13 = ((Rectangle)(ref P_0)).Bottom - ((Rectangle)(ref P_0)).Height * (array2[num7] - num10) / (num11 - num10);
										if (num12 > num13)
										{
											num14 = num13;
											num15 = num12;
										}
										else if (num12 < num13)
										{
											num14 = num12;
											num15 = num13;
										}
										else
										{
											num14 = num12;
											num15 = num12 + 1;
										}
									}
									else
									{
										num14 = ((Rectangle)(ref P_0)).Top + ((Rectangle)(ref P_0)).Height / 2;
										num15 = num14 + 1;
									}
									if (num2 != 0)
									{
										if (num15 < array3[num7])
										{
											num15 = array3[num7];
										}
										if (num14 > array4[num7])
										{
											num14 = array4[num7];
										}
									}
									if (num14 != num15)
									{
										if (num14 < ((Rectangle)(ref P_0)).Top - P_1)
										{
											num14 = ((Rectangle)(ref P_0)).Top - P_1;
										}
										if (num14 > ((Rectangle)(ref P_0)).Bottom + P_2)
										{
											num14 = ((Rectangle)(ref P_0)).Bottom + P_2;
										}
										if (num15 < ((Rectangle)(ref P_0)).Top - P_1)
										{
											num15 = ((Rectangle)(ref P_0)).Top - P_1;
										}
										if (num15 > ((Rectangle)(ref P_0)).Bottom + P_2)
										{
											num15 = ((Rectangle)(ref P_0)).Bottom + P_2;
										}
									}
									while (P_7.Count < num8 + 1)
									{
										P_7.Add(new List<b>());
									}
									b b = default(b);
									b.BLS = new Point(num2 + ((Rectangle)(ref P_0)).Left, num15);
									b.BLs = new Point(num2 + ((Rectangle)(ref P_0)).Left, num14);
									b.BLT = (byte)num8;
									b.BLU = (short)i;
									b.BLt = num9;
									b.BLu = P_6[i][num8];
									P_7[num8].Add(b);
									array3[num7] = num14;
									array4[num7] = num15;
								}
								else
								{
									int num16;
									int num18;
									if (num11 - num10 != 0)
									{
										num16 = ((Rectangle)(ref P_0)).Bottom - ((Rectangle)(ref P_0)).Height * (array[num7] - num10) / (num11 - num10);
										int num17 = a2.BLO[num7];
										num18 = ((Rectangle)(ref P_0)).Bottom - ((Rectangle)(ref P_0)).Height * (num17 - num10) / (num11 - num10);
									}
									else
									{
										num16 = (num18 = ((Rectangle)(ref P_0)).Top + ((Rectangle)(ref P_0)).Height / 2);
									}
									while (P_7.Count < num8 + 1)
									{
										P_7.Add(new List<b>());
									}
									b b2 = default(b);
									b2.BLS = new Point(num2 + ((Rectangle)(ref P_0)).Left, num16);
									b2.BLs = new Point(num5 + ((Rectangle)(ref P_0)).Left, num18);
									b2.BLT = (byte)num8;
									b2.BLt = num9;
									b2.BLU = (short)i;
									b2.BLu = P_6[i][num8];
									P_7[num8].Add(b2);
									array3[num7] = Math.Min(num16, num18);
									array4[num7] = Math.Max(num16, num18);
								}
								break;
							}
						}
						num2 = num5;
						for (int num19 = 0; num19 < array.Length; num19++)
						{
							array[num19] = 2147483647;
						}
						for (int num20 = 0; num20 < array2.Length; num20++)
						{
							array2[num20] = -2147483648;
						}
					}
					for (int num21 = 0; num21 < P_3[i].Count; num21++)
					{
						int num22 = a2.BLO[array5[num21]];
						if (num22 < array[array5[num21]])
						{
							array[array5[num21]] = num22;
						}
						if (num22 > array2[array5[num21]])
						{
							array2[array5[num21]] = num22;
						}
					}
				}
			}
		}
	}

	private void A(object P_0, PaintEventArgs P_1)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		int num = Gs - GS;
		if (gB.Count == 0 || num == 0)
		{
			return;
		}
		for (int i = 0; i < gE.Count; i++)
		{
			Enumerator<b> enumerator = gE[i].GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					b current = enumerator.Current;
					if (i == current.BLT)
					{
						Pen val = new Pen(current.BLu, 1f);
						try
						{
							P_1.Graphics.DrawLine(val, ((Point)(ref current.BLS)).X, ((Point)(ref current.BLS)).Y, ((Point)(ref current.BLs)).X, ((Point)(ref current.BLs)).Y);
						}
						catch
						{
						}
						finally
						{
							((System.IDisposable)val)?.Dispose();
						}
						continue;
					}
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.en());
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		A(P_1.Graphics, gQ, num);
		Pen val2 = new Pen(Color.White, 1f);
		try
		{
			val2.DashStyle = (DashStyle)1;
			int num2 = (int)((long)(Gr - GS) * (long)((Control)gQ).Width / num);
			P_1.Graphics.DrawLine(val2, num2, 0, num2, ((Control)gQ).Height);
		}
		finally
		{
			((System.IDisposable)val2)?.Dispose();
		}
		Font val3 = new Font(((Control)this).Font.FontFamily, 8f);
		try
		{
			StringFormat val4 = new StringFormat();
			val4.Alignment = (StringAlignment)1;
			val4.LineAlignment = (StringAlignment)1;
			int num3 = 0;
			RectangleF val7 = default(RectangleF);
			for (int j = 0; j < GN.Count; j++)
			{
				for (int k = 0; k < gB[j].Count; k++)
				{
					Setting setting = BM.Qz.A(gB[j][k]);
					int num4 = ((Control)gQ).Width / 10;
					if (setting != null)
					{
						SolidBrush val5 = new SolidBrush(gb[j][k]);
						try
						{
							string text = ((SettingOrSpecialObject)setting).H();
							string text2 = (string.IsNullOrWhiteSpace(text) ? ((SettingOrSpecialObject)setting).A(bz.aYT) : (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + ((SettingOrSpecialObject)setting).A(bz.aYT) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()));
							SizeF val6 = P_1.Graphics.MeasureString(text2, val3);
							((RectangleF)(ref val7))._002Ector((float)(4 + num3 * num4), 6f, ((SizeF)(ref val6)).Width, ((SizeF)(ref val6)).Height - 4f);
							P_1.Graphics.FillRectangle(Brushes.Black, val7);
							P_1.Graphics.DrawString(text2, val3, (Brush)(object)val5, val7, val4);
							num3++;
						}
						finally
						{
							((System.IDisposable)val5)?.Dispose();
						}
					}
				}
			}
			val4.Dispose();
		}
		finally
		{
			((System.IDisposable)val3)?.Dispose();
		}
	}

	private void A(Graphics P_0, v P_1, int P_2)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (Gt == Gs && GT == GS)
		{
			return;
		}
		SolidBrush val = new SolidBrush(Color.FromArgb(100, Color.Red));
		try
		{
			int num = (int)((long)(GT - GS) * (long)((Control)gQ).Width / P_2);
			int num2 = (int)((long)(Gt - GS) * (long)((Control)gQ).Width / P_2);
			P_0.FillRectangle((Brush)(object)val, new Rectangle(new Point(num, 0), new Size(num2 - num, ((Control)this).Height)));
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	private static bool d()
	{
		if (GT == GS)
		{
			return Gt == Gs;
		}
		return false;
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		((Control)gQ).Focus();
		GW = true;
		gH = P_1.X;
		if (GR.IsRunning)
		{
			c((object)null, (EventArgs)null);
			GR.Reset();
		}
		if (Gw)
		{
			gh = A(Gt);
		}
		else if (GX)
		{
			gI = A(GT);
		}
		if (Gx)
		{
			Gr = GS + (int)((long)P_1.X * (long)(Gs - GS) / ((Control)gQ).Width);
			GU = Gr;
			D();
			if (d())
			{
				GY = true;
			}
			else
			{
				gI = gH - A(GT);
				gh = A(Gt) - gH;
			}
		}
		else
		{
			Gr = GS + (int)((long)P_1.X * (long)(Gs - GS) / ((Control)gQ).Width);
			GU = Gr;
			GT = GS;
			Gt = Gs;
			Gu = GT;
			GV = Gt;
		}
		gA.Clear();
		ga = -1;
	}

	private int A(int P_0)
	{
		int result = 0;
		if (Gs - GS != 0)
		{
			result = (int)((long)(P_0 - GS) * (long)((Control)gQ).Width / (Gs - GS));
		}
		return result;
	}

	private void a(object P_0, MouseEventArgs P_1)
	{
		if (GW)
		{
			if (Math.Abs(gH - P_1.X) < 3)
			{
				return;
			}
			int num = 0;
			int num2 = 0;
			if (Gw)
			{
				num = GS + (int)((long)P_1.X * (long)(Gs - GS) / ((Control)gQ).Width);
				num2 = GS + (int)((long)gh * (long)(Gs - GS) / ((Control)gQ).Width);
				GT = ((num < num2) ? num : num2);
				Gt = ((num2 > num) ? num2 : num);
				if (GT < GS)
				{
					GT = GS;
				}
				if (Gt > Gs)
				{
					Gt = Gs;
				}
				Gu = GT;
				GV = Gt;
				if (Gr < GT || Gr > Gt)
				{
					Gr = GT;
					GU = Gr;
				}
				((Control)gQ).Invalidate();
				return;
			}
			if (GX)
			{
				num2 = GS + (int)((long)P_1.X * (long)(Gs - GS) / ((Control)gQ).Width);
				num = GS + (int)((long)gI * (long)(Gs - GS) / ((Control)gQ).Width);
				GT = ((num < num2) ? num : num2);
				Gt = ((num2 > num) ? num2 : num);
				if (GT < GS)
				{
					GT = GS;
				}
				if (Gt > Gs)
				{
					Gt = Gs;
				}
				Gu = GT;
				GV = Gt;
				if (Gr < GT || Gr > Gt)
				{
					Gr = Gt;
					GU = Gr;
				}
				((Control)gQ).Invalidate();
				return;
			}
			if (Gx)
			{
				if (GY)
				{
					num = GS + (int)((double)A(Gr) / (double)((Control)gQ).Width * (double)(Gs - GS));
					num2 = GS + (int)((long)P_1.X * (long)(Gs - GS) / ((Control)gQ).Width);
					GT = ((num < num2) ? num : num2);
					Gt = ((num2 > num) ? num2 : num);
					if (GT < GS)
					{
						GT = GS;
					}
					if (Gt > Gs)
					{
						Gt = Gs;
					}
					Gu = GT;
					GV = Gt;
				}
				else
				{
					num = GS + (int)((long)(P_1.X - gI) * (long)(Gs - GS) / ((Control)gQ).Width);
					num2 = GS + (int)((long)(P_1.X + gh) * (long)(Gs - GS) / ((Control)gQ).Width);
					int num3 = ((num < num2) ? num : num2);
					int num4 = ((num2 > num) ? num2 : num);
					int num5 = num4 - num3;
					if (num3 < GS)
					{
						num3 = GS;
						num4 = GS + num5;
					}
					else if (num4 > Gs)
					{
						num4 = Gs;
						num3 = Gs - num5;
					}
					GT = num3;
					Gt = num4;
					if (GT < GS)
					{
						GT = GS;
					}
					if (Gt > Gs)
					{
						Gt = Gs;
					}
					Gr = GS + (int)((long)P_1.X * (long)(Gs - GS) / ((Control)gQ).Width);
					Gu = GT;
					GV = Gt;
					GU = Gr;
				}
			}
			else
			{
				num = Gr;
				num2 = GS + (int)((long)P_1.X * (long)(Gs - GS) / ((Control)gQ).Width);
				GT = ((num < num2) ? num : num2);
				Gt = ((num2 > num) ? num2 : num);
				if (GT < GS)
				{
					GT = GS;
				}
				if (Gt > Gs)
				{
					Gt = Gs;
				}
				Gu = GT;
				GV = Gt;
				Gr = GS + (int)((long)gH * (long)(Gs - GS) / ((Control)gQ).Width);
				GU = Gr;
			}
			((Control)gQ).Invalidate();
			return;
		}
		int num6 = Gs - GS;
		if (num6 == 0)
		{
			return;
		}
		int num7 = (int)((long)(GT - GS) * (long)((Control)gQ).Width / num6);
		int num8 = (int)((long)(Gt - GS) * (long)((Control)gQ).Width / num6);
		_ = (long)(Gr - GS) * (long)((Control)gQ).Width / num6;
		Gw = false;
		GX = false;
		Gx = false;
		if (num7 != num8)
		{
			if (P_1.X >= num7 + 5 && P_1.X <= num8 - 5)
			{
				((Control)this).Cursor = Cursors.Default;
				Gx = true;
			}
			if (P_1.X >= num7 - 5 && P_1.X <= num7 + 5 && num7 != 0)
			{
				((Control)this).Cursor = Cursors.VSplit;
				Gw = true;
			}
			else if (P_1.X >= num8 - 5 && P_1.X <= num8 + 5 && num8 != ((Control)gQ).Right)
			{
				((Control)this).Cursor = Cursors.VSplit;
				GX = true;
			}
			else
			{
				((Control)this).Cursor = Cursors.Default;
			}
		}
	}

	private void B(object P_0, MouseEventArgs P_1)
	{
		if (GW)
		{
			GY = false;
			D();
			if (Gr == Gt)
			{
				c();
			}
			A(aC.c.BLX);
			GW = false;
		}
	}

	private void b(object P_0, MouseEventArgs P_1)
	{
		if (P_1.Delta > 0)
		{
			A(true);
		}
		else if (P_1.Delta < 0)
		{
			A(false);
		}
	}

	private void E(object P_0, EventArgs P_1)
	{
		BM.ae();
	}

	private void e(object P_0, EventArgs P_1)
	{
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		if (!((Control)this).Visible)
		{
			return;
		}
		if (((Control)this).Height > ((Control)gS).Height + 20)
		{
			gi = false;
			((Control)gQ).Left = 0;
			((Control)gQ).Top = 0;
			((Control)gQ).Width = ((Control)this).Width;
			((Control)gQ).Height = ((Control)this).Height;
			((Control)gS).BringToFront();
			if (((Control)gS).Top < 0)
			{
				((Control)gS).Top = 0;
			}
			if (((Control)gS).Left < 0)
			{
				((Control)gS).Left = 0;
			}
		}
		else
		{
			gi = true;
			((Control)gS).Left = 0;
			((Control)gS).Top = 0;
			((Control)gQ).Left = ((Control)gS).Right + 1;
			((Control)gQ).Top = 0;
			((Control)gQ).Width = ((Control)this).Width - ((Control)gQ).Left;
			((Control)gQ).Height = ((Control)this).Height;
			((Control)gS).Show();
		}
		A(new Rectangle(0, 4, ((Control)gQ).Width, ((Control)gQ).Height - 10), 0, 0, gB, null, null, gb, gE, GS, Gs);
		((Control)this).Invalidate();
	}

	private void C(object P_0, MouseEventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)P_1.Button == 1048576)
		{
			((Control)gS).BringToFront();
			if (!gi)
			{
				gJ = true;
				gj = P_1.X;
				gK = P_1.Y;
			}
		}
	}

	private void c(object P_0, MouseEventArgs P_1)
	{
		int num = P_1.X - gj;
		int num2 = P_1.Y - gK;
		if (gJ)
		{
			int num3 = ((Control)gS).Left + num;
			int num4 = ((Control)gS).Top + num2;
			if (num3 < 0)
			{
				num3 = 0;
			}
			if (num4 < 0)
			{
				num4 = 0;
			}
			if (num3 + ((Control)gS).Width > ((Control)gQ).Right)
			{
				num3 = ((Control)gQ).Right - ((Control)gS).Width;
			}
			if (num4 + ((Control)gS).Height > ((Control)this).Bottom)
			{
				num4 = ((Control)this).Bottom - ((Control)gS).Height;
			}
			((Control)gS).Left = num3;
			((Control)gS).Top = num4;
		}
	}

	private void D(object P_0, MouseEventArgs P_1)
	{
		gJ = false;
	}

	internal void E()
	{
		if (((ButtonBase)go).Image != null)
		{
			((ButtonBase)go).Image.Dispose();
		}
		((ButtonBase)go).Image = (Image)(object)O.A((Image)(object)GeneralResources.LogPlaybackPlay, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		if (((ButtonBase)gn).Image != null)
		{
			((ButtonBase)gn).Image.Dispose();
		}
		((ButtonBase)gn).Image = (Image)(object)O.A((Image)(object)GeneralResources.LogPlaybackPause, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		if (((ButtonBase)gs).Image != null)
		{
			((ButtonBase)gs).Image.Dispose();
		}
		((ButtonBase)gs).Image = (Image)(object)O.A((Image)(object)GeneralResources.LogPlaybackStop, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		if (((ButtonBase)gN).Image != null)
		{
			((ButtonBase)gN).Image.Dispose();
		}
		((ButtonBase)gN).Image = (Image)(object)O.A((Image)(object)GeneralResources.LogPlaybackDecSpeed, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		if (((ButtonBase)gm).Image != null)
		{
			((ButtonBase)gm).Image.Dispose();
		}
		((ButtonBase)gm).Image = (Image)(object)O.A((Image)(object)GeneralResources.LogPlaybackIncSpeed, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		if (((ButtonBase)gO).Image != null)
		{
			((ButtonBase)gO).Image.Dispose();
		}
		((ButtonBase)gO).Image = (Image)(object)O.A((Image)(object)GeneralResources.LogPlaybackExit, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
	}

	private void A(object P_0, PreviewKeyDownEventArgs P_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Invalid comparison between Unknown and I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Invalid comparison between Unknown and I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Invalid comparison between Unknown and I4
		P_1.IsInputKey = true;
		if (((uint)BM.qI & 0x1000u) != 0)
		{
			if ((int)P_1.KeyCode == 38)
			{
				A(true);
			}
			else if ((int)P_1.KeyCode == 40)
			{
				A(false);
			}
			else if (P_1.Shift && (int)P_1.KeyCode == 37)
			{
				A(aC.e.BLz, true);
			}
			else if (P_1.Shift && (int)P_1.KeyCode == 39)
			{
				A(aC.e.BLz, false);
			}
			else if (P_1.Control && (int)P_1.KeyCode == 37)
			{
				A(aC.e.BLy, true);
			}
			else if (P_1.Control && (int)P_1.KeyCode == 39)
			{
				A(aC.e.BLy, false);
			}
			else if ((int)P_1.KeyCode == 37)
			{
				A(aC.e.BLZ, true);
			}
			else if ((int)P_1.KeyCode == 39)
			{
				A(aC.e.BLZ, false);
			}
		}
	}

	internal void A(e P_0, bool P_1)
	{
		int num = 0;
		num = P_0 switch
		{
			aC.e.BLy => a(1), 
			aC.e.BLZ => a(10), 
			aC.e.BLz => a(50), 
			_ => 0, 
		};
		int num2 = (P_1 ? (Gr - num) : (Gr + num));
		if (num2 < GT)
		{
			int num3 = Gt - GT;
			int num4 = num2;
			int gt = num2 + num3;
			if (num4 >= GS)
			{
				GT = num4;
				Gt = gt;
			}
			else
			{
				GT = GS;
				Gt = GT + num3;
			}
			Gr = GT;
		}
		else if (num2 > Gt)
		{
			int num5 = Gt - GT;
			int gT = num2 - num5;
			int num6 = num2;
			if (num6 <= Gs)
			{
				GT = gT;
				Gt = num6;
			}
			else
			{
				Gt = Gs;
				GT = Gt - num5;
			}
			Gr = Gt;
		}
		else
		{
			Gr = num2;
		}
		GU = Gr;
		((Control)gQ).Invalidate();
		D();
		A(aC.c.BLX);
		gA.Clear();
		ga = -1;
	}

	private int a(int P_0)
	{
		int num = Gt - GT;
		if (num == 0)
		{
			return 0;
		}
		int num2 = (int)((double)P_0 / (double)((Control)gQ).Width * (double)num);
		if (num2 != 0)
		{
			return num2;
		}
		return 1;
	}

	internal void A(bool P_0)
	{
		int num = Gt - GT;
		int gT = GT;
		int gt = Gt;
		if (P_0)
		{
			int num2 = num >> 2;
			gT = Gr - num2;
			gt = Gr + num2;
			if (gt - gT <= 50)
			{
				return;
			}
		}
		else
		{
			int num3 = num >> 1;
			gT = GT - num3;
			gt = Gt + num3;
		}
		if (gT < GS)
		{
			GT = GS;
		}
		else
		{
			GT = gT;
		}
		if (gt > Gs)
		{
			Gt = Gs;
		}
		else
		{
			Gt = gt;
		}
		((Control)gQ).Invalidate();
		D();
		A(aC.c.BLX);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && gM != null)
		{
			((System.IDisposable)gM).Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void e()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected O, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected O, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected O, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected O, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected O, but got Unknown
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected O, but got Unknown
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected O, but got Unknown
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected O, but got Unknown
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected O, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Expected O, but got Unknown
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected O, but got Unknown
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Expected O, but got Unknown
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d1: Expected O, but got Unknown
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Expected O, but got Unknown
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected O, but got Unknown
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected O, but got Unknown
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Expected O, but got Unknown
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected O, but got Unknown
		gM = (IContainer)new Container();
		ComponentResourceManager val = new ComponentResourceManager(typeof(aC));
		gp = new Label();
		gP = new Label();
		gq = new ImageList(gM);
		gR = new ContextMenuStrip(gM);
		gr = new ToolStripMenuItem();
		gS = new Panel();
		gm = new ThemedButton();
		gN = new ThemedButton();
		gn = new ThemedButton();
		gO = new ThemedButton();
		gs = new ThemedButton();
		go = new ThemedButton();
		gQ = new v();
		((Control)gR).SuspendLayout();
		((Control)gS).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)gp).AutoSize = true;
		((Control)gp).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)gp).Location = new Point(0, 0);
		((Control)gp).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eo();
		((Control)gp).Size = new Size(105, 13);
		((Control)gp).TabIndex = 7;
		((Control)gp).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eP();
		((Control)gP).AutoSize = true;
		((Control)gP).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)gP).Location = new Point(116, -1);
		((Control)gP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ep();
		((Control)gP).Size = new Size(124, 13);
		((Control)gP).TabIndex = 6;
		((Control)gP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eQ();
		gq.ImageStream = (ImageListStreamer)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eq());
		gq.TransparentColor = Color.Transparent;
		gq.Images.SetKeyName(0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eR());
		gq.Images.SetKeyName(1, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.er());
		gq.Images.SetKeyName(2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eS());
		gq.Images.SetKeyName(3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.es());
		gq.Images.SetKeyName(4, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eT());
		gq.Images.SetKeyName(5, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.et());
		gq.Images.SetKeyName(6, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eU());
		((ToolStrip)gR).ImageScalingSize = new Size(20, 20);
		((ToolStrip)gR).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)gr });
		((Control)gR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eu();
		((Control)gR).Size = new Size(158, 26);
		((ToolStripItem)gr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eV();
		((ToolStripItem)gr).Size = new Size(157, 22);
		((ToolStripItem)gr).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ev();
		((ToolStripItem)gr).Click += new EventHandler(a);
		((Control)gS).Anchor = (AnchorStyles)6;
		gS.BorderStyle = (BorderStyle)1;
		((Control)gS).Controls.Add((Control)(object)gp);
		((Control)gS).Controls.Add((Control)(object)gP);
		((Control)gS).Controls.Add((Control)(object)gm);
		((Control)gS).Controls.Add((Control)(object)gN);
		((Control)gS).Controls.Add((Control)(object)gn);
		((Control)gS).Controls.Add((Control)(object)gO);
		((Control)gS).Controls.Add((Control)(object)gs);
		((Control)gS).Controls.Add((Control)(object)go);
		((Control)gS).Location = new Point(139, 141);
		((Control)gS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eW();
		((Control)gS).Size = new Size(248, 50);
		((Control)gS).TabIndex = 0;
		((Control)gm).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ButtonBase)gm).ImageIndex = 5;
		((ButtonBase)gm).ImageList = gq;
		((Control)gm).Location = new Point(160, 15);
		((Control)gm).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ew();
		((Control)gm).Size = new Size(30, 30);
		((Control)gm).TabIndex = 5;
		((ButtonBase)gm).UseVisualStyleBackColor = true;
		((Control)gm).Click += new EventHandler(d);
		((Control)gN).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ButtonBase)gN).ImageIndex = 4;
		((ButtonBase)gN).ImageList = gq;
		((Control)gN).Location = new Point(124, 15);
		((Control)gN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eX();
		((Control)gN).Size = new Size(30, 30);
		((Control)gN).TabIndex = 4;
		((ButtonBase)gN).UseVisualStyleBackColor = true;
		((Control)gN).Click += new EventHandler(D);
		((Control)gn).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ButtonBase)gn).ImageIndex = 2;
		((ButtonBase)gn).ImageList = gq;
		((Control)gn).Location = new Point(39, 15);
		((Control)gn).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ex();
		((Control)gn).Size = new Size(30, 30);
		((Control)gn).TabIndex = 2;
		((ButtonBase)gn).UseVisualStyleBackColor = true;
		((Control)gn).Click += new EventHandler(C);
		((Control)gO).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ButtonBase)gO).ImageIndex = 6;
		((ButtonBase)gO).ImageList = gq;
		((Control)gO).Location = new Point(210, 15);
		((Control)gO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eY();
		((Control)gO).Size = new Size(30, 30);
		((Control)gO).TabIndex = 6;
		((ButtonBase)gO).UseVisualStyleBackColor = true;
		((Control)gO).Click += new EventHandler(E);
		((Control)gs).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ButtonBase)gs).ImageIndex = 3;
		((ButtonBase)gs).ImageList = gq;
		((Control)gs).Location = new Point(75, 15);
		((Control)gs).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ey();
		((Control)gs).Size = new Size(30, 30);
		((Control)gs).TabIndex = 3;
		((ButtonBase)gs).UseVisualStyleBackColor = true;
		((Control)gs).Click += new EventHandler(c);
		((Control)go).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ButtonBase)go).ImageIndex = 0;
		((ButtonBase)go).ImageList = gq;
		((Control)go).Location = new Point(3, 15);
		((Control)go).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eZ();
		((Control)go).Size = new Size(30, 30);
		((Control)go).TabIndex = 0;
		((ButtonBase)go).UseVisualStyleBackColor = true;
		((Control)go).Click += new EventHandler(B);
		((Control)gQ).BackColor = Color.Black;
		((Panel)gQ).BorderStyle = (BorderStyle)1;
		((Control)gQ).ContextMenuStrip = gR;
		((Control)gQ).Location = new Point(250, 5);
		((Control)gQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ez();
		((Control)gQ).Size = new Size(1043, 52);
		((Control)gQ).TabIndex = 1;
		((Control)gQ).Paint += new PaintEventHandler(A);
		((Control)gQ).MouseDown += new MouseEventHandler(A);
		((Control)gQ).MouseMove += new MouseEventHandler(a);
		((Control)gQ).MouseUp += new MouseEventHandler(B);
		((Control)gQ).MouseWheel += new MouseEventHandler(b);
		((Control)gQ).PreviewKeyDown += new PreviewKeyDownEventHandler(A);
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)gQ);
		((Control)this).Controls.Add((Control)(object)gS);
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FA();
		((Control)this).Size = new Size(1296, 304);
		((Control)this).VisibleChanged += new EventHandler(A);
		((Control)this).Resize += new EventHandler(e);
		((Control)gR).ResumeLayout(false);
		((Control)gS).ResumeLayout(false);
		((Control)gS).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	static aC()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		ushort[] array = new ushort[9];
		RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		gc = array;
		gE = new List<List<b>>();
		ge = new BackgroundWorker();
		gF = aC.C.BLV;
		gg = new object();
		gH = 0;
		gh = 0;
		gI = 0;
	}
}
internal class ac : UserControl
{
	private enum A
	{
		BlA,
		Bla,
		BlB
	}

	private delegate void a(bool P_0, bool P_1, bool P_2, bool P_3);

	private delegate void B(bool P_0);

	private delegate void b(bool P_0);

	private static readonly string gT = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ft();

	private ThemedButton gt = new ThemedButton();

	private PictureBox gU = new PictureBox();

	private ThemedTextBox gu = new ThemedTextBox();

	private ThemedButton gV = new ThemedButton();

	private Timer gv = new Timer();

	private TreeViewWithThemedScrollBars gW = new TreeViewWithThemedScrollBars();

	private Panel gw = new Panel();

	private ThemedButton gX = new ThemedButton();

	private ThemedButton gx = new ThemedButton();

	private ThemedButton gY = new ThemedButton();

	private ThemedButton gy = new ThemedButton();

	private Stack<TreeNode> gZ = new Stack<TreeNode>();

	private Stack<TreeNode> gz = new Stack<TreeNode>();

	private ContextMenuStrip HA = new ContextMenuStrip();

	private ContextMenuStrip Ha = new ContextMenuStrip();

	private ag HB = new ag();

	private const int Hb = 0;

	private const int HC = 1;

	private const int Hc = 120;

	private const int HD = 5;

	private const int Hd = 160;

	private bool HE;

	private bool He;

	private int HF;

	private int Hf;

	private int HG;

	private int Hg;

	private bool HH;

	private bool Hh = true;

	private List<int> HI = new List<int>();

	private SettingOrSpecialObject Hi;

	private TreeNode HJ;

	private TreeNode Hj;

	internal bt HK;

	private MenuNode Hk;

	internal bool HL;

	private bool Hl;

	private bool HM;

	internal ac()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		((Control)this).MouseDown += new MouseEventHandler(A);
		((Control)this).MouseUp += new MouseEventHandler(a);
		((Control)this).MouseMove += new MouseEventHandler(B);
		((Control)this).MouseLeave += new EventHandler(d);
		gW.A(new TreeViewCancelEventHandler(A));
		gW.A(new TreeViewEventHandler(a));
		gW.B(new TreeViewEventHandler(A));
		((Control)gW).MouseClick += new MouseEventHandler(b);
		((Control)gU).BackColor = ((Control)this).BackColor;
		if (gU.Image != null)
		{
			gU.Image.Dispose();
		}
		gU.Image = (Image)(object)O.A((Image)(object)GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		((Control)gU).Width = 24;
		((Control)gU).Height = 24;
		((Control)gu).Enabled = false;
		((Control)gu).TextChanged += new EventHandler(l);
		gu.A(A);
		((Control)gV).Enabled = false;
		((Control)gV).Click += new EventHandler(L);
		((Control)gV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Di();
		((Control)gV).Font = new Font(((Control)gV).Font.FontFamily, 8f, (FontStyle)1);
		gv.Interval = 400;
		gv.Tick += new EventHandler(M);
		D();
		((Control)this).Controls.Add((Control)(object)gU);
		((Control)this).Controls.Add((Control)(object)gu);
		((Control)this).Controls.Add((Control)(object)gV);
		((Control)this).Controls.Add((Control)(object)gW);
		((Control)gt).Click += new EventHandler(A);
		((Control)gt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fb();
		((Control)gt).Enabled = false;
		((Control)this).Controls.Add((Control)(object)gt);
		((TextBoxBase)HB).ReadOnly = true;
		((RichTextBox)HB).ScrollBars = (RichTextBoxScrollBars)2;
		((Control)HB).Height = 120;
		((Control)this).Controls.Add((Control)(object)HB);
		((Control)gX).AutoSize = false;
		((Control)gX).Height = 24;
		((Control)gX).Click += new EventHandler(b);
		((Control)gX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FC();
		((Control)gX).Enabled = false;
		((Control)gx).AutoSize = false;
		((Control)gx).Height = 24;
		((ButtonBase)gx).ImageAlign = (ContentAlignment)32;
		((ButtonBase)gx).Image = BM.tR;
		((Control)gx).Click += new EventHandler(a);
		((Control)gx).Enabled = false;
		((Control)gY).AutoSize = false;
		((Control)gY).Height = 24;
		((ButtonBase)gY).ImageAlign = (ContentAlignment)32;
		((ButtonBase)gY).Image = BM.tr;
		((Control)gY).Click += new EventHandler(B);
		((Control)gY).Enabled = false;
		((Control)gy).AutoSize = false;
		((Control)gy).Height = 24;
		((Control)gy).Click += new EventHandler(C);
		((Control)gy).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FC();
		((Control)gy).Enabled = false;
		((Control)gw).Height = ((Control)gx).Height + 2;
		((Control)gw).Controls.Add((Control)(object)gX);
		((Control)gw).Controls.Add((Control)(object)gx);
		((Control)gw).Controls.Add((Control)(object)gY);
		((Control)gw).Controls.Add((Control)(object)gy);
		((Control)this).Controls.Add((Control)(object)gw);
	}

	[SpecialName]
	internal TreeViewWithThemedScrollBars A()
	{
		return gW;
	}

	[SpecialName]
	internal ThemedTextBox a()
	{
		return gu;
	}

	[SpecialName]
	internal ag B()
	{
		return HB;
	}

	[SpecialName]
	internal bool b()
	{
		return HH;
	}

	[SpecialName]
	internal void A(bool P_0)
	{
		HH = P_0;
	}

	[SpecialName]
	internal bool C()
	{
		return Hh;
	}

	[SpecialName]
	internal void a(bool P_0)
	{
		Hh = P_0;
	}

	internal void c()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<TreeNode> enumerator = gW.a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				TreeNode current = enumerator.Current;
				A(current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		gW.a().Clear();
		((Control)gW).Invalidate();
		gZ.Clear();
		gz.Clear();
		F();
		f();
		((TextBoxBase)HB).Clear();
		HB.A();
	}

	private void A(TreeNode P_0)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		P_0.Tag = null;
		foreach (TreeNode node in P_0.Nodes)
		{
			TreeNode val = node;
			A(val);
		}
	}

	internal void D()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		((Control)gW).BackColor = BM.tg;
		((Control)gW).ForeColor = BM.te;
		((UserControl)gW).BorderStyle = (BorderStyle)(BM.TO ? 1 : 0);
		((Control)gU).BackColor = ((Control)this).BackColor;
		if (gU.Image != null)
		{
			gU.Image.Dispose();
		}
		gU.Image = (Image)(object)O.A((Image)(object)GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		((Control)gu).BackColor = BM.to;
		((Control)gu).ForeColor = BM.te;
		((ButtonBase)gx).Image = BM.tR;
		((ButtonBase)gY).Image = BM.tr;
		((Control)HB).BackColor = BM.tg;
	}

	internal void d()
	{
		((Control)gt).Width = ((Control)this).Width - 5;
		((Control)HB).Width = ((Control)this).Width - 5;
		((Control)HB).Top = ((Control)this).Height - ((Control)HB).Height;
		HB.A();
		((Control)gw).Width = ((Control)this).Width - 5;
		((Control)gX).Width = 30;
		((Control)gx).Width = (((Control)gw).Width - 2 * ((Control)gX).Width) / 2 - 1;
		((Control)gx).Left = ((Control)gX).Right;
		((Control)gY).Width = ((Control)gx).Width;
		((Control)gY).Left = ((Control)gx).Right;
		((Control)gy).Width = ((Control)gX).Width;
		((Control)gy).Left = ((Control)gY).Right;
		((Control)gw).Top = ((Control)HB).Top - ((Control)gw).Height - 4;
		((Control)gu).Left = ((Control)gU).Right + 1;
		((Control)gV).Width = 22;
		((Control)gu).Top = ((Control)gt).Bottom + 2;
		((Control)gu).Width = ((Control)this).Width - 4 - (((Control)gU).Width + ((Control)gV).Width + 6);
		((Control)gU).Top = ((Control)gu).Top;
		((Control)gV).Left = ((Control)gu).Right + 3;
		((Control)gV).Top = ((Control)gu).Top - 2;
		((Control)gV).Height = ((Control)gu).Height + 2;
		((Control)gW).Width = ((Control)this).Width - 5;
		((Control)gW).Height = ((Control)gw).Top - ((Control)gt).Height - 4 - (((Control)gV).Height + 2);
		((Control)gW).Top = ((Control)gu).Bottom + 2;
	}

	protected override void OnResize(EventArgs e)
	{
		((UserControl)this).OnResize(e);
		d();
	}

	private void A(ref A[] P_0, TreeNodeCollection P_1, bool P_2)
	{
		for (int i = 0; i < P_1.Count; i++)
		{
			if (!(P_1[i].Tag is MenuNode))
			{
				continue;
			}
			MenuNode menuNode = (MenuNode)P_1[i].Tag;
			if (menuNode.a() != null && (P_2 || menuNode != BM.qa))
			{
				int num = menuNode.e();
				if (P_1[i].IsExpanded)
				{
					P_0[num] = ac.A.Bla;
				}
				else
				{
					P_0[num] = ac.A.BlB;
				}
				A(ref P_0, P_1[i].Nodes, P_2);
			}
		}
	}

	private void A(ref A[] P_0, List<TreeNode> P_1, bool P_2)
	{
		for (int i = 0; i < P_1.Count; i++)
		{
			if (!(P_1[i].Tag is MenuNode))
			{
				continue;
			}
			MenuNode menuNode = (MenuNode)P_1[i].Tag;
			if (menuNode.a() != null && (P_2 || menuNode != BM.qa))
			{
				int num = menuNode.e();
				if (P_1[i].IsExpanded)
				{
					P_0[num] = ac.A.Bla;
				}
				else
				{
					P_0[num] = ac.A.BlB;
				}
				A(ref P_0, P_1[i].Nodes, P_2);
			}
		}
	}

	private void A(ref A[] P_0)
	{
		for (int i = 0; i < gW.a().Count; i++)
		{
			MenuNode menuNode = (MenuNode)gW.a()[i].Tag;
			if (menuNode != null && menuNode.B() != null)
			{
				byte b = (byte)menuNode.B().A();
				P_0[b] = ac.A.BlB;
			}
		}
	}

	internal void A(bool P_0, bool P_1, bool P_2, bool P_3)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).InvokeRequired)
		{
			try
			{
				a a = A;
				((Control)this).Invoke((System.Delegate)a, new object[4] { P_0, P_1, P_2, P_3 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BM.Qz == null)
		{
			return;
		}
		Stopwatch val = new Stopwatch();
		val.Start();
		if (gW.d() == null)
		{
			gW.A(new List<Image>());
		}
		else
		{
			gW.d().Clear();
		}
		((Control)gt).Enabled = true;
		((Control)gu).Enabled = true;
		((Control)gV).Enabled = true;
		A[] array = null;
		A[] array2 = null;
		A[] array3 = null;
		int num = -1;
		byte b = 0;
		bool flag = false;
		if (gW.a().Count >= 2)
		{
			if (gW.B() != null && gW.B().Tag != null)
			{
				if (gW.B() == gW.a()[0])
				{
					flag = true;
				}
				else if (((MenuNode)gW.B().Tag).B() != null)
				{
					b = (byte)((MenuNode)gW.B().Tag).B().A();
				}
				else
				{
					num = ((MenuNode)gW.B().Tag).e();
				}
			}
			array = new A[BM.Qz.L()];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = ac.A.BlA;
			}
			A(ref array, gW.a()[1].Nodes, true);
			if (gW.a()[1].IsExpanded)
			{
				array[0] = ac.A.Bla;
			}
			else
			{
				array[0] = ac.A.BlB;
			}
			array2 = new A[BM.Qz.L()];
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j] = ac.A.BlA;
			}
			A(ref array2, gW.a(), false);
			array3 = new A[256];
			for (int k = 0; k < array3.Length; k++)
			{
				array3[k] = ac.A.BlA;
			}
			A(ref array3);
		}
		gW.b();
		int num2 = BM.QQ.rl.b();
		string text = string.Empty;
		int num3 = -1;
		if (BM.QQ.rl.E().Count > 0 && BM.QQ.rl.d().Count > 0)
		{
			if (BM.QQ.rl.E()[num2] != -1)
			{
				num3 = BM.QQ.rl.E()[num2];
			}
			else if (!string.IsNullOrEmpty(BM.QQ.rl.d()[num2]))
			{
				text = BM.QQ.rl.d()[num2];
			}
		}
		if (P_0)
		{
			HJ = null;
			gW.a().Clear();
			HI.Clear();
			if (File.Exists(gT))
			{
				h();
			}
			else
			{
				H();
			}
		}
		List<string> val2 = new List<string>();
		if (((Control)gu).Text != string.Empty)
		{
			string[] array4 = ((Control)gu).Text.Split(RuntimeHelpers.CreateSpan<char>((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/));
			for (int l = 0; l < array4.Length; l++)
			{
				val2.Add(array4[l].ToLower());
			}
		}
		A(P_0, BM.qA, null, false, null, P_1, val2);
		A(P_0, BM.qa, null, false, array, P_1, val2);
		Enumerator<MenuNode> enumerator = BM.Qz.awj.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				MenuNode current = enumerator.Current;
				A(P_0, current, null, false, array2, P_1, val2);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		enumerator = BM.ST.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				MenuNode current2 = enumerator.Current;
				A(P_0, current2, null, false, array3, P_1, val2);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (P_0)
		{
			gZ.Clear();
			gz.Clear();
			F();
			f();
		}
		if (P_3)
		{
			this.a(gW.B());
		}
		if (((TabControl)BM.QQ.rl).SelectedTab != null && (((TabControl)BM.QQ.rl).SelectedTab as ae).A() == BP.uA)
		{
			if (HK != 0)
			{
				Enumerator<TreeNode> enumerator2 = gW.a().GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						TreeNode current3 = enumerator2.Current;
						if (current3.Tag is MenuNode menuNode && menuNode.B() != null && menuNode.B().A() == HK)
						{
							gW.A(current3);
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				HK = bt.avK;
			}
			else if (P_2)
			{
				if (!P_0 && BM.QQ.rl.i() != null)
				{
					C(false);
				}
				else if (flag)
				{
					gW.A(gW.a()[0]);
					A(gW.B(), false);
				}
				else if (num != -1)
				{
					gW.A(A(num));
					if (gW.B() != null)
					{
						A(gW.B(), false);
					}
				}
				else if (b != 0)
				{
					Enumerator<TreeNode> enumerator2 = gW.a().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							TreeNode current4 = enumerator2.Current;
							if (current4.Tag is MenuNode menuNode2 && menuNode2.B() != null && (uint)menuNode2.B().A() == b)
							{
								gW.A(current4);
								if (gW.B() != null)
								{
									A(gW.B(), false);
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
				else if (((TabControl)BM.QQ.rl).SelectedIndex == num2)
				{
					if (num3 != -1)
					{
						B(num3);
						if (gW.B() == null && HJ != null)
						{
							gW.A(HJ);
						}
					}
					else if (text != string.Empty)
					{
						A(text);
						if (gW.B() == null && HJ != null)
						{
							gW.A(HJ);
						}
					}
					else if (HJ != null)
					{
						gW.A(HJ);
					}
				}
			}
		}
		gW.C();
		val.Stop();
		N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fc(), (object)val.ElapsedMilliseconds), true);
	}

	private void A(bool P_0, MenuNode P_1, TreeNode P_2, bool P_3, A[] P_4, bool P_5, List<string> P_6)
	{
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		string text = P_1.E();
		int num = P_1.b();
		int num2 = P_1.H();
		int num3 = P_1.e();
		bool flag = P_1.f();
		byte b = 0;
		bu bu = P_1.B();
		if (bu != null)
		{
			b = (byte)bu.A();
		}
		SettingOrSpecialObject settingOrSpecialObject = BM.Qz.a(num);
		SettingOrSpecialObject settingOrSpecialObject2 = BM.Qz.a(num2);
		if (P_3 && settingOrSpecialObject is Table)
		{
			text = settingOrSpecialObject.A(bz.aYt);
		}
		TreeNode val = A(P_0, P_1, P_2, P_4, num3, bu, b, P_3);
		string text2 = A(text, P_1, settingOrSpecialObject, settingOrSpecialObject2, bu);
		string text3 = text;
		string text4 = text;
		if (!string.IsNullOrEmpty(text2))
		{
			text3 = text2;
			text4 = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
		}
		TreeNode val2 = null;
		if (val != null)
		{
			val2 = val;
			if (HL && !string.IsNullOrEmpty(P_1.U()))
			{
				string text5 = text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FD() + P_1.U() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fd();
				if (val.Text != text5)
				{
					val.Text = text5;
				}
			}
			else if (val.Text != text3)
			{
				val.Text = text3;
			}
			if (val.ToolTipText != text4)
			{
				val.ToolTipText = text4;
			}
		}
		else
		{
			val2 = (TreeNode)(object)((!HL || string.IsNullOrEmpty(P_1.U())) ? new aw(text3) : new aw(text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FD() + P_1.U() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fd()));
			val2.ToolTipText = text4;
			(val2 as aw).kq = !P_1.M();
		}
		val2.ImageIndex = A(P_1);
		val2.Tag = P_1;
		if (P_2 != null && P_2.ForeColor == Color.Gray)
		{
			val2.ForeColor = Color.Gray;
		}
		else
		{
			val2.ForeColor = BM.te;
		}
		if (BM.Qz.awZ == 21)
		{
			if (P_1 == BM.Qz.awR)
			{
				HJ = val2;
			}
		}
		else if (settingOrSpecialObject != null && P_2 != null && settingOrSpecialObject.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FE())
		{
			HJ = P_2;
		}
		if (P_1.C() != null)
		{
			if ((P_1.C().j() || (P_1.K() && !P_1.C().l()) || ((!P_1.K() || !P_1.C().l()) && P_1.J()) || P_1.C().M()) && P_1.C().H() == -1)
			{
				val2.Tag = null;
				return;
			}
			if (((BM.Qz.awZ == 20 && BM.Qz.aXA < new k(1, 21, 0, 4, 0)) || (bx.A(BM.Qz.awZ) && BM.Qz.aXA < new k(3, 8, 0, 4, 0))) && text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cJ())
			{
				val2.Tag = null;
				return;
			}
		}
		if (A(P_1, val2, val, P_2, settingOrSpecialObject, settingOrSpecialObject2, bu, P_3, P_6) || A(P_1, val2, val, P_2) || A(P_1, val2, val, P_2, settingOrSpecialObject))
		{
			return;
		}
		if (BM.Qz.awA || !P_3)
		{
			if (P_1 == BM.qa)
			{
				A(P_0, val2, P_4, P_5, P_6);
			}
			else
			{
				Enumerator<MenuNode> enumerator = P_1.c().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						MenuNode current = enumerator.Current;
						A(P_0, current, val2, P_3, P_4, P_5, P_6);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
		}
		bool flag2 = true;
		if (P_6.Count != 0)
		{
			flag2 = A(P_1, P_6);
		}
		bool num4 = A(P_1, val2.GetNodeCount(true), P_6);
		bool flag3 = P_1.l() || P_1.M() || P_1.o();
		bool flag4 = P_1 == BM.Qz.awU || P_1 == BM.Qz.awu || P_1 == BM.Qz.awV;
		if (!num4 && P_1 != BM.qc && ((settingOrSpecialObject == null && settingOrSpecialObject2 == null && !flag3) || !flag2) && bu == null && P_1 != BM.qA && !flag4)
		{
			Setting setting = null;
			if (P_1.x() && !P_1.aA())
			{
				setting = BM.Qz.A(P_1.W());
			}
			if ((setting == null || setting.Bb() || !flag2 || (BM.qC != null && !BM.qD.Contains(setting.A()))) && A(val2, val, P_2))
			{
				return;
			}
		}
		if (flag || P_6.Count != 0 || BM.qC != null)
		{
			val2.Expand();
		}
		if (P_0 || val == null)
		{
			A(P_0, val2, P_2, num3, bu, b, P_3);
		}
		if (P_5 && P_4 != null)
		{
			A(val2, P_1, P_4, settingOrSpecialObject, bu, num3);
		}
		A(val2, P_1, settingOrSpecialObject, settingOrSpecialObject2, bu);
		if ((P_1.j() || P_1.K()) && val2.Parent != null && val2.Nodes.Count != 0)
		{
			while (val2.Nodes.Count != 0)
			{
				TreeNode val3 = val2.Nodes[0];
				val2.Nodes.Remove(val3);
				val2.Parent.Nodes.Add(val3);
			}
			val2.Tag = null;
			A(val2, P_2);
		}
	}

	private void A(bool P_0, TreeNode P_1, A[] P_2, bool P_3, List<string> P_4)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		if (BM.Qz.awA)
		{
			Enumerator<int> enumerator = HI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					if (BM.Qz.awB.ContainsKey(current))
					{
						MenuNode menuNode = BM.Qz.awB[current];
						A(P_0, menuNode, P_1, true, P_2, P_3, P_4);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			List<TreeNode> val = new List<TreeNode>();
			foreach (TreeNode node in P_1.Nodes)
			{
				TreeNode val2 = node;
				if (val2.Tag is MenuNode menuNode2 && !HI.Contains(menuNode2.s()))
				{
					val.Add(val2);
				}
			}
			Enumerator<TreeNode> enumerator3 = val.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					MenuNode menuNode3 = enumerator3.Current.Tag as MenuNode;
					A(P_0, menuNode3, P_1, true, P_2, P_3, P_4);
				}
				return;
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
		}
		Enumerator<Table> enumerator4 = BM.Qz.aWV.GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				Table current2 = enumerator4.Current;
				MenuNode menuNode4 = MenuNode.A(BM.Qz.awj, current2.C());
				if (menuNode4 != null)
				{
					A(P_0, menuNode4, P_1, true, P_2, P_3, P_4);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator4).Dispose();
		}
	}

	private void A(TreeNode P_0, MenuNode P_1, SettingOrSpecialObject P_2, SettingOrSpecialObject P_3, bu P_4)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (!(P_0 is aw))
		{
			return;
		}
		bool flag = P_1 == BM.Qz.awU || P_1 == BM.Qz.awu || P_1 == BM.Qz.awV;
		bool kR = false;
		if (P_2 != null || P_3 != null || P_4 != null || P_1 == BM.qA || (P_0.Parent == null && P_1 != BM.qa) || flag)
		{
			kR = true;
		}
		else
		{
			Enumerator<MenuNode> enumerator = P_1.c().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.J())
					{
						kR = true;
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		(P_0 as aw).kR = kR;
	}

	private TreeNode A(bool P_0, MenuNode P_1, TreeNode P_2, A[] P_3, int P_4, bu P_5, byte P_6, bool P_7)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		TreeNode result = null;
		if (!P_0 && (P_3 != null || P_1 == BM.qA || P_1 == BM.qa))
		{
			if (P_1 == BM.qA)
			{
				if (gW.a().Count != 0)
				{
					result = gW.a()[0];
				}
			}
			else if (P_1 == BM.qa)
			{
				if (gW.a().Count >= 2)
				{
					result = gW.a()[1];
				}
			}
			else if (P_5 != null)
			{
				if (P_3[P_6] != 0)
				{
					Enumerator<TreeNode> enumerator = gW.a().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							TreeNode current = enumerator.Current;
							if (current.Tag is MenuNode menuNode && menuNode.B() != null && (uint)menuNode.B().A() == P_6)
							{
								result = current;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
			}
			else if (P_3[P_4] != 0)
			{
				if (P_7)
				{
					foreach (TreeNode node in P_2.Nodes)
					{
						TreeNode val = node;
						if (val.Tag is MenuNode menuNode2 && menuNode2.e() == P_4)
						{
							result = val;
							break;
						}
					}
				}
				else
				{
					result = A(P_4);
				}
			}
		}
		return result;
	}

	private void A(TreeNode P_0, MenuNode P_1, A[] P_2, SettingOrSpecialObject P_3, bu P_4, int P_5)
	{
		if (P_1 == BM.qA || P_4 != null)
		{
			P_0.Collapse();
		}
		else if (P_1 == BM.qa)
		{
			if (P_2[0] == ac.A.Bla)
			{
				P_0.Expand();
			}
			else
			{
				P_0.Collapse();
			}
		}
		else if (P_2[P_5] == ac.A.Bla)
		{
			P_0.Expand();
		}
		else
		{
			P_0.Collapse();
		}
	}

	private string A(string P_0, MenuNode P_1, SettingOrSpecialObject P_2, SettingOrSpecialObject P_3, bu P_4)
	{
		string text = string.Empty;
		if (P_2 != null)
		{
			text = P_2.H();
		}
		if (string.IsNullOrWhiteSpace(text))
		{
			if (P_4 != null)
			{
				bt bt = P_4.A();
				if (BM.Qz.awf.ContainsKey((byte)bt))
				{
					text = ((SettingOrSpecialObject)BM.Qz.awf[(byte)bt]).H();
				}
			}
			else if (P_1.l())
			{
				int num = P_1.m();
				DK dK = BM.Qz.awP.E()[num];
				int num2 = BM.Qz.awP.B().ax();
				text = dK.H();
				if (num == num2)
				{
					text = ((!string.IsNullOrWhiteSpace(text)) ? (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fe()) : (P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fe()));
				}
			}
			else if (P_1.M())
			{
				int num3 = P_1.C().C().m();
				int num4 = P_1.N();
				try
				{
					Dk dk = BM.Qz.awP.E()[num3].a()[num4];
					text = ((SettingOrSpecialObject)dk).H();
					if (!string.IsNullOrWhiteSpace(text))
					{
						string text2 = dk.Bc();
						text = (string.IsNullOrEmpty(text2) ? (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()) : (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()));
					}
				}
				catch
				{
					N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FF(), (object)num4, (object)num3, (object)P_1.E()), true);
				}
			}
			else if (P_1.o())
			{
				int num5 = P_1.P();
				text = BM.Qz.awp.B()[num5].H();
			}
			else if (BM.Qz.aWz)
			{
				if (P_1.h() != 0)
				{
					Setting setting = BM.Qz.A(P_1.h());
					if (setting != null && ((SettingOrSpecialObject)setting).D() != null && ((SettingOrSpecialObject)setting).D() is SpecialObject && BM.Qz.aWY.Contains(((SettingOrSpecialObject)setting).D()))
					{
						text = ((SettingOrSpecialObject)setting).D().H();
					}
				}
			}
			else if (P_3 != null)
			{
				text = P_3.H();
			}
		}
		return text;
	}

	private int A(MenuNode P_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		Image val = null;
		if (P_0.u() != null)
		{
			val = (Image)(Bitmap)TreeIconsResources.ResourceManager.GetObject(P_0.u(), CultureInfo.CurrentCulture);
		}
		int result = -1;
		if (val != null)
		{
			result = gW.d().Count;
			gW.d().Add(val);
		}
		return result;
	}

	private bool A(MenuNode P_0, TreeNode P_1, TreeNode P_2, TreeNode P_3)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (P_0.a() != null)
		{
			SettingOrSpecialObject settingOrSpecialObject = P_0.a().a(P_0.b());
			if (settingOrSpecialObject is Table)
			{
				Table table = settingOrSpecialObject as Table;
				MenuNode menuNode = P_0.A(table.TableDataSetting);
				if (menuNode != null && menuNode.z() && menuNode != P_0)
				{
					HashSet<DataIdAndAttrId> idsContained = table.GetIdsContained();
					bool flag = true;
					Enumerator<DataIdAndAttrId> enumerator = idsContained.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							DataIdAndAttrId current = enumerator.Current;
							Setting setting = P_0.a().A(current);
							if (setting != null && setting.E())
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
					if (flag && A(P_1, P_2, P_3))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private bool A(MenuNode P_0, TreeNode P_1, TreeNode P_2, TreeNode P_3, SettingOrSpecialObject P_4)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (BM.qC != null && (!P_0.x() || (P_0 != BM.qc && !BM.qD.Contains(P_0.W()))))
		{
			if (P_4 is Table)
			{
				Table table = P_4 as Table;
				if ((table.TableDataSetting == null || !BM.qD.Contains(table.TableDataSetting.A())) && A(P_1, P_2, P_3))
				{
					return true;
				}
			}
			else
			{
				HashSet<DataIdAndAttrId> obj = MenuNode.A(P_0, false);
				bool flag = false;
				Enumerator<DataIdAndAttrId> enumerator = obj.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataIdAndAttrId current = enumerator.Current;
						if (BM.qD.Contains(current.DataId))
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
				if (!flag && A(P_1, P_2, P_3))
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool A(TreeNode P_0, TreeNode P_1, TreeNode P_2)
	{
		if (P_1 != null)
		{
			P_1.Tag = null;
			A(P_1, P_2);
			return false;
		}
		P_0.Tag = null;
		return true;
	}

	private bool A(MenuNode P_0, TreeNode P_1, TreeNode P_2, TreeNode P_3, SettingOrSpecialObject P_4, SettingOrSpecialObject P_5, bu P_6, bool P_7, List<string> P_8)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		bool flag;
		bool flag2 = A(P_0, out flag);
		if (((Hh && BM.qC == null) || P_7) && flag2)
		{
			if ((P_8.Count != 0 || BM.qC != null) && !P_7 && !flag)
			{
				P_1.ForeColor = Color.Gray;
			}
			else if (A(P_1, P_2, P_3))
			{
				return true;
			}
		}
		else if (flag2)
		{
			if (!flag)
			{
				P_1.ForeColor = Color.Gray;
			}
			else if (A(P_1, P_2, P_3))
			{
				return true;
			}
		}
		else if (P_4 != null)
		{
			bool flag3 = P_4.l();
			if (P_4 is Table && BM.Qn != null && BM.QO == BM.b.BpG)
			{
				Setting setting = BM.Qn.A(((Setting)(P_4 as Table)).A());
				if (setting is Table)
				{
					flag3 = ((SettingOrSpecialObject)setting).l();
				}
			}
			if (!flag3)
			{
				if ((Hh && BM.qC == null) || P_7)
				{
					if ((P_8.Count != 0 || BM.qC != null) && !P_7)
					{
						P_1.ForeColor = Color.Gray;
					}
					else if (A(P_1, P_2, P_3))
					{
						return true;
					}
				}
				else
				{
					P_1.ForeColor = Color.Gray;
				}
			}
			if (P_7)
			{
				bool flag4 = P_3 != null && P_3.Tag is MenuNode && (MenuNode)P_3.Tag == BM.qa;
				if (!A(P_0, !flag4) && A(P_1, P_2, P_3))
				{
					return true;
				}
			}
			if (P_4.J().Count != 0 || P_4.K().A().Count != 0)
			{
				P_1.Tag = null;
				return true;
			}
			if (a(P_0, P_4, P_7, P_8, P_1, P_2, P_3))
			{
				return true;
			}
		}
		else
		{
			P_4 = P_5;
			if (P_5 != null)
			{
				if (A(P_0, P_5, P_7, P_8, P_1, P_2, P_3))
				{
					return true;
				}
			}
			else if (P_6 != null)
			{
				Setting setting2 = null;
				if (BM.Qz.awf.ContainsKey((byte)P_6.A()))
				{
					setting2 = BM.Qz.awf[(byte)P_6.A()];
				}
				if ((P_6.C() || (setting2 != null && setting2.am() && setting2.ax() == 0) || (setting2 == null && !P_6.D() && !BM.Qz.A(P_6.A()))) && A(P_1, P_2, P_3))
				{
					return true;
				}
			}
			else
			{
				if (a(P_0, P_1, P_2, P_3))
				{
					return true;
				}
				if (P_7)
				{
					bool flag5 = P_3 != null && P_3.Tag is MenuNode && (MenuNode)P_3.Tag == BM.qa;
					if (!A(P_0, !flag5) && A(P_1, P_2, P_3))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private bool A(MenuNode P_0, out bool P_1)
	{
		P_1 = false;
		bool result;
		if (BM.Qn != null && BM.QO == BM.b.BpG)
		{
			if (P_0.h() != 0)
			{
				Setting setting = BM.Qn.A(P_0.h());
				result = ((P_0.h() != 10195) ? (setting != null && setting.ax() != 1) : (setting != null && setting.ax() == 0));
				if (setting != null && setting.am())
				{
					P_1 = true;
				}
			}
			else
			{
				result = false;
			}
		}
		else
		{
			result = P_0.A(out var setting2);
			if (setting2 != null && setting2.am())
			{
				P_1 = true;
			}
		}
		return result;
	}

	private bool A(MenuNode P_0, SettingOrSpecialObject P_1, bool P_2, List<string> P_3, TreeNode P_4, TreeNode P_5, TreeNode P_6)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		if (P_2)
		{
			bool flag = P_6 != null && P_6.Tag is MenuNode && (MenuNode)P_6.Tag == BM.qa;
			if (!A(P_0, !flag) && A(P_4, P_5, P_6))
			{
				return true;
			}
		}
		Setting setting = null;
		Enumerator<SettingOrSpecialObject> enumerator = P_1.a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SettingOrSpecialObject current = enumerator.Current;
				if (current is Setting && (current.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ff()) || current.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FG()) || current.B().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fg())))
				{
					setting = current as Setting;
					break;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (setting != null && BM.Qn != null && BM.QO == BM.b.BpG)
		{
			setting = BM.Qn.A(setting.A());
		}
		bool flag2 = false;
		if (setting != null)
		{
			flag2 = ((setting.A() != 10195) ? (setting.ax() != 1) : (setting.ax() == 0));
		}
		bool flag3 = setting?.am() ?? false;
		if (!flag2 && P_1.F().D().Count == 0)
		{
			HashSet<DataIdAndAttrId> val = P_0.j(false);
			bool flag4 = true;
			Enumerator<DataIdAndAttrId> enumerator2 = val.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					DataIdAndAttrId current2 = enumerator2.Current;
					Setting setting2 = ((BM.Qn == null || BM.QO != BM.b.BpG) ? BM.Qz.A(current2) : BM.Qn.A(current2));
					if (setting2 == null || setting2 == setting || ((SettingOrSpecialObject)setting2).A().aWZ.Contains(current2.DataId) || (!((SettingOrSpecialObject)setting2).l() && (!(setting2 is Dn) || setting2.O())) || (!(setting2 is Dn) && setting2.am()) || setting2.aN() || setting2.al())
					{
						continue;
					}
					PortFunction.B b = null;
					if (setting2.av()[0] == 1 && setting2.av()[1] == 1 && setting2.av()[2] == 1 && PortFunction.a(((SettingOrSpecialObject)setting2).D()))
					{
						b = ((SettingOrSpecialObject)setting2).D().F().E();
					}
					if (b == null)
					{
						flag4 = false;
						break;
					}
					List<Dn> val2 = PortFunction.A(((SettingOrSpecialObject)setting2).A(), b.BSQ, b.BSq, b.BSR, b.BSr, false);
					if (val2 == null)
					{
						continue;
					}
					for (int i = 0; i < val2.Count; i++)
					{
						if (val.Contains(val2[i].C()))
						{
							flag4 = false;
							break;
						}
					}
					if (!flag4)
					{
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			flag2 = flag4;
		}
		if (flag2)
		{
			if ((Hh && BM.qC == null) || P_2)
			{
				if ((P_3.Count != 0 || BM.qC != null) && !flag3)
				{
					P_4.ForeColor = Color.Gray;
				}
				else if (A(P_4, P_5, P_6))
				{
					return true;
				}
			}
			else if (!flag3)
			{
				P_4.ForeColor = Color.Gray;
			}
			else if (A(P_4, P_5, P_6))
			{
				return true;
			}
		}
		return false;
	}

	private bool a(MenuNode P_0, SettingOrSpecialObject P_1, bool P_2, List<string> P_3, TreeNode P_4, TreeNode P_5, TreeNode P_6)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (P_1 is SpecialObject && (P_1 as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.Count != 0)
		{
			bool flag = true;
			Enumerator<DataIdAndAttrId> enumerator = P_0.j(false).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DataIdAndAttrId current = enumerator.Current;
					Setting setting = ((BM.Qn == null || BM.QO != BM.b.BpG) ? BM.Qz.A(current) : BM.Qn.A(current));
					if (setting != null && !((SettingOrSpecialObject)setting).A().aWZ.Contains(current.DataId) && ((SettingOrSpecialObject)setting).l() && !setting.am() && !setting.aN() && !setting.al())
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
			if (flag)
			{
				if ((Hh && BM.qC == null) || P_2)
				{
					if (P_3.Count != 0 || BM.qC != null)
					{
						P_4.ForeColor = Color.Gray;
					}
					else if (A(P_4, P_5, P_6))
					{
						return true;
					}
				}
				else
				{
					P_4.ForeColor = Color.Gray;
				}
			}
		}
		return false;
	}

	private bool a(MenuNode P_0, TreeNode P_1, TreeNode P_2, TreeNode P_3)
	{
		if (BM.Qz.awZ == 21)
		{
			if (P_0.l())
			{
				if (P_0.m() >= BM.Qz.awP.a().ax() && A(P_1, P_2, P_3))
				{
					return true;
				}
			}
			else if (P_0.M())
			{
				int num = P_0.N();
				int num2 = P_0.C().C().m();
				try
				{
					if (BM.Qz.awP.E()[num2].a()[num].B().ax() == 0 && A(P_1, P_2, P_3))
					{
						return true;
					}
				}
				catch
				{
					N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FF(), (object)num, (object)num2, (object)P_0.E()), true);
				}
			}
			else if (P_0.o())
			{
				int num3 = P_0.P();
				DJ dJ = BM.Qz.awp.B()[num3];
				if (dJ.a() != null && dJ.a().ax() == 0 && A(P_1, P_2, P_3))
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool A(MenuNode P_0, bool P_1)
	{
		MenuNode menuNode = P_0;
		bool flag = false;
		do
		{
			SettingOrSpecialObject settingOrSpecialObject = BM.Qz.a(menuNode.b());
			int num = -1;
			if (settingOrSpecialObject is Table)
			{
				num = ((Setting)(settingOrSpecialObject as Table)).A();
			}
			else if (menuNode.s() != -1)
			{
				num = menuNode.s();
			}
			if (num != -1 && HI.Contains(num))
			{
				return true;
			}
			if (!P_1)
			{
				return false;
			}
			if (menuNode.C() != null)
			{
				menuNode = menuNode.C();
			}
			else
			{
				flag = true;
			}
		}
		while (!flag);
		return false;
	}

	private bool A(MenuNode P_0, int P_1, List<string> P_2)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (P_0 == BM.qa || P_1 != 0)
		{
			flag = true;
		}
		else
		{
			Enumerator<MenuNode> enumerator = P_0.c().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					MenuNode current = enumerator.Current;
					if (!current.J())
					{
						continue;
					}
					if (P_2.Count == 0)
					{
						SpecialObject specialObject = BM.Qz.a(current.b()) as SpecialObject;
						if (specialObject != null && specialObject.b().DataIdsOfListSettings.Count != 0)
						{
							int num;
							if (specialObject.b().FixedCountValue != 0)
							{
								num = specialObject.b().FixedCountValue;
							}
							else
							{
								Setting setting = BM.Qz.A(specialObject.b().DataIdOfListCountSetting);
								int num2 = setting.ax();
								num = setting.ar();
								if (num2 > num && num != 0)
								{
									num2 = num;
								}
								if (num == 0)
								{
									num = num2;
								}
							}
							for (int i = 0; i < specialObject.b().DataIdsOfListSettings.Count; i++)
							{
								int num3 = specialObject.b().DataIdsOfListSettings[i];
								Setting setting2 = BM.Qz.A(num3);
								if (BM.qC == null || BM.qD.Contains(num3))
								{
									for (int j = 0; j < num; j++)
									{
										if (setting2.q()[0, 0, j] || !Hh || BM.qC != null)
										{
											flag = true;
											break;
										}
									}
								}
								if (flag)
								{
									break;
								}
							}
						}
						else
						{
							Enumerator<DataIdAndAttrId> enumerator2 = current.j(false).GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									DataIdAndAttrId current2 = enumerator2.Current;
									Setting setting3 = BM.Qz.A(current2);
									if (setting3 != null && (((SettingOrSpecialObject)setting3).l() || !Hh || BM.qC != null) && (setting3 is Dn || !setting3.am()) && !setting3.aN() && !setting3.al() && (BM.qC == null || BM.qD.Contains(setting3.A())))
									{
										flag = true;
										break;
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator2).Dispose();
							}
							if (!flag && specialObject != null && specialObject.B().CurrentUIListSettingsIdsAndIndents.Count == 0)
							{
								if (specialObject.R() != null)
								{
									string text = specialObject.R();
									if (BM.Qz.aWW.ErrorDefs.ContainsKey(text))
									{
										flag = true;
									}
								}
								else
								{
									Enumerator<string> enumerator3 = specialObject.Q().GetEnumerator();
									try
									{
										while (enumerator3.MoveNext())
										{
											string current3 = enumerator3.Current;
											if (BM.Qz.aWv.ContainsKey(current3))
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
								}
							}
						}
						if (flag)
						{
							break;
						}
						SettingOrSpecialObject settingOrSpecialObject = BM.Qz.a(current.b());
						if (settingOrSpecialObject != null && settingOrSpecialObject is SpecialObject && (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.Count != 0)
						{
							bool flag2 = true;
							Enumerator<UIListSettingDataIdAndIndent> enumerator4 = (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.GetEnumerator();
							try
							{
								while (enumerator4.MoveNext())
								{
									UIListSettingDataIdAndIndent current4 = enumerator4.Current;
									if (!BM.Qz.aWZ.Contains(current4.DataId) || (BM.qC != null && !BM.qD.Contains(current4.DataId)))
									{
										flag2 = false;
										break;
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator4).Dispose();
							}
							if (flag2)
							{
								flag = true;
								break;
							}
						}
						else if (settingOrSpecialObject is StateMachine && BM.qC == null && (settingOrSpecialObject as StateMachine).l())
						{
							flag = true;
							break;
						}
					}
					else if (A(current, P_2))
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
		return flag;
	}

	private void A(TreeNode P_0, TreeNode P_1)
	{
		if (P_1 != null)
		{
			P_1.Nodes.Remove(P_0);
		}
		else
		{
			gW.a().Remove(P_0);
		}
	}

	private int A(TreeNode P_0, int P_1, bu P_2, byte P_3)
	{
		List<TreeNode> val = new List<TreeNode>();
		if (P_0 != null)
		{
			for (int i = 0; i < P_0.Nodes.Count; i++)
			{
				TreeNode val2 = P_0.Nodes[i];
				val.Add(val2);
			}
		}
		else
		{
			val = gW.a();
		}
		if (val.Count != 0)
		{
			if (P_2 == null)
			{
				if (val[0].Tag is MenuNode)
				{
					if (P_1 < ((MenuNode)val[0].Tag).e())
					{
						return 0;
					}
					for (int j = 0; j < val.Count - 1; j++)
					{
						if (val[j].Tag is MenuNode && val[j + 1].Tag is MenuNode && P_1 > ((MenuNode)val[j].Tag).e() && P_1 < ((MenuNode)val[j + 1].Tag).e())
						{
							return j + 1;
						}
					}
				}
			}
			else
			{
				for (int k = 0; k < val.Count; k++)
				{
					if (val[k].Tag is MenuNode && ((MenuNode)val[k].Tag).B() != null && (int)P_3 < (int)((MenuNode)val[k].Tag).B().A())
					{
						return k;
					}
				}
				for (int l = 0; l < val.Count - 1; l++)
				{
					if (val[l].Tag is MenuNode && val[l + 1].Tag is MenuNode && ((MenuNode)val[l].Tag).B() != null && ((MenuNode)val[l + 1].Tag).B() != null && (int)P_3 > (int)((MenuNode)val[l].Tag).B().A() && (int)P_3 < (int)((MenuNode)val[l + 1].Tag).B().A())
					{
						return l + 1;
					}
				}
			}
		}
		return -1;
	}

	private void A(bool P_0, TreeNode P_1, TreeNode P_2, int P_3, bu P_4, byte P_5, bool P_6)
	{
		if (P_1.Tag == null)
		{
			return;
		}
		if (P_0)
		{
			if (P_2 != null)
			{
				P_2.Nodes.Add(P_1);
			}
			else
			{
				gW.a().Add(P_1);
			}
			return;
		}
		if (P_6 && P_2 != null)
		{
			P_2.Nodes.Add(P_1);
			return;
		}
		int num = A(P_2, P_3, P_4, P_5);
		if (P_2 != null)
		{
			if (num != -1)
			{
				P_2.Nodes.Insert(num, P_1);
			}
			else
			{
				P_2.Nodes.Add(P_1);
			}
		}
		else if (num != -1)
		{
			gW.a().Insert(num, P_1);
		}
		else
		{
			gW.a().Add(P_1);
		}
	}

	internal TreeNode A(int P_0)
	{
		try
		{
			return A(gW.a(), P_0, true);
		}
		catch
		{
			return null;
		}
	}

	private TreeNode A(TreeNodeCollection P_0, int P_1, bool P_2)
	{
		int num = 0;
		if (P_2)
		{
			num = 2;
		}
		for (int i = num; i < P_0.Count; i++)
		{
			if (P_0[i].Tag is MenuNode)
			{
				MenuNode menuNode = (MenuNode)P_0[i].Tag;
				if (menuNode.e() == P_1 && menuNode.B() == null)
				{
					return P_0[i];
				}
			}
			TreeNode val = A(P_0[i].Nodes, P_1, false);
			if (val != null)
			{
				return val;
			}
		}
		return null;
	}

	private TreeNode A(List<TreeNode> P_0, int P_1, bool P_2)
	{
		int num = 0;
		if (P_2)
		{
			num = 2;
		}
		for (int i = num; i < P_0.Count; i++)
		{
			if (P_0[i].Tag is MenuNode)
			{
				MenuNode menuNode = (MenuNode)P_0[i].Tag;
				if (menuNode.e() == P_1 && menuNode.B() == null)
				{
					return P_0[i];
				}
			}
			TreeNode val = A(P_0[i].Nodes, P_1, false);
			if (val != null)
			{
				return val;
			}
		}
		return null;
	}

	internal void a(int P_0)
	{
		if (BM.Qz.awB.ContainsKey(P_0))
		{
			MenuNode menuNode = BM.Qz.awB[P_0];
			TreeNode val = A(A().a(), menuNode);
			if (val != null)
			{
				gW.A(val);
			}
		}
	}

	internal void B(bool P_0)
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).InvokeRequired)
		{
			try
			{
				B b = B;
				((Control)this).Invoke((System.Delegate)b, new object[1] { P_0 });
				return;
			}
			catch
			{
				return;
			}
		}
		gW.b();
		if (!BM.Qz.aXA.d())
		{
			Enumerator<TreeNode> enumerator = A().a().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TreeNode current = enumerator.Current;
					if (current.Tag is MenuNode && current.Tag as MenuNode == BM.Qz.awj[0])
					{
						current.ForeColor = Color.Orange;
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		HashSet<DataIdAndAttrId> obj2 = new HashSet<DataIdAndAttrId>();
		obj2.UnionWith((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)BM.SM);
		obj2.UnionWith((System.Collections.Generic.IEnumerable<DataIdAndAttrId>)BM.Sm);
		Enumerator<DataIdAndAttrId> enumerator2 = obj2.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				DataIdAndAttrId current2 = enumerator2.Current;
				bool flag = BM.SM.Contains(current2);
				bool flag2 = !flag && BM.Sm.Contains(current2);
				bool flag3 = false;
				bool flag4 = false;
				do
				{
					TreeNode val = A(gW.a(), current2, true, false, !flag3);
					if (val != null)
					{
						Setting setting = BM.Qz.A(current2);
						if (setting != null && setting.p())
						{
							TreeNode val2 = val;
							bool flag5 = false;
							do
							{
								if (P_0 && ((flag && val2.ForeColor != BM.tC) || (flag2 && val2.ForeColor != Color.Orange)) && val2.Parent != null)
								{
									val2.Parent.Expand();
								}
								if (flag)
								{
									val2.ForeColor = BM.tC;
								}
								else if (flag2 && val2.ForeColor != BM.tC)
								{
									val2.ForeColor = Color.Orange;
								}
								if (val2.Parent != null)
								{
									val2 = val2.Parent;
								}
								else
								{
									flag5 = true;
								}
							}
							while (!flag5);
						}
					}
					if (!flag3)
					{
						flag3 = true;
					}
					else
					{
						flag4 = true;
					}
				}
				while (!flag3 || !flag4);
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
		gW.C();
		((Control)gW).Invalidate();
	}

	internal void b(bool P_0)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).InvokeRequired)
		{
			try
			{
				b b = this.b;
				((Control)this).Invoke((System.Delegate)b, new object[1] { P_0 });
				return;
			}
			catch
			{
				return;
			}
		}
		gW.b();
		Enumerator<DataIdAndAttrId> enumerator = BM.qf.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				bool flag = false;
				bool flag2 = false;
				do
				{
					TreeNode val = A(gW.a(), current, true, true, !flag);
					if (val != null)
					{
						TreeNode val2 = val;
						bool flag3 = false;
						do
						{
							if (P_0 && val2.ForeColor != BM.tC && val2.ForeColor != Color.Orange && val2.ForeColor != BM.tD && val2.Parent != null)
							{
								val2.Parent.Expand();
							}
							if (val2.ForeColor != BM.tC && val2.ForeColor != Color.Orange)
							{
								val2.ForeColor = BM.tD;
							}
							if (val2.Parent != null)
							{
								val2 = val2.Parent;
							}
							else
							{
								flag3 = true;
							}
						}
						while (!flag3);
					}
					if (!flag)
					{
						flag = true;
					}
					else
					{
						flag2 = true;
					}
				}
				while (!flag || !flag2);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		gW.C();
		((Control)gW).Invalidate();
	}

	internal void a(TreeNode P_0)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 == null)
		{
			return;
		}
		List<int> val = new List<int>();
		TreeNode val2 = P_0;
		bool flag = false;
		do
		{
			if (val2.Parent != null)
			{
				if (val2.Parent.Tag is MenuNode menuNode)
				{
					val.Add(menuNode.e());
				}
				val2 = val2.Parent;
			}
			else
			{
				flag = true;
			}
		}
		while (!flag);
		A(gW.a(), val);
		Enumerator<TreeNode> enumerator = gW.a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				TreeNode current = enumerator.Current;
				if (current.Tag is MenuNode menuNode2 && menuNode2.a() != null)
				{
					current.ExpandAll();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		a(gW.a(), val);
	}

	private static void A(List<TreeNode> P_0, List<int> P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<TreeNode> enumerator = P_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				TreeNode current = enumerator.Current;
				MenuNode menuNode = current.Tag as MenuNode;
				if (current.IsExpanded && menuNode != null)
				{
					P_1.Add(menuNode.e());
				}
				A(current.Nodes, P_1);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private static void A(TreeNodeCollection P_0, List<int> P_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		foreach (TreeNode item in P_0)
		{
			MenuNode menuNode = item.Tag as MenuNode;
			if (item.IsExpanded && menuNode != null)
			{
				P_1.Add(menuNode.e());
			}
			A(item.Nodes, P_1);
		}
	}

	private static void a(List<TreeNode> P_0, List<int> P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<TreeNode> enumerator = P_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				TreeNode current = enumerator.Current;
				if (current.Tag is MenuNode menuNode && !P_1.Contains(menuNode.e()))
				{
					current.Collapse();
				}
				a(current.Nodes, P_1);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private static void a(TreeNodeCollection P_0, List<int> P_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		foreach (TreeNode item in P_0)
		{
			TreeNode val = item;
			if (val.Tag is MenuNode menuNode && !P_1.Contains(menuNode.e()))
			{
				val.Collapse();
			}
			a(val.Nodes, P_1);
		}
	}

	internal void A(Cn P_0, List<TreeNode> P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<TreeNode> enumerator = P_1.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				TreeNode current = enumerator.Current;
				A(current, P_0);
				A(P_0, current.Nodes);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal void A(Cn P_0, TreeNodeCollection P_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		foreach (TreeNode item in P_1)
		{
			TreeNode val = item;
			A(val, P_0);
			A(P_0, val.Nodes);
		}
	}

	private void A(TreeNode P_0, Cn P_1)
	{
		if (!(P_0.Tag is MenuNode menuNode) || menuNode.a() == null)
		{
			return;
		}
		SettingOrSpecialObject settingOrSpecialObject = menuNode.a().a(menuNode.b());
		if (settingOrSpecialObject is Table)
		{
			Table table = settingOrSpecialObject as Table;
			if (P_1.a(table.TableDataSetting) != null)
			{
				a(P_0);
			}
		}
	}

	private bool A(MenuNode P_0, List<string> P_1)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		SettingOrSpecialObject settingOrSpecialObject = BM.Qz.a(P_0.H());
		Enumerator<string> enumerator = P_1.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				bool flag2 = P_0.E().ToLower().Contains(current);
				if (!flag2)
				{
					Enumerator<string> enumerator2 = P_0.V().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current.ToLower().Contains(current))
							{
								flag2 = true;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
				}
				if (!flag2 && settingOrSpecialObject != null)
				{
					Enumerator<string> enumerator2 = settingOrSpecialObject.i().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current.ToLower().Contains(current))
							{
								flag2 = true;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
				}
				if (!flag2)
				{
					Enumerator<DataIdAndAttrId> enumerator3 = P_0.j(false).GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							DataIdAndAttrId current2 = enumerator3.Current;
							Setting setting = BM.Qz.A(current2);
							if (setting == null || (setting.U() && setting.am() && setting.ax() == 0))
							{
								continue;
							}
							string text = ((SettingOrSpecialObject)setting).A(bz.aYt);
							if (text == null)
							{
								text = ((SettingOrSpecialObject)setting).B();
							}
							if (text.ToLower().Contains(current))
							{
								flag2 = true;
								break;
							}
							string text2 = ((SettingOrSpecialObject)setting).A(bz.aYT);
							if (text2 == null)
							{
								text2 = ((SettingOrSpecialObject)setting).B();
							}
							if (text2.ToLower().Contains(current))
							{
								flag2 = true;
								break;
							}
							string text3 = ((SettingOrSpecialObject)setting).A(bz.aYu);
							if (text3 != null && text3.ToLower().Contains(current))
							{
								flag2 = true;
								break;
							}
							string text4 = ((SettingOrSpecialObject)setting).A(bz.aYV);
							if (text4 != null && text4.ToLower().Contains(current))
							{
								flag2 = true;
								break;
							}
							string text5 = ((SettingOrSpecialObject)setting).A(bz.aYv);
							if (text5 != null && text5.ToLower().Contains(current))
							{
								flag2 = true;
								break;
							}
							string text6 = ((SettingOrSpecialObject)setting).H();
							if (!string.IsNullOrWhiteSpace(text6) && text6.ToLower().Contains(current))
							{
								flag2 = true;
								break;
							}
							Enumerator<string> enumerator2 = ((SettingOrSpecialObject)setting).i().GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									if (enumerator2.Current.ToLower().Contains(current))
									{
										flag2 = true;
										break;
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator2).Dispose();
							}
							if (flag2)
							{
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator3).Dispose();
					}
				}
				if (!flag2)
				{
					SettingOrSpecialObject settingOrSpecialObject2 = BM.Qz.a(P_0.b());
					bu bu = P_0.B();
					string text7 = P_0.E();
					if (text7.ToLower().Contains(current))
					{
						flag2 = true;
					}
					else
					{
						string text8 = A(text7, P_0, settingOrSpecialObject2, settingOrSpecialObject, bu);
						if (!string.IsNullOrEmpty(text8) && text8.ToLower().Contains(current))
						{
							flag2 = true;
						}
					}
				}
				if (!flag2)
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
		if (!flag && settingOrSpecialObject != null && P_0.C() != null && P_0.C().h() != 0)
		{
			Setting setting2 = BM.Qz.A(P_0.C().h());
			if (setting2 != null && ((SettingOrSpecialObject)setting2).D() != null && !string.IsNullOrWhiteSpace(((SettingOrSpecialObject)setting2).D().H()) && A(P_0.C(), P_1))
			{
				flag = true;
			}
		}
		return flag;
	}

	internal void A(TreeNode P_0, bool P_1, bool P_2 = false)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 == null || !(P_0.Tag is MenuNode))
		{
			Hk = null;
			BM.si = null;
			return;
		}
		Stopwatch val = new Stopwatch();
		val.Start();
		MenuNode menuNode = (MenuNode)P_0.Tag;
		int num = -1;
		int num2 = -1;
		bu bu = menuNode.B();
		if (bu == null)
		{
			num = menuNode.b();
			num2 = menuNode.H();
		}
		Hi = BM.Qz.a(num);
		SettingOrSpecialObject settingOrSpecialObject = BM.Qz.a(num2);
		if (menuNode == BM.qA)
		{
			BM.QQ.rl.A(null, aE.Ht, null, BM.qA, P_1);
		}
		else if (menuNode != BM.qa)
		{
			if (BM.Qz.awr != null && BM.Qz.awr == BM.Qz.awR && menuNode == BM.Qz.awR)
			{
				BM.QQ.rl.A(null, aE.hB, null, menuNode, P_1);
			}
			else if (bu != null)
			{
				BM.QQ.rl.A(null, aE.HU, bu, menuNode, P_1);
			}
			else if (P_0.Parent == null)
			{
				BM.QQ.rl.A(null, aE.Hu, null, menuNode, P_1);
			}
			else if (settingOrSpecialObject != null)
			{
				Hi = settingOrSpecialObject;
				BM.QQ.rl.A(Hi, aE.Hw, null, menuNode, P_1);
			}
			else if (Hi != null)
			{
				CG cG = Hi.e();
				if (cG != null)
				{
					cG.ShowUIControlForSelectedNode(menuNode, P_1);
				}
				else if (Hi.a().Count != 0)
				{
					BM.QQ.rl.A(Hi, aE.HX, null, menuNode, P_1);
				}
			}
			else
			{
				if (menuNode.l())
				{
					if (menuNode == Hk && !BM.sX && !P_2)
					{
						P_1 = false;
					}
					else
					{
						Hk = menuNode;
					}
				}
				if (menuNode.M())
				{
					MenuNode menuNode2 = menuNode.C().C();
					if (menuNode2 == Hk)
					{
						P_1 = BM.sX || BM.To || P_2;
					}
					Hk = menuNode2;
					BM.QQ.rl.A(menuNode2, P_1);
					int num3 = menuNode.N();
					BM.QQ.rl.B(num3);
				}
				else if (menuNode.j())
				{
					BM.QQ.rl.A(menuNode, P_1);
				}
				else
				{
					Enumerator<MenuNode> enumerator = menuNode.c().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.J())
							{
								BM.QQ.rl.A(menuNode, P_1);
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
			}
		}
		B(P_0);
		if (Hi is Setting setting && setting.aF() != null && setting.aF().Length > 2)
		{
			BM.si = setting.aF();
		}
		else if (menuNode.Y() != null && menuNode.Y().BcF != null && menuNode.z() && !string.IsNullOrEmpty(menuNode.Y().BcF.Bca))
		{
			BM.si = menuNode.Y().BcF.Bca;
		}
		else if (string.IsNullOrEmpty(menuNode.U()))
		{
			MenuNode menuNode3 = menuNode;
			while (true)
			{
				MenuNode menuNode4 = menuNode3.C();
				if (menuNode4 == null)
				{
					break;
				}
				string text = menuNode4.U();
				if (!string.IsNullOrEmpty(text))
				{
					BM.si = text;
					break;
				}
				menuNode3 = menuNode4;
			}
		}
		else
		{
			BM.si = menuNode.U();
		}
		if ((BM.sJ != null && ((Control)BM.sJ).Visible) || (BM.QQ.rq != null && ((Control)BM.QQ.rq).Visible))
		{
			BM.QQ.T();
		}
		BM.X(null, null);
		BM.Sl = true;
		if (!menuNode.l() && !menuNode.M())
		{
			Hk = null;
		}
		val.Stop();
		N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FH(), (object)val.ElapsedMilliseconds), false);
	}

	internal string a(TreeNode P_0, bool P_1, bool P_2)
	{
		if (P_0 == null)
		{
			return string.Empty;
		}
		if (P_0.Tag is MenuNode && ((P_0.Tag as MenuNode).B() != null || P_0.Tag as MenuNode == BM.qA))
		{
			return P_0.ToolTipText;
		}
		string text = string.Empty;
		List<TreeNode> val = new List<TreeNode>();
		val.Add(P_0);
		TreeNode val2 = P_0;
		bool flag = false;
		do
		{
			if (val2.Parent != null)
			{
				val.Insert(0, val2.Parent);
				val2 = val2.Parent;
			}
			else
			{
				flag = true;
			}
		}
		while (!flag);
		for (int i = 0; i < val.Count; i++)
		{
			if (i != 0 || P_1)
			{
				TreeNode val3 = val[i];
				if (text != string.Empty)
				{
					text = ((!P_2) ? (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh()) : (text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj()));
				}
				text += val3.ToolTipText;
			}
		}
		return text;
	}

	internal void B(int P_0)
	{
		TreeNode val = A(gW.a(), new DataIdAndAttrId(P_0), false);
		if (gW.B() != val)
		{
			gW.A(val);
		}
	}

	internal void b(int P_0)
	{
		TreeNode val = A(gW.a(), P_0);
		if (val != null && val != gW.B())
		{
			gW.A(val);
		}
		Hj = gW.B();
	}

	internal void C(int P_0)
	{
		bool num = gW.B() == Hj || Hj == null;
		b(P_0);
		if (num)
		{
			A(gW.B(), true, true);
		}
	}

	private TreeNode A(List<TreeNode> P_0, int P_1)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			TreeNode val = P_0[i];
			if (val.Nodes.Count > 0)
			{
				TreeNode val2 = A(val.Nodes, P_1);
				if (val2 != null)
				{
					return val2;
				}
			}
		}
		return null;
	}

	private TreeNode A(TreeNodeCollection P_0, int P_1)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			TreeNode val = P_0[i];
			if (val.Tag is MenuNode && ((MenuNode)val.Tag).l() && ((MenuNode)val.Tag).m() == P_1)
			{
				return val;
			}
			if (val.Nodes.Count > 0)
			{
				TreeNode val2 = A(val.Nodes, P_1);
				if (val2 != null)
				{
					return val2;
				}
			}
		}
		return null;
	}

	internal TreeNode A(List<TreeNode> P_0, MenuNode P_1)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			TreeNode val = P_0[i];
			if (val.Tag is MenuNode && val.Tag as MenuNode == P_1)
			{
				return val;
			}
			if (val.Nodes.Count > 0)
			{
				TreeNode val2 = A(val.Nodes, P_1);
				if (val2 != null)
				{
					return val2;
				}
			}
		}
		return null;
	}

	internal TreeNode A(TreeNodeCollection P_0, MenuNode P_1)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			TreeNode val = P_0[i];
			if (val.Tag is MenuNode && val.Tag as MenuNode == P_1)
			{
				return val;
			}
			if (val.Nodes.Count > 0)
			{
				TreeNode val2 = A(val.Nodes, P_1);
				if (val2 != null)
				{
					return val2;
				}
			}
		}
		return null;
	}

	internal void A(int P_0, int P_1)
	{
		TreeNode val = A(gW.a(), P_0, P_1);
		if (gW.B() != val)
		{
			gW.A(val);
		}
	}

	private TreeNode A(List<TreeNode> P_0, int P_1, int P_2)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			TreeNode val = P_0[i];
			if (val.Nodes.Count > 0)
			{
				TreeNode val2 = A(val.Nodes, P_1, P_2);
				if (val2 != null)
				{
					return val2;
				}
			}
		}
		return null;
	}

	private TreeNode A(TreeNodeCollection P_0, int P_1, int P_2)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			TreeNode val = P_0[i];
			if (val.Parent != null && val.Tag is MenuNode && val.Parent.Tag is MenuNode)
			{
				MenuNode menuNode = (MenuNode)val.Parent.Tag;
				MenuNode menuNode2 = (MenuNode)val.Tag;
				if (menuNode.l() && menuNode.m() == P_1 && menuNode2.M() && menuNode2.N() == P_2)
				{
					return val;
				}
			}
			if (val.Nodes.Count > 0)
			{
				TreeNode val2 = A(val.Nodes, P_1, P_2);
				if (val2 != null)
				{
					return val2;
				}
			}
		}
		return null;
	}

	internal void A(string P_0)
	{
		string[] array = P_0.Split('\\', (StringSplitOptions)0);
		if (gW.a().Count == 0 || array.Length == 0)
		{
			return;
		}
		TreeNode val = null;
		int num = 0;
		bool flag;
		do
		{
			flag = false;
			if (val == null)
			{
				for (int i = 0; i < gW.a().Count; i++)
				{
					if (gW.a()[i].ToolTipText == array[num])
					{
						val = gW.a()[i];
						num++;
						flag = true;
						break;
					}
				}
				continue;
			}
			for (int j = 0; j < val.Nodes.Count; j++)
			{
				if (val.Nodes[j].ToolTipText == array[num])
				{
					val = val.Nodes[j];
					num++;
					flag = true;
					break;
				}
			}
		}
		while (flag && num < array.Length);
		if (flag && num == array.Length)
		{
			gW.A(val);
		}
		else
		{
			gW.A((TreeNode)null);
		}
	}

	internal void A(Setting P_0)
	{
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		Cn cn = null;
		bool flag = false;
		MenuNode menuNode = MenuNode.A(((SettingOrSpecialObject)P_0).A().awj, P_0.C());
		if (menuNode != null)
		{
			MenuNode menuNode2 = menuNode.A(P_0);
			if (menuNode2 != null)
			{
				cn = menuNode2.Y().BcF;
				flag = menuNode2.z();
			}
		}
		if (cn != null && P_0.e() && flag && !string.IsNullOrEmpty(P_0.F()) && !string.IsNullOrEmpty(P_0.f()))
		{
			((Control)HB).Text = P_0.F() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FI();
		}
		else
		{
			((Control)HB).Text = ((SettingOrSpecialObject)P_0).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FI();
		}
		if (P_0.d(0).Count == 0 && P_0.e(0).Count == 0 && !P_0.U())
		{
			int num;
			int num2;
			if (cn != null && P_0.e() && flag)
			{
				num = P_0.aO();
				num2 = P_0.ao();
			}
			else
			{
				num = P_0.aR();
				num2 = P_0.ar();
			}
			if (num != 0 || num2 != 0)
			{
				int num3 = P_0.aS();
				int num4 = P_0.K();
				string text = bS.a(num, num3, num4);
				string text2 = bS.a(num2, num3, num4);
				int num5 = P_0.an();
				if (num5 > 1)
				{
					string text3 = bS.a(num5, num3, num4);
					((TextBoxBase)HB).AppendText(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fi(), (object)text, (object)text2, (object)text3) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FI());
				}
				else
				{
					((TextBoxBase)HB).AppendText(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FJ(), (object)text, (object)text2) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FI());
				}
			}
		}
		((TextBoxBase)HB).Select(0, ((TextBoxBase)HB).TextLength);
		((RichTextBox)HB).SelectionFont = new Font(((RichTextBox)HB).SelectionFont.FontFamily, ((RichTextBox)HB).SelectionFont.Size, (FontStyle)1);
		((RichTextBox)HB).SelectionColor = BM.te;
		((TextBoxBase)HB).SelectionLength = 0;
		int textLength = ((TextBoxBase)HB).TextLength;
		if (cn != null && P_0.e() && flag && !string.IsNullOrEmpty(P_0.F()) && !string.IsNullOrEmpty(P_0.f()))
		{
			string text4 = P_0.f();
			((TextBoxBase)HB).AppendText(text4);
		}
		else
		{
			string text5 = ((SettingOrSpecialObject)P_0).A(bz.aYU);
			if (text5 != null)
			{
				((TextBoxBase)HB).AppendText(text5);
			}
			else
			{
				string text6 = ((SettingOrSpecialObject)P_0).A(bz.aYt);
				if (text6 != null)
				{
					((TextBoxBase)HB).AppendText(text6);
				}
				else
				{
					string text7 = ((SettingOrSpecialObject)P_0).A(bz.aYT);
					if (text7 != null)
					{
						((TextBoxBase)HB).AppendText(text7);
					}
					else
					{
						((TextBoxBase)HB).AppendText(((SettingOrSpecialObject)P_0).B());
					}
				}
			}
		}
		int num6 = ((TextBoxBase)HB).TextLength - textLength;
		((TextBoxBase)HB).Select(textLength, num6);
		((RichTextBox)HB).SelectionColor = BM.te;
		((TextBoxBase)HB).SelectionLength = 0;
		HB.A();
	}

	private void B(TreeNode P_0)
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		((Control)HB).Text = a(P_0, false, false) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FI();
		if (Hi is Table)
		{
			Table table = Hi as Table;
			int num = table.aR();
			int num2 = table.ar();
			if (num != 0 || num2 != 0)
			{
				int num3 = table.TableDataSetting.aS();
				string text = bS.a(num, num3, -1);
				string text2 = bS.a(num2, num3, -1);
				((TextBoxBase)HB).AppendText(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FJ(), (object)text, (object)text2) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FI());
			}
		}
		((TextBoxBase)HB).Select(0, ((TextBoxBase)HB).TextLength);
		((RichTextBox)HB).SelectionFont = new Font(((RichTextBox)HB).SelectionFont.FontFamily, ((RichTextBox)HB).SelectionFont.Size, (FontStyle)1);
		((RichTextBox)HB).SelectionColor = BM.te;
		((TextBoxBase)HB).SelectionLength = 0;
		int textLength = ((TextBoxBase)HB).TextLength;
		if (Hi != null)
		{
			string text3 = Hi.A(bz.aYU);
			if (text3 != null)
			{
				((TextBoxBase)HB).AppendText(text3);
			}
			else
			{
				string text4 = Hi.A(bz.aYt);
				if (text4 != null)
				{
					((TextBoxBase)HB).AppendText(text4);
				}
				else
				{
					string text5 = Hi.A(bz.aYT);
					if (text5 != null)
					{
						((TextBoxBase)HB).AppendText(text5);
					}
					else
					{
						((TextBoxBase)HB).AppendText(Hi.B());
					}
				}
			}
		}
		int num4 = ((TextBoxBase)HB).TextLength - textLength;
		((TextBoxBase)HB).Select(textLength, num4);
		((RichTextBox)HB).SelectionColor = BM.te;
		((TextBoxBase)HB).SelectionLength = 0;
		HB.A();
	}

	private void E()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		((Control)HB).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fj();
		((TextBoxBase)HB).Select(0, ((TextBoxBase)HB).TextLength);
		((RichTextBox)HB).SelectionFont = new Font(((RichTextBox)HB).SelectionFont.FontFamily, ((RichTextBox)HB).SelectionFont.Size, (FontStyle)1);
		((RichTextBox)HB).SelectionColor = BM.te;
		((TextBoxBase)HB).SelectionLength = 0;
		int textLength = ((TextBoxBase)HB).TextLength;
		((TextBoxBase)HB).AppendText(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FK());
		int num = ((TextBoxBase)HB).TextLength - textLength;
		((TextBoxBase)HB).Select(textLength, num);
		((RichTextBox)HB).SelectionColor = BM.te;
		((TextBoxBase)HB).SelectionLength = 0;
		HB.A();
	}

	internal TreeNode A(TreeNodeCollection P_0, DataIdAndAttrId P_1, bool P_2)
	{
		return A(P_0, P_1, true, P_2, false);
	}

	internal TreeNode A(List<TreeNode> P_0, DataIdAndAttrId P_1, bool P_2)
	{
		return A(P_0, P_1, true, P_2, false);
	}

	internal TreeNode A(TreeNodeCollection P_0, DataIdAndAttrId P_1, bool P_2, bool P_3, bool P_4)
	{
		if (P_2 && BM.Qz.aWZ.Contains(P_1.DataId))
		{
			Setting setting = BM.Qz.A(P_1.DataId);
			if (setting != null && setting.t() != null)
			{
				TreeNode val = A(P_0, setting.t());
				if (val != null)
				{
					return val;
				}
			}
		}
		for (int i = 0; i < P_0.Count; i++)
		{
			TreeNode val2 = P_0[i];
			bool flag = val2.Tag is MenuNode && (val2.Tag as MenuNode == BM.qa || b(val2));
			if (P_4 == flag)
			{
				if (val2.Tag is MenuNode && ((MenuNode)val2.Tag).j(P_3).Contains(P_1))
				{
					return val2;
				}
				TreeNode val3 = A(val2.Nodes, P_1, false, P_3, P_4);
				if (val3 != null)
				{
					return val3;
				}
			}
		}
		return null;
	}

	internal TreeNode A(List<TreeNode> P_0, DataIdAndAttrId P_1, bool P_2, bool P_3, bool P_4)
	{
		if (P_2 && BM.Qz.aWZ.Contains(P_1.DataId))
		{
			Setting setting = BM.Qz.A(P_1.DataId);
			if (setting != null && setting.t() != null)
			{
				TreeNode val = A(P_0, setting.t());
				if (val != null)
				{
					return val;
				}
			}
		}
		for (int i = 0; i < P_0.Count; i++)
		{
			TreeNode val2 = P_0[i];
			bool flag = val2.Tag is MenuNode && (val2.Tag as MenuNode == BM.qa || b(val2));
			if (P_4 == flag)
			{
				if (val2.Tag is MenuNode && ((MenuNode)val2.Tag).j(P_3).Contains(P_1))
				{
					return val2;
				}
				TreeNode val3 = A(val2.Nodes, P_1, false, P_3, P_4);
				if (val3 != null)
				{
					return val3;
				}
			}
		}
		return null;
	}

	private bool b(TreeNode P_0)
	{
		if (P_0.Parent == null)
		{
			return false;
		}
		TreeNode val = P_0;
		bool flag = false;
		do
		{
			if (val.Parent != null)
			{
				val = val.Parent;
			}
			else
			{
				flag = true;
			}
		}
		while (!flag);
		if (val != null && val.Tag is MenuNode)
		{
			return val.Tag as MenuNode == BM.qa;
		}
		return false;
	}

	[SpecialName]
	internal SettingOrSpecialObject e()
	{
		return Hi;
	}

	internal void C(bool P_0)
	{
		if (BM.Qz != null)
		{
			if (!Hl)
			{
				G();
			}
			F();
			BM.QQ.rl.A(null, aE.HV, null, null, P_0);
			E();
			BM.X(null, null);
			BM.Sl = true;
			BM.qe = true;
			if (!Hl)
			{
				gz.Clear();
			}
			f();
			HM = true;
			gW.A((TreeNode)null);
			Hl = false;
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		C(true);
	}

	private void A(object P_0, TreeViewCancelEventArgs P_1)
	{
		if (!Hl && !HM)
		{
			G();
		}
		F();
	}

	private void A(object P_0, TreeViewEventArgs P_1)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		if (P_1.Node != null && P_1.Node.Tag is MenuNode && (P_1.Node.Tag as MenuNode).M() && (int)P_1.Action == 2)
		{
			a(P_0, P_1);
		}
	}

	private void a(object P_0, TreeViewEventArgs P_1)
	{
		HH = true;
		A(P_1.Node, true);
		HH = false;
		if (!((Control)gu).Focused)
		{
			BM.qe = true;
		}
		if (!Hl && !HM)
		{
			gz.Clear();
		}
		Hl = false;
		HM = false;
		f();
	}

	private void F()
	{
		TreeNode val = null;
		if (gZ.Count != 0)
		{
			val = gZ.Peek();
		}
		if (val == null)
		{
			((Control)gx).Enabled = false;
		}
		else
		{
			((Control)gx).Enabled = true;
		}
		((Control)gX).Enabled = ((Control)gx).Enabled;
	}

	private void f()
	{
		TreeNode val = null;
		if (gz.Count != 0)
		{
			val = gz.Peek();
		}
		if (val == null)
		{
			((Control)gY).Enabled = false;
		}
		else
		{
			((Control)gY).Enabled = true;
		}
		((Control)gy).Enabled = ((Control)gY).Enabled;
	}

	private void G()
	{
		if (BM.QQ.rl.i() != null)
		{
			TreeNode val = (TreeNode)(object)new aw();
			gZ.Push(val);
		}
		else if (gW.B() != null && gW.B().Tag is MenuNode menuNode && (menuNode.b() != -1 || menuNode.H() != -1 || (menuNode.c().Count != 0 && gW.B().Nodes.Count == 0) || menuNode.B() != null || menuNode == BM.qA) && (gZ.Count == 0 || gZ.Peek() != gW.B()))
		{
			gZ.Push(gW.B());
		}
	}

	private void g()
	{
		if (BM.QQ.rl.i() != null)
		{
			TreeNode val = (TreeNode)(object)new aw();
			gz.Push(val);
		}
		else if (gW.B() != null && (gz.Count == 0 || gz.Peek() != gW.B()))
		{
			gz.Push(gW.B());
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		Hl = true;
		g();
		TreeNode val = gZ.Pop();
		if (val.Tag != null)
		{
			gW.A(val);
		}
		else
		{
			C(true);
		}
		F();
		f();
	}

	private void B(object P_0, EventArgs P_1)
	{
		Hl = true;
		G();
		TreeNode val = gz.Pop();
		if (val.Tag != null)
		{
			gW.A(val);
		}
		else
		{
			C(true);
		}
		F();
		f();
	}

	private void b(object P_0, EventArgs P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		((ToolStrip)HA).BackColor = BM.tG;
		((ToolStrip)HA).ForeColor = BM.te;
		((ToolStrip)HA).Items.Clear();
		int num = 0;
		Enumerator<TreeNode> enumerator = gZ.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				TreeNode current = enumerator.Current;
				ToolStripMenuItem val = new ToolStripMenuItem();
				if (current.Tag == null)
				{
					((ToolStripItem)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fk();
				}
				else
				{
					((ToolStripItem)val).Text = a(current, false, false);
				}
				((ToolStripItem)val).Tag = num;
				((ToolStripItem)val).Click += new EventHandler(c);
				((ToolStrip)HA).Items.Insert(0, (ToolStripItem)(object)val);
				num++;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		Point val2 = default(Point);
		((Point)(ref val2))._002Ector(0, 0);
		((ToolStripDropDown)HA).Show((Control)(object)gX, val2, (ToolStripDropDownDirection)1);
	}

	private void C(object P_0, EventArgs P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		((ToolStrip)Ha).BackColor = BM.tG;
		((ToolStrip)Ha).ForeColor = BM.te;
		((ToolStrip)Ha).Items.Clear();
		int num = 0;
		Enumerator<TreeNode> enumerator = gz.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				TreeNode current = enumerator.Current;
				ToolStripMenuItem val = new ToolStripMenuItem();
				if (current.Tag == null)
				{
					((ToolStripItem)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fk();
				}
				else
				{
					((ToolStripItem)val).Text = a(current, false, false);
				}
				((ToolStripItem)val).Tag = num;
				((ToolStripItem)val).Click += new EventHandler(D);
				((ToolStrip)Ha).Items.Add((ToolStripItem)(object)val);
				num++;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		Point val2 = default(Point);
		((Point)(ref val2))._002Ector(0, 0);
		((ToolStripDropDown)Ha).Show((Control)(object)gy, val2, (ToolStripDropDownDirection)1);
	}

	private void c(object P_0, EventArgs P_1)
	{
		int num = (int)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		for (int i = 0; i < num; i++)
		{
			gz.Push(gZ.Pop());
		}
		a((object)null, (EventArgs)null);
	}

	private void D(object P_0, EventArgs P_1)
	{
		int num = (int)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		for (int i = 0; i < num; i++)
		{
			gZ.Push(gz.Pop());
		}
		B((object)null, (EventArgs)null);
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)P_1.Button == 1048576)
		{
			HF = P_1.X;
			Hf = P_1.Y;
			HG = ((Control)this).Width;
			Hg = ((Control)HB).Height;
			if (HF >= ((Control)this).Width - 5)
			{
				HE = true;
			}
			else if (Hf >= ((Control)gW).Bottom - 2 && Hf <= ((Control)gW).Bottom + 2)
			{
				He = true;
			}
			else if (Hf >= ((Control)HB).Top - 4 && Hf <= ((Control)HB).Top)
			{
				He = true;
			}
		}
	}

	private void a(object P_0, MouseEventArgs P_1)
	{
		HE = false;
		He = false;
		BM.X();
	}

	private void B(object P_0, MouseEventArgs P_1)
	{
		int num = P_1.X - HF;
		int num2 = P_1.Y - Hf;
		if (HE)
		{
			((Control)this).Width = Math.Max(HG + num, 160);
			BM.X();
			((Control)this).Invalidate();
		}
		else if (He)
		{
			((Control)HB).Height = Math.Max(Hg - num2, 1);
			d();
			((Control)this).Invalidate();
		}
		a(P_1.X, P_1.Y);
	}

	private void d(object P_0, EventArgs P_1)
	{
		((Control)this).Cursor = Cursors.Default;
	}

	private void a(int P_0, int P_1)
	{
		if (P_0 >= ((Control)this).Width - 5)
		{
			((Control)this).Cursor = Cursors.SizeWE;
		}
		else if (P_1 >= ((Control)gW).Bottom - 2 && P_1 <= ((Control)gW).Bottom + 2)
		{
			((Control)this).Cursor = Cursors.SizeNS;
		}
		else if (P_1 >= ((Control)HB).Top - 4 && P_1 <= ((Control)HB).Top)
		{
			((Control)this).Cursor = Cursors.SizeNS;
		}
		else
		{
			((Control)this).Cursor = Cursors.Default;
		}
	}

	private void b(object P_0, MouseEventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected O, but got Unknown
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected O, but got Unknown
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected O, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected O, but got Unknown
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected O, but got Unknown
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected O, but got Unknown
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected O, but got Unknown
		if ((int)P_1.Button != 2097152)
		{
			return;
		}
		int x = P_1.X;
		int y = P_1.Y;
		Rectangle val;
		TreeNode val2 = gW.A(x, y, out val);
		if (val2 != null)
		{
			if (!(val2.Tag is MenuNode))
			{
				return;
			}
			MenuNode menuNode = val2.Tag as MenuNode;
			SettingOrSpecialObject settingOrSpecialObject = BM.Qz.a(menuNode.b());
			Setting setting = null;
			if (BM.Qz.C() && menuNode.h() != 0)
			{
				setting = BM.Qz.A(menuNode.h());
				if (setting != null && ((SettingOrSpecialObject)setting).A().B() && ((SettingOrSpecialObject)setting).A().b() && setting.J())
				{
					setting = null;
				}
			}
			bool flag = false;
			if (BM.Qz.awZ == 21 && BM.Qz.awR != null)
			{
				flag = menuNode == BM.Qz.awR;
			}
			bool flag2 = false;
			if (BM.Qz.awZ == 21 && BM.Qz.awS != null)
			{
				flag2 = menuNode == BM.Qz.awS;
			}
			HashSet<DataIdAndAttrId> val3 = MenuNode.A(menuNode, true);
			bool flag3;
			if (BM.Qz.C() && val3.Count != 0)
			{
				flag3 = true;
				if (BM.Qz.B() && BM.Qz.b())
				{
					Enumerator<DataIdAndAttrId> enumerator = val3.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							DataIdAndAttrId current = enumerator.Current;
							Setting setting2 = BM.Qz.A(current);
							if (setting2 != null && setting2.J())
							{
								flag3 = false;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
			}
			else
			{
				flag3 = false;
			}
			if (flag3)
			{
				Enumerator<DataIdAndAttrId> enumerator = menuNode.j(false).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataIdAndAttrId current2 = enumerator.Current;
						Setting setting3 = BM.Qz.A(current2);
						if (setting3 != null && setting3.aA())
						{
							flag3 = false;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			bool flag4 = settingOrSpecialObject is Table || menuNode.s() != -1;
			if (!(flag3 || flag4 || setting != null || flag || menuNode.l() || flag2) && !menuNode.o() && !menuNode.M())
			{
				return;
			}
			ContextMenuStrip val4 = new ContextMenuStrip();
			((ToolStrip)val4).BackColor = BM.tG;
			((ToolStrip)val4).ForeColor = BM.te;
			if (flag)
			{
				ToolStripMenuItem val5 = new ToolStripMenuItem();
				((ToolStripItem)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FL();
				((ToolStripItem)val5).Click += new EventHandler(e);
				((ToolStrip)val4).Items.Add((ToolStripItem)(object)val5);
			}
			else if (menuNode.l())
			{
				ToolStripMenuItem val6 = new ToolStripMenuItem();
				((ToolStripItem)val6).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fl();
				((ToolStripItem)val6).Tag = menuNode.m();
				((ToolStripItem)val6).Click += new EventHandler(F);
				((ToolStrip)val4).Items.Add((ToolStripItem)(object)val6);
				ToolStripMenuItem val7 = new ToolStripMenuItem();
				((ToolStripItem)val7).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FM();
				((ToolStripItem)val7).Tag = menuNode.m();
				((ToolStripItem)val7).Click += new EventHandler(f);
				((ToolStrip)val4).Items.Add((ToolStripItem)(object)val7);
			}
			else if (menuNode.M())
			{
				if (menuNode.C() != null)
				{
					MenuNode menuNode2 = menuNode.C().C();
					if (menuNode2 != null)
					{
						ToolStripMenuItem val8 = new ToolStripMenuItem();
						((ToolStripItem)val8).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dt();
						((ToolStripItem)val8).Tag = menuNode2;
						((ToolStripItem)val8).Click += new EventHandler(G);
						((ToolStrip)val4).Items.Add((ToolStripItem)(object)val8);
						ToolStripMenuItem val9 = new ToolStripMenuItem();
						((ToolStripItem)val9).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Dr();
						((ToolStripItem)val9).Tag = menuNode2;
						((ToolStripItem)val9).Click += new EventHandler(g);
						((ToolStrip)val4).Items.Add((ToolStripItem)(object)val9);
					}
				}
			}
			else if (flag2)
			{
				ToolStripMenuItem val10 = new ToolStripMenuItem();
				((ToolStripItem)val10).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fm();
				((ToolStripItem)val10).Click += new EventHandler(H);
				((ToolStrip)val4).Items.Add((ToolStripItem)(object)val10);
			}
			else if (menuNode.o())
			{
				ToolStripMenuItem val11 = new ToolStripMenuItem();
				((ToolStripItem)val11).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FN();
				((ToolStripItem)val11).Tag = menuNode.P();
				((ToolStripItem)val11).Click += new EventHandler(h);
				((ToolStrip)val4).Items.Add((ToolStripItem)(object)val11);
				ToolStripMenuItem val12 = new ToolStripMenuItem();
				((ToolStripItem)val12).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fn();
				((ToolStripItem)val12).Tag = menuNode.P();
				((ToolStripItem)val12).Click += new EventHandler(I);
				((ToolStrip)val4).Items.Add((ToolStripItem)(object)val12);
			}
			if (BM.Qz.C())
			{
				if (setting != null)
				{
					if ((setting.A() != 10195) ? (setting.ax() == 1) : ((byte)setting.ax() != 0))
					{
						ToolStripMenuItem val13 = new ToolStripMenuItem();
						((ToolStripItem)val13).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FO() + menuNode.E();
						((ToolStripItem)val13).Tag = menuNode;
						((ToolStripItem)val13).Click += new EventHandler(K);
						((ToolStrip)val4).Items.Add((ToolStripItem)(object)val13);
					}
					else
					{
						ToolStripMenuItem val14 = new ToolStripMenuItem();
						((ToolStripItem)val14).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fo() + menuNode.E();
						((ToolStripItem)val14).Tag = menuNode;
						((ToolStripItem)val14).Click += new EventHandler(k);
						((ToolStrip)val4).Items.Add((ToolStripItem)(object)val14);
					}
				}
				if (flag3)
				{
					ToolStripMenuItem val15 = new ToolStripMenuItem();
					((ToolStripItem)val15).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FP();
					((ToolStripItem)val15).Tag = menuNode;
					((ToolStripItem)val15).Click += new EventHandler(j);
					((ToolStrip)val4).Items.Add((ToolStripItem)(object)val15);
				}
			}
			if (flag4)
			{
				int num = -1;
				if (BM.Qz.awA)
				{
					num = menuNode.s();
				}
				else if (settingOrSpecialObject is Table)
				{
					num = ((Setting)(settingOrSpecialObject as Table)).A();
				}
				if (num != -1)
				{
					if (!HI.Contains(num))
					{
						ToolStripMenuItem val16 = new ToolStripMenuItem();
						((ToolStripItem)val16).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fp();
						((ToolStripItem)val16).Tag = num;
						((ToolStripItem)val16).Click += new EventHandler(i);
						((ToolStrip)val4).Items.Add((ToolStripItem)(object)val16);
					}
					else
					{
						ToolStripMenuItem val17 = new ToolStripMenuItem();
						((ToolStripItem)val17).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FQ();
						((ToolStripItem)val17).Tag = num;
						((ToolStripItem)val17).Click += new EventHandler(J);
						((ToolStrip)val4).Items.Add((ToolStripItem)(object)val17);
					}
				}
			}
			((ToolStripDropDown)val4).Show((Control)(object)gW, new Point(x, y));
		}
		else
		{
			ContextMenuStrip val18 = new ContextMenuStrip
			{
				BackColor = BM.tG,
				ForeColor = BM.te
			};
			ToolStripMenuItem val19 = new ToolStripMenuItem();
			((ToolStripItem)val19).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fq();
			((ToolStripItem)val19).Click += new EventHandler(E);
			((ToolStrip)val18).Items.Add((ToolStripItem)(object)val19);
			((ToolStripDropDown)val18).Show((Control)(object)gW, new Point(x, y));
		}
	}

	private void E(object P_0, EventArgs P_1)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		BM.QQ.w();
		bf bf = new bf();
		((Form)bf).ShowDialog((IWin32Window)(object)BM.QQ);
		((Component)bf).Dispose();
	}

	private void e(object P_0, EventArgs P_1)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		int num = BM.Qz.awP.a().ax();
		if (num < BM.Qz.awP.E().Count)
		{
			if (BM.Qz.awP.A(num))
			{
				cI.A(BM.Qz, num);
			}
		}
		else
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FR() + BM.Qz.awP.E().Count, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void F(object P_0, EventArgs P_1)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (BM.Qz.awP.a().ax() < BM.Qz.awP.E().Count)
		{
			int num = (int)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
			BM.Qz.awP.B(num);
		}
		else
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FR() + BM.Qz.awP.E().Count, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void f(object P_0, EventArgs P_1)
	{
		int num = (int)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		TreeNode val = A(gW.a(), BM.Qz.awR);
		if (val != null)
		{
			gW.A(val);
		}
		BM.Qz.awP.a(num);
	}

	private void G(object P_0, EventArgs P_1)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		int num = ((MenuNode)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag).m();
		DK dK = BM.Qz.awP.E()[num];
		if (dK.B() < dK.a().Count)
		{
			BM.Qz.awP.F();
		}
		else
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fr() + dK.a().Count, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void g(object P_0, EventArgs P_1)
	{
		MenuNode menuNode = (MenuNode)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		TreeNode val = A(gW.a(), menuNode);
		if (val != null)
		{
			gW.A(val);
		}
		BM.Qz.awP.e();
	}

	private void H(object P_0, EventArgs P_1)
	{
		BM.Qz.awp.b();
	}

	private void h(object P_0, EventArgs P_1)
	{
		int num = (int)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		BM.Qz.awp.a(num);
	}

	private void I(object P_0, EventArgs P_1)
	{
		int num = (int)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		BM.Qz.awp.A(num);
	}

	internal void B(int P_0, int P_1)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		List<int> val = new List<int>(HI.Count);
		Enumerator<int> enumerator = HI.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current = enumerator.Current;
				if (current != P_0)
				{
					val.Add(current);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (P_1 < val.Count)
		{
			val.Insert(P_1, P_0);
		}
		else
		{
			val.Add(P_0);
		}
		for (int num = HI.Count - 1; num >= 0; num--)
		{
			int num2 = HI[num];
			HI.Remove(num2);
			D(num2);
		}
		enumerator = val.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current2 = enumerator.Current;
				HI.Add(current2);
				c(current2);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		A(true, true, false, false);
		B(false);
		if (BM.Qn != null)
		{
			b(false);
		}
	}

	private void c(int P_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		Enumerator<Table> enumerator = BM.Qz.aWV.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				if (((Setting)enumerator.Current).A() == P_0)
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
		if (!Directory.Exists(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
		{
			Directory.CreateDirectory(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
		}
		List<string> val = new List<string>();
		if (flag)
		{
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fs() + P_0);
		}
		if (BM.Qz.awA)
		{
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FT() + P_0);
		}
		File.AppendAllLines(gT, (System.Collections.Generic.IEnumerable<string>)val);
	}

	private void D(int P_0)
	{
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		if (!Directory.Exists(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
		{
			Directory.CreateDirectory(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
		}
		if (!File.Exists(gT))
		{
			return;
		}
		List<int> val = new List<int>();
		List<int> val2 = new List<int>();
		StreamReader val3 = File.OpenText(gT);
		try
		{
			string text;
			while ((text = ((TextReader)val3).ReadLine()) != null)
			{
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FT()))
				{
					int num = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FT().Length));
					if (num != P_0 && !val.Contains(num))
					{
						val.Add(num);
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fs()))
				{
					int num2 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fs().Length));
					if (num2 != P_0 && !val2.Contains(num2))
					{
						val2.Add(num2);
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)val3)?.Dispose();
		}
		File.Delete(gT);
		((Stream)File.Create(gT)).Close();
		List<string> val4 = new List<string>();
		Enumerator<int> enumerator = val.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current = enumerator.Current;
				val4.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FT() + current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int current2 = enumerator.Current;
				val4.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fs() + current2);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		File.AppendAllLines(gT, (System.Collections.Generic.IEnumerable<string>)val4);
	}

	private void i(object P_0, EventArgs P_1)
	{
		int num = (int)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		HI.Add(num);
		c(num);
		A(false, true, false, false);
		B(false);
		if (BM.Qn != null)
		{
			b(false);
		}
	}

	private void J(object P_0, EventArgs P_1)
	{
		int num = (int)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		HI.Remove(num);
		D(num);
		A(false, true, false, false);
		B(false);
		if (BM.Qn != null)
		{
			b(false);
		}
	}

	private void H()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<MenuNode> enumerator = BM.Qz.awL.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				MenuNode current = enumerator.Current;
				if (BM.Qz.awA)
				{
					if (current.s() != -1)
					{
						HI.Add(current.s());
						c(current.s());
					}
					continue;
				}
				SettingOrSpecialObject settingOrSpecialObject = BM.Qz.a(current.b());
				if (settingOrSpecialObject is Table)
				{
					int num = ((Setting)(settingOrSpecialObject as Table)).A();
					HI.Add(num);
					c(num);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void h()
	{
		StreamReader val = File.OpenText(gT);
		try
		{
			string text;
			while ((text = ((TextReader)val).ReadLine()) != null)
			{
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fs()))
				{
					int num = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fs().Length));
					if (!HI.Contains(num))
					{
						HI.Add(num);
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FT()) && BM.Qz.awA)
				{
					int num2 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FT().Length));
					if (!HI.Contains(num2))
					{
						HI.Add(num2);
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	private void j(object P_0, EventArgs P_1)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		MenuNode menuNode = ((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag as MenuNode;
		bool flag = false;
		if (Bw.A())
		{
			flag = true;
		}
		else
		{
			Bw bw = new Bw(menuNode);
			if ((int)((Form)bw).ShowDialog((IWin32Window)(object)this) == 1)
			{
				flag = true;
			}
			((Component)bw).Dispose();
		}
		if (flag)
		{
			Ck ck = BM.aM();
			ck?.a();
			BM.Qz.C(BM.Qz.aWS);
			BM.Qz.M();
			a(menuNode, false);
			BM.QQ.aa();
			a(menuNode, true);
			BM.Qz.A(true);
			BM.Qz.c(BM.Qz.aWS);
			ck?.B();
		}
	}

	private void a(MenuNode P_0, bool P_1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<DataIdAndAttrId> enumerator = MenuNode.A(P_0, true).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				Setting setting = BM.Qz.A(current);
				if (setting != null)
				{
					bool flag = PortFunction.a(((SettingOrSpecialObject)setting).D());
					if (((!P_1 && !flag) || (P_1 && flag)) && setting.I(true))
					{
						BM.A(current);
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void K(object P_0, EventArgs P_1)
	{
		MenuNode menuNode = ((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag as MenuNode;
		Setting setting = BM.Qz.A(menuNode.h());
		if (menuNode.h() != 0 && setting != null)
		{
			MenuNode menuNode2 = menuNode;
			menuNode2?.A().A(setting.A());
			setting.a(0, true);
			menuNode2?.A().B();
			BM.b(setting.A());
		}
	}

	private void k(object P_0, EventArgs P_1)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
		MenuNode menuNode = ((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag as MenuNode;
		Setting setting = BM.Qz.A(menuNode.h());
		if (menuNode.h() == 0 || setting == null)
		{
			return;
		}
		Setting setting2 = null;
		MenuNode menuNode2 = null;
		string text = ((SettingOrSpecialObject)setting).P();
		if (text == null)
		{
			menuNode2 = menuNode;
			if (menuNode2 != null)
			{
				text = menuNode2.t();
			}
		}
		else
		{
			setting2 = setting;
		}
		MenuNode menuNode3 = menuNode;
		bool flag = true;
		if (text != null && !Bg.A(setting2, menuNode2))
		{
			Bg bg = new Bg(text, setting2, menuNode2);
			if ((int)((Form)bg).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				menuNode3?.A().A(setting.A());
				if (setting.A() == 10195 && setting.d(0).Count == 3)
				{
					setting.a(2, true);
				}
				else
				{
					setting.a(1, true);
				}
			}
			else
			{
				flag = false;
			}
			((Component)bg).Dispose();
		}
		else
		{
			menuNode3?.A().A(setting.A());
			if (setting.A() == 10195 && setting.d(0).Count == 3)
			{
				setting.a(2, true);
			}
			else
			{
				setting.a(1, true);
			}
		}
		if (flag)
		{
			SettingOrSpecialObject settingOrSpecialObject = null;
			if (((SettingOrSpecialObject)setting).D() != null && ((SettingOrSpecialObject)setting).D() is SpecialObject && BM.Qz.aWY.Contains(((SettingOrSpecialObject)setting).D()))
			{
				settingOrSpecialObject = ((SettingOrSpecialObject)setting).D();
				if (settingOrSpecialObject != null)
				{
					PortFunction.A(settingOrSpecialObject, false);
				}
			}
			menuNode3?.A().B();
		}
		BM.b(setting.A());
	}

	private void L(object P_0, EventArgs P_1)
	{
		((Control)gu).Text = string.Empty;
	}

	private void l(object P_0, EventArgs P_1)
	{
		gv.Stop();
		gv.Start();
	}

	private void A(object P_0, ThemedTextBox.B P_1)
	{
		gv.Stop();
		gv.Start();
	}

	private void M(object P_0, EventArgs P_1)
	{
		gv.Stop();
		bool flag = ((Control)gu).Text == string.Empty;
		A(true, false, true, flag);
		B(false);
		if (BM.Qn != null)
		{
			b(false);
		}
		if (flag)
		{
			BM.qe = false;
			((Control)gu).Focus();
		}
	}
}
