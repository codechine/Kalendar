using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kalendář
{
    //třída pro uchovávání vlastností eventů
    public class _event
    {
        public DateTime date_from = DateTime.Now;
        public DateTime date_to = DateTime.Now;
        public string name = "Nová událost";
        public int lenght = 30;
        public int time = DateTime.Now.Hour * 60 + DateTime.Now.Minute;
        public bool whole_day = false;
        public int priority = 1;
        public bool deleted = false;
    }
    //třída která udržuje události v jednotlivých dnech
    public class Day
    {
        public List<_event> _events = new List<_event>();
        public DateTime date = new DateTime();
        //fukce pro zkontrolování zda je ve dnu plný počet událostí
        public bool check_day()
        {
            int x = 0;
            foreach (_event _Event in _events) 
                if (!_Event.deleted)
                    x++;
            if (x < 8)
                return true;
            else
                return false;
        }
        //funkce pro třídění událostí ve dnu
        public void sort()
        {

            for (int i = 0; i < _events.Count; i++)
            {
                for (int j = i+1; j < _events.Count; j++)
                {
                    if (_events[i].time < _events[j].time)
                    {
                        _events.Insert(i, _events[j]);
                        _events.RemoveAt(j + 1);
                    }
                    if (_events[i].time == _events[j].time)
                    {
                        if (_events[i].priority < _events[j].priority)
                        {
                            _events.Insert(i, _events[j]);
                            _events.RemoveAt(j + 1);
                        }
                    }
                }
            }
        }
    }
    //hlavní třida
    public class kalendar
    {
        public Form1 form;
        public Label lbl_year_month;
        List<Control> old_btns = new List<Control>();
        public List<Day> Days = new List<Day>();

        List<string> svatky = new List<string>();
        List<string> svatky_datum = new List<string>();
        public int selected_month = DateTime.Now.Month;
        public int selected_year = DateTime.Now.Year;
        string[] mesice = new string[]
        {
            "Leden", "Únor",
            "Březen","Duben",
            "Květen", "Červen",
            "Červenec", "Srpen",
            "Září", "Říjen",
            "Listopad", "Prosinec"
        };
        //funkce pro vykreslování jednotlivých dnů v kalendáři
        public void load_mesic()
        {
            int dny_count = DateTime.DaysInMonth(selected_year, selected_month);
            int cord_x = 45;
            int cord_y = 50;

            lbl_year_month.Text = selected_year.ToString() + " " + mesice[selected_month - 1];
            if (old_btns.Count != 0)
                foreach (Control old_btn in old_btns)
                    form.Controls.Remove(old_btn);
            old_btns = new List<Control>();

            for (int i = 1; i <= dny_count; i++)
            {
                Button btn = new Button { TextAlign = ContentAlignment.TopCenter };
                btn.Text = i.ToString();
                btn.Height = 100;
                btn.Width = 100;
                btn.Tag = i;
                btn.Location = new Point(cord_x, cord_y);
                btn.Click += Den_Click;
                form.Controls.Add(btn);
                cord_x += 100;
                if (i % 7 == 0)
                {
                    cord_x = 45;
                    cord_y += 100;
                }
                old_btns.Add(btn);
            }
        }
        //funkce pro načítání svátků ze souboru
        public void load_svátky()
        {
            StreamReader reader = new StreamReader("Svátky.txt");
            string sv_unedit = reader.ReadToEnd();
            string[] sv_edit = sv_unedit.Split('-');
            for (int i = 0; i < sv_edit.Length; i++)
            {
                if (sv_edit[i].Contains("\n"))
                    sv_edit[i] = sv_edit[i].Remove(0, 1);

                if (i % 2 == 0)
                    svatky_datum.Add(sv_edit[i]);
                else svatky.Add(sv_edit[i]);
            }
        }
        //funkce pro zobrazování konkrétního dne v novém formu
        private void Den_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DateTime date = new DateTime(selected_year, selected_month, (int)btn.Tag);
            string svatek = "nikdo nemá";
            for (int i = 0; i < svatky.Count; i++)
            {
                string datum = btn.Tag + "." + selected_month.ToString() + ".";
                if (svatky_datum[i] == datum)
                {
                    svatek = svatky[i];
                    break;
                }
            }

            Den Form_den = new Den();

            foreach (Day day in Days)
            {
                if (day.date == date) 
                    Form_den.day = day;
            }
            if (Form_den.day == null)
            {
                Days.Add(new Day { date = date });
                Form_den.day = Days[Days.Count - 1];
            }
            
            Form_den.Day = (int)btn.Tag;
            Form_den.Month = selected_month;
            Form_den.Year = (int)btn.Tag;
            Form_den.svatek = svatek;
            Form_den.ShowDialog();

            for (int i = 0; i < Days.Count; i++)
            {
                if (Days[i].date == date)
                    Days[i] = Form_den.day;
            }
        }
    }
}
