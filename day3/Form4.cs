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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            InitEsc();
        }
        private void InitEsc()
        {
            this.KeyDown += Form4_KeyDown;
        }

        private void Form4_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }
    }
}
