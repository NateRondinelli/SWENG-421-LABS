using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Ellipse : Shape
    {
        public Ellipse()
        {

        }

        public override void DrawColoredShape(Graphics g, Panel panel1, int x, int y, Bitmap bm)
        {
            //Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(255, red, green, blue));
            g.DrawEllipse(pen, oldX, oldY, x, y);
        }
    }
}
