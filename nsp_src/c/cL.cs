using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.SettingsFramework;
using NSP.UserInterface;

namespace c
{
	internal class cL : MovableResizablePanel
	{
		private Z BJG;

		internal cL(Framework P_0, Rectangle P_1, bool P_2)
			: base(P_1, P_2, false, true)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			BJG = new Z(P_0.awO, P_0);
			((Control)this).Controls.Add((Control)(object)BJG);
			UpdateLayout(resizingOnly: false);
			((Control)this).ContextMenuStrip = a();
		}

		protected override void Dispose(bool disposing)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			try
			{
				foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
				{
					((ToolStripItem)item).Click -= new EventHandler(A);
				}
				((ToolStripDropDown)((Control)this).ContextMenuStrip).Opened -= new EventHandler(a);
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		public override string ToString()
		{
			string text = ((Panel)this).ToString();
			return string.Concat(new string[5]
			{
				text,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAZ(),
				((Control)this).Left.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAz(),
				((Control)this).Top.ToString()
			});
		}

		public override void UpdateLayout(bool resizingOnly)
		{
			((Control)BJG).Left = 10;
			((Control)BJG).Top = 10;
			((Control)BJG).Width = ((Control)this).Width - 20;
			((Control)BJG).Height = ((Control)this).Height - 20;
			((Control)BJG).Invalidate();
		}

		private void A(object P_0, EventArgs P_1)
		{
			q.A((Control)(object)this);
			BM.QQ.rl.a(false);
		}

		private void a(object P_0, EventArgs P_1)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			if (((Control)this).ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
			{
				ToolStripMenuItem val = item;
				if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaS())
				{
					((ToolStripItem)val).Enabled = !BM.QQ.rl.a((Control)(object)this);
					break;
				}
			}
		}

		private ContextMenuStrip a()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			ContextMenuStrip val = new ContextMenuStrip
			{
				BackColor = BM.tG,
				ForeColor = BM.te
			};
			((ToolStripDropDown)val).Opened += new EventHandler(a);
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaS();
			((ToolStripItem)val2).Click += new EventHandler(A);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
			return val;
		}

		internal void A(string P_0, int P_1, int P_2)
		{
			List<string> val = new List<string>();
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bas());
			int num = ((Control)this).Left - P_1;
			int num2 = ((Control)this).Top - P_2;
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
		}

		internal void A(StreamReader P_0)
		{
			string text;
			while ((text = ((TextReader)P_0).ReadLine()) != null && !string.IsNullOrWhiteSpace(text))
			{
			}
		}
	}
	internal class cl : MovableResizablePanel
	{
		private z BJg;

		internal cl(Framework P_0, Rectangle P_1, bool P_2)
			: base(P_1, P_2, false, true)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			BJg = new z(P_0.awO, P_0);
			((Control)this).Controls.Add((Control)(object)BJg);
			UpdateLayout(resizingOnly: false);
			((Control)this).ContextMenuStrip = a();
		}

		protected override void Dispose(bool disposing)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			try
			{
				foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
				{
					((ToolStripItem)item).Click -= new EventHandler(A);
				}
				((ToolStripDropDown)((Control)this).ContextMenuStrip).Opened -= new EventHandler(a);
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		public override string ToString()
		{
			string text = ((Panel)this).ToString();
			return string.Concat(new string[5]
			{
				text,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAZ(),
				((Control)this).Left.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAz(),
				((Control)this).Top.ToString()
			});
		}

		public override void UpdateLayout(bool resizingOnly)
		{
			((Control)BJg).Left = 10;
			((Control)BJg).Top = 10;
			((Control)BJg).Width = ((Control)this).Width - 20;
			((Control)BJg).Height = ((Control)this).Height - 20;
			((Control)BJg).Invalidate();
		}

		private void A(object P_0, EventArgs P_1)
		{
			q.A((Control)(object)this);
			BM.QQ.rl.a(false);
		}

		private void a(object P_0, EventArgs P_1)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			if (((Control)this).ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
			{
				ToolStripMenuItem val = item;
				if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaT())
				{
					((ToolStripItem)val).Enabled = !BM.QQ.rl.a((Control)(object)this);
					break;
				}
			}
		}

		private ContextMenuStrip a()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			ContextMenuStrip val = new ContextMenuStrip
			{
				BackColor = BM.tG,
				ForeColor = BM.te
			};
			((ToolStripDropDown)val).Opened += new EventHandler(a);
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaT();
			((ToolStripItem)val2).Click += new EventHandler(A);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
			return val;
		}

		internal void A(string P_0, int P_1, int P_2)
		{
			List<string> val = new List<string>();
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bat());
			int num = ((Control)this).Left - P_1;
			int num2 = ((Control)this).Top - P_2;
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
		}

		internal void A(StreamReader P_0)
		{
			string text;
			while ((text = ((TextReader)P_0).ReadLine()) != null && !string.IsNullOrWhiteSpace(text))
			{
			}
		}
	}
}
namespace C
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class CL
	{
		private static ResourceManager BCK;

		private static CultureInfo BCk;

		[EditorBrowsable(/*Could not decode attribute arguments.*/)]
		internal static ResourceManager bbl
		{
			get
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Expected O, but got Unknown
				if (BCK == null)
				{
					BCK = new ResourceManager("C.CL", typeof(CL).Assembly);
				}
				return BCK;
			}
		}

		[EditorBrowsable(/*Could not decode attribute arguments.*/)]
		internal static CultureInfo bbM
		{
			get
			{
				return BCk;
			}
			set
			{
				BCk = value;
			}
		}

		internal CL()
		{
		}

		[SpecialName]
		internal static Bitmap B()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUG(), BCk);
		}

		[SpecialName]
		internal static Bitmap b()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUg(), BCk);
		}

		[SpecialName]
		internal static Bitmap C()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUH(), BCk);
		}

		[SpecialName]
		internal static Bitmap c()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUh(), BCk);
		}

		[SpecialName]
		internal static Bitmap D()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUI(), BCk);
		}

		[SpecialName]
		internal static Bitmap d()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUi(), BCk);
		}

		[SpecialName]
		internal static Bitmap E()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUJ(), BCk);
		}

		[SpecialName]
		internal static Bitmap e()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUj(), BCk);
		}

		[SpecialName]
		internal static Bitmap F()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUK(), BCk);
		}

		[SpecialName]
		internal static Bitmap f()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUk(), BCk);
		}

		[SpecialName]
		internal static Bitmap G()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUL(), BCk);
		}

		[SpecialName]
		internal static Bitmap g()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUl(), BCk);
		}

		[SpecialName]
		internal static Bitmap H()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUM(), BCk);
		}

		[SpecialName]
		internal static Bitmap h()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUm(), BCk);
		}

		[SpecialName]
		internal static Bitmap I()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUN(), BCk);
		}

		[SpecialName]
		internal static Bitmap i()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUn(), BCk);
		}

		[SpecialName]
		internal static Bitmap J()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aUO(), BCk);
		}

		[SpecialName]
		internal static Bitmap j()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbl.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aI(), BCk);
		}
	}
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Cl
	{
		private static ResourceManager BCM;

		private static CultureInfo BCm;

		[EditorBrowsable(/*Could not decode attribute arguments.*/)]
		internal static ResourceManager bbm
		{
			get
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Expected O, but got Unknown
				if (BCM == null)
				{
					BCM = new ResourceManager("C.Cl", typeof(Cl).Assembly);
				}
				return BCM;
			}
		}

		[EditorBrowsable(/*Could not decode attribute arguments.*/)]
		internal static CultureInfo bbN
		{
			get
			{
				return BCm;
			}
			set
			{
				BCm = value;
			}
		}

		internal Cl()
		{
		}

		[SpecialName]
		internal static Bitmap B()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anp(), BCm);
		}

		[SpecialName]
		internal static Bitmap b()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anN(), BCm);
		}

		[SpecialName]
		internal static Bitmap C()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ank(), BCm);
		}

		[SpecialName]
		internal static Bitmap c()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOb(), BCm);
		}

		[SpecialName]
		internal static Bitmap D()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.any(), BCm);
		}

		[SpecialName]
		internal static Bitmap d()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anv(), BCm);
		}

		[SpecialName]
		internal static Bitmap E()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ans(), BCm);
		}

		[SpecialName]
		internal static Bitmap e()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOk(), BCm);
		}

		[SpecialName]
		internal static Bitmap F()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOh(), BCm);
		}

		[SpecialName]
		internal static Bitmap f()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOe(), BCm);
		}

		[SpecialName]
		internal static Bitmap G()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOX(), BCm);
		}

		[SpecialName]
		internal static Bitmap g()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOr(), BCm);
		}

		[SpecialName]
		internal static Bitmap H()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOn(), BCm);
		}

		[SpecialName]
		internal static Bitmap h()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNA(), BCm);
		}

		[SpecialName]
		internal static Bitmap I()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amL(), BCm);
		}

		[SpecialName]
		internal static Bitmap i()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amI(), BCm);
		}

		[SpecialName]
		internal static Bitmap J()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amF(), BCm);
		}

		[SpecialName]
		internal static Bitmap j()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anD(), BCm);
		}

		[SpecialName]
		internal static Bitmap K()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNZ(), BCm);
		}

		[SpecialName]
		internal static Bitmap k()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anH(), BCm);
		}

		[SpecialName]
		internal static Bitmap L()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amR(), BCm);
		}

		[SpecialName]
		internal static Bitmap l()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amO(), BCm);
		}

		[SpecialName]
		internal static Bitmap M()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amX(), BCm);
		}

		[SpecialName]
		internal static Bitmap m()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			return (Bitmap)bbm.GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amU(), BCm);
		}
	}
}
