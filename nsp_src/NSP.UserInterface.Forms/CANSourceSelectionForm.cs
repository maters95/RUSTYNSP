using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using NSP.SettingsFramework;
using a;
using b;

namespace NSP.UserInterface.Forms;

public class CANSourceSelectionForm : Form
{
	[CompilerGenerated]
	private ISignalSource MC;

	private IContainer Mc;

	private RadioButton MD;

	private RadioButton Md;

	private RadioButton ME;

	private ThemedTextBox Me;

	private ThemedTextBox MF;

	private ThemedTextBox Mf;

	private ThemedTextBox MG;

	private Label Mg;

	private Label MH;

	private Label Mh;

	private ThemedButton MI;

	private ThemedButton Mi;

	private aI MJ;

	public ISignalSource Source
	{
		[CompilerGenerated]
		get
		{
			return MC;
		}
		[CompilerGenerated]
		set
		{
			MC = value;
		}
	}

	public CANSourceSelectionForm()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		A();
		((Control)this).BackColor = BM.tg;
		((Control)MD).ForeColor = BM.te;
		((Control)Md).ForeColor = BM.te;
		((Control)ME).ForeColor = BM.te;
		((Control)Me).BackColor = BM.to;
		((Control)Me).ForeColor = BM.te;
		MJ.A(BM.Qz);
		((Control)MJ).Enabled = true;
		((Control)Me).Enabled = false;
		((Form)this).Shown += new EventHandler(D);
	}

	private void A(object P_0, EventArgs P_1)
	{
		((Form)this).DialogResult = (DialogResult)2;
		if (MD.Checked)
		{
			if (MJ.a() != 0)
			{
				Setting setting = BM.Qz.A(MJ.a());
				if (setting != null)
				{
					Source = new ChannelSource(setting);
					((Form)this).DialogResult = (DialogResult)1;
				}
			}
		}
		else if (ME.Checked)
		{
			Source = new CounterSource();
			((Form)this).DialogResult = (DialogResult)1;
		}
		else
		{
			string text = ((Control)Me).Text;
			int val2 = default(int);
			if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dI(), (StringComparison)5))
			{
				int val = bS.A(text, 102);
				Source = new FixedSource(val);
				((Form)this).DialogResult = (DialogResult)1;
			}
			else if (int.TryParse(text, ref val2))
			{
				Source = new FixedSource(val2);
				((Form)this).DialogResult = (DialogResult)1;
			}
		}
		((Form)this).Close();
	}

	private void a(object P_0, EventArgs P_1)
	{
		((Form)this).DialogResult = (DialogResult)2;
		((Form)this).Close();
	}

	private void B(object P_0, EventArgs P_1)
	{
		A(null, null);
	}

	private void b(object P_0, EventArgs P_1)
	{
		((Control)MJ).Enabled = true;
		((Control)Me).Enabled = false;
	}

	private void C(object P_0, EventArgs P_1)
	{
		((Control)MJ).Enabled = false;
		((Control)Me).Enabled = true;
	}

	private void c(object P_0, EventArgs P_1)
	{
		((Control)MJ).Enabled = false;
		((Control)Me).Enabled = false;
	}

	private void D(object P_0, EventArgs P_1)
	{
		if (Source != null)
		{
			if (Source is ChannelSource channelSource)
			{
				MD.Checked = true;
				MJ.A(channelSource.Channel.A());
			}
			else if (Source is FixedSource fixedSource)
			{
				Md.Checked = true;
				((Control)Me).Text = fixedSource.Value.ToString();
			}
			else if (Source is CounterSource)
			{
				ME.Checked = true;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && Mc != null)
		{
			((System.IDisposable)Mc).Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void A()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		MD = new RadioButton();
		Md = new RadioButton();
		ME = new RadioButton();
		Me = new ThemedTextBox();
		MI = new ThemedButton();
		Mi = new ThemedButton();
		MJ = new aI();
		((Control)this).SuspendLayout();
		((Control)MD).AutoSize = true;
		((Control)MD).Location = new Point(17, 18);
		((Control)MD).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hQ();
		((Control)MD).Size = new Size(80, 23);
		((Control)MD).TabIndex = 0;
		MD.TabStop = true;
		((Control)MD).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hq();
		((ButtonBase)MD).UseVisualStyleBackColor = true;
		MD.CheckedChanged += new EventHandler(b);
		((Control)Md).AutoSize = true;
		((Control)Md).Location = new Point(17, 69);
		((Control)Md).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hR();
		((Control)Md).Size = new Size(98, 23);
		((Control)Md).TabIndex = 1;
		Md.TabStop = true;
		((Control)Md).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hr();
		((ButtonBase)Md).UseVisualStyleBackColor = true;
		Md.CheckedChanged += new EventHandler(C);
		((Control)ME).AutoSize = true;
		((Control)ME).Location = new Point(17, 120);
		((Control)ME).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hS();
		((Control)ME).Size = new Size(80, 23);
		((Control)ME).TabIndex = 2;
		ME.TabStop = true;
		((Control)ME).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hs();
		((ButtonBase)ME).UseVisualStyleBackColor = true;
		ME.CheckedChanged += new EventHandler(c);
		((Control)Me).Location = new Point(134, 69);
		((Control)Me).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hT();
		((Control)Me).Size = new Size(104, 26);
		((Control)Me).TabIndex = 4;
		((Control)MI).Location = new Point(232, 160);
		((Control)MI).MinimumSize = new Size(104, 40);
		((Control)MI).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ht();
		((Control)MI).Size = new Size(104, 40);
		((Control)MI).TabIndex = 5;
		((Control)MI).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
		((ButtonBase)MI).UseVisualStyleBackColor = true;
		((Control)MI).Click += new EventHandler(A);
		((Control)Mi).Location = new Point(342, 160);
		((Control)Mi).MinimumSize = new Size(104, 40);
		((Control)Mi).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hu();
		((Control)Mi).Size = new Size(104, 40);
		((Control)Mi).TabIndex = 6;
		((Control)Mi).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
		((ButtonBase)Mi).UseVisualStyleBackColor = true;
		((Control)Mi).Click += new EventHandler(a);
		((Control)MJ).AutoSize = true;
		((UserControl)MJ).AutoSizeMode = (AutoSizeMode)0;
		((Control)MJ).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)MJ).Location = new Point(120, 18);
		((Control)MJ).Margin = new Padding(4, 4, 4, 4);
		((Control)MJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hv();
		((Control)MJ).Size = new Size(285, 30);
		((Control)MJ).TabIndex = 7;
		MJ.A(new EventHandler(B));
		((Form)this).AcceptButton = (IButtonControl)(object)MI;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(8f, 19f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).CancelButton = (IButtonControl)(object)Mi;
		((Form)this).ClientSize = new Size(450, 210);
		((Control)this).Controls.Add((Control)(object)MJ);
		((Control)this).Controls.Add((Control)(object)Mi);
		((Control)this).Controls.Add((Control)(object)MI);
		((Control)this).Controls.Add((Control)(object)Me);
		((Control)this).Controls.Add((Control)(object)ME);
		((Control)this).Controls.Add((Control)(object)Md);
		((Control)this).Controls.Add((Control)(object)MD);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hW();
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hw();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
