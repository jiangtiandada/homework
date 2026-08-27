using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day4
{
    public partial class Form3 : Form
    {
        private List<Dictionary<string, dynamic>> data { get; set; }
        public Form3()
        {
            InitializeComponent();
            Initselect();
        }
        private void Initselect()
        {
            data = new List<Dictionary<string, dynamic>>()
            {
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 1,
                    ["name"] = "广东省",
                    ["parent_id"] = 0
                },
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 2,
                    ["name"] = "深圳市",
                    ["parent_id"] = 1
                },
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 3,
                    ["name"] = "广州市",
                    ["parent_id"] = 1
                },
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 4,
                    ["name"] = "广西省",
                    ["parent_id"] = 0
                },
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 5,
                    ["name"] = "桂林市",
                    ["parent_id"] = 4
                },
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 6,
                    ["name"] = "柳州市",
                    ["parent_id"] = 4
                }
            };
            comboBox1.Items.Clear();
            comboBox1.Items.Add((data.FindAll(item => item["parent_id"] == 0)).ToArray());
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {

        }
    }
}
