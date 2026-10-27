using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Win32;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;

namespace A;

internal class X : Panel
{
	private Framework FG;

	private DataGridViewWithThemedScrollBars Fg;

	private Setting FH;

	private Setting Fh;

	private Setting FI;

	internal X(Framework P_0, DataGridViewWithThemedScrollBars P_1, Setting P_2, Setting P_3, Setting P_4)
	{
		FG = P_0;
		Fg = P_1;
		FH = P_2;
		Fh = P_3;
		FI = P_4;
		((Control)this).DoubleBuffered = true;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnPaint(e);
		Graphics graphics = e.Graphics;
		int num = FI.ax();
		Brush val = (Brush)((BM.Tn != 0 && BM.Tn != BM.r.Bqh) ? new SolidBrush(BM.td) : new SolidBrush(Color.Gray));
		graphics.FillRectangle(val, 0, 0, ((Control)this).Width, ((Control)this).Height);
		val.Dispose();
		if (num == 0)
		{
			return;
		}
		graphics.SmoothingMode = (SmoothingMode)2;
		Font val2 = new Font(((Control)this).Font.FontFamily, 9f, (FontStyle)1);
		StringFormat val3 = new StringFormat();
		val3.Alignment = (StringAlignment)2;
		StringFormat val4 = new StringFormat();
		val4.Alignment = (StringAlignment)1;
		Pen val5 = new Pen(Color.White, 3f);
		int num2 = 2147483647;
		int num3 = -2147483648;
		for (int num4 = 0; num4 < num; num4++)
		{
			int num5 = Fh.m(num4);
			if (num5 < num2)
			{
				num2 = num5;
			}
			if (num5 > num3)
			{
				num3 = num5;
			}
		}
		int num6 = 18;
		if (num2 == 0 && num3 == 1000)
		{
			num6 = 11;
		}
		float num7 = ((float)((Control)this).Height - 50f) / (float)(num6 - 1);
		int num8 = Fh.aS();
		for (int num9 = 0; num9 < num6; num9++)
		{
			int num10 = ((num9 != 0) ? ((num9 != num6 - 1) ? (num2 + (num3 - num2) * num9 / (num6 - 1)) : num3) : num2);
			string text = bS.a(num10, num8, -1);
			float num11 = (float)(((Control)this).Height - 35) - num7 * (float)num9;
			graphics.DrawString(text, val2, Brushes.White, 60f, num11 - 7f, val3);
			graphics.DrawLine(Pens.LightGray, 65f, num11, (float)(((Control)this).Width - 10), num11);
		}
		graphics.DrawLine(Pens.White, 65, 15, 65, ((Control)this).Height - 35);
		int num12 = FH.m(0);
		int num13 = FH.m(num - 1);
		int num14 = FH.aS();
		float num15 = 0f;
		float num16 = 0f;
		float num17 = 0f;
		for (int num18 = 0; num18 < num; num18++)
		{
			int num19 = FH.m(num18);
			string text2 = bS.a(num19, num14, -1);
			float num20 = ((num13 - num12 != 0) ? (75f + (float)((num19 - num12) * (((Control)this).Width - 105)) / (float)(num13 - num12)) : 75f);
			graphics.DrawLine(Pens.White, num20, (float)(((Control)this).Height - 28), num20, (float)(((Control)this).Height - 22));
			SizeF val6 = graphics.MeasureString(text2, val2);
			float num21 = ((SizeF)(ref val6)).Width / 2f;
			if (num18 == 0 || num20 - num21 > num17 + 5f)
			{
				graphics.DrawString(text2, val2, Brushes.White, num20, (float)(((Control)this).Height - 20), val4);
				num17 = num20 + num21;
			}
			int num22 = Fh.m(num18);
			float num23 = ((num3 - num2 != 0) ? ((float)(((Control)this).Height - 35) - (float)((num22 - num2) * (((Control)this).Height - 50)) / (float)(num3 - num2)) : ((float)(((Control)this).Height - 35)));
			if ((((BaseCollection)((DataGridView)Fg).Rows[0].Cells).Count > num18 && ((DataGridView)Fg).Rows[0].Cells[num18].Selected) || (((BaseCollection)((DataGridView)Fg).Rows[1].Cells).Count > num18 && ((DataGridView)Fg).Rows[1].Cells[num18].Selected))
			{
				graphics.DrawEllipse(val5, num20 - 4f, num23 - 4f, 8f, 8f);
			}
			else
			{
				graphics.DrawEllipse(val5, num20 - 2f, num23 - 2f, 4f, 4f);
			}
			if (num18 != 0)
			{
				graphics.DrawLine(Pens.White, num15, num16, num20, num23);
			}
			num15 = num20;
			num16 = num23;
		}
		val2.Dispose();
		val5.Dispose();
	}
}
internal class x : UserControl
{
	internal const string FJ = "https://support.haltech.com/";

	internal const string Fj = "https://support.haltech.com/portal/en/kb/articles/";

	private ThemedButton FK = new ThemedButton();

	private ThemedButton Fk = new ThemedButton();

	private ThemedButton FL = new ThemedButton();

	private ThemedButton Fl = new ThemedButton();

	private ThemedButton FM = new ThemedButton();

	private ThemedTextBox Fm = new ThemedTextBox();

	private PictureBox FN = new PictureBox();

	private ThemedButton Fn = new ThemedButton();

	private TreeViewWithThemedScrollBars FO = new TreeViewWithThemedScrollBars();

	private bool Fo;

	private const int FP = 10;

	private bool Fp;

	private int FQ;

	private int Fq;

	private IContainer FR;

	private TableLayoutPanel Fr;

	private TableLayoutPanel FS;

	private WebView2 Fs;

	private Timer FT;

	private Panel Ft;

	private LocalHelpFramework A()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		LocalHelpFramework result = null;
		string text = BM.Qw + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EN();
		if (File.Exists(text))
		{
			try
			{
				XmlSerializer val = new XmlSerializer(typeof(LocalHelpFramework));
				StreamReader val2 = new StreamReader(text);
				try
				{
					result = (LocalHelpFramework)val.Deserialize((TextReader)(object)val2);
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.En() + ex.Message, true);
			}
		}
		return result;
	}

	internal x()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		f();
		Fs.CreationProperties = new CoreWebView2CreationProperties
		{
			UserDataFolder = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EO()
		};
		((Control)this).Dock = (DockStyle)5;
		FO.A(new TreeViewEventHandler(A));
		((Control)Ft).BackColor = BM.tE;
		((Control)FK).AutoSize = false;
		((Control)FK).Width = 160;
		((Control)FK).Height = 24;
		((Control)FK).Click += new EventHandler(d);
		((Control)Fk).Left = ((Control)FK).Right + 10;
		((Control)Fk).AutoSize = false;
		((Control)Fk).Width = 100;
		((Control)Fk).Height = 24;
		((Control)Fk).Click += new EventHandler(E);
		((Control)Fk).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Eo();
		((Control)FL).Left = ((Control)Fk).Right + 10;
		((Control)FL).AutoSize = false;
		((Control)FL).Width = 70;
		((Control)FL).Height = 24;
		((ButtonBase)FL).ImageAlign = (ContentAlignment)32;
		((ButtonBase)FL).Image = BM.tR;
		((Control)FL).Click += new EventHandler(a);
		((Control)FL).Enabled = false;
		((Control)Fl).Left = ((Control)FL).Right + 1;
		((Control)Fl).AutoSize = false;
		((Control)Fl).Width = 70;
		((Control)Fl).Height = 24;
		((ButtonBase)Fl).ImageAlign = (ContentAlignment)32;
		((ButtonBase)Fl).Image = BM.tr;
		((Control)Fl).Click += new EventHandler(B);
		((Control)Fl).Enabled = false;
		((Control)FN).Left = ((Control)Fl).Right + 10;
		((Control)FN).BackColor = BM.tE;
		if (FN.Image != null)
		{
			FN.Image.Dispose();
		}
		FN.Image = (Image)(object)O.A((Image)(object)GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		((Control)FN).Width = 24;
		((Control)FN).Height = 24;
		((Control)Fm).Left = ((Control)FN).Right + 1;
		((Control)Fm).Width = 200;
		((Control)Fm).Top = 2;
		((Control)Fm).Enabled = false;
		((Control)Fm).KeyPress += new KeyPressEventHandler(A);
		((Control)Fm).TextChanged += new EventHandler(C);
		Fm.A(A);
		((Control)Fn).Left = ((Control)Fm).Right + 1;
		((Control)Fn).Enabled = false;
		((Control)Fn).Click += new EventHandler(b);
		((Control)Fn).Width = 30;
		((Control)Fn).Height = 24;
		((Control)Fn).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Di();
		((Control)Fn).Font = new Font(((Control)Fn).Font.FontFamily, 8f, (FontStyle)1);
		((Control)FM).AutoSize = false;
		((Control)FM).Width = 170;
		((Control)FM).Height = 24;
		((Control)FM).Click += new EventHandler(e);
		((Control)FM).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EP();
		((Control)FM).Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ep();
		F();
		((Control)Ft).Controls.Add((Control)(object)FK);
		((Control)Ft).Controls.Add((Control)(object)Fk);
		((Control)Ft).Controls.Add((Control)(object)FL);
		((Control)Ft).Controls.Add((Control)(object)Fl);
		((Control)Ft).Controls.Add((Control)(object)FN);
		((Control)Ft).Controls.Add((Control)(object)Fm);
		((Control)Ft).Controls.Add((Control)(object)Fn);
		((Control)Ft).Controls.Add((Control)(object)FM);
		FS.Controls.Add((Control)(object)FO, 0, 0);
		((Control)FO).Width = (int)FS.ColumnStyles[0].Width - 10;
		((Control)FO).Height = ((Control)FS).Height - 10;
		C();
	}

	internal void a()
	{
		((Control)Ft).Visible = false;
		((Control)Ft).Dock = (DockStyle)0;
		((Control)Ft).Height = 0;
		((TableLayoutStyleCollection)Fr.RowStyles).RemoveAt(0);
		((Control)FS).Height = ((Control)this).Height;
	}

	internal void B()
	{
		((Control)FS).Height = ((Control)this).Height - ((Control)Ft).Height;
		((Control)FM).Left = ((Control)Ft).Right - ((Control)FM).Width;
		((Control)FO).Height = ((Control)FS).Height - 10;
	}

	internal void A(Uri P_0)
	{
		try
		{
			if (Fs.Source == (Uri)null || Fo || Path.GetFullPath(Fs.Source.AbsolutePath) != Path.GetFullPath(P_0.AbsolutePath))
			{
				Fo = P_0.AbsoluteUri == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EQ();
				Fs.Source = P_0;
			}
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Eq() + ex.Message, true);
		}
	}

	internal void A(string P_0)
	{
		if (!string.IsNullOrEmpty(P_0))
		{
			((Control)FM).Tag = P_0;
		}
		else
		{
			((Control)FM).Tag = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ep();
		}
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		if (!(((Control)this).Parent is aF) && (int)P_1.Button == 1048576 && P_1.X > ((Control)FO).Right - 1 && P_1.X < ((Control)FO).Right + 4)
		{
			FQ = P_1.X;
			Fq = (int)FS.ColumnStyles[0].Width;
			Fp = true;
		}
	}

	private void a(object P_0, MouseEventArgs P_1)
	{
		if (((Control)this).Parent is aF)
		{
			return;
		}
		if (Fp)
		{
			int num = P_1.X - FQ;
			FS.ColumnStyles[0].Width = Math.Max(Fq + num, 100);
			if (((Control)Fs).Width > ((Control)FS).Width - ((Control)Fs).Left)
			{
				((Control)Fs).Width = ((Control)FS).Width - ((Control)Fs).Left;
			}
			((Control)FO).Width = (int)FS.ColumnStyles[0].Width - 10;
			((Control)this).Refresh();
		}
		if (P_1.X > ((Control)FO).Right - 1 && P_1.X < ((Control)FO).Right + 4)
		{
			((Control)this).Cursor = Cursors.SizeWE;
		}
		else
		{
			((Control)this).Cursor = Cursors.Default;
		}
	}

	private void B(object P_0, MouseEventArgs P_1)
	{
		Fp = false;
	}

	private void A(object P_0, EventArgs P_1)
	{
		((Control)this).Cursor = Cursors.Default;
	}

	private void a(object P_0, EventArgs P_1)
	{
		Fs.GoBack();
	}

	private void B(object P_0, EventArgs P_1)
	{
		Fs.GoForward();
	}

	private void b(object P_0, EventArgs P_1)
	{
		((Control)Fm).Text = string.Empty;
	}

	private void A(object P_0, KeyPressEventArgs P_1)
	{
		FT.Stop();
		FT.Start();
	}

	private void C(object P_0, EventArgs P_1)
	{
		FT.Stop();
		FT.Start();
	}

	private void A(object P_0, ThemedTextBox.B P_1)
	{
		FT.Stop();
		FT.Start();
	}

	private void c(object P_0, EventArgs P_1)
	{
		FT.Stop();
		((Control)this).Cursor = Cursors.WaitCursor;
		if (((Control)Fm).Text == string.Empty)
		{
			C();
		}
		else
		{
			b();
		}
		((Control)this).Cursor = Cursors.Default;
	}

	private void b()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		FO.a().Clear();
		LocalHelpFramework localHelpFramework = A();
		if (localHelpFramework == null)
		{
			return;
		}
		List<string> val = new List<string>();
		if (((Control)Fm).Text != string.Empty)
		{
			string[] array = ((Control)Fm).Text.Split(RuntimeHelpers.CreateSpan<char>((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/));
			for (int num = 0; num < array.Length; num++)
			{
				val.Add(array[num].ToLower());
			}
		}
		FO.b();
		Enumerator<LocalCategory> enumerator = localHelpFramework.RootCategories.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				LocalCategory current = enumerator.Current;
				A(current, val);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		FO.C();
	}

	private string A(LocalArticle P_0)
	{
		return (BM.Qw + P_0.LocalURL).Replace('\\', '/');
	}

	private void A(LocalCategory P_0, List<string> P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<LocalCategory> enumerator = P_0.ChildCategories.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				LocalCategory current = enumerator.Current;
				A(current, P_1);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		Enumerator<LocalArticle> enumerator2 = P_0.Articles.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				LocalArticle current2 = enumerator2.Current;
				A(current2, P_1);
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
	}

	private void A(LocalArticle P_0, List<string> P_1)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		if (File.Exists(A(P_0)))
		{
			Enumerator<string> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (P_0.Name.ToLower().Contains(current))
					{
						continue;
					}
					try
					{
						string text = File.ReadAllText(A(P_0));
						if (!string.IsNullOrEmpty(text))
						{
							if (text.ToLower().Contains(current))
							{
								continue;
							}
							flag = false;
						}
						else
						{
							flag = false;
						}
					}
					catch
					{
						flag = false;
					}
					break;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		else
		{
			flag = false;
		}
		if (flag)
		{
			TreeNode val = new TreeNode(P_0.Name);
			val.Tag = P_0;
			val.ForeColor = BM.te;
			FO.a().Add(val);
		}
	}

	private void C()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		FO.a().Clear();
		LocalHelpFramework localHelpFramework = A();
		if (localHelpFramework != null)
		{
			FO.b();
			Enumerator<LocalCategory> enumerator = localHelpFramework.RootCategories.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					LocalCategory current = enumerator.Current;
					A(current, (TreeNode)null);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			FO.C();
			((Control)Fm).Enabled = true;
			((Control)Fn).Enabled = true;
		}
		else
		{
			d();
			Uri val;
			try
			{
				val = new Uri(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ep());
			}
			catch
			{
				val = null;
			}
			if (val != (Uri)null)
			{
				A(val);
			}
		}
	}

	private void A(LocalCategory P_0, TreeNode P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		TreeNode val = new TreeNode(P_0.Name);
		val.Tag = null;
		val.ForeColor = BM.te;
		if (P_1 == null)
		{
			FO.a().Add(val);
		}
		else
		{
			P_1.Nodes.Add(val);
		}
		Enumerator<LocalCategory> enumerator = P_0.ChildCategories.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				LocalCategory current = enumerator.Current;
				A(current, val);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		Enumerator<LocalArticle> enumerator2 = P_0.Articles.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				LocalArticle current2 = enumerator2.Current;
				A(current2, val);
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
	}

	private void A(LocalArticle P_0, TreeNode P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		TreeNode val = new TreeNode(P_0.Name);
		val.Tag = P_0;
		val.ForeColor = BM.te;
		if (P_1 == null)
		{
			FO.a().Add(val);
		}
		else
		{
			P_1.Nodes.Add(val);
		}
	}

	private void A(object P_0, TreeViewEventArgs P_1)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		if (!(P_1.Node.Tag is LocalArticle))
		{
			return;
		}
		string text = A(P_1.Node.Tag as LocalArticle);
		Uri val = null;
		if (File.Exists(text))
		{
			try
			{
				val = new Uri(text);
			}
			catch
			{
				val = null;
			}
		}
		if (val == (Uri)null)
		{
			try
			{
				val = new Uri(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ER() + Path.GetFileNameWithoutExtension(text));
			}
			catch
			{
				val = null;
			}
		}
		if (val != (Uri)null)
		{
			A(val);
		}
		A((P_1.Node.Tag as LocalArticle).OnlineURL);
	}

	private void c()
	{
		A(Path.GetFullPath(Fs.Source.AbsolutePath), FO.a());
		((Control)FL).Enabled = Fs.CanGoBack;
		((Control)Fl).Enabled = Fs.CanGoForward;
	}

	private void A(object P_0, CoreWebView2NavigationStartingEventArgs P_1)
	{
		c();
	}

	private void A(object P_0, CoreWebView2NavigationCompletedEventArgs P_1)
	{
		c();
	}

	private void A(string P_0, List<TreeNode> P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		Enumerator<TreeNode> enumerator = P_1.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				TreeNode current = enumerator.Current;
				if (current.Tag != null && current.Tag is LocalArticle)
				{
					if (Path.GetFullPath(A(current.Tag as LocalArticle)) == P_0)
					{
						FO.A(current);
						break;
					}
					continue;
				}
				List<TreeNode> val = new List<TreeNode>();
				foreach (TreeNode node in current.Nodes)
				{
					TreeNode val2 = node;
					val.Add(val2);
				}
				A(P_0, val);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	internal static string D()
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		RegistryKey val = Registry.CurrentUser.OpenSubKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Er(), false);
		try
		{
			string text = val.GetValue(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ES()).ToString();
			RegistryKey val2 = Registry.ClassesRoot.OpenSubKey(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Es(), false);
			try
			{
				string text2 = (string)val2.GetValue(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
				Match val3 = new Regex(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ET()).Match(text2);
				return ((Group)val3).Success ? ((Capture)val3).Value : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
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

	internal void d()
	{
		if (((Control)this).Parent is aF)
		{
			e();
			((Control)Fk).Visible = false;
			((Control)FL).Visible = false;
			((Control)Fl).Visible = false;
			((Control)FN).Visible = false;
			((Control)Fm).Visible = false;
			((Control)Fn).Visible = false;
			((Control)FM).Visible = false;
			((Control)FK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Et();
			return;
		}
		if (A() != null)
		{
			E();
			((Control)Fk).Visible = true;
			((Control)FN).Visible = true;
			((Control)Fm).Visible = true;
			((Control)Fn).Visible = true;
		}
		else
		{
			e();
			((Control)Fk).Visible = false;
			((Control)FN).Visible = false;
			((Control)Fm).Visible = false;
			((Control)Fn).Visible = false;
		}
		((Control)FL).Visible = true;
		((Control)Fl).Visible = true;
		((Control)FM).Visible = true;
		((Control)FK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EU();
	}

	private void E()
	{
		TableLayoutColumnStyleCollection columnStyles = FS.ColumnStyles;
		if (columnStyles[0].Width == 0f)
		{
			columnStyles[0].Width = 250f;
		}
		((Control)FO).Width = (int)columnStyles[0].Width - 10;
		((Control)Fs).Width = ((Control)FS).Width - ((Control)Fs).Left;
		((Control)this).Refresh();
		((Control)FO).Visible = true;
	}

	private void e()
	{
		TableLayoutColumnStyleCollection columnStyles = FS.ColumnStyles;
		if (columnStyles[0].Width > 0f)
		{
			columnStyles[0].Width = 0f;
		}
		((Control)Fs).Width = ((Control)FS).Width - ((Control)Fs).Left;
		((Control)this).Refresh();
		((Control)FO).Visible = false;
	}

	private void D(object P_0, EventArgs P_1)
	{
		((Control)Fs).Width = ((Control)FS).Width - ((Control)Fs).Left;
		((Control)this).Refresh();
	}

	private void d(object P_0, EventArgs P_1)
	{
		BM.QQ.r();
		if (BM.sI)
		{
			((Control)FK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Et();
		}
		else
		{
			((Control)FK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EU();
		}
	}

	private void E(object P_0, EventArgs P_1)
	{
		TableLayoutColumnStyleCollection columnStyles = FS.ColumnStyles;
		if (columnStyles[0].Width == 0f)
		{
			columnStyles[0].Width = 250f;
			((Control)FO).Width = (int)columnStyles[0].Width - 10;
		}
		else
		{
			columnStyles[0].Width = 0f;
		}
		((Control)Fs).Width = ((Control)FS).Width - ((Control)Fs).Left;
		((Control)this).Refresh();
	}

	private void e(object P_0, EventArgs P_1)
	{
		try
		{
			string text = D();
			string text2 = ((Control)FM).Tag as string;
			Process.Start(text, text2);
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Eu() + ex.Message, true);
		}
	}

	private void F(object P_0, EventArgs P_1)
	{
		B();
	}

	private void A(TreeNode P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		P_0.ForeColor = BM.te;
		foreach (TreeNode node in P_0.Nodes)
		{
			TreeNode val = node;
			A(val);
		}
	}

	internal void F()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		((Control)Ft).BackColor = BM.tE;
		((Control)FO).BackColor = BM.tg;
		((Control)FO).ForeColor = BM.te;
		((Control)Fm).BackColor = BM.to;
		((Control)Fm).ForeColor = BM.te;
		((ButtonBase)FL).Image = BM.tR;
		((ButtonBase)Fl).Image = BM.tr;
		((Control)FN).BackColor = BM.tE;
		if (FN.Image != null)
		{
			FN.Image.Dispose();
		}
		FN.Image = (Image)(object)O.A((Image)(object)GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		Enumerator<TreeNode> enumerator = FO.a().GetEnumerator();
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
		((Control)this).Refresh();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && FR != null)
		{
			((System.IDisposable)FR).Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void f()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		FR = (IContainer)new Container();
		Fr = new TableLayoutPanel();
		FS = new TableLayoutPanel();
		Fs = new WebView2();
		FT = new Timer(FR);
		Ft = new Panel();
		((Control)Fr).SuspendLayout();
		((Control)FS).SuspendLayout();
		((Control)this).SuspendLayout();
		Fr.ColumnCount = 1;
		Fr.ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		Fr.Controls.Add((Control)(object)FS, 0, 1);
		Fr.Controls.Add((Control)(object)Ft, 0, 0);
		((Control)Fr).Dock = (DockStyle)5;
		((Control)Fr).Location = new Point(0, 0);
		((Control)Fr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EV();
		Fr.RowCount = 2;
		Fr.RowStyles.Add(new RowStyle((SizeType)1, 25f));
		Fr.RowStyles.Add(new RowStyle());
		Fr.RowStyles.Add(new RowStyle((SizeType)1, 20f));
		((Control)Fr).Size = new Size(1000, 600);
		((Control)Fr).TabIndex = 1;
		((Panel)FS).AutoSizeMode = (AutoSizeMode)0;
		FS.CellBorderStyle = (TableLayoutPanelCellBorderStyle)1;
		FS.ColumnCount = 2;
		FS.ColumnStyles.Add(new ColumnStyle((SizeType)1, 250f));
		FS.ColumnStyles.Add(new ColumnStyle());
		FS.Controls.Add((Control)(object)Fs, 1, 0);
		((Control)FS).Dock = (DockStyle)5;
		((Control)FS).Location = new Point(1, 26);
		((Control)FS).Margin = new Padding(1);
		((Control)FS).MinimumSize = new Size(200, 200);
		((Control)FS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ev();
		FS.RowCount = 1;
		FS.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		((Control)FS).Size = new Size(998, 573);
		((Control)FS).TabIndex = 1;
		((Control)FS).SizeChanged += new EventHandler(D);
		((Control)FS).MouseDown += new MouseEventHandler(A);
		((Control)FS).MouseLeave += new EventHandler(A);
		((Control)FS).MouseMove += new MouseEventHandler(a);
		((Control)FS).MouseUp += new MouseEventHandler(B);
		Fs.AllowExternalDrop = false;
		((Control)Fs).Dock = (DockStyle)5;
		((Control)Fs).Location = new Point(255, 4);
		((Control)Fs).MinimumSize = new Size(20, 20);
		((Control)Fs).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EW();
		((Control)Fs).Size = new Size(739, 565);
		((Control)Fs).TabIndex = 1;
		Fs.NavigationStarting += A;
		Fs.NavigationCompleted += A;
		FT.Interval = 400;
		FT.Tick += new EventHandler(c);
		((Control)Ft).Dock = (DockStyle)5;
		((Control)Ft).Location = new Point(0, 0);
		((Control)Ft).Margin = new Padding(0);
		((Control)Ft).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ew();
		((Control)Ft).Size = new Size(1000, 25);
		((Control)Ft).TabIndex = 2;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((UserControl)this).AutoSizeMode = (AutoSizeMode)0;
		((Control)this).Controls.Add((Control)(object)Fr);
		((Control)this).Margin = new Padding(0);
		((Control)this).MinimumSize = new Size(200, 200);
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EX();
		((Control)this).Size = new Size(1000, 600);
		((Control)this).Resize += new EventHandler(F);
		((Control)Fr).ResumeLayout(false);
		((Control)FS).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
