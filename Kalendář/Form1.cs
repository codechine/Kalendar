using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalendář
{
    public partial class Form1 : Form
        {
            kalendar kal = new kalendar();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kal.form = this;
            kal.lbl_year_month = label_month_year;
            kal.load_svátky();
            kal.load_mesic();

        }

        private void button_right_Click(object sender, EventArgs e)
        {
            if (kal.selected_month == 12)
            {
                kal.selected_month = 1;
                kal.selected_year++;
            }
            else kal.selected_month++;
            kal.load_mesic();
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            if (kal.selected_month == 1)
            {
                kal.selected_month = 12;
                kal.selected_year--;
            }
            else kal.selected_month--;
            kal.load_mesic();
        }

        private void button_bin_Click(object sender, EventArgs e)
        {
            Bin bin = new Bin();
            bin.Days = kal.Days;
            bin.ShowDialog();
        }
    }
}
