using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace line
{
    class Line
    {
        public Pen pen = new Pen(Color.Red);
        private Point begin, end;

        public Point Begin
        {
            get { return begin; }
            set { begin = value; }
        }

        public Point End
        {
            get { return end; }
            set { end = value; }
        }

        public bool draw(Graphics graphics)
        {
            try
            {
                graphics.DrawLine(pen, begin, end);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void set_pen(Pen p)
        {
            pen = p;
        }
    }
   
   
}
