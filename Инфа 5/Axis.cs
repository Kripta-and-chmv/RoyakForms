using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Инфа_5
{
    class Grid
    {
        private Point start;
        private int step = 10;
        private Pen forAxis = new Pen(Color.Black, 3);
        private Pen forGrid = new Pen(Color.Black, 1);

        public Point Start
        {
            get
            {
                return start;
            }
            set
            {
                start = value;
            }

        }

        public int Step
        {
            get
            {
                return step;
            }

            set
            {
                if (value > 0)
                    step = value;
            }
        }

        public void Draw(Graphics graphics, int height, int width)
        {
            if (step > 5)
                DrawGrid(graphics, height, width);
            DrawAxis(graphics, height, width);
        }

        private void DrawGrid(Graphics graphics, int height, int width)
        {
            for (int i = start.X; i <= width; i += step)
                graphics.DrawLine(forGrid, new Point(i, 0), new Point(i, height));
            for (int i = start.X; i >= 0; i -= step)
                graphics.DrawLine(forGrid, new Point(i, 0), new Point(i, height));

            for (int i = start.Y - 1; i >= 0; i -= step)
                graphics.DrawLine(forGrid, new Point(0, i), new Point(width, i));
            for (int i = start.Y; i <= height; i += step)
                graphics.DrawLine(forGrid, new Point(0, i), new Point(width, i));
        }

        private void DrawAxis(Graphics graphics, int height, int width)
        {
            graphics.DrawLine(forAxis, new Point(Start.X, 0), new Point(Start.X, height));
            graphics.DrawLine(forAxis, new Point(Start.X, 0), new Point(Start.X - 5, 10));
            graphics.DrawLine(forAxis, new Point(Start.X, 0), new Point(Start.X + 5, 10));
            graphics.DrawString("Y", new Font("Arial", 15), Brushes.Red, new Point(Start.X - 25, 0));


            graphics.DrawLine(forAxis, new Point(0, Start.Y), new Point(width, Start.Y));
            graphics.DrawLine(forAxis, new Point(width, Start.Y), new Point(width - 10, Start.Y - 5));
            graphics.DrawLine(forAxis, new Point(width, Start.Y), new Point(width - 10, Start.Y + 5));
            graphics.DrawString("X", new Font("Arial", 15), Brushes.Red, new Point(width - 25, Start.Y));
        }
    }
}
