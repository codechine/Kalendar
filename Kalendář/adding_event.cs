using System;
using System.Windows.Forms;

namespace Kalendář
{
    public partial class adding_event : Form
    {
        public _event Event = null;
        public _event Event_out = null;

        public adding_event()
        {
            InitializeComponent();
        }

        private void checkBox_ent_day_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ent_day.Checked)
            {
                label_od.Text = "OD:";
                dateTimePicker_do.Visible = true;
                label_do.Visible = true;
                dateTimePicker_time.Visible = false;
                label_time.Visible = false;
                dateTimePicker_lenght.Visible = false;
                label_lenght.Visible = false;
            }
            else
            {
                label_od.Text = "Datum:";
                dateTimePicker_do.Visible = false;
                label_do.Visible = false;
                dateTimePicker_time.Visible = true;
                label_time.Visible = true;
                dateTimePicker_lenght.Visible = true;
                label_lenght.Visible = true;
            }
        }

        private void adding_event_Load(object sender, EventArgs e)
        {
            if (Event != null)
            {
                this.Text = "Upravování události";
                label1.Text = "Úprava události:";
                button.Text = "Potvrdit úpravu";
                textBox_name.Text = Event.name;
                dateTimePicker_od.Value = Event.date_from;
                dateTimePicker_time.Value = Event.date_to;
                dateTimePicker_time.Value = new DateTime(2000, 1, 1, (int)(Event.time / 60), Event.time % 60, 0);
                dateTimePicker_lenght.Value = new DateTime(2000, 1, 1, (int)(Event.lenght / 60), Event.lenght % 60, 0);
                checkBox_ent_day.Checked = Event.whole_day;
                if (Event.priority == 1) radioButton1.Checked = true;
                else
                if (Event.priority == 2) radioButton2.Checked = true;
                else
                if (Event.priority == 3) radioButton3.Checked = true;

                if (checkBox_ent_day.Checked)
                {
                    label_od.Text = "OD:";
                    dateTimePicker_do.Visible = true;
                    label_do.Visible = true;
                    dateTimePicker_time.Visible = false;
                    label_time.Visible = false;
                    dateTimePicker_lenght.Visible = false;
                    label_lenght.Visible = false;
                }
                else
                {
                    label_od.Text = "Datum:";
                    dateTimePicker_do.Visible = false;
                    label_do.Visible = false;
                    dateTimePicker_time.Visible = true;
                    label_time.Visible = true;
                    dateTimePicker_lenght.Visible = true;
                    label_lenght.Visible = true;
                }                
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Event_out = new _event();
            Event_out.date_from = dateTimePicker_od.Value;
            Event_out.date_to = dateTimePicker_do.Value;
            Event_out.name = textBox_name.Text;
            Event_out.lenght = dateTimePicker_lenght.Value.Hour * 60 + dateTimePicker_lenght.Value.Minute;
            Event_out.time = dateTimePicker_time.Value.Hour * 60 + dateTimePicker_time.Value.Minute;
            Event_out.whole_day = checkBox_ent_day.Checked;
            if (radioButton1.Checked == true) Event_out.priority = 1;
            else
            if (radioButton2.Checked == true) Event_out.priority = 2;
            else
            if (radioButton3.Checked == true) Event_out.priority = 3;
            Close();
        }

    }
}
