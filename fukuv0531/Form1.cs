namespace fukuv0531
{
    public partial class Form1 : Form
    {
        int vy = 15;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vy = -15;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vy = 15;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top = label1.Top + vy;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "���v�� �I��";
            vy = 0;
            timer1.Enabled = false;
        }
    }
}