// Christopher Brennen
// Nate Rondinelli

namespace Lab1
{
    public partial class Form1 : Form
    {
        Shape shape = new Line();
        Graphics g, gShape, g3;
        bool isDrawing = false;
        Bitmap bm, bmShape, bm3;


        public Form1()
        {
            InitializeComponent();
            
            // instantiation
            g = panel1.CreateGraphics();
            gShape = panel1.CreateGraphics();
            bm = new Bitmap(panel1.Width, panel1.Height, g);
            bmShape = new Bitmap(panel1.Width, panel1.Height, g);
            g.Clear(Color.White);
            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // draws to background graphics upon completing draw
            using (Graphics g = Graphics.FromImage(bm))
            {
                shape.DrawColoredShape(g, e.X, e.Y);
            }
            g = panel1.CreateGraphics();
            g.DrawImage(bm, 0, 0);
            
            isDrawing = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (isDrawing)    // tracks mouse hold
            {
                Graphics g = panel1.CreateGraphics();
                
                using( gShape = Graphics.FromImage(bmShape) )   // uses a bitmap for just the new shape
                {
                    gShape.Clear(Color.White);  // clears and redraws background bitmap
                    gShape.DrawImage(bm, 0, 0);
                    shape.DrawColoredShape(gShape, e.X, e.Y);
                    g.DrawImage(bmShape,0,0);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shape = new Line();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shape = new Rectangle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shape = new Ellipse();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // sets current values in order to draw
            shape.oldX = e.X;
            shape.oldY = e.Y;
            shape.red = trackBar1.Value;
            shape.green = trackBar2.Value;
            shape.blue = trackBar3.Value;
            isDrawing = true;
        }
        
        private void panel1_Resize(object sender, EventArgs e)  // window resize
        {
            g = panel1.CreateGraphics();                    // redo g
            bm3 = new Bitmap(panel1.Width, panel1.Height);  // temp bitmap
            using(g3 = Graphics.FromImage(bm3) )  
            {
                g3.DrawImage(bm,0,0);   // use the temp while making bigger one
            }
            
            if( panel1.Width > bm.Width || panel1.Height > bm.Height)   // resize if bigger
            {
                bm = new Bitmap(Math.Max(panel1.Width, bm.Width), Math.Max(panel1.Height, bm.Height), g);
                bmShape = new Bitmap(Math.Max(panel1.Width, bmShape.Width), Math.Max(panel1.Height, bmShape.Height), g);
            }
            g.DrawImage(bm, 0, 0);
            using (g3 = Graphics.FromImage(bm))    // redraw the content
            {
                g3.DrawImage(bm3, 0, 0);
            }
        }
    }
}