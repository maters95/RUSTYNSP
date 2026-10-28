using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ns0;
using ns7;

namespace ns4;

internal class Form5 : Form
{
	[CompilerGenerated]
	private sealed class Class177
	{
		public uint BOd;

		public uint BOE;

		public Form5 BOe;

		internal void method_0()
		{
			BOe.label_0.Text = Class333.BcV() + BOd / 10 + Class333.smethod_190() + BOd % 10;
		}

		internal void method_1()
		{
			BOe.label_3.Text = Class333.Bcv() + BOE;
		}
	}

	[CompilerGenerated]
	private sealed class Class178
	{
		public uint BOF;

		public uint BOf;

		public uint BOG;

		public uint BOg;

		public uint BOH;

		public uint BOh;

		public uint BOI;

		public uint BOi;

		public uint BOJ;

		public Class177 BOj;

		internal void method_0()
		{
			BOj.BOe.label_4.Text = Class333.BcW() + BOF;
		}

		internal void method_1()
		{
			BOj.BOe.label_5.Text = Class333.Bcw() + ((BOf != uint.MaxValue) ? (BOf + Class333.BcX() + BOG + Class333.Bcx()) : string.Empty);
		}

		internal void method_2()
		{
			BOj.BOe.label_6.Text = Class333.BcY() + ((BOg != uint.MaxValue) ? (BOg + Class333.BcX() + BOH + Class333.Bcx()) : string.Empty);
		}

		internal void method_3()
		{
			BOj.BOe.label_7.Text = Class333.Bcy() + ((BOh != uint.MaxValue) ? (BOh + Class333.BcX() + BOI + Class333.Bcx()) : string.Empty);
		}

		internal void method_4()
		{
			BOj.BOe.label_8.Text = Class333.BcZ() + ((BOi != uint.MaxValue) ? (BOi + Class333.BcX() + BOJ + Class333.Bcx()) : string.Empty);
		}
	}

	[CompilerGenerated]
	private sealed class Class179
	{
		public int BOK;

		public int BOk;

		public int BOL;

		public int BOl;

		public Class177 BOM;

		internal void method_0()
		{
			BOM.BOe.label_2.Text = Class333.Bcz() + BOL + Class333.smethod_881() + BOl + Class333.aTV();
		}
	}

	[CompilerGenerated]
	private sealed class Class180
	{
		public string BOm;

		public string BON;

		public Class179 BOn;

		internal void method_0()
		{
			Label label_ = BOn.BOM.BOe.label_1;
			label_.Text = label_.Text + BOm + BOn.BOK + Class333.smethod_881() + BOn.BOk + BON;
		}
	}

	[CompilerGenerated]
	private sealed class Class181
	{
		public int BOO;

		public Class179 BOo;

		internal void method_0()
		{
			BOo.BOM.BOe.chart_0.Series[BOO].Points.Clear();
		}
	}

	[CompilerGenerated]
	private sealed class Class182
	{
		public int BOP;

		public Class179 BOp;

		internal void method_0()
		{
			BOp.BOM.BOe.chart_0.Series[Class333.smethod_853()].Points.AddY(BOp.BOM.BOe.int_1[BOP]);
		}

		internal void method_1()
		{
			BOp.BOM.BOe.chart_0.Series[Class333.smethod_854()].Points.AddY(BOp.BOM.BOe.int_2[BOP]);
		}

		internal void method_2()
		{
			BOp.BOM.BOe.chart_0.Series[Class333.smethod_855()].Points.AddY(BOp.BOM.BOe.int_3[BOP]);
		}

		internal void method_3()
		{
			BOp.BOM.BOe.chart_0.Series[Class333.smethod_856()].Points.AddY(BOp.BOM.BOe.int_4[BOP]);
		}
	}

	private BackgroundWorker backgroundWorker_0 = new BackgroundWorker();

	private uint uint_0;

	private const int int_0 = 20;

	private int[] int_1 = new int[20];

	private int[] int_2 = new int[20];

	private int[] int_3 = new int[20];

	private int[] int_4 = new int[20];

	private static int int_5;

	private IContainer icontainer_0;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Chart chart_0;

	private Button button_0;

	private Button button_1;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private Label label_6;

	private Label label_7;

	private Label label_8;

	internal Form5()
	{
		method_0();
		chart_0.ChartAreas[0].AxisX.Maximum = 20.0;
		chart_0.ChartAreas[0].AxisX.Minimum = 0.0;
		chart_0.ChartAreas[0].AxisY.Maximum = 400.0;
		chart_0.ChartAreas[0].AxisY.Minimum = 0.0;
		backgroundWorker_0.DoWork += backgroundWorker_0_DoWork;
		backgroundWorker_0.RunWorkerAsync();
	}

	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
		while (true)
		{
			try
			{
				if (Form23.framework_1 != null)
				{
					string aXc = Form23.framework_1.aXc;
					if (!Disposing && !IsDisposed && Visible)
					{
						uint BOF = Class1.smethod_73(aXc, Enum10.const_5);
						label_4.Invoke(() =>
						{
							label_4.Text = Class333.BcW() + BOF;
						});
						uint BOG = Class1.smethod_80(aXc, Enum10.const_5);
						uint BOf = Class1.smethod_81(aXc, Enum10.const_5);
						uint BOH = Class1.smethod_80(aXc, Enum10.const_4);
						uint BOg = Class1.smethod_81(aXc, Enum10.const_4);
						uint BOI = Class1.smethod_80(aXc, Enum10.const_12);
						uint BOh = Class1.smethod_81(aXc, Enum10.const_12);
						uint BOJ = Class1.smethod_80(aXc, Enum10.const_6);
						uint BOi = Class1.smethod_81(aXc, Enum10.const_6);
						label_5.Invoke(() =>
						{
							label_5.Text = Class333.Bcw() + ((BOf != uint.MaxValue) ? (BOf + Class333.BcX() + BOG + Class333.Bcx()) : string.Empty);
						});
						label_6.Invoke(() =>
						{
							label_6.Text = Class333.BcY() + ((BOg != uint.MaxValue) ? (BOg + Class333.BcX() + BOH + Class333.Bcx()) : string.Empty);
						});
						label_7.Invoke(() =>
						{
							label_7.Text = Class333.Bcy() + ((BOh != uint.MaxValue) ? (BOh + Class333.BcX() + BOI + Class333.Bcx()) : string.Empty);
						});
						label_8.Invoke(() =>
						{
							label_8.Text = Class333.BcZ() + ((BOi != uint.MaxValue) ? (BOi + Class333.BcX() + BOJ + Class333.Bcx()) : string.Empty);
						});
					}
					uint num = Class1.smethod_85(aXc);
					uint BOd = Class1.smethod_82(aXc);
					uint[,] array = Class1.smethod_84(aXc);
					uint BOE = Class1.smethod_83(aXc);
					if (array != null && num != uint_0)
					{
						if (!Disposing && !IsDisposed && Visible)
						{
							label_0.Invoke(() =>
							{
								label_0.Text = Class333.BcV() + BOd / 10 + Class333.smethod_190() + BOd % 10;
							});
							label_1.Invoke(() =>
							{
								label_1.Text = Class333.smethod_872();
							});
						}
						int BOL = 0;
						int BOl = 0;
						int BOK = 0;
						int BOk = 0;
						for (int num2 = 0; num2 < array.GetLength(0); num2++)
						{
							BOK = (int)array[num2, 0];
							BOk = (int)array[num2, 1];
							BOL += BOK;
							BOl += BOk;
							string BOm = Class333.smethod_842();
							string BON = Class333.smethod_843();
							if (num2 == num)
							{
								BOm = Class333.smethod_844();
								BON = Class333.smethod_845();
							}
							if (!Disposing && !IsDisposed && Visible)
							{
								label_1.Invoke(() =>
								{
									Label label = label_1;
									label.Text = label.Text + BOm + BOK + Class333.smethod_881() + BOk + BON;
								});
							}
						}
						if (!Disposing && !IsDisposed && Visible)
						{
							label_2.Invoke(() =>
							{
								label_2.Text = Class333.Bcz() + BOL + Class333.smethod_881() + BOl + Class333.aTV();
							});
							label_3.Invoke(() =>
							{
								label_3.Text = Class333.Bcv() + BOE;
							});
						}
						if (int_5 >= 20)
						{
							Array.Copy(int_1, 1, int_1, 0, 19);
							Array.Copy(int_2, 1, int_2, 0, 19);
							Array.Copy(int_3, 1, int_3, 0, 19);
							Array.Copy(int_4, 1, int_4, 0, 19);
						}
						int_5++;
						if (int_5 >= 20)
						{
							int_5 = 20;
						}
						int_1[int_5 - 1] = BOL;
						int_2[int_5 - 1] = BOl;
						int_3[int_5 - 1] = (int)array[num, 0];
						int_4[int_5 - 1] = (int)array[num, 1];
						if (!Disposing && !IsDisposed && Visible)
						{
							int BOO;
							for (BOO = 0; BOO < chart_0.Series.Count; BOO++)
							{
								chart_0.Invoke(() =>
								{
									chart_0.Series[BOO].Points.Clear();
								});
							}
							int BOP;
							for (BOP = 0; BOP < int_5; BOP++)
							{
								chart_0.Invoke(() =>
								{
									chart_0.Series[Class333.smethod_853()].Points.AddY(int_1[BOP]);
								});
								chart_0.Invoke(() =>
								{
									chart_0.Series[Class333.smethod_854()].Points.AddY(int_2[BOP]);
								});
								chart_0.Invoke(() =>
								{
									chart_0.Series[Class333.smethod_855()].Points.AddY(int_3[BOP]);
								});
								chart_0.Invoke(() =>
								{
									chart_0.Series[Class333.smethod_856()].Points.AddY(int_4[BOP]);
								});
							}
						}
						uint_0 = num;
					}
				}
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.smethod_846() + ex.Message);
			}
			Thread.Sleep(200);
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		chart_0.Invoke(() =>
		{
			chart_0.Show();
		});
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		chart_0.Invoke(() =>
		{
			chart_0.Hide();
		});
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_0()
	{
		ChartArea chartArea = new ChartArea();
		Legend legend = new Legend();
		Series series = new Series();
		Series series2 = new Series();
		Series series3 = new Series();
		Series series4 = new Series();
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		chart_0 = new Chart();
		button_0 = new Button();
		button_1 = new Button();
		label_3 = new Label();
		label_4 = new Label();
		label_5 = new Label();
		label_6 = new Label();
		label_7 = new Label();
		label_8 = new Label();
		((ISupportInitialize)chart_0).BeginInit();
		SuspendLayout();
		label_0.Location = new Point(12, 9);
		label_0.Name = Class333.smethod_618();
		label_0.Size = new Size(530, 17);
		label_0.TabIndex = 0;
		label_0.Text = Class333.smethod_847();
		label_1.Location = new Point(12, 33);
		label_1.Name = Class333.smethod_620();
		label_1.Size = new Size(530, 17);
		label_1.TabIndex = 1;
		label_1.Text = Class333.smethod_848();
		label_2.Location = new Point(12, 57);
		label_2.Name = Class333.smethod_621();
		label_2.Size = new Size(530, 17);
		label_2.TabIndex = 2;
		label_2.Text = Class333.smethod_849();
		chartArea.AxisX.Interval = 1.0;
		chartArea.AxisX.IntervalOffsetType = DateTimeIntervalType.Number;
		chartArea.AxisX.IsLabelAutoFit = false;
		chartArea.AxisX.Maximum = 20.0;
		chartArea.AxisX.Minimum = 0.0;
		chartArea.AxisX2.IntervalOffsetType = DateTimeIntervalType.Number;
		chartArea.AxisY.Maximum = 300.0;
		chartArea.AxisY.Minimum = 0.0;
		chartArea.Name = Class333.smethod_850();
		chart_0.ChartAreas.Add(chartArea);
		legend.Name = Class333.smethod_851();
		chart_0.Legends.Add(legend);
		chart_0.Location = new Point(13, 265);
		chart_0.Name = Class333.smethod_852();
		series.ChartArea = Class333.smethod_850();
		series.ChartType = SeriesChartType.Line;
		series.Legend = Class333.smethod_851();
		series.Name = Class333.smethod_853();
		series2.ChartArea = Class333.smethod_850();
		series2.ChartType = SeriesChartType.Line;
		series2.Legend = Class333.smethod_851();
		series2.Name = Class333.smethod_854();
		series3.ChartArea = Class333.smethod_850();
		series3.ChartType = SeriesChartType.Line;
		series3.Legend = Class333.smethod_851();
		series3.Name = Class333.smethod_855();
		series4.ChartArea = Class333.smethod_850();
		series4.ChartType = SeriesChartType.Line;
		series4.Legend = Class333.smethod_851();
		series4.Name = Class333.smethod_856();
		chart_0.Series.Add(series);
		chart_0.Series.Add(series2);
		chart_0.Series.Add(series3);
		chart_0.Series.Add(series4);
		chart_0.Size = new Size(533, 262);
		chart_0.TabIndex = 3;
		chart_0.Text = Class333.smethod_852();
		button_0.Location = new Point(91, 233);
		button_0.Name = Class333.smethod_857();
		button_0.Size = new Size(75, 23);
		button_0.TabIndex = 4;
		button_0.Text = Class333.smethod_858();
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		button_1.Location = new Point(183, 233);
		button_1.Name = Class333.smethod_859();
		button_1.Size = new Size(75, 23);
		button_1.TabIndex = 5;
		button_1.Text = Class333.smethod_860();
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		label_3.Location = new Point(12, 81);
		label_3.Name = Class333.smethod_623();
		label_3.Size = new Size(530, 17);
		label_3.TabIndex = 6;
		label_3.Text = Class333.smethod_861();
		label_4.Location = new Point(12, 105);
		label_4.Name = Class333.smethod_862();
		label_4.Size = new Size(530, 17);
		label_4.TabIndex = 7;
		label_4.Text = Class333.smethod_863();
		label_5.Location = new Point(12, 129);
		label_5.Name = Class333.smethod_864();
		label_5.Size = new Size(530, 17);
		label_5.TabIndex = 8;
		label_5.Text = Class333.smethod_865();
		label_6.Location = new Point(12, 153);
		label_6.Name = Class333.smethod_866();
		label_6.Size = new Size(530, 17);
		label_6.TabIndex = 9;
		label_6.Text = Class333.smethod_867();
		label_7.Location = new Point(12, 177);
		label_7.Name = Class333.smethod_627();
		label_7.Size = new Size(530, 17);
		label_7.TabIndex = 10;
		label_7.Text = Class333.smethod_868();
		label_8.Location = new Point(12, 201);
		label_8.Name = Class333.smethod_629();
		label_8.Size = new Size(530, 17);
		label_8.TabIndex = 11;
		label_8.Text = Class333.smethod_869();
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(560, 539);
		Controls.Add(label_8);
		Controls.Add(label_7);
		Controls.Add(label_6);
		Controls.Add(label_5);
		Controls.Add(label_4);
		Controls.Add(label_3);
		Controls.Add(button_1);
		Controls.Add(button_0);
		Controls.Add(chart_0);
		Controls.Add(label_2);
		Controls.Add(label_1);
		Controls.Add(label_0);
		Font = new Font(Class333.smethod_145(), 8.25f);
		Name = Class333.smethod_870();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.Manual;
		Text = Class333.smethod_871();
		((ISupportInitialize)chart_0).EndInit();
		ResumeLayout(performLayout: false);
	}

	[CompilerGenerated]
	private void method_1()
	{
		label_1.Text = Class333.smethod_872();
	}

	[CompilerGenerated]
	private void method_2()
	{
		chart_0.Show();
	}

	[CompilerGenerated]
	private void method_3()
	{
		chart_0.Hide();
	}
}
