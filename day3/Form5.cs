using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day3
{
    public partial class Form5 : Form
    {
        private DateTime timeDown;
        private DateTime timeUp;
        public Form5()
        {
            InitializeComponent();
            InitCtrl();
        }
        private void InitCtrl()
        {
            textBox1.KeyDown += TextBox1_KeyDown;
            textBox1.KeyPress += TextBox1_KeyPress;
            textBox1.KeyUp += TextBox1_KeyUp;
        }

        private void TextBox1_KeyUp(object? sender, KeyEventArgs e)
        { 
            timeUp = DateTime.Now;
            MessageBox.Show((timeUp - timeDown).TotalSeconds.ToString());
        }

        private void TextBox1_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9') e.Handled = true;
        }

        private void TextBox1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C) MessageBox.Show("复制");
            if (e.Control && e.KeyCode == Keys.V) MessageBox.Show("粘贴");
            timeDown = DateTime.Now;
        }
    }
}
