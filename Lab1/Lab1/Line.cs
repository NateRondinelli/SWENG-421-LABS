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

        public override void DrawColoredShape(Graphics g, Panel panel1, int x, int y, Bitmap bm)
        {
            //g = panel1.CreateGraphics();
            //g = Graphics.FromImage(bm);
            //g.DrawImage(bm, 0, 0);
            //panel1.Refresh();
            
            Pen pen = new Pen(Color.FromArgb(255, red, green, blue));
            g.DrawLine(pen, oldX, oldY, x, y);
        }
    }
}
