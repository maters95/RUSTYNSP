using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;
using c;

namespace D;

internal class DD : cq, Y
{
	private new delegate void A(object P_0, EventArgs P_1);

	private new delegate void a(object P_0, EventArgs P_1);

	private new delegate void B(object P_0, EventArgs P_1);

	private new delegate void b(object P_0, EventArgs P_1);

	private const int BWh = 5;

	private const int BWI = 5;

	private const int BWi = 6;

	private const int BWJ = 0;

	private const int BWj = 48;

	private const int BWK = 400;

	private const int BWk = 80;

	private const int BWL = 42;

	private const int BWl = 4;

	private const int BWM = 250;

	private int BWm;

	private Framework BWN;

	private Framework BWn;

	private SettingOrSpecialObject BWO;

	private Setting BWo;

	private Setting BWP;

	private MenuNode BWp;

	private aF BWQ = new aF();

	private List<Label> BWq = new List<Label>();

	private List<List<string>> BWR = new List<List<string>>();

	private List<List<int>> BWr = new List<List<int>>();

	private List<Dn> BWS = new List<Dn>();

	private aP BWs = new aP();

	private PictureBox BWT = new PictureBox();

	private Label BWt = new Label();

	private Label BWU = new Label();

	private HashSet<Setting> BWu = new HashSet<Setting>();

	private Rectangle BWV;

	private static Df BWv;

	internal DD(SettingOrSpecialObject P_0, MenuNode P_1, Framework P_2, Framework P_3, Rectangle P_4, bool P_5)
		: base(P_4, P_5, false)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		BWO = P_0;
		BWN = P_2;
		BWn = P_3;
		BWp = P_1;
		BWo = null;
		if (BWp.h() != 0 && (BM.qC == null || BM.qD.Contains(BWp.h())))
		{
			BWo = BWN.A(BWp.h());
			if (BWn != null)
			{
				BWP = BWn.A(BWp.h());
			}
		}
		BWV = P_4;
		global::A.A.A((global::A.D)E);
		BM.D(new EventHandler(E));
		BM.QQ.B(new EventHandler(B));
		Enumerator<WiringPin> enumerator = BWN.awc.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				WiringPin current = enumerator.Current;
				if (current.e())
				{
					BWu.Add(BWN.A(current.Bbx));
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		Enumerator<Setting> enumerator2 = BWu.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				enumerator2.Current.A(new EventHandler(g));
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		try
		{
			if (BWp.h() != 0)
			{
				((CheckBox)BWs).CheckedChanged -= new EventHandler(c);
				if (BWo != null)
				{
					BWo.a(new EventHandler(D));
				}
			}
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val = item;
				if (val is PictureBox && BWp.h() != 0)
				{
					((val is PictureBox) ? val : null).Click -= new EventHandler(d);
				}
			}
			Enumerator<Dn> enumerator2 = BWS.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					Dn current = enumerator2.Current;
					current.a(new EventHandler(b));
					((SettingOrSpecialObject)current).a(new EventHandler(C));
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			BWS.Clear();
			if (((ArrangedElementCollection)((Control)BWQ).Controls).Count != 0)
			{
				foreach (Control item2 in (ArrangedElementCollection)((Control)BWQ).Controls)
				{
					foreach (Control item3 in (ArrangedElementCollection)item2.Controls)
					{
						Control val2 = item3;
						if (val2 is Button)
						{
							((val2 is Button) ? val2 : null).Click -= new EventHandler(H);
							((val2 is Button) ? val2 : null).Click -= new EventHandler(I);
							((val2 is Button) ? val2 : null).Click -= new EventHandler(h);
							Dn dn = null;
							if (((val2 is Button) ? val2 : null).Tag is int)
							{
								dn = BWN.A((int)((val2 is Button) ? val2 : null).Tag) as Dn;
							}
							if (dn != null)
							{
								dn.a(new EventHandler(b));
								((SettingOrSpecialObject)dn).a(new EventHandler(C));
							}
							if (BWn != null)
							{
								dn = null;
								if (((val2 is Button) ? val2 : null).Tag is int)
								{
									dn = BWn.A((int)((val2 is Button) ? val2 : null).Tag) as Dn;
								}
								if (dn != null)
								{
									dn.a(new EventHandler(b));
									((SettingOrSpecialObject)dn).a(new EventHandler(C));
								}
							}
						}
						else if (val2 is Label && val2.Name != null && val2.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGw())
						{
							val2.MouseEnter -= new EventHandler(f);
							val2.MouseLeave -= new EventHandler(G);
						}
						else if (val2 is PictureBox && val2.Name != null && val2.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGX())
						{
							val2.Click -= new EventHandler(F);
							val2.MouseEnter -= new EventHandler(f);
							if (BM.SR == val2)
							{
								BM.SR = null;
							}
						}
					}
				}
			}
			Enumerator<Label> enumerator4 = BWq.GetEnumerator();
			try
			{
				while (enumerator4.MoveNext())
				{
					SettingOrSpecialObject settingOrSpecialObject = (((Control)enumerator4.Current).Tag as SettingOrSpecialObject[])[0];
					for (int i = 0; i < settingOrSpecialObject.F().b().Count; i++)
					{
						settingOrSpecialObject.F().b()[i].a(new EventHandler(e));
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator4).Dispose();
			}
			global::A.A.a((global::A.D)E);
			BM.d(new EventHandler(E));
			BM.QQ.b(new EventHandler(B));
			Enumerator<Setting> enumerator5 = BWu.GetEnumerator();
			try
			{
				while (enumerator5.MoveNext())
				{
					enumerator5.Current.a(new EventHandler(g));
				}
			}
			finally
			{
				((System.IDisposable)enumerator5).Dispose();
			}
			BWu.Clear();
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public Control A(DataIdAndAttrId P_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val = item;
			if ((val is DE && ((aj)(val as DE)).b().C() == P_0) || (val is cu && ((aj)(val as cu)).b().C() == P_0) || (val is ct && (val as ct).b().C() == P_0))
			{
				return val;
			}
		}
		return null;
	}

	public Control A()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
		{
			Control val = item;
			if (val is DE || val is cu || val is ct)
			{
				return val;
			}
		}
		return null;
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		if (resizingOnly)
		{
			A(false);
			return;
		}
		((Control)base.B()).Controls.Clear();
		A(true);
	}

	[SpecialName]
	internal new Setting B()
	{
		return BWo;
	}

	private void B(object P_0, EventArgs P_1)
	{
		A(false);
	}

	private void b(object P_0, EventArgs P_1)
	{
		if (BM.QO != BM.b.BpG)
		{
			A(false);
			BM.b(((Setting)(P_0 as Dn)).A());
		}
	}

	private void C(object P_0, EventArgs P_1)
	{
		A(false);
	}

	private void c(object P_0, EventArgs P_1)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG || !BWN.C() || BWO == null)
		{
			return;
		}
		aP aP = P_0 as aP;
		Setting setting = BWN.A((int)((Control)aP).Tag);
		if (!BM.QP)
		{
			if (((CheckBox)aP).Checked)
			{
				Setting setting2 = null;
				MenuNode menuNode = null;
				string text = ((SettingOrSpecialObject)setting).P();
				if (text == null)
				{
					menuNode = BWp;
					if (menuNode != null)
					{
						text = menuNode.t();
					}
				}
				else
				{
					setting2 = setting;
				}
				Ck ck = BM.aM();
				if (text != null && !Bg.A(setting2, menuNode))
				{
					Bg bg = new Bg(text, setting2, menuNode);
					if ((int)((Form)bg).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
					{
						ck?.A(setting.A());
						setting.a(1, true);
					}
					else
					{
						((CheckBox)aP).Checked = false;
					}
					((Component)bg).Dispose();
				}
				else
				{
					ck?.A(setting.A());
					setting.a(1, true);
				}
				if (((CheckBox)aP).Checked)
				{
					PortFunction.A(BWO, false);
					ck?.B();
				}
			}
			else
			{
				Ck ck2 = BM.aM();
				ck2?.A(setting.A());
				setting.a(0, true);
				((Control)BWT).Visible = false;
				ck2?.B();
			}
		}
		BM.b(setting.A());
	}

	private void D(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = D;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BM.QO != BM.b.BpG && ((CheckBox)BWs).Checked != (BWo.ax() == 1))
		{
			((CheckBox)BWs).Checked = BWo.ax() == 1;
		}
	}

	private void d(object P_0, EventArgs P_1)
	{
		PictureBox val = (PictureBox)((P_0 is PictureBox) ? P_0 : null);
		BM.A(BWN.A((int)((Control)val).Tag), (Control)(object)val);
	}

	private new bool b()
	{
		if (BM.QO == BM.b.BpG && BWP != null)
		{
			if (BWn.B() && BWn.b())
			{
				return BWP.J();
			}
			return false;
		}
		if (BWN.B() && BWN.b())
		{
			return BWo.J();
		}
		return false;
	}

	private new void C()
	{
		string text = ((!(((Control)this).Parent is Df)) ? BWp.A(false, false) : BWp.E());
		if (BM.QO == BM.b.BpG && BWP != null)
		{
			BWs.jd = true;
			((Control)BWs).Enabled = false;
			if (((CheckBox)BWs).Checked != (BWP.ax() == 1))
			{
				((CheckBox)BWs).Checked = !((CheckBox)BWs).Checked;
			}
			if (b())
			{
				((Control)BWs).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGx() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGY();
			}
			else
			{
				((Control)BWs).Text = text;
			}
		}
		else if (b())
		{
			BWs.jd = true;
			((Control)BWs).Enabled = false;
			if (((CheckBox)BWs).Checked != (BWo.ax() == 1))
			{
				((CheckBox)BWs).Checked = !((CheckBox)BWs).Checked;
			}
			((Control)BWs).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGx() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGY();
		}
		else
		{
			BWs.jd = false;
			((Control)BWs).Enabled = BWN.C();
			if (((CheckBox)BWs).Checked != (BWo.ax() == 1))
			{
				((CheckBox)BWs).Checked = !((CheckBox)BWs).Checked;
			}
			((Control)BWs).Text = text;
		}
	}

	private void c()
	{
		if (((SettingOrSpecialObject)BWo).l() && !BWo.O())
		{
			switch (BWo.P())
			{
			case IllegalitySeverityLevel.Error:
				BWT.Image = (Image)(object)GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Warning:
				BWT.Image = (Image)(object)GeneralResources.YellowWarning;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (BM.A(BWN.aXc, true))
				{
					BWT.Image = (Image)(object)GeneralResources.RedError;
				}
				else
				{
					BWT.Image = (Image)(object)GeneralResources.YellowWarning;
				}
				break;
			default:
				BWT.Image = (Image)(object)GeneralResources.RedError;
				break;
			}
			((Control)BWT).Visible = true;
		}
		else
		{
			((Control)BWT).Visible = false;
			BWT.Image = (Image)(object)GeneralResources.QuestionMark;
		}
	}

	internal new void A(bool P_0)
	{
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected O, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		if (BWO == null)
		{
			return;
		}
		((Control)this).SuspendLayout();
		((Control)base.B()).SuspendLayout();
		int num = 5;
		int num2 = 5;
		string text = ((!(((Control)this).Parent is Df)) ? BWp.A(false, false) : BWp.E());
		if (BWo != null)
		{
			if (!P_0)
			{
				if (!BWo.am())
				{
					C();
					c();
					num2 = ((Control)BWs).Bottom + 6;
				}
				else
				{
					c();
					num2 = ((Control)BWT).Bottom + 6;
				}
			}
			else
			{
				if (!BWo.am())
				{
					((Control)BWs).Enabled = BWN.C();
					((Control)BWs).Font = new Font(((Control)BWs).Font.FontFamily, 10f, (FontStyle)1);
					((Control)BWs).ForeColor = BM.tf;
					C();
					((Control)BWs).Left = num;
					((Control)BWs).Top = num2;
					((Control)BWs).AutoSize = true;
					((Control)BWs).Tag = BWo.A();
					((CheckBox)BWs).CheckedChanged += new EventHandler(c);
					BWo.A(new EventHandler(D));
					((Control)base.B()).Controls.Add((Control)(object)BWs);
				}
				else if (BWp.Q())
				{
					Label val = new Label();
					((Control)val).Text = text;
					((Control)val).ForeColor = BM.tf;
					((Control)val).Font = new Font(((Control)val).Font.FontFamily, 10f, (FontStyle)1);
					((Control)val).BackColor = Color.Transparent;
					((Control)val).AutoSize = true;
					((Control)val).Left = num;
					((Control)val).Top = num2;
					((Control)base.B()).Controls.Add((Control)(object)val);
					num += ((Control)val).Width + 10;
				}
				((Control)base.B()).ResumeLayout(true);
				((Control)this).ResumeLayout(true);
				((Control)this).SuspendLayout();
				((Control)base.B()).SuspendLayout();
				((Control)BWT).Tag = BWo.A();
				((Control)BWT).Width = 18;
				((Control)BWT).Height = 18;
				if (BWo.am())
				{
					((Control)BWT).Left = num;
				}
				else
				{
					((Control)BWT).Left = num + ((Control)BWs).Width;
				}
				((Control)BWT).Top = num2 + 2;
				BWT.SizeMode = (PictureBoxSizeMode)1;
				((Control)BWT).Click += new EventHandler(d);
				c();
				((Control)base.B()).Controls.Add((Control)(object)BWT);
				((Control)BWT).BringToFront();
				num = 5;
				num2 = ((Control)BWT).Bottom + 6;
			}
		}
		else if (BWp.Q())
		{
			Label val2 = new Label();
			((Control)val2).Text = text;
			((Control)val2).ForeColor = BM.tf;
			((Control)val2).Font = new Font(((Control)val2).Font.FontFamily, 10f, (FontStyle)1);
			((Control)val2).BackColor = Color.Transparent;
			((Control)val2).AutoSize = true;
			((Control)val2).Left = num;
			((Control)val2).Top = num2;
			num2 = ((Control)val2).Bottom + 6;
			if (P_0)
			{
				((Control)base.B()).Controls.Add((Control)(object)val2);
			}
			else
			{
				((Component)val2).Dispose();
			}
		}
		if (P_0)
		{
			E();
		}
		if (!P_0)
		{
			num2 = ((!((Control)BWt).Visible) ? ((Control)BWt).Top : ((Control)BWt).Bottom);
		}
		else
		{
			((Control)BWt).Visible = true;
			((Control)BWt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGy();
			((Control)BWt).ForeColor = BM.tf;
			((Control)BWt).Font = new Font(((Control)BWt).Font.FontFamily, 8.25f, (FontStyle)1);
			if (BWo != null)
			{
				((Control)BWt).Top = num2 + 5;
			}
			else
			{
				((Control)BWt).Top = num2;
			}
			((Control)BWt).Left = 5;
			((Control)base.B()).Controls.Add((Control)(object)BWt);
			num2 = ((Control)BWt).Bottom;
		}
		SettingOrSpecialObject settingOrSpecialObject = D();
		if (!A(settingOrSpecialObject, false, ref num, ref num2, P_0) && P_0)
		{
			num2 -= ((Control)BWt).Height;
			((Control)BWt).Visible = false;
		}
		if (P_0)
		{
			((Control)BWU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IU();
			((Control)BWU).ForeColor = BM.tf;
			((Control)BWU).Font = new Font(((Control)BWU).Font.FontFamily, 8.25f, (FontStyle)1);
			((Control)BWU).Left = 5;
		}
		if (((Control)BWU).Top != num2 + 5)
		{
			((Control)BWU).Top = num2 + 5;
		}
		if (P_0)
		{
			((Control)base.B()).Controls.Add((Control)(object)BWU);
		}
		num2 = ((Control)BWU).Bottom;
		if (P_0)
		{
			((Panel)BWQ).BorderStyle = (BorderStyle)1;
			((Control)BWQ).BackColor = BM.tG;
			((Control)BWQ).Left = 5;
			if (BWV != Rectangle.Empty)
			{
				((Control)BWQ).Width = ((Control)this).Width - 20;
			}
		}
		if (((Control)BWQ).Top != num2)
		{
			((Control)BWQ).Top = num2;
		}
		if (BWV != Rectangle.Empty)
		{
			int num3 = Math.Max(((Control)this).Height - ((Control)BWQ).Top - 10, 160);
			if (((Control)BWQ).Height != num3)
			{
				((Control)BWQ).Height = num3;
			}
		}
		if (P_0)
		{
			((Control)base.B()).Controls.Add((Control)(object)BWQ);
		}
		BWm = 0;
		if (P_0)
		{
			BWq.Clear();
		}
		if (settingOrSpecialObject.F().Bbd)
		{
			A(settingOrSpecialObject, P_0);
			a(settingOrSpecialObject, P_0);
		}
		else
		{
			a(settingOrSpecialObject, P_0);
			A(settingOrSpecialObject, P_0);
		}
		if (BWV == Rectangle.Empty)
		{
			int num4 = 0;
			int num5 = 0;
			foreach (Control item in (ArrangedElementCollection)((Control)base.B()).Controls)
			{
				Control val3 = item;
				num4 = Math.Max(num4, val3.Right + 10);
				num5 = Math.Max(num5, val3.Bottom + 10);
			}
			((Control)this).Width = num4;
			((Control)this).Height = num5;
		}
		((Control)base.B()).ResumeLayout(true);
		((Control)this).ResumeLayout(true);
		if (BM.QO != BM.b.BpG)
		{
			d();
		}
	}

	private SettingOrSpecialObject D()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		SettingOrSpecialObject settingOrSpecialObject = BWO;
		if (BM.QO == BM.b.BpG && BWn != null)
		{
			List<Do> val = new List<Do>();
			PortFunction.A(BWO, false, false, val);
			Enumerator<Do> enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Do current = enumerator.Current;
					Setting setting = BWn.A(current.A());
					if (setting != null && ((SettingOrSpecialObject)setting).D() != null)
					{
						settingOrSpecialObject = ((SettingOrSpecialObject)setting).D();
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (settingOrSpecialObject == BWO)
			{
				List<Dn> val2 = new List<Dn>();
				PortFunction.A(BWO, false, val2);
				Enumerator<Dn> enumerator2 = val2.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Dn current2 = enumerator2.Current;
						Setting setting2 = BWn.A(((Setting)current2).A());
						if (setting2 != null && ((SettingOrSpecialObject)setting2).D() != null)
						{
							settingOrSpecialObject = ((SettingOrSpecialObject)setting2).D();
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
		return settingOrSpecialObject;
	}

	private void d()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		BWR.Clear();
		BWr.Clear();
		Enumerator<Label> enumerator = BWq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Label current = enumerator.Current;
				List<string> val = new List<string>();
				List<int> val2 = new List<int>();
				SettingOrSpecialObject settingOrSpecialObject = (((Control)current).Tag as SettingOrSpecialObject[])[0];
				Dn dn = (((Control)current).Tag as SettingOrSpecialObject[])[1] as Dn;
				List<int> val3 = null;
				if (dn != null)
				{
					val3 = ((SettingOrSpecialObject)dn).F().C();
				}
				else
				{
					Cg bSQ = settingOrSpecialObject.F().E().BSQ;
					CH bSq = settingOrSpecialObject.F().E().BSq;
					byte bSR = settingOrSpecialObject.F().E().BSR;
					ushort bSr = settingOrSpecialObject.F().E().BSr;
					List<Dn> val4 = PortFunction.A(BWN, bSQ, bSq, bSR, bSr, false);
					if (val4 != null && val4.Count == 1)
					{
						val3 = ((SettingOrSpecialObject)val4[0]).F().C();
					}
				}
				for (int i = 0; i < settingOrSpecialObject.F().b().Count; i++)
				{
					Setting setting = settingOrSpecialObject.F().b()[i];
					int bBZ = ((SettingOrSpecialObject)setting).F().BBZ;
					if (bBZ == -1 || val3 == null || val3.Contains(bBZ))
					{
						setting.a(new EventHandler(e));
						setting.A(new EventHandler(e));
						int num = setting.aS();
						val.Add(bS.A(setting.@as(), num, false, 0));
						val2.Add(i);
					}
				}
				BWR.Add(val);
				BWr.Add(val2);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void E(object P_0, EventArgs P_1)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).InvokeRequired)
		{
			try
			{
				a a = E;
				((Control)this).BeginInvoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BM.A(BWN.aXc, true) && !BM.aE())
		{
			return;
		}
		Enumerator<Label> enumerator = BWq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				((Control)enumerator.Current).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ft();
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void e(object P_0, EventArgs P_1)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		if (!((MovableResizablePanel)this).B() || BM.QO == BM.b.BpG)
		{
			return;
		}
		if (((Control)this).InvokeRequired)
		{
			try
			{
				B b = e;
				((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		Setting setting = P_0 as Setting;
		SettingOrSpecialObject settingOrSpecialObject = ((((SettingOrSpecialObject)setting).F().E().BSQ != Cg.BAM) ? ((SettingOrSpecialObject)setting).D() : setting);
		int num = 0;
		Enumerator<Label> enumerator = BWq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Label current = enumerator.Current;
				if ((((Control)current).Tag as SettingOrSpecialObject[])[0] == settingOrSpecialObject)
				{
					bool flag = false;
					for (int i = 0; i < settingOrSpecialObject.F().b().Count; i++)
					{
						if (BM.C(settingOrSpecialObject.F().b()[i].A()))
						{
							flag = true;
							break;
						}
					}
					if ((!BM.A(BWN.aXc, true) || BM.aE()) && !flag)
					{
						((Control)current).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ft();
					}
					else
					{
						StringBuilder val = new StringBuilder();
						for (int j = 0; j < settingOrSpecialObject.F().b().Count; j++)
						{
							if (!BWr[num].Contains(j))
							{
								continue;
							}
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
							int num2 = BWr[num].IndexOf(j);
							if (!string.IsNullOrEmpty(val2.Item2))
							{
								if (BWR[num][num2] == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IX())
								{
									val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ix());
								}
								else
								{
									val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + BWR[num][num2]);
								}
							}
							if (num2 != BWr[num].Count - 1)
							{
								val.Append(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IY());
							}
						}
						string text2 = ((object)val).ToString();
						if (text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IY()))
						{
							text2 = text2.Substring(0, text2.Length - 3);
						}
						if (setting.ac().Count > 0 && ((SettingOrSpecialObject)setting).l())
						{
							Color foreColor = BM.te;
							Enumerator<Setting.B> enumerator2 = setting.ac().GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									Setting.B current2 = enumerator2.Current;
									if (setting.ax() == current2.BYk)
									{
										switch (current2.BYL)
										{
										case Setting.a.BYi:
											foreColor = BM.tC;
											break;
										case Setting.a.BYj:
											foreColor = Color.DarkOrange;
											break;
										case Setting.a.BYK:
											foreColor = Color.DarkGreen;
											break;
										case Setting.a.BYJ:
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
							((Control)current).ForeColor = foreColor;
						}
						else
						{
							((Control)current).ForeColor = BM.te;
						}
						((Control)current).Text = text2;
					}
				}
				num++;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private bool A(SettingOrSpecialObject P_0, bool P_1, ref int P_2, ref int P_3, bool P_4)
	{
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		bool result = P_1;
		bool flag = false;
		Enumerator<SettingOrSpecialObject> enumerator;
		if (!P_1)
		{
			SettingOrSpecialObject settingOrSpecialObject = null;
			if (P_0.A().aWx.Contains(P_0))
			{
				if (P_0.D() != null)
				{
					enumerator = P_0.D().a().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							SettingOrSpecialObject current = enumerator.Current;
							if (current is SpecialObject && current != P_0 && current.B() == P_0.B())
							{
								settingOrSpecialObject = current;
								break;
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
					enumerator = P_0.A().aWS.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							SettingOrSpecialObject current2 = enumerator.Current;
							if (current2 is SpecialObject && current2 != P_0 && current2.c() == P_0.c() && current2.B() == P_0.B())
							{
								settingOrSpecialObject = current2;
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
			if (settingOrSpecialObject != null)
			{
				enumerator = settingOrSpecialObject.a().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						SettingOrSpecialObject current3 = enumerator.Current;
						if (!(current3 is Setting) || (current3 as Setting).aJ() || !(current3.B() == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aTe()))
						{
							continue;
						}
						Do @do = current3 as Do;
						if (@do.am() || (BM.qC != null && !BM.qD.Contains(@do.A())))
						{
							continue;
						}
						string text = @do.A().ToString();
						Control val = null;
						if (!P_4 && ((Control)base.B()).Controls.ContainsKey(text))
						{
							val = ((Control)base.B()).Controls[text];
						}
						if (@do.al() || @do.aN())
						{
							if (val != null)
							{
								((Control)base.B()).Controls.Remove(val);
							}
						}
						else if (!@do.U() && @do.L().Count != 0)
						{
							result = true;
							if (val == null)
							{
								cu cu = new cu(@do.C(), BWN, BWn, null, false, true, false);
								((Control)cu).Name = text;
								((Control)cu).Left = P_2;
								((Control)cu).Top = P_3;
								P_3 = ((Control)cu).Bottom + 4;
								((Control)base.B()).Controls.Add((Control)(object)cu);
							}
							else
							{
								P_3 += val.Height + 4;
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
		}
		enumerator = P_0.a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SettingOrSpecialObject current4 = enumerator.Current;
				Do do2 = null;
				if (current4 is SpecialObject)
				{
					Enumerator<SettingOrSpecialObject> enumerator2 = current4.a().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							SettingOrSpecialObject current5 = enumerator2.Current;
							if (current5 is Do && (current5 as Do).c() != 0)
							{
								do2 = current5 as Do;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
				}
				if (!(current4 is Do) && do2 == null)
				{
					continue;
				}
				Do do3 = ((do2 == null) ? (current4 as Do) : do2);
				if (do3.am() || (BM.qC != null && !BM.qD.Contains(do3.A())))
				{
					continue;
				}
				string text2 = do3.A().ToString();
				Control val2 = null;
				if (!P_4 && ((Control)base.B()).Controls.ContainsKey(text2))
				{
					val2 = ((Control)base.B()).Controls[text2];
				}
				if (do3.al() || do3.aN())
				{
					if (val2 != null)
					{
						((Control)base.B()).Controls.Remove(val2);
					}
					continue;
				}
				result = true;
				if (P_1)
				{
					flag = true;
				}
				if (do3.U())
				{
					if (val2 == null)
					{
						ct ct = new ct(do3.C(), BWN, BWn, null, false);
						((Control)ct).Name = text2;
						((Control)ct).Left = P_2;
						((Control)ct).Top = P_3;
						if (P_1)
						{
							P_2 = ((Control)ct).Right + 10;
							P_2 = N.a(P_2, 15);
						}
						else
						{
							P_3 = ((Control)ct).Bottom;
						}
						((Control)base.B()).Controls.Add((Control)(object)ct);
					}
					else if (P_1)
					{
						P_2 += val2.Width + 10;
						P_2 = N.a(P_2, 15);
					}
					else
					{
						P_3 += val2.Height;
					}
				}
				else if (do3.L().Count != 0)
				{
					if (val2 == null)
					{
						cu cu2 = new cu(do3.C(), BWN, BWn, null, false, true, false);
						((Control)cu2).Name = text2;
						((Control)cu2).Left = P_2;
						((Control)cu2).Top = P_3;
						if (P_1)
						{
							P_2 = ((Control)cu2).Right + 10;
							P_2 = N.a(P_2, 15);
						}
						else
						{
							P_3 = ((Control)cu2).Bottom + 4;
						}
						((Control)base.B()).Controls.Add((Control)(object)cu2);
					}
					else if (P_1)
					{
						P_2 += val2.Width + 10;
						P_2 = N.a(P_2, 15);
					}
					else
					{
						P_3 += val2.Height + 4;
					}
				}
				else if (current4 is Setting && (current4 as Setting).v())
				{
					if (val2 == null)
					{
						cS cS = new cS(do3.C(), BWN, BWn);
						((Control)cS).Name = text2;
						((Control)cS).Left = P_2;
						((Control)cS).Top = P_3;
						if (P_1)
						{
							P_2 = ((Control)cS).Right + 10;
							P_2 = N.a(P_2, 15);
						}
						else
						{
							P_3 = ((Control)cS).Bottom + 4;
						}
						((Control)base.B()).Controls.Add((Control)(object)cS);
					}
					else if (P_1)
					{
						P_2 += val2.Width + 10;
						P_2 = N.a(P_2, 15);
					}
					else
					{
						P_3 += val2.Height + 4;
					}
				}
				else if (current4 is Setting && (current4 as Setting).Y())
				{
					if (val2 == null)
					{
						cU cU = new cU(do3.C(), BWN, BWn, null);
						((Control)cU).Name = text2;
						((Control)cU).Left = P_2;
						((Control)cU).Top = P_3;
						if (P_1)
						{
							P_2 = ((Control)cU).Right + 10;
							P_2 = N.a(P_2, 15);
						}
						else
						{
							P_3 = ((Control)cU).Bottom + 4;
						}
						((Control)base.B()).Controls.Add((Control)(object)cU);
					}
					else if (P_1)
					{
						P_2 += val2.Width + 10;
						P_2 = N.a(P_2, 15);
					}
					else
					{
						P_3 += val2.Height + 4;
					}
				}
				else if (val2 == null)
				{
					DE dE = new DE(do3.C(), BWN, BWn, null, false, false, false);
					((Control)dE).Name = text2;
					((Control)dE).Left = P_2;
					((Control)dE).Top = P_3;
					if (P_1)
					{
						P_2 = ((Control)dE).Right + 10;
						P_2 = N.a(P_2, 15);
					}
					else
					{
						P_3 = ((Control)dE).Bottom + 4;
					}
					((Control)base.B()).Controls.Add((Control)(object)dE);
				}
				else if (P_1)
				{
					P_2 += val2.Width + 10;
					P_2 = N.a(P_2, 15);
				}
				else
				{
					P_3 += val2.Height + 4;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (P_1)
		{
			P_2 = 5;
			if (flag)
			{
				P_3 += 25;
			}
		}
		else if (P_0.k().Count != 0)
		{
			result = true;
			Enumerator<int> enumerator3 = P_0.k().GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					int current6 = enumerator3.Current;
					SettingOrSpecialObject settingOrSpecialObject2 = P_0.A().a(current6);
					A(settingOrSpecialObject2, true, ref P_2, ref P_3, P_4);
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
		}
		return result;
	}

	private void E()
	{
		while (((ArrangedElementCollection)((Control)BWQ).Controls).Count != 0)
		{
			Control obj = ((Control)BWQ).Controls[0];
			Panel val = (Panel)(object)((obj is Panel) ? obj : null);
			A(val);
		}
	}

	private void A(Panel P_0)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		while (((ArrangedElementCollection)((Control)P_0).Controls).Count != 0)
		{
			Control val = ((Control)P_0).Controls[0];
			if (val is Button)
			{
				((val is Button) ? val : null).Click -= new EventHandler(H);
				((val is Button) ? val : null).Click -= new EventHandler(I);
				((val is Button) ? val : null).Click -= new EventHandler(h);
			}
			((Component)val).Dispose();
		}
		((Component)P_0).Dispose();
	}

	private void A(SettingOrSpecialObject P_0, bool P_1)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_0bbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b51: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected O, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected O, but got Unknown
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected O, but got Unknown
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected O, but got Unknown
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected O, but got Unknown
		//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Expected O, but got Unknown
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad6: Expected O, but got Unknown
		Enumerator<PortFunction.a> enumerator = P_0.F().c().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				PortFunction.a current = enumerator.Current;
				Panel val = null;
				if (!P_1)
				{
					foreach (Panel item in (ArrangedElementCollection)((Control)BWQ).Controls)
					{
						Panel val2 = item;
						if (((Control)val2).Tag == current)
						{
							val = val2;
							break;
						}
					}
				}
				if (P_0.F().D().Contains(current))
				{
					Cg bSl = current.BSl;
					CH bSM = current.BSM;
					byte bSm = current.BSm;
					ushort bSN = current.BSN;
					SettingOrSpecialObject settingOrSpecialObject = PortFunction.A(P_0.A(), bSl, bSM, bSm, bSN);
					Label val3 = new Label();
					List<Label> val4 = new List<Label>();
					val4.Add(val3);
					((Control)val3).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGw();
					if (bSl == Cg.BAM)
					{
						((Control)val3).Text = current.BSn;
					}
					else
					{
						switch (bSM)
						{
						case CH.Baa:
							((Control)val3).Text = PortFunction.A(P_0.A(), bSm + 1, current.BSn);
							break;
						case CH.BaB:
							((Control)val3).Text = PortFunction.a(P_0.A(), bSm + 1, current.BSn);
							break;
						default:
							((Control)val3).Text = current.BSn;
							break;
						}
					}
					((Control)val3).ForeColor = BM.te;
					((Control)val3).AutoSize = true;
					((Control)val3).Left = 5;
					if (settingOrSpecialObject != null && settingOrSpecialObject.F().b().Count != 0)
					{
						((Control)val3).Top = -10;
					}
					else
					{
						((Control)val3).Top = 0;
					}
					Label val5 = null;
					if (settingOrSpecialObject != null && settingOrSpecialObject.F().b().Count != 0 && BM.QO != BM.b.BpG)
					{
						val5 = new Label();
						((Control)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ft();
						((Control)val5).ForeColor = BM.te;
						((Control)val5).Tag = new SettingOrSpecialObject[2] { settingOrSpecialObject, null };
						((Control)val5).AutoSize = false;
						((Control)val5).Left = 5;
						((Control)val5).Width = 390;
						((Control)val5).Height = (int)((float)((Control)val5).Height * 0.7f);
						((Control)val5).Top = 9;
						if (P_1)
						{
							BWq.Add(val5);
						}
					}
					List<PictureBox> val6 = new List<PictureBox>();
					List<Label> val7 = new List<Label>();
					Label val8 = new Label();
					((Control)val8).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBZ();
					((Control)val8).ForeColor = BM.te;
					((Control)val8).AutoSize = true;
					string text = string.Empty;
					List<WiringPin> val9 = WiringPin.A(P_0.A(), bSl, bSM, bSm, bSN);
					if (bSM == CH.Bal || val9.Count == 0)
					{
						PictureBox val10 = new PictureBox();
						((Control)val10).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGZ();
						((Control)val10).BackColor = Color.Transparent;
						if (bSM == CH.Bal)
						{
							val10.Image = (Image)(object)WiringPin.A(Color.Transparent, Color.Transparent, false, true, false);
						}
						else
						{
							val10.Image = PortFunction.A(bSl, bSM);
						}
						if (val10.Image != null)
						{
							((Control)val10).Height = val10.Image.Height;
							((Control)val10).Width = val10.Image.Width;
						}
						else
						{
							((Control)val10).Height = 23;
							((Control)val10).Width = 100;
						}
						((Control)val10).Left = 490;
						val6.Add(val10);
						Label val11 = new Label();
						((Control)val11).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGz();
						if (bSM == CH.Bal)
						{
							((Control)val11).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IZ();
						}
						((Control)val11).ForeColor = BM.te;
						((Control)val11).AutoSize = true;
						((Control)val11).Left = ((Control)val10).Right + 10;
						((Control)val11).Top = 0;
						val7.Add(val11);
						if (((Control)val10).Height > 45)
						{
							((Control)val10).Top = 2;
						}
						else
						{
							((Control)val10).Top = ((Control)val11).Top - 3;
						}
					}
					else
					{
						bool flag = val9.Count > 1;
						for (int i = 0; i < val9.Count; i++)
						{
							WiringPin wiringPin = val9[i];
							PictureBox val12 = new PictureBox();
							((Control)val12).Tag = wiringPin;
							((Control)val12).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgA() + i;
							((Control)val12).BackColor = Color.Transparent;
							val12.Image = wiringPin.d();
							if (val12.Image != null)
							{
								((Control)val12).Height = val12.Image.Height;
								((Control)val12).Width = val12.Image.Width;
							}
							else
							{
								((Control)val12).Height = 23;
								((Control)val12).Width = 100;
							}
							((Control)val12).Left = 490;
							val6.Add(val12);
							Label val13 = new Label();
							((Control)val13).Tag = wiringPin;
							((Control)val13).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bga() + i;
							((Control)val13).Text = wiringPin.A(flag);
							((Control)val13).ForeColor = BM.te;
							((Control)val13).AutoSize = true;
							((Control)val13).Left = ((Control)val12).Right + 3;
							((Control)val13).Top = val7.Count * ((Control)val13).Height;
							val7.Add(val13);
							if (((Control)val12).Height > 45)
							{
								((Control)val12).Top = 2;
							}
							else
							{
								((Control)val12).Top = ((Control)val13).Top - 3;
							}
							if (!string.IsNullOrEmpty(wiringPin.E()))
							{
								text = text + wiringPin.E() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iA();
							}
						}
					}
					if (bSM != CH.Bal)
					{
						string text2 = PortFunction.B(settingOrSpecialObject);
						if (text2 != null)
						{
							((Control)val8).Text = text2;
							if (val6.Count != 0)
							{
								Graphics val14 = ((Control)this).CreateGraphics();
								try
								{
									Size val15 = TextRenderer.MeasureText((IDeviceContext)(object)val14, ((Control)val8).Text, ((Control)val8).Font);
									((Control)val8).Left = ((Control)val6[0]).Left + ((Control)val6[0]).Width / 2 - ((Size)(ref val15)).Width / 2;
									if (((Control)val8).Left < ((Control)val6[0]).Left - 15)
									{
										((Control)val8).Left = ((Control)val6[0]).Left - 15;
									}
								}
								finally
								{
									((System.IDisposable)val14)?.Dispose();
								}
							}
							else
							{
								((Control)val8).Left = 490;
							}
							((Control)val8).Top = 0;
						}
					}
					Label val16 = null;
					if (!string.IsNullOrEmpty(text))
					{
						val16 = new Label();
						((Control)val16).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgB();
						((Control)val16).Text = text;
						((Control)val16).ForeColor = Color.DarkOrange;
						((Control)val16).Left = 5;
						((Control)val16).Top = 5;
						((Control)val16).AutoSize = true;
					}
					StateMachine stateMachine;
					List<ApplyAndExecuteProcess> val17;
					List<int> val18 = A(false, settingOrSpecialObject, null, current, out stateMachine, out val17);
					int num = 0;
					if (val18.Count > 4)
					{
						num = 84;
					}
					else if (val18.Count != 0)
					{
						num = 42;
					}
					List<cg> val19 = new List<cg>();
					Enumerator<ApplyAndExecuteProcess> enumerator3 = val17.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							cg cg = new cg(enumerator3.Current.OwnerObject, BWN, BWn, Rectangle.Empty, false);
							cg.A(false, true, null, 0);
							val19.Add(cg);
							if (num == 0)
							{
								num = 42;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator3).Dispose();
					}
					int num2 = BB.A(val6, val7, null, val4, val5, val16, 48, val6.Count != 0 && !string.IsNullOrEmpty(((Control)val8).Text)) + num;
					Panel val20 = new Panel();
					((Control)val20).Tag = current;
					val20.BorderStyle = (BorderStyle)1;
					((Control)val20).BackColor = ((Control)BWQ).BackColor;
					Point autoScrollPosition = ((ScrollableControl)BWQ).AutoScrollPosition;
					int num3 = ((Point)(ref autoScrollPosition)).X - 1;
					autoScrollPosition = ((ScrollableControl)BWQ).AutoScrollPosition;
					((Control)val20).Location = new Point(num3, ((Point)(ref autoScrollPosition)).Y + BWm - 1);
					((Control)val20).Height = num2 + 1;
					if (val == null)
					{
						foreach (Panel item2 in (ArrangedElementCollection)((Control)BWQ).Controls)
						{
							Panel val21 = item2;
							if (((Control)val21).Top >= ((Control)val20).Top)
							{
								((Control)val21).Top = ((Control)val21).Top + num2;
							}
						}
						((Control)BWQ).Controls.Add((Control)(object)val20);
					}
					else
					{
						if (((Control)val).Height != ((Control)val20).Height)
						{
							((Control)val).Height = ((Control)val20).Height;
						}
						if (((Control)val).Top != ((Control)val20).Top)
						{
							((Control)val).Top = ((Control)val20).Top;
						}
					}
					BWm += num2;
					BB.A(val6, val7, null, val4, null, val5, null, val8, val16, num2 - num, 48, val6.Count != 0 && !string.IsNullOrEmpty(((Control)val8).Text));
					A(val20, val, val6, val7, val3, val8, val5, val16);
					A(val20, val, num, val18, null, val19, val7, false, settingOrSpecialObject, null, null);
					if (val != null)
					{
						A(val, val18, null, val17, 0, false);
					}
					int num4 = ((BWV != Rectangle.Empty) ? (((Control)BWQ).Width - 11) : 0);
					if (val != null)
					{
						foreach (Control item3 in (ArrangedElementCollection)((Control)val).Controls)
						{
							Control val22 = item3;
							num4 = Math.Max(num4, val22.Right);
						}
						((Control)val).Width = Math.Max(((Control)val).Width, num4 + 10);
					}
					else
					{
						foreach (Control item4 in (ArrangedElementCollection)((Control)val20).Controls)
						{
							Control val23 = item4;
							num4 = Math.Max(num4, val23.Right);
						}
						((Control)val20).Width = Math.Max(((Control)val20).Width, num4 + 10);
					}
					int num5 = ((BWV != Rectangle.Empty) ? (((Control)BWQ).Width - 1) : 0);
					foreach (Control item5 in (ArrangedElementCollection)((Control)BWQ).Controls)
					{
						Control val24 = item5;
						num5 = Math.Max(num5, val24.Width);
					}
					foreach (Control item6 in (ArrangedElementCollection)((Control)BWQ).Controls)
					{
						item6.Width = num5;
					}
					if (!(BWV == Rectangle.Empty))
					{
						continue;
					}
					((Control)BWQ).Width = num5 + 1;
					int num6 = 0;
					foreach (Control item7 in (ArrangedElementCollection)((Control)BWQ).Controls)
					{
						Control val25 = item7;
						num6 = Math.Max(num6, val25.Bottom);
					}
					((Control)BWQ).Height = num6 + 2;
				}
				else
				{
					if (val == null)
					{
						continue;
					}
					int num7 = ((Control)val).Height - 1;
					int top = ((Control)val).Top;
					A(val);
					foreach (Panel item8 in (ArrangedElementCollection)((Control)BWQ).Controls)
					{
						Panel val26 = item8;
						if (((Control)val26).Top > top + 1)
						{
							((Control)val26).Top = ((Control)val26).Top - num7;
						}
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (P_0.k().Count == 0)
		{
			return;
		}
		Enumerator<int> enumerator4 = P_0.k().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				int current2 = enumerator4.Current;
				SettingOrSpecialObject settingOrSpecialObject2 = P_0.A().a(current2);
				A(settingOrSpecialObject2, P_1);
			}
		}
		finally
		{
			((System.IDisposable)enumerator4).Dispose();
		}
	}

	private void A(Panel P_0, Panel P_1, List<PictureBox> P_2, List<Label> P_3, Label P_4, Label P_5, Label P_6, Label P_7)
	{
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		if (P_1 != null)
		{
			List<int> val = new List<int>();
			bool flag = false;
			for (int i = 0; i < ((ArrangedElementCollection)((Control)P_1).Controls).Count; i++)
			{
				Control val2 = ((Control)P_1).Controls[i];
				if (val2 is Label && BWq.Contains((Label)(object)((val2 is Label) ? val2 : null)))
				{
					flag = true;
					if (P_6 != null)
					{
						if ((val2.Tag as SettingOrSpecialObject[])[0] != (((Control)P_6).Tag as SettingOrSpecialObject[])[0])
						{
							(val2.Tag as SettingOrSpecialObject[])[0] = (((Control)P_6).Tag as SettingOrSpecialObject[])[0];
						}
						if ((val2.Tag as SettingOrSpecialObject[])[1] != (((Control)P_6).Tag as SettingOrSpecialObject[])[1])
						{
							(val2.Tag as SettingOrSpecialObject[])[1] = (((Control)P_6).Tag as SettingOrSpecialObject[])[1];
						}
						if (val2.Left != ((Control)P_6).Left)
						{
							val2.Left = ((Control)P_6).Left;
						}
						if (val2.Top != ((Control)P_6).Top)
						{
							val2.Top = ((Control)P_6).Top;
						}
						((Component)P_6).Dispose();
					}
					else
					{
						SettingOrSpecialObject settingOrSpecialObject = (((val2 is Label) ? val2 : null).Tag as SettingOrSpecialObject[])[0];
						for (int j = 0; j < settingOrSpecialObject.F().b().Count; j++)
						{
							settingOrSpecialObject.F().b()[j].a(new EventHandler(e));
						}
						BWq.Remove((Label)(object)((val2 is Label) ? val2 : null));
						((Component)val2).Dispose();
						i--;
					}
				}
				else if (val2.Name != null && val2.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGw())
				{
					if (val2.Left != ((Control)P_4).Left)
					{
						val2.Left = ((Control)P_4).Left;
					}
					if (val2.Top != ((Control)P_4).Top)
					{
						val2.Top = ((Control)P_4).Top;
					}
					if (val2.Text != ((Control)P_4).Text)
					{
						val2.Text = ((Control)P_4).Text;
					}
					((Component)P_4).Dispose();
				}
				else if (val2.Name != null && val2.Name.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgA()))
				{
					val.Add(int.Parse(val2.Name.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgA().Length)));
					PictureBox val3 = null;
					for (int k = 0; k < P_2.Count; k++)
					{
						PictureBox val4 = P_2[k];
						if (val2.Name == ((Control)val4).Name)
						{
							val3 = val4;
							break;
						}
					}
					if (val3 != null)
					{
						if (val2.Left != ((Control)val3).Left)
						{
							val2.Left = ((Control)val3).Left;
						}
						if (val2.Top != ((Control)val3).Top)
						{
							val2.Top = ((Control)val3).Top;
						}
						if (val2.Width != ((Control)val3).Width)
						{
							val2.Width = ((Control)val3).Width;
						}
						if (val2.Height != ((Control)val3).Height)
						{
							val2.Height = ((Control)val3).Height;
						}
						if (((PictureBox)((val2 is PictureBox) ? val2 : null)).Image != val3.Image)
						{
							((PictureBox)((val2 is PictureBox) ? val2 : null)).Image = val3.Image;
						}
						if (((Control)val3).Tag != null)
						{
							val2.Tag = ((Control)val3).Tag;
						}
					}
					else
					{
						((Component)val2).Dispose();
						i--;
					}
				}
				else if (val2.Name != null && val2.Name.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bga()))
				{
					Label val5 = null;
					for (int l = 0; l < P_3.Count; l++)
					{
						Label val6 = P_3[l];
						if (val2.Name == ((Control)val6).Name)
						{
							val5 = val6;
							break;
						}
					}
					if (val5 != null)
					{
						if (val2.Left != ((Control)val5).Left)
						{
							val2.Left = ((Control)val5).Left;
						}
						if (val2.Top != ((Control)val5).Top)
						{
							val2.Top = ((Control)val5).Top;
						}
						if (val2.Text != ((Control)val5).Text)
						{
							val2.Text = ((Control)val5).Text;
						}
						if (val2.ForeColor != ((Control)val5).ForeColor)
						{
							val2.ForeColor = ((Control)val5).ForeColor;
						}
						if (((Control)val5).Tag != null)
						{
							val2.Tag = ((Control)val5).Tag;
						}
					}
					else
					{
						((Component)val2).Dispose();
						i--;
					}
				}
				else if (val2.Name != null && val2.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBZ())
				{
					if (val2.Left != ((Control)P_5).Left)
					{
						val2.Left = ((Control)P_5).Left;
					}
					if (val2.Top != ((Control)P_5).Top)
					{
						val2.Top = ((Control)P_5).Top;
					}
					if (val2.Text != ((Control)P_5).Text)
					{
						val2.Text = ((Control)P_5).Text;
					}
					((Component)P_5).Dispose();
				}
				else
				{
					if (val2.Name == null || !(val2.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgB()))
					{
						continue;
					}
					if (P_7 != null)
					{
						if (val2.Left != ((Control)P_7).Left)
						{
							val2.Left = ((Control)P_7).Left;
						}
						if (val2.Top != ((Control)P_7).Top)
						{
							val2.Top = ((Control)P_7).Top;
						}
						if (val2.Text != ((Control)P_7).Text)
						{
							val2.Text = ((Control)P_7).Text;
						}
						if (val2.ForeColor != ((Control)P_7).ForeColor)
						{
							val2.ForeColor = ((Control)P_7).ForeColor;
						}
						((Component)P_7).Dispose();
					}
					else
					{
						((Component)val2).Dispose();
						i--;
					}
				}
			}
			if (P_6 != null && !flag)
			{
				((Control)P_1).Controls.Add((Control)(object)P_6);
				BWq.Add(P_6);
			}
			for (int m = 0; m < P_2.Count; m++)
			{
				if (!val.Contains(m))
				{
					PictureBox val7 = P_2[m];
					((Control)P_1).Controls.Add((Control)(object)val7);
					Label val8 = P_3[m];
					((Control)P_1).Controls.Add((Control)(object)val8);
				}
			}
			return;
		}
		((Control)P_0).Controls.Add((Control)(object)P_4);
		if (P_6 != null)
		{
			((Control)P_0).Controls.Add((Control)(object)P_6);
		}
		Enumerator<PictureBox> enumerator = P_2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				PictureBox current = enumerator.Current;
				((Control)P_0).Controls.Add((Control)(object)current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		Enumerator<Label> enumerator2 = P_3.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				Label current2 = enumerator2.Current;
				((Control)P_0).Controls.Add((Control)(object)current2);
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
		((Control)P_0).Controls.Add((Control)(object)P_5);
		if (P_7 != null)
		{
			((Control)P_0).Controls.Add((Control)(object)P_7);
		}
	}

	private void a(SettingOrSpecialObject P_0, bool P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_1545: Unknown result type (might be due to invalid IL or missing references)
		//IL_154a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_14d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d9: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected O, but got Unknown
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected O, but got Unknown
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected O, but got Unknown
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e6: Expected O, but got Unknown
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e87: Expected O, but got Unknown
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c19: Expected O, but got Unknown
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094e: Expected O, but got Unknown
		//IL_0971: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Expected O, but got Unknown
		//IL_0f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Expected O, but got Unknown
		//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe3: Expected O, but got Unknown
		//IL_1005: Unknown result type (might be due to invalid IL or missing references)
		//IL_1017: Unknown result type (might be due to invalid IL or missing references)
		//IL_101c: Unknown result type (might be due to invalid IL or missing references)
		//IL_102d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1032: Unknown result type (might be due to invalid IL or missing references)
		//IL_1044: Unknown result type (might be due to invalid IL or missing references)
		//IL_1078: Unknown result type (might be due to invalid IL or missing references)
		//IL_107f: Expected O, but got Unknown
		//IL_12b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f9: Expected O, but got Unknown
		//IL_1342: Unknown result type (might be due to invalid IL or missing references)
		//IL_1347: Unknown result type (might be due to invalid IL or missing references)
		//IL_1382: Unknown result type (might be due to invalid IL or missing references)
		//IL_1389: Expected O, but got Unknown
		//IL_13d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1401: Unknown result type (might be due to invalid IL or missing references)
		//IL_1406: Unknown result type (might be due to invalid IL or missing references)
		//IL_143f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1446: Expected O, but got Unknown
		Enumerator<SettingOrSpecialObject> enumerator = P_0.a().GetEnumerator();
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
				dn.a(new EventHandler(this.b));
				((Setting)dn).A(new EventHandler(this.b));
				((SettingOrSpecialObject)dn).a(new EventHandler(C));
				((SettingOrSpecialObject)dn).A(new EventHandler(C));
				if (!BWS.Contains(dn))
				{
					BWS.Add(dn);
				}
				int num = dn.ax();
				bool flag = ((SettingOrSpecialObject)dn).l() || num != 0;
				bool flag2 = dn.am() && !((SettingOrSpecialObject)dn).l();
				Panel val = null;
				if (!P_1)
				{
					foreach (Panel item in (ArrangedElementCollection)((Control)BWQ).Controls)
					{
						Panel val2 = item;
						if (((Control)val2).Tag is int && (int)((Control)val2).Tag == ((Setting)dn).A())
						{
							val = val2;
							break;
						}
					}
				}
				if (flag && !flag2 && !dn.al())
				{
					bool flag3 = !((SettingOrSpecialObject)dn).l();
					if (!flag3)
					{
						int bbC = ((SettingOrSpecialObject)dn).F().BbC;
						if (bbC != 0)
						{
							Setting setting = P_0.A().A(bbC);
							if (setting != null)
							{
								flag = setting.ax() == 1;
							}
						}
					}
					if (flag)
					{
						bool flag4 = P_0.A().B() && P_0.A().b() && dn.J();
						PictureBox val3 = new PictureBox();
						List<PictureBox> val4 = new List<PictureBox>();
						Label val5 = null;
						string text = ((SettingOrSpecialObject)dn).A(bz.aYv);
						if (string.IsNullOrEmpty(text))
						{
							text = ((SettingOrSpecialObject)dn).A(bz.aYu);
						}
						string text2 = (string.IsNullOrEmpty(text) ? ((SettingOrSpecialObject)dn).A(bz.aYt) : text);
						Cg cg = PortFunction.A((uint)num);
						CH cH = PortFunction.a((uint)num);
						byte b = PortFunction.B((uint)num);
						ushort num2 = PortFunction.b((uint)num);
						bool flag5 = false;
						bool flag6 = false;
						if (cH == CH.BaF)
						{
							if (text2.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgb(), (StringComparison)5) >= 0)
							{
								flag5 = true;
							}
							else if (text2.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgC(), (StringComparison)5) >= 0)
							{
								flag5 = true;
								flag6 = true;
							}
						}
						SettingOrSpecialObject settingOrSpecialObject = PortFunction.A(P_0.A(), cg, cH, b, num2);
						Label val6 = new Label();
						List<Label> val7 = new List<Label>();
						cQ cQ = null;
						Size val8;
						if (flag5)
						{
							cQ = new cQ(BM.Qz, Rectangle.Empty, false, P_0, flag6);
							((Control)cQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgc();
							((Control)cQ).Left = 5;
							((Control)cQ).Top = 20;
						}
						else
						{
							val7.Add(val6);
							((Control)val6).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGw();
							if (flag4)
							{
								((Control)val6).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO();
							}
							else
							{
								string text3 = ((SettingOrSpecialObject)dn).H();
								if (!string.IsNullOrWhiteSpace(text3))
								{
									text2 = text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
								}
								((Control)val6).Text = text2;
							}
							((Control)val6).ForeColor = BM.te;
							((Control)val6).AutoSize = true;
							((Control)val6).Left = 5;
							if (settingOrSpecialObject != null && settingOrSpecialObject.F().b().Count != 0)
							{
								((Control)val6).Top = -10;
							}
							else
							{
								((Control)val6).Top = 0;
							}
							((Control)val6).Enabled = !flag3;
							val3.Image = (Image)(object)GeneralResources.QuestionMark;
							val4.Add(val3);
							((Control)val3).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGX();
							((Control)val3).Tag = dn;
							((Control)val3).Width = 18;
							((Control)val3).Height = 18;
							int left = ((Control)val6).Left;
							val8 = TextRenderer.MeasureText(((Control)val6).Text, ((Control)val6).Font);
							((Control)val3).Left = left + ((Size)(ref val8)).Width;
							((Control)val3).Top = ((Control)val6).Top;
							val3.SizeMode = (PictureBoxSizeMode)1;
							((Control)val3).Click += new EventHandler(F);
							((Control)val3).Visible = false;
							((Control)val6).MouseEnter += new EventHandler(f);
							((Control)val3).MouseEnter += new EventHandler(f);
							((Control)val6).MouseLeave += new EventHandler(G);
							if (settingOrSpecialObject != null && settingOrSpecialObject.F().b().Count != 0 && BM.QO != BM.b.BpG)
							{
								val5 = new Label();
								((Control)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ft();
								((Control)val5).ForeColor = BM.te;
								((Control)val5).Tag = new SettingOrSpecialObject[2] { settingOrSpecialObject, dn };
								((Control)val5).AutoSize = false;
								((Control)val5).Left = 5;
								((Control)val5).Width = 390;
								((Control)val5).Height = (int)((float)((Control)val5).Height * 0.7f);
								((Control)val5).Top = 9;
								if (P_1)
								{
									BWq.Add(val5);
								}
							}
						}
						ThemedButton themedButton = new ThemedButton();
						((Control)themedButton).Tag = ((Setting)dn).A();
						((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgD();
						((Control)themedButton).Enabled = BWN.C() && BM.QO != BM.b.BpG && !flag3;
						((Control)themedButton).Width = 80;
						((Control)themedButton).Height = 23;
						((Control)themedButton).Left = 400;
						if (flag5)
						{
							((Control)themedButton).Visible = false;
						}
						ThemedButton themedButton2 = new ThemedButton();
						((Control)themedButton2).Tag = ((Setting)dn).A();
						((Control)themedButton2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgd();
						((Control)themedButton2).Width = 80;
						((Control)themedButton2).Height = ((Control)themedButton).Height;
						int num3;
						if (PortFunction.A(dn) && !flag5)
						{
							((Control)themedButton2).Enabled = ((Control)themedButton).Enabled;
							if (A((Setting)dn))
							{
								((Control)themedButton2).ForeColor = BM.tC;
							}
							((Control)themedButton2).Left = ((Control)themedButton).Left;
							((Control)themedButton2).Visible = true;
							num3 = 48 + ((Control)themedButton2).Height;
						}
						else
						{
							((Control)themedButton2).Visible = false;
							num3 = 48;
						}
						ThemedButton themedButton3 = new ThemedButton();
						((Control)themedButton3).Tag = ((Setting)dn).A();
						((Control)themedButton3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcj();
						((Control)themedButton3).Enabled = BWN.C() && BM.QO != BM.b.BpG;
						if (flag3)
						{
							((Control)themedButton3).ForeColor = BM.tC;
						}
						((Control)themedButton3).Width = 80;
						((Control)themedButton3).Height = ((Control)themedButton).Height;
						((Control)themedButton3).Left = ((Control)themedButton).Left;
						if (flag5)
						{
							((Control)themedButton3).Visible = false;
						}
						List<PictureBox> val9 = new List<PictureBox>();
						List<Label> val10 = new List<Label>();
						Label val11 = new Label();
						((Control)val11).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBZ();
						((Control)val11).ForeColor = BM.te;
						((Control)val11).AutoSize = true;
						Label val12 = null;
						string text4 = string.Empty;
						if (!flag5)
						{
							if (num == 0)
							{
								PictureBox val13 = new PictureBox();
								((Control)val13).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGZ();
								((Control)val13).BackColor = Color.Transparent;
								val13.Image = (Image)(object)WiringPin.A(Color.Transparent, Color.Transparent, false, false, true);
								((Control)val13).Height = val13.Image.Height;
								((Control)val13).Width = val13.Image.Width;
								((Control)val13).Left = ((Control)themedButton).Right + 10;
								val9.Add(val13);
								Label val14 = new Label();
								((Control)val14).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGz();
								((Control)val14).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgE();
								((Control)val14).ForeColor = BM.tC;
								((Control)val14).AutoSize = true;
								((Control)val14).Left = ((Control)val13).Right + 10;
								((Control)val14).Top = 0;
								val10.Add(val14);
								if (((Control)val13).Height > num3 - 3)
								{
									((Control)val13).Top = 2;
								}
								else
								{
									((Control)val13).Top = ((Control)val14).Top - 3;
								}
							}
							else
							{
								List<WiringPin> val15 = WiringPin.A(P_0.A(), cg, cH, b, num2);
								if (cH == CH.Bal || val15.Count == 0)
								{
									PictureBox val16 = new PictureBox();
									((Control)val16).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGZ();
									((Control)val16).BackColor = Color.Transparent;
									if (cH == CH.Bal)
									{
										val16.Image = (Image)(object)WiringPin.A(Color.Transparent, Color.Transparent, false, true, false);
									}
									else
									{
										val16.Image = PortFunction.A(cg, cH);
									}
									if (val16.Image != null)
									{
										((Control)val16).Height = val16.Image.Height;
										((Control)val16).Width = val16.Image.Width;
									}
									else
									{
										((Control)val16).Height = 23;
										((Control)val16).Width = 100;
									}
									((Control)val16).Left = ((Control)themedButton).Right + 10;
									val9.Add(val16);
									Label val17 = new Label();
									((Control)val17).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGz();
									if (cH == CH.Bal)
									{
										((Control)val17).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IZ();
									}
									((Control)val17).ForeColor = BM.te;
									((Control)val17).AutoSize = true;
									((Control)val17).Left = ((Control)val16).Right + 10;
									((Control)val17).Top = 0;
									((Control)val17).Enabled = !flag3;
									val10.Add(val17);
									if (((Control)val16).Height > num3 - 3)
									{
										((Control)val16).Top = 2;
									}
									else
									{
										((Control)val16).Top = ((Control)val17).Top - 3;
									}
								}
								else
								{
									bool flag7 = val15.Count > 1;
									for (int i = 0; i < val15.Count; i++)
									{
										WiringPin wiringPin = val15[i];
										PictureBox val18 = new PictureBox();
										((Control)val18).Tag = wiringPin;
										((Control)val18).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgA() + i;
										((Control)val18).BackColor = Color.Transparent;
										val18.Image = wiringPin.d();
										if (val18.Image != null)
										{
											((Control)val18).Height = val18.Image.Height;
											((Control)val18).Width = val18.Image.Width;
										}
										else
										{
											((Control)val18).Height = 23;
											((Control)val18).Width = 100;
										}
										((Control)val18).Left = ((Control)themedButton).Right + 10;
										val9.Add(val18);
										Label val19 = new Label();
										((Control)val19).Tag = wiringPin;
										((Control)val19).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bga() + i;
										((Control)val19).Text = wiringPin.A(flag7);
										((Control)val19).ForeColor = BM.te;
										((Control)val19).AutoSize = true;
										((Control)val19).Left = ((Control)val18).Right + 3;
										((Control)val19).Top = val10.Count * ((Control)val19).Height;
										((Control)val19).Enabled = !flag3;
										val10.Add(val19);
										if (((Control)val18).Height > num3 - 3)
										{
											((Control)val18).Top = 2;
										}
										else
										{
											((Control)val18).Top = ((Control)val19).Top - 3;
										}
										if (!string.IsNullOrEmpty(wiringPin.E()))
										{
											text4 = text4 + wiringPin.E() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iA();
										}
									}
								}
								if (cH != CH.Bal)
								{
									string text5 = PortFunction.B(settingOrSpecialObject);
									if (text5 != null)
									{
										((Control)val11).Text = text5;
										if (val9.Count != 0)
										{
											Graphics val20 = ((Control)this).CreateGraphics();
											try
											{
												Size val21 = TextRenderer.MeasureText((IDeviceContext)(object)val20, ((Control)val11).Text, ((Control)val11).Font);
												((Control)val11).Left = ((Control)val9[0]).Left + ((Control)val9[0]).Width / 2 - ((Size)(ref val21)).Width / 2;
												if (((Control)val11).Left < ((Control)val9[0]).Left - 15)
												{
													((Control)val11).Left = ((Control)val9[0]).Left - 15;
												}
											}
											finally
											{
												((System.IDisposable)val20)?.Dispose();
											}
										}
										else if (val10.Count != 0 && ((Control)val10[0]).Text != string.Empty)
										{
											((Control)val11).Left = ((Control)val10[0]).Right + 10;
										}
										else if (val10.Count != 0)
										{
											((Control)val11).Left = ((Control)val9[0]).Right + 10;
										}
										else
										{
											((Control)val11).Left = ((Control)themedButton).Right + 10;
										}
										((Control)val11).Top = 0;
										((Control)val11).Enabled = !flag3;
									}
								}
							}
							if (!string.IsNullOrEmpty(text4))
							{
								val12 = new Label();
								((Control)val12).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgB();
								((Control)val12).Text = text4;
								((Control)val12).ForeColor = Color.DarkOrange;
								((Control)val12).Left = 5;
								((Control)val12).Top = 5;
								((Control)val12).AutoSize = true;
							}
						}
						string text6 = null;
						if (BWn != null)
						{
							Dn dn2;
							bool flag8;
							if (((SettingOrSpecialObject)dn).A() == BWn)
							{
								dn2 = BWN.A(((Setting)dn).A()) as Dn;
								flag8 = (!BWn.B() || !BWn.b() || !dn.J()) && (!BWN.B() || !BWN.b() || dn2 == null || !dn2.J());
							}
							else
							{
								dn2 = BWn.A(((Setting)dn).A()) as Dn;
								flag8 = (!BWn.B() || !BWn.b() || dn2 == null || !dn2.J()) && (!BWN.B() || !BWN.b() || !dn.J());
							}
							if (flag8 && dn2 != null)
							{
								int num4 = dn2.ax();
								if (num4 != num)
								{
									if (num4 == 0)
									{
										text6 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bge();
									}
									else
									{
										Cg cg2 = PortFunction.A((uint)num4);
										CH cH2 = PortFunction.a((uint)num4);
										byte b2 = PortFunction.B((uint)num4);
										ushort num5 = PortFunction.b((uint)num4);
										if (cH2 == CH.Bal)
										{
											text6 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgF();
										}
										else
										{
											string text7 = PortFunction.B(PortFunction.A(((SettingOrSpecialObject)dn2).A(), cg2, cH2, b2, num5));
											if (text7 != null)
											{
												text6 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgf() + text7 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgG();
											}
										}
									}
								}
							}
						}
						StateMachine stateMachine;
						List<ApplyAndExecuteProcess> val22;
						List<int> val23 = A(flag3, settingOrSpecialObject, dn, null, out stateMachine, out val22);
						string text8 = null;
						if (num != 0 && dn.o().Count != 0)
						{
							text8 = string.Empty;
							Enumerator<string> enumerator3 = dn.o().GetEnumerator();
							try
							{
								while (enumerator3.MoveNext())
								{
									string current2 = enumerator3.Current;
									if (text8 != string.Empty)
									{
										text8 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv();
									}
									text8 += current2;
								}
							}
							finally
							{
								((System.IDisposable)enumerator3).Dispose();
							}
						}
						else if (A((Setting)dn))
						{
							text8 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgg();
						}
						int num6 = 0;
						if (text8 != null)
						{
							Font val24 = new Font(((Control)this).Font.FontFamily, 8.25f);
							try
							{
								val8 = TextRenderer.MeasureText(text8, val24, new Size(230, -1), (TextFormatFlags)16);
								num6 = ((Size)(ref val8)).Height;
							}
							finally
							{
								((System.IDisposable)val24)?.Dispose();
							}
						}
						int num7 = 0;
						if (val23.Count > 4)
						{
							num7 = Math.Max(84, num6);
						}
						else if (val23.Count != 0)
						{
							num7 = Math.Max(42, num6);
						}
						else if (text6 != null || text8 != null)
						{
							num7 = Math.Max(42, num6);
						}
						De de = null;
						if (stateMachine != null)
						{
							de = new De(stateMachine, BWN, BWn, Rectangle.Empty, false);
							de.b();
							num7 += ((Control)de).Height;
						}
						List<cg> val25 = new List<cg>();
						Enumerator<ApplyAndExecuteProcess> enumerator4 = val22.GetEnumerator();
						try
						{
							while (enumerator4.MoveNext())
							{
								cg cg3 = new cg(enumerator4.Current.OwnerObject, BWN, BWn, Rectangle.Empty, false);
								cg3.A(false, true, null, 0);
								val25.Add(cg3);
								if (num7 == 0)
								{
									num7 = 42;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator4).Dispose();
						}
						int num8 = BB.A(val9, val10, null, val7, val5, val12, num3, val9.Count != 0 && !string.IsNullOrEmpty(((Control)val11).Text)) + num7;
						if (flag5)
						{
							num8 += ((Control)cQ).Height;
						}
						Panel val26 = new Panel();
						((Control)val26).Tag = ((Setting)dn).A();
						val26.BorderStyle = (BorderStyle)1;
						((Control)val26).BackColor = ((Control)BWQ).BackColor;
						Point autoScrollPosition = ((ScrollableControl)BWQ).AutoScrollPosition;
						int num9 = ((Point)(ref autoScrollPosition)).X - 1;
						autoScrollPosition = ((ScrollableControl)BWQ).AutoScrollPosition;
						((Control)val26).Location = new Point(num9, ((Point)(ref autoScrollPosition)).Y + BWm - 1);
						((Control)val26).Height = num8 + 1;
						if (val == null)
						{
							foreach (Panel item2 in (ArrangedElementCollection)((Control)BWQ).Controls)
							{
								Panel val27 = item2;
								if (((Control)val27).Top >= ((Control)val26).Top)
								{
									((Control)val27).Top = ((Control)val27).Top + num8;
								}
							}
							((Control)BWQ).Controls.Add((Control)(object)val26);
						}
						else
						{
							if (((Control)val).Height != ((Control)val26).Height)
							{
								((Control)val).Height = ((Control)val26).Height;
							}
							if (((Control)val).Top != ((Control)val26).Top)
							{
								((Control)val).Top = ((Control)val26).Top;
							}
						}
						BWm += num8;
						BB.A(val9, val10, null, val7, val4, val5, null, val11, val12, num8 - num7, num3, val9.Count != 0 && !string.IsNullOrEmpty(((Control)val11).Text));
						if (!flag5)
						{
							if (((Control)themedButton2).Visible)
							{
								if (settingOrSpecialObject != null && settingOrSpecialObject.F().b().Count != 0)
								{
									((Control)themedButton).Top = ((Control)val6).Top - 18;
								}
								else
								{
									((Control)themedButton).Top = ((Control)val6).Top - 28;
								}
								if (((Control)val6).Text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy()))
								{
									((Control)themedButton).Top = ((Control)themedButton).Top + 10;
								}
								((Control)themedButton2).Top = ((Control)themedButton).Bottom;
								((Control)themedButton3).Top = ((Control)themedButton2).Bottom;
							}
							else
							{
								if (settingOrSpecialObject != null && settingOrSpecialObject.F().b().Count != 0)
								{
									((Control)themedButton).Top = ((Control)val6).Top - 6;
								}
								else
								{
									((Control)themedButton).Top = ((Control)val6).Top - 16;
								}
								if (((Control)val6).Text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy()))
								{
									((Control)themedButton).Top = ((Control)themedButton).Top + 10;
								}
								((Control)themedButton3).Top = ((Control)themedButton).Bottom;
							}
						}
						A(val26, val, cQ, val9, val10, val6, val3, val11, val5, val12, themedButton, themedButton2, themedButton3, dn);
						A(val26, val, num7, val23, de, val25, val10, flag3, settingOrSpecialObject, text8, text6);
						if (val != null)
						{
							A(val, val23, stateMachine, val22, ((Setting)dn).A(), text6 != null);
						}
						Panel val28 = ((val == null) ? val26 : val);
						int num10 = ((BWV != Rectangle.Empty) ? (((Control)BWQ).Width - 11) : 0);
						foreach (Control item3 in (ArrangedElementCollection)((Control)val28).Controls)
						{
							Control val29 = item3;
							num10 = Math.Max(num10, val29.Right);
						}
						((Control)val28).Width = Math.Max(((Control)val28).Width, num10 + 10);
						int num11 = ((BWV != Rectangle.Empty) ? (((Control)BWQ).Width - 1) : 0);
						foreach (Control item4 in (ArrangedElementCollection)((Control)BWQ).Controls)
						{
							Control val30 = item4;
							num11 = Math.Max(num11, val30.Width);
						}
						foreach (Control item5 in (ArrangedElementCollection)((Control)BWQ).Controls)
						{
							item5.Width = num11;
						}
						if (BWV == Rectangle.Empty)
						{
							((Control)BWQ).Width = num11 + 1;
							int num12 = 0;
							foreach (Control item6 in (ArrangedElementCollection)((Control)BWQ).Controls)
							{
								Control val31 = item6;
								num12 = Math.Max(num12, val31.Bottom);
							}
							((Control)BWQ).Height = num12 + 2;
						}
					}
				}
				if (val == null || (!(dn.al() || flag2) && flag))
				{
					continue;
				}
				int num13 = ((Control)val).Height - 1;
				int top = ((Control)val).Top;
				A(val);
				foreach (Panel item7 in (ArrangedElementCollection)((Control)BWQ).Controls)
				{
					Panel val32 = item7;
					if (((Control)val32).Top > top + 1)
					{
						((Control)val32).Top = ((Control)val32).Top - num13;
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (P_0.k().Count == 0)
		{
			return;
		}
		Enumerator<int> enumerator5 = P_0.k().GetEnumerator();
		try
		{
			while (enumerator5.MoveNext())
			{
				int current3 = enumerator5.Current;
				SettingOrSpecialObject settingOrSpecialObject2 = P_0.A().a(current3);
				a(settingOrSpecialObject2, P_1);
			}
		}
		finally
		{
			((System.IDisposable)enumerator5).Dispose();
		}
	}

	private void A(Panel P_0, Panel P_1, cQ P_2, List<PictureBox> P_3, List<Label> P_4, Label P_5, PictureBox P_6, Label P_7, Label P_8, Label P_9, ThemedButton P_10, ThemedButton P_11, ThemedButton P_12, Dn P_13)
	{
		//IL_0977: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Expected O, but got Unknown
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Expected O, but got Unknown
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected O, but got Unknown
		if (P_1 != null)
		{
			List<int> val = new List<int>();
			bool flag = false;
			for (int i = 0; i < ((ArrangedElementCollection)((Control)P_1).Controls).Count; i++)
			{
				Control val2 = ((Control)P_1).Controls[i];
				if (val2 is Label && BWq.Contains((Label)(object)((val2 is Label) ? val2 : null)))
				{
					flag = true;
					if (P_8 != null)
					{
						if ((val2.Tag as SettingOrSpecialObject[])[0] != (((Control)P_8).Tag as SettingOrSpecialObject[])[0])
						{
							(val2.Tag as SettingOrSpecialObject[])[0] = (((Control)P_8).Tag as SettingOrSpecialObject[])[0];
						}
						if ((val2.Tag as SettingOrSpecialObject[])[1] != (((Control)P_8).Tag as SettingOrSpecialObject[])[1])
						{
							(val2.Tag as SettingOrSpecialObject[])[1] = (((Control)P_8).Tag as SettingOrSpecialObject[])[1];
						}
						if (val2.Left != ((Control)P_8).Left)
						{
							val2.Left = ((Control)P_8).Left;
						}
						if (val2.Top != ((Control)P_8).Top)
						{
							val2.Top = ((Control)P_8).Top;
						}
						((Component)P_8).Dispose();
					}
					else
					{
						SettingOrSpecialObject settingOrSpecialObject = (((val2 is Label) ? val2 : null).Tag as SettingOrSpecialObject[])[0];
						for (int j = 0; j < settingOrSpecialObject.F().b().Count; j++)
						{
							settingOrSpecialObject.F().b()[j].a(new EventHandler(e));
						}
						BWq.Remove((Label)(object)((val2 is Label) ? val2 : null));
						((Component)val2).Dispose();
						i--;
					}
				}
				else if (val2.Name != null && val2.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGw())
				{
					if (val2.Left != ((Control)P_5).Left)
					{
						val2.Left = ((Control)P_5).Left;
					}
					if (val2.Top != ((Control)P_5).Top)
					{
						val2.Top = ((Control)P_5).Top;
					}
					if (val2.Text != ((Control)P_5).Text)
					{
						val2.Text = ((Control)P_5).Text;
					}
					if (val2.Enabled != ((Control)P_5).Enabled)
					{
						val2.Enabled = ((Control)P_5).Enabled;
					}
					((Component)P_5).Dispose();
				}
				else if (val2.Name != null && val2.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGX())
				{
					if (val2.Left != ((Control)P_6).Left)
					{
						val2.Left = ((Control)P_6).Left;
					}
					if (val2.Top != ((Control)P_6).Top)
					{
						val2.Top = ((Control)P_6).Top;
					}
					((Component)P_6).Dispose();
				}
				else if (val2.Name != null && val2.Name.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgA()))
				{
					val.Add(int.Parse(val2.Name.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgA().Length)));
					PictureBox val3 = null;
					for (int k = 0; k < P_3.Count; k++)
					{
						PictureBox val4 = P_3[k];
						if (val2.Name == ((Control)val4).Name)
						{
							val3 = val4;
							break;
						}
					}
					if (val3 != null)
					{
						if (val2.Left != ((Control)val3).Left)
						{
							val2.Left = ((Control)val3).Left;
						}
						if (val2.Top != ((Control)val3).Top)
						{
							val2.Top = ((Control)val3).Top;
						}
						if (val2.Width != ((Control)val3).Width)
						{
							val2.Width = ((Control)val3).Width;
						}
						if (val2.Height != ((Control)val3).Height)
						{
							val2.Height = ((Control)val3).Height;
						}
						if (((PictureBox)((val2 is PictureBox) ? val2 : null)).Image != val3.Image)
						{
							((PictureBox)((val2 is PictureBox) ? val2 : null)).Image = val3.Image;
						}
						if (((Control)val3).Tag != null)
						{
							val2.Tag = ((Control)val3).Tag;
						}
					}
					else
					{
						((Component)val2).Dispose();
						i--;
					}
				}
				else if (val2.Name != null && val2.Name.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bga()))
				{
					Label val5 = null;
					for (int l = 0; l < P_4.Count; l++)
					{
						Label val6 = P_4[l];
						if (val2.Name == ((Control)val6).Name)
						{
							val5 = val6;
							break;
						}
					}
					if (val5 != null)
					{
						if (val2.Left != ((Control)val5).Left)
						{
							val2.Left = ((Control)val5).Left;
						}
						if (val2.Top != ((Control)val5).Top)
						{
							val2.Top = ((Control)val5).Top;
						}
						if (val2.Text != ((Control)val5).Text)
						{
							val2.Text = ((Control)val5).Text;
						}
						if (val2.ForeColor != ((Control)val5).ForeColor)
						{
							val2.ForeColor = ((Control)val5).ForeColor;
						}
						if (val2.Enabled != ((Control)val5).Enabled)
						{
							val2.Enabled = ((Control)val5).Enabled;
						}
						if (((Control)val5).Tag != null)
						{
							val2.Tag = ((Control)val5).Tag;
						}
					}
					else
					{
						((Component)val2).Dispose();
						i--;
					}
				}
				else if (val2.Name != null && val2.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBZ())
				{
					if (val2.Left != ((Control)P_7).Left)
					{
						val2.Left = ((Control)P_7).Left;
					}
					if (val2.Top != ((Control)P_7).Top)
					{
						val2.Top = ((Control)P_7).Top;
					}
					if (val2.Text != ((Control)P_7).Text)
					{
						val2.Text = ((Control)P_7).Text;
					}
					if (val2.Enabled != ((Control)P_7).Enabled)
					{
						val2.Enabled = ((Control)P_7).Enabled;
					}
					((Component)P_7).Dispose();
				}
				else if (val2.Name != null && val2.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgB())
				{
					if (P_9 != null)
					{
						if (val2.Left != ((Control)P_9).Left)
						{
							val2.Left = ((Control)P_9).Left;
						}
						if (val2.Top != ((Control)P_9).Top)
						{
							val2.Top = ((Control)P_9).Top;
						}
						if (val2.Text != ((Control)P_9).Text)
						{
							val2.Text = ((Control)P_9).Text;
						}
						if (val2.ForeColor != ((Control)P_9).ForeColor)
						{
							val2.ForeColor = ((Control)P_9).ForeColor;
						}
						((Component)P_9).Dispose();
					}
					else
					{
						((Component)val2).Dispose();
						i--;
					}
				}
				else if (val2 is Button && (val2.Text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oW()) || val2.Text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgD())))
				{
					if (val2.Left != ((Control)P_10).Left)
					{
						val2.Left = ((Control)P_10).Left;
					}
					if (val2.Top != ((Control)P_10).Top)
					{
						val2.Top = ((Control)P_10).Top;
					}
					if (val2.Enabled != ((Control)P_10).Enabled)
					{
						val2.Enabled = ((Control)P_10).Enabled;
					}
					if (val2.ForeColor != ((Control)P_10).ForeColor)
					{
						val2.ForeColor = ((Control)P_10).ForeColor;
					}
					((Component)P_10).Dispose();
				}
				else if (val2 is Button && val2.Text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgd()))
				{
					if (val2.Visible != ((Control)P_11).Visible)
					{
						val2.Visible = ((Control)P_11).Visible;
					}
					if (val2.Left != ((Control)P_11).Left)
					{
						val2.Left = ((Control)P_11).Left;
					}
					if (val2.Top != ((Control)P_11).Top)
					{
						val2.Top = ((Control)P_11).Top;
					}
					if (val2.Enabled != ((Control)P_11).Enabled)
					{
						val2.Enabled = ((Control)P_11).Enabled;
					}
					if (val2.ForeColor != ((Control)P_11).ForeColor)
					{
						val2.ForeColor = ((Control)P_11).ForeColor;
					}
					((Component)P_11).Dispose();
				}
				else if (val2 is Button && val2.Text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bcj()))
				{
					if (val2.Left != ((Control)P_12).Left)
					{
						val2.Left = ((Control)P_12).Left;
					}
					if (val2.Top != ((Control)P_12).Top)
					{
						val2.Top = ((Control)P_12).Top;
					}
					if (val2.Enabled != ((Control)P_12).Enabled)
					{
						val2.Enabled = ((Control)P_12).Enabled;
					}
					if (val2.ForeColor != ((Control)P_12).ForeColor)
					{
						val2.ForeColor = ((Control)P_12).ForeColor;
					}
					((Component)P_12).Dispose();
				}
				else if (val2 is cQ)
				{
					if (val2.Left != ((Control)P_2).Left)
					{
						val2.Left = ((Control)P_2).Left;
					}
					if (val2.Top != ((Control)P_2).Top)
					{
						val2.Top = ((Control)P_2).Top;
					}
					if (val2.Enabled != ((Control)P_2).Enabled)
					{
						val2.Enabled = ((Control)P_2).Enabled;
					}
					((Component)P_2).Dispose();
				}
			}
			if (P_8 != null && !flag)
			{
				((Control)P_1).Controls.Add((Control)(object)P_8);
				BWq.Add(P_8);
			}
			for (int m = 0; m < P_3.Count; m++)
			{
				if (!val.Contains(m))
				{
					PictureBox val7 = P_3[m];
					((Control)P_1).Controls.Add((Control)(object)val7);
					Label val8 = P_4[m];
					((Control)P_1).Controls.Add((Control)(object)val8);
				}
			}
			return;
		}
		if (P_2 != null)
		{
			((Control)P_0).Controls.Add((Control)(object)P_2);
		}
		if (P_5 != null)
		{
			((Control)P_0).Controls.Add((Control)(object)P_5);
		}
		if (P_6 != null)
		{
			((Control)P_0).Controls.Add((Control)(object)P_6);
		}
		if (P_8 != null)
		{
			((Control)P_0).Controls.Add((Control)(object)P_8);
		}
		Enumerator<PictureBox> enumerator = P_3.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				PictureBox current = enumerator.Current;
				((Control)P_0).Controls.Add((Control)(object)current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		Enumerator<Label> enumerator2 = P_4.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				Label current2 = enumerator2.Current;
				((Control)P_0).Controls.Add((Control)(object)current2);
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
		((Control)P_0).Controls.Add((Control)(object)P_7);
		if (P_9 != null)
		{
			((Control)P_0).Controls.Add((Control)(object)P_9);
		}
		if (!P_13.am() && !P_13.al() && !P_13.aN() && (!BWN.B() || !BWN.b() || !P_13.J()))
		{
			((Control)P_10).Click += new EventHandler(H);
			((Control)P_0).Controls.Add((Control)(object)P_10);
			((Control)P_11).Click += new EventHandler(I);
			((Control)P_0).Controls.Add((Control)(object)P_11);
			((Control)P_12).Click += new EventHandler(h);
			((Control)P_0).Controls.Add((Control)(object)P_12);
		}
	}

	private void F(object P_0, EventArgs P_1)
	{
		if (P_0 is PictureBox)
		{
			PictureBox val = (PictureBox)((P_0 is PictureBox) ? P_0 : null);
			if (((Control)val).Tag is Setting)
			{
				BM.A(((Control)val).Tag as Setting, (Control)((P_0 is Control) ? P_0 : null));
			}
		}
	}

	private void f(object P_0, EventArgs P_1)
	{
		PictureBox val = null;
		if (P_0 is PictureBox)
		{
			val = (PictureBox)((P_0 is PictureBox) ? P_0 : null);
		}
		else if (P_0 is Label)
		{
			Label val2 = (Label)((P_0 is Label) ? P_0 : null);
			if (((Control)val2).Parent.Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGX()))
			{
				Control obj = ((Control)val2).Parent.Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGX()];
				val = (PictureBox)(object)((obj is PictureBox) ? obj : null);
			}
		}
		if (val == null)
		{
			return;
		}
		if (BM.SR != val)
		{
			if (!BM.Sr && BM.SR != null)
			{
				((Control)BM.SR).Visible = false;
			}
			BM.Sr = false;
			BM.SR = val;
		}
		((Control)val).Visible = true;
		((Control)val).BringToFront();
	}

	private void G(object P_0, EventArgs P_1)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		PictureBox val = null;
		if (P_0 is PictureBox)
		{
			val = (PictureBox)((P_0 is PictureBox) ? P_0 : null);
		}
		else if (P_0 is Label)
		{
			Label val2 = (Label)((P_0 is Label) ? P_0 : null);
			if (((Control)val2).Parent.Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGX()))
			{
				Control obj = ((Control)val2).Parent.Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BGX()];
				val = (PictureBox)(object)((obj is PictureBox) ? obj : null);
			}
		}
		if (val != null)
		{
			Point val3 = ((Control)val).Parent.PointToClient(Control.MousePosition);
			Rectangle bounds = ((Control)val).Bounds;
			if (!((Rectangle)(ref bounds)).Contains(val3))
			{
				((Control)val).Visible = false;
			}
		}
	}

	private List<int> A(bool P_0, SettingOrSpecialObject P_1, Dn P_2, PortFunction.a P_3, out StateMachine P_4, out List<ApplyAndExecuteProcess> P_5)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		List<int> val = new List<int>();
		P_4 = null;
		P_5 = new List<ApplyAndExecuteProcess>();
		if ((P_3 == null || (!bx.A(BWN.awZ) && (BWN.awZ != 21 || !(BWN.aXA < new k(2, 27, 0, 1, 0))) && (BWN.awZ == 21 || !(BWN.aXA < new k(1, 27, 0, 1, 0))))) && P_1 != null && !P_0)
		{
			Enumerator<SettingOrSpecialObject> enumerator = P_1.a().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					SettingOrSpecialObject current = enumerator.Current;
					bool flag = current.B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ia());
					if (!(current.l() || flag) || (P_2 != null && (P_2.al() || P_2.aN())))
					{
						continue;
					}
					Setting setting = current as Setting;
					bool num = setting != null && !setting.b() && !setting.am() && !setting.aN() && setting.av()[0] == 1 && setting.av()[1] == 1 && setting.av()[2] == 1 && ((setting.aH() && setting.ah() && setting.aJ()) || !setting.aJ());
					bool flag2 = current is SpecialObject specialObject && (specialObject.C().IdleText != null || specialObject.C().PreApplySettingDataIds.Count != 0);
					bool flag3 = current is StateMachine;
					if (!(num || flag3 || flag2) || !PortFunction.A(current, P_2, P_3))
					{
						continue;
					}
					if (current is StateMachine)
					{
						if (BM.qC == null)
						{
							P_4 = current as StateMachine;
						}
					}
					else if (current is SpecialObject && ((current as SpecialObject).C().IdleText != null || (current as SpecialObject).C().PreApplySettingDataIds.Count != 0))
					{
						if (BM.qC == null)
						{
							P_5.Add((current as SpecialObject).C());
						}
					}
					else if (current is Setting && (BM.qC == null || BM.qD.Contains(setting.A())))
					{
						val.Add((current as Setting).A());
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		return val;
	}

	private void A(Panel P_0, Panel P_1, int P_2, List<int> P_3, De P_4, List<cg> P_5, List<Label> P_6, bool P_7, SettingOrSpecialObject P_8, string P_9, string P_10)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected O, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected O, but got Unknown
		int left = 10;
		int num = ((Control)P_0).Height - (P_2 + 3);
		if (!P_7)
		{
			if (P_8 != null)
			{
				int num2 = 0;
				Framework framework = ((BM.QO != BM.b.BpG || BWn == null) ? BWN : BWn);
				Enumerator<int> enumerator = P_3.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						int current = enumerator.Current;
						Setting setting = framework.A(current);
						if (setting == null)
						{
							continue;
						}
						if (num2 == 4)
						{
							left = 10;
							num += 42;
						}
						if (setting.L().Count != 0)
						{
							cu cu = new cu(setting.C(), BWN, BWn, null, false, true, true);
							((Control)cu).Left = left;
							((Control)cu).Top = num;
							bool flag = false;
							if (P_1 != null)
							{
								foreach (Control item in (ArrangedElementCollection)((Control)P_1).Controls)
								{
									Control val = item;
									if (val is cu && ((aj)(val as cu)).b() == setting)
									{
										if (val.Left != ((Control)cu).Left)
										{
											val.Left = ((Control)cu).Left;
										}
										if (val.Top != ((Control)cu).Top)
										{
											val.Top = ((Control)cu).Top;
										}
										flag = true;
										break;
									}
								}
							}
							left = ((Control)cu).Right + 10;
							if (!flag)
							{
								if (P_1 != null)
								{
									((Control)P_1).Controls.Add((Control)(object)cu);
								}
								else
								{
									((Control)P_0).Controls.Add((Control)(object)cu);
								}
							}
							else
							{
								((Component)cu).Dispose();
							}
						}
						else if (setting.U())
						{
							ct ct = new ct(setting.C(), BWN, BWn, null, false);
							((Control)ct).Left = left;
							((Control)ct).Top = num;
							bool flag2 = false;
							if (P_1 != null)
							{
								foreach (Control item2 in (ArrangedElementCollection)((Control)P_1).Controls)
								{
									Control val2 = item2;
									if (val2 is ct && (val2 as ct).b() == setting)
									{
										if (val2.Left != ((Control)ct).Left)
										{
											val2.Left = ((Control)ct).Left;
										}
										if (val2.Top != ((Control)ct).Top)
										{
											val2.Top = ((Control)ct).Top;
										}
										flag2 = true;
										break;
									}
								}
							}
							left = ((Control)ct).Right + 10;
							if (!flag2)
							{
								if (P_1 != null)
								{
									((Control)P_1).Controls.Add((Control)(object)ct);
								}
								else
								{
									((Control)P_0).Controls.Add((Control)(object)ct);
								}
							}
							else
							{
								((Component)ct).Dispose();
							}
						}
						else
						{
							DE dE = new DE(setting.C(), BWN, BWn, null, false, false, true);
							((Control)dE).Left = left;
							((Control)dE).Top = num;
							bool flag3 = false;
							if (P_1 != null)
							{
								foreach (Control item3 in (ArrangedElementCollection)((Control)P_1).Controls)
								{
									Control val3 = item3;
									if (val3 is DE && ((aj)(val3 as DE)).b() == setting)
									{
										if (val3.Left != ((Control)dE).Left)
										{
											val3.Left = ((Control)dE).Left;
										}
										if (val3.Top != ((Control)dE).Top)
										{
											val3.Top = ((Control)dE).Top;
										}
										flag3 = true;
										break;
									}
								}
							}
							left = ((Control)dE).Right + 10;
							if (!flag3)
							{
								if (P_1 != null)
								{
									((Control)P_1).Controls.Add((Control)(object)dE);
								}
								else
								{
									((Control)P_0).Controls.Add((Control)(object)dE);
								}
							}
							else
							{
								((Component)dE).Dispose();
							}
						}
						num2++;
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				for (int i = 0; i < P_5.Count; i++)
				{
					bool flag4 = ((SettingOrSpecialObject)P_5[i].B()).B().Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ia());
					if (flag4)
					{
						Label val4 = ((P_6.Count <= 0) ? null : (val4 = P_6[0]));
						if (val4 != null)
						{
							if (((Control)P_5[i]).Left == 0 && i == 0)
							{
								((Control)P_5[i]).Left = ((Control)val4).Left + 60;
							}
							else if (i > 0)
							{
								((Control)P_5[i]).Left = ((Control)P_5[i - 1]).Left + ((Control)P_5[i - 1]).Width;
							}
							((Control)P_5[i]).Top = -9;
						}
					}
					else
					{
						((Control)P_5[i]).Left = left;
						((Control)P_5[i]).Top = num + 6;
					}
					bool flag5 = false;
					if (P_1 != null)
					{
						foreach (Control item4 in (ArrangedElementCollection)((Control)P_1).Controls)
						{
							Control val5 = item4;
							if (val5 is cg && (val5 as cg).B() == P_5[i].B())
							{
								if (val5.Left != ((Control)P_5[i]).Left)
								{
									val5.Left = ((Control)P_5[i]).Left;
								}
								if (val5.Top != ((Control)P_5[i]).Top)
								{
									val5.Top = ((Control)P_5[i]).Top;
								}
								if ((val5 as cg).BHP != P_5[i].BHP)
								{
									(val5 as cg).BHP = P_5[i].BHP;
								}
								flag5 = true;
								break;
							}
						}
					}
					if (!flag4)
					{
						left = ((Control)P_5[i]).Right + 10;
					}
					if (!flag5)
					{
						if (P_1 != null)
						{
							((Control)P_1).Controls.Add((Control)(object)P_5[i]);
						}
						else
						{
							((Control)P_0).Controls.Add((Control)(object)P_5[i]);
						}
					}
					else
					{
						((Component)P_5[i]).Dispose();
					}
				}
				if (P_4 != null)
				{
					left = 10;
					if (num2 != 0)
					{
						num += 42;
					}
					((Control)P_4).Left = left;
					((Control)P_4).Top = num;
					bool flag6 = false;
					if (P_1 != null)
					{
						foreach (Control item5 in (ArrangedElementCollection)((Control)P_1).Controls)
						{
							Control val6 = item5;
							if (val6 is De)
							{
								if (val6.Left != ((Control)P_4).Left)
								{
									val6.Left = ((Control)P_4).Left;
								}
								if (val6.Top != ((Control)P_4).Top)
								{
									val6.Top = ((Control)P_4).Top;
								}
								flag6 = true;
								break;
							}
						}
					}
					if (!flag6)
					{
						if (P_1 != null)
						{
							((Control)P_1).Controls.Add((Control)(object)P_4);
						}
						else
						{
							((Control)P_0).Controls.Add((Control)(object)P_4);
						}
					}
					else
					{
						((Component)P_4).Dispose();
					}
				}
			}
			if (P_9 != null || P_10 != null)
			{
				A(P_0, P_1, P_9, P_10, ref left, ref num);
			}
		}
		else if (P_9 != null)
		{
			A(P_0, P_1, P_9, P_10, ref left, ref num);
		}
	}

	private void A(Panel P_0, Panel P_1, string P_2, string P_3, ref int P_4, ref int P_5)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		Label val = new Label();
		((Control)val).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgH();
		((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8.25f);
		((Control)val).AutoSize = true;
		((Control)val).MinimumSize = new Size(250, 0);
		((Control)val).MaximumSize = new Size(250, 0);
		if (P_2 != null)
		{
			((Control)val).Text = P_2;
			((Control)val).ForeColor = BM.tC;
		}
		else if (P_3 != null)
		{
			((Control)val).Text = P_3;
			((Control)val).ForeColor = BM.tD;
		}
		((Control)val).Left = P_4;
		((Control)val).Top = P_5;
		bool flag = false;
		if (P_1 != null)
		{
			foreach (Control item in (ArrangedElementCollection)((Control)P_1).Controls)
			{
				Control val2 = item;
				if (val2 is Label && val2.Name != null && val2.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgH() && (val2.ForeColor == BM.tC || val2.ForeColor == BM.tD))
				{
					if (val2.Left != ((Control)val).Left)
					{
						val2.Left = ((Control)val).Left;
					}
					if (val2.Top != ((Control)val).Top)
					{
						val2.Top = ((Control)val).Top;
					}
					if (val2.Text != ((Control)val).Text)
					{
						val2.Text = ((Control)val).Text;
					}
					if (val2.ForeColor != ((Control)val).ForeColor)
					{
						val2.ForeColor = ((Control)val).ForeColor;
					}
					flag = true;
					break;
				}
			}
		}
		P_4 = ((Control)val).Right + 10;
		if (!flag)
		{
			if (P_1 != null)
			{
				((Control)P_1).Controls.Add((Control)(object)val);
			}
			else
			{
				((Control)P_0).Controls.Add((Control)(object)val);
			}
		}
		else
		{
			((Component)val).Dispose();
		}
	}

	private void A(Panel P_0, List<int> P_1, StateMachine P_2, List<ApplyAndExecuteProcess> P_3, int P_4, bool P_5)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		Framework framework = ((BM.QO != BM.b.BpG || BWn == null) ? BWN : BWn);
		for (int i = 0; i < ((ArrangedElementCollection)((Control)P_0).Controls).Count; i++)
		{
			Control val = ((Control)P_0).Controls[i];
			if (val is Label)
			{
				if (val.Name != null && val.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgH())
				{
					if (val.ForeColor == BM.tC)
					{
						if (framework.A(P_4) is Dn dn && (dn.ax() == 0 || dn.o().Count == 0) && !A((Setting)dn))
						{
							((Component)val).Dispose();
							i--;
						}
					}
					else if (val.ForeColor == BM.tD && !P_5)
					{
						((Component)val).Dispose();
						i--;
					}
				}
				else if (val.Tag != null && val.Tag is int)
				{
					Setting setting = framework.A((int)val.Tag);
					if (PortFunction.a(((SettingOrSpecialObject)setting).D()) && !P_1.Contains(setting.A()))
					{
						((Component)val).Dispose();
						i--;
					}
				}
			}
			else if (val is cu)
			{
				if (!P_1.Contains(((aj)(val as cu)).b().A()))
				{
					((Component)val).Dispose();
					i--;
				}
			}
			else if (val is ct)
			{
				if (!P_1.Contains((val as ct).b().A()))
				{
					((Component)val).Dispose();
					i--;
				}
			}
			else if (val is DE)
			{
				if (!P_1.Contains(((aj)(val as DE)).b().A()))
				{
					((Component)val).Dispose();
					i--;
				}
			}
			else if (val is De)
			{
				if (P_2 == null)
				{
					((Component)val).Dispose();
					i--;
				}
			}
			else
			{
				if (!(val is cg))
				{
					continue;
				}
				bool flag = false;
				Enumerator<ApplyAndExecuteProcess> enumerator = P_3.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ApplyAndExecuteProcess current = enumerator.Current;
						if ((val as cg).B() == current.OwnerObject)
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
				if (!flag)
				{
					((Component)val).Dispose();
					i--;
				}
			}
		}
	}

	private bool A(Setting P_0)
	{
		if (PortFunction.A((uint)P_0.ax()) == Cg.BAM && A(P_0, out var setting, out var setting2) != null && setting != null && setting2 != null && !setting.O())
		{
			return true;
		}
		return false;
	}

	private void g(object P_0, EventArgs P_1)
	{
		A(false);
	}

	private void H(object P_0, EventArgs P_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG || !BWN.C())
		{
			return;
		}
		int num = (int)((Control)(Button)P_0).Tag;
		Setting setting = BWN.A(num);
		if (setting is Dn)
		{
			cX cX = new cX(setting as Dn);
			if ((int)((Form)cX).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				A(false);
			}
			((Component)cX).Dispose();
		}
	}

	private void h(object P_0, EventArgs P_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (BM.QO != BM.b.BpG && BWN.C())
		{
			int num = (int)((Control)(Button)P_0).Tag;
			Setting setting = BWN.A(num);
			if (setting is Dn)
			{
				Ck ck = BM.aM();
				ck?.A(setting.A());
				setting.a(0, true);
				ck?.B();
				BM.b(setting.A());
			}
		}
	}

	private void I(object P_0, EventArgs P_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		if (BM.QO == BM.b.BpG || !BWN.C())
		{
			return;
		}
		int num = (int)((Control)(Button)P_0).Tag;
		Setting setting = BWN.A(num);
		if (!(setting is Dn))
		{
			return;
		}
		Setting setting2;
		Setting setting3;
		SettingOrSpecialObject settingOrSpecialObject = A(setting, out setting2, out setting3);
		if (settingOrSpecialObject == null || setting2 == null || setting3 == null)
		{
			settingOrSpecialObject = A(out setting2, out setting3);
		}
		if (settingOrSpecialObject != null && setting2 != null && setting3 != null)
		{
			if (setting2.ax() == 0)
			{
				Ck ck = BM.aM();
				ck?.A(setting2.A());
				setting2.a(1, true);
				ck?.B();
				BM.b(setting2.A());
			}
			Setting setting4 = BWN.A(settingOrSpecialObject.I());
			if (setting4 != null && setting4.c() != 0)
			{
				string text = ((SettingOrSpecialObject)setting).A(bz.aYv);
				if (string.IsNullOrEmpty(text))
				{
					text = ((SettingOrSpecialObject)setting).A(bz.aYu);
				}
				string text2 = (string.IsNullOrEmpty(text) ? ((SettingOrSpecialObject)setting).A(bz.aYt) : text);
				if (setting4.ay() != text2)
				{
					Ck ck2 = BM.aM();
					ck2?.A(setting4.A());
					setting4.A(text2, true);
					ck2?.B();
					BM.b(setting4.A());
				}
			}
			A(setting2, setting, setting3);
		}
		else
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgh(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BgI(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private SettingOrSpecialObject A(Setting P_0, out Setting P_1, out Setting P_2)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		SettingOrSpecialObject settingOrSpecialObject = null;
		P_1 = null;
		P_2 = null;
		int num = P_0.ax();
		Cg cg = PortFunction.A((uint)num);
		ushort num2 = PortFunction.b((uint)num);
		if (cg == Cg.BAM)
		{
			Enumerator<SettingOrSpecialObject> enumerator = BWN.awD.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					SettingOrSpecialObject current = enumerator.Current;
					if (!(current is Setting) || current.F().E().BSQ != Cg.BAM || current.F().E().BSr != num2)
					{
						continue;
					}
					P_2 = current as Setting;
					settingOrSpecialObject = ((SettingOrSpecialObject)P_2).D();
					Enumerator<SettingOrSpecialObject> enumerator2 = settingOrSpecialObject.a().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							SettingOrSpecialObject current2 = enumerator2.Current;
							if (current2 is Setting && (current2 as Setting).U())
							{
								P_1 = current2 as Setting;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
					break;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		return settingOrSpecialObject;
	}

	private SettingOrSpecialObject A(out Setting P_0, out Setting P_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		SettingOrSpecialObject settingOrSpecialObject = null;
		P_0 = null;
		P_1 = null;
		Enumerator<SettingOrSpecialObject> enumerator = BWN.awD.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SettingOrSpecialObject current = enumerator.Current;
				if (!(current is Setting) || current.F().E().BSQ != Cg.BAM)
				{
					continue;
				}
				P_1 = current as Setting;
				settingOrSpecialObject = ((SettingOrSpecialObject)P_1).D();
				Enumerator<SettingOrSpecialObject> enumerator2 = settingOrSpecialObject.a().GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						SettingOrSpecialObject current2 = enumerator2.Current;
						if (current2 is Setting && (current2 as Setting).U())
						{
							P_0 = current2 as Setting;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				if (P_0 == null || P_0.ax() != 0)
				{
					settingOrSpecialObject = null;
					continue;
				}
				break;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return settingOrSpecialObject;
	}

	private void A(Setting P_0, Setting P_1, Setting P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Invalid comparison between Unknown and I4
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		Form val = new Form();
		((Control)val).BackColor = BM.td;
		((Control)val).ForeColor = BM.te;
		((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bgi();
		val.FormBorderStyle = (FormBorderStyle)3;
		val.MinimizeBox = false;
		val.MaximizeBox = false;
		val.ShowIcon = false;
		val.ShowInTaskbar = false;
		val.StartPosition = (FormStartPosition)4;
		val.Shown += new EventHandler(i);
		Df df = new Df(BWN, BWn, Rectangle.Empty, false, false, false);
		df.A(P_0.t());
		((Control)df).Left = 5;
		((Control)df).Top = 5;
		((Panel)df).BorderStyle = (BorderStyle)1;
		df.A(true);
		((Control)df).Height = ((Control)df).Height + 10;
		df.BXo = false;
		ThemedButton themedButton = new ThemedButton();
		((Button)themedButton).DialogResult = (DialogResult)2;
		((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
		((Control)themedButton).Size = new Size(80, 30);
		((Control)themedButton).Location = new Point(((Control)df).Width - ((Control)themedButton).Width, ((Control)df).Height + 15);
		ThemedButton themedButton2 = new ThemedButton();
		((Button)themedButton2).DialogResult = (DialogResult)1;
		((Control)themedButton2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
		((Control)themedButton2).Size = new Size(80, 30);
		((Control)themedButton2).Location = new Point(((Control)themedButton).Left - (10 + ((Control)themedButton2).Width), ((Control)df).Height + 15);
		val.CancelButton = (IButtonControl)(object)themedButton;
		Size clientSize = default(Size);
		((Size)(ref clientSize))._002Ector(5 + ((Control)df).Width + 5, 5 + ((Control)df).Height + 10 + ((Control)themedButton2).Height + 10);
		val.ClientSize = clientSize;
		((Control)val).Controls.Add((Control)(object)df);
		((Control)val).Controls.Add((Control)(object)themedButton2);
		((Control)val).Controls.Add((Control)(object)themedButton);
		BWv = df;
		HashSet<DataIdAndAttrId> val2 = P_0.t().j(false);
		Enumerator<DataIdAndAttrId> enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current = enumerator.Current;
				Setting setting = BWN.A(current);
				if (setting != null && !setting.aJ())
				{
					((SettingOrSpecialObject)setting).A(new EventHandler(J));
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if ((int)val.ShowDialog((IWin32Window)(object)BM.QQ) == 1)
		{
			int num = (int)PortFunction.A(Cg.BAM, CH.Bae, (ushort)P_2.A());
			if (P_1.ax() != num)
			{
				Ck ck = BM.aM();
				ck?.A(P_1.A());
				P_1.a(num, true);
				ck?.B();
				BM.b(P_1.A());
			}
		}
		else if (P_0.ax() != 0)
		{
			Ck ck2 = BM.aM();
			ck2?.A(P_0.A());
			P_0.a(0, true);
			ck2?.B();
			BM.b(P_0.A());
		}
		enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataIdAndAttrId current2 = enumerator.Current;
				Setting setting2 = BWN.A(current2);
				if (setting2 != null && !setting2.aJ())
				{
					((SettingOrSpecialObject)setting2).a(new EventHandler(J));
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		BWv = null;
		val.Shown -= new EventHandler(i);
		((Component)val).Dispose();
	}

	private void i(object P_0, EventArgs P_1)
	{
		if (BWv != null)
		{
			BWv.BXo = true;
		}
	}

	private void J(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				b b = J;
				((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (BWv != null && !((Control)BWv).Disposing && !((Control)BWv).IsDisposed)
		{
			BWv.A(false);
		}
	}
}
internal class Dd : cv
{
	private new delegate void A(object P_0, EventArgs P_1);

	private new delegate void a(object P_0, EventArgs P_1);

	private bool BWW;

	private int BWw;

	private Label BWX = new Label();

	private bool BWx;

	private bool BWY;

	internal Dd(DataIdAndAttrId P_0, bool P_1, int P_2, Framework P_3, Framework P_4, Cn P_5, bool P_6)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		A(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
	}

	private void A(DataIdAndAttrId P_0, bool P_1, int P_2, Framework P_3, Framework P_4, Cn P_5, bool P_6)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		BWW = P_1;
		BWw = P_2;
		A(P_3, P_4);
		A(P_0);
		BNQ = P_5;
		if (BNQ != null)
		{
			BNq = P_6;
			int[] array = BNQ.a(ic);
			int num = (BWW ? BWw : 0);
			if (array != null && array.Length > num)
			{
				BNR = array[num];
			}
			else
			{
				BNQ = null;
			}
		}
		C();
		bool num2 = c();
		if (((Control)BNP).ContextMenuStrip == null)
		{
			((Control)BNP).ContextMenuStrip = a();
		}
		List<Control> val = new List<Control>();
		BM.QQ.B(new EventHandler(C));
		BNp = false;
		ic.A(new EventHandler(d));
		((SettingOrSpecialObject)ic).A(new EventHandler(c));
		((Control)this).SuspendLayout();
		bool flag = BM.QO == BM.b.BpF && (iF || @if) && ib != null;
		if (num2 || flag)
		{
			((Control)BWX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BcI();
			((Control)BWX).ForeColor = BM.te;
			((Control)BWX).Left = 0;
			((Control)BWX).Top = 2;
			((Control)BWX).AutoSize = true;
			val.Add((Control)(object)BWX);
			if (!((Control)this).Controls.Contains((Control)(object)BWX))
			{
				((Control)this).Controls.Add((Control)(object)BWX);
			}
			((Control)this).AutoSize = false;
			((Control)this).Height = ((Control)BNP).Height + 2;
			((Control)this).Width = 100;
		}
		else
		{
			((Control)BNP).Font = new Font(((Control)BNP).Font.FontFamily, 8.25f, ((Control)BNP).Font.Style);
			if (BM.QO == BM.b.BpG && iD != null)
			{
				((Control)BNP).Text = A(iD);
				((Control)BNP).Enabled = false;
			}
			else
			{
				((Control)BNP).Text = A(ic);
			}
			((Control)BNP).Left = 0;
			((Control)BNP).Top = 0;
			((Control)BNP).Width = 70;
			((Control)BNP).GotFocus += new EventHandler(b);
			((Control)BNP).KeyDown += new KeyEventHandler(A);
			((Control)BNP).KeyPress += new KeyPressEventHandler(A);
			((Control)BNP).Leave += new EventHandler(D);
			val.Add((Control)(object)BNP);
			if (!((Control)this).Controls.Contains((Control)(object)BNP))
			{
				((Control)this).Controls.Add((Control)(object)BNP);
			}
			((Control)this).AutoSize = false;
			((Control)this).Height = ((Control)BNP).Height;
			((Control)iG).Tag = ic;
			((Control)iG).Width = 18;
			((Control)iG).Height = 18;
			((Control)iG).Left = ((Control)BNP).Width + 5;
			((Control)iG).Top = 1;
			iG.SizeMode = (PictureBoxSizeMode)1;
			((Control)iG).Click += new EventHandler(B);
			val.Add((Control)(object)iG);
			if (!((Control)this).Controls.Contains((Control)(object)iG))
			{
				((Control)this).Controls.Add((Control)(object)iG);
			}
			((Control)this).Width = ((Control)iG).Right;
			((Control)iG).Visible = false;
			((Control)this).MouseEnter += new EventHandler(A);
			((Control)BNP).MouseEnter += new EventHandler(A);
			((Control)iG).MouseEnter += new EventHandler(A);
			((Control)BNP).MouseLeave += new EventHandler(a);
			((Control)this).MouseLeave += new EventHandler(a);
		}
		for (int num3 = ((ArrangedElementCollection)((Control)this).Controls).Count - 1; num3 >= 0; num3--)
		{
			if (!val.Contains(((Control)this).Controls[num3]))
			{
				((Control)this).Controls.RemoveAt(num3);
			}
		}
		b();
		c();
		((Control)this).ResumeLayout(true);
	}

	protected override void A(object P_0, EventArgs P_1)
	{
		if (BM.SR != iG)
		{
			if (!BM.Sr && BM.SR != null)
			{
				((Control)BM.SR).Visible = false;
			}
			bool flag = ((!BWW) ? ((SettingOrSpecialObject)ic).l() : ic.q()[0, 0, BWw]);
			BM.Sr = flag && !ic.O();
			BM.SR = iG;
		}
		((Control)iG).Visible = true;
	}

	protected override void a(object P_0, EventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		Rectangle clientRectangle = ((Control)this).ClientRectangle;
		if (!((Rectangle)(ref clientRectangle)).Contains(((Control)this).PointToClient(Cursor.Position)))
		{
			bool flag = ((!BWW) ? ((SettingOrSpecialObject)ic).l() : ic.q()[0, 0, BWw]);
			((Control)iG).Visible = iG.Image != null && flag && !ic.O();
		}
	}

	private new void b()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		bool flag = iB.C() && BM.QO != BM.b.BpG && ((!BWW) ? ((SettingOrSpecialObject)ic).l() : ic.q()[0, 0, BWw]);
		if (flag && !ic.O())
		{
			((Control)BNP).Enabled = true;
			switch (ic.P())
			{
			case IllegalitySeverityLevel.Error:
				((Control)BNP).BackColor = Color.Red;
				iG.Image = (Image)(object)GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Warning:
				((Control)BNP).BackColor = Color.Orange;
				iG.Image = (Image)(object)GeneralResources.YellowWarning;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (BM.A(iB.aXc, true))
				{
					((Control)BNP).BackColor = Color.Red;
					iG.Image = (Image)(object)GeneralResources.RedError;
				}
				else
				{
					((Control)BNP).BackColor = Color.Orange;
					iG.Image = (Image)(object)GeneralResources.YellowWarning;
				}
				break;
			default:
				((Control)BNP).BackColor = Color.Red;
				iG.Image = (Image)(object)GeneralResources.RedError;
				break;
			}
			((Control)iG).Visible = true;
		}
		else
		{
			((Control)BNP).Enabled = flag;
			bool flag2 = iF || @if;
			if (iD != null && !flag2 && !ic.A(iD, BWw))
			{
				((Control)BNP).BackColor = BM.tD;
			}
			else if (flag)
			{
				((Control)BNP).BackColor = BM.to;
			}
			else
			{
				((Control)BNP).BackColor = BM.tQ;
			}
			((Control)iG).Visible = false;
			iG.Image = (Image)(object)GeneralResources.QuestionMark;
		}
		if (((Control)BNP).Enabled || ((Control)BNP).BackColor == BM.tD)
		{
			((Control)BNP).ForeColor = BM.te;
		}
		else
		{
			((Control)BNP).ForeColor = BM.tq;
		}
		((Control)this).TabStop = ((Control)BNP).Enabled;
		((Control)BNP).TabStop = ((Control)this).TabStop;
		((Control)BNP).Invalidate();
	}

	private new void B(object P_0, EventArgs P_1)
	{
		BM.A(ic, BWw, (Control)(object)this);
	}

	private new void b(object P_0, EventArgs P_1)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		BM.QQ.rL.A(ic);
		if (ib != null && ((Control)BNP).BackColor == BM.tD)
		{
			BM.A(ic, BWw, (Control)(object)this);
		}
	}

	private new void C(object P_0, EventArgs P_1)
	{
		if (iF || @if)
		{
			A();
			return;
		}
		if (BM.QO == BM.b.BpG)
		{
			if (iD != null)
			{
				((Control)BNP).Text = A(iD);
			}
		}
		else
		{
			((Control)BNP).Text = A(ic);
		}
		b();
	}

	private void c(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				A a = c;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		b();
	}

	private string A(Setting P_0)
	{
		int num = ((!BWW) ? P_0.ax() : P_0.m(BWw));
		return bS.a(num, P_0.aS(), -1);
	}

	internal new void C()
	{
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)BNP).Disposing || BM.QP || BM.QO == BM.b.BpG || BM.sX)
		{
			return;
		}
		string text = ((Control)BNP).Text;
		BNp = false;
		string text2 = A(ic);
		if (text2 == text)
		{
			return;
		}
		if (string.IsNullOrWhiteSpace(text))
		{
			((Control)BNP).Text = text2;
			return;
		}
		if (((SettingOrSpecialObject)ic).j())
		{
			try
			{
				int num = bS.A(text, ic.aS());
				if (ic.aG() == 2)
				{
					if (ic.ag())
					{
						if (num < -32768)
						{
							num = -32768;
						}
						else if (num > 32767)
						{
							num = 32767;
						}
					}
					else if (num < 0)
					{
						num = 0;
					}
					else if (num > 65535)
					{
						num = 65535;
					}
				}
				else if (ic.aG() == 1)
				{
					if (ic.ag())
					{
						if (num < -128)
						{
							num = -128;
						}
						else if (num > 127)
						{
							num = 127;
						}
					}
					else if (num < 0)
					{
						num = 0;
					}
					else if (num > 255)
					{
						num = 255;
					}
				}
				int num2 = ic.an();
				if (num2 > 1)
				{
					num = N.A(num, num2);
				}
				int num3 = ic.aR();
				int num4 = ic.ar();
				if (num3 != 0 || num4 != 0)
				{
					num = Math.Min(Math.Max(num, num3), num4);
				}
				Ck ck = BM.aM();
				ck?.A(ic.C());
				if (BWW)
				{
					ic.a(BWw, num, true);
				}
				else
				{
					ic.a(num, true);
				}
				ck?.B();
				BM.A(ic.C());
				return;
			}
			catch
			{
				BWx = true;
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fQ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				BWx = false;
				((Control)BNP).Text = text2;
				return;
			}
		}
		((Control)BNP).Text = text2;
	}

	private void A(object P_0, KeyEventArgs P_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		if ((P_1.Control && (int)P_1.KeyCode == 33) || (int)P_1.KeyData == 33 || (P_1.Shift && (int)P_1.KeyCode == 33) || (P_1.Control && (int)P_1.KeyCode == 34) || (int)P_1.KeyData == 34 || (P_1.Shift && (int)P_1.KeyCode == 34))
		{
			BWY = true;
			P_1.Handled = true;
		}
		else if ((int)P_1.KeyCode == 13 || (int)P_1.KeyCode == 13)
		{
			C();
		}
		else if (!P_1.Control)
		{
			BNp = true;
		}
	}

	private void A(object P_0, KeyPressEventArgs P_1)
	{
		if (BWY)
		{
			P_1.Handled = true;
			BWY = false;
			BNp = false;
		}
	}

	private void D(object P_0, EventArgs P_1)
	{
		if (!BWx)
		{
			C();
		}
	}

	private void d(object P_0, EventArgs P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				a a = d;
				((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		c();
		if (BM.QO != BM.b.BpG && !BNp)
		{
			int selectionStart = ((TextBoxBase)BNP).SelectionStart;
			int selectionLength = ((TextBoxBase)BNP).SelectionLength;
			string text = A(ic);
			if (((Control)BNP).Text != text)
			{
				((Control)BNP).Text = text;
				BM.A(ic.C());
			}
			((TextBoxBase)BNP).SelectionStart = selectionStart;
			((TextBoxBase)BNP).SelectionLength = selectionLength;
			if (iD != null)
			{
				b();
			}
		}
	}

	private new void c()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		FontStyle val = (FontStyle)0;
		if (BNQ != null && BNq)
		{
			Setting setting = ((BM.QO != BM.b.BpG || iD == null) ? ic : iD);
			if (BWW)
			{
				if (setting.m(BWw) != BNR)
				{
					val = (FontStyle)2;
				}
			}
			else if (setting.ax() != BNR)
			{
				val = (FontStyle)2;
			}
		}
		if (((Control)BNP).Font.Style != val)
		{
			Font font = ((Control)BNP).Font;
			((Control)BNP).Font = new Font(((Control)BNP).Font.FontFamily, ((Control)BNP).Font.Size, val);
			font.Dispose();
		}
	}

	internal bool A(KeyEventArgs P_0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Invalid comparison between Unknown and I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Invalid comparison between Unknown and I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG)
		{
			return false;
		}
		if ((!P_0.Control || (int)P_0.KeyCode != 33) && (int)P_0.KeyData != 33 && (!P_0.Shift || (int)P_0.KeyCode != 33) && (!P_0.Control || (int)P_0.KeyCode != 34) && (int)P_0.KeyData != 34 && (!P_0.Shift || (int)P_0.KeyCode != 34))
		{
			return false;
		}
		BNp = false;
		int num = ic.aS();
		int num2 = ic.aR();
		int num3 = ic.ar();
		int num4 = ic.ax();
		int num5 = num4;
		if (P_0.Control && (int)P_0.KeyCode == 33)
		{
			num5 += bS.b(num);
		}
		else if ((int)P_0.KeyData == 33)
		{
			num5 += bS.C(num);
		}
		else if (P_0.Shift && (int)P_0.KeyCode == 33)
		{
			num5 += bS.c(num);
		}
		else if (P_0.Control && (int)P_0.KeyCode == 34)
		{
			num5 -= bS.b(num);
		}
		else if ((int)P_0.KeyData == 34)
		{
			num5 -= bS.C(num);
		}
		else if (P_0.Shift && (int)P_0.KeyCode == 34)
		{
			num5 -= bS.c(num);
		}
		if (num5 != num4)
		{
			if (num2 != 0 || num3 != 0)
			{
				num5 = Math.Min(num3, Math.Max(num2, num5));
			}
			if (num5 != num4)
			{
				((Control)BNP).Text = bS.a(num5, num, -1);
				C();
			}
		}
		return true;
	}

	protected override void A()
	{
		D();
		if (((Control)this).Parent != null)
		{
			((Control)this).Parent.SuspendLayout();
		}
		A(iC, BWW, BWw, iB, ib, BNQ, BNq);
		if (((Control)this).Parent != null)
		{
			((Control)this).Parent.ResumeLayout(true);
		}
	}

	protected override void B()
	{
		Ck ck = BM.aM();
		ck?.A(ic.C());
		if (BWW)
		{
			ic.A(BWw, true);
		}
		else
		{
			ic.I(true);
		}
		ck?.B();
		BM.A(ic.C());
	}

	private void D()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		try
		{
			((Control)BNP).GotFocus -= new EventHandler(b);
			((Control)BNP).KeyDown -= new KeyEventHandler(A);
			((Control)BNP).KeyPress -= new KeyPressEventHandler(A);
			((Control)BNP).Leave -= new EventHandler(D);
			((Control)this).MouseEnter -= new EventHandler(A);
			((Control)BNP).MouseEnter -= new EventHandler(A);
			((Control)iG).MouseEnter -= new EventHandler(A);
			((Control)BNP).MouseLeave -= new EventHandler(a);
			((Control)iG).Click -= new EventHandler(B);
			ic.a(new EventHandler(d));
			((SettingOrSpecialObject)ic).a(new EventHandler(c));
			if (iE != null)
			{
				((SettingOrSpecialObject)iE).a(new EventHandler(((aj)this).B));
			}
			if (ie != null)
			{
				ie.a(new EventHandler(((aj)this).b));
			}
			BM.QQ.b(new EventHandler(C));
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		D();
		if (BM.SR == iG)
		{
			BM.SR = null;
		}
		try
		{
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
