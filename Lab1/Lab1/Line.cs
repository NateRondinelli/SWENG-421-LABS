// Christopher Brennen
// Nate Rondinelli

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    internal class Line : Shape
    {
        public Line()
        {

        }

        public override void DrawColoredShape(Graphics g, int x, int y)
        {
            
            Pen pen = new Pen(Color.FromArgb(255, red, green, blue));
            g.DrawLine(pen, oldX, oldY, x, y);
        }
    }
}
