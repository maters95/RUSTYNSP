using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Win32;
using NSP.Resources;
using NSP.UserInterface;
using ns2;
using ns4;
using ns7;

namespace ns0;

internal class Control2 : UserControl
{
	internal const string string_0 = "https://support.haltech.com/";

	internal const string string_1 = "https://support.haltech.com/portal/en/kb/articles/";

	private ThemedButton themedButton_0 = new ThemedButton();

	private ThemedButton themedButton_1 = new ThemedButton();

	private ThemedButton themedButton_2 = new ThemedButton();

	private ThemedButton themedButton_3 = new ThemedButton();

	private ThemedButton themedButton_4 = new ThemedButton();

	private ThemedTextBox themedTextBox_0 = new ThemedTextBox();

	private PictureBox pictureBox_0 = new PictureBox();

	private ThemedButton themedButton_5 = new ThemedButton();

	private TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_0 = new TreeViewWithThemedScrollBars();

	private bool bool_0;

	private const int int_0 = 10;

	private bool bool_1;

	private int int_1;

	private int int_2;

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private TableLayoutPanel tableLayoutPanel_1;

	private WebView2 webView2_0;

	private Timer timer_0;

	private Panel panel_0;

	private LocalHelpFramework method_0()
	{
		LocalHelpFramework result = null;
		string path = Form23.string_14 + Class333.smethod_443();
		if (File.Exists(path))
		{
			try
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(LocalHelpFramework));
				using StreamReader textReader = new StreamReader(path);
				result = (LocalHelpFramework)xmlSerializer.Deserialize(textReader);
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.smethod_444() + ex.Message);
			}
		}
		return result;
	}

	internal Control2()
	{
		method_23();
		webView2_0.CreationProperties = new CoreWebView2CreationProperties
		{
			UserDataFolder = Form23.string_3 + Class333.smethod_445()
		};
		Dock = DockStyle.Fill;
		treeViewWithThemedScrollBars_0.method_23(method_13);
		panel_0.BackColor = Form23.color_11;
		themedButton_0.AutoSize = false;
		themedButton_0.Width = 160;
		themedButton_0.Height = 24;
		themedButton_0.Click += themedButton_0_Click;
		themedButton_1.Left = themedButton_0.Right + 10;
		themedButton_1.AutoSize = false;
		themedButton_1.Width = 100;
		themedButton_1.Height = 24;
		themedButton_1.Click += themedButton_1_Click;
		themedButton_1.Text = Class333.smethod_446();
		themedButton_2.Left = themedButton_1.Right + 10;
		themedButton_2.AutoSize = false;
		themedButton_2.Width = 70;
		themedButton_2.Height = 24;
		themedButton_2.ImageAlign = ContentAlignment.MiddleCenter;
		themedButton_2.Image = Form23.image_2;
		themedButton_2.Click += themedButton_2_Click;
		themedButton_2.Enabled = false;
		themedButton_3.Left = themedButton_2.Right + 1;
		themedButton_3.AutoSize = false;
		themedButton_3.Width = 70;
		themedButton_3.Height = 24;
		themedButton_3.ImageAlign = ContentAlignment.MiddleCenter;
		themedButton_3.Image = Form23.image_3;
		themedButton_3.Click += themedButton_3_Click;
		themedButton_3.Enabled = false;
		pictureBox_0.Left = themedButton_3.Right + 10;
		pictureBox_0.BackColor = Form23.color_11;
		if (pictureBox_0.Image != null)
		{
			pictureBox_0.Image.Dispose();
		}
		pictureBox_0.Image = Class25.smethod_0(GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		pictureBox_0.Width = 24;
		pictureBox_0.Height = 24;
		themedTextBox_0.Left = pictureBox_0.Right + 1;
		themedTextBox_0.Width = 200;
		themedTextBox_0.Top = 2;
		themedTextBox_0.Enabled = false;
		themedTextBox_0.KeyPress += themedTextBox_0_KeyPress;
		themedTextBox_0.TextChanged += themedTextBox_0_TextChanged;
		themedTextBox_0.method_0(method_5);
		themedButton_5.Left = themedTextBox_0.Right + 1;
		themedButton_5.Enabled = false;
		themedButton_5.Click += themedButton_5_Click;
		themedButton_5.Width = 30;
		themedButton_5.Height = 24;
		themedButton_5.Text = Class333.smethod_330();
		themedButton_5.Font = new Font(themedButton_5.Font.FontFamily, 8f, FontStyle.Bold);
		themedButton_4.AutoSize = false;
		themedButton_4.Width = 170;
		themedButton_4.Height = 24;
		themedButton_4.Click += themedButton_4_Click;
		themedButton_4.Text = Class333.smethod_447();
		themedButton_4.Tag = Class333.smethod_448();
		method_22();
		panel_0.Controls.Add(themedButton_0);
		panel_0.Controls.Add(themedButton_1);
		panel_0.Controls.Add(themedButton_2);
		panel_0.Controls.Add(themedButton_3);
		panel_0.Controls.Add(pictureBox_0);
		panel_0.Controls.Add(themedTextBox_0);
		panel_0.Controls.Add(themedButton_5);
		panel_0.Controls.Add(themedButton_4);
		tableLayoutPanel_1.Controls.Add(treeViewWithThemedScrollBars_0, 0, 0);
		treeViewWithThemedScrollBars_0.Width = (int)tableLayoutPanel_1.ColumnStyles[0].Width - 10;
		treeViewWithThemedScrollBars_0.Height = tableLayoutPanel_1.Height - 10;
		method_10();
	}

	internal void method_1()
	{
		panel_0.Visible = false;
		panel_0.Dock = DockStyle.None;
		panel_0.Height = 0;
		tableLayoutPanel_0.RowStyles.RemoveAt(0);
		tableLayoutPanel_1.Height = Height;
	}

	internal void method_2()
	{
		tableLayoutPanel_1.Height = Height - panel_0.Height;
		themedButton_4.Left = panel_0.Right - themedButton_4.Width;
		treeViewWithThemedScrollBars_0.Height = tableLayoutPanel_1.Height - 10;
	}

	internal void method_3(Uri uri_0)
	{
		try
		{
			if (webView2_0.Source == null || bool_0 || Path.GetFullPath(webView2_0.Source.AbsolutePath) != Path.GetFullPath(uri_0.AbsolutePath))
			{
				bool_0 = uri_0.AbsoluteUri == Class333.smethod_449();
				webView2_0.Source = uri_0;
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_450() + ex.Message);
		}
	}

	internal void method_4(string string_2)
	{
		if (!string.IsNullOrEmpty(string_2))
		{
			themedButton_4.Tag = string_2;
		}
		else
		{
			themedButton_4.Tag = Class333.smethod_448();
		}
	}

	private void tableLayoutPanel_1_MouseDown(object sender, MouseEventArgs e)
	{
		if (!(Parent is Class131) && e.Button == MouseButtons.Left && e.X > treeViewWithThemedScrollBars_0.Right - 1 && e.X < treeViewWithThemedScrollBars_0.Right + 4)
		{
			int_1 = e.X;
			int_2 = (int)tableLayoutPanel_1.ColumnStyles[0].Width;
			bool_1 = true;
		}
	}

	private void tableLayoutPanel_1_MouseMove(object sender, MouseEventArgs e)
	{
		if (Parent is Class131)
		{
			return;
		}
		if (bool_1)
		{
			int num = e.X - int_1;
			tableLayoutPanel_1.ColumnStyles[0].Width = Math.Max(int_2 + num, 100);
			if (webView2_0.Width > tableLayoutPanel_1.Width - webView2_0.Left)
			{
				webView2_0.Width = tableLayoutPanel_1.Width - webView2_0.Left;
			}
			treeViewWithThemedScrollBars_0.Width = (int)tableLayoutPanel_1.ColumnStyles[0].Width - 10;
			Refresh();
		}
		if (e.X > treeViewWithThemedScrollBars_0.Right - 1 && e.X < treeViewWithThemedScrollBars_0.Right + 4)
		{
			Cursor = Cursors.SizeWE;
		}
		else
		{
			Cursor = Cursors.Default;
		}
	}

	private void tableLayoutPanel_1_MouseUp(object sender, MouseEventArgs e)
	{
		bool_1 = false;
	}

	private void tableLayoutPanel_1_MouseLeave(object sender, EventArgs e)
	{
		Cursor = Cursors.Default;
	}

	private void themedButton_2_Click(object sender, EventArgs e)
	{
		webView2_0.GoBack();
	}

	private void themedButton_3_Click(object sender, EventArgs e)
	{
		webView2_0.GoForward();
	}

	private void themedButton_5_Click(object sender, EventArgs e)
	{
		themedTextBox_0.Text = string.Empty;
	}

	private void themedTextBox_0_KeyPress(object sender, KeyPressEventArgs e)
	{
		timer_0.Stop();
		timer_0.Start();
	}

	private void themedTextBox_0_TextChanged(object sender, EventArgs e)
	{
		timer_0.Stop();
		timer_0.Start();
	}

	private void method_5(object sender, ThemedTextBox.EventArgs4 e)
	{
		timer_0.Stop();
		timer_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		Cursor = Cursors.WaitCursor;
		if (themedTextBox_0.Text == string.Empty)
		{
			method_10();
		}
		else
		{
			method_6();
		}
		Cursor = Cursors.Default;
	}

	private void method_6()
	{
		treeViewWithThemedScrollBars_0.method_2().Clear();
		LocalHelpFramework localHelpFramework = method_0();
		if (localHelpFramework == null)
		{
			return;
		}
		List<string> list = new List<string>();
		if (themedTextBox_0.Text != string.Empty)
		{
			string[] array = themedTextBox_0.Text.Split(' ', ',');
			for (int i = 0; i < array.Length; i++)
			{
				list.Add(array[i].ToLower());
			}
		}
		treeViewWithThemedScrollBars_0.method_5();
		foreach (LocalCategory rootCategory in localHelpFramework.RootCategories)
		{
			method_8(rootCategory, list);
		}
		treeViewWithThemedScrollBars_0.method_6();
	}

	private string method_7(LocalArticle localArticle_0)
	{
		return (Form23.string_14 + localArticle_0.LocalURL).Replace('\\', '/');
	}

	private void method_8(LocalCategory localCategory_0, List<string> list_0)
	{
		foreach (LocalCategory childCategory in localCategory_0.ChildCategories)
		{
			method_8(childCategory, list_0);
		}
		foreach (LocalArticle article in localCategory_0.Articles)
		{
			method_9(article, list_0);
		}
	}

	private void method_9(LocalArticle localArticle_0, List<string> list_0)
	{
		bool flag = true;
		if (File.Exists(method_7(localArticle_0)))
		{
			foreach (string item in list_0)
			{
				if (localArticle_0.Name.ToLower().Contains(item))
				{
					continue;
				}
				try
				{
					string text = File.ReadAllText(method_7(localArticle_0));
					if (!string.IsNullOrEmpty(text))
					{
						if (text.ToLower().Contains(item))
						{
							continue;
						}
						flag = false;
					}
					else
					{
						flag = false;
					}
				}
				catch
				{
					flag = false;
				}
				break;
			}
		}
		else
		{
			flag = false;
		}
		if (flag)
		{
			TreeNode treeNode = new TreeNode(localArticle_0.Name);
			treeNode.Tag = localArticle_0;
			treeNode.ForeColor = Form23.color_12;
			treeViewWithThemedScrollBars_0.method_2().Add(treeNode);
		}
	}

	private void method_10()
	{
		treeViewWithThemedScrollBars_0.method_2().Clear();
		LocalHelpFramework localHelpFramework = method_0();
		if (localHelpFramework != null)
		{
			treeViewWithThemedScrollBars_0.method_5();
			foreach (LocalCategory rootCategory in localHelpFramework.RootCategories)
			{
				method_11(rootCategory, null);
			}
			treeViewWithThemedScrollBars_0.method_6();
			themedTextBox_0.Enabled = true;
			themedButton_5.Enabled = true;
		}
		else
		{
			method_18();
			Uri uri;
			try
			{
				uri = new Uri(Class333.smethod_448());
			}
			catch
			{
				uri = null;
			}
			if (uri != null)
			{
				method_3(uri);
			}
		}
	}

	private void method_11(LocalCategory localCategory_0, TreeNode treeNode_0)
	{
		TreeNode treeNode = new TreeNode(localCategory_0.Name);
		treeNode.Tag = null;
		treeNode.ForeColor = Form23.color_12;
		if (treeNode_0 == null)
		{
			treeViewWithThemedScrollBars_0.method_2().Add(treeNode);
		}
		else
		{
			treeNode_0.Nodes.Add(treeNode);
		}
		foreach (LocalCategory childCategory in localCategory_0.ChildCategories)
		{
			method_11(childCategory, treeNode);
		}
		foreach (LocalArticle article in localCategory_0.Articles)
		{
			method_12(article, treeNode);
		}
	}

	private void method_12(LocalArticle localArticle_0, TreeNode treeNode_0)
	{
		TreeNode treeNode = new TreeNode(localArticle_0.Name);
		treeNode.Tag = localArticle_0;
		treeNode.ForeColor = Form23.color_12;
		if (treeNode_0 == null)
		{
			treeViewWithThemedScrollBars_0.method_2().Add(treeNode);
		}
		else
		{
			treeNode_0.Nodes.Add(treeNode);
		}
	}

	private void method_13(object sender, TreeViewEventArgs e)
	{
		if (!(e.Node.Tag is LocalArticle))
		{
			return;
		}
		string text = method_7(e.Node.Tag as LocalArticle);
		Uri uri = null;
		if (File.Exists(text))
		{
			try
			{
				uri = new Uri(text);
			}
			catch
			{
				uri = null;
			}
		}
		if (uri == null)
		{
			try
			{
				uri = new Uri(Class333.smethod_451() + Path.GetFileNameWithoutExtension(text));
			}
			catch
			{
				uri = null;
			}
		}
		if (uri != null)
		{
			method_3(uri);
		}
		method_4((e.Node.Tag as LocalArticle).OnlineURL);
	}

	private void method_14()
	{
		method_17(Path.GetFullPath(webView2_0.Source.AbsolutePath), treeViewWithThemedScrollBars_0.method_2());
		themedButton_2.Enabled = webView2_0.CanGoBack;
		themedButton_3.Enabled = webView2_0.CanGoForward;
	}

	private void method_15(object sender, CoreWebView2NavigationStartingEventArgs e)
	{
		method_14();
	}

	private void method_16(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
		method_14();
	}

	private void method_17(string string_2, List<TreeNode> list_0)
	{
		foreach (TreeNode item2 in list_0)
		{
			if (item2.Tag != null && item2.Tag is LocalArticle)
			{
				if (Path.GetFullPath(method_7(item2.Tag as LocalArticle)) == string_2)
				{
					treeViewWithThemedScrollBars_0.method_4(item2);
					break;
				}
				continue;
			}
			List<TreeNode> list = new List<TreeNode>();
			foreach (TreeNode node in item2.Nodes)
			{
				list.Add(node);
			}
			method_17(string_2, list);
		}
	}

	internal static string smethod_0()
	{
		using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class333.smethod_452(), writable: false);
		string text = registryKey.GetValue(Class333.smethod_453()).ToString();
		using RegistryKey registryKey2 = Registry.ClassesRoot.OpenSubKey(text + Class333.smethod_454(), writable: false);
		string input = (string)registryKey2.GetValue(Class333.smethod_102());
		Match match = new Regex(Class333.smethod_455()).Match(input);
		return match.Success ? match.Value : Class333.smethod_102();
	}

	internal void method_18()
	{
		if (Parent is Class131)
		{
			method_20();
			themedButton_1.Visible = false;
			themedButton_2.Visible = false;
			themedButton_3.Visible = false;
			pictureBox_0.Visible = false;
			themedTextBox_0.Visible = false;
			themedButton_5.Visible = false;
			themedButton_4.Visible = false;
			themedButton_0.Text = Class333.smethod_456();
			return;
		}
		if (method_0() != null)
		{
			method_19();
			themedButton_1.Visible = true;
			pictureBox_0.Visible = true;
			themedTextBox_0.Visible = true;
			themedButton_5.Visible = true;
		}
		else
		{
			method_20();
			themedButton_1.Visible = false;
			pictureBox_0.Visible = false;
			themedTextBox_0.Visible = false;
			themedButton_5.Visible = false;
		}
		themedButton_2.Visible = true;
		themedButton_3.Visible = true;
		themedButton_4.Visible = true;
		themedButton_0.Text = Class333.smethod_457();
	}

	private void method_19()
	{
		TableLayoutColumnStyleCollection columnStyles = tableLayoutPanel_1.ColumnStyles;
		if (columnStyles[0].Width == 0f)
		{
			columnStyles[0].Width = 250f;
		}
		treeViewWithThemedScrollBars_0.Width = (int)columnStyles[0].Width - 10;
		webView2_0.Width = tableLayoutPanel_1.Width - webView2_0.Left;
		Refresh();
		treeViewWithThemedScrollBars_0.Visible = true;
	}

	private void method_20()
	{
		TableLayoutColumnStyleCollection columnStyles = tableLayoutPanel_1.ColumnStyles;
		if (columnStyles[0].Width > 0f)
		{
			columnStyles[0].Width = 0f;
		}
		webView2_0.Width = tableLayoutPanel_1.Width - webView2_0.Left;
		Refresh();
		treeViewWithThemedScrollBars_0.Visible = false;
	}

	private void tableLayoutPanel_1_SizeChanged(object sender, EventArgs e)
	{
		webView2_0.Width = tableLayoutPanel_1.Width - webView2_0.Left;
		Refresh();
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		Form23.form23_0.method_90();
		if (Form23.bool_30)
		{
			themedButton_0.Text = Class333.smethod_456();
		}
		else
		{
			themedButton_0.Text = Class333.smethod_457();
		}
	}

	private void themedButton_1_Click(object sender, EventArgs e)
	{
		TableLayoutColumnStyleCollection columnStyles = tableLayoutPanel_1.ColumnStyles;
		if (columnStyles[0].Width == 0f)
		{
			columnStyles[0].Width = 250f;
			treeViewWithThemedScrollBars_0.Width = (int)columnStyles[0].Width - 10;
		}
		else
		{
			columnStyles[0].Width = 0f;
		}
		webView2_0.Width = tableLayoutPanel_1.Width - webView2_0.Left;
		Refresh();
	}

	private void themedButton_4_Click(object sender, EventArgs e)
	{
		try
		{
			string fileName = smethod_0();
			string arguments = themedButton_4.Tag as string;
			Process.Start(fileName, arguments);
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_458() + ex.Message);
		}
	}

	private void Control2_Resize(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_21(TreeNode treeNode_0)
	{
		treeNode_0.ForeColor = Form23.color_12;
		foreach (TreeNode node in treeNode_0.Nodes)
		{
			method_21(node);
		}
	}

	internal void method_22()
	{
		panel_0.BackColor = Form23.color_11;
		treeViewWithThemedScrollBars_0.BackColor = Form23.color_16;
		treeViewWithThemedScrollBars_0.ForeColor = Form23.color_12;
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.ForeColor = Form23.color_12;
		themedButton_2.Image = Form23.image_2;
		themedButton_3.Image = Form23.image_3;
		pictureBox_0.BackColor = Form23.color_11;
		if (pictureBox_0.Image != null)
		{
			pictureBox_0.Image.Dispose();
		}
		pictureBox_0.Image = Class25.smethod_0(GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		foreach (TreeNode item in treeViewWithThemedScrollBars_0.method_2())
		{
			method_21(item);
		}
		Refresh();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_23()
	{
		icontainer_0 = new Container();
		tableLayoutPanel_0 = new TableLayoutPanel();
		tableLayoutPanel_1 = new TableLayoutPanel();
		webView2_0 = new WebView2();
		timer_0 = new Timer(icontainer_0);
		panel_0 = new Panel();
		tableLayoutPanel_0.SuspendLayout();
		tableLayoutPanel_1.SuspendLayout();
		SuspendLayout();
		tableLayoutPanel_0.ColumnCount = 1;
		tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		tableLayoutPanel_0.Controls.Add(tableLayoutPanel_1, 0, 1);
		tableLayoutPanel_0.Controls.Add(panel_0, 0, 0);
		tableLayoutPanel_0.Dock = DockStyle.Fill;
		tableLayoutPanel_0.Location = new Point(0, 0);
		tableLayoutPanel_0.Name = Class333.smethod_459();
		tableLayoutPanel_0.RowCount = 2;
		tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
		tableLayoutPanel_0.RowStyles.Add(new RowStyle());
		tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		tableLayoutPanel_0.Size = new Size(1000, 600);
		tableLayoutPanel_0.TabIndex = 1;
		tableLayoutPanel_1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		tableLayoutPanel_1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
		tableLayoutPanel_1.ColumnCount = 2;
		tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250f));
		tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle());
		tableLayoutPanel_1.Controls.Add(webView2_0, 1, 0);
		tableLayoutPanel_1.Dock = DockStyle.Fill;
		tableLayoutPanel_1.Location = new Point(1, 26);
		tableLayoutPanel_1.Margin = new Padding(1);
		tableLayoutPanel_1.MinimumSize = new Size(200, 200);
		tableLayoutPanel_1.Name = Class333.smethod_460();
		tableLayoutPanel_1.RowCount = 1;
		tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanel_1.Size = new Size(998, 573);
		tableLayoutPanel_1.TabIndex = 1;
		tableLayoutPanel_1.SizeChanged += tableLayoutPanel_1_SizeChanged;
		tableLayoutPanel_1.MouseDown += tableLayoutPanel_1_MouseDown;
		tableLayoutPanel_1.MouseLeave += tableLayoutPanel_1_MouseLeave;
		tableLayoutPanel_1.MouseMove += tableLayoutPanel_1_MouseMove;
		tableLayoutPanel_1.MouseUp += tableLayoutPanel_1_MouseUp;
		webView2_0.AllowExternalDrop = false;
		webView2_0.Dock = DockStyle.Fill;
		webView2_0.Location = new Point(255, 4);
		webView2_0.MinimumSize = new Size(20, 20);
		webView2_0.Name = Class333.smethod_461();
		webView2_0.Size = new Size(739, 565);
		webView2_0.TabIndex = 1;
		webView2_0.NavigationStarting += method_15;
		webView2_0.NavigationCompleted += method_16;
		timer_0.Interval = 400;
		timer_0.Tick += timer_0_Tick;
		panel_0.Dock = DockStyle.Fill;
		panel_0.Location = new Point(0, 0);
		panel_0.Margin = new Padding(0);
		panel_0.Name = Class333.smethod_462();
		panel_0.Size = new Size(1000, 25);
		panel_0.TabIndex = 2;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		AutoSizeMode = AutoSizeMode.GrowAndShrink;
		Controls.Add(tableLayoutPanel_0);
		Margin = new Padding(0);
		MinimumSize = new Size(200, 200);
		Name = Class333.smethod_463();
		Size = new Size(1000, 600);
		Resize += Control2_Resize;
		tableLayoutPanel_0.ResumeLayout(performLayout: false);
		tableLayoutPanel_1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
