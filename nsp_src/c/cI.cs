using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;

namespace c
{
	internal class cI : MovableResizablePanel
	{
		internal new class A : Panel
		{
			private cI Bua;

			internal A(cI P_0)
			{
				Bua = P_0;
			}

			protected override void OnPaint(PaintEventArgs e)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d9: Expected O, but got Unknown
				//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00de: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e4: Expected O, but got Unknown
				//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ea: Expected O, but got Unknown
				//IL_0115: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Unknown result type (might be due to invalid IL or missing references)
				e.Graphics.Clear(((Control)this).BackColor);
				int num = (int)((Control)this).Tag;
				try
				{
					if (Bua.BIq.Count > num && Bua.BIq[num] != null)
					{
						e.Graphics.SmoothingMode = (SmoothingMode)2;
						e.Graphics.DrawImage(Bua.BIq[num], 2, 2, ((Control)this).Width - 4, ((Control)this).Height - 4);
						return;
					}
					e.Graphics.FillRectangle(Brushes.Black, 2, 2, ((Control)this).Width - 4, ((Control)this).Height - 4);
					if (!Bua.BIm.awP.h())
					{
						return;
					}
					Font val = new Font(((Control)this).Font.FontFamily, (float)(((Control)this).Width / 12));
					try
					{
						SolidBrush val2 = new SolidBrush(BM.te);
						try
						{
							StringFormat val3 = new StringFormat();
							try
							{
								val3.Alignment = (StringAlignment)1;
								val3.LineAlignment = (StringAlignment)1;
								e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bek(), val, (Brush)(object)val2, Point.op_Implicit(new Point(((Control)this).Width / 2, ((Control)this).Height / 2)), val3);
							}
							finally
							{
								((System.IDisposable)val3)?.Dispose();
							}
						}
						finally
						{
							((System.IDisposable)val2)?.Dispose();
						}
					}
					finally
					{
						((System.IDisposable)val)?.Dispose();
					}
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BeL() + ex.Message, true);
				}
			}
		}

		[CompilerGenerated]
		private new sealed class a
		{
			public cI BuB;

			public int Bub;

			internal void A()
			{
				BuB.C(Bub);
			}
		}

		private const int BIK = 10;

		private const int BIk = 90;

		private const int BIL = 15;

		private const int BIl = 30;

		private const int BIM = 1000;

		private Framework BIm;

		private Di BIN;

		private int BIn = -1;

		private bool BIO;

		private int BIo;

		private int BIP;

		private int BIp = -1;

		private Panel BIQ = new Panel();

		private List<Image> BIq = new List<Image>();

		private FileSystemWatcher BIR;

		private bool BIr;

		private Timer BIS;

		private int BIs;

		internal cI(Framework P_0, Rectangle P_1, bool P_2)
			: base(P_1, P_2, false, true)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected O, but got Unknown
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Expected O, but got Unknown
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected O, but got Unknown
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			BIm = P_0;
			BIN = BIm.awP;
			BIR = new FileSystemWatcher();
			BIR.Path = BM.QW;
			BIR.NotifyFilter = (NotifyFilters)81;
			BIR.Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aVY();
			BIR.IncludeSubdirectories = false;
			BIR.EnableRaisingEvents = true;
			BIR.Changed += new FileSystemEventHandler(A);
			BIR.Created += new FileSystemEventHandler(A);
			B();
			if (P_1 == Rectangle.Empty)
			{
				int num = ch.A(BIm) * 90 / ch.a(BIm);
				((Control)this).Width = 15 + 6 * (num + 15) + 15;
				if (BIN.E().Count <= 5)
				{
					((Control)this).Height = 130;
				}
				else
				{
					((Control)this).Height = 250;
				}
			}
			else
			{
				((Control)this).Width = ((Rectangle)(ref P_1)).Width;
				((Control)this).Height = ((Rectangle)(ref P_1)).Height;
				((Control)this).Left = ((Rectangle)(ref P_1)).Left;
				((Control)this).Top = ((Rectangle)(ref P_1)).Top;
			}
			BIN.A(new EventHandler(A));
			((Control)this).MouseDown += new MouseEventHandler(b);
			((Control)BIQ).Tag = -1;
			((Control)BIQ).BackColor = Color.DodgerBlue;
			BIQ.BorderStyle = (BorderStyle)0;
			((Control)BIQ).Width = 5;
			((Control)BIQ).Height = 90;
			((Control)this).Controls.Add((Control)(object)BIQ);
			((Control)BIQ).Visible = false;
			if (BIm.awP.h() && cb.A())
			{
				cb.a();
				Application.DoEvents();
				cb.B();
				a();
			}
		}

		private void a()
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			if (BIS != null)
			{
				BIS.Close();
				BIS = null;
			}
			BIs = 0;
			BIS = new Timer();
			BIS.Interval = 1000.0;
			BIS.SynchronizingObject = (ISynchronizeInvoke)(object)this;
			BIS.Elapsed += new ElapsedEventHandler(A);
			BIS.AutoReset = true;
			BIS.Enabled = true;
			BIS.Start();
		}

		private void A(object P_0, ElapsedEventArgs P_1)
		{
			if (BIs < 3)
			{
				if (BIm.awP.h())
				{
					cb.B();
				}
				BIs++;
			}
			if (BIr)
			{
				try
				{
					A(true);
				}
				catch
				{
				}
				BIr = false;
			}
		}

		private bool A(string P_0)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				if (!File.Exists(P_0))
				{
					return false;
				}
				FileStream val = new FileInfo(P_0).Open((FileMode)3, (FileAccess)1, (FileShare)0);
				try
				{
					((Stream)val).Close();
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			catch (IOException)
			{
				return true;
			}
			return false;
		}

		private void A(object P_0, FileSystemEventArgs P_1)
		{
			int num = default(int);
			if (int.TryParse(Path.GetFileNameWithoutExtension(P_1.FullPath).Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAt().Length), ref num) && !A(P_1.FullPath))
			{
				BIr = true;
			}
		}

		internal new void A(bool P_0)
		{
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Expected O, but got Unknown
			H();
			List<Control> val = null;
			if (P_0)
			{
				while (((ArrangedElementCollection)((Control)this).Controls).Count > 1)
				{
					foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
					{
						Control val2 = item;
						if (val2 != BIQ)
						{
							((Component)val2).Dispose();
							break;
						}
					}
				}
				for (int num = BIq.Count - 1; num >= 0; num--)
				{
					Image val3 = BIq[num];
					if (val3 != null)
					{
						val3.Dispose();
					}
					BIq.RemoveAt(num);
				}
			}
			else if (BIN.E().Count != 0)
			{
				val = new List<Control>();
				foreach (Control item2 in (ArrangedElementCollection)((Control)this).Controls)
				{
					Control val4 = item2;
					if (val4 != BIQ && val4.Tag is int)
					{
						val.Add(val4);
					}
				}
			}
			if (BIN.E().Count == 0)
			{
				if (P_0)
				{
					return;
				}
				while (((ArrangedElementCollection)((Control)this).Controls).Count > 3)
				{
					foreach (Control item3 in (ArrangedElementCollection)((Control)this).Controls)
					{
						Control val5 = item3;
						if (val5 != BIQ && val5.Tag is int)
						{
							((Component)val5).Dispose();
							break;
						}
					}
				}
				for (int num2 = BIq.Count - 1; num2 >= 0; num2--)
				{
					Image val6 = BIq[num2];
					if (val6 != null)
					{
						val6.Dispose();
					}
					BIq.RemoveAt(num2);
				}
				return;
			}
			int num3 = 15;
			int num4 = 10;
			int num5 = BIN.a().ax();
			if (num5 == 0 || BIn >= num5)
			{
				BIn = -1;
			}
			int num6 = ch.A(BIm) * 90 / ch.a(BIm);
			for (int i = 0; i < num5; i++)
			{
				A a = A(i, num3, num4, num6);
				if (num3 + 2 * ((Control)a).Width + 15 < ((Control)this).Width - 15)
				{
					num3 += ((Control)a).Width + 15;
					continue;
				}
				num3 = 15;
				num4 += 120;
			}
			A(P_0, num5, num3, num4, num6);
			if (!P_0)
			{
				for (int num7 = val.Count - 1; num7 >= 0; num7--)
				{
					((Component)val[num7]).Dispose();
					val.RemoveAt(num7);
				}
			}
			for (int num8 = BIq.Count - 1; num8 >= num5; num8--)
			{
				Image val7 = BIq[num8];
				if (val7 != null)
				{
					val7.Dispose();
				}
				BIq.RemoveAt(num8);
			}
		}

		private A A(int P_0, int P_1, int P_2, int P_3)
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected O, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Expected O, but got Unknown
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			this.a(P_0);
			A a = new A(this);
			((Control)a).Tag = P_0;
			((Panel)a).BorderStyle = (BorderStyle)0;
			if (P_0 == BIn)
			{
				((Control)a).BackColor = Color.DodgerBlue;
			}
			else
			{
				((Control)a).BackColor = Color.White;
			}
			((Control)a).Left = P_1;
			((Control)a).Top = P_2;
			((Control)a).Width = P_3;
			((Control)a).Height = 90;
			((Control)a).DoubleClick += new EventHandler(b);
			((Control)a).MouseDown += new MouseEventHandler(A);
			((Control)a).MouseMove += new MouseEventHandler(this.a);
			((Control)a).MouseUp += new MouseEventHandler(B);
			((Control)a).ContextMenuStrip = B(P_0);
			((Control)this).Controls.Add((Control)(object)a);
			((Control)a).BringToFront();
			((Control)a).Refresh();
			string text = BIN.E()[P_0].H();
			int num = BIN.B().ax();
			string text2 = ((P_0 == num) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fe() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			Label val = new Label();
			((Control)val).AutoSize = false;
			((Control)val).Width = ((Control)a).Width + 15 - 2;
			val.TextAlign = (ContentAlignment)2;
			((Control)val).Tag = P_0;
			((Control)val).ForeColor = BM.tf;
			if (string.IsNullOrWhiteSpace(text))
			{
				((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aof() + (P_0 + 1) + text2;
			}
			else
			{
				((Control)val).Text = text + text2;
			}
			((Control)val).Left = P_1 + 1 - 7;
			((Control)val).Top = P_2 + 90 + 5;
			((Control)this).Controls.Add((Control)(object)val);
			((Control)val).BringToFront();
			((Control)val).Refresh();
			return a;
		}

		private new void B()
		{
			Application.DoEvents();
			string[] files = Directory.GetFiles(BM.QW);
			BIN.a().ax();
			string[] array = files;
			int num = default(int);
			foreach (string text in array)
			{
				if (!A(text) && int.TryParse(Path.GetFileNameWithoutExtension(text).Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAt().Length), ref num))
				{
					A(num, text);
				}
			}
		}

		private Image A(Image P_0, Color P_1)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			Bitmap val = new Bitmap(P_0.Width, P_0.Height, (PixelFormat)2498570);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				val2.Clear(P_1);
				val2.DrawImage(P_0, new Rectangle(default(Point), P_0.Size), new Rectangle(default(Point), P_0.Size), (GraphicsUnit)2);
				return (Image)(object)val;
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}

		private void A(int P_0, string P_1)
		{
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected O, but got Unknown
			if (!File.Exists(P_1) || P_0 < 0 || P_0 >= BIN.E().Count)
			{
				return;
			}
			try
			{
				FileStream obj = File.Open(P_1, (FileMode)3, (FileAccess)1);
				Image val = Image.FromStream((Stream)(object)obj);
				val = A(val, Color.Black);
				((Stream)obj).Dispose();
				if (BIq.Count > P_0)
				{
					BIq[P_0].Dispose();
					BIq[P_0] = val;
				}
				else
				{
					BIq.Add(val);
				}
				if (((Control)this).InvokeRequired)
				{
					((Control)this).Invoke((Action)delegate
					{
						C(P_0);
					});
				}
				else
				{
					C(P_0);
				}
			}
			catch (IOException)
			{
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAU() + ex.Message, true);
			}
		}

		private MenuNode A(int P_0)
		{
			MenuNode result = null;
			for (int i = 0; i < BIm.awR.c().Count; i++)
			{
				MenuNode menuNode = BIm.awR.c()[i];
				if (menuNode.m() == P_0)
				{
					result = menuNode;
					break;
				}
			}
			return result;
		}

		private void a(int P_0)
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			MenuNode menuNode = A(P_0);
			Image val = null;
			if (menuNode != null)
			{
				string qW = BM.QW;
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(11, 1);
				defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAu());
				defaultInterpolatedStringHandler.AppendFormatted<int>(P_0);
				defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wm());
				string text = qW + defaultInterpolatedStringHandler.ToStringAndClear();
				if (File.Exists(text) && !A(text))
				{
					FileStream obj = File.Open(text, (FileMode)3, (FileAccess)1);
					val = Image.FromStream((Stream)(object)obj);
					val = A(val, Color.Black);
					((Stream)obj).Dispose();
				}
				else if (BIm.awZ == 21 && !BIm.awP.h())
				{
					val = Co.A(menuNode.Y());
				}
			}
			if (BIq.Count > P_0)
			{
				Image val2 = BIq[P_0];
				BIq[P_0] = val;
				if (val2 != null)
				{
					val2.Dispose();
				}
			}
			else
			{
				BIq.Add(val);
			}
		}

		private void A(bool P_0, int P_1, int P_2, int P_3, int P_4)
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected O, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected O, but got Unknown
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected O, but got Unknown
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			Panel val = null;
			if (!P_0)
			{
				if (((Control)this).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAV()))
				{
					Control obj = ((Control)this).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAV()];
					val = (Panel)(object)((obj is Panel) ? obj : null);
				}
			}
			else
			{
				val = new Panel();
				((Control)val).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAV();
				val.BorderStyle = (BorderStyle)0;
				((Control)val).Width = P_4;
				((Control)val).Height = 90;
			}
			((Control)val).DoubleClick += new EventHandler(c);
			((Control)val).Click += new EventHandler(C);
			((Control)val).Paint += new PaintEventHandler(A);
			if (P_1 < BIN.E().Count)
			{
				((Control)val).Enabled = true;
			}
			else
			{
				BIO = false;
				((Control)val).Enabled = false;
			}
			((Control)val).Left = P_2;
			((Control)val).Top = P_3;
			if (P_0)
			{
				((Control)this).Controls.Add((Control)(object)val);
			}
			Label val2 = null;
			if (!P_0)
			{
				if (((Control)this).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAv()))
				{
					Control obj2 = ((Control)this).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAv()];
					val2 = (Label)(object)((obj2 is Label) ? obj2 : null);
				}
			}
			else
			{
				val2 = new Label();
				((Control)val2).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAv();
				((Control)val2).AutoSize = false;
				((Control)val2).Width = P_4;
				val2.TextAlign = (ContentAlignment)2;
				((Control)val2).ForeColor = BM.tf;
				((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAW() + BIN.E().Count + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
			}
			((Control)val2).Left = P_2;
			((Control)val2).Top = P_3 + 90 + 5;
			if (P_0)
			{
				((Control)this).Controls.Add((Control)(object)val2);
			}
		}

		public override void UpdateLayout(bool resizingOnly)
		{
			A(true);
		}

		private void A(object P_0, EventArgs P_1)
		{
			A(true);
		}

		private void A(object P_0, PaintEventArgs P_1)
		{
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected O, but got Unknown
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			Panel val = (Panel)((P_0 is Panel) ? P_0 : null);
			P_1.Graphics.SmoothingMode = (SmoothingMode)2;
			if (((Control)val).Enabled)
			{
				if (BIO)
				{
					P_1.Graphics.FillRectangle(Brushes.DodgerBlue, 0, 0, ((Control)val).Width, ((Control)val).Height);
					P_1.Graphics.FillRectangle(Brushes.White, 7, 7, ((Control)val).Width - 14, ((Control)val).Height - 14);
				}
				else
				{
					P_1.Graphics.FillRectangle(Brushes.White, 0, 0, ((Control)val).Width, ((Control)val).Height);
				}
				Pen val2 = new Pen(Color.DodgerBlue, 8f);
				try
				{
					P_1.Graphics.DrawEllipse(val2, ((Control)val).Width / 2 - 32, ((Control)val).Height / 2 - 32, 64, 64);
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
				Pen val3 = new Pen(Color.DodgerBlue, 5f);
				try
				{
					P_1.Graphics.DrawLine(val3, ((Control)val).Width / 2, ((Control)val).Height / 2 - 15, ((Control)val).Width / 2, ((Control)val).Height / 2 + 15);
					P_1.Graphics.DrawLine(val3, ((Control)val).Width / 2 - 15, ((Control)val).Height / 2, ((Control)val).Width / 2 + 15, ((Control)val).Height / 2);
					return;
				}
				finally
				{
					((System.IDisposable)val3)?.Dispose();
				}
			}
			P_1.Graphics.FillRectangle(Brushes.DarkGray, 0, 0, ((Control)val).Width, ((Control)val).Height);
			Pen val4 = new Pen(Color.Gray, 8f);
			try
			{
				P_1.Graphics.DrawEllipse(val4, ((Control)val).Width / 2 - 32, ((Control)val).Height / 2 - 32, 64, 64);
			}
			finally
			{
				((System.IDisposable)val4)?.Dispose();
			}
			Pen val5 = new Pen(Color.Gray, 5f);
			try
			{
				P_1.Graphics.DrawLine(val5, ((Control)val).Width / 2, ((Control)val).Height / 2 - 15, ((Control)val).Width / 2, ((Control)val).Height / 2 + 15);
				P_1.Graphics.DrawLine(val5, ((Control)val).Width / 2 - 15, ((Control)val).Height / 2, ((Control)val).Width / 2 + 15, ((Control)val).Height / 2);
			}
			finally
			{
				((System.IDisposable)val5)?.Dispose();
			}
		}

		private ContextMenuStrip B(int P_0)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Expected O, but got Unknown
			ContextMenuStrip val = new ContextMenuStrip
			{
				BackColor = BM.tG,
				ForeColor = BM.te
			};
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Tag = P_0;
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fl();
			((ToolStripItem)val2).Font = ((Control)this).Font;
			((ToolStripItem)val2).Click += new EventHandler(a);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
			ToolStripMenuItem val3 = new ToolStripMenuItem();
			((ToolStripItem)val3).Tag = P_0;
			((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FM();
			((ToolStripItem)val3).Font = ((Control)this).Font;
			((ToolStripItem)val3).Click += new EventHandler(B);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
			return val;
		}

		private void a(object P_0, EventArgs P_1)
		{
			int num = (int)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
			BIN.B(num);
		}

		private void B(object P_0, EventArgs P_1)
		{
			int num = (int)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
			BIN.a(num);
		}

		private void b(int P_0)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (!(val is Panel) || val == BIQ)
				{
					continue;
				}
				if (val.Tag is int)
				{
					if ((int)val.Tag == P_0)
					{
						val.BackColor = Color.DodgerBlue;
					}
					else
					{
						val.BackColor = Color.White;
					}
				}
				else
				{
					val.BackColor = Color.White;
				}
			}
			BIO = false;
			BIn = P_0;
		}

		private void C(int P_0)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Panel && val != BIQ && val.Tag is int && (int)val.Tag == P_0)
				{
					val.Refresh();
				}
			}
			BIO = false;
			BIn = P_0;
		}

		private void b(object P_0, EventArgs P_1)
		{
			int num = (int)((Control)(P_0 as A)).Tag;
			BM.QQ.rL.b(num);
		}

		private void C(object P_0, EventArgs P_1)
		{
			b();
			((Control)this).Focus();
		}

		private new void b()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Panel && val != BIQ)
				{
					if (val.Tag is int)
					{
						val.BackColor = Color.White;
					}
					else
					{
						val.BackColor = Color.DodgerBlue;
					}
				}
			}
			BIn = -1;
			BIO = true;
		}

		internal static void A(Framework P_0, int P_1)
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Invalid comparison between Unknown and I4
			Cursor current = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;
			MenuNode menuNode = null;
			for (int i = 0; i < P_0.awR.c().Count; i++)
			{
				MenuNode menuNode2 = P_0.awR.c()[i];
				if (menuNode2.m() == P_1)
				{
					menuNode = menuNode2;
					break;
				}
			}
			if (menuNode != null)
			{
				BR bR = new BR(menuNode);
				if ((int)((Form)bR).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
				{
					cb.b();
					if (BM.A(P_0.aXc, true))
					{
						global::A.A.d(P_0.aXc, out var _);
					}
					if (BM.QQ.rL.A().a().Count != 0)
					{
						BM.QQ.rL.A(false, true, true, true);
						BM.QQ.rL.B(false);
						if (BM.Qn != null)
						{
							BM.QQ.rL.b(false);
						}
					}
					if (P_0 == BM.Qz && BM.A(P_0.aXc, true))
					{
						BM.QQ.A(null, -1, false);
					}
					BM.QQ.rL.b(P_1);
				}
				else
				{
					P_0.awP.a(P_1);
				}
				((Component)bR).Dispose();
			}
			Cursor.Current = current;
		}

		private void c(object P_0, EventArgs P_1)
		{
			int num = BIN.a().ax();
			if (BIN.A(num))
			{
				A(BIm, num);
			}
		}

		private void A(object P_0, MouseEventArgs P_1)
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Invalid comparison between Unknown and I4
			((Control)BIQ).Tag = -1;
			((Control)BIQ).Visible = false;
			if ((int)P_1.Button == 1048576)
			{
				BIo = P_1.X;
				BIP = P_1.Y;
				int num = (int)((Control)(P_0 as A)).Tag;
				b(num);
				BIp = num;
			}
			((Control)this).Focus();
		}

		private void a(object P_0, MouseEventArgs P_1)
		{
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			if (BIp == -1)
			{
				return;
			}
			A a = P_0 as A;
			((Control)a).BringToFront();
			int num = P_1.X - BIo;
			int num2 = P_1.Y - BIP;
			((Control)a).Left = ((Control)a).Left + num;
			((Control)a).Top = ((Control)a).Top + num2;
			Rectangle val = default(Rectangle);
			((Rectangle)(ref val))._002Ector(((Control)a).Left, ((Control)a).Top, ((Control)a).Width, ((Control)a).Height);
			int num3 = 15;
			int num4 = 10;
			int num5 = BIN.a().ax();
			int num6 = ch.A(BIm) * 90 / ch.a(BIm);
			Rectangle val2 = default(Rectangle);
			Rectangle val3 = default(Rectangle);
			for (int i = 0; i < num5; i++)
			{
				((Rectangle)(ref val2))._002Ector(num3 - 15, num4, 15, 90);
				((Rectangle)(ref val3))._002Ector(num3 + num6, num4, 15, 90);
				if (BIp != i)
				{
					if (((Rectangle)(ref val)).IntersectsWith(val2))
					{
						int num7 = i;
						if (BIp != num7 - 1)
						{
							((Control)BIQ).Tag = num7;
						}
						((Control)BIQ).Left = num3 - 7 - ((Control)BIQ).Width / 2;
						((Control)BIQ).Top = num4;
						((Control)BIQ).Visible = true;
						break;
					}
					if (((Rectangle)(ref val)).IntersectsWith(val3))
					{
						int num8 = i + 1;
						if (BIp != num8)
						{
							((Control)BIQ).Tag = num8;
						}
						((Control)BIQ).Left = num3 + num6 + 7 - ((Control)BIQ).Width / 2;
						((Control)BIQ).Top = num4;
						((Control)BIQ).Visible = true;
						break;
					}
				}
				if (num3 + 2 * num6 + 15 < ((Control)this).Width - 15)
				{
					num3 += num6 + 15;
					continue;
				}
				num3 = 15;
				num4 += 120;
			}
		}

		private void B(object P_0, MouseEventArgs P_1)
		{
			if (BIp == -1)
			{
				return;
			}
			((Control)BIQ).Visible = false;
			int num = (int)((Control)BIQ).Tag;
			bool flag = false;
			if (num != -1)
			{
				int bIp = BIp;
				if (bIp != num)
				{
					if (num < bIp)
					{
						BIn = num;
					}
					else
					{
						BIn = num - 1;
					}
					BIN.A(bIp, BIn);
				}
				else
				{
					flag = true;
				}
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				A a = P_0 as A;
				int num2 = (int)((Control)a).Tag;
				int num3 = 15;
				int num4 = 10;
				int num5 = BIN.a().ax();
				int num6 = ch.A(BIm) * 90 / ch.a(BIm);
				for (int i = 0; i < num5; i++)
				{
					if (i == num2)
					{
						((Control)a).Left = num3;
						((Control)a).Top = num4;
					}
					if (num3 + 2 * num6 + 15 < ((Control)this).Width - 15)
					{
						num3 += num6 + 15;
						continue;
					}
					num3 = 15;
					num4 += 120;
				}
			}
			((Control)BIQ).Tag = -1;
			BIp = -1;
		}

		private void b(object P_0, MouseEventArgs P_1)
		{
			((Control)this).Focus();
		}

		private void C()
		{
			if (BIn != -1)
			{
				BM.QQ.rL.b(BIn);
			}
			else if (BIO)
			{
				c(null, null);
			}
		}

		private void c()
		{
			int num = BIN.a().ax();
			if (num != 0)
			{
				if (BIO)
				{
					b(0);
				}
				else if (BIn != -1)
				{
					if (BIn < num - 1)
					{
						b(BIn + 1);
					}
					else if (num < BIN.E().Count)
					{
						b();
					}
					else
					{
						b(0);
					}
				}
				else
				{
					b(0);
				}
			}
			else
			{
				b();
			}
		}

		private void D()
		{
			int num = BIN.a().ax();
			if (num != 0)
			{
				if (BIO)
				{
					b(num - 1);
				}
				else if (BIn != -1)
				{
					if (BIn != 0)
					{
						b(BIn - 1);
					}
				}
				else
				{
					b(0);
				}
			}
			else
			{
				b();
			}
		}

		private void d()
		{
			int num = BIN.a().ax();
			if (num != 0)
			{
				if (BIO)
				{
					return;
				}
				if (BIn != -1)
				{
					if (BIn < num - 1)
					{
						b(BIn + 1);
					}
					else if (num < BIN.E().Count)
					{
						b();
					}
				}
				else
				{
					b(0);
				}
			}
			else
			{
				b();
			}
		}

		private void E()
		{
			int num = -1;
			if (BIn != -1)
			{
				if (BIN.A(BIn + 1))
				{
					num = BIn + 1;
				}
			}
			else
			{
				int num2 = BIN.a().ax();
				if (BIN.A(num2))
				{
					num = num2;
				}
			}
			if (num != -1)
			{
				A(BIm, num);
			}
		}

		private void e()
		{
			if (BIn != -1)
			{
				int bIn = BIn;
				BIn = -1;
				BIN.a(bIn);
			}
		}

		private void F()
		{
			if (BIn != -1 && BIn != 0)
			{
				int bIn = BIn;
				int num = --BIn;
				BIN.A(bIn, num);
			}
		}

		private void f()
		{
			int num = BIN.a().ax();
			if (BIn != -1 && BIn != num - 1)
			{
				int num2 = BIn + 1;
				int num3 = BIn++;
				BIN.A(num2, num3);
			}
		}

		private void G()
		{
			BIN.b(BIn);
		}

		private void g()
		{
			BIN.C(BIn);
		}

		protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Invalid comparison between Unknown and I4
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Invalid comparison between Unknown and I4
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Invalid comparison between Unknown and I4
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Invalid comparison between Unknown and I4
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Invalid comparison between Unknown and I4
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Invalid comparison between Unknown and I4
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Invalid comparison between Unknown and I4
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Invalid comparison between Unknown and I4
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Invalid comparison between Unknown and I4
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Invalid comparison between Unknown and I4
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Invalid comparison between Unknown and I4
			e.IsInputKey = (int)e.KeyData == 13 || (int)e.KeyData == 13 || (int)e.KeyData == 9 || (int)e.KeyData == 37 || (int)e.KeyData == 39 || (int)e.KeyData == 45 || (int)e.KeyData == 46 || (int)e.KeyData == 131109 || (int)e.KeyData == 131111 || (int)e.KeyData == 131139 || (int)e.KeyData == 131158;
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Invalid comparison between Unknown and I4
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Invalid comparison between Unknown and I4
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Invalid comparison between Unknown and I4
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Invalid comparison between Unknown and I4
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Invalid comparison between Unknown and I4
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Invalid comparison between Unknown and I4
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Invalid comparison between Unknown and I4
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Invalid comparison between Unknown and I4
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Invalid comparison between Unknown and I4
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Invalid comparison between Unknown and I4
			if ((int)e.KeyData == 13 || (int)e.KeyData == 13)
			{
				C();
			}
			else if ((int)e.KeyData == 9)
			{
				c();
			}
			else if ((int)e.KeyData == 37)
			{
				D();
			}
			else if ((int)e.KeyData == 39)
			{
				d();
			}
			else if ((int)e.KeyData == 45)
			{
				E();
			}
			else if ((int)e.KeyData == 46)
			{
				this.e();
			}
			else if ((int)e.KeyData == 131109)
			{
				F();
			}
			else if ((int)e.KeyData == 131111)
			{
				f();
			}
			else if ((int)e.KeyData == 131139)
			{
				G();
			}
			else if ((int)e.KeyData == 131158)
			{
				g();
			}
		}

		private void H()
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected O, but got Unknown
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected O, but got Unknown
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Expected O, but got Unknown
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
			try
			{
				foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
				{
					Control val = item;
					if (val is A)
					{
						val.DoubleClick -= new EventHandler(b);
						val.MouseDown -= new MouseEventHandler(A);
						val.MouseMove -= new MouseEventHandler(a);
						val.MouseUp -= new MouseEventHandler(B);
						if (val.ContextMenuStrip != null && !((Control)val.ContextMenuStrip).IsDisposed && !((Control)val.ContextMenuStrip).Disposing)
						{
							foreach (ToolStripMenuItem item2 in (ArrangedElementCollection)((ToolStrip)val.ContextMenuStrip).Items)
							{
								((ToolStripItem)item2).Click -= new EventHandler(a);
								((ToolStripItem)item2).Click -= new EventHandler(B);
							}
						}
					}
					val.DoubleClick -= new EventHandler(c);
					val.Click -= new EventHandler(C);
					val.Paint -= new PaintEventHandler(A);
				}
			}
			catch
			{
			}
		}

		protected override void Dispose(bool disposing)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			try
			{
				BIN.a(new EventHandler(A));
				if (BIS != null)
				{
					BIS.Elapsed -= new ElapsedEventHandler(A);
					BIS.Close();
					BIS = null;
				}
				((Control)this).MouseDown -= new MouseEventHandler(b);
				H();
				for (int num = BIq.Count - 1; num >= 0; num--)
				{
					Image val = BIq[num];
					if (val != null)
					{
						val.Dispose();
					}
					BIq.RemoveAt(num);
				}
				BIR.Changed -= new FileSystemEventHandler(A);
				BIR.Created -= new FileSystemEventHandler(A);
				((Component)BIR).Dispose();
				base.Dispose(disposing);
			}
			catch
			{
			}
		}
	}
	internal class ci : MovableResizablePanel
	{
		private new enum A
		{
			Buh,
			BuI,
			Bui,
			BuJ
		}

		private new delegate void a(object P_0, EventArgs P_1);

		private const int Bif = 220;

		private const int BiG = 17;

		private Framework Big;

		private Framework BiH;

		private bool Bih;

		private Label BiI = new Label();

		private PictureBox Bii = new PictureBox();

		private ThemedTextBox BiJ = new ThemedTextBox();

		private ThemedButton Bij = new ThemedButton();

		private static string BiK = string.Empty;

		private ThemedComboBox Bik = new ThemedComboBox();

		private static int BiL = 0;

		private aF Bil = new aF();

		private Timer BiM = new Timer();

		[CompilerGenerated]
		private readonly Ck Bim;

		[SpecialName]
		[CompilerGenerated]
		internal Ck a()
		{
			return Bim;
		}

		internal ci(Framework P_0, Framework P_1, Rectangle P_2, bool P_3)
			: base(P_2, P_3, false, false)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected O, but got Unknown
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected O, but got Unknown
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Expected O, but got Unknown
			//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected O, but got Unknown
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Expected O, but got Unknown
			//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d4: Expected O, but got Unknown
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Expected O, but got Unknown
			Bih = true;
			Big = P_0;
			BiH = P_1;
			((Control)BiI).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAw();
			((Control)BiI).Font = new Font(((Control)BiI).Font.FontFamily, ((Control)BiI).Font.Size, (FontStyle)1);
			((Control)BiI).AutoSize = true;
			((Control)BiI).ForeColor = BM.te;
			if (Bii.Image != null)
			{
				Bii.Image.Dispose();
			}
			Bii.Image = (Image)(object)O.A((Image)(object)GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
			((Control)Bii).Width = 24;
			((Control)Bii).Height = 24;
			((Control)BiJ).TextChanged += new EventHandler(c);
			((Control)BiJ).Width = 220;
			((Control)BiJ).Text = BiK;
			((Control)BiJ).BackColor = BM.to;
			((Control)BiJ).ForeColor = BM.te;
			BiJ.A(A);
			((Control)Bij).Click += new EventHandler(C);
			((Control)Bij).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Di();
			((Control)Bij).Font = new Font(((Control)Bij).Font.FontFamily, 8f, (FontStyle)1);
			((Control)Bij).Width = 22;
			((ComboBox)Bik).SelectedIndexChanged += new EventHandler(d);
			((Control)Bik).Width = 200;
			((ComboBox)Bik).DropDownStyle = (ComboBoxStyle)2;
			((ComboBox)Bik).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAX());
			((ComboBox)Bik).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAx());
			((ComboBox)Bik).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAY());
			((ComboBox)Bik).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAy());
			((ListControl)Bik).SelectedIndex = BiL;
			((Panel)Bil).BorderStyle = (BorderStyle)1;
			BiM.Interval = 400;
			BiM.Tick += new EventHandler(D);
			BM.QQ.B(new EventHandler(A));
			Bim = new Ck(P_0);
			Bih = false;
		}

		protected override void Dispose(bool disposing)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected O, but got Unknown
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			try
			{
				((Control)BiJ).TextChanged -= new EventHandler(c);
				((Control)Bij).Click -= new EventHandler(C);
				((ComboBox)Bik).SelectedIndexChanged -= new EventHandler(d);
				BiJ.a(A);
				BiM.Tick -= new EventHandler(D);
				((Component)BiM).Dispose();
				foreach (Control item in (ArrangedElementCollection)((Control)Bil).Controls)
				{
					Control val = item;
					if (val is aP)
					{
						((CheckBox)(val as aP)).CheckedChanged -= new EventHandler(a);
						Big.A((int)val.Tag).a(new EventHandler(B));
					}
					else if (val is LinkLabel)
					{
						((val is LinkLabel) ? val : null).Click -= new EventHandler(b);
					}
				}
				BM.QQ.b(new EventHandler(A));
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		[SpecialName]
		internal new ThemedTextBox B()
		{
			return BiJ;
		}

		public override void UpdateLayout(bool resizingOnly)
		{
			if (!resizingOnly)
			{
				((Control)Bil).SuspendLayout();
				while (((ArrangedElementCollection)((Control)Bil).Controls).Count != 0)
				{
					q.A(((Control)Bil).Controls[0]);
				}
				((Control)Bil).ResumeLayout(true);
				((Control)this).Controls.Clear();
				A(true);
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			c();
		}

		private void a(object P_0, EventArgs P_1)
		{
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Invalid comparison between Unknown and I4
			if (BM.QO == BM.b.BpG || !Big.C())
			{
				return;
			}
			aP aP = P_0 as aP;
			Setting setting = Big.A((int)((Control)aP).Tag);
			if (!BM.QP)
			{
				if (((CheckBox)aP).Checked)
				{
					Setting setting2 = null;
					MenuNode menuNode = null;
					string text = ((SettingOrSpecialObject)setting).P();
					if (text == null)
					{
						if (((SettingOrSpecialObject)setting).D() != null && ((SettingOrSpecialObject)setting).D().o() != null)
						{
							text = ((SettingOrSpecialObject)setting).D().o().t();
							if (text != null)
							{
								menuNode = ((SettingOrSpecialObject)setting).D().o();
							}
							else if (setting.t() != null)
							{
								text = setting.t().t();
								if (text != null)
								{
									menuNode = setting.t();
								}
							}
						}
					}
					else
					{
						setting2 = setting;
					}
					if (text != null && !Bg.A(setting2, menuNode))
					{
						Bg bg = new Bg(text, setting2, menuNode);
						if ((int)((Form)bg).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
						{
							a().A(setting.A());
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
							((CheckBox)aP).Checked = false;
						}
						((Component)bg).Dispose();
					}
					else
					{
						a().A(setting.A());
						if (setting.A() == 10195 && setting.d(0).Count == 3)
						{
							setting.a(2, true);
						}
						else
						{
							setting.a(1, true);
						}
					}
					if (((CheckBox)aP).Checked)
					{
						if (((SettingOrSpecialObject)setting).D() != null)
						{
							PortFunction.A(((SettingOrSpecialObject)setting).D(), false);
						}
						a().B();
					}
				}
				else
				{
					a().A(setting.A());
					setting.a(0, true);
					a().B();
				}
			}
			BM.b(setting.A());
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			if (((Control)this).InvokeRequired)
			{
				try
				{
					a a = B;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			if (BM.QO == BM.b.BpG)
			{
				return;
			}
			Setting setting = P_0 as Setting;
			foreach (Control item in (ArrangedElementCollection)((Control)Bil).Controls)
			{
				Control val = item;
				if (!(val is aP))
				{
					continue;
				}
				aP aP = val as aP;
				if ((int)((Control)aP).Tag != setting.A())
				{
					continue;
				}
				if (setting.A() == 10195)
				{
					if (((CheckBox)aP).Checked != (setting.ax() != 0))
					{
						((CheckBox)aP).Checked = setting.ax() != 0;
					}
				}
				else if (((CheckBox)aP).Checked != (setting.ax() == 1))
				{
					((CheckBox)aP).Checked = setting.ax() == 1;
				}
				break;
			}
		}

		private void b(object P_0, EventArgs P_1)
		{
			aP aP = ((Control)((P_0 is LinkLabel) ? P_0 : null)).Tag as aP;
			Setting setting = Big.A((int)((Control)aP).Tag);
			TreeNode val = BM.QQ.rL.A(BM.QQ.rL.A().a(), setting.C(), false);
			if (val != null)
			{
				BM.QQ.rL.A().A(val);
			}
		}

		private new List<Setting> b()
		{
			List<Setting> val = new List<Setting>();
			for (int i = 0; i < Big.aWZ.Count; i++)
			{
				Setting setting = Big.A(Big.aWZ[i]);
				if (setting == null || setting.am())
				{
					continue;
				}
				string text = null;
				text = ((((SettingOrSpecialObject)setting).D() == null || string.IsNullOrEmpty(((SettingOrSpecialObject)setting).D().A(bz.aYt))) ? ((SettingOrSpecialObject)setting).A(bz.aYt) : ((SettingOrSpecialObject)setting).D().A(bz.aYt));
				string text2 = text.ToLower();
				bool flag = false;
				for (int j = 0; j < val.Count; j++)
				{
					Setting setting2 = val[j];
					string text3 = null;
					text3 = ((((SettingOrSpecialObject)setting2).D() == null || string.IsNullOrEmpty(((SettingOrSpecialObject)setting2).D().A(bz.aYt))) ? ((SettingOrSpecialObject)setting2).A(bz.aYt) : ((SettingOrSpecialObject)setting2).D().A(bz.aYt));
					string text4 = text3.ToLower();
					for (int k = 0; k < Math.Min(text2.Length, text4.Length); k++)
					{
						if (text2[k] != text4[k])
						{
							if (text2[k] > text4[k])
							{
								break;
							}
							if (text2[k] < text4[k])
							{
								val.Insert(j, setting);
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
				if (!flag)
				{
					val.Add(setting);
				}
			}
			return val;
		}

		internal bool C()
		{
			return ((ListControl)Bik).SelectedIndex == 0;
		}

		private void c()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected O, but got Unknown
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0214: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			foreach (Control item in (ArrangedElementCollection)((Control)Bil).Controls)
			{
				Control val = item;
				if (!(val is aP))
				{
					continue;
				}
				aP aP = val as aP;
				Setting setting = Big.A((int)((Control)aP).Tag);
				if (BM.QO == BM.b.BpG)
				{
					Setting setting2 = null;
					if (BiH != null)
					{
						setting2 = BiH.A((int)((Control)aP).Tag);
					}
					if (setting2 != null)
					{
						setting = setting2;
					}
					((Control)aP).Enabled = false;
					aP.jd = true;
				}
				else
				{
					((Control)aP).Enabled = true;
					aP.jd = false;
				}
				if (setting.A() == 10195)
				{
					if (((CheckBox)aP).Checked != (setting.ax() != 0))
					{
						((CheckBox)aP).Checked = !((CheckBox)aP).Checked;
					}
				}
				else if (((CheckBox)aP).Checked != (setting.ax() == 1))
				{
					((CheckBox)aP).Checked = !((CheckBox)aP).Checked;
				}
			}
			foreach (Control item2 in (ArrangedElementCollection)((Control)Bil).Controls)
			{
				Control val2 = item2;
				if (!(val2 is LinkLabel))
				{
					continue;
				}
				LinkLabel val3 = (LinkLabel)(object)((val2 is LinkLabel) ? val2 : null);
				aP aP2 = ((Control)val3).Tag as aP;
				if (((CheckBox)aP2).Checked)
				{
					val3.LinkBehavior = (LinkBehavior)1;
				}
				else
				{
					val3.LinkBehavior = (LinkBehavior)3;
				}
				Setting setting3 = Big.A((int)((Control)aP2).Tag);
				if (((SettingOrSpecialObject)setting3).l() && !setting3.O())
				{
					switch (setting3.P())
					{
					case IllegalitySeverityLevel.Error:
						val3.LinkColor = BM.tC;
						break;
					case IllegalitySeverityLevel.Warning:
						val3.LinkColor = Color.Orange;
						break;
					case IllegalitySeverityLevel.ErrorIfOnline:
						if (BM.A(Big.aXc, true))
						{
							val3.LinkColor = BM.tC;
						}
						else
						{
							val3.LinkColor = Color.Orange;
						}
						break;
					default:
						val3.LinkColor = BM.tC;
						break;
					}
				}
				else
				{
					((Control)val3).BackColor = ((Control)this).BackColor;
					Setting setting4 = null;
					if (BiH != null)
					{
						setting4 = BiH.A(setting3.A());
					}
					if (setting4 != null && !setting3.A(setting4))
					{
						val3.LinkColor = BM.tD;
					}
					else if (!((CheckBox)aP2).Checked)
					{
						val3.LinkColor = BM.tq;
					}
					else
					{
						val3.LinkColor = BM.tF;
					}
				}
			}
		}

		private void D()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected O, but got Unknown
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Expected O, but got Unknown
			//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cf: Expected O, but got Unknown
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Expected O, but got Unknown
			//IL_0370: Unknown result type (might be due to invalid IL or missing references)
			//IL_0375: Unknown result type (might be due to invalid IL or missing references)
			//IL_0376: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0308: Unknown result type (might be due to invalid IL or missing references)
			//IL_0319: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Unknown result type (might be due to invalid IL or missing references)
			//IL_033d: Unknown result type (might be due to invalid IL or missing references)
			//IL_035f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
			int num = 10;
			int num2 = 10;
			Enumerator<Setting> enumerator = b().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					Setting setting = null;
					if (BiH != null)
					{
						setting = BiH.A(current.A());
					}
					bool flag;
					bool flag2;
					if (BM.QO == BM.b.BpG && setting != null)
					{
						flag = ((setting.A() != 10195) ? (setting.ax() == 1) : (setting.ax() != 0));
						flag2 = ((SettingOrSpecialObject)setting).l() && !current.O();
					}
					else
					{
						flag = ((current.A() != 10195) ? (current.ax() == 1) : (current.ax() != 0));
						flag2 = ((SettingOrSpecialObject)current).l() && !current.O();
					}
					if (current.am() || (((ListControl)Bik).SelectedIndex != 0 && !(((ListControl)Bik).SelectedIndex == 1 && flag) && (((ListControl)Bik).SelectedIndex != 2 || flag) && !(((ListControl)Bik).SelectedIndex == 3 && flag2)) || (Big.B() && Big.b() && current.J()) || !A(current))
					{
						continue;
					}
					string text = null;
					if (((SettingOrSpecialObject)current).D() != null && !string.IsNullOrEmpty(((SettingOrSpecialObject)current).D().A(bz.aYt)))
					{
						text = ((SettingOrSpecialObject)current).D().A(bz.aYt);
						string text2 = ((SettingOrSpecialObject)current).D().H();
						if (!string.IsNullOrWhiteSpace(text2))
						{
							text = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
						}
					}
					else
					{
						text = ((SettingOrSpecialObject)current).A(bz.aYt);
					}
					aP aP = new aP();
					if (BM.QO == BM.b.BpG)
					{
						aP.jd = true;
						((Control)aP).Enabled = false;
					}
					else
					{
						((Control)aP).Enabled = Big.C();
					}
					LinkLabel val = new LinkLabel();
					((Control)aP).AutoSize = false;
					((Control)val).AutoSize = false;
					((Control)val).Text = text;
					((Control)aP).Text = string.Empty;
					((CheckBox)aP).Checked = flag;
					if (((CheckBox)aP).Checked)
					{
						val.LinkBehavior = (LinkBehavior)1;
					}
					else
					{
						val.LinkBehavior = (LinkBehavior)3;
					}
					((Control)aP).Left = num;
					((Control)val).Left = num + 17;
					((Control)aP).Top = num2;
					((Control)val).Top = num2 + 1;
					((Control)aP).Width = 17;
					((Control)val).Width = 203;
					((Control)aP).Height = (int)((float)((Control)aP).Height * 0.75f);
					((Control)val).Height = ((Control)aP).Height;
					((Control)aP).Tag = current.A();
					((Control)val).Tag = aP;
					((CheckBox)aP).CheckedChanged += new EventHandler(a);
					current.A(new EventHandler(B));
					((Control)val).Click += new EventHandler(b);
					if (flag2)
					{
						switch (current.P())
						{
						case IllegalitySeverityLevel.Error:
							val.LinkColor = BM.tC;
							break;
						case IllegalitySeverityLevel.Warning:
							val.LinkColor = Color.Orange;
							break;
						case IllegalitySeverityLevel.ErrorIfOnline:
							if (BM.A(Big.aXc, true))
							{
								val.LinkColor = BM.tC;
							}
							else
							{
								val.LinkColor = Color.Orange;
							}
							break;
						default:
							val.LinkColor = BM.tC;
							break;
						}
					}
					else
					{
						Color backColor2 = (((Control)val).BackColor = ((Control)this).BackColor);
						((Control)aP).BackColor = backColor2;
						Setting setting2 = null;
						if (BiH != null)
						{
							setting2 = BiH.A(current.A());
						}
						if (setting2 != null && !current.A(setting2))
						{
							val.LinkColor = BM.tD;
						}
						else if (!((CheckBox)aP).Checked)
						{
							val.LinkColor = BM.tq;
						}
						else
						{
							val.LinkColor = BM.tF;
						}
					}
					((Control)Bil).Controls.Add((Control)(object)aP);
					((Control)Bil).Controls.Add((Control)(object)val);
					if (((Control)aP).Bottom + ((Control)aP).Height > ((Control)Bil).Height - 10)
					{
						num += 220;
						num2 = 10;
					}
					else
					{
						num2 = ((Control)aP).Bottom;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		internal new void A(bool P_0)
		{
			if (P_0)
			{
				((Control)BiI).Left = 10;
				((Control)BiI).Top = 10;
				((Control)this).Controls.Add((Control)(object)BiI);
				((Control)Bii).Left = ((Control)BiI).Right + 40;
				((Control)Bii).Top = 6;
				((Control)this).Controls.Add((Control)(object)Bii);
				((Control)BiJ).Left = ((Control)Bii).Right + 1;
				((Control)BiJ).Top = 6;
				((Control)this).Controls.Add((Control)(object)BiJ);
				((Control)Bij).Left = ((Control)BiJ).Right + 3;
				((Control)Bij).Top = ((Control)BiJ).Top - 1;
				((Control)Bij).Height = ((Control)BiJ).Height + 2;
				((Control)this).Controls.Add((Control)(object)Bij);
				((Control)Bik).Left = ((Control)Bij).Right + 50;
				((Control)Bik).Top = 5;
				((Control)this).Controls.Add((Control)(object)Bik);
				((Control)Bil).SuspendLayout();
				((Control)Bil).Left = 10;
				((Control)Bil).Width = ((Control)this).Width - 20;
				((Control)Bil).Top = 33;
				((Control)Bil).Height = ((Control)this).Height - 10 - ((Control)Bil).Top;
				D();
				((Control)Bil).ResumeLayout(true);
				((Control)this).Controls.Add((Control)(object)Bil);
			}
			else
			{
				c();
			}
		}

		private bool A(Setting P_0)
		{
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
			string text = null;
			text = ((((SettingOrSpecialObject)P_0).D() == null || string.IsNullOrEmpty(((SettingOrSpecialObject)P_0).D().A(bz.aYt))) ? ((SettingOrSpecialObject)P_0).A(bz.aYt) : ((SettingOrSpecialObject)P_0).D().A(bz.aYt));
			string text2 = null;
			if (((SettingOrSpecialObject)P_0).D() != null && !string.IsNullOrEmpty(((SettingOrSpecialObject)P_0).D().A(bz.aYT)))
			{
				text2 = ((SettingOrSpecialObject)P_0).D().A(bz.aYT);
			}
			string text3 = null;
			if (!string.IsNullOrEmpty(((SettingOrSpecialObject)P_0).A(bz.aYT)))
			{
				text3 = ((SettingOrSpecialObject)P_0).A(bz.aYT);
			}
			string text4 = null;
			if (((SettingOrSpecialObject)P_0).D() != null && !string.IsNullOrEmpty(((SettingOrSpecialObject)P_0).D().A(bz.aYu)))
			{
				text4 = ((SettingOrSpecialObject)P_0).D().A(bz.aYu);
			}
			string text5 = null;
			if (!string.IsNullOrEmpty(((SettingOrSpecialObject)P_0).A(bz.aYu)))
			{
				text3 = ((SettingOrSpecialObject)P_0).A(bz.aYu);
			}
			string text6 = string.Empty;
			if (((SettingOrSpecialObject)P_0).D() != null)
			{
				text6 = ((SettingOrSpecialObject)P_0).D().H();
			}
			bool flag = true;
			if (((Control)BiJ).Text != string.Empty)
			{
				flag = false;
				string text7 = ((Control)BiJ).Text.ToLower();
				if (!string.IsNullOrEmpty(text))
				{
					string text8 = text.ToLower();
					flag = flag || text8.Contains(text7);
				}
				if (!string.IsNullOrEmpty(text2))
				{
					string text9 = text2.ToLower();
					flag = flag || text9.Contains(text7);
				}
				if (!string.IsNullOrEmpty(text3))
				{
					string text10 = text3.ToLower();
					flag = flag || text10.Contains(text7);
				}
				if (!string.IsNullOrEmpty(text4))
				{
					string text11 = text4.ToLower();
					flag = flag || text11.Contains(text7);
				}
				if (!string.IsNullOrEmpty(text5))
				{
					string text12 = text5.ToLower();
					flag = flag || text12.Contains(text7);
				}
				if (!string.IsNullOrWhiteSpace(text6))
				{
					string text13 = text6.ToLower();
					flag = flag || text13.Contains(text7);
				}
				Enumerator<string> enumerator;
				if (((SettingOrSpecialObject)P_0).D() != null)
				{
					enumerator = ((SettingOrSpecialObject)P_0).D().i().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							string text14 = enumerator.Current.ToLower();
							flag = flag || text14.Contains(text7);
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				enumerator = ((SettingOrSpecialObject)P_0).i().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string text15 = enumerator.Current.ToLower();
						flag = flag || text15.Contains(text7);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			return flag;
		}

		private void C(object P_0, EventArgs P_1)
		{
			((Control)BiJ).Text = string.Empty;
		}

		private void c(object P_0, EventArgs P_1)
		{
			if (!Bih)
			{
				BiK = ((Control)BiJ).Text;
				BiM.Stop();
				BiM.Start();
			}
		}

		private void A(object P_0, ThemedTextBox.B P_1)
		{
			if (!Bih)
			{
				BiK = ((Control)BiJ).Text;
				BiM.Stop();
				BiM.Start();
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			BiM.Stop();
			((ScrollableControl)Bil).AutoScrollPosition = new Point(0, 0);
			((Control)Bil).SuspendLayout();
			while (((ArrangedElementCollection)((Control)Bil).Controls).Count != 0)
			{
				q.A(((Control)Bil).Controls[0]);
			}
			D();
			((Control)Bil).ResumeLayout(true);
		}

		private void d(object P_0, EventArgs P_1)
		{
			if (!Bih)
			{
				BiL = ((ListControl)Bik).SelectedIndex;
				D(null, null);
			}
		}
	}
}
namespace C
{
	internal enum CI : byte
	{
		BaY = 0,
		Bay = 1,
		BaZ = 2,
		Baz = 3,
		BBA = 4,
		BBa = 5,
		BBB = 6,
		BBb = 7,
		BBC = 8,
		BBc = 9,
		BBD = 10,
		BBd = 11,
		BBE = 12,
		BBe = 13,
		BBF = 14,
		BBf = 15,
		BBG = 16,
		BBg = 17,
		BBH = 18,
		BBh = 19,
		BBI = 128,
		BBi = 129,
		BBJ = 130
	}
	internal enum Ci : byte
	{
		BBj,
		BBK,
		BBk,
		BBL,
		BBl,
		BBM,
		BBm,
		BBN,
		BBn,
		BBO,
		BBo,
		BBP,
		BBp,
		BBQ,
		BBq,
		BBR,
		BBr,
		BBS,
		BBs,
		BBT,
		BBt,
		BBU,
		BBu,
		BBV,
		BBv,
		BBW,
		BBw
	}
}
