// Decompiled with JetBrains decompiler
// Type: Draw.DrawPreview
// Assembly: Draw, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FD5E856C-6F6B-4BBC-986E-5999C2E1DCD5
// Assembly location: C:\Users\Evgen\Desktop\Draw\Draw.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Draw
{
	public class DrawPreview : Form
	{
		private string title = "";
		private int fontOffset = 20;
		private int gridLineWidth = 200;
		private int startX = 30;
		private int startY = 150;
		private List<ParticipantPair> pairs = new List<ParticipantPair>();
		private Dictionary<Point, Point> grid = new Dictionary<Point, Point>();
		private IContainer components = (IContainer)null;
		private PrintDocument printDocumentGrid;
		private Button buttonPrint;
		private int games = 0;
		private GridMap gridMap = new GridMap();
		private int participantCount = 0;

		public DrawPreview()
		{
			this.InitializeComponent();
		}

		public DrawPreview(string title, List<ParticipantPair> pairs, int participantCount)
		{
			this.InitializeComponent();
			this.title = title;
			this.pairs = pairs;
			this.participantCount = participantCount;
		}

		private void DrawPreview_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = this.CreateGraphics();
			//int participants = this.pairs.Count * 2;
			//if (this.pairs.ElementAt<ParticipantPair>(this.pairs.Count - 1).siro == null)
			//--participants;

			List<GridNode> nodes = this.gridMap.getMap(this.participantCount);
			Pen pen = new Pen(Color.Black, 5f);
			Brush brush = (Brush)new SolidBrush(Color.Black);

			if (nodes.Count > 0)
			{
				foreach (GridNode node in nodes)
				{
					if (node.getChildNodes().Count == 2)
					{
						graphics.DrawLine(pen, this.startX + node.getChildNodes()[0].getX() * this.gridLineWidth, this.startY + node.getChildNodes()[0].getY() * this.fontOffset, this.startX + node.getX() * this.gridLineWidth, this.startY + node.getChildNodes()[0].getY() * this.fontOffset);
						graphics.DrawLine(pen, this.startX + node.getChildNodes()[1].getX() * this.gridLineWidth, this.startY + node.getChildNodes()[1].getY() * this.fontOffset, this.startX + node.getX() * this.gridLineWidth, this.startY + node.getChildNodes()[1].getY() * this.fontOffset);

						graphics.DrawLine(pen, this.startX + node.getX() * this.gridLineWidth, this.startY + node.getChildNodes()[0].getY() * this.fontOffset, this.startX + node.getX() * this.gridLineWidth, this.startY + node.getChildNodes()[1].getY() * this.fontOffset);
					}
					else if (node.getChildNodes().Count == 1)
					{
						graphics.DrawLine(pen, this.startX + node.getChildNodes()[0].getX() * this.gridLineWidth, this.startY + node.getY() * this.fontOffset, this.startX + node.getX() * this.gridLineWidth, this.startY + node.getY() * this.fontOffset);
					}
				}
			}
			else
			{
				this.generateGrid(this.participantCount, graphics);
			}
            this.drawParticipants(graphics);
		}

		private void generateGrid(int participants, Graphics gr)
		{
			this.games = 0;
			Brush brush;
			if (participants <= 31 && participants != 4 && (participants != 8 && participants != 16) && participants != 32)
			{
				this.fillGrid(participants);
				Pen pen = new Pen(Color.Black, 5f);
				brush = (Brush)new SolidBrush(Color.Black);
				foreach (KeyValuePair<Point, Point> keyValuePair in this.grid)
				{
					gr.DrawLine(pen, this.startX + keyValuePair.Key.X, this.startY + keyValuePair.Key.Y, this.startX + keyValuePair.Value.X, this.startY + keyValuePair.Value.Y);
				}
				this.games = participants;
			}
			else
			{
				int num1 = participants % 2 == 0 ? participants : participants + 1;
				Pen pen = new Pen(Color.Black, 5f);
				brush = (Brush)new SolidBrush(Color.Black);
				PointF pointF = (PointF)new Point(this.startX, this.startY);
				int fontOffset = this.fontOffset;
				int num2 = 2 * this.fontOffset;
				int num3 = num1;
				while (num3 > 1)
				{
					int num4 = 1;
					while (num4 < num3)
					{
						gr.DrawLine(pen, pointF.X, pointF.Y, pointF.X + (float)this.gridLineWidth, pointF.Y);
						gr.DrawLine(pen, pointF.X, pointF.Y + (float)num2, pointF.X + (float)this.gridLineWidth, pointF.Y + (float)num2);
						gr.DrawLine(pen, pointF.X + (float)this.gridLineWidth, pointF.Y, pointF.X + (float)this.gridLineWidth, pointF.Y + (float)num2);
						++this.games;
						num4 += 2;
						pointF.Y += (float)(2 * num2);
					}
					num3 /= 2;
					pointF.X += (float)this.gridLineWidth;
					pointF.Y = (float)(this.startY + fontOffset);
					fontOffset += num2;
					num2 *= 2;
				}
				gr.DrawLine(pen, pointF.X, pointF.Y, pointF.X + (float)this.gridLineWidth, pointF.Y);
				this.games += 1;
			}
		}

		private void drawParticipants(Graphics gr)
		{
			Pen pen = new Pen(Color.Black, 5f);
			SolidBrush brush = new SolidBrush(Color.Black);
			Font font = new Font("Helvetica", 11f);
			String duration = "";
			int duration_seconds = this.games * 150;
			int duration_h = (int)duration_seconds / 3600;
			if (duration_h > 0)
			{
				duration += duration_h.ToString() + "г. ";
			}
			int duration_min = (int)((duration_seconds % 3600) / 60);
			duration += duration_min.ToString().PadLeft(2, '0') + "хв.";
			gr.DrawString(this.title, font, brush, 500f, (float)this.fontOffset);
			gr.DrawString("1. ______________", font, brush, 200f, (float)(3 * this.fontOffset));
			gr.DrawString("Команда ______________", font, brush, 150f, (float)(4 * this.fontOffset));
			gr.DrawString("2. ______________", font, brush, 400f, (float)(3 * this.fontOffset));
			gr.DrawString("Команда ______________", font, brush, 350f, (float)(4 * this.fontOffset));
			gr.DrawString("3. ______________", font, brush, 600f, (float)(3 * this.fontOffset));
			gr.DrawString("Команда ______________", font, brush, 550f, (float)(4 * this.fontOffset));
			gr.DrawString("______________", font, brush, 800f, (float)(3 * this.fontOffset));
			gr.DrawString("______________", font, brush, 800f, (float)(4 * this.fontOffset));
			gr.DrawString("Час категорії: " + duration, font, brush, 1050f, (float)(4 * this.fontOffset));
			PointF pointF = (PointF)new Point(this.startX, this.startY);
			foreach (ParticipantPair pair in this.pairs)
			{
				float point = pointF.Y - (float)this.fontOffset;
				int shift = 4;
				if (pair.aka.GetType() != typeof(FakeParticipant))
				{
					brush.Color = Color.Red;
					gr.DrawString(pair.aka.getName() + " (" + pair.aka.getTeam() + ")", font, brush, pointF.X, point);
					point = pointF.Y + (float)this.fontOffset;
				}
				else
				{
					shift = 2;
				}
				if (pair.siro != null && pair.siro.GetType() != typeof(FakeParticipant))
				{
					brush.Color = Color.Blue;
					gr.DrawString(pair.siro.getName() + " (" + pair.siro.getTeam() + ")", font, brush, pointF.X, point);
				}
				else
				{
					shift = 2;
				}
				pointF.Y += (float)(shift * this.fontOffset);
			}
		}

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			this.printDocumentGrid.PrintPage += new PrintPageEventHandler(this.printDocumentGrid_PrintPage);
			PrintDialog printDialog = new PrintDialog();
			printDialog.Document = this.printDocumentGrid;
			if (printDialog.ShowDialog((IWin32Window)this) != DialogResult.OK)
				return;
			this.printDocumentGrid.PrinterSettings = printDialog.PrinterSettings;
			if (new PrintPreviewDialog()
			{
				Document = this.printDocumentGrid
			}.ShowDialog() == DialogResult.OK)
				this.printDocumentGrid.Print();
		}

		private void printDocumentGrid_PrintPage(object sender, PrintPageEventArgs e)
		{
			this.generateGrid(this.pairs.Count * 2, e.Graphics);
			this.drawParticipants(e.Graphics);
		}

		private void fillGrid(int count)
		{
			if (this.grid.Count != 0)
				return;
			switch (count)
			{
				case 4:
					this.grid.Add(new Point(0, 0), new Point(this.gridLineWidth, 0));
					this.grid.Add(new Point(0, 2 * this.fontOffset), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(0, 4 * this.fontOffset), new Point(this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(0, 6 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 0), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 4 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 5 * this.fontOffset), new Point(2 * this.gridLineWidth, 5 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, 5 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 3 * this.fontOffset), new Point(3 * this.gridLineWidth, 3 * this.fontOffset));
					break;
				case 5:
					this.grid.Add(new Point(0, 0), new Point(this.gridLineWidth, 0));
					this.grid.Add(new Point(0, 2 * this.fontOffset), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(0, 4 * this.fontOffset), new Point(2 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(0, 6 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(0, 8 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 0), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 6 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 3 * this.fontOffset), new Point(3 * this.gridLineWidth, 3 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 7 * this.fontOffset), new Point(3 * this.gridLineWidth, 7 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 3 * this.fontOffset), new Point(3 * this.gridLineWidth, 7 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 5 * this.fontOffset), new Point(4 * this.gridLineWidth, 5 * this.fontOffset));
					break;
				case 6:
					this.grid.Add(new Point(0, 0), new Point(this.gridLineWidth, 0));
					this.grid.Add(new Point(0, 2 * this.fontOffset), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(0, 4 * this.fontOffset), new Point(2 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(0, 6 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(0, 8 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(0, 10 * this.fontOffset), new Point(2 * this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 0), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 6 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 7 * this.fontOffset), new Point(2 * this.gridLineWidth, 7 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 7 * this.fontOffset), new Point(2 * this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 3 * this.fontOffset), new Point(3 * this.gridLineWidth, 3 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 9 * this.fontOffset), new Point(3 * this.gridLineWidth, 9 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 3 * this.fontOffset), new Point(3 * this.gridLineWidth, 9 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 6 * this.fontOffset), new Point(4 * this.gridLineWidth, 6 * this.fontOffset));
					break;
				case 7:
					this.grid.Add(new Point(0, 0), new Point(this.gridLineWidth, 0));
					this.grid.Add(new Point(0, 2 * this.fontOffset), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(0, 4 * this.fontOffset), new Point(this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(0, 6 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(0, 8 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(0, 10 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(0, 12 * this.fontOffset), new Point(2 * this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 0), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 4 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 8 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 5 * this.fontOffset), new Point(2 * this.gridLineWidth, 5 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 9 * this.fontOffset), new Point(2 * this.gridLineWidth, 9 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, 5 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 9 * this.fontOffset), new Point(2 * this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 3 * this.fontOffset), new Point(3 * this.gridLineWidth, 3 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 11 * this.fontOffset), new Point(3 * this.gridLineWidth, 11 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 3 * this.fontOffset), new Point(3 * this.gridLineWidth, 11 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 7 * this.fontOffset), new Point(4 * this.gridLineWidth, 7 * this.fontOffset));
					this.games = 7;
					break;
				case 9:
					this.grid.Add(new Point(0, 0), new Point(this.gridLineWidth, 0));
					this.grid.Add(new Point(0, 2 * this.fontOffset), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(0, 4 * this.fontOffset), new Point(2 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(0, 6 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(0, 8 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(0, 10 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(0, 12 * this.fontOffset), new Point(this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(0, 14 * this.fontOffset), new Point(this.gridLineWidth, 14 * this.fontOffset));
					this.grid.Add(new Point(0, 16 * this.fontOffset), new Point(this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 0), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 6 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 10 * this.fontOffset), new Point(this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 14 * this.fontOffset), new Point(this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 11 * this.fontOffset), new Point(2 * this.gridLineWidth, 11 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 15 * this.fontOffset), new Point(2 * this.gridLineWidth, 15 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 11 * this.fontOffset), new Point(2 * this.gridLineWidth, 15 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 2 * this.fontOffset), new Point(3 * this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 7 * this.fontOffset), new Point(3 * this.gridLineWidth, 7 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 2 * this.fontOffset), new Point(3 * this.gridLineWidth, 7 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 4 * this.fontOffset), new Point(4 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 13 * this.fontOffset), new Point(4 * this.gridLineWidth, 13 * this.fontOffset));
					this.grid.Add(new Point(4 * this.gridLineWidth, 4 * this.fontOffset), new Point(4 * this.gridLineWidth, 13 * this.fontOffset));
					this.grid.Add(new Point(4 * this.gridLineWidth, 8 * this.fontOffset), new Point(5 * this.gridLineWidth, 8 * this.fontOffset));
					this.games = 9;
					break;
				case 10:
					this.grid.Add(new Point(0, 0), new Point(this.gridLineWidth, 0));
					this.grid.Add(new Point(0, 2 * this.fontOffset), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(0, 4 * this.fontOffset), new Point(2 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(0, 6 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(0, 8 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(0, 10 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(0, 12 * this.fontOffset), new Point(this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(0, 14 * this.fontOffset), new Point(this.gridLineWidth, 14 * this.fontOffset));
					this.grid.Add(new Point(0, 16 * this.fontOffset), new Point(this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(0, 18 * this.fontOffset), new Point(2 * this.gridLineWidth, 18 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 0), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 6 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 10 * this.fontOffset), new Point(this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 14 * this.fontOffset), new Point(this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 11 * this.fontOffset), new Point(3 * this.gridLineWidth, 11 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 15 * this.fontOffset), new Point(2 * this.gridLineWidth, 15 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 2 * this.fontOffset), new Point(3 * this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 7 * this.fontOffset), new Point(3 * this.gridLineWidth, 7 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 2 * this.fontOffset), new Point(3 * this.gridLineWidth, 7 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 15 * this.fontOffset), new Point(2 * this.gridLineWidth, 18 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 16 * this.fontOffset), new Point(3 * this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 11 * this.fontOffset), new Point(3 * this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 5 * this.fontOffset), new Point(4 * this.gridLineWidth, 5 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 13 * this.fontOffset), new Point(4 * this.gridLineWidth, 13 * this.fontOffset));
					this.grid.Add(new Point(4 * this.gridLineWidth, 5 * this.fontOffset), new Point(4 * this.gridLineWidth, 13 * this.fontOffset));
					this.grid.Add(new Point(4 * this.gridLineWidth, 9 * this.fontOffset), new Point(5 * this.gridLineWidth, 9 * this.fontOffset));
					this.games = 10;
					break;
				case 11:
					this.grid.Add(new Point(0, 0), new Point(this.gridLineWidth, 0));
					this.grid.Add(new Point(0, 2 * this.fontOffset), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(0, 4 * this.fontOffset), new Point(this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(0, 6 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(0, 8 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(0, 10 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(0, 12 * this.fontOffset), new Point(this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(0, 14 * this.fontOffset), new Point(this.gridLineWidth, 14 * this.fontOffset));
					this.grid.Add(new Point(0, 16 * this.fontOffset), new Point(this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(0, 18 * this.fontOffset), new Point(this.gridLineWidth, 18 * this.fontOffset));
					this.grid.Add(new Point(0, 20 * this.fontOffset), new Point(2 * this.gridLineWidth, 20 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 0), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 4 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 8 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 12 * this.fontOffset), new Point(this.gridLineWidth, 14 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 16 * this.fontOffset), new Point(this.gridLineWidth, 18 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 5 * this.fontOffset), new Point(2 * this.gridLineWidth, 5 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 17 * this.fontOffset), new Point(2 * this.gridLineWidth, 17 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, 5 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 17 * this.fontOffset), new Point(2 * this.gridLineWidth, 20 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 3 * this.fontOffset), new Point(3 * this.gridLineWidth, 3 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 9 * this.fontOffset), new Point(3 * this.gridLineWidth, 9 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 3 * this.fontOffset), new Point(3 * this.gridLineWidth, 9 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 13 * this.fontOffset), new Point(3 * this.gridLineWidth, 13 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 18 * this.fontOffset), new Point(3 * this.gridLineWidth, 18 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 13 * this.fontOffset), new Point(3 * this.gridLineWidth, 18 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 6 * this.fontOffset), new Point(4 * this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 15 * this.fontOffset), new Point(4 * this.gridLineWidth, 15 * this.fontOffset));
					this.grid.Add(new Point(4 * this.gridLineWidth, 6 * this.fontOffset), new Point(4 * this.gridLineWidth, 15 * this.fontOffset));
					this.grid.Add(new Point(4 * this.gridLineWidth, 11 * this.fontOffset), new Point(5 * this.gridLineWidth, 11 * this.fontOffset));
					this.games = 11;
					break;
				case 12:
					this.grid.Add(new Point(0, 0), new Point(this.gridLineWidth, 0));
					this.grid.Add(new Point(0, 2 * this.fontOffset), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(0, 4 * this.fontOffset), new Point(this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(0, 6 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(0, 8 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(0, 10 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(0, 12 * this.fontOffset), new Point(this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(0, 14 * this.fontOffset), new Point(this.gridLineWidth, 14 * this.fontOffset));
					this.grid.Add(new Point(0, 16 * this.fontOffset), new Point(this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(0, 18 * this.fontOffset), new Point(this.gridLineWidth, 18 * this.fontOffset));
					this.grid.Add(new Point(0, 20 * this.fontOffset), new Point(this.gridLineWidth, 20 * this.fontOffset));
					this.grid.Add(new Point(0, 22 * this.fontOffset), new Point(this.gridLineWidth, 22 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 0), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 4 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 8 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 12 * this.fontOffset), new Point(this.gridLineWidth, 14 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 16 * this.fontOffset), new Point(this.gridLineWidth, 18 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 20 * this.fontOffset), new Point(this.gridLineWidth, 22 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 5 * this.fontOffset), new Point(2 * this.gridLineWidth, 5 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 17 * this.fontOffset), new Point(2 * this.gridLineWidth, 17 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 21 * this.fontOffset), new Point(2 * this.gridLineWidth, 21 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, 5 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 17 * this.fontOffset), new Point(2 * this.gridLineWidth, 21 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 3 * this.fontOffset), new Point(3 * this.gridLineWidth, 3 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 9 * this.fontOffset), new Point(3 * this.gridLineWidth, 9 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 3 * this.fontOffset), new Point(3 * this.gridLineWidth, 9 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 13 * this.fontOffset), new Point(3 * this.gridLineWidth, 13 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 19 * this.fontOffset), new Point(3 * this.gridLineWidth, 19 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 13 * this.fontOffset), new Point(3 * this.gridLineWidth, 19 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 6 * this.fontOffset), new Point(4 * this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 16 * this.fontOffset), new Point(4 * this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(4 * this.gridLineWidth, 6 * this.fontOffset), new Point(4 * this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(4 * this.gridLineWidth, 11 * this.fontOffset), new Point(5 * this.gridLineWidth, 11 * this.fontOffset));
					this.games = 12;
					break;
				case 13:
					this.grid.Add(new Point(0, 0), new Point(this.gridLineWidth, 0));
					this.grid.Add(new Point(0, 2 * this.fontOffset), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(0, 4 * this.fontOffset), new Point(2 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(0, 6 * this.fontOffset), new Point(2 * this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(0, 8 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(0, 10 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(0, 12 * this.fontOffset), new Point(this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(0, 14 * this.fontOffset), new Point(this.gridLineWidth, 14 * this.fontOffset));
					this.grid.Add(new Point(0, 16 * this.fontOffset), new Point(this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(0, 18 * this.fontOffset), new Point(this.gridLineWidth, 18 * this.fontOffset));
					this.grid.Add(new Point(0, 20 * this.fontOffset), new Point(2 * this.gridLineWidth, 20 * this.fontOffset));
					this.grid.Add(new Point(0, 22 * this.fontOffset), new Point(this.gridLineWidth, 22 * this.fontOffset));
					this.grid.Add(new Point(0, 24 * this.fontOffset), new Point(this.gridLineWidth, 24 * this.fontOffset));

					this.grid.Add(new Point(this.gridLineWidth, 0), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 8 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 12 * this.fontOffset), new Point(this.gridLineWidth, 14 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 16 * this.fontOffset), new Point(this.gridLineWidth, 18 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 22 * this.fontOffset), new Point(this.gridLineWidth, 24 * this.fontOffset));

					this.grid.Add(new Point(this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 9 * this.fontOffset), new Point(2 * this.gridLineWidth, 9 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 13 * this.fontOffset), new Point(2 * this.gridLineWidth, 13 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 17 * this.fontOffset), new Point(2 * this.gridLineWidth, 17 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 23 * this.fontOffset), new Point(2 * this.gridLineWidth, 23 * this.fontOffset));

					//this.grid.Add(new Point(this.gridLineWidth, this.fontOffset), new Point(this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 6 * this.fontOffset), new Point(2 * this.gridLineWidth, 9 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 13 * this.fontOffset), new Point(2 * this.gridLineWidth, 17 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 20 * this.fontOffset), new Point(2 * this.gridLineWidth, 23 * this.fontOffset));

					this.grid.Add(new Point(2 * this.gridLineWidth, 2 * this.fontOffset), new Point(3 * this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 8 * this.fontOffset), new Point(3 * this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 15 * this.fontOffset), new Point(3 * this.gridLineWidth, 15 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 21 * this.fontOffset), new Point(3 * this.gridLineWidth, 21 * this.fontOffset));

					this.grid.Add(new Point(3 * this.gridLineWidth, 2 * this.fontOffset), new Point(3 * this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 15 * this.fontOffset), new Point(3 * this.gridLineWidth, 21 * this.fontOffset));

					this.grid.Add(new Point(3 * this.gridLineWidth, 5 * this.fontOffset), new Point(4 * this.gridLineWidth, 5 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 18 * this.fontOffset), new Point(4 * this.gridLineWidth, 18 * this.fontOffset));

					this.grid.Add(new Point(4 * this.gridLineWidth, 5 * this.fontOffset), new Point(4 * this.gridLineWidth, 18 * this.fontOffset));

					this.grid.Add(new Point(4 * this.gridLineWidth, 11 * this.fontOffset), new Point(5 * this.gridLineWidth, 11 * this.fontOffset));
					break;

				case 14:
					this.grid.Add(new Point(0, 0), new Point(this.gridLineWidth, 0));
					this.grid.Add(new Point(0, 2 * this.fontOffset), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(0, 4 * this.fontOffset), new Point(2 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(0, 6 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(0, 8 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(0, 10 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(0, 12 * this.fontOffset), new Point(this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(0, 14 * this.fontOffset), new Point(this.gridLineWidth, 14 * this.fontOffset));
					this.grid.Add(new Point(0, 16 * this.fontOffset), new Point(this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(0, 18 * this.fontOffset), new Point(this.gridLineWidth, 18 * this.fontOffset));
					this.grid.Add(new Point(0, 20 * this.fontOffset), new Point(this.gridLineWidth, 20 * this.fontOffset));
					this.grid.Add(new Point(0, 22 * this.fontOffset), new Point(2 * this.gridLineWidth, 22 * this.fontOffset));
					this.grid.Add(new Point(0, 24 * this.fontOffset), new Point(this.gridLineWidth, 24 * this.fontOffset));
					this.grid.Add(new Point(0, 26 * this.fontOffset), new Point(this.gridLineWidth, 26 * this.fontOffset));

					this.grid.Add(new Point(this.gridLineWidth, 0), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 6 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 10 * this.fontOffset), new Point(this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 14 * this.fontOffset), new Point(this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 18 * this.fontOffset), new Point(this.gridLineWidth, 20 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 24 * this.fontOffset), new Point(this.gridLineWidth, 26 * this.fontOffset));

					this.grid.Add(new Point(this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 7 * this.fontOffset), new Point(2 * this.gridLineWidth, 7 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 11 * this.fontOffset), new Point(2 * this.gridLineWidth, 11 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 15 * this.fontOffset), new Point(2 * this.gridLineWidth, 15 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 19 * this.fontOffset), new Point(2 * this.gridLineWidth, 19 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 25 * this.fontOffset), new Point(2 * this.gridLineWidth, 25 * this.fontOffset));

					this.grid.Add(new Point(2 * this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 7 * this.fontOffset), new Point(2 * this.gridLineWidth, 11 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 15 * this.fontOffset), new Point(2 * this.gridLineWidth, 19 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 22 * this.fontOffset), new Point(2 * this.gridLineWidth, 25 * this.fontOffset));

					this.grid.Add(new Point(2 * this.gridLineWidth, 2 * this.fontOffset), new Point(3 * this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 9 * this.fontOffset), new Point(3 * this.gridLineWidth, 9 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 17 * this.fontOffset), new Point(3 * this.gridLineWidth, 17 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 24 * this.fontOffset), new Point(3 * this.gridLineWidth, 24 * this.fontOffset));

					this.grid.Add(new Point(3 * this.gridLineWidth, 2 * this.fontOffset), new Point(3 * this.gridLineWidth, 9 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 17 * this.fontOffset), new Point(3 * this.gridLineWidth, 24 * this.fontOffset));

					this.grid.Add(new Point(3 * this.gridLineWidth, 6 * this.fontOffset), new Point(4 * this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 21 * this.fontOffset), new Point(4 * this.gridLineWidth, 21 * this.fontOffset));

					this.grid.Add(new Point(4 * this.gridLineWidth, 6 * this.fontOffset), new Point(4 * this.gridLineWidth, 21 * this.fontOffset));

					this.grid.Add(new Point(4 * this.gridLineWidth, 13 * this.fontOffset), new Point(5 * this.gridLineWidth, 13 * this.fontOffset));
					break;
				case 15:
					this.grid.Add(new Point(0, 0), new Point(this.gridLineWidth, 0));
					this.grid.Add(new Point(0, 2 * this.fontOffset), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(0, 4 * this.fontOffset), new Point(2 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(0, 6 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(0, 8 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(0, 10 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(0, 12 * this.fontOffset), new Point(this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(0, 14 * this.fontOffset), new Point(2 * this.gridLineWidth, 14 * this.fontOffset));
					this.grid.Add(new Point(0, 16 * this.fontOffset), new Point(this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(0, 18 * this.fontOffset), new Point(this.gridLineWidth, 18 * this.fontOffset));
					this.grid.Add(new Point(0, 20 * this.fontOffset), new Point(this.gridLineWidth, 20 * this.fontOffset));
					this.grid.Add(new Point(0, 22 * this.fontOffset), new Point(this.gridLineWidth, 22 * this.fontOffset));
					this.grid.Add(new Point(0, 24 * this.fontOffset), new Point(2 * this.gridLineWidth, 24 * this.fontOffset));
					this.grid.Add(new Point(0, 26 * this.fontOffset), new Point(this.gridLineWidth, 26 * this.fontOffset));
					this.grid.Add(new Point(0, 28 * this.fontOffset), new Point(this.gridLineWidth, 28 * this.fontOffset));

					this.grid.Add(new Point(this.gridLineWidth, 0), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 6 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 10 * this.fontOffset), new Point(this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 16 * this.fontOffset), new Point(this.gridLineWidth, 18 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 20 * this.fontOffset), new Point(this.gridLineWidth, 22 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 26 * this.fontOffset), new Point(this.gridLineWidth, 28 * this.fontOffset));

					this.grid.Add(new Point(this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 11 * this.fontOffset), new Point(2 * this.gridLineWidth, 11 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 17 * this.fontOffset), new Point(2 * this.gridLineWidth, 17 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 21 * this.fontOffset), new Point(2 * this.gridLineWidth, 21 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 27 * this.fontOffset), new Point(2 * this.gridLineWidth, 27 * this.fontOffset));

					this.grid.Add(new Point(2 * this.gridLineWidth, this.fontOffset), new Point(2 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 11 * this.fontOffset), new Point(2 * this.gridLineWidth, 14 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 17 * this.fontOffset), new Point(2 * this.gridLineWidth, 21 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 24 * this.fontOffset), new Point(2 * this.gridLineWidth, 27 * this.fontOffset));

					this.grid.Add(new Point(2 * this.gridLineWidth, 2 * this.fontOffset), new Point(3 * this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 7 * this.fontOffset), new Point(3 * this.gridLineWidth, 7 * this.fontOffset));

					this.grid.Add(new Point(3 * this.gridLineWidth, 2 * this.fontOffset), new Point(3 * this.gridLineWidth, 7 * this.fontOffset));

					this.grid.Add(new Point(3 * this.gridLineWidth, 4 * this.fontOffset), new Point(4 * this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 12 * this.fontOffset), new Point(4 * this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 19 * this.fontOffset), new Point(4 * this.gridLineWidth, 19 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 25 * this.fontOffset), new Point(4 * this.gridLineWidth, 25 * this.fontOffset));

					this.grid.Add(new Point(4 * this.gridLineWidth, 4 * this.fontOffset), new Point(4 * this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(4 * this.gridLineWidth, 19 * this.fontOffset), new Point(4 * this.gridLineWidth, 25 * this.fontOffset));

					this.grid.Add(new Point(4 * this.gridLineWidth, 8 * this.fontOffset), new Point(5 * this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(4 * this.gridLineWidth, 22 * this.fontOffset), new Point(5 * this.gridLineWidth, 22 * this.fontOffset));

					this.grid.Add(new Point(5 * this.gridLineWidth, 8 * this.fontOffset), new Point(5 * this.gridLineWidth, 22 * this.fontOffset));

					this.grid.Add(new Point(5 * this.gridLineWidth, 15 * this.fontOffset), new Point(6 * this.gridLineWidth, 15 * this.fontOffset));
					break;
				case 17:
					this.grid.Add(new Point(0, 0), new Point(this.gridLineWidth, 0));
					this.grid.Add(new Point(0, 2 * this.fontOffset), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(0, 4 * this.fontOffset), new Point(this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(0, 6 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(0, 8 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(0, 10 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(0, 12 * this.fontOffset), new Point(2 * this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(0, 14 * this.fontOffset), new Point(this.gridLineWidth, 14 * this.fontOffset));
					this.grid.Add(new Point(0, 16 * this.fontOffset), new Point(this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(0, 18 * this.fontOffset), new Point(this.gridLineWidth, 18 * this.fontOffset));
					this.grid.Add(new Point(0, 20 * this.fontOffset), new Point(this.gridLineWidth, 20 * this.fontOffset));
					this.grid.Add(new Point(0, 22 * this.fontOffset), new Point(this.gridLineWidth, 22 * this.fontOffset));
					this.grid.Add(new Point(0, 24 * this.fontOffset), new Point(this.gridLineWidth, 24 * this.fontOffset));
					this.grid.Add(new Point(0, 26 * this.fontOffset), new Point(this.gridLineWidth, 26 * this.fontOffset));
					this.grid.Add(new Point(0, 28 * this.fontOffset), new Point(this.gridLineWidth, 28 * this.fontOffset));
					this.grid.Add(new Point(0, 30 * this.fontOffset), new Point(this.gridLineWidth, 30 * this.fontOffset));
					this.grid.Add(new Point(0, 32 * this.fontOffset), new Point(this.gridLineWidth, 32 * this.fontOffset));

					this.grid.Add(new Point(this.gridLineWidth, 0), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 4 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 8 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 14 * this.fontOffset), new Point(this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 18 * this.fontOffset), new Point(this.gridLineWidth, 20 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 22 * this.fontOffset), new Point(this.gridLineWidth, 24 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 26 * this.fontOffset), new Point(this.gridLineWidth, 28 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 30 * this.fontOffset), new Point(this.gridLineWidth, 32 * this.fontOffset));

					this.grid.Add(new Point(this.gridLineWidth, 9 * this.fontOffset), new Point(2 * this.gridLineWidth, 9 * this.fontOffset));

					this.grid.Add(new Point(2 * this.gridLineWidth, 9 * this.fontOffset), new Point(2 * this.gridLineWidth, 12 * this.fontOffset));

					this.grid.Add(new Point(this.gridLineWidth, this.fontOffset), new Point(3 * this.gridLineWidth, this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 5 * this.fontOffset), new Point(3 * this.gridLineWidth, 5 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 11 * this.fontOffset), new Point(3 * this.gridLineWidth, 11 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 15 * this.fontOffset), new Point(3 * this.gridLineWidth, 15 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 19 * this.fontOffset), new Point(3 * this.gridLineWidth, 19 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 23 * this.fontOffset), new Point(3 * this.gridLineWidth, 23 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 27 * this.fontOffset), new Point(3 * this.gridLineWidth, 27 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 31 * this.fontOffset), new Point(3 * this.gridLineWidth, 31 * this.fontOffset));

					this.grid.Add(new Point(3 * this.gridLineWidth, this.fontOffset), new Point(3 * this.gridLineWidth, 5 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 11 * this.fontOffset), new Point(3 * this.gridLineWidth, 15 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 19 * this.fontOffset), new Point(3 * this.gridLineWidth, 23 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 27 * this.fontOffset), new Point(3 * this.gridLineWidth, 31 * this.fontOffset));

					this.grid.Add(new Point(3 * this.gridLineWidth, 3 * this.fontOffset), new Point(4 * this.gridLineWidth, 3 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 13 * this.fontOffset), new Point(4 * this.gridLineWidth, 13 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 21 * this.fontOffset), new Point(4 * this.gridLineWidth, 21 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 29 * this.fontOffset), new Point(4 * this.gridLineWidth, 29 * this.fontOffset));

					this.grid.Add(new Point(4 * this.gridLineWidth, 3 * this.fontOffset), new Point(4 * this.gridLineWidth, 13 * this.fontOffset));
					this.grid.Add(new Point(4 * this.gridLineWidth, 21 * this.fontOffset), new Point(4 * this.gridLineWidth, 29 * this.fontOffset));

					this.grid.Add(new Point(4 * this.gridLineWidth, 8 * this.fontOffset), new Point(5 * this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(4 * this.gridLineWidth, 25 * this.fontOffset), new Point(5 * this.gridLineWidth, 25 * this.fontOffset));

					this.grid.Add(new Point(5 * this.gridLineWidth, 8 * this.fontOffset), new Point(5 * this.gridLineWidth, 25 * this.fontOffset));

					this.grid.Add(new Point(5 * this.gridLineWidth, 16 * this.fontOffset), new Point(6 * this.gridLineWidth, 16 * this.fontOffset));
					break;
				case 18:
					this.grid.Add(new Point(0, 0), new Point(this.gridLineWidth, 0));
					this.grid.Add(new Point(0, 2 * this.fontOffset), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(0, 4 * this.fontOffset), new Point(this.gridLineWidth, 4 * this.fontOffset));
					this.grid.Add(new Point(0, 6 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(0, 8 * this.fontOffset), new Point(this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(0, 10 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(0, 12 * this.fontOffset), new Point(this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(0, 14 * this.fontOffset), new Point(this.gridLineWidth, 14 * this.fontOffset));
					this.grid.Add(new Point(0, 16 * this.fontOffset), new Point(2 * this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(0, 18 * this.fontOffset), new Point(2 * this.gridLineWidth, 18 * this.fontOffset));
					this.grid.Add(new Point(0, 20 * this.fontOffset), new Point(this.gridLineWidth, 20 * this.fontOffset));
					this.grid.Add(new Point(0, 22 * this.fontOffset), new Point(this.gridLineWidth, 22 * this.fontOffset));
					this.grid.Add(new Point(0, 24 * this.fontOffset), new Point(this.gridLineWidth, 24 * this.fontOffset));
					this.grid.Add(new Point(0, 26 * this.fontOffset), new Point(this.gridLineWidth, 26 * this.fontOffset));
					this.grid.Add(new Point(0, 28 * this.fontOffset), new Point(this.gridLineWidth, 28 * this.fontOffset));
					this.grid.Add(new Point(0, 30 * this.fontOffset), new Point(this.gridLineWidth, 30 * this.fontOffset));
					this.grid.Add(new Point(0, 32 * this.fontOffset), new Point(this.gridLineWidth, 32 * this.fontOffset));
					this.grid.Add(new Point(0, 34 * this.fontOffset), new Point(this.gridLineWidth, 34 * this.fontOffset));

					this.grid.Add(new Point(this.gridLineWidth, 0), new Point(this.gridLineWidth, 2 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 4 * this.fontOffset), new Point(this.gridLineWidth, 6 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 8 * this.fontOffset), new Point(this.gridLineWidth, 10 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 12 * this.fontOffset), new Point(this.gridLineWidth, 14 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 20 * this.fontOffset), new Point(this.gridLineWidth, 22 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 24 * this.fontOffset), new Point(this.gridLineWidth, 26 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 28 * this.fontOffset), new Point(this.gridLineWidth, 30 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 32 * this.fontOffset), new Point(this.gridLineWidth, 34 * this.fontOffset));

					this.grid.Add(new Point(this.gridLineWidth, 13 * this.fontOffset), new Point(2 * this.gridLineWidth, 13 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 21 * this.fontOffset), new Point(2 * this.gridLineWidth, 21 * this.fontOffset));

					this.grid.Add(new Point(2 * this.gridLineWidth, 13 * this.fontOffset), new Point(2 * this.gridLineWidth, 16 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 18 * this.fontOffset), new Point(2 * this.gridLineWidth, 21 * this.fontOffset));

					this.grid.Add(new Point(this.gridLineWidth, this.fontOffset), new Point(3 * this.gridLineWidth, this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 5 * this.fontOffset), new Point(3 * this.gridLineWidth, 5 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 9 * this.fontOffset), new Point(3 * this.gridLineWidth, 9 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 15 * this.fontOffset), new Point(3 * this.gridLineWidth, 15 * this.fontOffset));
					this.grid.Add(new Point(2 * this.gridLineWidth, 19 * this.fontOffset), new Point(3 * this.gridLineWidth, 19 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 25 * this.fontOffset), new Point(3 * this.gridLineWidth, 25 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 29 * this.fontOffset), new Point(3 * this.gridLineWidth, 29 * this.fontOffset));
					this.grid.Add(new Point(this.gridLineWidth, 33 * this.fontOffset), new Point(3 * this.gridLineWidth, 33 * this.fontOffset));

					this.grid.Add(new Point(3 * this.gridLineWidth, this.fontOffset), new Point(3 * this.gridLineWidth, 5 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 9 * this.fontOffset), new Point(3 * this.gridLineWidth, 15 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 19 * this.fontOffset), new Point(3 * this.gridLineWidth, 25 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 29 * this.fontOffset), new Point(3 * this.gridLineWidth, 33 * this.fontOffset));

					this.grid.Add(new Point(3 * this.gridLineWidth, 3 * this.fontOffset), new Point(4 * this.gridLineWidth, 3 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 12 * this.fontOffset), new Point(4 * this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 22 * this.fontOffset), new Point(4 * this.gridLineWidth, 22 * this.fontOffset));
					this.grid.Add(new Point(3 * this.gridLineWidth, 31 * this.fontOffset), new Point(4 * this.gridLineWidth, 31 * this.fontOffset));

					this.grid.Add(new Point(4 * this.gridLineWidth, 3 * this.fontOffset), new Point(4 * this.gridLineWidth, 12 * this.fontOffset));
					this.grid.Add(new Point(4 * this.gridLineWidth, 22 * this.fontOffset), new Point(4 * this.gridLineWidth, 31 * this.fontOffset));

					this.grid.Add(new Point(4 * this.gridLineWidth, 8 * this.fontOffset), new Point(5 * this.gridLineWidth, 8 * this.fontOffset));
					this.grid.Add(new Point(4 * this.gridLineWidth, 26 * this.fontOffset), new Point(5 * this.gridLineWidth, 26 * this.fontOffset));

					this.grid.Add(new Point(5 * this.gridLineWidth, 8 * this.fontOffset), new Point(5 * this.gridLineWidth, 26 * this.fontOffset));

					this.grid.Add(new Point(5 * this.gridLineWidth, 17 * this.fontOffset), new Point(6 * this.gridLineWidth, 17 * this.fontOffset));
					break;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
				this.components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.printDocumentGrid = new PrintDocument();
			this.buttonPrint = new Button();
			this.SuspendLayout();
			this.buttonPrint.Location = new Point(12, 12);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new Size(75, 23);
			this.buttonPrint.TabIndex = 0;
			this.buttonPrint.Text = "Друк";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new EventHandler(this.buttonPrint_Click);
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(1027, 594);
			this.Controls.Add((Control)this.buttonPrint);
			this.Name = nameof(DrawPreview);
			this.Text = nameof(DrawPreview);
			this.Paint += new PaintEventHandler(this.DrawPreview_Paint);
			this.ResumeLayout(false);
			this.WindowState = FormWindowState.Maximized;
			this.BackColor = Color.White;
		}
	}
}
