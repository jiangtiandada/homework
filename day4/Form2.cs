using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day4
{
    public partial class Form2 : Form
    {
        List<Dictionary<string, Control>> conList = new();
        public Form2()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            conList.Add(new Dictionary<string, Control>()
            {
                ["price"] = label5,
                ["count"] = textBox1
            });
            conList.Add(new Dictionary<string, Control>()
            {
                ["price"] = label7,
                ["count"] = textBox2
            });
            textBox1.TextChanged += textBox_TextChanged;
            textBox2.TextChanged += textBox_TextChanged;
            button1.Click += Button1_Click;
            button3.Click += Button1_Click;
            button2.Click += Button2_Click;
            button4.Click += Button2_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            if((sender as Button) == button1)
            {
                bool istrue = int.TryParse(textBox1.Text,out int i);
                if (i >= 1) i--;
                textBox1.Text = i.ToString();
            }
            else if((sender as Button) == button3)
            {
                bool istrue = int.TryParse(textBox2.Text,out int i);
                if (i >= 1) i--;
                textBox2.Text = i.ToString();
            }
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            if ((sender as Button) == button2)
            {
                bool istrue = int.TryParse(textBox1.Text,out int i);
                i++;
                textBox1.Text = i.ToString();
            }
            else if((sender as Button) == button4)
            {
                bool istrue = int.TryParse(textBox2.Text, out int i);
                i++;
                textBox2.Text = i.ToString();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var con in conList)
           {
                if (Regex.IsMatch(con["count"].Text, @"[a-zA-Z\W_]")) con["count"].Text = "";
                bool istrue = int.TryParse(con["count"].Text, out int i);
                if (!istrue)
                {
                    //con["count"].Text = "0";
                }
                sum += int.Parse(con["price"].Text) * i;
           }
            label9.Text = sum.ToString();
            label9.Visible = true;
        }
    }
}
