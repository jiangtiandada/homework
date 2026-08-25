using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            init();
        }
        string[] picArr = { @"./images/cat.jpg", @"./images/bird.jpg", @"./images/eagle.jpg" };
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button_Click(object sender, EventArgs e)
        {
            foreach (Button item in tableLayoutPanel1.Controls)
            {
                item.BackColor = Color.Gray;
                item.ForeColor = Color.Black;
            }
            int index = tableLayoutPanel1.Controls.IndexOf((Button)sender);
            pictureBox1.Image = Image.FromFile(picArr[index]);
            ((Button)sender).BackColor = Color.SkyBlue;
            ((Button)sender).ForeColor = Color.White;
        }
        private void init()
        {
            tableLayoutPanel1.Controls[0].BackColor = Color.SkyBlue;
            tableLayoutPanel1.Controls[0].ForeColor = Color.White;
            pictureBox1.Image = Image.FromFile(picArr[0]);
            foreach(Button item in tableLayoutPanel1.Controls)
            {
                item.Click += button_Click;
            }
        }
    }
}
