using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns2;
using ns3;
using ns5;
using ns6;
using ns7;

namespace ns4;

internal class Form30 : Form
{
	private MenuNode menuNode_0;

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Control6 control6_0;

	internal Form30(MenuNode menuNode_1)
	{
		method_7();
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				(control as Label).ForeColor = Form23.color_12;
			}
		}
		menuNode_0 = menuNode_1;
		Setting setting_ = menuNode_0.method_1().method_31(menuNode_0.method_73());
		Text = Class286.smethod_13(menuNode_0.method_1(), menuNode_0, setting_);
		control6_0.method_1(menuNode_0);
		control6_0.method_14(method_0);
		themedButton_0.BringToFront();
		themedButton_1.BringToFront();
		Form23.smethod_7(method_1);
	}

	internal Form30()
	{
		method_7();
		themedButton_0.BringToFront();
		themedButton_1.BringToFront();
		Form23.smethod_7(method_1);
	}

	private void Form30_Shown(object sender, EventArgs e)
	{
		control6_0.method_21();
	}

	private void method_0(object sender, EventArgs e)
	{
		if (!string.IsNullOrWhiteSpace(control6_0.method_13()))
		{
			DialogResult = DialogResult.OK;
			Close();
		}
	}

	private void Form30_Resize(object sender, EventArgs e)
	{
		control6_0.Size = ClientSize;
		themedButton_1.Left = ClientSize.Width - 9 - themedButton_1.Width;
		themedButton_1.Top = ClientSize.Height - 8 - themedButton_1.Height;
		themedButton_0.Left = themedButton_1.Left - 9 - themedButton_0.Width;
		themedButton_0.Top = themedButton_1.Top;
	}

	private void method_1(object sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
		Close();
	}

	private void Form30_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form23.smethod_8(method_1);
		if (DialogResult == DialogResult.OK)
		{
			if (string.IsNullOrWhiteSpace(control6_0.method_13()))
			{
				Form54.smethod_6(this, Class333.smethod_2151(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Cancel = true;
			}
			else if (method_2())
			{
				control6_0.method_23();
			}
			else
			{
				e.Cancel = true;
			}
		}
	}

	private bool method_2()
	{
		if (!string.IsNullOrWhiteSpace(control6_0.method_13()) && control6_0.method_13() != Class333.smethod_563())
		{
			if (menuNode_0.method_37() && menuNode_0.method_1().awP.method_79()[menuNode_0.method_39()].method_73() == 0)
			{
				return true;
			}
			Class286 @class = null;
			lock (Form23.object_0)
			{
				if (Form23.dictionary_1.ContainsKey(control6_0.method_13()))
				{
					@class = Form23.dictionary_1[control6_0.method_13()].BcF;
				}
			}
			if (@class != null)
			{
				List<Setting> list = @class.method_8(menuNode_0, bool_0: true, bool_1: true);
				List<Setting> list2 = new List<Setting>();
				foreach (Setting item in list)
				{
					if (!item.method_35())
					{
						continue;
					}
					int[] array = @class.method_3(item);
					bool flag = false;
					if (array != null)
					{
						int num = Math.Min(item.method_277(), array.Length);
						if (item.method_6() != null)
						{
							if (item.method_6() is Table)
							{
								Table table = item.method_6() as Table;
								if (table.method_35() && item == table.TableDataSetting)
								{
									int num2 = table.ColumnCount();
									int num3 = table.RowCount();
									int num4 = table.SliceCount();
									for (int i = 0; i < num4; i++)
									{
										for (int j = 0; j < num3; j++)
										{
											for (int k = 0; k < num2; k++)
											{
												int num5 = item.method_250(k, j, i);
												if (num5 >= array.Length || item.method_258(num5) != array[num5])
												{
													flag = true;
													break;
												}
											}
											if (flag)
											{
												break;
											}
										}
										if (flag)
										{
											break;
										}
									}
								}
							}
							else
							{
								if (item.method_6() is TableAxis && item.method_6().method_6() is Table)
								{
									Table obj = item.method_6().method_6() as Table;
									TableAxis tableAxis = item.method_6() as TableAxis;
									if (obj.method_35() && tableAxis.method_35() && item == tableAxis.method_89() && tableAxis.method_88() != null)
									{
										num = Math.Min(num, tableAxis.method_88().method_256());
									}
								}
								else if (item.method_6() is SensorCalibration)
								{
									SensorCalibration sensorCalibration = item.method_6() as SensorCalibration;
									if (sensorCalibration.method_35() && (item == sensorCalibration.CalibrationValuesSetting || item == sensorCalibration.CalibrationVoltagesSetting) && sensorCalibration.CalibrationValueCountSetting != null)
									{
										num = Math.Min(num, sensorCalibration.CalibrationValueCountSetting.method_256());
									}
								}
								for (int l = 0; l < num; l++)
								{
									if (item.method_258(l) != array[l])
									{
										flag = true;
										break;
									}
								}
							}
						}
						else
						{
							for (int m = 0; m < num; m++)
							{
								if (item.method_258(m) != array[m])
								{
									flag = true;
									break;
								}
							}
						}
					}
					if (flag)
					{
						list2.Add(item);
					}
				}
				if (list2.Count != 0)
				{
					if (menuNode_0.method_37())
					{
						if (Form54.smethod_6(this, Class333.smethod_2152(), Class333.smethod_2153(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
						{
							return false;
						}
					}
					else
					{
						string string_ = string.Empty;
						List<Setting> list_ = new List<Setting>();
						method_3(ref string_, list2, list_);
						method_4(ref string_, list2, list_);
						method_5(ref string_, list2, list_);
						method_6(ref string_, list2, list_);
						if (Form54.smethod_6(this, string_, Class333.smethod_2153(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
						{
							return false;
						}
					}
				}
			}
		}
		return true;
	}

	private void method_3(ref string string_0, List<Setting> list_0, List<Setting> list_1)
	{
		bool flag = false;
		foreach (Setting item in list_0)
		{
			if (item.method_6() == null || (!(item.method_6() is Table) && !(item.method_6() is TableAxis)))
			{
				continue;
			}
			if (item.method_6() is Table && item == (item.method_6() as Table).TableDataSetting)
			{
				Table table = item.method_6() as Table;
				if (!flag)
				{
					string_0 += Class333.smethod_2154();
					flag = true;
				}
				string text = table.method_60(Enum96.aYt);
				if (string.IsNullOrWhiteSpace(text))
				{
					text = table.method_2();
				}
				string_0 = string_0 + Class333.smethod_2155() + text;
			}
			list_1.Add(item);
		}
	}

	private void method_4(ref string string_0, List<Setting> list_0, List<Setting> list_1)
	{
		bool flag = false;
		foreach (Setting item in list_0)
		{
			if (!(item.method_6() is SensorCalibration))
			{
				continue;
			}
			SensorCalibration sensorCalibration = item.method_6() as SensorCalibration;
			if ((item == sensorCalibration.CalibrationValuesSetting || item == sensorCalibration.CalibrationVoltagesSetting || item == sensorCalibration.CalibrationValueCountSetting) && !list_1.Contains(sensorCalibration.CalibrationValuesSetting) && !list_1.Contains(sensorCalibration.CalibrationVoltagesSetting) && !list_1.Contains(sensorCalibration.CalibrationValueCountSetting))
			{
				if (!flag)
				{
					if (!string.IsNullOrWhiteSpace(string_0))
					{
						string_0 += Class333.smethod_1812();
					}
					string_0 += Class333.smethod_2156();
					flag = true;
				}
				string text = sensorCalibration.method_60(Enum96.aYt);
				if (string.IsNullOrWhiteSpace(text))
				{
					text = sensorCalibration.method_2();
				}
				string_0 = string_0 + Class333.smethod_2155() + text;
			}
			list_1.Add(item);
		}
	}

	private void method_5(ref string string_0, List<Setting> list_0, List<Setting> list_1)
	{
		bool flag = false;
		foreach (Setting item in list_0)
		{
			if (!(item is Class244))
			{
				continue;
			}
			if (!flag)
			{
				if (!string.IsNullOrWhiteSpace(string_0))
				{
					string_0 += Class333.smethod_1812();
				}
				string_0 += Class333.smethod_2157();
				flag = true;
			}
			string text = item.method_60(Enum96.aYt);
			if (string.IsNullOrWhiteSpace(text))
			{
				text = item.method_2();
			}
			string_0 = string_0 + Class333.smethod_2155() + text;
			list_1.Add(item);
		}
	}

	private void method_6(ref string string_0, List<Setting> list_0, List<Setting> list_1)
	{
		bool flag = false;
		foreach (Setting item in list_0)
		{
			if (list_1.Contains(item))
			{
				continue;
			}
			if (!flag)
			{
				if (!string.IsNullOrWhiteSpace(string_0))
				{
					string_0 += Class333.smethod_1812();
				}
				string_0 += Class333.smethod_2158();
				flag = true;
			}
			string text = item.method_60(Enum96.aYt);
			if (string.IsNullOrWhiteSpace(text))
			{
				text = item.method_2();
			}
			string_0 = string_0 + Class333.smethod_2155() + text;
			list_1.Add(item);
		}
	}

	protected override void Dispose(bool disposing)
	{
		control6_0.method_15(method_0);
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_7()
	{
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		control6_0 = new Control6();
		SuspendLayout();
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Font = new Font(Class333.smethod_145(), 9.5f);
		themedButton_0.Location = new Point(896, 577);
		themedButton_0.Name = Class333.smethod_829();
		themedButton_0.Size = new Size(135, 36);
		themedButton_0.TabIndex = 5;
		themedButton_0.Text = Class333.smethod_821();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.Cancel;
		themedButton_1.Font = new Font(Class333.smethod_145(), 9.5f);
		themedButton_1.Location = new Point(1040, 577);
		themedButton_1.Name = Class333.smethod_830();
		themedButton_1.Size = new Size(135, 36);
		themedButton_1.TabIndex = 6;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		control6_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		control6_0.Location = new Point(0, 0);
		control6_0.Name = Class333.smethod_2159();
		control6_0.Size = new Size(1184, 621);
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		ClientSize = new Size(1184, 621);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Controls.Add(control6_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		MinimizeBox = false;
		Name = Class333.smethod_2160();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_2161();
		FormClosing += Form30_FormClosing;
		Shown += Form30_Shown;
		Resize += Form30_Resize;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
