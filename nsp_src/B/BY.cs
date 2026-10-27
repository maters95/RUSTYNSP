using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;

namespace B
{
	internal class BY : Form
	{
		private static BY YG;

		private Framework Yg;

		private SortedList<string, ListViewItem> YH;

		private List<int> Yh;

		private int YI;

		private IContainer Yi;

		private ThemedButton YJ;

		private ThemedButton Yj;

		private Timer YK;

		private ag Yk;

		private ThemedTextBox YL;

		private ThemedButton Yl;

		private ab YM;

		private ColumnHeader Ym;

		private ColumnHeader YN;

		private ColumnHeader Yn;

		private ColumnHeader YO;

		private ThemedButton Yo;

		private ThemedButton YP;

		private ab Yp;

		private ColumnHeader YQ;

		private ColumnHeader Yq;

		private ColumnHeader YR;

		private ColumnHeader Yr;

		private Label YS;

		private PictureBox Ys;

		internal static List<int> A(IWin32Window P_0, Framework P_1, List<int> P_2, int P_3)
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Invalid comparison between Unknown and I4
			if (YG == null)
			{
				YG = new BY();
			}
			YG.Yg = P_1;
			YG.A(P_2);
			YG.YI = P_3;
			((Control)YG).BackColor = BM.td;
			((Control)YG.Ys).BackColor = BM.td;
			if (YG.Ys.Image != null)
			{
				YG.Ys.Image.Dispose();
			}
			YG.Ys.Image = (Image)(object)O.A((Image)(object)GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
			((Control)YG.Yk).BackColor = BM.tH;
			((Control)YG.Yk).ForeColor = BM.te;
			((Control)YG.YM).BackColor = BM.tH;
			((Control)YG.YM).ForeColor = BM.te;
			((Control)YG.Yp).BackColor = BM.tH;
			((Control)YG.Yp).ForeColor = BM.te;
			((Control)YG.YS).ForeColor = BM.te;
			((Control)YG.YL).BackColor = BM.to;
			((Control)YG.YL).ForeColor = BM.te;
			DialogResult val = ((Form)YG).ShowDialog(P_0);
			YG.Yg = null;
			if ((int)val == 1)
			{
				return YG.A();
			}
			return null;
		}

		internal BY()
		{
			B();
			Yh = new List<int>();
			YH = new SortedList<string, ListViewItem>();
			YL.A(A);
		}

		[SpecialName]
		internal List<int> A()
		{
			return Yh;
		}

		[SpecialName]
		internal void A(List<int> P_0)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			Yh.Clear();
			if (P_0 == null || Yg == null)
			{
				return;
			}
			Enumerator<int> enumerator = P_0.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					if (Yg.A(current) != null)
					{
						Yh.Add(current);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private void A(int P_0)
		{
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			if (Yg == null)
			{
				return;
			}
			Setting setting = Yg.A(P_0);
			if (setting == null)
			{
				((Control)Yk).Text = string.Empty;
				return;
			}
			string text = ((SettingOrSpecialObject)setting).A(bz.aYt);
			if (text != null)
			{
				((Control)Yk).Text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FI();
			}
			else
			{
				((Control)Yk).Text = ((SettingOrSpecialObject)setting).B() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FI();
			}
			((TextBoxBase)Yk).Select(0, ((TextBoxBase)Yk).TextLength);
			((RichTextBox)Yk).SelectionFont = new Font(((RichTextBox)Yk).SelectionFont.FontFamily, ((RichTextBox)Yk).SelectionFont.Size, (FontStyle)1);
			((TextBoxBase)Yk).SelectionLength = 0;
			int textLength = ((TextBoxBase)Yk).TextLength;
			string text2 = ((SettingOrSpecialObject)setting).A(bz.aYU);
			if (text2 != null)
			{
				((TextBoxBase)Yk).AppendText(text2);
			}
			else if (text != null)
			{
				((TextBoxBase)Yk).AppendText(text);
			}
			else
			{
				string text3 = ((SettingOrSpecialObject)setting).A(bz.aYT);
				if (text3 != null)
				{
					((TextBoxBase)Yk).AppendText(text3);
				}
				else
				{
					((TextBoxBase)Yk).AppendText(((SettingOrSpecialObject)setting).B());
				}
			}
			int num = ((TextBoxBase)Yk).TextLength - textLength;
			((TextBoxBase)Yk).Select(textLength, num);
			((TextBoxBase)Yk).SelectionLength = 0;
		}

		private void A(object P_0, EventArgs P_1)
		{
			((Control)YP).Enabled = ((ListView)YM).SelectedItems.Count != 0;
			if (((ListView)YM).SelectedItems.Count == 1)
			{
				A((int)((ListView)YM).SelectedItems[0].Tag);
			}
			else
			{
				((Control)Yk).Text = string.Empty;
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			((Control)Yo).Enabled = ((ListView)Yp).SelectedItems.Count != 0;
			if (((ListView)Yp).SelectedItems.Count == 1)
			{
				A((int)((ListView)Yp).SelectedItems[0].Tag);
			}
			else
			{
				((Control)Yk).Text = string.Empty;
			}
		}

		private void A(object P_0, DragEventArgs P_1)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			Yh.Clear();
			foreach (ListViewItem item in ((ListView)Yp).Items)
			{
				ListViewItem val = item;
				Yh.Add((int)val.Tag);
			}
		}

		private void A(object P_0, KeyPressEventArgs P_1)
		{
			YK.Stop();
			YK.Start();
		}

		private void A(object P_0, ThemedTextBox.B P_1)
		{
			YK.Stop();
			YK.Start();
		}

		private void B(object P_0, EventArgs P_1)
		{
			YK.Stop();
			a();
		}

		private void A(object P_0, KeyEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Invalid comparison between Unknown and I4
			if ((int)P_1.KeyCode == 40)
			{
				if (((ListView)YM).SelectedIndices.Count != 0)
				{
					((Control)YM).Focus();
				}
			}
			else if ((int)P_1.KeyCode == 13)
			{
				C(this, EventArgs.Empty);
				((TextBoxBase)YL).SelectAll();
			}
		}

		private void a()
		{
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			if (Yg == null)
			{
				return;
			}
			string text = ((Control)YL).Text.ToUpper();
			string[] array = text.Split(RuntimeHelpers.CreateSpan<char>((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/));
			((ListView)YM).BeginUpdate();
			((ListView)YM).Items.Clear();
			System.Collections.Generic.IEnumerator<ListViewItem> enumerator = ((System.Collections.Generic.IEnumerable<ListViewItem>)YH.Values).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					ListViewItem current = enumerator.Current;
					if (((ListView)Yp).Items.Contains(current))
					{
						continue;
					}
					Setting setting = Yg.A((int)current.Tag);
					if (setting == null)
					{
						continue;
					}
					string text2 = ((SettingOrSpecialObject)setting).A(true);
					string text3 = string.Empty;
					if (((SettingOrSpecialObject)setting).s() != null)
					{
						text3 = ((SettingOrSpecialObject)setting).s();
					}
					string text4 = ((SettingOrSpecialObject)setting).A(bz.aYT);
					if (text4 == null)
					{
						text4 = ((SettingOrSpecialObject)setting).B();
					}
					string text5 = text4.ToUpper();
					string text6 = text2.ToUpper();
					string text7 = text3.ToUpper();
					bool flag = true;
					bool flag2 = false;
					if (text == text6 || text == text5)
					{
						flag2 = true;
					}
					else
					{
						Enumerator<string> enumerator2 = ((SettingOrSpecialObject)setting).i().GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								string current2 = enumerator2.Current;
								if (text == current2.ToUpper())
								{
									flag2 = true;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator2).Dispose();
						}
					}
					if (!flag2)
					{
						string[] array2 = array;
						foreach (string text8 in array2)
						{
							if (text6.Contains(text8) || text5.Contains(text8) || text7.Contains(text8))
							{
								continue;
							}
							bool flag3 = false;
							Enumerator<string> enumerator2 = ((SettingOrSpecialObject)setting).i().GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									if (enumerator2.Current.ToUpper().Contains(text8))
									{
										flag3 = true;
										break;
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator2).Dispose();
							}
							if (!flag3)
							{
								flag = false;
								break;
							}
						}
					}
					if (flag)
					{
						current.Selected = false;
						if (((ListView)YM).Items.Count != 0 && flag2)
						{
							((ListView)YM).Items.Insert(0, current);
						}
						else
						{
							((ListView)YM).Items.Add(current);
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			if (((ListView)YM).Items.Count != 0)
			{
				ListViewItem val = ((ListView)YM).Items[0];
				val.Selected = true;
				((ListView)YM).FocusedItem = val;
			}
			((ListView)YM).EndUpdate();
			YM.a();
			Yp.a();
		}

		private void b(object P_0, EventArgs P_1)
		{
			((TextBoxBase)YL).Clear();
			A((object)null, (KeyPressEventArgs)null);
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Expected O, but got Unknown
			//IL_0333: Unknown result type (might be due to invalid IL or missing references)
			//IL_033a: Expected O, but got Unknown
			if (((Control)this).Visible && Yg != null)
			{
				((TextBoxBase)YL).Clear();
				YH.Clear();
				((ListView)YM).Items.Clear();
				((ListView)Yp).Items.Clear();
				List<string> val = new List<string>();
				Enumerator<Setting> enumerator = Yg.aWt.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Setting current = enumerator.Current;
						if (!((SettingOrSpecialObject)current).l() || !current.aC() || current.al() || (((Control)BM.QQ.rn).Visible && !BM.C(current.A())) || !PortFunction.A(current))
						{
							continue;
						}
						string text = ((SettingOrSpecialObject)current).A(bz.aYt);
						if (text == null)
						{
							text = ((SettingOrSpecialObject)current).B();
						}
						string text2 = ((SettingOrSpecialObject)current).H();
						if (!string.IsNullOrWhiteSpace(text2))
						{
							text = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
						}
						string text3 = string.Empty;
						if (((SettingOrSpecialObject)current).s() != null)
						{
							text3 = ((SettingOrSpecialObject)current).s();
						}
						string text4 = ((SettingOrSpecialObject)current).A(bz.aYT);
						if (text4 == null)
						{
							text4 = ((SettingOrSpecialObject)current).B();
						}
						int num = current.aS();
						string text5 = bS.A(current.@as(), num, false, 0);
						ListViewItem val2 = new ListViewItem(new string[4] { text, text3, text4, text5 });
						val2.Name = text;
						val2.Tag = current.A();
						if (YH.ContainsKey(text))
						{
							if (!val.Contains(text))
							{
								val.Add(text);
							}
						}
						else
						{
							YH.Add(text, val2);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				if (val.Count != 0)
				{
					string text6 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yo();
					Enumerator<string> enumerator2 = val.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							string current2 = enumerator2.Current;
							text6 = text6 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy() + current2;
						}
					}
					finally
					{
						((System.IDisposable)enumerator2).Dispose();
					}
					bE.A((IWin32Window)(object)this, text6, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				a();
				Enumerator<int> enumerator3 = Yh.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						int current3 = enumerator3.Current;
						Setting setting = Yg.A(current3);
						if (setting != null)
						{
							string text7 = ((SettingOrSpecialObject)setting).A(bz.aYt);
							if (text7 == null)
							{
								text7 = ((SettingOrSpecialObject)setting).B();
							}
							string text8 = ((SettingOrSpecialObject)setting).H();
							if (!string.IsNullOrWhiteSpace(text8))
							{
								text7 = text8 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text7 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
							}
							string text9 = string.Empty;
							if (((SettingOrSpecialObject)setting).s() != null)
							{
								text9 = ((SettingOrSpecialObject)setting).s();
							}
							string text10 = ((SettingOrSpecialObject)setting).A(bz.aYT);
							if (text10 == null)
							{
								text10 = ((SettingOrSpecialObject)setting).B();
							}
							ListViewItem val3 = ((ListView)YM).Items[text7];
							if (val3 != null)
							{
								((ListView)YM).Items.Remove(val3);
								((ListView)Yp).Items.Add(val3);
								continue;
							}
							int num2 = setting.aS();
							string text11 = bS.A(setting.@as(), num2, false, 0);
							val3 = new ListViewItem(new string[4] { text7, text9, text10, text11 });
							val3.Name = text7;
							val3.Tag = current3;
							((ListView)Yp).Items.Add(val3);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator3).Dispose();
				}
				((Control)YS).Text = ((ListView)Yp).Items.Count + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yt();
				if (YI != 0)
				{
					Label yS = YS;
					((Control)yS).Text = ((Control)yS).Text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YU() + YI + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
				}
			}
			((Form)this).OnVisibleChanged(e);
			((Control)YL).Focus();
		}

		private void C(object P_0, EventArgs P_1)
		{
			if (((ListView)YM).SelectedItems.Count == 1)
			{
				ListViewItem val = ((ListView)YM).SelectedItems[0];
				A(val);
			}
			else if (((ListView)YM).SelectedItems.Count > 1)
			{
				SelectedListViewItemCollection selectedItems = ((ListView)YM).SelectedItems;
				ListViewItem[] array = (ListViewItem[])(object)new ListViewItem[selectedItems.Count];
				selectedItems.CopyTo((System.Array)array, 0);
				A(array);
			}
		}

		private void c(object P_0, EventArgs P_1)
		{
			if (((ListView)Yp).SelectedItems.Count == 1)
			{
				a(((ListView)Yp).SelectedItems[0]);
			}
			else if (((ListView)Yp).SelectedItems.Count > 1)
			{
				SelectedListViewItemCollection selectedItems = ((ListView)Yp).SelectedItems;
				ListViewItem[] array = (ListViewItem[])(object)new ListViewItem[selectedItems.Count];
				selectedItems.CopyTo((System.Array)array, 0);
				a(array);
			}
		}

		private void A(params ListViewItem[] items)
		{
			foreach (ListViewItem val in items)
			{
				Yh.Add((int)val.Tag);
				((ListView)YM).Items.Remove(val);
				val.Selected = false;
				((ListView)Yp).Items.Add(val);
			}
			YM.a();
			Yp.a();
			((Control)YS).Text = ((ListView)Yp).Items.Count + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yt();
			if (YI != 0)
			{
				Label yS = YS;
				((Control)yS).Text = ((Control)yS).Text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YU() + YI + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
			}
		}

		private void a(params ListViewItem[] items)
		{
			((ListView)Yp).BeginUpdate();
			foreach (ListViewItem val in items)
			{
				Yh.Remove((int)val.Tag);
				((ListView)Yp).Items.Remove(val);
			}
			((ListView)Yp).EndUpdate();
			a();
			((Control)YS).Text = ((ListView)Yp).Items.Count + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yt();
			if (YI != 0)
			{
				Label yS = YS;
				((Control)yS).Text = ((Control)yS).Text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YU() + YI + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			ag yk = Yk;
			Rectangle clientRectangle = ((Control)this).ClientRectangle;
			((Control)yk).Width = ((Rectangle)(ref clientRectangle)).Width - ((Control)Yk).Left - 11;
			Yk.A();
			ab yM = YM;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)yM).Height = ((Rectangle)(ref clientRectangle)).Height - 44 - ((Control)YM).Top;
			((Control)Yp).Top = ((Control)YM).Top;
			((Control)Yp).Height = ((Control)YM).Height;
			ab yM2 = YM;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)yM2).Width = ((Rectangle)(ref clientRectangle)).Width / 2 - 29 - 10;
			((Control)Yp).Width = ((Control)YM).Width;
			((Control)Yp).Left = 10 + ((Control)YM).Width + 58;
			((Control)YP).Top = ((Control)YM).Top + ((Control)YM).Height * 115 / 375;
			((Control)Yo).Top = ((Control)YM).Top + ((Control)YM).Height * 173 / 375;
			ThemedButton yP = YP;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)yP).Left = ((Rectangle)(ref clientRectangle)).Width / 2 - ((Control)YP).Width / 2;
			((Control)Yo).Left = ((Control)YP).Left;
			((Control)YS).Top = ((Control)Yp).Bottom + 13;
			((Control)YS).Left = ((Control)Yp).Left + 4;
			ThemedButton yj = Yj;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)yj).Left = ((Rectangle)(ref clientRectangle)).Width - 193;
			ThemedButton yj2 = Yj;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)yj2).Top = ((Rectangle)(ref clientRectangle)).Height - 36;
			ThemedButton yJ = YJ;
			clientRectangle = ((Control)this).ClientRectangle;
			((Control)yJ).Left = ((Rectangle)(ref clientRectangle)).Width - 100;
			((Control)YJ).Top = ((Control)Yj).Top;
			YM.a();
			Yp.a();
		}

		private void A(object P_0, ColumnWidthChangedEventArgs P_1)
		{
			YM.a();
		}

		private void a(object P_0, ColumnWidthChangedEventArgs P_1)
		{
			Yp.a();
		}

		private void A(object P_0, ColumnWidthChangingEventArgs P_1)
		{
			YM.a();
		}

		private void a(object P_0, ColumnWidthChangingEventArgs P_1)
		{
			Yp.a();
		}

		private void a(object P_0, KeyEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			if ((int)P_1.KeyCode == 46)
			{
				((Button)Yo).PerformClick();
			}
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			if ((int)((Form)this).DialogResult == 1 && YI != 0 && A().Count > YI)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yu() + YI + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((CancelEventArgs)P_1).Cancel = true;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && Yi != null)
			{
				((System.IDisposable)Yi).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void B()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected O, but got Unknown
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Expected O, but got Unknown
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f6: Expected O, but got Unknown
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Expected O, but got Unknown
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Expected O, but got Unknown
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Expected O, but got Unknown
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_0378: Unknown result type (might be due to invalid IL or missing references)
			//IL_0382: Expected O, but got Unknown
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0399: Expected O, but got Unknown
			//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b0: Expected O, but got Unknown
			//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c7: Expected O, but got Unknown
			//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03de: Expected O, but got Unknown
			//IL_0468: Unknown result type (might be due to invalid IL or missing references)
			//IL_0472: Expected O, but got Unknown
			//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c2: Expected O, but got Unknown
			//IL_055a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0589: Unknown result type (might be due to invalid IL or missing references)
			//IL_0593: Expected O, but got Unknown
			//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05aa: Expected O, but got Unknown
			//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c1: Expected O, but got Unknown
			//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d8: Expected O, but got Unknown
			//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ef: Expected O, but got Unknown
			//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0606: Expected O, but got Unknown
			//IL_0613: Unknown result type (might be due to invalid IL or missing references)
			//IL_061d: Expected O, but got Unknown
			//IL_0685: Unknown result type (might be due to invalid IL or missing references)
			//IL_068f: Expected O, but got Unknown
			//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07be: Expected O, but got Unknown
			//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f0: Expected O, but got Unknown
			//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0802: Expected O, but got Unknown
			Yi = (IContainer)new Container();
			ComponentResourceManager val = new ComponentResourceManager(typeof(BY));
			YJ = new ThemedButton();
			Yj = new ThemedButton();
			YK = new Timer(Yi);
			YL = new ThemedTextBox();
			Yl = new ThemedButton();
			Yk = new ag();
			YM = new ab();
			Ym = new ColumnHeader();
			YN = new ColumnHeader();
			Yn = new ColumnHeader();
			YO = new ColumnHeader();
			Yo = new ThemedButton();
			YP = new ThemedButton();
			Yp = new ab();
			YQ = new ColumnHeader();
			Yq = new ColumnHeader();
			YR = new ColumnHeader();
			Yr = new ColumnHeader();
			YS = new Label();
			Ys = new PictureBox();
			((ISupportInitialize)Ys).BeginInit();
			((Control)this).SuspendLayout();
			val.ApplyResources((object)YJ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YP());
			((Button)YJ).DialogResult = (DialogResult)2;
			((Control)YJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YP();
			((ButtonBase)YJ).UseVisualStyleBackColor = true;
			val.ApplyResources((object)Yj, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yp());
			((Button)Yj).DialogResult = (DialogResult)1;
			((Control)Yj).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yp();
			((ButtonBase)Yj).UseVisualStyleBackColor = true;
			YK.Interval = 400;
			YK.Tick += new EventHandler(B);
			val.ApplyResources((object)YL, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YQ());
			((Control)YL).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YQ();
			((Control)YL).KeyDown += new KeyEventHandler(A);
			((Control)YL).KeyPress += new KeyPressEventHandler(A);
			val.ApplyResources((object)Yl, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fj());
			((Control)Yl).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)Yl).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fj();
			((ButtonBase)Yl).UseVisualStyleBackColor = true;
			((Control)Yl).Click += new EventHandler(b);
			((Control)Yk).BackColor = SystemColors.Window;
			((TextBoxBase)Yk).BorderStyle = (BorderStyle)0;
			val.ApplyResources((object)Yk, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KO());
			((Control)Yk).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)Yk).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KO();
			((TextBoxBase)Yk).ReadOnly = true;
			((ListView)YM).Columns.AddRange((ColumnHeader[])(object)new ColumnHeader[4] { Ym, YN, Yn, YO });
			((ListView)YM).FullRowSelect = true;
			((ListView)YM).HeaderStyle = (ColumnHeaderStyle)1;
			((ListView)YM).HideSelection = false;
			val.ApplyResources((object)YM, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YV());
			((Control)YM).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YV();
			((ListView)YM).TileSize = new Size(400, 16);
			((ListView)YM).UseCompatibleStateImageBehavior = false;
			((ListView)YM).View = (View)1;
			((ListView)YM).ColumnWidthChanged += new ColumnWidthChangedEventHandler(A);
			((ListView)YM).ColumnWidthChanging += new ColumnWidthChangingEventHandler(A);
			((ListView)YM).ItemActivate += new EventHandler(C);
			((ListView)YM).SelectedIndexChanged += new EventHandler(A);
			((Control)YM).DoubleClick += new EventHandler(C);
			val.ApplyResources((object)Ym, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yv());
			val.ApplyResources((object)YN, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yr());
			val.ApplyResources((object)Yn, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YS());
			val.ApplyResources((object)YO, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ys());
			val.ApplyResources((object)Yo, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YW());
			((Control)Yo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YW();
			((Control)Yo).TabStop = false;
			((ButtonBase)Yo).UseVisualStyleBackColor = true;
			((Control)Yo).Click += new EventHandler(c);
			val.ApplyResources((object)YP, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fR());
			((Control)YP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fR();
			((Control)YP).TabStop = false;
			((ButtonBase)YP).UseVisualStyleBackColor = true;
			((Control)YP).Click += new EventHandler(C);
			((Control)Yp).AllowDrop = true;
			((ListView)Yp).Columns.AddRange((ColumnHeader[])(object)new ColumnHeader[4] { YQ, Yq, YR, Yr });
			((ListView)Yp).FullRowSelect = true;
			((ListView)Yp).HeaderStyle = (ColumnHeaderStyle)1;
			((ListView)Yp).HideSelection = false;
			val.ApplyResources((object)Yp, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yw());
			((Control)Yp).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yw();
			((ListView)Yp).TileSize = new Size(400, 16);
			((ListView)Yp).UseCompatibleStateImageBehavior = false;
			((ListView)Yp).View = (View)1;
			((ListView)Yp).ColumnWidthChanged += new ColumnWidthChangedEventHandler(a);
			((ListView)Yp).ColumnWidthChanging += new ColumnWidthChangingEventHandler(a);
			((ListView)Yp).ItemActivate += new EventHandler(c);
			((ListView)Yp).SelectedIndexChanged += new EventHandler(a);
			((Control)Yp).DragDrop += new DragEventHandler(A);
			((Control)Yp).DoubleClick += new EventHandler(c);
			((Control)Yp).KeyDown += new KeyEventHandler(a);
			val.ApplyResources((object)YQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YX());
			val.ApplyResources((object)Yq, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yx());
			val.ApplyResources((object)YR, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YY());
			val.ApplyResources((object)Yr, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yy());
			val.ApplyResources((object)YS, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YZ());
			((Control)YS).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)YS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YZ();
			val.ApplyResources((object)Ys, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fJ());
			((Control)Ys).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fJ();
			Ys.TabStop = false;
			val.ApplyResources((object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fr());
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)YJ;
			((Control)this).Controls.Add((Control)(object)Yp);
			((Control)this).Controls.Add((Control)(object)YM);
			((Control)this).Controls.Add((Control)(object)YS);
			((Control)this).Controls.Add((Control)(object)Yo);
			((Control)this).Controls.Add((Control)(object)YP);
			((Control)this).Controls.Add((Control)(object)YJ);
			((Control)this).Controls.Add((Control)(object)Yj);
			((Control)this).Controls.Add((Control)(object)Yk);
			((Control)this).Controls.Add((Control)(object)Ys);
			((Control)this).Controls.Add((Control)(object)YL);
			((Control)this).Controls.Add((Control)(object)Yl);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yz();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Control)this).Resize += new EventHandler(D);
			((ISupportInitialize)Ys).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class By : Form
	{
		private static By YT;

		private Framework Yt;

		private SortedList<string, ListViewItem> YU;

		private IContainer Yu;

		private ThemedButton YV;

		private ThemedButton Yv;

		private Timer YW;

		private ThemedTextBox Yw;

		private ab YX;

		private ColumnHeader Yx;

		private ColumnHeader YY;

		private ColumnHeader Yy;

		private ag YZ;

		private ThemedButton Yz;

		private ColumnHeader yA;

		private PictureBox ya;

		internal static int A(IWin32Window P_0, Framework P_1)
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Invalid comparison between Unknown and I4
			if (YT == null)
			{
				YT = new By();
			}
			YT.Yt = P_1;
			YT.A(0);
			((Control)YT).BackColor = BM.td;
			((Control)YT.ya).BackColor = BM.td;
			if (YT.ya.Image != null)
			{
				YT.ya.Image.Dispose();
			}
			YT.ya.Image = (Image)(object)O.A((Image)(object)GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
			((Control)YT.YZ).BackColor = BM.tH;
			((Control)YT.YZ).ForeColor = BM.te;
			((Control)YT.YX).BackColor = BM.tH;
			((Control)YT.YX).ForeColor = BM.te;
			((Control)YT.Yw).BackColor = BM.to;
			((Control)YT.Yw).ForeColor = BM.te;
			DialogResult val = ((Form)YT).ShowDialog(P_0);
			YT.Yt = null;
			if ((int)val == 1)
			{
				return YT.A();
			}
			return 0;
		}

		internal By()
		{
			a();
			YU = new SortedList<string, ListViewItem>();
			Yw.A(A);
		}

		[SpecialName]
		internal int A()
		{
			if (((ListView)YX).SelectedItems.Count == 0)
			{
				return 0;
			}
			return (int)((ListView)YX).SelectedItems[0].Tag;
		}

		[SpecialName]
		internal void A(int P_0)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			foreach (ListViewItem item in ((ListView)YX).Items)
			{
				ListViewItem val = item;
				if (P_0 != (int)val.Tag)
				{
					val.Selected = false;
				}
			}
			((ListView)YX).SelectedItems.Clear();
			foreach (ListViewItem item2 in ((ListView)YX).Items)
			{
				ListViewItem val2 = item2;
				if (P_0 == (int)val2.Tag)
				{
					val2.Selected = true;
					((ListView)YX).FocusedItem = val2;
					break;
				}
			}
		}

		private void A(object P_0, MouseEventArgs P_1)
		{
			if (((ListView)YX).SelectedItems.Count != 0)
			{
				((Form)this).Close();
				((Form)this).DialogResult = (DialogResult)1;
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			if (Yt == null)
			{
				return;
			}
			if (((ListView)YX).SelectedItems.Count != 0)
			{
				Setting setting = Yt.A((int)((ListView)YX).SelectedItems[0].Tag);
				string text = ((SettingOrSpecialObject)setting).A(bz.aYt);
				if (text != null)
				{
					((Control)YZ).Text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FI();
				}
				else
				{
					((Control)YZ).Text = ((SettingOrSpecialObject)setting).B() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FI();
				}
				((TextBoxBase)YZ).Select(0, ((TextBoxBase)YZ).TextLength);
				((RichTextBox)YZ).SelectionFont = new Font(((RichTextBox)YZ).SelectionFont.FontFamily, ((RichTextBox)YZ).SelectionFont.Size, (FontStyle)1);
				((TextBoxBase)YZ).SelectionLength = 0;
				int textLength = ((TextBoxBase)YZ).TextLength;
				string text2 = ((SettingOrSpecialObject)setting).A(bz.aYU);
				if (text2 != null)
				{
					((TextBoxBase)YZ).AppendText(text2);
				}
				else if (text != null)
				{
					((TextBoxBase)YZ).AppendText(text);
				}
				else
				{
					string text3 = ((SettingOrSpecialObject)setting).A(bz.aYT);
					if (text3 != null)
					{
						((TextBoxBase)YZ).AppendText(text3);
					}
					else
					{
						((TextBoxBase)YZ).AppendText(((SettingOrSpecialObject)setting).B());
					}
				}
				int num = ((TextBoxBase)YZ).TextLength - textLength;
				((TextBoxBase)YZ).Select(textLength, num);
				((TextBoxBase)YZ).SelectionLength = 0;
				((Control)Yv).Enabled = true;
			}
			else
			{
				((Control)YZ).Text = string.Empty;
				((Control)Yv).Enabled = false;
			}
		}

		private void A(object P_0, KeyPressEventArgs P_1)
		{
			YW.Stop();
			YW.Start();
		}

		private void A(object P_0, ThemedTextBox.B P_1)
		{
			YW.Stop();
			YW.Start();
		}

		private void a(object P_0, EventArgs P_1)
		{
			YW.Stop();
			a(-1);
		}

		private void A(object P_0, KeyEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			if ((int)P_1.KeyCode == 40 && ((ListView)YX).SelectedIndices.Count != 0)
			{
				((Control)YX).Focus();
			}
		}

		private void a(int P_0)
		{
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Expected O, but got Unknown
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			if (Yt == null)
			{
				return;
			}
			string text = ((Control)Yw).Text.ToUpper();
			string[] array = text.Split(RuntimeHelpers.CreateSpan<char>((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/));
			((ListView)YX).BeginUpdate();
			((ListView)YX).Items.Clear();
			System.Collections.Generic.IEnumerator<ListViewItem> enumerator = ((System.Collections.Generic.IEnumerable<ListViewItem>)YU.Values).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					ListViewItem current = enumerator.Current;
					Setting setting = Yt.A((int)current.Tag);
					if (setting == null)
					{
						continue;
					}
					string text2 = ((SettingOrSpecialObject)setting).A(true);
					string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yA();
					string text4 = ((SettingOrSpecialObject)setting).A(bz.aYT);
					if (text4 == null)
					{
						text4 = ((SettingOrSpecialObject)setting).B();
					}
					string text5 = text4.ToUpper();
					string text6 = text2.ToUpper();
					string text7 = text3.ToUpper();
					bool flag = true;
					bool flag2 = false;
					if (text == text6 || text == text5)
					{
						flag2 = true;
					}
					else
					{
						Enumerator<string> enumerator2 = ((SettingOrSpecialObject)setting).i().GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								string current2 = enumerator2.Current;
								if (text == current2.ToUpper())
								{
									flag2 = true;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator2).Dispose();
						}
					}
					if (!flag2)
					{
						string[] array2 = array;
						foreach (string text8 in array2)
						{
							if (text6.Contains(text8) || text5.Contains(text8) || text7.Contains(text8))
							{
								continue;
							}
							bool flag3 = false;
							Enumerator<string> enumerator2 = ((SettingOrSpecialObject)setting).i().GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									if (enumerator2.Current.ToUpper().Contains(text8))
									{
										flag3 = true;
										break;
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator2).Dispose();
							}
							if (!flag3)
							{
								flag = false;
								break;
							}
						}
					}
					if (flag)
					{
						if (((ListView)YX).Items.Count != 0 && flag2)
						{
							((ListView)YX).Items.Insert(0, current);
						}
						else
						{
							((ListView)YX).Items.Add(current);
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			if (P_0 != -1)
			{
				A(P_0);
				foreach (ListViewItem item in ((ListView)YX).Items)
				{
					ListViewItem val = item;
					if (P_0 == (int)val.Tag)
					{
						((ListView)YX).EnsureVisible(((ListView)YX).Items.IndexOf(val));
						break;
					}
				}
			}
			else if (((ListView)YX).Items.Count != 0)
			{
				ListViewItem val2 = ((ListView)YX).Items[0];
				val2.Selected = true;
				((ListView)YX).FocusedItem = val2;
			}
			((ListView)YX).EndUpdate();
			((Control)Yv).Enabled = ((ListView)YX).SelectedItems.Count != 0;
			YX.a();
		}

		private void B(object P_0, EventArgs P_1)
		{
			((TextBoxBase)Yw).Clear();
			A((object)null, (KeyPressEventArgs)null);
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			((Form)this).OnVisibleChanged(e);
			((Control)Yw).Focus();
		}

		protected override void OnShown(EventArgs e)
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			((Form)this).OnShown(e);
			((TextBoxBase)Yw).Clear();
			YU.Clear();
			List<string> val = new List<string>();
			Enumerator<Table> enumerator = Yt.aWV.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Table current = enumerator.Current;
					if (!((SettingOrSpecialObject)current).l() || (((Control)BM.QQ.rn).Visible && !BM.C(((Setting)current).A())))
					{
						continue;
					}
					string text = ((SettingOrSpecialObject)current).A(true);
					string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.yA();
					string text3 = ((SettingOrSpecialObject)current).A(bz.aYT);
					if (text3 == null)
					{
						text3 = ((SettingOrSpecialObject)current).B();
					}
					int num = current.aS();
					string text4 = bS.A(current.@as(), num, false, 0);
					ListViewItem val2 = new ListViewItem(new string[4] { text, text2, text3, text4 });
					val2.Tag = ((Setting)current).A();
					if (YU.ContainsKey(text))
					{
						if (!val.Contains(text))
						{
							val.Add(text);
						}
					}
					else
					{
						YU.Add(text, val2);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (val.Count != 0)
			{
				string text5 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yo();
				Enumerator<string> enumerator2 = val.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						string current2 = enumerator2.Current;
						text5 = text5 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy() + current2;
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				bE.A((IWin32Window)(object)this, text5, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			a(A());
			((Control)Yw).Focus();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			e.Cancel = (int)((Form)this).DialogResult == 1 && ((ListView)YX).SelectedItems.Count == 0;
		}

		private void b(object P_0, EventArgs P_1)
		{
			YX.a();
		}

		private void A(object P_0, ColumnWidthChangedEventArgs P_1)
		{
			YX.a();
		}

		private void A(object P_0, ColumnWidthChangingEventArgs P_1)
		{
			YX.a();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && Yu != null)
			{
				((System.IDisposable)Yu).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Expected O, but got Unknown
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected O, but got Unknown
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected O, but got Unknown
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Expected O, but got Unknown
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Expected O, but got Unknown
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Expected O, but got Unknown
			//IL_032b: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0364: Expected O, but got Unknown
			//IL_0371: Unknown result type (might be due to invalid IL or missing references)
			//IL_037b: Expected O, but got Unknown
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_0392: Expected O, but got Unknown
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Expected O, but got Unknown
			//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d4: Expected O, but got Unknown
			//IL_050a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0514: Expected O, but got Unknown
			Yu = (IContainer)new Container();
			ComponentResourceManager val = new ComponentResourceManager(typeof(By));
			YV = new ThemedButton();
			Yv = new ThemedButton();
			YW = new Timer(Yu);
			Yw = new ThemedTextBox();
			Yz = new ThemedButton();
			YZ = new ag();
			YX = new ab();
			Yx = new ColumnHeader();
			yA = new ColumnHeader();
			Yy = new ColumnHeader();
			YY = new ColumnHeader();
			ya = new PictureBox();
			((ISupportInitialize)ya).BeginInit();
			((Control)this).SuspendLayout();
			val.ApplyResources((object)YV, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YP());
			((Control)YV).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Button)YV).DialogResult = (DialogResult)2;
			((Control)YV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YP();
			((ButtonBase)YV).UseVisualStyleBackColor = true;
			((Button)Yv).DialogResult = (DialogResult)1;
			val.ApplyResources((object)Yv, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yp());
			((Control)Yv).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)Yv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yp();
			((ButtonBase)Yv).UseVisualStyleBackColor = true;
			YW.Interval = 400;
			YW.Tick += new EventHandler(a);
			val.ApplyResources((object)Yw, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YQ());
			((Control)Yw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YQ();
			((Control)Yw).KeyDown += new KeyEventHandler(A);
			((Control)Yw).KeyPress += new KeyPressEventHandler(A);
			val.ApplyResources((object)Yz, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fj());
			((Control)Yz).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)Yz).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fj();
			((ButtonBase)Yz).UseVisualStyleBackColor = true;
			((Control)Yz).Click += new EventHandler(B);
			((Control)YZ).BackColor = SystemColors.Window;
			((TextBoxBase)YZ).BorderStyle = (BorderStyle)0;
			val.ApplyResources((object)YZ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KO());
			((Control)YZ).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)YZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KO();
			((TextBoxBase)YZ).ReadOnly = true;
			((ListView)YX).Columns.AddRange((ColumnHeader[])(object)new ColumnHeader[4] { Yx, yA, Yy, YY });
			((ListView)YX).FullRowSelect = true;
			((ListView)YX).HeaderStyle = (ColumnHeaderStyle)1;
			((ListView)YX).HideSelection = false;
			val.ApplyResources((object)YX, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yq());
			((Control)YX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yq();
			((ListView)YX).TileSize = new Size(400, 16);
			((ListView)YX).UseCompatibleStateImageBehavior = false;
			((ListView)YX).View = (View)1;
			((ListView)YX).ColumnWidthChanged += new ColumnWidthChangedEventHandler(A);
			((ListView)YX).ColumnWidthChanging += new ColumnWidthChangingEventHandler(A);
			((ListView)YX).SelectedIndexChanged += new EventHandler(A);
			((Control)YX).MouseDoubleClick += new MouseEventHandler(A);
			val.ApplyResources((object)Yx, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YR());
			val.ApplyResources((object)yA, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yr());
			val.ApplyResources((object)Yy, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YS());
			val.ApplyResources((object)YY, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ys());
			val.ApplyResources((object)ya, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fJ());
			((Control)ya).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fJ();
			ya.TabStop = false;
			((Form)this).AcceptButton = (IButtonControl)(object)Yv;
			val.ApplyResources((object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fr());
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)YV;
			((Control)this).Controls.Add((Control)(object)YV);
			((Control)this).Controls.Add((Control)(object)Yv);
			((Control)this).Controls.Add((Control)(object)ya);
			((Control)this).Controls.Add((Control)(object)Yw);
			((Control)this).Controls.Add((Control)(object)Yz);
			((Control)this).Controls.Add((Control)(object)YZ);
			((Control)this).Controls.Add((Control)(object)YX);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ya();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Control)this).Resize += new EventHandler(b);
			((ISupportInitialize)ya).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
namespace b
{
	internal enum bY
	{
		axy = 1,
		axZ = 2,
		axz = 4,
		aYA = 8,
		aYa = 16,
		aYB = 32,
		aYb = 64,
		aYC = 128,
		aYc = 65535,
		aYD = 192,
		aYd = 0,
		aYE = 17,
		aYe = 19,
		aYF = 21,
		aYf = 25,
		aYG = 27,
		aYg = 203,
		aYH = 195,
		aYh = 194,
		aYI = 199,
		aYi = 231
	}
	internal enum by
	{
		aYJ = 0,
		aYj = 1,
		aYK = 2,
		aYk = 4
	}
}
