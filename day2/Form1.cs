namespace day2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "ON")
            {
                btn.Text = "OFF";
                pictureBox1.Image = Image.FromFile(@"./images/on.png");
            }
            else
            {
                btn.Text = "ON";
                pictureBox1.Image = Image.FromFile(@"./images/off.png");

            }
        }
        private void init()
        {
            button1.Text = "ON";
            pictureBox1.Image = Image.FromFile(@"./images/off.png");
        }
    }
}
