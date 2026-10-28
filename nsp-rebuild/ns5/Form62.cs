using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using NSP.UserInterface;
using ns0;
using ns4;
using ns7;

namespace ns5;

internal class Form62 : Form
{
	[CompilerGenerated]
	private sealed class Class227
	{
		public string BRP;

		public Form62 BRp;

		internal void method_0()
		{
			BRp.aBZ.Text = aBX + BRP;
		}
	}

	private BackgroundWorker aBw = new BackgroundWorker();

	internal static string aBX = Class333.aBZ();

	internal const uint aBx = 5u;

	private static uint aBY = 5u;

	private IContainer aBy;

	private ThemedButton aBZ;

	private Label aBz;

	internal Form62()
	{
		method_0();
		aBY = 5u;
		aBZ.Text = aBX + Class333.smethod_536() + 5u;
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		aBw.WorkerSupportsCancellation = true;
		aBw.DoWork += aBw_DoWork;
		aBw.RunWorkerCompleted += aBw_RunWorkerCompleted;
		aBw.RunWorkerAsync();
	}

	private void aBw_DoWork(object sender, DoWorkEventArgs e)
	{
		while (true)
		{
			if (!Class1.smethod_20(Form23.framework_1.aXc) || aBY >= 2)
			{
				Class1.smethod_37(Form23.framework_1.aXc, Enum10.const_5, 0u, 4u, out var _, out var _);
				Thread.Sleep(1000);
				if (aBw.CancellationPending)
				{
					break;
				}
				try
				{
					string BRP = Class333.smethod_102();
					if (aBY > 1)
					{
						aBY--;
						BRP = Class333.smethod_536() + aBY;
					}
					else
					{
						aBZ.Invoke(() =>
						{
							aBZ.Enabled = true;
						});
					}
					aBZ.Invoke(() =>
					{
						aBZ.Text = aBX + BRP;
					});
				}
				catch (Exception ex)
				{
					Class23.smethod_3(Class333.aBw() + ex.Message);
				}
				continue;
			}
			e.Result = true;
			return;
		}
		e.Result = false;
	}

	private void aBw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		if ((bool)e.Result)
		{
			DialogResult = DialogResult.OK;
		}
		else
		{
			DialogResult = DialogResult.Cancel;
		}
		Close();
	}

	private void aBZ_Click(object sender, EventArgs e)
	{
		aBw.CancelAsync();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && aBy != null)
		{
			aBy.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_0()
	{
		aBZ = new ThemedButton();
		aBz = new Label();
		SuspendLayout();
		aBZ.Enabled = false;
		aBZ.Location = new Point(56, 46);
		aBZ.Name = Class333.smethod_830();
		aBZ.Size = new Size(128, 38);
		aBZ.TabIndex = 0;
		aBZ.Text = Class333.aBX();
		aBZ.UseVisualStyleBackColor = true;
		aBZ.Click += aBZ_Click;
		aBz.AutoSize = true;
		aBz.Location = new Point(52, 14);
		aBz.Name = Class333.smethod_618();
		aBz.Size = new Size(135, 13);
		aBz.TabIndex = 1;
		aBz.Text = Class333.aBx();
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(240, 98);
		ControlBox = false;
		Controls.Add(aBz);
		Controls.Add(aBZ);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		Name = Class333.aBY();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.aBy();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[CompilerGenerated]
	private void method_1()
	{
		aBZ.Enabled = true;
	}
}
