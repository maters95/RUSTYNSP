using System;
using System.Drawing;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns4;
using ns7;

namespace ns5;

internal class Form64 : Form
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

	internal Form64(WiringPin wiringPin_0)
	{
		Shown += Form64_Shown;
		Form23.smethod_7(method_0);
		abe = wiringPin_0;
		Text = Class333.abb();
		BackColor = Form23.color_10;
		ForeColor = Form23.color_12;
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		StartPosition = FormStartPosition.CenterParent;
		ShowIcon = false;
		ShowInTaskbar = false;
		Color color = wiringPin_0.method_14();
		Color color2 = wiringPin_0.method_15();
		byte b = 1;
		while (b <= WiringPin.BCd.Length)
		{
			if (!(WiringPin.smethod_4(WiringPin.BCd[b - 1]) == color))
			{
				b++;
				continue;
			}
			abd = b;
			break;
		}
		byte b2 = 1;
		while (b2 <= WiringPin.BCd.Length)
		{
			if (!(WiringPin.smethod_4(WiringPin.BCd[b2 - 1]) == color2))
			{
				b2++;
				continue;
			}
			abE = b2;
			break;
		}
		Padding margin = new Padding(10, 2, 10, 2);
		abF.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
		abF.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
		abF.AutoScroll = false;
		abF.ColumnCount = 2;
		abF.RowCount = 2;
		abF.AutoSize = true;
		abg.BackColor = Color.Transparent;
		abg.Margin = margin;
		abg.Image = WiringPin.smethod_3(color, color2, wiringPin_0.Bbt, bool_1: false, bool_2: false);
		abF.Controls.Add(abg, 0, 0);
		abF.SetColumnSpan(abg, 2);
		abg.Dock = DockStyle.Fill;
		abg.SizeMode = PictureBoxSizeMode.CenterImage;
		abf.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
		abf.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
		abf.AutoScroll = false;
		abf.ColumnCount = 1;
		abf.RowCount = 1 + WiringPin.BCd.Length;
		abf.AutoSize = true;
		abG.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
		abG.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
		abG.AutoScroll = false;
		abG.ColumnCount = 1;
		abG.RowCount = 1 + WiringPin.BCd.Length;
		abG.AutoSize = true;
		Label control = new Label
		{
			Margin = margin,
			AutoSize = false,
			Width = 200,
			Height = 25,
			Text = Class333.abC()
		};
		abf.Controls.Add(control, 0, 0);
		Label control2 = new Label
		{
			Margin = margin,
			AutoSize = false,
			Width = 200,
			Height = 25,
			Text = Class333.abc()
		};
		abG.Controls.Add(control2, 0, 0);
		for (byte b3 = 1; b3 <= WiringPin.BCd.Length; b3++)
		{
			string string_ = WiringPin.BCd[b3 - 1];
			RadioButton radioButton = new RadioButton();
			radioButton.Margin = margin;
			radioButton.Padding = new Padding(radioButton.Padding.Left + 5, radioButton.Padding.Top, radioButton.Padding.Right, radioButton.Padding.Bottom);
			radioButton.BackColor = WiringPin.smethod_4(string_);
			radioButton.AutoSize = false;
			radioButton.Width = 200;
			radioButton.Height = 25;
			abf.Controls.Add(radioButton, 0, b3);
			radioButton.CheckedChanged += method_1;
			RadioButton radioButton2 = new RadioButton();
			radioButton2.Margin = margin;
			radioButton2.Padding = new Padding(radioButton2.Padding.Left + 5, radioButton2.Padding.Top, radioButton2.Padding.Right, radioButton2.Padding.Bottom);
			radioButton2.BackColor = WiringPin.smethod_4(string_);
			radioButton2.AutoSize = false;
			radioButton2.Width = 200;
			radioButton2.Height = 25;
			abG.Controls.Add(radioButton2, 0, b3);
			radioButton2.CheckedChanged += method_2;
		}
		abF.Controls.Add(abf, 0, 1);
		abF.Controls.Add(abG, 1, 1);
		Controls.Add(abF);
		ClientSize = new Size(abF.Width, abF.Height + 50);
		ThemedButton themedButton = new ThemedButton();
		themedButton.DialogResult = DialogResult.Cancel;
		themedButton.Text = Class333.smethod_823();
		themedButton.AutoSize = false;
		themedButton.Size = new Size(100, 30);
		themedButton.Location = new Point(ClientSize.Width - 10 - themedButton.Width, abF.Height + 10);
		Controls.Add(themedButton);
		ThemedButton themedButton2 = new ThemedButton();
		themedButton2.DialogResult = DialogResult.OK;
		themedButton2.Text = Class333.smethod_821();
		themedButton2.AutoSize = false;
		themedButton2.Size = new Size(100, 30);
		themedButton2.Location = new Point(themedButton.Left - 10 - themedButton2.Width, abF.Height + 10);
		Controls.Add(themedButton2);
		abH.Click += abH_Click;
		abH.Text = Class333.smethod_551();
		abH.AutoSize = false;
		abH.Size = new Size(120, 30);
		abH.Location = new Point(10, abF.Height + 10);
		Controls.Add(abH);
		CancelButton = themedButton;
		themedButton.Focus();
	}

	protected override void Dispose(bool disposing)
	{
		Shown -= Form64_Shown;
		Form23.smethod_8(method_0);
		foreach (Control control3 in abf.Controls)
		{
			if (control3 is RadioButton)
			{
				(control3 as RadioButton).CheckedChanged -= method_1;
			}
		}
		foreach (Control control4 in abG.Controls)
		{
			if (control4 is RadioButton)
			{
				(control4 as RadioButton).CheckedChanged -= method_2;
			}
		}
		abH.Click -= abH_Click;
		base.Dispose(disposing);
	}

	private void method_0(object sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
		Close();
	}

	private void Form64_Shown(object sender, EventArgs e)
	{
		if (abd > 0)
		{
			(abf.GetControlFromPosition(0, abd) as RadioButton).Checked = true;
		}
		if (abE > 0)
		{
			(abG.GetControlFromPosition(0, abE) as RadioButton).Checked = true;
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		if ((sender as RadioButton).Checked)
		{
			abd = (byte)abf.GetCellPosition(sender as RadioButton).Row;
			Color color_ = WiringPin.smethod_4(WiringPin.BCd[abd - 1]);
			Color color_2 = WiringPin.smethod_4(WiringPin.BCd[abE - 1]);
			Image? image = abg.Image;
			abg.Image = WiringPin.smethod_3(color_, color_2, abe.Bbt, bool_1: false, bool_2: false);
			image.Dispose();
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		if ((sender as RadioButton).Checked)
		{
			abE = (byte)abG.GetCellPosition(sender as RadioButton).Row;
			Color color_ = WiringPin.smethod_4(WiringPin.BCd[abd - 1]);
			Color color_2 = WiringPin.smethod_4(WiringPin.BCd[abE - 1]);
			Image? image = abg.Image;
			abg.Image = WiringPin.smethod_3(color_, color_2, abe.Bbt, bool_1: false, bool_2: false);
			image.Dispose();
		}
	}

	private void abH_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(abe.BbU) || string.IsNullOrEmpty(abe.Bbu))
		{
			return;
		}
		foreach (Control control3 in abf.Controls)
		{
			if (control3 is RadioButton && control3.BackColor == WiringPin.smethod_4(abe.BbU))
			{
				(control3 as RadioButton).Checked = true;
				break;
			}
		}
		foreach (Control control4 in abG.Controls)
		{
			if (control4 is RadioButton && control4.BackColor == WiringPin.smethod_4(abe.Bbu))
			{
				(control4 as RadioButton).Checked = true;
				break;
			}
		}
	}
}
