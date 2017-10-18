using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using line;
using System.Drawing.Drawing2D;

namespace Инфа_5
{
    public partial class Form1 : Form
    {
        public static Point pointsAddition (Point x, Point y)
        {
            return new Point(x.X + y.X, x.Y + y.Y);
        }

        public static Point pointsSubstraction(Point x, Point y)
        {
            return new Point(x.X - y.X, x.Y - y.Y);
        }

        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            this.DoubleBuffered = true;

            graphics.SmoothingMode = SmoothingMode.HighQuality;
            pictureBox1.Focus();
            forGrid = new Pen(Color.Black);

            grid.Start = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            if (mouse.IsMoveMode)
                pictureBox1.Cursor = Cursors.Hand;
            else
                pictureBox1.Cursor = Cursors.Cross;
        }

        Grid grid = new Grid();
        List<Line> lines = new List<Line>();
        Line line = new Line();
        Graphics graphics;
        Pen forGrid;
        int step = 10;

        Mouse mouse = new Mouse();

        void drawLines(List<Line> lines, Graphics _graphics)
        {
            if (lines.Count != 0)
                foreach (Line el in lines)
                    el.draw(_graphics);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse.Position = new Point(e.X, e.Y);
                mouse.IsPushed = true;
            }
            if(e.Button == MouseButtons.Right)
            {
                mouse.IsMoveMode = !mouse.IsMoveMode;

                if (mouse.IsMoveMode)
                    pictureBox1.Cursor = Cursors.Hand;
                else
                    pictureBox1.Cursor = Cursors.Cross;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoordX.Text = ((e.X - grid.Start.X) / (float)grid.Step).ToString();
            lblCoordY.Text = ((grid.Start.Y - e.Y) / (float)grid.Step).ToString();

            if (mouse.IsPushed && mouse.IsMoveMode)
            {
                Point difference = pointsSubstraction(mouse.Position, new Point(e.X, e.Y));
                mouse.Position = new Point(e.X, e.Y);
                //difference.X /= 5;
                //difference.Y /= 5;
                grid.Start = pointsAddition(grid.Start, difference);
                for(int i = 0; i < lines.Count; i++)
                {
                    lines[i].Begin = pointsAddition(lines[i].Begin, difference);
                    lines[i].End = pointsAddition(lines[i].End, difference);
                }
                timer1.Start();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse.IsPushed = false;

                if(!mouse.IsMoveMode)
                {
                    if (!mouse.IsDrawing)
                    {
                        mouse.IsDrawing = true;
                        line.Begin = new Point(e.X, e.Y);
                    }
                    else
                    {
                        line.End = new Point(e.X, e.Y);
                        lines.Add(line);
                        line = new Line();
                        timer1.Start();
                        mouse.IsDrawing = false;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //graphics.Clear(Color.White);
            pictureBox1.Refresh();
            grid.Draw(graphics, pictureBox1.Height, pictureBox1.Width);

            if(lines.Count > 1)
            {
                lines[0].draw(graphics);
                lines[1].draw(graphics);
            }
            foreach (Line el in lines)
            {
                el.draw(graphics);
            }
            timer1.Stop();
        }

        private void btnStepDec_Click(object sender, EventArgs e)
        {
            float dif = (float)(grid.Step - step) / (float)grid.Step;
            grid.Step = grid.Step - step;
            if (dif > 0)
            {
                foreach (Line line in lines)
                {
                    int beginX = (int)((line.Begin.X - grid.Start.X) * dif);
                    int beginY = (int)((grid.Start.Y - line.Begin.Y) * dif);
                    int endX = (int)((line.End.X - grid.Start.X) * dif);
                    int endY = (int)((grid.Start.Y - line.End.Y) * dif);
                    line.Begin = new Point(beginX + grid.Start.X, grid.Start.Y - beginY);
                    line.End = new Point(endX + grid.Start.X, grid.Start.Y - endY);
                }
                timer1.Start();
            }
        }

        private void btnStepInc_Click(object sender, EventArgs e)
        {
            float dif = (float)(grid.Step + step) / (float)grid.Step;
            grid.Step = grid.Step + step;
            foreach(Line line in lines)
            {
                int beginX = (int)((line.Begin.X - grid.Start.X) * dif);
                int beginY = (int)((grid.Start.Y - line.Begin.Y) * dif);
                int endX = (int)((line.End.X - grid.Start.X) * dif);
                int endY = (int)((grid.Start.Y - line.End.Y) * dif);
                line.Begin = new Point(beginX + grid.Start.X, grid.Start.Y - beginY);
                line.End = new Point(endX + grid.Start.X, grid.Start.Y - endY);
            }
            timer1.Start();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            try
            {
                lines.RemoveAt(lines.Count - 1);
                timer1.Start();
            }
            catch
            {
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            line = new Line();
            mouse.IsDrawing = false;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Graphs(*.grph;*.txt;)|*.grph;*.txt;|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    readGraph(open_dialog.FileName);
                    timer1.Start();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Impossible to open selected file",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void readGraph(string fileName)
        {
            
            string[] fDots = System.IO.File.ReadAllLines(fileName);

            using (var file = new System.IO.StreamReader(fileName))
            {
                lines.Clear();
                var begin = new Point(0, 0);
                while (!file.EndOfStream)
                {
                    var bufLine = new Line();
                    bufLine.Begin = begin;
                    var coord = file.ReadLine().Split(' ');
                    float x = 0;
                    float.TryParse(coord[0], out x);
                    float y = 0;
                    float.TryParse(coord[1], out y);
                    bufLine.End = new Point((int)x * grid.Step + grid.Start.X, grid.Start.Y - (int)y * grid.Step);
                    lines.Add(bufLine);
                    begin = bufLine.End;
                }
                lines.RemoveAt(0);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Title = "Сохранить график как ...";
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.Filter = "Graphs(*.grph;)|*.grph;|All files (*.*)|*.*";
            saveFileDialog1.ShowHelp = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                saveDotsInFile(saveFileDialog1.FileName);
        }

        private void saveDotsInFile(string fileName)
        {
            //lblCoordX.Text = ((e.X - grid.Start.X) / (float)grid.Step).ToString();
            //lblCoordY.Text = ((grid.Start.Y - e.Y) / (float)grid.Step).ToString();
            using (var file = new System.IO.StreamWriter(fileName))
            {
                var dot = String.Format("{0} {1}", (lines[0].Begin.X - grid.Start.X) / (float)grid.Step, (grid.Start.Y - lines[0].Begin.Y) / (float)grid.Step);
                file.WriteLine(dot);
                foreach(var line in lines)
                    file.WriteLine(String.Format("{0} {1}", (line.End.X - grid.Start.X) / (float)grid.Step, (grid.Start.Y - line.End.Y) / (float)grid.Step));
            }
        }
    }
}