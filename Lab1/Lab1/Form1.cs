namespace Lab1
{
    public partial class Form1 : Form
    {
        Shape shape = new Line();
        Graphics g;
        Graphics gShape;
        bool drawing = false;
        public Bitmap bm;
        Bitmap bmShape;
        Bitmap bm3;

        public Form1()
        {
            InitializeComponent();
            
            g = panel1.CreateGraphics();
            gShape = panel1.CreateGraphics();
            bm = new Bitmap(panel1.Width, panel1.Height, g);
            bmShape = new Bitmap(panel1.Width, panel1.Height, g);
            g.Clear(Color.White);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            
            
            using (Graphics g = Graphics.FromImage(bm))
            {
                shape.DrawColoredShape(g, panel1, e.X, e.Y, bm);

            }
            g = panel1.CreateGraphics();
            g.DrawImage(bm, 0, 0);
            
            drawing = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (drawing)
            {
                Graphics g = panel1.CreateGraphics();
                
                using( gShape = Graphics.FromImage(bmShape) )
                {
                    gShape.Clear(Color.White);
                    gShape.DrawImage(bm, 0, 0);
                    shape.DrawColoredShape(gShape, panel1, e.X, e.Y, bm);
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
            
            shape.oldX = e.X;
            shape.oldY = e.Y;
            shape.red = trackBar1.Value;
            shape.green = trackBar2.Value;
            shape.blue = trackBar3.Value;
            drawing = true;
            
        }
        
        

        private void panel1_Resize(object sender, EventArgs e)  // window resize
        {
            Graphics g = panel1.CreateGraphics();   // redo g
            bm3 = new Bitmap(panel1.Width, panel1.Height);  // temp bitmap
            using( Graphics g3 = Graphics.FromImage(bm3) )  
            {
                g3.DrawImage(bm,0,0);   // use the temp while making bigger one
            }
            
            if( panel1.Width > bm.Width || panel1.Height > bm.Height)   // resize if bigger
            {
                bm = new Bitmap(panel1.Width, panel1.Height, g);
                bmShape = new Bitmap(panel1.Width, panel1.Height, g);
            }
            g.DrawImage(bm, 0, 0);
            using (Graphics g3 = Graphics.FromImage(bm))    // redraw the stuff
            {
                g3.DrawImage(bm3, 0, 0);
            }
        }
    }
}