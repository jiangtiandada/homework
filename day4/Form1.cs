using System.Text.RegularExpressions;

namespace day4
{
    public partial class Form1 : Form
    {
        private List<string> CobItems = new List<string>
        {
        "11112222333","22222","1111144444","222222444","22222","11111444","444444","444444","333333"
        };
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(CobItems.ToArray());
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lab1.Visible = true;
            lab1.Text = (sender as ListBox).SelectedItem.ToString();
        }

        private int max_length = 10;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > max_length)
            {
                label1.Visible = true;
                textBox1.Text = textBox1.Text.Substring(0, max_length);
                textBox1.SelectionStart = max_length;
            }
            else if (textBox1.Text.Length < 10) label1.Visible = false;
            List<string> newList = new List<string>();
            newList = CobItems.FindAll(item => item.Contains(textBox1.Text));
            listBox1.Items.Clear();
            listBox1.Items.AddRange(newList.ToArray());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lab2.Visible = true;
            int num = 0;
            if (Regex.IsMatch(textBox2.Text, @"\d")) num++;
            if (Regex.IsMatch(textBox2.Text, @"[a-zA-Z]")) num++;
            if (Regex.IsMatch(textBox2.Text, @"(\W|_)")) num++;
            if (num == 1)
            {
                lab2.Text = "弱";
                lab2.BackColor = Color.Blue;
            }
            else if (num == 2)
            {
                lab2.Text = "中";
                lab2.BackColor = Color.Yellow;
            }
            else
            {
                lab2.Text = "强";
                lab2.BackColor = Color.Red;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string content = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(content)) return; // 处理空白情况
            content = content.Replace(",", "");
            int resNum = int.Parse(content);
            string resStr = resNum.ToString("#,#");
            (sender as TextBox).Text = resStr;
            (sender as TextBox).SelectionStart = resStr.Length;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string content = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(content)) return;
            content = content.ToUpper();
            (sender as TextBox).Text = content;
            (sender as TextBox).SelectionStart = content.Length;
        }
    }
}
