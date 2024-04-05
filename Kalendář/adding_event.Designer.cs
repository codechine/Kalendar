namespace Kalendář
{
    partial class adding_event
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_od = new System.Windows.Forms.Label();
            this.dateTimePicker_od = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_do = new System.Windows.Forms.DateTimePicker();
            this.label_do = new System.Windows.Forms.Label();
            this.dateTimePicker_time = new System.Windows.Forms.DateTimePicker();
            this.label_time = new System.Windows.Forms.Label();
            this.dateTimePicker_lenght = new System.Windows.Forms.DateTimePicker();
            this.label_lenght = new System.Windows.Forms.Label();
            this.checkBox_ent_day = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nová událost:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Název / Popis:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_name
            // 
            this.textBox_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_name.Location = new System.Drawing.Point(0, 36);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(205, 40);
            this.textBox_name.TabIndex = 3;
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_od
            // 
            this.label_od.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_od.Location = new System.Drawing.Point(0, 76);
            this.label_od.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_od.Name = "label_od";
            this.label_od.Size = new System.Drawing.Size(205, 15);
            this.label_od.TabIndex = 4;
            this.label_od.Text = "Datum:";
            // 
            // dateTimePicker_od
            // 
            this.dateTimePicker_od.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker_od.Location = new System.Drawing.Point(0, 91);
            this.dateTimePicker_od.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_od.Name = "dateTimePicker_od";
            this.dateTimePicker_od.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker_od.TabIndex = 5;
            // 
            // dateTimePicker_do
            // 
            this.dateTimePicker_do.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker_do.Location = new System.Drawing.Point(0, 126);
            this.dateTimePicker_do.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_do.Name = "dateTimePicker_do";
            this.dateTimePicker_do.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker_do.TabIndex = 7;
            this.dateTimePicker_do.Visible = false;
            // 
            // label_do
            // 
            this.label_do.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_do.Location = new System.Drawing.Point(0, 111);
            this.label_do.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_do.Name = "label_do";
            this.label_do.Size = new System.Drawing.Size(205, 15);
            this.label_do.TabIndex = 6;
            this.label_do.Text = "DO:";
            this.label_do.Visible = false;
            // 
            // dateTimePicker_time
            // 
            this.dateTimePicker_time.CustomFormat = "HH:mm";
            this.dateTimePicker_time.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_time.Location = new System.Drawing.Point(0, 161);
            this.dateTimePicker_time.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_time.Name = "dateTimePicker_time";
            this.dateTimePicker_time.ShowUpDown = true;
            this.dateTimePicker_time.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker_time.TabIndex = 9;
            this.dateTimePicker_time.Value = new System.DateTime(2022, 12, 15, 9, 10, 55, 0);
            // 
            // label_time
            // 
            this.label_time.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_time.Location = new System.Drawing.Point(0, 146);
            this.label_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(205, 15);
            this.label_time.TabIndex = 8;
            this.label_time.Text = "Čas:";
            // 
            // dateTimePicker_lenght
            // 
            this.dateTimePicker_lenght.CustomFormat = "HH:mm";
            this.dateTimePicker_lenght.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker_lenght.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_lenght.Location = new System.Drawing.Point(0, 196);
            this.dateTimePicker_lenght.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_lenght.Name = "dateTimePicker_lenght";
            this.dateTimePicker_lenght.ShowUpDown = true;
            this.dateTimePicker_lenght.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker_lenght.TabIndex = 11;
            this.dateTimePicker_lenght.Value = new System.DateTime(2022, 12, 15, 0, 30, 0, 0);
            // 
            // label_lenght
            // 
            this.label_lenght.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_lenght.Location = new System.Drawing.Point(0, 181);
            this.label_lenght.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_lenght.Name = "label_lenght";
            this.label_lenght.Size = new System.Drawing.Size(205, 15);
            this.label_lenght.TabIndex = 10;
            this.label_lenght.Text = "Doba trvání:";
            // 
            // checkBox_ent_day
            // 
            this.checkBox_ent_day.AutoSize = true;
            this.checkBox_ent_day.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_ent_day.Location = new System.Drawing.Point(0, 216);
            this.checkBox_ent_day.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_ent_day.Name = "checkBox_ent_day";
            this.checkBox_ent_day.Size = new System.Drawing.Size(205, 17);
            this.checkBox_ent_day.TabIndex = 12;
            this.checkBox_ent_day.Text = "Celý den";
            this.checkBox_ent_day.UseVisualStyleBackColor = true;
            this.checkBox_ent_day.CheckedChanged += new System.EventHandler(this.checkBox_ent_day_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton1.Location = new System.Drawing.Point(0, 233);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(205, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Priorita 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton2.Location = new System.Drawing.Point(0, 250);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(205, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "Priorita 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton3.Location = new System.Drawing.Point(0, 267);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(205, 17);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.Text = "Priorita 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(0, 291);
            this.button.Margin = new System.Windows.Forms.Padding(2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(205, 32);
            this.button.TabIndex = 16;
            this.button.Text = "Potvrdit událost";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // adding_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 323);
            this.Controls.Add(this.button);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox_ent_day);
            this.Controls.Add(this.dateTimePicker_lenght);
            this.Controls.Add(this.label_lenght);
            this.Controls.Add(this.dateTimePicker_time);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.dateTimePicker_do);
            this.Controls.Add(this.label_do);
            this.Controls.Add(this.dateTimePicker_od);
            this.Controls.Add(this.label_od);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "adding_event";
            this.Text = "Nová událost";
            this.Load += new System.EventHandler(this.adding_event_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_od;
        private System.Windows.Forms.DateTimePicker dateTimePicker_od;
        private System.Windows.Forms.DateTimePicker dateTimePicker_do;
        private System.Windows.Forms.Label label_do;
        private System.Windows.Forms.DateTimePicker dateTimePicker_time;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.DateTimePicker dateTimePicker_lenght;
        private System.Windows.Forms.Label label_lenght;
        private System.Windows.Forms.CheckBox checkBox_ent_day;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button;
    }
}