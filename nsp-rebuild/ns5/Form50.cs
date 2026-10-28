using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using NSP.Properties;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns2;
using ns4;
using ns7;

namespace ns5;

internal class Form50 : Form
{
	private Framework framework_0;

	private string string_0;

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private ThemedTextBox themedTextBox_0;

	private ThemedTextBox themedTextBox_1;

	private ThemedTextBox themedTextBox_2;

	private ThemedTextBox themedTextBox_3;

	private ThemedTextBox themedTextBox_4;

	private ThemedTextBox themedTextBox_5;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private Label label_6;

	internal Form50(Framework framework_1, string string_1)
	{
		method_3();
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
			else if (control is ThemedTextBox)
			{
				control.BackColor = Form23.color_32;
				control.ForeColor = Form23.color_12;
			}
		}
		framework_0 = framework_1;
		string_0 = string_1;
		method_1();
	}

	private void themedButton_1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		try
		{
			if (string.IsNullOrWhiteSpace(themedTextBox_0.Text))
			{
				Form54.smethod_6(this, Class333.smethod_2592(), Class333.smethod_2593(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			try
			{
				if (new MailAddress(themedTextBox_0.Text).Address != themedTextBox_0.Text)
				{
					throw new FormatException();
				}
			}
			catch (FormatException)
			{
				Form54.smethod_6(this, Class333.smethod_2594(), Class333.smethod_2595(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (string.IsNullOrWhiteSpace(themedTextBox_4.Text))
			{
				Form54.smethod_6(this, Class333.smethod_2596(), Class333.smethod_2597(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (string.IsNullOrWhiteSpace(themedTextBox_5.Text))
			{
				Form54.smethod_6(this, Class333.smethod_2598(), Class333.smethod_2599(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			method_0();
			method_2(string_0 + Class333.smethod_2600());
			bool flag = false;
			try
			{
				using WebClient webClient = new WebClient();
				using (webClient.OpenRead(Class333.smethod_2601()))
				{
					flag = true;
				}
			}
			catch
			{
				flag = false;
			}
			if (flag)
			{
				Form54.smethod_6(this, Class333.smethod_2602(), Class333.smethod_2603(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_2604(), Class333.smethod_2603(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			DialogResult = DialogResult.OK;
			Close();
		}
		catch (Exception ex2)
		{
			Form54.smethod_6(this, ex2.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_0()
	{
		try
		{
			if (themedTextBox_0.Text != null)
			{
				Settings.Default.UserEmail = themedTextBox_0.Text;
			}
			if (themedTextBox_1.Text != null)
			{
				Settings.Default.UserFirstName = themedTextBox_1.Text;
			}
			if (themedTextBox_2.Text != null)
			{
				Settings.Default.UserLastName = themedTextBox_2.Text;
			}
			if (themedTextBox_3.Text != null)
			{
				Settings.Default.UserPhone = themedTextBox_3.Text;
			}
			Settings.Default.Save();
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_2605() + ex.Message);
		}
	}

	private void method_1()
	{
		try
		{
			themedTextBox_0.Text = Settings.Default.UserEmail;
			themedTextBox_1.Text = Settings.Default.UserFirstName;
			themedTextBox_2.Text = Settings.Default.UserLastName;
			themedTextBox_3.Text = Settings.Default.UserPhone;
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_2606() + ex.Message);
		}
	}

	private void method_2(string string_1)
	{
		bool flag = true;
		string text = themedTextBox_0.Text;
		string text2 = themedTextBox_1.Text;
		string text3 = themedTextBox_2.Text;
		string text4 = themedTextBox_3.Text;
		string text5 = themedTextBox_4.Text;
		string text6 = themedTextBox_5.Text;
		string value = Form1.smethod_0(Assembly.GetEntryAssembly().GetName().Version);
		string value2 = Class242.smethod_10(framework_0.awZ, framework_0.awz);
		string aXc = framework_0.aXc;
		string value3 = framework_0.aXA.ToString();
		Dictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{
				Class333.smethod_2607(),
				flag.ToString()
			},
			{
				Class333.smethod_2608(),
				text
			},
			{
				Class333.smethod_2609(),
				text2
			},
			{
				Class333.smethod_2610(),
				text3
			},
			{
				Class333.smethod_2611(),
				text4
			},
			{
				Class333.smethod_2612(),
				text5
			},
			{
				Class333.smethod_91(),
				text6
			},
			{
				Class333.smethod_2613(),
				value
			},
			{
				Class333.smethod_2614(),
				value2
			},
			{
				Class333.smethod_2615(),
				aXc
			},
			{
				Class333.smethod_2616(),
				value3
			}
		};
		MemoryStream memoryStream = new MemoryStream();
		XmlWriter xmlWriter = XmlWriter.Create(memoryStream, new XmlWriterSettings
		{
			ConformanceLevel = ConformanceLevel.Document,
			CloseOutput = false,
			Indent = true,
			NewLineChars = Environment.NewLine
		});
		xmlWriter.WriteStartElement(Class333.smethod_2617());
		foreach (KeyValuePair<string, string> item in dictionary)
		{
			xmlWriter.WriteStartElement(item.Key);
			xmlWriter.WriteAttributeString(Class333.smethod_1159(), item.Value);
			xmlWriter.WriteEndElement();
		}
		xmlWriter.WriteEndElement();
		xmlWriter.Close();
		memoryStream.Flush();
		using (StreamWriter streamWriter = new StreamWriter(string_1))
		{
			memoryStream.Position = 0L;
			using StreamReader streamReader = new StreamReader(memoryStream);
			string value4 = streamReader.ReadToEnd();
			streamWriter.Write(value4);
		}
		memoryStream.Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_3()
	{
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		themedTextBox_0 = new ThemedTextBox();
		themedTextBox_1 = new ThemedTextBox();
		themedTextBox_2 = new ThemedTextBox();
		themedTextBox_3 = new ThemedTextBox();
		themedTextBox_4 = new ThemedTextBox();
		themedTextBox_5 = new ThemedTextBox();
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		label_5 = new Label();
		label_6 = new Label();
		SuspendLayout();
		themedButton_0.Location = new Point(440, 339);
		themedButton_0.Name = Class333.smethod_2618();
		themedButton_0.Size = new Size(100, 35);
		themedButton_0.TabIndex = 6;
		themedButton_0.Text = Class333.smethod_2619();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_0.Click += themedButton_0_Click;
		themedButton_1.DialogResult = DialogResult.Cancel;
		themedButton_1.Location = new Point(546, 339);
		themedButton_1.Name = Class333.smethod_830();
		themedButton_1.Size = new Size(100, 35);
		themedButton_1.TabIndex = 7;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		themedButton_1.Click += themedButton_1_Click;
		themedTextBox_0.Location = new Point(146, 6);
		themedTextBox_0.Name = Class333.smethod_2620();
		themedTextBox_0.Size = new Size(500, 22);
		themedTextBox_0.TabIndex = 0;
		themedTextBox_1.Location = new Point(146, 34);
		themedTextBox_1.Name = Class333.smethod_2621();
		themedTextBox_1.Size = new Size(500, 22);
		themedTextBox_1.TabIndex = 1;
		themedTextBox_2.Location = new Point(146, 62);
		themedTextBox_2.Name = Class333.smethod_2622();
		themedTextBox_2.Size = new Size(500, 22);
		themedTextBox_2.TabIndex = 2;
		themedTextBox_3.Location = new Point(146, 90);
		themedTextBox_3.Name = Class333.smethod_2623();
		themedTextBox_3.Size = new Size(500, 22);
		themedTextBox_3.TabIndex = 3;
		themedTextBox_4.Location = new Point(146, 118);
		themedTextBox_4.Name = Class333.smethod_2624();
		themedTextBox_4.Size = new Size(500, 22);
		themedTextBox_4.TabIndex = 4;
		themedTextBox_5.AcceptsReturn = true;
		themedTextBox_5.Location = new Point(146, 146);
		themedTextBox_5.Multiline = true;
		themedTextBox_5.Name = Class333.smethod_2625();
		themedTextBox_5.Size = new Size(500, 150);
		themedTextBox_5.TabIndex = 5;
		label_0.AutoSize = true;
		label_0.Location = new Point(12, 10);
		label_0.Name = Class333.smethod_618();
		label_0.Size = new Size(86, 13);
		label_0.TabIndex = 8;
		label_0.Text = Class333.smethod_2626();
		label_1.AutoSize = true;
		label_1.Location = new Point(12, 38);
		label_1.Name = Class333.smethod_620();
		label_1.Size = new Size(61, 13);
		label_1.TabIndex = 9;
		label_1.Text = Class333.smethod_2627();
		label_2.AutoSize = true;
		label_2.Location = new Point(12, 66);
		label_2.Name = Class333.smethod_621();
		label_2.Size = new Size(59, 13);
		label_2.TabIndex = 10;
		label_2.Text = Class333.smethod_2628();
		label_3.AutoSize = true;
		label_3.Location = new Point(12, 94);
		label_3.Name = Class333.smethod_623();
		label_3.Size = new Size(84, 13);
		label_3.TabIndex = 11;
		label_3.Text = Class333.smethod_2629();
		label_4.AutoSize = true;
		label_4.Location = new Point(12, 122);
		label_4.Name = Class333.smethod_862();
		label_4.Size = new Size(53, 13);
		label_4.TabIndex = 12;
		label_4.Text = Class333.smethod_2630();
		label_5.AutoSize = true;
		label_5.Location = new Point(12, 150);
		label_5.Name = Class333.smethod_864();
		label_5.Size = new Size(120, 13);
		label_5.TabIndex = 13;
		label_5.Text = Class333.smethod_2631();
		label_6.AutoSize = true;
		label_6.Location = new Point(143, 309);
		label_6.Name = Class333.smethod_866();
		label_6.Size = new Size(470, 13);
		label_6.TabIndex = 14;
		label_6.Text = Class333.smethod_2632();
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		ClientSize = new Size(664, 388);
		Controls.Add(label_6);
		Controls.Add(label_5);
		Controls.Add(label_4);
		Controls.Add(label_3);
		Controls.Add(label_2);
		Controls.Add(label_1);
		Controls.Add(label_0);
		Controls.Add(themedTextBox_5);
		Controls.Add(themedTextBox_4);
		Controls.Add(themedTextBox_3);
		Controls.Add(themedTextBox_2);
		Controls.Add(themedTextBox_1);
		Controls.Add(themedTextBox_0);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Font = new Font(Class333.smethod_145(), 8.25f);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2633();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1637();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
