using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.Resources;
using ns0;
using ns5;
using ns7;

namespace ns4;

internal class Form11 : Form
{
	private delegate void Delegate104(object sender, EventArgs e);

	private delegate void Delegate105(object sender, EventArgs2 e);

	private class Class203 : Button
	{
		protected bool BPe;

		protected Form11 BPF;

		protected override void OnMouseEnter(EventArgs eventArgs_0)
		{
			base.OnMouseEnter(eventArgs_0);
			BPe = true;
			Invalidate();
		}

		protected override void OnMouseLeave(EventArgs eventArgs_0)
		{
			base.OnMouseLeave(eventArgs_0);
			BPe = false;
			Invalidate();
		}

		protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs previewKeyDownEventArgs_0)
		{
			base.OnPreviewKeyDown(previewKeyDownEventArgs_0);
			previewKeyDownEventArgs_0.IsInputKey = previewKeyDownEventArgs_0.KeyData == Keys.Left || previewKeyDownEventArgs_0.KeyData == Keys.Up || previewKeyDownEventArgs_0.KeyData == Keys.Right || previewKeyDownEventArgs_0.KeyData == Keys.Down;
		}

		protected override void OnKeyDown(KeyEventArgs keyEventArgs_0)
		{
			List<Class203> list = new List<Class203>();
			int num = -1;
			foreach (Control control3 in BPF.Controls)
			{
				if (control3 is Panel)
				{
					foreach (Control control4 in control3.Controls)
					{
						if (control4 is Class203 && control4.Enabled)
						{
							if (control4.Focused)
							{
								num = list.Count;
							}
							list.Add(control4 as Class203);
						}
					}
				}
				else if (control3 is Class203 && control3.Enabled)
				{
					if (control3.Focused)
					{
						num = list.Count;
					}
					list.Add(control3 as Class203);
				}
			}
			if (list.Count > 1)
			{
				if (keyEventArgs_0.KeyData != Keys.Left && keyEventArgs_0.KeyData != Keys.Up)
				{
					if (keyEventArgs_0.KeyData != Keys.Right && keyEventArgs_0.KeyData != Keys.Down)
					{
						base.OnKeyDown(keyEventArgs_0);
					}
					else if (num == -1)
					{
						Focus();
					}
					else if (list[list.Count - 1].Focused)
					{
						list[0].Focus();
					}
					else
					{
						list[num + 1].Focus();
					}
				}
				else if (num == -1)
				{
					Focus();
				}
				else if (list[0].Focused)
				{
					list[list.Count - 1].Focus();
				}
				else
				{
					list[num - 1].Focus();
				}
			}
			else
			{
				base.OnKeyDown(keyEventArgs_0);
			}
		}
	}

	private class Class204 : Class203
	{
		internal Class204(Form11 form11_0)
		{
			BPF = form11_0;
		}

		internal bool method_0()
		{
			string text = string.Empty;
			if (Tag is Class5)
			{
				text = (Tag as Class5).string_0;
			}
			if (!string.IsNullOrEmpty(BPF.string_0) && text == BPF.string_0 && Form23.framework_1 != null && Form23.framework_1.method_5() && Form23.framework_1.method_9())
			{
				return true;
			}
			return false;
		}

		protected override void OnClick(EventArgs eventArgs_0)
		{
			bool flag;
			if ((flag = method_0()) || Form23.smethod_87(this, bool_53: true) != DialogResult.Cancel)
			{
				if (flag)
				{
					BPF.enum57_0 = Enum57.const_1;
				}
				else
				{
					BPF.enum57_0 = Enum57.const_2;
				}
				BPF.string_0 = string.Empty;
				if (Tag is Class5)
				{
					BPF.string_0 = (Tag as Class5).string_0;
				}
				BPF.DialogResult = DialogResult.OK;
				BPF.Close();
			}
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs_0)
		{
			using (SolidBrush brush = new SolidBrush(BackColor))
			{
				paintEventArgs_0.Graphics.FillRectangle(brush, 0, 0, Width, Height);
			}
			if (Focused)
			{
				using Pen pen = new Pen(Color.DodgerBlue, 3f);
				paintEventArgs_0.Graphics.DrawRectangle(pen, 1, 1, Width - 3, Height - 3);
			}
			else if (BPe)
			{
				using Pen pen2 = new Pen(Color.DodgerBlue, 1f);
				paintEventArgs_0.Graphics.DrawRectangle(pen2, 0, 0, Width - 1, Height - 1);
			}
			using SolidBrush brush2 = new SolidBrush(Form23.color_12);
			using Font font = new Font(Font.FontFamily, 10f, FontStyle.Regular);
			using StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			if (method_0())
			{
				paintEventArgs_0.Graphics.DrawString(Class333.BhE(), font, brush2, Width / 2, 19f, stringFormat);
				paintEventArgs_0.Graphics.DrawString(Class333.Bhe(), font, brush2, Width / 2, 33f, stringFormat);
			}
			else
			{
				paintEventArgs_0.Graphics.DrawString(Class333.BhF(), font, brush2, Width / 2, 19f, stringFormat);
				paintEventArgs_0.Graphics.DrawString(Class333.Bhf(), font, brush2, Width / 2, 33f, stringFormat);
			}
		}
	}

	private class Class205 : Class203
	{
		internal Class205(Form11 form11_0)
		{
			BPF = form11_0;
		}

		protected override void OnClick(EventArgs eventArgs_0)
		{
			if (!Enabled)
			{
				return;
			}
			Form23.framework_1.method_65(BPF);
			Form23.smethod_11();
			if (Form23.framework_1.method_4())
			{
				BPF.enum57_0 = Enum57.const_3;
				BPF.string_0 = string.Empty;
				if (Tag is Class5)
				{
					BPF.string_0 = (Tag as Class5).string_0;
				}
				BPF.DialogResult = DialogResult.OK;
				BPF.Close();
			}
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs_0)
		{
			using (SolidBrush brush = new SolidBrush(BackColor))
			{
				paintEventArgs_0.Graphics.FillRectangle(brush, 0, 0, Width, Height);
			}
			if (Enabled)
			{
				if (Focused)
				{
					using Pen pen = new Pen(Color.DodgerBlue, 3f);
					paintEventArgs_0.Graphics.DrawRectangle(pen, 1, 1, Width - 3, Height - 3);
				}
				else if (BPe)
				{
					using Pen pen2 = new Pen(Color.DodgerBlue, 1f);
					paintEventArgs_0.Graphics.DrawRectangle(pen2, 0, 0, Width - 1, Height - 1);
				}
			}
			Color color = ((!Enabled) ? Form23.color_36 : Form23.color_12);
			using SolidBrush brush2 = new SolidBrush(color);
			using Font font = new Font(Font.FontFamily, 10f, FontStyle.Regular);
			using StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			paintEventArgs_0.Graphics.DrawString(Class333.BhG(), font, brush2, Width / 2, 19f, stringFormat);
			paintEventArgs_0.Graphics.DrawString(Class333.Bhe(), font, brush2, Width / 2, 33f, stringFormat);
		}
	}

	private class Class206 : Class203
	{
		internal Class206(Form11 form11_0)
		{
			BPF = form11_0;
		}

		protected override void OnClick(EventArgs eventArgs_0)
		{
			BPF.string_0 = string.Empty;
			BPF.enum57_0 = Enum57.const_0;
			BPF.DialogResult = DialogResult.Cancel;
			BPF.Close();
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs_0)
		{
			using (SolidBrush brush = new SolidBrush(BackColor))
			{
				paintEventArgs_0.Graphics.FillRectangle(brush, 0, 0, Width, Height);
			}
			if (Focused)
			{
				using Pen pen = new Pen(Color.DodgerBlue, 3f);
				paintEventArgs_0.Graphics.DrawRectangle(pen, 1, 1, Width - 3, Height - 3);
			}
			else if (BPe)
			{
				using Pen pen2 = new Pen(Color.DodgerBlue, 1f);
				paintEventArgs_0.Graphics.DrawRectangle(pen2, 0, 0, Width - 1, Height - 1);
			}
			Image image = Class25.smethod_0(GeneralResources.IconOffline, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f);
			paintEventArgs_0.Graphics.DrawImage(image, 50 - image.Width / 2, 50 - image.Height / 2, image.Width, image.Height);
			image.Dispose();
			using Font font = new Font(Font.FontFamily, 13f, FontStyle.Bold);
			paintEventArgs_0.Graphics.DrawString(Class333.Bhg(), font, Brushes.Red, 110f, 35f);
		}
	}

	private const int int_0 = 33;

	private const int int_1 = 100;

	private const int int_2 = 120;

	private List<Panel> list_0 = new List<Panel>();

	private Class206 class206_0;

	private string string_0 = string.Empty;

	private Enum57 enum57_0;

	private IContainer icontainer_0;

	private Label label_0;

	internal Form11(List<Class5> list_1, string string_1)
	{
		method_7();
		BackColor = Form23.color_11;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		class206_0 = new Class206(this);
		string_0 = string_1;
		method_0(list_1, string_1);
		enum57_0 = Enum57.const_0;
		Class1.smethod_10(method_1);
		Class1.smethod_12(method_2);
	}

	private void method_0(List<Class5> list_1, string string_1)
	{
		if (Controls.Contains(class206_0))
		{
			Controls.Remove(class206_0);
		}
		list_0.Clear();
		while (Controls.Count != 1)
		{
			foreach (Control control4 in Controls)
			{
				if (!(control4 is Panel))
				{
					continue;
				}
				Panel panel = control4 as Panel;
				panel.Paint -= method_4;
				panel.Tag = null;
				foreach (Control control5 in panel.Controls)
				{
					control5.Tag = null;
					control5.Dispose();
				}
				panel.Dispose();
				break;
			}
		}
		bool flag = false;
		foreach (Class5 item in list_1)
		{
			Panel panel2 = new Panel();
			panel2.Tag = item;
			panel2.BackColor = BackColor;
			panel2.Left = 0;
			panel2.Width = ClientRectangle.Width;
			panel2.Height = 100;
			panel2.Paint += method_4;
			Class204 @class = new Class204(this);
			@class.Tag = item;
			@class.BackColor = BackColor;
			@class.Left = panel2.Width - 120;
			@class.Top = 0;
			@class.Width = 120;
			@class.Height = 50;
			panel2.Controls.Add(@class);
			if (@class.method_0())
			{
				CancelButton = @class;
				flag = true;
			}
			Class205 class2 = new Class205(this);
			class2.Tag = item;
			class2.BackColor = BackColor;
			class2.Left = panel2.Width - 120;
			class2.Top = 50;
			class2.Width = 120;
			class2.Height = 50;
			panel2.Controls.Add(class2);
			Class240 class3 = new Class240
			{
				axS = item.byte_4,
				axs = item.byte_5,
				axt = item.byte_16,
				axT = new Class14(item.byte_0, item.byte_1, item.byte_2, item.byte_3, item.int_0)
			};
			Class240 class4 = null;
			if (Form23.framework_1 != null)
			{
				class4 = new Class240
				{
					axS = Form23.framework_1.awZ,
					axs = Form23.framework_1.awz,
					axT = Form23.framework_1.aXA,
					axt = Form23.framework_1.method_11()
				};
			}
			int num;
			if (!string.IsNullOrEmpty(string_1))
			{
				num = ((item.string_0 == string_1) ? 1 : 0);
				if (num != 0)
				{
					goto IL_0357;
				}
			}
			else
			{
				num = 0;
			}
			if (Form23.framework_1 == null || !Form23.framework_1.method_5() || !Form23.framework_1.method_9() || !(class3 == class4) || item.byte_20 != 1 || (Form23.int_0 & 2) != 0 || (Form23.int_0 & 0x100) != 0 || (Form23.int_0 & 0x20) != 0)
			{
				goto IL_0357;
			}
			class2.Enabled = true;
			goto IL_035f;
			IL_035f:
			if (num != 0)
			{
				panel2.Top = 33;
				if (list_0.Count == 0)
				{
					list_0.Add(panel2);
				}
				else
				{
					foreach (Panel item2 in list_0)
					{
						item2.Top += 100;
						foreach (Control control6 in item2.Controls)
						{
							if (control6 is Button)
							{
								control6.TabIndex += 2;
							}
						}
					}
					list_0.Insert(0, panel2);
				}
				@class.TabIndex = 0;
				class2.TabIndex = 1;
			}
			else
			{
				panel2.Top = 33 + list_0.Count * 100;
				int count = list_0.Count;
				list_0.Add(panel2);
				@class.TabIndex = count * 2;
				class2.TabIndex = count * 2 + 1;
			}
			Controls.Add(panel2);
			continue;
			IL_0357:
			class2.Enabled = false;
			goto IL_035f;
		}
		class206_0.BackColor = BackColor;
		class206_0.Left = 0;
		class206_0.Top = 33 + list_0.Count * 100;
		class206_0.Width = ClientRectangle.Width;
		class206_0.Height = 100;
		class206_0.TabIndex = list_0.Count * 2;
		Controls.Add(class206_0);
		if (!flag)
		{
			CancelButton = class206_0;
		}
		Height = 75 + (list_1.Count + 1) * 100;
	}

	private void Form11_Shown(object sender, EventArgs e)
	{
		class206_0.Width = ClientRectangle.Width;
		foreach (Panel item in list_0)
		{
			item.Width = ClientRectangle.Width;
			foreach (Control control in item.Controls)
			{
				if (control is Button)
				{
					control.Left = item.Width - 120;
				}
			}
		}
		method_3();
		if (Form23.form63_0 != null && !Form23.form63_0.IsDisposed && Form23.form63_0.Visible)
		{
			Form23.form63_0.Hide();
		}
		if (Form23.form62_0 != null && !Form23.form62_0.IsDisposed && Form23.form62_0.Visible)
		{
			Form23.form62_0.Hide();
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate104 method = method_1;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		List<Class5> list_ = Class1.smethod_27();
		method_0(list_, string_0);
		method_3();
	}

	private void method_2(object sender, EventArgs2 e)
	{
		try
		{
			if (IsDisposed)
			{
				return;
			}
			if (InvokeRequired)
			{
				try
				{
					Delegate105 method = method_2;
					Invoke(method, sender, e);
					return;
				}
				catch
				{
					return;
				}
			}
			if (sender is string)
			{
				string obj2 = sender as string;
				Enum7 enum7_ = e.enum7_0;
				string empty = string.Empty;
				if (!(obj2 != string_0) && enum7_ != Enum7.const_0)
				{
					string_0 = string.Empty;
				}
				else
				{
					empty = string_0;
				}
				List<Class5> list_ = Class1.smethod_27();
				method_0(list_, empty);
				method_3();
			}
		}
		catch
		{
		}
	}

	private void method_3()
	{
		if (list_0.Count != 1 && string.IsNullOrEmpty(string_0))
		{
			class206_0.Focus();
			return;
		}
		bool flag = false;
		foreach (Panel item in list_0)
		{
			Class5 @class = item.Tag as Class5;
			if ((list_0.Count == 1 || (!string.IsNullOrEmpty(string_0) && @class.string_0 == string_0)) && item.Controls.Count != 0 && item.Controls[0] is Class204)
			{
				(item.Controls[0] as Class204).Focus();
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			class206_0.Focus();
		}
	}

	private void method_4(object sender, PaintEventArgs e)
	{
		Panel panel = sender as Panel;
		using (SolidBrush brush = new SolidBrush(BackColor))
		{
			e.Graphics.FillRectangle(brush, 0, 0, panel.Width, panel.Height);
		}
		Class5 @class = panel.Tag as Class5;
		int byte_ = @class.byte_4;
		int byte_2 = @class.byte_5;
		Class14 class2 = new Class14(@class.byte_0, @class.byte_1, @class.byte_2, @class.byte_3, @class.int_0);
		Image image = Class242.smethod_11(byte_, byte_2);
		if (image != null)
		{
			e.Graphics.DrawImage(image, 10, 10, 80, 80);
		}
		string text = string.Empty;
		switch (Class1.smethod_25(@class.string_0))
		{
		case Enum11.const_0:
			text = Class333.smethod_1036();
			break;
		case Enum11.const_1:
			text = Class333.smethod_1037();
			break;
		case Enum11.const_2:
			text = Class333.smethod_1036();
			break;
		case Enum11.const_3:
			text = Class333.smethod_1036();
			break;
		}
		if (!string.IsNullOrEmpty(string_0) && @class.string_0 == string_0)
		{
			using SolidBrush brush2 = new SolidBrush(Color.FromArgb(255, 0, 128, 0));
			using Font font = new Font(Font.FontFamily, 13f, FontStyle.Bold);
			e.Graphics.DrawString(Class242.smethod_10(byte_, byte_2) + text + Class333.smethod_1038(), font, brush2, 110f, 10f);
		}
		else
		{
			using SolidBrush brush3 = new SolidBrush(Form23.color_12);
			using Font font2 = new Font(Font.FontFamily, 13f, FontStyle.Bold);
			e.Graphics.DrawString(Class242.smethod_10(byte_, byte_2) + text, font2, brush3, 110f, 10f);
		}
		using SolidBrush brush4 = new SolidBrush(Form23.color_12);
		using Font font3 = new Font(Font.FontFamily, 13f, FontStyle.Regular);
		e.Graphics.DrawString(Class333.smethod_1039() + class2, font3, brush4, 110f, 35f);
		e.Graphics.DrawString(Class333.smethod_1040() + @class.string_0, font3, brush4, 110f, 60f);
	}

	[SpecialName]
	internal string method_5()
	{
		return string_0;
	}

	[SpecialName]
	internal Enum57 method_6()
	{
		return enum57_0;
	}

	private void Form11_FormClosing(object sender, FormClosingEventArgs e)
	{
		Class1.smethod_11(method_1);
		Class1.smethod_13(method_2);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_7()
	{
		label_0 = new Label();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Location = new Point(7, 9);
		label_0.Name = Class333.smethod_618();
		label_0.Size = new Size(343, 13);
		label_0.TabIndex = 2;
		label_0.Text = Class333.smethod_1041();
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(554, 61);
		ControlBox = false;
		Controls.Add(label_0);
		Font = new Font(Class333.smethod_145(), 8.25f);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_1042();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1043();
		FormClosing += Form11_FormClosing;
		Shown += Form11_Shown;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
