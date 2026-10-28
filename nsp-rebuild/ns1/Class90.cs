using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns2;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns1;

internal class Class90 : MovableResizablePanel
{
	private enum Enum29
	{
		Buh,
		BuI,
		Bui,
		BuJ
	}

	private delegate void Delegate16(object sender, EventArgs e);

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

	private Class131 Bil = new Class131();

	private Timer BiM = new Timer();

	[CompilerGenerated]
	private readonly Class280 Bim;

	[SpecialName]
	[CompilerGenerated]
	internal Class280 method_12()
	{
		return Bim;
	}

	internal Class90(Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: false)
	{
		Bih = true;
		Big = framework_0;
		BiH = framework_1;
		BiI.Text = Class333.BAw();
		BiI.Font = new Font(BiI.Font.FontFamily, BiI.Font.Size, FontStyle.Bold);
		BiI.AutoSize = true;
		BiI.ForeColor = Form23.color_12;
		if (Bii.Image != null)
		{
			Bii.Image.Dispose();
		}
		Bii.Image = Class25.smethod_0(GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		Bii.Width = 24;
		Bii.Height = 24;
		BiJ.TextChanged += BiJ_TextChanged;
		BiJ.Width = 220;
		BiJ.Text = BiK;
		BiJ.BackColor = Form23.color_32;
		BiJ.ForeColor = Form23.color_12;
		BiJ.method_0(method_24);
		Bij.Click += Bij_Click;
		Bij.Text = Class333.smethod_330();
		Bij.Font = new Font(Bij.Font.FontFamily, 8f, FontStyle.Bold);
		Bij.Width = 22;
		Bik.SelectedIndexChanged += Bik_SelectedIndexChanged;
		Bik.Width = 200;
		Bik.DropDownStyle = ComboBoxStyle.DropDownList;
		Bik.Items.Add(Class333.BAX());
		Bik.Items.Add(Class333.BAx());
		Bik.Items.Add(Class333.BAY());
		Bik.Items.Add(Class333.BAy());
		Bik.SelectedIndex = BiL;
		Bil.BorderStyle = BorderStyle.FixedSingle;
		BiM.Interval = 400;
		BiM.Tick += BiM_Tick;
		Form23.form23_0.method_9(method_14);
		Bim = new Class280(framework_0);
		Bih = false;
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			BiJ.TextChanged -= BiJ_TextChanged;
			Bij.Click -= Bij_Click;
			Bik.SelectedIndexChanged -= Bik_SelectedIndexChanged;
			BiJ.method_1(method_24);
			BiM.Tick -= BiM_Tick;
			BiM.Dispose();
			foreach (Control control in Bil.Controls)
			{
				if (control is Class148)
				{
					(control as Class148).CheckedChanged -= method_15;
					Big.method_31((int)control.Tag).method_265(method_16);
				}
				else if (control is LinkLabel)
				{
					(control as LinkLabel).Click -= method_17;
				}
			}
			Form23.form23_0.method_10(method_14);
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	[SpecialName]
	internal ThemedTextBox method_13()
	{
		return BiJ;
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		if (!resizingOnly)
		{
			Bil.SuspendLayout();
			while (Bil.Controls.Count != 0)
			{
				Class30.smethod_0(Bil.Controls[0]);
			}
			Bil.ResumeLayout(performLayout: true);
			Controls.Clear();
			method_22(bool_0: true);
		}
	}

	private void method_14(object sender, EventArgs e)
	{
		method_20();
	}

	private void method_15(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !Big.method_4())
		{
			return;
		}
		Class148 @class = sender as Class148;
		Setting setting = Big.method_31((int)@class.Tag);
		if (!Form23.bool_2)
		{
			if (@class.Checked)
			{
				Setting setting_ = null;
				MenuNode menuNode_ = null;
				string text = setting.method_47();
				if (text == null)
				{
					if (setting.method_6() != null && setting.method_6().method_45() != null)
					{
						text = setting.method_6().method_45().method_64();
						if (text != null)
						{
							menuNode_ = setting.method_6().method_45();
						}
						else if (setting.method_152() != null)
						{
							text = setting.method_152().method_64();
							if (text != null)
							{
								menuNode_ = setting.method_152();
							}
						}
					}
				}
				else
				{
					setting_ = setting;
				}
				if (text != null && !Form13.smethod_0(setting_, menuNode_))
				{
					Form13 form = new Form13(text, setting_, menuNode_);
					if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
					{
						method_12().method_2(setting.method_64());
						if (setting.method_64() == 10195 && setting.method_102().Count == 3)
						{
							setting.method_272(2, bool_0: true);
						}
						else
						{
							setting.method_272(1, bool_0: true);
						}
					}
					else
					{
						@class.Checked = false;
					}
					form.Dispose();
				}
				else
				{
					method_12().method_2(setting.method_64());
					if (setting.method_64() == 10195 && setting.method_102().Count == 3)
					{
						setting.method_272(2, bool_0: true);
					}
					else
					{
						setting.method_272(1, bool_0: true);
					}
				}
				if (@class.Checked)
				{
					if (setting.method_6() != null)
					{
						PortFunction.smethod_20(setting.method_6(), bool_0: false);
					}
					method_12().method_4();
				}
			}
			else
			{
				method_12().method_2(setting.method_64());
				setting.method_272(0, bool_0: true);
				method_12().method_4();
			}
		}
		Form23.smethod_74(setting.method_64());
	}

	private void method_16(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate16 method = method_16;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		Setting setting = sender as Setting;
		foreach (Control control in Bil.Controls)
		{
			if (!(control is Class148))
			{
				continue;
			}
			Class148 @class = control as Class148;
			if ((int)@class.Tag != setting.method_64())
			{
				continue;
			}
			if (setting.method_64() == 10195)
			{
				if (@class.Checked != (setting.method_256() != 0))
				{
					@class.Checked = setting.method_256() != 0;
				}
			}
			else if (@class.Checked != (setting.method_256() == 1))
			{
				@class.Checked = setting.method_256() == 1;
			}
			break;
		}
	}

	private void method_17(object sender, EventArgs e)
	{
		Class148 @class = (sender as LinkLabel).Tag as Class148;
		Setting setting = Big.method_31((int)@class.Tag);
		TreeNode treeNode = Form23.form23_0.control4_0.method_63(Form23.form23_0.control4_0.method_0().method_2(), setting.method_69(), bool_7: false);
		if (treeNode != null)
		{
			Form23.form23_0.control4_0.method_0().method_4(treeNode);
		}
	}

	private List<Setting> method_18()
	{
		List<Setting> list = new List<Setting>();
		for (int i = 0; i < Big.aWZ.Count; i++)
		{
			Setting setting = Big.method_31(Big.aWZ[i]);
			if (setting == null || setting.method_219())
			{
				continue;
			}
			string text = null;
			text = ((setting.method_6() == null || string.IsNullOrEmpty(setting.method_6().method_60(Enum96.aYt))) ? setting.method_60(Enum96.aYt) : setting.method_6().method_60(Enum96.aYt));
			string text2 = text.ToLower();
			bool flag = false;
			for (int j = 0; j < list.Count; j++)
			{
				Setting setting2 = list[j];
				string text3 = null;
				text3 = ((setting2.method_6() == null || string.IsNullOrEmpty(setting2.method_6().method_60(Enum96.aYt))) ? setting2.method_60(Enum96.aYt) : setting2.method_6().method_60(Enum96.aYt));
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
							list.Insert(j, setting);
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
				list.Add(setting);
			}
		}
		return list;
	}

	internal bool method_19()
	{
		return Bik.SelectedIndex == 0;
	}

	private void method_20()
	{
		foreach (Control control3 in Bil.Controls)
		{
			if (!(control3 is Class148))
			{
				continue;
			}
			Class148 @class = control3 as Class148;
			Setting setting = Big.method_31((int)@class.Tag);
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				Setting setting2 = null;
				if (BiH != null)
				{
					setting2 = BiH.method_31((int)@class.Tag);
				}
				if (setting2 != null)
				{
					setting = setting2;
				}
				@class.Enabled = false;
				@class.bool_0 = true;
			}
			else
			{
				@class.Enabled = true;
				@class.bool_0 = false;
			}
			if (setting.method_64() == 10195)
			{
				if (@class.Checked != (setting.method_256() != 0))
				{
					@class.Checked = !@class.Checked;
				}
			}
			else if (@class.Checked != (setting.method_256() == 1))
			{
				@class.Checked = !@class.Checked;
			}
		}
		foreach (Control control4 in Bil.Controls)
		{
			if (!(control4 is LinkLabel))
			{
				continue;
			}
			LinkLabel linkLabel = control4 as LinkLabel;
			Class148 class2 = linkLabel.Tag as Class148;
			if (class2.Checked)
			{
				linkLabel.LinkBehavior = LinkBehavior.AlwaysUnderline;
			}
			else
			{
				linkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
			}
			Setting setting3 = Big.method_31((int)class2.Tag);
			if (setting3.method_35() && !setting3.method_122())
			{
				switch (setting3.method_124())
				{
				default:
					linkLabel.LinkColor = Form23.color_7;
					break;
				case IllegalitySeverityLevel.Error:
					linkLabel.LinkColor = Form23.color_7;
					break;
				case IllegalitySeverityLevel.Warning:
					linkLabel.LinkColor = Color.Orange;
					break;
				case IllegalitySeverityLevel.ErrorIfOnline:
					if (Form23.smethod_28(Big.aXc, bool_53: true))
					{
						linkLabel.LinkColor = Form23.color_7;
					}
					else
					{
						linkLabel.LinkColor = Color.Orange;
					}
					break;
				}
			}
			else
			{
				linkLabel.BackColor = BackColor;
				Setting setting4 = null;
				if (BiH != null)
				{
					setting4 = BiH.method_31(setting3.method_64());
				}
				if (setting4 != null && !setting3.method_282(setting4))
				{
					linkLabel.LinkColor = Form23.color_9;
				}
				else if (!class2.Checked)
				{
					linkLabel.LinkColor = Form23.color_36;
				}
				else
				{
					linkLabel.LinkColor = Form23.color_13;
				}
			}
		}
	}

	private void method_21()
	{
		int num = 10;
		int num2 = 10;
		foreach (Setting item in method_18())
		{
			Setting setting = null;
			if (BiH != null)
			{
				setting = BiH.method_31(item.method_64());
			}
			bool flag;
			bool flag2;
			if (Form23.enum60_0 == Form23.Enum60.BpG && setting != null)
			{
				flag = ((setting.method_64() != 10195) ? (setting.method_256() == 1) : (setting.method_256() != 0));
				flag2 = setting.method_35() && !item.method_122();
			}
			else
			{
				flag = ((item.method_64() != 10195) ? (item.method_256() == 1) : (item.method_256() != 0));
				flag2 = item.method_35() && !item.method_122();
			}
			if (item.method_219() || (Bik.SelectedIndex != 0 && !((Bik.SelectedIndex == 1) & flag) && (Bik.SelectedIndex != 2 || flag) && !((Bik.SelectedIndex == 3) & flag2)) || (Big.method_2() && Big.method_3() && item.method_96()) || !method_23(item))
			{
				continue;
			}
			string text = null;
			if (item.method_6() != null && !string.IsNullOrEmpty(item.method_6().method_60(Enum96.aYt)))
			{
				text = item.method_6().method_60(Enum96.aYt);
				string text2 = item.method_6().method_18();
				if (!string.IsNullOrWhiteSpace(text2))
				{
					text = text2 + Class333.smethod_497() + text + Class333.smethod_9();
				}
			}
			else
			{
				text = item.method_60(Enum96.aYt);
			}
			Class148 @class = new Class148();
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				@class.bool_0 = true;
				@class.Enabled = false;
			}
			else
			{
				@class.Enabled = Big.method_4();
			}
			LinkLabel linkLabel = new LinkLabel();
			@class.AutoSize = false;
			linkLabel.AutoSize = false;
			linkLabel.Text = text;
			@class.Text = string.Empty;
			@class.Checked = flag;
			if (@class.Checked)
			{
				linkLabel.LinkBehavior = LinkBehavior.AlwaysUnderline;
			}
			else
			{
				linkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
			}
			@class.Left = num;
			linkLabel.Left = num + 17;
			@class.Top = num2;
			linkLabel.Top = num2 + 1;
			@class.Width = 17;
			linkLabel.Width = 203;
			@class.Height = (int)((float)@class.Height * 0.75f);
			linkLabel.Height = @class.Height;
			@class.Tag = item.method_64();
			linkLabel.Tag = @class;
			@class.CheckedChanged += method_15;
			item.method_264(method_16);
			linkLabel.Click += method_17;
			if (flag2)
			{
				switch (item.method_124())
				{
				default:
					linkLabel.LinkColor = Form23.color_7;
					break;
				case IllegalitySeverityLevel.Error:
					linkLabel.LinkColor = Form23.color_7;
					break;
				case IllegalitySeverityLevel.Warning:
					linkLabel.LinkColor = Color.Orange;
					break;
				case IllegalitySeverityLevel.ErrorIfOnline:
					if (Form23.smethod_28(Big.aXc, bool_53: true))
					{
						linkLabel.LinkColor = Form23.color_7;
					}
					else
					{
						linkLabel.LinkColor = Color.Orange;
					}
					break;
				}
			}
			else
			{
				Color backColor = (linkLabel.BackColor = BackColor);
				@class.BackColor = backColor;
				Setting setting2 = null;
				if (BiH != null)
				{
					setting2 = BiH.method_31(item.method_64());
				}
				if (setting2 != null && !item.method_282(setting2))
				{
					linkLabel.LinkColor = Form23.color_9;
				}
				else if (!@class.Checked)
				{
					linkLabel.LinkColor = Form23.color_36;
				}
				else
				{
					linkLabel.LinkColor = Form23.color_13;
				}
			}
			Bil.Controls.Add(@class);
			Bil.Controls.Add(linkLabel);
			if (@class.Bottom + @class.Height > Bil.Height - 10)
			{
				num += 220;
				num2 = 10;
			}
			else
			{
				num2 = @class.Bottom;
			}
		}
	}

	internal void method_22(bool bool_0)
	{
		if (bool_0)
		{
			BiI.Left = 10;
			BiI.Top = 10;
			Controls.Add(BiI);
			Bii.Left = BiI.Right + 40;
			Bii.Top = 6;
			Controls.Add(Bii);
			BiJ.Left = Bii.Right + 1;
			BiJ.Top = 6;
			Controls.Add(BiJ);
			Bij.Left = BiJ.Right + 3;
			Bij.Top = BiJ.Top - 1;
			Bij.Height = BiJ.Height + 2;
			Controls.Add(Bij);
			Bik.Left = Bij.Right + 50;
			Bik.Top = 5;
			Controls.Add(Bik);
			Bil.SuspendLayout();
			Bil.Left = 10;
			Bil.Width = Width - 20;
			Bil.Top = 33;
			Bil.Height = Height - 10 - Bil.Top;
			method_21();
			Bil.ResumeLayout(performLayout: true);
			Controls.Add(Bil);
		}
		else
		{
			method_20();
		}
	}

	private bool method_23(Setting setting_0)
	{
		string text = null;
		text = ((setting_0.method_6() == null || string.IsNullOrEmpty(setting_0.method_6().method_60(Enum96.aYt))) ? setting_0.method_60(Enum96.aYt) : setting_0.method_6().method_60(Enum96.aYt));
		string text2 = null;
		if (setting_0.method_6() != null && !string.IsNullOrEmpty(setting_0.method_6().method_60(Enum96.aYT)))
		{
			text2 = setting_0.method_6().method_60(Enum96.aYT);
		}
		string text3 = null;
		if (!string.IsNullOrEmpty(setting_0.method_60(Enum96.aYT)))
		{
			text3 = setting_0.method_60(Enum96.aYT);
		}
		string text4 = null;
		if (setting_0.method_6() != null && !string.IsNullOrEmpty(setting_0.method_6().method_60(Enum96.aYu)))
		{
			text4 = setting_0.method_6().method_60(Enum96.aYu);
		}
		string text5 = null;
		if (!string.IsNullOrEmpty(setting_0.method_60(Enum96.aYu)))
		{
			text3 = setting_0.method_60(Enum96.aYu);
		}
		string text6 = string.Empty;
		if (setting_0.method_6() != null)
		{
			text6 = setting_0.method_6().method_18();
		}
		bool flag = true;
		if (BiJ.Text != string.Empty)
		{
			flag = false;
			string value = BiJ.Text.ToLower();
			if (!string.IsNullOrEmpty(text))
			{
				string text7 = text.ToLower();
				flag = flag || text7.Contains(value);
			}
			if (!string.IsNullOrEmpty(text2))
			{
				string text8 = text2.ToLower();
				flag = flag || text8.Contains(value);
			}
			if (!string.IsNullOrEmpty(text3))
			{
				string text9 = text3.ToLower();
				flag = flag || text9.Contains(value);
			}
			if (!string.IsNullOrEmpty(text4))
			{
				string text10 = text4.ToLower();
				flag = flag || text10.Contains(value);
			}
			if (!string.IsNullOrEmpty(text5))
			{
				string text11 = text5.ToLower();
				flag = flag || text11.Contains(value);
			}
			if (!string.IsNullOrWhiteSpace(text6))
			{
				string text12 = text6.ToLower();
				flag = flag || text12.Contains(value);
			}
			if (setting_0.method_6() != null)
			{
				foreach (string item in setting_0.method_6().method_23())
				{
					string text13 = item.ToLower();
					flag = flag || text13.Contains(value);
				}
			}
			foreach (string item2 in setting_0.method_23())
			{
				string text14 = item2.ToLower();
				flag = flag || text14.Contains(value);
			}
		}
		return flag;
	}

	private void Bij_Click(object sender, EventArgs e)
	{
		BiJ.Text = string.Empty;
	}

	private void BiJ_TextChanged(object sender, EventArgs e)
	{
		if (!Bih)
		{
			BiK = BiJ.Text;
			BiM.Stop();
			BiM.Start();
		}
	}

	private void method_24(object sender, ThemedTextBox.EventArgs4 e)
	{
		if (!Bih)
		{
			BiK = BiJ.Text;
			BiM.Stop();
			BiM.Start();
		}
	}

	private void BiM_Tick(object sender, EventArgs e)
	{
		BiM.Stop();
		Bil.AutoScrollPosition = new Point(0, 0);
		Bil.SuspendLayout();
		while (Bil.Controls.Count != 0)
		{
			Class30.smethod_0(Bil.Controls[0]);
		}
		method_21();
		Bil.ResumeLayout(performLayout: true);
	}

	private void Bik_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!Bih)
		{
			BiL = Bik.SelectedIndex;
			BiM_Tick(null, null);
		}
	}
}
