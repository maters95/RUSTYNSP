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

internal class Form63 : Form
{
	[CompilerGenerated]
	private sealed class Class228
	{
		public string BRQ;

		public Form63 BRq;

		internal void method_0()
		{
			BRq.abC.Text = Form62.aBX + BRQ;
		}
	}

	private BackgroundWorker abA = new BackgroundWorker();

	private uint aba = 5u;

	private IContainer abB;

	private Label abb;

	private ThemedButton abC;

	internal Form63()
	{
		method_0();
		aba = 5u;
		abC.Text = Form62.aBX + Class333.smethod_536() + aba;
		abC.Enabled = false;
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		abA.WorkerSupportsCancellation = true;
		abA.DoWork += abA_DoWork;
		abA.RunWorkerCompleted += abA_RunWorkerCompleted;
		abA.RunWorkerAsync();
	}

	private void abA_DoWork(object sender, DoWorkEventArgs e)
	{
		while (true)
		{
			if (!Class1.smethod_20(Form23.framework_1.aXc))
			{
				Class1.smethod_37(Form23.framework_1.aXc, Enum10.const_5, 0u, 4u, out var _, out var _);
				Thread.Sleep(1000);
				if (abA.CancellationPending)
				{
					break;
				}
				try
				{
					string BRQ = Class333.smethod_102();
					if (aba > 1)
					{
						aba--;
						BRQ = Class333.smethod_536() + aba;
					}
					else
					{
						abC.Invoke(() =>
						{
							abC.Enabled = true;
						});
					}
					abC.Invoke(() =>
					{
						abC.Text = Form62.aBX + BRQ;
					});
				}
				catch (Exception ex)
				{
					Class23.smethod_3(Class333.aBz() + ex.Message);
				}
				continue;
			}
			e.Result = true;
			return;
		}
		e.Result = false;
	}

	private void abA_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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

	private void abC_Click(object sender, EventArgs e)
	{
		abA.CancelAsync();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && abB != null)
		{
			abB.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_0()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form63));
		abb = new Label();
		abC = new ThemedButton();
		SuspendLayout();
		abb.AutoSize = true;
		abb.Location = new Point(5, 9);
		abb.Name = Class333.smethod_618();
		abb.Size = new Size(328, 65);
		abb.TabIndex = 0;
		abb.Text = componentResourceManager.GetString(Class333.smethod_2199());
		abC.Enabled = false;
		abC.Location = new Point(116, 83);
		abC.Name = Class333.abA();
		abC.Size = new Size(128, 38);
		abC.TabIndex = 3;
		abC.Text = Class333.aBX();
		abC.UseVisualStyleBackColor = true;
		abC.Click += abC_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(360, 133);
		ControlBox = false;
		Controls.Add(abC);
		Controls.Add(abb);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		Name = Class333.aba();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.abB();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[CompilerGenerated]
	private void method_1()
	{
		abC.Enabled = true;
	}
}
