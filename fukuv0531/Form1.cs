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
            label1.Text = "上に動いたよ";
            label1.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vy = 15;
            label1.Text = "下に動いたよ";
            label1.ForeColor = Color.Brown;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top = label1.Top + vy;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "佐久間 悠生";
            timer1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vy = 15;
            label1.Left = label1.Left + vy;
            label1.Text = "右に動いたよ";
            label1.ForeColor = Color.Cyan;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vy = -15;
            label1.Left = label1.Left + vy;
            label1.Text = "左に動いたよ";
            label1.ForeColor = Color.YellowGreen;
        }
    }
}