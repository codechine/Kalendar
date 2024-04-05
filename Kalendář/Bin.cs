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
    public partial class Bin : Form
    {
        public List<Day> Days;

        public Bin()
        {
            InitializeComponent();
        }

        private void Bin_Load(object sender, EventArgs e)
        {
            foreach (Day day in Days)
            {
                foreach (_event _Event in day._events)
                {
                    if (_Event.deleted)
                        kresleni_udalosti(_Event);
                }
            }
        }

        private void button_obnovit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _event _Event = (_event)btn.Tag;

            for (int i = 0; i < Days.Count; i++)
            {
                if (Days[i].date == _Event.date_from)
                    if (!Days[i].check_day())
                    {
                        MessageBox.Show("Dosažen maximální počet eventů!");
                        return;
                    }
            }

            _Event.deleted = false;

            Close(); 
        }

        private void kresleni_udalosti(_event ev)
        {
            Label label = new Label();
            Panel panel = new Panel();
            panel.Dock = DockStyle.Top;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.AutoSize = true;
            if (ev.priority == 1) panel.BackColor = Color.Green;
            if (ev.priority == 2) panel.BackColor = Color.Yellow;
            if (ev.priority == 3) panel.BackColor = Color.Red;
            panel1.Controls.Add(panel);

            if (ev.whole_day)
            {
                label = new Label();
                label.Text = "Celodenní";
                label.Dock = DockStyle.Top;
                label.BackColor = Color.Transparent;
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.MiddleLeft;
                panel.Controls.Add(label);
            }
            else
            {
                label = new Label();
                label.Text = "Doba trvání: " + (int)(ev.lenght / 60) + ":" + ev.lenght % 60;
                label.Dock = DockStyle.Top;
                label.BackColor = Color.Transparent;
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.MiddleLeft;
                panel.Controls.Add(label);

                label = new Label();
                label.Text = "Začátek události: " + (int)(ev.time / 60) + ":" + ev.time % 60;
                label.Dock = DockStyle.Top;
                label.BackColor = Color.Transparent;
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.MiddleLeft;
                panel.Controls.Add(label);
            }

            label = new Label();
            label.Dock = DockStyle.Top;
            label.BackColor = Color.Transparent;
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = ev.name;
            panel.Controls.Add(label);

            Button btn = new Button();
            btn.Dock = DockStyle.Bottom;
            btn.Text = "Obnovit";
            btn.BackColor = Color.White;
            btn.Tag = ev;
            btn.Height = 25;
            btn.Width = 340;
            btn.Click += button_obnovit_Click;
            panel.Controls.Add(btn);

            //panel1.Height += 100;
            //this.Height +=50;
        }
    }
}
