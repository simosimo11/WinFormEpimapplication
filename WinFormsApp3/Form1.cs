namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            acceuilcc1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            secteurcc1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Height = button2.Height; 
            panel4.Top = button2.Top;
            acceuilcc1.BringToFront(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}