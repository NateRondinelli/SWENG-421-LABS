using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Rectangle : Shape
    {
        public Rectangle()
        {

        }

        public override void DrawColoredShape(Graphics g, Panel panel1, int x, int y, Bitmap bm)
        {
            //Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(255, red, green, blue));
            g.DrawRectangle(pen, oldX, oldY, x, y);
        }
    }
}
