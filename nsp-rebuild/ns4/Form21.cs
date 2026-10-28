using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns2;
using ns7;

namespace ns4;

internal class Form21 : Form
{
	private const int int_0 = 3;

	private const int int_1 = 3;

	private const int int_2 = 3;

	internal Color color_0 = Color.Black;

	internal Color color_1 = Color.White;

	private IContainer icontainer_0;

	private Class85 class85_0;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ImageList imageList_0;

	private Class85 class85_1;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	internal Form21()
	{
		method_5();
		class85_0.DrawColumnHeader += class85_1_DrawColumnHeader;
		class85_0.DrawItem += class85_1_DrawItem;
		class85_0.DrawSubItem += class85_1_DrawSubItem;
		class85_1.DrawColumnHeader += class85_1_DrawColumnHeader;
		class85_1.DrawItem += class85_1_DrawItem;
		class85_1.DrawSubItem += class85_1_DrawSubItem;
	}

	private void Form21_Shown(object sender, EventArgs e)
	{
		method_1(class85_0, 20);
		method_1(class85_1, 20);
		method_0();
		ListViewItem listViewItem = class85_0.Items.Add(Class333.smethod_1237());
		listViewItem.UseItemStyleForSubItems = false;
		listViewItem.SubItems.Add(Class333.smethod_1238());
		ListViewItem listViewItem2 = class85_0.Items.Add(Class333.smethod_1239());
		listViewItem2.UseItemStyleForSubItems = false;
		listViewItem2.SubItems.Add(Class333.smethod_1240());
		ListViewItem listViewItem3 = class85_0.Items.Add(Class333.smethod_1241());
		listViewItem3.UseItemStyleForSubItems = false;
		listViewItem3.SubItems.Add(Class333.smethod_1242());
		ListViewItem listViewItem4 = class85_0.Items.Add(Class333.smethod_1243());
		listViewItem4.UseItemStyleForSubItems = false;
		listViewItem4.SubItems.Add(Class333.smethod_1244());
		ListViewItem listViewItem5 = class85_0.Items.Add(Class333.smethod_1245());
		listViewItem5.UseItemStyleForSubItems = false;
		listViewItem5.SubItems.Add(Class333.smethod_1246());
		ListViewItem listViewItem6 = class85_0.Items.Add(Class333.smethod_1247());
		listViewItem6.UseItemStyleForSubItems = false;
		listViewItem6.SubItems.Add(Class333.smethod_1248());
		ListViewItem listViewItem7 = class85_0.Items.Add(Class333.smethod_1249());
		listViewItem7.UseItemStyleForSubItems = false;
		listViewItem7.SubItems.Add(Class333.smethod_1250());
		ListViewItem listViewItem8 = class85_0.Items.Add(Class333.smethod_1251());
		listViewItem8.UseItemStyleForSubItems = false;
		listViewItem8.SubItems.Add(Class333.smethod_1252());
		ListViewItem listViewItem9 = class85_0.Items.Add(Class333.smethod_1253());
		listViewItem9.UseItemStyleForSubItems = false;
		listViewItem9.SubItems.Add(Class333.smethod_1254());
		ListViewItem listViewItem10 = class85_0.Items.Add(Class333.smethod_1255());
		listViewItem10.UseItemStyleForSubItems = false;
		listViewItem10.SubItems.Add(Class333.smethod_1256());
		ListViewItem listViewItem11 = class85_0.Items.Add(Class333.smethod_1257());
		listViewItem11.UseItemStyleForSubItems = false;
		listViewItem11.SubItems.Add(Class333.smethod_1258());
		ListViewItem listViewItem12 = class85_0.Items.Add(Class333.smethod_1259());
		listViewItem12.UseItemStyleForSubItems = false;
		listViewItem12.SubItems.Add(Class333.smethod_1260());
		ListViewItem listViewItem13 = class85_0.Items.Add(Class333.smethod_1261());
		listViewItem13.UseItemStyleForSubItems = false;
		listViewItem13.SubItems.Add(Class333.smethod_1262());
		ListViewItem listViewItem14 = class85_0.Items.Add(Class333.smethod_1263());
		listViewItem14.UseItemStyleForSubItems = false;
		listViewItem14.SubItems.Add(Class333.smethod_1264());
		ListViewItem listViewItem15 = class85_0.Items.Add(Class333.smethod_1265());
		listViewItem15.UseItemStyleForSubItems = false;
		listViewItem15.SubItems.Add(Class333.smethod_1266());
		ListViewItem listViewItem16 = class85_0.Items.Add(Class333.smethod_1267());
		listViewItem16.UseItemStyleForSubItems = false;
		listViewItem16.SubItems.Add(Class333.smethod_1268());
		ListViewItem listViewItem17 = class85_0.Items.Add(Class333.smethod_1269());
		listViewItem17.UseItemStyleForSubItems = false;
		listViewItem17.SubItems.Add(Class333.smethod_1270());
		ListViewItem listViewItem18 = class85_0.Items.Add(Class333.smethod_1271());
		listViewItem18.UseItemStyleForSubItems = false;
		listViewItem18.SubItems.Add(Class333.smethod_1272());
		ListViewItem listViewItem19 = class85_0.Items.Add(Class333.smethod_1273());
		listViewItem19.UseItemStyleForSubItems = false;
		listViewItem19.SubItems.Add(Class333.smethod_1274());
		ListViewItem listViewItem20 = class85_0.Items.Add(Class333.smethod_1275());
		listViewItem20.UseItemStyleForSubItems = false;
		listViewItem20.SubItems.Add(Class333.smethod_1276());
		ListViewItem listViewItem21 = class85_0.Items.Add(Class333.smethod_1277());
		listViewItem21.UseItemStyleForSubItems = false;
		listViewItem21.SubItems.Add(Class333.smethod_1278());
		ListViewItem listViewItem22 = class85_0.Items.Add(Class333.smethod_1279());
		listViewItem22.UseItemStyleForSubItems = false;
		listViewItem22.SubItems.Add(Class333.smethod_1280());
		ListViewItem listViewItem23 = class85_0.Items.Add(Class333.smethod_1281());
		listViewItem23.UseItemStyleForSubItems = false;
		listViewItem23.SubItems.Add(Class333.smethod_1282());
		ListViewItem listViewItem24 = class85_0.Items.Add(Class333.smethod_1283());
		listViewItem24.UseItemStyleForSubItems = false;
		listViewItem24.SubItems.Add(Class333.smethod_1284());
		ListViewItem listViewItem25 = class85_1.Items.Add(Class333.smethod_1285());
		listViewItem25.UseItemStyleForSubItems = false;
		listViewItem25.SubItems.Add(Class333.smethod_1286());
		ListViewItem listViewItem26 = class85_1.Items.Add(Class333.smethod_1287());
		listViewItem26.UseItemStyleForSubItems = false;
		listViewItem26.SubItems.Add(Class333.smethod_1288());
		ListViewItem listViewItem27 = class85_1.Items.Add(Class333.smethod_1289());
		listViewItem27.UseItemStyleForSubItems = false;
		listViewItem27.SubItems.Add(Class333.smethod_1290());
		ListViewItem listViewItem28 = class85_1.Items.Add(Class333.smethod_1291());
		listViewItem28.UseItemStyleForSubItems = false;
		listViewItem28.SubItems.Add(Class333.smethod_1292());
		ListViewItem listViewItem29 = class85_1.Items.Add(Class333.smethod_1293());
		listViewItem29.UseItemStyleForSubItems = false;
		listViewItem29.SubItems.Add(Class333.smethod_1294());
		ListViewItem listViewItem30 = class85_1.Items.Add(Class333.smethod_1295());
		listViewItem30.UseItemStyleForSubItems = false;
		listViewItem30.SubItems.Add(Class333.smethod_1296());
		ListViewItem listViewItem31 = class85_1.Items.Add(Class333.smethod_1297());
		listViewItem31.UseItemStyleForSubItems = false;
		listViewItem31.SubItems.Add(Class333.smethod_1298());
		ListViewItem listViewItem32 = class85_1.Items.Add(Class333.smethod_1299());
		listViewItem32.UseItemStyleForSubItems = false;
		listViewItem32.SubItems.Add(Class333.smethod_1300());
		ListViewItem listViewItem33 = class85_1.Items.Add(Class333.smethod_1301());
		listViewItem33.UseItemStyleForSubItems = false;
		listViewItem33.SubItems.Add(Class333.smethod_102());
		ListViewItem listViewItem34 = class85_1.Items.Add(Class333.smethod_1302());
		listViewItem34.UseItemStyleForSubItems = false;
		listViewItem34.SubItems.Add(Class333.smethod_1303());
		ListViewItem listViewItem35 = class85_1.Items.Add(Class333.smethod_1304());
		listViewItem35.UseItemStyleForSubItems = false;
		listViewItem35.SubItems.Add(Class333.smethod_102());
		ListViewItem listViewItem36 = class85_1.Items.Add(Class333.smethod_1305());
		listViewItem36.UseItemStyleForSubItems = false;
		listViewItem36.SubItems.Add(Class333.smethod_1306());
		ListViewItem listViewItem37 = class85_1.Items.Add(Class333.smethod_1307());
		listViewItem37.UseItemStyleForSubItems = false;
		listViewItem37.SubItems.Add(Class333.smethod_102());
		ListViewItem listViewItem38 = class85_1.Items.Add(Class333.smethod_1308());
		listViewItem38.UseItemStyleForSubItems = false;
		listViewItem38.SubItems.Add(Class333.smethod_1309());
		ListViewItem listViewItem39 = class85_1.Items.Add(Class333.smethod_1310());
		listViewItem39.UseItemStyleForSubItems = false;
		listViewItem39.SubItems.Add(Class333.smethod_1311());
		ListViewItem listViewItem40 = class85_1.Items.Add(Class333.smethod_185());
		listViewItem40.UseItemStyleForSubItems = false;
		listViewItem40.SubItems.Add(Class333.smethod_1312());
		ListViewItem listViewItem41 = class85_1.Items.Add(Class333.smethod_1039());
		listViewItem41.UseItemStyleForSubItems = false;
		listViewItem41.SubItems.Add(Class333.smethod_1313());
		ListViewItem listViewItem42 = class85_1.Items.Add(Class333.smethod_1314());
		listViewItem42.UseItemStyleForSubItems = false;
		listViewItem42.SubItems.Add(Class333.smethod_1315());
		ListViewItem listViewItem43 = class85_1.Items.Add(Class333.smethod_1316());
		listViewItem43.UseItemStyleForSubItems = false;
		listViewItem43.SubItems.Add(Class333.smethod_1317());
		ListViewItem listViewItem44 = class85_1.Items.Add(Class333.smethod_1318());
		listViewItem44.UseItemStyleForSubItems = false;
		listViewItem44.SubItems.Add(Class333.smethod_1319());
		ListViewItem listViewItem45 = class85_1.Items.Add(Class333.smethod_1320());
		listViewItem45.UseItemStyleForSubItems = false;
		listViewItem45.SubItems.Add(Class333.smethod_1321());
		ListViewItem listViewItem46 = class85_1.Items.Add(Class333.smethod_330());
		listViewItem46.UseItemStyleForSubItems = false;
		listViewItem46.SubItems.Add(Class333.smethod_1322());
		ListViewItem listViewItem47 = class85_1.Items.Add(Class333.smethod_1323());
		listViewItem47.UseItemStyleForSubItems = false;
		listViewItem47.SubItems.Add(Class333.smethod_1324());
		ListViewItem listViewItem48 = class85_1.Items.Add(Class333.smethod_1325());
		listViewItem48.UseItemStyleForSubItems = false;
		listViewItem48.SubItems.Add(Class333.smethod_1326());
		ListViewItem listViewItem49 = class85_1.Items.Add(Class333.smethod_1327());
		listViewItem49.UseItemStyleForSubItems = false;
		listViewItem49.SubItems.Add(Class333.smethod_1328());
		ListViewItem listViewItem50 = class85_1.Items.Add(Class333.smethod_1329());
		listViewItem50.UseItemStyleForSubItems = false;
		listViewItem50.SubItems.Add(Class333.smethod_1330());
	}

	internal void method_0()
	{
		BackColor = Form23.color_10;
		class85_0.BackColor = Form23.color_17;
		class85_0.ForeColor = Form23.color_12;
		class85_1.BackColor = Form23.color_17;
		class85_1.ForeColor = Form23.color_12;
		_ = Color.Black;
		_ = Color.White;
		Refresh();
	}

	private void method_1(ListView listView_0, int int_3)
	{
		ImageList imageList = new ImageList();
		imageList.ImageSize = new Size(1, int_3);
		listView_0.SmallImageList = imageList;
	}

	private Size method_2(string string_0, Font font_0)
	{
		return Graphics.FromImage(new Bitmap(1, 1)).MeasureString(string_0, font_0).ToSize();
	}

	private Size method_3(Size size_0)
	{
		int width = size_0.Width + 6;
		int height = size_0.Height + 6;
		return new Size(width, height);
	}

	private Bitmap method_4(string[] string_0, Font font_0)
	{
		int num = 0;
		int num2 = 0;
		List<Size> list = new List<Size>();
		foreach (string text in string_0)
		{
			Size size_ = ((!text.Contains(Class333.smethod_1287())) ? method_2(text, font_0) : method_2(Class333.smethod_1331(), font_0));
			Size item = method_3(size_);
			list.Add(item);
			num = ((!text.Contains(Class333.smethod_1287())) ? (num + item.Width) : (num + item.Width * 4));
			if (item.Height > num2)
			{
				num2 = item.Height;
			}
		}
		Bitmap bitmap = new Bitmap(num + 3 * (string_0.Length - 1) + 5, num2);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		StringFormat stringFormat = new StringFormat();
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Alignment = StringAlignment.Center;
		using Pen pen = new Pen(color_0, 1f);
		int num3 = 5;
		for (int j = 0; j < string_0.Length; j++)
		{
			if (string_0[j].Contains(Class333.smethod_1332()))
			{
				Rectangle rectangle = new Rectangle(num3, 1, list[j].Width - 1, num2 - 1);
				graphics.FillRectangle(new SolidBrush(Form23.color_17), rectangle);
				graphics.DrawString(string_0[j].TrimStart(new char[1] { '&' }), font_0, new SolidBrush(Form23.color_12), rectangle, stringFormat);
				num3 += list[j].Width + 3;
			}
			else if (string_0[j].Contains(Class333.smethod_1287()))
			{
				PointF[] array = new PointF[3];
				Size size = method_3(method_2(Class333.smethod_1331(), font_0));
				Rectangle rectangle_ = new Rectangle(num3, 1, size.Width - 1, num2 - 2);
				if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
				{
					graphics.FillPath(new SolidBrush(color_1), smethod_0(rectangle_, 3));
				}
				else
				{
					graphics.DrawPath(new Pen(Color.Black), smethod_0(rectangle_, 3));
				}
				array[0] = new PointF(num3 + size.Width / 2, num2 / 2 - 3);
				array[1] = new PointF(num3 + size.Width / 2 - 3, num2 / 2 + 3);
				array[2] = new PointF(num3 + size.Width / 2 + 3, num2 / 2 + 3);
				graphics.FillPolygon(Brushes.Black, array);
				Rectangle rectangle_2 = new Rectangle(num3 + size.Width, 1, size.Width - 1, num2 - 2);
				if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
				{
					graphics.FillPath(new SolidBrush(color_1), smethod_0(rectangle_2, 3));
				}
				else
				{
					graphics.DrawPath(new Pen(Color.Black), smethod_0(rectangle_2, 3));
				}
				array[0] = new PointF(num3 + size.Width + size.Width / 2 - 3, num2 / 2);
				array[1] = new PointF(num3 + size.Width + size.Width / 2 + 3, num2 / 2 + 3);
				array[2] = new PointF(num3 + size.Width + size.Width / 2 + 3, num2 / 2 - 3);
				graphics.FillPolygon(Brushes.Black, array);
				Rectangle rectangle_3 = new Rectangle(num3 + size.Width * 2, 1, size.Width - 1, num2 - 2);
				if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
				{
					graphics.FillPath(new SolidBrush(color_1), smethod_0(rectangle_3, 3));
				}
				else
				{
					graphics.DrawPath(new Pen(Color.Black), smethod_0(rectangle_3, 3));
				}
				array[0] = new PointF(num3 + size.Width * 2 + size.Width / 2 + 3, num2 / 2);
				array[1] = new PointF(num3 + size.Width * 2 + size.Width / 2 - 3, num2 / 2 + 3);
				array[2] = new PointF(num3 + size.Width * 2 + size.Width / 2 - 3, num2 / 2 - 3);
				graphics.FillPolygon(Brushes.Black, array);
				Rectangle rectangle_4 = new Rectangle(num3 + size.Width * 3, 1, size.Width - 1, num2 - 2);
				if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
				{
					graphics.FillPath(new SolidBrush(color_1), smethod_0(rectangle_4, 3));
				}
				else
				{
					graphics.DrawPath(new Pen(Color.Black), smethod_0(rectangle_4, 3));
				}
				array[0] = new PointF(num3 + size.Width * 3 + size.Width / 2, num2 / 2 + 3);
				array[1] = new PointF(num3 + size.Width * 3 + size.Width / 2 - 3, num2 / 2 - 3);
				array[2] = new PointF(num3 + size.Width * 3 + size.Width / 2 + 3, num2 / 2 - 3);
				graphics.FillPolygon(Brushes.Black, array);
				num3 += size.Width * 4 + 3;
			}
			else
			{
				Rectangle rectangle2 = new Rectangle(num3, 1, list[j].Width - 1, num2 - 2);
				if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
				{
					graphics.FillPath(new SolidBrush(color_1), smethod_0(rectangle2, 3));
				}
				else
				{
					graphics.FillPath(new SolidBrush(color_1), smethod_0(rectangle2, 3));
					graphics.DrawPath(pen, smethod_0(rectangle2, 3));
				}
				graphics.DrawString(string_0[j], font_0, new SolidBrush(color_0), rectangle2, stringFormat);
				num3 += list[j].Width + 3;
			}
		}
		return bitmap;
	}

	private static GraphicsPath smethod_0(Rectangle rectangle_0, int int_3)
	{
		int num = int_3 * 2;
		Rectangle rect = new Rectangle(size: new Size(num, num), location: rectangle_0.Location);
		GraphicsPath graphicsPath = new GraphicsPath();
		if (int_3 == 0)
		{
			graphicsPath.AddRectangle(rectangle_0);
			return graphicsPath;
		}
		graphicsPath.AddArc(rect, 180f, 90f);
		rect.X = rectangle_0.Right - num;
		graphicsPath.AddArc(rect, 270f, 90f);
		rect.Y = rectangle_0.Bottom - num;
		graphicsPath.AddArc(rect, 0f, 90f);
		rect.X = rectangle_0.Left;
		graphicsPath.AddArc(rect, 90f, 90f);
		graphicsPath.CloseFigure();
		return graphicsPath;
	}

	private void class85_1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
	{
		using StringFormat stringFormat = new StringFormat();
		switch (e.Header.TextAlign)
		{
		case HorizontalAlignment.Center:
			stringFormat.Alignment = StringAlignment.Center;
			break;
		case HorizontalAlignment.Right:
			stringFormat.Alignment = StringAlignment.Far;
			break;
		}
		stringFormat.LineAlignment = StringAlignment.Near;
		Rectangle rect = new Rectangle(e.Bounds.Left - 1, e.Bounds.Top - 1, e.Bounds.Width - 1, e.Bounds.Height - 1);
		e.Graphics.FillRectangle(new SolidBrush(Form23.color_10), e.Bounds);
		e.Graphics.DrawRectangle(new Pen(Form23.color_12), rect);
		Rectangle rectangle = new Rectangle(e.Bounds.Left + 10, e.Bounds.Top, e.Bounds.Width - 10, e.Bounds.Height);
		using Font font = new Font(Font.FontFamily, 9f);
		e.Graphics.DrawString(e.Header.Text, font, new SolidBrush(Form23.color_12), rectangle, stringFormat);
	}

	private void class85_1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
	{
		using StringFormat stringFormat = new StringFormat();
		stringFormat.LineAlignment = StringAlignment.Center;
		switch (e.Header.TextAlign)
		{
		case HorizontalAlignment.Center:
			stringFormat.Alignment = StringAlignment.Center;
			break;
		case HorizontalAlignment.Right:
			stringFormat.Alignment = StringAlignment.Far;
			break;
		}
		if (e.ColumnIndex == 0)
		{
			using (Font font_ = new Font(Font.FontFamily, 8f, FontStyle.Bold))
			{
				e.Graphics.DrawImage(method_4(e.SubItem.Text.Split('$'), font_), e.Bounds.Left, e.Bounds.Top);
				return;
			}
		}
		Rectangle rectangle = new Rectangle(e.Bounds.Left + 10, e.Bounds.Top, e.Bounds.Width - 10, e.Bounds.Height);
		using Font font = new Font(Font.FontFamily, 8f);
		e.Graphics.DrawString(e.SubItem.Text, font, new SolidBrush(Form23.color_12), rectangle, stringFormat);
	}

	private void class85_1_DrawItem(object sender, DrawListViewItemEventArgs e)
	{
		if (class85_0.View != View.Details)
		{
			e.DrawText();
		}
	}

	private void class85_0_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
	{
		e.Cancel = true;
		Class85 @class = sender as Class85;
		e.NewWidth = @class.Columns[e.ColumnIndex].Width;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_5()
	{
		icontainer_0 = new Container();
		imageList_0 = new ImageList(icontainer_0);
		class85_1 = new Class85();
		columnHeader_2 = new ColumnHeader();
		columnHeader_3 = new ColumnHeader();
		class85_0 = new Class85();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		SuspendLayout();
		imageList_0.ColorDepth = ColorDepth.Depth8Bit;
		imageList_0.ImageSize = new Size(16, 16);
		imageList_0.TransparentColor = Color.Transparent;
		class85_1.Columns.AddRange(columnHeader_2, columnHeader_3);
		class85_1.Font = new Font(Class333.smethod_145(), 8f);
		class85_1.FullRowSelect = true;
		class85_1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		class85_1.HideSelection = false;
		class85_1.Location = new Point(488, 12);
		class85_1.Name = Class333.smethod_1333();
		class85_1.OwnerDraw = true;
		class85_1.Scrollable = false;
		class85_1.Size = new Size(470, 638);
		class85_1.TabIndex = 2;
		class85_1.UseCompatibleStateImageBehavior = false;
		class85_1.View = View.Details;
		class85_1.ColumnWidthChanging += class85_0_ColumnWidthChanging;
		columnHeader_2.Text = Class333.smethod_1334();
		columnHeader_2.Width = 200;
		columnHeader_3.Text = Class333.smethod_1335();
		columnHeader_3.Width = 400;
		class85_0.Columns.AddRange(columnHeader_0, columnHeader_1);
		class85_0.Font = new Font(Class333.smethod_145(), 8f);
		class85_0.FullRowSelect = true;
		class85_0.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		class85_0.HideSelection = false;
		class85_0.Location = new Point(12, 12);
		class85_0.Name = Class333.smethod_1336();
		class85_0.OwnerDraw = true;
		class85_0.Scrollable = false;
		class85_0.Size = new Size(470, 638);
		class85_0.TabIndex = 1;
		class85_0.UseCompatibleStateImageBehavior = false;
		class85_0.View = View.Details;
		class85_0.ColumnWidthChanging += class85_0_ColumnWidthChanging;
		columnHeader_0.Text = Class333.smethod_1334();
		columnHeader_0.Width = 200;
		columnHeader_1.Text = Class333.smethod_1335();
		columnHeader_1.Width = 278;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(968, 661);
		Controls.Add(class85_1);
		Controls.Add(class85_0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		Name = Class333.smethod_1337();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.Manual;
		Text = Class333.smethod_1338();
		Shown += Form21_Shown;
		ResumeLayout(performLayout: false);
	}
}
