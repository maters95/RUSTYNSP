using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns3;
using ns4;
using ns6;
using ns7;

namespace ns1;

internal class Form7 : Form6
{
	[CompilerGenerated]
	private static EventHandler BPJ;

	private IContainer BPj;

	private PictureBox BPK;

	private ThemedTextBox BPk;

	private ThemedButton BPL;

	private Label BPl;

	private ThemedComboBox BPM;

	private Label BPm;

	private ThemedComboBox BPN;

	private ThemedButton BPn;

	private ThemedButton BPO;

	private ThemedButton BPo;

	private Label BPP;

	private ThemedComboBox BPp;

	private ThemedButton BPQ;

	private ThemedButton BPq;

	private System.Windows.Forms.Timer BPR;

	internal Form7(Class244 class244_1)
	{
		bool_0 = true;
		method_28();
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		class244_0 = class244_1;
		uint uint_ = (uint)class244_1.method_256();
		enum104_1 = PortFunction.smethod_12(uint_);
		enum105_1 = PortFunction.smethod_13(uint_);
		if (enum104_1 == Enum104.BAM)
		{
			byte_0 = 0;
			ushort_0 = PortFunction.smethod_15(uint_);
		}
		else
		{
			byte_0 = PortFunction.smethod_14(uint_);
			ushort_0 = 0;
		}
		BPK.BackColor = BackColor;
		if (BPK.Image != null)
		{
			BPK.Image.Dispose();
		}
		BPK.Image = Class25.smethod_0(GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		BPk.BackColor = Form23.color_32;
		BPk.ForeColor = Form23.color_12;
		BPk.method_0(method_26);
		if (Form23.framework_1.awC.Count != 0)
		{
			class185_0 = new Class185(this);
			class185_0.BorderStyle = BorderStyle.FixedSingle;
			class185_0.BackColor = Form23.color_15;
			class185_0.Left = 10;
			class185_0.Width = ClientRectangle.Width - 20;
			class185_0.Top = BPo.Bottom + 7;
			Controls.Add(class185_0);
		}
		class131_0.BorderStyle = BorderStyle.FixedSingle;
		class131_0.BackColor = Form23.color_15;
		class131_0.Left = 10;
		class131_0.Width = ClientRectangle.Width - 20;
		if (Form23.framework_1.awC.Count != 0)
		{
			class131_0.Top = class185_0.Top + class185_0.Height + 7;
		}
		else
		{
			class131_0.Top = BPo.Bottom + 7;
		}
		class131_0.Height = BPq.Top - 10 - class131_0.Top;
		Controls.Add(class131_0);
		BPM.Items.Add(Class333.BDm());
		Enum104[] array = PortFunction.smethod_5();
		foreach (Enum104 @enum in array)
		{
			BPM.Items.Add(PortFunction.smethod_2(@enum, Form23.framework_1));
		}
		BPM.SelectedIndex = 0;
		BPN.Items.Add(Class333.BDN());
		Enum105[] array2 = PortFunction.smethod_6();
		foreach (Enum105 enum2 in array2)
		{
			BPN.Items.Add(PortFunction.smethod_4(enum2));
		}
		BPN.SelectedIndex = 0;
		ComboBox.ObjectCollection items = BPp.Items;
		object[] items2 = new string[2]
		{
			Class333.BDn(),
			Class333.BDO()
		};
		items.AddRange(items2);
		BPp.SelectedIndex = (int)Form6.enum51_0;
		BPP.Visible = (BPp.Visible = Form23.framework_1.awe);
		Class1.smethod_12(method_5);
		Form23.smethod_30(method_5);
		Form23.smethod_7(method_27);
		vmethod_1();
		Form6.form6_0 = this;
		class280_0 = new Class280(Form23.framework_1);
		foreach (WiringPin item in Form23.framework_1.awc)
		{
			if (item.method_13())
			{
				hashSet_0.Add(Form23.framework_1.method_31(item.Bbx));
			}
		}
		foreach (Setting item2 in hashSet_0)
		{
			item2.method_264(method_16);
		}
		bool_1 = false;
	}

	private void BPn_Click(object sender, EventArgs e)
	{
		method_10();
	}

	private void BPO_Click(object sender, EventArgs e)
	{
		method_11();
	}

	private void BPo_Click(object sender, EventArgs e)
	{
		method_12();
	}

	private void BPM_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			method_13(BPM.SelectedIndex == 0, BPM.Text);
		}
	}

	private void BPN_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			method_14(BPN.SelectedIndex == 0, BPN.Text);
		}
	}

	private void BPp_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1 && BPp.SelectedIndex != -1)
		{
			method_17((Enum51)BPp.SelectedIndex);
		}
	}

	private void BPk_TextChanged(object sender, EventArgs e)
	{
		BPR.Stop();
		BPR.Start();
	}

	private void method_26(object sender, ThemedTextBox.EventArgs4 e)
	{
		BPR.Stop();
		BPR.Start();
	}

	private void BPR_Tick(object sender, EventArgs e)
	{
		BPR.Stop();
		vmethod_1();
	}

	private void BPL_Click(object sender, EventArgs e)
	{
		BPk.Text = string.Empty;
	}

	internal override string vmethod_0()
	{
		return BPk.Text;
	}

	protected override void vmethod_2(object sender, EventArgs e)
	{
		method_21(sender, (MouseEventArgs)e);
		BPq.PerformClick();
	}

	private void method_27(object sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
		Close();
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_3(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BPJ;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BPJ, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_4(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = BPJ;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref BPJ, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private void Form7_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form6.form6_0 = null;
		foreach (Control control3 in class131_0.Controls)
		{
			control3.MouseClick -= method_21;
			control3.DoubleClick -= vmethod_2;
			foreach (Control control4 in control3.Controls)
			{
				control4.MouseClick -= method_21;
				control4.DoubleClick -= vmethod_2;
				control4.MouseClick -= method_22;
			}
		}
		Class1.smethod_13(method_5);
		Form23.smethod_31(method_5);
		Form23.smethod_8(method_27);
		foreach (Label item in list_0)
		{
			SettingOrSpecialObject bOR = ((Class183)item.Tag).BOR;
			for (int i = 0; i < bOR.method_12().method_1().Count; i++)
			{
				bOR.method_12().method_1()[i].method_265(method_6);
			}
		}
		foreach (Setting item2 in hashSet_0)
		{
			item2.method_265(method_16);
		}
		hashSet_0.Clear();
		if (stopwatch_0.IsRunning)
		{
			stopwatch_0.Stop();
		}
		if (BPJ != null)
		{
			BPJ(this, null);
		}
		if (DialogResult != DialogResult.OK)
		{
			return;
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_2(class244_0.method_64());
		List<Setting> list = new List<Setting>();
		PortFunction.smethod_31(class244_0, list, bool_0: false);
		List<Table> list2 = new List<Table>();
		PortFunction.smethod_34(class244_0, list2, bool_0: false);
		if (enum104_1 != Enum104.BAM)
		{
			int num = class244_0.method_256();
			int num2 = (int)PortFunction.smethod_16(enum104_1, enum105_1, byte_0);
			class244_0.method_272(num2, bool_0: true);
			if (num == 0)
			{
				class244_0.method_294();
			}
		}
		else
		{
			class244_0.method_272((int)PortFunction.smethod_17(enum104_1, enum105_1, ushort_0), bool_0: true);
		}
		if (PortFunction.smethod_38(Form23.framework_1, bool_0: true, enum104_1, enum105_1, byte_0, ushort_0) == 1)
		{
			PortFunction.smethod_26(class244_0, list, list2);
		}
		@class?.method_4();
		Form23.smethod_74(class244_0.method_64());
	}

	private void Form7_Resize(object sender, EventArgs e)
	{
		BPq.Left = Width - 235;
		BPQ.Left = BPq.Right + 9;
		ThemedButton bPq = BPq;
		int top = (BPQ.Top = Height - 79);
		bPq.Top = top;
		BPP.Top = Height - 72;
		BPp.Top = Height - 76;
		if (class185_0 != null)
		{
			class185_0.Width = ClientRectangle.Width - 20;
		}
		class131_0.Width = ClientRectangle.Width - 20;
		class131_0.Height = BPq.Top - 10 - class131_0.Top;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && BPj != null)
		{
			BPj.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_28()
	{
		BPj = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form7));
		BPK = new PictureBox();
		BPk = new ThemedTextBox();
		BPL = new ThemedButton();
		BPl = new Label();
		BPM = new ThemedComboBox();
		BPm = new Label();
		BPN = new ThemedComboBox();
		BPn = new ThemedButton();
		BPO = new ThemedButton();
		BPo = new ThemedButton();
		BPP = new Label();
		BPp = new ThemedComboBox();
		BPQ = new ThemedButton();
		BPq = new ThemedButton();
		BPR = new System.Windows.Forms.Timer(BPj);
		((ISupportInitialize)BPK).BeginInit();
		SuspendLayout();
		BPK.Image = (Image)componentResourceManager.GetObject(Class333.BDo());
		BPK.Location = new Point(7, 7);
		BPK.Name = Class333.smethod_591();
		BPK.Size = new Size(24, 24);
		BPK.TabIndex = 28;
		BPK.TabStop = false;
		BPk.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPk.Location = new Point(36, 8);
		BPk.Name = Class333.smethod_590();
		BPk.Size = new Size(137, 22);
		BPk.TabIndex = 0;
		BPk.TextChanged += BPk_TextChanged;
		BPL.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		BPL.Location = new Point(175, 7);
		BPL.Name = Class333.smethod_592();
		BPL.Size = new Size(22, 24);
		BPL.TabIndex = 1;
		BPL.Text = Class333.smethod_330();
		BPL.UseVisualStyleBackColor = true;
		BPL.Click += BPL_Click;
		BPl.AutoSize = true;
		BPl.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPl.Location = new Point(211, 11);
		BPl.Name = Class333.BDP();
		BPl.Size = new Size(48, 13);
		BPl.TabIndex = 27;
		BPl.Text = Class333.BDp();
		BPM.DrawMode = DrawMode.OwnerDrawFixed;
		BPM.DropDownStyle = ComboBoxStyle.DropDownList;
		BPM.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPM.FormattingEnabled = true;
		BPM.Location = new Point(262, 7);
		BPM.MaxDropDownItems = 50;
		BPM.Name = Class333.BDQ();
		BPM.Size = new Size(206, 23);
		BPM.TabIndex = 2;
		BPM.SelectedIndexChanged += BPM_SelectedIndexChanged;
		BPm.AutoSize = true;
		BPm.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPm.Location = new Point(482, 11);
		BPm.Name = Class333.BDq();
		BPm.Size = new Size(101, 13);
		BPm.TabIndex = 26;
		BPm.Text = Class333.BDR();
		BPN.DrawMode = DrawMode.OwnerDrawFixed;
		BPN.DropDownStyle = ComboBoxStyle.DropDownList;
		BPN.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPN.FormattingEnabled = true;
		BPN.Location = new Point(586, 7);
		BPN.MaxDropDownItems = 50;
		BPN.Name = Class333.BDr();
		BPN.Size = new Size(194, 23);
		BPN.TabIndex = 3;
		BPN.SelectedIndexChanged += BPN_SelectedIndexChanged;
		BPn.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPn.Location = new Point(836, 5);
		BPn.Name = Class333.BDS();
		BPn.Size = new Size(120, 25);
		BPn.TabIndex = 4;
		BPn.Text = Class333.BDs();
		BPn.UseVisualStyleBackColor = true;
		BPn.Click += BPn_Click;
		BPO.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPO.Location = new Point(958, 5);
		BPO.Name = Class333.BDT();
		BPO.Size = new Size(120, 25);
		BPO.TabIndex = 5;
		BPO.Text = Class333.BDt();
		BPO.UseVisualStyleBackColor = true;
		BPO.Click += BPO_Click;
		BPo.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPo.Location = new Point(1080, 5);
		BPo.Name = Class333.BDU();
		BPo.Size = new Size(120, 25);
		BPo.TabIndex = 6;
		BPo.Text = Class333.BDu();
		BPo.UseVisualStyleBackColor = true;
		BPo.Click += BPo_Click;
		BPP.AutoSize = true;
		BPP.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPP.Location = new Point(7, 570);
		BPP.Name = Class333.BDV();
		BPP.Size = new Size(60, 13);
		BPP.TabIndex = 26;
		BPP.Text = Class333.BDv();
		BPp.DrawMode = DrawMode.OwnerDrawFixed;
		BPp.DropDownStyle = ComboBoxStyle.DropDownList;
		BPp.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPp.FormattingEnabled = true;
		BPp.Location = new Point(55, 566);
		BPp.MaxDropDownItems = 2;
		BPp.Name = Class333.BDW();
		BPp.Size = new Size(180, 23);
		BPp.TabIndex = 7;
		BPp.SelectedIndexChanged += BPp_SelectedIndexChanged;
		BPQ.DialogResult = DialogResult.Cancel;
		BPQ.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPQ.Location = new Point(1135, 563);
		BPQ.Name = Class333.smethod_830();
		BPQ.Size = new Size(100, 30);
		BPQ.TabIndex = 9;
		BPQ.Text = Class333.smethod_823();
		BPQ.UseVisualStyleBackColor = true;
		BPq.DialogResult = DialogResult.OK;
		BPq.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BPq.Location = new Point(1026, 563);
		BPq.Name = Class333.smethod_829();
		BPq.Size = new Size(100, 30);
		BPq.TabIndex = 8;
		BPq.Text = Class333.smethod_821();
		BPq.UseVisualStyleBackColor = true;
		BPR.Interval = 400;
		BPR.Tick += BPR_Tick;
		AcceptButton = BPq;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = BPQ;
		ClientSize = new Size(1245, 604);
		Controls.Add(BPK);
		Controls.Add(BPk);
		Controls.Add(BPL);
		Controls.Add(BPl);
		Controls.Add(BPM);
		Controls.Add(BPm);
		Controls.Add(BPN);
		Controls.Add(BPn);
		Controls.Add(BPO);
		Controls.Add(BPo);
		Controls.Add(BPP);
		Controls.Add(BPp);
		Controls.Add(BPQ);
		Controls.Add(BPq);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MinimizeBox = false;
		Name = Class333.BDw();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.BDX();
		FormClosing += Form7_FormClosing;
		Resize += Form7_Resize;
		((ISupportInitialize)BPK).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
