using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using NSP.UserInterface;
using ns2;
using ns4;
using ns7;

namespace ns5;

internal class Form54 : Form
{
	private const int aAG = 28;

	private const int aAg = 70;

	private const int aAH = 10;

	private const int aAh = 34;

	private const int aAI = 50;

	private const int aAi = 40;

	private const int aAJ = 600;

	private ThemedButton aAj = new ThemedButton();

	private ThemedButton aAK = new ThemedButton();

	private ThemedButton aAk = new ThemedButton();

	private MessageBoxDefaultButton aAL;

	private IContainer aAl;

	internal Form54(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, MessageBoxDefaultButton messageBoxDefaultButton_0, string[] string_2)
	{
		method_0();
		BackColor = Form23.color_10;
		ForeColor = Form23.color_12;
		if (string_0.Length > 60000)
		{
			string_0 = string_0.Substring(0, 60000) + Class333.aAU();
		}
		Label label = new Label
		{
			Text = string_0
		};
		int width = TextRenderer.MeasureText(string_0, label.Font).Width;
		if (messageBoxIcon_0 != MessageBoxIcon.None)
		{
			if ((float)width * 1.5f < (float)(ClientSize.Width - 50 - 10))
			{
				ClientSize = new Size((int)((float)width * 1.5f) + 50 + 10, ClientSize.Height);
			}
		}
		else if ((float)width * 1.5f < (float)(ClientSize.Width - 20))
		{
			ClientSize = new Size((int)((float)width * 1.5f) + 20, ClientSize.Height);
		}
		label.TextAlign = ContentAlignment.MiddleLeft;
		label.BackColor = BackColor;
		label.ForeColor = Form23.color_12;
		label.Left = ((messageBoxIcon_0 != MessageBoxIcon.None) ? 50 : 10);
		label.Top = 10;
		int num = ((messageBoxIcon_0 != MessageBoxIcon.None) ? (ClientSize.Width - 50 - 10) : (ClientSize.Width - 20));
		label.MinimumSize = new Size(num, 40);
		label.MaximumSize = new Size(num, int.MaxValue);
		label.AutoSize = true;
		int height = TextRenderer.MeasureText(string_0, label.Font, new Size(label.Width, -1)).Height;
		if (height > 600)
		{
			Class131 @class = new Class131
			{
				BackColor = BackColor,
				Width = label.Width,
				Height = 600,
				Left = label.Left,
				Top = label.Top
			};
			label.Left = 0;
			label.Top = 0;
			label.MinimumSize = new Size(num - 20, 40);
			label.MaximumSize = new Size(num - 20, int.MaxValue);
			@class.Controls.Add(label);
			Controls.Add(@class);
			ClientSize = new Size(ClientSize.Width, 658);
		}
		else
		{
			Controls.Add(label);
			ClientSize = new Size(ClientSize.Width, 10 + label.Height + 10 + 28 + 10);
		}
		Text = string_1;
		if (messageBoxIcon_0 != MessageBoxIcon.None)
		{
			PictureBox pictureBox = new PictureBox
			{
				BackColor = BackColor,
				Width = 34,
				Height = 34,
				Left = 10
			};
			if (height > 600)
			{
				pictureBox.Top = 310 - pictureBox.Height / 2;
			}
			else
			{
				pictureBox.Top = 10 + label.Height / 2 - pictureBox.Height / 2;
			}
			pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
			if (messageBoxIcon_0 != MessageBoxIcon.Hand && messageBoxIcon_0 != MessageBoxIcon.Hand && messageBoxIcon_0 != MessageBoxIcon.Hand)
			{
				if (messageBoxIcon_0 == MessageBoxIcon.Question)
				{
					pictureBox.Image = SystemIcons.Question.ToBitmap();
				}
				else if (messageBoxIcon_0 != MessageBoxIcon.Exclamation && messageBoxIcon_0 != MessageBoxIcon.Exclamation)
				{
					if (messageBoxIcon_0 == MessageBoxIcon.Asterisk || messageBoxIcon_0 == MessageBoxIcon.Asterisk)
					{
						pictureBox.Image = SystemIcons.Information.ToBitmap();
					}
				}
				else
				{
					pictureBox.Image = SystemIcons.Warning.ToBitmap();
				}
			}
			else
			{
				pictureBox.Image = SystemIcons.Error.ToBitmap();
			}
			Controls.Add(pictureBox);
		}
		aAj.AutoSize = false;
		aAj.Height = 28;
		aAj.Top = ClientSize.Height - 38;
		aAK.AutoSize = false;
		aAK.Height = 28;
		aAK.Top = aAj.Top;
		aAk.AutoSize = false;
		aAk.Height = 28;
		aAk.Top = aAj.Top;
		switch (messageBoxButtons_0)
		{
		case MessageBoxButtons.OK:
			if (string_2 != null && string_2.Length != 0)
			{
				aAj.Text = string_2[0];
			}
			else
			{
				aAj.Text = Class333.smethod_821();
			}
			aAj.Width = Math.Max(70, TextRenderer.MeasureText(aAj.Text, aAj.Font).Width + 20);
			if (ClientSize.Width < 10 + aAj.Width + 10)
			{
				ClientSize = new Size(10 + aAj.Width + 10, ClientSize.Height);
			}
			aAj.Left = ClientSize.Width - (aAj.Width + 10);
			aAj.DialogResult = DialogResult.OK;
			Controls.Add(aAj);
			CancelButton = aAj;
			break;
		case MessageBoxButtons.OKCancel:
			if (string_2 != null && string_2.Length >= 2)
			{
				aAj.Text = string_2[0];
				aAK.Text = string_2[1];
			}
			else
			{
				aAj.Text = Class333.smethod_821();
				aAK.Text = Class333.smethod_823();
			}
			aAj.Width = Math.Max(70, TextRenderer.MeasureText(aAj.Text, aAj.Font).Width + 20);
			aAK.Width = Math.Max(70, TextRenderer.MeasureText(aAK.Text, aAK.Font).Width + 20);
			if (ClientSize.Width < 10 + aAj.Width + 10 + aAK.Width + 10)
			{
				ClientSize = new Size(10 + aAj.Width + 10 + aAK.Width + 10, ClientSize.Height);
			}
			aAK.Left = ClientSize.Width - (aAK.Width + 10);
			aAj.Left = aAK.Left - (aAj.Width + 10);
			aAj.DialogResult = DialogResult.OK;
			aAK.DialogResult = DialogResult.Cancel;
			Controls.Add(aAj);
			Controls.Add(aAK);
			CancelButton = aAK;
			break;
		case MessageBoxButtons.AbortRetryIgnore:
			if (string_2 != null && string_2.Length >= 3)
			{
				aAj.Text = string_2[0];
				aAK.Text = string_2[1];
				aAk.Text = string_2[2];
			}
			else
			{
				aAj.Text = Class333.aAu();
				aAK.Text = Class333.aAV();
				aAk.Text = Class333.smethod_1401();
			}
			aAj.Width = Math.Max(70, TextRenderer.MeasureText(aAj.Text, aAj.Font).Width + 20);
			aAK.Width = Math.Max(70, TextRenderer.MeasureText(aAK.Text, aAK.Font).Width + 20);
			aAk.Width = Math.Max(70, TextRenderer.MeasureText(aAk.Text, aAk.Font).Width + 20);
			if (ClientSize.Width < 10 + aAj.Width + 10 + aAK.Width + 10 + aAk.Width + 10)
			{
				ClientSize = new Size(10 + aAj.Width + 10 + aAK.Width + 10 + aAk.Width + 10, ClientSize.Height);
			}
			aAk.Left = ClientSize.Width - (aAk.Width + 10);
			aAK.Left = aAk.Left - (aAK.Width + 10);
			aAj.Left = aAK.Left - (aAj.Width + 10);
			aAj.DialogResult = DialogResult.Abort;
			aAK.DialogResult = DialogResult.Retry;
			aAk.DialogResult = DialogResult.Ignore;
			Controls.Add(aAj);
			Controls.Add(aAK);
			Controls.Add(aAk);
			CancelButton = aAj;
			break;
		case MessageBoxButtons.YesNoCancel:
			if (string_2 != null && string_2.Length >= 3)
			{
				aAj.Text = string_2[0];
				aAK.Text = string_2[1];
				aAk.Text = string_2[2];
			}
			else
			{
				aAj.Text = Class333.smethod_2340();
				aAK.Text = Class333.smethod_2339();
				aAk.Text = Class333.smethod_823();
			}
			aAj.Width = Math.Max(70, TextRenderer.MeasureText(aAj.Text, aAj.Font).Width + 20);
			aAK.Width = Math.Max(70, TextRenderer.MeasureText(aAK.Text, aAK.Font).Width + 20);
			aAk.Width = Math.Max(70, TextRenderer.MeasureText(aAk.Text, aAk.Font).Width + 20);
			if (ClientSize.Width < 10 + aAj.Width + 10 + aAK.Width + 10 + aAk.Width + 10)
			{
				ClientSize = new Size(10 + aAj.Width + 10 + aAK.Width + 10 + aAk.Width + 10, ClientSize.Height);
			}
			aAk.Left = ClientSize.Width - (aAk.Width + 10);
			aAK.Left = aAk.Left - (aAK.Width + 10);
			aAj.Left = aAK.Left - (aAj.Width + 10);
			aAj.DialogResult = DialogResult.Yes;
			aAK.DialogResult = DialogResult.No;
			aAk.DialogResult = DialogResult.Cancel;
			Controls.Add(aAj);
			Controls.Add(aAK);
			Controls.Add(aAk);
			CancelButton = aAk;
			break;
		case MessageBoxButtons.YesNo:
			if (string_2 != null && string_2.Length >= 2)
			{
				aAj.Text = string_2[0];
				aAK.Text = string_2[1];
			}
			else
			{
				aAj.Text = Class333.smethod_2340();
				aAK.Text = Class333.smethod_2339();
			}
			aAj.Width = Math.Max(70, TextRenderer.MeasureText(aAj.Text, aAj.Font).Width + 20);
			aAK.Width = Math.Max(70, TextRenderer.MeasureText(aAK.Text, aAK.Font).Width + 20);
			if (ClientSize.Width < 10 + aAj.Width + 10 + aAK.Width + 10)
			{
				ClientSize = new Size(10 + aAj.Width + 10 + aAK.Width + 10, ClientSize.Height);
			}
			aAK.Left = ClientSize.Width - (aAK.Width + 10);
			aAj.Left = aAK.Left - (aAj.Width + 10);
			aAj.DialogResult = DialogResult.Yes;
			aAK.DialogResult = DialogResult.No;
			Controls.Add(aAj);
			Controls.Add(aAK);
			CancelButton = aAK;
			break;
		case MessageBoxButtons.RetryCancel:
			if (string_2 != null && string_2.Length >= 2)
			{
				aAj.Text = string_2[0];
				aAK.Text = string_2[1];
			}
			else
			{
				aAj.Text = Class333.aAV();
				aAK.Text = Class333.smethod_823();
			}
			aAj.Width = Math.Max(70, TextRenderer.MeasureText(aAj.Text, aAj.Font).Width + 20);
			aAK.Width = Math.Max(70, TextRenderer.MeasureText(aAK.Text, aAK.Font).Width + 20);
			if (ClientSize.Width < 10 + aAj.Width + 10 + aAK.Width + 10)
			{
				ClientSize = new Size(10 + aAj.Width + 10 + aAK.Width + 10, ClientSize.Height);
			}
			aAK.Left = ClientSize.Width - (aAK.Width + 10);
			aAj.Left = aAK.Left - (aAj.Width + 10);
			aAj.DialogResult = DialogResult.Retry;
			aAK.DialogResult = DialogResult.Cancel;
			Controls.Add(aAj);
			Controls.Add(aAK);
			CancelButton = aAK;
			break;
		}
		aAL = messageBoxDefaultButton_0;
	}

	protected override void OnShown(EventArgs eventArgs_0)
	{
		switch (aAL)
		{
		default:
			aAj.Focus();
			break;
		case MessageBoxDefaultButton.Button3:
			aAk.Focus();
			break;
		case MessageBoxDefaultButton.Button2:
			aAK.Focus();
			break;
		case MessageBoxDefaultButton.Button1:
			aAj.Focus();
			break;
		}
	}

	internal static DialogResult smethod_0(IWin32Window iwin32Window_0, string string_0)
	{
		Form54 form = new Form54(string_0, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, null);
		DialogResult result = form.ShowDialog(iwin32Window_0);
		form.Dispose();
		return result;
	}

	internal static DialogResult smethod_1(IWin32Window iwin32Window_0, string string_0, string[] string_1)
	{
		Form54 form = new Form54(string_0, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, string_1);
		DialogResult result = form.ShowDialog(iwin32Window_0);
		form.Dispose();
		return result;
	}

	internal static DialogResult smethod_2(IWin32Window iwin32Window_0, string string_0, string string_1)
	{
		Form54 form = new Form54(string_0, string_1, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, null);
		DialogResult result = form.ShowDialog(iwin32Window_0);
		form.Dispose();
		return result;
	}

	internal static DialogResult smethod_3(IWin32Window iwin32Window_0, string string_0, string string_1, string[] string_2)
	{
		Form54 form = new Form54(string_0, string_1, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, string_2);
		DialogResult result = form.ShowDialog(iwin32Window_0);
		form.Dispose();
		return result;
	}

	internal static DialogResult smethod_4(IWin32Window iwin32Window_0, string string_0, string string_1, MessageBoxButtons messageBoxButtons_0)
	{
		Form54 form = new Form54(string_0, string_1, messageBoxButtons_0, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, null);
		DialogResult result = form.ShowDialog(iwin32Window_0);
		form.Dispose();
		return result;
	}

	internal static DialogResult smethod_5(IWin32Window iwin32Window_0, string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, string[] string_2)
	{
		Form54 form = new Form54(string_0, string_1, messageBoxButtons_0, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, string_2);
		DialogResult result = form.ShowDialog(iwin32Window_0);
		form.Dispose();
		return result;
	}

	internal static DialogResult smethod_6(IWin32Window iwin32Window_0, string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		Form54 form = new Form54(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, MessageBoxDefaultButton.Button1, null);
		DialogResult result = form.ShowDialog(iwin32Window_0);
		form.Dispose();
		return result;
	}

	internal static DialogResult smethod_7(IWin32Window iwin32Window_0, string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, string[] string_2)
	{
		Form54 form = new Form54(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, MessageBoxDefaultButton.Button1, string_2);
		DialogResult result = form.ShowDialog(iwin32Window_0);
		form.Dispose();
		return result;
	}

	internal static DialogResult smethod_8(IWin32Window iwin32Window_0, string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, MessageBoxDefaultButton messageBoxDefaultButton_0)
	{
		Form54 form = new Form54(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, messageBoxDefaultButton_0, null);
		DialogResult result = form.ShowDialog(iwin32Window_0);
		form.Dispose();
		return result;
	}

	internal static DialogResult smethod_9(IWin32Window iwin32Window_0, string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, MessageBoxDefaultButton messageBoxDefaultButton_0, string[] string_2)
	{
		Form54 form = new Form54(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, messageBoxDefaultButton_0, string_2);
		DialogResult result = form.ShowDialog(iwin32Window_0);
		form.Dispose();
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && aAl != null)
		{
			aAl.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_0()
	{
		SuspendLayout();
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(424, 131);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		ControlBox = false;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.aAv();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		ResumeLayout(performLayout: false);
	}
}
