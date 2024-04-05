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
    public partial class Den : Form
    {
        public Day day = null;
        public int Day;
        public int Month;
        public int Year;
        public string svatek;
        string[] nazvy_dnu = new string[]
        { "Nedělě", "Pondělí", "Úterý", "Středa", "Čtvrtek", "Pátek", "Sobota" };

        public Den()
        {
            InitializeComponent();
        }

        private void Den_Load(object sender, EventArgs e)
        {
            lbl_day.Text = Day.ToString();
            lbl_day_name.Text = nazvy_dnu[(int)new DateTime(Year, Month, Day).DayOfWeek];
            lbl_svatek.Text = "Svátek: " + svatek;

            day.sort();
            foreach (_event Event in day._events)
                if(!Event.deleted)
                    kresleni_udalosti(Event);
        }

        private void button_new_event_Click(object sender, EventArgs e)
        {
            if (!day.check_day())
            {
                MessageBox.Show("Dosažen maximální počet eventů!v amogus");
                return;
            }
            adding_event event_add = new adding_event();
            event_add.ShowDialog();
            if (event_add.Event_out != null) 
                day._events.Add(event_add.Event_out);
            Close();
        }

        private void button_upravit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            adding_event event_edit = new adding_event();
            event_edit.Event = (_event)btn.Tag;
            event_edit.ShowDialog();
            if (event_edit.Event_out != null)
            {
                int index = day._events.IndexOf((_event)btn.Tag);
                if (index != -1)
                    day._events[index] = event_edit.Event_out;
            }
            Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _event _Event = (_event)btn.Tag;
            _Event.deleted = true;

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

            if(ev.whole_day)
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

            Button btn_del = new Button();
            btn_del.Dock = DockStyle.Bottom;
            btn_del.Text = "Odstranit";
            btn_del.BackColor = Color.White;
            btn_del.Tag = ev;
            btn_del.Height = 25;
            btn_del.Width = 340;
            btn_del.Click += button_delete_Click;
            panel.Controls.Add(btn_del);

            Button btn = new Button();
            btn.Dock = DockStyle.Bottom;
            btn.Text = "Upravit";
            btn.BackColor = Color.White;
            btn.Tag = ev;
            btn.Height = 25;
            btn.Width = 340;
            btn.Click += button_upravit_Click;
            panel.Controls.Add(btn);

            //panel1.Height += 100;
            //this.Height +=50;
        }
    }
}
