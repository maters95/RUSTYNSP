using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns0;
using ns4;
using ns7;

namespace NSP.UserInterface.Forms;

public class DTCManagerForm : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class207
	{
		public static readonly Class207 BPf = new Class207();

		public static Func<KeyValuePair<string, Dictionary<string, string>>, bool> BPG;

		public static Func<KeyValuePair<string, Dictionary<string, string>>, string> BPg;

		public static Func<KeyValuePair<string, Dictionary<string, string>>, Dictionary<string, string>> BPH;

		public static Func<KeyValuePair<string, Dictionary<string, string>>, bool> BPh;

		public static Func<KeyValuePair<string, Dictionary<string, string>>, string> BPI;

		public static Func<KeyValuePair<string, Dictionary<string, string>>, Dictionary<string, string>> BPi;

		internal bool method_0(KeyValuePair<string, Dictionary<string, string>> keyValuePair_0)
		{
			return !keyValuePair_0.Value.ContainsKey(Class333.smethod_1086());
		}

		internal string method_1(KeyValuePair<string, Dictionary<string, string>> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		internal Dictionary<string, string> method_2(KeyValuePair<string, Dictionary<string, string>> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}

		internal bool method_3(KeyValuePair<string, Dictionary<string, string>> keyValuePair_0)
		{
			return keyValuePair_0.Value.ContainsKey(Class333.smethod_1086());
		}

		internal string method_4(KeyValuePair<string, Dictionary<string, string>> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		internal Dictionary<string, string> method_5(KeyValuePair<string, Dictionary<string, string>> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}
	}

	private Framework framework_0;

	private DataTableObject dataTableObject_0;

	private ThemedDataTable themedDataTable_0;

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private ThemedButton themedButton_0;

	private TableLayoutPanel tableLayoutPanel_1;

	public DTCManagerForm(Framework framework, DataTableObject data)
	{
		method_3();
		BackColor = Form23.color_16;
		ForeColor = Form23.color_12;
		framework_0 = framework;
		Dictionary<string, Dictionary<string, string>> dictionary = data.Data.Where((KeyValuePair<string, Dictionary<string, string>> keyValuePair_0) => !keyValuePair_0.Value.ContainsKey(Class333.smethod_1086())).ToDictionary((KeyValuePair<string, Dictionary<string, string>> keyValuePair_0) => keyValuePair_0.Key, (KeyValuePair<string, Dictionary<string, string>> keyValuePair_0) => keyValuePair_0.Value);
		foreach (KeyValuePair<string, Dictionary<string, string>> item in data.Data.Where((KeyValuePair<string, Dictionary<string, string>> keyValuePair_0) => keyValuePair_0.Value.ContainsKey(Class333.smethod_1086())).ToDictionary((KeyValuePair<string, Dictionary<string, string>> keyValuePair_0) => keyValuePair_0.Key, (KeyValuePair<string, Dictionary<string, string>> keyValuePair_0) => keyValuePair_0.Value))
		{
			string text = null;
			try
			{
				text = item.Value[Class333.smethod_1086()];
				Class37.smethod_0(ref text, framework);
				if (Class37.smethod_10(ref text))
				{
					dictionary.Add(item.Key, item.Value);
				}
			}
			catch (Exception)
			{
			}
		}
		dataTableObject_0 = data;
		dataTableObject_0.Data = dictionary;
		dataTableObject_0.IndexColName = Class333.smethod_1087();
		dataTableObject_0.IdColName = Class333.smethod_1088();
		dataTableObject_0.SettingMapColName = Class333.smethod_1089();
		dataTableObject_0.DataToSettingMap = framework_0.aWW.ErrorToSettingMap;
		dataTableObject_0.GroupDataName = Class333.smethod_1090();
		dataTableObject_0.GroupDescDataName = Class333.smethod_91();
		dataTableObject_0.SelectedItemDataName = Class333.smethod_1091();
		foreach (DataTableColumn column in dataTableObject_0.Columns)
		{
			if (string.IsNullOrEmpty(column.EnumValueStr) && !string.IsNullOrEmpty(column.BindingData?.BindingDataId))
			{
				column.PopulateEnumStrFromSettingEnums(framework_0);
			}
		}
		foreach (IFilter filter in dataTableObject_0.Filters)
		{
			if (filter is CheckboxFilter && string.IsNullOrEmpty((filter as CheckboxFilter).OptionsStr))
			{
				(filter as CheckboxFilter).PopulateOptionsStrFromSettingEnums(framework_0);
			}
		}
		themedDataTable_0 = new ThemedDataTable(data, framework);
		themedDataTable_0.Dock = DockStyle.Fill;
		tableLayoutPanel_0.Controls.Add(themedDataTable_0);
		tableLayoutPanel_0.SetColumn(themedDataTable_0, 0);
		tableLayoutPanel_0.SetRow(themedDataTable_0, 0);
		Controls.Add(tableLayoutPanel_0);
		Width = 875;
		themedDataTable_0.SetPreferredWidth(Width);
		themedDataTable_0.ItemsSelected += method_1;
		Form23.smethod_7(method_0);
		FormClosing += DTCManagerForm_FormClosing;
	}

	private void method_0(object sender, EventArgs e)
	{
		Close();
	}

	private void DTCManagerForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		themedDataTable_0.ItemsSelected -= method_1;
		themedDataTable_0.Enabled = false;
		themedDataTable_0.Dispose();
		Form23.smethod_8(method_0);
	}

	private void method_1(object object_0, string string_0)
	{
		if (string_0 != null && int.TryParse(string_0, out var result))
		{
			Form23.form23_0.control4_0.method_38(result);
			method_2();
		}
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_2()
	{
		BeginInvoke((MethodInvoker)(() =>
		{
			Close();
		}));
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
		tableLayoutPanel_0 = new TableLayoutPanel();
		tableLayoutPanel_1 = new TableLayoutPanel();
		themedButton_0 = new ThemedButton();
		tableLayoutPanel_0.SuspendLayout();
		tableLayoutPanel_1.SuspendLayout();
		SuspendLayout();
		tableLayoutPanel_0.ColumnCount = 1;
		tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		tableLayoutPanel_0.Controls.Add(tableLayoutPanel_1, 0, 1);
		tableLayoutPanel_0.Dock = DockStyle.Fill;
		tableLayoutPanel_0.Location = new Point(0, 0);
		tableLayoutPanel_0.Margin = new Padding(4);
		tableLayoutPanel_0.Name = Class333.smethod_672();
		tableLayoutPanel_0.RowCount = 2;
		tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 65f));
		tableLayoutPanel_0.Size = new Size(912, 1030);
		tableLayoutPanel_0.TabIndex = 0;
		tableLayoutPanel_1.ColumnCount = 2;
		tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10f));
		tableLayoutPanel_1.Controls.Add(themedButton_0, 0, 0);
		tableLayoutPanel_1.Dock = DockStyle.Fill;
		tableLayoutPanel_1.Location = new Point(3, 968);
		tableLayoutPanel_1.Name = Class333.smethod_249();
		tableLayoutPanel_1.RowCount = 2;
		tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10f));
		tableLayoutPanel_1.Size = new Size(906, 59);
		tableLayoutPanel_1.TabIndex = 1;
		themedButton_0.Dock = DockStyle.Right;
		themedButton_0.Location = new Point(759, 4);
		themedButton_0.Margin = new Padding(4);
		themedButton_0.Name = Class333.smethod_1092();
		themedButton_0.Size = new Size(133, 41);
		themedButton_0.TabIndex = 0;
		themedButton_0.Text = Class333.smethod_821();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_0.Click += themedButton_0_Click;
		AutoScaleDimensions = new SizeF(8f, 19f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(912, 1030);
		Controls.Add(tableLayoutPanel_0);
		Margin = new Padding(4);
		Name = Class333.smethod_1093();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1094();
		tableLayoutPanel_0.ResumeLayout(performLayout: false);
		tableLayoutPanel_1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	[CompilerGenerated]
	private void method_4()
	{
		Close();
	}
}
