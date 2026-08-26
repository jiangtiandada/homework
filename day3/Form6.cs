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
    public partial class Form6 : Form
    {
        int speed = 5;
        public Form6()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            this.KeyDown += Form6_KeyDown;
            this.KeyPreview = true;
        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            Point b1 = button1.Location;
            //MessageBox.Show(b1.ToString());
            switch (e.KeyCode)
            {
                case Keys.W:
                    if(b1.Y>=0)b1.Y -= speed;
                    break;
                case Keys.S:
                    if(b1.Y<=400)b1.Y += speed;
                    break;
                case Keys.A:
                    if(b1.X>=0)b1.X -= speed;
                    break;
                case Keys.D:
                    if(b1.X<=830)b1.X += speed;
                    break;
                default:
                    break;
            }
            button1.Location = b1;
            //MessageBox.Show(b1.ToString());
        }
    }
    } 
