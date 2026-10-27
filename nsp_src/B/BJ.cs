using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using NSP.SettingsFramework;
using NSP.UserInterface;
using NexusUpdaterAWS;
using a;
using b;
using c;

namespace B
{
	internal class BJ : Form
	{
		private IContainer Pv;

		private Timer PW;

		internal BJ()
		{
			A();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)P_1.CloseReason == 3)
			{
				((CancelEventArgs)P_1).Cancel = true;
				((Control)this).Hide();
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Invalid comparison between Unknown and I4
			if ((int)keyData == 112 && ((Control)this).Visible)
			{
				((Control)this).Hide();
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && Pv != null)
			{
				((System.IDisposable)Pv).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void A()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			Pv = (IContainer)new Container();
			PW = new Timer(Pv);
			((Control)this).SuspendLayout();
			PW.Interval = 400;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(984, 562);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)this).MinimumSize = new Size(200, 200);
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LQ();
			((Form)this).ShowIcon = false;
			((Form)this).StartPosition = (FormStartPosition)0;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lq();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)this).ResumeLayout(false);
		}
	}
	internal class Bj : Form
	{
		private enum A : byte
		{
			BPr = 1,
			BPS = 2,
			BPs = 4,
			BPT = 8
		}

		private Framework Pw;

		private Framework PX;

		private bool Px;

		private HashSet<DataIdAndAttrId> PY = new HashSet<DataIdAndAttrId>();

		private HashSet<DataIdAndAttrId> Py = new HashSet<DataIdAndAttrId>();

		private List<TreeNode> PZ = new List<TreeNode>();

		private bool Pz;

		private bool pA;

		private bool pa;

		private TreeNode pB;

		private bool pb;

		private string pC = string.Empty;

		private string pc = string.Empty;

		private IContainer pD;

		private ThemedButton pd;

		private ThemedButton pE;

		private Label pe;

		private Label pF;

		private Label pf;

		private TreeViewWithThemedScrollBars pG;

		private TreeViewWithThemedScrollBars pg;

		private Label pH;

		private Label ph;

		private Label pI;

		private ThemedButton pi;

		private ThemedButton pJ;

		private ThemedButton pj;

		internal Bj()
		{
			D();
		}

		internal Bj(string P_0, bool P_1, bool P_2, Framework P_3, Framework P_4)
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0364: Unknown result type (might be due to invalid IL or missing references)
			//IL_036e: Expected O, but got Unknown
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0385: Expected O, but got Unknown
			//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
			D();
			Pw = P_3;
			PX = P_4;
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label)
				{
					((val is Label) ? val : null).ForeColor = BM.te;
				}
				if (val is TreeViewWithThemedScrollBars)
				{
					((Control)(val as TreeViewWithThemedScrollBars)).BackColor = BM.tg;
					((Control)(val as TreeViewWithThemedScrollBars)).ForeColor = BM.te;
				}
			}
			Pz = Pw.B() && Pw.b();
			pA = PX.B() && PX.b();
			pa = (!Pz && !pA) || (Pz && pA && Pw.A(PX));
			Px = P_1;
			if (P_1)
			{
				((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FP();
				if (P_2)
				{
					((Control)pF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LR();
				}
				else
				{
					((Control)pF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lr();
				}
				((Control)pG).Width = ((Control)pg).Right - ((Control)pG).Left;
				((Control)pg).Visible = false;
				((Control)pH).Visible = false;
				((Control)pe).Visible = false;
				((Control)pf).Visible = false;
				((Control)ph).Visible = false;
			}
			else
			{
				((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LS();
				if (P_2)
				{
					((Control)pF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LR();
				}
				else
				{
					((Control)pF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ls();
				}
				((Control)pg).Visible = !P_2;
				((Control)pH).Visible = !P_2;
				((Control)pe).Visible = true;
				if (string.IsNullOrEmpty(P_0))
				{
					((Control)pe).Text = string.Empty;
				}
				else
				{
					((Control)pe).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LT() + P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
				}
				((Control)pf).Visible = true;
				((Control)pf).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lt() + ((object)Pw).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
				if (Pw.B() && Pw.b() && !pa)
				{
					Label obj = pf;
					((Control)obj).Text = ((Control)obj).Text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LU();
				}
				((Control)ph).Visible = true;
				((Control)ph).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lu() + ((object)PX).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
				if (PX.B() && PX.b() && !pa)
				{
					Label obj2 = ph;
					((Control)obj2).Text = ((Control)obj2).Text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LU();
				}
			}
			BM.C(new EventHandler(A));
			pG.A(new DrawTreeNodeEventHandler(A));
			A(P_2);
			A();
			a();
			B();
			Enumerator<TreeNode> enumerator2 = PZ.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					TreeNode current = enumerator2.Current;
					A(current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			A(pG.a());
			if (pG.a().Count == 0)
			{
				((Control)pi).Visible = false;
				((Control)pJ).Visible = false;
				if (Px && pA)
				{
					((Control)pd).Visible = false;
					((Control)pG).Visible = false;
					((Control)pF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LV();
				}
			}
			else
			{
				((Control)pi).Enabled = !P_2;
				((Control)pJ).Enabled = !P_2;
			}
			if (Px)
			{
				((Control)pd).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lv();
				((Control)pj).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LW();
			}
			if (!pa && !Px)
			{
				((Control)pj).Enabled = false;
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			((Form)this).DialogResult = (DialogResult)3;
			((Form)this).Close();
		}

		private void A(TreeNode P_0, ref byte P_1)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			if (!P_0.Checked)
			{
				P_1 |= 1;
			}
			else if (P_0.ForeColor == BM.te)
			{
				P_1 |= 2;
			}
			else if (P_0.ForeColor == Color.Orange)
			{
				P_1 |= 4;
			}
			else if (P_0.ForeColor == Color.Gray)
			{
				P_1 |= 8;
			}
			foreach (TreeNode node in P_0.Nodes)
			{
				TreeNode val = node;
				A(val, ref P_1);
			}
		}

		private void A(object P_0, DrawTreeNodeEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0242: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			Rectangle bounds = P_1.Bounds;
			if (((Rectangle)(ref bounds)).Y < -10)
			{
				return;
			}
			bounds = P_1.Bounds;
			if (((Rectangle)(ref bounds)).Y > ((Control)pG).Height)
			{
				return;
			}
			Font font = ((Control)pG).Font;
			SolidBrush val = new SolidBrush(((Control)pG).BackColor);
			try
			{
				Graphics graphics = P_1.Graphics;
				bounds = P_1.Bounds;
				int right = ((Rectangle)(ref bounds)).Right;
				bounds = P_1.Bounds;
				int top = ((Rectangle)(ref bounds)).Top;
				int width = ((Control)pG).Width;
				bounds = P_1.Bounds;
				int num = width - ((Rectangle)(ref bounds)).Right;
				bounds = P_1.Bounds;
				graphics.FillRectangle((Brush)(object)val, right, top, num, ((Rectangle)(ref bounds)).Height);
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
			bounds = P_1.Bounds;
			int top2 = ((Rectangle)(ref bounds)).Top;
			int num2 = ((Control)pG).Width - 530;
			bounds = P_1.Bounds;
			Rectangle val2 = default(Rectangle);
			((Rectangle)(ref val2))._002Ector(530, top2, num2, ((Rectangle)(ref bounds)).Height);
			if (P_1.Node.Checked)
			{
				byte b = 0;
				A(P_1.Node, ref b);
				bool flag = b != 0 && b != 1 && b != 2 && b != 4 && b != 8;
				if (P_1.Node.ForeColor == BM.te)
				{
					if (flag)
					{
						TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lw(), font, val2, P_1.Node.ForeColor, (TextFormatFlags)0);
					}
					else
					{
						TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LX(), font, val2, P_1.Node.ForeColor, (TextFormatFlags)0);
					}
				}
				else if (P_1.Node.ForeColor == Color.Orange)
				{
					if (flag)
					{
						TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lw(), font, val2, P_1.Node.ForeColor, (TextFormatFlags)0);
					}
					else
					{
						TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lx(), font, val2, P_1.Node.ForeColor, (TextFormatFlags)0);
					}
				}
				else
				{
					TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LY(), font, val2, Color.Gray, (TextFormatFlags)0);
				}
			}
			else if (TreeViewWithThemedScrollBars.c(P_1.Node))
			{
				TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lw(), font, val2, BM.te, (TextFormatFlags)0);
			}
			else if ((P_1.State & 1) != 0)
			{
				TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ly(), font, val2, BM.te, (TextFormatFlags)0);
			}
			else
			{
				TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ly(), font, val2, Color.Gray, (TextFormatFlags)0);
			}
		}

		private void A(TreeNode P_0)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			TreeNode val = P_0;
			bool flag = false;
			do
			{
				val.ForeColor = BM.te;
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
		}

		private void a(TreeNode P_0)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			TreeNode val = P_0;
			bool flag = false;
			do
			{
				if (val.ForeColor != BM.te)
				{
					val.ForeColor = Color.Orange;
				}
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
		}

		private void A(bool P_0)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			pG.b();
			HashSet<DataIdAndAttrId> val = new HashSet<DataIdAndAttrId>();
			A(val, P_0);
			Enumerator<MenuNode> enumerator = PX.awj.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					MenuNode current = enumerator.Current;
					A(current, null, val, P_0);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			pG.C();
			pG.I();
			pG.a(!P_0);
		}

		private void A(HashSet<DataIdAndAttrId> P_0, bool P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			TreeNode val = new TreeNode(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LZ());
			if (P_1)
			{
				val.Checked = true;
			}
			val.ForeColor = Color.Gray;
			List<int> val2 = new List<int>();
			val2.Add(1501);
			val2.Add(1502);
			val2.Add(3800);
			for (int i = 0; i < val2.Count; i++)
			{
				int num = val2[i];
				Setting setting = PX.A(num);
				if (setting == null || setting.D())
				{
					continue;
				}
				TreeNode val3 = new TreeNode(((SettingOrSpecialObject)setting).A(true));
				if (P_1)
				{
					val3.Checked = true;
				}
				val3.ForeColor = Color.Gray;
				val3.Tag = setting;
				Setting setting2 = Pw.A(num);
				if (pa || ((!pA || !setting.J()) && (!Pz || (setting2 != null && !setting2.J()))))
				{
					val.Nodes.Add(val3);
					PY.Add(new DataIdAndAttrId(num));
					P_0.Add(new DataIdAndAttrId(num));
					if (setting2 != null && !setting.A(setting2))
					{
						PZ.Add(val3);
					}
				}
			}
			if (val.Nodes.Count != 0)
			{
				val.Expand();
				pG.a().Add(val);
				pB = val;
			}
		}

		private void A(MenuNode P_0, TreeNode P_1, HashSet<DataIdAndAttrId> P_2, bool P_3)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected O, but got Unknown
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0713: Unknown result type (might be due to invalid IL or missing references)
			//IL_0718: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0315: Unknown result type (might be due to invalid IL or missing references)
			//IL_031c: Expected O, but got Unknown
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ba: Expected O, but got Unknown
			//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0489: Unknown result type (might be due to invalid IL or missing references)
			//IL_0490: Expected O, but got Unknown
			//IL_049e: Unknown result type (might be due to invalid IL or missing references)
			//IL_066f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0676: Expected O, but got Unknown
			//IL_0684: Unknown result type (might be due to invalid IL or missing references)
			string text = P_0.E();
			int num = P_0.b();
			int num2 = P_0.H();
			TreeNode val = new TreeNode(text);
			if (P_3)
			{
				val.Checked = true;
			}
			val.Tag = P_0;
			val.ForeColor = Color.Gray;
			SettingOrSpecialObject settingOrSpecialObject = PX.a(num);
			SettingOrSpecialObject settingOrSpecialObject2 = PX.a(num2);
			if (settingOrSpecialObject != null && (settingOrSpecialObject.J().Count != 0 || settingOrSpecialObject.K().A().Count != 0))
			{
				return;
			}
			if (P_0.h() != 0)
			{
				Setting setting = PX.A(P_0.h());
				if (setting != null)
				{
					if (setting.am() && setting.ax() != 1)
					{
						return;
					}
					Setting setting2 = Pw.A(setting.A());
					if ((pa || ((!pA || !setting.J()) && (!Pz || (setting2 != null && !setting2.J())))) && !P_2.Contains(setting.C()))
					{
						TreeNode val2 = new TreeNode(((SettingOrSpecialObject)setting).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lz());
						if (P_3)
						{
							val2.Checked = true;
						}
						val2.ForeColor = Color.Gray;
						val2.Tag = setting;
						val.Nodes.Add(val2);
						PY.Add(setting.C());
						P_2.Add(setting.C());
						if (setting2 != null && !setting.A(setting2))
						{
							PZ.Add(val2);
						}
					}
				}
			}
			Enumerator<MenuNode> enumerator = P_0.c().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					MenuNode current = enumerator.Current;
					A(current, val, P_2, P_3);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (A(P_0, val, settingOrSpecialObject, settingOrSpecialObject2))
			{
				return;
			}
			if (P_0.C() != null && P_0.C().h() == 0 && settingOrSpecialObject is SpecialObject && (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.Count != 0)
			{
				bool flag = true;
				Enumerator<UIListSettingDataIdAndIndent> enumerator2 = (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						UIListSettingDataIdAndIndent current2 = enumerator2.Current;
						if (!PX.aWZ.Contains(current2.DataId))
						{
							flag = false;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				if (flag)
				{
					return;
				}
			}
			bool flag2 = false;
			bool skipThisTreeNode = false;
			if (settingOrSpecialObject2 != null)
			{
				List<Do> val3 = new List<Do>();
				PortFunction.A(settingOrSpecialObject2, false, true, val3);
				Enumerator<Do> enumerator3 = val3.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						Do current3 = enumerator3.Current;
						Do @do = Pw.A(current3.A()) as Do;
						if ((pa || ((!pA || !current3.J()) && (!Pz || (@do != null && !@do.J())))) && !P_2.Contains(current3.C()))
						{
							TreeNode val4 = new TreeNode(((SettingOrSpecialObject)current3).A(true));
							if (P_3)
							{
								val4.Checked = true;
							}
							val4.ForeColor = Color.Gray;
							val4.Tag = current3;
							val.Nodes.Add(val4);
							flag2 = true;
							PY.Add(current3.C());
							P_2.Add(current3.C());
							if (@do != null && !current3.A((Setting)@do))
							{
								PZ.Add(val4);
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator3).Dispose();
				}
				List<Dn> val5 = new List<Dn>();
				PortFunction.A(settingOrSpecialObject2, false, val5, Px);
				Enumerator<Dn> enumerator4 = val5.GetEnumerator();
				try
				{
					while (enumerator4.MoveNext())
					{
						Dn current4 = enumerator4.Current;
						if (current4.am())
						{
							List<Setting> val6 = new List<Setting>();
							PortFunction.A(current4.ax(), current4.al(), current4.aN(), PX, val6, false);
							if (val6.Count == 0)
							{
								continue;
							}
						}
						Setting setting3 = Pw.A(((Setting)current4).A());
						if ((pa || ((!pA | !current4.J()) && (!Pz || (setting3 != null && !setting3.J())))) && !P_2.Contains(current4.C()))
						{
							TreeNode val7 = new TreeNode(((SettingOrSpecialObject)current4).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ku());
							if (P_3)
							{
								val7.Checked = true;
							}
							val7.ForeColor = Color.Gray;
							val7.Tag = current4;
							val.Nodes.Add(val7);
							flag2 = true;
							PY.Add(current4.C());
							P_2.Add(current4.C());
							if (setting3 != null && !current4.A(setting3))
							{
								PZ.Add(val7);
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator4).Dispose();
				}
			}
			else if (settingOrSpecialObject != null)
			{
				CG cG = settingOrSpecialObject.e();
				if (cG != null)
				{
					cG.InitImportMapDestinationNode(val, ref skipThisTreeNode, Pw, pa, pA, Pz, PY, PZ, P_2, P_3);
					if (!skipThisTreeNode)
					{
						flag2 = true;
					}
				}
				else if (settingOrSpecialObject.a().Count != 0)
				{
					if (!(settingOrSpecialObject is SpecialObject) || !(settingOrSpecialObject as SpecialObject).b().EachListRowIsAnObject())
					{
						Enumerator<SettingOrSpecialObject> enumerator5 = settingOrSpecialObject.a().GetEnumerator();
						try
						{
							while (enumerator5.MoveNext())
							{
								SettingOrSpecialObject current5 = enumerator5.Current;
								if (!(current5 is Setting))
								{
									continue;
								}
								Setting setting4 = current5 as Setting;
								if (setting4.D() || setting4.am() || setting4.aN() || PX.aWZ.Contains(setting4.A()))
								{
									continue;
								}
								Setting setting5 = Pw.A(setting4.A());
								if ((pa || ((!pA || !setting4.J()) && (!Pz || (setting5 != null && !setting5.J())))) && !P_2.Contains(setting4.C()))
								{
									TreeNode val8 = new TreeNode(((SettingOrSpecialObject)setting4).A(true));
									if (P_3)
									{
										val8.Checked = true;
									}
									val8.ForeColor = Color.Gray;
									val8.Tag = setting4;
									val.Nodes.Add(val8);
									flag2 = true;
									PY.Add(setting4.C());
									P_2.Add(setting4.C());
									if (setting5 != null && !setting4.A(setting5))
									{
										PZ.Add(val8);
									}
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator5).Dispose();
						}
					}
					A(val, settingOrSpecialObject, P_3, ref flag2);
				}
			}
			Enumerator<int> enumerator6 = P_0.aE().GetEnumerator();
			try
			{
				while (enumerator6.MoveNext())
				{
					int current6 = enumerator6.Current;
					Setting setting6 = PX.A(current6);
					if (setting6 == null || setting6.D() || setting6.am())
					{
						continue;
					}
					Setting setting7 = Pw.A(current6);
					if ((pa || ((!pA || !setting6.J()) && (!Pz || (setting7 != null && !setting7.J())))) && !P_2.Contains(setting6.C()))
					{
						TreeNode val9 = new TreeNode(((SettingOrSpecialObject)setting6).A(true));
						if (P_3)
						{
							val9.Checked = true;
						}
						val9.ForeColor = Color.Gray;
						val9.Tag = setting6;
						val.Nodes.Add(val9);
						flag2 = true;
						PY.Add(setting6.C());
						P_2.Add(setting6.C());
						if (setting7 != null && !setting6.A(setting7))
						{
							PZ.Add(val9);
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator6).Dispose();
			}
			if (val.GetNodeCount(true) == 0 && !flag2)
			{
				skipThisTreeNode = true;
			}
			if (!skipThisTreeNode)
			{
				if (P_1 != null)
				{
					P_1.Nodes.Add(val);
					return;
				}
				val.Expand();
				pG.a().Add(val);
			}
		}

		private bool A(MenuNode P_0, TreeNode P_1, SettingOrSpecialObject P_2, SettingOrSpecialObject P_3)
		{
			bool flag = P_2 != null;
			bool flag2 = P_3 != null;
			bool flag3 = P_0.h() != 0;
			bool flag4 = P_0.aE().Count != 0;
			if (P_1.GetNodeCount(true) == 0 && !flag && !flag2 && !flag3)
			{
				return !flag4;
			}
			return false;
		}

		private void A()
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < PX.awD.Count; i++)
			{
				SettingOrSpecialObject settingOrSpecialObject = PX.awD[i];
				Enumerator<Setting> enumerator = PortFunction.a(settingOrSpecialObject, false).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Setting current = enumerator.Current;
						Setting setting = Pw.A(current.A());
						if (pa || ((!pA || !current.J()) && (!Pz || setting == null || !setting.J())))
						{
							PY.Add(current.C());
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				Enumerator<Table> enumerator2 = PortFunction.B(settingOrSpecialObject, false).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Table current2 = enumerator2.Current;
						Setting setting2 = Pw.A(((Setting)current2).A());
						if (pa || ((!pA || !current2.J()) && (!Pz || setting2 == null || !setting2.J())))
						{
							PY.Add(current2.C());
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
		}

		private void a()
		{
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			pg.b();
			HashSet<DataIdAndAttrId> val = new HashSet<DataIdAndAttrId>();
			List<int> val2 = new List<int>();
			val2.Add(1501);
			val2.Add(1502);
			val2.Add(3800);
			for (int i = 0; i < val2.Count; i++)
			{
				int num = val2[i];
				Setting setting = Pw.A(num);
				if (setting != null && (pa || !Pz || !setting.J()))
				{
					Py.Add(new DataIdAndAttrId(num));
				}
			}
			Enumerator<MenuNode> enumerator = Pw.awj.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					MenuNode current = enumerator.Current;
					A(current, null, val);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			pg.C();
			pg.I();
		}

		private void A(MenuNode P_0, TreeNode P_1, HashSet<DataIdAndAttrId> P_2)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Expected O, but got Unknown
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_068b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0690: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_0563: Unknown result type (might be due to invalid IL or missing references)
			//IL_0568: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Expected O, but got Unknown
			//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0367: Unknown result type (might be due to invalid IL or missing references)
			//IL_036e: Expected O, but got Unknown
			//IL_0370: Unknown result type (might be due to invalid IL or missing references)
			//IL_0741: Unknown result type (might be due to invalid IL or missing references)
			//IL_0748: Expected O, but got Unknown
			//IL_074a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0490: Unknown result type (might be due to invalid IL or missing references)
			//IL_0497: Expected O, but got Unknown
			//IL_0499: Unknown result type (might be due to invalid IL or missing references)
			//IL_0624: Unknown result type (might be due to invalid IL or missing references)
			//IL_062b: Expected O, but got Unknown
			//IL_062d: Unknown result type (might be due to invalid IL or missing references)
			string text = P_0.E();
			int num = P_0.b();
			int num2 = P_0.H();
			TreeNode val = new TreeNode(text);
			val.Tag = P_0;
			val.ForeColor = BM.te;
			SettingOrSpecialObject settingOrSpecialObject = Pw.a(num);
			SettingOrSpecialObject settingOrSpecialObject2 = Pw.a(num2);
			if (settingOrSpecialObject != null && (settingOrSpecialObject.J().Count != 0 || settingOrSpecialObject.K().A().Count != 0))
			{
				return;
			}
			if (P_0.h() != 0)
			{
				Setting setting = Pw.A(P_0.h());
				if (setting != null)
				{
					if (setting.am() && setting.ax() != 1)
					{
						return;
					}
					if ((pa || !Pz || !setting.J()) && !P_2.Contains(setting.C()))
					{
						Py.Add(setting.C());
						if (!PY.Contains(setting.C()))
						{
							TreeNode val2 = new TreeNode(((SettingOrSpecialObject)setting).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lz());
							val2.ForeColor = BM.te;
							val2.Tag = setting;
							val.Nodes.Add(val2);
							P_2.Add(setting.C());
						}
					}
				}
			}
			Enumerator<MenuNode> enumerator = P_0.c().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					MenuNode current = enumerator.Current;
					A(current, val, P_2);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (a(P_0, val, settingOrSpecialObject, settingOrSpecialObject2))
			{
				return;
			}
			if (P_0.C() != null && P_0.C().h() == 0 && settingOrSpecialObject is SpecialObject && (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.Count != 0)
			{
				bool flag = true;
				Enumerator<UIListSettingDataIdAndIndent> enumerator2 = (settingOrSpecialObject as SpecialObject).B().CurrentUIListSettingsIdsAndIndents.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						UIListSettingDataIdAndIndent current2 = enumerator2.Current;
						if (!Pw.aWZ.Contains(current2.DataId))
						{
							flag = false;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				if (flag)
				{
					return;
				}
			}
			bool equivalentNodeExistsInDestMap = true;
			bool flag2 = false;
			bool skipThisTreeNode = false;
			if (settingOrSpecialObject2 != null)
			{
				if (!Pw.aWz)
				{
					Setting setting2 = PortFunction.A(settingOrSpecialObject2);
					if (setting2 != null && (pa || !Pz || !setting2.J()) && !P_2.Contains(setting2.C()))
					{
						Py.Add(setting2.C());
						if (!PY.Contains(setting2.C()))
						{
							TreeNode val3 = new TreeNode(((SettingOrSpecialObject)setting2).A(true));
							val3.ForeColor = BM.te;
							val3.Tag = setting2;
							val.Nodes.Add(val3);
							flag2 = true;
							P_2.Add(setting2.C());
						}
					}
				}
				List<Do> val4 = new List<Do>();
				PortFunction.A(settingOrSpecialObject2, false, true, val4);
				Enumerator<Do> enumerator3 = val4.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						Do current3 = enumerator3.Current;
						if ((pa || !Pz || !current3.J()) && !P_2.Contains(current3.C()))
						{
							Py.Add(current3.C());
							if (!PY.Contains(current3.C()))
							{
								TreeNode val5 = new TreeNode(((SettingOrSpecialObject)current3).A(true));
								val5.ForeColor = BM.te;
								val5.Tag = current3;
								val.Nodes.Add(val5);
								flag2 = true;
								P_2.Add(current3.C());
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator3).Dispose();
				}
				List<Dn> val6 = new List<Dn>();
				PortFunction.A(settingOrSpecialObject2, false, val6, Px);
				Enumerator<Dn> enumerator4 = val6.GetEnumerator();
				try
				{
					while (enumerator4.MoveNext())
					{
						Dn current4 = enumerator4.Current;
						if (current4.am())
						{
							List<Setting> val7 = new List<Setting>();
							PortFunction.A(current4.ax(), current4.al(), current4.aN(), Pw, val7, false);
							if (val7.Count == 0)
							{
								continue;
							}
						}
						if ((pa || !Pz || !current4.J()) && !P_2.Contains(current4.C()))
						{
							Py.Add(current4.C());
							if (!PY.Contains(current4.C()))
							{
								TreeNode val8 = new TreeNode(((SettingOrSpecialObject)current4).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ku());
								val8.ForeColor = BM.te;
								val8.Tag = current4;
								val.Nodes.Add(val8);
								flag2 = true;
								P_2.Add(current4.C());
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator4).Dispose();
				}
			}
			else if (settingOrSpecialObject != null)
			{
				CG cG = settingOrSpecialObject.e();
				if (cG != null)
				{
					cG.InitImportMapSourceNode(val, ref skipThisTreeNode, pa, Pz, Py, PY, P_2, ref equivalentNodeExistsInDestMap);
					if (!skipThisTreeNode)
					{
						flag2 = true;
					}
				}
				else if (settingOrSpecialObject.a().Count != 0)
				{
					if (!(settingOrSpecialObject is SpecialObject) || !(settingOrSpecialObject as SpecialObject).b().EachListRowIsAnObject())
					{
						Enumerator<SettingOrSpecialObject> enumerator5 = settingOrSpecialObject.a().GetEnumerator();
						try
						{
							while (enumerator5.MoveNext())
							{
								SettingOrSpecialObject current5 = enumerator5.Current;
								if (!(current5 is Setting))
								{
									continue;
								}
								Setting setting3 = current5 as Setting;
								if (!setting3.D() && !setting3.am() && !setting3.aN() && !Pw.aWZ.Contains(setting3.A()) && (pa || !Pz || !setting3.J()) && !P_2.Contains(setting3.C()))
								{
									Py.Add(setting3.C());
									if (!PY.Contains(setting3.C()))
									{
										TreeNode val9 = new TreeNode(((SettingOrSpecialObject)setting3).A(true));
										val9.ForeColor = BM.te;
										val9.Tag = setting3;
										val.Nodes.Add(val9);
										flag2 = true;
										P_2.Add(setting3.C());
									}
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator5).Dispose();
						}
					}
					A(val, settingOrSpecialObject, ref flag2);
				}
			}
			Enumerator<int> enumerator6 = P_0.aE().GetEnumerator();
			try
			{
				while (enumerator6.MoveNext())
				{
					int current6 = enumerator6.Current;
					Setting setting4 = Pw.A(current6);
					if (setting4 != null && !setting4.D() && !setting4.am() && !Pw.aWZ.Contains(setting4.A()) && (pa || !Pz || !setting4.J()) && !P_2.Contains(setting4.C()))
					{
						Py.Add(setting4.C());
						if (!PY.Contains(setting4.C()))
						{
							TreeNode val10 = new TreeNode(((SettingOrSpecialObject)setting4).A(true));
							val10.ForeColor = BM.te;
							val10.Tag = setting4;
							val.Nodes.Add(val10);
							flag2 = true;
							P_2.Add(setting4.C());
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator6).Dispose();
			}
			if (val.GetNodeCount(true) == 0 && !flag2)
			{
				skipThisTreeNode = true;
			}
			if (!skipThisTreeNode && (val.GetNodeCount(true) != 0 || !equivalentNodeExistsInDestMap))
			{
				val.Expand();
				if (P_1 != null)
				{
					P_1.Nodes.Add(val);
				}
				else
				{
					pg.a().Add(val);
				}
			}
		}

		private bool a(MenuNode P_0, TreeNode P_1, SettingOrSpecialObject P_2, SettingOrSpecialObject P_3)
		{
			bool flag = P_2 != null;
			bool flag2 = P_3 != null;
			bool flag3 = P_0.h() != 0;
			bool flag4 = P_0.aE().Count != 0;
			if (P_1.GetNodeCount(true) == 0 && !flag && !flag2 && !flag3)
			{
				return !flag4;
			}
			return false;
		}

		private void B()
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < Pw.awD.Count; i++)
			{
				SettingOrSpecialObject settingOrSpecialObject = Pw.awD[i];
				Enumerator<Setting> enumerator = PortFunction.a(settingOrSpecialObject, false).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Setting current = enumerator.Current;
						if (pa || !Pz || !current.J())
						{
							Py.Add(current.C());
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				Enumerator<Table> enumerator2 = PortFunction.B(settingOrSpecialObject, false).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Table current2 = enumerator2.Current;
						if (pa || !Pz || !current2.J())
						{
							PY.Add(current2.C());
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
		}

		private void A(TreeNode P_0, SettingOrSpecialObject P_1, ref bool P_2)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			Enumerator<string> enumerator = P_1.Q().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (!Pw.aWv.ContainsKey(current))
					{
						continue;
					}
					Enumerator<SettingOrSpecialObject> enumerator2 = ((SettingOrSpecialObject)Pw.aWv[current]).a().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							SettingOrSpecialObject current2 = enumerator2.Current;
							if (!(current2 is Setting))
							{
								continue;
							}
							Setting setting = current2 as Setting;
							if (setting.D() || !(((SettingOrSpecialObject)setting).B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kW()))
							{
								continue;
							}
							if (!setting.am() && (pa || !Pz || !setting.J()))
							{
								Py.Add(setting.C());
								if (!PY.Contains(setting.C()))
								{
									TreeNode val = new TreeNode(((SettingOrSpecialObject)setting).A(true));
									val.ForeColor = BM.te;
									val.Tag = setting;
									P_0.Nodes.Add(val);
									P_2 = true;
								}
							}
							break;
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
		}

		private void A(TreeNode P_0, SettingOrSpecialObject P_1, bool P_2, ref bool P_3)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			Enumerator<string> enumerator = P_1.Q().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (!PX.aWv.ContainsKey(current))
					{
						continue;
					}
					Enumerator<SettingOrSpecialObject> enumerator2 = ((SettingOrSpecialObject)PX.aWv[current]).a().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							SettingOrSpecialObject current2 = enumerator2.Current;
							if (!(current2 is Setting))
							{
								continue;
							}
							Setting setting = current2 as Setting;
							if (setting.D() || !(((SettingOrSpecialObject)setting).B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kW()))
							{
								continue;
							}
							if (setting.am())
							{
								break;
							}
							Setting setting2 = Pw.A(setting.A());
							if (pa || ((!pA || !setting.J()) && (!Pz || (setting2 != null && !setting2.J()))))
							{
								TreeNode val = new TreeNode(((SettingOrSpecialObject)setting).A(true));
								if (P_2)
								{
									val.Checked = true;
								}
								val.ForeColor = Color.Gray;
								val.Tag = setting;
								P_0.Nodes.Add(val);
								P_3 = true;
								PY.Add(setting.C());
								if (setting2 != null && !setting.A(setting2))
								{
									PZ.Add(val);
								}
							}
							break;
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
		}

		private void A(List<TreeNode> P_0)
		{
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			for (int i = 0; i < P_0.Count; i++)
			{
				TreeNode val = P_0[i];
				if (val.Tag is Setting)
				{
					Setting setting = val.Tag as Setting;
					if (!Py.Contains(setting.C()))
					{
						a(val);
					}
				}
				else if (val.Tag is MenuNode)
				{
					MenuNode obj = val.Tag as MenuNode;
					int num = obj.b();
					int num2 = obj.H();
					SettingOrSpecialObject settingOrSpecialObject = PX.a(num);
					if (PX.a(num2) == null && settingOrSpecialObject != null)
					{
						CG cG = settingOrSpecialObject.e();
						if (cG != null)
						{
							if (cG.NodeShouldBeOrange(val, Py))
							{
								a(val);
							}
						}
						else
						{
							_ = settingOrSpecialObject.a().Count;
						}
					}
				}
				List<TreeNode> val2 = new List<TreeNode>();
				foreach (TreeNode node in val.Nodes)
				{
					TreeNode val3 = node;
					val2.Add(val3);
				}
				A(val2);
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			A(pG.a(), true);
			((Control)pG).Invalidate();
		}

		private void B(object P_0, EventArgs P_1)
		{
			A(pG.a(), false);
			((Control)pG).Invalidate();
		}

		private void A(List<TreeNode> P_0, bool P_1)
		{
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			for (int i = 0; i < P_0.Count; i++)
			{
				TreeNode val = P_0[i];
				if (val.Tag is MenuNode)
				{
					MenuNode menuNode = val.Tag as MenuNode;
					SettingOrSpecialObject settingOrSpecialObject = PX.a(menuNode.H());
					if (settingOrSpecialObject != null)
					{
						List<Do> val2 = new List<Do>();
						PortFunction.A(settingOrSpecialObject, false, true, val2);
						List<Dn> val3 = new List<Dn>();
						PortFunction.A(settingOrSpecialObject, false, val3, Px);
						foreach (TreeNode node in val.Nodes)
						{
							TreeNode val4 = node;
							if (!(val4.Tag is Setting))
							{
								continue;
							}
							Setting setting = val4.Tag as Setting;
							if ((setting is Do && val2.Contains(setting as Do)) || (setting is Dn && val3.Contains(setting as Dn)))
							{
								if (P_1)
								{
									val4.Checked = true;
								}
								else
								{
									val4.Checked = false;
								}
							}
						}
					}
				}
				List<TreeNode> val5 = new List<TreeNode>();
				foreach (TreeNode node2 in val.Nodes)
				{
					TreeNode val6 = node2;
					val5.Add(val6);
				}
				A(val5, P_1);
			}
		}

		private void a(List<TreeNode> P_0)
		{
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Expected O, but got Unknown
			for (int i = 0; i < P_0.Count; i++)
			{
				TreeNode val = P_0[i];
				if (val.Checked)
				{
					if (val.Tag is Setting)
					{
						(val.Tag as Setting).A(Pw, false, true);
					}
					else if (val.Tag is MenuNode)
					{
						MenuNode menuNode = val.Tag as MenuNode;
						Enumerator<int> enumerator = menuNode.aE().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								int current = enumerator.Current;
								PX.A(current)?.A(Pw, false, true);
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
						if (menuNode.x())
						{
							PX.A(menuNode.W())?.A(Pw, false);
						}
						int num = menuNode.b();
						int num2 = menuNode.H();
						SettingOrSpecialObject settingOrSpecialObject = PX.a(num);
						if (PX.a(num2) == null && settingOrSpecialObject != null)
						{
							CG cG = settingOrSpecialObject.e();
							if (cG != null)
							{
								cG.ImportFromAnotherFramework(Pw, markForWrite: false);
							}
							else
							{
								_ = settingOrSpecialObject.a().Count;
							}
						}
					}
				}
				List<TreeNode> val2 = new List<TreeNode>();
				foreach (TreeNode node in val.Nodes)
				{
					TreeNode val3 = node;
					val2.Add(val3);
				}
				a(val2);
			}
		}

		[SpecialName]
		internal bool b()
		{
			return pb;
		}

		[SpecialName]
		internal string C()
		{
			return pC;
		}

		[SpecialName]
		internal string c()
		{
			return pc;
		}

		private void a(bool P_0)
		{
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			pb = false;
			pC = string.Empty;
			pc = string.Empty;
			if (pB == null)
			{
				return;
			}
			foreach (TreeNode node in pB.Nodes)
			{
				TreeNode val = node;
				if (!(val.Checked || P_0) || !(val.Tag is Setting))
				{
					continue;
				}
				Setting setting = val.Tag as Setting;
				if (setting.A() != 1501)
				{
					continue;
				}
				Setting setting2 = Pw.A(1501);
				if (setting2 != null)
				{
					string text = setting.ay();
					string text2 = setting2.ay();
					if (text2 != text && !string.IsNullOrEmpty(text2))
					{
						pb = true;
						pC = text;
						pc = text2;
					}
				}
				break;
			}
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Invalid comparison between Unknown and I4
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Expected O, but got Unknown
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			bool flag = (int)((Form)this).DialogResult == 1;
			bool flag2 = (int)((Form)this).DialogResult == 6;
			bool flag3 = true;
			Enumerator<TreeNode> enumerator = pG.a().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TreeNode current = enumerator.Current;
					if (!current.Checked)
					{
						flag3 = false;
						break;
					}
					if (TreeViewWithThemedScrollBars.D(current))
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
			if (flag || flag2)
			{
				ca.A((IWin32Window)(object)this, flag2, flag3, Pw, PX, out var flag4);
				if (flag4)
				{
					((CancelEventArgs)P_1).Cancel = true;
					return;
				}
			}
			pG.a(new DrawTreeNodeEventHandler(A));
			BM.c(new EventHandler(A));
			if (flag || flag2)
			{
				a(flag2);
				if (BM.Qz != null)
				{
					BM.Qz.m();
					BM.QQ.rl.i()?.a().E();
				}
				if (pG.a().Count == 0 && !Px && (Pz || pA))
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lA(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.la(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				lock (PX.K())
				{
					PX.C(PX.aWS);
					bool flag5 = PX.l();
					PX.M();
					bool flag6 = Px && pA && (pG.a().Count == 0 || flag2);
					if ((pa && (flag3 || flag2)) || flag6)
					{
						if (Pw.awZ == PX.awZ && Pw.awz == PX.awz && Pw.aXA == PX.aXA)
						{
							Pw.A(PX.d());
							Pw.aXc = PX.aXc;
							Pw.aXD = PX.aXD;
							List<byte[]> val = new List<byte[]>();
							if (!Px)
							{
								for (int i = 0; i < PX.aWw.Count; i++)
								{
									Setting setting = PX.aWw[i];
									val.Add(setting.aY());
								}
							}
							PX = Pw;
							if (!Px)
							{
								for (int j = 0; j < PX.aWw.Count; j++)
								{
									PX.aWw[j].A(val[j], false);
								}
							}
							if (!Px)
							{
								Enumerator<Setting> enumerator2 = PX.awv.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										Di.A(enumerator2.Current, false);
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
							PX.A(Pw, PX.aWS, false, false, true);
							PX.A(Pw, false);
						}
					}
					else
					{
						a(pG.a());
					}
					PX.N();
					PX.a(PX.awj);
					PX.a((HashSet<DataIdAndAttrId>)null);
					if (flag5)
					{
						PX.A(true);
					}
					PX.c(PX.aWS);
					PortFunction.A(PX, false);
				}
				BM.Qz = PX;
			}
			PX.a(PX.awj);
			PX.a((HashSet<DataIdAndAttrId>)null);
			PX.A(null, BM.Qn, BM.qf);
			PX.A((HashSet<DataIdAndAttrId>)null);
			PX = null;
			Pw = null;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && pD != null)
			{
				((System.IDisposable)pD).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void D()
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Expected O, but got Unknown
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Expected O, but got Unknown
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Expected O, but got Unknown
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02db: Expected O, but got Unknown
			//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_035b: Expected O, but got Unknown
			//IL_0368: Unknown result type (might be due to invalid IL or missing references)
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0402: Unknown result type (might be due to invalid IL or missing references)
			//IL_040c: Expected O, but got Unknown
			//IL_0425: Unknown result type (might be due to invalid IL or missing references)
			//IL_045b: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c7: Expected O, but got Unknown
			//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0512: Unknown result type (might be due to invalid IL or missing references)
			//IL_0547: Unknown result type (might be due to invalid IL or missing references)
			//IL_0551: Expected O, but got Unknown
			//IL_055b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0582: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d2: Expected O, but got Unknown
			//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0609: Unknown result type (might be due to invalid IL or missing references)
			//IL_0648: Unknown result type (might be due to invalid IL or missing references)
			//IL_066f: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b8: Expected O, but got Unknown
			//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_073a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0744: Expected O, but got Unknown
			//IL_0763: Unknown result type (might be due to invalid IL or missing references)
			//IL_076d: Expected O, but got Unknown
			//IL_077d: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0812: Unknown result type (might be due to invalid IL or missing references)
			//IL_0907: Unknown result type (might be due to invalid IL or missing references)
			//IL_0911: Expected O, but got Unknown
			//IL_0959: Unknown result type (might be due to invalid IL or missing references)
			//IL_0963: Expected O, but got Unknown
			pd = new ThemedButton();
			pE = new ThemedButton();
			pe = new Label();
			pF = new Label();
			pf = new Label();
			pH = new Label();
			pg = new TreeViewWithThemedScrollBars();
			pG = new TreeViewWithThemedScrollBars();
			ph = new Label();
			pI = new Label();
			pi = new ThemedButton();
			pJ = new ThemedButton();
			pj = new ThemedButton();
			((Control)this).SuspendLayout();
			((Button)pd).DialogResult = (DialogResult)1;
			((Control)pd).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pd).Location = new Point(912, 597);
			((Control)pd).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lB();
			((Control)pd).Size = new Size(145, 38);
			((Control)pd).TabIndex = 0;
			((Control)pd).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lb();
			((ButtonBase)pd).UseVisualStyleBackColor = true;
			((Button)pE).DialogResult = (DialogResult)2;
			((Control)pE).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pE).Location = new Point(1158, 597);
			((Control)pE).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)pE).Size = new Size(73, 38);
			((Control)pE).TabIndex = 2;
			((Control)pE).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)pE).UseVisualStyleBackColor = true;
			((Control)pe).AutoSize = true;
			((Control)pe).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pe).Location = new Point(12, 4);
			((Control)pe).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lC();
			((Control)pe).Size = new Size(121, 13);
			((Control)pe).TabIndex = 2;
			((Control)pe).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lc();
			((Control)pF).AutoSize = true;
			((Control)pF).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pF).Location = new Point(10, 73);
			((Control)pF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lD();
			((Control)pF).Size = new Size(252, 13);
			((Control)pF).TabIndex = 3;
			((Control)pF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ls();
			((Control)pf).AutoSize = true;
			((Control)pf).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pf).Location = new Point(12, 23);
			((Control)pf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ky();
			((Control)pf).Size = new Size(155, 13);
			((Control)pf).TabIndex = 4;
			((Control)pf).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ld();
			((Control)pH).AutoSize = true;
			((Control)pH).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pH).Location = new Point(857, 73);
			((Control)pH).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lE();
			((Control)pH).Size = new Size(353, 13);
			((Control)pH).TabIndex = 10;
			((Control)pH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.le();
			pg.a(true);
			((ScrollableControl)pg).AutoScroll = true;
			((UserControl)pg).BorderStyle = (BorderStyle)1;
			pg.A(false);
			pg.A(aW.kP);
			((Control)pg).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f);
			pg.A((List<Image>)null);
			((Control)pg).Location = new Point(858, 91);
			((Control)pg).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lF();
			pg.A((TreeNode)null);
			((Control)pg).Size = new Size(374, 499);
			((Control)pg).TabIndex = 6;
			pG.a(true);
			((ScrollableControl)pG).AutoScroll = true;
			((UserControl)pG).BorderStyle = (BorderStyle)1;
			pG.A(true);
			pG.A(aW.kP);
			((Control)pG).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f);
			pG.A((List<Image>)null);
			((Control)pG).Location = new Point(8, 91);
			((Control)pG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lf();
			pG.A((TreeNode)null);
			((Control)pG).Size = new Size(844, 499);
			((Control)pG).TabIndex = 5;
			((Control)ph).AutoSize = true;
			((Control)ph).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)ph).Location = new Point(12, 41);
			((Control)ph).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lG();
			((Control)ph).Size = new Size(148, 13);
			((Control)ph).TabIndex = 11;
			((Control)ph).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lg();
			((Control)pI).AutoSize = true;
			((Control)pI).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pI).Location = new Point(490, 610);
			((Control)pI).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lH();
			((Control)pI).Size = new Size(283, 13);
			((Control)pI).TabIndex = 12;
			((Control)pI).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lh();
			((Control)pi).Enabled = false;
			((Control)pi).Location = new Point(8, 601);
			((Control)pi).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lI();
			((Control)pi).Size = new Size(157, 28);
			((Control)pi).TabIndex = 3;
			((Control)pi).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.li();
			((ButtonBase)pi).UseVisualStyleBackColor = true;
			((Control)pi).Click += new EventHandler(a);
			((Control)pJ).Enabled = false;
			((Control)pJ).Location = new Point(171, 601);
			((Control)pJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lJ();
			((Control)pJ).Size = new Size(182, 28);
			((Control)pJ).TabIndex = 4;
			((Control)pJ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lj();
			((ButtonBase)pJ).UseVisualStyleBackColor = true;
			((Control)pJ).Click += new EventHandler(B);
			((Button)pj).DialogResult = (DialogResult)6;
			((Control)pj).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)pj).Location = new Point(1062, 597);
			((Control)pj).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lK();
			((Control)pj).Size = new Size(91, 38);
			((Control)pj).TabIndex = 1;
			((Control)pj).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lk();
			((ButtonBase)pj).UseVisualStyleBackColor = true;
			((Form)this).AcceptButton = (IButtonControl)(object)pd;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)pE;
			((Form)this).ClientSize = new Size(1240, 642);
			((Control)this).Controls.Add((Control)(object)pj);
			((Control)this).Controls.Add((Control)(object)pJ);
			((Control)this).Controls.Add((Control)(object)pi);
			((Control)this).Controls.Add((Control)(object)pI);
			((Control)this).Controls.Add((Control)(object)ph);
			((Control)this).Controls.Add((Control)(object)pH);
			((Control)this).Controls.Add((Control)(object)pg);
			((Control)this).Controls.Add((Control)(object)pG);
			((Control)this).Controls.Add((Control)(object)pf);
			((Control)this).Controls.Add((Control)(object)pF);
			((Control)this).Controls.Add((Control)(object)pe);
			((Control)this).Controls.Add((Control)(object)pE);
			((Control)this).Controls.Add((Control)(object)pd);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lL();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LS();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
namespace b
{
	internal class bJ : Form
	{
		private const int abc = 200;

		private const int abD = 25;

		internal byte abd;

		internal byte abE;

		private WiringPin abe;

		private TableLayoutPanelWithThemedScrollBars abF = new TableLayoutPanelWithThemedScrollBars();

		private TableLayoutPanelWithThemedScrollBars abf = new TableLayoutPanelWithThemedScrollBars();

		private TableLayoutPanelWithThemedScrollBars abG = new TableLayoutPanelWithThemedScrollBars();

		private PictureBox abg = new PictureBox();

		private ThemedButton abH = new ThemedButton();

		internal bJ(WiringPin P_0)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a3: Expected O, but got Unknown
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e9: Expected O, but got Unknown
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0342: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Expected O, but got Unknown
			//IL_034b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0367: Unknown result type (might be due to invalid IL or missing references)
			//IL_036c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0377: Unknown result type (might be due to invalid IL or missing references)
			//IL_037c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_038c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0395: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f2: Expected O, but got Unknown
			//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f9: Expected O, but got Unknown
			//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0405: Unknown result type (might be due to invalid IL or missing references)
			//IL_040a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0417: Unknown result type (might be due to invalid IL or missing references)
			//IL_041c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0427: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0437: Unknown result type (might be due to invalid IL or missing references)
			//IL_043c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0445: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0498: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a2: Expected O, but got Unknown
			//IL_0512: Unknown result type (might be due to invalid IL or missing references)
			//IL_0545: Unknown result type (might be due to invalid IL or missing references)
			//IL_0552: Unknown result type (might be due to invalid IL or missing references)
			//IL_0557: Unknown result type (might be due to invalid IL or missing references)
			//IL_0579: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0609: Unknown result type (might be due to invalid IL or missing references)
			//IL_0613: Expected O, but got Unknown
			//IL_0639: Unknown result type (might be due to invalid IL or missing references)
			//IL_0659: Unknown result type (might be due to invalid IL or missing references)
			((Form)this).Shown += new EventHandler(a);
			BM.C(new EventHandler(A));
			abe = P_0;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abb();
			((Control)this).BackColor = BM.td;
			((Control)this).ForeColor = BM.te;
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			Color val = P_0.F();
			Color val2 = P_0.f();
			for (byte b = 1; b <= WiringPin.BCd.Length; b++)
			{
				if (WiringPin.A(WiringPin.BCd[b - 1]) == val)
				{
					abd = b;
					break;
				}
			}
			for (byte b2 = 1; b2 <= WiringPin.BCd.Length; b2++)
			{
				if (WiringPin.A(WiringPin.BCd[b2 - 1]) == val2)
				{
					abE = b2;
					break;
				}
			}
			Padding margin = default(Padding);
			((Padding)(ref margin))._002Ector(10, 2, 10, 2);
			((TableLayoutPanel)abF).CellBorderStyle = (TableLayoutPanelCellBorderStyle)0;
			((TableLayoutPanel)abF).GrowStyle = (TableLayoutPanelGrowStyle)0;
			((ScrollableControl)abF).AutoScroll = false;
			((TableLayoutPanel)abF).ColumnCount = 2;
			((TableLayoutPanel)abF).RowCount = 2;
			((Control)abF).AutoSize = true;
			((Control)abg).BackColor = Color.Transparent;
			((Control)abg).Margin = margin;
			abg.Image = (Image)(object)WiringPin.A(val, val2, P_0.Bbt, false, false);
			((TableLayoutPanel)abF).Controls.Add((Control)(object)abg, 0, 0);
			((TableLayoutPanel)abF).SetColumnSpan((Control)(object)abg, 2);
			((Control)abg).Dock = (DockStyle)5;
			abg.SizeMode = (PictureBoxSizeMode)3;
			((TableLayoutPanel)abf).CellBorderStyle = (TableLayoutPanelCellBorderStyle)1;
			((TableLayoutPanel)abf).GrowStyle = (TableLayoutPanelGrowStyle)0;
			((ScrollableControl)abf).AutoScroll = false;
			((TableLayoutPanel)abf).ColumnCount = 1;
			((TableLayoutPanel)abf).RowCount = 1 + WiringPin.BCd.Length;
			((Control)abf).AutoSize = true;
			((TableLayoutPanel)abG).CellBorderStyle = (TableLayoutPanelCellBorderStyle)1;
			((TableLayoutPanel)abG).GrowStyle = (TableLayoutPanelGrowStyle)0;
			((ScrollableControl)abG).AutoScroll = false;
			((TableLayoutPanel)abG).ColumnCount = 1;
			((TableLayoutPanel)abG).RowCount = 1 + WiringPin.BCd.Length;
			((Control)abG).AutoSize = true;
			Label val3 = new Label();
			((Control)val3).Margin = margin;
			((Control)val3).AutoSize = false;
			((Control)val3).Width = 200;
			((Control)val3).Height = 25;
			((Control)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abC();
			((TableLayoutPanel)abf).Controls.Add((Control)(object)val3, 0, 0);
			Label val4 = new Label();
			((Control)val4).Margin = margin;
			((Control)val4).AutoSize = false;
			((Control)val4).Width = 200;
			((Control)val4).Height = 25;
			((Control)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abc();
			((TableLayoutPanel)abG).Controls.Add((Control)(object)val4, 0, 0);
			for (byte b3 = 1; b3 <= WiringPin.BCd.Length; b3++)
			{
				string text = WiringPin.BCd[b3 - 1];
				RadioButton val5 = new RadioButton();
				((Control)val5).Margin = margin;
				Padding padding = ((Control)val5).Padding;
				int num = ((Padding)(ref padding)).Left + 5;
				padding = ((Control)val5).Padding;
				int top = ((Padding)(ref padding)).Top;
				padding = ((Control)val5).Padding;
				int right = ((Padding)(ref padding)).Right;
				padding = ((Control)val5).Padding;
				((Control)val5).Padding = new Padding(num, top, right, ((Padding)(ref padding)).Bottom);
				((Control)val5).BackColor = WiringPin.A(text);
				((Control)val5).AutoSize = false;
				((Control)val5).Width = 200;
				((Control)val5).Height = 25;
				((TableLayoutPanel)abf).Controls.Add((Control)(object)val5, 0, (int)b3);
				val5.CheckedChanged += new EventHandler(B);
				RadioButton val6 = new RadioButton();
				((Control)val6).Margin = margin;
				padding = ((Control)val6).Padding;
				int num2 = ((Padding)(ref padding)).Left + 5;
				padding = ((Control)val6).Padding;
				int top2 = ((Padding)(ref padding)).Top;
				padding = ((Control)val6).Padding;
				int right2 = ((Padding)(ref padding)).Right;
				padding = ((Control)val6).Padding;
				((Control)val6).Padding = new Padding(num2, top2, right2, ((Padding)(ref padding)).Bottom);
				((Control)val6).BackColor = WiringPin.A(text);
				((Control)val6).AutoSize = false;
				((Control)val6).Width = 200;
				((Control)val6).Height = 25;
				((TableLayoutPanel)abG).Controls.Add((Control)(object)val6, 0, (int)b3);
				val6.CheckedChanged += new EventHandler(this.b);
			}
			((TableLayoutPanel)abF).Controls.Add((Control)(object)abf, 0, 1);
			((TableLayoutPanel)abF).Controls.Add((Control)(object)abG, 1, 1);
			((Control)this).Controls.Add((Control)(object)abF);
			((Form)this).ClientSize = new Size(((Control)abF).Width, ((Control)abF).Height + 50);
			ThemedButton themedButton = new ThemedButton();
			((Button)themedButton).DialogResult = (DialogResult)2;
			((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((Control)themedButton).AutoSize = false;
			((Control)themedButton).Size = new Size(100, 30);
			Size clientSize = ((Form)this).ClientSize;
			((Control)themedButton).Location = new Point(((Size)(ref clientSize)).Width - 10 - ((Control)themedButton).Width, ((Control)abF).Height + 10);
			((Control)this).Controls.Add((Control)(object)themedButton);
			ThemedButton themedButton2 = new ThemedButton();
			((Button)themedButton2).DialogResult = (DialogResult)1;
			((Control)themedButton2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((Control)themedButton2).AutoSize = false;
			((Control)themedButton2).Size = new Size(100, 30);
			((Control)themedButton2).Location = new Point(((Control)themedButton).Left - 10 - ((Control)themedButton2).Width, ((Control)abF).Height + 10);
			((Control)this).Controls.Add((Control)(object)themedButton2);
			((Control)abH).Click += new EventHandler(C);
			((Control)abH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FP();
			((Control)abH).AutoSize = false;
			((Control)abH).Size = new Size(120, 30);
			((Control)abH).Location = new Point(10, ((Control)abF).Height + 10);
			((Control)this).Controls.Add((Control)(object)abH);
			((Form)this).CancelButton = (IButtonControl)(object)themedButton;
			((Control)themedButton).Focus();
		}

		protected override void Dispose(bool disposing)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected O, but got Unknown
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			((Form)this).Shown -= new EventHandler(a);
			BM.c(new EventHandler(A));
			foreach (Control item in (ArrangedElementCollection)((TableLayoutPanel)abf).Controls)
			{
				Control val = item;
				if (val is RadioButton)
				{
					((RadioButton)((val is RadioButton) ? val : null)).CheckedChanged -= new EventHandler(B);
				}
			}
			foreach (Control item2 in (ArrangedElementCollection)((TableLayoutPanel)abG).Controls)
			{
				Control val2 = item2;
				if (val2 is RadioButton)
				{
					((RadioButton)((val2 is RadioButton) ? val2 : null)).CheckedChanged -= new EventHandler(b);
				}
			}
			((Control)abH).Click -= new EventHandler(C);
			((Form)this).Dispose(disposing);
		}

		private void A(object P_0, EventArgs P_1)
		{
			((Form)this).DialogResult = (DialogResult)2;
			((Form)this).Close();
		}

		private void a(object P_0, EventArgs P_1)
		{
			if (abd > 0)
			{
				Control controlFromPosition = ((TableLayoutPanel)abf).GetControlFromPosition(0, (int)abd);
				((RadioButton)((controlFromPosition is RadioButton) ? controlFromPosition : null)).Checked = true;
			}
			if (abE > 0)
			{
				Control controlFromPosition2 = ((TableLayoutPanel)abG).GetControlFromPosition(0, (int)abE);
				((RadioButton)((controlFromPosition2 is RadioButton) ? controlFromPosition2 : null)).Checked = true;
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			if (((RadioButton)((P_0 is RadioButton) ? P_0 : null)).Checked)
			{
				TableLayoutPanelCellPosition cellPosition = ((TableLayoutPanel)abf).GetCellPosition((Control)((P_0 is RadioButton) ? P_0 : null));
				abd = (byte)((TableLayoutPanelCellPosition)(ref cellPosition)).Row;
				Color val = WiringPin.A(WiringPin.BCd[abd - 1]);
				Color val2 = WiringPin.A(WiringPin.BCd[abE - 1]);
				Image image = abg.Image;
				abg.Image = (Image)(object)WiringPin.A(val, val2, abe.Bbt, false, false);
				image.Dispose();
			}
		}

		private void b(object P_0, EventArgs P_1)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			if (((RadioButton)((P_0 is RadioButton) ? P_0 : null)).Checked)
			{
				TableLayoutPanelCellPosition cellPosition = ((TableLayoutPanel)abG).GetCellPosition((Control)((P_0 is RadioButton) ? P_0 : null));
				abE = (byte)((TableLayoutPanelCellPosition)(ref cellPosition)).Row;
				Color val = WiringPin.A(WiringPin.BCd[abd - 1]);
				Color val2 = WiringPin.A(WiringPin.BCd[abE - 1]);
				Image image = abg.Image;
				abg.Image = (Image)(object)WiringPin.A(val, val2, abe.Bbt, false, false);
				image.Dispose();
			}
		}

		private void C(object P_0, EventArgs P_1)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected O, but got Unknown
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			if (string.IsNullOrEmpty(abe.BbU) || string.IsNullOrEmpty(abe.Bbu))
			{
				return;
			}
			foreach (Control item in (ArrangedElementCollection)((TableLayoutPanel)abf).Controls)
			{
				Control val = item;
				if (val is RadioButton && val.BackColor == WiringPin.A(abe.BbU))
				{
					((RadioButton)((val is RadioButton) ? val : null)).Checked = true;
					break;
				}
			}
			foreach (Control item2 in (ArrangedElementCollection)((TableLayoutPanel)abG).Controls)
			{
				Control val2 = item2;
				if (val2 is RadioButton && val2.BackColor == WiringPin.A(abe.Bbu))
				{
					((RadioButton)((val2 is RadioButton) ? val2 : null)).Checked = true;
					break;
				}
			}
		}
	}
	internal static class bj
	{
		[CompilerGenerated]
		private static class A
		{
			public static DoWorkEventHandler BRR;

			public static RunWorkerCompletedEventHandler BRr;

			public static RunWorkerCompletedEventHandler BRS;

			public static DoWorkEventHandler BRs;

			public static ProgressChangedEventHandler BRT;

			public static DoWorkEventHandler BRt;

			public static RunWorkerCompletedEventHandler BRU;

			public static RunWorkerCompletedEventHandler BRu;

			public static DoWorkEventHandler BRV;

			public static DoWorkEventHandler BRv;

			public static DoWorkEventHandler BRW;

			public static RunWorkerCompletedEventHandler BRw;
		}

		private static Version abh = new Version(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acv());

		private static readonly EndpointAddress abI = new EndpointAddress(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acW());

		private static readonly NetNamedPipeBinding abi = new NetNamedPipeBinding();

		internal static bool abJ = false;

		private static bool abj = false;

		internal static bool abK = false;

		internal static bool abk = false;

		internal static string abL = string.Empty;

		internal static string abl = string.Empty;

		internal static bool abM = false;

		private static HashSet<string> abm = null;

		private static HashSet<string> abN = null;

		[CompilerGenerated]
		private static EventHandler abn;

		internal static int abO = 100;

		internal static bool abo = false;

		internal static bool abP = false;

		private const string abp = "Firmware";

		private const string abQ = "Definitions";

		internal static void A()
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			if (!a())
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abD(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abd(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private static bool a()
		{
			Version val = default(Version);
			if (Version.TryParse(aY.A(), ref val))
			{
				return val >= abh;
			}
			return false;
		}

		private static NexusAWSSvcCmdClient B()
		{
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = new NexusAWSSvcCmdClient((Binding)(object)abi, abI);
			try
			{
				nexusAWSSvcCmdClient.SetDebugMode(debugMode: false);
			}
			catch
			{
			}
			return nexusAWSSvcCmdClient;
		}

		internal static bool b()
		{
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
			try
			{
				if (nexusAWSSvcCmdClient.KnockKnock())
				{
					return true;
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abE() + ex.Message, true);
			}
			finally
			{
				try
				{
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
				}
				catch (CommunicationException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abe(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (TimeoutException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abF(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (System.Exception ex2)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abf() + ex2.Message, true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
			}
			return false;
		}

		internal static void C()
		{
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
			try
			{
				nexusAWSSvcCmdClient.SetDebugMode(debugMode: false);
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abG() + ex.Message, true);
			}
			finally
			{
				try
				{
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
				}
				catch (CommunicationException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abg(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (TimeoutException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abH(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (System.Exception ex2)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abh() + ex2.Message, true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
			}
		}

		internal static bool A(out bool P_0)
		{
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
			try
			{
				P_0 = nexusAWSSvcCmdClient.GetDebugMode();
				return true;
			}
			catch (System.Exception ex)
			{
				P_0 = false;
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abI() + ex.Message, true);
				return false;
			}
			finally
			{
				try
				{
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
				}
				catch (CommunicationException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abi(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (TimeoutException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abJ(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (System.Exception ex2)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abj() + ex2.Message, true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
			}
		}

		internal static void c()
		{
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
			try
			{
				nexusAWSSvcCmdClient.ToggleAutoUpdate();
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abK() + ex.Message, true);
			}
			finally
			{
				try
				{
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
				}
				catch (CommunicationException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abk(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (TimeoutException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abL(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (System.Exception ex2)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abl() + ex2.Message, true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
			}
		}

		internal static bool D()
		{
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
			try
			{
				return nexusAWSSvcCmdClient.AutoUpdateEnabled();
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abM() + ex.Message, true);
				return false;
			}
			finally
			{
				try
				{
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
				}
				catch (CommunicationException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abm(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (TimeoutException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abN(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (System.Exception ex2)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abn() + ex2.Message, true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
			}
		}

		private static void d()
		{
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
			try
			{
				nexusAWSSvcCmdClient.AbortCurrentOperation();
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abO() + ex.Message, true);
			}
			finally
			{
				try
				{
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
				}
				catch (CommunicationException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abo(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (TimeoutException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abP(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (System.Exception ex2)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abp() + ex2.Message, true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
			}
		}

		internal static void A(bool P_0)
		{
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected O, but got Unknown
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected O, but got Unknown
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			if (BM.qW || E())
			{
				return;
			}
			BM.QQ.rO.A(ar.A.Bnm, 0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abQ());
			try
			{
				BackgroundWorker val = new BackgroundWorker();
				object obj = bj.A.BRR;
				if (obj == null)
				{
					DoWorkEventHandler val2 = A;
					bj.A.BRR = val2;
					obj = (object)val2;
				}
				val.DoWork += (DoWorkEventHandler)obj;
				if (P_0)
				{
					object obj2 = bj.A.BRr;
					if (obj2 == null)
					{
						RunWorkerCompletedEventHandler val3 = a;
						bj.A.BRr = val3;
						obj2 = (object)val3;
					}
					val.RunWorkerCompleted += (RunWorkerCompletedEventHandler)obj2;
				}
				else
				{
					object obj3 = bj.A.BRS;
					if (obj3 == null)
					{
						RunWorkerCompletedEventHandler val4 = A;
						bj.A.BRS = val4;
						obj3 = (object)val4;
					}
					val.RunWorkerCompleted += (RunWorkerCompletedEventHandler)obj3;
				}
				BackgroundWorker val5 = new BackgroundWorker
				{
					WorkerReportsProgress = true
				};
				object obj4 = bj.A.BRs;
				if (obj4 == null)
				{
					DoWorkEventHandler val6 = b;
					bj.A.BRs = val6;
					obj4 = (object)val6;
				}
				val5.DoWork += (DoWorkEventHandler)obj4;
				object obj5 = bj.A.BRT;
				if (obj5 == null)
				{
					ProgressChangedEventHandler val7 = BM.A;
					bj.A.BRT = val7;
					obj5 = (object)val7;
				}
				val5.ProgressChanged += (ProgressChangedEventHandler)obj5;
				val5.RunWorkerAsync();
				val.RunWorkerAsync();
			}
			catch
			{
				if (!P_0)
				{
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abq(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
		}

		internal static bool a(bool P_0)
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Invalid comparison between Unknown and I4
			if (!BM.qW && e())
			{
				if (!abK)
				{
					g();
					return true;
				}
				if (!P_0)
				{
					if ((int)bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abR(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abr(), (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
					{
						abj = true;
						d();
						BM.QQ.rO.A(ar.A.Bnl, 0, string.Empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abS());
					}
				}
				else
				{
					abj = true;
					d();
					BM.QQ.rO.A(ar.A.Bnl, 0, string.Empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abS());
				}
				return true;
			}
			return false;
		}

		internal static bool E()
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			if (!BM.qW && e())
			{
				if (abK)
				{
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abs(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abr(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else
				{
					g();
				}
				return true;
			}
			return false;
		}

		internal static bool e()
		{
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
			try
			{
				return nexusAWSSvcCmdClient.IsUpdaterBusy();
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abT() + ex.Message, true);
				return false;
			}
			finally
			{
				try
				{
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
				}
				catch (CommunicationException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abt(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (TimeoutException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abU(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (System.Exception ex2)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abu() + ex2.Message, true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
			}
		}

		internal static UpdaterStatus F()
		{
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
			try
			{
				return nexusAWSSvcCmdClient.GetCurrentUpdaterStatus();
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abV() + ex.Message, true);
				return UpdaterStatus.Idle;
			}
			finally
			{
				try
				{
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
				}
				catch (CommunicationException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abv(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (TimeoutException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abW(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (System.Exception ex2)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abw() + ex2.Message, true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
			}
		}

		private static void A(object P_0, DoWorkEventArgs P_1)
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			Thread.CurrentThread.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abX();
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
			((IContextChannel)((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).InnerChannel).OperationTimeout = new TimeSpan(0, 3, 0);
			abK = true;
			bool flag = a();
			try
			{
				if (flag)
				{
					P_1.Result = nexusAWSSvcCmdClient.CheckForUpdates();
				}
				else
				{
					P_1.Result = nexusAWSSvcCmdClient.UpdateAvailable1();
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abx() + ex.Message, true);
				if (flag)
				{
					P_1.Result = new CheckForUpdatesResult
					{
						CheckSoftwareUpdatesSuccess = false,
						NewSoftwareAvailable = false,
						CheckSupportFilesUpdatesSuccess = false,
						NewSupportFilesAvailable = false,
						CheckSoftwareUpdatesErrorMessage = ex.Message,
						CheckSupportFilesUpdatesErrorMessage = ex.Message
					};
				}
				else
				{
					P_1.Result = 0;
				}
			}
			finally
			{
				try
				{
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
				}
				catch (CommunicationException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abY(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (TimeoutException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aby(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (System.Exception ex2)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abZ() + ex2.Message, true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
			}
		}

		private static void A(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0214: Invalid comparison between Unknown and I4
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Invalid comparison between Unknown and I4
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			if (BM.qW)
			{
				return;
			}
			if (a())
			{
				CheckForUpdatesResult checkForUpdatesResult = (CheckForUpdatesResult)P_1.Result;
				abJ = (checkForUpdatesResult.CheckSoftwareUpdatesSuccess && checkForUpdatesResult.NewSoftwareAvailable) || (checkForUpdatesResult.CheckSupportFilesUpdatesSuccess && checkForUpdatesResult.NewSupportFilesAvailable);
				if (abJ)
				{
					BM.QQ.rO.A(ar.A.BnM, 0, string.Empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ND());
				}
				else
				{
					BM.QQ.rO.A(ar.A.Bnl, 0, string.Empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abS());
				}
				if (checkForUpdatesResult.CheckSoftwareUpdatesSuccess && checkForUpdatesResult.CheckSupportFilesUpdatesSuccess && (checkForUpdatesResult.NewSoftwareAvailable || checkForUpdatesResult.NewSupportFilesAvailable) && D())
				{
					B(false);
				}
				else
				{
					string empty = string.Empty;
					empty = ((!checkForUpdatesResult.CheckSoftwareUpdatesSuccess) ? (empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCa() + checkForUpdatesResult.CheckSoftwareUpdatesErrorMessage) : ((!checkForUpdatesResult.NewSoftwareAvailable) ? (empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCA()) : (empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abz())));
					empty += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv();
					empty = ((!checkForUpdatesResult.CheckSupportFilesUpdatesSuccess) ? (empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCC() + checkForUpdatesResult.CheckSupportFilesUpdatesErrorMessage) : ((!checkForUpdatesResult.NewSupportFilesAvailable) ? (empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCb()) : (empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCB())));
					if (abJ)
					{
						if (D())
						{
							bE.A((IWin32Window)(object)BM.QQ, empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCc(), (MessageBoxButtons)0);
							B(false);
						}
						else
						{
							empty += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCD();
							if ((int)bE.A((IWin32Window)(object)BM.QQ, empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ND(), (MessageBoxButtons)4) == 6)
							{
								B(false);
							}
						}
					}
					else
					{
						bE.A((IWin32Window)(object)BM.QQ, empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCc(), (MessageBoxButtons)0);
					}
				}
			}
			else
			{
				int num = (int)P_1.Result;
				abJ = num > 1;
				if (abJ)
				{
					BM.QQ.rO.A(ar.A.BnM, 0, string.Empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ND());
					if (D())
					{
						B(false);
					}
					else if ((int)bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nc(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ND(), (MessageBoxButtons)4) == 6)
					{
						B(false);
					}
				}
				else
				{
					BM.QQ.rO.A(ar.A.Bnl, 0, string.Empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abS());
					if (num == 0)
					{
						bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCd(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else
					{
						bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCE(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCE(), (MessageBoxButtons)0);
					}
				}
			}
			abj = false;
			abK = false;
		}

		private static void a(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			if (!BM.qW)
			{
				if (a())
				{
					CheckForUpdatesResult checkForUpdatesResult = (CheckForUpdatesResult)P_1.Result;
					abJ = (checkForUpdatesResult.CheckSoftwareUpdatesSuccess && checkForUpdatesResult.NewSoftwareAvailable) || (checkForUpdatesResult.CheckSupportFilesUpdatesSuccess && checkForUpdatesResult.NewSupportFilesAvailable);
				}
				else
				{
					abJ = (int)P_1.Result > 1;
				}
				if (abJ && D())
				{
					BM.QQ.rO.A(ar.A.BnM, 0, string.Empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ND());
					B(true);
				}
				else
				{
					BM.QQ.rO.A(ar.A.Bnl, 0, string.Empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abS());
				}
				abj = false;
				abK = false;
			}
		}

		private static HashSet<string> f()
		{
			HashSet<string> val = new HashSet<string>();
			try
			{
				if (Directory.Exists(CZ.Bdl))
				{
					string[] files = Directory.GetFiles(CZ.Bdl, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCe());
					foreach (string text in files)
					{
						val.Add(text);
					}
				}
			}
			catch
			{
				val = null;
			}
			return val;
		}

		internal static void B(bool P_0)
		{
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected O, but got Unknown
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected O, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected O, but got Unknown
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Expected O, but got Unknown
			if (BM.qW || a(P_0))
			{
				return;
			}
			BM.QQ.rO.A(ar.A.Bnm, 0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCF(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCf());
			abN = null;
			abm = f();
			BackgroundWorker val = new BackgroundWorker();
			object obj = bj.A.BRt;
			if (obj == null)
			{
				DoWorkEventHandler val2 = a;
				bj.A.BRt = val2;
				obj = (object)val2;
			}
			val.DoWork += (DoWorkEventHandler)obj;
			val.WorkerReportsProgress = true;
			object obj2 = bj.A.BRT;
			if (obj2 == null)
			{
				ProgressChangedEventHandler val3 = BM.A;
				bj.A.BRT = val3;
				obj2 = (object)val3;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj2;
			if (P_0)
			{
				object obj3 = bj.A.BRU;
				if (obj3 == null)
				{
					RunWorkerCompletedEventHandler val4 = b;
					bj.A.BRU = val4;
					obj3 = (object)val4;
				}
				val.RunWorkerCompleted += (RunWorkerCompletedEventHandler)obj3;
			}
			else
			{
				object obj4 = bj.A.BRu;
				if (obj4 == null)
				{
					RunWorkerCompletedEventHandler val5 = B;
					bj.A.BRu = val5;
					obj4 = (object)val5;
				}
				val.RunWorkerCompleted += (RunWorkerCompletedEventHandler)obj4;
				BackgroundWorker val6 = new BackgroundWorker
				{
					WorkerReportsProgress = true
				};
				object obj5 = bj.A.BRV;
				if (obj5 == null)
				{
					DoWorkEventHandler val7 = B;
					bj.A.BRV = val7;
					obj5 = (object)val7;
				}
				val6.DoWork += (DoWorkEventHandler)obj5;
				object obj6 = bj.A.BRT;
				if (obj6 == null)
				{
					ProgressChangedEventHandler val8 = BM.A;
					bj.A.BRT = val8;
					obj6 = (object)val8;
				}
				val6.ProgressChanged += (ProgressChangedEventHandler)obj6;
				val6.RunWorkerAsync();
			}
			val.RunWorkerAsync();
		}

		private static void a(object P_0, DoWorkEventArgs P_1)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			Thread.CurrentThread.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCG();
			UpdateOutcomes updateOutcomes = UpdateOutcomes.Timeout;
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
			((IContextChannel)((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).InnerChannel).OperationTimeout = new TimeSpan(0, 90, 0);
			abK = true;
			try
			{
				try
				{
					updateOutcomes = nexusAWSSvcCmdClient.UpdateManual();
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCg() + ex.Message, true);
				}
				P_1.Result = updateOutcomes;
			}
			catch (System.Exception ex2)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCg() + ex2.Message, true);
				P_1.Result = 0;
			}
			finally
			{
				try
				{
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
				}
				catch (CommunicationException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCH(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (TimeoutException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCh(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (System.Exception ex3)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCI() + ex3.Message, true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
			}
		}

		private static void B(object P_0, DoWorkEventArgs P_1)
		{
			if (BM.qW)
			{
				return;
			}
			Thread.CurrentThread.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCi();
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			while (!abj)
			{
				NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
				try
				{
					float? currentPercentProgress = nexusAWSSvcCmdClient.GetCurrentPercentProgress();
					if (currentPercentProgress.HasValue)
					{
						int num = Math.Max(Math.Min((int)currentPercentProgress.Value, 100), 0);
						int num2 = (int)nexusAWSSvcCmdClient.GetCurrentDLSpeedKBps().Value;
						string text = string.Concat(new string[5]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCJ(),
							nexusAWSSvcCmdClient.GetCurrentCategory(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO(),
							num2.ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCj()
						});
						val.ReportProgress(num, (object)text);
						Thread.Sleep(100);
					}
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCK() + ex.Message, true);
					break;
				}
				finally
				{
					try
					{
						((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
					}
					catch (CommunicationException)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCk(), true);
						((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
					}
					catch (TimeoutException)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCL(), true);
						((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
					}
					catch (System.Exception ex2)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCl() + ex2.Message, true);
						((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
					}
				}
				if (!e())
				{
					break;
				}
			}
		}

		private static void b(object P_0, DoWorkEventArgs P_1)
		{
			if (BM.qW)
			{
				return;
			}
			Thread.CurrentThread.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCM();
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			while (!abj)
			{
				NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
				try
				{
					float? currentUpdateCheckProgress = nexusAWSSvcCmdClient.GetCurrentUpdateCheckProgress();
					if (currentUpdateCheckProgress.HasValue)
					{
						int num = Math.Max(Math.Min((int)currentUpdateCheckProgress.Value, 100), 0);
						string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCm() + num + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCN();
						val.ReportProgress(num, (object)text);
						Thread.Sleep(100);
					}
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCn() + ex.Message, true);
					break;
				}
				finally
				{
					try
					{
						((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
					}
					catch (CommunicationException)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCO(), true);
						((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
					}
					catch (TimeoutException)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCo(), true);
						((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
					}
					catch (System.Exception ex2)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCP() + ex2.Message, true);
						((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
					}
				}
				if (!e())
				{
					break;
				}
			}
		}

		private static void C(object P_0, DoWorkEventArgs P_1)
		{
			if (BM.qW)
			{
				return;
			}
			Thread.CurrentThread.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCp();
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			abk = true;
			while (true)
			{
				switch (F())
				{
				case UpdaterStatus.Checking:
				{
					NexusAWSSvcCmdClient nexusAWSSvcCmdClient2 = B();
					try
					{
						float? currentUpdateCheckProgress = nexusAWSSvcCmdClient2.GetCurrentUpdateCheckProgress();
						if (currentUpdateCheckProgress.HasValue)
						{
							int num3 = Math.Max(Math.Min((int)currentUpdateCheckProgress.Value, 100), 0);
							string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCm() + num3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCN();
							val.ReportProgress(num3, (object)text2);
							Thread.Sleep(100);
						}
					}
					catch (System.Exception ex3)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCQ() + ex3.Message, true);
						return;
					}
					finally
					{
						try
						{
							((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient2).Close();
						}
						catch (CommunicationException)
						{
							N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCq(), true);
							((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient2).Abort();
						}
						catch (TimeoutException)
						{
							N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCR(), true);
							((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient2).Abort();
						}
						catch (System.Exception ex4)
						{
							N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCr() + ex4.Message, true);
							((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient2).Abort();
						}
					}
					break;
				}
				case UpdaterStatus.Downloading:
				{
					NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
					try
					{
						float? currentPercentProgress = nexusAWSSvcCmdClient.GetCurrentPercentProgress();
						if (currentPercentProgress.HasValue)
						{
							int num = Math.Max(Math.Min((int)currentPercentProgress.Value, 100), 0);
							int num2 = (int)nexusAWSSvcCmdClient.GetCurrentDLSpeedKBps().Value;
							string text = string.Concat(new string[5]
							{
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCJ(),
								nexusAWSSvcCmdClient.GetCurrentCategory(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO(),
								num2.ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCj()
							});
							val.ReportProgress(num, (object)text);
							Thread.Sleep(100);
						}
					}
					catch (System.Exception ex)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCQ() + ex.Message, true);
						return;
					}
					finally
					{
						try
						{
							((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
						}
						catch (CommunicationException)
						{
							N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCq(), true);
							((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
						}
						catch (TimeoutException)
						{
							N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCR(), true);
							((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
						}
						catch (System.Exception ex2)
						{
							N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCr() + ex2.Message, true);
							((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
						}
					}
					break;
				}
				default:
					return;
				}
				Thread.Sleep(1000);
			}
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void A(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = abn;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref abn, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void a(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = abn;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref abn, val3, val2);
			}
			while (val != val2);
		}

		private static void B(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			if (!BM.qW)
			{
				UpdateOutcomes updateOutcomes = (UpdateOutcomes)P_1.Result;
				bool flag = false;
				switch (updateOutcomes)
				{
				case UpdateOutcomes.CompleteUpdate:
					abJ = false;
					Ct.A();
					abN = f();
					G();
					b(true);
					flag = true;
					break;
				case UpdateOutcomes.DownloadInstallFailed:
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCS(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					break;
				case UpdateOutcomes.InitError:
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCs(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)16);
					break;
				case UpdateOutcomes.NoUpdate:
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCT(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCt(), (MessageBoxButtons)0);
					break;
				case UpdateOutcomes.Timeout:
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCU(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)16);
					break;
				case UpdateOutcomes.Aborted:
					bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCu(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)16);
					break;
				}
				BM.QQ.rO.A(ar.A.Bnl, 0, string.Empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abS());
				abj = false;
				abK = false;
				if (abn != null)
				{
					abn.Invoke((object)flag, (EventArgs)null);
				}
			}
		}

		private static void b(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			if (!BM.qW)
			{
				UpdateOutcomes num = (UpdateOutcomes)P_1.Result;
				bool flag = false;
				BM.QQ.rO.A(ar.A.Bnl, 0, string.Empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abS());
				if (num == UpdateOutcomes.CompleteUpdate)
				{
					abJ = false;
					Ct.A();
					abN = f();
					G();
					flag = true;
				}
				abj = false;
				abK = false;
				if (abn != null)
				{
					abn.Invoke((object)flag, (EventArgs)null);
				}
			}
		}

		private static void G()
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			if (abN != null && abN.Count != 0)
			{
				HashSet<string> val = new HashSet<string>();
				if (abm != null && abm.Count != 0)
				{
					Enumerator<string> enumerator = abN.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							if (!abm.Contains(current))
							{
								val.Add(current);
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
					val.UnionWith((System.Collections.Generic.IEnumerable<string>)abN);
				}
				if (val.Count != 0)
				{
					BackgroundWorker val2 = new BackgroundWorker();
					object obj = bj.A.BRv;
					if (obj == null)
					{
						DoWorkEventHandler val3 = c;
						bj.A.BRv = val3;
						obj = (object)val3;
					}
					val2.DoWork += (DoWorkEventHandler)obj;
					val2.RunWorkerAsync((object)val);
				}
			}
			abm = null;
			abN = null;
		}

		private static void c(object P_0, DoWorkEventArgs P_1)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			Thread.CurrentThread.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCV();
			HashSet<string> val = P_1.Argument as HashSet<string>;
			abO = 0;
			int num = 0;
			Enumerator<string> enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					bT.C(enumerator.Current);
					num++;
					abO = num * 100 / val.Count;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			abO = 100;
			bT.B();
		}

		private static void C(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			if (!BM.qW)
			{
				BM.QQ.rO.A(ar.A.Bnl, 0, string.Empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abS());
				abk = false;
			}
		}

		internal static void b(bool P_0)
		{
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Invalid comparison between Unknown and I4
			//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Invalid comparison between Unknown and I4
			if (BM.qW)
			{
				return;
			}
			I();
			string text = BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCv();
			try
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
			}
			catch
			{
			}
			bool flag = false;
			bool flag2 = false;
			Version val = null;
			try
			{
				string[] files = Directory.GetFiles(BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCW(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCw(), (SearchOption)1);
				Version val2 = default(Version);
				foreach (string text2 in files)
				{
					string[] array = Path.GetFileNameWithoutExtension(text2).Split('_', (StringSplitOptions)0);
					if (array.Length >= 2 && Version.TryParse(array[1].Remove(0, 1), ref val2) && (val == (Version)null || val2 > val))
					{
						val = val2;
						abL = text2;
					}
				}
				if (File.Exists(abL))
				{
					File.Copy(abL, text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCX(), true);
				}
			}
			catch
			{
			}
			if (File.Exists(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCX()))
			{
				flag = true;
			}
			h();
			Version val3 = null;
			try
			{
				string[] files = Directory.GetFiles(BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCW(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCx(), (SearchOption)1);
				Version val4 = default(Version);
				foreach (string text3 in files)
				{
					string[] array2 = Path.GetFileNameWithoutExtension(text3).Split('_', (StringSplitOptions)0);
					if (array2.Length >= 2 && Version.TryParse(array2[1].Remove(0, 1), ref val4) && (val3 == (Version)null || val4 > val3))
					{
						val3 = val4;
						abl = text3;
					}
				}
				if (File.Exists(abl))
				{
					File.Copy(abl, text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCY(), true);
				}
			}
			catch
			{
			}
			if (File.Exists(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCY()))
			{
				flag2 = true;
			}
			bj.i();
			if (flag || flag2)
			{
				bA obj4 = new bA(val, val3);
				DialogResult val5 = ((Form)obj4).ShowDialog((IWin32Window)(object)BM.QQ);
				if ((int)val5 == 6)
				{
					BM.QQ.qd.UserOptInPrivacy = true;
					BM.QQ.qd.LastAgreedPrivacyDocumentVer = Bh.A();
					if (flag2)
					{
						abP = false;
						H();
					}
					if (flag)
					{
						abo = false;
						C(true);
					}
				}
				else if ((int)val5 == 7)
				{
					if (flag)
					{
						abo = true;
					}
					if (flag2)
					{
						abP = true;
					}
					BM.QQ.rO.A(ar.A.BnM, 0, string.Empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCy());
					BM.QQ.qd.UserOptInPrivacy = true;
					BM.QQ.qd.LastAgreedPrivacyDocumentVer = Bh.A();
				}
				else
				{
					BM.QQ.rO.A(ar.A.BnM, 0, string.Empty, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCZ());
				}
				((Component)obj4).Dispose();
			}
			else if (P_0)
			{
				Version version = Assembly.GetEntryAssembly().GetName().Version;
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCz() + ((object)version).ToString() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acA(), (MessageBoxButtons)0);
			}
			else
			{
				g();
			}
		}

		private static void g()
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected O, but got Unknown
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			if (!BM.qW && e() && !abk)
			{
				if (F() == UpdaterStatus.Downloading)
				{
					BM.QQ.rO.A(ar.A.Bnm, 0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCF(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCf());
				}
				else
				{
					BM.QQ.rO.A(ar.A.Bnm, 0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.abQ());
				}
				BackgroundWorker val = new BackgroundWorker();
				object obj = bj.A.BRW;
				if (obj == null)
				{
					DoWorkEventHandler val2 = C;
					bj.A.BRW = val2;
					obj = (object)val2;
				}
				val.DoWork += (DoWorkEventHandler)obj;
				val.WorkerReportsProgress = true;
				object obj2 = bj.A.BRT;
				if (obj2 == null)
				{
					ProgressChangedEventHandler val3 = BM.A;
					bj.A.BRT = val3;
					obj2 = (object)val3;
				}
				val.ProgressChanged += (ProgressChangedEventHandler)obj2;
				object obj3 = bj.A.BRw;
				if (obj3 == null)
				{
					RunWorkerCompletedEventHandler val4 = C;
					bj.A.BRw = val4;
					obj3 = (object)val4;
				}
				val.RunWorkerCompleted += (RunWorkerCompletedEventHandler)obj3;
				val.RunWorkerAsync();
			}
		}

		internal static void C(bool P_0)
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			if (BM.qW)
			{
				return;
			}
			BM.A((IWin32Window)(object)BM.QQ, false);
			try
			{
				c(P_0);
			}
			catch
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aca(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		internal static void H()
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			if (BM.qW)
			{
				return;
			}
			try
			{
				J();
			}
			catch
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acB(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private static void h()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			DirectoryInfo val = new DirectoryInfo(BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCW());
			if (!((FileSystemInfo)val).Exists)
			{
				return;
			}
			FileInfo[] files = val.GetFiles(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCw());
			foreach (FileInfo val2 in files)
			{
				try
				{
					File.Delete(((FileSystemInfo)val2).FullName);
				}
				catch
				{
				}
			}
		}

		private static void c(bool P_0)
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			if (BM.qW)
			{
				return;
			}
			string text = BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCv();
			_ = BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acb();
			string empty = string.Empty;
			try
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				Process val = new Process();
				val.StartInfo.FileName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acC();
				val.StartInfo.WorkingDirectory = text;
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acc() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acD();
				if (P_0)
				{
					empty += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acd();
				}
				val.StartInfo.Arguments = empty;
				val.StartInfo.Verb = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acE();
				val.Start();
				val.WaitForExit(60000);
				if (val.ExitCode == 0)
				{
					File.Delete(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCX());
				}
				else if (File.Exists(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCX()))
				{
					File.Copy(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCX(), abL, true);
					File.Delete(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCX());
				}
			}
			catch
			{
			}
		}

		private static void I()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			DirectoryInfo val = new DirectoryInfo(BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCv());
			if (((FileSystemInfo)val).Exists)
			{
				FileInfo[] files = val.GetFiles();
				for (int i = 0; i < files.Length; i++)
				{
					((FileSystemInfo)files[i]).Delete();
				}
				DirectoryInfo[] directories = val.GetDirectories();
				for (int i = 0; i < directories.Length; i++)
				{
					directories[i].Delete(true);
				}
			}
		}

		private static void i()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			DirectoryInfo val = new DirectoryInfo(BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCW());
			if (!((FileSystemInfo)val).Exists)
			{
				return;
			}
			FileInfo[] files = val.GetFiles(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCx());
			foreach (FileInfo val2 in files)
			{
				try
				{
					File.Delete(((FileSystemInfo)val2).FullName);
				}
				catch
				{
				}
			}
		}

		private static void J()
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			if (BM.qW)
			{
				return;
			}
			string text = BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCv();
			_ = BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acb();
			string empty = string.Empty;
			try
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				Process val = new Process();
				val.StartInfo.FileName = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acC();
				val.StartInfo.WorkingDirectory = text;
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acc() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ace();
				val.StartInfo.Arguments = empty;
				val.StartInfo.Verb = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acE();
				val.Start();
				val.WaitForExit(60000);
				if (val.ExitCode == 0)
				{
					File.Delete(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCY());
				}
				else if (File.Exists(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCY()))
				{
					File.Copy(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCY(), abl, true);
					File.Delete(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCY());
				}
			}
			catch
			{
			}
		}

		internal static bool A(int P_0, int P_1)
		{
			try
			{
				string text = BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBL();
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				string text2 = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acF();
				List<string> val = new List<string>();
				if (File.Exists(text2))
				{
					string[] array = File.ReadAllLines(text2);
					if (array != null)
					{
						val.AddRange((System.Collections.Generic.IEnumerable<string>)array);
					}
					File.Delete(text2);
				}
				string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acf() + P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acG() + P_1;
				if (!val.Contains(text3))
				{
					val.Add(text3);
				}
				File.WriteAllLines(text2, (System.Collections.Generic.IEnumerable<string>)val);
				return true;
			}
			catch
			{
				return false;
			}
		}

		private static int? A(string P_0, bool P_1, List<S3MetaDataKeyValuePair> P_2)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
			((IContextChannel)((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).InnerChannel).OperationTimeout = new TimeSpan(0, 3, 0);
			abK = true;
			try
			{
				if (P_1)
				{
					return nexusAWSSvcCmdClient.DefinitionsAvailable(P_2.ToArray());
				}
				return nexusAWSSvcCmdClient.ObjectsAvailableTagged(P_0, P_2.ToArray());
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acg() + ex.Message, true);
				return null;
			}
			finally
			{
				try
				{
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
				}
				catch (CommunicationException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acH(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (TimeoutException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ach(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (System.Exception ex2)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acI() + ex2.Message, true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
			}
		}

		private static int? A(string P_0, List<S3MetaDataKeyValuePair> P_1)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
			((IContextChannel)((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).InnerChannel).OperationTimeout = new TimeSpan(0, 3, 0);
			abK = true;
			try
			{
				return nexusAWSSvcCmdClient.LatestObjectVersionAvailableTagged(P_0, P_1.ToArray());
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aci() + ex.Message, true);
				return null;
			}
			finally
			{
				try
				{
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
				}
				catch (CommunicationException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acJ(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (TimeoutException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acj(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (System.Exception ex2)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acK() + ex2.Message, true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
			}
		}

		private static List<S3MetaDataKeyValuePair> A(int P_0, int P_1, k P_2)
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			List<S3MetaDataKeyValuePair> val = new List<S3MetaDataKeyValuePair>();
			S3MetaDataKeyValuePair s3MetaDataKeyValuePair = new S3MetaDataKeyValuePair();
			s3MetaDataKeyValuePair.Key = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ack();
			s3MetaDataKeyValuePair.Value = P_0.ToString();
			val.Add(s3MetaDataKeyValuePair);
			S3MetaDataKeyValuePair s3MetaDataKeyValuePair2 = new S3MetaDataKeyValuePair();
			s3MetaDataKeyValuePair2.Key = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acL();
			s3MetaDataKeyValuePair2.Value = P_1.ToString();
			val.Add(s3MetaDataKeyValuePair2);
			Version val2 = default(Version);
			if (Version.TryParse(aY.A(), ref val2) && val2 >= new Version(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acl()))
			{
				S3MetaDataKeyValuePair s3MetaDataKeyValuePair3 = new S3MetaDataKeyValuePair();
				s3MetaDataKeyValuePair3.Key = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acM();
				s3MetaDataKeyValuePair3.Value = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acm() + P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acN() + P_1;
				val.Add(s3MetaDataKeyValuePair3);
			}
			if (P_2 != null)
			{
				S3MetaDataKeyValuePair s3MetaDataKeyValuePair4 = new S3MetaDataKeyValuePair();
				s3MetaDataKeyValuePair4.Key = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acn();
				s3MetaDataKeyValuePair4.Value = P_2.A().ToString();
				val.Add(s3MetaDataKeyValuePair4);
				S3MetaDataKeyValuePair s3MetaDataKeyValuePair5 = new S3MetaDataKeyValuePair();
				s3MetaDataKeyValuePair5.Key = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acO();
				s3MetaDataKeyValuePair5.Value = P_2.a().ToString();
				val.Add(s3MetaDataKeyValuePair5);
				S3MetaDataKeyValuePair s3MetaDataKeyValuePair6 = new S3MetaDataKeyValuePair();
				s3MetaDataKeyValuePair6.Key = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aco();
				s3MetaDataKeyValuePair6.Value = P_2.B().ToString();
				val.Add(s3MetaDataKeyValuePair6);
				S3MetaDataKeyValuePair s3MetaDataKeyValuePair7 = new S3MetaDataKeyValuePair();
				s3MetaDataKeyValuePair7.Key = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bk();
				s3MetaDataKeyValuePair7.Value = P_2.b().ToString();
				val.Add(s3MetaDataKeyValuePair7);
				S3MetaDataKeyValuePair s3MetaDataKeyValuePair8 = new S3MetaDataKeyValuePair();
				s3MetaDataKeyValuePair8.Key = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acP();
				s3MetaDataKeyValuePair8.Value = P_2.C().ToString();
				val.Add(s3MetaDataKeyValuePair8);
			}
			return val;
		}

		private static UpdateOutcomes A(bool P_0, out string[] P_1)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			UpdateOutcomes result = UpdateOutcomes.Timeout;
			string[] downloadedFilePaths = null;
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
			((IContextChannel)((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).InnerChannel).OperationTimeout = new TimeSpan(0, 10, 0);
			abK = true;
			try
			{
				try
				{
					result = ((!P_0) ? nexusAWSSvcCmdClient.GetTaggedObjects(out downloadedFilePaths) : nexusAWSSvcCmdClient.GetDefinitionObjects(out downloadedFilePaths));
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acp() + ex.Message, true);
				}
				P_1 = downloadedFilePaths;
				return result;
			}
			catch (System.Exception ex2)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acp() + ex2.Message, true);
				P_1 = downloadedFilePaths;
				return UpdateOutcomes.NoUpdate;
			}
			finally
			{
				try
				{
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
				}
				catch (CommunicationException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acQ(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (TimeoutException)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acq(), true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
				catch (System.Exception ex3)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acR() + ex3.Message, true);
					((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
				}
			}
		}

		internal static void D(object P_0, DoWorkEventArgs P_1)
		{
			Thread.CurrentThread.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acr();
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			while (abM)
			{
				NexusAWSSvcCmdClient nexusAWSSvcCmdClient = B();
				try
				{
					int? currentTaggedFilePercentProgress = nexusAWSSvcCmdClient.GetCurrentTaggedFilePercentProgress();
					if (currentTaggedFilePercentProgress.HasValue)
					{
						int num = Math.Max(Math.Min(currentTaggedFilePercentProgress.Value, 100), 0);
						string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acS() + nexusAWSSvcCmdClient.GetCurrentTaggedFileDownloading();
						val.ReportProgress(num, (object)text);
						Thread.Sleep(100);
					}
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acs() + ex.Message, true);
					break;
				}
				finally
				{
					try
					{
						((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Close();
					}
					catch (CommunicationException)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acT(), true);
						((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
					}
					catch (TimeoutException)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.act(), true);
						((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
					}
					catch (System.Exception ex2)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acU() + ex2.Message, true);
						((ClientBase<INexusAWSSvcCmd>)nexusAWSSvcCmdClient).Abort();
					}
				}
			}
		}

		internal static string A(int P_0, int P_1, out int? P_2, out UpdateOutcomes P_3)
		{
			P_2 = null;
			P_3 = UpdateOutcomes.NoUpdate;
			if (e())
			{
				return null;
			}
			string result = null;
			List<S3MetaDataKeyValuePair> val = A(P_0, P_1, null);
			P_2 = A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acu(), val);
			P_3 = A(false, out var array);
			if (array != null && array.Length == 1)
			{
				result = array[0];
			}
			abM = false;
			return result;
		}

		internal static string[] A(k P_0, int P_1, int P_2, string P_3, out int? P_4, out UpdateOutcomes P_5)
		{
			string[] result = null;
			P_4 = null;
			P_5 = UpdateOutcomes.NoUpdate;
			if (File.Exists(P_3))
			{
				result = new string[1] { P_3 };
				P_4 = 1;
				P_5 = UpdateOutcomes.CompleteUpdate;
			}
			else
			{
				if (E())
				{
					return null;
				}
				List<S3MetaDataKeyValuePair> val = A(P_1, P_2, P_0);
				bool flag = false;
				if (bx.A(P_1) && P_0.A() < 3)
				{
					flag = true;
				}
				if (flag)
				{
					P_4 = A(string.Empty, true, val);
					P_5 = A(true, out result);
				}
				else
				{
					P_4 = A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acu(), false, val);
					P_5 = A(false, out result);
				}
				if (!P_4.HasValue || P_5 != UpdateOutcomes.CompleteUpdate)
				{
					P_4 = A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.acV(), false, val);
					P_5 = A(false, out result);
				}
			}
			abM = false;
			return result;
		}
	}
}
