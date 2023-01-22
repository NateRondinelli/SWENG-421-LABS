using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract internal class Shape
    {
        public int red, green, blue;
        public int oldX, oldY;
        public Shape()
        {

        }

        public abstract void DrawColoredShape( Graphics g, Panel panel1, int x, int y, Bitmap bm);
    }
}
