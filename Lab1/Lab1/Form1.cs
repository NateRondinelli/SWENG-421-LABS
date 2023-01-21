namespace Lab1
{
    public partial class Form1 : Form
    {
        Shape shape = new Line();
        //int red, green, blue;
        public Graphics g = new );
        //int oldX, oldY;
        bool drawing = false;
        public Bitmap bm;
        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(panel1.Width, panel1.Height);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            shape.DrawColoredShape(g,panel1, e.X, e.Y, bm );
            
            bm = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bm);
            g.DrawImage(bm, 0, 0);

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                //panel1.Invalidate();
                
                shape.DrawColoredShape(g, panel1, e.X, e.Y, bm);
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

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

    }
}