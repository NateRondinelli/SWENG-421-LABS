namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawColoredShape()
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int oldX,oldY;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(255,red,green,blue));
            g.DrawLine(pen, oldX, oldY, e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //Graphics g = panel1.CreateGraphics();
            //Pen pen = new Pen(Color.Red);
            //g.DrawLine(pen, oldX, oldY, e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        int red,green,blue;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            red = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            green = trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            blue = trackBar3.Value;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X;
            oldY = e.Y;
        }
    }
}