using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.Resources;

namespace NSP.UserInterface;

public class ThemedSearchBox : UserControl
{
	private PictureBox jZ = new PictureBox();

	private ThemedTextBox jz = new ThemedTextBox();

	private ThemedButton KA = new ThemedButton();

	private IContainer Ka;

	private TableLayoutPanel KB;

	public ThemedSearchBox()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		A();
		((Control)this).BackColor = BM.tg;
		((Control)KB).BackColor = BM.tg;
		((Control)KB).Padding = new Padding(2);
		((Control)KB).Margin = new Padding(2);
		((Control)jZ).BackColor = BM.tg;
		if (jZ.Image != null)
		{
			jZ.Image.Dispose();
		}
		jZ.Image = (Image)(object)O.A((Image)(object)GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		((Control)jz).BackColor = BM.to;
		((Control)jz).ForeColor = BM.te;
		((Control)jz).Font = new Font(Control.DefaultFont.FontFamily, ((Control)jz).Font.Size);
		((Control)jz).Dock = (DockStyle)5;
		((Control)jz).Height = ((Control)KB).Height - 2;
		((Control)jz).KeyUp += (KeyEventHandler)([CompilerGenerated] (object? s, KeyEventArgs P_1) =>
		{
			((Control)this).Text = ((Control)jz).Text;
		});
		((Control)KA).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Di();
		((Control)KA).Font = new Font(Control.DefaultFont.FontFamily, 8f, (FontStyle)1);
		((Control)KA).Click += (EventHandler)([CompilerGenerated] (object? s, EventArgs P_1) =>
		{
			((Control)jz).Text = string.Empty;
			((Control)this).Text = string.Empty;
		});
		KB.Controls.Add((Control)(object)jZ, 0, 0);
		KB.Controls.Add((Control)(object)jz, 1, 0);
		KB.Controls.Add((Control)(object)KA, 2, 0);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && Ka != null)
		{
			((System.IDisposable)Ka).Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void A()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		KB = new TableLayoutPanel();
		((Control)this).SuspendLayout();
		KB.ColumnCount = 3;
		KB.ColumnStyles.Add(new ColumnStyle((SizeType)1, 28f));
		KB.ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		KB.ColumnStyles.Add(new ColumnStyle((SizeType)1, 28f));
		((Control)KB).Dock = (DockStyle)5;
		((Control)KB).Location = new Point(0, 0);
		((Control)KB).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gx();
		KB.RowCount = 1;
		KB.RowStyles.Add(new RowStyle((SizeType)1, 30f));
		((Control)KB).Size = new Size(150, 30);
		((Control)KB).TabIndex = 0;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)KB);
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gA();
		((Control)this).Size = new Size(150, 30);
		((Control)this).ResumeLayout(false);
	}

	[CompilerGenerated]
	private void A(object? s, KeyEventArgs P_1)
	{
		((Control)this).Text = ((Control)jz).Text;
	}

	[CompilerGenerated]
	private void A(object? s, EventArgs P_1)
	{
		((Control)jz).Text = string.Empty;
		((Control)this).Text = string.Empty;
	}
}
