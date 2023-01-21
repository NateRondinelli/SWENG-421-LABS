namespace Lab1
{
    public partial class Form1 : Form
    {
        Shape shape = new Line();
        //int red, green, blue;
        Graphics g;
        Graphics gShape;
        //int oldX, oldY;
        bool drawing = false;
        public Bitmap bm;

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bm);
            gShape = Graphics.FromImage(bm);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            shape.DrawColoredShape(g,panel1, e.X, e.Y, bm );

            //bm = new Bitmap(panel1.Width, panel1.Height, g);
            panel1.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, panel1.Width,panel1.Height));
            g = Graphics.FromImage(bm);
            g.DrawImage(bm, 0, 0);
            //panel1.BackgroundImage = bm;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {

                //panel1.Refresh();
                //g = Graphics.FromImage(bm);
                g = panel1.CreateGraphics();
                g.DrawImage(bm, 0, 0);
                shape.DrawColoredShape(gShape, panel1, e.X, e.Y, bm);


                //gShape.Invalidate();
                //g.DrawImage(bm, 0, 0);
                
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
            panel1.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, panel1.Width, panel1.Height));
            shape.oldX = e.X;
            shape.oldY = e.Y;
            shape.red = trackBar1.Value;
            shape.green = trackBar2.Value;
            shape.blue = trackBar3.Value;
            drawing = true;
        }

    }
}