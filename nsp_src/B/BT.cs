using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;

namespace B
{
	internal class BT : Form
	{
		private static readonly string Vv = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vi();

		private IContainer VW;

		private aP Vw;

		private ThemedButton VX;

		private ThemedButton Vx;

		private Label VY;

		internal BT()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			a();
			((Control)this).BackColor = BM.td;
			((Control)VY).ForeColor = BM.te;
			((Control)Vw).ForeColor = BM.te;
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)((Form)this).DialogResult == 1 && ((CheckBox)Vw).Checked)
			{
				if (!Directory.Exists(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
				{
					Directory.CreateDirectory(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
				}
				else if (!File.Exists(Vv))
				{
					((Stream)File.Create(Vv)).Close();
				}
				List<string> val = new List<string>();
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vg() + ((CheckBox)Vw).Checked);
				File.AppendAllLines(Vv, (System.Collections.Generic.IEnumerable<string>)val);
			}
		}

		internal static bool A()
		{
			if (File.Exists(Vv))
			{
				StreamReader val = File.OpenText(Vv);
				try
				{
					string text;
					while ((text = ((TextReader)val).ReadLine()) != null)
					{
						if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vg()))
						{
							return bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vg().Length));
						}
					}
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && VW != null)
			{
				((System.IDisposable)VW).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected O, but got Unknown
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected O, but got Unknown
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0309: Expected O, but got Unknown
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_035b: Expected O, but got Unknown
			ComponentResourceManager val = new ComponentResourceManager(typeof(BT));
			Vw = new aP();
			VX = new ThemedButton();
			Vx = new ThemedButton();
			VY = new Label();
			((Control)this).SuspendLayout();
			((Control)Vw).AutoSize = true;
			((Control)Vw).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)Vw).Location = new Point(15, 66);
			((Control)Vw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KT();
			((Control)Vw).Size = new Size(212, 17);
			((Control)Vw).TabIndex = 4;
			((Control)Vw).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KR();
			((ButtonBase)Vw).UseVisualStyleBackColor = true;
			((Button)VX).DialogResult = (DialogResult)1;
			((Control)VX).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)VX).Location = new Point(256, 59);
			((Control)VX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IN();
			((Control)VX).Size = new Size(75, 30);
			((Control)VX).TabIndex = 6;
			((Control)VX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)VX).UseVisualStyleBackColor = true;
			((Button)Vx).DialogResult = (DialogResult)2;
			((Control)Vx).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)Vx).Location = new Point(337, 59);
			((Control)Vx).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IM();
			((Control)Vx).Size = new Size(75, 30);
			((Control)Vx).TabIndex = 5;
			((Control)Vx).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)Vx).UseVisualStyleBackColor = true;
			((Control)VY).AutoSize = true;
			((Control)VY).Location = new Point(12, 9);
			((Control)VY).MaximumSize = new Size(400, 0);
			((Control)VY).MinimumSize = new Size(400, 0);
			((Control)VY).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)VY).Size = new Size(400, 39);
			((Control)VY).TabIndex = 7;
			((Control)VY).Text = ((ResourceManager)val).GetString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VH());
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(424, 101);
			((Form)this).ControlBox = false;
			((Control)this).Controls.Add((Control)(object)VY);
			((Control)this).Controls.Add((Control)(object)VX);
			((Control)this).Controls.Add((Control)(object)Vx);
			((Control)this).Controls.Add((Control)(object)Vw);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vh();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VI();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class Bt : Form
	{
		private const int Vy = 16;

		private bool VZ = true;

		private IContainer Vz;

		private DataGridView vA;

		private CheckBox va;

		private CheckBox vB;

		private DataGridViewTextBoxColumn vb;

		private DataGridViewTextBoxColumn vC;

		private DataGridViewTextBoxColumn vc;

		private DataGridViewTextBoxColumn vD;

		private DataGridViewTextBoxColumn vd;

		private DataGridViewTextBoxColumn vE;

		private DataGridViewTextBoxColumn ve;

		private DataGridViewTextBoxColumn vF;

		private DataGridViewTextBoxColumn vf;

		private DataGridViewTextBoxColumn vG;

		private DataGridViewTextBoxColumn vg;

		private DataGridViewTextBoxColumn vH;

		private DataGridViewTextBoxColumn vh;

		private DataGridViewTextBoxColumn vI;

		private DataGridViewTextBoxColumn vi;

		private DataGridViewTextBoxColumn vJ;

		private Timer vj;

		private TextBox vK;

		private Button vk;

		private Button vL;

		private Button vl;

		private ComboBox vM;

		private DataGridView vm;

		private DataGridViewTextBoxColumn vN;

		private DataGridViewTextBoxColumn vn;

		private DataGridViewTextBoxColumn vO;

		private DataGridViewTextBoxColumn vo;

		private DataGridViewTextBoxColumn vP;

		private DataGridViewTextBoxColumn vp;

		private DataGridViewTextBoxColumn vQ;

		private DataGridViewTextBoxColumn vq;

		private DataGridViewTextBoxColumn vR;

		private DataGridViewTextBoxColumn vr;

		private DataGridViewTextBoxColumn vS;

		private DataGridViewTextBoxColumn vs;

		private DataGridViewTextBoxColumn vT;

		private DataGridViewTextBoxColumn vt;

		private DataGridViewTextBoxColumn vU;

		private DataGridViewTextBoxColumn vu;

		private Label vV;

		private Label vv;

		private Label vW;

		internal Bt()
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			VZ = true;
			a();
			BM.C(new EventHandler(A));
			typeof(DataGridView).InvokeMember(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HG(), (BindingFlags)8228, (Binder)null, (object)vA, new object[1] { true });
			typeof(DataGridView).InvokeMember(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HG(), (BindingFlags)8228, (Binder)null, (object)vm, new object[1] { true });
			vA.RowCount = BM.Qz.I().Length / 16;
			vm.RowCount = BM.Qz.J().Length / 16;
			((ListControl)vM).SelectedIndex = 0;
			VZ = false;
			vj.Enabled = true;
			vj.Start();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			BM.c(new EventHandler(A));
		}

		private void A(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
		}

		private void a(object P_0, EventArgs P_1)
		{
			if (!VZ)
			{
				if (((ListControl)vM).SelectedIndex == 0)
				{
					((Control)vA).Visible = true;
					((Control)vm).Visible = false;
				}
				else
				{
					((Control)vA).Visible = false;
					((Control)vm).Visible = true;
				}
			}
		}

		private void A(object P_0, DataGridViewCellToolTipTextNeededEventArgs P_1)
		{
			int num = ((DataGridViewCellEventArgs)P_1).RowIndex * 16 + ((DataGridViewCellEventArgs)P_1).ColumnIndex;
			Setting setting = BM.Qz.B(num);
			if (setting != null)
			{
				P_1.ToolTipText = string.Concat(new string[8]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VJ(),
					(num - setting.a()).ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vj(),
					((SettingOrSpecialObject)setting).A(bz.aYt),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VK(),
					setting.A().ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vk(),
					setting.B().ToString()
				});
			}
			else
			{
				P_1.ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VL();
			}
		}

		private void a(object P_0, DataGridViewCellToolTipTextNeededEventArgs P_1)
		{
			int num = ((DataGridViewCellEventArgs)P_1).RowIndex * 16 + ((DataGridViewCellEventArgs)P_1).ColumnIndex;
			Setting setting = BM.Qz.b(num);
			if (setting != null)
			{
				P_1.ToolTipText = string.Concat(new string[6]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VJ(),
					(num - setting.a()).ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vj(),
					((SettingOrSpecialObject)setting).A(bz.aYt),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VK(),
					setting.A().ToString()
				});
			}
			else
			{
				P_1.ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vl();
			}
		}

		private void A(object P_0, DataGridViewCellValueEventArgs P_1)
		{
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			if (P_1.ColumnIndex == 0)
			{
				int num = P_1.RowIndex * 16;
				Setting setting = BM.Qz.B(num);
				string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
				if (setting != null)
				{
					text = ((SettingOrSpecialObject)setting).A(bz.aYT) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VM();
				}
				if (va.Checked)
				{
					((DataGridViewCell)vA.Rows[P_1.RowIndex].HeaderCell).Value = text + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vm(), (object)num);
				}
				else
				{
					((DataGridViewCell)vA.Rows[P_1.RowIndex].HeaderCell).Value = text + num;
				}
			}
			int num2 = P_1.RowIndex * 16 + P_1.ColumnIndex;
			if (vB.Checked)
			{
				P_1.Value = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.an(), (object)BM.Qz.I()[num2]);
			}
			else
			{
				P_1.Value = BM.Qz.I()[num2].ToString();
			}
			if (BM.Qz.B(num2) == null)
			{
				vA.Rows[P_1.RowIndex].Cells[P_1.ColumnIndex].Style.BackColor = Color.LightPink;
			}
			else if (vA.CurrentCell != null)
			{
				int rowIndex = vA.CurrentCell.RowIndex;
				int columnIndex = vA.CurrentCell.ColumnIndex;
				int num3 = rowIndex * 16 + columnIndex;
				Setting setting2 = BM.Qz.B(num3);
				if (setting2 != null)
				{
					if (num2 >= setting2.a() && num2 < setting2.a() + setting2.BB())
					{
						vA.Rows[P_1.RowIndex].Cells[P_1.ColumnIndex].Style.BackColor = Color.LightGreen;
					}
					else
					{
						vA.Rows[P_1.RowIndex].Cells[P_1.ColumnIndex].Style.BackColor = Color.White;
					}
				}
				else
				{
					vA.Rows[P_1.RowIndex].Cells[P_1.ColumnIndex].Style.BackColor = Color.White;
				}
			}
			else
			{
				vA.Rows[P_1.RowIndex].Cells[P_1.ColumnIndex].Style.BackColor = Color.White;
			}
		}

		private void a(object P_0, DataGridViewCellValueEventArgs P_1)
		{
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			if (P_1.ColumnIndex == 0)
			{
				int num = P_1.RowIndex * 16;
				Setting setting = BM.Qz.b(num);
				string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
				if (setting != null)
				{
					text = ((SettingOrSpecialObject)setting).A(bz.aYT) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VM();
				}
				if (va.Checked)
				{
					((DataGridViewCell)vm.Rows[P_1.RowIndex].HeaderCell).Value = text + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vm(), (object)num);
				}
				else
				{
					((DataGridViewCell)vm.Rows[P_1.RowIndex].HeaderCell).Value = text + num;
				}
			}
			int num2 = P_1.RowIndex * 16 + P_1.ColumnIndex;
			if (vB.Checked)
			{
				P_1.Value = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.an(), (object)BM.Qz.J()[num2]);
			}
			else
			{
				P_1.Value = BM.Qz.J()[num2].ToString();
			}
			if (BM.Qz.b(num2) == null)
			{
				vm.Rows[P_1.RowIndex].Cells[P_1.ColumnIndex].Style.BackColor = Color.LightPink;
			}
			else if (vm.CurrentCell != null)
			{
				int rowIndex = vm.CurrentCell.RowIndex;
				int columnIndex = vm.CurrentCell.ColumnIndex;
				int num3 = rowIndex * 16 + columnIndex;
				Setting setting2 = BM.Qz.b(num3);
				if (setting2 != null)
				{
					if (num2 >= setting2.a() && num2 < setting2.a() + setting2.BB())
					{
						vm.Rows[P_1.RowIndex].Cells[P_1.ColumnIndex].Style.BackColor = Color.LightGreen;
					}
					else
					{
						vm.Rows[P_1.RowIndex].Cells[P_1.ColumnIndex].Style.BackColor = Color.White;
					}
				}
				else
				{
					vm.Rows[P_1.RowIndex].Cells[P_1.ColumnIndex].Style.BackColor = Color.White;
				}
			}
			else
			{
				vm.Rows[P_1.RowIndex].Cells[P_1.ColumnIndex].Style.BackColor = Color.White;
			}
		}

		private void B(object P_0, DataGridViewCellValueEventArgs P_1)
		{
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			bool flag = false;
			byte b = default(byte);
			if ((!vB.Checked) ? byte.TryParse(P_1.Value as string, ref b) : byte.TryParse(P_1.Value as string, (NumberStyles)512, (IFormatProvider)null, ref b))
			{
				int num = P_1.RowIndex * 16 + P_1.ColumnIndex;
				Setting setting = BM.Qz.B(num);
				if (setting != null)
				{
					setting.A(num - setting.a(), b, true);
					BM.A(setting.C());
				}
				else
				{
					BM.Qz.I()[num] = b;
					BM.Qz.i()[num] = by.aYK;
					BM.Qz.aXd = true;
				}
			}
			else
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fQ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			if (VZ)
			{
				return;
			}
			vj.Stop();
			vj.Enabled = false;
			if (((ListControl)vM).SelectedIndex == 0)
			{
				for (int i = 0; i < 16; i++)
				{
					if (va.Checked)
					{
						((DataGridViewCell)vA.Columns[i].HeaderCell).Value = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VN(), (object)i);
					}
					else
					{
						((DataGridViewCell)vA.Columns[i].HeaderCell).Value = i.ToString();
					}
				}
				for (int j = 0; j < vA.Rows.Count; j++)
				{
					int num = j * 16;
					Setting setting = BM.Qz.B(num);
					string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
					if (setting != null)
					{
						text = ((SettingOrSpecialObject)setting).A(bz.aYT) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VM();
					}
					if (va.Checked)
					{
						((DataGridViewCell)vA.Rows[j].HeaderCell).Value = text + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vm(), (object)num);
					}
					else
					{
						((DataGridViewCell)vA.Rows[j].HeaderCell).Value = text + num;
					}
				}
			}
			else
			{
				for (int k = 0; k < 16; k++)
				{
					if (va.Checked)
					{
						((DataGridViewCell)vm.Columns[k].HeaderCell).Value = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VN(), (object)k);
					}
					else
					{
						((DataGridViewCell)vm.Columns[k].HeaderCell).Value = k.ToString();
					}
				}
				for (int l = 0; l < vm.Rows.Count; l++)
				{
					int num2 = l * 16;
					Setting setting2 = BM.Qz.b(num2);
					string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
					if (setting2 != null)
					{
						text2 = ((SettingOrSpecialObject)setting2).A(bz.aYT) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VM();
					}
					if (va.Checked)
					{
						((DataGridViewCell)vm.Rows[l].HeaderCell).Value = text2 + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vm(), (object)num2);
					}
					else
					{
						((DataGridViewCell)vm.Rows[l].HeaderCell).Value = text2 + num2;
					}
				}
			}
			vj.Enabled = true;
			vj.Start();
		}

		private void b(object P_0, EventArgs P_1)
		{
			if (!VZ)
			{
				c(null, null);
			}
		}

		private void C(object P_0, EventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			DataGridView obj = vA;
			Size clientSize = ((Form)this).ClientSize;
			((Control)obj).Height = ((Size)(ref clientSize)).Height - (((Control)vA).Top + 10);
			((Control)vm).Height = ((Control)vA).Height;
		}

		private void c(object P_0, EventArgs P_1)
		{
			if (((ListControl)vM).SelectedIndex == 0)
			{
				((Control)vA).Refresh();
				if (vA.CurrentCell == null)
				{
					((Control)vV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
					((Control)vv).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
					((Control)vW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
					return;
				}
				int rowIndex = vA.CurrentCell.RowIndex;
				int columnIndex = vA.CurrentCell.ColumnIndex;
				int num = rowIndex * 16 + columnIndex;
				Setting setting = BM.Qz.B(num);
				if (setting != null)
				{
					string text = ((SettingOrSpecialObject)setting).A(bz.aYT);
					if (text != null)
					{
						((Control)vV).Text = string.Concat(new string[6]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vn(),
							text,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VO(),
							setting.A().ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vo(),
							setting.B().ToString()
						});
					}
					else
					{
						((Control)vV).Text = string.Concat(new string[6]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vn(),
							((SettingOrSpecialObject)setting).A(bz.aYt),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VO(),
							setting.A().ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vo(),
							setting.B().ToString()
						});
					}
					string text2 = ((!va.Checked) ? setting.a().ToString() : string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vm(), (object)setting.a()));
					((Control)vv).Text = string.Concat(new string[5]
					{
						setting.Ba().ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VP(),
						setting.aG().ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vp(),
						text2
					});
					int num2 = (num - setting.a()) / setting.aG();
					int num3 = setting.m(num2);
					((Control)vW).Text = setting.aG() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VQ() + num3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vq();
				}
				else
				{
					((Control)vV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VR();
					((Control)vv).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
					((Control)vW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
				}
				return;
			}
			((Control)vm).Refresh();
			if (vm.CurrentCell == null)
			{
				((Control)vV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
				((Control)vv).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
				((Control)vW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
				return;
			}
			int rowIndex2 = vm.CurrentCell.RowIndex;
			int columnIndex2 = vm.CurrentCell.ColumnIndex;
			int num4 = rowIndex2 * 16 + columnIndex2;
			Setting setting2 = BM.Qz.b(num4);
			if (setting2 != null)
			{
				string text3 = ((SettingOrSpecialObject)setting2).A(bz.aYT);
				if (text3 != null)
				{
					((Control)vV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vr() + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VO() + setting2.A();
				}
				else
				{
					((Control)vV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vr() + ((SettingOrSpecialObject)setting2).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VO() + setting2.A();
				}
				string text4 = ((!va.Checked) ? setting2.a().ToString() : string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vm(), (object)setting2.a()));
				((Control)vv).Text = string.Concat(new string[5]
				{
					setting2.Ba().ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VP(),
					setting2.aG().ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vp(),
					text4
				});
				int num5 = (num4 - setting2.a()) / setting2.aG();
				int num6 = setting2.m(num5);
				((Control)vW).Text = setting2.aG() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VQ() + num6 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vq();
			}
			else
			{
				((Control)vV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VS();
				((Control)vv).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
				((Control)vW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
			}
		}

		private void A(int P_0)
		{
			try
			{
				int num = P_0 / 16;
				if (((ListControl)vM).SelectedIndex == 0)
				{
					vA.FirstDisplayedScrollingRowIndex = num;
					int num2 = num * 16;
					for (int i = 0; i < vA.RowCount; i++)
					{
						for (int j = 0; j < vA.ColumnCount; j++)
						{
							vA.Rows[i].Cells[j].Selected = false;
						}
					}
					vA.CurrentCell = vA.Rows[num].Cells[P_0 - num2];
					vA.Rows[num].Cells[P_0 - num2].Selected = true;
					return;
				}
				vm.FirstDisplayedScrollingRowIndex = num;
				int num3 = num * 16;
				for (int k = 0; k < vm.RowCount; k++)
				{
					for (int l = 0; l < vm.ColumnCount; l++)
					{
						vm.Rows[k].Cells[l].Selected = false;
					}
				}
				vm.CurrentCell = vm.Rows[num].Cells[P_0 - num3];
				vm.Rows[num].Cells[P_0 - num3].Selected = true;
			}
			catch
			{
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			bool flag = false;
			int num = default(int);
			if ((!va.Checked) ? int.TryParse(((Control)vK).Text, ref num) : int.TryParse(((Control)vK).Text, (NumberStyles)512, (IFormatProvider)null, ref num))
			{
				A(num);
			}
		}

		private void d(object P_0, EventArgs P_1)
		{
			int num = default(int);
			if (int.TryParse(((Control)vK).Text, ref num))
			{
				Setting setting = BM.Qz.A(num);
				if (setting != null)
				{
					A(setting.a());
				}
			}
		}

		private void E(object P_0, EventArgs P_1)
		{
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected O, but got Unknown
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected O, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Expected O, but got Unknown
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Invalid comparison between Unknown and I4
			//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Expected O, but got Unknown
			try
			{
				if (!(((Control)vK).Text != string.Empty))
				{
					return;
				}
				string[] array = ((Control)vK).Text.Split(RuntimeHelpers.CreateSpan<char>((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/));
				List<string> val = new List<string>();
				for (int i = 0; i < array.Length; i++)
				{
					val.Add(array[i].ToLower());
				}
				List<SettingOrSpecialObject> val2 = new List<SettingOrSpecialObject>();
				A(BM.Qz.aWS, val, val2);
				if (val2.Count == 1)
				{
					if (val2[0] is Setting)
					{
						A((val2[0] as Setting).a());
					}
				}
				else
				{
					if (val2.Count == 0)
					{
						return;
					}
					Form val3 = new Form();
					val3.FormBorderStyle = (FormBorderStyle)3;
					((Control)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vs();
					val3.StartPosition = (FormStartPosition)4;
					val3.ShowIcon = false;
					val3.ShowInTaskbar = false;
					val3.Size = new Size(400, 500);
					((ScrollableControl)val3).AutoScroll = true;
					Button val4 = new Button();
					((Control)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
					val4.DialogResult = (DialogResult)1;
					((Control)val4).Location = new Point(100, 10);
					Button val5 = new Button();
					((Control)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
					val5.DialogResult = (DialogResult)2;
					((Control)val5).Location = new Point(200, 10);
					((Control)val3).Controls.Add((Control)(object)val4);
					((Control)val3).Controls.Add((Control)(object)val5);
					val3.AcceptButton = (IButtonControl)(object)val4;
					val3.CancelButton = (IButtonControl)(object)val5;
					GroupBox val6 = new GroupBox();
					((Control)val6).Location = new Point(10, 40);
					Rectangle clientRectangle = ((Control)val3).ClientRectangle;
					((Control)val6).MinimumSize = new Size(((Rectangle)(ref clientRectangle)).Width - 20, 0);
					clientRectangle = ((Control)val3).ClientRectangle;
					((Control)val6).MaximumSize = new Size(((Rectangle)(ref clientRectangle)).Width - 20, 0);
					((Control)val6).AutoSize = true;
					((Control)val6).SuspendLayout();
					int num = 10;
					Enumerator<SettingOrSpecialObject> enumerator = val2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							SettingOrSpecialObject current = enumerator.Current;
							RadioButton val7 = new RadioButton();
							((Control)val7).AutoSize = true;
							((Control)val7).Tag = current;
							((Control)val7).Text = current.A(bz.aYt);
							((Control)val7).Location = new Point(10, num);
							num += ((Control)val7).Height;
							((Control)val6).Controls.Add((Control)(object)val7);
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					((Control)val6).ResumeLayout(true);
					((Control)val3).Controls.Add((Control)(object)val6);
					if ((int)val3.ShowDialog((IWin32Window)(object)this) == 1)
					{
						foreach (Control item in (ArrangedElementCollection)((Control)val6).Controls)
						{
							Control val8 = item;
							if (val8 is RadioButton && ((RadioButton)((val8 is RadioButton) ? val8 : null)).Checked)
							{
								if (((val8 is RadioButton) ? val8 : null).Tag is Setting)
								{
									A((((val8 is RadioButton) ? val8 : null).Tag as Setting).a());
								}
								break;
							}
						}
					}
					((Component)val3).Dispose();
				}
			}
			catch
			{
			}
		}

		private void A(List<SettingOrSpecialObject> P_0, List<string> P_1, List<SettingOrSpecialObject> P_2)
		{
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < P_0.Count; i++)
			{
				SettingOrSpecialObject settingOrSpecialObject = P_0[i];
				if (settingOrSpecialObject is Setting)
				{
					Setting setting = settingOrSpecialObject as Setting;
					if ((((ListControl)vM).SelectedIndex == 0 && !setting.aJ()) || (((ListControl)vM).SelectedIndex == 1 && setting.aJ()))
					{
						bool flag = true;
						for (int j = 0; j < P_1.Count; j++)
						{
							string text = ((SettingOrSpecialObject)setting).A(bz.aYT);
							if (text == null || !text.ToLower().Contains(P_1[j]))
							{
								string text2 = ((SettingOrSpecialObject)setting).A(bz.aYt);
								if (text2 == null || !text2.ToLower().Contains(P_1[j]))
								{
									flag = false;
									break;
								}
							}
						}
						if (flag)
						{
							P_2.Add((SettingOrSpecialObject)setting);
						}
					}
				}
				if (P_2.Count >= 100)
				{
					break;
				}
				A(settingOrSpecialObject.a(), P_1, P_2);
			}
			if (P_0 == BM.Qz.aWS && P_2.Count >= 100)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VT(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vt(), (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
		}

		private void A()
		{
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected O, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected O, but got Unknown
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				if (!Clipboard.ContainsText())
				{
					return;
				}
				string text = Clipboard.GetText();
				int num = text.Split('\n', (StringSplitOptions)0).Length;
				int num2 = 0;
				for (int i = 0; i < num; i++)
				{
					int num3 = text.Split('\n', (StringSplitOptions)0)[i].Split('\t', (StringSplitOptions)0).Length;
					if (i == 0)
					{
						num2 = num3;
					}
					else if (num3 != num2)
					{
						throw new System.Exception();
					}
				}
				int num4 = 2147483647;
				int num5 = -2147483648;
				int num6 = 2147483647;
				int num7 = -2147483648;
				if (((ListControl)vM).SelectedIndex == 0)
				{
					foreach (DataGridViewCell item in (BaseCollection)vA.SelectedCells)
					{
						DataGridViewCell val = item;
						num4 = Math.Min(num4, val.ColumnIndex);
						num5 = Math.Max(num5, val.ColumnIndex);
						num6 = Math.Min(num6, val.RowIndex);
						num7 = Math.Max(num7, val.RowIndex);
					}
				}
				else
				{
					foreach (DataGridViewCell item2 in (BaseCollection)vm.SelectedCells)
					{
						DataGridViewCell val2 = item2;
						num4 = Math.Min(num4, val2.ColumnIndex);
						num5 = Math.Max(num5, val2.ColumnIndex);
						num6 = Math.Min(num6, val2.RowIndex);
						num7 = Math.Max(num7, val2.RowIndex);
					}
				}
				if ((num4 == num5 && num6 == num7) || (1 + num5 - num4 == num2 && 1 + num7 - num6 == num))
				{
					bool enabled = vj.Enabled;
					vj.Stop();
					vj.Enabled = false;
					for (int j = 0; j < num; j++)
					{
						for (int k = 0; k < num2; k++)
						{
							string text2 = text.Split('\n', (StringSplitOptions)0)[j].Split('\t', (StringSplitOptions)0)[k];
							if (text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VU()))
							{
								text2 = text2.Substring(0, text2.Length - 1);
							}
							if (((ListControl)vM).SelectedIndex == 0)
							{
								vA.Rows[num6 + j].Cells[num4 + k].Value = text2;
							}
							else
							{
								vm.Rows[num6 + j].Cells[num4 + k].Value = text2;
							}
						}
					}
					if (enabled)
					{
						vj.Enabled = true;
						vj.Start();
					}
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vu(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			catch
			{
			}
		}

		private void A(object P_0, KeyEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)P_1.KeyData == 131158)
			{
				A();
			}
		}

		private void a(object P_0, KeyEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)P_1.KeyData == 131158)
			{
				A();
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && Vz != null)
			{
				((System.IDisposable)Vz).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got Unknown
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected O, but got Unknown
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected O, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected O, but got Unknown
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected O, but got Unknown
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected O, but got Unknown
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected O, but got Unknown
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected O, but got Unknown
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected O, but got Unknown
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected O, but got Unknown
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Expected O, but got Unknown
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Expected O, but got Unknown
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected O, but got Unknown
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected O, but got Unknown
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected O, but got Unknown
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Expected O, but got Unknown
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Expected O, but got Unknown
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Expected O, but got Unknown
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected O, but got Unknown
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected O, but got Unknown
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Expected O, but got Unknown
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Expected O, but got Unknown
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Expected O, but got Unknown
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Expected O, but got Unknown
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Expected O, but got Unknown
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Expected O, but got Unknown
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Expected O, but got Unknown
			//IL_0214: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Expected O, but got Unknown
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Expected O, but got Unknown
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0234: Expected O, but got Unknown
			//IL_0296: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected O, but got Unknown
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0315: Expected O, but got Unknown
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_0333: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_041e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0433: Unknown result type (might be due to invalid IL or missing references)
			//IL_043d: Expected O, but got Unknown
			//IL_043e: Unknown result type (might be due to invalid IL or missing references)
			//IL_045b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0466: Unknown result type (might be due to invalid IL or missing references)
			//IL_0495: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f7: Expected O, but got Unknown
			//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0515: Unknown result type (might be due to invalid IL or missing references)
			//IL_0520: Unknown result type (might be due to invalid IL or missing references)
			//IL_0581: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ba: Expected O, but got Unknown
			//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d1: Expected O, but got Unknown
			//IL_05de: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e8: Expected O, but got Unknown
			//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ff: Expected O, but got Unknown
			//IL_060c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0616: Expected O, but got Unknown
			//IL_0623: Unknown result type (might be due to invalid IL or missing references)
			//IL_062d: Expected O, but got Unknown
			//IL_0934: Unknown result type (might be due to invalid IL or missing references)
			//IL_093e: Expected O, but got Unknown
			//IL_0947: Unknown result type (might be due to invalid IL or missing references)
			//IL_096b: Unknown result type (might be due to invalid IL or missing references)
			//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b4: Expected O, but got Unknown
			//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f5: Expected O, but got Unknown
			//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a6c: Expected O, but got Unknown
			//IL_0a89: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a93: Expected O, but got Unknown
			//IL_0ab2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0abc: Expected O, but got Unknown
			//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b22: Expected O, but got Unknown
			//IL_0b2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b9c: Expected O, but got Unknown
			//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb9: Expected O, but got Unknown
			//IL_0bc6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c33: Expected O, but got Unknown
			//IL_0c46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c50: Expected O, but got Unknown
			//IL_0c5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c81: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cca: Expected O, but got Unknown
			//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf3: Expected O, but got Unknown
			//IL_0d32: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d59: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d86: Expected O, but got Unknown
			//IL_0dce: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd8: Expected O, but got Unknown
			//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e34: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e54: Expected O, but got Unknown
			//IL_0e56: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e76: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e82: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f66: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f7c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f86: Expected O, but got Unknown
			//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ff9: Unknown result type (might be due to invalid IL or missing references)
			//IL_102a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1040: Unknown result type (might be due to invalid IL or missing references)
			//IL_104a: Expected O, but got Unknown
			//IL_104c: Unknown result type (might be due to invalid IL or missing references)
			//IL_106c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1078: Unknown result type (might be due to invalid IL or missing references)
			//IL_10db: Unknown result type (might be due to invalid IL or missing references)
			//IL_1116: Unknown result type (might be due to invalid IL or missing references)
			//IL_1120: Expected O, but got Unknown
			//IL_112d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1137: Expected O, but got Unknown
			//IL_1144: Unknown result type (might be due to invalid IL or missing references)
			//IL_114e: Expected O, but got Unknown
			//IL_115b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1165: Expected O, but got Unknown
			//IL_1172: Unknown result type (might be due to invalid IL or missing references)
			//IL_117c: Expected O, but got Unknown
			//IL_1458: Unknown result type (might be due to invalid IL or missing references)
			//IL_147f: Unknown result type (might be due to invalid IL or missing references)
			//IL_14b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_14da: Unknown result type (might be due to invalid IL or missing references)
			//IL_150e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1535: Unknown result type (might be due to invalid IL or missing references)
			//IL_1567: Unknown result type (might be due to invalid IL or missing references)
			//IL_1583: Unknown result type (might be due to invalid IL or missing references)
			//IL_166b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1675: Expected O, but got Unknown
			//IL_16a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_16b2: Expected O, but got Unknown
			//IL_16ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_16c4: Expected O, but got Unknown
			Vz = (IContainer)new Container();
			DataGridViewCellStyle val = new DataGridViewCellStyle();
			DataGridViewCellStyle val2 = new DataGridViewCellStyle();
			DataGridViewCellStyle val3 = new DataGridViewCellStyle();
			DataGridViewCellStyle val4 = new DataGridViewCellStyle();
			DataGridViewCellStyle val5 = new DataGridViewCellStyle();
			DataGridViewCellStyle val6 = new DataGridViewCellStyle();
			DataGridViewCellStyle val7 = new DataGridViewCellStyle();
			DataGridViewCellStyle val8 = new DataGridViewCellStyle();
			vA = new DataGridView();
			vb = new DataGridViewTextBoxColumn();
			vC = new DataGridViewTextBoxColumn();
			vc = new DataGridViewTextBoxColumn();
			vD = new DataGridViewTextBoxColumn();
			vd = new DataGridViewTextBoxColumn();
			vE = new DataGridViewTextBoxColumn();
			ve = new DataGridViewTextBoxColumn();
			vF = new DataGridViewTextBoxColumn();
			vf = new DataGridViewTextBoxColumn();
			vG = new DataGridViewTextBoxColumn();
			vg = new DataGridViewTextBoxColumn();
			vH = new DataGridViewTextBoxColumn();
			vh = new DataGridViewTextBoxColumn();
			vI = new DataGridViewTextBoxColumn();
			vi = new DataGridViewTextBoxColumn();
			vJ = new DataGridViewTextBoxColumn();
			va = new CheckBox();
			vB = new CheckBox();
			vj = new Timer(Vz);
			vK = new TextBox();
			vk = new Button();
			vL = new Button();
			vl = new Button();
			vM = new ComboBox();
			vm = new DataGridView();
			vN = new DataGridViewTextBoxColumn();
			vn = new DataGridViewTextBoxColumn();
			vO = new DataGridViewTextBoxColumn();
			vo = new DataGridViewTextBoxColumn();
			vP = new DataGridViewTextBoxColumn();
			vp = new DataGridViewTextBoxColumn();
			vQ = new DataGridViewTextBoxColumn();
			vq = new DataGridViewTextBoxColumn();
			vR = new DataGridViewTextBoxColumn();
			vr = new DataGridViewTextBoxColumn();
			vS = new DataGridViewTextBoxColumn();
			vs = new DataGridViewTextBoxColumn();
			vT = new DataGridViewTextBoxColumn();
			vt = new DataGridViewTextBoxColumn();
			vU = new DataGridViewTextBoxColumn();
			vu = new DataGridViewTextBoxColumn();
			vV = new Label();
			vv = new Label();
			vW = new Label();
			((ISupportInitialize)vA).BeginInit();
			((ISupportInitialize)vm).BeginInit();
			((Control)this).SuspendLayout();
			vA.AllowUserToAddRows = false;
			vA.AllowUserToDeleteRows = false;
			vA.AllowUserToResizeColumns = false;
			vA.AllowUserToResizeRows = false;
			val.Alignment = (DataGridViewContentAlignment)64;
			val.Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			val.Format = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VV();
			val.NullValue = null;
			val.WrapMode = (DataGridViewTriState)2;
			vA.AlternatingRowsDefaultCellStyle = val;
			vA.BackgroundColor = Color.White;
			vA.ClipboardCopyMode = (DataGridViewClipboardCopyMode)2;
			vA.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
			val2.Alignment = (DataGridViewContentAlignment)64;
			val2.BackColor = Color.White;
			val2.Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
			val2.ForeColor = SystemColors.WindowText;
			val2.Format = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VV();
			val2.NullValue = null;
			val2.SelectionBackColor = SystemColors.Highlight;
			val2.SelectionForeColor = SystemColors.HighlightText;
			val2.WrapMode = (DataGridViewTriState)2;
			vA.ColumnHeadersDefaultCellStyle = val2;
			vA.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
			vA.Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[16]
			{
				(DataGridViewColumn)vb,
				(DataGridViewColumn)vC,
				(DataGridViewColumn)vc,
				(DataGridViewColumn)vD,
				(DataGridViewColumn)vd,
				(DataGridViewColumn)vE,
				(DataGridViewColumn)ve,
				(DataGridViewColumn)vF,
				(DataGridViewColumn)vf,
				(DataGridViewColumn)vG,
				(DataGridViewColumn)vg,
				(DataGridViewColumn)vH,
				(DataGridViewColumn)vh,
				(DataGridViewColumn)vI,
				(DataGridViewColumn)vi,
				(DataGridViewColumn)vJ
			});
			val3.Alignment = (DataGridViewContentAlignment)64;
			val3.BackColor = Color.White;
			val3.Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
			val3.ForeColor = SystemColors.ControlText;
			val3.Format = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VV();
			val3.NullValue = null;
			val3.SelectionBackColor = SystemColors.Highlight;
			val3.SelectionForeColor = SystemColors.HighlightText;
			val3.WrapMode = (DataGridViewTriState)2;
			vA.DefaultCellStyle = val3;
			vA.EditMode = (DataGridViewEditMode)1;
			vA.GridColor = Color.Black;
			((Control)vA).Location = new Point(12, 52);
			((Control)vA).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vv();
			vA.RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
			val4.Alignment = (DataGridViewContentAlignment)64;
			val4.BackColor = Color.White;
			val4.Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
			val4.ForeColor = SystemColors.WindowText;
			val4.Format = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VV();
			val4.NullValue = null;
			val4.SelectionBackColor = SystemColors.Highlight;
			val4.SelectionForeColor = SystemColors.HighlightText;
			val4.WrapMode = (DataGridViewTriState)2;
			vA.RowHeadersDefaultCellStyle = val4;
			vA.RowHeadersWidth = 500;
			vA.SelectionMode = (DataGridViewSelectionMode)0;
			vA.ShowCellErrors = false;
			vA.ShowRowErrors = false;
			((Control)vA).Size = new Size(960, 447);
			((Control)vA).TabIndex = 7;
			vA.VirtualMode = true;
			vA.CellToolTipTextNeeded += new DataGridViewCellToolTipTextNeededEventHandler(A);
			vA.CellValueNeeded += new DataGridViewCellValueEventHandler(A);
			vA.CellValuePushed += new DataGridViewCellValueEventHandler(B);
			vA.CurrentCellChanged += new EventHandler(c);
			vA.SelectionChanged += new EventHandler(c);
			((Control)vA).KeyDown += new KeyEventHandler(A);
			((DataGridViewColumn)vb).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn();
			((DataGridViewColumn)vb).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VW();
			((DataGridViewColumn)vb).Width = 27;
			((DataGridViewColumn)vC).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CJ();
			((DataGridViewColumn)vC).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vw();
			((DataGridViewColumn)vC).Width = 27;
			((DataGridViewColumn)vc).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cb();
			((DataGridViewColumn)vc).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VX();
			((DataGridViewColumn)vc).Width = 27;
			((DataGridViewColumn)vD).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ca();
			((DataGridViewColumn)vD).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vx();
			((DataGridViewColumn)vD).Width = 27;
			((DataGridViewColumn)vd).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cz();
			((DataGridViewColumn)vd).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VY();
			((DataGridViewColumn)vd).Width = 27;
			((DataGridViewColumn)vE).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cy();
			((DataGridViewColumn)vE).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vy();
			((DataGridViewColumn)vE).Width = 27;
			((DataGridViewColumn)ve).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cx();
			((DataGridViewColumn)ve).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VZ();
			((DataGridViewColumn)ve).Width = 27;
			((DataGridViewColumn)vF).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cw();
			((DataGridViewColumn)vF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Vz();
			((DataGridViewColumn)vF).Width = 27;
			((DataGridViewColumn)vf).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vA();
			((DataGridViewColumn)vf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.va();
			((DataGridViewColumn)vf).Width = 27;
			((DataGridViewColumn)vG).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vB();
			((DataGridViewColumn)vG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vb();
			((DataGridViewColumn)vG).Width = 27;
			((DataGridViewColumn)vg).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mP();
			((DataGridViewColumn)vg).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vC();
			((DataGridViewColumn)vg).Width = 27;
			((DataGridViewColumn)vH).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vc();
			((DataGridViewColumn)vH).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vD();
			((DataGridViewColumn)vH).Width = 27;
			((DataGridViewColumn)vh).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vd();
			((DataGridViewColumn)vh).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vE();
			((DataGridViewColumn)vh).Width = 27;
			((DataGridViewColumn)vI).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MS();
			((DataGridViewColumn)vI).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ve();
			((DataGridViewColumn)vI).Width = 27;
			((DataGridViewColumn)vi).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vF();
			((DataGridViewColumn)vi).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vf();
			((DataGridViewColumn)vi).Width = 27;
			((DataGridViewColumn)vJ).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mj();
			((DataGridViewColumn)vJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vG();
			((DataGridViewColumn)vJ).Width = 27;
			((Control)va).AutoSize = true;
			va.Checked = true;
			va.CheckState = (CheckState)1;
			((Control)va).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)va).Location = new Point(12, 5);
			((Control)va).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vg();
			((Control)va).Size = new Size(113, 17);
			((Control)va).TabIndex = 0;
			((Control)va).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vH();
			((ButtonBase)va).UseVisualStyleBackColor = true;
			va.CheckedChanged += new EventHandler(B);
			((Control)vB).AutoSize = true;
			vB.Checked = true;
			vB.CheckState = (CheckState)1;
			((Control)vB).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)vB).Location = new Point(12, 25);
			((Control)vB).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vh();
			((Control)vB).Size = new Size(94, 17);
			((Control)vB).TabIndex = 1;
			((Control)vB).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vI();
			((ButtonBase)vB).UseVisualStyleBackColor = true;
			vB.CheckedChanged += new EventHandler(b);
			vj.Interval = 1000;
			vj.Tick += new EventHandler(c);
			((TextBoxBase)vK).BorderStyle = (BorderStyle)1;
			((Control)vK).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)vK).Location = new Point(418, 3);
			((Control)vK).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fi();
			((Control)vK).Size = new Size(200, 22);
			((Control)vK).TabIndex = 3;
			((Control)vk).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)vk).Location = new Point(360, 27);
			((Control)vk).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vi();
			((Control)vk).Size = new Size(100, 23);
			((Control)vk).TabIndex = 4;
			((Control)vk).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vJ();
			((ButtonBase)vk).UseVisualStyleBackColor = true;
			((Control)vk).Click += new EventHandler(D);
			((Control)vL).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)vL).Location = new Point(467, 27);
			((Control)vL).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vj();
			((Control)vL).Size = new Size(100, 23);
			((Control)vL).TabIndex = 5;
			((Control)vL).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vK();
			((ButtonBase)vL).UseVisualStyleBackColor = true;
			((Control)vL).Click += new EventHandler(E);
			((Control)vl).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)vl).Location = new Point(574, 27);
			((Control)vl).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vk();
			((Control)vl).Size = new Size(100, 23);
			((Control)vl).TabIndex = 6;
			((Control)vl).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vL();
			((ButtonBase)vl).UseVisualStyleBackColor = true;
			((Control)vl).Click += new EventHandler(d);
			vM.DropDownStyle = (ComboBoxStyle)2;
			((Control)vM).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((ListControl)vM).FormattingEnabled = true;
			vM.Items.AddRange(new object[2]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vl(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vM()
			});
			((Control)vM).Location = new Point(137, 15);
			((Control)vM).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vm();
			((Control)vM).Size = new Size(200, 21);
			((Control)vM).TabIndex = 2;
			vM.SelectedIndexChanged += new EventHandler(a);
			vm.AllowUserToAddRows = false;
			vm.AllowUserToDeleteRows = false;
			vm.AllowUserToResizeColumns = false;
			vm.AllowUserToResizeRows = false;
			val5.Alignment = (DataGridViewContentAlignment)64;
			val5.Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			val5.Format = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VV();
			val5.NullValue = null;
			val5.WrapMode = (DataGridViewTriState)2;
			vm.AlternatingRowsDefaultCellStyle = val5;
			vm.BackgroundColor = Color.White;
			vm.ClipboardCopyMode = (DataGridViewClipboardCopyMode)2;
			vm.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
			val6.Alignment = (DataGridViewContentAlignment)64;
			val6.BackColor = Color.White;
			val6.Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
			val6.ForeColor = SystemColors.WindowText;
			val6.Format = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VV();
			val6.NullValue = null;
			val6.SelectionBackColor = SystemColors.Highlight;
			val6.SelectionForeColor = SystemColors.HighlightText;
			val6.WrapMode = (DataGridViewTriState)2;
			vm.ColumnHeadersDefaultCellStyle = val6;
			vm.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
			vm.Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[16]
			{
				(DataGridViewColumn)vN,
				(DataGridViewColumn)vn,
				(DataGridViewColumn)vO,
				(DataGridViewColumn)vo,
				(DataGridViewColumn)vP,
				(DataGridViewColumn)vp,
				(DataGridViewColumn)vQ,
				(DataGridViewColumn)vq,
				(DataGridViewColumn)vR,
				(DataGridViewColumn)vr,
				(DataGridViewColumn)vS,
				(DataGridViewColumn)vs,
				(DataGridViewColumn)vT,
				(DataGridViewColumn)vt,
				(DataGridViewColumn)vU,
				(DataGridViewColumn)vu
			});
			val7.Alignment = (DataGridViewContentAlignment)64;
			val7.BackColor = Color.White;
			val7.Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
			val7.ForeColor = SystemColors.ControlText;
			val7.Format = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VV();
			val7.NullValue = null;
			val7.SelectionBackColor = SystemColors.Highlight;
			val7.SelectionForeColor = SystemColors.HighlightText;
			val7.WrapMode = (DataGridViewTriState)2;
			vm.DefaultCellStyle = val7;
			vm.EditMode = (DataGridViewEditMode)1;
			vm.GridColor = Color.Black;
			((Control)vm).Location = new Point(12, 52);
			((Control)vm).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vN();
			vm.RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
			val8.Alignment = (DataGridViewContentAlignment)64;
			val8.BackColor = Color.White;
			val8.Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
			val8.ForeColor = SystemColors.WindowText;
			val8.Format = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VV();
			val8.NullValue = null;
			val8.SelectionBackColor = SystemColors.Highlight;
			val8.SelectionForeColor = SystemColors.HighlightText;
			val8.WrapMode = (DataGridViewTriState)2;
			vm.RowHeadersDefaultCellStyle = val8;
			vm.RowHeadersWidth = 500;
			vm.SelectionMode = (DataGridViewSelectionMode)0;
			vm.ShowCellErrors = false;
			vm.ShowRowErrors = false;
			((Control)vm).Size = new Size(960, 447);
			((Control)vm).TabIndex = 8;
			vm.VirtualMode = true;
			((Control)vm).Visible = false;
			vm.CellToolTipTextNeeded += new DataGridViewCellToolTipTextNeededEventHandler(a);
			vm.CellValueNeeded += new DataGridViewCellValueEventHandler(a);
			vm.CurrentCellChanged += new EventHandler(c);
			vm.SelectionChanged += new EventHandler(c);
			((Control)vm).KeyDown += new KeyEventHandler(a);
			((DataGridViewColumn)vN).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn();
			((DataGridViewColumn)vN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vn();
			((DataGridViewColumn)vN).Width = 27;
			((DataGridViewColumn)vn).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CJ();
			((DataGridViewColumn)vn).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vO();
			((DataGridViewColumn)vn).Width = 27;
			((DataGridViewColumn)vO).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cb();
			((DataGridViewColumn)vO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vo();
			((DataGridViewColumn)vO).Width = 27;
			((DataGridViewColumn)vo).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ca();
			((DataGridViewColumn)vo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vP();
			((DataGridViewColumn)vo).Width = 27;
			((DataGridViewColumn)vP).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cz();
			((DataGridViewColumn)vP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vp();
			((DataGridViewColumn)vP).Width = 27;
			((DataGridViewColumn)vp).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cy();
			((DataGridViewColumn)vp).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vQ();
			((DataGridViewColumn)vp).Width = 27;
			((DataGridViewColumn)vQ).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cx();
			((DataGridViewColumn)vQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vq();
			((DataGridViewColumn)vQ).Width = 27;
			((DataGridViewColumn)vq).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cw();
			((DataGridViewColumn)vq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vR();
			((DataGridViewColumn)vq).Width = 27;
			((DataGridViewColumn)vR).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vA();
			((DataGridViewColumn)vR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vr();
			((DataGridViewColumn)vR).Width = 27;
			((DataGridViewColumn)vr).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vB();
			((DataGridViewColumn)vr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vS();
			((DataGridViewColumn)vr).Width = 27;
			((DataGridViewColumn)vS).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mP();
			((DataGridViewColumn)vS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vs();
			((DataGridViewColumn)vS).Width = 27;
			((DataGridViewColumn)vs).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vc();
			((DataGridViewColumn)vs).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vT();
			((DataGridViewColumn)vs).Width = 27;
			((DataGridViewColumn)vT).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vd();
			((DataGridViewColumn)vT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vt();
			((DataGridViewColumn)vT).Width = 27;
			((DataGridViewColumn)vt).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MS();
			((DataGridViewColumn)vt).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vU();
			((DataGridViewColumn)vt).Width = 27;
			((DataGridViewColumn)vU).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vF();
			((DataGridViewColumn)vU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vu();
			((DataGridViewColumn)vU).Width = 27;
			((DataGridViewColumn)vu).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mj();
			((DataGridViewColumn)vu).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vV();
			((DataGridViewColumn)vu).Width = 27;
			((Control)vV).Location = new Point(700, 4);
			((Control)vV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vv();
			((Control)vV).Size = new Size(270, 13);
			((Control)vV).TabIndex = 9;
			((Control)vV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cv();
			((Control)vv).Location = new Point(700, 19);
			((Control)vv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vW();
			((Control)vv).Size = new Size(270, 13);
			((Control)vv).TabIndex = 10;
			((Control)vv).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vw();
			((Control)vW).Location = new Point(700, 34);
			((Control)vW).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vX();
			((Control)vW).Size = new Size(270, 13);
			((Control)vW).TabIndex = 11;
			((Control)vW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vx();
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(984, 511);
			((Control)this).Controls.Add((Control)(object)vW);
			((Control)this).Controls.Add((Control)(object)vv);
			((Control)this).Controls.Add((Control)(object)vV);
			((Control)this).Controls.Add((Control)(object)vm);
			((Control)this).Controls.Add((Control)(object)vM);
			((Control)this).Controls.Add((Control)(object)vl);
			((Control)this).Controls.Add((Control)(object)vL);
			((Control)this).Controls.Add((Control)(object)vk);
			((Control)this).Controls.Add((Control)(object)vK);
			((Control)this).Controls.Add((Control)(object)vB);
			((Control)this).Controls.Add((Control)(object)va);
			((Control)this).Controls.Add((Control)(object)vA);
			((Control)this).DoubleBuffered = true;
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vY();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)0;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ch();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)this).Resize += new EventHandler(C);
			((ISupportInitialize)vA).EndInit();
			((ISupportInitialize)vm).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
namespace b
{
	internal static class bT
	{
		internal static readonly string avG = BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ags();

		private static readonly string avg = BM.Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agT();

		private static readonly string avH = avG + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agt();

		private static readonly string avh = avG + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agU();

		private static Dictionary<string, ValueTuple<string, string>> avI = new Dictionary<string, ValueTuple<string, string>>();

		private static readonly object avi = new object();

		internal static readonly object avJ = new object();

		internal static int avj = 100;

		internal static bv A(string P_0)
		{
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Invalid comparison between Unknown and I4
			//IL_059f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a5: Invalid comparison between Unknown and I4
			bv bv2 = bx.A(P_0);
			if (bv2 != null)
			{
				return bv2;
			}
			k k = null;
			int axq = -1;
			int axR = -1;
			Stream val = null;
			try
			{
				val = (Stream)(object)S.a(P_0, M.a());
			}
			catch (FileNotFoundException)
			{
				return null;
			}
			bool flag;
			try
			{
				flag = R.A(val);
			}
			catch
			{
				flag = false;
			}
			Stream val3 = null;
			if (flag)
			{
				if (R.A(val, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGW(), out val3, null))
				{
					Stream val4 = null;
					if (!R.A(val3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGw(), out val4, M.A()))
					{
						val3.Close();
						return null;
					}
					XmlReader val5 = XmlReader.Create(val4);
					val5.Read();
					while ((int)val5.NodeType != 1)
					{
						val5.Read();
					}
					bool flag2 = false;
					bool flag3 = false;
					if (!val5.IsEmptyElement)
					{
						val5.Read();
						while (val5.IsStartElement())
						{
							bool flag4 = true;
							if (val5.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGX())
							{
								if (!val5.IsEmptyElement)
								{
									while (val5.IsStartElement() && (k == null || !flag2 || !flag3))
									{
										string name = val5.Name;
										if (name != null)
										{
											switch (name.Length)
											{
											case 3:
											{
												char c = name[0];
												if (c != 'M')
												{
													if (c != 'T' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGx()))
													{
														break;
													}
												}
												else if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGY()))
												{
													break;
												}
												goto IL_03f2;
											}
											case 8:
											{
												char c = name[0];
												if (c != 'F')
												{
													if (c == 'H')
													{
														if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGZ()))
														{
															break;
														}
														goto IL_03f2;
													}
													if (c != 'P' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGz()))
													{
														break;
													}
												}
												else if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agA()))
												{
													break;
												}
												goto IL_03fe;
											}
											case 11:
											{
												char c = name[0];
												if (c != 'I')
												{
													if (c != 'P' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agB()))
													{
														break;
													}
												}
												else if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aga()))
												{
													break;
												}
												goto IL_03fe;
											}
											case 14:
											{
												char c = name[7];
												if (c != 'E')
												{
													if (c != 'N' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agc()))
													{
														break;
													}
												}
												else if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agC()))
												{
													break;
												}
												goto IL_03fe;
											}
											case 21:
											{
												char c = name[7];
												if (c != 'D')
												{
													if (c != 'S' || !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.age()))
													{
														break;
													}
												}
												else if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agE()))
												{
													break;
												}
												goto IL_03fe;
											}
											case 7:
												switch (name[1])
												{
												case 'a':
													if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agg())
													{
														val5.Read();
														axR = int.Parse(val5.Value, (NumberStyles)512);
														flag3 = true;
														val5.Skip();
													}
													break;
												case 'e':
													if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bs())
													{
														val5.Read();
														string text = string.Empty;
														byte[] array = n.A(val5.Value);
														foreach (byte b in array)
														{
															System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(text);
															char c = (char)b;
															text = string.Concat(readOnlySpan, new System.ReadOnlySpan<char>(ref c));
														}
														k = new k(text, false);
														val5.Skip();
													}
													break;
												}
												break;
											case 10:
												if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGy()))
												{
													break;
												}
												goto IL_03f2;
											case 15:
												if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agb()))
												{
													break;
												}
												goto IL_03fe;
											case 18:
												if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agD()))
												{
													break;
												}
												goto IL_03fe;
											case 17:
												if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agd()))
												{
													break;
												}
												goto IL_03fe;
											case 20:
												if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agF()))
												{
													break;
												}
												goto IL_03fe;
											case 27:
												if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agf()))
												{
													break;
												}
												goto IL_03fe;
											case 9:
												{
													if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agG())
													{
														val5.Read();
														axq = int.Parse(val5.Value, (NumberStyles)512);
														flag2 = true;
														val5.Skip();
													}
													break;
												}
												IL_03fe:
												val5.Read();
												val5.Skip();
												break;
												IL_03f2:
												val5.Skip();
												break;
											}
										}
										val5.Read();
									}
								}
							}
							else
							{
								flag4 = false;
							}
							if (!flag4)
							{
								val5.Skip();
							}
							else
							{
								val5.Read();
							}
						}
					}
					val5.Close();
					val4.Close();
				}
				else
				{
					val3 = null;
				}
			}
			if (val3 != null)
			{
				val3.Close();
			}
			if (k != null)
			{
				bv2 = new bv
				{
					axq = axq,
					axR = axR,
					axr = k
				};
				val.Close();
				return bv2;
			}
			Stream val6 = null;
			if (flag)
			{
				if (!R.A(val, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agH(), out val6, null))
				{
					val.Close();
					return null;
				}
			}
			else
			{
				val6 = val;
			}
			XmlReader val7 = XmlReader.Create(val6);
			val7.Read();
			while ((int)val7.NodeType != 1)
			{
				val7.Read();
			}
			if (!val7.IsEmptyElement)
			{
				axq = int.Parse(val7.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agh()));
				axR = int.Parse(val7.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agI()));
				k = new k(val7.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bU()), false);
			}
			val7.Close();
			if (val6 != null)
			{
				val6.Close();
			}
			val.Close();
			if (k != null)
			{
				bv2 = new bv
				{
					axq = axq,
					axR = axR,
					axr = k
				};
			}
			return bv2;
		}

		internal static string a(string P_0)
		{
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Invalid comparison between Unknown and I4
			Stream val = (Stream)(object)S.a(P_0, M.a());
			bool flag;
			try
			{
				flag = R.A(val);
			}
			catch (System.Exception)
			{
				flag = false;
			}
			Stream val2 = null;
			if (flag)
			{
				if (!R.A(val, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agH(), out val2, null))
				{
					val.Close();
					return null;
				}
			}
			else
			{
				val2 = val;
			}
			XmlReader val3 = XmlReader.Create(val2);
			val3.Read();
			while ((int)val3.NodeType != 1)
			{
				val3.Read();
			}
			string result = null;
			if (!val3.IsEmptyElement)
			{
				result = val3.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agi());
			}
			val3.Close();
			if (val2 != null)
			{
				val2.Close();
			}
			val.Close();
			return result;
		}

		internal static void A()
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				if (!Directory.Exists(avG))
				{
					Directory.CreateDirectory(avG);
				}
				List<string> val = new List<string>();
				Enumerator<string, ValueTuple<string, string>> enumerator = avI.Keys.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						val.Add(string.Concat(new string[5]
						{
							current,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agJ(),
							avI[current].Item1,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agj(),
							avI[current].Item2
						}));
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				if (File.Exists(avh))
				{
					File.Delete(avh);
				}
				File.WriteAllLines(avh, (System.Collections.Generic.IEnumerable<string>)val);
				File.SetAttributes(avh, (FileAttributes)2);
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agK() + ex.Message, true);
			}
		}

		internal static void a()
		{
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				avI.Clear();
				if (!File.Exists(avh))
				{
					return;
				}
				StreamReader val = File.OpenText(avh);
				try
				{
					string text;
					while ((text = ((TextReader)val).ReadLine()) != null)
					{
						int num = text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agJ());
						int num2 = text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agj());
						if (num != -1 && num2 != -1)
						{
							string text2 = text.Substring(0, num);
							string text3 = text.Substring(num + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agJ().Length, 32);
							string text4 = text.Substring(num2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agj().Length);
							avI.Add(text2, new ValueTuple<string, string>(text3, text4));
						}
					}
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agk() + ex.Message, true);
			}
		}

		internal static string B(string P_0)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			string text = null;
			string text2 = null;
			string text3 = null;
			try
			{
				text = Path.GetFullPath(P_0);
				if (avI.ContainsKey(text))
				{
					text3 = N.A(File.GetLastWriteTime(text), true);
					if (avI[text].Item2 == text3)
					{
						text2 = avI[text].Item1;
					}
				}
			}
			catch
			{
				text2 = null;
			}
			if (text2 == null)
			{
				byte[] array = N.a(P_0);
				if (array != null)
				{
					text2 = n.A(array);
					if (text != null)
					{
						try
						{
							if (text3 == null)
							{
								text3 = N.A(File.GetLastWriteTime(text), true);
							}
							avI[text] = new ValueTuple<string, string>(text2, text3);
						}
						catch
						{
							if (avI.ContainsKey(text))
							{
								avI.Remove(text);
							}
						}
					}
				}
			}
			return text2;
		}

		internal static bool A(string P_0, bW P_1, out bool P_2, out bool P_3, out k P_4)
		{
			bv bv2 = A(P_0);
			bool flag = false;
			P_2 = false;
			P_3 = false;
			P_4 = null;
			if (bv2 != null)
			{
				P_4 = bv2.axr;
				bv bv3 = new bv
				{
					axq = P_1.axS,
					axR = P_1.axs,
					axr = P_1.axT
				};
				if (bv2 == bv3)
				{
					flag = true;
					P_2 = true;
					P_3 = true;
				}
				else
				{
					P_2 = bv2.axq == P_1.axS && bv2.axR == P_1.axs;
					P_3 = P_4 == P_1.axT;
				}
			}
			if (flag)
			{
				if (P_1.axt == null)
				{
					return true;
				}
				string text = B(P_0);
				if (text != null)
				{
					string text2 = n.A(P_1.axt);
					if (text == text2)
					{
						return true;
					}
				}
			}
			return false;
		}

		internal static void B()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			Stopwatch val = new Stopwatch();
			val.Start();
			bool flag = false;
			try
			{
				Monitor.TryEnter(avi, ref flag);
				if (!flag)
				{
					lock (avi)
					{
						val.Stop();
						return;
					}
				}
				if (!Directory.Exists(avG))
				{
					Directory.CreateDirectory(avG);
				}
				if (File.Exists(avH))
				{
					File.Delete(avH);
				}
				((Stream)File.Create(avH)).Close();
				File.SetAttributes(avH, (FileAttributes)128);
				string[] files = Directory.GetFiles(avG, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agL());
				string[] array;
				string[] array2;
				if (Directory.Exists(avg))
				{
					string[] files2 = Directory.GetFiles(avg, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agL());
					array = new string[files.Length + files2.Length];
					int num = 0;
					array2 = files;
					foreach (string text in array2)
					{
						array[num] = text;
						num++;
					}
					array2 = files2;
					foreach (string text2 in array2)
					{
						array[num] = text2;
						num++;
					}
				}
				else
				{
					array = new string[files.Length];
					int num2 = 0;
					array2 = files;
					foreach (string text3 in array2)
					{
						array[num2] = text3;
						num2++;
					}
				}
				array2 = array;
				foreach (string text4 in array2)
				{
					bv bv2 = A(text4);
					if (bv2 != null)
					{
						List<string> val2 = new List<string>();
						val2.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agl() + text4);
						val2.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agM() + bv2.axq);
						val2.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agm() + bv2.axR);
						val2.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agN() + ((object)bv2.axr).ToString());
						val2.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
						File.AppendAllLines(avH, (System.Collections.Generic.IEnumerable<string>)val2);
					}
				}
				File.SetAttributes(avH, (FileAttributes)2);
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agn() + ex.Message, true);
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(avi);
				}
			}
			val.Stop();
			N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agO(), (object)val.ElapsedMilliseconds), true);
		}

		internal static void A(string P_0, int P_1, int P_2, k P_3)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			Stopwatch val = new Stopwatch();
			val.Start();
			bool flag = false;
			try
			{
				Monitor.TryEnter(avi, ref flag);
				if (!flag)
				{
					return;
				}
				if (!Directory.Exists(avG))
				{
					Directory.CreateDirectory(avG);
				}
				if (File.Exists(avH))
				{
					StreamReader val2 = File.OpenText(avH);
					try
					{
						string text;
						while ((text = ((TextReader)val2).ReadLine()) != null)
						{
							if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agl()) && Path.GetFullPath(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agl().Length)) == Path.GetFullPath(P_0))
							{
								return;
							}
						}
					}
					finally
					{
						((System.IDisposable)val2)?.Dispose();
					}
				}
				else
				{
					((Stream)File.Create(avH)).Close();
				}
				File.SetAttributes(avH, (FileAttributes)128);
				List<string> val3 = new List<string>();
				val3.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agl() + P_0);
				val3.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agM() + P_1);
				val3.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agm() + P_2);
				val3.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agN() + ((object)P_3).ToString());
				val3.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
				File.AppendAllLines(avH, (System.Collections.Generic.IEnumerable<string>)val3);
				File.SetAttributes(avH, (FileAttributes)2);
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ago() + ex.Message, true);
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(avi);
				}
			}
			val.Stop();
			N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agP(), (object)val.ElapsedMilliseconds), true);
		}

		internal static string A(int P_0, int P_1, k P_2, byte[] P_3, bool P_4)
		{
			string text = null;
			lock (avi)
			{
				bool flag = false;
				do
				{
					if (!File.Exists(avH))
					{
						B();
						flag = true;
					}
					string text2 = string.Empty;
					int num = -1;
					int num2 = -1;
					k k = null;
					k k2 = null;
					try
					{
						StreamReader val = File.OpenText(avH);
						try
						{
							string text3;
							while ((text3 = ((TextReader)val).ReadLine()) != null)
							{
								if (text3.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agl()))
								{
									text2 = text3.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agl().Length);
								}
								else if (text3.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agM()))
								{
									num = int.Parse(text3.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agM().Length));
								}
								else if (text3.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agm()))
								{
									num2 = int.Parse(text3.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agm().Length));
								}
								else if (text3.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agN()))
								{
									k = new k(text3.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agN().Length), false);
								}
								else if (P_2 == null)
								{
									if (num == P_0 && num2 == P_1 && (k2 == null || k > k2))
									{
										k2 = k;
										text = text2;
									}
								}
								else
								{
									if (num != P_0 || num2 != P_1 || !(k == P_2))
									{
										continue;
									}
									if (P_3 != null)
									{
										string text4 = B(text2);
										if (text4 != null)
										{
											string text5 = n.A(P_3);
											if (text4 == text5)
											{
												text = text2;
												break;
											}
										}
									}
									else if (File.Exists(text2))
									{
										text = text2;
										break;
									}
								}
							}
						}
						finally
						{
							((System.IDisposable)val)?.Dispose();
						}
					}
					catch
					{
					}
					if (!P_4 || !string.IsNullOrEmpty(text) || flag)
					{
						break;
					}
					B();
					flag = true;
				}
				while (string.IsNullOrEmpty(text));
			}
			return text;
		}

		internal static string A(int P_0, int P_1, k P_2)
		{
			string result = null;
			lock (avi)
			{
				if (!File.Exists(avH))
				{
					B();
				}
				string text = string.Empty;
				int num = -1;
				int num2 = -1;
				k k = null;
				try
				{
					StreamReader val = File.OpenText(avH);
					try
					{
						string text2;
						while ((text2 = ((TextReader)val).ReadLine()) != null)
						{
							if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agl()))
							{
								text = text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agl().Length);
							}
							else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agM()))
							{
								num = int.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agM().Length));
							}
							else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agm()))
							{
								num2 = int.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agm().Length));
							}
							else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agN()))
							{
								k = new k(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agN().Length), false);
							}
							else if (num == P_0 && num2 == P_1 && k != null && k == P_2)
							{
								result = text;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)val)?.Dispose();
					}
				}
				catch
				{
				}
			}
			return result;
		}

		internal static string A(int P_0, int P_1, out k P_2)
		{
			string result = null;
			P_2 = null;
			lock (avi)
			{
				if (!File.Exists(avH))
				{
					B();
				}
				string text = string.Empty;
				int num = -1;
				int num2 = -1;
				k k = null;
				try
				{
					StreamReader val = File.OpenText(avH);
					try
					{
						string text2;
						while ((text2 = ((TextReader)val).ReadLine()) != null)
						{
							if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agl()))
							{
								text = text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agl().Length);
							}
							else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agM()))
							{
								num = int.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agM().Length));
							}
							else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agm()))
							{
								num2 = int.Parse(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agm().Length));
							}
							else if (text2.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agN()))
							{
								k = new k(text2.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agN().Length), false);
							}
							else if (num == P_0 && num2 == P_1 && (P_2 == null || k > P_2))
							{
								P_2 = k;
								result = text;
							}
						}
					}
					finally
					{
						((System.IDisposable)val)?.Dispose();
					}
				}
				catch
				{
				}
			}
			return result;
		}

		internal static List<string> b()
		{
			List<string> val = null;
			if (!File.Exists(avH))
			{
				B();
			}
			lock (avi)
			{
				bool flag = false;
				int num = 100;
				do
				{
					try
					{
						StreamReader val2 = File.OpenText(avH);
						try
						{
							flag = true;
							if (val == null)
							{
								val = new List<string>();
							}
							string text;
							while ((text = ((TextReader)val2).ReadLine()) != null)
							{
								if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agl()))
								{
									val.Add(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agl().Length));
								}
							}
						}
						finally
						{
							((System.IDisposable)val2)?.Dispose();
						}
					}
					catch (System.Exception ex)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agp() + ex.Message, true);
					}
					num--;
				}
				while (num != 0 && !flag);
			}
			return val;
		}

		internal static string A(byte[] P_0, string P_1, out bW P_2)
		{
			P_2 = null;
			string text = null;
			lock (avJ)
			{
				if (!Directory.Exists(avG))
				{
					Directory.CreateDirectory(avG);
				}
				string text2 = avG + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK() + P_1;
				File.WriteAllBytes(text2, P_0);
				bv bv2 = A(text2);
				byte[] array = null;
				MD5 val = MD5.Create();
				try
				{
					array = ((HashAlgorithm)val).ComputeHash(P_0);
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
				string text3 = n.A(array);
				P_2 = new bW
				{
					axS = bv2.axq,
					axs = bv2.axR,
					axT = bv2.axr,
					axt = array
				};
				string text4 = bx.A(bv2.axq, bv2.axR, bv2.axr);
				string text5 = avG + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK() + text4;
				if (File.Exists(text5))
				{
					if (B(text5) == text3)
					{
						int num = 5;
						do
						{
							try
							{
								File.Delete(text2);
							}
							catch
							{
								num--;
								if (num != 0)
								{
									Thread.Sleep(200);
								}
								continue;
							}
							break;
						}
						while (num != 0);
					}
					else
					{
						text5 = string.Concat(new string[5]
						{
							avG,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK(),
							text3,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax(),
							text4
						});
						int num2 = 5;
						do
						{
							try
							{
								if (File.Exists(text5))
								{
									File.Delete(text2);
								}
								else
								{
									File.Move(text2, text5);
								}
							}
							catch
							{
								num2--;
								if (num2 != 0)
								{
									Thread.Sleep(200);
								}
								continue;
							}
							break;
						}
						while (num2 != 0);
					}
				}
				else
				{
					string[] files = Directory.GetFiles(avG, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agL());
					bool flag = false;
					string[] array2 = files;
					foreach (string text6 in array2)
					{
						if (Path.GetFullPath(text6) != Path.GetFullPath(text2) && B(text6) == text3)
						{
							flag = true;
							text5 = text6;
							break;
						}
					}
					int num3 = 5;
					do
					{
						try
						{
							if (flag)
							{
								File.Delete(text2);
							}
							else
							{
								File.Move(text2, text5);
							}
						}
						catch
						{
							num3--;
							if (num3 != 0)
							{
								Thread.Sleep(200);
							}
							continue;
						}
						break;
					}
					while (num3 != 0);
				}
				return text5;
			}
		}

		internal static List<string> b(string P_0)
		{
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			List<string> val = new List<string>();
			if (Directory.Exists(CZ.Bdl))
			{
				try
				{
					FileStream val2 = File.OpenRead(P_0);
					try
					{
						List<string> val3 = R.A((Stream)(object)val2, null);
						for (int i = 0; i < val3.Count; i++)
						{
							string text = val3[i];
							if (!text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny()) && !text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agQ()))
							{
								continue;
							}
							Stream val4 = null;
							if (R.A((Stream)(object)val2, text, out val4, null))
							{
								BinaryReader val5 = new BinaryReader(val4);
								byte[] array;
								try
								{
									array = val5.ReadBytes((int)val5.BaseStream.Length);
								}
								finally
								{
									((System.IDisposable)val5)?.Dispose();
								}
								bW bW2;
								string text2 = A(array, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agq() + text, out bW2);
								if (text2 != null)
								{
									val.Add(text2);
								}
							}
						}
					}
					finally
					{
						((System.IDisposable)val2)?.Dispose();
					}
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agR() + ex.Message, true);
				}
			}
			return val;
		}

		internal static void C(string P_0)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			bool flag = false;
			try
			{
				Monitor.TryEnter(CZ.Bdn, ref flag);
				if (!flag)
				{
					b(P_0);
					return;
				}
				CY cY = CU.A(P_0);
				if (cY != null)
				{
					Enumerator<CX> enumerator = cY.BdF.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							CX current = enumerator.Current;
							if (string.IsNullOrEmpty(A(current.BdC.axS, current.BdC.axs, current.BdC.axT, current.BdC.axt, false)))
							{
								b(P_0);
								break;
							}
						}
						return;
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				b(P_0);
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agr() + ex.Message, true);
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(CZ.Bdn);
				}
			}
		}

		internal static void C()
		{
			B();
			if (Directory.Exists(CZ.Bdl))
			{
				string[] files;
				try
				{
					files = Directory.GetFiles(CZ.Bdl, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aCe());
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agS() + ex.Message, true);
					return;
				}
				avj = 0;
				int num = 0;
				string[] array = files;
				for (int i = 0; i < array.Length; i++)
				{
					C(array[i]);
					num++;
					avj = num * 100 / files.Length;
					Thread.Sleep(0);
				}
				avj = 100;
			}
			B();
		}
	}
	internal enum bt : byte
	{
		avK = 0,
		avk = 1,
		avL = 2,
		avl = 3,
		avM = 4,
		avm = 5,
		avN = 6,
		avn = 7,
		avO = 8,
		avo = 9,
		avP = 10,
		avp = 11,
		avQ = 12,
		avq = 13,
		avR = 14,
		avr = 15,
		avS = 16,
		avs = 17,
		avT = 18,
		avt = 19,
		avU = 20,
		avu = 21,
		avV = 22,
		avv = 23,
		avW = 24,
		avw = 25,
		avX = 26,
		avx = 27,
		avY = 28,
		avy = 29,
		avZ = 129,
		avz = 130,
		aWA = 131,
		aWa = 252,
		aWB = 253,
		aWb = 254,
		aWC = 255
	}
}
