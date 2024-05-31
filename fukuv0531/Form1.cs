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
            label1.Text = "è„Ç…ìÆÇ¢ÇΩÇÊ";
            label1.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vy = 15;
            label1.Text = "â∫Ç…ìÆÇ¢ÇΩÇÊ";
            label1.ForeColor = Color.Brown;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top = label1.Top + vy;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "ç≤ãvä‘ óIê∂";
            timer1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vy = 15;
            label1.Left = label1.Left + vy;
            label1.Text = "âEÇ…ìÆÇ¢ÇΩÇÊ";
            label1.ForeColor = Color.Cyan;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vy = -15;
            label1.Left = label1.Left + vy;
            label1.Text = "ç∂Ç…ìÆÇ¢ÇΩÇÊ";
            label1.ForeColor = Color.YellowGreen;
        }
    }
}