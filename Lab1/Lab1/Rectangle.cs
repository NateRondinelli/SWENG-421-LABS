// Christopher Brennen
// Nate Rondinelli

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

        public override void DrawColoredShape(Graphics g, int x, int y)
        {
            
            int oldX2, oldY2;
            if (x < oldX)
            {
                int t = x;
                x= oldX;
                oldX2 = t;
            }
            else
            {
                oldX2 = oldX;
            }
            if (y < oldY)
            {
                int t = y;
                y = oldY;
                oldY2 = t;
            }
            else
            {
                oldY2 = oldY;
            }
            Pen pen = new Pen(Color.FromArgb(255, red, green, blue));
            g.DrawRectangle(pen, oldX2, oldY2, x-oldX2, y-oldY2);
        }
    }
}
