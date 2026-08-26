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

namespace day3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Initxy();
            Initisnum();
            InitEnter();
        }
        private void Initxy()
        {
            this.MouseMove += Form3_MouseMove;
        }

        private void Form3_MouseMove(object? sender, MouseEventArgs e)
        {
            lab1.Text = e.X.ToString(); lab2.Text = e.Y.ToString();
        }
        private void Initisnum()
        {
            textBox1.GotFocus += TextBox1_GotFocus;
            textBox1.Leave += TextBox1_Leave;
            button1.GotFocus += Button1_GotFocus;
            button1.Leave += Button1_Leave;
        }
        private void InitEnter()
        {
            textBox1.KeyUp += TextBox1_KeyUp;
        }

        private void TextBox1_KeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) MessageBox.Show("模拟提交");
        }

        private void Button1_Leave(object? sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.White;
            (sender as Button).ForeColor = Color.Black;
        }

        private void Button1_GotFocus(object? sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Orange;
            (sender as Button).ForeColor = Color.Blue;
        }

        private void TextBox1_Leave(object? sender, EventArgs e)
        {
            if (Regex.IsMatch((sender as TextBox).Text, @"^1[1-9]\d{9}$"))
            {
                lab4.Visible = true;
            }
            else lab3.Visible = true;
            (sender as TextBox).BackColor = Color.White;
            (sender as TextBox).ForeColor = Color.Black;
        }

        private void TextBox1_GotFocus(object? sender, EventArgs e)
        {
            lab3.Visible = false;
            lab4.Visible = false;
            (sender as TextBox).BackColor = Color.Orange;
            (sender as TextBox).ForeColor = Color.Blue;
        }
    }
}
