using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns5;
using ns7;

namespace ns4;

internal class Form35 : Form
{
	private const int int_0 = 16;

	private bool bool_0 = true;

	private IContainer icontainer_0;

	private DataGridView dataGridView_0;

	private CheckBox checkBox_0;

	private CheckBox checkBox_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

	private Timer timer_0;

	private TextBox textBox_0;

	private Button button_0;

	private Button button_1;

	private Button button_2;

	private ComboBox comboBox_0;

	private DataGridView dataGridView_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	internal Form35()
	{
		bool_0 = true;
		method_4();
		Form23.smethod_7(method_0);
		typeof(DataGridView).InvokeMember(Class333.smethod_741(), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty, null, dataGridView_0, new object[1] { true });
		typeof(DataGridView).InvokeMember(Class333.smethod_741(), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty, null, dataGridView_1, new object[1] { true });
		dataGridView_0.RowCount = Form23.framework_1.method_21().Length / 16;
		dataGridView_1.RowCount = Form23.framework_1.method_23().Length / 16;
		comboBox_0.SelectedIndex = 0;
		bool_0 = false;
		timer_0.Enabled = true;
		timer_0.Start();
	}

	private void Form35_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form23.smethod_8(method_0);
	}

	private void method_0(object sender, EventArgs e)
	{
		Close();
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			if (comboBox_0.SelectedIndex == 0)
			{
				dataGridView_0.Visible = true;
				dataGridView_1.Visible = false;
			}
			else
			{
				dataGridView_0.Visible = false;
				dataGridView_1.Visible = true;
			}
		}
	}

	private void dataGridView_0_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
	{
		int num = e.RowIndex * 16 + e.ColumnIndex;
		Setting setting = Form23.framework_1.method_34(num);
		if (setting != null)
		{
			e.ToolTipText = Class333.smethod_2203() + (num - setting.method_65()) + Class333.smethod_2204() + setting.method_60(Enum96.aYt) + Class333.smethod_2205() + setting.method_64() + Class333.smethod_2206() + setting.method_67();
		}
		else
		{
			e.ToolTipText = Class333.smethod_2207();
		}
	}

	private void dataGridView_1_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
	{
		int num = e.RowIndex * 16 + e.ColumnIndex;
		Setting setting = Form23.framework_1.method_35(num);
		if (setting != null)
		{
			e.ToolTipText = Class333.smethod_2203() + (num - setting.method_65()) + Class333.smethod_2204() + setting.method_60(Enum96.aYt) + Class333.smethod_2205() + setting.method_64();
		}
		else
		{
			e.ToolTipText = Class333.smethod_2208();
		}
	}

	private void dataGridView_0_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
	{
		if (e.ColumnIndex == 0)
		{
			int num = e.RowIndex * 16;
			Setting setting = Form23.framework_1.method_34(num);
			string text = Class333.smethod_102();
			if (setting != null)
			{
				text = setting.method_60(Enum96.aYT) + Class333.smethod_2209();
			}
			if (checkBox_0.Checked)
			{
				dataGridView_0.Rows[e.RowIndex].HeaderCell.Value = text + string.Format(Class333.smethod_2210(), num);
			}
			else
			{
				dataGridView_0.Rows[e.RowIndex].HeaderCell.Value = text + num;
			}
		}
		int num2 = e.RowIndex * 16 + e.ColumnIndex;
		if (checkBox_1.Checked)
		{
			e.Value = string.Format(Class333.smethod_80(), Form23.framework_1.method_21()[num2]);
		}
		else
		{
			e.Value = Form23.framework_1.method_21()[num2].ToString();
		}
		if (Form23.framework_1.method_34(num2) == null)
		{
			dataGridView_0.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightPink;
		}
		else if (dataGridView_0.CurrentCell != null)
		{
			int rowIndex = dataGridView_0.CurrentCell.RowIndex;
			int columnIndex = dataGridView_0.CurrentCell.ColumnIndex;
			int num3 = rowIndex * 16 + columnIndex;
			Setting setting2 = Form23.framework_1.method_34(num3);
			if (setting2 != null)
			{
				if (num2 >= setting2.method_65() && num2 < setting2.method_65() + setting2.method_278())
				{
					dataGridView_0.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGreen;
				}
				else
				{
					dataGridView_0.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
				}
			}
			else
			{
				dataGridView_0.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
			}
		}
		else
		{
			dataGridView_0.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
		}
	}

	private void dataGridView_1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
	{
		if (e.ColumnIndex == 0)
		{
			int num = e.RowIndex * 16;
			Setting setting = Form23.framework_1.method_35(num);
			string text = Class333.smethod_102();
			if (setting != null)
			{
				text = setting.method_60(Enum96.aYT) + Class333.smethod_2209();
			}
			if (checkBox_0.Checked)
			{
				dataGridView_1.Rows[e.RowIndex].HeaderCell.Value = text + string.Format(Class333.smethod_2210(), num);
			}
			else
			{
				dataGridView_1.Rows[e.RowIndex].HeaderCell.Value = text + num;
			}
		}
		int num2 = e.RowIndex * 16 + e.ColumnIndex;
		if (checkBox_1.Checked)
		{
			e.Value = string.Format(Class333.smethod_80(), Form23.framework_1.method_23()[num2]);
		}
		else
		{
			e.Value = Form23.framework_1.method_23()[num2].ToString();
		}
		if (Form23.framework_1.method_35(num2) == null)
		{
			dataGridView_1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightPink;
		}
		else if (dataGridView_1.CurrentCell != null)
		{
			int rowIndex = dataGridView_1.CurrentCell.RowIndex;
			int columnIndex = dataGridView_1.CurrentCell.ColumnIndex;
			int num3 = rowIndex * 16 + columnIndex;
			Setting setting2 = Form23.framework_1.method_35(num3);
			if (setting2 != null)
			{
				if (num2 >= setting2.method_65() && num2 < setting2.method_65() + setting2.method_278())
				{
					dataGridView_1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGreen;
				}
				else
				{
					dataGridView_1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
				}
			}
			else
			{
				dataGridView_1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
			}
		}
		else
		{
			dataGridView_1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
		}
	}

	private void dataGridView_0_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
	{
		bool flag = false;
		if ((!checkBox_1.Checked) ? byte.TryParse(e.Value as string, out var result) : byte.TryParse(e.Value as string, NumberStyles.AllowHexSpecifier, null, out result))
		{
			int num = e.RowIndex * 16 + e.ColumnIndex;
			Setting setting = Form23.framework_1.method_34(num);
			if (setting != null)
			{
				setting.method_270(num - setting.method_65(), result, bool_0: true);
				Form23.smethod_75(setting.method_69());
			}
			else
			{
				Form23.framework_1.method_21()[num] = result;
				Form23.framework_1.method_22()[num] = Enum93.aYK;
				Form23.framework_1.aXd = true;
			}
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_605(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		timer_0.Stop();
		timer_0.Enabled = false;
		if (comboBox_0.SelectedIndex == 0)
		{
			for (int i = 0; i < 16; i++)
			{
				if (checkBox_0.Checked)
				{
					dataGridView_0.Columns[i].HeaderCell.Value = string.Format(Class333.smethod_2211(), i);
				}
				else
				{
					dataGridView_0.Columns[i].HeaderCell.Value = i.ToString();
				}
			}
			for (int j = 0; j < dataGridView_0.Rows.Count; j++)
			{
				int num = j * 16;
				Setting setting = Form23.framework_1.method_34(num);
				string text = Class333.smethod_102();
				if (setting != null)
				{
					text = setting.method_60(Enum96.aYT) + Class333.smethod_2209();
				}
				if (checkBox_0.Checked)
				{
					dataGridView_0.Rows[j].HeaderCell.Value = text + string.Format(Class333.smethod_2210(), num);
				}
				else
				{
					dataGridView_0.Rows[j].HeaderCell.Value = text + num;
				}
			}
		}
		else
		{
			for (int k = 0; k < 16; k++)
			{
				if (checkBox_0.Checked)
				{
					dataGridView_1.Columns[k].HeaderCell.Value = string.Format(Class333.smethod_2211(), k);
				}
				else
				{
					dataGridView_1.Columns[k].HeaderCell.Value = k.ToString();
				}
			}
			for (int l = 0; l < dataGridView_1.Rows.Count; l++)
			{
				int num2 = l * 16;
				Setting setting2 = Form23.framework_1.method_35(num2);
				string text2 = Class333.smethod_102();
				if (setting2 != null)
				{
					text2 = setting2.method_60(Enum96.aYT) + Class333.smethod_2209();
				}
				if (checkBox_0.Checked)
				{
					dataGridView_1.Rows[l].HeaderCell.Value = text2 + string.Format(Class333.smethod_2210(), num2);
				}
				else
				{
					dataGridView_1.Rows[l].HeaderCell.Value = text2 + num2;
				}
			}
		}
		timer_0.Enabled = true;
		timer_0.Start();
	}

	private void checkBox_1_CheckedChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			dataGridView_1_SelectionChanged(null, null);
		}
	}

	private void Form35_Resize(object sender, EventArgs e)
	{
		dataGridView_0.Height = ClientSize.Height - (dataGridView_0.Top + 10);
		dataGridView_1.Height = dataGridView_0.Height;
	}

	private void dataGridView_1_SelectionChanged(object sender, EventArgs e)
	{
		if (comboBox_0.SelectedIndex == 0)
		{
			dataGridView_0.Refresh();
			if (dataGridView_0.CurrentCell == null)
			{
				label_0.Text = Class333.smethod_325();
				label_1.Text = Class333.smethod_325();
				label_2.Text = Class333.smethod_325();
				return;
			}
			int rowIndex = dataGridView_0.CurrentCell.RowIndex;
			int columnIndex = dataGridView_0.CurrentCell.ColumnIndex;
			int num = rowIndex * 16 + columnIndex;
			Setting setting = Form23.framework_1.method_34(num);
			if (setting != null)
			{
				string text = setting.method_60(Enum96.aYT);
				if (text != null)
				{
					label_0.Text = Class333.smethod_2212() + text + Class333.smethod_2213() + setting.method_64() + Class333.smethod_2214() + setting.method_67();
				}
				else
				{
					label_0.Text = Class333.smethod_2212() + setting.method_60(Enum96.aYt) + Class333.smethod_2213() + setting.method_64() + Class333.smethod_2214() + setting.method_67();
				}
				string text2 = ((!checkBox_0.Checked) ? setting.method_65().ToString() : string.Format(Class333.smethod_2210(), setting.method_65()));
				label_1.Text = setting.method_277() + Class333.smethod_2215() + setting.method_199() + Class333.smethod_2216() + text2;
				int num2 = (num - setting.method_65()) / setting.method_199();
				int num3 = setting.method_258(num2);
				label_2.Text = setting.method_199() + Class333.smethod_2217() + num3 + Class333.smethod_2218();
			}
			else
			{
				label_0.Text = Class333.smethod_2219();
				label_1.Text = Class333.smethod_325();
				label_2.Text = Class333.smethod_325();
			}
			return;
		}
		dataGridView_1.Refresh();
		if (dataGridView_1.CurrentCell == null)
		{
			label_0.Text = Class333.smethod_325();
			label_1.Text = Class333.smethod_325();
			label_2.Text = Class333.smethod_325();
			return;
		}
		int rowIndex2 = dataGridView_1.CurrentCell.RowIndex;
		int columnIndex2 = dataGridView_1.CurrentCell.ColumnIndex;
		int num4 = rowIndex2 * 16 + columnIndex2;
		Setting setting2 = Form23.framework_1.method_35(num4);
		if (setting2 != null)
		{
			string text3 = setting2.method_60(Enum96.aYT);
			if (text3 != null)
			{
				label_0.Text = Class333.smethod_2220() + text3 + Class333.smethod_2213() + setting2.method_64();
			}
			else
			{
				label_0.Text = Class333.smethod_2220() + setting2.method_60(Enum96.aYt) + Class333.smethod_2213() + setting2.method_64();
			}
			string text4 = ((!checkBox_0.Checked) ? setting2.method_65().ToString() : string.Format(Class333.smethod_2210(), setting2.method_65()));
			label_1.Text = setting2.method_277() + Class333.smethod_2215() + setting2.method_199() + Class333.smethod_2216() + text4;
			int num5 = (num4 - setting2.method_65()) / setting2.method_199();
			int num6 = setting2.method_258(num5);
			label_2.Text = setting2.method_199() + Class333.smethod_2217() + num6 + Class333.smethod_2218();
		}
		else
		{
			label_0.Text = Class333.smethod_2221();
			label_1.Text = Class333.smethod_325();
			label_2.Text = Class333.smethod_325();
		}
	}

	private void method_1(int int_1)
	{
		try
		{
			int num = int_1 / 16;
			if (comboBox_0.SelectedIndex == 0)
			{
				dataGridView_0.FirstDisplayedScrollingRowIndex = num;
				int num2 = num * 16;
				for (int i = 0; i < dataGridView_0.RowCount; i++)
				{
					for (int j = 0; j < dataGridView_0.ColumnCount; j++)
					{
						dataGridView_0.Rows[i].Cells[j].Selected = false;
					}
				}
				dataGridView_0.CurrentCell = dataGridView_0.Rows[num].Cells[int_1 - num2];
				dataGridView_0.Rows[num].Cells[int_1 - num2].Selected = true;
				return;
			}
			dataGridView_1.FirstDisplayedScrollingRowIndex = num;
			int num3 = num * 16;
			for (int k = 0; k < dataGridView_1.RowCount; k++)
			{
				for (int l = 0; l < dataGridView_1.ColumnCount; l++)
				{
					dataGridView_1.Rows[k].Cells[l].Selected = false;
				}
			}
			dataGridView_1.CurrentCell = dataGridView_1.Rows[num].Cells[int_1 - num3];
			dataGridView_1.Rows[num].Cells[int_1 - num3].Selected = true;
		}
		catch
		{
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		bool flag = false;
		if ((!checkBox_0.Checked) ? int.TryParse(textBox_0.Text, out var result) : int.TryParse(textBox_0.Text, NumberStyles.AllowHexSpecifier, null, out result))
		{
			method_1(result);
		}
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		if (int.TryParse(textBox_0.Text, out var result))
		{
			Setting setting = Form23.framework_1.method_31(result);
			if (setting != null)
			{
				method_1(setting.method_65());
			}
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		try
		{
			if (!(textBox_0.Text != string.Empty))
			{
				return;
			}
			string[] array = textBox_0.Text.Split(' ', ',');
			List<string> list = new List<string>();
			for (int i = 0; i < array.Length; i++)
			{
				list.Add(array[i].ToLower());
			}
			List<SettingOrSpecialObject> list2 = new List<SettingOrSpecialObject>();
			method_2(Form23.framework_1.aWS, list, list2);
			if (list2.Count == 1)
			{
				if (list2[0] is Setting)
				{
					method_1((list2[0] as Setting).method_65());
				}
			}
			else
			{
				if (list2.Count == 0)
				{
					return;
				}
				Form form = new Form();
				form.FormBorderStyle = FormBorderStyle.FixedDialog;
				form.Text = Class333.smethod_2222();
				form.StartPosition = FormStartPosition.CenterParent;
				form.ShowIcon = false;
				form.ShowInTaskbar = false;
				form.Size = new Size(400, 500);
				form.AutoScroll = true;
				Button button = new Button();
				button.Text = Class333.smethod_821();
				button.DialogResult = DialogResult.OK;
				button.Location = new Point(100, 10);
				Button button2 = new Button();
				button2.Text = Class333.smethod_823();
				button2.DialogResult = DialogResult.Cancel;
				button2.Location = new Point(200, 10);
				form.Controls.Add(button);
				form.Controls.Add(button2);
				form.AcceptButton = button;
				form.CancelButton = button2;
				GroupBox groupBox = new GroupBox();
				groupBox.Location = new Point(10, 40);
				groupBox.MinimumSize = new Size(form.ClientRectangle.Width - 20, 0);
				groupBox.MaximumSize = new Size(form.ClientRectangle.Width - 20, 0);
				groupBox.AutoSize = true;
				groupBox.SuspendLayout();
				int num = 10;
				foreach (SettingOrSpecialObject item in list2)
				{
					RadioButton radioButton = new RadioButton();
					radioButton.AutoSize = true;
					radioButton.Tag = item;
					radioButton.Text = item.method_60(Enum96.aYt);
					radioButton.Location = new Point(10, num);
					num += radioButton.Height;
					groupBox.Controls.Add(radioButton);
				}
				groupBox.ResumeLayout(performLayout: true);
				form.Controls.Add(groupBox);
				if (form.ShowDialog(this) == DialogResult.OK)
				{
					foreach (Control control in groupBox.Controls)
					{
						if (control is RadioButton && (control as RadioButton).Checked)
						{
							if ((control as RadioButton).Tag is Setting)
							{
								method_1(((control as RadioButton).Tag as Setting).method_65());
							}
							break;
						}
					}
				}
				form.Dispose();
			}
		}
		catch
		{
		}
	}

	private void method_2(List<SettingOrSpecialObject> list_0, List<string> list_1, List<SettingOrSpecialObject> list_2)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = list_0[i];
			if (settingOrSpecialObject is Setting)
			{
				Setting setting = settingOrSpecialObject as Setting;
				if ((comboBox_0.SelectedIndex == 0 && !setting.method_207()) || (comboBox_0.SelectedIndex == 1 && setting.method_207()))
				{
					bool flag = true;
					for (int j = 0; j < list_1.Count; j++)
					{
						string text = setting.method_60(Enum96.aYT);
						if (text == null || !text.ToLower().Contains(list_1[j]))
						{
							string text2 = setting.method_60(Enum96.aYt);
							if (text2 == null || !text2.ToLower().Contains(list_1[j]))
							{
								flag = false;
								break;
							}
						}
					}
					if (flag)
					{
						list_2.Add(setting);
					}
				}
			}
			if (list_2.Count >= 100)
			{
				break;
			}
			method_2(settingOrSpecialObject.method_1(), list_1, list_2);
		}
		if (list_0 == Form23.framework_1.aWS && list_2.Count >= 100)
		{
			Form54.smethod_6(this, Class333.smethod_2223(), Class333.smethod_2224(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	private void method_3()
	{
		try
		{
			if (!Clipboard.ContainsText())
			{
				return;
			}
			string text = Clipboard.GetText();
			int num = text.Split('\n').Length;
			int num2 = 0;
			int num3 = 0;
			while (true)
			{
				if (num3 < num)
				{
					int num4 = text.Split('\n')[num3].Split('\t').Length;
					if (num3 == 0)
					{
						num2 = num4;
					}
					else if (num4 != num2)
					{
						throw new Exception();
					}
					num3++;
					continue;
				}
				int num5 = int.MaxValue;
				int num6 = int.MinValue;
				int num7 = int.MaxValue;
				int num8 = int.MinValue;
				if (comboBox_0.SelectedIndex == 0)
				{
					foreach (DataGridViewCell selectedCell in dataGridView_0.SelectedCells)
					{
						num5 = Math.Min(num5, selectedCell.ColumnIndex);
						num6 = Math.Max(num6, selectedCell.ColumnIndex);
						num7 = Math.Min(num7, selectedCell.RowIndex);
						num8 = Math.Max(num8, selectedCell.RowIndex);
					}
				}
				else
				{
					foreach (DataGridViewCell selectedCell2 in dataGridView_1.SelectedCells)
					{
						num5 = Math.Min(num5, selectedCell2.ColumnIndex);
						num6 = Math.Max(num6, selectedCell2.ColumnIndex);
						num7 = Math.Min(num7, selectedCell2.RowIndex);
						num8 = Math.Max(num8, selectedCell2.RowIndex);
					}
				}
				if ((num5 == num6 && num7 == num8) || (1 + num6 - num5 == num2 && 1 + num8 - num7 == num))
				{
					bool enabled = timer_0.Enabled;
					timer_0.Stop();
					timer_0.Enabled = false;
					for (int i = 0; i < num; i++)
					{
						for (int j = 0; j < num2; j++)
						{
							string text2 = text.Split('\n')[i].Split('\t')[j];
							if (text2.EndsWith(Class333.smethod_2225()))
							{
								text2 = text2.Substring(0, text2.Length - 1);
							}
							if (comboBox_0.SelectedIndex == 0)
							{
								dataGridView_0.Rows[num7 + i].Cells[num5 + j].Value = text2;
							}
							else
							{
								dataGridView_1.Rows[num7 + i].Cells[num5 + j].Value = text2;
							}
						}
					}
					if (enabled)
					{
						timer_0.Enabled = true;
						timer_0.Start();
					}
				}
				else
				{
					Form54.smethod_6(this, Class333.smethod_2226(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				break;
			}
		}
		catch
		{
		}
	}

	private void dataGridView_0_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyData == (Keys.V | Keys.Control))
		{
			method_3();
		}
	}

	private void dataGridView_1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyData == (Keys.V | Keys.Control))
		{
			method_3();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_4()
	{
		icontainer_0 = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
		dataGridView_0 = new DataGridView();
		dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
		checkBox_0 = new CheckBox();
		checkBox_1 = new CheckBox();
		timer_0 = new Timer(icontainer_0);
		textBox_0 = new TextBox();
		button_0 = new Button();
		button_1 = new Button();
		button_2 = new Button();
		comboBox_0 = new ComboBox();
		dataGridView_1 = new DataGridView();
		dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		((ISupportInitialize)dataGridView_0).BeginInit();
		((ISupportInitialize)dataGridView_1).BeginInit();
		SuspendLayout();
		dataGridView_0.AllowUserToAddRows = false;
		dataGridView_0.AllowUserToDeleteRows = false;
		dataGridView_0.AllowUserToResizeColumns = false;
		dataGridView_0.AllowUserToResizeRows = false;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dataGridViewCellStyle.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.Format = Class333.smethod_2227();
		dataGridViewCellStyle.NullValue = null;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.False;
		dataGridView_0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		dataGridView_0.BackgroundColor = Color.White;
		dataGridView_0.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
		dataGridView_0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
		dataGridViewCellStyle2.BackColor = Color.White;
		dataGridViewCellStyle2.Font = new Font(Class333.smethod_145(), 8.25f);
		dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle2.Format = Class333.smethod_2227();
		dataGridViewCellStyle2.NullValue = null;
		dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
		dataGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_0.Columns.AddRange(dataGridViewTextBoxColumn_0, dataGridViewTextBoxColumn_1, dataGridViewTextBoxColumn_2, dataGridViewTextBoxColumn_3, dataGridViewTextBoxColumn_4, dataGridViewTextBoxColumn_5, dataGridViewTextBoxColumn_6, dataGridViewTextBoxColumn_7, dataGridViewTextBoxColumn_8, dataGridViewTextBoxColumn_9, dataGridViewTextBoxColumn_10, dataGridViewTextBoxColumn_11, dataGridViewTextBoxColumn_12, dataGridViewTextBoxColumn_13, dataGridViewTextBoxColumn_14, dataGridViewTextBoxColumn_15);
		dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
		dataGridViewCellStyle3.BackColor = Color.White;
		dataGridViewCellStyle3.Font = new Font(Class333.smethod_145(), 8.25f);
		dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle3.Format = Class333.smethod_2227();
		dataGridViewCellStyle3.NullValue = null;
		dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
		dataGridView_0.DefaultCellStyle = dataGridViewCellStyle3;
		dataGridView_0.EditMode = DataGridViewEditMode.EditOnKeystroke;
		dataGridView_0.GridColor = Color.Black;
		dataGridView_0.Location = new Point(12, 52);
		dataGridView_0.Name = Class333.smethod_2228();
		dataGridView_0.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
		dataGridViewCellStyle4.BackColor = Color.White;
		dataGridViewCellStyle4.Font = new Font(Class333.smethod_145(), 8.25f);
		dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle4.Format = Class333.smethod_2227();
		dataGridViewCellStyle4.NullValue = null;
		dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
		dataGridView_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		dataGridView_0.RowHeadersWidth = 500;
		dataGridView_0.SelectionMode = DataGridViewSelectionMode.CellSelect;
		dataGridView_0.ShowCellErrors = false;
		dataGridView_0.ShowRowErrors = false;
		dataGridView_0.Size = new Size(960, 447);
		dataGridView_0.TabIndex = 7;
		dataGridView_0.VirtualMode = true;
		dataGridView_0.CellToolTipTextNeeded += dataGridView_0_CellToolTipTextNeeded;
		dataGridView_0.CellValueNeeded += dataGridView_0_CellValueNeeded;
		dataGridView_0.CellValuePushed += dataGridView_0_CellValuePushed;
		dataGridView_0.CurrentCellChanged += dataGridView_1_SelectionChanged;
		dataGridView_0.SelectionChanged += dataGridView_1_SelectionChanged;
		dataGridView_0.KeyDown += dataGridView_0_KeyDown;
		dataGridViewTextBoxColumn_0.HeaderText = Class333.smethod_184();
		dataGridViewTextBoxColumn_0.Name = Class333.smethod_2229();
		dataGridViewTextBoxColumn_0.Width = 27;
		dataGridViewTextBoxColumn_1.HeaderText = Class333.smethod_227();
		dataGridViewTextBoxColumn_1.Name = Class333.smethod_2230();
		dataGridViewTextBoxColumn_1.Width = 27;
		dataGridViewTextBoxColumn_2.HeaderText = Class333.smethod_264();
		dataGridViewTextBoxColumn_2.Name = Class333.smethod_2231();
		dataGridViewTextBoxColumn_2.Width = 27;
		dataGridViewTextBoxColumn_3.HeaderText = Class333.smethod_262();
		dataGridViewTextBoxColumn_3.Name = Class333.smethod_2232();
		dataGridViewTextBoxColumn_3.Width = 27;
		dataGridViewTextBoxColumn_4.HeaderText = Class333.smethod_260();
		dataGridViewTextBoxColumn_4.Name = Class333.smethod_2233();
		dataGridViewTextBoxColumn_4.Width = 27;
		dataGridViewTextBoxColumn_5.HeaderText = Class333.smethod_258();
		dataGridViewTextBoxColumn_5.Name = Class333.smethod_2234();
		dataGridViewTextBoxColumn_5.Width = 27;
		dataGridViewTextBoxColumn_6.HeaderText = Class333.smethod_256();
		dataGridViewTextBoxColumn_6.Name = Class333.smethod_2235();
		dataGridViewTextBoxColumn_6.Width = 27;
		dataGridViewTextBoxColumn_7.HeaderText = Class333.smethod_254();
		dataGridViewTextBoxColumn_7.Name = Class333.smethod_2236();
		dataGridViewTextBoxColumn_7.Width = 27;
		dataGridViewTextBoxColumn_8.HeaderText = Class333.smethod_2237();
		dataGridViewTextBoxColumn_8.Name = Class333.smethod_2238();
		dataGridViewTextBoxColumn_8.Width = 27;
		dataGridViewTextBoxColumn_9.HeaderText = Class333.smethod_2239();
		dataGridViewTextBoxColumn_9.Name = Class333.smethod_2240();
		dataGridViewTextBoxColumn_9.Width = 27;
		dataGridViewTextBoxColumn_10.HeaderText = Class333.smethod_1331();
		dataGridViewTextBoxColumn_10.Name = Class333.smethod_2241();
		dataGridViewTextBoxColumn_10.Width = 27;
		dataGridViewTextBoxColumn_11.HeaderText = Class333.smethod_2242();
		dataGridViewTextBoxColumn_11.Name = Class333.smethod_2243();
		dataGridViewTextBoxColumn_11.Width = 27;
		dataGridViewTextBoxColumn_12.HeaderText = Class333.smethod_2244();
		dataGridViewTextBoxColumn_12.Name = Class333.smethod_2245();
		dataGridViewTextBoxColumn_12.Width = 27;
		dataGridViewTextBoxColumn_13.HeaderText = Class333.smethod_1285();
		dataGridViewTextBoxColumn_13.Name = Class333.smethod_2246();
		dataGridViewTextBoxColumn_13.Width = 27;
		dataGridViewTextBoxColumn_14.HeaderText = Class333.smethod_2247();
		dataGridViewTextBoxColumn_14.Name = Class333.smethod_2248();
		dataGridViewTextBoxColumn_14.Width = 27;
		dataGridViewTextBoxColumn_15.HeaderText = Class333.smethod_1320();
		dataGridViewTextBoxColumn_15.Name = Class333.smethod_2249();
		dataGridViewTextBoxColumn_15.Width = 27;
		checkBox_0.AutoSize = true;
		checkBox_0.Checked = true;
		checkBox_0.CheckState = CheckState.Checked;
		checkBox_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		checkBox_0.Location = new Point(12, 5);
		checkBox_0.Name = Class333.smethod_2250();
		checkBox_0.Size = new Size(113, 17);
		checkBox_0.TabIndex = 0;
		checkBox_0.Text = Class333.smethod_2251();
		checkBox_0.UseVisualStyleBackColor = true;
		checkBox_0.CheckedChanged += checkBox_0_CheckedChanged;
		checkBox_1.AutoSize = true;
		checkBox_1.Checked = true;
		checkBox_1.CheckState = CheckState.Checked;
		checkBox_1.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		checkBox_1.Location = new Point(12, 25);
		checkBox_1.Name = Class333.smethod_2252();
		checkBox_1.Size = new Size(94, 17);
		checkBox_1.TabIndex = 1;
		checkBox_1.Text = Class333.smethod_2253();
		checkBox_1.UseVisualStyleBackColor = true;
		checkBox_1.CheckedChanged += checkBox_1_CheckedChanged;
		timer_0.Interval = 1000;
		timer_0.Tick += dataGridView_1_SelectionChanged;
		textBox_0.BorderStyle = BorderStyle.FixedSingle;
		textBox_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_0.Location = new Point(418, 3);
		textBox_0.Name = Class333.smethod_590();
		textBox_0.Size = new Size(200, 22);
		textBox_0.TabIndex = 3;
		button_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button_0.Location = new Point(360, 27);
		button_0.Name = Class333.smethod_2254();
		button_0.Size = new Size(100, 23);
		button_0.TabIndex = 4;
		button_0.Text = Class333.smethod_2255();
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		button_1.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button_1.Location = new Point(467, 27);
		button_1.Name = Class333.smethod_2256();
		button_1.Size = new Size(100, 23);
		button_1.TabIndex = 5;
		button_1.Text = Class333.smethod_2257();
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		button_2.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button_2.Location = new Point(574, 27);
		button_2.Name = Class333.smethod_2258();
		button_2.Size = new Size(100, 23);
		button_2.TabIndex = 6;
		button_2.Text = Class333.smethod_2259();
		button_2.UseVisualStyleBackColor = true;
		button_2.Click += button_2_Click;
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Items.AddRange(Class333.smethod_2260(), Class333.smethod_2261());
		comboBox_0.Location = new Point(137, 15);
		comboBox_0.Name = Class333.smethod_2262();
		comboBox_0.Size = new Size(200, 21);
		comboBox_0.TabIndex = 2;
		comboBox_0.SelectedIndexChanged += comboBox_0_SelectedIndexChanged;
		dataGridView_1.AllowUserToAddRows = false;
		dataGridView_1.AllowUserToDeleteRows = false;
		dataGridView_1.AllowUserToResizeColumns = false;
		dataGridView_1.AllowUserToResizeRows = false;
		dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
		dataGridViewCellStyle5.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle5.Format = Class333.smethod_2227();
		dataGridViewCellStyle5.NullValue = null;
		dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
		dataGridView_1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
		dataGridView_1.BackgroundColor = Color.White;
		dataGridView_1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
		dataGridView_1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
		dataGridViewCellStyle6.BackColor = Color.White;
		dataGridViewCellStyle6.Font = new Font(Class333.smethod_145(), 8.25f);
		dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle6.Format = Class333.smethod_2227();
		dataGridViewCellStyle6.NullValue = null;
		dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
		dataGridView_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
		dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_1.Columns.AddRange(dataGridViewTextBoxColumn_16, dataGridViewTextBoxColumn_17, dataGridViewTextBoxColumn_18, dataGridViewTextBoxColumn_19, dataGridViewTextBoxColumn_20, dataGridViewTextBoxColumn_21, dataGridViewTextBoxColumn_22, dataGridViewTextBoxColumn_23, dataGridViewTextBoxColumn_24, dataGridViewTextBoxColumn_25, dataGridViewTextBoxColumn_26, dataGridViewTextBoxColumn_27, dataGridViewTextBoxColumn_28, dataGridViewTextBoxColumn_29, dataGridViewTextBoxColumn_30, dataGridViewTextBoxColumn_31);
		dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
		dataGridViewCellStyle7.BackColor = Color.White;
		dataGridViewCellStyle7.Font = new Font(Class333.smethod_145(), 8.25f);
		dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle7.Format = Class333.smethod_2227();
		dataGridViewCellStyle7.NullValue = null;
		dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
		dataGridView_1.DefaultCellStyle = dataGridViewCellStyle7;
		dataGridView_1.EditMode = DataGridViewEditMode.EditOnKeystroke;
		dataGridView_1.GridColor = Color.Black;
		dataGridView_1.Location = new Point(12, 52);
		dataGridView_1.Name = Class333.smethod_2263();
		dataGridView_1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
		dataGridViewCellStyle8.BackColor = Color.White;
		dataGridViewCellStyle8.Font = new Font(Class333.smethod_145(), 8.25f);
		dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle8.Format = Class333.smethod_2227();
		dataGridViewCellStyle8.NullValue = null;
		dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
		dataGridView_1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
		dataGridView_1.RowHeadersWidth = 500;
		dataGridView_1.SelectionMode = DataGridViewSelectionMode.CellSelect;
		dataGridView_1.ShowCellErrors = false;
		dataGridView_1.ShowRowErrors = false;
		dataGridView_1.Size = new Size(960, 447);
		dataGridView_1.TabIndex = 8;
		dataGridView_1.VirtualMode = true;
		dataGridView_1.Visible = false;
		dataGridView_1.CellToolTipTextNeeded += dataGridView_1_CellToolTipTextNeeded;
		dataGridView_1.CellValueNeeded += dataGridView_1_CellValueNeeded;
		dataGridView_1.CurrentCellChanged += dataGridView_1_SelectionChanged;
		dataGridView_1.SelectionChanged += dataGridView_1_SelectionChanged;
		dataGridView_1.KeyDown += dataGridView_1_KeyDown;
		dataGridViewTextBoxColumn_16.HeaderText = Class333.smethod_184();
		dataGridViewTextBoxColumn_16.Name = Class333.smethod_2264();
		dataGridViewTextBoxColumn_16.Width = 27;
		dataGridViewTextBoxColumn_17.HeaderText = Class333.smethod_227();
		dataGridViewTextBoxColumn_17.Name = Class333.smethod_2265();
		dataGridViewTextBoxColumn_17.Width = 27;
		dataGridViewTextBoxColumn_18.HeaderText = Class333.smethod_264();
		dataGridViewTextBoxColumn_18.Name = Class333.smethod_2266();
		dataGridViewTextBoxColumn_18.Width = 27;
		dataGridViewTextBoxColumn_19.HeaderText = Class333.smethod_262();
		dataGridViewTextBoxColumn_19.Name = Class333.smethod_2267();
		dataGridViewTextBoxColumn_19.Width = 27;
		dataGridViewTextBoxColumn_20.HeaderText = Class333.smethod_260();
		dataGridViewTextBoxColumn_20.Name = Class333.smethod_2268();
		dataGridViewTextBoxColumn_20.Width = 27;
		dataGridViewTextBoxColumn_21.HeaderText = Class333.smethod_258();
		dataGridViewTextBoxColumn_21.Name = Class333.smethod_2269();
		dataGridViewTextBoxColumn_21.Width = 27;
		dataGridViewTextBoxColumn_22.HeaderText = Class333.smethod_256();
		dataGridViewTextBoxColumn_22.Name = Class333.smethod_2270();
		dataGridViewTextBoxColumn_22.Width = 27;
		dataGridViewTextBoxColumn_23.HeaderText = Class333.smethod_254();
		dataGridViewTextBoxColumn_23.Name = Class333.smethod_2271();
		dataGridViewTextBoxColumn_23.Width = 27;
		dataGridViewTextBoxColumn_24.HeaderText = Class333.smethod_2237();
		dataGridViewTextBoxColumn_24.Name = Class333.smethod_2272();
		dataGridViewTextBoxColumn_24.Width = 27;
		dataGridViewTextBoxColumn_25.HeaderText = Class333.smethod_2239();
		dataGridViewTextBoxColumn_25.Name = Class333.smethod_2273();
		dataGridViewTextBoxColumn_25.Width = 27;
		dataGridViewTextBoxColumn_26.HeaderText = Class333.smethod_1331();
		dataGridViewTextBoxColumn_26.Name = Class333.smethod_2274();
		dataGridViewTextBoxColumn_26.Width = 27;
		dataGridViewTextBoxColumn_27.HeaderText = Class333.smethod_2242();
		dataGridViewTextBoxColumn_27.Name = Class333.smethod_2275();
		dataGridViewTextBoxColumn_27.Width = 27;
		dataGridViewTextBoxColumn_28.HeaderText = Class333.smethod_2244();
		dataGridViewTextBoxColumn_28.Name = Class333.smethod_2276();
		dataGridViewTextBoxColumn_28.Width = 27;
		dataGridViewTextBoxColumn_29.HeaderText = Class333.smethod_1285();
		dataGridViewTextBoxColumn_29.Name = Class333.smethod_2277();
		dataGridViewTextBoxColumn_29.Width = 27;
		dataGridViewTextBoxColumn_30.HeaderText = Class333.smethod_2247();
		dataGridViewTextBoxColumn_30.Name = Class333.smethod_2278();
		dataGridViewTextBoxColumn_30.Width = 27;
		dataGridViewTextBoxColumn_31.HeaderText = Class333.smethod_1320();
		dataGridViewTextBoxColumn_31.Name = Class333.smethod_2279();
		dataGridViewTextBoxColumn_31.Width = 27;
		label_0.Location = new Point(700, 4);
		label_0.Name = Class333.smethod_2280();
		label_0.Size = new Size(270, 13);
		label_0.TabIndex = 9;
		label_0.Text = Class333.smethod_304();
		label_1.Location = new Point(700, 19);
		label_1.Name = Class333.smethod_2281();
		label_1.Size = new Size(270, 13);
		label_1.TabIndex = 10;
		label_1.Text = Class333.smethod_2282();
		label_2.Location = new Point(700, 34);
		label_2.Name = Class333.smethod_2283();
		label_2.Size = new Size(270, 13);
		label_2.TabIndex = 11;
		label_2.Text = Class333.smethod_2284();
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(984, 511);
		Controls.Add(label_2);
		Controls.Add(label_1);
		Controls.Add(label_0);
		Controls.Add(dataGridView_1);
		Controls.Add(comboBox_0);
		Controls.Add(button_2);
		Controls.Add(button_1);
		Controls.Add(button_0);
		Controls.Add(textBox_0);
		Controls.Add(checkBox_1);
		Controls.Add(checkBox_0);
		Controls.Add(dataGridView_0);
		DoubleBuffered = true;
		Font = new Font(Class333.smethod_145(), 8.25f);
		Name = Class333.smethod_2285();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.Manual;
		Text = Class333.smethod_276();
		FormClosing += Form35_FormClosing;
		Resize += Form35_Resize;
		((ISupportInitialize)dataGridView_0).EndInit();
		((ISupportInitialize)dataGridView_1).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
