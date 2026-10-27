using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Timers;
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
	internal class cQ : MovableResizablePanel
	{
		private new delegate void A(object P_0, EventArgs P_1);

		private Framework BLg;

		private Rectangle BLH = Rectangle.Empty;

		private const int BLh = 40;

		private const int BLI = 10;

		private const int BLi = 20;

		private const int BLJ = 20;

		private const int BLj = 250;

		private const int BLK = 100;

		private bool BLk = true;

		private double BLL = 1.0;

		private bool BLl;

		private aB BLM;

		private DJ BLm;

		private PictureBox BLN;

		private Timer BLn = new Timer();

		internal cQ(Framework P_0, Rectangle P_1, bool P_2, SettingOrSpecialObject P_3, bool P_4 = false)
			: base(P_1, P_2, false, false)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected O, but got Unknown
			BLg = P_0;
			BLH = P_1;
			if (BLH != Rectangle.Empty)
			{
				((Control)this).Width = ((Rectangle)(ref BLH)).Width;
				((Control)this).Height = ((Rectangle)(ref BLH)).Height;
				((Control)this).Left = ((Rectangle)(ref BLH)).Left;
				((Control)this).Top = ((Rectangle)(ref BLH)).Top;
			}
			BLl = P_4;
			if (!P_4 && P_3 is DJ)
			{
				BLm = P_3 as DJ;
				if (BLm.C() != null)
				{
					BLm.C().A(new EventHandler(B));
				}
				int count = BLg.awq.Count;
				int num = 0;
				if (BLm != null && BLm.C() != null)
				{
					num = BLm.C().ax();
				}
				BLM = new aB(count, BLm.B().ax(), BLm.b().ax(), num);
				b();
				B();
				((Control)this).Refresh();
				return;
			}
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBy());
		}

		private new void B()
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			BLn.Interval = 250.0;
			BLn.SynchronizingObject = (ISynchronizeInvoke)(object)this;
			BLn.Elapsed += new ElapsedEventHandler(A);
			BLn.AutoReset = true;
			BLn.Enabled = true;
			BLn.Start();
		}

		private void A(object P_0, ElapsedEventArgs P_1)
		{
			BLk = !BLk;
			if (!BLl)
			{
				BLM.A(BLm.b().ax() == 1);
				for (int i = 0; i < BLM.A(); i++)
				{
					BLM.A(i, BLm.B().ax());
				}
			}
			((Control)this).Refresh();
		}

		internal void A(double P_0)
		{
			if (BLL != P_0)
			{
				BLL = P_0;
				b();
			}
		}

		private new void b()
		{
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			while (((ArrangedElementCollection)((Control)this).Controls).Count != 0)
			{
				q.A(((Control)this).Controls[0]);
			}
			((Control)this).Width = (int)Math.Round((double)(20 + BLg.awq.Count * 60 + 20 - 20) * BLL) + 2;
			((Control)this).Height = 20;
			for (int i = 0; i < BLg.awq.Count; i++)
			{
				PictureBox val = new PictureBox();
				((Control)val).Width = (int)Math.Round(45.0 * BLL);
				((Control)val).Height = 10;
				((Control)val).Top = 5;
				((Control)val).Left = (int)Math.Round((double)(20 + i * 60) * BLL);
				((Control)this).Controls.Add((Control)(object)val);
				((Control)val).Name = i.ToString();
				((Control)val).Paint += new PaintEventHandler(A);
				if (!BLl)
				{
					((Control)val).MouseUp += new MouseEventHandler(A);
				}
				BLN = val;
			}
			Label val2 = new Label();
			((Control)val2).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBZ();
			((Control)val2).ForeColor = BM.te;
			((Control)val2).AutoSize = true;
			if (BLm != null)
			{
				((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBz();
			}
			else if (BLl)
			{
				((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BbA();
			}
			((Control)val2).Left = BLg.awq.Count * 60 + 20;
			((Control)this).Controls.Add((Control)(object)val2);
			((Control)this).Refresh();
		}

		private void C()
		{
			if (BLm != null && BLm.C() != null)
			{
				Ck ck2 = BM.aM();
				ck2?.a();
				BLm.C().a(BLM.C(), true);
				ck2?.B();
			}
		}

		private void A(object P_0, MouseEventArgs P_1)
		{
			int num = int.Parse(((Control)((P_0 is PictureBox) ? P_0 : null)).Name);
			BLM.A(num, !BLM.b()[num]);
			C();
			((Control)this).Refresh();
		}

		private void B(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					A a = B;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			int count = BLg.awq.Count;
			int num = BLm.C().ax();
			for (int i = 0; i < count; i++)
			{
				BLM.A(i, (num & (1 << i)) > 0);
			}
			((Control)this).Refresh();
		}

		private void A(object P_0, PaintEventArgs P_1)
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected O, but got Unknown
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			int num = int.Parse(((Control)((P_0 is PictureBox) ? P_0 : null)).Name);
			Rectangle val = default(Rectangle);
			((Rectangle)(ref val))._002Ector(0, 0, 40, 10);
			SolidBrush val2 = new SolidBrush((BLM.b()[num] && (!BLM.B() || !BLk)) ? BLM.a()[num] : aa.A(0));
			try
			{
				P_1.Graphics.FillRectangle((Brush)(object)val2, val);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}

		internal void c()
		{
			for (int i = 0; i < BLg.awq.Count; i++)
			{
				BLg.awq[i].a().a(0, false);
			}
		}

		protected override void Dispose(bool disposing)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			if (BLn != null)
			{
				BLn.Elapsed -= new ElapsedEventHandler(A);
				BLn.Stop();
				BLn.Close();
				BLn = null;
			}
			if (BLN != null)
			{
				((Control)BLN).Paint -= new PaintEventHandler(A);
				if (!BLl)
				{
					((Control)BLN).MouseUp -= new MouseEventHandler(A);
				}
			}
			if (BLm != null && BLm.C() != null)
			{
				BLm.C().a(new EventHandler(B));
			}
			base.Dispose(disposing);
		}
	}
	internal class cq : MovableResizablePanel
	{
		[CompilerGenerated]
		private new static class A
		{
			public static EventHandler BWd;
		}

		private aF BlC = new aF();

		private bool Blc;

		private int BlD;

		private int Bld;

		internal cq(Rectangle P_0, bool P_1, bool P_2)
			: base(P_0, P_1, P_2, false)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected O, but got Unknown
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			((Control)this).Resize += new EventHandler(B);
			((Control)BlC).MouseDown += new MouseEventHandler(A);
			((Control)BlC).MouseUp += new MouseEventHandler(B);
			((Control)BlC).MouseMove += new MouseEventHandler(a);
			aF blC = BlC;
			object obj = cq.A.BWd;
			if (obj == null)
			{
				EventHandler val = BM.X;
				cq.A.BWd = val;
				obj = (object)val;
			}
			((Control)blC).Click += (EventHandler)obj;
			((Control)BlC).Click += new EventHandler(b);
			((Panel)BlC).BorderStyle = (BorderStyle)0;
			((Control)BlC).Left = 5;
			((Control)BlC).Top = 5;
			b();
			((Control)this).Controls.Add((Control)(object)BlC);
		}

		[SpecialName]
		internal new aF B()
		{
			return BlC;
		}

		private void B(object P_0, EventArgs P_1)
		{
			b();
		}

		private new void b()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			((Control)BlC).Size = new Size(((Control)this).Width - 10, ((Control)this).Height - 10);
		}

		internal void C()
		{
			BlC.a();
		}

		protected override void Dispose(bool disposing)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			try
			{
				((Control)this).Resize -= new EventHandler(B);
				((Control)BlC).MouseDown -= new MouseEventHandler(A);
				((Control)BlC).MouseUp -= new MouseEventHandler(B);
				((Control)BlC).MouseMove -= new MouseEventHandler(a);
				aF blC = BlC;
				object obj = cq.A.BWd;
				if (obj == null)
				{
					EventHandler val = BM.X;
					cq.A.BWd = val;
					obj = (object)val;
				}
				((Control)blC).Click -= (EventHandler)obj;
				((Control)BlC).Click -= new EventHandler(b);
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		protected override void OnPanelClicked(object sender, EventArgs e)
		{
		}

		private void b(object P_0, EventArgs P_1)
		{
			if (((Control)this).Parent != null && (((Control)this).Parent.Parent == null || !(((Control)this).Parent.Parent is TabPage)))
			{
				if (((Control)this).Parent.Parent != null && (((Control)this).Parent.Parent.Parent == null || !(((Control)this).Parent.Parent.Parent is TabPage)))
				{
					if (((Control)this).Parent.Parent.Parent != null && (((Control)this).Parent.Parent.Parent.Parent == null || !(((Control)this).Parent.Parent.Parent.Parent is TabPage)))
					{
						if (((Control)this).Parent.Parent.Parent is DF)
						{
							((MovableResizablePanel)(((Control)this).Parent.Parent.Parent as DF)).b();
						}
						else if (((Control)this).Parent.Parent.Parent is Df)
						{
							((MovableResizablePanel)(((Control)this).Parent.Parent.Parent as Df)).b();
						}
						else if (((Control)this).Parent.Parent.Parent is aF && ((Control)this).Parent.Parent.Parent.Parent != null && ((Control)this).Parent.Parent.Parent.Parent is cq)
						{
							((MovableResizablePanel)(((Control)this).Parent.Parent.Parent.Parent as cq)).b();
						}
					}
					else if (((Control)this).Parent.Parent is DF)
					{
						((MovableResizablePanel)(((Control)this).Parent.Parent as DF)).b();
					}
					else if (((Control)this).Parent.Parent is Df)
					{
						((MovableResizablePanel)(((Control)this).Parent.Parent as Df)).b();
					}
					else if (((Control)this).Parent.Parent is aF && ((Control)this).Parent.Parent.Parent != null && ((Control)this).Parent.Parent.Parent is cq)
					{
						((MovableResizablePanel)(((Control)this).Parent.Parent.Parent as cq)).b();
					}
				}
				else if (((Control)this).Parent is DF)
				{
					((MovableResizablePanel)(((Control)this).Parent as DF)).b();
				}
				else if (((Control)this).Parent is Df)
				{
					((MovableResizablePanel)(((Control)this).Parent as Df)).b();
				}
				else if (((Control)this).Parent is aF && ((Control)this).Parent.Parent != null && ((Control)this).Parent.Parent is cq)
				{
					((MovableResizablePanel)(((Control)this).Parent.Parent as cq)).b();
				}
			}
			else
			{
				base.b();
			}
		}

		protected override void MouseMoveHandler(object sender, MouseEventArgs e)
		{
			base.MouseMoveHandler(sender, e);
			if (m_isBeingResizedLeft || m_isBeingResizedRight || m_isBeingResizedTop || m_isBeingResizedBottom)
			{
				b();
			}
		}

		private void A(object P_0, MouseEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)P_1.Button == 1048576)
			{
				((Control)this).BringToFront();
				if (m_allowMoveAndResize && !BM.QQ.rl.a((Control)(object)this))
				{
					BlD = P_1.X;
					Bld = P_1.Y;
					Blc = true;
				}
			}
		}

		private void a(object P_0, MouseEventArgs P_1)
		{
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			if (!m_allowMoveAndResize || BM.QQ.rl.a((Control)(object)this) || !Blc)
			{
				return;
			}
			int num = P_1.X - BlD;
			int num2 = P_1.Y - Bld;
			if (num != 0 || num2 != 0)
			{
				GetEdgePositionsOfNearestSiblingControls(((Control)this).Left, ((Control)this).Top, ((Control)this).Right, ((Control)this).Bottom, out var nearestToLeft, out var nearestToTop, out var nearestToRight, out var nearestToBottom);
				bool flag;
				try
				{
					flag = Math.Abs(((Control)this).Left + num - nearestToLeft) <= 10;
				}
				catch
				{
					flag = false;
				}
				bool flag2;
				try
				{
					flag2 = Math.Abs(nearestToRight - (((Control)this).Right + num)) <= 10;
				}
				catch
				{
					flag2 = false;
				}
				bool flag3;
				try
				{
					flag3 = Math.Abs(((Control)this).Top + num2 - nearestToTop) <= 10;
				}
				catch
				{
					flag3 = false;
				}
				bool flag4;
				try
				{
					flag4 = Math.Abs(nearestToBottom - (((Control)this).Bottom + num2)) <= 10;
				}
				catch
				{
					flag4 = false;
				}
				int left = ((Control)this).Left;
				left = (flag ? Math.Max(0, nearestToLeft) : ((!flag2) ? Math.Max(0, ((Control)this).Left + num) : Math.Max(0, nearestToRight - ((Control)this).Width)));
				int top = ((Control)this).Top;
				top = (flag3 ? Math.Max(0, nearestToTop) : ((!flag4) ? Math.Max(0, ((Control)this).Top + num2) : Math.Max(0, nearestToBottom - ((Control)this).Height)));
				if (left != ((Control)this).Left || top != ((Control)this).Top)
				{
					((Control)this).Location = new Point(left, top);
				}
			}
		}

		private void B(object P_0, MouseEventArgs P_1)
		{
			bool blc = Blc;
			Blc = false;
			if (blc)
			{
				BM.QQ.rl.a(false);
			}
		}
	}
}
namespace C
{
	internal class CQ
	{
		[CompilerGenerated]
		private static class A
		{
			public static ProgressChangedEventHandler Bsr;
		}

		[CompilerGenerated]
		private sealed class a
		{
			public FileInfo BsS;

			internal void A()
			{
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEp() + ((FileSystemInfo)BsS).Name + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FC());
			}
		}

		internal string BcL;

		internal bool Bcl;

		internal CQ(string P_0, bool P_1)
		{
			BcL = P_0;
			Bcl = P_1;
		}

		internal void A()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected O, but got Unknown
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			DirectoryInfo val = new DirectoryInfo(BcL);
			if (((FileSystemInfo)val).Exists)
			{
				string text = ((FileSystemInfo)val.Parent).FullName + ((((FileSystemInfo)val.Parent).FullName.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()) || ((FileSystemInfo)val.Parent).FullName.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj())) ? string.Empty : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()) + ((FileSystemInfo)val).Name + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awl();
				if (!Directory.Exists(text))
				{
					try
					{
						Directory.CreateDirectory(text);
					}
					catch
					{
						string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awM();
						if (!BM.qW)
						{
							bE.A((IWin32Window)(object)BM.QQ, text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
							return;
						}
						Console.WriteLine();
						Console.WriteLine(text2);
						Environment.Exit(1);
					}
					BackgroundWorker val2 = new BackgroundWorker();
					if (!BM.qW)
					{
						val2.WorkerReportsProgress = true;
					}
					val2.DoWork += new DoWorkEventHandler(A);
					object obj2 = CQ.A.Bsr;
					if (obj2 == null)
					{
						ProgressChangedEventHandler val3 = BM.a;
						CQ.A.Bsr = val3;
						obj2 = (object)val3;
					}
					val2.ProgressChanged += (ProgressChangedEventHandler)obj2;
					val2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(A);
					val2.RunWorkerAsync((object)text);
				}
				else
				{
					string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awm();
					if (BM.qW)
					{
						Console.WriteLine();
						Console.WriteLine(text3);
						Environment.Exit(1);
					}
					else
					{
						bE.A((IWin32Window)(object)BM.QQ, text3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
			}
			else
			{
				string text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awN();
				if (BM.qW)
				{
					Console.WriteLine();
					Console.WriteLine(text4);
					Environment.Exit(1);
				}
				else
				{
					bE.A((IWin32Window)(object)BM.QQ, text4, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
		}

		private void A(string P_0, string P_1, List<string> P_2, BackgroundWorker P_3)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			DirectoryInfo val = new DirectoryInfo(P_0);
			if (!Directory.Exists(P_1))
			{
				Directory.CreateDirectory(P_1);
			}
			FileInfo[] files = val.GetFiles();
			foreach (FileInfo BsS in files)
			{
				string text = string.Empty;
				try
				{
					if (!BM.qW)
					{
						P_3.ReportProgress(0);
					}
					if (((FileSystemInfo)BsS).FullName.ToLower().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awa()))
					{
						if (!BM.qW)
						{
							((Control)BM.QQ).Invoke((Action)delegate
							{
								BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEp() + ((FileSystemInfo)BsS).Name + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FC());
							});
						}
						if (!BM.qW)
						{
							P_3.ReportProgress(10);
						}
						Stream val2 = (Stream)(object)File.OpenRead(((FileSystemInfo)BsS).FullName);
						if (!BM.qW)
						{
							P_3.ReportProgress(20);
						}
						Thread.Sleep(0);
						bool flag;
						try
						{
							flag = R.A(val2);
						}
						catch (System.Exception)
						{
							flag = false;
						}
						if (flag)
						{
							if (val2 != null)
							{
								val2.Close();
							}
						}
						else
						{
							byte[] array = new byte[val2.Length];
							if (!N.A(val2, array, 0, (int)val2.Length))
							{
								throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awg() + val2.Length + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awn());
							}
							if (val2 != null)
							{
								val2.Close();
							}
							if (!BM.qW)
							{
								P_3.ReportProgress(40);
							}
							Thread.Sleep(0);
							string text2 = Path.GetFileNameWithoutExtension(((FileSystemInfo)BsS).FullName);
							if (text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awO()))
							{
								text2 = text2.Substring(0, text2.LastIndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awO()));
							}
							List<KeyValuePair<string, byte[]>> val3 = new List<KeyValuePair<string, byte[]>>();
							val3.Add(new KeyValuePair<string, byte[]>(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWP(), array));
							val2 = (Stream)(object)File.OpenRead(((FileSystemInfo)BsS).FullName);
							Cn cn = new Co(val2).A();
							if (val2 != null)
							{
								val2.Close();
							}
							if (!BM.qW)
							{
								P_3.ReportProgress(50);
							}
							Thread.Sleep(0);
							string text3 = ((P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()) || P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj())) ? P_0 : (P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()));
							if (!string.IsNullOrEmpty(cn.BcB))
							{
								byte[] array2 = null;
								if (File.Exists(text3 + cn.BcB))
								{
									array2 = File.ReadAllBytes(text3 + cn.BcB);
								}
								else if (File.Exists(text3 + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax() + cn.BcB))
								{
									array2 = File.ReadAllBytes(text3 + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax() + cn.BcB);
								}
								if (array2 == null)
								{
									throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awo() + cn.BcB + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu());
								}
								val3.Add(new KeyValuePair<string, byte[]>(cn.BcB, array2));
							}
							if (!BM.qW)
							{
								P_3.ReportProgress(60);
							}
							Thread.Sleep(0);
							A(val3, text3, text2);
							string text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
							if (cn.BCY != (Version)null)
							{
								text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax() + ((object)cn.BCY).ToString();
							}
							if (!BM.qW)
							{
								P_3.ReportProgress(90);
							}
							Thread.Sleep(0);
							R.A(Path.Combine(P_1, text2) + text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sU(), M.A(), true, val3.ToArray());
							if (!BM.qW)
							{
								P_3.ReportProgress(100);
							}
							Thread.Sleep(50);
							text = ((FileSystemInfo)BsS).FullName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awI();
						}
					}
				}
				catch (System.Exception ex2)
				{
					text = ((FileSystemInfo)BsS).FullName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FZ() + ex2.Message;
				}
				if (!string.IsNullOrEmpty(text))
				{
					P_2.Add(text);
				}
			}
			if (Bcl)
			{
				DirectoryInfo[] directories = val.GetDirectories();
				foreach (DirectoryInfo val4 in directories)
				{
					string text5 = P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK() + ((FileSystemInfo)val4).Name;
					A(((FileSystemInfo)val4).FullName, text5, P_2, P_3);
				}
			}
		}

		private void A(List<KeyValuePair<string, byte[]>> P_0, string P_1, string P_2)
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			string text = Path.Combine(P_1, P_2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awi());
			if (!Directory.Exists(text))
			{
				return;
			}
			string[] directories = Directory.GetDirectories(text);
			foreach (string obj in directories)
			{
				string name = ((FileSystemInfo)new DirectoryInfo(obj)).Name;
				string[] files = Directory.GetFiles(obj);
				foreach (string text2 in files)
				{
					byte[] array = File.ReadAllBytes(text2);
					if (array != null)
					{
						string fileName = Path.GetFileName(text2);
						string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWz() + name + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK() + fileName;
						P_0.Add(new KeyValuePair<string, byte[]>(text3, array));
						continue;
					}
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awP() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu());
				}
			}
		}

		private void A(object P_0, DoWorkEventArgs P_1)
		{
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			string text = P_1.Argument as string;
			List<string> val2 = new List<string>();
			A(BcL, text, val2, val);
			P_1.Result = val2;
		}

		private void A(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
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
			bool flag = num == val.Count;
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awp() + num + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awK() + (flag ? string.Empty : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awQ());
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
			if (BM.qW)
			{
				Console.WriteLine();
				Console.WriteLine(text);
				Environment.Exit((!flag) ? 1 : 0);
			}
			else
			{
				bE.A((IWin32Window)(object)BM.QQ, text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awq(), (MessageBoxButtons)0);
			}
		}
	}
	internal class Cq
	{
		private string BcM;

		private Stream Bcm;

		private Framework BcN;

		internal Cq(string P_0, Framework P_1)
		{
			BcM = P_0;
			BcN = P_1;
		}

		internal Cq(Stream P_0, Framework P_1)
		{
			Bcm = P_0;
			BcN = P_1;
		}

		internal bool A(out string P_0)
		{
			return A(out P_0, false, false, false);
		}

		internal bool A(out string P_0, bool P_1, bool P_2, bool P_3)
		{
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Invalid comparison between Unknown and I4
			XmlReader val = null;
			Stream val2 = null;
			Stream val3 = null;
			P_0 = null;
			bool flag = true;
			if (BcM != null)
			{
				val2 = (Stream)(object)File.OpenRead(BcM);
				try
				{
					flag = R.A(val2);
				}
				catch (System.Exception)
				{
					flag = false;
				}
				if (flag)
				{
					if (!R.A(val2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGw(), out val3, M.A()))
					{
						val2.Close();
						P_0 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awR();
						return false;
					}
				}
				else
				{
					val3 = val2;
				}
				val = XmlReader.Create(val3);
			}
			else
			{
				if (Bcm == null)
				{
					P_0 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awr();
					return false;
				}
				val = XmlReader.Create(Bcm);
			}
			string text = null;
			bool flag2 = false;
			val.Read();
			while ((int)val.NodeType != 1)
			{
				val.Read();
			}
			if (!val.IsEmptyElement)
			{
				val.Read();
				while (val.IsStartElement())
				{
					bool flag3 = true;
					string name = val.Name;
					if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGX()))
					{
						if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hh())
						{
							if (!val.IsEmptyElement)
							{
								A(val, P_1);
							}
						}
						else
						{
							flag3 = false;
						}
					}
					else if (!val.IsEmptyElement && !A(val, P_1, out text))
					{
						flag2 = true;
					}
					if (!flag3)
					{
						val.Skip();
					}
					else
					{
						val.Read();
					}
				}
			}
			val.Close();
			if (val3 != null)
			{
				val3.Close();
			}
			if (val2 != null)
			{
				if (BcM != null && flag)
				{
					A(val2);
					if (!P_1 && BcN.awv.Count != 0)
					{
						A(val2, P_2, P_3);
					}
				}
				val2.Close();
			}
			if (flag2)
			{
				P_0 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awS();
				return false;
			}
			bool flag4 = false;
			if (bx.A(BcN.awZ) && BcN.aXA.A() < 3)
			{
				flag4 = true;
			}
			if (P_1 || flag4)
			{
				return true;
			}
			if (string.IsNullOrWhiteSpace(text))
			{
				P_0 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aws();
				return false;
			}
			if (A(text))
			{
				return true;
			}
			P_0 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awT();
			return false;
		}

		private bool A(string P_0)
		{
			byte[] array = BcN.h();
			bool result = false;
			MD5 val = MD5.Create();
			try
			{
				string text = n.A(((HashAlgorithm)val).ComputeHash(array));
				byte[] bytes = Encoding.ASCII.GetBytes(text);
				byte[] array2 = n.A(P_0);
				if (bytes.Length == array2.Length)
				{
					result = true;
					for (int i = 0; i < bytes.Length; i++)
					{
						if (bytes[i] != array2[i])
						{
							result = false;
							break;
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
			return result;
		}

		private bool A(XmlReader P_0, bool P_1, out string P_2)
		{
			P_2 = null;
			bool result = true;
			for (; P_0.IsStartElement(); P_0.Read())
			{
				string name = P_0.Name;
				if (name == null)
				{
					continue;
				}
				switch (name.Length)
				{
				case 3:
					switch (name[0])
					{
					case 'T':
						if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGx())
						{
							P_0.Skip();
						}
						break;
					case 'M':
						if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGY())
						{
							P_0.Read();
							P_2 = P_0.Value;
							P_0.Skip();
						}
						break;
					}
					continue;
				case 8:
				{
					char c = name[0];
					if (c != 'F')
					{
						if (c == 'H')
						{
							if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGZ()))
							{
								continue;
							}
							P_0.Read();
							string value = P_0.Value;
							P_0.Skip();
							byte[] array = n.A(value);
							byte[] array2 = BcN.F();
							for (int i = 0; i < 16; i++)
							{
								if (array2[i] != array[i])
								{
									result = false;
									break;
								}
							}
							continue;
						}
						if (c != 'P' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGz()))
						{
							continue;
						}
					}
					else if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agA()))
					{
						continue;
					}
					break;
				}
				case 21:
				{
					char c = name[7];
					if (c != 'D')
					{
						if (c != 'S' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.age()))
						{
							continue;
						}
						goto IL_03c3;
					}
					if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agE()))
					{
						continue;
					}
					break;
				}
				case 11:
				{
					char c = name[0];
					if (c != 'I')
					{
						if (c != 'P' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agB()))
						{
							continue;
						}
					}
					else if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aga()))
					{
						continue;
					}
					break;
				}
				case 14:
				{
					char c = name[7];
					if (c != 'E')
					{
						if (c != 'N' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agc()))
						{
							continue;
						}
					}
					else if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agC()))
					{
						continue;
					}
					break;
				}
				case 7:
				{
					char c = name[1];
					if (c != 'a')
					{
						if (c != 'e' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bs()))
						{
							continue;
						}
					}
					else if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agg()))
					{
						continue;
					}
					break;
				}
				case 12:
					if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZH())
					{
						BcN.aXc = P_0.ReadElementContentAsString();
					}
					continue;
				case 10:
					if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGy())
					{
						P_0.Skip();
					}
					continue;
				case 20:
					if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agF()))
					{
						continue;
					}
					goto IL_03c3;
				case 27:
					if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agf()))
					{
						continue;
					}
					goto IL_03c3;
				case 15:
					if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agb()))
					{
						continue;
					}
					break;
				case 18:
					if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agD()))
					{
						continue;
					}
					break;
				case 17:
					if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agd()))
					{
						continue;
					}
					break;
				case 9:
					if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agG()))
					{
						continue;
					}
					break;
				default:
					continue;
					IL_03c3:
					P_0.Skip();
					continue;
				}
				int num = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
				Setting setting = BcN.A(num);
				P_0.Read();
				byte[] array3 = n.A(P_0.Value);
				byte[] array4 = (BcN.aWR ? array3 : N.A(array3, setting.aG()));
				if (P_1)
				{
					setting.A(new byte[setting.BB()]);
					for (int j = 0; j < setting.aW().Length; j++)
					{
						if (j >= array4.Length)
						{
							setting.aW()[j] = 0;
						}
						else
						{
							setting.aW()[j] = array4[j];
						}
					}
				}
				else
				{
					setting.A(array4, false);
				}
				P_0.Skip();
			}
			return result;
		}

		private void A(XmlReader P_0, bool P_1)
		{
			while (P_0.IsStartElement())
			{
				string name = P_0.Name;
				if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGi() || name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWX())
				{
					int dataId = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
					int attrId = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWx()));
					Setting setting = BcN.A(new DataIdAndAttrId(dataId, attrId));
					if (setting != null)
					{
						P_0.Read();
						byte[] array = n.A(P_0.Value);
						byte[] array2 = (BcN.aWR ? array : N.A(array, setting.aG()));
						if (P_1)
						{
							setting.A(new byte[setting.BB()]);
							for (int i = 0; i < setting.aW().Length; i++)
							{
								if (i >= array2.Length)
								{
									setting.aW()[i] = 0;
								}
								else
								{
									setting.aW()[i] = array2[i];
								}
							}
						}
						else
						{
							setting.A(array2, false);
						}
						P_0.Skip();
					}
				}
				P_0.Read();
			}
		}

		private void A(Stream P_0)
		{
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			try
			{
				List<string> val = R.A(P_0, M.A());
				if (val.Count <= 1)
				{
					return;
				}
				for (int i = 0; i < val.Count; i++)
				{
					string text = val[i];
					if (!text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sU()))
					{
						continue;
					}
					Stream val2 = null;
					if (R.A(P_0, text, out val2, M.A()))
					{
						byte[] array = null;
						MemoryStream val3 = new MemoryStream();
						try
						{
							val2.CopyTo((Stream)(object)val3);
							array = val3.ToArray();
						}
						finally
						{
							((System.IDisposable)val3)?.Dispose();
						}
						Cn cn = new Co(val2).A();
						if (cn != null && BcN.awF.ContainsKey(cn.BCx))
						{
							lock (BM.qb)
							{
								if (!BM.qB.ContainsKey(cn.BCw))
								{
									DO dO = BcN.awF[cn.BCx];
									string text2 = BM.QY + dO.e();
									if (!Directory.Exists(text2))
									{
										Directory.CreateDirectory(text2);
									}
									string text3 = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK() + text;
									if (File.Exists(text3))
									{
										text3 = string.Concat(new string[6]
										{
											text2,
											D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK(),
											Path.GetFileNameWithoutExtension(text3),
											D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(),
											cn.BCX,
											D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sU()
										});
									}
									File.WriteAllBytes(text3, array);
									CO cO = new CO();
									cO.BcF = cn;
									cO.Bcf = text3;
									BM.A(cn.BCw, cO);
								}
							}
						}
					}
					if (val2 != null)
					{
						val2.Close();
					}
				}
			}
			catch
			{
			}
		}

		private void A(Stream P_0, bool P_1, bool P_2)
		{
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected O, but got Unknown
			List<string> val = null;
			try
			{
				val = R.A(P_0, M.A());
			}
			catch
			{
				return;
			}
			if (val == null || val.Count <= 1)
			{
				return;
			}
			string text = null;
			if (P_1)
			{
				BM.A(BM.QV, out text);
			}
			else if (P_2)
			{
				BM.A(BM.Qv, out text);
			}
			else
			{
				BM.A(BM.Qu, out text);
			}
			if (text != null)
			{
				N.A(text, true);
			}
			for (int i = 0; i < val.Count; i++)
			{
				string text2 = val[i];
				try
				{
					if (!text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TQ()) || text2.Length <= D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TQ().Length + 1)
					{
						continue;
					}
					Stream val2 = null;
					if (R.A(P_0, text2, out val2, M.A()))
					{
						byte[] array = null;
						MemoryStream val3 = new MemoryStream();
						try
						{
							val2.CopyTo((Stream)(object)val3);
							array = val3.ToArray();
						}
						finally
						{
							((System.IDisposable)val3)?.Dispose();
						}
						int num = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TQ().Length + 1;
						string text3 = text2.Substring(num);
						int num2 = text3.IndexOfAny(new char[2] { '\\', '/' });
						if (num2 != -1)
						{
							string text4 = text3.Substring(0, num2);
							int length = (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWz() + text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()).Length;
							if (length < text2.Length)
							{
								string text5 = text2.Substring(length);
								if (P_1)
								{
									BM.A(BM.QV, text5, array, text4, out text);
								}
								else if (P_2)
								{
									BM.A(BM.Qv, text5, array, text4, out text);
								}
								else
								{
									BM.A(BM.Qu, text5, array, text4, out text);
									if (text != null)
									{
										N.A(text, true);
									}
									BM.A(BcN, text5, array, text4, out text);
								}
								if (text != null)
								{
									N.A(text, true);
								}
							}
						}
					}
					if (val2 != null)
					{
						val2.Close();
					}
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awt() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rq() + ex.Message, true);
				}
			}
		}

		internal static bW a(string P_0)
		{
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Invalid comparison between Unknown and I4
			XmlReader val = null;
			Stream val2 = (Stream)(object)File.OpenRead(P_0);
			Stream val3 = null;
			bool flag;
			try
			{
				flag = R.A(val2);
			}
			catch (System.Exception)
			{
				flag = false;
			}
			if (flag)
			{
				if (!R.A(val2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGw(), out val3, M.A()))
				{
					val2.Close();
					return null;
				}
			}
			else
			{
				val3 = val2;
			}
			val = XmlReader.Create(val3);
			val.Read();
			while ((int)val.NodeType != 1)
			{
				val.Read();
			}
			k k = null;
			int axS = -1;
			int axs = -1;
			byte[] array = null;
			bool flag2 = false;
			bool flag3 = false;
			if (!val.IsEmptyElement)
			{
				val.Read();
				while (val.IsStartElement())
				{
					bool flag4 = true;
					if (val.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGX())
					{
						if (!val.IsEmptyElement)
						{
							while (val.IsStartElement() && (k == null || array == null || !flag2 || !flag3))
							{
								string name = val.Name;
								if (name != null)
								{
									switch (name.Length)
									{
									case 3:
									{
										char c = name[0];
										if (c != 'M')
										{
											if (c != 'T' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGx()))
											{
												break;
											}
										}
										else if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGY()))
										{
											break;
										}
										goto IL_03c0;
									}
									case 8:
									{
										char c = name[0];
										if (c != 'F')
										{
											if (c == 'H')
											{
												if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGZ())
												{
													val.Read();
													string value = val.Value;
													val.Skip();
													array = n.A(value);
												}
												break;
											}
											if (c != 'P' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGz()))
											{
												break;
											}
										}
										else if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agA()))
										{
											break;
										}
										goto IL_03cb;
									}
									case 11:
									{
										char c = name[0];
										if (c != 'I')
										{
											if (c != 'P' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agB()))
											{
												break;
											}
										}
										else if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aga()))
										{
											break;
										}
										goto IL_03cb;
									}
									case 14:
									{
										char c = name[7];
										if (c != 'E')
										{
											if (c != 'N' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agc()))
											{
												break;
											}
										}
										else if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agC()))
										{
											break;
										}
										goto IL_03cb;
									}
									case 21:
									{
										char c = name[7];
										if (c != 'D')
										{
											if (c != 'S' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.age()))
											{
												break;
											}
										}
										else if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agE()))
										{
											break;
										}
										goto IL_03cb;
									}
									case 7:
										switch (name[1])
										{
										case 'a':
											if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agg())
											{
												val.Read();
												axs = int.Parse(val.Value, (NumberStyles)512);
												flag3 = true;
												val.Skip();
											}
											break;
										case 'e':
											if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bs())
											{
												val.Read();
												string text = string.Empty;
												byte[] array2 = n.A(val.Value);
												foreach (byte b in array2)
												{
													System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(text);
													char c = (char)b;
													text = string.Concat(readOnlySpan, new System.ReadOnlySpan<char>(ref c));
												}
												k = new k(text, false);
												val.Skip();
											}
											break;
										}
										break;
									case 12:
										if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ZH()))
										{
											break;
										}
										goto IL_03c0;
									case 10:
										if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGy()))
										{
											break;
										}
										goto IL_03c0;
									case 15:
										if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agb()))
										{
											break;
										}
										goto IL_03cb;
									case 18:
										if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agD()))
										{
											break;
										}
										goto IL_03cb;
									case 17:
										if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agd()))
										{
											break;
										}
										goto IL_03cb;
									case 20:
										if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agF()))
										{
											break;
										}
										goto IL_03cb;
									case 27:
										if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agf()))
										{
											break;
										}
										goto IL_03cb;
									case 9:
										{
											if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agG())
											{
												val.Read();
												axS = int.Parse(val.Value, (NumberStyles)512);
												flag2 = true;
												val.Skip();
											}
											break;
										}
										IL_03c0:
										val.Skip();
										break;
										IL_03cb:
										val.Read();
										val.Skip();
										break;
									}
								}
								val.Read();
							}
						}
					}
					else
					{
						flag4 = false;
					}
					if (!flag4)
					{
						val.Skip();
					}
					else
					{
						val.Read();
					}
				}
			}
			val.Close();
			if (val3 != null)
			{
				val3.Close();
			}
			if (val2 != null)
			{
				val2.Close();
			}
			bW result = null;
			if (k != null && array != null)
			{
				result = new bW
				{
					axS = axS,
					axs = axs,
					axT = k,
					axt = array
				};
			}
			return result;
		}
	}
}
