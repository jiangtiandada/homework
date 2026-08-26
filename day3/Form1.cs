using System.Windows.Forms;

namespace day3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        string[] picArr = { @"./images/cat.jpg", @"./images/bird.jpg", @"./images/eagle.jpg" };
        private int Index = 0;
        List<Button> btnList = new List<Button>();
        private void Init()
        {
            btnList.AddRange([button1, button2, button3]);
            pictureBox2.Image = Image.FromFile(picArr[0]);
            btnList[0].BackColor = Color.SkyBlue;
            btnList[0].ForeColor = Color.White;
            foreach (Button item in btnList)
            {
                item.Click += button_Click;
            }
            button4.Click += button4_Click;
            button5.Click += button5_Click;
        }
        private void button_Click(object sender, EventArgs e)
        {
            foreach (Button item in btnList)
            {
                item.BackColor = Color.Gray;
                item.ForeColor = Color.Black;
            }
            this.Index = btnList.IndexOf((Button)sender);
            pictureBox2.Image = Image.FromFile(picArr[this.Index]);
            ((Button)sender).BackColor = Color.SkyBlue;
            ((Button)sender).ForeColor = Color.White;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Button item in btnList)
            {
                item.BackColor = Color.Gray;
                item.ForeColor = Color.Black;
            }
            this.Index = (this.Index + 1) % 3;
            pictureBox2.Image = Image.FromFile(picArr[this.Index]);
            btnList[this.Index].BackColor = Color.SkyBlue;
            btnList[this.Index].ForeColor = Color.White;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Button item in btnList)
            {
                item.BackColor = Color.Gray;
                item.ForeColor = Color.Black;
            }
            this.Index = this.Index == 0 ? 2 : this.Index - 1;
            //label1.Text = this.Index.ToString();
            pictureBox2.Image = Image.FromFile(picArr[this.Index]);
            btnList[this.Index].BackColor = Color.SkyBlue;
            btnList[this.Index].ForeColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
